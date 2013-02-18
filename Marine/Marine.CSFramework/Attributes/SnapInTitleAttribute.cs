using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    class SnapInTitleAttribute:Attribute
    {
        private string _title;

        public SnapInTitleAttribute(string title)
        {
            _title = title;
        }

        public string Title
        {
            get { return _title; }
        }

        public override string ToString()
        {
            return "SnapIn Title: " + _title;
        }
    }
}
