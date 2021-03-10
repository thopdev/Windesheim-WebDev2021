using Microsoft.AspNetCore.Components;
using Windesheim.WebDev.Blazor.Models;

namespace Windesheim.WebDev.Blazor.Pages
{
    public partial class NewTodoItemComponent
    {
        public NewTodoItemModel NewTodoItem { get; set; } = new NewTodoItemModel();

        [Parameter]
        public EventCallback<string> OnNewItem { get; set; }

        public void OnSubmit()
        {
            OnNewItem.InvokeAsync(NewTodoItem.Text);
            NewTodoItem = new NewTodoItemModel();
        }
    }
}
