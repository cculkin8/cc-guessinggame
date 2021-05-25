using System;
using System.Collections.Generic;
using System.Threading;
Console.Clear();
int secret = new Random().Next(2, 12);


    Console.WriteLine(@"
               (( _______
     _______     /\O    O\
    /O     /\   /  \      \
   /   O  /O \ / O  \O____O\ ))
((/_____O/    \\    /O     /
  \O    O\    / \  /   O  /
   \O    O\ O/   \/_____O/
    \O____O\/ ))          ))
  ((
      Let's roll some dice
    ");

Console.WriteLine("Select a difficulty level.");
Console.WriteLine("1. Easy (8 Rolls)\n2. Medium (6 Rolls)\n3. Hard (4 Rolls)\n4. Cheater (Infinite Rolls) ");
Console.WriteLine("=============================");

int attempt = Int32.Parse(Console.ReadLine());

Dictionary<int, int> attemptCounter = new Dictionary<int, int>() {
    {1, 8},
    {2, 6},
    {3, 4},
    {4, int.MaxValue}
};
int attempts = attemptCounter[attempt];
int count = attempts;
for (int i = 1; i <= count; i++) 
{

    Console.Write($"Roll number {i}: ");
    Random rnd = new Random();
    string Roll;
    int dice   = rnd.Next(2, 12);
    Roll = dice.ToString();
    string guess = Roll;
    int guessInt;
    Int32.TryParse(guess, out guessInt);
    Console.WriteLine($"You're rolling for {secret}");
    Console.WriteLine($"You rolled {guessInt}");
    if ( guessInt == secret) 
    {
        Console.WriteLine($"That's surprising, I can't believe you rolled {secret} ");
        return;
    } 
    else if (i <= attempts - 1)
    {
        string highorlow = guessInt > secret ? "Too High" : "Too Low";
        Thread.Sleep(2000);
        Console.WriteLine($"{highorlow}. Try again. You have {attempts - i} chance{ (i == attempts - 1 ? "" : "s") } left.");
    }
    else
    {
         Console.WriteLine($"Loser, don't waste my time and try again");
    }
}
Console.WriteLine("Get out of my sight.");
