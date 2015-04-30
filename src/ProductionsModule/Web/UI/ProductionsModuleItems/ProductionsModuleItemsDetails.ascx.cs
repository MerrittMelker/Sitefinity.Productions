using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.UI;
using System.Xml;
using Telerik.Sitefinity.Web;
using Telerik.Sitefinity.Modules.Pages;
using ProductionsModule.Web.Services.ProductionsModuleItems;
using ProductionsModule.Web.Services.ProductionsModuleItems.ViewModels;

namespace ProductionsModule.Web.UI.ProductionsModuleItems
{
    public partial class ProductionsModuleItemsDetails : UserControl
    {
        #region Properties
        /// <summary>
        /// Gets the master view URL.
        /// </summary>
        /// <value>The master view URL.</value>
        protected string MasterViewUrl
        {
            get
            {
                if (this.masterViewUrl == null)
                {
                    var sitemap = BackendSiteMap.GetCurrentProvider();
                    var node = sitemap.FindSiteMapNodeFromKey(ProductionsModuleClass.ProductionsModuleItemHomePageId.ToString());
                    if (node == null)
                        return "#";
                    this.masterViewUrl = UrlPath.ResolveUrl(node.Url);
                }
                return this.masterViewUrl;
            }
        }
        #endregion

        #region Event Handlers

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            PageManager.ConfigureScriptManager(this.Page, ScriptRef.JQuery);
        }


        /// <summary>
        /// Called when [save button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var prod_season_no = this.prod_season_noControl.Text.Trim();
                var friendlyTitle = this.friendlyTitleControl.Text.Trim();

                var viewModel = new ProductionsModuleItemViewModel()
                {
                    prod_season_no = prod_season_no,
                    FriendlyTitle = friendlyTitle,
                };

                if (this.itemId == Guid.Empty)
                {
                    service.CreateItem(viewModel);
                    this.returnUrl = this.MasterViewUrl;
                }
                else
                {
                    service.UpdateItem(this.itemId, viewModel);
                }

                Response.Redirect(this.returnUrl);
            }
        }
        #endregion

        #region Page events
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.returnUrl = Request.QueryString["ReturnUrl"];
            string idString = Request.QueryString["Id"];

            this.ConfigureCommonControls();

            if (Guid.TryParse(idString, out this.itemId))
            {
                if (!Page.IsPostBack)
                {
                    if (this.itemId == Guid.Empty)
                        SetViewForCreate();
                    else
                        SetViewForEdit();
                }
            }
            else
            {
                if (!Page.IsPostBack)
                    SetViewForCreate();
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Sets the view for create.
        /// </summary>
        private void SetViewForCreate()
        {
            this.ResetForm();
            this.ConfigureVisualControls(true);
        }

        /// <summary>
        /// Sets the view for edit.
        /// </summary>
        private void SetViewForEdit()
        {
            if (this.itemId == Guid.Empty)
                throw new ArgumentException("itemId is not set.");

            this.ConfigureVisualControls(false);

            var viewModel = service.GetItem(itemId);

            this.prod_season_noControl.Text = viewModel.prod_season_no;
            this.friendlyTitleControl.Text = viewModel.FriendlyTitle;

        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ResetForm()
        {
            this.prod_season_noControl.Text = string.Empty;
            this.friendlyTitleControl.Text = string.Empty;
        }

        /// <summary>
        /// Configures the common controls.
        /// </summary>
        private void ConfigureCommonControls()
        {
            this.ConfigureEditorToolset();

            this.goBackButton.NavigateUrl = this.returnUrl;
            this.cancelButton.NavigateUrl = this.returnUrl;
        }

        /// <summary>
        /// Configures the editor toolset.
        /// </summary>
        private void ConfigureEditorToolset()
        {
            Assembly assembly = Assembly.Load("ProductionsModule");
            using (Stream stream = assembly.GetManifestResourceStream("ProductionsModule.Web.Resources.basictools.xml"))
            {
                var simpleToolsXmlDoc = new XmlDocument();
                simpleToolsXmlDoc.Load(stream);
            }
        }

        /// <summary>
        /// Configures the visual controls.
        /// </summary>
        /// <param name="creatingNewItem">The creating new item.</param>
        private void ConfigureVisualControls(bool creatingNewItem)
        {
            this.createButtonText.Visible = creatingNewItem;
            this.saveChangesButtonText.Visible = !creatingNewItem;

            this.titleCreate.Visible = creatingNewItem;
            this.titleEdit.Visible = !creatingNewItem;
        }
        #endregion

        #region Private fields
        private ProductionsModuleItemsService service = new ProductionsModuleItemsService();
        private string masterViewUrl = null;
        private Guid itemId;
        private string returnUrl = null;
        #endregion
    }
}