using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Application.Dtos
{
    public class ProductDto
    {
        public int Id {get;set;}
        public string Name{ get; set; }
         public string Description{ get; set; }
         public long  Price { get; set; }   
         public string PictureUrl { get; set; } 
         public string Type { get; set; }   
         public string Brand { get; set; }  
         
    }
}