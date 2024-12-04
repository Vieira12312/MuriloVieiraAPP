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
    public class Cliente
    {
       
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public Cliente(int id, string? nome, string? email, string? telefone, string? endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        public Cliente(string? nome, string? email, string? telefone, string? endereco)
        {
          
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        public Cliente(string? nome, string? email, string? telefone )
        {
   
            Nome = nome;
            Email = email;
            Telefone = telefone;
         
        }

        public Cliente()
        {
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_clientes_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone",Telefone );
            cmd.Parameters.AddWithValue("spemail", Endereco);
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();

        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4)
                   );

            }

            return cliente;

        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4)
                   ));

            }

            return lista;

        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_clientes_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spendereco", Endereco);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
