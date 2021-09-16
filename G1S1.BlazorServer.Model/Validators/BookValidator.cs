using FluentValidation;
using System;

namespace G1S1.BlazorServer.Model.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ingrese un nombre.");
            RuleFor(x => x.Name).Length(5, 100).WithMessage("El Nombre debe ser mayor a 5 y menor a 100 letras.");
            RuleFor(x => x.AuthorId).NotEmpty().WithMessage("Seleccione un autor.");
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Seleccione un género.");
            RuleFor(x => x.PublishDate).LessThan(DateTime.Today).WithMessage("La fecha debe ser menor a la actual.");
            RuleFor(x => x.Price).LessThan(0).WithMessage("El valor no es válido.");
            RuleFor(x => x.Pages).LessThan(5).WithMessage("El valor debe ser mayor a 5.");
            //RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Please specify a valid email");
        }
    }
}
