﻿using FluentValidation;
using NeoCA.Application.Contracts.Persistence;
using NeoCA.Application.Helper;

namespace NeoCA.Application.Features.Categories.Commands.StoredProcedure
{
    public class StoredProcedureCommandValidator: AbstractValidator<StoredProcedureCommand>
    {
        private readonly IMessageRepository _messageRepository;
        public StoredProcedureCommandValidator(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(GetMessage("1", ApplicationConstants.LANG_ENG))
                .NotNull()
                .MaximumLength(10).WithMessage(GetMessage("2", ApplicationConstants.LANG_ENG));
        }

        private string GetMessage(string Code, string Lang)
        {
            return _messageRepository.GetMessage(Code, Lang).Result.MessageContent.ToString();
        }
    }
}
