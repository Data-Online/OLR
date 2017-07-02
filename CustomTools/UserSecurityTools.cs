using BaseClasses.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CustomTools
{
    public class UserSecurityTools
    {
        public UserSecurityTools()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static bool UserInTheseRoles(string[] rollList, string[] roles)
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.Or_Operator, null);
            WhereClause whereClause = new WhereClause();

            // Find RoleId(s) for defined roles
            foreach (string r in rollList)
            {
                filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"NOIC.Business.Roles1Table, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Roles_.RoleName"), r, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            }
            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
            OLR.Business.Roles1Record[] roleDetails = OLR.Business.Roles1Table.GetRecords(whereClause, null, 0, 0);

            // Now test to see if current logging in user is assigned one of these roles.
            string[] matchedRoles = { };
            //string roles = "";
            foreach (var r in roleDetails)
            {
                matchedRoles = Array.FindAll(roles, s => s.Equals(r.RoleID.ToString()));
            }

            return (matchedRoles.Length > 0);

        }

        public static bool UserActive()
        {
            string userId = BaseClasses.Utils.SecurityControls.GetCurrentUserID();
            return OLR.Business.UsersTable.GetRecord(userId, false).Active;
        }

        public static void SetEventIdSessionVariable(bool anonymous)
        {
            string userId = "";

            if (anonymous)
            {
                userId = ConfigurationManager.AppSettings["ActiveRegistrationId"]; //"2";// Settings.ActiveRegistrationId;
            }
            else
            {
                userId = BaseClasses.Utils.SecurityControls.GetCurrentUserID();
            }

            // Get the record
            OLR.Business.UsersRecord myRecord = OLR.Business.UsersTable.GetRecord(userId, false);

            System.Web.HttpContext.Current.Session["ActiveEventId"] = myRecord.ActiveEventId;
        }
    }
}