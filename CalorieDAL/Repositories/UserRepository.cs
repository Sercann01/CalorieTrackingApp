using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDAL.Repositories
{
    public class UserRepository
    {
        CalorieTrackingAppDbContext context;
        public UserRepository()
        {
            context = new CalorieTrackingAppDbContext();  
            
        }


        public User CheckLogin(string UserMail, string Password)
        {
            User user = context.User.Where(a => a.Usermail == UserMail).SingleOrDefault();
            if (user == null)
            {
                return null;
            }
            if (user.Password == Password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public User CheckLogin(int ID)
        {
            User user = context.User.Where(a => a.UserID == ID).SingleOrDefault();
            if (user == null)
            {
                return null; 
            }         
            else
            {
                return user;
            }
           
        }

        public bool Insert(User user)
        {
            context.User.Add(user);
            return context.SaveChanges() > 0;
        }

        public bool Update(User User, int oldUserId)
        {
            User user = context.User.Where(a => a.UserID == oldUserId).SingleOrDefault();

            user.Name = User.Name;
            user.Surname = User.Surname;
            user.Gender = User.Gender;
            user.Height = User.Height;
            user.Weight = User.Weight;
            user.Age = User.Age;
            user.SportBackground = User.SportBackground;
            user.Usermail = User.Usermail;
            user.Password = User.Password;

            return context.SaveChanges() > 0;

        }
    }
}
