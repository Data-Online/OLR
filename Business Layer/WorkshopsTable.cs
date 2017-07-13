// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OLR.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseWorkshopsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseWorkshopsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseWorkshopsTable"></seealso>
/// <seealso cref="BaseWorkshopsSqlTable"></seealso>
/// <seealso cref="WorkshopsSqlTable"></seealso>
/// <seealso cref="WorkshopsDefinition"></seealso>
/// <seealso cref="WorkshopsRecord"></seealso>
/// <seealso cref="BaseWorkshopsRecord"></seealso>
[SerializableAttribute()]
public class WorkshopsTable : BaseWorkshopsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="WorkshopsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="WorkshopsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="WorkshopsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(WorkshopsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class WorkshopsTable_SerializationHelper"

    [SerializableAttribute()]
    private class WorkshopsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return WorkshopsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="WorkshopsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="WorkshopsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static WorkshopsTable Instance = new WorkshopsTable();

    public WorkshopsTable()
    {
    }


} // End class WorkshopsTable

}
