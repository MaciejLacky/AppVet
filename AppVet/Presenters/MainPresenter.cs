using AppVet._Repositories;
using AppVet.Models;
using AppVet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
            this.mainView.ShowOwnerView += ShowOwnerView;
            this.mainView.ShowVetsView += ShowVetsView;
        }

        private void ShowVetsView(object? sender, EventArgs e)
        {
            var view = VetView.GetInstance((MainView)mainView);
            //IOwnerRepository repository = new OwnerRepository(sqlConnectionString);
            new VetPresenter(view);
        }

        private void ShowOwnerView(object? sender, EventArgs e)
        {
            var  view = OwnerView.GetInstance((MainView)mainView);
            //IOwnerRepository repository = new OwnerRepository(sqlConnectionString);
            new OwnerPresenter(view);
        }

        private void ShowPetsView(object? sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView) mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
