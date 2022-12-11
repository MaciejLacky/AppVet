using AppVet.Models;
using AppVet.Presenters.Common;
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
    public partial class VetView : Form, IVetsView
    {
        public VetView()
        {
            InitializeComponent();
        }

        public string VetId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string VetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string VetAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<PetModel> Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetOwnerListBindingSource(BindingSource ownerList)
        {
            throw new NotImplementedException();
        }
        public static VetView GetInstance(Form parentContainer)
        {
            return Instance<VetView>.Get(parentContainer);
        }
    }
}
