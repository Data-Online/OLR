// This class is "generated" and will be overwritten.
// Your customizations should be made in ConfigurationRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="ConfigurationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ConfigurationTable"></see> class.
/// </remarks>
/// <seealso cref="ConfigurationTable"></seealso>
/// <seealso cref="ConfigurationRecord"></seealso>
public class BaseConfigurationRecord : PrimaryKeyRecord
{

	public readonly static ConfigurationTable TableUtils = ConfigurationTable.Instance;

	// Constructors
 
	protected BaseConfigurationRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ConfigurationRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ConfigurationRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ConfigurationRecord_ReadRecord); 
	}

	protected BaseConfigurationRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ConfigurationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ConfigurationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        Validate_Inserting();
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
               ConfigurationRec.Parse(EvaluateFormula("1",this,null),ConfigurationTable.EventId);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ConfigurationRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        Validate_Updating();
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
               ConfigurationRec.Parse(EvaluateFormula("1",this,null),ConfigurationTable.EventId);
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
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.ConfigurationId field.
	/// </summary>
	public ColumnValue GetConfigurationIdValue()
	{
		return this.GetValue(TableUtils.ConfigurationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.ConfigurationId field.
	/// </summary>
	public Int32 GetConfigurationIdFieldValue()
	{
		return this.GetValue(TableUtils.ConfigurationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public ColumnValue GetSendEmailCopiesValue()
	{
		return this.GetValue(TableUtils.SendEmailCopiesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public bool GetSendEmailCopiesFieldValue()
	{
		return this.GetValue(TableUtils.SendEmailCopiesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public void SetSendEmailCopiesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SendEmailCopiesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public void SetSendEmailCopiesFieldValue(string val)
	{
		this.SetString(val, TableUtils.SendEmailCopiesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public void SetSendEmailCopiesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SendEmailCopiesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public ColumnValue GetEmailCopiesAddressValue()
	{
		return this.GetValue(TableUtils.EmailCopiesAddressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public string GetEmailCopiesAddressFieldValue()
	{
		return this.GetValue(TableUtils.EmailCopiesAddressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public void SetEmailCopiesAddressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailCopiesAddressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public void SetEmailCopiesAddressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailCopiesAddressColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Configuration_.ConfigurationId field.
	/// </summary>
	public Int32 ConfigurationId
	{
		get
		{
			return this.GetValue(TableUtils.ConfigurationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ConfigurationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ConfigurationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ConfigurationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.ConfigurationId field.
	/// </summary>
	public string ConfigurationIdDefault
	{
		get
		{
			return TableUtils.ConfigurationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Configuration_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public bool SendEmailCopies
	{
		get
		{
			return this.GetValue(TableUtils.SendEmailCopiesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.SendEmailCopiesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SendEmailCopiesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SendEmailCopiesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.SendEmailCopies field.
	/// </summary>
	public string SendEmailCopiesDefault
	{
		get
		{
			return TableUtils.SendEmailCopiesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public string EmailCopiesAddress
	{
		get
		{
			return this.GetValue(TableUtils.EmailCopiesAddressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EmailCopiesAddressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EmailCopiesAddressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EmailCopiesAddressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Configuration_.EmailCopiesAddress field.
	/// </summary>
	public string EmailCopiesAddressDefault
	{
		get
		{
			return TableUtils.EmailCopiesAddressColumn.DefaultValue;
		}
	}


#endregion
}

}
