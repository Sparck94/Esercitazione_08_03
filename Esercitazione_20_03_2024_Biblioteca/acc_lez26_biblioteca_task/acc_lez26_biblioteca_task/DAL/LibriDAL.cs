using acc_lez26_biblioteca_task.Models;
using acc_lez26_biblioteca_task.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acc_lez26_biblioteca_task.DAL
{
    internal class LibriDAL : IDal<Libro>
    {
        private static LibriDAL? istanza;

        public static LibriDAL getIstanza()
        {
            if (istanza == null)
                istanza = new LibriDAL();

            return istanza;
        }

        public Libro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro lib)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Libro (titolo, annoPub, isDisponibile) VALUES (@titolo, @annoPub, @isDisp)";
                cmd.Parameters.AddWithValue("nome", lib.Titolo);
                cmd.Parameters.AddWithValue("descrizione", lib.AnnoPubblicazione);
                cmd.Parameters.AddWithValue("prezzo", lib.isDisponibile);

                try
                {
                    con.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return risultato;
        }

        public bool Update(Libro t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Libro t)
        {
            throw new NotImplementedException();
        }

        private LibriDAL() { }
    }
}
