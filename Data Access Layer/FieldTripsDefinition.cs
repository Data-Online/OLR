﻿using System;

namespace OLR.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="FieldTripsTable">OLR.FieldTripsTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="FieldTripsTable"></seealso>
public class FieldTripsDefinition
{
#region "Definition (XML) for FieldTripsDefinition table"
	//Next 249 lines contain Table Definition (XML) for table "FieldTripsDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="FieldTripsTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.2"" Type=""GENERIC"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>FieldTripId</columnName>");
         tbf.Append(      @"<columnUIName>Field Trip</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>Y</columnIndex>");
         tbf.Append(      @"<columnUnique>Y</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>Y</columnComputed>");
         tbf.Append(      @"<columnIdentity>Y</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>Y</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>Y</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>Description</columnName>");
         tbf.Append(      @"<columnUIName>Description</columnUIName>");
         tbf.Append(      @"<columnType>String</columnType>");
         tbf.Append(      @"<columnDBType>nvarchar</columnDBType>");
         tbf.Append(      @"<columnLengthSet>100</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation>Latin1_General_CI_AS</columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>Date</columnName>");
         tbf.Append(      @"<columnUIName>Date</columnUIName>");
         tbf.Append(      @"<columnType>Date</columnType>");
         tbf.Append(      @"<columnDBType>date</columnDBType>");
         tbf.Append(      @"<columnLengthSet></columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnFormat>d</columnFormat>");
         tbf.Append(      @"<columnDBFormat>d</columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">");
         tbf.Append(      @"<columnName>Time</columnName>");
         tbf.Append(      @"<columnUIName>Time</columnUIName>");
         tbf.Append(      @"<columnType>Date</columnType>");
         tbf.Append(      @"<columnDBType>time</columnDBType>");
         tbf.Append(      @"<columnLengthSet></columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnFormat>t</columnFormat>");
         tbf.Append(      @"<columnDBFormat>t</columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">");
         tbf.Append(      @"<columnName>EventId</columnName>");
         tbf.Append(      @"<columnUIName>Event</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault>= Session(&quot;ActiveEventId&quot;)</columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed Source=""User"">N</columnComputed>");
         tbf.Append(      @"<columnIdentity Source=""User"">N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly Source=""User"">N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive Source=""User"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText Source=""User"">N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_FieldTrips_Events</columnFKName>");
         tbf.Append(        @"<columnFKTable>OLR.Business.EventsTable, OLR.Business</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>EventId</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>=Events.EventName</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>Y</applyDefaultValue>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(      @"<InternalName>4</InternalName>");
         tbf.Append(      @"<columnTableClassName></columnTableClassName>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">");
         tbf.Append(      @"<columnName>DisplaySequence</columnName>");
         tbf.Append(      @"<columnUIName>Display Sequence</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>FieldTrips</TableName>");
         tbf.Append(  @"<Version>2</Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>FieldTrips_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseOLR_db</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>");
         tbf.Append(  @"<AppShortName>OLR</AppShortName>");
         tbf.Append(  @"<TableCodeName>FieldTrips</TableCodeName>");
         tbf.Append(  @"<FolderName>FieldTrips</FolderName>");
         tbf.Append(  @"<MenuName>Field Trips</MenuName>");
         tbf.Append(  @"<QSPath>../FieldTrips/FieldTrips-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableStoredProcPrefix>pOLRFieldTrips</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
