namespace FolderTreeDemo
{
    using System.Net.NetworkInformation;
    using System.Reflection;

    public static class FolderProcessor
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

        // while and for are similar
        public static IEnumerable<string> EnumParentNames_For(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath));
            for (; folder != null; folder = folder.Parent)
            {
                yield return folder.Name;
            }
        }
        public static IEnumerable<string> DisplayParentName_DoWhile(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
            do
            {
                yield return folder.Name;
                folder = folder.Parent;
            } while (folder != null);
        }
    }
}