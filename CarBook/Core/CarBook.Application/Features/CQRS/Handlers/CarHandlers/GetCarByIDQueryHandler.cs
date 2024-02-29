using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIDQueryHandler
    {
        private readonly IRepository<Car> _repository ;

        public GetCarByIDQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIDQueryResult> Handle(GetCarByIDQuery query)
        {
            var values = await _repository.GetByIdAsync(query.CarId);
            return new GetCarByIDQueryResult { 
                CarId = values.CarId, 
                BigImageURL = values.BigImageURL,
                BrandID = values.BrandID,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission,
            };
        }
    }
}
