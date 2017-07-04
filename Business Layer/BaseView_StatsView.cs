// This class is "generated" and will be overwritten.
// Your customizations should be made in View_StatsView.cs


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
/// The generated superclass for the <see cref="View_StatsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseOLR_db%dbo.view_Stats.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="View_StatsView.Instance">View_StatsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="View_StatsView"></seealso>
[SerializableAttribute()]
public class BaseView_StatsView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = View_StatsDefinition.GetXMLString();







    protected BaseView_StatsView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_StatsView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_StatsRecord");
        this.ApplicationName = "OLR";
        this.DataAdapter = new View_StatsSqlView();
        ((View_StatsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        FieldTripIdColumn.CodeName = "FieldTripId";
        SUM1Column.CodeName = "SUM1";
        FieldTripOptionIdColumn.CodeName = "FieldTripOptionId";
        SUM2Column.CodeName = "SUM2";
        FieldTripOptionId2Column.CodeName = "FieldTripOptionId2";
        SUM3Column.CodeName = "SUM3";
        FieldTripOptionId3Column.CodeName = "FieldTripOptionId3";
        PlacesAvailableColumn.CodeName = "PlacesAvailable";
        PlacesAvailable2Column.CodeName = "PlacesAvailable2";
        PlacesAvailable3Column.CodeName = "PlacesAvailable3";
        ftKeyColumn.CodeName = "ftKey";
        ftO1KeyColumn.CodeName = "ftO1Key";
        ftO2KeyColumn.CodeName = "ftO2Key";
        ftO3KeyColumn.CodeName = "ftO3Key";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripId
    {
        get
        {
            return View_StatsView.Instance.FieldTripIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM1
    {
        get
        {
            return View_StatsView.Instance.SUM1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId
    {
        get
        {
            return View_StatsView.Instance.FieldTripOptionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM2
    {
        get
        {
            return View_StatsView.Instance.SUM2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionId2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId2
    {
        get
        {
            return View_StatsView.Instance.FieldTripOptionId2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SUM3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.SUM3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SUM3
    {
        get
        {
            return View_StatsView.Instance.SUM3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FieldTripOptionId3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.FieldTripOptionId3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FieldTripOptionId3
    {
        get
        {
            return View_StatsView.Instance.FieldTripOptionId3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PlacesAvailableColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PlacesAvailable
    {
        get
        {
            return View_StatsView.Instance.PlacesAvailableColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PlacesAvailable2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PlacesAvailable2
    {
        get
        {
            return View_StatsView.Instance.PlacesAvailable2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PlacesAvailable3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.PlacesAvailable3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PlacesAvailable3
    {
        get
        {
            return View_StatsView.Instance.PlacesAvailable3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftKey column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftKeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftKey column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftKey
    {
        get
        {
            return View_StatsView.Instance.ftKeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO1Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO1KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO1Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO1Key
    {
        get
        {
            return View_StatsView.Instance.ftO1KeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO2Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO2KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO2Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO2Key
    {
        get
        {
            return View_StatsView.Instance.ftO2KeyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO3Key column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ftO3KeyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_Stats_.ftO3Key column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ftO3Key
    {
        get
        {
            return View_StatsView.Instance.ftO3KeyColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where clause.
    /// </summary>
    public static View_StatsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where clause.
    /// </summary>
    public static View_StatsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where and order by clause.
    /// </summary>
    public static View_StatsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where and order by clause.
    /// </summary>
    public static View_StatsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_StatsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_StatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_StatsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = View_StatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }   


    public static View_StatsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_StatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }

    public static View_StatsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = View_StatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }


    public static View_StatsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_StatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }

    public static View_StatsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = View_StatsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_StatsRecord[])recList.ToArray(Type.GetType("OLR.Business.View_StatsRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)View_StatsView.Instance.GetCountResponseForPost(View_StatsView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of View_StatsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = View_StatsView.Instance.GetRecordListResponseForPost(View_StatsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)View_StatsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)View_StatsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)View_StatsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)View_StatsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_StatsRecord record using a where clause.
    /// </summary>
    public static View_StatsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_StatsRecord record using a where clause.
    /// </summary>
    public static View_StatsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_StatsRecord record using a where and order by clause.
    /// </summary>
    public static View_StatsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = View_StatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_StatsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_StatsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_StatsRecord record using a where and order by clause.
    /// </summary>
    public static View_StatsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = View_StatsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_StatsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_StatsRecord)recList[0];
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

        return View_StatsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return View_StatsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        View_StatsRecord[] recs = GetRecords(where);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        View_StatsRecord[] recs = GetRecords(join, where);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        View_StatsRecord[] recs = GetRecords(where, orderBy);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        View_StatsRecord[] recs = GetRecords(join, where, orderBy);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_StatsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_StatsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  View_StatsView.Instance.CreateDataTable(recs, null);
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
        View_StatsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  View_StatsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return View_StatsView.Instance.ExportRecordData(whereFilter);
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

        return View_StatsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_StatsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_StatsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_StatsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return View_StatsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return View_StatsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return View_StatsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return View_StatsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = View_StatsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = View_StatsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static View_StatsRecord GetRecord(string id, bool bMutable)
        {
            return (View_StatsRecord)View_StatsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static View_StatsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (View_StatsRecord)View_StatsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string FieldTripIdValue, 
        string SUM1Value, 
        string FieldTripOptionIdValue, 
        string SUM2Value, 
        string FieldTripOptionId2Value, 
        string SUM3Value, 
        string FieldTripOptionId3Value, 
        string PlacesAvailableValue, 
        string PlacesAvailable2Value, 
        string PlacesAvailable3Value, 
        string ftKeyValue, 
        string ftO1KeyValue, 
        string ftO2KeyValue, 
        string ftO3KeyValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(FieldTripIdValue, FieldTripIdColumn);
        rec.SetString(SUM1Value, SUM1Column);
        rec.SetString(FieldTripOptionIdValue, FieldTripOptionIdColumn);
        rec.SetString(SUM2Value, SUM2Column);
        rec.SetString(FieldTripOptionId2Value, FieldTripOptionId2Column);
        rec.SetString(SUM3Value, SUM3Column);
        rec.SetString(FieldTripOptionId3Value, FieldTripOptionId3Column);
        rec.SetString(PlacesAvailableValue, PlacesAvailableColumn);
        rec.SetString(PlacesAvailable2Value, PlacesAvailable2Column);
        rec.SetString(PlacesAvailable3Value, PlacesAvailable3Column);
        rec.SetString(ftKeyValue, ftKeyColumn);
        rec.SetString(ftO1KeyValue, ftO1KeyColumn);
        rec.SetString(ftO2KeyValue, ftO2KeyColumn);
        rec.SetString(ftO3KeyValue, ftO3KeyColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			View_StatsView.Instance.DeleteOneRecord(kv);
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
				View_StatsView.GetRecord(kv, false);
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
            if (!(View_StatsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return View_StatsView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(View_StatsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = View_StatsView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = View_StatsView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (View_StatsView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = View_StatsView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = View_StatsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = View_StatsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
