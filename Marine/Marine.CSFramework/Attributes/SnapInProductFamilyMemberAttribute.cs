using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
    public class SnapInProductFamilyMemberAttribute:Attribute
    {
        private string _productFamily;

        public SnapInProductFamilyMemberAttribute(string productFamily)
        {
            _productFamily = productFamily;
        }

        public string ProductFamily
        {
            get { return _productFamily; }
        }
    }
}
