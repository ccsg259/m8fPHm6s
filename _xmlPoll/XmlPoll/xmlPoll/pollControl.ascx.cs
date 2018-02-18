using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;

namespace xmlPoll
{
    public partial class pollControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (IsExist(GetIpAddress()))
                    MultiView1.ActiveViewIndex = 1;
                else
                {
                    MultiView1.ActiveViewIndex = 0;
                    pollInformation();
                }
            }
        }

        bool IsExist(string IpAddress)
        {
            string path = Server.MapPath(@"App_Data/list.xml");
            XDocument myXml = XDocument.Load(path);
            return myXml.Descendants("Ip").Where(n => ((string)n.Attribute("Address").Value == IpAddress)).Count() != 0;
        }

        string GetIpAddress()
        {
            if (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null)
                return Request.ServerVariables["REMOTE_ADDR"];
            else
                return Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        }

        void AddIpAddress(string IpAddress)
        {
            string path = Server.MapPath(@"App_Data/list.xml");
            XDocument myXml = XDocument.Load(path);
            //add
            myXml.Root.Add(new XElement("Ip",
                                        new XAttribute("Address", IpAddress)));
            //save
            myXml.Save(path);
        }

        void pollInformation()
        {
            string path = Server.MapPath(@"App_Data/pollData.xml");
            //input xml doc
            XDocument myXml = XDocument.Load(path);
            //get header
            lblHead.Text = myXml.Element("Poll").Attribute("name").Value;
            //get answers
            foreach (var att in myXml.Element("Poll").Elements("answer"))
                rbQ.Items.Add(att.Attribute("text").Value);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string IpAddress = GetIpAddress();
            if (rbQ.SelectedValue != string.Empty && !IsExist(IpAddress))
            {
                string path = Server.MapPath(@"App_Data/pollData.xml");
                //input xml doc
                XDocument myXml = XDocument.Load(path);
                //get value of vote
                int value = Convert.ToInt32(myXml
                    .Descendants("answer")
                    .Where(n => ((string)n.Attribute("text").Value == rbQ.SelectedValue)).Single().Value);
                //increase value +1
                value++;
                //set new value of vote
                myXml.Descendants("answer").Single(n => ((string)n.Attribute("text").Value == rbQ.SelectedValue)).Value = value.ToString();
                //save xml doc
                myXml.Save(path);
                //add ipaddress
                AddIpAddress(IpAddress);
            }
            MultiView1.ActiveViewIndex = 1;
        }
    }
}