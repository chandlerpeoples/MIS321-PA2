using System;
using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class Character
    {
        public string name {get; set;}
        public string type {get; set;}
        public int maxPower {get; set;}
        public int health {get; set;}
        public int attackStrength {get; set;}
        public int defensivePower {get; set;}

        public IAttack attackBehavior {get; set;}
        public IDefend defendBehavior {get; set;}

        public Character()
        {
            health = 100;
            
            Random randomNum = new Random();
            maxPower = randomNum.Next(100) + 1;

            attackStrength = randomNum.Next(maxPower) + 1;
            defensivePower = randomNum.Next(maxPower) + 1;
        }

        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
        public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: " + name + "\nClass: " + type + "\nHealth: " + health + "\nMax Power: " + maxPower + "\nAttack Strength: " + attackStrength + "\nDefensive Power: " + defensivePower);
        }

    }
}