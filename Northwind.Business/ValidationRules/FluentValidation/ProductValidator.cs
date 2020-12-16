using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entites.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı girin");
            //RuleFor(p => p.CategoryId).NotEmpty();
            //RuleFor(p => p.UnitPrice).NotEmpty();
            //RuleFor(p => p.UnitsInStock).NotEmpty();
            //RuleFor(p => p.QuantityPerUnit).NotEmpty();

            //RuleFor(p => p.UnitPrice).GreaterThan(0);
            //RuleFor(p => p.UnitsInStock).GreaterThan((short) 0);
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

            //RuleFor(p => p.ProductName).Must(StartsWithA).WithMessage("Ürün adı A ile başlamalı"); //Kendimiz bu şekilde kural ekleyebiliriz
        }

        //private bool StartsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
