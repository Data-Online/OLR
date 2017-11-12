<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="RegisterMe.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/Registration.master" Inherits="OLR.UI.RegisterMe" %>
<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.RegisterMe" Assembly="OLR" %>

<%@ Register Tagprefix="OLR" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OLR:RegistrationsRecordControl runat="server" id="RegistrationsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="RegistrationsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="largeText"><BaseClasses:QuickSelector runat="server" id="ContactId" redirecturl="" visible="False"></BaseClasses:QuickSelector></td></tr><tr><td class="tableCellLabel"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="largeText" valign="middle">Your Details</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion6" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OLR:ContactsRecordControl runat="server" id="ContactsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="ContactsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" colspan="3"><table><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EmailLabel" Text="Email">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="Email"></asp:Literal> </td><td class="tableCellLabel"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ContactId1" visible="False"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstName" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="FirstNameRequiredFieldValidator" ControlToValidate="FirstName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FirstNameTextBoxMaxLengthValidator" ControlToValidate="FirstName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="LastName" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="LastNameRequiredFieldValidator" ControlToValidate="LastName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Last Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="LastNameTextBoxMaxLengthValidator" ControlToValidate="LastName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Last Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MobileNumberLabel" Text="Mobile Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="MobileNumber" Columns="20" MaxLength="42" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MobileNumberTextBoxMaxLengthValidator" ControlToValidate="MobileNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Mobile Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="HometownIdLabel" Text="Hometown">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="HometownId"></BaseClasses:QuickSelector> </td></tr><tr><td class="tableCellLabel" colspan="4"><table><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZMemberLabel" Text="PSNZ Member">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="PSNZMember"></asp:CheckBox> </td><td class="tableCellLabel"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td><td class="tableCellLabel"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZAppliedForLabel" Text="PSNZ Applied For">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="PSNZAppliedFor"></asp:CheckBox></td><td class="tableCellLabel"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td><td class="tableCellValue"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td><td><asp:Literal runat="server" id="NZIPPMemberLabel" Text="NZIPP Member">	</asp:Literal></td><td><asp:CheckBox runat="server" id="NZIPPMember"></asp:CheckBox></td></tr></table>
</td></tr></table>
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><OLR:PhotoClubContactLinksTableControl runat="server" id="PhotoClubContactLinksTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;Photographic clubs you belong to&quot;) %>">	</asp:Literal>
                      </td><td><img src="../Images/space.gif" alt="" /></td><td><img src="../Images/space.gif" alt="" /></td><td><asp:ImageButton runat="server" id="NewButton" causesvalidation="false" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="PhotoClubContactLinksTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display:none" colspan="3"></th></tr><asp:Repeater runat="server" id="PhotoClubContactLinksTableControlRepeater">		<ITEMTEMPLATE>
<tr><asp:Repeater runat="server" id="PhotoClubContactLinksTableControlCellRepeater">		<ITEMTEMPLATE>		<OLR:PhotoClubContactLinksTableControlRow runat="server" id="PhotoClubContactLinksTableControlRow">
<td class="galleryttc" style="width:33%;"><asp:Literal runat="server" id="PhotoClubId"></asp:Literal> 
<asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="Remove">		
	</asp:ImageButton></td></OLR:PhotoClubContactLinksTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</tr></ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="PhotoClubContactLinksTableControl_PostbackTracker" runat="server" />
</OLR:PhotoClubContactLinksTableControl>
 
</td><td class="tableCellLabel"><OLR:HonourContactLinksTableControl runat="server" id="HonourContactLinksTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="&lt;%#String.Concat(&quot;Photographic honours&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"></td><td class="dht" valign="middle"></td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="NewButton1" causesvalidation="false" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="HonourContactLinksTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display:none" colspan="3"></th></tr><asp:Repeater runat="server" id="HonourContactLinksTableControlRepeater">		<ITEMTEMPLATE>
<tr><asp:Repeater runat="server" id="HonourContactLinksTableControlCellRepeater">		<ITEMTEMPLATE>		<OLR:HonourContactLinksTableControlRow runat="server" id="HonourContactLinksTableControlRow">
<td class="galleryttc" style="width:33%;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HonourId"></asp:Literal></span>
 
<asp:ImageButton runat="server" id="DeleteRowButton1" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="Remove">		
	</asp:ImageButton></td></OLR:HonourContactLinksTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</tr></ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="HonourContactLinksTableControl_PostbackTracker" runat="server" />
