using System.Globalization;
using System.Threading;
using System.Windows;

namespace TurkmenCalculator
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tk");
        }
    }
}
