using FluentValidation_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation_2.Controllers
{
    public class ProductController : Controller
    {
        //Validation: Bir degerin icinde bulundugu sartlara uygun olmasi durumudur.
        //Belirlenen koşullara ve amaca uygun olup olmama durmunun kontrol edilmesidir.
        //Bu kontrole göre verinin işeme tabi tutulması durumudur.

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateProduct()
        {

            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModalSatate: Bir Type'ın Data Annotoinslarını kontrol eden ve geriye sonuç dönen bir property'dir.

            if (!ModelState.IsValid)
            {
                //Eğer Geçerli Değilse, işlem yapma modeli takrar döndür.
                
                var messages = ModelState.ToList();
                
                return View(model);
            }
            else
            {
                //İşlem Yap
                return View();
            }

          
        }   

    }
}
