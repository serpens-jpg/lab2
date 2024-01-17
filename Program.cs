using _8xml.Forms;

namespace _8xml
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MyForm());
        }
    }
}