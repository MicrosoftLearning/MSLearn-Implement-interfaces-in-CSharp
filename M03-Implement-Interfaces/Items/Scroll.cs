namespace M03_Implement_Interfaces.Items
{
    internal class Scroll : Item
    {
        public Scroll(string resourceName, Bitmap image) : base(ParseResourceName(resourceName), image) 
        { 
            // Nothing to do for now
        }

        protected override int InternalSortOrder { get { return 5; } }
    }
}
