using Shared.Properties;
using System;

namespace M03_Implement_Interfaces.Items
{
    internal class Food : Item, IConsumable, ICombinable
    {
        private static Random random = new();
        protected int healthBoost;
        private readonly bool ingredient = false;

        public Food(string resouceName, Bitmap image) : base(ParseResourceName(resouceName), image) 
        {
            healthBoost = 10 + random.Next(0, 25);
            ingredient = resouceName.StartsWith("ingredient");
        }

        public bool Consumed { get; set; }

        public void Consume()
        {
            Player.hp += healthBoost;
            Consumed = true;
        }

        public bool CanCombine(Item item)
        {
            if (item != null && this.ingredient)
                return true;

            return false;
        }

        public Item? Combine(Item item)
        {
            if (CanCombine(item))
                return CreateRandomFood();

            return null;
        }

        protected Food CreateRandomFood()
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
                    name = "curry";
                    image = Resources.food_combined_2;
                    break;
                case 3:
                    name = "gyro";
                    image = Resources.food_combined_3;
                    break;
                case 4:
                    name = "lo mein";
                    image = Resources.food_combined_4;
                    break;
                default:
                    name = "cream puff";
                    image = Resources.food_combined_5;
                    break;
            }
            return new Food(name, image);
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
