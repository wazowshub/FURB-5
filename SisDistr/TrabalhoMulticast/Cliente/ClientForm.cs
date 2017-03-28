using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Cliente
{
	public partial class ClientForm : Form
	{
		Client c;

		public delegate void AdicionarItens(List<ServerClass> ListaServer);

		public ClientForm()
		{
			InitializeComponent();
		}

		private void ClientForm_Load(object sender, EventArgs e)
		{
			this.c = new Client("", new AdicionarItens(AddItem), ListaServidores);
			c.NotifyToAll(true);
		}

		private void AddItem(List<ServerClass> Server)
		{
			ListaServidores.Rows.Clear();

			foreach (var p in Server)
			{
				ListaServidores.Rows.Add();
				ListaServidores.Rows[ListaServidores.Rows.Count - 2].Cells[0].Value = p.ServerName;
				ListaServidores.Rows[ListaServidores.Rows.Count - 2].Cells[1].Value = p.IP;
				ListaServidores.Rows[ListaServidores.Rows.Count - 2].Cells[2].Value = p.Port;
				ListaServidores.Rows[ListaServidores.Rows.Count - 2].Cells[3].Value = p.Origem;
				ListaServidores.Rows[ListaServidores.Rows.Count - 2].Cells[4].Value = p.Destino;
			}
		}

		private void Start_Click(object sender, EventArgs e)
		{
			var ip = ListaServidores.SelectedRows[0].Cells[1].Value.ToString();
			var porta = ListaServidores.SelectedRows[0].Cells[2].Value.ToString();

			c.IniciaBackUp(ip,porta);
		}
	}
}
