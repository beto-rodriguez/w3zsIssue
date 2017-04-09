using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Geared;
using LiveCharts.Geared.Geometries;
using LiveCharts.Wpf;

namespace Testing.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        public GearedValues<ObservablePoint> dopplerPt { get; set; }
        public GearedValues<ObservablePoint> headingPt { get; set; }
        public GearedValues<ObservablePoint> speedPt { get; set; }
        public SeriesCollection dopplerPlots { get; set; }

        public void Init()
        {
            GearedValues<ObservablePoint> dopplerPt = new GearedValues<ObservablePoint>();
            GearedValues<ObservablePoint> headingPt = new GearedValues<ObservablePoint>();
            GearedValues<ObservablePoint> speedPt = new GearedValues<ObservablePoint>();

            System.Windows.Media.BrushConverter converter = new System.Windows.Media.BrushConverter();
            var brush = (System.Windows.Media.Brush)converter.ConvertFromString("#000000");
            if (brush.CanFreeze)
            {
                brush.Freeze();
            }
            Separator separator = new Separator();

            dopplerPlots = new SeriesCollection
            {
                new GScatterSeries
                {
                    Title = "Doppler Shift",
                    Values = dopplerPt,
                    GearedPointGeometry = GearedGeometries.Diamond,
                    MaxPointShapeDiameter =10,
                    FontSize = 8,
                    ScalesYAt = 0,
                    Fill = brush
                },
                new GScatterSeries
                {
                    Title = "Heading",
                    Values = headingPt,
                    GearedPointGeometry = GearedGeometries.Diamond,
                    MaxPointShapeDiameter = 8,
                    FontSize = 8,
                    ScalesYAt = 1
                },
                new GScatterSeries
                {
                    Title = "Speed",
                    Values = speedPt,
                    GearedPointGeometry = GearedGeometries.Diamond,
                    MaxPointShapeDiameter = 8,
                    FontSize = 8,
                    ScalesYAt =2
                }
            };

            dopGraph.AxisY.Add(new Axis
            {
                Position = AxisPosition.LeftBottom,
                Title = "Hz",
                Foreground = brush,
                FontWeight = System.Windows.FontWeights.Bold,
                FontSize = 15,
                //LabelFormatter = value => ((Math.Abs(rateDopChange) <= 0.01) && (dopplerDataList.Count < 100)) ? value.ToString("F2") :
                //    ((Math.Abs(rateDopChange) > 0.01) && (Math.Abs(rateDopChange) <= 0.02) && (dopplerDataList.Count < 50)) ? value.ToString("F2") :
                //        ((Math.Abs(rateDopChange) > 0.02) && (Math.Abs(rateDopChange) <= 0.03) && (dopplerDataList.Count < 42)) ? value.ToString("F2") :
                //            ((Math.Abs(rateDopChange) > 0.03) && (Math.Abs(rateDopChange) <= 0.04) && (dopplerDataList.Count < 34)) ? value.ToString("F2") :
                //                ((Math.Abs(rateDopChange) > 0.04) && (Math.Abs(rateDopChange) <= 0.05) && (dopplerDataList.Count < 25)) ? value.ToString("F2") :
                //                    ((Math.Abs(rateDopChange) > 0.05) && (Math.Abs(rateDopChange) <= 0.1) && (dopplerDataList.Count < 20)) ? value.ToString("F2") :
                //                        ((Math.Abs(rateDopChange) > 0.1) && (Math.Abs(rateDopChange) <= 0.5) && (dopplerDataList.Count < 20)) ? value.ToString("F2") :
                //                            ((Math.Abs(rateDopChange) > 0.5) && (Math.Abs(rateDopChange) <= 1.0) && (dopplerDataList.Count < 10)) ? value.ToString("F2") :
                //                                Math.Round(value).ToString(),
                Separator = new Separator
                {
                    Stroke = brush
                },
            });

            dopGraph.AxisY.Add(new Axis
            {
                Position = AxisPosition.RightTop,
                Title = "Degrees  (0 - 360)",
                ShowLabels = false,
                MaxValue = 370,
                MinValue = 0,
                Foreground = brush,
                FontWeight = System.Windows.FontWeights.Bold,
                FontSize = 15,
                Separator = new Separator
                {
                    IsEnabled = false
                },
            });
            dopGraph.AxisY.Add(new Axis
            {
                Position = AxisPosition.RightTop,
                Title = "km/h",
                MaxValue = 1300,
                MinValue = 0,
                Foreground = brush,
                FontWeight = System.Windows.FontWeights.Bold,
                FontSize = 15,
                Separator = new Separator
                {
                    IsEnabled = false
                }
            });
            dopGraph.AxisX.Add(new Axis
            {
                Position = AxisPosition.LeftBottom,
                Title = "Seconds",
                MinValue = 0,
                MinRange = 10,
                Foreground = brush,
                FontWeight = System.Windows.FontWeights.Bold,
                FontSize = 15,
                Separator = new Separator
                {
                    Stroke = brush
                }
            });

            dopGraph.Hoverable = false;
            dopGraph.DataTooltip = null;
            dopGraph.DisableAnimations = false;
            dopGraph.Series = dopplerPlots;
            dopGraph.LegendLocation = LegendLocation.Top;
            //not necessary
            //dopGraph.ForeColor = Colors.Black;

            foreach (var series in dopplerPlots)
            {
                if (series.Title == "Doppler Shift")
                {
                    series.Values.Add(new ObservablePoint(9, 9));
                }
                else if (series.Title == "Heading")
                {
                    series.Values.Add(new ObservablePoint(8, 8));
                }
                else if (series.Title == "Speed")
                {
                    series.Values.Add(new ObservablePoint(7, 7));
                }
            }
        }
    }
}
