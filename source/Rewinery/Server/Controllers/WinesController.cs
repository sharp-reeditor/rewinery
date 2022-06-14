﻿using Microsoft.AspNetCore.Mvc;
using Rewinery.Server.Core.Models.Wines;
using Rewinery.Server.Infrastructure;
using Rewinery.Shared.Dtos.WinesDtos;

namespace Rewinery.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinesController
    {
        private readonly WineRepository _wineRepository;

        public WinesController(WineRepository ingredientRepository)
        {
            _wineRepository = ingredientRepository;
        }

        [Route("/api/wines/{id}")]
        [HttpGet]
        public async Task<WineReadDto> GetAsync(int id)
        {
            return await _wineRepository.GetAsync(id);
        }
        [HttpGet]
        public async Task<IEnumerable<WineReadDto>> GetListAsync()
        {
            return await _wineRepository.GetAllAsync();
        }

        [HttpPost]
        public async Task<Wine> CreateAsync(WineCreateDto ingredient)
        {
            return await _wineRepository.CreateAsync(ingredient);
        }

        [HttpDelete]
        public async Task<int> DeleteAsync(int id)
        {
            await _wineRepository.DeleteAsync(id);
            return id;
        }
    }
}
