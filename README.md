# Codeformatter Package

A Simple Text formatter that formats the contents of a file using the c# style.


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

Pass in the paths of the file you want formatted in a string array
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
