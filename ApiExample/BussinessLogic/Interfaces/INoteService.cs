using ApiExample.BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Interfaces
{
    public interface INoteService
    {
        Task<NoteInformationBlo> Add(NoteInformationBlo noteInformationBlo, string token);
        Task<NoteInformationBlo> Get(int id, string token);
        Task<List<NoteInformationBlo>> GetAll(string token);
        Task<NoteInformationBlo> Update(int id, NoteUpdateBlo noteUpdateBlo, string token);
        Task<bool> Delete(int id, string token);
    }
}
