// Decompiled with JetBrains decompiler
// Type: Core.Listener
// Assembly: Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C905E59-1448-40AA-80BE-DA507AB59B90
// Assembly location: C:\Users\maiconsilva\Documents\Visual Studio 2015\Projects\Servidores\bin\Debug\Core.dll

using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Core
{
	public abstract class Listener
	{
		private IPEndPoint EndPointListener;
		private IPEndPoint EndPointSenderAll;
		public string HostName;
		protected bool Ativa;
		protected IPEndPoint EndPointToNewClients;

		public IPAddress Grupo { get; set; }

		public UdpClient Cliente { get; set; }

		public Listener(string _HostName)
		{
			this.HostName = _HostName;
			this.Grupo = IPAddress.Parse("224.0.0.5");
			this.Cliente = new UdpClient();
			this.Cliente.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
			this.Cliente.JoinMulticastGroup(this.Grupo);
			this.EndPointSenderAll = new IPEndPoint(this.Grupo, this.PortToSendAll());
			this.EndPointListener = new IPEndPoint(IPAddress.Any, this.PortToListen());
			this.Cliente.Client.Bind((EndPoint)this.EndPointListener);
			this.Ativa = true;
			new Thread(new ThreadStart(this.StartListening))
			{
				IsBackground = true
			}.Start();
		}

		private void StartListening()
		{
			while (this.Ativa)
			{
				if (this.Cliente.Available > 0)
					this.AfterListen(Encoding.ASCII.GetString(this.Cliente.Receive(ref this.EndPointListener)).Split('|'));
			}
		}

		public void NotifyToAll(bool _In)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(this.InfoToSend(_In));
			this.Cliente.Send(bytes, bytes.Length, this.EndPointSenderAll);
			this.Ativa = _In;
			if (!this.Ativa)
			{
				this.Cliente.Client.Close();
				this.LiberarPortas();
			}
			this.AfterSend();
		}

		protected void SendMessage(IPEndPoint EPDestiny, string message)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(message);
			this.Cliente.Send(bytes, bytes.Length, EPDestiny);
		}

		protected abstract int PortToListen();

		protected abstract int PortToSendAll();

		protected abstract string InfoToSend(bool _In);

		protected abstract void AfterListen(string[] Parameters);

		protected abstract void AfterSend();

		protected abstract void LiberarPortas();
	}
}
