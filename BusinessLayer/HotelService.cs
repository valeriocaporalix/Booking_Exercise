using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.QueryParameters;
using Booking_Exercise.Utilities;

namespace Booking_Exercise.BusinessLayer
{
    public class HotelService : IHotelService
    {
        private IDASHotels _dataAccessService;
        private readonly IMapper _mapper;

        public HotelService(IDASHotels dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }

        // Cambiamo il ritorno effettivo del metodo GetHotels e restituiamo una PagedList tramite il 
        // metodo statico della classe che ci inizializza la lista PagedList.

        // Tramite i query params lavoriamo sulla paginazione nel metodo statico.
        public PagedList<LightHotelDto> GetHotels(PageParameters parameters)
        {
            var hotels = _dataAccessService.GetAll();
            var mappedHotels = _mapper.Map<List<LightHotelDto>>(hotels);
            return PagedList<LightHotelDto>.ToPagedList(mappedHotels, parameters.PageNumber, parameters.PageSize);
        }

        public DetailsHotelDto GetHotelById(int hotelId)
        {
            var hotel = _dataAccessService.GetById(hotelId);
            var mappedHotel = _mapper.Map<DetailsHotelDto>(hotel);
            return mappedHotel;
        }

        public Hotel InsertHotel(PostHotelDto postHotel)
        {
            var mappedHotel = _mapper.Map<Hotel>(postHotel);
            return _dataAccessService.Post(mappedHotel);
        }

        public Hotel ModifyOrCreateHotel(PostHotelDto hotelToModify, int hotelId)
        {
            try
            {
                var hotelMapped = _mapper.Map<Hotel>(hotelToModify);
                hotelMapped.HotelId = hotelId;
                _dataAccessService.Put(hotelMapped, hotelId);
                throw new Exception();
            }
            catch(InvalidOperationException)
            {
                var hotelToCreate = _mapper.Map<Hotel>(hotelToModify);
                return _dataAccessService.Post(hotelToCreate);
            }
        }
    }
}
