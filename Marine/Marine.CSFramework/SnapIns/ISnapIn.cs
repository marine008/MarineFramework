using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marine.CSFramework.SnapIns
{
    public interface ISnapIn
    {
        event EventHandler InstallCommonOptions;
        event EventHandler InstallLocalUserOptions;
        event EventHandler UpgradeCommonOptions;
        event EventHandler UpgradeLocalUserOptions;
        event EventHandler ReadCommonOptions;
        event EventHandler ReadLocalUserOptions;
        event EventHandler WriteCommonOptions;
        event EventHandler WriteLocalUserOptions;
        event EventHandler UninstallCommonOptions;
        event EventHandler UninstallLocalUserOptions;
        event EventHandler Start;
        event EventHandler Stop;

        void OnInstallCommonOptions(object sender, System.EventArgs e);
        void OnInstallLocalUserOptions(object sender, System.EventArgs e);
        void OnUpgradeCommonOptions(object sender, System.EventArgs e);
        void OnUpgradeLocalUserOptions(object sender, System.EventArgs e);
        void OnReadCommonOptions(object sender, System.EventArgs e);
        void OnReadLocalUserOptions(object sender, System.EventArgs e);
        void OnWriteCommonOptions(object sender, System.EventArgs e);
        void OnWriteLocalUserOptions(object sender, System.EventArgs e);
        void OnUninstallCommonOptions(object sender, System.EventArgs e);
        void OnUninstallLocalUserOptions(object sender, System.EventArgs e);
        void OnStart(object sender, System.EventArgs e);
        void OnStop(object sender, System.EventArgs e);
    }
}
