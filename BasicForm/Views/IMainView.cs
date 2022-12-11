using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Views
{
    public interface IMainView
    {
        event EventHandler ShowPetView;        
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;

        void CustomizeDesign();
        void HideSubMenu();
        void ShowSubMenu(Panel submenu);

    }
}
