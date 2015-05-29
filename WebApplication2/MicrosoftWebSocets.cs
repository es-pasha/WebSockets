using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2
{
	public class MicrosoftWebSocets : WebSocketHandler
	{
		private static WebSocketCollection _clients = new WebSocketCollection();

		public override void OnOpen()
		{
			_clients.Add(this);
		}

		public override void OnMessage(string url)
		{
			this.Send(DateTime.Now.ToShortTimeString() +  " count connections: " + _clients.Count.ToString());
		}

		public override void OnClose()
		{
			_clients.Remove(this);
		}
	}
}
