// This class is "generated" and will be overwritten.
// Your customizations should be made in FieldTripChoicesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="FieldTripChoicesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="FieldTripChoicesTable"></see> class.
/// </remarks>
/// <seealso cref="FieldTripChoicesTable"></seealso>
/// <seealso cref="FieldTripChoicesRecord"></seealso>
public class BaseFieldTripChoicesRecord : PrimaryKeyRecord
{

	public readonly static FieldTripChoicesTable TableUtils = FieldTripChoicesTable.Instance;

	// Constructors
 
	protected BaseFieldTripChoicesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.FieldTripChoicesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.FieldTripChoicesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.FieldTripChoicesRecord_ReadRecord); 
	}

	protected BaseFieldTripChoicesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void FieldTripChoicesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                FieldTripChoicesRecord FieldTripChoicesRec = (FieldTripChoicesRecord)sender;
        if(FieldTripChoicesRec != null && !FieldTripChoicesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void FieldTripChoicesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                FieldTripChoicesRecord FieldTripChoicesRec = (FieldTripChoicesRecord)sender;
        Validate_Inserting();
        if(FieldTripChoicesRec != null && !FieldTripChoicesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void FieldTripChoicesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                FieldTripChoicesRecord FieldTripChoicesRec = (FieldTripChoicesRecord)sender;
        Validate_Updating();
        if(FieldTripChoicesRec != null && !FieldTripChoicesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripChoiceId field.
	/// </summary>
	public ColumnValue GetFieldTripChoiceIdValue()
	{
		return this.GetValue(TableUtils.FieldTripChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripChoiceId field.
	/// </summary>
	public Int32 GetFieldTripChoiceIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripChoiceIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public ColumnValue GetFieldTripOptionIdValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public Int32 GetFieldTripOptionIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public ColumnValue GetRegistrationIdValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public Int32 GetRegistrationIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public void SetRegistrationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public ColumnValue GetFieldTripOptionId2Value()
	{
		return this.GetValue(TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public Int32 GetFieldTripOptionId2FieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionId2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public ColumnValue GetFieldTripOptionId3Value()
	{
		return this.GetValue(TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public Int32 GetFieldTripOptionId3FieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionId3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public ColumnValue GetFieldTripIdValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public Int32 GetFieldTripIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public ColumnValue GetRecordDeletedValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public bool GetRecordDeletedFieldValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RecordDeletedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public ColumnValue GetFieldTripAllocatedValue()
	{
		return this.GetValue(TableUtils.FieldTripAllocatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public Int32 GetFieldTripAllocatedFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripAllocatedColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public void SetFieldTripAllocatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripAllocatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public void SetFieldTripAllocatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripAllocatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public void SetFieldTripAllocatedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripAllocatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public void SetFieldTripAllocatedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripAllocatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public void SetFieldTripAllocatedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripAllocatedColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripChoiceId field.
	/// </summary>
	public Int32 FieldTripChoiceId
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripChoiceIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripChoiceIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripChoiceIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripChoiceIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripChoiceId field.
	/// </summary>
	public string FieldTripChoiceIdDefault
	{
		get
		{
			return TableUtils.FieldTripChoiceIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public Int32 FieldTripOptionId
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripOptionIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripOptionIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripOptionIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId field.
	/// </summary>
	public string FieldTripOptionIdDefault
	{
		get
		{
			return TableUtils.FieldTripOptionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.RegistrationId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RegistrationId field.
	/// </summary>
	public string RegistrationIdDefault
	{
		get
		{
			return TableUtils.RegistrationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public Int32 FieldTripOptionId2
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripOptionId2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripOptionId2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripOptionId2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId2 field.
	/// </summary>
	public string FieldTripOptionId2Default
	{
		get
		{
			return TableUtils.FieldTripOptionId2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public Int32 FieldTripOptionId3
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripOptionId3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripOptionId3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripOptionId3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripOptionId3 field.
	/// </summary>
	public string FieldTripOptionId3Default
	{
		get
		{
			return TableUtils.FieldTripOptionId3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public Int32 FieldTripId
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripId field.
	/// </summary>
	public string FieldTripIdDefault
	{
		get
		{
			return TableUtils.FieldTripIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.RecordDeleted field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.RecordDeleted field.
	/// </summary>
	public string RecordDeletedDefault
	{
		get
		{
			return TableUtils.RecordDeletedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public Int32 FieldTripAllocated
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripAllocatedColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripAllocatedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripAllocatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripAllocatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripChoices_.FieldTripAllocated field.
	/// </summary>
	public string FieldTripAllocatedDefault
	{
		get
		{
			return TableUtils.FieldTripAllocatedColumn.DefaultValue;
		}
	}


#endregion
}

}
