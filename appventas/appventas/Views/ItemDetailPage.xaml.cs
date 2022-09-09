using appventas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace appventas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}