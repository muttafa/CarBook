using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.TestimonialCommand
{
    public class RemoveTestimonialCommand  :IRequest
    {
        public int TestimonialID { get; set; }

        public RemoveTestimonialCommand(int testimonialID)
        {
            TestimonialID = testimonialID;
        }
    }
}
