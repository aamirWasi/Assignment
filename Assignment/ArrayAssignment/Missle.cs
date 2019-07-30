using System;

namespace ArrayAssignment
{
    public class Missle : Weapon
    {
        public Missle()
        {
            DamageAmount = 200;
        }
        public override void Fire()
        {
            Console.WriteLine($"Missle was damaged {DamageAmount} damageamount");
        }
    }
}
