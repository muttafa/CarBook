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
    public class GetTestimonialHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {

        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetTestimonialQueryResult
            {
                Comment = x.Comment,
                ImageURl = x.ImageURl,
                Name = x.Name,
                TestimonialID = x.TestimonialID,
                Title = x.Title,
            }).ToList();
        }
    }
}
