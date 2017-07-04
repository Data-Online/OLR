// This class is "generated" and will be overwritten.
// Your customizations should be made in View_FieldTripStatsView.cs

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
/// The generated superclass for the <see cref="View_FieldTripStatsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseOLR_db%dbo.view_FieldTripStats.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="View_FieldTripStatsView.Instance">View_FieldTripStatsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="View_FieldTripStatsView"></seealso>
[SerializableAttribute()]
public class BaseView_FieldTripStatsView : KeylessTable
{

	private readonly string TableDefinitionString = View_FieldTripStatsDefinition.GetXMLString();







	protected BaseView_FieldTripStatsView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_FieldTripStatsView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_FieldTripStatsRecord");
		this.ApplicationName = "OLR";
		this.DataAdapter = new View_FieldTripStatsSqlView();
		((View_FieldTripStatsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        FieldTripIdColumn.CodeName = "FieldTripId";
        SUM1Column.CodeName = "SUM1";
        FieldTripOptionIdColumn.CodeName = "FieldTripOptionId";
        SUM2Column.CodeName = "SUM2";
        FieldTripOptionId2Column.CodeName = "FieldTripOptionId2";
        FieldTripOptionId2Column.Name = EvaluateFormula("\"Field Trip Option\"");
        SUM3Column.CodeName = "SUM3";
        FieldTripOptionId3Column.CodeName = "FieldTripOptionId3";
        FieldTripOptionId3Column.Name = EvaluateFormula("\"Field Trip Option\"");
        ftKeyColumn.CodeName = "ftKey";
        ftO1KeyColumn.CodeName = "ftO1Key";
        ftO2KeyColumn.CodeName = "ftO2Key";
        ftO3KeyColumn.CodeName = "ftO3Key";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripId
    {
        get
        {
            return View_FieldTripStatsView.Instance.FieldTripIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM1
    {
        get
        {
            return View_FieldTripStatsView.Instance.SUM1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId
    {
        get
        {
            return View_FieldTripStatsView.Instance.FieldTripOptionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM2
    {
        get
        {
            return View_FieldTripStatsView.Instance.SUM2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionId2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId2
    {
        get
        {
            return View_FieldTripStatsView.Instance.FieldTripOptionId2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.SUM3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM3
    {
        get
        {
            return View_FieldTripStatsView.Instance.SUM3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionId3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.FieldTripOptionId3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId3
    {
        get
        {
            return View_FieldTripStatsView.Instance.FieldTripOptionId3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftKey
    {
        get
        {
            return View_FieldTripStatsView.Instance.ftKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO1Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO1KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO1Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO1Key
    {
        get
        {
            return View_FieldTripStatsView.Instance.ftO1KeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO2Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO2KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO2Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO2Key
    {
        get
        {
            return View_FieldTripStatsView.Instance.ftO2KeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO3Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO3KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_FieldTripStats_.ftO3Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO3Key
    {
        get
        {
            return View_FieldTripStatsView.Instance.ftO3KeyColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where clause.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where clause.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where and order by clause.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where and order by clause.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_FieldTripStatsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }   


    public static View_FieldTripStatsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }

    public static View_FieldTripStatsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }


    public static View_FieldTripStatsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }

    public static View_FieldTripStatsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_FieldTripStatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_FieldTripStatsRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)View_FieldTripStatsView.Instance.GetCountResponseForPost(View_FieldTripStatsView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of View_FieldTripStatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = View_FieldTripStatsView.Instance.GetRecordListResponseForPost(View_FieldTripStatsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)View_FieldTripStatsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)View_FieldTripStatsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)View_FieldTripStatsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)View_FieldTripStatsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripStatsRecord record using a where clause.
    /// </summary>
    public static View_FieldTripStatsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripStatsRecord record using a where clause.
    /// </summary>
    public static View_FieldTripStatsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripStatsRecord record using a where and order by clause.
    /// </summary>
    public static View_FieldTripStatsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_FieldTripStatsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_FieldTripStatsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_FieldTripStatsRecord record using a where and order by clause.
    /// </summary>
    public static View_FieldTripStatsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = View_FieldTripStatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_FieldTripStatsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_FieldTripStatsRecord)recList[0];
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

        return View_FieldTripStatsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return View_FieldTripStatsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(where);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(join, where);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(where, orderBy);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(join, where, orderBy);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_FieldTripStatsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  View_FieldTripStatsView.Instance.CreateDataTable(recs, null);
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
        View_FieldTripStatsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  View_FieldTripStatsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return View_FieldTripStatsView.Instance.ExportRecordData(whereFilter);
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

        return View_FieldTripStatsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripStatsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripStatsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_FieldTripStatsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return View_FieldTripStatsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return View_FieldTripStatsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return View_FieldTripStatsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return View_FieldTripStatsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = View_FieldTripStatsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = View_FieldTripStatsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = View_FieldTripStatsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = View_FieldTripStatsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
