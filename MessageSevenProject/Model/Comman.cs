using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MessageSevenProject.Model
{
    public class Comman
    {
       
        public enum Attributes
        {

            [Display(Name = "ID")]
            Id,
            [Display(Name = "Name")]
            Name ,
            [Display(Name = "Last Updated")]
            LastUpdated,
            [Display(Name = "Activity Status")]
            ActivityStatus,
            [Display(Name = "Business Risk Rating")]
            BusinessRiskRating,
            [Display(Name = "Information Risk Rating")]
            InformationRiskRating,
            [Display(Name = "Owner Mail")]
            OwnerMail,
            [Display(Name = "Approver Mail")]
            ApproverMail,
            [Display(Name = "Application Type")]
            Type 
    }

        public enum Operators
        {
           Equals,
           Contains
        }
    }
}
