using FluentValidation_2.Models.ModelMetadataTypes;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace FluentValidation_2.Models
{
    public class Product
    {        
        //Validasyonlar genelikle ViewModel'lerde uygulanır.
        //Sorumluluğu başka bir sınıfa yüklemeliyiz diğer şekilde solid'e aykırı bir işlem yapımış oluruz.(Single Responsibility.)    
        public string ProductName { get; set; }
        public string Quantity { get; set; }      
        public string Email { get; set; }

    }
}
