// See https://aka.ms/new-console-template for more information
using MyPiano;

Console.WriteLine("Voici mes musiques connues !");

int i = 0;
foreach (var musique in AllMusiques.allMusiques)
{
    Console.WriteLine(i +" : "+ musique.TitreMusique + " par "+ musique.Compositeur);
    i++;
}

Console.WriteLine("");
Console.WriteLine("Quelle musique voulez-vous entendre ?");
string MusiqueToListen = Console.ReadLine();
int indexMusique = Convert.ToInt16(MusiqueToListen);

var musiquePlaying = AllMusiques.allMusiques[indexMusique];
Console.WriteLine("Vous écoutez " + musiquePlaying.TitreMusique + " par " + musiquePlaying.Compositeur);
musiquePlaying.PlayMusique();

/** PIANO **/
//while (true)
//{
//    var reponseUtilisateur = Console.ReadKey();
//    var reponseString = reponseUtilisateur.Key.ToString();
//    int noteFrequency = octave[reponseString];
//    Console.Beep(noteFrequency, 250);
//}

