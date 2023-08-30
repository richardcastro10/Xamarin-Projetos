using ConsultoCep.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ConsultoCep.Views
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