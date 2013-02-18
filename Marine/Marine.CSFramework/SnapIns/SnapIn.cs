using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.SnapIns
{
    [Attributes.SnapInVisibility(false)]
    public class SnapIn : ISnapIn
    {
        public SnapIn()
        { }

        #region Suggested Overridable Method

        protected virtual void RestartMyServices()
        { }

        protected virtual void StartMyServices() { }
        protected virtual void StopMyServices() { }
        protected virtual void InstallMyCommonOptions() { }
        protected virtual void InstallMyLocalUserOptions() { }
        protected virtual void ReadMyCommonOptions() { }
        protected virtual void ReadMyLocalUserOptions() { }
        protected virtual void WriteMyCommonOptions() { }
        protected virtual void WriteMyLocalUserOptions() { }
        protected virtual void UninstallMyCommonOptions() { }
        protected virtual void UninstallMyLocalUserOptions() { }
        protected virtual void UpgradeMyCommonOptions() { }
        protected virtual void UpgradeMyLocalUserOptions() { }


        #endregion

        #region ISnapIn

        public event EventHandler InstallCommonOptions;

        public event EventHandler InstallLocalUserOptions;

        public event EventHandler UpgradeCommonOptions;

        public event EventHandler UpgradeLocalUserOptions;

        public event EventHandler ReadCommonOptions;

        public event EventHandler ReadLocalUserOptions;

        public event EventHandler WriteCommonOptions;

        public event EventHandler WriteLocalUserOptions;

        public event EventHandler UninstallCommonOptions;

        public event EventHandler UninstallLocalUserOptions;

        public event EventHandler Start;

        public event EventHandler Stop;

        public void OnInstallCommonOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.InstallCommonOptions != null)
                    this.InstallCommonOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnInstallLocalUserOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.InstallLocalUserOptions != null)
                    this.InstallLocalUserOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnUpgradeCommonOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.UpgradeCommonOptions != null)
                    this.UpgradeCommonOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnUpgradeLocalUserOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.UpgradeLocalUserOptions != null)
                    this.UpgradeLocalUserOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnReadCommonOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.ReadCommonOptions != null)
                    this.ReadCommonOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnReadLocalUserOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.ReadLocalUserOptions != null)
                    this.ReadLocalUserOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnWriteCommonOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.WriteCommonOptions != null)
                    this.WriteCommonOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnWriteLocalUserOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.WriteLocalUserOptions != null)
                    this.WriteLocalUserOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnUninstallCommonOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.UninstallCommonOptions != null)
                    this.UninstallCommonOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnUninstallLocalUserOptions(object sender, EventArgs e)
        {
            try
            {
                if (this.UninstallLocalUserOptions != null)
                    this.UninstallLocalUserOptions(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnStart(object sender, EventArgs e)
        {
            try
            {
                if (this.Start != null)
                    this.Start(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }

        public void OnStop(object sender, EventArgs e)
        {
            try
            {
                if (this.Stop != null)
                    this.Stop(sender, e);
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err);
            }
        }
        #endregion
    }
}
