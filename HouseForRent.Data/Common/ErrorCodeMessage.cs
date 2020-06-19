using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Common
{
    public class ErrorCodeMessage
    {
        #region Return Code (0 - 99): Common error
        public static KeyValuePair<int, string> Success = new KeyValuePair<int, string>(0, "The operation completed successfully.");
        public static KeyValuePair<int, string> IncorrectFunction = new KeyValuePair<int, string>(1, "Incorrect function");
        public static KeyValuePair<int, string> FileNotFound = new KeyValuePair<int, string>(2, "File not found");
        public static KeyValuePair<int, string> PathNotFound = new KeyValuePair<int, string>(3, "Path not found");
        public static KeyValuePair<int, string> AccessDenied = new KeyValuePair<int, string>(5, "Access denied");
        public static KeyValuePair<int, string> UploadFileFail = new KeyValuePair<int, string>(6, "File upload fail");
        public static KeyValuePair<int, string> ReportExisted = new KeyValuePair<int, string>(7, "Report for this PAC is existed");
        public static KeyValuePair<int, string> TemplateNotFound = new KeyValuePair<int, string>(8, "Template of report not found");
        public static KeyValuePair<int, string> ReportNotExisted = new KeyValuePair<int, string>(10, "Report does not exist");
        public static KeyValuePair<int, string> IdentityDuplicate = new KeyValuePair<int, string>(11, "Data is already exist.");
        public static KeyValuePair<int, string> DataNotExist = new KeyValuePair<int, string>(12, "Data is Not Exist.");
        #endregion

        #region Return Code (100 - 199): User/Account error
        public static KeyValuePair<int, string> UserNotExisted = new KeyValuePair<int, string>(100, "User not existed");
        public static KeyValuePair<int, string> UserInfoIncorrect = new KeyValuePair<int, string>(101, "User information is incorrect");
        public static KeyValuePair<int, string> UserInactivated = new KeyValuePair<int, string>(102, "User is inactivated");
        public static KeyValuePair<int, string> UserExisted = new KeyValuePair<int, string>(103, "User existed");
        public static KeyValuePair<int, string> UnauthorizedUser = new KeyValuePair<int, string>(103, "Unauthorized");
        public static KeyValuePair<int, string> AuthKeyNotFound = new KeyValuePair<int, string>(105, "Key for authentication not found");
        #endregion

        #region Return Code (200 - 299): Access Group/ Access Group Control Rights

        public static KeyValuePair<int, string> GroupHasUser = new KeyValuePair<int, string>(201, "Group has users");
        public static KeyValuePair<int, string> GroupNotExisted = new KeyValuePair<int, string>(203, "Group not existed");

        public static KeyValuePair<int, string> SheetNameNotFound = new KeyValuePair<int, string>(211, "Sheet Name Not Found");
        public static KeyValuePair<int, string> SheetNameIsRedundant = new KeyValuePair<int, string>(212, "Sheet Name Is Redundant");
        public static KeyValuePair<int, string> SheetNameNotValid = new KeyValuePair<int, string>(213, "Sheet Name Not Valid");

        public static KeyValuePair<int, string> PipelineIdNotExisted = new KeyValuePair<int, string>(221, "PipelineId not existed");

        public static KeyValuePair<int, string> DocumentNotFount = new KeyValuePair<int, string>(231, "Document not fount");
        #endregion

        #region Return Code (300 - 399): 

        #endregion

        #region Return Code (400 - 499): Web API error
        public static KeyValuePair<int, string> ParamIsNull = new KeyValuePair<int, string>(400, "Parameter(s) is null");
        public static KeyValuePair<int, string> ParamIsIncorrect = new KeyValuePair<int, string>(401, "Parameter(s) is incorrect");
        public static KeyValuePair<int, string> NotFound = new KeyValuePair<int, string>(404, "Not found");
        public static KeyValuePair<int, string> UnauthorizedAction = new KeyValuePair<int, string>(403, "Unauthorized Action");
        public static KeyValuePair<int, string> ObjectNotExisted = new KeyValuePair<int, string>(405, "Object Not found");
        public static KeyValuePair<int, string> ActionUnavailable = new KeyValuePair<int, string>(406, "Action not available");
        public static KeyValuePair<int, string> ParamOrMediaNotSupport = new KeyValuePair<int, string>(407, "Parameter(s)/Media Type does not supported");
        public static KeyValuePair<int, string> ApiError = new KeyValuePair<int, string>(408, "Api error, cannot get data");
        #region Incident
        public static KeyValuePair<int, string> TitleIsNull = new KeyValuePair<int, string>(405, "Title cannot be blanked");
        public static KeyValuePair<int, string> IncidientClassificationNotMajor = new KeyValuePair<int, string>(405, "This incident classification is not major");
        #endregion
        #endregion

        #region Return Code (500): Server error
        public const int ServerError = 500;
        #endregion
        #region MasterData Return Code (600-700)
        public static KeyValuePair<int, string> ModuleRequire = new KeyValuePair<int, string>(600, "ModuleID is Require.");
        public static KeyValuePair<int, string> SectionRequire = new KeyValuePair<int, string>(600, "Section is Require.");
        public static KeyValuePair<int, string> FieldTypeNotFound = new KeyValuePair<int, string>(2, "Field type not found.");
        #endregion

        #region RulesManage
        public static KeyValuePair<int, string> ModuleTypeNotFound = new KeyValuePair<int, string>(2, "ModuleType not found.");
        #endregion
    }
}
