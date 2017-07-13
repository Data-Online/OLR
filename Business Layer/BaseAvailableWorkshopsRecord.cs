// This class is "generated" and will be overwritten.
// Your customizations should be made in AvailableWorkshopsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="AvailableWorkshopsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AvailableWorkshopsTable"></see> class.
/// </remarks>
/// <seealso cref="AvailableWorkshopsTable"></seealso>
/// <seealso cref="AvailableWorkshopsRecord"></seealso>
public class BaseAvailableWorkshopsRecord : PrimaryKeyRecord
{

	public readonly static AvailableWorkshopsTable TableUtils = AvailableWorkshopsTable.Instance;

	// Constructors
 
	protected BaseAvailableWorkshopsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AvailableWorkshopsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AvailableWorkshopsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AvailableWorkshopsRecord_ReadRecord); 
	}

	protected BaseAvailableWorkshopsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AvailableWorkshopsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AvailableWorkshopsRecord AvailableWorkshopsRec = (AvailableWorkshopsRecord)sender;
        if(AvailableWorkshopsRec != null && !AvailableWorkshopsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AvailableWorkshopsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AvailableWorkshopsRecord AvailableWorkshopsRec = (AvailableWorkshopsRecord)sender;
        Validate_Inserting();
        if(AvailableWorkshopsRec != null && !AvailableWorkshopsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AvailableWorkshopsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AvailableWorkshopsRecord AvailableWorkshopsRec = (AvailableWorkshopsRecord)sender;
        Validate_Updating();
        if(AvailableWorkshopsRec != null && !AvailableWorkshopsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.AvailableWorkshopId field.
	/// </summary>
	public ColumnValue GetAvailableWorkshopIdValue()
	{
		return this.GetValue(TableUtils.AvailableWorkshopIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.AvailableWorkshopId field.
	/// </summary>
	public Int32 GetAvailableWorkshopIdFieldValue()
	{
		return this.GetValue(TableUtils.AvailableWorkshopIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public ColumnValue GetWorkshopDescriptionValue()
	{
		return this.GetValue(TableUtils.WorkshopDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public string GetWorkshopDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.WorkshopDescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public void SetWorkshopDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.WorkshopDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public void SetWorkshopDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.WorkshopDescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public ColumnValue GetPlacesAvailableValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public Int32 GetPlacesAvailableFieldValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(string val)
	{
		this.SetString(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AvailableWorkshops_.AvailableWorkshopId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.AvailableWorkshopId field.
	/// </summary>
	public string AvailableWorkshopIdDefault
	{
		get
		{
			return TableUtils.AvailableWorkshopIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AvailableWorkshops_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public string WorkshopDescription
	{
		get
		{
			return this.GetValue(TableUtils.WorkshopDescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.WorkshopDescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool WorkshopDescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.WorkshopDescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.WorkshopDescription field.
	/// </summary>
	public string WorkshopDescriptionDefault
	{
		get
		{
			return TableUtils.WorkshopDescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public Int32 PlacesAvailable
	{
		get
		{
			return this.GetValue(TableUtils.PlacesAvailableColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlacesAvailableColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlacesAvailableSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlacesAvailableColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AvailableWorkshops_.PlacesAvailable field.
	/// </summary>
	public string PlacesAvailableDefault
	{
		get
		{
			return TableUtils.PlacesAvailableColumn.DefaultValue;
		}
	}


#endregion
}

}
