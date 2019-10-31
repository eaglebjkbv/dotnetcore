using System;
using Personnel.DAL.Repositories.Abstract;
namespace Personnel.DAL
{
    public interface IUnitOfWork: IDisposable
    {
        IPersonnelRepository PersonnelRepository { get;}

        int Complete();
    
    }
}