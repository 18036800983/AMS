using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Server_Modle.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools.Chart
{
    public class ColumnChart
    {
        public static PlotController CreateController()
        {
            var controller = new PlotController();
            controller.UnbindAll();
            controller.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            return controller;
        }

        public static PlotModel CreateModel(List<Line_StationAlarm_Model> list, string subtitle, string type, string itemString)
        {
            var group1 = list.OrderBy(n => n.DT).GroupBy(n => n.DT.ToString("MM/dd")).ToList();
            List<IGrouping<string, Line_StationAlarm_Model>> group2;
            switch (type)
            {
                case "Type":
                    group2 = list.GroupBy(n => n.Type.Trim()).ToList();
                    break;
                case "Station":
                    group2 = list.GroupBy(n => n.Station.Trim()).ToList();
                    break;
                case "Describtion":
                    group2 = list.GroupBy(n => n.Describtion.Trim()).ToList();
                    break;
                default:
                    group2 = null;
                    break;
            }
            var model = new PlotModel
            {
                LegendPlacement = LegendPlacement.Outside,
                Title = "Alarm ratio analysis",
                TitleFont = "微软雅黑",
                Subtitle = subtitle
            };

            model.DefaultColors[0] = OxyColor.FromRgb(31, 120, 180);
            model.DefaultColors[3] = OxyColor.FromRgb(51, 160, 44);
            //{
            //    OxyColor.FromRgb(31, 120, 180),
            //    OxyColor.FromRgb(227, 26, 28),
            //    OxyColor.FromRgb(127, 201, 127),
            //    OxyColor.FromRgb(190, 174, 212),
            //    OxyColor.FromRgb(253, 192, 134),
            //    OxyColor.FromRgb(166, 206, 227),
            //    OxyColor.FromRgb(178, 223, 138),
            //    OxyColor.FromRgb(51, 160, 44),
            //    OxyColor.FromRgb(251, 154, 153),
            //    OxyColor.FromRgb(255, 255, 153)
            //};

            bool flag = group1.Count > 7;
            var categoryAxis1 = new CategoryAxis
            {
                Title = "Time",
                Position = AxisPosition.Bottom,
                Angle = flag ? -60 : 0,
                LabelField = "Key",
                ItemsSource = group1,
                MajorStep = 1,
                MinorStep = 1
            };
            model.Axes.Add(categoryAxis1);
            var linearAxis1 = new LinearAxis
            {
                Title = "Number",
                Position = AxisPosition.Left,
                AbsoluteMinimum = 0,
                MinimumPadding = 0,
                MinimumMinorStep = 1,
                MinimumMajorStep = 1,
                //MajorStep = 5,
                //MinorStep = 1
            };
            model.Axes.Add(linearAxis1);

            foreach (var item2 in group2)
            {
                if (itemString != "全部" && itemString != item2.Key)
                    continue;
                var s1 = new ColumnSeries { Title = item2.Key, IsStacked = flag ? true : false, StrokeColor = OxyColors.Black, StrokeThickness = 1 };
                s1.LabelFormatString = "{0}";
                s1.LabelPlacement = flag ? LabelPlacement.Middle : LabelPlacement.Inside;
                foreach (var item1 in group1)
                {
                    s1.Items.Add(new ColumnItem() { Value = item2.Where(n => n.DT.ToString("MM/dd") == item1.Key).Count() });
                }
                model.Series.Add(s1);
            }
            return model;
        }
    }
}
