namespace MAuiMenu;

public partial class DayPage : ContentPage
{
	public DayPage()
	{
		InitializeComponent();
		
		this.BindingContext= new ListViewModel(20);
		
	}
}