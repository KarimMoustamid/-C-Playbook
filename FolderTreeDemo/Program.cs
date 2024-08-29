// See https://aka.ms/new-console-template for more information
using System.Reflection;
using FolderTreeDemo;

string filePath = Assembly.GetExecutingAssembly()!.Location;
Console.WriteLine("Entry assembly is " + Path.GetFileName(filePath));

Console.WriteLine("Folders are:");
FolderProcessor.DisplayParentName_While(filePath);