﻿// This is a "safe" class, meaning that it is created once 
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
/// See <see cref="BasePhotoClubsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BasePhotoClubsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BasePhotoClubsTable"></seealso>
/// <seealso cref="BasePhotoClubsSqlTable"></seealso>
/// <seealso cref="PhotoClubsSqlTable"></seealso>
/// <seealso cref="PhotoClubsDefinition"></seealso>
/// <seealso cref="PhotoClubsRecord"></seealso>
/// <seealso cref="BasePhotoClubsRecord"></seealso>
[SerializableAttribute()]
public class PhotoClubsTable : BasePhotoClubsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="PhotoClubsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="PhotoClubsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PhotoClubsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(PhotoClubsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class PhotoClubsTable_SerializationHelper"

    [SerializableAttribute()]
    private class PhotoClubsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return PhotoClubsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="PhotoClubsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PhotoClubsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static PhotoClubsTable Instance = new PhotoClubsTable();

    public PhotoClubsTable()
    {
    }


} // End class PhotoClubsTable

}
