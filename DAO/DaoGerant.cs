using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using METIER;

namespace DAO
{
    public class DaoGerant
    {
        public void SaveChanges(List<Gerant> gerant)
        {
            for (int i = 0; i < gerant.Count; i++)
            {
                Gerant gerants = gerant[i];
                switch (gerants.State1)
                {
                    case state.added:
                        this.insert(gerants);
                        break;
                    case state.modified:
                        this.update(gerants);
                        break;
                    case state.deleted:
                        this.delete(gerants);
                        gerant.Remove(gerants);
                        break;
                }
            }
        }
        public void SaveChanges(Gerant gerant)
        {
                switch (gerant.State1)
                {
                    case state.added:
                        this.insert(gerant);
                        break;
                    case state.modified:
                        this.update(gerant);
                        break;
                }
        }
        private void delete(Gerant gerant)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update lapin set idGerant= null where idGerant=@idGerant", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idGerant", MySqlDbType.Int32));
                    cmd.Parameters["@idGerant"].Value = gerant.Id;
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand("delete from gerant where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = gerant.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void update(Gerant gerant)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Gerant set age=@age, nom=@nom, prenom=@prenom, budget=@budget where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));                   
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@budget", MySqlDbType.Int32));
                    cmd.Parameters["@budget"].Value = gerant.Budget;
                    cmd.Parameters["@id"].Value = gerant.Id;
                    cmd.Parameters["@age"].Value = gerant.Age;
                    cmd.Parameters["@nom"].Value = gerant.Nom;
                    cmd.Parameters["@prenom"].Value = gerant.Prenom;
                    cmd.ExecuteNonQuery();
                }
            }
            gerant.State1=(state.unChanged);
        }

        private void insert(Gerant gerant)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into gerant(nom,prenom,age,pwd,budget) values(@nom,@prenom,@age,@pwd,@budget)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@pwd", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@budget", MySqlDbType.Int32));
                    cmd.Parameters["@budget"].Value = gerant.Budget;
                    cmd.Parameters["@age"].Value = gerant.Age;
                    cmd.Parameters["@nom"].Value = gerant.Nom;
                    cmd.Parameters["@prenom"].Value = gerant.Prenom;
                    cmd.Parameters["@pwd"].Value = gerant.Password;
                    cmd.ExecuteNonQuery();
                }
            }
            gerant.State1=(state.unChanged);
        }

        public List<Gerant> GetAll()
        {
            List<Gerant> gerants = new List<Gerant>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,age,nom,prenom,pwd,budget from gerant", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            gerants.Add(new Gerant(rdr["nom"].ToString(), rdr["prenom"].ToString(), Convert.ToInt32(rdr["age"]), rdr["pwd"].ToString(), state.unChanged, Convert.ToInt32(rdr["budget"]), Convert.ToInt32(rdr["id"])));
                        }
                    }
                }
            }
            return gerants;
        }
    }
}
