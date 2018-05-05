using System;

namespace issueTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Status Status { get; set; }
        public int StatusId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Priority Priority { get; set; }
        public int PriorityId { get; set; }

        public Creator Creator { get; set; }
        public int CreatorId { get; set; }


    }
}