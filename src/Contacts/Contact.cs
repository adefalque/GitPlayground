﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPlayground.Contacts
{
    // A class to hold contact information
    public class Contact
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Job { get; set; }

        ///
        /// The date of birth of the contact
        /// 
        public DateTime Birthday { get; set; }

        public Company Company { get; set; }
    }
}
