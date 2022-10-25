using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponAmmoSystem
{
    internal class Program
    {
        static int[] MaxAmmo;
        static int[] Ammo;
        static int weapon;
        static string[] WeaponName;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Weapon Ammo System ===");

            weapon = 3;

            Ammo = new int[5];
            Ammo[0] = 14;
            Ammo[1] = 19;
            Ammo[2] = 18;
            Ammo[3] = 35;
            Ammo[4] = 5;

            MaxAmmo = new int[5];
            MaxAmmo[0] = 14;
            MaxAmmo[1] = 19;
            MaxAmmo[2] = 18;
            MaxAmmo[3] = 35;
            MaxAmmo[4] = 5;


            WeaponName = new string[5];
            WeaponName[0] = "P2020 Pistol";
            WeaponName[1] = "Alternator SMG";
            WeaponName[2] = "R301 Assault Rifle";
            WeaponName[3] = "Spitfire LMG";
            WeaponName[4] = "PeaceKeeper Shotgun";

            weaponAmmoCheck();

            Console.ReadKey();



            Fire(20);

            weaponAmmoCheck();


            Console.ReadKey(true);
            

            Reload();

            weaponAmmoCheck();

            Console.ReadKey(true);


        }

        static void weaponAmmoCheck()
        {

            Console.WriteLine("Weapon: " + WeaponName[weapon] + "          Ammo: " + Ammo[weapon]);
                
        }

        static void Fire(int bulletsShot)
        {
            Console.WriteLine("The player's about to use a " + WeaponName[weapon] + ", and fire" + bulletsShot + " Shots");
            
            Ammo[weapon] = Ammo[weapon] - bulletsShot;

            Console.WriteLine("The player just shot their " + WeaponName[weapon] + " " +bulletsShot + " Times!");
        }

        static void AmmoCheck()
        {
            if (Ammo[weapon] == 0)
            {
                Console.WriteLine("== Your mag for your " + WeaponName + " is empty!    Ammo: " + (Ammo[weapon] = 0));
            }
        }

        static void Reload()
        {
            Ammo[weapon] = Ammo[weapon] + MaxAmmo[weapon];


            if (Ammo[weapon] > MaxAmmo[weapon])
            {
                Ammo[weapon] = MaxAmmo[weapon];
                Console.WriteLine("Already at max Ammo for your " + WeaponName[weapon] + ".       Ammo: " + Ammo[weapon]);
            }
        }



    }
}
