using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SnapInDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public SnapInDescriptionAttribute(string description)
            : base(description)
        { }
    }
}
