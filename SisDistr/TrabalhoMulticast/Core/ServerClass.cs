// Decompiled with JetBrains decompiler
// Type: Core.ServerClass
// Assembly: Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C905E59-1448-40AA-80BE-DA507AB59B90
// Assembly location: C:\Users\maiconsilva\Documents\Visual Studio 2015\Projects\Servidores\bin\Debug\Core.dll

using System.Net;

namespace Core
{
  public class ServerClass
  {
    public string ServerName { get; set; }

    public IPAddress IP { get; set; }

    public int Port { get; set; }

    public string Origem { get; set; }

    public string Destino { get; set; }

    public ServerClass(string _ServerName, IPAddress _IP, int _Port, string _Origem, string _Destino)
    {
      this.ServerName = _ServerName;
      this.IP = _IP;
      this.Port = _Port;
      this.Origem = _Origem;
      this.Destino = _Destino;
    }

    public override string ToString()
    {
      return this.ServerName + "|" + this.IP.ToString() + "|" + (object) this.Port;
    }
  }
}
