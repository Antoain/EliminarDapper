using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AccesoDatos
{
    public class CategoryRepo
    {
        public List<Categoria> ObtenerTodo()
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [CategoryID] " + "\n";
                SelectAll = SelectAll + "      ,[CategoryName] " + "\n";
                SelectAll = SelectAll + "      ,[Description] " + "\n";
                SelectAll = SelectAll + "      ,[Picture] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Categories]";

                var Categoriass = conexion.Query<Categoria>(SelectAll).ToList();
                return Categoriass;
            }
        }

        public Categoria ObtenerPoeID(int id)
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {

                String SelectID = "";
                SelectID = SelectID + "SELECT [CategoryID] " + "\n";
                SelectID = SelectID + "      ,[CategoryName] " + "\n";
                SelectID = SelectID + "      ,[Description] " + "\n";
                SelectID = SelectID + "      ,[Picture] " + "\n";
                SelectID = SelectID + "  FROM [dbo].[Categories] " + "\n";
                SelectID = SelectID + "  WHERE CategoryID = @CategoryID";

                var Categoriass = conexion.QueryFirstOrDefault<Categoria>(SelectID, new { CategoryID = id });
                return Categoriass;
            }
        }

        public int EliminarCategoria(int id)
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {
                string Delete = "";
                Delete += "DELETE FROM [dbo].[Categories] " + "\n";
                Delete += "WHERE CategoryID = @CategoryID;";

                var eliminadas = conexion.Execute(Delete, new
                {
                    CategoryID = id
                });

                return eliminadas; 
            }
        }


    }
}
