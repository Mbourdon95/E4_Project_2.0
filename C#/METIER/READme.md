# E4_PROJECT_2
## Championnat des Lapins : Les Classes Métiers  :earth_americas: :honeybee:

>> Les classes Métiers forment la plaque angulaire du projet. Elle nous permettent de créer les objets que l'on va manipuler dans le script.

### Setup

Il faut noter que chaque classe possède des accesseurs sur leur donnée membre.
**Important** 
Les classes Course, Lapins, Gérant doivent gérer un LastId.. pour éviter d'inserer des données répétitives, notamment des clés primaires qui pourrait planter le programme. 
Pour éviter ces désagréments, il y a une classe qui gère lesCourses, lesLapins, lesGérants

```c#
public class LesCourses
    {
        private List<Course> lesC;
        private int lastID;

        public LesCourses()
        {
            this.lesC = new List<Course>();
            this.lastID = 1;
        }

        public int LastID { get => lastID; set => lastID = value; }

        public void Add(Course uneCourse)
        {
            lesC.Add(uneCourse);
            this.lastID = uneCourse.GetId() + 1;
        }
    }
````
### Les Classes

#### *1.Course*

Une course ne peut etre lancé qu'une fois. 
```c#
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
        
 public Lapins Gagnant()
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
            return LosParticipantes[gagnant];
        }
````
#### *2. Lapins*
> Constructeur par défaut, il génère un nouveau lapin avec des stats aléatoire.
```c#
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
        }
````
> Constructeur par défaut lorsque l'on récupère des lapins de la bdd, les stats sont déjà effective alors pourquoi en générer des nouvelles.
```c#
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
        }
````     
>> La lapin possède une méthode pour avancer dans une course qui dépend de l'aléatoire 
```c# 
public void Avancer()
        {
            this.position += (aléatoire.Next(0, 6) + this.endurance + this.chance + this.vitesse)%10;
        }
````  
#### *3.State*
> Cette classe définit une énumération, c'est ici que tout se joue.
> En effet, les actions sur la bdd dépendent de l'état des objets, modifier, inserer ou supprimmer, 
> insérer plusieurs fois un id dans la bbd provoque des erreurs **Duplicate entry** sur la clef primaire 

```c# 
public enum state
    {
        added,
        modified,
        deleted,
        unChanged
    };
```` 

> #### 4. Les Classes ADO.Net !
**https://github.com/Mbourdon95/E4_PROJECT_2/tree/main/C%23/DAO**

> #### 5. Les Windows Forms !
**https://github.com/Mbourdon95/E4_PROJECT_2/tree/main/C%23/WF**
