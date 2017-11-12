
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_View_Registered_Table.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using OLR.Business;
using OLR.Data;
using OLR.UI;
using OLR;
//using OLR.UI.Helpers;


#endregion


namespace OLR.UI.Controls.Show_View_Registered_Table
{
  

#region "Section 1: Place your customizations here."

    
public class View_RegisteredTableControlRow : BaseView_RegisteredTableControlRow
{

        // The BaseView_RegisteredTableControlRow implements code for a ROW within the
        // the View_RegisteredTableControl table.  The BaseView_RegisteredTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of View_RegisteredTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        public override void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
            // Set delete flag only
            string contactToDelete = this.ContactId.Text;
            bool deletedOkay = CustomTools.CustomStoredProcedures.FlagRegistrationAsDeleted(contactToDelete);
            //var userRecord = (ContactsTable.GetRecord(contactToDelete, false));
            if (deletedOkay)
                this.Page.Response.Redirect("../view_Registered/Show-View-Registered-Table.aspx");
            else
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", "Error deleteing record");

        }

        public override void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {

            string targetUrl = System.Configuration.ConfigurationManager.AppSettings["RegistrationUrlApi"];
            //Settings.RegistrationUrlApi;
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            var validationUid = this.ValidationUid.Text;
            string url = String.Format(targetUrl, validationUid, "&A=dps");
            //string url = String.Format("http://localhost:60892/Home/RegisterMe?Registration={0}", validationUid);
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];

            bool shouldRedirect = true;
            string target = null;
            if (target == null) target = ""; // avoid warning on VS

            try
            {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();

                url = this.ModifyRedirectUrl(url, "", false);
                url = this.Page.ModifyRedirectUrl(url, "", false);

            }
            catch (Exception ex)
            {
                // Upon error, rollback the transaction
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;

                // Report the error message to the end user
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);

            }
            finally
            {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect)
            {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);

            }

        }
    }

  

