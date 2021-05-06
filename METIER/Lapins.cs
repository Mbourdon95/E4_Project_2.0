using System;

namespace METIER
{
    public class Lapins
    {
        // Donnée Membres 

        private string surnom;
        private int age;
        private int position;
        private static Random aléatoire;
        private int id;
        private int endurance;
        private int vitesse;
        private int chance;
        private int idGerant;
        private int valeur;
        private int gagnantDuneCourse;
        private int offreMinimal;
        private state State;

        public int Chance { get => chance; set => chance = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }
        public int Endurance { get => endurance; set => endurance = value; }
        public int GagnantDuneCourse { get => gagnantDuneCourse; set => gagnantDuneCourse = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public int OffreMinimal { get => offreMinimal; set => offreMinimal = value; }

        // Constructeur.

        static Lapins()
        {
            aléatoire = new Random();
        }
        /// <summary>
        /// Constructeur permettant de générer un nouveau lapin avec des stats aléatoires.
        /// </summary>
        public Lapins(int _id, string _surnom, state _stat, int _idGerant)
        {
            this.position = 0;
            this.id = _id;
            this.surnom = _surnom;
            this.idGerant = _idGerant;
            this.State = _stat;
            this.vitesse = aléatoire.Next(0,10);
            this.endurance = aléatoire.Next(0, 10);
            this.chance = aléatoire.Next(0, 10);
            this.valeur = (this.endurance * 150 + this.vitesse * 200 + this.chance * 50);
            this.offreMinimal = this.valeur / 10;
        }
        /// <summary>
        /// Constructeur permettant de récupérer un lapin d'une bdd avec ses stats prédéfinies.
        /// </summary>
        public Lapins(int _id, string _surnom, state _stat, int _idGerant, int _chance, int _endurance, int _vitesse)
        {
            this.position = 0;
            this.id = _id;
            this.surnom = _surnom;
            this.idGerant = _idGerant;
            this.vitesse = _vitesse;
            this.chance = _chance;
            this.endurance = _endurance;
            this.State = _stat;
            this.valeur = (this.endurance * 150 + this.vitesse * 200 + this.chance * 50);
            this.offreMinimal = this.valeur / 10;
        }
        /// <summary>
        /// Constructeur permettant de récupérer un lapin d'une course spécifique et de savoir s'il est le gagnant de cette course
        /// </summary>
        public Lapins(int _id, string _surnom, state _stat, int _idGerant, int _chance, int _endurance, int _vitesse, int gagnant)
        {
            this.position = 0;
            this.id = _id;
            this.surnom = _surnom;
            this.idGerant = _idGerant;
            this.vitesse = _vitesse;
            this.chance = _chance;
            this.endurance = _endurance;
            this.State = _stat;
            this.gagnantDuneCourse = gagnant;
            this.valeur = (this.endurance * 150 + this.vitesse * 200 + this.chance * 50);
        }
        /// <summary>
        /// Fonction Permettant de récupérer l'état de notre Lapin.
        /// </summary>
        public state GetState()
        {
            return this.State;
        }
        /// <summary>
        /// Fonction Permettant de modifier l'état de notre Lapin.
        /// </summary>
        public void SetState(state _state)
        {
            this.State = _state;
        }

        /// <summary>
        /// Fonction Permettant de récupérer l'état de notre Lapin.
        /// </summary>
        public int GetIdGerant()
        {
            return this.idGerant;
        }
        /// <summary>
        /// Fonction Permettant de modifier l'état de notre Lapin.
        /// </summary>
        public void SetIdGerant(int _idGerant)
        {
            this.idGerant = _idGerant;
        }
        /// <summary>
        /// Fonction qui retourne l'Id d'un Lapin.
        /// </summary>
        public int GetId()
        {
            return this.id;
        }
        /// <summary>
        /// Procédure qui modifie l'Id d'un Lapin.
        /// </summary>
        public void SetId(int _id)
        {
            this.id = _id;
        }
        /// <summary>
        /// Procédure qui modifie l'état d'un Lapin en deleted.
        /// </summary>
        public void Remove()
        {
            this.State = state.deleted;
        }
        /// <summary>
        /// Procédure qui fait avancer de manière aléatoire un Lapin.
        /// </summary>
        public void Avancer()
        {
            if (aléatoire.Next(0, this.chance + 1) % 2 == 1)
            {
                this.position = (this.endurance + this.vitesse) % 11 + this.chance;
            }
            else
            {
                this.position = (this.endurance + this.vitesse) % (this.chance+2);
            }
        }
        /// <summary>
        /// Fonction qui retourne la position d'un Lapin.
        /// </summary>
        public int GetPosition()
        {
            return this.position;
        }
        /// <summary>
        /// Procédure qui modifie la position d'un Lapin.
        /// </summary>
        public void SetPosition(int _position)
        {
            this.position = _position;
        }
        /// <summary>
        /// Fonction qui retourne le surnom d'un Lapin.
        /// </summary>
        public string GetSurnom()
        {
            return this.surnom;
        }
        /// <summary>
        /// Fonction qui modifie le surnom d'un Lapin.
        /// </summary>
        public void SetSurnom(string surnom)
        {
            this.surnom = surnom;
        }
        /// <summary>
        /// Fonction qui retourne l'âge d'un Lapin.
        /// </summary>
        public int GetAge()
        {
            return this.age;
        }
        /// <summary>
        /// Fonction qui modifie l'âge d'un Lapin.
        /// </summary>
        public void SetAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Fonction qui retourne les informations d'une course sous la forme d'une chaîne de caractère.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Lapin n°{0} : {1} Sous Etat : {2}",
                this.id,
                this.surnom,
                this.State
            );
        }
    }
}
