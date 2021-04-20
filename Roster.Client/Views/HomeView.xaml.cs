using System.Reflection;
using Xamarin.Forms;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new Header();
        }
    }

    public class Header
    {
        public string Title { get => "Roster App"; }
    }
}