﻿//Objects and classes - exercise, Task 001
//27.02.2024, 23:23

string[] phrases =
    { "Excellent product.", "Such a great product.", "I always use that product.",
    "Best product of its category.", "Exceptional product.", "I can't live without this product." };
string[] events =
    { "Now I feel good.", "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.", "I feel great!" };
string[] authors =
    { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
string[] towns =
    { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
Random rand = new Random();

Console.WriteLine($"{phrases[rand.Next(0, phrases.Length)]} {events[rand.Next(0, events.Length)]} " +
    $"{authors[rand.Next(0, authors.Length)]} - {towns[rand.Next(0, towns.Length)]}");