using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class SwordSlash: IAttack
    {
        public void Attack(Character character)
        {
            System.Console.WriteLine($"{character.name} swings their sword!");
        }
    }
}