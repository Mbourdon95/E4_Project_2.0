using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    public class Course
    {
        // Données Membres.
        private int distance;
        private string nomCourse;
        private bool depart;
        static Random aléatoire;
        private List<Lapins> LosParticipantes;
        private Lapins leGagnant;
        private int prixDuGagnant;
        private int prixEntree;
        private int id;
        private state State;

        public bool Depart { get => depart; set => depart = value; }
        public Lapins LeGagnant { get => leGagnant; set => leGagnant = value; }
        public int PrixDuGagnant { get => prixDuGagnant; set => prixDuGagnant = value; }
        public int PrixEntree { get => prixEntree; set => prixEntree = value; }
        public List<Lapins> LosParticipantes1 { get => LosParticipantes; set => LosParticipantes = value; }

        // Constructeurs.
        static Course()
        {
            aléatoire = new Random();
        }
        /// <summary>
        /// Constructeur Course avec id,distance,nom et état.
        /// </summary>
        public Course(int _id, int _distance, string _nomCourse, int _prix, int _prixE,state _stat)
        {
            this.id = _id;
            this.nomCourse = _nomCourse;
            this.distance = _distance;
            this.depart = true;
            this.State = _stat;
            this.prixDuGagnant = _prix;
            this.prixEntree = _prixE;
            LosParticipantes = new List<Lapins>();
        }
        // Accesseurs et Méthodes       
        /// <summary>
        /// Fonction Permettant de récupérer l'id de notre Course.
        /// </summary>
        public int GetId()
        {
            return this.id;
        }
        /// <summary>
        /// Fonction Permettant de récupérer l'état de notre Course.
        /// </summary>
        public state GetState()
        {
            return this.State;
        }
        /// <summary>
        /// Fonction Permettant de modifier l'état de notre Course.
        /// </summary>
        public void SetState(state _state)
        {
            this.State = _state;
        }
        /// <summary>
        /// Procédure Permettant d'assigner une valeur à l'id de notre Course.
        /// </summary>
        public void SetId(int _id)
        {
            this.id = _id;
        }
        /// <summary>
        /// Procédure qui change l'état d'une Course en 'deleted'.
        /// </summary>
        public void Remove()
        {
            this.State = state.deleted;
        }
        /// <summary>
        /// Fonction qui compte le nombre de Lapin dans une Course.
        /// </summary>
        public int Count()
        {
            return LosParticipantes.Count;
        }
        /// <summary>
        /// Fonction qui Donne la Distance d'une Course.
        /// </summary>
        public int GetDistance()
        {
            return this.distance;
        }
        /// <summary>
        /// Procedure qui modifie la Distance d'une Course.
        /// </summary>
        public void SetDistance(int _distance)
        {
            this.distance = _distance;
        }
        /// <summary>
        /// Fonction qui Donne le nom d'une Course.
        /// </summary>
        public string GetNom()
        {
            return this.nomCourse;
        }
        /// <summary>
        /// Procedure qui modifie le nom d'une Course.
        /// </summary>
        public void SetNom(string _nom)
        {
            this.nomCourse = _nom;
        }
        /// <summary>
        /// Fonction qui retourne la liste de Lapin participant à la Course.
        /// </summary>
        public List<Lapins> Participer()
        {
            return LosParticipantes;
        }
        /// <summary>
        /// Fonction qui retourne un Lapin d'une Course à une certaine position.
        /// </summary>
        public Lapins This(int _position)
        {
            return LosParticipantes[_position];
        }
        /// <summary>
        /// Procédure qui ajoute un Lapin à l'intérieur d'une Course.
        /// </summary>
        public void Add(Lapins _Lapin)
        {
            LosParticipantes.Add(_Lapin);
        }
        /// <summary>
        /// Procédure qui Lance la Course si elle n'a jamais été lancée.
        /// </summary>
        public void Départ()
        {
            for (int i = 0; i < LosParticipantes.Count; i++)
            {
                for (int j = 0; j < this.distance; j++)
                {
                    LosParticipantes[i].Avancer();
                }
            }
            this.depart = false;
        }
        /// <summary>
        /// Procédure qui supprime un Lapin de la Course à une certaine Position.
        /// </summary>
        public void RemoveAt(int _position)
        {
            LosParticipantes.RemoveAt(_position);
        }
        /// <summary>
        /// Fonction qui retourne le Lapin Gagnant d'une Course.
        /// </summary>
        public void Gagnant()
        {
            int gagnant = 0;
            int positio = 0;
            for (int i = 0; i < LosParticipantes.Count; i++)
            {
                positio = LosParticipantes[i].GetPosition();

                if (LosParticipantes[gagnant].GetPosition() < LosParticipantes[i].GetPosition())
                {
                    gagnant = i;
                }
            }
            for (int i = 0; i < LosParticipantes.Count; i++)
            {
                LosParticipantes[i].SetPosition(0);
            }
            this.leGagnant = LosParticipantes[gagnant];
        }
        /// <summary>
        /// Fonction qui retourne les informations d'une course sous la forme d'une chaîne de caractère.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Course n°{0} : {1},{3}km  sous Etat : {2}  ",
                this.id,
                this.nomCourse,
                this.State,
                this.distance
            );
        }
    }
}
