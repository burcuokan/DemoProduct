using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidation
{
   public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri bilgisi boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez");
        }
    }
}
