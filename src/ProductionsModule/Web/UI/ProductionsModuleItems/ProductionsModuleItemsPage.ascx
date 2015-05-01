<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductionsModuleItemsPage.ascx.cs" Inherits="ProductionsModule.Web.UI.ProductionsModuleItems.ProductionsModuleItemsPage" %>
<%@ Register TagPrefix="sitefinity" Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register TagPrefix="telerik" Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" %>
<%@ Register TagPrefix="cust" Namespace="ProductionsModule.Web.UI.ProductionsModuleItems" Assembly="ProductionsModule" %>

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server">
    <sitefinity:ResourceFile Name="Styles/Grid.css" />
    <sitefinity:ResourceFile Name="Styles/MenuMoreActions.css" />
    <sitefinity:ResourceFile Name="Styles/Window.css" />
    <sitefinity:ResourceFile Name="Styles/Layout.css" />
</sitefinity:ResourceLinks>
<sitefinity:ResourceLinks ID="resourcesLinks2" runat="server" UseEmbeddedThemes="true" Theme="Default">
    <sitefinity:ResourceFile Name="ProductionsModule.Web.Resources.CustomStylesWebFormsView.css" AssemblyInfo="ProductionsModule.ProductionsModuleClass, ProductionsModule" Static="True" />
</sitefinity:ResourceLinks>
<cust:CustomRadAjaxManager ID="RadAjaxManager1" runat="server">
    <AjaxSettings>
        <telerik:AjaxSetting AjaxControlID="ProductionsModuleItemsMaster">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="ProductionsModuleItemsMaster" LoadingPanelID="RadAjaxLoadingPanel1"></telerik:AjaxUpdatedControl>
            </UpdatedControls>
        </telerik:AjaxSetting>
    </AjaxSettings>
</cust:CustomRadAjaxManager>

<telerik:RadAjaxLoadingPanel runat="server" ID="RadAjaxLoadingPanel1" ClientIDMode="AutoID"></telerik:RadAjaxLoadingPanel>

<h1 class="sfBreadCrumb">
    <asp:Literal ID="ProductionsModule" runat="server" Text='ProductionsModule'></asp:Literal>
</h1>

<asp:Button runat="server" ID="Button1" Text="Click To Randomly Change Text" OnClick="foo"/>

<div class="sfMain sfClearfix" runat="server" id="productionsModuleItemsMainPage">
    <div class="sfContent" >
       

        <!-- main area -->
        <div class="sfWorkArea" id="workArea">
            <div runat="server">
                <telerik:RadGrid ID="ProductionsModuleItemsMaster" ClientIDMode="AutoID" runat="server" DataSourceID="productionsModuleItemsDataSource" ClientSettings-Selecting-EnableDragToSelectRows="false"
                    AllowFilteringByColumn="True" AllowPaging="true" AllowCustomPaging="true" AllowSorting="True" AutoGenerateColumns="false" AllowMultiRowSelection="true" OnDataBound="ProductionsModuleItemsGrid_DataBound" >
                    <MasterTableView CssClass="rgTopOffset rgMasterTable" AllowFilteringByColumn="True" >
                        <Columns>
                             <telerik:GridTemplateColumn HeaderText='Production Season #' ItemStyle-CssClass="sfLarge">
                                <ItemTemplate>
                                    <div class="dmDescription"><%# Eval("prod_season_no") %></div>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText='Description' ItemStyle-CssClass="sfLarge">
                                <ItemTemplate>
                                    <div class="dmDescription"><%# Eval("prod_desc") %></div>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText='First' ItemStyle-CssClass="sfLarge">
                                <ItemTemplate>
                                    <div class="dmDescription"><%# Eval("first_dt", "{0:d}") %></div>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText='Last' ItemStyle-CssClass="sfLarge">
                                <ItemTemplate>
                                    <div class="dmDescription"><%# Eval("last_dt", "{0:d}") %></div>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridCheckBoxColumn UniqueName="Enabled" HeaderText="Enabled" AllowSorting="true"></telerik:GridCheckBoxColumn>
                        </Columns>
                    </MasterTableView>
                    <PagerStyle Mode="NumericPages" />
                </telerik:RadGrid>
                <asp:HiddenField ID="selectedItemId" runat="server" />
                <asp:HiddenField ID="sortExpression" runat="server" Value="DateCreated DESC" />
                <asp:ObjectDataSource ID="productionsModuleItemsDataSource" runat="server" DeleteMethod="Delete" EnablePaging="true" SelectCountMethod="GetTotalItemsCount"
                    SelectMethod="GetItems" TypeName="ProductionsModule.Web.Services.ProductionsModuleItems.ProductionsModuleItemsService">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="sortExpression" PropertyName="Value" Direction="Input" Name="sortExpression" Type="String" />
                        <asp:Parameter />
                    </SelectParameters>
                    <DeleteParameters>
                        <asp:Parameter Name="ids" Direction="Input" Type="String" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    jQuery("body").addClass("sfNoSidebar");
</script>