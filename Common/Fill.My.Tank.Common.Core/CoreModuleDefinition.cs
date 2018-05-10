using Fill.My.Tank.Common.PlaceHolder;
using System.Collections.Generic;

namespace Fill.My.Tank.Common.Core
{
    public static class CoreModuleDefinitions
    {
        //Module Category definitions
        public const string MODULE_CATEGORY_NAME = "CORE_SE";
        public const string MODULE_CATEGORY_ALIAS = "Core";
        public const string MODULE_CATEGORY_CODE = "MCCRSE";
        public const string MODULE_CATEGORY_IMAGEURL = "";
        public const string MODULE_CATEGORY_COLOR = "";
        public const string MODULE_CATEGORY_DESCRIPTION = "General Setups";

        //Module definitions
        public const string MODULE_NAME = "CORE_SE";
        public const string MODULE_ALIAS = "Core";
        public const string MODULE_CODE = "MCRSE";
        public const string MODULE_DESCRIPTION = "";
        public const string MODULE_IMAGEURL = "";
        public const string MODULE_COLOR = "";
        public const string MODULE_VERSION = "CORE v1.0";

        public const string DEFAULT_LANGUAGE = "English - United States";
        public const string DEFAULT_COUNTRY = "Nigeria";

        public const string GROUP_ADMINISTRATOR = "Administrator";
        public const string GROUP_USER = "User";

        public static List<RolePlaceHolder> GetRoleDefinitions()
        {
            var items = new List<RolePlaceHolder>();

            items.Add(new RolePlaceHolder() { Name = GROUP_ADMINISTRATOR, Description = "Core unlimited role" });
            items.Add(new RolePlaceHolder() { Name = GROUP_USER, Description = "Core limited role" });

            return items;
        }

