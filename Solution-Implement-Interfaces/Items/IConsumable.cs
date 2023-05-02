namespace Solution.Items
{
    internal interface IConsumable
    {
        public void Consume();

        public bool Consumed { get; set; }
    }
}
