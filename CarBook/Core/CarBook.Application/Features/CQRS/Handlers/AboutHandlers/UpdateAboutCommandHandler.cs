﻿using CarBook.Application.Features.CQRS.Commands.AboutCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.AboutID);

            value.Title = command.Title;
            value.Description = command.Description;
            value.ImageURl = command.ImageURl;

            await _repository.UpdateAsync(value);


        }
    }
}
