using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponAmmoSystem
{
    internal class Program
    {
        static int[] Ammo;
        static int weapon;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Weapon Ammo System ===");

            weapon = 0;

            Ammo = new int[5];
            Ammo[0] = 14;
            Ammo[1] = 19;
            Ammo[2] = 18;
            Ammo[3] = 35;
            Ammo[4] = 5;

            weaponAmmoCheck();


            Console.ReadKey();
        }



        static void weaponAmmoCheck()
        {

            Console.WriteLine("Ammo: " + Ammo[0]);
                
        }
    }
}
