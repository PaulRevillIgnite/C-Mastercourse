using HotelAppLibary.Models;

namespace HotelAppLibary.Data
{
    public interface IDatabaseData
    {
        void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId);
        void CheckIn(int bookingId);
        List<RoomTypeModel> GetAvaliableRoomTypes(DateTime startDate, DateTime endDate);
        List<BookingFullModel> SearchBookings(string lastName);
    }
}