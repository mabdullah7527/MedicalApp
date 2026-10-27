using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp_Domain.Constants
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Doctor = "Doctor";
        public const string Patient = "Patient";

        public static readonly string[] All = [Admin, Doctor, Patient];
    }
}
