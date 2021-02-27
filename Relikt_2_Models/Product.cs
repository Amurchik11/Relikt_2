using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Relikt_2_Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Название")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Краткое Описание")]
        public string ShortDesc { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        [DisplayName("Цена")]
        public double Price { get; set; }
        public string Image { get; set; }
        [Display(Name = "Тип Категории")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Тип Товара")]
        public int ApplicationTypeId { get; set; }
        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }

        [Display(Name = "Размер Товара")]
        public int SizeTypeId { get; set; }
        [ForeignKey("SizeTypeId")] 
        public virtual SizeType SizeType { get; set; }
        public InquiryDetail InquiryDetail { get; set; }
    }
}
