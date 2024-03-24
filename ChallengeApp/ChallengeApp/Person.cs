
namespace ChallengeApp
{
    public abstract class Person 
    {
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name {get; private set;}
        public string Surname {get; private set;}
        public char Sex {get; private set;}
    }
}


// Składowe interfejsu nie mogą być oznaczone atrybutem dostępu 
// Interfejs umożliwia jedynie deklarację składowych, bez implementacji 
// Interfejs może dziedziczyć jedynie po innych interfejsach
// Klasa abstrakcyjna może dziedziczyć po klasach abstrakcyjnych, interfejsach a nawet zwykłych klasach  
// Jeśli do interfejsu zostanie dodana nowa metoda trzeba prześledzić wszystkie klasy implemetujące dany interface i dodać implementację nowej metody 
// Interface nie może mieć konstruktora 
// Jeśli w klasie nie ma logiki zróbmy interface a nie klasę abstrakcyjną 