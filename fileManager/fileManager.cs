using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace fileManager
{
    public partial class frmFileManager : Form
    {
        public frmFileManager()
        {
            InitializeComponent();

            //Check and load XML config file
            loadXML();

        }


        //**************
        //  XML shenanigans
        //**************
        #region XML_Subroutines

        private void loadXML()
        { 

            //Check to see if the file currently exists
            //if not, create it - call createXML()
            //XML should reside in program root
            //XML should be called fileManagerConfig.XML

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + globalVars.gsXMLFilename))
            {
                //Load xml values
                string lsXMLFile = AppDomain.CurrentDomain.BaseDirectory + globalVars.gsXMLFilename;

                XmlDocument doc = new XmlDocument();
                doc.Load(lsXMLFile);
                XmlNode root = doc.DocumentElement;
                //XmlNode myNode = root.SelectSingleNode("fileManagerConfig::settings::backupNow::backupNowSource");
                //XmlNode myNode = root.SelectSingleNode("backupNowSource");
                //doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowSource").Attributes["value"].Value = txtSource.Text;
                txtSource.Text = doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowSource").InnerText.ToString();
                txtDest.Text = doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowDest").InnerText.ToString();
                //myNode.Value = txtSource.Text;
                //doc.Save(lsXMLFile);
                


            }
            else 
            {
                createXML();
            }

        }

        private void createXML()
        { 

            //If the XML does not currently exist, it was either moved or this is the first run
            //Create XML in program root
            //XML should be called fileManagerConfig.XML

            string lsXMLFile = AppDomain.CurrentDomain.BaseDirectory + globalVars.gsXMLFilename;

            XmlTextWriter writer = new XmlTextWriter(lsXMLFile, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("fileManagerConfig");
            writer.WriteStartElement("settings");

            //createNode("1", "Product 1", "1000", writer);
                writer.WriteStartElement("backupNow");

                writer.WriteStartElement("backupNowSource");
                writer.WriteString("");
                writer.WriteEndElement();
                writer.WriteStartElement("backupNowDest");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteEndElement();

            //createNode("2", "Product 2", "2000", writer);

            //createNode("3", "Product 3", "3000", writer);

            //createNode("4", "Product 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            //MessageBox.Show("XML File created ! ");


            //writer.WriteStartElement("Product");
            //writer.WriteStartElement("Product_id");
            //writer.WriteString(pID);
            //writer.WriteEndElement();
            //writer.WriteStartElement("Product_name");
            //writer.WriteString(pName);
            //writer.WriteEndElement();
            //writer.WriteStartElement("Product_price");
            //writer.WriteString(pPrice);
            //writer.WriteEndElement();
            //writer.WriteEndElement();
        
        }
        #endregion

        //**************
        //  Backup Now!
        //**************

        #region Backup_Now


        private void btnRemember_Click(object sender, EventArgs e)
        {

            string lsXMLFile = AppDomain.CurrentDomain.BaseDirectory + globalVars.gsXMLFilename;

            XmlDocument doc = new XmlDocument();
            doc.Load(lsXMLFile);
            XmlNode root = doc.DocumentElement;
            //XmlNode myNode = root.SelectSingleNode("fileManagerConfig::settings::backupNow::backupNowSource");
            //XmlNode myNode = root.SelectSingleNode("backupNowSource");
            //doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowSource").Attributes["value"].Value = txtSource.Text;
            doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowSource").InnerText = txtSource.Text;
            doc.SelectSingleNode("/fileManagerConfig/settings/backupNow/backupNowDest").InnerText = txtDest.Text;
            //myNode.Value = txtSource.Text;
            doc.Save(lsXMLFile);




            //XmlDocument doc = new XmlDocument();
            //string path = @"C:\MyFiles\TestApp\WindowsFormsApplication1\WindowsFormsApplication1\XMLFile1.xml";
            //doc.Load(path);
            //doc.SelectSingleNode("/appSettings/add").Attributes["value"].Value = "hello";
            //doc.Save(path);




        }

        #endregion


        //**************
        //  Backup Later
        //**************
      



        //**************
        //  Menu Items
        //**************
        # region menu_items



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }

        private void fAQsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jstienstra/data-management/wiki/FAQs");
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jstienstra/data-management/wiki");
        }


        #endregion




    }











}
