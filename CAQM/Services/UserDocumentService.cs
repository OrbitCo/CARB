using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAQM.Entities;
using CAQM.IServices;

namespace CAQM.Services
{
    
    public class UserDocumentService : IUserDocumentService
    {
        private DataContext _context;

        public UserDocumentService(DataContext context)
        {
            _context = context;
        }

        public UsersDocument GetById(int userId, string filename)
        {
            return _context.UsersDocument.AsQueryable()
                .Where(x=> x.UserId == userId && x.FileName == filename)
                .FirstOrDefault();
        }

        public UsersDocument Create(UsersDocument usersDocument)
        {
            _context.UsersDocument.Add(usersDocument);
            _context.SaveChanges();

            return usersDocument;
        }

        public void Delete(int id)
        {
            var usersDocument = _context.UsersDocument.Find(id);
            if (usersDocument != null)
            {
                _context.UsersDocument.Remove(usersDocument);
                _context.SaveChanges();
            }
        }
    }
}
