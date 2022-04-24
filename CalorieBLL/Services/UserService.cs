using CalorieDAL.Repositories;
using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieBLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public User CheckLogin (string UserMail, string Password)
        {
            if (string.IsNullOrEmpty(UserMail) || string.IsNullOrEmpty(Password))
            {
                throw new Exception("Kullanıcı Bilgilerini Kontrol Ediniz.");                
            }

            return userRepository.CheckLogin(UserMail, Password);           
        }
        public User CheckLogin(int ID)
        {
            return userRepository.CheckLogin(ID);
        }

        public bool Insert(User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Surname) || string.IsNullOrEmpty(user.Usermail) || string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("İsim, Soyisim, Kullanıcı Maili yada Şifre bilgilerinden birisi boş geçilemez");
            }
            return userRepository.Insert(user);
        }

        public bool Update(User User, int oldUserId)
        {
            return userRepository.Update(User, oldUserId);
        }


            bool buyukmu = false;
            bool rakammi = false;
            bool harfmi = false;
        public bool PasswordCheckControl(string password)
        {
            bool PasswordCheck = false;

            PasswordControlPart(password);

            if (rakammi && harfmi && buyukmu)
            {
                PasswordCheck = true;
            }
            else if ((rakammi && harfmi) || (rakammi && buyukmu) || (harfmi && buyukmu))
            {                
                PasswordCheck = false;
            }
            else if (rakammi || harfmi || buyukmu)
            {              
                PasswordCheck = false;
            }

            return PasswordCheck;
        }

        public int PasswordStrengthControl(string Password)
        {
            int passwordstrength = 0;

            PasswordControlPart(Password);

            if (rakammi && harfmi && buyukmu)
            {
                passwordstrength = 1;
            }
            else if ((rakammi && harfmi) || (rakammi && buyukmu) || (harfmi && buyukmu))
            {
                passwordstrength = 2;
            }
            else if (rakammi || harfmi || buyukmu)
            {
                passwordstrength = 3;
            }

            return passwordstrength;
        }

        public void PasswordControlPart (string password)
        {
            buyukmu = false;
            harfmi = false;
            rakammi = false;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    rakammi = true;                    
                }
                if (char.IsLetter(item))
                {
                    harfmi = true;                    
                }
                if (char.IsUpper(item))
                {
                    buyukmu = true;
                }
            }
            
        }

        public bool UserMailControl(string mail)
        {
            
            if (mail.EndsWith(".com") && mail.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }














    }
}
