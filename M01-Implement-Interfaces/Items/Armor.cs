namespace M01_Implement_Interfaces.Items
{
    public enum ArmorType
    {
        Shield,
        Breastplate,
        None
    }

    internal class Armor : Item
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
    }
}
