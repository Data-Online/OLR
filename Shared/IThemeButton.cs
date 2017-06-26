
using Microsoft.VisualBasic;
  
namespace OLR.UI
{

  

    public interface IThemeButton {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  