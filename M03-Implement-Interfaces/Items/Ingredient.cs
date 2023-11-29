namespace M03_Implement_Interfaces.Items
{
    internal class Ingredient : Item
    {
        public Ingredient(string resouceName, Bitmap image) : base(ParseResourceName(resouceName), image)
        {
            Random random = new();
            // healthBoost = 5 + random.Next(0, 5);
        }

        private static new string ParseResourceName(string name)
        {
            if (name.StartsWith("ingredient"))
                name = name[name.IndexOf("_")..].Trim();

            return name.Replace("_", " ").Trim();
        }

        protected override int InternalSortOrder { get { return 3; } }
    }
}
