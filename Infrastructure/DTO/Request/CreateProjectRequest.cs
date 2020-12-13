using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO.Request
{
    public class CreateProjectRequest
    {
        public long AppId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Lead { get; set; }
    }

    public class CreateProjectRequestValidator : AbstractValidator<CreateProjectRequest>
    {
        public CreateProjectRequestValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
            RuleFor(o => o.Description).NotEmpty();
        }
    }
}
