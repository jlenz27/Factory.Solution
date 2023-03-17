using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        [Required(ErrorMessage = "The Machines's name can't be empty.")]

        public List<MachineEngineer> JoinEntities { get; set; }
    }
}