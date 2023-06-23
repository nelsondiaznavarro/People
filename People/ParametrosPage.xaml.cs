namespace People;

public partial class ParametrosPage : CustomControls.MasterPage
{
	public ParametrosPage()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.ParametrosRepo.AddNewParametro(newParametro.Text,newValor.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        //List<Person> people = App.PersonRepo.GetAllPeople();
        //peopleList.ItemsSource = people;
    }
}