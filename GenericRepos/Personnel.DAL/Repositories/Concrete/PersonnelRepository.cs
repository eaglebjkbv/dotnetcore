using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Personnel.DAL;
using Personnel.Domains;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Personnel.DAL.Repositories.Abstract;

namespace Personnel.DAL.Repositories.Concrete
{
    public class PersonnelRepository: Repository<Personnel.Domains.Personnel>,IPersonnelRepository
    {
        public PersonnelRepository(PersonnelDbContext context): base(context)
        {
            
        }
        public IEnumerable<Personnel.Domains.Personnel> GetTopPersonels(int count)
        {
            return personnelContext.Personnels.Take(count);
        }
        public PersonnelDbContext personnelContext { get{return _context as PersonnelDbContext;} }
        
    }
}