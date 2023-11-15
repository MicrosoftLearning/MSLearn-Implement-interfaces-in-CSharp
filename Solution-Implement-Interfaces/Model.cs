using Solution.Items;

namespace Solution
{
    internal class Model
    {
        private const string none = "Select";
        private const string craft = "Craft";
        private const string equip = "Equip";
        private const string unequip = "Unequip";
        private const string consume = "Consume";
        private const string read = "Read";
        private const string markAsUnread = "Mark as Unread";
        private readonly List<Item> inventory;
        private List<Item> selectedItems;

        public static bool ScrollsImplemented = true;

        public Model(List<Item> inventory)
        {
            this.inventory = inventory;
            selectedItems = new List<Item>();
        }

        public string GetItemAction()
        {
            ICombinable? material = selectedItems[0] as ICombinable;
            if (selectedItems.Count == 2 && material != null)
            {
                if (material.CanCombine(selectedItems[1]))
                    return craft;
            }
            else if (selectedItems[0] is IEquipable item)
            {
                var item2 = selectedItems[0] as IEquipable;
                return item.Equipped ? unequip : equip;
            }
            else if (selectedItems[0] is IConsumable)
            {
                return consume;
            }
            else if (selectedItems[0] is IReadable text)
            {
                return text.IsRead ? read : markAsUnread;
            }
            return none;
        }

        public Item? DoItemAction()
        {
            if (selectedItems.Count == 1)
            {
                if (selectedItems[0] is IEquipable equipable)
                {
                    if (equipable.Equipped)
                        equipable.Unequip();
                    else
                        equipable.Equip();
                }
                else if (selectedItems[0] is IConsumable consumable)
                {
                    consumable.Consume();
                }
                else if (selectedItems[0] is IReadable text)
                {
                    if (text.IsRead)
                        text.MarkAsUnread();
                    else
                        text.Read();
                }    
            }
            else if (selectedItems.Count == 2 && selectedItems[0] is ICombinable material)
            {
                Item? newItem = material.Combine(selectedItems[1]);

                if (newItem != null)
                    inventory.Add(newItem);

                return newItem;
            }
            return null;
        }

        public List<Item> GetReadables()
        {
            List<Item> items = new();
            foreach (Item item in inventory)
            {
                if (item is IReadable)
                    items.Add(item);
            }
            return items;
        }

        public List<Item> GetEquipables()
        {
            List<Item> items = new();
            foreach (Item item in inventory)
            {
                if (item is IEquipable)
                    items.Add(item);
            }
            return items;
        }

        public List<Item> GetAllEquipped()
        {
            List<Item> items = new();
            foreach (Item item in inventory)
            {
                if (item is IEquipable equipable && equipable.Equipped)
                    items.Add(item);
            }
            return items;
        }

        public List<Item> GetConsumables()
        {
            List<Item> items = new List<Item>();
            foreach (Item item in inventory)
            {
                if (item is IConsumable)
                    items.Add(item);
            }
            return items;
        }

        public List<Item> GetAllConsumed()
        {
            List<Item> items = new List<Item>();
            foreach (Item item in inventory)
            {
                if (item is IConsumable food && food.Consumed)
                    items.Add(item);
            }
            return items;
        }

        public List<Item> GetCraftables()
        {
            List<Item> items = new List<Item>();
            foreach (Item item in inventory)
            {
                if (item is ICombinable)
                    items.Add(item);
            }
            return items;
        }

        public bool ShowComparableStats()
        {
            if (selectedItems.Count > 1)
            {
                //if (selectedItems[0].Comparable(selectedItems[1]))
                return true;
            }
            return false;
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
