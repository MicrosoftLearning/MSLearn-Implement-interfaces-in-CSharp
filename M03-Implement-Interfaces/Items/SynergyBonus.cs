namespace M03_Implement_Interfaces.Items
{
    public class SynergyBonus
    {
        public string Stat {  get; }
        public int Bonus { get; }

        public SynergyBonus(string stat, int bonus) 
        {
            Stat = stat;
            Bonus = bonus;
        }
    }
}