</OLR:HonourContactLinksTableControl>
</td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactsRecordControl_PostbackTracker" runat="server" />
</OLR:ContactsRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="dht" valign="middle" style="vertical-align:top;"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="largeText" valign="middle">Registration Details</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion5" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RegistrationTypeIdLabel" Text="Registration Type">	</asp:Literal></td><td class="tableCellValue" rowspan="2"><asp:RadioButtonList runat="server" id="RegistrationTypeId" RepeatLayout="Flow" autopostback="True"></asp:RadioButtonList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="RegistrationTypeIdRequiredFieldValidator" ControlToValidate="RegistrationTypeId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Registration Type&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator></td><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerTicketLabel" Text="Additional Dinner Ticket">	</asp:Literal></td><td class="tableCellValue" style="padding-right:318px"><asp:CheckBox runat="server" id="AdditionalDinnerTicket" autopostback="True" tooltip="Select if you require an additional diner" width="100%"></asp:CheckBox></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RegistrationId1" visible="False"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerNameLabel" Text="Additional Dinner Name" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="AdditionalDinnerName" Columns="40" MaxLength="50" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AdditionalDinnerNameTextBoxMaxLengthValidator" ControlToValidate="AdditionalDinnerName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Additional Dinner Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" valign="middle" style="vertical-align:top;"><asp:Literal runat="server" id="SpecialRequirementsLabel" Text="Special Requirements">	</asp:Literal></td><td class="tableCellValue" colspan="4"><asp:TextBox runat="server" id="SpecialRequirements" MaxLength="200" columns="120" cssclass="field_input" rows="2" textmode="MultiLine" width="70%"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SpecialRequirementsTextBoxMaxLengthValidator" ControlToValidate="SpecialRequirements" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OLR&quot;).Replace(&quot;{FieldName}&quot;, &quot;Special Requirements&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="dht" valign="middle" style="vertical-align:top;"><BaseClasses:TabContainer runat="server" id="RegistrationsRecordControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Field Trip Choices">	<ContentTemplate> 
  <OLR:FieldTripChoicesTableControl runat="server" id="FieldTripChoicesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="largeText" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(&quot;Field Trip Choices&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="FieldTripChoicesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><asp:Repeater runat="server" id="FieldTripChoicesTableControlRepeater">		<ITEMTEMPLATE>		<OLR:FieldTripChoicesTableControlRow runat="server" id="FieldTripChoicesTableControlRow">
<tr><td class="dht" colspan="3" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FieldTripId1" visible="True"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="FieldTripId" redirecturl="" visible="False"></BaseClasses:QuickSelector></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FieldTripOptionIdLabel" Text="EvaluateFormula(&quot;= \&quot;First Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FieldTripOptionId" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="FieldTripOptionId2Label" Text="EvaluateFormula(&quot;= \&quot;Second Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FieldTripOptionId2" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="FieldTripOptionId3Label" Text="EvaluateFormula(&quot;= \&quot;Third Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FieldTripOptionId3" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="RegistrationId" redirecturl="" visible="False"></BaseClasses:QuickSelector></td></tr><tr><td class="tableRowDivider" colspan="4"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OLR:FieldTripChoicesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="FieldTripChoicesTableControl_PostbackTracker" runat="server" />
</OLR:FieldTripChoicesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Workshops">	<ContentTemplate> 
  <table><tr width="100%"><td><OLR:WorkshopsTableControl runat="server" id="WorkshopsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="largeText" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Workshops&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion7" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WorkshopsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><asp:Repeater runat="server" id="WorkshopsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:WorkshopsTableControlRow runat="server" id="WorkshopsTableControlRow">
<tr><td class="dht" colspan="3" style="text-align:left;"><asp:Literal runat="server" id="AvailableWorkshopId"></asp:Literal></td><td>&nbsp;</td><td>&nbsp;</td><td class="tableCellLabel"><asp:Literal runat="server" id="AttendingLabel" Text="EvaluateFormula(&quot;= \&quot;Attending?\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Attending"></asp:CheckBox> </td></tr><tr><td class="tableRowDivider" colspan="3"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OLR:WorkshopsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WorkshopsTableControl_PostbackTracker" runat="server" />
</OLR:WorkshopsTableControl>
</td></tr></table>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RegistrationsRecordControl_PostbackTracker" runat="server" />
</OLR:RegistrationsRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OLR:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OLR&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OLR&quot;) %>" postback="True"></OLR:ThemeButton></td><td><OLR:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OLR&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OLR&quot;) %>" postback="False"></OLR:ThemeButton></td></tr></table>
</td></tr></table>
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
                