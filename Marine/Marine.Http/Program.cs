using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Marine.Http
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://www.baidu.com");

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            WebHeaderCollection responseHeader = webResponse.Headers;

            Console.WriteLine("{0} / {1}", webResponse.StatusCode, webResponse.StatusDescription);

            System.Collections.IEnumerator ienum = responseHeader.GetEnumerator();
            int i = 0;
            ienum.Reset();
            while (ienum.MoveNext())
            {
                Console.WriteLine("{0}={1}\r\n", responseHeader.GetKey(i), responseHeader.Get(i));
                i++;
            }


            //Char[] readBuffer = new Char[256];
            //int count = streamReader.Read(readBuffer, 0, 256);
            //while (count > 0)
            //{
            //    string outputData = new string(readBuffer, 0, count);
            //    content += outputData;
            //    count = streamReader.Read(readBuffer, 0, 256);
            //}
            webResponse.Close();
            Console.WriteLine(content);
            Console.Read();
        }
    }
}
