using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Title can't be empty!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Content can't be empty!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Image can't be empty!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Title can't be longer than 150");

        }
    }
}
