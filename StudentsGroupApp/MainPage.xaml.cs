namespace StudentsGroupApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        studentsList.ItemsSource = App.Database.GetItemsConference();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Conference selectedConference = (Conference)e.SelectedItem;
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = selectedConference;
        await Navigation.PushAsync(studentPage);
    }
    // обработка нажатия кнопки добавления
    private async void CreateConference(object sender, EventArgs e)
    {
        Conference conferences = new Conference();
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = conferences;
        await Navigation.PushAsync(studentPage);
    }
}

