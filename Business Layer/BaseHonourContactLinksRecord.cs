// This class is "generated" and will be overwritten.
// Your customizations should be made in HonourContactLinksRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="HonourContactLinksRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="HonourContactLinksTable"></see> class.
/// </remarks>
/// <seealso cref="HonourContactLinksTable"></seealso>
/// <seealso cref="HonourContactLinksRecord"></seealso>
public class BaseHonourContactLinksRecord : PrimaryKeyRecord
{

	public readonly static HonourContactLinksTable TableUtils = HonourContactLinksTable.Instance;

	// Constructors
 
	protected BaseHonourContactLinksRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.HonourContactLinksRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.HonourContactLinksRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.HonourContactLinksRecord_ReadRecord); 
	}

	protected BaseHonourContactLinksRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void HonourContactLinksRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                HonourContactLinksRecord HonourContactLinksRec = (HonourContactLinksRecord)sender;
        if(HonourContactLinksRec != null && !HonourContactLinksRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void HonourContactLinksRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                HonourContactLinksRecord HonourContactLinksRec = (HonourContactLinksRecord)sender;
        Validate_Inserting();
        if(HonourContactLinksRec != null && !HonourContactLinksRec.IsReadOnly ){
               HonourContactLinksRec.Parse(EvaluateFormula("\"false\"",this,null),HonourContactLinksTable.RecordDeleted);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void HonourContactLinksRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                HonourContactLinksRecord HonourContactLinksRec = (HonourContactLinksRecord)sender;
        Validate_Updating();
        if(HonourContactLinksRec != null && !HonourContactLinksRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public ColumnValue GetHonourIdValue()
	{
		return this.GetValue(TableUtils.HonourIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public Int32 GetHonourIdFieldValue()
	{
		return this.GetValue(TableUtils.HonourIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public void SetHonourIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HonourIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public void SetHonourIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.HonourIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public void SetHonourIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonourIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public void SetHonourIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonourIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public void SetHonourIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HonourIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.HonourContactLinkId field.
	/// </summary>
	public ColumnValue GetHonourContactLinkIdValue()
	{
		return this.GetValue(TableUtils.HonourContactLinkIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.HonourContactLinkId field.
	/// </summary>
	public Int32 GetHonourContactLinkIdFieldValue()
	{
		return this.GetValue(TableUtils.HonourContactLinkIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.RecordDeleted field.
	/// </summary>
	public ColumnValue GetRecordDeletedValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's HonourContactLinks_.RecordDeleted field.
	/// </summary>
	public bool GetRecordDeletedFieldValue()
	{
		return this.GetValue(TableUtils.RecordDeletedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RecordDeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.RecordDeleted field.
	/// </summary>
	public void SetRecordDeletedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RecordDeletedColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public Int32 HonourId
	{
		get
		{
			return this.GetValue(TableUtils.HonourIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HonourIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HonourIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HonourIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourId field.
	/// </summary>
	public string HonourIdDefault
	{
		get
		{
			return TableUtils.HonourIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonourContactLinks_.ContactId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonourContactLinks_.HonourContactLinkId field.
	/// </summary>
	public Int32 HonourContactLinkId
	{
		get
		{
			return this.GetValue(TableUtils.HonourContactLinkIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HonourContactLinkIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HonourContactLinkIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HonourContactLinkIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.HonourContactLinkId field.
	/// </summary>
	public string HonourContactLinkIdDefault
	{
		get
		{
			return TableUtils.HonourContactLinkIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's HonourContactLinks_.RecordDeleted field.
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
	/// This is a convenience method that allows direct modification of the value of the record's HonourContactLinks_.RecordDeleted field.
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
