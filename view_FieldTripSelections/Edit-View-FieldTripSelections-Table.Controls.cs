
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_View_FieldTripSelections_Table.aspx page.  The Row or RecordControl classes are the 
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
		

#endregion

  
namespace OLR.UI.Controls.Edit_View_FieldTripSelections_Table
{
  

#region "Section 1: Place your customizations here."

    
public class View_FieldTripSelectionsTableControlRow : BaseView_FieldTripSelectionsTableControlRow
{
      
        // The BaseView_FieldTripSelectionsTableControlRow implements code for a ROW within the
        // the View_FieldTripSelectionsTableControl table.  The BaseView_FieldTripSelectionsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of View_FieldTripSelectionsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

		public override void SetFieldTripId1()
        {
            
                    
            // Set the FieldTripId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.FieldTripId1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripIdSpecified) {
                								
                // If the FieldTripId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.FieldTripId);
                //if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.FieldTripId.IsApplyDisplayAs)

                //      formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.FieldTripId.ToString(),View_FieldTripSelectionsView.FieldTripId, null);

                //if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                formattedValue = this.DataSource.FieldTripId.ToString(); //.Format(View_FieldTripSelectionsView.FieldTripId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripId1.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripId1.Text = View_FieldTripSelectionsView.FieldTripId.Format(View_FieldTripSelectionsView.FieldTripId.DefaultValue);
            		
            }
                               
        }

        public override void SaveData()
        {
            bool savedOkay = true;
            this.LoadData();

            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null)
            {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value)
                {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OLR"));
                }
            }

            this.GetUIData();

            if (this.DataSource.IsAnyValueChanged)
            {
                var uid = this.ValidationUid.Text;
                var date = this.DatePaid.Text;
                var allocatedId = this.AllocatedId.Text;
                var fieldTripId = this.FieldTripId1.Text;

                savedOkay = CustomTools.CustomStoredProcedures.SaveFieldTripData(uid, date, allocatedId, fieldTripId);
            }
            if (!savedOkay)
            {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", "Error saving data");
            }
            //base.SaveData();
        }
    }

  

public class View_FieldTripSelectionsTableControl : BaseView_FieldTripSelectionsTableControl
{
        // The BaseView_FieldTripSelectionsTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The View_FieldTripSelectionsTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
        public override void SaveButton_Click(object sender, ImageClickEventArgs args)
        {

            try
            {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();


                if (!this.Page.IsPageRefresh)
                {
                    this.SaveData();
                }

                // Save data is managed via SP

                ////this.Page.CommitTransaction(sender);
                // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"

                foreach (View_FieldTripSelectionsTableControlRow recCtl in this.GetRecordControls())
                {

                    recCtl.IsNewRecord = false;
                }

                // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.

                this.DeletedRecordIds = null;

            }
            catch (Exception ex)
            {
                // Upon error, rollback the transaction
                //this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;

                // Report the error message to the end user
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);

            }
            finally
            {
                DbUtils.EndTransaction();
            }

            string url = @"../view_FieldTripSelections/Edit-View-FieldTripSelections-Table.aspx";

