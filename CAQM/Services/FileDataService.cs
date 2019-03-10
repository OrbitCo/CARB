using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAQM.Entities;
using CAQM.IServices;

namespace CAQM.Services
{
    
    public class FileDataService : IFileDataService
    {
        private DataContext _context;

        public FileDataService(DataContext context)
        {
            _context = context;
        }

        public bool AddFile(FileData _fileData)
        {
           
                    _context.FileData.Add(_fileData);
                    _context.SaveChanges();
             
            return true;
        }     
    }
}