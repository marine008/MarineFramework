using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    public class AssemblyAttributeReader : AttributeReader
    {
        private Assembly _assembly;

        public AssemblyAttributeReader(Assembly assembly)
        {
            _assembly = assembly;
        }

        public Version GetAssemblyVersion()
        {
            try
            {
                if (_assembly != null)
                {
                    Version v = _assembly.GetName().Version;
                    return v;
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public ProductIdentifierAttribute GetProductIdentifierAttribute()
        {
            try
            {
                object[] attributes = _assembly.GetCustomAttributes(typeof(ProductIdentifierAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return attributes[0] as ProductIdentifierAttribute;
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public RequiresRegistrationAttribute GetRequiresRegistrationAttribute()
        {
            try
            {
                object[] attributes = _assembly.GetCustomAttributes(typeof(RequiresRegistrationAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    return attributes[0] as RequiresRegistrationAttribute;
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return null;
        }

        public AssemblyCompanyAttribute[] GetAssemblyCompanyAttributes()
        {
            try
            {
                return (AssemblyCompanyAttribute[])_assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new AssemblyCompanyAttribute[] { };
        }

        public AssemblyConfigurationAttribute[] GetAssemblyConfigurationAttribute()
        {
            try
            {
                return (AssemblyConfigurationAttribute[])_assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new AssemblyConfigurationAttribute[] { };
        }

        public AssemblyCopyrightAttribute[] GetAssemblyCopyrightAttribute()
        {
            try
            {
                return (AssemblyCopyrightAttribute[])_assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new AssemblyCopyrightAttribute[] { };
        }

        public SnapInExportedFromAssemblyAttribute[] GetAssemblyCopyrightAttribute()
        {
            try
            {
                return (SnapInExportedFromAssemblyAttribute[])_assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new SnapInExportedFromAssemblyAttribute[] { };
        }

        public SnapInProductFamilyMemberAttribute[] GetAssemblyCopyrightAttribute()
        {
            try
            {
                return (SnapInProductFamilyMemberAttribute[])_assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new SnapInProductFamilyMemberAttribute[] { };
        }
    }
}
