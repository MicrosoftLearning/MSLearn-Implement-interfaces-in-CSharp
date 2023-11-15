namespace Solution.Items
{
    internal class Scroll : Item, IReadable
    {
        public bool IsRead {get; set;}

        public Scroll(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image) 
        { 
            // Nothing to do for now
        }

        public void Read()
        {
            IsRead = true;
        }

        public void MarkAsUnread()
        {
            IsRead = false;
        }

        protected override int InternalSortOrder { get { return 5; } }
    }
}