            this.Page.Response.Redirect(url);

        }
    }

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the View_FieldTripSelectionsTableControlRow control on the Edit_View_FieldTripSelections_Table page.
// Do not modify this class. Instead override any method in View_FieldTripSelectionsTableControlRow.
public class BaseView_FieldTripSelectionsTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseView_FieldTripSelectionsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in View_FieldTripSelectionsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in View_FieldTripSelectionsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
              this.AllocatedId.SelectedIndexChanged += AllocatedId_SelectedIndexChanged;
            
              this.DatePaid.TextChanged += DatePaid_TextChanged;
            
              this.ValidationUid.TextChanged += ValidationUid_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.view_FieldTripSelections record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = View_FieldTripSelectionsView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseView_FieldTripSelectionsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new View_FieldTripSelectionsRecord();
            
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
        
                SetContactId();
                SetDatePaid();
                
                SetFieldTripId();
                SetFieldTripId1();
                SetFirstChoiceId();
                SetInitialCreationDate();
                SetPaymentRef();
                SetSecondChoiceId();
                SetThirdChoiceId();
                SetValidationUid();
                SetAllocatedId();
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
            
        }
        
        
        public virtual void SetContactId()
        {
            
                    
            // Set the ContactId Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.ContactId is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactIdSpecified) {
                								
                // If the ContactId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.ContactId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.ContactId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.ContactId.ToString(),View_FieldTripSelectionsView.ContactId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.ContactId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ContactId.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactId.Text = View_FieldTripSelectionsView.ContactId.Format(View_FieldTripSelectionsView.ContactId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetDatePaid()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.DatePaid.ID))
            {
            
                this.DatePaid.Text = this.PreviousUIData[this.DatePaid.ID].ToString();
              
                return;
            }
            
                    
            // Set the DatePaid TextBox on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.DatePaid is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DatePaidSpecified) {
                								
                // If the DatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.DatePaid, @"d");
                                
                this.DatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // DatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DatePaid.Text = View_FieldTripSelectionsView.DatePaid.Format(View_FieldTripSelectionsView.DatePaid.DefaultValue, @"d");
            		
            }
            
              this.DatePaid.TextChanged += DatePaid_TextChanged;
                               
        }
                
        public virtual void SetFieldTripId()
        {
            
                    
            // Set the FieldTripId Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.FieldTripId is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripIdSpecified) {
                								
                // If the FieldTripId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.FieldTripId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.FieldTripId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.FieldTripId.ToString(),View_FieldTripSelectionsView.FieldTripId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.FieldTripId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripId.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripId.Text = View_FieldTripSelectionsView.FieldTripId.Format(View_FieldTripSelectionsView.FieldTripId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFieldTripId1()
        {
            
                    
            // Set the FieldTripId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.FieldTripId1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripIdSpecified) {
                								
                // If the FieldTripId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.FieldTripId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.FieldTripId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.FieldTripId.ToString(),View_FieldTripSelectionsView.FieldTripId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.FieldTripId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripId1.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripId1.Text = View_FieldTripSelectionsView.FieldTripId.Format(View_FieldTripSelectionsView.FieldTripId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFirstChoiceId()
        {
            
                    
            // Set the FirstChoiceId Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.FirstChoiceId is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstChoiceIdSpecified) {
                								
                // If the FirstChoiceId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.FirstChoiceId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.FirstChoiceId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.FirstChoiceId.ToString(),View_FieldTripSelectionsView.FirstChoiceId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.FirstChoiceId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstChoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstChoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstChoiceId.Text = View_FieldTripSelectionsView.FirstChoiceId.Format(View_FieldTripSelectionsView.FirstChoiceId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetInitialCreationDate()
        {
            
                    
            // Set the InitialCreationDate Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.InitialCreationDate is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InitialCreationDateSpecified) {
                								
                // If the InitialCreationDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.InitialCreationDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InitialCreationDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InitialCreationDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InitialCreationDate.Text = View_FieldTripSelectionsView.InitialCreationDate.Format(View_FieldTripSelectionsView.InitialCreationDate.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void SetPaymentRef()
        {
            
                    
            // Set the PaymentRef Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.PaymentRef is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PaymentRefSpecified) {
                								
                // If the PaymentRef is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.PaymentRef);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PaymentRef.Text = formattedValue;
                   
            } 
            
            else {
            
                // PaymentRef is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PaymentRef.Text = View_FieldTripSelectionsView.PaymentRef.Format(View_FieldTripSelectionsView.PaymentRef.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetSecondChoiceId()
        {
            
                    
            // Set the SecondChoiceId Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.SecondChoiceId is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SecondChoiceIdSpecified) {
                								
                // If the SecondChoiceId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.SecondChoiceId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.SecondChoiceId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.SecondChoiceId.ToString(),View_FieldTripSelectionsView.SecondChoiceId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.SecondChoiceId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SecondChoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // SecondChoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SecondChoiceId.Text = View_FieldTripSelectionsView.SecondChoiceId.Format(View_FieldTripSelectionsView.SecondChoiceId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetThirdChoiceId()
        {
            
                    
            // Set the ThirdChoiceId Label on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.ThirdChoiceId is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ThirdChoiceIdSpecified) {
                								
                // If the ThirdChoiceId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.ThirdChoiceId);
               if(_isExpandableNonCompositeForeignKey &&View_FieldTripSelectionsView.ThirdChoiceId.IsApplyDisplayAs)
                                  
                     formattedValue = View_FieldTripSelectionsView.GetDFKA(this.DataSource.ThirdChoiceId.ToString(),View_FieldTripSelectionsView.ThirdChoiceId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.ThirdChoiceId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ThirdChoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // ThirdChoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ThirdChoiceId.Text = View_FieldTripSelectionsView.ThirdChoiceId.Format(View_FieldTripSelectionsView.ThirdChoiceId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetValidationUid()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ValidationUid.ID))
            {
            
                this.ValidationUid.Text = this.PreviousUIData[this.ValidationUid.ID].ToString();
              
                return;
            }
            
                    
            // Set the ValidationUid TextBox on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.ValidationUid is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ValidationUidSpecified) {
                								
                // If the ValidationUid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_FieldTripSelectionsView.ValidationUid);
                                
                this.ValidationUid.Text = formattedValue;
                   
            } 
            
            else {
            
                // ValidationUid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ValidationUid.Text = View_FieldTripSelectionsView.ValidationUid.Format(View_FieldTripSelectionsView.ValidationUid.DefaultValue);
            		
            }
            
              this.ValidationUid.TextChanged += ValidationUid_TextChanged;
                               
        }
                
        public virtual void SetAllocatedId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.AllocatedId.ID))
            {
                if (this.PreviousUIData[this.AllocatedId.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.AllocatedId.ID].ToString();
            }
            
            
            // Set the AllocatedId DropDownList on the webpage with value from the
            // DatabaseOLR_db%dbo.view_FieldTripSelections database record.
            
            // this.DataSource is the DatabaseOLR_db%dbo.view_FieldTripSelections record retrieved from the database.
            // this.AllocatedId is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetAllocatedId();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.AllocatedIdSpecified)
            {
                            
                // If the AllocatedId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.AllocatedId.ToString();
                
            }
            else
            {
                
                // AllocatedId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = View_FieldTripSelectionsView.AllocatedId.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateAllocatedIdDropDownList(selectedValue, 100);              
                
                  
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
                ((View_FieldTripSelectionsTableControl)MiscUtils.GetParentControlObject(this, "View_FieldTripSelectionsTableControl")).DataChanged = true;
                ((View_FieldTripSelectionsTableControl)MiscUtils.GetParentControlObject(this, "View_FieldTripSelectionsTableControl")).ResetData = true;
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
        
            GetContactId();
            GetDatePaid();
            GetFieldTripId();
            GetFieldTripId1();
            GetFirstChoiceId();
            GetInitialCreationDate();
            GetPaymentRef();
            GetSecondChoiceId();
            GetThirdChoiceId();
            GetValidationUid();
            GetAllocatedId();
        }
        
        
        public virtual void GetContactId()
        {
            
        }
                
        public virtual void GetDatePaid()
        {
            
            // Retrieve the value entered by the user on the DatePaid ASP:TextBox, and
            // save it into the DatePaid field in DataSource DatabaseOLR_db%dbo.view_FieldTripSelections record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.DatePaid.Text, View_FieldTripSelectionsView.DatePaid);							
                          
                      
        }
                
        public virtual void GetFieldTripId()
        {
            
        }
                
        public virtual void GetFieldTripId1()
        {
            
        }
                
        public virtual void GetFirstChoiceId()
        {
            
        }
                
        public virtual void GetInitialCreationDate()
        {
            
        }
                
        public virtual void GetPaymentRef()
        {
            
        }
                
        public virtual void GetSecondChoiceId()
        {
            
        }
                
        public virtual void GetThirdChoiceId()
        {
            
        }
                
        public virtual void GetValidationUid()
        {
            
            // Retrieve the value entered by the user on the ValidationUid ASP:TextBox, and
            // save it into the ValidationUid field in DataSource DatabaseOLR_db%dbo.view_FieldTripSelections record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ValidationUid.Text, View_FieldTripSelectionsView.ValidationUid);							
                          
                      
        }
                
        public virtual void GetAllocatedId()
        {
         // Retrieve the value entered by the user on the AllocatedId ASP:DropDownList, and
            // save it into the AllocatedId field in DataSource DatabaseOLR_db%dbo.view_FieldTripSelections record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.AllocatedId), View_FieldTripSelectionsView.AllocatedId);			
                			 
        }
                

      // To customize, override this method in View_FieldTripSelectionsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersView_FieldTripSelectionsTableControl = false;
            hasFiltersView_FieldTripSelectionsTableControl = hasFiltersView_FieldTripSelectionsTableControl && false; // suppress warning
      
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
          View_FieldTripSelectionsView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((View_FieldTripSelectionsTableControl)MiscUtils.GetParentControlObject(this, "View_FieldTripSelectionsTableControl")).DataChanged = true;
            ((View_FieldTripSelectionsTableControl)MiscUtils.GetParentControlObject(this, "View_FieldTripSelectionsTableControl")).ResetData = true;
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
        
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_AllocatedIdDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseOLR_db%dbo.FieldTripOptions table.
            // Examples:
            // wc.iAND(FieldTripOptionsTable.FieldTripOptionId, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(FieldTripOptionsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("View_FieldTripSelectionsTableControlRow.FieldTripId1.Text", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OLR.Business.FieldTripOptionsTable, OLR.Business").TableDefinition.ColumnList.GetByUniqueName(@"FieldTripOptions_.FieldTripId"), EvaluateFormula("View_FieldTripSelectionsTableControlRow.FieldTripId1.Text", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("View_FieldTripSelectionsTableControlRow.FieldTripId1.Text", false) == "--PLEASE_SELECT--" || EvaluateFormula("View_FieldTripSelectionsTableControlRow.FieldTripId1.Text", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the AllocatedId list.
        protected virtual void PopulateAllocatedIdDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.AllocatedId.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.AllocatedId.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OLR"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_AllocatedIdDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_AllocatedIdDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(FieldTripOptionsTable.Description, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the AllocatedIdDropDownList.
            FieldTripOptionsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = FieldTripOptionsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (FieldTripOptionsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.FieldTripOptionIdSpecified) 
                        {
                            cvalue = itemValue.FieldTripOptionId.ToString().ToString();
                            if (counter < maxItems && this.AllocatedId.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.AllocatedId);
                                if(_isExpandableNonCompositeForeignKey && View_FieldTripSelectionsView.AllocatedId.IsApplyDisplayAs)
                                    fvalue = View_FieldTripSelectionsView.GetDFKA(itemValue, View_FieldTripSelectionsView.AllocatedId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(FieldTripOptionsTable.FieldTripOptionId);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.AllocatedId.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.AllocatedId.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.AllocatedId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.AllocatedId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseOLR_db%dbo.FieldTripOptions.FieldTripOptionId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(FieldTripOptionsTable.FieldTripOptionId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    FieldTripOptionsRecord[] rc = FieldTripOptionsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        FieldTripOptionsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.FieldTripOptionIdSpecified)
                            cvalue = itemValue.FieldTripOptionId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.AllocatedId);
                        if(_isExpandableNonCompositeForeignKey && View_FieldTripSelectionsView.AllocatedId.IsApplyDisplayAs)
                            fvalue = View_FieldTripSelectionsView.GetDFKA(itemValue, View_FieldTripSelectionsView.AllocatedId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(FieldTripOptionsTable.FieldTripOptionId);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.AllocatedId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
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
            
            string url = @"../Shared/ConfigureEditRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
            
            
        
        protected virtual void AllocatedId_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[AllocatedId.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[AllocatedId.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.AllocatedId.Items.Add(new ListItem(displayText, val));
	            this.AllocatedId.SelectedIndex = this.AllocatedId.Items.Count - 1;
	            this.Page.Session.Remove(AllocatedId.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(AllocatedId.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void DatePaid_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ValidationUid_TextChanged(object sender, EventArgs args)
        {
                    
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
                return (string)this.ViewState["BaseView_FieldTripSelectionsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseView_FieldTripSelectionsTableControlRow_Rec"] = value;
            }
        }
        
        public View_FieldTripSelectionsRecord DataSource {
            get {
                return (View_FieldTripSelectionsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Label ContactId {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactId");
            }
        }
            
        public System.Web.UI.WebControls.TextBox DatePaid {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaid");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Label FieldTripId {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripId");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripId1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripId1");
            }
        }
            
        public System.Web.UI.WebControls.Label FirstChoiceId {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstChoiceId");
            }
        }
            
        public System.Web.UI.WebControls.Label InitialCreationDate {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal PaymentRef {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PaymentRef");
            }
        }
            
        public System.Web.UI.WebControls.Label SecondChoiceId {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SecondChoiceId");
            }
        }
            
        public System.Web.UI.WebControls.Label ThirdChoiceId {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ThirdChoiceId");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ValidationUid {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ValidationUid");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList AllocatedId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AllocatedId");
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
        View_FieldTripSelectionsRecord rec = null;
             
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
    View_FieldTripSelectionsRecord rec = null;
    
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

        
        public virtual View_FieldTripSelectionsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return View_FieldTripSelectionsView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the View_FieldTripSelectionsTableControl control on the Edit_View_FieldTripSelections_Table page.
// Do not modify this class. Instead override any method in View_FieldTripSelectionsTableControl.
public class BaseView_FieldTripSelectionsTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseView_FieldTripSelectionsTableControl()
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
                if  (this.InSession(this.ContactIdFilter)) 				
                    initialVal = this.GetFromSession(this.ContactIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ContactId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ContactIdFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ContactIdFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.FieldTripIdFilter)) 				
                    initialVal = this.GetFromSession(this.FieldTripIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"FieldTripId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.FieldTripIdFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.FieldTripIdFilter.SelectedValue = initialVal;
                            
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
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "OLR") + "\"));");
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.AllocatedIdLabel.Click += AllocatedIdLabel_Click;
            
              this.ContactIdLabel.Click += ContactIdLabel_Click;
            
              this.DatePaidLabel.Click += DatePaidLabel_Click;
            
              this.FieldTripIdLabel.Click += FieldTripIdLabel_Click;
            
              this.FirstChoiceIdLabel.Click += FirstChoiceIdLabel_Click;
            
              this.InitialCreationDateLabel.Click += InitialCreationDateLabel_Click;
            
              this.PaymentRefLabel.Click += PaymentRefLabel_Click;
            
              this.SecondChoiceIdLabel.Click += SecondChoiceIdLabel_Click;
            
              this.ThirdChoiceIdLabel.Click += ThirdChoiceIdLabel_Click;
            
            // Setup the button events.
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SaveButton.Click += SaveButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
            this.ContactIdFilter.SelectedIndexChanged += new EventHandler(ContactIdFilter_SelectedIndexChanged);
            
            this.FieldTripIdFilter.SelectedIndexChanged += new EventHandler(FieldTripIdFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OLR.Business.View_FieldTripSelectionsRecord);
                      this.DataSource = (View_FieldTripSelectionsRecord[])(alist.ToArray(myrec));
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
                    foreach (View_FieldTripSelectionsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.View_FieldTripSelectionsRecord);
                    this.DataSource = (View_FieldTripSelectionsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual View_FieldTripSelectionsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(View_FieldTripSelectionsView.Column1, true);          
            // selCols.Add(View_FieldTripSelectionsView.Column2, true);          
            // selCols.Add(View_FieldTripSelectionsView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return View_FieldTripSelectionsView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                View_FieldTripSelectionsView databaseTable = new View_FieldTripSelectionsView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(View_FieldTripSelectionsRecord)) as View_FieldTripSelectionsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(View_FieldTripSelectionsView.Column1, true);          
            // selCols.Add(View_FieldTripSelectionsView.Column2, true);          
            // selCols.Add(View_FieldTripSelectionsView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return View_FieldTripSelectionsView.GetRecordCount(join, where);
            else
            {
                View_FieldTripSelectionsView databaseTable = new View_FieldTripSelectionsView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_FieldTripSelectionsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            View_FieldTripSelectionsTableControlRow recControl = (View_FieldTripSelectionsTableControlRow)(repItem.FindControl("View_FieldTripSelectionsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetAllocatedIdLabel();
                SetContactIdFilter();
                SetContactIdLabel();
                SetContactIdLabel1();
                SetDatePaidLabel();
                
                
                SetFieldTripIdFilter();
                SetFieldTripIdLabel();
                SetFieldTripIdLabel1();
                
                
                SetFirstChoiceIdLabel();
                SetInitialCreationDateLabel();
                
                SetPaymentRefLabel();
                
                
                SetSecondChoiceIdLabel();
                SetSortByLabel();
                SetSortControl();
                SetThirdChoiceIdLabel();
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetExcelButton();
              
                SetResetButton();
              
                SetSaveButton();
              
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
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.ContactId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.FieldTripId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.FieldTripId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.FirstChoiceId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.SecondChoiceId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.ThirdChoiceId, this.DataSource);
            this.Page.PregetDfkaRecords(View_FieldTripSelectionsView.AllocatedId, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SaveButton"));
                                
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


            
            this.ContactIdFilter.ClearSelection();
            
            this.FieldTripIdFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
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
    
            // Bind the buttons for View_FieldTripSelectionsTableControl pagination.
        
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
              
            foreach (View_FieldTripSelectionsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (View_FieldTripSelectionsTableControlRow recCtl in this.GetRecordControls()){
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
            View_FieldTripSelectionsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.ContactIdFilter)) {
                        
                wc.iAND(View_FieldTripSelectionsView.ContactId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ContactIdFilter, this.GetFromSession(this.ContactIdFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.FieldTripIdFilter)) {
                        
                wc.iAND(View_FieldTripSelectionsView.FieldTripId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.FieldTripIdFilter, this.GetFromSession(this.FieldTripIdFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            View_FieldTripSelectionsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ContactIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ContactIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ContactIdFilterSelectedValue)) {

              
                wc.iAND(View_FieldTripSelectionsView.ContactId, BaseFilter.ComparisonOperator.EqualsTo, ContactIdFilterSelectedValue, false, false);
                      
      }
                      
      String FieldTripIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "FieldTripIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(FieldTripIdFilterSelectedValue)) {

              
                wc.iAND(View_FieldTripSelectionsView.FieldTripId, BaseFilter.ComparisonOperator.EqualsTo, FieldTripIdFilterSelectedValue, false, false);
                      
      }
                      

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_FieldTripSelectionsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                View_FieldTripSelectionsTableControlRow recControl = (View_FieldTripSelectionsTableControlRow)(repItem.FindControl("View_FieldTripSelectionsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      View_FieldTripSelectionsRecord rec = new View_FieldTripSelectionsRecord();
        
                        if (recControl.ContactId.Text != "") {
                            rec.Parse(recControl.ContactId.Text, View_FieldTripSelectionsView.ContactId);
                  }
                
                        if (recControl.DatePaid.Text != "") {
                            rec.Parse(recControl.DatePaid.Text, View_FieldTripSelectionsView.DatePaid);
                  }
                
                        if (recControl.FieldTripId.Text != "") {
                            rec.Parse(recControl.FieldTripId.Text, View_FieldTripSelectionsView.FieldTripId);
                  }
                
                        if (recControl.FieldTripId1.Text != "") {
                            rec.Parse(recControl.FieldTripId1.Text, View_FieldTripSelectionsView.FieldTripId);
                  }
                
                        if (recControl.FirstChoiceId.Text != "") {
                            rec.Parse(recControl.FirstChoiceId.Text, View_FieldTripSelectionsView.FirstChoiceId);
                  }
                
                        if (recControl.InitialCreationDate.Text != "") {
                            rec.Parse(recControl.InitialCreationDate.Text, View_FieldTripSelectionsView.InitialCreationDate);
                  }
                
                        if (recControl.PaymentRef.Text != "") {
                            rec.Parse(recControl.PaymentRef.Text, View_FieldTripSelectionsView.PaymentRef);
                  }
                
                        if (recControl.SecondChoiceId.Text != "") {
                            rec.Parse(recControl.SecondChoiceId.Text, View_FieldTripSelectionsView.SecondChoiceId);
                  }
                
                        if (recControl.ThirdChoiceId.Text != "") {
                            rec.Parse(recControl.ThirdChoiceId.Text, View_FieldTripSelectionsView.ThirdChoiceId);
                  }
                
                        if (recControl.ValidationUid.Text != "") {
                            rec.Parse(recControl.ValidationUid.Text, View_FieldTripSelectionsView.ValidationUid);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.AllocatedId)) {
                            rec.Parse(recControl.AllocatedId.SelectedItem.Value, View_FieldTripSelectionsView.AllocatedId);
                        }
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new View_FieldTripSelectionsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.View_FieldTripSelectionsRecord);
                this.DataSource = (View_FieldTripSelectionsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(View_FieldTripSelectionsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(View_FieldTripSelectionsTableControlRow rec)            
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
        
        public virtual void SetAllocatedIdLabel()
                  {
                  
                        this.AllocatedIdLabel.Text = EvaluateFormula("\"Allocated Field Trip\"");
                      
                    
        }
                
        public virtual void SetContactIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetDatePaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetFieldTripIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetFieldTripIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFirstChoiceIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetInitialCreationDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetPaymentRefLabel()
                  {
                  
                    
        }
                
        public virtual void SetSecondChoiceIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetThirdChoiceIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void SetContactIdFilter()
        {
            
            this.PopulateContactIdFilter(MiscUtils.GetSelectedValue(this.ContactIdFilter,  GetFromSession(this.ContactIdFilter)), 500);					
                                     
        }
            
        public virtual void SetFieldTripIdFilter()
        {
            
            this.PopulateFieldTripIdFilter(MiscUtils.GetSelectedValue(this.FieldTripIdFilter,  GetFromSession(this.FieldTripIdFilter)), 500);					
                                     
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Allocated {Txt:Ascending}"), "AllocatedId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Allocated {Txt:Descending}"), "AllocatedId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Ascending}"), "ContactId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact {Txt:Descending}"), "ContactId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Paid {Txt:Ascending}"), "DatePaid Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Paid {Txt:Descending}"), "DatePaid Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip {Txt:Ascending}"), "FieldTripId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip {Txt:Descending}"), "FieldTripId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("First Choice {Txt:Ascending}"), "FirstChoiceId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("First Choice {Txt:Descending}"), "FirstChoiceId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Initial Creation Date {Txt:Ascending}"), "InitialCreationDate Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Initial Creation Date {Txt:Descending}"), "InitialCreationDate Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Second Choice {Txt:Ascending}"), "SecondChoiceId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Second Choice {Txt:Descending}"), "SecondChoiceId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Third Choice {Txt:Ascending}"), "ThirdChoiceId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Third Choice {Txt:Descending}"), "ThirdChoiceId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Validation UID {Txt:Ascending}"), "ValidationUid Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Validation UID {Txt:Descending}"), "ValidationUid Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Payment Reference {Txt:Ascending}"), "PaymentRef Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Payment Reference {Txt:Descending}"), "PaymentRef Desc"));
              
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
            
        // Get the filters' data for ContactIdFilter.
                
        protected virtual void PopulateContactIdFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ContactIdFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ContactIdFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ContactIdFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ContactIdFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OLR"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ContactsTable.FirstName, OrderByItem.OrderDir.Asc);
              orderBy.Add(ContactsTable.LastName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OLR");

            ContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = ContactsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (ContactsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ContactIdSpecified) 
                        {
                            cvalue = itemValue.ContactId.ToString();
                            if (counter < maxItems && this.ContactIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.ContactId);
                                if(_isExpandableNonCompositeForeignKey && View_FieldTripSelectionsView.ContactId.IsApplyDisplayAs)
                                     fvalue = View_FieldTripSelectionsView.GetDFKA(itemValue, View_FieldTripSelectionsView.ContactId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(ContactsTable.ContactId);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ContactIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ContactIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.ContactIdFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ContactIdFilter.SelectedValue != null && this.ContactIdFilter.Items.FindByValue(this.ContactIdFilter.SelectedValue) == null)
                this.ContactIdFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for FieldTripIdFilter.
                
        protected virtual void PopulateFieldTripIdFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.FieldTripIdFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_FieldTripIdFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FieldTripIdFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.FieldTripIdFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OLR"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(FieldTripsTable.Description, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OLR");

            FieldTripsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = FieldTripsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (FieldTripsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.FieldTripIdSpecified) 
                        {
                            cvalue = itemValue.FieldTripId.ToString();
                            if (counter < maxItems && this.FieldTripIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = View_FieldTripSelectionsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_FieldTripSelectionsView.FieldTripId);
                                if(_isExpandableNonCompositeForeignKey && View_FieldTripSelectionsView.FieldTripId.IsApplyDisplayAs)
                                     fvalue = View_FieldTripSelectionsView.GetDFKA(itemValue, View_FieldTripSelectionsView.FieldTripId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(FieldTripsTable.FieldTripId);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.FieldTripIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.FieldTripIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.FieldTripIdFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.FieldTripIdFilter.SelectedValue != null && this.FieldTripIdFilter.Items.FindByValue(this.FieldTripIdFilter.SelectedValue) == null)
                this.FieldTripIdFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_ContactIdFilter()
        {
            // Create a where clause for the filter ContactIdFilter.
            // This function is called by the Populate method to load the items 
            // in the ContactIdFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_FieldTripIdFilter()
        {
            // Create a where clause for the filter FieldTripIdFilter.
            // This function is called by the Populate method to load the items 
            // in the FieldTripIdFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("View_FieldTripSelectionsTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                View_FieldTripSelectionsTableControlRow recControl = (View_FieldTripSelectionsTableControlRow)repItem.FindControl("View_FieldTripSelectionsTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
            }
        }
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            this.SaveToSession(this.ContactIdFilter, this.ContactIdFilter.SelectedValue);
                  
            this.SaveToSession(this.FieldTripIdFilter, this.FieldTripIdFilter.SelectedValue);
                  
            
                    
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
                  
      this.SaveToSession("ContactIdFilter_Ajax", this.ContactIdFilter.SelectedValue);
              
      this.SaveToSession("FieldTripIdFilter_Ajax", this.FieldTripIdFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.ContactIdFilter);
            this.RemoveFromSession(this.FieldTripIdFilter);
            
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

            string orderByStr = (string)ViewState["View_FieldTripSelectionsTableControl_OrderBy"];
          
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
                this.ViewState["View_FieldTripSelectionsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetAddButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSaveButton()                
              
        {
        
                    this.SaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "OLR") + "\");");
                  
   
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
    
      
            if (MiscUtils.IsValueSelected(ContactIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(FieldTripIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
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
        
        public virtual void AllocatedIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by AllocatedId when clicked.
              
            // Get previous sorting state for AllocatedId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.AllocatedId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for AllocatedId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.AllocatedId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by AllocatedId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ContactIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ContactId when clicked.
              
            // Get previous sorting state for ContactId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.ContactId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ContactId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.ContactId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ContactId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void DatePaidLabel_Click(object sender, EventArgs args)
        {
            //Sorts by DatePaid when clicked.
              
            // Get previous sorting state for DatePaid.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.DatePaid);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for DatePaid.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.DatePaid, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by DatePaid, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void FieldTripIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by FieldTripId when clicked.
              
            // Get previous sorting state for FieldTripId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.FieldTripId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for FieldTripId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.FieldTripId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by FieldTripId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void FirstChoiceIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by FirstChoiceId when clicked.
              
            // Get previous sorting state for FirstChoiceId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.FirstChoiceId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for FirstChoiceId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.FirstChoiceId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by FirstChoiceId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void InitialCreationDateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by InitialCreationDate when clicked.
              
            // Get previous sorting state for InitialCreationDate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.InitialCreationDate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for InitialCreationDate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.InitialCreationDate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by InitialCreationDate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PaymentRefLabel_Click(object sender, EventArgs args)
        {
            //Sorts by PaymentRef when clicked.
              
            // Get previous sorting state for PaymentRef.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.PaymentRef);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PaymentRef.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.PaymentRef, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PaymentRef, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void SecondChoiceIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by SecondChoiceId when clicked.
              
            // Get previous sorting state for SecondChoiceId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.SecondChoiceId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for SecondChoiceId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.SecondChoiceId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by SecondChoiceId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ThirdChoiceIdLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ThirdChoiceId when clicked.
              
            // Get previous sorting state for ThirdChoiceId.
        
            OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.ThirdChoiceId);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ThirdChoiceId.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(View_FieldTripSelectionsView.ThirdChoiceId, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ThirdChoiceId, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void AddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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


              this.TotalRecords = View_FieldTripSelectionsView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             View_FieldTripSelectionsView.ContactId,
             View_FieldTripSelectionsView.DatePaid,
             View_FieldTripSelectionsView.InitialCreationDate,
             View_FieldTripSelectionsView.FieldTripId,
             View_FieldTripSelectionsView.FirstChoiceId,
             View_FieldTripSelectionsView.SecondChoiceId,
             View_FieldTripSelectionsView.ThirdChoiceId,
             View_FieldTripSelectionsView.AllocatedId,
             View_FieldTripSelectionsView.PaymentRef,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(View_FieldTripSelectionsView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(View_FieldTripSelectionsView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(View_FieldTripSelectionsView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(View_FieldTripSelectionsView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.ContactId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.DatePaid, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.InitialCreationDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.FieldTripId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.FirstChoiceId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.SecondChoiceId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.ThirdChoiceId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.AllocatedId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_FieldTripSelectionsView.PaymentRef, "Default"));


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
                val = View_FieldTripSelectionsView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.ContactIdFilter.ClearSelection();
            
              this.FieldTripIdFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
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
        public virtual void SaveButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.Page.CommitTransaction(sender);
          // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
           
                foreach (View_FieldTripSelectionsTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
          // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                this.DeletedRecordIds = null;
            
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in View_FieldTripSelectionsView.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(View_FieldTripSelectionsView.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (View_FieldTripSelectionsView.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && View_FieldTripSelectionsView.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(View_FieldTripSelectionsView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(View_FieldTripSelectionsView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void ContactIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void FieldTripIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = View_FieldTripSelectionsView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  View_FieldTripSelectionsRecord[] DataSource {
             
            get {
                return (View_FieldTripSelectionsRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton AddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AddButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AllocatedIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AllocatedIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ContactIdFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIdFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ContactIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ContactIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DatePaidLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList FieldTripIdFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FieldTripIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdLabel1");
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
        
        public System.Web.UI.WebControls.LinkButton FirstChoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstChoiceIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton InitialCreationDateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDateLabel");
            }
        }
        
        public OLR.UI.IPaginationModern Pagination {
            get {
                return (OLR.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PaymentRefLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PaymentRefLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SaveButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton SecondChoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SecondChoiceIdLabel");
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
        
        public System.Web.UI.WebControls.LinkButton ThirdChoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ThirdChoiceIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
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
                View_FieldTripSelectionsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_FieldTripSelectionsRecord rec = null;
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
                View_FieldTripSelectionsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_FieldTripSelectionsRecord rec = null;
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
          
        public virtual View_FieldTripSelectionsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual View_FieldTripSelectionsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (View_FieldTripSelectionsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Edit_View_FieldTripSelections_Table.View_FieldTripSelectionsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            View_FieldTripSelectionsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (View_FieldTripSelectionsTableControlRow recCtl in recordList)
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

        public virtual View_FieldTripSelectionsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "View_FieldTripSelectionsTableControlRow");
	          List<View_FieldTripSelectionsTableControlRow> list = new List<View_FieldTripSelectionsTableControlRow>();
	          foreach (View_FieldTripSelectionsTableControlRow recCtrl in recCtrls) {
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

  