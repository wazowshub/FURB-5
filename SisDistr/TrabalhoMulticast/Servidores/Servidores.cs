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
using System.IO;

namespace Servidores
{
	public partial class Servidores : Form
	{
		public Dictionary<String,Server> ServerAtivos;

		public Servidores()
		{
			InitializeComponent();
		}

		private void Servidores_Load(object sender, EventArgs e)
		{
			ServerAtivos = new Dictionary<String,Server>();
		}

		private void Servidores_Leave(object sender, EventArgs e)
		{
			MessageBox.Show("");
		}

		private void AdicionarBT_Click(object sender, EventArgs e)
		{
			if (ValidarAdd())
			{
				if (!ServerJaExiste())
				{
					if (PortaValida())
					{
						if (PortaLivre())
						{
							var s = new Server(ServerName.Text, Int32.Parse(Porta.Text), Path.GetFullPath(OrigemBackUp.Text), Path.GetFullPath(SalvarEm.Text));
							AdicionarServer(s);
							s.NotifyToAll(true);
							MessageBox.Show(null, "Servidor adicionado com sucesso!", "Informação");
						}
						else
						{
							MessageBox.Show(null, "Porta em uso!", "Atenção");
						}
					}
					else
					{
						MessageBox.Show(null, "Porta inválida! Somente valores de 1025 até 65535 são válidos!", "Atenção");
					}
				}
				else
				{
					MessageBox.Show(null, "Servidor já registrado!", "Atenção");
				}
			}
			else
			{
				MessageBox.Show(null,"Preenche todas as informações!","Atenção");
			}
		}

		private bool ValidarAdd()
		{
			return ((ServerName.Text.Trim() != "") &&
				(Porta.Text.Trim() != "") &&
				(OrigemBackUp.Text.Trim() != "") &&
				(SalvarEm.Text.Trim() != ""));
		}

		private void Porta_KeyPress(object sender, KeyPressEventArgs e)
		{
			{
				if (!char.IsDigit(e.KeyChar) && !((e.KeyChar == (char)Keys.Delete) || (e.KeyChar == (char)Keys.Back)))
				{
					e.Handled = true;
				}
			}
		}

		private void ProcurarBT_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					OrigemBackUp.Text = fbd.SelectedPath;
				}
			}
		}

		private void SalvarBT_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					SalvarEm.Text = fbd.SelectedPath;
				}
			}
		}

		private bool ServerJaExiste()
		{
			return ServerAtivos.ContainsKey(ServerName.Text + ":" + Porta.Text);
		}

		private void AdicionarServer(Server server)
		{
			ServerAtivos.Add(ServerName.Text + ":" + Porta.Text, server);
			AttLista();
		}

		private void AttLista()
		{
			ListaServers.Rows.Clear();

			foreach (var p in ServerAtivos)
			{
				ListaServers.Rows.Add();
				ListaServers.Rows[ListaServers.Rows.Count - 2].Cells[0].Value = p.Value.HostName;
				ListaServers.Rows[ListaServers.Rows.Count - 2].Cells[1].Value = p.Value.TCPPort;
				ListaServers.Rows[ListaServers.Rows.Count - 2].Cells[2].Value = p.Value.PathOrigem;
				ListaServers.Rows[ListaServers.Rows.Count - 2].Cells[3].Value = p.Value.PathDestino;
			}
		}

		private bool PortaLivre()
		{
			foreach (var s in ServerAtivos)
			{
				if (s.Value.TCPPort == Int32.Parse(Porta.Text))
				{
					return false;
				}
			}

			return true;
		}

		private bool PortaValida()
		{
			return ((Int32.Parse(Porta.Text) > 1024) && (Int32.Parse(Porta.Text) < 65536));
		}
		
		private void Remover_Click(object sender, EventArgs e)
		{
			Server server = null;
			ServerAtivos.TryGetValue(ListaServers.SelectedRows[0].Cells[0].Value + ":" + ListaServers.SelectedRows[0].Cells[1].Value, out server);
			ExcluirServer(server);
		}

		private void ExcluirServer(Server server)
		{
			if (server != null)
			{
				server.NotifyToAll(false);
				ServerAtivos.Remove(server.HostName + ":" + server.TCPPort);
				AttLista();
			}
		}

		private void Servidores_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (ServerAtivos.Count > 0)
			{
				ExcluirServer(ServerAtivos.ElementAt(0).Value);
			}
		}
	}
}
