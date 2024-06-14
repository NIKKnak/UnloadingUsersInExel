using System;
using System.Windows.Forms;

namespace UnloadingUsersInExel
{
    internal class PathFile
    {
        public string GetPath()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openFile.FileName;
                return path;
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
            return "Файл не найден";
        }
    }
}
