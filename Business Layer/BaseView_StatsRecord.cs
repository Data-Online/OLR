// This class is "generated" and will be overwritten.
// Your customizations should be made in View_StatsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="View_StatsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="View_StatsView"></see> class.
/// </remarks>
/// <seealso cref="View_StatsView"></seealso>
/// <seealso cref="View_StatsRecord"></seealso>
public class BaseView_StatsRecord : PrimaryKeyRecord
{

	public readonly static View_StatsView TableUtils = View_StatsView.Instance;

	// Constructors
 
	protected BaseView_StatsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.View_StatsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.View_StatsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.View_StatsRecord_ReadRecord); 
	}

	protected BaseView_StatsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void View_StatsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                View_StatsRecord View_StatsRec = (View_StatsRecord)sender;
        if(View_StatsRec != null && !View_StatsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void View_StatsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                View_StatsRecord View_StatsRec = (View_StatsRecord)sender;
        Validate_Inserting();
        if(View_StatsRec != null && !View_StatsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void View_StatsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                View_StatsRecord View_StatsRec = (View_StatsRecord)sender;
        Validate_Updating();
        if(View_StatsRec != null && !View_StatsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public ColumnValue GetFieldTripIdValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public Int32 GetFieldTripIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public void SetFieldTripIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public ColumnValue GetSUM1Value()
	{
		return this.GetValue(TableUtils.SUM1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public Int32 GetSUM1FieldValue()
	{
		return this.GetValue(TableUtils.SUM1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public void SetSUM1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SUM1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public void SetSUM1FieldValue(string val)
	{
		this.SetString(val, TableUtils.SUM1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public void SetSUM1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public void SetSUM1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public void SetSUM1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public ColumnValue GetFieldTripOptionIdValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public Int32 GetFieldTripOptionIdFieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public void SetFieldTripOptionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public ColumnValue GetSUM2Value()
	{
		return this.GetValue(TableUtils.SUM2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public Int32 GetSUM2FieldValue()
	{
		return this.GetValue(TableUtils.SUM2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public void SetSUM2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SUM2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public void SetSUM2FieldValue(string val)
	{
		this.SetString(val, TableUtils.SUM2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public void SetSUM2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public void SetSUM2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public void SetSUM2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public ColumnValue GetFieldTripOptionId2Value()
	{
		return this.GetValue(TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public Int32 GetFieldTripOptionId2FieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionId2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public void SetFieldTripOptionId2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public ColumnValue GetSUM3Value()
	{
		return this.GetValue(TableUtils.SUM3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public Int32 GetSUM3FieldValue()
	{
		return this.GetValue(TableUtils.SUM3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public void SetSUM3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SUM3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public void SetSUM3FieldValue(string val)
	{
		this.SetString(val, TableUtils.SUM3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public void SetSUM3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public void SetSUM3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public void SetSUM3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SUM3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public ColumnValue GetFieldTripOptionId3Value()
	{
		return this.GetValue(TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public Int32 GetFieldTripOptionId3FieldValue()
	{
		return this.GetValue(TableUtils.FieldTripOptionId3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(string val)
	{
		this.SetString(val, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public void SetFieldTripOptionId3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public ColumnValue GetPlacesAvailableValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public Int32 GetPlacesAvailableFieldValue()
	{
		return this.GetValue(TableUtils.PlacesAvailableColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(string val)
	{
		this.SetString(val, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public void SetPlacesAvailableFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailableColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public ColumnValue GetPlacesAvailable2Value()
	{
		return this.GetValue(TableUtils.PlacesAvailable2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public Int32 GetPlacesAvailable2FieldValue()
	{
		return this.GetValue(TableUtils.PlacesAvailable2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public void SetPlacesAvailable2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlacesAvailable2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public void SetPlacesAvailable2FieldValue(string val)
	{
		this.SetString(val, TableUtils.PlacesAvailable2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public void SetPlacesAvailable2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public void SetPlacesAvailable2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public void SetPlacesAvailable2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public ColumnValue GetPlacesAvailable3Value()
	{
		return this.GetValue(TableUtils.PlacesAvailable3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public Int32 GetPlacesAvailable3FieldValue()
	{
		return this.GetValue(TableUtils.PlacesAvailable3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public void SetPlacesAvailable3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlacesAvailable3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public void SetPlacesAvailable3FieldValue(string val)
	{
		this.SetString(val, TableUtils.PlacesAvailable3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public void SetPlacesAvailable3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public void SetPlacesAvailable3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public void SetPlacesAvailable3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlacesAvailable3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public ColumnValue GetftKeyValue()
	{
		return this.GetValue(TableUtils.ftKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public Int32 GetftKeyFieldValue()
	{
		return this.GetValue(TableUtils.ftKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public void SetftKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ftKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public void SetftKeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ftKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public void SetftKeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public void SetftKeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public void SetftKeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public ColumnValue GetftO1KeyValue()
	{
		return this.GetValue(TableUtils.ftO1KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public Int32 GetftO1KeyFieldValue()
	{
		return this.GetValue(TableUtils.ftO1KeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public void SetftO1KeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ftO1KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public void SetftO1KeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ftO1KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public void SetftO1KeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO1KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public void SetftO1KeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO1KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public void SetftO1KeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO1KeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public ColumnValue GetftO2KeyValue()
	{
		return this.GetValue(TableUtils.ftO2KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public Int32 GetftO2KeyFieldValue()
	{
		return this.GetValue(TableUtils.ftO2KeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public void SetftO2KeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ftO2KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public void SetftO2KeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ftO2KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public void SetftO2KeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO2KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public void SetftO2KeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO2KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public void SetftO2KeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO2KeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public ColumnValue GetftO3KeyValue()
	{
		return this.GetValue(TableUtils.ftO3KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public Int32 GetftO3KeyFieldValue()
	{
		return this.GetValue(TableUtils.ftO3KeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public void SetftO3KeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ftO3KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public void SetftO3KeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ftO3KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public void SetftO3KeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO3KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public void SetftO3KeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO3KeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public void SetftO3KeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ftO3KeyColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.FieldTripId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripId field.
	/// </summary>
	public string FieldTripIdDefault
	{
		get
		{
			return TableUtils.FieldTripIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public Int32 SUM1
	{
		get
		{
			return this.GetValue(TableUtils.SUM1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SUM1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SUM1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SUM1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM1 field.
	/// </summary>
	public string SUM1Default
	{
		get
		{
			return TableUtils.SUM1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.FieldTripOptionId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId field.
	/// </summary>
	public string FieldTripOptionIdDefault
	{
		get
		{
			return TableUtils.FieldTripOptionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public Int32 SUM2
	{
		get
		{
			return this.GetValue(TableUtils.SUM2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SUM2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SUM2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SUM2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM2 field.
	/// </summary>
	public string SUM2Default
	{
		get
		{
			return TableUtils.SUM2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public Int32 FieldTripOptionId2
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripOptionId2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripOptionId2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripOptionId2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripOptionId2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId2 field.
	/// </summary>
	public string FieldTripOptionId2Default
	{
		get
		{
			return TableUtils.FieldTripOptionId2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public Int32 SUM3
	{
		get
		{
			return this.GetValue(TableUtils.SUM3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SUM3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SUM3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SUM3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.SUM3 field.
	/// </summary>
	public string SUM3Default
	{
		get
		{
			return TableUtils.SUM3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public Int32 FieldTripOptionId3
	{
		get
		{
			return this.GetValue(TableUtils.FieldTripOptionId3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FieldTripOptionId3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FieldTripOptionId3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FieldTripOptionId3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.FieldTripOptionId3 field.
	/// </summary>
	public string FieldTripOptionId3Default
	{
		get
		{
			return TableUtils.FieldTripOptionId3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.PlacesAvailable field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable field.
	/// </summary>
	public string PlacesAvailableDefault
	{
		get
		{
			return TableUtils.PlacesAvailableColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public Int32 PlacesAvailable2
	{
		get
		{
			return this.GetValue(TableUtils.PlacesAvailable2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlacesAvailable2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlacesAvailable2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlacesAvailable2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable2 field.
	/// </summary>
	public string PlacesAvailable2Default
	{
		get
		{
			return TableUtils.PlacesAvailable2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public Int32 PlacesAvailable3
	{
		get
		{
			return this.GetValue(TableUtils.PlacesAvailable3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlacesAvailable3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlacesAvailable3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlacesAvailable3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.PlacesAvailable3 field.
	/// </summary>
	public string PlacesAvailable3Default
	{
		get
		{
			return TableUtils.PlacesAvailable3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public Int32 ftKey
	{
		get
		{
			return this.GetValue(TableUtils.ftKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ftKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ftKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ftKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftKey field.
	/// </summary>
	public string ftKeyDefault
	{
		get
		{
			return TableUtils.ftKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public Int32 ftO1Key
	{
		get
		{
			return this.GetValue(TableUtils.ftO1KeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ftO1KeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ftO1KeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ftO1KeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO1Key field.
	/// </summary>
	public string ftO1KeyDefault
	{
		get
		{
			return TableUtils.ftO1KeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public Int32 ftO2Key
	{
		get
		{
			return this.GetValue(TableUtils.ftO2KeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ftO2KeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ftO2KeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ftO2KeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO2Key field.
	/// </summary>
	public string ftO2KeyDefault
	{
		get
		{
			return TableUtils.ftO2KeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public Int32 ftO3Key
	{
		get
		{
			return this.GetValue(TableUtils.ftO3KeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ftO3KeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ftO3KeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ftO3KeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Stats_.ftO3Key field.
	/// </summary>
	public string ftO3KeyDefault
	{
		get
		{
			return TableUtils.ftO3KeyColumn.DefaultValue;
		}
	}


#endregion
}

}
