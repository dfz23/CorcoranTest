using System;

namespace PersitenceService.Common.DTO
{
    public class PresidentDTO
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public DateTime DeathDay { get; set; }
        public string DeathPlace { get; set; }
    }
}
