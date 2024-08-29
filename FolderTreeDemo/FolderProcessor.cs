namespace FolderTreeDemo
{
    using System.Net.NetworkInformation;
    using System.Reflection;

    public class FolderProcessor
    {
        public static void DisplayParentName_While(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
            while (folder != null)
            {
                Console.WriteLine(folder.Name);
                folder = folder.Parent;
            }
        }

        public static List<string> DisplayParentName_While_List(string filePath)
        {
            var result = new List<string>();
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath
            )!);
            while (folder != null)
            {
               result.Add(folder.Name);
               folder = folder.Parent;
            }
            return result;
        }

        public static IEnumerable<string> enumParentNames_While(string filepath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filepath));
            while (folder != null)
            {
                yield return folder.Name;
                folder = folder.Parent;
            }
        }
    }
}