using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RecycleTrack23
{
    public class MaterijalRepozitorij
    {
        public List<Materijal> GetAll()
        {
            List<Materijal> materijali = new List<Materijal>();
            string query = "SELECT * FROM [dbo].[Materijali]";
            DB.SetConfiguration("PI2324_jkuhtic22_DB", "PI2324_jkuhtic22_User", "{RDmyW(W");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(query);
            while (reader.Read())
            {
                materijali.Add(new Materijal
                {
                    Id = reader.GetInt32(0),
                    NazivMaterijala = reader.GetString(1),
                    PostotakKapaciteta = reader.GetString(2),
                    CijenaPoKilogramu=reader.GetString(3),
                });
            }
            reader.Close();
            DB.CloseConnection();
            return materijali;
        }
        public List<Materijal> Search(string search)
        {
            List<Materijal> materijali = new List<Materijal>();
            string query = $"SELECT * FROM [dbo].[Materijali] WHERE Materijal LIKE '%{search}%'";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(query);
            while (reader.Read())
            {
                materijali.Add(new Materijal
                {
                    Id = reader.GetInt32(0),
                    NazivMaterijala = reader.GetString(1),
                    PostotakKapaciteta=reader.GetString(2),
                    CijenaPoKilogramu = reader.GetString(3)
                });
            }
            reader.Close();
            DB.CloseConnection();
            return materijali;
        }

        

        public void Update(Materijal materijal)
        {
            string query = $"UPDATE [dbo].[Materijali] SET Materijal = '{materijal.NazivMaterijala}', [Postotak kapaciteta] = '{materijal.PostotakKapaciteta}',[Cijena po kilogramu] = '{materijal.CijenaPoKilogramu}' WHERE Id = {materijal.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }
        public void Delete(int id)
        {
            string query = $"DELETE FROM [dbo].[Materijali] WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }
        public static void NoviMaterijal(Materijal noviUnos)
        {

            string query = $"INSERT INTO [dbo].[Materijali] ([Id], [Materijal],[Postotak kapaciteta], [Cijena po kilogramu] ) " +
                           $"VALUES ({noviUnos.Id}, '{noviUnos.NazivMaterijala}',  '{noviUnos.PostotakKapaciteta}', {noviUnos.CijenaPoKilogramu})";

            DB.SetConfiguration("PI2324_jkuhtic22_DB", "PI2324_jkuhtic22_User", "{RDmyW(W");
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();

        }
        public static List<Izvjestaj> GetAllIzvjestaj1(int index)
        {
            string nazivTablice = string.Empty;
            switch (index)
            {
                case 0:
                    nazivTablice = "IzvjestajDan"; break;
                case 1:
                    nazivTablice = "IzvjestajTjedan"; break;
                case 2:
                    nazivTablice = "IzvjestajMjesec"; break;
                case 3:
                    nazivTablice = "IzvjestajGodina"; break;
            }
            List<Izvjestaj> izvjestaji = new List<Izvjestaj>();
            if (nazivTablice.Length > 0)
            {
                string query = $"SELECT * FROM [dbo].[{nazivTablice}]";

                DB.SetConfiguration("PI2324_jkuhtic22_DB", "PI2324_jkuhtic22_User", "{RDmyW(W");
                DB.OpenConnection();
                SqlDataReader reader = DB.GetDataReader(query);

                while (reader.Read())
                {
                    izvjestaji.Add(new Izvjestaj
                    {
                        Naziv = reader.GetString(0),
                        Kupljeno = reader.GetInt32(1),
                        CijenaPoKilogramu = reader.GetDouble(2).ToString(),
                        StanjeNaSkladistu = reader.GetInt32(3),
                        Reciklirano = reader.GetInt32(4)

                    });

                }
                reader.Close();
                DB.CloseConnection();
            }
            return izvjestaji;
        }
    }
}