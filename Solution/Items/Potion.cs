namespace Solution.Items
{
    public enum PotionModifier
    {
        Max,
        Strong,
        Medium,
        Weak
    }

    public enum PotionType
    {
        Health,
        Strength,
        Defense,
        Magic,
        Mana,
        Speed
    }

    internal class Potion : Item, IConsumable
    {
        private PotionModifier modifier;

        public Potion(string name, Bitmap image) : base(ParseName(name), image) 
        {
            string strength = name.Substring(0, name.IndexOf("_"));
            PotionModifier.TryParse(strength, true, out modifier);
            Consumed = false;
        }

        public Potion(string name, Bitmap image, PotionModifier modifier) 
            : base(FormatName(name,modifier), image) 
        {
            this.modifier = modifier;
            Consumed = false;
        }

        public bool Consumed { get; set; }

        public void Consume()
        {
            int buff = modifier == PotionModifier.Max ? 100 :
                        modifier == PotionModifier.Strong ? 60 :
                        modifier == PotionModifier.Medium ? 35 :
                        10;

            if (Name.Contains("mana"))
            {
                Player.mana += buff;
            } 
            else if (Name.Contains("health"))
            {
                Player.hp += buff;
            }
            else if (Name.Contains("strength"))
            {
                Player.attack += buff;
            }
            else if (Name.Contains("defense"))
            {
                Player.defense += buff;
            }
            else if (Name.Contains("magic"))
            {
                Player.magic += buff;
            }

            Consumed = true;
        }

        private static string FormatName(string name, PotionModifier modifier)
        {
            string append = " potion";
            switch (modifier)
            {
                case PotionModifier.Max:
                    append = " max" + append;
                    break;
                case PotionModifier.Strong:
                    append = "++" + append;
                    break;
                case PotionModifier.Medium:
                    append = "+" + append;
                    break;

            }
            return name + append;
        }

        private static string ParseName(string name)
        {
            string type = name.Substring(0, name.IndexOf("_"));
            name = name.Substring(name.IndexOf("_")).Replace("_", " ");
            string append = " potion";
            PotionModifier.TryParse(type, true, out PotionModifier modifier);
            switch (modifier)
            { 
                case PotionModifier.Max:
                    append = "max" + append;
                    break;
                case PotionModifier.Strong:
                    append = "++" + append;
                    break;
                case PotionModifier.Medium:
                    append = "+" + append;
                    break;

            }
            return name + append;
        }

        protected override int InternalSortOrder { get { return 4; } }
    }
}
