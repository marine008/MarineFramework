using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class SnapInDependencyAttribute : Attribute
    {
        private Type _type;

        public SnapInDependencyAttribute(Type t)
        {
            _type = t;
        }

        public Type Type
        {
            get { return _type; }
        }

        public override string ToString()
        {
            return "SnapIn Dependency':" + _type.FullName;
        }
    }
}
