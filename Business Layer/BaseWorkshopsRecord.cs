// This class is "generated" and will be overwritten.
// Your customizations should be made in WorkshopsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="WorkshopsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="WorkshopsTable"></see> class.
/// </remarks>
/// <seealso cref="WorkshopsTable"></seealso>
/// <seealso cref="WorkshopsRecord"></seealso>
public class BaseWorkshopsRecord : PrimaryKeyRecord
{

	public readonly static WorkshopsTable TableUtils = WorkshopsTable.Instance;

	// Constructors
 
	protected BaseWorkshopsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.WorkshopsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.WorkshopsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.WorkshopsRecord_ReadRecord); 
	}

	protected BaseWorkshopsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void WorkshopsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                WorkshopsRecord WorkshopsRec = (WorkshopsRecord)sender;
        if(WorkshopsRec != null && !WorkshopsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void WorkshopsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                WorkshopsRecord WorkshopsRec = (WorkshopsRecord)sender;
        Validate_Inserting();
        if(WorkshopsRec != null && !WorkshopsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void WorkshopsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                WorkshopsRecord WorkshopsRec = (WorkshopsRecord)sender;
        Validate_Updating();
        if(WorkshopsRec != null && !WorkshopsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.WorkshopId field.
	/// </summary>
	public ColumnValue GetWorkshopIdValue()
	{
		return this.GetValue(TableUtils.WorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.WorkshopId field.
	/// </summary>
	public Int32 GetWorkshopIdFieldValue()
	{
		return this.GetValue(TableUtils.WorkshopIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public ColumnValue GetRegistrationIdValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public Int32 GetRegistrationIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public ColumnValue GetAvailableWorkshopIdValue()
	{
		return this.GetValue(TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public Int32 GetAvailableWorkshopIdFieldValue()
	{
		return this.GetValue(TableUtils.AvailableWorkshopIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public void SetAvailableWorkshopIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public void SetAvailableWorkshopIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public void SetAvailableWorkshopIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public void SetAvailableWorkshopIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public void SetAvailableWorkshopIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AvailableWorkshopIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.Attending field.
	/// </summary>
	public ColumnValue GetAttendingValue()
	{
		return this.GetValue(TableUtils.AttendingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.Attending field.
	/// </summary>
	public bool GetAttendingFieldValue()
	{
		return this.GetValue(TableUtils.AttendingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.Attending field.
	/// </summary>
	public void SetAttendingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.Attending field.
	/// </summary>
	public void SetAttendingFieldValue(string val)
	{
		this.SetString(val, TableUtils.AttendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.Attending field.
	/// </summary>
	public void SetAttendingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttendingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public ColumnValue GetRecordDeletedValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public bool GetRecordDeletedFieldValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RecordDeletedColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Workshops_.WorkshopId field.
	/// </summary>
	public Int32 WorkshopId
	{
		get
		{
			return this.GetValue(TableUtils.WorkshopIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.WorkshopIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool WorkshopIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.WorkshopIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.WorkshopId field.
	/// </summary>
	public string WorkshopIdDefault
	{
		get
		{
			return TableUtils.WorkshopIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Workshops_.RegistrationId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RegistrationId field.
	/// </summary>
	public string RegistrationIdDefault
	{
		get
		{
			return TableUtils.RegistrationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public Int32 AvailableWorkshopId
	{
		get
		{
			return this.GetValue(TableUtils.AvailableWorkshopIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AvailableWorkshopIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AvailableWorkshopIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AvailableWorkshopIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.AvailableWorkshopId field.
	/// </summary>
	public string AvailableWorkshopIdDefault
	{
		get
		{
			return TableUtils.AvailableWorkshopIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Workshops_.Attending field.
	/// </summary>
	public bool Attending
	{
		get
		{
			return this.GetValue(TableUtils.AttendingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.AttendingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttendingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttendingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.Attending field.
	/// </summary>
	public string AttendingDefault
	{
		get
		{
			return TableUtils.AttendingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public bool RecordDeleted
	{
		get
		{
			return this.GetValue(TableUtils.RecordDeletedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RecordDeletedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RecordDeletedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RecordDeletedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Workshops_.RecordDeleted field.
	/// </summary>
	public string RecordDeletedDefault
	{
		get
		{
			return TableUtils.RecordDeletedColumn.DefaultValue;
		}
	}


#endregion
}

}
