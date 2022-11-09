namespace Booking_Exercise.Models.QueryParameters
{
    public class PageParameters
    {
        const int maxPageSize = 1000;
        public int PageNumber { get; set; } = 1;
        private int _pageSize { get; set; } = 1000;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }
    }
}