public class View_RegisteredTableControl : BaseView_RegisteredTableControl
{
    // The BaseView_RegisteredTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The View_RegisteredTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

//public class FieldTripChoicesTableControl : BaseFieldTripChoicesTableControl
//{
//    // The BaseFieldTripChoicesTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The FieldTripChoicesTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//
//public class FieldTripChoicesTableControlRow : BaseFieldTripChoicesTableControlRow
//{
//      
//        // The BaseFieldTripChoicesTableControlRow implements code for a ROW within the
//        // the FieldTripChoicesTableControl table.  The BaseFieldTripChoicesTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of FieldTripChoicesTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//
public class FieldTripChoicesTableControl1 : BaseFieldTripChoicesTableControl1
{
    // The BaseFieldTripChoicesTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The FieldTripChoicesTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class FieldTripChoicesTableControl1Row : BaseFieldTripChoicesTableControl1Row
{
      
        // The BaseFieldTripChoicesTableControl1Row implements code for a ROW within the
        // the FieldTripChoicesTableControl1 table.  The BaseFieldTripChoicesTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of FieldTripChoicesTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
public class WorkshopsTableControl : BaseWorkshopsTableControl
{
    // The BaseWorkshopsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The WorkshopsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class WorkshopsTableControlRow : BaseWorkshopsTableControlRow
{
      
        // The BaseWorkshopsTableControlRow implements code for a ROW within the
        // the WorkshopsTableControl table.  The BaseWorkshopsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of WorkshopsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the FieldTripChoicesTableControl1Row control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in FieldTripChoicesTableControl1Row.
public class BaseFieldTripChoicesTableControl1Row : OLR.UI.BaseApplicationRecordControl
{
        public BaseFieldTripChoicesTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in FieldTripChoicesTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in FieldTripChoicesTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.FieldTripAllocated.Click += FieldTripAllocated_Click;
                        
                    this.FieldTripId1.Click += FieldTripId1_Click;
                        
                    this.FieldTripOptionId1.Click += FieldTripOptionId1_Click;
                        
                    this.FieldTripOptionId21.Click += FieldTripOptionId21_Click;
                        
                    this.FieldTripOptionId31.Click += FieldTripOptionId31_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.FieldTripChoices record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = FieldTripChoicesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseFieldTripChoicesTableControl1 when the data for the entire
            // table is loaded.
            
            this.DataSource = new FieldTripChoicesRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetFieldTripAllocated();
                SetFieldTripAllocatedLabel();
                SetFieldTripId1();
                SetFieldTripOptionId1();
                SetFieldTripOptionId21();
                SetFieldTripOptionId2Label();
                SetFieldTripOptionId31();
                SetFieldTripOptionId3Label();
                SetFieldTripOptionIdLabel();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetFieldTripAllocated()
        {
            
                    
            // Set the FieldTripAllocated LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.FieldTripChoices database record.

            // this.DataSource is the DatabaseOLR_db%dbo.FieldTripChoices record retrieved from the database.
            // this.FieldTripAllocated is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripAllocatedSpecified) {
                								
                // If the FieldTripAllocated is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = FieldTripChoicesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(FieldTripChoicesTable.FieldTripAllocated);
               if(_isExpandableNonCompositeForeignKey &&FieldTripChoicesTable.FieldTripAllocated.IsApplyDisplayAs)
                                  
                     formattedValue = FieldTripChoicesTable.GetDFKA(this.DataSource.FieldTripAllocated.ToString(),FieldTripChoicesTable.FieldTripAllocated, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(FieldTripChoicesTable.FieldTripAllocated);
                                  
                                
                this.FieldTripAllocated.Text = formattedValue;
                
                  this.FieldTripAllocated.ToolTip = "Go to " + this.FieldTripAllocated.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FieldTripAllocated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripAllocated.Text = FieldTripChoicesTable.FieldTripAllocated.Format(FieldTripChoicesTable.FieldTripAllocated.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripId1()
        {
            
                    
            // Set the FieldTripId LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.FieldTripChoices database record.

            // this.DataSource is the DatabaseOLR_db%dbo.FieldTripChoices record retrieved from the database.
            // this.FieldTripId1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripIdSpecified) {
                								
                // If the FieldTripId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = FieldTripChoicesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(FieldTripChoicesTable.FieldTripId);
               if(_isExpandableNonCompositeForeignKey &&FieldTripChoicesTable.FieldTripId.IsApplyDisplayAs)
                                  
                     formattedValue = FieldTripChoicesTable.GetDFKA(this.DataSource.FieldTripId.ToString(),FieldTripChoicesTable.FieldTripId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(FieldTripChoicesTable.FieldTripId);
                                  
                                
                this.FieldTripId1.Text = formattedValue;
                
                  this.FieldTripId1.ToolTip = "Go to " + this.FieldTripId1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FieldTripId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripId1.Text = FieldTripChoicesTable.FieldTripId.Format(FieldTripChoicesTable.FieldTripId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripOptionId1()
        {
            
                    
            // Set the FieldTripOptionId LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.FieldTripChoices database record.

            // this.DataSource is the DatabaseOLR_db%dbo.FieldTripChoices record retrieved from the database.
            // this.FieldTripOptionId1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionIdSpecified) {
                								
                // If the FieldTripOptionId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = FieldTripChoicesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(FieldTripChoicesTable.FieldTripOptionId);
               if(_isExpandableNonCompositeForeignKey &&FieldTripChoicesTable.FieldTripOptionId.IsApplyDisplayAs)
                                  
                     formattedValue = FieldTripChoicesTable.GetDFKA(this.DataSource.FieldTripOptionId.ToString(),FieldTripChoicesTable.FieldTripOptionId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(FieldTripChoicesTable.FieldTripOptionId);
                                  
                                
                this.FieldTripOptionId1.Text = formattedValue;
                
                  this.FieldTripOptionId1.ToolTip = "Go to " + this.FieldTripOptionId1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FieldTripOptionId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId1.Text = FieldTripChoicesTable.FieldTripOptionId.Format(FieldTripChoicesTable.FieldTripOptionId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripOptionId21()
        {
            
                    
            // Set the FieldTripOptionId2 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.FieldTripChoices database record.

            // this.DataSource is the DatabaseOLR_db%dbo.FieldTripChoices record retrieved from the database.
            // this.FieldTripOptionId21 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionId2Specified) {
                								
                // If the FieldTripOptionId2 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = FieldTripChoicesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(FieldTripChoicesTable.FieldTripOptionId2);
               if(_isExpandableNonCompositeForeignKey &&FieldTripChoicesTable.FieldTripOptionId2.IsApplyDisplayAs)
                                  
                     formattedValue = FieldTripChoicesTable.GetDFKA(this.DataSource.FieldTripOptionId2.ToString(),FieldTripChoicesTable.FieldTripOptionId2, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(FieldTripChoicesTable.FieldTripOptionId2);
                                  
                                
                this.FieldTripOptionId21.Text = formattedValue;
                
                  this.FieldTripOptionId21.ToolTip = "Go to " + this.FieldTripOptionId21.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FieldTripOptionId2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId21.Text = FieldTripChoicesTable.FieldTripOptionId2.Format(FieldTripChoicesTable.FieldTripOptionId2.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripOptionId31()
        {
            
                    
            // Set the FieldTripOptionId3 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.FieldTripChoices database record.

            // this.DataSource is the DatabaseOLR_db%dbo.FieldTripChoices record retrieved from the database.
            // this.FieldTripOptionId31 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionId3Specified) {
                								
                // If the FieldTripOptionId3 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = FieldTripChoicesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(FieldTripChoicesTable.FieldTripOptionId3);
               if(_isExpandableNonCompositeForeignKey &&FieldTripChoicesTable.FieldTripOptionId3.IsApplyDisplayAs)
                                  
                     formattedValue = FieldTripChoicesTable.GetDFKA(this.DataSource.FieldTripOptionId3.ToString(),FieldTripChoicesTable.FieldTripOptionId3, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(FieldTripChoicesTable.FieldTripOptionId3);
                                  
                                
                this.FieldTripOptionId31.Text = formattedValue;
                
                  this.FieldTripOptionId31.ToolTip = "Go to " + this.FieldTripOptionId31.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FieldTripOptionId3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId31.Text = FieldTripChoicesTable.FieldTripOptionId3.Format(FieldTripChoicesTable.FieldTripOptionId3.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripAllocatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetFieldTripOptionId2Label()
                  {
                  
                        this.FieldTripOptionId2Label.Text = EvaluateFormula("\"Second Choice\"");
                      
                    
        }
                
        public virtual void SetFieldTripOptionId3Label()
                  {
                  
                        this.FieldTripOptionId3Label.Text = EvaluateFormula("\"Third Choice\"");
                      
                    
        }
                
        public virtual void SetFieldTripOptionIdLabel()
                  {
                  
                        this.FieldTripOptionIdLabel.Text = EvaluateFormula("\"First Choice\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OLR"));
                }
            }
        View_RegisteredTableControlRow parentCtrl;
      
            parentCtrl = (View_RegisteredTableControlRow)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OLR"));
        }
        
          this.DataSource.RegistrationId = parentCtrl.DataSource.RegistrationId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((FieldTripChoicesTableControl1)MiscUtils.GetParentControlObject(this, "FieldTripChoicesTableControl1")).DataChanged = true;
                ((FieldTripChoicesTableControl1)MiscUtils.GetParentControlObject(this, "FieldTripChoicesTableControl1")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetFieldTripAllocated();
            GetFieldTripId1();
            GetFieldTripOptionId1();
            GetFieldTripOptionId21();
            GetFieldTripOptionId31();
        }
        
        
        public virtual void GetFieldTripAllocated()
        {
            
        }
                
        public virtual void GetFieldTripId1()
        {
            
        }
                
        public virtual void GetFieldTripOptionId1()
        {
            
        }
                
        public virtual void GetFieldTripOptionId21()
        {
            
        }
                
        public virtual void GetFieldTripOptionId31()
        {
            
        }
                

      // To customize, override this method in FieldTripChoicesTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersFieldTripChoicesTableControl1 = false;
            hasFiltersFieldTripChoicesTableControl1 = hasFiltersFieldTripChoicesTableControl1 && false; // suppress warning
      
            bool hasFiltersView_RegisteredTableControl = false;
            hasFiltersView_RegisteredTableControl = hasFiltersView_RegisteredTableControl && false; // suppress warning
      
            bool hasFiltersWorkshopsTableControl = false;
            hasFiltersWorkshopsTableControl = hasFiltersWorkshopsTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          FieldTripChoicesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((FieldTripChoicesTableControl1)MiscUtils.GetParentControlObject(this, "FieldTripChoicesTableControl1")).DataChanged = true;
            ((FieldTripChoicesTableControl1)MiscUtils.GetParentControlObject(this, "FieldTripChoicesTableControl1")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        // event handler for LinkButton
        public virtual void FieldTripAllocated_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={FieldTripChoicesTableControl1Row:FK:FK_FieldTripChoices_FieldTripOptions3}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void FieldTripId1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTrips/Show-FieldTrips.aspx?FieldTrips={FieldTripChoicesTableControl1Row:FK:FK_FieldTripChoices_FieldTrips}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void FieldTripOptionId1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={FieldTripChoicesTableControl1Row:FK:FK_FieldTripChoices_FieldTripOptions}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void FieldTripOptionId21_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={FieldTripChoicesTableControl1Row:FK:FK_FieldTripChoices_FieldTripOptions1}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void FieldTripOptionId31_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={FieldTripChoicesTableControl1Row:FK:FK_FieldTripChoices_FieldTripOptions2}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseFieldTripChoicesTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseFieldTripChoicesTableControl1Row_Rec"] = value;
            }
        }
        
        public FieldTripChoicesRecord DataSource {
            get {
                return (FieldTripChoicesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton FieldTripAllocated {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripAllocated");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripAllocatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripAllocatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FieldTripId1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripId1");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton FieldTripOptionId1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId1");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton FieldTripOptionId21 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId21");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripOptionId2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId2Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FieldTripOptionId31 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId31");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripOptionId3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripOptionIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionIdLabel");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        FieldTripChoicesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    FieldTripChoicesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual FieldTripChoicesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return FieldTripChoicesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the FieldTripChoicesTableControl1 control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in FieldTripChoicesTableControl1.
public class BaseFieldTripChoicesTableControl1 : OLR.UI.BaseApplicationTableControl
{
         
       public BaseFieldTripChoicesTableControl1()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "5"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
                  
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OLR.Business.FieldTripChoicesRecord);
                      this.DataSource = (FieldTripChoicesRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (FieldTripChoicesTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.FieldTripChoicesRecord);
                    this.DataSource = (FieldTripChoicesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual FieldTripChoicesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(FieldTripChoicesTable.Column1, true);          
            // selCols.Add(FieldTripChoicesTable.Column2, true);          
            // selCols.Add(FieldTripChoicesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return FieldTripChoicesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                FieldTripChoicesTable databaseTable = new FieldTripChoicesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(FieldTripChoicesRecord)) as FieldTripChoicesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(FieldTripChoicesTable.Column1, true);          
            // selCols.Add(FieldTripChoicesTable.Column2, true);          
            // selCols.Add(FieldTripChoicesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return FieldTripChoicesTable.GetRecordCount(join, where);
            else
            {
                FieldTripChoicesTable databaseTable = new FieldTripChoicesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            FieldTripChoicesTableControl1Row recControl = (FieldTripChoicesTableControl1Row)(repItem.FindControl("FieldTripChoicesTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(FieldTripChoicesTable.FieldTripAllocated, this.DataSource);
            this.Page.PregetDfkaRecords(FieldTripChoicesTable.FieldTripId, this.DataSource);
            this.Page.PregetDfkaRecords(FieldTripChoicesTable.FieldTripOptionId, this.DataSource);
            this.Page.PregetDfkaRecords(FieldTripChoicesTable.FieldTripOptionId2, this.DataSource);
            this.Page.PregetDfkaRecords(FieldTripChoicesTable.FieldTripOptionId3, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
    
            // Bind the buttons for FieldTripChoicesTableControl1 pagination.
            
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (FieldTripChoicesTableControl1Row recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (FieldTripChoicesTableControl1Row recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            FieldTripChoicesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue view_RegisteredRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = view_RegisteredRecordObj;
          view_RegisteredRecordObj = tmp;
        View_RegisteredTableControlRow view_RegisteredTableControlObjRow = (MiscUtils.GetParentControlObject(this, "View_RegisteredTableControlRow") as View_RegisteredTableControlRow);
          
              if (view_RegisteredTableControlObjRow != null && view_RegisteredTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(FieldTripChoicesTable.RegistrationId, BaseFilter.ComparisonOperator.EqualsTo, view_RegisteredTableControlObjRow.GetRecord().RegistrationId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["FieldTripChoicesTableControl1WhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            FieldTripChoicesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInView_RegisteredTableControl = HttpContext.Current.Session["FieldTripChoicesTableControl1WhereClause"] as string;
      
      if (selectedRecordInView_RegisteredTableControl != null && KeyValue.IsXmlKey(selectedRecordInView_RegisteredTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInView_RegisteredTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(FieldTripChoicesTable.RegistrationId))
      {
      wc.iAND(FieldTripChoicesTable.RegistrationId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(FieldTripChoicesTable.RegistrationId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          

            return wc;
        }

        
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                FieldTripChoicesTableControl1Row recControl = (FieldTripChoicesTableControl1Row)(repItem.FindControl("FieldTripChoicesTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      FieldTripChoicesRecord rec = new FieldTripChoicesRecord();
        
                        if (recControl.FieldTripAllocated.Text != "") {
                            rec.Parse(recControl.FieldTripAllocated.Text, FieldTripChoicesTable.FieldTripAllocated);
                  }
                
                        if (recControl.FieldTripId1.Text != "") {
                            rec.Parse(recControl.FieldTripId1.Text, FieldTripChoicesTable.FieldTripId);
                  }
                
                        if (recControl.FieldTripOptionId1.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId1.Text, FieldTripChoicesTable.FieldTripOptionId);
                  }
                
                        if (recControl.FieldTripOptionId21.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId21.Text, FieldTripChoicesTable.FieldTripOptionId2);
                  }
                
                        if (recControl.FieldTripOptionId31.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId31.Text, FieldTripChoicesTable.FieldTripOptionId3);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new FieldTripChoicesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.FieldTripChoicesRecord);
                this.DataSource = (FieldTripChoicesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(FieldTripChoicesTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(FieldTripChoicesTableControl1Row rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["FieldTripChoicesTableControl1_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["FieldTripChoicesTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = FieldTripChoicesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  FieldTripChoicesRecord[] DataSource {
             
            get {
                return (FieldTripChoicesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                FieldTripChoicesTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        FieldTripChoicesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                FieldTripChoicesTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        FieldTripChoicesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual FieldTripChoicesTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual FieldTripChoicesTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (FieldTripChoicesTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_Registered_Table.FieldTripChoicesTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            FieldTripChoicesTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (FieldTripChoicesTableControl1Row recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual FieldTripChoicesTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "FieldTripChoicesTableControl1Row");
	          List<FieldTripChoicesTableControl1Row> list = new List<FieldTripChoicesTableControl1Row>();
	          foreach (FieldTripChoicesTableControl1Row recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the View_RegisteredTableControlRow control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in View_RegisteredTableControlRow.
public class BaseView_RegisteredTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseView_RegisteredTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in View_RegisteredTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in View_RegisteredTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OLR") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.view_Registered record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = View_RegisteredView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseView_RegisteredTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new View_RegisteredRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAdditionalDinnerName();
                SetAdditionalDinnerTicket();
                SetAddress1();
                SetAddress2();
                SetAddress3();
                SetContactId();
                SetDatePaid();
                
                
                SetEmail();
                
                SetFirstName();
                SetInitialCreationDate();
                SetLastName();
                SetMobileNumber();
                SetPSNZAppliedFor();
                SetPSNZMember();
                SetPSNZMembershipCheck();
                SetRegistrationType();
                SetSpecialRequirements();
                SetSpecialRequirementsLabel();
                SetTownName();
                SetValidationUid();
                
                SetDeleteRowButton();
              
                SetEditRowButton();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
                      
        SetFieldTripChoicesTableControl1();

                  
        SetWorkshopsTableControl();

        
        }
        
        
        public virtual void SetAdditionalDinnerName()
        {
            
                    
            // Set the AdditionalDinnerName Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.AdditionalDinnerName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerNameSpecified) {
                								
                // If the AdditionalDinnerName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.AdditionalDinnerName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerName.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerName.Text = View_RegisteredView.AdditionalDinnerName.Format(View_RegisteredView.AdditionalDinnerName.DefaultValue);
            		
            }
            
            // If the AdditionalDinnerName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AdditionalDinnerName.Text == null ||
                this.AdditionalDinnerName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AdditionalDinnerName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAdditionalDinnerTicket()
        {
            
                    
            // Set the AdditionalDinnerTicket Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.AdditionalDinnerTicket is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerTicketSpecified) {
                								
                // If the AdditionalDinnerTicket is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.AdditionalDinnerTicket);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerTicket.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerTicket is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerTicket.Text = View_RegisteredView.AdditionalDinnerTicket.Format(View_RegisteredView.AdditionalDinnerTicket.DefaultValue);
            		
            }
            
            // If the AdditionalDinnerTicket is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AdditionalDinnerTicket.Text == null ||
                this.AdditionalDinnerTicket.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AdditionalDinnerTicket.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress1()
        {
            
                    
            // Set the Address1 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = View_RegisteredView.Address1.Format(View_RegisteredView.Address1.DefaultValue);
            		
            }
            
            // If the Address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address1.Text == null ||
                this.Address1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress2()
        {
            
                    
            // Set the Address2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = View_RegisteredView.Address2.Format(View_RegisteredView.Address2.DefaultValue);
            		
            }
            
            // If the Address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address2.Text == null ||
                this.Address2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress3()
        {
            
                    
            // Set the Address3 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.Address3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = View_RegisteredView.Address3.Format(View_RegisteredView.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address3.Text == null ||
                this.Address3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetContactId()
        {
            
                    
            // Set the ContactId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.ContactId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactIdSpecified) {
                								
                // If the ContactId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.ContactId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ContactId.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactId.Text = View_RegisteredView.ContactId.Format(View_RegisteredView.ContactId.DefaultValue);
            		
            }
            
            // If the ContactId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ContactId.Text == null ||
                this.ContactId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ContactId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDatePaid()
        {
            
                    
            // Set the DatePaid Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.DatePaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DatePaidSpecified) {
                								
                // If the DatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.DatePaid, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.DatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // DatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DatePaid.Text = View_RegisteredView.DatePaid.Format(View_RegisteredView.DatePaid.DefaultValue, @"d");
            		
            }
            
            // If the DatePaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.DatePaid.Text == null ||
                this.DatePaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.DatePaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEmail()
        {
            
                    
            // Set the Email Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.Email is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EmailSpecified) {
                								
                // If the Email is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.Email);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Email.Text = formattedValue;
                   
            } 
            
            else {
            
                // Email is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Email.Text = View_RegisteredView.Email.Format(View_RegisteredView.Email.DefaultValue);
            		
            }
            
            // If the Email is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Email.Text == null ||
                this.Email.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Email.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName()
        {
            
                    
            // Set the FirstName Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.FirstName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.FirstName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName.Text = View_RegisteredView.FirstName.Format(View_RegisteredView.FirstName.DefaultValue);
            		
            }
            
            // If the FirstName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName.Text == null ||
                this.FirstName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInitialCreationDate()
        {
            
                    
            // Set the InitialCreationDate Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.InitialCreationDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InitialCreationDateSpecified) {
                								
                // If the InitialCreationDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.InitialCreationDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InitialCreationDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InitialCreationDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InitialCreationDate.Text = View_RegisteredView.InitialCreationDate.Format(View_RegisteredView.InitialCreationDate.DefaultValue, @"d");
            		
            }
            
            // If the InitialCreationDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InitialCreationDate.Text == null ||
                this.InitialCreationDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InitialCreationDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName()
        {
            
                    
            // Set the LastName Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.LastName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.LastName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName.Text = View_RegisteredView.LastName.Format(View_RegisteredView.LastName.DefaultValue);
            		
            }
            
            // If the LastName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName.Text == null ||
                this.LastName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMobileNumber()
        {
            
                    
            // Set the MobileNumber Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.MobileNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MobileNumberSpecified) {
                								
                // If the MobileNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.MobileNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.MobileNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // MobileNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MobileNumber.Text = View_RegisteredView.MobileNumber.Format(View_RegisteredView.MobileNumber.DefaultValue);
            		
            }
            
            // If the MobileNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.MobileNumber.Text == null ||
                this.MobileNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.MobileNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPSNZAppliedFor()
        {
            
                    
            // Set the PSNZAppliedFor Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.PSNZAppliedFor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZAppliedForSpecified) {
                								
                // If the PSNZAppliedFor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.PSNZAppliedFor);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZAppliedFor.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZAppliedFor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZAppliedFor.Text = View_RegisteredView.PSNZAppliedFor.Format(View_RegisteredView.PSNZAppliedFor.DefaultValue);
            		
            }
            
            // If the PSNZAppliedFor is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PSNZAppliedFor.Text == null ||
                this.PSNZAppliedFor.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PSNZAppliedFor.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPSNZMember()
        {
            
                    
            // Set the PSNZMember Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.PSNZMember is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZMemberSpecified) {
                								
                // If the PSNZMember is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.PSNZMember);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZMember.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZMember is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZMember.Text = View_RegisteredView.PSNZMember.Format(View_RegisteredView.PSNZMember.DefaultValue);
            		
            }
            
            // If the PSNZMember is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PSNZMember.Text == null ||
                this.PSNZMember.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PSNZMember.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPSNZMembershipCheck()
        {
            
                    
            // Set the PSNZMembershipCheck Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.PSNZMembershipCheck is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZMembershipCheckSpecified) {
                								
                // If the PSNZMembershipCheck is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.PSNZMembershipCheck);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZMembershipCheck.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZMembershipCheck is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZMembershipCheck.Text = View_RegisteredView.PSNZMembershipCheck.Format(View_RegisteredView.PSNZMembershipCheck.DefaultValue);
            		
            }
            
            // If the PSNZMembershipCheck is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PSNZMembershipCheck.Text == null ||
                this.PSNZMembershipCheck.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PSNZMembershipCheck.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegistrationType()
        {
            
                    
            // Set the RegistrationType Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.RegistrationType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegistrationTypeSpecified) {
                								
                // If the RegistrationType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.RegistrationType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RegistrationType.Text = formattedValue;
                   
            } 
            
            else {
            
                // RegistrationType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegistrationType.Text = View_RegisteredView.RegistrationType.Format(View_RegisteredView.RegistrationType.DefaultValue);
            		
            }
            
            // If the RegistrationType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RegistrationType.Text == null ||
                this.RegistrationType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RegistrationType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSpecialRequirements()
        {
            
                    
            // Set the SpecialRequirements Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.SpecialRequirements is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SpecialRequirementsSpecified) {
                								
                // If the SpecialRequirements is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.SpecialRequirements);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SpecialRequirements.Text = formattedValue;
                   
            } 
            
            else {
            
                // SpecialRequirements is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SpecialRequirements.Text = View_RegisteredView.SpecialRequirements.Format(View_RegisteredView.SpecialRequirements.DefaultValue);
            		
            }
            
            // If the SpecialRequirements is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SpecialRequirements.Text == null ||
                this.SpecialRequirements.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SpecialRequirements.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTownName()
        {
            
                    
            // Set the TownName Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.TownName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TownNameSpecified) {
                								
                // If the TownName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.TownName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TownName.Text = formattedValue;
                   
            } 
            
            else {
            
                // TownName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TownName.Text = View_RegisteredView.TownName.Format(View_RegisteredView.TownName.DefaultValue);
            		
            }
            
            // If the TownName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TownName.Text == null ||
                this.TownName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TownName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetValidationUid()
        {
            
                    
            // Set the ValidationUid Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Registered database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Registered record retrieved from the database.
            // this.ValidationUid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ValidationUidSpecified) {
                								
                // If the ValidationUid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_RegisteredView.ValidationUid);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ValidationUid.Text = formattedValue;
                   
            } 
            
            else {
            
                // ValidationUid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ValidationUid.Text = View_RegisteredView.ValidationUid.Format(View_RegisteredView.ValidationUid.DefaultValue);
            		
            }
            
            // If the ValidationUid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ValidationUid.Text == null ||
                this.ValidationUid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ValidationUid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSpecialRequirementsLabel()
                  {
                  
                    
        }
                
        public virtual void SetFieldTripChoicesTableControl1()           
        
        {        
            if (FieldTripChoicesTableControl1.Visible)
            {
                FieldTripChoicesTableControl1.LoadData();
                FieldTripChoicesTableControl1.DataBind();
            }
        }
      
        public virtual void SetWorkshopsTableControl()           
        
        {        
            if (WorkshopsTableControl.Visible)
            {
                WorkshopsTableControl.LoadData();
                WorkshopsTableControl.DataBind();
            }
        }
      
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"DeleteRowButton"));
                            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OLR"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((View_RegisteredTableControl)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControl")).DataChanged = true;
                ((View_RegisteredTableControl)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          FieldTripChoicesTableControl1 recFieldTripChoicesTableControl1 = (FieldTripChoicesTableControl1)(MiscUtils.FindControlRecursively(this, "FieldTripChoicesTableControl1"));
        recFieldTripChoicesTableControl1.SaveData();
        WorkshopsTableControl recWorkshopsTableControl = (WorkshopsTableControl)(MiscUtils.FindControlRecursively(this, "WorkshopsTableControl"));
        recWorkshopsTableControl.SaveData();
        
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAdditionalDinnerName();
            GetAdditionalDinnerTicket();
            GetAddress1();
            GetAddress2();
            GetAddress3();
            GetContactId();
            GetDatePaid();
            GetEmail();
            GetFirstName();
            GetInitialCreationDate();
            GetLastName();
            GetMobileNumber();
            GetPSNZAppliedFor();
            GetPSNZMember();
            GetPSNZMembershipCheck();
            GetRegistrationType();
            GetSpecialRequirements();
            GetTownName();
            GetValidationUid();
        }
        
        
        public virtual void GetAdditionalDinnerName()
        {
            
        }
                
        public virtual void GetAdditionalDinnerTicket()
        {
            
        }
                
        public virtual void GetAddress1()
        {
            
        }
                
        public virtual void GetAddress2()
        {
            
        }
                
        public virtual void GetAddress3()
        {
            
        }
                
        public virtual void GetContactId()
        {
            
        }
                
        public virtual void GetDatePaid()
        {
            
        }
                
        public virtual void GetEmail()
        {
            
        }
                
        public virtual void GetFirstName()
        {
            
        }
                
        public virtual void GetInitialCreationDate()
        {
            
        }
                
        public virtual void GetLastName()
        {
            
        }
                
        public virtual void GetMobileNumber()
        {
            
        }
                
        public virtual void GetPSNZAppliedFor()
        {
            
        }
                
        public virtual void GetPSNZMember()
        {
            
        }
                
        public virtual void GetPSNZMembershipCheck()
        {
            
        }
                
        public virtual void GetRegistrationType()
        {
            
        }
                
        public virtual void GetSpecialRequirements()
        {
            
        }
                
        public virtual void GetTownName()
        {
            
        }
                
        public virtual void GetValidationUid()
        {
            
        }
                

      // To customize, override this method in View_RegisteredTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersFieldTripChoicesTableControl1 = false;
            hasFiltersFieldTripChoicesTableControl1 = hasFiltersFieldTripChoicesTableControl1 && false; // suppress warning
      
            bool hasFiltersView_RegisteredTableControl = false;
            hasFiltersView_RegisteredTableControl = hasFiltersView_RegisteredTableControl && false; // suppress warning
      
            bool hasFiltersWorkshopsTableControl = false;
            hasFiltersWorkshopsTableControl = hasFiltersWorkshopsTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          View_RegisteredView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((View_RegisteredTableControl)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControl")).DataChanged = true;
            ((View_RegisteredTableControl)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"http://localhost:60892/Home/RegisterMe?Registration={View_RegisteredTableControlRow:NoUrlEncode:FV:ValidationUid}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseView_RegisteredTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseView_RegisteredTableControlRow_Rec"] = value;
            }
        }
        
        public View_RegisteredRecord DataSource {
            get {
                return (View_RegisteredRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal AdditionalDinnerName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerName");
            }
        }
            
        public System.Web.UI.WebControls.Literal AdditionalDinnerTicket {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerTicket");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactId");
            }
        }
            
        public System.Web.UI.WebControls.Literal DatePaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaid");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal Email {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Email");
            }
        }
            
        public FieldTripChoicesTableControl1 FieldTripChoicesTableControl1 {
            get {
                return (FieldTripChoicesTableControl1)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesTableControl1");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName");
            }
        }
            
        public System.Web.UI.WebControls.Literal InitialCreationDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName");
            }
        }
            
        public System.Web.UI.WebControls.Literal MobileNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MobileNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZAppliedFor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZAppliedFor");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZMember {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMember");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZMembershipCheck {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMembershipCheck");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegistrationType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationType");
            }
        }
            
        public System.Web.UI.WebControls.Literal SpecialRequirements {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SpecialRequirements");
            }
        }
            
        public System.Web.UI.WebControls.Literal SpecialRequirementsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SpecialRequirementsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TownName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TownName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ValidationUid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ValidationUid");
            }
        }
            
        public WorkshopsTableControl WorkshopsTableControl {
            get {
                return (WorkshopsTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopsTableControl");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        View_RegisteredRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    View_RegisteredRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual View_RegisteredRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return View_RegisteredView.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "OLR"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the View_RegisteredTableControl control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in View_RegisteredTableControl.
public class BaseView_RegisteredTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseView_RegisteredTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.SortControl)) 				
                    initialVal = this.GetFromSession(this.SortControl);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.AdditionalDinnerNameLabel1.Click += AdditionalDinnerNameLabel1_Click;
            
              this.AdditionalDinnerTicketLabel1.Click += AdditionalDinnerTicketLabel1_Click;
            
              this.Address1Label1.Click += Address1Label1_Click;
            
              this.DatePaidLabel1.Click += DatePaidLabel1_Click;
            
              this.EmailLabel1.Click += EmailLabel1_Click;
            
              this.FirstNameLabel1.Click += FirstNameLabel1_Click;
            
              this.InitialCreationDateLabel1.Click += InitialCreationDateLabel1_Click;
            
              this.LastNameLabel1.Click += LastNameLabel1_Click;
            
              this.MobileNumberLabel1.Click += MobileNumberLabel1_Click;
            
              this.PSNZAppliedForLabel1.Click += PSNZAppliedForLabel1_Click;
            
              this.PSNZMemberLabel1.Click += PSNZMemberLabel1_Click;
            
              this.PSNZMembershipCheckLabel1.Click += PSNZMembershipCheckLabel1_Click;
            
              this.RegistrationTypeLabel.Click += RegistrationTypeLabel_Click;
            
              this.TownNameLabel.Click += TownNameLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OLR.Business.View_RegisteredRecord);
                      this.DataSource = (View_RegisteredRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (View_RegisteredTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.View_RegisteredRecord);
                    this.DataSource = (View_RegisteredRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual View_RegisteredRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(View_RegisteredView.Column1, true);          
            // selCols.Add(View_RegisteredView.Column2, true);          
            // selCols.Add(View_RegisteredView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return View_RegisteredView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                View_RegisteredView databaseTable = new View_RegisteredView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(View_RegisteredRecord)) as View_RegisteredRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(View_RegisteredView.Column1, true);          
            // selCols.Add(View_RegisteredView.Column2, true);          
            // selCols.Add(View_RegisteredView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return View_RegisteredView.GetRecordCount(join, where);
            else
            {
                View_RegisteredView databaseTable = new View_RegisteredView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_RegisteredTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            View_RegisteredTableControlRow recControl = (View_RegisteredTableControlRow)(repItem.FindControl("View_RegisteredTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                SetAdditionalDinnerNameLabel1();
                SetAdditionalDinnerTicketLabel1();
                SetAddress1Label1();
                SetDatePaidLabel1();
                SetEmailLabel1();
                
                
                
                SetFirstNameLabel1();
                SetInitialCreationDateLabel1();
                SetLastNameLabel1();
                SetMobileNumberLabel1();
                
                
                SetPSNZAppliedForLabel1();
                SetPSNZMemberLabel1();
                SetPSNZMembershipCheckLabel1();
                SetRegistrationTypeLabel();
                
                
                SetSearchText();
                SetSortByLabel();
                SetSortControl();
                
                SetTownNameLabel();
                
                SetExcelButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OLR") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.SortControl.ClearSelection();
            
            this.SearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
            this.Pagination.TotalPages.Text = this.TotalPages.ToString();
    
            // Bind the buttons for View_RegisteredTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (View_RegisteredTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (View_RegisteredTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            View_RegisteredView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(View_RegisteredView.LastName, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            View_RegisteredView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(View_RegisteredView.LastName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(View_RegisteredView.LastName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OLR.Business.View_RegisteredView, OLR.Business").TableDefinition.ColumnList.GetByUniqueName(@"view_Registered_.RegistrationType"), null, BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OLR.Business.View_RegisteredRecord[] recordList  = View_RegisteredView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (View_RegisteredRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(View_RegisteredView.LastName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(View_RegisteredView.LastName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, View_RegisteredView.LastName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_RegisteredTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                View_RegisteredTableControlRow recControl = (View_RegisteredTableControlRow)(repItem.FindControl("View_RegisteredTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      View_RegisteredRecord rec = new View_RegisteredRecord();
        
                        if (recControl.AdditionalDinnerName.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerName.Text, View_RegisteredView.AdditionalDinnerName);
                  }
                
                        if (recControl.AdditionalDinnerTicket.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerTicket.Text, View_RegisteredView.AdditionalDinnerTicket);
                  }
                
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, View_RegisteredView.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, View_RegisteredView.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, View_RegisteredView.Address3);
                  }
                
                        if (recControl.ContactId.Text != "") {
                            rec.Parse(recControl.ContactId.Text, View_RegisteredView.ContactId);
                  }
                
                        if (recControl.DatePaid.Text != "") {
                            rec.Parse(recControl.DatePaid.Text, View_RegisteredView.DatePaid);
                  }
                
                        if (recControl.Email.Text != "") {
                            rec.Parse(recControl.Email.Text, View_RegisteredView.Email);
                  }
                
                        if (recControl.FirstName.Text != "") {
                            rec.Parse(recControl.FirstName.Text, View_RegisteredView.FirstName);
                  }
                
                        if (recControl.InitialCreationDate.Text != "") {
                            rec.Parse(recControl.InitialCreationDate.Text, View_RegisteredView.InitialCreationDate);
                  }
                
                        if (recControl.LastName.Text != "") {
                            rec.Parse(recControl.LastName.Text, View_RegisteredView.LastName);
                  }
                
                        if (recControl.MobileNumber.Text != "") {
                            rec.Parse(recControl.MobileNumber.Text, View_RegisteredView.MobileNumber);
                  }
                
                        if (recControl.PSNZAppliedFor.Text != "") {
                            rec.Parse(recControl.PSNZAppliedFor.Text, View_RegisteredView.PSNZAppliedFor);
                  }
                
                        if (recControl.PSNZMember.Text != "") {
                            rec.Parse(recControl.PSNZMember.Text, View_RegisteredView.PSNZMember);
                  }
                
                        if (recControl.PSNZMembershipCheck.Text != "") {
                            rec.Parse(recControl.PSNZMembershipCheck.Text, View_RegisteredView.PSNZMembershipCheck);
                  }
                
                        if (recControl.RegistrationType.Text != "") {
                            rec.Parse(recControl.RegistrationType.Text, View_RegisteredView.RegistrationType);
                  }
                
                        if (recControl.SpecialRequirements.Text != "") {
                            rec.Parse(recControl.SpecialRequirements.Text, View_RegisteredView.SpecialRequirements);
                  }
                
                        if (recControl.TownName.Text != "") {
                            rec.Parse(recControl.TownName.Text, View_RegisteredView.TownName);
                  }
                
                        if (recControl.ValidationUid.Text != "") {
                            rec.Parse(recControl.ValidationUid.Text, View_RegisteredView.ValidationUid);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new View_RegisteredRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.View_RegisteredRecord);
                this.DataSource = (View_RegisteredRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(View_RegisteredTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(View_RegisteredTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetAdditionalDinnerNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetAdditionalDinnerTicketLabel1()
                  {
                  
                    
        }
                
        public virtual void SetAddress1Label1()
                  {
                  
                    
        }
                
        public virtual void SetDatePaidLabel1()
                  {
                  
                    
        }
                
        public virtual void SetEmailLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInitialCreationDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetMobileNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPSNZAppliedForLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPSNZMemberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPSNZMembershipCheckLabel1()
                  {
                  
                    
        }
                
        public virtual void SetRegistrationTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetTownNameLabel()
                  {
                  
                        this.TownNameLabel.Text = EvaluateFormula("\"Town\"");
                      
                    
        }
                
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Additional Dinner Name {Txt:Ascending}"), "AdditionalDinnerName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Additional Dinner Name {Txt:Descending}"), "AdditionalDinnerName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Additional Dinner Ticket {Txt:Ascending}"), "AdditionalDinnerTicket Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Additional Dinner Ticket {Txt:Descending}"), "AdditionalDinnerTicket Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 1 {Txt:Ascending}"), "Address1 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 1 {Txt:Descending}"), "Address1 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Ascending}"), "Address2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 2 {Txt:Descending}"), "Address2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 3 {Txt:Ascending}"), "Address3 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address 3 {Txt:Descending}"), "Address3 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Ascending}"), "ContactId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Descending}"), "ContactId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Paid {Txt:Ascending}"), "DatePaid Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Paid {Txt:Descending}"), "DatePaid Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("First Name {Txt:Ascending}"), "FirstName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("First Name {Txt:Descending}"), "FirstName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Initial Creation Date {Txt:Ascending}"), "InitialCreationDate Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Initial Creation Date {Txt:Descending}"), "InitialCreationDate Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Name {Txt:Ascending}"), "LastName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Name {Txt:Descending}"), "LastName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Town Name {Txt:Ascending}"), "TownName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Town Name {Txt:Descending}"), "TownName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration Type {Txt:Ascending}"), "RegistrationType Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration Type {Txt:Descending}"), "RegistrationType Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration {Txt:Ascending}"), "RegistrationId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration {Txt:Descending}"), "RegistrationId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Record Deleted {Txt:Ascending}"), "RecordDeleted Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Record Deleted {Txt:Descending}"), "RecordDeleted Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Validation UID {Txt:Ascending}"), "ValidationUid Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Validation UID {Txt:Descending}"), "ValidationUid Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl.SelectedValue != null && this.SortControl.Items.FindByValue(this.SortControl.SelectedValue) == null)
                this.SortControl.SelectedValue = null;
              
        }
            

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.SearchText);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["View_RegisteredTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["View_RegisteredTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        
        public virtual void AdditionalDinnerNameLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by AdditionalDinnerName when clicked.
              
            // Get previous sorting state for AdditionalDinnerName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.AdditionalDinnerName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for AdditionalDinnerName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.AdditionalDinnerName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by AdditionalDinnerName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void AdditionalDinnerTicketLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by AdditionalDinnerTicket when clicked.
              
            // Get previous sorting state for AdditionalDinnerTicket.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.AdditionalDinnerTicket);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for AdditionalDinnerTicket.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.AdditionalDinnerTicket, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by AdditionalDinnerTicket, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address1Label1_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.Address1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void DatePaidLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by DatePaid when clicked.
              
            // Get previous sorting state for DatePaid.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.DatePaid);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for DatePaid.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.DatePaid, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by DatePaid, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void EmailLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by Email when clicked.
              
            // Get previous sorting state for Email.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.Email);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Email.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.Email, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Email, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void FirstNameLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by FirstName when clicked.
              
            // Get previous sorting state for FirstName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.FirstName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for FirstName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.FirstName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by FirstName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void InitialCreationDateLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by InitialCreationDate when clicked.
              
            // Get previous sorting state for InitialCreationDate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.InitialCreationDate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for InitialCreationDate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.InitialCreationDate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by InitialCreationDate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LastNameLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by LastName when clicked.
              
            // Get previous sorting state for LastName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.LastName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LastName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.LastName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LastName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void MobileNumberLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by MobileNumber when clicked.
              
            // Get previous sorting state for MobileNumber.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.MobileNumber);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for MobileNumber.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.MobileNumber, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by MobileNumber, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PSNZAppliedForLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by PSNZAppliedFor when clicked.
              
            // Get previous sorting state for PSNZAppliedFor.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.PSNZAppliedFor);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PSNZAppliedFor.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.PSNZAppliedFor, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PSNZAppliedFor, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PSNZMemberLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by PSNZMember when clicked.
              
            // Get previous sorting state for PSNZMember.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.PSNZMember);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PSNZMember.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.PSNZMember, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PSNZMember, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PSNZMembershipCheckLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by PSNZMembershipCheck when clicked.
              
            // Get previous sorting state for PSNZMembershipCheck.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.PSNZMembershipCheck);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PSNZMembershipCheck.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.PSNZMembershipCheck, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PSNZMembershipCheck, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RegistrationTypeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RegistrationType when clicked.
              
            // Get previous sorting state for RegistrationType.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.RegistrationType);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RegistrationType.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.RegistrationType, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RegistrationType, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void TownNameLabel_Click(object sender, EventArgs args)
        {
            //Sorts by TownName when clicked.
              
            // Get previous sorting state for TownName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.TownName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for TownName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_RegisteredView.TownName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by TownName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = View_RegisteredView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             View_RegisteredView.ContactId,
             View_RegisteredView.Address1,
             View_RegisteredView.Address2,
             View_RegisteredView.Address3,
             View_RegisteredView.MobileNumber,
             View_RegisteredView.PSNZMembershipCheck,
             View_RegisteredView.PSNZMember,
             View_RegisteredView.Email,
             View_RegisteredView.PSNZAppliedFor,
             View_RegisteredView.FirstName,
             View_RegisteredView.LastName,
             View_RegisteredView.DatePaid,
             View_RegisteredView.InitialCreationDate,
             View_RegisteredView.AdditionalDinnerName,
             View_RegisteredView.SpecialRequirements,
             View_RegisteredView.AdditionalDinnerTicket,
             View_RegisteredView.TownName,
             View_RegisteredView.RegistrationType,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(View_RegisteredView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(View_RegisteredView.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(View_RegisteredView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(View_RegisteredView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(View_RegisteredView.ContactId, "0"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.Address3, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.MobileNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.PSNZMembershipCheck, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.PSNZMember, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.Email, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.PSNZAppliedFor, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.FirstName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.LastName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.DatePaid, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.InitialCreationDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.AdditionalDinnerName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.SpecialRequirements, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.AdditionalDinnerTicket, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.TownName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_RegisteredView.RegistrationType, "Default"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = View_RegisteredView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
              }
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-Registered-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_Registered";
                // If Show-View-Registered-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_RegisteredView.ContactId.Name, ReportEnum.Align.Right, "${ContactId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_RegisteredView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.MobileNumber.Name, ReportEnum.Align.Left, "${MobileNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(View_RegisteredView.PSNZMembershipCheck.Name, ReportEnum.Align.Left, "${PSNZMembershipCheck}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.PSNZMember.Name, ReportEnum.Align.Left, "${PSNZMember}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.Email.Name, ReportEnum.Align.Left, "${Email}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.PSNZAppliedFor.Name, ReportEnum.Align.Left, "${PSNZAppliedFor}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.DatePaid.Name, ReportEnum.Align.Left, "${DatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_RegisteredView.InitialCreationDate.Name, ReportEnum.Align.Left, "${InitialCreationDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_RegisteredView.AdditionalDinnerName.Name, ReportEnum.Align.Left, "${AdditionalDinnerName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.SpecialRequirements.Name, ReportEnum.Align.Left, "${SpecialRequirements}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.AdditionalDinnerTicket.Name, ReportEnum.Align.Left, "${AdditionalDinnerTicket}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.TownName.Name, ReportEnum.Align.Left, "${TownName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.RegistrationType.Name, ReportEnum.Align.Left, "${RegistrationType}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = View_RegisteredView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = View_RegisteredView.GetRecordCount(joinFilter,whereClause);
                View_RegisteredRecord[] records = null;
                
                do
                {
                    
                    records = View_RegisteredView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_RegisteredRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${ContactId}", record.Format(View_RegisteredView.ContactId), ReportEnum.Align.Right, 300);
                             report.AddData("${Address1}", record.Format(View_RegisteredView.Address1), ReportEnum.Align.Left, 300);
                             report.AddData("${Address2}", record.Format(View_RegisteredView.Address2), ReportEnum.Align.Left, 300);
                             report.AddData("${Address3}", record.Format(View_RegisteredView.Address3), ReportEnum.Align.Left, 300);
                             report.AddData("${MobileNumber}", record.Format(View_RegisteredView.MobileNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMembershipCheck}", record.Format(View_RegisteredView.PSNZMembershipCheck), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMember}", record.Format(View_RegisteredView.PSNZMember), ReportEnum.Align.Left, 300);
                             report.AddData("${Email}", record.Format(View_RegisteredView.Email), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZAppliedFor}", record.Format(View_RegisteredView.PSNZAppliedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${FirstName}", record.Format(View_RegisteredView.FirstName), ReportEnum.Align.Left, 300);
                             report.AddData("${LastName}", record.Format(View_RegisteredView.LastName), ReportEnum.Align.Left, 300);
                             report.AddData("${DatePaid}", record.Format(View_RegisteredView.DatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${InitialCreationDate}", record.Format(View_RegisteredView.InitialCreationDate), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerName}", record.Format(View_RegisteredView.AdditionalDinnerName), ReportEnum.Align.Left, 300);
                             report.AddData("${SpecialRequirements}", record.Format(View_RegisteredView.SpecialRequirements), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerTicket}", record.Format(View_RegisteredView.AdditionalDinnerTicket), ReportEnum.Align.Left, 300);
                             report.AddData("${TownName}", record.Format(View_RegisteredView.TownName), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationType}", record.Format(View_RegisteredView.RegistrationType), ReportEnum.Align.Left, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
           
            this.SortControl.ClearSelection();
          
              this.SearchText.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-Registered-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_Registered";
                // If Show-View-Registered-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_RegisteredView.ContactId.Name, ReportEnum.Align.Right, "${ContactId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_RegisteredView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.MobileNumber.Name, ReportEnum.Align.Left, "${MobileNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(View_RegisteredView.PSNZMembershipCheck.Name, ReportEnum.Align.Left, "${PSNZMembershipCheck}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.PSNZMember.Name, ReportEnum.Align.Left, "${PSNZMember}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.Email.Name, ReportEnum.Align.Left, "${Email}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.PSNZAppliedFor.Name, ReportEnum.Align.Left, "${PSNZAppliedFor}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.DatePaid.Name, ReportEnum.Align.Left, "${DatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_RegisteredView.InitialCreationDate.Name, ReportEnum.Align.Left, "${InitialCreationDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_RegisteredView.AdditionalDinnerName.Name, ReportEnum.Align.Left, "${AdditionalDinnerName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.SpecialRequirements.Name, ReportEnum.Align.Left, "${SpecialRequirements}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.AdditionalDinnerTicket.Name, ReportEnum.Align.Left, "${AdditionalDinnerTicket}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_RegisteredView.TownName.Name, ReportEnum.Align.Left, "${TownName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_RegisteredView.RegistrationType.Name, ReportEnum.Align.Left, "${RegistrationType}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = View_RegisteredView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = View_RegisteredView.GetColumnList();
                View_RegisteredRecord[] records = null;
                do
                {
                    records = View_RegisteredView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_RegisteredRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${ContactId}", record.Format(View_RegisteredView.ContactId), ReportEnum.Align.Right, 300);
                             report.AddData("${Address1}", record.Format(View_RegisteredView.Address1), ReportEnum.Align.Left, 300);
                             report.AddData("${Address2}", record.Format(View_RegisteredView.Address2), ReportEnum.Align.Left, 300);
                             report.AddData("${Address3}", record.Format(View_RegisteredView.Address3), ReportEnum.Align.Left, 300);
                             report.AddData("${MobileNumber}", record.Format(View_RegisteredView.MobileNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMembershipCheck}", record.Format(View_RegisteredView.PSNZMembershipCheck), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMember}", record.Format(View_RegisteredView.PSNZMember), ReportEnum.Align.Left, 300);
                             report.AddData("${Email}", record.Format(View_RegisteredView.Email), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZAppliedFor}", record.Format(View_RegisteredView.PSNZAppliedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${FirstName}", record.Format(View_RegisteredView.FirstName), ReportEnum.Align.Left, 300);
                             report.AddData("${LastName}", record.Format(View_RegisteredView.LastName), ReportEnum.Align.Left, 300);
                             report.AddData("${DatePaid}", record.Format(View_RegisteredView.DatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${InitialCreationDate}", record.Format(View_RegisteredView.InitialCreationDate), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerName}", record.Format(View_RegisteredView.AdditionalDinnerName), ReportEnum.Align.Left, 300);
                             report.AddData("${SpecialRequirements}", record.Format(View_RegisteredView.SpecialRequirements), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerTicket}", record.Format(View_RegisteredView.AdditionalDinnerTicket), ReportEnum.Align.Left, 300);
                             report.AddData("${TownName}", record.Format(View_RegisteredView.TownName), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationType}", record.Format(View_RegisteredView.RegistrationType), ReportEnum.Align.Left, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void SortControl_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in View_RegisteredView.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(View_RegisteredView.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (View_RegisteredView.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && View_RegisteredView.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(View_RegisteredView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(View_RegisteredView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = View_RegisteredView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  View_RegisteredRecord[] DataSource {
             
            get {
                return (View_RegisteredRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OLR.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OLR.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AdditionalDinnerNameLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AdditionalDinnerTicketLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerTicketLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address1Label1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DatePaidLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaidLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton EmailLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EmailLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public OLR.UI.IThemeButton FilterButton {
            get {
                return (OLR.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public OLR.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (OLR.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FirstNameLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton InitialCreationDateLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LastNameLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton MobileNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MobileNumberLabel1");
            }
        }
        
        public OLR.UI.IPaginationMedium Pagination {
            get {
                return (OLR.UI.IPaginationMedium)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PSNZAppliedForLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZAppliedForLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PSNZMemberLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMemberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PSNZMembershipCheckLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMembershipCheckLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RegistrationTypeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl");
          }
          }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TownNameLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TownNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                View_RegisteredTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_RegisteredRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                View_RegisteredTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_RegisteredRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual View_RegisteredTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual View_RegisteredTableControlRow[] GetSelectedRecordControls()
        {
        
            return (View_RegisteredTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_Registered_Table.View_RegisteredTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            View_RegisteredTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (View_RegisteredTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual View_RegisteredTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "View_RegisteredTableControlRow");
	          List<View_RegisteredTableControlRow> list = new List<View_RegisteredTableControlRow>();
	          foreach (View_RegisteredTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the WorkshopsTableControlRow control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in WorkshopsTableControlRow.
public class BaseWorkshopsTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseWorkshopsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in WorkshopsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in WorkshopsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.Workshops record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = WorkshopsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseWorkshopsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new WorkshopsRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAttending();
                SetAvailableWorkshopId();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetAttending()
        {
            
                    
            // Set the Attending Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Workshops database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Workshops record retrieved from the database.
            // this.Attending is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttendingSpecified) {
                								
                // If the Attending is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(WorkshopsTable.Attending);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Attending.Text = formattedValue;
                   
            } 
            
            else {
            
                // Attending is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Attending.Text = WorkshopsTable.Attending.Format(WorkshopsTable.Attending.DefaultValue);
            		
            }
            
            // If the Attending is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Attending.Text == null ||
                this.Attending.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Attending.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAvailableWorkshopId()
        {
            
                    
            // Set the AvailableWorkshopId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Workshops database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Workshops record retrieved from the database.
            // this.AvailableWorkshopId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AvailableWorkshopIdSpecified) {
                								
                // If the AvailableWorkshopId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = WorkshopsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WorkshopsTable.AvailableWorkshopId);
               if(_isExpandableNonCompositeForeignKey &&WorkshopsTable.AvailableWorkshopId.IsApplyDisplayAs)
                                  
                     formattedValue = WorkshopsTable.GetDFKA(this.DataSource.AvailableWorkshopId.ToString(),WorkshopsTable.AvailableWorkshopId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(WorkshopsTable.AvailableWorkshopId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AvailableWorkshopId.Text = formattedValue;
                   
            } 
            
            else {
            
                // AvailableWorkshopId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AvailableWorkshopId.Text = WorkshopsTable.AvailableWorkshopId.Format(WorkshopsTable.AvailableWorkshopId.DefaultValue);
            		
            }
            
            // If the AvailableWorkshopId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AvailableWorkshopId.Text == null ||
                this.AvailableWorkshopId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AvailableWorkshopId.Text = "&nbsp;";
            }
                                     
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OLR"));
                }
            }
        View_RegisteredTableControlRow parentCtrl;
      
            parentCtrl = (View_RegisteredTableControlRow)MiscUtils.GetParentControlObject(this, "View_RegisteredTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OLR"));
        }
        
          this.DataSource.RegistrationId = parentCtrl.DataSource.RegistrationId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((WorkshopsTableControl)MiscUtils.GetParentControlObject(this, "WorkshopsTableControl")).DataChanged = true;
                ((WorkshopsTableControl)MiscUtils.GetParentControlObject(this, "WorkshopsTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAttending();
            GetAvailableWorkshopId();
        }
        
        
        public virtual void GetAttending()
        {
            
        }
                
        public virtual void GetAvailableWorkshopId()
        {
            
        }
                

      // To customize, override this method in WorkshopsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersFieldTripChoicesTableControl1 = false;
            hasFiltersFieldTripChoicesTableControl1 = hasFiltersFieldTripChoicesTableControl1 && false; // suppress warning
      
            bool hasFiltersView_RegisteredTableControl = false;
            hasFiltersView_RegisteredTableControl = hasFiltersView_RegisteredTableControl && false; // suppress warning
      
            bool hasFiltersWorkshopsTableControl = false;
            hasFiltersWorkshopsTableControl = hasFiltersWorkshopsTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          WorkshopsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((WorkshopsTableControl)MiscUtils.GetParentControlObject(this, "WorkshopsTableControl")).DataChanged = true;
            ((WorkshopsTableControl)MiscUtils.GetParentControlObject(this, "WorkshopsTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseWorkshopsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseWorkshopsTableControlRow_Rec"] = value;
            }
        }
        
        public WorkshopsRecord DataSource {
            get {
                return (WorkshopsRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal Attending {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Attending");
            }
        }
            
        public System.Web.UI.WebControls.Literal AvailableWorkshopId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AvailableWorkshopId");
            }
        }
            
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        WorkshopsRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    WorkshopsRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OLR"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual WorkshopsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return WorkshopsTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the WorkshopsTableControl control on the Show_View_Registered_Table page.
// Do not modify this class. Instead override any method in WorkshopsTableControl.
public class BaseWorkshopsTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseWorkshopsTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.AttendingLabel1.Click += AttendingLabel1_Click;
            
              this.AvailableWorkshopIdLabel.Click += AvailableWorkshopIdLabel_Click;
            
            // Setup the button events.
                  
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OLR.Business.WorkshopsRecord);
                      this.DataSource = (WorkshopsRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (WorkshopsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.WorkshopsRecord);
                    this.DataSource = (WorkshopsRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual WorkshopsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(WorkshopsTable.Column1, true);          
            // selCols.Add(WorkshopsTable.Column2, true);          
            // selCols.Add(WorkshopsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return WorkshopsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                WorkshopsTable databaseTable = new WorkshopsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(WorkshopsRecord)) as WorkshopsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(WorkshopsTable.Column1, true);          
            // selCols.Add(WorkshopsTable.Column2, true);          
            // selCols.Add(WorkshopsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return WorkshopsTable.GetRecordCount(join, where);
            else
            {
                WorkshopsTable databaseTable = new WorkshopsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            WorkshopsTableControlRow recControl = (WorkshopsTableControlRow)(repItem.FindControl("WorkshopsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAttendingLabel1();
                SetAvailableWorkshopIdLabel();
                
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(WorkshopsTable.AvailableWorkshopId, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
    
            // Bind the buttons for WorkshopsTableControl pagination.
            
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (WorkshopsTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (WorkshopsTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            WorkshopsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue view_RegisteredRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = view_RegisteredRecordObj;
          view_RegisteredRecordObj = tmp;
        View_RegisteredTableControlRow view_RegisteredTableControlObjRow = (MiscUtils.GetParentControlObject(this, "View_RegisteredTableControlRow") as View_RegisteredTableControlRow);
          
              if (view_RegisteredTableControlObjRow != null && view_RegisteredTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(WorkshopsTable.RegistrationId, BaseFilter.ComparisonOperator.EqualsTo, view_RegisteredTableControlObjRow.GetRecord().RegistrationId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["WorkshopsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WorkshopsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInView_RegisteredTableControl = HttpContext.Current.Session["WorkshopsTableControlWhereClause"] as string;
      
      if (selectedRecordInView_RegisteredTableControl != null && KeyValue.IsXmlKey(selectedRecordInView_RegisteredTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInView_RegisteredTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(WorkshopsTable.RegistrationId))
      {
      wc.iAND(WorkshopsTable.RegistrationId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WorkshopsTable.RegistrationId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          

            return wc;
        }

        
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                WorkshopsTableControlRow recControl = (WorkshopsTableControlRow)(repItem.FindControl("WorkshopsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      WorkshopsRecord rec = new WorkshopsRecord();
        
                        if (recControl.Attending.Text != "") {
                            rec.Parse(recControl.Attending.Text, WorkshopsTable.Attending);
                  }
                
                        if (recControl.AvailableWorkshopId.Text != "") {
                            rec.Parse(recControl.AvailableWorkshopId.Text, WorkshopsTable.AvailableWorkshopId);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new WorkshopsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.WorkshopsRecord);
                this.DataSource = (WorkshopsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(WorkshopsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(WorkshopsTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetAttendingLabel1()
                  {
                  
                        this.AttendingLabel1.Text = EvaluateFormula("\"Attending?\"");
                      
                    
        }
                
        public virtual void SetAvailableWorkshopIdLabel()
                  {
                  
                    
        }
                

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["WorkshopsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["WorkshopsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        

        // Generate the event handling functions for sorting events.
        
        public virtual void AttendingLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by Attending when clicked.
              
            // Get previous sorting state for Attending.
        
            OrderByItem sd = this.CurrentSortOrder.Find(WorkshopsTable.Attending);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Attending.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(WorkshopsTable.Attending, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Attending, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void AvailableWorkshopIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by AvailableWorkshopId when clicked.
              
            // Get previous sorting state for AvailableWorkshopId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(WorkshopsTable.AvailableWorkshopId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for AvailableWorkshopId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(WorkshopsTable.AvailableWorkshopId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by AvailableWorkshopId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = WorkshopsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  WorkshopsRecord[] DataSource {
             
            get {
                return (WorkshopsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton AttendingLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttendingLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AvailableWorkshopIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AvailableWorkshopIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title2");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                WorkshopsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        WorkshopsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                WorkshopsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        WorkshopsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual WorkshopsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual WorkshopsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (WorkshopsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_Registered_Table.WorkshopsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            WorkshopsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (WorkshopsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual WorkshopsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "WorkshopsTableControlRow");
	          List<WorkshopsTableControlRow> list = new List<WorkshopsTableControlRow>();
	          foreach (WorkshopsTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  

#endregion
    
  
}

  