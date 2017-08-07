// This class is "generated" and will be overwritten.
// Your customizations should be made in View_FieldTripSelectionsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="View_FieldTripSelectionsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="View_FieldTripSelectionsView"></see> class.
/// </remarks>
/// <seealso cref="View_FieldTripSelectionsView"></seealso>
/// <seealso cref="View_FieldTripSelectionsRecord"></seealso>
public class BaseView_FieldTripSelectionsRecord : PrimaryKeyRecord
{

	public readonly static View_FieldTripSelectionsView TableUtils = View_FieldTripSelectionsView.Instance;

	// Constructors
 
	protected BaseView_FieldTripSelectionsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.View_FieldTripSelectionsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.View_FieldTripSelectionsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.View_FieldTripSelectionsRecord_ReadRecord); 
	}

	protected BaseView_FieldTripSelectionsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void View_FieldTripSelectionsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                View_FieldTripSelectionsRecord View_FieldTripSelectionsRec = (View_FieldTripSelectionsRecord)sender;
        if(View_FieldTripSelectionsRec != null && !View_FieldTripSelectionsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void View_FieldTripSelectionsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                View_FieldTripSelectionsRecord View_FieldTripSelectionsRec = (View_FieldTripSelectionsRecord)sender;
        Validate_Inserting();
        if(View_FieldTripSelectionsRec != null && !View_FieldTripSelectionsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void View_FieldTripSelectionsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                View_FieldTripSelectionsRecord View_FieldTripSelectionsRec = (View_FieldTripSelectionsRecord)sender;
        Validate_Updating();
        if(View_FieldTripSelectionsRec != null && !View_FieldTripSelectionsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public void SetContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public ColumnValue GetValidationUidValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public System.Guid GetValidationUidFieldValue()
	{
		return this.GetValue(TableUtils.ValidationUidColumn).ToGuid();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(string val)
	{
		this.SetString(val, TableUtils.ValidationUidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public void SetValidationUidFieldValue(System.Guid val)
	{
		ColumnValue cv = new ColumnValue(val, System.TypeCode.Object);
		this.SetValue(cv, TableUtils.ValidationUidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public ColumnValue GetDatePaidValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public DateTime GetDatePaidFieldValue()
	{
		return this.GetValue(TableUtils.DatePaidColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(string val)
	{
		this.SetString(val, TableUtils.DatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public void SetDatePaidFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DatePaidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public ColumnValue GetInitialCreationDateValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public DateTime GetInitialCreationDateFieldValue()
	{
		return this.GetValue(TableUtils.InitialCreationDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.InitialCreationDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public void SetInitialCreationDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InitialCreationDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public ColumnValue GetFieldTripIdValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public Int32 GetFieldTripIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public ColumnValue GetFirstChoiceIdValue()
	{
		return this.GetValue(TableUtils.FirstChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public Int32 GetFirstChoiceIdFieldValue()
	{
		return this.GetValue(TableUtils.FirstChoiceIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public void SetFirstChoiceIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public void SetFirstChoiceIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirstChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public void SetFirstChoiceIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public void SetFirstChoiceIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public void SetFirstChoiceIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstChoiceIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public ColumnValue GetSecondChoiceIdValue()
	{
		return this.GetValue(TableUtils.SecondChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public Int32 GetSecondChoiceIdFieldValue()
	{
		return this.GetValue(TableUtils.SecondChoiceIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public void SetSecondChoiceIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SecondChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public void SetSecondChoiceIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SecondChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public void SetSecondChoiceIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SecondChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public void SetSecondChoiceIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SecondChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public void SetSecondChoiceIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SecondChoiceIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public ColumnValue GetThirdChoiceIdValue()
	{
		return this.GetValue(TableUtils.ThirdChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public Int32 GetThirdChoiceIdFieldValue()
	{
		return this.GetValue(TableUtils.ThirdChoiceIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public void SetThirdChoiceIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ThirdChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public void SetThirdChoiceIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ThirdChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public void SetThirdChoiceIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ThirdChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public void SetThirdChoiceIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ThirdChoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public void SetThirdChoiceIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ThirdChoiceIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public ColumnValue GetAllocatedIdValue()
	{
		return this.GetValue(TableUtils.AllocatedIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public Int32 GetAllocatedIdFieldValue()
	{
		return this.GetValue(TableUtils.AllocatedIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public void SetAllocatedIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AllocatedIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public void SetAllocatedIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.AllocatedIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public void SetAllocatedIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AllocatedIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public void SetAllocatedIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AllocatedIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public void SetAllocatedIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AllocatedIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public ColumnValue GetRecIdValue()
	{
		return this.GetValue(TableUtils.RecIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public string GetRecIdFieldValue()
	{
		return this.GetValue(TableUtils.RecIdColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public void SetRecIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RecIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public void SetRecIdFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RecIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.ContactId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public System.Guid ValidationUid
	{
		get
		{
			return this.GetValue(TableUtils.ValidationUidColumn).ToGuid();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value, System.TypeCode.Object);
			this.SetValue(cv, TableUtils.ValidationUidColumn);
		}
	}
		

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ValidationUidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ValidationUidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ValidationUid field.
	/// </summary>
	public string ValidationUidDefault
	{
		get
		{
			return TableUtils.ValidationUidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public DateTime DatePaid
	{
		get
		{
			return this.GetValue(TableUtils.DatePaidColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DatePaidColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DatePaidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DatePaidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.DatePaid field.
	/// </summary>
	public string DatePaidDefault
	{
		get
		{
			return TableUtils.DatePaidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public DateTime InitialCreationDate
	{
		get
		{
			return this.GetValue(TableUtils.InitialCreationDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InitialCreationDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InitialCreationDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InitialCreationDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.InitialCreationDate field.
	/// </summary>
	public string InitialCreationDateDefault
	{
		get
		{
			return TableUtils.InitialCreationDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.FieldTripId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FieldTripId field.
	/// </summary>
	public string FieldTripIdDefault
	{
		get
		{
			return TableUtils.FieldTripIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public Int32 FirstChoiceId
	{
		get
		{
			return this.GetValue(TableUtils.FirstChoiceIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstChoiceIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstChoiceIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstChoiceIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.FirstChoiceId field.
	/// </summary>
	public string FirstChoiceIdDefault
	{
		get
		{
			return TableUtils.FirstChoiceIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public Int32 SecondChoiceId
	{
		get
		{
			return this.GetValue(TableUtils.SecondChoiceIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SecondChoiceIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SecondChoiceIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SecondChoiceIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.SecondChoiceId field.
	/// </summary>
	public string SecondChoiceIdDefault
	{
		get
		{
			return TableUtils.SecondChoiceIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public Int32 ThirdChoiceId
	{
		get
		{
			return this.GetValue(TableUtils.ThirdChoiceIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ThirdChoiceIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ThirdChoiceIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ThirdChoiceIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.ThirdChoiceId field.
	/// </summary>
	public string ThirdChoiceIdDefault
	{
		get
		{
			return TableUtils.ThirdChoiceIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public Int32 AllocatedId
	{
		get
		{
			return this.GetValue(TableUtils.AllocatedIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AllocatedIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AllocatedIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AllocatedIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.AllocatedId field.
	/// </summary>
	public string AllocatedIdDefault
	{
		get
		{
			return TableUtils.AllocatedIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public string RecId
	{
		get
		{
			return this.GetValue(TableUtils.RecIdColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RecIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RecIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RecIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_FieldTripSelections_.RecId field.
	/// </summary>
	public string RecIdDefault
	{
		get
		{
			return TableUtils.RecIdColumn.DefaultValue;
		}
	}


#endregion
}

}
