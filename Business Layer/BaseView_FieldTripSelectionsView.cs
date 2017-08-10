// This class is "generated" and will be overwritten.
// Your customizations should be made in View_FieldTripSelectionsView.cs


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
/// The generated superclass for the <see cref="View_FieldTripSelectionsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseOLR_db%dbo.view_FieldTripSelections.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="View_FieldTripSelectionsView.Instance">View_FieldTripSelectionsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="View_FieldTripSelectionsView"></seealso>
[SerializableAttribute()]
public class BaseView_FieldTripSelectionsView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = View_FieldTripSelectionsDefinition.GetXMLString();







    protected BaseView_FieldTripSelectionsView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_FieldTripSelectionsView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_FieldTripSelectionsRecord");
        this.ApplicationName = "OLR";
        this.DataAdapter = new View_FieldTripSelectionsSqlView();
        ((View_FieldTripSelectionsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ContactIdColumn.CodeName = "ContactId";
        ValidationUidColumn.CodeName = "ValidationUid";
        DatePaidColumn.CodeName = "DatePaid";
        InitialCreationDateColumn.CodeName = "InitialCreationDate";
        FieldTripIdColumn.CodeName = "FieldTripId";
        FirstChoiceIdColumn.CodeName = "FirstChoiceId";
        SecondChoiceIdColumn.CodeName = "SecondChoiceId";
        ThirdChoiceIdColumn.CodeName = "ThirdChoiceId";
        AllocatedIdColumn.CodeName = "AllocatedId";
        AllocatedIdColumn.Name = EvaluateFormula("\"Allocated Field Trip\"");
        RecIdColumn.CodeName = "RecId";
        PaymentRefColumn.CodeName = "PaymentRef";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ContactId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ContactIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ContactId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ContactId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.ContactIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ValidationUid column object.
    /// </summary>
    public BaseClasses.Data.UniqueIdentifierColumn ValidationUidColumn
    {
        get
        {
            return (BaseClasses.Data.UniqueIdentifierColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ValidationUid column object.
    /// </summary>
    public static BaseClasses.Data.UniqueIdentifierColumn ValidationUid
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.ValidationUidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.DatePaid column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DatePaidColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.DatePaid column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DatePaid
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.DatePaidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.InitialCreationDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InitialCreationDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.InitialCreationDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InitialCreationDate
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.InitialCreationDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.FieldTripId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.FieldTripId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.FieldTripIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.FirstChoiceId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirstChoiceIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.FirstChoiceId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirstChoiceId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.FirstChoiceIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.SecondChoiceId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SecondChoiceIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.SecondChoiceId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SecondChoiceId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.SecondChoiceIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ThirdChoiceId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ThirdChoiceIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.ThirdChoiceId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ThirdChoiceId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.ThirdChoiceIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.AllocatedId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn AllocatedIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.AllocatedId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn AllocatedId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.AllocatedIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.RecId column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RecIdColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.RecId column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn RecId
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.RecIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.PaymentRef column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PaymentRefColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripSelections_.PaymentRef column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PaymentRef
    {
        get
        {
            return View_FieldTripSelectionsView.Instance.PaymentRefColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where and order by clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where and order by clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_FieldTripSelectionsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }   


    public static View_FieldTripSelectionsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }

    public static View_FieldTripSelectionsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }


    public static View_FieldTripSelectionsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }

    public static View_FieldTripSelectionsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_FieldTripSelectionsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripSelectionsRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)View_FieldTripSelectionsView.Instance.GetCountResponseForPost(View_FieldTripSelectionsView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripSelectionsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = View_FieldTripSelectionsView.Instance.GetRecordListResponseForPost(View_FieldTripSelectionsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)View_FieldTripSelectionsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)View_FieldTripSelectionsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)View_FieldTripSelectionsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)View_FieldTripSelectionsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripSelectionsRecord record using a where clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripSelectionsRecord record using a where clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripSelectionsRecord record using a where and order by clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_FieldTripSelectionsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_FieldTripSelectionsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripSelectionsRecord record using a where and order by clause.
    /// </summary>
    public static View_FieldTripSelectionsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = View_FieldTripSelectionsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_FieldTripSelectionsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_FieldTripSelectionsRecord)recList[0];
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

        return View_FieldTripSelectionsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return View_FieldTripSelectionsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(where);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(join, where);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(where, orderBy);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(join, where, orderBy);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_FieldTripSelectionsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  View_FieldTripSelectionsView.Instance.CreateDataTable(recs, null);
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
        View_FieldTripSelectionsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  View_FieldTripSelectionsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return View_FieldTripSelectionsView.Instance.ExportRecordData(whereFilter);
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

        return View_FieldTripSelectionsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripSelectionsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripSelectionsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripSelectionsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return View_FieldTripSelectionsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return View_FieldTripSelectionsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return View_FieldTripSelectionsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return View_FieldTripSelectionsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = View_FieldTripSelectionsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = View_FieldTripSelectionsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static View_FieldTripSelectionsRecord GetRecord(string id, bool bMutable)
        {
            return (View_FieldTripSelectionsRecord)View_FieldTripSelectionsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static View_FieldTripSelectionsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (View_FieldTripSelectionsRecord)View_FieldTripSelectionsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string ContactIdValue, 
        string ValidationUidValue, 
        string DatePaidValue, 
        string InitialCreationDateValue, 
        string FieldTripIdValue, 
        string FirstChoiceIdValue, 
        string SecondChoiceIdValue, 
        string ThirdChoiceIdValue, 
        string AllocatedIdValue, 
        string RecIdValue, 
        string PaymentRefValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(ContactIdValue, ContactIdColumn);
        rec.SetString(ValidationUidValue, ValidationUidColumn);
        rec.SetString(DatePaidValue, DatePaidColumn);
        rec.SetString(InitialCreationDateValue, InitialCreationDateColumn);
        rec.SetString(FieldTripIdValue, FieldTripIdColumn);
        rec.SetString(FirstChoiceIdValue, FirstChoiceIdColumn);
        rec.SetString(SecondChoiceIdValue, SecondChoiceIdColumn);
        rec.SetString(ThirdChoiceIdValue, ThirdChoiceIdColumn);
        rec.SetString(AllocatedIdValue, AllocatedIdColumn);
        rec.SetString(RecIdValue, RecIdColumn);
        rec.SetString(PaymentRefValue, PaymentRefColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			View_FieldTripSelectionsView.Instance.DeleteOneRecord(kv);
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
				View_FieldTripSelectionsView.GetRecord(kv, false);
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
            if (!(View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (View_FieldTripSelectionsView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = View_FieldTripSelectionsView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = View_FieldTripSelectionsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = View_FieldTripSelectionsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
