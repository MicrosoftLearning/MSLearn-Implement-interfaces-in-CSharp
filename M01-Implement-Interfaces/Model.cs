using M01_Implement_Interfaces.Items;

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
            return none;
        }

        public List<Item> GetEquipables()
        {
            return inventory;
        }

        public List<Item> GetConsumables()
        {
            return inventory;
        }

        public List<Item> GetAllItems()
        {
            return inventory;
        }

        public void SetSelectedItems(List<Item> selectedItems)
        {
            this.selectedItems = selectedItems;
        }
    }

}
