//// Define a generic lookup
//Dictionary<string, string> rotStrings = new();
//rotStrings.Add(key: "A", value: "N");
//rotStrings.Add(key: "B", value: "O");
//rotStrings.Add(key: "C", value: "O");
//rotStrings.Add(key: "D", value: "Q");
//rotStrings.Add(key: "E", value: "R");
//rotStrings.Add(key: "F", value: "S");
//rotStrings.Add(key: "G", value: "T");
//rotStrings.Add(key: "H", value: "U");
//rotStrings.Add(key: "I", value: "V");
//rotStrings.Add(key: "J", value: "W");
//rotStrings.Add(key: "K", value: "X");
//rotStrings.Add(key: "L", value: "Y");
//rotStrings.Add(key: "M", value: "Z");
//rotStrings.Add(key: "N", value: "A");
//rotStrings.Add(key: "O", value: "B");
//rotStrings.Add(key: "P", value: "C");
//rotStrings.Add(key: "Q", value: "D");
//rotStrings.Add(key: "R", value: "E");
//rotStrings.Add(key: "S", value: "F");
//rotStrings.Add(key: "T", value: "G");
//rotStrings.Add(key: "U", value: "H");
//rotStrings.Add(key: "V", value: "I");
//rotStrings.Add(key: "W", value: "J");
//rotStrings.Add(key: "X", value: "K");
//rotStrings.Add(key: "Y", value: "L");
//rotStrings.Add(key: "Z", value: "M");

//Console.WriteLine("Input Text:");
//string fullInput = Console.ReadLine()!;
//char[] chars = fullInput.ToCharArray();

//List<string> cypher = new List<string>();
//foreach (char c in chars)
//{
//    string s = c.ToString().ToUpper();
//    string cyph = rotStrings[s];
//    cypher.Add(cyph);
//}

//var result = String.Concat(cypher);
//Console.WriteLine(result);


//string c = "Hello";
//foreach (char a in c)
//{
//    int code = ((a * 223) - 52) % 26 + (a % 32) + 65;
//    Console.WriteLine(a);
//    Console.WriteLine(code);
//}

char x = 'a';
Console.WriteLine(x & 223);
Console.WriteLine(x);
Console.WriteLine(x + 1);

