﻿using AutoMapper;
using PortalWeb.Application.System.Mappings;
using PortalWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalWeb.Application.Categories.Queries.Model
{
    public class CategoryDto : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryDto>()
                .ForMember(c => c.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(c => c.Description, opt => opt.MapFrom(d => d.Description))
                .ForMember(c => c.Name, opt => opt.MapFrom(d => d.Name));
        }
    }
}
