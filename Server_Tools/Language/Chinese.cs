using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools.Language
{
    public class Chinese
    {
        #region MainForm
        public static string MainForm_Top_title = "昂华自动化工程股份有限公司";

        public static string MainForm_Middle_title = "   AMS智能制造装配系统";

        public static string MainForm_TopBar_Setting = "设置 ";

        public static string MainForm_TopBar_Setting_sys = "系统设置";

        public static string MainForm_TopBar_Setting_db = "数据库设置";

        public static string MainForm_TopBar_Setting_user = "用户设置";

        public static string MainForm_TopBar_Tool = " 工具 ";

        public static string MainForm_TopBar_Tool_log = "日志查询";

        public static string MainForm_TopBar_Tool_report = "报表查询";

        public static string MainForm_TopBar_Tool_analysis = "报警分析";

        public static string MainForm_TopBar_Station = "工位";

        public static string MainForm_TopBar_Station_stationM = "工位管理";

        public static string MainForm_TopBar_Station_plcAddr = "产线管理";

        public static string MainForm_TopBar_Recipe = "配方";

        public static string MainForm_TopBar_Recipe_production = "产品管理";

        public static string MainForm_TopBar_Recipe_recipeM = "配方管理";

        public static string MainForm_TopBar_Recipe_recipeInput = "配方导入";

        public static string MainForm_TopBar_Plan = "计划";

        public static string MainForm_TopBar_Plan_planM = "工单管理";

        public static string MainForm_TabControl_Log = "系统";

        public static string MainForm_Log_System_Start = "系统开启！";
        #endregion

        #region PlanManagerForm
        public static string PlanManagerForm_Top_title = "工单管理";

        public static string PlanManagerForm_Plan_NO = "工单编号";

        public static string PlanManagerForm_Production_NO = "产品编号";

        public static string PlanManagerForm_Plan_Describe = "工单描述";

        public static string PlanManagerForm_Plan_number = "计划量";

        public static string PlanManagerForm_Button_save = "保存";

        public static string PlanManagerForm_Button_delete = "删除";

        public static string PlanManagerForm_Button_cancel = "取消";

        public static string PlanManagerForm_log_save_proc = "参数不能为空，请检查";

        public static string PlanManagerForm_log_modify_success = "订单信息修改成功！";

        public static string PlanManagerForm_log_add_success = "订单信息添加成功！";

        public static string PlanManagerForm_log_save_exception = "保存按钮事件出现异常：";

        public static string PlanManagerForm_log_delete_proc = "工单号不能为空，请检查";

        public static string PlanManagerForm_log_delete_success = "工单信息删除成功！";

        public static string PlanManagerForm_log_delete_exception = "删除按钮事件出现异常：";

        public static string PlanManagerForm_log_cancel_exception = "取消按钮事件出现异常：";
        #endregion

        #region ProductionManagerForm
        public static string ProductionManagerForm_Top_title = "产品管理";

        public static string ProductionManagerForm_Production_node = "产品";

        public static string ProductionManagerForm_Production_name = "产品名称";

        public static string ProductionManagerForm__Production_no = "产品编号";

        public static string ProductionManagerForm_Production_describe = "产品描述";

        public static string ProductionManagerForm_Production_rule = "产品规则";

        public static string ProductionManagerForm_Button_save = "保存";

        public static string ProductionManagerForm_Button_delete = "删除";

        public static string ProductionManagerForm_Button_cancel = "取消";

        public static string ProductionManagerForm_log_page_exception = "页面加载出现异常：";

        public static string ProductionManagerForm_log_save_proc = "产品名称或者产品编号不能为空！";

        public static string ProductionManagerForm_log_save_success = "产品保存成功！";

        public static string ProductionManagerForm_log_save_exception = "保存操作出现异常：";

        public static string ProductionManagerForm_log_delete_success = "产品删除成功!";

        public static string ProductionManagerForm_log_delete_fail = "产品删除失败!";

        public static string ProductionManagerForm_log_delete_exception = "产品删除出现异常：";
        #endregion

        # region RecipeInputForm
        public static string RecipeInputForm_Top_title = "配方导入";

        public static string RecipeInputForm_label_ProductionName = "产品名称";

        public static string RecipeInputForm_Button_select = "查询";

        public static string RecipeInputForm_Button_input = "导入";

        public static string RecipeInputForm_Button_exput = "导出";

        public static string RecipeInputForm_Button_save = "保存";

        public static string RecipeInputForm_log_page_exception = "页面加载出现异常：";

        public static string RecipeInputForm_log_select_proc = "请选择产品名称......";

        public static string RecipeInputForm_log_select_exception = "查询事件出现异常：";

        public static string RecipeInputForm_log_input_tip = "请选择要导入的Excel文件";

        public static string RecipeInputForm_log_input_success = "导入配方成功，请仔细检查配方后保存！";

        public static string RecipeInputForm_log_input_fail = "导入数据为空，请检查EXCEL文件！";

        public static string RecipeInputForm_log_input_exception = "导入配方失败，请检查EXCEL文件格式与模板的差异:";

        public static string RecipeInputForm_log_output_title = "配方导出";

        public static string RecipeInputForm_log_output_success = "Excel导出成功。";

        public static string RecipeInputForm_log_output_fail = "Excel导出失败。";

        public static string RecipeInputForm_log_output_exception = "Excel导出失败:";

        public static string RecipeInputForm_log_save_success = "配方保存成功！";

        public static string RecipeInputForm_log_save_exception = "配方保存事件出现异常：";
        #endregion

        #region DBManageForm
        public static string DBManageForm_Top_title = "数据库备份还原";

        public static string DBManageForm_Group_tip = "数据库备份为bak文件";

        public static string DBManageForm_Button_backup = "备份数据库";

        public static string DBManageForm_Btton_recover = "还原数据库";

        public static string DBManageForm_log_backup_success = "备份数据库成功！";

        public static string DBManageForm_log_backup_exception = "备份数据库出现异常：";

        public static string DBManageForm_log_recover_success = "还原数据库成功！";

        public static string DBManageForm_log_recover_exception = "还原数据库出现异常：";
        #endregion

        #region SystemSettingForm
        public static string SystemSettingForm_Top_title = "系统设置";

        public static string SystemSettingForm_Db_tip = "数据库设置";

        public static string SystemSettingForm_Db_serviceName = "服务器名";

        public static string SystemSettingForm_Db_dbName = "数据库名";

        public static string SystemSettingForm_Db_loginName = "登录名称";

        public static string SystemSettingForm_Db_pwd = "登录密码";

        public static string SystemSettingForm_Db_backupPath = "备份路径";

        public static string SystemSettingForm_Db_dbType = "数 据 库";

        public static string SystemSettingForm_SerialPort_tip = "串口设置";

        public static string SystemSettingForm_SerialPort_name = "串口名";

        public static string SystemSettingForm_SerialPort_parity = "奇偶性";

        public static string SystemSettingForm_SerialPort_bandRate = "波特率";

        public static string SystemSettingForm_SerialPort_dataBits = "数据位";

        public static string SystemSettingForm_SerialPort_stopBits = "停止位";

        public static string SystemSettingForm_Print_tip = "打印机设置";

        public static string SystemSettingForm_Print_IP = "打印机IP";

        public static string SystemSettingForm_Print_port = "端口";

        public static string SystemSettingForm_Print_code = "打印代码";

        public static string SystemSettingForm_sys_tip = "系统设置";

        public static string SystemSettingForm_sys_isChinese = "是否显示中文  ";

        public static string SystemSettingForm_sys_isClient = "是否有客户端  ";

        public static string SystemSettingForm_sys_startWithLogin = "是否以登录开始";

        public static string SystemSettingForm_sys_endWithLogin = "是否以登录结束";

        public static string SystemSettingForm_Button_save = "保存";

        public static string SystemSettingForm_log_page_exception = "加载配置出现异常：";

        public static string SystemSettingForm_log_save_success = "保存配置成功！";

        public static string SystemSettingForm_log_save_exception = "保存配置出现异常：";
        #endregion

        #region UserManageForm
        public static string UserManageForm_Top_title = "用户管理";

        public static string UserManageForm_Button_add = "新增";

        public static string UserManageForm_Button_modify = "修改";

        public static string UserManageForm_Button_delete = "删除";

        public static string UserManageForm_Button_save = "保存";

        public static string UserManageForm_Button_exit = "退出";

        public static string UserManageForm_User_tip = "用户信息";

        public static string UserManageForm_User_name = "帐户名";

        public static string UserManageForm_User_pwd = "密   码";

        public static string UserManageForm_User_level = "权 限";

        public static string UserManageForm_User_opLevel = "操作权限";
        #endregion

        #region LogManagerForm
        public static string LogManagerForm_Top_title = "日志管理";

        public static string LogManagerForm_Condition_time = " 时间";

        public static string LogManagerForm_Condition_others = " 条件";

        public static string LogManagerForm_Button_select = "查询";

        public static string LogManagerForm_Button_exput = "导出";

        public static string LogManagerForm_Tree_node = "日志";
        #endregion

        #region ReportManagerForm
        public static string ReportManagerForm_Top_title = "报表查询";

        public static string ReportManagerForm_Label_count = "查询数量：";

        public static string ReportManagerForm_Condition_time = "时间：";

        public static string ReportManagerForm_Condition_serialN0 = "序列号：";

        public static string ReportManagerForm_serialN0_tip = "请输入序列号";

        public static string ReportManagerForm_Condition_station = "工位:";

        public static string ReportManagerForm_station_tip = "输入工位";

        public static string ReportManagerForm_Button_select = "开始查询";

        public static string ReportManagerForm_Button_exput = "导出数据";

        public static string ReportManagerForm_Table_tip = "拖拽一列到这里可以进行分组";
        #endregion

        #region RecipeManageForm
        public static string RecipeManageForm_Top_title = "配方管理";

        public static string RecipeManageForm_Label_productionName = "产品名称";

        public static string RecipeManageForm_ProductionName_tip = "都需配置";

        public static string RecipeManageForm_Label_station = "工    位";

        public static string RecipeManageForm_Station_tip = "都需配置";

        public static string RecipeManageForm_Label_imagePath = "图片路径";

        public static string RecipeManageForm_ImagePath_tip = "都需配置";

        public static string RecipeManageForm_Label_step = "步    序";

        public static string RecipeManageForm_Step_tip = "都需配置，每个工位必须填连续的数字";

        public static string RecipeManageForm_Label_operationType = "操作类型";

        public static string RecipeManageForm_OperationType_tip = "都需配置";

        public static string RecipeManageForm_Label_programNo = "程 序 号";

        public static string RecipeManageForm_ProgramNo_tip = "拧紧类型需配置";

        public static string RecipeManageForm_Label_checkRule = "校验规则";

        public static string RecipeManageForm_CheckRule_tip = "扫描类型需配置";

        public static string RecipeManageForm_Label_boltNo = "螺栓编号";

        public static string RecipeManageForm_BoltNo_tip = "拧紧类型需配置";

        public static string RecipeManageForm_Label_componentName = "部件名称";

        public static string RecipeManageForm_ComponentName_tip = "除开始结束以外其他操作类型都需要配置";

        public static string RecipeManageForm_Label_boltNumber = "螺栓数量";

        public static string RecipeManageForm_BoltNumber_tip = "拧紧类型需配置";

        public static string RecipeManageForm_Label_componentNumber = "部件数量";

        public static string RecipeManageForm_ComponentNumber_tip = "扫描类型需配置";

        public static string RecipeManageForm_Label_barcodeLength = "条码长度";

        public static string RecipeManageForm_BarcodeLength_tip = "扫描类型需配置";

        public static string RecipeManageForm_Label_sleeve = "套 筒 号";

        public static string RecipeManageForm_Label_stepDesc = "操作说明";

        public static string RecipeManageForm_Sleeve_tip = "拧紧类型需配置";

        public static string RecipeManageForm_Label_isTrace = "    是否追溯";

        public static string RecipeManageForm_Label_isCheck = "    是否校验";

        public static string RecipeManageForm_Button_save = "保存";

        public static string RecipeManageForm_Button_cancel = "取消";

        public static string RecipeManageForm_Button_delete = "删除";

        public static string RecipeManageForm_log_page_proc = "当前无产品，请先添加产品，再添加配方！";

        public static string RecipeManageForm_log_page_exception = "配方界面加载出现异常：";

        public static string RecipeManageForm_log_save_success = "配方保存成功！";

        public static string RecipeManageForm_log_save_exception = "保存配方出现异常：";

        public static string RecipeManageForm_log_delete_proc = "产品名称、工位、步序不能为空！";

        public static string RecipeManageForm_log_delete_success = "配方删除成功！";

        public static string RecipeManageForm_log_delete_fail = "配方删除失败！";

        public static string RecipeManageForm_log_delete_exception = "配方删除出现异常：";

        public static string RecipeManageForm_log_cancel_exception = "取消按钮点击事件出现异常：";

        public static string RecipeManageForm_log_check_err1 = "必要参数不能为空！请检查！";

        public static string RecipeManageForm_log_check_err2 = "扫描类型下，校验规则、部件名称、部件数量、条码长度不能为空！";

        public static string RecipeManageForm_log_check_err3 = "拧紧类型下，程序号、螺栓编号、部件名称、螺栓数量、套筒号不能为空！";

        public static string RecipeManageForm_log_check_err4 = "部件名称不能为空！";
        #endregion

        #region ReportAnalysisForm
        public static string ReportAnalysisForm_Top_title = "报警分析";

        public static string ReportAnalysisForm_Label_starttime = " 开始时间:";

        public static string ReportAnalysisForm_Label_endtime = " 结束时间:";

        public static string ReportAnalysisForm_Label_type = "类别:";

        public static string ReportAnalysisForm_Label_singleitem = "单项:";

        public static string ReportAnalysisForm_Button_export = "导出图片";

        public static string ReportAnalysisForm_Label_Cylindrical = "柱形图";

        public static string ReportAnalysisForm_Label_line = "折线图";

        public static string ReportAnalysisForm_Label_pie = "饼状图";
        #endregion

        # region LoginForm
        public static string LoginForm_UserName = "登录账号";
        public static string LoginForm_Password = "登录密码";
        public static string LoginForm_Sure = "登录";
        public static string LoginForm_Cancle = "取消";
        #endregion

        #region StationManageForm
        public static string StationManageForm_Top_title = "工位管理";
        public static string StationManageForm_Label_stationName = "工位名称";
        public static string StationManageForm_Label_stationOrder = "工位顺序";
        public static string StationManageForm_Label_isPass = "是否屏蔽";
        public static string StationManageForm_Label_isEndStation = "是否尾站";
        public static string StationManageForm_Label_isOutLineStation = "是否线外站";
        public static string StationManageForm_Button_save = "保存";
        public static string StationManageForm_Button_delete = "删除";
        public static string StationManageForm_Button_cancel = "取消";
        #endregion

        #region LineManageForm
        public static string LineManageForm_Top_title = "产线管理";
        public static string LineManageForm_Button_save = "保存";
        public static string LineManageForm_Button_delete = "删除";
        public static string LineManageForm_Button_cancel = "取消";
        public static string LineManageForm_Dataitem_name = "名 称";
        public static string LineManageForm_Dataitem_address = "地 址";
        public static string LineManageForm_Dataitem_columnName = "列名称";
        public static string LineManageForm_Dataitem_addressType = "地址类型";
        public static string LineManageForm_Dataitem_addressLength = "读取长度";
        public static string LineManageForm_Tag_name = "名 称";
        public static string LineManageForm_Tag_tag = "标 签";
        public static string LineManageForm_Tag_tableName = "表名称";
        public static string LineManageForm_Opcitem_name = "名 称";
        public static string LineManageForm_Opcitem_address = "地 址";
        public static string LineManageForm_Opcitem_backAddress = "反馈地址";
        public static string LineManageForm_Opcitem_addressType = "地址类型";
        public static string LineManageForm_Opcitem_operationDesc = "操作描述";
        public static string LineManageForm_Station_name = "名 称";
        public static string LineManageForm_Station_desc = "工位描述";
        public static string LineManageForm_Station_planTime = "工位节拍";
        public static string LineManageForm_Station_alarmAddress = "报警地址";
        public static string LineManageForm_Station_addressType = "地址类型";
        public static string LineManageForm_Line_name = "名 称";
        public static string LineManageForm_Line_index = "索 引";
        public static string LineManageForm_Line_plcBrand = "PLC品牌";
        public static string LineManageForm_Line_threadCount = "线程数";
        public static string LineManageForm_Line_ip = "PLC IP";
        public static string LineManageForm_Line_plcSolt = "卡槽号";
        public static string LineManageForm_Line_updateRate = "更新速率";
        public static string LineManageForm_Line_heartAddress = "心跳地址";
        public static string LineManageForm_Line_addressType = "地址类型";
        #endregion
    }
}
