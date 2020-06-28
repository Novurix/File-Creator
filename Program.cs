using System;
using System.IO;

namespace FileCreator
{
    // NOTE: the created files will appear in the bin/Debug folders

    class FileCreator {
        string pathToFolder = Directory.GetCurrentDirectory();
        string folderName = "Content";
        // Creates folder
        public FileCreator() {
            if (!Directory.Exists(pathToFolder + "/" + folderName)) {
                Directory.CreateDirectory(pathToFolder + "/" + folderName);
            }
        }

        public void createFile(string fileName, string type, string textInsert) {
            // Creates File
            string file = fileName + type;
            if (!Directory.Exists(pathToFolder + "/" + folderName + "/" + file)) {
                try { 
                    TextWriter writer = new StreamWriter(pathToFolder+"/"+folderName+"/"+file,true);

                    writer.Write(textInsert);
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }
    }

    class Program {

        static FileCreator fileCreator;

        public static void Main(string[] args) {
            fileCreator = new FileCreator();
            fileCreator.createFile("test", ".txt", "test Text");
        }
    }
}
