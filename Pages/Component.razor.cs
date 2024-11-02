using BlazorWasm.Models;

namespace BlazorWasm.Pages
{
    public partial class Component
    {
        private string _info = "Komunikat 123";
        private string _title = "Tytuł123!!";
        private List<CardModel> _authors = new List<CardModel>
        {
                    new CardModel { Title = "Jan Kowalski", Content = "Programista C#/.NET z 20 letnim doświadczeniem.Specjalizacje: Blazor i ASP.NET Core", Image = "/files/kowalski.png", BtnText = "Więcej"},
                    new CardModel { Title = "Anna Nowak", Content = "Programista C#/.NET z 10 letnim doświadczeniem.Specjalizacje: WPF", Image = "/files/nowak.png", BtnText = "Więcej"},
                    new CardModel { Title = "Błażej Kwiatkowski", Content = "Programista C#/.NET z 3 letnim doświadczeniem.Specjalizacje: Frontend", Image = "/files/kwiatkowski.png", BtnText = "Więcej" }
        };
    }
}

