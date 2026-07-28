public enum PokemonType
{
    Placeholder,
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

    public int level = 15;
    public int health;
    public int speed;
    public int attack;
    public PokemonType type;
    public int defense;
    public string choice;
    string selectionChoice = "Please select between the following pokemon: Charmander, pikachu, squirtle, bulbasaur, or random.";

    public virtual void Selection()
    {
            Console.WriteLine(selectionChoice);
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
    public void Move()
    {
        int movePower;
        int moveAccuracy;
        PokemonType moveType = PokemonType.Placeholder;
        int moveCritical = 1;
        Double STAB = 1;
        if (moveType == type)
        {
            STAB = 1.5;
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
        Pokemon Player1 = new Pokemon();
        Player1.Selection();
        Pokemon Player2 = new Pokemon();
        Player2.Selection();
    }
}