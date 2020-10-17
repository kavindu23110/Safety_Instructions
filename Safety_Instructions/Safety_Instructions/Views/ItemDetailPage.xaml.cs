using System.ComponentModel;
using Xamarin.Forms;
using Safety_Instructions.ViewModels;

namespace Safety_Instructions.Views
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