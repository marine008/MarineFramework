using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    public class SnapInAttributeReader : AttributeReader
    {
        private Type _type;

        public SnapInAttributeReader(Type t)
        {
            _type = t;
        }

        public SnapInImageAttribute GetSnapInImageAttribute()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInImageAttribute), false);
                if (attributes.Length > 0)
                {
                    return attributes[0] as SnapInImageAttribute;
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInTitleAttribute GetSnapInTitleAttribute()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInTitleAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInTitleAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInDescriptionAttribute GetSnapInDescriptionAttribute()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInDescriptionAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInDescriptionAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInCompanyAttribute GetSnapInCompanyAttribute()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInCompanyAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInCompanyAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInDevelopersAttribute GetSnapInDevelopersAttributes()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInDevelopersAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInDevelopersAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInVisibilityAttribute GetSnapInVisibilityAttributes()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInVisibilityAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInVisibilityAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInVersionAttribute GetSnapInVersionAttributes()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInVersionAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInVersionAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInVersionAttribute GetSnapInVersionAttributes()
        {
            try
            {
                object[] attributes = _type.GetCustomAttributes(typeof(SnapInVersionAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0] as SnapInVersionAttribute;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInProductFamilyMemberAttribute[] GetSnapInProductFamilyMemberAttributes()
        {
            try
            {
                return (SnapInProductFamilyMemberAttribute[])_type.GetCustomAttributes(typeof(SnapInProductFamilyMemberAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public SnapInDependencyAttribute[] GetSnapInDependencyAttributes()
        {
            try
            {
                return (SnapInDependencyAttribute[])_type.GetCustomAttributes(typeof(SnapInDependencyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }
    }
}
