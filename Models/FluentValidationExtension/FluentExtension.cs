using FluentValidation.AspNetCore;
using FluentValidation_2.Models.Validators;

namespace FluentValidation_2.Models.FluentValidationExtension
{
    public static class FluentExtension
    {
        public static IServiceCollection AddFluetAsExtension(this IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssemblyContaining<ProductValidator>();
                x.DisableDataAnnotationsValidation = true;
                x.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");
            });

            return services;

        }

    }
}
