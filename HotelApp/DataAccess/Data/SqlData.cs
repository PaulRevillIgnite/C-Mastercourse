using HotelAppLibary.Databases;
using HotelAppLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibary.Data
{
    public class SqlData : IDatabaseData
    {
        private readonly ISqlDataAccess db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public List<RoomTypeModel> GetAvaliableRoomTypes(DateTime startDate, DateTime endDate)
        {
            return db.LoadData<RoomTypeModel, dynamic>("dbo.spRoomTypes_GetAvaliableTypes",
                                                new { startDate, endDate },
                                                connectionStringName,
                                                true);
        }

        public void BookGuest(string firstName,
                              string lastName,
                              DateTime startDate,
                              DateTime endDate,
                              int roomTypeId)
        {
            GuestModel guest = db.LoadData<GuestModel, dynamic>("dbo.spGuests_Insert",
                                                                 new { firstName, lastName },
                                                                 connectionStringName,
                                                                 true).First();

            RoomTypeModel roomType = db.LoadData<RoomTypeModel, dynamic>("select * from dbo.RoomTypes where Id = @Id",
                                                                         new { Id = roomTypeId },
                                                                         connectionStringName,
                                                                         false).First();

            TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date);

            List<RoomModel> avliableRooms = db.LoadData<RoomModel, dynamic>("dbo.spRooms_GetAvaliableRooms",
                                                                            new { startDate, endDate, roomTypeId },
                                                                            connectionStringName,
                                                                            true);

            db.SaveData("dbo.spBookings_Insert",
                        new
                        {
                            roomId = avliableRooms.First().Id,
                            guestId = guest.Id,
                            startDate = startDate,
                            endDate = endDate,
                            totalCost = timeStaying.Days * roomType.Price
                        },
                        connectionStringName,
                        true);
        }

        public List<BookingFullModel> SearchBookings(string lastName)
        {
            return db.LoadData<BookingFullModel, dynamic>("dbo.spBookings_Search",
                                                   new { lastName, startDate = DateTime.Now.Date },
                                                   connectionStringName,
                                                   true);
        }

        public void CheckIn(int bookingId)
        {
            db.SaveData("dbo.[spBookings_CheckIn]", new { Id = bookingId }, connectionStringName, true);
        }
    }
}
