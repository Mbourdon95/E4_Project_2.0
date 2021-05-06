using System;
using System.Collections.Generic;
using METIER;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DaoCourse
    {
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
        private void update(Course course)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Course set distance=@distance, @nomprixDuGagnant=nomprixDuGagnant where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@distance", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@prixDuGagnant", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@prixEntree", MySqlDbType.Int32));
                    cmd.Parameters["@prixEntree"].Value = course.PrixEntree;
                    cmd.Parameters["@prixDuGagnant"].Value = course.PrixDuGagnant;
                    cmd.Parameters["@id"].Value = course.GetId();
                    cmd.Parameters["@distance"].Value = course.GetDistance();
                    cmd.ExecuteNonQuery();
                }
            }
            course.SetState(state.unChanged);
        }
        private void insert(Course course)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Course(distance,nom,prixDuGagnant,prixEntree) values(@distance,@nom,@prixDuGagnant,@prixEntree)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@distance", MySqlDbType.Int32));
                    cmd.Parameters["@distance"].Value = course.GetDistance();
                    cmd.Parameters.Add(new MySqlParameter("@prixDuGagnant", MySqlDbType.Int32));
                    cmd.Parameters["@prixDuGagnant"].Value = course.PrixDuGagnant;
                    cmd.Parameters.Add(new MySqlParameter("@prixEntree", MySqlDbType.Int32));
                    cmd.Parameters["@prixEntree"].Value = course.PrixEntree;
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters["@nom"].Value = course.GetNom();
                    cmd.ExecuteNonQuery();
                }
            }
            course.SetState(state.unChanged);
        }
        public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,distance,nom,prixDuGagnant,prixEntree from Course", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            courses.Add(new Course(Convert.ToInt32(rdr["id"]), Convert.ToInt32(rdr["distance"]), rdr["nom"].ToString(), Convert.ToInt32(rdr["prixDuGagnant"]), Convert.ToInt32(rdr["prixEntree"]), state.unChanged));
                        }
                    }
                }
            }
            return courses;
        }
    }
}
