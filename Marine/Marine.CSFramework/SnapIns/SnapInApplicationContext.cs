using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marine.CSFramework.SnapIns
{
    public class SnapInApplicationContext : ApplicationContext
    {
        protected FormList _topLevelWindows;

        public SnapInApplicationContext()
        {
            _topLevelWindows = new FormList();
        }

        public virtual void AddTopLevelWindows(Form form)
        {
            if (form == null)
                throw new ArgumentNullException("form");

            form.Closed += new EventHandler(OnTopLevelWindowClosed);

            lock (_topLevelWindows)
                _topLevelWindows.Add(form);
        }

        public virtual void RemoveTopLevelWindow(Form form)
        {
            if (form == null)
                throw new ArgumentNullException("form");

            form.Closed -= new EventHandler(OnTopLevelWindowClosed);

            lock (_topLevelWindows)
            {
                _topLevelWindows.Remove(form);
                if (_topLevelWindows.Count == 0)
                {
                    this.ExitThread();
                }
            }
        }

        protected virtual void OnTopLevelWindowClosed(object sender, EventArgs e)
        {
            try
            {
                Form form = sender as Form;

                this.RemoveTopLevelWindow(form);
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }
    }
}
