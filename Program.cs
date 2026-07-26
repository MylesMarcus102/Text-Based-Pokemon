using System;

public enum PokemonType
{
    Fire,
    Water,
    Electric,
    Grass
}

public class Pokemon
{ 
    public int health;
    public int speed;
    public int attack;
    public PokemonType type;
    public int defense;
    public string choice;
}

public class UserPokemon : Pokemon
{
    public void SelectionTypes()
    {
        while (true)
        {
            Console.WriteLine("Please select between the following pokemon: Charmander, pikachu, squirtle, or bulbasaur.");
            choice = Console.ReadLine().ToLower();
            if (choice == "charmander")
            {
                health = 41;
                attack = 24;
                defense = 21;
                speed = 28;
                type = PokemonType.Fire;
                break;
            }
            else if (choice == "pikachu")
            {
                health = 41;
                attack = 22;
                defense = 17;
                speed = 39;
                type = PokemonType.Electric;
                break;
            }
            else if (choice == "squirtle")
            {
                health = 46;
                attack = 24;
                defense = 28;
                speed = 22;
                type = PokemonType.Water;
                break;
            }
            else if (choice == "bulbasaur")
            {
                health = 47;
                attack = 24;
                defense = 24;
                speed = 22;
                type = PokemonType.Grass;
                break;
            }
            else
            {
                Console.WriteLine("Please retype your response as written below.");
            }
        }
    }
}

public class OpponentPokemon : Pokemon
{
    
}


