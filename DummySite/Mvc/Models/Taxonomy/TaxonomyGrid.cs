using System;

namespace DummySite.Mvc.Models.Taxonomy
{
    public class TaxonomyGrid
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime LastModified { get; set; }
        public string Description { get; set; }
        public string RootTaxonomy { get; set; }

    }
}