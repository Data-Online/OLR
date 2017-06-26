// This class is "generated" and will be overwritten.
// Your customizations should be made in FieldTripsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="FieldTripsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="FieldTripsTable"></see> class.
/// </remarks>
/// <seealso cref="FieldTripsTable"></seealso>
/// <seealso cref="FieldTripsRecord"></seealso>
public class BaseFieldTripsRecord : PrimaryKeyRecord
{

	public readonly static FieldTripsTable TableUtils = FieldTripsTable.Instance;

	// Constructors
 
	protected BaseFieldTripsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.FieldTripsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.FieldTripsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.FieldTripsRecord_ReadRecord); 
	}

	protected BaseFieldTripsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void FieldTripsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                FieldTripsRecord FieldTripsRec = (FieldTripsRecord)sender;
        if(FieldTripsRec != null && !FieldTripsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void FieldTripsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                FieldTripsRecord FieldTripsRec = (FieldTripsRecord)sender;
        Validate_Inserting();
        if(FieldTripsRec != null && !FieldTripsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void FieldTripsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                FieldTripsRecord FieldTripsRec = (FieldTripsRecord)sender;
        Validate_Updating();
        if(FieldTripsRec != null && !FieldTripsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.FieldTripId field.
	/// </summary>
	public ColumnValue GetFieldTripIdValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.FieldTripId field.
	/// </summary>
	public Int32 GetFieldTripIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Date field.
	/// </summary>
	public ColumnValue GetDate0Value()
	{
		return this.GetValue(TableUtils.Date0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Date field.
	/// </summary>
	public DateTime GetDate0FieldValue()
	{
		return this.GetValue(TableUtils.Date0Column).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Date field.
	/// </summary>
	public void SetDate0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Date0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Date field.
	/// </summary>
	public void SetDate0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Date0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Date field.
	/// </summary>
	public void SetDate0FieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Date0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Time field.
	/// </summary>
	public ColumnValue GetTimeValue()
	{
		return this.GetValue(TableUtils.TimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.Time field.
	/// </summary>
	public DateTime GetTimeFieldValue()
	{
		return this.GetValue(TableUtils.TimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Time field.
	/// </summary>
	public void SetTimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Time field.
	/// </summary>
	public void SetTimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.TimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Time field.
	/// </summary>
	public void SetTimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public ColumnValue GetDisplaySequenceValue()
	{
		return this.GetValue(TableUtils.DisplaySequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public Int32 GetDisplaySequenceFieldValue()
	{
		return this.GetValue(TableUtils.DisplaySequenceColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public void SetDisplaySequenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DisplaySequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public void SetDisplaySequenceFieldValue(string val)
	{
		this.SetString(val, TableUtils.DisplaySequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public void SetDisplaySequenceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DisplaySequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public void SetDisplaySequenceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DisplaySequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public void SetDisplaySequenceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DisplaySequenceColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.FieldTripId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.FieldTripId field.
	/// </summary>
	public string FieldTripIdDefault
	{
		get
		{
			return TableUtils.FieldTripIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.Description field.
	/// </summary>
	public string Description
	{
		get
		{
			return this.GetValue(TableUtils.DescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.Date field.
	/// </summary>
	public DateTime Date0
	{
		get
		{
			return this.GetValue(TableUtils.Date0Column).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Date0Column);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Date0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Date0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Date field.
	/// </summary>
	public string Date0Default
	{
		get
		{
			return TableUtils.Date0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.Time field.
	/// </summary>
	public DateTime Time
	{
		get
		{
			return this.GetValue(TableUtils.TimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.Time field.
	/// </summary>
	public string TimeDefault
	{
		get
		{
			return TableUtils.TimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public Int32 DisplaySequence
	{
		get
		{
			return this.GetValue(TableUtils.DisplaySequenceColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DisplaySequenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DisplaySequenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DisplaySequenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTrips_.DisplaySequence field.
	/// </summary>
	public string DisplaySequenceDefault
	{
		get
		{
			return TableUtils.DisplaySequenceColumn.DefaultValue;
		}
	}


#endregion
}

}
