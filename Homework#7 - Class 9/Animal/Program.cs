﻿using Animals.Domain.Enum;
using Animals.Domain.Models;

List<Animal> animals = new List<Animal>();

animals.Add(new Animal("Tiger", "Orange", 4, Gender.Female));
animals.Add(new Animal("Elephant", "Gray", 8, Gender.Female));
animals.Add(new Animal("Rhino", "Gray", 10, Gender.Male));
animals.Add(new Animal("Hippopotamus", "Gray", 11, Gender.Female));
animals.Add(new Animal("Leopard", "Yellow", 4, Gender.Male));
animals.Add(new Animal("Cheetah", "Golden", 8, Gender.Female));
animals.Add(new Animal("Ape", "Brown", 11, Gender.Male));
animals.Add(new Animal("Bear", "Brown", 12, Gender.Male));
animals.Add(new Animal("Chimpanzee", "Brown", 5, Gender.Male));
animals.Add(new Animal("Zebra", "Black and White", 3, Gender.Male));
animals.Add(new Animal("Antelope", "Brown", 9, Gender.Male));
animals.Add(new Animal("Hummingbird", "Blue", 3, Gender.Female));
animals.Add(new Animal("Gorilla", "Black", 10, Gender.Male));
animals.Add(new Animal("Cheetah", "Yellow", 4, Gender.Female));

List<Animal> namesAged5OrMore = animals.Where(animal => animal.Age >= 5).ToList();

foreach (Animal animal in namesAged5OrMore)
{
    Console.WriteLine("Names of animals aged 5 or more: " + animal.Name);
}

List<Animal> namesStartingWithA = animals.Where(animal => animal.Name.StartsWith('A')).ToList();

foreach (Animal animal in namesStartingWithA)
{
    Console.WriteLine("Names of animals starting with 'A': " + animal.Name);
}

List<Animal> maleBrownAnimals = animals.Where(animal => animal.Gender == Gender.Male && animal.Color.ToLower() == "brown").ToList();

foreach (Animal animal in maleBrownAnimals)
{
    Console.WriteLine("Names of male, brown animals: " + animal.Name);
}

Animal firstLongNameAnimal = null;
foreach (var animal in animals)
{
    if (animal.Name.Length > 10)
    {
        firstLongNameAnimal = animal;
        break;
    }
}

string firstAnimalNameLongerThan10Characters;
if (firstLongNameAnimal != null)
{
    firstAnimalNameLongerThan10Characters = firstLongNameAnimal.Name;
}
else
{
    firstAnimalNameLongerThan10Characters = "No such animal found";
}

Console.WriteLine("First animal with a name longer than 10 characters: " + firstAnimalNameLongerThan10Characters);