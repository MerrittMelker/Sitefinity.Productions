using System;
using System.Linq;
using Telerik.Sitefinity.Data;
using ProductionsModule.Models;

namespace ProductionsModule
{
    public abstract class ProductionsModuleDataProvider : DataProviderBase
    {
        #region Public and overriden methods
        /// <summary>
        /// Gets the known types.
        /// </summary>
        public override Type[] GetKnownTypes()
        {
            if (knownTypes == null)
            {
                knownTypes = new Type[]
                {
                    typeof(ProductionsModuleItem)
                };
            }
            return knownTypes;
        }

        /// <summary>
        /// Gets the root key.
        /// </summary>
        /// <value>The root key.</value>
        public override string RootKey
        {
            get
            {
                return "ProductionsModuleDataProvider";
            }
        }
        #endregion

        #region Abstract methods
        /// <summary>
        /// Creates a new ProductionsModuleItem and returns it.
        /// </summary>
        /// <returns>The new ProductionsModuleItem.</returns>
        public abstract ProductionsModuleItem CreateProductionsModuleItem();

        /// <summary>
        /// Gets a ProductionsModuleItem by a specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>The ProductionsModuleItem.</returns>
        public abstract ProductionsModuleItem GetProductionsModuleItem(Guid id);

        /// <summary>
        /// Gets a query of all the ProductionsModuleItem items.
        /// </summary>
        /// <returns>The ProductionsModuleItem items.</returns>
        public abstract IQueryable<ProductionsModuleItem> GetProductionsModuleItems();

        /// <summary>
        /// Updates the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public abstract void UpdateProductionsModuleItem(ProductionsModuleItem entity);

        /// <summary>
        /// Deletes the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public abstract void DeleteProductionsModuleItem(ProductionsModuleItem entity);
        #endregion

        #region Private fields and constants
        private static Type[] knownTypes;
        #endregion
    }
}