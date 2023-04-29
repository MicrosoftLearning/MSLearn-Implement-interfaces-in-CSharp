using global::Solution;
using M01_Implement_Interfaces.Items;
using Shared.Properties;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace M01_Implement_Interfaces
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            UpdateStats();
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
                            imageList.Images.Add(img);
                            listView1.Items.Add(new ListViewItem(item.Name, imageList.Images.Count - 1) { Tag = item });
                        }
                    }
                }
            }

            return inventory;
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

        private void equipButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetEquipables());
        }

        private void consumeButton_Click(object sender, EventArgs e)
        {
            UpdateInventory(controller.GetConsumables());
        }
    }
}