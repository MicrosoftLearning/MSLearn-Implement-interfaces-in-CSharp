namespace M02_Implement_Interfaces.Items
{
    internal interface IConsumable
    {
        public void Consume();

        public bool Consumed { get; set; }
    }
}
