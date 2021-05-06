using System;
using System.Collections.Generic;
using METIER;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DaoParticiper
    {
        private void delete(Participer p)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Participer where idCourse=@idC and idLapin=@idL", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idC", MySqlDbType.Int32));
                    cmd.Parameters["@idC"].Value = p.IdCourse;
                    cmd.Parameters.Add(new MySqlParameter("@idL", MySqlDbType.Int32));
                    cmd.Parameters["@idL"].Value = p.IdLapin;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void SaveChanges(List<Participer> part)
        {
            for (int i = 0; i < part.Count; i++)
            {
                Participer p = part[i];
                switch (p.State1)
                {
                    case state.added:
                        this.insert(p);
                        break;
                    case state.modified:
                        this.update(p);
                        break;
                    case state.deleted:
                        this.delete(p);
                        break;
                }
            }
        }
        private void update(Participer p)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Participer set gagnant=1 where idCourse=@idCourse and idLapin=@idLapin", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idCourse", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@idLapin", MySqlDbType.Int32));
                    cmd.Parameters["@idCourse"].Value = p.IdCourse;
                    cmd.Parameters["@idLapin"].Value = p.IdLapin;
                    cmd.ExecuteNonQuery();
                }              
            }
            p.State1 = state.unChanged;
        }
        private void insert(Participer p)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Participer(idCourse,Gagnant,idLapin) values(@idCourse,@Gagnant,@idLapin)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idCourse", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@idLapin", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@Gagnant", MySqlDbType.Int32));
                    cmd.Parameters["@idCourse"].Value = p.IdCourse;
                    cmd.Parameters["@idLapin"].Value = p.IdLapin;
                    cmd.Parameters["@Gagnant"].Value = p.Gagnant;
                    cmd.ExecuteNonQuery();
                }
            }
            p.State1=(state.unChanged);
        }
        public List<Participer> GetAll()
        {
            List<Participer> p = new List<Participer>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select * from Participer", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            p.Add(new Participer(Convert.ToInt32(rdr["idCourse"]),  Convert.ToInt32(rdr["idLapin"]), Convert.ToInt32(rdr["Gagnant"]), state.unChanged));
                        }
                    }
                }
            }
            return p;
        }
    }
}
