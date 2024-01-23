namespace TemasDelSistema
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            //Application.Current.UserAppTheme = AppTheme.Dark;

            AppTheme temaActual = Application.Current.RequestedTheme;

            Label label = new Label();
            label.SetAppThemeColor(Label.TextColorProperty, Colors.Purple, Colors.White);
            label.Text = $"Este texto hace referencia al que esta construido con C#, el tema actual del sistema es:  {temaActual}";

            Image image = new Image();
            image.SetAppTheme<FileImageSource>(Image.SourceProperty, "darkimg.png", "lightimg.png");
            image.WidthRequest = 100;
            image.HeightRequest = 100;

            stack.Children.Add(label);
            stack.Children.Add(image);

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                Application.Current.MainPage.DisplayAlert("Alerta", "Cambio el tema", "Ok");
            };
        }

        
    }

}
