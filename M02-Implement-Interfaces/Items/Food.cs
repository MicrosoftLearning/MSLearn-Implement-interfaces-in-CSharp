using Shared.Properties;

namespace M02_Implement_Interfaces.Items
{
    internal class Food : Item, IConsumable
    {
        private readonly Random random = new();
        private readonly bool ingredient = false;

        public Food(string resouceName, Bitmap image) : base(ParseResourceName(resouceName), image)
        {
            ingredient = resouceName.StartsWith("ingredient");
            Consumed = false;
        }

        public Food(string name, Bitmap image, bool ingredient) : base(name, image)
        {
            this.ingredient = ingredient;
            Consumed = false;
        }

        public bool Consumed { get; set; }

        public void Consume()
        {
            Player.hp += ingredient ? 5 : 10;
            Consumed = true;
        }

        public bool IsIngredient()
        {
            return ingredient;
        }

        private Food CreateRandomFood()
        {

            int combination = random.Next(1, 6);
            string name;
            Bitmap image;
            switch (combination)
            {
                case 1:
                    name = "lasagna";
                    image = Resources.food_combined_1;
                    break;
                case 2:
                    name = "soup";
                    image = Resources.food_combined_2;
                    break;
                case 3:
                    name = "burger";
                    image = Resources.food_combined_3;
                    break;
                case 4:
                    name = "trifle";
                    image = Resources.food_combined_4;
                    break;
                default:
                    name = "pastry";
                    image = Resources.food_combined_5;
                    break;
            }
            return new Food(name, image, false);
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
