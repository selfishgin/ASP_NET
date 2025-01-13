using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_LESSON1;

public class WebHost
{
    private short _port;
    private HttpListener _listener;

    public WebHost(short port)
    {
        _port = port;
    }

    public void Run()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add($"http://localhost:{_port}/");
        _listener.Start();
        Console.WriteLine($"Http Server Started on {_port} ...");

        while (true)
        {
            HttpListenerContext context = _listener.GetContext();
            Task.Run(() =>
            {
                HandlerRequest(context);
            });
        }
        

    }

    private void HandlerRequest(HttpListenerContext context)
    {
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;

        var writer = new StreamWriter(response.OutputStream);

        var str = request.RawUrl;

        if (str == "/")
            str = "/index";

        var path = str.Substring(1);


        if(!Path.HasExtension(path))
                path += ".html";

        var fileName = "../../../Views/" + path;
        //var fileName = "Views/" + path;

        try
        {
            if (File.Exists(fileName))
            {
                response.StatusCode = 200;
                response.ContentType = "text/html";
                var text = File.ReadAllText(fileName);
                writer.Write(text);
            }
            else
            {
                response.StatusCode = 404;
                var text = File.ReadAllText("C:\\Users\\Husey_ij91\\source\\repos\\ASPNET_LESSON1\\ASPNET_LESSON1\\Views\\404.html");
                writer.Write(text);
            }
        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            writer.Write(ex.ToString());
        }
        finally
        {
            writer.Dispose();
        }





    }


}
