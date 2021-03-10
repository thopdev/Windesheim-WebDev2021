using System.ComponentModel.DataAnnotations;

namespace Windesheim.WebDev.Blazor.Models
{
    public class NewTodoItemModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Maximum length for a new task is 25 characters")]
        public string Text { get; set; }
    }
}
