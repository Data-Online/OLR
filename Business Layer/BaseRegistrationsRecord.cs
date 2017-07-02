// This class is "generated" and will be overwritten.
// Your customizations should be made in RegistrationsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="RegistrationsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RegistrationsTable"></see> class.
/// </remarks>
/// <seealso cref="RegistrationsTable"></seealso>
/// <seealso cref="RegistrationsRecord"></seealso>
public class BaseRegistrationsRecord : PrimaryKeyRecord
{

	public readonly static RegistrationsTable TableUtils = RegistrationsTable.Instance;

	// Constructors
 
	protected BaseRegistrationsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RegistrationsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RegistrationsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RegistrationsRecord_ReadRecord); 
	}

	protected BaseRegistrationsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RegistrationsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RegistrationsRecord RegistrationsRec = (RegistrationsRecord)sender;
        if(RegistrationsRec != null && !RegistrationsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RegistrationsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RegistrationsRecord RegistrationsRec = (RegistrationsRecord)sender;
        Validate_Inserting();
        if(RegistrationsRec != null && !RegistrationsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RegistrationsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RegistrationsRecord RegistrationsRec = (RegistrationsRecord)sender;
        Validate_Updating();
        if(RegistrationsRec != null && !RegistrationsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.RegistrationId field.
	/// </summary>
	public ColumnValue GetRegistrationIdValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.RegistrationId field.
	/// </summary>
	public Int32 GetRegistrationIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public ColumnValue GetValidationUidValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public System.Guid GetValidationUidFieldValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn).ToGuid();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(string val)
	{
		this.SetString(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(System.Guid val)
	{
		ColumnValue cv = new ColumnValue(val, System.TypeCode.Object);
		this.SetValue(cv, TableUtils.ValidationUidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public ColumnValue GetRegistrationTypeIdValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public Int32 GetRegistrationTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public void SetRegistrationTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public void SetRegistrationTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public void SetRegistrationTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public void SetRegistrationTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public void SetRegistrationTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationTypeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public ColumnValue GetAdditionalDinnerTicketValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public bool GetAdditionalDinnerTicketFieldValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerTicketColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(string val)
	{
		this.SetString(val, TableUtils.AdditionalDinnerTicketColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public void SetAdditionalDinnerTicketFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdditionalDinnerTicketColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.SpecialRequirements field.
	/// </summary>
	public ColumnValue GetSpecialRequirementsValue()
	{
		return this.GetValue(TableUtils.SpecialRequirementsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.SpecialRequirements field.
	/// </summary>
	public string GetSpecialRequirementsFieldValue()
	{
		return this.GetValue(TableUtils.SpecialRequirementsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.SpecialRequirements field.
	/// </summary>
	public void SetSpecialRequirementsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SpecialRequirementsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.SpecialRequirements field.
	/// </summary>
	public void SetSpecialRequirementsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpecialRequirementsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.AdditionalDinnerName field.
	/// </summary>
	public ColumnValue GetAdditionalDinnerNameValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.AdditionalDinnerName field.
	/// </summary>
	public string GetAdditionalDinnerNameFieldValue()
	{
		return this.GetValue(TableUtils.AdditionalDinnerNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerName field.
	/// </summary>
	public void SetAdditionalDinnerNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdditionalDinnerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerName field.
	/// </summary>
	public void SetAdditionalDinnerNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdditionalDinnerNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public ColumnValue GetDatePaidValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public DateTime GetDatePaidFieldValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(string val)
	{
		this.SetString(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DatePaidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public ColumnValue GetInitialCreationDateValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public DateTime GetInitialCreationDateFieldValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InitialCreationDateColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.RegistrationId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationId field.
	/// </summary>
	public string RegistrationIdDefault
	{
		get
		{
			return TableUtils.RegistrationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.EventId field.
	/// </summary>
	public Int32 EventId
	{
		get
		{
			return this.GetValue(TableUtils.EventIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EventIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EventIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EventIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.ContactId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.ValidationUid field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.ValidationUid field.
	/// </summary>
	public string ValidationUidDefault
	{
		get
		{
			return TableUtils.ValidationUidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public Int32 RegistrationTypeId
	{
		get
		{
			return this.GetValue(TableUtils.RegistrationTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegistrationTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegistrationTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegistrationTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.RegistrationTypeId field.
	/// </summary>
	public string RegistrationTypeIdDefault
	{
		get
		{
			return TableUtils.RegistrationTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.AdditionalDinnerTicket field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerTicket field.
	/// </summary>
	public string AdditionalDinnerTicketDefault
	{
		get
		{
			return TableUtils.AdditionalDinnerTicketColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.SpecialRequirements field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.SpecialRequirements field.
	/// </summary>
	public string SpecialRequirementsDefault
	{
		get
		{
			return TableUtils.SpecialRequirementsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.AdditionalDinnerName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.AdditionalDinnerName field.
	/// </summary>
	public string AdditionalDinnerNameDefault
	{
		get
		{
			return TableUtils.AdditionalDinnerNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.DatePaid field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.DatePaid field.
	/// </summary>
	public string DatePaidDefault
	{
		get
		{
			return TableUtils.DatePaidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Registrations_.InitialCreationDate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Registrations_.InitialCreationDate field.
	/// </summary>
	public string InitialCreationDateDefault
	{
		get
		{
			return TableUtils.InitialCreationDateColumn.DefaultValue;
		}
	}


#endregion
}

}
