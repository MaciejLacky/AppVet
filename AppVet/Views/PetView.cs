using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVet.Views
{
    public partial class PetView : Form, IPetView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessful;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage1);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearchPet.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearchPet.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string PetId { get => tbPetId.Text; set => tbPetId.Text = value; }
        public string PetName { get => tbPetName.Text; set => tbPetName.Text = value; }
        public string PetType { get => tbPetType.Text; set => tbPetType.Text = value; }
        public string PetColour { get => tbPetColour.Text; set => tbPetColour.Text = value; }
        public string SearchValue { get => tbSearchPet.Text; set => tbSearchPet.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get =>  message ; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dgvListPets.DataSource = petList;
        }

        //sigleton pattern to open one instance window
        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
                
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
