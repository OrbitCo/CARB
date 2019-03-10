using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAQM.Entities;

namespace CAQM.IServices
{
    public interface IFileDataService
    {
        bool AddFile(FileData _fileData);
    }
    
}