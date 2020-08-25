using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using moviesnow.Models;
using Microsoft.AspNetCore.Identity;


namespace moviesnow.Controllers     //be sure to use your own project's namespace!
{
    public class LogRegController : Controller   
    {
        private MyContext _context;

        public LogRegController(MyContext context)
        {
            _context = context;
        }

        //for each route this controller is to handle:
        [HttpGet("login")]     //Http Method and the route
        public IActionResult Login() //When in doubt, use IActionResult
        {
            return View("Login"); //or whatever you want to return
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User user)
        {
            // User user = form.RegForm;
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return Register();
                }

                //Hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                //Adding user to database
                _context.Add(user);
                _context.SaveChanges();

                //Adding UserId to Session
                HttpContext.Session.SetInt32("UserId", user.UserId);

                //Send to sucess page
                return RedirectToAction("Dashboard", "Home");
            }
            return Register();
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginUser user)
        {
            // LoginUser user = form.LoginForm;
            if (ModelState.IsValid)
            {
                //Get user from db
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);

                //Check if returned user equals null
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email2", "Invalid Email/Password");
                    return Login();
                }

                //Initialize Hasher
                var hasher = new PasswordHasher<User>();

                var result = hasher.VerifyHashedPassword(userInDb, userInDb.Password, user.Password);

                if (result == 0)
                {
                    ModelState.AddModelError("Email2", "Invalid Email/Password");
                    return Login();
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard", "Home");
            }

            return Login();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
