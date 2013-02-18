using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class SnapInExportedFromAssemblyAttribute : Attribute
    {
        private Type _type;

        public SnapInExportedFromAssemblyAttribute(Type t)
        {
            _type = t;
        }

        public Type Type
        {
            get { return _type; }
        }

        public override string ToString()
        {
            return "'SnapIn Exported from Assembly':" + _type.FullName;
        }
    }
}
