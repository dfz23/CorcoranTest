using PersitenceService.Common.DTO;

namespace WebAPI.Models
{
    public class PresidentViewModel
    {
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Birthplace { get; set; }
        public string DeathDay { get; set; }
        public string DeathPlace { get; set; }

        public PresidentViewModel(PresidentDTO objPresident)
        {
            this.FullName = objPresident.FullName;
            this.Birthday = objPresident.Birthday.ToShortDateString();
            this.Birthplace = objPresident.Birthplace;
            this.DeathDay = objPresident.DeathDay.ToShortDateString();
            this.DeathPlace = objPresident.DeathPlace;
        }
    }
}