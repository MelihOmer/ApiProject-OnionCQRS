﻿using ApiProject.Application.Bases;
using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using Bogus;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Application.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandHandler : BaseHandler, IRequestHandler<CreateBrandCommandRequest, Unit>
    {
        public CreateBrandCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContext) : base(mapper, unitOfWork, httpContext)
        {
        }

        public async Task<Unit> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            Faker faker = new("tr");
            List<Brand> brands = new();
            for (int i = 0; i < 1000000; i++)
            {
                brands.Add(new(faker.Commerce.Department(1)));
            }
            await unitOfWork.GetWriteRepository<Brand>().AddRangeAsync(brands);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
