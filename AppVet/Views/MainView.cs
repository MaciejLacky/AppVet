using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVet.Views
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler ShowPetView;       
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        public MainView()
        {
            InitializeComponent();
            ButtonsClickEvents();           
        }

        private void ButtonsClickEvents()
        {
            btnPets.Click += delegate {
                ShowPetView?.Invoke(this, EventArgs.Empty);
                ShowSubMenu(panelSubmenu1);
            };
            btnMain2.Click += delegate {
                ShowOwnerView?.Invoke(this, EventArgs.Empty);
                ShowSubMenu(panelSubmenu2);
            };
            btnMain3.Click += delegate {
                ShowVetsView?.Invoke(this, EventArgs.Empty);
                
            };

        }

        public void CustomizeDesign()
        {
            panelSubmenu1.Visible = false;
            panelSubmenu2.Visible = false;           
        }

        public void HideSubMenu()
        {
            if (panelSubmenu1.Visible == true)
                panelSubmenu1.Visible = false;
            if (panelSubmenu2.Visible == true)
                panelSubmenu2.Visible = false;
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
    }
}
