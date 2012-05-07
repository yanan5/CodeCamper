﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeCamper.Model
{
    public class Person
    {
        public Person()
        {
            Gender = " "; // make not assumption
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
        [StringLength(1,MinimumLength = 1) ]
        public string Gender { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<Session> SpeakerSessions { get; set; }
        public virtual ICollection<PersonSession> AttendingSessions { get; set; }
    }
}