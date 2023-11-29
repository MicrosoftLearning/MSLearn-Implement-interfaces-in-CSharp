namespace M03_Implement_Interfaces.Items
{
    public enum ArmorType
    {
        Shield,
        Breastplate,
        None
    }

    internal class Armor : Item, IEquipable, IComparable<Armor>
    {
        public readonly ArmorType armorType;
        private int defense = 0;
        private int weight = 0;

        public Armor(string name, Bitmap image) : base(ParseResourceName(name), image)
        {
            string type = name.Substring(0, name.IndexOf("_"));

            if (ArmorType.TryParse(type, true, out armorType))
                AssignStats();
            else
                armorType = ArmorType.None;
        }

        private void AssignStats()
        {
            if (armorType == ArmorType.Shield)
            {
                weight = 30;
                defense = 80;
            }
            else if (armorType == ArmorType.Breastplate)
            {
                weight = 10;
                defense = 15;
            }

            Random random = new();
            weight += random.Next(1, 10);
            defense += random.Next(1, 10);
        }

        public int Defense => defense;
        public int Weight => weight;

        public bool Equipped { get; set; }

        public void Equip()
        {
            Player.defense += defense;
            Player.load += weight;
            Equipped = true;
        }

        public void Unequip()
        {
            Player.defense -= defense;
            Player.load -= weight;
            Equipped = false;
        }

        public int CompareTo(Armor? armor)
        {
            if (armor != null)
                return defense.CompareTo(armor.defense);
            return 0;
        }

        protected override int InternalSortOrder { get { return 1; } }
    }
}
