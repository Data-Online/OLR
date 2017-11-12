
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_View_AllDataExtract_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OLR.UI.Controls.Show_View_AllDataExtract_Table
{
  

#region "Section 1: Place your customizations here."

    
public class View_AllDataExtractTableControlRow : BaseView_AllDataExtractTableControlRow
{
      
        // The BaseView_AllDataExtractTableControlRow implements code for a ROW within the
        // the View_AllDataExtractTableControl table.  The BaseView_AllDataExtractTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of View_AllDataExtractTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class View_AllDataExtractTableControl : BaseView_AllDataExtractTableControl
{
    // The BaseView_AllDataExtractTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The View_AllDataExtractTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the View_AllDataExtractTableControlRow control on the Show_View_AllDataExtract_Table page.
// Do not modify this class. Instead override any method in View_AllDataExtractTableControlRow.
public class BaseView_AllDataExtractTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseView_AllDataExtractTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in View_AllDataExtractTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in View_AllDataExtractTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.FT1_1.Click += FT1_1_Click;
                        
                    this.FT1_2.Click += FT1_2_Click;
                        
                    this.FT1_3.Click += FT1_3_Click;
                        
                    this.FT2_1.Click += FT2_1_Click;
                        
                    this.FT2_2.Click += FT2_2_Click;
                        
                    this.FT2_3.Click += FT2_3_Click;
                        
                    this.FTA1.Click += FTA1_Click;
                        
                    this.FTA2.Click += FTA2_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.view_AllDataExtract record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = View_AllDataExtractView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseView_AllDataExtractTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new View_AllDataExtractRecord();
            
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
                SetAdditionalDinnerNameLabel();
                SetAdditionalDinnerTicket();
                SetAdditionalDinnerTicketLabel();
                SetAddress1();
                SetAddress1Label();
                SetAddress2();
                SetAddress2Label();
                SetAddress3();
                SetAddress3Label();
                SetAttending();
                SetAttending2();
                SetAttending2Label();
                SetAttendingLabel();
                SetContactId();
                SetContactIdLabel();
                SetDatePaid();
                SetDatePaidLabel();
                SetDescription1();
                SetDescription1Label();
                SetDescription2();
                SetDescription2Label();
                SetEmail();
                SetEmailLabel();
                SetFirstName();
                SetFirstNameLabel();
                SetFT1_1();
                SetFT1_1Label();
                SetFT1_2();
                SetFT1_2Label();
                SetFT1_3();
                SetFT1_3Label();
                SetFT2_1();
                SetFT2_1Label();
                SetFT2_2();
                SetFT2_2Label();
                SetFT2_3();
                SetFT2_3Label();
                SetFTA1();
                SetFTA1Label();
                SetFTA2();
                SetFTA2Label();
                SetInitialCreationDate();
                SetInitialCreationDateLabel();
                SetLastName();
                SetLastNameLabel();
                SetMobileNumber();
                SetMobileNumberLabel();
                SetPSNZAppliedFor();
                SetPSNZAppliedForLabel();
                SetPSNZMember();
                SetPSNZMemberLabel();
                SetPSNZMembershipCheck();
                SetPSNZMembershipCheckLabel();
                SetRegistrationId();
                SetRegistrationIdLabel();
                SetRegistrationType();
                SetRegistrationTypeLabel();
                SetSpecialRequirements();
                SetSpecialRequirementsLabel();
                SetTownName();
                SetTownNameLabel();
                SetWorkshopDescription();
                SetWorkshopDescription2();
                SetWorkshopDescription2Label();
                SetWorkshopDescriptionLabel();

      

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
        
        
        public virtual void SetAdditionalDinnerName()
        {
            
                    
            // Set the AdditionalDinnerName Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.AdditionalDinnerName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerNameSpecified) {
                								
                // If the AdditionalDinnerName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.AdditionalDinnerName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerName.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerName.Text = View_AllDataExtractView.AdditionalDinnerName.Format(View_AllDataExtractView.AdditionalDinnerName.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.AdditionalDinnerTicket is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerTicketSpecified) {
                								
                // If the AdditionalDinnerTicket is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.AdditionalDinnerTicket);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerTicket.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerTicket is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerTicket.Text = View_AllDataExtractView.AdditionalDinnerTicket.Format(View_AllDataExtractView.AdditionalDinnerTicket.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = View_AllDataExtractView.Address1.Format(View_AllDataExtractView.Address1.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = View_AllDataExtractView.Address2.Format(View_AllDataExtractView.Address2.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Address3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = View_AllDataExtractView.Address3.Format(View_AllDataExtractView.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address3.Text == null ||
                this.Address3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttending()
        {
            
                    
            // Set the Attending Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Attending is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AttendingSpecified) {
                								
                // If the Attending is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Attending);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Attending.Text = formattedValue;
                   
            } 
            
            else {
            
                // Attending is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Attending.Text = View_AllDataExtractView.Attending.Format(View_AllDataExtractView.Attending.DefaultValue);
            		
            }
            
            // If the Attending is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Attending.Text == null ||
                this.Attending.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Attending.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAttending2()
        {
            
                    
            // Set the Attending2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Attending2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Attending2Specified) {
                								
                // If the Attending2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Attending2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Attending2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Attending2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Attending2.Text = View_AllDataExtractView.Attending2.Format(View_AllDataExtractView.Attending2.DefaultValue);
            		
            }
            
            // If the Attending2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Attending2.Text == null ||
                this.Attending2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Attending2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetContactId()
        {
            
                    
            // Set the ContactId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.ContactId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactIdSpecified) {
                								
                // If the ContactId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.ContactId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ContactId.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactId.Text = View_AllDataExtractView.ContactId.Format(View_AllDataExtractView.ContactId.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.DatePaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DatePaidSpecified) {
                								
                // If the DatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.DatePaid, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.DatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // DatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DatePaid.Text = View_AllDataExtractView.DatePaid.Format(View_AllDataExtractView.DatePaid.DefaultValue, @"d");
            		
            }
            
            // If the DatePaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.DatePaid.Text == null ||
                this.DatePaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.DatePaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDescription1()
        {
            
                    
            // Set the Description1 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Description1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Description1Specified) {
                								
                // If the Description1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Description1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Description1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Description1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Description1.Text = View_AllDataExtractView.Description1.Format(View_AllDataExtractView.Description1.DefaultValue);
            		
            }
            
            // If the Description1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Description1.Text == null ||
                this.Description1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Description1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDescription2()
        {
            
                    
            // Set the Description2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Description2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Description2Specified) {
                								
                // If the Description2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Description2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Description2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Description2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Description2.Text = View_AllDataExtractView.Description2.Format(View_AllDataExtractView.Description2.DefaultValue);
            		
            }
            
            // If the Description2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Description2.Text == null ||
                this.Description2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Description2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEmail()
        {
            
                    
            // Set the Email Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.Email is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EmailSpecified) {
                								
                // If the Email is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.Email);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Email.Text = formattedValue;
                   
            } 
            
            else {
            
                // Email is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Email.Text = View_AllDataExtractView.Email.Format(View_AllDataExtractView.Email.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FirstName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.FirstName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName.Text = View_AllDataExtractView.FirstName.Format(View_AllDataExtractView.FirstName.DefaultValue);
            		
            }
            
            // If the FirstName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName.Text == null ||
                this.FirstName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFT1_1()
        {
            
                    
            // Set the FT1_1 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT1_1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT1_1Specified) {
                								
                // If the FT1_1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_1);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT1_1.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT1_1.ToString(),View_AllDataExtractView.FT1_1, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT1_1);
                                  
                                
                this.FT1_1.Text = formattedValue;
                
                  this.FT1_1.ToolTip = "Go to " + this.FT1_1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT1_1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT1_1.Text = View_AllDataExtractView.FT1_1.Format(View_AllDataExtractView.FT1_1.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFT1_2()
        {
            
                    
            // Set the FT1_2 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT1_2 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT1_2Specified) {
                								
                // If the FT1_2 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_2);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT1_2.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT1_2.ToString(),View_AllDataExtractView.FT1_2, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT1_2);
                                  
                                
                this.FT1_2.Text = formattedValue;
                
                  this.FT1_2.ToolTip = "Go to " + this.FT1_2.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT1_2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT1_2.Text = View_AllDataExtractView.FT1_2.Format(View_AllDataExtractView.FT1_2.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFT1_3()
        {
            
                    
            // Set the FT1_3 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT1_3 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT1_3Specified) {
                								
                // If the FT1_3 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_3);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT1_3.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT1_3.ToString(),View_AllDataExtractView.FT1_3, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT1_3);
                                  
                                
                this.FT1_3.Text = formattedValue;
                
                  this.FT1_3.ToolTip = "Go to " + this.FT1_3.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT1_3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT1_3.Text = View_AllDataExtractView.FT1_3.Format(View_AllDataExtractView.FT1_3.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFT2_1()
        {
            
                    
            // Set the FT2_1 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT2_1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT2_1Specified) {
                								
                // If the FT2_1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_1);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT2_1.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT2_1.ToString(),View_AllDataExtractView.FT2_1, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT2_1);
                                  
                                
                this.FT2_1.Text = formattedValue;
                
                  this.FT2_1.ToolTip = "Go to " + this.FT2_1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT2_1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT2_1.Text = View_AllDataExtractView.FT2_1.Format(View_AllDataExtractView.FT2_1.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFT2_2()
        {
            
                    
            // Set the FT2_2 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT2_2 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT2_2Specified) {
                								
                // If the FT2_2 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_2);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT2_2.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT2_2.ToString(),View_AllDataExtractView.FT2_2, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT2_2);
                                  
                                
                this.FT2_2.Text = formattedValue;
                
                  this.FT2_2.ToolTip = "Go to " + this.FT2_2.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT2_2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT2_2.Text = View_AllDataExtractView.FT2_2.Format(View_AllDataExtractView.FT2_2.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFT2_3()
        {
            
                    
            // Set the FT2_3 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FT2_3 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FT2_3Specified) {
                								
                // If the FT2_3 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_3);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FT2_3.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FT2_3.ToString(),View_AllDataExtractView.FT2_3, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FT2_3);
                                  
                                
                this.FT2_3.Text = formattedValue;
                
                  this.FT2_3.ToolTip = "Go to " + this.FT2_3.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FT2_3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FT2_3.Text = View_AllDataExtractView.FT2_3.Format(View_AllDataExtractView.FT2_3.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFTA1()
        {
            
                    
            // Set the FTA1 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FTA1 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FTA1Specified) {
                								
                // If the FTA1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA1);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FTA1.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FTA1.ToString(),View_AllDataExtractView.FTA1, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FTA1);
                                  
                                
                this.FTA1.Text = formattedValue;
                
                  this.FTA1.ToolTip = "Go to " + this.FTA1.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FTA1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FTA1.Text = View_AllDataExtractView.FTA1.Format(View_AllDataExtractView.FTA1.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetFTA2()
        {
            
                    
            // Set the FTA2 LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.FTA2 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FTA2Specified) {
                								
                // If the FTA2 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA2);
               if(_isExpandableNonCompositeForeignKey &&View_AllDataExtractView.FTA2.IsApplyDisplayAs)
                                  
                     formattedValue = View_AllDataExtractView.GetDFKA(this.DataSource.FTA2.ToString(),View_AllDataExtractView.FTA2, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_AllDataExtractView.FTA2);
                                  
                                
                this.FTA2.Text = formattedValue;
                
                  this.FTA2.ToolTip = "Go to " + this.FTA2.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // FTA2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FTA2.Text = View_AllDataExtractView.FTA2.Format(View_AllDataExtractView.FTA2.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetInitialCreationDate()
        {
            
                    
            // Set the InitialCreationDate Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.InitialCreationDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InitialCreationDateSpecified) {
                								
                // If the InitialCreationDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.InitialCreationDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InitialCreationDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InitialCreationDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InitialCreationDate.Text = View_AllDataExtractView.InitialCreationDate.Format(View_AllDataExtractView.InitialCreationDate.DefaultValue, @"d");
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.LastName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.LastName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName.Text = View_AllDataExtractView.LastName.Format(View_AllDataExtractView.LastName.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.MobileNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MobileNumberSpecified) {
                								
                // If the MobileNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.MobileNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.MobileNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // MobileNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MobileNumber.Text = View_AllDataExtractView.MobileNumber.Format(View_AllDataExtractView.MobileNumber.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.PSNZAppliedFor is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZAppliedForSpecified) {
                								
                // If the PSNZAppliedFor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.PSNZAppliedFor);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZAppliedFor.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZAppliedFor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZAppliedFor.Text = View_AllDataExtractView.PSNZAppliedFor.Format(View_AllDataExtractView.PSNZAppliedFor.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.PSNZMember is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZMemberSpecified) {
                								
                // If the PSNZMember is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.PSNZMember);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZMember.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZMember is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZMember.Text = View_AllDataExtractView.PSNZMember.Format(View_AllDataExtractView.PSNZMember.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.PSNZMembershipCheck is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PSNZMembershipCheckSpecified) {
                								
                // If the PSNZMembershipCheck is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.PSNZMembershipCheck);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PSNZMembershipCheck.Text = formattedValue;
                   
            } 
            
            else {
            
                // PSNZMembershipCheck is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PSNZMembershipCheck.Text = View_AllDataExtractView.PSNZMembershipCheck.Format(View_AllDataExtractView.PSNZMembershipCheck.DefaultValue);
            		
            }
            
            // If the PSNZMembershipCheck is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PSNZMembershipCheck.Text == null ||
                this.PSNZMembershipCheck.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PSNZMembershipCheck.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegistrationId()
        {
            
                    
            // Set the RegistrationId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.RegistrationId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegistrationIdSpecified) {
                								
                // If the RegistrationId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.RegistrationId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RegistrationId.Text = formattedValue;
                   
            } 
            
            else {
            
                // RegistrationId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegistrationId.Text = View_AllDataExtractView.RegistrationId.Format(View_AllDataExtractView.RegistrationId.DefaultValue);
            		
            }
            
            // If the RegistrationId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RegistrationId.Text == null ||
                this.RegistrationId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RegistrationId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegistrationType()
        {
            
                    
            // Set the RegistrationType Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.RegistrationType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegistrationTypeSpecified) {
                								
                // If the RegistrationType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.RegistrationType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RegistrationType.Text = formattedValue;
                   
            } 
            
            else {
            
                // RegistrationType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegistrationType.Text = View_AllDataExtractView.RegistrationType.Format(View_AllDataExtractView.RegistrationType.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.SpecialRequirements is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SpecialRequirementsSpecified) {
                								
                // If the SpecialRequirements is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.SpecialRequirements);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SpecialRequirements.Text = formattedValue;
                   
            } 
            
            else {
            
                // SpecialRequirements is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SpecialRequirements.Text = View_AllDataExtractView.SpecialRequirements.Format(View_AllDataExtractView.SpecialRequirements.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.TownName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TownNameSpecified) {
                								
                // If the TownName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.TownName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TownName.Text = formattedValue;
                   
            } 
            
            else {
            
                // TownName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TownName.Text = View_AllDataExtractView.TownName.Format(View_AllDataExtractView.TownName.DefaultValue);
            		
            }
            
            // If the TownName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TownName.Text == null ||
                this.TownName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TownName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetWorkshopDescription()
        {
            
                    
            // Set the WorkshopDescription Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.WorkshopDescription is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.WorkshopDescriptionSpecified) {
                								
                // If the WorkshopDescription is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.WorkshopDescription);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.WorkshopDescription.Text = formattedValue;
                   
            } 
            
            else {
            
                // WorkshopDescription is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.WorkshopDescription.Text = View_AllDataExtractView.WorkshopDescription.Format(View_AllDataExtractView.WorkshopDescription.DefaultValue);
            		
            }
            
            // If the WorkshopDescription is NULL or blank, then use the value specified  
            // on Properties.
            if (this.WorkshopDescription.Text == null ||
                this.WorkshopDescription.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.WorkshopDescription.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetWorkshopDescription2()
        {
            
                    
            // Set the WorkshopDescription2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_AllDataExtract database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_AllDataExtract record retrieved from the database.
            // this.WorkshopDescription2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.WorkshopDescription2Specified) {
                								
                // If the WorkshopDescription2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_AllDataExtractView.WorkshopDescription2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.WorkshopDescription2.Text = formattedValue;
                   
            } 
            
            else {
            
                // WorkshopDescription2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.WorkshopDescription2.Text = View_AllDataExtractView.WorkshopDescription2.Format(View_AllDataExtractView.WorkshopDescription2.DefaultValue);
            		
            }
            
            // If the WorkshopDescription2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.WorkshopDescription2.Text == null ||
                this.WorkshopDescription2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.WorkshopDescription2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAdditionalDinnerNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetAdditionalDinnerTicketLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetAddress3Label()
                  {
                  
                    
        }
                
        public virtual void SetAttending2Label()
                  {
                  
                        this.Attending2Label.Text = EvaluateFormula("\"Attending\"");
                      
                    
        }
                
        public virtual void SetAttendingLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetDatePaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetDescription1Label()
                  {
                  
                    
        }
                
        public virtual void SetDescription2Label()
                  {
                  
                    
        }
                
        public virtual void SetEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetFT1_1Label()
                  {
                  
                        this.FT1_1Label.Text = EvaluateFormula("\"First Choice\"");
                      
                    
        }
                
        public virtual void SetFT1_2Label()
                  {
                  
                        this.FT1_2Label.Text = EvaluateFormula("\"Second Choice\"");
                      
                    
        }
                
        public virtual void SetFT1_3Label()
                  {
                  
                        this.FT1_3Label.Text = EvaluateFormula("\"Third Choice\"");
                      
                    
        }
                
        public virtual void SetFT2_1Label()
                  {
                  
                        this.FT2_1Label.Text = EvaluateFormula("\"First Choice\"");
                      
                    
        }
                
        public virtual void SetFT2_2Label()
                  {
                  
                        this.FT2_2Label.Text = EvaluateFormula("\"Second Choice\"");
                      
                    
        }
                
        public virtual void SetFT2_3Label()
                  {
                  
                        this.FT2_3Label.Text = EvaluateFormula("\"Third Choice\"");
                      
                    
        }
                
        public virtual void SetFTA1Label()
                  {
                  
                        this.FTA1Label.Text = EvaluateFormula("\"Allocated1\"");
                      
                    
        }
                
        public virtual void SetFTA2Label()
                  {
                  
                        this.FTA2Label.Text = EvaluateFormula("\"Allocated2\"");
                      
                    
        }
                
        public virtual void SetInitialCreationDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetMobileNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetPSNZAppliedForLabel()
                  {
                  
                    
        }
                
        public virtual void SetPSNZMemberLabel()
                  {
                  
                    
        }
                
        public virtual void SetPSNZMembershipCheckLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegistrationIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegistrationTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetSpecialRequirementsLabel()
                  {
                  
                    
        }
                
        public virtual void SetTownNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetWorkshopDescription2Label()
                  {
                  
                        this.WorkshopDescription2Label.Text = EvaluateFormula("\"Workshop\"");
                      
                    
        }
                
        public virtual void SetWorkshopDescriptionLabel()
                  {
                  
                        this.WorkshopDescriptionLabel.Text = EvaluateFormula("\"Workshop\"");
                      
                    
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
                ((View_AllDataExtractTableControl)MiscUtils.GetParentControlObject(this, "View_AllDataExtractTableControl")).DataChanged = true;
                ((View_AllDataExtractTableControl)MiscUtils.GetParentControlObject(this, "View_AllDataExtractTableControl")).ResetData = true;
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
        
            GetAdditionalDinnerName();
            GetAdditionalDinnerTicket();
            GetAddress1();
            GetAddress2();
            GetAddress3();
            GetAttending();
            GetAttending2();
            GetContactId();
            GetDatePaid();
            GetDescription1();
            GetDescription2();
            GetEmail();
            GetFirstName();
            GetFT1_1();
            GetFT1_2();
            GetFT1_3();
            GetFT2_1();
            GetFT2_2();
            GetFT2_3();
            GetFTA1();
            GetFTA2();
            GetInitialCreationDate();
            GetLastName();
            GetMobileNumber();
            GetPSNZAppliedFor();
            GetPSNZMember();
            GetPSNZMembershipCheck();
            GetRegistrationId();
            GetRegistrationType();
            GetSpecialRequirements();
            GetTownName();
            GetWorkshopDescription();
            GetWorkshopDescription2();
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
                
        public virtual void GetAttending()
        {
            
        }
                
        public virtual void GetAttending2()
        {
            
        }
                
        public virtual void GetContactId()
        {
            
        }
                
        public virtual void GetDatePaid()
        {
            
        }
                
        public virtual void GetDescription1()
        {
            
        }
                
        public virtual void GetDescription2()
        {
            
        }
                
        public virtual void GetEmail()
        {
            
        }
                
        public virtual void GetFirstName()
        {
            
        }
                
        public virtual void GetFT1_1()
        {
            
        }
                
        public virtual void GetFT1_2()
        {
            
        }
                
        public virtual void GetFT1_3()
        {
            
        }
                
        public virtual void GetFT2_1()
        {
            
        }
                
        public virtual void GetFT2_2()
        {
            
        }
                
        public virtual void GetFT2_3()
        {
            
        }
                
        public virtual void GetFTA1()
        {
            
        }
                
        public virtual void GetFTA2()
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
                
        public virtual void GetRegistrationId()
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
                
        public virtual void GetWorkshopDescription()
        {
            
        }
                
        public virtual void GetWorkshopDescription2()
        {
            
        }
                

      // To customize, override this method in View_AllDataExtractTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersView_AllDataExtractTableControl = false;
            hasFiltersView_AllDataExtractTableControl = hasFiltersView_AllDataExtractTableControl && false; // suppress warning
      
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
          View_AllDataExtractView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((View_AllDataExtractTableControl)MiscUtils.GetParentControlObject(this, "View_AllDataExtractTableControl")).DataChanged = true;
            ((View_AllDataExtractTableControl)MiscUtils.GetParentControlObject(this, "View_AllDataExtractTableControl")).ResetData = true;
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
        public virtual void FT1_1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT1_1_1}";
            
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
        public virtual void FT1_2_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT1_2_1}";
            
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
        public virtual void FT1_3_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT1_3_1}";
            
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
        public virtual void FT2_1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT2_1_1}";
            
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
        public virtual void FT2_2_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT2_2_1}";
            
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
        public virtual void FT2_3_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FT2_3_1}";
            
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
        public virtual void FTA1_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FTA1_1}";
            
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
        public virtual void FTA2_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../FieldTripOptions/Show-FieldTripOptions.aspx?FieldTripOptions={View_AllDataExtractTableControlRow:FK:VFK_view_AllDataExtract_FTA2_1}";
            
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
                return (string)this.ViewState["BaseView_AllDataExtractTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseView_AllDataExtractTableControlRow_Rec"] = value;
            }
        }
        
        public View_AllDataExtractRecord DataSource {
            get {
                return (View_AllDataExtractRecord)(this._DataSource);
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
            
        public System.Web.UI.WebControls.Literal AdditionalDinnerNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AdditionalDinnerTicket {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerTicket");
            }
        }
            
        public System.Web.UI.WebControls.Literal AdditionalDinnerTicketLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdditionalDinnerTicketLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Attending {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Attending");
            }
        }
            
        public System.Web.UI.WebControls.Literal Attending2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Attending2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Attending2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Attending2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal AttendingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AttendingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ContactId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactId");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DatePaid {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaid");
            }
        }
            
        public System.Web.UI.WebControls.Literal DatePaidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DatePaidLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Description1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Description1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Description2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Description2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Email {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Email");
            }
        }
            
        public System.Web.UI.WebControls.Literal EmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT1_1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_1");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT1_1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_1Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT1_2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_2");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT1_2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_2Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT1_3 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_3");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT1_3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT1_3Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT2_1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_1");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT2_1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_1Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT2_2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_2");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT2_2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_2Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FT2_3 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_3");
            }
        }
            
        public System.Web.UI.WebControls.Literal FT2_3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FT2_3Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FTA1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FTA1");
            }
        }
            
        public System.Web.UI.WebControls.Literal FTA1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FTA1Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FTA2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FTA2");
            }
        }
            
        public System.Web.UI.WebControls.Literal FTA2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FTA2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InitialCreationDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InitialCreationDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InitialCreationDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal MobileNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MobileNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal MobileNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MobileNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PSNZAppliedFor {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZAppliedFor");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZAppliedForLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZAppliedForLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PSNZMember {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMember");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZMemberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMemberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PSNZMembershipCheck {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMembershipCheck");
            }
        }
            
        public System.Web.UI.WebControls.Literal PSNZMembershipCheckLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PSNZMembershipCheckLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RegistrationId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationId");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegistrationIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RegistrationType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationType");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegistrationTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationTypeLabel");
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
            
        public System.Web.UI.WebControls.Literal TownNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TownNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal WorkshopDescription {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopDescription");
            }
        }
            
        public System.Web.UI.WebControls.Literal WorkshopDescription2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopDescription2");
            }
        }
            
        public System.Web.UI.WebControls.Literal WorkshopDescription2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopDescription2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal WorkshopDescriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WorkshopDescriptionLabel");
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
        View_AllDataExtractRecord rec = null;
             
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
    View_AllDataExtractRecord rec = null;
    
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

        
        public virtual View_AllDataExtractRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return View_AllDataExtractView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the View_AllDataExtractTableControl control on the Show_View_AllDataExtract_Table page.
