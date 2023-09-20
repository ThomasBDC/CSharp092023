/*
 * 
 * CONDITIONS
 *          -> éxécuter du code, en fonction d'une condition
 * 
SI  (ET OU)
SINON
 
if (&& ||)
else
else if 
 */

/*
 * BOUCLES
 *          -> éxécuter du code plusieurs fois, avec des conditions
 *          
 * TANT QUE (condition)
 * 
 * POUR i de 0 à x
 
 */

Console.WriteLine("Bienvenue dans notre jeu RoulettePerdante");

List<string> list = new()
{
    "WOUF",
    "MIAOU",
    "Quoi de neuf"
};

//On peut le faire sur une liste mais pas sur un tableau
list.Add("Hihan");

Console.WriteLine("Voici les éléments que vous pouvez voir");

foreach (var item in list)
{
    Console.WriteLine(item);
}

string reponse;
do
{
    //Ici on mettra le contenu du jeu
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Lancement de la roulette ...");
    //Trois cases
    // CHIEN, CHAT, LAPIN
    Random rnd = new Random();
    int firstCase = rnd.Next(0, list.Count()); // creates a number between 0 and 2
    int secondCase = rnd.Next(0, list.Count());
    int thirdCase = rnd.Next(0, list.Count());


    Console.WriteLine(list[firstCase] + " " + list[secondCase] + " " + list[thirdCase]);

    if (firstCase == secondCase && secondCase == thirdCase)
    {
        Console.WriteLine("Vous avez gagné");
    }
    else
    {
        Console.WriteLine("Vous avez perdu");
    }

    //Condition pour lancer une nouvelle partie
    Console.WriteLine("Voulez-vous re-perdre à la roulette ? O/N");
    reponse = Console.ReadLine();
} while (reponse == "O" || reponse == "o");
