using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Model;
using ProductionsModule.Models;

namespace ProductionsModule.Data.OpenAccess
{
    public class ProductionsModuleFluentMapping : OpenAccessFluentMappingBase
    {
        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleFluentMapping" /> class.
        /// </summary>
        internal ProductionsModuleFluentMapping()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleFluentMapping" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ProductionsModuleFluentMapping(IDatabaseMappingContext context)
            : base(context)
        {
        }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Gets the list of mapping configurations.
        /// </summary>
        /// <inheritdoc />
        /// <returns></returns>
        public override IList<MappingConfiguration> GetMapping()
        {
            var mappings = new List<MappingConfiguration>();

            this.MapProductionsModuleItems(mappings);

            return mappings;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Maps the ProductionsModuleItem items.
        /// </summary>
        /// <param name="mappings">The mappings.</param>
        private void MapProductionsModuleItems(List<MappingConfiguration> mappings)
        {
            var mapping = new MappingConfiguration<ProductionsModuleItem>();

            mapping.MapType(p => new { }).SetTableName("ProductionsModule_ProductionsModuleItems", this.Context);

            mapping.HasProperty(p => p.Id).IsIdentity().IsNotNullable();
            mapping.HasProperty(p => p.prod_season_no).IsNotNullable().IsText(this.Context, 255);
            mapping.HasProperty(p => p.FriendlyTitle).IsText(this.Context, 255);
            mapping.HasProperty(p => p.ApplicationName);
            mapping.HasProperty(p => p.LastModified);
            mapping.HasProperty(p => p.DateCreated);

            mappings.Add(mapping);
        }
        #endregion
    }
}