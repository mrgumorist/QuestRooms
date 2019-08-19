using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Entities
{
    [Table("Country")]
    class Country
    {
        [Key]
        public int ID;
        [Required]
        public string Name;
    }
}
