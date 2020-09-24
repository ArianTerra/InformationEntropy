using System;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TextParser
{
    public static class Parser
    {
        public static string GetText(string url)
        {
            string result = String.Empty;
            try
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(url);
                result = htmlDoc.DocumentNode.SelectSingleNode("//body").InnerText;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
