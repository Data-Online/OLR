﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in RegistrationTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="RegistrationTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RegistrationTypesTable"></see> class.
/// </remarks>
/// <seealso cref="RegistrationTypesTable"></seealso>
/// <seealso cref="RegistrationTypesRecord"></seealso>
public class BaseRegistrationTypesRecord : PrimaryKeyRecord
{

	public readonly static RegistrationTypesTable TableUtils = RegistrationTypesTable.Instance;

	// Constructors
 
	protected BaseRegistrationTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RegistrationTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RegistrationTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RegistrationTypesRecord_ReadRecord); 
	}

	protected BaseRegistrationTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RegistrationTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RegistrationTypesRecord RegistrationTypesRec = (RegistrationTypesRecord)sender;
        if(RegistrationTypesRec != null && !RegistrationTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RegistrationTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RegistrationTypesRecord RegistrationTypesRec = (RegistrationTypesRecord)sender;
        Validate_Inserting();
        if(RegistrationTypesRec != null && !RegistrationTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RegistrationTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RegistrationTypesRecord RegistrationTypesRec = (RegistrationTypesRecord)sender;
        Validate_Updating();
        if(RegistrationTypesRec != null && !RegistrationTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.RegistrationTypeId field.
	/// </summary>
	public ColumnValue GetRegistrationTypeIdValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.RegistrationTypeId field.
	/// </summary>
	public Int32 GetRegistrationTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public ColumnValue GetEventIdValue()
	{
		return this.GetValue(TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public Int32 GetEventIdFieldValue()
	{
		return this.GetValue(TableUtils.EventIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public void SetEventIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EventIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public ColumnValue GetRegistrationTypeValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public string GetRegistrationTypeFieldValue()
	{
		return this.GetValue(TableUtils.RegistrationTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public void SetRegistrationTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegistrationTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public void SetRegistrationTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegistrationTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public ColumnValue GetCostMemberValue()
	{
		return this.GetValue(TableUtils.CostMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public Decimal GetCostMemberFieldValue()
	{
		return this.GetValue(TableUtils.CostMemberColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public void SetCostMemberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CostMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public void SetCostMemberFieldValue(string val)
	{
		this.SetString(val, TableUtils.CostMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public void SetCostMemberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public void SetCostMemberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public void SetCostMemberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostMemberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public ColumnValue GetCostNonMemberValue()
	{
		return this.GetValue(TableUtils.CostNonMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public Decimal GetCostNonMemberFieldValue()
	{
		return this.GetValue(TableUtils.CostNonMemberColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public void SetCostNonMemberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CostNonMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public void SetCostNonMemberFieldValue(string val)
	{
		this.SetString(val, TableUtils.CostNonMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public void SetCostNonMemberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostNonMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public void SetCostNonMemberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostNonMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public void SetCostNonMemberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CostNonMemberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public ColumnValue GetDefault0Value()
	{
		return this.GetValue(TableUtils.Default0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public bool GetDefault0FieldValue()
	{
		return this.GetValue(TableUtils.Default0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public void SetDefault0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Default0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public void SetDefault0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Default0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public void SetDefault0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Default0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public ColumnValue GetActiveOptionValue()
	{
		return this.GetValue(TableUtils.ActiveOptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public bool GetActiveOptionFieldValue()
	{
		return this.GetValue(TableUtils.ActiveOptionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public void SetActiveOptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveOptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public void SetActiveOptionFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveOptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public void SetActiveOptionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveOptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public ColumnValue GetMaximumNumberValue()
	{
		return this.GetValue(TableUtils.MaximumNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public Int32 GetMaximumNumberFieldValue()
	{
		return this.GetValue(TableUtils.MaximumNumberColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public void SetMaximumNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MaximumNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public void SetMaximumNumberFieldValue(string val)
	{
		this.SetString(val, TableUtils.MaximumNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public void SetMaximumNumberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MaximumNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public void SetMaximumNumberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MaximumNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public void SetMaximumNumberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MaximumNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public ColumnValue GetInactiveOnMaxValue()
	{
		return this.GetValue(TableUtils.InactiveOnMaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public bool GetInactiveOnMaxFieldValue()
	{
		return this.GetValue(TableUtils.InactiveOnMaxColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public void SetInactiveOnMaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InactiveOnMaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public void SetInactiveOnMaxFieldValue(string val)
	{
		this.SetString(val, TableUtils.InactiveOnMaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public void SetInactiveOnMaxFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InactiveOnMaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public ColumnValue GetActivateOnInactiveTypeValue()
	{
		return this.GetValue(TableUtils.ActivateOnInactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public bool GetActivateOnInactiveTypeFieldValue()
	{
		return this.GetValue(TableUtils.ActivateOnInactiveTypeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public void SetActivateOnInactiveTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActivateOnInactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public void SetActivateOnInactiveTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActivateOnInactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public void SetActivateOnInactiveTypeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActivateOnInactiveTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public ColumnValue GetInactiveTypeValue()
	{
		return this.GetValue(TableUtils.InactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public Int32 GetInactiveTypeFieldValue()
	{
		return this.GetValue(TableUtils.InactiveTypeColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public void SetInactiveTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public void SetInactiveTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.InactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public void SetInactiveTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public void SetInactiveTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InactiveTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public void SetInactiveTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InactiveTypeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.RegistrationTypeId field.
	/// </summary>
	public Int32 RegistrationTypeId
	{
		get
		{
			return this.GetValue(TableUtils.RegistrationTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegistrationTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegistrationTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegistrationTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.RegistrationTypeId field.
	/// </summary>
	public string RegistrationTypeIdDefault
	{
		get
		{
			return TableUtils.RegistrationTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.EventId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.EventId field.
	/// </summary>
	public string EventIdDefault
	{
		get
		{
			return TableUtils.EventIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public string RegistrationType
	{
		get
		{
			return this.GetValue(TableUtils.RegistrationTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegistrationTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegistrationTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegistrationTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.RegistrationType field.
	/// </summary>
	public string RegistrationTypeDefault
	{
		get
		{
			return TableUtils.RegistrationTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public Decimal CostMember
	{
		get
		{
			return this.GetValue(TableUtils.CostMemberColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CostMemberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CostMemberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CostMemberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostMember field.
	/// </summary>
	public string CostMemberDefault
	{
		get
		{
			return TableUtils.CostMemberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public Decimal CostNonMember
	{
		get
		{
			return this.GetValue(TableUtils.CostNonMemberColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CostNonMemberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CostNonMemberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CostNonMemberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.CostNonMember field.
	/// </summary>
	public string CostNonMemberDefault
	{
		get
		{
			return TableUtils.CostNonMemberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public bool Default0
	{
		get
		{
			return this.GetValue(TableUtils.Default0Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Default0Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Default0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Default0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.Default field.
	/// </summary>
	public string Default0Default
	{
		get
		{
			return TableUtils.Default0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public bool ActiveOption
	{
		get
		{
			return this.GetValue(TableUtils.ActiveOptionColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ActiveOptionColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActiveOptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActiveOptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActiveOption field.
	/// </summary>
	public string ActiveOptionDefault
	{
		get
		{
			return TableUtils.ActiveOptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public Int32 MaximumNumber
	{
		get
		{
			return this.GetValue(TableUtils.MaximumNumberColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MaximumNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MaximumNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MaximumNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.MaximumNumber field.
	/// </summary>
	public string MaximumNumberDefault
	{
		get
		{
			return TableUtils.MaximumNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public bool InactiveOnMax
	{
		get
		{
			return this.GetValue(TableUtils.InactiveOnMaxColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.InactiveOnMaxColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InactiveOnMaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InactiveOnMaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveOnMax field.
	/// </summary>
	public string InactiveOnMaxDefault
	{
		get
		{
			return TableUtils.InactiveOnMaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public bool ActivateOnInactiveType
	{
		get
		{
			return this.GetValue(TableUtils.ActivateOnInactiveTypeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ActivateOnInactiveTypeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActivateOnInactiveTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActivateOnInactiveTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.ActivateOnInactiveType field.
	/// </summary>
	public string ActivateOnInactiveTypeDefault
	{
		get
		{
			return TableUtils.ActivateOnInactiveTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public Int32 InactiveType
	{
		get
		{
			return this.GetValue(TableUtils.InactiveTypeColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InactiveTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InactiveTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InactiveTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RegistrationTypes_.InactiveType field.
	/// </summary>
	public string InactiveTypeDefault
	{
		get
		{
			return TableUtils.InactiveTypeColumn.DefaultValue;
		}
	}


#endregion
}

}
