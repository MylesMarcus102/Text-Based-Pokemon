public enum PokemonType
{
    Placeholder,
    Fire,
    Water,
    Electric,
    Grass,
    Normal
}

public enum Status
{
    None,
    Burned,
    Paralyzed,
    Sleep
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
    public string selectionChoice = "Please select between the following pokemon: Charmander, pikachu, squirtle, bulbasaur, or random.";

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
}


public class Move
{
    public string Name{get;set;}
    public PokemonType Type{get;set;}
    public int Power{get;set;}
    public int Accuracy{get;set;}
    public int CurrentPP{get;set;}
    public int MaxPP{get;set;}
    public int Priotiry{get;set;}
    public Status Status{get;set;}
    public int StatusChance{get;set;}
    public Move(string name, PokemonType type, int power, int accuracy, int currentPP, int maxPP, int priotiry, Status status, int statuschance)
    {
        Name = name;
        Type = type;
        Power = power;
        Accuracy = accuracy;
        CurrentPP = currentPP;
        MaxPP = maxPP;
        Priotiry = priotiry;
        Status = status;
        StatusChance = statuschance;
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
        Player2.selectionChoice = "Player2 please select between the following pokemon: Charmander, pikachu, squirtle, bulbasaur, or random.";
        Player2.Selection();
        Console.WriteLine($"Player 1 chose {Player1.choice} and Player 2 chose {Player2.choice}");
        var MoveDataBase = new Dictionary<string, Move>();
        MoveDataBase.Add("tackle", new Move("tackle", PokemonType.Normal,40,100,35,35,0, Status.None,0));
        MoveDataBase.Add("ember", new Move("ember", PokemonType.Fire,40,100,25,25,0, Status.None,10));
        MoveDataBase.Add("water gun", new Move("water gun", PokemonType.Water,40,100,25,25,0,Status.None,0));
        MoveDataBase.Add("thunder shock", new Move("thunder shock", PokemonType.Electric,40,100,30,30,0,Status.Paralyzed,10));
        MoveDataBase.Add("vine whip", new Move("vine whip", PokemonType.Grass,45,100,25,25,0, Status.None,0));
        MoveDataBase.Add("scratch", new Move("scratch", PokemonType.Normal,40,100,35,35,0, Status.None,0));
        MoveDataBase.Add("quick attack", new Move("quick attack", PokemonType.Normal,40,100,35,30,1, Status.None,0));
        MoveDataBase.Add("thunder wave", new Move("thunder wave", PokemonType.Electric,0,100,20,20,0,Status.Paralyzed,90));
    }
}