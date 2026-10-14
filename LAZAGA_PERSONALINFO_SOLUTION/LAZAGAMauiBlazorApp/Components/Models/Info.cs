using System;
using System.Collections.Generic;
using System.Text;

namespace LAZAGAMauiBlazorApp.Components.Models
{

    public class MyInfo
    {
        public class Fullname { public string? FirstN { get; set; } }
        public class MiddleName { public string? MiddleN { get; set; } }
        public class LastName { public string? LastN { get; set; } }
        public class Mycourse { public string? Course { get; set; } }
        public class MyYear { public string? Year { get; set; } }
        public class MyBirthday { public string? Birthday { get; set; } }
        public class Myage { public string? Age { get; set; } }
        public class MyContacts
        {
            public string? FbLink { get; set; }
            public string? GithubLink { get; set; }
            public string? InstagramLink { get; set; }
            public string? TiktokLink { get; set; }
        }
    }

}
