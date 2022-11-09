using Booking_Exercise.BusinessLayer;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Utilities.Validators.Booking;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDASBookings, DbDASBookings>();
builder.Services.AddScoped<IDASHotels, DbDASHotels>();
builder.Services.AddScoped<IDASRatings, DbDASRatings>();
builder.Services.AddScoped<IDASRooms, DbDASRooms>();
builder.Services.AddScoped<IDASUsers, DbDASUsers>();

builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRatingService, RatingService>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IValidator<PostBookingDto>, PostBookingValidator>();
builder.Services.AddDbContext<BookingDbContext>(option =>
                option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookingDatabase"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
