using System.Windows.Forms;

namespace TypingApp
{
    public partial class MainForm : Form
    {
        // インスタンスを固定
        public static TitleControl titleCtr;
        public static TypingControl typingCtr;
        public static RankingControl rankCtr;
        public static ScoreControl scoreCtr;
        public static GameOverControl overCtr;
        public static WaitControl waitCtr;

        public MainForm()
        {
            // インスタンス化
            titleCtr = new TitleControl();
            typingCtr = new TypingControl();
            scoreCtr = new ScoreControl();
            rankCtr = new RankingControl();
            overCtr = new GameOverControl();
            waitCtr = new WaitControl();

            InitializeComponent();

            // リサイズを禁止
            MaximizeBox = false;
            MinimizeBox = false;

            // パネルに追加
            MainPanel.Controls.Add(titleCtr);
            MainPanel.Controls.Add(typingCtr);
            MainPanel.Controls.Add(scoreCtr);
            MainPanel.Controls.Add(rankCtr);
            MainPanel.Controls.Add(overCtr);
            MainPanel.Controls.Add(waitCtr);

            // タイトルのコントロールのみを見えるようにする
            titleCtr.Visible = true;
            typingCtr.Visible = false;
            rankCtr.Visible = false;
            scoreCtr.Visible = false;
            overCtr.Visible = false;
            waitCtr.Visible = false;
        }

    }
}