        public static List<MenuPlaceHolder> GetMenuDefinitions()
        {
            var items = new List<MenuPlaceHolder>();

            var setups = new MenuPlaceHolder() { Code = "SEP_COR", Name = "SETUP_COR", Alias = "General Setup", Action = "None", Controller = "None", ParentName = "None", Description = "", ImageUrl = "sf-icon-setup2", Image = null };
            items.Add(setups);

            items.Add(new MenuPlaceHolder() { Code = "MOD_COR", Name = "MODULE_COR", Alias = "License", Action = "Module", Controller = "Core", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-liscense2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "CONT_COR", Name = "COUNTRY_COR", Alias = "Countries", Action = "Country", Controller = "Core", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-country2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "LANG_COR", Name = "LANGUAGE_COR", Alias = "Languages", Action = "Language", Controller = "Core", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-language1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "RELG_COR", Name = "RELIGION_COR", Alias = "Religions", Action = "Religion", Controller = "Core", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-religion1", Image = null });

            var security = new MenuPlaceHolder() { Code = "SECR_COR", Name = "SECURITY_COR", Alias = "Security", Action = "None", Controller = "None", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-security1", Image = null };
            items.Add(security);

            var theme = new MenuPlaceHolder() { Code = "THME_COR", Name = "THEME_COR", Alias = "Theme", Action = "Theme", Controller = "Core", ParentName = setups.Name, Description = "", ImageUrl = "sf-icon-student6", Image = null };
            items.Add(theme);

            //items.Add(new MenuPlaceHolder() { Code = "MENU_COR", Name = "MENU_COR", Alias = "Menus", Action = "Menu", Controller = "Core", ParentName = security.Name, Description = "", ImageUrl = "fa-folder-open", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ROLE_COR", Name = "ROLE_COR", Alias = "Roles", Action = "Role", Controller = "Core", ParentName = security.Name, Description = "", ImageUrl = "fa-tasks", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "GRP_COR", Name = "GROUP_COR", Alias = "Groups", Action = "Group", Controller = "Core", ParentName = security.Name, Description = "", ImageUrl = "sf-icon-group1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "USER_COR", Name = "USER_COR", Alias = "Users", Action = "User", Controller = "Core", ParentName = security.Name, Description = "", ImageUrl = "sf-icon-user1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "CHP_COR", Name = "CHANGE_PASSWORD_COR", Alias = "Change Password", Action = "ChangePassword", Controller = "Core", ParentName = security.Name, Description = "", ImageUrl = "security2", Image = null });

            //Facility Management

            var parameters = new MenuPlaceHolder() { Code = "PAR_COR", Name = "PARAM_COR", Alias = "Parameter", Action = "None", Controller = "None", ParentName = "None", Description = "", ImageUrl = "sf-icon-group1", Image = null };
            items.Add(parameters);

            var FacilityManagement = new MenuPlaceHolder() { Code = "FC_FMM_COR", Name = "FAC_FCM_COR", Alias = "Facility", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-facility1", Image = null };
            items.Add(FacilityManagement);


            items.Add(new MenuPlaceHolder() { Code = "GP_FCM_COR", Name = "GRP_FCM_COR", Alias = "Asset Group", Action = "FacilityGroup", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "facility1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "CS_FCM_COR", Name = "CAT_FCM_COR", Alias = "Asset Category", Action = "FacilityCategory", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "facility2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ST_FCM_COR", Name = "STA_FCM_COR", Alias = "Status Setup", Action = "FacilityStatus", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-Spinner", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "PS_FCM_COR", Name = "PUR_FCM_COR", Alias = "Purpose Setup", Action = "FacilityPurpose", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-cog", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "TC_FCM_COR", Name = "TEC_FCM_COR", Alias = "Technician Setup", Action = "TechnicianCategory", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-spinner", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "VG_FCM_COR", Name = "VEG_FCM_COR", Alias = "Vendor Group", Action = "VendorGroup", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-cubes", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "VD_FCM_COR", Name = "VED_FCM_COR", Alias = "Vendor", Action = "Vendor", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-user", Image = null });

            //items.Add(new MenuPlaceHolder() { Code = "SE_FCM_COR", Name = "SER_FCM_COR", Alias = "Service Type", Action = "ServiceType", Controller = "FacilityManagement", ParentName = FacilityManagement.Name, Description = "", ImageUrl = "fa-wrench", Image = null });

           


            //Academic Plan

            var academicPlan = new MenuPlaceHolder() { Code = "ACP_COR", Name = "ACADEMIC_PLAN_COR", Alias = "Academic Plan", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-academics", Image = null };
            items.Add(academicPlan);

            items.Add(new MenuPlaceHolder() { Code = "ASCS_ACP_C", Name = "ACADEMIC_SETTING_ACP_C", Alias = "Academic Settings", Action = "AcademicSchoolSetting", Controller = "AcademicPlan", ParentName = academicPlan.Name, Description = "", ImageUrl = "sf-icon-setup1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ASS_ACP_C", Name = "ACADEMIC_SUBJECT_ACP_C", Alias = "Subject Settings", Action = "AcademicSubject", Controller = "AcademicPlan", ParentName = academicPlan.Name, Description = "", ImageUrl = "fa-wrench", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ASS_SUB_W", Name = "ACADEMIC_SUBJECT_ASS_W", Alias = "Subject Weight", Action = "AcademicSubjectAssessmentWeight", Controller = "AcademicPlan", ParentName = academicPlan.Name, Description = "", ImageUrl = "fa-book", Image = null });

            //Financial

            var financial = new MenuPlaceHolder() { Code = "FN_CR", Name = "FINANCIAL_COR", Alias = "Financial", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-finanical1", Image = null };
            items.Add(financial);

            items.Add(new MenuPlaceHolder() { Code = "FN_ERP", Name = "FINANCIAL_ERP_SETTINGS", Alias = "ERP Settings", Action = "ERPSelection", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-wrench", Image = null });


            items.Add(new MenuPlaceHolder() { Code = "MSC_ERP", Name = "STUDENT_ERP_MSC", Alias = "ERP Data Synch", Action = "MasterDataSynch", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-wrench", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "FN_ITEM", Name = "FINANCIAL_ITEM_CAT", Alias = "Item Setup", Action = "FeeCategory", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-spinner", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "FIN_FEP", Name = "FINANCIAL_FEE_PLAN", Alias = "Fee Schedule", Action = "FeePlan", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-calendar", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "FIN_GL", Name = "FINANCIAL_FEE_GL", Alias = "Setup GL-Account", Action = "FeeAccount", Controller = "Financial", ParentName = financial.Name, Description = "", ImageUrl = "fa-cog", Image = null });

            //Document

            var documentManagement = new MenuPlaceHolder() { Code = "D_DM", Name = "DOCUMENT_MANAGAMENT", Alias = "Document", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-document2", Image = null };
            items.Add(documentManagement);

            items.Add(new MenuPlaceHolder() { Code = "DOC_CON", Name = "CONTAINER_DOC", Alias = "Containers", Action = "DocumentContainer", Controller = "Document", ParentName = documentManagement.Name, Description = "", ImageUrl = "fa-cubes", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "DOC_CAT", Name = "CATEGORY_DOC", Alias = "Categories", Action = "DocumentCategory", Controller = "Document", ParentName = documentManagement.Name, Description = "", ImageUrl = "fa-cog", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "DOC_TYPE", Name = "TYPE_DOC", Alias = "Types", Action = "DocumentType", Controller = "Document", ParentName = documentManagement.Name, Description = "", ImageUrl = "fa-cubes", Image = null });

            //Communication

            var communication = new MenuPlaceHolder() { Code = "COM_COR", Name = "COMM_COR", Alias = "Communication", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-communication1", Image = null };
            items.Add(communication);

            items.Add(new MenuPlaceHolder() { Code = "CH_COM_C", Name = "CHANNELS_COM_C", Alias = "Channel", Action = "Channel", Controller = "Communication", ParentName = communication.Name, Description = "", ImageUrl = "sf-icon-communication2", Image = null });

            //Hostel

            var Hostel = new MenuPlaceHolder() { Code = "HOS_COR", Name = "HOS_COR", Alias = "Hostel", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-hostel1", Image = null };
            items.Add(Hostel);


            //items.Add(new MenuPlaceHolder() { Code = "HS_CAT", Name = "HS_CAT", Alias = "Category", Action = "HostelCategory", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "hostel1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "HS_CT_M", Name = "HS_CT_M", Alias = "Hostel List", Action = "HostelCategoryMap", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "hostel2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "HS_ROM", Name = "HS_ROM", Alias = "Room", Action = "RoomSetup", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "fa-home", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "HS_SUP", Name = "HS_SUP", Alias = "Porters", Action = "HostelSupervisor", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "fa-group", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "HS_HRUM", Name = "HS_HRUM", Alias = "Units", Action = "HostelRoomUnitMap", Controller = "Hostel", ParentName = Hostel.Name, Description = "", ImageUrl = "fa-key", Image = null });


            //Admission Test
            var admission = new MenuPlaceHolder() { Code = "ADM_COR", Name = "ADMISSION_COR", Alias = "Admission", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-admission1", Image = null };
            items.Add(admission);

            items.Add(new MenuPlaceHolder() { Code = "ADM_ADM_C", Name = "AMISSION_SETTING_ADM_C", Alias = "Admission Settings", Action = "AdmissionQualificationSubjectConfiguration", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "admission1", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ACB_ADM_C", Name = "AMISSION_CERTIFICATE_BODY_ADM_C", Alias = "Certificate Bodies", Action = "AdmissionCertificationExamBody", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "admission2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ASC_ADM_C", Name = "AMISSION_SUBJECT_CATEGORY_ADM_C", Alias = "Subject Category", Action = "AdmissionCertificationExamSubjectCategory", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-book", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ACB_ADM_M", Name = "AMISSION_MATRICULATION_BODY_ADM_M", Alias = "Matriculation Bodies", Action = "AdmissionMatriculationBody", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-institution", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "AGL_ADM_C", Name = "AMISSION_GRADE_LEVEL_ADM_C", Alias = "Grade Levels", Action = "AdmissionGradeLevel", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-level-up", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "AGL_ADM_P", Name = "AMISSION_PROGRAM_MANDATORY_SUBJECT_ADM_C", Alias = "Program Subject", Action = "AdmissionProgramMandatorySubject", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-book", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "ADS_ADM_C", Name = "AMISSION_STAGE_ADM_C", Alias = "Admission Stages", Action = "AdmissionStage", Controller = "Admission", ParentName = admission.Name, Description = "", ImageUrl = "fa-level-up", Image = null });


            //TimeTable

            var timetable = new MenuPlaceHolder() { Code = "TMT_COR", Name = "TIME_TABLE_COR", Alias = "Timetable", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-timetable1", Image = null };
            items.Add(timetable);

            items.Add(new MenuPlaceHolder() { Code = "SMU_TT_C", Name = "SIMULATION_TT_C", Alias = "Simulation", Action = "Simulation", Controller = "TimeTable", ParentName = timetable.Name, Description = "", ImageUrl = "fa-calendar", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "PGM_TT_C", Name = "PROGRAM_TT_C", Alias = "Weekly Schedule", Action = "ProgramTimeTable", Controller = "TimeTable", ParentName = timetable.Name, Description = "", ImageUrl = "fa-calendar-o", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "POS_TT_C", Name = "POST_TT_C", Alias = "Publish Time Table", Action = "PublishTimeTable", Controller = "TimeTable", ParentName = timetable.Name, Description = "", ImageUrl = "fa-calendar", Image = null });

            //Discipline

            var discipline = new MenuPlaceHolder() { Code = "DIS_COR", Name = "DISCIPLINE_COR", Alias = "Discipline", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-discipline1", Image = null };
            items.Add(discipline);

            items.Add(new MenuPlaceHolder() { Code = "DCS_COR", Name = "CATEGORY_SETUP_COR", Alias = "Category Setups", Action = "CategorySetup", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "setup2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "INC_COR", Name = "DISCIPLINE_PENALTY_SETUP_COR", Alias = "Penalty Setup", Action = "PenaltySetup", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "fa-spinner", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "DAP_COR", Name = "DISCIPLINE_PANEL_SETUP_COR", Alias = "Panel Setup", Action = "DisciplinePanel", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "fa-user", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "DPM_COR", Name = "DISCIPLINE_PANEL_MEMBERS_COR", Alias = "Panel Members", Action = "DisciplinePanelMembers", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "fa-user", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "DIO_COR", Name = "DISCIPLINE_DISCIPLINARY_OFFICER_COR", Alias = "Disciplinary Officer", Action = "DisciplinaryOfficer", Controller = "Discipline", ParentName = discipline.Name, Description = "", ImageUrl = "fa-group", Image = null });

            //Project Setup

            var projectSetups = new MenuPlaceHolder() { Code = "PS_COR", Name = "PROJECT_SETUP_COR", Alias = "Project", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-project2", Image = null };
            items.Add(projectSetups);

            items.Add(new MenuPlaceHolder() { Code = "PDS_PR", Name = "PROJECT_D_PR", Alias = "Project Definition", Action = "ProjectDefinition", Controller = "Project", ParentName = projectSetups.Name, Description = "", ImageUrl = "fa-file-word-o", Image = null });

            //Result

            var result = new MenuPlaceHolder() { Code = "RES_COR", Name = "RES_COR", Alias = "Result", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-result1", Image = null };
            items.Add(result);

            items.Add(new MenuPlaceHolder() { Code = "GS_RES_C", Name = "GRADE_SETUP_C", Alias = "Grade Setup", Action = "GradeSetup", Controller = "Result", ParentName = result.Name, Description = "", ImageUrl = "fa-file-excel-o", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "GCP_RES_C", Name = "GRADE_PROCEDURE_C", Alias = "Grading Procedure", Action = "GradeComputationProcedure", Controller = "Result", ParentName = result.Name, Description = "", ImageUrl = "fa-file-word-o", Image = null });

            //Medical

            var medical = new MenuPlaceHolder() { Code = "MED_COR", Name = "MED_COR", Alias = "Medical", Action = "None", Controller = "None", ParentName = parameters.Name, Description = "", ImageUrl = "sf-icon-medical1", Image = null };
            items.Add(medical);

            items.Add(new MenuPlaceHolder() { Code = "HH_S", Name = "HH_SETUP", Alias = "Health History", Action = "PersonalHealthHistory", Controller = "Medical", ParentName = medical.Name, Description = "", ImageUrl = "medical2", Image = null });

            items.Add(new MenuPlaceHolder() { Code = "IL_SET", Name = "IL_SETUP", Alias = "Illness Setup", Action = "Illness", Controller = "Medical", ParentName = medical.Name, Description = "", ImageUrl = "fa-hospital-o", Image = null });

            return items;
        }

        public static List<MenuRolePlaceHolder> GetMenuRoleDefinitions()
        {
            var items = new List<MenuRolePlaceHolder>();

            //Administrator
            items.Add(new MenuRolePlaceHolder() { MenuName = "SETUP_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "PARAM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "MODULE_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "COUNTRY_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "LANGUAGE_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "RELIGION_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "SECURITY_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "GROUP_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "USER_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "ROLE_COR", RoleName = GROUP_ADMINISTRATOR });
            //items.Add(new MenuRolePlaceHolder() { MenuName = "MENU_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "THEME_COR", RoleName = GROUP_ADMINISTRATOR });

            //Facility
            items.Add(new MenuRolePlaceHolder() { MenuName = "FAC_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "GRP_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "CAT_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "STA_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "PUR_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "TEC_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "VEG_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "VED_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
            //items.Add(new MenuRolePlaceHolder() { MenuName = "SER_FCM_COR", RoleName = GROUP_ADMINISTRATOR });
           


            //Academic Plan
            items.Add(new MenuRolePlaceHolder() { MenuName = "ACADEMIC_SETTING_ACP_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "ACADEMIC_SUBJECT_ACP_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "ACADEMIC_SUBJECT_ASS_W", RoleName = GROUP_ADMINISTRATOR });

            //Financial
            items.Add(new MenuRolePlaceHolder() { MenuName = "FINANCIAL_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "FINANCIAL_ERP_SETTINGS", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "FINANCIAL_ITEM_CAT", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "STUDENT_ERP_MSC", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "FINANCIAL_FEE_GL", RoleName = GROUP_ADMINISTRATOR });


            //Document
            items.Add(new MenuRolePlaceHolder() { MenuName = "DOCUMENT_MANAGAMENT", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "CONTAINER_DOC", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "CATEGORY_DOC", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "TYPE_DOC", RoleName = GROUP_ADMINISTRATOR });

            //Communication
            items.Add(new MenuRolePlaceHolder() { MenuName = "COMM_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "CHANNELS_COM_C", RoleName = GROUP_ADMINISTRATOR });

            //Hostel
            items.Add(new MenuRolePlaceHolder() { MenuName = "HOS_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HS_CAT", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HS_CT_M", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HS_ROM", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HS_SUP", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HS_HRUM", RoleName = GROUP_ADMINISTRATOR });


            //Admission
            items.Add(new MenuRolePlaceHolder() { MenuName = "ADMISSION_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_SETTING_ADM_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_CERTIFICATE_BODY_ADM_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_SUBJECT_CATEGORY_ADM_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_MATRICULATION_BODY_ADM_M", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_GRADE_LEVEL_ADM_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_PROGRAM_MANDATORY_SUBJECT_ADM_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "AMISSION_STAGE_ADM_C", RoleName = GROUP_ADMINISTRATOR });

            //Time Table
            items.Add(new MenuRolePlaceHolder() { MenuName = "SIMULATION_TT_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "POST_TT_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "PROGRAM_TT_C", RoleName = GROUP_ADMINISTRATOR });

            //Discipline
            items.Add(new MenuRolePlaceHolder() { MenuName = "DISCIPLINE_COR", RoleName = GROUP_USER });
            items.Add(new MenuRolePlaceHolder() { MenuName = "CATEGORY_SETUP_COR", RoleName = GROUP_USER });
            items.Add(new MenuRolePlaceHolder() { MenuName = "DISCIPLINE_PENALTY_SETUP_COR", RoleName = GROUP_USER });
            items.Add(new MenuRolePlaceHolder() { MenuName = "DISCIPLINE_PANEL_SETUP_COR", RoleName = GROUP_USER });
            items.Add(new MenuRolePlaceHolder() { MenuName = "DISCIPLINE_PANEL_MEMBERS_COR", RoleName = GROUP_USER });

            //Project
            items.Add(new MenuRolePlaceHolder() { MenuName = "PROJECT_SETUP_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "PROJECT_D_PR", RoleName = GROUP_ADMINISTRATOR });

            //Result
            items.Add(new MenuRolePlaceHolder() { MenuName = "RES_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "GRADE_SETUP_C", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "GRADE_PROCEDURE_C", RoleName = GROUP_ADMINISTRATOR });

            //Med
            items.Add(new MenuRolePlaceHolder() { MenuName = "MED_COR", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "HH_SETUP", RoleName = GROUP_ADMINISTRATOR });
            items.Add(new MenuRolePlaceHolder() { MenuName = "IL_SETUP", RoleName = GROUP_ADMINISTRATOR });



            return items;
        }
    }
}