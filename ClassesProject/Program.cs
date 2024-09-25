namespace ClassesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготова к бою");

            Console.WriteLine("Введите имя бойца");
            string name = Console.ReadLine();

             Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            int.TryParse(Console.ReadLine(), out int health);

            Console.WriteLine("Введите значение брони шлема от 0, до 1:)");
            float.TryParse(Console.ReadLine(), out float helmArmor);
            var Helm = new Helm(helmArmor);

            Console.WriteLine("Введите значение брони кирасы от 0, до 1:");
            float.TryParse(Console.ReadLine(), out float shellArmor);
            var Shell = new Shell(shellArmor);

            Console.WriteLine("Введите значение брони сапог от 0, до 1:)");
            float.TryParse(Console.ReadLine(), out float bootsArrmor);
            var Boots = new Boots(bootsArrmor);


            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            float. TryParse (Console.ReadLine(), out float minDamage);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            float.TryParse(Console.ReadLine(), out float maxDamage);

            
            var weapon = new Weapon("Kalasnikov", minDamage,maxDamage);
            var unit = new Unit (name, health);
            
            unit.EquiqWeapon(weapon);
            unit.EquipHelm (Helm);
            unit.EquipShell (Shell);
            unit.EquipBoots (Boots);

            Console.WriteLine("Общий показатель брони равен :{0}", unit.Armor);
            Console.WriteLine("“Фактическое значение здоровья равно: :{0}", unit.RealHealth);

        }
    }
}
