using System;
using System.Resources;
using System.Windows.Forms;
using Solutions.Forms;

namespace Solutions
{
    static class Program
    {
        /// <summary>
        ///     Представляет диспетчер ресурсов, обеспечивающий удобный доступ к ресурсам, 
        ///     связанным с языком и региональными параметрами, во время выполнения.
        /// </summary>
        /// <returns>
        ///     Объект типа System.Resources.ResourceManager
        /// </returns>
        public static ResourceManager ResourceManager { get; } = 
            new ResourceManager("Solutions.Properties.Resources", typeof(Program).Assembly);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
