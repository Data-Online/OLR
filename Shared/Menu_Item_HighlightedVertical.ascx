﻿<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="OLR" Assembly="OLR" %>

<%@ Control Language="C#" AutoEventWireup="false" Codebehind="Menu_Item_HighlightedVertical.ascx.cs" Inherits="OLR.UI.Menu_Item_HighlightedVertical" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);" width="100%"><tr><td class="mvoTL"><img src="../Images/space.gif" height="5" width="5" alt="" /></td><td class="mvoT"><img src="../Images/space.gif" height="5" width="2" alt="" /></td><td class="mvoTR"><img src="../Images/space.gif" height="5" width="5" alt="" /></td></tr><tr><td class="mvoL"><img src="../Images/space.gif" height="14" width="5" alt="" /></td><td class="mvoC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="menu">		
	</asp:LinkButton></td><td class="mvoR"><img src="../Images/space.gif" height="14" width="5" alt="" /></td></tr><tr><td class="mvoBL"><img src="../Images/space.gif" height="3" width="5" alt="" /></td><td class="mvoB"><img src="../Images/space.gif" height="3" width="2" alt="" /></td><td class="mvoBR"><img src="../Images/space.gif" height="3" width="5" alt="" /></td></tr></table>