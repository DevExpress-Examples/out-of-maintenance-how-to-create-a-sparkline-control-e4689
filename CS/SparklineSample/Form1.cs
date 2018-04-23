#region #usings
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Sparkline;
using DevExpress.XtraEditors;
#endregion #usings

namespace SparklineSample {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Controls.Add(CreateSparkline());
        }

        #region #Sparkline
        private SparklineEdit CreateSparkline() {
            // Create a Sparkline editor and set its dock style.
            SparklineEdit sparkline = new SparklineEdit();
            sparkline.Dock = DockStyle.Fill;

            sparkline.EditValue = CreateData();

            // Create an Area view and assign it to the sparkline.
            AreaSparklineView view = new AreaSparklineView();
            sparkline.Properties.View = view;

            // Customize area appearance.
            view.Color = Color.Aqua;
            view.AreaOpacity = 50;

            // Show markerks.
            view.HighlightStartPoint = true;
            view.HighlightEndPoint = true;
            view.HighlightMaxPoint = true;
            view.HighlightMinPoint = true;
            view.HighlightNegativePoints = true;
            view.SetSizeForAllMarkers(10);

            return sparkline;
        }

        private double[] CreateData() {
            return new double[] { 2, 4, 5, 1, -1, -2, -1, 2, 4, 5, 6, 3, 5, 4, 8, -1, 6 };
        }
        #endregion #Sparkline
    }

}
