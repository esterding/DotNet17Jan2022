using ManyToMany.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Services
{
    public class IRepoUser : IRepo<int, Models.User>
    {
        private readonly ManyToManyContext _context;

        public IRepoUser(ManyToManyContext context)
        {
            _context = context;
        }
        public bool Create(User user)
        {
            _context.Add(user);

            User u = user;
            _context.Add(u);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int k)
        {
            User u = _context.Users.FirstOrDefault(p => p.Id == k);
            if (u != null)
            {
                _context.Users.Remove(u);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public User Get(int k)
        {
           User user = _context.Users.FirstOrDefault(p => p.Id == k);
            //user.Interests = _context.UserInterests.Join()
            user.Interests = (ICollection<Interest>)_context.UserInterests.Join(_context.Interests, ut => ut.InterestId, i => i.Id, (ut, i) => new
            {
                InterestId = i.Id,
                InterestName = i.InterestName
            }).Where( ut => ut.InterestId == k).ToList();

            return user;

        }

        public ICollection<User> GetAll()
        {
            List<User> Users = _context.Users.ToList();
            foreach(var u in Users)
            {
                u.Interests = (ICollection<Interest>)_context.UserInterests.Join(_context.Interests, ut => ut.InterestId, i => i.Id, (ut, i) => new
                {
                    InterestId = i.Id,
                    InterestName = i.InterestName
                }).Where(ut => ut.InterestId == u.Id).ToList();
            }
            return Users;
        }


        public bool Update(int k, User t)
        {
            throw new NotImplementedException();
        }
    }
}
