
namespace MyWPFApp
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new MyUWPApp.App())
            {
                var app = new MyWPFApp.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}