using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;

namespace BloodLink.Models
{
    public enum Role
    {
        [Description("Donor - I want to donate blood")] Donor,
        [Description("Finder - I want to find donor")] Finder
    }

    public enum BloodGroup
    {
        [Description("A+")] APositive,
        [Description("A-")] ANegative,
        [Description("B+")] BPositive,
        [Description("B-")] BNegative,
        [Description("O+")] OPositive,
        [Description("O-")] ONegative,
        [Description("AB+")] ABPositive,
        [Description("AB-")] ABNegative
    }

    public enum Gender
    {
        [Description("Male")] Male,
        [Description("Female")] Female,
        [Description("Other")] Other
    }
}
