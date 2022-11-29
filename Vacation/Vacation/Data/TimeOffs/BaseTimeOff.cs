namespace Vacation.Data.TimeOffs
{
    public abstract class BaseTimeOff : BaseEntity
    {
        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual bool IsHalfDay { get; set; }

        public bool IsApproved { get; set; }

        public string RequestorId { get; set; }
        public virtual AppUser Requestor { get; set; }
    }
}
