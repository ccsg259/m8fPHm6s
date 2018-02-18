using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForm_Poll_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitVote(string theVote)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("Poll.xml");
                
                xmlDoc.Element("Poll").Add(new XElement("Vote", new XElement("Choice", theVote)));

                xmlDoc.Save("Poll.xml");
                lblResults.Text = "Thank you for your vote.";
                readXML();
            }
            catch
            {
                lblResults.Text = "Sorry, unable to process request. Please try again.";
            }
        }

        private void butResults_Click(object sender, EventArgs e)
        {
            readXML();
        }

        private void readXML()
        {
            XDocument xmlDoc = XDocument.Load("Poll.xml");

            var votes = from vote in xmlDoc.Descendants("Vote")
                        select new
                        {
                            Vote = vote.Element("Choice").Value,
                        };

            int mCount;
            int oCount;
            mCount = 0;
            oCount = 0;

            foreach (var vote in votes)
            {
                if (vote.Vote == "McCain")
                    mCount++;
                else if (vote.Vote == "Obama")
                    oCount++;
            }

            double theTotal;
            theTotal = mCount + oCount;
            double mPercent;
            double oPercent;
            mPercent = (mCount/theTotal)*100;
            oPercent = (oCount/theTotal)*100;

            lblResults.Text = "McCain: " + mCount + " votes (" + mPercent + "%).\n";
            lblResults.Text = lblResults.Text + "Obama: " + oCount + " votes (" + oPercent + "%).\n\n";
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (radMcCain.Checked == true)
                submitVote("McCain");
            else if (radObama.Checked == true)
                submitVote("Obama");
        }
    }
}
