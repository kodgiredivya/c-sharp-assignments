using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                Person oPerson = new Person();
                oPerson.FirstName = txtFirstName.Text;
                oPerson.LastName = txtLastName.Text;
                XmlSerializer oSerialiser = new XmlSerializer(typeof(Person));
                Stream oStream = new FileStream(@"C:\xmlFile.xml", FileMode.Create);
                oSerialiser.Serialize(oStream, oPerson);
                oStream.Close();
                MessageBox.Show("The job is done");
            }
            catch (ApplicationException caught)
            { MessageBox.Show(caught.Source); }
        }
    }
}