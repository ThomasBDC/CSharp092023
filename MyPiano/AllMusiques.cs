using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPiano
{
    public static class AllMusiques
    {
        public static List<MusiquePartition> allMusiques = new List<MusiquePartition>() 
        {
            new MusiquePartition("Für Elise", "Ludwig van Beethoven", "EEDDDEEEDDDEEEDDDEEDDDEEDDDEEEDDDEEEDDDEEDDDEEEDDDEEEDDDEEEDDDEEEDDDEE"),
            new MusiquePartition("Canon in D", "Johann Pachelbel", "AAAAGGGGFFFFEEEEEDDDDGGGGFFFFEEEEEDDDD"),
            new MusiquePartition("Moonlight Sonata", "Ludwig van Beethoven", "CCCDDDEEECCCDDDEEECCCDDDEEECCCDDDEEE"),
            new MusiquePartition("Ode to Joy", "Ludwig van Beethoven", "GGGFFFEEEEDDDGGGFFFEEEEDDDGGGFFFEEEEDDD"),
            new MusiquePartition("Clair de Lune", "Claude Debussy", "EEEEDDDDCCCBBBAAA")
        };
    }
}
