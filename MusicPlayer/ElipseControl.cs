using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElipseToolDemo
{
    class ElipseControl : Component
    {
        private Control _cntrl;
        private int _CornerRadius = 30;

        public Control TargetControl
        {
            get { return _cntrl; }
            set
            {
                _cntrl = value;
                _cntrl.SizeChanged += UpdateRegion;
                UpdateRegion(_cntrl, null);
            }
        }

        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                if (_cntrl != null)
                    UpdateRegion(_cntrl, null);
            }
        }

        private void UpdateRegion(object sender, EventArgs e)
        {
            if (_cntrl != null)
            {
                // Tạo GraphicsPath với đường viền bo tròn
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, _CornerRadius, _CornerRadius, 180, 90);
                path.AddArc(_cntrl.Width - _CornerRadius, 0, _CornerRadius, _CornerRadius, 270, 90);
                path.AddArc(_cntrl.Width - _CornerRadius, _cntrl.Height - _CornerRadius, _CornerRadius, _CornerRadius, 0, 90);
                path.AddArc(0, _cntrl.Height - _CornerRadius, _CornerRadius, _CornerRadius, 90, 90);
                path.CloseFigure();

                // Tạo Region từ GraphicsPath
                Region region = new Region(path);

                // Áp dụng Region cho Control
                _cntrl.Region = region;

                using (Graphics g = _cntrl.CreateGraphics())
                {
                    // Bật anti-aliasing
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                }
            }
        }
    }
}
