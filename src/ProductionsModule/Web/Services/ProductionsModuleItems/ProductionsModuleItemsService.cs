using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using Telerik.Sitefinity.Data.Linq.Dynamic;
using Telerik.Sitefinity.Utilities.Json;
using ProductionsModule.Models;
using ProductionsModule.Web.Services.ProductionsModuleItems.ViewModels;
using Telerik.OpenAccess;
using Telerik.Web.UI;
using TessituraIntegration.TessituraWebAPI;

namespace ProductionsModule.Web.Services.ProductionsModuleItems
{
    public class ProductionsModuleItemsService
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionsModuleItemsService" /> class.
        /// </summary>
        public ProductionsModuleItemsService()
        {
            manager = ProductionsModuleManager.GetManager();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Gets the total items count.
        /// </summary>
        /// <param name="sortExpression">The sort expression.</param>
        /// <returns></returns>
        public int GetTotalItemsCount(string sortExpression)
        {
            //return manager.GetProductionsModuleItems().Count();
            return result.Tables[0].Rows.Count;
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="startRowIndex">Start index of the row.</param>
        /// <param name="maximumRows">The maximum rows.</param>
        /// <param name="sortExpression">The sort expression.</param>
        /// <returns></returns>
        public DataTable GetItems(int startRowIndex, int maximumRows, string sortExpression)
        {
            //var viewData = new List<ProductionsModuleItemViewModel>();
            //var items = manager.GetProductionsModuleItems().OrderBy(sortExpression).Skip(startRowIndex).Take(maximumRows);
            //foreach (var item in items)
            //{
            //    var viewModel = new ProductionsModuleItemViewModel();
            //    ProductionsModuleItemsViewModelTranslator.ToViewModel(item, viewModel, manager);
            //    viewData.Add(viewModel);
            //}
            //return viewData;

                if (result == null)
                {
                    GetResult();
                }

                return result.Tables[0];
        }

        private static void GetResult()
        {
            var myBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            myBinding.MaxReceivedMessageSize = 2147483647;
            var myEndpoint =
                new EndpointAddress("https://gatewaytest.omahaperformingarts.org/TessituraWebAPItest/Tessitura.asmx");
            using (var soapClient = new TessituraSoapClient(myBinding, myEndpoint))
            {
                result = soapClient.GetProductionsEx3(string.Empty, string.Empty, string.Empty, string.Empty,
                string.Empty, -1, string.Empty, 6, 1, string.Empty, string.Empty, string.Empty, 0,
                string.Empty, string.Empty, string.Empty);
            }
        }
 
        private static DataSet result;

        /// <summary>
        /// Deletes the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        public void Delete(string ids)
        {
            foreach (var id in JsonUtility.FromJson<Guid[]>(ids))
            {
                var item = manager.GetProductionsModuleItem(id);
                if (item != null)
                    manager.DeleteProductionsModuleItem(item);
            }

            manager.SaveChanges();
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        public ProductionsModuleItemViewModel GetItem(Guid itemId)
        {
            var item = manager.GetProductionsModuleItem(itemId);
            var viewModel = new ProductionsModuleItemViewModel();
            ProductionsModuleItemsViewModelTranslator.ToViewModel(item, viewModel, manager);
            return viewModel;
        }

        /// <summary>
        /// Creates the productionsModuleItem.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        public ProductionsModuleItem CreateItem(ProductionsModuleItemViewModel viewModel)
        {
            var item = manager.CreateProductionsModuleItem();
            ProductionsModuleItemsViewModelTranslator.ToModel(viewModel, item, manager);
            manager.SaveChanges();
            return item;
        }

        /// <summary>
        /// Updates the productionsModuleItem.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="viewModel">The view model.</param>
        public void UpdateItem(Guid id, ProductionsModuleItemViewModel viewModel)
        {
            var item = manager.GetProductionsModuleItem(id);
            if (item == null)
                throw new NullReferenceException("ProductionsModuleItem can not be found.");
            ProductionsModuleItemsViewModelTranslator.ToModel(viewModel, item, manager);
            manager.UpdateProductionsModuleItem(item);
            manager.SaveChanges();
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        public List<ProductionsModuleItemPropertyViewModel> GetProperties()
        {
            var properties = new List<ProductionsModuleItemPropertyViewModel>();

            foreach (PropertyInfo property in typeof(ProductionsModuleItem).GetProperties())
                if (!this.systemProperties.Contains(property.Name))
                    properties.Add(new ProductionsModuleItemPropertyViewModel() { Name = property.Name });

            return properties;
        }
        #endregion

        #region Private fields
        private readonly ProductionsModuleManager manager = null;
        private readonly IEnumerable<string> systemProperties = new List<string>()
        {
            "Id", "Transaction", "ApplicationName", "Provider",
        };
        #endregion
    }
}