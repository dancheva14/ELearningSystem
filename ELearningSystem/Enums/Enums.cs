using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningSystem.Enums
{
    public class Enums
    {
        public enum Roles
        {
            [Display(Name = "Админ")]
            admin = 0,
            [Display(Name = "Потребител")]
            user = 1
        }
    }
}