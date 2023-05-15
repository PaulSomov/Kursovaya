using System;
using System.ComponentModel.DataAnnotations;

namespace KR1.Models
{
    public class Application
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Поле 'Имя' является обязательным.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле 'Фамилия' является обязательным.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле 'Дата рождения' является обязательным.")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Поле 'Пол' является обязательным.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Поле 'Адрес' является обязательным.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Поле 'Номер телефона' является обязательным.")]
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле 'Почта' является обязательным.")]
        [Display(Name = "Почта")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Дата заявки")]
        [DataType(DataType.DateTime)]
        public DateTime ApplicationDate { get; set; }

        [Required(ErrorMessage = "Поле 'Статус' является обязательным.")]
        public string Status { get; set; }
    }
}
