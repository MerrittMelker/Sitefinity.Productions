using System;
using System.Linq;
using System.Reflection;
using Telerik.OpenAccess.Metadata;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Data.Linq;
using Telerik.Sitefinity.Model;
using ProductionsModule.Models;

namespace ProductionsModule.Data.OpenAccess
{
    public class ProductionsModuleOpenAccessDataProvider : ProductionsModuleDataProvider, IOpenAccessDataProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        public OpenAccessProviderContext Context { get; set; }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Gets the meta data source.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>The meta data source</returns>
        public MetadataSource GetMetaDataSource(IDatabaseMappingContext context)
        {
            return new ProductionsModuleStorageMetadataSource(context);
        }

        /// <summary>
        /// Gets a query of all the ProductionsModuleItem items.
        /// </summary>
        /// <returns>The ProductionsModuleItem items.</returns>
        public override IQueryable<ProductionsModuleItem> GetProductionsModuleItems()
        {
            return SitefinityQuery
                .Get<ProductionsModuleItem>(this, MethodBase.GetCurrentMethod())
                .Where(b => b.ApplicationName == this.ApplicationName);
        }

        /// <summary>
        /// Gets a ProductionsModuleItem by a specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>The ProductionsModuleItem.</returns>
        public override ProductionsModuleItem GetProductionsModuleItem(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be Empty Guid");

            return this.GetContext().GetItemById<ProductionsModuleItem>(id.ToString());
        }

        /// <summary>
        /// Creates a new ProductionsModuleItem and returns it.
        /// </summary>
        /// <returns>The new ProductionsModuleItem.</returns>
        public override ProductionsModuleItem CreateProductionsModuleItem()
        {
            Guid id = Guid.NewGuid();

            var item = new ProductionsModuleItem(id, this.ApplicationName);

            if (id != Guid.Empty)
                this.GetContext().Add(item);

            return item;
        }

        /// <summary>
        /// Updates the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public override void UpdateProductionsModuleItem(ProductionsModuleItem entity)
        {
            entity.LastModified = DateTime.UtcNow;
        }

        /// <summary>
        /// Deletes the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public override void DeleteProductionsModuleItem(ProductionsModuleItem entity)
        {
            this.GetContext().Remove(entity);
        }
        #endregion
    }
}