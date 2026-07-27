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
    public void RandomChoice()
    {
        int randomchoice = Random.Shared.Next(1, 5);
        if (randomchoice == 1)
        {
            choice = "charmander";
            Charmander();
        }
        else if (randomchoice == 2)
        {
            choice = "bulbasaur";
            Bulbasaur();
        }
        else if (randomchoice == 3)
        {
            choice = "pikachu";
            Pikachu();
        }
        else if (randomchoice == 4)
        {
            choice = "squirtle";
            Squirtle();
        }
    }

    public void Charmander()
    {
        health = 41;
        attack = 24;
        defense = 21;
        speed = 28;
        type = PokemonType.Fire;
    }

    public void Squirtle()
    {
        health = 46;
        attack = 24;
        defense = 28;
        speed = 22;
        type = PokemonType.Water;
    }

    public void Pikachu()
    {
        health = 41;
        attack = 22;
        defense = 17;
        speed = 39;
        type = PokemonType.Electric;
    }

    public void Bulbasaur()
    {
        health = 47;
        attack = 24;
        defense = 24;
        speed = 22;
        type = PokemonType.Grass;
    }
    public int health;
    public int speed;
    public int attack;
    public PokemonType type;
    public int defense;
    public string choice;

    public virtual void Selection()
    { 
            Console.WriteLine("Please select between the following pokemon: Charmander, pikachu, squirtle, bulbasaur, or random.");
            choice = Console.ReadLine().ToLower();
            if (choice == "random")
            {
                RandomChoice();
            }
            else if (choice == "charmander")
            {
                Charmander();
            }
            else if (choice == "pikachu")
            {
                Pikachu();
            }
            else if (choice == "squirtle")
            {
                Squirtle();
            }
            else if (choice == "bulbasaur")
            {
                Bulbasaur();
            }
            else
            {
                Console.WriteLine("Please retype your response as written below.");
            }
    }
}

public class User : Pokemon { }
public class Opponent : Pokemon
{
    public override void Selection()
    { 
            Console.WriteLine("Player2 please select the pokemon you want: Charmander, pikachu, squirtle, bulbasaur, or random.");
            choice = Console.ReadLine().ToLower();
            if (choice == "random")
            {
                RandomChoice();
            }
            else if (choice == "charmander")
            {
                Charmander();
            }
            else if (choice == "pikachu")
            {
                Pikachu();
            }
            else if (choice == "squirtle")
            {
                Squirtle();
            }
            else if (choice == "bulbasaur")
            {
                Bulbasaur();
            }
            else
            {
                Console.WriteLine("Please retype your response as written below.");
            }
    }
}

public class Battle
{
    public void Damage_Calculator()
    {
        
    }
}

public class Game
{
    public static void Main()
    {
        User Player1 = new User();
        Player1.Selection();
        Opponent Player2 = new Opponent();
        Player2.Selection();
    }
}