using AppVet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Presenters.Common
{
    public class Instance<T> where T : Form
    {
        //sigleton pattern to open one instance window
        
        private static T instance;

        public static T Get(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = (T)Activator.CreateInstance(typeof(T));
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        public void Show()
        {
            instance.Show();
        }
    }
}
