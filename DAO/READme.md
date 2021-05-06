# E4_PROJECT_2
## Championnat des Lapins : Les Classes ADO.NET :earth_americas: :honeybee:

>> Les classes Dao sont essentielles. Elle nous permettents de faire la liaison les objets que l'on va manipuler dans le script.

### Les Classes

#### *1. Dao Connection*

**Cette Classe permet d'établir la chaîne de connection, elle est unique (*static*)**

#### *2. Dao*
> Les Classes sont toutes formées de la même manière. Insert, Update et Delete
```c#
         private void delete(Course course)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Course where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = course.GetId();
                    cmd.ExecuteNonQuery();
                }
            }
        }
````

> Elles ont également deux spécificitées, la fonction qui dirige vers (insert,update et delete) (*SaveChanges*) 
>> C'est ici que l'on remarque que l'état d'un objet est très important.
```c#
        public void SaveChanges(List<Course> courses)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                Course course = courses[i];
                switch (course.GetState())
                {
                    case state.added:
                        this.insert(course);
                        break;
                    case state.modified:
                        this.update(course);
                        break;
                    case state.deleted:
                        this.delete(course);
                        courses.Remove(course);
                        break;
                }
            }
        }
````
> et aussi la fonction qui récupère les éléments dans la bdd (*GetAll*)
```c#
         public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,distance,nom from Course", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            courses.Add(new Course(Convert.ToInt32(rdr["id"]), Convert.ToInt32(rdr["distance"]), rdr["nom"].ToString(), state.unChanged));
                        }
                    }
                }
            }
            return courses;
        }
````

#### *3. Spécificités*
> Lorsque qu'on récupère des données, il se peut qe l'une d'entre elles soit de valeur *NULL*, or on récupère une valeur vide, c'est pourquoi on ajoute une condition dans le cas ou le lapin ne serait affilié à aucun gérant.
```c#
        public List<Lapins> GetAll()
        {
            List<Lapins> lapins = new List<Lapins>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,surnom,age,idGerant,vitesse,endurance,chance from Lapin", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int n = 0;
                            if (rdr["idGerant"].ToString() != "")
                            {
                                n = Convert.ToInt32(rdr["idGerant"]);
                            }
                            lapins.Add(new Lapins(Convert.ToInt32(rdr["id"]), rdr["surnom"].ToString(), state.unChanged, n, Convert.ToInt32(rdr["chance"]),         
                                        Convert.ToInt32(rdr["endurance"]), Convert.ToInt32(rdr["vitesse"])));
                        }
                    }
                }
            }
            return lapins;
````     
> #### 4. Les Classes Métier !
**https://github.com/Mbourdon95/E4_PROJECT_2/tree/main/C%23/METIER**

> #### 5. Les Windows Forms !
**https://github.com/Mbourdon95/E4_PROJECT_2/tree/main/C%23/WF**
