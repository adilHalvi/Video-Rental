using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_1.Models;
using Vidly_1.Dtos;

namespace Vidly_1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /*  Property ‘Id’ is part of object’s key information and cannot be modified.
                This exception happens at the following line: Mapper.Map(movieDto,movie);
                The exception is thrown when AutoMapper attempts to set the Id of movie:
                customer.Id = customerDto.Id;
                Id is the key property for the Movie class, and a key property should not be changed.
                That’s why we get this exception. To resolve this, you need to tell AutoMapper to ignore
                Id during mapping of a MovieDto to Movie.

                In MappingProfile:
                CreateMap<Movie,MovieDto>().ForMember(m=>m.Id,opt=>opt.Ignore());*/
                
            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}