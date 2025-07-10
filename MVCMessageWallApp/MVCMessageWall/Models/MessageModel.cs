using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Cool Message")]
        public string Message { get; set; }
    }
}
