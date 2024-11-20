using LifeManagementApp.ViewModel;

namespace LifeManagementApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm){
        
        InitializeComponent();
       BindingContext = vm;
	
    }

   
}
