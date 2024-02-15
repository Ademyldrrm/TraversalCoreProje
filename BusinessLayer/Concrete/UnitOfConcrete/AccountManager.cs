using BusinessLayer.Abstract.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UnitOfConcrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _ofWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal ofWorkDal)
        {
            _accountDal = accountDal;
            _ofWorkDal = ofWorkDal;
        }

        public Account TGetById(int id)
        {
           return _accountDal.GetById(id);
            
        }

        public void TInsert(Account t)
        {
           _accountDal.Insert(t);
            _ofWorkDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _ofWorkDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _ofWorkDal.Save();
        }
    }
}
