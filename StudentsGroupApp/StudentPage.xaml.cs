namespace StudentsGroupApp;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
	}
    Staff staff = null;

    protected override void OnAppearing()
    {
        staffPicker.ItemsSource = App.Database.GetItemsStaff().ToList();
        var conferences = (Conference)BindingContext;
        if (!String.IsNullOrEmpty(conferences.data))
        {
            staffPicker.SelectedItem = App.Database.GetItemsConference(conferences.conferenceID);
            //groupsPicker.SelectedIndex = 3;
        }
        base.OnAppearing();
    }
    private void SaveConference(object sender, EventArgs e)
    {
        var conferences = (Conference)BindingContext;
        if (!String.IsNullOrEmpty(conferences.data) & !String.IsNullOrEmpty(staff.surname))
        {
            conferences.staffID = staff.staffID;
            App.Database.SaveItemsConference(conferences);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteConference(object sender, EventArgs e)
    {
        var conferences = (Conference)BindingContext;
        App.Database.DeleteItemsConference(conferences.conferenceID);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex != -1)
        {
            staff = (Staff)picker.ItemsSource[selectedIndex];
            StaffID.Text = staff.staffID.ToString();
        }
    }
}