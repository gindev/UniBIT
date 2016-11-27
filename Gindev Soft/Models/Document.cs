namespace Models
{
    using System;
    using System.Collections.Generic;

    public class Document
    {
        public string Type { get; set; }

        public string Number { get; set; }

        public DateTime IssueDate { get; set; }

        public Contragent Client { get; set; }

        public Contragent Provider { get; set; }

        public HashSet<Product> ProductsList { get; set; }
    }
}
