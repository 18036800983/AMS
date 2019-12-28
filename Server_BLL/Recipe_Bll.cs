using Server_Modle.DBase;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Recipe_Bll
    {
        public delegate void recodeRecipeLog(string name, string message, int b, bool showFlag);
        public static recodeRecipeLog recodeRecipeMessage;
        public static Dictionary<string, Dictionary<int, Dictionary<string, string>>> RecipesDic = new Dictionary<string, Dictionary<int, Dictionary<string, string>>>();
        private static Dictionary<string, Dictionary<string, string>> StationsDic = new Dictionary<string, Dictionary<string, string>>();
        static object _lock = new object();
        static Trace_StationStatus_Bll trace_StationStatus_Bll = new Trace_StationStatus_Bll();
        static Trace_StationStatus_Modle trace_StationStatus_Modle = new Trace_StationStatus_Modle();
        static Trace_Bolt_Bll trace_Bolt_Bll = new Trace_Bolt_Bll();

        /// <summary>
        /// recipe init
        /// </summary>
        public static void Init()
        {
            foreach (var lineNode in XML_Tool.xml.LINE)
            {
                foreach (var stationName in lineNode.STATION)
                {
                    #region>>>>>初始化工位缓存信息
                    Dictionary<string, string> station = new Dictionary<string, string>();
                    station.Add("Step", "");
                    station.Add("SN", "");
                    StationsDic.Add(stationName.Name, station);
                    #endregion
                }
            }
        }

        /// <summary>
        /// 加载对应工位下对应产品的配方
        /// </summary>
        /// <param name="production"></param>
        /// <param name="stationName"></param>
        public static bool LoadRecipes(string production, string stationName)
        {
            try
            {
                if (RecipesDic.Count > 0)
                {
                    RecipesDic.Clear();
                }
                List<Crafts_Recipe_Modle> recipeList = Crafts_Recipe_Bll.GetRecipesByProductionAndStation(production, stationName);
                if (recipeList.Count > 0)
                {
                    Dictionary<int, Dictionary<string, string>> rp = new Dictionary<int, Dictionary<string, string>>();
                    foreach (Crafts_Recipe_Modle crm in recipeList)
                    {
                        Dictionary<string, string> recipe = new Dictionary<string, string>();
                        recipe.Add("RecipeID", crm.RecipeID.ToString());
                        recipe.Add("ProductionName", crm.ProductionName);
                        recipe.Add("Station", crm.Station);
                        recipe.Add("Step", crm.Step.ToString());
                        recipe.Add("OperationType", crm.OperationType);
                        recipe.Add("ProgramNo", crm.ProgramNo);
                        recipe.Add("CheckRule", crm.CheckRule);
                        recipe.Add("BlotNo", crm.BlotNo);
                        recipe.Add("ComponentName", crm.ComponentName);
                        recipe.Add("BlotNumber", crm.BlotNumber.ToString());
                        recipe.Add("ComponentNNumber", crm.ComponentNNumber.ToString());
                        recipe.Add("BarcodeLength", crm.BarcodeLength.ToString());
                        recipe.Add("Istrace", crm.Istrace.ToString());
                        recipe.Add("IsCheck", crm.IsCheck.ToString());
                        recipe.Add("ImagePath", crm.ImagePath);
                        recipe.Add("SleeveNo", crm.SleeveNo.ToString());
                        recipe.Add("StepDescription",crm.StepDesc);
                        rp.Add(Convert.ToInt32(crm.Step), recipe);
                    }
                    RecipesDic.Add(stationName, rp);
                    //WriteCacheStationInfo(stationName, "ToalStep", recipeList.Count.ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        /// <summary>
        /// 
        /// 获取单步配方信息
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="stepNo"></param>
        /// <returns></returns>
        public static Crafts_Recipe_Modle GetSingleRecipe(string stationName, int stepNo)
        {
            Crafts_Recipe_Modle crm = null;
            Dictionary<int, Dictionary<string, string>> stationRecipes = RecipesDic[stationName];
            Dictionary<string, string> recipe = stationRecipes[stepNo];
            if (recipe.Count > 0)
            {
                crm = new Crafts_Recipe_Modle
                {
                    RecipeID = int.Parse(recipe["RecipeID"].ToString()),
                    ProductionName = recipe["ProductionName"],
                    Station = recipe["Station"],
                    Step = int.Parse(recipe["Step"].ToString()),
                    OperationType = recipe["OperationType"],
                    ProgramNo = recipe["ProgramNo"],
                    CheckRule = recipe["CheckRule"],
                    BlotNo = recipe["BlotNo"],
                    ComponentName = recipe["ComponentName"],
                    BlotNumber = int.Parse(recipe["BlotNumber"].ToString()),
                    ComponentNNumber = int.Parse(recipe["ComponentNNumber"].ToString()),
                    BarcodeLength = int.Parse(recipe["BarcodeLength"].ToString()),
                    Istrace = int.Parse(recipe["Istrace"].ToString()),
                    IsCheck = int.Parse(recipe["IsCheck"].ToString()),
                    ImagePath = recipe["ImagePath"],
                    SleeveNo = int.Parse(recipe["SleeveNo"]),
                    StepDesc = recipe["StepDescription"]
                };
            }
            return crm;
        }
        /// <summary>
        /// 写入工位缓存信息
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="item"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void WriteCacheStationInfo(string stationName, string item, string value)
        {
            StationsDic[stationName][item] = value;
        }
        /// <summary>
        /// 读取工位缓存信息
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetCacheStationInfo(string stationName, string item)
        {
            return StationsDic[stationName][item];
        }
        /// <summary>
        /// 清空工位缓存的信息
        /// </summary>
        /// <param name="stationName"></param>
        public static void ResetCacheStationInfo(string stationName)
        {
            StationsDic[stationName]["Step"] = "";
            StationsDic[stationName]["SN"] = "";
        }
        /// <summary>
        /// 清空工位配方
        /// </summary>
        public static void ResetCacheStationRecipeInfo(string stationName)
        {
            RecipesDic.Remove(stationName);
        }

        /// <summary>
        /// 更新步序和下发类别
        /// </summary>
        /// <param name="line"></param>
        /// <param name="station"></param>
        /// <param name="packPn"></param>
        /// <param name="step"></param>
        public static void Business(string lineName, string station, int step)
        {
            #region 检查当前步是否大于总步数
            //string ss = Recipe_Bll.GetCacheStationInfo(station, "TotalStep");
            //int totalStep = int.Parse(Recipe_Bll.GetCacheStationInfo(station, "TotalStep"));
            //if (step > totalStep)
            //{
            //    recodeRecipeMessage(lineName + station, "Current step can not more than the total Step, Current step:" + step + " , total step:" + totalStep, 1, true);
            //    return;
            //}
            #endregion

            #region 变量
            Recipe_Bll.WriteCacheStationInfo(station, "Step", step.ToString());
            var lineObj = XML_Tool.xml.LINE.Single(n => n.Name == lineName);
            var stationObj = lineObj.STATION.Single(n => n.Name == station);
            Crafts_Recipe_Modle crafts_Recipe_Modle = GetSingleRecipe(station, step);
            #endregion

            #region 配方为空
            if (crafts_Recipe_Modle == null)
            {
                recodeRecipeMessage(lineName + station, "Station：" + station + " , Step：" + step + " ,Formula not found！", 1, true);
                return;
            }
            #endregion

            #region 扫描
            if (crafts_Recipe_Modle.OperationType == "扫描" || crafts_Recipe_Modle.OperationType == "Scanning")
            {
                var opcObj = stationObj.Opcitem.Single(n => n.Name == "物料记录");
                string backAddr = opcObj.BackAddr;
                if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "21", opcObj.AddrType, 0))
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                        + step + " ,Send scan address：" + backAddr + " , Write value ：21 ，Successfully written！", 0, true);
                }
                else
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                        + step + " ,Send scan address：" + backAddr + " , Write value ：21 ，Write failure！", 0, true);
                }
            }
            #endregion

            #region 拧紧
            if (crafts_Recipe_Modle.OperationType == "拧紧" || crafts_Recipe_Modle.OperationType == "Tighten")
            {
                var opcObj = stationObj.Opcitem.Single(n => n.Name == "拧紧记录");
                string backAddr = opcObj.BackAddr;
                var dataitemObj = opcObj.Tag.Single(n => n.Name == "拧紧下发").Dataitem;
                foreach (var data in dataitemObj)
                {
                    string sn = Recipe_Bll.GetCacheStationInfo(station, "SN");
                    if (data.ColmnName == "SN")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, sn, data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                                                    + step + " ,SN：" + data.Addr + " , Write value ："
                                                                    + sn + " ，Successfully written！", 0, false);
                        }
                    }
                    if (data.ColmnName == "BlotNumber")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, crafts_Recipe_Modle.BlotNumber.ToString(), data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,BlotNumber：" + data.Addr + " , Write value ："
                                + crafts_Recipe_Modle.BlotNumber.ToString() + " ，Successfully written！", 0, true);
                        }
                    }
                    if (data.ColmnName == "SleeveNo")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, crafts_Recipe_Modle.SleeveNo.ToString(), data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,SleeveNo：" + data.Addr + " , Write value ："
                                + crafts_Recipe_Modle.SleeveNo.ToString() + " ，Successfully written！", 0, true);
                        }
                    }
                    if (data.ColmnName == "ProgramNo")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, crafts_Recipe_Modle.ProgramNo.ToString(), data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,ProgramNo：" + data.Addr + " , Write value ："
                                + crafts_Recipe_Modle.ProgramNo.ToString() + " ，Successfully written！", 0, true);
                        }
                    }
                }
                if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "21", opcObj.AddrType, 0))
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,Send tightening address：" + backAddr + " , Write value ："
                                + " 21，Successfully written！", 0, true);
                }
                else
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,Send tightening address：" + backAddr + " , Write value ："
                                + " 21，Write failure！", 0, true);
                }
            }
            #endregion

            #region 测量
            if (crafts_Recipe_Modle.OperationType == "测量" || crafts_Recipe_Modle.OperationType == "Measuring")
            {
                var opcObj = stationObj.Opcitem.Single(n => n.Name.Contains("测量记录"));
                string backAddr = opcObj.BackAddr;
                var dataitemObj = opcObj.Tag.Single(n => n.Name == "测量下发").Dataitem;
                if (dataitemObj.Count == 0)//无需下发程序号
                {
                    if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "21", opcObj.AddrType, 0))
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 21，Successfully written！", 0, true);
                    }
                    else
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 21，Write failure！", 0, true);
                    }
                }
                else
                {
                    foreach (var data in dataitemObj)
                    {
                        if (data.Name == "ProgramNo")
                        {
                            if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, crafts_Recipe_Modle.ProgramNo.ToString(), data.AddrType,0))
                            {
                                recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + crafts_Recipe_Modle.ProgramNo.ToString() + " ，Successfully written！", 0, true);
                            }
                        }
                    }
                    if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "21", opcObj.AddrType,0))
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 21，Successfully written！", 0, true);
                    }
                    else
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 21，Write failure！", 0, true);
                    }
                }
            }
            #endregion

            #region 结束
            if (crafts_Recipe_Modle.OperationType == "结束" || crafts_Recipe_Modle.OperationType == "End")
            {
                string sn = Recipe_Bll.GetCacheStationInfo(station, "SN");
                var opcObj = stationObj.Opcitem.Single(n => n.Name == "总成绑定");
                PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], opcObj.BackAddr, "0", opcObj.AddrType, 0);

                #region 获取工位结果以及工单号
                int result = 1;
                string workOrder = Crafts_CurPlan_Bll.Select_workOrder_Table();
                #endregion

                #region 数据转移
                Trace_StationStatus_Bll.TraceData_Transfer(station, sn);
                #endregion

                #region 添加工位状态
                trace_StationStatus_Modle.RecordTime = DateTime.Now.ToString();
                trace_StationStatus_Modle.SN = sn;
                trace_StationStatus_Modle.Station = station;
                trace_StationStatus_Modle.StationBeat = PLC_Bll.timeAdd.ToString();
                trace_StationStatus_Modle.StationStatue = result;
                trace_StationStatus_Modle.WorkOrder = workOrder;
                if (XML_Tool.xml.StationConfig.Single(n => n.Name == station).IsEnd == "1" ||
                    XML_Tool.xml.StationConfig.Single(n => n.Name == station).IsOutLine == "1")
                    trace_StationStatus_Bll.Insert_Condition_CurStationInfo_Table(trace_StationStatus_Modle, true);
                else
                    trace_StationStatus_Bll.Insert_Condition_CurStationInfo_Table(trace_StationStatus_Modle, false);
                PLC_Bll.timeAddFlag = false;
                #endregion

                #region 清除数据缓存
                ResetCacheStationInfo(station);
                ResetCacheStationRecipeInfo(station);
                #endregion

                recodeRecipeMessage(lineName + station, "Station：" + station + " , SN ：" + sn + " Go offline！", 0, true);
            }
            #endregion
        }

        /// <summary>
        /// 清空控制字
        /// </summary>
        /// <param name="lineName"></param>
        /// <param name="station"></param>
        /// <param name="step"></param>
        public static void ClearControl(string lineName, string station, int step)
        {
            #region 变量
            Recipe_Bll.WriteCacheStationInfo(station, "Step", step.ToString());
            var lineObj = XML_Tool.xml.LINE.Single(n => n.Name == lineName);
            var stationObj = lineObj.STATION.Single(n => n.Name == station);
            Crafts_Recipe_Modle crafts_Recipe_Modle = GetSingleRecipe(station, step);
            #endregion

            #region 配方为空
            if (crafts_Recipe_Modle == null)
            {
                recodeRecipeMessage(lineName + station, "Station：" + station + " , Step：" + step + " ,Formula not found！", 1, true);
                return;
            }
            #endregion

            #region 拧紧
            if (crafts_Recipe_Modle.OperationType == "拧紧" || crafts_Recipe_Modle.OperationType == "Tighten")
            {
                var opcObj = stationObj.Opcitem.Single(n => n.Name == "拧紧记录");
                string backAddr = opcObj.BackAddr;
                var dataitemObj = opcObj.Tag.Single(n => n.Name == "拧紧下发").Dataitem;
                foreach (var data in dataitemObj)
                {
                    string sn = Recipe_Bll.GetCacheStationInfo(station, "SN");
                    if (data.ColmnName == "SN")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, "", data.AddrType, int.Parse(data.AddrLength)))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                                                    + step + " ,SN：" + data.Addr + " , Write value ：null"
                                                                    + " ，Successfully written！", 0, false);
                        }
                    }
                    if (data.ColmnName == "BlotNumber")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, "0", data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,BlotNumber：" + data.Addr + " , Write value ：0"
                                + " ，Successfully written！", 0, false);
                        }
                    }
                    if (data.ColmnName == "SleeveNo")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, "0", data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,SleeveNo：" + data.Addr + " , Write value ：0"
                                + " ，Successfully written！", 0, false);
                        }
                    }
                    if (data.ColmnName == "ProgramNo")
                    {
                        if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, "0", data.AddrType, 0))
                        {
                            recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,ProgramNo：" + data.Addr + " , Write value ：0"
                                + " ，Successfully written！", 0, false);
                        }
                    }
                }
                if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "0", opcObj.AddrType, 0))
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,Send tightening address：" + backAddr + " , Write value ："
                                + " 0，Successfully written！", 0, false);
                }
                else
                {
                    recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                + step + " ,Send tightening address：" + backAddr + " , Write value ："
                                + " 0，Write failure！", 0, false);
                }
            }
            #endregion

            #region 测量
            if (crafts_Recipe_Modle.OperationType == "测量" || crafts_Recipe_Modle.OperationType == "Measuring")
            {
                var opcObj = stationObj.Opcitem.Single(n => n.Name.Contains("测量记录") && GetTestType(crafts_Recipe_Modle.ComponentName).Contains(n.OperationDesc));
                string backAddr = opcObj.BackAddr;
                var dataitemObj = opcObj.Tag.Single(n => n.Name == "测量下发").Dataitem;
                if (dataitemObj.Count == 0)//无需下发程序号
                {
                    if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "0", opcObj.AddrType, 0))
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 0，Successfully written！", 0, true);
                    }
                    else
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 0，Write failure！", 0, true);
                    }
                }
                else
                {
                    foreach (var data in dataitemObj)
                    {
                        if (data.Name == "ProgramNo")
                        {
                            if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], data.Addr, crafts_Recipe_Modle.ProgramNo.ToString(), data.AddrType, 0))
                            {
                                recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + crafts_Recipe_Modle.ProgramNo.ToString() + " ，Successfully written！", 0, true);
                            }
                        }
                    }
                    if (PLC_Bll.ABWrite(PLC_Bll.abPlc[lineObj.Index], backAddr, "0", opcObj.AddrType, 0))
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 0，Successfully written！", 0, true);
                    }
                    else
                    {
                        recodeRecipeMessage(lineName + station, "Station：" + station + " , Step："
                                    + step + " ,Send measuring address：" + backAddr + " , Write value ："
                                    + " 0，Write failure！", 0, true);
                    }
                }
            }
            #endregion
        }

        /// <summary>
        /// 获取测试类型
        /// </summary>
        /// <param name="componentName"></param>
        /// <returns></returns>
        public static string GetTestType(string componentName)
        {
            string testName = string.Empty;
            if (componentName.Contains("气密性") || componentName.Contains("Air tightness"))
                testName = "气密性";
            if (componentName.Contains("EOL"))
                testName = "EOL";
            if (componentName.Contains("充放电") || componentName.Contains("Discharge"))
                testName = "充放电";
            if (componentName.Contains("BMS刷写") || componentName.Contains("BMS flashing"))
                testName = "BMS刷写";
            if (componentName.Contains("高压绝缘") || componentName.Contains("High voltage insulation"))
                testName = "高压绝缘";
            if (componentName.Contains("OCV"))
                testName = "OCV";
            return testName;
        }
    }
}
