namespace Vacation.Data
{
    public class Team : BaseEntity
    {
        public Team()
        {
            this.Developers = new HashSet<AppUser>();
        }
        public string Name { get; set; }

        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public string? TeamLeadId { get; set; }

        public virtual AppUser TeamLead { get; set; }

        public virtual ICollection<AppUser> Developers { get; set; }

    }
}
