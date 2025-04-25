using Microsoft.UI.Xaml;

namespace MauiAppTempoAgora.WinUI
{

    public partial class App : MauiWinUIApplication
    {
 
        public App()
        {
            this.InitializeComponent();

            Platform.MapServiceToken = "z55QeeUbRf6mRhiZDgcP~KpONY3zL1wHlGBeb590zGg~Aky4ub2z4AnvS2RMdaU2VoYIfuWnoDGtOoUfgAi9CngN5iWe3Cps0cGqUdAnBVXT";
        }
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }

}