namespace trial_extend_user.Models
{
    public class Milk
    {
        public int Id { get; set; }
        public DateOnly MilkingDate { get; set; }
        public string type { get; set; }
        public int AmTotal { get; set; }
        public int PmTotal { get; set; }
        public int TotalMilkProduced { get; set; }
        public int TotalUsed { get; set; }

    }
}
