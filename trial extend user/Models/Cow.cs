using System.ComponentModel.DataAnnotations.Schema;

namespace trial_extend_user.Models
{
    public class Cow
    {
        public int CowId { get; set; }
        public string CowName { get; set;}
        public string Breed { get; set; }
        public int TagNo { get; set; }
        public string Gender { get; set; }
        public string Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEntry { get; set;}
        public string  Group { get; set;}
        public string Source { get; set; }
        public string MotherTag { get; set; }
        public string FatherTag { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Farm")]
        public  int FarmId { get; set; }
        public Farm? Farm { get; set; }
    }
}
