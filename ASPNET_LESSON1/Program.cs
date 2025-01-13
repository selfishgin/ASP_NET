using System.Net;
using System.Text;
using ASPNET_LESSON1;

Console.WriteLine("Hello, World!");
// -----------------------------------------------------------------------
#region HttpListener
//HttpListener listener = new();
//listener.Prefixes.Add("http://localhost:27001/");
//listener.Start();
//Console.WriteLine("I am listening...");

//while (true)
//{
//    HttpListenerContext context = listener.GetContext();
//    Console.WriteLine("Request Handler");
//    context.Response.OutputStream.Write(Encoding.UTF8.GetBytes("Hello world"));
//    context.Response.Close();
//}

#endregion

WebHost myHost = new(27001);
myHost.Run();