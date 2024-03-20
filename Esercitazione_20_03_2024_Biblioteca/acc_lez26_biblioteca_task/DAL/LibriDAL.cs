using acc_lez26_biblioteca_task.Models;
using System;
using System.Collections.Generic;
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

        public bool Insert(Libro t)
        {
            throw new NotImplementedException();
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
