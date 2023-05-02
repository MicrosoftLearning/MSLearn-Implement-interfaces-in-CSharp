using Shared.Properties;

namespace Solution.Items
{
    public enum WeaponClass
    {
        Sword,
        Hammer,
        Wand,
        Axe
    }

    internal class Weapon : Item, IEquipable, ICombinable
    {
        private readonly Random random = new();
        private readonly WeaponClass weaponClass;
        private int attack = 0;
        private int magic = 0;
        private int weight = 0;
        private int mana = 0;

        public Weapon(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image)
        {
            string type = resourceName[..resourceName.IndexOf("_")];
            
            if (WeaponClass.TryParse(type, true, out weaponClass))
                AssignStats();
        }

        public Weapon(string name, Bitmap image, WeaponClass weaponClass) : base(name, image)
        {
            this.weaponClass = weaponClass;
            AssignStats();
        }
        
        public bool CanCombine(Item item)
        {
            if (item  == null) 
                return false;

            if (item is Material material)
                return material.GetMaterialType() == MaterialType.Rune;

            return false;
        }

        public Item? Combine(Item item)
        {
            if (CanCombine(item))
            {
                return CreateRandomWeapon((Material) item);
            }
            return null;
        }

        public bool Equipped { get; set; }

        public void Equip()
        {
            Player.attack += attack;
            Player.magic += magic;
            Player.load += weight;
            Player.mana += mana;
            Equipped = true;
        }

        public void Unequip()
        {
            Player.attack -= attack;
            Player.magic -= magic;
            Player.load -= weight;
            Player.mana -= mana;
            Equipped = false;
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
                case WeaponClass.Hammer:
                    attack = 115 + random.Next(0, 30);
                    weight = 35 + random.Next(0, 10);
                    break;
            }
        }

        public int Attack => attack;
        public int Magic => magic;
        public int Mana => mana;
        public int Weight => weight;

        private Weapon CreateRandomWeapon(Material item)
        {
            int combination = random.Next(1, 6);
            string name = item.GetRuneType() + " Hammer";
            Bitmap image;
            switch (combination)
            {
                case 1:
                    image = Resources.weapons_axe_helm_splitter;
                    break;
                case 2:
                    image = Resources.weapons_axe_gygantallax;
                    break;
                case 3:
                    image = Resources.weapons_axe_stone_winder;
                    break;
                default:
                    image = Resources.weapons_sword_death_s_edge;
                    break;
            }
            return new Weapon(name, image, WeaponClass.Hammer);
        }

        protected override int InternalSortOrder { get { return 2; } }
    }
}
