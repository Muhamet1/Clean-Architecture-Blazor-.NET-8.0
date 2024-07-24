using Core.Models;

namespace InventoryManagment.UI.Components.Pages
{
    public partial class Home
    {
        protected List<Item> items = new();

        protected override async Task OnInitializedAsync()
        {
            items= await IItemService.GetItems();
        }

    }
}
