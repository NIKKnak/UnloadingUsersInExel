using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using OfficeOpenXml;

namespace UnloadingUsersInExel
{
    internal class ReadXMLFile
    {
        public void ReadXML(string path)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(path))
            {
                Console.WriteLine($"File {path} does not exist.");
                return;
            }

            // Загружаем XML-документ из файла
            XDocument xDoc;
            try
            {
                xDoc = XDocument.Load(path);
                Console.WriteLine("XML file loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load XML file: {ex.Message}");
                return;
            }

            // Определяем путь для сохранения файла Excel в ту же директорию
            string directory = Path.GetDirectoryName(path);
            string saveNewFile = Path.Combine(directory, $"{Path.GetFileNameWithoutExtension(path)}.xlsx");

            try
            {
                if (File.Exists(saveNewFile))
                {
                    File.Delete(saveNewFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete existing Excel file: {ex.Message}");
                return;
            }

            // Пишем извлеченные значения в файл Excel
            try
            {
                using (var package = new ExcelPackage(new FileInfo(saveNewFile)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Заголовки
                    worksheet.Cells[1, 1].Value = "Client Name";
                    worksheet.Cells[1, 2].Value = "Client ID";
                    worksheet.Cells[1, 3].Value = "User ID";
                    //worksheet.Cells[1, 4].Value = "User Name";

                    int row = 2;

                    var clients = xDoc.Descendants("client");
                    foreach (var client in clients)
                    {
                        string clientName = (string)client.Attribute("name");
                        string clientId = (string)client.Attribute("id");

                        var users = client.Descendants("user");
                        foreach (var user in users)
                        {
                            string userId = (string)user.Attribute("id");
                            string userName = (string)user.Attribute("name");

                            worksheet.Cells[row, 1].Value = clientName;
                            worksheet.Cells[row, 2].Value = clientId;
                            worksheet.Cells[row, 3].Value = userId;
                            //worksheet.Cells[row, 4].Value = userName;
                            row++;
                        }
                    }

                    package.Save();
                }
                Console.WriteLine($"Data successfully written to {saveNewFile}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write to Excel file: {ex.Message}");
            }
        }
    }
}
