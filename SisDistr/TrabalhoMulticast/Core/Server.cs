// Decompiled with JetBrains decompiler
// Type: Core.Server
// Assembly: Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C905E59-1448-40AA-80BE-DA507AB59B90
// Assembly location: C:\Users\maiconsilva\Documents\Visual Studio 2015\Projects\Servidores\bin\Debug\Core.dll

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text;

namespace Core
{
	public class Server : Listener
	{
		private TcpListener TCPConnection;
		TcpClient client;
		private IPEndPoint TCPLocalEP;
		public int TCPPort;
		public string PathOrigem;
		public string PathDestino;

		public Server(string _HostName, int _PortaTCP, string _PathOrigem, string _PathDestino)
		  : base(_HostName)
		{
			this.EndPointToNewClients = new IPEndPoint(this.Grupo, 10020);
			this.PathOrigem = _PathOrigem;
			this.PathDestino = _PathDestino;
			this.TCPPort = _PortaTCP;
			this.TCPConnection = new TcpListener(IPAddress.Any, TCPPort);
			this.TCPConnection.Start();
			new Thread(new ThreadStart(this.ListenTCP))
			{
				IsBackground = true
			}.Start();
		}

		protected override void LiberarPortas()
		{
			this.TCPConnection.Stop();
		}

		private void ListenTCP()
		{
			while (this.Ativa)
			{
				if (TCPConnection.Pending())
				{
					client = TCPConnection.AcceptTcpClient();
					Copy(PathOrigem, PathDestino);
					client.Close();
				}
			}
		}

		private void Copy(string sourceDir, string targetDir)
		{
			try
			{
				Directory.CreateDirectory(targetDir);

				foreach (var file in Directory.GetFiles(sourceDir))
					File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

				foreach (var directory in Directory.GetDirectories(sourceDir))
					Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));


				client.GetStream().Write(Encoding.ASCII.GetBytes("true "), 0, 5);
			}
			catch (Exception e)
			{
				client.GetStream().Write(Encoding.ASCII.GetBytes("false"), 0, 5);
				client.GetStream().Write(Encoding.Unicode.GetBytes(e.Message), 0, e.Message.Length);
			}
		}

		protected override string InfoToSend(bool _In)
		{
			return this.HostName + "|" + _In.ToString() + "|" + (object)this.TCPPort + "|" + this.PathOrigem + "|" + this.PathDestino + "|" + GetLocalIPAddress();
		}

		protected override int PortToListen()
		{
			return 20010;
		}

		protected override int PortToSendAll()
		{
			return 10010;
		}

		protected override void AfterListen(string[] Parameters)
		{
			if (!bool.Parse(Parameters[1]))
				return;
			Console.WriteLine(Parameters[0] + " asking informations...");
			this.SendMessage(this.EndPointToNewClients, this.InfoToSend(true));
		}

		protected override void AfterSend()
		{
		}

		private string GetLocalIPAddress()
		{
			foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
			{
				if (address.AddressFamily == AddressFamily.InterNetwork)
					return address.ToString();
			}
			throw new Exception("Local IP Address Not Found!");
		}
	}
}
