using Task_ferramenta.Models;

namespace Task_ferramenta.Repositories
{
    public class ProdottoRepo : IRepo<Prodotto>
    {
        private static ProdottoRepo? _instance;

        public static ProdottoRepo getInstance()
        {
            if (_instance == null)
                _instance = new ProdottoRepo();
            return _instance;
        }

        private ProdottoRepo() { }
        public bool delete(string codice)
        {
            bool risultato = false;
            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
            {
                try
                {
                    Prodotto prod = ctx.Prodottos.Single(c => c.Codice == codice);
                    ctx.Prodottos.Remove(prod);
                    ctx.SaveChanges();

                    risultato = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public Prodotto? GetByCod(string codice)
        {
            Prodotto? prod = null;

            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
                prod = ctx.Prodottos.FirstOrDefault(p => p.Codice == codice);

            return prod;
        }
        public Prodotto? GetById(int id)
        {
            Prodotto? prod = null;
            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
                prod = ctx.Prodottos.FirstOrDefault(p => p.ProdottoId == id);

            return prod;
        }

        public List<Prodotto> GetAll()
        {
            List<Prodotto> elenco = new List<Prodotto>();

            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
            {
                elenco = ctx.Prodottos.ToList();
            }

            return elenco;
        }

        public bool insert(Prodotto t)
        {
            bool risultato = false;
            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
            {
                try
                {
                    ctx.Prodottos.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool update(Prodotto t)
        {
            bool risultato = false;

            using (TaskFerramentaContext ctx = new TaskFerramentaContext())
            {
                try
                {
                    Prodotto temp = ctx.Prodottos.Single(p => p.Codice == t.Codice);

                    t.ProdottoId = temp.ProdottoId;
                    t.Codice = t.Codice is not null ? t.Codice : temp.Codice;
                    t.Nome = t.Nome is not null ? t.Nome : temp.Nome;
                    t.Descrizione = t.Descrizione is not null ? t.Descrizione : temp.Descrizione;
                    t.Prezzo = t.Prezzo == 0 ? temp.Prezzo : t.Prezzo;
                    t.Quantita = temp.Quantita;
                    t.Categoria = t.Categoria is not null ? t.Categoria : temp.Categoria;
                    t.DataCreazione = temp.DataCreazione;

                    ctx.Entry(temp).CurrentValues.SetValues(t);

                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }
    }
}
