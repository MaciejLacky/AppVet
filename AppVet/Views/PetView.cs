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
            tabControl1.TabPages.Remove(tabPagePetDetails);
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
            btnAddPet.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetails);
                tabPagePetDetails.Text = "Add new pet";
            };
            btnEditPet.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetails);
                tabPagePetDetails.Text = "Edit pet";
            };
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if(isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetails);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);

            };
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetails);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            btnDeletePet.Click += delegate 
            { 
                
                var result = MessageBox.Show("Are you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
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
