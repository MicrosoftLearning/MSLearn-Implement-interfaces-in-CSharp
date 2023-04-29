namespace M01_Implement_Interfaces.Items
{
    public enum WeaponClass
    {
        Sword,
        Wand,
        Axe
    }

    internal class Weapon : Item
    {
        private readonly Random random = new();
        private readonly WeaponClass weaponClass;
        private int attack = 0;
        private int magic = 0;
        private int weight = 0;
        private int mana = 0;

        public int Attack => attack;
        public int Magic => magic;
        public int Mana => mana;
        public int Weight => weight;

        public Weapon(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image)
        {
            string type = resourceName[..resourceName.IndexOf("_")];
            
            if (WeaponClass.TryParse(type, true, out weaponClass))
                AssignStats();
        }

        private void AssignStats()
        {
            switch (weaponClass)
            {
                case WeaponClass.Sword:
                    attack = 50 + random.Next(0, 10);
                    weight = 10 + random.Next(0, 10);
                    break;
                case WeaponClass.Wand:
                    attack = 5 + random.Next(0, 5);
                    magic = 50 + random.Next(0, 10);
                    weight = 2 + random.Next(0, 7);
                    mana = 17 + random.Next(0, 10);
                    break;
                case WeaponClass.Axe:
                    attack = 80 + random.Next(0, 20);
                    weight = 20 + random.Next(0, 10);
                    break;
            }
        }

    }
}
