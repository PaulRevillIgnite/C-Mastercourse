using HotelAppLibary.Data;
using HotelAppLibary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Web.Pages
{
    public class RoomSearchModel : PageModel
    {
        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [BindProperty(SupportsGet = true)]
        public bool SearchEnabled { get; set; }

        public List<RoomTypeModel> AvaliableRoomTypes { get; set; }
        public IDatabaseData _db { get; }

        public RoomSearchModel(IDatabaseData db)
        {
            _db = db;
        }

        public void OnGet()
        {
            if (SearchEnabled == true)
            {
                AvaliableRoomTypes = _db.GetAvaliableRoomTypes(StartDate, EndDate);
            }
        }

        public IActionResult OnPost()
        {
            return RedirectToPage(new { SearchEnabled = true, StartDate, EndDate });
        }
    }
}
