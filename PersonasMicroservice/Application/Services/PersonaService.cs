﻿using PersonasMicroservice.Api.DTOs;
using PersonasMicroservice.Domain.Entities;
using PersonasMicroservice.Infrastructure.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonasMicroservice.Application.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public Task<List<Persona>> GetAll()
        {
            var personas = _personaRepository.GetAll();
            return personas;
        }

        public Task<PersonaDTO> GetById()
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Create(PersonaDTO personaDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Update(int Id, PersonaDTO personaDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Delete(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}