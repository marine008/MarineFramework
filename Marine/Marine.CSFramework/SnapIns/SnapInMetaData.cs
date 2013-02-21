using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
using Marine.CSFramework.Attributes;

namespace Marine.CSFramework.SnapIns
{
    public class SnapInMetaData
    {
        private string _company;
        private string _decription;
        private string[] _developers;
        private Bitmap _image;
        private string[] _productFamilies;
        private string _title;
        private Version _version;
        private static Bitmap _defaultImage;

        static SnapInMetaData()
        {
            ResourceManager resource = new ResourceManager("Marine.Image", System.Reflection.Assembly.GetExecutingAssembly());
            _defaultImage = (Bitmap)resource.GetObject("Marine2");
        }

        public SnapInMetaData(Type type)
        {
            ExtractAttributesFromMetaData(type);
        }

        public string CompanyName
        {
            get { return _company; }
        }

        public string Description
        {
            get { return _decription; }
        }

        public string[] Developers
        {
            get { return _developers; }
        }

        public Bitmap Image
        {
            get { return _image; }
        }

        public string[] ProductFamilies
        {
            get { return _productFamilies; }
        }

        public string Title
        {
            get { return _title; }
        }

        public Version Version
        {
            get { return _version; }
        }

        private void ExtractAttributesFromMetaData(Type type)
        {
            try
            {
                SnapInAttributeReader reader = new SnapInAttributeReader(type);
                if (reader != null)
                {
                    SnapInCompanyAttribute companyAttribute = reader.GetSnapInCompanyAttribute();
                    if (companyAttribute != null)
                        _company = companyAttribute.CompanyName;

                    SnapInDescriptionAttribute descriptionAttribute = reader.GetSnapInDescriptionAttribute();
                    if (descriptionAttribute != null)
                        _decription = descriptionAttribute.Description;

                    SnapInDevelopersAttribute developersAttribute = reader.GetSnapInDevelopersAttributes();
                    if (developersAttribute != null)
                        _developers = developersAttribute.DevelopersNames;

                    SnapInImageAttribute imageAttribute = reader.GetSnapInImageAttribute();
                    if (imageAttribute != null)
                        _image = (Bitmap)imageAttribute.GetImage(type);

                    SnapInProductFamilyMemberAttribute[] productFamilyAttributes = reader.GetSnapInProductFamilyMemberAttributes();
                    if (productFamilyAttributes != null)
                    {
                        _productFamilies = new string[productFamilyAttributes.Length];
                        for (int i = 0; i < productFamilyAttributes.Length; i++)
                        {
                            _productFamilies[i] = productFamilyAttributes[i].ProductFamily;
                        }
                    }

                    SnapInTitleAttribute titleAttribute = reader.GetSnapInTitleAttribute();
                    if (titleAttribute != null)
                    {
                        _title = titleAttribute.Title;
                    }

                    SnapInVersionAttribute versionAttribute = reader.GetSnapInVersionAttributes();
                    if (versionAttribute != null)
                        _version = versionAttribute.Version;
                }

                if (_developers == null)
                    _developers = new string[] { };
                if (_productFamilies == null)
                    _productFamilies = new string[] { };

                if (_image == null)
                    _image = _defaultImage;

                if (_title == null || _title == string.Empty)
                    _title = type.FullName;

                if (_version == null)
                    _version = new Version("1.0.0.0");
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }
    }
}
