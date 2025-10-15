using HotelAppLibary.Databases;
using HotelAppLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibary.Data
{
    public class SqlData
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
    }
}
