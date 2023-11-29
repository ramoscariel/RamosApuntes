
namespace RamosApuntes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => ":3";
        public string MoreInfoUrl => "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        public string Message => "Esta app fue escrita en XAML y C# con .NET MAUI.";
    }
}
