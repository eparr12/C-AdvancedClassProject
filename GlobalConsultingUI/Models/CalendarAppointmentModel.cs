using System;

namespace GlobalConsultingUI.Models
{
    public class CalendarAppointmentModel
    {
        public string Customer { get; set; }
        public string User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}
