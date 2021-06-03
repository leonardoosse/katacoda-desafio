using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Models
{
    //[Table("segmentos")]
    public class Segmento
    {
        public Segmento() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Taxa { get; set; }

        private static DBContexto db = new DBContexto();

        public static List<Segmento> All()
        {
            var segmentoJson = File.ReadAllText("segmento.json");
            return JsonConvert.DeserializeObject<List<Segmento>>(segmentoJson);            
            //return db.Segmentos.AsNoTracking().ToList();
        }

        public Segmento Atualizar()
        {
            string segmentoJson = File.ReadAllText("segmento.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(segmentoJson);
            foreach(var item in jsonObj)
            {
                if (item["id"] == this.Id)
                {
                    item["taxa"] = this.Taxa;
                }
            }
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("segmento.json", output);            

            // SqlConnection cn = new SqlConnection(Conexao.Dados);
            // cn.Open();

            // SqlCommand cmd = new SqlCommand("update segmentos set taxa = @taxa where id = @id", cn);
            // cmd.Parameters.Add("@id", SqlDbType.Int);
            // cmd.Parameters["@id"].Value = this.Id;
            // cmd.Parameters.Add("@taxa", SqlDbType.Decimal);
            // cmd.Parameters["@taxa"].Value = this.Taxa;
            // cmd.ExecuteNonQuery();

            // cn.Close();
            // cn.Dispose();
            // cmd.Dispose();
            return this;
        }

        public Segmento AtualizarEf()
        {
            db.Segmentos.Update(this);
            db.SaveChanges();
            return this;
        }

    }
}
