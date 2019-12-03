using KSD.UI.Client.Interfaces;
using KSD.UI.Shared;
using KSD.UI.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSD.UI.Client.Services
{
   

    public class KsdService : IKsdService
    {
        private readonly HttpClient _httpClient;

        public KsdService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Response> AddStudent(StudentDto dto)
        {
            return await _httpClient.PostJsonAsync<Response>("api/ksd", dto);
        }
        public async Task<Response> AddParent(Guid id, ParentDto dto)
        {
            return await _httpClient.PostJsonAsync<Response>($"api/ksd/{id}", dto);
        }
    }
}
