using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//trabajar en json
using System.Web.Script.Serialization;
//para peticiones web 
using System.Net;
//para flujo de datos 
using System.IO;


namespace Avaluos
{
    public class MiServicio
    {
        //poner ruta de servicio a construir 
        private string url { get; set; }

        private HttpWebRequest httpResquest { get; set; }
        private HttpWebResponse httpResponce { get; set; }

        private StreamReader streanReader { get; set; }
        private StreamWriter streaWriter { get; set; }

        private string body { get; set; }
        private string results { get; set; }

        public MiServicio()
        {
            //poner direccion de servicion web
            url = "http://192.168.43.202/mtzWS/";
           // url = "http://localhost/mtzWS/";
            httpResquest = (HttpWebRequest)WebRequest.Create(url);
            httpResquest.ContentType = "application/json";
            httpResquest.Method = "POST";
            streaWriter = new StreamWriter(httpResquest.GetRequestStream());


        }

        public string llamarServicio(string parametros)
        {
            body = parametros;
            streaWriter.InitializeLifetimeService();
            streaWriter.Write(body);
            streaWriter.Flush();
            //pbtener respuesta del web service 
            httpResponce = (HttpWebResponse)httpResquest.GetResponse();

            using (streanReader = new StreamReader(httpResponce.GetResponseStream()))
            {
                results = streanReader.ReadToEnd();
            }

            return results;
        }


    }
}
