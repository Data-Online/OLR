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
/// See <see cref="BaseView_RegisteredView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseView_RegisteredView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseView_RegisteredView"></seealso>
/// <seealso cref="BaseView_RegisteredSqlView"></seealso>
/// <seealso cref="View_RegisteredSqlView"></seealso>
/// <seealso cref="View_RegisteredDefinition"></seealso>
/// <seealso cref="View_RegisteredRecord"></seealso>
/// <seealso cref="BaseView_RegisteredRecord"></seealso>
[SerializableAttribute()]
public class View_RegisteredView : BaseView_RegisteredView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="View_RegisteredView_SerializationHelper"></see> class 
    /// for deserialization of <see cref="View_RegisteredView"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="View_RegisteredView"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(View_RegisteredView_SerializationHelper)); //No other values need to be added
    }

#region "Class View_RegisteredView_SerializationHelper"

    [SerializableAttribute()]
    private class View_RegisteredView_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return View_RegisteredView.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="View_RegisteredView"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="View_RegisteredView"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static View_RegisteredView Instance = new View_RegisteredView();

    public View_RegisteredView()
    {
    }


} // End class View_RegisteredView

}
