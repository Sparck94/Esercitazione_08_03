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
    internal class UtenteDAL : IDal<Utente>
    {
        public bool Delete(Utente t)
        {
            throw new NotImplementedException();
        }

        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Utente ut)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Utente (nome, cognome, email) VALUES (@nome, @cognome, @email)";
                cmd.Parameters.AddWithValue("nome", ut.Nome);
                cmd.Parameters.AddWithValue("descrizione", ut.Cognome);
                cmd.Parameters.AddWithValue("prezzo", ut.Email);

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

        public bool Update(Utente t)
        {
            throw new NotImplementedException();
        }
        private UtenteDAL() { }
    }
}
