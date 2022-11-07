namespace Booking_Exercise.DataAccessLayer.Interfaces
{
    public interface IDataAccessService<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public T Post(T input);
    }
}
