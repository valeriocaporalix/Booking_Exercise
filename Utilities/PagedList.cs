namespace Booking_Exercise.Utilities
{
    // PagedList è una lista che possiede un set di proprietà che servono alla paginazione.
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        
        // Costruttore parametrico 
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize == 0 ? count : pageSize;
            CurrentPage = pageNumber;
            TotalPages = pageSize != 0 ? (int)Math.Ceiling(count / (double)pageSize) : 1;
            AddRange(items);
        }

        // Metodo statico che lavora su una getAll di un entità (source)
        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            // Cuore del paging <3
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            var itemsToReturn = items.Count() == 0 ? source.ToList() : items;
            return new PagedList<T>(itemsToReturn, count, pageNumber, pageSize);
        }
    }
}
