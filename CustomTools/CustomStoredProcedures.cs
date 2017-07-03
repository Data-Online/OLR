using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomTools
{
    public class CustomStoredProcedures
    {
        public static bool FlagRegistrationAsDeleted(string contactId)
        {

            bool statusOkay = false;
            //BaseClasses.Data.StoredProcedureParameter firstParameter = null;

            BaseClasses.Data.StoredProcedureParameter firstParameter = new BaseClasses.Data.StoredProcedureParameter("@contactId", Int32.Parse(contactId), System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input);
            //BaseClasses.Data.StoredProcedureParameter OutputPara1 = new BaseClasses.Data.StoredProcedureParameter("@statusOkay", 0, System.Data.SqlDbType.Bit, System.Data.ParameterDirection.Output); 

            // Step 2: Add the configured parameters to an array list.
            BaseClasses.Data.StoredProcedureParameter[] parameterList = new BaseClasses.Data.StoredProcedureParameter[1];
            parameterList[0] = firstParameter;
            //parameterList[1] = OutputPara1;
            BaseClasses.Data.StoredProcedure myStoredProcedure = null;


            // Step 3: Connect to the stored procedure.
            string spName = string.Format("sp_upd_{0}", "MarkRegistrationAsDeleted");
            myStoredProcedure = new BaseClasses.Data.StoredProcedure("DatabaseOLR_db", spName, parameterList);

            // Step 4: Run the stored procedure to insert a new record using the specified values.    
            // RunNonQuery() will return true if stored procedure successfully executed. Otherwise, it will return false.
            // Use RunQuery or RunNonQuery.  RunQuery is used when a set of records is being returned.  RunNonQuery is used when one or more values are returned through output parameters.
            if (myStoredProcedure.RunNonQuery())
            {
                statusOkay = true;
            }
            else
            {
                ///IMPORTANT: If you raise an error that has a severity level of 10 or less, it is considered  
                ///a warning, and no exception is raised. The severity of the error must be between 11 and 20
                ///for an exception to be thrown.

                var message = myStoredProcedure.ErrorMessage;
                statusOkay = false;
            }

            //results.Tables[0].Columns.Add("Sprite",typeof(object));

            return statusOkay;

        }

    }


}