namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepo { get; set; }

    public static ParametrosRepository ParametrosRepo { get; set; }


    public App(PersonRepository personRepository,ParametrosRepository parametrosRepository)
	{
		InitializeComponent();

		MainPage = new TabbedPageDemo();
        ParametrosRepo = parametrosRepository;
        PersonRepo = personRepository;

    }
}
