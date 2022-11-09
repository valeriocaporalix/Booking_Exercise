using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.QueryParameters;
using Booking_Exercise.Utilities;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IHotelService
    {
        public PagedList<LightHotelDto> GetHotels(PageParameters parameters);
        public Hotel InsertHotel(PostHotelDto postHotel);
        public DetailsHotelDto GetHotelById(int hotelId);
        public Hotel ModifyOrCreateHotel(PostHotelDto hotelToModify, int hotelId);
    }
}
