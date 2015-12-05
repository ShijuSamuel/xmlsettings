using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace xmlsettings
{
    public partial class Main : Form
    {
        List<Settings> _settings;
        public Main()
        {
            InitializeComponent();
            _settings = new List<Settings>();
            LoadSettings();
        }

        private void LoadSettings()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Settings.xml");
            try
            {

            
            StringReader stringreader = new StringReader(GetSchema());
            XmlTextReader xmltextreader = new XmlTextReader(stringreader);
            doc.Schemas.Add(null, xmltextreader);
            doc.Validate(null);
     

            foreach (XmlNode node in doc.DocumentElement)
            {
                string _label = node.Attributes["label"].Value; //Attribute
                string _dconnection = node["destinationconnection"].InnerText;
                string _sconnection = node["sourceconnection"].InnerText;
                string _query = node["query"].InnerText.Trim();
                string _dtable = node["destinationtable"].InnerText;
                string _preexecute = node["preexcecute"].InnerText;
                string _postexecute = node["postexcecute"].InnerText;
                Settings st = new Settings(_label, _sconnection, _dconnection, _dtable, _preexecute, _postexecute, _query);

                _settings.Add(st);
                lstBox.Items.Add(st);
                
            }
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBox.SelectedIndex != -1)
            {
                propGrid.SelectedObject = lstBox.SelectedItem;
            }
        }

        private static string GetSchema()
        {
            return @"<?xml version=""1.0"" encoding=""utf-8""?>
                    <xs:schema attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
                      <xs:element name=""settings"">
                        <xs:complexType>
                          <xs:sequence>
                            <xs:element maxOccurs=""unbounded"" name=""table"">
                              <xs:complexType>
                                <xs:sequence>
                                  <xs:element name=""sourceconnection"" type=""xs:string"" />
                                  <xs:element name=""destinationconnection"" type=""xs:string"" />
                                  <xs:element name=""query"" type=""xs:string"" />
                                  <xs:element name=""destinationtable"" />
                                  <xs:element name=""preexcecute"" />
                                  <xs:element name=""postexcecute"" />
                                </xs:sequence>
                                <xs:attribute name=""label"" type=""xs:string"" use=""required"" />
                              </xs:complexType>
                            </xs:element>
                          </xs:sequence>
                        </xs:complexType>
                      </xs:element>
            </xs:schema>";
        }
    }
}
