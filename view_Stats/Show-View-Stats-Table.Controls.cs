
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_View_Stats_Table.aspx page.  The Row or RecordControl classes are the 
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


namespace OLR.UI.Controls.Show_View_Stats_Table
{


    #region "Section 1: Place your customizations here."


    public class View_StatsTableControlRow : BaseView_StatsTableControlRow
    {

        // The BaseView_StatsTableControlRow implements code for a ROW within the
        // the View_StatsTableControl table.  The BaseView_StatsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of View_StatsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        public override void DataBind()
        {
            base.DataBind();

            //   this.FieldTripChoicesCountControl.Text = EvaluateFormula("LOOKUP(FieldTripChoicesCountQuery2, FieldTripId)");
            WhereClause wc = new WhereClause();

            if (this.ftO1Key.Text != "&nbsp;")
            {
                wc.iAND(FieldTripChoicesTable.FieldTripId, BaseFilter.ComparisonOperator.EqualsTo, this.ftKey.Text);
                wc.iAND(FieldTripChoicesTable.FieldTripAllocated, BaseFilter.ComparisonOperator.EqualsTo, this.ftO1Key.Text);

                this.FieldTripChoicesCountControl.Text = FieldTripChoicesTable.GetRecordCount(wc).ToString();
            }
            else { this.FieldTripChoicesCountControl.Text = "0"; }

            if (this.ftO2Key.Text != "&nbsp;")
            {
                wc = new WhereClause();

                wc.iAND(FieldTripChoicesTable.FieldTripId, BaseFilter.ComparisonOperator.EqualsTo, this.ftKey.Text);
                wc.iAND(FieldTripChoicesTable.FieldTripAllocated, BaseFilter.ComparisonOperator.EqualsTo, this.ftO2Key.Text);
                this.FieldTripChoicesCountControl1.Text = FieldTripChoicesTable.GetRecordCount(wc).ToString();
            }
            else { this.FieldTripChoicesCountControl1.Text = "0"; }

            if (this.ftO3Key.Text != "&nbsp;")
            {
                wc = new WhereClause();
                wc.iAND(FieldTripChoicesTable.FieldTripId, BaseFilter.ComparisonOperator.EqualsTo, this.ftKey.Text);
                wc.iAND(FieldTripChoicesTable.FieldTripAllocated, BaseFilter.ComparisonOperator.EqualsTo, this.ftO3Key.Text);
                this.FieldTripChoicesCountControl2.Text = FieldTripChoicesTable.GetRecordCount(wc).ToString();
            }
            else { this.FieldTripChoicesCountControl2.Text = "0"; }
        }

    }



    public class View_StatsTableControl : BaseView_StatsTableControl
    {
        // The BaseView_StatsTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The View_StatsTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    }



    public class RegistrationsTableControl : BaseRegistrationsTableControl
{
    // The BaseRegistrationsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The RegistrationsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class RegistrationsTableControlRow : BaseRegistrationsTableControlRow
{
      
        // The BaseRegistrationsTableControlRow implements code for a ROW within the
        // the RegistrationsTableControl table.  The BaseRegistrationsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of RegistrationsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion



    #region "Section 2: Do not modify this section."
    
    
// Base class for the RegistrationsTableControlRow control on the Show_View_Stats_Table page.
// Do not modify this class. Instead override any method in RegistrationsTableControlRow.
public class BaseRegistrationsTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseRegistrationsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in RegistrationsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in RegistrationsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton1.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OLR") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton1.Click += DeleteRowButton1_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
                    this.ContactId.Click += ContactId_Click;
                        
                    this.EventId.Click += EventId_Click;
                        
                    this.RegistrationTypeId.Click += RegistrationTypeId_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.Registrations record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = RegistrationsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRegistrationsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new RegistrationsRecord();
            
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
                SetContactId();
                SetContactIdLabel();
                SetDatePaid();
                SetDatePaidLabel();
                
                
                SetEventId();
                SetEventIdLabel();
                SetInitialCreationDate();
                SetInitialCreationDateLabel();
                SetRecordDeleted();
                SetRecordDeletedLabel();
                SetRegistrationTypeId();
                SetRegistrationTypeIdLabel();
                SetSpecialRequirements();
                SetSpecialRequirementsLabel();
                SetDeleteRowButton1();
              
                SetEditRowButton1();
              

      

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
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.AdditionalDinnerName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerNameSpecified) {
                								
                // If the AdditionalDinnerName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.AdditionalDinnerName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerName.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerName.Text = RegistrationsTable.AdditionalDinnerName.Format(RegistrationsTable.AdditionalDinnerName.DefaultValue);
            		
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
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.AdditionalDinnerTicket is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdditionalDinnerTicketSpecified) {
                								
                // If the AdditionalDinnerTicket is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.AdditionalDinnerTicket);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AdditionalDinnerTicket.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdditionalDinnerTicket is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdditionalDinnerTicket.Text = RegistrationsTable.AdditionalDinnerTicket.Format(RegistrationsTable.AdditionalDinnerTicket.DefaultValue);
            		
            }
            
