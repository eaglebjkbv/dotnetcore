using Personnel.DAL.Repositories.Abstract;
using Personnel.DAL.Repositories.Concrete;
namespace Personnel.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonnelDbContext _personelContext;
        public UnitOfWork(PersonnelDbContext context)
        {
                _personelContext=context;
                PersonnelRepository=new PersonnelRepository(_personelContext);
        }
         public IPersonnelRepository PersonnelRepository { get; private set;}

        public int Complete()
        {
          return  _personelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personelContext.Dispose();

        }

    }
}