using System;
using System.Globalization;
using System.Windows.Forms;

namespace GlobalConsultingUI
{
    static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var culture = CultureInfo.CurrentCulture.Name;
			System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(culture);
			System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
			Application.CurrentCulture = CultureInfo.CurrentCulture;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