            // If the AdditionalDinnerTicket is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AdditionalDinnerTicket.Text == null ||
                this.AdditionalDinnerTicket.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AdditionalDinnerTicket.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetContactId()
        {
            
                    
            // Set the ContactId LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.ContactId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactIdSpecified) {
                								
                // If the ContactId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RegistrationsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RegistrationsTable.ContactId);
               if(_isExpandableNonCompositeForeignKey &&RegistrationsTable.ContactId.IsApplyDisplayAs)
                                  
                     formattedValue = RegistrationsTable.GetDFKA(this.DataSource.ContactId.ToString(),RegistrationsTable.ContactId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RegistrationsTable.ContactId);
                                  
                                
                this.ContactId.Text = formattedValue;
                
                  this.ContactId.ToolTip = "Go to " + this.ContactId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ContactId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactId.Text = RegistrationsTable.ContactId.Format(RegistrationsTable.ContactId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetDatePaid()
        {
            
                    
            // Set the DatePaid Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.DatePaid is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DatePaidSpecified) {
                								
                // If the DatePaid is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.DatePaid, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.DatePaid.Text = formattedValue;
                   
            } 
            
            else {
            
                // DatePaid is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DatePaid.Text = RegistrationsTable.DatePaid.Format(RegistrationsTable.DatePaid.DefaultValue, @"d");
            		
            }
            
            // If the DatePaid is NULL or blank, then use the value specified  
            // on Properties.
            if (this.DatePaid.Text == null ||
                this.DatePaid.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.DatePaid.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEventId()
        {
            
                    
            // Set the EventId LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.EventId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EventIdSpecified) {
                								
                // If the EventId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RegistrationsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RegistrationsTable.EventId);
               if(_isExpandableNonCompositeForeignKey &&RegistrationsTable.EventId.IsApplyDisplayAs)
                                  
                     formattedValue = RegistrationsTable.GetDFKA(this.DataSource.EventId.ToString(),RegistrationsTable.EventId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RegistrationsTable.EventId);
                                  
                                
                this.EventId.Text = formattedValue;
                
                  this.EventId.ToolTip = "Go to " + this.EventId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // EventId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EventId.Text = RegistrationsTable.EventId.Format(RegistrationsTable.EventId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetInitialCreationDate()
        {
            
                    
            // Set the InitialCreationDate Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.InitialCreationDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InitialCreationDateSpecified) {
                								
                // If the InitialCreationDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.InitialCreationDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InitialCreationDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InitialCreationDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InitialCreationDate.Text = RegistrationsTable.InitialCreationDate.Format(RegistrationsTable.InitialCreationDate.DefaultValue, @"d");
            		
            }
            
            // If the InitialCreationDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InitialCreationDate.Text == null ||
                this.InitialCreationDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InitialCreationDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRecordDeleted()
        {
            
                    
            // Set the RecordDeleted Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.RecordDeleted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RecordDeletedSpecified) {
                								
                // If the RecordDeleted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.RecordDeleted);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RecordDeleted.Text = formattedValue;
                   
            } 
            
            else {
            
                // RecordDeleted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RecordDeleted.Text = RegistrationsTable.RecordDeleted.Format(RegistrationsTable.RecordDeleted.DefaultValue);
            		
            }
            
            // If the RecordDeleted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RecordDeleted.Text == null ||
                this.RecordDeleted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RecordDeleted.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegistrationTypeId()
        {
            
                    
            // Set the RegistrationTypeId LinkButton on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.RegistrationTypeId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegistrationTypeIdSpecified) {
                								
                // If the RegistrationTypeId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = RegistrationsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RegistrationsTable.RegistrationTypeId);
               if(_isExpandableNonCompositeForeignKey &&RegistrationsTable.RegistrationTypeId.IsApplyDisplayAs)
                                  
                     formattedValue = RegistrationsTable.GetDFKA(this.DataSource.RegistrationTypeId.ToString(),RegistrationsTable.RegistrationTypeId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(RegistrationsTable.RegistrationTypeId);
                                  
                                
                this.RegistrationTypeId.Text = formattedValue;
                
                  this.RegistrationTypeId.ToolTip = "Go to " + this.RegistrationTypeId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // RegistrationTypeId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegistrationTypeId.Text = RegistrationsTable.RegistrationTypeId.Format(RegistrationsTable.RegistrationTypeId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetSpecialRequirements()
        {
            
                    
            // Set the SpecialRequirements Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.Registrations database record.

            // this.DataSource is the DatabaseOLR_db%dbo.Registrations record retrieved from the database.
            // this.SpecialRequirements is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SpecialRequirementsSpecified) {
                								
                // If the SpecialRequirements is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RegistrationsTable.SpecialRequirements);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SpecialRequirements.Text = formattedValue;
                   
            } 
            
            else {
            
                // SpecialRequirements is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SpecialRequirements.Text = RegistrationsTable.SpecialRequirements.Format(RegistrationsTable.SpecialRequirements.DefaultValue);
            		
            }
            
            // If the SpecialRequirements is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SpecialRequirements.Text == null ||
                this.SpecialRequirements.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SpecialRequirements.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAdditionalDinnerNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetAdditionalDinnerTicketLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetDatePaidLabel()
                  {
                  
                    
        }
                
        public virtual void SetEventIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetInitialCreationDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetRecordDeletedLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegistrationTypeIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSpecialRequirementsLabel()
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
                
                // add datasource as variables for formula evaluation
                  RegistrationsTableControl panel;
                panel = (RegistrationsTableControl)(this.GetParentTableControl());
                  
                e.Variables.Add("RegistrationsCountQuery", panel.RegistrationsCountQuery);                                                       
                        
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
                ((RegistrationsTableControl)MiscUtils.GetParentControlObject(this, "RegistrationsTableControl")).DataChanged = true;
                ((RegistrationsTableControl)MiscUtils.GetParentControlObject(this, "RegistrationsTableControl")).ResetData = true;
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
            GetContactId();
            GetDatePaid();
            GetEventId();
            GetInitialCreationDate();
            GetRecordDeleted();
            GetRegistrationTypeId();
            GetSpecialRequirements();
        }
        
        
        public virtual void GetAdditionalDinnerName()
        {
            
        }
                
        public virtual void GetAdditionalDinnerTicket()
        {
            
        }
                
        public virtual void GetContactId()
        {
            
        }
                
        public virtual void GetDatePaid()
        {
            
        }
                
        public virtual void GetEventId()
        {
            
        }
                
        public virtual void GetInitialCreationDate()
        {
            
        }
                
        public virtual void GetRecordDeleted()
        {
            
        }
                
        public virtual void GetRegistrationTypeId()
        {
            
        }
                
        public virtual void GetSpecialRequirements()
        {
            
        }
                

      // To customize, override this method in RegistrationsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRegistrationsTableControl = false;
            hasFiltersRegistrationsTableControl = hasFiltersRegistrationsTableControl && false; // suppress warning
      
            bool hasFiltersView_StatsTableControl = false;
            hasFiltersView_StatsTableControl = hasFiltersView_StatsTableControl && false; // suppress warning
      
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
          RegistrationsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((RegistrationsTableControl)MiscUtils.GetParentControlObject(this, "RegistrationsTableControl")).DataChanged = true;
            ((RegistrationsTableControl)MiscUtils.GetParentControlObject(this, "RegistrationsTableControl")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton1()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton1_Click(object sender, ImageClickEventArgs args)
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
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for LinkButton
        public virtual void ContactId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Contacts/Show-Contacts.aspx?Contacts={RegistrationsTableControlRow:FK:FK_Registrations_Contacts}";
            
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
        public virtual void EventId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Events/Show-Events.aspx?Events={RegistrationsTableControlRow:FK:FK_Registrations_Events}";
            
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
        public virtual void RegistrationTypeId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RegistrationTypes/Show-RegistrationTypes.aspx?RegistrationTypes={RegistrationsTableControlRow:FK:FK_Registrations_RegistrationTypes}";
            
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
                return (string)this.ViewState["BaseRegistrationsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRegistrationsTableControlRow_Rec"] = value;
            }
        }
        
        public RegistrationsRecord DataSource {
            get {
                return (RegistrationsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton ContactId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactId");
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton EventId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EventId");
            }
        }
            
        public System.Web.UI.WebControls.Literal EventIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EventIdLabel");
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
        
        public System.Web.UI.WebControls.Literal RecordDeleted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RecordDeleted");
            }
        }
            
        public System.Web.UI.WebControls.Literal RecordDeletedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RecordDeletedLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RegistrationTypeId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationTypeId");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegistrationTypeIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationTypeIdLabel");
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
        RegistrationsRecord rec = null;
             
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
    RegistrationsRecord rec = null;
    
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

        
        public virtual RegistrationsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return RegistrationsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the RegistrationsTableControl control on the Show_View_Stats_Table page.
// Do not modify this class. Instead override any method in RegistrationsTableControl.
public class BaseRegistrationsTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseRegistrationsTableControl()
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
                      Type myrec = typeof(OLR.Business.RegistrationsRecord);
                      this.DataSource = (RegistrationsRecord[])(alist.ToArray(myrec));
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
                    foreach (RegistrationsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.RegistrationsRecord);
                    this.DataSource = (RegistrationsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual RegistrationsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(RegistrationsTable.Column1, true);          
            // selCols.Add(RegistrationsTable.Column2, true);          
            // selCols.Add(RegistrationsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return RegistrationsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                RegistrationsTable databaseTable = new RegistrationsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(RegistrationsRecord)) as RegistrationsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(RegistrationsTable.Column1, true);          
            // selCols.Add(RegistrationsTable.Column2, true);          
            // selCols.Add(RegistrationsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return RegistrationsTable.GetRecordCount(join, where);
            else
            {
                RegistrationsTable databaseTable = new RegistrationsTable();
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
          
                  LoadData_RegistrationsCountQuery();
       
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            RegistrationsTableControlRow recControl = (RegistrationsTableControlRow)(repItem.FindControl("RegistrationsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetLabel4();
                SetRegistrationsCountControl();
                
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
          
            this.Page.PregetDfkaRecords(RegistrationsTable.ContactId, this.DataSource);
            this.Page.PregetDfkaRecords(RegistrationsTable.EventId, this.DataSource);
            this.Page.PregetDfkaRecords(RegistrationsTable.RegistrationTypeId, this.DataSource);
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
                
                // add datasource as variables for formula evaluation
                    
                if (RegistrationsCountQuery != null) e.Variables.Add("RegistrationsCountQuery", RegistrationsCountQuery);                                                       
                    
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
        
    
            // Bind the buttons for RegistrationsTableControl pagination.
            
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (RegistrationsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (RegistrationsTableControlRow recCtl in this.GetRecordControls()){
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
            RegistrationsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
             
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            RegistrationsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RegistrationsTableControlRow recControl = (RegistrationsTableControlRow)(repItem.FindControl("RegistrationsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RegistrationsRecord rec = new RegistrationsRecord();
        
                        if (recControl.AdditionalDinnerName.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerName.Text, RegistrationsTable.AdditionalDinnerName);
                  }
                
                        if (recControl.AdditionalDinnerTicket.Text != "") {
                            rec.Parse(recControl.AdditionalDinnerTicket.Text, RegistrationsTable.AdditionalDinnerTicket);
                  }
                
                        if (recControl.ContactId.Text != "") {
                            rec.Parse(recControl.ContactId.Text, RegistrationsTable.ContactId);
                  }
                
                        if (recControl.DatePaid.Text != "") {
                            rec.Parse(recControl.DatePaid.Text, RegistrationsTable.DatePaid);
                  }
                
                        if (recControl.EventId.Text != "") {
                            rec.Parse(recControl.EventId.Text, RegistrationsTable.EventId);
                  }
                
                        if (recControl.InitialCreationDate.Text != "") {
                            rec.Parse(recControl.InitialCreationDate.Text, RegistrationsTable.InitialCreationDate);
                  }
                
                        if (recControl.RecordDeleted.Text != "") {
                            rec.Parse(recControl.RecordDeleted.Text, RegistrationsTable.RecordDeleted);
                  }
                
                        if (recControl.RegistrationTypeId.Text != "") {
                            rec.Parse(recControl.RegistrationTypeId.Text, RegistrationsTable.RegistrationTypeId);
                  }
                
                        if (recControl.SpecialRequirements.Text != "") {
                            rec.Parse(recControl.SpecialRequirements.Text, RegistrationsTable.SpecialRequirements);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new RegistrationsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.RegistrationsRecord);
                this.DataSource = (RegistrationsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(RegistrationsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(RegistrationsTableControlRow rec)            
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
        
        public virtual void SetLabel4()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label4.Text = "Some value";
                    
                    
        }
                
        public virtual void SetRegistrationsCountControl()
                  {
                  
                        this.RegistrationsCountControl.Text = EvaluateFormula("LOOKUP(RegistrationsCountQuery, \"\")");
                    
                    
        }
                
        public virtual WhereClause CreateWhereClause_RegistrationsCountQuery()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual void LoadData_RegistrationsCountQuery()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _RegistrationsCountQuery.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _RegistrationsCountQuery.DataChanged = true;
          
              this._RegistrationsCountQuery.Initialize("RegistrationsCountQuery", RegistrationsTable.Instance, 0, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_RegistrationsCountQuery();
              this._RegistrationsCountQuery.WhereClause.iAND(wc);                      
          
              // Define selects
          
                    this._RegistrationsCountQuery.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, RegistrationsTable.Instance, "RegistrationsCount", ""), "RegistrationsCount"));
              
              // Define joins if there are any
          
              this._RegistrationsCountQuery.LoadData(false, this._RegistrationsCountQuery.PageSize, this._RegistrationsCountQuery.PageIndex);                       
                        
        }
      
        private DataSource _RegistrationsCountQuery = new DataSource();
        public DataSource RegistrationsCountQuery
        {
            get
            {
                return _RegistrationsCountQuery;
             }
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

            string orderByStr = (string)ViewState["RegistrationsTableControl_OrderBy"];
          
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
                this.ViewState["RegistrationsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
                    _TotalRecords = RegistrationsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  RegistrationsRecord[] DataSource {
             
            get {
                return (RegistrationsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Label Label4 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label4");
            }
        }
        
        public System.Web.UI.WebControls.Literal RegistrationsCountControl {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegistrationsCountControl");
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
                RegistrationsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        RegistrationsRecord rec = null;
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
                RegistrationsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        RegistrationsRecord rec = null;
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
          
        public virtual RegistrationsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual RegistrationsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (RegistrationsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_Stats_Table.RegistrationsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            RegistrationsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (RegistrationsTableControlRow recCtl in recordList)
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

        public virtual RegistrationsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "RegistrationsTableControlRow");
	          List<RegistrationsTableControlRow> list = new List<RegistrationsTableControlRow>();
	          foreach (RegistrationsTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the View_StatsTableControlRow control on the Show_View_Stats_Table page.
// Do not modify this class. Instead override any method in View_StatsTableControlRow.
public class BaseView_StatsTableControlRow : OLR.UI.BaseApplicationRecordControl
{
        public BaseView_StatsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in View_StatsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in View_StatsTableControlRow.
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
            // Load the data from the database into the DataSource DatabaseOLR_db%dbo.view_Stats record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = View_StatsView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseView_StatsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new View_StatsRecord();
            
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
        
                
                
                SetFieldTripChoicesCountControl();
                SetFieldTripChoicesCountControl1();
                SetFieldTripChoicesCountControl2();
                SetFieldTripId();
                SetFieldTripOptionId();
                SetFieldTripOptionId2();
                SetFieldTripOptionId3();
                SetftKey();
                SetftO1Key();
                SetftO2Key();
                SetftO3Key();
                SetLabel();
                SetLabel1();
                SetLabel2();
                SetLabel3();
                SetPlacesAvailable();
                SetPlacesAvailable2();
                SetPlacesAvailable3();
                SetSUM1();
                SetSUM2();
                SetSUM3();
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
            
        }
        
        
        public virtual void SetFieldTripId()
        {
            
                    
            // Set the FieldTripId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.FieldTripId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripIdSpecified) {
                								
                // If the FieldTripId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripId);
               if(_isExpandableNonCompositeForeignKey &&View_StatsView.FieldTripId.IsApplyDisplayAs)
                                  
                     formattedValue = View_StatsView.GetDFKA(this.DataSource.FieldTripId.ToString(),View_StatsView.FieldTripId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_StatsView.FieldTripId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripId.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripId.Text = View_StatsView.FieldTripId.Format(View_StatsView.FieldTripId.DefaultValue);
            		
            }
            
            // If the FieldTripId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FieldTripId.Text == null ||
                this.FieldTripId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FieldTripId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFieldTripOptionId()
        {
            
                    
            // Set the FieldTripOptionId Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.FieldTripOptionId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionIdSpecified) {
                								
                // If the FieldTripOptionId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId);
               if(_isExpandableNonCompositeForeignKey &&View_StatsView.FieldTripOptionId.IsApplyDisplayAs)
                                  
                     formattedValue = View_StatsView.GetDFKA(this.DataSource.FieldTripOptionId.ToString(),View_StatsView.FieldTripOptionId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_StatsView.FieldTripOptionId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripOptionId.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripOptionId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId.Text = View_StatsView.FieldTripOptionId.Format(View_StatsView.FieldTripOptionId.DefaultValue);
            		
            }
            
            // If the FieldTripOptionId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FieldTripOptionId.Text == null ||
                this.FieldTripOptionId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FieldTripOptionId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFieldTripOptionId2()
        {
            
                    
            // Set the FieldTripOptionId2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.FieldTripOptionId2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionId2Specified) {
                								
                // If the FieldTripOptionId2 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId2);
               if(_isExpandableNonCompositeForeignKey &&View_StatsView.FieldTripOptionId2.IsApplyDisplayAs)
                                  
                     formattedValue = View_StatsView.GetDFKA(this.DataSource.FieldTripOptionId2.ToString(),View_StatsView.FieldTripOptionId2, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_StatsView.FieldTripOptionId2);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripOptionId2.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripOptionId2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId2.Text = View_StatsView.FieldTripOptionId2.Format(View_StatsView.FieldTripOptionId2.DefaultValue);
            		
            }
            
            // If the FieldTripOptionId2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FieldTripOptionId2.Text == null ||
                this.FieldTripOptionId2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FieldTripOptionId2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFieldTripOptionId3()
        {
            
                    
            // Set the FieldTripOptionId3 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.FieldTripOptionId3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FieldTripOptionId3Specified) {
                								
                // If the FieldTripOptionId3 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId3);
               if(_isExpandableNonCompositeForeignKey &&View_StatsView.FieldTripOptionId3.IsApplyDisplayAs)
                                  
                     formattedValue = View_StatsView.GetDFKA(this.DataSource.FieldTripOptionId3.ToString(),View_StatsView.FieldTripOptionId3, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(View_StatsView.FieldTripOptionId3);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FieldTripOptionId3.Text = formattedValue;
                   
            } 
            
            else {
            
                // FieldTripOptionId3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FieldTripOptionId3.Text = View_StatsView.FieldTripOptionId3.Format(View_StatsView.FieldTripOptionId3.DefaultValue);
            		
            }
            
            // If the FieldTripOptionId3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FieldTripOptionId3.Text == null ||
                this.FieldTripOptionId3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FieldTripOptionId3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetftKey()
        {
            
                    
            // Set the ftKey Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.ftKey is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ftKeySpecified) {
                								
                // If the ftKey is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.ftKey);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ftKey.Text = formattedValue;
                   
            } 
            
            else {
            
                // ftKey is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ftKey.Text = View_StatsView.ftKey.Format(View_StatsView.ftKey.DefaultValue);
            		
            }
            
            // If the ftKey is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ftKey.Text == null ||
                this.ftKey.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ftKey.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetftO1Key()
        {
            
                    
            // Set the ftO1Key Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.ftO1Key is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ftO1KeySpecified) {
                								
                // If the ftO1Key is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.ftO1Key);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ftO1Key.Text = formattedValue;
                   
            } 
            
            else {
            
                // ftO1Key is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ftO1Key.Text = View_StatsView.ftO1Key.Format(View_StatsView.ftO1Key.DefaultValue);
            		
            }
            
            // If the ftO1Key is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ftO1Key.Text == null ||
                this.ftO1Key.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ftO1Key.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetftO2Key()
        {
            
                    
            // Set the ftO2Key Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.ftO2Key is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ftO2KeySpecified) {
                								
                // If the ftO2Key is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.ftO2Key);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ftO2Key.Text = formattedValue;
                   
            } 
            
            else {
            
                // ftO2Key is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ftO2Key.Text = View_StatsView.ftO2Key.Format(View_StatsView.ftO2Key.DefaultValue);
            		
            }
            
            // If the ftO2Key is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ftO2Key.Text == null ||
                this.ftO2Key.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ftO2Key.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetftO3Key()
        {
            
                    
            // Set the ftO3Key Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.ftO3Key is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ftO3KeySpecified) {
                								
                // If the ftO3Key is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.ftO3Key);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ftO3Key.Text = formattedValue;
                   
            } 
            
            else {
            
                // ftO3Key is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ftO3Key.Text = View_StatsView.ftO3Key.Format(View_StatsView.ftO3Key.DefaultValue);
            		
            }
            
            // If the ftO3Key is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ftO3Key.Text == null ||
                this.ftO3Key.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ftO3Key.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPlacesAvailable()
        {
            
                    
            // Set the PlacesAvailable Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.PlacesAvailable is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PlacesAvailableSpecified) {
                								
                // If the PlacesAvailable is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.PlacesAvailable);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PlacesAvailable.Text = formattedValue;
                   
            } 
            
            else {
            
                // PlacesAvailable is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PlacesAvailable.Text = View_StatsView.PlacesAvailable.Format(View_StatsView.PlacesAvailable.DefaultValue);
            		
            }
            
            // If the PlacesAvailable is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PlacesAvailable.Text == null ||
                this.PlacesAvailable.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PlacesAvailable.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPlacesAvailable2()
        {
            
                    
            // Set the PlacesAvailable2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.PlacesAvailable2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PlacesAvailable2Specified) {
                								
                // If the PlacesAvailable2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.PlacesAvailable2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PlacesAvailable2.Text = formattedValue;
                   
            } 
            
            else {
            
                // PlacesAvailable2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PlacesAvailable2.Text = View_StatsView.PlacesAvailable2.Format(View_StatsView.PlacesAvailable2.DefaultValue);
            		
            }
            
            // If the PlacesAvailable2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PlacesAvailable2.Text == null ||
                this.PlacesAvailable2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PlacesAvailable2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPlacesAvailable3()
        {
            
                    
            // Set the PlacesAvailable3 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.PlacesAvailable3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PlacesAvailable3Specified) {
                								
                // If the PlacesAvailable3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.PlacesAvailable3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PlacesAvailable3.Text = formattedValue;
                   
            } 
            
            else {
            
                // PlacesAvailable3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PlacesAvailable3.Text = View_StatsView.PlacesAvailable3.Format(View_StatsView.PlacesAvailable3.DefaultValue);
            		
            }
            
            // If the PlacesAvailable3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PlacesAvailable3.Text == null ||
                this.PlacesAvailable3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PlacesAvailable3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSUM1()
        {
            
                    
            // Set the SUM1 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.SUM1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SUM1Specified) {
                								
                // If the SUM1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.SUM1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SUM1.Text = formattedValue;
                   
            } 
            
            else {
            
                // SUM1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SUM1.Text = View_StatsView.SUM1.Format(View_StatsView.SUM1.DefaultValue);
            		
            }
            
            // If the SUM1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SUM1.Text == null ||
                this.SUM1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SUM1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSUM2()
        {
            
                    
            // Set the SUM2 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.SUM2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SUM2Specified) {
                								
                // If the SUM2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.SUM2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SUM2.Text = formattedValue;
                   
            } 
            
            else {
            
                // SUM2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SUM2.Text = View_StatsView.SUM2.Format(View_StatsView.SUM2.DefaultValue);
            		
            }
            
            // If the SUM2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SUM2.Text == null ||
                this.SUM2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SUM2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSUM3()
        {
            
                    
            // Set the SUM3 Literal on the webpage with value from the
            // DatabaseOLR_db%dbo.view_Stats database record.

            // this.DataSource is the DatabaseOLR_db%dbo.view_Stats record retrieved from the database.
            // this.SUM3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SUM3Specified) {
                								
                // If the SUM3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(View_StatsView.SUM3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SUM3.Text = formattedValue;
                   
            } 
            
            else {
            
                // SUM3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SUM3.Text = View_StatsView.SUM3.Format(View_StatsView.SUM3.DefaultValue);
            		
            }
            
            // If the SUM3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SUM3.Text == null ||
                this.SUM3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SUM3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFieldTripChoicesCountControl()
                  {
                  
                        this.FieldTripChoicesCountControl.Text = EvaluateFormula("LOOKUP(FieldTripChoicesCountQuery2, FieldTripId)");
                    
                    
        }
                
        public virtual void SetFieldTripChoicesCountControl1()
                  {
                  
                        this.FieldTripChoicesCountControl1.Text = EvaluateFormula("LOOKUP(FieldTripChoicesCountQuery2, FieldTripId)");
                    
                    
        }
                
        public virtual void SetFieldTripChoicesCountControl2()
                  {
                  
                        this.FieldTripChoicesCountControl2.Text = EvaluateFormula("LOOKUP(FieldTripChoicesCountQuery2, FieldTripId)");
                    
                    
        }
                
        public virtual void SetLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label2.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLabel3()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label3.Text = "Some value";
                    
                    
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
                
                // add datasource as variables for formula evaluation
                  View_StatsTableControl panel;
                panel = (View_StatsTableControl)(this.GetParentTableControl());
                  
                e.Variables.Add("FieldTripChoicesCountQuery", panel.FieldTripChoicesCountQuery);                                                       
                        
                e.Variables.Add("FieldTripChoicesCountQuery1", panel.FieldTripChoicesCountQuery1);                                                       
                        
                e.Variables.Add("FieldTripChoicesCountQuery2", panel.FieldTripChoicesCountQuery2);                                                       
                        
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
                ((View_StatsTableControl)MiscUtils.GetParentControlObject(this, "View_StatsTableControl")).DataChanged = true;
                ((View_StatsTableControl)MiscUtils.GetParentControlObject(this, "View_StatsTableControl")).ResetData = true;
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
        
            GetFieldTripId();
            GetFieldTripOptionId();
            GetFieldTripOptionId2();
            GetFieldTripOptionId3();
            GetftKey();
            GetftO1Key();
            GetftO2Key();
            GetftO3Key();
            GetPlacesAvailable();
            GetPlacesAvailable2();
            GetPlacesAvailable3();
            GetSUM1();
            GetSUM2();
            GetSUM3();
        }
        
        
        public virtual void GetFieldTripId()
        {
            
        }
                
        public virtual void GetFieldTripOptionId()
        {
            
        }
                
        public virtual void GetFieldTripOptionId2()
        {
            
        }
                
        public virtual void GetFieldTripOptionId3()
        {
            
        }
                
        public virtual void GetftKey()
        {
            
        }
                
        public virtual void GetftO1Key()
        {
            
        }
                
        public virtual void GetftO2Key()
        {
            
        }
                
        public virtual void GetftO3Key()
        {
            
        }
                
        public virtual void GetPlacesAvailable()
        {
            
        }
                
        public virtual void GetPlacesAvailable2()
        {
            
        }
                
        public virtual void GetPlacesAvailable3()
        {
            
        }
                
        public virtual void GetSUM1()
        {
            
        }
                
        public virtual void GetSUM2()
        {
            
        }
                
        public virtual void GetSUM3()
        {
            
        }
                

      // To customize, override this method in View_StatsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRegistrationsTableControl = false;
            hasFiltersRegistrationsTableControl = hasFiltersRegistrationsTableControl && false; // suppress warning
      
            bool hasFiltersView_StatsTableControl = false;
            hasFiltersView_StatsTableControl = hasFiltersView_StatsTableControl && false; // suppress warning
      
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
          View_StatsView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((View_StatsTableControl)MiscUtils.GetParentControlObject(this, "View_StatsTableControl")).DataChanged = true;
            ((View_StatsTableControl)MiscUtils.GetParentControlObject(this, "View_StatsTableControl")).ResetData = true;
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
            
            string url = @"../FieldTrips/Edit-FieldTrips-Table.aspx";
            
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
                return (string)this.ViewState["BaseView_StatsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseView_StatsTableControlRow_Rec"] = value;
            }
        }
        
        public View_StatsRecord DataSource {
            get {
                return (View_StatsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal FieldTripChoicesCountControl {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesCountControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripChoicesCountControl1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesCountControl1");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripChoicesCountControl2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripChoicesCountControl2");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripId");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripOptionId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripOptionId2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId2");
            }
        }
            
        public System.Web.UI.WebControls.Literal FieldTripOptionId3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripOptionId3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ftKey {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ftKey");
            }
        }
            
        public System.Web.UI.WebControls.Literal ftO1Key {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ftO1Key");
            }
        }
            
        public System.Web.UI.WebControls.Literal ftO2Key {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ftO2Key");
            }
        }
            
        public System.Web.UI.WebControls.Literal ftO3Key {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ftO3Key");
            }
        }
            
        public System.Web.UI.WebControls.Label Label {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label");
            }
        }
        
        public System.Web.UI.WebControls.Label Label1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label1");
            }
        }
        
        public System.Web.UI.WebControls.Label Label2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label2");
            }
        }
        
        public System.Web.UI.WebControls.Label Label3 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label3");
            }
        }
        
        public System.Web.UI.WebControls.Literal PlacesAvailable {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PlacesAvailable");
            }
        }
            
