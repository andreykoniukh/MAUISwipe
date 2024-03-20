namespace MAuiMenu;

public partial class WeekPage : ContentPage
{
	public WeekPage()
	{
		InitializeComponent();
        this.BindingContext = new ListViewModel(500);
    }
}