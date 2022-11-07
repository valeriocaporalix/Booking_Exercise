using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IUserService
    {
        public User Post(PostUserDto postUserDto);
        public IEnumerable<LightUserDto> GetAll();
        public DetailUserDto GetById(int id);
    }
}
