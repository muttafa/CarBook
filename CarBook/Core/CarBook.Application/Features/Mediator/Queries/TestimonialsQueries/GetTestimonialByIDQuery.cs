﻿using CarBook.Application.Features.Mediator.Results.TestimonialsResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialsQueries
{
    public class GetTestimonialByIDQuery : IRequest<GetTestimonialByIDQueryResult>
    {
        public int TestimonialID { get; set; }

        public GetTestimonialByIDQuery(int testimonialID)
        {
            TestimonialID = testimonialID;
        }
    }
}
