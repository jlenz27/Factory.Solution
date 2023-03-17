using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId {get; set;}
        [Required(ErrorMessage = "The engineer's name can't be empty.")]

        public string EngineerName {get; set;}
        public List<MachineEngineer> JoinEntities {get; set;}
        }
}