﻿//new branch for part5-guided 

using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();

//AssignGroup();

Console.WriteLine("School A");

//PrintGroup(group)

//var group = AssignGroup();

//string[,] group = AssignGroup();

void RandomizeAnimals()
{
    Random rnd = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) //going through the array
    {
    int r = rnd.Next(i, pettingZoo.Length); //randomizing which gets swapped

    string temp = pettingZoo[i];  //using temp to swap random indcies in the array
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
    }
}

foreach(string animal in pettingZoo)
{
    Console.WriteLine(animal);
}