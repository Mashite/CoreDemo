using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name can't be empty!");
            //RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Writer mail can't be empty!");
            //RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Writer password can't be empty!")
            //                              .Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir harf ve bir sayı içermelidir!");

            //RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Writer name should be atleast 2 character!");
            //RuleFor(x=>x.WriterImage).Length(5, 20).WithMessage("Dosya yolu 5 ile 20 karakter arasında olmalıdır!");

        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}
