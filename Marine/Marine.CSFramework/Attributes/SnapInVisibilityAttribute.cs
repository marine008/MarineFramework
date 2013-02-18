using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=false)]
    public class SnapInVisibilityAttribute:Attribute
    {
        private bool _visible;

        public SnapInVisibilityAttribute(bool visible)
        {
            _visible = visible;
        }

        public bool Visible
        {
            get { return _visible; }
        }

        public override string ToString()
        {
            return "SnapIn HostingEngine Visible:"+_visible.ToString();
        }
    }
}
