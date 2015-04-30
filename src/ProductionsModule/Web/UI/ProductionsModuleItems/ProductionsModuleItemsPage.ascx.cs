using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Utilities.Json;
using Telerik.Sitefinity.Web;
using Telerik.Web.UI;
using Telerik.Sitefinity.Modules.Pages;
using ProductionsModule.Web.Services.ProductionsModuleItems;
using ProductionsModule.Web.Services.ProductionsModuleItems.ViewModels;

namespace ProductionsModule.Web.UI.ProductionsModuleItems
{
    public class CustomRadAjaxPanel : RadAjaxPanel
    {
        protected override void OnInit(EventArgs e)
        {
            this.Page.InitComplete += new EventHandler(Page_InitComplete);
        }
        void Page_InitComplete(object sender, EventArgs e)
        {
            base.OnInit(e);
        }
    }
    public class CustomRadAjaxManager : RadAjaxManager
    {
        protected override void OnInit(EventArgs e)
        {
            this.Page.InitComplete += new EventHandler(Page_InitComplete);
        }
        void Page_InitComplete(object sender, EventArgs e)
        {
            base.OnInit(e);
        }
    }

    [Telerik.Sitefinity.Modules.Pages.Web.UI.RequireScriptManager(true)]
    public partial class ProductionsModuleItemsPage : UserControl
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.InitComplete += new EventHandler(Page_InitComplete);
            //var setting = new AjaxSetting();
            //AjaxUpdatedControl target = new AjaxUpdatedControl(Button1.ID, RadAjaxLoadingPanel1.ID);
            //setting.UpdatedControls.Add(target);
            //setting.AjaxControlID = Button1.ID;
            //RadAjaxManager1.AjaxSettings.Add(setting);
            //target = new AjaxUpdatedControl(ProductionsModuleItemsMaster.ID, RadAjaxLoadingPanel1.ID);
            //setting.UpdatedControls.Add(target);
            //setting.AjaxControlID = ProductionsModuleItemsMaster.ID;
            //RadAjaxManager1.AjaxSettings.Add(setting);
        }

        private void Page_InitComplete(object sender, EventArgs e)
        {
            //RadAjaxManager1.AjaxSettings.AddAjaxSetting(Button1, Button1, RadAjaxLoadingPanel1);
            //RadAjaxManager1.AjaxSettings.AddAjaxSetting(ProductionsModuleItemsMaster, ProductionsModuleItemsMaster, RadAjaxLoadingPanel1);
        }

        protected void foo(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            Button1.Text = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }

        #region Properties
        /// <summary>
        /// Gets the details view URL.
        /// </summary>
        /// <value>The details view URL.</value>
        private string DetailsViewUrl
        {
            get
            {
                if (this.detailsViewUrl == null)
                {
                    var sitemap = BackendSiteMap.GetCurrentProvider();
                    var node = sitemap.FindSiteMapNodeFromKey(ProductionsModuleClass.ProductionsModuleItemDetailPageId.ToString());
                    if (node == null)
                        return "#";
                    this.detailsViewUrl = UrlPath.ResolveUrl(node.Url);
                }
                return this.detailsViewUrl;
            }
        }
        #endregion

        #region Page events

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            PageManager.ConfigureScriptManager(this.Page, ScriptRef.JQuery);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ConfigureControls();
        }

        /// <summary>
        /// Configures the controls.
        /// </summary>
        private void ConfigureControls()
        {
            ////populate sortby dropdown list
            //var properties = this.service.GetProperties();
            //properties.ForEach(p =>
            //{
            //    customSortByDropdown.Items.Add(new ListItem(p.Name, p.Name));
            //});

            ////set paging and sorting
            //if (!Page.IsPostBack)
            //{
            //    string page = Request.QueryString["page"];
            //    string sort = Request.QueryString["sort"];

            //    if (!string.IsNullOrEmpty(page))
            //        ProductionsModuleItemsMaster.CurrentPageIndex = int.Parse(page);

            //    if (!string.IsNullOrEmpty(sort))
            //    {
            //        sortExpression.Value = sort;

            //        //set visual state for the sorting drop down
            //        sortDropDown.SelectedValue = "custom";
            //        foreach (ListItem item in sortDropDown.Items)
            //            if (item.Value == sortExpression.Value)
            //                sortDropDown.SelectedValue = item.Value;
            //    }
            //}

            ////show or hide editcustom sorting option
            //foreach (ListItem item in sortDropDown.Items)
            //    if (item.Value == "editcustom")
            //        item.Enabled = (sortDropDown.SelectedValue == "custom" ||
            //                        sortDropDown.SelectedValue == "editcustom");

            //if (sortDropDown.SelectedValue == "editcustom")
            //    sortDropDown.SelectedValue = "custom";

            ////set custom sorting screen
            //if (sortDropDown.SelectedValue == "custom")
            //{
            //    string[] sortParams = sortExpression.Value.Split(' ');
            //    string sortField = sortParams[0];
            //    string sortDirection = sortParams[1];

            //    customSortByDropdown.SelectedValue = sortField;

            //    ascRadioChoice.Checked = (sortDirection == "ASC");
            //    descRadioChoice.Checked = !ascRadioChoice.Checked;
            //}
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Called when [confirm delete button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void OnConfirmDeleteButtonClicked(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(selectedItemId.Value))
            //{
            //    var ids = new List<Guid>()
            //    {
            //        new Guid(selectedItemId.Value)
            //    };
            //    this.DeleteItems(ids);
            //    selectedItemId.Value = string.Empty;
            //}
        }

        /// <summary>
        /// Called when [confirm batch delete button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void OnConfirmBatchDeleteButtonClicked(object sender, EventArgs e)
        {
            //var ids = new List<Guid>();
            //ProductionsModuleItemsMaster.MasterTableView.GetSelectedItems().ToList().ForEach(gridDataItem =>
            //{
            //    var item = gridDataItem.DataItem as ProductionsModuleItemViewModel;
            //    if (item != null)
            //        ids.Add(item.Id);
            //});
            //this.DeleteItems(ids);
        }

        /// <summary>
        /// Handles the DataBound event of the ProductsGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void ProductionsModuleItemsGrid_DataBound(object sender, EventArgs e)
        {
            //var grid = (RadGrid)sender;
            //if (grid.Items.Count == 0)
            //{
            //    this.productionsModuleItemsDecisionScreen.Style["display"] = "block";
            //    this.productionsModuleItemsMainPage.Style["display"] = "none";
            //}
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deletes the items by id.
        /// </summary>
        protected void DeleteItems(List<Guid> ids)
        {
            productionsModuleItemsDataSource.DeleteParameters["ids"].DefaultValue = JsonUtility.ToJson(ids);
            productionsModuleItemsDataSource.Delete();
        }

        /// <summary>
        /// Gets the details page URL.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        protected string GetDetailsPageUrl(string id = null)
        {
            //var returnUrl = Server.UrlEncode(string.Format("{0}?page={1}&sort={2}", Page.Request.Url.AbsolutePath, ProductionsModuleItemsMaster.CurrentPageIndex, sortExpression.Value));

            //if (string.IsNullOrEmpty(id))
            //    return string.Format("{0}?ReturnUrl={1}", this.DetailsViewUrl, returnUrl);

            //return string.Format("{0}?Id={1}&ReturnUrl={2}", this.DetailsViewUrl, id, returnUrl);
            return "Suck it";
        }
        #endregion

        #region Private fields
        private string detailsViewUrl = null;
        private ProductionsModuleItemsService service = new ProductionsModuleItemsService();
        #endregion
    }
}