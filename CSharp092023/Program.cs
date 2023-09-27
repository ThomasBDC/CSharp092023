using CSharp092023;

List<string> listAnimals = new()
{
    "WOUF",
    "MIAOU",
    "Quoi de neuf"
};

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