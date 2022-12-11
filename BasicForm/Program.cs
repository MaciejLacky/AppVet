using AppVet._Repositories;
using AppVet.Models;
using AppVet.Presenters;
using AppVet.Views;
using System.Configuration;

namespace AppVet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string connectionString = "Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=VeterinaryDb;Trusted_Connection=True;";
            //string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            //IPetView view = new PetView();
            //IPetRepository repository = new PetRepository(connectionString);
            //new PetPresenter(view, repository);
            //Application.Run((Form)view);
            IMainView view = new MainView();
            new MainPresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}