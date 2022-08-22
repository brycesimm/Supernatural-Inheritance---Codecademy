using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(s.Announce());
            Pupil p = new Pupil("Mezil-kree");
            Storm ps = p.CastWindStorm();
            Console.WriteLine(ps.Announce());
            Mage m = new Mage("Gul'dan");
            Storm ms = m.CastRainStorm();
            Console.WriteLine(ms.Announce());
            Archmage a = new Archmage("Nielas Aran");
            Storm sa = a.CastRainStorm();
            Storm sa2 = a.CastLightningStorm();
            Console.WriteLine(sa.Announce());
            Console.WriteLine(sa2.Announce());
        }
    }
}
