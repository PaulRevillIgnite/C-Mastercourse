using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorHomework.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Firstname { get; set; }
        [BindProperty]
        public string Lastname { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
