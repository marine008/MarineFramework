using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class ProductIdentifierAttribute : Attribute
    {
        protected string _id;

        public ProductIdentifierAttribute(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id; }
        }
    }
}
