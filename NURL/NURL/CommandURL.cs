/*
 * Created by SharpDevelop.
 * User: Cédric
 * Date: 29/05/2014
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;

namespace NURL
{
	/// <summary>
	/// Description of CommandURL.
	/// </summary>
	public class CommandURL
	{
        public string Datas { get; set; }
        public double avg { get; set; }
        public double Time { get; set; }


        public void GetData(string url)
        {
            try
            {
                var client = new WebClient();
                Datas =  RemoveRetourChariot((client.DownloadString(url)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex.Message);
            }
        }
        
        public string RemoveRetourChariot(string str)
        {
            if (str != null)
            {
                str.Remove(str.Length - 2);
            }
            return str;
        }

        public void Save(string path, string datas)
        {

        }

       //public string GetFileName(string url)
       //{

       //}

        public void testConnectionTime(string url, int times)
        {

        }

        public void AvgTestConnection(string url, int times)
        {


        }

        public void DispatchArgs(string[] consoleArgs)
        {
            for (int i = 0; i < consoleArgs.Length; i++)
            {
                switch (consoleArgs[i])
                {
                    case "get":
                        if (consoleArgs[i + 1] == "-url")
                        {
                            GetData(consoleArgs[i + 2]);
                            Console.WriteLine(Datas);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option");
                            return;
                        }
                        break;

                    case "test":
                        if (consoleArgs[i + 1] == "-url")
                        {
                            var url = consoleArgs[i + 2];
                            if (consoleArgs[i + 3] == "-time")
                            {
                                int time;
                                if (!int.TryParse(consoleArgs[i + 4], out time))
                                {
                                    Console.WriteLine("Invalid argument");
                                    return;
                                }
                                try
                                {
                                    var avg = consoleArgs[i + 5];
                                    if (avg == "-avg")
                                    {
                                        AvgTestConnection(url, time);
                                        return;
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    testConnectionTime(url, time);
                                    return;
                                }
                            }
                            else
                                Console.WriteLine("Invalid option");
                        }
                        break;
                 	case "-save":
	                        string file = consoleArgs[i + 1];
	                        Save(file, Datas);
                    break;
                }
            }
        }

    }
}

