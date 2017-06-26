// This class is "generated" and will be overwritten.
// Your customizations should be made in HomeTownsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="HomeTownsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="HomeTownsTable"></see> class.
/// </remarks>
/// <seealso cref="HomeTownsTable"></seealso>
/// <seealso cref="HomeTownsRecord"></seealso>
public class BaseHomeTownsRecord : PrimaryKeyRecord
{

	public readonly static HomeTownsTable TableUtils = HomeTownsTable.Instance;

	// Constructors
 
	protected BaseHomeTownsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.HomeTownsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.HomeTownsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.HomeTownsRecord_ReadRecord); 
	}

	protected BaseHomeTownsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void HomeTownsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                HomeTownsRecord HomeTownsRec = (HomeTownsRecord)sender;
        if(HomeTownsRec != null && !HomeTownsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void HomeTownsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                HomeTownsRecord HomeTownsRec = (HomeTownsRecord)sender;
        Validate_Inserting();
        if(HomeTownsRec != null && !HomeTownsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void HomeTownsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                HomeTownsRecord HomeTownsRec = (HomeTownsRecord)sender;
        Validate_Updating();
        if(HomeTownsRec != null && !HomeTownsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's HomeTowns_.HomeTownId field.
	/// </summary>
	public ColumnValue GetHomeTownIdValue()
	{
		return this.GetValue(TableUtils.HomeTownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HomeTowns_.HomeTownId field.
	/// </summary>
	public Int32 GetHomeTownIdFieldValue()
	{
		return this.GetValue(TableUtils.HomeTownIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HomeTowns_.Name field.
	/// </summary>
	public ColumnValue GetNameValue()
	{
		return this.GetValue(TableUtils.NameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HomeTowns_.Name field.
	/// </summary>
	public string GetNameFieldValue()
	{
		return this.GetValue(TableUtils.NameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HomeTowns_.Name field.
	/// </summary>
	public void SetNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HomeTowns_.Name field.
	/// </summary>
	public void SetNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's HomeTowns_.HomeTownId field.
	/// </summary>
	public Int32 HomeTownId
	{
		get
		{
			return this.GetValue(TableUtils.HomeTownIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HomeTownIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HomeTownIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HomeTownIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HomeTowns_.HomeTownId field.
	/// </summary>
	public string HomeTownIdDefault
	{
		get
		{
			return TableUtils.HomeTownIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HomeTowns_.Name field.
	/// </summary>
	public string Name
	{
		get
		{
			return this.GetValue(TableUtils.NameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HomeTowns_.Name field.
	/// </summary>
	public string NameDefault
	{
		get
		{
			return TableUtils.NameColumn.DefaultValue;
		}
	}


#endregion
}

}
