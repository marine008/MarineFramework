using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple=false)]
    public class RequiresRegistrationAttribute:Attribute
    {
        protected bool _requiresRegistration;

        public RequiresRegistrationAttribute(bool requiresRegistration)
        {
            _requiresRegistration = requiresRegistration;
        }

        public bool RequireRegistration
        {
            get { return _requiresRegistration; }
        }
    }
}
