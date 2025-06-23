// Product     : GRANDIT
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R99.cs
// 機能名      : HR_PY_03_R99 退職者用源泉徴収票(A4)(サブレポート)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K24565 2012/10/04 ActiveReportsバージョンアップ対応
// 2.0.0 2012/10/31
// 管理番号 K24060 2012/11/16 法改正対応（介護医療保険料控除）に伴う源泉徴収票のレイアウト変更
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30
// 3.1.0 2020/06/30
// 3.2.0 2023/03/31
// 管理番号K27665 2023/07/11 ActiveReportsバージョンアップ（SP4）対応

using System;
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;
using System.Globalization;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_03_R99 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R99()
		{


			InitializeComponent();
		}

		#region Protected Fields
		private Label label24;
		private Label label28;
		private Label label34;
		private Label label35;
		private Label label36;
		private Label label38;
		private Label label41;
		private Label label43;
		private Label label45;
		private Label label46;
		private Label label50;
		private Label label51;
		private Label label52;
		private Line line16;
		private Line line17;
		private Line line18;
		private Line line19;
		private Line line20;
		private Line line21;
		private Line line22;
		private Line line23;
		private Line line24;
		private Line line25;
		private Line line26;
		private Line line27;
		private Label label53;
		private Label label54;
		private Label label55;
		private Label label56;
		private Label label47;
		private TextBox YoungDpndNum2Text;
		private Label label57;
		private Label label60;
		private Label label61;
		private Label label62;
		private Label label63;
		private Label label65;
		private Label label66;
		private Label label68;
		private Label label70;
		private Label label71;
		private Label label72;
		private Label label75;
		private Label label76;
		private Label label77;
		private Line line28;
		private Line line29;
		private Line line30;
		private Line line31;
		private Line line32;
		private Line line33;
		private Line line34;
		private Line line35;
		private Line line36;
		private Line line37;
		private Line line38;
		private Line line39;
		private Label label78;
		private Label label79;
		private Label label80;
		private Label label81;
		private Label label1;
		private Line line1;
		private Label label2;
		private TextBox newLifeInsPensAmt2Text;
		private TextBox newLifeInsCareAmt2Text;
		private Label label3;
		private Label label4;
		private Line line2;
		private Label label5;
		private Label label6;
		private TextBox newLifeInsGeneralAmt2Text;
		private TextBox lifeInsGeneralAmt2Text;
		private Line line3;
		private Label label7;
		private Label label8;
		private Line line4;
		private TextBox summary1Digit2Text;
		private Label label9;
		private Line line5;
		private TextBox newLifeInsPensAmt3Text;
		private TextBox newLifeInsCareAmt3Text;
		private Label label10;
		private Label label11;
		private Line line6;
		private Label label12;
		private Label label13;
		private Label label14;
		private TextBox newLifeInsGeneralAmt3Text;
		private TextBox lifeInsGeneralAmt3Text;
		private Line line7;
		private Label label15;
		private Label label16;
		private Line line8;
		private TextBox summary1Digit3Text;
		private TextBox YoungDpndNum3Text;

		#endregion
		#region Properties
		#endregion

		private void HR_PY_03_R99_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			JapaneseCalendar ca = new JapaneseCalendar();
			string[] gg = { "明治", "大正", "昭和", "平成" };
			string YlyEdCalYear = YlyEdCalYear5Text.Text + "/12" + "/31";

			if (YlyEdCalYear5Text.Text.Length != 0)
			{
				DateTime dt = DateTime.Parse(YlyEdCalYear);
				if (ca.GetYear(dt) < 10)
				{
					YlyEdCalYear6Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);
				}
				else
				{
					YlyEdCalYear6Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);
				}
			}
			if (YlyEdCalYear7Text.Text.Length != 0)
			{
				DateTime dt = DateTime.Parse(YlyEdCalYear);
				if (ca.GetYear(dt) < 10)
				{
					YlyEdCalYear8Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);

				}
				else
				{
					YlyEdCalYear8Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);

				}
			}

			if ((this.YlyEdCalYear5Text.Text != null) && (this.YlyEdCalYear5Text.Text != ""))
			{
				if (Convert.ToDecimal(this.YlyEdCalYear5Text.Text) >= 2007)
				{
					this.Label1237.Text = "地震保険料";
					this.Label1526.Text = "地震保険料";
					this.Label1190.Text = "旧長期損害保険料の金額";
					this.Label1480.Text = "旧長期損害保険料の金額";
				}
				else
				{
					this.Label1237.Text = "損害保険料";
					this.Label1526.Text = "損害保険料";
					this.Label1190.Text = "長期損害保険料の金額";
					this.Label1480.Text = "長期損害保険料の金額";
				}
			}
		}




		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1138 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyEdAddress1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empCode2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox postName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameKana2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1142 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1144 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1146 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox class2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox slryInsmDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox incmDedAmtSum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyCollectTax2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1152 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1156 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1159 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposOldAgeType2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposexet2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExist2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1160 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1161 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposExtDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1162 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1163 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1164 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1165 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1166 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1167 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1168 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1169 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtAgePreNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1170 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1171 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1172 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1173 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1174 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1175 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtExtHandiNum1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1176 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1177 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1178 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1179 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1180 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1181 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1182 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox smlScaleCompCpratAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1183 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1184 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1185 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1186 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox housingObtDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1188 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1189 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1190 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposSumIncmAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1191 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1192 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsPensAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1193 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsLongProdAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1213 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1214 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1215 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1216 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1217 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1218 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1219 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1220 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox minrType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox latter2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widowType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extWidowType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widomType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox wrkStdType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1221 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1222 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1223 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAddress2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1224 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntPhone2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1225 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1226 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1228 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1229 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1230 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1231 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1232 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1233 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1234 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1235 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1236 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1237 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1238 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1239 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox deathRetireType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox disasterType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox foreignType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmployType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1261 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfRetireType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halrEmReDateYear2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateMonth2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateDay2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1262 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1263 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1264 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1265 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1266 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraM2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfErat2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraS2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraH2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayYear2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayMonth2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayDay2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox socInsDedAmt2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1273 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1274 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1275 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line463 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line473 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line474 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line475 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line476 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line477 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line478 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line479 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line480 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line481 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line482 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line483 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line484 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line485 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line486 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line487 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line488 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line489 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line490 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line491 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line492 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line493 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line494 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line495 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line496 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line497 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line498 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line499 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line500 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line501 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line502 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line503 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line504 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line505 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line506 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line507 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line508 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line509 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line510 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line511 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line512 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line513 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line514 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line515 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line528 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line529 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line530 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line531 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line532 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line533 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line534 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line535 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line536 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line537 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line538 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line541 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line542 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line616 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line621 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line622 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line625 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line626 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line627 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line628 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line629 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line630 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line631 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line632 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line633 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line634 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line635 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line636 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line637 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line638 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line639 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line640 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line641 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line642 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line643 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line644 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1421 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1422 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1423 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1424 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1425 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line645 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1426 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1203 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line646 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1427 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1428 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyEdAddress1_4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1429 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empCode3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox postName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameKana3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1430 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1431 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1432 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1433 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1434 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1435 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1436 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox class3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1438 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox slryInsmDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1439 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox incmDedAmtSum3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1440 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1441 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyCollectTax3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1442 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1443 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1444 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1445 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1446 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1447 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1448 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1449 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposOldAgeType2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposexet3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExist2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1450 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1451 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposExtDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1452 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1453 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1454 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1455 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1456 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1457 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum1_4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum2_4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1458 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1459 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtAgePreNum3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1460 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1461 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1462 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1463 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum2_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1464 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1465 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtExtHandiNum1_3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiNum3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1466 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1467 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1468 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1469 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1470 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiNum3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1471 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1472 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox smlScaleCompCpratAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1473 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1474 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1475 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1476 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox housingObtDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary0Digit3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1478 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1479 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1480 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposSumIncmAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1481 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1482 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsPensAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1483 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsLongProdAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1502 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1503 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1504 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1505 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1506 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1507 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1508 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TempName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1509 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox minrType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox latter3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widowType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extWidowType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widomType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox wrkStdType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1510 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1511 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1512 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAddress3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1513 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntPhone3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1514 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1515 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1517 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1518 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1519 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1520 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1521 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1522 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1523 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1524 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1525 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1526 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1527 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1528 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox deathRetireType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox disasterType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox foreignType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmployType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1550 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfRetireType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halrEmReDateYear3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateMonth3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateDay3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1551 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1552 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1553 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1554 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1555 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraM3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfErat3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraS3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraH3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayYear3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayMonth3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayDay3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox socInsDedAmt3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1562 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1563 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1564 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line647 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line648 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line649 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line650 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line651 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line652 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line653 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line654 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line655 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line656 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line657 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line658 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line659 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line660 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line661 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line662 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line663 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line664 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line665 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line666 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line667 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line668 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line669 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line670 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line671 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line672 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line673 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line674 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line675 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line676 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line677 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line678 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line679 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line680 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line681 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line682 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line683 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line684 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line685 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line686 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line687 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line688 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line689 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line690 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line703 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line704 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line705 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line706 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line707 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line708 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line709 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line710 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line711 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line712 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line713 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line716 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line717 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line718 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line719 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line720 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line721 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line722 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line723 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line724 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line725 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line726 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line727 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line728 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line729 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line730 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line731 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line732 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line733 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line734 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line735 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line736 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line737 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line738 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line739 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line740 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1567 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1568 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1569 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1570 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1571 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line741 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1572 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1573 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line742 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1579 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1580 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1581 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1582 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1583 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1589 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1590 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1591 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1592 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1593 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1594 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1597 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1598 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line754 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line755 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1599 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line756 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line757 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary2Digit2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary2Digit3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary0Digit2Text = null;

		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R99));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.summary1Digit3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label41 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label78 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label57 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label56 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label55 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label72 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label80 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label77 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label81 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YoungDpndNum3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label65 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label63 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label79 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label50 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label52 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label24 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label53 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label51 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label54 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label38 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1138 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empCode2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.postName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameKana2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1146 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.class2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.slryInsmDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1149 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmDedAmtSum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyCollectTax2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1152 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1153 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1156 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1157 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1158 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1159 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposOldAgeType2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposexet2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExist2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1160 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1161 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposExtDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1162 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1163 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1164 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1165 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1166 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1167 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.specDpndNum1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1168 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1169 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtAgePreNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1170 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.agePreNum1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1171 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1172 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1173 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1174 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1175 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtExtHandiNum1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1176 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1177 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1178 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1179 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1180 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HandiNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1181 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1182 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.smlScaleCompCpratAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1183 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1184 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1185 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1186 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.housingObtDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1188 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1189 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1190 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposSumIncmAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1191 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1192 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsPensAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1193 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsLongProdAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1213 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1214 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1215 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1216 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1217 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1218 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1219 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1220 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.minrType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latter2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HandiType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1221 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1222 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1223 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntAddress2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1224 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntPhone2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1225 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1226 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1228 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1229 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1230 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1231 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1232 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1233 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1234 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1235 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1236 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1237 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1238 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1239 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.deathRetireType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.foreignType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmployType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1261 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfRetireType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halrEmReDateYear2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateMonth2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDay2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1262 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1263 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1264 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1265 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1266 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.birthNameOfEraM2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfErat2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraS2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraH2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayYear2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonth2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDay2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1273 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1274 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1275 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line473 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line474 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line475 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line476 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line477 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line478 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line481 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line482 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line483 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line484 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line485 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line486 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line487 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line488 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line489 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line490 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line491 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line492 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line493 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line494 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line495 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line496 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line497 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line498 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line499 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line500 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line501 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line502 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line503 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line504 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line505 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line506 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line507 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line508 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line509 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line510 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line511 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line512 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line513 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line514 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line515 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line528 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line529 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line530 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line531 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line532 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line533 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line534 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line535 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line536 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line537 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line538 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line541 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line542 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line616 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line621 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line622 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line625 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line626 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line627 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line628 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line629 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line630 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line631 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line632 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line633 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line634 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line635 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line636 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line637 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line638 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line639 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line640 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line641 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line642 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line643 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line644 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1421 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1422 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1423 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1424 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1425 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line645 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1426 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1203 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line646 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1427 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1428 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1429 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empCode3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.postName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameKana3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1430 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1431 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1432 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1433 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1434 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1435 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1436 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.class3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1438 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.slryInsmDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1439 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmDedAmtSum3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1440 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1441 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyCollectTax3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1442 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1443 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1444 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1445 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1446 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1447 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1448 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1449 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposOldAgeType2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposexet3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExist2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1450 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1451 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposExtDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1452 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1453 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1454 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1455 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1456 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1457 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.specDpndNum1_4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1458 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1459 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtAgePreNum3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1460 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.agePreNum1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1461 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1462 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1463 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1464 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1465 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtExtHandiNum1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiNum3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1466 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1467 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1468 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1469 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1470 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HandiNum3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1471 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1472 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.smlScaleCompCpratAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1473 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1474 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1475 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1476 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.housingObtDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary0Digit3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1478 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1479 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1480 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposSumIncmAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1481 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1482 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsPensAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1483 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsLongProdAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1502 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1503 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1504 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1505 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1506 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1507 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1508 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TempName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1509 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.minrType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latter3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HandiType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1510 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1511 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1512 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntAddress3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1513 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntPhone3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1514 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1515 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1517 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1518 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1519 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1520 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1521 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1522 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1523 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1524 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1525 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1526 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1527 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1528 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.deathRetireType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.foreignType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmployType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1550 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfRetireType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halrEmReDateYear3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateMonth3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDay3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1551 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1552 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1553 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1554 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1555 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.birthNameOfEraM3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfErat3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraS3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraH3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayYear3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonth3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDay3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1562 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1563 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1564 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line649 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line650 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line651 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line652 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line653 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line655 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line656 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line657 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line658 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line659 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line660 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line661 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line662 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line663 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line664 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line665 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line666 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line667 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line668 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line669 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line670 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line671 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line672 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line673 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line674 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line675 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line676 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line677 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line678 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line679 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line680 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line681 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line682 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line683 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line684 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line685 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line686 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line687 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line688 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line689 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line690 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line703 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line704 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line705 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line706 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line707 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line708 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line709 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line710 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line711 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line712 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line713 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line716 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line717 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line718 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line719 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line720 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line721 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line722 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line723 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line724 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line725 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line726 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line727 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line728 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line729 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line730 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line731 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line732 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line733 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line734 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line735 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line736 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line737 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line738 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line739 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line740 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1567 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1568 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1569 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1570 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1571 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line741 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1572 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1573 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line742 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1579 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1580 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1581 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1582 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1583 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1589 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1590 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1591 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1592 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1593 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1594 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1597 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1598 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line754 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line755 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YlyEdCalYear5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YlyEdCalYear6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1599 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YlyEdCalYear8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YlyEdCalYear7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line756 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line757 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.summary2Digit2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary2Digit3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary0Digit2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label28 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label34 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label43 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label46 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line17 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line18 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line19 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line20 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line23 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line24 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line25 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line26 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line27 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label60 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label61 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label62 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label66 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label68 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label70 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label71 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label75 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label76 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line28 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line29 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line30 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line31 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line32 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line36 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line39 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line647 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line21 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line38 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line37 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line654 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line33 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line34 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line35 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line22 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YoungDpndNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line463 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line479 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line16 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line480 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line648 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsPensAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsCareAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsGeneralAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsGeneralAmt2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.summary1Digit2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.newLifeInsPensAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsCareAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label11 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label12 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label13 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label14 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsGeneralAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsGeneralAmt3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label15 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label16 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1138)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCode2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKana2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1146)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.class2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1149)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1152)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1156)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1159)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposexet2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1160)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1161)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1162)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1163)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1164)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1165)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1166)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1167)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1168)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1169)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1170)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1171)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1172)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1173)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1174)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1175)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNum1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1176)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1177)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1178)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1179)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1181)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1182)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1183)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1184)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1185)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1186)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1188)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1189)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1190)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumIncmAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1191)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1192)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1193)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1213)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1214)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1215)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1216)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1217)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1218)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1219)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1220)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latter2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1221)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1222)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1223)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1224)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1225)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1226)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1228)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1229)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1230)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1231)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1232)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1233)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1234)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1235)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1236)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1237)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1238)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1239)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1261)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halrEmReDateYear2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDay2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1262)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1263)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1264)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1265)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1266)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfErat2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1273)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1274)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1275)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1421)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1422)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1423)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1424)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1425)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1426)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1203)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1427)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1428)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1429)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCode3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKana3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1430)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1431)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1432)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1433)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1434)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1435)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1436)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.class3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1438)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1439)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1440)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1441)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1442)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1443)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1444)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1445)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1446)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1447)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1448)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1449)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposexet3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1450)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1451)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1452)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1453)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1454)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1455)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1456)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1457)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1458)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1459)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1460)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1461)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1462)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1463)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1464)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1465)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNum1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1466)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1467)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1468)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1469)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1470)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNum3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1471)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1472)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1473)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1474)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1475)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1476)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1478)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1479)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1480)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumIncmAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1481)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1482)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1483)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1502)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1503)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1504)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1505)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1506)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1507)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1508)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TempName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1509)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latter3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1510)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1511)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1512)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1513)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1514)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1515)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1517)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1518)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1519)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1520)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1521)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1522)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1523)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1524)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1525)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1526)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1527)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1528)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1550)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halrEmReDateYear3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDay3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1551)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1552)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1553)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1554)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1555)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfErat3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1562)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1563)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1564)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1567)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1568)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1569)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1570)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1571)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1572)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1573)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1579)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1580)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1581)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1582)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1583)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1589)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1590)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1591)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1592)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1593)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1594)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1597)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1598)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1599)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.summary1Digit3Text,
            this.label41,
            this.label78,
            this.label57,
            this.label56,
            this.label55,
            this.label72,
            this.label80,
            this.label77,
            this.label81,
            this.YoungDpndNum3Text,
            this.label65,
            this.label63,
            this.label79,
            this.label50,
            this.label52,
            this.label24,
            this.label53,
            this.label51,
            this.label35,
            this.label54,
            this.label38,
            this.Label1137,
            this.Label1138,
            this.ylyEdAddress1_3Text,
            this.Label1139,
            this.empCode2Text,
            this.postName2Text,
            this.empNameKana2Text,
            this.Label1140,
            this.Label1141,
            this.Label1142,
            this.Label1143,
            this.Label1144,
            this.Label1145,
            this.Label1146,
            this.class2Text,
            this.paymntAmt2Text,
            this.Label1147,
            this.Label1148,
            this.slryInsmDedAmt2Text,
            this.Label1149,
            this.incmDedAmtSum2Text,
            this.Label1150,
            this.Label1151,
            this.ylyCollectTax2Text,
            this.Label1152,
            this.Label1153,
            this.Label1154,
            this.Label1155,
            this.Label1156,
            this.Label1157,
            this.Label1158,
            this.Label1159,
            this.sposOldAgeType2_2Text,
            this.dedSposexet2Text,
            this.dedSposN1_2Text,
            this.dedSposExist2_2Text,
            this.dedSposN2_2Text,
            this.Label1160,
            this.Label1161,
            this.sposExtDedAmt2Text,
            this.Label1162,
            this.Label1163,
            this.Label1164,
            this.Label1165,
            this.Label1166,
            this.Label1167,
            this.specDpndNum1_3Text,
            this.specDpndNum2_3Text,
            this.Label1168,
            this.Label1169,
            this.liveTgtAgePreNum2Text,
            this.Label1170,
            this.agePreNum1_2Text,
            this.agePreNum2_2Text,
            this.Label1171,
            this.Label1172,
            this.othersDpndNum1_2Text,
            this.Label1173,
            this.othersDpndNum2_2Text,
            this.Label1174,
            this.Label1175,
            this.liveTgtExtHandiNum1_2Text,
            this.extHandiNum2Text,
            this.Label1176,
            this.Label1177,
            this.Label1178,
            this.Label1179,
            this.Label1180,
            this.HandiNum2Text,
            this.Label1181,
            this.Label1182,
            this.smlScaleCompCpratAmt2Text,
            this.Label1183,
            this.Label1184,
            this.lifeInsDedAmt2Text,
            this.Label1185,
            this.Label1186,
            this.housingObtDedAmt2Text,
            this.Label1188,
            this.Label1189,
            this.Label1190,
            this.sposSumIncmAmt2Text,
            this.Label1191,
            this.Label1192,
            this.lifeInsPensAmt2Text,
            this.Label1193,
            this.nolfInsLongProdAmt2Text,
            this.Label1213,
            this.Label1214,
            this.Label1215,
            this.Label1216,
            this.Label1217,
            this.Label1218,
            this.Label1219,
            this.empName2Text,
            this.Label1220,
            this.minrType2Text,
            this.latter2Text,
            this.extHandiType2Text,
            this.HandiType2Text,
            this.widowType2Text,
            this.extWidowType2Text,
            this.widomType2Text,
            this.wrkStdType2Text,
            this.Label1221,
            this.Label1222,
            this.Label1223,
            this.paymntAddress2Text,
            this.paymntName2Text,
            this.Label1224,
            this.paymntPhone2Text,
            this.Label1225,
            this.Label1226,
            this.Label1228,
            this.Label1229,
            this.Label1230,
            this.Label1231,
            this.Label1232,
            this.Label1233,
            this.Label1234,
            this.Label1235,
            this.Label1236,
            this.Label1237,
            this.Label1238,
            this.nolfInsDedAmt2Text,
            this.Label1239,
            this.deathRetireType2Text,
            this.disasterType2Text,
            this.foreignType2Text,
            this.halfEmployType2Text,
            this.Label1261,
            this.halfRetireType2Text,
            this.halrEmReDateYear2Text,
            this.halfEmReDateMonth2Text,
            this.halfEmReDateDay2Text,
            this.Label1262,
            this.Label1263,
            this.Label1264,
            this.Label1265,
            this.Label1266,
            this.birthNameOfEraM2Text,
            this.birthNameOfErat2Text,
            this.birthNameOfEraS2Text,
            this.birthNameOfEraH2Text,
            this.birthDayYear2Text,
            this.birthDayMonth2Text,
            this.birthDayDay2Text,
            this.socInsDedAmt2Text,
            this.Label1273,
            this.Label1274,
            this.Label1275,
            this.Line473,
            this.Line474,
            this.Line475,
            this.Line476,
            this.Line477,
            this.Line478,
            this.Line481,
            this.Line482,
            this.Line483,
            this.Line484,
            this.Line485,
            this.Line486,
            this.Line487,
            this.Line488,
            this.Line489,
            this.Line490,
            this.Line491,
            this.Line492,
            this.Line493,
            this.Line494,
            this.Line495,
            this.Line496,
            this.Line497,
            this.Line498,
            this.Line499,
            this.Line500,
            this.Line501,
            this.Line502,
            this.Line503,
            this.Line504,
            this.Line505,
            this.Line506,
            this.Line507,
            this.Line508,
            this.Line509,
            this.Line510,
            this.Line511,
            this.Line512,
            this.Line513,
            this.Line514,
            this.Line515,
            this.Line528,
            this.Line529,
            this.Line530,
            this.Line531,
            this.Line532,
            this.Line533,
            this.Line534,
            this.Line535,
            this.Line536,
            this.Line537,
            this.Line538,
            this.Line541,
            this.Line542,
            this.Line616,
            this.Line621,
            this.Line622,
            this.Line625,
            this.Line626,
            this.Line627,
            this.Line628,
            this.Line629,
            this.Line630,
            this.Line631,
            this.Line632,
            this.Line633,
            this.Line634,
            this.Line635,
            this.Line636,
            this.Line637,
            this.Line638,
            this.Line639,
            this.Line640,
            this.Line641,
            this.Line642,
            this.Line643,
            this.Line644,
            this.Label1421,
            this.Label1422,
            this.Label1423,
            this.Label1424,
            this.Label1425,
            this.Line645,
            this.Label1426,
            this.Label1203,
            this.Line646,
            this.Label1427,
            this.Label1428,
            this.ylyEdAddress1_4Text,
            this.Label1429,
            this.empCode3Text,
            this.postName3Text,
            this.empNameKana3Text,
            this.Label1430,
            this.Label1431,
            this.Label1432,
            this.Label1433,
            this.Label1434,
            this.Label1435,
            this.Label1436,
            this.class3Text,
            this.paymntAmt3Text,
            this.Label1438,
            this.slryInsmDedAmt3Text,
            this.Label1439,
            this.incmDedAmtSum3Text,
            this.Label1440,
            this.Label1441,
            this.ylyCollectTax3Text,
            this.Label1442,
            this.Label1443,
            this.Label1444,
            this.Label1445,
            this.Label1446,
            this.Label1447,
            this.Label1448,
            this.Label1449,
            this.sposOldAgeType2_3Text,
            this.dedSposexet3Text,
            this.dedSposN1_3Text,
            this.dedSposExist2_3Text,
            this.dedSposN2_3Text,
            this.Label1450,
            this.Label1451,
            this.sposExtDedAmt3Text,
            this.Label1452,
            this.Label1453,
            this.Label1454,
            this.Label1455,
            this.Label1456,
            this.Label1457,
            this.specDpndNum1_4Text,
            this.specDpndNum2_4Text,
            this.Label1458,
            this.Label1459,
            this.liveTgtAgePreNum3Text,
            this.Label1460,
            this.agePreNum1_3Text,
            this.agePreNum2_3Text,
            this.Label1461,
            this.Label1462,
            this.othersDpndNum1_3Text,
            this.Label1463,
            this.othersDpndNum2_3Text,
            this.Label1464,
            this.Label1465,
            this.liveTgtExtHandiNum1_3Text,
            this.extHandiNum3Text,
            this.Label1466,
            this.Label1467,
            this.Label1468,
            this.Label1469,
            this.Label1470,
            this.HandiNum3Text,
            this.Label1471,
            this.Label1472,
            this.smlScaleCompCpratAmt3Text,
            this.Label1473,
            this.Label1474,
            this.lifeInsDedAmt3Text,
            this.Label1475,
            this.Label1476,
            this.housingObtDedAmt3Text,
            this.summary0Digit3Text,
            this.Label1478,
            this.Label1479,
            this.Label1480,
            this.sposSumIncmAmt3Text,
            this.Label1481,
            this.Label1482,
            this.lifeInsPensAmt3Text,
            this.Label1483,
            this.nolfInsLongProdAmt3Text,
            this.Label1502,
            this.Label1503,
            this.Label1504,
            this.Label1505,
            this.Label1506,
            this.Label1507,
            this.Label1508,
            this.TempName3Text,
            this.Label1509,
            this.minrType3Text,
            this.latter3Text,
            this.extHandiType3Text,
            this.HandiType3Text,
            this.widowType3Text,
            this.extWidowType3Text,
            this.widomType3Text,
            this.wrkStdType3Text,
            this.Label1510,
            this.Label1511,
            this.Label1512,
            this.paymntAddress3Text,
            this.paymntName3Text,
            this.Label1513,
            this.paymntPhone3Text,
            this.Label1514,
            this.Label1515,
            this.Label1517,
            this.Label1518,
            this.Label1519,
            this.Label1520,
            this.Label1521,
            this.Label1522,
            this.Label1523,
            this.Label1524,
            this.Label1525,
            this.Label1526,
            this.Label1527,
            this.nolfInsDedAmt3Text,
            this.Label1528,
            this.deathRetireType3Text,
            this.disasterType3Text,
            this.foreignType3Text,
            this.halfEmployType3Text,
            this.Label1550,
            this.halfRetireType3Text,
            this.halrEmReDateYear3Text,
            this.halfEmReDateMonth3Text,
            this.halfEmReDateDay3Text,
            this.Label1551,
            this.Label1552,
            this.Label1553,
            this.Label1554,
            this.Label1555,
            this.birthNameOfEraM3Text,
            this.birthNameOfErat3Text,
            this.birthNameOfEraS3Text,
            this.birthNameOfEraH3Text,
            this.birthDayYear3Text,
            this.birthDayMonth3Text,
            this.birthDayDay3Text,
            this.socInsDedAmt3Text,
            this.Label1562,
            this.Label1563,
            this.Label1564,
            this.Line649,
            this.Line650,
            this.Line651,
            this.Line652,
            this.Line653,
            this.Line655,
            this.Line656,
            this.Line657,
            this.Line658,
            this.Line659,
            this.Line660,
            this.Line661,
            this.Line662,
            this.Line663,
            this.Line664,
            this.Line665,
            this.Line666,
            this.Line667,
            this.Line668,
            this.Line669,
            this.Line670,
            this.Line671,
            this.Line672,
            this.Line673,
            this.Line674,
            this.Line675,
            this.Line676,
            this.Line677,
            this.Line678,
            this.Line679,
            this.Line680,
            this.Line681,
            this.Line682,
            this.Line683,
            this.Line684,
            this.Line685,
            this.Line686,
            this.Line687,
            this.Line688,
            this.Line689,
            this.Line690,
            this.Line703,
            this.Line704,
            this.Line705,
            this.Line706,
            this.Line707,
            this.Line708,
            this.Line709,
            this.Line710,
            this.Line711,
            this.Line712,
            this.Line713,
            this.Line716,
            this.Line717,
            this.Line718,
            this.Line719,
            this.Line720,
            this.Line721,
            this.Line722,
            this.Line723,
            this.Line724,
            this.Line725,
            this.Line726,
            this.Line727,
            this.Line728,
            this.Line729,
            this.Line730,
            this.Line731,
            this.Line732,
            this.Line733,
            this.Line734,
            this.Line735,
            this.Line736,
            this.Line737,
            this.Line738,
            this.Line739,
            this.Line740,
            this.Label1567,
            this.Label1568,
            this.Label1569,
            this.Label1570,
            this.Label1571,
            this.Line741,
            this.Label1572,
            this.Label1573,
            this.Line742,
            this.Label1579,
            this.Label1580,
            this.Label1581,
            this.Label1582,
            this.Label1583,
            this.Label1589,
            this.Label1590,
            this.Label1591,
            this.Label1592,
            this.Label1593,
            this.Label1594,
            this.Label1597,
            this.Label1598,
            this.Line754,
            this.Line755,
            this.YlyEdCalYear5Text,
            this.YlyEdCalYear6Text,
            this.Label1599,
            this.YlyEdCalYear8Text,
            this.YlyEdCalYear7Text,
            this.Line756,
            this.Line757,
            this.summary2Digit2Text,
            this.summary2Digit3Text,
            this.summary0Digit2Text,
            this.label28,
            this.label34,
            this.label36,
            this.label43,
            this.label45,
            this.label46,
            this.line17,
            this.line18,
            this.line19,
            this.line20,
            this.line23,
            this.line24,
            this.line25,
            this.line26,
            this.line27,
            this.label60,
            this.label61,
            this.label62,
            this.label66,
            this.label68,
            this.label70,
            this.label71,
            this.label75,
            this.label76,
            this.line28,
            this.line29,
            this.line30,
            this.line31,
            this.line32,
            this.line36,
            this.line39,
            this.Line647,
            this.line21,
            this.line38,
            this.line37,
            this.Line654,
            this.line33,
            this.line34,
            this.line35,
            this.line22,
            this.label47,
            this.YoungDpndNum2Text,
            this.Line463,
            this.Line479,
            this.line16,
            this.Line480,
            this.Line648,
            this.label1,
            this.line1,
            this.label2,
            this.newLifeInsPensAmt2Text,
            this.newLifeInsCareAmt2Text,
            this.label3,
            this.label4,
            this.line2,
            this.label5,
            this.label6,
            this.newLifeInsGeneralAmt2Text,
            this.lifeInsGeneralAmt2Text,
            this.line3,
            this.label7,
            this.label8,
            this.line4,
            this.summary1Digit2Text,
            this.label9,
            this.line5,
            this.newLifeInsPensAmt3Text,
            this.newLifeInsCareAmt3Text,
            this.label10,
            this.label11,
            this.line6,
            this.label12,
            this.label13,
            this.label14,
            this.newLifeInsGeneralAmt3Text,
            this.lifeInsGeneralAmt3Text,
            this.line7,
            this.label15,
            this.label16,
            this.line8});
			this.Detail.Height = 7.958333F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// summary1Digit3Text
			// 
			this.summary1Digit3Text.CanGrow = false;
			this.summary1Digit3Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit3Text.Height = 0.558F;
			this.summary1Digit3Text.Left = 0.406F;
			this.summary1Digit3Text.Name = "summary1Digit3Text";
			this.summary1Digit3Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit3Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary1Digit3Text.Top = 6.17F;
			this.summary1Digit3Text.Width = 2.173F;
			// 
			// label41
			// 
			this.label41.Height = 0.21F;
			this.label41.HyperLink = null;
			this.label41.Left = 2.125F;
			this.label41.Name = "label41";
			this.label41.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label41.Text = "一般";
			this.label41.Top = 2.712F;
			this.label41.Width = 0.1250001F;
			// 
			// label78
			// 
			this.label78.Height = 0.35F;
			this.label78.HyperLink = null;
			this.label78.Left = 0.49F;
			this.label78.Name = "label78";
			this.label78.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label78.Text = "16歳未満";
			this.label78.Top = 6.702F;
			this.label78.Width = 0.105F;
			// 
			// label57
			// 
			this.label57.Height = 0.35F;
			this.label57.HyperLink = null;
			this.label57.Left = 0.386F;
			this.label57.Name = "label57";
			this.label57.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label57.Text = "扶養親族";
			this.label57.Top = 6.702F;
			this.label57.Width = 0.105F;
			// 
			// label56
			// 
			this.label56.Height = 0.35F;
			this.label56.HyperLink = null;
			this.label56.Left = 2.729F;
			this.label56.Name = "label56";
			this.label56.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label56.Text = "勤労学生";
			this.label56.Top = 2.598F;
			this.label56.Width = 0.125F;
			// 
			// label55
			// 
			this.label55.Height = 0.35F;
			this.label55.HyperLink = null;
			this.label55.Left = 1.094F;
			this.label55.Name = "label55";
			this.label55.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label55.Text = "死亡退職";
			this.label55.Top = 2.598F;
			this.label55.Width = 0.125F;
			// 
			// label72
			// 
			this.label72.Height = 0.35F;
			this.label72.HyperLink = null;
			this.label72.Left = 2.729F;
			this.label72.Name = "label72";
			this.label72.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label72.Text = "勤労学生";
			this.label72.Top = 6.702F;
			this.label72.Width = 0.125F;
			// 
			// label80
			// 
			this.label80.Height = 0.35F;
			this.label80.HyperLink = null;
			this.label80.Left = 1.094F;
			this.label80.Name = "label80";
			this.label80.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label80.Text = "死亡退職";
			this.label80.Top = 6.702F;
			this.label80.Width = 0.125F;
			// 
			// label77
			// 
			this.label77.Height = 0.35F;
			this.label77.HyperLink = null;
			this.label77.Left = 0.657F;
			this.label77.Name = "label77";
			this.label77.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label77.Text = "未成年者";
			this.label77.Top = 6.702F;
			this.label77.Width = 0.125F;
			// 
			// label81
			// 
			this.label81.Height = 0.125F;
			this.label81.HyperLink = null;
			this.label81.Left = 0.49F;
			this.label81.Name = "label81";
			this.label81.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label81.Text = "人";
			this.label81.Top = 7.035F;
			this.label81.Width = 0.125F;
			// 
			// YoungDpndNum3Text
			// 
			this.YoungDpndNum3Text.CanGrow = false;
			this.YoungDpndNum3Text.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNum3Text.Height = 0.1250001F;
			this.YoungDpndNum3Text.Left = 0.386F;
			this.YoungDpndNum3Text.Name = "YoungDpndNum3Text";
			this.YoungDpndNum3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNum3Text.Text = "Z6";
			this.YoungDpndNum3Text.Top = 7.087F;
			this.YoungDpndNum3Text.Width = 0.1249998F;
			// 
			// label65
			// 
			this.label65.Height = 0.09F;
			this.label65.HyperLink = null;
			this.label65.Left = 2.125F;
			this.label65.Name = "label65";
			this.label65.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label65.Text = "寡　 婦";
			this.label65.Top = 6.712F;
			this.label65.Width = 0.3F;
			// 
			// label63
			// 
			this.label63.Height = 0.21F;
			this.label63.HyperLink = null;
			this.label63.Left = 1.729F;
			this.label63.Name = "label63";
			this.label63.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label63.Text = "特別";
			this.label63.Top = 6.816F;
			this.label63.Width = 0.1249999F;
			// 
			// label79
			// 
			this.label79.Height = 0.2499999F;
			this.label79.HyperLink = null;
			this.label79.Left = 1.917F;
			this.label79.Name = "label79";
			this.label79.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label79.Text = "その他";
			this.label79.Top = 6.795F;
			this.label79.Width = 0.125F;
			// 
			// label50
			// 
			this.label50.Height = 0.29F;
			this.label50.HyperLink = null;
			this.label50.Left = 1.307F;
			this.label50.Name = "label50";
			this.label50.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label50.Text = "災害者";
			this.label50.Top = 2.628F;
			this.label50.Width = 0.135F;
			// 
			// label52
			// 
			this.label52.Height = 0.35F;
			this.label52.HyperLink = null;
			this.label52.Left = 0.646F;
			this.label52.Name = "label52";
			this.label52.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label52.Text = "未成年者";
			this.label52.Top = 2.598F;
			this.label52.Width = 0.125F;
			// 
			// label24
			// 
			this.label24.Height = 0.35F;
			this.label24.HyperLink = null;
			this.label24.Left = 0.386F;
			this.label24.Name = "label24";
			this.label24.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label24.Text = "扶養親族";
			this.label24.Top = 2.598F;
			this.label24.Width = 0.105F;
			// 
			// label53
			// 
			this.label53.Height = 0.35F;
			this.label53.HyperLink = null;
			this.label53.Left = 0.49F;
			this.label53.Name = "label53";
			this.label53.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label53.Text = "16歳未満";
			this.label53.Top = 2.598F;
			this.label53.Width = 0.105F;
			// 
			// label51
			// 
			this.label51.Height = 0.29F;
			this.label51.HyperLink = null;
			this.label51.Left = 0.865F;
			this.label51.Name = "label51";
			this.label51.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.label51.Text = "外国人";
			this.label51.Top = 2.628F;
			this.label51.Width = 0.135F;
			// 
			// label35
			// 
			this.label35.Height = 0.09F;
			this.label35.HyperLink = null;
			this.label35.Left = 1.698F;
			this.label35.Name = "label35";
			this.label35.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label35.Text = "本人が障害者";
			this.label35.Top = 2.598F;
			this.label35.Width = 0.394F;
			// 
			// label54
			// 
			this.label54.Height = 0.2499999F;
			this.label54.HyperLink = null;
			this.label54.Left = 1.927F;
			this.label54.Name = "label54";
			this.label54.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label54.Text = "その他";
			this.label54.Top = 2.691F;
			this.label54.Width = 0.125F;
			// 
			// label38
			// 
			this.label38.Height = 0.09F;
			this.label38.HyperLink = null;
			this.label38.Left = 2.136F;
			this.label38.Name = "label38";
			this.label38.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label38.Text = "寡　 婦";
			this.label38.Top = 2.598F;
			this.label38.Width = 0.3F;
			// 
			// Label1137
			// 
			this.Label1137.Height = 0.208F;
			this.Label1137.HyperLink = null;
			this.Label1137.Left = 0.3862205F;
			this.Label1137.Name = "Label1137";
			this.Label1137.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1137.Text = "支払";
			this.Label1137.Top = 0.2084449F;
			this.Label1137.Width = 0.292F;
			// 
			// Label1138
			// 
			this.Label1138.Height = 0.235F;
			this.Label1138.HyperLink = null;
			this.Label1138.Left = 0.6787205F;
			this.Label1138.Name = "Label1138";
			this.Label1138.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1138.Text = "住";
			this.Label1138.Top = 0.3649449F;
			this.Label1138.Width = 0.188F;
			// 
			// ylyEdAddress1_3Text
			// 
			this.ylyEdAddress1_3Text.CanGrow = false;
			this.ylyEdAddress1_3Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_3Text.Height = 0.4685F;
			this.ylyEdAddress1_3Text.Left = 0.8667202F;
			this.ylyEdAddress1_3Text.Name = "ylyEdAddress1_3Text";
			this.ylyEdAddress1_3Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_3Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_3Text.Top = 0.3649449F;
			this.ylyEdAddress1_3Text.Width = 2.349F;
			// 
			// Label1139
			// 
			this.Label1139.Height = 0.313F;
			this.Label1139.HyperLink = null;
			this.Label1139.Left = 3.21522F;
			this.Label1139.Name = "Label1139";
			this.Label1139.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1139.Text = "氏";
			this.Label1139.Top = 0.2084449F;
			this.Label1139.Width = 0.19F;
			// 
			// empCode2Text
			// 
			this.empCode2Text.CanGrow = false;
			this.empCode2Text.DataField = "EMP_CODE";
			this.empCode2Text.Height = 0.156F;
			this.empCode2Text.Left = 3.95422F;
			this.empCode2Text.Name = "empCode2Text";
			this.empCode2Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empCode2Text.Text = "0000000000";
			this.empCode2Text.Top = 0.2084449F;
			this.empCode2Text.Width = 1.619001F;
			// 
			// postName2Text
			// 
			this.postName2Text.CanGrow = false;
			this.postName2Text.DataField = "POST_NAME";
			this.postName2Text.Height = 0.156F;
			this.postName2Text.Left = 3.95422F;
			this.postName2Text.Name = "postName2Text";
			this.postName2Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.postName2Text.Text = "ああああああああああ";
			this.postName2Text.Top = 0.5214451F;
			this.postName2Text.Width = 1.619001F;
			// 
			// empNameKana2Text
			// 
			this.empNameKana2Text.CanGrow = false;
			this.empNameKana2Text.DataField = "EMP_REGIST_NAME_KANA";
			this.empNameKana2Text.Height = 0.156F;
			this.empNameKana2Text.Left = 3.95422F;
			this.empNameKana2Text.Name = "empNameKana2Text";
			this.empNameKana2Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameKana2Text.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.empNameKana2Text.Top = 0.364445F;
			this.empNameKana2Text.Width = 1.619001F;
			// 
			// Label1140
			// 
			this.Label1140.Height = 0.156F;
			this.Label1140.HyperLink = null;
			this.Label1140.Left = 3.40522F;
			this.Label1140.Name = "Label1140";
			this.Label1140.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1140.Text = "(受給者番号）";
			this.Label1140.Top = 0.2084449F;
			this.Label1140.Width = 0.6055002F;
			// 
			// Label1141
			// 
			this.Label1141.Height = 0.156F;
			this.Label1141.HyperLink = null;
			this.Label1141.Left = 3.40522F;
			this.Label1141.Name = "Label1141";
			this.Label1141.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1141.Text = "(フリガナ）";
			this.Label1141.Top = 0.364445F;
			this.Label1141.Width = 0.5430002F;
			// 
			// Label1142
			// 
			this.Label1142.Height = 0.156F;
			this.Label1142.HyperLink = null;
			this.Label1142.Left = 3.40522F;
			this.Label1142.Name = "Label1142";
			this.Label1142.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1142.Text = "(役職名）";
			this.Label1142.Top = 0.5204446F;
			this.Label1142.Width = 0.5430002F;
			// 
			// Label1143
			// 
			this.Label1143.Height = 0.173F;
			this.Label1143.HyperLink = null;
			this.Label1143.Left = 0.3857203F;
			this.Label1143.Name = "Label1143";
			this.Label1143.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1143.Text = "種　　別";
			this.Label1143.Top = 0.8334449F;
			this.Label1143.Width = 0.938F;
			// 
			// Label1144
			// 
			this.Label1144.Height = 0.173F;
			this.Label1144.HyperLink = null;
			this.Label1144.Left = 1.324219F;
			this.Label1144.Name = "Label1144";
			this.Label1144.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1144.Text = "支　払　金　額";
			this.Label1144.Top = 0.8334449F;
			this.Label1144.Width = 1.078F;
			// 
			// Label1145
			// 
			this.Label1145.Height = 0.173F;
			this.Label1145.HyperLink = null;
			this.Label1145.Left = 2.402221F;
			this.Label1145.Name = "Label1145";
			this.Label1145.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1145.Text = " 給与所得控除後の金額";
			this.Label1145.Top = 0.8334449F;
			this.Label1145.Width = 1.063F;
			// 
			// Label1146
			// 
			this.Label1146.Height = 0.173F;
			this.Label1146.HyperLink = null;
			this.Label1146.Left = 3.46522F;
			this.Label1146.Name = "Label1146";
			this.Label1146.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1146.Text = "所得控除の額の合計額";
			this.Label1146.Top = 0.8334449F;
			this.Label1146.Width = 1.063F;
			// 
			// class2Text
			// 
			this.class2Text.CanGrow = false;
			this.class2Text.DataField = "CLASS";
			this.class2Text.Height = 0.328F;
			this.class2Text.Left = 0.3862205F;
			this.class2Text.Name = "class2Text";
			this.class2Text.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.class2Text.Text = "ああああああ";
			this.class2Text.Top = 1.006445F;
			this.class2Text.Width = 0.937F;
			// 
			// paymntAmt2Text
			// 
			this.paymntAmt2Text.CanGrow = false;
			this.paymntAmt2Text.DataField = "PAYMNT_AMT";
			this.paymntAmt2Text.Height = 0.328F;
			this.paymntAmt2Text.Left = 1.42322F;
			this.paymntAmt2Text.Name = "paymntAmt2Text";
			this.paymntAmt2Text.OutputFormat = "#,##0";
			this.paymntAmt2Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.paymntAmt2Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.paymntAmt2Text.Top = 1.006445F;
			this.paymntAmt2Text.Width = 0.838F;
			// 
			// Label1147
			// 
			this.Label1147.Height = 0.125F;
			this.Label1147.HyperLink = null;
			this.Label1147.Left = 1.32322F;
			this.Label1147.Name = "Label1147";
			this.Label1147.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1147.Text = "内";
			this.Label1147.Top = 1.006445F;
			this.Label1147.Width = 0.1F;
			// 
			// Label1148
			// 
			this.Label1148.Height = 0.125F;
			this.Label1148.HyperLink = null;
			this.Label1148.Left = 2.26122F;
			this.Label1148.Name = "Label1148";
			this.Label1148.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1148.Text = "円";
			this.Label1148.Top = 1.006445F;
			this.Label1148.Width = 0.141F;
			// 
			// slryInsmDedAmt2Text
			// 
			this.slryInsmDedAmt2Text.CanGrow = false;
			this.slryInsmDedAmt2Text.DataField = "SLRY_INSM_DED_AMT";
			this.slryInsmDedAmt2Text.Height = 0.328F;
			this.slryInsmDedAmt2Text.Left = 2.402221F;
			this.slryInsmDedAmt2Text.Name = "slryInsmDedAmt2Text";
			this.slryInsmDedAmt2Text.OutputFormat = "#,##0";
			this.slryInsmDedAmt2Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.slryInsmDedAmt2Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.slryInsmDedAmt2Text.Top = 1.006445F;
			this.slryInsmDedAmt2Text.Width = 0.938F;
			// 
			// Label1149
			// 
			this.Label1149.Height = 0.125F;
			this.Label1149.HyperLink = null;
			this.Label1149.Left = 3.34022F;
			this.Label1149.Name = "Label1149";
			this.Label1149.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1149.Text = "円";
			this.Label1149.Top = 1.006445F;
			this.Label1149.Width = 0.1245001F;
			// 
			// incmDedAmtSum2Text
			// 
			this.incmDedAmtSum2Text.CanGrow = false;
			this.incmDedAmtSum2Text.DataField = "INCM_DED_AMT_SUM";
			this.incmDedAmtSum2Text.Height = 0.328F;
			this.incmDedAmtSum2Text.Left = 3.46522F;
			this.incmDedAmtSum2Text.Name = "incmDedAmtSum2Text";
			this.incmDedAmtSum2Text.OutputFormat = "#,##0";
			this.incmDedAmtSum2Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmDedAmtSum2Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.incmDedAmtSum2Text.Top = 1.006445F;
			this.incmDedAmtSum2Text.Width = 0.938F;
			// 
			// Label1150
			// 
			this.Label1150.Height = 0.125F;
			this.Label1150.HyperLink = null;
			this.Label1150.Left = 4.40322F;
			this.Label1150.Name = "Label1150";
			this.Label1150.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1150.Text = "円";
			this.Label1150.Top = 1.006445F;
			this.Label1150.Width = 0.125F;
			// 
			// Label1151
			// 
			this.Label1151.Height = 0.125F;
			this.Label1151.HyperLink = null;
			this.Label1151.Left = 4.52822F;
			this.Label1151.Name = "Label1151";
			this.Label1151.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1151.Text = "内";
			this.Label1151.Top = 1.006445F;
			this.Label1151.Width = 0.125F;
			// 
			// ylyCollectTax2Text
			// 
			this.ylyCollectTax2Text.CanGrow = false;
			this.ylyCollectTax2Text.DataField = "YLY_COLLECT_TAX";
			this.ylyCollectTax2Text.Height = 0.328F;
			this.ylyCollectTax2Text.Left = 4.636721F;
			this.ylyCollectTax2Text.Name = "ylyCollectTax2Text";
			this.ylyCollectTax2Text.OutputFormat = "#,##0";
			this.ylyCollectTax2Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ylyCollectTax2Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.ylyCollectTax2Text.Top = 1.006945F;
			this.ylyCollectTax2Text.Width = 0.816F;
			// 
			// Label1152
			// 
			this.Label1152.Height = 0.125F;
			this.Label1152.HyperLink = null;
			this.Label1152.Left = 5.43422F;
			this.Label1152.Name = "Label1152";
			this.Label1152.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1152.Text = "円";
			this.Label1152.Top = 1.006445F;
			this.Label1152.Width = 0.134F;
			// 
			// Label1153
			// 
			this.Label1153.Height = 0.173F;
			this.Label1153.HyperLink = null;
			this.Label1153.Left = 4.52822F;
			this.Label1153.Name = "Label1153";
			this.Label1153.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1153.Text = "源　泉　徴　収　税　額";
			this.Label1153.Top = 0.8334449F;
			this.Label1153.Width = 1.04F;
			// 
			// Label1154
			// 
			this.Label1154.Height = 0.157F;
			this.Label1154.HyperLink = null;
			this.Label1154.Left = 0.3862205F;
			this.Label1154.Name = "Label1154";
			this.Label1154.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1154.Text = "控除対象配偶";
			this.Label1154.Top = 1.334445F;
			this.Label1154.Width = 0.5F;
			// 
			// Label1155
			// 
			this.Label1155.Height = 0.345F;
			this.Label1155.HyperLink = null;
			this.Label1155.Left = 0.7862201F;
			this.Label1155.Name = "Label1155";
			this.Label1155.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1155.Text = "老人";
			this.Label1155.Top = 1.475945F;
			this.Label1155.Width = 0.1F;
			// 
			// Label1156
			// 
			this.Label1156.Height = 0.1875F;
			this.Label1156.HyperLink = null;
			this.Label1156.Left = 0.3862205F;
			this.Label1156.Name = "Label1156";
			this.Label1156.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1156.Text = "有";
			this.Label1156.Top = 1.648445F;
			this.Label1156.Width = 0.1F;
			// 
			// Label1157
			// 
			this.Label1157.Height = 0.188F;
			this.Label1157.HyperLink = null;
			this.Label1157.Left = 0.4862204F;
			this.Label1157.Name = "Label1157";
			this.Label1157.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1157.Text = "無";
			this.Label1157.Top = 1.648445F;
			this.Label1157.Width = 0.1F;
			// 
			// Label1158
			// 
			this.Label1158.Height = 0.188F;
			this.Label1158.HyperLink = null;
			this.Label1158.Left = 0.5867205F;
			this.Label1158.Name = "Label1158";
			this.Label1158.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1158.Text = "従有";
			this.Label1158.Top = 1.646362F;
			this.Label1158.Width = 0.1F;
			// 
			// Label1159
			// 
			this.Label1159.Height = 0.188F;
			this.Label1159.HyperLink = null;
			this.Label1159.Left = 0.6867204F;
			this.Label1159.Name = "Label1159";
			this.Label1159.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1159.Text = "従無";
			this.Label1159.Top = 1.646362F;
			this.Label1159.Width = 0.1F;
			// 
			// sposOldAgeType2_2Text
			// 
			this.sposOldAgeType2_2Text.CanGrow = false;
			this.sposOldAgeType2_2Text.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeType2_2Text.Height = 0.155F;
			this.sposOldAgeType2_2Text.Left = 0.7862201F;
			this.sposOldAgeType2_2Text.Name = "sposOldAgeType2_2Text";
			this.sposOldAgeType2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeType2_2Text.Text = "0";
			this.sposOldAgeType2_2Text.Top = 1.836445F;
			this.sposOldAgeType2_2Text.Width = 0.1F;
			// 
			// dedSposexet2Text
			// 
			this.dedSposexet2Text.CanGrow = false;
			this.dedSposexet2Text.DataField = "DED_SPOS_EXIST";
			this.dedSposexet2Text.Height = 0.155F;
			this.dedSposexet2Text.Left = 0.3862205F;
			this.dedSposexet2Text.Name = "dedSposexet2Text";
			this.dedSposexet2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposexet2Text.Text = "0";
			this.dedSposexet2Text.Top = 1.836445F;
			this.dedSposexet2Text.Width = 0.1F;
			// 
			// dedSposN1_2Text
			// 
			this.dedSposN1_2Text.CanGrow = false;
			this.dedSposN1_2Text.DataField = "DED_SPOS_N";
			this.dedSposN1_2Text.Height = 0.155F;
			this.dedSposN1_2Text.Left = 0.4862204F;
			this.dedSposN1_2Text.Name = "dedSposN1_2Text";
			this.dedSposN1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN1_2Text.Text = "0";
			this.dedSposN1_2Text.Top = 1.836445F;
			this.dedSposN1_2Text.Width = 0.1F;
			// 
			// dedSposExist2_2Text
			// 
			this.dedSposExist2_2Text.CanGrow = false;
			this.dedSposExist2_2Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExist2_2Text.Height = 0.155F;
			this.dedSposExist2_2Text.Left = 0.5862203F;
			this.dedSposExist2_2Text.Name = "dedSposExist2_2Text";
			this.dedSposExist2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExist2_2Text.Text = "0";
			this.dedSposExist2_2Text.Top = 1.836445F;
			this.dedSposExist2_2Text.Width = 0.1F;
			// 
			// dedSposN2_2Text
			// 
			this.dedSposN2_2Text.CanGrow = false;
			this.dedSposN2_2Text.DataField = "DED_SPOS_N2";
			this.dedSposN2_2Text.Height = 0.155F;
			this.dedSposN2_2Text.Left = 0.6862202F;
			this.dedSposN2_2Text.Name = "dedSposN2_2Text";
			this.dedSposN2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN2_2Text.Text = "0";
			this.dedSposN2_2Text.Top = 1.836445F;
			this.dedSposN2_2Text.Width = 0.1F;
			// 
			// Label1160
			// 
			this.Label1160.Height = 0.157F;
			this.Label1160.HyperLink = null;
			this.Label1160.Left = 0.8872204F;
			this.Label1160.Name = "Label1160";
			this.Label1160.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1160.Text = "配偶者特別";
			this.Label1160.Top = 1.334445F;
			this.Label1160.Width = 0.593F;
			// 
			// Label1161
			// 
			this.Label1161.Height = 0.125F;
			this.Label1161.HyperLink = null;
			this.Label1161.Left = 1.38622F;
			this.Label1161.Name = "Label1161";
			this.Label1161.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1161.Text = "円";
			this.Label1161.Top = 1.648445F;
			this.Label1161.Width = 0.1F;
			// 
			// sposExtDedAmt2Text
			// 
			this.sposExtDedAmt2Text.CanGrow = false;
			this.sposExtDedAmt2Text.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmt2Text.Height = 0.343F;
			this.sposExtDedAmt2Text.Left = 0.8862205F;
			this.sposExtDedAmt2Text.Name = "sposExtDedAmt2Text";
			this.sposExtDedAmt2Text.OutputFormat = "#,##0";
			this.sposExtDedAmt2Text.Style = "font-size: 5.8pt; text-align: right; vertical-align: bottom; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposExtDedAmt2Text.Text = "Z,ZZ6,ZZ6";
			this.sposExtDedAmt2Text.Top = 1.648445F;
			this.sposExtDedAmt2Text.Width = 0.5620003F;
			// 
			// Label1162
			// 
			this.Label1162.Height = 0.104F;
			this.Label1162.HyperLink = null;
			this.Label1162.Left = 1.48022F;
			this.Label1162.Name = "Label1162";
			this.Label1162.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1162.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.Label1162.Top = 1.334445F;
			this.Label1162.Width = 1.317F;
			// 
			// Label1163
			// 
			this.Label1163.Height = 0.104F;
			this.Label1163.HyperLink = null;
			this.Label1163.Left = 1.48022F;
			this.Label1163.Name = "Label1163";
			this.Label1163.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1163.Text = "     　　（配偶者を除く）";
			this.Label1163.Top = 1.438445F;
			this.Label1163.Width = 1.317F;
			// 
			// Label1164
			// 
			this.Label1164.Height = 0.105F;
			this.Label1164.HyperLink = null;
			this.Label1164.Left = 1.48022F;
			this.Label1164.Name = "Label1164";
			this.Label1164.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1164.Text = "特　定";
			this.Label1164.Top = 1.542445F;
			this.Label1164.Width = 0.386F;
			// 
			// Label1165
			// 
			this.Label1165.Height = 0.105F;
			this.Label1165.HyperLink = null;
			this.Label1165.Left = 1.86622F;
			this.Label1165.Name = "Label1165";
			this.Label1165.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1165.Text = "老　人";
			this.Label1165.Top = 1.542445F;
			this.Label1165.Width = 0.547F;
			// 
			// Label1166
			// 
			this.Label1166.Height = 0.105F;
			this.Label1166.HyperLink = null;
			this.Label1166.Left = 2.41322F;
			this.Label1166.Name = "Label1166";
			this.Label1166.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1166.Text = "その他";
			this.Label1166.Top = 1.542445F;
			this.Label1166.Width = 0.38F;
			// 
			// Label1167
			// 
			this.Label1167.Height = 0.125F;
			this.Label1167.HyperLink = null;
			this.Label1167.Left = 1.54922F;
			this.Label1167.Name = "Label1167";
			this.Label1167.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1167.Text = "人";
			this.Label1167.Top = 1.648445F;
			this.Label1167.Width = 0.099F;
			// 
			// specDpndNum1_3Text
			// 
			this.specDpndNum1_3Text.CanGrow = false;
			this.specDpndNum1_3Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_3Text.Height = 0.343F;
			this.specDpndNum1_3Text.Left = 1.51072F;
			this.specDpndNum1_3Text.Name = "specDpndNum1_3Text";
			this.specDpndNum1_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_3Text.Text = "Z6";
			this.specDpndNum1_3Text.Top = 1.648445F;
			this.specDpndNum1_3Text.Width = 0.125F;
			// 
			// specDpndNum2_3Text
			// 
			this.specDpndNum2_3Text.CanGrow = false;
			this.specDpndNum2_3Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_3Text.Height = 0.343F;
			this.specDpndNum2_3Text.Left = 1.66822F;
			this.specDpndNum2_3Text.Name = "specDpndNum2_3Text";
			this.specDpndNum2_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum2_3Text.Text = "Z6";
			this.specDpndNum2_3Text.Top = 1.648445F;
			this.specDpndNum2_3Text.Width = 0.1550002F;
			// 
			// Label1168
			// 
			this.Label1168.Height = 0.125F;
			this.Label1168.HyperLink = null;
			this.Label1168.Left = 1.66822F;
			this.Label1168.Name = "Label1168";
			this.Label1168.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1168.Text = "従人";
			this.Label1168.Top = 1.648445F;
			this.Label1168.Width = 0.198F;
			// 
			// Label1169
			// 
			this.Label1169.Height = 0.125F;
			this.Label1169.HyperLink = null;
			this.Label1169.Left = 1.86622F;
			this.Label1169.Name = "Label1169";
			this.Label1169.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1169.Text = "内";
			this.Label1169.Top = 1.648445F;
			this.Label1169.Width = 0.11F;
			// 
			// liveTgtAgePreNum2Text
			// 
			this.liveTgtAgePreNum2Text.CanGrow = false;
			this.liveTgtAgePreNum2Text.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNum2Text.Height = 0.343F;
			this.liveTgtAgePreNum2Text.Left = 1.86672F;
			this.liveTgtAgePreNum2Text.Name = "liveTgtAgePreNum2Text";
			this.liveTgtAgePreNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNum2Text.Text = "Z6";
			this.liveTgtAgePreNum2Text.Top = 1.645945F;
			this.liveTgtAgePreNum2Text.Width = 0.11F;
			// 
			// Label1170
			// 
			this.Label1170.Height = 0.125F;
			this.Label1170.HyperLink = null;
			this.Label1170.Left = 2.07022F;
			this.Label1170.Name = "Label1170";
			this.Label1170.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1170.Text = "人";
			this.Label1170.Top = 1.648445F;
			this.Label1170.Width = 0.125F;
			// 
			// agePreNum1_2Text
			// 
			this.agePreNum1_2Text.CanGrow = false;
			this.agePreNum1_2Text.DataField = "AGE_PRE_NUM";
			this.agePreNum1_2Text.Height = 0.343F;
			this.agePreNum1_2Text.Left = 1.97622F;
			this.agePreNum1_2Text.Name = "agePreNum1_2Text";
			this.agePreNum1_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum1_2Text.Text = "Z6";
			this.agePreNum1_2Text.Top = 1.648445F;
			this.agePreNum1_2Text.Width = 0.1594997F;
			// 
			// agePreNum2_2Text
			// 
			this.agePreNum2_2Text.CanGrow = false;
			this.agePreNum2_2Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2_2Text.Height = 0.343F;
			this.agePreNum2_2Text.Left = 2.19522F;
			this.agePreNum2_2Text.Name = "agePreNum2_2Text";
			this.agePreNum2_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum2_2Text.Text = "Z6";
			this.agePreNum2_2Text.Top = 1.648445F;
			this.agePreNum2_2Text.Width = 0.1905003F;
			// 
			// Label1171
			// 
			this.Label1171.Height = 0.125F;
			this.Label1171.HyperLink = null;
			this.Label1171.Left = 2.19522F;
			this.Label1171.Name = "Label1171";
			this.Label1171.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1171.Text = "従人";
			this.Label1171.Top = 1.648445F;
			this.Label1171.Width = 0.219F;
			// 
			// Label1172
			// 
			this.Label1172.Height = 0.125F;
			this.Label1172.HyperLink = null;
			this.Label1172.Left = 2.480219F;
			this.Label1172.Name = "Label1172";
			this.Label1172.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1172.Text = "人";
			this.Label1172.Top = 1.648445F;
			this.Label1172.Width = 0.125F;
			// 
			// othersDpndNum1_2Text
			// 
			this.othersDpndNum1_2Text.CanGrow = false;
			this.othersDpndNum1_2Text.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNum1_2Text.Height = 0.343F;
			this.othersDpndNum1_2Text.Left = 2.41322F;
			this.othersDpndNum1_2Text.Name = "othersDpndNum1_2Text";
			this.othersDpndNum1_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum1_2Text.Text = "Z6";
			this.othersDpndNum1_2Text.Top = 1.648445F;
			this.othersDpndNum1_2Text.Width = 0.1599999F;
			// 
			// Label1173
			// 
			this.Label1173.Height = 0.125F;
			this.Label1173.HyperLink = null;
			this.Label1173.Left = 2.595721F;
			this.Label1173.Name = "Label1173";
			this.Label1173.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1173.Text = "従人";
			this.Label1173.Top = 1.648945F;
			this.Label1173.Width = 0.2180004F;
			// 
			// othersDpndNum2_2Text
			// 
			this.othersDpndNum2_2Text.CanGrow = false;
			this.othersDpndNum2_2Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2_2Text.Height = 0.343F;
			this.othersDpndNum2_2Text.Left = 2.605219F;
			this.othersDpndNum2_2Text.Name = "othersDpndNum2_2Text";
			this.othersDpndNum2_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum2_2Text.Text = "Z6";
			this.othersDpndNum2_2Text.Top = 1.648445F;
			this.othersDpndNum2_2Text.Width = 0.1555004F;
			// 
			// Label1174
			// 
			this.Label1174.Height = 0.104F;
			this.Label1174.HyperLink = null;
			this.Label1174.Left = 2.797221F;
			this.Label1174.Name = "Label1174";
			this.Label1174.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1174.Text = "障害者の数";
			this.Label1174.Top = 1.334445F;
			this.Label1174.Width = 0.5249999F;
			// 
			// Label1175
			// 
			this.Label1175.Height = 0.105F;
			this.Label1175.HyperLink = null;
			this.Label1175.Left = 2.797221F;
			this.Label1175.Name = "Label1175";
			this.Label1175.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1175.Text = "特 別";
			this.Label1175.Top = 1.542445F;
			this.Label1175.Width = 0.25F;
			// 
			// liveTgtExtHandiNum1_2Text
			// 
			this.liveTgtExtHandiNum1_2Text.CanGrow = false;
			this.liveTgtExtHandiNum1_2Text.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtExtHandiNum1_2Text.Height = 0.343F;
			this.liveTgtExtHandiNum1_2Text.Left = 2.797221F;
			this.liveTgtExtHandiNum1_2Text.Name = "liveTgtExtHandiNum1_2Text";
			this.liveTgtExtHandiNum1_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtExtHandiNum1_2Text.Text = "Z6";
			this.liveTgtExtHandiNum1_2Text.Top = 1.648445F;
			this.liveTgtExtHandiNum1_2Text.Width = 0.125F;
			// 
			// extHandiNum2Text
			// 
			this.extHandiNum2Text.CanGrow = false;
			this.extHandiNum2Text.DataField = "EXT_HANDI_NUM";
			this.extHandiNum2Text.Height = 0.343F;
			this.extHandiNum2Text.Left = 2.922221F;
			this.extHandiNum2Text.Name = "extHandiNum2Text";
			this.extHandiNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHandiNum2Text.Text = "Z6";
			this.extHandiNum2Text.Top = 1.648445F;
			this.extHandiNum2Text.Width = 0.125F;
			// 
			// Label1176
			// 
			this.Label1176.Height = 0.125F;
			this.Label1176.HyperLink = null;
			this.Label1176.Left = 2.922221F;
			this.Label1176.Name = "Label1176";
			this.Label1176.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1176.Text = "人";
			this.Label1176.Top = 1.648445F;
			this.Label1176.Width = 0.125F;
			// 
			// Label1177
			// 
			this.Label1177.Height = 0.125F;
			this.Label1177.HyperLink = null;
			this.Label1177.Left = 2.797221F;
			this.Label1177.Name = "Label1177";
			this.Label1177.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1177.Text = "内";
			this.Label1177.Top = 1.648445F;
			this.Label1177.Width = 0.125F;
			// 
			// Label1178
			// 
			this.Label1178.Height = 0.104F;
			this.Label1178.HyperLink = null;
			this.Label1178.Left = 2.797221F;
			this.Label1178.Name = "Label1178";
			this.Label1178.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1178.Text = "（本人を除く）";
			this.Label1178.Top = 1.438445F;
			this.Label1178.Width = 0.5249999F;
			// 
			// Label1179
			// 
			this.Label1179.Height = 0.105F;
			this.Label1179.HyperLink = null;
			this.Label1179.Left = 3.047221F;
			this.Label1179.Name = "Label1179";
			this.Label1179.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1179.Text = "その他";
			this.Label1179.Top = 1.542445F;
			this.Label1179.Width = 0.275F;
			// 
			// Label1180
			// 
			this.Label1180.Height = 0.125F;
			this.Label1180.HyperLink = null;
			this.Label1180.Left = 3.19722F;
			this.Label1180.Name = "Label1180";
			this.Label1180.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1180.Text = "人";
			this.Label1180.Top = 1.648445F;
			this.Label1180.Width = 0.125F;
			// 
			// HandiNum2Text
			// 
			this.HandiNum2Text.CanGrow = false;
			this.HandiNum2Text.DataField = "HANDI_NUM";
			this.HandiNum2Text.Height = 0.343F;
			this.HandiNum2Text.Left = 3.04772F;
			this.HandiNum2Text.Name = "HandiNum2Text";
			this.HandiNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HandiNum2Text.Text = "Z6";
			this.HandiNum2Text.Top = 1.645945F;
			this.HandiNum2Text.Width = 0.2129994F;
			// 
			// Label1181
			// 
			this.Label1181.Height = 0.156F;
			this.Label1181.HyperLink = null;
			this.Label1181.Left = 3.32222F;
			this.Label1181.Name = "Label1181";
			this.Label1181.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1181.Text = "社会保険料";
			this.Label1181.Top = 1.334445F;
			this.Label1181.Width = 0.532F;
			// 
			// Label1182
			// 
			this.Label1182.Height = 0.125F;
			this.Label1182.HyperLink = null;
			this.Label1182.Left = 3.724221F;
			this.Label1182.Name = "Label1182";
			this.Label1182.Style = "font-size: 6pt; text-align: right; vertical-align: top; ddo-char-set: 1";
			this.Label1182.Text = "円";
			this.Label1182.Top = 1.648445F;
			this.Label1182.Width = 0.125F;
			// 
			// smlScaleCompCpratAmt2Text
			// 
			this.smlScaleCompCpratAmt2Text.CanGrow = false;
			this.smlScaleCompCpratAmt2Text.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.smlScaleCompCpratAmt2Text.Height = 0.24F;
			this.smlScaleCompCpratAmt2Text.Left = 3.32222F;
			this.smlScaleCompCpratAmt2Text.Name = "smlScaleCompCpratAmt2Text";
			this.smlScaleCompCpratAmt2Text.OutputFormat = "#,##0";
			this.smlScaleCompCpratAmt2Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.smlScaleCompCpratAmt2Text.Text = "ZZ,ZZZ,ZZ6";
			this.smlScaleCompCpratAmt2Text.Top = 1.648445F;
			this.smlScaleCompCpratAmt2Text.Width = 0.532F;
			// 
			// Label1183
			// 
			this.Label1183.Height = 0.156F;
			this.Label1183.HyperLink = null;
			this.Label1183.Left = 3.85422F;
			this.Label1183.Name = "Label1183";
			this.Label1183.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1183.Text = "生命保険料";
			this.Label1183.Top = 1.334445F;
			this.Label1183.Width = 0.563F;
			// 
			// Label1184
			// 
			this.Label1184.Height = 0.125F;
			this.Label1184.HyperLink = null;
			this.Label1184.Left = 4.314221F;
			this.Label1184.Name = "Label1184";
			this.Label1184.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1184.Text = "円";
			this.Label1184.Top = 1.648445F;
			this.Label1184.Width = 0.11F;
			// 
			// lifeInsDedAmt2Text
			// 
			this.lifeInsDedAmt2Text.CanGrow = false;
			this.lifeInsDedAmt2Text.DataField = "LIFE_INS_DED_AMT";
			this.lifeInsDedAmt2Text.Height = 0.1875F;
			this.lifeInsDedAmt2Text.Left = 3.854719F;
			this.lifeInsDedAmt2Text.Name = "lifeInsDedAmt2Text";
			this.lifeInsDedAmt2Text.OutputFormat = "#,##0";
			this.lifeInsDedAmt2Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsDedAmt2Text.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsDedAmt2Text.Top = 1.810945F;
			this.lifeInsDedAmt2Text.Width = 0.563F;
			// 
			// Label1185
			// 
			this.Label1185.Height = 0.156F;
			this.Label1185.HyperLink = null;
			this.Label1185.Left = 4.96822F;
			this.Label1185.Name = "Label1185";
			this.Label1185.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1185.Text = "住宅借入金等";
			this.Label1185.Top = 1.334445F;
			this.Label1185.Width = 0.605F;
			// 
			// Label1186
			// 
			this.Label1186.Height = 0.125F;
			this.Label1186.HyperLink = null;
			this.Label1186.Left = 5.43622F;
			this.Label1186.Name = "Label1186";
			this.Label1186.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1186.Text = "円";
			this.Label1186.Top = 1.648445F;
			this.Label1186.Width = 0.1370001F;
			// 
			// housingObtDedAmt2Text
			// 
			this.housingObtDedAmt2Text.CanGrow = false;
			this.housingObtDedAmt2Text.DataField = "HOUSING_OBT_DED_AMT";
			this.housingObtDedAmt2Text.Height = 0.1875F;
			this.housingObtDedAmt2Text.Left = 4.96872F;
			this.housingObtDedAmt2Text.Name = "housingObtDedAmt2Text";
			this.housingObtDedAmt2Text.OutputFormat = "#,##0";
			this.housingObtDedAmt2Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.housingObtDedAmt2Text.Text = "ZZ,ZZZ,ZZ6";
			this.housingObtDedAmt2Text.Top = 1.810945F;
			this.housingObtDedAmt2Text.Width = 0.605F;
			// 
			// Label1188
			// 
			this.Label1188.Height = 0.153F;
			this.Label1188.HyperLink = null;
			this.Label1188.Left = 2.649F;
			this.Label1188.Name = "Label1188";
			this.Label1188.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1188.Text = "配偶者の合計所得";
			this.Label1188.Top = 2.136F;
			this.Label1188.Width = 0.67F;
			// 
			// Label1189
			// 
			this.Label1189.Height = 0.153F;
			this.Label1189.HyperLink = null;
			this.Label1189.Left = 4.081F;
			this.Label1189.Name = "Label1189";
			this.Label1189.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1189.Text = "旧個人年金保険料の金額";
			this.Label1189.Top = 2.299F;
			this.Label1189.Width = 0.755F;
			// 
			// Label1190
			// 
			this.Label1190.Height = 0.153F;
			this.Label1190.HyperLink = null;
			this.Label1190.Left = 4.081F;
			this.Label1190.Name = "Label1190";
			this.Label1190.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1190.Text = "長期損害保険料の金額";
			this.Label1190.Top = 2.456F;
			this.Label1190.Width = 0.755F;
			// 
			// sposSumIncmAmt2Text
			// 
			this.sposSumIncmAmt2Text.CanGrow = false;
			this.sposSumIncmAmt2Text.DataField = "SPOS_SUM_INCM_AMT";
			this.sposSumIncmAmt2Text.Height = 0.153F;
			this.sposSumIncmAmt2Text.Left = 3.319F;
			this.sposSumIncmAmt2Text.Name = "sposSumIncmAmt2Text";
			this.sposSumIncmAmt2Text.OutputFormat = "#,##0";
			this.sposSumIncmAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.sposSumIncmAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.sposSumIncmAmt2Text.Top = 2.136F;
			this.sposSumIncmAmt2Text.Width = 0.647F;
			// 
			// Label1191
			// 
			this.Label1191.Height = 0.161F;
			this.Label1191.HyperLink = null;
			this.Label1191.Left = 3.956F;
			this.Label1191.Name = "Label1191";
			this.Label1191.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1191.Text = "円";
			this.Label1191.Top = 2.136F;
			this.Label1191.Width = 0.125F;
			// 
			// Label1192
			// 
			this.Label1192.Height = 0.161F;
			this.Label1192.HyperLink = null;
			this.Label1192.Left = 5.448F;
			this.Label1192.Name = "Label1192";
			this.Label1192.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1192.Text = "円";
			this.Label1192.Top = 2.289F;
			this.Label1192.Width = 0.125F;
			// 
			// lifeInsPensAmt2Text
			// 
			this.lifeInsPensAmt2Text.CanGrow = false;
			this.lifeInsPensAmt2Text.DataField = "LIFE_INS_PENS_AMT";
			this.lifeInsPensAmt2Text.Height = 0.153F;
			this.lifeInsPensAmt2Text.Left = 4.811F;
			this.lifeInsPensAmt2Text.Name = "lifeInsPensAmt2Text";
			this.lifeInsPensAmt2Text.OutputFormat = "#,##0";
			this.lifeInsPensAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.lifeInsPensAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsPensAmt2Text.Top = 2.289F;
			this.lifeInsPensAmt2Text.Width = 0.647F;
			// 
			// Label1193
			// 
			this.Label1193.Height = 0.1610007F;
			this.Label1193.HyperLink = null;
			this.Label1193.Left = 5.448F;
			this.Label1193.Name = "Label1193";
			this.Label1193.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1193.Text = "円";
			this.Label1193.Top = 2.446F;
			this.Label1193.Width = 0.125F;
			// 
			// nolfInsLongProdAmt2Text
			// 
			this.nolfInsLongProdAmt2Text.CanGrow = false;
			this.nolfInsLongProdAmt2Text.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmt2Text.Height = 0.153F;
			this.nolfInsLongProdAmt2Text.Left = 4.811F;
			this.nolfInsLongProdAmt2Text.Name = "nolfInsLongProdAmt2Text";
			this.nolfInsLongProdAmt2Text.OutputFormat = "#,##0";
			this.nolfInsLongProdAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.nolfInsLongProdAmt2Text.Text = "ZZ,ZZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmt2Text.Top = 2.446F;
			this.nolfInsLongProdAmt2Text.Width = 0.647F;
			// 
			// Label1213
			// 
			this.Label1213.Height = 0.17F;
			this.Label1213.HyperLink = null;
			this.Label1213.Left = 2.888F;
			this.Label1213.Name = "Label1213";
			this.Label1213.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1213.Text = "就職";
			this.Label1213.Top = 2.758F;
			this.Label1213.Width = 0.2F;
			// 
			// Label1214
			// 
			this.Label1214.Height = 0.17F;
			this.Label1214.HyperLink = null;
			this.Label1214.Left = 3.529F;
			this.Label1214.Name = "Label1214";
			this.Label1214.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1214.Text = "月";
			this.Label1214.Top = 2.758F;
			this.Label1214.Width = 0.192F;
			// 
			// Label1215
			// 
			this.Label1215.Height = 0.17F;
			this.Label1215.HyperLink = null;
			this.Label1215.Left = 3.288F;
			this.Label1215.Name = "Label1215";
			this.Label1215.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1215.Text = "年";
			this.Label1215.Top = 2.758F;
			this.Label1215.Width = 0.241F;
			// 
			// Label1216
			// 
			this.Label1216.Height = 0.17F;
			this.Label1216.HyperLink = null;
			this.Label1216.Left = 3.721F;
			this.Label1216.Name = "Label1216";
			this.Label1216.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1216.Text = "日";
			this.Label1216.Top = 2.758F;
			this.Label1216.Width = 0.228F;
			// 
			// Label1217
			// 
			this.Label1217.Height = 0.16F;
			this.Label1217.HyperLink = null;
			this.Label1217.Left = 3.948F;
			this.Label1217.Name = "Label1217";
			this.Label1217.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1217.Text = "受給者生年月日";
			this.Label1217.Top = 2.598F;
			this.Label1217.Width = 1.625F;
			// 
			// Label1218
			// 
			this.Label1218.Height = 0.17F;
			this.Label1218.HyperLink = null;
			this.Label1218.Left = 3.948F;
			this.Label1218.Name = "Label1218";
			this.Label1218.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1218.Text = "明";
			this.Label1218.Top = 2.758F;
			this.Label1218.Width = 0.194F;
			// 
			// Label1219
			// 
			this.Label1219.Height = 0.17F;
			this.Label1219.HyperLink = null;
			this.Label1219.Left = 4.724F;
			this.Label1219.Name = "Label1219";
			this.Label1219.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1219.Text = "年";
			this.Label1219.Top = 2.758F;
			this.Label1219.Width = 0.283F;
			// 
			// empName2Text
			// 
			this.empName2Text.CanGrow = false;
			this.empName2Text.DataField = "EMP_REGIST_NAME";
			this.empName2Text.Height = 0.157F;
			this.empName2Text.Left = 3.95422F;
			this.empName2Text.Name = "empName2Text";
			this.empName2Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empName2Text.Text = "あああああああああああああああ";
			this.empName2Text.Top = 0.6774449F;
			this.empName2Text.Width = 1.619001F;
			// 
			// Label1220
			// 
			this.Label1220.Height = 0.16F;
			this.Label1220.HyperLink = null;
			this.Label1220.Left = 2.888F;
			this.Label1220.Name = "Label1220";
			this.Label1220.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1220.Text = "中途就・退職";
			this.Label1220.Top = 2.598F;
			this.Label1220.Width = 1.063F;
			// 
			// minrType2Text
			// 
			this.minrType2Text.CanGrow = false;
			this.minrType2Text.DataField = "MINR_TYPE";
			this.minrType2Text.Height = 0.17F;
			this.minrType2Text.Left = 0.613F;
			this.minrType2Text.Name = "minrType2Text";
			this.minrType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrType2Text.Text = "0";
			this.minrType2Text.Top = 2.928F;
			this.minrType2Text.Width = 0.2F;
			// 
			// latter2Text
			// 
			this.latter2Text.CanGrow = false;
			this.latter2Text.DataField = "LATTER";
			this.latter2Text.Height = 0.17F;
			this.latter2Text.Left = 1.486F;
			this.latter2Text.Name = "latter2Text";
			this.latter2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latter2Text.Text = "0";
			this.latter2Text.Top = 2.928F;
			this.latter2Text.Width = 0.2F;
			// 
			// extHandiType2Text
			// 
			this.extHandiType2Text.CanGrow = false;
			this.extHandiType2Text.DataField = "EXT_HANDI_TYPE";
			this.extHandiType2Text.Height = 0.17F;
			this.extHandiType2Text.Left = 1.686F;
			this.extHandiType2Text.Name = "extHandiType2Text";
			this.extHandiType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiType2Text.Text = "0";
			this.extHandiType2Text.Top = 2.928F;
			this.extHandiType2Text.Width = 0.197F;
			// 
			// HandiType2Text
			// 
			this.HandiType2Text.CanGrow = false;
			this.HandiType2Text.DataField = "HANDI_TYPE";
			this.HandiType2Text.Height = 0.17F;
			this.HandiType2Text.Left = 1.886F;
			this.HandiType2Text.Name = "HandiType2Text";
			this.HandiType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HandiType2Text.Text = "0";
			this.HandiType2Text.Top = 2.928F;
			this.HandiType2Text.Width = 0.2F;
			// 
			// widowType2Text
			// 
			this.widowType2Text.CanGrow = false;
			this.widowType2Text.DataField = "WIDOW_TYPE";
			this.widowType2Text.Height = 0.17F;
			this.widowType2Text.Left = 2.086F;
			this.widowType2Text.Name = "widowType2Text";
			this.widowType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowType2Text.Text = "0";
			this.widowType2Text.Top = 2.928F;
			this.widowType2Text.Width = 0.2F;
			// 
			// extWidowType2Text
			// 
			this.extWidowType2Text.CanGrow = false;
			this.extWidowType2Text.DataField = "EXT_WIDOW_TYPE";
			this.extWidowType2Text.Height = 0.17F;
			this.extWidowType2Text.Left = 2.286F;
			this.extWidowType2Text.Name = "extWidowType2Text";
			this.extWidowType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowType2Text.Text = "0";
			this.extWidowType2Text.Top = 2.928F;
			this.extWidowType2Text.Width = 0.2F;
			// 
			// widomType2Text
			// 
			this.widomType2Text.CanGrow = false;
			this.widomType2Text.DataField = "WIDOM_TYPE";
			this.widomType2Text.Height = 0.17F;
			this.widomType2Text.Left = 2.486F;
			this.widomType2Text.Name = "widomType2Text";
			this.widomType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomType2Text.Text = "0";
			this.widomType2Text.Top = 2.928F;
			this.widomType2Text.Width = 0.2F;
			// 
			// wrkStdType2Text
			// 
			this.wrkStdType2Text.CanGrow = false;
			this.wrkStdType2Text.DataField = "WRK_STD_TYPE";
			this.wrkStdType2Text.Height = 0.17F;
			this.wrkStdType2Text.Left = 2.686F;
			this.wrkStdType2Text.Name = "wrkStdType2Text";
			this.wrkStdType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdType2Text.Text = "0";
			this.wrkStdType2Text.Top = 2.928F;
			this.wrkStdType2Text.Width = 0.2F;
			// 
			// Label1221
			// 
			this.Label1221.Height = 0.166F;
			this.Label1221.HyperLink = null;
			this.Label1221.Left = 0.386F;
			this.Label1221.Name = "Label1221";
			this.Label1221.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1221.Text = "支";
			this.Label1221.Top = 3.109F;
			this.Label1221.Width = 0.22F;
			// 
			// Label1222
			// 
			this.Label1222.Height = 0.166F;
			this.Label1222.HyperLink = null;
			this.Label1222.Left = 0.386F;
			this.Label1222.Name = "Label1222";
			this.Label1222.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1222.Text = "払";
			this.Label1222.Top = 3.272F;
			this.Label1222.Width = 0.22F;
			// 
			// Label1223
			// 
			this.Label1223.Height = 0.166F;
			this.Label1223.HyperLink = null;
			this.Label1223.Left = 0.386F;
			this.Label1223.Name = "Label1223";
			this.Label1223.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1223.Text = "者";
			this.Label1223.Top = 3.438F;
			this.Label1223.Width = 0.22F;
			// 
			// paymntAddress2Text
			// 
			this.paymntAddress2Text.CanGrow = false;
			this.paymntAddress2Text.DataField = "PAYMNT_ADDRESS";
			this.paymntAddress2Text.Height = 0.332F;
			this.paymntAddress2Text.Left = 1.261F;
			this.paymntAddress2Text.Name = "paymntAddress2Text";
			this.paymntAddress2Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddress2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddress2Text.Top = 3.106F;
			this.paymntAddress2Text.Width = 4.312F;
			// 
			// paymntName2Text
			// 
			this.paymntName2Text.CanGrow = false;
			this.paymntName2Text.DataField = "PAYMNT_NAME";
			this.paymntName2Text.Height = 0.188F;
			this.paymntName2Text.Left = 1.262F;
			this.paymntName2Text.MultiLine = false;
			this.paymntName2Text.Name = "paymntName2Text";
			this.paymntName2Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntName2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntName2Text.Top = 3.438F;
			this.paymntName2Text.Width = 3.125F;
			// 
			// Label1224
			// 
			this.Label1224.Height = 0.188F;
			this.Label1224.HyperLink = null;
			this.Label1224.Left = 4.386F;
			this.Label1224.Name = "Label1224";
			this.Label1224.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1224.Text = "（電話）";
			this.Label1224.Top = 3.438F;
			this.Label1224.Width = 0.365F;
			// 
			// paymntPhone2Text
			// 
			this.paymntPhone2Text.CanGrow = false;
			this.paymntPhone2Text.DataField = "PAYMNT_PHONE";
			this.paymntPhone2Text.Height = 0.188F;
			this.paymntPhone2Text.Left = 4.761F;
			this.paymntPhone2Text.Name = "paymntPhone2Text";
			this.paymntPhone2Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.paymntPhone2Text.Text = "99999999999999";
			this.paymntPhone2Text.Top = 3.438F;
			this.paymntPhone2Text.Width = 0.812F;
			// 
			// Label1225
			// 
			this.Label1225.Height = 0.166F;
			this.Label1225.HyperLink = null;
			this.Label1225.Left = 0.616F;
			this.Label1225.Name = "Label1225";
			this.Label1225.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1225.Text = "住所（居所）";
			this.Label1225.Top = 3.108F;
			this.Label1225.Width = 0.64F;
			// 
			// Label1226
			// 
			this.Label1226.Height = 0.166F;
			this.Label1226.HyperLink = null;
			this.Label1226.Left = 0.616F;
			this.Label1226.Name = "Label1226";
			this.Label1226.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1226.Text = "又は所在地";
			this.Label1226.Top = 3.272F;
			this.Label1226.Width = 0.64F;
			// 
			// Label1228
			// 
			this.Label1228.Height = 0.188F;
			this.Label1228.HyperLink = null;
			this.Label1228.Left = 0.616F;
			this.Label1228.Name = "Label1228";
			this.Label1228.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1228.Text = "氏名又は名称";
			this.Label1228.Top = 3.443F;
			this.Label1228.Width = 0.655F;
			// 
			// Label1229
			// 
			this.Label1229.Height = 0.209F;
			this.Label1229.HyperLink = null;
			this.Label1229.Left = 0.3857203F;
			this.Label1229.Name = "Label1229";
			this.Label1229.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1229.Text = "を受け";
			this.Label1229.Top = 0.4164455F;
			this.Label1229.Width = 0.292F;
			// 
			// Label1230
			// 
			this.Label1230.Height = 0.209F;
			this.Label1230.HyperLink = null;
			this.Label1230.Left = 0.3857203F;
			this.Label1230.Name = "Label1230";
			this.Label1230.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1230.Text = "る者";
			this.Label1230.Top = 0.6254443F;
			this.Label1230.Width = 0.292F;
			// 
			// Label1231
			// 
			this.Label1231.Height = 0.313F;
			this.Label1231.HyperLink = null;
			this.Label1231.Left = 3.21522F;
			this.Label1231.Name = "Label1231";
			this.Label1231.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1231.Text = "名";
			this.Label1231.Top = 0.5214451F;
			this.Label1231.Width = 0.19F;
			// 
			// Label1232
			// 
			this.Label1232.Height = 0.157F;
			this.Label1232.HyperLink = null;
			this.Label1232.Left = 0.3872204F;
			this.Label1232.Name = "Label1232";
			this.Label1232.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1232.Text = "者の有無等";
			this.Label1232.Top = 1.491445F;
			this.Label1232.Width = 0.399F;
			// 
			// Label1233
			// 
			this.Label1233.Height = 0.157F;
			this.Label1233.HyperLink = null;
			this.Label1233.Left = 0.8862205F;
			this.Label1233.Name = "Label1233";
			this.Label1233.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1233.Text = "控除の額";
			this.Label1233.Top = 1.491445F;
			this.Label1233.Width = 0.593F;
			// 
			// Label1234
			// 
			this.Label1234.Height = 0.157F;
			this.Label1234.HyperLink = null;
			this.Label1234.Left = 3.32322F;
			this.Label1234.Name = "Label1234";
			this.Label1234.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1234.Text = "等の金額";
			this.Label1234.Top = 1.490445F;
			this.Label1234.Width = 0.532F;
			// 
			// Label1235
			// 
			this.Label1235.Height = 0.157F;
			this.Label1235.HyperLink = null;
			this.Label1235.Left = 3.85422F;
			this.Label1235.Name = "Label1235";
			this.Label1235.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1235.Text = "の控除額";
			this.Label1235.Top = 1.490445F;
			this.Label1235.Width = 0.563F;
			// 
			// Label1236
			// 
			this.Label1236.Height = 0.157F;
			this.Label1236.HyperLink = null;
			this.Label1236.Left = 4.96822F;
			this.Label1236.Name = "Label1236";
			this.Label1236.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1236.Text = "特別控除の額";
			this.Label1236.Top = 1.490445F;
			this.Label1236.Width = 0.605F;
			// 
			// Label1237
			// 
			this.Label1237.Height = 0.156F;
			this.Label1237.HyperLink = null;
			this.Label1237.Left = 4.417219F;
			this.Label1237.Name = "Label1237";
			this.Label1237.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1237.Text = "損害保険料";
			this.Label1237.Top = 1.334445F;
			this.Label1237.Width = 0.551F;
			// 
			// Label1238
			// 
			this.Label1238.Height = 0.157F;
			this.Label1238.HyperLink = null;
			this.Label1238.Left = 4.417219F;
			this.Label1238.Name = "Label1238";
			this.Label1238.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1238.Text = "の控除額";
			this.Label1238.Top = 1.490445F;
			this.Label1238.Width = 0.551F;
			// 
			// nolfInsDedAmt2Text
			// 
			this.nolfInsDedAmt2Text.CanGrow = false;
			this.nolfInsDedAmt2Text.DataField = "NOLF_INS_DED_AMT";
			this.nolfInsDedAmt2Text.Height = 0.1875F;
			this.nolfInsDedAmt2Text.Left = 4.38572F;
			this.nolfInsDedAmt2Text.Name = "nolfInsDedAmt2Text";
			this.nolfInsDedAmt2Text.OutputFormat = "#,##0";
			this.nolfInsDedAmt2Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsDedAmt2Text.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsDedAmt2Text.Top = 1.810945F;
			this.nolfInsDedAmt2Text.Width = 0.5625F;
			// 
			// Label1239
			// 
			this.Label1239.Height = 0.125F;
			this.Label1239.HyperLink = null;
			this.Label1239.Left = 4.85722F;
			this.Label1239.Name = "Label1239";
			this.Label1239.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1239.Text = "円";
			this.Label1239.Top = 1.648445F;
			this.Label1239.Width = 0.1114998F;
			// 
			// deathRetireType2Text
			// 
			this.deathRetireType2Text.CanGrow = false;
			this.deathRetireType2Text.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireType2Text.Height = 0.17F;
			this.deathRetireType2Text.Left = 1.054F;
			this.deathRetireType2Text.Name = "deathRetireType2Text";
			this.deathRetireType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireType2Text.Text = "0";
			this.deathRetireType2Text.Top = 2.928F;
			this.deathRetireType2Text.Width = 0.2F;
			// 
			// disasterType2Text
			// 
			this.disasterType2Text.CanGrow = false;
			this.disasterType2Text.DataField = "DISASTER_TYPE";
			this.disasterType2Text.Height = 0.17F;
			this.disasterType2Text.Left = 1.275F;
			this.disasterType2Text.Name = "disasterType2Text";
			this.disasterType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterType2Text.Text = "0";
			this.disasterType2Text.Top = 2.928F;
			this.disasterType2Text.Width = 0.2F;
			// 
			// foreignType2Text
			// 
			this.foreignType2Text.CanGrow = false;
			this.foreignType2Text.DataField = "FOREIGN_TYPE";
			this.foreignType2Text.Height = 0.17F;
			this.foreignType2Text.Left = 0.834F;
			this.foreignType2Text.Name = "foreignType2Text";
			this.foreignType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignType2Text.Text = "0";
			this.foreignType2Text.Top = 2.928F;
			this.foreignType2Text.Width = 0.2F;
			// 
			// halfEmployType2Text
			// 
			this.halfEmployType2Text.CanGrow = false;
			this.halfEmployType2Text.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployType2Text.Height = 0.17F;
			this.halfEmployType2Text.Left = 2.888F;
			this.halfEmployType2Text.Name = "halfEmployType2Text";
			this.halfEmployType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployType2Text.Text = "0";
			this.halfEmployType2Text.Top = 2.928F;
			this.halfEmployType2Text.Width = 0.2F;
			// 
			// Label1261
			// 
			this.Label1261.Height = 0.17F;
			this.Label1261.HyperLink = null;
			this.Label1261.Left = 3.088F;
			this.Label1261.Name = "Label1261";
			this.Label1261.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1261.Text = "退職";
			this.Label1261.Top = 2.758F;
			this.Label1261.Width = 0.2F;
			// 
			// halfRetireType2Text
			// 
			this.halfRetireType2Text.CanGrow = false;
			this.halfRetireType2Text.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireType2Text.Height = 0.17F;
			this.halfRetireType2Text.Left = 3.088F;
			this.halfRetireType2Text.Name = "halfRetireType2Text";
			this.halfRetireType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireType2Text.Text = "0";
			this.halfRetireType2Text.Top = 2.928F;
			this.halfRetireType2Text.Width = 0.2F;
			// 
			// halrEmReDateYear2Text
			// 
			this.halrEmReDateYear2Text.CanGrow = false;
			this.halrEmReDateYear2Text.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halrEmReDateYear2Text.Height = 0.17F;
			this.halrEmReDateYear2Text.Left = 3.288F;
			this.halrEmReDateYear2Text.Name = "halrEmReDateYear2Text";
			this.halrEmReDateYear2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halrEmReDateYear2Text.Text = "0";
			this.halrEmReDateYear2Text.Top = 2.928F;
			this.halrEmReDateYear2Text.Width = 0.241F;
			// 
			// halfEmReDateMonth2Text
			// 
			this.halfEmReDateMonth2Text.CanGrow = false;
			this.halfEmReDateMonth2Text.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReDateMonth2Text.Height = 0.17F;
			this.halfEmReDateMonth2Text.Left = 3.529F;
			this.halfEmReDateMonth2Text.Name = "halfEmReDateMonth2Text";
			this.halfEmReDateMonth2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateMonth2Text.Text = "0";
			this.halfEmReDateMonth2Text.Top = 2.928F;
			this.halfEmReDateMonth2Text.Width = 0.192F;
			// 
			// halfEmReDateDay2Text
			// 
			this.halfEmReDateDay2Text.CanGrow = false;
			this.halfEmReDateDay2Text.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDay2Text.Height = 0.17F;
			this.halfEmReDateDay2Text.Left = 3.721F;
			this.halfEmReDateDay2Text.Name = "halfEmReDateDay2Text";
			this.halfEmReDateDay2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDay2Text.Text = "0";
			this.halfEmReDateDay2Text.Top = 2.928F;
			this.halfEmReDateDay2Text.Width = 0.228F;
			// 
			// Label1262
			// 
			this.Label1262.Height = 0.17F;
			this.Label1262.HyperLink = null;
			this.Label1262.Left = 4.142F;
			this.Label1262.Name = "Label1262";
			this.Label1262.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1262.Text = "大";
			this.Label1262.Top = 2.758F;
			this.Label1262.Width = 0.194F;
			// 
			// Label1263
			// 
			this.Label1263.Height = 0.17F;
			this.Label1263.HyperLink = null;
			this.Label1263.Left = 4.336F;
			this.Label1263.Name = "Label1263";
			this.Label1263.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1263.Text = "昭";
			this.Label1263.Top = 2.758F;
			this.Label1263.Width = 0.194F;
			// 
			// Label1264
			// 
			this.Label1264.Height = 0.17F;
			this.Label1264.HyperLink = null;
			this.Label1264.Left = 4.53F;
			this.Label1264.Name = "Label1264";
			this.Label1264.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1264.Text = "平";
			this.Label1264.Top = 2.758F;
			this.Label1264.Width = 0.194F;
			// 
			// Label1265
			// 
			this.Label1265.Height = 0.17F;
			this.Label1265.HyperLink = null;
			this.Label1265.Left = 5.007F;
			this.Label1265.Name = "Label1265";
			this.Label1265.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1265.Text = "月";
			this.Label1265.Top = 2.758F;
			this.Label1265.Width = 0.283F;
			// 
			// Label1266
			// 
			this.Label1266.Height = 0.17F;
			this.Label1266.HyperLink = null;
			this.Label1266.Left = 5.29F;
			this.Label1266.Name = "Label1266";
			this.Label1266.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1266.Text = "日";
			this.Label1266.Top = 2.758F;
			this.Label1266.Width = 0.283F;
			// 
			// birthNameOfEraM2Text
			// 
			this.birthNameOfEraM2Text.CanGrow = false;
			this.birthNameOfEraM2Text.DataField = "BIRTH_NAME_OF_ERA_M";
			this.birthNameOfEraM2Text.Height = 0.17F;
			this.birthNameOfEraM2Text.Left = 3.948F;
			this.birthNameOfEraM2Text.Name = "birthNameOfEraM2Text";
			this.birthNameOfEraM2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraM2Text.Text = "0";
			this.birthNameOfEraM2Text.Top = 2.928F;
			this.birthNameOfEraM2Text.Width = 0.194F;
			// 
			// birthNameOfErat2Text
			// 
			this.birthNameOfErat2Text.CanGrow = false;
			this.birthNameOfErat2Text.DataField = "BIRTH_NAME_OF_ERA_T";
			this.birthNameOfErat2Text.Height = 0.17F;
			this.birthNameOfErat2Text.Left = 4.142F;
			this.birthNameOfErat2Text.Name = "birthNameOfErat2Text";
			this.birthNameOfErat2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfErat2Text.Text = "0";
			this.birthNameOfErat2Text.Top = 2.928F;
			this.birthNameOfErat2Text.Width = 0.194F;
			// 
			// birthNameOfEraS2Text
			// 
			this.birthNameOfEraS2Text.CanGrow = false;
			this.birthNameOfEraS2Text.DataField = "BIRTH_NAME_OF_ERA_S";
			this.birthNameOfEraS2Text.Height = 0.17F;
			this.birthNameOfEraS2Text.Left = 4.336F;
			this.birthNameOfEraS2Text.Name = "birthNameOfEraS2Text";
			this.birthNameOfEraS2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraS2Text.Text = "0";
			this.birthNameOfEraS2Text.Top = 2.928F;
			this.birthNameOfEraS2Text.Width = 0.194F;
			// 
			// birthNameOfEraH2Text
			// 
			this.birthNameOfEraH2Text.CanGrow = false;
			this.birthNameOfEraH2Text.DataField = "BIRTH_NAME_OF_ERA_H";
			this.birthNameOfEraH2Text.Height = 0.17F;
			this.birthNameOfEraH2Text.Left = 4.53F;
			this.birthNameOfEraH2Text.Name = "birthNameOfEraH2Text";
			this.birthNameOfEraH2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraH2Text.Text = "0";
			this.birthNameOfEraH2Text.Top = 2.928F;
			this.birthNameOfEraH2Text.Width = 0.194F;
			// 
			// birthDayYear2Text
			// 
			this.birthDayYear2Text.CanGrow = false;
			this.birthDayYear2Text.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYear2Text.Height = 0.17F;
			this.birthDayYear2Text.Left = 4.724F;
			this.birthDayYear2Text.Name = "birthDayYear2Text";
			this.birthDayYear2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYear2Text.Text = "0";
			this.birthDayYear2Text.Top = 2.928F;
			this.birthDayYear2Text.Width = 0.283F;
			// 
			// birthDayMonth2Text
			// 
			this.birthDayMonth2Text.CanGrow = false;
			this.birthDayMonth2Text.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonth2Text.Height = 0.17F;
			this.birthDayMonth2Text.Left = 5.007F;
			this.birthDayMonth2Text.Name = "birthDayMonth2Text";
			this.birthDayMonth2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonth2Text.Text = "0";
			this.birthDayMonth2Text.Top = 2.928F;
			this.birthDayMonth2Text.Width = 0.283F;
			// 
			// birthDayDay2Text
			// 
			this.birthDayDay2Text.CanGrow = false;
			this.birthDayDay2Text.DataField = "BIRTH_DAY_DAY";
			this.birthDayDay2Text.Height = 0.17F;
			this.birthDayDay2Text.Left = 5.29F;
			this.birthDayDay2Text.Name = "birthDayDay2Text";
			this.birthDayDay2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDay2Text.Text = "0";
			this.birthDayDay2Text.Top = 2.928F;
			this.birthDayDay2Text.Width = 0.283F;
			// 
			// socInsDedAmt2Text
			// 
			this.socInsDedAmt2Text.CanGrow = false;
			this.socInsDedAmt2Text.DataField = "SOC_INS_DED_AMT";
			this.socInsDedAmt2Text.Height = 0.158F;
			this.socInsDedAmt2Text.Left = 3.32222F;
			this.socInsDedAmt2Text.Name = "socInsDedAmt2Text";
			this.socInsDedAmt2Text.OutputFormat = "#,##0";
			this.socInsDedAmt2Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.socInsDedAmt2Text.Text = "ZZ,ZZZ,ZZ6";
			this.socInsDedAmt2Text.Top = 1.848446F;
			this.socInsDedAmt2Text.Width = 0.532F;
			// 
			// Label1273
			// 
			this.Label1273.Height = 0.625F;
			this.Label1273.HyperLink = null;
			this.Label1273.Left = 0.2167201F;
			this.Label1273.Name = "Label1273";
			this.Label1273.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1273.Text = "市区町村提出用";
			this.Label1273.Top = 3.083945F;
			this.Label1273.Width = 0.1695F;
			// 
			// Label1274
			// 
			this.Label1274.Angle = 2700;
			this.Label1274.Height = 0.1164999F;
			this.Label1274.HyperLink = null;
			this.Label1274.Left = 0.2162204F;
			this.Label1274.Name = "Label1274";
			this.Label1274.Style = "font-size: 5.5pt; text-align: center; vertical-align: bottom; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1274.Text = "(";
			this.Label1274.Top = 2.986945F;
			this.Label1274.Width = 0.17F;
			// 
			// Label1275
			// 
			this.Label1275.Angle = 900;
			this.Label1275.Height = 0.08F;
			this.Label1275.HyperLink = null;
			this.Label1275.Left = 0.2271371F;
			this.Label1275.Name = "Label1275";
			this.Label1275.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1275.Text = "(";
			this.Label1275.Top = 3.630945F;
			this.Label1275.Width = 0.17F;
			// 
			// Line473
			// 
			this.Line473.Height = 0F;
			this.Line473.Left = 0.3862205F;
			this.Line473.LineWeight = 1F;
			this.Line473.Name = "Line473";
			this.Line473.Top = 3.630945F;
			this.Line473.Width = 5.186999F;
			this.Line473.X1 = 0.3862205F;
			this.Line473.X2 = 5.57322F;
			this.Line473.Y1 = 3.630945F;
			this.Line473.Y2 = 3.630945F;
			// 
			// Line474
			// 
			this.Line474.Height = 0F;
			this.Line474.Left = 0.3862205F;
			this.Line474.LineWeight = 1F;
			this.Line474.Name = "Line474";
			this.Line474.Top = 0.2089451F;
			this.Line474.Width = 5.186999F;
			this.Line474.X1 = 0.3862205F;
			this.Line474.X2 = 5.57322F;
			this.Line474.Y1 = 0.2089451F;
			this.Line474.Y2 = 0.2089451F;
			// 
			// Line475
			// 
			this.Line475.Height = 0F;
			this.Line475.Left = 0.3862205F;
			this.Line475.LineWeight = 1F;
			this.Line475.Name = "Line475";
			this.Line475.Top = 0.833945F;
			this.Line475.Width = 5.186999F;
			this.Line475.X1 = 0.3862205F;
			this.Line475.X2 = 5.57322F;
			this.Line475.Y1 = 0.833945F;
			this.Line475.Y2 = 0.833945F;
			// 
			// Line476
			// 
			this.Line476.Height = 0F;
			this.Line476.Left = 0.3862205F;
			this.Line476.LineWeight = 1F;
			this.Line476.Name = "Line476";
			this.Line476.Top = 1.334945F;
			this.Line476.Width = 5.186999F;
			this.Line476.X1 = 0.3862205F;
			this.Line476.X2 = 5.57322F;
			this.Line476.Y1 = 1.334945F;
			this.Line476.Y2 = 1.334945F;
			// 
			// Line477
			// 
			this.Line477.Height = 0F;
			this.Line477.Left = 0.3862205F;
			this.Line477.LineWeight = 1F;
			this.Line477.Name = "Line477";
			this.Line477.Top = 1.648945F;
			this.Line477.Width = 5.186999F;
			this.Line477.X1 = 0.3862205F;
			this.Line477.X2 = 5.57322F;
			this.Line477.Y1 = 1.648945F;
			this.Line477.Y2 = 1.648945F;
			// 
			// Line478
			// 
			this.Line478.Height = 0F;
			this.Line478.Left = 0.3862205F;
			this.Line478.LineWeight = 1F;
			this.Line478.Name = "Line478";
			this.Line478.Top = 2.6F;
			this.Line478.Width = 5.186999F;
			this.Line478.X1 = 0.3862205F;
			this.Line478.X2 = 5.57322F;
			this.Line478.Y1 = 2.6F;
			this.Line478.Y2 = 2.6F;
			// 
			// Line481
			// 
			this.Line481.Height = 3.61F;
			this.Line481.Left = 5.57322F;
			this.Line481.LineWeight = 1F;
			this.Line481.Name = "Line481";
			this.Line481.Top = 0.02094489F;
			this.Line481.Width = 0F;
			this.Line481.X1 = 5.57322F;
			this.Line481.X2 = 5.57322F;
			this.Line481.Y1 = 0.02094489F;
			this.Line481.Y2 = 3.630945F;
			// 
			// Line482
			// 
			this.Line482.Height = 0.7330001F;
			this.Line482.Left = 0.6782203F;
			this.Line482.LineWeight = 1F;
			this.Line482.Name = "Line482";
			this.Line482.Top = 0.1009449F;
			this.Line482.Width = 0F;
			this.Line482.X1 = 0.6782203F;
			this.Line482.X2 = 0.6782203F;
			this.Line482.Y1 = 0.1009449F;
			this.Line482.Y2 = 0.833945F;
			// 
			// Line483
			// 
			this.Line483.Height = 0.4690001F;
			this.Line483.Left = 0.8662205F;
			this.Line483.LineWeight = 1F;
			this.Line483.Name = "Line483";
			this.Line483.Top = 0.3649449F;
			this.Line483.Width = 0F;
			this.Line483.X1 = 0.8662205F;
			this.Line483.X2 = 0.8662205F;
			this.Line483.Y1 = 0.3649449F;
			this.Line483.Y2 = 0.833945F;
			// 
			// Line484
			// 
			this.Line484.Height = 0.6249999F;
			this.Line484.Left = 3.21522F;
			this.Line484.LineWeight = 1F;
			this.Line484.Name = "Line484";
			this.Line484.Top = 0.2089451F;
			this.Line484.Width = 0F;
			this.Line484.X1 = 3.21522F;
			this.Line484.X2 = 3.21522F;
			this.Line484.Y1 = 0.2089451F;
			this.Line484.Y2 = 0.833945F;
			// 
			// Line485
			// 
			this.Line485.Height = 0.6249999F;
			this.Line485.Left = 3.40522F;
			this.Line485.LineWeight = 1F;
			this.Line485.Name = "Line485";
			this.Line485.Top = 0.2089451F;
			this.Line485.Width = 0F;
			this.Line485.X1 = 3.40522F;
			this.Line485.X2 = 3.40522F;
			this.Line485.Y1 = 0.2089451F;
			this.Line485.Y2 = 0.833945F;
			// 
			// Line486
			// 
			this.Line486.Height = 0F;
			this.Line486.Left = 3.40522F;
			this.Line486.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line486.LineWeight = 1F;
			this.Line486.Name = "Line486";
			this.Line486.Top = 0.3649448F;
			this.Line486.Width = 2.168F;
			this.Line486.X1 = 3.40522F;
			this.Line486.X2 = 5.57322F;
			this.Line486.Y1 = 0.3649448F;
			this.Line486.Y2 = 0.3649448F;
			// 
			// Line487
			// 
			this.Line487.Height = 0F;
			this.Line487.Left = 3.40522F;
			this.Line487.LineWeight = 1F;
			this.Line487.Name = "Line487";
			this.Line487.Top = 0.5209449F;
			this.Line487.Width = 2.168F;
			this.Line487.X1 = 3.40522F;
			this.Line487.X2 = 5.57322F;
			this.Line487.Y1 = 0.5209449F;
			this.Line487.Y2 = 0.5209449F;
			// 
			// Line488
			// 
			this.Line488.Height = 0.501F;
			this.Line488.Left = 1.324219F;
			this.Line488.LineWeight = 1F;
			this.Line488.Name = "Line488";
			this.Line488.Top = 0.833945F;
			this.Line488.Width = 0F;
			this.Line488.X1 = 1.324219F;
			this.Line488.X2 = 1.324219F;
			this.Line488.Y1 = 0.833945F;
			this.Line488.Y2 = 1.334945F;
			// 
			// Line489
			// 
			this.Line489.Height = 0.501F;
			this.Line489.Left = 2.402221F;
			this.Line489.LineWeight = 1F;
			this.Line489.Name = "Line489";
			this.Line489.Top = 0.833945F;
			this.Line489.Width = 0F;
			this.Line489.X1 = 2.402221F;
			this.Line489.X2 = 2.402221F;
			this.Line489.Y1 = 0.833945F;
			this.Line489.Y2 = 1.334945F;
			// 
			// Line490
			// 
			this.Line490.Height = 0.501F;
			this.Line490.Left = 3.46522F;
			this.Line490.LineWeight = 1F;
			this.Line490.Name = "Line490";
			this.Line490.Top = 0.833945F;
			this.Line490.Width = 0F;
			this.Line490.X1 = 3.46522F;
			this.Line490.X2 = 3.46522F;
			this.Line490.Y1 = 0.833945F;
			this.Line490.Y2 = 1.334945F;
			// 
			// Line491
			// 
			this.Line491.Height = 0.501F;
			this.Line491.Left = 4.52822F;
			this.Line491.LineWeight = 1F;
			this.Line491.Name = "Line491";
			this.Line491.Top = 0.833945F;
			this.Line491.Width = 0F;
			this.Line491.X1 = 4.52822F;
			this.Line491.X2 = 4.52822F;
			this.Line491.Y1 = 0.833945F;
			this.Line491.Y2 = 1.334945F;
			// 
			// Line492
			// 
			this.Line492.Height = 0F;
			this.Line492.Left = 0.3862205F;
			this.Line492.LineWeight = 1F;
			this.Line492.Name = "Line492";
			this.Line492.Top = 1.006945F;
			this.Line492.Width = 5.186999F;
			this.Line492.X1 = 0.3862205F;
			this.Line492.X2 = 5.57322F;
			this.Line492.Y1 = 1.006945F;
			this.Line492.Y2 = 1.006945F;
			// 
			// Line493
			// 
			this.Line493.Height = 0F;
			this.Line493.Left = 0.7862201F;
			this.Line493.LineWeight = 1F;
			this.Line493.Name = "Line493";
			this.Line493.Top = 1.475945F;
			this.Line493.Width = 0.1000004F;
			this.Line493.X1 = 0.7862201F;
			this.Line493.X2 = 0.8862205F;
			this.Line493.Y1 = 1.475945F;
			this.Line493.Y2 = 1.475945F;
			// 
			// Line494
			// 
			this.Line494.Height = 0.516F;
			this.Line494.Left = 0.7862201F;
			this.Line494.LineWeight = 1F;
			this.Line494.Name = "Line494";
			this.Line494.Top = 1.475945F;
			this.Line494.Width = 0F;
			this.Line494.X1 = 0.7862201F;
			this.Line494.X2 = 0.7862201F;
			this.Line494.Y1 = 1.475945F;
			this.Line494.Y2 = 1.991945F;
			// 
			// Line495
			// 
			this.Line495.Height = 0.343001F;
			this.Line495.Left = 0.6862202F;
			this.Line495.LineWeight = 1F;
			this.Line495.Name = "Line495";
			this.Line495.Top = 1.648944F;
			this.Line495.Width = 0F;
			this.Line495.X1 = 0.6862202F;
			this.Line495.X2 = 0.6862202F;
			this.Line495.Y1 = 1.648944F;
			this.Line495.Y2 = 1.991945F;
			// 
			// Line496
			// 
			this.Line496.Height = 0.343001F;
			this.Line496.Left = 0.5862203F;
			this.Line496.LineWeight = 1F;
			this.Line496.Name = "Line496";
			this.Line496.Top = 1.648944F;
			this.Line496.Width = 0F;
			this.Line496.X1 = 0.5862203F;
			this.Line496.X2 = 0.5862203F;
			this.Line496.Y1 = 1.648944F;
			this.Line496.Y2 = 1.991945F;
			// 
			// Line497
			// 
			this.Line497.Height = 0.343001F;
			this.Line497.Left = 0.4862204F;
			this.Line497.LineWeight = 1F;
			this.Line497.Name = "Line497";
			this.Line497.Top = 1.648944F;
			this.Line497.Width = 0F;
			this.Line497.X1 = 0.4862204F;
			this.Line497.X2 = 0.4862204F;
			this.Line497.Y1 = 1.648944F;
			this.Line497.Y2 = 1.991945F;
			// 
			// Line498
			// 
			this.Line498.Height = 0.6570001F;
			this.Line498.Left = 1.48022F;
			this.Line498.LineWeight = 1F;
			this.Line498.Name = "Line498";
			this.Line498.Top = 1.334945F;
			this.Line498.Width = 0F;
			this.Line498.X1 = 1.48022F;
			this.Line498.X2 = 1.48022F;
			this.Line498.Y1 = 1.334945F;
			this.Line498.Y2 = 1.991945F;
			// 
			// Line499
			// 
			this.Line499.Height = 0.343001F;
			this.Line499.Left = 1.66822F;
			this.Line499.LineWeight = 1F;
			this.Line499.Name = "Line499";
			this.Line499.Top = 1.648944F;
			this.Line499.Width = 0F;
			this.Line499.X1 = 1.66822F;
			this.Line499.X2 = 1.66822F;
			this.Line499.Y1 = 1.648944F;
			this.Line499.Y2 = 1.991945F;
			// 
			// Line500
			// 
			this.Line500.Height = 0F;
			this.Line500.Left = 1.48022F;
			this.Line500.LineWeight = 1F;
			this.Line500.Name = "Line500";
			this.Line500.Top = 1.542945F;
			this.Line500.Width = 1.843F;
			this.Line500.X1 = 1.48022F;
			this.Line500.X2 = 3.32322F;
			this.Line500.Y1 = 1.542945F;
			this.Line500.Y2 = 1.542945F;
			// 
			// Line501
			// 
			this.Line501.Height = 0.448999F;
			this.Line501.Left = 1.86622F;
			this.Line501.LineWeight = 1F;
			this.Line501.Name = "Line501";
			this.Line501.Top = 1.542946F;
			this.Line501.Width = 0F;
			this.Line501.X1 = 1.86622F;
			this.Line501.X2 = 1.86622F;
			this.Line501.Y1 = 1.542946F;
			this.Line501.Y2 = 1.991945F;
			// 
			// Line502
			// 
			this.Line502.Height = 0.2460001F;
			this.Line502.Left = 1.97622F;
			this.Line502.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line502.LineWeight = 1F;
			this.Line502.Name = "Line502";
			this.Line502.Top = 1.745945F;
			this.Line502.Width = 0F;
			this.Line502.X1 = 1.97622F;
			this.Line502.X2 = 1.97622F;
			this.Line502.Y1 = 1.745945F;
			this.Line502.Y2 = 1.991945F;
			// 
			// Line503
			// 
			this.Line503.Height = 0.343001F;
			this.Line503.Left = 2.19522F;
			this.Line503.LineWeight = 1F;
			this.Line503.Name = "Line503";
			this.Line503.Top = 1.648944F;
			this.Line503.Width = 0F;
			this.Line503.X1 = 2.19522F;
			this.Line503.X2 = 2.19522F;
			this.Line503.Y1 = 1.648944F;
			this.Line503.Y2 = 1.991945F;
			// 
			// Line504
			// 
			this.Line504.Height = 0.449F;
			this.Line504.Left = 2.41322F;
			this.Line504.LineWeight = 1F;
			this.Line504.Name = "Line504";
			this.Line504.Top = 1.542945F;
			this.Line504.Width = 0F;
			this.Line504.X1 = 2.41322F;
			this.Line504.X2 = 2.41322F;
			this.Line504.Y1 = 1.542945F;
			this.Line504.Y2 = 1.991945F;
			// 
			// Line505
			// 
			this.Line505.Height = 0.343001F;
			this.Line505.Left = 2.605219F;
			this.Line505.LineWeight = 1F;
			this.Line505.Name = "Line505";
			this.Line505.Top = 1.648944F;
			this.Line505.Width = 0F;
			this.Line505.X1 = 2.605219F;
			this.Line505.X2 = 2.605219F;
			this.Line505.Y1 = 1.648944F;
			this.Line505.Y2 = 1.991945F;
			// 
			// Line506
			// 
			this.Line506.Height = 0.6570001F;
			this.Line506.Left = 2.797221F;
			this.Line506.LineWeight = 1F;
			this.Line506.Name = "Line506";
			this.Line506.Top = 1.334945F;
			this.Line506.Width = 0F;
			this.Line506.X1 = 2.797221F;
			this.Line506.X2 = 2.797221F;
			this.Line506.Y1 = 1.334945F;
			this.Line506.Y2 = 1.991945F;
			// 
			// Line507
			// 
			this.Line507.Height = 0.2460001F;
			this.Line507.Left = 2.922221F;
			this.Line507.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line507.LineWeight = 1F;
			this.Line507.Name = "Line507";
			this.Line507.Top = 1.745945F;
			this.Line507.Width = 0F;
			this.Line507.X1 = 2.922221F;
			this.Line507.X2 = 2.922221F;
			this.Line507.Y1 = 1.745945F;
			this.Line507.Y2 = 1.991945F;
			// 
			// Line508
			// 
			this.Line508.Height = 0.448999F;
			this.Line508.Left = 3.047221F;
			this.Line508.LineWeight = 1F;
			this.Line508.Name = "Line508";
			this.Line508.Top = 1.542946F;
			this.Line508.Width = 0F;
			this.Line508.X1 = 3.047221F;
			this.Line508.X2 = 3.047221F;
			this.Line508.Y1 = 1.542946F;
			this.Line508.Y2 = 1.991945F;
			// 
			// Line509
			// 
			this.Line509.Height = 0.6570001F;
			this.Line509.Left = 3.32222F;
			this.Line509.LineWeight = 1F;
			this.Line509.Name = "Line509";
			this.Line509.Top = 1.334945F;
			this.Line509.Width = 0F;
			this.Line509.X1 = 3.32222F;
			this.Line509.X2 = 3.32222F;
			this.Line509.Y1 = 1.334945F;
			this.Line509.Y2 = 1.991945F;
			// 
			// Line510
			// 
			this.Line510.Height = 0.6570001F;
			this.Line510.Left = 3.85422F;
			this.Line510.LineWeight = 1F;
			this.Line510.Name = "Line510";
			this.Line510.Top = 1.334945F;
			this.Line510.Width = 0F;
			this.Line510.X1 = 3.85422F;
			this.Line510.X2 = 3.85422F;
			this.Line510.Y1 = 1.334945F;
			this.Line510.Y2 = 1.991945F;
			// 
			// Line511
			// 
			this.Line511.Height = 0.6570001F;
			this.Line511.Left = 4.417219F;
			this.Line511.LineWeight = 1F;
			this.Line511.Name = "Line511";
			this.Line511.Top = 1.334945F;
			this.Line511.Width = 0F;
			this.Line511.X1 = 4.417219F;
			this.Line511.X2 = 4.417219F;
			this.Line511.Y1 = 1.334945F;
			this.Line511.Y2 = 1.991945F;
			// 
			// Line512
			// 
			this.Line512.Height = 0.6570001F;
			this.Line512.Left = 4.96822F;
			this.Line512.LineWeight = 1F;
			this.Line512.Name = "Line512";
			this.Line512.Top = 1.334945F;
			this.Line512.Width = 0F;
			this.Line512.X1 = 4.96822F;
			this.Line512.X2 = 4.96822F;
			this.Line512.Y1 = 1.334945F;
			this.Line512.Y2 = 1.991945F;
			// 
			// Line513
			// 
			this.Line513.Height = 0F;
			this.Line513.Left = 0.3862205F;
			this.Line513.LineWeight = 1F;
			this.Line513.Name = "Line513";
			this.Line513.Top = 1.991945F;
			this.Line513.Width = 5.186999F;
			this.Line513.X1 = 0.3862205F;
			this.Line513.X2 = 5.57322F;
			this.Line513.Y1 = 1.991945F;
			this.Line513.Y2 = 1.991945F;
			// 
			// Line514
			// 
			this.Line514.Height = 0.51F;
			this.Line514.Left = 3.948719F;
			this.Line514.LineWeight = 1F;
			this.Line514.Name = "Line514";
			this.Line514.Top = 2.6F;
			this.Line514.Width = 0F;
			this.Line514.X1 = 3.948719F;
			this.Line514.X2 = 3.948719F;
			this.Line514.Y1 = 2.6F;
			this.Line514.Y2 = 3.11F;
			// 
			// Line515
			// 
			this.Line515.Height = 0.6080549F;
			this.Line515.Left = 4.818F;
			this.Line515.LineWeight = 1F;
			this.Line515.Name = "Line515";
			this.Line515.Top = 1.991945F;
			this.Line515.Width = 0F;
			this.Line515.X1 = 4.818F;
			this.Line515.X2 = 4.818F;
			this.Line515.Y1 = 1.991945F;
			this.Line515.Y2 = 2.6F;
			// 
			// Line528
			// 
			this.Line528.Height = 0.51F;
			this.Line528.Left = 2.88772F;
			this.Line528.LineWeight = 1F;
			this.Line528.Name = "Line528";
			this.Line528.Top = 2.6F;
			this.Line528.Width = 0F;
			this.Line528.X1 = 2.88772F;
			this.Line528.X2 = 2.88772F;
			this.Line528.Y1 = 2.6F;
			this.Line528.Y2 = 3.11F;
			// 
			// Line529
			// 
			this.Line529.Height = 0F;
			this.Line529.Left = 2.88772F;
			this.Line529.LineWeight = 1F;
			this.Line529.Name = "Line529";
			this.Line529.Top = 2.76F;
			this.Line529.Width = 2.6855F;
			this.Line529.X1 = 2.88772F;
			this.Line529.X2 = 5.57322F;
			this.Line529.Y1 = 2.76F;
			this.Line529.Y2 = 2.76F;
			// 
			// Line530
			// 
			this.Line530.Height = 0.3499999F;
			this.Line530.Left = 3.087719F;
			this.Line530.LineWeight = 1F;
			this.Line530.Name = "Line530";
			this.Line530.Top = 2.76F;
			this.Line530.Width = 0F;
			this.Line530.X1 = 3.087719F;
			this.Line530.X2 = 3.087719F;
			this.Line530.Y1 = 2.76F;
			this.Line530.Y2 = 3.11F;
			// 
			// Line531
			// 
			this.Line531.Height = 0.3499999F;
			this.Line531.Left = 3.28772F;
			this.Line531.LineWeight = 1F;
			this.Line531.Name = "Line531";
			this.Line531.Top = 2.76F;
			this.Line531.Width = 0F;
			this.Line531.X1 = 3.28772F;
			this.Line531.X2 = 3.28772F;
			this.Line531.Y1 = 2.76F;
			this.Line531.Y2 = 3.11F;
			// 
			// Line532
			// 
			this.Line532.Height = 0.3499999F;
			this.Line532.Left = 3.528719F;
			this.Line532.LineWeight = 1F;
			this.Line532.Name = "Line532";
			this.Line532.Top = 2.76F;
			this.Line532.Width = 0F;
			this.Line532.X1 = 3.528719F;
			this.Line532.X2 = 3.528719F;
			this.Line532.Y1 = 2.76F;
			this.Line532.Y2 = 3.11F;
			// 
			// Line533
			// 
			this.Line533.Height = 0.3499999F;
			this.Line533.Left = 3.720721F;
			this.Line533.LineWeight = 1F;
			this.Line533.Name = "Line533";
			this.Line533.Top = 2.76F;
			this.Line533.Width = 0F;
			this.Line533.X1 = 3.720721F;
			this.Line533.X2 = 3.720721F;
			this.Line533.Y1 = 2.76F;
			this.Line533.Y2 = 3.11F;
			// 
			// Line534
			// 
			this.Line534.Height = 0.3499999F;
			this.Line534.Left = 4.14222F;
			this.Line534.LineWeight = 1F;
			this.Line534.Name = "Line534";
			this.Line534.Top = 2.76F;
			this.Line534.Width = 0F;
			this.Line534.X1 = 4.14222F;
			this.Line534.X2 = 4.14222F;
			this.Line534.Y1 = 2.76F;
			this.Line534.Y2 = 3.11F;
			// 
			// Line535
			// 
			this.Line535.Height = 0.3499999F;
			this.Line535.Left = 4.33622F;
			this.Line535.LineWeight = 1F;
			this.Line535.Name = "Line535";
			this.Line535.Top = 2.76F;
			this.Line535.Width = 0F;
			this.Line535.X1 = 4.33622F;
			this.Line535.X2 = 4.33622F;
			this.Line535.Y1 = 2.76F;
			this.Line535.Y2 = 3.11F;
			// 
			// Line536
			// 
			this.Line536.Height = 0.3499999F;
			this.Line536.Left = 4.530221F;
			this.Line536.LineWeight = 1F;
			this.Line536.Name = "Line536";
			this.Line536.Top = 2.76F;
			this.Line536.Width = 0F;
			this.Line536.X1 = 4.530221F;
			this.Line536.X2 = 4.530221F;
			this.Line536.Y1 = 2.76F;
			this.Line536.Y2 = 3.11F;
			// 
			// Line537
			// 
			this.Line537.Height = 0.3499999F;
			this.Line537.Left = 4.724221F;
			this.Line537.LineWeight = 1F;
			this.Line537.Name = "Line537";
			this.Line537.Top = 2.76F;
			this.Line537.Width = 0F;
			this.Line537.X1 = 4.724221F;
			this.Line537.X2 = 4.724221F;
			this.Line537.Y1 = 2.76F;
			this.Line537.Y2 = 3.11F;
			// 
			// Line538
			// 
			this.Line538.Height = 0.3499999F;
			this.Line538.Left = 5.00722F;
			this.Line538.LineWeight = 1F;
			this.Line538.Name = "Line538";
			this.Line538.Top = 2.76F;
			this.Line538.Width = 0F;
			this.Line538.X1 = 5.00722F;
			this.Line538.X2 = 5.00722F;
			this.Line538.Y1 = 2.76F;
			this.Line538.Y2 = 3.11F;
			// 
			// Line541
			// 
			this.Line541.Height = 0F;
			this.Line541.Left = 0.6057201F;
			this.Line541.LineWeight = 1F;
			this.Line541.Name = "Line541";
			this.Line541.Top = 3.44F;
			this.Line541.Width = 4.9675F;
			this.Line541.X1 = 0.6057201F;
			this.Line541.X2 = 5.57322F;
			this.Line541.Y1 = 3.44F;
			this.Line541.Y2 = 3.44F;
			// 
			// Line542
			// 
			this.Line542.Height = 0.3499999F;
			this.Line542.Left = 5.290221F;
			this.Line542.LineWeight = 1F;
			this.Line542.Name = "Line542";
			this.Line542.Top = 2.76F;
			this.Line542.Width = 0F;
			this.Line542.X1 = 5.290221F;
			this.Line542.X2 = 5.290221F;
			this.Line542.Y1 = 2.76F;
			this.Line542.Y2 = 3.11F;
			// 
			// Line616
			// 
			this.Line616.Height = 0.6570001F;
			this.Line616.Left = 0.8872204F;
			this.Line616.LineWeight = 1F;
			this.Line616.Name = "Line616";
			this.Line616.Top = 1.334945F;
			this.Line616.Width = 0F;
			this.Line616.X1 = 0.8872204F;
			this.Line616.X2 = 0.8872204F;
			this.Line616.Y1 = 1.334945F;
			this.Line616.Y2 = 1.991945F;
			// 
			// Line621
			// 
			this.Line621.Height = 0F;
			this.Line621.Left = 2.628F;
			this.Line621.LineWeight = 1F;
			this.Line621.Name = "Line621";
			this.Line621.Top = 2.28F;
			this.Line621.Width = 2.94522F;
			this.Line621.X1 = 2.628F;
			this.Line621.X2 = 5.57322F;
			this.Line621.Y1 = 2.28F;
			this.Line621.Y2 = 2.28F;
			// 
			// Line622
			// 
			this.Line622.Height = 0F;
			this.Line622.Left = 2.628F;
			this.Line622.LineWeight = 1F;
			this.Line622.Name = "Line622";
			this.Line622.Top = 2.44F;
			this.Line622.Width = 2.945F;
			this.Line622.X1 = 2.628F;
			this.Line622.X2 = 5.573F;
			this.Line622.Y1 = 2.44F;
			this.Line622.Y2 = 2.44F;
			// 
			// Line625
			// 
			this.Line625.Height = 0F;
			this.Line625.Left = 0.3862205F;
			this.Line625.LineWeight = 1F;
			this.Line625.Name = "Line625";
			this.Line625.Top = 0.02086614F;
			this.Line625.Width = 5.186999F;
			this.Line625.X1 = 0.3862205F;
			this.Line625.X2 = 5.57322F;
			this.Line625.Y1 = 0.02086614F;
			this.Line625.Y2 = 0.02086614F;
			// 
			// Line626
			// 
			this.Line626.Height = 0F;
			this.Line626.Left = 0.3862205F;
			this.Line626.LineWeight = 1F;
			this.Line626.Name = "Line626";
			this.Line626.Top = 0.1009449F;
			this.Line626.Width = 5.186999F;
			this.Line626.X1 = 0.3862205F;
			this.Line626.X2 = 5.57322F;
			this.Line626.Y1 = 0.1009449F;
			this.Line626.Y2 = 0.1009449F;
			// 
			// Line627
			// 
			this.Line627.Height = 0.108F;
			this.Line627.Left = 0.5327202F;
			this.Line627.LineWeight = 1F;
			this.Line627.Name = "Line627";
			this.Line627.Top = 0.1009449F;
			this.Line627.Width = 0F;
			this.Line627.X1 = 0.5327202F;
			this.Line627.X2 = 0.5327202F;
			this.Line627.Y1 = 0.1009449F;
			this.Line627.Y2 = 0.2089449F;
			// 
			// Line628
			// 
			this.Line628.Height = 0.108F;
			this.Line628.Left = 0.8247204F;
			this.Line628.LineWeight = 1F;
			this.Line628.Name = "Line628";
			this.Line628.Top = 0.1009449F;
			this.Line628.Width = 0F;
			this.Line628.X1 = 0.8247204F;
			this.Line628.X2 = 0.8247204F;
			this.Line628.Y1 = 0.1009449F;
			this.Line628.Y2 = 0.2089449F;
			// 
			// Line629
			// 
			this.Line629.Height = 0.108F;
			this.Line629.Left = 0.9707204F;
			this.Line629.LineWeight = 1F;
			this.Line629.Name = "Line629";
			this.Line629.Top = 0.1009449F;
			this.Line629.Width = 0F;
			this.Line629.X1 = 0.9707204F;
			this.Line629.X2 = 0.9707204F;
			this.Line629.Y1 = 0.1009449F;
			this.Line629.Y2 = 0.2089449F;
			// 
			// Line630
			// 
			this.Line630.Height = 0.108F;
			this.Line630.Left = 1.11672F;
			this.Line630.LineWeight = 1F;
			this.Line630.Name = "Line630";
			this.Line630.Top = 0.1009449F;
			this.Line630.Width = 0F;
			this.Line630.X1 = 1.11672F;
			this.Line630.X2 = 1.11672F;
			this.Line630.Y1 = 0.1009449F;
			this.Line630.Y2 = 0.2089449F;
			// 
			// Line631
			// 
			this.Line631.Height = 0.108F;
			this.Line631.Left = 1.26272F;
			this.Line631.LineWeight = 1F;
			this.Line631.Name = "Line631";
			this.Line631.Top = 0.1009449F;
			this.Line631.Width = 0F;
			this.Line631.X1 = 1.26272F;
			this.Line631.X2 = 1.26272F;
			this.Line631.Y1 = 0.1009449F;
			this.Line631.Y2 = 0.2089449F;
			// 
			// Line632
			// 
			this.Line632.Height = 0.108F;
			this.Line632.Left = 1.40872F;
			this.Line632.LineWeight = 1F;
			this.Line632.Name = "Line632";
			this.Line632.Top = 0.1009449F;
			this.Line632.Width = 0F;
			this.Line632.X1 = 1.40872F;
			this.Line632.X2 = 1.40872F;
			this.Line632.Y1 = 0.1009449F;
			this.Line632.Y2 = 0.2089449F;
			// 
			// Line633
			// 
			this.Line633.Height = 0.108F;
			this.Line633.Left = 1.55472F;
			this.Line633.LineWeight = 1F;
			this.Line633.Name = "Line633";
			this.Line633.Top = 0.1009449F;
			this.Line633.Width = 0F;
			this.Line633.X1 = 1.55472F;
			this.Line633.X2 = 1.55472F;
			this.Line633.Y1 = 0.1009449F;
			this.Line633.Y2 = 0.2089449F;
			// 
			// Line634
			// 
			this.Line634.Height = 0.108F;
			this.Line634.Left = 1.70072F;
			this.Line634.LineWeight = 1F;
			this.Line634.Name = "Line634";
			this.Line634.Top = 0.1009449F;
			this.Line634.Width = 0F;
			this.Line634.X1 = 1.70072F;
			this.Line634.X2 = 1.70072F;
			this.Line634.Y1 = 0.1009449F;
			this.Line634.Y2 = 0.2089449F;
			// 
			// Line635
			// 
			this.Line635.Height = 0.108F;
			this.Line635.Left = 1.84672F;
			this.Line635.LineWeight = 1F;
			this.Line635.Name = "Line635";
			this.Line635.Top = 0.1009449F;
			this.Line635.Width = 0F;
			this.Line635.X1 = 1.84672F;
			this.Line635.X2 = 1.84672F;
			this.Line635.Y1 = 0.1009449F;
			this.Line635.Y2 = 0.2089449F;
			// 
			// Line636
			// 
			this.Line636.Height = 0.108F;
			this.Line636.Left = 1.99272F;
			this.Line636.LineWeight = 1F;
			this.Line636.Name = "Line636";
			this.Line636.Top = 0.1009449F;
			this.Line636.Width = 0F;
			this.Line636.X1 = 1.99272F;
			this.Line636.X2 = 1.99272F;
			this.Line636.Y1 = 0.1009449F;
			this.Line636.Y2 = 0.2089449F;
			// 
			// Line637
			// 
			this.Line637.Height = 0.108F;
			this.Line637.Left = 2.13872F;
			this.Line637.LineWeight = 1F;
			this.Line637.Name = "Line637";
			this.Line637.Top = 0.1009449F;
			this.Line637.Width = 0F;
			this.Line637.X1 = 2.13872F;
			this.Line637.X2 = 2.13872F;
			this.Line637.Y1 = 0.1009449F;
			this.Line637.Y2 = 0.2089449F;
			// 
			// Line638
			// 
			this.Line638.Height = 0.108F;
			this.Line638.Left = 2.28472F;
			this.Line638.LineWeight = 1F;
			this.Line638.Name = "Line638";
			this.Line638.Top = 0.1009449F;
			this.Line638.Width = 0F;
			this.Line638.X1 = 2.28472F;
			this.Line638.X2 = 2.28472F;
			this.Line638.Y1 = 0.1009449F;
			this.Line638.Y2 = 0.2089449F;
			// 
			// Line639
			// 
			this.Line639.Height = 0.108F;
			this.Line639.Left = 2.43072F;
			this.Line639.LineWeight = 1F;
			this.Line639.Name = "Line639";
			this.Line639.Top = 0.1009449F;
			this.Line639.Width = 0F;
			this.Line639.X1 = 2.43072F;
			this.Line639.X2 = 2.43072F;
			this.Line639.Y1 = 0.1009449F;
			this.Line639.Y2 = 0.2089449F;
			// 
			// Line640
			// 
			this.Line640.Height = 0.108F;
			this.Line640.Left = 2.57672F;
			this.Line640.LineWeight = 1F;
			this.Line640.Name = "Line640";
			this.Line640.Top = 0.1009449F;
			this.Line640.Width = 0F;
			this.Line640.X1 = 2.57672F;
			this.Line640.X2 = 2.57672F;
			this.Line640.Y1 = 0.1009449F;
			this.Line640.Y2 = 0.2089449F;
			// 
			// Line641
			// 
			this.Line641.Height = 0.108F;
			this.Line641.Left = 2.72272F;
			this.Line641.LineWeight = 1F;
			this.Line641.Name = "Line641";
			this.Line641.Top = 0.1009449F;
			this.Line641.Width = 0F;
			this.Line641.X1 = 2.72272F;
			this.Line641.X2 = 2.72272F;
			this.Line641.Y1 = 0.1009449F;
			this.Line641.Y2 = 0.2089449F;
			// 
			// Line642
			// 
			this.Line642.Height = 0.188F;
			this.Line642.Left = 2.892664F;
			this.Line642.LineWeight = 1F;
			this.Line642.Name = "Line642";
			this.Line642.Top = 0.02094489F;
			this.Line642.Width = 0F;
			this.Line642.X1 = 2.892664F;
			this.Line642.X2 = 2.892664F;
			this.Line642.Y1 = 0.02094489F;
			this.Line642.Y2 = 0.2089449F;
			// 
			// Line643
			// 
			this.Line643.Height = 0.188F;
			this.Line643.Left = 3.47572F;
			this.Line643.LineWeight = 1F;
			this.Line643.Name = "Line643";
			this.Line643.Top = 0.02094489F;
			this.Line643.Width = 0F;
			this.Line643.X1 = 3.47572F;
			this.Line643.X2 = 3.47572F;
			this.Line643.Y1 = 0.02094489F;
			this.Line643.Y2 = 0.2089449F;
			// 
			// Line644
			// 
			this.Line644.Height = 0.188F;
			this.Line644.Left = 4.650722F;
			this.Line644.LineWeight = 1F;
			this.Line644.Name = "Line644";
			this.Line644.Top = 0.02094489F;
			this.Line644.Width = 0F;
			this.Line644.X1 = 4.650722F;
			this.Line644.X2 = 4.650722F;
			this.Line644.Y1 = 0.02094489F;
			this.Line644.Y2 = 0.2089449F;
			// 
			// Label1421
			// 
			this.Label1421.Height = 0.09F;
			this.Label1421.HyperLink = null;
			this.Label1421.Left = 2.89272F;
			this.Label1421.Name = "Label1421";
			this.Label1421.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1421.Text = "※　　種　別";
			this.Label1421.Top = 0.02094489F;
			this.Label1421.Width = 0.583F;
			// 
			// Label1422
			// 
			this.Label1422.Height = 0.09F;
			this.Label1422.HyperLink = null;
			this.Label1422.Left = 3.47572F;
			this.Label1422.Name = "Label1422";
			this.Label1422.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1422.Text = "※　　　　　整　理　番　号";
			this.Label1422.Top = 0.02094489F;
			this.Label1422.Width = 1.175F;
			// 
			// Label1423
			// 
			this.Label1423.Height = 0.08F;
			this.Label1423.HyperLink = null;
			this.Label1423.Left = 4.650722F;
			this.Label1423.Name = "Label1423";
			this.Label1423.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1423.Text = "※";
			this.Label1423.Top = 0.02094489F;
			this.Label1423.Width = 0.923F;
			// 
			// Label1424
			// 
			this.Label1424.Height = 0.08F;
			this.Label1424.HyperLink = null;
			this.Label1424.Left = 0.3867193F;
			this.Label1424.Name = "Label1424";
			this.Label1424.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1424.Text = "※";
			this.Label1424.Top = 0.02094489F;
			this.Label1424.Width = 2.506F;
			// 
			// Label1425
			// 
			this.Label1425.Height = 0.234F;
			this.Label1425.HyperLink = null;
			this.Label1425.Left = 0.6787205F;
			this.Label1425.Name = "Label1425";
			this.Label1425.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1425.Text = "所";
			this.Label1425.Top = 0.5999448F;
			this.Label1425.Width = 0.188F;
			// 
			// Line645
			// 
			this.Line645.Height = 0.156F;
			this.Line645.Left = 1.05572F;
			this.Line645.LineWeight = 1F;
			this.Line645.Name = "Line645";
			this.Line645.Top = 0.2089449F;
			this.Line645.Width = 0F;
			this.Line645.X1 = 1.05572F;
			this.Line645.X2 = 1.05572F;
			this.Line645.Y1 = 0.2089449F;
			this.Line645.Y2 = 0.3649449F;
			// 
			// Label1426
			// 
			this.Label1426.Height = 0.156F;
			this.Label1426.HyperLink = null;
			this.Label1426.Left = 0.6787205F;
			this.Label1426.Name = "Label1426";
			this.Label1426.Style = "font-size: 6pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.Label1426.Text = "※区分";
			this.Label1426.Top = 0.2089449F;
			this.Label1426.Width = 0.377F;
			// 
			// Label1203
			// 
			this.Label1203.Height = 0.155F;
			this.Label1203.HyperLink = null;
			this.Label1203.Left = 0.6987205F;
			this.Label1203.Name = "Label1203";
			this.Label1203.Style = "font-size: 6pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.Label1203.Text = "（摘要）に控除対象配偶者、扶養親族の氏名、続柄及び前職分の加算額、支払者等を記入してください。";
			this.Label1203.Top = 3.630945F;
			this.Label1203.Width = 3.9995F;
			// 
			// Line646
			// 
			this.Line646.Height = 0F;
			this.Line646.Left = 0.6787205F;
			this.Line646.LineWeight = 1F;
			this.Line646.Name = "Line646";
			this.Line646.Top = 0.3649449F;
			this.Line646.Width = 2.536999F;
			this.Line646.X1 = 0.6787205F;
			this.Line646.X2 = 3.21572F;
			this.Line646.Y1 = 0.3649449F;
			this.Line646.Y2 = 0.3649449F;
			// 
			// Label1427
			// 
			this.Label1427.Height = 0.208F;
			this.Label1427.HyperLink = null;
			this.Label1427.Left = 0.3862205F;
			this.Label1427.Name = "Label1427";
			this.Label1427.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1427.Text = "支払";
			this.Label1427.Top = 4.312613F;
			this.Label1427.Width = 0.292F;
			// 
			// Label1428
			// 
			this.Label1428.Height = 0.235F;
			this.Label1428.HyperLink = null;
			this.Label1428.Left = 0.6787216F;
			this.Label1428.Name = "Label1428";
			this.Label1428.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1428.Text = "住";
			this.Label1428.Top = 4.469111F;
			this.Label1428.Width = 0.188F;
			// 
			// ylyEdAddress1_4Text
			// 
			this.ylyEdAddress1_4Text.CanGrow = false;
			this.ylyEdAddress1_4Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_4Text.Height = 0.4685001F;
			this.ylyEdAddress1_4Text.Left = 0.8667212F;
			this.ylyEdAddress1_4Text.Name = "ylyEdAddress1_4Text";
			this.ylyEdAddress1_4Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_4Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_4Text.Top = 4.469111F;
			this.ylyEdAddress1_4Text.Width = 2.349F;
			// 
			// Label1429
			// 
			this.Label1429.Height = 0.313F;
			this.Label1429.HyperLink = null;
			this.Label1429.Left = 3.215222F;
			this.Label1429.Name = "Label1429";
			this.Label1429.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1429.Text = "氏";
			this.Label1429.Top = 4.312613F;
			this.Label1429.Width = 0.19F;
			// 
			// empCode3Text
			// 
			this.empCode3Text.CanGrow = false;
			this.empCode3Text.DataField = "EMP_CODE";
			this.empCode3Text.Height = 0.156F;
			this.empCode3Text.Left = 3.95422F;
			this.empCode3Text.Name = "empCode3Text";
			this.empCode3Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empCode3Text.Text = "0000000000";
			this.empCode3Text.Top = 4.312613F;
			this.empCode3Text.Width = 1.619001F;
			// 
			// postName3Text
			// 
			this.postName3Text.CanGrow = false;
			this.postName3Text.DataField = "POST_NAME";
			this.postName3Text.Height = 0.156F;
			this.postName3Text.Left = 3.95422F;
			this.postName3Text.Name = "postName3Text";
			this.postName3Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.postName3Text.Text = "ああああああああああ";
			this.postName3Text.Top = 4.625612F;
			this.postName3Text.Width = 1.619001F;
			// 
			// empNameKana3Text
			// 
			this.empNameKana3Text.CanGrow = false;
			this.empNameKana3Text.DataField = "EMP_REGIST_NAME_KANA";
			this.empNameKana3Text.Height = 0.156F;
			this.empNameKana3Text.Left = 3.95422F;
			this.empNameKana3Text.Name = "empNameKana3Text";
			this.empNameKana3Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameKana3Text.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.empNameKana3Text.Top = 4.468613F;
			this.empNameKana3Text.Width = 1.619001F;
			// 
			// Label1430
			// 
			this.Label1430.Height = 0.156F;
			this.Label1430.HyperLink = null;
			this.Label1430.Left = 3.40522F;
			this.Label1430.Name = "Label1430";
			this.Label1430.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1430.Text = "(受給者番号）";
			this.Label1430.Top = 4.312613F;
			this.Label1430.Width = 0.6055002F;
			// 
			// Label1431
			// 
			this.Label1431.Height = 0.156F;
			this.Label1431.HyperLink = null;
			this.Label1431.Left = 3.40522F;
			this.Label1431.Name = "Label1431";
			this.Label1431.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1431.Text = "(フリガナ）";
			this.Label1431.Top = 4.468613F;
			this.Label1431.Width = 0.5430002F;
			// 
			// Label1432
			// 
			this.Label1432.Height = 0.156F;
			this.Label1432.HyperLink = null;
			this.Label1432.Left = 3.40522F;
			this.Label1432.Name = "Label1432";
			this.Label1432.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1432.Text = "(役職名）";
			this.Label1432.Top = 4.624611F;
			this.Label1432.Width = 0.5430002F;
			// 
			// Label1433
			// 
			this.Label1433.Height = 0.173F;
			this.Label1433.HyperLink = null;
			this.Label1433.Left = 0.3857203F;
			this.Label1433.Name = "Label1433";
			this.Label1433.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1433.Text = "種　　別";
			this.Label1433.Top = 4.937613F;
			this.Label1433.Width = 0.938F;
			// 
			// Label1434
			// 
			this.Label1434.Height = 0.173F;
			this.Label1434.HyperLink = null;
			this.Label1434.Left = 1.324219F;
			this.Label1434.Name = "Label1434";
			this.Label1434.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1434.Text = "支　払　金　額";
			this.Label1434.Top = 4.937613F;
			this.Label1434.Width = 1.078F;
			// 
			// Label1435
			// 
			this.Label1435.Height = 0.173F;
			this.Label1435.HyperLink = null;
			this.Label1435.Left = 2.402221F;
			this.Label1435.Name = "Label1435";
			this.Label1435.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1435.Text = " 給与所得控除後の金額";
			this.Label1435.Top = 4.937613F;
			this.Label1435.Width = 1.063F;
			// 
			// Label1436
			// 
			this.Label1436.Height = 0.173F;
			this.Label1436.HyperLink = null;
			this.Label1436.Left = 3.46522F;
			this.Label1436.Name = "Label1436";
			this.Label1436.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1436.Text = "所得控除の額の合計額";
			this.Label1436.Top = 4.937613F;
			this.Label1436.Width = 1.063F;
			// 
			// class3Text
			// 
			this.class3Text.CanGrow = false;
			this.class3Text.DataField = "CLASS";
			this.class3Text.Height = 0.328F;
			this.class3Text.Left = 0.3862205F;
			this.class3Text.Name = "class3Text";
			this.class3Text.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.class3Text.Text = "ああああああ";
			this.class3Text.Top = 5.110611F;
			this.class3Text.Width = 0.937F;
			// 
			// paymntAmt3Text
			// 
			this.paymntAmt3Text.CanGrow = false;
			this.paymntAmt3Text.DataField = "PAYMNT_AMT";
			this.paymntAmt3Text.Height = 0.328F;
			this.paymntAmt3Text.Left = 1.42322F;
			this.paymntAmt3Text.Name = "paymntAmt3Text";
			this.paymntAmt3Text.OutputFormat = "#,##0";
			this.paymntAmt3Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.paymntAmt3Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.paymntAmt3Text.Top = 5.110611F;
			this.paymntAmt3Text.Width = 0.838F;
			// 
			// Label1438
			// 
			this.Label1438.Height = 0.125F;
			this.Label1438.HyperLink = null;
			this.Label1438.Left = 2.26122F;
			this.Label1438.Name = "Label1438";
			this.Label1438.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1438.Text = "円";
			this.Label1438.Top = 5.110611F;
			this.Label1438.Width = 0.141F;
			// 
			// slryInsmDedAmt3Text
			// 
			this.slryInsmDedAmt3Text.CanGrow = false;
			this.slryInsmDedAmt3Text.DataField = "SLRY_INSM_DED_AMT";
			this.slryInsmDedAmt3Text.Height = 0.328F;
			this.slryInsmDedAmt3Text.Left = 2.51072F;
			this.slryInsmDedAmt3Text.Name = "slryInsmDedAmt3Text";
			this.slryInsmDedAmt3Text.OutputFormat = "#,##0";
			this.slryInsmDedAmt3Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.slryInsmDedAmt3Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.slryInsmDedAmt3Text.Top = 5.110611F;
			this.slryInsmDedAmt3Text.Width = 0.8294993F;
			// 
			// Label1439
			// 
			this.Label1439.Height = 0.125F;
			this.Label1439.HyperLink = null;
			this.Label1439.Left = 3.34022F;
			this.Label1439.Name = "Label1439";
			this.Label1439.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1439.Text = "円";
			this.Label1439.Top = 5.110611F;
			this.Label1439.Width = 0.1245001F;
			// 
			// incmDedAmtSum3Text
			// 
			this.incmDedAmtSum3Text.CanGrow = false;
			this.incmDedAmtSum3Text.DataField = "INCM_DED_AMT_SUM";
			this.incmDedAmtSum3Text.Height = 0.328F;
			this.incmDedAmtSum3Text.Left = 3.46522F;
			this.incmDedAmtSum3Text.Name = "incmDedAmtSum3Text";
			this.incmDedAmtSum3Text.OutputFormat = "#,##0";
			this.incmDedAmtSum3Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmDedAmtSum3Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.incmDedAmtSum3Text.Top = 5.110611F;
			this.incmDedAmtSum3Text.Width = 0.938F;
			// 
			// Label1440
			// 
			this.Label1440.Height = 0.125F;
			this.Label1440.HyperLink = null;
			this.Label1440.Left = 4.40322F;
			this.Label1440.Name = "Label1440";
			this.Label1440.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1440.Text = "円";
			this.Label1440.Top = 5.110611F;
			this.Label1440.Width = 0.125F;
			// 
			// Label1441
			// 
			this.Label1441.Height = 0.125F;
			this.Label1441.HyperLink = null;
			this.Label1441.Left = 4.52822F;
			this.Label1441.Name = "Label1441";
			this.Label1441.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1441.Text = "内";
			this.Label1441.Top = 5.110611F;
			this.Label1441.Width = 0.125F;
			// 
			// ylyCollectTax3Text
			// 
			this.ylyCollectTax3Text.CanGrow = false;
			this.ylyCollectTax3Text.DataField = "YLY_COLLECT_TAX";
			this.ylyCollectTax3Text.Height = 0.328F;
			this.ylyCollectTax3Text.Left = 4.636721F;
			this.ylyCollectTax3Text.Name = "ylyCollectTax3Text";
			this.ylyCollectTax3Text.OutputFormat = "#,##0";
			this.ylyCollectTax3Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ylyCollectTax3Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.ylyCollectTax3Text.Top = 5.110611F;
			this.ylyCollectTax3Text.Width = 0.816F;
			// 
			// Label1442
			// 
			this.Label1442.Height = 0.125F;
			this.Label1442.HyperLink = null;
			this.Label1442.Left = 5.43422F;
			this.Label1442.Name = "Label1442";
			this.Label1442.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1442.Text = "円";
			this.Label1442.Top = 5.110611F;
			this.Label1442.Width = 0.134F;
			// 
			// Label1443
			// 
			this.Label1443.Height = 0.173F;
			this.Label1443.HyperLink = null;
			this.Label1443.Left = 4.52822F;
			this.Label1443.Name = "Label1443";
			this.Label1443.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1443.Text = "源　泉　徴　収　税　額";
			this.Label1443.Top = 4.937613F;
			this.Label1443.Width = 1.04F;
			// 
			// Label1444
			// 
			this.Label1444.Height = 0.157F;
			this.Label1444.HyperLink = null;
			this.Label1444.Left = 0.3862205F;
			this.Label1444.Name = "Label1444";
			this.Label1444.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1444.Text = "控除対象配偶";
			this.Label1444.Top = 5.438612F;
			this.Label1444.Width = 0.5F;
			// 
			// Label1445
			// 
			this.Label1445.Height = 0.173F;
			this.Label1445.HyperLink = null;
			this.Label1445.Left = 0.7862192F;
			this.Label1445.Name = "Label1445";
			this.Label1445.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1445.Text = "老人";
			this.Label1445.Top = 5.580112F;
			this.Label1445.Width = 0.1F;
			// 
			// Label1446
			// 
			this.Label1446.Height = 0.1875F;
			this.Label1446.HyperLink = null;
			this.Label1446.Left = 0.3862205F;
			this.Label1446.Name = "Label1446";
			this.Label1446.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1446.Text = "有";
			this.Label1446.Top = 5.752613F;
			this.Label1446.Width = 0.1F;
			// 
			// Label1447
			// 
			this.Label1447.Height = 0.188F;
			this.Label1447.HyperLink = null;
			this.Label1447.Left = 0.4862214F;
			this.Label1447.Name = "Label1447";
			this.Label1447.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1447.Text = "無";
			this.Label1447.Top = 5.752613F;
			this.Label1447.Width = 0.1F;
			// 
			// Label1448
			// 
			this.Label1448.Height = 0.188F;
			this.Label1448.HyperLink = null;
			this.Label1448.Left = 0.5867205F;
			this.Label1448.Name = "Label1448";
			this.Label1448.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1448.Text = "従有";
			this.Label1448.Top = 5.750529F;
			this.Label1448.Width = 0.1F;
			// 
			// Label1449
			// 
			this.Label1449.Height = 0.188F;
			this.Label1449.HyperLink = null;
			this.Label1449.Left = 0.6867204F;
			this.Label1449.Name = "Label1449";
			this.Label1449.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1449.Text = "従無";
			this.Label1449.Top = 5.750529F;
			this.Label1449.Width = 0.1F;
			// 
			// sposOldAgeType2_3Text
			// 
			this.sposOldAgeType2_3Text.CanGrow = false;
			this.sposOldAgeType2_3Text.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeType2_3Text.Height = 0.155F;
			this.sposOldAgeType2_3Text.Left = 0.7862192F;
			this.sposOldAgeType2_3Text.Name = "sposOldAgeType2_3Text";
			this.sposOldAgeType2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeType2_3Text.Text = "0";
			this.sposOldAgeType2_3Text.Top = 5.940612F;
			this.sposOldAgeType2_3Text.Width = 0.1F;
			// 
			// dedSposexet3Text
			// 
			this.dedSposexet3Text.CanGrow = false;
			this.dedSposexet3Text.DataField = "DED_SPOS_EXIST";
			this.dedSposexet3Text.Height = 0.155F;
			this.dedSposexet3Text.Left = 0.3862205F;
			this.dedSposexet3Text.Name = "dedSposexet3Text";
			this.dedSposexet3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposexet3Text.Text = "0";
			this.dedSposexet3Text.Top = 5.940612F;
			this.dedSposexet3Text.Width = 0.1F;
			// 
			// dedSposN1_3Text
			// 
			this.dedSposN1_3Text.CanGrow = false;
			this.dedSposN1_3Text.DataField = "DED_SPOS_N";
			this.dedSposN1_3Text.Height = 0.155F;
			this.dedSposN1_3Text.Left = 0.4862214F;
			this.dedSposN1_3Text.Name = "dedSposN1_3Text";
			this.dedSposN1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN1_3Text.Text = "0";
			this.dedSposN1_3Text.Top = 5.940612F;
			this.dedSposN1_3Text.Width = 0.1F;
			// 
			// dedSposExist2_3Text
			// 
			this.dedSposExist2_3Text.CanGrow = false;
			this.dedSposExist2_3Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExist2_3Text.Height = 0.155F;
			this.dedSposExist2_3Text.Left = 0.5862203F;
			this.dedSposExist2_3Text.Name = "dedSposExist2_3Text";
			this.dedSposExist2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExist2_3Text.Text = "0";
			this.dedSposExist2_3Text.Top = 5.940612F;
			this.dedSposExist2_3Text.Width = 0.1F;
			// 
			// dedSposN2_3Text
			// 
			this.dedSposN2_3Text.CanGrow = false;
			this.dedSposN2_3Text.DataField = "DED_SPOS_N2";
			this.dedSposN2_3Text.Height = 0.155F;
			this.dedSposN2_3Text.Left = 0.6862202F;
			this.dedSposN2_3Text.Name = "dedSposN2_3Text";
			this.dedSposN2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN2_3Text.Text = "0";
			this.dedSposN2_3Text.Top = 5.940612F;
			this.dedSposN2_3Text.Width = 0.1F;
			// 
			// Label1450
			// 
			this.Label1450.Height = 0.157F;
			this.Label1450.HyperLink = null;
			this.Label1450.Left = 0.8872204F;
			this.Label1450.Name = "Label1450";
			this.Label1450.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1450.Text = "配偶者特別";
			this.Label1450.Top = 5.438612F;
			this.Label1450.Width = 0.593F;
			// 
			// Label1451
			// 
			this.Label1451.Height = 0.125F;
			this.Label1451.HyperLink = null;
			this.Label1451.Left = 1.38622F;
			this.Label1451.Name = "Label1451";
			this.Label1451.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1451.Text = "円";
			this.Label1451.Top = 5.752613F;
			this.Label1451.Width = 0.1F;
			// 
			// sposExtDedAmt3Text
			// 
			this.sposExtDedAmt3Text.CanGrow = false;
			this.sposExtDedAmt3Text.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmt3Text.Height = 0.343F;
			this.sposExtDedAmt3Text.Left = 0.8852201F;
			this.sposExtDedAmt3Text.Name = "sposExtDedAmt3Text";
			this.sposExtDedAmt3Text.OutputFormat = "#,##0";
			this.sposExtDedAmt3Text.Style = "font-size: 5.8pt; text-align: right; vertical-align: bottom; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposExtDedAmt3Text.Text = "Z,ZZ6,ZZ6";
			this.sposExtDedAmt3Text.Top = 5.750612F;
			this.sposExtDedAmt3Text.Width = 0.5629997F;
			// 
			// Label1452
			// 
			this.Label1452.Height = 0.104F;
			this.Label1452.HyperLink = null;
			this.Label1452.Left = 1.48022F;
			this.Label1452.Name = "Label1452";
			this.Label1452.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1452.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.Label1452.Top = 5.438612F;
			this.Label1452.Width = 1.317F;
			// 
			// Label1453
			// 
			this.Label1453.Height = 0.104F;
			this.Label1453.HyperLink = null;
			this.Label1453.Left = 1.48022F;
			this.Label1453.Name = "Label1453";
			this.Label1453.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1453.Text = "     　　（配偶者を除く）";
			this.Label1453.Top = 5.542613F;
			this.Label1453.Width = 1.317F;
			// 
			// Label1454
			// 
			this.Label1454.Height = 0.105F;
			this.Label1454.HyperLink = null;
			this.Label1454.Left = 1.48022F;
			this.Label1454.Name = "Label1454";
			this.Label1454.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1454.Text = "特　定";
			this.Label1454.Top = 5.646614F;
			this.Label1454.Width = 0.386F;
			// 
			// Label1455
			// 
			this.Label1455.Height = 0.105F;
			this.Label1455.HyperLink = null;
			this.Label1455.Left = 1.866221F;
			this.Label1455.Name = "Label1455";
			this.Label1455.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1455.Text = "老　人";
			this.Label1455.Top = 5.646614F;
			this.Label1455.Width = 0.547F;
			// 
			// Label1456
			// 
			this.Label1456.Height = 0.105F;
			this.Label1456.HyperLink = null;
			this.Label1456.Left = 2.41322F;
			this.Label1456.Name = "Label1456";
			this.Label1456.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1456.Text = "その他";
			this.Label1456.Top = 5.646614F;
			this.Label1456.Width = 0.38F;
			// 
			// Label1457
			// 
			this.Label1457.Height = 0.125F;
			this.Label1457.HyperLink = null;
			this.Label1457.Left = 1.54972F;
			this.Label1457.Name = "Label1457";
			this.Label1457.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1457.Text = "人";
			this.Label1457.Top = 5.75311F;
			this.Label1457.Width = 0.099F;
			// 
			// specDpndNum1_4Text
			// 
			this.specDpndNum1_4Text.CanGrow = false;
			this.specDpndNum1_4Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_4Text.Height = 0.2205F;
			this.specDpndNum1_4Text.Left = 1.51072F;
			this.specDpndNum1_4Text.Name = "specDpndNum1_4Text";
			this.specDpndNum1_4Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_4Text.Text = "Z6";
			this.specDpndNum1_4Text.Top = 5.875113F;
			this.specDpndNum1_4Text.Width = 0.125F;
			// 
			// specDpndNum2_4Text
			// 
			this.specDpndNum2_4Text.CanGrow = false;
			this.specDpndNum2_4Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_4Text.Height = 0.343F;
			this.specDpndNum2_4Text.Left = 1.668219F;
			this.specDpndNum2_4Text.Name = "specDpndNum2_4Text";
			this.specDpndNum2_4Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum2_4Text.Text = "Z6";
			this.specDpndNum2_4Text.Top = 5.752613F;
			this.specDpndNum2_4Text.Width = 0.1550002F;
			// 
			// Label1458
			// 
			this.Label1458.Height = 0.125F;
			this.Label1458.HyperLink = null;
			this.Label1458.Left = 1.668219F;
			this.Label1458.Name = "Label1458";
			this.Label1458.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1458.Text = "従人";
			this.Label1458.Top = 5.752613F;
			this.Label1458.Width = 0.198F;
			// 
			// Label1459
			// 
			this.Label1459.Height = 0.125F;
			this.Label1459.HyperLink = null;
			this.Label1459.Left = 1.866221F;
			this.Label1459.Name = "Label1459";
			this.Label1459.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1459.Text = "内";
			this.Label1459.Top = 5.752613F;
			this.Label1459.Width = 0.11F;
			// 
			// liveTgtAgePreNum3Text
			// 
			this.liveTgtAgePreNum3Text.CanGrow = false;
			this.liveTgtAgePreNum3Text.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNum3Text.Height = 0.2209992F;
			this.liveTgtAgePreNum3Text.Left = 1.86672F;
			this.liveTgtAgePreNum3Text.Name = "liveTgtAgePreNum3Text";
			this.liveTgtAgePreNum3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNum3Text.Text = "Z6";
			this.liveTgtAgePreNum3Text.Top = 5.875113F;
			this.liveTgtAgePreNum3Text.Width = 0.11F;
			// 
			// Label1460
			// 
			this.Label1460.Height = 0.125F;
			this.Label1460.HyperLink = null;
			this.Label1460.Left = 2.07022F;
			this.Label1460.Name = "Label1460";
			this.Label1460.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1460.Text = "人";
			this.Label1460.Top = 5.752613F;
			this.Label1460.Width = 0.125F;
			// 
			// agePreNum1_3Text
			// 
			this.agePreNum1_3Text.CanGrow = false;
			this.agePreNum1_3Text.DataField = "AGE_PRE_NUM";
			this.agePreNum1_3Text.Height = 0.343F;
			this.agePreNum1_3Text.Left = 1.976219F;
			this.agePreNum1_3Text.Name = "agePreNum1_3Text";
			this.agePreNum1_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum1_3Text.Text = "Z6";
			this.agePreNum1_3Text.Top = 5.752613F;
			this.agePreNum1_3Text.Width = 0.1594997F;
			// 
			// agePreNum2_3Text
			// 
			this.agePreNum2_3Text.CanGrow = false;
			this.agePreNum2_3Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2_3Text.Height = 0.343F;
			this.agePreNum2_3Text.Left = 2.19522F;
			this.agePreNum2_3Text.Name = "agePreNum2_3Text";
			this.agePreNum2_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum2_3Text.Text = "Z6";
			this.agePreNum2_3Text.Top = 5.752613F;
			this.agePreNum2_3Text.Width = 0.1905003F;
			// 
			// Label1461
			// 
			this.Label1461.Height = 0.125F;
			this.Label1461.HyperLink = null;
			this.Label1461.Left = 2.19522F;
			this.Label1461.Name = "Label1461";
			this.Label1461.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1461.Text = "従人";
			this.Label1461.Top = 5.752613F;
			this.Label1461.Width = 0.219F;
			// 
			// Label1462
			// 
			this.Label1462.Height = 0.125F;
			this.Label1462.HyperLink = null;
			this.Label1462.Left = 2.480219F;
			this.Label1462.Name = "Label1462";
			this.Label1462.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1462.Text = "人";
			this.Label1462.Top = 5.752613F;
			this.Label1462.Width = 0.125F;
			// 
			// othersDpndNum1_3Text
			// 
			this.othersDpndNum1_3Text.CanGrow = false;
			this.othersDpndNum1_3Text.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNum1_3Text.Height = 0.343F;
			this.othersDpndNum1_3Text.Left = 2.41322F;
			this.othersDpndNum1_3Text.Name = "othersDpndNum1_3Text";
			this.othersDpndNum1_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum1_3Text.Text = "Z6";
			this.othersDpndNum1_3Text.Top = 5.752613F;
			this.othersDpndNum1_3Text.Width = 0.1599999F;
			// 
			// Label1463
			// 
			this.Label1463.Height = 0.125F;
			this.Label1463.HyperLink = null;
			this.Label1463.Left = 2.595721F;
			this.Label1463.Name = "Label1463";
			this.Label1463.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1463.Text = "従人";
			this.Label1463.Top = 5.75311F;
			this.Label1463.Width = 0.2180004F;
			// 
			// othersDpndNum2_3Text
			// 
			this.othersDpndNum2_3Text.CanGrow = false;
			this.othersDpndNum2_3Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2_3Text.Height = 0.343F;
			this.othersDpndNum2_3Text.Left = 2.605219F;
			this.othersDpndNum2_3Text.Name = "othersDpndNum2_3Text";
			this.othersDpndNum2_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum2_3Text.Text = "Z6";
			this.othersDpndNum2_3Text.Top = 5.752613F;
			this.othersDpndNum2_3Text.Width = 0.1555004F;
			// 
			// Label1464
			// 
			this.Label1464.Height = 0.104F;
			this.Label1464.HyperLink = null;
			this.Label1464.Left = 2.797219F;
			this.Label1464.Name = "Label1464";
			this.Label1464.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1464.Text = "障害者の数";
			this.Label1464.Top = 5.438612F;
			this.Label1464.Width = 0.5249999F;
			// 
			// Label1465
			// 
			this.Label1465.Height = 0.105F;
			this.Label1465.HyperLink = null;
			this.Label1465.Left = 2.797219F;
			this.Label1465.Name = "Label1465";
			this.Label1465.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1465.Text = "特 別";
			this.Label1465.Top = 5.646614F;
			this.Label1465.Width = 0.25F;
			// 
			// liveTgtExtHandiNum1_3Text
			// 
			this.liveTgtExtHandiNum1_3Text.CanGrow = false;
			this.liveTgtExtHandiNum1_3Text.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtExtHandiNum1_3Text.Height = 0.343F;
			this.liveTgtExtHandiNum1_3Text.Left = 2.797219F;
			this.liveTgtExtHandiNum1_3Text.Name = "liveTgtExtHandiNum1_3Text";
			this.liveTgtExtHandiNum1_3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtExtHandiNum1_3Text.Text = "Z6";
			this.liveTgtExtHandiNum1_3Text.Top = 5.752613F;
			this.liveTgtExtHandiNum1_3Text.Width = 0.125F;
			// 
			// extHandiNum3Text
			// 
			this.extHandiNum3Text.CanGrow = false;
			this.extHandiNum3Text.DataField = "EXT_HANDI_NUM";
			this.extHandiNum3Text.Height = 0.343F;
			this.extHandiNum3Text.Left = 2.922221F;
			this.extHandiNum3Text.Name = "extHandiNum3Text";
			this.extHandiNum3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHandiNum3Text.Text = "Z6";
			this.extHandiNum3Text.Top = 5.752613F;
			this.extHandiNum3Text.Width = 0.125F;
			// 
			// Label1466
			// 
			this.Label1466.Height = 0.125F;
			this.Label1466.HyperLink = null;
			this.Label1466.Left = 2.922221F;
			this.Label1466.Name = "Label1466";
			this.Label1466.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1466.Text = "人";
			this.Label1466.Top = 5.752613F;
			this.Label1466.Width = 0.125F;
			// 
			// Label1467
			// 
			this.Label1467.Height = 0.125F;
			this.Label1467.HyperLink = null;
			this.Label1467.Left = 2.797219F;
			this.Label1467.Name = "Label1467";
			this.Label1467.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1467.Text = "内";
			this.Label1467.Top = 5.752613F;
			this.Label1467.Width = 0.125F;
			// 
			// Label1468
			// 
			this.Label1468.Height = 0.104F;
			this.Label1468.HyperLink = null;
			this.Label1468.Left = 2.797219F;
			this.Label1468.Name = "Label1468";
			this.Label1468.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1468.Text = "（本人を除く）";
			this.Label1468.Top = 5.542613F;
			this.Label1468.Width = 0.5249999F;
			// 
			// Label1469
			// 
			this.Label1469.Height = 0.105F;
			this.Label1469.HyperLink = null;
			this.Label1469.Left = 3.047221F;
			this.Label1469.Name = "Label1469";
			this.Label1469.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1469.Text = "その他";
			this.Label1469.Top = 5.646614F;
			this.Label1469.Width = 0.275F;
			// 
			// Label1470
			// 
			this.Label1470.Height = 0.125F;
			this.Label1470.HyperLink = null;
			this.Label1470.Left = 3.19722F;
			this.Label1470.Name = "Label1470";
			this.Label1470.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1470.Text = "人";
			this.Label1470.Top = 5.752613F;
			this.Label1470.Width = 0.125F;
			// 
			// HandiNum3Text
			// 
			this.HandiNum3Text.CanGrow = false;
			this.HandiNum3Text.DataField = "HANDI_NUM";
			this.HandiNum3Text.Height = 0.343F;
			this.HandiNum3Text.Left = 3.047221F;
			this.HandiNum3Text.Name = "HandiNum3Text";
			this.HandiNum3Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HandiNum3Text.Text = "Z6";
			this.HandiNum3Text.Top = 5.752613F;
			this.HandiNum3Text.Width = 0.2135F;
			// 
			// Label1471
			// 
			this.Label1471.Height = 0.156F;
			this.Label1471.HyperLink = null;
			this.Label1471.Left = 3.32222F;
			this.Label1471.Name = "Label1471";
			this.Label1471.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1471.Text = "社会保険料";
			this.Label1471.Top = 5.438612F;
			this.Label1471.Width = 0.532F;
			// 
			// Label1472
			// 
			this.Label1472.Height = 0.125F;
			this.Label1472.HyperLink = null;
			this.Label1472.Left = 3.724221F;
			this.Label1472.Name = "Label1472";
			this.Label1472.Style = "font-size: 6pt; text-align: right; vertical-align: top; ddo-char-set: 1";
			this.Label1472.Text = "円";
			this.Label1472.Top = 5.752613F;
			this.Label1472.Width = 0.125F;
			// 
			// smlScaleCompCpratAmt3Text
			// 
			this.smlScaleCompCpratAmt3Text.CanGrow = false;
			this.smlScaleCompCpratAmt3Text.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.smlScaleCompCpratAmt3Text.Height = 0.24F;
			this.smlScaleCompCpratAmt3Text.Left = 3.32222F;
			this.smlScaleCompCpratAmt3Text.Name = "smlScaleCompCpratAmt3Text";
			this.smlScaleCompCpratAmt3Text.OutputFormat = "#,##0";
			this.smlScaleCompCpratAmt3Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.smlScaleCompCpratAmt3Text.Text = "ZZ,ZZZ,ZZ6";
			this.smlScaleCompCpratAmt3Text.Top = 5.752613F;
			this.smlScaleCompCpratAmt3Text.Width = 0.532F;
			// 
			// Label1473
			// 
			this.Label1473.Height = 0.156F;
			this.Label1473.HyperLink = null;
			this.Label1473.Left = 3.85422F;
			this.Label1473.Name = "Label1473";
			this.Label1473.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1473.Text = "生命保険料";
			this.Label1473.Top = 5.438612F;
			this.Label1473.Width = 0.563F;
			// 
			// Label1474
			// 
			this.Label1474.Height = 0.125F;
			this.Label1474.HyperLink = null;
			this.Label1474.Left = 4.314221F;
			this.Label1474.Name = "Label1474";
			this.Label1474.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1474.Text = "円";
			this.Label1474.Top = 5.752613F;
			this.Label1474.Width = 0.11F;
			// 
			// lifeInsDedAmt3Text
			// 
			this.lifeInsDedAmt3Text.CanGrow = false;
			this.lifeInsDedAmt3Text.DataField = "LIFE_INS_DED_AMT";
			this.lifeInsDedAmt3Text.Height = 0.1875F;
			this.lifeInsDedAmt3Text.Left = 3.854719F;
			this.lifeInsDedAmt3Text.Name = "lifeInsDedAmt3Text";
			this.lifeInsDedAmt3Text.OutputFormat = "#,##0";
			this.lifeInsDedAmt3Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsDedAmt3Text.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsDedAmt3Text.Top = 5.915112F;
			this.lifeInsDedAmt3Text.Width = 0.563F;
			// 
			// Label1475
			// 
			this.Label1475.Height = 0.156F;
			this.Label1475.HyperLink = null;
			this.Label1475.Left = 4.96822F;
			this.Label1475.Name = "Label1475";
			this.Label1475.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1475.Text = "住宅借入金等";
			this.Label1475.Top = 5.438612F;
			this.Label1475.Width = 0.605F;
			// 
			// Label1476
			// 
			this.Label1476.Height = 0.125F;
			this.Label1476.HyperLink = null;
			this.Label1476.Left = 5.43622F;
			this.Label1476.Name = "Label1476";
			this.Label1476.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1476.Text = "円";
			this.Label1476.Top = 5.752613F;
			this.Label1476.Width = 0.1370001F;
			// 
			// housingObtDedAmt3Text
			// 
			this.housingObtDedAmt3Text.CanGrow = false;
			this.housingObtDedAmt3Text.DataField = "HOUSING_OBT_DED_AMT";
			this.housingObtDedAmt3Text.Height = 0.1875F;
			this.housingObtDedAmt3Text.Left = 4.96872F;
			this.housingObtDedAmt3Text.Name = "housingObtDedAmt3Text";
			this.housingObtDedAmt3Text.OutputFormat = "#,##0";
			this.housingObtDedAmt3Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.housingObtDedAmt3Text.Text = "ZZ,ZZZ,ZZ6";
			this.housingObtDedAmt3Text.Top = 5.915112F;
			this.housingObtDedAmt3Text.Width = 0.605F;
			// 
			// summary0Digit3Text
			// 
			this.summary0Digit3Text.CanGrow = false;
			this.summary0Digit3Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit3Text.Height = 0.125F;
			this.summary0Digit3Text.Left = 0.406F;
			this.summary0Digit3Text.MultiLine = false;
			this.summary0Digit3Text.Name = "summary0Digit3Text";
			this.summary0Digit3Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit3Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit3Text.Top = 6.1F;
			this.summary0Digit3Text.Width = 3.695F;
			// 
			// Label1478
			// 
			this.Label1478.Height = 0.153F;
			this.Label1478.HyperLink = null;
			this.Label1478.Left = 2.649F;
			this.Label1478.Name = "Label1478";
			this.Label1478.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1478.Text = "配偶者の合計所得";
			this.Label1478.Top = 6.238F;
			this.Label1478.Width = 0.67F;
			// 
			// Label1479
			// 
			this.Label1479.Height = 0.153F;
			this.Label1479.HyperLink = null;
			this.Label1479.Left = 4.081F;
			this.Label1479.Name = "Label1479";
			this.Label1479.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1479.Text = "旧個人年金保険料の金額";
			this.Label1479.Top = 6.391F;
			this.Label1479.Width = 0.755F;
			// 
			// Label1480
			// 
			this.Label1480.Height = 0.153F;
			this.Label1480.HyperLink = null;
			this.Label1480.Left = 4.081F;
			this.Label1480.Name = "Label1480";
			this.Label1480.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1480.Text = "長期損害保険料の金額";
			this.Label1480.Top = 6.561F;
			this.Label1480.Width = 0.755F;
			// 
			// sposSumIncmAmt3Text
			// 
			this.sposSumIncmAmt3Text.CanGrow = false;
			this.sposSumIncmAmt3Text.DataField = "SPOS_SUM_INCM_AMT";
			this.sposSumIncmAmt3Text.Height = 0.153F;
			this.sposSumIncmAmt3Text.Left = 3.319F;
			this.sposSumIncmAmt3Text.Name = "sposSumIncmAmt3Text";
			this.sposSumIncmAmt3Text.OutputFormat = "#,##0";
			this.sposSumIncmAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposSumIncmAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.sposSumIncmAmt3Text.Top = 6.238F;
			this.sposSumIncmAmt3Text.Width = 0.647F;
			// 
			// Label1481
			// 
			this.Label1481.Height = 0.161F;
			this.Label1481.HyperLink = null;
			this.Label1481.Left = 5.448F;
			this.Label1481.Name = "Label1481";
			this.Label1481.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1481.Text = "円";
			this.Label1481.Top = 6.085F;
			this.Label1481.Width = 0.125F;
			// 
			// Label1482
			// 
			this.Label1482.Height = 0.161F;
			this.Label1482.HyperLink = null;
			this.Label1482.Left = 5.448F;
			this.Label1482.Name = "Label1482";
			this.Label1482.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1482.Text = "円";
			this.Label1482.Top = 6.391F;
			this.Label1482.Width = 0.125F;
			// 
			// lifeInsPensAmt3Text
			// 
			this.lifeInsPensAmt3Text.CanGrow = false;
			this.lifeInsPensAmt3Text.DataField = "LIFE_INS_PENS_AMT";
			this.lifeInsPensAmt3Text.Height = 0.153F;
			this.lifeInsPensAmt3Text.Left = 4.811F;
			this.lifeInsPensAmt3Text.Name = "lifeInsPensAmt3Text";
			this.lifeInsPensAmt3Text.OutputFormat = "#,##0";
			this.lifeInsPensAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.lifeInsPensAmt3Text.Text = "ZZ,ZZZ,ZZZ,ZZ6";
			this.lifeInsPensAmt3Text.Top = 6.391F;
			this.lifeInsPensAmt3Text.Width = 0.647F;
			// 
			// Label1483
			// 
			this.Label1483.Height = 0.161F;
			this.Label1483.HyperLink = null;
			this.Label1483.Left = 5.448F;
			this.Label1483.Name = "Label1483";
			this.Label1483.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1483.Text = "円";
			this.Label1483.Top = 6.551F;
			this.Label1483.Width = 0.125F;
			// 
			// nolfInsLongProdAmt3Text
			// 
			this.nolfInsLongProdAmt3Text.CanGrow = false;
			this.nolfInsLongProdAmt3Text.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmt3Text.Height = 0.153F;
			this.nolfInsLongProdAmt3Text.Left = 4.811F;
			this.nolfInsLongProdAmt3Text.Name = "nolfInsLongProdAmt3Text";
			this.nolfInsLongProdAmt3Text.OutputFormat = "#,##0";
			this.nolfInsLongProdAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.nolfInsLongProdAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmt3Text.Top = 6.551F;
			this.nolfInsLongProdAmt3Text.Width = 0.647F;
			// 
			// Label1502
			// 
			this.Label1502.Height = 0.17F;
			this.Label1502.HyperLink = null;
			this.Label1502.Left = 2.888F;
			this.Label1502.Name = "Label1502";
			this.Label1502.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1502.Text = "就職";
			this.Label1502.Top = 6.862F;
			this.Label1502.Width = 0.2F;
			// 
			// Label1503
			// 
			this.Label1503.Height = 0.17F;
			this.Label1503.HyperLink = null;
			this.Label1503.Left = 3.529F;
			this.Label1503.Name = "Label1503";
			this.Label1503.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1503.Text = "月";
			this.Label1503.Top = 6.862F;
			this.Label1503.Width = 0.192F;
			// 
			// Label1504
			// 
			this.Label1504.Height = 0.17F;
			this.Label1504.HyperLink = null;
			this.Label1504.Left = 3.288F;
			this.Label1504.Name = "Label1504";
			this.Label1504.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1504.Text = "年";
			this.Label1504.Top = 6.862F;
			this.Label1504.Width = 0.241F;
			// 
			// Label1505
			// 
			this.Label1505.Height = 0.17F;
			this.Label1505.HyperLink = null;
			this.Label1505.Left = 3.721F;
			this.Label1505.Name = "Label1505";
			this.Label1505.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1505.Text = "日";
			this.Label1505.Top = 6.862F;
			this.Label1505.Width = 0.228F;
			// 
			// Label1506
			// 
			this.Label1506.Height = 0.16F;
			this.Label1506.HyperLink = null;
			this.Label1506.Left = 3.948F;
			this.Label1506.Name = "Label1506";
			this.Label1506.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1506.Text = "受給者生年月日";
			this.Label1506.Top = 6.702F;
			this.Label1506.Width = 1.625F;
			// 
			// Label1507
			// 
			this.Label1507.Height = 0.17F;
			this.Label1507.HyperLink = null;
			this.Label1507.Left = 3.948F;
			this.Label1507.Name = "Label1507";
			this.Label1507.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1507.Text = "明";
			this.Label1507.Top = 6.862F;
			this.Label1507.Width = 0.194F;
			// 
			// Label1508
			// 
			this.Label1508.Height = 0.17F;
			this.Label1508.HyperLink = null;
			this.Label1508.Left = 4.724F;
			this.Label1508.Name = "Label1508";
			this.Label1508.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1508.Text = "年";
			this.Label1508.Top = 6.862F;
			this.Label1508.Width = 0.283F;
			// 
			// TempName3Text
			// 
			this.TempName3Text.CanGrow = false;
			this.TempName3Text.DataField = "EMP_REGIST_NAME";
			this.TempName3Text.Height = 0.157F;
			this.TempName3Text.Left = 3.95422F;
			this.TempName3Text.Name = "TempName3Text";
			this.TempName3Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.TempName3Text.Text = "あああああああああああああああ";
			this.TempName3Text.Top = 4.781612F;
			this.TempName3Text.Width = 1.619001F;
			// 
			// Label1509
			// 
			this.Label1509.Height = 0.16F;
			this.Label1509.HyperLink = null;
			this.Label1509.Left = 2.885F;
			this.Label1509.Name = "Label1509";
			this.Label1509.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1509.Text = "中途就・退職";
			this.Label1509.Top = 6.702F;
			this.Label1509.Width = 1.063F;
			// 
			// minrType3Text
			// 
			this.minrType3Text.CanGrow = false;
			this.minrType3Text.DataField = "MINR_TYPE";
			this.minrType3Text.Height = 0.17F;
			this.minrType3Text.Left = 0.613F;
			this.minrType3Text.Name = "minrType3Text";
			this.minrType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrType3Text.Text = "0";
			this.minrType3Text.Top = 7.035F;
			this.minrType3Text.Width = 0.2F;
			// 
			// latter3Text
			// 
			this.latter3Text.CanGrow = false;
			this.latter3Text.DataField = "LATTER";
			this.latter3Text.Height = 0.17F;
			this.latter3Text.Left = 1.486F;
			this.latter3Text.Name = "latter3Text";
			this.latter3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latter3Text.Text = "0";
			this.latter3Text.Top = 7.035F;
			this.latter3Text.Width = 0.2F;
			// 
			// extHandiType3Text
			// 
			this.extHandiType3Text.CanGrow = false;
			this.extHandiType3Text.DataField = "EXT_HANDI_TYPE";
			this.extHandiType3Text.Height = 0.17F;
			this.extHandiType3Text.Left = 1.686F;
			this.extHandiType3Text.Name = "extHandiType3Text";
			this.extHandiType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiType3Text.Text = "0";
			this.extHandiType3Text.Top = 7.035F;
			this.extHandiType3Text.Width = 0.2F;
			// 
			// HandiType3Text
			// 
			this.HandiType3Text.CanGrow = false;
			this.HandiType3Text.DataField = "HANDI_TYPE";
			this.HandiType3Text.Height = 0.17F;
			this.HandiType3Text.Left = 1.886F;
			this.HandiType3Text.Name = "HandiType3Text";
			this.HandiType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HandiType3Text.Text = "0";
			this.HandiType3Text.Top = 7.035F;
			this.HandiType3Text.Width = 0.2F;
			// 
			// widowType3Text
			// 
			this.widowType3Text.CanGrow = false;
			this.widowType3Text.DataField = "WIDOW_TYPE";
			this.widowType3Text.Height = 0.17F;
			this.widowType3Text.Left = 2.086F;
			this.widowType3Text.Name = "widowType3Text";
			this.widowType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowType3Text.Text = "0";
			this.widowType3Text.Top = 7.035F;
			this.widowType3Text.Width = 0.2F;
			// 
			// extWidowType3Text
			// 
			this.extWidowType3Text.CanGrow = false;
			this.extWidowType3Text.DataField = "EXT_WIDOW_TYPE";
			this.extWidowType3Text.Height = 0.17F;
			this.extWidowType3Text.Left = 2.286F;
			this.extWidowType3Text.Name = "extWidowType3Text";
			this.extWidowType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowType3Text.Text = "0";
			this.extWidowType3Text.Top = 7.035F;
			this.extWidowType3Text.Width = 0.2F;
			// 
			// widomType3Text
			// 
			this.widomType3Text.CanGrow = false;
			this.widomType3Text.DataField = "WIDOM_TYPE";
			this.widomType3Text.Height = 0.17F;
			this.widomType3Text.Left = 2.486F;
			this.widomType3Text.Name = "widomType3Text";
			this.widomType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomType3Text.Text = "0";
			this.widomType3Text.Top = 7.035F;
			this.widomType3Text.Width = 0.2F;
			// 
			// wrkStdType3Text
			// 
			this.wrkStdType3Text.CanGrow = false;
			this.wrkStdType3Text.DataField = "WRK_STD_TYPE";
			this.wrkStdType3Text.Height = 0.17F;
			this.wrkStdType3Text.Left = 2.686F;
			this.wrkStdType3Text.Name = "wrkStdType3Text";
			this.wrkStdType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdType3Text.Text = "0";
			this.wrkStdType3Text.Top = 7.035F;
			this.wrkStdType3Text.Width = 0.2F;
			// 
			// Label1510
			// 
			this.Label1510.Height = 0.166F;
			this.Label1510.HyperLink = null;
			this.Label1510.Left = 0.386F;
			this.Label1510.Name = "Label1510";
			this.Label1510.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1510.Text = "支";
			this.Label1510.Top = 7.22F;
			this.Label1510.Width = 0.22F;
			// 
			// Label1511
			// 
			this.Label1511.Height = 0.166F;
			this.Label1511.HyperLink = null;
			this.Label1511.Left = 0.386F;
			this.Label1511.Name = "Label1511";
			this.Label1511.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1511.Text = "払";
			this.Label1511.Top = 7.376F;
			this.Label1511.Width = 0.22F;
			// 
			// Label1512
			// 
			this.Label1512.Height = 0.166F;
			this.Label1512.HyperLink = null;
			this.Label1512.Left = 0.386F;
			this.Label1512.Name = "Label1512";
			this.Label1512.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1512.Text = "者";
			this.Label1512.Top = 7.548F;
			this.Label1512.Width = 0.22F;
			// 
			// paymntAddress3Text
			// 
			this.paymntAddress3Text.CanGrow = false;
			this.paymntAddress3Text.DataField = "PAYMNT_ADDRESS";
			this.paymntAddress3Text.Height = 0.332F;
			this.paymntAddress3Text.Left = 1.261F;
			this.paymntAddress3Text.Name = "paymntAddress3Text";
			this.paymntAddress3Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddress3Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddress3Text.Top = 7.21F;
			this.paymntAddress3Text.Width = 4.312F;
			// 
			// paymntName3Text
			// 
			this.paymntName3Text.CanGrow = false;
			this.paymntName3Text.DataField = "PAYMNT_NAME";
			this.paymntName3Text.Height = 0.188F;
			this.paymntName3Text.Left = 1.262F;
			this.paymntName3Text.MultiLine = false;
			this.paymntName3Text.Name = "paymntName3Text";
			this.paymntName3Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntName3Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntName3Text.Top = 7.556F;
			this.paymntName3Text.Width = 3.125F;
			// 
			// Label1513
			// 
			this.Label1513.Height = 0.188F;
			this.Label1513.HyperLink = null;
			this.Label1513.Left = 4.386F;
			this.Label1513.Name = "Label1513";
			this.Label1513.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1513.Text = "（電話）";
			this.Label1513.Top = 7.542F;
			this.Label1513.Width = 0.365F;
			// 
			// paymntPhone3Text
			// 
			this.paymntPhone3Text.CanGrow = false;
			this.paymntPhone3Text.DataField = "PAYMNT_PHONE";
			this.paymntPhone3Text.Height = 0.188F;
			this.paymntPhone3Text.Left = 4.761F;
			this.paymntPhone3Text.Name = "paymntPhone3Text";
			this.paymntPhone3Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.paymntPhone3Text.Text = "99999999999999";
			this.paymntPhone3Text.Top = 7.542F;
			this.paymntPhone3Text.Width = 0.813F;
			// 
			// Label1514
			// 
			this.Label1514.Height = 0.166F;
			this.Label1514.HyperLink = null;
			this.Label1514.Left = 0.606F;
			this.Label1514.Name = "Label1514";
			this.Label1514.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1514.Text = "住所（居所）";
			this.Label1514.Top = 7.21F;
			this.Label1514.Width = 0.65F;
			// 
			// Label1515
			// 
			this.Label1515.Height = 0.166F;
			this.Label1515.HyperLink = null;
			this.Label1515.Left = 0.606F;
			this.Label1515.Name = "Label1515";
			this.Label1515.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1515.Text = "又は所在地";
			this.Label1515.Top = 7.376F;
			this.Label1515.Width = 0.65F;
			// 
			// Label1517
			// 
			this.Label1517.Height = 0.188F;
			this.Label1517.HyperLink = null;
			this.Label1517.Left = 0.606F;
			this.Label1517.Name = "Label1517";
			this.Label1517.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1517.Text = "氏名又は名称";
			this.Label1517.Top = 7.548F;
			this.Label1517.Width = 0.655F;
			// 
			// Label1518
			// 
			this.Label1518.Height = 0.209F;
			this.Label1518.HyperLink = null;
			this.Label1518.Left = 0.3857203F;
			this.Label1518.Name = "Label1518";
			this.Label1518.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1518.Text = "を受け";
			this.Label1518.Top = 4.520612F;
			this.Label1518.Width = 0.292F;
			// 
			// Label1519
			// 
			this.Label1519.Height = 0.209F;
			this.Label1519.HyperLink = null;
			this.Label1519.Left = 0.3857203F;
			this.Label1519.Name = "Label1519";
			this.Label1519.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1519.Text = "る者";
			this.Label1519.Top = 4.72961F;
			this.Label1519.Width = 0.292F;
			// 
			// Label1520
			// 
			this.Label1520.Height = 0.313F;
			this.Label1520.HyperLink = null;
			this.Label1520.Left = 3.215222F;
			this.Label1520.Name = "Label1520";
			this.Label1520.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1520.Text = "名";
			this.Label1520.Top = 4.625612F;
			this.Label1520.Width = 0.19F;
			// 
			// Label1521
			// 
			this.Label1521.Height = 0.157F;
			this.Label1521.HyperLink = null;
			this.Label1521.Left = 0.3872214F;
			this.Label1521.Name = "Label1521";
			this.Label1521.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1521.Text = "者の有無等";
			this.Label1521.Top = 5.595613F;
			this.Label1521.Width = 0.399F;
			// 
			// Label1522
			// 
			this.Label1522.Height = 0.157F;
			this.Label1522.HyperLink = null;
			this.Label1522.Left = 0.8862205F;
			this.Label1522.Name = "Label1522";
			this.Label1522.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1522.Text = "控除の額";
			this.Label1522.Top = 5.595613F;
			this.Label1522.Width = 0.593F;
			// 
			// Label1523
			// 
			this.Label1523.Height = 0.157F;
			this.Label1523.HyperLink = null;
			this.Label1523.Left = 3.32322F;
			this.Label1523.Name = "Label1523";
			this.Label1523.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1523.Text = "等の金額";
			this.Label1523.Top = 5.594613F;
			this.Label1523.Width = 0.532F;
			// 
			// Label1524
			// 
			this.Label1524.Height = 0.157F;
			this.Label1524.HyperLink = null;
			this.Label1524.Left = 3.85422F;
			this.Label1524.Name = "Label1524";
			this.Label1524.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1524.Text = "の控除額";
			this.Label1524.Top = 5.594613F;
			this.Label1524.Width = 0.563F;
			// 
			// Label1525
			// 
			this.Label1525.Height = 0.157F;
			this.Label1525.HyperLink = null;
			this.Label1525.Left = 4.96822F;
			this.Label1525.Name = "Label1525";
			this.Label1525.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1525.Text = "特別控除の額";
			this.Label1525.Top = 5.594613F;
			this.Label1525.Width = 0.605F;
			// 
			// Label1526
			// 
			this.Label1526.Height = 0.156F;
			this.Label1526.HyperLink = null;
			this.Label1526.Left = 4.417219F;
			this.Label1526.Name = "Label1526";
			this.Label1526.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1526.Text = "損害保険料";
			this.Label1526.Top = 5.438612F;
			this.Label1526.Width = 0.551F;
			// 
			// Label1527
			// 
			this.Label1527.Height = 0.157F;
			this.Label1527.HyperLink = null;
			this.Label1527.Left = 4.417219F;
			this.Label1527.Name = "Label1527";
			this.Label1527.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1527.Text = "の控除額";
			this.Label1527.Top = 5.594613F;
			this.Label1527.Width = 0.551F;
			// 
			// nolfInsDedAmt3Text
			// 
			this.nolfInsDedAmt3Text.CanGrow = false;
			this.nolfInsDedAmt3Text.DataField = "NOLF_INS_DED_AMT";
			this.nolfInsDedAmt3Text.Height = 0.1875F;
			this.nolfInsDedAmt3Text.Left = 4.417719F;
			this.nolfInsDedAmt3Text.Name = "nolfInsDedAmt3Text";
			this.nolfInsDedAmt3Text.OutputFormat = "#,##0";
			this.nolfInsDedAmt3Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsDedAmt3Text.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsDedAmt3Text.Top = 5.915112F;
			this.nolfInsDedAmt3Text.Width = 0.551F;
			// 
			// Label1528
			// 
			this.Label1528.Height = 0.125F;
			this.Label1528.HyperLink = null;
			this.Label1528.Left = 4.85722F;
			this.Label1528.Name = "Label1528";
			this.Label1528.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1528.Text = "円";
			this.Label1528.Top = 5.752613F;
			this.Label1528.Width = 0.1114998F;
			// 
			// deathRetireType3Text
			// 
			this.deathRetireType3Text.CanGrow = false;
			this.deathRetireType3Text.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireType3Text.Height = 0.17F;
			this.deathRetireType3Text.Left = 1.054F;
			this.deathRetireType3Text.Name = "deathRetireType3Text";
			this.deathRetireType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireType3Text.Text = "0";
			this.deathRetireType3Text.Top = 7.035F;
			this.deathRetireType3Text.Width = 0.2F;
			// 
			// disasterType3Text
			// 
			this.disasterType3Text.CanGrow = false;
			this.disasterType3Text.DataField = "DISASTER_TYPE";
			this.disasterType3Text.Height = 0.17F;
			this.disasterType3Text.Left = 1.275F;
			this.disasterType3Text.Name = "disasterType3Text";
			this.disasterType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterType3Text.Text = "0";
			this.disasterType3Text.Top = 7.035F;
			this.disasterType3Text.Width = 0.2F;
			// 
			// foreignType3Text
			// 
			this.foreignType3Text.CanGrow = false;
			this.foreignType3Text.DataField = "FOREIGN_TYPE";
			this.foreignType3Text.Height = 0.17F;
			this.foreignType3Text.Left = 0.834F;
			this.foreignType3Text.Name = "foreignType3Text";
			this.foreignType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignType3Text.Text = "0";
			this.foreignType3Text.Top = 7.035F;
			this.foreignType3Text.Width = 0.2F;
			// 
			// halfEmployType3Text
			// 
			this.halfEmployType3Text.CanGrow = false;
			this.halfEmployType3Text.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployType3Text.Height = 0.17F;
			this.halfEmployType3Text.Left = 2.888F;
			this.halfEmployType3Text.Name = "halfEmployType3Text";
			this.halfEmployType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployType3Text.Text = "0";
			this.halfEmployType3Text.Top = 7.035F;
			this.halfEmployType3Text.Width = 0.2F;
			// 
			// Label1550
			// 
			this.Label1550.Height = 0.17F;
			this.Label1550.HyperLink = null;
			this.Label1550.Left = 3.088F;
			this.Label1550.Name = "Label1550";
			this.Label1550.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1550.Text = "退職";
			this.Label1550.Top = 6.862F;
			this.Label1550.Width = 0.2F;
			// 
			// halfRetireType3Text
			// 
			this.halfRetireType3Text.CanGrow = false;
			this.halfRetireType3Text.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireType3Text.Height = 0.17F;
			this.halfRetireType3Text.Left = 3.088F;
			this.halfRetireType3Text.Name = "halfRetireType3Text";
			this.halfRetireType3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireType3Text.Text = "0";
			this.halfRetireType3Text.Top = 7.035F;
			this.halfRetireType3Text.Width = 0.2F;
			// 
			// halrEmReDateYear3Text
			// 
			this.halrEmReDateYear3Text.CanGrow = false;
			this.halrEmReDateYear3Text.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halrEmReDateYear3Text.Height = 0.17F;
			this.halrEmReDateYear3Text.Left = 3.288F;
			this.halrEmReDateYear3Text.Name = "halrEmReDateYear3Text";
			this.halrEmReDateYear3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halrEmReDateYear3Text.Text = "0";
			this.halrEmReDateYear3Text.Top = 7.035F;
			this.halrEmReDateYear3Text.Width = 0.241F;
			// 
			// halfEmReDateMonth3Text
			// 
			this.halfEmReDateMonth3Text.CanGrow = false;
			this.halfEmReDateMonth3Text.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReDateMonth3Text.Height = 0.17F;
			this.halfEmReDateMonth3Text.Left = 3.529F;
			this.halfEmReDateMonth3Text.Name = "halfEmReDateMonth3Text";
			this.halfEmReDateMonth3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateMonth3Text.Text = "0";
			this.halfEmReDateMonth3Text.Top = 7.035F;
			this.halfEmReDateMonth3Text.Width = 0.192F;
			// 
			// halfEmReDateDay3Text
			// 
			this.halfEmReDateDay3Text.CanGrow = false;
			this.halfEmReDateDay3Text.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDay3Text.Height = 0.17F;
			this.halfEmReDateDay3Text.Left = 3.721F;
			this.halfEmReDateDay3Text.Name = "halfEmReDateDay3Text";
			this.halfEmReDateDay3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDay3Text.Text = "0";
			this.halfEmReDateDay3Text.Top = 7.035F;
			this.halfEmReDateDay3Text.Width = 0.228F;
			// 
			// Label1551
			// 
			this.Label1551.Height = 0.17F;
			this.Label1551.HyperLink = null;
			this.Label1551.Left = 4.142F;
			this.Label1551.Name = "Label1551";
			this.Label1551.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1551.Text = "大";
			this.Label1551.Top = 6.862F;
			this.Label1551.Width = 0.194F;
			// 
			// Label1552
			// 
			this.Label1552.Height = 0.17F;
			this.Label1552.HyperLink = null;
			this.Label1552.Left = 4.336F;
			this.Label1552.Name = "Label1552";
			this.Label1552.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1552.Text = "昭";
			this.Label1552.Top = 6.862F;
			this.Label1552.Width = 0.194F;
			// 
			// Label1553
			// 
			this.Label1553.Height = 0.17F;
			this.Label1553.HyperLink = null;
			this.Label1553.Left = 4.53F;
			this.Label1553.Name = "Label1553";
			this.Label1553.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1553.Text = "平";
			this.Label1553.Top = 6.862F;
			this.Label1553.Width = 0.194F;
			// 
			// Label1554
			// 
			this.Label1554.Height = 0.17F;
			this.Label1554.HyperLink = null;
			this.Label1554.Left = 5.007F;
			this.Label1554.Name = "Label1554";
			this.Label1554.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1554.Text = "月";
			this.Label1554.Top = 6.862F;
			this.Label1554.Width = 0.283F;
			// 
			// Label1555
			// 
			this.Label1555.Height = 0.17F;
			this.Label1555.HyperLink = null;
			this.Label1555.Left = 5.29F;
			this.Label1555.Name = "Label1555";
			this.Label1555.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1555.Text = "日";
			this.Label1555.Top = 6.862F;
			this.Label1555.Width = 0.283F;
			// 
			// birthNameOfEraM3Text
			// 
			this.birthNameOfEraM3Text.CanGrow = false;
			this.birthNameOfEraM3Text.DataField = "BIRTH_NAME_OF_ERA_M";
			this.birthNameOfEraM3Text.Height = 0.17F;
			this.birthNameOfEraM3Text.Left = 3.948F;
			this.birthNameOfEraM3Text.Name = "birthNameOfEraM3Text";
			this.birthNameOfEraM3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraM3Text.Text = "0";
			this.birthNameOfEraM3Text.Top = 7.035F;
			this.birthNameOfEraM3Text.Width = 0.194F;
			// 
			// birthNameOfErat3Text
			// 
			this.birthNameOfErat3Text.CanGrow = false;
			this.birthNameOfErat3Text.DataField = "BIRTH_NAME_OF_ERA_T";
			this.birthNameOfErat3Text.Height = 0.17F;
			this.birthNameOfErat3Text.Left = 4.142F;
			this.birthNameOfErat3Text.Name = "birthNameOfErat3Text";
			this.birthNameOfErat3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfErat3Text.Text = "0";
			this.birthNameOfErat3Text.Top = 7.035F;
			this.birthNameOfErat3Text.Width = 0.194F;
			// 
			// birthNameOfEraS3Text
			// 
			this.birthNameOfEraS3Text.CanGrow = false;
			this.birthNameOfEraS3Text.DataField = "BIRTH_NAME_OF_ERA_S";
			this.birthNameOfEraS3Text.Height = 0.17F;
			this.birthNameOfEraS3Text.Left = 4.336F;
			this.birthNameOfEraS3Text.Name = "birthNameOfEraS3Text";
			this.birthNameOfEraS3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraS3Text.Text = "0";
			this.birthNameOfEraS3Text.Top = 7.035F;
			this.birthNameOfEraS3Text.Width = 0.194F;
			// 
			// birthNameOfEraH3Text
			// 
			this.birthNameOfEraH3Text.CanGrow = false;
			this.birthNameOfEraH3Text.DataField = "BIRTH_NAME_OF_ERA_H";
			this.birthNameOfEraH3Text.Height = 0.17F;
			this.birthNameOfEraH3Text.Left = 4.53F;
			this.birthNameOfEraH3Text.Name = "birthNameOfEraH3Text";
			this.birthNameOfEraH3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraH3Text.Text = "0";
			this.birthNameOfEraH3Text.Top = 7.035F;
			this.birthNameOfEraH3Text.Width = 0.194F;
			// 
			// birthDayYear3Text
			// 
			this.birthDayYear3Text.CanGrow = false;
			this.birthDayYear3Text.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYear3Text.Height = 0.17F;
			this.birthDayYear3Text.Left = 4.724F;
			this.birthDayYear3Text.Name = "birthDayYear3Text";
			this.birthDayYear3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYear3Text.Text = "0";
			this.birthDayYear3Text.Top = 7.035F;
			this.birthDayYear3Text.Width = 0.283F;
			// 
			// birthDayMonth3Text
			// 
			this.birthDayMonth3Text.CanGrow = false;
			this.birthDayMonth3Text.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonth3Text.Height = 0.17F;
			this.birthDayMonth3Text.Left = 5.007F;
			this.birthDayMonth3Text.Name = "birthDayMonth3Text";
			this.birthDayMonth3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonth3Text.Text = "0";
			this.birthDayMonth3Text.Top = 7.035F;
			this.birthDayMonth3Text.Width = 0.283F;
			// 
			// birthDayDay3Text
			// 
			this.birthDayDay3Text.CanGrow = false;
			this.birthDayDay3Text.DataField = "BIRTH_DAY_DAY";
			this.birthDayDay3Text.Height = 0.17F;
			this.birthDayDay3Text.Left = 5.29F;
			this.birthDayDay3Text.Name = "birthDayDay3Text";
			this.birthDayDay3Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDay3Text.Text = "0";
			this.birthDayDay3Text.Top = 7.035F;
			this.birthDayDay3Text.Width = 0.283F;
			// 
			// socInsDedAmt3Text
			// 
			this.socInsDedAmt3Text.CanGrow = false;
			this.socInsDedAmt3Text.DataField = "SOC_INS_DED_AMT";
			this.socInsDedAmt3Text.Height = 0.158F;
			this.socInsDedAmt3Text.Left = 3.32222F;
			this.socInsDedAmt3Text.Name = "socInsDedAmt3Text";
			this.socInsDedAmt3Text.OutputFormat = "#,##0";
			this.socInsDedAmt3Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.socInsDedAmt3Text.Text = "ZZ,ZZZ,ZZ6";
			this.socInsDedAmt3Text.Top = 5.952612F;
			this.socInsDedAmt3Text.Width = 0.532F;
			// 
			// Label1562
			// 
			this.Label1562.Height = 0.625F;
			this.Label1562.HyperLink = null;
			this.Label1562.Left = 0.2207213F;
			this.Label1562.Name = "Label1562";
			this.Label1562.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1562.Text = "市区町村提出用";
			this.Label1562.Top = 7.188112F;
			this.Label1562.Width = 0.1695F;
			// 
			// Label1563
			// 
			this.Label1563.Angle = 2700;
			this.Label1563.Height = 0.1164999F;
			this.Label1563.HyperLink = null;
			this.Label1563.Left = 0.2162204F;
			this.Label1563.Name = "Label1563";
			this.Label1563.Style = "font-size: 5.5pt; text-align: center; vertical-align: bottom; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1563.Text = "(";
			this.Label1563.Top = 7.091114F;
			this.Label1563.Width = 0.17F;
			// 
			// Label1564
			// 
			this.Label1564.Angle = 900;
			this.Label1564.Height = 0.08F;
			this.Label1564.HyperLink = null;
			this.Label1564.Left = 0.2375532F;
			this.Label1564.Name = "Label1564";
			this.Label1564.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1564.Text = "(";
			this.Label1564.Top = 7.735113F;
			this.Label1564.Width = 0.17F;
			// 
			// Line649
			// 
			this.Line649.Height = 0F;
			this.Line649.Left = 0.3862205F;
			this.Line649.LineWeight = 1F;
			this.Line649.Name = "Line649";
			this.Line649.Top = 4.313112F;
			this.Line649.Width = 5.186999F;
			this.Line649.X1 = 0.3862205F;
			this.Line649.X2 = 5.57322F;
			this.Line649.Y1 = 4.313112F;
			this.Line649.Y2 = 4.313112F;
			// 
			// Line650
			// 
			this.Line650.Height = 0F;
			this.Line650.Left = 0.3862205F;
			this.Line650.LineWeight = 1F;
			this.Line650.Name = "Line650";
			this.Line650.Top = 4.938112F;
			this.Line650.Width = 5.186999F;
			this.Line650.X1 = 0.3862205F;
			this.Line650.X2 = 5.57322F;
			this.Line650.Y1 = 4.938112F;
			this.Line650.Y2 = 4.938112F;
			// 
			// Line651
			// 
			this.Line651.Height = 0F;
			this.Line651.Left = 0.3862205F;
			this.Line651.LineWeight = 1F;
			this.Line651.Name = "Line651";
			this.Line651.Top = 5.439111F;
			this.Line651.Width = 5.186999F;
			this.Line651.X1 = 0.3862205F;
			this.Line651.X2 = 5.57322F;
			this.Line651.Y1 = 5.439111F;
			this.Line651.Y2 = 5.439111F;
			// 
			// Line652
			// 
			this.Line652.Height = 0F;
			this.Line652.Left = 0.3862205F;
			this.Line652.LineWeight = 1F;
			this.Line652.Name = "Line652";
			this.Line652.Top = 5.75311F;
			this.Line652.Width = 5.186999F;
			this.Line652.X1 = 0.3862205F;
			this.Line652.X2 = 5.57322F;
			this.Line652.Y1 = 5.75311F;
			this.Line652.Y2 = 5.75311F;
			// 
			// Line653
			// 
			this.Line653.Height = 0F;
			this.Line653.Left = 0.3862205F;
			this.Line653.LineWeight = 1F;
			this.Line653.Name = "Line653";
			this.Line653.Top = 6.7F;
			this.Line653.Width = 5.186999F;
			this.Line653.X1 = 0.3862205F;
			this.Line653.X2 = 5.57322F;
			this.Line653.Y1 = 6.7F;
			this.Line653.Y2 = 6.7F;
			// 
			// Line655
			// 
			this.Line655.Height = 0F;
			this.Line655.Left = 0.3862205F;
			this.Line655.LineWeight = 1F;
			this.Line655.Name = "Line655";
			this.Line655.Top = 7.21F;
			this.Line655.Width = 5.186999F;
			this.Line655.X1 = 0.3862205F;
			this.Line655.X2 = 5.57322F;
			this.Line655.Y1 = 7.21F;
			this.Line655.Y2 = 7.21F;
			// 
			// Line656
			// 
			this.Line656.Height = 3.609999F;
			this.Line656.Left = 5.57322F;
			this.Line656.LineWeight = 1F;
			this.Line656.Name = "Line656";
			this.Line656.Top = 4.125113F;
			this.Line656.Width = 0F;
			this.Line656.X1 = 5.57322F;
			this.Line656.X2 = 5.57322F;
			this.Line656.Y1 = 4.125113F;
			this.Line656.Y2 = 7.735112F;
			// 
			// Line657
			// 
			this.Line657.Height = 0.7329998F;
			this.Line657.Left = 0.6782203F;
			this.Line657.LineWeight = 1F;
			this.Line657.Name = "Line657";
			this.Line657.Top = 4.205112F;
			this.Line657.Width = 0F;
			this.Line657.X1 = 0.6782203F;
			this.Line657.X2 = 0.6782203F;
			this.Line657.Y1 = 4.205112F;
			this.Line657.Y2 = 4.938112F;
			// 
			// Line658
			// 
			this.Line658.Height = 0.4690008F;
			this.Line658.Left = 0.8662216F;
			this.Line658.LineWeight = 1F;
			this.Line658.Name = "Line658";
			this.Line658.Top = 4.469111F;
			this.Line658.Width = 0F;
			this.Line658.X1 = 0.8662216F;
			this.Line658.X2 = 0.8662216F;
			this.Line658.Y1 = 4.469111F;
			this.Line658.Y2 = 4.938112F;
			// 
			// Line659
			// 
			this.Line659.Height = 0.625F;
			this.Line659.Left = 3.21522F;
			this.Line659.LineWeight = 1F;
			this.Line659.Name = "Line659";
			this.Line659.Top = 4.313112F;
			this.Line659.Width = 0F;
			this.Line659.X1 = 3.21522F;
			this.Line659.X2 = 3.21522F;
			this.Line659.Y1 = 4.313112F;
			this.Line659.Y2 = 4.938112F;
			// 
			// Line660
			// 
			this.Line660.Height = 0.625F;
			this.Line660.Left = 3.40522F;
			this.Line660.LineWeight = 1F;
			this.Line660.Name = "Line660";
			this.Line660.Top = 4.313112F;
			this.Line660.Width = 0F;
			this.Line660.X1 = 3.40522F;
			this.Line660.X2 = 3.40522F;
			this.Line660.Y1 = 4.313112F;
			this.Line660.Y2 = 4.938112F;
			// 
			// Line661
			// 
			this.Line661.Height = 0F;
			this.Line661.Left = 3.40522F;
			this.Line661.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line661.LineWeight = 1F;
			this.Line661.Name = "Line661";
			this.Line661.Top = 4.469111F;
			this.Line661.Width = 2.168F;
			this.Line661.X1 = 3.40522F;
			this.Line661.X2 = 5.57322F;
			this.Line661.Y1 = 4.469111F;
			this.Line661.Y2 = 4.469111F;
			// 
			// Line662
			// 
			this.Line662.Height = 0F;
			this.Line662.Left = 3.40522F;
			this.Line662.LineWeight = 1F;
			this.Line662.Name = "Line662";
			this.Line662.Top = 4.625113F;
			this.Line662.Width = 2.168F;
			this.Line662.X1 = 3.40522F;
			this.Line662.X2 = 5.57322F;
			this.Line662.Y1 = 4.625113F;
			this.Line662.Y2 = 4.625113F;
			// 
			// Line663
			// 
			this.Line663.Height = 0.5009995F;
			this.Line663.Left = 1.324219F;
			this.Line663.LineWeight = 1F;
			this.Line663.Name = "Line663";
			this.Line663.Top = 4.938112F;
			this.Line663.Width = 0F;
			this.Line663.X1 = 1.324219F;
			this.Line663.X2 = 1.324219F;
			this.Line663.Y1 = 4.938112F;
			this.Line663.Y2 = 5.439111F;
			// 
			// Line664
			// 
			this.Line664.Height = 0.5009995F;
			this.Line664.Left = 2.402221F;
			this.Line664.LineWeight = 1F;
			this.Line664.Name = "Line664";
			this.Line664.Top = 4.938112F;
			this.Line664.Width = 0F;
			this.Line664.X1 = 2.402221F;
			this.Line664.X2 = 2.402221F;
			this.Line664.Y1 = 4.938112F;
			this.Line664.Y2 = 5.439111F;
			// 
			// Line665
			// 
			this.Line665.Height = 0.5009995F;
			this.Line665.Left = 3.46522F;
			this.Line665.LineWeight = 1F;
			this.Line665.Name = "Line665";
			this.Line665.Top = 4.938112F;
			this.Line665.Width = 0F;
			this.Line665.X1 = 3.46522F;
			this.Line665.X2 = 3.46522F;
			this.Line665.Y1 = 4.938112F;
			this.Line665.Y2 = 5.439111F;
			// 
			// Line666
			// 
			this.Line666.Height = 0.5009995F;
			this.Line666.Left = 4.52822F;
			this.Line666.LineWeight = 1F;
			this.Line666.Name = "Line666";
			this.Line666.Top = 4.938112F;
			this.Line666.Width = 0F;
			this.Line666.X1 = 4.52822F;
			this.Line666.X2 = 4.52822F;
			this.Line666.Y1 = 4.938112F;
			this.Line666.Y2 = 5.439111F;
			// 
			// Line667
			// 
			this.Line667.Height = 0F;
			this.Line667.Left = 0.3862205F;
			this.Line667.LineWeight = 1F;
			this.Line667.Name = "Line667";
			this.Line667.Top = 5.111113F;
			this.Line667.Width = 5.186999F;
			this.Line667.X1 = 0.3862205F;
			this.Line667.X2 = 5.57322F;
			this.Line667.Y1 = 5.111113F;
			this.Line667.Y2 = 5.111113F;
			// 
			// Line668
			// 
			this.Line668.Height = 0F;
			this.Line668.Left = 0.7862201F;
			this.Line668.LineWeight = 1F;
			this.Line668.Name = "Line668";
			this.Line668.Top = 5.580112F;
			this.Line668.Width = 0.1000004F;
			this.Line668.X1 = 0.7862201F;
			this.Line668.X2 = 0.8862205F;
			this.Line668.Y1 = 5.580112F;
			this.Line668.Y2 = 5.580112F;
			// 
			// Line669
			// 
			this.Line669.Height = 0.5159998F;
			this.Line669.Left = 0.7862201F;
			this.Line669.LineWeight = 1F;
			this.Line669.Name = "Line669";
			this.Line669.Top = 5.580112F;
			this.Line669.Width = 0F;
			this.Line669.X1 = 0.7862201F;
			this.Line669.X2 = 0.7862201F;
			this.Line669.Y1 = 5.580112F;
			this.Line669.Y2 = 6.096112F;
			// 
			// Line670
			// 
			this.Line670.Height = 0.3430018F;
			this.Line670.Left = 0.6862202F;
			this.Line670.LineWeight = 1F;
			this.Line670.Name = "Line670";
			this.Line670.Top = 5.75311F;
			this.Line670.Width = 0F;
			this.Line670.X1 = 0.6862202F;
			this.Line670.X2 = 0.6862202F;
			this.Line670.Y1 = 5.75311F;
			this.Line670.Y2 = 6.096112F;
			// 
			// Line671
			// 
			this.Line671.Height = 0.3430018F;
			this.Line671.Left = 0.5862203F;
			this.Line671.LineWeight = 1F;
			this.Line671.Name = "Line671";
			this.Line671.Top = 5.75311F;
			this.Line671.Width = 0F;
			this.Line671.X1 = 0.5862203F;
			this.Line671.X2 = 0.5862203F;
			this.Line671.Y1 = 5.75311F;
			this.Line671.Y2 = 6.096112F;
			// 
			// Line672
			// 
			this.Line672.Height = 0.3430018F;
			this.Line672.Left = 0.4862204F;
			this.Line672.LineWeight = 1F;
			this.Line672.Name = "Line672";
			this.Line672.Top = 5.75311F;
			this.Line672.Width = 0F;
			this.Line672.X1 = 0.4862204F;
			this.Line672.X2 = 0.4862204F;
			this.Line672.Y1 = 5.75311F;
			this.Line672.Y2 = 6.096112F;
			// 
			// Line673
			// 
			this.Line673.Height = 0.6570005F;
			this.Line673.Left = 1.48022F;
			this.Line673.LineWeight = 1F;
			this.Line673.Name = "Line673";
			this.Line673.Top = 5.439111F;
			this.Line673.Width = 0F;
			this.Line673.X1 = 1.48022F;
			this.Line673.X2 = 1.48022F;
			this.Line673.Y1 = 5.439111F;
			this.Line673.Y2 = 6.096112F;
			// 
			// Line674
			// 
			this.Line674.Height = 0.3430018F;
			this.Line674.Left = 1.66822F;
			this.Line674.LineWeight = 1F;
			this.Line674.Name = "Line674";
			this.Line674.Top = 5.75311F;
			this.Line674.Width = 0F;
			this.Line674.X1 = 1.66822F;
			this.Line674.X2 = 1.66822F;
			this.Line674.Y1 = 5.75311F;
			this.Line674.Y2 = 6.096112F;
			// 
			// Line675
			// 
			this.Line675.Height = 0F;
			this.Line675.Left = 1.48022F;
			this.Line675.LineWeight = 1F;
			this.Line675.Name = "Line675";
			this.Line675.Top = 5.647111F;
			this.Line675.Width = 1.843F;
			this.Line675.X1 = 1.48022F;
			this.Line675.X2 = 3.32322F;
			this.Line675.Y1 = 5.647111F;
			this.Line675.Y2 = 5.647111F;
			// 
			// Line676
			// 
			this.Line676.Height = 0.4490008F;
			this.Line676.Left = 1.866221F;
			this.Line676.LineWeight = 1F;
			this.Line676.Name = "Line676";
			this.Line676.Top = 5.647111F;
			this.Line676.Width = 0F;
			this.Line676.X1 = 1.866221F;
			this.Line676.X2 = 1.866221F;
			this.Line676.Y1 = 5.647111F;
			this.Line676.Y2 = 6.096112F;
			// 
			// Line677
			// 
			this.Line677.Height = 0.2460008F;
			this.Line677.Left = 1.97622F;
			this.Line677.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line677.LineWeight = 1F;
			this.Line677.Name = "Line677";
			this.Line677.Top = 5.850111F;
			this.Line677.Width = 0F;
			this.Line677.X1 = 1.97622F;
			this.Line677.X2 = 1.97622F;
			this.Line677.Y1 = 5.850111F;
			this.Line677.Y2 = 6.096112F;
			// 
			// Line678
			// 
			this.Line678.Height = 0.3430018F;
			this.Line678.Left = 2.19522F;
			this.Line678.LineWeight = 1F;
			this.Line678.Name = "Line678";
			this.Line678.Top = 5.75311F;
			this.Line678.Width = 0F;
			this.Line678.X1 = 2.19522F;
			this.Line678.X2 = 2.19522F;
			this.Line678.Y1 = 5.75311F;
			this.Line678.Y2 = 6.096112F;
			// 
			// Line679
			// 
			this.Line679.Height = 0.4490008F;
			this.Line679.Left = 2.41322F;
			this.Line679.LineWeight = 1F;
			this.Line679.Name = "Line679";
			this.Line679.Top = 5.647111F;
			this.Line679.Width = 0F;
			this.Line679.X1 = 2.41322F;
			this.Line679.X2 = 2.41322F;
			this.Line679.Y1 = 5.647111F;
			this.Line679.Y2 = 6.096112F;
			// 
			// Line680
			// 
			this.Line680.Height = 0.3430018F;
			this.Line680.Left = 2.605219F;
			this.Line680.LineWeight = 1F;
			this.Line680.Name = "Line680";
			this.Line680.Top = 5.75311F;
			this.Line680.Width = 0F;
			this.Line680.X1 = 2.605219F;
			this.Line680.X2 = 2.605219F;
			this.Line680.Y1 = 5.75311F;
			this.Line680.Y2 = 6.096112F;
			// 
			// Line681
			// 
			this.Line681.Height = 0.6570005F;
			this.Line681.Left = 2.797221F;
			this.Line681.LineWeight = 1F;
			this.Line681.Name = "Line681";
			this.Line681.Top = 5.439111F;
			this.Line681.Width = 0F;
			this.Line681.X1 = 2.797221F;
			this.Line681.X2 = 2.797221F;
			this.Line681.Y1 = 5.439111F;
			this.Line681.Y2 = 6.096112F;
			// 
			// Line682
			// 
			this.Line682.Height = 0.2460008F;
			this.Line682.Left = 2.922221F;
			this.Line682.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line682.LineWeight = 1F;
			this.Line682.Name = "Line682";
			this.Line682.Top = 5.850111F;
			this.Line682.Width = 0F;
			this.Line682.X1 = 2.922221F;
			this.Line682.X2 = 2.922221F;
			this.Line682.Y1 = 5.850111F;
			this.Line682.Y2 = 6.096112F;
			// 
			// Line683
			// 
			this.Line683.Height = 0.4490008F;
			this.Line683.Left = 3.047221F;
			this.Line683.LineWeight = 1F;
			this.Line683.Name = "Line683";
			this.Line683.Top = 5.647111F;
			this.Line683.Width = 0F;
			this.Line683.X1 = 3.047221F;
			this.Line683.X2 = 3.047221F;
			this.Line683.Y1 = 5.647111F;
			this.Line683.Y2 = 6.096112F;
			// 
			// Line684
			// 
			this.Line684.Height = 0.6570005F;
			this.Line684.Left = 3.32222F;
			this.Line684.LineWeight = 1F;
			this.Line684.Name = "Line684";
			this.Line684.Top = 5.439111F;
			this.Line684.Width = 0F;
			this.Line684.X1 = 3.32222F;
			this.Line684.X2 = 3.32222F;
			this.Line684.Y1 = 5.439111F;
			this.Line684.Y2 = 6.096112F;
			// 
			// Line685
			// 
			this.Line685.Height = 0.6570005F;
			this.Line685.Left = 3.85422F;
			this.Line685.LineWeight = 1F;
			this.Line685.Name = "Line685";
			this.Line685.Top = 5.439111F;
			this.Line685.Width = 0F;
			this.Line685.X1 = 3.85422F;
			this.Line685.X2 = 3.85422F;
			this.Line685.Y1 = 5.439111F;
			this.Line685.Y2 = 6.096112F;
			// 
			// Line686
			// 
			this.Line686.Height = 0.6570005F;
			this.Line686.Left = 4.417219F;
			this.Line686.LineWeight = 1F;
			this.Line686.Name = "Line686";
			this.Line686.Top = 5.439111F;
			this.Line686.Width = 0F;
			this.Line686.X1 = 4.417219F;
			this.Line686.X2 = 4.417219F;
			this.Line686.Y1 = 5.439111F;
			this.Line686.Y2 = 6.096112F;
			// 
			// Line687
			// 
			this.Line687.Height = 0.6570005F;
			this.Line687.Left = 4.96822F;
			this.Line687.LineWeight = 1F;
			this.Line687.Name = "Line687";
			this.Line687.Top = 5.439111F;
			this.Line687.Width = 0F;
			this.Line687.X1 = 4.96822F;
			this.Line687.X2 = 4.96822F;
			this.Line687.Y1 = 5.439111F;
			this.Line687.Y2 = 6.096112F;
			// 
			// Line688
			// 
			this.Line688.Height = 0F;
			this.Line688.Left = 0.3862205F;
			this.Line688.LineWeight = 1F;
			this.Line688.Name = "Line688";
			this.Line688.Top = 6.096112F;
			this.Line688.Width = 5.186999F;
			this.Line688.X1 = 0.3862205F;
			this.Line688.X2 = 5.57322F;
			this.Line688.Y1 = 6.096112F;
			this.Line688.Y2 = 6.096112F;
			// 
			// Line689
			// 
			this.Line689.Height = 0.5100002F;
			this.Line689.Left = 3.94822F;
			this.Line689.LineWeight = 1F;
			this.Line689.Name = "Line689";
			this.Line689.Top = 6.7F;
			this.Line689.Width = 0F;
			this.Line689.X1 = 3.94822F;
			this.Line689.X2 = 3.94822F;
			this.Line689.Y1 = 6.7F;
			this.Line689.Y2 = 7.21F;
			// 
			// Line690
			// 
			this.Line690.Height = 0.603888F;
			this.Line690.Left = 4.818F;
			this.Line690.LineWeight = 1F;
			this.Line690.Name = "Line690";
			this.Line690.Top = 6.096112F;
			this.Line690.Width = 0F;
			this.Line690.X1 = 4.818F;
			this.Line690.X2 = 4.818F;
			this.Line690.Y1 = 6.096112F;
			this.Line690.Y2 = 6.7F;
			// 
			// Line703
			// 
			this.Line703.Height = 0.5100002F;
			this.Line703.Left = 2.88772F;
			this.Line703.LineWeight = 1F;
			this.Line703.Name = "Line703";
			this.Line703.Top = 6.7F;
			this.Line703.Width = 0F;
			this.Line703.X1 = 2.88772F;
			this.Line703.X2 = 2.88772F;
			this.Line703.Y1 = 6.7F;
			this.Line703.Y2 = 7.21F;
			// 
			// Line704
			// 
			this.Line704.Height = 0F;
			this.Line704.Left = 2.88522F;
			this.Line704.LineWeight = 1F;
			this.Line704.Name = "Line704";
			this.Line704.Top = 6.862F;
			this.Line704.Width = 2.688F;
			this.Line704.X1 = 2.88522F;
			this.Line704.X2 = 5.57322F;
			this.Line704.Y1 = 6.862F;
			this.Line704.Y2 = 6.862F;
			// 
			// Line705
			// 
			this.Line705.Height = 0.3499999F;
			this.Line705.Left = 3.087719F;
			this.Line705.LineWeight = 1F;
			this.Line705.Name = "Line705";
			this.Line705.Top = 6.86F;
			this.Line705.Width = 0F;
			this.Line705.X1 = 3.087719F;
			this.Line705.X2 = 3.087719F;
			this.Line705.Y1 = 6.86F;
			this.Line705.Y2 = 7.21F;
			// 
			// Line706
			// 
			this.Line706.Height = 0.3499999F;
			this.Line706.Left = 3.28772F;
			this.Line706.LineWeight = 1F;
			this.Line706.Name = "Line706";
			this.Line706.Top = 6.86F;
			this.Line706.Width = 0F;
			this.Line706.X1 = 3.28772F;
			this.Line706.X2 = 3.28772F;
			this.Line706.Y1 = 6.86F;
			this.Line706.Y2 = 7.21F;
			// 
			// Line707
			// 
			this.Line707.Height = 0.3499999F;
			this.Line707.Left = 3.528719F;
			this.Line707.LineWeight = 1F;
			this.Line707.Name = "Line707";
			this.Line707.Top = 6.86F;
			this.Line707.Width = 0F;
			this.Line707.X1 = 3.528719F;
			this.Line707.X2 = 3.528719F;
			this.Line707.Y1 = 6.86F;
			this.Line707.Y2 = 7.21F;
			// 
			// Line708
			// 
			this.Line708.Height = 0.3499999F;
			this.Line708.Left = 3.720721F;
			this.Line708.LineWeight = 1F;
			this.Line708.Name = "Line708";
			this.Line708.Top = 6.86F;
			this.Line708.Width = 0F;
			this.Line708.X1 = 3.720721F;
			this.Line708.X2 = 3.720721F;
			this.Line708.Y1 = 6.86F;
			this.Line708.Y2 = 7.21F;
			// 
			// Line709
			// 
			this.Line709.Height = 0.3499999F;
			this.Line709.Left = 4.14222F;
			this.Line709.LineWeight = 1F;
			this.Line709.Name = "Line709";
			this.Line709.Top = 6.86F;
			this.Line709.Width = 0F;
			this.Line709.X1 = 4.14222F;
			this.Line709.X2 = 4.14222F;
			this.Line709.Y1 = 6.86F;
			this.Line709.Y2 = 7.21F;
			// 
			// Line710
			// 
			this.Line710.Height = 0.3499999F;
			this.Line710.Left = 4.33622F;
			this.Line710.LineWeight = 1F;
			this.Line710.Name = "Line710";
			this.Line710.Top = 6.86F;
			this.Line710.Width = 0F;
			this.Line710.X1 = 4.33622F;
			this.Line710.X2 = 4.33622F;
			this.Line710.Y1 = 6.86F;
			this.Line710.Y2 = 7.21F;
			// 
			// Line711
			// 
			this.Line711.Height = 0.3499999F;
			this.Line711.Left = 4.530221F;
			this.Line711.LineWeight = 1F;
			this.Line711.Name = "Line711";
			this.Line711.Top = 6.86F;
			this.Line711.Width = 0F;
			this.Line711.X1 = 4.530221F;
			this.Line711.X2 = 4.530221F;
			this.Line711.Y1 = 6.86F;
			this.Line711.Y2 = 7.21F;
			// 
			// Line712
			// 
			this.Line712.Height = 0.3499999F;
			this.Line712.Left = 4.724221F;
			this.Line712.LineWeight = 1F;
			this.Line712.Name = "Line712";
			this.Line712.Top = 6.86F;
			this.Line712.Width = 0F;
			this.Line712.X1 = 4.724221F;
			this.Line712.X2 = 4.724221F;
			this.Line712.Y1 = 6.86F;
			this.Line712.Y2 = 7.21F;
			// 
			// Line713
			// 
			this.Line713.Height = 0.3499999F;
			this.Line713.Left = 5.00722F;
			this.Line713.LineWeight = 1F;
			this.Line713.Name = "Line713";
			this.Line713.Top = 6.86F;
			this.Line713.Width = 0F;
			this.Line713.X1 = 5.00722F;
			this.Line713.X2 = 5.00722F;
			this.Line713.Y1 = 6.86F;
			this.Line713.Y2 = 7.21F;
			// 
			// Line716
			// 
			this.Line716.Height = 0F;
			this.Line716.Left = 0.6057201F;
			this.Line716.LineWeight = 1F;
			this.Line716.Name = "Line716";
			this.Line716.Top = 7.54F;
			this.Line716.Width = 4.9675F;
			this.Line716.X1 = 0.6057201F;
			this.Line716.X2 = 5.57322F;
			this.Line716.Y1 = 7.54F;
			this.Line716.Y2 = 7.54F;
			// 
			// Line717
			// 
			this.Line717.Height = 0.3499999F;
			this.Line717.Left = 5.290221F;
			this.Line717.LineWeight = 1F;
			this.Line717.Name = "Line717";
			this.Line717.Top = 6.86F;
			this.Line717.Width = 0F;
			this.Line717.X1 = 5.290221F;
			this.Line717.X2 = 5.290221F;
			this.Line717.Y1 = 6.86F;
			this.Line717.Y2 = 7.21F;
			// 
			// Line718
			// 
			this.Line718.Height = 0.6570005F;
			this.Line718.Left = 0.8872214F;
			this.Line718.LineWeight = 1F;
			this.Line718.Name = "Line718";
			this.Line718.Top = 5.439111F;
			this.Line718.Width = 0F;
			this.Line718.X1 = 0.8872214F;
			this.Line718.X2 = 0.8872214F;
			this.Line718.Y1 = 5.439111F;
			this.Line718.Y2 = 6.096112F;
			// 
			// Line719
			// 
			this.Line719.Height = 0F;
			this.Line719.Left = 2.628F;
			this.Line719.LineWeight = 1F;
			this.Line719.Name = "Line719";
			this.Line719.Top = 6.385F;
			this.Line719.Width = 2.94522F;
			this.Line719.X1 = 2.628F;
			this.Line719.X2 = 5.57322F;
			this.Line719.Y1 = 6.385F;
			this.Line719.Y2 = 6.385F;
			// 
			// Line720
			// 
			this.Line720.Height = 0F;
			this.Line720.Left = 2.628F;
			this.Line720.LineWeight = 1F;
			this.Line720.Name = "Line720";
			this.Line720.Top = 6.545F;
			this.Line720.Width = 2.94522F;
			this.Line720.X1 = 2.628F;
			this.Line720.X2 = 5.57322F;
			this.Line720.Y1 = 6.545F;
			this.Line720.Y2 = 6.545F;
			// 
			// Line721
			// 
			this.Line721.Height = 0F;
			this.Line721.Left = 0.3862205F;
			this.Line721.LineWeight = 1F;
			this.Line721.Name = "Line721";
			this.Line721.Top = 4.125113F;
			this.Line721.Width = 5.186999F;
			this.Line721.X1 = 0.3862205F;
			this.Line721.X2 = 5.57322F;
			this.Line721.Y1 = 4.125113F;
			this.Line721.Y2 = 4.125113F;
			// 
			// Line722
			// 
			this.Line722.Height = 0F;
			this.Line722.Left = 0.3862205F;
			this.Line722.LineWeight = 1F;
			this.Line722.Name = "Line722";
			this.Line722.Top = 4.205112F;
			this.Line722.Width = 5.186999F;
			this.Line722.X1 = 0.3862205F;
			this.Line722.X2 = 5.57322F;
			this.Line722.Y1 = 4.205112F;
			this.Line722.Y2 = 4.205112F;
			// 
			// Line723
			// 
			this.Line723.Height = 0.1079998F;
			this.Line723.Left = 0.5327202F;
			this.Line723.LineWeight = 1F;
			this.Line723.Name = "Line723";
			this.Line723.Top = 4.205112F;
			this.Line723.Width = 0F;
			this.Line723.X1 = 0.5327202F;
			this.Line723.X2 = 0.5327202F;
			this.Line723.Y1 = 4.205112F;
			this.Line723.Y2 = 4.313112F;
			// 
			// Line724
			// 
			this.Line724.Height = 0.1079998F;
			this.Line724.Left = 0.8247214F;
			this.Line724.LineWeight = 1F;
			this.Line724.Name = "Line724";
			this.Line724.Top = 4.205112F;
			this.Line724.Width = 0F;
			this.Line724.X1 = 0.8247214F;
			this.Line724.X2 = 0.8247214F;
			this.Line724.Y1 = 4.205112F;
			this.Line724.Y2 = 4.313112F;
			// 
			// Line725
			// 
			this.Line725.Height = 0.1079998F;
			this.Line725.Left = 0.9707213F;
			this.Line725.LineWeight = 1F;
			this.Line725.Name = "Line725";
			this.Line725.Top = 4.205112F;
			this.Line725.Width = 0F;
			this.Line725.X1 = 0.9707213F;
			this.Line725.X2 = 0.9707213F;
			this.Line725.Y1 = 4.205112F;
			this.Line725.Y2 = 4.313112F;
			// 
			// Line726
			// 
			this.Line726.Height = 0.1079998F;
			this.Line726.Left = 1.11672F;
			this.Line726.LineWeight = 1F;
			this.Line726.Name = "Line726";
			this.Line726.Top = 4.205112F;
			this.Line726.Width = 0F;
			this.Line726.X1 = 1.11672F;
			this.Line726.X2 = 1.11672F;
			this.Line726.Y1 = 4.205112F;
			this.Line726.Y2 = 4.313112F;
			// 
			// Line727
			// 
			this.Line727.Height = 0.1079998F;
			this.Line727.Left = 1.26272F;
			this.Line727.LineWeight = 1F;
			this.Line727.Name = "Line727";
			this.Line727.Top = 4.205112F;
			this.Line727.Width = 0F;
			this.Line727.X1 = 1.26272F;
			this.Line727.X2 = 1.26272F;
			this.Line727.Y1 = 4.205112F;
			this.Line727.Y2 = 4.313112F;
			// 
			// Line728
			// 
			this.Line728.Height = 0.1079998F;
			this.Line728.Left = 1.40872F;
			this.Line728.LineWeight = 1F;
			this.Line728.Name = "Line728";
			this.Line728.Top = 4.205112F;
			this.Line728.Width = 0F;
			this.Line728.X1 = 1.40872F;
			this.Line728.X2 = 1.40872F;
			this.Line728.Y1 = 4.205112F;
			this.Line728.Y2 = 4.313112F;
			// 
			// Line729
			// 
			this.Line729.Height = 0.1079998F;
			this.Line729.Left = 1.55472F;
			this.Line729.LineWeight = 1F;
			this.Line729.Name = "Line729";
			this.Line729.Top = 4.205112F;
			this.Line729.Width = 0F;
			this.Line729.X1 = 1.55472F;
			this.Line729.X2 = 1.55472F;
			this.Line729.Y1 = 4.205112F;
			this.Line729.Y2 = 4.313112F;
			// 
			// Line730
			// 
			this.Line730.Height = 0.1079998F;
			this.Line730.Left = 1.70072F;
			this.Line730.LineWeight = 1F;
			this.Line730.Name = "Line730";
			this.Line730.Top = 4.205112F;
			this.Line730.Width = 0F;
			this.Line730.X1 = 1.70072F;
			this.Line730.X2 = 1.70072F;
			this.Line730.Y1 = 4.205112F;
			this.Line730.Y2 = 4.313112F;
			// 
			// Line731
			// 
			this.Line731.Height = 0.1079998F;
			this.Line731.Left = 1.84672F;
			this.Line731.LineWeight = 1F;
			this.Line731.Name = "Line731";
			this.Line731.Top = 4.205112F;
			this.Line731.Width = 0F;
			this.Line731.X1 = 1.84672F;
			this.Line731.X2 = 1.84672F;
			this.Line731.Y1 = 4.205112F;
			this.Line731.Y2 = 4.313112F;
			// 
			// Line732
			// 
			this.Line732.Height = 0.1079998F;
			this.Line732.Left = 1.99272F;
			this.Line732.LineWeight = 1F;
			this.Line732.Name = "Line732";
			this.Line732.Top = 4.205112F;
			this.Line732.Width = 0F;
			this.Line732.X1 = 1.99272F;
			this.Line732.X2 = 1.99272F;
			this.Line732.Y1 = 4.205112F;
			this.Line732.Y2 = 4.313112F;
			// 
			// Line733
			// 
			this.Line733.Height = 0.1079998F;
			this.Line733.Left = 2.13872F;
			this.Line733.LineWeight = 1F;
			this.Line733.Name = "Line733";
			this.Line733.Top = 4.205112F;
			this.Line733.Width = 0F;
			this.Line733.X1 = 2.13872F;
			this.Line733.X2 = 2.13872F;
			this.Line733.Y1 = 4.205112F;
			this.Line733.Y2 = 4.313112F;
			// 
			// Line734
			// 
			this.Line734.Height = 0.1079998F;
			this.Line734.Left = 2.28472F;
			this.Line734.LineWeight = 1F;
			this.Line734.Name = "Line734";
			this.Line734.Top = 4.205112F;
			this.Line734.Width = 0F;
			this.Line734.X1 = 2.28472F;
			this.Line734.X2 = 2.28472F;
			this.Line734.Y1 = 4.205112F;
			this.Line734.Y2 = 4.313112F;
			// 
			// Line735
			// 
			this.Line735.Height = 0.1079998F;
			this.Line735.Left = 2.43072F;
			this.Line735.LineWeight = 1F;
			this.Line735.Name = "Line735";
			this.Line735.Top = 4.205112F;
			this.Line735.Width = 0F;
			this.Line735.X1 = 2.43072F;
			this.Line735.X2 = 2.43072F;
			this.Line735.Y1 = 4.205112F;
			this.Line735.Y2 = 4.313112F;
			// 
			// Line736
			// 
			this.Line736.Height = 0.1079998F;
			this.Line736.Left = 2.57672F;
			this.Line736.LineWeight = 1F;
			this.Line736.Name = "Line736";
			this.Line736.Top = 4.205112F;
			this.Line736.Width = 0F;
			this.Line736.X1 = 2.57672F;
			this.Line736.X2 = 2.57672F;
			this.Line736.Y1 = 4.205112F;
			this.Line736.Y2 = 4.313112F;
			// 
			// Line737
			// 
			this.Line737.Height = 0.1079998F;
			this.Line737.Left = 2.72272F;
			this.Line737.LineWeight = 1F;
			this.Line737.Name = "Line737";
			this.Line737.Top = 4.205112F;
			this.Line737.Width = 0F;
			this.Line737.X1 = 2.72272F;
			this.Line737.X2 = 2.72272F;
			this.Line737.Y1 = 4.205112F;
			this.Line737.Y2 = 4.313112F;
			// 
			// Line738
			// 
			this.Line738.Height = 0.1879988F;
			this.Line738.Left = 2.892664F;
			this.Line738.LineWeight = 1F;
			this.Line738.Name = "Line738";
			this.Line738.Top = 4.125113F;
			this.Line738.Width = 0F;
			this.Line738.X1 = 2.892664F;
			this.Line738.X2 = 2.892664F;
			this.Line738.Y1 = 4.125113F;
			this.Line738.Y2 = 4.313112F;
			// 
			// Line739
			// 
			this.Line739.Height = 0.1879988F;
			this.Line739.Left = 3.47572F;
			this.Line739.LineWeight = 1F;
			this.Line739.Name = "Line739";
			this.Line739.Top = 4.125113F;
			this.Line739.Width = 0F;
			this.Line739.X1 = 3.47572F;
			this.Line739.X2 = 3.47572F;
			this.Line739.Y1 = 4.125113F;
			this.Line739.Y2 = 4.313112F;
			// 
			// Line740
			// 
			this.Line740.Height = 0.1879988F;
			this.Line740.Left = 4.650722F;
			this.Line740.LineWeight = 1F;
			this.Line740.Name = "Line740";
			this.Line740.Top = 4.125113F;
			this.Line740.Width = 0F;
			this.Line740.X1 = 4.650722F;
			this.Line740.X2 = 4.650722F;
			this.Line740.Y1 = 4.125113F;
			this.Line740.Y2 = 4.313112F;
			// 
			// Label1567
			// 
			this.Label1567.Height = 0.09F;
			this.Label1567.HyperLink = null;
			this.Label1567.Left = 2.89272F;
			this.Label1567.Name = "Label1567";
			this.Label1567.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1567.Text = "※　　種　別";
			this.Label1567.Top = 4.125113F;
			this.Label1567.Width = 0.583F;
			// 
			// Label1568
			// 
			this.Label1568.Height = 0.09F;
			this.Label1568.HyperLink = null;
			this.Label1568.Left = 3.47572F;
			this.Label1568.Name = "Label1568";
			this.Label1568.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1568.Text = "※　　　　　整　理　番　号";
			this.Label1568.Top = 4.125113F;
			this.Label1568.Width = 1.175F;
			// 
			// Label1569
			// 
			this.Label1569.Height = 0.08F;
			this.Label1569.HyperLink = null;
			this.Label1569.Left = 4.650722F;
			this.Label1569.Name = "Label1569";
			this.Label1569.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1569.Text = "※";
			this.Label1569.Top = 4.125113F;
			this.Label1569.Width = 0.923F;
			// 
			// Label1570
			// 
			this.Label1570.Height = 0.08F;
			this.Label1570.HyperLink = null;
			this.Label1570.Left = 0.3867193F;
			this.Label1570.Name = "Label1570";
			this.Label1570.Style = "font-size: 4.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1570.Text = "※";
			this.Label1570.Top = 4.125113F;
			this.Label1570.Width = 2.506F;
			// 
			// Label1571
			// 
			this.Label1571.Height = 0.234F;
			this.Label1571.HyperLink = null;
			this.Label1571.Left = 0.6787216F;
			this.Label1571.Name = "Label1571";
			this.Label1571.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1571.Text = "所";
			this.Label1571.Top = 4.704113F;
			this.Label1571.Width = 0.188F;
			// 
			// Line741
			// 
			this.Line741.Height = 0.1559992F;
			this.Line741.Left = 1.05572F;
			this.Line741.LineWeight = 1F;
			this.Line741.Name = "Line741";
			this.Line741.Top = 4.313112F;
			this.Line741.Width = 0F;
			this.Line741.X1 = 1.05572F;
			this.Line741.X2 = 1.05572F;
			this.Line741.Y1 = 4.313112F;
			this.Line741.Y2 = 4.469111F;
			// 
			// Label1572
			// 
			this.Label1572.Height = 0.156F;
			this.Label1572.HyperLink = null;
			this.Label1572.Left = 0.6787216F;
			this.Label1572.Name = "Label1572";
			this.Label1572.Style = "font-size: 6pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.Label1572.Text = "※区分";
			this.Label1572.Top = 4.313112F;
			this.Label1572.Width = 0.377F;
			// 
			// Label1573
			// 
			this.Label1573.Height = 0.155F;
			this.Label1573.HyperLink = null;
			this.Label1573.Left = 0.6987205F;
			this.Label1573.Name = "Label1573";
			this.Label1573.Style = "font-size: 6pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.Label1573.Text = "（摘要）に控除対象配偶者、扶養親族の氏名、続柄及び前職分の加算額、支払者等を記入してください。";
			this.Label1573.Top = 7.720111F;
			this.Label1573.Width = 3.9995F;
			// 
			// Line742
			// 
			this.Line742.Height = 0F;
			this.Line742.Left = 0.6787216F;
			this.Line742.LineWeight = 1F;
			this.Line742.Name = "Line742";
			this.Line742.Top = 4.469111F;
			this.Line742.Width = 2.536998F;
			this.Line742.X1 = 0.6787216F;
			this.Line742.X2 = 3.21572F;
			this.Line742.Y1 = 4.469111F;
			this.Line742.Y2 = 4.469111F;
			// 
			// Label1579
			// 
			this.Label1579.Height = 0.4375F;
			this.Label1579.HyperLink = null;
			this.Label1579.Left = 0.01072031F;
			this.Label1579.Name = "Label1579";
			this.Label1579.Style = "font-size: 25pt; font-weight: normal; text-align: left; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1579.Text = "○";
			this.Label1579.Top = 0.08344491F;
			this.Label1579.Width = 0.375F;
			// 
			// Label1580
			// 
			this.Label1580.Height = 1.125F;
			this.Label1580.HyperLink = null;
			this.Label1580.Left = 0.1357203F;
			this.Label1580.Name = "Label1580";
			this.Label1580.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1580.Text = "給与支払報告書";
			this.Label1580.Top = 0.7084449F;
			this.Label1580.Width = 0.25F;
			// 
			// Label1581
			// 
			this.Label1581.Angle = 2700;
			this.Label1581.Height = 0.188F;
			this.Label1581.HyperLink = null;
			this.Label1581.Left = 0.1357203F;
			this.Label1581.MultiLine = false;
			this.Label1581.Name = "Label1581";
			this.Label1581.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1581.Text = "（";
			this.Label1581.Top = 1.810528F;
			this.Label1581.Width = 0.251F;
			// 
			// Label1582
			// 
			this.Label1582.Height = 0.875F;
			this.Label1582.HyperLink = null;
			this.Label1582.Left = 0.1357203F;
			this.Label1582.Name = "Label1582";
			this.Label1582.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1582.Text = "個人別明細書";
			this.Label1582.Top = 2.000111F;
			this.Label1582.Width = 0.25F;
			// 
			// Label1583
			// 
			this.Label1583.Angle = 900;
			this.Label1583.Height = 0.1875F;
			this.Label1583.HyperLink = null;
			this.Label1583.Left = 0.1357203F;
			this.Label1583.Name = "Label1583";
			this.Label1583.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1583.Text = "（";
			this.Label1583.Top = 2.864695F;
			this.Label1583.Width = 0.25F;
			// 
			// Label1589
			// 
			this.Label1589.Angle = 2700;
			this.Label1589.Height = 0.1164999F;
			this.Label1589.HyperLink = null;
			this.Label1589.Left = 0.2162204F;
			this.Label1589.Name = "Label1589";
			this.Label1589.Style = "font-size: 5.5pt; text-align: center; vertical-align: bottom; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1589.Text = "(";
			this.Label1589.Top = 7.091114F;
			this.Label1589.Width = 0.17F;
			// 
			// Label1590
			// 
			this.Label1590.Height = 1.0625F;
			this.Label1590.HyperLink = null;
			this.Label1590.Left = 0.1982203F;
			this.Label1590.Name = "Label1590";
			this.Label1590.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1590.Text = "給与支払報告書";
			this.Label1590.Top = 4.875113F;
			this.Label1590.Width = 0.1875F;
			// 
			// Label1591
			// 
			this.Label1591.Angle = 2700;
			this.Label1591.Height = 0.1875F;
			this.Label1591.HyperLink = null;
			this.Label1591.Left = 0.1982203F;
			this.Label1591.MultiLine = false;
			this.Label1591.Name = "Label1591";
			this.Label1591.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1591.Text = "（";
			this.Label1591.Top = 5.937613F;
			this.Label1591.Width = 0.1875F;
			// 
			// Label1592
			// 
			this.Label1592.Height = 0.875F;
			this.Label1592.HyperLink = null;
			this.Label1592.Left = 0.1982203F;
			this.Label1592.Name = "Label1592";
			this.Label1592.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1592.Text = "個人別明細書";
			this.Label1592.Top = 6.125112F;
			this.Label1592.Width = 0.1875F;
			// 
			// Label1593
			// 
			this.Label1593.Angle = 900;
			this.Label1593.Height = 0.1875F;
			this.Label1593.HyperLink = null;
			this.Label1593.Left = 0.1982203F;
			this.Label1593.MultiLine = false;
			this.Label1593.Name = "Label1593";
			this.Label1593.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1593.Text = "（";
			this.Label1593.Top = 7.020946F;
			this.Label1593.Width = 0.1875F;
			// 
			// Label1594
			// 
			this.Label1594.Height = 0.125F;
			this.Label1594.HyperLink = null;
			this.Label1594.Left = 1.32322F;
			this.Label1594.Name = "Label1594";
			this.Label1594.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1594.Text = "内";
			this.Label1594.Top = 5.110611F;
			this.Label1594.Width = 0.1F;
			// 
			// Label1597
			// 
			this.Label1597.Height = 0.125F;
			this.Label1597.HyperLink = null;
			this.Label1597.Left = 3.32222F;
			this.Label1597.Name = "Label1597";
			this.Label1597.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1597.Text = "内";
			this.Label1597.Top = 5.75311F;
			this.Label1597.Width = 0.125F;
			// 
			// Label1598
			// 
			this.Label1598.Height = 0.125F;
			this.Label1598.HyperLink = null;
			this.Label1598.Left = 3.32222F;
			this.Label1598.Name = "Label1598";
			this.Label1598.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1598.Text = "内";
			this.Label1598.Top = 1.648945F;
			this.Label1598.Width = 0.125F;
			// 
			// Line754
			// 
			this.Line754.Height = 0F;
			this.Line754.Left = 0.3862205F;
			this.Line754.LineWeight = 1F;
			this.Line754.Name = "Line754";
			this.Line754.Top = 5.941112F;
			this.Line754.Width = 0.3999996F;
			this.Line754.X1 = 0.3862205F;
			this.Line754.X2 = 0.7862201F;
			this.Line754.Y1 = 5.941112F;
			this.Line754.Y2 = 5.941112F;
			// 
			// Line755
			// 
			this.Line755.Height = 0F;
			this.Line755.Left = 0.3862205F;
			this.Line755.LineWeight = 1F;
			this.Line755.Name = "Line755";
			this.Line755.Top = 1.836945F;
			this.Line755.Width = 0.3999996F;
			this.Line755.X1 = 0.3862205F;
			this.Line755.X2 = 0.7862201F;
			this.Line755.Y1 = 1.836945F;
			this.Line755.Y2 = 1.836945F;
			// 
			// YlyEdCalYear5Text
			// 
			this.YlyEdCalYear5Text.CanGrow = false;
			this.YlyEdCalYear5Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear5Text.Height = 0.406F;
			this.YlyEdCalYear5Text.Left = 0.04822022F;
			this.YlyEdCalYear5Text.Name = "YlyEdCalYear5Text";
			this.YlyEdCalYear5Text.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; wh" +
    "ite-space: nowrap; ddo-char-set: 1";
			this.YlyEdCalYear5Text.Text = "ああ";
			this.YlyEdCalYear5Text.Top = 0.0839449F;
			this.YlyEdCalYear5Text.Visible = false;
			this.YlyEdCalYear5Text.Width = 0.338F;
			// 
			// YlyEdCalYear6Text
			// 
			this.YlyEdCalYear6Text.CanGrow = false;
			this.YlyEdCalYear6Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear6Text.Height = 0.406F;
			this.YlyEdCalYear6Text.Left = 0.04872042F;
			this.YlyEdCalYear6Text.Name = "YlyEdCalYear6Text";
			this.YlyEdCalYear6Text.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; wh" +
    "ite-space: nowrap; ddo-char-set: 1";
			this.YlyEdCalYear6Text.Text = "ああ";
			this.YlyEdCalYear6Text.Top = 0.09094491F;
			this.YlyEdCalYear6Text.Width = 0.338F;
			// 
			// Label1599
			// 
			this.Label1599.Height = 0.4375F;
			this.Label1599.HyperLink = null;
			this.Label1599.Left = 0.01072031F;
			this.Label1599.Name = "Label1599";
			this.Label1599.Style = "font-size: 25pt; font-weight: normal; text-align: left; vertical-align: middle; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1599.Text = "○";
			this.Label1599.Top = 4.187613F;
			this.Label1599.Width = 0.375F;
			// 
			// YlyEdCalYear8Text
			// 
			this.YlyEdCalYear8Text.CanGrow = false;
			this.YlyEdCalYear8Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear8Text.Height = 0.406F;
			this.YlyEdCalYear8Text.Left = 0.04822022F;
			this.YlyEdCalYear8Text.Name = "YlyEdCalYear8Text";
			this.YlyEdCalYear8Text.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; wh" +
    "ite-space: nowrap; ddo-char-set: 1";
			this.YlyEdCalYear8Text.Text = "ああ";
			this.YlyEdCalYear8Text.Top = 4.188112F;
			this.YlyEdCalYear8Text.Width = 0.3375001F;
			// 
			// YlyEdCalYear7Text
			// 
			this.YlyEdCalYear7Text.CanGrow = false;
			this.YlyEdCalYear7Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear7Text.Height = 0.406F;
			this.YlyEdCalYear7Text.Left = 0.04872042F;
			this.YlyEdCalYear7Text.Name = "YlyEdCalYear7Text";
			this.YlyEdCalYear7Text.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; wh" +
    "ite-space: nowrap; ddo-char-set: 1";
			this.YlyEdCalYear7Text.Text = "ああ";
			this.YlyEdCalYear7Text.Top = 4.190113F;
			this.YlyEdCalYear7Text.Visible = false;
			this.YlyEdCalYear7Text.Width = 0.3375001F;
			// 
			// Line756
			// 
			this.Line756.Height = 0F;
			this.Line756.Left = 3.32272F;
			this.Line756.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line756.LineWeight = 1F;
			this.Line756.Name = "Line756";
			this.Line756.Top = 1.880945F;
			this.Line756.Width = 0.5319989F;
			this.Line756.X1 = 3.32272F;
			this.Line756.X2 = 3.854719F;
			this.Line756.Y1 = 1.880945F;
			this.Line756.Y2 = 1.880945F;
			// 
			// Line757
			// 
			this.Line757.Height = 0F;
			this.Line757.Left = 3.32272F;
			this.Line757.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line757.LineWeight = 1F;
			this.Line757.Name = "Line757";
			this.Line757.Top = 5.99011F;
			this.Line757.Width = 0.5319989F;
			this.Line757.X1 = 3.32272F;
			this.Line757.X2 = 3.854719F;
			this.Line757.Y1 = 5.99011F;
			this.Line757.Y2 = 5.99011F;
			// 
			// summary2Digit2Text
			// 
			this.summary2Digit2Text.CanGrow = false;
			this.summary2Digit2Text.DataField = "SUMMARY_2_DIGIT";
			this.summary2Digit2Text.Height = 0.113F;
			this.summary2Digit2Text.Left = 0.3857203F;
			this.summary2Digit2Text.Name = "summary2Digit2Text";
			this.summary2Digit2Text.Style = "font-size: 5.2pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.summary2Digit2Text.Text = "あいうえおかきくけこさしすせそたちつてとあいうえおかきくけこさしすせそたちつてと";
			this.summary2Digit2Text.Top = 3.810945F;
			this.summary2Digit2Text.Width = 3.5F;
			// 
			// summary2Digit3Text
			// 
			this.summary2Digit3Text.CanGrow = false;
			this.summary2Digit3Text.DataField = "SUMMARY_2_DIGIT";
			this.summary2Digit3Text.Height = 0.113F;
			this.summary2Digit3Text.Left = 0.4057203F;
			this.summary2Digit3Text.Name = "summary2Digit3Text";
			this.summary2Digit3Text.Style = "font-size: 5.2pt; text-align: left; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.summary2Digit3Text.Text = "あいうえおかきくけこさしすせそたちつてとあいうえおかきくけこさしすせそたちつてと";
			this.summary2Digit3Text.Top = 7.840111F;
			this.summary2Digit3Text.Width = 3.5F;
			// 
			// summary0Digit2Text
			// 
			this.summary0Digit2Text.CanGrow = false;
			this.summary0Digit2Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit2Text.Height = 0.125F;
			this.summary0Digit2Text.Left = 0.406F;
			this.summary0Digit2Text.MultiLine = false;
			this.summary0Digit2Text.Name = "summary0Digit2Text";
			this.summary0Digit2Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit2Text.Top = 1.981F;
			this.summary0Digit2Text.Width = 3.695F;
			// 
			// label28
			// 
			this.label28.Height = 0.165F;
			this.label28.HyperLink = null;
			this.label28.Left = 1.486F;
			this.label28.Name = "label28";
			this.label28.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label28.Text = "乙";
			this.label28.Top = 2.598F;
			this.label28.Width = 0.2F;
			// 
			// label34
			// 
			this.label34.Height = 0.165F;
			this.label34.HyperLink = null;
			this.label34.Left = 1.486F;
			this.label34.Name = "label34";
			this.label34.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label34.Text = "欄";
			this.label34.Top = 2.763F;
			this.label34.Width = 0.2F;
			// 
			// label36
			// 
			this.label36.Height = 0.21F;
			this.label36.HyperLink = null;
			this.label36.Left = 1.719F;
			this.label36.Name = "label36";
			this.label36.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label36.Text = "特別";
			this.label36.Top = 2.712F;
			this.label36.Width = 0.1249999F;
			// 
			// label43
			// 
			this.label43.Height = 0.21F;
			this.label43.HyperLink = null;
			this.label43.Left = 2.323F;
			this.label43.Name = "label43";
			this.label43.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label43.Text = "特別";
			this.label43.Top = 2.712F;
			this.label43.Width = 0.1249998F;
			// 
			// label45
			// 
			this.label45.Height = 0.165F;
			this.label45.HyperLink = null;
			this.label45.Left = 2.486F;
			this.label45.Name = "label45";
			this.label45.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label45.Text = "寡";
			this.label45.Top = 2.598F;
			this.label45.Width = 0.2F;
			// 
			// label46
			// 
			this.label46.Height = 0.165F;
			this.label46.HyperLink = null;
			this.label46.Left = 2.486F;
			this.label46.Name = "label46";
			this.label46.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label46.Text = "夫";
			this.label46.Top = 2.763F;
			this.label46.Width = 0.2F;
			// 
			// line17
			// 
			this.line17.Height = 0.51F;
			this.line17.Left = 0.8232203F;
			this.line17.LineWeight = 1F;
			this.line17.Name = "line17";
			this.line17.Top = 2.6F;
			this.line17.Width = 0F;
			this.line17.X1 = 0.8232203F;
			this.line17.X2 = 0.8232203F;
			this.line17.Y1 = 2.6F;
			this.line17.Y2 = 3.11F;
			// 
			// line18
			// 
			this.line18.Height = 0.51F;
			this.line18.Left = 1.044053F;
			this.line18.LineWeight = 1F;
			this.line18.Name = "line18";
			this.line18.Top = 2.6F;
			this.line18.Width = 0F;
			this.line18.X1 = 1.044053F;
			this.line18.X2 = 1.044053F;
			this.line18.Y1 = 2.6F;
			this.line18.Y2 = 3.11F;
			// 
			// line19
			// 
			this.line19.Height = 0F;
			this.line19.Left = 1.685721F;
			this.line19.LineWeight = 1F;
			this.line19.Name = "line19";
			this.line19.Top = 2.69F;
			this.line19.Width = 0.7999989F;
			this.line19.X1 = 1.685721F;
			this.line19.X2 = 2.48572F;
			this.line19.Y1 = 2.69F;
			this.line19.Y2 = 2.69F;
			// 
			// line20
			// 
			this.line20.Height = 0.51F;
			this.line20.Left = 1.48572F;
			this.line20.LineWeight = 1F;
			this.line20.Name = "line20";
			this.line20.Top = 2.6F;
			this.line20.Width = 0F;
			this.line20.X1 = 1.48572F;
			this.line20.X2 = 1.48572F;
			this.line20.Y1 = 2.6F;
			this.line20.Y2 = 3.11F;
			// 
			// line23
			// 
			this.line23.Height = 0.51F;
			this.line23.Left = 2.48572F;
			this.line23.LineWeight = 1F;
			this.line23.Name = "line23";
			this.line23.Top = 2.6F;
			this.line23.Width = 0F;
			this.line23.X1 = 2.48572F;
			this.line23.X2 = 2.48572F;
			this.line23.Y1 = 2.6F;
			this.line23.Y2 = 3.11F;
			// 
			// line24
			// 
			this.line24.Height = 0.51F;
			this.line24.Left = 2.685721F;
			this.line24.LineWeight = 1F;
			this.line24.Name = "line24";
			this.line24.Top = 2.6F;
			this.line24.Width = 0F;
			this.line24.X1 = 2.685721F;
			this.line24.X2 = 2.685721F;
			this.line24.Y1 = 2.6F;
			this.line24.Y2 = 3.11F;
			// 
			// line25
			// 
			this.line25.Height = 0.4199998F;
			this.line25.Left = 1.88572F;
			this.line25.LineWeight = 1F;
			this.line25.Name = "line25";
			this.line25.Top = 2.69F;
			this.line25.Width = 0F;
			this.line25.X1 = 1.88572F;
			this.line25.X2 = 1.88572F;
			this.line25.Y1 = 2.69F;
			this.line25.Y2 = 3.11F;
			// 
			// line26
			// 
			this.line26.Height = 0.51F;
			this.line26.Left = 1.68572F;
			this.line26.LineWeight = 1F;
			this.line26.Name = "line26";
			this.line26.Top = 2.6F;
			this.line26.Width = 0F;
			this.line26.X1 = 1.68572F;
			this.line26.X2 = 1.68572F;
			this.line26.Y1 = 2.6F;
			this.line26.Y2 = 3.11F;
			// 
			// line27
			// 
			this.line27.Height = 1.031F;
			this.line27.Left = 1.264887F;
			this.line27.LineWeight = 1F;
			this.line27.Name = "line27";
			this.line27.Top = 2.6F;
			this.line27.Width = 0F;
			this.line27.X1 = 1.264887F;
			this.line27.X2 = 1.264887F;
			this.line27.Y1 = 2.6F;
			this.line27.Y2 = 3.631F;
			// 
			// label60
			// 
			this.label60.Height = 0.165F;
			this.label60.HyperLink = null;
			this.label60.Left = 1.486F;
			this.label60.Name = "label60";
			this.label60.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label60.Text = "乙";
			this.label60.Top = 6.703F;
			this.label60.Width = 0.2F;
			// 
			// label61
			// 
			this.label61.Height = 0.165F;
			this.label61.HyperLink = null;
			this.label61.Left = 1.486F;
			this.label61.Name = "label61";
			this.label61.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label61.Text = "欄";
			this.label61.Top = 6.858F;
			this.label61.Width = 0.2F;
			// 
			// label62
			// 
			this.label62.Height = 0.09F;
			this.label62.HyperLink = null;
			this.label62.Left = 1.688F;
			this.label62.Name = "label62";
			this.label62.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label62.Text = "本人が障害者";
			this.label62.Top = 6.712F;
			this.label62.Width = 0.394F;
			// 
			// label66
			// 
			this.label66.Height = 0.21F;
			this.label66.HyperLink = null;
			this.label66.Left = 2.125F;
			this.label66.Name = "label66";
			this.label66.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label66.Text = "一般";
			this.label66.Top = 6.816F;
			this.label66.Width = 0.1250001F;
			// 
			// label68
			// 
			this.label68.Height = 0.21F;
			this.label68.HyperLink = null;
			this.label68.Left = 2.323F;
			this.label68.Name = "label68";
			this.label68.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label68.Text = "特別";
			this.label68.Top = 6.816F;
			this.label68.Width = 0.1250001F;
			// 
			// label70
			// 
			this.label70.Height = 0.165F;
			this.label70.HyperLink = null;
			this.label70.Left = 2.486F;
			this.label70.Name = "label70";
			this.label70.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label70.Text = "寡";
			this.label70.Top = 6.703F;
			this.label70.Width = 0.2F;
			// 
			// label71
			// 
			this.label71.Height = 0.165F;
			this.label71.HyperLink = null;
			this.label71.Left = 2.486F;
			this.label71.Name = "label71";
			this.label71.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label71.Text = "夫";
			this.label71.Top = 6.858F;
			this.label71.Width = 0.2F;
			// 
			// label75
			// 
			this.label75.Height = 0.29F;
			this.label75.HyperLink = null;
			this.label75.Left = 1.307F;
			this.label75.Name = "label75";
			this.label75.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label75.Text = "災害者";
			this.label75.Top = 6.732F;
			this.label75.Width = 0.135F;
			// 
			// label76
			// 
			this.label76.Height = 0.29F;
			this.label76.HyperLink = null;
			this.label76.Left = 0.865F;
			this.label76.Name = "label76";
			this.label76.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.label76.Text = "外国人";
			this.label76.Top = 6.732F;
			this.label76.Width = 0.135F;
			// 
			// line28
			// 
			this.line28.Height = 1.035F;
			this.line28.Left = 0.6057201F;
			this.line28.LineWeight = 1F;
			this.line28.Name = "line28";
			this.line28.Top = 6.7F;
			this.line28.Width = 0F;
			this.line28.X1 = 0.6057201F;
			this.line28.X2 = 0.6057201F;
			this.line28.Y1 = 6.7F;
			this.line28.Y2 = 7.735F;
			// 
			// line29
			// 
			this.line29.Height = 0.5100002F;
			this.line29.Left = 0.8232203F;
			this.line29.LineWeight = 1F;
			this.line29.Name = "line29";
			this.line29.Top = 6.7F;
			this.line29.Width = 0F;
			this.line29.X1 = 0.8232203F;
			this.line29.X2 = 0.8232203F;
			this.line29.Y1 = 6.7F;
			this.line29.Y2 = 7.21F;
			// 
			// line30
			// 
			this.line30.Height = 0.5100002F;
			this.line30.Left = 1.044052F;
			this.line30.LineWeight = 1F;
			this.line30.Name = "line30";
			this.line30.Top = 6.7F;
			this.line30.Width = 0F;
			this.line30.X1 = 1.044052F;
			this.line30.X2 = 1.044052F;
			this.line30.Y1 = 6.7F;
			this.line30.Y2 = 7.21F;
			// 
			// line31
			// 
			this.line31.Height = 0F;
			this.line31.Left = 1.685721F;
			this.line31.LineWeight = 1F;
			this.line31.Name = "line31";
			this.line31.Top = 6.8F;
			this.line31.Width = 0.7999989F;
			this.line31.X1 = 1.685721F;
			this.line31.X2 = 2.48572F;
			this.line31.Y1 = 6.8F;
			this.line31.Y2 = 6.8F;
			// 
			// line32
			// 
			this.line32.Height = 0.5100002F;
			this.line32.Left = 1.48572F;
			this.line32.LineWeight = 1F;
			this.line32.Name = "line32";
			this.line32.Top = 6.7F;
			this.line32.Width = 0F;
			this.line32.X1 = 1.48572F;
			this.line32.X2 = 1.48572F;
			this.line32.Y1 = 6.7F;
			this.line32.Y2 = 7.21F;
			// 
			// line36
			// 
			this.line36.Height = 0.5100002F;
			this.line36.Left = 2.685721F;
			this.line36.LineWeight = 1F;
			this.line36.Name = "line36";
			this.line36.Top = 6.7F;
			this.line36.Width = 0F;
			this.line36.X1 = 2.685721F;
			this.line36.X2 = 2.685721F;
			this.line36.Y1 = 6.7F;
			this.line36.Y2 = 7.21F;
			// 
			// line39
			// 
			this.line39.Height = 1.035F;
			this.line39.Left = 1.257F;
			this.line39.LineWeight = 1F;
			this.line39.Name = "line39";
			this.line39.Top = 6.7F;
			this.line39.Width = 0F;
			this.line39.X1 = 1.257F;
			this.line39.X2 = 1.257F;
			this.line39.Y1 = 6.7F;
			this.line39.Y2 = 7.735F;
			// 
			// Line647
			// 
			this.Line647.Height = 3.609999F;
			this.Line647.Left = 0.3862205F;
			this.Line647.LineWeight = 1F;
			this.Line647.Name = "Line647";
			this.Line647.Top = 4.125113F;
			this.Line647.Width = 0F;
			this.Line647.X1 = 0.3862205F;
			this.Line647.X2 = 0.3862205F;
			this.Line647.Y1 = 4.125113F;
			this.Line647.Y2 = 7.735112F;
			// 
			// line21
			// 
			this.line21.Height = 0.51F;
			this.line21.Left = 2.08572F;
			this.line21.LineWeight = 1F;
			this.line21.Name = "line21";
			this.line21.Top = 2.6F;
			this.line21.Width = 0F;
			this.line21.X1 = 2.08572F;
			this.line21.X2 = 2.08572F;
			this.line21.Y1 = 2.6F;
			this.line21.Y2 = 3.11F;
			// 
			// line38
			// 
			this.line38.Height = 0.5100002F;
			this.line38.Left = 1.68572F;
			this.line38.LineWeight = 1F;
			this.line38.Name = "line38";
			this.line38.Top = 6.7F;
			this.line38.Width = 0F;
			this.line38.X1 = 1.68572F;
			this.line38.X2 = 1.68572F;
			this.line38.Y1 = 6.7F;
			this.line38.Y2 = 7.21F;
			// 
			// line37
			// 
			this.line37.Height = 0.4099998F;
			this.line37.Left = 1.88572F;
			this.line37.LineWeight = 1F;
			this.line37.Name = "line37";
			this.line37.Top = 6.8F;
			this.line37.Width = 0F;
			this.line37.X1 = 1.88572F;
			this.line37.X2 = 1.88572F;
			this.line37.Y1 = 6.8F;
			this.line37.Y2 = 7.21F;
			// 
			// Line654
			// 
			this.Line654.Height = 0F;
			this.Line654.Left = 0.3862205F;
			this.Line654.LineWeight = 1F;
			this.Line654.Name = "Line654";
			this.Line654.Top = 7.03F;
			this.Line654.Width = 5.186999F;
			this.Line654.X1 = 0.3862205F;
			this.Line654.X2 = 5.57322F;
			this.Line654.Y1 = 7.03F;
			this.Line654.Y2 = 7.03F;
			// 
			// line33
			// 
			this.line33.Height = 0.5100002F;
			this.line33.Left = 2.08572F;
			this.line33.LineWeight = 1F;
			this.line33.Name = "line33";
			this.line33.Top = 6.7F;
			this.line33.Width = 0F;
			this.line33.X1 = 2.08572F;
			this.line33.X2 = 2.08572F;
			this.line33.Y1 = 6.7F;
			this.line33.Y2 = 7.21F;
			// 
			// line34
			// 
			this.line34.Height = 0.4099998F;
			this.line34.Left = 2.28572F;
			this.line34.LineWeight = 1F;
			this.line34.Name = "line34";
			this.line34.Top = 6.8F;
			this.line34.Width = 0F;
			this.line34.X1 = 2.28572F;
			this.line34.X2 = 2.28572F;
			this.line34.Y1 = 6.8F;
			this.line34.Y2 = 7.21F;
			// 
			// line35
			// 
			this.line35.Height = 0.5100002F;
			this.line35.Left = 2.48572F;
			this.line35.LineWeight = 1F;
			this.line35.Name = "line35";
			this.line35.Top = 6.7F;
			this.line35.Width = 0F;
			this.line35.X1 = 2.48572F;
			this.line35.X2 = 2.48572F;
			this.line35.Y1 = 6.7F;
			this.line35.Y2 = 7.21F;
			// 
			// line22
			// 
			this.line22.Height = 0.4199998F;
			this.line22.Left = 2.28572F;
			this.line22.LineWeight = 1F;
			this.line22.Name = "line22";
			this.line22.Top = 2.69F;
			this.line22.Width = 0F;
			this.line22.X1 = 2.28572F;
			this.line22.X2 = 2.28572F;
			this.line22.Y1 = 2.69F;
			this.line22.Y2 = 3.11F;
			// 
			// label47
			// 
			this.label47.Height = 0.125F;
			this.label47.HyperLink = null;
			this.label47.Left = 0.49F;
			this.label47.Name = "label47";
			this.label47.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label47.Text = "人";
			this.label47.Top = 2.931F;
			this.label47.Width = 0.125F;
			// 
			// YoungDpndNum2Text
			// 
			this.YoungDpndNum2Text.CanGrow = false;
			this.YoungDpndNum2Text.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNum2Text.Height = 0.125F;
			this.YoungDpndNum2Text.Left = 0.386F;
			this.YoungDpndNum2Text.Name = "YoungDpndNum2Text";
			this.YoungDpndNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNum2Text.Text = "Z6";
			this.YoungDpndNum2Text.Top = 2.973F;
			this.YoungDpndNum2Text.Width = 0.1249998F;
			// 
			// Line463
			// 
			this.Line463.Height = 3.61F;
			this.Line463.Left = 0.3862205F;
			this.Line463.LineWeight = 1F;
			this.Line463.Name = "Line463";
			this.Line463.Top = 0.02094489F;
			this.Line463.Width = 0F;
			this.Line463.X1 = 0.3862205F;
			this.Line463.X2 = 0.3862205F;
			this.Line463.Y1 = 0.02094489F;
			this.Line463.Y2 = 3.630945F;
			// 
			// Line479
			// 
			this.Line479.Height = 0F;
			this.Line479.Left = 0.3862205F;
			this.Line479.LineWeight = 1F;
			this.Line479.Name = "Line479";
			this.Line479.Top = 2.93F;
			this.Line479.Width = 5.186999F;
			this.Line479.X1 = 0.3862205F;
			this.Line479.X2 = 5.57322F;
			this.Line479.Y1 = 2.93F;
			this.Line479.Y2 = 2.93F;
			// 
			// line16
			// 
			this.line16.Height = 1.031F;
			this.line16.Left = 0.6023876F;
			this.line16.LineWeight = 1F;
			this.line16.Name = "line16";
			this.line16.Top = 2.6F;
			this.line16.Width = 0F;
			this.line16.X1 = 0.6023876F;
			this.line16.X2 = 0.6023876F;
			this.line16.Y1 = 2.6F;
			this.line16.Y2 = 3.631F;
			// 
			// Line480
			// 
			this.Line480.Height = 0F;
			this.Line480.Left = 0.3862205F;
			this.Line480.LineWeight = 1F;
			this.Line480.Name = "Line480";
			this.Line480.Top = 3.11F;
			this.Line480.Width = 5.186999F;
			this.Line480.X1 = 0.3862205F;
			this.Line480.X2 = 5.57322F;
			this.Line480.Y1 = 3.11F;
			this.Line480.Y2 = 3.11F;
			// 
			// Line648
			// 
			this.Line648.Height = 0F;
			this.Line648.Left = 0.3862205F;
			this.Line648.LineWeight = 1F;
			this.Line648.Name = "Line648";
			this.Line648.Top = 7.735112F;
			this.Line648.Width = 5.186999F;
			this.Line648.X1 = 0.3862205F;
			this.Line648.X2 = 5.57322F;
			this.Line648.Y1 = 7.735112F;
			this.Line648.Y2 = 7.735112F;
			// 
			// label1
			// 
			this.label1.Height = 0.161F;
			this.label1.HyperLink = null;
			this.label1.Left = 5.448F;
			this.label1.Name = "label1";
			this.label1.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label1.Text = "円";
			this.label1.Top = 2.136F;
			this.label1.Width = 0.125F;
			// 
			// line1
			// 
			this.line1.Height = 0F;
			this.line1.Left = 2.628F;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.Top = 2.12F;
			this.line1.Width = 2.945F;
			this.line1.X1 = 2.628F;
			this.line1.X2 = 5.573F;
			this.line1.Y1 = 2.12F;
			this.line1.Y2 = 2.12F;
			// 
			// label2
			// 
			this.label2.Height = 0.161F;
			this.label2.HyperLink = null;
			this.label2.Left = 5.448F;
			this.label2.Name = "label2";
			this.label2.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label2.Text = "円";
			this.label2.Top = 1.985F;
			this.label2.Width = 0.125F;
			// 
			// newLifeInsPensAmt2Text
			// 
			this.newLifeInsPensAmt2Text.CanGrow = false;
			this.newLifeInsPensAmt2Text.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.newLifeInsPensAmt2Text.Height = 0.153F;
			this.newLifeInsPensAmt2Text.Left = 4.811F;
			this.newLifeInsPensAmt2Text.Name = "newLifeInsPensAmt2Text";
			this.newLifeInsPensAmt2Text.OutputFormat = "#,##0";
			this.newLifeInsPensAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.newLifeInsPensAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsPensAmt2Text.Top = 2.136F;
			this.newLifeInsPensAmt2Text.Width = 0.647F;
			// 
			// newLifeInsCareAmt2Text
			// 
			this.newLifeInsCareAmt2Text.CanGrow = false;
			this.newLifeInsCareAmt2Text.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.newLifeInsCareAmt2Text.Height = 0.153F;
			this.newLifeInsCareAmt2Text.Left = 4.811F;
			this.newLifeInsCareAmt2Text.Name = "newLifeInsCareAmt2Text";
			this.newLifeInsCareAmt2Text.OutputFormat = "#,##0";
			this.newLifeInsCareAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.newLifeInsCareAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsCareAmt2Text.Top = 1.98F;
			this.newLifeInsCareAmt2Text.Width = 0.647F;
			// 
			// label3
			// 
			this.label3.Height = 0.153F;
			this.label3.HyperLink = null;
			this.label3.Left = 4.081F;
			this.label3.Name = "label3";
			this.label3.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label3.Text = "新個人年金保険料の金額";
			this.label3.Top = 2.142F;
			this.label3.Width = 0.755F;
			// 
			// label4
			// 
			this.label4.Height = 0.153F;
			this.label4.HyperLink = null;
			this.label4.Left = 4.081F;
			this.label4.Name = "label4";
			this.label4.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label4.Text = "介護医療保険料の金額";
			this.label4.Top = 1.985F;
			this.label4.Width = 0.755F;
			// 
			// line2
			// 
			this.line2.Height = 0.6079999F;
			this.line2.Left = 4.068F;
			this.line2.LineWeight = 1F;
			this.line2.Name = "line2";
			this.line2.Top = 1.992F;
			this.line2.Width = 0F;
			this.line2.X1 = 4.068F;
			this.line2.X2 = 4.068F;
			this.line2.Y1 = 1.992F;
			this.line2.Y2 = 2.6F;
			// 
			// label5
			// 
			this.label5.Height = 0.161F;
			this.label5.HyperLink = null;
			this.label5.Left = 3.956F;
			this.label5.Name = "label5";
			this.label5.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label5.Text = "円";
			this.label5.Top = 2.289F;
			this.label5.Width = 0.125F;
			// 
			// label6
			// 
			this.label6.Height = 0.161F;
			this.label6.HyperLink = null;
			this.label6.Left = 3.956F;
			this.label6.Name = "label6";
			this.label6.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label6.Text = "円";
			this.label6.Top = 2.446F;
			this.label6.Width = 0.125F;
			// 
			// newLifeInsGeneralAmt2Text
			// 
			this.newLifeInsGeneralAmt2Text.CanGrow = false;
			this.newLifeInsGeneralAmt2Text.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmt2Text.Height = 0.153F;
			this.newLifeInsGeneralAmt2Text.Left = 3.319F;
			this.newLifeInsGeneralAmt2Text.Name = "newLifeInsGeneralAmt2Text";
			this.newLifeInsGeneralAmt2Text.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.newLifeInsGeneralAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmt2Text.Top = 2.289F;
			this.newLifeInsGeneralAmt2Text.Width = 0.647F;
			// 
			// lifeInsGeneralAmt2Text
			// 
			this.lifeInsGeneralAmt2Text.CanGrow = false;
			this.lifeInsGeneralAmt2Text.DataField = "LIFE_INS_GENERAL_AMT";
			this.lifeInsGeneralAmt2Text.Height = 0.153F;
			this.lifeInsGeneralAmt2Text.Left = 3.319F;
			this.lifeInsGeneralAmt2Text.Name = "lifeInsGeneralAmt2Text";
			this.lifeInsGeneralAmt2Text.OutputFormat = "#,##0";
			this.lifeInsGeneralAmt2Text.Style = "font-family: ＭＳ 明朝; font-size: 6.8pt; text-align: right; vertical-align: middle; " +
    "white-space: nowrap; ddo-char-set: 1";
			this.lifeInsGeneralAmt2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsGeneralAmt2Text.Top = 2.446F;
			this.lifeInsGeneralAmt2Text.Width = 0.647F;
			// 
			// line3
			// 
			this.line3.Height = 0.48F;
			this.line3.Left = 3.323F;
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.Top = 2.12F;
			this.line3.Width = 0F;
			this.line3.X1 = 3.323F;
			this.line3.X2 = 3.323F;
			this.line3.Y1 = 2.12F;
			this.line3.Y2 = 2.6F;
			// 
			// label7
			// 
			this.label7.Height = 0.153F;
			this.label7.HyperLink = null;
			this.label7.Left = 2.649F;
			this.label7.Name = "label7";
			this.label7.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label7.Text = "新生命保険料の金額";
			this.label7.Top = 2.289F;
			this.label7.Width = 0.67F;
			// 
			// label8
			// 
			this.label8.Height = 0.153F;
			this.label8.HyperLink = null;
			this.label8.Left = 2.649F;
			this.label8.Name = "label8";
			this.label8.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label8.Text = "旧生命保険料の金額";
			this.label8.Top = 2.446F;
			this.label8.Width = 0.67F;
			// 
			// line4
			// 
			this.line4.Height = 0.48F;
			this.line4.Left = 2.628F;
			this.line4.LineWeight = 1F;
			this.line4.Name = "line4";
			this.line4.Top = 2.12F;
			this.line4.Width = 0F;
			this.line4.X1 = 2.628F;
			this.line4.X2 = 2.628F;
			this.line4.Y1 = 2.12F;
			this.line4.Y2 = 2.6F;
			// 
			// summary1Digit2Text
			// 
			this.summary1Digit2Text.CanGrow = false;
			this.summary1Digit2Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit2Text.Height = 0.558F;
			this.summary1Digit2Text.Left = 0.406F;
			this.summary1Digit2Text.Name = "summary1Digit2Text";
			this.summary1Digit2Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary1Digit2Text.Top = 2.063F;
			this.summary1Digit2Text.Width = 2.173F;
			// 
			// label9
			// 
			this.label9.Height = 0.161F;
			this.label9.HyperLink = null;
			this.label9.Left = 5.448F;
			this.label9.Name = "label9";
			this.label9.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label9.Text = "円";
			this.label9.Top = 6.238F;
			this.label9.Width = 0.125F;
			// 
			// line5
			// 
			this.line5.Height = 0F;
			this.line5.Left = 2.628F;
			this.line5.LineWeight = 1F;
			this.line5.Name = "line5";
			this.line5.Top = 6.232F;
			this.line5.Width = 2.945F;
			this.line5.X1 = 2.628F;
			this.line5.X2 = 5.573F;
			this.line5.Y1 = 6.232F;
			this.line5.Y2 = 6.232F;
			// 
			// newLifeInsPensAmt3Text
			// 
			this.newLifeInsPensAmt3Text.CanGrow = false;
			this.newLifeInsPensAmt3Text.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.newLifeInsPensAmt3Text.Height = 0.153F;
			this.newLifeInsPensAmt3Text.Left = 4.811F;
			this.newLifeInsPensAmt3Text.Name = "newLifeInsPensAmt3Text";
			this.newLifeInsPensAmt3Text.OutputFormat = "#,##0";
			this.newLifeInsPensAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsPensAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsPensAmt3Text.Top = 6.238F;
			this.newLifeInsPensAmt3Text.Width = 0.647F;
			// 
			// newLifeInsCareAmt3Text
			// 
			this.newLifeInsCareAmt3Text.CanGrow = false;
			this.newLifeInsCareAmt3Text.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.newLifeInsCareAmt3Text.Height = 0.153F;
			this.newLifeInsCareAmt3Text.Left = 4.811F;
			this.newLifeInsCareAmt3Text.Name = "newLifeInsCareAmt3Text";
			this.newLifeInsCareAmt3Text.OutputFormat = "#,##0";
			this.newLifeInsCareAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsCareAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsCareAmt3Text.Top = 6.085F;
			this.newLifeInsCareAmt3Text.Width = 0.647F;
			// 
			// label10
			// 
			this.label10.Height = 0.153F;
			this.label10.HyperLink = null;
			this.label10.Left = 4.081F;
			this.label10.Name = "label10";
			this.label10.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label10.Text = "新個人年金保険料の金額";
			this.label10.Top = 6.238F;
			this.label10.Width = 0.755F;
			// 
			// label11
			// 
			this.label11.Height = 0.153F;
			this.label11.HyperLink = null;
			this.label11.Left = 4.081F;
			this.label11.Name = "label11";
			this.label11.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label11.Text = "介護医療保険料の金額";
			this.label11.Top = 6.085F;
			this.label11.Width = 0.755F;
			// 
			// line6
			// 
			this.line6.Height = 0.6039996F;
			this.line6.Left = 4.068F;
			this.line6.LineWeight = 1F;
			this.line6.Name = "line6";
			this.line6.Top = 6.096F;
			this.line6.Width = 0F;
			this.line6.X1 = 4.068F;
			this.line6.X2 = 4.068F;
			this.line6.Y1 = 6.096F;
			this.line6.Y2 = 6.7F;
			// 
			// label12
			// 
			this.label12.Height = 0.161F;
			this.label12.HyperLink = null;
			this.label12.Left = 3.956F;
			this.label12.Name = "label12";
			this.label12.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label12.Text = "円";
			this.label12.Top = 6.238F;
			this.label12.Width = 0.125F;
			// 
			// label13
			// 
			this.label13.Height = 0.161F;
			this.label13.HyperLink = null;
			this.label13.Left = 3.956F;
			this.label13.Name = "label13";
			this.label13.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label13.Text = "円";
			this.label13.Top = 6.391F;
			this.label13.Width = 0.125F;
			// 
			// label14
			// 
			this.label14.Height = 0.161F;
			this.label14.HyperLink = null;
			this.label14.Left = 3.956F;
			this.label14.Name = "label14";
			this.label14.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label14.Text = "円";
			this.label14.Top = 6.551F;
			this.label14.Width = 0.125F;
			// 
			// newLifeInsGeneralAmt3Text
			// 
			this.newLifeInsGeneralAmt3Text.CanGrow = false;
			this.newLifeInsGeneralAmt3Text.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmt3Text.Height = 0.153F;
			this.newLifeInsGeneralAmt3Text.Left = 3.319F;
			this.newLifeInsGeneralAmt3Text.Name = "newLifeInsGeneralAmt3Text";
			this.newLifeInsGeneralAmt3Text.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsGeneralAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmt3Text.Top = 6.391F;
			this.newLifeInsGeneralAmt3Text.Width = 0.647F;
			// 
			// lifeInsGeneralAmt3Text
			// 
			this.lifeInsGeneralAmt3Text.CanGrow = false;
			this.lifeInsGeneralAmt3Text.DataField = "LIFE_INS_GENERAL_AMT";
			this.lifeInsGeneralAmt3Text.Height = 0.153F;
			this.lifeInsGeneralAmt3Text.Left = 3.319F;
			this.lifeInsGeneralAmt3Text.Name = "lifeInsGeneralAmt3Text";
			this.lifeInsGeneralAmt3Text.OutputFormat = "#,##0";
			this.lifeInsGeneralAmt3Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.lifeInsGeneralAmt3Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsGeneralAmt3Text.Top = 6.551F;
			this.lifeInsGeneralAmt3Text.Width = 0.647F;
			// 
			// line7
			// 
			this.line7.Height = 0.4679999F;
			this.line7.Left = 3.323F;
			this.line7.LineWeight = 1F;
			this.line7.Name = "line7";
			this.line7.Top = 6.232F;
			this.line7.Width = 0F;
			this.line7.X1 = 3.323F;
			this.line7.X2 = 3.323F;
			this.line7.Y1 = 6.232F;
			this.line7.Y2 = 6.7F;
			// 
			// label15
			// 
			this.label15.Height = 0.153F;
			this.label15.HyperLink = null;
			this.label15.Left = 2.649F;
			this.label15.Name = "label15";
			this.label15.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label15.Text = "新生命保険料の金額";
			this.label15.Top = 6.391F;
			this.label15.Width = 0.67F;
			// 
			// label16
			// 
			this.label16.Height = 0.153F;
			this.label16.HyperLink = null;
			this.label16.Left = 2.649F;
			this.label16.Name = "label16";
			this.label16.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label16.Text = "旧生命保険料の金額";
			this.label16.Top = 6.551F;
			this.label16.Width = 0.67F;
			// 
			// line8
			// 
			this.line8.Height = 0.4679999F;
			this.line8.Left = 2.628F;
			this.line8.LineWeight = 1F;
			this.line8.Name = "line8";
			this.line8.Top = 6.232F;
			this.line8.Width = 0F;
			this.line8.X1 = 2.628F;
			this.line8.X2 = 2.628F;
			this.line8.Y1 = 6.232F;
			this.line8.Y2 = 6.7F;
			// 
			// HR_PY_03_R99
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.1F;
			this.PageSettings.Margins.Left = 0.2F;
			this.PageSettings.Margins.Right = 0.2F;
			this.PageSettings.Margins.Top = 0.2F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.267716F;
			this.PrintWidth = 11.23958F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1138)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCode2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKana2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1146)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.class2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1149)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1152)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1156)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1159)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposexet2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1160)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1161)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1162)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1163)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1164)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1165)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1166)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1167)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1168)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1169)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1170)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1171)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1172)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1173)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1174)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1175)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNum1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1176)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1177)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1178)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1179)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1181)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1182)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1183)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1184)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1185)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1186)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1188)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1189)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1190)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumIncmAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1191)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1192)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1193)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1213)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1214)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1215)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1216)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1217)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1218)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1219)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1220)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latter2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1221)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1222)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1223)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1224)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1225)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1226)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1228)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1229)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1230)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1231)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1232)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1233)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1234)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1235)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1236)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1237)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1238)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1239)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1261)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halrEmReDateYear2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDay2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1262)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1263)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1264)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1265)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1266)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfErat2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1273)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1274)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1275)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1421)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1422)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1423)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1424)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1425)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1426)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1203)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1427)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1428)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1429)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCode3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKana3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1430)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1431)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1432)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1433)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1434)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1435)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1436)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.class3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1438)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1439)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1440)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1441)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1442)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1443)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1444)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1445)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1446)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1447)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1448)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1449)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposexet3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1450)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1451)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1452)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1453)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1454)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1455)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1456)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1457)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1458)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1459)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1460)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1461)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1462)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1463)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1464)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1465)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNum1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1466)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1467)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1468)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1469)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1470)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNum3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1471)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1472)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1473)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1474)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1475)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1476)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1478)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1479)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1480)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumIncmAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1481)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1482)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1483)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1502)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1503)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1504)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1505)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1506)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1507)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1508)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TempName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1509)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latter3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1510)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1511)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1512)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1513)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1514)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1515)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1517)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1518)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1519)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1520)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1521)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1522)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1523)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1524)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1525)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1526)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1527)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1528)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1550)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halrEmReDateYear3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDay3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1551)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1552)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1553)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1554)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1555)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfErat3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1562)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1563)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1564)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1567)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1568)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1569)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1570)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1571)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1572)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1573)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1579)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1580)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1581)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1582)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1583)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1589)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1590)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1591)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1592)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1593)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1594)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1597)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1598)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1599)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
