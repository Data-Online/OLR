<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Edit-Configuration-Table.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OLR.UI.Edit_Configuration_Table" %>
<%@ Register Tagprefix="OLR" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.Edit_Configuration_Table" Assembly="OLR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="OLR" Assembly="OLR" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OLR:ConfigurationTableControl runat="server" id="ConfigurationTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Configuration&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ConfigurationTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc"></th></tr><asp:Repeater runat="server" id="ConfigurationTableControlRepeater">		<ITEMTEMPLATE>		<OLR:ConfigurationTableControlRow runat="server" id="ConfigurationTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="SendEmailCopiesLabel" Text="Send Email Copies">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SendEmailCopies"></asp:CheckBox> </td><td class="tableCellLabel"><asp:Literal runat="server" id="EmailCopiesAddressLabel" Text="Email Copies Address">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EmailCopiesAddress" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EmailCopiesAddressTextBoxMaxLengthValidator" ControlToValidate="EmailCopiesAddress" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email Copies Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EventId" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EventIdRequiredFieldValidator" ControlToValidate="EventId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Event&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EventIdTextBoxMaxLengthValidator" ControlToValidate="EventId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Event&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableRowDivider" colspan="4"></td><td class="tableRowDivider"></td></tr></OLR:ConfigurationTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr><tr><td>
                    <asp:ImageButton runat="server" id="SaveButton1" causesvalidation="True" commandname="UpdateData" imageurl="../Images/ButtonBarSave.gif" onmouseout="this.src=&#39;../Images/ButtonBarSave.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarSaveOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OLR:PaginationModern runat="server" id="Pagination"></OLR:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ConfigurationTableControl_PostbackTracker" runat="server" />
</OLR:ConfigurationTableControl>

            </td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                