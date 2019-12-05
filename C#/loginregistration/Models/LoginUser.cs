using System.ComponentModel.DataAnnotations;
namespace loginregistration.Models {
    public class LoginUser {
        public string Email {get;set;}
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}