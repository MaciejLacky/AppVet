using AppVet.Presenters.Common;
using AppVet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Presenters
{
    

    public class OwnerPresenter
    {
        private IOwnerView view;
        public OwnerPresenter(OwnerView view)
        {
            this.view = view;
            this.view.Show();
        }
    }
}
