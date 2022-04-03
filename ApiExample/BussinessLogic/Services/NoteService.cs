using ApiExample.BussinessLogic.Interfaces;
using ApiExample.BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Services
{
    public class NoteService : INoteService
    {
        public Task<NoteInformationBlo> Add(NoteInformationBlo noteInformationBlo, string token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id, string token)
        {
            throw new NotImplementedException();
        }

        public Task<NoteInformationBlo> Get(int id, string token)
        {
            throw new NotImplementedException();
        }

        public Task<List<NoteInformationBlo>> GetAll(string token)
        {
            throw new NotImplementedException();
        }

        public Task<NoteInformationBlo> Update(int id, NoteUpdateBlo noteUpdateBlo, string token)
        {
            throw new NotImplementedException();
        }
    }
}
