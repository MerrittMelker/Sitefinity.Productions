using System;
using System.Linq;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;
using ProductionsModule.Configuration;
using ProductionsModule.Models;

namespace ProductionsModule
{
    public class ProductionsModuleManager : ManagerBase<ProductionsModuleDataProvider>
    {
        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleManager" /> class.
        /// </summary>
        public ProductionsModuleManager()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleManager" /> class.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        public ProductionsModuleManager(string providerName)
            : base(providerName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleManager" /> class.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        public ProductionsModuleManager(string providerName, string transactionName)
            : base(providerName, transactionName)
        {
        }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Gets the default provider delegate.
        /// </summary>
        /// <value>The default provider delegate.</value>
        protected override GetDefaultProvider DefaultProviderDelegate
        {
            get
            {
                return () => Config.Get<ProductionsModuleConfig>().DefaultProvider;
            }
        }

        /// <summary>
        /// Gets the name of the module.
        /// </summary>
        /// <value>The name of the module.</value>
        public override string ModuleName
        {
            get
            {
                return ProductionsModuleClass.ModuleName;
            }
        }

        /// <summary>
        /// Gets the providers settings.
        /// </summary>
        /// <value>The providers settings.</value>
        protected override ConfigElementDictionary<string, DataProviderSettings> ProvidersSettings
        {
            get
            {
                return Config.Get<ProductionsModuleConfig>().Providers;
            }
        }

        /// <summary>
        /// Get an instance of the ProductionsModule manager using the default provider.
        /// </summary>
        /// <returns>Instance of the ProductionsModule manager</returns>
        public static ProductionsModuleManager GetManager()
        {
            return ManagerBase<ProductionsModuleDataProvider>.GetManager<ProductionsModuleManager>();
        }

        /// <summary>
        /// Get an instance of the ProductionsModule manager by explicitly specifying the required provider to use
        /// </summary>
        /// <param name="providerName">Name of the provider to use, or null/empty string to use the default provider.</param>
        /// <returns>Instance of the ProductionsModule manager</returns>
        public static ProductionsModuleManager GetManager(string providerName)
        {
            return ManagerBase<ProductionsModuleDataProvider>.GetManager<ProductionsModuleManager>(providerName);
        }

        /// <summary>
        /// Get an instance of the ProductionsModule manager by explicitly specifying the required provider to use
        /// </summary>
        /// <param name="providerName">Name of the provider to use, or null/empty string to use the default provider.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        /// <returns>Instance of the ProductionsModule manager</returns>
        public static ProductionsModuleManager GetManager(string providerName, string transactionName)
        {
            return ManagerBase<ProductionsModuleDataProvider>.GetManager<ProductionsModuleManager>(providerName, transactionName);
        }

        /// <summary>
        /// Creates a ProductionsModuleItem.
        /// </summary>
        /// <returns>The created ProductionsModuleItem.</returns>
        public ProductionsModuleItem CreateProductionsModuleItem()
        {
            return this.Provider.CreateProductionsModuleItem();
        }

        /// <summary>
        /// Updates the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public void UpdateProductionsModuleItem(ProductionsModuleItem entity)
        {
            this.Provider.UpdateProductionsModuleItem(entity);
        }

        /// <summary>
        /// Deletes the ProductionsModuleItem.
        /// </summary>
        /// <param name="entity">The ProductionsModuleItem entity.</param>
        public void DeleteProductionsModuleItem(ProductionsModuleItem entity)
        {
            this.Provider.DeleteProductionsModuleItem(entity);
        }

        /// <summary>
        /// Gets the ProductionsModuleItem by a specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>The ProductionsModuleItem.</returns>
        public ProductionsModuleItem GetProductionsModuleItem(Guid id)
        {
            return this.Provider.GetProductionsModuleItem(id);
        }

        /// <summary>
        /// Gets a query of all the ProductionsModuleItem items.
        /// </summary>
        /// <returns>The ProductionsModuleItem items.</returns>
        public IQueryable<ProductionsModuleItem> GetProductionsModuleItems()
        {
            return this.Provider.GetProductionsModuleItems();
        }
        #endregion
    }
}