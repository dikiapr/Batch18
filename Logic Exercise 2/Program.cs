// See https://aka.ms/new-console-template for more information
Console.Write("Masukkan angka: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++)
{
    string output = "";
    
    if(i % 3 == 0) output += "foo";
    
    if(i % 5 == 0) output += "bar";
    
    if(i % 7 == 0) output += "jazz";
    
    if(output == "") output = i.ToString();
    
    Console.Write(output);
    
    if(i < n) Console.Write(", ");
}

Console.WriteLine();