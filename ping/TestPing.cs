using System;
using System.Net;
using System.Net.Sockets;

namespace Template

{
  class Program
  {
    static void Main(string[] args)
    {

      Ping netMon = new Ping();

      PingResponse response = netMon.PinHost("localhost", 4);

      if (response != null)
      {
        ProcessResponse(response);
      }

    }
  }
}
