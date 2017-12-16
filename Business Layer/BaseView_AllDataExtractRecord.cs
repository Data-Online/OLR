// This class is "generated" and will be overwritten.
// Your customizations should be made in View_AllDataExtractRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="View_AllDataExtractRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="View_AllDataExtractView"></see> class.
/// </remarks>
/// <seealso cref="View_AllDataExtractView"></seealso>
/// <seealso cref="View_AllDataExtractRecord"></seealso>
public class BaseView_AllDataExtractRecord : PrimaryKeyRecord
{

	public readonly static View_AllDataExtractView TableUtils = View_AllDataExtractView.Instance;

	// Constructors
 
	protected BaseView_AllDataExtractRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.View_AllDataExtractRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.View_AllDataExtractRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.View_AllDataExtractRecord_ReadRecord); 
	}

	protected BaseView_AllDataExtractRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void View_AllDataExtractRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                View_AllDataExtractRecord View_AllDataExtractRec = (View_AllDataExtractRecord)sender;
        if(View_AllDataExtractRec != null && !View_AllDataExtractRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void View_AllDataExtractRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                View_AllDataExtractRecord View_AllDataExtractRec = (View_AllDataExtractRecord)sender;
        Validate_Inserting();
        if(View_AllDataExtractRec != null && !View_AllDataExtractRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void View_AllDataExtractRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                View_AllDataExtractRecord View_AllDataExtractRec = (View_AllDataExtractRecord)sender;
        Validate_Updating();
        if(View_AllDataExtractRec != null && !View_AllDataExtractRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public ColumnValue GetMobileNumberValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public string GetMobileNumberFieldValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public ColumnValue GetPSNZMembershipCheckValue()
	{
		return this.GetValue(TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public bool GetPSNZMembershipCheckFieldValue()
	{
		return this.GetValue(TableUtils.PSNZMembershipCheckColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZMembershipCheckColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public ColumnValue GetPSNZMemberValue()
	{
		return this.GetValue(TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public bool GetPSNZMemberFieldValue()
	{
		return this.GetValue(TableUtils.PSNZMemberColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZMemberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public ColumnValue GetEmailValue()
	{
		return this.GetValue(TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public string GetEmailFieldValue()
	{
		return this.GetValue(TableUtils.EmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public void SetEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public void SetEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public ColumnValue GetPSNZAppliedForValue()
	{
		return this.GetValue(TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public bool GetPSNZAppliedForFieldValue()
	{
		return this.GetValue(TableUtils.PSNZAppliedForColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZAppliedForColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public ColumnValue GetDatePaidValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public DateTime GetDatePaidFieldValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(string val)
	{
		this.SetString(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DatePaidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public ColumnValue GetInitialCreationDateValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public DateTime GetInitialCreationDateFieldValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InitialCreationDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public ColumnValue GetAdditionalDinnerNameValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public string GetAdditionalDinnerNameFieldValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public void SetAdditionalDinnerNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdditionalDinnerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public void SetAdditionalDinnerNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdditionalDinnerNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public ColumnValue GetSpecialRequirementsValue()
	{
		return this.GetValue(TableUtils.SpecialRequirementsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public string GetSpecialRequirementsFieldValue()
	{
		return this.GetValue(TableUtils.SpecialRequirementsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public void SetSpecialRequirementsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SpecialRequirementsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public void SetSpecialRequirementsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpecialRequirementsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public ColumnValue GetAdditionalDinnerTicketValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public bool GetAdditionalDinnerTicketFieldValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerTicketColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(string val)
	{
		this.SetString(val, TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdditionalDinnerTicketColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public ColumnValue GetTownNameValue()
	{
		return this.GetValue(TableUtils.TownNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public string GetTownNameFieldValue()
	{
		return this.GetValue(TableUtils.TownNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public void SetTownNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TownNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public void SetTownNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TownNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public ColumnValue GetRegistrationTypeValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public string GetRegistrationTypeFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public void SetRegistrationTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public void SetRegistrationTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public ColumnValue GetRegistrationIdValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public Int32 GetRegistrationIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public ColumnValue GetValidationUidValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public System.Guid GetValidationUidFieldValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn).ToGuid();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(string val)
	{
		this.SetString(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(System.Guid val)
	{
		ColumnValue cv = new ColumnValue(val, System.TypeCode.Object);
		this.SetValue(cv, TableUtils.ValidationUidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public ColumnValue GetFT1_1Value()
	{
		return this.GetValue(TableUtils.FT1_1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public Int32 GetFT1_1FieldValue()
	{
		return this.GetValue(TableUtils.FT1_1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public void SetFT1_1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT1_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public void SetFT1_1FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT1_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public void SetFT1_1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public void SetFT1_1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public void SetFT1_1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public ColumnValue GetFT1_2Value()
	{
		return this.GetValue(TableUtils.FT1_2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public Int32 GetFT1_2FieldValue()
	{
		return this.GetValue(TableUtils.FT1_2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public void SetFT1_2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT1_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public void SetFT1_2FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT1_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public void SetFT1_2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public void SetFT1_2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public void SetFT1_2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public ColumnValue GetFT1_3Value()
	{
		return this.GetValue(TableUtils.FT1_3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public Int32 GetFT1_3FieldValue()
	{
		return this.GetValue(TableUtils.FT1_3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public void SetFT1_3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT1_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public void SetFT1_3FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT1_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public void SetFT1_3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public void SetFT1_3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public void SetFT1_3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT1_3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public ColumnValue GetDescription1Value()
	{
		return this.GetValue(TableUtils.Description1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public string GetDescription1FieldValue()
	{
		return this.GetValue(TableUtils.Description1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public void SetDescription1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Description1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public void SetDescription1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Description1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public ColumnValue GetFT2_1Value()
	{
		return this.GetValue(TableUtils.FT2_1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public Int32 GetFT2_1FieldValue()
	{
		return this.GetValue(TableUtils.FT2_1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public void SetFT2_1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT2_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public void SetFT2_1FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT2_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public void SetFT2_1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public void SetFT2_1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public void SetFT2_1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public ColumnValue GetFT2_2Value()
	{
		return this.GetValue(TableUtils.FT2_2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public Int32 GetFT2_2FieldValue()
	{
		return this.GetValue(TableUtils.FT2_2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public void SetFT2_2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT2_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public void SetFT2_2FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT2_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public void SetFT2_2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public void SetFT2_2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public void SetFT2_2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public ColumnValue GetFT2_3Value()
	{
		return this.GetValue(TableUtils.FT2_3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public Int32 GetFT2_3FieldValue()
	{
		return this.GetValue(TableUtils.FT2_3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public void SetFT2_3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FT2_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public void SetFT2_3FieldValue(string val)
	{
		this.SetString(val, TableUtils.FT2_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public void SetFT2_3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public void SetFT2_3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public void SetFT2_3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FT2_3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public ColumnValue GetDescription2Value()
	{
		return this.GetValue(TableUtils.Description2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public string GetDescription2FieldValue()
	{
		return this.GetValue(TableUtils.Description2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public void SetDescription2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Description2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public void SetDescription2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Description2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public ColumnValue GetFTA2Value()
	{
		return this.GetValue(TableUtils.FTA2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public Int32 GetFTA2FieldValue()
	{
		return this.GetValue(TableUtils.FTA2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public void SetFTA2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FTA2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public void SetFTA2FieldValue(string val)
	{
		this.SetString(val, TableUtils.FTA2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public void SetFTA2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public void SetFTA2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public void SetFTA2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public ColumnValue GetFTA1Value()
	{
		return this.GetValue(TableUtils.FTA1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public Int32 GetFTA1FieldValue()
	{
		return this.GetValue(TableUtils.FTA1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public void SetFTA1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FTA1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public void SetFTA1FieldValue(string val)
	{
		this.SetString(val, TableUtils.FTA1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public void SetFTA1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public void SetFTA1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public void SetFTA1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FTA1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public ColumnValue GetItem1Value()
	{
		return this.GetValue(TableUtils.Item1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public Int32 GetItem1FieldValue()
	{
		return this.GetValue(TableUtils.Item1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public void SetItem1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public void SetItem1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public void SetItem1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public void SetItem1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public void SetItem1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public ColumnValue GetItem2Value()
	{
		return this.GetValue(TableUtils.Item2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public Int32 GetItem2FieldValue()
	{
		return this.GetValue(TableUtils.Item2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public void SetItem2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public void SetItem2FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public void SetItem2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public void SetItem2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public void SetItem2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public ColumnValue GetItem1aValue()
	{
		return this.GetValue(TableUtils.Item1aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public bool GetItem1aFieldValue()
	{
		return this.GetValue(TableUtils.Item1aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public void SetItem1aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item1aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public void SetItem1aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item1aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public void SetItem1aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item1aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public ColumnValue GetItem2aValue()
	{
		return this.GetValue(TableUtils.Item2aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public bool GetItem2aFieldValue()
	{
		return this.GetValue(TableUtils.Item2aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public void SetItem2aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item2aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public void SetItem2aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item2aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public void SetItem2aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item2aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public ColumnValue GetItem3Value()
	{
		return this.GetValue(TableUtils.Item3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public Int32 GetItem3FieldValue()
	{
		return this.GetValue(TableUtils.Item3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public void SetItem3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public void SetItem3FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public void SetItem3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public void SetItem3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public void SetItem3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public ColumnValue GetItem4Value()
	{
		return this.GetValue(TableUtils.Item4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public Int32 GetItem4FieldValue()
	{
		return this.GetValue(TableUtils.Item4Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public void SetItem4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public void SetItem4FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public void SetItem4FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public void SetItem4FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public void SetItem4FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public ColumnValue GetItem5Value()
	{
		return this.GetValue(TableUtils.Item5Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public Int32 GetItem5FieldValue()
	{
		return this.GetValue(TableUtils.Item5Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public void SetItem5FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public void SetItem5FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public void SetItem5FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public void SetItem5FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public void SetItem5FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item5Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public ColumnValue GetItem6Value()
	{
		return this.GetValue(TableUtils.Item6Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public Int32 GetItem6FieldValue()
	{
		return this.GetValue(TableUtils.Item6Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public void SetItem6FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public void SetItem6FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public void SetItem6FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public void SetItem6FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public void SetItem6FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item6Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public ColumnValue GetItem7Value()
	{
		return this.GetValue(TableUtils.Item7Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public Int32 GetItem7FieldValue()
	{
		return this.GetValue(TableUtils.Item7Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public void SetItem7FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public void SetItem7FieldValue(string val)
	{
		this.SetString(val, TableUtils.Item7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public void SetItem7FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public void SetItem7FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public void SetItem7FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item7Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public ColumnValue GetItem3aValue()
	{
		return this.GetValue(TableUtils.Item3aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public bool GetItem3aFieldValue()
	{
		return this.GetValue(TableUtils.Item3aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public void SetItem3aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item3aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public void SetItem3aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item3aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public void SetItem3aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item3aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public ColumnValue GetItem4aValue()
	{
		return this.GetValue(TableUtils.Item4aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public bool GetItem4aFieldValue()
	{
		return this.GetValue(TableUtils.Item4aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public void SetItem4aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item4aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public void SetItem4aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item4aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public void SetItem4aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item4aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public ColumnValue GetItem5aValue()
	{
		return this.GetValue(TableUtils.Item5aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public bool GetItem5aFieldValue()
	{
		return this.GetValue(TableUtils.Item5aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public void SetItem5aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item5aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public void SetItem5aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item5aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public void SetItem5aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item5aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public ColumnValue GetItem6aValue()
	{
		return this.GetValue(TableUtils.Item6aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public bool GetItem6aFieldValue()
	{
		return this.GetValue(TableUtils.Item6aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public void SetItem6aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item6aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public void SetItem6aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item6aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public void SetItem6aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item6aColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public ColumnValue GetItem7aValue()
	{
		return this.GetValue(TableUtils.Item7aColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public bool GetItem7aFieldValue()
	{
		return this.GetValue(TableUtils.Item7aColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public void SetItem7aFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Item7aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public void SetItem7aFieldValue(string val)
	{
		this.SetString(val, TableUtils.Item7aColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public void SetItem7aFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Item7aColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public Int32 ContactId
	{
		get
		{
			return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public string Address1
	{
		get
		{
			return this.GetValue(TableUtils.Address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public string Address2
	{
		get
		{
			return this.GetValue(TableUtils.Address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public string Address3
	{
		get
		{
			return this.GetValue(TableUtils.Address3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public string MobileNumber
	{
		get
		{
			return this.GetValue(TableUtils.MobileNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MobileNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MobileNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MobileNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.MobileNumber field.
	/// </summary>
	public string MobileNumberDefault
	{
		get
		{
			return TableUtils.MobileNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public bool PSNZMembershipCheck
	{
		get
		{
			return this.GetValue(TableUtils.PSNZMembershipCheckColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZMembershipCheckColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZMembershipCheckSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZMembershipCheckColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMembershipCheck field.
	/// </summary>
	public string PSNZMembershipCheckDefault
	{
		get
		{
			return TableUtils.PSNZMembershipCheckColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public bool PSNZMember
	{
		get
		{
			return this.GetValue(TableUtils.PSNZMemberColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZMemberColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZMemberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZMemberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZMember field.
	/// </summary>
	public string PSNZMemberDefault
	{
		get
		{
			return TableUtils.PSNZMemberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public string Email
	{
		get
		{
			return this.GetValue(TableUtils.EmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Email field.
	/// </summary>
	public string EmailDefault
	{
		get
		{
			return TableUtils.EmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public bool PSNZAppliedFor
	{
		get
		{
			return this.GetValue(TableUtils.PSNZAppliedForColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZAppliedForColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZAppliedForSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZAppliedForColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.PSNZAppliedFor field.
	/// </summary>
	public string PSNZAppliedForDefault
	{
		get
		{
			return TableUtils.PSNZAppliedForColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public string FirstName
	{
		get
		{
			return this.GetValue(TableUtils.FirstNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public string LastName
	{
		get
		{
			return this.GetValue(TableUtils.LastNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LastNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public DateTime DatePaid
	{
		get
		{
			return this.GetValue(TableUtils.DatePaidColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DatePaidColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DatePaidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DatePaidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.DatePaid field.
	/// </summary>
	public string DatePaidDefault
	{
		get
		{
			return TableUtils.DatePaidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public DateTime InitialCreationDate
	{
		get
		{
			return this.GetValue(TableUtils.InitialCreationDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InitialCreationDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InitialCreationDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InitialCreationDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.InitialCreationDate field.
	/// </summary>
	public string InitialCreationDateDefault
	{
		get
		{
			return TableUtils.InitialCreationDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public string AdditionalDinnerName
	{
		get
		{
			return this.GetValue(TableUtils.AdditionalDinnerNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdditionalDinnerNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdditionalDinnerNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdditionalDinnerNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerName field.
	/// </summary>
	public string AdditionalDinnerNameDefault
	{
		get
		{
			return TableUtils.AdditionalDinnerNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public string SpecialRequirements
	{
		get
		{
			return this.GetValue(TableUtils.SpecialRequirementsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SpecialRequirementsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SpecialRequirementsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SpecialRequirementsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.SpecialRequirements field.
	/// </summary>
	public string SpecialRequirementsDefault
	{
		get
		{
			return TableUtils.SpecialRequirementsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public bool AdditionalDinnerTicket
	{
		get
		{
			return this.GetValue(TableUtils.AdditionalDinnerTicketColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.AdditionalDinnerTicketColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdditionalDinnerTicketSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdditionalDinnerTicketColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.AdditionalDinnerTicket field.
	/// </summary>
	public string AdditionalDinnerTicketDefault
	{
		get
		{
			return TableUtils.AdditionalDinnerTicketColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public string TownName
	{
		get
		{
			return this.GetValue(TableUtils.TownNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TownNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TownNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TownNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.TownName field.
	/// </summary>
	public string TownNameDefault
	{
		get
		{
			return TableUtils.TownNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public string RegistrationType
	{
		get
		{
			return this.GetValue(TableUtils.RegistrationTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegistrationTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegistrationTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegistrationTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationType field.
	/// </summary>
	public string RegistrationTypeDefault
	{
		get
		{
			return TableUtils.RegistrationTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public Int32 RegistrationId
	{
		get
		{
			return this.GetValue(TableUtils.RegistrationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegistrationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegistrationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegistrationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.RegistrationId field.
	/// </summary>
	public string RegistrationIdDefault
	{
		get
		{
			return TableUtils.RegistrationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public System.Guid ValidationUid
	{
		get
		{
			return this.GetValue(TableUtils.ValidationUidColumn).ToGuid();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value, System.TypeCode.Object);
			this.SetValue(cv, TableUtils.ValidationUidColumn);
		}
	}
		

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ValidationUidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ValidationUidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.ValidationUid field.
	/// </summary>
	public string ValidationUidDefault
	{
		get
		{
			return TableUtils.ValidationUidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public Int32 FT1_1
	{
		get
		{
			return this.GetValue(TableUtils.FT1_1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT1_1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT1_1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT1_1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_1 field.
	/// </summary>
	public string FT1_1Default
	{
		get
		{
			return TableUtils.FT1_1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public Int32 FT1_2
	{
		get
		{
			return this.GetValue(TableUtils.FT1_2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT1_2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT1_2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT1_2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_2 field.
	/// </summary>
	public string FT1_2Default
	{
		get
		{
			return TableUtils.FT1_2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public Int32 FT1_3
	{
		get
		{
			return this.GetValue(TableUtils.FT1_3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT1_3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT1_3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT1_3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT1_3 field.
	/// </summary>
	public string FT1_3Default
	{
		get
		{
			return TableUtils.FT1_3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public string Description1
	{
		get
		{
			return this.GetValue(TableUtils.Description1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Description1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Description1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Description1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description1 field.
	/// </summary>
	public string Description1Default
	{
		get
		{
			return TableUtils.Description1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public Int32 FT2_1
	{
		get
		{
			return this.GetValue(TableUtils.FT2_1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT2_1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT2_1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT2_1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_1 field.
	/// </summary>
	public string FT2_1Default
	{
		get
		{
			return TableUtils.FT2_1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public Int32 FT2_2
	{
		get
		{
			return this.GetValue(TableUtils.FT2_2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT2_2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT2_2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT2_2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_2 field.
	/// </summary>
	public string FT2_2Default
	{
		get
		{
			return TableUtils.FT2_2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public Int32 FT2_3
	{
		get
		{
			return this.GetValue(TableUtils.FT2_3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FT2_3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FT2_3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FT2_3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FT2_3 field.
	/// </summary>
	public string FT2_3Default
	{
		get
		{
			return TableUtils.FT2_3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public string Description2
	{
		get
		{
			return this.GetValue(TableUtils.Description2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Description2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Description2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Description2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Description2 field.
	/// </summary>
	public string Description2Default
	{
		get
		{
			return TableUtils.Description2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public Int32 FTA2
	{
		get
		{
			return this.GetValue(TableUtils.FTA2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FTA2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FTA2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FTA2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA2 field.
	/// </summary>
	public string FTA2Default
	{
		get
		{
			return TableUtils.FTA2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public Int32 FTA1
	{
		get
		{
			return this.GetValue(TableUtils.FTA1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FTA1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FTA1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FTA1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.FTA1 field.
	/// </summary>
	public string FTA1Default
	{
		get
		{
			return TableUtils.FTA1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public Int32 Item1
	{
		get
		{
			return this.GetValue(TableUtils.Item1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1 field.
	/// </summary>
	public string Item1Default
	{
		get
		{
			return TableUtils.Item1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public Int32 Item2
	{
		get
		{
			return this.GetValue(TableUtils.Item2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2 field.
	/// </summary>
	public string Item2Default
	{
		get
		{
			return TableUtils.Item2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public bool Item1a
	{
		get
		{
			return this.GetValue(TableUtils.Item1aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item1aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item1aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item1aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item1a field.
	/// </summary>
	public string Item1aDefault
	{
		get
		{
			return TableUtils.Item1aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public bool Item2a
	{
		get
		{
			return this.GetValue(TableUtils.Item2aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item2aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item2aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item2aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item2a field.
	/// </summary>
	public string Item2aDefault
	{
		get
		{
			return TableUtils.Item2aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public Int32 Item3
	{
		get
		{
			return this.GetValue(TableUtils.Item3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3 field.
	/// </summary>
	public string Item3Default
	{
		get
		{
			return TableUtils.Item3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public Int32 Item4
	{
		get
		{
			return this.GetValue(TableUtils.Item4Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4 field.
	/// </summary>
	public string Item4Default
	{
		get
		{
			return TableUtils.Item4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public Int32 Item5
	{
		get
		{
			return this.GetValue(TableUtils.Item5Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item5Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item5Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item5Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5 field.
	/// </summary>
	public string Item5Default
	{
		get
		{
			return TableUtils.Item5Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public Int32 Item6
	{
		get
		{
			return this.GetValue(TableUtils.Item6Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item6Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item6Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item6Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6 field.
	/// </summary>
	public string Item6Default
	{
		get
		{
			return TableUtils.Item6Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public Int32 Item7
	{
		get
		{
			return this.GetValue(TableUtils.Item7Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Item7Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item7Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item7Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7 field.
	/// </summary>
	public string Item7Default
	{
		get
		{
			return TableUtils.Item7Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public bool Item3a
	{
		get
		{
			return this.GetValue(TableUtils.Item3aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item3aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item3aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item3aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item3a field.
	/// </summary>
	public string Item3aDefault
	{
		get
		{
			return TableUtils.Item3aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public bool Item4a
	{
		get
		{
			return this.GetValue(TableUtils.Item4aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item4aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item4aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item4aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item4a field.
	/// </summary>
	public string Item4aDefault
	{
		get
		{
			return TableUtils.Item4aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public bool Item5a
	{
		get
		{
			return this.GetValue(TableUtils.Item5aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item5aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item5aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item5aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item5a field.
	/// </summary>
	public string Item5aDefault
	{
		get
		{
			return TableUtils.Item5aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public bool Item6a
	{
		get
		{
			return this.GetValue(TableUtils.Item6aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item6aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item6aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item6aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item6a field.
	/// </summary>
	public string Item6aDefault
	{
		get
		{
			return TableUtils.Item6aColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public bool Item7a
	{
		get
		{
			return this.GetValue(TableUtils.Item7aColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Item7aColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Item7aSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Item7aColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_AllDataExtract_.Item7a field.
	/// </summary>
	public string Item7aDefault
	{
		get
		{
			return TableUtils.Item7aColumn.DefaultValue;
		}
	}


#endregion
}

}
