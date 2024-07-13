

using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private bool _isActive = false;

        [Parameter]
        public int Header { get; set; }

        [Parameter]
        public bool? IsDeleted { get; set; }

        [SupplyParameterFromQuery(Name = "Header2")]
        public string Header2 { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void IncrementCount()
        {
            currentCount++;
        }

        private void ToogleActive()
        {
            _isActive = !_isActive;
        }

        private void GoToIndex()
        {
            NavigationManager.NavigateTo("/counter-par/99/true");
        }
    }
}
