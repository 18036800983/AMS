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
    public class LineChart
    {
        public static PlotController CreateController()
        {
            var controller = new PlotController();
            controller.UnbindAll();
            controller.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            return controller;
        }

        public static PlotModel CreateModel()
        {
            var model = new PlotModel
            {
                //Title = "PLC轮询效率",
                LegendPlacement = LegendPlacement.Inside,
                LegendPosition = LegendPosition.TopCenter,
                LegendOrientation = LegendOrientation.Horizontal,
                PlotType = PlotType.XY,
            };
            model.Axes.Add(
                new LinearAxis()
                {
                    //Title = "数量",
                    MajorGridlineStyle = LineStyle.Solid,
                    MinorGridlineStyle = LineStyle.Dash,
                    MinimumMinorStep = 1,
                    MinimumMajorStep = 1,
                    MaximumPadding = 0.3,
                    //MajorStep = 5,
                    //MinorStep = 1,
                    Position = AxisPosition.Left
                });
            model.Axes.Add(
                new LinearAxis()
                {
                    MinimumMinorStep = 1,
                    MinimumMajorStep = 1,
                    //MaximumPadding = 0.3,
                    //MajorStep = 5,
                    //MinorStep = 1,
                    Position = AxisPosition.Bottom
                });

            return model;
        }

        public static PlotModel CreateModel(List<Line_StationAlarm_Model> list, string subtitle, string type, string itemString)
        {
            var group1 = list.OrderBy(n => n.DT).GroupBy(n => n.DT.ToString()).ToList();
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

            var max = DateTimeAxis.ToDouble(DateTime.Now.AddDays(1));
            var min = max - 2;
            var model = new PlotModel
            {
                Title = "Alarm ratio analysis",
                Subtitle = subtitle,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.RightTop
            };
            model.DefaultColors[0] = OxyColor.FromRgb(31, 120, 180);
            model.DefaultColors[3] = OxyColor.FromRgb(51, 160, 44);

            var dateAxes = new DateTimeAxis
            {
                Title = "Time",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dash,
                Position = AxisPosition.Bottom,
                //MinimumPadding = 0.1,
                //MaximumPadding = 0.1,
                //Minimum = min,
                //Maximum = max,
                MinimumMajorStep = 1,
                MinimumMinorStep = 1,
                //MajorStep = 1,
                //MinorStep = 1,
                Angle = -60,
                StringFormat = "yyMMMdd"
            };
            model.Axes.Add(dateAxes);
            model.Axes.Add(
                new LinearAxis
                {
                    Title = "Number",
                    MajorGridlineStyle = LineStyle.Solid,
                    MinorGridlineStyle = LineStyle.Dash,
                    MinimumMinorStep = 1,
                    MinimumMajorStep = 1,
                    //MajorStep = 5,
                    //MinorStep = 1,
                    Position = AxisPosition.Left,
                    PositionTier = 1000
                });
            if (group1.Count <= 1)
            {
                dateAxes.Minimum = min;
                dateAxes.Maximum = max;
            }
            foreach (var item2 in group2)
            {
                var s1 = new LineSeries { Title = item2.Key };
                if (itemString != "全部" && itemString != item2.Key)
                    s1.IsVisible = false;
                foreach (var item1 in group1)
                {
                    //s1.Points.Add(DateTimeAxis.CreateDataPoint(Convert.ToDateTime(item1.Key),
                    //item2.Where(n => n.DT.ToString("yyMMMdd") == item1.Key).Count()));
                    s1.Points.Add(DateTimeAxis.CreateDataPoint(Convert.ToDateTime(item1.Key),
                        item2.Count()));
                }
                s1.InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline;
                s1.MarkerType = MarkerType.Circle;
                s1.TrackerFormatString = "{2:yyMMMdd}: {4:0}";
                //s1.LineLegendPosition = LineLegendPosition.End;
                model.Series.Add(s1);
            }
            return model;
        }
    }
}
