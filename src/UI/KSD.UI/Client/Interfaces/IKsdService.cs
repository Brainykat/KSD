using KSD.UI.Shared;
using KSD.UI.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSD.UI.Client.Interfaces
{
    public interface IKsdService
    {
        Task<Response> AddParent(Guid id, ParentDto dto);
        Task<Response> AddStudent(StudentDto dto);
    }
}
