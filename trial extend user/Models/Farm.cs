using trial_extend_user.Data;

namespace trial_extend_user.Models
{
    public class Farm
    {
        public int ID { get; set; }
        public string FarmName { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string SubscriptionStatus { get; set; }

    }
}
