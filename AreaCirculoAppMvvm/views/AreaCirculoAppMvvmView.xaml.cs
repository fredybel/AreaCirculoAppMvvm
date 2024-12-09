using AreaCirculoAppMvvm.ViewModels;

namespace AreaCirculoAppMvvm.views;

public partial class AreaCirculoAppMvvmView : ContentPage
{
	AreaCirculoAppMvvmViewModel ViewModel;
	public AreaCirculoAppMvvmView()
	{
		InitializeComponent();
		ViewModel = new AreaCirculoAppMvvmViewModel();
		BindingContext = ViewModel;
	}
}