using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using Vacation.Data.TimeOffs;

namespace Vacation.Data
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.LedTeams = new HashSet<Team>();
            this.PaidTimeOffRequests = new HashSet<PaidTimeOff>();
            this.UnpaidTimeOffRequests = new HashSet<UnpaidTimeOff>();
            this.SickTimeOffRequests = new HashSet<SickTimeOff>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<Team> LedTeams { get; set; }

        public virtual ICollection<PaidTimeOff> PaidTimeOffRequests { get; set; }

        public virtual ICollection<UnpaidTimeOff> UnpaidTimeOffRequests { get; set; }

        public virtual ICollection<SickTimeOff> SickTimeOffRequests { get; set; }

    }
}
