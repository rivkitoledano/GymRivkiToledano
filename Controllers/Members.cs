using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementOfGymRivkiToledano.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Members : ControllerBase
    {
        public static List<Member> memberList = new List<Member>()
    {
        new Member() {MemberId=Member.Count, Name = "eli", Age = 25 },
        new Member() { MemberId=Member.Count,Name = " Daniel", Age = 30 },
        new Member() {MemberId=Member.Count, Name = "Michael", Age = 45 },
        new Member() {MemberId=Member.Count, Name = "Sarah", Age = 35 },
        new Member() {MemberId=Member.Count,Name = "David", Age = 28 }
    };
        // GET: api/<Members>
        [HttpGet]
        public List<Member> Get()
        {
            return memberList;
        }

        // GET api/<Members>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return memberList[id];
        }

        // POST api/<Members>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            memberList.Add(value);
        }

        // PUT api/<Members>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member value)
        {
            Member m = memberList.Find(x => x.MemberId == id);
            m.Name = value.Name;
            m.Age=value.Age;
        }

        // DELETE api/<Members>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            memberList.Remove(memberList.Find(x => x.MemberId == id));

        }
    }
}
