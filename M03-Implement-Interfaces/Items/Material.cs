using Shared.Properties;

namespace M03_Implement_Interfaces.Items
{
    internal enum MaterialType
    {
        Herb,
        Rune,
        Container
    }

    internal enum RuneType
    {
        Air,
        Fire,
        Water,
        Earth,
        Spirit,
        None
    }

    internal class Material : Item, ICombinable
    {
        private readonly MaterialType materialType;
        private readonly RuneType runeType;

        public Material(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image)
        {
            string type = resourceName[..resourceName.IndexOf("_")];
            MaterialType.TryParse(type, true, out materialType);
            runeType = ParseRuneType();
        }

        public Material(string name, Bitmap image, MaterialType materialType) : base(name, image)
        {
            this.materialType = materialType;
            runeType = ParseRuneType();
        }

        public Item? Combine(Item item)
        {
            if (CreatesPotion(item))
                return CreateRandomPotion();

            else if (CreatesWeapon(item))
                return ((Weapon)item).Combine(this);

            return null;
        }

        public bool CanCombine(Item item)
        {
            return CreatesPotion(item) || CreatesWeapon(item);
        }

        public MaterialType GetMaterialType()
        {
            return materialType;
        }

        public RuneType GetRuneType()
        {
            return runeType;
        }

        private bool CreatesPotion(Item item)
        {
            if (item == null)
                return false;

            if (item is Material other)
            {
                switch (materialType)
                {
                    case MaterialType.Rune:
                        return false;

                    case MaterialType.Container:
                        return other.materialType == MaterialType.Herb;

                    case MaterialType.Herb:
                        return other.materialType == MaterialType.Container
                            || other.materialType == MaterialType.Herb;

                }
            }

            return false;
        }

        private Potion CreateRandomPotion()
        {
            Random random = new();
            string[] potionTypes = Enum.GetNames(typeof(PotionType));
            int index = random.Next(0, potionTypes.Length);

            return new Potion(potionTypes[index].ToLower(), Resources.potion_weak_mana, PotionModifier.Strong);
        }

        private bool CreatesWeapon(Item item)
        {
            if (item == null)
                return false;

            return item is Weapon && materialType == MaterialType.Rune;
        }

        private RuneType ParseRuneType()
        {
            if (Name.Contains("earth"))
                return RuneType.Earth;
            else if (Name.Contains("air"))
                return RuneType.Air;
            else if (Name.Contains("water"))
                return RuneType.Water;
            else if (Name.Contains("fire"))
                return RuneType.Fire;
            else if (Name.Contains("spirit") || Name.Contains("mystic"))
                return RuneType.Spirit;
            else
                return RuneType.None;
        }

        protected override int InternalSortOrder
        {
            get
            {
                return materialType == MaterialType.Rune ? 5 :
                        materialType == MaterialType.Herb ? 6 : 7;
            }
        }
    }
}
