using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
namespace Update
{
    /*
     Author:Angelo Ruwantha
     Date:‎Thursday, ‎June ‎13, ‎2013
     Release Date:‎Sunday, ‎December ‎21, ‎2014
   */

    class APP_UPDATER
    {
        
        //Check if Internet Available
        public static string NET()
        {
            string status = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://google.com");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                status = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                status = ex.Message.ToString();
            }
            return status;
        }
       
        public static string CheckVersion(string url)
        {
            string checkV = "";

                if (NET() != "OK")
                {
                    MessageBox.Show("Colud not Connect to Server!\nPlease Check Your Internet Settings\nor Firewall Settings", "Internet Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                
                    WebClient dx = new WebClient();
                    dx.DownloadFile(url, "updates.xml"); //Downloading XML file
                    XmlDocument XmlUpdateFile = new XmlDocument();
                    XmlUpdateFile.Load("updates.xml");
                    foreach (XmlNode x in XmlUpdateFile.SelectNodes("update"))
                    {
                        checkV = x.SelectSingleNode("version").InnerText + "@";
                        checkV += x.SelectSingleNode("PatchUrl").InnerText;
                    }

                }
            return checkV;
        }
    }
}
