using System;
using System.ComponentModel.Design;

UserPokemon User = new UserPokemon();

public class Pokemon
{ 
    public int health;
    public int speed;
    public int damage;
    public string type;
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

                break;
            }
            else if (choice == "pikachu")
            {

                break;
            }
            else if (choice == "squirtle")
            {
                
                break;
            }
            else if (choice == "bulbasaur")
            {

                break;
            }
            else
            {
                Console.WriteLine("Please retype your response as written below. It is not sensitive to capitilazation.");
            }
        }
    }
}

public class OpponentPokemon : Pokemon
{
    
}


