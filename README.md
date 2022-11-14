# Text, intended to explain
Final work 1st q

User types something using space to separate words
```
Console.WriteLine("Input something to find out what is shorter than four symbols(use space to separate)");
string line = System.Console.ReadLine();
```

Method starts, using ```foreach (var value in M)``` (counts words) and ``` if (value.Length <= 3)``` (counts symbols in those words), writes them down in ```string row``` if there is less than 4 symbols, separating them with spaces.

Finally, the output is made like this just for beautiness.
```
System.Console.Write("[ ");
Console.Write(symbolCount(line));
System.Console.Write(" ]");
```