using AppVet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Views
{
    public interface IVetsView
    {
        string VetId { get; set; }
        string VetName { get; set; }
        string VetAddress { get; set; }
        List<PetModel> Customers { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetOwnerListBindingSource(BindingSource ownerList);
        void Show();
    }
}
