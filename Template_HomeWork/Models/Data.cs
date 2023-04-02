using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Template_HomeWork.Models
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1,Icon="<i class=\"bx bxl-dribbble\"></i>",Title="Salam Azerbaycan",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=2,Icon="<i class=\"bx bx-file\"></i>",Title="Salam Baku",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=3,Icon="<i class=\"bx bx-tachometer\"></i>",Title="Salam Ganja",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=4,Icon="<i class=\"bx bx-world\"></i>",Title="Salam Shusha",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=5,Icon="<i class=\"bx bx-slideshow\"></i>",Title="Salam Kalbacar",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=6,Icon="<i class=\"bx bx-arch\"></i>",Title="Salam Lachin",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
        };

        public static List<Team> Members = new List<Team>
        {
            new Team{Id=1,Image="team-1.jpg",Icon1="<i class=\"bi bi-twitter\"></i>",Icon2="<i class=\"bi bi-facebook\"></i>",Icon3="<i class=\"bi bi-instagram\"></i>",Icon4="<i class=\"bi bi-linkedin\"></i>",FullName="Walter White",Position="Chief Executive Officer"},
            new Team{Id=1,Image="team-2.jpg",Icon1="<i class=\"bi bi-twitter\"></i>",Icon2="<i class=\"bi bi-facebook\"></i>",Icon3="<i class=\"bi bi-instagram\"></i>",Icon4="<i class=\"bi bi-linkedin\"></i>",FullName="Sarah Jhonson",Position="Product Manager"},
            new Team{Id=1,Image="team-3.jpg",Icon1="<i class=\"bi bi-twitter\"></i>",Icon2="<i class=\"bi bi-facebook\"></i>",Icon3="<i class=\"bi bi-instagram\"></i>",Icon4="<i class=\"bi bi-linkedin\"></i>",FullName="William Anderson",Position="CTO"},
            new Team{Id=1,Image="team-4.jpg",Icon1="<i class=\"bi bi-twitter\"></i>",Icon2="<i class=\"bi bi-facebook\"></i>",Icon3="<i class=\"bi bi-instagram\"></i>",Icon4="<i class=\"bi bi-linkedin\"></i>",FullName="Amanda Jepson",Position="Accountant"},
        };

        public static List<Contact> Contacts = new List<Contact>
        {
            new Contact{Id=1,Icon="<i class=\"bx bx-map\"></i>",Title="Our Address",Info="A108 Adam Street, New York, NY 535022"},
            new Contact{Id=3,Icon="<i class=\"bx bx-phone-call\"></i>",Title="Call Us",Info="+1 5589 55488 55"},
            new Contact{Id=3,Icon="<i class=\"bx bx-envelope\"></i>",Title="Email Us",Info="contact@example.com"},

        };
    }
}
