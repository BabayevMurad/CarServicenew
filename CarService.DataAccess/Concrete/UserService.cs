﻿using CarService.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Concrete
{
    public class UserService : IUserService
    {
        //private readonly AppDataContext _context;

        //public UserService(AppDataContext context)
        //{
        //    _context = context;
        //}

        //public async void AddUserMoney(int userId, decimal money)
        //{
        //    var user = await _context.Users
        //        .FirstOrDefaultAsync(u => u.Id == userId);

        //    if (user is not null)
        //    {
        //        user.Money = user.Money + money;

        //        _context.Users.Update(user);

        //        await _context.SaveChangesAsync();
        //    }
        //}

        //public async void UserPay(int userId, decimal money)
        //{
        //    var user = await _context.Users
        //        .FirstOrDefaultAsync(u => u.Id == userId);

        //    if (user is not null)
        //    {
        //        if (user.Money >= money)
        //        {
        //            user.Money = user.Money - money;

        //            _context.Users.Update(user);

        //            await _context.SaveChangesAsync();
        //        }

        //    }
        //}
    }
}
