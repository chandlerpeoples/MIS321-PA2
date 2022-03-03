using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class JackSparrow: Character
    {
        public JackSparrow()
        {
            type = "Jack Sparrow";
            attackBehavior = new Distract();
            defendBehavior = new Block();
        }
        new public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
        new public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }
    }
}