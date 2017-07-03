// This class is "generated" and will be overwritten.
// Your customizations should be made in View_RegisteredView.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using OLR.Data;

namespace OLR.Business
{

/// <summary>
/// The generated superclass for the <see cref="View_RegisteredView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseOLR_db%dbo.view_Registered.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="View_RegisteredView.Instance">View_RegisteredView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="View_RegisteredView"></seealso>
[SerializableAttribute()]
public class BaseView_RegisteredView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = View_RegisteredDefinition.GetXMLString();







    protected BaseView_RegisteredView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_RegisteredView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_RegisteredRecord");
        this.ApplicationName = "OLR";
        this.DataAdapter = new View_RegisteredSqlView();
        ((View_RegisteredSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ContactIdColumn.CodeName = "ContactId";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        MobileNumberColumn.CodeName = "MobileNumber";
        PSNZMembershipCheckColumn.CodeName = "PSNZMembershipCheck";
        PSNZMemberColumn.CodeName = "PSNZMember";
        EmailColumn.CodeName = "Email";
        PSNZAppliedForColumn.CodeName = "PSNZAppliedFor";
        FirstNameColumn.CodeName = "FirstName";
        LastNameColumn.CodeName = "LastName";
        DatePaidColumn.CodeName = "DatePaid";
        InitialCreationDateColumn.CodeName = "InitialCreationDate";
        AdditionalDinnerNameColumn.CodeName = "AdditionalDinnerName";
        SpecialRequirementsColumn.CodeName = "SpecialRequirements";
        AdditionalDinnerTicketColumn.CodeName = "AdditionalDinnerTicket";
        TownNameColumn.CodeName = "TownName";
        TownNameColumn.Name = EvaluateFormula("\"Town\"");
        RegistrationTypeColumn.CodeName = "RegistrationType";
        RegistrationIdColumn.CodeName = "RegistrationId";
        RecordDeletedColumn.CodeName = "RecordDeleted";

        
    }
    
#region "Overriden methods"
	public override WhereClause AddGlobalWhereClause()
    {
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
        WhereClause wc = new WhereClause();
        String formula;

        if(BaseFormulaEvaluator.ShouldApplyGlobalWhereClause("1")){
            formula = EvaluateFormula("1");
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(View_RegisteredView.RecordDeleted, formula, BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));
            wc.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
        }

        return wc;
    }
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.ContactId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ContactIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.ContactId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ContactId
    {
        get
        {
            return View_RegisteredView.Instance.ContactIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return View_RegisteredView.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return View_RegisteredView.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return View_RegisteredView.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.MobileNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MobileNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.MobileNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MobileNumber
    {
        get
        {
            return View_RegisteredView.Instance.MobileNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZMembershipCheck column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZMembershipCheckColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZMembershipCheck column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZMembershipCheck
    {
        get
        {
            return View_RegisteredView.Instance.PSNZMembershipCheckColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZMember column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZMemberColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZMember column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZMember
    {
        get
        {
            return View_RegisteredView.Instance.PSNZMemberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn EmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.Email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn Email
    {
        get
        {
            return View_RegisteredView.Instance.EmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZAppliedFor column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZAppliedForColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.PSNZAppliedFor column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZAppliedFor
    {
        get
        {
            return View_RegisteredView.Instance.PSNZAppliedForColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.FirstName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirstNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.FirstName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirstName
    {
        get
        {
            return View_RegisteredView.Instance.FirstNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.LastName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LastNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.LastName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LastName
    {
        get
        {
            return View_RegisteredView.Instance.LastNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.DatePaid column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DatePaidColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.DatePaid column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DatePaid
    {
        get
        {
            return View_RegisteredView.Instance.DatePaidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.InitialCreationDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InitialCreationDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.InitialCreationDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InitialCreationDate
    {
        get
        {
            return View_RegisteredView.Instance.InitialCreationDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.AdditionalDinnerName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AdditionalDinnerNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.AdditionalDinnerName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AdditionalDinnerName
    {
        get
        {
            return View_RegisteredView.Instance.AdditionalDinnerNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.SpecialRequirements column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SpecialRequirementsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.SpecialRequirements column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SpecialRequirements
    {
        get
        {
            return View_RegisteredView.Instance.SpecialRequirementsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.AdditionalDinnerTicket column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AdditionalDinnerTicketColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.AdditionalDinnerTicket column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AdditionalDinnerTicket
    {
        get
        {
            return View_RegisteredView.Instance.AdditionalDinnerTicketColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.TownName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TownNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.TownName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TownName
    {
        get
        {
            return View_RegisteredView.Instance.TownNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RegistrationType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RegistrationTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RegistrationType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn RegistrationType
    {
        get
        {
            return View_RegisteredView.Instance.RegistrationTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RegistrationId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RegistrationIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RegistrationId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RegistrationId
    {
        get
        {
            return View_RegisteredView.Instance.RegistrationIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RecordDeleted column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn RecordDeletedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Registered_.RecordDeleted column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn RecordDeleted
    {
        get
        {
            return View_RegisteredView.Instance.RecordDeletedColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where clause.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where clause.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where and order by clause.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where and order by clause.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_RegisteredRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }   


    public static View_RegisteredRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }

    public static View_RegisteredRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }


    public static View_RegisteredRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }

    public static View_RegisteredRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_RegisteredRecord[])recList.ToArray(Type.GetType("OLR.Business.View_RegisteredRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)View_RegisteredView.Instance.GetCountResponseForPost(View_RegisteredView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of View_RegisteredRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = View_RegisteredView.Instance.GetRecordListResponseForPost(View_RegisteredView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
                                                                join, filter, groupBy, sortOrder, startIndex, count, ref totalCount, fromDataSource, isGetColumnValues);
        }
        else if (table != null)
        {
            recList = table.GetDataSourceResponseForPost(requestedSelection, workingSelection, distinctSelection, join, filter, 
                groupBy, sortOrder, startIndex, count, ref totalCount, true);
        }

		return recList;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)View_RegisteredView.Instance.GetRecordListCount(null, whereFilter, null, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(BaseFilter join, string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)View_RegisteredView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)View_RegisteredView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)View_RegisteredView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_RegisteredRecord record using a where clause.
    /// </summary>
    public static View_RegisteredRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_RegisteredRecord record using a where clause.
    /// </summary>
    public static View_RegisteredRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_RegisteredRecord record using a where and order by clause.
    /// </summary>
    public static View_RegisteredRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_RegisteredRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_RegisteredRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_RegisteredRecord record using a where and order by clause.
    /// </summary>
    public static View_RegisteredRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = View_RegisteredView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_RegisteredRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_RegisteredRecord)recList[0];
        }

        return rec;
    }


    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return View_RegisteredView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }

    public static String[] GetValues(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return View_RegisteredView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        View_RegisteredRecord[] recs = GetRecords(where);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        View_RegisteredRecord[] recs = GetRecords(join, where);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        View_RegisteredRecord[] recs = GetRecords(where, orderBy);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        View_RegisteredRecord[] recs = GetRecords(join, where, orderBy);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_RegisteredRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_RegisteredRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  View_RegisteredView.Instance.CreateDataTable(recs, null);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        View_RegisteredView.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  View_RegisteredView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return View_RegisteredView.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return View_RegisteredView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
	public static string GetSum(
		BaseColumn col,
		BaseFilter join, 
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return View_RegisteredView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }    
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return View_RegisteredView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return View_RegisteredView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return View_RegisteredView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return View_RegisteredView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return View_RegisteredView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return View_RegisteredView.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = View_RegisteredView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = View_RegisteredView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static View_RegisteredRecord GetRecord(string id, bool bMutable)
        {
            return (View_RegisteredRecord)View_RegisteredView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static View_RegisteredRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (View_RegisteredRecord)View_RegisteredView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string ContactIdValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string MobileNumberValue, 
        string PSNZMembershipCheckValue, 
        string PSNZMemberValue, 
        string EmailValue, 
        string PSNZAppliedForValue, 
        string FirstNameValue, 
        string LastNameValue, 
        string DatePaidValue, 
        string InitialCreationDateValue, 
        string AdditionalDinnerNameValue, 
        string SpecialRequirementsValue, 
        string AdditionalDinnerTicketValue, 
        string TownNameValue, 
        string RegistrationTypeValue, 
        string RegistrationIdValue, 
        string RecordDeletedValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(ContactIdValue, ContactIdColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(MobileNumberValue, MobileNumberColumn);
        rec.SetString(PSNZMembershipCheckValue, PSNZMembershipCheckColumn);
        rec.SetString(PSNZMemberValue, PSNZMemberColumn);
        rec.SetString(EmailValue, EmailColumn);
        rec.SetString(PSNZAppliedForValue, PSNZAppliedForColumn);
        rec.SetString(FirstNameValue, FirstNameColumn);
        rec.SetString(LastNameValue, LastNameColumn);
        rec.SetString(DatePaidValue, DatePaidColumn);
        rec.SetString(InitialCreationDateValue, InitialCreationDateColumn);
        rec.SetString(AdditionalDinnerNameValue, AdditionalDinnerNameColumn);
        rec.SetString(SpecialRequirementsValue, SpecialRequirementsColumn);
        rec.SetString(AdditionalDinnerTicketValue, AdditionalDinnerTicketColumn);
        rec.SetString(TownNameValue, TownNameColumn);
        rec.SetString(RegistrationTypeValue, RegistrationTypeColumn);
        rec.SetString(RegistrationIdValue, RegistrationIdColumn);
        rec.SetString(RecordDeletedValue, RecordDeletedColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			View_RegisteredView.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				View_RegisteredView.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(View_RegisteredView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return View_RegisteredView.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(View_RegisteredView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = View_RegisteredView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = View_RegisteredView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (View_RegisteredView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = View_RegisteredView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = View_RegisteredView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }
                            
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
		public static string GetDFKA(String keyValue, BaseColumn col, String formatPattern)
		{
		    if (keyValue == null)
				return null;
			ForeignKey fkColumn = View_RegisteredView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(tableName);
				BaseRecord rec = null;
				
				if (t != null)
				{
					try
					{
						rec = (BaseRecord)t.GetRecordData(keyValue, false);
					}
					catch
					{
						rec = null;
					}
				}
				if( rec == null)
					return "";

                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }	            
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, string name)
		{
			BaseFormulaEvaluator e = new BaseFormulaEvaluator();
			if(dataSourceForEvaluate != null)
				e.Evaluator.Variables.Add(name, dataSourceForEvaluate);
			e.DataSource = dataSourceForEvaluate;
	        object resultObj = e.Evaluate(formula);
	
		    if (resultObj == null)
			    return "";
	        if (!string.IsNullOrEmpty(format))
	            return BaseFormulaUtils.Format(resultObj, format);
		    else
            return resultObj.ToString();
		}
		
		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula)
		{
			return EvaluateFormula(formula,null,null,null);
		}
		
				
	#endregion
	}

}
