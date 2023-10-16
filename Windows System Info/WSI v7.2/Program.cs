using Windows_System_Info_Form_And_Designer;

namespace Windows_System_Info_Program
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormJanelaPrincipal());
        }
    }
}
