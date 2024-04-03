namespace Task_ferramenta.Repositories
{
    public interface IRepo<T>
    {
        T? GetById(int id);
        T? GetByCod(string codice);
        List<T> GetAll();
        bool insert(T t);
        bool update(T t);
        bool delete(string codice);
    }
}
