using System;
using System.Linq;
using System.Text.RegularExpressions;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace DummySite.Utils
{
    public static class FlatTaxonomyAPI
    {
        public static Guid CreateFlatTaxonomy()
        {
            //gets an instance of the TaxonomyManager
            TaxonomyManager manager = TaxonomyManager.GetManager();

            //creates flat taxonomy
            var tax = manager.CreateTaxonomy<FlatTaxonomy>();
            tax.TaxonName = "Meals";
            tax.Name = "Meals";
            tax.Title = "Meals";
            tax.Description = "Meals Description";

            //creates three taxons for the taxonomy
            //1
            var taxon = manager.CreateTaxon<FlatTaxon>(Guid.NewGuid());
            taxon.Title = "Breakfast";
            taxon.Name = "Breakfast";
            taxon.Description = "This tag categorizes the Breakfast";
            taxon.UrlName = new Lstring(Regex.Replace("Breakfast", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
            tax.Taxa.Add(taxon);
            manager.SaveChanges();

            //2
            taxon = manager.CreateTaxon<FlatTaxon>(Guid.NewGuid());
            taxon.Title = "Lunch";
            taxon.Name = "Lunch";
            taxon.Description = "This tag categorizes the Lunch";
            taxon.UrlName = new Lstring(Regex.Replace("Lunch", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
            tax.Taxa.Add(taxon);
            manager.SaveChanges();

            //3
            taxon = manager.CreateTaxon<FlatTaxon>(Guid.NewGuid());
            taxon.Title = "Dinner";
            taxon.Name = "Dinner";
            taxon.Description = "This tag categorizes the Dinner";
            taxon.UrlName = new Lstring(Regex.Replace("Dinner", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
            tax.Taxa.Add(taxon);
            manager.SaveChanges();

            return tax.Id;
        }

        public static FlatTaxonomy FindATaxonomy()
        {
            TaxonomyManager manager = TaxonomyManager.GetManager();

            var taxonomy = manager.GetTaxonomies<FlatTaxonomy>().Where(t => t.Name == "Meals").Single();

            return taxonomy;

        }

        public static FlatTaxon GetTaxonomyId(Guid taxaId)
        {
            TaxonomyManager manager = TaxonomyManager.GetManager();
            var taxa = manager.GetTaxa<FlatTaxon>().Where(t => t.Id == taxaId).Single();
            return taxa;

        }
    }
}