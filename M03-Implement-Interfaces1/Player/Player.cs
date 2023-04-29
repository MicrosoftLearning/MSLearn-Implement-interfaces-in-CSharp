namespace M03_Implement_Interfaces
{
    internal class Player
    {
        public static int hp = 20;
        public static int attack = 10;
        public static int defense = 10;
        public static int magic = 10;
        public static int speed = 40;
        public static int load = 0;
        public static int mana = 20;

        public static int GetSpeed()
        {
            return speed - load / 3;
        }

        public static int GetSpeed(int newLoad, bool useBaseStat = false)
        {
            if (useBaseStat) return 40 - newLoad / 3;
            return speed - newLoad / 3;
        }
    }
}
