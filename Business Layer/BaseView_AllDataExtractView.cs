// This class is "generated" and will be overwritten.
// Your customizations should be made in View_AllDataExtractView.cs


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
/// The generated superclass for the <see cref="View_AllDataExtractView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseOLR_db%dbo.view_AllDataExtract.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="View_AllDataExtractView.Instance">View_AllDataExtractView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="View_AllDataExtractView"></seealso>
[SerializableAttribute()]
public class BaseView_AllDataExtractView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = View_AllDataExtractDefinition.GetXMLString();







    protected BaseView_AllDataExtractView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_AllDataExtractView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("OLR.Business", "OLR.Business.View_AllDataExtractRecord");
        this.ApplicationName = "OLR";
        this.DataAdapter = new View_AllDataExtractSqlView();
        ((View_AllDataExtractSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
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
        RegistrationTypeColumn.CodeName = "RegistrationType";
        RegistrationIdColumn.CodeName = "RegistrationId";
        ValidationUidColumn.CodeName = "ValidationUid";
        FT1_1Column.CodeName = "FT1_1";
        FT1_1Column.Name = EvaluateFormula("\"First Choice\"");
        FT1_2Column.CodeName = "FT1_2";
        FT1_2Column.Name = EvaluateFormula("\"Second Choice\"");
        FT1_3Column.CodeName = "FT1_3";
        FT1_3Column.Name = EvaluateFormula("\"Third Choice\"");
        Description1Column.CodeName = "Description1";
        FT2_1Column.CodeName = "FT2_1";
        FT2_1Column.Name = EvaluateFormula("\"First Choice\"");
        FT2_2Column.CodeName = "FT2_2";
        FT2_2Column.Name = EvaluateFormula("\"Second Choice\"");
        FT2_3Column.CodeName = "FT2_3";
        FT2_3Column.Name = EvaluateFormula("\"Third Choice\"");
        Description2Column.CodeName = "Description2";
        FTA2Column.CodeName = "FTA2";
        FTA2Column.Name = EvaluateFormula("\"Allocated2\"");
        FTA1Column.CodeName = "FTA1";
        FTA1Column.Name = EvaluateFormula("\"Allocated1\"");
        Item1Column.CodeName = "Item1";
        Item1Column.Name = EvaluateFormula("\"Workshop1\"");
        Item2Column.CodeName = "Item2";
        Item2Column.Name = EvaluateFormula("\"Workshop2\"");
        Item1aColumn.CodeName = "Item1a";
        Item1aColumn.Name = EvaluateFormula("\"Attending1\"");
        Item2aColumn.CodeName = "Item2a";
        Item2aColumn.Name = EvaluateFormula("\"Attending2\"");
        Item3Column.CodeName = "Item3";
        Item3Column.Name = EvaluateFormula("\"Workshop3\"");
        Item4Column.CodeName = "Item4";
        Item4Column.Name = EvaluateFormula("\"Workshop4\"");
        Item5Column.CodeName = "Item5";
        Item5Column.Name = EvaluateFormula("\"Workshop5\"");
        Item6Column.CodeName = "Item6";
        Item6Column.Name = EvaluateFormula("\"Workshop6\"");
        Item7Column.CodeName = "Item7";
        Item7Column.Name = EvaluateFormula("\"Workshop7\"");
        Item3aColumn.CodeName = "Item3a";
        Item3aColumn.Name = EvaluateFormula("\"Attending3\"");
        Item4aColumn.CodeName = "Item4a";
        Item4aColumn.Name = EvaluateFormula("\"Attending4\"");
        Item5aColumn.CodeName = "Item5a";
        Item5aColumn.Name = EvaluateFormula("\"Attending5\"");
        Item6aColumn.CodeName = "Item6a";
        Item6aColumn.Name = EvaluateFormula("\"Attending6\"");
        Item7aColumn.CodeName = "Item7a";
        Item7aColumn.Name = EvaluateFormula("\"Attending7\"");
        Hon1Column.CodeName = "Hon1";
        Hon1Column.Name = EvaluateFormula("\"Honours\"");
        Hon2Column.CodeName = "Hon2";
        Hon3Column.CodeName = "Hon3";
        Hon4Column.CodeName = "Hon4";
        Hon5Column.CodeName = "Hon5";
        Hon6Column.CodeName = "Hon6";
        Hon7Column.CodeName = "Hon7";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.ContactId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ContactIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.ContactId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ContactId
    {
        get
        {
            return View_AllDataExtractView.Instance.ContactIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return View_AllDataExtractView.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return View_AllDataExtractView.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return View_AllDataExtractView.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.MobileNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MobileNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.MobileNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MobileNumber
    {
        get
        {
            return View_AllDataExtractView.Instance.MobileNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZMembershipCheck column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZMembershipCheckColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZMembershipCheck column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZMembershipCheck
    {
        get
        {
            return View_AllDataExtractView.Instance.PSNZMembershipCheckColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZMember column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZMemberColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZMember column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZMember
    {
        get
        {
            return View_AllDataExtractView.Instance.PSNZMemberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn EmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn Email
    {
        get
        {
            return View_AllDataExtractView.Instance.EmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZAppliedFor column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PSNZAppliedForColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.PSNZAppliedFor column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PSNZAppliedFor
    {
        get
        {
            return View_AllDataExtractView.Instance.PSNZAppliedForColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FirstName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirstNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FirstName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirstName
    {
        get
        {
            return View_AllDataExtractView.Instance.FirstNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.LastName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LastNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.LastName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LastName
    {
        get
        {
            return View_AllDataExtractView.Instance.LastNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.DatePaid column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DatePaidColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.DatePaid column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DatePaid
    {
        get
        {
            return View_AllDataExtractView.Instance.DatePaidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.InitialCreationDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InitialCreationDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.InitialCreationDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InitialCreationDate
    {
        get
        {
            return View_AllDataExtractView.Instance.InitialCreationDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.AdditionalDinnerName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AdditionalDinnerNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.AdditionalDinnerName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AdditionalDinnerName
    {
        get
        {
            return View_AllDataExtractView.Instance.AdditionalDinnerNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.SpecialRequirements column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SpecialRequirementsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.SpecialRequirements column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SpecialRequirements
    {
        get
        {
            return View_AllDataExtractView.Instance.SpecialRequirementsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.AdditionalDinnerTicket column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AdditionalDinnerTicketColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.AdditionalDinnerTicket column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AdditionalDinnerTicket
    {
        get
        {
            return View_AllDataExtractView.Instance.AdditionalDinnerTicketColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.TownName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TownNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.TownName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TownName
    {
        get
        {
            return View_AllDataExtractView.Instance.TownNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.RegistrationType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RegistrationTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.RegistrationType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn RegistrationType
    {
        get
        {
            return View_AllDataExtractView.Instance.RegistrationTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.RegistrationId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RegistrationIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.RegistrationId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RegistrationId
    {
        get
        {
            return View_AllDataExtractView.Instance.RegistrationIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.ValidationUid column object.
    /// </summary>
    public BaseClasses.Data.UniqueIdentifierColumn ValidationUidColumn
    {
        get
        {
            return (BaseClasses.Data.UniqueIdentifierColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.ValidationUid column object.
    /// </summary>
    public static BaseClasses.Data.UniqueIdentifierColumn ValidationUid
    {
        get
        {
            return View_AllDataExtractView.Instance.ValidationUidColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT1_1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT1_1
    {
        get
        {
            return View_AllDataExtractView.Instance.FT1_1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT1_2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT1_2
    {
        get
        {
            return View_AllDataExtractView.Instance.FT1_2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT1_3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT1_3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT1_3
    {
        get
        {
            return View_AllDataExtractView.Instance.FT1_3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Description1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Description1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Description1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Description1
    {
        get
        {
            return View_AllDataExtractView.Instance.Description1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT2_1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT2_1
    {
        get
        {
            return View_AllDataExtractView.Instance.FT2_1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT2_2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT2_2
    {
        get
        {
            return View_AllDataExtractView.Instance.FT2_2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FT2_3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FT2_3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FT2_3
    {
        get
        {
            return View_AllDataExtractView.Instance.FT2_3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Description2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Description2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Description2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Description2
    {
        get
        {
            return View_AllDataExtractView.Instance.Description2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FTA2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FTA2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FTA2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FTA2
    {
        get
        {
            return View_AllDataExtractView.Instance.FTA2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FTA1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FTA1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.FTA1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FTA1
    {
        get
        {
            return View_AllDataExtractView.Instance.FTA1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item1
    {
        get
        {
            return View_AllDataExtractView.Instance.Item1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item2
    {
        get
        {
            return View_AllDataExtractView.Instance.Item2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item1a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item1aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item1a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item1a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item1aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item2a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item2aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item2a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item2a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item2aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item3
    {
        get
        {
            return View_AllDataExtractView.Instance.Item3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item4 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item4Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item4 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item4
    {
        get
        {
            return View_AllDataExtractView.Instance.Item4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item5 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item5Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item5 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item5
    {
        get
        {
            return View_AllDataExtractView.Instance.Item5Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item6 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item6Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item6 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item6
    {
        get
        {
            return View_AllDataExtractView.Instance.Item6Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item7 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Item7Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item7 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Item7
    {
        get
        {
            return View_AllDataExtractView.Instance.Item7Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item3a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item3aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item3a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item3a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item3aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item4a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item4aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item4a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item4a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item4aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item5a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item5aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item5a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item5a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item5aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item6a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item6aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item6a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item6a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item6aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item7a column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Item7aColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Item7a column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Item7a
    {
        get
        {
            return View_AllDataExtractView.Instance.Item7aColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon1
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon2
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon3 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon3Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon3 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon3
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon4 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon4Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon4 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon4
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon4Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon5 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon5Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon5 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon5
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon5Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon6 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon6Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon6 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon6
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon6Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon7 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Hon7Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's view_AllDataExtract_.Hon7 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Hon7
    {
        get
        {
            return View_AllDataExtractView.Instance.Hon7Column;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where clause.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where clause.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where and order by clause.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where and order by clause.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static View_AllDataExtractRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }   


    public static View_AllDataExtractRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }

    public static View_AllDataExtractRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }


    public static View_AllDataExtractRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }

    public static View_AllDataExtractRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (View_AllDataExtractRecord[])recList.ToArray(Type.GetType("OLR.Business.View_AllDataExtractRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)View_AllDataExtractView.Instance.GetCountResponseForPost(View_AllDataExtractView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of View_AllDataExtractRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = View_AllDataExtractView.Instance.GetRecordListResponseForPost(View_AllDataExtractView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)View_AllDataExtractView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)View_AllDataExtractView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)View_AllDataExtractView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)View_AllDataExtractView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_AllDataExtractRecord record using a where clause.
    /// </summary>
    public static View_AllDataExtractRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_AllDataExtractRecord record using a where clause.
    /// </summary>
    public static View_AllDataExtractRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a View_AllDataExtractRecord record using a where and order by clause.
    /// </summary>
    public static View_AllDataExtractRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_AllDataExtractRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_AllDataExtractRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a View_AllDataExtractRecord record using a where and order by clause.
    /// </summary>
    public static View_AllDataExtractRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = View_AllDataExtractView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        View_AllDataExtractRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (View_AllDataExtractRecord)recList[0];
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

        return View_AllDataExtractView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return View_AllDataExtractView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        View_AllDataExtractRecord[] recs = GetRecords(where);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        View_AllDataExtractRecord[] recs = GetRecords(join, where);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        View_AllDataExtractRecord[] recs = GetRecords(where, orderBy);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        View_AllDataExtractRecord[] recs = GetRecords(join, where, orderBy);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_AllDataExtractRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        View_AllDataExtractRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  View_AllDataExtractView.Instance.CreateDataTable(recs, null);
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
        View_AllDataExtractView.Instance.DeleteRecordList(whereFilter);
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
        
        return  View_AllDataExtractView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return View_AllDataExtractView.Instance.ExportRecordData(whereFilter);
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

        return View_AllDataExtractView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_AllDataExtractView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_AllDataExtractView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return View_AllDataExtractView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return View_AllDataExtractView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return View_AllDataExtractView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return View_AllDataExtractView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return View_AllDataExtractView.Instance.CreateRecord(tempId);
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
        BaseColumn column = View_AllDataExtractView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = View_AllDataExtractView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static View_AllDataExtractRecord GetRecord(string id, bool bMutable)
        {
            return (View_AllDataExtractRecord)View_AllDataExtractView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static View_AllDataExtractRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (View_AllDataExtractRecord)View_AllDataExtractView.Instance.GetRecordData(id, bMutable);
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
        string ValidationUidValue, 
        string FT1_1Value, 
        string FT1_2Value, 
        string FT1_3Value, 
        string Description1Value, 
        string FT2_1Value, 
        string FT2_2Value, 
        string FT2_3Value, 
        string Description2Value, 
        string FTA2Value, 
        string FTA1Value, 
        string Item1Value, 
        string Item2Value, 
        string Item1aValue, 
        string Item2aValue, 
        string Item3Value, 
        string Item4Value, 
        string Item5Value, 
        string Item6Value, 
        string Item7Value, 
        string Item3aValue, 
        string Item4aValue, 
        string Item5aValue, 
        string Item6aValue, 
        string Item7aValue, 
        string Hon1Value, 
        string Hon2Value, 
        string Hon3Value, 
        string Hon4Value, 
        string Hon5Value, 
        string Hon6Value, 
        string Hon7Value
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
        rec.SetString(ValidationUidValue, ValidationUidColumn);
        rec.SetString(FT1_1Value, FT1_1Column);
        rec.SetString(FT1_2Value, FT1_2Column);
        rec.SetString(FT1_3Value, FT1_3Column);
        rec.SetString(Description1Value, Description1Column);
        rec.SetString(FT2_1Value, FT2_1Column);
        rec.SetString(FT2_2Value, FT2_2Column);
        rec.SetString(FT2_3Value, FT2_3Column);
        rec.SetString(Description2Value, Description2Column);
        rec.SetString(FTA2Value, FTA2Column);
        rec.SetString(FTA1Value, FTA1Column);
        rec.SetString(Item1Value, Item1Column);
        rec.SetString(Item2Value, Item2Column);
        rec.SetString(Item1aValue, Item1aColumn);
        rec.SetString(Item2aValue, Item2aColumn);
        rec.SetString(Item3Value, Item3Column);
        rec.SetString(Item4Value, Item4Column);
        rec.SetString(Item5Value, Item5Column);
        rec.SetString(Item6Value, Item6Column);
        rec.SetString(Item7Value, Item7Column);
        rec.SetString(Item3aValue, Item3aColumn);
        rec.SetString(Item4aValue, Item4aColumn);
        rec.SetString(Item5aValue, Item5aColumn);
        rec.SetString(Item6aValue, Item6aColumn);
        rec.SetString(Item7aValue, Item7aColumn);
        rec.SetString(Hon1Value, Hon1Column);
        rec.SetString(Hon2Value, Hon2Column);
        rec.SetString(Hon3Value, Hon3Column);
        rec.SetString(Hon4Value, Hon4Column);
        rec.SetString(Hon5Value, Hon5Column);
        rec.SetString(Hon6Value, Hon6Column);
        rec.SetString(Hon7Value, Hon7Column);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			View_AllDataExtractView.Instance.DeleteOneRecord(kv);
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
				View_AllDataExtractView.GetRecord(kv, false);
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
            if (!(View_AllDataExtractView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return View_AllDataExtractView.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(View_AllDataExtractView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = View_AllDataExtractView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = View_AllDataExtractView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (View_AllDataExtractView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = View_AllDataExtractView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = View_AllDataExtractView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = View_AllDataExtractView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
