using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Common
{
    public static class _ValidationConstants
    {
        public static class _Task
        {
            public const int TitleMaxLength = 200;
            public const string TitleMaxLengthErrorMessage = "The Title must not exceed 200 characters.";

            public const int DescriptionMaxLength = 1000;
            public const string DescriptionMaxLengthErrorMessage = "The Description must not exceed 1000 characters.";

            // Additional constants for Task as needed
        }

        public static class _Project
        {
            public const int NameMaxLength = 200;
            public const string NameMaxLengthErrorMessage = "The Name must not exceed 200 characters.";

            public const int DescriptionMaxLength = 1000;
            public const string DescriptionMaxLengthErrorMessage = "The Description must not exceed 1000 characters.";

            // Additional constants for Project as needed
        }

        public static class _Note
        {
            public const int TitleMaxLength = 200;
            public const string TitleMaxLengthErrorMessage = "The Title must not exceed 200 characters.";

            public const int ContentMaxLength = 5000;
            public const string ContentMaxLengthErrorMessage = "The Content must not exceed 5000 characters.";

            // Additional constants for Note as needed
        }

        public static class _Event
        {
            public const int TitleMaxLength = 200;
            public const string TitleMaxLengthErrorMessage = "The Title must not exceed 200 characters.";

            public const int DescriptionMaxLength = 1000;
            public const string DescriptionMaxLengthErrorMessage = "The Description must not exceed 1000 characters.";

            public const int LocationMaxLength = 500;
            public const string LocationMaxLengthErrorMessage = "The Location must not exceed 500 characters.";

            // Additional constants for Event as needed
        }

        public static class _Contact
        {
            public const int NameMaxLength = 200;
            public const string NameMaxLengthErrorMessage = "The Name must not exceed 200 characters.";

            public const int EmailMaxLength = 100;
            public const string EmailMaxLengthErrorMessage = "The Email must not exceed 100 characters.";

            public const int PhoneMaxLength = 20;
            public const string PhoneMaxLengthErrorMessage = "The Phone number must not exceed 20 characters.";

            public const int AddressMaxLength = 500;
            public const string AddressMaxLengthErrorMessage = "The Address must not exceed 500 characters.";

            // Additional constants for Contact as needed
        }

        public static class _General
        {
            // Add general constants that apply to multiple classes
            // e.g., user ID length, general description length, etc.
        }

        // Additional entity-specific constants as needed
    }

}