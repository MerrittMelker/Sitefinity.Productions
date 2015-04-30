using System;
using System.Linq;
using ProductionsModule.Models;

namespace ProductionsModule.Web.Services.ProductionsModuleItems.ViewModels
{
    /// <summary>
    /// Provides methods for translating view models to models and vice versa for the ProductionsModule module.
    /// </summary>
    public static class ProductionsModuleItemsViewModelTranslator
    {
        #region ProductionsModuleItem
        /// <summary>
        /// Translates ProductionsModuleItem view model to ProductionsModuleItem model.
        /// </summary>
        /// <param name="source">
        /// An instance of the <see cref="ProductionsModuleItemViewModel"/>.
        /// </param>
        /// <param name="target">
        /// An instance of the <see cref="ProductionsModuleItem"/>.
        /// </param>
        public static void ToModel(ProductionsModuleItemViewModel source, ProductionsModuleItem target, ProductionsModuleManager manager)
        {
            target.prod_season_no = source.prod_season_no;
            target.FriendlyTitle = source.FriendlyTitle;
        }

        /// <summary>
        /// Translates ProductionsModuleItem to ProductionsModuleItem view model.
        /// </summary>
        /// <param name="source">
        /// An instance of the <see cref="ProductionsModuleItem"/>.
        /// </param>
        /// <param name="target">
        /// An instance of the <see cref="ProductionsModuleItemViewModel"/>.
        /// </param>
        public static void ToViewModel(ProductionsModuleItem source, ProductionsModuleItemViewModel target, ProductionsModuleManager manager)
        {
            target.Id = source.Id;
            target.LastModified = source.LastModified;
            target.DateCreated = source.DateCreated;

            target.prod_season_no = source.prod_season_no;
            target.FriendlyTitle = source.FriendlyTitle;
        }
        #endregion
    }
}
