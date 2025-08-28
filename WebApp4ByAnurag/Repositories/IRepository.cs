namespace WebApp4ByAnurag.Repositories
{
    public interface IRepository<T>
    {
        public void AddRecord(T model);
        public T UpdateRecord(T model);
        public T DeleteRecord(T model);
        public T GetSingleRecord(int id);
        public IEnumerable<T> GetAllRecords();
    }

}
