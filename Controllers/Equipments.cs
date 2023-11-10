using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementOfGymRivkiToledano.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Equipments : ControllerBase
    {
        public static List<Equipment> equipmentList = new List<Equipment>()
    {
        new Equipment() {EquipmentId=Equipment.Count, Name = "Item 1", Category = "Category 1", AmountItem = 5 },
        new Equipment() {EquipmentId=Equipment.Count, Name = "Item 2", Category = "Category 2", AmountItem = 10 },
        new Equipment() {EquipmentId=Equipment.Count, Name = "Item 3", Category = "Category 1", AmountItem = 3 },
        new Equipment() {EquipmentId=Equipment.Count, Name = "Item 4", Category = "Category 3", AmountItem = 8 },
        new Equipment() { EquipmentId=Equipment.Count,Name = "Item 5", Category = "Category 2", AmountItem = 6 }
    };


        // GET: api/<Equipment>
        [HttpGet]
        public List<Equipment> Get()
        {
            return equipmentList;
        }

        // GET api/<Equipment>/5
        [HttpGet("{id}")]
        public Equipment Get(int id)
        {
            return equipmentList[id];
        }

        // POST api/<Equipment>
        [HttpPost]
        public void Post([FromBody] Equipment value)
        {
            equipmentList.Add(value);
        }

        // PUT api/<Equipment>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Equipment  updatedEquipment)
        {
            Equipment e = equipmentList.Find(x => x.EquipmentId == id);
            e.Name = updatedEquipment.Name;
            e.Category = updatedEquipment.Category;
            e.AmountItem = updatedEquipment.AmountItem;

        }

        // DELETE api/<Equipment>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            equipmentList.Remove(equipmentList.Find(x => x.EquipmentId == id));

        }
    }
}
