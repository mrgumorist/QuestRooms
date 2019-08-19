using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    [Table("Adress")]
    public class Adress
    {
        [Key]
        public int ID;
        [Required]
        public int CountryID;
        [Required]
        public int CityID;
        [Required]
        public int StreetID;
        string HouseNum;
    }
}
