# Windesheim-WebDev2021
This repo contains all the instructions and information for the Windesheim WebDev

### Setup
- [ ] 1.1 Verify that you have .Net version 5.0.* with **dotnet --version**  
*If you don't have this version: https://dotnet.microsoft.com/download*  
- [ ] 1.2 Open Visual studio and create a new **Blazor App** project with the following settings:  
*.NET 5.0  
Blazor WebAssembly App  
**Unchecked** Asp .Net Core Hosted*

### Todo list
- [ ] 2.1 Create a new [Compontent](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0) in the Pages Folder (TodoListComponent)
- [ ] 2.2 Add the component to the Pages/Index.razor
- [ ] 2.3 Add a list of string to the component and display the list on the component *Insert a few options into the list*

### Click event
- [ ] 3.1 Add a checkbox before each item in the TodoListComponent
- [ ] 3.2 Create a function that removes a item from the list by value on the TodoListComponent
- [ ] 3.3 Trigger the function when a change occours on the checkbox. [Event handeling](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0)  

### New Tasks
- [ ] 4.1 Create a new Component in the Pages Folder (NewTodoItemComponent) and add it to your TodoListComponenent
- [ ] 4.2 Create a EditForm with a text input and button [Forms](https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0)\  
*Make sure to add some validation and user feedback*
- [ ] 4.3 Create the property EventCallback<string> with the attribute [Parameter]
- [ ] 4.4 Create a function that triggers the EventCallback and clears the form
- [ ] 4.5 Trigger the function on valid submit from the form
- [ ] 4.6 On the TodoListComponent, Handle the event of the NewTodoItemComponent and add the value to the list

## Additional
### bUnit Unit testing
- [ ] 5.1 Create a Xunit project (Make sure it is .Net 5.0
- [ ] 5.2 Add the following packages to it.  
*bunit.web 1.0.0-preview-01  
bunit.xunit 1.0.0-preview-01*
- [ ] 5.3 Add the Blazor project as depedency
- [ ] 5.4 Create a new class with a test
```
using var context = new TestContext();

var component = context.RenderComponent<TodoListComponent>();

Assert.Equal(2, component.FindAll("input[type=checkbox]").Count);
```
- [ ] 5.5 Can you add more tests?
### Features!
- [ ] 6. Can you add more features and add some styling?
