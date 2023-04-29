namespace Solution.Items
{
    internal interface IEquipable
    {
        public void Equip();
        public void Unequip();
        public bool Equipped { get; set; }
    }
}
