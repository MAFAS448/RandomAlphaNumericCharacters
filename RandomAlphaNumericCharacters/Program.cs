using System.Collections;
using System.Collections.Immutable;
using System.Data;
using Bogus;
using System.Diagnostics;
using System.Threading.Tasks.Sources;


//var randomAlphabeticalLetters = new Faker().Random.AlphaNumeric(1000).ToCharArray();

//List<char> numbersList = new List<char>();
//List<char> alphabetList = new List<char>();

//foreach (char c in randomAlphabeticalLetters)
//{
//    if (char.IsDigit(c))
//    {
//        numbersList.Add(c);
//    }
//    else
//    {
//        alphabetList.Add(c);
//    }
//}

//// Sort the numbers
//numbersList.Sort((a, b) => int.Parse(a.ToString()).CompareTo(int.Parse(b.ToString())));

//// Sort the letters
//alphabetList.Sort();

var randomAlphabeticalLetters = new Faker().Random.AlphaNumeric(1000).ToCharArray();

Console.WriteLine("Diolay the Random letters");

var Stopwatch = new Stopwatch();

//1st Method
Stopwatch.Start();
Array.Sort(randomAlphabeticalLetters);

Stopwatch.Stop();
Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedMilliseconds} ms");


//2nd  Method
Stopwatch.Restart();
var result01 = new List<char>(randomAlphabeticalLetters);
result01.Sort();

Stopwatch.Stop();
Console.WriteLine($"Time Taken By LINQ Query Method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by LiNQ method : {Stopwatch.ElapsedMilliseconds} ms");
Console.ReadLine();


//3rd Method
Stopwatch.Restart();
var result = from name in randomAlphabeticalLetters orderby name select name;

Stopwatch.Stop();
Console.WriteLine($"Time Taken By Query.next method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by Query method : {Stopwatch.ElapsedMilliseconds} ms");

