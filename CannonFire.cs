using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class CannonFire: IAttack
    {
        public void Attack(Character character)
        {
            System.Console.WriteLine($"{character.name} fires their cannons!");
        }
    }
}