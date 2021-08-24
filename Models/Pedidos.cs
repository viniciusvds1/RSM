using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RSM.Models;
using System.Xml.Serialization;
using System.IO;

namespace RSM
{

   
    [XmlInclude(typeof(Pedidos))]

    public class Pedidos : Produtos
    {
        private string cliente = "";
        private string pedido;
        private string data;
        private string total;
        [XmlArray]
        public Produtos []Produtos;
        
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        public string Data{
            get { return data;}
            set { data = value; }
        }

        public string Total
        {
            get { return total; }
            set { total = value; }
        }
        

    }
}
