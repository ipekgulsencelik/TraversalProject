using FluentValidation;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz...!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 Karakterlik Açıklama Bilgisi Giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen Açıklama Bilgisini Kısaltınız...!");
        }
    }
}