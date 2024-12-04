using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MuriloVIeiraClass
{
    public class Placa
    {
     

        public int Id { get; set; }
        public string? Tipo{ set; get; }
        public string? Tamanho{ get; set; }
        public double Preco  { get; set; }
        public Placa(int id, string? tipo, string? tamanho, double preco)
        {
            Id = id;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;
        }
        public Placa() { }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_placas_insert";
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.Parameters.AddWithValue("sptamanho", Tamanho);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();

        }
        public static Placa ObterPorId(int id)
        {
            Placa placa = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from placa where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                placa = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetDouble(3)
                   );

            }

            return placa;

        }
        public static List<Placa> ObterLista()
        {
            List<Placa> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from placa order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetDouble(3)
                   ));

            }

            return lista;

        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_placa_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

    }
}
