

namespace BlazorWasm.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private bool _isActive = false;

        private void IncrementCount()
        {
            currentCount++;
        }

        private void ToogleActive()
        {
            _isActive = !_isActive;
        }
    }
}
