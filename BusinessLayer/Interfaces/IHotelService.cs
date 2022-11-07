using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IHotelService
    {
        public IEnumerable<LightHotelDto> GetHotels();
        public Hotel InsertHotel(PostHotelDto postHotel);
        public DetailsHotelDto GetHotelById(int hotelId);
        public Hotel ModifyOrCreateHotel(PostHotelDto hotelToModify, int hotelId);
    }
}
