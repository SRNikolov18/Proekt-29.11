using System.ComponentModel.DataAnnotations.Schema;

namespace Vacation.Data.TimeOffs
{
    public class SickTimeOff : BaseTimeOff
    {
        public string AttachmentPath { get; set; }

        [NotMapped] //няма да бъде в базата за съответната таблица
        public override bool IsHalfDay { get; set; }
    }
}
