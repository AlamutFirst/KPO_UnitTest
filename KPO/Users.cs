using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    public class Users
    {
        ITable _userRepository;
        public Users(ITable userRepository)
        {
            _userRepository = userRepository;
        }
        public IEnumerable<Table> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
