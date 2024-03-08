using CarBook.Application.Features.Mediator.Queries.TestimonialsQueries;
using CarBook.Application.Features.Mediator.Results.TestimonialsResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIDQueryHandler : IRequestHandler<GetTestimonialByIDQuery, GetTestimonialByIDQueryResult>
    {

        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIDQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIDQueryResult> Handle(GetTestimonialByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TestimonialID);

            return new GetTestimonialByIDQueryResult
            {
                TestimonialID = values.TestimonialID,
                Comment = values.Comment,
                ImageURl = values.ImageURl,
                Name = values.Name,
                Title = values.Title,
            };
        }
    }
}
