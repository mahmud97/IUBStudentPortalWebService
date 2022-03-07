using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UserPortalWebService.Models;

namespace UserPortalWebService.ViewModel
{
    public class UserViewModel
    {
        public  User User { get; set; }

        [Required(ErrorMessage = "You must provide information of your Current Workplace")]
        [StringLength(512)]
        //[DisplayName("Name of the current organization (If you are not associated with any organizations, please mention so)")]
        [DisplayName("Current Workplace")]
        public string NewWorkPlace { get; set; }



        [Required(ErrorMessage = "You must provide information of your role in your Current Workplace")]
        [StringLength(500)]
        [DisplayName("Job Role in the current workplace")]
        public string NewJobRole { get; set; }

    }
}