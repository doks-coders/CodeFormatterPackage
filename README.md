# Codeformatter Package

A Simple Text formatter that formats the contents of a file using the c# style.

[![Order Tracker](https://firebasestorage.googleapis.com/v0/b/blogs-1c218.appspot.com/o/My%20Video2.gif?alt=media&token=de501566-4e8c-4f85-8ae9-53189604b993)](https://firebasestorage.googleapis.com/v0/b/blogs-1c218.appspot.com/o/My%20Video2.gif?alt=media&token=de501566-4e8c-4f85-8ae9-53189604b993)




## Installation

```csharp
  Install-Package CodeFormatterModule
```

## Imports

#### import the Codeformatter

```csharp
  using CodeFormatterModule;
```
## API Reference

### Format a single file

Pass in the path of the file you want formatted
```csharp
var formatter = new FormatCode();

try
{
	formatter.FormatCodeFile("File.cs");
}
catch (Exception ex) 
{
	Console.WriteLine(ex.Message);
}
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `path` | `string` | Should contain relative path to your file |



### Format multiple files

Pass in the paths of the file you want formatted in a string array
```csharp
var formatter = new FormatCode();

try
{
	var files = new string[] { "File1.cs", "File2.cs" };
    	formatter.FormatCodeFile(files);
}
catch (Exception ex) 
{
	Console.WriteLine(ex.Message);
}
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `paths` | `string []` | Should contain relative paths to your files |



### Format all files in directory and subdirectory

Pass in the path of the folder you want formatted 
```csharp
var formatter = new FormatCode();

try
{
	formatter.FormatCodeFile("Folder",children:true);
}
catch (Exception ex) 
{
	Console.WriteLine(ex.Message);
}
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `fileDirectory` | `string` | Should contain relative path to your folder |
| `children` | `boolean` | Should be used if you want the children of the folder |
