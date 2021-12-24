using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private UserManager<IdentityUser> _userManager;

        private RoleManager<IdentityRole> _roleManager;
        public UsersRepository()
        {
            Initialize();
        }

        public async Task<User> CreateAsync(User user)
        {
            var a = await _userManager.CreateAsync(new IdentityUser()
            {
                UserName = user.Username
            }, user.Password);

            var createdUser = await _userManager.FindAsync(user.Username, user.Password);
            await _userManager.AddToRoleAsync(createdUser.Id, "User");

            return user;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityUser> GetIdentityUserAsync(User user)
        {
            return await _userManager.FindAsync(user.Username, user.Password);
        }

        public void Initialize()
        {
            var userStore = new UserStore<IdentityUser>();
            _userManager = new UserManager<IdentityUser>(userStore);

            var roleStore = new RoleStore<IdentityRole>();
            _roleManager = new RoleManager<IdentityRole>(roleStore);

            _roleManager.Create(new IdentityRole() { Name = "Admin" });
            _roleManager.Create(new IdentityRole() { Name = "User" });

            if (_userManager.Find("Admin435", "epam2021") == null)
            {
                _userManager.Create(new IdentityUser()
                {
                    UserName = "Admin435"
                }, "epam2021");
            }
            if (_userManager.Find("User1242", "epam2021") == null)
            {
                _userManager.Create(new IdentityUser()
                {
                    UserName = "User1242"
                }, "epam2021");
            }

            var user1 = _userManager.Find("Admin435", "epam2021");
            var user2 = _userManager.Find("User1242", "epam2021");
            _userManager.AddToRole(user1.Id, "Admin");
            _userManager.AddToRole(user2.Id, "User");
        }

        public Task<bool> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
