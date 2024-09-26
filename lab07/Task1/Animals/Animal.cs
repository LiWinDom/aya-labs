namespace lab07.Task1.Animals;

public abstract class Animal
{
    public Animal()
    {
        
    }
    
    public string Country { get; set; }
    public bool HideFromOtherAnimals { get; init; }
    public string Name { get; init; }
    public string WhatAnimal { get; init; }
}