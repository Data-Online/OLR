<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-View-AllDataExtract-Table.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OLR.UI.Show_View_AllDataExtract_Table" %>
<%@ Register Tagprefix="OLR" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OLR" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OLR" Namespace="OLR.UI.Controls.Show_View_AllDataExtract_Table" Assembly="OLR" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OLR:View_AllDataExtractTableControl runat="server" id="View_AllDataExtractTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;All Data Extract&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OLR:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OLR&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OLR&quot;) %>"></OLR:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OLR:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OLR&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OLR&quot;) %>"></OLR:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>

                <asp:TextBox runat="server" id="SearchText" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="SearchTextAutoCompleteExtender" runat="server" TargetControlID="SearchText" ServiceMethod="GetAutoCompletionList_SearchText" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td colspan="2" class="popupTableCellValue"></td><td class="popupTableCellValue"><OLR:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OLR&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OLR&quot;) %>" postback="False"></OLR:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OLR&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OLR&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="View_AllDataExtractTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="View_AllDataExtractTableControlRepeater">		<ITEMTEMPLATE>		<OLR:View_AllDataExtractTableControlRow runat="server" id="View_AllDataExtractTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="ContactIdLabel" Text="Contact">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ContactId"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="RegistrationIdLabel" Text="Registration">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RegistrationId"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InitialCreationDateLabel" Text="Initial Creation Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InitialCreationDate"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="DatePaidLabel" Text="Date Paid">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DatePaid"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FirstName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LastName"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="Address1Label" Text="Address 1">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="Address3Label" Text="Address 3">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address3"></asp:Literal> </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TownNameLabel" Text="Town Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="TownName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="MobileNumberLabel" Text="Mobile Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="MobileNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="EmailLabel" Text="Email">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Email"></asp:Literal> </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZMemberLabel" Text="PSNZ Member">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PSNZMember"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZAppliedForLabel" Text="PSNZ Applied For">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PSNZAppliedFor"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="PSNZMembershipCheckLabel" Text="PSNZ Membership Check">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PSNZMembershipCheck"></asp:Literal> </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RegistrationTypeLabel" Text="Registration Type">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="RegistrationType"></asp:Literal></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerTicketLabel" Text="Additional Dinner Ticket">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AdditionalDinnerTicket"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AdditionalDinnerNameLabel" Text="Additional Dinner Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AdditionalDinnerName"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SpecialRequirementsLabel" Text="Special Requirements">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SpecialRequirements"></asp:Literal> </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="Description1Label" Text="Description 1">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="Description1"></asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT1_1Label" Text="EvaluateFormula(&quot;= \&quot;First Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT1_1" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="FTA1Label" Text="EvaluateFormula(&quot;= \&quot;Allocated1\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FTA1" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT1_2Label" Text="EvaluateFormula(&quot;= \&quot;Second Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT1_2" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT1_3Label" Text="EvaluateFormula(&quot;= \&quot;Third Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT1_3" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="Description2Label" Text="Description 2">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="Description2"></asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT2_1Label" Text="EvaluateFormula(&quot;= \&quot;First Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT2_1" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="FTA2Label" Text="EvaluateFormula(&quot;= \&quot;Allocated2\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FTA2" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT2_2Label" Text="EvaluateFormula(&quot;= \&quot;Second Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT2_2" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FT2_3Label" Text="EvaluateFormula(&quot;= \&quot;Third Choice\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="FT2_3" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WorkshopDescriptionLabel" Text="EvaluateFormula(&quot;= \&quot;Workshop\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WorkshopDescription"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="AttendingLabel" Text="Attending">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="Attending"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="WorkshopDescription2Label" Text="EvaluateFormula(&quot;= \&quot;Workshop\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WorkshopDescription2"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="Attending2Label" Text="EvaluateFormula(&quot;= \&quot;Attending\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="Attending2"></asp:Literal></td></tr><tr><td class="tableRowDivider" colspan="6"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OLR:View_AllDataExtractTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OLR:PaginationModern runat="server" id="Pagination"></OLR:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="View_AllDataExtractTableControl_PostbackTracker" runat="server" />
</OLR:View_AllDataExtractTableControl>

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
                