// Do not modify this class. Instead override any method in View_AllDataExtractTableControl.
public class BaseView_AllDataExtractTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseView_AllDataExtractTableControl()
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
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
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
                      Type myrec = typeof(OLR.Business.View_AllDataExtractRecord);
                      this.DataSource = (View_AllDataExtractRecord[])(alist.ToArray(myrec));
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
                    foreach (View_AllDataExtractTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.View_AllDataExtractRecord);
                    this.DataSource = (View_AllDataExtractRecord[])(postdata.ToArray(myrec));
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
        
        public virtual View_AllDataExtractRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(View_AllDataExtractView.Column1, true);          
            // selCols.Add(View_AllDataExtractView.Column2, true);          
            // selCols.Add(View_AllDataExtractView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return View_AllDataExtractView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                View_AllDataExtractView databaseTable = new View_AllDataExtractView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(View_AllDataExtractRecord)) as View_AllDataExtractRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(View_AllDataExtractView.Column1, true);          
            // selCols.Add(View_AllDataExtractView.Column2, true);          
            // selCols.Add(View_AllDataExtractView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return View_AllDataExtractView.GetRecordCount(join, where);
            else
            {
                View_AllDataExtractView databaseTable = new View_AllDataExtractView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            View_AllDataExtractTableControlRow recControl = (View_AllDataExtractTableControlRow)(repItem.FindControl("View_AllDataExtractTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                
                
                SetSearchText();
                SetSortByLabel();
                SetSortControl();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
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
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT1_1, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT1_2, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT1_3, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT2_1, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT2_2, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FT2_3, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FTA1, this.DataSource);
            this.Page.PregetDfkaRecords(View_AllDataExtractView.FTA2, this.DataSource);
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
    
            // Bind the buttons for View_AllDataExtractTableControl pagination.
        
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
              
            foreach (View_AllDataExtractTableControlRow recCtl in this.GetRecordControls())
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
            foreach (View_AllDataExtractTableControlRow recCtl in this.GetRecordControls()){
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
            View_AllDataExtractView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
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
      
      cols.Add(View_AllDataExtractView.LastName, true);
      
      cols.Add(View_AllDataExtractView.FirstName, true);
      
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
            View_AllDataExtractView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
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
      
      cols.Add(View_AllDataExtractView.LastName, true);
      
      cols.Add(View_AllDataExtractView.FirstName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(View_AllDataExtractView.LastName, true);
      
      cols.Add(View_AllDataExtractView.FirstName, true);
      
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

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OLR.Business.View_AllDataExtractRecord[] recordList  = View_AllDataExtractView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (View_AllDataExtractRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(View_AllDataExtractView.LastName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(View_AllDataExtractView.LastName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, View_AllDataExtractView.LastName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(View_AllDataExtractView.FirstName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(View_AllDataExtractView.FirstName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, View_AllDataExtractView.FirstName.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                View_AllDataExtractTableControlRow recControl = (View_AllDataExtractTableControlRow)(repItem.FindControl("View_AllDataExtractTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      View_AllDataExtractRecord rec = new View_AllDataExtractRecord();
        
                        if (recControl.AdditionalDinnerName.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerName.Text, View_AllDataExtractView.AdditionalDinnerName);
                  }
                
                        if (recControl.AdditionalDinnerTicket.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerTicket.Text, View_AllDataExtractView.AdditionalDinnerTicket);
                  }
                
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, View_AllDataExtractView.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, View_AllDataExtractView.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, View_AllDataExtractView.Address3);
                  }
                
                        if (recControl.Attending.Text != "") {
                            rec.Parse(recControl.Attending.Text, View_AllDataExtractView.Attending);
                  }
                
                        if (recControl.Attending2.Text != "") {
                            rec.Parse(recControl.Attending2.Text, View_AllDataExtractView.Attending2);
                  }
                
                        if (recControl.ContactId.Text != "") {
                            rec.Parse(recControl.ContactId.Text, View_AllDataExtractView.ContactId);
                  }
                
                        if (recControl.DatePaid.Text != "") {
                            rec.Parse(recControl.DatePaid.Text, View_AllDataExtractView.DatePaid);
                  }
                
                        if (recControl.Description1.Text != "") {
                            rec.Parse(recControl.Description1.Text, View_AllDataExtractView.Description1);
                  }
                
                        if (recControl.Description2.Text != "") {
                            rec.Parse(recControl.Description2.Text, View_AllDataExtractView.Description2);
                  }
                
                        if (recControl.Email.Text != "") {
                            rec.Parse(recControl.Email.Text, View_AllDataExtractView.Email);
                  }
                
                        if (recControl.FirstName.Text != "") {
                            rec.Parse(recControl.FirstName.Text, View_AllDataExtractView.FirstName);
                  }
                
                        if (recControl.FT1_1.Text != "") {
                            rec.Parse(recControl.FT1_1.Text, View_AllDataExtractView.FT1_1);
                  }
                
                        if (recControl.FT1_2.Text != "") {
                            rec.Parse(recControl.FT1_2.Text, View_AllDataExtractView.FT1_2);
                  }
                
                        if (recControl.FT1_3.Text != "") {
                            rec.Parse(recControl.FT1_3.Text, View_AllDataExtractView.FT1_3);
                  }
                
                        if (recControl.FT2_1.Text != "") {
                            rec.Parse(recControl.FT2_1.Text, View_AllDataExtractView.FT2_1);
                  }
                
                        if (recControl.FT2_2.Text != "") {
                            rec.Parse(recControl.FT2_2.Text, View_AllDataExtractView.FT2_2);
                  }
                
                        if (recControl.FT2_3.Text != "") {
                            rec.Parse(recControl.FT2_3.Text, View_AllDataExtractView.FT2_3);
                  }
                
                        if (recControl.FTA1.Text != "") {
                            rec.Parse(recControl.FTA1.Text, View_AllDataExtractView.FTA1);
                  }
                
                        if (recControl.FTA2.Text != "") {
                            rec.Parse(recControl.FTA2.Text, View_AllDataExtractView.FTA2);
                  }
                
                        if (recControl.InitialCreationDate.Text != "") {
                            rec.Parse(recControl.InitialCreationDate.Text, View_AllDataExtractView.InitialCreationDate);
                  }
                
                        if (recControl.LastName.Text != "") {
                            rec.Parse(recControl.LastName.Text, View_AllDataExtractView.LastName);
                  }
                
                        if (recControl.MobileNumber.Text != "") {
                            rec.Parse(recControl.MobileNumber.Text, View_AllDataExtractView.MobileNumber);
                  }
                
                        if (recControl.PSNZAppliedFor.Text != "") {
                            rec.Parse(recControl.PSNZAppliedFor.Text, View_AllDataExtractView.PSNZAppliedFor);
                  }
                
                        if (recControl.PSNZMember.Text != "") {
                            rec.Parse(recControl.PSNZMember.Text, View_AllDataExtractView.PSNZMember);
                  }
                
                        if (recControl.PSNZMembershipCheck.Text != "") {
                            rec.Parse(recControl.PSNZMembershipCheck.Text, View_AllDataExtractView.PSNZMembershipCheck);
                  }
                
                        if (recControl.RegistrationId.Text != "") {
                            rec.Parse(recControl.RegistrationId.Text, View_AllDataExtractView.RegistrationId);
                  }
                
                        if (recControl.RegistrationType.Text != "") {
                            rec.Parse(recControl.RegistrationType.Text, View_AllDataExtractView.RegistrationType);
                  }
                
                        if (recControl.SpecialRequirements.Text != "") {
                            rec.Parse(recControl.SpecialRequirements.Text, View_AllDataExtractView.SpecialRequirements);
                  }
                
                        if (recControl.TownName.Text != "") {
                            rec.Parse(recControl.TownName.Text, View_AllDataExtractView.TownName);
                  }
                
                        if (recControl.WorkshopDescription.Text != "") {
                            rec.Parse(recControl.WorkshopDescription.Text, View_AllDataExtractView.WorkshopDescription);
                  }
                
                        if (recControl.WorkshopDescription2.Text != "") {
                            rec.Parse(recControl.WorkshopDescription2.Text, View_AllDataExtractView.WorkshopDescription2);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new View_AllDataExtractRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.View_AllDataExtractRecord);
                this.DataSource = (View_AllDataExtractRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(View_AllDataExtractTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(View_AllDataExtractTableControlRow rec)            
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
        
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
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
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration {Txt:Ascending}"), "RegistrationId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Registration {Txt:Descending}"), "RegistrationId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Attending 2 {Txt:Ascending}"), "Attending2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Attending 2 {Txt:Descending}"), "Attending2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Attending {Txt:Ascending}"), "Attending Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Attending {Txt:Descending}"), "Attending Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Workshop Description 2 {Txt:Ascending}"), "WorkshopDescription2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Workshop Description 2 {Txt:Descending}"), "WorkshopDescription2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Workshop Description {Txt:Ascending}"), "WorkshopDescription Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Workshop Description {Txt:Descending}"), "WorkshopDescription Desc"));
              
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

            string orderByStr = (string)ViewState["View_AllDataExtractTableControl_OrderBy"];
          
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
                this.ViewState["View_AllDataExtractTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=View_AllDataExtract" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
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


              this.TotalRecords = View_AllDataExtractView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             View_AllDataExtractView.ContactId,
             View_AllDataExtractView.Address1,
             View_AllDataExtractView.Address2,
             View_AllDataExtractView.Address3,
             View_AllDataExtractView.MobileNumber,
             View_AllDataExtractView.PSNZMembershipCheck,
             View_AllDataExtractView.PSNZMember,
             View_AllDataExtractView.Email,
             View_AllDataExtractView.PSNZAppliedFor,
             View_AllDataExtractView.FirstName,
             View_AllDataExtractView.LastName,
             View_AllDataExtractView.DatePaid,
             View_AllDataExtractView.InitialCreationDate,
             View_AllDataExtractView.AdditionalDinnerName,
             View_AllDataExtractView.SpecialRequirements,
             View_AllDataExtractView.AdditionalDinnerTicket,
             View_AllDataExtractView.TownName,
             View_AllDataExtractView.RegistrationType,
             View_AllDataExtractView.RegistrationId,
             View_AllDataExtractView.FT1_1,
             View_AllDataExtractView.FT1_2,
             View_AllDataExtractView.FT1_3,
             View_AllDataExtractView.Description1,
             View_AllDataExtractView.FT2_1,
             View_AllDataExtractView.FT2_2,
             View_AllDataExtractView.FT2_3,
             View_AllDataExtractView.Description2,
             View_AllDataExtractView.FTA2,
             View_AllDataExtractView.FTA1,
             View_AllDataExtractView.WorkshopDescription,
             View_AllDataExtractView.Attending,
             View_AllDataExtractView.WorkshopDescription2,
             View_AllDataExtractView.Attending2,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(View_AllDataExtractView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(View_AllDataExtractView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(View_AllDataExtractView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(View_AllDataExtractView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.ContactId, "0"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Address3, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.MobileNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.PSNZMembershipCheck, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.PSNZMember, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Email, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.PSNZAppliedFor, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FirstName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.LastName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.DatePaid, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.InitialCreationDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.AdditionalDinnerName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.SpecialRequirements, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.AdditionalDinnerTicket, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.TownName, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.RegistrationType, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.RegistrationId, "0"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT1_1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT1_2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT1_3, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Description1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT2_1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT2_2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FT2_3, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Description2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FTA2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.FTA1, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.WorkshopDescription, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Attending, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.WorkshopDescription2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_AllDataExtractView.Attending2, "Default"));


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
                val = View_AllDataExtractView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "View_AllDataExtractTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-AllDataExtract-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_AllDataExtract";
                // If Show-View-AllDataExtract-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_AllDataExtractView.ContactId.Name, ReportEnum.Align.Right, "${ContactId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_AllDataExtractView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.MobileNumber.Name, ReportEnum.Align.Left, "${MobileNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(View_AllDataExtractView.PSNZMembershipCheck.Name, ReportEnum.Align.Left, "${PSNZMembershipCheck}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.PSNZMember.Name, ReportEnum.Align.Left, "${PSNZMember}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.Email.Name, ReportEnum.Align.Left, "${Email}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.PSNZAppliedFor.Name, ReportEnum.Align.Left, "${PSNZAppliedFor}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.DatePaid.Name, ReportEnum.Align.Left, "${DatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_AllDataExtractView.InitialCreationDate.Name, ReportEnum.Align.Left, "${InitialCreationDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_AllDataExtractView.AdditionalDinnerName.Name, ReportEnum.Align.Left, "${AdditionalDinnerName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.SpecialRequirements.Name, ReportEnum.Align.Left, "${SpecialRequirements}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.AdditionalDinnerTicket.Name, ReportEnum.Align.Left, "${AdditionalDinnerTicket}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.TownName.Name, ReportEnum.Align.Left, "${TownName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.RegistrationType.Name, ReportEnum.Align.Left, "${RegistrationType}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.RegistrationId.Name, ReportEnum.Align.Right, "${RegistrationId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_AllDataExtractView.FT1_1.Name, ReportEnum.Align.Left, "${FT1_1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT1_2.Name, ReportEnum.Align.Left, "${FT1_2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT1_3.Name, ReportEnum.Align.Left, "${FT1_3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.Description1.Name, ReportEnum.Align.Left, "${Description1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.FT2_1.Name, ReportEnum.Align.Left, "${FT2_1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT2_2.Name, ReportEnum.Align.Left, "${FT2_2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT2_3.Name, ReportEnum.Align.Left, "${FT2_3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.Description2.Name, ReportEnum.Align.Left, "${Description2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.FTA2.Name, ReportEnum.Align.Left, "${FTA2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FTA1.Name, ReportEnum.Align.Left, "${FTA1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.WorkshopDescription.Name, ReportEnum.Align.Left, "${WorkshopDescription}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Attending.Name, ReportEnum.Align.Left, "${Attending}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.WorkshopDescription2.Name, ReportEnum.Align.Left, "${WorkshopDescription2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Attending2.Name, ReportEnum.Align.Left, "${Attending2}", ReportEnum.Align.Left, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = View_AllDataExtractView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = View_AllDataExtractView.GetRecordCount(joinFilter,whereClause);
                View_AllDataExtractRecord[] records = null;
                
                do
                {
                    
                    records = View_AllDataExtractView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_AllDataExtractRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${ContactId}", record.Format(View_AllDataExtractView.ContactId), ReportEnum.Align.Right, 300);
                             report.AddData("${Address1}", record.Format(View_AllDataExtractView.Address1), ReportEnum.Align.Left, 300);
                             report.AddData("${Address2}", record.Format(View_AllDataExtractView.Address2), ReportEnum.Align.Left, 300);
                             report.AddData("${Address3}", record.Format(View_AllDataExtractView.Address3), ReportEnum.Align.Left, 300);
                             report.AddData("${MobileNumber}", record.Format(View_AllDataExtractView.MobileNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMembershipCheck}", record.Format(View_AllDataExtractView.PSNZMembershipCheck), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMember}", record.Format(View_AllDataExtractView.PSNZMember), ReportEnum.Align.Left, 300);
                             report.AddData("${Email}", record.Format(View_AllDataExtractView.Email), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZAppliedFor}", record.Format(View_AllDataExtractView.PSNZAppliedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${FirstName}", record.Format(View_AllDataExtractView.FirstName), ReportEnum.Align.Left, 300);
                             report.AddData("${LastName}", record.Format(View_AllDataExtractView.LastName), ReportEnum.Align.Left, 300);
                             report.AddData("${DatePaid}", record.Format(View_AllDataExtractView.DatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${InitialCreationDate}", record.Format(View_AllDataExtractView.InitialCreationDate), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerName}", record.Format(View_AllDataExtractView.AdditionalDinnerName), ReportEnum.Align.Left, 300);
                             report.AddData("${SpecialRequirements}", record.Format(View_AllDataExtractView.SpecialRequirements), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerTicket}", record.Format(View_AllDataExtractView.AdditionalDinnerTicket), ReportEnum.Align.Left, 300);
                             report.AddData("${TownName}", record.Format(View_AllDataExtractView.TownName), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationType}", record.Format(View_AllDataExtractView.RegistrationType), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationId}", record.Format(View_AllDataExtractView.RegistrationId), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_1)){
                                 report.AddData("${FT1_1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_1.ToString(), View_AllDataExtractView.FT1_1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_1.IsApplyDisplayAs){
                                     report.AddData("${FT1_1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_1}", record.Format(View_AllDataExtractView.FT1_1), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_2)){
                                 report.AddData("${FT1_2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_2.ToString(), View_AllDataExtractView.FT1_2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_2.IsApplyDisplayAs){
                                     report.AddData("${FT1_2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_2}", record.Format(View_AllDataExtractView.FT1_2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_3)){
                                 report.AddData("${FT1_3}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_3);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_3.ToString(), View_AllDataExtractView.FT1_3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_3.IsApplyDisplayAs){
                                     report.AddData("${FT1_3}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_3}", record.Format(View_AllDataExtractView.FT1_3), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Description1}", record.Format(View_AllDataExtractView.Description1), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_1)){
                                 report.AddData("${FT2_1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_1.ToString(), View_AllDataExtractView.FT2_1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_1.IsApplyDisplayAs){
                                     report.AddData("${FT2_1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_1}", record.Format(View_AllDataExtractView.FT2_1), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_2)){
                                 report.AddData("${FT2_2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_2.ToString(), View_AllDataExtractView.FT2_2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_2.IsApplyDisplayAs){
                                     report.AddData("${FT2_2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_2}", record.Format(View_AllDataExtractView.FT2_2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_3)){
                                 report.AddData("${FT2_3}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_3);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_3.ToString(), View_AllDataExtractView.FT2_3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_3.IsApplyDisplayAs){
                                     report.AddData("${FT2_3}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_3}", record.Format(View_AllDataExtractView.FT2_3), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Description2}", record.Format(View_AllDataExtractView.Description2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FTA2)){
                                 report.AddData("${FTA2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FTA2.ToString(), View_AllDataExtractView.FTA2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FTA2.IsApplyDisplayAs){
                                     report.AddData("${FTA2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FTA2}", record.Format(View_AllDataExtractView.FTA2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FTA1)){
                                 report.AddData("${FTA1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FTA1.ToString(), View_AllDataExtractView.FTA1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FTA1.IsApplyDisplayAs){
                                     report.AddData("${FTA1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FTA1}", record.Format(View_AllDataExtractView.FTA1), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${WorkshopDescription}", record.Format(View_AllDataExtractView.WorkshopDescription), ReportEnum.Align.Left, 300);
                             report.AddData("${Attending}", record.Format(View_AllDataExtractView.Attending), ReportEnum.Align.Left, 300);
                             report.AddData("${WorkshopDescription2}", record.Format(View_AllDataExtractView.WorkshopDescription2), ReportEnum.Align.Left, 300);
                             report.AddData("${Attending2}", record.Format(View_AllDataExtractView.Attending2), ReportEnum.Align.Left, 300);

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

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-AllDataExtract-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_AllDataExtract";
                // If Show-View-AllDataExtract-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_AllDataExtractView.ContactId.Name, ReportEnum.Align.Right, "${ContactId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_AllDataExtractView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.MobileNumber.Name, ReportEnum.Align.Left, "${MobileNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(View_AllDataExtractView.PSNZMembershipCheck.Name, ReportEnum.Align.Left, "${PSNZMembershipCheck}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.PSNZMember.Name, ReportEnum.Align.Left, "${PSNZMember}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.Email.Name, ReportEnum.Align.Left, "${Email}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.PSNZAppliedFor.Name, ReportEnum.Align.Left, "${PSNZAppliedFor}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.DatePaid.Name, ReportEnum.Align.Left, "${DatePaid}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_AllDataExtractView.InitialCreationDate.Name, ReportEnum.Align.Left, "${InitialCreationDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(View_AllDataExtractView.AdditionalDinnerName.Name, ReportEnum.Align.Left, "${AdditionalDinnerName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.SpecialRequirements.Name, ReportEnum.Align.Left, "${SpecialRequirements}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.AdditionalDinnerTicket.Name, ReportEnum.Align.Left, "${AdditionalDinnerTicket}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.TownName.Name, ReportEnum.Align.Left, "${TownName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.RegistrationType.Name, ReportEnum.Align.Left, "${RegistrationType}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.RegistrationId.Name, ReportEnum.Align.Right, "${RegistrationId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_AllDataExtractView.FT1_1.Name, ReportEnum.Align.Left, "${FT1_1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT1_2.Name, ReportEnum.Align.Left, "${FT1_2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT1_3.Name, ReportEnum.Align.Left, "${FT1_3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.Description1.Name, ReportEnum.Align.Left, "${Description1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.FT2_1.Name, ReportEnum.Align.Left, "${FT2_1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT2_2.Name, ReportEnum.Align.Left, "${FT2_2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FT2_3.Name, ReportEnum.Align.Left, "${FT2_3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.Description2.Name, ReportEnum.Align.Left, "${Description2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.FTA2.Name, ReportEnum.Align.Left, "${FTA2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.FTA1.Name, ReportEnum.Align.Left, "${FTA1}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_AllDataExtractView.WorkshopDescription.Name, ReportEnum.Align.Left, "${WorkshopDescription}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Attending.Name, ReportEnum.Align.Left, "${Attending}", ReportEnum.Align.Left, 15);
                 report.AddColumn(View_AllDataExtractView.WorkshopDescription2.Name, ReportEnum.Align.Left, "${WorkshopDescription2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(View_AllDataExtractView.Attending2.Name, ReportEnum.Align.Left, "${Attending2}", ReportEnum.Align.Left, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = View_AllDataExtractView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = View_AllDataExtractView.GetColumnList();
                View_AllDataExtractRecord[] records = null;
                do
                {
                    records = View_AllDataExtractView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_AllDataExtractRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${ContactId}", record.Format(View_AllDataExtractView.ContactId), ReportEnum.Align.Right, 300);
                             report.AddData("${Address1}", record.Format(View_AllDataExtractView.Address1), ReportEnum.Align.Left, 300);
                             report.AddData("${Address2}", record.Format(View_AllDataExtractView.Address2), ReportEnum.Align.Left, 300);
                             report.AddData("${Address3}", record.Format(View_AllDataExtractView.Address3), ReportEnum.Align.Left, 300);
                             report.AddData("${MobileNumber}", record.Format(View_AllDataExtractView.MobileNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMembershipCheck}", record.Format(View_AllDataExtractView.PSNZMembershipCheck), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZMember}", record.Format(View_AllDataExtractView.PSNZMember), ReportEnum.Align.Left, 300);
                             report.AddData("${Email}", record.Format(View_AllDataExtractView.Email), ReportEnum.Align.Left, 300);
                             report.AddData("${PSNZAppliedFor}", record.Format(View_AllDataExtractView.PSNZAppliedFor), ReportEnum.Align.Left, 300);
                             report.AddData("${FirstName}", record.Format(View_AllDataExtractView.FirstName), ReportEnum.Align.Left, 300);
                             report.AddData("${LastName}", record.Format(View_AllDataExtractView.LastName), ReportEnum.Align.Left, 300);
                             report.AddData("${DatePaid}", record.Format(View_AllDataExtractView.DatePaid), ReportEnum.Align.Left, 300);
                             report.AddData("${InitialCreationDate}", record.Format(View_AllDataExtractView.InitialCreationDate), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerName}", record.Format(View_AllDataExtractView.AdditionalDinnerName), ReportEnum.Align.Left, 300);
                             report.AddData("${SpecialRequirements}", record.Format(View_AllDataExtractView.SpecialRequirements), ReportEnum.Align.Left, 300);
                             report.AddData("${AdditionalDinnerTicket}", record.Format(View_AllDataExtractView.AdditionalDinnerTicket), ReportEnum.Align.Left, 300);
                             report.AddData("${TownName}", record.Format(View_AllDataExtractView.TownName), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationType}", record.Format(View_AllDataExtractView.RegistrationType), ReportEnum.Align.Left, 300);
                             report.AddData("${RegistrationId}", record.Format(View_AllDataExtractView.RegistrationId), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_1)){
                                 report.AddData("${FT1_1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_1.ToString(), View_AllDataExtractView.FT1_1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_1.IsApplyDisplayAs){
                                     report.AddData("${FT1_1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_1}", record.Format(View_AllDataExtractView.FT1_1), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_2)){
                                 report.AddData("${FT1_2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_2.ToString(), View_AllDataExtractView.FT1_2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_2.IsApplyDisplayAs){
                                     report.AddData("${FT1_2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_2}", record.Format(View_AllDataExtractView.FT1_2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT1_3)){
                                 report.AddData("${FT1_3}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT1_3);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT1_3.ToString(), View_AllDataExtractView.FT1_3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT1_3.IsApplyDisplayAs){
                                     report.AddData("${FT1_3}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT1_3}", record.Format(View_AllDataExtractView.FT1_3), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Description1}", record.Format(View_AllDataExtractView.Description1), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_1)){
                                 report.AddData("${FT2_1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_1.ToString(), View_AllDataExtractView.FT2_1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_1.IsApplyDisplayAs){
                                     report.AddData("${FT2_1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_1}", record.Format(View_AllDataExtractView.FT2_1), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_2)){
                                 report.AddData("${FT2_2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_2.ToString(), View_AllDataExtractView.FT2_2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_2.IsApplyDisplayAs){
                                     report.AddData("${FT2_2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_2}", record.Format(View_AllDataExtractView.FT2_2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FT2_3)){
                                 report.AddData("${FT2_3}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FT2_3);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FT2_3.ToString(), View_AllDataExtractView.FT2_3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FT2_3.IsApplyDisplayAs){
                                     report.AddData("${FT2_3}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FT2_3}", record.Format(View_AllDataExtractView.FT2_3), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Description2}", record.Format(View_AllDataExtractView.Description2), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FTA2)){
                                 report.AddData("${FTA2}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA2);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FTA2.ToString(), View_AllDataExtractView.FTA2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FTA2.IsApplyDisplayAs){
                                     report.AddData("${FTA2}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FTA2}", record.Format(View_AllDataExtractView.FTA2), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FTA1)){
                                 report.AddData("${FTA1}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_AllDataExtractView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_AllDataExtractView.FTA1);
                                 _DFKA = View_AllDataExtractView.GetDFKA(record.FTA1.ToString(), View_AllDataExtractView.FTA1,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_AllDataExtractView.FTA1.IsApplyDisplayAs){
                                     report.AddData("${FTA1}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${FTA1}", record.Format(View_AllDataExtractView.FTA1), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${WorkshopDescription}", record.Format(View_AllDataExtractView.WorkshopDescription), ReportEnum.Align.Left, 300);
                             report.AddData("${Attending}", record.Format(View_AllDataExtractView.Attending), ReportEnum.Align.Left, 300);
                             report.AddData("${WorkshopDescription2}", record.Format(View_AllDataExtractView.WorkshopDescription2), ReportEnum.Align.Left, 300);
                             report.AddData("${Attending2}", record.Format(View_AllDataExtractView.Attending2), ReportEnum.Align.Left, 300);

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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in View_AllDataExtractView.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(View_AllDataExtractView.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (View_AllDataExtractView.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && View_AllDataExtractView.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(View_AllDataExtractView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(View_AllDataExtractView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = View_AllDataExtractView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  View_AllDataExtractRecord[] DataSource {
             
            get {
                return (View_AllDataExtractRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
        public OLR.UI.IPaginationModern Pagination {
            get {
                return (OLR.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
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
                View_AllDataExtractTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_AllDataExtractRecord rec = null;
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
                View_AllDataExtractTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_AllDataExtractRecord rec = null;
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
          
        public virtual View_AllDataExtractTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual View_AllDataExtractTableControlRow[] GetSelectedRecordControls()
        {
        
            return (View_AllDataExtractTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_AllDataExtract_Table.View_AllDataExtractTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            View_AllDataExtractTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (View_AllDataExtractTableControlRow recCtl in recordList)
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

        public virtual View_AllDataExtractTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "View_AllDataExtractTableControlRow");
	          List<View_AllDataExtractTableControlRow> list = new List<View_AllDataExtractTableControlRow>();
	          foreach (View_AllDataExtractTableControlRow recCtrl in recCtrls) {
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

  