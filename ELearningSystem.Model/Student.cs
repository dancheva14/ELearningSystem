using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Security.AccessControl;
using Resources;

namespace ELearningSystem.Model
{
    public class Student : IPrincipal
    {
        public int Id { get; set; }

        [Display(Name = "strUserName", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceName = "strUserNameError", ErrorMessageResourceType = typeof(Resources.Resource))]

        public string UserName { get; set; }

        [StringLength(255, ErrorMessage = "Паролата трябва да е минимум 6 символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "strPassword", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceName = "strPasswordError", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string Password { get; set; }

        [Display(Name = "strConfirmPassword", ResourceType = typeof(Resources.Resource))]
        // [Required(ErrorMessage = "Полето потвърди парола е задължително.")]
        // [StringLength(255, ErrorMessage = "Паролата трябва да е минимум 6 символа", MinimumLength = 6)]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }

        // [Required]
        [Display(Name = "strFullName", ResourceType = typeof(Resources.Resource))]
        public string FullName { get; set; }

        [Display(Name = "strMail", ResourceType = typeof(Resources.Resource))]
        public string Email { get; set; }

        public IIdentity Identity
        {
            get
            {
                return new GenericIdentity(UserName);
            }
        }

        public bool IsInRole(string role)
        {
            return true;
        }

        public bool IsAdmin { get; set; }
    }
}
