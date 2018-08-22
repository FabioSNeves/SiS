using System;
using TicketSystem.Domain.Users;
using TicketSystem.Domain.Repository;

namespace TicketSystem.Domain
{
    public class Incident
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public string Description { get; set; }
        public string Response { get; set; }
        public IIncidentRepository Repository { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public long User_Id { get; set; }
        public string Name { get; set; }

        public void Save()
            {
                if (Repository == null)
                    throw new ArgumentNullException("Incident domain repository not referenced.");

                if (String.IsNullOrEmpty(Title))
                    throw new Exception("Incident title should not be empty.");

                if (Title.Length > 20)
                    throw new Exception("The title of the incident should be longer than 20 characters.");

                if (String.IsNullOrEmpty(Description))
                    throw new Exception("Incident description should not be empty.");

                if (Description.Length > 500)
                    throw new Exception("The description of the incident should be longer than 500 characters.");

                if (CategoryId.Equals(null))
                    throw new Exception("Category invalid.");

                if (StatusId.Equals(null))
                throw new Exception("Status invalid.");

                Repository.Add(this);
                }

        public void Update()
        {
            if (Repository == null)
                throw new ArgumentNullException("Incident domain repository not referenced.");

            if (String.IsNullOrEmpty(Response))
                throw new Exception("Incident response should not be empty.");

            if (StatusId.Equals(false))
                throw new Exception("Status invalid");

            Repository.Update(this);
        }

    }
}


