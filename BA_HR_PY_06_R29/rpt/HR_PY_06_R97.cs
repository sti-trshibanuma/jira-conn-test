// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 06
// File Name   : HR_PY_06_R97.cs
// 機能名      : HR_PY_06_R97 賃金台帳兼源泉徴収簿(サブレポート)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K24565 2012/10/03 ActiveReportsバージョンアップ対応
// 2.0.0 2012/10/31
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30
// 3.1.0 2020/06/30
// 管理番号K27274 2021/06/11 年末調整関連法改正(令和２年)
// 3.2.0 2023/03/31
// 管理番号K27665 2023/07/11 ActiveReportsバージョンアップ（SP4）対応

using System;
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_06_R97 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_06_R97()
		{


			InitializeComponent();
		}

		#region Protected Fields
		private const string TAX_REVISION_YEAR = "2006";
		private const string EARTHQUAKE_INSURANCE_DED = "地震保険控除";
		private const string H23_TAX_REVISION_YEAR = "2011";
		//平成24年以後の所得税改正（介護医療保険控除創設）の西暦年
		private const string TAX_REVISION_CARE_YEAR = "2012";
		protected string reportID;
		protected string companyName;
		protected CommonData cd;

		double paymntTotal1Amt7 = 0;
		double paymntTotal1Amt8 = 0;
		double paymntTotal1Amt9 = 0;
		double paymntTotal1Amt10 = 0;
		double paymntTotal1Amt11 = 0;
		double paymntTotal1Amt12 = 0;
		double dedTotal1Amt7 = 0;
		double dedTotal1Amt8 = 0;
		double dedTotal1Amt9 = 0;
		double dedTotal1Amt10 = 0;
		double dedTotal1Amt11 = 0;
		double dedTotal1Amt12 = 0;
		double paymntTotal2Amt7 = 0;
		double paymntTotal2Amt8 = 0;
		double paymntTotal2Amt9 = 0;
		double paymntTotal2Amt10 = 0;
		double paymntTotal2Amt11 = 0;
		double paymntTotal2Amt12 = 0;
		double dedTotal2Amt7 = 0;
		double dedTotal2Amt8 = 0;
		double dedTotal2Amt9 = 0;
		double dedTotal2Amt10 = 0;
		double dedTotal2Amt11 = 0;
		double dedTotal2Amt12 = 0;
		double paymntTotal3Amt7 = 0;
		double paymntTotal3Amt8 = 0;
		double paymntTotal3Amt9 = 0;
		double paymntTotal3Amt10 = 0;
		double paymntTotal3Amt11 = 0;
		double paymntTotal3Amt12 = 0;
		double paymntTotal4Amt7 = 0;
		double paymntTotal4Amt8 = 0;
		double paymntTotal4Amt9 = 0;
		double paymntTotal4Amt10 = 0;
		double paymntTotal4Amt11 = 0;
		double paymntTotal4Amt12 = 0;
		double dedTotal3Amt7 = 0;
		double dedTotal3Amt8 = 0;
		double dedTotal3Amt9 = 0;
		double dedTotal3Amt10 = 0;
		double dedTotal3Amt11 = 0;
		double dedTotal3Amt12 = 0;
		double dedTotal4Amt7 = 0;
		double dedTotal4Amt8 = 0;
		double dedTotal4Amt9 = 0;
		double dedTotal4Amt10 = 0;
		double dedTotal4Amt11 = 0;
		double dedTotal4Amt12 = 0;
		bool paymntTotal1Amt7Flg = false;	// 支給合計1項目7出力フラグ
		bool paymntTotal1Amt8Flg = false;	// 支給合計1項目8出力フラグ
		bool paymntTotal1Amt9Flg = false;	// 支給合計1項目9出力フラグ
		bool paymntTotal1Amt10Flg = false;	// 支給合計1項目10出力フラグ
		bool paymntTotal1Amt11Flg = false;	// 支給合計1項目11出力フラグ
		bool paymntTotal1Amt12Flg = false;	// 支給合計1項目12出力フラグ
		bool dedTotal1Amt7Flg = false;		// 支給合計1項目7出力フラグ
		bool dedTotal1Amt8Flg = false;		// 支給合計1項目8出力フラグ
		bool dedTotal1Amt9Flg = false;		// 支給合計1項目9出力フラグ
		bool dedTotal1Amt10Flg = false;		// 支給合計1項目10出力フラグ
		bool dedTotal1Amt11Flg = false;		// 支給合計1項目11出力フラグ
		bool dedTotal1Amt12Flg = false;		// 支給合計1項目12出力フラグ

		bool paymntTotal2Amt7Flg = false;	// 支給合計2項目7出力フラグ
		bool paymntTotal2Amt8Flg = false;	// 支給合計2項目8出力フラグ
		bool paymntTotal2Amt9Flg = false;	// 支給合計2項目9出力フラグ
		bool paymntTotal2Amt10Flg = false;	// 支給合計2項目10出力フラグ
		bool paymntTotal2Amt11Flg = false;	// 支給合計2項目11出力フラグ
		bool paymntTotal2Amt12Flg = false;	// 支給合計2項目12出力フラグ
		bool dedTotal2Amt7Flg = false;		// 支給合計2項目7出力フラグ
		bool dedTotal2Amt8Flg = false;		// 支給合計2項目8出力フラグ
		bool dedTotal2Amt9Flg = false;		// 支給合計2項目9出力フラグ
		bool dedTotal2Amt10Flg = false;		// 支給合計2項目10出力フラグ
		bool dedTotal2Amt11Flg = false;		// 支給合計2項目11出力フラグ
		bool dedTotal2Amt12Flg = false;		// 支給合計2項目12出力フラグ

		bool paymntTotal3Amt7Flg = false;	// 支給合計3項目7出力フラグ
		bool paymntTotal3Amt8Flg = false;	// 支給合計3項目8出力フラグ
		bool paymntTotal3Amt9Flg = false;	// 支給合計3項目9出力フラグ
		bool paymntTotal3Amt10Flg = false;	// 支給合計3項目10出力フラグ
		bool paymntTotal3Amt11Flg = false;	// 支給合計3項目11出力フラグ
		bool paymntTotal3Amt12Flg = false;	// 支給合計2項目12出力フラグ
		bool dedTotal3Amt7Flg = false;		// 支給合計3項目7出力フラグ
		bool dedTotal3Amt8Flg = false;		// 支給合計3項目8出力フラグ
		bool dedTotal3Amt9Flg = false;		// 支給合計3項目9出力フラグ
		bool dedTotal3Amt10Flg = false;		// 支給合計3項目10出力フラグ
		bool dedTotal3Amt11Flg = false;
		private Line Line313;
		private Line Line387;
		private Line Line389;
		private GroupHeader GroupHeader1;
		private GroupFooter GroupFooter1;
		private TextBox PaymntName7;		// 支給合計3項目11出力フラグ
		bool dedTotal3Amt12Flg = false;		// 支給合計3項目12出力フラグ

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

		private void HR_PY_06_R97_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;

			// 制御用の値をコントロールに設定
			PaymntDispType7.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE7"].ToString();
			PaymntDispType8.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE8"].ToString();
			PaymntDispType9.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE9"].ToString();
			PaymntDispType10.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE10"].ToString();
			PaymntDispType11.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE11"].ToString();
			PaymntDispType12.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_DISP_TYPE12"].ToString();

			PaymntBnsDispType7.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE7"].ToString();
			PaymntBnsDispType8.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE8"].ToString();
			PaymntBnsDispType9.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE9"].ToString();
			PaymntBnsDispType10.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE10"].ToString();
			PaymntBnsDispType11.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE11"].ToString();
			PaymntBnsDispType12.Text = ((System.Data.DataRow[])(DataSource))[0]["PAYMNT_BNS_DISP_TYPE12"].ToString();

			DedDispType7.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE7"].ToString();
			DedDispType8.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE8"].ToString();
			DedDispType9.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE9"].ToString();
			DedDispType10.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE10"].ToString();
			DedDispType11.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE11"].ToString();
			DedDispType12.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_DISP_TYPE12"].ToString();

			DedBnsDispType7.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE7"].ToString();
			DedBnsDispType8.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE8"].ToString();
			DedBnsDispType9.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE9"].ToString();
			DedBnsDispType10.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE10"].ToString();
			DedBnsDispType11.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE11"].ToString();
			DedBnsDispType12.Text = ((System.Data.DataRow[])(DataSource))[0]["DED_BNS_DISP_TYPE12"].ToString();

			if (PaymntDispType7.Text == "2")
			{
				Paymnt1Amt7.OutputFormat = "###0";
				Paymnt2Amt7.OutputFormat = "###0";
				Paymnt3Amt7.OutputFormat = "###0";
				Paymnt4Amt7.OutputFormat = "###0";
				Paymnt5Amt7.OutputFormat = "###0";
				Paymnt6Amt7.OutputFormat = "###0";
				Paymnt7Amt7.OutputFormat = "###0";
				Paymnt8Amt7.OutputFormat = "###0";
				Paymnt9Amt7.OutputFormat = "###0";
				Paymnt10Amt7.OutputFormat = "###0";
				Paymnt11Amt7.OutputFormat = "###0";
				Paymnt12Amt7.OutputFormat = "###0";
				PaymntTotal1Amt7.OutputFormat = "###0";
				Paymnt13Amt7.OutputFormat = "###0";
				Paymnt14Amt7.OutputFormat = "###0";
				Paymnt15Amt7.OutputFormat = "###0";
				Paymnt16Amt7.OutputFormat = "###0";
				PaymntTotal2Amt7.OutputFormat = "###0";
				Paymnt17Amt7.OutputFormat = "###0";
				PaymntTotal3Amt7.OutputFormat = "###0";
			}

			else if (PaymntDispType7.Text == "3")
			{
				Paymnt1Amt7.OutputFormat = "#,##0.00";
				Paymnt2Amt7.OutputFormat = "#,##0.00";
				Paymnt3Amt7.OutputFormat = "#,##0.00";
				Paymnt4Amt7.OutputFormat = "#,##0.00";
				Paymnt5Amt7.OutputFormat = "#,##0.00";
				Paymnt6Amt7.OutputFormat = "#,##0.00";
				Paymnt7Amt7.OutputFormat = "#,##0.00";
				Paymnt8Amt7.OutputFormat = "#,##0.00";
				Paymnt9Amt7.OutputFormat = "#,##0.00";
				Paymnt10Amt7.OutputFormat = "#,##0.00";
				Paymnt11Amt7.OutputFormat = "#,##0.00";
				Paymnt12Amt7.OutputFormat = "#,##0.00";
				PaymntTotal1Amt7.OutputFormat = "#,##0.00";
				Paymnt13Amt7.OutputFormat = "#,##0.00";
				Paymnt14Amt7.OutputFormat = "#,##0.00";
				Paymnt15Amt7.OutputFormat = "#,##0.00";
				Paymnt16Amt7.OutputFormat = "#,##0.00";
				PaymntTotal2Amt7.OutputFormat = "#,##0.00";
				Paymnt17Amt7.OutputFormat = "#,##0.00";
				PaymntTotal3Amt7.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType7.Text == "4")
			{
				Paymnt1Amt7.OutputFormat = "###0.00";
				Paymnt2Amt7.OutputFormat = "###0.00";
				Paymnt3Amt7.OutputFormat = "###0.00";
				Paymnt4Amt7.OutputFormat = "###0.00";
				Paymnt5Amt7.OutputFormat = "###0.00";
				Paymnt6Amt7.OutputFormat = "###0.00";
				Paymnt7Amt7.OutputFormat = "###0.00";
				Paymnt8Amt7.OutputFormat = "###0.00";
				Paymnt9Amt7.OutputFormat = "###0.00";
				Paymnt10Amt7.OutputFormat = "###0.00";
				Paymnt11Amt7.OutputFormat = "###0.00";
				Paymnt12Amt7.OutputFormat = "###0.00";
				PaymntTotal1Amt7.OutputFormat = "###0.00";
				Paymnt13Amt7.OutputFormat = "###0.00";
				Paymnt14Amt7.OutputFormat = "###0.00";
				Paymnt15Amt7.OutputFormat = "###0.00";
				Paymnt16Amt7.OutputFormat = "###0.00";
				PaymntTotal2Amt7.OutputFormat = "###0.00";
				Paymnt17Amt7.OutputFormat = "###0.00";
				PaymntTotal3Amt7.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt7.OutputFormat = "#,##0";
				Paymnt2Amt7.OutputFormat = "#,##0";
				Paymnt3Amt7.OutputFormat = "#,##0";
				Paymnt4Amt7.OutputFormat = "#,##0";
				Paymnt5Amt7.OutputFormat = "#,##0";
				Paymnt6Amt7.OutputFormat = "#,##0";
				Paymnt7Amt7.OutputFormat = "#,##0";
				Paymnt8Amt7.OutputFormat = "#,##0";
				Paymnt9Amt7.OutputFormat = "#,##0";
				Paymnt10Amt7.OutputFormat = "#,##0";
				Paymnt11Amt7.OutputFormat = "#,##0";
				Paymnt12Amt7.OutputFormat = "#,##0";
				PaymntTotal1Amt7.OutputFormat = "#,##0";
				Paymnt13Amt7.OutputFormat = "#,##0";
				Paymnt14Amt7.OutputFormat = "#,##0";
				Paymnt15Amt7.OutputFormat = "#,##0";
				Paymnt16Amt7.OutputFormat = "#,##0";
				PaymntTotal2Amt7.OutputFormat = "#,##0";
				Paymnt17Amt7.OutputFormat = "#,##0";
				PaymntTotal3Amt7.OutputFormat = "#,##0";
			}

			if (PaymntDispType8.Text == "2")
			{
				Paymnt1Amt8.OutputFormat = "###0";
				Paymnt2Amt8.OutputFormat = "###0";
				Paymnt3Amt8.OutputFormat = "###0";
				Paymnt4Amt8.OutputFormat = "###0";
				Paymnt5Amt8.OutputFormat = "###0";
				Paymnt6Amt8.OutputFormat = "###0";
				Paymnt7Amt8.OutputFormat = "###0";
				Paymnt8Amt8.OutputFormat = "###0";
				Paymnt9Amt8.OutputFormat = "###0";
				Paymnt10Amt8.OutputFormat = "###0";
				Paymnt11Amt8.OutputFormat = "###0";
				Paymnt12Amt8.OutputFormat = "###0";
				PaymntTotal1Amt8.OutputFormat = "###0";
				Paymnt13Amt8.OutputFormat = "###0";
				Paymnt14Amt8.OutputFormat = "###0";
				Paymnt15Amt8.OutputFormat = "###0";
				Paymnt16Amt8.OutputFormat = "###0";
				PaymntTotal2Amt8.OutputFormat = "###0";
				Paymnt17Amt8.OutputFormat = "###0";
				PaymntTotal3Amt8.OutputFormat = "###0";
			}

			else if (PaymntDispType8.Text == "3")
			{
				Paymnt1Amt8.OutputFormat = "#,##0.00";
				Paymnt2Amt8.OutputFormat = "#,##0.00";
				Paymnt3Amt8.OutputFormat = "#,##0.00";
				Paymnt4Amt8.OutputFormat = "#,##0.00";
				Paymnt5Amt8.OutputFormat = "#,##0.00";
				Paymnt6Amt8.OutputFormat = "#,##0.00";
				Paymnt7Amt8.OutputFormat = "#,##0.00";
				Paymnt8Amt8.OutputFormat = "#,##0.00";
				Paymnt9Amt8.OutputFormat = "#,##0.00";
				Paymnt10Amt8.OutputFormat = "#,##0.00";
				Paymnt11Amt8.OutputFormat = "#,##0.00";
				Paymnt12Amt8.OutputFormat = "#,##0.00";
				PaymntTotal1Amt8.OutputFormat = "#,##0.00";
				Paymnt13Amt8.OutputFormat = "#,##0.00";
				Paymnt14Amt8.OutputFormat = "#,##0.00";
				Paymnt15Amt8.OutputFormat = "#,##0.00";
				Paymnt16Amt8.OutputFormat = "#,##0.00";
				PaymntTotal2Amt8.OutputFormat = "#,##0.00";
				Paymnt17Amt8.OutputFormat = "#,##0.00";
				PaymntTotal3Amt8.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType8.Text == "4")
			{
				Paymnt1Amt8.OutputFormat = "###0.00";
				Paymnt2Amt8.OutputFormat = "###0.00";
				Paymnt3Amt8.OutputFormat = "###0.00";
				Paymnt4Amt8.OutputFormat = "###0.00";
				Paymnt5Amt8.OutputFormat = "###0.00";
				Paymnt6Amt8.OutputFormat = "###0.00";
				Paymnt7Amt8.OutputFormat = "###0.00";
				Paymnt8Amt8.OutputFormat = "###0.00";
				Paymnt9Amt8.OutputFormat = "###0.00";
				Paymnt10Amt8.OutputFormat = "###0.00";
				Paymnt11Amt8.OutputFormat = "###0.00";
				Paymnt12Amt8.OutputFormat = "###0.00";
				PaymntTotal1Amt8.OutputFormat = "###0.00";
				Paymnt13Amt8.OutputFormat = "###0.00";
				Paymnt14Amt8.OutputFormat = "###0.00";
				Paymnt15Amt8.OutputFormat = "###0.00";
				Paymnt16Amt8.OutputFormat = "###0.00";
				PaymntTotal2Amt8.OutputFormat = "###0.00";
				Paymnt17Amt8.OutputFormat = "###0.00";
				PaymntTotal3Amt8.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt8.OutputFormat = "#,##0";
				Paymnt2Amt8.OutputFormat = "#,##0";
				Paymnt3Amt8.OutputFormat = "#,##0";
				Paymnt4Amt8.OutputFormat = "#,##0";
				Paymnt5Amt8.OutputFormat = "#,##0";
				Paymnt6Amt8.OutputFormat = "#,##0";
				Paymnt7Amt8.OutputFormat = "#,##0";
				Paymnt8Amt8.OutputFormat = "#,##0";
				Paymnt9Amt8.OutputFormat = "#,##0";
				Paymnt10Amt8.OutputFormat = "#,##0";
				Paymnt11Amt8.OutputFormat = "#,##0";
				Paymnt12Amt8.OutputFormat = "#,##0";
				PaymntTotal1Amt8.OutputFormat = "#,##0";
				Paymnt13Amt8.OutputFormat = "#,##0";
				Paymnt14Amt8.OutputFormat = "#,##0";
				Paymnt15Amt8.OutputFormat = "#,##0";
				Paymnt16Amt8.OutputFormat = "#,##0";
				PaymntTotal2Amt8.OutputFormat = "#,##0";
				Paymnt17Amt8.OutputFormat = "#,##0";
				PaymntTotal3Amt8.OutputFormat = "#,##0";
			}

			if (PaymntDispType9.Text == "2")
			{
				Paymnt1Amt9.OutputFormat = "###0";
				Paymnt2Amt9.OutputFormat = "###0";
				Paymnt3Amt9.OutputFormat = "###0";
				Paymnt4Amt9.OutputFormat = "###0";
				Paymnt5Amt9.OutputFormat = "###0";
				Paymnt6Amt9.OutputFormat = "###0";
				Paymnt7Amt9.OutputFormat = "###0";
				Paymnt8Amt9.OutputFormat = "###0";
				Paymnt9Amt9.OutputFormat = "###0";
				Paymnt10Amt9.OutputFormat = "###0";
				Paymnt11Amt9.OutputFormat = "###0";
				Paymnt12Amt9.OutputFormat = "###0";
				PaymntTotal1Amt9.OutputFormat = "###0";
				Paymnt13Amt9.OutputFormat = "###0";
				Paymnt14Amt9.OutputFormat = "###0";
				Paymnt15Amt9.OutputFormat = "###0";
				Paymnt16Amt9.OutputFormat = "###0";
				PaymntTotal2Amt9.OutputFormat = "###0";
				Paymnt17Amt9.OutputFormat = "###0";
				PaymntTotal3Amt9.OutputFormat = "###0";
			}

			else if (PaymntDispType9.Text == "3")
			{
				Paymnt1Amt9.OutputFormat = "#,##0.00";
				Paymnt2Amt9.OutputFormat = "#,##0.00";
				Paymnt3Amt9.OutputFormat = "#,##0.00";
				Paymnt4Amt9.OutputFormat = "#,##0.00";
				Paymnt5Amt9.OutputFormat = "#,##0.00";
				Paymnt6Amt9.OutputFormat = "#,##0.00";
				Paymnt7Amt9.OutputFormat = "#,##0.00";
				Paymnt8Amt9.OutputFormat = "#,##0.00";
				Paymnt9Amt9.OutputFormat = "#,##0.00";
				Paymnt10Amt9.OutputFormat = "#,##0.00";
				Paymnt11Amt9.OutputFormat = "#,##0.00";
				Paymnt12Amt9.OutputFormat = "#,##0.00";
				PaymntTotal1Amt9.OutputFormat = "#,##0.00";
				Paymnt13Amt9.OutputFormat = "#,##0.00";
				Paymnt14Amt9.OutputFormat = "#,##0.00";
				Paymnt15Amt9.OutputFormat = "#,##0.00";
				Paymnt16Amt9.OutputFormat = "#,##0.00";
				PaymntTotal2Amt9.OutputFormat = "#,##0.00";
				Paymnt17Amt9.OutputFormat = "#,##0.00";
				PaymntTotal3Amt9.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType9.Text == "4")
			{
				Paymnt1Amt9.OutputFormat = "###0.00";
				Paymnt2Amt9.OutputFormat = "###0.00";
				Paymnt3Amt9.OutputFormat = "###0.00";
				Paymnt4Amt9.OutputFormat = "###0.00";
				Paymnt5Amt9.OutputFormat = "###0.00";
				Paymnt6Amt9.OutputFormat = "###0.00";
				Paymnt7Amt9.OutputFormat = "###0.00";
				Paymnt8Amt9.OutputFormat = "###0.00";
				Paymnt9Amt9.OutputFormat = "###0.00";
				Paymnt10Amt9.OutputFormat = "###0.00";
				Paymnt11Amt9.OutputFormat = "###0.00";
				Paymnt12Amt9.OutputFormat = "###0.00";
				PaymntTotal1Amt9.OutputFormat = "###0.00";
				Paymnt13Amt9.OutputFormat = "###0.00";
				Paymnt14Amt9.OutputFormat = "###0.00";
				Paymnt15Amt9.OutputFormat = "###0.00";
				Paymnt16Amt9.OutputFormat = "###0.00";
				PaymntTotal2Amt9.OutputFormat = "###0.00";
				Paymnt17Amt9.OutputFormat = "###0.00";
				PaymntTotal3Amt9.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt9.OutputFormat = "#,##0";
				Paymnt2Amt9.OutputFormat = "#,##0";
				Paymnt3Amt9.OutputFormat = "#,##0";
				Paymnt4Amt9.OutputFormat = "#,##0";
				Paymnt5Amt9.OutputFormat = "#,##0";
				Paymnt6Amt9.OutputFormat = "#,##0";
				Paymnt7Amt9.OutputFormat = "#,##0";
				Paymnt8Amt9.OutputFormat = "#,##0";
				Paymnt9Amt9.OutputFormat = "#,##0";
				Paymnt10Amt9.OutputFormat = "#,##0";
				Paymnt11Amt9.OutputFormat = "#,##0";
				Paymnt12Amt9.OutputFormat = "#,##0";
				PaymntTotal1Amt9.OutputFormat = "#,##0";
				Paymnt13Amt9.OutputFormat = "#,##0";
				Paymnt14Amt9.OutputFormat = "#,##0";
				Paymnt15Amt9.OutputFormat = "#,##0";
				Paymnt16Amt9.OutputFormat = "#,##0";
				PaymntTotal2Amt9.OutputFormat = "#,##0";
				Paymnt17Amt9.OutputFormat = "#,##0";
				PaymntTotal3Amt9.OutputFormat = "#,##0";
			}

			if (PaymntDispType10.Text == "2")
			{
				Paymnt1Amt10.OutputFormat = "###0";
				Paymnt2Amt10.OutputFormat = "###0";
				Paymnt3Amt10.OutputFormat = "###0";
				Paymnt4Amt10.OutputFormat = "###0";
				Paymnt5Amt10.OutputFormat = "###0";
				Paymnt6Amt10.OutputFormat = "###0";
				Paymnt7Amt10.OutputFormat = "###0";
				Paymnt8Amt10.OutputFormat = "###0";
				Paymnt9Amt10.OutputFormat = "###0";
				Paymnt10Amt10.OutputFormat = "###0";
				Paymnt11Amt10.OutputFormat = "###0";
				Paymnt12Amt10.OutputFormat = "###0";
				PaymntTotal1Amt10.OutputFormat = "###0";
				Paymnt13Amt10.OutputFormat = "###0";
				Paymnt14Amt10.OutputFormat = "###0";
				Paymnt15Amt10.OutputFormat = "###0";
				Paymnt16Amt10.OutputFormat = "###0";
				PaymntTotal2Amt10.OutputFormat = "###0";
				Paymnt17Amt10.OutputFormat = "###0";
				PaymntTotal3Amt10.OutputFormat = "###0";
			}

			else if (PaymntDispType10.Text == "3")
			{
				Paymnt1Amt10.OutputFormat = "#,##0.00";
				Paymnt2Amt10.OutputFormat = "#,##0.00";
				Paymnt3Amt10.OutputFormat = "#,##0.00";
				Paymnt4Amt10.OutputFormat = "#,##0.00";
				Paymnt5Amt10.OutputFormat = "#,##0.00";
				Paymnt6Amt10.OutputFormat = "#,##0.00";
				Paymnt7Amt10.OutputFormat = "#,##0.00";
				Paymnt8Amt10.OutputFormat = "#,##0.00";
				Paymnt9Amt10.OutputFormat = "#,##0.00";
				Paymnt10Amt10.OutputFormat = "#,##0.00";
				Paymnt11Amt10.OutputFormat = "#,##0.00";
				Paymnt12Amt10.OutputFormat = "#,##0.00";
				PaymntTotal1Amt10.OutputFormat = "#,##0.00";
				Paymnt13Amt10.OutputFormat = "#,##0.00";
				Paymnt14Amt10.OutputFormat = "#,##0.00";
				Paymnt15Amt10.OutputFormat = "#,##0.00";
				Paymnt16Amt10.OutputFormat = "#,##0.00";
				PaymntTotal2Amt10.OutputFormat = "#,##0.00";
				Paymnt17Amt10.OutputFormat = "#,##0.00";
				PaymntTotal3Amt10.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType10.Text == "4")
			{
				Paymnt1Amt10.OutputFormat = "###0.00";
				Paymnt2Amt10.OutputFormat = "###0.00";
				Paymnt3Amt10.OutputFormat = "###0.00";
				Paymnt4Amt10.OutputFormat = "###0.00";
				Paymnt5Amt10.OutputFormat = "###0.00";
				Paymnt6Amt10.OutputFormat = "###0.00";
				Paymnt7Amt10.OutputFormat = "###0.00";
				Paymnt8Amt10.OutputFormat = "###0.00";
				Paymnt9Amt10.OutputFormat = "###0.00";
				Paymnt10Amt10.OutputFormat = "###0.00";
				Paymnt11Amt10.OutputFormat = "###0.00";
				Paymnt12Amt10.OutputFormat = "###0.00";
				PaymntTotal1Amt10.OutputFormat = "###0.00";
				Paymnt13Amt10.OutputFormat = "###0.00";
				Paymnt14Amt10.OutputFormat = "###0.00";
				Paymnt15Amt10.OutputFormat = "###0.00";
				Paymnt16Amt10.OutputFormat = "###0.00";
				PaymntTotal2Amt10.OutputFormat = "###0.00";
				Paymnt17Amt10.OutputFormat = "###0.00";
				PaymntTotal3Amt10.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt10.OutputFormat = "#,##0";
				Paymnt2Amt10.OutputFormat = "#,##0";
				Paymnt3Amt10.OutputFormat = "#,##0";
				Paymnt4Amt10.OutputFormat = "#,##0";
				Paymnt5Amt10.OutputFormat = "#,##0";
				Paymnt6Amt10.OutputFormat = "#,##0";
				Paymnt7Amt10.OutputFormat = "#,##0";
				Paymnt8Amt10.OutputFormat = "#,##0";
				Paymnt9Amt10.OutputFormat = "#,##0";
				Paymnt10Amt10.OutputFormat = "#,##0";
				Paymnt11Amt10.OutputFormat = "#,##0";
				Paymnt12Amt10.OutputFormat = "#,##0";
				PaymntTotal1Amt10.OutputFormat = "#,##0";
				Paymnt13Amt10.OutputFormat = "#,##0";
				Paymnt14Amt10.OutputFormat = "#,##0";
				Paymnt15Amt10.OutputFormat = "#,##0";
				Paymnt16Amt10.OutputFormat = "#,##0";
				PaymntTotal2Amt10.OutputFormat = "#,##0";
				Paymnt17Amt10.OutputFormat = "#,##0";
				PaymntTotal3Amt10.OutputFormat = "#,##0";
			}

			if (PaymntDispType11.Text == "2")
			{
				Paymnt1Amt11.OutputFormat = "###0";
				Paymnt2Amt11.OutputFormat = "###0";
				Paymnt3Amt11.OutputFormat = "###0";
				Paymnt4Amt11.OutputFormat = "###0";
				Paymnt5Amt11.OutputFormat = "###0";
				Paymnt6Amt11.OutputFormat = "###0";
				Paymnt7Amt11.OutputFormat = "###0";
				Paymnt8Amt11.OutputFormat = "###0";
				Paymnt9Amt11.OutputFormat = "###0";
				Paymnt10Amt11.OutputFormat = "###0";
				Paymnt11Amt11.OutputFormat = "###0";
				Paymnt12Amt11.OutputFormat = "###0";
				PaymntTotal1Amt11.OutputFormat = "###0";
				Paymnt13Amt11.OutputFormat = "###0";
				Paymnt14Amt11.OutputFormat = "###0";
				Paymnt15Amt11.OutputFormat = "###0";
				Paymnt16Amt11.OutputFormat = "###0";
				PaymntTotal2Amt11.OutputFormat = "###0";
				Paymnt17Amt11.OutputFormat = "###0";
				PaymntTotal3Amt11.OutputFormat = "###0";
			}

			else if (PaymntDispType11.Text == "3")
			{
				Paymnt1Amt11.OutputFormat = "#,##0.00";
				Paymnt2Amt11.OutputFormat = "#,##0.00";
				Paymnt3Amt11.OutputFormat = "#,##0.00";
				Paymnt4Amt11.OutputFormat = "#,##0.00";
				Paymnt5Amt11.OutputFormat = "#,##0.00";
				Paymnt6Amt11.OutputFormat = "#,##0.00";
				Paymnt7Amt11.OutputFormat = "#,##0.00";
				Paymnt8Amt11.OutputFormat = "#,##0.00";
				Paymnt9Amt11.OutputFormat = "#,##0.00";
				Paymnt10Amt11.OutputFormat = "#,##0.00";
				Paymnt11Amt11.OutputFormat = "#,##0.00";
				Paymnt12Amt11.OutputFormat = "#,##0.00";
				PaymntTotal1Amt11.OutputFormat = "#,##0.00";
				Paymnt13Amt11.OutputFormat = "#,##0.00";
				Paymnt14Amt11.OutputFormat = "#,##0.00";
				Paymnt15Amt11.OutputFormat = "#,##0.00";
				Paymnt16Amt11.OutputFormat = "#,##0.00";
				PaymntTotal2Amt11.OutputFormat = "#,##0.00";
				Paymnt17Amt11.OutputFormat = "#,##0.00";
				PaymntTotal3Amt11.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType11.Text == "4")
			{
				Paymnt1Amt11.OutputFormat = "###0.00";
				Paymnt2Amt11.OutputFormat = "###0.00";
				Paymnt3Amt11.OutputFormat = "###0.00";
				Paymnt4Amt11.OutputFormat = "###0.00";
				Paymnt5Amt11.OutputFormat = "###0.00";
				Paymnt6Amt11.OutputFormat = "###0.00";
				Paymnt7Amt11.OutputFormat = "###0.00";
				Paymnt8Amt11.OutputFormat = "###0.00";
				Paymnt9Amt11.OutputFormat = "###0.00";
				Paymnt10Amt11.OutputFormat = "###0.00";
				Paymnt11Amt11.OutputFormat = "###0.00";
				Paymnt12Amt11.OutputFormat = "###0.00";
				PaymntTotal1Amt11.OutputFormat = "###0.00";
				Paymnt13Amt11.OutputFormat = "###0.00";
				Paymnt14Amt11.OutputFormat = "###0.00";
				Paymnt15Amt11.OutputFormat = "###0.00";
				Paymnt16Amt11.OutputFormat = "###0.00";
				PaymntTotal2Amt11.OutputFormat = "###0.00";
				Paymnt17Amt11.OutputFormat = "###0.00";
				PaymntTotal3Amt11.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt11.OutputFormat = "#,##0";
				Paymnt2Amt11.OutputFormat = "#,##0";
				Paymnt3Amt11.OutputFormat = "#,##0";
				Paymnt4Amt11.OutputFormat = "#,##0";
				Paymnt5Amt11.OutputFormat = "#,##0";
				Paymnt6Amt11.OutputFormat = "#,##0";
				Paymnt7Amt11.OutputFormat = "#,##0";
				Paymnt8Amt11.OutputFormat = "#,##0";
				Paymnt9Amt11.OutputFormat = "#,##0";
				Paymnt10Amt11.OutputFormat = "#,##0";
				Paymnt11Amt11.OutputFormat = "#,##0";
				Paymnt12Amt11.OutputFormat = "#,##0";
				PaymntTotal1Amt11.OutputFormat = "#,##0";
				Paymnt13Amt11.OutputFormat = "#,##0";
				Paymnt14Amt11.OutputFormat = "#,##0";
				Paymnt15Amt11.OutputFormat = "#,##0";
				Paymnt16Amt11.OutputFormat = "#,##0";
				PaymntTotal2Amt11.OutputFormat = "#,##0";
				Paymnt17Amt11.OutputFormat = "#,##0";
				PaymntTotal3Amt11.OutputFormat = "#,##0";
			}

			if (PaymntDispType12.Text == "2")
			{
				Paymnt1Amt12.OutputFormat = "###0";
				Paymnt2Amt12.OutputFormat = "###0";
				Paymnt3Amt12.OutputFormat = "###0";
				Paymnt4Amt12.OutputFormat = "###0";
				Paymnt5Amt12.OutputFormat = "###0";
				Paymnt6Amt12.OutputFormat = "###0";
				Paymnt7Amt12.OutputFormat = "###0";
				Paymnt8Amt12.OutputFormat = "###0";
				Paymnt9Amt12.OutputFormat = "###0";
				Paymnt10Amt12.OutputFormat = "###0";
				Paymnt11Amt12.OutputFormat = "###0";
				Paymnt12Amt12.OutputFormat = "###0";
				PaymntTotal1Amt12.OutputFormat = "###0";
				Paymnt13Amt12.OutputFormat = "###0";
				Paymnt14Amt12.OutputFormat = "###0";
				Paymnt15Amt12.OutputFormat = "###0";
				Paymnt16Amt12.OutputFormat = "###0";
				PaymntTotal2Amt12.OutputFormat = "###0";
				Paymnt17Amt12.OutputFormat = "###0";
				PaymntTotal3Amt12.OutputFormat = "###0";

				Paymnt18Amt7.OutputFormat = "###0";
				Paymnt18Amt8.OutputFormat = "###0";
				Paymnt18Amt9.OutputFormat = "###0";
				Paymnt18Amt10.OutputFormat = "###0";
				Paymnt18Amt11.OutputFormat = "###0";
				Paymnt18Amt12.OutputFormat = "###0";
				Ded18Amt7.OutputFormat = "###0";
				Ded18Amt8.OutputFormat = "###0";
				Ded18Amt9.OutputFormat = "###0";
				Ded18Amt10.OutputFormat = "###0";
				Ded18Amt11.OutputFormat = "###0";
				Ded18Amt12.OutputFormat = "###0";
// 管理番号K27274 From
//				Ded18Amt13.OutputFormat = "###0";
// 管理番号K27274 To
			}

			else if (PaymntDispType12.Text == "3")
			{
				Paymnt1Amt12.OutputFormat = "#,##0.00";
				Paymnt2Amt12.OutputFormat = "#,##0.00";
				Paymnt3Amt12.OutputFormat = "#,##0.00";
				Paymnt4Amt12.OutputFormat = "#,##0.00";
				Paymnt5Amt12.OutputFormat = "#,##0.00";
				Paymnt6Amt12.OutputFormat = "#,##0.00";
				Paymnt7Amt12.OutputFormat = "#,##0.00";
				Paymnt8Amt12.OutputFormat = "#,##0.00";
				Paymnt9Amt12.OutputFormat = "#,##0.00";
				Paymnt10Amt12.OutputFormat = "#,##0.00";
				Paymnt11Amt12.OutputFormat = "#,##0.00";
				Paymnt12Amt12.OutputFormat = "#,##0.00";
				PaymntTotal1Amt12.OutputFormat = "#,##0.00";
				Paymnt13Amt12.OutputFormat = "#,##0.00";
				Paymnt14Amt12.OutputFormat = "#,##0.00";
				Paymnt15Amt12.OutputFormat = "#,##0.00";
				Paymnt16Amt12.OutputFormat = "#,##0.00";
				PaymntTotal2Amt12.OutputFormat = "#,##0.00";
				Paymnt17Amt12.OutputFormat = "#,##0.00";
				PaymntTotal3Amt12.OutputFormat = "#,##0.00";

				Paymnt18Amt7.OutputFormat = "#,##0.00";
				Paymnt18Amt8.OutputFormat = "#,##0.00";
				Paymnt18Amt9.OutputFormat = "#,##0.00";
				Paymnt18Amt10.OutputFormat = "#,##0.00";
				Paymnt18Amt11.OutputFormat = "#,##0.00";
				Paymnt18Amt12.OutputFormat = "#,##0.00";
				Ded18Amt7.OutputFormat = "#,##0.00";
				Ded18Amt8.OutputFormat = "#,##0.00";
				Ded18Amt9.OutputFormat = "#,##0.00";
				Ded18Amt10.OutputFormat = "#,##0.00";
				Ded18Amt11.OutputFormat = "#,##0.00";
				Ded18Amt12.OutputFormat = "#,##0.00";
// 管理番号K27274 From
//				Ded18Amt13.OutputFormat = "#,##0.00";
// 管理番号K27274 To
			}

			else if (PaymntDispType12.Text == "4")
			{
				Paymnt1Amt12.OutputFormat = "###0.00";
				Paymnt2Amt12.OutputFormat = "###0.00";
				Paymnt3Amt12.OutputFormat = "###0.00";
				Paymnt4Amt12.OutputFormat = "###0.00";
				Paymnt5Amt12.OutputFormat = "###0.00";
				Paymnt6Amt12.OutputFormat = "###0.00";
				Paymnt7Amt12.OutputFormat = "###0.00";
				Paymnt8Amt12.OutputFormat = "###0.00";
				Paymnt9Amt12.OutputFormat = "###0.00";
				Paymnt10Amt12.OutputFormat = "###0.00";
				Paymnt11Amt12.OutputFormat = "###0.00";
				Paymnt12Amt12.OutputFormat = "###0.00";
				PaymntTotal1Amt12.OutputFormat = "###0.00";
				Paymnt13Amt12.OutputFormat = "###0.00";
				Paymnt14Amt12.OutputFormat = "###0.00";
				Paymnt15Amt12.OutputFormat = "###0.00";
				Paymnt16Amt12.OutputFormat = "###0.00";
				PaymntTotal2Amt12.OutputFormat = "###0.00";
				Paymnt17Amt12.OutputFormat = "###0.00";
				PaymntTotal3Amt12.OutputFormat = "###0.00";

				Paymnt18Amt7.OutputFormat = "###0.00";
				Paymnt18Amt8.OutputFormat = "###0.00";
				Paymnt18Amt9.OutputFormat = "###0.00";
				Paymnt18Amt10.OutputFormat = "###0.00";
				Paymnt18Amt11.OutputFormat = "###0.00";
				Paymnt18Amt12.OutputFormat = "###0.00";
				Ded18Amt7.OutputFormat = "###0.00";
				Ded18Amt8.OutputFormat = "###0.00";
				Ded18Amt9.OutputFormat = "###0.00";
				Ded18Amt10.OutputFormat = "###0.00";
				Ded18Amt11.OutputFormat = "###0.00";
				Ded18Amt12.OutputFormat = "###0.00";
// 管理番号K27274 From
//				Ded18Amt13.OutputFormat = "###0.00";
// 管理番号K27274 To
			}

			else
			{
				Paymnt1Amt12.OutputFormat = "#,##0";
				Paymnt2Amt12.OutputFormat = "#,##0";
				Paymnt3Amt12.OutputFormat = "#,##0";
				Paymnt4Amt12.OutputFormat = "#,##0";
				Paymnt5Amt12.OutputFormat = "#,##0";
				Paymnt6Amt12.OutputFormat = "#,##0";
				Paymnt7Amt12.OutputFormat = "#,##0";
				Paymnt8Amt12.OutputFormat = "#,##0";
				Paymnt9Amt12.OutputFormat = "#,##0";
				Paymnt10Amt12.OutputFormat = "#,##0";
				Paymnt11Amt12.OutputFormat = "#,##0";
				Paymnt12Amt12.OutputFormat = "#,##0";
				PaymntTotal1Amt12.OutputFormat = "###0";
				Paymnt13Amt12.OutputFormat = "#,##0";
				Paymnt14Amt12.OutputFormat = "#,##0";
				Paymnt15Amt12.OutputFormat = "#,##0";
				Paymnt16Amt12.OutputFormat = "#,##0";
				PaymntTotal2Amt12.OutputFormat = "#,##0";
				Paymnt17Amt12.OutputFormat = "#,##0";
				PaymntTotal3Amt12.OutputFormat = "#,##0";

				Paymnt18Amt7.OutputFormat = "#,##0";
				Paymnt18Amt8.OutputFormat = "#,##0";
				Paymnt18Amt9.OutputFormat = "#,##0";
				Paymnt18Amt10.OutputFormat = "#,##0";
				Paymnt18Amt11.OutputFormat = "#,##0";
				Paymnt18Amt12.OutputFormat = "#,##0";
				Ded18Amt7.OutputFormat = "#,##0";
				Ded18Amt8.OutputFormat = "#,##0";
				Ded18Amt9.OutputFormat = "#,##0";
				Ded18Amt10.OutputFormat = "#,##0";
				Ded18Amt11.OutputFormat = "#,##0";
				Ded18Amt12.OutputFormat = "#,##0";
// 管理番号K27274 From
//				Ded18Amt13.OutputFormat = "#,##0";
// 管理番号K27274 To
			}

			if (PaymntBnsDispType7.Text == "2")
			{
				Paymnt13Amt7.OutputFormat = "###0";
				Paymnt14Amt7.OutputFormat = "###0";
				Paymnt15Amt7.OutputFormat = "###0";
				Paymnt16Amt7.OutputFormat = "###0";
				PaymntTotal2Amt7.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType7.Text == "3")
			{
				Paymnt13Amt7.OutputFormat = "#,##0.00";
				Paymnt14Amt7.OutputFormat = "#,##0.00";
				Paymnt15Amt7.OutputFormat = "#,##0.00";
				Paymnt16Amt7.OutputFormat = "#,##0.00";
				PaymntTotal2Amt7.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType7.Text == "4")
			{
				Paymnt13Amt7.OutputFormat = "###0.00";
				Paymnt14Amt7.OutputFormat = "###0.00";
				Paymnt15Amt7.OutputFormat = "###0.00";
				Paymnt16Amt7.OutputFormat = "###0.00";
				PaymntTotal2Amt7.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt7.OutputFormat = "#,##0";
				Paymnt14Amt7.OutputFormat = "#,##0";
				Paymnt15Amt7.OutputFormat = "#,##0";
				Paymnt16Amt7.OutputFormat = "#,##0";
				PaymntTotal2Amt7.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType8.Text == "2")
			{
				Paymnt13Amt8.OutputFormat = "###0";
				Paymnt14Amt8.OutputFormat = "###0";
				Paymnt15Amt8.OutputFormat = "###0";
				Paymnt16Amt8.OutputFormat = "###0";
				PaymntTotal2Amt8.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType8.Text == "3")
			{
				Paymnt13Amt8.OutputFormat = "#,##0.00";
				Paymnt14Amt8.OutputFormat = "#,##0.00";
				Paymnt15Amt8.OutputFormat = "#,##0.00";
				Paymnt16Amt8.OutputFormat = "#,##0.00";
				PaymntTotal2Amt8.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType8.Text == "4")
			{
				Paymnt13Amt8.OutputFormat = "###0.00";
				Paymnt14Amt8.OutputFormat = "###0.00";
				Paymnt15Amt8.OutputFormat = "###0.00";
				Paymnt16Amt8.OutputFormat = "###0.00";
				PaymntTotal2Amt8.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt8.OutputFormat = "#,##0";
				Paymnt14Amt8.OutputFormat = "#,##0";
				Paymnt15Amt8.OutputFormat = "#,##0";
				Paymnt16Amt8.OutputFormat = "#,##0";
				PaymntTotal2Amt8.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType9.Text == "2")
			{
				Paymnt13Amt9.OutputFormat = "###0";
				Paymnt14Amt9.OutputFormat = "###0";
				Paymnt15Amt9.OutputFormat = "###0";
				Paymnt16Amt9.OutputFormat = "###0";
				PaymntTotal2Amt9.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType9.Text == "3")
			{
				Paymnt13Amt9.OutputFormat = "#,##0.00";
				Paymnt14Amt9.OutputFormat = "#,##0.00";
				Paymnt15Amt9.OutputFormat = "#,##0.00";
				Paymnt16Amt9.OutputFormat = "#,##0.00";
				PaymntTotal2Amt9.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType9.Text == "4")
			{
				Paymnt13Amt9.OutputFormat = "###0.00";
				Paymnt14Amt9.OutputFormat = "###0.00";
				Paymnt15Amt9.OutputFormat = "###0.00";
				Paymnt16Amt9.OutputFormat = "###0.00";
				PaymntTotal2Amt9.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt9.OutputFormat = "#,##0";
				Paymnt14Amt9.OutputFormat = "#,##0";
				Paymnt15Amt9.OutputFormat = "#,##0";
				Paymnt16Amt9.OutputFormat = "#,##0";
				PaymntTotal2Amt9.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType10.Text == "2")
			{
				Paymnt13Amt10.OutputFormat = "###0";
				Paymnt14Amt10.OutputFormat = "###0";
				Paymnt15Amt10.OutputFormat = "###0";
				Paymnt16Amt10.OutputFormat = "###0";
				PaymntTotal2Amt10.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType10.Text == "3")
			{
				Paymnt13Amt10.OutputFormat = "#,##0.00";
				Paymnt14Amt10.OutputFormat = "#,##0.00";
				Paymnt15Amt10.OutputFormat = "#,##0.00";
				Paymnt16Amt10.OutputFormat = "#,##0.00";
				PaymntTotal2Amt10.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType10.Text == "4")
			{
				Paymnt13Amt10.OutputFormat = "###0.00";
				Paymnt14Amt10.OutputFormat = "###0.00";
				Paymnt15Amt10.OutputFormat = "###0.00";
				Paymnt16Amt10.OutputFormat = "###0.00";
				PaymntTotal2Amt10.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt10.OutputFormat = "#,##0";
				Paymnt14Amt10.OutputFormat = "#,##0";
				Paymnt15Amt10.OutputFormat = "#,##0";
				Paymnt16Amt10.OutputFormat = "#,##0";
				PaymntTotal2Amt10.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType11.Text == "2")
			{
				Paymnt13Amt11.OutputFormat = "###0";
				Paymnt14Amt11.OutputFormat = "###0";
				Paymnt15Amt11.OutputFormat = "###0";
				Paymnt16Amt11.OutputFormat = "###0";
				PaymntTotal2Amt11.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType11.Text == "3")
			{
				Paymnt13Amt11.OutputFormat = "#,##0.00";
				Paymnt14Amt11.OutputFormat = "#,##0.00";
				Paymnt15Amt11.OutputFormat = "#,##0.00";
				Paymnt16Amt11.OutputFormat = "#,##0.00";
				PaymntTotal2Amt11.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType11.Text == "4")
			{
				Paymnt13Amt11.OutputFormat = "###0.00";
				Paymnt14Amt11.OutputFormat = "###0.00";
				Paymnt15Amt11.OutputFormat = "###0.00";
				Paymnt16Amt11.OutputFormat = "###0.00";
				PaymntTotal2Amt11.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt11.OutputFormat = "#,##0";
				Paymnt14Amt11.OutputFormat = "#,##0";
				Paymnt15Amt11.OutputFormat = "#,##0";
				Paymnt16Amt11.OutputFormat = "#,##0";
				PaymntTotal2Amt11.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType12.Text == "2")
			{
				Paymnt13Amt12.OutputFormat = "###0";
				Paymnt14Amt12.OutputFormat = "###0";
				Paymnt15Amt12.OutputFormat = "###0";
				Paymnt16Amt12.OutputFormat = "###0";
				PaymntTotal2Amt12.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType12.Text == "3")
			{
				Paymnt13Amt12.OutputFormat = "#,##0.00";
				Paymnt14Amt12.OutputFormat = "#,##0.00";
				Paymnt15Amt12.OutputFormat = "#,##0.00";
				Paymnt16Amt12.OutputFormat = "#,##0.00";
				PaymntTotal2Amt12.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType12.Text == "4")
			{
				Paymnt13Amt12.OutputFormat = "###0.00";
				Paymnt14Amt12.OutputFormat = "###0.00";
				Paymnt15Amt12.OutputFormat = "###0.00";
				Paymnt16Amt12.OutputFormat = "###0.00";
				PaymntTotal2Amt12.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt12.OutputFormat = "#,##0";
				Paymnt14Amt12.OutputFormat = "#,##0";
				Paymnt15Amt12.OutputFormat = "#,##0";
				Paymnt16Amt12.OutputFormat = "#,##0";
				PaymntTotal2Amt12.OutputFormat = "#,##0";
			}

			if (DedDispType7.Text == "2")
			{
				Ded1Amt7.OutputFormat = "###0";
				Ded2Amt7.OutputFormat = "###0";
				Ded3Amt7.OutputFormat = "###0";
				Ded4Amt7.OutputFormat = "###0";
				Ded5Amt7.OutputFormat = "###0";
				Ded6Amt7.OutputFormat = "###0";
				Ded7Amt7.OutputFormat = "###0";
				Ded8Amt7.OutputFormat = "###0";
				Ded9Amt7.OutputFormat = "###0";
				Ded10Amt7.OutputFormat = "###0";
				Ded11Amt7.OutputFormat = "###0";
				Ded12Amt7.OutputFormat = "###0";
				DedTotal1Amt7.OutputFormat = "###0";
				Ded13Amt7.OutputFormat = "###0";
				Ded14Amt7.OutputFormat = "###0";
				Ded15Amt7.OutputFormat = "###0";
				Ded16Amt7.OutputFormat = "###0";
				DedTotal2Amt7.OutputFormat = "###0";
				Ded17Amt7.OutputFormat = "###0";
				DedTotal3Amt7.OutputFormat = "###0";
			}

			else if (DedDispType7.Text == "3")
			{
				Ded1Amt7.OutputFormat = "#,##0.00";
				Ded2Amt7.OutputFormat = "#,##0.00";
				Ded3Amt7.OutputFormat = "#,##0.00";
				Ded4Amt7.OutputFormat = "#,##0.00";
				Ded5Amt7.OutputFormat = "#,##0.00";
				Ded6Amt7.OutputFormat = "#,##0.00";
				Ded7Amt7.OutputFormat = "#,##0.00";
				Ded8Amt7.OutputFormat = "#,##0.00";
				Ded9Amt7.OutputFormat = "#,##0.00";
				Ded10Amt7.OutputFormat = "#,##0.00";
				Ded11Amt7.OutputFormat = "#,##0.00";
				Ded12Amt7.OutputFormat = "#,##0.00";
				DedTotal1Amt7.OutputFormat = "#,##0.00";
				Ded13Amt7.OutputFormat = "#,##0.00";
				Ded14Amt7.OutputFormat = "#,##0.00";
				Ded15Amt7.OutputFormat = "#,##0.00";
				Ded16Amt7.OutputFormat = "#,##0.00";
				DedTotal2Amt7.OutputFormat = "#,##0.00";
				Ded17Amt7.OutputFormat = "#,##0.00";
				DedTotal3Amt7.OutputFormat = "#,##0.00";
			}

			else if (DedDispType7.Text == "4")
			{
				Ded1Amt7.OutputFormat = "###0.00";
				Ded2Amt7.OutputFormat = "###0.00";
				Ded3Amt7.OutputFormat = "###0.00";
				Ded4Amt7.OutputFormat = "###0.00";
				Ded5Amt7.OutputFormat = "###0.00";
				Ded6Amt7.OutputFormat = "###0.00";
				Ded7Amt7.OutputFormat = "###0.00";
				Ded8Amt7.OutputFormat = "###0.00";
				Ded9Amt7.OutputFormat = "###0.00";
				Ded10Amt7.OutputFormat = "###0.00";
				Ded11Amt7.OutputFormat = "###0.00";
				Ded12Amt7.OutputFormat = "###0.00";
				DedTotal1Amt7.OutputFormat = "###0.00";
				Ded13Amt7.OutputFormat = "###0.00";
				Ded14Amt7.OutputFormat = "###0.00";
				Ded15Amt7.OutputFormat = "###0.00";
				Ded16Amt7.OutputFormat = "###0.00";
				DedTotal2Amt7.OutputFormat = "###0.00";
				Ded17Amt7.OutputFormat = "###0.00";
				DedTotal3Amt7.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt7.OutputFormat = "#,##0";
				Ded2Amt7.OutputFormat = "#,##0";
				Ded3Amt7.OutputFormat = "#,##0";
				Ded4Amt7.OutputFormat = "#,##0";
				Ded5Amt7.OutputFormat = "#,##0";
				Ded6Amt7.OutputFormat = "#,##0";
				Ded7Amt7.OutputFormat = "#,##0";
				Ded8Amt7.OutputFormat = "#,##0";
				Ded9Amt7.OutputFormat = "#,##0";
				Ded10Amt7.OutputFormat = "#,##0";
				Ded11Amt7.OutputFormat = "#,##0";
				Ded12Amt7.OutputFormat = "#,##0";
				DedTotal1Amt7.OutputFormat = "#,##0";
				Ded13Amt7.OutputFormat = "#,##0";
				Ded14Amt7.OutputFormat = "#,##0";
				Ded15Amt7.OutputFormat = "#,##0";
				Ded16Amt7.OutputFormat = "#,##0";
				DedTotal2Amt7.OutputFormat = "#,##0";
				Ded17Amt7.OutputFormat = "#,##0";
				DedTotal3Amt7.OutputFormat = "#,##0";
			}

			if (DedDispType8.Text == "2")
			{
				Ded1Amt8.OutputFormat = "###0";
				Ded2Amt8.OutputFormat = "###0";
				Ded3Amt8.OutputFormat = "###0";
				Ded4Amt8.OutputFormat = "###0";
				Ded5Amt8.OutputFormat = "###0";
				Ded6Amt8.OutputFormat = "###0";
				Ded7Amt8.OutputFormat = "###0";
				Ded8Amt8.OutputFormat = "###0";
				Ded9Amt8.OutputFormat = "###0";
				Ded10Amt8.OutputFormat = "###0";
				Ded11Amt8.OutputFormat = "###0";
				Ded12Amt8.OutputFormat = "###0";
				DedTotal1Amt8.OutputFormat = "###0";
				Ded13Amt8.OutputFormat = "###0";
				Ded14Amt8.OutputFormat = "###0";
				Ded15Amt8.OutputFormat = "###0";
				Ded16Amt8.OutputFormat = "###0";
				DedTotal2Amt8.OutputFormat = "###0";
				Ded17Amt8.OutputFormat = "###0";
				DedTotal3Amt8.OutputFormat = "###0";
			}

			else if (DedDispType8.Text == "3")
			{
				Ded1Amt8.OutputFormat = "#,##0.00";
				Ded2Amt8.OutputFormat = "#,##0.00";
				Ded3Amt8.OutputFormat = "#,##0.00";
				Ded4Amt8.OutputFormat = "#,##0.00";
				Ded5Amt8.OutputFormat = "#,##0.00";
				Ded6Amt8.OutputFormat = "#,##0.00";
				Ded7Amt8.OutputFormat = "#,##0.00";
				Ded8Amt8.OutputFormat = "#,##0.00";
				Ded9Amt8.OutputFormat = "#,##0.00";
				Ded10Amt8.OutputFormat = "#,##0.00";
				Ded11Amt8.OutputFormat = "#,##0.00";
				Ded12Amt8.OutputFormat = "#,##0.00";
				DedTotal1Amt8.OutputFormat = "#,##0.00";
				Ded13Amt8.OutputFormat = "#,##0.00";
				Ded14Amt8.OutputFormat = "#,##0.00";
				Ded15Amt8.OutputFormat = "#,##0.00";
				Ded16Amt8.OutputFormat = "#,##0.00";
				DedTotal2Amt8.OutputFormat = "#,##0.00";
				Ded17Amt8.OutputFormat = "#,##0.00";
				DedTotal3Amt8.OutputFormat = "#,##0.00";
			}

			else if (DedDispType8.Text == "4")
			{
				Ded1Amt8.OutputFormat = "###0.00";
				Ded2Amt8.OutputFormat = "###0.00";
				Ded3Amt8.OutputFormat = "###0.00";
				Ded4Amt8.OutputFormat = "###0.00";
				Ded5Amt8.OutputFormat = "###0.00";
				Ded6Amt8.OutputFormat = "###0.00";
				Ded7Amt8.OutputFormat = "###0.00";
				Ded8Amt8.OutputFormat = "###0.00";
				Ded9Amt8.OutputFormat = "###0.00";
				Ded10Amt8.OutputFormat = "###0.00";
				Ded11Amt8.OutputFormat = "###0.00";
				Ded12Amt8.OutputFormat = "###0.00";
				DedTotal1Amt8.OutputFormat = "###0.00";
				Ded13Amt8.OutputFormat = "###0.00";
				Ded14Amt8.OutputFormat = "###0.00";
				Ded15Amt8.OutputFormat = "###0.00";
				Ded16Amt8.OutputFormat = "###0.00";
				DedTotal2Amt8.OutputFormat = "###0.00";
				Ded17Amt8.OutputFormat = "###0.00";
				DedTotal3Amt8.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt8.OutputFormat = "#,##0";
				Ded2Amt8.OutputFormat = "#,##0";
				Ded3Amt8.OutputFormat = "#,##0";
				Ded4Amt8.OutputFormat = "#,##0";
				Ded5Amt8.OutputFormat = "#,##0";
				Ded6Amt8.OutputFormat = "#,##0";
				Ded7Amt8.OutputFormat = "#,##0";
				Ded8Amt8.OutputFormat = "#,##0";
				Ded9Amt8.OutputFormat = "#,##0";
				Ded10Amt8.OutputFormat = "#,##0";
				Ded11Amt8.OutputFormat = "#,##0";
				Ded12Amt8.OutputFormat = "#,##0";
				DedTotal1Amt8.OutputFormat = "#,##0";
				Ded13Amt8.OutputFormat = "#,##0";
				Ded14Amt8.OutputFormat = "#,##0";
				Ded15Amt8.OutputFormat = "#,##0";
				Ded16Amt8.OutputFormat = "#,##0";
				DedTotal2Amt8.OutputFormat = "#,##0";
				Ded17Amt8.OutputFormat = "#,##0";
				DedTotal3Amt8.OutputFormat = "#,##0";
			}

			if (DedDispType9.Text == "2")
			{
				Ded1Amt9.OutputFormat = "###0";
				Ded2Amt9.OutputFormat = "###0";
				Ded3Amt9.OutputFormat = "###0";
				Ded4Amt9.OutputFormat = "###0";
				Ded5Amt9.OutputFormat = "###0";
				Ded6Amt9.OutputFormat = "###0";
				Ded7Amt9.OutputFormat = "###0";
				Ded8Amt9.OutputFormat = "###0";
				Ded9Amt9.OutputFormat = "###0";
				Ded10Amt9.OutputFormat = "###0";
				Ded11Amt9.OutputFormat = "###0";
				Ded12Amt9.OutputFormat = "###0";
				DedTotal1Amt9.OutputFormat = "###0";
				Ded13Amt9.OutputFormat = "###0";
				Ded14Amt9.OutputFormat = "###0";
				Ded15Amt9.OutputFormat = "###0";
				Ded16Amt9.OutputFormat = "###0";
				DedTotal2Amt9.OutputFormat = "###0";
				Ded17Amt9.OutputFormat = "###0";
				DedTotal3Amt9.OutputFormat = "###0";
			}

			else if (DedDispType9.Text == "3")
			{
				Ded1Amt9.OutputFormat = "#,##0.00";
				Ded2Amt9.OutputFormat = "#,##0.00";
				Ded3Amt9.OutputFormat = "#,##0.00";
				Ded4Amt9.OutputFormat = "#,##0.00";
				Ded5Amt9.OutputFormat = "#,##0.00";
				Ded6Amt9.OutputFormat = "#,##0.00";
				Ded7Amt9.OutputFormat = "#,##0.00";
				Ded8Amt9.OutputFormat = "#,##0.00";
				Ded9Amt9.OutputFormat = "#,##0.00";
				Ded10Amt9.OutputFormat = "#,##0.00";
				Ded11Amt9.OutputFormat = "#,##0.00";
				Ded12Amt9.OutputFormat = "#,##0.00";
				DedTotal1Amt9.OutputFormat = "#,##0.00";
				Ded13Amt9.OutputFormat = "#,##0.00";
				Ded14Amt9.OutputFormat = "#,##0.00";
				Ded15Amt9.OutputFormat = "#,##0.00";
				Ded16Amt9.OutputFormat = "#,##0.00";
				DedTotal2Amt9.OutputFormat = "#,##0.00";
				Ded17Amt9.OutputFormat = "#,##0.00";
				DedTotal3Amt9.OutputFormat = "#,##0.00";
			}

			else if (DedDispType9.Text == "4")
			{
				Ded1Amt9.OutputFormat = "###0.00";
				Ded2Amt9.OutputFormat = "###0.00";
				Ded3Amt9.OutputFormat = "###0.00";
				Ded4Amt9.OutputFormat = "###0.00";
				Ded5Amt9.OutputFormat = "###0.00";
				Ded6Amt9.OutputFormat = "###0.00";
				Ded7Amt9.OutputFormat = "###0.00";
				Ded8Amt9.OutputFormat = "###0.00";
				Ded9Amt9.OutputFormat = "###0.00";
				Ded10Amt9.OutputFormat = "###0.00";
				Ded11Amt9.OutputFormat = "###0.00";
				Ded12Amt9.OutputFormat = "###0.00";
				DedTotal1Amt9.OutputFormat = "###0.00";
				Ded13Amt9.OutputFormat = "###0.00";
				Ded14Amt9.OutputFormat = "###0.00";
				Ded15Amt9.OutputFormat = "###0.00";
				Ded16Amt9.OutputFormat = "###0.00";
				DedTotal2Amt9.OutputFormat = "###0.00";
				Ded17Amt9.OutputFormat = "###0.00";
				DedTotal3Amt9.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt9.OutputFormat = "#,##0";
				Ded2Amt9.OutputFormat = "#,##0";
				Ded3Amt9.OutputFormat = "#,##0";
				Ded4Amt9.OutputFormat = "#,##0";
				Ded5Amt9.OutputFormat = "#,##0";
				Ded6Amt9.OutputFormat = "#,##0";
				Ded7Amt9.OutputFormat = "#,##0";
				Ded8Amt9.OutputFormat = "#,##0";
				Ded9Amt9.OutputFormat = "#,##0";
				Ded10Amt9.OutputFormat = "#,##0";
				Ded11Amt9.OutputFormat = "#,##0";
				Ded12Amt9.OutputFormat = "#,##0";
				DedTotal1Amt9.OutputFormat = "#,##0";
				Ded13Amt9.OutputFormat = "#,##0";
				Ded14Amt9.OutputFormat = "#,##0";
				Ded15Amt9.OutputFormat = "#,##0";
				Ded16Amt9.OutputFormat = "#,##0";
				DedTotal2Amt9.OutputFormat = "#,##0";
				Ded17Amt9.OutputFormat = "#,##0";
				DedTotal3Amt9.OutputFormat = "#,##0";
			}

			if (DedDispType10.Text == "2")
			{
				Ded1Amt10.OutputFormat = "###0";
				Ded2Amt10.OutputFormat = "###0";
				Ded3Amt10.OutputFormat = "###0";
				Ded4Amt10.OutputFormat = "###0";
				Ded5Amt10.OutputFormat = "###0";
				Ded6Amt10.OutputFormat = "###0";
				Ded7Amt10.OutputFormat = "###0";
				Ded8Amt10.OutputFormat = "###0";
				Ded9Amt10.OutputFormat = "###0";
				Ded10Amt10.OutputFormat = "###0";
				Ded11Amt10.OutputFormat = "###0";
				Ded12Amt10.OutputFormat = "###0";
				DedTotal1Amt10.OutputFormat = "###0";
				Ded13Amt10.OutputFormat = "###0";
				Ded14Amt10.OutputFormat = "###0";
				Ded15Amt10.OutputFormat = "###0";
				Ded16Amt10.OutputFormat = "###0";
				DedTotal2Amt10.OutputFormat = "###0";
				Ded17Amt10.OutputFormat = "###0";
				DedTotal3Amt10.OutputFormat = "###0";
			}

			else if (DedDispType10.Text == "3")
			{
				Ded1Amt10.OutputFormat = "#,##0.00";
				Ded2Amt10.OutputFormat = "#,##0.00";
				Ded3Amt10.OutputFormat = "#,##0.00";
				Ded4Amt10.OutputFormat = "#,##0.00";
				Ded5Amt10.OutputFormat = "#,##0.00";
				Ded6Amt10.OutputFormat = "#,##0.00";
				Ded7Amt10.OutputFormat = "#,##0.00";
				Ded8Amt10.OutputFormat = "#,##0.00";
				Ded9Amt10.OutputFormat = "#,##0.00";
				Ded10Amt10.OutputFormat = "#,##0.00";
				Ded11Amt10.OutputFormat = "#,##0.00";
				Ded12Amt10.OutputFormat = "#,##0.00";
				DedTotal1Amt10.OutputFormat = "#,##0.00";
				Ded13Amt10.OutputFormat = "#,##0.00";
				Ded14Amt10.OutputFormat = "#,##0.00";
				Ded15Amt10.OutputFormat = "#,##0.00";
				Ded16Amt10.OutputFormat = "#,##0.00";
				DedTotal2Amt10.OutputFormat = "#,##0.00";
				Ded17Amt10.OutputFormat = "#,##0.00";
				DedTotal3Amt10.OutputFormat = "#,##0.00";
			}

			else if (DedDispType10.Text == "4")
			{
				Ded1Amt10.OutputFormat = "###0.00";
				Ded2Amt10.OutputFormat = "###0.00";
				Ded3Amt10.OutputFormat = "###0.00";
				Ded4Amt10.OutputFormat = "###0.00";
				Ded5Amt10.OutputFormat = "###0.00";
				Ded6Amt10.OutputFormat = "###0.00";
				Ded7Amt10.OutputFormat = "###0.00";
				Ded8Amt10.OutputFormat = "###0.00";
				Ded9Amt10.OutputFormat = "###0.00";
				Ded10Amt10.OutputFormat = "###0.00";
				Ded11Amt10.OutputFormat = "###0.00";
				Ded12Amt10.OutputFormat = "###0.00";
				DedTotal1Amt10.OutputFormat = "###0.00";
				Ded13Amt10.OutputFormat = "###0.00";
				Ded14Amt10.OutputFormat = "###0.00";
				Ded15Amt10.OutputFormat = "###0.00";
				Ded16Amt10.OutputFormat = "###0.00";
				DedTotal2Amt10.OutputFormat = "###0.00";
				Ded17Amt10.OutputFormat = "###0.00";
				DedTotal3Amt10.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt10.OutputFormat = "#,##0";
				Ded2Amt10.OutputFormat = "#,##0";
				Ded3Amt10.OutputFormat = "#,##0";
				Ded4Amt10.OutputFormat = "#,##0";
				Ded5Amt10.OutputFormat = "#,##0";
				Ded6Amt10.OutputFormat = "#,##0";
				Ded7Amt10.OutputFormat = "#,##0";
				Ded8Amt10.OutputFormat = "#,##0";
				Ded9Amt10.OutputFormat = "#,##0";
				Ded10Amt10.OutputFormat = "#,##0";
				Ded11Amt10.OutputFormat = "#,##0";
				Ded12Amt10.OutputFormat = "#,##0";
				DedTotal1Amt10.OutputFormat = "#,##0";
				Ded13Amt10.OutputFormat = "#,##0";
				Ded14Amt10.OutputFormat = "#,##0";
				Ded15Amt10.OutputFormat = "#,##0";
				Ded16Amt10.OutputFormat = "#,##0";
				DedTotal2Amt10.OutputFormat = "#,##0";
				Ded17Amt10.OutputFormat = "#,##0";
				DedTotal3Amt10.OutputFormat = "#,##0";
			}

			if (DedDispType11.Text == "2")
			{
				Ded1Amt11.OutputFormat = "###0";
				Ded2Amt11.OutputFormat = "###0";
				Ded3Amt11.OutputFormat = "###0";
				Ded4Amt11.OutputFormat = "###0";
				Ded5Amt11.OutputFormat = "###0";
				Ded6Amt11.OutputFormat = "###0";
				Ded7Amt11.OutputFormat = "###0";
				Ded8Amt11.OutputFormat = "###0";
				Ded9Amt11.OutputFormat = "###0";
				Ded10Amt11.OutputFormat = "###0";
				Ded11Amt11.OutputFormat = "###0";
				Ded12Amt11.OutputFormat = "###0";
				DedTotal1Amt11.OutputFormat = "###0";
				Ded13Amt11.OutputFormat = "###0";
				Ded14Amt11.OutputFormat = "###0";
				Ded15Amt11.OutputFormat = "###0";
				Ded16Amt11.OutputFormat = "###0";
				DedTotal2Amt11.OutputFormat = "###0";
				Ded17Amt11.OutputFormat = "###0";
				DedTotal3Amt11.OutputFormat = "###0";
			}

			else if (DedDispType11.Text == "3")
			{
				Ded1Amt11.OutputFormat = "#,##0.00";
				Ded2Amt11.OutputFormat = "#,##0.00";
				Ded3Amt11.OutputFormat = "#,##0.00";
				Ded4Amt11.OutputFormat = "#,##0.00";
				Ded5Amt11.OutputFormat = "#,##0.00";
				Ded6Amt11.OutputFormat = "#,##0.00";
				Ded7Amt11.OutputFormat = "#,##0.00";
				Ded8Amt11.OutputFormat = "#,##0.00";
				Ded9Amt11.OutputFormat = "#,##0.00";
				Ded10Amt11.OutputFormat = "#,##0.00";
				Ded11Amt11.OutputFormat = "#,##0.00";
				Ded12Amt11.OutputFormat = "#,##0.00";
				DedTotal1Amt11.OutputFormat = "#,##0.00";
				Ded13Amt11.OutputFormat = "#,##0.00";
				Ded14Amt11.OutputFormat = "#,##0.00";
				Ded15Amt11.OutputFormat = "#,##0.00";
				Ded16Amt11.OutputFormat = "#,##0.00";
				DedTotal2Amt11.OutputFormat = "#,##0.00";
				Ded17Amt11.OutputFormat = "#,##0.00";
				DedTotal3Amt11.OutputFormat = "#,##0.00";
			}

			else if (DedDispType11.Text == "4")
			{
				Ded1Amt11.OutputFormat = "###0.00";
				Ded2Amt11.OutputFormat = "###0.00";
				Ded3Amt11.OutputFormat = "###0.00";
				Ded4Amt11.OutputFormat = "###0.00";
				Ded5Amt11.OutputFormat = "###0.00";
				Ded6Amt11.OutputFormat = "###0.00";
				Ded7Amt11.OutputFormat = "###0.00";
				Ded8Amt11.OutputFormat = "###0.00";
				Ded9Amt11.OutputFormat = "###0.00";
				Ded10Amt11.OutputFormat = "###0.00";
				Ded11Amt11.OutputFormat = "###0.00";
				Ded12Amt11.OutputFormat = "###0.00";
				DedTotal1Amt11.OutputFormat = "###0.00";
				Ded13Amt11.OutputFormat = "###0.00";
				Ded14Amt11.OutputFormat = "###0.00";
				Ded15Amt11.OutputFormat = "###0.00";
				Ded16Amt11.OutputFormat = "###0.00";
				DedTotal2Amt11.OutputFormat = "###0.00";
				Ded17Amt11.OutputFormat = "###0.00";
				DedTotal3Amt11.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt11.OutputFormat = "#,##0";
				Ded2Amt11.OutputFormat = "#,##0";
				Ded3Amt11.OutputFormat = "#,##0";
				Ded4Amt11.OutputFormat = "#,##0";
				Ded5Amt11.OutputFormat = "#,##0";
				Ded6Amt11.OutputFormat = "#,##0";
				Ded7Amt11.OutputFormat = "#,##0";
				Ded8Amt11.OutputFormat = "#,##0";
				Ded9Amt11.OutputFormat = "#,##0";
				Ded10Amt11.OutputFormat = "#,##0";
				Ded11Amt11.OutputFormat = "#,##0";
				Ded12Amt11.OutputFormat = "#,##0";
				DedTotal1Amt11.OutputFormat = "#,##0";
				Ded13Amt11.OutputFormat = "#,##0";
				Ded14Amt11.OutputFormat = "#,##0";
				Ded15Amt11.OutputFormat = "#,##0";
				Ded16Amt11.OutputFormat = "#,##0";
				DedTotal2Amt11.OutputFormat = "#,##0";
				Ded17Amt11.OutputFormat = "#,##0";
				DedTotal3Amt11.OutputFormat = "#,##0";
			}

			if (DedDispType12.Text == "2")
			{
				Ded1Amt12.OutputFormat = "###0";
				Ded2Amt12.OutputFormat = "###0";
				Ded3Amt12.OutputFormat = "###0";
				Ded4Amt12.OutputFormat = "###0";
				Ded5Amt12.OutputFormat = "###0";
				Ded6Amt12.OutputFormat = "###0";
				Ded7Amt12.OutputFormat = "###0";
				Ded8Amt12.OutputFormat = "###0";
				Ded9Amt12.OutputFormat = "###0";
				Ded10Amt12.OutputFormat = "###0";
				Ded11Amt12.OutputFormat = "###0";
				Ded12Amt12.OutputFormat = "###0";
				DedTotal1Amt12.OutputFormat = "###0";
				Ded13Amt12.OutputFormat = "###0";
				Ded14Amt12.OutputFormat = "###0";
				Ded15Amt12.OutputFormat = "###0";
				Ded16Amt12.OutputFormat = "###0";
				DedTotal2Amt12.OutputFormat = "###0";
				Ded17Amt12.OutputFormat = "###0";
				DedTotal3Amt12.OutputFormat = "###0";
			}

			else if (DedDispType12.Text == "3")
			{
				Ded1Amt12.OutputFormat = "#,##0.00";
				Ded2Amt12.OutputFormat = "#,##0.00";
				Ded3Amt12.OutputFormat = "#,##0.00";
				Ded4Amt12.OutputFormat = "#,##0.00";
				Ded5Amt12.OutputFormat = "#,##0.00";
				Ded6Amt12.OutputFormat = "#,##0.00";
				Ded7Amt12.OutputFormat = "#,##0.00";
				Ded8Amt12.OutputFormat = "#,##0.00";
				Ded9Amt12.OutputFormat = "#,##0.00";
				Ded10Amt12.OutputFormat = "#,##0.00";
				Ded11Amt12.OutputFormat = "#,##0.00";
				Ded12Amt12.OutputFormat = "#,##0.00";
				DedTotal1Amt12.OutputFormat = "#,##0.00";
				Ded13Amt12.OutputFormat = "#,##0.00";
				Ded14Amt12.OutputFormat = "#,##0.00";
				Ded15Amt12.OutputFormat = "#,##0.00";
				Ded16Amt12.OutputFormat = "#,##0.00";
				DedTotal2Amt12.OutputFormat = "#,##0.00";
				Ded17Amt12.OutputFormat = "#,##0.00";
				DedTotal3Amt12.OutputFormat = "#,##0.00";
			}

			else if (DedDispType12.Text == "4")
			{
				Ded1Amt12.OutputFormat = "###0.00";
				Ded2Amt12.OutputFormat = "###0.00";
				Ded3Amt12.OutputFormat = "###0.00";
				Ded4Amt12.OutputFormat = "###0.00";
				Ded5Amt12.OutputFormat = "###0.00";
				Ded6Amt12.OutputFormat = "###0.00";
				Ded7Amt12.OutputFormat = "###0.00";
				Ded8Amt12.OutputFormat = "###0.00";
				Ded9Amt12.OutputFormat = "###0.00";
				Ded10Amt12.OutputFormat = "###0.00";
				Ded11Amt12.OutputFormat = "###0.00";
				Ded12Amt12.OutputFormat = "###0.00";
				DedTotal1Amt12.OutputFormat = "###0.00";
				Ded13Amt12.OutputFormat = "###0.00";
				Ded14Amt12.OutputFormat = "###0.00";
				Ded15Amt12.OutputFormat = "###0.00";
				Ded16Amt12.OutputFormat = "###0.00";
				DedTotal2Amt12.OutputFormat = "###0.00";
				Ded17Amt12.OutputFormat = "###0.00";
				DedTotal3Amt12.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt12.OutputFormat = "#,##0";
				Ded2Amt12.OutputFormat = "#,##0";
				Ded3Amt12.OutputFormat = "#,##0";
				Ded4Amt12.OutputFormat = "#,##0";
				Ded5Amt12.OutputFormat = "#,##0";
				Ded6Amt12.OutputFormat = "#,##0";
				Ded7Amt12.OutputFormat = "#,##0";
				Ded8Amt12.OutputFormat = "#,##0";
				Ded9Amt12.OutputFormat = "#,##0";
				Ded10Amt12.OutputFormat = "#,##0";
				Ded11Amt12.OutputFormat = "#,##0";
				Ded12Amt12.OutputFormat = "#,##0";
				DedTotal1Amt12.OutputFormat = "#,##0";
				Ded13Amt12.OutputFormat = "#,##0";
				Ded14Amt12.OutputFormat = "#,##0";
				Ded15Amt12.OutputFormat = "#,##0";
				Ded16Amt12.OutputFormat = "#,##0";
				DedTotal2Amt12.OutputFormat = "#,##0";
				Ded17Amt12.OutputFormat = "#,##0";
				DedTotal3Amt12.OutputFormat = "#,##0";
			}

			if (DedBnsDispType7.Text == "2")
			{
				Ded13Amt7.OutputFormat = "###0";
				Ded14Amt7.OutputFormat = "###0";
				Ded15Amt7.OutputFormat = "###0";
				Ded16Amt7.OutputFormat = "###0";
				DedTotal2Amt7.OutputFormat = "###0";
			}
			else if (DedBnsDispType7.Text == "3")
			{
				Ded13Amt7.OutputFormat = "#,##0.00";
				Ded14Amt7.OutputFormat = "#,##0.00";
				Ded15Amt7.OutputFormat = "#,##0.00";
				Ded16Amt7.OutputFormat = "#,##0.00";
				DedTotal2Amt7.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType7.Text == "4")
			{
				Ded13Amt7.OutputFormat = "###0.00";
				Ded14Amt7.OutputFormat = "###0.00";
				Ded15Amt7.OutputFormat = "###0.00";
				Ded16Amt7.OutputFormat = "###0.00";
				DedTotal2Amt7.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt7.OutputFormat = "#,##0";
				Ded14Amt7.OutputFormat = "#,##0";
				Ded15Amt7.OutputFormat = "#,##0";
				Ded16Amt7.OutputFormat = "#,##0";
				DedTotal2Amt7.OutputFormat = "#,##0";
			}

			if (DedBnsDispType8.Text == "2")
			{
				Ded13Amt8.OutputFormat = "###0";
				Ded14Amt8.OutputFormat = "###0";
				Ded15Amt8.OutputFormat = "###0";
				Ded16Amt8.OutputFormat = "###0";
				DedTotal2Amt8.OutputFormat = "###0";
			}
			else if (DedBnsDispType8.Text == "3")
			{
				Ded13Amt8.OutputFormat = "#,##0.00";
				Ded14Amt8.OutputFormat = "#,##0.00";
				Ded15Amt8.OutputFormat = "#,##0.00";
				Ded16Amt8.OutputFormat = "#,##0.00";
				DedTotal2Amt8.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType8.Text == "4")
			{
				Ded13Amt8.OutputFormat = "###0.00";
				Ded14Amt8.OutputFormat = "###0.00";
				Ded15Amt8.OutputFormat = "###0.00";
				Ded16Amt8.OutputFormat = "###0.00";
				DedTotal2Amt8.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt8.OutputFormat = "#,##0";
				Ded14Amt8.OutputFormat = "#,##0";
				Ded15Amt8.OutputFormat = "#,##0";
				Ded16Amt8.OutputFormat = "#,##0";
				DedTotal2Amt8.OutputFormat = "#,##0";
			}

			if (DedBnsDispType9.Text == "2")
			{
				Ded13Amt9.OutputFormat = "###0";
				Ded14Amt9.OutputFormat = "###0";
				Ded15Amt9.OutputFormat = "###0";
				Ded16Amt9.OutputFormat = "###0";
				DedTotal2Amt9.OutputFormat = "###0";
			}
			else if (DedBnsDispType9.Text == "3")
			{
				Ded13Amt9.OutputFormat = "#,##0.00";
				Ded14Amt9.OutputFormat = "#,##0.00";
				Ded15Amt9.OutputFormat = "#,##0.00";
				Ded16Amt9.OutputFormat = "#,##0.00";
				DedTotal2Amt9.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType9.Text == "4")
			{
				Ded13Amt9.OutputFormat = "###0.00";
				Ded14Amt9.OutputFormat = "###0.00";
				Ded15Amt9.OutputFormat = "###0.00";
				Ded16Amt9.OutputFormat = "###0.00";
				DedTotal2Amt9.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt9.OutputFormat = "#,##0";
				Ded14Amt9.OutputFormat = "#,##0";
				Ded15Amt9.OutputFormat = "#,##0";
				Ded16Amt9.OutputFormat = "#,##0";
				DedTotal2Amt9.OutputFormat = "#,##0";
			}

			if (DedBnsDispType10.Text == "2")
			{
				Ded13Amt10.OutputFormat = "###0";
				Ded14Amt10.OutputFormat = "###0";
				Ded15Amt10.OutputFormat = "###0";
				Ded16Amt10.OutputFormat = "###0";
				DedTotal2Amt10.OutputFormat = "###0";
			}
			else if (DedBnsDispType10.Text == "3")
			{
				Ded13Amt10.OutputFormat = "#,##0.00";
				Ded14Amt10.OutputFormat = "#,##0.00";
				Ded15Amt10.OutputFormat = "#,##0.00";
				Ded16Amt10.OutputFormat = "#,##0.00";
				DedTotal2Amt10.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType10.Text == "4")
			{
				Ded13Amt10.OutputFormat = "###0.00";
				Ded14Amt10.OutputFormat = "###0.00";
				Ded15Amt10.OutputFormat = "###0.00";
				Ded16Amt10.OutputFormat = "###0.00";
				DedTotal2Amt10.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt10.OutputFormat = "#,##0";
				Ded14Amt10.OutputFormat = "#,##0";
				Ded15Amt10.OutputFormat = "#,##0";
				Ded16Amt10.OutputFormat = "#,##0";
				DedTotal2Amt10.OutputFormat = "#,##0";
			}

			if (DedBnsDispType11.Text == "2")
			{
				Ded13Amt11.OutputFormat = "###0";
				Ded14Amt11.OutputFormat = "###0";
				Ded15Amt11.OutputFormat = "###0";
				Ded16Amt11.OutputFormat = "###0";
				DedTotal2Amt11.OutputFormat = "###0";
			}
			else if (DedBnsDispType11.Text == "3")
			{
				Ded13Amt11.OutputFormat = "#,##0.00";
				Ded14Amt11.OutputFormat = "#,##0.00";
				Ded15Amt11.OutputFormat = "#,##0.00";
				Ded16Amt11.OutputFormat = "#,##0.00";
				DedTotal2Amt11.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType11.Text == "4")
			{
				Ded13Amt11.OutputFormat = "###0.00";
				Ded14Amt11.OutputFormat = "###0.00";
				Ded15Amt11.OutputFormat = "###0.00";
				Ded16Amt11.OutputFormat = "###0.00";
				DedTotal2Amt11.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt11.OutputFormat = "#,##0";
				Ded14Amt11.OutputFormat = "#,##0";
				Ded15Amt11.OutputFormat = "#,##0";
				Ded16Amt11.OutputFormat = "#,##0";
				DedTotal2Amt11.OutputFormat = "#,##0";
			}

			if (DedBnsDispType12.Text == "2")
			{
				Ded13Amt12.OutputFormat = "###0";
				Ded14Amt12.OutputFormat = "###0";
				Ded15Amt12.OutputFormat = "###0";
				Ded16Amt12.OutputFormat = "###0";
				DedTotal2Amt12.OutputFormat = "###0";
			}
			else if (DedBnsDispType12.Text == "3")
			{
				Ded13Amt12.OutputFormat = "#,##0.00";
				Ded14Amt12.OutputFormat = "#,##0.00";
				Ded15Amt12.OutputFormat = "#,##0.00";
				Ded16Amt12.OutputFormat = "#,##0.00";
				DedTotal2Amt12.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType12.Text == "4")
			{
				Ded13Amt12.OutputFormat = "###0.00";
				Ded14Amt12.OutputFormat = "###0.00";
				Ded15Amt12.OutputFormat = "###0.00";
				Ded16Amt12.OutputFormat = "###0.00";
				DedTotal2Amt12.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt12.OutputFormat = "#,##0";
				Ded14Amt12.OutputFormat = "#,##0";
				Ded15Amt12.OutputFormat = "#,##0";
				Ded16Amt12.OutputFormat = "#,##0";
				DedTotal2Amt12.OutputFormat = "#,##0";
			}
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

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
			paymntTotal1Amt7Flg = false;	// 支給合計1項目7出力フラグ
			paymntTotal1Amt8Flg = false;	// 支給合計1項目8出力フラグ
			paymntTotal1Amt9Flg = false;	// 支給合計1項目9出力フラグ
			paymntTotal1Amt10Flg = false;	// 支給合計1項目10出力フラグ
			paymntTotal1Amt11Flg = false;	// 支給合計1項目11出力フラグ
			paymntTotal1Amt12Flg = false;	// 支給合計1項目12出力フラグ
			dedTotal1Amt7Flg = false;	// 支給合計1項目7出力フラグ
			dedTotal1Amt8Flg = false;	// 支給合計1項目8出力フラグ
			dedTotal1Amt9Flg = false;	// 支給合計1項目9出力フラグ
			dedTotal1Amt10Flg = false;	// 支給合計1項目10出力フラグ
			dedTotal1Amt11Flg = false;	// 支給合計1項目11出力フラグ
			dedTotal1Amt12Flg = false;	// 支給合計1項目12出力フラグ

			paymntTotal2Amt7Flg = false;	// 支給合計2項目7出力フラグ
			paymntTotal2Amt8Flg = false;	// 支給合計2項目8出力フラグ
			paymntTotal2Amt9Flg = false;	// 支給合計2項目9出力フラグ
			paymntTotal2Amt10Flg = false;	// 支給合計2項目10出力フラグ
			paymntTotal2Amt11Flg = false;	// 支給合計2項目11出力フラグ
			paymntTotal2Amt12Flg = false;	// 支給合計2項目12出力フラグ
			dedTotal2Amt7Flg = false;	// 支給合計2項目7出力フラグ
			dedTotal2Amt8Flg = false;	// 支給合計2項目8出力フラグ
			dedTotal2Amt9Flg = false;	// 支給合計2項目9出力フラグ
			dedTotal2Amt10Flg = false;	// 支給合計2項目10出力フラグ
			dedTotal2Amt11Flg = false;	// 支給合計2項目11出力フラグ
			dedTotal2Amt12Flg = false;	// 支給合計2項目12出力フラグ

			paymntTotal3Amt7Flg = false;	// 支給合計3項目7出力フラグ
			paymntTotal3Amt8Flg = false;	// 支給合計3項目8出力フラグ
			paymntTotal3Amt9Flg = false;	// 支給合計3項目9出力フラグ
			paymntTotal3Amt10Flg = false;	// 支給合計3項目10出力フラグ
			paymntTotal3Amt11Flg = false;	// 支給合計3項目11出力フラグ
			paymntTotal3Amt12Flg = false;	// 支給合計2項目12出力フラグ
			dedTotal3Amt7Flg = false;	// 支給合計3項目7出力フラグ
			dedTotal3Amt8Flg = false;	// 支給合計3項目8出力フラグ
			dedTotal3Amt9Flg = false;	// 支給合計3項目9出力フラグ
			dedTotal3Amt10Flg = false;	// 支給合計3項目10出力フラグ
			dedTotal3Amt11Flg = false;	// 支給合計3項目11出力フラグ
			dedTotal3Amt12Flg = false;	// 支給合計3項目12出力フラグ

// 管理番号K27274 From
//			if ((Ded18Amt13.Text != null) && (Ded18Amt13.Text != "") && (Ded18Amt13.Text != "0"))
//			{
//			}
//			else
//			{
//				Title.Text = "";
//			}
			if ((Ded18Amt9.Text != null) && (Ded18Amt9.Text != "") && (Ded18Amt9.Text != "0"))
			{
			}
			else
			{
				Label111.Text = "";
			}
// 管理番号K27274 To

			//給与支給額、賞与支給額、前職等修正分、年末調整の空白処理
			//給与支給額1
			if (((Paymnt1Amt7.Text == "0") || (Paymnt1Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt1Amt7.Text = "";
			}

			if (((Paymnt1Amt8.Text == "0") || (Paymnt1Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt1Amt8.Text = "";
			}

			if (((Paymnt1Amt9.Text == "0") || (Paymnt1Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt1Amt9.Text = "";
			}

			if (((Paymnt1Amt10.Text == "0") || (Paymnt1Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt1Amt10.Text = "";
			}

			if (((Paymnt1Amt11.Text == "0") || (Paymnt1Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt1Amt11.Text = "";
			}

			if (((Paymnt1Amt12.Text == "0") || (Paymnt1Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt1Amt12.Text = "";
			}

			//給与支給額2
			if (((Paymnt2Amt7.Text == "0") || (Paymnt2Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt2Amt7.Text = "";
			}

			if (((Paymnt2Amt8.Text == "0") || (Paymnt2Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt2Amt8.Text = "";
			}

			if (((Paymnt2Amt9.Text == "0") || (Paymnt2Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt2Amt9.Text = "";
			}

			if (((Paymnt2Amt10.Text == "0") || (Paymnt2Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt2Amt10.Text = "";
			}

			if (((Paymnt2Amt11.Text == "0") || (Paymnt2Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt2Amt11.Text = "";
			}

			if (((Paymnt2Amt12.Text == "0") || (Paymnt2Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt2Amt12.Text = "";
			}

			//給与支給額3
			if (((Paymnt3Amt7.Text == "0") || (Paymnt3Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt3Amt7.Text = "";
			}

			if (((Paymnt3Amt8.Text == "0") || (Paymnt3Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt3Amt8.Text = "";
			}

			if (((Paymnt3Amt9.Text == "0") || (Paymnt3Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt3Amt9.Text = "";
			}

			if (((Paymnt3Amt10.Text == "0") || (Paymnt3Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt3Amt10.Text = "";
			}

			if (((Paymnt3Amt11.Text == "0") || (Paymnt3Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt3Amt11.Text = "";
			}

			if (((Paymnt3Amt12.Text == "0") || (Paymnt3Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt3Amt12.Text = "";
			}

			//給与支給額4
			if (((Paymnt4Amt7.Text == "0") || (Paymnt4Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt4Amt7.Text = "";
			}

			if (((Paymnt4Amt8.Text == "0") || (Paymnt4Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt4Amt8.Text = "";
			}

			if (((Paymnt4Amt9.Text == "0") || (Paymnt4Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt4Amt9.Text = "";
			}

			if (((Paymnt4Amt10.Text == "0") || (Paymnt4Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt4Amt10.Text = "";
			}

			if (((Paymnt4Amt11.Text == "0") || (Paymnt4Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt4Amt11.Text = "";
			}

			if (((Paymnt4Amt12.Text == "0") || (Paymnt4Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt4Amt12.Text = "";
			}

			//給与支給額5
			if (((Paymnt5Amt7.Text == "0") || (Paymnt5Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt5Amt7.Text = "";
			}

			if (((Paymnt5Amt8.Text == "0") || (Paymnt5Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt5Amt8.Text = "";
			}

			if (((Paymnt5Amt9.Text == "0") || (Paymnt5Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt5Amt9.Text = "";
			}

			if (((Paymnt5Amt10.Text == "0") || (Paymnt5Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt5Amt10.Text = "";
			}

			if (((Paymnt5Amt11.Text == "0") || (Paymnt5Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt5Amt11.Text = "";
			}

			if (((Paymnt5Amt12.Text == "0") || (Paymnt5Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt5Amt12.Text = "";
			}

			//給与支給額6
			if (((Paymnt6Amt7.Text == "0") || (Paymnt6Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt6Amt7.Text = "";
			}

			if (((Paymnt6Amt8.Text == "0") || (Paymnt6Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt6Amt8.Text = "";
			}

			if (((Paymnt6Amt9.Text == "0") || (Paymnt6Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt6Amt9.Text = "";
			}

			if (((Paymnt6Amt10.Text == "0") || (Paymnt6Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt6Amt10.Text = "";
			}

			if (((Paymnt6Amt11.Text == "0") || (Paymnt6Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt6Amt11.Text = "";
			}
			if (((Paymnt6Amt12.Text == "0") || (Paymnt6Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt6Amt12.Text = "";
			}

			//給与支給額7
			if (((Paymnt7Amt7.Text == "0") || (Paymnt7Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt7Amt7.Text = "";
			}

			if (((Paymnt7Amt8.Text == "0") || (Paymnt7Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt7Amt8.Text = "";
			}

			if (((Paymnt7Amt9.Text == "0") || (Paymnt7Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt7Amt9.Text = "";
			}

			if (((Paymnt7Amt10.Text == "0") || (Paymnt7Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt7Amt10.Text = "";
			}

			if (((Paymnt7Amt11.Text == "0") || (Paymnt7Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt7Amt11.Text = "";
			}

			if (((Paymnt7Amt12.Text == "0") || (Paymnt7Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt7Amt12.Text = "";
			}

			//給与支給額8
			if (((Paymnt8Amt7.Text == "0") || (Paymnt8Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt8Amt7.Text = "";
			}

			if (((Paymnt8Amt8.Text == "0") || (Paymnt8Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt8Amt8.Text = "";
			}

			if (((Paymnt8Amt9.Text == "0") || (Paymnt8Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt8Amt9.Text = "";
			}

			if (((Paymnt8Amt10.Text == "0") || (Paymnt8Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt8Amt10.Text = "";
			}

			if (((Paymnt8Amt11.Text == "0") || (Paymnt8Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt8Amt11.Text = "";
			}

			if (((Paymnt8Amt12.Text == "0") || (Paymnt8Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt8Amt12.Text = "";
			}

			//給与支給額9
			if (((Paymnt9Amt7.Text == "0") || (Paymnt9Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt9Amt7.Text = "";
			}

			if (((Paymnt9Amt8.Text == "0") || (Paymnt9Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt9Amt8.Text = "";
			}

			if (((Paymnt9Amt9.Text == "0") || (Paymnt9Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt9Amt9.Text = "";
			}

			if (((Paymnt9Amt10.Text == "0") || (Paymnt9Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt9Amt10.Text = "";
			}

			if (((Paymnt9Amt11.Text == "0") || (Paymnt9Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt9Amt11.Text = "";
			}

			if (((Paymnt9Amt12.Text == "0") || (Paymnt9Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt9Amt12.Text = "";
			}

			//給与支給額10
			if (((Paymnt10Amt7.Text == "0") || (Paymnt10Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt10Amt7.Text = "";
			}

			if (((Paymnt10Amt8.Text == "0") || (Paymnt10Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt10Amt8.Text = "";
			}

			if (((Paymnt10Amt9.Text == "0") || (Paymnt10Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt10Amt9.Text = "";
			}

			if (((Paymnt10Amt10.Text == "0") || (Paymnt10Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt10Amt10.Text = "";
			}

			if (((Paymnt10Amt11.Text == "0") || (Paymnt10Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt10Amt11.Text = "";
			}

			if (((Paymnt10Amt12.Text == "0") || (Paymnt10Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt10Amt12.Text = "";
			}

			//給与支給額11
			if (((Paymnt11Amt7.Text == "0") || (Paymnt11Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt11Amt7.Text = "";
			}

			if (((Paymnt11Amt8.Text == "0") || (Paymnt11Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt11Amt8.Text = "";
			}

			if (((Paymnt11Amt9.Text == "0") || (Paymnt11Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt11Amt9.Text = "";
			}

			if (((Paymnt11Amt10.Text == "0") || (Paymnt11Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt11Amt10.Text = "";
			}

			if (((Paymnt11Amt11.Text == "0") || (Paymnt11Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt11Amt11.Text = "";
			}

			if (((Paymnt11Amt12.Text == "0") || (Paymnt11Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt11Amt12.Text = "";
			}

			//給与支給額12
			if (((Paymnt12Amt7.Text == "0") || (Paymnt12Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				Paymnt12Amt7.Text = "";
			}

			if (((Paymnt12Amt8.Text == "0") || (Paymnt12Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				Paymnt12Amt8.Text = "";
			}

			if (((Paymnt12Amt9.Text == "0") || (Paymnt12Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				Paymnt12Amt9.Text = "";
			}

			if (((Paymnt12Amt10.Text == "0") || (Paymnt12Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				Paymnt12Amt10.Text = "";
			}

			if (((Paymnt12Amt11.Text == "0") || (Paymnt12Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt12Amt11.Text = "";
			}

			if (((Paymnt12Amt12.Text == "0") || (Paymnt12Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt12Amt12.Text = "";
			}

			//賞与支給額1
			if (((Paymnt13Amt7.Text == "0") || (Paymnt13Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
			{
				Paymnt13Amt7.Text = "";
			}

			if (((Paymnt13Amt8.Text == "0") || (Paymnt13Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
			{
				Paymnt13Amt8.Text = "";
			}

			if (((Paymnt13Amt9.Text == "0") || (Paymnt13Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
			{
				Paymnt13Amt9.Text = "";
			}

			if (((Paymnt13Amt10.Text == "0") || (Paymnt13Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
			{
				Paymnt13Amt10.Text = "";
			}

			if (((Paymnt13Amt11.Text == "0") || (Paymnt13Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
			{
				Paymnt13Amt11.Text = "";
			}

			if (((Paymnt13Amt12.Text == "0") || (Paymnt13Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
			{
				Paymnt13Amt12.Text = "";
			}

			//賞与支給額2
			if (((Paymnt14Amt7.Text == "0") || (Paymnt14Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
			{
				Paymnt14Amt7.Text = "";
			}

			if (((Paymnt14Amt8.Text == "0") || (Paymnt14Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
			{
				Paymnt14Amt8.Text = "";
			}

			if (((Paymnt14Amt9.Text == "0") || (Paymnt14Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
			{
				Paymnt14Amt9.Text = "";
			}

			if (((Paymnt14Amt10.Text == "0") || (Paymnt14Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
			{
				Paymnt14Amt10.Text = "";
			}

			if (((Paymnt14Amt11.Text == "0") || (Paymnt14Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
			{
				Paymnt14Amt11.Text = "";
			}

			if (((Paymnt14Amt12.Text == "0") || (Paymnt14Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
			{
				Paymnt14Amt12.Text = "";
			}

			//賞与支給額3
			if (((Paymnt15Amt7.Text == "0") || (Paymnt15Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
			{
				Paymnt15Amt7.Text = "";
			}

			if (((Paymnt15Amt8.Text == "0") || (Paymnt15Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
			{
				Paymnt15Amt8.Text = "";
			}

			if (((Paymnt15Amt9.Text == "0") || (Paymnt15Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
			{
				Paymnt15Amt9.Text = "";
			}

			if (((Paymnt15Amt10.Text == "0") || (Paymnt15Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
			{
				Paymnt15Amt10.Text = "";
			}

			if (((Paymnt15Amt11.Text == "0") || (Paymnt15Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
			{
				Paymnt15Amt11.Text = "";
			}

			if (((Paymnt15Amt12.Text == "0") || (Paymnt15Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
			{
				Paymnt15Amt12.Text = "";
			}

			//賞与支給額4
			if (((Paymnt16Amt7.Text == "0") || (Paymnt16Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
			{
				Paymnt16Amt7.Text = "";
			}

			if (((Paymnt16Amt8.Text == "0") || (Paymnt16Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
			{
				Paymnt16Amt8.Text = "";
			}

			if (((Paymnt16Amt9.Text == "0") || (Paymnt16Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
			{
				Paymnt16Amt9.Text = "";
			}

			if (((Paymnt16Amt10.Text == "0") || (Paymnt16Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
			{
				Paymnt16Amt10.Text = "";
			}

			if (((Paymnt16Amt11.Text == "0") || (Paymnt16Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
			{
				Paymnt16Amt11.Text = "";
			}

			if (((Paymnt16Amt12.Text == "0") || (Paymnt16Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
			{
				Paymnt16Amt12.Text = "";
			}

			//給与控除、賞与控除、前職等修正分下段、年末調整控除の空白処理
			//給与控除1
			if (((Ded1Amt7.Text == "0") || (Ded1Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded1Amt7.Text = "";
			}

			if (((Ded1Amt8.Text == "0") || (Ded1Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded1Amt8.Text = "";
			}

			if (((Ded1Amt9.Text == "0") || (Ded1Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded1Amt9.Text = "";
			}

			if (((Ded1Amt10.Text == "0") || (Ded1Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded1Amt10.Text = "";
			}

			if (((Ded1Amt11.Text == "0") || (Ded1Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded1Amt11.Text = "";
			}

			if (((Ded1Amt12.Text == "0") || (Ded1Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded1Amt12.Text = "";
			}

			//給与控除2
			if (((Ded2Amt7.Text == "0") || (Ded2Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded2Amt7.Text = "";
			}

			if (((Ded2Amt8.Text == "0") || (Ded2Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded2Amt8.Text = "";
			}

			if (((Ded2Amt9.Text == "0") || (Ded2Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded2Amt9.Text = "";
			}

			if (((Ded2Amt10.Text == "0") || (Ded2Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded2Amt10.Text = "";
			}

			if (((Ded2Amt11.Text == "0") || (Ded2Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded2Amt11.Text = "";
			}

			if (((Ded2Amt12.Text == "0") || (Ded2Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded2Amt12.Text = "";
			}

			//給与控除3
			if (((Ded3Amt7.Text == "0") || (Ded3Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded3Amt7.Text = "";
			}

			if (((Ded3Amt8.Text == "0") || (Ded3Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded3Amt8.Text = "";
			}

			if (((Ded3Amt9.Text == "0") || (Ded3Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded3Amt9.Text = "";
			}

			if (((Ded3Amt10.Text == "0") || (Ded3Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded3Amt10.Text = "";
			}

			if (((Ded3Amt11.Text == "0") || (Ded3Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded3Amt11.Text = "";
			}

			if (((Ded3Amt12.Text == "0") || (Ded3Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded3Amt12.Text = "";
			}

			//給与控除4
			if (((Ded4Amt7.Text == "0") || (Ded4Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded4Amt7.Text = "";
			}

			if (((Ded4Amt8.Text == "0") || (Ded4Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded4Amt8.Text = "";
			}

			if (((Ded4Amt9.Text == "0") || (Ded4Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded4Amt9.Text = "";
			}

			if (((Ded4Amt10.Text == "0") || (Ded4Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded4Amt10.Text = "";
			}

			if (((Ded4Amt11.Text == "0") || (Ded4Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded4Amt11.Text = "";
			}

			if (((Ded4Amt12.Text == "0") || (Ded4Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded4Amt12.Text = "";
			}

			//給与控除5
			if (((Ded5Amt7.Text == "0") || (Ded5Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded5Amt7.Text = "";
			}

			if (((Ded5Amt8.Text == "0") || (Ded5Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded5Amt8.Text = "";
			}

			if (((Ded5Amt9.Text == "0") || (Ded5Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded5Amt9.Text = "";
			}

			if (((Ded5Amt10.Text == "0") || (Ded5Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded5Amt10.Text = "";
			}

			if (((Ded5Amt11.Text == "0") || (Ded5Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded5Amt11.Text = "";
			}

			if (((Ded5Amt12.Text == "0") || (Ded5Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded5Amt12.Text = "";
			}

			//給与控除6
			if (((Ded6Amt7.Text == "0") || (Ded6Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded6Amt7.Text = "";
			}

			if (((Ded6Amt8.Text == "0") || (Ded6Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded6Amt8.Text = "";
			}

			if (((Ded6Amt9.Text == "0") || (Ded6Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded6Amt9.Text = "";
			}

			if (((Ded6Amt10.Text == "0") || (Ded6Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded6Amt10.Text = "";
			}

			if (((Ded6Amt11.Text == "0") || (Ded6Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded6Amt11.Text = "";
			}

			if (((Ded6Amt12.Text == "0") || (Ded6Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded6Amt12.Text = "";
			}

			//給与控除7
			if (((Ded7Amt7.Text == "0") || (Ded7Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded7Amt7.Text = "";
			}

			if (((Ded7Amt8.Text == "0") || (Ded7Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded7Amt8.Text = "";
			}

			if (((Ded7Amt9.Text == "0") || (Ded7Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded7Amt9.Text = "";
			}

			if (((Ded7Amt10.Text == "0") || (Ded7Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded7Amt10.Text = "";
			}

			if (((Ded7Amt11.Text == "0") || (Ded7Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded7Amt11.Text = "";
			}

			if (((Ded7Amt12.Text == "0") || (Ded7Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded7Amt12.Text = "";
			}

			//給与控除8
			if (((Ded8Amt7.Text == "0") || (Ded8Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded8Amt7.Text = "";
			}

			if (((Ded8Amt8.Text == "0") || (Ded8Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded8Amt8.Text = "";
			}

			if (((Ded8Amt9.Text == "0") || (Ded8Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded8Amt9.Text = "";
			}

			if (((Ded8Amt10.Text == "0") || (Ded8Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded8Amt10.Text = "";
			}

			if (((Ded8Amt11.Text == "0") || (Ded8Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded8Amt11.Text = "";
			}

			if (((Ded8Amt12.Text == "0") || (Ded8Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded8Amt12.Text = "";
			}

			//給与控除9
			if (((Ded9Amt7.Text == "0") || (Ded9Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded9Amt7.Text = "";
			}

			if (((Ded9Amt8.Text == "0") || (Ded9Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded9Amt8.Text = "";
			}

			if (((Ded9Amt9.Text == "0") || (Ded9Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded9Amt9.Text = "";
			}

			if (((Ded9Amt10.Text == "0") || (Ded9Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded9Amt10.Text = "";
			}

			if (((Ded9Amt11.Text == "0") || (Ded9Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded9Amt11.Text = "";
			}

			if (((Ded9Amt12.Text == "0") || (Ded9Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded9Amt12.Text = "";
			}

			//給与控除10
			if (((Ded10Amt7.Text == "0") || (Ded10Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded10Amt7.Text = "";
			}

			if (((Ded10Amt8.Text == "0") || (Ded10Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded10Amt8.Text = "";
			}

			if (((Ded10Amt9.Text == "0") || (Ded10Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded10Amt9.Text = "";
			}

			if (((Ded10Amt10.Text == "0") || (Ded10Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded10Amt10.Text = "";
			}

			if (((Ded10Amt11.Text == "0") || (Ded10Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded10Amt11.Text = "";
			}

			if (((Ded10Amt12.Text == "0") || (Ded10Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded10Amt12.Text = "";
			}

			//給与控除11
			if (((Ded11Amt7.Text == "0") || (Ded11Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded11Amt7.Text = "";
			}

			if (((Ded11Amt8.Text == "0") || (Ded11Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded11Amt8.Text = "";
			}

			if (((Ded11Amt9.Text == "0") || (Ded11Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded11Amt9.Text = "";
			}

			if (((Ded11Amt10.Text == "0") || (Ded11Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded11Amt10.Text = "";
			}

			if (((Ded11Amt11.Text == "0") || (Ded11Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded11Amt11.Text = "";
			}

			if (((Ded11Amt12.Text == "0") || (Ded11Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded11Amt12.Text = "";
			}

			//給与控除12
			if (((Ded12Amt7.Text == "0") || (Ded12Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded12Amt7.Text = "";
			}

			if (((Ded12Amt8.Text == "0") || (Ded12Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				Ded12Amt8.Text = "";
			}

			if (((Ded12Amt9.Text == "0") || (Ded12Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				Ded12Amt9.Text = "";
			}

			if (((Ded12Amt10.Text == "0") || (Ded12Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				Ded12Amt10.Text = "";
			}

			if (((Ded12Amt11.Text == "0") || (Ded12Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded12Amt11.Text = "";
			}

			if (((Ded12Amt12.Text == "0") || (Ded12Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				Ded12Amt12.Text = "";
			}

			//賞与控除1
			if (((Ded13Amt7.Text == "0") || (Ded13Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
			{
				Ded13Amt7.Text = "";
			}

			if (((Ded13Amt8.Text == "0") || (Ded13Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
			{
				Ded13Amt8.Text = "";
			}

			if (((Ded13Amt9.Text == "0") || (Ded13Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
			{
				Ded13Amt9.Text = "";
			}

			if (((Ded13Amt10.Text == "0") || (Ded13Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
			{
				Ded13Amt10.Text = "";
			}

			if (((Ded13Amt11.Text == "0") || (Ded13Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
			{
				Ded13Amt11.Text = "";
			}

			if (((Ded13Amt12.Text == "0") || (Ded13Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
			{
				Ded13Amt12.Text = "";
			}

			//賞与控除2
			if (((Ded14Amt7.Text == "0") || (Ded14Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
			{
				Ded14Amt7.Text = "";
			}

			if (((Ded14Amt8.Text == "0") || (Ded14Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
			{
				Ded14Amt8.Text = "";
			}

			if (((Ded14Amt9.Text == "0") || (Ded14Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
			{
				Ded14Amt9.Text = "";
			}

			if (((Ded14Amt10.Text == "0") || (Ded14Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
			{
				Ded14Amt10.Text = "";
			}

			if (((Ded14Amt11.Text == "0") || (Ded14Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
			{
				Ded14Amt11.Text = "";
			}

			if (((Ded14Amt12.Text == "0") || (Ded14Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
			{
				Ded14Amt12.Text = "";
			}

			//賞与控除3
			if (((Ded15Amt7.Text == "0") || (Ded15Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
			{
				Ded15Amt7.Text = "";
			}

			if (((Ded15Amt8.Text == "0") || (Ded15Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
			{
				Ded15Amt8.Text = "";
			}

			if (((Ded15Amt9.Text == "0") || (Ded15Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
			{
				Ded15Amt9.Text = "";
			}

			if (((Ded15Amt10.Text == "0") || (Ded15Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
			{
				Ded15Amt10.Text = "";
			}

			if (((Ded15Amt11.Text == "0") || (Ded15Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
			{
				Ded15Amt11.Text = "";
			}

			if (((Ded15Amt12.Text == "0") || (Ded15Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
			{
				Ded15Amt12.Text = "";
			}

			//賞与控除4
			if (((Ded16Amt7.Text == "0") || (Ded16Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
			{
				Ded16Amt7.Text = "";
			}

			if (((Ded16Amt8.Text == "0") || (Ded16Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
			{
				Ded16Amt8.Text = "";
			}

			if (((Ded16Amt9.Text == "0") || (Ded16Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
			{
				Ded16Amt9.Text = "";
			}

			if (((Ded16Amt10.Text == "0") || (Ded16Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
			{
				Ded16Amt10.Text = "";
			}

			if (((Ded16Amt11.Text == "0") || (Ded16Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
			{
				Ded16Amt11.Text = "";
			}

			if (((Ded16Amt12.Text == "0") || (Ded16Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
			{
				Ded16Amt12.Text = "";
			}

// 管理番号K27274 From
//			if ((Ded18Amt13.Text != "0") && (Ded18Amt13.Text != "0.00") && (Ded18Amt13.Text != "") && (Ded18Amt13.Text != null) && (Title.Text.Length > 0))
//			{
//				// 絶対値を表示する
//				Ded18Amt13.Text = Ded18Amt13.Text.Replace("-", "");
//				Ded18Amt8.Text = Ded18Amt13.Text;
//			}
//			else
//			{
//				Ded18Amt8.Text = "";
//			}
			if ((Ded18Amt9.Text != "0") && (Ded18Amt9.Text != "0.00") && (Ded18Amt9.Text != "") && (Ded18Amt9.Text != null) && (Label111.Text.Length > 0))
			{
				// 絶対値を表示する
				Ded18Amt9.Text = Ded18Amt9.Text.Replace("-", "");
			}
			else
			{
				Ded18Amt9.Text = "";
			}
// 管理番号K27274 To

			//給与支給額の合計処理
			if ((Paymnt1Amt7.Text == null) || (Paymnt1Amt7.Text == ""))
			{
				paymntTotal1Amt7 = 0;
			}
			else
			{
				paymntTotal1Amt7 = Convert.ToDouble(Paymnt1Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt2Amt7.Text == null) || (Paymnt2Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt2Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt3Amt7.Text == null) || (Paymnt3Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt3Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt4Amt7.Text == null) || (Paymnt4Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt4Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt5Amt7.Text == null) || (Paymnt5Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt5Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt6Amt7.Text == null) || (Paymnt6Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt6Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt7Amt7.Text == null) || (Paymnt7Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt7Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt8Amt7.Text == null) || (Paymnt8Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt8Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt9Amt7.Text == null) || (Paymnt9Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt9Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt10Amt7.Text == null) || (Paymnt10Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt10Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt11Amt7.Text == null) || (Paymnt11Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt11Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if ((Paymnt12Amt7.Text == null) || (Paymnt12Amt7.Text == ""))
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
			}
			else
			{
				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt12Amt7.Text);
				paymntTotal1Amt7Flg = true;
			}

			if (paymntTotal1Amt7Flg)
			{
				if (PaymntDispType7.Text == "2")
				{
					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("###0");
				}

				else if (PaymntDispType7.Text == "3")
				{
					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("#,##0.00");
				}

				else if (PaymntDispType7.Text == "4")
				{
					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt7.Text = "";
			}

			if ((Paymnt1Amt8.Text == null) || (Paymnt1Amt8.Text == ""))
			{
				paymntTotal1Amt8 = 0;
			}
			else
			{
				paymntTotal1Amt8 = Convert.ToDouble(Paymnt1Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt2Amt8.Text == null) || (Paymnt2Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt2Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt3Amt8.Text == null) || (Paymnt3Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt3Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt4Amt8.Text == null) || (Paymnt4Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt4Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt5Amt8.Text == null) || (Paymnt5Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt5Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt6Amt8.Text == null) || (Paymnt6Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt6Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt7Amt8.Text == null) || (Paymnt7Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt7Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt8Amt8.Text == null) || (Paymnt8Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt8Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt9Amt8.Text == null) || (Paymnt9Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt9Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt10Amt8.Text == null) || (Paymnt10Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt10Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt11Amt8.Text == null) || (Paymnt11Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt11Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if ((Paymnt12Amt8.Text == null) || (Paymnt12Amt8.Text == ""))
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
			}
			else
			{
				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt12Amt8.Text);
				paymntTotal1Amt8Flg = true;
			}

			if (paymntTotal1Amt8Flg)
			{
				if (PaymntDispType8.Text == "2")
				{
					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("###0");
				}

				else if (PaymntDispType8.Text == "3")
				{
					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("#,##0.00");
				}

				else if (PaymntDispType8.Text == "4")
				{
					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt8.Text = "";
			}

			if ((Paymnt1Amt9.Text == null) || (Paymnt1Amt9.Text == ""))
			{
				paymntTotal1Amt9 = 0;
			}
			else
			{
				paymntTotal1Amt9 = Convert.ToDouble(Paymnt1Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt2Amt9.Text == null) || (Paymnt2Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt2Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt3Amt9.Text == null) || (Paymnt3Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt3Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt4Amt9.Text == null) || (Paymnt4Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt4Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt5Amt9.Text == null) || (Paymnt5Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt5Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt6Amt9.Text == null) || (Paymnt6Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt6Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt7Amt9.Text == null) || (Paymnt7Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt7Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt8Amt9.Text == null) || (Paymnt8Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt8Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt9Amt9.Text == null) || (Paymnt9Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt9Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt10Amt9.Text == null) || (Paymnt10Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt10Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt11Amt9.Text == null) || (Paymnt11Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt11Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if ((Paymnt12Amt9.Text == null) || (Paymnt12Amt9.Text == ""))
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
			}
			else
			{
				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt12Amt9.Text);
				paymntTotal1Amt9Flg = true;
			}

			if (paymntTotal1Amt9Flg)
			{
				if (PaymntDispType9.Text == "2")
				{
					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("###0");
				}

				else if (PaymntDispType9.Text == "3")
				{
					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("#,##0.00");
				}

				else if (PaymntDispType9.Text == "4")
				{
					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt9.Text = "";
			}

			if ((Paymnt1Amt10.Text == null) || (Paymnt1Amt10.Text == ""))
			{
				paymntTotal1Amt10 = 0;
			}
			else
			{
				paymntTotal1Amt10 = Convert.ToDouble(Paymnt1Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt2Amt10.Text == null) || (Paymnt2Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt2Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt3Amt10.Text == null) || (Paymnt3Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt3Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt4Amt10.Text == null) || (Paymnt4Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt4Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt5Amt10.Text == null) || (Paymnt5Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt5Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt6Amt10.Text == null) || (Paymnt6Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt6Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt7Amt10.Text == null) || (Paymnt7Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt7Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt8Amt10.Text == null) || (Paymnt8Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt8Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt9Amt10.Text == null) || (Paymnt9Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt9Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt10Amt10.Text == null) || (Paymnt10Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt10Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt11Amt10.Text == null) || (Paymnt11Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt11Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if ((Paymnt12Amt10.Text == null) || (Paymnt12Amt10.Text == ""))
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
			}
			else
			{
				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt12Amt10.Text);
				paymntTotal1Amt10Flg = true;
			}

			if (paymntTotal1Amt10Flg)
			{
				if (PaymntDispType10.Text == "2")
				{
					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("###0");
				}

				else if (PaymntDispType10.Text == "3")
				{
					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("#,##0.00");
				}

				else if (PaymntDispType10.Text == "4")
				{
					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt10.Text = "";
			}

			if ((Paymnt1Amt11.Text == null) || (Paymnt1Amt11.Text == ""))
			{
				paymntTotal1Amt11 = 0;
			}
			else
			{
				paymntTotal1Amt11 = Convert.ToDouble(Paymnt1Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt2Amt11.Text == null) || (Paymnt2Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt2Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt3Amt11.Text == null) || (Paymnt3Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt3Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt4Amt11.Text == null) || (Paymnt4Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt4Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt5Amt11.Text == null) || (Paymnt5Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt5Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt6Amt11.Text == null) || (Paymnt6Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt6Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt7Amt11.Text == null) || (Paymnt7Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt7Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt8Amt11.Text == null) || (Paymnt8Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt8Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt9Amt11.Text == null) || (Paymnt9Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt9Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt10Amt11.Text == null) || (Paymnt10Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt10Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt11Amt11.Text == null) || (Paymnt11Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt11Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if ((Paymnt12Amt11.Text == null) || (Paymnt12Amt11.Text == ""))
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
			}
			else
			{
				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt12Amt11.Text);
				paymntTotal1Amt11Flg = true;
			}

			if (paymntTotal1Amt11Flg)
			{
				if (PaymntDispType11.Text == "2")
				{
					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("###0");
				}

				else if (PaymntDispType11.Text == "3")
				{
					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("#,##0.00");
				}

				else if (PaymntDispType12.Text == "4")
				{
					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt11.Text = "";
			}

			if ((Paymnt1Amt12.Text == null) || (Paymnt1Amt12.Text == ""))
			{
				paymntTotal1Amt12 = 0;
			}
			else
			{
				paymntTotal1Amt12 = Convert.ToDouble(Paymnt1Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt2Amt12.Text == null) || (Paymnt2Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt2Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt3Amt12.Text == null) || (Paymnt3Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt3Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt4Amt12.Text == null) || (Paymnt4Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt4Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt5Amt12.Text == null) || (Paymnt5Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt5Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt6Amt12.Text == null) || (Paymnt6Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt6Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt7Amt12.Text == null) || (Paymnt7Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt7Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt8Amt12.Text == null) || (Paymnt8Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt8Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt9Amt12.Text == null) || (Paymnt9Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt9Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt10Amt12.Text == null) || (Paymnt10Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt10Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt11Amt12.Text == null) || (Paymnt11Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt11Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if ((Paymnt12Amt12.Text == null) || (Paymnt12Amt12.Text == ""))
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
			}
			else
			{
				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt12Amt12.Text);
				paymntTotal1Amt12Flg = true;
			}

			if (paymntTotal1Amt12Flg)
			{
				if (PaymntDispType12.Text == "2")
				{
					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("###0");
				}

				else if (PaymntDispType12.Text == "3")
				{
					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("#,##0.00");
				}

				else if (PaymntDispType12.Text == "4")
				{
					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal1Amt12.Text = "";
			}

			//賞与支給総合計の処理
			if ((Paymnt13Amt7.Text == null) || (Paymnt13Amt7.Text == ""))
			{
				paymntTotal2Amt7 = 0;
			}
			else
			{
				paymntTotal2Amt7 = Convert.ToDouble(Paymnt13Amt7.Text);
				paymntTotal2Amt7Flg = true;
			}

			if ((Paymnt14Amt7.Text == null) || (Paymnt14Amt7.Text == ""))
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
			}
			else
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt14Amt7.Text);
				paymntTotal2Amt7Flg = true;
			}

			if ((Paymnt15Amt7.Text == null) || (Paymnt15Amt7.Text == ""))
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
			}
			else
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt15Amt7.Text);
				paymntTotal2Amt7Flg = true;
			}

			if ((Paymnt16Amt7.Text == null) || (Paymnt16Amt7.Text == ""))
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
			}
			else
			{
				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt16Amt7.Text);
				paymntTotal2Amt7Flg = true;
			}

			if (paymntTotal2Amt7Flg)
			{
				if (PaymntBnsDispType7.Text == "2")
				{
					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("###0");
				}
				else if (PaymntBnsDispType7.Text == "3")
				{
					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType7.Text == "4")
				{
					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt7.Text = "";
			}

			if ((Paymnt13Amt8.Text == null) || (Paymnt13Amt8.Text == ""))
			{
				paymntTotal2Amt8 = 0;
			}
			else
			{
				paymntTotal2Amt8 = Convert.ToDouble(Paymnt13Amt8.Text);
				paymntTotal2Amt8Flg = true;
			}

			if ((Paymnt14Amt8.Text == null) || (Paymnt14Amt8.Text == ""))
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
			}
			else
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt14Amt8.Text);
				paymntTotal2Amt8Flg = true;
			}

			if ((Paymnt15Amt8.Text == null) || (Paymnt15Amt8.Text == ""))
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
			}
			else
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt15Amt8.Text);
				paymntTotal2Amt8Flg = true;
			}

			if ((Paymnt16Amt8.Text == null) || (Paymnt16Amt8.Text == ""))
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
			}
			else
			{
				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt16Amt8.Text);
				paymntTotal2Amt8Flg = true;
			}

			if (paymntTotal2Amt8Flg)
			{
				if (PaymntBnsDispType8.Text == "2")
				{
					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("###0");
				}
				else if (PaymntBnsDispType8.Text == "3")
				{
					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType8.Text == "4")
				{
					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt8.Text = "";
			}

			if ((Paymnt13Amt9.Text == null) || (Paymnt13Amt9.Text == ""))
			{
				paymntTotal2Amt9 = 0;
			}
			else
			{
				paymntTotal2Amt9 = Convert.ToDouble(Paymnt13Amt9.Text);
				paymntTotal2Amt9Flg = true;
			}

			if ((Paymnt14Amt9.Text == null) || (Paymnt14Amt9.Text == ""))
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
			}
			else
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt14Amt9.Text);
				paymntTotal2Amt9Flg = true;
			}

			if ((Paymnt15Amt9.Text == null) || (Paymnt15Amt9.Text == ""))
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
			}
			else
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt15Amt9.Text);
				paymntTotal2Amt9Flg = true;
			}

			if ((Paymnt16Amt9.Text == null) || (Paymnt16Amt9.Text == ""))
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
			}
			else
			{
				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt16Amt9.Text);
				paymntTotal2Amt9Flg = true;
			}

			if (paymntTotal2Amt9Flg)
			{
				if (PaymntBnsDispType9.Text == "2")
				{
					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("###0");
				}
				else if (PaymntBnsDispType9.Text == "3")
				{
					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType9.Text == "4")
				{
					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt9.Text = "";
			}

			if ((Paymnt13Amt10.Text == null) || (Paymnt13Amt10.Text == ""))
			{
				paymntTotal2Amt10 = 0;
			}
			else
			{
				paymntTotal2Amt10 = Convert.ToDouble(Paymnt13Amt10.Text);
				paymntTotal2Amt10Flg = true;
			}

			if ((Paymnt14Amt10.Text == null) || (Paymnt14Amt10.Text == ""))
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
			}
			else
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt14Amt10.Text);
				paymntTotal2Amt10Flg = true;
			}

			if ((Paymnt15Amt10.Text == null) || (Paymnt15Amt10.Text == ""))
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
			}
			else
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt15Amt10.Text);
				paymntTotal2Amt10Flg = true;
			}

			if ((Paymnt16Amt10.Text == null) || (Paymnt16Amt10.Text == ""))
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
			}
			else
			{
				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt16Amt10.Text);
				paymntTotal2Amt10Flg = true;
			}

			if (paymntTotal2Amt10Flg)
			{
				if (PaymntBnsDispType10.Text == "2")
				{
					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("###0");
				}
				else if (PaymntBnsDispType10.Text == "3")
				{
					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType10.Text == "4")
				{
					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt10.Text = "";
			}

			if ((Paymnt13Amt11.Text == null) || (Paymnt13Amt11.Text == ""))
			{
				paymntTotal2Amt11 = 0;
			}
			else
			{
				paymntTotal2Amt11 = Convert.ToDouble(Paymnt13Amt11.Text);
				paymntTotal2Amt11Flg = true;
			}

			if ((Paymnt14Amt11.Text == null) || (Paymnt14Amt11.Text == ""))
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
			}
			else
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt14Amt11.Text);
				paymntTotal2Amt11Flg = true;
			}

			if ((Paymnt15Amt11.Text == null) || (Paymnt15Amt11.Text == ""))
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
			}
			else
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt15Amt11.Text);
				paymntTotal2Amt11Flg = true;
			}

			if ((Paymnt16Amt11.Text == null) || (Paymnt16Amt11.Text == ""))
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
			}
			else
			{
				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt16Amt11.Text);
				paymntTotal2Amt11Flg = true;
			}

			if (paymntTotal2Amt11Flg)
			{
				if (PaymntBnsDispType11.Text == "2")
				{
					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("###0");
				}
				else if (PaymntBnsDispType11.Text == "3")
				{
					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType11.Text == "4")
				{
					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt11.Text = "";
			}

			if ((Paymnt13Amt12.Text == null) || (Paymnt13Amt12.Text == ""))
			{
				paymntTotal2Amt12 = 0;
			}
			else
			{
				paymntTotal2Amt12 = Convert.ToDouble(Paymnt13Amt12.Text);
				paymntTotal2Amt12Flg = true;
			}

			if ((Paymnt14Amt12.Text == null) || (Paymnt14Amt12.Text == ""))
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
			}
			else
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt14Amt12.Text);
				paymntTotal2Amt12Flg = true;
			}

			if ((Paymnt15Amt12.Text == null) || (Paymnt15Amt12.Text == ""))
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
			}
			else
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt15Amt12.Text);
				paymntTotal2Amt12Flg = true;
			}

			if ((Paymnt16Amt12.Text == null) || (Paymnt16Amt12.Text == ""))
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
			}
			else
			{
				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt16Amt12.Text);
				paymntTotal2Amt12Flg = true;
			}

			if (paymntTotal2Amt12Flg)
			{
				if (PaymntBnsDispType12.Text == "2")
				{
					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("###0");
				}
				else if (PaymntBnsDispType12.Text == "3")
				{
					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("#,##0.00");
				}
				else if (PaymntBnsDispType12.Text == "4")
				{
					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("###0.00");
				}
				else
				{
					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal2Amt12.Text = "";
			}


			//給与控除額の合計処理
			if ((Ded1Amt7.Text == null) || (Ded1Amt7.Text == ""))
			{
				dedTotal1Amt7 = 0;
			}
			else
			{
				dedTotal1Amt7 = Convert.ToDouble(Ded1Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded2Amt7.Text == null) || (Ded2Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded2Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded3Amt7.Text == null) || (Ded3Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded3Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded4Amt7.Text == null) || (Ded4Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded4Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded5Amt7.Text == null) || (Ded5Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded5Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded6Amt7.Text == null) || (Ded6Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded6Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded7Amt7.Text == null) || (Ded7Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded7Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded8Amt7.Text == null) || (Ded8Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded8Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded9Amt7.Text == null) || (Ded9Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded9Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded10Amt7.Text == null) || (Ded10Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded10Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded11Amt7.Text == null) || (Ded11Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded11Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if ((Ded12Amt7.Text == null) || (Ded12Amt7.Text == ""))
			{
				dedTotal1Amt7 = dedTotal1Amt7 + 0;
			}
			else
			{
				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded12Amt7.Text);
				dedTotal1Amt7Flg = true;
			}

			if (dedTotal1Amt7Flg)
			{
				if (DedDispType7.Text == "2")
				{
					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("###0");
				}
				else if (DedDispType7.Text == "3")
				{
					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("#,##0.00");
				}
				else if (DedDispType7.Text == "4")
				{
					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("###0.00");
				}
				else
				{
					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt7.Text = "";
			}

			if ((Ded1Amt8.Text == null) || (Ded1Amt8.Text == ""))
			{
				dedTotal1Amt8 = 0;
			}
			else
			{
				dedTotal1Amt8 = Convert.ToDouble(Ded1Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded2Amt8.Text == null) || (Ded2Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded2Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded3Amt8.Text == null) || (Ded3Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded3Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded4Amt8.Text == null) || (Ded4Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded4Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded5Amt8.Text == null) || (Ded5Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded5Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded6Amt8.Text == null) || (Ded6Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded6Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded7Amt8.Text == null) || (Ded7Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded7Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded8Amt8.Text == null) || (Ded8Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded8Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded9Amt8.Text == null) || (Ded9Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded9Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded10Amt8.Text == null) || (Ded10Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded10Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded11Amt8.Text == null) || (Ded11Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded11Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if ((Ded12Amt8.Text == null) || (Ded12Amt8.Text == ""))
			{
				dedTotal1Amt8 = dedTotal1Amt8 + 0;
			}
			else
			{
				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded12Amt8.Text);
				dedTotal1Amt8Flg = true;
			}

			if (dedTotal1Amt8Flg)
			{
				if (DedDispType8.Text == "2")
				{
					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("###0");
				}

				else if (DedDispType8.Text == "3")
				{
					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("#,##0.00");
				}

				else if (DedDispType8.Text == "4")
				{
					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt8.Text = "";
			}

			if ((Ded1Amt9.Text == null) || (Ded1Amt9.Text == ""))
			{
				dedTotal1Amt9 = 0;
			}
			else
			{
				dedTotal1Amt9 = Convert.ToDouble(Ded1Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded2Amt9.Text == null) || (Ded2Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded2Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded3Amt9.Text == null) || (Ded3Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded3Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded4Amt9.Text == null) || (Ded4Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded4Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded5Amt9.Text == null) || (Ded5Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded5Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded6Amt9.Text == null) || (Ded6Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded6Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded7Amt9.Text == null) || (Ded7Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded7Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded8Amt9.Text == null) || (Ded8Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded8Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded9Amt9.Text == null) || (Ded9Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded9Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded10Amt9.Text == null) || (Ded10Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded10Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded11Amt9.Text == null) || (Ded11Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded11Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if ((Ded12Amt9.Text == null) || (Ded12Amt9.Text == ""))
			{
				dedTotal1Amt9 = dedTotal1Amt9 + 0;
			}
			else
			{
				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded12Amt9.Text);
				dedTotal1Amt9Flg = true;
			}

			if (dedTotal1Amt9Flg)
			{
				if (DedDispType9.Text == "2")
				{
					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("###0");
				}
				else if (DedDispType9.Text == "3")
				{
					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("#,##0.00");
				}
				else if (DedDispType9.Text == "4")
				{
					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("###0.00");
				}
				else
				{
					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt9.Text = "";
			}

			if ((Ded1Amt10.Text == null) || (Ded1Amt10.Text == ""))
			{
				dedTotal1Amt10 = 0;
			}
			else
			{
				dedTotal1Amt10 = Convert.ToDouble(Ded1Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded2Amt10.Text == null) || (Ded2Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded2Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded3Amt10.Text == null) || (Ded3Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded3Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded4Amt10.Text == null) || (Ded4Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded4Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded5Amt10.Text == null) || (Ded5Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded5Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded6Amt10.Text == null) || (Ded6Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded6Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded7Amt10.Text == null) || (Ded7Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded7Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded8Amt10.Text == null) || (Ded8Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded8Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded9Amt10.Text == null) || (Ded9Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded9Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded10Amt10.Text == null) || (Ded10Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded10Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded11Amt10.Text == null) || (Ded11Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded11Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if ((Ded12Amt10.Text == null) || (Ded12Amt10.Text == ""))
			{
				dedTotal1Amt10 = dedTotal1Amt10 + 0;
			}
			else
			{
				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded12Amt10.Text);
				dedTotal1Amt10Flg = true;
			}

			if (dedTotal1Amt10Flg)
			{
				if (DedDispType10.Text == "2")
				{
					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("###0");
				}
				else if (DedDispType10.Text == "3")
				{
					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("#,##0.00");
				}
				else if (DedDispType10.Text == "4")
				{
					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("###0.00");
				}
				else
				{
					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt10.Text = "";
			}

			if ((Ded1Amt11.Text == null) || (Ded1Amt11.Text == ""))
			{
				dedTotal1Amt11 = 0;
			}
			else
			{
				dedTotal1Amt11 = Convert.ToDouble(Ded1Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded2Amt11.Text == null) || (Ded2Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded2Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded3Amt11.Text == null) || (Ded3Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded3Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded4Amt11.Text == null) || (Ded4Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded4Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded5Amt11.Text == null) || (Ded5Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded5Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded6Amt11.Text == null) || (Ded6Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded6Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded7Amt11.Text == null) || (Ded7Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded7Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded8Amt11.Text == null) || (Ded8Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded8Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded9Amt11.Text == null) || (Ded9Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded9Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded10Amt11.Text == null) || (Ded10Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded10Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded11Amt11.Text == null) || (Ded11Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded11Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if ((Ded12Amt11.Text == null) || (Ded12Amt11.Text == ""))
			{
				dedTotal1Amt11 = dedTotal1Amt11 + 0;
			}
			else
			{
				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded12Amt11.Text);
				dedTotal1Amt11Flg = true;
			}

			if (dedTotal1Amt11Flg)
			{
				if (DedDispType11.Text == "2")
				{
					DedTotal1Amt11.Text = dedTotal1Amt11.ToString("###0");
				}
				else if (DedDispType11.Text == "3")
				{
					DedTotal1Amt11.Text = dedTotal1Amt11.ToString("#,##0.00");
				}
				else if (DedDispType11.Text == "4")
				{
					DedTotal1Amt11.Text = dedTotal1Amt11.ToString("###0.00");
				}
				else
				{
					DedTotal1Amt11.Text = dedTotal1Amt11.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt11.Text = "";
			}

			if ((Ded1Amt12.Text == null) || (Ded1Amt12.Text == ""))
			{
				dedTotal1Amt12 = 0;
			}
			else
			{
				dedTotal1Amt12 = Convert.ToDouble(Ded1Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded2Amt12.Text == null) || (Ded2Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded2Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded3Amt12.Text == null) || (Ded3Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded3Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded4Amt12.Text == null) || (Ded4Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded4Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded5Amt12.Text == null) || (Ded5Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded5Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded6Amt12.Text == null) || (Ded6Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded6Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded7Amt12.Text == null) || (Ded7Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded7Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded8Amt12.Text == null) || (Ded8Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded8Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded9Amt12.Text == null) || (Ded9Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded9Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded10Amt12.Text == null) || (Ded10Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded10Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded11Amt12.Text == null) || (Ded11Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded11Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if ((Ded12Amt12.Text == null) || (Ded12Amt12.Text == ""))
			{
				dedTotal1Amt12 = dedTotal1Amt12 + 0;
			}
			else
			{
				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded12Amt12.Text);
				dedTotal1Amt12Flg = true;
			}

			if (dedTotal1Amt12Flg)
			{
				if (DedDispType12.Text == "2")
				{
					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("###0");
				}

				else if (DedDispType12.Text == "3")
				{
					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("#,##0.00");
				}

				else if (DedDispType12.Text == "4")
				{
					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("#,##0");
				}
			}
			else
			{
				DedTotal1Amt12.Text = "";
			}


			//賞与控除合計の処理
			if ((Ded13Amt7.Text == null) || (Ded13Amt7.Text == ""))
			{
				dedTotal2Amt7 = 0;
			}
			else
			{
				dedTotal2Amt7 = Convert.ToDouble(Ded13Amt7.Text);
				dedTotal2Amt7Flg = true;
			}

			if ((Ded14Amt7.Text == null) || (Ded14Amt7.Text == ""))
			{
				dedTotal2Amt7 = dedTotal2Amt7 + 0;
			}
			else
			{
				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded14Amt7.Text);
				dedTotal2Amt7Flg = true;
			}

			if ((Ded15Amt7.Text == null) || (Ded15Amt7.Text == ""))
			{
				dedTotal2Amt7 = dedTotal2Amt7 + 0;
			}
			else
			{
				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded15Amt7.Text);
				dedTotal2Amt7Flg = true;
			}

			if ((Ded16Amt7.Text == null) || (Ded16Amt7.Text == ""))
			{
				dedTotal2Amt7 = dedTotal2Amt7 + 0;
			}
			else
			{
				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded16Amt7.Text);
				dedTotal2Amt7Flg = true;
			}

			if (dedTotal2Amt7Flg)
			{
				if (DedBnsDispType7.Text == "2")
				{
					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("###0");
				}
				else if (DedBnsDispType7.Text == "3")
				{
					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("#,##0.00");
				}
				else if (DedBnsDispType7.Text == "4")
				{
					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("###0.00");
				}
				else
				{
					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt7.Text = "";
			}

			if ((Ded13Amt8.Text == null) || (Ded13Amt8.Text == ""))
			{
				dedTotal2Amt8 = 0;
			}
			else
			{
				dedTotal2Amt8 = Convert.ToDouble(Ded13Amt8.Text);
				dedTotal2Amt8Flg = true;
			}

			if ((Ded14Amt8.Text == null) || (Ded14Amt8.Text == ""))
			{
				dedTotal2Amt8 = dedTotal2Amt8 + 0;
			}
			else
			{
				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded14Amt8.Text);
				dedTotal2Amt8Flg = true;
			}

			if ((Ded15Amt8.Text == null) || (Ded15Amt8.Text == ""))
			{
				dedTotal2Amt8 = dedTotal2Amt8 + 0;
			}
			else
			{
				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded15Amt8.Text);
				dedTotal2Amt8Flg = true;
			}

			if ((Ded16Amt8.Text == null) || (Ded16Amt8.Text == ""))
			{
				dedTotal2Amt8 = dedTotal2Amt8 + 0;
			}
			else
			{
				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded16Amt8.Text);
				dedTotal2Amt8Flg = true;
			}

			if (dedTotal2Amt8Flg)
			{
				if (DedBnsDispType8.Text == "2")
				{
					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("###0");
				}
				else if (DedBnsDispType8.Text == "3")
				{
					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("#,##0.00");
				}
				else if (DedBnsDispType8.Text == "4")
				{
					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("###0.00");
				}
				else
				{
					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt8.Text = "";
			}

			if ((Ded13Amt9.Text == null) || (Ded13Amt9.Text == ""))
			{
				dedTotal2Amt9 = 0;
			}
			else
			{
				dedTotal2Amt9 = Convert.ToDouble(Ded13Amt9.Text);
				dedTotal2Amt9Flg = true;
			}

			if ((Ded14Amt9.Text == null) || (Ded14Amt9.Text == ""))
			{
				dedTotal2Amt9 = dedTotal2Amt9 + 0;
			}
			else
			{
				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded14Amt9.Text);
				dedTotal2Amt9Flg = true;
			}

			if ((Ded15Amt9.Text == null) || (Ded15Amt9.Text == ""))
			{
				dedTotal2Amt9 = dedTotal2Amt9 + 0;
			}
			else
			{
				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded15Amt9.Text);
				dedTotal2Amt9Flg = true;
			}

			if ((Ded16Amt9.Text == null) || (Ded16Amt9.Text == ""))
			{
				dedTotal2Amt9 = dedTotal2Amt9 + 0;
			}
			else
			{
				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded16Amt9.Text);
				dedTotal2Amt9Flg = true;
			}

			if (dedTotal2Amt9Flg)
			{
				if (DedBnsDispType9.Text == "2")
				{
					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("###0");
				}
				else if (DedBnsDispType9.Text == "3")
				{
					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("#,##0.00");
				}
				else if (DedBnsDispType9.Text == "4")
				{
					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("###0.00");
				}
				else
				{
					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt9.Text = "";
			}

			if ((Ded13Amt10.Text == null) || (Ded13Amt10.Text == ""))
			{
				dedTotal2Amt10 = 0;
			}
			else
			{
				dedTotal2Amt10 = Convert.ToDouble(Ded13Amt10.Text);
				dedTotal2Amt10Flg = true;
			}

			if ((Ded14Amt10.Text == null) || (Ded14Amt10.Text == ""))
			{
				dedTotal2Amt10 = dedTotal2Amt10 + 0;
			}
			else
			{
				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded14Amt10.Text);
				dedTotal2Amt10Flg = true;
			}

			if ((Ded15Amt10.Text == null) || (Ded15Amt10.Text == ""))
			{
				dedTotal2Amt10 = dedTotal2Amt10 + 0;
			}
			else
			{
				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded15Amt10.Text);
				dedTotal2Amt10Flg = true;
			}

			if ((Ded16Amt10.Text == null) || (Ded16Amt10.Text == ""))
			{
				dedTotal2Amt10 = dedTotal2Amt10 + 0;
			}
			else
			{
				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded16Amt10.Text);
				dedTotal2Amt10Flg = true;
			}

			if (dedTotal2Amt10Flg)
			{
				if (DedBnsDispType10.Text == "2")
				{
					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("###0");
				}
				else if (DedBnsDispType10.Text == "3")
				{
					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("#,##0.00");
				}
				else if (DedBnsDispType10.Text == "4")
				{
					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("###0.00");
				}
				else
				{
					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt10.Text = "";
			}

			if ((Ded13Amt11.Text == null) || (Ded13Amt11.Text == ""))
			{
				dedTotal2Amt11 = 0;
			}
			else
			{
				dedTotal2Amt11 = Convert.ToDouble(Ded13Amt11.Text);
				dedTotal2Amt11Flg = true;
			}

			if ((Ded14Amt11.Text == null) || (Ded14Amt11.Text == ""))
			{
				dedTotal2Amt11 = dedTotal2Amt11 + 0;
			}
			else
			{
				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded14Amt11.Text);
				dedTotal2Amt11Flg = true;
			}

			if ((Ded15Amt11.Text == null) || (Ded15Amt11.Text == ""))
			{
				dedTotal2Amt11 = dedTotal2Amt11 + 0;
			}
			else
			{
				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded15Amt11.Text);
				dedTotal2Amt11Flg = true;
			}

			if ((Ded16Amt11.Text == null) || (Ded16Amt11.Text == ""))
			{
				dedTotal2Amt11 = dedTotal2Amt11 + 0;
			}
			else
			{
				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded16Amt11.Text);
				dedTotal2Amt11Flg = true;
			}

			if (dedTotal2Amt11Flg)
			{
				if (DedBnsDispType11.Text == "2")
				{
					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("###0");
				}
				else if (DedBnsDispType11.Text == "3")
				{
					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("#,##0.00");
				}
				else if (DedBnsDispType11.Text == "4")
				{
					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt11.Text = "";
			}

			if ((Ded13Amt12.Text == null) || (Ded13Amt12.Text == ""))
			{
				dedTotal2Amt12 = 0;
			}
			else
			{
				dedTotal2Amt12 = Convert.ToDouble(Ded13Amt12.Text);
				dedTotal2Amt12Flg = true;
			}

			if ((Ded14Amt12.Text == null) || (Ded14Amt12.Text == ""))
			{
				dedTotal2Amt12 = dedTotal2Amt12 + 0;
			}
			else
			{
				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded14Amt12.Text);
				dedTotal2Amt12Flg = true;
			}

			if ((Ded15Amt12.Text == null) || (Ded15Amt12.Text == ""))
			{
				dedTotal2Amt12 = dedTotal2Amt12 + 0;
			}
			else
			{
				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded15Amt12.Text);
				dedTotal2Amt12Flg = true;
			}

			if ((Ded16Amt12.Text == null) || (Ded16Amt12.Text == ""))
			{
				dedTotal2Amt12 = dedTotal2Amt12 + 0;
			}
			else
			{
				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded16Amt12.Text);
				dedTotal2Amt12Flg = true;
			}

			if (dedTotal2Amt12Flg)
			{
				if (DedBnsDispType12.Text == "2")
				{
					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("###0");
				}
				else if (DedBnsDispType12.Text == "3")
				{
					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("#,##0.00");
				}
				else if (DedBnsDispType12.Text == "4")
				{
					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("###0.00");
				}
				else
				{
					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("#,##0");
				}
			}
			else
			{
				DedTotal2Amt12.Text = "";
			}

			//給与支給合計の空白処理
			if (((PaymntTotal1Amt7.Text == "0") || (PaymntTotal1Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				PaymntTotal1Amt7.Text = "";
			}
			if ((PaymntItemId7.Text == null) || (PaymntItemId7.Text == ""))
			{
				PaymntTotal1Amt7.Text = "";
			}

			if (((PaymntTotal1Amt8.Text == "0") || (PaymntTotal1Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				PaymntTotal1Amt8.Text = "";
			}
			if ((PaymntItemId8.Text == null) || (PaymntItemId8.Text == ""))
			{
				PaymntTotal1Amt8.Text = "";
			}

			if (((PaymntTotal1Amt9.Text == "0") || (PaymntTotal1Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				PaymntTotal1Amt9.Text = "";
			}
			if ((PaymntItemId9.Text == null) || (PaymntItemId9.Text == ""))
			{
				PaymntTotal1Amt9.Text = "";
			}

			if (((PaymntTotal1Amt10.Text == "0") || (PaymntTotal1Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				PaymntTotal1Amt10.Text = "";
			}
			if ((PaymntItemId10.Text == null) || (PaymntItemId10.Text == ""))
			{
				PaymntTotal1Amt10.Text = "";
			}

			if (((PaymntTotal1Amt11.Text == "0") || (PaymntTotal1Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				PaymntTotal1Amt11.Text = "";
			}
			if ((PaymntItemId11.Text == null) || (PaymntItemId11.Text == ""))
			{
				PaymntTotal1Amt11.Text = "";
			}

			if (((PaymntTotal1Amt12.Text == "0") || (PaymntTotal1Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				PaymntTotal1Amt12.Text = "";
			}
			if ((PaymntItemId12.Text == null) || (PaymntItemId12.Text == ""))
			{
				PaymntTotal1Amt12.Text = "";
			}

			//給与控除合計の空白処理
			if (((DedTotal1Amt7.Text == "0") || (DedTotal1Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				DedTotal1Amt7.Text = "";
			}
			if ((DedItemId7.Text == null) || (DedItemId7.Text == ""))
			{
				DedTotal1Amt7.Text = "";
			}

			if (((DedTotal1Amt8.Text == "0") || (DedTotal1Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				DedTotal1Amt8.Text = "";
			}
			if ((DedItemId8.Text == null) || (DedItemId8.Text == ""))
			{
				DedTotal1Amt8.Text = "";
			}

			if (((DedTotal1Amt9.Text == "0") || (DedTotal1Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				DedTotal1Amt9.Text = "";
			}
			if ((DedItemId9.Text == null) || (DedItemId9.Text == ""))
			{
				DedTotal1Amt9.Text = "";
			}

			if (((DedTotal1Amt10.Text == "0") || (DedTotal1Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				DedTotal1Amt10.Text = "";
			}
			if ((DedItemId10.Text == null) || (DedItemId10.Text == ""))
			{
				DedTotal1Amt10.Text = "";
			}

			if (((DedTotal1Amt11.Text == "0") || (DedTotal1Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				DedTotal1Amt11.Text = "";
			}
			if ((DedItemId11.Text == null) || (DedItemId11.Text == ""))
			{
				DedTotal1Amt11.Text = "";
			}

			if (((DedTotal1Amt12.Text == "0") || (DedTotal1Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				DedTotal1Amt12.Text = "";
			}
			if ((DedItemId12.Text == null) || (DedItemId12.Text == ""))
			{
				DedTotal1Amt12.Text = "";
			}

			//賞与取得合計の空白処理
			if (((PaymntTotal2Amt7.Text == "0") || (PaymntTotal2Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
			{
				PaymntTotal2Amt7.Text = "";
			}
			if ((PaymntItemId7.Text == null) || (PaymntItemId7.Text == ""))
			{
				PaymntTotal2Amt7.Text = "";
			}

			if (((PaymntTotal2Amt8.Text == "0") || (PaymntTotal2Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
			{
				PaymntTotal2Amt8.Text = "";
			}
			if ((PaymntItemId8.Text == null) || (PaymntItemId8.Text == ""))
			{
				PaymntTotal2Amt8.Text = "";
			}

			if (((PaymntTotal2Amt9.Text == "0") || (PaymntTotal2Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
			{
				PaymntTotal2Amt9.Text = "";
			}
			if ((PaymntItemId9.Text == null) || (PaymntItemId9.Text == ""))
			{
				PaymntTotal2Amt9.Text = "";
			}

			if (((PaymntTotal2Amt10.Text == "0") || (PaymntTotal2Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
			{
				PaymntTotal2Amt10.Text = "";
			}
			if ((PaymntItemId10.Text == null) || (PaymntItemId10.Text == ""))
			{
				PaymntTotal2Amt10.Text = "";
			}

			if (((PaymntTotal2Amt11.Text == "0") || (PaymntTotal2Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
			{
				PaymntTotal2Amt11.Text = "";
			}
			if ((PaymntItemId11.Text == null) || (PaymntItemId11.Text == ""))
			{
				PaymntTotal2Amt11.Text = "";
			}

			if (((PaymntTotal2Amt12.Text == "0") || (PaymntTotal2Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
			{
				PaymntTotal2Amt12.Text = "";
			}
			if ((PaymntItemId12.Text == null) || (PaymntItemId12.Text == ""))
			{
				PaymntTotal2Amt12.Text = "";
			}

			//賞与控除合計の空白処理
			if (((DedTotal2Amt7.Text == "0") || (DedTotal2Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
			{
				DedTotal2Amt7.Text = "";
			}
			if ((DedItemId7.Text == null) || (DedItemId7.Text == ""))
			{
				DedTotal2Amt7.Text = "";
			}

			if (((DedTotal2Amt8.Text == "0") || (DedTotal2Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
			{
				DedTotal2Amt8.Text = "";
			}
			if ((DedItemId8.Text == null) || (DedItemId8.Text == ""))
			{
				DedTotal2Amt8.Text = "";
			}

			if (((DedTotal2Amt10.Text == "0") || (DedTotal2Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
			{
				DedTotal2Amt10.Text = "";
			}
			if ((DedItemId10.Text == null) || (DedItemId10.Text == ""))
			{
				DedTotal2Amt10.Text = "";
			}

			if (((DedTotal2Amt11.Text == "0") || (DedTotal2Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
			{
				DedTotal2Amt11.Text = "";
			}
			if ((DedItemId11.Text == null) || (DedItemId11.Text == ""))
			{
				DedTotal2Amt11.Text = "";
			}

			if (((DedTotal2Amt12.Text == "0") || (DedTotal2Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
			{
				DedTotal2Amt12.Text = "";
			}
			if ((DedItemId12.Text == null) || (DedItemId12.Text == ""))
			{
				DedTotal2Amt12.Text = "";
			}

			//前職等修正分の空白処理
			if (((Paymnt17Amt11.Text == "0") || (Paymnt17Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				Paymnt17Amt11.Text = "";
			}

			if (((Paymnt17Amt12.Text == "0") || (Paymnt17Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				Paymnt17Amt12.Text = "";
			}

			if (((Ded17Amt7.Text == "0") || (Ded17Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				Ded17Amt7.Text = "";
			}

			if (((Ded17Amt11.Text == "0") || (Ded17Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				Ded17Amt11.Text = "";
			}

			//前職等修正分(支給)の処理
			if ((Paymnt17Amt7.Text == null) || (Paymnt17Amt7.Text == ""))
			{
				paymntTotal3Amt7 = 0;
			}
			else
			{
				paymntTotal3Amt7 = Convert.ToDouble(Paymnt17Amt7.Text);
				paymntTotal3Amt7Flg = true;
			}

			if ((Paymnt17Amt8.Text == null) || (Paymnt17Amt8.Text == ""))
			{
				paymntTotal3Amt8 = 0;
			}
			else
			{
				paymntTotal3Amt8 = Convert.ToDouble(Paymnt17Amt8.Text);
				paymntTotal3Amt8Flg = true;
			}

			if ((Paymnt17Amt9.Text == null) || (Paymnt17Amt9.Text == ""))
			{
				paymntTotal3Amt9 = 0;
			}
			else
			{
				paymntTotal3Amt9 = Convert.ToDouble(Paymnt17Amt9.Text);
				paymntTotal3Amt9Flg = true;
			}

			if ((Paymnt17Amt10.Text == null) || (Paymnt17Amt10.Text == ""))
			{
				paymntTotal3Amt10 = 0;
			}
			else
			{
				paymntTotal3Amt10 = Convert.ToDouble(Paymnt17Amt10.Text);
				paymntTotal3Amt10Flg = true;
			}

			if ((Paymnt17Amt11.Text == null) || (Paymnt17Amt11.Text == ""))
			{
				paymntTotal3Amt11 = 0;
			}
			else
			{
				paymntTotal3Amt11 = Convert.ToDouble(Paymnt17Amt11.Text);
				paymntTotal3Amt11Flg = true;
			}

			if ((Paymnt17Amt12.Text == null) || (Paymnt17Amt12.Text == ""))
			{
				paymntTotal3Amt12 = 0;
			}
			else
			{
				paymntTotal3Amt12 = Convert.ToDouble(Paymnt17Amt12.Text);
				paymntTotal3Amt12Flg = true;
			}

			//前職等修正分(控除)の処理
			if ((Ded17Amt7.Text == null) || (Ded17Amt7.Text == ""))
			{
				dedTotal3Amt7 = 0;
			}
			else
			{
				dedTotal3Amt7 = Convert.ToDouble(Ded17Amt7.Text);
				dedTotal3Amt7Flg = true;
			}

			if ((Ded17Amt8.Text == null) || (Ded17Amt8.Text == ""))
			{
				dedTotal3Amt8 = 0;
			}
			else
			{
				dedTotal3Amt8 = Convert.ToDouble(Ded17Amt8.Text);
				dedTotal3Amt8Flg = true;
			}

			if ((Ded17Amt9.Text == null) || (Ded17Amt9.Text == ""))
			{
				dedTotal3Amt9 = 0;
			}
			else
			{
				dedTotal3Amt9 = Convert.ToDouble(Ded17Amt9.Text);
				dedTotal3Amt9Flg = true;
			}

			if ((Ded17Amt10.Text == null) || (Ded17Amt10.Text == ""))
			{
				dedTotal3Amt10 = 0;
			}
			else
			{
				dedTotal3Amt10 = Convert.ToDouble(Ded17Amt10.Text);
				dedTotal3Amt10Flg = true;
			}

			if ((Ded17Amt11.Text == null) || (Ded17Amt11.Text == ""))
			{
				dedTotal3Amt11 = 0;
			}
			else
			{
				dedTotal3Amt11 = Convert.ToDouble(Ded17Amt11.Text);
				dedTotal3Amt11Flg = true;
			}

			if ((Ded17Amt12.Text == null) || (Ded17Amt12.Text == ""))
			{
				dedTotal3Amt12 = 0;
			}
			else
			{
				dedTotal3Amt12 = Convert.ToDouble(Ded17Amt12.Text);
				dedTotal3Amt12Flg = true;
			}

			//支給総合計処理
			if ((paymntTotal1Amt7Flg) || (paymntTotal2Amt7Flg) || (paymntTotal3Amt7Flg))
			{
				if (PaymntDispType7.Text == "2")
				{
					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("###0");
				}
				else if (PaymntDispType7.Text == "3")
				{
					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("#,##0.00");
				}
				else if (PaymntDispType7.Text == "4")
				{
					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt7.Text = "";
			}

			if ((paymntTotal1Amt8Flg) || (paymntTotal2Amt8Flg) || (paymntTotal3Amt8Flg))
			{
				if (PaymntDispType8.Text == "2")
				{
					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("###0");
				}
				else if (PaymntDispType8.Text == "3")
				{
					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("#,##0.00");
				}
				else if (PaymntDispType8.Text == "4")
				{
					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt8.Text = "";
			}

			if ((paymntTotal1Amt9Flg) || (paymntTotal2Amt9Flg) || (paymntTotal3Amt9Flg))
			{
				if (PaymntDispType9.Text == "2")
				{
					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("###0");
				}
				else if (PaymntDispType9.Text == "3")
				{
					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("#,##0.00");
				}
				else if (PaymntDispType9.Text == "4")
				{
					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt9.Text = "";
			}

			if ((paymntTotal1Amt10Flg) || (paymntTotal2Amt10Flg) || (paymntTotal3Amt10Flg))
			{
				if (PaymntDispType10.Text == "2")
				{
					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("###0");
				}
				else if (PaymntDispType10.Text == "3")
				{
					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("#,##0.00");
				}
				else if (PaymntDispType10.Text == "4")
				{
					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt10.Text = "";
			}

			if ((paymntTotal1Amt11Flg) || (paymntTotal2Amt11Flg) || (paymntTotal3Amt11Flg))
			{
				if (PaymntDispType11.Text == "2")
				{
					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("###0");
				}
				else if (PaymntDispType11.Text == "3")
				{
					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("#,##0.00");
				}
				else if (PaymntDispType11.Text == "4")
				{
					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt11.Text = "";
			}

			if ((paymntTotal1Amt12Flg) || (paymntTotal2Amt12Flg) || (paymntTotal3Amt12Flg))
			{
				if (PaymntDispType12.Text == "2")
				{
					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("###0");
				}
				else if (PaymntDispType12.Text == "3")
				{
					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("#,##0.00");
				}
				else if (PaymntDispType12.Text == "4")
				{
					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("###0.00");
				}
				else
				{
					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("#,##0");
				}
			}
			else
			{
				PaymntTotal3Amt12.Text = "";
			}

			//控除総合計処理
			if ((dedTotal1Amt7Flg) || (dedTotal2Amt7Flg) || (dedTotal3Amt7Flg))
			{
				if (DedDispType7.Text == "2")
				{
					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("###0");
				}
				else if (DedDispType7.Text == "3")
				{
					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("#,##0.00");
				}
				else if (DedDispType7.Text == "4")
				{
					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt7.Text = "";
			}

			if ((dedTotal1Amt8Flg) || (dedTotal2Amt8Flg) || (dedTotal3Amt8Flg))
			{
				if (DedDispType8.Text == "2")
				{
					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("###0");
				}
				else if (DedDispType8.Text == "3")
				{
					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("#,##0.00");
				}
				else if (DedDispType8.Text == "4")
				{
					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt8.Text = "";
			}

			if ((dedTotal1Amt9Flg) || (dedTotal2Amt9Flg) || (dedTotal3Amt9Flg))
			{
				if (DedDispType9.Text == "2")
				{
					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("###0");
				}
				else if (DedDispType9.Text == "3")
				{
					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("#,##0.00");
				}
				else if (DedDispType9.Text == "4")
				{
					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt9.Text = "";
			}

			if ((dedTotal1Amt10Flg) || (dedTotal2Amt10Flg) || (dedTotal3Amt10Flg))
			{
				if (DedDispType10.Text == "2")
				{
					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("###0");
				}
				else if (DedDispType10.Text == "3")
				{
					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("#,##0.00");
				}
				else if (DedDispType10.Text == "4")
				{
					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt10.Text = "";
			}

			if ((dedTotal1Amt11Flg) || (dedTotal2Amt11Flg) || (dedTotal3Amt11Flg))
			{
				if (DedDispType11.Text == "2")
				{
					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("###0");
				}
				else if (DedDispType11.Text == "3")
				{
					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("#,##0.00");
				}
				else if (DedDispType11.Text == "4")
				{
					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt11.Text = "";
			}

			if ((dedTotal1Amt12Flg) || (dedTotal2Amt12Flg) || (dedTotal3Amt12Flg))
			{
				if (DedDispType12.Text == "2")
				{
					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("###0");
				}
				else if (DedDispType12.Text == "3")
				{
					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("#,##0.00");
				}
				else if (DedDispType12.Text == "4")
				{
					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("###0.00");
				}
				else
				{
					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("#,##0");
				}
			}
			else
			{
				DedTotal3Amt12.Text = "";
			}

			//支給総合計の空白処理
			if (((PaymntTotal3Amt7.Text == "0") || (PaymntTotal3Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
			{
				PaymntTotal3Amt7.Text = "";
			}
			if ((PaymntItemId7.Text == null) || (PaymntItemId7.Text == ""))
			{
				PaymntTotal3Amt7.Text = "";
			}

			if (((PaymntTotal3Amt8.Text == "0") || (PaymntTotal3Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
			{
				PaymntTotal3Amt8.Text = "";
			}
			if ((PaymntItemId8.Text == null) || (PaymntItemId8.Text == ""))
			{
				PaymntTotal3Amt8.Text = "";
			}

			if (((PaymntTotal3Amt9.Text == "0") || (PaymntTotal3Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
			{
				PaymntTotal3Amt9.Text = "";
			}
			if ((PaymntItemId9.Text == null) || (PaymntItemId9.Text == ""))
			{
				PaymntTotal3Amt9.Text = "";
			}

			if (((PaymntTotal3Amt10.Text == "0") || (PaymntTotal3Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
			{
				PaymntTotal3Amt10.Text = "";
			}
			if ((PaymntItemId10.Text == null) || (PaymntItemId10.Text == ""))
			{
				PaymntTotal3Amt10.Text = "";
			}

			if (((PaymntTotal3Amt11.Text == "0") || (PaymntTotal3Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
			{
				PaymntTotal3Amt11.Text = "";
			}
			if ((PaymntItemId11.Text == null) || (PaymntItemId11.Text == ""))
			{
				PaymntTotal3Amt11.Text = "";
			}

			if (((PaymntTotal3Amt12.Text == "0") || (PaymntTotal3Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
			{
				PaymntTotal3Amt12.Text = "";
			}
			if ((PaymntItemId12.Text == null) || (PaymntItemId12.Text == ""))
			{
				PaymntTotal3Amt12.Text = "";
			}

			//控除総合計の空白処理
			if (((DedTotal3Amt7.Text == "0") || (DedTotal3Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
			{
				DedTotal3Amt7.Text = "";
			}
			if ((DedItemId7.Text == null) || (DedItemId7.Text == ""))
			{
				DedTotal3Amt7.Text = "";
			}

			if (((DedTotal3Amt8.Text == "0") || (DedTotal3Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
			{
				DedTotal3Amt8.Text = "";
			}
			if ((DedItemId8.Text == null) || (DedItemId8.Text == ""))
			{
				DedTotal3Amt8.Text = "";
			}

			if (((DedTotal3Amt9.Text == "0") || (DedTotal3Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
			{
				DedTotal3Amt9.Text = "";
			}
			if ((DedItemId9.Text == null) || (DedItemId9.Text == ""))
			{
				DedTotal3Amt9.Text = "";
			}

			if (((DedTotal3Amt10.Text == "0") || (DedTotal3Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
			{
				DedTotal3Amt10.Text = "";
			}
			if ((DedItemId10.Text == null) || (DedItemId10.Text == ""))
			{
				DedTotal3Amt10.Text = "";
			}

			if (((DedTotal3Amt11.Text == "0") || (DedTotal3Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
			{
				DedTotal3Amt11.Text = "";
			}
			if ((DedItemId11.Text == null) || (DedItemId11.Text == ""))
			{
				DedTotal3Amt11.Text = "";
			}

			if (((DedTotal3Amt12.Text == "0") || (DedTotal3Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
			{
				DedTotal3Amt12.Text = "";
			}
			if ((DedItemId12.Text == null) || (DedItemId12.Text == ""))
			{
				DedTotal3Amt12.Text = "";
			}

			string slryPaymntYy = ((System.Data.DataRow[])(DataSource))[0]["SLRY_PAYMNT_YY"].ToString();

// 管理番号K27274 From
//			// 地震保険料控除対応
//			if (slryPaymntYy.Substring(0, 4).CompareTo(TAX_REVISION_YEAR) > 0)
//			{
//				Label154.Text = EARTHQUAKE_INSURANCE_DED;
//			}
//
//			if (slryPaymntYy.Substring(0, 4).CompareTo(TAX_REVISION_YEAR) > 0)
//			{
//				// 住宅取得控除可能額
//				if ((this.Ded18Amt12.Text != null) && (this.Ded18Amt12.Text != ""))
//				{
//					if (Convert.ToDecimal(this.Ded18Amt12.Text) == 0)
//					{
//						this.Label155.Text = "";
//						this.Ded18Amt12.Text = "";
//					}
//					else
//					{
//						this.Label155.Text = "住宅可能額";
//					}
//				}
//				else
//				{
//					this.Label155.Text = "";
//					this.Ded18Amt12.Text = "";
//				}
//			}
//			else
//			{
//				this.Label155.Text = "";
//				this.Ded18Amt12.Text = "";
//			}
// 管理番号K27274 To

			//年調年度＜2012年の時は、介護医療控除の金額は空白で印字
			if (slryPaymntYy.Substring(0, 4).CompareTo(TAX_REVISION_CARE_YEAR) < 0)
			{
// 管理番号K27274 From
//				this.Paymnt18Amt10.Text = "";
				this.Paymnt18Amt11.Text = "";
// 管理番号K27274 To
			}
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void PageHeader_BeforePrint(object sender, System.EventArgs eArgs)
		{

		}

		private void PageHeader_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}

		private void GroupHeader1_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line208 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line260 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line261 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line262 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line263 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line264 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line265 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line274 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line275 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line277 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line282 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line283 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line286 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line287 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line289 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line291 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line294 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line295 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line298 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line299 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line301 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line303 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line306 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line307 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line310 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line311 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line315 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line318 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line319 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line322 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line323 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line325 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line327 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line328 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line373 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line374 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line375 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line376 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line377 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line378 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line380 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line381 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line382 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line383 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line384 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line385 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line386 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label98 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label99 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label100 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label101 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label102 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line388 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line390 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label109 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label111 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label112 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label113 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Title = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line391 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line405 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line410 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line411 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;

		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_06_R97));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PaymntName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line260 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line261 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line262 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line263 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line264 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line265 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line274 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line275 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line277 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt1Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line282 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line283 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt2Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line286 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line287 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt3Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line289 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line291 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt4Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line294 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line295 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt5Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line298 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line299 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt6Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line301 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line303 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt7Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line306 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line307 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt8Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line310 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line311 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt9Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line313 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line315 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt10Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line318 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line319 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt11Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line322 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line323 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt12Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line325 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line327 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntTotal1Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line328 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line373 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt13Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line374 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line375 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt14Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line376 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line377 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt15Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line378 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt16Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line380 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line381 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntTotal2Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line382 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line383 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt17Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line384 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line385 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntTotal3Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line386 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label98 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label99 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label100 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label101 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label102 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line387 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt18Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line388 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line389 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line390 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label109 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label111 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label112 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Ded18Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Title = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line391 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line405 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntZeroFlg7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line410 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line411 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntBnsName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.PaymntName7,
            this.DedName7,
            this.Line260,
            this.PaymntName8,
            this.DedName8,
            this.Line261,
            this.PaymntName9,
            this.DedName9,
            this.Line262,
            this.PaymntName10,
            this.DedName10,
            this.Line263,
            this.PaymntName11,
            this.DedName11,
            this.Line264,
            this.PaymntName12,
            this.DedName12,
            this.Line265,
            this.Line274,
            this.Line275,
            this.Line277,
            this.Paymnt1Amt7,
            this.Ded1Amt7,
            this.Paymnt1Amt8,
            this.Ded1Amt8,
            this.Paymnt1Amt9,
            this.Ded1Amt9,
            this.Paymnt1Amt10,
            this.Ded1Amt10,
            this.Paymnt1Amt11,
            this.Ded1Amt11,
            this.Paymnt1Amt12,
            this.Ded1Amt12,
            this.Line282,
            this.Line283,
            this.Paymnt2Amt7,
            this.Ded2Amt7,
            this.Paymnt2Amt8,
            this.Ded2Amt8,
            this.Paymnt2Amt9,
            this.Ded2Amt9,
            this.Paymnt2Amt10,
            this.Ded2Amt10,
            this.Paymnt2Amt11,
            this.Ded2Amt11,
            this.Paymnt2Amt12,
            this.Ded2Amt12,
            this.Line286,
            this.Line287,
            this.Paymnt3Amt7,
            this.Ded3Amt7,
            this.Paymnt3Amt8,
            this.Ded3Amt8,
            this.Paymnt3Amt9,
            this.Ded3Amt9,
            this.Paymnt3Amt10,
            this.Ded3Amt10,
            this.Paymnt3Amt11,
            this.Ded3Amt11,
            this.Paymnt3Amt12,
            this.Ded3Amt12,
            this.Line289,
            this.Line291,
            this.Paymnt4Amt7,
            this.Ded4Amt7,
            this.Paymnt4Amt8,
            this.Ded4Amt8,
            this.Paymnt4Amt9,
            this.Ded4Amt9,
            this.Paymnt4Amt10,
            this.Ded4Amt10,
            this.Paymnt4Amt11,
            this.Ded4Amt11,
            this.Paymnt4Amt12,
            this.Ded4Amt12,
            this.Line294,
            this.Line295,
            this.Paymnt5Amt7,
            this.Ded5Amt7,
            this.Paymnt5Amt8,
            this.Ded5Amt8,
            this.Paymnt5Amt9,
            this.Ded5Amt9,
            this.Paymnt5Amt10,
            this.Ded5Amt10,
            this.Paymnt5Amt11,
            this.Ded5Amt11,
            this.Paymnt5Amt12,
            this.Ded5Amt12,
            this.Line298,
            this.Line299,
            this.Paymnt6Amt7,
            this.Ded6Amt7,
            this.Paymnt6Amt8,
            this.Ded6Amt8,
            this.Paymnt6Amt9,
            this.Ded6Amt9,
            this.Paymnt6Amt10,
            this.Ded6Amt10,
            this.Paymnt6Amt11,
            this.Ded6Amt11,
            this.Paymnt6Amt12,
            this.Ded6Amt12,
            this.Line301,
            this.Line303,
            this.Paymnt7Amt7,
            this.Ded7Amt7,
            this.Paymnt7Amt8,
            this.Ded7Amt8,
            this.Paymnt7Amt9,
            this.Ded7Amt9,
            this.Paymnt7Amt10,
            this.Ded7Amt10,
            this.Paymnt7Amt11,
            this.Ded7Amt11,
            this.Paymnt7Amt12,
            this.Ded7Amt12,
            this.Line306,
            this.Line307,
            this.Paymnt8Amt7,
            this.Ded8Amt7,
            this.Paymnt8Amt8,
            this.Ded8Amt8,
            this.Paymnt8Amt9,
            this.Ded8Amt9,
            this.Paymnt8Amt10,
            this.Ded8Amt10,
            this.Paymnt8Amt11,
            this.Ded8Amt11,
            this.Paymnt8Amt12,
            this.Ded8Amt12,
            this.Line310,
            this.Line311,
            this.Paymnt9Amt7,
            this.Ded9Amt7,
            this.Paymnt9Amt8,
            this.Ded9Amt8,
            this.Paymnt9Amt9,
            this.Ded9Amt9,
            this.Paymnt9Amt10,
            this.Ded9Amt10,
            this.Paymnt9Amt11,
            this.Ded9Amt11,
            this.Paymnt9Amt12,
            this.Ded9Amt12,
            this.Line313,
            this.Line315,
            this.Paymnt10Amt7,
            this.Ded10Amt7,
            this.Paymnt10Amt8,
            this.Ded10Amt8,
            this.Paymnt10Amt9,
            this.Ded10Amt9,
            this.Paymnt10Amt10,
            this.Ded10Amt10,
            this.Paymnt10Amt11,
            this.Ded10Amt11,
            this.Paymnt10Amt12,
            this.Ded10Amt12,
            this.Line318,
            this.Line319,
            this.Paymnt11Amt7,
            this.Ded11Amt7,
            this.Paymnt11Amt8,
            this.Ded11Amt8,
            this.Paymnt11Amt9,
            this.Ded11Amt9,
            this.Paymnt11Amt10,
            this.Ded11Amt10,
            this.Paymnt11Amt11,
            this.Ded11Amt11,
            this.Paymnt11Amt12,
            this.Ded11Amt12,
            this.Line322,
            this.Line323,
            this.Paymnt12Amt7,
            this.Ded12Amt7,
            this.Paymnt12Amt8,
            this.Ded12Amt8,
            this.Paymnt12Amt9,
            this.Ded12Amt9,
            this.Paymnt12Amt10,
            this.Ded12Amt10,
            this.Paymnt12Amt11,
            this.Ded12Amt11,
            this.Paymnt12Amt12,
            this.Ded12Amt12,
            this.Line325,
            this.Line327,
            this.PaymntTotal1Amt7,
            this.DedTotal1Amt7,
            this.PaymntTotal1Amt8,
            this.DedTotal1Amt8,
            this.PaymntTotal1Amt9,
            this.DedTotal1Amt9,
            this.PaymntTotal1Amt10,
            this.DedTotal1Amt10,
            this.PaymntTotal1Amt11,
            this.DedTotal1Amt11,
            this.PaymntTotal1Amt12,
            this.DedTotal1Amt12,
            this.Line328,
            this.Line373,
            this.Paymnt13Amt7,
            this.Ded13Amt7,
            this.Paymnt13Amt8,
            this.Ded13Amt8,
            this.Paymnt13Amt9,
            this.Ded13Amt9,
            this.Paymnt13Amt10,
            this.Ded13Amt10,
            this.Paymnt13Amt11,
            this.Ded13Amt11,
            this.Paymnt13Amt12,
            this.Ded13Amt12,
            this.Line374,
            this.Line375,
            this.Paymnt14Amt7,
            this.Ded14Amt7,
            this.Paymnt14Amt8,
            this.Ded14Amt8,
            this.Paymnt14Amt9,
            this.Ded14Amt9,
            this.Paymnt14Amt10,
            this.Ded14Amt10,
            this.Paymnt14Amt11,
            this.Ded14Amt11,
            this.Paymnt14Amt12,
            this.Ded14Amt12,
            this.Line376,
            this.Line377,
            this.Paymnt15Amt7,
            this.Ded15Amt7,
            this.Paymnt15Amt8,
            this.Ded15Amt8,
            this.Paymnt15Amt9,
            this.Ded15Amt9,
            this.Paymnt15Amt10,
            this.Ded15Amt10,
            this.Paymnt15Amt11,
            this.Ded15Amt11,
            this.Paymnt15Amt12,
            this.Ded15Amt12,
            this.Line378,
            this.Paymnt16Amt7,
            this.Ded16Amt7,
            this.Paymnt16Amt8,
            this.Ded16Amt8,
            this.Paymnt16Amt9,
            this.Ded16Amt9,
            this.Paymnt16Amt10,
            this.Ded16Amt10,
            this.Paymnt16Amt11,
            this.Ded16Amt11,
            this.Paymnt16Amt12,
            this.Ded16Amt12,
            this.Line380,
            this.Line381,
            this.PaymntTotal2Amt7,
            this.DedTotal2Amt7,
            this.PaymntTotal2Amt8,
            this.DedTotal2Amt8,
            this.PaymntTotal2Amt9,
            this.DedTotal2Amt9,
            this.PaymntTotal2Amt10,
            this.DedTotal2Amt10,
            this.PaymntTotal2Amt11,
            this.DedTotal2Amt11,
            this.PaymntTotal2Amt12,
            this.DedTotal2Amt12,
            this.Line382,
            this.Line383,
            this.Paymnt17Amt7,
            this.Ded17Amt7,
            this.Paymnt17Amt8,
            this.Ded17Amt8,
            this.Paymnt17Amt9,
            this.Ded17Amt9,
            this.Paymnt17Amt10,
            this.Ded17Amt10,
            this.Paymnt17Amt11,
            this.Ded17Amt11,
            this.Paymnt17Amt12,
            this.Ded17Amt12,
            this.Line384,
            this.Line385,
            this.PaymntTotal3Amt7,
            this.DedTotal3Amt7,
            this.PaymntTotal3Amt8,
            this.DedTotal3Amt8,
            this.PaymntTotal3Amt9,
            this.DedTotal3Amt9,
            this.PaymntTotal3Amt10,
            this.DedTotal3Amt10,
            this.PaymntTotal3Amt11,
            this.DedTotal3Amt11,
            this.PaymntTotal3Amt12,
            this.DedTotal3Amt12,
            this.Line386,
            this.Label98,
            this.Label99,
            this.Label100,
            this.Label101,
            this.Label102,
            this.Line387,
            this.Paymnt18Amt7,
            this.Paymnt18Amt8,
            this.Paymnt18Amt9,
            this.Paymnt18Amt10,
            this.Paymnt18Amt11,
            this.Paymnt18Amt12,
            this.Line388,
            this.Line389,
            this.Line390,
            this.Label109,
            this.Label111,
            this.Label112,
            this.Label113,
            this.Ded18Amt7,
            this.Ded18Amt8,
            this.Ded18Amt9,
            this.Ded18Amt10,
            this.Ded18Amt11,
            this.Ded18Amt12,
            this.Title,
            this.Line391,
            this.Line405,
            this.PaymntZeroFlg7,
            this.PaymntZeroFlg8,
            this.PaymntZeroFlg9,
            this.PaymntZeroFlg10,
            this.PaymntZeroFlg11,
            this.PaymntZeroFlg12,
            this.DedZeroFlg7,
            this.DedZeroFlg8,
            this.DedZeroFlg9,
            this.DedZeroFlg10,
            this.DedZeroFlg11,
            this.DedZeroFlg12,
            this.PaymntItemId7,
            this.DedItemId7,
            this.PaymntItemId8,
            this.DedItemId8,
            this.PaymntItemId9,
            this.DedItemId9,
            this.PaymntItemId10,
            this.DedItemId10,
            this.PaymntItemId11,
            this.DedItemId11,
            this.PaymntItemId12,
            this.DedItemId12,
            this.PaymntDispType7,
            this.DedDispType7,
            this.PaymntDispType8,
            this.DedDispType8,
            this.PaymntDispType11,
            this.DedDispType11,
            this.PaymntDispType12,
            this.DedDispType12,
            this.PaymntDispType9,
            this.PaymntDispType10,
            this.DedDispType9,
            this.DedDispType10,
            this.PaymntBnsZeroFlg7,
            this.PaymntBnsZeroFlg8,
            this.PaymntBnsZeroFlg9,
            this.PaymntBnsZeroFlg10,
            this.PaymntBnsZeroFlg11,
            this.PaymntBnsZeroFlg12,
            this.DedBnsZeroFlg7,
            this.DedBnsZeroFlg8,
            this.DedBnsZeroFlg9,
            this.DedBnsZeroFlg10,
            this.DedBnsZeroFlg11,
            this.DedBnsZeroFlg12,
            this.PaymntBnsDispType7,
            this.PaymntBnsDispType8,
            this.PaymntBnsDispType9,
            this.PaymntBnsDispType10,
            this.PaymntBnsDispType11,
            this.PaymntBnsDispType12,
            this.DedBnsDispType7,
            this.DedBnsDispType8,
            this.DedBnsDispType9,
            this.DedBnsDispType10,
            this.DedBnsDispType11,
            this.DedBnsDispType12,
            this.Line410,
            this.Line411,
            this.PaymntBnsName7,
            this.DedBnsName7,
            this.PaymntBnsName8,
            this.DedBnsName8,
            this.PaymntBnsName9,
            this.DedBnsName9,
            this.DedBnsName10,
            this.PaymntBnsName10,
            this.PaymntBnsName11,
            this.DedBnsName11,
            this.PaymntBnsName12,
            this.DedBnsName12,
            this.Label154,
            this.Label155});
			this.Detail.Height = 6.884722F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// PaymntName7
			// 
			this.PaymntName7.DataField = "PAYMNT_NAME7";
			this.PaymntName7.Height = 0.143F;
			this.PaymntName7.Left = 0F;
			this.PaymntName7.Name = "PaymntName7";
			this.PaymntName7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName7.Text = "あいうえおか";
			this.PaymntName7.Top = 0F;
			this.PaymntName7.Width = 0.625F;
			// 
			// DedName7
			// 
			this.DedName7.DataField = "DED_NAME7";
			this.DedName7.Height = 0.143F;
			this.DedName7.Left = 0F;
			this.DedName7.Name = "DedName7";
			this.DedName7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName7.Text = "あいうえおか";
			this.DedName7.Top = 0.143F;
			this.DedName7.Width = 0.625F;
			// 
			// Line260
			// 
			this.Line260.Height = 6.891F;
			this.Line260.Left = 0.6254997F;
			this.Line260.LineWeight = 1F;
			this.Line260.Name = "Line260";
			this.Line260.Top = 0F;
			this.Line260.Width = 0F;
			this.Line260.X1 = 0.6254997F;
			this.Line260.X2 = 0.6254997F;
			this.Line260.Y1 = 0F;
			this.Line260.Y2 = 6.891F;
			// 
			// PaymntName8
			// 
			this.PaymntName8.DataField = "PAYMNT_NAME8";
			this.PaymntName8.Height = 0.143F;
			this.PaymntName8.Left = 0.625F;
			this.PaymntName8.Name = "PaymntName8";
			this.PaymntName8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName8.Text = "あいうえおか";
			this.PaymntName8.Top = 0F;
			this.PaymntName8.Width = 0.624F;
			// 
			// DedName8
			// 
			this.DedName8.DataField = "DED_NAME8";
			this.DedName8.Height = 0.143F;
			this.DedName8.Left = 0.625F;
			this.DedName8.Name = "DedName8";
			this.DedName8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName8.Text = "あいうえおか";
			this.DedName8.Top = 0.143F;
			this.DedName8.Width = 0.624F;
			// 
			// Line261
			// 
			this.Line261.Height = 6.891F;
			this.Line261.Left = 1.250499F;
			this.Line261.LineWeight = 1F;
			this.Line261.Name = "Line261";
			this.Line261.Top = 0F;
			this.Line261.Width = 0F;
			this.Line261.X1 = 1.250499F;
			this.Line261.X2 = 1.250499F;
			this.Line261.Y1 = 0F;
			this.Line261.Y2 = 6.891F;
			// 
			// PaymntName9
			// 
			this.PaymntName9.DataField = "PAYMNT_NAME9";
			this.PaymntName9.Height = 0.143F;
			this.PaymntName9.Left = 1.251F;
			this.PaymntName9.Name = "PaymntName9";
			this.PaymntName9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName9.Text = "あいうえおか";
			this.PaymntName9.Top = 0F;
			this.PaymntName9.Width = 0.624F;
			// 
			// DedName9
			// 
			this.DedName9.DataField = "DED_NAME9";
			this.DedName9.Height = 0.143F;
			this.DedName9.Left = 1.251F;
			this.DedName9.Name = "DedName9";
			this.DedName9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName9.Text = "あいうえおか";
			this.DedName9.Top = 0.143F;
			this.DedName9.Width = 0.624F;
			// 
			// Line262
			// 
			this.Line262.Height = 6.891F;
			this.Line262.Left = 1.875499F;
			this.Line262.LineWeight = 1F;
			this.Line262.Name = "Line262";
			this.Line262.Top = 0F;
			this.Line262.Width = 0F;
			this.Line262.X1 = 1.875499F;
			this.Line262.X2 = 1.875499F;
			this.Line262.Y1 = 0F;
			this.Line262.Y2 = 6.891F;
			// 
			// PaymntName10
			// 
			this.PaymntName10.DataField = "PAYMNT_NAME10";
			this.PaymntName10.Height = 0.143F;
			this.PaymntName10.Left = 1.875F;
			this.PaymntName10.Name = "PaymntName10";
			this.PaymntName10.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName10.Text = "あいうえおか";
			this.PaymntName10.Top = 0F;
			this.PaymntName10.Width = 0.625F;
			// 
			// DedName10
			// 
			this.DedName10.DataField = "DED_NAME10";
			this.DedName10.Height = 0.143F;
			this.DedName10.Left = 1.875F;
			this.DedName10.Name = "DedName10";
			this.DedName10.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName10.Text = "あいうえおか";
			this.DedName10.Top = 0.143F;
			this.DedName10.Width = 0.625F;
			// 
			// Line263
			// 
			this.Line263.Height = 6.891F;
			this.Line263.Left = 2.5005F;
			this.Line263.LineWeight = 1F;
			this.Line263.Name = "Line263";
			this.Line263.Top = 0F;
			this.Line263.Width = 0F;
			this.Line263.X1 = 2.5005F;
			this.Line263.X2 = 2.5005F;
			this.Line263.Y1 = 0F;
			this.Line263.Y2 = 6.891F;
			// 
			// PaymntName11
			// 
			this.PaymntName11.DataField = "PAYMNT_NAME11";
			this.PaymntName11.Height = 0.143F;
			this.PaymntName11.Left = 2.501F;
			this.PaymntName11.Name = "PaymntName11";
			this.PaymntName11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName11.Text = "あいうえおか";
			this.PaymntName11.Top = 0F;
			this.PaymntName11.Width = 0.624F;
			// 
			// DedName11
			// 
			this.DedName11.DataField = "DED_NAME11";
			this.DedName11.Height = 0.143F;
			this.DedName11.Left = 2.501F;
			this.DedName11.Name = "DedName11";
			this.DedName11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName11.Text = "あいうえおか";
			this.DedName11.Top = 0.143F;
			this.DedName11.Width = 0.624F;
			// 
			// Line264
			// 
			this.Line264.Height = 6.891F;
			this.Line264.Left = 3.1255F;
			this.Line264.LineWeight = 1F;
			this.Line264.Name = "Line264";
			this.Line264.Top = 0F;
			this.Line264.Width = 0F;
			this.Line264.X1 = 3.1255F;
			this.Line264.X2 = 3.1255F;
			this.Line264.Y1 = 0F;
			this.Line264.Y2 = 6.891F;
			// 
			// PaymntName12
			// 
			this.PaymntName12.DataField = "PAYMNT_NAME12";
			this.PaymntName12.Height = 0.143F;
			this.PaymntName12.Left = 3.125F;
			this.PaymntName12.Name = "PaymntName12";
			this.PaymntName12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName12.Text = "あいうえおか";
			this.PaymntName12.Top = 0F;
			this.PaymntName12.Width = 0.625F;
			// 
			// DedName12
			// 
			this.DedName12.DataField = "DED_NAME12";
			this.DedName12.Height = 0.143F;
			this.DedName12.Left = 3.125F;
			this.DedName12.Name = "DedName12";
			this.DedName12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName12.Text = "あいうえおか";
			this.DedName12.Top = 0.143F;
			this.DedName12.Width = 0.625F;
			// 
			// Line265
			// 
			this.Line265.Height = 6.891F;
			this.Line265.Left = 3.7505F;
			this.Line265.LineWeight = 1F;
			this.Line265.Name = "Line265";
			this.Line265.Top = 0F;
			this.Line265.Width = 0F;
			this.Line265.X1 = 3.7505F;
			this.Line265.X2 = 3.7505F;
			this.Line265.Y1 = 0F;
			this.Line265.Y2 = 6.891F;
			// 
			// Line274
			// 
			this.Line274.Height = 0F;
			this.Line274.Left = 0.0004997253F;
			this.Line274.LineWeight = 1F;
			this.Line274.Name = "Line274";
			this.Line274.Top = 0.2860001F;
			this.Line274.Width = 3.7505F;
			this.Line274.X1 = 0.0004997253F;
			this.Line274.X2 = 3.751F;
			this.Line274.Y1 = 0.2860001F;
			this.Line274.Y2 = 0.2860001F;
			// 
			// Line275
			// 
			this.Line275.Height = 0F;
			this.Line275.Left = 0.0004997253F;
			this.Line275.LineWeight = 1F;
			this.Line275.Name = "Line275";
			this.Line275.Top = 0.143F;
			this.Line275.Width = 3.7505F;
			this.Line275.X1 = 0.0004997253F;
			this.Line275.X2 = 3.751F;
			this.Line275.Y1 = 0.143F;
			this.Line275.Y2 = 0.143F;
			// 
			// Line277
			// 
			this.Line277.Height = 0F;
			this.Line277.Left = 0.0004997253F;
			this.Line277.LineWeight = 1F;
			this.Line277.Name = "Line277";
			this.Line277.Top = 0.429F;
			this.Line277.Width = 3.7505F;
			this.Line277.X1 = 0.0004997253F;
			this.Line277.X2 = 3.751F;
			this.Line277.Y1 = 0.429F;
			this.Line277.Y2 = 0.429F;
			// 
			// Paymnt1Amt7
			// 
			this.Paymnt1Amt7.DataField = "PAYMNT_1AMT7";
			this.Paymnt1Amt7.Height = 0.143F;
			this.Paymnt1Amt7.Left = 0F;
			this.Paymnt1Amt7.Name = "Paymnt1Amt7";
			this.Paymnt1Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt7.Top = 0.2860001F;
			this.Paymnt1Amt7.Width = 0.625F;
			// 
			// Ded1Amt7
			// 
			this.Ded1Amt7.DataField = "DED_1AMT7";
			this.Ded1Amt7.Height = 0.143F;
			this.Ded1Amt7.Left = 0F;
			this.Ded1Amt7.Name = "Ded1Amt7";
			this.Ded1Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt7.Top = 0.429F;
			this.Ded1Amt7.Width = 0.625F;
			// 
			// Paymnt1Amt8
			// 
			this.Paymnt1Amt8.DataField = "PAYMNT_1AMT8";
			this.Paymnt1Amt8.Height = 0.143F;
			this.Paymnt1Amt8.Left = 0.625F;
			this.Paymnt1Amt8.Name = "Paymnt1Amt8";
			this.Paymnt1Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt8.Top = 0.2860001F;
			this.Paymnt1Amt8.Width = 0.624F;
			// 
			// Ded1Amt8
			// 
			this.Ded1Amt8.DataField = "DED_1AMT8";
			this.Ded1Amt8.Height = 0.143F;
			this.Ded1Amt8.Left = 0.625F;
			this.Ded1Amt8.Name = "Ded1Amt8";
			this.Ded1Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt8.Top = 0.429F;
			this.Ded1Amt8.Width = 0.624F;
			// 
			// Paymnt1Amt9
			// 
			this.Paymnt1Amt9.DataField = "PAYMNT_1AMT9";
			this.Paymnt1Amt9.Height = 0.143F;
			this.Paymnt1Amt9.Left = 1.251F;
			this.Paymnt1Amt9.Name = "Paymnt1Amt9";
			this.Paymnt1Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt9.Top = 0.2860001F;
			this.Paymnt1Amt9.Width = 0.624F;
			// 
			// Ded1Amt9
			// 
			this.Ded1Amt9.DataField = "DED_1AMT9";
			this.Ded1Amt9.Height = 0.143F;
			this.Ded1Amt9.Left = 1.251F;
			this.Ded1Amt9.Name = "Ded1Amt9";
			this.Ded1Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt9.Top = 0.429F;
			this.Ded1Amt9.Width = 0.624F;
			// 
			// Paymnt1Amt10
			// 
			this.Paymnt1Amt10.DataField = "PAYMNT_1AMT10";
			this.Paymnt1Amt10.Height = 0.143F;
			this.Paymnt1Amt10.Left = 1.875F;
			this.Paymnt1Amt10.Name = "Paymnt1Amt10";
			this.Paymnt1Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt10.Top = 0.2860001F;
			this.Paymnt1Amt10.Width = 0.625F;
			// 
			// Ded1Amt10
			// 
			this.Ded1Amt10.DataField = "DED_1AMT10";
			this.Ded1Amt10.Height = 0.143F;
			this.Ded1Amt10.Left = 1.875F;
			this.Ded1Amt10.Name = "Ded1Amt10";
			this.Ded1Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt10.Top = 0.429F;
			this.Ded1Amt10.Width = 0.625F;
			// 
			// Paymnt1Amt11
			// 
			this.Paymnt1Amt11.DataField = "PAYMNT_1AMT11";
			this.Paymnt1Amt11.Height = 0.143F;
			this.Paymnt1Amt11.Left = 2.501F;
			this.Paymnt1Amt11.Name = "Paymnt1Amt11";
			this.Paymnt1Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt11.Top = 0.2860001F;
			this.Paymnt1Amt11.Width = 0.624F;
			// 
			// Ded1Amt11
			// 
			this.Ded1Amt11.DataField = "DED_1AMT11";
			this.Ded1Amt11.Height = 0.143F;
			this.Ded1Amt11.Left = 2.501F;
			this.Ded1Amt11.Name = "Ded1Amt11";
			this.Ded1Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt11.Top = 0.429F;
			this.Ded1Amt11.Width = 0.624F;
			// 
			// Paymnt1Amt12
			// 
			this.Paymnt1Amt12.DataField = "PAYMNT_1AMT12";
			this.Paymnt1Amt12.Height = 0.143F;
			this.Paymnt1Amt12.Left = 3.125F;
			this.Paymnt1Amt12.Name = "Paymnt1Amt12";
			this.Paymnt1Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt12.Top = 0.2860001F;
			this.Paymnt1Amt12.Width = 0.625F;
			// 
			// Ded1Amt12
			// 
			this.Ded1Amt12.DataField = "DED_1AMT12";
			this.Ded1Amt12.Height = 0.143F;
			this.Ded1Amt12.Left = 3.125F;
			this.Ded1Amt12.Name = "Ded1Amt12";
			this.Ded1Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt12.Top = 0.429F;
			this.Ded1Amt12.Width = 0.625F;
			// 
			// Line282
			// 
			this.Line282.Height = 0F;
			this.Line282.Left = 0.0004997253F;
			this.Line282.LineWeight = 1F;
			this.Line282.Name = "Line282";
			this.Line282.Top = 0.572F;
			this.Line282.Width = 3.7505F;
			this.Line282.X1 = 0.0004997253F;
			this.Line282.X2 = 3.751F;
			this.Line282.Y1 = 0.572F;
			this.Line282.Y2 = 0.572F;
			// 
			// Line283
			// 
			this.Line283.Height = 0F;
			this.Line283.Left = 0.0004997253F;
			this.Line283.LineWeight = 1F;
			this.Line283.Name = "Line283";
			this.Line283.Top = 0.715F;
			this.Line283.Width = 3.7505F;
			this.Line283.X1 = 0.0004997253F;
			this.Line283.X2 = 3.751F;
			this.Line283.Y1 = 0.715F;
			this.Line283.Y2 = 0.715F;
			// 
			// Paymnt2Amt7
			// 
			this.Paymnt2Amt7.DataField = "PAYMNT_2AMT7";
			this.Paymnt2Amt7.Height = 0.143F;
			this.Paymnt2Amt7.Left = 0F;
			this.Paymnt2Amt7.Name = "Paymnt2Amt7";
			this.Paymnt2Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt7.Top = 0.572F;
			this.Paymnt2Amt7.Width = 0.625F;
			// 
			// Ded2Amt7
			// 
			this.Ded2Amt7.DataField = "DED_2AMT7";
			this.Ded2Amt7.Height = 0.143F;
			this.Ded2Amt7.Left = 0F;
			this.Ded2Amt7.Name = "Ded2Amt7";
			this.Ded2Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt7.Top = 0.715F;
			this.Ded2Amt7.Width = 0.625F;
			// 
			// Paymnt2Amt8
			// 
			this.Paymnt2Amt8.DataField = "PAYMNT_2AMT8";
			this.Paymnt2Amt8.Height = 0.143F;
			this.Paymnt2Amt8.Left = 0.625F;
			this.Paymnt2Amt8.Name = "Paymnt2Amt8";
			this.Paymnt2Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt8.Top = 0.572F;
			this.Paymnt2Amt8.Width = 0.624F;
			// 
			// Ded2Amt8
			// 
			this.Ded2Amt8.DataField = "DED_2AMT8";
			this.Ded2Amt8.Height = 0.143F;
			this.Ded2Amt8.Left = 0.625F;
			this.Ded2Amt8.Name = "Ded2Amt8";
			this.Ded2Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt8.Top = 0.715F;
			this.Ded2Amt8.Width = 0.624F;
			// 
			// Paymnt2Amt9
			// 
			this.Paymnt2Amt9.DataField = "PAYMNT_2AMT9";
			this.Paymnt2Amt9.Height = 0.143F;
			this.Paymnt2Amt9.Left = 1.251F;
			this.Paymnt2Amt9.Name = "Paymnt2Amt9";
			this.Paymnt2Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt9.Top = 0.572F;
			this.Paymnt2Amt9.Width = 0.624F;
			// 
			// Ded2Amt9
			// 
			this.Ded2Amt9.DataField = "DED_2AMT9";
			this.Ded2Amt9.Height = 0.143F;
			this.Ded2Amt9.Left = 1.25F;
			this.Ded2Amt9.Name = "Ded2Amt9";
			this.Ded2Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt9.Top = 0.715F;
			this.Ded2Amt9.Width = 0.624F;
			// 
			// Paymnt2Amt10
			// 
			this.Paymnt2Amt10.DataField = "PAYMNT_2AMT10";
			this.Paymnt2Amt10.Height = 0.143F;
			this.Paymnt2Amt10.Left = 1.875F;
			this.Paymnt2Amt10.Name = "Paymnt2Amt10";
			this.Paymnt2Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt10.Top = 0.572F;
			this.Paymnt2Amt10.Width = 0.625F;
			// 
			// Ded2Amt10
			// 
			this.Ded2Amt10.DataField = "DED_2AMT10";
			this.Ded2Amt10.Height = 0.143F;
			this.Ded2Amt10.Left = 1.875F;
			this.Ded2Amt10.Name = "Ded2Amt10";
			this.Ded2Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt10.Top = 0.715F;
			this.Ded2Amt10.Width = 0.625F;
			// 
			// Paymnt2Amt11
			// 
			this.Paymnt2Amt11.DataField = "PAYMNT_2AMT11";
			this.Paymnt2Amt11.Height = 0.143F;
			this.Paymnt2Amt11.Left = 2.501F;
			this.Paymnt2Amt11.Name = "Paymnt2Amt11";
			this.Paymnt2Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt11.Top = 0.572F;
			this.Paymnt2Amt11.Width = 0.624F;
			// 
			// Ded2Amt11
			// 
			this.Ded2Amt11.DataField = "DED_2AMT11";
			this.Ded2Amt11.Height = 0.143F;
			this.Ded2Amt11.Left = 2.501F;
			this.Ded2Amt11.Name = "Ded2Amt11";
			this.Ded2Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt11.Top = 0.715F;
			this.Ded2Amt11.Width = 0.624F;
			// 
			// Paymnt2Amt12
			// 
			this.Paymnt2Amt12.DataField = "PAYMNT_2AMT12";
			this.Paymnt2Amt12.Height = 0.143F;
			this.Paymnt2Amt12.Left = 3.125F;
			this.Paymnt2Amt12.Name = "Paymnt2Amt12";
			this.Paymnt2Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt12.Top = 0.572F;
			this.Paymnt2Amt12.Width = 0.625F;
			// 
			// Ded2Amt12
			// 
			this.Ded2Amt12.DataField = "DED_2AMT12";
			this.Ded2Amt12.Height = 0.143F;
			this.Ded2Amt12.Left = 3.125F;
			this.Ded2Amt12.Name = "Ded2Amt12";
			this.Ded2Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt12.Top = 0.715F;
			this.Ded2Amt12.Width = 0.625F;
			// 
			// Line286
			// 
			this.Line286.Height = 0F;
			this.Line286.Left = 0.0004997253F;
			this.Line286.LineWeight = 1F;
			this.Line286.Name = "Line286";
			this.Line286.Top = 0.858F;
			this.Line286.Width = 3.7505F;
			this.Line286.X1 = 0.0004997253F;
			this.Line286.X2 = 3.751F;
			this.Line286.Y1 = 0.858F;
			this.Line286.Y2 = 0.858F;
			// 
			// Line287
			// 
			this.Line287.Height = 0F;
			this.Line287.Left = 0.0004997253F;
			this.Line287.LineWeight = 1F;
			this.Line287.Name = "Line287";
			this.Line287.Top = 1.001F;
			this.Line287.Width = 3.7505F;
			this.Line287.X1 = 0.0004997253F;
			this.Line287.X2 = 3.751F;
			this.Line287.Y1 = 1.001F;
			this.Line287.Y2 = 1.001F;
			// 
			// Paymnt3Amt7
			// 
			this.Paymnt3Amt7.DataField = "PAYMNT_3AMT7";
			this.Paymnt3Amt7.Height = 0.143F;
			this.Paymnt3Amt7.Left = 0F;
			this.Paymnt3Amt7.Name = "Paymnt3Amt7";
			this.Paymnt3Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt7.Top = 0.858F;
			this.Paymnt3Amt7.Width = 0.625F;
			// 
			// Ded3Amt7
			// 
			this.Ded3Amt7.DataField = "DED_3AMT7";
			this.Ded3Amt7.Height = 0.143F;
			this.Ded3Amt7.Left = 0F;
			this.Ded3Amt7.Name = "Ded3Amt7";
			this.Ded3Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt7.Top = 1.001F;
			this.Ded3Amt7.Width = 0.625F;
			// 
			// Paymnt3Amt8
			// 
			this.Paymnt3Amt8.DataField = "PAYMNT_3AMT8";
			this.Paymnt3Amt8.Height = 0.143F;
			this.Paymnt3Amt8.Left = 0.625F;
			this.Paymnt3Amt8.Name = "Paymnt3Amt8";
			this.Paymnt3Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt8.Top = 0.858F;
			this.Paymnt3Amt8.Width = 0.624F;
			// 
			// Ded3Amt8
			// 
			this.Ded3Amt8.DataField = "DED_3AMT8";
			this.Ded3Amt8.Height = 0.143F;
			this.Ded3Amt8.Left = 0.625F;
			this.Ded3Amt8.Name = "Ded3Amt8";
			this.Ded3Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt8.Top = 1.001F;
			this.Ded3Amt8.Width = 0.624F;
			// 
			// Paymnt3Amt9
			// 
			this.Paymnt3Amt9.DataField = "PAYMNT_3AMT9";
			this.Paymnt3Amt9.Height = 0.143F;
			this.Paymnt3Amt9.Left = 1.251F;
			this.Paymnt3Amt9.Name = "Paymnt3Amt9";
			this.Paymnt3Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt9.Top = 0.858F;
			this.Paymnt3Amt9.Width = 0.624F;
			// 
			// Ded3Amt9
			// 
			this.Ded3Amt9.DataField = "DED_3AMT9";
			this.Ded3Amt9.Height = 0.143F;
			this.Ded3Amt9.Left = 1.251F;
			this.Ded3Amt9.Name = "Ded3Amt9";
			this.Ded3Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt9.Top = 1.001F;
			this.Ded3Amt9.Width = 0.624F;
			// 
			// Paymnt3Amt10
			// 
			this.Paymnt3Amt10.DataField = "PAYMNT_3AMT10";
			this.Paymnt3Amt10.Height = 0.143F;
			this.Paymnt3Amt10.Left = 1.875F;
			this.Paymnt3Amt10.Name = "Paymnt3Amt10";
			this.Paymnt3Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt10.Top = 0.858F;
			this.Paymnt3Amt10.Width = 0.625F;
			// 
			// Ded3Amt10
			// 
			this.Ded3Amt10.DataField = "DED_3AMT10";
			this.Ded3Amt10.Height = 0.143F;
			this.Ded3Amt10.Left = 1.875F;
			this.Ded3Amt10.Name = "Ded3Amt10";
			this.Ded3Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt10.Top = 1.001F;
			this.Ded3Amt10.Width = 0.625F;
			// 
			// Paymnt3Amt11
			// 
			this.Paymnt3Amt11.DataField = "PAYMNT_3AMT11";
			this.Paymnt3Amt11.Height = 0.143F;
			this.Paymnt3Amt11.Left = 2.501F;
			this.Paymnt3Amt11.Name = "Paymnt3Amt11";
			this.Paymnt3Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt11.Top = 0.858F;
			this.Paymnt3Amt11.Width = 0.624F;
			// 
			// Ded3Amt11
			// 
			this.Ded3Amt11.DataField = "DED_3AMT11";
			this.Ded3Amt11.Height = 0.143F;
			this.Ded3Amt11.Left = 2.501F;
			this.Ded3Amt11.Name = "Ded3Amt11";
			this.Ded3Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt11.Top = 1.001F;
			this.Ded3Amt11.Width = 0.624F;
			// 
			// Paymnt3Amt12
			// 
			this.Paymnt3Amt12.DataField = "PAYMNT_3AMT12";
			this.Paymnt3Amt12.Height = 0.143F;
			this.Paymnt3Amt12.Left = 3.125F;
			this.Paymnt3Amt12.Name = "Paymnt3Amt12";
			this.Paymnt3Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt12.Top = 0.858F;
			this.Paymnt3Amt12.Width = 0.625F;
			// 
			// Ded3Amt12
			// 
			this.Ded3Amt12.DataField = "DED_3AMT12";
			this.Ded3Amt12.Height = 0.143F;
			this.Ded3Amt12.Left = 3.125F;
			this.Ded3Amt12.Name = "Ded3Amt12";
			this.Ded3Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt12.Top = 1.001F;
			this.Ded3Amt12.Width = 0.625F;
			// 
			// Line289
			// 
			this.Line289.Height = 0F;
			this.Line289.Left = 0.0004997253F;
			this.Line289.LineWeight = 1F;
			this.Line289.Name = "Line289";
			this.Line289.Top = 1.144F;
			this.Line289.Width = 3.7505F;
			this.Line289.X1 = 0.0004997253F;
			this.Line289.X2 = 3.751F;
			this.Line289.Y1 = 1.144F;
			this.Line289.Y2 = 1.144F;
			// 
			// Line291
			// 
			this.Line291.Height = 0F;
			this.Line291.Left = 0.0004997253F;
			this.Line291.LineWeight = 1F;
			this.Line291.Name = "Line291";
			this.Line291.Top = 1.287F;
			this.Line291.Width = 3.7505F;
			this.Line291.X1 = 0.0004997253F;
			this.Line291.X2 = 3.751F;
			this.Line291.Y1 = 1.287F;
			this.Line291.Y2 = 1.287F;
			// 
			// Paymnt4Amt7
			// 
			this.Paymnt4Amt7.DataField = "PAYMNT_4AMT7";
			this.Paymnt4Amt7.Height = 0.143F;
			this.Paymnt4Amt7.Left = 0F;
			this.Paymnt4Amt7.Name = "Paymnt4Amt7";
			this.Paymnt4Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt7.Top = 1.144F;
			this.Paymnt4Amt7.Width = 0.625F;
			// 
			// Ded4Amt7
			// 
			this.Ded4Amt7.DataField = "DED_4AMT7";
			this.Ded4Amt7.Height = 0.143F;
			this.Ded4Amt7.Left = 0F;
			this.Ded4Amt7.Name = "Ded4Amt7";
			this.Ded4Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt7.Top = 1.287F;
			this.Ded4Amt7.Width = 0.625F;
			// 
			// Paymnt4Amt8
			// 
			this.Paymnt4Amt8.DataField = "PAYMNT_4AMT8";
			this.Paymnt4Amt8.Height = 0.1436F;
			this.Paymnt4Amt8.Left = 0.625F;
			this.Paymnt4Amt8.Name = "Paymnt4Amt8";
			this.Paymnt4Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt8.Top = 1.144F;
			this.Paymnt4Amt8.Width = 0.624F;
			// 
			// Ded4Amt8
			// 
			this.Ded4Amt8.DataField = "DED_4AMT8";
			this.Ded4Amt8.Height = 0.143F;
			this.Ded4Amt8.Left = 0.625F;
			this.Ded4Amt8.Name = "Ded4Amt8";
			this.Ded4Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt8.Top = 1.287F;
			this.Ded4Amt8.Width = 0.625F;
			// 
			// Paymnt4Amt9
			// 
			this.Paymnt4Amt9.DataField = "PAYMNT_4AMT9";
			this.Paymnt4Amt9.Height = 0.143F;
			this.Paymnt4Amt9.Left = 1.251F;
			this.Paymnt4Amt9.Name = "Paymnt4Amt9";
			this.Paymnt4Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt9.Top = 1.144F;
			this.Paymnt4Amt9.Width = 0.624F;
			// 
			// Ded4Amt9
			// 
			this.Ded4Amt9.DataField = "DED_4AMT9";
			this.Ded4Amt9.Height = 0.143F;
			this.Ded4Amt9.Left = 1.251F;
			this.Ded4Amt9.Name = "Ded4Amt9";
			this.Ded4Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt9.Top = 1.287F;
			this.Ded4Amt9.Width = 0.625F;
			// 
			// Paymnt4Amt10
			// 
			this.Paymnt4Amt10.DataField = "PAYMNT_4AMT10";
			this.Paymnt4Amt10.Height = 0.143F;
			this.Paymnt4Amt10.Left = 1.875F;
			this.Paymnt4Amt10.Name = "Paymnt4Amt10";
			this.Paymnt4Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt10.Top = 1.144F;
			this.Paymnt4Amt10.Width = 0.625F;
			// 
			// Ded4Amt10
			// 
			this.Ded4Amt10.DataField = "DED_4AMT10";
			this.Ded4Amt10.Height = 0.143F;
			this.Ded4Amt10.Left = 1.875F;
			this.Ded4Amt10.Name = "Ded4Amt10";
			this.Ded4Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt10.Top = 1.287F;
			this.Ded4Amt10.Width = 0.625F;
			// 
			// Paymnt4Amt11
			// 
			this.Paymnt4Amt11.DataField = "PAYMNT_4AMT11";
			this.Paymnt4Amt11.Height = 0.143F;
			this.Paymnt4Amt11.Left = 2.501F;
			this.Paymnt4Amt11.Name = "Paymnt4Amt11";
			this.Paymnt4Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt11.Top = 1.144F;
			this.Paymnt4Amt11.Width = 0.624F;
			// 
			// Ded4Amt11
			// 
			this.Ded4Amt11.DataField = "DED_4AMT11";
			this.Ded4Amt11.Height = 0.143F;
			this.Ded4Amt11.Left = 2.501F;
			this.Ded4Amt11.Name = "Ded4Amt11";
			this.Ded4Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt11.Top = 1.287F;
			this.Ded4Amt11.Width = 0.625F;
			// 
			// Paymnt4Amt12
			// 
			this.Paymnt4Amt12.DataField = "PAYMNT_4AMT12";
			this.Paymnt4Amt12.Height = 0.143F;
			this.Paymnt4Amt12.Left = 3.125F;
			this.Paymnt4Amt12.Name = "Paymnt4Amt12";
			this.Paymnt4Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt12.Top = 1.144F;
			this.Paymnt4Amt12.Width = 0.625F;
			// 
			// Ded4Amt12
			// 
			this.Ded4Amt12.DataField = "DED_4AMT12";
			this.Ded4Amt12.Height = 0.143F;
			this.Ded4Amt12.Left = 3.125F;
			this.Ded4Amt12.Name = "Ded4Amt12";
			this.Ded4Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt12.Top = 1.287F;
			this.Ded4Amt12.Width = 0.625F;
			// 
			// Line294
			// 
			this.Line294.Height = 0F;
			this.Line294.Left = 0.0004997253F;
			this.Line294.LineWeight = 1F;
			this.Line294.Name = "Line294";
			this.Line294.Top = 1.43F;
			this.Line294.Width = 3.7505F;
			this.Line294.X1 = 0.0004997253F;
			this.Line294.X2 = 3.751F;
			this.Line294.Y1 = 1.43F;
			this.Line294.Y2 = 1.43F;
			// 
			// Line295
			// 
			this.Line295.Height = 0F;
			this.Line295.Left = 0.0004997253F;
			this.Line295.LineWeight = 1F;
			this.Line295.Name = "Line295";
			this.Line295.Top = 1.573F;
			this.Line295.Width = 3.7505F;
			this.Line295.X1 = 0.0004997253F;
			this.Line295.X2 = 3.751F;
			this.Line295.Y1 = 1.573F;
			this.Line295.Y2 = 1.573F;
			// 
			// Paymnt5Amt7
			// 
			this.Paymnt5Amt7.DataField = "PAYMNT_5AMT7";
			this.Paymnt5Amt7.Height = 0.143F;
			this.Paymnt5Amt7.Left = 0F;
			this.Paymnt5Amt7.Name = "Paymnt5Amt7";
			this.Paymnt5Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt7.Top = 1.43F;
			this.Paymnt5Amt7.Width = 0.625F;
			// 
			// Ded5Amt7
			// 
			this.Ded5Amt7.DataField = "DED_5AMT7";
			this.Ded5Amt7.Height = 0.143F;
			this.Ded5Amt7.Left = 0F;
			this.Ded5Amt7.Name = "Ded5Amt7";
			this.Ded5Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt7.Top = 1.573F;
			this.Ded5Amt7.Width = 0.625F;
			// 
			// Paymnt5Amt8
			// 
			this.Paymnt5Amt8.DataField = "PAYMNT_5AMT8";
			this.Paymnt5Amt8.Height = 0.143F;
			this.Paymnt5Amt8.Left = 0.625F;
			this.Paymnt5Amt8.Name = "Paymnt5Amt8";
			this.Paymnt5Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt8.Top = 1.43F;
			this.Paymnt5Amt8.Width = 0.625F;
			// 
			// Ded5Amt8
			// 
			this.Ded5Amt8.DataField = "DED_5AMT8";
			this.Ded5Amt8.Height = 0.143F;
			this.Ded5Amt8.Left = 0.625F;
			this.Ded5Amt8.Name = "Ded5Amt8";
			this.Ded5Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt8.Top = 1.573F;
			this.Ded5Amt8.Width = 0.625F;
			// 
			// Paymnt5Amt9
			// 
			this.Paymnt5Amt9.DataField = "PAYMNT_5AMT9";
			this.Paymnt5Amt9.Height = 0.143F;
			this.Paymnt5Amt9.Left = 1.251F;
			this.Paymnt5Amt9.Name = "Paymnt5Amt9";
			this.Paymnt5Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt9.Top = 1.43F;
			this.Paymnt5Amt9.Width = 0.625F;
			// 
			// Ded5Amt9
			// 
			this.Ded5Amt9.DataField = "DED_5AMT9";
			this.Ded5Amt9.Height = 0.143F;
			this.Ded5Amt9.Left = 1.251F;
			this.Ded5Amt9.Name = "Ded5Amt9";
			this.Ded5Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt9.Top = 1.573F;
			this.Ded5Amt9.Width = 0.625F;
			// 
			// Paymnt5Amt10
			// 
			this.Paymnt5Amt10.DataField = "PAYMNT_5AMT10";
			this.Paymnt5Amt10.Height = 0.143F;
			this.Paymnt5Amt10.Left = 1.875F;
			this.Paymnt5Amt10.Name = "Paymnt5Amt10";
			this.Paymnt5Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt10.Top = 1.43F;
			this.Paymnt5Amt10.Width = 0.625F;
			// 
			// Ded5Amt10
			// 
			this.Ded5Amt10.DataField = "DED_5AMT10";
			this.Ded5Amt10.Height = 0.143F;
			this.Ded5Amt10.Left = 1.875F;
			this.Ded5Amt10.Name = "Ded5Amt10";
			this.Ded5Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt10.Top = 1.573F;
			this.Ded5Amt10.Width = 0.625F;
			// 
			// Paymnt5Amt11
			// 
			this.Paymnt5Amt11.DataField = "PAYMNT_5AMT11";
			this.Paymnt5Amt11.Height = 0.143F;
			this.Paymnt5Amt11.Left = 2.501F;
			this.Paymnt5Amt11.Name = "Paymnt5Amt11";
			this.Paymnt5Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt11.Top = 1.43F;
			this.Paymnt5Amt11.Width = 0.625F;
			// 
			// Ded5Amt11
			// 
			this.Ded5Amt11.DataField = "DED_5AMT11";
			this.Ded5Amt11.Height = 0.143F;
			this.Ded5Amt11.Left = 2.501F;
			this.Ded5Amt11.Name = "Ded5Amt11";
			this.Ded5Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt11.Top = 1.573F;
			this.Ded5Amt11.Width = 0.625F;
			// 
			// Paymnt5Amt12
			// 
			this.Paymnt5Amt12.DataField = "PAYMNT_5AMT12";
			this.Paymnt5Amt12.Height = 0.143F;
			this.Paymnt5Amt12.Left = 3.125F;
			this.Paymnt5Amt12.Name = "Paymnt5Amt12";
			this.Paymnt5Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt12.Top = 1.43F;
			this.Paymnt5Amt12.Width = 0.625F;
			// 
			// Ded5Amt12
			// 
			this.Ded5Amt12.DataField = "DED_5AMT12";
			this.Ded5Amt12.Height = 0.143F;
			this.Ded5Amt12.Left = 3.125F;
			this.Ded5Amt12.Name = "Ded5Amt12";
			this.Ded5Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt12.Top = 1.573F;
			this.Ded5Amt12.Width = 0.625F;
			// 
			// Line298
			// 
			this.Line298.Height = 0F;
			this.Line298.Left = 0.0004997253F;
			this.Line298.LineWeight = 1F;
			this.Line298.Name = "Line298";
			this.Line298.Top = 1.716F;
			this.Line298.Width = 3.7505F;
			this.Line298.X1 = 0.0004997253F;
			this.Line298.X2 = 3.751F;
			this.Line298.Y1 = 1.716F;
			this.Line298.Y2 = 1.716F;
			// 
			// Line299
			// 
			this.Line299.Height = 0F;
			this.Line299.Left = 0.0004997253F;
			this.Line299.LineWeight = 1F;
			this.Line299.Name = "Line299";
			this.Line299.Top = 1.859F;
			this.Line299.Width = 3.7505F;
			this.Line299.X1 = 0.0004997253F;
			this.Line299.X2 = 3.751F;
			this.Line299.Y1 = 1.859F;
			this.Line299.Y2 = 1.859F;
			// 
			// Paymnt6Amt7
			// 
			this.Paymnt6Amt7.DataField = "PAYMNT_6AMT7";
			this.Paymnt6Amt7.Height = 0.143F;
			this.Paymnt6Amt7.Left = 0F;
			this.Paymnt6Amt7.Name = "Paymnt6Amt7";
			this.Paymnt6Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt7.Top = 1.716F;
			this.Paymnt6Amt7.Width = 0.625F;
			// 
			// Ded6Amt7
			// 
			this.Ded6Amt7.DataField = "DED_6AMT7";
			this.Ded6Amt7.Height = 0.143F;
			this.Ded6Amt7.Left = 0F;
			this.Ded6Amt7.Name = "Ded6Amt7";
			this.Ded6Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt7.Top = 1.859F;
			this.Ded6Amt7.Width = 0.625F;
			// 
			// Paymnt6Amt8
			// 
			this.Paymnt6Amt8.DataField = "PAYMNT_6AMT8";
			this.Paymnt6Amt8.Height = 0.143F;
			this.Paymnt6Amt8.Left = 0.625F;
			this.Paymnt6Amt8.Name = "Paymnt6Amt8";
			this.Paymnt6Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt8.Top = 1.716F;
			this.Paymnt6Amt8.Width = 0.625F;
			// 
			// Ded6Amt8
			// 
			this.Ded6Amt8.DataField = "DED_6AMT8";
			this.Ded6Amt8.Height = 0.143F;
			this.Ded6Amt8.Left = 0.625F;
			this.Ded6Amt8.Name = "Ded6Amt8";
			this.Ded6Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt8.Top = 1.859F;
			this.Ded6Amt8.Width = 0.625F;
			// 
			// Paymnt6Amt9
			// 
			this.Paymnt6Amt9.DataField = "PAYMNT_6AMT9";
			this.Paymnt6Amt9.Height = 0.143F;
			this.Paymnt6Amt9.Left = 1.251F;
			this.Paymnt6Amt9.Name = "Paymnt6Amt9";
			this.Paymnt6Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt9.Top = 1.716F;
			this.Paymnt6Amt9.Width = 0.625F;
			// 
			// Ded6Amt9
			// 
			this.Ded6Amt9.DataField = "DED_6AMT9";
			this.Ded6Amt9.Height = 0.143F;
			this.Ded6Amt9.Left = 1.251F;
			this.Ded6Amt9.Name = "Ded6Amt9";
			this.Ded6Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt9.Top = 1.859F;
			this.Ded6Amt9.Width = 0.625F;
			// 
			// Paymnt6Amt10
			// 
			this.Paymnt6Amt10.DataField = "PAYMNT_6AMT10";
			this.Paymnt6Amt10.Height = 0.143F;
			this.Paymnt6Amt10.Left = 1.875F;
			this.Paymnt6Amt10.Name = "Paymnt6Amt10";
			this.Paymnt6Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt10.Top = 1.716F;
			this.Paymnt6Amt10.Width = 0.625F;
			// 
			// Ded6Amt10
			// 
			this.Ded6Amt10.DataField = "DED_6AMT10";
			this.Ded6Amt10.Height = 0.143F;
			this.Ded6Amt10.Left = 1.875F;
			this.Ded6Amt10.Name = "Ded6Amt10";
			this.Ded6Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt10.Top = 1.859F;
			this.Ded6Amt10.Width = 0.625F;
			// 
			// Paymnt6Amt11
			// 
			this.Paymnt6Amt11.DataField = "PAYMNT_6AMT11";
			this.Paymnt6Amt11.Height = 0.143F;
			this.Paymnt6Amt11.Left = 2.501F;
			this.Paymnt6Amt11.Name = "Paymnt6Amt11";
			this.Paymnt6Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt11.Top = 1.716F;
			this.Paymnt6Amt11.Width = 0.625F;
			// 
			// Ded6Amt11
			// 
			this.Ded6Amt11.DataField = "DED_6AMT11";
			this.Ded6Amt11.Height = 0.143F;
			this.Ded6Amt11.Left = 2.5F;
			this.Ded6Amt11.Name = "Ded6Amt11";
			this.Ded6Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt11.Top = 1.859F;
			this.Ded6Amt11.Width = 0.625F;
			// 
			// Paymnt6Amt12
			// 
			this.Paymnt6Amt12.DataField = "PAYMNT_6AMT12";
			this.Paymnt6Amt12.Height = 0.143F;
			this.Paymnt6Amt12.Left = 3.125F;
			this.Paymnt6Amt12.Name = "Paymnt6Amt12";
			this.Paymnt6Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt12.Top = 1.716F;
			this.Paymnt6Amt12.Width = 0.625F;
			// 
			// Ded6Amt12
			// 
			this.Ded6Amt12.DataField = "DED_6AMT12";
			this.Ded6Amt12.Height = 0.143F;
			this.Ded6Amt12.Left = 3.125F;
			this.Ded6Amt12.Name = "Ded6Amt12";
			this.Ded6Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt12.Top = 1.859F;
			this.Ded6Amt12.Width = 0.625F;
			// 
			// Line301
			// 
			this.Line301.Height = 0F;
			this.Line301.Left = 0.0004997253F;
			this.Line301.LineWeight = 1F;
			this.Line301.Name = "Line301";
			this.Line301.Top = 2.002F;
			this.Line301.Width = 3.7505F;
			this.Line301.X1 = 0.0004997253F;
			this.Line301.X2 = 3.751F;
			this.Line301.Y1 = 2.002F;
			this.Line301.Y2 = 2.002F;
			// 
			// Line303
			// 
			this.Line303.Height = 0F;
			this.Line303.Left = 0.0004997253F;
			this.Line303.LineWeight = 1F;
			this.Line303.Name = "Line303";
			this.Line303.Top = 2.145F;
			this.Line303.Width = 3.7505F;
			this.Line303.X1 = 0.0004997253F;
			this.Line303.X2 = 3.751F;
			this.Line303.Y1 = 2.145F;
			this.Line303.Y2 = 2.145F;
			// 
			// Paymnt7Amt7
			// 
			this.Paymnt7Amt7.DataField = "PAYMNT_7AMT7";
			this.Paymnt7Amt7.Height = 0.143F;
			this.Paymnt7Amt7.Left = 0F;
			this.Paymnt7Amt7.Name = "Paymnt7Amt7";
			this.Paymnt7Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt7.Top = 2.002F;
			this.Paymnt7Amt7.Width = 0.625F;
			// 
			// Ded7Amt7
			// 
			this.Ded7Amt7.DataField = "DED_7AMT7";
			this.Ded7Amt7.Height = 0.143F;
			this.Ded7Amt7.Left = 0F;
			this.Ded7Amt7.Name = "Ded7Amt7";
			this.Ded7Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt7.Top = 2.145F;
			this.Ded7Amt7.Width = 0.625F;
			// 
			// Paymnt7Amt8
			// 
			this.Paymnt7Amt8.DataField = "PAYMNT_7AMT8";
			this.Paymnt7Amt8.Height = 0.143F;
			this.Paymnt7Amt8.Left = 0.625F;
			this.Paymnt7Amt8.Name = "Paymnt7Amt8";
			this.Paymnt7Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt8.Top = 2.002F;
			this.Paymnt7Amt8.Width = 0.625F;
			// 
			// Ded7Amt8
			// 
			this.Ded7Amt8.DataField = "DED_7AMT8";
			this.Ded7Amt8.Height = 0.143F;
			this.Ded7Amt8.Left = 0.625F;
			this.Ded7Amt8.Name = "Ded7Amt8";
			this.Ded7Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt8.Top = 2.145F;
			this.Ded7Amt8.Width = 0.625F;
			// 
			// Paymnt7Amt9
			// 
			this.Paymnt7Amt9.DataField = "PAYMNT_7AMT9";
			this.Paymnt7Amt9.Height = 0.143F;
			this.Paymnt7Amt9.Left = 1.251F;
			this.Paymnt7Amt9.Name = "Paymnt7Amt9";
			this.Paymnt7Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt9.Top = 2.002F;
			this.Paymnt7Amt9.Width = 0.625F;
			// 
			// Ded7Amt9
			// 
			this.Ded7Amt9.DataField = "DED_7AMT9";
			this.Ded7Amt9.Height = 0.143F;
			this.Ded7Amt9.Left = 1.251F;
			this.Ded7Amt9.Name = "Ded7Amt9";
			this.Ded7Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt9.Top = 2.145F;
			this.Ded7Amt9.Width = 0.625F;
			// 
			// Paymnt7Amt10
			// 
			this.Paymnt7Amt10.DataField = "PAYMNT_7AMT10";
			this.Paymnt7Amt10.Height = 0.143F;
			this.Paymnt7Amt10.Left = 1.875F;
			this.Paymnt7Amt10.Name = "Paymnt7Amt10";
			this.Paymnt7Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt10.Top = 2.002F;
			this.Paymnt7Amt10.Width = 0.625F;
			// 
			// Ded7Amt10
			// 
			this.Ded7Amt10.DataField = "DED_7AMT10";
			this.Ded7Amt10.Height = 0.143F;
			this.Ded7Amt10.Left = 1.875F;
			this.Ded7Amt10.Name = "Ded7Amt10";
			this.Ded7Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt10.Top = 2.145F;
			this.Ded7Amt10.Width = 0.625F;
			// 
			// Paymnt7Amt11
			// 
			this.Paymnt7Amt11.DataField = "PAYMNT_7AMT11";
			this.Paymnt7Amt11.Height = 0.143F;
			this.Paymnt7Amt11.Left = 2.501F;
			this.Paymnt7Amt11.Name = "Paymnt7Amt11";
			this.Paymnt7Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt11.Top = 2.002F;
			this.Paymnt7Amt11.Width = 0.625F;
			// 
			// Ded7Amt11
			// 
			this.Ded7Amt11.DataField = "DED_7AMT11";
			this.Ded7Amt11.Height = 0.143F;
			this.Ded7Amt11.Left = 2.501F;
			this.Ded7Amt11.Name = "Ded7Amt11";
			this.Ded7Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt11.Top = 2.145F;
			this.Ded7Amt11.Width = 0.625F;
			// 
			// Paymnt7Amt12
			// 
			this.Paymnt7Amt12.DataField = "PAYMNT_7AMT12";
			this.Paymnt7Amt12.Height = 0.143F;
			this.Paymnt7Amt12.Left = 3.125F;
			this.Paymnt7Amt12.Name = "Paymnt7Amt12";
			this.Paymnt7Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt12.Top = 2.002F;
			this.Paymnt7Amt12.Width = 0.625F;
			// 
			// Ded7Amt12
			// 
			this.Ded7Amt12.DataField = "DED_7AMT12";
			this.Ded7Amt12.Height = 0.143F;
			this.Ded7Amt12.Left = 3.125F;
			this.Ded7Amt12.Name = "Ded7Amt12";
			this.Ded7Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt12.Top = 2.145F;
			this.Ded7Amt12.Width = 0.625F;
			// 
			// Line306
			// 
			this.Line306.Height = 0F;
			this.Line306.Left = 0.0004997253F;
			this.Line306.LineWeight = 1F;
			this.Line306.Name = "Line306";
			this.Line306.Top = 2.288F;
			this.Line306.Width = 3.7505F;
			this.Line306.X1 = 0.0004997253F;
			this.Line306.X2 = 3.751F;
			this.Line306.Y1 = 2.288F;
			this.Line306.Y2 = 2.288F;
			// 
			// Line307
			// 
			this.Line307.Height = 0F;
			this.Line307.Left = 0.0004997253F;
			this.Line307.LineWeight = 1F;
			this.Line307.Name = "Line307";
			this.Line307.Top = 2.431F;
			this.Line307.Width = 3.7505F;
			this.Line307.X1 = 0.0004997253F;
			this.Line307.X2 = 3.751F;
			this.Line307.Y1 = 2.431F;
			this.Line307.Y2 = 2.431F;
			// 
			// Paymnt8Amt7
			// 
			this.Paymnt8Amt7.DataField = "PAYMNT_8AMT7";
			this.Paymnt8Amt7.Height = 0.143F;
			this.Paymnt8Amt7.Left = 0F;
			this.Paymnt8Amt7.Name = "Paymnt8Amt7";
			this.Paymnt8Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt7.Top = 2.288F;
			this.Paymnt8Amt7.Width = 0.625F;
			// 
			// Ded8Amt7
			// 
			this.Ded8Amt7.DataField = "DED_8AMT7";
			this.Ded8Amt7.Height = 0.143F;
			this.Ded8Amt7.Left = 0F;
			this.Ded8Amt7.Name = "Ded8Amt7";
			this.Ded8Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt7.Top = 2.431F;
			this.Ded8Amt7.Width = 0.625F;
			// 
			// Paymnt8Amt8
			// 
			this.Paymnt8Amt8.DataField = "PAYMNT_8AMT8";
			this.Paymnt8Amt8.Height = 0.143F;
			this.Paymnt8Amt8.Left = 0.625F;
			this.Paymnt8Amt8.Name = "Paymnt8Amt8";
			this.Paymnt8Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt8.Top = 2.288F;
			this.Paymnt8Amt8.Width = 0.625F;
			// 
			// Ded8Amt8
			// 
			this.Ded8Amt8.DataField = "DED_8AMT8";
			this.Ded8Amt8.Height = 0.143F;
			this.Ded8Amt8.Left = 0.625F;
			this.Ded8Amt8.Name = "Ded8Amt8";
			this.Ded8Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt8.Top = 2.431F;
			this.Ded8Amt8.Width = 0.625F;
			// 
			// Paymnt8Amt9
			// 
			this.Paymnt8Amt9.DataField = "PAYMNT_8AMT9";
			this.Paymnt8Amt9.Height = 0.143F;
			this.Paymnt8Amt9.Left = 1.251F;
			this.Paymnt8Amt9.Name = "Paymnt8Amt9";
			this.Paymnt8Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt9.Top = 2.288F;
			this.Paymnt8Amt9.Width = 0.625F;
			// 
			// Ded8Amt9
			// 
			this.Ded8Amt9.DataField = "DED_8AMT9";
			this.Ded8Amt9.Height = 0.143F;
			this.Ded8Amt9.Left = 1.251F;
			this.Ded8Amt9.Name = "Ded8Amt9";
			this.Ded8Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt9.Top = 2.431F;
			this.Ded8Amt9.Width = 0.625F;
			// 
			// Paymnt8Amt10
			// 
			this.Paymnt8Amt10.DataField = "PAYMNT_8AMT10";
			this.Paymnt8Amt10.Height = 0.143F;
			this.Paymnt8Amt10.Left = 1.875F;
			this.Paymnt8Amt10.Name = "Paymnt8Amt10";
			this.Paymnt8Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt10.Top = 2.288F;
			this.Paymnt8Amt10.Width = 0.625F;
			// 
			// Ded8Amt10
			// 
			this.Ded8Amt10.DataField = "DED_8AMT10";
			this.Ded8Amt10.Height = 0.143F;
			this.Ded8Amt10.Left = 1.875F;
			this.Ded8Amt10.Name = "Ded8Amt10";
			this.Ded8Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt10.Top = 2.431F;
			this.Ded8Amt10.Width = 0.625F;
			// 
			// Paymnt8Amt11
			// 
			this.Paymnt8Amt11.DataField = "PAYMNT_8AMT11";
			this.Paymnt8Amt11.Height = 0.143F;
			this.Paymnt8Amt11.Left = 2.501F;
			this.Paymnt8Amt11.Name = "Paymnt8Amt11";
			this.Paymnt8Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt11.Top = 2.288F;
			this.Paymnt8Amt11.Width = 0.625F;
			// 
			// Ded8Amt11
			// 
			this.Ded8Amt11.DataField = "DED_8AMT11";
			this.Ded8Amt11.Height = 0.143F;
			this.Ded8Amt11.Left = 2.501F;
			this.Ded8Amt11.Name = "Ded8Amt11";
			this.Ded8Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt11.Top = 2.431F;
			this.Ded8Amt11.Width = 0.625F;
			// 
			// Paymnt8Amt12
			// 
			this.Paymnt8Amt12.DataField = "PAYMNT_8AMT12";
			this.Paymnt8Amt12.Height = 0.143F;
			this.Paymnt8Amt12.Left = 3.125F;
			this.Paymnt8Amt12.Name = "Paymnt8Amt12";
			this.Paymnt8Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt12.Top = 2.288F;
			this.Paymnt8Amt12.Width = 0.625F;
			// 
			// Ded8Amt12
			// 
			this.Ded8Amt12.DataField = "DED_8AMT12";
			this.Ded8Amt12.Height = 0.143F;
			this.Ded8Amt12.Left = 3.125F;
			this.Ded8Amt12.Name = "Ded8Amt12";
			this.Ded8Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt12.Top = 2.431F;
			this.Ded8Amt12.Width = 0.625F;
			// 
			// Line310
			// 
			this.Line310.Height = 0F;
			this.Line310.Left = 0.0004997253F;
			this.Line310.LineWeight = 1F;
			this.Line310.Name = "Line310";
			this.Line310.Top = 2.574F;
			this.Line310.Width = 3.7505F;
			this.Line310.X1 = 0.0004997253F;
			this.Line310.X2 = 3.751F;
			this.Line310.Y1 = 2.574F;
			this.Line310.Y2 = 2.574F;
			// 
			// Line311
			// 
			this.Line311.Height = 0F;
			this.Line311.Left = 0.0004997253F;
			this.Line311.LineWeight = 1F;
			this.Line311.Name = "Line311";
			this.Line311.Top = 2.717F;
			this.Line311.Width = 3.7505F;
			this.Line311.X1 = 0.0004997253F;
			this.Line311.X2 = 3.751F;
			this.Line311.Y1 = 2.717F;
			this.Line311.Y2 = 2.717F;
			// 
			// Paymnt9Amt7
			// 
			this.Paymnt9Amt7.DataField = "PAYMNT_9AMT7";
			this.Paymnt9Amt7.Height = 0.143F;
			this.Paymnt9Amt7.Left = 0F;
			this.Paymnt9Amt7.Name = "Paymnt9Amt7";
			this.Paymnt9Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt7.Top = 2.574F;
			this.Paymnt9Amt7.Width = 0.625F;
			// 
			// Ded9Amt7
			// 
			this.Ded9Amt7.DataField = "DED_9AMT7";
			this.Ded9Amt7.Height = 0.143F;
			this.Ded9Amt7.Left = 0F;
			this.Ded9Amt7.Name = "Ded9Amt7";
			this.Ded9Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt7.Top = 2.717F;
			this.Ded9Amt7.Width = 0.625F;
			// 
			// Paymnt9Amt8
			// 
			this.Paymnt9Amt8.DataField = "PAYMNT_9AMT8";
			this.Paymnt9Amt8.Height = 0.143F;
			this.Paymnt9Amt8.Left = 0.625F;
			this.Paymnt9Amt8.Name = "Paymnt9Amt8";
			this.Paymnt9Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt8.Top = 2.574F;
			this.Paymnt9Amt8.Width = 0.625F;
			// 
			// Ded9Amt8
			// 
			this.Ded9Amt8.DataField = "DED_9AMT8";
			this.Ded9Amt8.Height = 0.143F;
			this.Ded9Amt8.Left = 0.625F;
			this.Ded9Amt8.Name = "Ded9Amt8";
			this.Ded9Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt8.Top = 2.717F;
			this.Ded9Amt8.Width = 0.625F;
			// 
			// Paymnt9Amt9
			// 
			this.Paymnt9Amt9.DataField = "PAYMNT_9AMT9";
			this.Paymnt9Amt9.Height = 0.143F;
			this.Paymnt9Amt9.Left = 1.251F;
			this.Paymnt9Amt9.Name = "Paymnt9Amt9";
			this.Paymnt9Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt9.Top = 2.574F;
			this.Paymnt9Amt9.Width = 0.625F;
			// 
			// Ded9Amt9
			// 
			this.Ded9Amt9.DataField = "DED_9AMT9";
			this.Ded9Amt9.Height = 0.143F;
			this.Ded9Amt9.Left = 1.251F;
			this.Ded9Amt9.Name = "Ded9Amt9";
			this.Ded9Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt9.Top = 2.717F;
			this.Ded9Amt9.Width = 0.625F;
			// 
			// Paymnt9Amt10
			// 
			this.Paymnt9Amt10.DataField = "PAYMNT_9AMT10";
			this.Paymnt9Amt10.Height = 0.143F;
			this.Paymnt9Amt10.Left = 1.875F;
			this.Paymnt9Amt10.Name = "Paymnt9Amt10";
			this.Paymnt9Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt10.Top = 2.574F;
			this.Paymnt9Amt10.Width = 0.625F;
			// 
			// Ded9Amt10
			// 
			this.Ded9Amt10.DataField = "DED_9AMT10";
			this.Ded9Amt10.Height = 0.143F;
			this.Ded9Amt10.Left = 1.875F;
			this.Ded9Amt10.Name = "Ded9Amt10";
			this.Ded9Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt10.Top = 2.717F;
			this.Ded9Amt10.Width = 0.625F;
			// 
			// Paymnt9Amt11
			// 
			this.Paymnt9Amt11.DataField = "PAYMNT_9AMT11";
			this.Paymnt9Amt11.Height = 0.143F;
			this.Paymnt9Amt11.Left = 2.501F;
			this.Paymnt9Amt11.Name = "Paymnt9Amt11";
			this.Paymnt9Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt11.Top = 2.574F;
			this.Paymnt9Amt11.Width = 0.625F;
			// 
			// Ded9Amt11
			// 
			this.Ded9Amt11.DataField = "DED_9AMT11";
			this.Ded9Amt11.Height = 0.143F;
			this.Ded9Amt11.Left = 2.501F;
			this.Ded9Amt11.Name = "Ded9Amt11";
			this.Ded9Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt11.Top = 2.717F;
			this.Ded9Amt11.Width = 0.625F;
			// 
			// Paymnt9Amt12
			// 
			this.Paymnt9Amt12.DataField = "PAYMNT_9AMT12";
			this.Paymnt9Amt12.Height = 0.143F;
			this.Paymnt9Amt12.Left = 3.125F;
			this.Paymnt9Amt12.Name = "Paymnt9Amt12";
			this.Paymnt9Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt12.Top = 2.574F;
			this.Paymnt9Amt12.Width = 0.625F;
			// 
			// Ded9Amt12
			// 
			this.Ded9Amt12.DataField = "DED_9AMT12";
			this.Ded9Amt12.Height = 0.143F;
			this.Ded9Amt12.Left = 3.125F;
			this.Ded9Amt12.Name = "Ded9Amt12";
			this.Ded9Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt12.Top = 2.717F;
			this.Ded9Amt12.Width = 0.625F;
			// 
			// Line313
			// 
			this.Line313.Height = 0F;
			this.Line313.Left = 0.0004997253F;
			this.Line313.LineWeight = 1F;
			this.Line313.Name = "Line313";
			this.Line313.Top = 2.86F;
			this.Line313.Width = 3.7505F;
			this.Line313.X1 = 0.0004997253F;
			this.Line313.X2 = 3.751F;
			this.Line313.Y1 = 2.86F;
			this.Line313.Y2 = 2.86F;
			// 
			// Line315
			// 
			this.Line315.Height = 0F;
			this.Line315.Left = 0.0004997253F;
			this.Line315.LineWeight = 1F;
			this.Line315.Name = "Line315";
			this.Line315.Top = 3.003F;
			this.Line315.Width = 3.7505F;
			this.Line315.X1 = 0.0004997253F;
			this.Line315.X2 = 3.751F;
			this.Line315.Y1 = 3.003F;
			this.Line315.Y2 = 3.003F;
			// 
			// Paymnt10Amt7
			// 
			this.Paymnt10Amt7.DataField = "PAYMNT_10AMT7";
			this.Paymnt10Amt7.Height = 0.143F;
			this.Paymnt10Amt7.Left = 0F;
			this.Paymnt10Amt7.Name = "Paymnt10Amt7";
			this.Paymnt10Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt7.Top = 2.86F;
			this.Paymnt10Amt7.Width = 0.625F;
			// 
			// Ded10Amt7
			// 
			this.Ded10Amt7.DataField = "DED_10AMT7";
			this.Ded10Amt7.Height = 0.143F;
			this.Ded10Amt7.Left = 0F;
			this.Ded10Amt7.Name = "Ded10Amt7";
			this.Ded10Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt7.Top = 3.003F;
			this.Ded10Amt7.Width = 0.625F;
			// 
			// Paymnt10Amt8
			// 
			this.Paymnt10Amt8.DataField = "PAYMNT_10AMT8";
			this.Paymnt10Amt8.Height = 0.143F;
			this.Paymnt10Amt8.Left = 0.625F;
			this.Paymnt10Amt8.Name = "Paymnt10Amt8";
			this.Paymnt10Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt8.Top = 2.86F;
			this.Paymnt10Amt8.Width = 0.625F;
			// 
			// Ded10Amt8
			// 
			this.Ded10Amt8.DataField = "DED_10AMT8";
			this.Ded10Amt8.Height = 0.143F;
			this.Ded10Amt8.Left = 0.625F;
			this.Ded10Amt8.Name = "Ded10Amt8";
			this.Ded10Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt8.Top = 3.003F;
			this.Ded10Amt8.Width = 0.625F;
			// 
			// Paymnt10Amt9
			// 
			this.Paymnt10Amt9.DataField = "PAYMNT_10AMT9";
			this.Paymnt10Amt9.Height = 0.143F;
			this.Paymnt10Amt9.Left = 1.251F;
			this.Paymnt10Amt9.Name = "Paymnt10Amt9";
			this.Paymnt10Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt9.Top = 2.86F;
			this.Paymnt10Amt9.Width = 0.625F;
			// 
			// Ded10Amt9
			// 
			this.Ded10Amt9.DataField = "DED_10AMT9";
			this.Ded10Amt9.Height = 0.143F;
			this.Ded10Amt9.Left = 1.251F;
			this.Ded10Amt9.Name = "Ded10Amt9";
			this.Ded10Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt9.Top = 3.003F;
			this.Ded10Amt9.Width = 0.625F;
			// 
			// Paymnt10Amt10
			// 
			this.Paymnt10Amt10.DataField = "PAYMNT_10AMT10";
			this.Paymnt10Amt10.Height = 0.143F;
			this.Paymnt10Amt10.Left = 1.875F;
			this.Paymnt10Amt10.Name = "Paymnt10Amt10";
			this.Paymnt10Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt10.Top = 2.86F;
			this.Paymnt10Amt10.Width = 0.625F;
			// 
			// Ded10Amt10
			// 
			this.Ded10Amt10.DataField = "DED_10AMT10";
			this.Ded10Amt10.Height = 0.143F;
			this.Ded10Amt10.Left = 1.875F;
			this.Ded10Amt10.Name = "Ded10Amt10";
			this.Ded10Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt10.Top = 3.003F;
			this.Ded10Amt10.Width = 0.625F;
			// 
			// Paymnt10Amt11
			// 
			this.Paymnt10Amt11.DataField = "PAYMNT_10AMT11";
			this.Paymnt10Amt11.Height = 0.143F;
			this.Paymnt10Amt11.Left = 2.501F;
			this.Paymnt10Amt11.Name = "Paymnt10Amt11";
			this.Paymnt10Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt11.Top = 2.86F;
			this.Paymnt10Amt11.Width = 0.625F;
			// 
			// Ded10Amt11
			// 
			this.Ded10Amt11.DataField = "DED_10AMT11";
			this.Ded10Amt11.Height = 0.143F;
			this.Ded10Amt11.Left = 2.501F;
			this.Ded10Amt11.Name = "Ded10Amt11";
			this.Ded10Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt11.Top = 3.003F;
			this.Ded10Amt11.Width = 0.625F;
			// 
			// Paymnt10Amt12
			// 
			this.Paymnt10Amt12.DataField = "PAYMNT_10AMT12";
			this.Paymnt10Amt12.Height = 0.143F;
			this.Paymnt10Amt12.Left = 3.125F;
			this.Paymnt10Amt12.Name = "Paymnt10Amt12";
			this.Paymnt10Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt12.Top = 2.86F;
			this.Paymnt10Amt12.Width = 0.625F;
			// 
			// Ded10Amt12
			// 
			this.Ded10Amt12.DataField = "DED_10AMT12";
			this.Ded10Amt12.Height = 0.143F;
			this.Ded10Amt12.Left = 3.125F;
			this.Ded10Amt12.Name = "Ded10Amt12";
			this.Ded10Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt12.Top = 3.003F;
			this.Ded10Amt12.Width = 0.625F;
			// 
			// Line318
			// 
			this.Line318.Height = 0F;
			this.Line318.Left = 0.0004997253F;
			this.Line318.LineWeight = 1F;
			this.Line318.Name = "Line318";
			this.Line318.Top = 3.146F;
			this.Line318.Width = 3.7505F;
			this.Line318.X1 = 0.0004997253F;
			this.Line318.X2 = 3.751F;
			this.Line318.Y1 = 3.146F;
			this.Line318.Y2 = 3.146F;
			// 
			// Line319
			// 
			this.Line319.Height = 0F;
			this.Line319.Left = 0.0004997253F;
			this.Line319.LineWeight = 1F;
			this.Line319.Name = "Line319";
			this.Line319.Top = 3.289F;
			this.Line319.Width = 3.7505F;
			this.Line319.X1 = 0.0004997253F;
			this.Line319.X2 = 3.751F;
			this.Line319.Y1 = 3.289F;
			this.Line319.Y2 = 3.289F;
			// 
			// Paymnt11Amt7
			// 
			this.Paymnt11Amt7.DataField = "PAYMNT_11AMT7";
			this.Paymnt11Amt7.Height = 0.143F;
			this.Paymnt11Amt7.Left = 0F;
			this.Paymnt11Amt7.Name = "Paymnt11Amt7";
			this.Paymnt11Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt7.Top = 3.146F;
			this.Paymnt11Amt7.Width = 0.625F;
			// 
			// Ded11Amt7
			// 
			this.Ded11Amt7.DataField = "DED_11AMT7";
			this.Ded11Amt7.Height = 0.143F;
			this.Ded11Amt7.Left = 0F;
			this.Ded11Amt7.Name = "Ded11Amt7";
			this.Ded11Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt7.Top = 3.289F;
			this.Ded11Amt7.Width = 0.625F;
			// 
			// Paymnt11Amt8
			// 
			this.Paymnt11Amt8.DataField = "PAYMNT_11AMT8";
			this.Paymnt11Amt8.Height = 0.143F;
			this.Paymnt11Amt8.Left = 0.625F;
			this.Paymnt11Amt8.Name = "Paymnt11Amt8";
			this.Paymnt11Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt8.Top = 3.146F;
			this.Paymnt11Amt8.Width = 0.625F;
			// 
			// Ded11Amt8
			// 
			this.Ded11Amt8.DataField = "DED_11AMT8";
			this.Ded11Amt8.Height = 0.143F;
			this.Ded11Amt8.Left = 0.625F;
			this.Ded11Amt8.Name = "Ded11Amt8";
			this.Ded11Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt8.Top = 3.289F;
			this.Ded11Amt8.Width = 0.625F;
			// 
			// Paymnt11Amt9
			// 
			this.Paymnt11Amt9.DataField = "PAYMNT_11AMT9";
			this.Paymnt11Amt9.Height = 0.143F;
			this.Paymnt11Amt9.Left = 1.25F;
			this.Paymnt11Amt9.Name = "Paymnt11Amt9";
			this.Paymnt11Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt9.Top = 3.146F;
			this.Paymnt11Amt9.Width = 0.625F;
			// 
			// Ded11Amt9
			// 
			this.Ded11Amt9.DataField = "DED_11AMT9";
			this.Ded11Amt9.Height = 0.143F;
			this.Ded11Amt9.Left = 1.251F;
			this.Ded11Amt9.Name = "Ded11Amt9";
			this.Ded11Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt9.Top = 3.289F;
			this.Ded11Amt9.Width = 0.625F;
			// 
			// Paymnt11Amt10
			// 
			this.Paymnt11Amt10.DataField = "PAYMNT_11AMT10";
			this.Paymnt11Amt10.Height = 0.143F;
			this.Paymnt11Amt10.Left = 1.875F;
			this.Paymnt11Amt10.Name = "Paymnt11Amt10";
			this.Paymnt11Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt10.Top = 3.146F;
			this.Paymnt11Amt10.Width = 0.625F;
			// 
			// Ded11Amt10
			// 
			this.Ded11Amt10.DataField = "DED_11AMT10";
			this.Ded11Amt10.Height = 0.143F;
			this.Ded11Amt10.Left = 1.875F;
			this.Ded11Amt10.Name = "Ded11Amt10";
			this.Ded11Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt10.Top = 3.289F;
			this.Ded11Amt10.Width = 0.625F;
			// 
			// Paymnt11Amt11
			// 
			this.Paymnt11Amt11.DataField = "PAYMNT_11AMT11";
			this.Paymnt11Amt11.Height = 0.143F;
			this.Paymnt11Amt11.Left = 2.501F;
			this.Paymnt11Amt11.Name = "Paymnt11Amt11";
			this.Paymnt11Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt11.Top = 3.146F;
			this.Paymnt11Amt11.Width = 0.625F;
			// 
			// Ded11Amt11
			// 
			this.Ded11Amt11.DataField = "DED_11AMT11";
			this.Ded11Amt11.Height = 0.143F;
			this.Ded11Amt11.Left = 2.501F;
			this.Ded11Amt11.Name = "Ded11Amt11";
			this.Ded11Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt11.Top = 3.289F;
			this.Ded11Amt11.Width = 0.625F;
			// 
			// Paymnt11Amt12
			// 
			this.Paymnt11Amt12.DataField = "PAYMNT_11AMT12";
			this.Paymnt11Amt12.Height = 0.143F;
			this.Paymnt11Amt12.Left = 3.125F;
			this.Paymnt11Amt12.Name = "Paymnt11Amt12";
			this.Paymnt11Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt12.Top = 3.146F;
			this.Paymnt11Amt12.Width = 0.625F;
			// 
			// Ded11Amt12
			// 
			this.Ded11Amt12.DataField = "DED_11AMT12";
			this.Ded11Amt12.Height = 0.143F;
			this.Ded11Amt12.Left = 3.125F;
			this.Ded11Amt12.Name = "Ded11Amt12";
			this.Ded11Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt12.Top = 3.289F;
			this.Ded11Amt12.Width = 0.625F;
			// 
			// Line322
			// 
			this.Line322.Height = 0F;
			this.Line322.Left = 0.0004997253F;
			this.Line322.LineWeight = 1F;
			this.Line322.Name = "Line322";
			this.Line322.Top = 3.432F;
			this.Line322.Width = 3.7505F;
			this.Line322.X1 = 0.0004997253F;
			this.Line322.X2 = 3.751F;
			this.Line322.Y1 = 3.432F;
			this.Line322.Y2 = 3.432F;
			// 
			// Line323
			// 
			this.Line323.Height = 0F;
			this.Line323.Left = 0.0004997253F;
			this.Line323.LineWeight = 1F;
			this.Line323.Name = "Line323";
			this.Line323.Top = 3.575F;
			this.Line323.Width = 3.7505F;
			this.Line323.X1 = 0.0004997253F;
			this.Line323.X2 = 3.751F;
			this.Line323.Y1 = 3.575F;
			this.Line323.Y2 = 3.575F;
			// 
			// Paymnt12Amt7
			// 
			this.Paymnt12Amt7.DataField = "PAYMNT_12AMT7";
			this.Paymnt12Amt7.Height = 0.143F;
			this.Paymnt12Amt7.Left = 0F;
			this.Paymnt12Amt7.Name = "Paymnt12Amt7";
			this.Paymnt12Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt7.Top = 3.432F;
			this.Paymnt12Amt7.Width = 0.625F;
			// 
			// Ded12Amt7
			// 
			this.Ded12Amt7.DataField = "DED_12AMT7";
			this.Ded12Amt7.Height = 0.143F;
			this.Ded12Amt7.Left = 0F;
			this.Ded12Amt7.Name = "Ded12Amt7";
			this.Ded12Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt7.Top = 3.575F;
			this.Ded12Amt7.Width = 0.625F;
			// 
			// Paymnt12Amt8
			// 
			this.Paymnt12Amt8.DataField = "PAYMNT_12AMT8";
			this.Paymnt12Amt8.Height = 0.143F;
			this.Paymnt12Amt8.Left = 0.625F;
			this.Paymnt12Amt8.Name = "Paymnt12Amt8";
			this.Paymnt12Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt8.Top = 3.432F;
			this.Paymnt12Amt8.Width = 0.625F;
			// 
			// Ded12Amt8
			// 
			this.Ded12Amt8.DataField = "DED_12AMT8";
			this.Ded12Amt8.Height = 0.143F;
			this.Ded12Amt8.Left = 0.625F;
			this.Ded12Amt8.Name = "Ded12Amt8";
			this.Ded12Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt8.Top = 3.575F;
			this.Ded12Amt8.Width = 0.625F;
			// 
			// Paymnt12Amt9
			// 
			this.Paymnt12Amt9.DataField = "PAYMNT_12AMT9";
			this.Paymnt12Amt9.Height = 0.143F;
			this.Paymnt12Amt9.Left = 1.251F;
			this.Paymnt12Amt9.Name = "Paymnt12Amt9";
			this.Paymnt12Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt9.Top = 3.432F;
			this.Paymnt12Amt9.Width = 0.625F;
			// 
			// Ded12Amt9
			// 
			this.Ded12Amt9.DataField = "DED_12AMT9";
			this.Ded12Amt9.Height = 0.143F;
			this.Ded12Amt9.Left = 1.251F;
			this.Ded12Amt9.Name = "Ded12Amt9";
			this.Ded12Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt9.Top = 3.575F;
			this.Ded12Amt9.Width = 0.625F;
			// 
			// Paymnt12Amt10
			// 
			this.Paymnt12Amt10.DataField = "PAYMNT_12AMT10";
			this.Paymnt12Amt10.Height = 0.143F;
			this.Paymnt12Amt10.Left = 1.875F;
			this.Paymnt12Amt10.Name = "Paymnt12Amt10";
			this.Paymnt12Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt10.Top = 3.432F;
			this.Paymnt12Amt10.Width = 0.625F;
			// 
			// Ded12Amt10
			// 
			this.Ded12Amt10.DataField = "DED_12AMT10";
			this.Ded12Amt10.Height = 0.143F;
			this.Ded12Amt10.Left = 1.875F;
			this.Ded12Amt10.Name = "Ded12Amt10";
			this.Ded12Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt10.Top = 3.575F;
			this.Ded12Amt10.Width = 0.625F;
			// 
			// Paymnt12Amt11
			// 
			this.Paymnt12Amt11.DataField = "PAYMNT_12AMT11";
			this.Paymnt12Amt11.Height = 0.143F;
			this.Paymnt12Amt11.Left = 2.501F;
			this.Paymnt12Amt11.Name = "Paymnt12Amt11";
			this.Paymnt12Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt11.Top = 3.432F;
			this.Paymnt12Amt11.Width = 0.625F;
			// 
			// Ded12Amt11
			// 
			this.Ded12Amt11.DataField = "DED_12AMT11";
			this.Ded12Amt11.Height = 0.143F;
			this.Ded12Amt11.Left = 2.5F;
			this.Ded12Amt11.Name = "Ded12Amt11";
			this.Ded12Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt11.Top = 3.575F;
			this.Ded12Amt11.Width = 0.625F;
			// 
			// Paymnt12Amt12
			// 
			this.Paymnt12Amt12.DataField = "PAYMNT_12AMT12";
			this.Paymnt12Amt12.Height = 0.143F;
			this.Paymnt12Amt12.Left = 3.125F;
			this.Paymnt12Amt12.Name = "Paymnt12Amt12";
			this.Paymnt12Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt12.Top = 3.432F;
			this.Paymnt12Amt12.Width = 0.625F;
			// 
			// Ded12Amt12
			// 
			this.Ded12Amt12.DataField = "DED_12AMT12";
			this.Ded12Amt12.Height = 0.143F;
			this.Ded12Amt12.Left = 3.125F;
			this.Ded12Amt12.Name = "Ded12Amt12";
			this.Ded12Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt12.Top = 3.575F;
			this.Ded12Amt12.Width = 0.625F;
			// 
			// Line325
			// 
			this.Line325.Height = 0F;
			this.Line325.Left = 0.0004997253F;
			this.Line325.LineWeight = 1F;
			this.Line325.Name = "Line325";
			this.Line325.Top = 3.718F;
			this.Line325.Width = 3.7505F;
			this.Line325.X1 = 0.0004997253F;
			this.Line325.X2 = 3.751F;
			this.Line325.Y1 = 3.718F;
			this.Line325.Y2 = 3.718F;
			// 
			// Line327
			// 
			this.Line327.Height = 0F;
			this.Line327.Left = 0.0004997253F;
			this.Line327.LineWeight = 1F;
			this.Line327.Name = "Line327";
			this.Line327.Top = 3.861001F;
			this.Line327.Width = 3.7505F;
			this.Line327.X1 = 0.0004997253F;
			this.Line327.X2 = 3.751F;
			this.Line327.Y1 = 3.861001F;
			this.Line327.Y2 = 3.861001F;
			// 
			// PaymntTotal1Amt7
			// 
			this.PaymntTotal1Amt7.Height = 0.143F;
			this.PaymntTotal1Amt7.Left = 0F;
			this.PaymntTotal1Amt7.Name = "PaymntTotal1Amt7";
			this.PaymntTotal1Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt7.Top = 3.718F;
			this.PaymntTotal1Amt7.Width = 0.625F;
			// 
			// DedTotal1Amt7
			// 
			this.DedTotal1Amt7.Height = 0.143F;
			this.DedTotal1Amt7.Left = 0F;
			this.DedTotal1Amt7.Name = "DedTotal1Amt7";
			this.DedTotal1Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt7.Top = 3.861001F;
			this.DedTotal1Amt7.Width = 0.625F;
			// 
			// PaymntTotal1Amt8
			// 
			this.PaymntTotal1Amt8.Height = 0.143F;
			this.PaymntTotal1Amt8.Left = 0.625F;
			this.PaymntTotal1Amt8.Name = "PaymntTotal1Amt8";
			this.PaymntTotal1Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt8.Top = 3.718F;
			this.PaymntTotal1Amt8.Width = 0.625F;
			// 
			// DedTotal1Amt8
			// 
			this.DedTotal1Amt8.Height = 0.143F;
			this.DedTotal1Amt8.Left = 0.625F;
			this.DedTotal1Amt8.Name = "DedTotal1Amt8";
			this.DedTotal1Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt8.Top = 3.861001F;
			this.DedTotal1Amt8.Width = 0.625F;
			// 
			// PaymntTotal1Amt9
			// 
			this.PaymntTotal1Amt9.Height = 0.143F;
			this.PaymntTotal1Amt9.Left = 1.251F;
			this.PaymntTotal1Amt9.Name = "PaymntTotal1Amt9";
			this.PaymntTotal1Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt9.Top = 3.718F;
			this.PaymntTotal1Amt9.Width = 0.625F;
			// 
			// DedTotal1Amt9
			// 
			this.DedTotal1Amt9.Height = 0.143F;
			this.DedTotal1Amt9.Left = 1.251F;
			this.DedTotal1Amt9.Name = "DedTotal1Amt9";
			this.DedTotal1Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt9.Top = 3.861001F;
			this.DedTotal1Amt9.Width = 0.625F;
			// 
			// PaymntTotal1Amt10
			// 
			this.PaymntTotal1Amt10.Height = 0.143F;
			this.PaymntTotal1Amt10.Left = 1.875F;
			this.PaymntTotal1Amt10.Name = "PaymntTotal1Amt10";
			this.PaymntTotal1Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt10.Top = 3.718F;
			this.PaymntTotal1Amt10.Width = 0.625F;
			// 
			// DedTotal1Amt10
			// 
			this.DedTotal1Amt10.Height = 0.143F;
			this.DedTotal1Amt10.Left = 1.875F;
			this.DedTotal1Amt10.Name = "DedTotal1Amt10";
			this.DedTotal1Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt10.Top = 3.861001F;
			this.DedTotal1Amt10.Width = 0.625F;
			// 
			// PaymntTotal1Amt11
			// 
			this.PaymntTotal1Amt11.Height = 0.143F;
			this.PaymntTotal1Amt11.Left = 2.501F;
			this.PaymntTotal1Amt11.Name = "PaymntTotal1Amt11";
			this.PaymntTotal1Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt11.Top = 3.718F;
			this.PaymntTotal1Amt11.Width = 0.625F;
			// 
			// DedTotal1Amt11
			// 
			this.DedTotal1Amt11.Height = 0.143F;
			this.DedTotal1Amt11.Left = 2.5F;
			this.DedTotal1Amt11.Name = "DedTotal1Amt11";
			this.DedTotal1Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt11.Top = 3.861001F;
			this.DedTotal1Amt11.Width = 0.625F;
			// 
			// PaymntTotal1Amt12
			// 
			this.PaymntTotal1Amt12.Height = 0.143F;
			this.PaymntTotal1Amt12.Left = 3.125F;
			this.PaymntTotal1Amt12.Name = "PaymntTotal1Amt12";
			this.PaymntTotal1Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt12.Top = 3.718F;
			this.PaymntTotal1Amt12.Width = 0.625F;
			// 
			// DedTotal1Amt12
			// 
			this.DedTotal1Amt12.Height = 0.143F;
			this.DedTotal1Amt12.Left = 3.125F;
			this.DedTotal1Amt12.Name = "DedTotal1Amt12";
			this.DedTotal1Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt12.Top = 3.861001F;
			this.DedTotal1Amt12.Width = 0.625F;
			// 
			// Line328
			// 
			this.Line328.Height = 0F;
			this.Line328.Left = 0.0004997253F;
			this.Line328.LineWeight = 1F;
			this.Line328.Name = "Line328";
			this.Line328.Top = 4.004F;
			this.Line328.Width = 3.7505F;
			this.Line328.X1 = 0.0004997253F;
			this.Line328.X2 = 3.751F;
			this.Line328.Y1 = 4.004F;
			this.Line328.Y2 = 4.004F;
			// 
			// Line373
			// 
			this.Line373.Height = 0F;
			this.Line373.Left = 0.0004997253F;
			this.Line373.LineWeight = 1F;
			this.Line373.Name = "Line373";
			this.Line373.Top = 4.4595F;
			this.Line373.Width = 3.7505F;
			this.Line373.X1 = 0.0004997253F;
			this.Line373.X2 = 3.751F;
			this.Line373.Y1 = 4.4595F;
			this.Line373.Y2 = 4.4595F;
			// 
			// Paymnt13Amt7
			// 
			this.Paymnt13Amt7.DataField = "PAYMNT_13AMT7";
			this.Paymnt13Amt7.Height = 0.143F;
			this.Paymnt13Amt7.Left = 0F;
			this.Paymnt13Amt7.Name = "Paymnt13Amt7";
			this.Paymnt13Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt7.Top = 4.3165F;
			this.Paymnt13Amt7.Width = 0.625F;
			// 
			// Ded13Amt7
			// 
			this.Ded13Amt7.DataField = "DED_13AMT7";
			this.Ded13Amt7.Height = 0.143F;
			this.Ded13Amt7.Left = 0F;
			this.Ded13Amt7.Name = "Ded13Amt7";
			this.Ded13Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt7.Top = 4.4595F;
			this.Ded13Amt7.Width = 0.625F;
			// 
			// Paymnt13Amt8
			// 
			this.Paymnt13Amt8.DataField = "PAYMNT_13AMT8";
			this.Paymnt13Amt8.Height = 0.143F;
			this.Paymnt13Amt8.Left = 0.625F;
			this.Paymnt13Amt8.Name = "Paymnt13Amt8";
			this.Paymnt13Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt8.Top = 4.3165F;
			this.Paymnt13Amt8.Width = 0.625F;
			// 
			// Ded13Amt8
			// 
			this.Ded13Amt8.DataField = "DED_13AMT8";
			this.Ded13Amt8.Height = 0.143F;
			this.Ded13Amt8.Left = 0.625F;
			this.Ded13Amt8.Name = "Ded13Amt8";
			this.Ded13Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt8.Top = 4.4595F;
			this.Ded13Amt8.Width = 0.625F;
			// 
			// Paymnt13Amt9
			// 
			this.Paymnt13Amt9.DataField = "PAYMNT_13AMT9";
			this.Paymnt13Amt9.Height = 0.143F;
			this.Paymnt13Amt9.Left = 1.251F;
			this.Paymnt13Amt9.Name = "Paymnt13Amt9";
			this.Paymnt13Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt9.Top = 4.3165F;
			this.Paymnt13Amt9.Width = 0.625F;
			// 
			// Ded13Amt9
			// 
			this.Ded13Amt9.DataField = "DED_13AMT9";
			this.Ded13Amt9.Height = 0.143F;
			this.Ded13Amt9.Left = 1.251F;
			this.Ded13Amt9.Name = "Ded13Amt9";
			this.Ded13Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt9.Top = 4.4595F;
			this.Ded13Amt9.Width = 0.625F;
			// 
			// Paymnt13Amt10
			// 
			this.Paymnt13Amt10.DataField = "PAYMNT_13AMT10";
			this.Paymnt13Amt10.Height = 0.143F;
			this.Paymnt13Amt10.Left = 1.875F;
			this.Paymnt13Amt10.Name = "Paymnt13Amt10";
			this.Paymnt13Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt10.Top = 4.3165F;
			this.Paymnt13Amt10.Width = 0.625F;
			// 
			// Ded13Amt10
			// 
			this.Ded13Amt10.DataField = "DED_13AMT10";
			this.Ded13Amt10.Height = 0.143F;
			this.Ded13Amt10.Left = 1.875F;
			this.Ded13Amt10.Name = "Ded13Amt10";
			this.Ded13Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt10.Top = 4.4595F;
			this.Ded13Amt10.Width = 0.625F;
			// 
			// Paymnt13Amt11
			// 
			this.Paymnt13Amt11.DataField = "PAYMNT_13AMT11";
			this.Paymnt13Amt11.Height = 0.143F;
			this.Paymnt13Amt11.Left = 2.501F;
			this.Paymnt13Amt11.Name = "Paymnt13Amt11";
			this.Paymnt13Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt11.Top = 4.3165F;
			this.Paymnt13Amt11.Width = 0.625F;
			// 
			// Ded13Amt11
			// 
			this.Ded13Amt11.DataField = "DED_13AMT11";
			this.Ded13Amt11.Height = 0.143F;
			this.Ded13Amt11.Left = 2.501F;
			this.Ded13Amt11.Name = "Ded13Amt11";
			this.Ded13Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt11.Top = 4.4595F;
			this.Ded13Amt11.Width = 0.625F;
			// 
			// Paymnt13Amt12
			// 
			this.Paymnt13Amt12.DataField = "PAYMNT_13AMT12";
			this.Paymnt13Amt12.Height = 0.143F;
			this.Paymnt13Amt12.Left = 3.125F;
			this.Paymnt13Amt12.Name = "Paymnt13Amt12";
			this.Paymnt13Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt12.Top = 4.3165F;
			this.Paymnt13Amt12.Width = 0.625F;
			// 
			// Ded13Amt12
			// 
			this.Ded13Amt12.DataField = "DED_13AMT12";
			this.Ded13Amt12.Height = 0.143F;
			this.Ded13Amt12.Left = 3.125F;
			this.Ded13Amt12.Name = "Ded13Amt12";
			this.Ded13Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt12.Top = 4.4595F;
			this.Ded13Amt12.Width = 0.625F;
			// 
			// Line374
			// 
			this.Line374.Height = 0F;
			this.Line374.Left = 0.0004997253F;
			this.Line374.LineWeight = 1F;
			this.Line374.Name = "Line374";
			this.Line374.Top = 4.602499F;
			this.Line374.Width = 3.7505F;
			this.Line374.X1 = 0.0004997253F;
			this.Line374.X2 = 3.751F;
			this.Line374.Y1 = 4.602499F;
			this.Line374.Y2 = 4.602499F;
			// 
			// Line375
			// 
			this.Line375.Height = 0F;
			this.Line375.Left = 0.0004997253F;
			this.Line375.LineWeight = 1F;
			this.Line375.Name = "Line375";
			this.Line375.Top = 5.0315F;
			this.Line375.Width = 3.7505F;
			this.Line375.X1 = 0.0004997253F;
			this.Line375.X2 = 3.751F;
			this.Line375.Y1 = 5.0315F;
			this.Line375.Y2 = 5.0315F;
			// 
			// Paymnt14Amt7
			// 
			this.Paymnt14Amt7.DataField = "PAYMNT_14AMT7";
			this.Paymnt14Amt7.Height = 0.143F;
			this.Paymnt14Amt7.Left = 0F;
			this.Paymnt14Amt7.Name = "Paymnt14Amt7";
			this.Paymnt14Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt7.Top = 4.602499F;
			this.Paymnt14Amt7.Width = 0.625F;
			// 
			// Ded14Amt7
			// 
			this.Ded14Amt7.DataField = "DED_14AMT7";
			this.Ded14Amt7.Height = 0.143F;
			this.Ded14Amt7.Left = 0F;
			this.Ded14Amt7.Name = "Ded14Amt7";
			this.Ded14Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt7.Top = 4.7455F;
			this.Ded14Amt7.Width = 0.625F;
			// 
			// Paymnt14Amt8
			// 
			this.Paymnt14Amt8.DataField = "PAYMNT_14AMT8";
			this.Paymnt14Amt8.Height = 0.143F;
			this.Paymnt14Amt8.Left = 0.625F;
			this.Paymnt14Amt8.Name = "Paymnt14Amt8";
			this.Paymnt14Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt8.Top = 4.602499F;
			this.Paymnt14Amt8.Width = 0.625F;
			// 
			// Ded14Amt8
			// 
			this.Ded14Amt8.DataField = "DED_14AMT8";
			this.Ded14Amt8.Height = 0.143F;
			this.Ded14Amt8.Left = 0.625F;
			this.Ded14Amt8.Name = "Ded14Amt8";
			this.Ded14Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt8.Top = 4.7455F;
			this.Ded14Amt8.Width = 0.625F;
			// 
			// Paymnt14Amt9
			// 
			this.Paymnt14Amt9.DataField = "PAYMNT_14AMT9";
			this.Paymnt14Amt9.Height = 0.143F;
			this.Paymnt14Amt9.Left = 1.251F;
			this.Paymnt14Amt9.Name = "Paymnt14Amt9";
			this.Paymnt14Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt9.Top = 4.602499F;
			this.Paymnt14Amt9.Width = 0.625F;
			// 
			// Ded14Amt9
			// 
			this.Ded14Amt9.DataField = "DED_14AMT9";
			this.Ded14Amt9.Height = 0.143F;
			this.Ded14Amt9.Left = 1.251F;
			this.Ded14Amt9.Name = "Ded14Amt9";
			this.Ded14Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt9.Top = 4.7455F;
			this.Ded14Amt9.Width = 0.625F;
			// 
			// Paymnt14Amt10
			// 
			this.Paymnt14Amt10.DataField = "PAYMNT_14AMT10";
			this.Paymnt14Amt10.Height = 0.143F;
			this.Paymnt14Amt10.Left = 1.875F;
			this.Paymnt14Amt10.Name = "Paymnt14Amt10";
			this.Paymnt14Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt10.Top = 4.602499F;
			this.Paymnt14Amt10.Width = 0.625F;
			// 
			// Ded14Amt10
			// 
			this.Ded14Amt10.DataField = "DED_14AMT10";
			this.Ded14Amt10.Height = 0.143F;
			this.Ded14Amt10.Left = 1.875F;
			this.Ded14Amt10.Name = "Ded14Amt10";
			this.Ded14Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt10.Top = 4.7455F;
			this.Ded14Amt10.Width = 0.625F;
			// 
			// Paymnt14Amt11
			// 
			this.Paymnt14Amt11.DataField = "PAYMNT_14AMT11";
			this.Paymnt14Amt11.Height = 0.143F;
			this.Paymnt14Amt11.Left = 2.501F;
			this.Paymnt14Amt11.Name = "Paymnt14Amt11";
			this.Paymnt14Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt11.Top = 4.602499F;
			this.Paymnt14Amt11.Width = 0.625F;
			// 
			// Ded14Amt11
			// 
			this.Ded14Amt11.DataField = "DED_14AMT11";
			this.Ded14Amt11.Height = 0.143F;
			this.Ded14Amt11.Left = 2.501F;
			this.Ded14Amt11.Name = "Ded14Amt11";
			this.Ded14Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt11.Top = 4.7455F;
			this.Ded14Amt11.Width = 0.625F;
			// 
			// Paymnt14Amt12
			// 
			this.Paymnt14Amt12.DataField = "PAYMNT_14AMT12";
			this.Paymnt14Amt12.Height = 0.143F;
			this.Paymnt14Amt12.Left = 3.125F;
			this.Paymnt14Amt12.Name = "Paymnt14Amt12";
			this.Paymnt14Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt12.Top = 4.602499F;
			this.Paymnt14Amt12.Width = 0.625F;
			// 
			// Ded14Amt12
			// 
			this.Ded14Amt12.DataField = "DED_14AMT12";
			this.Ded14Amt12.Height = 0.143F;
			this.Ded14Amt12.Left = 3.125F;
			this.Ded14Amt12.Name = "Ded14Amt12";
			this.Ded14Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt12.Top = 4.7455F;
			this.Ded14Amt12.Width = 0.625F;
			// 
			// Line376
			// 
			this.Line376.Height = 0F;
			this.Line376.Left = 0.0004997253F;
			this.Line376.LineWeight = 1F;
			this.Line376.Name = "Line376";
			this.Line376.Top = 4.8885F;
			this.Line376.Width = 3.7505F;
			this.Line376.X1 = 0.0004997253F;
			this.Line376.X2 = 3.751F;
			this.Line376.Y1 = 4.8885F;
			this.Line376.Y2 = 4.8885F;
			// 
			// Line377
			// 
			this.Line377.Height = 0F;
			this.Line377.Left = 0.0004997253F;
			this.Line377.LineWeight = 1F;
			this.Line377.Name = "Line377";
			this.Line377.Top = 5.3175F;
			this.Line377.Width = 3.7505F;
			this.Line377.X1 = 0.0004997253F;
			this.Line377.X2 = 3.751F;
			this.Line377.Y1 = 5.3175F;
			this.Line377.Y2 = 5.3175F;
			// 
			// Paymnt15Amt7
			// 
			this.Paymnt15Amt7.DataField = "PAYMNT_15AMT7";
			this.Paymnt15Amt7.Height = 0.143F;
			this.Paymnt15Amt7.Left = 0F;
			this.Paymnt15Amt7.Name = "Paymnt15Amt7";
			this.Paymnt15Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt7.Top = 4.8885F;
			this.Paymnt15Amt7.Width = 0.625F;
			// 
			// Ded15Amt7
			// 
			this.Ded15Amt7.DataField = "DED_15AMT7";
			this.Ded15Amt7.Height = 0.143F;
			this.Ded15Amt7.Left = 0F;
			this.Ded15Amt7.Name = "Ded15Amt7";
			this.Ded15Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt7.Top = 5.0315F;
			this.Ded15Amt7.Width = 0.625F;
			// 
			// Paymnt15Amt8
			// 
			this.Paymnt15Amt8.DataField = "PAYMNT_15AMT8";
			this.Paymnt15Amt8.Height = 0.143F;
			this.Paymnt15Amt8.Left = 0.625F;
			this.Paymnt15Amt8.Name = "Paymnt15Amt8";
			this.Paymnt15Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt8.Top = 4.8885F;
			this.Paymnt15Amt8.Width = 0.625F;
			// 
			// Ded15Amt8
			// 
			this.Ded15Amt8.DataField = "DED_15AMT8";
			this.Ded15Amt8.Height = 0.143F;
			this.Ded15Amt8.Left = 0.625F;
			this.Ded15Amt8.Name = "Ded15Amt8";
			this.Ded15Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt8.Top = 5.0315F;
			this.Ded15Amt8.Width = 0.625F;
			// 
			// Paymnt15Amt9
			// 
			this.Paymnt15Amt9.DataField = "PAYMNT_15AMT9";
			this.Paymnt15Amt9.Height = 0.143F;
			this.Paymnt15Amt9.Left = 1.251F;
			this.Paymnt15Amt9.Name = "Paymnt15Amt9";
			this.Paymnt15Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt9.Top = 4.8885F;
			this.Paymnt15Amt9.Width = 0.625F;
			// 
			// Ded15Amt9
			// 
			this.Ded15Amt9.DataField = "DED_15AMT9";
			this.Ded15Amt9.Height = 0.143F;
			this.Ded15Amt9.Left = 1.251F;
			this.Ded15Amt9.Name = "Ded15Amt9";
			this.Ded15Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt9.Top = 5.0315F;
			this.Ded15Amt9.Width = 0.625F;
			// 
			// Paymnt15Amt10
			// 
			this.Paymnt15Amt10.DataField = "PAYMNT_15AMT10";
			this.Paymnt15Amt10.Height = 0.143F;
			this.Paymnt15Amt10.Left = 1.875F;
			this.Paymnt15Amt10.Name = "Paymnt15Amt10";
			this.Paymnt15Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt10.Top = 4.8885F;
			this.Paymnt15Amt10.Width = 0.625F;
			// 
			// Ded15Amt10
			// 
			this.Ded15Amt10.DataField = "DED_15AMT10";
			this.Ded15Amt10.Height = 0.143F;
			this.Ded15Amt10.Left = 1.875F;
			this.Ded15Amt10.Name = "Ded15Amt10";
			this.Ded15Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt10.Top = 5.0315F;
			this.Ded15Amt10.Width = 0.625F;
			// 
			// Paymnt15Amt11
			// 
			this.Paymnt15Amt11.DataField = "PAYMNT_15AMT11";
			this.Paymnt15Amt11.Height = 0.143F;
			this.Paymnt15Amt11.Left = 2.501F;
			this.Paymnt15Amt11.Name = "Paymnt15Amt11";
			this.Paymnt15Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt11.Top = 4.8885F;
			this.Paymnt15Amt11.Width = 0.625F;
			// 
			// Ded15Amt11
			// 
			this.Ded15Amt11.DataField = "DED_15AMT11";
			this.Ded15Amt11.Height = 0.143F;
			this.Ded15Amt11.Left = 2.501F;
			this.Ded15Amt11.Name = "Ded15Amt11";
			this.Ded15Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt11.Top = 5.0315F;
			this.Ded15Amt11.Width = 0.625F;
			// 
			// Paymnt15Amt12
			// 
			this.Paymnt15Amt12.DataField = "PAYMNT_15AMT12";
			this.Paymnt15Amt12.Height = 0.143F;
			this.Paymnt15Amt12.Left = 3.125F;
			this.Paymnt15Amt12.Name = "Paymnt15Amt12";
			this.Paymnt15Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt12.Top = 4.8885F;
			this.Paymnt15Amt12.Width = 0.625F;
			// 
			// Ded15Amt12
			// 
			this.Ded15Amt12.DataField = "DED_15AMT12";
			this.Ded15Amt12.Height = 0.143F;
			this.Ded15Amt12.Left = 3.125F;
			this.Ded15Amt12.Name = "Ded15Amt12";
			this.Ded15Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt12.Top = 5.0315F;
			this.Ded15Amt12.Width = 0.625F;
			// 
			// Line378
			// 
			this.Line378.Height = 0F;
			this.Line378.Left = 0.0004997253F;
			this.Line378.LineWeight = 1F;
			this.Line378.Name = "Line378";
			this.Line378.Top = 5.1745F;
			this.Line378.Width = 3.7505F;
			this.Line378.X1 = 0.0004997253F;
			this.Line378.X2 = 3.751F;
			this.Line378.Y1 = 5.1745F;
			this.Line378.Y2 = 5.1745F;
			// 
			// Paymnt16Amt7
			// 
			this.Paymnt16Amt7.DataField = "PAYMNT_16AMT7";
			this.Paymnt16Amt7.Height = 0.143F;
			this.Paymnt16Amt7.Left = 0F;
			this.Paymnt16Amt7.Name = "Paymnt16Amt7";
			this.Paymnt16Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt7.Top = 5.1745F;
			this.Paymnt16Amt7.Width = 0.625F;
			// 
			// Ded16Amt7
			// 
			this.Ded16Amt7.DataField = "DED_16AMT7";
			this.Ded16Amt7.Height = 0.143F;
			this.Ded16Amt7.Left = 0F;
			this.Ded16Amt7.Name = "Ded16Amt7";
			this.Ded16Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt7.Top = 5.3175F;
			this.Ded16Amt7.Width = 0.625F;
			// 
			// Paymnt16Amt8
			// 
			this.Paymnt16Amt8.DataField = "PAYMNT_16AMT8";
			this.Paymnt16Amt8.Height = 0.143F;
			this.Paymnt16Amt8.Left = 0.625F;
			this.Paymnt16Amt8.Name = "Paymnt16Amt8";
			this.Paymnt16Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt8.Top = 5.1745F;
			this.Paymnt16Amt8.Width = 0.625F;
			// 
			// Ded16Amt8
			// 
			this.Ded16Amt8.DataField = "DED_16AMT8";
			this.Ded16Amt8.Height = 0.143F;
			this.Ded16Amt8.Left = 0.625F;
			this.Ded16Amt8.Name = "Ded16Amt8";
			this.Ded16Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt8.Top = 5.3175F;
			this.Ded16Amt8.Width = 0.625F;
			// 
			// Paymnt16Amt9
			// 
			this.Paymnt16Amt9.DataField = "PAYMNT_16AMT9";
			this.Paymnt16Amt9.Height = 0.143F;
			this.Paymnt16Amt9.Left = 1.251F;
			this.Paymnt16Amt9.Name = "Paymnt16Amt9";
			this.Paymnt16Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt9.Top = 5.1745F;
			this.Paymnt16Amt9.Width = 0.625F;
			// 
			// Ded16Amt9
			// 
			this.Ded16Amt9.DataField = "DED_16AMT9";
			this.Ded16Amt9.Height = 0.143F;
			this.Ded16Amt9.Left = 1.251F;
			this.Ded16Amt9.Name = "Ded16Amt9";
			this.Ded16Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt9.Top = 5.3175F;
			this.Ded16Amt9.Width = 0.625F;
			// 
			// Paymnt16Amt10
			// 
			this.Paymnt16Amt10.DataField = "PAYMNT_16AMT10";
			this.Paymnt16Amt10.Height = 0.143F;
			this.Paymnt16Amt10.Left = 1.875F;
			this.Paymnt16Amt10.Name = "Paymnt16Amt10";
			this.Paymnt16Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt10.Top = 5.1745F;
			this.Paymnt16Amt10.Width = 0.625F;
			// 
			// Ded16Amt10
			// 
			this.Ded16Amt10.DataField = "DED_16AMT10";
			this.Ded16Amt10.Height = 0.143F;
			this.Ded16Amt10.Left = 1.875F;
			this.Ded16Amt10.Name = "Ded16Amt10";
			this.Ded16Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt10.Top = 5.3175F;
			this.Ded16Amt10.Width = 0.625F;
			// 
			// Paymnt16Amt11
			// 
			this.Paymnt16Amt11.DataField = "PAYMNT_16AMT11";
			this.Paymnt16Amt11.Height = 0.143F;
			this.Paymnt16Amt11.Left = 2.501F;
			this.Paymnt16Amt11.Name = "Paymnt16Amt11";
			this.Paymnt16Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt11.Top = 5.1745F;
			this.Paymnt16Amt11.Width = 0.625F;
			// 
			// Ded16Amt11
			// 
			this.Ded16Amt11.DataField = "DED_16AMT11";
			this.Ded16Amt11.Height = 0.143F;
			this.Ded16Amt11.Left = 2.5F;
			this.Ded16Amt11.Name = "Ded16Amt11";
			this.Ded16Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt11.Top = 5.3175F;
			this.Ded16Amt11.Width = 0.625F;
			// 
			// Paymnt16Amt12
			// 
			this.Paymnt16Amt12.DataField = "PAYMNT_16AMT12";
			this.Paymnt16Amt12.Height = 0.143F;
			this.Paymnt16Amt12.Left = 3.125F;
			this.Paymnt16Amt12.Name = "Paymnt16Amt12";
			this.Paymnt16Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt12.Top = 5.1745F;
			this.Paymnt16Amt12.Width = 0.625F;
			// 
			// Ded16Amt12
			// 
			this.Ded16Amt12.DataField = "DED_16AMT12";
			this.Ded16Amt12.Height = 0.143F;
			this.Ded16Amt12.Left = 3.125F;
			this.Ded16Amt12.Name = "Ded16Amt12";
			this.Ded16Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt12.Top = 5.3175F;
			this.Ded16Amt12.Width = 0.625F;
			// 
			// Line380
			// 
			this.Line380.Height = 0F;
			this.Line380.Left = 0.0004997253F;
			this.Line380.LineWeight = 1F;
			this.Line380.Name = "Line380";
			this.Line380.Top = 5.4605F;
			this.Line380.Width = 3.7505F;
			this.Line380.X1 = 0.0004997253F;
			this.Line380.X2 = 3.751F;
			this.Line380.Y1 = 5.4605F;
			this.Line380.Y2 = 5.4605F;
			// 
			// Line381
			// 
			this.Line381.Height = 0F;
			this.Line381.Left = 0.0004997253F;
			this.Line381.LineWeight = 1F;
			this.Line381.Name = "Line381";
			this.Line381.Top = 5.6035F;
			this.Line381.Width = 3.7505F;
			this.Line381.X1 = 0.0004997253F;
			this.Line381.X2 = 3.751F;
			this.Line381.Y1 = 5.6035F;
			this.Line381.Y2 = 5.6035F;
			// 
			// PaymntTotal2Amt7
			// 
			this.PaymntTotal2Amt7.Height = 0.143F;
			this.PaymntTotal2Amt7.Left = 0F;
			this.PaymntTotal2Amt7.Name = "PaymntTotal2Amt7";
			this.PaymntTotal2Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt7.Top = 5.4605F;
			this.PaymntTotal2Amt7.Width = 0.625F;
			// 
			// DedTotal2Amt7
			// 
			this.DedTotal2Amt7.Height = 0.143F;
			this.DedTotal2Amt7.Left = 0F;
			this.DedTotal2Amt7.Name = "DedTotal2Amt7";
			this.DedTotal2Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt7.Top = 5.6035F;
			this.DedTotal2Amt7.Width = 0.625F;
			// 
			// PaymntTotal2Amt8
			// 
			this.PaymntTotal2Amt8.Height = 0.143F;
			this.PaymntTotal2Amt8.Left = 0.625F;
			this.PaymntTotal2Amt8.Name = "PaymntTotal2Amt8";
			this.PaymntTotal2Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt8.Top = 5.4605F;
			this.PaymntTotal2Amt8.Width = 0.625F;
			// 
			// DedTotal2Amt8
			// 
			this.DedTotal2Amt8.Height = 0.143F;
			this.DedTotal2Amt8.Left = 0.625F;
			this.DedTotal2Amt8.Name = "DedTotal2Amt8";
			this.DedTotal2Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt8.Top = 5.6035F;
			this.DedTotal2Amt8.Width = 0.625F;
			// 
			// PaymntTotal2Amt9
			// 
			this.PaymntTotal2Amt9.Height = 0.143F;
			this.PaymntTotal2Amt9.Left = 1.251F;
			this.PaymntTotal2Amt9.Name = "PaymntTotal2Amt9";
			this.PaymntTotal2Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt9.Top = 5.4605F;
			this.PaymntTotal2Amt9.Width = 0.625F;
			// 
			// DedTotal2Amt9
			// 
			this.DedTotal2Amt9.Height = 0.143F;
			this.DedTotal2Amt9.Left = 1.251F;
			this.DedTotal2Amt9.Name = "DedTotal2Amt9";
			this.DedTotal2Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt9.Top = 5.6035F;
			this.DedTotal2Amt9.Width = 0.625F;
			// 
			// PaymntTotal2Amt10
			// 
			this.PaymntTotal2Amt10.Height = 0.143F;
			this.PaymntTotal2Amt10.Left = 1.875F;
			this.PaymntTotal2Amt10.Name = "PaymntTotal2Amt10";
			this.PaymntTotal2Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt10.Top = 5.4605F;
			this.PaymntTotal2Amt10.Width = 0.625F;
			// 
			// DedTotal2Amt10
			// 
			this.DedTotal2Amt10.Height = 0.143F;
			this.DedTotal2Amt10.Left = 1.875F;
			this.DedTotal2Amt10.Name = "DedTotal2Amt10";
			this.DedTotal2Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt10.Top = 5.6035F;
			this.DedTotal2Amt10.Width = 0.625F;
			// 
			// PaymntTotal2Amt11
			// 
			this.PaymntTotal2Amt11.Height = 0.143F;
			this.PaymntTotal2Amt11.Left = 2.501F;
			this.PaymntTotal2Amt11.Name = "PaymntTotal2Amt11";
			this.PaymntTotal2Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt11.Top = 5.4605F;
			this.PaymntTotal2Amt11.Width = 0.625F;
			// 
			// DedTotal2Amt11
			// 
			this.DedTotal2Amt11.Height = 0.143F;
			this.DedTotal2Amt11.Left = 2.5F;
			this.DedTotal2Amt11.Name = "DedTotal2Amt11";
			this.DedTotal2Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt11.Top = 5.6035F;
			this.DedTotal2Amt11.Width = 0.625F;
			// 
			// PaymntTotal2Amt12
			// 
			this.PaymntTotal2Amt12.Height = 0.143F;
			this.PaymntTotal2Amt12.Left = 3.125F;
			this.PaymntTotal2Amt12.Name = "PaymntTotal2Amt12";
			this.PaymntTotal2Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt12.Top = 5.4605F;
			this.PaymntTotal2Amt12.Width = 0.625F;
			// 
			// DedTotal2Amt12
			// 
			this.DedTotal2Amt12.Height = 0.143F;
			this.DedTotal2Amt12.Left = 3.125F;
			this.DedTotal2Amt12.Name = "DedTotal2Amt12";
			this.DedTotal2Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt12.Top = 5.6035F;
			this.DedTotal2Amt12.Width = 0.625F;
			// 
			// Line382
			// 
			this.Line382.Height = 0F;
			this.Line382.Left = 0.0004997253F;
			this.Line382.LineWeight = 1F;
			this.Line382.Name = "Line382";
			this.Line382.Top = 5.7465F;
			this.Line382.Width = 3.7505F;
			this.Line382.X1 = 0.0004997253F;
			this.Line382.X2 = 3.751F;
			this.Line382.Y1 = 5.7465F;
			this.Line382.Y2 = 5.7465F;
			// 
			// Line383
			// 
			this.Line383.Height = 0F;
			this.Line383.Left = 0.0004997253F;
			this.Line383.LineWeight = 1F;
			this.Line383.Name = "Line383";
			this.Line383.Top = 5.8895F;
			this.Line383.Width = 3.7505F;
			this.Line383.X1 = 0.0004997253F;
			this.Line383.X2 = 3.751F;
			this.Line383.Y1 = 5.8895F;
			this.Line383.Y2 = 5.8895F;
			// 
			// Paymnt17Amt7
			// 
			this.Paymnt17Amt7.DataField = "PAYMNT_17AMT7";
			this.Paymnt17Amt7.Height = 0.143F;
			this.Paymnt17Amt7.Left = 0F;
			this.Paymnt17Amt7.Name = "Paymnt17Amt7";
			this.Paymnt17Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt7.Top = 5.7465F;
			this.Paymnt17Amt7.Width = 0.625F;
			// 
			// Ded17Amt7
			// 
			this.Ded17Amt7.DataField = "DED_17AMT7";
			this.Ded17Amt7.Height = 0.143F;
			this.Ded17Amt7.Left = 0F;
			this.Ded17Amt7.Name = "Ded17Amt7";
			this.Ded17Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt7.Top = 5.8895F;
			this.Ded17Amt7.Width = 0.625F;
			// 
			// Paymnt17Amt8
			// 
			this.Paymnt17Amt8.DataField = "PAYMNT_17AMT8";
			this.Paymnt17Amt8.Height = 0.143F;
			this.Paymnt17Amt8.Left = 0.625F;
			this.Paymnt17Amt8.Name = "Paymnt17Amt8";
			this.Paymnt17Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt8.Top = 5.7465F;
			this.Paymnt17Amt8.Width = 0.625F;
			// 
			// Ded17Amt8
			// 
			this.Ded17Amt8.DataField = "DED_17AMT8";
			this.Ded17Amt8.Height = 0.143F;
			this.Ded17Amt8.Left = 0.625F;
			this.Ded17Amt8.Name = "Ded17Amt8";
			this.Ded17Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt8.Top = 5.8895F;
			this.Ded17Amt8.Width = 0.625F;
			// 
			// Paymnt17Amt9
			// 
			this.Paymnt17Amt9.DataField = "PAYMNT_17AMT9";
			this.Paymnt17Amt9.Height = 0.143F;
			this.Paymnt17Amt9.Left = 1.251F;
			this.Paymnt17Amt9.Name = "Paymnt17Amt9";
			this.Paymnt17Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt9.Top = 5.7465F;
			this.Paymnt17Amt9.Width = 0.625F;
			// 
			// Ded17Amt9
			// 
			this.Ded17Amt9.DataField = "DED_17AMT9";
			this.Ded17Amt9.Height = 0.143F;
			this.Ded17Amt9.Left = 1.251F;
			this.Ded17Amt9.Name = "Ded17Amt9";
			this.Ded17Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt9.Top = 5.8895F;
			this.Ded17Amt9.Width = 0.625F;
			// 
			// Paymnt17Amt10
			// 
			this.Paymnt17Amt10.DataField = "PAYMNT_17AMT10";
			this.Paymnt17Amt10.Height = 0.143F;
			this.Paymnt17Amt10.Left = 1.875F;
			this.Paymnt17Amt10.Name = "Paymnt17Amt10";
			this.Paymnt17Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt10.Top = 5.7465F;
			this.Paymnt17Amt10.Width = 0.625F;
			// 
			// Ded17Amt10
			// 
			this.Ded17Amt10.DataField = "DED_17AMT10";
			this.Ded17Amt10.Height = 0.143F;
			this.Ded17Amt10.Left = 1.875F;
			this.Ded17Amt10.Name = "Ded17Amt10";
			this.Ded17Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt10.Top = 5.8895F;
			this.Ded17Amt10.Width = 0.625F;
			// 
			// Paymnt17Amt11
			// 
			this.Paymnt17Amt11.DataField = "PAYMNT_17AMT11";
			this.Paymnt17Amt11.Height = 0.143F;
			this.Paymnt17Amt11.Left = 2.501F;
			this.Paymnt17Amt11.Name = "Paymnt17Amt11";
			this.Paymnt17Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt11.Top = 5.7465F;
			this.Paymnt17Amt11.Width = 0.625F;
			// 
			// Ded17Amt11
			// 
			this.Ded17Amt11.DataField = "DED_17AMT11";
			this.Ded17Amt11.Height = 0.143F;
			this.Ded17Amt11.Left = 2.501F;
			this.Ded17Amt11.Name = "Ded17Amt11";
			this.Ded17Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt11.Top = 5.8895F;
			this.Ded17Amt11.Width = 0.625F;
			// 
			// Paymnt17Amt12
			// 
			this.Paymnt17Amt12.DataField = "PAYMNT_17AMT12";
			this.Paymnt17Amt12.Height = 0.143F;
			this.Paymnt17Amt12.Left = 3.125F;
			this.Paymnt17Amt12.Name = "Paymnt17Amt12";
			this.Paymnt17Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt12.Top = 5.7465F;
			this.Paymnt17Amt12.Width = 0.625F;
			// 
			// Ded17Amt12
			// 
			this.Ded17Amt12.DataField = "DED_17AMT12";
			this.Ded17Amt12.Height = 0.143F;
			this.Ded17Amt12.Left = 3.125F;
			this.Ded17Amt12.Name = "Ded17Amt12";
			this.Ded17Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt12.Top = 5.8895F;
			this.Ded17Amt12.Width = 0.625F;
			// 
			// Line384
			// 
			this.Line384.Height = 0F;
			this.Line384.Left = 0.0004997253F;
			this.Line384.LineWeight = 1F;
			this.Line384.Name = "Line384";
			this.Line384.Top = 6.0325F;
			this.Line384.Width = 3.7505F;
			this.Line384.X1 = 0.0004997253F;
			this.Line384.X2 = 3.751F;
			this.Line384.Y1 = 6.0325F;
			this.Line384.Y2 = 6.0325F;
			// 
			// Line385
			// 
			this.Line385.Height = 0F;
			this.Line385.Left = 0.0004997253F;
			this.Line385.LineWeight = 1F;
			this.Line385.Name = "Line385";
			this.Line385.Top = 6.1755F;
			this.Line385.Width = 3.7505F;
			this.Line385.X1 = 0.0004997253F;
			this.Line385.X2 = 3.751F;
			this.Line385.Y1 = 6.1755F;
			this.Line385.Y2 = 6.1755F;
			// 
			// PaymntTotal3Amt7
			// 
			this.PaymntTotal3Amt7.Height = 0.143F;
			this.PaymntTotal3Amt7.Left = 0F;
			this.PaymntTotal3Amt7.Name = "PaymntTotal3Amt7";
			this.PaymntTotal3Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt7.Top = 6.0325F;
			this.PaymntTotal3Amt7.Width = 0.625F;
			// 
			// DedTotal3Amt7
			// 
			this.DedTotal3Amt7.Height = 0.143F;
			this.DedTotal3Amt7.Left = 0F;
			this.DedTotal3Amt7.Name = "DedTotal3Amt7";
			this.DedTotal3Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt7.Top = 6.1755F;
			this.DedTotal3Amt7.Width = 0.625F;
			// 
			// PaymntTotal3Amt8
			// 
			this.PaymntTotal3Amt8.Height = 0.143F;
			this.PaymntTotal3Amt8.Left = 0.625F;
			this.PaymntTotal3Amt8.Name = "PaymntTotal3Amt8";
			this.PaymntTotal3Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt8.Top = 6.0325F;
			this.PaymntTotal3Amt8.Width = 0.625F;
			// 
			// DedTotal3Amt8
			// 
			this.DedTotal3Amt8.Height = 0.143F;
			this.DedTotal3Amt8.Left = 0.625F;
			this.DedTotal3Amt8.Name = "DedTotal3Amt8";
			this.DedTotal3Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt8.Top = 6.1755F;
			this.DedTotal3Amt8.Width = 0.625F;
			// 
			// PaymntTotal3Amt9
			// 
			this.PaymntTotal3Amt9.Height = 0.143F;
			this.PaymntTotal3Amt9.Left = 1.251F;
			this.PaymntTotal3Amt9.Name = "PaymntTotal3Amt9";
			this.PaymntTotal3Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt9.Top = 6.0325F;
			this.PaymntTotal3Amt9.Width = 0.625F;
			// 
			// DedTotal3Amt9
			// 
			this.DedTotal3Amt9.Height = 0.143F;
			this.DedTotal3Amt9.Left = 1.251F;
			this.DedTotal3Amt9.Name = "DedTotal3Amt9";
			this.DedTotal3Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt9.Top = 6.1755F;
			this.DedTotal3Amt9.Width = 0.625F;
			// 
			// PaymntTotal3Amt10
			// 
			this.PaymntTotal3Amt10.Height = 0.143F;
			this.PaymntTotal3Amt10.Left = 1.875F;
			this.PaymntTotal3Amt10.Name = "PaymntTotal3Amt10";
			this.PaymntTotal3Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt10.Top = 6.0325F;
			this.PaymntTotal3Amt10.Width = 0.625F;
			// 
			// DedTotal3Amt10
			// 
			this.DedTotal3Amt10.Height = 0.143F;
			this.DedTotal3Amt10.Left = 1.875F;
			this.DedTotal3Amt10.Name = "DedTotal3Amt10";
			this.DedTotal3Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt10.Top = 6.1755F;
			this.DedTotal3Amt10.Width = 0.625F;
			// 
			// PaymntTotal3Amt11
			// 
			this.PaymntTotal3Amt11.Height = 0.143F;
			this.PaymntTotal3Amt11.Left = 2.501F;
			this.PaymntTotal3Amt11.Name = "PaymntTotal3Amt11";
			this.PaymntTotal3Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt11.Top = 6.0325F;
			this.PaymntTotal3Amt11.Width = 0.625F;
			// 
			// DedTotal3Amt11
			// 
			this.DedTotal3Amt11.Height = 0.143F;
			this.DedTotal3Amt11.Left = 2.5F;
			this.DedTotal3Amt11.Name = "DedTotal3Amt11";
			this.DedTotal3Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt11.Top = 6.1755F;
			this.DedTotal3Amt11.Width = 0.625F;
			// 
			// PaymntTotal3Amt12
			// 
			this.PaymntTotal3Amt12.Height = 0.143F;
			this.PaymntTotal3Amt12.Left = 3.125F;
			this.PaymntTotal3Amt12.Name = "PaymntTotal3Amt12";
			this.PaymntTotal3Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt12.Top = 6.0325F;
			this.PaymntTotal3Amt12.Width = 0.625F;
			// 
			// DedTotal3Amt12
			// 
			this.DedTotal3Amt12.Height = 0.143F;
			this.DedTotal3Amt12.Left = 3.125F;
			this.DedTotal3Amt12.Name = "DedTotal3Amt12";
			this.DedTotal3Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt12.Top = 6.1755F;
			this.DedTotal3Amt12.Width = 0.625F;
			// 
			// Line386
			// 
			this.Line386.Height = 0F;
			this.Line386.Left = 0.0004997253F;
			this.Line386.LineWeight = 1F;
			this.Line386.Name = "Line386";
			this.Line386.Top = 6.318499F;
			this.Line386.Width = 3.7505F;
			this.Line386.X1 = 0.0004997253F;
			this.Line386.X2 = 3.751F;
			this.Line386.Y1 = 6.318499F;
			this.Line386.Y2 = 6.318499F;
			// 
			// Label98
			// 
			this.Label98.Height = 0.143F;
			this.Label98.HyperLink = null;
			this.Label98.Left = 0F;
			this.Label98.Name = "Label98";
			this.Label98.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label98.Text = "社会保険控除";
			this.Label98.Top = 6.318499F;
			this.Label98.Width = 0.625F;
			// 
			// Label99
			// 
			this.Label99.Height = 0.143F;
			this.Label99.HyperLink = null;
			this.Label99.Left = 0.625F;
			this.Label99.Name = "Label99";
			this.Label99.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label99.Text = "社会保険申告";
			this.Label99.Top = 6.318499F;
			this.Label99.Width = 0.625F;
			// 
			// Label100
			// 
			this.Label100.Height = 0.143F;
			this.Label100.HyperLink = null;
			this.Label100.Left = 1.25F;
			this.Label100.Name = "Label100";
			this.Label100.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label100.Text = "小企業共済";
			this.Label100.Top = 6.318499F;
			this.Label100.Width = 0.625F;
			// 
			// Label101
			// 
			this.Label101.Height = 0.143F;
			this.Label101.HyperLink = null;
			this.Label101.Left = 1.875F;
			this.Label101.Name = "Label101";
			this.Label101.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label101.Text = "生命保険控除";
			this.Label101.Top = 6.318499F;
			this.Label101.Width = 0.625F;
			// 
			// Label102
			// 
			this.Label102.Height = 0.143F;
			this.Label102.HyperLink = null;
			this.Label102.Left = 2.5F;
			this.Label102.Name = "Label102";
			this.Label102.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label102.Text = "介護医療控除";
			this.Label102.Top = 6.318499F;
			this.Label102.Width = 0.625F;
			// 
			// Line387
			// 
			this.Line387.Height = 0F;
			this.Line387.Left = 0.0004997253F;
			this.Line387.LineWeight = 1F;
			this.Line387.Name = "Line387";
			this.Line387.Top = 6.4615F;
			this.Line387.Width = 3.7505F;
			this.Line387.X1 = 0.0004997253F;
			this.Line387.X2 = 3.751F;
			this.Line387.Y1 = 6.4615F;
			this.Line387.Y2 = 6.4615F;
			// 
			// Paymnt18Amt7
			// 
			this.Paymnt18Amt7.DataField = "PAYMNT_18AMT7";
			this.Paymnt18Amt7.Height = 0.143F;
			this.Paymnt18Amt7.Left = 0F;
			this.Paymnt18Amt7.Name = "Paymnt18Amt7";
			this.Paymnt18Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt7.Top = 6.4615F;
			this.Paymnt18Amt7.Width = 0.625F;
			// 
			// Paymnt18Amt8
			// 
			this.Paymnt18Amt8.DataField = "PAYMNT_18AMT8";
			this.Paymnt18Amt8.Height = 0.143F;
			this.Paymnt18Amt8.Left = 0.625F;
			this.Paymnt18Amt8.Name = "Paymnt18Amt8";
			this.Paymnt18Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt8.Top = 6.4615F;
			this.Paymnt18Amt8.Width = 0.625F;
			// 
			// Paymnt18Amt9
			// 
			this.Paymnt18Amt9.DataField = "PAYMNT_18AMT9";
			this.Paymnt18Amt9.Height = 0.143F;
			this.Paymnt18Amt9.Left = 1.251F;
			this.Paymnt18Amt9.Name = "Paymnt18Amt9";
			this.Paymnt18Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt9.Top = 6.4615F;
			this.Paymnt18Amt9.Width = 0.625F;
			// 
			// Paymnt18Amt10
			// 
			this.Paymnt18Amt10.DataField = "PAYMNT_18AMT10";
			this.Paymnt18Amt10.Height = 0.143F;
			this.Paymnt18Amt10.Left = 1.875F;
			this.Paymnt18Amt10.Name = "Paymnt18Amt10";
			this.Paymnt18Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt10.Top = 6.4615F;
			this.Paymnt18Amt10.Width = 0.625F;
			// 
			// Paymnt18Amt11
			// 
			this.Paymnt18Amt11.DataField = "PAYMNT_18AMT11";
			this.Paymnt18Amt11.Height = 0.143F;
			this.Paymnt18Amt11.Left = 2.5F;
			this.Paymnt18Amt11.Name = "Paymnt18Amt11";
			this.Paymnt18Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt11.Top = 6.4615F;
			this.Paymnt18Amt11.Width = 0.625F;
			// 
			// Paymnt18Amt12
			// 
			this.Paymnt18Amt12.DataField = "PAYMNT_18AMT12";
			this.Paymnt18Amt12.Height = 0.143F;
			this.Paymnt18Amt12.Left = 3.125F;
			this.Paymnt18Amt12.Name = "Paymnt18Amt12";
			this.Paymnt18Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt12.Top = 6.4615F;
			this.Paymnt18Amt12.Width = 0.625F;
			// 
			// Line388
			// 
			this.Line388.Height = 0F;
			this.Line388.Left = 0.0004997253F;
			this.Line388.LineWeight = 1F;
			this.Line388.Name = "Line388";
			this.Line388.Top = 6.6045F;
			this.Line388.Width = 3.7505F;
			this.Line388.X1 = 0.0004997253F;
			this.Line388.X2 = 3.751F;
			this.Line388.Y1 = 6.6045F;
			this.Line388.Y2 = 6.6045F;
			// 
			// Line389
			// 
			this.Line389.Height = 0F;
			this.Line389.Left = 0.0004997253F;
			this.Line389.LineWeight = 1F;
			this.Line389.Name = "Line389";
			this.Line389.Top = 6.6045F;
			this.Line389.Width = 3.7505F;
			this.Line389.X1 = 0.0004997253F;
			this.Line389.X2 = 3.751F;
			this.Line389.Y1 = 6.6045F;
			this.Line389.Y2 = 6.6045F;
			// 
			// Line390
			// 
			this.Line390.Height = 0F;
			this.Line390.Left = 0.0004997253F;
			this.Line390.LineWeight = 1F;
			this.Line390.Name = "Line390";
			this.Line390.Top = 6.7475F;
			this.Line390.Width = 3.7505F;
			this.Line390.X1 = 0.0004997253F;
			this.Line390.X2 = 3.751F;
			this.Line390.Y1 = 6.7475F;
			this.Line390.Y2 = 6.7475F;
			// 
			// Label109
			// 
			this.Label109.Height = 0.143F;
			this.Label109.HyperLink = null;
			this.Label109.Left = 0.0004997253F;
			this.Label109.Name = "Label109";
			this.Label109.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label109.Text = "年税額";
			this.Label109.Top = 6.605F;
			this.Label109.Width = 0.625F;
			// 
			// Label111
			// 
			this.Label111.DataField = "FX_TAX_SUB_TAX_TITLE";
			this.Label111.Height = 0.143F;
			this.Label111.HyperLink = null;
			this.Label111.Left = 1.25F;
			this.Label111.Name = "Label111";
			this.Label111.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label111.Text = "年調定率控除";
			this.Label111.Top = 6.6045F;
			this.Label111.Width = 0.625F;
			// 
			// Label112
			// 
			this.Label112.Height = 0.143F;
			this.Label112.HyperLink = null;
			this.Label112.Left = 1.875F;
			this.Label112.Name = "Label112";
			this.Label112.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label112.Text = "差引年税額";
			this.Label112.Top = 6.6045F;
			this.Label112.Width = 0.625F;
			// 
			// Label113
			// 
			this.Label113.Height = 0.143F;
			this.Label113.HyperLink = null;
			this.Label113.Left = 2.5F;
			this.Label113.Name = "Label113";
			this.Label113.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label113.Text = "徴収税額";
			this.Label113.Top = 6.6045F;
			this.Label113.Width = 0.625F;
			// 
			// Ded18Amt7
			// 
			this.Ded18Amt7.DataField = "DED_18AMT7";
			this.Ded18Amt7.Height = 0.143F;
			this.Ded18Amt7.Left = 0.0004997253F;
			this.Ded18Amt7.Name = "Ded18Amt7";
			this.Ded18Amt7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt7.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt7.Top = 6.748F;
			this.Ded18Amt7.Width = 0.625F;
			// 
			// Ded18Amt8
			// 
			this.Ded18Amt8.DataField = "DED_18AMT8";
			this.Ded18Amt8.Height = 0.143F;
			this.Ded18Amt8.Left = 0.6254997F;
			this.Ded18Amt8.Name = "Ded18Amt8";
			this.Ded18Amt8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded18Amt8.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt8.Top = 6.748F;
			this.Ded18Amt8.Width = 0.625F;
			// 
			// Ded18Amt9
			// 
			this.Ded18Amt9.DataField = "DED_18AMT9";
			this.Ded18Amt9.Height = 0.143F;
			this.Ded18Amt9.Left = 1.251F;
			this.Ded18Amt9.Name = "Ded18Amt9";
			this.Ded18Amt9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt9.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt9.Top = 6.7475F;
			this.Ded18Amt9.Width = 0.625F;
			// 
			// Ded18Amt10
			// 
			this.Ded18Amt10.DataField = "DED_18AMT10";
			this.Ded18Amt10.Height = 0.143F;
			this.Ded18Amt10.Left = 1.875F;
			this.Ded18Amt10.Name = "Ded18Amt10";
			this.Ded18Amt10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt10.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt10.Top = 6.7475F;
			this.Ded18Amt10.Width = 0.625F;
			// 
			// Ded18Amt11
			// 
			this.Ded18Amt11.DataField = "DED_18AMT11";
			this.Ded18Amt11.Height = 0.143F;
			this.Ded18Amt11.Left = 2.5F;
			this.Ded18Amt11.Name = "Ded18Amt11";
			this.Ded18Amt11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt11.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt11.Top = 6.7475F;
			this.Ded18Amt11.Width = 0.625F;
			// 
			// Ded18Amt12
			// 
			this.Ded18Amt12.DataField = "DED_18AMT12";
			this.Ded18Amt12.Height = 0.143F;
			this.Ded18Amt12.Left = 3.125F;
			this.Ded18Amt12.Name = "Ded18Amt12";
			this.Ded18Amt12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt12.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt12.Top = 6.7475F;
			this.Ded18Amt12.Width = 0.625F;
			// 
			// Title
			// 
			this.Title.Height = 0.143F;
			this.Title.HyperLink = null;
			this.Title.Left = 0.6254997F;
			this.Title.Name = "Title";
			this.Title.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Title.Text = "住宅取得控除";
			this.Title.Top = 6.605F;
			this.Title.Width = 0.625F;
			// 
			// Line391
			// 
			this.Line391.Height = 0F;
			this.Line391.Left = 0.0004997253F;
			this.Line391.LineWeight = 1F;
			this.Line391.Name = "Line391";
			this.Line391.Top = 6.8905F;
			this.Line391.Width = 3.7495F;
			this.Line391.X1 = 0.0004997253F;
			this.Line391.X2 = 3.75F;
			this.Line391.Y1 = 6.8905F;
			this.Line391.Y2 = 6.8905F;
			// 
			// Line405
			// 
			this.Line405.Height = 0F;
			this.Line405.Left = 0.0004997253F;
			this.Line405.LineWeight = 1F;
			this.Line405.Name = "Line405";
			this.Line405.Top = 4.7455F;
			this.Line405.Width = 3.7505F;
			this.Line405.X1 = 0.0004997253F;
			this.Line405.X2 = 3.751F;
			this.Line405.Y1 = 4.7455F;
			this.Line405.Y2 = 4.7455F;
			// 
			// PaymntZeroFlg7
			// 
			this.PaymntZeroFlg7.DataField = "PAYMNT_ZERO_FLG7";
			this.PaymntZeroFlg7.Height = 0.143F;
			this.PaymntZeroFlg7.Left = 0F;
			this.PaymntZeroFlg7.Name = "PaymntZeroFlg7";
			this.PaymntZeroFlg7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg7.Text = null;
			this.PaymntZeroFlg7.Top = 0.2860001F;
			this.PaymntZeroFlg7.Visible = false;
			this.PaymntZeroFlg7.Width = 0.625F;
			// 
			// PaymntZeroFlg8
			// 
			this.PaymntZeroFlg8.DataField = "PAYMNT_ZERO_FLG8";
			this.PaymntZeroFlg8.Height = 0.143F;
			this.PaymntZeroFlg8.Left = 0.625F;
			this.PaymntZeroFlg8.Name = "PaymntZeroFlg8";
			this.PaymntZeroFlg8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg8.Text = null;
			this.PaymntZeroFlg8.Top = 0.2860001F;
			this.PaymntZeroFlg8.Visible = false;
			this.PaymntZeroFlg8.Width = 0.625F;
			// 
			// PaymntZeroFlg9
			// 
			this.PaymntZeroFlg9.DataField = "PAYMNT_ZERO_FLG9";
			this.PaymntZeroFlg9.Height = 0.143F;
			this.PaymntZeroFlg9.Left = 1.25F;
			this.PaymntZeroFlg9.Name = "PaymntZeroFlg9";
			this.PaymntZeroFlg9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg9.Text = null;
			this.PaymntZeroFlg9.Top = 0.2860001F;
			this.PaymntZeroFlg9.Visible = false;
			this.PaymntZeroFlg9.Width = 0.625F;
			// 
			// PaymntZeroFlg10
			// 
			this.PaymntZeroFlg10.DataField = "PAYMNT_ZERO_FLG10";
			this.PaymntZeroFlg10.Height = 0.143F;
			this.PaymntZeroFlg10.Left = 1.875F;
			this.PaymntZeroFlg10.Name = "PaymntZeroFlg10";
			this.PaymntZeroFlg10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg10.Text = null;
			this.PaymntZeroFlg10.Top = 0.2860001F;
			this.PaymntZeroFlg10.Visible = false;
			this.PaymntZeroFlg10.Width = 0.625F;
			// 
			// PaymntZeroFlg11
			// 
			this.PaymntZeroFlg11.DataField = "PAYMNT_ZERO_FLG11";
			this.PaymntZeroFlg11.Height = 0.143F;
			this.PaymntZeroFlg11.Left = 2.5F;
			this.PaymntZeroFlg11.Name = "PaymntZeroFlg11";
			this.PaymntZeroFlg11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg11.Text = null;
			this.PaymntZeroFlg11.Top = 0.2860001F;
			this.PaymntZeroFlg11.Visible = false;
			this.PaymntZeroFlg11.Width = 0.625F;
			// 
			// PaymntZeroFlg12
			// 
			this.PaymntZeroFlg12.DataField = "PAYMNT_ZERO_FLG12";
			this.PaymntZeroFlg12.Height = 0.143F;
			this.PaymntZeroFlg12.Left = 3.125F;
			this.PaymntZeroFlg12.Name = "PaymntZeroFlg12";
			this.PaymntZeroFlg12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg12.Text = null;
			this.PaymntZeroFlg12.Top = 0.2860001F;
			this.PaymntZeroFlg12.Visible = false;
			this.PaymntZeroFlg12.Width = 0.625F;
			// 
			// DedZeroFlg7
			// 
			this.DedZeroFlg7.DataField = "DED_ZERO_FLG7";
			this.DedZeroFlg7.Height = 0.143F;
			this.DedZeroFlg7.Left = 0F;
			this.DedZeroFlg7.Name = "DedZeroFlg7";
			this.DedZeroFlg7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg7.Text = null;
			this.DedZeroFlg7.Top = 0.429F;
			this.DedZeroFlg7.Visible = false;
			this.DedZeroFlg7.Width = 0.625F;
			// 
			// DedZeroFlg8
			// 
			this.DedZeroFlg8.DataField = "DED_ZERO_FLG8";
			this.DedZeroFlg8.Height = 0.143F;
			this.DedZeroFlg8.Left = 0.625F;
			this.DedZeroFlg8.Name = "DedZeroFlg8";
			this.DedZeroFlg8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg8.Text = null;
			this.DedZeroFlg8.Top = 0.429F;
			this.DedZeroFlg8.Visible = false;
			this.DedZeroFlg8.Width = 0.625F;
			// 
			// DedZeroFlg9
			// 
			this.DedZeroFlg9.DataField = "DED_ZERO_FLG9";
			this.DedZeroFlg9.Height = 0.143F;
			this.DedZeroFlg9.Left = 1.25F;
			this.DedZeroFlg9.Name = "DedZeroFlg9";
			this.DedZeroFlg9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg9.Text = null;
			this.DedZeroFlg9.Top = 0.429F;
			this.DedZeroFlg9.Visible = false;
			this.DedZeroFlg9.Width = 0.625F;
			// 
			// DedZeroFlg10
			// 
			this.DedZeroFlg10.DataField = "DED_ZERO_FLG10";
			this.DedZeroFlg10.Height = 0.143F;
			this.DedZeroFlg10.Left = 1.875F;
			this.DedZeroFlg10.Name = "DedZeroFlg10";
			this.DedZeroFlg10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg10.Text = null;
			this.DedZeroFlg10.Top = 0.429F;
			this.DedZeroFlg10.Visible = false;
			this.DedZeroFlg10.Width = 0.625F;
			// 
			// DedZeroFlg11
			// 
			this.DedZeroFlg11.DataField = "DED_ZERO_FLG11";
			this.DedZeroFlg11.Height = 0.143F;
			this.DedZeroFlg11.Left = 2.5F;
			this.DedZeroFlg11.Name = "DedZeroFlg11";
			this.DedZeroFlg11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg11.Text = null;
			this.DedZeroFlg11.Top = 0.429F;
			this.DedZeroFlg11.Visible = false;
			this.DedZeroFlg11.Width = 0.625F;
			// 
			// DedZeroFlg12
			// 
			this.DedZeroFlg12.DataField = "DED_ZERO_FLG12";
			this.DedZeroFlg12.Height = 0.143F;
			this.DedZeroFlg12.Left = 3.125F;
			this.DedZeroFlg12.Name = "DedZeroFlg12";
			this.DedZeroFlg12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg12.Text = null;
			this.DedZeroFlg12.Top = 0.429F;
			this.DedZeroFlg12.Visible = false;
			this.DedZeroFlg12.Width = 0.625F;
			// 
			// PaymntItemId7
			// 
			this.PaymntItemId7.DataField = "PAYMNT_ITEM_ID7";
			this.PaymntItemId7.Height = 0.143F;
			this.PaymntItemId7.Left = 0F;
			this.PaymntItemId7.Name = "PaymntItemId7";
			this.PaymntItemId7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId7.Text = null;
			this.PaymntItemId7.Top = 0.572F;
			this.PaymntItemId7.Visible = false;
			this.PaymntItemId7.Width = 0.625F;
			// 
			// DedItemId7
			// 
			this.DedItemId7.DataField = "DED_ITEM_ID7";
			this.DedItemId7.Height = 0.143F;
			this.DedItemId7.Left = 0F;
			this.DedItemId7.Name = "DedItemId7";
			this.DedItemId7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId7.Text = null;
			this.DedItemId7.Top = 0.715F;
			this.DedItemId7.Visible = false;
			this.DedItemId7.Width = 0.625F;
			// 
			// PaymntItemId8
			// 
			this.PaymntItemId8.DataField = "PAYMNT_ITEM_ID8";
			this.PaymntItemId8.Height = 0.143F;
			this.PaymntItemId8.Left = 0.625F;
			this.PaymntItemId8.Name = "PaymntItemId8";
			this.PaymntItemId8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId8.Text = null;
			this.PaymntItemId8.Top = 0.572F;
			this.PaymntItemId8.Visible = false;
			this.PaymntItemId8.Width = 0.625F;
			// 
			// DedItemId8
			// 
			this.DedItemId8.DataField = "DED_ITEM_ID8";
			this.DedItemId8.Height = 0.143F;
			this.DedItemId8.Left = 0.625F;
			this.DedItemId8.Name = "DedItemId8";
			this.DedItemId8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId8.Text = null;
			this.DedItemId8.Top = 0.715F;
			this.DedItemId8.Visible = false;
			this.DedItemId8.Width = 0.625F;
			// 
			// PaymntItemId9
			// 
			this.PaymntItemId9.DataField = "PAYMNT_ITEM_ID9";
			this.PaymntItemId9.Height = 0.143F;
			this.PaymntItemId9.Left = 1.25F;
			this.PaymntItemId9.Name = "PaymntItemId9";
			this.PaymntItemId9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId9.Text = null;
			this.PaymntItemId9.Top = 0.572F;
			this.PaymntItemId9.Visible = false;
			this.PaymntItemId9.Width = 0.625F;
			// 
			// DedItemId9
			// 
			this.DedItemId9.DataField = "DED_ITEM_ID9";
			this.DedItemId9.Height = 0.143F;
			this.DedItemId9.Left = 1.25F;
			this.DedItemId9.Name = "DedItemId9";
			this.DedItemId9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId9.Text = null;
			this.DedItemId9.Top = 0.715F;
			this.DedItemId9.Visible = false;
			this.DedItemId9.Width = 0.625F;
			// 
			// PaymntItemId10
			// 
			this.PaymntItemId10.DataField = "PAYMNT_ITEM_ID10";
			this.PaymntItemId10.Height = 0.143F;
			this.PaymntItemId10.Left = 1.875F;
			this.PaymntItemId10.Name = "PaymntItemId10";
			this.PaymntItemId10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId10.Text = null;
			this.PaymntItemId10.Top = 0.572F;
			this.PaymntItemId10.Visible = false;
			this.PaymntItemId10.Width = 0.625F;
			// 
			// DedItemId10
			// 
			this.DedItemId10.DataField = "DED_ITEM_ID10";
			this.DedItemId10.Height = 0.143F;
			this.DedItemId10.Left = 1.875F;
			this.DedItemId10.Name = "DedItemId10";
			this.DedItemId10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId10.Text = null;
			this.DedItemId10.Top = 0.715F;
			this.DedItemId10.Visible = false;
			this.DedItemId10.Width = 0.625F;
			// 
			// PaymntItemId11
			// 
			this.PaymntItemId11.DataField = "PAYMNT_ITEM_ID11";
			this.PaymntItemId11.Height = 0.143F;
			this.PaymntItemId11.Left = 2.5F;
			this.PaymntItemId11.Name = "PaymntItemId11";
			this.PaymntItemId11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId11.Text = null;
			this.PaymntItemId11.Top = 0.572F;
			this.PaymntItemId11.Visible = false;
			this.PaymntItemId11.Width = 0.625F;
			// 
			// DedItemId11
			// 
			this.DedItemId11.DataField = "DED_ITEM_ID11";
			this.DedItemId11.Height = 0.143F;
			this.DedItemId11.Left = 2.5F;
			this.DedItemId11.Name = "DedItemId11";
			this.DedItemId11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId11.Text = null;
			this.DedItemId11.Top = 0.715F;
			this.DedItemId11.Visible = false;
			this.DedItemId11.Width = 0.625F;
			// 
			// PaymntItemId12
			// 
			this.PaymntItemId12.DataField = "PAYMNT_ITEM_ID12";
			this.PaymntItemId12.Height = 0.143F;
			this.PaymntItemId12.Left = 3.125F;
			this.PaymntItemId12.Name = "PaymntItemId12";
			this.PaymntItemId12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId12.Text = null;
			this.PaymntItemId12.Top = 0.572F;
			this.PaymntItemId12.Visible = false;
			this.PaymntItemId12.Width = 0.625F;
			// 
			// DedItemId12
			// 
			this.DedItemId12.DataField = "DED_ITEM_ID12";
			this.DedItemId12.Height = 0.143F;
			this.DedItemId12.Left = 3.125F;
			this.DedItemId12.Name = "DedItemId12";
			this.DedItemId12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId12.Text = null;
			this.DedItemId12.Top = 0.715F;
			this.DedItemId12.Visible = false;
			this.DedItemId12.Width = 0.625F;
			// 
			// PaymntDispType7
			// 
			this.PaymntDispType7.DataField = "PAYMNT_DISP_TYPE7";
			this.PaymntDispType7.Height = 0.143F;
			this.PaymntDispType7.Left = 0F;
			this.PaymntDispType7.Name = "PaymntDispType7";
			this.PaymntDispType7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType7.Text = null;
			this.PaymntDispType7.Top = 0.858F;
			this.PaymntDispType7.Visible = false;
			this.PaymntDispType7.Width = 0.625F;
			// 
			// DedDispType7
			// 
			this.DedDispType7.DataField = "DED_DISP_TYPE7";
			this.DedDispType7.Height = 0.143F;
			this.DedDispType7.Left = 0F;
			this.DedDispType7.Name = "DedDispType7";
			this.DedDispType7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType7.Text = null;
			this.DedDispType7.Top = 1.001F;
			this.DedDispType7.Visible = false;
			this.DedDispType7.Width = 0.625F;
			// 
			// PaymntDispType8
			// 
			this.PaymntDispType8.DataField = "PAYMNT_DISP_TYPE8";
			this.PaymntDispType8.Height = 0.143F;
			this.PaymntDispType8.Left = 0.625F;
			this.PaymntDispType8.Name = "PaymntDispType8";
			this.PaymntDispType8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType8.Text = null;
			this.PaymntDispType8.Top = 0.858F;
			this.PaymntDispType8.Visible = false;
			this.PaymntDispType8.Width = 0.625F;
			// 
			// DedDispType8
			// 
			this.DedDispType8.DataField = "DED_DISP_TYPE8";
			this.DedDispType8.Height = 0.143F;
			this.DedDispType8.Left = 0.625F;
			this.DedDispType8.Name = "DedDispType8";
			this.DedDispType8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType8.Text = null;
			this.DedDispType8.Top = 1.001F;
			this.DedDispType8.Visible = false;
			this.DedDispType8.Width = 0.625F;
			// 
			// PaymntDispType11
			// 
			this.PaymntDispType11.DataField = "PAYMNT_DISP_TYPE11";
			this.PaymntDispType11.Height = 0.143F;
			this.PaymntDispType11.Left = 2.5F;
			this.PaymntDispType11.Name = "PaymntDispType11";
			this.PaymntDispType11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType11.Text = null;
			this.PaymntDispType11.Top = 0.858F;
			this.PaymntDispType11.Visible = false;
			this.PaymntDispType11.Width = 0.625F;
			// 
			// DedDispType11
			// 
			this.DedDispType11.DataField = "DED_DISP_TYPE11";
			this.DedDispType11.Height = 0.143F;
			this.DedDispType11.Left = 2.5F;
			this.DedDispType11.Name = "DedDispType11";
			this.DedDispType11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType11.Text = null;
			this.DedDispType11.Top = 1.001F;
			this.DedDispType11.Visible = false;
			this.DedDispType11.Width = 0.625F;
			// 
			// PaymntDispType12
			// 
			this.PaymntDispType12.DataField = "PAYMNT_DISP_TYPE12";
			this.PaymntDispType12.Height = 0.143F;
			this.PaymntDispType12.Left = 3.125F;
			this.PaymntDispType12.Name = "PaymntDispType12";
			this.PaymntDispType12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType12.Text = null;
			this.PaymntDispType12.Top = 0.858F;
			this.PaymntDispType12.Visible = false;
			this.PaymntDispType12.Width = 0.625F;
			// 
			// DedDispType12
			// 
			this.DedDispType12.DataField = "DED_DISP_TYPE12";
			this.DedDispType12.Height = 0.143F;
			this.DedDispType12.Left = 3.125F;
			this.DedDispType12.Name = "DedDispType12";
			this.DedDispType12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType12.Text = null;
			this.DedDispType12.Top = 1.001F;
			this.DedDispType12.Visible = false;
			this.DedDispType12.Width = 0.625F;
			// 
			// PaymntDispType9
			// 
			this.PaymntDispType9.DataField = "PAYMNT_DISP_TYPE9";
			this.PaymntDispType9.Height = 0.143F;
			this.PaymntDispType9.Left = 1.25F;
			this.PaymntDispType9.Name = "PaymntDispType9";
			this.PaymntDispType9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType9.Text = null;
			this.PaymntDispType9.Top = 0.858F;
			this.PaymntDispType9.Visible = false;
			this.PaymntDispType9.Width = 0.625F;
			// 
			// PaymntDispType10
			// 
			this.PaymntDispType10.DataField = "PAYMNT_DISP_TYPE10";
			this.PaymntDispType10.Height = 0.143F;
			this.PaymntDispType10.Left = 1.875F;
			this.PaymntDispType10.Name = "PaymntDispType10";
			this.PaymntDispType10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType10.Text = null;
			this.PaymntDispType10.Top = 0.858F;
			this.PaymntDispType10.Visible = false;
			this.PaymntDispType10.Width = 0.625F;
			// 
			// DedDispType9
			// 
			this.DedDispType9.DataField = "DED_DISP_TYPE9";
			this.DedDispType9.Height = 0.143F;
			this.DedDispType9.Left = 1.25F;
			this.DedDispType9.Name = "DedDispType9";
			this.DedDispType9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType9.Text = null;
			this.DedDispType9.Top = 1.001F;
			this.DedDispType9.Visible = false;
			this.DedDispType9.Width = 0.625F;
			// 
			// DedDispType10
			// 
			this.DedDispType10.DataField = "DED_DISP_TYPE10";
			this.DedDispType10.Height = 0.143F;
			this.DedDispType10.Left = 1.875F;
			this.DedDispType10.Name = "DedDispType10";
			this.DedDispType10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType10.Text = null;
			this.DedDispType10.Top = 1.001F;
			this.DedDispType10.Visible = false;
			this.DedDispType10.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg7
			// 
			this.PaymntBnsZeroFlg7.DataField = "PAYMNT_BNS_ZERO_FLG7";
			this.PaymntBnsZeroFlg7.Height = 0.143F;
			this.PaymntBnsZeroFlg7.Left = 0F;
			this.PaymntBnsZeroFlg7.Name = "PaymntBnsZeroFlg7";
			this.PaymntBnsZeroFlg7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg7.Text = null;
			this.PaymntBnsZeroFlg7.Top = 4.339F;
			this.PaymntBnsZeroFlg7.Visible = false;
			this.PaymntBnsZeroFlg7.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg8
			// 
			this.PaymntBnsZeroFlg8.DataField = "PAYMNT_BNS_ZERO_FLG8";
			this.PaymntBnsZeroFlg8.Height = 0.143F;
			this.PaymntBnsZeroFlg8.Left = 0.625F;
			this.PaymntBnsZeroFlg8.Name = "PaymntBnsZeroFlg8";
			this.PaymntBnsZeroFlg8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg8.Text = null;
			this.PaymntBnsZeroFlg8.Top = 4.339F;
			this.PaymntBnsZeroFlg8.Visible = false;
			this.PaymntBnsZeroFlg8.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg9
			// 
			this.PaymntBnsZeroFlg9.DataField = "PAYMNT_BNS_ZERO_FLG9";
			this.PaymntBnsZeroFlg9.Height = 0.143F;
			this.PaymntBnsZeroFlg9.Left = 1.25F;
			this.PaymntBnsZeroFlg9.Name = "PaymntBnsZeroFlg9";
			this.PaymntBnsZeroFlg9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg9.Text = null;
			this.PaymntBnsZeroFlg9.Top = 4.339F;
			this.PaymntBnsZeroFlg9.Visible = false;
			this.PaymntBnsZeroFlg9.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg10
			// 
			this.PaymntBnsZeroFlg10.DataField = "PAYMNT_BNS_ZERO_FLG10";
			this.PaymntBnsZeroFlg10.Height = 0.143F;
			this.PaymntBnsZeroFlg10.Left = 1.875F;
			this.PaymntBnsZeroFlg10.Name = "PaymntBnsZeroFlg10";
			this.PaymntBnsZeroFlg10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg10.Text = null;
			this.PaymntBnsZeroFlg10.Top = 4.339F;
			this.PaymntBnsZeroFlg10.Visible = false;
			this.PaymntBnsZeroFlg10.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg11
			// 
			this.PaymntBnsZeroFlg11.DataField = "PAYMNT_BNS_ZERO_FLG11";
			this.PaymntBnsZeroFlg11.Height = 0.143F;
			this.PaymntBnsZeroFlg11.Left = 2.5F;
			this.PaymntBnsZeroFlg11.Name = "PaymntBnsZeroFlg11";
			this.PaymntBnsZeroFlg11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg11.Text = null;
			this.PaymntBnsZeroFlg11.Top = 4.339F;
			this.PaymntBnsZeroFlg11.Visible = false;
			this.PaymntBnsZeroFlg11.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg12
			// 
			this.PaymntBnsZeroFlg12.DataField = "PAYMNT_BNS_ZERO_FLG12";
			this.PaymntBnsZeroFlg12.Height = 0.143F;
			this.PaymntBnsZeroFlg12.Left = 3.125F;
			this.PaymntBnsZeroFlg12.Name = "PaymntBnsZeroFlg12";
			this.PaymntBnsZeroFlg12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg12.Text = null;
			this.PaymntBnsZeroFlg12.Top = 4.339F;
			this.PaymntBnsZeroFlg12.Visible = false;
			this.PaymntBnsZeroFlg12.Width = 0.625F;
			// 
			// DedBnsZeroFlg7
			// 
			this.DedBnsZeroFlg7.DataField = "DED_BNS_ZERO_FLG7";
			this.DedBnsZeroFlg7.Height = 0.143F;
			this.DedBnsZeroFlg7.Left = 0F;
			this.DedBnsZeroFlg7.Name = "DedBnsZeroFlg7";
			this.DedBnsZeroFlg7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg7.Text = null;
			this.DedBnsZeroFlg7.Top = 4.464F;
			this.DedBnsZeroFlg7.Visible = false;
			this.DedBnsZeroFlg7.Width = 0.625F;
			// 
			// DedBnsZeroFlg8
			// 
			this.DedBnsZeroFlg8.DataField = "DED_BNS_ZERO_FLG8";
			this.DedBnsZeroFlg8.Height = 0.143F;
			this.DedBnsZeroFlg8.Left = 0.625F;
			this.DedBnsZeroFlg8.Name = "DedBnsZeroFlg8";
			this.DedBnsZeroFlg8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg8.Text = null;
			this.DedBnsZeroFlg8.Top = 4.464F;
			this.DedBnsZeroFlg8.Visible = false;
			this.DedBnsZeroFlg8.Width = 0.625F;
			// 
			// DedBnsZeroFlg9
			// 
			this.DedBnsZeroFlg9.DataField = "DED_BNS_ZERO_FLG9";
			this.DedBnsZeroFlg9.Height = 0.143F;
			this.DedBnsZeroFlg9.Left = 1.25F;
			this.DedBnsZeroFlg9.Name = "DedBnsZeroFlg9";
			this.DedBnsZeroFlg9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg9.Text = null;
			this.DedBnsZeroFlg9.Top = 4.464F;
			this.DedBnsZeroFlg9.Visible = false;
			this.DedBnsZeroFlg9.Width = 0.625F;
			// 
			// DedBnsZeroFlg10
			// 
			this.DedBnsZeroFlg10.DataField = "DED_BNS_ZERO_FLG10";
			this.DedBnsZeroFlg10.Height = 0.143F;
			this.DedBnsZeroFlg10.Left = 1.875F;
			this.DedBnsZeroFlg10.Name = "DedBnsZeroFlg10";
			this.DedBnsZeroFlg10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg10.Text = null;
			this.DedBnsZeroFlg10.Top = 4.464F;
			this.DedBnsZeroFlg10.Visible = false;
			this.DedBnsZeroFlg10.Width = 0.625F;
			// 
			// DedBnsZeroFlg11
			// 
			this.DedBnsZeroFlg11.DataField = "DED_BNS_ZERO_FLG11";
			this.DedBnsZeroFlg11.Height = 0.143F;
			this.DedBnsZeroFlg11.Left = 2.5F;
			this.DedBnsZeroFlg11.Name = "DedBnsZeroFlg11";
			this.DedBnsZeroFlg11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg11.Text = null;
			this.DedBnsZeroFlg11.Top = 4.464F;
			this.DedBnsZeroFlg11.Visible = false;
			this.DedBnsZeroFlg11.Width = 0.625F;
			// 
			// DedBnsZeroFlg12
			// 
			this.DedBnsZeroFlg12.DataField = "DED_BNS_ZERO_FLG12";
			this.DedBnsZeroFlg12.Height = 0.143F;
			this.DedBnsZeroFlg12.Left = 3.125F;
			this.DedBnsZeroFlg12.Name = "DedBnsZeroFlg12";
			this.DedBnsZeroFlg12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg12.Text = null;
			this.DedBnsZeroFlg12.Top = 4.464F;
			this.DedBnsZeroFlg12.Visible = false;
			this.DedBnsZeroFlg12.Width = 0.625F;
			// 
			// PaymntBnsDispType7
			// 
			this.PaymntBnsDispType7.DataField = "PAYMNT_BNS_DISP_TYPE7";
			this.PaymntBnsDispType7.Height = 0.143F;
			this.PaymntBnsDispType7.Left = 0F;
			this.PaymntBnsDispType7.Name = "PaymntBnsDispType7";
			this.PaymntBnsDispType7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType7.Text = null;
			this.PaymntBnsDispType7.Top = 4.589F;
			this.PaymntBnsDispType7.Visible = false;
			this.PaymntBnsDispType7.Width = 0.625F;
			// 
			// PaymntBnsDispType8
			// 
			this.PaymntBnsDispType8.DataField = "PAYMNT_BNS_DISP_TYPE8";
			this.PaymntBnsDispType8.Height = 0.143F;
			this.PaymntBnsDispType8.Left = 0.625F;
			this.PaymntBnsDispType8.Name = "PaymntBnsDispType8";
			this.PaymntBnsDispType8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType8.Text = null;
			this.PaymntBnsDispType8.Top = 4.589F;
			this.PaymntBnsDispType8.Visible = false;
			this.PaymntBnsDispType8.Width = 0.625F;
			// 
			// PaymntBnsDispType9
			// 
			this.PaymntBnsDispType9.DataField = "PAYMNT_BNS_DISP_TYPE9";
			this.PaymntBnsDispType9.Height = 0.143F;
			this.PaymntBnsDispType9.Left = 1.25F;
			this.PaymntBnsDispType9.Name = "PaymntBnsDispType9";
			this.PaymntBnsDispType9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType9.Text = null;
			this.PaymntBnsDispType9.Top = 4.589F;
			this.PaymntBnsDispType9.Visible = false;
			this.PaymntBnsDispType9.Width = 0.625F;
			// 
			// PaymntBnsDispType10
			// 
			this.PaymntBnsDispType10.DataField = "PAYMNT_BNS_DISP_TYPE10";
			this.PaymntBnsDispType10.Height = 0.143F;
			this.PaymntBnsDispType10.Left = 1.875F;
			this.PaymntBnsDispType10.Name = "PaymntBnsDispType10";
			this.PaymntBnsDispType10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType10.Text = null;
			this.PaymntBnsDispType10.Top = 4.589F;
			this.PaymntBnsDispType10.Visible = false;
			this.PaymntBnsDispType10.Width = 0.625F;
			// 
			// PaymntBnsDispType11
			// 
			this.PaymntBnsDispType11.DataField = "PAYMNT_BNS_DISP_TYPE11";
			this.PaymntBnsDispType11.Height = 0.143F;
			this.PaymntBnsDispType11.Left = 2.5F;
			this.PaymntBnsDispType11.Name = "PaymntBnsDispType11";
			this.PaymntBnsDispType11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType11.Text = null;
			this.PaymntBnsDispType11.Top = 4.589F;
			this.PaymntBnsDispType11.Visible = false;
			this.PaymntBnsDispType11.Width = 0.625F;
			// 
			// PaymntBnsDispType12
			// 
			this.PaymntBnsDispType12.DataField = "PAYMNT_BNS_DISP_TYPE12";
			this.PaymntBnsDispType12.Height = 0.143F;
			this.PaymntBnsDispType12.Left = 3.125F;
			this.PaymntBnsDispType12.Name = "PaymntBnsDispType12";
			this.PaymntBnsDispType12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType12.Text = null;
			this.PaymntBnsDispType12.Top = 4.589F;
			this.PaymntBnsDispType12.Visible = false;
			this.PaymntBnsDispType12.Width = 0.625F;
			// 
			// DedBnsDispType7
			// 
			this.DedBnsDispType7.DataField = "DED_BNS_DISP_TYPE7";
			this.DedBnsDispType7.Height = 0.143F;
			this.DedBnsDispType7.Left = 0F;
			this.DedBnsDispType7.Name = "DedBnsDispType7";
			this.DedBnsDispType7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType7.Text = null;
			this.DedBnsDispType7.Top = 4.714F;
			this.DedBnsDispType7.Visible = false;
			this.DedBnsDispType7.Width = 0.625F;
			// 
			// DedBnsDispType8
			// 
			this.DedBnsDispType8.DataField = "DED_BNS_DISP_TYPE8";
			this.DedBnsDispType8.Height = 0.143F;
			this.DedBnsDispType8.Left = 0.625F;
			this.DedBnsDispType8.Name = "DedBnsDispType8";
			this.DedBnsDispType8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType8.Text = null;
			this.DedBnsDispType8.Top = 4.714F;
			this.DedBnsDispType8.Visible = false;
			this.DedBnsDispType8.Width = 0.625F;
			// 
			// DedBnsDispType9
			// 
			this.DedBnsDispType9.DataField = "DED_BNS_DISP_TYPE9";
			this.DedBnsDispType9.Height = 0.143F;
			this.DedBnsDispType9.Left = 1.25F;
			this.DedBnsDispType9.Name = "DedBnsDispType9";
			this.DedBnsDispType9.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType9.Text = null;
			this.DedBnsDispType9.Top = 4.714F;
			this.DedBnsDispType9.Visible = false;
			this.DedBnsDispType9.Width = 0.625F;
			// 
			// DedBnsDispType10
			// 
			this.DedBnsDispType10.DataField = "DED_BNS_DISP_TYPE10";
			this.DedBnsDispType10.Height = 0.143F;
			this.DedBnsDispType10.Left = 1.875F;
			this.DedBnsDispType10.Name = "DedBnsDispType10";
			this.DedBnsDispType10.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType10.Text = null;
			this.DedBnsDispType10.Top = 4.714F;
			this.DedBnsDispType10.Visible = false;
			this.DedBnsDispType10.Width = 0.625F;
			// 
			// DedBnsDispType11
			// 
			this.DedBnsDispType11.DataField = "DED_BNS_DISP_TYPE11";
			this.DedBnsDispType11.Height = 0.143F;
			this.DedBnsDispType11.Left = 2.5F;
			this.DedBnsDispType11.Name = "DedBnsDispType11";
			this.DedBnsDispType11.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType11.Text = null;
			this.DedBnsDispType11.Top = 4.714F;
			this.DedBnsDispType11.Visible = false;
			this.DedBnsDispType11.Width = 0.625F;
			// 
			// DedBnsDispType12
			// 
			this.DedBnsDispType12.DataField = "DED_BNS_DISP_TYPE12";
			this.DedBnsDispType12.Height = 0.143F;
			this.DedBnsDispType12.Left = 3.125F;
			this.DedBnsDispType12.Name = "DedBnsDispType12";
			this.DedBnsDispType12.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType12.Text = null;
			this.DedBnsDispType12.Top = 4.714F;
			this.DedBnsDispType12.Visible = false;
			this.DedBnsDispType12.Width = 0.625F;
			// 
			// Line410
			// 
			this.Line410.Height = 0F;
			this.Line410.Left = 0.0004997253F;
			this.Line410.LineWeight = 1F;
			this.Line410.Name = "Line410";
			this.Line410.Top = 4.316999F;
			this.Line410.Width = 3.751F;
			this.Line410.X1 = 0.0004997253F;
			this.Line410.X2 = 3.7515F;
			this.Line410.Y1 = 4.316999F;
			this.Line410.Y2 = 4.316999F;
			// 
			// Line411
			// 
			this.Line411.Height = 0F;
			this.Line411.Left = 0.0004997253F;
			this.Line411.LineWeight = 1F;
			this.Line411.Name = "Line411";
			this.Line411.Top = 4.159F;
			this.Line411.Width = 3.751F;
			this.Line411.X1 = 0.0004997253F;
			this.Line411.X2 = 3.7515F;
			this.Line411.Y1 = 4.159F;
			this.Line411.Y2 = 4.159F;
			// 
			// PaymntBnsName7
			// 
			this.PaymntBnsName7.DataField = "PAYMNT_BNS_NAME7";
			this.PaymntBnsName7.Height = 0.143F;
			this.PaymntBnsName7.Left = 0.0004997253F;
			this.PaymntBnsName7.Name = "PaymntBnsName7";
			this.PaymntBnsName7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName7.Text = "あいうえおか";
			this.PaymntBnsName7.Top = 4.021F;
			this.PaymntBnsName7.Width = 0.625F;
			// 
			// DedBnsName7
			// 
			this.DedBnsName7.DataField = "DED_BNS_NAME7";
			this.DedBnsName7.Height = 0.143F;
			this.DedBnsName7.Left = 0.0004997253F;
			this.DedBnsName7.Name = "DedBnsName7";
			this.DedBnsName7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName7.Text = "あいうえおか";
			this.DedBnsName7.Top = 4.174F;
			this.DedBnsName7.Width = 0.625F;
			// 
			// PaymntBnsName8
			// 
			this.PaymntBnsName8.DataField = "PAYMNT_BNS_NAME8";
			this.PaymntBnsName8.Height = 0.143F;
			this.PaymntBnsName8.Left = 0.6254997F;
			this.PaymntBnsName8.Name = "PaymntBnsName8";
			this.PaymntBnsName8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName8.Text = "あいうえおか";
			this.PaymntBnsName8.Top = 4.021F;
			this.PaymntBnsName8.Width = 0.624F;
			// 
			// DedBnsName8
			// 
			this.DedBnsName8.DataField = "DED_BNS_NAME8";
			this.DedBnsName8.Height = 0.143F;
			this.DedBnsName8.Left = 0.6254997F;
			this.DedBnsName8.Name = "DedBnsName8";
			this.DedBnsName8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName8.Text = "あいうえおか";
			this.DedBnsName8.Top = 4.174F;
			this.DedBnsName8.Width = 0.624F;
			// 
			// PaymntBnsName9
			// 
			this.PaymntBnsName9.DataField = "PAYMNT_BNS_NAME9";
			this.PaymntBnsName9.Height = 0.143F;
			this.PaymntBnsName9.Left = 1.251501F;
			this.PaymntBnsName9.Name = "PaymntBnsName9";
			this.PaymntBnsName9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName9.Text = "あいうえおか";
			this.PaymntBnsName9.Top = 4.021F;
			this.PaymntBnsName9.Width = 0.624F;
			// 
			// DedBnsName9
			// 
			this.DedBnsName9.DataField = "DED_BNS_NAME9";
			this.DedBnsName9.Height = 0.143F;
			this.DedBnsName9.Left = 1.251501F;
			this.DedBnsName9.Name = "DedBnsName9";
			this.DedBnsName9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName9.Text = "あいうえおか";
			this.DedBnsName9.Top = 4.174F;
			this.DedBnsName9.Width = 0.624F;
			// 
			// DedBnsName10
			// 
			this.DedBnsName10.DataField = "DED_BNS_NAME10";
			this.DedBnsName10.Height = 0.143F;
			this.DedBnsName10.Left = 1.875499F;
			this.DedBnsName10.Name = "DedBnsName10";
			this.DedBnsName10.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName10.Text = "あいうえおか";
			this.DedBnsName10.Top = 4.174F;
			this.DedBnsName10.Width = 0.625F;
			// 
			// PaymntBnsName10
			// 
			this.PaymntBnsName10.DataField = "PAYMNT_BNS_NAME10";
			this.PaymntBnsName10.Height = 0.143F;
			this.PaymntBnsName10.Left = 1.875499F;
			this.PaymntBnsName10.Name = "PaymntBnsName10";
			this.PaymntBnsName10.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName10.Text = "あいうえおか";
			this.PaymntBnsName10.Top = 4.021F;
			this.PaymntBnsName10.Width = 0.625F;
			// 
			// PaymntBnsName11
			// 
			this.PaymntBnsName11.DataField = "PAYMNT_BNS_NAME11";
			this.PaymntBnsName11.Height = 0.143F;
			this.PaymntBnsName11.Left = 2.5015F;
			this.PaymntBnsName11.Name = "PaymntBnsName11";
			this.PaymntBnsName11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName11.Text = "あいうえおか";
			this.PaymntBnsName11.Top = 4.021F;
			this.PaymntBnsName11.Width = 0.624F;
			// 
			// DedBnsName11
			// 
			this.DedBnsName11.DataField = "DED_BNS_NAME11";
			this.DedBnsName11.Height = 0.143F;
			this.DedBnsName11.Left = 2.5015F;
			this.DedBnsName11.Name = "DedBnsName11";
			this.DedBnsName11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName11.Text = "あいうえおか";
			this.DedBnsName11.Top = 4.174F;
			this.DedBnsName11.Width = 0.624F;
			// 
			// PaymntBnsName12
			// 
			this.PaymntBnsName12.DataField = "PAYMNT_BNS_NAME12";
			this.PaymntBnsName12.Height = 0.143F;
			this.PaymntBnsName12.Left = 3.1255F;
			this.PaymntBnsName12.Name = "PaymntBnsName12";
			this.PaymntBnsName12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName12.Text = "あいうえおか";
			this.PaymntBnsName12.Top = 4.021F;
			this.PaymntBnsName12.Width = 0.625F;
			// 
			// DedBnsName12
			// 
			this.DedBnsName12.DataField = "DED_BNS_NAME12";
			this.DedBnsName12.Height = 0.143F;
			this.DedBnsName12.Left = 3.1255F;
			this.DedBnsName12.Name = "DedBnsName12";
			this.DedBnsName12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName12.Text = "あいうえおか";
			this.DedBnsName12.Top = 4.174F;
			this.DedBnsName12.Width = 0.625F;
			// 
			// Label154
			// 
			this.Label154.Height = 0.143F;
			this.Label154.HyperLink = null;
			this.Label154.Left = 3.125F;
			this.Label154.Name = "Label154";
			this.Label154.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label154.Text = "個人年金控除";
			this.Label154.Top = 6.318499F;
			this.Label154.Width = 0.625F;
			// 
			// Label155
			// 
			this.Label155.Height = 0.143F;
			this.Label155.HyperLink = null;
			this.Label155.Left = 3.125F;
			this.Label155.Name = "Label155";
			this.Label155.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label155.Text = "差引過納額";
			this.Label155.Top = 6.6045F;
			this.Label155.Width = 0.625F;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Line208});
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			this.PageHeader.BeforePrint += new System.EventHandler(this.PageHeader_BeforePrint);
			this.PageHeader.AfterPrint += new System.EventHandler(this.PageHeader_AfterPrint);
			// 
			// Line208
			// 
			this.Line208.Height = 0F;
			this.Line208.Left = 0.06F;
			this.Line208.LineWeight = 1F;
			this.Line208.Name = "Line208";
			this.Line208.Top = 1.245F;
			this.Line208.Width = 10.72F;
			this.Line208.X1 = 0.06F;
			this.Line208.X2 = 10.78F;
			this.Line208.Y1 = 1.245F;
			this.Line208.Y2 = 1.245F;
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Format += new System.EventHandler(this.PageFooter_Format);
			this.PageFooter.AfterPrint += new System.EventHandler(this.PageFooter_AfterPrint);
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Height = 0F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.AfterPrint += new System.EventHandler(this.GroupHeader1_AfterPrint);
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// HR_PY_06_R97
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.2F;
			this.PageSettings.Margins.Left = 0.3F;
			this.PageSettings.Margins.Right = 0.3F;
			this.PageSettings.Margins.Top = 0.2F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.268056F;
			this.PrintWidth = 10.9F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_06_R97_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.PaymntName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
