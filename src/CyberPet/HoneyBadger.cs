using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public class HoneyBadger : IPet
    {
        public string Name { get; set; }
        public int energy { get; set; }
        public int hunger { get; set; }
        public int happy  { get; set; }

        public HoneyBadger()
        {
            energy = 10;
            hunger = 0;
            happy = -10;
        }

        public void Feed()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
