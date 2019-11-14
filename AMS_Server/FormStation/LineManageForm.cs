using DevComponents.DotNetBar;
using Server_Modle.XML;
using Server_Tools;
using Server_Tools.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FormStation
{
    public partial class LineManageForm : Office2007Form
    {
        Xml_InfoConfig xi;//info root
        Xml_InfoConfig_Station xis;//station root
        Xml_InfoConfig_Opcitem xio;//opcitem root
        Xml_InfoConfig_Tags xit;//tag root
        Xml_InfoConfig_Dataitem xid;//dataitem root
        TreeNode treeNode;
        public LineManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LineManageForm_Load(object sender, EventArgs e)
        {
            try
            {               
                PageFrush(null);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("产线管理页面加载异常：" + ex.Message);
            }
        }

        /// <summary>
        /// line save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void line_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LineCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空，请检查！");
                    return;
                }
                if (xi.Name == line_name_textBox.Text)
                {
                    xi.Name = line_name_textBox.Text;
                    xi.Index = int.Parse(line_index_textBox.Text);
                    xi.HeartBeatAddr = line_heartAddress_textBox.Text;
                    xi.IP = line_ip_textBox.Text;
                    xi.PLCSlot = int.Parse(line_plcSolt_textBox.Text);
                    xi.ThreaCount = int.Parse(line_threadCount_textBox.Text);
                    xi.UpdateRate = int.Parse(line_updateRate_textBox.Text);
                    xi.PLCType = line_plcBrand_comboBox.Text;
                    xi.AddrType = line_addressType_label.Text;
                    XML_Tool.Save();
                    MessageBoxEx.Show("line层修改成功！");
                }
                else
                {
                    Xml_InfoConfig xInfo = new Xml_InfoConfig();
                    xInfo.Name = line_name_textBox.Text;
                    xInfo.Index = int.Parse(line_index_textBox.Text);
                    xInfo.HeartBeatAddr = line_heartAddress_textBox.Text;
                    xInfo.IP = line_ip_textBox.Text;
                    xInfo.PLCSlot = int.Parse(line_plcSolt_textBox.Text);
                    xInfo.ThreaCount = int.Parse(line_threadCount_textBox.Text);
                    xInfo.UpdateRate = int.Parse(line_updateRate_textBox.Text);
                    xInfo.PLCType = line_plcBrand_comboBox.Text;
                    xi.AddrType = line_addressType_label.Text;
                    List<Xml_InfoConfig_Station> xisList = new List<Xml_InfoConfig_Station>();
                    Xml_InfoConfig_Station xml_InfoConfig_Station = new Xml_InfoConfig_Station();
                    xml_InfoConfig_Station.Name = "OP00";
                    xisList.Add(xml_InfoConfig_Station);
                    xInfo.STATION = xisList;
                    XML_Tool.xml.LINE.Add(xInfo);
                    XML_Tool.Save();
                    MessageBoxEx.Show("line层添加成功！");
                }
                PageFrush(treeNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("line层添加异常：" + ex.Message);
            }
        }

        /// <summary>
        /// line delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void line_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (LineCheck())
                {
                    var _line = XML_Tool.xml.LINE.Single(n => n.Name == line_name_textBox.Text);
                    XML_Tool.xml.LINE.Remove(_line);
                    XML_Tool.Save();
                    MessageBoxEx.Show("line层删除成功！");
                    PageFrush(treeNode);
                }
                else
                {
                    MessageBoxEx.Show("界面参数不能为空，请检查！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("产线不存在：" + ex.Message);
            }
        }

        /// <summary>
        /// line cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void line_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                line_name_textBox.Text = "";
                line_index_textBox.Text = "";
                line_ip_textBox.Text = "";
                line_heartAddress_textBox.Text = "";
                line_plcBrand_comboBox.Text = "";
                line_plcSolt_textBox.Text = "";
                line_threadCount_textBox.Text = "";
                line_updateRate_textBox.Text = "";
                line_addressType_label.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("line层取消按钮事件异常：" + ex.Message);
            }
        }

        /// <summary>
        /// line check
        /// </summary>
        /// <returns></returns>
        public bool LineCheck()
        {
            if (string.IsNullOrEmpty(line_name_textBox.Text) || string.IsNullOrEmpty(line_ip_textBox.Text)
                || string.IsNullOrEmpty(line_heartAddress_textBox.Text) || string.IsNullOrEmpty(line_plcBrand_comboBox.Text)
                || string.IsNullOrEmpty(line_plcSolt_textBox.Text) || string.IsNullOrEmpty(line_threadCount_textBox.Text)
                || string.IsNullOrEmpty(line_updateRate_textBox.Text) || string.IsNullOrEmpty(line_index_textBox.Text)
                || string.IsNullOrEmpty(line_addressType_label.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// station save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StationCheck())
                {
                    MessageBoxEx.Show("工位名称不能为空！");
                    return;
                }
                if (xis.Name == station_name_textBox.Text)
                {
                    xis.Name = station_name_textBox.Text;
                    xis.Desc = station_desc_textBox.Text;
                    xis.PlanTime = station_planTime_textBox.Text;
                    xis.AlarmAddr = station_alarmAddress_textBox.Text;
                    xis.AddrType = station_addressType_textBox.Text;
                    XML_Tool.Save();
                    MessageBoxEx.Show("station层修改成功！");
                }
                else
                {
                    Xml_InfoConfig_Station xml_InfoConfig_Station = new Xml_InfoConfig_Station
                    {
                        Name = station_name_textBox.Text,
                        Desc = station_desc_textBox.Text,
                        PlanTime = station_planTime_textBox.Text,
                        AlarmAddr = station_alarmAddress_textBox.Text,
                        AddrType = station_addressType_textBox.Text
                    };
                    Xml_InfoConfig_Opcitem xml_InfoConfig_Opcitem = new Xml_InfoConfig_Opcitem();
                    xml_InfoConfig_Opcitem.Name = "条码验证";
                    xml_InfoConfig_Station.Opcitem.Add(xml_InfoConfig_Opcitem);
                    xi.STATION.Add(xml_InfoConfig_Station);
                    XML_Tool.Save();
                    MessageBox.Show("station层保存成功！");
                    PageFrush(treeNode);
                }              
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("station层保存按钮事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// station delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StationCheck())
                {
                    MessageBoxEx.Show("工位名称不能为空！");
                    return;
                }
                if (xis.Name == station_name_textBox.Text)
                {
                    xi.STATION.Remove(xis);
                    XML_Tool.Save();
                    MessageBox.Show("station层删除成功！");
                    PageFrush(treeNode);
                }
                else
                {
                    MessageBoxEx.Show("不存在该工位！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("station层删除出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// station cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                station_name_textBox.Text = "";
                station_desc_textBox.Text = "";
                station_planTime_textBox.Text = "";
                station_alarmAddress_textBox.Text = "";
                station_addressType_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("station层取消异常：" + ex.Message);
            }
        }

        /// <summary>
        /// station check
        /// </summary>
        /// <returns></returns>
        public bool StationCheck()
        {
            if (string.IsNullOrEmpty(station_name_textBox.Text) || string.IsNullOrEmpty(station_desc_textBox.Text) 
                || string.IsNullOrEmpty(station_planTime_textBox.Text) || string.IsNullOrEmpty(station_alarmAddress_textBox.Text)
                || string.IsNullOrEmpty(station_addressType_textBox.Text))
                return false;
            else
                return true;
        }

        /// <summary>
        /// opcitem save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcitem_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OpcitemCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xio.Name == opcitem_name_textBox.Text)
                {
                    xio.Name = opcitem_name_textBox.Text;
                    xio.Addr = opcitem_address_textBox.Text;
                    xio.BackAddr = opcitem_backAddress_textBox.Text;
                    xio.AddrType = opcitem_addressType_textBox.Text;
                    xio.OperationDesc = opcitem_operationDesc_textBox.Text;
                    if (xio.Tag.Count == 0)
                    {
                        Xml_InfoConfig_Tags xml_InfoConfig_Tags = new Xml_InfoConfig_Tags();
                        xml_InfoConfig_Tags.Name = "条码数据";
                        xio.Tag.Add(xml_InfoConfig_Tags);
                    }
                    XML_Tool.Save();
                    MessageBoxEx.Show("opcitem层修改成功！");
                }
                else
                {
                    Xml_InfoConfig_Opcitem xml_InfoConfig_Opcitem = new Xml_InfoConfig_Opcitem();
                    xml_InfoConfig_Opcitem.Name = opcitem_name_textBox.Text;
                    xml_InfoConfig_Opcitem.Addr = opcitem_address_textBox.Text;
                    xml_InfoConfig_Opcitem.BackAddr = opcitem_backAddress_textBox.Text;
                    xml_InfoConfig_Opcitem.AddrType = opcitem_addressType_textBox.Text;
                    xml_InfoConfig_Opcitem.OperationDesc = opcitem_operationDesc_textBox.Text;
                    Xml_InfoConfig_Tags xml_InfoConfig_Tags = new Xml_InfoConfig_Tags();
                    xml_InfoConfig_Tags.Name = "条码数据";
                    xml_InfoConfig_Opcitem.Tag.Add(xml_InfoConfig_Tags);
                    xis.Opcitem.Add(xml_InfoConfig_Opcitem);
                    XML_Tool.Save();
                    MessageBoxEx.Show("opcitem层添加成功！");
                }
                PageFrush(treeNode);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("opcitem保存异常：" + ex.Message);
            }
        }

        /// <summary>
        /// opcitem delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcitem_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OpcitemCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xio.Name == opcitem_name_textBox.Text)
                {
                    xis.Opcitem.Remove(xio);
                    XML_Tool.Save();
                    MessageBoxEx.Show("opcitem层删除成功！");
                    PageFrush(treeNode);
                }
                else
                {
                    MessageBoxEx.Show("不存在该opcitem！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("opcitem删除异常：" + ex.Message);
            }
        }

        /// <summary>
        /// opcitem cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcitem_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                opcitem_name_textBox.Text = "";
                opcitem_address_textBox.Text = "";
                opcitem_backAddress_textBox.Text = "";
                opcitem_operationDesc_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("opcitem取消异常：" + ex.Message);
            }
        }

        /// <summary>
        /// opcitem check
        /// </summary>
        /// <returns></returns>
        public bool OpcitemCheck()
        {
            if (string.IsNullOrEmpty(opcitem_name_textBox.Text) || string.IsNullOrEmpty(opcitem_address_textBox.Text)
                || string.IsNullOrEmpty(opcitem_backAddress_textBox.Text))
                return false;
            else
                return true;
        }

        /// <summary>
        /// tag save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tag_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TagCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xit.Name == tag_name_textBox.Text)
                {
                    xit.Name = tag_name_textBox.Text;
                    xit.Tag = int.Parse(tag_tag_textBox.Text);
                    xit.TableName = tag_tableName_textBox.Text;
                    if (xit.Dataitem.Count == 0)
                    {
                        Xml_InfoConfig_Dataitem xml_InfoConfig_Dataitem = new Xml_InfoConfig_Dataitem();
                        xml_InfoConfig_Dataitem.Name = "总成条码";
                        xit.Dataitem.Add(xml_InfoConfig_Dataitem);
                    }
                    XML_Tool.Save();
                    MessageBoxEx.Show("tag层修改成功！");
                }
                else
                {
                    Xml_InfoConfig_Tags xml_InfoConfig_Tags = new Xml_InfoConfig_Tags();
                    xml_InfoConfig_Tags.Name = tag_name_textBox.Text;
                    xml_InfoConfig_Tags.Tag = int.Parse(tag_tag_textBox.Text);
                    xml_InfoConfig_Tags.TableName = tag_tableName_textBox.Text;
                    Xml_InfoConfig_Dataitem xml_InfoConfig_Dataitem = new Xml_InfoConfig_Dataitem();
                    xml_InfoConfig_Dataitem.Name = "总成条码";
                    xml_InfoConfig_Tags.Dataitem.Add(xml_InfoConfig_Dataitem);
                    xio.Tag.Add(xml_InfoConfig_Tags);
                    XML_Tool.Save();
                    MessageBoxEx.Show("tag层添加成功！");
                }
                PageFrush(treeNode);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("tag层保存异常：" + ex.Message);
            }
        }

        /// <summary>
        /// tag delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tag_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TagCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xit.Name == tag_name_textBox.Text)
                {
                    xio.Tag.Remove(xit);
                    XML_Tool.Save();
                    MessageBox.Show("tag层删除成功！");
                    PageFrush(treeNode);
                }
                else
                {
                    MessageBoxEx.Show("不存在该Tag！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("tag层删除异常：" + ex.Message);
            }
        }

        /// <summary>
        /// tag cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tag_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                tag_name_textBox.Text = "";
                tag_tag_textBox.Text = "";
                tag_tableName_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("tag层取消异常：" + ex.Message);
            }
        }

        /// <summary>
        /// tag check
        /// </summary>
        /// <returns></returns>
        public bool TagCheck()
        {
            if (string.IsNullOrEmpty(tag_name_textBox.Text) || string.IsNullOrEmpty(tag_tag_textBox.Text)
                || string.IsNullOrEmpty(tag_tableName_textBox.Text))
                return false;
            else
                return true;
        }

        /// <summary>
        /// dataitem save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataitem_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataitemCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xid.Name == dataitem_name_textBox.Text)
                {
                    xid.Name = dataitem_name_textBox.Text;
                    xid.Addr = dataitem_address_textBox.Text;
                    xid.ColmnName = dataitem_columnName_textBox.Text;
                    xid.AddrType = dataitem_addressType_textBox.Text;
                    xid.AddrLength = dataitem_addressLength_textBox.Text;
                    XML_Tool.Save();
                    MessageBoxEx.Show("Dataitem层修改成功！");
                }
                else
                {
                    Xml_InfoConfig_Dataitem xml_InfoConfig_Dataitem = new Xml_InfoConfig_Dataitem();
                    xml_InfoConfig_Dataitem.Name = dataitem_name_textBox.Text;
                    xml_InfoConfig_Dataitem.Addr = dataitem_address_textBox.Text;
                    xml_InfoConfig_Dataitem.ColmnName = dataitem_columnName_textBox.Text;
                    xml_InfoConfig_Dataitem.AddrType = dataitem_addressType_textBox.Text;
                    xml_InfoConfig_Dataitem.AddrLength = dataitem_addressLength_textBox.Text;
                    xit.Dataitem.Add(xml_InfoConfig_Dataitem);
                    XML_Tool.Save();
                    MessageBoxEx.Show("Dataitem层添加成功！");
                }
                PageFrush(treeNode);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("dataitem层保存按钮事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// dataitem delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataitem_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataitemCheck())
                {
                    MessageBoxEx.Show("界面参数不能为空！");
                    return;
                }
                if (xid.Name == dataitem_name_textBox.Text)
                {
                    xit.Dataitem.Remove(xid);
                    XML_Tool.Save();
                    MessageBoxEx.Show("Dataitem层删除成功！");
                    PageFrush(treeNode);
                }
                else
                {
                    MessageBoxEx.Show("不存在该Dataitem！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("dataitem层删除按钮事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// dataitem cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataitem_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataitem_name_textBox.Text = "";
                dataitem_address_textBox.Text = "";
                dataitem_columnName_textBox.Text = "";
                dataitem_addressType_textBox.Text = "";
                dataitem_addressLength_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("dataitem层取消按钮事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// dataitem check
        /// </summary>
        /// <returns></returns>
        public bool DataitemCheck()
        {
            if (string.IsNullOrEmpty(dataitem_name_textBox.Text) || string.IsNullOrEmpty(dataitem_address_textBox.Text)
                || string.IsNullOrEmpty(dataitem_columnName_textBox.Text))
                return false;
            else
                return true;
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush(TreeNode node)
        {
            plcAddress_tree_advTree.Nodes.Clear();
            foreach (var line in XML_Tool.xml.LINE)
            {
                var node1 = plcAddress_tree_advTree.Nodes.Add(line.Name);
                foreach (var st in line.STATION)
                {
                    var node2 = node1.Nodes.Add(st.Name);
                    foreach (var opc in st.Opcitem)
                    {
                        var node3 = node2.Nodes.Add(opc.Name);
                        foreach (var tag in opc.Tag)
                        {
                            var node4 = node3.Nodes.Add(tag.Name);
                            foreach (var data in tag.Dataitem)
                            {
                                node4.Nodes.Add(data.Name);
                            }
                        }
                    }
                }
            }
            if (node == null)
            {
                plcAddress_tree_advTree.SelectedNode = plcAddress_tree_advTree.Nodes[0];
            }
            else
            {
                node.ExpandAll();
            }
        }

        /// <summary>
        /// tree select event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void plcAddress_tree_advTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Level == 0)
                {
                    ShowPanel(0);
                    var line = XML_Tool.xml.LINE.Single(n => n.Name == e.Node.Text);
                    xi = line;
                    line_name_textBox.Text = xi.Name;
                    line_index_textBox.Text = xi.Index.ToString();
                    line_heartAddress_textBox.Text = xi.HeartBeatAddr;
                    line_ip_textBox.Text = xi.IP;
                    line_plcSolt_textBox.Text = xi.PLCSlot.ToString();
                    line_threadCount_textBox.Text = xi.ThreaCount.ToString();
                    line_updateRate_textBox.Text = xi.UpdateRate.ToString();
                    line_plcBrand_comboBox.Text = xi.PLCType;
                    line_addressType_textBox.Text = xi.AddrType;
                    treeNode = plcAddress_tree_advTree.Nodes[e.Node.Index];
                }
                else if (e.Node.Level == 1)
                {
                    ShowPanel(1);
                    var line = XML_Tool.xml.LINE.Single(n => n.Name == e.Node.Parent.Text);
                    xi = line;
                    var station = line.STATION.Single(n => n.Name == e.Node.Text);
                    xis = station;
                    station_name_textBox.Text = station.Name;
                    station_desc_textBox.Text = station.Desc;
                    station_planTime_textBox.Text = station.PlanTime;
                    station_alarmAddress_textBox.Text = station.AlarmAddr;
                    station_addressType_textBox.Text = station.AddrType;
                    treeNode = plcAddress_tree_advTree.Nodes[e.Node.Parent.Index];
                }
                else if (e.Node.Level == 2)
                {
                    ShowPanel(2);
                    var station = XML_Tool.xml.LINE.Single(n => n.Name == e.Node.Parent.Parent.Text).STATION.
                        Single(n => n.Name == e.Node.Parent.Text);
                    xis = station;
                    var opc = station.Opcitem.Single(n => n.Name == e.Node.Text);
                    xio = opc;
                    opcitem_name_textBox.Text = opc.Name;
                    opcitem_address_textBox.Text = opc.Addr;
                    opcitem_backAddress_textBox.Text = opc.BackAddr;
                    opcitem_addressType_textBox.Text = opc.AddrType;
                    opcitem_operationDesc_textBox.Text = opc.OperationDesc;
                    treeNode = plcAddress_tree_advTree.Nodes[e.Node.Parent.Parent.Index];
                }
                else if (e.Node.Level == 3)
                {
                    ShowPanel(3);
                    var opc = XML_Tool.xml.LINE.Single(n => n.Name == e.Node.Parent.Parent.Parent.Text).STATION.
                        Single(n => n.Name == e.Node.Parent.Parent.Text).Opcitem.
                        Single(n => n.Name == e.Node.Parent.Text);
                    xio = opc;
                    var tag = opc.Tag.Single(n => n.Name == e.Node.Text);
                    xit = tag;
                    tag_name_textBox.Text = xit.Name;
                    tag_tag_textBox.Text = xit.Tag.ToString();
                    tag_tableName_textBox.Text = xit.TableName;
                    treeNode = plcAddress_tree_advTree.Nodes[e.Node.Parent.Parent.Parent.Index];
                }
                else if (e.Node.Level == 4)
                {
                    ShowPanel(4);
                    var tag = XML_Tool.xml.LINE.Single(n => n.Name == e.Node.Parent.Parent.Parent.Parent.Text).
                        STATION.Single(n => n.Name == e.Node.Parent.Parent.Parent.Text).Opcitem.
                        Single(n => n.Name == e.Node.Parent.Parent.Text).Tag.Single(n => n.Name == e.Node.Parent.Text);
                    xit = tag;
                    var dataitem = tag.Dataitem.Single(n => n.Name == e.Node.Text);
                    xid = dataitem;
                    dataitem_name_textBox.Text = xid.Name;
                    dataitem_address_textBox.Text = xid.Addr;
                    dataitem_columnName_textBox.Text = xid.ColmnName;
                    dataitem_addressType_textBox.Text = xid.AddrType;
                    dataitem_addressLength_textBox.Text = xid.AddrLength;
                    treeNode = plcAddress_tree_advTree.Nodes[e.Node.Parent.Parent.Parent.Parent.Index];
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("树点击事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// panel show
        /// </summary>
        /// <param name="level"></param>
        public void ShowPanel(int level)
        {
            switch (level)
            {
                case 0:
                    line_panel.Visible = true;
                    station_panel.Visible = false;
                    opcitem_panel.Visible = false;
                    tag_panel.Visible = false;
                    dataitem_panel.Visible = false;
                    break;
                case 1:
                    line_panel.Visible = true;
                    station_panel.Visible = true;
                    opcitem_panel.Visible = false;
                    tag_panel.Visible = false;
                    dataitem_panel.Visible = false;
                    break;
                case 2:
                    line_panel.Visible = true;
                    station_panel.Visible = true;
                    opcitem_panel.Visible = true;
                    tag_panel.Visible = false;
                    dataitem_panel.Visible = false;
                    break;
                case 3:
                    line_panel.Visible = true;
                    station_panel.Visible = true;
                    opcitem_panel.Visible = true;
                    tag_panel.Visible = true;
                    dataitem_panel.Visible = false;
                    break;
                case 4:
                    line_panel.Visible = true;
                    station_panel.Visible = true;
                    opcitem_panel.Visible = true;
                    tag_panel.Visible = true;
                    dataitem_panel.Visible = true;
                    break;
                default:
                    line_panel.Visible = true;
                    station_panel.Visible = false;
                    opcitem_panel.Visible = false;
                    tag_panel.Visible = false;
                    dataitem_panel.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.LogManagerForm_Top_title;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.LogManagerForm_Top_title;
                #endregion
            }
        }
    }
}
