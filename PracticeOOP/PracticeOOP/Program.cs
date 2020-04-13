using System;

namespace PracticeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new StudentClass().GetBooks();
            foreach (var item in books)
            {
                Console.WriteLine("Book Information - "+item.Name+"  -  " + item.Id);
            }

            Book book = new Book();
            book.Id = 738127;
            book.Name = "Programming Heroes";
            Book.AuthorizedBy = "Admin";
            Book.GetBooks();

            /*new Student();
            new Student("Sabbir");
            new Student("Sabbir", 32);
            new Student("Ashraful Islam","Emon","Sabbir", "Saddam");*/
        }
    }

    public interface IWeapon
    {
        void Fire();
    }

    public abstract class Weapon
    {
        protected int DamagePower;
        protected string WeaponName;
        public abstract void Fire();
    }

    public class Missile : IWeapon
    {
        protected int DamagePower;
        protected string WeaponName;
        public Missile()
        {
            DamagePower = 1000;
            WeaponName = "Missile 62";
        }
        public void Fire()
        {
            Console.WriteLine("{0} Fired with Damage Amount {1}",WeaponName,DamagePower);
        }
    }

    public class MachineGun : IWeapon
    {
        protected int DamagePower;
        protected string WeaponName;
        public MachineGun()
        {
            DamagePower = 200;
            WeaponName = "Machine Gun - 22";
        }
        public void Fire()
        {
            Console.WriteLine("{0} Fired with Damage Amount {1}", WeaponName, DamagePower);
        }
    }

}
