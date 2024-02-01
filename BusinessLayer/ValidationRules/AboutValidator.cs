using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
                RuleFor(x=>x.Description1).NotEmpty().WithMessage("Açıllama Kısmını Boş Geçemezsin");
                RuleFor(x=>x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz...");
                RuleFor(x=>x.Description1).MinimumLength(50).WithMessage("Lütfen en az 50 karakter giriniz");
                RuleFor(x=>x.Description1).MaximumLength(100).WithMessage("Lütfen açıklamayaı kısaltınız");

        }
    }
}
