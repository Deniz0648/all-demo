using FluentValidation;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            const string ErrorMessage = "Boş Olamaz!";
            RuleFor(p => p.ProductName).NotEmpty().WithMessage(ErrorMessage);
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage(ErrorMessage);
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage(ErrorMessage);
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage(ErrorMessage);
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage(ErrorMessage);

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
        }
    }
}
