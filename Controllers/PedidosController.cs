using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;  
namespace RSM.Controllers
{
     public class PedidosController : Controller  
    {  
        [HttpGet]
        public List<Pedidos> GetAllPedidos()  
        {  
            List<Pedidos> lp = new List<Pedidos>();      
            XDocument doc = XDocument.Load("pedidos.xml");  
            foreach (XElement element in doc.Descendants("PedidosVendas"))
            {  
               
                Pedidos p = new Pedidos();  
                p.Cliente = element.Element("Cliente").Value;  
                p.Pedido = element.Element("Pedido").Value;  
                p.Data  = element.Element ("Data").Value;
                p.Total  = element.Element ("Total").Value;  
                p.Codigo  = element.Element ("Codigo").Value;  
                p.Nome  = element.Element ("Nome").Value;  
                p.Quantidade  = element.Element ("Quantidade").Value;  
                p.Valor  = element.Element ("Valor").Value;  
                
                lp.Add(p);
            }
                
            return lp;  
        }  
        public Pedidos GetPedidos(string Codigo)  
        {  
           Pedidos p = new Pedidos();  
           XDocument doc = XDocument.Load("D:\\projetos\\pedidos.xml");  
            XElement element = doc.Element("Pedidos")  
                                .Elements("Pedidos").Elements("Cliente").  
                                SingleOrDefault(x => x.Value == Codigo.ToString());  
                       if (element != null)  
            {  
                XElement parent = element.Parent;  
                p.Cliente = parent.Element("Cliente").Value;  
                p.Pedido = parent.Element("Pedido").Value;  
                p.Data  = parent.Element ("Data").Value;
                p.Total  = parent.Element ("Total").Value;  
                p.Codigo  = parent.Element ("Codigo").Value;  
                p.Nome  = parent.Element ("Nome").Value;  
                p.Quantidade  = parent.Element ("Quantidade").Value;  
                p.Valor  = parent.Element ("Valor").Value; 
                
            }
            return p;   
        }  
    }  
} 
