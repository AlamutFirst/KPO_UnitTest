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
        public Table GetFirstItem()
        {
            return _userRepository.GetFirstItem();
        }
        public Table GetUserByName(string name)
        {
            return _userRepository.GetUserByName(name);
        }
        public Table GetUserByAddres(string address)
        {
            return _userRepository.GetUserByAddres(address);
        }
        public Table GetUserByAddresAndName(string address, string name)
        {
            return _userRepository.GetUserByAddresAndName(address, name);
        }
    }
}
