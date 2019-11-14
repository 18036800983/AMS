using OxyPlot;
using OxyPlot.Series;
using Server_Modle.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools.Chart
{
    public class PieChart
    {
        public static PlotController CreateController()
        {
            var controller = new PlotController();
            controller.UnbindAll();
            controller.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            return controller;
        }

        public static PlotModel CreateModel(string name)
        {
            var model = new PlotModel
            {
                Title = name,
                TitleFont = "微软雅黑",
                TitlePadding = 30,
                Padding = new OxyThickness(10, 10, 10, 10)
            };
            model.DefaultColors[0] = OxyColor.FromRgb(31, 120, 180);
            model.DefaultColors[3] = OxyColor.FromRgb(51, 160, 44);
            var ps = new PieSeries
            {
                AreInsideLabelsAngled = false,
                TickLabelDistance = 10,
                InnerDiameter = 0.4,
                StrokeThickness = 0.1,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0,
            };
            //var ps1 = new PieSeries
            //{
            //    AreInsideLabelsAngled = false,
            //    TickLabelDistance = 10,
            //    Diameter = 0.4,
            //    StrokeThickness = 0.1,
            //    InsideLabelPosition = 0.5,
            //    AngleSpan = 360,
            //    StartAngle = 0,
            //};
            model.Series.Add(ps);
            //model.Series.Add(ps1);
            return model;
        }

        public static PlotModel CreateModel(List<Line_StationAlarm_Model> list, string subtitle, string type)
        {
            List<IGrouping<string, Line_StationAlarm_Model>> group1;
            switch (type)
            {
                case "Type":
                    group1 = list.GroupBy(n => n.Type.Trim()).ToList();
                    break;
                case "Station":
                    group1 = list.GroupBy(n => n.Station.Trim()).ToList();
                    break;
                case "Describtion":
                    group1 = list.GroupBy(n => n.Describtion.Trim()).ToList();
                    break;
                default:
                    group1 = null;
                    break;
            }
            var model = new PlotModel
            {
                Title = "Alarm ratio analysis",
                TitleFont = "微软雅黑",
                Subtitle = subtitle,
                TitlePadding = 30,
                Padding = new OxyThickness(0, 0, 0, 10)
            };
            model.DefaultColors[0] = OxyColor.FromRgb(31, 120, 180);
            model.DefaultColors[3] = OxyColor.FromRgb(51, 160, 44);
            var ps = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0

            };
            foreach (var item in group1)
            {
                ps.Slices.Add(new PieSlice(item.Key, item.Count()) { IsExploded = true });
            }
            model.Series.Add(ps);
            return model;
        }
    }
}
