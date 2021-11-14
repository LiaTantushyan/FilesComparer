using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileComparer.Helpers
{
    public static class FileValidator
    {
        public static bool IsValid(this string path, FileTypes fileType)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!File.Exists(path))
            {
                return false;
            }

            switch (fileType)
            {
                case FileTypes.Xml:
                    if (FileExtensions.XmlExtensions.Contains(Path.GetExtension(path)))
                    {
                        return true;
                    }
                    break;
                case FileTypes.Excel:
                    if (FileExtensions.ExcelExtensions.Contains(Path.GetExtension(path)))
                    {
                        return true;
                    }
                    break;
                default:
                    break;
            }

            return false;
        }

        private static class FileExtensions
        {
            public static string[] XmlExtensions = { ".xml", ".txt" };
            public static string[] ExcelExtensions = { ".xlsx", ".xls" };
        }
    }

    public enum FileTypes
    {
        Xml,
        Excel
    }
}
