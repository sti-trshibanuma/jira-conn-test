// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R64.cs
// 機能名      : HR_PY_03_R64 退職者用源泉徴収票(A4)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 2.3.0 2016/06/30
// 管理番号K26330 2016/07/29 マイナンバー帳票対応
// 3.0.0 2018/04/30
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
	public class HR_PY_03_R64 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R64()
		{


			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
		private Line line1;
		private Line line2;
		private Line line3;
		private Label label1;
		private TextBox YoungDpndNumText;
		private Label label2;
		private Label label3;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label16;
		private Label label17;
		private Label label19;
		private Label label21;
		private Label label22;
		private Label label23;
		private Label label25;
		private Label label31;
		private Label label32;
		private Label label33;
		private Line line4;
		private Line line5;
		private Line line6;
		private Line line7;
		private Line line8;
		private Line line9;
		private Line line10;
		private Line line11;
		private Line line12;
		private Line line13;
		private Line line14;
		private Line line15;
		private Label label39;
		private Label label40;
		private Label label15;
		private TextBox YoungDpndNum1Text;
		private Label label14;
		private SubReport subReport1;
		private Label Label1078;
		private Label Label1079;
		private Label label4;
		private Line line16;
		private Label label5;
		private TextBox newLifeInsPensAmtText;
		private Label label13;
		private TextBox newLifeInsCareAmtText;
		private Label label18;
		private Line line17;
		private Label label20;
		private Label label24;
		private TextBox newLifeInsGeneralAmtText;
		private TextBox lifeInsGeneralAmtText;
		private Line line18;
		private Label label26;
		private Label label27;
		private Line line19;
		private TextBox summary1Digit0Text;
		private Label label6;
		private TextBox newLifeInsPensAmt1Text;
		private Label label7;
		private Label label28;
		private TextBox newLifeInsCareAmt1Text;
		private Label label29;
		private Line line20;
		private Line line21;
		private Line line22;
		private Line line23;
		private Label label30;
		private TextBox newLifeInsGeneralAmt1Text;
		private Label label34;
		private Label label35;
		private TextBox lifeInsGeneralAmt1Text;
		private Label label36;
		private TextBox summary1Digit1Text;
		protected CommonData cd;


		#endregion
		#region Properties
		public string ReportID
		{
			get { return reportID; }
			set { reportID = value; }
		}

		public string CompanyName
		{
			get { return companyName; }
			set { companyName = value; }
		}

		public CommonData commonData
		{
			get { return cd; }
			set { cd = value; }
		}

		#endregion

		private void HR_PY_03_R64_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;

		}

		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
		}



		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{

		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			JapaneseCalendar ca = new JapaneseCalendar();
			string[] gg = { "明治", "大正", "昭和", "平成" };
			string YlyEdCalYear = YlyEdCalYear1Text.Text + "/12" + "/31";

			if (YlyEdCalYear1Text.Text.Length != 0)
			{
				DateTime dt = DateTime.Parse(YlyEdCalYear);
				if (ca.GetYear(dt) < 10)
				{
					YlyEdCalYear2Text.Text = string.Format("{0} {1}年",
						gg[ca.GetEra(dt) - 1],
						ca.GetYear(dt));
				}
				else
				{
					YlyEdCalYear2Text.Text = string.Format("{0}{1}年",
						gg[ca.GetEra(dt) - 1],
						ca.GetYear(dt));
				}
			}

			if (YlyEdCalYear3Text.Text.Length != 0)
			{
				DateTime dt = DateTime.Parse(YlyEdCalYear);
				if (ca.GetYear(dt) < 10)
				{
					YlyEdCalYear4Text.Text = string.Format("{0} {1}年",
						gg[ca.GetEra(dt) - 1],
						ca.GetYear(dt));
				}
				else
				{
					YlyEdCalYear4Text.Text = string.Format("{0}{1}年",
						gg[ca.GetEra(dt) - 1],
						ca.GetYear(dt));
				}
			}
			if ((this.YlyEdCalYear1Text.Text != null) && (this.YlyEdCalYear1Text.Text != ""))
			{
				if (Convert.ToDecimal(this.YlyEdCalYear1Text.Text) >= 2007)
				{
					this.Label1093.Text = "地震保険料";
					this.Label244.Text = "地震保険料";
					this.Label1046.Text = "旧長期損害保険料の金額";
					this.Label179.Text = "旧長期損害保険料の金額";
				}
				else
				{
					this.Label1093.Text = "損害保険料";
					this.Label244.Text = "損害保険料";
					this.Label1046.Text = "長期損害保険料の金額";
					this.Label179.Text = "長期損害保険料の金額";
				}
			}
			System.Data.DataRow[] dtR64 = ((System.Data.DataView)DataSource).Table.Select("[EMP_CODE] = '" + empCodeText.Text.Trim() + "'", "[EMP_CODE]");

			rpt.HR_PY_03_R98 rptR98 = new HR_PY_03_R98();
			//データソースを渡す
			rptR98.DataSource = dtR64;
			this.subReport1.Report = rptR98;
			this.subReport1.Visible = true;
		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
		}

		private void GroupFooter2_AfterPrint(object sender, System.EventArgs eArgs)
		{
			// GroupFooderでブレイク後、最初のデータを出力する。
		}

		private void PageFooter_BeforePrint(object sender, System.EventArgs eArgs)
		{

		}

		private void PageFooter_AfterPrint(object sender, System.EventArgs eArgs)
		{
			// 改ページ後、最初のデータを出力する。
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}

		private void GroupFooter2_BeforePrint(object sender, System.EventArgs eArgs)
		{
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label124 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label125 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label126 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyEdAddress1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label127 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label128 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label130 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label132 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label133 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label134 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox class1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label135 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label136 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox incmDedAmtSum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label138 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyCollectTax1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label142 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label144 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label146 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposOldAgeType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExeist1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN1_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExeist2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposExtDedAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label152 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum1_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum2_2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label156 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtAgePreNum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox tagePreNum1Tex = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label159 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label160 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label161 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label162 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label163 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtHandiNum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiNum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label164 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label165 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label166 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label167 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label168 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox handiNum1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label169 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label170 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox smlScaleCompCpratAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label172 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label173 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsDedAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label174 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label175 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox housingObtDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary0Digit1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label177 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label178 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label179 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposSumINcmAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label180 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label181 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsPensAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label182 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsLongProdAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label213 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label215 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label216 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label217 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label218 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label219 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label223 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label226 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox minrType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox latter1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox handiType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widowType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extWidowType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widomType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox wrkStdType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label227 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label228 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label229 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAddress1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label230 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntPhone1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label231 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label232 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label234 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label236 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label237 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label238 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label239 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label240 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label241 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label242 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label243 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label244 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label245 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsDedAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label246 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox deathRetireType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox disasterType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox foreignType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmployType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label270 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfRetireType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateYear1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateMonth1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label271 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label272 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label273 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label274 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label275 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraM1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraT1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraS1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraH1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayYear1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayMonth1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayDay1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox socInsDedAmt1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label703 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label704 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label705 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line298 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line300 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line301 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line302 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line303 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line304 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line305 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line306 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label991 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label992 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label993 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label994 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyEdAddress1_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label995 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empCodeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox postNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameKanaText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label996 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label997 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label998 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label999 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1000 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1001 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1002 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox classText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1003 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1004 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox slryInsmDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1005 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox incmDedAmtSumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1006 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1007 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyCollectTaxText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1008 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1009 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1010 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1011 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1012 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1013 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1014 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1015 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposOldAgeTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExistText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposNText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExist2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposN2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1016 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1017 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposExtDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1018 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1019 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1020 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1021 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1022 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1023 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum1_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1024 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1025 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtAgePreNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1026 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1027 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1028 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1029 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1030 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1031 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtExtHandiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHndiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1032 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1033 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1034 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1035 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1036 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1037 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1038 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox smlScaleCompCpratAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1039 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1040 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1041 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1042 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox454 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1044 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1045 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1046 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sponSumIncmAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1047 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1048 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LifeInsPensAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1049 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsLongProdAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1051 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1052 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1053 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1054 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1055 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1059 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1062 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1063 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1065 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1067 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1068 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1069 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1070 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1071 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1072 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1073 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1074 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1075 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1076 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox minrTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox latterText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox handiTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widowTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extWidowTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widomTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox wrkStdTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1077 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAddressText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1080 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntPhoneText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1081 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1082 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1084 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1085 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1086 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1087 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1088 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1089 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1090 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1091 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1092 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1093 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1094 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1095 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1105 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox deathRetireTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox disasterTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1113 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox foreignTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1116 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmployTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1117 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfRetireTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateYearText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReFateMonthText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateDayText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1118 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1119 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1120 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1121 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraMText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraTText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraSText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthNameOfEraHText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayYearText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayMonthText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayDayText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox socInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1130 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line307 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line308 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line309 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line310 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line311 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line312 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line313 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1134 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line314 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line315 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line316 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line317 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line318 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line319 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line320 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line321 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line322 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line323 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox YlyEdCalYear3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line324 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line325 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line326 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line327 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line328 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line329 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line330 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line331 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line332 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line333 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line334 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line335 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line336 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line337 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line338 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line339 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line340 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line341 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line342 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line343 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line344 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line345 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line346 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line347 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line348 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line349 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line350 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line351 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line352 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line353 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line354 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line367 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line370 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line371 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line372 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line373 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line374 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line375 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line376 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line377 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line378 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line379 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line380 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line381 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line382 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line383 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line384 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line385 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line386 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line387 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line388 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line389 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line390 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line391 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line392 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line393 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line394 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line395 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line396 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line397 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line398 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line399 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line400 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line401 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line402 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line403 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line404 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line405 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line406 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line408 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line409 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line410 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line411 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line412 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line413 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line414 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line415 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line416 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line417 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line418 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line419 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line420 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line421 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line422 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line423 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line424 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line425 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line426 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line427 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line428 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line429 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line431 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line432 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line433 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line434 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line436 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line438 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line439 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line440 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line441 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line442 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line443 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line444 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line445 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line446 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line447 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line448 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line449 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line450 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line451 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line452 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line455 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line456 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line615 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line617 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line618 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line619 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line620 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line751 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1595 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1596 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line752 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line753 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line758 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line759 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary2Digit0Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary2Digit1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary0Digit0Text = null;

		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R64));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.label17 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1063 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label14 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label40 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label25 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label33 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label39 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label23 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label15 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YoungDpndNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1055 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label31 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label12 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label11 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YlyEdCalYear2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label124 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label125 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label126 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label127 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label128 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label132 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label133 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label134 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.class1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label135 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label136 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmDedAmtSum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label138 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyCollectTax1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label146 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposOldAgeType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExeist1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExeist2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label149 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposExtDedAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label152 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label153 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.specDpndNum1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label156 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label157 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtAgePreNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label158 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.tagePreNum1Tex = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label159 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label160 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label161 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label162 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label163 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtHandiNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label164 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label165 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label166 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label167 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label168 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.handiNum1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label169 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label170 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.smlScaleCompCpratAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label172 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label173 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsDedAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label174 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label175 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.housingObtDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary0Digit1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label177 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label178 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label179 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposSumINcmAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label180 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label181 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsPensAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label182 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsLongProdAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label213 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label215 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label216 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label217 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label218 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label219 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label223 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox38 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label226 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.minrType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latter1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.handiType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label227 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label228 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label229 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntAddress1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label230 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntPhone1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label231 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label232 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label234 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label236 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label237 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label238 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label239 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label240 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label241 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label242 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label243 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label244 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label245 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsDedAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label246 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.deathRetireType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.foreignType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmployType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label270 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfRetireType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateYear1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateMonth1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label271 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label272 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label273 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label274 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label275 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.birthNameOfEraM1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraT1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraS1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraH1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayYear1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonth1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDay1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label703 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label704 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label705 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line298 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YlyEdCalYear1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line300 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line301 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line302 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line303 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line304 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line306 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label991 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YlyEdCalYear4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label992 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label993 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label994 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label995 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empCodeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.postNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameKanaText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label996 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label997 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label998 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label999 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1000 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1001 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1002 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.classText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1003 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1004 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.slryInsmDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1005 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmDedAmtSumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1006 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1007 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyCollectTaxText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1008 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1009 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1010 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1011 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1012 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1013 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1014 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1015 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposOldAgeTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExistText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposNText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExist2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposN2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1016 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1017 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposExtDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1018 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1019 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1020 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1021 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1022 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1023 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.specDpndNum1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1024 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1025 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtAgePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1026 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.agePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1027 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1028 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1029 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1030 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1031 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtExtHandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHndiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1032 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1033 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1034 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1035 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1036 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1037 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1038 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.smlScaleCompCpratAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1039 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1040 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1041 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1042 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox454 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1044 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1045 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1046 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sponSumIncmAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1047 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1048 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1049 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsLongProdAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1051 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1052 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1053 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1054 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1059 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1062 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1065 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1067 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1068 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1069 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1070 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1071 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1072 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1073 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1074 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1075 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1076 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.minrTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latterText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.handiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1077 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1078 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1079 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntAddressText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1080 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntPhoneText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1081 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1082 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1084 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1085 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1086 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1087 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1088 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1089 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1090 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1091 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1092 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1093 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1094 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1095 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.deathRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.foreignTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1116 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfEmployTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1117 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReFateMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1118 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1119 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1120 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1121 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1122 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.birthNameOfEraMText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraTText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraSText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraHText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line307 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line308 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line309 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line310 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line311 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line312 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1134 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line314 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line315 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line316 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line317 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line318 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line319 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line320 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line321 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line322 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line323 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YlyEdCalYear3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line324 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line325 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line326 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line327 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line328 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line129 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line332 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line333 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line334 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line335 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line336 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line337 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line338 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line339 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line340 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line341 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line342 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line343 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line344 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line345 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line346 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line347 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line348 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line349 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line350 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line351 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line352 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line353 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line354 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line367 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line370 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line371 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line372 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line373 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line374 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line375 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line376 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line377 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line378 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line379 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line380 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line381 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line382 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line383 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line384 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line385 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line386 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line387 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line388 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line389 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line390 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line391 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line392 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line393 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line394 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line395 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line396 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line397 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line398 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line399 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line400 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line401 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line402 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line403 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line404 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line405 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line406 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line408 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line409 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line410 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line411 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line412 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line413 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line414 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line415 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line416 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line417 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line418 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line419 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line420 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line421 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line422 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line423 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line424 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line425 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line426 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line427 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line428 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line429 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line431 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line434 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line436 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line440 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line441 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line442 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line443 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line444 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line445 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line446 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line447 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line448 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line449 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line450 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line451 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line452 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line455 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line456 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line615 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line617 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line618 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line619 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line620 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line751 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1595 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1596 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line752 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line753 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line758 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line759 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.summary2Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary2Digit1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary0Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label16 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label19 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label21 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label22 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label32 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line11 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line12 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line13 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line14 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line15 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line331 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line433 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line432 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line438 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line439 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line329 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line305 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line9 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line10 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YoungDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line313 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line330 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.subReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line16 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label13 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsCareAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label18 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line17 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label20 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label24 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line18 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label26 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label27 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line19 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.summary1Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsPensAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label28 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsCareAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label29 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line20 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line21 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line22 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line23 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label30 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsGeneralAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label34 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsGeneralAmt1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.summary1Digit1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.label17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1063)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1055)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.class1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label138)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExeist1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExeist2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label156)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tagePreNum1Tex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label159)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtHandiNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label167)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label168)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handiNum1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label169)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label170)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label172)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label173)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label178)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label179)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumINcmAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label181)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label182)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label213)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label215)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label216)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label217)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label218)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label219)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label223)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label226)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latter1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handiType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label227)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label228)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label229)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label230)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label231)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label232)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label234)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label236)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label237)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label238)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label239)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label240)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label241)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label242)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label243)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label244)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label245)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label246)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label270)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYear1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label271)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label272)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label273)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label274)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label275)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraT1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label703)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label704)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label705)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label991)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label992)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label993)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label994)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label995)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label996)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label997)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label998)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label999)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1000)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1001)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1002)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1003)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1004)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1005)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1006)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1007)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1008)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1009)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1010)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1011)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1012)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1013)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1014)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1015)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposNText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1016)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1017)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1018)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1019)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1020)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1021)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1022)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1023)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1024)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1025)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1026)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1027)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1028)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1029)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1030)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1031)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1032)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1033)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1034)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1035)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1036)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1037)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1038)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1039)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1040)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1041)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1042)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1044)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1045)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1046)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1047)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1048)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1049)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1051)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1052)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1053)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1054)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1059)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1062)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1065)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1067)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1068)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1069)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1070)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1071)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1072)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1073)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1074)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1075)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1076)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1077)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1078)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1079)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1080)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1081)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1082)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1084)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1085)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1086)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1087)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1088)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1089)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1090)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1091)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1092)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1093)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1094)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1095)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1116)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1117)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1118)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1119)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1120)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1121)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraMText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraTText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraSText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraHText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1134)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1595)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1596)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label17,
            this.Label1063,
            this.label14,
            this.label2,
            this.label3,
            this.Label1105,
            this.label40,
            this.label25,
            this.label33,
            this.label39,
            this.label23,
            this.label15,
            this.YoungDpndNum1Text,
            this.Label1055,
            this.label31,
            this.label12,
            this.label11,
            this.label1,
            this.Label123,
            this.YlyEdCalYear2Text,
            this.Label124,
            this.Label125,
            this.Label126,
            this.ylyEdAddress1_2Text,
            this.Label127,
            this.TextBox3,
            this.TextBox4,
            this.TextBox5,
            this.Label128,
            this.Label129,
            this.Label130,
            this.Label131,
            this.Label132,
            this.Label133,
            this.Label134,
            this.class1Text,
            this.paymntAmt1Text,
            this.Label135,
            this.Label136,
            this.TextBox8,
            this.Label137,
            this.incmDedAmtSum1Text,
            this.Label138,
            this.Label139,
            this.ylyCollectTax1Text,
            this.Label140,
            this.Label141,
            this.Label142,
            this.Label143,
            this.Label144,
            this.Label145,
            this.Label146,
            this.Label147,
            this.sposOldAgeType1Text,
            this.dedSposExeist1Text,
            this.dedSposN1_1Text,
            this.dedSposExeist2_1Text,
            this.dedSposN2_1Text,
            this.Label148,
            this.Label149,
            this.sposExtDedAmt1Text,
            this.Label150,
            this.Label151,
            this.Label152,
            this.Label153,
            this.Label154,
            this.Label155,
            this.specDpndNum1_2Text,
            this.specDpndNum2_2Text,
            this.Label156,
            this.Label157,
            this.liveTgtAgePreNum1Text,
            this.Label158,
            this.tagePreNum1Tex,
            this.agePreNum2_1Text,
            this.Label159,
            this.Label160,
            this.othersDpndNum1Text,
            this.Label161,
            this.othersDpndNum2_1Text,
            this.Label162,
            this.Label163,
            this.liveTgtHandiNum1Text,
            this.extHandiNum1Text,
            this.Label164,
            this.Label165,
            this.Label166,
            this.Label167,
            this.Label168,
            this.handiNum1Text,
            this.Label169,
            this.Label170,
            this.smlScaleCompCpratAmt1Text,
            this.Label172,
            this.Label173,
            this.lifeInsDedAmt1Text,
            this.Label174,
            this.Label175,
            this.housingObtDedAmtText,
            this.summary0Digit1Text,
            this.Label177,
            this.Label178,
            this.Label179,
            this.sposSumINcmAmt1Text,
            this.Label180,
            this.Label181,
            this.lifeInsPensAmt1Text,
            this.Label182,
            this.nolfInsLongProdAmt1Text,
            this.Label213,
            this.Label215,
            this.Label216,
            this.Label217,
            this.Label218,
            this.Label219,
            this.Label223,
            this.TextBox38,
            this.Label226,
            this.minrType1Text,
            this.latter1Text,
            this.extHandiType1Text,
            this.handiType1Text,
            this.widowType1Text,
            this.extWidowType1Text,
            this.widomType1Text,
            this.wrkStdType1Text,
            this.Label227,
            this.Label228,
            this.Label229,
            this.paymntAddress1Text,
            this.paymntName1Text,
            this.Label230,
            this.paymntPhone1Text,
            this.Label231,
            this.Label232,
            this.Label234,
            this.Label236,
            this.Label237,
            this.Label238,
            this.Label239,
            this.Label240,
            this.Label241,
            this.Label242,
            this.Label243,
            this.Label244,
            this.Label245,
            this.nolfInsDedAmt1Text,
            this.Label246,
            this.deathRetireType1Text,
            this.disasterType1Text,
            this.foreignType1Text,
            this.halfEmployType1Text,
            this.Label270,
            this.halfRetireType1Text,
            this.halfEmReDateYear1Text,
            this.halfEmReDateMonth1Text,
            this.halfEmReDateDate1Text,
            this.Label271,
            this.Label272,
            this.Label273,
            this.Label274,
            this.Label275,
            this.birthNameOfEraM1Text,
            this.birthNameOfEraT1Text,
            this.birthNameOfEraS1Text,
            this.birthNameOfEraH1Text,
            this.birthDayYear1Text,
            this.birthDayMonth1Text,
            this.birthDayDay1Text,
            this.socInsDedAmt1Text,
            this.Label703,
            this.Label704,
            this.Label705,
            this.Line298,
            this.YlyEdCalYear1Text,
            this.Line300,
            this.Line301,
            this.Line302,
            this.Line303,
            this.Line304,
            this.Line306,
            this.Label991,
            this.YlyEdCalYear4Text,
            this.Label992,
            this.Label993,
            this.Label994,
            this.ylyEdAddress1_1Text,
            this.Label995,
            this.empCodeText,
            this.postNameText,
            this.empNameKanaText,
            this.Label996,
            this.Label997,
            this.Label998,
            this.Label999,
            this.Label1000,
            this.Label1001,
            this.Label1002,
            this.classText,
            this.paymntAmtText,
            this.Label1003,
            this.Label1004,
            this.slryInsmDedAmtText,
            this.Label1005,
            this.incmDedAmtSumText,
            this.Label1006,
            this.Label1007,
            this.ylyCollectTaxText,
            this.Label1008,
            this.Label1009,
            this.Label1010,
            this.Label1011,
            this.Label1012,
            this.Label1013,
            this.Label1014,
            this.Label1015,
            this.sposOldAgeTypeText,
            this.dedSposExistText,
            this.dedSposNText,
            this.dedSposExist2Text,
            this.dedSposN2Text,
            this.Label1016,
            this.Label1017,
            this.sposExtDedAmtText,
            this.Label1018,
            this.Label1019,
            this.Label1020,
            this.Label1021,
            this.Label1022,
            this.Label1023,
            this.specDpndNum1_1Text,
            this.specDpndNum2_1Text,
            this.Label1024,
            this.Label1025,
            this.liveTgtAgePreNumText,
            this.Label1026,
            this.agePreNumText,
            this.agePreNum2Text,
            this.Label1027,
            this.Label1028,
            this.othersDpndNumText,
            this.Label1029,
            this.othersDpndNum2Text,
            this.Label1030,
            this.Label1031,
            this.liveTgtExtHandiNumText,
            this.extHndiNumText,
            this.Label1032,
            this.Label1033,
            this.Label1034,
            this.Label1035,
            this.Label1036,
            this.HandiNumText,
            this.Label1037,
            this.Label1038,
            this.smlScaleCompCpratAmtText,
            this.Label1039,
            this.Label1040,
            this.lifeInsDedAmtText,
            this.Label1041,
            this.Label1042,
            this.TextBox454,
            this.Label1044,
            this.Label1045,
            this.Label1046,
            this.sponSumIncmAmtText,
            this.Label1047,
            this.Label1048,
            this.LifeInsPensAmtText,
            this.Label1049,
            this.nolfInsLongProdAmtText,
            this.Label1051,
            this.Label1052,
            this.Label1053,
            this.Label1054,
            this.Label1059,
            this.Label1062,
            this.Label1065,
            this.Label1067,
            this.Label1068,
            this.Label1069,
            this.Label1070,
            this.Label1071,
            this.Label1072,
            this.Label1073,
            this.Label1074,
            this.Label1075,
            this.empNameText,
            this.Label1076,
            this.minrTypeText,
            this.latterText,
            this.extHandiTypeText,
            this.handiTypeText,
            this.widowTypeText,
            this.extWidowTypeText,
            this.widomTypeText,
            this.wrkStdTypeText,
            this.Label1077,
            this.Label1078,
            this.Label1079,
            this.paymntAddressText,
            this.paymntNameText,
            this.Label1080,
            this.paymntPhoneText,
            this.Label1081,
            this.Label1082,
            this.Label1084,
            this.Label1085,
            this.Label1086,
            this.Label1087,
            this.Label1088,
            this.Label1089,
            this.Label1090,
            this.Label1091,
            this.Label1092,
            this.Label1093,
            this.Label1094,
            this.nolfInsDedAmtText,
            this.Label1095,
            this.deathRetireTypeText,
            this.disasterTypeText,
            this.Label1113,
            this.foreignTypeText,
            this.Label1116,
            this.halfEmployTypeText,
            this.Label1117,
            this.halfRetireTypeText,
            this.halfEmReDateYearText,
            this.halfEmReFateMonthText,
            this.halfEmReDateDayText,
            this.Label1118,
            this.Label1119,
            this.Label1120,
            this.Label1121,
            this.Label1122,
            this.birthNameOfEraMText,
            this.birthNameOfEraTText,
            this.birthNameOfEraSText,
            this.birthNameOfEraHText,
            this.birthDayYearText,
            this.birthDayMonthText,
            this.birthDayDayText,
            this.socInsDedAmtText,
            this.Label1123,
            this.Label1129,
            this.Label1130,
            this.Label1131,
            this.Line307,
            this.Line308,
            this.Line309,
            this.Line310,
            this.Line311,
            this.Line312,
            this.Label1134,
            this.Line314,
            this.Line315,
            this.Line316,
            this.Line317,
            this.Line318,
            this.Line319,
            this.Line320,
            this.Line321,
            this.Line322,
            this.Line323,
            this.YlyEdCalYear3Text,
            this.Line324,
            this.Line325,
            this.Line326,
            this.Line327,
            this.Line328,
            this.Line129,
            this.Line332,
            this.Line333,
            this.Line334,
            this.Line335,
            this.Line336,
            this.Line337,
            this.Line338,
            this.Line339,
            this.Line340,
            this.Line341,
            this.Line342,
            this.Line343,
            this.Line344,
            this.Line345,
            this.Line346,
            this.Line347,
            this.Line348,
            this.Line349,
            this.Line350,
            this.Line351,
            this.Line352,
            this.Line353,
            this.Line354,
            this.Line367,
            this.Line370,
            this.Line371,
            this.Line372,
            this.Line373,
            this.Line374,
            this.Line375,
            this.Line376,
            this.Line377,
            this.Line378,
            this.Line379,
            this.Line380,
            this.Line381,
            this.Line382,
            this.Line383,
            this.Line384,
            this.Line385,
            this.Line386,
            this.Line387,
            this.Line388,
            this.Line389,
            this.Line390,
            this.Line391,
            this.Line392,
            this.Line393,
            this.Line394,
            this.Line395,
            this.Line396,
            this.Line397,
            this.Line398,
            this.Line399,
            this.Line400,
            this.Line401,
            this.Line402,
            this.Line403,
            this.Line404,
            this.Line405,
            this.Line406,
            this.Line408,
            this.Line409,
            this.Line410,
            this.Line411,
            this.Line412,
            this.Line413,
            this.Line414,
            this.Line415,
            this.Line416,
            this.Line417,
            this.Line418,
            this.Line419,
            this.Line420,
            this.Line421,
            this.Line422,
            this.Line423,
            this.Line424,
            this.Line425,
            this.Line426,
            this.Line427,
            this.Line428,
            this.Line429,
            this.Line431,
            this.Line434,
            this.Line436,
            this.Line440,
            this.Line441,
            this.Line442,
            this.Line443,
            this.Line444,
            this.Line445,
            this.Line446,
            this.Line447,
            this.Line448,
            this.Line449,
            this.Line450,
            this.Line451,
            this.Line452,
            this.Line455,
            this.Line456,
            this.Line615,
            this.Line617,
            this.Line618,
            this.Line619,
            this.Line620,
            this.Line751,
            this.Label1595,
            this.Label1596,
            this.Line752,
            this.Line753,
            this.Line758,
            this.Line759,
            this.summary2Digit0Text,
            this.summary2Digit1Text,
            this.summary0Digit0Text,
            this.line1,
            this.line2,
            this.line3,
            this.label8,
            this.label9,
            this.label10,
            this.label16,
            this.label19,
            this.label21,
            this.label22,
            this.label32,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line11,
            this.line12,
            this.line13,
            this.line14,
            this.line15,
            this.Line331,
            this.Line433,
            this.Line432,
            this.Line438,
            this.Line439,
            this.Line329,
            this.Line305,
            this.line9,
            this.line10,
            this.YoungDpndNumText,
            this.Line313,
            this.Line330,
            this.subReport1,
            this.label4,
            this.line16,
            this.label5,
            this.newLifeInsPensAmtText,
            this.label13,
            this.newLifeInsCareAmtText,
            this.label18,
            this.line17,
            this.label20,
            this.label24,
            this.newLifeInsGeneralAmtText,
            this.lifeInsGeneralAmtText,
            this.line18,
            this.label26,
            this.label27,
            this.line19,
            this.summary1Digit0Text,
            this.label6,
            this.newLifeInsPensAmt1Text,
            this.label7,
            this.label28,
            this.newLifeInsCareAmt1Text,
            this.label29,
            this.line20,
            this.line21,
            this.line22,
            this.line23,
            this.label30,
            this.newLifeInsGeneralAmt1Text,
            this.label34,
            this.label35,
            this.lifeInsGeneralAmt1Text,
            this.label36,
            this.summary1Digit1Text});
			this.Detail.Height = 7.958333F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// label17
			// 
			this.label17.Height = 0.21F;
			this.label17.HyperLink = null;
			this.label17.Left = 1.927F;
			this.label17.Name = "label17";
			this.label17.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label17.Text = "一般";
			this.label17.Top = 6.816F;
			this.label17.Width = 0.125F;
			// 
			// Label1063
			// 
			this.Label1063.Height = 0.21F;
			this.Label1063.HyperLink = null;
			this.Label1063.Left = 1.927F;
			this.Label1063.Name = "Label1063";
			this.Label1063.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1063.Text = "一般";
			this.Label1063.Top = 2.712F;
			this.Label1063.Width = 0.125F;
			// 
			// label14
			// 
			this.label14.Height = 0.35F;
			this.label14.HyperLink = null;
			this.label14.Left = 0.906F;
			this.label14.Name = "label14";
			this.label14.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label14.Text = "死亡退職";
			this.label14.Top = 2.598F;
			this.label14.Width = 0.125F;
			// 
			// label2
			// 
			this.label2.Height = 0.35F;
			this.label2.HyperLink = null;
			this.label2.Left = 0.302F;
			this.label2.Name = "label2";
			this.label2.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label2.Text = "16歳未満";
			this.label2.Top = 2.598F;
			this.label2.Width = 0.105F;
			// 
			// label3
			// 
			this.label3.Height = 0.35F;
			this.label3.HyperLink = null;
			this.label3.Left = 0.198F;
			this.label3.Name = "label3";
			this.label3.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label3.Text = "扶養親族";
			this.label3.Top = 2.598F;
			this.label3.Width = 0.105F;
			// 
			// Label1105
			// 
			this.Label1105.Height = 0.35F;
			this.Label1105.HyperLink = null;
			this.Label1105.Left = 2.531F;
			this.Label1105.Name = "Label1105";
			this.Label1105.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1105.Text = "勤労学生";
			this.Label1105.Top = 2.598F;
			this.Label1105.Width = 0.125F;
			// 
			// label40
			// 
			this.label40.Height = 0.35F;
			this.label40.HyperLink = null;
			this.label40.Left = 0.188F;
			this.label40.Name = "label40";
			this.label40.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label40.Text = "扶養親族";
			this.label40.Top = 6.702F;
			this.label40.Width = 0.105F;
			// 
			// label25
			// 
			this.label25.Height = 0.35F;
			this.label25.HyperLink = null;
			this.label25.Left = 0.906F;
			this.label25.Name = "label25";
			this.label25.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label25.Text = "死亡退職";
			this.label25.Top = 6.702F;
			this.label25.Width = 0.125F;
			// 
			// label33
			// 
			this.label33.Height = 0.35F;
			this.label33.HyperLink = null;
			this.label33.Left = 0.458F;
			this.label33.Name = "label33";
			this.label33.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label33.Text = "未成年者";
			this.label33.Top = 6.702F;
			this.label33.Width = 0.125F;
			// 
			// label39
			// 
			this.label39.Height = 0.35F;
			this.label39.HyperLink = null;
			this.label39.Left = 0.292F;
			this.label39.Name = "label39";
			this.label39.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label39.Text = "16歳未満";
			this.label39.Top = 6.702F;
			this.label39.Width = 0.105F;
			// 
			// label23
			// 
			this.label23.Height = 0.35F;
			this.label23.HyperLink = null;
			this.label23.Left = 2.531F;
			this.label23.Name = "label23";
			this.label23.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label23.Text = "勤労学生";
			this.label23.Top = 6.702F;
			this.label23.Width = 0.125F;
			// 
			// label15
			// 
			this.label15.Height = 0.125F;
			this.label15.HyperLink = null;
			this.label15.Left = 0.292F;
			this.label15.Name = "label15";
			this.label15.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label15.Text = "人";
			this.label15.Top = 7.035F;
			this.label15.Width = 0.125F;
			// 
			// YoungDpndNum1Text
			// 
			this.YoungDpndNum1Text.CanGrow = false;
			this.YoungDpndNum1Text.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNum1Text.Height = 0.1250003F;
			this.YoungDpndNum1Text.Left = 0.188F;
			this.YoungDpndNum1Text.Name = "YoungDpndNum1Text";
			this.YoungDpndNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNum1Text.Text = "Z6";
			this.YoungDpndNum1Text.Top = 7.087F;
			this.YoungDpndNum1Text.Width = 0.125F;
			// 
			// Label1055
			// 
			this.Label1055.Height = 0.2499999F;
			this.Label1055.HyperLink = null;
			this.Label1055.Left = 1.719F;
			this.Label1055.Name = "Label1055";
			this.Label1055.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1055.Text = "その他";
			this.Label1055.Top = 2.691F;
			this.Label1055.Width = 0.125F;
			// 
			// label31
			// 
			this.label31.Height = 0.29F;
			this.label31.HyperLink = null;
			this.label31.Left = 1.12F;
			this.label31.Name = "label31";
			this.label31.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label31.Text = "災害者";
			this.label31.Top = 6.732F;
			this.label31.Width = 0.135F;
			// 
			// label12
			// 
			this.label12.Height = 0.2500002F;
			this.label12.HyperLink = null;
			this.label12.Left = 1.729F;
			this.label12.Name = "label12";
			this.label12.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label12.Text = "その他";
			this.label12.Top = 6.795F;
			this.label12.Width = 0.125F;
			// 
			// label11
			// 
			this.label11.Height = 0.21F;
			this.label11.HyperLink = null;
			this.label11.Left = 1.531F;
			this.label11.Name = "label11";
			this.label11.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label11.Text = "特別";
			this.label11.Top = 6.816F;
			this.label11.Width = 0.125F;
			// 
			// label1
			// 
			this.label1.Height = 0.125F;
			this.label1.HyperLink = null;
			this.label1.Left = 0.292F;
			this.label1.Name = "label1";
			this.label1.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label1.Text = "人";
			this.label1.Top = 2.931F;
			this.label1.Width = 0.125F;
			// 
			// Label123
			// 
			this.Label123.Height = 0.125F;
			this.Label123.HyperLink = null;
			this.Label123.Left = 2.125582F;
			this.Label123.Name = "Label123";
			this.Label123.Style = "font-size: 7pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label123.Text = "分";
			this.Label123.Top = 4.145454F;
			this.Label123.Width = 0.1245001F;
			// 
			// YlyEdCalYear2Text
			// 
			this.YlyEdCalYear2Text.CanGrow = false;
			this.YlyEdCalYear2Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear2Text.Height = 0.125F;
			this.YlyEdCalYear2Text.Left = 1.730082F;
			this.YlyEdCalYear2Text.Name = "YlyEdCalYear2Text";
			this.YlyEdCalYear2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.YlyEdCalYear2Text.Text = "○○66年";
			this.YlyEdCalYear2Text.Top = 4.155453F;
			this.YlyEdCalYear2Text.Width = 0.49F;
			// 
			// Label124
			// 
			this.Label124.Height = 0.1875F;
			this.Label124.HyperLink = null;
			this.Label124.Left = 2.250082F;
			this.Label124.Name = "Label124";
			this.Label124.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-" +
    "char-set: 1";
			this.Label124.Text = "給与所得の源泉徴収票";
			this.Label124.Top = 4.114453F;
			this.Label124.Width = 1.3125F;
			// 
			// Label125
			// 
			this.Label125.Height = 0.208F;
			this.Label125.HyperLink = null;
			this.Label125.Left = 0.1880815F;
			this.Label125.Name = "Label125";
			this.Label125.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label125.Text = "支払";
			this.Label125.Top = 4.301953F;
			this.Label125.Width = 0.292F;
			// 
			// Label126
			// 
			this.Label126.Height = 0.625F;
			this.Label126.HyperLink = null;
			this.Label126.Left = 0.4800815F;
			this.Label126.Name = "Label126";
			this.Label126.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label126.Text = "住所又は居所";
			this.Label126.Top = 4.301953F;
			this.Label126.Width = 0.1875F;
			// 
			// ylyEdAddress1_2Text
			// 
			this.ylyEdAddress1_2Text.CanGrow = false;
			this.ylyEdAddress1_2Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_2Text.Height = 0.625F;
			this.ylyEdAddress1_2Text.Left = 0.6680815F;
			this.ylyEdAddress1_2Text.Name = "ylyEdAddress1_2Text";
			this.ylyEdAddress1_2Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_2Text.Top = 4.301953F;
			this.ylyEdAddress1_2Text.Width = 2.349F;
			// 
			// Label127
			// 
			this.Label127.Height = 0.313F;
			this.Label127.HyperLink = null;
			this.Label127.Left = 3.017081F;
			this.Label127.Name = "Label127";
			this.Label127.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label127.Text = "氏";
			this.Label127.Top = 4.301953F;
			this.Label127.Width = 0.19F;
			// 
			// TextBox3
			// 
			this.TextBox3.CanGrow = false;
			this.TextBox3.DataField = "EMP_CODE";
			this.TextBox3.Height = 0.156F;
			this.TextBox3.Left = 3.756082F;
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.TextBox3.Text = "0000000000";
			this.TextBox3.Top = 4.301953F;
			this.TextBox3.Width = 1.619F;
			// 
			// TextBox4
			// 
			this.TextBox4.CanGrow = false;
			this.TextBox4.DataField = "POST_NAME";
			this.TextBox4.Height = 0.156F;
			this.TextBox4.Left = 3.756082F;
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.TextBox4.Text = "ああああああああああ";
			this.TextBox4.Top = 4.614953F;
			this.TextBox4.Width = 1.619F;
			// 
			// TextBox5
			// 
			this.TextBox5.CanGrow = false;
			this.TextBox5.DataField = "EMP_REGIST_NAME_KANA";
			this.TextBox5.Height = 0.156F;
			this.TextBox5.Left = 3.756082F;
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.TextBox5.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.TextBox5.Top = 4.457954F;
			this.TextBox5.Width = 1.619F;
			// 
			// Label128
			// 
			this.Label128.Height = 0.156F;
			this.Label128.HyperLink = null;
			this.Label128.Left = 3.207082F;
			this.Label128.Name = "Label128";
			this.Label128.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label128.Text = "(受給者番号）";
			this.Label128.Top = 4.301953F;
			this.Label128.Width = 0.6055F;
			// 
			// Label129
			// 
			this.Label129.Height = 0.156F;
			this.Label129.HyperLink = null;
			this.Label129.Left = 3.207082F;
			this.Label129.Name = "Label129";
			this.Label129.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label129.Text = "(フリガナ）";
			this.Label129.Top = 4.457954F;
			this.Label129.Width = 0.543F;
			// 
			// Label130
			// 
			this.Label130.Height = 0.156F;
			this.Label130.HyperLink = null;
			this.Label130.Left = 3.207082F;
			this.Label130.Name = "Label130";
			this.Label130.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label130.Text = "(役職名）";
			this.Label130.Top = 4.613953F;
			this.Label130.Width = 0.543F;
			// 
			// Label131
			// 
			this.Label131.Height = 0.173F;
			this.Label131.HyperLink = null;
			this.Label131.Left = 0.1875815F;
			this.Label131.Name = "Label131";
			this.Label131.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label131.Text = "種　　別";
			this.Label131.Top = 4.926953F;
			this.Label131.Width = 0.938F;
			// 
			// Label132
			// 
			this.Label132.Height = 0.173F;
			this.Label132.HyperLink = null;
			this.Label132.Left = 1.126082F;
			this.Label132.Name = "Label132";
			this.Label132.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label132.Text = "支　払　金　額";
			this.Label132.Top = 4.926953F;
			this.Label132.Width = 1.078F;
			// 
			// Label133
			// 
			this.Label133.Height = 0.173F;
			this.Label133.HyperLink = null;
			this.Label133.Left = 2.204082F;
			this.Label133.Name = "Label133";
			this.Label133.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label133.Text = " 給与所得控除後の金額";
			this.Label133.Top = 4.926953F;
			this.Label133.Width = 1.063F;
			// 
			// Label134
			// 
			this.Label134.Height = 0.173F;
			this.Label134.HyperLink = null;
			this.Label134.Left = 3.267081F;
			this.Label134.Name = "Label134";
			this.Label134.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label134.Text = "所得控除の額の合計額";
			this.Label134.Top = 4.926953F;
			this.Label134.Width = 1.063F;
			// 
			// class1Text
			// 
			this.class1Text.CanGrow = false;
			this.class1Text.DataField = "CLASS";
			this.class1Text.Height = 0.328F;
			this.class1Text.Left = 0.1880815F;
			this.class1Text.Name = "class1Text";
			this.class1Text.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.class1Text.Text = "ああああああ";
			this.class1Text.Top = 5.099952F;
			this.class1Text.Width = 0.937F;
			// 
			// paymntAmt1Text
			// 
			this.paymntAmt1Text.CanGrow = false;
			this.paymntAmt1Text.DataField = "PAYMNT_AMT";
			this.paymntAmt1Text.Height = 0.328F;
			this.paymntAmt1Text.Left = 1.225082F;
			this.paymntAmt1Text.Name = "paymntAmt1Text";
			this.paymntAmt1Text.OutputFormat = "#,##0";
			this.paymntAmt1Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.paymntAmt1Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.paymntAmt1Text.Top = 5.099952F;
			this.paymntAmt1Text.Width = 0.838F;
			// 
			// Label135
			// 
			this.Label135.Height = 0.125F;
			this.Label135.HyperLink = null;
			this.Label135.Left = 1.125082F;
			this.Label135.Name = "Label135";
			this.Label135.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label135.Text = "内";
			this.Label135.Top = 5.099952F;
			this.Label135.Width = 0.1F;
			// 
			// Label136
			// 
			this.Label136.Height = 0.125F;
			this.Label136.HyperLink = null;
			this.Label136.Left = 2.063082F;
			this.Label136.Name = "Label136";
			this.Label136.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label136.Text = "円";
			this.Label136.Top = 5.099952F;
			this.Label136.Width = 0.141F;
			// 
			// TextBox8
			// 
			this.TextBox8.CanGrow = false;
			this.TextBox8.DataField = "SLRY_INSM_DED_AMT";
			this.TextBox8.Height = 0.328F;
			this.TextBox8.Left = 2.204082F;
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.OutputFormat = "#,##0";
			this.TextBox8.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TextBox8.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.TextBox8.Top = 5.099952F;
			this.TextBox8.Width = 0.938F;
			// 
			// Label137
			// 
			this.Label137.Height = 0.125F;
			this.Label137.HyperLink = null;
			this.Label137.Left = 3.142081F;
			this.Label137.Name = "Label137";
			this.Label137.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label137.Text = "円";
			this.Label137.Top = 5.099952F;
			this.Label137.Width = 0.1245001F;
			// 
			// incmDedAmtSum1Text
			// 
			this.incmDedAmtSum1Text.CanGrow = false;
			this.incmDedAmtSum1Text.DataField = "INCM_DED_AMT_SUM";
			this.incmDedAmtSum1Text.Height = 0.328F;
			this.incmDedAmtSum1Text.Left = 3.267081F;
			this.incmDedAmtSum1Text.Name = "incmDedAmtSum1Text";
			this.incmDedAmtSum1Text.OutputFormat = "#,##0";
			this.incmDedAmtSum1Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmDedAmtSum1Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.incmDedAmtSum1Text.Top = 5.099952F;
			this.incmDedAmtSum1Text.Width = 0.938F;
			// 
			// Label138
			// 
			this.Label138.Height = 0.125F;
			this.Label138.HyperLink = null;
			this.Label138.Left = 4.205081F;
			this.Label138.Name = "Label138";
			this.Label138.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label138.Text = "円";
			this.Label138.Top = 5.099952F;
			this.Label138.Width = 0.125F;
			// 
			// Label139
			// 
			this.Label139.Height = 0.125F;
			this.Label139.HyperLink = null;
			this.Label139.Left = 4.330081F;
			this.Label139.Name = "Label139";
			this.Label139.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label139.Text = "内";
			this.Label139.Top = 5.099952F;
			this.Label139.Width = 0.125F;
			// 
			// ylyCollectTax1Text
			// 
			this.ylyCollectTax1Text.CanGrow = false;
			this.ylyCollectTax1Text.DataField = "YLY_COLLECT_TAX";
			this.ylyCollectTax1Text.Height = 0.328F;
			this.ylyCollectTax1Text.Left = 4.437582F;
			this.ylyCollectTax1Text.Name = "ylyCollectTax1Text";
			this.ylyCollectTax1Text.OutputFormat = "#,##0";
			this.ylyCollectTax1Text.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ylyCollectTax1Text.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.ylyCollectTax1Text.Top = 5.099952F;
			this.ylyCollectTax1Text.Width = 0.816F;
			// 
			// Label140
			// 
			this.Label140.Height = 0.125F;
			this.Label140.HyperLink = null;
			this.Label140.Left = 5.236082F;
			this.Label140.Name = "Label140";
			this.Label140.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label140.Text = "円";
			this.Label140.Top = 5.099952F;
			this.Label140.Width = 0.134F;
			// 
			// Label141
			// 
			this.Label141.Height = 0.173F;
			this.Label141.HyperLink = null;
			this.Label141.Left = 4.330081F;
			this.Label141.Name = "Label141";
			this.Label141.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label141.Text = "源　泉　徴　収　税　額";
			this.Label141.Top = 4.926953F;
			this.Label141.Width = 1.04F;
			// 
			// Label142
			// 
			this.Label142.Height = 0.157F;
			this.Label142.HyperLink = null;
			this.Label142.Left = 0.1880815F;
			this.Label142.Name = "Label142";
			this.Label142.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label142.Text = "控除対象配偶";
			this.Label142.Top = 5.427953F;
			this.Label142.Width = 0.5F;
			// 
			// Label143
			// 
			this.Label143.Height = 0.345F;
			this.Label143.HyperLink = null;
			this.Label143.Left = 0.5880815F;
			this.Label143.Name = "Label143";
			this.Label143.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label143.Text = "老人";
			this.Label143.Top = 5.569453F;
			this.Label143.Width = 0.1F;
			// 
			// Label144
			// 
			this.Label144.Height = 0.1875F;
			this.Label144.HyperLink = null;
			this.Label144.Left = 0.1880815F;
			this.Label144.Name = "Label144";
			this.Label144.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label144.Text = "有";
			this.Label144.Top = 5.741953F;
			this.Label144.Width = 0.1F;
			// 
			// Label145
			// 
			this.Label145.Height = 0.188F;
			this.Label145.HyperLink = null;
			this.Label145.Left = 0.2880815F;
			this.Label145.Name = "Label145";
			this.Label145.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label145.Text = "無";
			this.Label145.Top = 5.741953F;
			this.Label145.Width = 0.1F;
			// 
			// Label146
			// 
			this.Label146.Height = 0.188F;
			this.Label146.HyperLink = null;
			this.Label146.Left = 0.3880816F;
			this.Label146.Name = "Label146";
			this.Label146.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label146.Text = "従有";
			this.Label146.Top = 5.73987F;
			this.Label146.Width = 0.1F;
			// 
			// Label147
			// 
			this.Label147.Height = 0.188F;
			this.Label147.HyperLink = null;
			this.Label147.Left = 0.4880815F;
			this.Label147.Name = "Label147";
			this.Label147.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label147.Text = "従無";
			this.Label147.Top = 5.73987F;
			this.Label147.Width = 0.1F;
			// 
			// sposOldAgeType1Text
			// 
			this.sposOldAgeType1Text.CanGrow = false;
			this.sposOldAgeType1Text.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeType1Text.Height = 0.155F;
			this.sposOldAgeType1Text.Left = 0.5880815F;
			this.sposOldAgeType1Text.Name = "sposOldAgeType1Text";
			this.sposOldAgeType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeType1Text.Text = "0";
			this.sposOldAgeType1Text.Top = 5.929954F;
			this.sposOldAgeType1Text.Width = 0.1F;
			// 
			// dedSposExeist1Text
			// 
			this.dedSposExeist1Text.CanGrow = false;
			this.dedSposExeist1Text.DataField = "DED_SPOS_EXIST";
			this.dedSposExeist1Text.Height = 0.155F;
			this.dedSposExeist1Text.Left = 0.1880815F;
			this.dedSposExeist1Text.Name = "dedSposExeist1Text";
			this.dedSposExeist1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExeist1Text.Text = "0";
			this.dedSposExeist1Text.Top = 5.929954F;
			this.dedSposExeist1Text.Width = 0.1F;
			// 
			// dedSposN1_1Text
			// 
			this.dedSposN1_1Text.CanGrow = false;
			this.dedSposN1_1Text.DataField = "DED_SPOS_N";
			this.dedSposN1_1Text.Height = 0.155F;
			this.dedSposN1_1Text.Left = 0.2880815F;
			this.dedSposN1_1Text.Name = "dedSposN1_1Text";
			this.dedSposN1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN1_1Text.Text = "0";
			this.dedSposN1_1Text.Top = 5.929954F;
			this.dedSposN1_1Text.Width = 0.1F;
			// 
			// dedSposExeist2_1Text
			// 
			this.dedSposExeist2_1Text.CanGrow = false;
			this.dedSposExeist2_1Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExeist2_1Text.Height = 0.155F;
			this.dedSposExeist2_1Text.Left = 0.3880816F;
			this.dedSposExeist2_1Text.Name = "dedSposExeist2_1Text";
			this.dedSposExeist2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExeist2_1Text.Text = "0";
			this.dedSposExeist2_1Text.Top = 5.929954F;
			this.dedSposExeist2_1Text.Width = 0.1F;
			// 
			// dedSposN2_1Text
			// 
			this.dedSposN2_1Text.CanGrow = false;
			this.dedSposN2_1Text.DataField = "DED_SPOS_N2";
			this.dedSposN2_1Text.Height = 0.155F;
			this.dedSposN2_1Text.Left = 0.4880815F;
			this.dedSposN2_1Text.Name = "dedSposN2_1Text";
			this.dedSposN2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN2_1Text.Text = "0";
			this.dedSposN2_1Text.Top = 5.929954F;
			this.dedSposN2_1Text.Width = 0.1F;
			// 
			// Label148
			// 
			this.Label148.Height = 0.157F;
			this.Label148.HyperLink = null;
			this.Label148.Left = 0.6890815F;
			this.Label148.Name = "Label148";
			this.Label148.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label148.Text = "配偶者特別";
			this.Label148.Top = 5.427953F;
			this.Label148.Width = 0.593F;
			// 
			// Label149
			// 
			this.Label149.Height = 0.125F;
			this.Label149.HyperLink = null;
			this.Label149.Left = 1.188082F;
			this.Label149.Name = "Label149";
			this.Label149.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label149.Text = "円";
			this.Label149.Top = 5.741953F;
			this.Label149.Width = 0.1F;
			// 
			// sposExtDedAmt1Text
			// 
			this.sposExtDedAmt1Text.CanGrow = false;
			this.sposExtDedAmt1Text.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmt1Text.Height = 0.343F;
			this.sposExtDedAmt1Text.Left = 0.6875815F;
			this.sposExtDedAmt1Text.Name = "sposExtDedAmt1Text";
			this.sposExtDedAmt1Text.OutputFormat = "#,##0";
			this.sposExtDedAmt1Text.Style = "font-size: 5.8pt; text-align: right; vertical-align: bottom; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposExtDedAmt1Text.Text = "Z,ZZ6,ZZ6";
			this.sposExtDedAmt1Text.Top = 5.739453F;
			this.sposExtDedAmt1Text.Width = 0.5625F;
			// 
			// Label150
			// 
			this.Label150.Height = 0.104F;
			this.Label150.HyperLink = null;
			this.Label150.Left = 1.282081F;
			this.Label150.Name = "Label150";
			this.Label150.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label150.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.Label150.Top = 5.427953F;
			this.Label150.Width = 1.317F;
			// 
			// Label151
			// 
			this.Label151.Height = 0.104F;
			this.Label151.HyperLink = null;
			this.Label151.Left = 1.282081F;
			this.Label151.Name = "Label151";
			this.Label151.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label151.Text = "     　　（配偶者を除く）";
			this.Label151.Top = 5.531953F;
			this.Label151.Width = 1.317F;
			// 
			// Label152
			// 
			this.Label152.Height = 0.105F;
			this.Label152.HyperLink = null;
			this.Label152.Left = 1.282081F;
			this.Label152.Name = "Label152";
			this.Label152.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label152.Text = "特　定";
			this.Label152.Top = 5.635954F;
			this.Label152.Width = 0.386F;
			// 
			// Label153
			// 
			this.Label153.Height = 0.105F;
			this.Label153.HyperLink = null;
			this.Label153.Left = 1.668082F;
			this.Label153.Name = "Label153";
			this.Label153.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label153.Text = "老　人";
			this.Label153.Top = 5.635954F;
			this.Label153.Width = 0.547F;
			// 
			// Label154
			// 
			this.Label154.Height = 0.105F;
			this.Label154.HyperLink = null;
			this.Label154.Left = 2.215081F;
			this.Label154.Name = "Label154";
			this.Label154.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label154.Text = "その他";
			this.Label154.Top = 5.635954F;
			this.Label154.Width = 0.38F;
			// 
			// Label155
			// 
			this.Label155.Height = 0.125F;
			this.Label155.HyperLink = null;
			this.Label155.Left = 1.351081F;
			this.Label155.Name = "Label155";
			this.Label155.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label155.Text = "人";
			this.Label155.Top = 5.741953F;
			this.Label155.Width = 0.099F;
			// 
			// specDpndNum1_2Text
			// 
			this.specDpndNum1_2Text.CanGrow = false;
			this.specDpndNum1_2Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_2Text.Height = 0.343F;
			this.specDpndNum1_2Text.Left = 1.312582F;
			this.specDpndNum1_2Text.Name = "specDpndNum1_2Text";
			this.specDpndNum1_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_2Text.Text = "Z6";
			this.specDpndNum1_2Text.Top = 5.741953F;
			this.specDpndNum1_2Text.Width = 0.125F;
			// 
			// specDpndNum2_2Text
			// 
			this.specDpndNum2_2Text.CanGrow = false;
			this.specDpndNum2_2Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_2Text.Height = 0.343F;
			this.specDpndNum2_2Text.Left = 1.470082F;
			this.specDpndNum2_2Text.Name = "specDpndNum2_2Text";
			this.specDpndNum2_2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum2_2Text.Text = "Z6";
			this.specDpndNum2_2Text.Top = 5.741953F;
			this.specDpndNum2_2Text.Width = 0.155F;
			// 
			// Label156
			// 
			this.Label156.Height = 0.125F;
			this.Label156.HyperLink = null;
			this.Label156.Left = 1.470082F;
			this.Label156.Name = "Label156";
			this.Label156.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label156.Text = "従人";
			this.Label156.Top = 5.741953F;
			this.Label156.Width = 0.198F;
			// 
			// Label157
			// 
			this.Label157.Height = 0.125F;
			this.Label157.HyperLink = null;
			this.Label157.Left = 1.668082F;
			this.Label157.Name = "Label157";
			this.Label157.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label157.Text = "内";
			this.Label157.Top = 5.741953F;
			this.Label157.Width = 0.11F;
			// 
			// liveTgtAgePreNum1Text
			// 
			this.liveTgtAgePreNum1Text.CanGrow = false;
			this.liveTgtAgePreNum1Text.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNum1Text.Height = 0.343F;
			this.liveTgtAgePreNum1Text.Left = 1.668082F;
			this.liveTgtAgePreNum1Text.Name = "liveTgtAgePreNum1Text";
			this.liveTgtAgePreNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNum1Text.Text = "Z6";
			this.liveTgtAgePreNum1Text.Top = 5.741953F;
			this.liveTgtAgePreNum1Text.Width = 0.11F;
			// 
			// Label158
			// 
			this.Label158.Height = 0.125F;
			this.Label158.HyperLink = null;
			this.Label158.Left = 1.872082F;
			this.Label158.Name = "Label158";
			this.Label158.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label158.Text = "人";
			this.Label158.Top = 5.741953F;
			this.Label158.Width = 0.125F;
			// 
			// tagePreNum1Tex
			// 
			this.tagePreNum1Tex.CanGrow = false;
			this.tagePreNum1Tex.DataField = "AGE_PRE_NUM";
			this.tagePreNum1Tex.Height = 0.343F;
			this.tagePreNum1Tex.Left = 1.778082F;
			this.tagePreNum1Tex.Name = "tagePreNum1Tex";
			this.tagePreNum1Tex.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.tagePreNum1Tex.Text = "Z6";
			this.tagePreNum1Tex.Top = 5.741953F;
			this.tagePreNum1Tex.Width = 0.1595F;
			// 
			// agePreNum2_1Text
			// 
			this.agePreNum2_1Text.CanGrow = false;
			this.agePreNum2_1Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2_1Text.Height = 0.343F;
			this.agePreNum2_1Text.Left = 1.997082F;
			this.agePreNum2_1Text.Name = "agePreNum2_1Text";
			this.agePreNum2_1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum2_1Text.Text = "Z6";
			this.agePreNum2_1Text.Top = 5.741953F;
			this.agePreNum2_1Text.Width = 0.1905F;
			// 
			// Label159
			// 
			this.Label159.Height = 0.125F;
			this.Label159.HyperLink = null;
			this.Label159.Left = 1.997082F;
			this.Label159.Name = "Label159";
			this.Label159.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label159.Text = "従人";
			this.Label159.Top = 5.741953F;
			this.Label159.Width = 0.219F;
			// 
			// Label160
			// 
			this.Label160.Height = 0.125F;
			this.Label160.HyperLink = null;
			this.Label160.Left = 2.282082F;
			this.Label160.Name = "Label160";
			this.Label160.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label160.Text = "人";
			this.Label160.Top = 5.741953F;
			this.Label160.Width = 0.125F;
			// 
			// othersDpndNum1Text
			// 
			this.othersDpndNum1Text.CanGrow = false;
			this.othersDpndNum1Text.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNum1Text.Height = 0.343F;
			this.othersDpndNum1Text.Left = 2.215081F;
			this.othersDpndNum1Text.Name = "othersDpndNum1Text";
			this.othersDpndNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum1Text.Text = "Z6";
			this.othersDpndNum1Text.Top = 5.741953F;
			this.othersDpndNum1Text.Width = 0.1599999F;
			// 
			// Label161
			// 
			this.Label161.Height = 0.125F;
			this.Label161.HyperLink = null;
			this.Label161.Left = 2.405082F;
			this.Label161.Name = "Label161";
			this.Label161.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label161.Text = "従人";
			this.Label161.Top = 5.742452F;
			this.Label161.Width = 0.2179999F;
			// 
			// othersDpndNum2_1Text
			// 
			this.othersDpndNum2_1Text.CanGrow = false;
			this.othersDpndNum2_1Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2_1Text.Height = 0.343F;
			this.othersDpndNum2_1Text.Left = 2.407082F;
			this.othersDpndNum2_1Text.Name = "othersDpndNum2_1Text";
			this.othersDpndNum2_1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum2_1Text.Text = "Z6";
			this.othersDpndNum2_1Text.Top = 5.741953F;
			this.othersDpndNum2_1Text.Width = 0.1554999F;
			// 
			// Label162
			// 
			this.Label162.Height = 0.104F;
			this.Label162.HyperLink = null;
			this.Label162.Left = 2.599082F;
			this.Label162.Name = "Label162";
			this.Label162.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label162.Text = "障害者の数";
			this.Label162.Top = 5.427953F;
			this.Label162.Width = 0.5249999F;
			// 
			// Label163
			// 
			this.Label163.Height = 0.105F;
			this.Label163.HyperLink = null;
			this.Label163.Left = 2.599082F;
			this.Label163.Name = "Label163";
			this.Label163.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label163.Text = "特 別";
			this.Label163.Top = 5.635954F;
			this.Label163.Width = 0.25F;
			// 
			// liveTgtHandiNum1Text
			// 
			this.liveTgtHandiNum1Text.CanGrow = false;
			this.liveTgtHandiNum1Text.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtHandiNum1Text.Height = 0.343F;
			this.liveTgtHandiNum1Text.Left = 2.599082F;
			this.liveTgtHandiNum1Text.Name = "liveTgtHandiNum1Text";
			this.liveTgtHandiNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtHandiNum1Text.Text = "Z6";
			this.liveTgtHandiNum1Text.Top = 5.741953F;
			this.liveTgtHandiNum1Text.Width = 0.125F;
			// 
			// extHandiNum1Text
			// 
			this.extHandiNum1Text.CanGrow = false;
			this.extHandiNum1Text.DataField = "EXT_HANDI_NUM";
			this.extHandiNum1Text.Height = 0.343F;
			this.extHandiNum1Text.Left = 2.724082F;
			this.extHandiNum1Text.Name = "extHandiNum1Text";
			this.extHandiNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHandiNum1Text.Text = "Z6";
			this.extHandiNum1Text.Top = 5.741953F;
			this.extHandiNum1Text.Width = 0.125F;
			// 
			// Label164
			// 
			this.Label164.Height = 0.125F;
			this.Label164.HyperLink = null;
			this.Label164.Left = 2.724082F;
			this.Label164.Name = "Label164";
			this.Label164.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label164.Text = "人";
			this.Label164.Top = 5.741953F;
			this.Label164.Width = 0.125F;
			// 
			// Label165
			// 
			this.Label165.Height = 0.125F;
			this.Label165.HyperLink = null;
			this.Label165.Left = 2.599082F;
			this.Label165.Name = "Label165";
			this.Label165.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label165.Text = "内";
			this.Label165.Top = 5.741953F;
			this.Label165.Width = 0.125F;
			// 
			// Label166
			// 
			this.Label166.Height = 0.104F;
			this.Label166.HyperLink = null;
			this.Label166.Left = 2.599082F;
			this.Label166.Name = "Label166";
			this.Label166.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label166.Text = "（本人を除く）";
			this.Label166.Top = 5.531953F;
			this.Label166.Width = 0.5249999F;
			// 
			// Label167
			// 
			this.Label167.Height = 0.105F;
			this.Label167.HyperLink = null;
			this.Label167.Left = 2.849082F;
			this.Label167.Name = "Label167";
			this.Label167.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label167.Text = "その他";
			this.Label167.Top = 5.635954F;
			this.Label167.Width = 0.275F;
			// 
			// Label168
			// 
			this.Label168.Height = 0.125F;
			this.Label168.HyperLink = null;
			this.Label168.Left = 2.999082F;
			this.Label168.Name = "Label168";
			this.Label168.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label168.Text = "人";
			this.Label168.Top = 5.741953F;
			this.Label168.Width = 0.125F;
			// 
			// handiNum1Text
			// 
			this.handiNum1Text.CanGrow = false;
			this.handiNum1Text.DataField = "HANDI_NUM";
			this.handiNum1Text.Height = 0.343F;
			this.handiNum1Text.Left = 2.849082F;
			this.handiNum1Text.Name = "handiNum1Text";
			this.handiNum1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.handiNum1Text.Text = "Z6";
			this.handiNum1Text.Top = 5.741953F;
			this.handiNum1Text.Width = 0.2135F;
			// 
			// Label169
			// 
			this.Label169.Height = 0.156F;
			this.Label169.HyperLink = null;
			this.Label169.Left = 3.124082F;
			this.Label169.Name = "Label169";
			this.Label169.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label169.Text = "社会保険料";
			this.Label169.Top = 5.427953F;
			this.Label169.Width = 0.532F;
			// 
			// Label170
			// 
			this.Label170.Height = 0.125F;
			this.Label170.HyperLink = null;
			this.Label170.Left = 3.526082F;
			this.Label170.Name = "Label170";
			this.Label170.Style = "font-size: 6pt; text-align: right; vertical-align: top; ddo-char-set: 1";
			this.Label170.Text = "円";
			this.Label170.Top = 5.741953F;
			this.Label170.Width = 0.125F;
			// 
			// smlScaleCompCpratAmt1Text
			// 
			this.smlScaleCompCpratAmt1Text.CanGrow = false;
			this.smlScaleCompCpratAmt1Text.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.smlScaleCompCpratAmt1Text.Height = 0.24F;
			this.smlScaleCompCpratAmt1Text.Left = 3.124082F;
			this.smlScaleCompCpratAmt1Text.Name = "smlScaleCompCpratAmt1Text";
			this.smlScaleCompCpratAmt1Text.OutputFormat = "#,##0";
			this.smlScaleCompCpratAmt1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.smlScaleCompCpratAmt1Text.Text = "ZZ,ZZZ,ZZ6";
			this.smlScaleCompCpratAmt1Text.Top = 5.741953F;
			this.smlScaleCompCpratAmt1Text.Width = 0.532F;
			// 
			// Label172
			// 
			this.Label172.Height = 0.156F;
			this.Label172.HyperLink = null;
			this.Label172.Left = 3.656081F;
			this.Label172.Name = "Label172";
			this.Label172.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label172.Text = "生命保険料";
			this.Label172.Top = 5.427953F;
			this.Label172.Width = 0.563F;
			// 
			// Label173
			// 
			this.Label173.Height = 0.125F;
			this.Label173.HyperLink = null;
			this.Label173.Left = 4.116082F;
			this.Label173.Name = "Label173";
			this.Label173.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label173.Text = "円";
			this.Label173.Top = 5.741953F;
			this.Label173.Width = 0.11F;
			// 
			// lifeInsDedAmt1Text
			// 
			this.lifeInsDedAmt1Text.CanGrow = false;
			this.lifeInsDedAmt1Text.DataField = "LIFE_INS_DED_AMT";
			this.lifeInsDedAmt1Text.Height = 0.1875F;
			this.lifeInsDedAmt1Text.Left = 3.656081F;
			this.lifeInsDedAmt1Text.Name = "lifeInsDedAmt1Text";
			this.lifeInsDedAmt1Text.OutputFormat = "#,##0";
			this.lifeInsDedAmt1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsDedAmt1Text.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsDedAmt1Text.Top = 5.904452F;
			this.lifeInsDedAmt1Text.Width = 0.563F;
			// 
			// Label174
			// 
			this.Label174.Height = 0.156F;
			this.Label174.HyperLink = null;
			this.Label174.Left = 4.770082F;
			this.Label174.Name = "Label174";
			this.Label174.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label174.Text = "住宅借入金等";
			this.Label174.Top = 5.427953F;
			this.Label174.Width = 0.605F;
			// 
			// Label175
			// 
			this.Label175.Height = 0.125F;
			this.Label175.HyperLink = null;
			this.Label175.Left = 5.238081F;
			this.Label175.Name = "Label175";
			this.Label175.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label175.Text = "円";
			this.Label175.Top = 5.741953F;
			this.Label175.Width = 0.1370001F;
			// 
			// housingObtDedAmtText
			// 
			this.housingObtDedAmtText.CanGrow = false;
			this.housingObtDedAmtText.DataField = "HOUSING_OBT_DED_AMT";
			this.housingObtDedAmtText.Height = 0.1875F;
			this.housingObtDedAmtText.Left = 4.770082F;
			this.housingObtDedAmtText.Name = "housingObtDedAmtText";
			this.housingObtDedAmtText.OutputFormat = "#,##0";
			this.housingObtDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.housingObtDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.housingObtDedAmtText.Top = 5.904452F;
			this.housingObtDedAmtText.Width = 0.605F;
			// 
			// summary0Digit1Text
			// 
			this.summary0Digit1Text.CanGrow = false;
			this.summary0Digit1Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit1Text.Height = 0.125F;
			this.summary0Digit1Text.Left = 0.208F;
			this.summary0Digit1Text.MultiLine = false;
			this.summary0Digit1Text.Name = "summary0Digit1Text";
			this.summary0Digit1Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit1Text.Top = 6.08F;
			this.summary0Digit1Text.Width = 3.695F;
			// 
			// Label177
			// 
			this.Label177.Height = 0.153F;
			this.Label177.HyperLink = null;
			this.Label177.Left = 2.441F;
			this.Label177.Name = "Label177";
			this.Label177.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label177.Text = "配偶者の合計所得";
			this.Label177.Top = 6.228F;
			this.Label177.Width = 0.67F;
			// 
			// Label178
			// 
			this.Label178.Height = 0.153F;
			this.Label178.HyperLink = null;
			this.Label178.Left = 3.883F;
			this.Label178.Name = "Label178";
			this.Label178.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label178.Text = "旧個人年金保険料の金額";
			this.Label178.Top = 6.388F;
			this.Label178.Width = 0.755F;
			// 
			// Label179
			// 
			this.Label179.Height = 0.153F;
			this.Label179.HyperLink = null;
			this.Label179.Left = 3.883F;
			this.Label179.Name = "Label179";
			this.Label179.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label179.Text = "長期損害保険料の金額";
			this.Label179.Top = 6.551F;
			this.Label179.Width = 0.755F;
			// 
			// sposSumINcmAmt1Text
			// 
			this.sposSumINcmAmt1Text.CanGrow = false;
			this.sposSumINcmAmt1Text.DataField = "SPOS_SUM_INCM_AMT";
			this.sposSumINcmAmt1Text.Height = 0.153F;
			this.sposSumINcmAmt1Text.Left = 3.111F;
			this.sposSumINcmAmt1Text.Name = "sposSumINcmAmt1Text";
			this.sposSumINcmAmt1Text.OutputFormat = "#,##0";
			this.sposSumINcmAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposSumINcmAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.sposSumINcmAmt1Text.Top = 6.238F;
			this.sposSumINcmAmt1Text.Width = 0.647F;
			// 
			// Label180
			// 
			this.Label180.Height = 0.153F;
			this.Label180.HyperLink = null;
			this.Label180.Left = 3.758F;
			this.Label180.Name = "Label180";
			this.Label180.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label180.Text = "円";
			this.Label180.Top = 6.238F;
			this.Label180.Width = 0.125F;
			// 
			// Label181
			// 
			this.Label181.Height = 0.153F;
			this.Label181.HyperLink = null;
			this.Label181.Left = 5.26F;
			this.Label181.Name = "Label181";
			this.Label181.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label181.Text = "円";
			this.Label181.Top = 6.391F;
			this.Label181.Width = 0.125F;
			// 
			// lifeInsPensAmt1Text
			// 
			this.lifeInsPensAmt1Text.CanGrow = false;
			this.lifeInsPensAmt1Text.DataField = "LIFE_INS_PENS_AMT";
			this.lifeInsPensAmt1Text.Height = 0.153F;
			this.lifeInsPensAmt1Text.Left = 4.613F;
			this.lifeInsPensAmt1Text.Name = "lifeInsPensAmt1Text";
			this.lifeInsPensAmt1Text.OutputFormat = "#,##0";
			this.lifeInsPensAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.lifeInsPensAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsPensAmt1Text.Top = 6.393F;
			this.lifeInsPensAmt1Text.Width = 0.647F;
			// 
			// Label182
			// 
			this.Label182.Height = 0.153F;
			this.Label182.HyperLink = null;
			this.Label182.Left = 5.26F;
			this.Label182.Name = "Label182";
			this.Label182.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label182.Text = "円";
			this.Label182.Top = 6.551F;
			this.Label182.Width = 0.125F;
			// 
			// nolfInsLongProdAmt1Text
			// 
			this.nolfInsLongProdAmt1Text.CanGrow = false;
			this.nolfInsLongProdAmt1Text.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmt1Text.Height = 0.153F;
			this.nolfInsLongProdAmt1Text.Left = 4.613F;
			this.nolfInsLongProdAmt1Text.Name = "nolfInsLongProdAmt1Text";
			this.nolfInsLongProdAmt1Text.OutputFormat = "#,##0";
			this.nolfInsLongProdAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.nolfInsLongProdAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmt1Text.Top = 6.551F;
			this.nolfInsLongProdAmt1Text.Width = 0.647F;
			// 
			// Label213
			// 
			this.Label213.Height = 0.17F;
			this.Label213.HyperLink = null;
			this.Label213.Left = 2.689F;
			this.Label213.Name = "Label213";
			this.Label213.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label213.Text = "就職";
			this.Label213.Top = 6.862F;
			this.Label213.Width = 0.2F;
			// 
			// Label215
			// 
			this.Label215.Height = 0.17F;
			this.Label215.HyperLink = null;
			this.Label215.Left = 3.33F;
			this.Label215.Name = "Label215";
			this.Label215.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label215.Text = "月";
			this.Label215.Top = 6.862F;
			this.Label215.Width = 0.192F;
			// 
			// Label216
			// 
			this.Label216.Height = 0.17F;
			this.Label216.HyperLink = null;
			this.Label216.Left = 3.089F;
			this.Label216.Name = "Label216";
			this.Label216.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label216.Text = "年";
			this.Label216.Top = 6.862F;
			this.Label216.Width = 0.241F;
			// 
			// Label217
			// 
			this.Label217.Height = 0.17F;
			this.Label217.HyperLink = null;
			this.Label217.Left = 3.522F;
			this.Label217.Name = "Label217";
			this.Label217.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label217.Text = "日";
			this.Label217.Top = 6.862F;
			this.Label217.Width = 0.228F;
			// 
			// Label218
			// 
			this.Label218.Height = 0.16F;
			this.Label218.HyperLink = null;
			this.Label218.Left = 3.75F;
			this.Label218.Name = "Label218";
			this.Label218.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label218.Text = "受給者生年月日";
			this.Label218.Top = 6.702F;
			this.Label218.Width = 1.625F;
			// 
			// Label219
			// 
			this.Label219.Height = 0.17F;
			this.Label219.HyperLink = null;
			this.Label219.Left = 3.75F;
			this.Label219.Name = "Label219";
			this.Label219.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label219.Text = "明";
			this.Label219.Top = 6.862F;
			this.Label219.Width = 0.194F;
			// 
			// Label223
			// 
			this.Label223.Height = 0.17F;
			this.Label223.HyperLink = null;
			this.Label223.Left = 4.526F;
			this.Label223.Name = "Label223";
			this.Label223.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label223.Text = "年";
			this.Label223.Top = 6.862F;
			this.Label223.Width = 0.283F;
			// 
			// TextBox38
			// 
			this.TextBox38.CanGrow = false;
			this.TextBox38.DataField = "EMP_REGIST_NAME";
			this.TextBox38.Height = 0.157F;
			this.TextBox38.Left = 3.756082F;
			this.TextBox38.Name = "TextBox38";
			this.TextBox38.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.TextBox38.Text = "あいうえおかきくけこさしすせそ";
			this.TextBox38.Top = 4.770953F;
			this.TextBox38.Width = 1.619F;
			// 
			// Label226
			// 
			this.Label226.Height = 0.16F;
			this.Label226.HyperLink = null;
			this.Label226.Left = 2.689F;
			this.Label226.Name = "Label226";
			this.Label226.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label226.Text = "中途就・退職";
			this.Label226.Top = 6.702F;
			this.Label226.Width = 1.061F;
			// 
			// minrType1Text
			// 
			this.minrType1Text.CanGrow = false;
			this.minrType1Text.DataField = "MINR_TYPE";
			this.minrType1Text.Height = 0.17F;
			this.minrType1Text.Left = 0.417F;
			this.minrType1Text.Name = "minrType1Text";
			this.minrType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrType1Text.Text = "0";
			this.minrType1Text.Top = 7.035F;
			this.minrType1Text.Width = 0.2F;
			// 
			// latter1Text
			// 
			this.latter1Text.CanGrow = false;
			this.latter1Text.DataField = "LATTER";
			this.latter1Text.Height = 0.17F;
			this.latter1Text.Left = 1.29F;
			this.latter1Text.Name = "latter1Text";
			this.latter1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latter1Text.Text = "0";
			this.latter1Text.Top = 7.035F;
			this.latter1Text.Width = 0.2F;
			// 
			// extHandiType1Text
			// 
			this.extHandiType1Text.CanGrow = false;
			this.extHandiType1Text.DataField = "EXT_HANDI_TYPE";
			this.extHandiType1Text.Height = 0.17F;
			this.extHandiType1Text.Left = 1.49F;
			this.extHandiType1Text.Name = "extHandiType1Text";
			this.extHandiType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiType1Text.Text = "0";
			this.extHandiType1Text.Top = 7.035F;
			this.extHandiType1Text.Width = 0.2F;
			// 
			// handiType1Text
			// 
			this.handiType1Text.CanGrow = false;
			this.handiType1Text.DataField = "HANDI_TYPE";
			this.handiType1Text.Height = 0.17F;
			this.handiType1Text.Left = 1.69F;
			this.handiType1Text.Name = "handiType1Text";
			this.handiType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.handiType1Text.Text = "0";
			this.handiType1Text.Top = 7.035F;
			this.handiType1Text.Width = 0.2F;
			// 
			// widowType1Text
			// 
			this.widowType1Text.CanGrow = false;
			this.widowType1Text.DataField = "WIDOW_TYPE";
			this.widowType1Text.Height = 0.17F;
			this.widowType1Text.Left = 1.89F;
			this.widowType1Text.Name = "widowType1Text";
			this.widowType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowType1Text.Text = "0";
			this.widowType1Text.Top = 7.035F;
			this.widowType1Text.Width = 0.2F;
			// 
			// extWidowType1Text
			// 
			this.extWidowType1Text.CanGrow = false;
			this.extWidowType1Text.DataField = "EXT_WIDOW_TYPE";
			this.extWidowType1Text.Height = 0.17F;
			this.extWidowType1Text.Left = 2.09F;
			this.extWidowType1Text.Name = "extWidowType1Text";
			this.extWidowType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowType1Text.Text = "0";
			this.extWidowType1Text.Top = 7.035F;
			this.extWidowType1Text.Width = 0.2F;
			// 
			// widomType1Text
			// 
			this.widomType1Text.CanGrow = false;
			this.widomType1Text.DataField = "WIDOM_TYPE";
			this.widomType1Text.Height = 0.17F;
			this.widomType1Text.Left = 2.29F;
			this.widomType1Text.Name = "widomType1Text";
			this.widomType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomType1Text.Text = "0";
			this.widomType1Text.Top = 7.035F;
			this.widomType1Text.Width = 0.2F;
			// 
			// wrkStdType1Text
			// 
			this.wrkStdType1Text.CanGrow = false;
			this.wrkStdType1Text.DataField = "WRK_STD_TYPE";
			this.wrkStdType1Text.Height = 0.17F;
			this.wrkStdType1Text.Left = 2.49F;
			this.wrkStdType1Text.Name = "wrkStdType1Text";
			this.wrkStdType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdType1Text.Text = "0";
			this.wrkStdType1Text.Top = 7.035F;
			this.wrkStdType1Text.Width = 0.2F;
			// 
			// Label227
			// 
			this.Label227.Height = 0.166F;
			this.Label227.HyperLink = null;
			this.Label227.Left = 0.198F;
			this.Label227.Name = "Label227";
			this.Label227.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label227.Text = "支";
			this.Label227.Top = 7.22F;
			this.Label227.Width = 0.22F;
			// 
			// Label228
			// 
			this.Label228.Height = 0.166F;
			this.Label228.HyperLink = null;
			this.Label228.Left = 0.198F;
			this.Label228.Name = "Label228";
			this.Label228.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label228.Text = "払";
			this.Label228.Top = 7.376F;
			this.Label228.Width = 0.22F;
			// 
			// Label229
			// 
			this.Label229.Height = 0.166F;
			this.Label229.HyperLink = null;
			this.Label229.Left = 0.198F;
			this.Label229.Name = "Label229";
			this.Label229.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label229.Text = "者";
			this.Label229.Top = 7.548F;
			this.Label229.Width = 0.22F;
			// 
			// paymntAddress1Text
			// 
			this.paymntAddress1Text.CanGrow = false;
			this.paymntAddress1Text.DataField = "PAYMNT_ADDRESS";
			this.paymntAddress1Text.Height = 0.332F;
			this.paymntAddress1Text.Left = 1.07F;
			this.paymntAddress1Text.Name = "paymntAddress1Text";
			this.paymntAddress1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddress1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddress1Text.Top = 7.21F;
			this.paymntAddress1Text.Width = 4.312F;
			// 
			// paymntName1Text
			// 
			this.paymntName1Text.CanGrow = false;
			this.paymntName1Text.DataField = "PAYMNT_NAME";
			this.paymntName1Text.Height = 0.188F;
			this.paymntName1Text.Left = 1.07F;
			this.paymntName1Text.MultiLine = false;
			this.paymntName1Text.Name = "paymntName1Text";
			this.paymntName1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntName1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntName1Text.Top = 7.556F;
			this.paymntName1Text.Width = 3.125F;
			// 
			// Label230
			// 
			this.Label230.Height = 0.188F;
			this.Label230.HyperLink = null;
			this.Label230.Left = 4.188F;
			this.Label230.Name = "Label230";
			this.Label230.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label230.Text = "（電話）";
			this.Label230.Top = 7.542F;
			this.Label230.Width = 0.375F;
			// 
			// paymntPhone1Text
			// 
			this.paymntPhone1Text.CanGrow = false;
			this.paymntPhone1Text.DataField = "PAYMNT_PHONE";
			this.paymntPhone1Text.Height = 0.188F;
			this.paymntPhone1Text.Left = 4.553F;
			this.paymntPhone1Text.Name = "paymntPhone1Text";
			this.paymntPhone1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.paymntPhone1Text.Text = "00000000000000";
			this.paymntPhone1Text.Top = 7.542F;
			this.paymntPhone1Text.Width = 0.813F;
			// 
			// Label231
			// 
			this.Label231.Height = 0.166F;
			this.Label231.HyperLink = null;
			this.Label231.Left = 0.42F;
			this.Label231.Name = "Label231";
			this.Label231.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label231.Text = "住所（居所）";
			this.Label231.Top = 7.21F;
			this.Label231.Width = 0.65F;
			// 
			// Label232
			// 
			this.Label232.Height = 0.166F;
			this.Label232.HyperLink = null;
			this.Label232.Left = 0.42F;
			this.Label232.Name = "Label232";
			this.Label232.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label232.Text = "又は所在地";
			this.Label232.Top = 7.376F;
			this.Label232.Width = 0.65F;
			// 
			// Label234
			// 
			this.Label234.Height = 0.188F;
			this.Label234.HyperLink = null;
			this.Label234.Left = 0.42F;
			this.Label234.Name = "Label234";
			this.Label234.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label234.Text = "氏名又は名称";
			this.Label234.Top = 7.548F;
			this.Label234.Width = 0.655F;
			// 
			// Label236
			// 
			this.Label236.Height = 0.209F;
			this.Label236.HyperLink = null;
			this.Label236.Left = 0.1875815F;
			this.Label236.Name = "Label236";
			this.Label236.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label236.Text = "を受け";
			this.Label236.Top = 4.509954F;
			this.Label236.Width = 0.292F;
			// 
			// Label237
			// 
			this.Label237.Height = 0.209F;
			this.Label237.HyperLink = null;
			this.Label237.Left = 0.1875815F;
			this.Label237.Name = "Label237";
			this.Label237.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label237.Text = "る者";
			this.Label237.Top = 4.718951F;
			this.Label237.Width = 0.292F;
			// 
			// Label238
			// 
			this.Label238.Height = 0.313F;
			this.Label238.HyperLink = null;
			this.Label238.Left = 3.017081F;
			this.Label238.Name = "Label238";
			this.Label238.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label238.Text = "名";
			this.Label238.Top = 4.614953F;
			this.Label238.Width = 0.19F;
			// 
			// Label239
			// 
			this.Label239.Height = 0.157F;
			this.Label239.HyperLink = null;
			this.Label239.Left = 0.1890815F;
			this.Label239.Name = "Label239";
			this.Label239.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label239.Text = "者の有無等";
			this.Label239.Top = 5.584953F;
			this.Label239.Width = 0.399F;
			// 
			// Label240
			// 
			this.Label240.Height = 0.157F;
			this.Label240.HyperLink = null;
			this.Label240.Left = 0.6880816F;
			this.Label240.Name = "Label240";
			this.Label240.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label240.Text = "控除の額";
			this.Label240.Top = 5.584953F;
			this.Label240.Width = 0.593F;
			// 
			// Label241
			// 
			this.Label241.Height = 0.157F;
			this.Label241.HyperLink = null;
			this.Label241.Left = 3.125082F;
			this.Label241.Name = "Label241";
			this.Label241.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label241.Text = "等の金額";
			this.Label241.Top = 5.583953F;
			this.Label241.Width = 0.532F;
			// 
			// Label242
			// 
			this.Label242.Height = 0.157F;
			this.Label242.HyperLink = null;
			this.Label242.Left = 3.656081F;
			this.Label242.Name = "Label242";
			this.Label242.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label242.Text = "の控除額";
			this.Label242.Top = 5.583953F;
			this.Label242.Width = 0.563F;
			// 
			// Label243
			// 
			this.Label243.Height = 0.157F;
			this.Label243.HyperLink = null;
			this.Label243.Left = 4.770082F;
			this.Label243.Name = "Label243";
			this.Label243.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label243.Text = "特別控除の額";
			this.Label243.Top = 5.583953F;
			this.Label243.Width = 0.605F;
			// 
			// Label244
			// 
			this.Label244.Height = 0.156F;
			this.Label244.HyperLink = null;
			this.Label244.Left = 4.219081F;
			this.Label244.Name = "Label244";
			this.Label244.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label244.Text = "損害保険料";
			this.Label244.Top = 5.427953F;
			this.Label244.Width = 0.551F;
			// 
			// Label245
			// 
			this.Label245.Height = 0.157F;
			this.Label245.HyperLink = null;
			this.Label245.Left = 4.219081F;
			this.Label245.Name = "Label245";
			this.Label245.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label245.Text = "の控除額";
			this.Label245.Top = 5.583953F;
			this.Label245.Width = 0.551F;
			// 
			// nolfInsDedAmt1Text
			// 
			this.nolfInsDedAmt1Text.CanGrow = false;
			this.nolfInsDedAmt1Text.DataField = "NOLF_INS_DED_AMT";
			this.nolfInsDedAmt1Text.Height = 0.1875F;
			this.nolfInsDedAmt1Text.Left = 4.219081F;
			this.nolfInsDedAmt1Text.Name = "nolfInsDedAmt1Text";
			this.nolfInsDedAmt1Text.OutputFormat = "#,##0";
			this.nolfInsDedAmt1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsDedAmt1Text.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsDedAmt1Text.Top = 5.904452F;
			this.nolfInsDedAmt1Text.Width = 0.551F;
			// 
			// Label246
			// 
			this.Label246.Height = 0.125F;
			this.Label246.HyperLink = null;
			this.Label246.Left = 4.659081F;
			this.Label246.Name = "Label246";
			this.Label246.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label246.Text = "円";
			this.Label246.Top = 5.741953F;
			this.Label246.Width = 0.1114998F;
			// 
			// deathRetireType1Text
			// 
			this.deathRetireType1Text.CanGrow = false;
			this.deathRetireType1Text.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireType1Text.Height = 0.17F;
			this.deathRetireType1Text.Left = 0.869F;
			this.deathRetireType1Text.Name = "deathRetireType1Text";
			this.deathRetireType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireType1Text.Text = "0";
			this.deathRetireType1Text.Top = 7.035F;
			this.deathRetireType1Text.Width = 0.2F;
			// 
			// disasterType1Text
			// 
			this.disasterType1Text.CanGrow = false;
			this.disasterType1Text.DataField = "DISASTER_TYPE";
			this.disasterType1Text.Height = 0.17F;
			this.disasterType1Text.Left = 1.08F;
			this.disasterType1Text.Name = "disasterType1Text";
			this.disasterType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterType1Text.Text = "0";
			this.disasterType1Text.Top = 7.035F;
			this.disasterType1Text.Width = 0.2F;
			// 
			// foreignType1Text
			// 
			this.foreignType1Text.CanGrow = false;
			this.foreignType1Text.DataField = "FOREIGN_TYPE";
			this.foreignType1Text.Height = 0.17F;
			this.foreignType1Text.Left = 0.648F;
			this.foreignType1Text.Name = "foreignType1Text";
			this.foreignType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignType1Text.Text = "0";
			this.foreignType1Text.Top = 7.035F;
			this.foreignType1Text.Width = 0.2F;
			// 
			// halfEmployType1Text
			// 
			this.halfEmployType1Text.CanGrow = false;
			this.halfEmployType1Text.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployType1Text.Height = 0.17F;
			this.halfEmployType1Text.Left = 2.689F;
			this.halfEmployType1Text.Name = "halfEmployType1Text";
			this.halfEmployType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployType1Text.Text = "0";
			this.halfEmployType1Text.Top = 7.035F;
			this.halfEmployType1Text.Width = 0.2F;
			// 
			// Label270
			// 
			this.Label270.Height = 0.17F;
			this.Label270.HyperLink = null;
			this.Label270.Left = 2.889F;
			this.Label270.Name = "Label270";
			this.Label270.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label270.Text = "退職";
			this.Label270.Top = 6.862F;
			this.Label270.Width = 0.2F;
			// 
			// halfRetireType1Text
			// 
			this.halfRetireType1Text.CanGrow = false;
			this.halfRetireType1Text.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireType1Text.Height = 0.17F;
			this.halfRetireType1Text.Left = 2.889F;
			this.halfRetireType1Text.Name = "halfRetireType1Text";
			this.halfRetireType1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireType1Text.Text = "0";
			this.halfRetireType1Text.Top = 7.035F;
			this.halfRetireType1Text.Width = 0.2F;
			// 
			// halfEmReDateYear1Text
			// 
			this.halfEmReDateYear1Text.CanGrow = false;
			this.halfEmReDateYear1Text.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halfEmReDateYear1Text.Height = 0.17F;
			this.halfEmReDateYear1Text.Left = 3.089F;
			this.halfEmReDateYear1Text.Name = "halfEmReDateYear1Text";
			this.halfEmReDateYear1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateYear1Text.Text = "0";
			this.halfEmReDateYear1Text.Top = 7.035F;
			this.halfEmReDateYear1Text.Width = 0.241F;
			// 
			// halfEmReDateMonth1Text
			// 
			this.halfEmReDateMonth1Text.CanGrow = false;
			this.halfEmReDateMonth1Text.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReDateMonth1Text.Height = 0.17F;
			this.halfEmReDateMonth1Text.Left = 3.33F;
			this.halfEmReDateMonth1Text.Name = "halfEmReDateMonth1Text";
			this.halfEmReDateMonth1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateMonth1Text.Text = "0";
			this.halfEmReDateMonth1Text.Top = 7.035F;
			this.halfEmReDateMonth1Text.Width = 0.192F;
			// 
			// halfEmReDateDate1Text
			// 
			this.halfEmReDateDate1Text.CanGrow = false;
			this.halfEmReDateDate1Text.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDate1Text.Height = 0.17F;
			this.halfEmReDateDate1Text.Left = 3.522F;
			this.halfEmReDateDate1Text.Name = "halfEmReDateDate1Text";
			this.halfEmReDateDate1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDate1Text.Text = "0";
			this.halfEmReDateDate1Text.Top = 7.035F;
			this.halfEmReDateDate1Text.Width = 0.228F;
			// 
			// Label271
			// 
			this.Label271.Height = 0.17F;
			this.Label271.HyperLink = null;
			this.Label271.Left = 3.944F;
			this.Label271.Name = "Label271";
			this.Label271.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label271.Text = "大";
			this.Label271.Top = 6.862F;
			this.Label271.Width = 0.194F;
			// 
			// Label272
			// 
			this.Label272.Height = 0.17F;
			this.Label272.HyperLink = null;
			this.Label272.Left = 4.138F;
			this.Label272.Name = "Label272";
			this.Label272.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label272.Text = "昭";
			this.Label272.Top = 6.862F;
			this.Label272.Width = 0.194F;
			// 
			// Label273
			// 
			this.Label273.Height = 0.17F;
			this.Label273.HyperLink = null;
			this.Label273.Left = 4.332F;
			this.Label273.Name = "Label273";
			this.Label273.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label273.Text = "平";
			this.Label273.Top = 6.862F;
			this.Label273.Width = 0.194F;
			// 
			// Label274
			// 
			this.Label274.Height = 0.17F;
			this.Label274.HyperLink = null;
			this.Label274.Left = 4.809F;
			this.Label274.Name = "Label274";
			this.Label274.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label274.Text = "月";
			this.Label274.Top = 6.862F;
			this.Label274.Width = 0.283F;
			// 
			// Label275
			// 
			this.Label275.Height = 0.17F;
			this.Label275.HyperLink = null;
			this.Label275.Left = 5.092F;
			this.Label275.Name = "Label275";
			this.Label275.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label275.Text = "日";
			this.Label275.Top = 6.862F;
			this.Label275.Width = 0.283F;
			// 
			// birthNameOfEraM1Text
			// 
			this.birthNameOfEraM1Text.CanGrow = false;
			this.birthNameOfEraM1Text.DataField = "BIRTH_NAME_OF_ERA_M";
			this.birthNameOfEraM1Text.Height = 0.17F;
			this.birthNameOfEraM1Text.Left = 3.75F;
			this.birthNameOfEraM1Text.Name = "birthNameOfEraM1Text";
			this.birthNameOfEraM1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraM1Text.Text = "0";
			this.birthNameOfEraM1Text.Top = 7.035F;
			this.birthNameOfEraM1Text.Width = 0.194F;
			// 
			// birthNameOfEraT1Text
			// 
			this.birthNameOfEraT1Text.CanGrow = false;
			this.birthNameOfEraT1Text.DataField = "BIRTH_NAME_OF_ERA_T";
			this.birthNameOfEraT1Text.Height = 0.17F;
			this.birthNameOfEraT1Text.Left = 3.944F;
			this.birthNameOfEraT1Text.Name = "birthNameOfEraT1Text";
			this.birthNameOfEraT1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraT1Text.Text = "0";
			this.birthNameOfEraT1Text.Top = 7.035F;
			this.birthNameOfEraT1Text.Width = 0.194F;
			// 
			// birthNameOfEraS1Text
			// 
			this.birthNameOfEraS1Text.CanGrow = false;
			this.birthNameOfEraS1Text.DataField = "BIRTH_NAME_OF_ERA_S";
			this.birthNameOfEraS1Text.Height = 0.17F;
			this.birthNameOfEraS1Text.Left = 4.138F;
			this.birthNameOfEraS1Text.Name = "birthNameOfEraS1Text";
			this.birthNameOfEraS1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraS1Text.Text = "0";
			this.birthNameOfEraS1Text.Top = 7.035F;
			this.birthNameOfEraS1Text.Width = 0.194F;
			// 
			// birthNameOfEraH1Text
			// 
			this.birthNameOfEraH1Text.CanGrow = false;
			this.birthNameOfEraH1Text.DataField = "BIRTH_NAME_OF_ERA_H";
			this.birthNameOfEraH1Text.Height = 0.17F;
			this.birthNameOfEraH1Text.Left = 4.332F;
			this.birthNameOfEraH1Text.Name = "birthNameOfEraH1Text";
			this.birthNameOfEraH1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraH1Text.Text = "0";
			this.birthNameOfEraH1Text.Top = 7.035F;
			this.birthNameOfEraH1Text.Width = 0.194F;
			// 
			// birthDayYear1Text
			// 
			this.birthDayYear1Text.CanGrow = false;
			this.birthDayYear1Text.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYear1Text.Height = 0.17F;
			this.birthDayYear1Text.Left = 4.526F;
			this.birthDayYear1Text.Name = "birthDayYear1Text";
			this.birthDayYear1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYear1Text.Text = "0";
			this.birthDayYear1Text.Top = 7.035F;
			this.birthDayYear1Text.Width = 0.283F;
			// 
			// birthDayMonth1Text
			// 
			this.birthDayMonth1Text.CanGrow = false;
			this.birthDayMonth1Text.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonth1Text.Height = 0.17F;
			this.birthDayMonth1Text.Left = 4.809F;
			this.birthDayMonth1Text.Name = "birthDayMonth1Text";
			this.birthDayMonth1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonth1Text.Text = "0";
			this.birthDayMonth1Text.Top = 7.035F;
			this.birthDayMonth1Text.Width = 0.283F;
			// 
			// birthDayDay1Text
			// 
			this.birthDayDay1Text.CanGrow = false;
			this.birthDayDay1Text.DataField = "BIRTH_DAY_DAY";
			this.birthDayDay1Text.Height = 0.17F;
			this.birthDayDay1Text.Left = 5.092F;
			this.birthDayDay1Text.Name = "birthDayDay1Text";
			this.birthDayDay1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDay1Text.Text = "0";
			this.birthDayDay1Text.Top = 7.035F;
			this.birthDayDay1Text.Width = 0.283F;
			// 
			// socInsDedAmt1Text
			// 
			this.socInsDedAmt1Text.CanGrow = false;
			this.socInsDedAmt1Text.DataField = "SOC_INS_DED_AMT";
			this.socInsDedAmt1Text.Height = 0.158F;
			this.socInsDedAmt1Text.Left = 3.124082F;
			this.socInsDedAmt1Text.Name = "socInsDedAmt1Text";
			this.socInsDedAmt1Text.OutputFormat = "#,##0";
			this.socInsDedAmt1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.socInsDedAmt1Text.Text = "ZZ,ZZZ,ZZ6";
			this.socInsDedAmt1Text.Top = 5.941953F;
			this.socInsDedAmt1Text.Width = 0.532F;
			// 
			// Label703
			// 
			this.Label703.Height = 0.5F;
			this.Label703.HyperLink = null;
			this.Label703.Left = 0.01758147F;
			this.Label703.Name = "Label703";
			this.Label703.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label703.Text = "受給者交付用";
			this.Label703.Top = 7.176953F;
			this.Label703.Width = 0.1695F;
			// 
			// Label704
			// 
			this.Label704.Angle = 2700;
			this.Label704.Height = 0.1164999F;
			this.Label704.HyperLink = null;
			this.Label704.Left = 0.01808167F;
			this.Label704.Name = "Label704";
			this.Label704.Style = "font-size: 5.5pt; text-align: center; vertical-align: bottom; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label704.Text = "(";
			this.Label704.Top = 7.080454F;
			this.Label704.Width = 0.17F;
			// 
			// Label705
			// 
			this.Label705.Angle = 900;
			this.Label705.Height = 0.08F;
			this.Label705.HyperLink = null;
			this.Label705.Left = 0.01808167F;
			this.Label705.Name = "Label705";
			this.Label705.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label705.Text = "(";
			this.Label705.Top = 7.645452F;
			this.Label705.Width = 0.17F;
			// 
			// Line298
			// 
			this.Line298.Height = 0F;
			this.Line298.Left = 0.1880815F;
			this.Line298.LineWeight = 1F;
			this.Line298.Name = "Line298";
			this.Line298.Top = 7.724453F;
			this.Line298.Width = 5.187F;
			this.Line298.X1 = 0.1880815F;
			this.Line298.X2 = 5.375082F;
			this.Line298.Y1 = 7.724453F;
			this.Line298.Y2 = 7.724453F;
			// 
			// YlyEdCalYear1Text
			// 
			this.YlyEdCalYear1Text.CanGrow = false;
			this.YlyEdCalYear1Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear1Text.Height = 0.125F;
			this.YlyEdCalYear1Text.Left = 1.750082F;
			this.YlyEdCalYear1Text.Name = "YlyEdCalYear1Text";
			this.YlyEdCalYear1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.YlyEdCalYear1Text.Text = "0000";
			this.YlyEdCalYear1Text.Top = 3.989453F;
			this.YlyEdCalYear1Text.Visible = false;
			this.YlyEdCalYear1Text.Width = 0.4070001F;
			// 
			// Line300
			// 
			this.Line300.Height = 0F;
			this.Line300.Left = 0.1880815F;
			this.Line300.LineWeight = 1F;
			this.Line300.Name = "Line300";
			this.Line300.Top = 4.302453F;
			this.Line300.Width = 5.187F;
			this.Line300.X1 = 0.1880815F;
			this.Line300.X2 = 5.375082F;
			this.Line300.Y1 = 4.302453F;
			this.Line300.Y2 = 4.302453F;
			// 
			// Line301
			// 
			this.Line301.Height = 0F;
			this.Line301.Left = 0.1880815F;
			this.Line301.LineWeight = 1F;
			this.Line301.Name = "Line301";
			this.Line301.Top = 4.927453F;
			this.Line301.Width = 5.187F;
			this.Line301.X1 = 0.1880815F;
			this.Line301.X2 = 5.375082F;
			this.Line301.Y1 = 4.927453F;
			this.Line301.Y2 = 4.927453F;
			// 
			// Line302
			// 
			this.Line302.Height = 0F;
			this.Line302.Left = 0.1880815F;
			this.Line302.LineWeight = 1F;
			this.Line302.Name = "Line302";
			this.Line302.Top = 5.428453F;
			this.Line302.Width = 5.187F;
			this.Line302.X1 = 0.1880815F;
			this.Line302.X2 = 5.375082F;
			this.Line302.Y1 = 5.428453F;
			this.Line302.Y2 = 5.428453F;
			// 
			// Line303
			// 
			this.Line303.Height = 0F;
			this.Line303.Left = 0.1880815F;
			this.Line303.LineWeight = 1F;
			this.Line303.Name = "Line303";
			this.Line303.Top = 5.742452F;
			this.Line303.Width = 5.187F;
			this.Line303.X1 = 0.1880815F;
			this.Line303.X2 = 5.375082F;
			this.Line303.Y1 = 5.742452F;
			this.Line303.Y2 = 5.742452F;
			// 
			// Line304
			// 
			this.Line304.Height = 0F;
			this.Line304.Left = 0.188F;
			this.Line304.LineWeight = 1F;
			this.Line304.Name = "Line304";
			this.Line304.Top = 6.7F;
			this.Line304.Width = 5.187F;
			this.Line304.X1 = 0.188F;
			this.Line304.X2 = 5.375F;
			this.Line304.Y1 = 6.7F;
			this.Line304.Y2 = 6.7F;
			// 
			// Line306
			// 
			this.Line306.Height = 0F;
			this.Line306.Left = 0.188F;
			this.Line306.LineWeight = 1F;
			this.Line306.Name = "Line306";
			this.Line306.Top = 7.21F;
			this.Line306.Width = 5.187F;
			this.Line306.X1 = 0.188F;
			this.Line306.X2 = 5.375F;
			this.Line306.Y1 = 7.21F;
			this.Line306.Y2 = 7.21F;
			// 
			// Label991
			// 
			this.Label991.Height = 0.125F;
			this.Label991.HyperLink = null;
			this.Label991.Left = 2.125582F;
			this.Label991.Name = "Label991";
			this.Label991.Style = "font-size: 7pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label991.Text = "分";
			this.Label991.Top = 0.04128585F;
			this.Label991.Width = 0.1245001F;
			// 
			// YlyEdCalYear4Text
			// 
			this.YlyEdCalYear4Text.CanGrow = false;
			this.YlyEdCalYear4Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear4Text.Height = 0.125F;
			this.YlyEdCalYear4Text.Left = 1.730082F;
			this.YlyEdCalYear4Text.Name = "YlyEdCalYear4Text";
			this.YlyEdCalYear4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.YlyEdCalYear4Text.Text = "0000";
			this.YlyEdCalYear4Text.Top = 0.05128586F;
			this.YlyEdCalYear4Text.Width = 0.49F;
			// 
			// Label992
			// 
			this.Label992.Height = 0.1875F;
			this.Label992.HyperLink = null;
			this.Label992.Left = 2.250082F;
			this.Label992.Name = "Label992";
			this.Label992.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-" +
    "char-set: 1";
			this.Label992.Text = "給与所得の源泉徴収票";
			this.Label992.Top = 0.01028585F;
			this.Label992.Width = 1.625F;
			// 
			// Label993
			// 
			this.Label993.Height = 0.208F;
			this.Label993.HyperLink = null;
			this.Label993.Left = 0.1880815F;
			this.Label993.Name = "Label993";
			this.Label993.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label993.Text = "支払";
			this.Label993.Top = 0.1977859F;
			this.Label993.Width = 0.292F;
			// 
			// Label994
			// 
			this.Label994.Height = 0.625F;
			this.Label994.HyperLink = null;
			this.Label994.Left = 0.4800815F;
			this.Label994.Name = "Label994";
			this.Label994.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label994.Text = "住所又は居所";
			this.Label994.Top = 0.1977859F;
			this.Label994.Width = 0.1875F;
			// 
			// ylyEdAddress1_1Text
			// 
			this.ylyEdAddress1_1Text.CanGrow = false;
			this.ylyEdAddress1_1Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_1Text.Height = 0.625F;
			this.ylyEdAddress1_1Text.Left = 0.6680815F;
			this.ylyEdAddress1_1Text.Name = "ylyEdAddress1_1Text";
			this.ylyEdAddress1_1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_1Text.Top = 0.1977859F;
			this.ylyEdAddress1_1Text.Width = 2.349F;
			// 
			// Label995
			// 
			this.Label995.Height = 0.313F;
			this.Label995.HyperLink = null;
			this.Label995.Left = 3.017081F;
			this.Label995.Name = "Label995";
			this.Label995.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label995.Text = "氏";
			this.Label995.Top = 0.1977859F;
			this.Label995.Width = 0.19F;
			// 
			// empCodeText
			// 
			this.empCodeText.CanGrow = false;
			this.empCodeText.DataField = "EMP_CODE";
			this.empCodeText.Height = 0.156F;
			this.empCodeText.Left = 3.750082F;
			this.empCodeText.Name = "empCodeText";
			this.empCodeText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empCodeText.Text = "0000000000";
			this.empCodeText.Top = 0.1977859F;
			this.empCodeText.Width = 1.494F;
			// 
			// postNameText
			// 
			this.postNameText.CanGrow = false;
			this.postNameText.DataField = "POST_NAME";
			this.postNameText.Height = 0.156F;
			this.postNameText.Left = 3.756082F;
			this.postNameText.Name = "postNameText";
			this.postNameText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.postNameText.Text = "ああああああああああ";
			this.postNameText.Top = 0.5107861F;
			this.postNameText.Width = 1.619F;
			// 
			// empNameKanaText
			// 
			this.empNameKanaText.CanGrow = false;
			this.empNameKanaText.DataField = "EMP_REGIST_NAME_KANA";
			this.empNameKanaText.Height = 0.156F;
			this.empNameKanaText.Left = 3.756082F;
			this.empNameKanaText.Name = "empNameKanaText";
			this.empNameKanaText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameKanaText.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.empNameKanaText.Top = 0.353786F;
			this.empNameKanaText.Width = 1.619F;
			// 
			// Label996
			// 
			this.Label996.Height = 0.156F;
			this.Label996.HyperLink = null;
			this.Label996.Left = 3.207082F;
			this.Label996.Name = "Label996";
			this.Label996.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label996.Text = "(受給者番号）";
			this.Label996.Top = 0.1977859F;
			this.Label996.Width = 0.6055F;
			// 
			// Label997
			// 
			this.Label997.Height = 0.156F;
			this.Label997.HyperLink = null;
			this.Label997.Left = 3.207082F;
			this.Label997.Name = "Label997";
			this.Label997.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label997.Text = "(フリガナ）";
			this.Label997.Top = 0.353786F;
			this.Label997.Width = 0.543F;
			// 
			// Label998
			// 
			this.Label998.Height = 0.156F;
			this.Label998.HyperLink = null;
			this.Label998.Left = 3.207082F;
			this.Label998.Name = "Label998";
			this.Label998.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label998.Text = "(役職名）";
			this.Label998.Top = 0.5097857F;
			this.Label998.Width = 0.543F;
			// 
			// Label999
			// 
			this.Label999.Height = 0.173F;
			this.Label999.HyperLink = null;
			this.Label999.Left = 0.1875815F;
			this.Label999.Name = "Label999";
			this.Label999.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label999.Text = "種　　別";
			this.Label999.Top = 0.8227859F;
			this.Label999.Width = 0.938F;
			// 
			// Label1000
			// 
			this.Label1000.Height = 0.173F;
			this.Label1000.HyperLink = null;
			this.Label1000.Left = 1.126082F;
			this.Label1000.Name = "Label1000";
			this.Label1000.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1000.Text = "支　払　金　額";
			this.Label1000.Top = 0.8227859F;
			this.Label1000.Width = 1.078F;
			// 
			// Label1001
			// 
			this.Label1001.Height = 0.173F;
			this.Label1001.HyperLink = null;
			this.Label1001.Left = 2.204082F;
			this.Label1001.Name = "Label1001";
			this.Label1001.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1001.Text = " 給与所得控除後の金額";
			this.Label1001.Top = 0.8227859F;
			this.Label1001.Width = 1.063F;
			// 
			// Label1002
			// 
			this.Label1002.Height = 0.173F;
			this.Label1002.HyperLink = null;
			this.Label1002.Left = 3.267081F;
			this.Label1002.Name = "Label1002";
			this.Label1002.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1002.Text = "所得控除の額の合計額";
			this.Label1002.Top = 0.8227859F;
			this.Label1002.Width = 1.063F;
			// 
			// classText
			// 
			this.classText.CanGrow = false;
			this.classText.DataField = "CLASS";
			this.classText.Height = 0.328F;
			this.classText.Left = 0.1880815F;
			this.classText.Name = "classText";
			this.classText.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.classText.Text = "ああああああ";
			this.classText.Top = 0.9957858F;
			this.classText.Width = 0.937F;
			// 
			// paymntAmtText
			// 
			this.paymntAmtText.CanGrow = false;
			this.paymntAmtText.DataField = "PAYMNT_AMT";
			this.paymntAmtText.Height = 0.328F;
			this.paymntAmtText.Left = 1.225082F;
			this.paymntAmtText.Name = "paymntAmtText";
			this.paymntAmtText.OutputFormat = "#,##0";
			this.paymntAmtText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.paymntAmtText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.paymntAmtText.Top = 0.9957858F;
			this.paymntAmtText.Width = 0.838F;
			// 
			// Label1003
			// 
			this.Label1003.Height = 0.125F;
			this.Label1003.HyperLink = null;
			this.Label1003.Left = 1.125082F;
			this.Label1003.Name = "Label1003";
			this.Label1003.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1003.Text = "内";
			this.Label1003.Top = 0.9957858F;
			this.Label1003.Width = 0.1F;
			// 
			// Label1004
			// 
			this.Label1004.Height = 0.125F;
			this.Label1004.HyperLink = null;
			this.Label1004.Left = 2.063082F;
			this.Label1004.Name = "Label1004";
			this.Label1004.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1004.Text = "円";
			this.Label1004.Top = 0.9957858F;
			this.Label1004.Width = 0.141F;
			// 
			// slryInsmDedAmtText
			// 
			this.slryInsmDedAmtText.CanGrow = false;
			this.slryInsmDedAmtText.DataField = "SLRY_INSM_DED_AMT";
			this.slryInsmDedAmtText.Height = 0.328F;
			this.slryInsmDedAmtText.Left = 2.204082F;
			this.slryInsmDedAmtText.Name = "slryInsmDedAmtText";
			this.slryInsmDedAmtText.OutputFormat = "#,##0";
			this.slryInsmDedAmtText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.slryInsmDedAmtText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.slryInsmDedAmtText.Top = 0.9957858F;
			this.slryInsmDedAmtText.Width = 0.938F;
			// 
			// Label1005
			// 
			this.Label1005.Height = 0.125F;
			this.Label1005.HyperLink = null;
			this.Label1005.Left = 3.142081F;
			this.Label1005.Name = "Label1005";
			this.Label1005.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1005.Text = "円";
			this.Label1005.Top = 0.9957858F;
			this.Label1005.Width = 0.1245001F;
			// 
			// incmDedAmtSumText
			// 
			this.incmDedAmtSumText.CanGrow = false;
			this.incmDedAmtSumText.DataField = "INCM_DED_AMT_SUM";
			this.incmDedAmtSumText.Height = 0.328F;
			this.incmDedAmtSumText.Left = 3.267081F;
			this.incmDedAmtSumText.Name = "incmDedAmtSumText";
			this.incmDedAmtSumText.OutputFormat = "#,##0";
			this.incmDedAmtSumText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmDedAmtSumText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.incmDedAmtSumText.Top = 0.9957858F;
			this.incmDedAmtSumText.Width = 0.938F;
			// 
			// Label1006
			// 
			this.Label1006.Height = 0.125F;
			this.Label1006.HyperLink = null;
			this.Label1006.Left = 4.205081F;
			this.Label1006.Name = "Label1006";
			this.Label1006.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1006.Text = "円";
			this.Label1006.Top = 0.9957858F;
			this.Label1006.Width = 0.125F;
			// 
			// Label1007
			// 
			this.Label1007.Height = 0.125F;
			this.Label1007.HyperLink = null;
			this.Label1007.Left = 4.330081F;
			this.Label1007.Name = "Label1007";
			this.Label1007.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1007.Text = "内";
			this.Label1007.Top = 0.9957858F;
			this.Label1007.Width = 0.125F;
			// 
			// ylyCollectTaxText
			// 
			this.ylyCollectTaxText.CanGrow = false;
			this.ylyCollectTaxText.DataField = "YLY_COLLECT_TAX";
			this.ylyCollectTaxText.Height = 0.328F;
			this.ylyCollectTaxText.Left = 4.437582F;
			this.ylyCollectTaxText.Name = "ylyCollectTaxText";
			this.ylyCollectTaxText.OutputFormat = "#,##0";
			this.ylyCollectTaxText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ylyCollectTaxText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.ylyCollectTaxText.Top = 0.9957858F;
			this.ylyCollectTaxText.Width = 0.816F;
			// 
			// Label1008
			// 
			this.Label1008.Height = 0.125F;
			this.Label1008.HyperLink = null;
			this.Label1008.Left = 5.236082F;
			this.Label1008.Name = "Label1008";
			this.Label1008.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1008.Text = "円";
			this.Label1008.Top = 0.9957858F;
			this.Label1008.Width = 0.134F;
			// 
			// Label1009
			// 
			this.Label1009.Height = 0.173F;
			this.Label1009.HyperLink = null;
			this.Label1009.Left = 4.330081F;
			this.Label1009.Name = "Label1009";
			this.Label1009.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1009.Text = "源　泉　徴　収　税　額";
			this.Label1009.Top = 0.8227859F;
			this.Label1009.Width = 1.04F;
			// 
			// Label1010
			// 
			this.Label1010.Height = 0.157F;
			this.Label1010.HyperLink = null;
			this.Label1010.Left = 0.1880815F;
			this.Label1010.Name = "Label1010";
			this.Label1010.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1010.Text = "控除対象配偶";
			this.Label1010.Top = 1.323786F;
			this.Label1010.Width = 0.5F;
			// 
			// Label1011
			// 
			this.Label1011.Height = 0.345F;
			this.Label1011.HyperLink = null;
			this.Label1011.Left = 0.5880815F;
			this.Label1011.Name = "Label1011";
			this.Label1011.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1011.Text = "老人";
			this.Label1011.Top = 1.465286F;
			this.Label1011.Width = 0.1F;
			// 
			// Label1012
			// 
			this.Label1012.Height = 0.1875F;
			this.Label1012.HyperLink = null;
			this.Label1012.Left = 0.1880815F;
			this.Label1012.Name = "Label1012";
			this.Label1012.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1012.Text = "有";
			this.Label1012.Top = 1.637786F;
			this.Label1012.Width = 0.1F;
			// 
			// Label1013
			// 
			this.Label1013.Height = 0.188F;
			this.Label1013.HyperLink = null;
			this.Label1013.Left = 0.2880815F;
			this.Label1013.Name = "Label1013";
			this.Label1013.Style = "font-size: 6pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.Label1013.Text = "無";
			this.Label1013.Top = 1.637786F;
			this.Label1013.Width = 0.1F;
			// 
			// Label1014
			// 
			this.Label1014.Height = 0.188F;
			this.Label1014.HyperLink = null;
			this.Label1014.Left = 0.3880816F;
			this.Label1014.Name = "Label1014";
			this.Label1014.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1014.Text = "従有";
			this.Label1014.Top = 1.635703F;
			this.Label1014.Width = 0.1F;
			// 
			// Label1015
			// 
			this.Label1015.Height = 0.188F;
			this.Label1015.HyperLink = null;
			this.Label1015.Left = 0.4880815F;
			this.Label1015.Name = "Label1015";
			this.Label1015.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1015.Text = "従無";
			this.Label1015.Top = 1.635703F;
			this.Label1015.Width = 0.1F;
			// 
			// sposOldAgeTypeText
			// 
			this.sposOldAgeTypeText.CanGrow = false;
			this.sposOldAgeTypeText.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeTypeText.Height = 0.155F;
			this.sposOldAgeTypeText.Left = 0.5880815F;
			this.sposOldAgeTypeText.Name = "sposOldAgeTypeText";
			this.sposOldAgeTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeTypeText.Text = "0";
			this.sposOldAgeTypeText.Top = 1.825786F;
			this.sposOldAgeTypeText.Width = 0.1F;
			// 
			// dedSposExistText
			// 
			this.dedSposExistText.CanGrow = false;
			this.dedSposExistText.DataField = "DED_SPOS_EXIST";
			this.dedSposExistText.Height = 0.155F;
			this.dedSposExistText.Left = 0.1880815F;
			this.dedSposExistText.Name = "dedSposExistText";
			this.dedSposExistText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExistText.Text = "0";
			this.dedSposExistText.Top = 1.825786F;
			this.dedSposExistText.Width = 0.1F;
			// 
			// dedSposNText
			// 
			this.dedSposNText.CanGrow = false;
			this.dedSposNText.DataField = "DED_SPOS_N";
			this.dedSposNText.Height = 0.155F;
			this.dedSposNText.Left = 0.2880815F;
			this.dedSposNText.Name = "dedSposNText";
			this.dedSposNText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposNText.Text = "0";
			this.dedSposNText.Top = 1.825786F;
			this.dedSposNText.Width = 0.1F;
			// 
			// dedSposExist2Text
			// 
			this.dedSposExist2Text.CanGrow = false;
			this.dedSposExist2Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExist2Text.Height = 0.155F;
			this.dedSposExist2Text.Left = 0.3880816F;
			this.dedSposExist2Text.Name = "dedSposExist2Text";
			this.dedSposExist2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExist2Text.Text = "0";
			this.dedSposExist2Text.Top = 1.825786F;
			this.dedSposExist2Text.Width = 0.1F;
			// 
			// dedSposN2Text
			// 
			this.dedSposN2Text.CanGrow = false;
			this.dedSposN2Text.DataField = "DED_SPOS_N2";
			this.dedSposN2Text.Height = 0.155F;
			this.dedSposN2Text.Left = 0.4880815F;
			this.dedSposN2Text.Name = "dedSposN2Text";
			this.dedSposN2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposN2Text.Text = "0";
			this.dedSposN2Text.Top = 1.825786F;
			this.dedSposN2Text.Width = 0.1F;
			// 
			// Label1016
			// 
			this.Label1016.Height = 0.157F;
			this.Label1016.HyperLink = null;
			this.Label1016.Left = 0.6890815F;
			this.Label1016.Name = "Label1016";
			this.Label1016.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1016.Text = "配偶者特別";
			this.Label1016.Top = 1.323786F;
			this.Label1016.Width = 0.593F;
			// 
			// Label1017
			// 
			this.Label1017.Height = 0.125F;
			this.Label1017.HyperLink = null;
			this.Label1017.Left = 1.188082F;
			this.Label1017.Name = "Label1017";
			this.Label1017.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1017.Text = "円";
			this.Label1017.Top = 1.637786F;
			this.Label1017.Width = 0.1F;
			// 
			// sposExtDedAmtText
			// 
			this.sposExtDedAmtText.CanGrow = false;
			this.sposExtDedAmtText.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmtText.Height = 0.343F;
			this.sposExtDedAmtText.Left = 0.6880816F;
			this.sposExtDedAmtText.Name = "sposExtDedAmtText";
			this.sposExtDedAmtText.OutputFormat = "#,##0";
			this.sposExtDedAmtText.Style = "font-size: 5.8pt; text-align: right; vertical-align: bottom; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sposExtDedAmtText.Text = "Z,ZZZ,ZZ9";
			this.sposExtDedAmtText.Top = 1.637786F;
			this.sposExtDedAmtText.Width = 0.562F;
			// 
			// Label1018
			// 
			this.Label1018.Height = 0.104F;
			this.Label1018.HyperLink = null;
			this.Label1018.Left = 1.282081F;
			this.Label1018.Name = "Label1018";
			this.Label1018.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1018.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.Label1018.Top = 1.323786F;
			this.Label1018.Width = 1.317F;
			// 
			// Label1019
			// 
			this.Label1019.Height = 0.104F;
			this.Label1019.HyperLink = null;
			this.Label1019.Left = 1.282081F;
			this.Label1019.Name = "Label1019";
			this.Label1019.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1019.Text = "     　　（配偶者を除く）";
			this.Label1019.Top = 1.427786F;
			this.Label1019.Width = 1.317F;
			// 
			// Label1020
			// 
			this.Label1020.Height = 0.105F;
			this.Label1020.HyperLink = null;
			this.Label1020.Left = 1.282081F;
			this.Label1020.Name = "Label1020";
			this.Label1020.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1020.Text = "特　定";
			this.Label1020.Top = 1.531786F;
			this.Label1020.Width = 0.386F;
			// 
			// Label1021
			// 
			this.Label1021.Height = 0.105F;
			this.Label1021.HyperLink = null;
			this.Label1021.Left = 1.668082F;
			this.Label1021.Name = "Label1021";
			this.Label1021.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1021.Text = "老　人";
			this.Label1021.Top = 1.531786F;
			this.Label1021.Width = 0.547F;
			// 
			// Label1022
			// 
			this.Label1022.Height = 0.105F;
			this.Label1022.HyperLink = null;
			this.Label1022.Left = 2.215081F;
			this.Label1022.Name = "Label1022";
			this.Label1022.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1022.Text = "その他";
			this.Label1022.Top = 1.531786F;
			this.Label1022.Width = 0.38F;
			// 
			// Label1023
			// 
			this.Label1023.Height = 0.125F;
			this.Label1023.HyperLink = null;
			this.Label1023.Left = 1.351081F;
			this.Label1023.Name = "Label1023";
			this.Label1023.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1023.Text = "人";
			this.Label1023.Top = 1.637786F;
			this.Label1023.Width = 0.099F;
			// 
			// specDpndNum1_1Text
			// 
			this.specDpndNum1_1Text.CanGrow = false;
			this.specDpndNum1_1Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_1Text.Height = 0.343F;
			this.specDpndNum1_1Text.Left = 1.312582F;
			this.specDpndNum1_1Text.Name = "specDpndNum1_1Text";
			this.specDpndNum1_1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_1Text.Text = "Z6";
			this.specDpndNum1_1Text.Top = 1.637786F;
			this.specDpndNum1_1Text.Width = 0.125F;
			// 
			// specDpndNum2_1Text
			// 
			this.specDpndNum2_1Text.CanGrow = false;
			this.specDpndNum2_1Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_1Text.Height = 0.343F;
			this.specDpndNum2_1Text.Left = 1.470082F;
			this.specDpndNum2_1Text.Name = "specDpndNum2_1Text";
			this.specDpndNum2_1Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum2_1Text.Text = "Z6";
			this.specDpndNum2_1Text.Top = 1.637786F;
			this.specDpndNum2_1Text.Width = 0.155F;
			// 
			// Label1024
			// 
			this.Label1024.Height = 0.125F;
			this.Label1024.HyperLink = null;
			this.Label1024.Left = 1.470082F;
			this.Label1024.Name = "Label1024";
			this.Label1024.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1024.Text = "従人";
			this.Label1024.Top = 1.637786F;
			this.Label1024.Width = 0.198F;
			// 
			// Label1025
			// 
			this.Label1025.Height = 0.125F;
			this.Label1025.HyperLink = null;
			this.Label1025.Left = 1.668082F;
			this.Label1025.Name = "Label1025";
			this.Label1025.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1025.Text = "内";
			this.Label1025.Top = 1.637786F;
			this.Label1025.Width = 0.11F;
			// 
			// liveTgtAgePreNumText
			// 
			this.liveTgtAgePreNumText.CanGrow = false;
			this.liveTgtAgePreNumText.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNumText.Height = 0.343F;
			this.liveTgtAgePreNumText.Left = 1.668082F;
			this.liveTgtAgePreNumText.Name = "liveTgtAgePreNumText";
			this.liveTgtAgePreNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNumText.Text = "Z6";
			this.liveTgtAgePreNumText.Top = 1.638286F;
			this.liveTgtAgePreNumText.Width = 0.11F;
			// 
			// Label1026
			// 
			this.Label1026.Height = 0.125F;
			this.Label1026.HyperLink = null;
			this.Label1026.Left = 1.872082F;
			this.Label1026.Name = "Label1026";
			this.Label1026.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1026.Text = "人";
			this.Label1026.Top = 1.637786F;
			this.Label1026.Width = 0.125F;
			// 
			// agePreNumText
			// 
			this.agePreNumText.CanGrow = false;
			this.agePreNumText.DataField = "AGE_PRE_NUM";
			this.agePreNumText.Height = 0.343F;
			this.agePreNumText.Left = 1.778082F;
			this.agePreNumText.Name = "agePreNumText";
			this.agePreNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNumText.Text = "Z6";
			this.agePreNumText.Top = 1.637786F;
			this.agePreNumText.Width = 0.1595F;
			// 
			// agePreNum2Text
			// 
			this.agePreNum2Text.CanGrow = false;
			this.agePreNum2Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2Text.Height = 0.343F;
			this.agePreNum2Text.Left = 1.997082F;
			this.agePreNum2Text.Name = "agePreNum2Text";
			this.agePreNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNum2Text.Text = "Z6";
			this.agePreNum2Text.Top = 1.637786F;
			this.agePreNum2Text.Width = 0.1905F;
			// 
			// Label1027
			// 
			this.Label1027.Height = 0.125F;
			this.Label1027.HyperLink = null;
			this.Label1027.Left = 1.997082F;
			this.Label1027.Name = "Label1027";
			this.Label1027.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1027.Text = "従人";
			this.Label1027.Top = 1.637786F;
			this.Label1027.Width = 0.219F;
			// 
			// Label1028
			// 
			this.Label1028.Height = 0.125F;
			this.Label1028.HyperLink = null;
			this.Label1028.Left = 2.282082F;
			this.Label1028.Name = "Label1028";
			this.Label1028.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1028.Text = "人";
			this.Label1028.Top = 1.637786F;
			this.Label1028.Width = 0.125F;
			// 
			// othersDpndNumText
			// 
			this.othersDpndNumText.CanGrow = false;
			this.othersDpndNumText.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNumText.Height = 0.343F;
			this.othersDpndNumText.Left = 2.215081F;
			this.othersDpndNumText.Name = "othersDpndNumText";
			this.othersDpndNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNumText.Text = "Z6";
			this.othersDpndNumText.Top = 1.637786F;
			this.othersDpndNumText.Width = 0.1599999F;
			// 
			// Label1029
			// 
			this.Label1029.Height = 0.125F;
			this.Label1029.HyperLink = null;
			this.Label1029.Left = 2.375082F;
			this.Label1029.Name = "Label1029";
			this.Label1029.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1029.Text = "従人";
			this.Label1029.Top = 1.635286F;
			this.Label1029.Width = 0.25F;
			// 
			// othersDpndNum2Text
			// 
			this.othersDpndNum2Text.CanGrow = false;
			this.othersDpndNum2Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2Text.Height = 0.343F;
			this.othersDpndNum2Text.Left = 2.407082F;
			this.othersDpndNum2Text.Name = "othersDpndNum2Text";
			this.othersDpndNum2Text.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNum2Text.Text = "Z6";
			this.othersDpndNum2Text.Top = 1.637786F;
			this.othersDpndNum2Text.Width = 0.1554999F;
			// 
			// Label1030
			// 
			this.Label1030.Height = 0.104F;
			this.Label1030.HyperLink = null;
			this.Label1030.Left = 2.599082F;
			this.Label1030.Name = "Label1030";
			this.Label1030.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1030.Text = "障害者の数";
			this.Label1030.Top = 1.323786F;
			this.Label1030.Width = 0.5249999F;
			// 
			// Label1031
			// 
			this.Label1031.Height = 0.105F;
			this.Label1031.HyperLink = null;
			this.Label1031.Left = 2.599082F;
			this.Label1031.Name = "Label1031";
			this.Label1031.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1031.Text = "特 別";
			this.Label1031.Top = 1.531786F;
			this.Label1031.Width = 0.25F;
			// 
			// liveTgtExtHandiNumText
			// 
			this.liveTgtExtHandiNumText.CanGrow = false;
			this.liveTgtExtHandiNumText.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtExtHandiNumText.Height = 0.343F;
			this.liveTgtExtHandiNumText.Left = 2.599082F;
			this.liveTgtExtHandiNumText.Name = "liveTgtExtHandiNumText";
			this.liveTgtExtHandiNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtExtHandiNumText.Text = "Z6";
			this.liveTgtExtHandiNumText.Top = 1.637786F;
			this.liveTgtExtHandiNumText.Width = 0.125F;
			// 
			// extHndiNumText
			// 
			this.extHndiNumText.CanGrow = false;
			this.extHndiNumText.DataField = "EXT_HANDI_NUM";
			this.extHndiNumText.Height = 0.343F;
			this.extHndiNumText.Left = 2.724082F;
			this.extHndiNumText.Name = "extHndiNumText";
			this.extHndiNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHndiNumText.Text = "Z6";
			this.extHndiNumText.Top = 1.637786F;
			this.extHndiNumText.Width = 0.125F;
			// 
			// Label1032
			// 
			this.Label1032.Height = 0.125F;
			this.Label1032.HyperLink = null;
			this.Label1032.Left = 2.724082F;
			this.Label1032.Name = "Label1032";
			this.Label1032.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1032.Text = "人";
			this.Label1032.Top = 1.637786F;
			this.Label1032.Width = 0.125F;
			// 
			// Label1033
			// 
			this.Label1033.Height = 0.125F;
			this.Label1033.HyperLink = null;
			this.Label1033.Left = 2.599082F;
			this.Label1033.Name = "Label1033";
			this.Label1033.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1033.Text = "内";
			this.Label1033.Top = 1.637786F;
			this.Label1033.Width = 0.125F;
			// 
			// Label1034
			// 
			this.Label1034.Height = 0.104F;
			this.Label1034.HyperLink = null;
			this.Label1034.Left = 2.599082F;
			this.Label1034.Name = "Label1034";
			this.Label1034.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1034.Text = "（本人を除く）";
			this.Label1034.Top = 1.427786F;
			this.Label1034.Width = 0.5249999F;
			// 
			// Label1035
			// 
			this.Label1035.Height = 0.105F;
			this.Label1035.HyperLink = null;
			this.Label1035.Left = 2.849082F;
			this.Label1035.Name = "Label1035";
			this.Label1035.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1035.Text = "その他";
			this.Label1035.Top = 1.531786F;
			this.Label1035.Width = 0.275F;
			// 
			// Label1036
			// 
			this.Label1036.Height = 0.125F;
			this.Label1036.HyperLink = null;
			this.Label1036.Left = 2.999082F;
			this.Label1036.Name = "Label1036";
			this.Label1036.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1036.Text = "人";
			this.Label1036.Top = 1.637786F;
			this.Label1036.Width = 0.125F;
			// 
			// HandiNumText
			// 
			this.HandiNumText.CanGrow = false;
			this.HandiNumText.DataField = "HANDI_NUM";
			this.HandiNumText.Height = 0.343F;
			this.HandiNumText.Left = 2.849082F;
			this.HandiNumText.Name = "HandiNumText";
			this.HandiNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HandiNumText.Text = "Z6";
			this.HandiNumText.Top = 1.637786F;
			this.HandiNumText.Width = 0.2135F;
			// 
			// Label1037
			// 
			this.Label1037.Height = 0.156F;
			this.Label1037.HyperLink = null;
			this.Label1037.Left = 3.124082F;
			this.Label1037.Name = "Label1037";
			this.Label1037.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1037.Text = "社会保険料";
			this.Label1037.Top = 1.323786F;
			this.Label1037.Width = 0.532F;
			// 
			// Label1038
			// 
			this.Label1038.Height = 0.125F;
			this.Label1038.HyperLink = null;
			this.Label1038.Left = 3.526082F;
			this.Label1038.Name = "Label1038";
			this.Label1038.Style = "font-size: 6pt; text-align: right; vertical-align: top; ddo-char-set: 1";
			this.Label1038.Text = "円";
			this.Label1038.Top = 1.637786F;
			this.Label1038.Width = 0.125F;
			// 
			// smlScaleCompCpratAmtText
			// 
			this.smlScaleCompCpratAmtText.CanGrow = false;
			this.smlScaleCompCpratAmtText.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.smlScaleCompCpratAmtText.Height = 0.24F;
			this.smlScaleCompCpratAmtText.Left = 3.124082F;
			this.smlScaleCompCpratAmtText.Name = "smlScaleCompCpratAmtText";
			this.smlScaleCompCpratAmtText.OutputFormat = "#,##0";
			this.smlScaleCompCpratAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.smlScaleCompCpratAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.smlScaleCompCpratAmtText.Top = 1.637786F;
			this.smlScaleCompCpratAmtText.Width = 0.532F;
			// 
			// Label1039
			// 
			this.Label1039.Height = 0.156F;
			this.Label1039.HyperLink = null;
			this.Label1039.Left = 3.656081F;
			this.Label1039.Name = "Label1039";
			this.Label1039.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1039.Text = "生命保険料";
			this.Label1039.Top = 1.323786F;
			this.Label1039.Width = 0.563F;
			// 
			// Label1040
			// 
			this.Label1040.Height = 0.125F;
			this.Label1040.HyperLink = null;
			this.Label1040.Left = 4.116082F;
			this.Label1040.Name = "Label1040";
			this.Label1040.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1040.Text = "円";
			this.Label1040.Top = 1.637786F;
			this.Label1040.Width = 0.11F;
			// 
			// lifeInsDedAmtText
			// 
			this.lifeInsDedAmtText.CanGrow = false;
			this.lifeInsDedAmtText.DataField = "LIFE_INS_DED_AMT";
			this.lifeInsDedAmtText.Height = 0.1875F;
			this.lifeInsDedAmtText.Left = 3.656081F;
			this.lifeInsDedAmtText.Name = "lifeInsDedAmtText";
			this.lifeInsDedAmtText.OutputFormat = "#,##0";
			this.lifeInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsDedAmtText.Top = 1.800286F;
			this.lifeInsDedAmtText.Width = 0.563F;
			// 
			// Label1041
			// 
			this.Label1041.Height = 0.156F;
			this.Label1041.HyperLink = null;
			this.Label1041.Left = 4.770082F;
			this.Label1041.Name = "Label1041";
			this.Label1041.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1041.Text = "住宅借入金等";
			this.Label1041.Top = 1.323786F;
			this.Label1041.Width = 0.605F;
			// 
			// Label1042
			// 
			this.Label1042.Height = 0.125F;
			this.Label1042.HyperLink = null;
			this.Label1042.Left = 5.238081F;
			this.Label1042.Name = "Label1042";
			this.Label1042.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1042.Text = "円";
			this.Label1042.Top = 1.637786F;
			this.Label1042.Width = 0.1370001F;
			// 
			// TextBox454
			// 
			this.TextBox454.CanGrow = false;
			this.TextBox454.DataField = "HOUSING_OBT_DED_AMT";
			this.TextBox454.Height = 0.1875F;
			this.TextBox454.Left = 4.770082F;
			this.TextBox454.Name = "TextBox454";
			this.TextBox454.OutputFormat = "#,##0";
			this.TextBox454.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TextBox454.Text = "ZZ,ZZZ,ZZ6";
			this.TextBox454.Top = 1.800286F;
			this.TextBox454.Width = 0.605F;
			// 
			// Label1044
			// 
			this.Label1044.Height = 0.153F;
			this.Label1044.HyperLink = null;
			this.Label1044.Left = 2.441F;
			this.Label1044.Name = "Label1044";
			this.Label1044.Style = "font-size: 5.5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1044.Text = "配偶者の合計所得";
			this.Label1044.Top = 2.136F;
			this.Label1044.Width = 0.67F;
			// 
			// Label1045
			// 
			this.Label1045.Height = 0.153F;
			this.Label1045.HyperLink = null;
			this.Label1045.Left = 3.883F;
			this.Label1045.Name = "Label1045";
			this.Label1045.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1045.Text = "旧個人年金保険料の金額";
			this.Label1045.Top = 2.289F;
			this.Label1045.Width = 0.755F;
			// 
			// Label1046
			// 
			this.Label1046.Height = 0.153F;
			this.Label1046.HyperLink = null;
			this.Label1046.Left = 3.883F;
			this.Label1046.Name = "Label1046";
			this.Label1046.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1046.Text = "長期損害保険料の金額";
			this.Label1046.Top = 2.456F;
			this.Label1046.Width = 0.755F;
			// 
			// sponSumIncmAmtText
			// 
			this.sponSumIncmAmtText.CanGrow = false;
			this.sponSumIncmAmtText.DataField = "SPOS_SUM_INCM_AMT";
			this.sponSumIncmAmtText.Height = 0.153F;
			this.sponSumIncmAmtText.Left = 3.111F;
			this.sponSumIncmAmtText.Name = "sponSumIncmAmtText";
			this.sponSumIncmAmtText.OutputFormat = "#,##0";
			this.sponSumIncmAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.sponSumIncmAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.sponSumIncmAmtText.Top = 2.136F;
			this.sponSumIncmAmtText.Width = 0.647F;
			// 
			// Label1047
			// 
			this.Label1047.Height = 0.153F;
			this.Label1047.HyperLink = null;
			this.Label1047.Left = 5.26F;
			this.Label1047.Name = "Label1047";
			this.Label1047.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1047.Text = "円";
			this.Label1047.Top = 1.98F;
			this.Label1047.Width = 0.125F;
			// 
			// Label1048
			// 
			this.Label1048.Height = 0.153F;
			this.Label1048.HyperLink = null;
			this.Label1048.Left = 5.26F;
			this.Label1048.Name = "Label1048";
			this.Label1048.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1048.Text = "円";
			this.Label1048.Top = 2.289F;
			this.Label1048.Width = 0.125F;
			// 
			// LifeInsPensAmtText
			// 
			this.LifeInsPensAmtText.CanGrow = false;
			this.LifeInsPensAmtText.DataField = "LIFE_INS_PENS_AMT";
			this.LifeInsPensAmtText.Height = 0.153F;
			this.LifeInsPensAmtText.Left = 4.613F;
			this.LifeInsPensAmtText.Name = "LifeInsPensAmtText";
			this.LifeInsPensAmtText.OutputFormat = "#,##0";
			this.LifeInsPensAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.LifeInsPensAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.LifeInsPensAmtText.Top = 2.289F;
			this.LifeInsPensAmtText.Width = 0.647F;
			// 
			// Label1049
			// 
			this.Label1049.Height = 0.153F;
			this.Label1049.HyperLink = null;
			this.Label1049.Left = 5.26F;
			this.Label1049.Name = "Label1049";
			this.Label1049.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1049.Text = "円";
			this.Label1049.Top = 2.446F;
			this.Label1049.Width = 0.125F;
			// 
			// nolfInsLongProdAmtText
			// 
			this.nolfInsLongProdAmtText.CanGrow = false;
			this.nolfInsLongProdAmtText.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmtText.Height = 0.153F;
			this.nolfInsLongProdAmtText.Left = 4.613F;
			this.nolfInsLongProdAmtText.Name = "nolfInsLongProdAmtText";
			this.nolfInsLongProdAmtText.OutputFormat = "#,##0";
			this.nolfInsLongProdAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.nolfInsLongProdAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmtText.Top = 2.446F;
			this.nolfInsLongProdAmtText.Width = 0.647F;
			// 
			// Label1051
			// 
			this.Label1051.Height = 0.165F;
			this.Label1051.HyperLink = null;
			this.Label1051.Left = 1.29F;
			this.Label1051.Name = "Label1051";
			this.Label1051.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.Label1051.Text = "乙";
			this.Label1051.Top = 2.598F;
			this.Label1051.Width = 0.2F;
			// 
			// Label1052
			// 
			this.Label1052.Height = 0.165F;
			this.Label1052.HyperLink = null;
			this.Label1052.Left = 1.29F;
			this.Label1052.Name = "Label1052";
			this.Label1052.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1052.Text = "欄";
			this.Label1052.Top = 2.763F;
			this.Label1052.Width = 0.2F;
			// 
			// Label1053
			// 
			this.Label1053.Height = 0.09F;
			this.Label1053.HyperLink = null;
			this.Label1053.Left = 1.5F;
			this.Label1053.Name = "Label1053";
			this.Label1053.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1053.Text = "本人が障害者";
			this.Label1053.Top = 2.598F;
			this.Label1053.Width = 0.394F;
			// 
			// Label1054
			// 
			this.Label1054.Height = 0.21F;
			this.Label1054.HyperLink = null;
			this.Label1054.Left = 1.531F;
			this.Label1054.Name = "Label1054";
			this.Label1054.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1054.Text = "特別";
			this.Label1054.Top = 2.712F;
			this.Label1054.Width = 0.1249999F;
			// 
			// Label1059
			// 
			this.Label1059.Height = 0.155F;
			this.Label1059.HyperLink = null;
			this.Label1059.Left = 0.1880815F;
			this.Label1059.Name = "Label1059";
			this.Label1059.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1059.Text = "署 番 号";
			this.Label1059.Top = 3.620286F;
			this.Label1059.Width = 0.593F;
			// 
			// Label1062
			// 
			this.Label1062.Height = 0.09F;
			this.Label1062.HyperLink = null;
			this.Label1062.Left = 1.94F;
			this.Label1062.Name = "Label1062";
			this.Label1062.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1062.Text = "寡　 婦";
			this.Label1062.Top = 2.598F;
			this.Label1062.Width = 0.3F;
			// 
			// Label1065
			// 
			this.Label1065.Height = 0.21F;
			this.Label1065.HyperLink = null;
			this.Label1065.Left = 2.125F;
			this.Label1065.Name = "Label1065";
			this.Label1065.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1065.Text = "特別";
			this.Label1065.Top = 2.712F;
			this.Label1065.Width = 0.1249999F;
			// 
			// Label1067
			// 
			this.Label1067.Height = 0.165F;
			this.Label1067.HyperLink = null;
			this.Label1067.Left = 2.29F;
			this.Label1067.Name = "Label1067";
			this.Label1067.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.Label1067.Text = "寡";
			this.Label1067.Top = 2.598F;
			this.Label1067.Width = 0.2F;
			// 
			// Label1068
			// 
			this.Label1068.Height = 0.165F;
			this.Label1068.HyperLink = null;
			this.Label1068.Left = 2.29F;
			this.Label1068.Name = "Label1068";
			this.Label1068.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1068.Text = "夫";
			this.Label1068.Top = 2.763F;
			this.Label1068.Width = 0.2F;
			// 
			// Label1069
			// 
			this.Label1069.Height = 0.17F;
			this.Label1069.HyperLink = null;
			this.Label1069.Left = 2.689F;
			this.Label1069.Name = "Label1069";
			this.Label1069.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1069.Text = "就職";
			this.Label1069.Top = 2.758F;
			this.Label1069.Width = 0.2F;
			// 
			// Label1070
			// 
			this.Label1070.Height = 0.17F;
			this.Label1070.HyperLink = null;
			this.Label1070.Left = 3.33F;
			this.Label1070.Name = "Label1070";
			this.Label1070.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1070.Text = "月";
			this.Label1070.Top = 2.758F;
			this.Label1070.Width = 0.192F;
			// 
			// Label1071
			// 
			this.Label1071.Height = 0.17F;
			this.Label1071.HyperLink = null;
			this.Label1071.Left = 3.089F;
			this.Label1071.Name = "Label1071";
			this.Label1071.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1071.Text = "年";
			this.Label1071.Top = 2.758F;
			this.Label1071.Width = 0.241F;
			// 
			// Label1072
			// 
			this.Label1072.Height = 0.17F;
			this.Label1072.HyperLink = null;
			this.Label1072.Left = 3.522F;
			this.Label1072.Name = "Label1072";
			this.Label1072.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1072.Text = "日";
			this.Label1072.Top = 2.758F;
			this.Label1072.Width = 0.228F;
			// 
			// Label1073
			// 
			this.Label1073.Height = 0.16F;
			this.Label1073.HyperLink = null;
			this.Label1073.Left = 3.75F;
			this.Label1073.Name = "Label1073";
			this.Label1073.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1073.Text = "受給者生年月日";
			this.Label1073.Top = 2.598F;
			this.Label1073.Width = 1.625F;
			// 
			// Label1074
			// 
			this.Label1074.Height = 0.17F;
			this.Label1074.HyperLink = null;
			this.Label1074.Left = 3.75F;
			this.Label1074.Name = "Label1074";
			this.Label1074.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1074.Text = "明";
			this.Label1074.Top = 2.758F;
			this.Label1074.Width = 0.194F;
			// 
			// Label1075
			// 
			this.Label1075.Height = 0.17F;
			this.Label1075.HyperLink = null;
			this.Label1075.Left = 4.526F;
			this.Label1075.Name = "Label1075";
			this.Label1075.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1075.Text = "年";
			this.Label1075.Top = 2.758F;
			this.Label1075.Width = 0.283F;
			// 
			// empNameText
			// 
			this.empNameText.CanGrow = false;
			this.empNameText.DataField = "EMP_REGIST_NAME";
			this.empNameText.Height = 0.157F;
			this.empNameText.Left = 3.756082F;
			this.empNameText.Name = "empNameText";
			this.empNameText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameText.Text = "あいうえおかきくけこあいうえお";
			this.empNameText.Top = 0.6667858F;
			this.empNameText.Width = 1.619F;
			// 
			// Label1076
			// 
			this.Label1076.Height = 0.16F;
			this.Label1076.HyperLink = null;
			this.Label1076.Left = 2.689F;
			this.Label1076.Name = "Label1076";
			this.Label1076.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1076.Text = "中途就・退職";
			this.Label1076.Top = 2.598F;
			this.Label1076.Width = 1.061F;
			// 
			// minrTypeText
			// 
			this.minrTypeText.CanGrow = false;
			this.minrTypeText.DataField = "MINR_TYPE";
			this.minrTypeText.Height = 0.17F;
			this.minrTypeText.Left = 0.417F;
			this.minrTypeText.Name = "minrTypeText";
			this.minrTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrTypeText.Text = "0";
			this.minrTypeText.Top = 2.928F;
			this.minrTypeText.Width = 0.2F;
			// 
			// latterText
			// 
			this.latterText.CanGrow = false;
			this.latterText.DataField = "LATTER";
			this.latterText.Height = 0.17F;
			this.latterText.Left = 1.29F;
			this.latterText.Name = "latterText";
			this.latterText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latterText.Text = "0";
			this.latterText.Top = 2.928F;
			this.latterText.Width = 0.2F;
			// 
			// extHandiTypeText
			// 
			this.extHandiTypeText.CanGrow = false;
			this.extHandiTypeText.DataField = "EXT_HANDI_TYPE";
			this.extHandiTypeText.Height = 0.17F;
			this.extHandiTypeText.Left = 1.49F;
			this.extHandiTypeText.Name = "extHandiTypeText";
			this.extHandiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiTypeText.Text = "0";
			this.extHandiTypeText.Top = 2.928F;
			this.extHandiTypeText.Width = 0.2F;
			// 
			// handiTypeText
			// 
			this.handiTypeText.CanGrow = false;
			this.handiTypeText.DataField = "HANDI_TYPE";
			this.handiTypeText.Height = 0.17F;
			this.handiTypeText.Left = 1.69F;
			this.handiTypeText.Name = "handiTypeText";
			this.handiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.handiTypeText.Text = "0";
			this.handiTypeText.Top = 2.928F;
			this.handiTypeText.Width = 0.2F;
			// 
			// widowTypeText
			// 
			this.widowTypeText.CanGrow = false;
			this.widowTypeText.DataField = "WIDOW_TYPE";
			this.widowTypeText.Height = 0.17F;
			this.widowTypeText.Left = 1.89F;
			this.widowTypeText.Name = "widowTypeText";
			this.widowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowTypeText.Text = "0";
			this.widowTypeText.Top = 2.928F;
			this.widowTypeText.Width = 0.2F;
			// 
			// extWidowTypeText
			// 
			this.extWidowTypeText.CanGrow = false;
			this.extWidowTypeText.DataField = "EXT_WIDOW_TYPE";
			this.extWidowTypeText.Height = 0.17F;
			this.extWidowTypeText.Left = 2.09F;
			this.extWidowTypeText.Name = "extWidowTypeText";
			this.extWidowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowTypeText.Text = "0";
			this.extWidowTypeText.Top = 2.928F;
			this.extWidowTypeText.Width = 0.2F;
			// 
			// widomTypeText
			// 
			this.widomTypeText.CanGrow = false;
			this.widomTypeText.DataField = "WIDOM_TYPE";
			this.widomTypeText.Height = 0.17F;
			this.widomTypeText.Left = 2.29F;
			this.widomTypeText.Name = "widomTypeText";
			this.widomTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomTypeText.Text = "0";
			this.widomTypeText.Top = 2.928F;
			this.widomTypeText.Width = 0.2F;
			// 
			// wrkStdTypeText
			// 
			this.wrkStdTypeText.CanGrow = false;
			this.wrkStdTypeText.DataField = "WRK_STD_TYPE";
			this.wrkStdTypeText.Height = 0.17F;
			this.wrkStdTypeText.Left = 2.49F;
			this.wrkStdTypeText.Name = "wrkStdTypeText";
			this.wrkStdTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdTypeText.Text = "0";
			this.wrkStdTypeText.Top = 2.928F;
			this.wrkStdTypeText.Width = 0.2F;
			// 
			// Label1077
			// 
			this.Label1077.Height = 0.166F;
			this.Label1077.HyperLink = null;
			this.Label1077.Left = 0.198F;
			this.Label1077.Name = "Label1077";
			this.Label1077.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1077.Text = "支";
			this.Label1077.Top = 3.109F;
			this.Label1077.Width = 0.21F;
			// 
			// Label1078
			// 
			this.Label1078.Height = 0.166F;
			this.Label1078.HyperLink = null;
			this.Label1078.Left = 0.198F;
			this.Label1078.Name = "Label1078";
			this.Label1078.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1078.Text = "払";
			this.Label1078.Top = 3.272F;
			this.Label1078.Width = 0.21F;
			// 
			// Label1079
			// 
			this.Label1079.Height = 0.166F;
			this.Label1079.HyperLink = null;
			this.Label1079.Left = 0.198F;
			this.Label1079.Name = "Label1079";
			this.Label1079.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1079.Text = "者";
			this.Label1079.Top = 3.438F;
			this.Label1079.Width = 0.21F;
			// 
			// paymntAddressText
			// 
			this.paymntAddressText.CanGrow = false;
			this.paymntAddressText.DataField = "PAYMNT_ADDRESS";
			this.paymntAddressText.Height = 0.332F;
			this.paymntAddressText.Left = 1.07F;
			this.paymntAddressText.Name = "paymntAddressText";
			this.paymntAddressText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddressText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddressText.Top = 3.106F;
			this.paymntAddressText.Width = 4.312F;
			// 
			// paymntNameText
			// 
			this.paymntNameText.CanGrow = false;
			this.paymntNameText.DataField = "PAYMNT_NAME";
			this.paymntNameText.Height = 0.188F;
			this.paymntNameText.Left = 1.063F;
			this.paymntNameText.MultiLine = false;
			this.paymntNameText.Name = "paymntNameText";
			this.paymntNameText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntNameText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntNameText.Top = 3.438F;
			this.paymntNameText.Width = 3.125F;
			// 
			// Label1080
			// 
			this.Label1080.Height = 0.188F;
			this.Label1080.HyperLink = null;
			this.Label1080.Left = 4.188F;
			this.Label1080.Name = "Label1080";
			this.Label1080.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1080.Text = "（電話）";
			this.Label1080.Top = 3.438F;
			this.Label1080.Width = 0.375F;
			// 
			// paymntPhoneText
			// 
			this.paymntPhoneText.CanGrow = false;
			this.paymntPhoneText.DataField = "PAYMNT_PHONE";
			this.paymntPhoneText.Height = 0.188F;
			this.paymntPhoneText.Left = 4.563F;
			this.paymntPhoneText.Name = "paymntPhoneText";
			this.paymntPhoneText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.paymntPhoneText.Text = "99999999999999";
			this.paymntPhoneText.Top = 3.438F;
			this.paymntPhoneText.Width = 0.813F;
			// 
			// Label1081
			// 
			this.Label1081.Height = 0.166F;
			this.Label1081.HyperLink = null;
			this.Label1081.Left = 0.406F;
			this.Label1081.Name = "Label1081";
			this.Label1081.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1081.Text = "住所（居所）";
			this.Label1081.Top = 3.108F;
			this.Label1081.Width = 0.66F;
			// 
			// Label1082
			// 
			this.Label1082.Height = 0.166F;
			this.Label1082.HyperLink = null;
			this.Label1082.Left = 0.406F;
			this.Label1082.Name = "Label1082";
			this.Label1082.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1082.Text = "又は所在地";
			this.Label1082.Top = 3.272F;
			this.Label1082.Width = 0.66F;
			// 
			// Label1084
			// 
			this.Label1084.Height = 0.166F;
			this.Label1084.HyperLink = null;
			this.Label1084.Left = 0.4063315F;
			this.Label1084.Name = "Label1084";
			this.Label1084.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1084.Text = "氏名又は名称";
			this.Label1084.Top = 3.453785F;
			this.Label1084.Width = 0.66F;
			// 
			// Label1085
			// 
			this.Label1085.Height = 0.209F;
			this.Label1085.HyperLink = null;
			this.Label1085.Left = 0.1875815F;
			this.Label1085.Name = "Label1085";
			this.Label1085.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1085.Text = "を受け";
			this.Label1085.Top = 0.4057865F;
			this.Label1085.Width = 0.292F;
			// 
			// Label1086
			// 
			this.Label1086.Height = 0.209F;
			this.Label1086.HyperLink = null;
			this.Label1086.Left = 0.1875815F;
			this.Label1086.Name = "Label1086";
			this.Label1086.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1086.Text = "る者";
			this.Label1086.Top = 0.6147853F;
			this.Label1086.Width = 0.292F;
			// 
			// Label1087
			// 
			this.Label1087.Height = 0.313F;
			this.Label1087.HyperLink = null;
			this.Label1087.Left = 3.017081F;
			this.Label1087.Name = "Label1087";
			this.Label1087.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1087.Text = "名";
			this.Label1087.Top = 0.5107861F;
			this.Label1087.Width = 0.19F;
			// 
			// Label1088
			// 
			this.Label1088.Height = 0.157F;
			this.Label1088.HyperLink = null;
			this.Label1088.Left = 0.1890815F;
			this.Label1088.Name = "Label1088";
			this.Label1088.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.Label1088.Text = "者の有無等";
			this.Label1088.Top = 1.480786F;
			this.Label1088.Width = 0.399F;
			// 
			// Label1089
			// 
			this.Label1089.Height = 0.157F;
			this.Label1089.HyperLink = null;
			this.Label1089.Left = 0.6880816F;
			this.Label1089.Name = "Label1089";
			this.Label1089.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1089.Text = "控除の額";
			this.Label1089.Top = 1.480786F;
			this.Label1089.Width = 0.593F;
			// 
			// Label1090
			// 
			this.Label1090.Height = 0.157F;
			this.Label1090.HyperLink = null;
			this.Label1090.Left = 3.125082F;
			this.Label1090.Name = "Label1090";
			this.Label1090.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1090.Text = "等の金額";
			this.Label1090.Top = 1.479786F;
			this.Label1090.Width = 0.532F;
			// 
			// Label1091
			// 
			this.Label1091.Height = 0.157F;
			this.Label1091.HyperLink = null;
			this.Label1091.Left = 3.656081F;
			this.Label1091.Name = "Label1091";
			this.Label1091.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1091.Text = "の控除額";
			this.Label1091.Top = 1.479786F;
			this.Label1091.Width = 0.563F;
			// 
			// Label1092
			// 
			this.Label1092.Height = 0.157F;
			this.Label1092.HyperLink = null;
			this.Label1092.Left = 4.770082F;
			this.Label1092.Name = "Label1092";
			this.Label1092.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1092.Text = "特別控除の額";
			this.Label1092.Top = 1.479786F;
			this.Label1092.Width = 0.605F;
			// 
			// Label1093
			// 
			this.Label1093.Height = 0.156F;
			this.Label1093.HyperLink = null;
			this.Label1093.Left = 4.219081F;
			this.Label1093.Name = "Label1093";
			this.Label1093.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1093.Text = "損害保険料";
			this.Label1093.Top = 1.323786F;
			this.Label1093.Width = 0.551F;
			// 
			// Label1094
			// 
			this.Label1094.Height = 0.157F;
			this.Label1094.HyperLink = null;
			this.Label1094.Left = 4.219081F;
			this.Label1094.Name = "Label1094";
			this.Label1094.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1094.Text = "の控除額";
			this.Label1094.Top = 1.479786F;
			this.Label1094.Width = 0.551F;
			// 
			// nolfInsDedAmtText
			// 
			this.nolfInsDedAmtText.CanGrow = false;
			this.nolfInsDedAmtText.DataField = "NOLF_INS_DED_AMT";
			this.nolfInsDedAmtText.Height = 0.1875F;
			this.nolfInsDedAmtText.Left = 4.219081F;
			this.nolfInsDedAmtText.Name = "nolfInsDedAmtText";
			this.nolfInsDedAmtText.OutputFormat = "#,##0";
			this.nolfInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsDedAmtText.Top = 1.800286F;
			this.nolfInsDedAmtText.Width = 0.551F;
			// 
			// Label1095
			// 
			this.Label1095.Height = 0.125F;
			this.Label1095.HyperLink = null;
			this.Label1095.Left = 4.659081F;
			this.Label1095.Name = "Label1095";
			this.Label1095.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1095.Text = "円";
			this.Label1095.Top = 1.637786F;
			this.Label1095.Width = 0.1114998F;
			// 
			// deathRetireTypeText
			// 
			this.deathRetireTypeText.CanGrow = false;
			this.deathRetireTypeText.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireTypeText.Height = 0.17F;
			this.deathRetireTypeText.Left = 0.869F;
			this.deathRetireTypeText.Name = "deathRetireTypeText";
			this.deathRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireTypeText.Text = "0";
			this.deathRetireTypeText.Top = 2.928F;
			this.deathRetireTypeText.Width = 0.2F;
			// 
			// disasterTypeText
			// 
			this.disasterTypeText.CanGrow = false;
			this.disasterTypeText.DataField = "DISASTER_TYPE";
			this.disasterTypeText.Height = 0.17F;
			this.disasterTypeText.Left = 1.08F;
			this.disasterTypeText.Name = "disasterTypeText";
			this.disasterTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterTypeText.Text = "0";
			this.disasterTypeText.Top = 2.928F;
			this.disasterTypeText.Width = 0.2F;
			// 
			// Label1113
			// 
			this.Label1113.Height = 0.29F;
			this.Label1113.HyperLink = null;
			this.Label1113.Left = 1.12F;
			this.Label1113.Name = "Label1113";
			this.Label1113.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1113.Text = "災害者";
			this.Label1113.Top = 2.628F;
			this.Label1113.Width = 0.135F;
			// 
			// foreignTypeText
			// 
			this.foreignTypeText.CanGrow = false;
			this.foreignTypeText.DataField = "FOREIGN_TYPE";
			this.foreignTypeText.Height = 0.17F;
			this.foreignTypeText.Left = 0.648F;
			this.foreignTypeText.Name = "foreignTypeText";
			this.foreignTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignTypeText.Text = "0";
			this.foreignTypeText.Top = 2.928F;
			this.foreignTypeText.Width = 0.2F;
			// 
			// Label1116
			// 
			this.Label1116.Height = 0.29F;
			this.Label1116.HyperLink = null;
			this.Label1116.Left = 0.67F;
			this.Label1116.Name = "Label1116";
			this.Label1116.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1116.Text = "外国人";
			this.Label1116.Top = 2.628F;
			this.Label1116.Width = 0.135F;
			// 
			// halfEmployTypeText
			// 
			this.halfEmployTypeText.CanGrow = false;
			this.halfEmployTypeText.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployTypeText.Height = 0.17F;
			this.halfEmployTypeText.Left = 2.689F;
			this.halfEmployTypeText.Name = "halfEmployTypeText";
			this.halfEmployTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployTypeText.Text = "0";
			this.halfEmployTypeText.Top = 2.928F;
			this.halfEmployTypeText.Width = 0.2F;
			// 
			// Label1117
			// 
			this.Label1117.Height = 0.17F;
			this.Label1117.HyperLink = null;
			this.Label1117.Left = 2.889F;
			this.Label1117.Name = "Label1117";
			this.Label1117.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1117.Text = "退職";
			this.Label1117.Top = 2.758F;
			this.Label1117.Width = 0.2F;
			// 
			// halfRetireTypeText
			// 
			this.halfRetireTypeText.CanGrow = false;
			this.halfRetireTypeText.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireTypeText.Height = 0.17F;
			this.halfRetireTypeText.Left = 2.889F;
			this.halfRetireTypeText.Name = "halfRetireTypeText";
			this.halfRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireTypeText.Text = "0";
			this.halfRetireTypeText.Top = 2.928F;
			this.halfRetireTypeText.Width = 0.2F;
			// 
			// halfEmReDateYearText
			// 
			this.halfEmReDateYearText.CanGrow = false;
			this.halfEmReDateYearText.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halfEmReDateYearText.Height = 0.17F;
			this.halfEmReDateYearText.Left = 3.089F;
			this.halfEmReDateYearText.Name = "halfEmReDateYearText";
			this.halfEmReDateYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateYearText.Text = "0";
			this.halfEmReDateYearText.Top = 2.928F;
			this.halfEmReDateYearText.Width = 0.241F;
			// 
			// halfEmReFateMonthText
			// 
			this.halfEmReFateMonthText.CanGrow = false;
			this.halfEmReFateMonthText.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReFateMonthText.Height = 0.17F;
			this.halfEmReFateMonthText.Left = 3.33F;
			this.halfEmReFateMonthText.Name = "halfEmReFateMonthText";
			this.halfEmReFateMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReFateMonthText.Text = "0";
			this.halfEmReFateMonthText.Top = 2.928F;
			this.halfEmReFateMonthText.Width = 0.192F;
			// 
			// halfEmReDateDayText
			// 
			this.halfEmReDateDayText.CanGrow = false;
			this.halfEmReDateDayText.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDayText.Height = 0.17F;
			this.halfEmReDateDayText.Left = 3.5F;
			this.halfEmReDateDayText.Name = "halfEmReDateDayText";
			this.halfEmReDateDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDayText.Text = "0";
			this.halfEmReDateDayText.Top = 2.928F;
			this.halfEmReDateDayText.Width = 0.228F;
			// 
			// Label1118
			// 
			this.Label1118.Height = 0.17F;
			this.Label1118.HyperLink = null;
			this.Label1118.Left = 3.944F;
			this.Label1118.Name = "Label1118";
			this.Label1118.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1118.Text = "大";
			this.Label1118.Top = 2.758F;
			this.Label1118.Width = 0.194F;
			// 
			// Label1119
			// 
			this.Label1119.Height = 0.17F;
			this.Label1119.HyperLink = null;
			this.Label1119.Left = 4.138F;
			this.Label1119.Name = "Label1119";
			this.Label1119.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1119.Text = "昭";
			this.Label1119.Top = 2.758F;
			this.Label1119.Width = 0.194F;
			// 
			// Label1120
			// 
			this.Label1120.Height = 0.17F;
			this.Label1120.HyperLink = null;
			this.Label1120.Left = 4.332F;
			this.Label1120.Name = "Label1120";
			this.Label1120.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1120.Text = "平";
			this.Label1120.Top = 2.758F;
			this.Label1120.Width = 0.194F;
			// 
			// Label1121
			// 
			this.Label1121.Height = 0.17F;
			this.Label1121.HyperLink = null;
			this.Label1121.Left = 4.809F;
			this.Label1121.Name = "Label1121";
			this.Label1121.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1121.Text = "月";
			this.Label1121.Top = 2.758F;
			this.Label1121.Width = 0.283F;
			// 
			// Label1122
			// 
			this.Label1122.Height = 0.17F;
			this.Label1122.HyperLink = null;
			this.Label1122.Left = 5.092F;
			this.Label1122.Name = "Label1122";
			this.Label1122.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1122.Text = "日";
			this.Label1122.Top = 2.758F;
			this.Label1122.Width = 0.283F;
			// 
			// birthNameOfEraMText
			// 
			this.birthNameOfEraMText.CanGrow = false;
			this.birthNameOfEraMText.DataField = "BIRTH_NAME_OF_ERA_M";
			this.birthNameOfEraMText.Height = 0.17F;
			this.birthNameOfEraMText.Left = 3.75F;
			this.birthNameOfEraMText.Name = "birthNameOfEraMText";
			this.birthNameOfEraMText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraMText.Text = "0";
			this.birthNameOfEraMText.Top = 2.928F;
			this.birthNameOfEraMText.Width = 0.194F;
			// 
			// birthNameOfEraTText
			// 
			this.birthNameOfEraTText.CanGrow = false;
			this.birthNameOfEraTText.DataField = "BIRTH_NAME_OF_ERA_T";
			this.birthNameOfEraTText.Height = 0.17F;
			this.birthNameOfEraTText.Left = 3.944F;
			this.birthNameOfEraTText.Name = "birthNameOfEraTText";
			this.birthNameOfEraTText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraTText.Text = "0";
			this.birthNameOfEraTText.Top = 2.928F;
			this.birthNameOfEraTText.Width = 0.194F;
			// 
			// birthNameOfEraSText
			// 
			this.birthNameOfEraSText.CanGrow = false;
			this.birthNameOfEraSText.DataField = "BIRTH_NAME_OF_ERA_S";
			this.birthNameOfEraSText.Height = 0.17F;
			this.birthNameOfEraSText.Left = 4.138F;
			this.birthNameOfEraSText.Name = "birthNameOfEraSText";
			this.birthNameOfEraSText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraSText.Text = "0";
			this.birthNameOfEraSText.Top = 2.928F;
			this.birthNameOfEraSText.Width = 0.194F;
			// 
			// birthNameOfEraHText
			// 
			this.birthNameOfEraHText.CanGrow = false;
			this.birthNameOfEraHText.DataField = "BIRTH_NAME_OF_ERA_H";
			this.birthNameOfEraHText.Height = 0.17F;
			this.birthNameOfEraHText.Left = 4.332F;
			this.birthNameOfEraHText.Name = "birthNameOfEraHText";
			this.birthNameOfEraHText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraHText.Text = "0";
			this.birthNameOfEraHText.Top = 2.928F;
			this.birthNameOfEraHText.Width = 0.194F;
			// 
			// birthDayYearText
			// 
			this.birthDayYearText.CanGrow = false;
			this.birthDayYearText.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYearText.Height = 0.17F;
			this.birthDayYearText.Left = 4.526F;
			this.birthDayYearText.Name = "birthDayYearText";
			this.birthDayYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYearText.Text = "0";
			this.birthDayYearText.Top = 2.928F;
			this.birthDayYearText.Width = 0.283F;
			// 
			// birthDayMonthText
			// 
			this.birthDayMonthText.CanGrow = false;
			this.birthDayMonthText.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonthText.Height = 0.17F;
			this.birthDayMonthText.Left = 4.809F;
			this.birthDayMonthText.Name = "birthDayMonthText";
			this.birthDayMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonthText.Text = "0";
			this.birthDayMonthText.Top = 2.928F;
			this.birthDayMonthText.Width = 0.283F;
			// 
			// birthDayDayText
			// 
			this.birthDayDayText.CanGrow = false;
			this.birthDayDayText.DataField = "BIRTH_DAY_DAY";
			this.birthDayDayText.Height = 0.17F;
			this.birthDayDayText.Left = 5.092F;
			this.birthDayDayText.Name = "birthDayDayText";
			this.birthDayDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDayText.Text = "0";
			this.birthDayDayText.Top = 2.928F;
			this.birthDayDayText.Width = 0.283F;
			// 
			// socInsDedAmtText
			// 
			this.socInsDedAmtText.CanGrow = false;
			this.socInsDedAmtText.DataField = "SOC_INS_DED_AMT";
			this.socInsDedAmtText.Height = 0.158F;
			this.socInsDedAmtText.Left = 3.124082F;
			this.socInsDedAmtText.Name = "socInsDedAmtText";
			this.socInsDedAmtText.OutputFormat = "#,##0";
			this.socInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.socInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.socInsDedAmtText.Top = 1.837787F;
			this.socInsDedAmtText.Width = 0.532F;
			// 
			// Label1123
			// 
			this.Label1123.Height = 0.35F;
			this.Label1123.HyperLink = null;
			this.Label1123.Left = 0.458F;
			this.Label1123.Name = "Label1123";
			this.Label1123.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1123.Text = "未成年者";
			this.Label1123.Top = 2.598F;
			this.Label1123.Width = 0.125F;
			// 
			// Label1129
			// 
			this.Label1129.Height = 0.5F;
			this.Label1129.HyperLink = null;
			this.Label1129.Left = 0.01758147F;
			this.Label1129.Name = "Label1129";
			this.Label1129.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1129.Text = "税務署提出用";
			this.Label1129.Top = 3.072786F;
			this.Label1129.Width = 0.1695F;
			// 
			// Label1130
			// 
			this.Label1130.Angle = 2700;
			this.Label1130.Height = 0.1164999F;
			this.Label1130.HyperLink = null;
			this.Label1130.Left = 0.01808167F;
			this.Label1130.Name = "Label1130";
			this.Label1130.Style = "font-size: 5.5pt; text-align: center; vertical-align: bottom; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1130.Text = "(";
			this.Label1130.Top = 2.976286F;
			this.Label1130.Width = 0.17F;
			// 
			// Label1131
			// 
			this.Label1131.Angle = 900;
			this.Label1131.Height = 0.08F;
			this.Label1131.HyperLink = null;
			this.Label1131.Left = 0.01808167F;
			this.Label1131.Name = "Label1131";
			this.Label1131.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.Label1131.Text = "(";
			this.Label1131.Top = 3.541286F;
			this.Label1131.Width = 0.17F;
			// 
			// Line307
			// 
			this.Line307.Height = 0.155F;
			this.Line307.Left = 0.9380816F;
			this.Line307.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line307.LineWeight = 1F;
			this.Line307.Name = "Line307";
			this.Line307.Top = 3.620286F;
			this.Line307.Width = 0F;
			this.Line307.X1 = 0.9380816F;
			this.Line307.X2 = 0.9380816F;
			this.Line307.Y1 = 3.620286F;
			this.Line307.Y2 = 3.775286F;
			// 
			// Line308
			// 
			this.Line308.Height = 0.155F;
			this.Line308.Left = 1.093082F;
			this.Line308.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line308.LineWeight = 1F;
			this.Line308.Name = "Line308";
			this.Line308.Top = 3.620286F;
			this.Line308.Width = 0F;
			this.Line308.X1 = 1.093082F;
			this.Line308.X2 = 1.093082F;
			this.Line308.Y1 = 3.620286F;
			this.Line308.Y2 = 3.775286F;
			// 
			// Line309
			// 
			this.Line309.Height = 0.155F;
			this.Line309.Left = 1.248082F;
			this.Line309.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line309.LineWeight = 1F;
			this.Line309.Name = "Line309";
			this.Line309.Top = 3.620286F;
			this.Line309.Width = 0F;
			this.Line309.X1 = 1.248082F;
			this.Line309.X2 = 1.248082F;
			this.Line309.Y1 = 3.620286F;
			this.Line309.Y2 = 3.775286F;
			// 
			// Line310
			// 
			this.Line310.Height = 0.155F;
			this.Line310.Left = 1.403082F;
			this.Line310.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line310.LineWeight = 1F;
			this.Line310.Name = "Line310";
			this.Line310.Top = 3.620286F;
			this.Line310.Width = 0F;
			this.Line310.X1 = 1.403082F;
			this.Line310.X2 = 1.403082F;
			this.Line310.Y1 = 3.620286F;
			this.Line310.Y2 = 3.775286F;
			// 
			// Line311
			// 
			this.Line311.Height = 0.155F;
			this.Line311.Left = 1.558082F;
			this.Line311.LineWeight = 1F;
			this.Line311.Name = "Line311";
			this.Line311.Top = 3.620286F;
			this.Line311.Width = 0F;
			this.Line311.X1 = 1.558082F;
			this.Line311.X2 = 1.558082F;
			this.Line311.Y1 = 3.620286F;
			this.Line311.Y2 = 3.775286F;
			// 
			// Line312
			// 
			this.Line312.Height = 0.155F;
			this.Line312.Left = 0.7810816F;
			this.Line312.LineWeight = 1F;
			this.Line312.Name = "Line312";
			this.Line312.Top = 3.620286F;
			this.Line312.Width = 0F;
			this.Line312.X1 = 0.7810816F;
			this.Line312.X2 = 0.7810816F;
			this.Line312.Y1 = 3.620286F;
			this.Line312.Y2 = 3.775286F;
			// 
			// Label1134
			// 
			this.Label1134.Height = 0.155F;
			this.Label1134.HyperLink = null;
			this.Label1134.Left = 1.558082F;
			this.Label1134.Name = "Label1134";
			this.Label1134.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1134.Text = "整　理　番　号";
			this.Label1134.Top = 3.620286F;
			this.Label1134.Width = 0.724F;
			// 
			// Line314
			// 
			this.Line314.Height = 0.155F;
			this.Line314.Left = 2.437082F;
			this.Line314.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line314.LineWeight = 1F;
			this.Line314.Name = "Line314";
			this.Line314.Top = 3.620286F;
			this.Line314.Width = 0F;
			this.Line314.X1 = 2.437082F;
			this.Line314.X2 = 2.437082F;
			this.Line314.Y1 = 3.620286F;
			this.Line314.Y2 = 3.775286F;
			// 
			// Line315
			// 
			this.Line315.Height = 0.155F;
			this.Line315.Left = 2.592082F;
			this.Line315.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line315.LineWeight = 1F;
			this.Line315.Name = "Line315";
			this.Line315.Top = 3.620286F;
			this.Line315.Width = 0F;
			this.Line315.X1 = 2.592082F;
			this.Line315.X2 = 2.592082F;
			this.Line315.Y1 = 3.620286F;
			this.Line315.Y2 = 3.775286F;
			// 
			// Line316
			// 
			this.Line316.Height = 0.155F;
			this.Line316.Left = 2.747082F;
			this.Line316.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line316.LineWeight = 1F;
			this.Line316.Name = "Line316";
			this.Line316.Top = 3.620286F;
			this.Line316.Width = 0F;
			this.Line316.X1 = 2.747082F;
			this.Line316.X2 = 2.747082F;
			this.Line316.Y1 = 3.620286F;
			this.Line316.Y2 = 3.775286F;
			// 
			// Line317
			// 
			this.Line317.Height = 0.155F;
			this.Line317.Left = 2.902081F;
			this.Line317.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line317.LineWeight = 1F;
			this.Line317.Name = "Line317";
			this.Line317.Top = 3.620286F;
			this.Line317.Width = 0F;
			this.Line317.X1 = 2.902081F;
			this.Line317.X2 = 2.902081F;
			this.Line317.Y1 = 3.620286F;
			this.Line317.Y2 = 3.775286F;
			// 
			// Line318
			// 
			this.Line318.Height = 0.155F;
			this.Line318.Left = 2.282082F;
			this.Line318.LineWeight = 1F;
			this.Line318.Name = "Line318";
			this.Line318.Top = 3.620286F;
			this.Line318.Width = 0F;
			this.Line318.X1 = 2.282082F;
			this.Line318.X2 = 2.282082F;
			this.Line318.Y1 = 3.620286F;
			this.Line318.Y2 = 3.775286F;
			// 
			// Line319
			// 
			this.Line319.Height = 0.155F;
			this.Line319.Left = 3.057081F;
			this.Line319.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line319.LineWeight = 1F;
			this.Line319.Name = "Line319";
			this.Line319.Top = 3.620286F;
			this.Line319.Width = 0F;
			this.Line319.X1 = 3.057081F;
			this.Line319.X2 = 3.057081F;
			this.Line319.Y1 = 3.620286F;
			this.Line319.Y2 = 3.775286F;
			// 
			// Line320
			// 
			this.Line320.Height = 0.155F;
			this.Line320.Left = 3.212081F;
			this.Line320.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line320.LineWeight = 1F;
			this.Line320.Name = "Line320";
			this.Line320.Top = 3.620286F;
			this.Line320.Width = 0F;
			this.Line320.X1 = 3.212081F;
			this.Line320.X2 = 3.212081F;
			this.Line320.Y1 = 3.620286F;
			this.Line320.Y2 = 3.775286F;
			// 
			// Line321
			// 
			this.Line321.Height = 0.155F;
			this.Line321.Left = 3.367082F;
			this.Line321.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line321.LineWeight = 1F;
			this.Line321.Name = "Line321";
			this.Line321.Top = 3.620286F;
			this.Line321.Width = 0F;
			this.Line321.X1 = 3.367082F;
			this.Line321.X2 = 3.367082F;
			this.Line321.Y1 = 3.620286F;
			this.Line321.Y2 = 3.775286F;
			// 
			// Line322
			// 
			this.Line322.Height = 0.155F;
			this.Line322.Left = 3.522082F;
			this.Line322.LineWeight = 1F;
			this.Line322.Name = "Line322";
			this.Line322.Top = 3.620286F;
			this.Line322.Width = 0F;
			this.Line322.X1 = 3.522082F;
			this.Line322.X2 = 3.522082F;
			this.Line322.Y1 = 3.620286F;
			this.Line322.Y2 = 3.775286F;
			// 
			// Line323
			// 
			this.Line323.Height = 0F;
			this.Line323.Left = 0.1880815F;
			this.Line323.LineWeight = 1F;
			this.Line323.Name = "Line323";
			this.Line323.Top = 3.620286F;
			this.Line323.Width = 5.187F;
			this.Line323.X1 = 0.1880815F;
			this.Line323.X2 = 5.375082F;
			this.Line323.Y1 = 3.620286F;
			this.Line323.Y2 = 3.620286F;
			// 
			// YlyEdCalYear3Text
			// 
			this.YlyEdCalYear3Text.CanGrow = false;
			this.YlyEdCalYear3Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear3Text.Height = 0.125F;
			this.YlyEdCalYear3Text.Left = 1.730082F;
			this.YlyEdCalYear3Text.Name = "YlyEdCalYear3Text";
			this.YlyEdCalYear3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.YlyEdCalYear3Text.Text = "0000";
			this.YlyEdCalYear3Text.Top = 0.05128586F;
			this.YlyEdCalYear3Text.Visible = false;
			this.YlyEdCalYear3Text.Width = 0.4375F;
			// 
			// Line324
			// 
			this.Line324.Height = 0F;
			this.Line324.Left = 0.1880815F;
			this.Line324.LineWeight = 1F;
			this.Line324.Name = "Line324";
			this.Line324.Top = 0.1982861F;
			this.Line324.Width = 5.187F;
			this.Line324.X1 = 0.1880815F;
			this.Line324.X2 = 5.375082F;
			this.Line324.Y1 = 0.1982861F;
			this.Line324.Y2 = 0.1982861F;
			// 
			// Line325
			// 
			this.Line325.Height = 0F;
			this.Line325.Left = 0.1880815F;
			this.Line325.LineWeight = 1F;
			this.Line325.Name = "Line325";
			this.Line325.Top = 0.8232859F;
			this.Line325.Width = 5.187F;
			this.Line325.X1 = 0.1880815F;
			this.Line325.X2 = 5.375082F;
			this.Line325.Y1 = 0.8232859F;
			this.Line325.Y2 = 0.8232859F;
			// 
			// Line326
			// 
			this.Line326.Height = 0F;
			this.Line326.Left = 0.1880815F;
			this.Line326.LineWeight = 1F;
			this.Line326.Name = "Line326";
			this.Line326.Top = 1.324286F;
			this.Line326.Width = 5.187F;
			this.Line326.X1 = 0.1880815F;
			this.Line326.X2 = 5.375082F;
			this.Line326.Y1 = 1.324286F;
			this.Line326.Y2 = 1.324286F;
			// 
			// Line327
			// 
			this.Line327.Height = 0F;
			this.Line327.Left = 0.1880815F;
			this.Line327.LineWeight = 1F;
			this.Line327.Name = "Line327";
			this.Line327.Top = 1.638286F;
			this.Line327.Width = 5.187F;
			this.Line327.X1 = 0.1880815F;
			this.Line327.X2 = 5.375082F;
			this.Line327.Y1 = 1.638286F;
			this.Line327.Y2 = 1.638286F;
			// 
			// Line328
			// 
			this.Line328.Height = 0F;
			this.Line328.Left = 0.1880815F;
			this.Line328.LineWeight = 1F;
			this.Line328.Name = "Line328";
			this.Line328.Top = 2.6F;
			this.Line328.Width = 5.187F;
			this.Line328.X1 = 0.1880815F;
			this.Line328.X2 = 5.375082F;
			this.Line328.Y1 = 2.6F;
			this.Line328.Y2 = 2.6F;
			// 
			// Line129
			// 
			this.Line129.Height = 3.422F;
			this.Line129.Left = 5.375082F;
			this.Line129.LineWeight = 1F;
			this.Line129.Name = "Line129";
			this.Line129.Top = 0.1982858F;
			this.Line129.Width = 0F;
			this.Line129.X1 = 5.375082F;
			this.Line129.X2 = 5.375082F;
			this.Line129.Y1 = 0.1982858F;
			this.Line129.Y2 = 3.620286F;
			// 
			// Line332
			// 
			this.Line332.Height = 3.422F;
			this.Line332.Left = 5.375082F;
			this.Line332.LineWeight = 1F;
			this.Line332.Name = "Line332";
			this.Line332.Top = 4.302453F;
			this.Line332.Width = 0F;
			this.Line332.X1 = 5.375082F;
			this.Line332.X2 = 5.375082F;
			this.Line332.Y1 = 4.302453F;
			this.Line332.Y2 = 7.724453F;
			// 
			// Line333
			// 
			this.Line333.Height = 0.625F;
			this.Line333.Left = 0.4800815F;
			this.Line333.LineWeight = 1F;
			this.Line333.Name = "Line333";
			this.Line333.Top = 4.302453F;
			this.Line333.Width = 0F;
			this.Line333.X1 = 0.4800815F;
			this.Line333.X2 = 0.4800815F;
			this.Line333.Y1 = 4.302453F;
			this.Line333.Y2 = 4.927453F;
			// 
			// Line334
			// 
			this.Line334.Height = 0.625F;
			this.Line334.Left = 0.6680815F;
			this.Line334.LineWeight = 1F;
			this.Line334.Name = "Line334";
			this.Line334.Top = 4.302453F;
			this.Line334.Width = 0F;
			this.Line334.X1 = 0.6680815F;
			this.Line334.X2 = 0.6680815F;
			this.Line334.Y1 = 4.302453F;
			this.Line334.Y2 = 4.927453F;
			// 
			// Line335
			// 
			this.Line335.Height = 0.625F;
			this.Line335.Left = 3.017081F;
			this.Line335.LineWeight = 1F;
			this.Line335.Name = "Line335";
			this.Line335.Top = 4.302453F;
			this.Line335.Width = 0F;
			this.Line335.X1 = 3.017081F;
			this.Line335.X2 = 3.017081F;
			this.Line335.Y1 = 4.302453F;
			this.Line335.Y2 = 4.927453F;
			// 
			// Line336
			// 
			this.Line336.Height = 0.625F;
			this.Line336.Left = 3.207082F;
			this.Line336.LineWeight = 1F;
			this.Line336.Name = "Line336";
			this.Line336.Top = 4.302453F;
			this.Line336.Width = 0F;
			this.Line336.X1 = 3.207082F;
			this.Line336.X2 = 3.207082F;
			this.Line336.Y1 = 4.302453F;
			this.Line336.Y2 = 4.927453F;
			// 
			// Line337
			// 
			this.Line337.Height = 0F;
			this.Line337.Left = 3.207082F;
			this.Line337.LineWeight = 1F;
			this.Line337.Name = "Line337";
			this.Line337.Top = 4.614453F;
			this.Line337.Width = 2.168F;
			this.Line337.X1 = 3.207082F;
			this.Line337.X2 = 5.375082F;
			this.Line337.Y1 = 4.614453F;
			this.Line337.Y2 = 4.614453F;
			// 
			// Line338
			// 
			this.Line338.Height = 0F;
			this.Line338.Left = 0.1880815F;
			this.Line338.LineWeight = 1F;
			this.Line338.Name = "Line338";
			this.Line338.Top = 5.100453F;
			this.Line338.Width = 5.187F;
			this.Line338.X1 = 0.1880815F;
			this.Line338.X2 = 5.375082F;
			this.Line338.Y1 = 5.100453F;
			this.Line338.Y2 = 5.100453F;
			// 
			// Line339
			// 
			this.Line339.Height = 0.5009999F;
			this.Line339.Left = 1.126082F;
			this.Line339.LineWeight = 1F;
			this.Line339.Name = "Line339";
			this.Line339.Top = 4.927453F;
			this.Line339.Width = 0F;
			this.Line339.X1 = 1.126082F;
			this.Line339.X2 = 1.126082F;
			this.Line339.Y1 = 4.927453F;
			this.Line339.Y2 = 5.428453F;
			// 
			// Line340
			// 
			this.Line340.Height = 0.5009999F;
			this.Line340.Left = 2.204082F;
			this.Line340.LineWeight = 1F;
			this.Line340.Name = "Line340";
			this.Line340.Top = 4.927453F;
			this.Line340.Width = 0F;
			this.Line340.X1 = 2.204082F;
			this.Line340.X2 = 2.204082F;
			this.Line340.Y1 = 4.927453F;
			this.Line340.Y2 = 5.428453F;
			// 
			// Line341
			// 
			this.Line341.Height = 0.5009999F;
			this.Line341.Left = 3.267081F;
			this.Line341.LineWeight = 1F;
			this.Line341.Name = "Line341";
			this.Line341.Top = 4.927453F;
			this.Line341.Width = 0F;
			this.Line341.X1 = 3.267081F;
			this.Line341.X2 = 3.267081F;
			this.Line341.Y1 = 4.927453F;
			this.Line341.Y2 = 5.428453F;
			// 
			// Line342
			// 
			this.Line342.Height = 0.5009999F;
			this.Line342.Left = 4.330081F;
			this.Line342.LineWeight = 1F;
			this.Line342.Name = "Line342";
			this.Line342.Top = 4.927453F;
			this.Line342.Width = 0F;
			this.Line342.X1 = 4.330081F;
			this.Line342.X2 = 4.330081F;
			this.Line342.Y1 = 4.927453F;
			this.Line342.Y2 = 5.428453F;
			// 
			// Line343
			// 
			this.Line343.Height = 0.6570001F;
			this.Line343.Left = 0.6890815F;
			this.Line343.LineWeight = 1F;
			this.Line343.Name = "Line343";
			this.Line343.Top = 5.428453F;
			this.Line343.Width = 0F;
			this.Line343.X1 = 0.6890815F;
			this.Line343.X2 = 0.6890815F;
			this.Line343.Y1 = 5.428453F;
			this.Line343.Y2 = 6.085453F;
			// 
			// Line344
			// 
			this.Line344.Height = 0.6570001F;
			this.Line344.Left = 1.282081F;
			this.Line344.LineWeight = 1F;
			this.Line344.Name = "Line344";
			this.Line344.Top = 5.428453F;
			this.Line344.Width = 0F;
			this.Line344.X1 = 1.282081F;
			this.Line344.X2 = 1.282081F;
			this.Line344.Y1 = 5.428453F;
			this.Line344.Y2 = 6.085453F;
			// 
			// Line345
			// 
			this.Line345.Height = 0.6570001F;
			this.Line345.Left = 2.599082F;
			this.Line345.LineWeight = 1F;
			this.Line345.Name = "Line345";
			this.Line345.Top = 5.428453F;
			this.Line345.Width = 0F;
			this.Line345.X1 = 2.599082F;
			this.Line345.X2 = 2.599082F;
			this.Line345.Y1 = 5.428453F;
			this.Line345.Y2 = 6.085453F;
			// 
			// Line346
			// 
			this.Line346.Height = 0.6570001F;
			this.Line346.Left = 3.124082F;
			this.Line346.LineWeight = 1F;
			this.Line346.Name = "Line346";
			this.Line346.Top = 5.428453F;
			this.Line346.Width = 0F;
			this.Line346.X1 = 3.124082F;
			this.Line346.X2 = 3.124082F;
			this.Line346.Y1 = 5.428453F;
			this.Line346.Y2 = 6.085453F;
			// 
			// Line347
			// 
			this.Line347.Height = 0.6570001F;
			this.Line347.Left = 3.656081F;
			this.Line347.LineWeight = 1F;
			this.Line347.Name = "Line347";
			this.Line347.Top = 5.428453F;
			this.Line347.Width = 0F;
			this.Line347.X1 = 3.656081F;
			this.Line347.X2 = 3.656081F;
			this.Line347.Y1 = 5.428453F;
			this.Line347.Y2 = 6.085453F;
			// 
			// Line348
			// 
			this.Line348.Height = 0.6570001F;
			this.Line348.Left = 4.219081F;
			this.Line348.LineWeight = 1F;
			this.Line348.Name = "Line348";
			this.Line348.Top = 5.428453F;
			this.Line348.Width = 0F;
			this.Line348.X1 = 4.219081F;
			this.Line348.X2 = 4.219081F;
			this.Line348.Y1 = 5.428453F;
			this.Line348.Y2 = 6.085453F;
			// 
			// Line349
			// 
			this.Line349.Height = 0.6570001F;
			this.Line349.Left = 4.770082F;
			this.Line349.LineWeight = 1F;
			this.Line349.Name = "Line349";
			this.Line349.Top = 5.428453F;
			this.Line349.Width = 0F;
			this.Line349.X1 = 4.770082F;
			this.Line349.X2 = 4.770082F;
			this.Line349.Y1 = 5.428453F;
			this.Line349.Y2 = 6.085453F;
			// 
			// Line350
			// 
			this.Line350.Height = 0F;
			this.Line350.Left = 1.282081F;
			this.Line350.LineWeight = 1F;
			this.Line350.Name = "Line350";
			this.Line350.Top = 5.636453F;
			this.Line350.Width = 1.843001F;
			this.Line350.X1 = 1.282081F;
			this.Line350.X2 = 3.125082F;
			this.Line350.Y1 = 5.636453F;
			this.Line350.Y2 = 5.636453F;
			// 
			// Line351
			// 
			this.Line351.Height = 0F;
			this.Line351.Left = 0.1880815F;
			this.Line351.LineWeight = 1F;
			this.Line351.Name = "Line351";
			this.Line351.Top = 6.085453F;
			this.Line351.Width = 5.187F;
			this.Line351.X1 = 0.1880815F;
			this.Line351.X2 = 5.375082F;
			this.Line351.Y1 = 6.085453F;
			this.Line351.Y2 = 6.085453F;
			// 
			// Line352
			// 
			this.Line352.Height = 0F;
			this.Line352.Left = 0.4100815F;
			this.Line352.LineWeight = 1F;
			this.Line352.Name = "Line352";
			this.Line352.Top = 7.54F;
			this.Line352.Width = 4.964919F;
			this.Line352.X1 = 0.4100815F;
			this.Line352.X2 = 5.375F;
			this.Line352.Y1 = 7.54F;
			this.Line352.Y2 = 7.54F;
			// 
			// Line353
			// 
			this.Line353.Height = 0.5100002F;
			this.Line353.Left = 3.750082F;
			this.Line353.LineWeight = 1F;
			this.Line353.Name = "Line353";
			this.Line353.Top = 6.7F;
			this.Line353.Width = 0F;
			this.Line353.X1 = 3.750082F;
			this.Line353.X2 = 3.750082F;
			this.Line353.Y1 = 6.7F;
			this.Line353.Y2 = 7.21F;
			// 
			// Line354
			// 
			this.Line354.Height = 0.6145468F;
			this.Line354.Left = 4.62F;
			this.Line354.LineWeight = 1F;
			this.Line354.Name = "Line354";
			this.Line354.Top = 6.085453F;
			this.Line354.Width = 0F;
			this.Line354.X1 = 4.62F;
			this.Line354.X2 = 4.62F;
			this.Line354.Y1 = 6.085453F;
			this.Line354.Y2 = 6.7F;
			// 
			// Line367
			// 
			this.Line367.Height = 0.5100002F;
			this.Line367.Left = 2.689081F;
			this.Line367.LineWeight = 1F;
			this.Line367.Name = "Line367";
			this.Line367.Top = 6.7F;
			this.Line367.Width = 0F;
			this.Line367.X1 = 2.689081F;
			this.Line367.X2 = 2.689081F;
			this.Line367.Y1 = 6.7F;
			this.Line367.Y2 = 7.21F;
			// 
			// Line370
			// 
			this.Line370.Height = 0F;
			this.Line370.Left = 2.69F;
			this.Line370.LineWeight = 1F;
			this.Line370.Name = "Line370";
			this.Line370.Top = 6.86F;
			this.Line370.Width = 2.685F;
			this.Line370.X1 = 2.69F;
			this.Line370.X2 = 5.375F;
			this.Line370.Y1 = 6.86F;
			this.Line370.Y2 = 6.86F;
			// 
			// Line371
			// 
			this.Line371.Height = 0.3499999F;
			this.Line371.Left = 2.89F;
			this.Line371.LineWeight = 1F;
			this.Line371.Name = "Line371";
			this.Line371.Top = 6.86F;
			this.Line371.Width = 0F;
			this.Line371.X1 = 2.89F;
			this.Line371.X2 = 2.89F;
			this.Line371.Y1 = 6.86F;
			this.Line371.Y2 = 7.21F;
			// 
			// Line372
			// 
			this.Line372.Height = 0.3499999F;
			this.Line372.Left = 3.09F;
			this.Line372.LineWeight = 1F;
			this.Line372.Name = "Line372";
			this.Line372.Top = 6.86F;
			this.Line372.Width = 0F;
			this.Line372.X1 = 3.09F;
			this.Line372.X2 = 3.09F;
			this.Line372.Y1 = 6.86F;
			this.Line372.Y2 = 7.21F;
			// 
			// Line373
			// 
			this.Line373.Height = 0.3499999F;
			this.Line373.Left = 3.330081F;
			this.Line373.LineWeight = 1F;
			this.Line373.Name = "Line373";
			this.Line373.Top = 6.86F;
			this.Line373.Width = 0F;
			this.Line373.X1 = 3.330081F;
			this.Line373.X2 = 3.330081F;
			this.Line373.Y1 = 6.86F;
			this.Line373.Y2 = 7.21F;
			// 
			// Line374
			// 
			this.Line374.Height = 0.3499999F;
			this.Line374.Left = 3.522082F;
			this.Line374.LineWeight = 1F;
			this.Line374.Name = "Line374";
			this.Line374.Top = 6.86F;
			this.Line374.Width = 0F;
			this.Line374.X1 = 3.522082F;
			this.Line374.X2 = 3.522082F;
			this.Line374.Y1 = 6.86F;
			this.Line374.Y2 = 7.21F;
			// 
			// Line375
			// 
			this.Line375.Height = 0.3499999F;
			this.Line375.Left = 3.94F;
			this.Line375.LineWeight = 1F;
			this.Line375.Name = "Line375";
			this.Line375.Top = 6.86F;
			this.Line375.Width = 0F;
			this.Line375.X1 = 3.94F;
			this.Line375.X2 = 3.94F;
			this.Line375.Y1 = 6.86F;
			this.Line375.Y2 = 7.21F;
			// 
			// Line376
			// 
			this.Line376.Height = 0.3499999F;
			this.Line376.Left = 4.14F;
			this.Line376.LineWeight = 1F;
			this.Line376.Name = "Line376";
			this.Line376.Top = 6.86F;
			this.Line376.Width = 0F;
			this.Line376.X1 = 4.14F;
			this.Line376.X2 = 4.14F;
			this.Line376.Y1 = 6.86F;
			this.Line376.Y2 = 7.21F;
			// 
			// Line377
			// 
			this.Line377.Height = 0.3499999F;
			this.Line377.Left = 4.33F;
			this.Line377.LineWeight = 1F;
			this.Line377.Name = "Line377";
			this.Line377.Top = 6.86F;
			this.Line377.Width = 0F;
			this.Line377.X1 = 4.33F;
			this.Line377.X2 = 4.33F;
			this.Line377.Y1 = 6.86F;
			this.Line377.Y2 = 7.21F;
			// 
			// Line378
			// 
			this.Line378.Height = 0.3499999F;
			this.Line378.Left = 4.53F;
			this.Line378.LineWeight = 1F;
			this.Line378.Name = "Line378";
			this.Line378.Top = 6.86F;
			this.Line378.Width = 0F;
			this.Line378.X1 = 4.53F;
			this.Line378.X2 = 4.53F;
			this.Line378.Y1 = 6.86F;
			this.Line378.Y2 = 7.21F;
			// 
			// Line379
			// 
			this.Line379.Height = 0.3499999F;
			this.Line379.Left = 4.81F;
			this.Line379.LineWeight = 1F;
			this.Line379.Name = "Line379";
			this.Line379.Top = 6.86F;
			this.Line379.Width = 0F;
			this.Line379.X1 = 4.81F;
			this.Line379.X2 = 4.81F;
			this.Line379.Y1 = 6.86F;
			this.Line379.Y2 = 7.21F;
			// 
			// Line380
			// 
			this.Line380.Height = 0.3499999F;
			this.Line380.Left = 5.09F;
			this.Line380.LineWeight = 1F;
			this.Line380.Name = "Line380";
			this.Line380.Top = 6.86F;
			this.Line380.Width = 0F;
			this.Line380.X1 = 5.09F;
			this.Line380.X2 = 5.09F;
			this.Line380.Y1 = 6.86F;
			this.Line380.Y2 = 7.21F;
			// 
			// Line381
			// 
			this.Line381.Height = 0.3430009F;
			this.Line381.Left = 1.470082F;
			this.Line381.LineWeight = 1F;
			this.Line381.Name = "Line381";
			this.Line381.Top = 5.742452F;
			this.Line381.Width = 0F;
			this.Line381.X1 = 1.470082F;
			this.Line381.X2 = 1.470082F;
			this.Line381.Y1 = 5.742452F;
			this.Line381.Y2 = 6.085453F;
			// 
			// Line382
			// 
			this.Line382.Height = 0.4489999F;
			this.Line382.Left = 2.215081F;
			this.Line382.LineWeight = 1F;
			this.Line382.Name = "Line382";
			this.Line382.Top = 5.636453F;
			this.Line382.Width = 0F;
			this.Line382.X1 = 2.215081F;
			this.Line382.X2 = 2.215081F;
			this.Line382.Y1 = 5.636453F;
			this.Line382.Y2 = 6.085453F;
			// 
			// Line383
			// 
			this.Line383.Height = 0.3430009F;
			this.Line383.Left = 1.997082F;
			this.Line383.LineWeight = 1F;
			this.Line383.Name = "Line383";
			this.Line383.Top = 5.742452F;
			this.Line383.Width = 0F;
			this.Line383.X1 = 1.997082F;
			this.Line383.X2 = 1.997082F;
			this.Line383.Y1 = 5.742452F;
			this.Line383.Y2 = 6.085453F;
			// 
			// Line384
			// 
			this.Line384.Height = 0.3430009F;
			this.Line384.Left = 2.407082F;
			this.Line384.LineWeight = 1F;
			this.Line384.Name = "Line384";
			this.Line384.Top = 5.742452F;
			this.Line384.Width = 0F;
			this.Line384.X1 = 2.407082F;
			this.Line384.X2 = 2.407082F;
			this.Line384.Y1 = 5.742452F;
			this.Line384.Y2 = 6.085453F;
			// 
			// Line385
			// 
			this.Line385.Height = 0.2460012F;
			this.Line385.Left = 1.778082F;
			this.Line385.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line385.LineWeight = 1F;
			this.Line385.Name = "Line385";
			this.Line385.Top = 5.839452F;
			this.Line385.Width = 0F;
			this.Line385.X1 = 1.778082F;
			this.Line385.X2 = 1.778082F;
			this.Line385.Y1 = 5.839452F;
			this.Line385.Y2 = 6.085453F;
			// 
			// Line386
			// 
			this.Line386.Height = 0.2460012F;
			this.Line386.Left = 2.724082F;
			this.Line386.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line386.LineWeight = 1F;
			this.Line386.Name = "Line386";
			this.Line386.Top = 5.839452F;
			this.Line386.Width = 0F;
			this.Line386.X1 = 2.724082F;
			this.Line386.X2 = 2.724082F;
			this.Line386.Y1 = 5.839452F;
			this.Line386.Y2 = 6.085453F;
			// 
			// Line387
			// 
			this.Line387.Height = 0.4489999F;
			this.Line387.Left = 2.849082F;
			this.Line387.LineWeight = 1F;
			this.Line387.Name = "Line387";
			this.Line387.Top = 5.636453F;
			this.Line387.Width = 0F;
			this.Line387.X1 = 2.849082F;
			this.Line387.X2 = 2.849082F;
			this.Line387.Y1 = 5.636453F;
			this.Line387.Y2 = 6.085453F;
			// 
			// Line388
			// 
			this.Line388.Height = 0.4489999F;
			this.Line388.Left = 1.668082F;
			this.Line388.LineWeight = 1F;
			this.Line388.Name = "Line388";
			this.Line388.Top = 5.636453F;
			this.Line388.Width = 0F;
			this.Line388.X1 = 1.668082F;
			this.Line388.X2 = 1.668082F;
			this.Line388.Y1 = 5.636453F;
			this.Line388.Y2 = 6.085453F;
			// 
			// Line389
			// 
			this.Line389.Height = 0.3430009F;
			this.Line389.Left = 0.2880815F;
			this.Line389.LineWeight = 1F;
			this.Line389.Name = "Line389";
			this.Line389.Top = 5.742452F;
			this.Line389.Width = 0F;
			this.Line389.X1 = 0.2880815F;
			this.Line389.X2 = 0.2880815F;
			this.Line389.Y1 = 5.742452F;
			this.Line389.Y2 = 6.085453F;
			// 
			// Line390
			// 
			this.Line390.Height = 0.3430009F;
			this.Line390.Left = 0.3880816F;
			this.Line390.LineWeight = 1F;
			this.Line390.Name = "Line390";
			this.Line390.Top = 5.742452F;
			this.Line390.Width = 0F;
			this.Line390.X1 = 0.3880816F;
			this.Line390.X2 = 0.3880816F;
			this.Line390.Y1 = 5.742452F;
			this.Line390.Y2 = 6.085453F;
			// 
			// Line391
			// 
			this.Line391.Height = 0.3430009F;
			this.Line391.Left = 0.4880815F;
			this.Line391.LineWeight = 1F;
			this.Line391.Name = "Line391";
			this.Line391.Top = 5.742452F;
			this.Line391.Width = 0F;
			this.Line391.X1 = 0.4880815F;
			this.Line391.X2 = 0.4880815F;
			this.Line391.Y1 = 5.742452F;
			this.Line391.Y2 = 6.085453F;
			// 
			// Line392
			// 
			this.Line392.Height = 0.5160012F;
			this.Line392.Left = 0.5880815F;
			this.Line392.LineWeight = 1F;
			this.Line392.Name = "Line392";
			this.Line392.Top = 5.569452F;
			this.Line392.Width = 0F;
			this.Line392.X1 = 0.5880815F;
			this.Line392.X2 = 0.5880815F;
			this.Line392.Y1 = 5.569452F;
			this.Line392.Y2 = 6.085453F;
			// 
			// Line393
			// 
			this.Line393.Height = 0F;
			this.Line393.Left = 0.5880815F;
			this.Line393.LineWeight = 1F;
			this.Line393.Name = "Line393";
			this.Line393.Top = 5.569452F;
			this.Line393.Width = 0.1000001F;
			this.Line393.X1 = 0.5880815F;
			this.Line393.X2 = 0.6880816F;
			this.Line393.Y1 = 5.569452F;
			this.Line393.Y2 = 5.569452F;
			// 
			// Line394
			// 
			this.Line394.Height = 0F;
			this.Line394.Left = 3.207082F;
			this.Line394.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line394.LineWeight = 1F;
			this.Line394.Name = "Line394";
			this.Line394.Top = 4.458452F;
			this.Line394.Width = 2.168F;
			this.Line394.X1 = 3.207082F;
			this.Line394.X2 = 5.375082F;
			this.Line394.Y1 = 4.458452F;
			this.Line394.Y2 = 4.458452F;
			// 
			// Line395
			// 
			this.Line395.Height = 0.6249998F;
			this.Line395.Left = 0.4800815F;
			this.Line395.LineWeight = 1F;
			this.Line395.Name = "Line395";
			this.Line395.Top = 0.1982861F;
			this.Line395.Width = 0F;
			this.Line395.X1 = 0.4800815F;
			this.Line395.X2 = 0.4800815F;
			this.Line395.Y1 = 0.1982861F;
			this.Line395.Y2 = 0.8232859F;
			// 
			// Line396
			// 
			this.Line396.Height = 0.6249998F;
			this.Line396.Left = 0.6680815F;
			this.Line396.LineWeight = 1F;
			this.Line396.Name = "Line396";
			this.Line396.Top = 0.1982861F;
			this.Line396.Width = 0F;
			this.Line396.X1 = 0.6680815F;
			this.Line396.X2 = 0.6680815F;
			this.Line396.Y1 = 0.1982861F;
			this.Line396.Y2 = 0.8232859F;
			// 
			// Line397
			// 
			this.Line397.Height = 0.6249998F;
			this.Line397.Left = 3.017081F;
			this.Line397.LineWeight = 1F;
			this.Line397.Name = "Line397";
			this.Line397.Top = 0.1982861F;
			this.Line397.Width = 0F;
			this.Line397.X1 = 3.017081F;
			this.Line397.X2 = 3.017081F;
			this.Line397.Y1 = 0.1982861F;
			this.Line397.Y2 = 0.8232859F;
			// 
			// Line398
			// 
			this.Line398.Height = 0.6249998F;
			this.Line398.Left = 3.207082F;
			this.Line398.LineWeight = 1F;
			this.Line398.Name = "Line398";
			this.Line398.Top = 0.1982861F;
			this.Line398.Width = 0F;
			this.Line398.X1 = 3.207082F;
			this.Line398.X2 = 3.207082F;
			this.Line398.Y1 = 0.1982861F;
			this.Line398.Y2 = 0.8232859F;
			// 
			// Line399
			// 
			this.Line399.Height = 0F;
			this.Line399.Left = 3.207082F;
			this.Line399.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line399.LineWeight = 1F;
			this.Line399.Name = "Line399";
			this.Line399.Top = 0.3542857F;
			this.Line399.Width = 2.168F;
			this.Line399.X1 = 3.207082F;
			this.Line399.X2 = 5.375082F;
			this.Line399.Y1 = 0.3542857F;
			this.Line399.Y2 = 0.3542857F;
			// 
			// Line400
			// 
			this.Line400.Height = 0F;
			this.Line400.Left = 3.207082F;
			this.Line400.LineWeight = 1F;
			this.Line400.Name = "Line400";
			this.Line400.Top = 0.5102859F;
			this.Line400.Width = 2.168F;
			this.Line400.X1 = 3.207082F;
			this.Line400.X2 = 5.375082F;
			this.Line400.Y1 = 0.5102859F;
			this.Line400.Y2 = 0.5102859F;
			// 
			// Line401
			// 
			this.Line401.Height = 0.5010001F;
			this.Line401.Left = 1.126082F;
			this.Line401.LineWeight = 1F;
			this.Line401.Name = "Line401";
			this.Line401.Top = 0.8232859F;
			this.Line401.Width = 0F;
			this.Line401.X1 = 1.126082F;
			this.Line401.X2 = 1.126082F;
			this.Line401.Y1 = 0.8232859F;
			this.Line401.Y2 = 1.324286F;
			// 
			// Line402
			// 
			this.Line402.Height = 0.5010001F;
			this.Line402.Left = 2.204082F;
			this.Line402.LineWeight = 1F;
			this.Line402.Name = "Line402";
			this.Line402.Top = 0.8232859F;
			this.Line402.Width = 0F;
			this.Line402.X1 = 2.204082F;
			this.Line402.X2 = 2.204082F;
			this.Line402.Y1 = 0.8232859F;
			this.Line402.Y2 = 1.324286F;
			// 
			// Line403
			// 
			this.Line403.Height = 0.5010001F;
			this.Line403.Left = 3.267081F;
			this.Line403.LineWeight = 1F;
			this.Line403.Name = "Line403";
			this.Line403.Top = 0.8232859F;
			this.Line403.Width = 0F;
			this.Line403.X1 = 3.267081F;
			this.Line403.X2 = 3.267081F;
			this.Line403.Y1 = 0.8232859F;
			this.Line403.Y2 = 1.324286F;
			// 
			// Line404
			// 
			this.Line404.Height = 0.5010001F;
			this.Line404.Left = 4.330081F;
			this.Line404.LineWeight = 1F;
			this.Line404.Name = "Line404";
			this.Line404.Top = 0.8232859F;
			this.Line404.Width = 0F;
			this.Line404.X1 = 4.330081F;
			this.Line404.X2 = 4.330081F;
			this.Line404.Y1 = 0.8232859F;
			this.Line404.Y2 = 1.324286F;
			// 
			// Line405
			// 
			this.Line405.Height = 0F;
			this.Line405.Left = 0.1880815F;
			this.Line405.LineWeight = 1F;
			this.Line405.Name = "Line405";
			this.Line405.Top = 0.9962859F;
			this.Line405.Width = 5.187F;
			this.Line405.X1 = 0.1880815F;
			this.Line405.X2 = 5.375082F;
			this.Line405.Y1 = 0.9962859F;
			this.Line405.Y2 = 0.9962859F;
			// 
			// Line406
			// 
			this.Line406.Height = 0F;
			this.Line406.Left = 0.5880815F;
			this.Line406.LineWeight = 1F;
			this.Line406.Name = "Line406";
			this.Line406.Top = 1.465286F;
			this.Line406.Width = 0.1000001F;
			this.Line406.X1 = 0.5880815F;
			this.Line406.X2 = 0.6880816F;
			this.Line406.Y1 = 1.465286F;
			this.Line406.Y2 = 1.465286F;
			// 
			// Line408
			// 
			this.Line408.Height = 0.516F;
			this.Line408.Left = 0.5880815F;
			this.Line408.LineWeight = 1F;
			this.Line408.Name = "Line408";
			this.Line408.Top = 1.465286F;
			this.Line408.Width = 0F;
			this.Line408.X1 = 0.5880815F;
			this.Line408.X2 = 0.5880815F;
			this.Line408.Y1 = 1.465286F;
			this.Line408.Y2 = 1.981286F;
			// 
			// Line409
			// 
			this.Line409.Height = 0.343001F;
			this.Line409.Left = 0.4880815F;
			this.Line409.LineWeight = 1F;
			this.Line409.Name = "Line409";
			this.Line409.Top = 1.638285F;
			this.Line409.Width = 0F;
			this.Line409.X1 = 0.4880815F;
			this.Line409.X2 = 0.4880815F;
			this.Line409.Y1 = 1.638285F;
			this.Line409.Y2 = 1.981286F;
			// 
			// Line410
			// 
			this.Line410.Height = 0.343001F;
			this.Line410.Left = 0.3880816F;
			this.Line410.LineWeight = 1F;
			this.Line410.Name = "Line410";
			this.Line410.Top = 1.638285F;
			this.Line410.Width = 0F;
			this.Line410.X1 = 0.3880816F;
			this.Line410.X2 = 0.3880816F;
			this.Line410.Y1 = 1.638285F;
			this.Line410.Y2 = 1.981286F;
			// 
			// Line411
			// 
			this.Line411.Height = 0.343001F;
			this.Line411.Left = 0.2880815F;
			this.Line411.LineWeight = 1F;
			this.Line411.Name = "Line411";
			this.Line411.Top = 1.638285F;
			this.Line411.Width = 0F;
			this.Line411.X1 = 0.2880815F;
			this.Line411.X2 = 0.2880815F;
			this.Line411.Y1 = 1.638285F;
			this.Line411.Y2 = 1.981286F;
			// 
			// Line412
			// 
			this.Line412.Height = 0.6570001F;
			this.Line412.Left = 1.282081F;
			this.Line412.LineWeight = 1F;
			this.Line412.Name = "Line412";
			this.Line412.Top = 1.324286F;
			this.Line412.Width = 0F;
			this.Line412.X1 = 1.282081F;
			this.Line412.X2 = 1.282081F;
			this.Line412.Y1 = 1.324286F;
			this.Line412.Y2 = 1.981286F;
			// 
			// Line413
			// 
			this.Line413.Height = 0.343001F;
			this.Line413.Left = 1.470082F;
			this.Line413.LineWeight = 1F;
			this.Line413.Name = "Line413";
			this.Line413.Top = 1.638285F;
			this.Line413.Width = 0F;
			this.Line413.X1 = 1.470082F;
			this.Line413.X2 = 1.470082F;
			this.Line413.Y1 = 1.638285F;
			this.Line413.Y2 = 1.981286F;
			// 
			// Line414
			// 
			this.Line414.Height = 0F;
			this.Line414.Left = 1.282081F;
			this.Line414.LineWeight = 1F;
			this.Line414.Name = "Line414";
			this.Line414.Top = 1.532286F;
			this.Line414.Width = 1.843001F;
			this.Line414.X1 = 1.282081F;
			this.Line414.X2 = 3.125082F;
			this.Line414.Y1 = 1.532286F;
			this.Line414.Y2 = 1.532286F;
			// 
			// Line415
			// 
			this.Line415.Height = 0.448999F;
			this.Line415.Left = 1.668082F;
			this.Line415.LineWeight = 1F;
			this.Line415.Name = "Line415";
			this.Line415.Top = 1.532287F;
			this.Line415.Width = 0F;
			this.Line415.X1 = 1.668082F;
			this.Line415.X2 = 1.668082F;
			this.Line415.Y1 = 1.532287F;
			this.Line415.Y2 = 1.981286F;
			// 
			// Line416
			// 
			this.Line416.Height = 0.2460001F;
			this.Line416.Left = 1.778082F;
			this.Line416.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line416.LineWeight = 1F;
			this.Line416.Name = "Line416";
			this.Line416.Top = 1.735286F;
			this.Line416.Width = 0F;
			this.Line416.X1 = 1.778082F;
			this.Line416.X2 = 1.778082F;
			this.Line416.Y1 = 1.735286F;
			this.Line416.Y2 = 1.981286F;
			// 
			// Line417
			// 
			this.Line417.Height = 0.343001F;
			this.Line417.Left = 1.997082F;
			this.Line417.LineWeight = 1F;
			this.Line417.Name = "Line417";
			this.Line417.Top = 1.638285F;
			this.Line417.Width = 0F;
			this.Line417.X1 = 1.997082F;
			this.Line417.X2 = 1.997082F;
			this.Line417.Y1 = 1.638285F;
			this.Line417.Y2 = 1.981286F;
			// 
			// Line418
			// 
			this.Line418.Height = 0.449F;
			this.Line418.Left = 2.215081F;
			this.Line418.LineWeight = 1F;
			this.Line418.Name = "Line418";
			this.Line418.Top = 1.532286F;
			this.Line418.Width = 0F;
			this.Line418.X1 = 2.215081F;
			this.Line418.X2 = 2.215081F;
			this.Line418.Y1 = 1.532286F;
			this.Line418.Y2 = 1.981286F;
			// 
			// Line419
			// 
			this.Line419.Height = 0.343001F;
			this.Line419.Left = 2.407082F;
			this.Line419.LineWeight = 1F;
			this.Line419.Name = "Line419";
			this.Line419.Top = 1.638285F;
			this.Line419.Width = 0F;
			this.Line419.X1 = 2.407082F;
			this.Line419.X2 = 2.407082F;
			this.Line419.Y1 = 1.638285F;
			this.Line419.Y2 = 1.981286F;
			// 
			// Line420
			// 
			this.Line420.Height = 0.6570001F;
			this.Line420.Left = 2.599082F;
			this.Line420.LineWeight = 1F;
			this.Line420.Name = "Line420";
			this.Line420.Top = 1.324286F;
			this.Line420.Width = 0F;
			this.Line420.X1 = 2.599082F;
			this.Line420.X2 = 2.599082F;
			this.Line420.Y1 = 1.324286F;
			this.Line420.Y2 = 1.981286F;
			// 
			// Line421
			// 
			this.Line421.Height = 0.2460001F;
			this.Line421.Left = 2.724082F;
			this.Line421.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line421.LineWeight = 1F;
			this.Line421.Name = "Line421";
			this.Line421.Top = 1.735286F;
			this.Line421.Width = 0F;
			this.Line421.X1 = 2.724082F;
			this.Line421.X2 = 2.724082F;
			this.Line421.Y1 = 1.735286F;
			this.Line421.Y2 = 1.981286F;
			// 
			// Line422
			// 
			this.Line422.Height = 0.448999F;
			this.Line422.Left = 2.849082F;
			this.Line422.LineWeight = 1F;
			this.Line422.Name = "Line422";
			this.Line422.Top = 1.532287F;
			this.Line422.Width = 0F;
			this.Line422.X1 = 2.849082F;
			this.Line422.X2 = 2.849082F;
			this.Line422.Y1 = 1.532287F;
			this.Line422.Y2 = 1.981286F;
			// 
			// Line423
			// 
			this.Line423.Height = 0.6570001F;
			this.Line423.Left = 3.124082F;
			this.Line423.LineWeight = 1F;
			this.Line423.Name = "Line423";
			this.Line423.Top = 1.324286F;
			this.Line423.Width = 0F;
			this.Line423.X1 = 3.124082F;
			this.Line423.X2 = 3.124082F;
			this.Line423.Y1 = 1.324286F;
			this.Line423.Y2 = 1.981286F;
			// 
			// Line424
			// 
			this.Line424.Height = 0.6570001F;
			this.Line424.Left = 3.656081F;
			this.Line424.LineWeight = 1F;
			this.Line424.Name = "Line424";
			this.Line424.Top = 1.324286F;
			this.Line424.Width = 0F;
			this.Line424.X1 = 3.656081F;
			this.Line424.X2 = 3.656081F;
			this.Line424.Y1 = 1.324286F;
			this.Line424.Y2 = 1.981286F;
			// 
			// Line425
			// 
			this.Line425.Height = 0.6570001F;
			this.Line425.Left = 4.219081F;
			this.Line425.LineWeight = 1F;
			this.Line425.Name = "Line425";
			this.Line425.Top = 1.324286F;
			this.Line425.Width = 0F;
			this.Line425.X1 = 4.219081F;
			this.Line425.X2 = 4.219081F;
			this.Line425.Y1 = 1.324286F;
			this.Line425.Y2 = 1.981286F;
			// 
			// Line426
			// 
			this.Line426.Height = 0.6570001F;
			this.Line426.Left = 4.770082F;
			this.Line426.LineWeight = 1F;
			this.Line426.Name = "Line426";
			this.Line426.Top = 1.324286F;
			this.Line426.Width = 0F;
			this.Line426.X1 = 4.770082F;
			this.Line426.X2 = 4.770082F;
			this.Line426.Y1 = 1.324286F;
			this.Line426.Y2 = 1.981286F;
			// 
			// Line427
			// 
			this.Line427.Height = 0F;
			this.Line427.Left = 0.1880815F;
			this.Line427.LineWeight = 1F;
			this.Line427.Name = "Line427";
			this.Line427.Top = 1.981286F;
			this.Line427.Width = 5.187F;
			this.Line427.X1 = 0.1880815F;
			this.Line427.X2 = 5.375082F;
			this.Line427.Y1 = 1.981286F;
			this.Line427.Y2 = 1.981286F;
			// 
			// Line428
			// 
			this.Line428.Height = 0.51F;
			this.Line428.Left = 3.750082F;
			this.Line428.LineWeight = 1F;
			this.Line428.Name = "Line428";
			this.Line428.Top = 2.6F;
			this.Line428.Width = 0F;
			this.Line428.X1 = 3.750082F;
			this.Line428.X2 = 3.750082F;
			this.Line428.Y1 = 2.6F;
			this.Line428.Y2 = 3.11F;
			// 
			// Line429
			// 
			this.Line429.Height = 0.619F;
			this.Line429.Left = 4.62F;
			this.Line429.LineWeight = 1F;
			this.Line429.Name = "Line429";
			this.Line429.Top = 1.981F;
			this.Line429.Width = 0F;
			this.Line429.X1 = 4.62F;
			this.Line429.X2 = 4.62F;
			this.Line429.Y1 = 1.981F;
			this.Line429.Y2 = 2.6F;
			// 
			// Line431
			// 
			this.Line431.Height = 1.02F;
			this.Line431.Left = 0.4067482F;
			this.Line431.LineWeight = 1F;
			this.Line431.Name = "Line431";
			this.Line431.Top = 2.6F;
			this.Line431.Width = 0F;
			this.Line431.X1 = 0.4067482F;
			this.Line431.X2 = 0.4067482F;
			this.Line431.Y1 = 2.6F;
			this.Line431.Y2 = 3.62F;
			// 
			// Line434
			// 
			this.Line434.Height = 0F;
			this.Line434.Left = 1.490082F;
			this.Line434.LineWeight = 1F;
			this.Line434.Name = "Line434";
			this.Line434.Top = 2.69F;
			this.Line434.Width = 0.8F;
			this.Line434.X1 = 1.490082F;
			this.Line434.X2 = 2.290082F;
			this.Line434.Y1 = 2.69F;
			this.Line434.Y2 = 2.69F;
			// 
			// Line436
			// 
			this.Line436.Height = 0.51F;
			this.Line436.Left = 1.290082F;
			this.Line436.LineWeight = 1F;
			this.Line436.Name = "Line436";
			this.Line436.Top = 2.6F;
			this.Line436.Width = 0F;
			this.Line436.X1 = 1.290082F;
			this.Line436.X2 = 1.290082F;
			this.Line436.Y1 = 2.6F;
			this.Line436.Y2 = 3.11F;
			// 
			// Line440
			// 
			this.Line440.Height = 0.51F;
			this.Line440.Left = 2.290082F;
			this.Line440.LineWeight = 1F;
			this.Line440.Name = "Line440";
			this.Line440.Top = 2.6F;
			this.Line440.Width = 0F;
			this.Line440.X1 = 2.290082F;
			this.Line440.X2 = 2.290082F;
			this.Line440.Y1 = 2.6F;
			this.Line440.Y2 = 3.11F;
			// 
			// Line441
			// 
			this.Line441.Height = 0.51F;
			this.Line441.Left = 2.490082F;
			this.Line441.LineWeight = 1F;
			this.Line441.Name = "Line441";
			this.Line441.Top = 2.6F;
			this.Line441.Width = 0F;
			this.Line441.X1 = 2.490082F;
			this.Line441.X2 = 2.490082F;
			this.Line441.Y1 = 2.6F;
			this.Line441.Y2 = 3.11F;
			// 
			// Line442
			// 
			this.Line442.Height = 0.51F;
			this.Line442.Left = 2.689081F;
			this.Line442.LineWeight = 1F;
			this.Line442.Name = "Line442";
			this.Line442.Top = 2.6F;
			this.Line442.Width = 0F;
			this.Line442.X1 = 2.689081F;
			this.Line442.X2 = 2.689081F;
			this.Line442.Y1 = 2.6F;
			this.Line442.Y2 = 3.11F;
			// 
			// Line443
			// 
			this.Line443.Height = 0F;
			this.Line443.Left = 2.689081F;
			this.Line443.LineWeight = 1F;
			this.Line443.Name = "Line443";
			this.Line443.Top = 2.76F;
			this.Line443.Width = 2.686001F;
			this.Line443.X1 = 2.689081F;
			this.Line443.X2 = 5.375082F;
			this.Line443.Y1 = 2.76F;
			this.Line443.Y2 = 2.76F;
			// 
			// Line444
			// 
			this.Line444.Height = 0.3499999F;
			this.Line444.Left = 2.889081F;
			this.Line444.LineWeight = 1F;
			this.Line444.Name = "Line444";
			this.Line444.Top = 2.76F;
			this.Line444.Width = 0F;
			this.Line444.X1 = 2.889081F;
			this.Line444.X2 = 2.889081F;
			this.Line444.Y1 = 2.76F;
			this.Line444.Y2 = 3.11F;
			// 
			// Line445
			// 
			this.Line445.Height = 0.3499999F;
			this.Line445.Left = 3.089082F;
			this.Line445.LineWeight = 1F;
			this.Line445.Name = "Line445";
			this.Line445.Top = 2.76F;
			this.Line445.Width = 0F;
			this.Line445.X1 = 3.089082F;
			this.Line445.X2 = 3.089082F;
			this.Line445.Y1 = 2.76F;
			this.Line445.Y2 = 3.11F;
			// 
			// Line446
			// 
			this.Line446.Height = 0.3499999F;
			this.Line446.Left = 3.330081F;
			this.Line446.LineWeight = 1F;
			this.Line446.Name = "Line446";
			this.Line446.Top = 2.76F;
			this.Line446.Width = 0F;
			this.Line446.X1 = 3.330081F;
			this.Line446.X2 = 3.330081F;
			this.Line446.Y1 = 2.76F;
			this.Line446.Y2 = 3.11F;
			// 
			// Line447
			// 
			this.Line447.Height = 0.3499999F;
			this.Line447.Left = 3.522082F;
			this.Line447.LineWeight = 1F;
			this.Line447.Name = "Line447";
			this.Line447.Top = 2.76F;
			this.Line447.Width = 0F;
			this.Line447.X1 = 3.522082F;
			this.Line447.X2 = 3.522082F;
			this.Line447.Y1 = 2.76F;
			this.Line447.Y2 = 3.11F;
			// 
			// Line448
			// 
			this.Line448.Height = 0.3499999F;
			this.Line448.Left = 3.944082F;
			this.Line448.LineWeight = 1F;
			this.Line448.Name = "Line448";
			this.Line448.Top = 2.76F;
			this.Line448.Width = 0F;
			this.Line448.X1 = 3.944082F;
			this.Line448.X2 = 3.944082F;
			this.Line448.Y1 = 2.76F;
			this.Line448.Y2 = 3.11F;
			// 
			// Line449
			// 
			this.Line449.Height = 0.3499999F;
			this.Line449.Left = 4.138082F;
			this.Line449.LineWeight = 1F;
			this.Line449.Name = "Line449";
			this.Line449.Top = 2.76F;
			this.Line449.Width = 0F;
			this.Line449.X1 = 4.138082F;
			this.Line449.X2 = 4.138082F;
			this.Line449.Y1 = 2.76F;
			this.Line449.Y2 = 3.11F;
			// 
			// Line450
			// 
			this.Line450.Height = 0.3499999F;
			this.Line450.Left = 4.332083F;
			this.Line450.LineWeight = 1F;
			this.Line450.Name = "Line450";
			this.Line450.Top = 2.76F;
			this.Line450.Width = 0F;
			this.Line450.X1 = 4.332083F;
			this.Line450.X2 = 4.332083F;
			this.Line450.Y1 = 2.76F;
			this.Line450.Y2 = 3.11F;
			// 
			// Line451
			// 
			this.Line451.Height = 0.3499999F;
			this.Line451.Left = 4.526082F;
			this.Line451.LineWeight = 1F;
			this.Line451.Name = "Line451";
			this.Line451.Top = 2.76F;
			this.Line451.Width = 0F;
			this.Line451.X1 = 4.526082F;
			this.Line451.X2 = 4.526082F;
			this.Line451.Y1 = 2.76F;
			this.Line451.Y2 = 3.11F;
			// 
			// Line452
			// 
			this.Line452.Height = 0.3499999F;
			this.Line452.Left = 4.809082F;
			this.Line452.LineWeight = 1F;
			this.Line452.Name = "Line452";
			this.Line452.Top = 2.76F;
			this.Line452.Width = 0F;
			this.Line452.X1 = 4.809082F;
			this.Line452.X2 = 4.809082F;
			this.Line452.Y1 = 2.76F;
			this.Line452.Y2 = 3.11F;
			// 
			// Line455
			// 
			this.Line455.Height = 0F;
			this.Line455.Left = 0.4100815F;
			this.Line455.LineWeight = 1F;
			this.Line455.Name = "Line455";
			this.Line455.Top = 3.44F;
			this.Line455.Width = 4.965001F;
			this.Line455.X1 = 0.4100815F;
			this.Line455.X2 = 5.375082F;
			this.Line455.Y1 = 3.44F;
			this.Line455.Y2 = 3.44F;
			// 
			// Line456
			// 
			this.Line456.Height = 0.3499999F;
			this.Line456.Left = 5.092082F;
			this.Line456.LineWeight = 1F;
			this.Line456.Name = "Line456";
			this.Line456.Top = 2.76F;
			this.Line456.Width = 0F;
			this.Line456.X1 = 5.092082F;
			this.Line456.X2 = 5.092082F;
			this.Line456.Y1 = 2.76F;
			this.Line456.Y2 = 3.11F;
			// 
			// Line615
			// 
			this.Line615.Height = 0.6570001F;
			this.Line615.Left = 0.6890815F;
			this.Line615.LineWeight = 1F;
			this.Line615.Name = "Line615";
			this.Line615.Top = 1.324286F;
			this.Line615.Width = 0F;
			this.Line615.X1 = 0.6890815F;
			this.Line615.X2 = 0.6890815F;
			this.Line615.Y1 = 1.324286F;
			this.Line615.Y2 = 1.981286F;
			// 
			// Line617
			// 
			this.Line617.Height = 0F;
			this.Line617.Left = 2.42F;
			this.Line617.LineWeight = 1F;
			this.Line617.Name = "Line617";
			this.Line617.Top = 2.12F;
			this.Line617.Width = 2.955F;
			this.Line617.X1 = 2.42F;
			this.Line617.X2 = 5.375F;
			this.Line617.Y1 = 2.12F;
			this.Line617.Y2 = 2.12F;
			// 
			// Line618
			// 
			this.Line618.Height = 0F;
			this.Line618.Left = 2.42F;
			this.Line618.LineWeight = 1F;
			this.Line618.Name = "Line618";
			this.Line618.Top = 2.28F;
			this.Line618.Width = 2.955F;
			this.Line618.X1 = 2.42F;
			this.Line618.X2 = 5.375F;
			this.Line618.Y1 = 2.28F;
			this.Line618.Y2 = 2.28F;
			// 
			// Line619
			// 
			this.Line619.Height = 0F;
			this.Line619.Left = 2.42F;
			this.Line619.LineWeight = 1F;
			this.Line619.Name = "Line619";
			this.Line619.Top = 6.23F;
			this.Line619.Width = 2.955082F;
			this.Line619.X1 = 2.42F;
			this.Line619.X2 = 5.375082F;
			this.Line619.Y1 = 6.23F;
			this.Line619.Y2 = 6.23F;
			// 
			// Line620
			// 
			this.Line620.Height = 0F;
			this.Line620.Left = 2.42F;
			this.Line620.LineWeight = 1F;
			this.Line620.Name = "Line620";
			this.Line620.Top = 6.54F;
			this.Line620.Width = 2.955082F;
			this.Line620.X1 = 2.42F;
			this.Line620.X2 = 5.375082F;
			this.Line620.Y1 = 6.54F;
			this.Line620.Y2 = 6.54F;
			// 
			// Line751
			// 
			this.Line751.Height = 0F;
			this.Line751.Left = 0.1880815F;
			this.Line751.LineWeight = 1F;
			this.Line751.Name = "Line751";
			this.Line751.Top = 3.775286F;
			this.Line751.Width = 3.334001F;
			this.Line751.X1 = 0.1880815F;
			this.Line751.X2 = 3.522082F;
			this.Line751.Y1 = 3.775286F;
			this.Line751.Y2 = 3.775286F;
			// 
			// Label1595
			// 
			this.Label1595.Height = 0.125F;
			this.Label1595.HyperLink = null;
			this.Label1595.Left = 3.124082F;
			this.Label1595.Name = "Label1595";
			this.Label1595.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1595.Text = "内";
			this.Label1595.Top = 1.638286F;
			this.Label1595.Width = 0.125F;
			// 
			// Label1596
			// 
			this.Label1596.Height = 0.125F;
			this.Label1596.HyperLink = null;
			this.Label1596.Left = 3.124082F;
			this.Label1596.Name = "Label1596";
			this.Label1596.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1596.Text = "内";
			this.Label1596.Top = 5.742452F;
			this.Label1596.Width = 0.125F;
			// 
			// Line752
			// 
			this.Line752.Height = 0F;
			this.Line752.Left = 0.1880815F;
			this.Line752.LineWeight = 1F;
			this.Line752.Name = "Line752";
			this.Line752.Top = 1.826286F;
			this.Line752.Width = 0.4F;
			this.Line752.X1 = 0.1880815F;
			this.Line752.X2 = 0.5880815F;
			this.Line752.Y1 = 1.826286F;
			this.Line752.Y2 = 1.826286F;
			// 
			// Line753
			// 
			this.Line753.Height = 0F;
			this.Line753.Left = 0.1880815F;
			this.Line753.LineWeight = 1F;
			this.Line753.Name = "Line753";
			this.Line753.Top = 5.930452F;
			this.Line753.Width = 0.4F;
			this.Line753.X1 = 0.1880815F;
			this.Line753.X2 = 0.5880815F;
			this.Line753.Y1 = 5.930452F;
			this.Line753.Y2 = 5.930452F;
			// 
			// Line758
			// 
			this.Line758.Height = 0F;
			this.Line758.Left = 3.124082F;
			this.Line758.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line758.LineWeight = 1F;
			this.Line758.Name = "Line758";
			this.Line758.Top = 5.979452F;
			this.Line758.Width = 0.5319989F;
			this.Line758.X1 = 3.124082F;
			this.Line758.X2 = 3.656081F;
			this.Line758.Y1 = 5.979452F;
			this.Line758.Y2 = 5.979452F;
			// 
			// Line759
			// 
			this.Line759.Height = 0F;
			this.Line759.Left = 3.124082F;
			this.Line759.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line759.LineWeight = 1F;
			this.Line759.Name = "Line759";
			this.Line759.Top = 1.870286F;
			this.Line759.Width = 0.5319989F;
			this.Line759.X1 = 3.124082F;
			this.Line759.X2 = 3.656081F;
			this.Line759.Y1 = 1.870286F;
			this.Line759.Y2 = 1.870286F;
			// 
			// summary2Digit0Text
			// 
			this.summary2Digit0Text.CanGrow = false;
			this.summary2Digit0Text.DataField = "SUMMARY_2_DIGIT";
			this.summary2Digit0Text.Height = 0.113F;
			this.summary2Digit0Text.Left = 0.22F;
			this.summary2Digit0Text.Name = "summary2Digit0Text";
			this.summary2Digit0Text.Style = "font-size: 5.2pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.summary2Digit0Text.Text = "あいうえおかきくけこさしすせそたちつてとあいうえおかきくけこさしすせそたちつてと";
			this.summary2Digit0Text.Top = 3.787F;
			this.summary2Digit0Text.Width = 3.5F;
			// 
			// summary2Digit1Text
			// 
			this.summary2Digit1Text.CanGrow = false;
			this.summary2Digit1Text.DataField = "SUMMARY_2_DIGIT";
			this.summary2Digit1Text.Height = 0.113F;
			this.summary2Digit1Text.Left = 0.2200815F;
			this.summary2Digit1Text.Name = "summary2Digit1Text";
			this.summary2Digit1Text.Style = "font-size: 5.2pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.summary2Digit1Text.Text = "あいうえおかきくけこさしすせそたちつてとあいうえおかきくけこさしすせそたちつてと";
			this.summary2Digit1Text.Top = 7.739452F;
			this.summary2Digit1Text.Width = 3.5F;
			// 
			// summary0Digit0Text
			// 
			this.summary0Digit0Text.CanGrow = false;
			this.summary0Digit0Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit0Text.Height = 0.125F;
			this.summary0Digit0Text.Left = 0.208F;
			this.summary0Digit0Text.MultiLine = false;
			this.summary0Digit0Text.Name = "summary0Digit0Text";
			this.summary0Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit0Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit0Text.Top = 1.97F;
			this.summary0Digit0Text.Width = 3.695F;
			// 
			// line1
			// 
			this.line1.Height = 0.4199998F;
			this.line1.Left = 1.690082F;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.Top = 2.69F;
			this.line1.Width = 0F;
			this.line1.X1 = 1.690082F;
			this.line1.X2 = 1.690082F;
			this.line1.Y1 = 2.69F;
			this.line1.Y2 = 3.11F;
			// 
			// line2
			// 
			this.line2.Height = 0.51F;
			this.line2.Left = 1.490082F;
			this.line2.LineWeight = 1F;
			this.line2.Name = "line2";
			this.line2.Top = 2.6F;
			this.line2.Width = 0F;
			this.line2.X1 = 1.490082F;
			this.line2.X2 = 1.490082F;
			this.line2.Y1 = 2.6F;
			this.line2.Y2 = 3.11F;
			// 
			// line3
			// 
			this.line3.Height = 1.02F;
			this.line3.Left = 1.07F;
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.Top = 2.6F;
			this.line3.Width = 0F;
			this.line3.X1 = 1.07F;
			this.line3.X2 = 1.07F;
			this.line3.Y1 = 2.6F;
			this.line3.Y2 = 3.62F;
			// 
			// label8
			// 
			this.label8.Height = 0.165F;
			this.label8.HyperLink = null;
			this.label8.Left = 1.29F;
			this.label8.Name = "label8";
			this.label8.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label8.Text = "乙";
			this.label8.Top = 6.703F;
			this.label8.Width = 0.2F;
			// 
			// label9
			// 
			this.label9.Height = 0.165F;
			this.label9.HyperLink = null;
			this.label9.Left = 1.29F;
			this.label9.Name = "label9";
			this.label9.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label9.Text = "欄";
			this.label9.Top = 6.858F;
			this.label9.Width = 0.2F;
			// 
			// label10
			// 
			this.label10.Height = 0.09F;
			this.label10.HyperLink = null;
			this.label10.Left = 1.5F;
			this.label10.Name = "label10";
			this.label10.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label10.Text = "本人が障害者";
			this.label10.Top = 6.712F;
			this.label10.Width = 0.394F;
			// 
			// label16
			// 
			this.label16.Height = 0.09F;
			this.label16.HyperLink = null;
			this.label16.Left = 1.938F;
			this.label16.Name = "label16";
			this.label16.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label16.Text = "寡　 婦";
			this.label16.Top = 6.712F;
			this.label16.Width = 0.3F;
			// 
			// label19
			// 
			this.label19.Height = 0.21F;
			this.label19.HyperLink = null;
			this.label19.Left = 2.125F;
			this.label19.Name = "label19";
			this.label19.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label19.Text = "特別";
			this.label19.Top = 6.816F;
			this.label19.Width = 0.1249999F;
			// 
			// label21
			// 
			this.label21.Height = 0.165F;
			this.label21.HyperLink = null;
			this.label21.Left = 2.29F;
			this.label21.Name = "label21";
			this.label21.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label21.Text = "寡";
			this.label21.Top = 6.703F;
			this.label21.Width = 0.2F;
			// 
			// label22
			// 
			this.label22.Height = 0.165F;
			this.label22.HyperLink = null;
			this.label22.Left = 2.29F;
			this.label22.Name = "label22";
			this.label22.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label22.Text = "夫";
			this.label22.Top = 6.858F;
			this.label22.Width = 0.2F;
			// 
			// label32
			// 
			this.label32.Height = 0.29F;
			this.label32.HyperLink = null;
			this.label32.Left = 0.67F;
			this.label32.Name = "label32";
			this.label32.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.label32.Text = "外国人";
			this.label32.Top = 6.732F;
			this.label32.Width = 0.135F;
			// 
			// line4
			// 
			this.line4.Height = 1.024F;
			this.line4.Left = 0.41F;
			this.line4.LineWeight = 1F;
			this.line4.Name = "line4";
			this.line4.Top = 6.7F;
			this.line4.Width = 0F;
			this.line4.X1 = 0.41F;
			this.line4.X2 = 0.41F;
			this.line4.Y1 = 6.7F;
			this.line4.Y2 = 7.724F;
			// 
			// line5
			// 
			this.line5.Height = 0.5100002F;
			this.line5.Left = 0.63F;
			this.line5.LineWeight = 1F;
			this.line5.Name = "line5";
			this.line5.Top = 6.7F;
			this.line5.Width = 0F;
			this.line5.X1 = 0.63F;
			this.line5.X2 = 0.63F;
			this.line5.Y1 = 6.7F;
			this.line5.Y2 = 7.21F;
			// 
			// line6
			// 
			this.line6.Height = 0.5100002F;
			this.line6.Left = 0.85F;
			this.line6.LineWeight = 1F;
			this.line6.Name = "line6";
			this.line6.Top = 6.7F;
			this.line6.Width = 0F;
			this.line6.X1 = 0.85F;
			this.line6.X2 = 0.85F;
			this.line6.Y1 = 6.7F;
			this.line6.Y2 = 7.21F;
			// 
			// line7
			// 
			this.line7.Height = 0F;
			this.line7.Left = 1.490082F;
			this.line7.LineWeight = 1F;
			this.line7.Name = "line7";
			this.line7.Top = 6.8F;
			this.line7.Width = 0.7999179F;
			this.line7.X1 = 1.490082F;
			this.line7.X2 = 2.29F;
			this.line7.Y1 = 6.8F;
			this.line7.Y2 = 6.8F;
			// 
			// line8
			// 
			this.line8.Height = 0.5100002F;
			this.line8.Left = 1.290082F;
			this.line8.LineWeight = 1F;
			this.line8.Name = "line8";
			this.line8.Top = 6.7F;
			this.line8.Width = 0F;
			this.line8.X1 = 1.290082F;
			this.line8.X2 = 1.290082F;
			this.line8.Y1 = 6.7F;
			this.line8.Y2 = 7.21F;
			// 
			// line11
			// 
			this.line11.Height = 0.5100002F;
			this.line11.Left = 2.290082F;
			this.line11.LineWeight = 1F;
			this.line11.Name = "line11";
			this.line11.Top = 6.7F;
			this.line11.Width = 0F;
			this.line11.X1 = 2.290082F;
			this.line11.X2 = 2.290082F;
			this.line11.Y1 = 6.7F;
			this.line11.Y2 = 7.21F;
			// 
			// line12
			// 
			this.line12.Height = 0.5100002F;
			this.line12.Left = 2.490082F;
			this.line12.LineWeight = 1F;
			this.line12.Name = "line12";
			this.line12.Top = 6.7F;
			this.line12.Width = 0F;
			this.line12.X1 = 2.490082F;
			this.line12.X2 = 2.490082F;
			this.line12.Y1 = 6.7F;
			this.line12.Y2 = 7.21F;
			// 
			// line13
			// 
			this.line13.Height = 0.4099998F;
			this.line13.Left = 1.687582F;
			this.line13.LineWeight = 1F;
			this.line13.Name = "line13";
			this.line13.Top = 6.8F;
			this.line13.Width = 0F;
			this.line13.X1 = 1.687582F;
			this.line13.X2 = 1.687582F;
			this.line13.Y1 = 6.8F;
			this.line13.Y2 = 7.21F;
			// 
			// line14
			// 
			this.line14.Height = 0.5100002F;
			this.line14.Left = 1.490082F;
			this.line14.LineWeight = 1F;
			this.line14.Name = "line14";
			this.line14.Top = 6.7F;
			this.line14.Width = 0F;
			this.line14.X1 = 1.490082F;
			this.line14.X2 = 1.490082F;
			this.line14.Y1 = 6.7F;
			this.line14.Y2 = 7.21F;
			// 
			// line15
			// 
			this.line15.Height = 1.024F;
			this.line15.Left = 1.070082F;
			this.line15.LineWeight = 1F;
			this.line15.Name = "line15";
			this.line15.Top = 6.7F;
			this.line15.Width = 0F;
			this.line15.X1 = 1.070082F;
			this.line15.X2 = 1.070082F;
			this.line15.Y1 = 6.7F;
			this.line15.Y2 = 7.724F;
			// 
			// Line331
			// 
			this.Line331.Height = 3.422F;
			this.Line331.Left = 0.1880815F;
			this.Line331.LineWeight = 1F;
			this.Line331.Name = "Line331";
			this.Line331.Top = 4.302453F;
			this.Line331.Width = 0F;
			this.Line331.X1 = 0.1880815F;
			this.Line331.X2 = 0.1880815F;
			this.Line331.Y1 = 4.302453F;
			this.Line331.Y2 = 7.724453F;
			// 
			// Line433
			// 
			this.Line433.Height = 0.51F;
			this.Line433.Left = 0.848415F;
			this.Line433.LineWeight = 1F;
			this.Line433.Name = "Line433";
			this.Line433.Top = 2.6F;
			this.Line433.Width = 0F;
			this.Line433.X1 = 0.848415F;
			this.Line433.X2 = 0.848415F;
			this.Line433.Y1 = 2.6F;
			this.Line433.Y2 = 3.11F;
			// 
			// Line432
			// 
			this.Line432.Height = 0.51F;
			this.Line432.Left = 0.6275815F;
			this.Line432.LineWeight = 1F;
			this.Line432.Name = "Line432";
			this.Line432.Top = 2.6F;
			this.Line432.Width = 0F;
			this.Line432.X1 = 0.6275815F;
			this.Line432.X2 = 0.6275815F;
			this.Line432.Y1 = 2.6F;
			this.Line432.Y2 = 3.11F;
			// 
			// Line438
			// 
			this.Line438.Height = 0.51F;
			this.Line438.Left = 1.890082F;
			this.Line438.LineWeight = 1F;
			this.Line438.Name = "Line438";
			this.Line438.Top = 2.6F;
			this.Line438.Width = 0F;
			this.Line438.X1 = 1.890082F;
			this.Line438.X2 = 1.890082F;
			this.Line438.Y1 = 2.6F;
			this.Line438.Y2 = 3.11F;
			// 
			// Line439
			// 
			this.Line439.Height = 0.4199998F;
			this.Line439.Left = 2.090081F;
			this.Line439.LineWeight = 1F;
			this.Line439.Name = "Line439";
			this.Line439.Top = 2.69F;
			this.Line439.Width = 0F;
			this.Line439.X1 = 2.090081F;
			this.Line439.X2 = 2.090081F;
			this.Line439.Y1 = 2.69F;
			this.Line439.Y2 = 3.11F;
			// 
			// Line329
			// 
			this.Line329.Height = 0F;
			this.Line329.Left = 0.188F;
			this.Line329.LineWeight = 1F;
			this.Line329.Name = "Line329";
			this.Line329.Top = 2.93F;
			this.Line329.Width = 5.187F;
			this.Line329.X1 = 0.188F;
			this.Line329.X2 = 5.375F;
			this.Line329.Y1 = 2.93F;
			this.Line329.Y2 = 2.93F;
			// 
			// Line305
			// 
			this.Line305.Height = 0F;
			this.Line305.Left = 0.188F;
			this.Line305.LineWeight = 1F;
			this.Line305.Name = "Line305";
			this.Line305.Top = 7.03F;
			this.Line305.Width = 5.187F;
			this.Line305.X1 = 0.188F;
			this.Line305.X2 = 5.375F;
			this.Line305.Y1 = 7.03F;
			this.Line305.Y2 = 7.03F;
			// 
			// line9
			// 
			this.line9.Height = 0.5100002F;
			this.line9.Left = 1.890082F;
			this.line9.LineWeight = 1F;
			this.line9.Name = "line9";
			this.line9.Top = 6.7F;
			this.line9.Width = 0F;
			this.line9.X1 = 1.890082F;
			this.line9.X2 = 1.890082F;
			this.line9.Y1 = 6.7F;
			this.line9.Y2 = 7.21F;
			// 
			// line10
			// 
			this.line10.Height = 0.4099998F;
			this.line10.Left = 2.090081F;
			this.line10.LineWeight = 1F;
			this.line10.Name = "line10";
			this.line10.Top = 6.8F;
			this.line10.Width = 0F;
			this.line10.X1 = 2.090081F;
			this.line10.X2 = 2.090081F;
			this.line10.Y1 = 6.8F;
			this.line10.Y2 = 7.21F;
			// 
			// YoungDpndNumText
			// 
			this.YoungDpndNumText.CanGrow = false;
			this.YoungDpndNumText.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNumText.Height = 0.1250001F;
			this.YoungDpndNumText.Left = 0.198F;
			this.YoungDpndNumText.Name = "YoungDpndNumText";
			this.YoungDpndNumText.Style = "font-size: 6pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNumText.Text = "Z6";
			this.YoungDpndNumText.Top = 2.973F;
			this.YoungDpndNumText.Width = 0.12F;
			// 
			// Line313
			// 
			this.Line313.Height = 3.577F;
			this.Line313.Left = 0.1880815F;
			this.Line313.LineWeight = 1F;
			this.Line313.Name = "Line313";
			this.Line313.Top = 0.1982858F;
			this.Line313.Width = 0F;
			this.Line313.X1 = 0.1880815F;
			this.Line313.X2 = 0.1880815F;
			this.Line313.Y1 = 0.1982858F;
			this.Line313.Y2 = 3.775286F;
			// 
			// Line330
			// 
			this.Line330.Height = 0F;
			this.Line330.Left = 0.188F;
			this.Line330.LineWeight = 1F;
			this.Line330.Name = "Line330";
			this.Line330.Top = 3.11F;
			this.Line330.Width = 5.187F;
			this.Line330.X1 = 0.188F;
			this.Line330.X2 = 5.375F;
			this.Line330.Y1 = 3.11F;
			this.Line330.Y2 = 3.11F;
			// 
			// subReport1
			// 
			this.subReport1.CloseBorder = false;
			this.subReport1.Height = 7.94685F;
			this.subReport1.Left = 5.612287F;
			this.subReport1.Name = "subReport1";
			this.subReport1.Report = null;
			this.subReport1.ReportName = "subReport1";
			this.subReport1.Top = 0F;
			this.subReport1.Width = 5.624646F;
			// 
			// label4
			// 
			this.label4.Height = 0.153F;
			this.label4.HyperLink = null;
			this.label4.Left = 3.758F;
			this.label4.Name = "label4";
			this.label4.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label4.Text = "円";
			this.label4.Top = 2.136F;
			this.label4.Width = 0.125F;
			// 
			// line16
			// 
			this.line16.Height = 0F;
			this.line16.Left = 2.42F;
			this.line16.LineWeight = 1F;
			this.line16.Name = "line16";
			this.line16.Top = 2.44F;
			this.line16.Width = 2.955F;
			this.line16.X1 = 2.42F;
			this.line16.X2 = 5.375F;
			this.line16.Y1 = 2.44F;
			this.line16.Y2 = 2.44F;
			// 
			// label5
			// 
			this.label5.Height = 0.153F;
			this.label5.HyperLink = null;
			this.label5.Left = 3.883F;
			this.label5.Name = "label5";
			this.label5.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label5.Text = "新個人年金保険料の金額";
			this.label5.Top = 2.136F;
			this.label5.Width = 0.755F;
			// 
			// newLifeInsPensAmtText
			// 
			this.newLifeInsPensAmtText.CanGrow = false;
			this.newLifeInsPensAmtText.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.newLifeInsPensAmtText.Height = 0.153F;
			this.newLifeInsPensAmtText.Left = 4.613F;
			this.newLifeInsPensAmtText.Name = "newLifeInsPensAmtText";
			this.newLifeInsPensAmtText.OutputFormat = "#,##0";
			this.newLifeInsPensAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsPensAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsPensAmtText.Top = 2.136F;
			this.newLifeInsPensAmtText.Width = 0.647F;
			// 
			// label13
			// 
			this.label13.Height = 0.153F;
			this.label13.HyperLink = null;
			this.label13.Left = 5.26F;
			this.label13.Name = "label13";
			this.label13.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label13.Text = "円";
			this.label13.Top = 2.136F;
			this.label13.Width = 0.125F;
			// 
			// newLifeInsCareAmtText
			// 
			this.newLifeInsCareAmtText.CanGrow = false;
			this.newLifeInsCareAmtText.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.newLifeInsCareAmtText.Height = 0.153F;
			this.newLifeInsCareAmtText.Left = 4.613F;
			this.newLifeInsCareAmtText.Name = "newLifeInsCareAmtText";
			this.newLifeInsCareAmtText.OutputFormat = "#,##0";
			this.newLifeInsCareAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsCareAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsCareAmtText.Top = 1.98F;
			this.newLifeInsCareAmtText.Width = 0.647F;
			// 
			// label18
			// 
			this.label18.Height = 0.153F;
			this.label18.HyperLink = null;
			this.label18.Left = 3.883F;
			this.label18.Name = "label18";
			this.label18.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label18.Text = "介護医療保険料の金額";
			this.label18.Top = 1.98F;
			this.label18.Width = 0.755F;
			// 
			// line17
			// 
			this.line17.Height = 0.619F;
			this.line17.Left = 3.87F;
			this.line17.LineWeight = 1F;
			this.line17.Name = "line17";
			this.line17.Top = 1.981F;
			this.line17.Width = 0F;
			this.line17.X1 = 3.87F;
			this.line17.X2 = 3.87F;
			this.line17.Y1 = 1.981F;
			this.line17.Y2 = 2.6F;
			// 
			// label20
			// 
			this.label20.Height = 0.153F;
			this.label20.HyperLink = null;
			this.label20.Left = 3.758F;
			this.label20.Name = "label20";
			this.label20.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label20.Text = "円";
			this.label20.Top = 2.289F;
			this.label20.Width = 0.125F;
			// 
			// label24
			// 
			this.label24.Height = 0.153F;
			this.label24.HyperLink = null;
			this.label24.Left = 3.758F;
			this.label24.Name = "label24";
			this.label24.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label24.Text = "円";
			this.label24.Top = 2.446F;
			this.label24.Width = 0.125F;
			// 
			// newLifeInsGeneralAmtText
			// 
			this.newLifeInsGeneralAmtText.CanGrow = false;
			this.newLifeInsGeneralAmtText.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmtText.Height = 0.153F;
			this.newLifeInsGeneralAmtText.Left = 3.111F;
			this.newLifeInsGeneralAmtText.Name = "newLifeInsGeneralAmtText";
			this.newLifeInsGeneralAmtText.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsGeneralAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmtText.Top = 2.289F;
			this.newLifeInsGeneralAmtText.Width = 0.647F;
			// 
			// lifeInsGeneralAmtText
			// 
			this.lifeInsGeneralAmtText.CanGrow = false;
			this.lifeInsGeneralAmtText.DataField = "LIFE_INS_GENERAL_AMT";
			this.lifeInsGeneralAmtText.Height = 0.153F;
			this.lifeInsGeneralAmtText.Left = 3.111F;
			this.lifeInsGeneralAmtText.Name = "lifeInsGeneralAmtText";
			this.lifeInsGeneralAmtText.OutputFormat = "#,##0";
			this.lifeInsGeneralAmtText.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.lifeInsGeneralAmtText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsGeneralAmtText.Top = 2.446F;
			this.lifeInsGeneralAmtText.Width = 0.647F;
			// 
			// line18
			// 
			this.line18.Height = 0.48F;
			this.line18.Left = 3.11F;
			this.line18.LineWeight = 1F;
			this.line18.Name = "line18";
			this.line18.Top = 2.12F;
			this.line18.Width = 0F;
			this.line18.X1 = 3.11F;
			this.line18.X2 = 3.11F;
			this.line18.Y1 = 2.12F;
			this.line18.Y2 = 2.6F;
			// 
			// label26
			// 
			this.label26.Height = 0.1530001F;
			this.label26.HyperLink = null;
			this.label26.Left = 2.441F;
			this.label26.Name = "label26";
			this.label26.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label26.Text = "新生命保険料の金額";
			this.label26.Top = 2.289F;
			this.label26.Width = 0.6700001F;
			// 
			// label27
			// 
			this.label27.Height = 0.153F;
			this.label27.HyperLink = null;
			this.label27.Left = 2.441F;
			this.label27.Name = "label27";
			this.label27.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label27.Text = "旧生命保険料の金額";
			this.label27.Top = 2.456F;
			this.label27.Width = 0.67F;
			// 
			// line19
			// 
			this.line19.Height = 0.48F;
			this.line19.Left = 2.42F;
			this.line19.LineWeight = 1F;
			this.line19.Name = "line19";
			this.line19.Top = 2.12F;
			this.line19.Width = 0F;
			this.line19.X1 = 2.42F;
			this.line19.X2 = 2.42F;
			this.line19.Y1 = 2.12F;
			this.line19.Y2 = 2.6F;
			// 
			// summary1Digit0Text
			// 
			this.summary1Digit0Text.CanGrow = false;
			this.summary1Digit0Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit0Text.Height = 0.558F;
			this.summary1Digit0Text.Left = 0.208F;
			this.summary1Digit0Text.Name = "summary1Digit0Text";
			this.summary1Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit0Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary1Digit0Text.Top = 2.052F;
			this.summary1Digit0Text.Width = 2.173F;
			// 
			// label6
			// 
			this.label6.Height = 0.153F;
			this.label6.HyperLink = null;
			this.label6.Left = 3.883F;
			this.label6.Name = "label6";
			this.label6.Style = "font-size: 4.75pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label6.Text = "新個人年金保険料の金額";
			this.label6.Top = 6.228F;
			this.label6.Width = 0.755F;
			// 
			// newLifeInsPensAmt1Text
			// 
			this.newLifeInsPensAmt1Text.CanGrow = false;
			this.newLifeInsPensAmt1Text.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.newLifeInsPensAmt1Text.Height = 0.153F;
			this.newLifeInsPensAmt1Text.Left = 4.613F;
			this.newLifeInsPensAmt1Text.Name = "newLifeInsPensAmt1Text";
			this.newLifeInsPensAmt1Text.OutputFormat = "#,##0";
			this.newLifeInsPensAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsPensAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsPensAmt1Text.Top = 6.238F;
			this.newLifeInsPensAmt1Text.Width = 0.647F;
			// 
			// label7
			// 
			this.label7.Height = 0.153F;
			this.label7.HyperLink = null;
			this.label7.Left = 5.26F;
			this.label7.Name = "label7";
			this.label7.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label7.Text = "円";
			this.label7.Top = 6.238F;
			this.label7.Width = 0.125F;
			// 
			// label28
			// 
			this.label28.Height = 0.153F;
			this.label28.HyperLink = null;
			this.label28.Left = 3.883F;
			this.label28.Name = "label28";
			this.label28.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label28.Text = "介護医療保険料の金額";
			this.label28.Top = 6.075F;
			this.label28.Width = 0.755F;
			// 
			// newLifeInsCareAmt1Text
			// 
			this.newLifeInsCareAmt1Text.CanGrow = false;
			this.newLifeInsCareAmt1Text.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.newLifeInsCareAmt1Text.Height = 0.153F;
			this.newLifeInsCareAmt1Text.Left = 4.613F;
			this.newLifeInsCareAmt1Text.Name = "newLifeInsCareAmt1Text";
			this.newLifeInsCareAmt1Text.OutputFormat = "#,##0";
			this.newLifeInsCareAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsCareAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsCareAmt1Text.Top = 6.085F;
			this.newLifeInsCareAmt1Text.Width = 0.647F;
			// 
			// label29
			// 
			this.label29.Height = 0.153F;
			this.label29.HyperLink = null;
			this.label29.Left = 5.26F;
			this.label29.Name = "label29";
			this.label29.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label29.Text = "円";
			this.label29.Top = 6.085F;
			this.label29.Width = 0.125F;
			// 
			// line20
			// 
			this.line20.Height = 0F;
			this.line20.Left = 2.42F;
			this.line20.LineWeight = 1F;
			this.line20.Name = "line20";
			this.line20.Top = 6.38F;
			this.line20.Width = 2.955F;
			this.line20.X1 = 2.42F;
			this.line20.X2 = 5.375F;
			this.line20.Y1 = 6.38F;
			this.line20.Y2 = 6.38F;
			// 
			// line21
			// 
			this.line21.Height = 0.6149998F;
			this.line21.Left = 3.87F;
			this.line21.LineWeight = 1F;
			this.line21.Name = "line21";
			this.line21.Top = 6.085F;
			this.line21.Width = 0F;
			this.line21.X1 = 3.87F;
			this.line21.X2 = 3.87F;
			this.line21.Y1 = 6.085F;
			this.line21.Y2 = 6.7F;
			// 
			// line22
			// 
			this.line22.Height = 0.4699998F;
			this.line22.Left = 3.11F;
			this.line22.LineWeight = 1F;
			this.line22.Name = "line22";
			this.line22.Top = 6.23F;
			this.line22.Width = 0F;
			this.line22.X1 = 3.11F;
			this.line22.X2 = 3.11F;
			this.line22.Y1 = 6.23F;
			this.line22.Y2 = 6.7F;
			// 
			// line23
			// 
			this.line23.Height = 0.4699998F;
			this.line23.Left = 2.42F;
			this.line23.LineWeight = 1F;
			this.line23.Name = "line23";
			this.line23.Top = 6.23F;
			this.line23.Width = 0F;
			this.line23.X1 = 2.42F;
			this.line23.X2 = 2.42F;
			this.line23.Y1 = 6.23F;
			this.line23.Y2 = 6.7F;
			// 
			// label30
			// 
			this.label30.Height = 0.153F;
			this.label30.HyperLink = null;
			this.label30.Left = 2.441F;
			this.label30.Name = "label30";
			this.label30.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label30.Text = "新生命保険料の金額";
			this.label30.Top = 6.388F;
			this.label30.Width = 0.67F;
			// 
			// newLifeInsGeneralAmt1Text
			// 
			this.newLifeInsGeneralAmt1Text.CanGrow = false;
			this.newLifeInsGeneralAmt1Text.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmt1Text.Height = 0.153F;
			this.newLifeInsGeneralAmt1Text.Left = 3.111F;
			this.newLifeInsGeneralAmt1Text.Name = "newLifeInsGeneralAmt1Text";
			this.newLifeInsGeneralAmt1Text.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.newLifeInsGeneralAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmt1Text.Top = 6.393F;
			this.newLifeInsGeneralAmt1Text.Width = 0.647F;
			// 
			// label34
			// 
			this.label34.Height = 0.153F;
			this.label34.HyperLink = null;
			this.label34.Left = 3.758F;
			this.label34.Name = "label34";
			this.label34.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label34.Text = "円";
			this.label34.Top = 6.393F;
			this.label34.Width = 0.125F;
			// 
			// label35
			// 
			this.label35.Height = 0.153F;
			this.label35.HyperLink = null;
			this.label35.Left = 2.441F;
			this.label35.Name = "label35";
			this.label35.Style = "font-size: 5pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label35.Text = "旧生命保険料の金額";
			this.label35.Top = 6.551F;
			this.label35.Width = 0.67F;
			// 
			// lifeInsGeneralAmt1Text
			// 
			this.lifeInsGeneralAmt1Text.CanGrow = false;
			this.lifeInsGeneralAmt1Text.DataField = "LIFE_INS_GENERAL_AMT";
			this.lifeInsGeneralAmt1Text.Height = 0.153F;
			this.lifeInsGeneralAmt1Text.Left = 3.111F;
			this.lifeInsGeneralAmt1Text.Name = "lifeInsGeneralAmt1Text";
			this.lifeInsGeneralAmt1Text.OutputFormat = "#,##0";
			this.lifeInsGeneralAmt1Text.Style = "font-size: 6.8pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.lifeInsGeneralAmt1Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.lifeInsGeneralAmt1Text.Top = 6.551F;
			this.lifeInsGeneralAmt1Text.Width = 0.647F;
			// 
			// label36
			// 
			this.label36.Height = 0.153F;
			this.label36.HyperLink = null;
			this.label36.Left = 3.758F;
			this.label36.Name = "label36";
			this.label36.Style = "font-size: 6pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.label36.Text = "円";
			this.label36.Top = 6.551F;
			this.label36.Width = 0.125F;
			// 
			// summary1Digit1Text
			// 
			this.summary1Digit1Text.CanGrow = false;
			this.summary1Digit1Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit1Text.Height = 0.558F;
			this.summary1Digit1Text.Left = 0.208F;
			this.summary1Digit1Text.Name = "summary1Digit1Text";
			this.summary1Digit1Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあ" +
    "いうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary1Digit1Text.Top = 6.154F;
			this.summary1Digit1Text.Width = 2.173F;
			// 
			// HR_PY_03_R64
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
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R64_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.label17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1063)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1055)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.class1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label138)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTax1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExeist1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExeist2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label156)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tagePreNum1Tex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label159)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtHandiNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label167)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label168)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handiNum1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label169)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label170)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label172)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label173)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.housingObtDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label178)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label179)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposSumINcmAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label181)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsPensAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label182)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label213)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label215)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label216)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label217)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label218)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label219)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label223)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label226)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latter1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handiType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label227)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label228)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label229)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddress1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label230)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhone1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label231)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label232)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label234)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label236)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label237)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label238)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label239)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label240)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label241)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label242)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label243)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label244)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label245)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label246)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label270)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYear1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateMonth1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label271)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label272)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label273)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label274)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label275)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraM1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraT1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraS1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraH1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYear1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonth1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDay1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label703)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label704)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label705)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label991)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label992)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label993)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label994)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label995)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label996)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label997)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label998)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label999)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1000)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1001)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1002)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1003)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1004)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1005)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1006)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1007)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1008)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1009)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1010)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1011)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1012)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1013)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1014)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1015)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposNText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposN2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1016)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1017)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1018)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1019)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1020)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1021)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1022)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1023)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1024)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1025)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1026)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1027)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1028)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1029)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1030)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1031)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1032)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1033)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1034)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1035)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1036)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1037)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1038)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1039)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1040)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1041)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1042)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1044)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1045)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1046)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1047)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1048)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1049)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1051)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1052)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1053)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1054)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1059)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1062)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1065)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1067)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1068)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1069)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1070)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1071)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1072)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1073)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1074)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1075)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1076)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1077)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1078)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1079)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1080)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1081)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1082)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1084)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1085)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1086)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1087)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1088)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1089)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1090)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1091)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1092)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1093)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1094)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1095)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1116)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1117)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1118)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1119)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1120)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1121)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraMText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraTText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraSText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraHText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1134)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1595)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1596)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary2Digit1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmt1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
