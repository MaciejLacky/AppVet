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
    public partial class OwnerView : Form, IOwnerView
    {
        public OwnerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            
        }

        public string OwnerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<PetModel> OwnerPets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

        public static OwnerView GetInstance(Form parentContainer)
        {
            return Instance<OwnerView>.Get(parentContainer);
        }
       

    }
}
