using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SnapInVersionAttribute:Attribute
    {
        private System.Version _version;

        public SnapInVersionAttribute(string version)
        {
            _version = new Version(version);
        }

        public Version Version
        {
            get { return _version; }
        }

        public override string ToString()
        {
            return "SnapIn Version:" + _version.ToString();
        }
    }
}
