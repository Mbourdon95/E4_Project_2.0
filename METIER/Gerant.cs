using System;

namespace METIER
{
    public class Gerant
    {
        private string nom;
        private string prenom;
        private int age;
        private int budget;
        private string password;
        private state State;
        private int id;

        public Gerant(string nom, string prenom, int age, string pssword, state _state,int _bud, int _id )
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.password = pssword;
            this.State = _state;
            this.budget = _bud;
            this.id = _id;
        }

        public int Age { get => age; set => age = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public state State1 { get => State; set => State = value; }
        public int Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public int Budget { get => budget; set => budget = value; }

        /// <summary>
        /// Fonction qui retourne les informations d'une course sous la forme d'une chaîne de caractère.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Gérant n°{0} : {1} Sous Etat : {2}",
                this.id,
                this.nom + " " + this.prenom,
                this.State
            );
        }
    }
}
