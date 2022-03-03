using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class WillTurner: Character
    {
        public WillTurner()
        {
            type = "Will Turner";
            attackBehavior = new SwordSlash();
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