using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marine.CSFramework.Attributes;

namespace Marine.CSFramework.SnapIns
{
    public class SnapInDescriptor
    {
        private readonly ISnapIn _snapIn;
        private readonly Type _type;
        private readonly Type[] _dependencies;
        internal bool _isMissingDependency;
        internal bool _isCircularlyDependent;
        internal bool _isDependentOnTypeThatIsCircularlyDenpendent;
        internal bool _isDependentOnTypeThatIsMissingDependency;
        internal bool _isStarted;
        internal bool _isUninstalled;
        internal DateTime _installDate;
        internal int _runCount;
        private SnapInMetaData _metaData;

        public Type Type
        {
            get { return _type; }
        }
        public ISnapIn SnapIn
        {
            get { return _snapIn; }
        }
        public Type[] Dependencies
        {
            get { return _dependencies; }
        }
        public bool IsMissingDenpendency
        {
            get { return _isMissingDependency; }
        }
        public bool IsCircularlyDependent
        {
            get { return _isCircularlyDependent; }
        }
        public bool IsDependentOnTypeThatIsCircularlyDependent
        {
            get { return _isDependentOnTypeThatIsCircularlyDenpendent; }
        }
        public bool IsDependentOnTypeThatIsMissingDependency
        {
            get { return _isDependentOnTypeThatIsMissingDependency; }
        }
        public bool IsStarted
        {
            get { return _isStarted; }
        }
        public bool IsUninstalled
        {
            get { return _isUninstalled; }
        }
        public DateTime InstallDate
        {
            get { return _installDate; }
        }
        public int RunCount
        {
            get { return _runCount; }
        }
        public SnapInMetaData MetaData
        {
            get { return _metaData; }
        }

        public SnapInDescriptor(Type type, ISnapIn snapIn)
        {
            _type = type;
            _snapIn = snapIn;


            _metaData = new SnapInMetaData(type);
        }

        public bool DependsOn(SnapInDescriptor descriptor)
        {
            foreach (Type t in _dependencies)
            {
                if (Type.Equals(t, descriptor.Type))
                    return true;
            }
            return false;
        }

        public void DetermineIfAnyDenpndenciesAreMissing(SnapInDescriptor[] descriptors)
        {
            //_isMissingDependency = this.DetermineIfAnyDenpndenciesAreMissing
        }

        public static void AdviseOnActionsThatCanBeTaken(SnapInDescriptor descriptor, out bool canStart, out bool canStop, out bool canReinstall, out bool canUninstall)
        {
            if (descriptor != null)
            {
                if (descriptor.IsUninstalled)
                {
                    canStart = false;
                    canStop = false;
                    canReinstall = true;
                    canUninstall = false;
                }
                else
                {
                    canStart = !descriptor.IsStarted;
                    canStop = descriptor.IsStarted;
                    canReinstall = false;
                    canUninstall = true;
                }
            }
            else
            {
                canStart = false;
                canStop = false;
                canReinstall = false;
                canUninstall = false;
            }
        }

        private Type[] ExtractTypesThatThisTypeDependsOn(Type type)
        {
            try
            {
                if (type != null)
                {
                    object[] attributes = type.GetCustomAttributes(typeof(SnapInDependencyAttribute), true);
                    if (attributes != null)
                    {
                        Type[] dependencies = new Type[attributes.Length];
                        for (int i = 0; i < dependencies.Length; i++)
                        {
                            SnapInDependencyAttribute da = (SnapInDependencyAttribute)attributes[i];
                            dependencies[i] = this.GetTypeFromAttribute(da);
                        }
                        return dependencies;
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return new Type[] { };
        }

        private System.Type GetTypeFromAttribute(SnapInDependencyAttribute da)
        {
            try
            {
                return da.Type;
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
            return (Type)Type.Missing;
        }

        public bool DetermineIfAnyDenpendenciesAreMissing(Type[] dependencies, SnapInDescriptor[] descriptors)
        {
            foreach (Type type in dependencies)
            {
                if ((object)type == Type.Missing)
                    return true;
            }

            foreach (Type type in dependencies)
            {
                bool found = false;
                foreach (SnapInDescriptor descriptor in descriptors)
                {
                    if (!descriptor.IsUninstalled)
                    {
                        if (descriptor.Type == type)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                    return true;
            }
            return false;
        }


    }
}
