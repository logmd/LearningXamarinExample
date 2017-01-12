using Autofac;
using GuitarShop.IoC;
using GuitarShop.Layouts;
using Xamarin.Forms;

namespace GuitarShop
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application
            MainPage = new MainPage();
        }

        public IContainer Container { get; private set; }

        protected override void OnStart()
        {
            DependencyService.Register<AppSetup>();
            var setup = DependencyService.Get<AppSetup>();
            setup.CreateContainer();
            Container = setup.Container;
            
        }

        //}
        //    // Handle when your app sleeps
        //{

        //protected override void OnSleep()

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}
    }
}