using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class SnapInDevelopersAttribute:Attribute
    {
        private string[] _names;

        public SnapInDevelopersAttribute(params string[] names)
        {
            _names = names;
        }

        public SnapInDevelopersAttribute(string name)
        {
            _names = new string[] { name };
        }

        public string[] DevelopersNames
        {
            get { return _names; }
        }
    }
}
