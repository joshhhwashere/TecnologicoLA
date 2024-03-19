namespace TecnologicoApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Por favor ingrese el correo electrónico y la contraseña.", "OK");
                return;
            }

            if (email == "usuarios@gmail.com" && password == "Password1234")
            {
                await DisplayAlert("Inicio de Sesión", "Ha iniciado sesión correctamente.", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas. Por favor, inténtelo de nuevo.", "OK");
            }
        }
    }
}