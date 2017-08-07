// This class is "generated" and will be overwritten.
// Your customizations should be made in FieldTripOptionsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="FieldTripOptionsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="FieldTripOptionsTable"></see> class.
/// </remarks>
/// <seealso cref="FieldTripOptionsTable"></seealso>
/// <seealso cref="FieldTripOptionsRecord"></seealso>
public class BaseFieldTripOptionsRecord : PrimaryKeyRecord
{

	public readonly static FieldTripOptionsTable TableUtils = FieldTripOptionsTable.Instance;

	// Constructors
 
	protected BaseFieldTripOptionsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.FieldTripOptionsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.FieldTripOptionsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.FieldTripOptionsRecord_ReadRecord); 
	}

	protected BaseFieldTripOptionsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void FieldTripOptionsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                FieldTripOptionsRecord FieldTripOptionsRec = (FieldTripOptionsRecord)sender;
        if(FieldTripOptionsRec != null && !FieldTripOptionsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void FieldTripOptionsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                FieldTripOptionsRecord FieldTripOptionsRec = (FieldTripOptionsRecord)sender;
        Validate_Inserting();
        if(FieldTripOptionsRec != null && !FieldTripOptionsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void FieldTripOptionsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                FieldTripOptionsRecord FieldTripOptionsRec = (FieldTripOptionsRecord)sender;
        Validate_Updating();
        if(FieldTripOptionsRec != null && !FieldTripOptionsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.FieldTripOptionId field.
	/// </summary>
	public ColumnValue GetFieldTripOptionIdValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.FieldTripOptionId field.
	/// </summary>
	public Int32 GetFieldTripOptionIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public ColumnValue GetFieldTripIdValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public Int32 GetFieldTripIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public ColumnValue GetPlacesAvailableValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public Int32 GetPlacesAvailableFieldValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(string val)
	{
		this.SetString(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public ColumnValue GetCostValue()
	{
		return this.GetValue(TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public Decimal GetCostFieldValue()
	{
		return this.GetValue(TableUtils.CostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public void SetCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public void SetCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public void SetCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public void SetCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public void SetCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripOptions_.FieldTripOptionId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripOptionId field.
	/// </summary>
	public string FieldTripOptionIdDefault
	{
		get
		{
			return TableUtils.FieldTripOptionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripOptions_.FieldTripId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.FieldTripId field.
	/// </summary>
	public string FieldTripIdDefault
	{
		get
		{
			return TableUtils.FieldTripIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripOptions_.PlacesAvailable field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.PlacesAvailable field.
	/// </summary>
	public string PlacesAvailableDefault
	{
		get
		{
			return TableUtils.PlacesAvailableColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripOptions_.Description field.
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
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public Decimal Cost
	{
		get
		{
			return this.GetValue(TableUtils.CostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's FieldTripOptions_.Cost field.
	/// </summary>
	public string CostDefault
	{
		get
		{
			return TableUtils.CostColumn.DefaultValue;
		}
	}


#endregion
}

}
