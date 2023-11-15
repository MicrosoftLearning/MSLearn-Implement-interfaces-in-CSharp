namespace M03_Implement_Interfaces.Items
{
    internal interface ISynergyEffect
    {
        public bool HasSynergyWith(Item item);

        public bool HasSynergyWith(List<Item> items);

        public void ActivateSynergy(bool active);

        public bool SynergyActive();

        public SynergyBonus GetSynergyBonus();
    }
}
