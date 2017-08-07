// This class is "generated" and will be overwritten.
// Your customizations should be made in OtherCostsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="OtherCostsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="OtherCostsTable"></see> class.
/// </remarks>
/// <seealso cref="OtherCostsTable"></seealso>
/// <seealso cref="OtherCostsRecord"></seealso>
public class BaseOtherCostsRecord : PrimaryKeyRecord
{

	public readonly static OtherCostsTable TableUtils = OtherCostsTable.Instance;

	// Constructors
 
	protected BaseOtherCostsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.OtherCostsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.OtherCostsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.OtherCostsRecord_ReadRecord); 
	}

	protected BaseOtherCostsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void OtherCostsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                OtherCostsRecord OtherCostsRec = (OtherCostsRecord)sender;
        if(OtherCostsRec != null && !OtherCostsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void OtherCostsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                OtherCostsRecord OtherCostsRec = (OtherCostsRecord)sender;
        Validate_Inserting();
        if(OtherCostsRec != null && !OtherCostsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void OtherCostsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                OtherCostsRecord OtherCostsRec = (OtherCostsRecord)sender;
        Validate_Updating();
        if(OtherCostsRec != null && !OtherCostsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.OtherCostId field.
	/// </summary>
	public ColumnValue GetOtherCostIdValue()
	{
		return this.GetValue(TableUtils.OtherCostIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.OtherCostId field.
	/// </summary>
	public Int32 GetOtherCostIdFieldValue()
	{
		return this.GetValue(TableUtils.OtherCostIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public ColumnValue GetCostDescriptionValue()
	{
		return this.GetValue(TableUtils.CostDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public string GetCostDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.CostDescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public void SetCostDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CostDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public void SetCostDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostDescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public ColumnValue GetCostValue()
	{
		return this.GetValue(TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public Decimal GetCostFieldValue()
	{
		return this.GetValue(TableUtils.CostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public void SetCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public void SetCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public void SetCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public void SetCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public void SetCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCosts_.OtherCostId field.
	/// </summary>
	public Int32 OtherCostId
	{
		get
		{
			return this.GetValue(TableUtils.OtherCostIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherCostIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherCostIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherCostIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.OtherCostId field.
	/// </summary>
	public string OtherCostIdDefault
	{
		get
		{
			return TableUtils.OtherCostIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public string CostDescription
	{
		get
		{
			return this.GetValue(TableUtils.CostDescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CostDescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CostDescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CostDescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.CostDescription field.
	/// </summary>
	public string CostDescriptionDefault
	{
		get
		{
			return TableUtils.CostDescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCosts_.Cost field.
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
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.Cost field.
	/// </summary>
	public string CostDefault
	{
		get
		{
			return TableUtils.CostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCosts_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's OtherCosts_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}


#endregion
}

}
