Console.WriteLine("Welcome to my quiz about which football club belongs to a certain country");
Console.WriteLine("Answer with a, b, c, or d. Goodluck..");
//

int points = 0;
// Points är noll

Console.WriteLine("1: Atletico Madrid is from which country?");
Console.WriteLine("a) Germany b) Portugal c) Spain");
string answer1 = Console.ReadLine().ToLower();
//------------------------------------------------------//
if(answer1 == "c")
{
    points++;
    Console.WriteLine("Correct answer!");
}
else  
{
    Console.WriteLine("Wrong answer!.. noob!");
}
//------------------------------------------------------//
Console.WriteLine("2: What country is Bayern from?");
Console.WriteLine("a) Germany b) Russia c)Denmark or d) United Kingdom");
string answer2 = Console.ReadLine().ToLower();

if (answer2 == "a")
{
    points++;
    Console.WriteLine("Correct answer!");
}
else  
{
    Console.WriteLine("Wrong answer!.. noob!");
}
//------------------------------------------------------//
Console.WriteLine("Okay you are advancing slowly.");
Console.WriteLine("What country does Liverpool come from?");
Console.WriteLine("a) Hungary b) United States c)United Kingdom d) Australia");
string answer3 = Console.ReadLine().ToLower();

if (answer3 == "c")
{
    points ++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong, wrong and wrong..!");
}
//------------------------------------------------------//
Console.WriteLine("Points: " + points);

//------------------------------------------------------//
Console.ReadLine();