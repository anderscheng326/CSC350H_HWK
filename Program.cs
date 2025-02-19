﻿//new branch for part5-guided 

using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups =6)
{
RandomizeAnimals();
Console.WriteLine(schoolName);
string[,] group = AssignGroup(groups);
PrintGroup(group);
}

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

/* testcase for animal shuffle - prints animals
foreach(string animal in pettingZoo)
{
    Console.WriteLine(animal);
}
*/

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length/groups]; // using 2d array to figure out the groups

    int start = 0;

    for (int i = 0; i < groups; i++) //outer loop cycles through each group
    {
        for (int j = 0; j < result.GetLength(1); j++) //inner loop cycles for # of animals groups should have
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;

}


void PrintGroup(string[,] group) //printing 2d array
{
    for (int i = 0; i<group.GetLength(0); i++)
    {
        Console.Write($"Group {i+1}: ");
        for (int j = 0; j<group.GetLength(1); j++)
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}