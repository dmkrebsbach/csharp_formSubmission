using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using formSubmission.Models;

namespace formSubmission
{
    public class HomeController: Controller
    {
        [HttpGet("")] //This renders the Main Page        
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("createUser")]
        public IActionResult Create(User newUser)
        {
            Console.Write("Is This Getting Here?");
            if(ModelState.IsValid)
            {
                Console.Write("###########It's Valid?#########");
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success", newUser);
            }
            else
            {
                Console.Write("##########It's Not Valid?#########");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }

        [HttpGet("Results")] //This renders the Results Page        
        public ViewResult Success(User newUser)
        {
            return View("Results", newUser);
        }
    }
}