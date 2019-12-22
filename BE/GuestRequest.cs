﻿using System;

namespace BE
{
    public class GuestRequest
    {
        public long GuestRequestKey = 10000000;
        public string PrivateName { get; set;}
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public Status_client status_Client { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Area area { get; set; }
        public Type type { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public Pool pool { get; set; }
        public Jaccuzzi jacuzzi { get; set; }
        public Garden garden { get; set; }
        public ChildrensAttractions childrenAttractions { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
