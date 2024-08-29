namespace FolderTreeDemo
{
    using System.Reflection;

    public class FolderProcessor
    {
        public static void DisplayParentName_While(string filePath)
        {
            var folder = new DirectoryInfo(filePath);
            while (folder != null)
            {
                Console.WriteLine(folder.Name);
                folder = folder.Parent;
            }
        }
    }
}