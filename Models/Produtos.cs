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
namespace RSM.Models
{
    public class Produtos
    {
        private string codigo;
        private string nome;
        private string quantidade;
        private string valor;
        public string Codigo { 
             get { return codigo; }
            set { codigo = value; }
        }
        public string Nome {
             get { return nome; }
            set { nome = value; }
         }
        public string Quantidade { get { return quantidade; }
            set { quantidade = value; } }
        public string Valor {
             get { return valor; }
            set { valor = value; }
         }

    }
}