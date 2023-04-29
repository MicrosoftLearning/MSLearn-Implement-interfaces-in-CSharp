namespace M02_Implement_Interfaces.Items
{
    internal interface IEquipable
    {
        public void Equip();
        public void Unequip();
        public bool Equipped { get; set; }
    }
}
