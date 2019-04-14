using System.ComponentModel.DataAnnotations;

namespace MiniProjectCourseApp2.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsim alanı zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage="Email adresi giriniz.")]
        [EmailAddress(ErrorMessage="Mail adresinizi doğru formatta giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage="Telefon giriniz.")]
        public string Phone { get; set; }
        
        //true , false(default), ? koyunca nullable oldu null deder de donderebilir
        [Required(ErrorMessage="Katılma durmunuzu belirtiniz.")]
        public bool? Confirm { get; set; }

    }
}