using System;

namespace ArrayAssignment
{
    public class MachineGun : Weapon
    {
        public MachineGun()
        {
            DamageAmount = 2300;
        }
        public override void Fire()
        {
            Console.WriteLine($"MachineGun was damaged {DamageAmount} damageamount");
        }
    }
}
