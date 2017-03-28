using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using Core;

namespace Cliente
{
    public class Client : Listener
    {
        private UdpClient NewClients;
		private ClientForm.AdicionarItens AddItemLista;
		public List<ServerClass> ListView;
		public DataGridView GridServer;

        public Client(string _HostName, ClientForm.AdicionarItens AddMethod, DataGridView _Grid) : base(_HostName)
        {
            NewClients = new UdpClient();
            NewClients.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            NewClients.JoinMulticastGroup(Grupo);
            EndPointToNewClients = new IPEndPoint(IPAddress.Any, 10020);
            NewClients.Client.Bind(EndPointToNewClients);
            ListView = new List<ServerClass>();
			AddItemLista = AddMethod;
			GridServer = _Grid;
		}

        protected override string InfoToSend(bool _In)
        {
            return HostName +  "|" + _In;
        }

        protected override int PortToListen()
        {
            return 10010;
        }

        protected override int PortToSendAll()
        {
            return 20010;
        }

        protected override void AfterListen(string[] Parameters)
        {
            if (Boolean.Parse(Parameters[1]))
            {
                ListView.Add(new ServerClass(Parameters[0], IPAddress.Parse(Parameters[5]), Int32.Parse(Parameters[2]),Parameters[3], Parameters[4]));
            }
            else
            {
				for (int i = 0; i < ListView.Count; i++)
				{
                    if (ListView[i].ToString() == new ServerClass(Parameters[0], IPAddress.Parse(Parameters[5]), Int32.Parse(Parameters[2]), Parameters[3], Parameters[4]).ToString())
                        ListView.RemoveAt(i);
                }
            }

			GridServer.Invoke(new ClientForm.AdicionarItens(AddItemLista), ListView);
		}

		protected override void LiberarPortas()
		{
		}

		protected override void AfterSend()
        {
            Thread.Sleep(1000);
            while (NewClients.Available > 0)
            {
                Byte[] data = NewClients.Receive(ref EndPointToNewClients);
                string[] Parameters = Encoding.ASCII.GetString(data).Split('|');
                ListView.Add(new ServerClass(Parameters[0], EndPointToNewClients.Address, Int32.Parse(Parameters[2]), Parameters[3], Parameters[4]));
			}

			AddItemLista(ListView);
			NewClients.Client.Close();
		}

		public void IniciaBackUp(string ip, string porta)
		{
			TcpClient cliente = new TcpClient(ip, Int32.Parse(porta));
			while (true)
			{
				if (cliente.Available > 0)
				{
					byte[] buffer = new byte[5];
					cliente.GetStream().Read(buffer, 0, 5);
					var ans = Encoding.ASCII.GetString(buffer);

					if (Boolean.Parse(ans.Trim()))
					{
						MessageBox.Show(null, "Backup realizado com sucesso!", "Informção");
						break;
					}
					else
					{
						byte[] MsgErro = new byte[1024];
						cliente.GetStream().Read(MsgErro, 0, 1024);
						var erro = Encoding.Unicode.GetString(MsgErro);
						MessageBox.Show(null, "Falha no meio do backup! " + erro, "Atenção");
						break;
					}
				}
			}

			cliente.Close();
		}
	}
}
