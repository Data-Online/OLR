<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-FieldTrips-Gallery2.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OLR.UI.Show_FieldTrips_Gallery2" %>
<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.Show_FieldTrips_Gallery2" Assembly="OLR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OLR" TagName="InfinitePagination" Src="../Shared/InfinitePagination.ascx" %>

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
                        <OLR:FieldTripsTableControl runat="server" id="FieldTripsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Field Trips&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="FieldTripsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display:none" colspan="3"></th></tr><asp:Repeater runat="server" id="FieldTripsTableControlRepeater">		<ITEMTEMPLATE>
		<asp:Repeater runat="server" id="FieldTripsTableControlRepeater1">				<ITEMTEMPLATE>
<tr><asp:Repeater runat="server" id="FieldTripsTableControlCellRepeater">		<ITEMTEMPLATE>		<OLR:FieldTripsTableControlRow runat="server" id="FieldTripsTableControlRow">
<td class="galleryttc" style="width:33%;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FieldTripId"></asp:Literal></span>
 <br />
<asp:LinkButton runat="server" id="Description" causesvalidation="False" commandname="Redirect"></asp:LinkButton> <br />
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="Date0"></asp:Literal></span>
 <br />
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="Time"></asp:Literal></span>
 <br />
</td><td class="galleryttc" style="width:33%;"><asp:chart id="FieldTripsCountChart" AlternateText="Field Trips  x  Description" width="300" height="300" runat="server" enableviewstate="true" /></td><td class="galleryttc" style="width:33%;"><asp:chart id="FieldTripsCountChart1" AlternateText="Field Trips  x  Description" width="300" height="300" runat="server" enableviewstate="true" /></td></OLR:FieldTripsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</tr></ITEMTEMPLATE>

</asp:Repeater>
</ITEMTEMPLATE>
</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OLR:InfinitePagination runat="server" id="Pagination"></OLR:InfinitePagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="FieldTripsTableControl_PostbackTracker" runat="server" />
</OLR:FieldTripsTableControl>

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
                