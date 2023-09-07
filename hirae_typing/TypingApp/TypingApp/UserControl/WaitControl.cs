using System;
using System.Drawing;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class WaitControl : UserControl
    {
        // タイマーを作成
        private Timer timer1 = new Timer();
        private double opacity = 1.0;
        private double opacityChange = -0.05; // 透明度の変化量

        public WaitControl()
        {
            InitializeComponent();

            // タイマーの設定
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(AnimateFade);

            KeyDown += WaitControl_KeyDown;
        }

        private void WaitControl_Load(object sender, EventArgs e)
        {
            EnterLabel.ForeColor = Color.Transparent;
            EnterLabel.Parent = this;
            timer1.Start();
        }

        private void AnimateFade(object sender, EventArgs e)
        {
            // 透明度を変更
            opacity += opacityChange;

            // 透明度が範囲外にならないように制限
            opacity = Math.Max(0.0, Math.Min(1.0, opacity));

            // Labelの透明度を設定
            EnterLabel.BackColor = Color.FromArgb((int)(opacity * 255), EnterLabel.BackColor);
            EnterLabel.ForeColor = Color.FromArgb((int)(opacity * 255), EnterLabel.ForeColor);

            // 透明度が完全に0または1に達したら逆方向に変更
            if (opacity <= 0.0 || opacity >= 1.0)
            {
                opacityChange = -opacityChange;
            }
        }

        private void WaitControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainForm.typingCtr.Visible = true;
                Visible = false;
            }
        }
    }
}
