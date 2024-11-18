using WebApplication2.Data;

namespace WebApplication2.repo
{
    public class userRepo:user
    { 
        
            private readonly AppDbContext _context;
            public userRepo(AppDbContext context)
            {
                _context = context;
            }
            public void addUser(dto user)
            {
                var u = new user
                {
                    email = user.email,
                    name = user.name,
                };
                _context.Add(user);
                _context.SaveChanges();
            }
            public void deleteUser(int id)
            {
                var user = _context.Users.FirstOrDefault(x => x.id == id);
                if (user != null)
                {
                    _context.Remove(user);
                    _context.SaveChanges();
                }
            }
            public user getUserById(int id)
            {
                return _context.Users.FirstOrDefault(x => x.id == id);
            }
            public void updateUser(dto dTOuser, int id)
            {
                var users = _context.Users.FirstOrDefault(x => x.id == id);
                users.email = dTOuser.email;
                users.name = dTOuser.name;
                _context.Update(dTOuser);
                _context.SaveChanges();
            }

        }

}
