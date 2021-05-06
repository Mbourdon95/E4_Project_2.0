using System;
using System.Collections.Generic;
using METIER;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DaoLapin
    {
        public void SaveChanges(List<Lapins> lapins)
        {
            for (int i = 0; i < lapins.Count; i++)
            {
                Lapins lapin = lapins[i];
                switch (lapin.GetState())
                {
                    case state.added:
                        this.insert(lapin);
                        break;
                    case state.modified:
                        this.update(lapin);
                        break;
                    case state.deleted:
                        this.delete(lapin);
                        lapins.Remove(lapin);
                        break;
                }
            }
        }
        private void delete(Lapins lapin)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Lapin where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = lapin.GetId();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void update(Lapins lapin)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                if (lapin.GetIdGerant() == 0)
                {
                    using (MySqlCommand cmd = new MySqlCommand("update Lapin set surnom=@surnom,age=@age, idGerant=NULL where id=@id", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@surnom", MySqlDbType.VarChar));
                        cmd.Parameters["@id"].Value = lapin.GetId();
                        cmd.Parameters["@age"].Value = lapin.GetAge();
                        cmd.Parameters["@surnom"].Value = lapin.GetSurnom();
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (MySqlCommand cmd = new MySqlCommand("update Lapin set surnom=@surnom,age=@age,idGerant=@idGerant where id=@id", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@idGerant", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@surnom", MySqlDbType.VarChar));
                        cmd.Parameters["@id"].Value = lapin.GetId();
                        cmd.Parameters["@age"].Value = lapin.GetAge();
                        cmd.Parameters["@surnom"].Value = lapin.GetSurnom();
                        cmd.Parameters["@idGerant"].Value = lapin.GetIdGerant();
                        cmd.ExecuteNonQuery();
                    }
                }
               
            }
            lapin.SetState(state.unChanged);
        }
        private void insert(Lapins lapin)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                if (lapin.GetIdGerant() == 0)
                {
                    using (MySqlCommand cmd = new MySqlCommand("insert into Lapin(surnom,age,vitesse,endurance,chance) values(@surnom,@age,@vitesse,@endurance,@chance)", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@surnom", MySqlDbType.VarChar));
                        cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@vitesse", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@endurance", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@chance", MySqlDbType.Int32));
                        cmd.Parameters["@surnom"].Value = lapin.GetSurnom();
                        cmd.Parameters["@age"].Value = lapin.GetAge();
                        cmd.Parameters["@vitesse"].Value = lapin.Vitesse;
                        cmd.Parameters["@endurance"].Value = lapin.Endurance;
                        cmd.Parameters["@chance"].Value = lapin.Chance;
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (MySqlCommand cmd = new MySqlCommand("insert into Lapin(surnom,age,vitesse,endurance,chance,idGerant) values(@surnom,@age,@vitesse,@endurance,@chance,@idGerant)", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@surnom", MySqlDbType.VarChar));
                        cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@vitesse", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@endurance", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@chance", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@idGerant", MySqlDbType.Int32));
                        cmd.Parameters["@surnom"].Value = lapin.GetSurnom();
                        cmd.Parameters["@age"].Value = lapin.GetAge();
                        cmd.Parameters["@vitesse"].Value = lapin.Vitesse;
                        cmd.Parameters["@endurance"].Value = lapin.Endurance;
                        cmd.Parameters["@chance"].Value = lapin.Chance;
                        cmd.Parameters["@idGerant"].Value = lapin.GetIdGerant();
                        cmd.ExecuteNonQuery();
                    }
                }
               
            }
            lapin.SetState(state.unChanged);
        }
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
                            lapins.Add(new Lapins(Convert.ToInt32(rdr["id"]), rdr["surnom"].ToString(), state.unChanged, n, Convert.ToInt32(rdr["chance"]), Convert.ToInt32(rdr["endurance"]), Convert.ToInt32(rdr["vitesse"])));
                        }
                    }
                }
            }
            return lapins;
        }
        public List<Lapins> GetAll(int id)
        {
            List<Lapins> lapins = new List<Lapins>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,surnom,age,idGerant,vitesse,endurance,chance,gagnant from Lapin inner join Participer on Lapin.id = Participer.idLapin where idCourse=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = id;
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int n = 0;
                            if (rdr["idGerant"].ToString() != "")
                            {
                                n = Convert.ToInt32(rdr["idGerant"]);
                            }
                            lapins.Add(new Lapins(Convert.ToInt32(rdr["id"]), rdr["surnom"].ToString(), state.unChanged, n, Convert.ToInt32(rdr["chance"]), Convert.ToInt32(rdr["endurance"]), Convert.ToInt32(rdr["vitesse"]), Convert.ToInt32(rdr["gagnant"])));
                        }
                    }
                }
            }
            return lapins;
        }
    }
}
