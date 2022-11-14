
Console.WriteLine("Input something to find out what is shorter than four symbols(use space to separate)");
string line = System.Console.ReadLine();

string symbolCount(string line)
{
string[] M = line.Split(' ');
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
string row = (string.Join(" ", result, 0, realSize));
return row;
}

System.Console.Write("[ ");
Console.Write(symbolCount(line));
System.Console.Write(" ]");
Console.ReadKey(true);