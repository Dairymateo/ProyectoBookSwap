using System.ComponentModel.DataAnnotations;

namespace ProyectoBookSwap.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required] 
        public string Email { get; set; }
        [Length(10)]
        public string PhoneNumber { get; set; }
        

       



        //Define la etiqueda Length
        [AttributeUsage(AttributeTargets.Property)]
        public class LengthAttribute : Attribute
        {
            public int MaxLength { get; }

            public LengthAttribute(int maxLength)
            {
                MaxLength = maxLength;
            }
        }
    }
}
