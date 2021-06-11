using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by Brian Chaves
 * Created on June 10,2021
 * Updateed on June 10, 2021
*/

namespace VendingMachineForm
{
    public abstract class FormLayoutGroup
    {
        protected int x;
        public virtual int X
        {
            get { return x; }
            set
            {
                x = value;
                UpdateLayout();
            }
        }
        protected int y;
        public virtual int Y
        {
            get { return y; }
            set
            {
                y = value;
                UpdateLayout();
            }
        }
        private Form form;
        public Form Form
        {
            get {return form;}
            set {form= value;}
        }

        public abstract void UpdateLayout();
        public abstract void UpdateInfo();
        public abstract void GenerateItems();
        public abstract void ResetForm();
    }
}
