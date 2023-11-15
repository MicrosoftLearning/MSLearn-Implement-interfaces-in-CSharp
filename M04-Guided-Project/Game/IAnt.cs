using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M04_Guided_Project.Game
{
    public interface IAnt
    {
        public int I { get; set; }
        public int J { get; set; }
        public AntDirection Direction { get; set; }
        public byte Act(byte oldValue);
        public void RotateCW();
        public void RotateCCW();
    }
}
