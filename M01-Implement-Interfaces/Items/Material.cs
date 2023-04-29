namespace M01_Implement_Interfaces.Items
{
    public enum MaterialType
    {
        Herb,
        Rune,
        Container
    }

    public enum RuneType
    {
        Air,
        Fire,
        Water,
        Earth,
        Spirit,
        None
    }

    internal class Material : Item
    {
        private readonly MaterialType materialType;
        private readonly RuneType runeType;

        public Material(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image)
        {
            string type = resourceName[..resourceName.IndexOf("_")];
            MaterialType.TryParse(type, true, out materialType);
            runeType = ParseRuneType();
        }

        public RuneType GetRuneType()
        {
            return runeType;
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
    }
}
