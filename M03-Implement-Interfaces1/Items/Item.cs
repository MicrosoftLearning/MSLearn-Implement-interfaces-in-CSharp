namespace M03_Implement_Interfaces.Items
{
    internal abstract class Item : IComparable<Item>
    {
        public static List<Item> equipped = new();

        public Item(string name, Bitmap image)
        {
            this.Name = name;
            this.Image = image;
        }

        public string Name { get; }

        public Bitmap Image { get; }

        public string Collection { get; set; }

        public static string ParseResourceName(string name)
        {
            return name[name.IndexOf("_")..].Replace("_s_", "'s ").Replace("_", " ").Trim();
        }

        public int CompareTo(Item? item)
        {
            if (item == null)
                return 1;

            if (InternalSortOrder == item.InternalSortOrder)
                return Name.CompareTo(item.Name);

            else
                return InternalSortOrder.CompareTo(item.InternalSortOrder);
        }

        protected abstract int InternalSortOrder { get; }
    }
}
