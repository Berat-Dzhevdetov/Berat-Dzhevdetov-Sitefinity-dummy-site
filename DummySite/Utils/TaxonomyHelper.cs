using System.Linq;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace DummySite.Utils
{
    public static class TaxonomyHelper
    {
        public static T GetAllTaxonomies<T>()
            where T : Taxon
        {
            var manager = TaxonomyManager.GetManager();
            return manager.GetTaxonomies<FlatTaxonomy>().Select(x => new TaxonomyGrid
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                LastModified = x.LastModified,
                RootTaxonomy = x.RootTaxonomy.Name,
            });
        }
    }
}