using System;
using System.Collections.Generic;
using System.Threading;

                                            
namespace MIS321_PA2                        // i have Thread.Sleep() methods all throughout the code
{                                           // it just takes a pause from executing the code 
    class Program                           // so it looks and plays smooth
    {
        static void Main(string[] args)
        {
            Welcome();
            List<Character> characterList = new List<Character>();
            characterList = GetCharacters();
            StartBattle(characterList);
        }

        static List<Character> GetCharacters()  //gets name and character choice
        {                                       //and creates the object
            List<Character> characterList = new List<Character>(); 
            Console.WriteLine("Enter the name for Player 1.");
            string playerName1 = Console.ReadLine();
            Console.WriteLine("Enter the name for Player 2.");
            string playerName2 = Console.ReadLine();
            Thread.Sleep(500);
            

            Console.WriteLine("\nDeciding which player will go first...");
            Thread.Sleep(1000);
            bool temp = WhichPlayerGoesFirst();
            if (temp == true)
            {
                Console.WriteLine($"\n{playerName1} will attack first.");
            }
            else if (temp == false)
            {
                Console.WriteLine($"\n{playerName2} will attack first.");
            }

            Thread.Sleep(1000);
            DisplayCharacters();

            Thread.Sleep(500);
            Console.WriteLine($"\n{playerName1}, choose your character by entering their corresponding number.");
            int userCharacterChoice1 = GetUserChoice();

            while(userCharacterChoice1 != 1 && userCharacterChoice1 != 2 && userCharacterChoice1 != 3)
            {
                Console.Clear();
                Console.WriteLine($"{userCharacterChoice1} is an invalid selection. Enter the corresponding number.");
                DisplayCharacters();
                userCharacterChoice1 = GetUserChoice();
            }

            if(userCharacterChoice1 == 1)
            {
                Console.WriteLine($"\n{playerName1} has chosen Jack Sparrow!");
            }
            else if(userCharacterChoice1 == 2)
            {
                Console.WriteLine($"\n{playerName1} has chosen Will Turner!");
            }
            else
            {
                Console.WriteLine($"\n{playerName1} has chosen Davy Jones!");
            }

            Thread.Sleep(1000);
            DisplayCharacters();
            Thread.Sleep(500);
            Console.WriteLine($"\n{playerName2}, choose your character by entering their corresponding number.");
            int userCharacterChoice2 = GetUserChoice();
            
            while(userCharacterChoice2 != 1 && userCharacterChoice2 != 2 && userCharacterChoice2 != 3)
            {
                Console.Clear();
                Console.WriteLine($"\n{userCharacterChoice2} is an invalid selection. Enter the corresponding number.");
                DisplayCharacters();
                userCharacterChoice2 = GetUserChoice();
            }

            if(userCharacterChoice2 == 1)
            {
                Console.WriteLine($"\n{playerName2} has chosen Jack Sparrow!");
            }
            else if(userCharacterChoice2 == 2)
            {
                Console.WriteLine($"\n{playerName2} has chosen Will Turner!");
            }
            else
            {
                Console.WriteLine($"\n{playerName2} has chosen Davy Jones!");
            }

            if(temp == true)                            // whoever is selected to go first will be
            {                                           // put into the List<> first so they are in
                if(userCharacterChoice1 == 1)           // array[0] and the other is in array[1]
                {
                    JackSparrow player1 = new JackSparrow(){name = playerName1};
                    characterList.Add(player1);
                }
                else if(userCharacterChoice1 == 2)
                {
                    WillTurner player1 = new WillTurner(){name = playerName1};
                    characterList.Add(player1);
                }
                else if(userCharacterChoice1 == 3)
                {
                    DavyJones player1 = new DavyJones(){name = playerName1};
                    characterList.Add(player1);
                }
            }
            else if(temp == false)
            {
                if(userCharacterChoice2 == 1)
                {
                    JackSparrow player1 = new JackSparrow(){name = playerName2};
                    characterList.Add(player1);
                }
                else if(userCharacterChoice2 == 2)
                {
                    WillTurner player1 = new WillTurner(){name = playerName2};
                    characterList.Add(player1);
                }
                else if(userCharacterChoice2 == 3)
                {
                    DavyJones player1 = new DavyJones(){name = playerName2};
                    characterList.Add(player1);
                }
            }
            
            if(temp == true)
            {
                if(userCharacterChoice2 == 1)
                {
                    JackSparrow player2 = new JackSparrow(){name = playerName2};
                    characterList.Add(player2);
                }
                else if(userCharacterChoice2 == 2)
                {
                    WillTurner player2 = new WillTurner(){name = playerName2};
                    characterList.Add(player2);
                }
                else if(userCharacterChoice2 == 3)
                {
                    DavyJones player2 = new DavyJones(){name = playerName2};
                    characterList.Add(player2);
                }
            }
            else if(temp == false)
            {
                if(userCharacterChoice1 == 1)
                {
                    JackSparrow player2 = new JackSparrow(){name = playerName1};
                    characterList.Add(player2);
                }
                else if(userCharacterChoice1 == 2)
                {
                    WillTurner player2 = new WillTurner(){name = playerName1};
                    characterList.Add(player2);
                }
                else if(userCharacterChoice1 == 3)
                {
                    DavyJones player2 = new DavyJones(){name = playerName1};
                    characterList.Add(player2);
                }
            }
    return characterList; //returns <List> to main
        }

