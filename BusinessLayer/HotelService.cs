﻿using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;

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

        public IEnumerable<LightHotelDto> GetHotels()
        {
            var hotels = _dataAccessService.GetAll();
            var mappedHotels = _mapper.Map<List<LightHotelDto>>(hotels);
            return mappedHotels;
        }

        public Hotel GetHotelById(int hotelId)
        {
            var hotel = _dataAccessService.GetById(hotelId);
            return hotel;
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
