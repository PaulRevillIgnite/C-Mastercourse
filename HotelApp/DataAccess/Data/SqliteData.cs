using HotelAppLibary.Databases;
using HotelAppLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibary.Data
{
    public class SqliteData : IDatabaseData
    {
        private const string connectionStringName = "SQLiteDb";

        public ISqliteDataAccess _db { get; }

        public SqliteData(ISqliteDataAccess db)
        {
            _db = db;
        }        

        public void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId)
        {
            string sql = @"select 1 from Guests where FirstName = @firstName and LastName = @lastName";
            int results = _db.LoadData<dynamic, dynamic>(sql, new { firstName, lastName }, connectionStringName).Count();

            if (results == 0)
            {
                sql = @"insert into Guests (FirstName, LastName)
		                values (@firstName, @lastName);";

                _db.SaveData(sql,
                             new { firstName, lastName },
                             connectionStringName);
            }

            sql = @"SELECT Id, FirstName, LastName
	                from Guests
	                where  FirstName = @firstName and LastName = @lastName LIMIT 1;";

            GuestModel guest = _db.LoadData<GuestModel, dynamic>(sql,
                                                                 new { firstName, lastName },
                                                                 connectionStringName).First();

            RoomTypeModel roomType = _db.LoadData<RoomTypeModel, dynamic>("select * from RoomTypes where Id = @Id",
                                                                         new { Id = roomTypeId },
                                                                         connectionStringName).First();

            TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date);

            sql = @"SELECT DISTINCT R.*
	                FROM Rooms R
		                INNER JOIN RoomTypes T ON T.Id = R.RoomTypeId
	                WHERE R.RoomTypeId = @roomTypeId
		                AND R.Id NOT IN (SELECT B.RoomId
						                FROM Rooms R
							                INNER JOIN RoomTypes RT ON RT.Id = R.RoomTypeId
							                INNER JOIN Bookings B ON B.RoomId = R.Id
						                WHERE (@startDate < B.StartDate AND @endDate > B.EndDate)
							                OR (B.StartDate <= @endDate AND @endDate < b.EndDate)
							                OR (B.StartDate <= @startDate AND @startDate < B.EndDate)
						                );";

            List<RoomModel> avliableRooms = _db.LoadData<RoomModel, dynamic>(sql,
                                                                            new { startDate, endDate, roomTypeId },
                                                                            connectionStringName);

            sql = @"insert into Bookings(RoomId, GuestId, StartDate, EndDate, TotalCost)
	                values (@roomId, @guestId, @startDate, @endDate, @totalCost);";

            _db.SaveData(sql,
                        new
                        {
                            roomId = avliableRooms.First().Id,
                            guestId = guest.Id,
                            startDate = startDate,
                            endDate = endDate,
                            totalCost = timeStaying.Days * roomType.Price
                        },
                        connectionStringName);
        }

        public void CheckInGuest(int bookingId)
        {
            throw new NotImplementedException();
        }

        public List<RoomTypeModel> GetAvaliableRoomTypes(DateTime startDate, DateTime endDate)
        {
            string sql = @"SELECT DISTINCT T.*
	                        FROM Rooms R
		                        INNER JOIN RoomTypes T ON T.Id = R.RoomTypeId
	                        WHERE R.Id NOT IN (SELECT B.RoomId
						                        FROM Rooms R
							                        INNER JOIN RoomTypes RT ON RT.Id = R.RoomTypeId
							                        INNER JOIN Bookings B ON B.RoomId = R.Id
						                        WHERE (@startDate < B.StartDate AND @endDate > B.EndDate)
							                        OR (B.StartDate <= @endDate AND @endDate < b.EndDate)
							                        OR (B.StartDate <= @startDate AND @startDate < B.EndDate)
						                        )
	                        GROUP BY T.Id, T.Title, T.Description, T.Price;";

            var output = _db.LoadData<RoomTypeModel, dynamic>(sql,
                                                new { startDate, endDate },
                                                connectionStringName);

            output.ForEach(x => x.Price = x.Price / 100);

            return output;
        }

        public RoomTypeModel GetRoomTypeById(int id)
        {
            string sql = @"select *
	                    from RoomTypes
	                    where Id = @id;";

            return _db.LoadData<RoomTypeModel, dynamic>(sql,
                                                       new { id },
                                                       connectionStringName).FirstOrDefault();
        }

        public List<BookingFullModel> SearchBookings(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
