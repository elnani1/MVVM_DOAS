using MVVM_bbhdzp.MVVM.Views;

namespace MVVM_bbhdzp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CommandsView();
        }
    }
}
