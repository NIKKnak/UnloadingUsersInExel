using System;
using System.Windows.Forms;

namespace UnloadingUsersInExel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PathFile pathFile = new PathFile();
            ReadXMLFile readXMLFile = new ReadXMLFile();

            string path = pathFile.GetPath();
            if (path != "Файл не найден")
            {
                readXMLFile.ReadXML(path);
            }
        }
    }
}
