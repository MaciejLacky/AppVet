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
        }

        private void ShowPetsView(object? sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView) mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
