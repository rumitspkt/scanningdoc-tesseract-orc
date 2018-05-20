using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ScanningDoc.DTO;

namespace ScanningDoc
{
   public class DataProvider
   {
      private static DataProvider instance;

      public static DataProvider Instance
      {
         get { if (instance == null) instance = new DataProvider(); return instance; }
         private set { instance = value; }
      }
      private DataProvider() { }
      public List<Path> getPaths()
      {
         List<Path> list = new List<Path>();
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = "select * from paths";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               list.Add(new Path((int)reader["id"], (string)reader["name"]));
            }
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
         return list;
      }
      public bool checkPathExist(string @name)
      {
         List<Path> listPath = getPaths();
         foreach (Path path in listPath)
         {
            if (path.Name.Equals(@name))
            {
               return true;
            }
         }
         return false;
      }
      public bool checkPathExistInLinks(int id)
      {
         List<Link> links = getLinks();
         foreach (Link link in links)
         {
            if (link.Path.Id == id)
            {
               return true;
            }
         }
         return false;
      }
      public Path getPath(int id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("select * from paths where id = {0}", id.ToString());
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               return new Path((int)reader["id"], (string)reader["name"]);
            }
            return null;
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
      }
      public bool addPath(int id, string @name)
      {
         if (name.Equals(""))
         {
            return false;
         }
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("insert into paths (id, name) values ({0}, '{1}')", id.ToString(), @name);
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public bool deletePath(int id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("delete from paths where id = {0}", id.ToString());
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }

      public List<Code> getCodes()
      {
         List<Code> list = new List<Code>();
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = "select * from codes";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               list.Add(new Code((int)reader["id"], (string)reader["name"]));
            }
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
         return list;
      }
      public bool checkCodeExist(string name)
      {
         List<Code> listCode = getCodes();
         foreach (Code code in listCode)
         {
            if (code.Name.Equals(name))
            {
               return true;
            }
         }
         return false;
      }
      public bool checkCodeExistInLinks(int id)
      {
         List<Link> links = getLinks();
         foreach (Link link in links)
         {
            if (link.Code.Id == id)
            {
               return true;
            }
         }
         return false;
      }
      public Code getCode(int id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("select * from codes where id = {0}", id.ToString());
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               return new Code((int)reader["id"], (string)reader["name"]);
            }
            return null;
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
      }
      public bool addCode(int id, string name)
      {
         if (name.Equals(""))
         {
            return false;
         }
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("insert into codes (id, name) values ({0}, '{1}')", id.ToString(), name);
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public bool deleteCode(int id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("delete from codes where id = {0}", id.ToString());
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public List<RelatingCode> getRelatingCodes(int id)
      {
         List<RelatingCode> list = new List<RelatingCode>();
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("select name from relating_codes where code_id = {0}", id.ToString());
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               list.Add(new RelatingCode((string)reader["name"]));
            }
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
         return list;
      }
      public bool checkRelatingCodeExist(int code_id, string @name)
      {
         List<RelatingCode> listRelatingCode = getRelatingCodes(code_id);
         foreach (RelatingCode relatingCode in listRelatingCode)
         {
            if (relatingCode.ToString().Equals(name))
            {
               return true;
            }
         }
         return false;
      }
      public bool addRelatingCode(int code_id, string name)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("insert into relating_codes (code_id, name) values ({0}, '{1}')", code_id.ToString(), name);
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public bool deleteRelatingCode(int code_id, string name)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("delete from relating_codes where code_id = {0} and name = '{1}'", code_id.ToString(), name);
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public List<Link> getLinks()
      {
         List<Link> list = new List<Link>();
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = "select * from links";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Code code = getCode((int)reader["code_id"]);
               Path path = getPath((int)reader["path_id"]);
               list.Add(new Link(code, path));
            }
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
         return list;
      }
      public bool addLink(int code_id, int path_id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("insert into links (code_id, path_id) values ({0}, {1})", code_id.ToString(), path_id.ToString());
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public bool deleteLink(int code_id, int path_id)
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("delete from links where code_id = {0} and path_id = {1}", code_id.ToString(), path_id.ToString());
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            deleteCode(code_id);
            deletePath(path_id);
            List<RelatingCode> relatingCodes = getRelatingCodes(code_id);
            foreach (RelatingCode relatingCode in relatingCodes)
            {
               deleteRelatingCode(code_id, relatingCode.ToString());
            }
            
            return true;
         }
         catch
         {
            return false;
         }
         finally
         {

         }
      }
      public bool checkLinkExist(int code_id, int path_id)
      {
         bool isExistedPath = checkPathExistInLinks(path_id);
         bool isExistedCode = checkCodeExistInLinks(code_id);
         if(!isExistedCode)
         {
            if (!isExistedPath)
            {
               return false;
            }
         }
         return true;
      }
      public bool addPDFFolderPath(string @name)
      {
        SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = string.Format("delete from pdf_folder");
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

            sql = string.Format("insert into pdf_folder (name) values ('{0}')", @name);
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

            return true;
         }
         catch
         {
            return false;
         }
         finally
         {
            con.Close();
         }
      }
      public string getPDFFolderPath()
      {
         SQLiteConnection con = new SQLiteConnection("Data Source=../../scanningdb.sqlite;Version=3;");
         try
         {
            con.Open();
            string sql = "select * from pdf_folder";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               return (string)reader["name"];
            }
         }
         catch
         {
            return null;
         }
         finally
         {
            con.Close();
         }

         //Console.WriteLine("ID: " + reader["code_id"] + "\tName: " + reader["name"]);
         return "";
      }

   }
}
