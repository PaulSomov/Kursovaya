using System.ComponentModel.DataAnnotations;

namespace KR1
{
    public class App_Code
    {
        public enum TimeOfDay
        {
            [Display(Name = "Утро")]
            Morning,
            [Display(Name = "День")]
            Afternoon,
            [Display(Name = "Вечер")]
            Evening,
            [Display(Name = "Ночь")]
            Night
        }
    }
}
