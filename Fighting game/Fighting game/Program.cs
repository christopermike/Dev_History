using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string martialArtsShop = "";
            string command = "";
            //stats and value of damage
            int playerStrenght = 3;
            int playerInt = 3;
            int playerAgi = 3;
            int playerEndurance = 0;
            int playerCharisma = 0;
            int playerLuck = 0;
            int Buckles = 0;
            double damage = 0;
            int defense = 0;
            int critical = 0;
            int enemyTurn = 0;
            double enemyDamage = 0;
            int enemyDefense = 0;
            int weaponDmg = 0;
            int cooldown = 0;
            int martialArts = 0;
            int critChance = 0;
            string skills = "";
           int defenseBonus = 0;
            int confuse = 0;
            string choosenSide = "";
            int coinSideNumber = 0;
            string coinSide = "";
            int coinWins = 0;
            Random rnd = new Random();
            double playerHealth = 100 + (playerEndurance *2);

            Console.WriteLine("SPŠS Betlémská | 1.I | Kaňák Kryštof | *datum*");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Fighting God");//starting screen
            Console.WriteLine("Ver. 0.5");
            Console.ResetColor();
            Console.WriteLine("Tell me your name");
            string name = Console.ReadLine();
            Console.WriteLine("You are {0}, a person who has just gotten into great debt with the Mob", name);//background
            Console.Write("The only way to make enough money to pay off your debt is to fight in the local arena ");
            Console.Write("Your house has been taken away and the dog you owned also taken away");
            Console.WriteLine("\n");
            Console.WriteLine("\nYour first fight you are assigned a fighter who has never won a fight");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n/This is a tutorial fight/");//tutorial fight    
            Console.WriteLine("The first opponent is Dave the lesser");
            Console.ResetColor();

            double daveHealth = 30;
            while (daveHealth > 0)//plays until dave is dead
            {
                Console.WriteLine("");
                Console.WriteLine("Enemy Health: " + daveHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn|");

                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    //all calculations are done here
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght/2) + weaponDmg) - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        daveHealth = daveHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", daveHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;



                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                       
                        enemyDamage = rnd.Next(0, 6) - defense;
                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = playerHealth - enemyDamage;
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(0, 4);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("Congrats you leveled up and gained 2 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }

            Console.WriteLine("You gained 100 Buckles");
            Buckles = Buckles + 100;
            while (command.ToLower() != "leave")
            {
                Console.WriteLine("You have entered the arena shop");
                Console.WriteLine("|Buy|  |Leave|");
                command = Console.ReadLine();
                int priceSword = 40 - playerCharisma;
                int priceSpear = 45 - playerCharisma;
                int priceMartial = 300 - playerCharisma;
                if (command.ToLower() == "buy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                    Console.ResetColor();
                    Console.WriteLine("The items available are: ");
                    Console.Write("\n |Cracked Sword|({0} Buckels)(+2 Attack) \n |Flimsy Spear|({1} Buckels)(+3 Attack) \n |Learning Martial Arts for Dummies 101|({2} Buckles)(requires 6 Intelligence) |Leave|", priceSword, priceSpear, priceMartial);
                    Console.WriteLine("/To buy the book please type Martial Arts Book/");
                    Console.WriteLine("You have {0} Buckles",Buckles);
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "cracked sword":
                            if (Buckles > priceSword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Cracked Sword for {0} Buckles", priceSword);
                                Console.ResetColor();
                                Buckles = Buckles - priceSword;
                                weaponDmg = 2;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "flimsy spear":
                            if (Buckles > priceSpear)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Flimsy Spear for {0} Buckles", priceSpear);
                                Console.ResetColor();
                                Buckles = Buckles - priceSpear;
                                weaponDmg = 3;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "martial arts book":
                            if (Buckles > priceMartial)
                            {
                                if (playerInt>6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                    Console.ResetColor();
                                    Buckles = Buckles - priceMartial;
                                    playerStrenght = playerStrenght + 6;
                                    playerAgi = playerAgi + 6;
                                }
                                else
                                {
                                    Console.WriteLine("You do not have high enough intelligence");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "leave":
                            Console.WriteLine("You left the shop");
                            break;
                        default:
                            Console.WriteLine("We dont have this item in stock");
                            break;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Once you come out of the shop 2 members of the Mob are waiting outside, they tell you that you have 5 days to get 500 Buckles or they will kill you");
            Console.WriteLine("They also give you keys to a small house and tell you that its yours for now");
            Console.WriteLine("/5 days is 5 fights ingame time/");
            Console.ResetColor();
            Console.WriteLine("In eight days a tournament also starts, this tournament is called 'God of Fight' ,it is hosted by the God of War himself");
            Console.Write("It is said that those who the God finds worthy he will grant a single wish to");
            Console.WriteLine("");
            Console.WriteLine("\nYou go to sleep in the streets after the fight to heal up from your injuries");
            playerHealth = 100 + (playerEndurance*2);
            Console.WriteLine("After you wake up you learn that you are assigned Bob the Greater as your second opponent. He is the brother of Dave the Lesser, your first opponent");

            double bobHealth = 100;
            while (bobHealth > 0)//plays until bob is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + bobHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn|");
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght/2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        bobHealth = bobHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", bobHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                        
                        enemyDamage = rnd.Next(0, 9) - defense;
                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = playerHealth - enemyDamage;
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(0, 3);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }

            Console.WriteLine("Congrats you leveled up and gained 2 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }
            Console.WriteLine("You gained 150 Buckles");
            Buckles = Buckles + 150;
            while (command.ToLower() != "leave")
            {
                Console.WriteLine("You have entered the arena shop");
                Console.WriteLine("|Buy|  |Leave|");
                command = Console.ReadLine();
                int priceSteelSword = 50 - playerCharisma;
                int priceLongSpear = 55 - playerCharisma;
                int priceMartial = 300 - playerCharisma;
                if (command.ToLower() == "buy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                    Console.ResetColor();
                    Console.WriteLine("The items available are: ");
                    Console.Write("\n |Steel Sword|({0} Buckels)(+4 Attack) \n |Long Spear|({1} Buckels)(+5 Attack) \n |Learning Martial Arts for Dummies 101|({2} Buckles)(requires 6 Intelligence) |Leave|", priceSteelSword, priceLongSpear, priceMartial);
                    Console.WriteLine("/To buy the book please type Martial Arts Book/");
                    Console.WriteLine("You have {0} Buckles",Buckles);
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "steel sword":
                            if (Buckles > priceSteelSword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Steel Sword for {0} Buckles", priceSteelSword);
                                Console.ResetColor();
                                Buckles = Buckles - priceSteelSword;
                                weaponDmg = 4;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "long spear":
                            if (Buckles > priceLongSpear)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Long Spear for {0} Buckles", priceLongSpear);
                                Console.ResetColor();
                                Buckles = Buckles - priceLongSpear;
                                weaponDmg = 5;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "martial arts book":
                            if (Buckles > priceMartial)
                            {
                                if (playerInt > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                    Console.ResetColor();
                                    Buckles = Buckles - priceMartial;
                                    playerStrenght = playerStrenght + 6;
                                    playerAgi = playerAgi + 6;
                                }
                                else
                                {
                                    Console.WriteLine("You do not have high enough intelligence");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "leave":
                            Console.WriteLine("You left the shop");
                            break;
                        default:
                            Console.WriteLine("We dont have this item in stock");
                            break;
                    }
                }
            }
            Console.WriteLine("You think about unwinding in the bar, or going home and sleeping for a while");
            Console.WriteLine("|Go to the Bar|  |Go Home|");
            command = Console.ReadLine();
            switch (command.ToLower())
            {
                case "go to the bar":
                    Console.WriteLine("You hear a loud shout from the bar 'OH YEAH, YOU GOING TO RUN AWAY?!'.\nYou come through the door to see a man on the ground and a man with a broken bottle standing above him");
                    Console.WriteLine("\n the man with the bottle looks at you and shouts 'WHAT, YOU WANT TO FIGHT?!' and runs at you with his bottle");
                    playerHealth = 100+(playerEndurance*2);
                    double brokenBottleHealth = 50;
                    while (brokenBottleHealth > 0)//plays until man is dead
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enemy Health: " + brokenBottleHealth);
                        Console.WriteLine("Player Health: " + playerHealth);
                        Console.WriteLine("You can |Attack| |Defend| |Pass Turn|");
                        Console.WriteLine();
                        command = Console.ReadLine();
                        Console.WriteLine();
                        switch (command.ToLower())
                        {
                            case "attack":
                                damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                                critical = rnd.Next(0, 10 + playerLuck);
                                if (critical > 15 + playerStrenght)
                                {
                                    Console.WriteLine("Critical hit");
                                    damage = damage * 2;

                                }
                                if (damage < 0)
                                {
                                    damage = 0;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("The enemy blocked the attack");
                                    Console.ResetColor();

                                }
                                brokenBottleHealth = brokenBottleHealth - damage;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("you deal {0} damage", damage);
                                Console.ResetColor();
                                Console.WriteLine("the enemy has {0} health left", brokenBottleHealth);
                                break;
                            case "defend":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You put your self into defensive position");
                                Console.ResetColor();
                                defense = rnd.Next(0, 10 + playerEndurance*2);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You pass the turn");
                                Console.ResetColor();
                                break;

                        }

                        enemyTurn = rnd.Next(1, 3);
                        switch (enemyTurn)
                        {
                            case 1:

                                enemyDamage = rnd.Next(0, 13) - defense;
                                int agility = rnd.Next(0, 5 + playerAgi);
                                if (enemyDamage < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You blocked this attack");
                                    Console.ResetColor();
                                    enemyDamage = enemyDamage * 0;
                                }
                                if (agility > 8 + playerStrenght)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You doged this attack");
                                    Console.ResetColor();
                                    enemyDamage = enemyDamage * 0;
                                }
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                                Console.ResetColor();
                                playerHealth = playerHealth - enemyDamage;
                                Console.WriteLine("You have {0} health left", playerHealth);
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The enemy gets into a defensive position");
                                Console.ResetColor();
                                enemyDefense = rnd.Next(0, 3);
                                break;
                            default:
                                break;
                        }

                        if (playerHealth <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GAME OVER");
                            Console.ResetColor();
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                    }
                    Console.WriteLine("After knocking the man out the man on the ground thanks you, you notice the mans broken bottle");
                    Console.WriteLine("Would you like to |Equip| the Bottle(+8 Attack) or |Leave|");
                    command = Console.ReadLine();
                    if (command.ToLower() == "equip")
                    {
                        Console.WriteLine("You have equipped the Bottle");
                        weaponDmg = 8;
                    }
                    else
                    {
                        Console.WriteLine("You left the scene without taking anything");
                    }
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("You go home, after an exhausting day");
            Console.WriteLine("You choose to go through a shortcut you used many times before, but this time there is a man you havent seen here before appear out of nowhere");
            Console.WriteLine("A few seconds after you notice him, theres a sharp pain in your stomach");

            playerHealth = 100+(playerEndurance*2);
            double BossHealth = 500;
            while (playerHealth > 0)//plays until player is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + BossHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn|");
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        BossHealth = BossHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", BossHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:

                        enemyDamage = rnd.Next(100, 101) - defense;
                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerEndurance)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = playerHealth - enemyDamage;
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(100, 100);
                        break;
                    default:
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You have been knocked out");
            Console.ResetColor();
            Buckles = 0;
            Console.WriteLine("When you wake all your money is gone");
            Console.WriteLine("You feel stressed as  only have 3 days left to pay off the payment");
            Console.WriteLine("You will remeber the mans face for until you beat him yourself");
            playerHealth = 100+(playerEndurance*2);
            Console.WriteLine("But you still have the match to attend");
            Console.WriteLine();
            Console.WriteLine("You are assigned Gronk the Gronk");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("/Gronk deals poison damage, this damage ignores defence and dodge, it is a small amount though/");
            Console.ResetColor();

            double gronkHealth = 150;
            while (gronkHealth > 0)//plays until gronk is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + gronkHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn|");
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        gronkHealth = gronkHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", gronkHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                        int gronkpoison = rnd.Next(0, 4);
                        enemyDamage = rnd.Next(1, 11) - defense;
                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage and {1} poison damage", enemyDamage ,gronkpoison);
                        Console.ResetColor();
                        playerHealth = (playerHealth - enemyDamage) -gronkpoison;
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(1, 6);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }


            Console.WriteLine("Congrats you leveled up and gained 2 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }
            Buckles = Buckles + 200;



            while (command.ToLower() != "leave")
            {
                Console.WriteLine("You have entered the arena shop");
                Console.WriteLine("|Buy|  |Leave|");
                command = Console.ReadLine();
                int priceSharpSword = 55 - playerCharisma;
                int priceFlexibleSpear = 60 - playerCharisma;
                int priceMartial = 300 - playerCharisma;
                if (command.ToLower() == "buy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                    Console.ResetColor();
                    Console.WriteLine("The items available are: ");
                    Console.Write("\n |Sharp Sword|({0} Buckels)(+6 Attack) \n |Flexible Spear|({1} Buckels)(+7 Attack) \n |Learning Martial Arts for Dummies 101|({2} Buckles)(requires 6 Intelligence) |Leave|", priceSharpSword, priceFlexibleSpear, priceMartial);
                    Console.WriteLine("/To buy the book please type Martial Arts Book/");
                    Console.WriteLine("You have {0} Buckles", Buckles);
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "sharp sword":
                            if (Buckles > priceSharpSword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Sharp Sword for {0} Buckles", priceSharpSword);
                                Console.ResetColor();
                                Buckles = Buckles - priceSharpSword;
                                weaponDmg = 6;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "flexible spear":
                            if (Buckles > priceFlexibleSpear)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Flexible Spear for {0} Buckles", priceFlexibleSpear);
                                Console.ResetColor();
                                Buckles = Buckles - priceFlexibleSpear;
                                weaponDmg = 7;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "martial arts book":
                            if (Buckles > priceMartial)
                            {
                                if (playerInt > 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                    Console.ResetColor();
                                    Buckles = Buckles - priceMartial;
                                    playerStrenght = playerStrenght + 6;
                                    playerAgi = playerAgi + 6;
                                }
                                else
                                {
                                    Console.WriteLine("You do not have high enough intelligence");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "leave":
                            Console.WriteLine("You left the shop");
                            break;
                        default:
                            Console.WriteLine("We dont have this item in stock");
                            break;
                    }
                }
            }

            Console.WriteLine("During the way home a man runs up to you, winded he tells you: ");
            Console.WriteLine("Oh my god, i am a big fan, i heard you are having some money problems soo here, hope it helps. Good luck in the next fight {0}",name);
            Console.WriteLine("\nHe gives you 60 Buckles");
            Buckles = Buckles + 60;
            Console.WriteLine("\n");
            Console.WriteLine("This time on your way home you avoid any shortcuts");
            Console.WriteLine("You get home and sleep");
            playerHealth = 100 + (playerEndurance * 2);
            Console.WriteLine("While going to the arena to find out who your next opponent a shady shopkeeper prompts you to come to him ");
            Console.WriteLine("Do you accept and |Go to the shopkeeper| or |Leave|");
            command = Console.ReadLine();
            if (command.ToLower() == "go to the shopkeeper")
            {
                while (command.ToLower() != "leave")
                {
                    Console.WriteLine("You have entered the Shady shop");
                    Console.WriteLine("|Buy|  |Leave|");
                    command = Console.ReadLine();
                    int priceHuman = 70 - playerCharisma;
                    int priceShield = 80 - playerCharisma;
                    int priceMartial = 200 - playerCharisma;
                    if (command.ToLower() == "buy")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                        Console.ResetColor();
                        Console.WriteLine("The items available are: ");
                        Console.Write("\n |The Human Body 101|({0} Buckels)(Increases Crit chance)(Requires 4 Int) \n |Small Shield|({1} Buckels)(+4 Defense while defending) \n |Learning Martial Arts for Dummies 101|({2} Buckles)(requires 6 Intelligence) |Leave|", priceHuman, priceShield, priceMartial);
                        Console.WriteLine("\n/To buy the book please type Human Body or Martial Arts Book/");
                        Console.WriteLine("You have {0} Buckles", Buckles);
                        command = Console.ReadLine();
                        switch (command.ToLower())
                        {
                            case "human body":
                                if (Buckles > priceHuman)
                                {
                                    if (playerInt>=4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought The Human Body 101 for {0} Buckles", priceHuman);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceHuman;
                                        critChance = 5;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have enough Intelligence");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You do not have enough Buckles");
                                    Console.ResetColor();
                                }
                                break;
                            case "small shield":
                                if (Buckles > priceShield)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have bought the Shield for {0} Buckles", priceShield);
                                    Console.ResetColor();
                                    Buckles = Buckles - priceShield;
                                    defenseBonus = 4;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You do not have enough Buckles");
                                    Console.ResetColor();
                                }
                                break;
                            case "martial arts book":
                                if (Buckles > priceMartial)
                                {
                                    if (playerInt >= 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceMartial;
                                        playerStrenght = playerStrenght + 6;
                                        playerAgi = playerAgi + 6;
                                        martialArts = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have high enough intelligence");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You do not have enough Buckles");
                                    Console.ResetColor();
                                }
                                break;
                            case "leave":
                                Console.WriteLine("You left the shop");
                                break;
                            default:
                                Console.WriteLine("We dont have this item in stock");
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("You arrive at the arena and are told that you are to fight Joe McShmoe");

            double joeHealth = 200;
            while (joeHealth > 0)//plays until gronk is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + joeHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                if (cooldown >0)
                {
                    cooldown = cooldown - 1;
                }
                
                if (cooldown > 0)
                {
                    Console.WriteLine("Skills are on cooldown");
                }
                if (martialArts == 1)
                {
                    skills = "Skills";
                }
                else
                {
                    skills = "Locked";
                }
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn| |{0}|",skills);
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck+critChance);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        joeHealth = joeHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", joeHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2) +defenseBonus;
                        break;
                    case "skills":
                        if (cooldown <= 0) //pokud he cooldown mensi nebo = nule
                        {
                            if (martialArts == 1) //pokud je zakoupena kniha
                            {
                                Console.WriteLine("|High Kick| |Leg Sweep| |Payback|"); //nabidka
                                command = Console.ReadLine();
                                switch (command.ToLower())
                                {
                                    case "high kick":
                                        Console.WriteLine("You use High Kick");
                                        damage = rnd.Next(0, (14 + playerStrenght / 2) + playerAgi);
                                        joeHealth = joeHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                     
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", joeHealth);
                                        cooldown = cooldown + 4;
                                        break;
                                    case "leg sweep":
                                        Console.WriteLine("You use Leg Sweep");
                                        damage = rnd.Next(0, (6 + playerStrenght / 2) + playerAgi);
                                        confuse = rnd.Next(1, 4);
                                        joeHealth = joeHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                     
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage and {1} confuse", damage ,confuse);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", joeHealth);
                                        cooldown = cooldown + 2;
                                        break;
                                    case "payback":
                                        damage = enemyDamage;
                                        joeHealth = joeHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                       
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", joeHealth);
                                        cooldown = cooldown + 3;
                                        break;
                                    default:
                                        Console.WriteLine("Unknown");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You were warned :)");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                        if (joeHealth < 50)
                        {
                            Console.WriteLine("The enemy uses Rage");
                            enemyDamage = (rnd.Next(5, 20) - defense) - confuse;
                        }
                        else
                        {
                            enemyDamage = (rnd.Next(1, 9) - defense) - confuse;
                        }
                        
                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = (playerHealth - enemyDamage);
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(1, 9);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }

            Console.WriteLine("Congrats you leveled up and gained 3 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }
            Buckles = Buckles + 300;

            if (martialArts ==1)
            {
                martialArtsShop = "Alredy Bought";
            }
            else
            {
                martialArtsShop = "Learning Martial Arts for Dummies 101";
            }

            while (command.ToLower() != "leave")
            {
                Console.WriteLine("You have entered the arena shop");
                Console.WriteLine("|Buy|  |Leave|");
                command = Console.ReadLine();
                int priceGreatSword = 60 - playerCharisma;
                int priceHalberd = 65 - playerCharisma;
                int priceMartial = 300 - playerCharisma;
                if (command.ToLower() == "buy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("The items available are: ");
                    Console.Write("\n |Greatsword|({0} Buckels)(+6 Attack) \n |Halberd|({1} Buckels)(+7 Attack) \n |{2}|({3} Buckles)(requires 6 Intelligence) |Leave|", priceGreatSword, priceHalberd, martialArtsShop , priceMartial);
                    Console.WriteLine("/To buy the book please type Martial Arts Book/");
                    Console.WriteLine("You have {0} Buckles", Buckles);
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "greatsword":
                            if (Buckles > priceGreatSword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the  Greatsword for {0} Buckles", priceGreatSword);
                                Console.ResetColor();
                                Buckles = Buckles - priceGreatSword;
                                weaponDmg = 9;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "halberd":
                            if (Buckles > priceHalberd)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Halberd for {0} Buckles", priceHalberd);
                                Console.ResetColor();
                                Buckles = Buckles - priceHalberd;
                                weaponDmg = 10;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "martial arts book":
                            if (martialArtsShop == "Alredy Bought")
                            {
                                Console.WriteLine("Alredy Bought");
                            }
                            else
                            {
                                if (Buckles > priceMartial)
                                {
                                    if (playerInt > 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceMartial;
                                        playerStrenght = playerStrenght + 6;
                                        playerAgi = playerAgi + 6;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have high enough intelligence");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You do not have enough Buckles");
                                    Console.ResetColor();
                                }
                               
                            }
                            break;
                        case "leave":
                            Console.WriteLine("You left the shop");
                            break;
                        default:
                            Console.WriteLine("We dont have this item in stock");
                            break;
                    }
                }
            }



            Console.WriteLine("While going home 3 members of the Mob come up to you and remind you, that you have to pay the 500 Buckles in 2 days");
            Console.WriteLine("You get home and decide you have quite a bit of time still left before you go to bed");
            Console.WriteLine("");
            Console.WriteLine("You can either |Train| or |Rest|");
            command = Console.ReadLine();
            if (command.ToLower() == "train")
            {
                Console.WriteLine("Congrats you leveled up and gained 2 stat points you can assign them here");
                Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
                for (int i = 0; i < 2; i++)
                {
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "strenght":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Strenght by one");
                            Console.ResetColor();
                            playerStrenght++;
                            break;
                        case "agility":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Agility by one");
                            Console.ResetColor();
                            playerAgi++;
                            break;
                        case "luck":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Luck by one");
                            Console.ResetColor();
                            playerLuck++;
                            break;
                        case "endurance":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Endurance by one");
                            Console.ResetColor();
                            playerEndurance++;
                            break;
                        case "int":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Intelligence by one");
                            Console.ResetColor();
                            playerInt++;
                            break;
                        case "charisma":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Charisma by one");
                            Console.ResetColor();
                            playerCharisma++;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You wasted a stat point");
                            Console.ResetColor();
                            break;
                    }
                }
                playerHealth = 100 + playerEndurance*2;
            }
            else
            {
                playerHealth = 150 + playerEndurance*2;
            }

            Console.WriteLine("You go to bed after you are done");
            Console.WriteLine("");
            Console.WriteLine("You wake up and go to the arena");
            Console.WriteLine("You learn you are to fight Maxwell The Serpent");

            double maxwellHealth = 150;
            while (maxwellHealth > 0)//plays until gronk is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + maxwellHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                if (cooldown > 0)
                {
                    cooldown = cooldown - 1;
                }

                if (cooldown > 0)
                {
                    Console.WriteLine("Skills are on cooldown");
                }
                if (martialArts == 1)
                {
                    skills = "Skills";
                }
                else
                {
                    skills = "Locked";
                }
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn| |{0}|", skills);
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck + critChance);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        maxwellHealth = maxwellHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", maxwellHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2) + defenseBonus;
                        break;
                    case "skills":
                        if (cooldown <= 0) //pokud he cooldown mensi nebo = nule
                        {
                            if (martialArts == 1) //pokud je zakoupena kniha
                            {
                                Console.WriteLine("|High Kick| |Leg Sweep| |Payback|"); //nabidka
                                command = Console.ReadLine();
                                switch (command.ToLower())
                                {
                                    case "high kick":
                                        Console.WriteLine("You use High Kick");
                                        damage = rnd.Next(0, (14 + playerStrenght / 2) + playerAgi);
                                        maxwellHealth = maxwellHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", maxwellHealth);
                                        cooldown = cooldown + 4;
                                        break;
                                    case "leg sweep":
                                        Console.WriteLine("You use Leg Sweep");
                                        damage = rnd.Next(0, (6 + playerStrenght / 2) + playerAgi);
                                        confuse = rnd.Next(1, 4);
                                        maxwellHealth = maxwellHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage and {1} confuse", damage, confuse);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", maxwellHealth);
                                        cooldown = cooldown + 2;
                                        break;
                                    case "payback":
                                        damage = enemyDamage;
                                        maxwellHealth = maxwellHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", maxwellHealth);
                                        cooldown = cooldown + 3;
                                        break;
                                    default:
                                        Console.WriteLine("Unknown");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You were warned :)");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                        if (maxwellHealth < 40)
                        {
                            Console.WriteLine("The enemy uses Counter");
                            enemyDamage = (damage - defense)-confuse;
                        }
                        else
                        {
                            enemyDamage = (rnd.Next(1, 15) - defense) - confuse;
                        }

                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = (playerHealth - enemyDamage);
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(1, 9);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }


            Console.WriteLine("Congrats you leveled up and gained 3 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }


            Buckles = Buckles + 400;

            if (martialArts == 1)
            {
                martialArtsShop = "Alredy Bought";
            }
            else
            {
                martialArtsShop = "Learning Martial Arts for Dummies 101";
            }

            while (command.ToLower() != "leave")
            {
                Console.WriteLine("You have entered the arena shop");
                Console.WriteLine("|Buy|  |Leave|");
                command = Console.ReadLine();
                int priceGreatSword = 60 - playerCharisma;
                int priceHalberd = 65 - playerCharisma;
                int priceMartial = 300 - playerCharisma;
                if (command.ToLower() == "buy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("The items available are: ");
                    Console.Write("\n |Greatsword|({0} Buckels)(+6 Attack) \n |Halberd|({1} Buckels)(+7 Attack) \n |{2}|({3} Buckles)(requires 6 Intelligence) |Leave|", priceGreatSword, priceHalberd, martialArtsShop, priceMartial);
                    Console.WriteLine("/To buy the book please type Martial Arts Book/");
                    Console.WriteLine("You have {0} Buckles", Buckles);
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "greatsword":
                            if (Buckles > priceGreatSword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the  Greatsword for {0} Buckles", priceGreatSword);
                                Console.ResetColor();
                                Buckles = Buckles - priceGreatSword;
                                weaponDmg = 9;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "halberd":
                            if (Buckles > priceHalberd)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have bought the Halberd for {0} Buckles", priceHalberd);
                                Console.ResetColor();
                                Buckles = Buckles - priceHalberd;
                                weaponDmg = 10;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You do not have enough Buckles");
                                Console.ResetColor();
                            }
                            break;
                        case "martial arts book":
                            if (martialArtsShop == "Alredy Bought")
                            {
                                Console.WriteLine("Alredy Bought");
                            }
                            else
                            {
                                if (Buckles > priceMartial)
                                {
                                    if (playerInt > 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceMartial);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceMartial;
                                        playerStrenght = playerStrenght + 6;
                                        playerAgi = playerAgi + 6;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have high enough intelligence");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You do not have enough Buckles");
                                    Console.ResetColor();
                                }

                            }
                            break;
                        case "leave":
                            Console.WriteLine("You left the shop");
                            break;
                        default:
                            Console.WriteLine("We dont have this item in stock");
                            break;
                    }
                }
            }

            Console.WriteLine("You go home, stressed about the collection of the payment you go to sleep early");
            Console.WriteLine("");
            Console.WriteLine("You wake up and get to the arena,when you get there you alredy see many members of the Mob lining the spectator ");
            playerHealth = 100 + playerEndurance*2;

            Console.WriteLine("You learn that you are assigned one of the stronger members of the Mob");
            Console.WriteLine();
            Console.WriteLine("Anthony The Smooth Sword");

            double anthonyHealth = 250;
            while (anthonyHealth > 0)//plays until anthony is dead
            {
                Console.WriteLine();
                Console.WriteLine("Enemy Health: " + anthonyHealth);
                Console.WriteLine("Player Health: " + playerHealth);
                if (cooldown > 0)
                {
                    cooldown = cooldown - 1;
                }

                if (cooldown > 0)
                {
                    Console.WriteLine("Skills are on cooldown");
                }
                if (martialArts == 1)
                {
                    skills = "Skills";
                }
                else
                {
                    skills = "Locked";
                }
                Console.WriteLine("You can |Attack| |Defend| |Pass Turn| |{0}|", skills);
                Console.WriteLine();
                command = Console.ReadLine();
                Console.WriteLine();
                switch (command.ToLower())
                {
                    case "attack":
                        damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                        critical = rnd.Next(0, 10 + playerLuck + critChance);
                        if (critical > 15 + playerStrenght)
                        {
                            Console.WriteLine("Critical hit");
                            damage = damage * 2;

                        }
                        if (damage < 0)
                        {
                            damage = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The enemy blocked the attack");
                            Console.ResetColor();

                        }
                        anthonyHealth = anthonyHealth - damage;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("you deal {0} damage", damage);
                        Console.ResetColor();
                        Console.WriteLine("the enemy has {0} health left", anthonyHealth);
                        break;
                    case "defend":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You put your self into defensive position");
                        Console.ResetColor();
                        defense = rnd.Next(0, 10 + playerEndurance*2) + defenseBonus;
                        break;
                    case "skills":
                        if (cooldown <= 0) //pokud he cooldown mensi nebo = nule
                        {
                            if (martialArts == 1) //pokud je zakoupena kniha
                            {
                                Console.WriteLine("|High Kick| |Leg Sweep| |Payback|"); //nabidka
                                command = Console.ReadLine();
                                switch (command.ToLower())
                                {
                                    case "high kick":
                                        Console.WriteLine("You use High Kick");
                                        damage = rnd.Next(0, (14 + playerStrenght / 2) + playerAgi);
                                        anthonyHealth = anthonyHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", anthonyHealth);
                                        cooldown = cooldown + 4;
                                        break;
                                    case "leg sweep":
                                        Console.WriteLine("You use Leg Sweep");
                                        damage = rnd.Next(0, (6 + playerStrenght / 2) + playerAgi);
                                        confuse = rnd.Next(1, 4);
                                        anthonyHealth = anthonyHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage and {1} confuse ", damage, confuse);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", anthonyHealth);
                                        cooldown = cooldown + 2;
                                        break;
                                    case "payback":
                                        damage = enemyDamage;
                                        anthonyHealth = anthonyHealth - damage;
                                        if (damage < 0)
                                        {
                                            damage = 0;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("The enemy blocked the attack");
                                            Console.ResetColor();

                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("you deal {0} damage", damage);
                                        Console.ResetColor();
                                        Console.WriteLine("the enemy has {0} health left", anthonyHealth);
                                        cooldown = cooldown + 3;
                                        break;
                                    default:
                                        Console.WriteLine("Unknown");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You were warned :)");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pass the turn");
                        Console.ResetColor();
                        break;

                }

                enemyTurn = rnd.Next(1, 3);
                switch (enemyTurn)
                {
                    case 1:
                        if (anthonyHealth < 30)
                        {
                            Console.WriteLine("The enemy uses Perfect Strike");
                            enemyDamage = (rnd.Next(1, 26) - defense) - confuse;
                        }
                        else
                        {
                            enemyDamage = (rnd.Next(1, 10) - defense) - confuse;
                        }

                        int agility = rnd.Next(0, 5 + playerAgi);
                        if (enemyDamage < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You blocked this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        if (agility > 8 + playerStrenght)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You doged this attack");
                            Console.ResetColor();
                            enemyDamage = enemyDamage * 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                        Console.ResetColor();
                        playerHealth = (playerHealth - enemyDamage);
                        Console.WriteLine("You have {0} health left", playerHealth);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The enemy gets into a defensive position");
                        Console.ResetColor();
                        enemyDefense = rnd.Next(1, 9);
                        break;
                    default:
                        break;
                }

                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("Congrats you leveled up and gained 3 stat points you can assign them here");
            Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
            for (int i = 0; i < 2; i++)
            {
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "strenght":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Strenght by one");
                        Console.ResetColor();
                        playerStrenght++;
                        break;
                    case "agility":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Agility by one");
                        Console.ResetColor();
                        playerAgi++;
                        break;
                    case "luck":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Luck by one");
                        Console.ResetColor();
                        playerLuck++;
                        break;
                    case "endurance":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Endurance by one");
                        Console.ResetColor();
                        playerEndurance++;
                        break;
                    case "int":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Intelligence by one");
                        Console.ResetColor();
                        playerInt++;
                        break;
                    case "charisma":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have upgraded your Charisma by one");
                        Console.ResetColor();
                        playerCharisma++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You wasted a stat point");
                        Console.ResetColor();
                        break;
                }
            }

            Buckles = Buckles + 500;
            playerHealth = 100 + playerEndurance * 2;
            Console.WriteLine("Once you come out of the arena 20 Mob members confront you");
            Console.WriteLine("They hand you a briefcase and tell you to fill it with the money you own");
            Console.WriteLine("You can either |Pay up| |Fight|");
            command = Console.ReadLine();

            if (command.ToLower() == "fight")
            {
                for (int i = 0; i < 20; i++)
                {
                    double MobHealth = 50;
                    while (MobHealth > 0)//plays until anthony is dead
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enemy Health: " + MobHealth);
                        Console.WriteLine("Player Health: " + playerHealth);
                        if (cooldown > 0)
                        {
                            cooldown = cooldown - 1;
                        }

                        if (cooldown > 0)
                        {
                            Console.WriteLine("Skills are on cooldown");
                        }
                        if (martialArts == 1)
                        {
                            skills = "Skills";
                        }
                        else
                        {
                            skills = "Locked";
                        }
                        Console.WriteLine("You can |Attack| |Defend| |Pass Turn| |{0}|", skills);
                        Console.WriteLine();
                        command = Console.ReadLine();
                        Console.WriteLine();
                        switch (command.ToLower())
                        {
                            case "attack":
                                damage = rnd.Next(0, (8 + playerStrenght / 2)) + weaponDmg - enemyDefense;

                                critical = rnd.Next(0, 10 + playerLuck + critChance);
                                if (critical > 15 + playerStrenght)
                                {
                                    Console.WriteLine("Critical hit");
                                    damage = damage * 2;

                                }
                                if (damage < 0)
                                {
                                    damage = 0;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("The enemy blocked the attack");
                                    Console.ResetColor();

                                }
                                MobHealth = MobHealth - damage;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("you deal {0} damage", damage);
                                Console.ResetColor();
                                Console.WriteLine("the enemy has {0} health left", MobHealth);
                                break;
                            case "defend":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You put your self into defensive position");
                                Console.ResetColor();
                                defense = rnd.Next(0, 10 + playerEndurance*2) + defenseBonus;
                                break;
                            case "skills":
                                if (cooldown <= 0) //pokud he cooldown mensi nebo = nule
                                {
                                    if (martialArts == 1) //pokud je zakoupena kniha
                                    {
                                        Console.WriteLine("|High Kick| |Leg Sweep| |Payback|"); //nabidka
                                        command = Console.ReadLine();
                                        switch (command.ToLower())
                                        {
                                            case "high kick":
                                                Console.WriteLine("You use High Kick");
                                                damage = rnd.Next(0, (14 + playerStrenght / 2) + playerAgi);
                                                MobHealth = MobHealth - damage;
                                                if (damage < 0)
                                                {
                                                    damage = 0;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("The enemy blocked the attack");
                                                    Console.ResetColor();

                                                }

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("you deal {0} damage", damage);
                                                Console.ResetColor();
                                                Console.WriteLine("the enemy has {0} health left", MobHealth);
                                                cooldown = cooldown + 4;
                                                break;
                                            case "leg sweep":
                                                Console.WriteLine("You use Leg Sweep");
                                                damage = rnd.Next(0, (6 + playerStrenght / 2) + playerAgi);
                                                confuse = rnd.Next(1, 4);
                                                MobHealth = MobHealth - damage;
                                                if (damage < 0)
                                                {
                                                    damage = 0;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("The enemy blocked the attack");
                                                    Console.ResetColor();

                                                }

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("you deal {0} damage and {1} confuse ", damage, confuse);
                                                Console.ResetColor();
                                                Console.WriteLine("the enemy has {0} health left", MobHealth);
                                                cooldown = cooldown + 2;
                                                break;
                                            case "payback":
                                                damage = enemyDamage;
                                                MobHealth = MobHealth - damage;
                                                if (damage < 0)
                                                {
                                                    damage = 0;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("The enemy blocked the attack");
                                                    Console.ResetColor();

                                                }

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("you deal {0} damage", damage);
                                                Console.ResetColor();
                                                Console.WriteLine("the enemy has {0} health left", MobHealth);
                                                cooldown = cooldown + 3;
                                                break;
                                            default:
                                                Console.WriteLine("Unknown");
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You were warned :)");
                                    Console.ResetColor();
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You pass the turn");
                                Console.ResetColor();
                                break;

                        }

                        enemyTurn = rnd.Next(1, 3);
                        switch (enemyTurn)
                        {
                            case 1:
                               
                                
                                
                                    enemyDamage = (rnd.Next(1, 8) - defense) - confuse;
                                

                                int agility = rnd.Next(0, 5 + playerAgi);
                                if (enemyDamage < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You blocked this attack");
                                    Console.ResetColor();
                                    enemyDamage = enemyDamage * 0;
                                }
                                if (agility > 8 + playerStrenght)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You doged this attack");
                                    Console.ResetColor();
                                    enemyDamage = enemyDamage * 0;
                                }
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The enemy attacks and deals {0} damage", enemyDamage);
                                Console.ResetColor();
                                playerHealth = (playerHealth - enemyDamage);
                                Console.WriteLine("You have {0} health left", playerHealth);
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The enemy gets into a defensive position");
                                Console.ResetColor();
                                enemyDefense = rnd.Next(1, 9);
                                break;
                            default:
                                break;
                        }

                        if (playerHealth <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GAME OVER");
                            Console.ResetColor();
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                    }
                }
                Console.WriteLine("This should keep the mob off your back for a lot of time");
            }
            else
            {
                Console.WriteLine("You pay the 500 Buckles you owe");
                Buckles = Buckles - 500;
                Console.WriteLine("You now have {0} left",Buckles);
            }

            Console.WriteLine("Though paying off the payment gives you a large amount of time, you still have debt and your life is still in ruins");
            Console.WriteLine("");
            Console.WriteLine("You remeber there is a way to fix your broken life, the tournament coming up in a three days");
            Console.WriteLine("The tournament is in a different city though and it will take two days to get to there");
            Console.WriteLine("");
            Buckles = Buckles - 50;
            Console.WriteLine("You buy a carriage to Sigan where the tournament is taking place");
            Console.WriteLine("After two days of uncomfortable sitting you arrive to the city");
            Console.WriteLine("\nTheres much fanfare to the tournament, there are people in the streets celebrating");
            Console.WriteLine("And a giant colosseum in the middle of the city, after all a god is hosting this, it is a grand event");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You walk to the arena noticing there are many shops around it, the entrance is a enormous gate, surrounded with 20 fully geared guards");
            Console.WriteLine("Inside there are another 50 guards in a room, you assume is a lobby");
            Console.WriteLine("");
            Console.WriteLine("After you stand in awe for a few seconds a man in a suit asks you 'Are you here to participate?'");
            Console.WriteLine("You of course answer yes, he hands you a form 'Fill this in please' ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Stats:");
            Console.WriteLine("Strenght |{0}|",playerStrenght);
            Console.WriteLine("Agility |{0}|", playerAgi);
            Console.WriteLine("Luck |{0}|",playerLuck);
            Console.WriteLine("Endurance |{0}|",playerEndurance);
            Console.WriteLine("Charisma |{0}|",playerCharisma);
            Console.WriteLine("Intelligence |{0}|",playerInt);
            Console.WriteLine("Fighting Style: _______");
            Console.ResetColor();
            Console.WriteLine("\nYou walk to another man in a suit and ask him about the last field 'Ah, no problem theres going to be a training course for first timers later'");
            Console.WriteLine("He takes the form from you");
            Console.WriteLine("'Ok, just come back in 2 hours, in the mean time do whatever you want'");
            Console.WriteLine("|Train| |Explore the city|");
            command = Console.ReadLine();
            if (command.ToLower() == "train" )
            {
                Console.WriteLine("Congrats you leveled up and gained 3 stat points you can assign them here");
                Console.WriteLine("|Strenght| |Agility| |Int (intelligence)| |Endurance| |Charisma| |Luck|");
                for (int i = 0; i < 2; i++)
                {
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "strenght":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Strenght by one");
                            Console.ResetColor();
                            playerStrenght++;
                            break;
                        case "agility":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Agility by one");
                            Console.ResetColor();
                            playerAgi++;
                            break;
                        case "luck":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Luck by one");
                            Console.ResetColor();
                            playerLuck++;
                            break;
                        case "endurance":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Endurance by one");
                            Console.ResetColor();
                            playerEndurance++;
                            break;
                        case "int":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Intelligence by one");
                            Console.ResetColor();
                            playerInt++;
                            break;
                        case "charisma":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have upgraded your Charisma by one");
                            Console.ResetColor();
                            playerCharisma++;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You wasted a stat point");
                            Console.ResetColor();
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Theres a old man sitting in the open with another chair unocuppied");
                Console.WriteLine("There are also many shops around the arena");
                Console.WriteLine("|Go to the man| |Explore the shops|");
                command = Console.ReadLine();
                if (command.ToLower() == "explore the shops")
                {
                    while (command.ToLower() != "leave")
                    {
                        Console.WriteLine("You have entered the shop");
                        Console.WriteLine("|Buy|  |Leave|");
                        command = Console.ReadLine();
                        int priceCurvedSword = 100 - playerCharisma;
                        int priceSarissa = 110 - playerCharisma;
                        int priceTowerShield = 100 - playerCharisma;
                        if (command.ToLower() == "buy")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("/Buying something will instantly equip the item, you cannot unequip items any other way other then equiping a new one. Books are permanent stat boosts, some also have hidden effects/");
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.WriteLine("The items available are: ");
                            Console.Write("\n |Curved Sword|({0} Buckels)(+12 Attack) \n |Sarissa|({1} Buckels)(+13 Attack) \n |Tower Shield|({3} Buckles) (+9 defense) |Leave|", priceCurvedSword, priceSarissa , priceTowerShield);
                            Console.WriteLine();
                            Console.WriteLine("You have {0} Buckles", Buckles);
                            command = Console.ReadLine();
                            switch (command.ToLower())
                            {
                                case "curved sword":
                                    if (Buckles > priceCurvedSword)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought the  Greatsword for {0} Buckles", priceCurvedSword);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceCurvedSword;
                                        weaponDmg = 12;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You do not have enough Buckles");
                                        Console.ResetColor();
                                    }
                                    break;
                                case "sarissa":
                                    if (Buckles > priceSarissa)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You have bought the Halberd for {0} Buckles", priceSarissa);
                                        Console.ResetColor();
                                        Buckles = Buckles - priceSarissa;
                                        weaponDmg = 13;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You do not have enough Buckles");
                                        Console.ResetColor();
                                    }
                                    break;
                                case "tower shield":
                                        if (Buckles > priceTowerShield)
                                        {
                                           
                                            
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("You have bought the Martial Arts book for {0} Buckels", priceTowerShield);
                                                Console.ResetColor();
                                                Buckles = Buckles - priceTowerShield;
                                            defenseBonus = 9;
                                            
                                           
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("You do not have enough Buckles");
                                            Console.ResetColor();
                                        }

                                    
                                    break;
                                case "leave":
                                    Console.WriteLine("You left the shop");
                                    break;
                                default:
                                    Console.WriteLine("We dont have this item in stock");
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You sit in front of the man, he looks at you excited");
                    Console.WriteLine("'Ah, young man want to play a little game?' he shows you a coin");
                    Console.WriteLine("We will pick sides and ill throw it, if it lands on mine you give me 50 Buckles, if yours ill give you 50 Buckles");
                    Console.WriteLine("Do you |Accept|?");
                    Console.WriteLine("You have {0} Buckles",Buckles);
                    Console.WriteLine("|Accept| |Decline|");
                    command = Console.ReadLine();
                    if (command.ToLower() == "accept")
                    {
                        command = "continue";
                        while (command.ToLower() == "continue")
                        {
                            Console.WriteLine("Pick a side");
                            Console.WriteLine("|Heads| |Tails|");
                            choosenSide = Console.ReadLine();
                            Console.WriteLine("The man throws the coin");
                            coinSideNumber = rnd.Next(1, 3);
                            switch (coinSideNumber)
                            {
                                case 1:
                                    coinSide = "head";
                                    break;
                                case 2:
                                    coinSide = "tails";
                                    break;
                                default:
                                    coinSide = "head";
                                    break;
                            }
                            if (coinSide == choosenSide)
                            {
                                Console.WriteLine("You Win!");
                                Buckles = Buckles + 50;
                                coinWins++;
                                Console.WriteLine("You now have {0} Buckles",Buckles);
                            }
                            else
                            {
                                Console.WriteLine("You Lose :(");
                                Buckles = Buckles - 50;
                                Console.WriteLine("You now have {0} Buckles",Buckles);
                            }
                            Console.WriteLine("|Continue| |Leave|");
                            command = Console.ReadLine();
                        }
                    }
                }
            }

            Console.WriteLine("You come back to the colloseum and the man in the suit prompts you to come over to him");
            Console.WriteLine("'The training starts in about 30 minutes, you should stay here'");
            Console.WriteLine("Would you like to stay for the training or skip over it");
            Console.WriteLine("|Stay| |Skip|");
            command = Console.ReadLine();
            if (command.ToLower() == "stay")
            {
                Console.WriteLine("You wait for the training, after a while you are invited in a large room where you see at least a 100 people");
                Console.WriteLine("You assume they are participants");
                Console.WriteLine("");
                Console.WriteLine("A man with glasses walks into the front of the room, he starts talking");
                Console.WriteLine("");
                Console.WriteLine("'Hello people, today ill tell you about fighting styles and the benefits of having one, well, more like a necessity of having one'");
            }

            Console.ReadLine();
        }
    }
}
