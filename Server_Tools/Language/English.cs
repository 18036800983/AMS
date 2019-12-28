using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools.Language
{
    public class English
    {
        #region MainForm
        public static string MainForm_Top_title = "Anwar Automation Engineering Co., Ltd.";

        public static string MainForm_Middle_title = "AMS intelligent manufacturing assembly system";

        public static string MainForm_TopBar_Setting = "Setting ";

        public static string MainForm_TopBar_Setting_sys = "System settings";

        public static string MainForm_TopBar_Setting_db = "Database settings";

        public static string MainForm_TopBar_Setting_user = "user settings";

        public static string MainForm_TopBar_Tool = " Tool ";

        public static string MainForm_TopBar_Tool_log = "Log query";

        public static string MainForm_TopBar_Tool_report = "Report Query";

        public static string MainForm_TopBar_Tool_analysis = "Alarm analysis";

        public static string MainForm_TopBar_Station = "Station";

        public static string MainForm_TopBar_Station_stationM = "Station management";

        public static string MainForm_TopBar_Station_plcAddr = "Production line management";

        public static string MainForm_TopBar_Recipe = "formula";

        public static string MainForm_TopBar_Recipe_production = "Product management";

        public static string MainForm_TopBar_Recipe_recipeM = "Recipe management";

        public static string MainForm_TopBar_Recipe_recipeInput = "Recipe import";

        public static string MainForm_TopBar_Plan = "Plan";

        public static string MainForm_TopBar_Plan_planM = "Work order management";

        public static string MainForm_TabControl_Log = "system";

        public static string MainForm_Log_System_Start = "System Start！";
        #endregion

        #region PlanManagerForm
        public static string PlanManagerForm_Top_title = "WorkOrderManagement";

        public static string PlanManagerForm_Plan_NO = "WorkOrderNumber";

        public static string PlanManagerForm_Production_NO = "ProductNumber";

        public static string PlanManagerForm_Plan_Describe = "WorkOrderDescribe";

        public static string PlanManagerForm_Plan_number = "PlanAmount";

        public static string PlanManagerForm_Button_save = "Save";

        public static string PlanManagerForm_Button_delete = "Delete";

        public static string PlanManagerForm_Button_cancel = "Cancel";

        public static string PlanManagerForm_log_save_proc = "The parameter cannot be empty, please check";

        public static string PlanManagerForm_log_modify_success = "Order information modified successfully！";

        public static string PlanManagerForm_log_add_success = "Order information added successfully！";

        public static string PlanManagerForm_log_save_exception = "Save button event exception：";

        public static string PlanManagerForm_log_delete_proc = "Work order number cannot be empty, please check";

        public static string PlanManagerForm_log_delete_success = "Work order information deleted successfully！";

        public static string PlanManagerForm_log_delete_exception = "Delete button event exception：";

        public static string PlanManagerForm_log_cancel_exception = "Cancel button event exception：";
        #endregion

        #region PlanManagerForm
        public static string ProductionManagerForm_Top_title = "Product management";

        public static string ProductionManagerForm_Production_node = "Product";

        public static string ProductionManagerForm_Production_name = "productName";

        public static string ProductionManagerForm__Production_no = "productNo";

        public static string ProductionManagerForm_Production_describe = "productDescribe";

        public static string ProductionManagerForm_Production_rule = "productRule";

        public static string ProductionManagerForm_Button_save = "save";

        public static string ProductionManagerForm_Button_delete = "delete";

        public static string ProductionManagerForm_Button_cancel = "cancel";

        public static string ProductionManagerForm_log_page_exception = "Abnormal page loading：";

        public static string ProductionManagerForm_log_save_proc = "Product name or product number cannot be empty！";

        public static string ProductionManagerForm_log_save_success = "Product saved successfully！";

        public static string ProductionManagerForm_log_save_exception = "The save operation is abnormal：";

        public static string ProductionManagerForm_log_delete_success = "Product deleted successfully!";

        public static string ProductionManagerForm_log_delete_fail = "Product removal failed!";

        public static string ProductionManagerForm_log_delete_exception = "Product deletion is abnormal：";
        #endregion

        #region RecipeInputForm
        public static string RecipeInputForm_Top_title = "Recipe import";

        public static string RecipeInputForm_label_ProductionName = "product name";

        public static string RecipeInputForm_Button_select = "select";

        public static string RecipeInputForm_Button_input = "Import";

        public static string RecipeInputForm_Button_exput = "Export";

        public static string RecipeInputForm_Button_save = "save";

        public static string RecipeInputForm_log_page_exception = "Abnormal page loading：";

        public static string RecipeInputForm_log_select_proc = "Please select a product name......";

        public static string RecipeInputForm_log_select_exception = "Query event exception：";

        public static string RecipeInputForm_log_input_tip = "Please select the Excel file to import";

        public static string RecipeInputForm_log_input_success = "The recipe was imported successfully. Please check the recipe carefully and save it.！";

        public static string RecipeInputForm_log_input_fail = "Import data is empty, please check EXCEL file！";

        public static string RecipeInputForm_log_input_exception = "Import recipe failed, please check the difference between EXCEL file format and template:";

        public static string RecipeInputForm_log_output_title = "Recipe export";

        public static string RecipeInputForm_log_output_success = "Excel export success。";

        public static string RecipeInputForm_log_output_fail = "Excel export failed。";

        public static string RecipeInputForm_log_output_exception = "Excel export failed:";

        public static string RecipeInputForm_log_save_success = "The recipe was saved successfully！";

        public static string RecipeInputForm_log_save_exception = "The recipe save event is abnormal.：";
        #endregion

        #region DBManageForm
        public static string DBManageForm_Top_title = "Database backup and restore";

        public static string DBManageForm_Group_tip = "Database backup to bak file";

        public static string DBManageForm_Button_backup = "backup database";

        public static string DBManageForm_Btton_recover = "Restore database";

        public static string DBManageForm_log_backup_success = "copy the database success！";

        public static string DBManageForm_log_backup_exception = "copy the database has exception：";

        public static string DBManageForm_log_recover_success = "restore the database success！";

        public static string DBManageForm_log_recover_exception = "copy the database has exception：";
        #endregion

        #region SystemSettingForm
        public static string SystemSettingForm_Top_title = "System settings";

        public static string SystemSettingForm_Db_tip = "Database settings";

        public static string SystemSettingForm_Db_serviceName = "server name";

        public static string SystemSettingForm_Db_dbName = "database name";

        public static string SystemSettingForm_Db_loginName = "Login name";

        public static string SystemSettingForm_Db_pwd = "login password";

        public static string SystemSettingForm_Db_backupPath = "Backup path";

        public static string SystemSettingForm_Db_dbType = "Database";

        public static string SystemSettingForm_SerialPort_tip = "Serial port settings";

        public static string SystemSettingForm_SerialPort_name = "SerialPort name";

        public static string SystemSettingForm_SerialPort_parity = "Parity";

        public static string SystemSettingForm_SerialPort_bandRate = "Baud rate";

        public static string SystemSettingForm_SerialPort_dataBits = "Data bit";

        public static string SystemSettingForm_SerialPort_stopBits = "Stop bit";

        public static string SystemSettingForm_Print_tip = "Printer settings";

        public static string SystemSettingForm_Print_IP = "Printer IP";

        public static string SystemSettingForm_Print_port = "port";

        public static string SystemSettingForm_Print_code = "Print code";

        public static string SystemSettingForm_sys_tip = "System settings";

        public static string SystemSettingForm_sys_isChinese = "display Chinese  ";

        public static string SystemSettingForm_sys_isClient = "have client  ";

        public static string SystemSettingForm_sys_startWithLogin = "start with login";

        public static string SystemSettingForm_sys_endWithLogin = "end with login";

        public static string SystemSettingForm_Button_save = "save";

        public static string SystemSettingForm_log_page_exception = "The configuration of the load is abnormal.：";

        public static string SystemSettingForm_log_save_success = "Save configuration successfully！";

        public static string SystemSettingForm_log_save_exception = "The save configuration is abnormal.：";
        #endregion

        #region UserManageForm
        public static string UserManageForm_Top_title = "User Management";

        public static string UserManageForm_Button_add = "New";

        public static string UserManageForm_Button_modify = "modify";

        public static string UserManageForm_Button_delete = "delete";

        public static string UserManageForm_Button_save = "save";

        public static string UserManageForm_Button_exit = "exit";

        public static string UserManageForm_User_tip = "user infomation";

        public static string UserManageForm_User_name = "account name";

        public static string UserManageForm_User_pwd = "Password";

        public static string UserManageForm_User_level = "Privilege";

        public static string UserManageForm_User_opLevel = "Operator";

        public static string UserManageForm_User_employeeID = "Employee ID";

        public static string UserManageForm_User_group = "Team";
        #endregion

        #region LogManagerForm
        public static string LogManagerForm_Top_title = "Log management";

        public static string LogManagerForm_Condition_time = " time";

        public static string LogManagerForm_Condition_others = " condition";

        public static string LogManagerForm_Button_select = "Select";

        public static string LogManagerForm_Button_exput = "Export";

        public static string LogManagerForm_Tree_node = "log";
        #endregion

        #region ReportManagerForm
        public static string ReportManagerForm_Top_title = "Report Query";

        public static string ReportManagerForm_Label_count = "query number：";

        public static string ReportManagerForm_Condition_time = "time：";

        public static string ReportManagerForm_Condition_serialN0 = "SN：";

        public static string ReportManagerForm_serialN0_tip = "Please enter the SN number";

        public static string ReportManagerForm_Condition_station = "station:";

        public static string ReportManagerForm_station_tip = "Input station";

        public static string ReportManagerForm_Button_select = "Start query";

        public static string ReportManagerForm_Button_exput = "export data";

        public static string ReportManagerForm_Table_tip = "Drag and drop a column to group here";
        #endregion

        #region RecipeManageForm
        public static string RecipeManageForm_Top_title = "Recipe management";

        public static string RecipeManageForm_Label_productionName = "productName";

        public static string RecipeManageForm_ProductionName_tip = "Need to be configured";

        public static string RecipeManageForm_Label_station = "station";

        public static string RecipeManageForm_Station_tip = "Need to be configured";

        public static string RecipeManageForm_Label_imagePath = "picturePath";

        public static string RecipeManageForm_ImagePath_tip = "Need to be configured";

        public static string RecipeManageForm_Label_step = "step";

        public static string RecipeManageForm_Step_tip = "All need to be configured, each station must be filled with consecutive numbers";

        public static string RecipeManageForm_Label_operationType = "operationType";

        public static string RecipeManageForm_OperationType_tip = "Need to be configured";

        public static string RecipeManageForm_Label_programNo = "programNo";

        public static string RecipeManageForm_ProgramNo_tip = "Tightening type needs to be configured";

        public static string RecipeManageForm_Label_checkRule = "checkRule";

        public static string RecipeManageForm_CheckRule_tip = "Scan type needs to be configured";

        public static string RecipeManageForm_Label_boltNo = "boltNo";

        public static string RecipeManageForm_BoltNo_tip = "Tightening type needs to be configured";

        public static string RecipeManageForm_Label_componentName = "componentName";

        public static string RecipeManageForm_ComponentName_tip = "All types of operations need to be configured except the beginning and the end.";

        public static string RecipeManageForm_Label_boltNumber = "boltNumber";

        public static string RecipeManageForm_BoltNumber_tip = "Tightening type needs to be configured";

        public static string RecipeManageForm_Label_componentNumber = "componentNumber";

        public static string RecipeManageForm_ComponentNumber_tip = "Scan type needs to be configured";

        public static string RecipeManageForm_Label_barcodeLength = "barcodeLength";

        public static string RecipeManageForm_BarcodeLength_tip = "Scan type needs to be configured";

        public static string RecipeManageForm_Label_sleeve = "sleeveNo";

        public static string RecipeManageForm_Label_stepDesc = "Descripe";

        public static string RecipeManageForm_Sleeve_tip = "Tightening type needs to be configured";

        public static string RecipeManageForm_Label_isTrace = "    Traceability";

        public static string RecipeManageForm_Label_isCheck = "    Whether to check";

        public static string RecipeManageForm_Button_save = "save";

        public static string RecipeManageForm_Button_cancel = "cancel";

        public static string RecipeManageForm_Button_delete = "delete";

        public static string RecipeManageForm_log_page_proc = "There is currently no product, please add the product first, then add the formula.！";

        public static string RecipeManageForm_log_page_exception = "The recipe interface is loaded abnormally.：";

        public static string RecipeManageForm_log_save_success = "The recipe was saved successfully！";

        public static string RecipeManageForm_log_save_exception = "Save the recipe abnormally：";

        public static string RecipeManageForm_log_delete_proc = "Product name, station, step cannot be empty！";

        public static string RecipeManageForm_log_delete_success = "Recipe deleted successfully！";

        public static string RecipeManageForm_log_delete_fail = "Recipe deletion failed！";

        public static string RecipeManageForm_log_delete_exception = "Abnormal deletion of recipe：";

        public static string RecipeManageForm_log_cancel_exception = "Cancel button click event exception：";

        public static string RecipeManageForm_log_check_err1 = "The necessary parameters cannot be empty!！";

        public static string RecipeManageForm_log_check_err2 = "The scan rule, part name, part number, and barcode length cannot be empty under scan type.！";

        public static string RecipeManageForm_log_check_err3 = "Under the tightening type, the program number, bolt number, part name, bolt quantity, and sleeve number cannot be empty.！";

        public static string RecipeManageForm_log_check_err4 = "Part name cannot be empty！";
        #endregion

        #region ReportAnalysisForm
        public static string ReportAnalysisForm_Top_title = "Alarm analysis";

        public static string ReportAnalysisForm_Label_starttime = " Start Time";

        public static string ReportAnalysisForm_Label_endtime = " End Time";

        public static string ReportAnalysisForm_Label_type = "Type";

        public static string ReportAnalysisForm_Label_singleitem = "Single item";

        public static string ReportAnalysisForm_Button_export = "Export image";

        public static string ReportAnalysisForm_Label_Cylindrical = "column chart";

        public static string ReportAnalysisForm_Label_line = "line chart";

        public static string ReportAnalysisForm_Label_pie = "pie chart";
        #endregion

        # region LoginForm
        public static string LoginForm_UserName = "User Name";
        public static string LoginForm_Password = "Password";
        public static string LoginForm_Sure = "Login";
        public static string LoginForm_Cancle = "Cancel";
        #endregion

        #region StationManageForm
        public static string StationManageForm_Top_title = "Station management";
        public static string StationManageForm_Label_stationName = "StationName";
        public static string StationManageForm_Label_stationOrder = "StationOrder";
        public static string StationManageForm_Label_isPass = "Shield";
        public static string StationManageForm_Label_isEndStation = "EndStation";
        public static string StationManageForm_Label_isOutLineStation = "OutlineStation";
        public static string StationManageForm_Button_save = "Save";
        public static string StationManageForm_Button_delete = "Delete";
        public static string StationManageForm_Button_cancel = "Cancel";
        #endregion

        #region LineManageForm
        public static string LineManageForm_Top_title = "Production line management";
        public static string LineManageForm_Button_save = "Save";
        public static string LineManageForm_Button_delete = "Delete";
        public static string LineManageForm_Button_cancel = "Cancel";
        public static string LineManageForm_Dataitem_name = "Name";
        public static string LineManageForm_Dataitem_address = "Address";
        public static string LineManageForm_Dataitem_columnName = "Clumn name";
        public static string LineManageForm_Dataitem_addressType = "Address type";
        public static string LineManageForm_Dataitem_addressLength = "Read length";
        public static string LineManageForm_Tag_name = "Name";
        public static string LineManageForm_Tag_tag = "Label";
        public static string LineManageForm_Tag_tableName = "Table Name";
        public static string LineManageForm_Opcitem_name = "Name";
        public static string LineManageForm_Opcitem_address = "Address";
        public static string LineManageForm_Opcitem_backAddress = "Feedback address";
        public static string LineManageForm_Opcitem_addressType = "Address type";
        public static string LineManageForm_Opcitem_operationDesc = "Operation description";
        public static string LineManageForm_Station_name = "Name";
        public static string LineManageForm_Station_desc = "Station description";
        public static string LineManageForm_Station_planTime = "Station beat";
        public static string LineManageForm_Station_alarmAddress = "Alarm address";
        public static string LineManageForm_Station_addressType = "Address type";
        public static string LineManageForm_Line_name = "Name";
        public static string LineManageForm_Line_index = "Index";
        public static string LineManageForm_Line_plcBrand = "PLC Brand";
        public static string LineManageForm_Line_threadCount = "Threads";
        public static string LineManageForm_Line_ip = "PLC IP";
        public static string LineManageForm_Line_plcSolt = "Card slot";
        public static string LineManageForm_Line_updateRate = "Update rate";
        public static string LineManageForm_Line_heartAddress = "Heartbeat address";
        public static string LineManageForm_Line_addressType = "Address type";
        #endregion
    }
}
