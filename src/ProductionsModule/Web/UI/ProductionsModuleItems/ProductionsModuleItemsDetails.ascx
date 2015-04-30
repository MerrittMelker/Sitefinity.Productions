<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductionsModuleItemsDetails.ascx.cs" Inherits="ProductionsModule.Web.UI.ProductionsModuleItems.ProductionsModuleItemsDetails" %>
<%@ Register TagPrefix="sitefinity" Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register TagPrefix="telerik" Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" %>

<sitefinity:ResourceLinks ID="resourcesLinks2" runat="server" UseEmbeddedThemes="true" Theme="Default">    
    <sitefinity:ResourceFile Name="ProductionsModule.Web.Resources.CustomStylesWebFormsView.css" AssemblyInfo="ProductionsModule.ProductionsModuleClass, ProductionsModule" Static="True" />
</sitefinity:ResourceLinks>
<div class="sfDialog sfFormDialog sfMaxDialogFake">
    <fieldset class="sfNewContentForm">
        <asp:HyperLink ID="goBackButton" runat="server" CssClass="sfBack">
                <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, BackToLabel %>'></asp:Literal>
        </asp:HyperLink>
        <h1>
            <asp:Literal ID="titleCreate" runat="server" Text='<%$Resources:ProductionsModuleResources, CreateAProductionsModuleItem %>'></asp:Literal>
            <asp:Literal ID="titleEdit" runat="server" Text='<%$Resources:ProductionsModuleResources, EditAProductionsModuleItem %>'></asp:Literal>
        </h1>
    
        <div class="sfForm sfFirstForm">
            <ul class="sfFormIn">
                <li class="sfTitleField">
                    <label for="<%= prod_season_noControl.ClientID %>" class="sfTxtLbl">
                        <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemprod_season_noLabel %>'></asp:Literal>
                    </label>
                    <asp:TextBox ID="prod_season_noControl" runat="server" ValidationGroup="details" CssClass="sfTxt"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="productionsModuleItemprod_season_noRequiredValidator" runat="server" ValidationGroup="details" ControlToValidate="prod_season_noControl" Display="Dynamic">
                        <div class="sfError"><asp:Literal runat="server" ID="productionsModuleItemprod_season_noCannotBeEmpty" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemprod_season_noCannotBeEmpty %>' /></div>
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="productionsModuleItemprod_season_noLengthValidator" runat="server" ControlToValidate="prod_season_noControl" ValidationGroup="details" Display="Dynamic" ValidationExpression="^([\w\W]{1,255})$">
                        <div class="sfError"><asp:Literal ID="productionsModuleItemprod_season_noLengthErrorLiteral" runat="server" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemprod_season_noInvalidLength %>' /></div>
                    </asp:RegularExpressionValidator>
                </li>
                <li class="sfFormSeparator">
                    <label for="<%= friendlyTitleControl.ClientID %>" class="sfTxtLbl">
                        <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemFriendlyTitleLabel %>'></asp:Literal>
                    </label>
                    <asp:TextBox ID="friendlyTitleControl" runat="server" CssClass="sfTxt"></asp:TextBox>
                    <div class="sfExample">
                        <asp:Literal ID="productionsModuleItemFriendlyTitleDescription" runat="server" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemFriendlyTitleDescription %>'></asp:Literal>
                    </div>
                    <asp:RegularExpressionValidator ID="productionsModuleItemFriendlyTitleLengthValidator" runat="server" ControlToValidate="friendlyTitleControl" ValidationGroup="details" Display="Dynamic" ValidationExpression="^([\w\W]{1,255})$">
                        <div class="sfError"><asp:Literal ID="productionsModuleItemFriendlyTitleLengthErrorLiteral" runat="server" Text='<%$Resources:ProductionsModuleResources, ProductionsModuleItemFriendlyTitleInvalidLength %>' /></div>
                    </asp:RegularExpressionValidator>
                </li>
            </ul>
        </div>

        <div class="sfButtonArea sfMainFormBtns">
            <asp:LinkButton ID="saveButton" runat="server" OnClick="OnSaveButtonClick" ValidationGroup="details" CausesValidation="true" CssClass="sfLinkBtn sfSave">
                <span id="createButtonText" runat="server" class="sfLinkBtnIn">
                    <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, CreateThisProductionsModuleItemButton %>' />
                </span>
                <span id="saveChangesButtonText" runat="server" class="sfLinkBtnIn">
                    <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, SaveChangesLabel %>' />
                </span>
            </asp:LinkButton>
            <asp:HyperLink ID="cancelButton" runat="server" CssClass="sfCancel sfCancelProductionsModuleItemButton">
                <asp:Literal runat="server" Text='<%$Resources:ProductionsModuleResources, CancelLabel %>' />
            </asp:HyperLink>
        </div>
    </fieldset>
</div>