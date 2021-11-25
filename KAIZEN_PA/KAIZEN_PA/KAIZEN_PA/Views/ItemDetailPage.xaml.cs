using KAIZEN_PA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KAIZEN_PA.Views
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