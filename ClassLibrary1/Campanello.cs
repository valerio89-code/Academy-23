using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void RingSound(string nomeCampanello);
    public class Campanello
    {
        public event RingSound RingPressed;
        public string Name { get; set; } = "Casa dei ladri";

        public void OnRingPressed()
        {
            RingPressed?.Invoke(Name);
        }
    }
}
