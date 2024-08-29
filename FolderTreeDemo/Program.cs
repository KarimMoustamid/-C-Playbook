// See https://aka.ms/new-console-template for more information
using System.Reflection;
using FolderTreeDemo;
string filePath = Assembly.GetExecutingAssembly()!.Location;
Console.WriteLine("Entry assembly is " + Path.GetFileName(filePath));

Console.WriteLine("Folders are:");
// FolderProcessor.DisplayParentName_While(filePath);
// FolderProcessor.DisplayParentName_While_List(filePath);
foreach (var folder in FolderProcessor.enumParentNames_While(filePath).Reverse())
    Console.WriteLine(folder);