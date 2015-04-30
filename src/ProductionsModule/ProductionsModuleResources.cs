using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace ProductionsModule
{
    /// <summary>
    /// Localizable strings for the ProductionsModule module
    /// </summary>
    /// <remarks>
    /// You can use Sitefinity Thunder to edit this file.
    /// To do this, open the file's context menu and select Edit with Thunder.
    /// 
    /// If you wish to install this as a part of a custom module,
    /// add this to the module's Initialize method:
    /// App.WorkWith()
    ///     .Module(ModuleName)
    ///     .Initialize()
    ///         .Localization<ProductionsModuleResources>();
    /// </remarks>
    /// <see cref="http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-import-events-from-facebook/creating-the-resources-class"/>
    [ObjectInfo("ProductionsModuleResources", ResourceClassId = "ProductionsModuleResources", Title = "ProductionsModuleResourcesTitle", TitlePlural = "ProductionsModuleResourcesTitlePlural", Description = "ProductionsModuleResourcesDescription")]
    public class ProductionsModuleResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="ProductionsModuleResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public ProductionsModuleResources()
        {
        }

        /// <summary>
        /// Initializes new instance of <see cref="ProductionsModuleResources"/> class with the provided <see cref="ResourceDataProvider"/>.
        /// </summary>
        /// <param name="dataProvider"><see cref="ResourceDataProvider"/></param>
        public ProductionsModuleResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }
        #endregion

        #region Class Description
        /// <summary>
        /// ProductionsModule Resources
        /// </summary>
        [ResourceEntry("ProductionsModuleResourcesTitle",
            Value = "ProductionsModule module labels",
            Description = "The title of this class.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleResourcesTitle
        {
            get
            {
                return this["ProductionsModuleResourcesTitle"];
            }
        }

        /// <summary>
        /// ProductionsModule Resources Title plural
        /// </summary>
        [ResourceEntry("ProductionsModuleResourcesTitlePlural",
            Value = "ProductionsModule module labels",
            Description = "The title plural of this class.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleResourcesTitlePlural
        {
            get
            {
                return this["ProductionsModuleResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for ProductionsModule module.
        /// </summary>
        [ResourceEntry("ProductionsModuleResourcesDescription",
            Value = "Contains localizable resources for ProductionsModule module.",
            Description = "The description of this class.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleResourcesDescription
        {
            get
            {
                return this["ProductionsModuleResourcesDescription"];
            }
        }
        #endregion

        #region Labels
        /// <summary>
        /// word: Actions
        /// </summary>
        [ResourceEntry("ActionsLabel",
            Value = "Actions",
            Description = "word: Actions",
            LastModified = "2015/04/29")]
        public string ActionsLabel
        {
            get
            {
                return this["ActionsLabel"];
            }
        }

        /// <summary>
        /// Title of the link for closing the dialog and going back to the ProductionsModule module
        /// </summary>
        [ResourceEntry("BackToLabel",
            Value = "Go Back",
            Description = "Title of the link for closing the dialog and going back",
            LastModified = "2015/04/29")]
        public string BackToLabel
        {
            get
            {
                return this["BackToLabel"];
            }
        }

        /// <summary>
        /// word: Cancel
        /// </summary>
        [ResourceEntry("CancelLabel",
            Value = "Cancel",
            Description = "word: Cancel",
            LastModified = "2015/04/29")]
        public string CancelLabel
        {
            get
            {
                return this["CancelLabel"];
            }
        }

        /// <summary>
        /// word: Save
        /// </summary>
        /// <value>Save</value>
        [ResourceEntry("SaveLabel",
            Value = "Save",
            Description = "word: Save",
            LastModified = "2015/04/29")]
        public string SaveLabel
        {
            get
            {
                return this["SaveLabel"];
            }
        }

        /// <summary>
        /// phrase: Save changes
        /// </summary>
        [ResourceEntry("SaveChangesLabel",
            Value = "Save changes",
            Description = "phrase: Save changes",
            LastModified = "2015/04/29")]
        public string SaveChangesLabel
        {
            get
            {
                return this["SaveChangesLabel"];
            }
        }

        /// <summary>
        /// word: Delete
        /// </summary>
        [ResourceEntry("DeleteLabel",
            Value = "Delete",
            Description = "word: Delete",
            LastModified = "2015/04/29")]
        public string DeleteLabel
        {
            get
            {
                return this["DeleteLabel"];
            }
        }

        /// <summary>
        /// Phrase: Yes, delete these items
        /// </summary>
        /// <value>Yes, delete these items</value>
        [ResourceEntry("YesDeleteTheseItemsButton",
            Value = "Yes, delete these items",
            Description = "Phrase: Yes, delete these items",
            LastModified = "2015/04/29")]
        public string YesDeleteTheseItemsButton
        {
            get
            {
                return this["YesDeleteTheseItemsButton"];
            }
        }

        /// <summary>
        /// Text of the button that confirms deletion of an item.
        /// </summary>
        /// <value>Yes, delete this item</value>
        [ResourceEntry("YesDeleteThisItemButton",
            Value = "Yes, delete this item",
            Description = "Text of the button that confirms deletion of an item.",
            LastModified = "2015/04/29")]
        public string YesDeleteThisItemButton
        {
            get
            {
                return this["YesDeleteThisItemButton"];
            }
        }

        /// <summary>
        /// Phrase: items are about to be deleted. Continue?
        /// </summary>
        /// <value>items are about to be deleted. Continue?</value>
        [ResourceEntry("BatchDeleteConfirmationMessage",
            Value = "items are about to be deleted. Continue?",
            Description = "Phrase: items are about to be deleted. Continue?",
            LastModified = "2015/04/29")]
        public string BatchDeleteConfirmationMessage
        {
            get
            {
                return this["BatchDeleteConfirmationMessage"];
            }
        }

        /// <summary>
        /// word: Sort
        /// </summary>
        /// <value>Sort</value>
        [ResourceEntry("SortLabel",
            Value = "Sort",
            Description = "word: Sort",
            LastModified = "2015/04/29")]
        public string SortLabel
        {
            get
            {
                return this["SortLabel"];
            }
        }

        /// <summary>
        /// Phrase: Custom sorting
        /// </summary>
        /// <value>Custom sorting</value>
        [ResourceEntry("CustomSortingDialogHeader",
            Value = "Custom sorting",
            Description = "Phrase: Custom sorting",
            LastModified = "2015/04/29")]
        public string CustomSortingDialogHeader
        {
            get
            {
                return this["CustomSortingDialogHeader"];
            }
        }

        /// <summary>
        /// word: or
        /// </summary>
        /// <value>or</value>
        [ResourceEntry("OrLabel",
            Value = "or",
            Description = "word: or",
            LastModified = "2015/04/29")]
        public string OrLabel
        {
            get
            {
                return this["OrLabel"];
            }
        }

        /// <summary>
        /// Phrase: Sort by
        /// </summary>
        /// <value>Sort by</value>
        [ResourceEntry("SortByLabel",
            Value = "Sort by",
            Description = "Phrase: Sort by",
            LastModified = "2015/04/29")]
        public string SortByLabel
        {
            get
            {
                return this["SortByLabel"];
            }
        }

        /// <summary>
        /// word: Yes
        /// </summary>
        /// <value>Yes</value>
        [ResourceEntry("YesLabel",
            Value = "Yes",
            Description = "word: Yes",
            LastModified = "2013/06/26")]
        public string YesLabel
        {
            get
            {
                return this["YesLabel"];
            }
        }

        /// <summary>
        /// word: No
        /// </summary>
        /// <value>No</value>
        [ResourceEntry("NoLabel",
            Value = "No",
            Description = "word: No",
            LastModified = "2013/06/26")]
        public string NoLabel
        {
            get
            {
                return this["NoLabel"];
            }
        }
        #endregion

        #region ProductionsModuleItems
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the ProductionsModuleItem's page.</value>
        [ResourceEntry("ProductionsModuleItemGroupPageTitle",
            Value = "ProductionsModuleItem",
            Description = "The title of ProductionsModuleItem's page.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemGroupPageTitle
        {
            get
            {
                return this["ProductionsModuleItemGroupPageTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageDescription
        /// </summary>
        /// <value>Description for the ProductionsModuleItem's page.</value>
        [ResourceEntry("ProductionsModuleItemGroupPageDescription",
            Value = "ProductionsModuleItem",
            Description = "The description of ProductionsModuleItem's page.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemGroupPageDescription
        {
            get
            {
                return this["ProductionsModuleItemGroupPageDescription"];
            }
        }

        /// <summary>
        /// The URL name of ProductionsModuleItem's page.
        /// </summary>
        [ResourceEntry("ProductionsModuleItemGroupPageUrlName",
            Value = "ProductionsModule-ProductionsModuleItem",
            Description = "The URL name of ProductionsModuleItem's page.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemGroupPageUrlName
        {
            get
            {
                return this["ProductionsModuleItemGroupPageUrlName"];
            }
        }

        /// <summary>
        /// Message displayed to user when no productionsModuleItems exist in the system
        /// </summary>
        /// <value>No productionsModuleItems have been created yet</value>
        [ResourceEntry("NoProductionsModuleItemsCreatedMessage",
            Value = "No productionsModuleItems have been created yet",
            Description = "Message displayed to user when no productionsModuleItems exist in the system",
            LastModified = "2015/04/29")]
        public string NoProductionsModuleItemsCreatedMessage
        {
            get
            {
                return this["NoProductionsModuleItemsCreatedMessage"];
            }
        }

        /// <summary>
        /// Title of the button for creating a new productionsModuleItem
        /// </summary>
        /// <value>Create a productionsModuleItem</value>
        [ResourceEntry("CreateAProductionsModuleItem",
            Value = "Create a productionsModuleItem",
            Description = "Title of the button for creating a new productionsModuleItem",
            LastModified = "2015/04/29")]
        public string CreateAProductionsModuleItem
        {
            get
            {
                return this["CreateAProductionsModuleItem"];
            }
        }

        /// <summary>
        /// Label for editing a new productionsModuleItem
        /// </summary>
        /// <value>Create a productionsModuleItem</value>
        [ResourceEntry("EditAProductionsModuleItem",
            Value = "Edit a productionsModuleItem",
            Description = "Label for editing a new productionsModuleItem",
            LastModified = "2015/04/29")]
        public string EditAProductionsModuleItem
        {
            get
            {
                return this["EditAProductionsModuleItem"];
            }
        }

        /// <summary>
        /// ProductionsModuleItem prod_season_no.
        /// </summary>
        /// <value>Production Season Number</value>
        [ResourceEntry("ProductionsModuleItemprod_season_noLabel",
            Value = "Production Season Number",
            Description = "ProductionsModuleItem prod_season_no.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemprod_season_noLabel
        {
            get
            {
                return this["ProductionsModuleItemprod_season_noLabel"];
            }
        }

        /// <summary>
        /// Error message displayed if the user does not enter productionsModuleItem prod_season_no.
        /// </summary>
        [ResourceEntry("ProductionsModuleItemprod_season_noCannotBeEmpty",
            Value = "The prod_season_no of the productionsModuleItem cannot be empty.",
            Description = "Error message displayed if the user does not enter productionsModuleItem prod_season_no.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemprod_season_noCannotBeEmpty
        {
            get
            {
                return this["ProductionsModuleItemprod_season_noCannotBeEmpty"];
            }
        }

        /// <summary>
        /// Error message displayed if the user enters too long prod_season_no.
        /// </summary>
        /// <value>prod_season_no value is too long. Maximum allowed is 255 characters.</value>
        [ResourceEntry("ProductionsModuleItemprod_season_noInvalidLength",
            Value = "prod_season_no value is too long. Maximum allowed is 255 characters.",
            Description = "Error message displayed if the user enters too long prod_season_no.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemprod_season_noInvalidLength
        {
            get
            {
                return this["ProductionsModuleItemprod_season_noInvalidLength"];
            }
        }

        /// <summary>
        /// ProductionsModuleItem FriendlyTitle.
        /// </summary>
        /// <value>FriendlyTitle</value>
        [ResourceEntry("ProductionsModuleItemFriendlyTitleLabel",
            Value = "FriendlyTitle",
            Description = "ProductionsModuleItem FriendlyTitle.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemFriendlyTitleLabel
        {
            get
            {
                return this["ProductionsModuleItemFriendlyTitleLabel"];
            }
        }

        /// <summary>
        /// ProductionsModuleItem FriendlyTitle description.
        /// </summary>
        /// <value>Enter the item's title (required)</value>
        [ResourceEntry("ProductionsModuleItemFriendlyTitleDescription",
            Value = "Enter the item's title (required)",
            Description = "ProductionsModuleItem FriendlyTitle description.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemFriendlyTitleDescription
        {
            get
            {
                return this["ProductionsModuleItemFriendlyTitleDescription"];
            }
        }

        /// <summary>
        /// Error message displayed if the user enters too long FriendlyTitle.
        /// </summary>
        /// <value>FriendlyTitle value is too long. Maximum allowed is 255 characters.</value>
        [ResourceEntry("ProductionsModuleItemFriendlyTitleInvalidLength",
            Value = "FriendlyTitle value is too long. Maximum allowed is 255 characters.",
            Description = "Error message displayed if the user enters too long FriendlyTitle.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemFriendlyTitleInvalidLength
        {
            get
            {
                return this["ProductionsModuleItemFriendlyTitleInvalidLength"];
            }
        }

        /// <summary>
        /// Message displayed to user when deleting a user productionsModuleItem.
        /// </summary>
        [ResourceEntry("DeleteProductionsModuleItemConfirmationMessage",
            Value = "Are you sure you want to delete this productionsModuleItem?",
            Description = "Message displayed to user when deleting a user productionsModuleItem.",
            LastModified = "2015/04/29")]
        public string DeleteProductionsModuleItemConfirmationMessage
        {
            get
            {
                return this["DeleteProductionsModuleItemConfirmationMessage"];
            }
        }

        /// <summary>
        /// phrase: Create this productionsModuleItem
        /// </summary>
        [ResourceEntry("CreateThisProductionsModuleItemButton",
            Value = "Create this productionsModuleItem",
            Description = "phrase: Create this productionsModuleItem",
            LastModified = "2015/04/29")]
        public string CreateThisProductionsModuleItemButton
        {
            get
            {
                return this["CreateThisProductionsModuleItemButton"];
            }
        }

        /// <summary>
        /// The URL name of ProductionsModuleItem's page.
        /// </summary>
        /// <value>ProductionsModuleItemMasterPageUrl</value>
        [ResourceEntry("ProductionsModuleItemMasterPageUrl",
            Value = "ProductionsModuleItemMasterPageUrl",
            Description = "The URL name of ProductionsModuleItem's page.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemMasterPageUrl
        {
            get
            {
                return this["ProductionsModuleItemMasterPageUrl"];
            }
        }

        /// <summary>
        /// The URL name of ProductionsModuleItem's detail page.
        /// </summary>
        /// <value>ProductionsModuleItemDetailPageUrl</value>
        [ResourceEntry("ProductionsModuleItemDetailPageUrl",
            Value = "ProductionsModuleItemDetailPageUrl",
            Description = "The URL name of ProductionsModuleItem's detail page.",
            LastModified = "2015/04/29")]
        public string ProductionsModuleItemDetailPageUrl
        {
            get
            {
                return this["ProductionsModuleItemDetailPageUrl"];
            }
        }
        #endregion
    }
}