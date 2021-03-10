using System.Collections.Generic;

namespace Windesheim.WebDev.Blazor.Pages
{
    public partial class TodoListComponent
    {
        public List<string> Tasks { get; set; } = new List<string>
        {
            "Add input form",
            "Add local storage"
        };

        public void OnCheckboxCheck(string value)
        {
            Tasks.Remove(value);
            StateHasChanged();
        }
    }
}
