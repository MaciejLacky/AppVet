using AppVet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Presenters
{
    public class VetPresenter
    {
        private IVetsView view;
        public VetPresenter(VetView view)
        {
            this.view = view;
            this.view.Show();
        }
    }
}
