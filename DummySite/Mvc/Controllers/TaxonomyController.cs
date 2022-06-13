using DummySite.Mvc.Models.Taxonomy;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace DummySite.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "ListAllTaxonomies", Title = "List All Taxonomies", SectionName = "Taxonomy")]
    public class TaxonomyController : Controller
    {
        #region Actions
        // GET: Taxonomy
        public ActionResult Index()
        {
            TaxonomyManager manager = TaxonomyManager.GetManager();

            var taxa = manager.GetTaxonomies<FlatTaxonomy>().Select(x => new TaxonomyGrid
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                LastModified = x.LastModified,
                RootTaxonomy = x.RootTaxonomy.Name,
            });

            return View(taxa);
        }
        #endregion

        [Category("String Properties")]
        public string Message { get; set; }
    }
}