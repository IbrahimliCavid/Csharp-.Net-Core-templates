
namespace lesson_12._1
{
    internal class Program
    {
        const string MyFolder = @"C:\Users\HP\Downloads";
        static void Main(string[] args)
        {
            SearchDriectoryAndEditFiles();
            DeleteEmptyFolder();


        }

        static void SearchDriectoryAndEditFiles()
        {
            var directory = new DirectoryInfo(MyFolder);

            var files = directory.GetFiles();

            string? newFolderName;

            foreach (var file in files)
            {
                string extension = file.Extension;
                switch (extension)
                {
                    case ".jpg":
                    case ".png":
                         newFolderName = "Picture";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;
                    case ".pdf":
                    case ".docx":
                    case ".doc":
                    case ".pptx":
                        newFolderName = "Documents";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;
                    case ".mp3":
                        newFolderName = "Musics";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;
                    case ".mp4":
                        newFolderName = "Videos";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;
                    case ".exe":
                        newFolderName = "Setups";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;

                    default:
                        newFolderName = "General";
                        CreateFolder(newFolderName);
                        FileMoveNewFolder(file, newFolderName);
                        break;



                }

            }
        }
        static void CreateFolder(string folderName)
        {

            string newFolderDirectory = Path.Combine(MyFolder, folderName);


            if (!Directory.Exists(newFolderDirectory))
            {
                Directory.CreateDirectory(newFolderDirectory);

            }
        }
        static void FileMoveNewFolder(FileInfo file, string folderName)
        {
            var destination = Path.Combine(MyFolder, folderName, file.Name);
            file.MoveTo(destination);
        }
        static void DeleteEmptyFolder()
        {
            bool isDelete = false;
            var directories = Directory.GetDirectories(MyFolder);
            foreach (var directory in directories)
            {
                if (Directory.GetFiles(directory).Length == 0)
                {
                    Directory.Delete(directory, true);
                    isDelete = true;
                }
              
            }

            if (isDelete)  Console.WriteLine("Delete empty folder is succesfuly.");
              
        }
    }
}