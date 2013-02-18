using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Marine.CSFramework.SnapIns
{
    public class FormList : CollectionBase
    {
        public FormList()
        { }

        public Form this[int index]
        {
            get { return base.InnerList[index] as Form; }
        }

        public bool Contains(Form form)
        {
            foreach (Form f in base.InnerList)
            {
                if (f.Equals(form))
                    return true;
            }
            return false;
        }

        public void Add(Form form)
        {
            if (this.Contains(form))
                throw new FormAlreadyExistsException(form);
            base.InnerList.Add(form);
        }

        public void Remove(Form form)
        {
            if (this.Contains(form))
                base.InnerList.Remove(form);
        }

        public void AddRange(Form[] forms)
        {
            foreach (Form f in forms)
            {
                this.Add(f);
            }
        }
    }

    public class FormAlreadyExistsException : Exception
    {
        protected Form _form;
        public FormAlreadyExistsException(Form form)
            : base(string.Format("The Form '{0}' already exists in the list", form.Text))
        {
            _form = form;
        }

        public Form Form
        {
            get { return _form; }
        }
    }
}
