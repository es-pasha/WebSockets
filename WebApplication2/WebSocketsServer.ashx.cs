using System.Web;
using Microsoft.Web.WebSockets;

namespace WebApplication2
{
	/// <summary>
	/// Summary description for WebSocketsServer
	/// </summary>
	public class WebSocketsServer : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			if (context.IsWebSocketRequest)
			{
				context.AcceptWebSocketRequest(new MicrosoftWebSocets());
			}
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}