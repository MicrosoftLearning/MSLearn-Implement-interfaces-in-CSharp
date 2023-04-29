namespace M01_Implement_Interfaces.Items
{
    internal abstract class Item
    {
        public Item(string name, Bitmap image)
        {
            this.Name = name;
            this.Image = image;
        }

        public string Name { get; }

        public Bitmap Image { get; }

        public static string ParseResourceName(string name)
        {
            return name[name.IndexOf("_")..].Replace("_s ", "'s ").Replace("_", " ").Trim();
        }
    }
}
