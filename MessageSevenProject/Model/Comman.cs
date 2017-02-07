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

            [Description("ID")]
            Id,
            [Description("Name")]
            Name ,
            [Description("Last Updated")]
            LastUpdated,
            [Description("Activity Status")]
            ActivityStatus,
            [Description("Business Risk Rating")]
            BusinessRiskRating,
            [Description("Information Risk Rating")]
            InformationRiskRating,
            [Description("Owner Mail")]
            OwnerMail,
            [Description("Approver Mail")]
            ApproverMail,
            [Description("Application Type")]
            Type 
    }

        public enum Operators
        {
           Equals,
           Contains
        }
    }
}
