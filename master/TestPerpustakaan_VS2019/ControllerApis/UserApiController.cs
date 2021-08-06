using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

using TestPerpustakaan_VS2019.Models;
using TestPerpustakaan_VS2019.Library;
using TestPerpustakaan_VS2019.Library.DataAccess;
using TestPerpustakaan_VS2019.Library.Utilities;
using TestPerpustakaan_VS2019.Library.Entities;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace TestPerpustakaan_VS2019.ControllerApis
{
    [Route("api/[controller]")]
    public class UserApiController : Controller
    {

        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;

        public UserApiController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: api/<controller>
        [HttpGet]
        [Route("GetList")]
        public ActionResult<List<UserEntity.User>> Gets()
        {

            var userList = context.Users.ToList();

            return userList;
        }

        // GET: api/<controller>/MultipleIDr
        [HttpGet]
        [Route("GetListByFilter")]
        public ActionResult<List<UserEntity.User>> GetsFilter(string name, string email, string isActive)
        {

            var userList = context.Users.Where(x => x.UserName.Contains(name) ||
                            x.Email.Contains(email) ||
                            x.IsActive == Convert.ToBoolean(isActive)).ToList();
           
            return userList;
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("GetById={id}")]
        public ActionResult<UserEntity.User> Get(long id)
        {
            var user = context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("GetByEmail={email}")]
        public ActionResult<UserEntity.User> GetEmail(string email)
        {
            var user = context.Users.Where(x => x.Email == email).Single();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST api/<controller>
        [HttpPost]
        [Route("CreateNew")]
        public void Post([FromBody] UserEntity.User user)
        {

            context.Entry(user).State = EntityState.Added;
            context.Users.Add(user);
            context.SaveChanges();

            CreatedAtAction(nameof(user), new { id = user.ID }, user);
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Route("UpdateById={id}")]
        public void Put(long id, [FromBody] UserEntity.User user)
        {
            
            if (id != user.ID)
            {
                BadRequest();
                return;
            }

            context.Entry(user).State = EntityState.Modified;
            context.Update(user);
            context.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("DeleteById={id}")]
        public void Delete(long id)
        {

            var user = context.Users.Find(id);

            if (user == null)
            {
                NotFound();
                return;
            }

            context.Users.Remove(user);
            context.SaveChanges();
        }

        // POST api/<controller>
        //[HttpPost]
        //[Route("POST-api-Authenticate")]
        //public void PostADUser([FromBody] UserEntity.User user)
        //{

        //    var userList = context.Users.ToList();

        //    return userList;
        //}

    }
}
