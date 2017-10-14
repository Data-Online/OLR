// This class is "generated" and will be overwritten.
// Your customizations should be made in EventsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="EventsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EventsTable"></see> class.
/// </remarks>
/// <seealso cref="EventsTable"></seealso>
/// <seealso cref="EventsRecord"></seealso>
public class BaseEventsRecord : PrimaryKeyRecord
{

	public readonly static EventsTable TableUtils = EventsTable.Instance;

	// Constructors
 
	protected BaseEventsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EventsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EventsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EventsRecord_ReadRecord); 
	}

	protected BaseEventsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EventsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EventsRecord EventsRec = (EventsRecord)sender;
        if(EventsRec != null && !EventsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EventsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EventsRecord EventsRec = (EventsRecord)sender;
        Validate_Inserting();
        if(EventsRec != null && !EventsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EventsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EventsRecord EventsRec = (EventsRecord)sender;
        Validate_Updating();
        if(EventsRec != null && !EventsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Events_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.EventName field.
	/// </summary>
	public ColumnValue GetEventNameValue()
	{
		return this.GetValue(TableUtils.EventNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.EventName field.
	/// </summary>
	public string GetEventNameFieldValue()
	{
		return this.GetValue(TableUtils.EventNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.EventName field.
	/// </summary>
	public void SetEventNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.EventName field.
	/// </summary>
	public void SetEventNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.GID field.
	/// </summary>
	public ColumnValue GetGIDValue()
	{
		return this.GetValue(TableUtils.GIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.GID field.
	/// </summary>
	public System.Guid GetGIDFieldValue()
	{
		return this.GetValue(TableUtils.GIDColumn).ToGuid();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.GID field.
	/// </summary>
	public void SetGIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.GID field.
	/// </summary>
	public void SetGIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.GIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.GID field.
	/// </summary>
	public void SetGIDFieldValue(System.Guid val)
	{
		ColumnValue cv = new ColumnValue(val, System.TypeCode.Object);
		this.SetValue(cv, TableUtils.GIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.Active field.
	/// </summary>
	public ColumnValue GetActiveValue()
	{
		return this.GetValue(TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.Active field.
	/// </summary>
	public bool GetActiveFieldValue()
	{
		return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.Active field.
	/// </summary>
	public void SetActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.Active field.
	/// </summary>
	public void SetActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.Active field.
	/// </summary>
	public void SetActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.ContactEmail field.
	/// </summary>
	public ColumnValue GetContactEmailValue()
	{
		return this.GetValue(TableUtils.ContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.ContactEmail field.
	/// </summary>
	public string GetContactEmailFieldValue()
	{
		return this.GetValue(TableUtils.ContactEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.ContactEmail field.
	/// </summary>
	public void SetContactEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.ContactEmail field.
	/// </summary>
	public void SetContactEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.AccountNumber field.
	/// </summary>
	public ColumnValue GetAccountNumberValue()
	{
		return this.GetValue(TableUtils.AccountNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Events_.AccountNumber field.
	/// </summary>
	public string GetAccountNumberFieldValue()
	{
		return this.GetValue(TableUtils.AccountNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.AccountNumber field.
	/// </summary>
	public void SetAccountNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccountNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.AccountNumber field.
	/// </summary>
	public void SetAccountNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccountNumberColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Events_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.EventName field.
	/// </summary>
	public string EventName
	{
		get
		{
			return this.GetValue(TableUtils.EventNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EventNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EventNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EventNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.EventName field.
	/// </summary>
	public string EventNameDefault
	{
		get
		{
			return TableUtils.EventNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.GID field.
	/// </summary>
	public System.Guid GID
	{
		get
		{
			return this.GetValue(TableUtils.GIDColumn).ToGuid();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value, System.TypeCode.Object);
			this.SetValue(cv, TableUtils.GIDColumn);
		}
	}
		

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.GID field.
	/// </summary>
	public string GIDDefault
	{
		get
		{
			return TableUtils.GIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.Active field.
	/// </summary>
	public bool Active
	{
		get
		{
			return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ActiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.Active field.
	/// </summary>
	public string ActiveDefault
	{
		get
		{
			return TableUtils.ActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.ContactEmail field.
	/// </summary>
	public string ContactEmail
	{
		get
		{
			return this.GetValue(TableUtils.ContactEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.ContactEmail field.
	/// </summary>
	public string ContactEmailDefault
	{
		get
		{
			return TableUtils.ContactEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Events_.AccountNumber field.
	/// </summary>
	public string AccountNumber
	{
		get
		{
			return this.GetValue(TableUtils.AccountNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccountNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccountNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccountNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Events_.AccountNumber field.
	/// </summary>
	public string AccountNumberDefault
	{
		get
		{
			return TableUtils.AccountNumberColumn.DefaultValue;
		}
	}


#endregion
}

}
