using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MuriloVIeiraClass
{
    public class Encomenda
    {


        public int Id { get; set; }
        public int Cliente_Id {  set; get; }
        public DateTime DataEncomenda{ get; set; }
        public string? Status { get; set; }
        public DateTime DataEntrega{ get; set; }
        public Encomenda(int id, int cliente_Id, DateTime dataEncomenda, string? status, DateTime dataEntrega)
        {
            Id = id;
            Cliente_Id = cliente_Id;
            DataEncomenda = dataEncomenda;
            Status = status;
            DataEntrega = dataEntrega;
        }
        public Encomenda( int cliente_Id, DateTime dataEncomenda, string? status)
        {
            Cliente_Id = cliente_Id;
            DataEncomenda = dataEncomenda;
            Status = status;

        }
        public Encomenda() { }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_encomendas_insert";
            cmd.Parameters.AddWithValue("spdata_encomenda", DataEncomenda);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdata_entrega", DataEntrega);
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();

        }
        public static Encomenda ObterPorId(int id)
        {
            Encomenda encomenda= new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from encomendas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                encomenda = new(
                   dr.GetInt32(0),
                   dr.GetInt32(1),
                   dr.GetDateTime(2),
                   dr.GetString(3),
                   dr.GetDateTime(4)
                   );

            }

            return encomenda;

        }
        public static List<Encomenda> ObterLista()
        {
            List<Encomenda> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from encomendas order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetInt32(1),
                   dr.GetDateTime(2),
                   dr.GetString(3),
                   dr.GetDateTime(4)
                   ));

            }

            return lista;

        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_encomendas_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdata_encomenda", DataEncomenda);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdata_entrega", DataEntrega);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
