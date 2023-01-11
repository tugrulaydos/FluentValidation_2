using FluentValidation;

namespace FluentValidation_2.Models.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //RuleFor(x => x.Email).NotNull().WithMessage("Email Alanı Boş Geçilemez.");

            //RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru Bir Email Adresi Giriniz.");

            //RuleFor(x => x.Quantity).NotNull().WithMessage("Quantity Alanı'nı Boş Geçmeyiniz.");

            //RuleFor(x => x.ProductName).NotNull().WithMessage("Product Name Alanı'nı Boş Geçmeyiniz.");

            //RuleFor(x => x.ProductName).MaximumLength(2).WithMessage("Product Name Maksimum 2 Karakter Olmalıdır.");

            RuleFor(x => x.Email).NotNull();

            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Quantity).NotNull();

            RuleFor(x => x.ProductName).NotNull();

            RuleFor(x => x.ProductName).MaximumLength(2);

        }

    }
}
