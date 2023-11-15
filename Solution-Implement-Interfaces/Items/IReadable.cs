namespace Solution.Items
{
    internal interface IReadable
    {
        public void Read();
        public void MarkAsUnread();
        public bool IsRead { get; set; }
    }
}
