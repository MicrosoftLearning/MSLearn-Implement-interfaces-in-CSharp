using M02_Implement_Interfaces.Items;

namespace Solution
{
    internal class Model
    {
        private const string none = "Select";
        private const string craft = "Craft";
        private const string equip = "Equip";
        private const string unequip = "Unequip";
        private const string consume = "Consume";
        private readonly List<Item> inventory;
        private List<Item> selectedItems;

        public Model(List<Item> inventory)
        {
            this.inventory = inventory;
            selectedItems = new List<Item>();
        }

        public string GetItemAction()
        {
            if (selectedItems.Count == 2)
            {
                // return combine
            }
            else if (selectedItems.Count == 1)
            {
                if (selectedItems[0] is IEquipable)
                    return equip;

                else if (selectedItems[0] is IConsumable)
                    return consume;
            }
            return none;
        }

        public Item? DoItemAction()
        {
            if (selectedItems.Count == 1)
            {
                if (selectedItems[0] is IEquipable)
                {
                    // equip or unequip
                }
                else if (selectedItems[0] is IConsumable)
                {
                    // consume
                }
            }
            else if (selectedItems.Count == 2)
            {
                // combine
            }
            return null;
        }

        public List<Item> GetEquipables()
        {
            List<Item> items = new();

            foreach (Item item in inventory)
                if (item is IEquipable)
                    items.Add(item);
            
            return items;
        }

        public List<Item> GetConsumables()
        {
            List<Item> items = new List<Item>();

            foreach (Item item in inventory)
                if (item is IConsumable)
                    items.Add(item);

            return items;
        }

        public List<Item> GetCraftables()
        {
            return inventory;
        }

        public void SetSelectedItems(List<Item> selectedItems)
        {
            this.selectedItems = selectedItems;
        }

        public List<Item> GetAllItems()
        {
            inventory.Sort();
            return inventory;
        }

    }

}
