// This class is "generated" and will be overwritten.
// Your customizations should be made in HonorContactLinksRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="HonorContactLinksRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="HonorContactLinksTable"></see> class.
/// </remarks>
/// <seealso cref="HonorContactLinksTable"></seealso>
/// <seealso cref="HonorContactLinksRecord"></seealso>
public class BaseHonorContactLinksRecord : PrimaryKeyRecord
{

	public readonly static HonorContactLinksTable TableUtils = HonorContactLinksTable.Instance;

	// Constructors
 
	protected BaseHonorContactLinksRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.HonorContactLinksRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.HonorContactLinksRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.HonorContactLinksRecord_ReadRecord); 
	}

	protected BaseHonorContactLinksRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void HonorContactLinksRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                HonorContactLinksRecord HonorContactLinksRec = (HonorContactLinksRecord)sender;
        if(HonorContactLinksRec != null && !HonorContactLinksRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void HonorContactLinksRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                HonorContactLinksRecord HonorContactLinksRec = (HonorContactLinksRecord)sender;
        Validate_Inserting();
        if(HonorContactLinksRec != null && !HonorContactLinksRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void HonorContactLinksRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                HonorContactLinksRecord HonorContactLinksRec = (HonorContactLinksRecord)sender;
        Validate_Updating();
        if(HonorContactLinksRec != null && !HonorContactLinksRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public ColumnValue GetHonorIdValue()
	{
		return this.GetValue(TableUtils.HonorIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public Int32 GetHonorIdFieldValue()
	{
		return this.GetValue(TableUtils.HonorIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public void SetHonorIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HonorIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public void SetHonorIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.HonorIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public void SetHonorIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonorIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public void SetHonorIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonorIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public void SetHonorIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonorIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.HonorContactLinkId field.
	/// </summary>
	public ColumnValue GetHonorContactLinkIdValue()
	{
		return this.GetValue(TableUtils.HonorContactLinkIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonorContactLinks_.HonorContactLinkId field.
	/// </summary>
	public Int32 GetHonorContactLinkIdFieldValue()
	{
		return this.GetValue(TableUtils.HonorContactLinkIdColumn).ToInt32();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public Int32 HonorId
	{
		get
		{
			return this.GetValue(TableUtils.HonorIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HonorIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HonorIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HonorIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorId field.
	/// </summary>
	public string HonorIdDefault
	{
		get
		{
			return TableUtils.HonorIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonorContactLinks_.ContactId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonorContactLinks_.HonorContactLinkId field.
	/// </summary>
	public Int32 HonorContactLinkId
	{
		get
		{
			return this.GetValue(TableUtils.HonorContactLinkIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HonorContactLinkIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HonorContactLinkIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HonorContactLinkIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonorContactLinks_.HonorContactLinkId field.
	/// </summary>
	public string HonorContactLinkIdDefault
	{
		get
		{
			return TableUtils.HonorContactLinkIdColumn.DefaultValue;
		}
	}


#endregion
}

}
