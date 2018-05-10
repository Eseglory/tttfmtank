using Fill.My.Tank.Common.PlaceHolder;
using System.Collections.Generic;

namespace Fill.My.Tank.Common.Core
{
    public static class ReportModuleDefinitions
    {
        //Module Category definitions
        public const string MODULE_CATEGORY_NAME = "REPORT_SE";
        public const string MODULE_CATEGORY_ALIAS = "Report";
        public const string MODULE_CATEGORY_CODE = "MCRRSE";
        public const string MODULE_CATEGORY_IMAGEURL = "";
        public const string MODULE_CATEGORY_COLOR = "";
        public const string MODULE_CATEGORY_DESCRIPTION = "";

        //Module definitions
        public const string MODULE_NAME = "REPORT_SE";
        public const string MODULE_ALIAS = "Core";
        public const string MODULE_CODE = "MRCRSE";
        public const string MODULE_DESCRIPTION = "";
        public const string MODULE_IMAGEURL = "";
        public const string MODULE_COLOR = "";
        public const string MODULE_VERSION = "REPORT v1.0";

        public const string DEFAULT_LANGUAGE = "English - United States";
        public const string DEFAULT_COUNTRY = "Nigeria";

        public const string GROUP_ADMINISTRATOR = "Administrator";
        public const string GROUP_USER = "User";

        public static List<RolePlaceHolder> GetRoleDefinitions()
        {
            var items = new List<RolePlaceHolder>();

            items.Add(new RolePlaceHolder() { Name = GROUP_ADMINISTRATOR ,Description="Report unlimited role"});
            items.Add(new RolePlaceHolder() { Name = GROUP_USER, Description = "Report limited role" });

            return items;
        }

