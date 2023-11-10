using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementOfGymRivkiToledano.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Classes : ControllerBase
    {
        public static List<Class> classList = new List<Class>() {
        new Class(){ClassId=Class.Count, Day = "Monday",Hour = 9.5,NumOfParticipants = 10,Guide = "Avi", Name = "TennegerGroup",AgeAppropriate=15},
        new Class()  {ClassId=Class.Count,Day = "Tuesday",Hour = 14.25, NumOfParticipants = 8,Guide = "Yahir",  Name = "YungerGroup",AgeAppropriate=30 },
        new Class(){ClassId = Class.Count,  Day = "Wednesday", Hour = 11.75, NumOfParticipants = 12,Guide = "Gali", Name = "OldGroup",AgeAppropriate=70 }};


        // GET: api/<Class>
        [HttpGet]
        public List<Class> Get()
        {
            return classList;
        }

        // GET api/<Class>/5
        [HttpGet("{id}")]
        public Class Get(int id)
        {
            return classList[id];
        }

        // POST api/<Class>
        [HttpPost]
        public void Post([FromBody] Class value)
        {
            classList.Add(value);   
        }

        // PUT api/<Class>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Class value)
        {
            Class c = classList.Find(x => x.ClassId == id);
             c.Name=value.Name;
            c.Hour=value.Hour;
            c.NumOfParticipants=value.NumOfParticipants;
            c.AgeAppropriate=value.AgeAppropriate;
            

        }

        // DELETE api/<Class>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            classList.Remove(classList.Find(x => x.ClassId == id));
        }
    }
}
