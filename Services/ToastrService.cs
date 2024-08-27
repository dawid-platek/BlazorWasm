using Microsoft.JSInterop;

namespace BlazorWasm.Services
{
    public class ToastrService
    {
        private IJSRuntime _jSruntime;

        public ToastrService(IJSRuntime jSruntime)
        {
            _jSruntime = jSruntime;
        }

        public async Task ShowInfoMessage(string message)
        {
            await _jSruntime.InvokeVoidAsync("toastrFuntions.showToastrInfo", message);
        }
    }
}
