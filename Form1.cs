using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace OSKBurmese
{
	public partial class Form1 : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams param = base.CreateParams;
				param.ExStyle |= 0x08000000;
				return param;
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void CleanOutput(string BtnText)
		{
			BtnText = BtnText.Replace("◌","");
			BtnText = BtnText.Replace("(", "{(}");
			BtnText = BtnText.Replace(")", "{)}");
			BtnText = BtnText.Replace("+", "{+}");
			SendKeys.Send(BtnText);
			chkBoxShift.Checked = false;
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxShift.Checked && chkBoxLock.Checked)
				chkBoxShift.Checked = false;
			if (chkBoxLayout.Checked)
				chkBoxLayout.BackColor = System.Drawing.ColorTranslator.FromHtml("#0076D7");
			else
				chkBoxLayout.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
			if (chkBoxLock.Checked)
				chkBoxLock.BackColor = System.Drawing.ColorTranslator.FromHtml("#0076D7");
			else
				chkBoxLock.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
			if (chkBoxShift.Checked)
				chkBoxShift.BackColor = System.Drawing.ColorTranslator.FromHtml("#0076D7");
			else
				chkBoxShift.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
			if (chkBoxLayout.Checked == true)
			{
				if (chkBoxShift.Checked || chkBoxLock.Checked == true)
				{
					btnA01.Text = "ဎ";
					btnB01.Text = "ဈ";
					btnC01.Text = ""; // blank
					btnD01.Text = ""; // blank
					btnA02.Text = "ဍ";
					btnB02.Text = "ဝ";
					btnC02.Text = "ဗ";
					btnD02.Text = "ဇ";
					btnA03.Text = "ၒ";
					btnB03.Text = "ဣ";
					btnC03.Text = "ှ"; // Asp
					btnD03.Text = "ဌ";
					btnA04.Text = "ဋ";
					btnB04.Text = "၎";
					btnC04.Text = "ီ"; // i low
					btnD04.Text = "ဃ";
					btnA05.Text = "ၓ";
					btnB05.Text = "ဤ";
					btnC05.Text = "္"; // Stacker
					btnD05.Text = "ဠ";
					btnA06.Text = "ၔ";
					btnB06.Text = "၌";
					btnC06.Text = "ွ"; // medial w
					btnD06.Text = "ယ";
					btnA07.Text = "ၕ";
					btnB07.Text = "ဥ";
					btnC07.Text = "ံ"; // nasal dot
					btnD07.Text = "ဉ";
					btnA08.Text = "ရ";
					btnB08.Text = "၍";
					btnC08.Text = "ဲ"; // e
					btnD08.Text = "ဦ";
					btnA09.Text = "*";
					btnB09.Text = "ဿ"; // 
					btnC09.Text = "ဒ";
					btnD09.Text = "၊";
					btnA10.Text = "(";
					btnB10.Text = "ဏ";
					btnC10.Text = "ဓ";
					btnD10.Text = "။";
					btnA11.Text = ")";
					btnB11.Text = "ဧ";
					btnC11.Text = "ဂ";
					btnD11.Text = "?";
					btnA12.Text = "_";
					btnB12.Text = "ဪ";
					btnC12.Text = "\"";
					btnD12.Text = "";
					btnA13.Text = "+";
					btnB13.Text = "ၑ";
					btnC13.Text = "";
					btnD13.Text = "";
					btnA14.Text = "့";
					btnB14.Text = "း";
					btnC14.Text = "်";
					btnD14.Text = "ံ";
					btnA15.Text = "၇";
					btnB15.Text = "၄";
					btnC15.Text = "၁";
					btnD15.Text = "၊";
					btnA16.Text = "၈";
					btnB16.Text = "၅";
					btnC16.Text = "၂";
					btnD16.Text = "၀";
					btnA17.Text = "၉";
					btnB17.Text = "၆";
					btnC17.Text = "၃";
					btnD17.Text = "။";
					btnA01.Size = btnA02.Size = btnA03.Size = btnA04.Size = btnA05.Size = btnA06.Size = btnA07.Size = btnA08.Size = btnA09.Size = btnA10.Size = btnA11.Size = btnA12.Size = btnA13.Size = btnA14.Size = btnA15.Size = btnA16.Size = btnA17.Size = new System.Drawing.Size(48, 48);
					btnB01.Size = btnB02.Size = btnB03.Size = btnB04.Size = btnB05.Size = btnB06.Size = btnB07.Size = btnB08.Size = btnB09.Size = btnB10.Size = btnB11.Size = btnB12.Size = btnB13.Size = btnB14.Size = btnB15.Size = btnB16.Size = btnD17.Size = new System.Drawing.Size(48, 48);
					btnC01.Size = btnC02.Size = btnC03.Size = btnC04.Size = btnC05.Size = btnC06.Size = btnC07.Size = btnC08.Size = btnC09.Size = btnC10.Size = btnC11.Size = btnC12.Size = btnC13.Size = btnC14.Size = btnC15.Size = btnC16.Size = btnC17.Size = new System.Drawing.Size(48, 48);
					btnD01.Size = btnD02.Size = btnD03.Size = btnD04.Size = btnD05.Size = btnD06.Size = btnD07.Size = btnD08.Size = btnD09.Size = btnD10.Size = btnD11.Size = btnD12.Size = btnD13.Size = btnD14.Size = btnD15.Size = btnD16.Size = btnB17.Size = new System.Drawing.Size(48, 48);
					btnA02.Location = new System.Drawing.Point(56, 4);
					btnA03.Location = new System.Drawing.Point(108, 4);
					btnA04.Location = new System.Drawing.Point(160, 4);
					btnA05.Location = new System.Drawing.Point(212, 4);
					btnA06.Location = new System.Drawing.Point(264, 4);
					btnA07.Location = new System.Drawing.Point(316, 4);
					btnA08.Location = new System.Drawing.Point(368, 4);
					btnA09.Location = new System.Drawing.Point(420, 4);
					btnA10.Location = new System.Drawing.Point(472, 4);
					btnA11.Location = new System.Drawing.Point(524, 4);
					btnA12.Location = new System.Drawing.Point(576, 4);
					btnA13.Location = new System.Drawing.Point(628, 4);
					btnA14.Location = new System.Drawing.Point(680, 4);
					btnA15.Location = new System.Drawing.Point(732, 4);
					btnA16.Location = new System.Drawing.Point(784, 4);
					btnA17.Location = new System.Drawing.Point(836, 4);
					btnB02.Location = new System.Drawing.Point(56, 56);
					btnB03.Location = new System.Drawing.Point(108, 56);
					btnB04.Location = new System.Drawing.Point(160, 56);
					btnB05.Location = new System.Drawing.Point(212, 56);
					btnB06.Location = new System.Drawing.Point(264, 56);
					btnB07.Location = new System.Drawing.Point(316, 56);
					btnB08.Location = new System.Drawing.Point(368, 56);
					btnB09.Location = new System.Drawing.Point(420, 56);
					btnB10.Location = new System.Drawing.Point(472, 56);
					btnB11.Location = new System.Drawing.Point(524, 56);
					btnB12.Location = new System.Drawing.Point(576, 56);
					btnB13.Location = new System.Drawing.Point(628, 56);
					btnB14.Location = new System.Drawing.Point(680, 56);
					btnB15.Location = new System.Drawing.Point(732, 56);
					btnB16.Location = new System.Drawing.Point(784, 56);
					btnB17.Location = new System.Drawing.Point(836, 56);
					btnC02.Location = new System.Drawing.Point(56, 108);
					btnC03.Location = new System.Drawing.Point(108, 108);
					btnC04.Location = new System.Drawing.Point(160, 108);
					btnC05.Location = new System.Drawing.Point(212, 108);
					btnC06.Location = new System.Drawing.Point(264, 108);
					btnC07.Location = new System.Drawing.Point(316, 108);
					btnC08.Location = new System.Drawing.Point(368, 108);
					btnC09.Location = new System.Drawing.Point(420, 108);
					btnC10.Location = new System.Drawing.Point(472, 108);
					btnC11.Location = new System.Drawing.Point(524, 108);
					btnC12.Location = new System.Drawing.Point(576, 108);
					btnC13.Location = new System.Drawing.Point(628, 108);
					btnC14.Location = new System.Drawing.Point(680, 108);
					btnC15.Location = new System.Drawing.Point(732, 108);
					btnC16.Location = new System.Drawing.Point(784, 108);
					btnC17.Location = new System.Drawing.Point(836, 108);
					btnD02.Location = new System.Drawing.Point(56, 160);
					btnD03.Location = new System.Drawing.Point(108, 160);
					btnD04.Location = new System.Drawing.Point(160, 160);
					btnD05.Location = new System.Drawing.Point(212, 160);
					btnD06.Location = new System.Drawing.Point(264, 160);
					btnD07.Location = new System.Drawing.Point(316, 160);
					btnD08.Location = new System.Drawing.Point(368, 160);
					btnD09.Location = new System.Drawing.Point(420, 160);
					btnD10.Location = new System.Drawing.Point(472, 160);
					btnD11.Location = new System.Drawing.Point(524, 160);
					btnD12.Location = new System.Drawing.Point(576, 160);
					btnD13.Location = new System.Drawing.Point(628, 160);
					btnD14.Location = new System.Drawing.Point(680, 160);
					btnD15.Location = new System.Drawing.Point(732, 160);
					btnD16.Location = new System.Drawing.Point(784, 160);
					btnD17.Location = new System.Drawing.Point(836, 160);
					btnC04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD05.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD07.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD12.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD14.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC01.Visible = false;
					btnD01.Visible = false;
					btnA07.Visible = true;
					btnD12.Visible = false;
					btnC13.Visible = false;
					btnD13.Visible = false;
					btnA14.Visible = false;
					btnB14.Visible = false;
					btnC14.Visible = false;
					btnD14.Visible = false;
				}
				else
				{
					btnA01.Text = "ၐ";
					btnB01.Text = "ဆ";
					btnC01.Text = ""; // blank
					btnD01.Text = ""; // blank
					btnA02.Text = "၁";
					btnB02.Text = "တ";
					btnC02.Text = "ေ";
					btnD02.Text = "ဖ";
					btnA03.Text = "၂";
					btnB03.Text = "န";
					btnC03.Text = "ျ"; // y medial
					btnD03.Text = "ထ";
					btnA04.Text = "၃";
					btnB04.Text = "မ";
					btnC04.Text = "ိ";
					btnD04.Text = "ခ";
					btnA05.Text = "၄";
					btnB05.Text = "အ";
					btnC05.Text = "်";
					btnD05.Text = "လ";
					btnA06.Text = "၅";
					btnB06.Text = "ပ";
					btnC06.Text = "ါ"; // asat
					btnD06.Text = "ဘ";
					btnA07.Text = "၆";
					btnB07.Text = "က";
					btnC07.Text = "့"; // creaky
					btnD07.Text = "ည";
					btnA08.Text = "၇";
					btnB08.Text = "င";
					btnC08.Text = "ြ"; // y medial
					btnD08.Text = "ာ"; // short a
					btnA09.Text = "၈";
					btnB09.Text = "သ";
					btnC09.Text = "ု";
					btnD09.Text = ",";
					btnA10.Text = "၉";
					btnB10.Text = "စ";
					btnC10.Text = "ူ";
					btnD10.Text = ".";
					btnA11.Text = "၀";
					btnB11.Text = "ဟ";
					btnC11.Text = "း";
					btnD11.Text = "/";
					btnA12.Text = "-";
					btnB12.Text = "ဩ";
					btnC12.Text = "'";
					btnD12.Text = "";
					btnA13.Text = "=";
					btnB13.Text = "၏";
					btnC13.Text = "";
					btnD13.Text = "";
					btnA14.Text = "့";
					btnB14.Text = "း";
					btnC14.Text = "်";
					btnD14.Text = "ံ";
					btnA15.Text = "၇";
					btnB15.Text = "၄";
					btnC15.Text = "၁";
					btnD15.Text = "၊";
					btnA16.Text = "၈";
					btnB16.Text = "၅";
					btnC16.Text = "၂";
					btnD16.Text = "၀";
					btnA17.Text = "၉";
					btnB17.Text = "၆";
					btnC17.Text = "၃";
					btnD17.Text = "။";
					btnA01.Size = btnA02.Size = btnA03.Size = btnA04.Size = btnA05.Size = btnA06.Size = btnA07.Size = btnA08.Size = btnA09.Size = btnA10.Size = btnA11.Size = btnA12.Size = btnA13.Size = btnA14.Size = btnA15.Size = btnA16.Size = btnA17.Size = new System.Drawing.Size(48, 48);
					btnB01.Size = btnB02.Size = btnB03.Size = btnB04.Size = btnB05.Size = btnB06.Size = btnB07.Size = btnB08.Size = btnB09.Size = btnB10.Size = btnB11.Size = btnB12.Size = btnB13.Size = btnB14.Size = btnB15.Size = btnB16.Size = btnD17.Size = new System.Drawing.Size(48, 48);
					btnC01.Size = btnC02.Size = btnC03.Size = btnC04.Size = btnC05.Size = btnC06.Size = btnC07.Size = btnC08.Size = btnC09.Size = btnC10.Size = btnC11.Size = btnC12.Size = btnC13.Size = btnC14.Size = btnC15.Size = btnC16.Size = btnC17.Size = new System.Drawing.Size(48, 48);
					btnD01.Size = btnD02.Size = btnD03.Size = btnD04.Size = btnD05.Size = btnD06.Size = btnD07.Size = btnD08.Size = btnD09.Size = btnD10.Size = btnD11.Size = btnD12.Size = btnD13.Size = btnD14.Size = btnD15.Size = btnD16.Size = btnB17.Size = new System.Drawing.Size(48, 48);
					btnA02.Location = new System.Drawing.Point(56, 4);
					btnA03.Location = new System.Drawing.Point(108, 4);
					btnA04.Location = new System.Drawing.Point(160, 4);
					btnA05.Location = new System.Drawing.Point(212, 4);
					btnA06.Location = new System.Drawing.Point(264, 4);
					btnA07.Location = new System.Drawing.Point(316, 4);
					btnA08.Location = new System.Drawing.Point(368, 4);
					btnA09.Location = new System.Drawing.Point(420, 4);
					btnA10.Location = new System.Drawing.Point(472, 4);
					btnA11.Location = new System.Drawing.Point(524, 4);
					btnA12.Location = new System.Drawing.Point(576, 4);
					btnA13.Location = new System.Drawing.Point(628, 4);
					btnA14.Location = new System.Drawing.Point(680, 4);
					btnA15.Location = new System.Drawing.Point(732, 4);
					btnA16.Location = new System.Drawing.Point(784, 4);
					btnA17.Location = new System.Drawing.Point(836, 4);
					btnB02.Location = new System.Drawing.Point(56, 56);
					btnB03.Location = new System.Drawing.Point(108, 56);
					btnB04.Location = new System.Drawing.Point(160, 56);
					btnB05.Location = new System.Drawing.Point(212, 56);
					btnB06.Location = new System.Drawing.Point(264, 56);
					btnB07.Location = new System.Drawing.Point(316, 56);
					btnB08.Location = new System.Drawing.Point(368, 56);
					btnB09.Location = new System.Drawing.Point(420, 56);
					btnB10.Location = new System.Drawing.Point(472, 56);
					btnB11.Location = new System.Drawing.Point(524, 56);
					btnB12.Location = new System.Drawing.Point(576, 56);
					btnB13.Location = new System.Drawing.Point(628, 56);
					btnB14.Location = new System.Drawing.Point(680, 56);
					btnB15.Location = new System.Drawing.Point(732, 56);
					btnB16.Location = new System.Drawing.Point(784, 56);
					btnB17.Location = new System.Drawing.Point(836, 56);
					btnC02.Location = new System.Drawing.Point(56, 108);
					btnC03.Location = new System.Drawing.Point(108, 108);
					btnC04.Location = new System.Drawing.Point(160, 108);
					btnC05.Location = new System.Drawing.Point(212, 108);
					btnC06.Location = new System.Drawing.Point(264, 108);
					btnC07.Location = new System.Drawing.Point(316, 108);
					btnC08.Location = new System.Drawing.Point(368, 108);
					btnC09.Location = new System.Drawing.Point(420, 108);
					btnC10.Location = new System.Drawing.Point(472, 108);
					btnC11.Location = new System.Drawing.Point(524, 108);
					btnC12.Location = new System.Drawing.Point(576, 108);
					btnC13.Location = new System.Drawing.Point(628, 108);
					btnC14.Location = new System.Drawing.Point(680, 108);
					btnC15.Location = new System.Drawing.Point(732, 108);
					btnC16.Location = new System.Drawing.Point(784, 108);
					btnC17.Location = new System.Drawing.Point(836, 108);
					btnD02.Location = new System.Drawing.Point(56, 160);
					btnD03.Location = new System.Drawing.Point(108, 160);
					btnD04.Location = new System.Drawing.Point(160, 160);
					btnD05.Location = new System.Drawing.Point(212, 160);
					btnD06.Location = new System.Drawing.Point(264, 160);
					btnD07.Location = new System.Drawing.Point(316, 160);
					btnD08.Location = new System.Drawing.Point(368, 160);
					btnD09.Location = new System.Drawing.Point(420, 160);
					btnD10.Location = new System.Drawing.Point(472, 160);
					btnD11.Location = new System.Drawing.Point(524, 160);
					btnD12.Location = new System.Drawing.Point(576, 160);
					btnD13.Location = new System.Drawing.Point(628, 160);
					btnD14.Location = new System.Drawing.Point(680, 160);
					btnD15.Location = new System.Drawing.Point(732, 160);
					btnD16.Location = new System.Drawing.Point(784, 160);
					btnD17.Location = new System.Drawing.Point(836, 160);
					btnC04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD05.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD07.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD12.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD14.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC01.Visible = false;
					btnD01.Visible = false;
					btnA07.Visible = true;
					btnD12.Visible = false;
					btnC13.Visible = false;
					btnD13.Visible = false;
					btnA14.Visible = false;
					btnB14.Visible = false;
					btnC14.Visible = false;
					btnD14.Visible = false;
				}
			}
			else
			{
				if (chkBoxShift.Checked || chkBoxLock.Checked == true)
				{
					btnA01.Text = "ာ";
					btnB01.Text = "";
					btnC01.Text = "န်";
					btnD01.Text = "တ်";
					btnA02.Text = "ါ";
					btnB02.Text = "";
					btnC02.Text = "မ်";
					btnD02.Text = "ပ်";
					btnA03.Text = "ိ";
					btnB03.Text = "ဣ";
					btnC03.Text = "င်";
					btnD03.Text = "စ်";
					btnA04.Text = "ီ";
					btnB04.Text = "ဤ";
					btnC04.Text = "ေန်";
					btnD04.Text = "ေတ်";
					btnA05.Text = "ု";
					btnB05.Text = "ဥ";
					btnC05.Text = "ွန်";
					btnD05.Text = "ွတ်";
					btnA06.Text = "ူ";
					btnB06.Text = "ဦ";
					btnC06.Text = "ွမ်";
					btnD06.Text = "ွပ်";
					btnA07.Text = "ေ";
					btnB07.Text = "ဧ";
					btnC07.Text = "ိန်";
					btnD07.Text = "ိတ်"; // stacker
					btnA08.Text = "";
					btnB08.Text = "ည်";
					btnC08.Text = "ိမ်";
					btnD08.Text = "ိပ်";
					btnA09.Text = "ဲ";
					btnB09.Text = "ယ်";
					btnC09.Text = "";
					btnD09.Text = "က်";
					btnA10.Text = "◌ော";
					btnB10.Text = "ဪ";
					btnC10.Text = "◌ောင်";
					btnD10.Text = "◌ောက်";
					btnA11.Text = "◌ေါ";
					btnB11.Text = "ဩ";
					btnC11.Text = "◌ေါင်";
					btnD11.Text = "◌ေါက်";
					btnA12.Text = "◌ို";
					btnB12.Text = "ဴ";
					btnC12.Text = "ုန်";
					btnD12.Text = "ုတ်";
					btnA13.Text = "့";
					btnB13.Text = "်";
					btnC13.Text = "ုမ်";
					btnD13.Text = "ုပ်";
					btnA14.Text = "ံ";
					btnB14.Text = "း";
					btnC14.Text = "◌ိုင်";
					btnD14.Text = "◌ိုက်";
					btnA15.Text = "၁";
					btnB15.Text = "၄";
					btnC15.Text = "၇";
					btnD15.Text = "၊";
					btnA16.Text = "၂";
					btnB16.Text = "၅";
					btnC16.Text = "၈";
					btnD16.Text = "၀";
					btnA17.Text = "၃";
					btnB17.Text = "၆";
					btnC17.Text = "၉";
					btnD17.Text = "။";
					btnA01.Size = btnA02.Size = btnA03.Size = btnA04.Size = btnA05.Size = btnA06.Size = btnA07.Size = btnA08.Size = btnA09.Size = btnA10.Size = btnA11.Size = btnA12.Size = btnA13.Size = btnA14.Size = btnA15.Size = btnA16.Size = btnA17.Size = new System.Drawing.Size(42, 48);
					btnB01.Size = btnB02.Size = btnB03.Size = btnB04.Size = btnB05.Size = btnB06.Size = btnB07.Size = btnB08.Size = btnB09.Size = btnB10.Size = btnB11.Size = btnB12.Size = btnB13.Size = btnB14.Size = btnB15.Size = btnB16.Size = btnD17.Size = new System.Drawing.Size(42, 48);
					btnC01.Size = btnC02.Size = btnC03.Size = btnC04.Size = btnC05.Size = btnC06.Size = btnC07.Size = btnC08.Size = btnC09.Size = btnC10.Size = btnC11.Size = btnC12.Size = btnC13.Size = btnC14.Size = btnC15.Size = btnC16.Size = btnC17.Size = new System.Drawing.Size(42, 48);
					btnD01.Size = btnD02.Size = btnD03.Size = btnD04.Size = btnD05.Size = btnD06.Size = btnD07.Size = btnD08.Size = btnD09.Size = btnD10.Size = btnD11.Size = btnD12.Size = btnD13.Size = btnD14.Size = btnD15.Size = btnD16.Size = btnB17.Size = new System.Drawing.Size(42, 48);
					btnA04.Size = btnB04.Size = btnC04.Size = btnD04.Size = new System.Drawing.Size(60, 48);
					btnA05.Size = btnB05.Size = btnC05.Size = btnD05.Size = new System.Drawing.Size(51, 48);
					btnA07.Size = btnB07.Size = btnC07.Size = btnD07.Size = new System.Drawing.Size(51, 48);
					btnA10.Size = btnB10.Size = btnC10.Size = btnD10.Size = new System.Drawing.Size(66, 48);
					btnA11.Size = btnB11.Size = btnC11.Size = btnD11.Size = new System.Drawing.Size(66, 48);
					btnA12.Size = btnB12.Size = btnC12.Size = btnD12.Size = new System.Drawing.Size(51, 48);
					btnA14.Size = btnB14.Size = btnC14.Size = btnD14.Size = new System.Drawing.Size(51, 48);
					btnA02.Location = new System.Drawing.Point(50, 4);
					btnB02.Location = new System.Drawing.Point(50, 56);
					btnC02.Location = new System.Drawing.Point(50, 108);
					btnD02.Location = new System.Drawing.Point(50, 160);
					btnA03.Location = new System.Drawing.Point(96, 4);
					btnB03.Location = new System.Drawing.Point(96, 56);
					btnC03.Location = new System.Drawing.Point(96, 108);
					btnD03.Location = new System.Drawing.Point(96, 160);
					btnA04.Location = new System.Drawing.Point(142, 4);
					btnB04.Location = new System.Drawing.Point(142, 56);
					btnC04.Location = new System.Drawing.Point(142, 108);
					btnD04.Location = new System.Drawing.Point(142, 160);
					btnA05.Location = new System.Drawing.Point(206, 4);
					btnB05.Location = new System.Drawing.Point(206, 56);
					btnC05.Location = new System.Drawing.Point(206, 108);
					btnD05.Location = new System.Drawing.Point(206, 160);
					btnA06.Location = new System.Drawing.Point(261, 4);
					btnB06.Location = new System.Drawing.Point(261, 56);
					btnC06.Location = new System.Drawing.Point(261, 108);
					btnD06.Location = new System.Drawing.Point(261, 160);
					btnA07.Location = new System.Drawing.Point(307, 4);
					btnB07.Location = new System.Drawing.Point(307, 56);
					btnC07.Location = new System.Drawing.Point(307, 108);
					btnD07.Location = new System.Drawing.Point(307, 160);
					btnA08.Location = new System.Drawing.Point(362, 4);
					btnB08.Location = new System.Drawing.Point(362, 56);
					btnC08.Location = new System.Drawing.Point(362, 108);
					btnD08.Location = new System.Drawing.Point(362, 160);
					btnA09.Location = new System.Drawing.Point(408, 4);
					btnB09.Location = new System.Drawing.Point(408, 56);
					btnC09.Location = new System.Drawing.Point(408, 108);
					btnD09.Location = new System.Drawing.Point(408, 160);
					btnA10.Location = new System.Drawing.Point(454, 4);
					btnB10.Location = new System.Drawing.Point(454, 56);
					btnC10.Location = new System.Drawing.Point(454, 108);
					btnD10.Location = new System.Drawing.Point(454, 160);
					btnA11.Location = new System.Drawing.Point(524, 4);
					btnB11.Location = new System.Drawing.Point(524, 56);
					btnC11.Location = new System.Drawing.Point(524, 108);
					btnD11.Location = new System.Drawing.Point(524, 160);
					btnA12.Location = new System.Drawing.Point(594, 4);
					btnB12.Location = new System.Drawing.Point(594, 56);
					btnC12.Location = new System.Drawing.Point(594, 108);
					btnD12.Location = new System.Drawing.Point(594, 160);
					btnA13.Location = new System.Drawing.Point(649, 4);
					btnB13.Location = new System.Drawing.Point(649, 56);
					btnC13.Location = new System.Drawing.Point(649, 108);
					btnD13.Location = new System.Drawing.Point(649, 160);
					btnA14.Location = new System.Drawing.Point(695, 4);
					btnB14.Location = new System.Drawing.Point(695, 56);
					btnC14.Location = new System.Drawing.Point(695, 108);
					btnD14.Location = new System.Drawing.Point(695, 160);
					btnA15.Location = new System.Drawing.Point(750, 4);
					btnB15.Location = new System.Drawing.Point(750, 56);
					btnC15.Location = new System.Drawing.Point(750, 108);
					btnD15.Location = new System.Drawing.Point(750, 160);
					btnA16.Location = new System.Drawing.Point(796, 4);
					btnB16.Location = new System.Drawing.Point(796, 56);
					btnC16.Location = new System.Drawing.Point(796, 108);
					btnD16.Location = new System.Drawing.Point(796, 160);
					btnA17.Location = new System.Drawing.Point(842, 4);
					btnB17.Location = new System.Drawing.Point(842, 56);
					btnC17.Location = new System.Drawing.Point(842, 108);
					btnD17.Location = new System.Drawing.Point(842, 160);
					btnC04.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD04.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD05.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC06.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD06.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD07.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC08.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD08.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnA10.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC10.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD10.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnA11.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC11.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD11.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD12.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC13.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD13.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnD14.Font = new System.Drawing.Font("Myanmar Text", 12);
					btnC01.Visible = true;
					btnD01.Visible = true;
					btnA07.Visible = true;
					btnD12.Visible = true;
					btnC13.Visible = true;
					btnD13.Visible = true;
					btnA14.Visible = true;
					btnB14.Visible = true;
					btnC14.Visible = true;
					btnD14.Visible = true;
				}
				else
				{
					btnA01.Text = "က";
					btnB01.Text = "ခ";
					btnC01.Text = "ဂ";
					btnD01.Text = "ဃ";
					btnA02.Text = "စ";
					btnB02.Text = "ဆ";
					btnC02.Text = "ဇ";
					btnD02.Text = "ဈ";
					btnA03.Text = "ဋ";
					btnB03.Text = "ဌ";
					btnC03.Text = "ဍ";
					btnD03.Text = "ဎ";
					btnA04.Text = "တ";
					btnB04.Text = "ထ";
					btnC04.Text = "ဒ";
					btnD04.Text = "ဓ";
					btnA05.Text = "ပ";
					btnB05.Text = "ဖ";
					btnC05.Text = "ဗ";
					btnD05.Text = "ဘ";
					btnA06.Text = "င";
					btnB06.Text = "ည";
					btnC06.Text = "န";
					btnD06.Text = "မ";
					btnA07.Text = "";
					btnB07.Text = "ဉ";
					btnC07.Text = "ဏ";
					btnD07.Text = "္";
					btnA08.Text = "ယ";
					btnB08.Text = "ရ";
					btnC08.Text = "လ";
					btnD08.Text = "ဝ";
					btnA09.Text = "သ";
					btnB09.Text = "ဟ";
					btnC09.Text = "ဠ";
					btnD09.Text = "အ";
					btnA10.Text = "ျ";
					btnB10.Text = "ြ";
					btnC10.Text = "ွ";
					btnD10.Text = "ှ";
					btnA11.Text = "ာ";
					btnB11.Text = "ါ";
					btnC11.Text = "ိ";
					btnD11.Text = "ီ";
					btnA12.Text = "ု";
					btnB12.Text = "ူ";
					btnC12.Text = "ေ";
					btnD12.Text = "ဲ";
					btnA13.Text = "◌ော";
					btnB13.Text = "◌ေါ";
					btnC13.Text = "◌ို";
					btnD13.Text = "";
					btnA14.Text = "့";
					btnB14.Text = "း";
					btnC14.Text = "်";
					btnD14.Text = "ံ";
					btnA15.Text = "၁";
					btnB15.Text = "၄";
					btnC15.Text = "၇";
					btnD15.Text = "၊";
					btnA16.Text = "၂";
					btnB16.Text = "၅";
					btnC16.Text = "၈";
					btnD16.Text = "၀";
					btnA17.Text = "၃";
					btnB17.Text = "၆";
					btnC17.Text = "၉";
					btnD17.Text = "။";
					btnA01.Size = btnA02.Size = btnA03.Size = btnA04.Size = btnA05.Size = btnA06.Size = btnA07.Size = btnA08.Size = btnA09.Size = btnA10.Size = btnA11.Size = btnA12.Size = btnA13.Size = btnA14.Size = btnA15.Size = btnA16.Size = btnA17.Size = new System.Drawing.Size(48, 48);
					btnB01.Size = btnB02.Size = btnB03.Size = btnB04.Size = btnB05.Size = btnB06.Size = btnB07.Size = btnB08.Size = btnB09.Size = btnB10.Size = btnB11.Size = btnB12.Size = btnB13.Size = btnB14.Size = btnB15.Size = btnB16.Size = btnD17.Size = new System.Drawing.Size(48, 48);
					btnC01.Size = btnC02.Size = btnC03.Size = btnC04.Size = btnC05.Size = btnC06.Size = btnC07.Size = btnC08.Size = btnC09.Size = btnC10.Size = btnC11.Size = btnC12.Size = btnC13.Size = btnC14.Size = btnC15.Size = btnC16.Size = btnC17.Size = new System.Drawing.Size(48, 48);
					btnD01.Size = btnD02.Size = btnD03.Size = btnD04.Size = btnD05.Size = btnD06.Size = btnD07.Size = btnD08.Size = btnD09.Size = btnD10.Size = btnD11.Size = btnD12.Size = btnD13.Size = btnD14.Size = btnD15.Size = btnD16.Size = btnB17.Size = new System.Drawing.Size(48, 48);
					btnA02.Location = new System.Drawing.Point(56, 4);
					btnA03.Location = new System.Drawing.Point(108, 4);
					btnA04.Location = new System.Drawing.Point(160, 4);
					btnA05.Location = new System.Drawing.Point(212, 4);
					btnA06.Location = new System.Drawing.Point(264, 4);
					btnA07.Location = new System.Drawing.Point(316, 4);
					btnA08.Location = new System.Drawing.Point(368, 4);
					btnA09.Location = new System.Drawing.Point(420, 4);
					btnA10.Location = new System.Drawing.Point(472, 4);
					btnA11.Location = new System.Drawing.Point(524, 4);
					btnA12.Location = new System.Drawing.Point(576, 4);
					btnA13.Location = new System.Drawing.Point(628, 4);
					btnA14.Location = new System.Drawing.Point(680, 4);
					btnA15.Location = new System.Drawing.Point(732, 4);
					btnA16.Location = new System.Drawing.Point(784, 4);
					btnA17.Location = new System.Drawing.Point(836, 4);
					btnB02.Location = new System.Drawing.Point(56, 56);
					btnB03.Location = new System.Drawing.Point(108, 56);
					btnB04.Location = new System.Drawing.Point(160, 56);
					btnB05.Location = new System.Drawing.Point(212, 56);
					btnB06.Location = new System.Drawing.Point(264, 56);
					btnB07.Location = new System.Drawing.Point(316, 56);
					btnB08.Location = new System.Drawing.Point(368, 56);
					btnB09.Location = new System.Drawing.Point(420, 56);
					btnB10.Location = new System.Drawing.Point(472, 56);
					btnB11.Location = new System.Drawing.Point(524, 56);
					btnB12.Location = new System.Drawing.Point(576, 56);
					btnB13.Location = new System.Drawing.Point(628, 56);
					btnB14.Location = new System.Drawing.Point(680, 56);
					btnB15.Location = new System.Drawing.Point(732, 56);
					btnB16.Location = new System.Drawing.Point(784, 56);
					btnB17.Location = new System.Drawing.Point(836, 56);
					btnC02.Location = new System.Drawing.Point(56, 108);
					btnC03.Location = new System.Drawing.Point(108, 108);
					btnC04.Location = new System.Drawing.Point(160, 108);
					btnC05.Location = new System.Drawing.Point(212, 108);
					btnC06.Location = new System.Drawing.Point(264, 108);
					btnC07.Location = new System.Drawing.Point(316, 108);
					btnC08.Location = new System.Drawing.Point(368, 108);
					btnC09.Location = new System.Drawing.Point(420, 108);
					btnC10.Location = new System.Drawing.Point(472, 108);
					btnC11.Location = new System.Drawing.Point(524, 108);
					btnC12.Location = new System.Drawing.Point(576, 108);
					btnC13.Location = new System.Drawing.Point(628, 108);
					btnC14.Location = new System.Drawing.Point(680, 108);
					btnC15.Location = new System.Drawing.Point(732, 108);
					btnC16.Location = new System.Drawing.Point(784, 108);
					btnC17.Location = new System.Drawing.Point(836, 108);
					btnD02.Location = new System.Drawing.Point(56, 160);
					btnD03.Location = new System.Drawing.Point(108, 160);
					btnD04.Location = new System.Drawing.Point(160, 160);
					btnD05.Location = new System.Drawing.Point(212, 160);
					btnD06.Location = new System.Drawing.Point(264, 160);
					btnD07.Location = new System.Drawing.Point(316, 160);
					btnD08.Location = new System.Drawing.Point(368, 160);
					btnD09.Location = new System.Drawing.Point(420, 160);
					btnD10.Location = new System.Drawing.Point(472, 160);
					btnD11.Location = new System.Drawing.Point(524, 160);
					btnD12.Location = new System.Drawing.Point(576, 160);
					btnD13.Location = new System.Drawing.Point(628, 160);
					btnD14.Location = new System.Drawing.Point(680, 160);
					btnD15.Location = new System.Drawing.Point(732, 160);
					btnD16.Location = new System.Drawing.Point(784, 160);
					btnD17.Location = new System.Drawing.Point(836, 160);
					btnC04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD04.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD05.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD06.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD07.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD08.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD10.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnA11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD11.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD12.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD13.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnD14.Font = new System.Drawing.Font("Myanmar Text", 14);
					btnC01.Visible = true;
					btnD01.Visible = true;
					btnA07.Visible = false;
					btnD12.Visible = true;
					btnC13.Visible = true;
					btnD13.Visible = false;
					btnA14.Visible = true;
					btnB14.Visible = true;
					btnC14.Visible = true;
					btnD14.Visible = true;
				}
			}
		}

		private void BtnA01_Click(object sender, EventArgs e)
		{
			String OSKBtnText = btnA01.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA02_Click(object sender, EventArgs e)
		{
			String OSKBtnText = btnA02.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA03_Click(object sender, System.EventArgs e) // ဋ
		{
			String OSKBtnText = btnA03.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA04_Click(object sender, System.EventArgs e) // တ
		{
			String OSKBtnText = btnA04.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA05_Click(object sender, System.EventArgs e) // ပ
		{
			String OSKBtnText = btnA05.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA06_Click(object sender, System.EventArgs e) // င
		{
			String OSKBtnText = btnA06.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA07_Click(object sender, System.EventArgs e) // င
		{
			String OSKBtnText = btnA07.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA08_Click(object sender, System.EventArgs e) // ယ
		{
			String OSKBtnText = btnA08.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA09_Click(object sender, System.EventArgs e) // သ
		{
			String OSKBtnText = btnA09.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA10_Click(object sender, System.EventArgs e) // မျ
		{
			String OSKBtnText = btnA10.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA11_Click(object sender, System.EventArgs e) // မာ
		{
			String OSKBtnText = btnA11.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA12_Click(object sender, System.EventArgs e) // မု
		{
			String OSKBtnText = btnA12.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA13_Click(object sender, System.EventArgs e) // မော
		{
			String OSKBtnText = btnA13.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA14_Click(object sender, System.EventArgs e) // မ့
		{
			String OSKBtnText = btnA14.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA15_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnA15.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA16_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnA16.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnA17_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnA17.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB01_Click(object sender, EventArgs e) // က ၐ ဎ
		{
			String OSKBtnText = btnB01.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB02_Click(object sender, EventArgs e) // စ
		{
			String OSKBtnText = btnB02.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB03_Click(object sender, System.EventArgs e) // ဋ
		{
			String OSKBtnText = btnB03.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB04_Click(object sender, System.EventArgs e) // တ
		{
			String OSKBtnText = btnB04.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB05_Click(object sender, System.EventArgs e) // ပ
		{
			String OSKBtnText = btnB05.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB06_Click(object sender, System.EventArgs e) // င
		{
			String OSKBtnText = btnB06.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB07_Click(object sender, System.EventArgs e) // င
		{
			String OSKBtnText = btnB07.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB08_Click(object sender, System.EventArgs e) // ယ
		{
			String OSKBtnText = btnB08.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB09_Click(object sender, System.EventArgs e) // သ
		{
			String OSKBtnText = btnB09.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB10_Click(object sender, System.EventArgs e) // မျ
		{
			String OSKBtnText = btnB10.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB11_Click(object sender, System.EventArgs e) // မာ
		{
			String OSKBtnText = btnB11.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB12_Click(object sender, System.EventArgs e) // မု
		{
			String OSKBtnText = btnB12.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB13_Click(object sender, System.EventArgs e) // မော
		{
			String OSKBtnText = btnB13.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB14_Click(object sender, System.EventArgs e) // မ့
		{
			String OSKBtnText = btnB14.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB15_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnB15.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB16_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnB16.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnB17_Click(object sender, System.EventArgs e)
		{
			String OSKBtnText = btnB17.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC01_Click(object sender, System.EventArgs e) // ဂ
		{
			String OSKBtnText = btnC01.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC02_Click(object sender, System.EventArgs e) // ဇ
		{
			String OSKBtnText = btnC02.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC03_Click(object sender, System.EventArgs e) // ဍ
		{
			String OSKBtnText = btnC03.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC04_Click(object sender, System.EventArgs e) // ဒ
		{
			String OSKBtnText = btnC04.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC05_Click(object sender, System.EventArgs e) // ဗ
		{
			String OSKBtnText = btnC05.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC06_Click(object sender, System.EventArgs e) // န
		{
			String OSKBtnText = btnC06.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC07_Click(object sender, System.EventArgs e) // ဏ
		{
			String OSKBtnText = btnC07.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC08_Click(object sender, System.EventArgs e) // လ
		{
			String OSKBtnText = btnC08.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC09_Click(object sender, System.EventArgs e) // ဠ
		{
			String OSKBtnText = btnC09.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC10_Click(object sender, System.EventArgs e) // မွ
		{
			String OSKBtnText = btnC10.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC11_Click(object sender, System.EventArgs e) // မိ
		{
			String OSKBtnText = btnC11.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC12_Click(object sender, System.EventArgs e) // မေ
		{
			String OSKBtnText = btnC12.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC13_Click(object sender, System.EventArgs e) // မို
		{
			String OSKBtnText = btnC13.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC14_Click(object sender, System.EventArgs e) // မ်
		{
			String OSKBtnText = btnC14.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC15_Click(object sender, System.EventArgs e) // ၇
		{
			String OSKBtnText = btnC15.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC16_Click(object sender, System.EventArgs e) // ၈
		{
			String OSKBtnText = btnC16.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnC17_Click(object sender, System.EventArgs e) // ၉
		{
			String OSKBtnText = btnC17.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD01_Click(object sender, System.EventArgs e) // ဃ
		{
			String OSKBtnText = btnD01.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD02_Click(object sender, System.EventArgs e) // ဈ
		{
			String OSKBtnText = btnD02.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD03_Click(object sender, System.EventArgs e) // ဎ
		{
			String OSKBtnText = btnD03.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD04_Click(object sender, System.EventArgs e) // ဓ
		{
			String OSKBtnText = btnD04.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD05_Click(object sender, System.EventArgs e) // ဘ
		{
			String OSKBtnText = btnD05.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD06_Click(object sender, System.EventArgs e) // မ
		{
			String OSKBtnText = btnD06.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD07_Click(object sender, System.EventArgs e) // မ္
		{
			String OSKBtnText = btnD07.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD08_Click(object sender, System.EventArgs e) // ဝ
		{
			String OSKBtnText = btnD08.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD09_Click(object sender, System.EventArgs e) // အ
		{
			String OSKBtnText = btnD09.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD10_Click(object sender, System.EventArgs e) // မှ
		{
			String OSKBtnText = btnD10.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD11_Click(object sender, System.EventArgs e) // မီ
		{
			String OSKBtnText = btnD11.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD12_Click(object sender, System.EventArgs e) // မဲ
		{
			String OSKBtnText = btnD12.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD13_Click(object sender, System.EventArgs e) // မံ
		{
			String OSKBtnText = btnD13.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD14_Click(object sender, System.EventArgs e) // မံ
		{
			String OSKBtnText = btnD14.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD15_Click(object sender, System.EventArgs e) // ၊
		{
			String OSKBtnText = btnD15.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD16_Click(object sender, System.EventArgs e) // ၀
		{
			String OSKBtnText = btnD16.Text;
			CleanOutput(OSKBtnText);
		}

		private void BtnD17_Click(object sender, System.EventArgs e) // ။
		{
			String OSKBtnText = btnD17.Text;
			CleanOutput(OSKBtnText);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			chkBoxLayout.Checked = false;
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnMinimise_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}

