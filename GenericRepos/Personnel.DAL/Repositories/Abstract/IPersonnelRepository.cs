using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Personnel.Domains;
namespace Personnel.DAL.Repositories.Abstract
{
    public interface IPersonnelRepository: IRepository<Personnel.Domains.Personnel>
    {
        IEnumerable<Personnel.Domains.Personnel> GetTopPersonels(int count);
        
         
    }
}