using Shared;
using Shared.Properties;
using Solution.Items;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace Solution
{
    public partial class Inventory : Form
    {
        private Model controller;
        private List<Item> inventory;
        private ImageList imageList = new();

        public Inventory()
        {
            InitializeComponent();
            inventory = FillInventory();
            controller = new Model(inventory);
            UpdateInventory(inventory);
            UpdateStats();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Item item = (Item)listView1.SelectedItems[0].Tag;
                controller.SetSelectedItems(new List<Item>() { item });
            }
            else if (listView1.SelectedItems.Count == 2)
            {
                Item item1 = (Item)listView1.SelectedItems[0].Tag;
                Item item2 = (Item)listView1.SelectedItems[1].Tag;
                controller.SetSelectedItems(new List<Item>() { item1, item2 });
            }
            selectButton.Text = controller.GetItemAction();
            UpdateStats();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetAllItems());
        }

        private void equipableButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetEquipables());
        }

        private void equippedButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetAllEquipped());
        }

        private void consumableButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetConsumables());
        }

        private void consumedButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetAllConsumed());
        }

        private void craftButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetCraftables());
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Item? craftedItem = controller.DoItemAction();
            UpdateStats();

            if (craftedItem != null)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                // Prevent the rune from being overwritten in a craft operation
                if (selectedItem.Tag is Material rune && rune.GetRuneType() != RuneType.None)
                {
                    selectedItem = listView1.SelectedItems[1];
                }

                listView1.LargeImageList.Images.Add(craftedItem.Image);
                selectedItem.Text = craftedItem.Name;
                selectedItem.Name = craftedItem.Name;
                selectedItem.Tag = craftedItem;
                selectedItem.ImageIndex = listView1.LargeImageList.Images.Count - 1;
                controller.SetSelectedItems(new List<Item>() { craftedItem });
            }
            selectButton.Text = controller.GetItemAction();
        }

        private void UpdateStats()
        {
            SetNormalStat(hpValue, Player.hp);
            SetNormalStat(attackValue, Player.attack);
            SetNormalStat(defenseValue, Player.defense);
            SetNormalStat(magicValue, Player.magic);
            SetNormalStat(speedValue, Player.GetSpeed());
            SetNormalStat(loadValue, Player.load);
            SetNormalStat(manaValue, Player.mana);

            if (controller.ShowComparableStats())
            {
                Item item1 = (Item)listView1.SelectedItems[0].Tag;
                Item item2 = (Item)listView1.SelectedItems[1].Tag;

                if (item1 is Weapon weapon1 && item2 is Weapon weapon2)
                {
                    SetStatComparison(attackValue, weapon1.Attack, weapon2.Attack);
                    SetStatComparison(magicValue, weapon1.Magic, weapon2.Magic);
                    SetStatComparison(speedValue, Player.GetSpeed(weapon1.Weight, true), Player.GetSpeed(weapon2.Weight, true), true);
                    SetStatComparison(loadValue, weapon1.Weight, weapon2.Weight, true);
                    SetStatComparison(manaValue, weapon1.Mana, weapon2.Mana);
                }
                else if (item1 is Armor armor1 && item2 is Armor armor2)
                {
                    SetStatComparison(defenseValue, armor1.Defense, armor2.Defense);
                    SetStatComparison(speedValue, Player.GetSpeed(armor1.Weight, true), Player.GetSpeed(armor2.Weight, true), true);
                    SetStatComparison(loadValue, armor1.Weight, armor2.Weight, true);
                }
            }
        }

        private List<Item> FillInventory()
        {
            inventory = new List<Item>();
            imageList.ImageSize = new Size(200, 200);
            listView1.LargeImageList = imageList;

            ResourceManager rm = Resources.ResourceManager;
            ResourceSet rs = rm.GetResourceSet(new CultureInfo("en-US"), true, true);

            if (rs != null)
            {
                var imageEntries =
                  from entry in rs.Cast<DictionaryEntry>()
                  where entry.Value is Bitmap
                  select entry;

                Dictionary<string, Type> itemTypes = new() {
                    { "weapons", typeof(Weapon) },
                    { "armor", typeof(Armor) },
                    { "potion", typeof(Potion) },
                    { "food", typeof(Food) },
                    { "materials", typeof(Material) }
                };

                foreach (DictionaryEntry entry in imageEntries)
                {
                    string name = (string)entry.Key;
                    if (name.Contains("combine"))
                    {
                        continue;
                    }
                    if (entry.Value is Bitmap img)
                    {
                        Item? item = null;

                        foreach (string key in itemTypes.Keys)
                        {
                            if (name.StartsWith(key))
                            {
                                name = name.Substring(key.Length + 1);
                                item = (Item?)Activator.CreateInstance(itemTypes[key], name, img);
                            }
                        }
                        if (item != null)
                        {
                            inventory.Add(item);
                        }
                    }
                }
            }

            inventory.Sort();
            return inventory;
        }

        private void SetStatComparison(Label label, int stat1, int stat2, bool inverse = false)
        {
            if (stat1 > stat2)
                label.ForeColor = inverse ? Color.Green : Color.Red;
            else if (stat2 > stat1)
                label.ForeColor = inverse ? Color.Red : Color.Green;
            else
                label.ForeColor = Color.Black;

            label.Text = $"{stat1} -> {stat2}";
        }

        private void SetNormalStat(Label label, int stat)
        {
            label.ForeColor = Color.Black;
            label.Text = $"{stat}";
        }

        private void UpdateInventory(List<Item> items)
        {
            imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            listView1.Clear();
            listView1.LargeImageList = imageList;

            foreach (Item item in items)
            {
                imageList.Images.Add(item.Image);
                listView1.Items.Add(new ListViewItem(item.Name, imageList.Images.Count - 1) { Tag = item });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}