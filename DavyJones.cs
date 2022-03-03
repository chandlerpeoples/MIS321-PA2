using MIS321_PA2.interfaces;

namespace MIS321_PA2
{
    public class DavyJones: Character
    {
        public DavyJones()
        {
            type = "Davy Jones";
            attackBehavior = new CannonFire();
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