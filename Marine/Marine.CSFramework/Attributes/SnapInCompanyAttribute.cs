using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SnapInCompanyAttribute : Attribute
    {
        private string _name;

        public SnapInCompanyAttribute(string companyName)
        {
            _name = companyName;
        }

        public string CompanyName
        {
            get { return _name; }
        }
    }
}
