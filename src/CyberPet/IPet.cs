using System;
using System.Collections.Generic;
using System.Text;

namespace CyberPet
{
    public interface IPet
    {
        string Name { get; set; }
        int energy { get; set; }
        int hunger { get; set; }
        int happy { get; set; }

        void Play();
        void Feed();
        void Sleep();

    }
}
