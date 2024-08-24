using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.Pages
{

    public partial class JavaScript
    {
        private bool _dialogResult = false;
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        private async Task DisplayAlert()
        {
            await JSRuntime.InvokeVoidAsync("alert", "Przykładowa wiadomość");
        }

        private async Task DisplayConfirmDialog()
        {
            _dialogResult = await JSRuntime.InvokeAsync<bool>("confirm", "Czy na pewno chcesz usunąć rekord?");
        }

        private async Task ShowResultJs()
        {
            await JSRuntime.InvokeVoidAsync("addNumberJS", 1, 2);
        }
    }
}
