namespace Solution.Items
{
    internal interface IReadable
    {
        public void Read();
        public void MarkAsNew();
        public bool IsRead { get; set; }
    }
}
