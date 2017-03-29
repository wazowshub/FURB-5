using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Servidores
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (!(Process.GetProcessesByName("Servidores").Length > 1))
			{
				Application.Run(new Servidores());
			}
			else
			{
				MessageBox.Show(null, "Já existem um gerenciador aberto!", "Atenção!");
			}
		}
	}
}