        public System.Web.UI.WebControls.Literal PlacesAvailable2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PlacesAvailable2");
            }
        }
            
        public System.Web.UI.WebControls.Literal PlacesAvailable3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PlacesAvailable3");
            }
        }
            
        public System.Web.UI.WebControls.Literal SUM1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SUM1");
            }
        }
            
        public System.Web.UI.WebControls.Literal SUM2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SUM2");
            }
        }
            
        public System.Web.UI.WebControls.Literal SUM3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SUM3");
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
        View_StatsRecord rec = null;
             
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
    View_StatsRecord rec = null;
    
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

        
        public virtual View_StatsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return View_StatsView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the View_StatsTableControl control on the Show_View_Stats_Table page.
// Do not modify this class. Instead override any method in View_StatsTableControl.
public class BaseView_StatsTableControl : OLR.UI.BaseApplicationTableControl
{
         
       public BaseView_StatsTableControl()
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
                if  (this.InSession(this.FieldTripIdFromFilter)) 				
                    initialVal = this.GetFromSession(this.FieldTripIdFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"FieldTripIdFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.FieldTripIdFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.FieldTripIdToFilter)) 				
                    initialVal = this.GetFromSession(this.FieldTripIdToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"FieldTripIdTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.FieldTripIdToFilter.Text = initialVal;
                            
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
            

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OLR.Business.View_StatsRecord);
                      this.DataSource = (View_StatsRecord[])(alist.ToArray(myrec));
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
                    foreach (View_StatsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OLR.Business.View_StatsRecord);
                    this.DataSource = (View_StatsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual View_StatsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(View_StatsView.Column1, true);          
            // selCols.Add(View_StatsView.Column2, true);          
            // selCols.Add(View_StatsView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return View_StatsView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                View_StatsView databaseTable = new View_StatsView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(View_StatsRecord)) as View_StatsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(View_StatsView.Column1, true);          
            // selCols.Add(View_StatsView.Column2, true);          
            // selCols.Add(View_StatsView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return View_StatsView.GetRecordCount(join, where);
            else
            {
                View_StatsView databaseTable = new View_StatsView();
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
          
                  LoadData_FieldTripChoicesCountQuery();
       
                  LoadData_FieldTripChoicesCountQuery1();
       
                  LoadData_FieldTripChoicesCountQuery2();
       
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_StatsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            View_StatsTableControlRow recControl = (View_StatsTableControlRow)(repItem.FindControl("View_StatsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                SetFieldTripIdLabel1();
                
                
                
                
                
                
                
                
                SetSortByLabel();
                SetSortControl();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
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
          
            this.Page.PregetDfkaRecords(View_StatsView.FieldTripId, this.DataSource);
            this.Page.PregetDfkaRecords(View_StatsView.FieldTripOptionId, this.DataSource);
            this.Page.PregetDfkaRecords(View_StatsView.FieldTripOptionId2, this.DataSource);
            this.Page.PregetDfkaRecords(View_StatsView.FieldTripOptionId3, this.DataSource);
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
                
                // add datasource as variables for formula evaluation
                    
                if (FieldTripChoicesCountQuery != null) e.Variables.Add("FieldTripChoicesCountQuery", FieldTripChoicesCountQuery);                                                       
                    
                if (FieldTripChoicesCountQuery1 != null) e.Variables.Add("FieldTripChoicesCountQuery1", FieldTripChoicesCountQuery1);                                                       
                    
                if (FieldTripChoicesCountQuery2 != null) e.Variables.Add("FieldTripChoicesCountQuery2", FieldTripChoicesCountQuery2);                                                       
                    
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
            
            this.FieldTripIdFromFilter.Text = "";
            
            this.FieldTripIdToFilter.Text = "";
            
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
        
    
            // Bind the buttons for View_StatsTableControl pagination.
            
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (View_StatsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (View_StatsTableControlRow recCtl in this.GetRecordControls()){
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
            View_StatsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.FieldTripIdFromFilter)) {
                        
                wc.iAND(View_StatsView.FieldTripId, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.FieldTripIdFromFilter, this.GetFromSession(this.FieldTripIdFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.FieldTripIdToFilter)) {
                        
                wc.iAND(View_StatsView.FieldTripId, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.FieldTripIdToFilter, this.GetFromSession(this.FieldTripIdToFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            View_StatsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String FieldTripIdFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "FieldTripIdFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(FieldTripIdFromFilterSelectedValue)) {

              
                wc.iAND(View_StatsView.FieldTripId, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, FieldTripIdFromFilterSelectedValue, false, false);
                      
      }
                      
      String FieldTripIdToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "FieldTripIdToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(FieldTripIdToFilterSelectedValue)) {

              
                wc.iAND(View_StatsView.FieldTripId, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, FieldTripIdToFilterSelectedValue, false, false);
                      
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_StatsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                View_StatsTableControlRow recControl = (View_StatsTableControlRow)(repItem.FindControl("View_StatsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      View_StatsRecord rec = new View_StatsRecord();
        
                        if (recControl.FieldTripId.Text != "") {
                            rec.Parse(recControl.FieldTripId.Text, View_StatsView.FieldTripId);
                  }
                
                        if (recControl.FieldTripOptionId.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId.Text, View_StatsView.FieldTripOptionId);
                  }
                
                        if (recControl.FieldTripOptionId2.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId2.Text, View_StatsView.FieldTripOptionId2);
                  }
                
                        if (recControl.FieldTripOptionId3.Text != "") {
                            rec.Parse(recControl.FieldTripOptionId3.Text, View_StatsView.FieldTripOptionId3);
                  }
                
                        if (recControl.ftKey.Text != "") {
                            rec.Parse(recControl.ftKey.Text, View_StatsView.ftKey);
                  }
                
                        if (recControl.ftO1Key.Text != "") {
                            rec.Parse(recControl.ftO1Key.Text, View_StatsView.ftO1Key);
                  }
                
                        if (recControl.ftO2Key.Text != "") {
                            rec.Parse(recControl.ftO2Key.Text, View_StatsView.ftO2Key);
                  }
                
                        if (recControl.ftO3Key.Text != "") {
                            rec.Parse(recControl.ftO3Key.Text, View_StatsView.ftO3Key);
                  }
                
                        if (recControl.PlacesAvailable.Text != "") {
                            rec.Parse(recControl.PlacesAvailable.Text, View_StatsView.PlacesAvailable);
                  }
                
                        if (recControl.PlacesAvailable2.Text != "") {
                            rec.Parse(recControl.PlacesAvailable2.Text, View_StatsView.PlacesAvailable2);
                  }
                
                        if (recControl.PlacesAvailable3.Text != "") {
                            rec.Parse(recControl.PlacesAvailable3.Text, View_StatsView.PlacesAvailable3);
                  }
                
                        if (recControl.SUM1.Text != "") {
                            rec.Parse(recControl.SUM1.Text, View_StatsView.SUM1);
                  }
                
                        if (recControl.SUM2.Text != "") {
                            rec.Parse(recControl.SUM2.Text, View_StatsView.SUM2);
                  }
                
                        if (recControl.SUM3.Text != "") {
                            rec.Parse(recControl.SUM3.Text, View_StatsView.SUM3);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new View_StatsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OLR.Business.View_StatsRecord);
                this.DataSource = (View_StatsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(View_StatsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(View_StatsTableControlRow rec)            
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
        
        public virtual void SetFieldTripIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual WhereClause CreateWhereClause_FieldTripChoicesCountQuery()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual WhereClause CreateWhereClause_FieldTripChoicesCountQuery1()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual WhereClause CreateWhereClause_FieldTripChoicesCountQuery2()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual void LoadData_FieldTripChoicesCountQuery()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _FieldTripChoicesCountQuery.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _FieldTripChoicesCountQuery.DataChanged = true;
          
              this._FieldTripChoicesCountQuery.Initialize("FieldTripChoicesCountQuery", FieldTripChoicesTable.Instance, 0, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_FieldTripChoicesCountQuery();
              this._FieldTripChoicesCountQuery.WhereClause.iAND(wc);                      
          
              // Define selects
          
                    this._FieldTripChoicesCountQuery.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, FieldTripChoicesTable.Instance, "FieldTripChoicesCount", ""), "FieldTripChoicesCount"));
              
              // Define joins if there are any
          
              this._FieldTripChoicesCountQuery.LoadData(false, this._FieldTripChoicesCountQuery.PageSize, this._FieldTripChoicesCountQuery.PageIndex);                       
                        
        }
      
        public virtual void LoadData_FieldTripChoicesCountQuery1()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _FieldTripChoicesCountQuery1.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _FieldTripChoicesCountQuery1.DataChanged = true;
          
              this._FieldTripChoicesCountQuery1.Initialize("FieldTripChoicesCountQuery1", View_StatsView.Instance, 0, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_FieldTripChoicesCountQuery1();
              this._FieldTripChoicesCountQuery1.WhereClause.iAND(wc);                      
          
              // Define selects
          
              this._FieldTripChoicesCountQuery1.AddSelectItem(new SelectItem(View_StatsView.FieldTripId, View_StatsView.Instance, false, "", ""));
              
                    this._FieldTripChoicesCountQuery1.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, FieldTripChoicesTable.Instance, "FieldTripChoicesCount", ""), "FieldTripChoicesCount"));
              
              // Define joins if there are any
          
              this._FieldTripChoicesCountQuery1.AddJoin(View_StatsView.FieldTripId, View_StatsView.Instance, "", FieldTripChoicesTable.FieldTripId, FieldTripChoicesTable.Instance, "");
          
              this._FieldTripChoicesCountQuery1.LoadData(false, this._FieldTripChoicesCountQuery1.PageSize, this._FieldTripChoicesCountQuery1.PageIndex);                       
                        
        }
      
        public virtual void LoadData_FieldTripChoicesCountQuery2()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _FieldTripChoicesCountQuery2.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _FieldTripChoicesCountQuery2.DataChanged = true;
          
              this._FieldTripChoicesCountQuery2.Initialize("FieldTripChoicesCountQuery2", View_StatsView.Instance, 0, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_FieldTripChoicesCountQuery2();
              this._FieldTripChoicesCountQuery2.WhereClause.iAND(wc);                      
          
              // Define selects
          
              this._FieldTripChoicesCountQuery2.AddSelectItem(new SelectItem(View_StatsView.FieldTripId, View_StatsView.Instance, false, "", ""));
              
                    this._FieldTripChoicesCountQuery2.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, FieldTripChoicesTable.Instance, "FieldTripChoicesCount", ""), "FieldTripChoicesCount"));
              
              // Define joins if there are any
          
              this._FieldTripChoicesCountQuery2.AddJoin(View_StatsView.FieldTripId, View_StatsView.Instance, "", FieldTripChoicesTable.FieldTripId, FieldTripChoicesTable.Instance, "");
          
              this._FieldTripChoicesCountQuery2.LoadData(false, this._FieldTripChoicesCountQuery2.PageSize, this._FieldTripChoicesCountQuery2.PageIndex);                       
                        
        }
      
        private DataSource _FieldTripChoicesCountQuery = new DataSource();
        public DataSource FieldTripChoicesCountQuery
        {
            get
            {
                return _FieldTripChoicesCountQuery;
             }
        }
      
        private DataSource _FieldTripChoicesCountQuery1 = new DataSource();
        public DataSource FieldTripChoicesCountQuery1
        {
            get
            {
                return _FieldTripChoicesCountQuery1;
             }
        }
      
        private DataSource _FieldTripChoicesCountQuery2 = new DataSource();
        public DataSource FieldTripChoicesCountQuery2
        {
            get
            {
                return _FieldTripChoicesCountQuery2;
             }
        }
      
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip {Txt:Ascending}"), "FieldTripId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip {Txt:Descending}"), "FieldTripId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option {Txt:Ascending}"), "FieldTripOptionId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option {Txt:Descending}"), "FieldTripOptionId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option 2 {Txt:Ascending}"), "FieldTripOptionId2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option 2 {Txt:Descending}"), "FieldTripOptionId2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option 3 {Txt:Ascending}"), "FieldTripOptionId3 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Field Trip Option 3 {Txt:Descending}"), "FieldTripOptionId3 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available {Txt:Ascending}"), "PlacesAvailable Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available {Txt:Descending}"), "PlacesAvailable Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available 2 {Txt:Ascending}"), "PlacesAvailable2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available 2 {Txt:Descending}"), "PlacesAvailable2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available 3 {Txt:Ascending}"), "PlacesAvailable3 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Places Available 3 {Txt:Descending}"), "PlacesAvailable3 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 1 {Txt:Ascending}"), "SUM1 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 1 {Txt:Descending}"), "SUM1 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 2 {Txt:Ascending}"), "SUM2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 2 {Txt:Descending}"), "SUM2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 3 {Txt:Ascending}"), "SUM3 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sum 3 {Txt:Descending}"), "SUM3 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT Key {Txt:Ascending}"), "ftKey Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT Key {Txt:Descending}"), "ftKey Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 2 Key {Txt:Ascending}"), "ftO2Key Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 2 Key {Txt:Descending}"), "ftO2Key Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 1 Key {Txt:Ascending}"), "ftO1Key Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 1 Key {Txt:Descending}"), "ftO1Key Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 3 Key {Txt:Ascending}"), "ftO3Key Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("FT O 3 Key {Txt:Descending}"), "ftO3Key Desc"));
              
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
                  
            this.SaveToSession(this.FieldTripIdFromFilter, this.FieldTripIdFromFilter.Text);
                  
            this.SaveToSession(this.FieldTripIdToFilter, this.FieldTripIdToFilter.Text);
                  
            
                    
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
                  
      this.SaveToSession("FieldTripIdFromFilter_Ajax", this.FieldTripIdFromFilter.Text);
              
      this.SaveToSession("FieldTripIdToFilter_Ajax", this.FieldTripIdToFilter.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.FieldTripIdFromFilter);
            this.RemoveFromSession(this.FieldTripIdToFilter);
            
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

            string orderByStr = (string)ViewState["View_StatsTableControl_OrderBy"];
          
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
                this.ViewState["View_StatsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=View_Stats" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "View_StatsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "View_StatsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
    
      
            if (MiscUtils.IsValueSelected(FieldTripIdFromFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(FieldTripIdToFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        

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


              this.TotalRecords = View_StatsView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             View_StatsView.FieldTripId,
             View_StatsView.SUM1,
             View_StatsView.FieldTripOptionId,
             View_StatsView.SUM2,
             View_StatsView.FieldTripOptionId2,
             View_StatsView.SUM3,
             View_StatsView.FieldTripOptionId3,
             View_StatsView.PlacesAvailable,
             View_StatsView.PlacesAvailable2,
             View_StatsView.PlacesAvailable3,
             View_StatsView.ftKey,
             View_StatsView.ftO1Key,
             View_StatsView.ftO2Key,
             View_StatsView.ftO3Key,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(View_StatsView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(View_StatsView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(View_StatsView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(View_StatsView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(View_StatsView.FieldTripId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.SUM1, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.FieldTripOptionId, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.SUM2, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.FieldTripOptionId2, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.SUM3, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.FieldTripOptionId3, "Default"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.PlacesAvailable, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.PlacesAvailable2, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.PlacesAvailable3, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.ftKey, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.ftO1Key, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.ftO2Key, "0"));
             data.ColumnList.Add(new ExcelColumn(View_StatsView.ftO3Key, "0"));


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
                val = View_StatsView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "View_StatsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "View_StatsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-Stats-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_Stats";
                // If Show-View-Stats-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_StatsView.FieldTripId.Name, ReportEnum.Align.Left, "${FieldTripId}", ReportEnum.Align.Left, 18);
                 report.AddColumn(View_StatsView.SUM1.Name, ReportEnum.Align.Right, "${SUM1}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId.Name, ReportEnum.Align.Left, "${FieldTripOptionId}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.SUM2.Name, ReportEnum.Align.Right, "${SUM2}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId2.Name, ReportEnum.Align.Left, "${FieldTripOptionId2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.SUM3.Name, ReportEnum.Align.Right, "${SUM3}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId3.Name, ReportEnum.Align.Left, "${FieldTripOptionId3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.PlacesAvailable.Name, ReportEnum.Align.Right, "${PlacesAvailable}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.PlacesAvailable2.Name, ReportEnum.Align.Right, "${PlacesAvailable2}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.PlacesAvailable3.Name, ReportEnum.Align.Right, "${PlacesAvailable3}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftKey.Name, ReportEnum.Align.Right, "${ftKey}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO1Key.Name, ReportEnum.Align.Right, "${ftO1Key}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO2Key.Name, ReportEnum.Align.Right, "${ftO2Key}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO3Key.Name, ReportEnum.Align.Right, "${ftO3Key}", ReportEnum.Align.Right, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = View_StatsView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = View_StatsView.GetRecordCount(joinFilter,whereClause);
                View_StatsRecord[] records = null;
                
                do
                {
                    
                    records = View_StatsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_StatsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripId)){
                                 report.AddData("${FieldTripId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripId);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripId.ToString(), View_StatsView.FieldTripId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripId.IsApplyDisplayAs){
                                     report.AddData("${FieldTripId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripId}", record.Format(View_StatsView.FieldTripId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM1}", record.Format(View_StatsView.SUM1), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId)){
                                 report.AddData("${FieldTripOptionId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId.ToString(), View_StatsView.FieldTripOptionId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId}", record.Format(View_StatsView.FieldTripOptionId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM2}", record.Format(View_StatsView.SUM2), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId2)){
                                 report.AddData("${FieldTripOptionId2}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId2);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId2.ToString(), View_StatsView.FieldTripOptionId2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId2.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId2}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId2}", record.Format(View_StatsView.FieldTripOptionId2), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM3}", record.Format(View_StatsView.SUM3), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId3)){
                                 report.AddData("${FieldTripOptionId3}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId3);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId3.ToString(), View_StatsView.FieldTripOptionId3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId3.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId3}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId3}", record.Format(View_StatsView.FieldTripOptionId3), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${PlacesAvailable}", record.Format(View_StatsView.PlacesAvailable), ReportEnum.Align.Right, 300);
                             report.AddData("${PlacesAvailable2}", record.Format(View_StatsView.PlacesAvailable2), ReportEnum.Align.Right, 300);
                             report.AddData("${PlacesAvailable3}", record.Format(View_StatsView.PlacesAvailable3), ReportEnum.Align.Right, 300);
                             report.AddData("${ftKey}", record.Format(View_StatsView.ftKey), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO1Key}", record.Format(View_StatsView.ftO1Key), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO2Key}", record.Format(View_StatsView.ftO2Key), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO3Key}", record.Format(View_StatsView.ftO3Key), ReportEnum.Align.Right, 300);

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
          
              this.FieldTripIdFromFilter.Text = "";
            
              this.FieldTripIdToFilter.Text = "";
            
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
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-View-Stats-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "view_Stats";
                // If Show-View-Stats-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(View_StatsView.FieldTripId.Name, ReportEnum.Align.Left, "${FieldTripId}", ReportEnum.Align.Left, 18);
                 report.AddColumn(View_StatsView.SUM1.Name, ReportEnum.Align.Right, "${SUM1}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId.Name, ReportEnum.Align.Left, "${FieldTripOptionId}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.SUM2.Name, ReportEnum.Align.Right, "${SUM2}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId2.Name, ReportEnum.Align.Left, "${FieldTripOptionId2}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.SUM3.Name, ReportEnum.Align.Right, "${SUM3}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.FieldTripOptionId3.Name, ReportEnum.Align.Left, "${FieldTripOptionId3}", ReportEnum.Align.Left, 22);
                 report.AddColumn(View_StatsView.PlacesAvailable.Name, ReportEnum.Align.Right, "${PlacesAvailable}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.PlacesAvailable2.Name, ReportEnum.Align.Right, "${PlacesAvailable2}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.PlacesAvailable3.Name, ReportEnum.Align.Right, "${PlacesAvailable3}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftKey.Name, ReportEnum.Align.Right, "${ftKey}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO1Key.Name, ReportEnum.Align.Right, "${ftO1Key}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO2Key.Name, ReportEnum.Align.Right, "${ftO2Key}", ReportEnum.Align.Right, 15);
                 report.AddColumn(View_StatsView.ftO3Key.Name, ReportEnum.Align.Right, "${ftO3Key}", ReportEnum.Align.Right, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = View_StatsView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OLR");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = View_StatsView.GetColumnList();
                View_StatsRecord[] records = null;
                do
                {
                    records = View_StatsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( View_StatsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripId)){
                                 report.AddData("${FieldTripId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripId);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripId.ToString(), View_StatsView.FieldTripId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripId.IsApplyDisplayAs){
                                     report.AddData("${FieldTripId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripId}", record.Format(View_StatsView.FieldTripId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM1}", record.Format(View_StatsView.SUM1), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId)){
                                 report.AddData("${FieldTripOptionId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId.ToString(), View_StatsView.FieldTripOptionId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId}", record.Format(View_StatsView.FieldTripOptionId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM2}", record.Format(View_StatsView.SUM2), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId2)){
                                 report.AddData("${FieldTripOptionId2}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId2);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId2.ToString(), View_StatsView.FieldTripOptionId2,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId2.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId2}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId2}", record.Format(View_StatsView.FieldTripOptionId2), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${SUM3}", record.Format(View_StatsView.SUM3), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.FieldTripOptionId3)){
                                 report.AddData("${FieldTripOptionId3}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = View_StatsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_StatsView.FieldTripOptionId3);
                                 _DFKA = View_StatsView.GetDFKA(record.FieldTripOptionId3.ToString(), View_StatsView.FieldTripOptionId3,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  View_StatsView.FieldTripOptionId3.IsApplyDisplayAs){
                                     report.AddData("${FieldTripOptionId3}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${FieldTripOptionId3}", record.Format(View_StatsView.FieldTripOptionId3), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${PlacesAvailable}", record.Format(View_StatsView.PlacesAvailable), ReportEnum.Align.Right, 300);
                             report.AddData("${PlacesAvailable2}", record.Format(View_StatsView.PlacesAvailable2), ReportEnum.Align.Right, 300);
                             report.AddData("${PlacesAvailable3}", record.Format(View_StatsView.PlacesAvailable3), ReportEnum.Align.Right, 300);
                             report.AddData("${ftKey}", record.Format(View_StatsView.ftKey), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO1Key}", record.Format(View_StatsView.ftO1Key), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO2Key}", record.Format(View_StatsView.ftO2Key), ReportEnum.Align.Right, 300);
                             report.AddData("${ftO3Key}", record.Format(View_StatsView.ftO3Key), ReportEnum.Align.Right, 300);

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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in View_StatsView.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(View_StatsView.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (View_StatsView.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && View_StatsView.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(View_StatsView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(View_StatsView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = View_StatsView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  View_StatsRecord[] DataSource {
             
            get {
                return (View_StatsRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox FieldTripIdFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal FieldTripIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox FieldTripIdToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FieldTripIdToFilter");
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
                View_StatsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_StatsRecord rec = null;
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
                View_StatsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
                }

        View_StatsRecord rec = null;
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
          
        public virtual View_StatsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual View_StatsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (View_StatsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OLR.UI.Controls.Show_View_Stats_Table.View_StatsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            View_StatsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OLR"));
            }
            
            foreach (View_StatsTableControlRow recCtl in recordList)
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

        public virtual View_StatsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "View_StatsTableControlRow");
	          List<View_StatsTableControlRow> list = new List<View_StatsTableControlRow>();
	          foreach (View_StatsTableControlRow recCtrl in recCtrls) {
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

