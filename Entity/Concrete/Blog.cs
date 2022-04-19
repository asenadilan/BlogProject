using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Core.Entity;

namespace EntityLayer.Concrete
{
    public class Blog: IEntity
    {
         [Key]
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string  BlogThumbnailImage { get; set; } //Bloğun küçük resmi - dosya yolu tutulacağı için string olarak tanımlandı
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        
    }
}
