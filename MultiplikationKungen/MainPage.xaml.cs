using MultiplikationKungen;
using MultiplikationKungen.Data;




namespace MultiplikationKungen
{


    public partial class MainPage : ContentPage
    {    
        private readonly AppDatabase _database;
        private bool _isInitialized = false;

        public MainPage(AppDatabase database)
        {
            InitializeComponent();

            _database = database;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_isInitialized)
                return;

            await _database.InitializeAsync();

            _isInitialized = true;
        }

    }
}
