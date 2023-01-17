using System.Text;

string fileName = "File.txt";
FileStream fileStream = File.OpenRead(fileName);

fileStream = File.OpenRead(fileName);

StreamReader reader = new StreamReader(fileStream, Encoding.UTF8);
string text = await reader.ReadToEndAsync();

Console.WriteLine(text);
Console.ReadLine();