using MIS321_PA2.interfaces;

namespace MIS321_PA2    //JACK SPARROW ATTACK
{
    public class Distract: IAttack 
    {
        public void Attack(Character character)
        {
            System.Console.WriteLine($"{character.name} distracts the enemy!");
        }
    }
}