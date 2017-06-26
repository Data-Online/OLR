// This class is "generated" and will be overwritten.
// Your customizations should be made in ContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContactsTable"></see> class.
/// </remarks>
/// <seealso cref="ContactsTable"></seealso>
/// <seealso cref="ContactsRecord"></seealso>
public class BaseContactsRecord : PrimaryKeyRecord
{

	public readonly static ContactsTable TableUtils = ContactsTable.Instance;

	// Constructors
 
	protected BaseContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContactsRecord_ReadRecord); 
	}

	protected BaseContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Inserting();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Updating();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.HometownId field.
	/// </summary>
	public ColumnValue GetHometownIdValue()
	{
		return this.GetValue(TableUtils.HometownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.HometownId field.
	/// </summary>
	public Int32 GetHometownIdFieldValue()
	{
		return this.GetValue(TableUtils.HometownIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public void SetHometownIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HometownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public void SetHometownIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.HometownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public void SetHometownIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HometownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public void SetHometownIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HometownIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public void SetHometownIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HometownIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public ColumnValue GetMobileNumberValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public String GetMobileNumberFieldValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(string val)
	{
		this.SetString(val, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public ColumnValue GetPSNZMembershipCheckValue()
	{
		return this.GetValue(TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public bool GetPSNZMembershipCheckFieldValue()
	{
		return this.GetValue(TableUtils.PSNZMembershipCheckColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZMembershipCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public void SetPSNZMembershipCheckFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZMembershipCheckColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public ColumnValue GetPSNZMemberValue()
	{
		return this.GetValue(TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public bool GetPSNZMemberFieldValue()
	{
		return this.GetValue(TableUtils.PSNZMemberColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZMemberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public void SetPSNZMemberFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZMemberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Email field.
	/// </summary>
	public ColumnValue GetEmailValue()
	{
		return this.GetValue(TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Email field.
	/// </summary>
	public string GetEmailFieldValue()
	{
		return this.GetValue(TableUtils.EmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Email field.
	/// </summary>
	public void SetEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Email field.
	/// </summary>
	public void SetEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public ColumnValue GetPSNZAppliedForValue()
	{
		return this.GetValue(TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public bool GetPSNZAppliedForFieldValue()
	{
		return this.GetValue(TableUtils.PSNZAppliedForColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(string val)
	{
		this.SetString(val, TableUtils.PSNZAppliedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public void SetPSNZAppliedForFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PSNZAppliedForColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.ContactId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address1 field.
	/// </summary>
	public string Address1
	{
		get
		{
			return this.GetValue(TableUtils.Address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address2 field.
	/// </summary>
	public string Address2
	{
		get
		{
			return this.GetValue(TableUtils.Address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address3 field.
	/// </summary>
	public string Address3
	{
		get
		{
			return this.GetValue(TableUtils.Address3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.HometownId field.
	/// </summary>
	public Int32 HometownId
	{
		get
		{
			return this.GetValue(TableUtils.HometownIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HometownIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HometownIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HometownIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.HometownId field.
	/// </summary>
	public string HometownIdDefault
	{
		get
		{
			return TableUtils.HometownIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public String MobileNumber
	{
		get
		{
			return this.GetValue(TableUtils.MobileNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MobileNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MobileNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MobileNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MobileNumber field.
	/// </summary>
	public string MobileNumberDefault
	{
		get
		{
			return TableUtils.MobileNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public bool PSNZMembershipCheck
	{
		get
		{
			return this.GetValue(TableUtils.PSNZMembershipCheckColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZMembershipCheckColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZMembershipCheckSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZMembershipCheckColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMembershipCheck field.
	/// </summary>
	public string PSNZMembershipCheckDefault
	{
		get
		{
			return TableUtils.PSNZMembershipCheckColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public bool PSNZMember
	{
		get
		{
			return this.GetValue(TableUtils.PSNZMemberColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZMemberColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZMemberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZMemberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZMember field.
	/// </summary>
	public string PSNZMemberDefault
	{
		get
		{
			return TableUtils.PSNZMemberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Email field.
	/// </summary>
	public string Email
	{
		get
		{
			return this.GetValue(TableUtils.EmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Email field.
	/// </summary>
	public string EmailDefault
	{
		get
		{
			return TableUtils.EmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public bool PSNZAppliedFor
	{
		get
		{
			return this.GetValue(TableUtils.PSNZAppliedForColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PSNZAppliedForColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PSNZAppliedForSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PSNZAppliedForColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PSNZAppliedFor field.
	/// </summary>
	public string PSNZAppliedForDefault
	{
		get
		{
			return TableUtils.PSNZAppliedForColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string FirstName
	{
		get
		{
			return this.GetValue(TableUtils.FirstNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public string LastName
	{
		get
		{
			return this.GetValue(TableUtils.LastNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LastNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}


#endregion
}

}
