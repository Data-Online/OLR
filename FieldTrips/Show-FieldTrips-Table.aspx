<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.Show_FieldTrips_Table" Assembly="OLR" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-FieldTrips-Table.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OLR.UI.Show_FieldTrips_Table" %>
<%@ Register Tagprefix="Selectors" Namespace="OLR" Assembly="OLR" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td></td></tr><tr><td><OLR:RegistrationsTableControl runat="server" id="RegistrationsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr hidden="true"><td><asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="RegistrationsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="RegistrationsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:RegistrationsTableControlRow runat="server" id="RegistrationsTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="4" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton1" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerNameLabel" Text="Additional Dinner Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AdditionalDinnerName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerTicketLabel" Text="Additional Dinner Ticket">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AdditionalDinnerTicket"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InitialCreationDateLabel" Text="Initial Creation Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InitialCreationDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ContactIdLabel" Text="Contact">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ContactId" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RecordDeletedLabel" Text="Record Deleted">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="RecordDeleted"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="DatePaidLabel" Text="Date Paid">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DatePaid"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EventIdLabel" Text="Event">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="EventId" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RegistrationTypeIdLabel" Text="Registration Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="RegistrationTypeId" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SpecialRequirementsLabel" Text="Special Requirements">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SpecialRequirements"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></OLR:RegistrationsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel></td></tr><tr><td class="panelBL, largeText" style="text-align:center;"></td></tr><tr><td class="panelBL, largeText" style="text-align:center;"><asp:Label runat="server" id="Label4" Text="Total Completed Registrations">	</asp:Label> 
<asp:Literal runat="server" id="RegistrationsCountControl">	</asp:Literal></td></tr><tr><td class="panelBL"></td></tr><tr><td class="panelBL"></td></tr><tr><td class="panelBL"><OLR:RegistrationTypesTableControl runat="server" id="RegistrationTypesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(&quot;Numbers by Registration Type&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="RegistrationTypesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="RegistrationTypesTableControlRepeater">		<ITEMTEMPLATE>		<OLR:RegistrationTypesTableControlRow runat="server" id="RegistrationTypesTableControlRow">
<tr><td class="largeText"><asp:Literal runat="server" id="RegistrationType"></asp:Literal></td><td class="largeText"><asp:Literal runat="server" id="RegistrationsCountControl1">	</asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OLR:RegistrationTypesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RegistrationTypesTableControl_PostbackTracker" runat="server" />
</OLR:RegistrationTypesTableControl>
</td></tr></table>
	<asp:hiddenfield id="RegistrationsTableControl_PostbackTracker" runat="server" />
</OLR:RegistrationsTableControl>
</td></tr><tr><td><OLR:FieldTripsTableControl runat="server" id="FieldTripsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Field Trips&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="FieldTripsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="FieldTripsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:FieldTripsTableControlRow runat="server" id="FieldTripsTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="2" colspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;OLR&quot;) %>" visible="False">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="largeText" colspan="2" rowspan="2"><asp:Literal runat="server" id="Description"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="DateLabel" Text="Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Date0"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TimeLabel" Text="Time">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Time"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr id="FieldTripsTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="4"><BaseClasses:TabContainer runat="server" id="FieldTripsTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="FieldTripOptionsTabPanel" HeaderText="Field Trip Options">	<ContentTemplate>
  <OLR:FieldTripOptionsTableControl runat="server" id="FieldTripOptionsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="FieldTripOptionsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="DescriptionLabel2" tooltip="Sort by Description" Text="Description" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="PlacesAvailableLabel1" tooltip="Sort by PlacesAvailable" Text="Places Available" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Label runat="server" id="Label" Text="First Choice Count">	</asp:Label></th><th class="thc"><asp:Label runat="server" id="Label1" Text="Allocation Count">	</asp:Label></th><th class="thc"></th></tr><asp:Repeater runat="server" id="FieldTripOptionsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:FieldTripOptionsTableControlRow runat="server" id="FieldTripOptionsTableControlRow">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="Description2"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PlacesAvailable"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="FieldTripChoicesCountControl">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FieldTripOptionId" visible="False"></asp:Literal></span>
 
<asp:Literal runat="server" id="FieldTripChoicesCountControl2">	</asp:Literal></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="5"></td></tr></OLR:FieldTripOptionsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="FieldTripOptionsTableControl_PostbackTracker" runat="server" />
</OLR:FieldTripOptionsTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></OLR:FieldTripsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="FieldTripsTableControl_PostbackTracker" runat="server" />
</OLR:FieldTripsTableControl>
</td></tr><tr><td><OLR:AvailableWorkshopsTableControl runat="server" id="AvailableWorkshopsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="&lt;%#String.Concat(&quot;Available Workshops&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion5" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="AvailableWorkshopsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="AvailableWorkshopsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:AvailableWorkshopsTableControlRow runat="server" id="AvailableWorkshopsTableControlRow">
<tr><td class="largeText" colspan="5"><asp:Literal runat="server" id="WorkshopDescription"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="PlacesAvailableLabel2" Text="Places Available">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PlacesAvailable1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Label runat="server" id="Label2" Text="Total Requested">	</asp:Label></td><td class="tableCellValue"><asp:Literal runat="server" id="WorkshopsCountControl1">	</asp:Literal></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="CostLabel" Text="Cost">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Cost"></asp:Literal></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OLR:AvailableWorkshopsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="AvailableWorkshopsTableControl_PostbackTracker" runat="server" />
</OLR:AvailableWorkshopsTableControl>
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
                