namespace Core_file_migration.inter
{
    public interface IRrepository<T>
    {
        List<T> GetAll();
        void Add(T ent);

        

    }
}