        static int GetUserChoice()      // gets user choice and returns and int
        {
            return int.Parse(Console.ReadLine());
        }

        static bool WhichPlayerGoesFirst()      // 50/50 num generator
        {                                       // generates a 0 or 1
            Random random = new Random();
            int randomNum = random.Next(2);

            //Console.WriteLine(randomNum);

            if(randomNum == 0)
            {
                return true;
            }
            else
            {
                return false;  
            } 
        }

        static void DisplayCharacters()     // displays the list of characters for selection
        {
            Console.WriteLine("\nCHARACTER LIST: \n1. JACK SPARROW\n2. WILL TURNER\n3. DAVY JONES");
        }

        static void StartBattle(List<Character> characters)
        {
            Character player1 = characters[0];  //this is the player that was selected to go first
            Character player2 = characters[1];
            int roundCount = 1;

            Thread.Sleep(500);
            Console.WriteLine("\nThe match will now begin.\n");
            Thread.Sleep(2000);

            while(player1.health > 0 && player2.health > 0)
            {
                
                Console.WriteLine("");
                Console.WriteLine($"Round {roundCount}:");  //this will update with each round
                Thread.Sleep(2000);
                Console.WriteLine($"{player1.name} will now attack.");
                Thread.Sleep(1000);

                AttackMenu();
                int userChoice = GetUserChoice();
                while(userChoice != 1)
                {
                    if(userChoice == 2)
                    {
                        player1.DisplayStats();
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                    else if(userChoice == 3)
                    {
                        player2.DisplayStats();
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                    else
                    {
                        Console.WriteLine($"\n{userChoice} is an invalid selection. Enter the corresponding number.");
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                }

                Console.WriteLine($"\n{player1.name} has readied their attack!");
                Thread.Sleep(1000);
                Console.WriteLine($"\n{player2.name} will now defend.");
                Thread.Sleep(1000);

                DefendMenu();
                userChoice = GetUserChoice();
                while(userChoice != 1)
                {
                    if(userChoice == 2)
                    {
                        player2.DisplayStats();
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                    else if(userChoice == 3)
                    {
                        player1.DisplayStats();
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                    else
                    {
                        Console.WriteLine($"\n{userChoice} is an invalid selection. Enter the corresponding number.");
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                }

                Console.WriteLine("");
                player1.attackBehavior.Attack(player1);
                player2.defendBehavior.Defend(player2);

                int damageDealt = AttackSequence(player1, player2);

                player2.health = player2.health - damageDealt;

                Thread.Sleep(1000);
                Console.WriteLine($"\n{player1.name}'s attack dealt {damageDealt} damage! (Attack Power: {player1.attackStrength})");
                Thread.Sleep(1000);
                Console.WriteLine($"{player2.name}'s health falls to {player2.health}! (Defensive Power: {player2.defensivePower})");

                if(player2.health < 1)
                {
                    Console.WriteLine($"\n{player2.name} has fallen!");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{player1.name} wins!");
                    Thread.Sleep(1000);
                    Console.WriteLine("GAME OVER! Thank you for playing!");
                    return;
                }

                Console.WriteLine($"\n{player2.name} will now attack.");
                Thread.Sleep(1000);

                AttackMenu();
                userChoice = GetUserChoice();
                while(userChoice != 1)
                {
                    if(userChoice == 2)
                    {
                        player2.DisplayStats();
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                    else if(userChoice == 3)
                    {
                        player1.DisplayStats();
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                    else
                    {
                        Console.WriteLine($"\n{userChoice} is an invalid selection. Enter the corresponding number.");
                        AttackMenu();
                        userChoice = GetUserChoice();
                    }
                }

                Console.WriteLine($"\n{player2.name} has readied their attack!");
                Thread.Sleep(1000);
                Console.WriteLine($"\n{player1.name} will now defend.");
                Thread.Sleep(1000);

                DefendMenu();
                userChoice = GetUserChoice();
                while(userChoice != 1)
                {
                    if(userChoice == 2)
                    {
                        player1.DisplayStats();
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                    else if(userChoice == 3)
                    {
                        player2.DisplayStats();
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                    else
                    {
                        Console.WriteLine($"\n{userChoice} is an invalid selection. Enter the corresponding number.");
                        DefendMenu();
                        userChoice = GetUserChoice();
                    }
                }

                Console.WriteLine("");
                player2.attackBehavior.Attack(player2);
                player1.defendBehavior.Defend(player1);

                damageDealt = AttackSequence(player2, player1);

                player1.health = player1.health - damageDealt;
                Thread.Sleep(1000);
                Console.WriteLine($"\n{player2.name}'s attack dealt {damageDealt} damage! (Attack Power: {player2.attackStrength})");
                Thread.Sleep(1000);
                Console.WriteLine($"{player1.name}'s health falls to {player1.health}! (Defensive Power: {player1.defensivePower})");

                if(player1.health < 1)
                {
                    Console.WriteLine($"\n{player1.name} has fallen!");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{player2.name} wins!");
                    Thread.Sleep(1000);
                    Console.WriteLine("GAME OVER! Thank you for playing!");

                    return;
                }
                roundCount++;
            }
        }

        static void AttackMenu()    //menu displayed when user's turn to attack
        {
            Thread.Sleep(500);
            Console.WriteLine("\nYou are attacking. Please make your choice:\n1. ATTACK\n2. VIEW MY STATS\n3. VIEW ENEMY STATS");
        }

        static void DefendMenu()    //menu displayed when user's turn to defend
        {
            Thread.Sleep(500);
            Console.WriteLine("\nYou are defending. Please make your choice:\n1. DEFEND\n2. VIEW MY STATS\n3. VIEW ENEMY STATS");
        }

        static int AttackSequence(Character attacker, Character defender)
        {
            double attackStrengthDouble = Convert.ToDouble(attacker.attackStrength);    //this logic was suggested by Anne in teams
            double defensivePowerDouble = Convert.ToDouble(defender.defensivePower);    //damage is equal to the percentages between the two stats
            double temp = attackStrengthDouble/defensivePowerDouble;                    //attacker's strength & defender's defensive power
            double damageDealt = temp * defensivePowerDouble;

            if(attacker.type == "Jack Sparrow" && defender.type == "Will Turner")       //type bonuses
            {
                damageDealt = damageDealt * 1.2;
            }
            else if(attacker.type == "Will Turner" && defender.type == "Davy Jones")
            {
                damageDealt = damageDealt * 1.2;
            }
            else if(attacker.type == "Davy Jones" && defender.type == "Jack Sparrow")
            {
                damageDealt = damageDealt * 1.2;
            }

            int returnDamage = Convert.ToInt32(damageDealt);
            if(returnDamage < 1)
            {
                returnDamage = 1;
            }
            return returnDamage;
        }

        static void Welcome()   //welcome message/instructions
        {
            Console.WriteLine("\nWelcome to the Battle of Calypso's Maelstrom! This is a turn-based dueling game between two user players. When making a character, users will select between 3 classes:\nJACK SPARROW\tWILL SILVER\tDAVY JONES\n");
            Console.WriteLine("These classes have different attacks, and will gain type bonuses versus one another.\nBONUSES:\nJack Sparrow +20% damage against Will Silver\nWill Silver +20% damage against Davy Jones\nDavy Jones +20% damage versus Jack Sparrow\n\n");
            Console.WriteLine("Attack order will be randomly selected, and the game will continue until one player character reaches 0 health.\n");

            Thread.Sleep(3000);
            Console.WriteLine("\nPress any key to start the game.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
