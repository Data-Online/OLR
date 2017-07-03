<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.Email_Contacts_Table1" Assembly="OLR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="OLR" Assembly="OLR" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Email-Contacts-Table1.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/Email.master" Inherits="OLR.UI.Email_Contacts_Table1" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OLR:ContactsTableControl runat="server" id="ContactsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Contacts&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ContactsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="ContactsTableControlRepeater">		<ITEMTEMPLATE>		<OLR:ContactsTableControlRow runat="server" id="ContactsTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="MobileNumberLabel" Text="Mobile Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="MobileNumber"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="Address1Label" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="Address3Label" Text="Address 3">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address3"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="HometownIdLabel" Text="Hometown">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HometownId"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="EmailLabel" Text="Email">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Email"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address2"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZMemberLabel" Text="PSNZ Member">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PSNZMember"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZMembershipCheckLabel" Text="PSNZ Membership Check">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PSNZMembershipCheck"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OLR:ContactsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactsTableControl_PostbackTracker" runat="server" />
</OLR:ContactsTableControl>

            </td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                