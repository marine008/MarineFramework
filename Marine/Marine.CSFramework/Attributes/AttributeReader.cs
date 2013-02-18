using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    public abstract class AttributeReader
    {
        public virtual void DumpAttributes(System.Reflection.Assembly a)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("Dumping attributes for Assembly'" + a.FullName + "'...");

                object[] attributes = a.GetCustomAttributes(false);
                if (attributes != null)
                {
                    foreach (object attribute in attributes)
                    {
                        System.Diagnostics.Trace.WriteLine(attributes);
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public virtual void DumpAttributes(System.Type t)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("Dumping Attributes for Type '" + t.FullName + "'...");

                object[] attributes = t.GetCustomAttributes(false);
                if (attributes != null)
                {
                    foreach (object attribuet in attributes)
                    {
                        System.Diagnostics.Trace.WriteLine(attributes);
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }
    }
}
