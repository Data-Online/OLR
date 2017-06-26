﻿<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="OLR" Assembly="OLR" %>

<%@ Control Language="C#" AutoEventWireup="false" Codebehind="DatePagination.ascx.cs" Inherits="OLR.UI.DatePagination" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OLR" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

    <a id="StartOfPageContent"></a>
    
                <table cellpadding="0" cellspacing="0" border="0"><tr><td style="text-align:center;"><OLR:ThemeButton runat="server" id="_PreviousPageInterval" button-causesvalidation="False" button-commandname="PreviousPageInterval" postback="False"></OLR:ThemeButton></td><td style="text-align:center;"><OLR:ThemeButton runat="server" id="_PreviousInterval" button-causesvalidation="False" button-commandname="PreviousInterval" button-text="-" button-tooltip="-" postback="False"></OLR:ThemeButton></td><td class="dfv"><asp:LinkButton runat="server" id="_Day" causesvalidation="False" commandname="Day" text="&lt;%# GetResourceValue(&quot;Btn:Day&quot;, &quot;OLR&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Day&quot;, &quot;OLR&quot;) %>">		
	</asp:LinkButton><asp:Literal runat="server" id="_Day1" Text="&lt;%# GetResourceValue(&quot;Btn:Day&quot;, &quot;OLR&quot;) %>">	</asp:Literal></td><td>&nbsp;</td><td class="dfv"><asp:LinkButton runat="server" id="_Week" causesvalidation="False" commandname="Week" text="&lt;%# GetResourceValue(&quot;Btn:Week&quot;, &quot;OLR&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Week&quot;, &quot;OLR&quot;) %>">		
	</asp:LinkButton><asp:Literal runat="server" id="_Week1" Text="&lt;%# GetResourceValue(&quot;Btn:Week&quot;, &quot;OLR&quot;) %>">	</asp:Literal></td><td>&nbsp;</td><td class="dfv"><asp:LinkButton runat="server" id="_Month" causesvalidation="False" commandname="Month" text="&lt;%# GetResourceValue(&quot;Btn:Month&quot;, &quot;OLR&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Month&quot;, &quot;OLR&quot;) %>">		
	</asp:LinkButton><asp:Literal runat="server" id="_Month1" Text="&lt;%# GetResourceValue(&quot;Btn:Month&quot;, &quot;OLR&quot;) %>">	</asp:Literal></td><td>&nbsp;</td><td class="dfv"><asp:LinkButton runat="server" id="_Quarter" causesvalidation="False" commandname="Quarter" text="&lt;%# GetResourceValue(&quot;Btn:Quarter&quot;, &quot;OLR&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Quarter&quot;, &quot;OLR&quot;) %>">		
	</asp:LinkButton><asp:Literal runat="server" id="_Quarter1" Text="&lt;%# GetResourceValue(&quot;Btn:Quarter&quot;, &quot;OLR&quot;) %>">	</asp:Literal></td><td>&nbsp;</td><td class="dfv"><asp:LinkButton runat="server" id="_Year" causesvalidation="False" commandname="Year" enabled="True" text="&lt;%# GetResourceValue(&quot;Btn:Year&quot;, &quot;OLR&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Year&quot;, &quot;OLR&quot;) %>">		
	</asp:LinkButton> 
<asp:Literal runat="server" id="_Year1" Text="&lt;%# GetResourceValue(&quot;Btn:Year&quot;, &quot;OLR&quot;) %>">	</asp:Literal></td><td style="text-align:center;"><OLR:ThemeButton runat="server" id="_NextInterval" button-causesvalidation="False" button-commandname="NextInterval" button-text="+" button-tooltip="+" postback="False"></OLR:ThemeButton></td><td style="text-align:center;"><OLR:ThemeButton runat="server" id="_NextPageInterval" button-causesvalidation="False" button-commandname="NextPageInterval" postback="False"></OLR:ThemeButton></td><td style="text-align:left;" nowrap="nowrap"><asp:Literal runat="server" id="_StartDate1" visible="False">	</asp:Literal></td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>

                