using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class Block: IDefend
    {
        public void Defend(Character character)
        {
            System.Console.WriteLine($"{character.name} braces themself...");
        }
    }
}