using CSharp092023;
using System.Reflection;

List<string> listAnimals = new()
{
    "WOUF",
    "MIAOU",
    "Quoi de neuf"
};

Humain monHumain = new Humain("BDC", "Thomas", new DateTime(1972,12,31), "Blond");

Console.WriteLine(monHumain.GetAge());

if (monHumain.canHavePermis(53))
{
    Console.WriteLine("Vous pouvez passer le permis");
}
else
{
    Console.WriteLine("Impossible de passer le permis, soyez patients.");
}

SayHelloToUser();

//Début du jeu
do
{
    DoTourDeJeu();

} while (GetReponsePlayAgain());


#region Methods
void SayHelloToUser()
{
    Console.WriteLine("Bienvenue dans notre jeu RoulettePerdante");

    Console.WriteLine("Voici les éléments que vous pouvez voir");

    foreach (var item in listAnimals)
    {
        Console.WriteLine(item);
    }

}

void DoTourDeJeu()
{
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Lancement de la roulette ...");

    string firstAnimal = Methods.GetRandomItemInTab(listAnimals);
    string secondAnimal = Methods.GetRandomItemInTab(listAnimals);
    string thirdAnimal = Methods.GetRandomItemInTab(listAnimals);

    Console.WriteLine(firstAnimal + " " + secondAnimal + " " + thirdAnimal);

    if (firstAnimal == secondAnimal && secondAnimal == thirdAnimal)
    {
        Console.WriteLine("Vous avez gagné");
    }
    else
    {
        Console.WriteLine("Vous avez perdu");
    }
}

bool GetReponsePlayAgain()
{
    Console.WriteLine("Voulez-vous re-perdre à la roulette ? O/N");
    string reponse = Console.ReadLine();
    if(reponse == "O" || reponse == "o" || reponse == "oui")
    {
        return true;
    }
    else
    {
        return false;
    }
}
#endregion









Voiture maVoiture = new()
{
    Immatriculation = "EX-609-GM",
    Marque = "Renault",
    Modele = "Clio",
    Couleur = "Rouge",
    NbChevaux = 75,
};

var Mavoiture2 = maVoiture;

Mavoiture2.Immatriculation = "coucou";

Console.WriteLine(maVoiture.Immatriculation);