        public static List<MenuPlaceHolder> GetMenuDefinitions()
        {
            var items = new List<MenuPlaceHolder>();

            var setups = new MenuPlaceHolder() { Code = "REM_REP", Name = "REM_REP", Alias = "Report", Action = "None", Controller = "None", ParentName = "None", Description = "", ImageUrl = "", Image = null };
            items.Add(setups);


            //Facility Management

            var FacilityManagement = new MenuPlaceHolder() { Code = "FC_FMM_REP", Name = "FAC_FCM_REP", Alias = "Facility", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-wrench", Image = null };
            items.Add(FacilityManagement);


            //Academic Plan

            var academicPlan = new MenuPlaceHolder() { Code = "ACP_REP", Name = "ACADEMIC_PLAN_REP", Alias = "Academic Plan", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-calendar", Image = null };
            items.Add(academicPlan);

            //Financial

            var financial = new MenuPlaceHolder() { Code = "FN_REP", Name = "FINANCIAL_REP", Alias = "Financial", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-money", Image = null };
            items.Add(financial);

            //items.Add(new MenuPlaceHolder() { Code = "FN_ERP", Name = "FINANCIAL_ERP_SETTINGS", Alias = "ERP Settings", Action = "ERPSelection", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-wrench", Image = null });

            //Document

            var documentManagement = new MenuPlaceHolder() { Code = "D_DM_REP", Name = "DOCUMENT_MANAG_REP", Alias = "Document", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-file-word-o", Image = null };
            items.Add(documentManagement);

            //items.Add(new MenuPlaceHolder() { Code = "DOC_CON", Name = "CONTAINER_DOC", Alias = "Containers", Action = "DocumentContainer", Controller = "Document", ParentName = documentManagement.Name, Description = "", ImageUrl = "fa-cubes", Image = null });

            //Communication

            var communication = new MenuPlaceHolder() { Code = "COM_REP", Name = "COMM_REP", Alias = "Communication", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-phone-square", Image = null };
            items.Add(communication);

            //items.Add(new MenuPlaceHolder() { Code = "CH_COM_C", Name = "CHANNELS_COM_C", Alias = "Channel", Action = "Channel", Controller = "Communication", ParentName = communication.Name, Description = "", ImageUrl = "fa-cog", Image = null });

            //Hostel

            var Hostel = new MenuPlaceHolder() { Code = "HOS_REP", Name = "HOS_REP", Alias = "Hostel", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-building", Image = null };
            items.Add(Hostel);


            //items.Add(new MenuPlaceHolder() { Code = "HS_CAT", Name = "HS_CAT", Alias = "Category", Action = "HostelCategory", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "fa-cog", Image = null });

            //Admission Test
            var admission = new MenuPlaceHolder() { Code = "ADM_REP", Name = "ADMISSION_REP", Alias = "Admission", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "Handshake-o", Image = null };
            items.Add(admission);

            //items.Add(new MenuPlaceHolder() { Code = "ADM_ADM_C", Name = "AMISSION_SETTING_ADM_C", Alias = "Admission Settings", Action = "AdmissionQualificationSubjectConfiguration", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-wrench", Image = null });            

            //TimeTable

            var timetable = new MenuPlaceHolder() { Code = "TMT_REP", Name = "TIME_TABLE_REP", Alias = "Timetable", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-calendar-o", Image = null };
            items.Add(timetable);

            //items.Add(new MenuPlaceHolder() { Code = "SMU_TT_C", Name = "SIMULATION_TT_C", Alias = "Simulation", Action = "Simulation", Controller = "TimeTable", ParentName = timetable.Name, Description = "", ImageUrl = "fa-calendar", Image = null });
            
            //Discipline

            var discipline = new MenuPlaceHolder() { Code = "DIS_REP", Name = "DISCIPLINE_REP", Alias = "Discipline", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-user", Image = null };
            items.Add(discipline);

            //items.Add(new MenuPlaceHolder() { Code = "DCS_COR", Name = "CATEGORY_SETUP_COR", Alias = "Category Setups", Action = "CategorySetup", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "fa-cog", Image = null });
           
            //Result

            var result = new MenuPlaceHolder() { Code = "RES_REP", Name = "RES_REP", Alias = "Result", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-file-word-o", Image = null };
            items.Add(result);

            //items.Add(new MenuPlaceHolder() { Code = "GS_RES_C", Name = "GRADE_SETUP_C", Alias = "Grade Setup", Action = "GradeSetup", Controller = "Result", ParentName = result.Name, Description = "", ImageUrl = "fa-file-excel-o", Image = null });
            
            //Medical

            var medical = new MenuPlaceHolder() { Code = "MED_REP", Name = "MED_REP", Alias = "Medical", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "fa-plus-square", Image = null };
            items.Add(medical);

            //items.Add(new MenuPlaceHolder() { Code = "HH_S", Name = "HH_SETUP", Alias = "Health History", Action = "PersonalHealthHistory", Controller = "Medical", ParentName = medical.Name, Description = "", ImageUrl = "fa-history", Image = null });

            return items;
        }

        public static List<MenuRolePlaceHolder> GetMenuRoleDefinitions()
        {
            var items = new List<MenuRolePlaceHolder>();

            //Administrator
            items.Add(new MenuRolePlaceHolder() { MenuName = "REM_REP", RoleName = GROUP_ADMINISTRATOR });
            
            //Facility
            items.Add(new MenuRolePlaceHolder() { MenuName = "FAC_FCM_REP", RoleName = GROUP_ADMINISTRATOR });
            
            //Academic Plan
            items.Add(new MenuRolePlaceHolder() { MenuName = "ACADEMIC_PLAN_REP", RoleName = GROUP_ADMINISTRATOR });

            //Financial
            items.Add(new MenuRolePlaceHolder() { MenuName = "FINANCIAL_REP", RoleName = GROUP_ADMINISTRATOR });

            //Document
            items.Add(new MenuRolePlaceHolder() { MenuName = "DOCUMENT_MANAG_REP", RoleName = GROUP_ADMINISTRATOR });

            //Communication
            items.Add(new MenuRolePlaceHolder() { MenuName = "COMM_REP", RoleName = GROUP_ADMINISTRATOR });

            //Hostel
            items.Add(new MenuRolePlaceHolder() { MenuName = "HOS_REP", RoleName = GROUP_ADMINISTRATOR });


            //Admission
            items.Add(new MenuRolePlaceHolder() { MenuName = "ADMISSION_REP", RoleName = GROUP_ADMINISTRATOR });

            //Time Table
            items.Add(new MenuRolePlaceHolder() { MenuName = "TIME_TABLE_REP", RoleName = GROUP_ADMINISTRATOR });

            //Discipline
            items.Add(new MenuRolePlaceHolder() { MenuName = "DISCIPLINE_REP", RoleName = GROUP_USER });

            //Result
            items.Add(new MenuRolePlaceHolder() { MenuName = "RES_REP", RoleName = GROUP_ADMINISTRATOR });

            //Med
            items.Add(new MenuRolePlaceHolder() { MenuName = "MED_REP", RoleName = GROUP_ADMINISTRATOR });

            return items;
        }
    }
}