using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class FilePathName
    {
        string filePath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aydin\Desktop\StokKontrolOtomasyonu\Source\Database\dbStokKontrolSistemi.mdf;Integrated Security=True;Connect Timeout=30";

        public string getFilePath() { 
        
            return filePath;
        }

    }
}
