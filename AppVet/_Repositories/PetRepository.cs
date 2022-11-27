using AppVet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVet._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using (var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Pet ORDER BY Pet_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Colour = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string search)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            string petName = search;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Pet 
                                        WHERE Pet_Id = @id OR Pet_Name LIKE @name + '%'
                                        ORDER BY Pet_Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Colour = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }
    }
}
