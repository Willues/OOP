using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Информация о дисках

            string disk = "D:";
            PPPDiskInfo.DisplayTotalFreeSpace(disk);
            PPPDiskInfo.DisplayDriveFormat(disk);
            PPPDiskInfo.DisplayDiskInfo();

            // Информация о файлах

            string filePath = @"D:\C#\lab13\lab13\PPPLogFile.txt";
            PPPFileInfo.GetFullPath(filePath);
            PPPFileInfo.GetFileInfo(filePath);
            PPPFileInfo.GetCreationAndChangeInfo(filePath);

            // Информация о директории

            string dirPath = @"D:\C#\";
            PPPDirInfo.FilesAmount(dirPath);
            PPPDirInfo.GetCreationTime(dirPath);
            PPPDirInfo.SubdirectoriesAmount(dirPath);
            PPPDirInfo.DisplayParentDirectories(dirPath);

            // Задание 5 - манипуляции с файлами и каталогами

            string drive = "D:";
            string dirpath = @"D:\C#\lab13\lab13\PPPInspect";
            string filepath = @"D:\C#\lab13\lab13\PPPInspect\pppdirinfo.txt";
            string filepath1 = @"D:\C#\lab13\lab13\PPPInspect\pppdirinfoSSSSS.txt";
            string filesAndDirectories = PPPFileManager.GetFilesAndDirectories(drive);

            PPPFileManager.CreateDirectory(dirpath);
            PPPFileManager.CreateFile(filepath);
            PPPFileManager.ToFile(filepath, filesAndDirectories);
            PPPFileManager.CopyFile(filepath, filepath1);
            PPPFileManager.RenameFile(filepath1, "pppdirinfoAAAAAAAAAAA.txt");
            PPPFileManager.DeleteFile(filepath);

            PPPFileManager.CreateDirectory(@"D:\C#\lab13\lab13\PPPFiles\t");
            PPPFileManager.CopyFiles(@"D:\pic", @"D:\C#\lab13\lab13\PPPFiles\t", "*.jpg");
            PPPFileManager.MoveDirectory(@"D:\C#\lab13\lab13\PPPFiles", @"D:\C#\lab13\lab13\PPPInspects");

            PPPFileManager.ToZip(@"D:\C#\lab13\lab13\PPPInspects", @"D:\C#\lab13\lab13\PPPInspects.zip");
            PPPFileManager.UnZip(@"D:\C#\lab13\lab13\PPPInspects.zip", @"D:\C#\lab13\lab13\PPPIn");

            Console.ReadKey();
        }
    }
}
