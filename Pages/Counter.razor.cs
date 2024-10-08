﻿using BlazorWasm.Services;
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

        [Inject]
        public IStudentRepo StudentRepo { get; set; }

        private void IncrementCount()
        {
            try
            {
                // throw new Exception("Error 123");

                StudentRepo.Add();
                currentCount++;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        private void ToogleActive()
        {
            _isActive = !_isActive;
        }

        private void GoToIndex()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
