using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPiano
{
    public class Musique
    {
        public Musique(string titreMusique, string compositeur)
        {
            TitreMusique = titreMusique;
            Compositeur = compositeur;
        }

        public string TitreMusique { get; set; }
        public string Compositeur { get; set; }
    }

    public class MusiquePartition : Musique
    {
        private readonly Dictionary<char, int> _octave = new Dictionary<char, int>()
        {
            {'A', 220},  // La
            {'B', 247},  // Si
            {'C', 262},  // Do
            {'D', 294},  // Ré
            {'E', 330},  // Mi
            {'F', 349},  // Fa
            {'G', 392},  // Sol
        };

        public MusiquePartition(string titreMusique, string compositeur, string partitionLettres) : base(titreMusique, compositeur)
        {
            PartitionLettres = partitionLettres;
        }

        //rrrtytryttr -> Au clair de la lune
        private string PartitionLettres { get; set; }

        public void PlayMusique()
        {
            foreach(var note in PartitionLettres)
            {
                var noteAjouer = _octave[Char.ToUpper(note)];
                Console.Beep(noteAjouer, 250);
            }
        }
    }
}
