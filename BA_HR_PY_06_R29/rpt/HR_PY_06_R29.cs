// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 06
// File Name   : HR_PY_06_R29.cs
// 機能名      : HR_PY_06_R29 賃金台帳兼源泉徴収簿
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 1.0.0 2004/04/01
// 管理番号 B14921 2005/06/20 フォーマット区分が1の時の出勤項目の表示対応
// 1.3.3 2005/06/30
// 管理番号 B15940 2005/08/11 給与･賞与明細項目設定マスタの不具合
// 1.4.0 2005/10/31
// 管理番号 B16920 2006/01/11 年末調整一覧表(年調定率控除額に見出し修正)
// 管理番号 B17433 2006/05/18 賃金台帳兼源泉徴収簿(項目見出し不備)
// 管理番号 B18040 2006/06/06 賃金台帳兼源泉徴収簿（厚生年金番号の出力不備）
// 管理番号 B18529 2006/08/01 年調調整入力(扶養人数の表示変更等)
// 管理番号 B18526 2006/08/04 賃金台帳源泉徴収簿(特別障害者の表示不具合)
// 管理番号 B18680 2006/09/19 賃金台帳兼源泉徴収簿(計算結果が0の時の印字有無不具合)
// 1.4.1 2006/09/30
// 管理番号 B19166 2006/10/12 賃金台帳兼源泉徴収簿(配偶者特別控除額の印字)
// 管理番号 K19592 2006/11/16 平成１８年度税制改正(地震保険料控除の創設)
// 1.4.2 2006/11/30
// 1.5.2 2007/10/31
// 管理番号 K20794 2007/12/04 法改正対応（地震保険料控除／住宅取得控除可能額）
// 管理番号 B21167 2008/02/18 H18年税額・住宅可能額の項目タイトルが正しく表示されない不具合
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 K23647 2010/09/30 平成22年度税制改正対応
// 管理番号 K24060 2012/04/16 平成22年度税制改正対応（介護医療保険料控除）
// 管理番号 K24565 2012/06/06 ActiveReportsバージョンアップ対応
// 管理番号 B24534 2012/08/28 時間項目の合算時に時間単位(60進)が考慮されない不具合を修正
// 管理番号 K24680 2012/09/06 法改正対応（復興特別所得税の創設）
// 管理番号 B24738 2012/10/03 給与控除額が正しく集計されない不具合を修正
// 2.0.0 2012/10/31
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30
// 管理番号K26643 2018/03/01 配偶者（特別）控除対応
// 3.0.0 2018/04/30
// 3.1.0 2020/06/30
// 管理番号K27274 2021/06/11 年末調整関連法改正(令和２年)
// 3.2.0 2023/03/31
// 管理番号K27665 2023/07/11 ActiveReportsバージョンアップ（SP4）対応

using System;
// 管理番号 K24565 From
using System.Data;
// 管理番号 K24565 To
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_06_R29 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_06_R29()
		{


			InitializeComponent();
		}

		#region Protected Fields
// 管理番号 K19592 From
		private const string TAX_REVISION_YEAR = "2006";
		private const string EARTHQUAKE_INSURANCE_DED = "地震保険控除";
// 管理番号 K19592 To
// 管理番号 K23647 From
		private const string H23_TAX_REVISION_YEAR = "2011";
// 管理番号 K23647 To
// 管理番号K26643 From
		private const string H30_TAX_REVISION_YEAR = "2018";
// 管理番号K26643 To
// 管理番号 K24060 From
		//平成24年以後の所得税改正（介護医療保険控除創設）の西暦年
		private const string TAX_REVISION_CARE_YEAR = "2012";
// 管理番号 K24060 To
		protected string reportID;
		protected string companyName;
		protected CommonData cd;
		double paymntTotal1Amt1 = 0;
		double paymntTotal1Amt2 = 0;
		double paymntTotal1Amt3 = 0;
		double paymntTotal1Amt4 = 0;
		double paymntTotal1Amt5 = 0;
		double paymntTotal1Amt6 = 0;
// 管理番号 K24565 From
//		double paymntTotal1Amt7 = 0;
//		double paymntTotal1Amt8 = 0; 
//		double paymntTotal1Amt9 = 0;
//		double paymntTotal1Amt10 = 0; 
//		double paymntTotal1Amt11 = 0;
//		double paymntTotal1Amt12 = 0; 
// 管理番号 K24565 To
		double dedTotal1Amt1 = 0;
		double dedTotal1Amt2 = 0;
		double dedTotal1Amt3 = 0;
		double dedTotal1Amt4 = 0;
		double dedTotal1Amt5 = 0;
		double dedTotal1Amt6 = 0;
// 管理番号 K24565 From
//		double dedTotal1Amt7 = 0;
//		double dedTotal1Amt8 = 0; 
//		double dedTotal1Amt9 = 0;
//		double dedTotal1Amt10 = 0; 
//		double dedTotal1Amt11 = 0;
//		double dedTotal1Amt12 = 0;
// 管理番号 K24565 To
		double paymntTotal2Amt1 = 0;
		double paymntTotal2Amt2 = 0;
		double paymntTotal2Amt3 = 0;
		double paymntTotal2Amt4 = 0;
		double paymntTotal2Amt5 = 0;
		double paymntTotal2Amt6 = 0;
// 管理番号 K24565 From
//		double paymntTotal2Amt7 = 0;
//		double paymntTotal2Amt8 = 0; 
//		double paymntTotal2Amt9 = 0;
//		double paymntTotal2Amt10 = 0; 
//		double paymntTotal2Amt11 = 0;
//		double paymntTotal2Amt12 = 0; 
// 管理番号 K24565 To
		double dedTotal2Amt1 = 0;
		double dedTotal2Amt2 = 0;
		double dedTotal2Amt3 = 0;
		double dedTotal2Amt4 = 0;
		double dedTotal2Amt5 = 0;
		double dedTotal2Amt6 = 0;
// 管理番号 K24565 From
//		double dedTotal2Amt7 = 0;
//		double dedTotal2Amt8 = 0; 
//		double dedTotal2Amt9 = 0;
//		double dedTotal2Amt10 = 0; 
//		double dedTotal2Amt11 = 0;
//		double dedTotal2Amt12 = 0;
// 管理番号 K24565 To
		double paymntTotal3Amt1 = 0;
		double paymntTotal3Amt2 = 0;
		double paymntTotal3Amt3 = 0;
		double paymntTotal3Amt4 = 0;
		double paymntTotal3Amt5 = 0;
		double paymntTotal3Amt6 = 0;
// 管理番号 K24565 From
//		double paymntTotal3Amt7 = 0;
//		double paymntTotal3Amt8 = 0; 
//		double paymntTotal3Amt9 = 0;
//		double paymntTotal3Amt10 = 0; 
//		double paymntTotal3Amt11 = 0;
//		double paymntTotal3Amt12 = 0;
// 管理番号 K24565 To
		double paymntTotal4Amt1 = 0;
		double paymntTotal4Amt2 = 0;
		double paymntTotal4Amt3 = 0;
		double paymntTotal4Amt4 = 0;
		double paymntTotal4Amt5 = 0;
		double paymntTotal4Amt6 = 0;
// 管理番号 K24565 From
//		double paymntTotal4Amt7 = 0;
//		double paymntTotal4Amt8 = 0; 
//		double paymntTotal4Amt9 = 0;
//		double paymntTotal4Amt10 = 0; 
//		double paymntTotal4Amt11 = 0;
//		double paymntTotal4Amt12 = 0; 
// 管理番号 K24565 To
		double dedTotal3Amt1 = 0;
		double dedTotal3Amt2 = 0;
		double dedTotal3Amt3 = 0;
		double dedTotal3Amt4 = 0;
		double dedTotal3Amt5 = 0;
		double dedTotal3Amt6 = 0;
// 管理番号 K24565 From
//		double dedTotal3Amt7 = 0;
//		double dedTotal3Amt8 = 0; 
//		double dedTotal3Amt9 = 0;
//		double dedTotal3Amt10 = 0; 
//		double dedTotal3Amt11 = 0;
//		double dedTotal3Amt12 = 0;
// 管理番号 K24565 To
		double dedTotal4Amt1 = 0;
		double dedTotal4Amt2 = 0;
		double dedTotal4Amt3 = 0;
		double dedTotal4Amt4 = 0;
		double dedTotal4Amt5 = 0;
		double dedTotal4Amt6 = 0;
// 管理番号 K24565 From
//		double dedTotal4Amt7 = 0;
//		double dedTotal4Amt8 = 0; 
//		double dedTotal4Amt9 = 0;
//		double dedTotal4Amt10 = 0; 
//		double dedTotal4Amt11 = 0;
//		double dedTotal4Amt12 = 0;
// 管理番号 K24565 To
// 管理番号 B24534 From
//		double dtyTotal1 = 0;
//		double dtyTotal2 = 0;
//		double dtyTotal3 = 0;
//		double dtyTotal4 = 0;
//		double dtyTotal5 = 0;
//		double dtyTotal6 = 0;
//		double dtyTotal7 = 0;
//		double dtyTotal8 = 0;
// 管理番号 B24534 To
// 管理番号 B15940 From
		bool paymntTotal1Amt1Flg = false;	// 支給合計1項目1出力フラグ
		bool paymntTotal1Amt2Flg = false;	// 支給合計1項目2出力フラグ
		bool paymntTotal1Amt3Flg = false;	// 支給合計1項目3出力フラグ
		bool paymntTotal1Amt4Flg = false;	// 支給合計1項目4出力フラグ
		bool paymntTotal1Amt5Flg = false;	// 支給合計1項目5出力フラグ
		bool paymntTotal1Amt6Flg = false;	// 支給合計1項目6出力フラグ
// 管理番号 K24565 From
//		bool paymntTotal1Amt7Flg = false;	// 支給合計1項目7出力フラグ
//		bool paymntTotal1Amt8Flg = false;	// 支給合計1項目8出力フラグ
//		bool paymntTotal1Amt9Flg = false;	// 支給合計1項目9出力フラグ
//		bool paymntTotal1Amt10Flg = false;	// 支給合計1項目10出力フラグ
//		bool paymntTotal1Amt11Flg = false;	// 支給合計1項目11出力フラグ
//		bool paymntTotal1Amt12Flg = false;	// 支給合計1項目12出力フラグ
// 管理番号 K24565 To
		bool dedTotal1Amt1Flg = false;		// 支給合計1項目1出力フラグ
		bool dedTotal1Amt2Flg = false;		// 支給合計1項目2出力フラグ
		bool dedTotal1Amt3Flg = false;		// 支給合計1項目3出力フラグ
		bool dedTotal1Amt4Flg = false;		// 支給合計1項目4出力フラグ
		bool dedTotal1Amt5Flg = false;		// 支給合計1項目5出力フラグ
		bool dedTotal1Amt6Flg = false;		// 支給合計1項目6出力フラグ
// 管理番号 K24565 From
//		bool dedTotal1Amt7Flg = false;		// 支給合計1項目7出力フラグ
//		bool dedTotal1Amt8Flg = false;		// 支給合計1項目8出力フラグ
//		bool dedTotal1Amt9Flg = false;		// 支給合計1項目9出力フラグ
//		bool dedTotal1Amt10Flg = false;		// 支給合計1項目10出力フラグ
//		bool dedTotal1Amt11Flg = false;		// 支給合計1項目11出力フラグ
//		bool dedTotal1Amt12Flg = false;		// 支給合計1項目12出力フラグ
// 管理番号 K24565 To

		bool paymntTotal2Amt1Flg = false;	// 支給合計2項目1出力フラグ
		bool paymntTotal2Amt2Flg = false;	// 支給合計2項目2出力フラグ
		bool paymntTotal2Amt3Flg = false;	// 支給合計2項目3出力フラグ
		bool paymntTotal2Amt4Flg = false;	// 支給合計2項目4出力フラグ
		bool paymntTotal2Amt5Flg = false;	// 支給合計2項目5出力フラグ
		bool paymntTotal2Amt6Flg = false;	// 支給合計2項目6出力フラグ
// 管理番号 K24565 From
//		bool paymntTotal2Amt7Flg = false;	// 支給合計2項目7出力フラグ
//		bool paymntTotal2Amt8Flg = false;	// 支給合計2項目8出力フラグ
//		bool paymntTotal2Amt9Flg = false;	// 支給合計2項目9出力フラグ
//		bool paymntTotal2Amt10Flg = false;	// 支給合計2項目10出力フラグ
//		bool paymntTotal2Amt11Flg = false;	// 支給合計2項目11出力フラグ
//		bool paymntTotal2Amt12Flg = false;	// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
		bool dedTotal2Amt1Flg = false;		// 支給合計2項目1出力フラグ
		bool dedTotal2Amt2Flg = false;		// 支給合計2項目2出力フラグ
		bool dedTotal2Amt3Flg = false;		// 支給合計2項目3出力フラグ
		bool dedTotal2Amt4Flg = false;		// 支給合計2項目4出力フラグ
		bool dedTotal2Amt5Flg = false;		// 支給合計2項目5出力フラグ
		bool dedTotal2Amt6Flg = false;		// 支給合計2項目6出力フラグ
// 管理番号 K24565 From
//		bool dedTotal2Amt7Flg = false;		// 支給合計2項目7出力フラグ
//		bool dedTotal2Amt8Flg = false;		// 支給合計2項目8出力フラグ
//		bool dedTotal2Amt9Flg = false;		// 支給合計2項目9出力フラグ
//		bool dedTotal2Amt10Flg = false;		// 支給合計2項目10出力フラグ
//		bool dedTotal2Amt11Flg = false;		// 支給合計2項目11出力フラグ
//		bool dedTotal2Amt12Flg = false;		// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
// 管理番号 B24534 From
//		bool dtyTotal1Flg		= false;	// 勤怠合計項目1出力フラグ
//		bool dtyTotal2Flg		= false;	// 勤怠合計項目2出力フラグ
//		bool dtyTotal3Flg		= false;	// 勤怠合計項目3出力フラグ
//		bool dtyTotal4Flg		= false;	// 勤怠合計項目4出力フラグ
//		bool dtyTotal5Flg		= false;	// 勤怠合計項目5出力フラグ
//		bool dtyTotal6Flg		= false;	// 勤怠合計項目6出力フラグ
//		bool dtyTotal7Flg		= false;	// 勤怠合計項目7出力フラグ
//		bool dtyTotal8Flg		= false;	// 勤怠合計項目8出力フラグ
// 管理番号 B24534 To

		bool paymntTotal3Amt1Flg = false;	// 支給合計3項目1出力フラグ
		bool paymntTotal3Amt2Flg = false;	// 支給合計3項目2出力フラグ
		bool paymntTotal3Amt3Flg = false;	// 支給合計3項目3出力フラグ
		bool paymntTotal3Amt4Flg = false;	// 支給合計3項目4出力フラグ
		bool paymntTotal3Amt5Flg = false;	// 支給合計3項目5出力フラグ
		bool paymntTotal3Amt6Flg = false;	// 支給合計3項目6出力フラグ
// 管理番号 K24565 From
//		bool paymntTotal3Amt7Flg = false;	// 支給合計3項目7出力フラグ
//		bool paymntTotal3Amt8Flg = false;	// 支給合計3項目8出力フラグ
//		bool paymntTotal3Amt9Flg = false;	// 支給合計3項目9出力フラグ
//		bool paymntTotal3Amt10Flg = false;	// 支給合計3項目10出力フラグ
//		bool paymntTotal3Amt11Flg = false;	// 支給合計3項目11出力フラグ
//		bool paymntTotal3Amt12Flg = false;	// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
		bool dedTotal3Amt1Flg = false;		// 支給合計3項目1出力フラグ
		bool dedTotal3Amt2Flg = false;		// 支給合計3項目2出力フラグ
		bool dedTotal3Amt3Flg = false;		// 支給合計3項目3出力フラグ
		bool dedTotal3Amt4Flg = false;		// 支給合計3項目4出力フラグ
		bool dedTotal3Amt5Flg = false;		// 支給合計3項目5出力フラグ
		bool dedTotal3Amt6Flg = false;		// 支給合計3項目6出力フラグ
// 管理番号 K24565 From
//		bool dedTotal3Amt7Flg = false;		// 支給合計3項目7出力フラグ
//		bool dedTotal3Amt8Flg = false;		// 支給合計3項目8出力フラグ
//		bool dedTotal3Amt9Flg = false;		// 支給合計3項目9出力フラグ
//		bool dedTotal3Amt10Flg = false;		// 支給合計3項目10出力フラグ
//		bool dedTotal3Amt11Flg = false;
//		private Label Label156;
//		private TextBox TextBox484;		// 支給合計3項目11出力フラグ
//		bool dedTotal3Amt12Flg = false;		// 支給合計3項目12出力フラグ

		private SubReport SubReport1;
		private SubReport SubReport2;
// 管理番号 K24565 To
// 管理番号 B15940 From

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

		private void HR_PY_06_R29_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;

			DateText.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
		}

		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
			ReportIDText.Text = reportID;
		}

		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
			CompanyNameText.Text = companyName;
		}

		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void GroupHeader2_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
// 管理番号 B15940 From
			paymntTotal1Amt1Flg = false;	// 支給合計1項目1出力フラグ
			paymntTotal1Amt2Flg = false;	// 支給合計1項目2出力フラグ
			paymntTotal1Amt3Flg = false;	// 支給合計1項目3出力フラグ
			paymntTotal1Amt4Flg = false;	// 支給合計1項目4出力フラグ
			paymntTotal1Amt5Flg = false;	// 支給合計1項目5出力フラグ
			paymntTotal1Amt6Flg = false;	// 支給合計1項目6出力フラグ
// 管理番号 K24565 From
//			 paymntTotal1Amt7Flg	= false;	// 支給合計1項目7出力フラグ
//			 paymntTotal1Amt8Flg	= false;	// 支給合計1項目8出力フラグ
//			 paymntTotal1Amt9Flg	= false;	// 支給合計1項目9出力フラグ
//			 paymntTotal1Amt10Flg	= false;	// 支給合計1項目10出力フラグ
//			 paymntTotal1Amt11Flg	= false;	// 支給合計1項目11出力フラグ
//			 paymntTotal1Amt12Flg	= false;	// 支給合計1項目12出力フラグ
// 管理番号 K24565 To
			dedTotal1Amt1Flg = false;	// 支給合計1項目1出力フラグ
			dedTotal1Amt2Flg = false;	// 支給合計1項目2出力フラグ
			dedTotal1Amt3Flg = false;	// 支給合計1項目3出力フラグ
			dedTotal1Amt4Flg = false;	// 支給合計1項目4出力フラグ
			dedTotal1Amt5Flg = false;	// 支給合計1項目5出力フラグ
			dedTotal1Amt6Flg = false;	// 支給合計1項目6出力フラグ
// 管理番号 K24565 From
//			 dedTotal1Amt7Flg		= false;	// 支給合計1項目7出力フラグ
//			 dedTotal1Amt8Flg		= false;	// 支給合計1項目8出力フラグ
//			 dedTotal1Amt9Flg		= false;	// 支給合計1項目9出力フラグ
//			 dedTotal1Amt10Flg		= false;	// 支給合計1項目10出力フラグ
//			 dedTotal1Amt11Flg		= false;	// 支給合計1項目11出力フラグ
//			 dedTotal1Amt12Flg		= false;	// 支給合計1項目12出力フラグ
// 管理番号 K24565 To

			paymntTotal2Amt1Flg = false;	// 支給合計2項目1出力フラグ
			paymntTotal2Amt2Flg = false;	// 支給合計2項目2出力フラグ
			paymntTotal2Amt3Flg = false;	// 支給合計2項目3出力フラグ
			paymntTotal2Amt4Flg = false;	// 支給合計2項目4出力フラグ
			paymntTotal2Amt5Flg = false;	// 支給合計2項目5出力フラグ
			paymntTotal2Amt6Flg = false;	// 支給合計2項目6出力フラグ
// 管理番号 K24565 From
//			paymntTotal2Amt7Flg		= false;	// 支給合計2項目7出力フラグ
//			paymntTotal2Amt8Flg		= false;	// 支給合計2項目8出力フラグ
//			paymntTotal2Amt9Flg		= false;	// 支給合計2項目9出力フラグ
//			paymntTotal2Amt10Flg	= false;	// 支給合計2項目10出力フラグ
//			paymntTotal2Amt11Flg	= false;	// 支給合計2項目11出力フラグ
//			paymntTotal2Amt12Flg	= false;	// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
			dedTotal2Amt1Flg = false;	// 支給合計2項目1出力フラグ
			dedTotal2Amt2Flg = false;	// 支給合計2項目2出力フラグ
			dedTotal2Amt3Flg = false;	// 支給合計2項目3出力フラグ
			dedTotal2Amt4Flg = false;	// 支給合計2項目4出力フラグ
			dedTotal2Amt5Flg = false;	// 支給合計2項目5出力フラグ
			dedTotal2Amt6Flg = false;	// 支給合計2項目6出力フラグ
// 管理番号 K24565 From
//			dedTotal2Amt7Flg		= false;	// 支給合計2項目7出力フラグ
//			dedTotal2Amt8Flg		= false;	// 支給合計2項目8出力フラグ
//			dedTotal2Amt9Flg		= false;	// 支給合計2項目9出力フラグ
//			dedTotal2Amt10Flg		= false;	// 支給合計2項目10出力フラグ
//			dedTotal2Amt11Flg		= false;	// 支給合計2項目11出力フラグ
//			dedTotal2Amt12Flg		= false;	// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
// 管理番号 B24534 From
//			dtyTotal1Flg			= false;	// 勤怠合計項目1出力フラグ
//			dtyTotal2Flg			= false;	// 勤怠合計項目2出力フラグ
//			dtyTotal3Flg			= false;	// 勤怠合計項目3出力フラグ
//			dtyTotal4Flg			= false;	// 勤怠合計項目4出力フラグ
//			dtyTotal5Flg			= false;	// 勤怠合計項目5出力フラグ
//			dtyTotal6Flg			= false;	// 勤怠合計項目6出力フラグ
//			dtyTotal7Flg			= false;	// 勤怠合計項目7出力フラグ
//			dtyTotal8Flg			= false;	// 勤怠合計項目8出力フラグ
// 管理番号 B24534 To

			paymntTotal3Amt1Flg = false;	// 支給合計3項目1出力フラグ
			paymntTotal3Amt2Flg = false;	// 支給合計3項目2出力フラグ
			paymntTotal3Amt3Flg = false;	// 支給合計3項目3出力フラグ
			paymntTotal3Amt4Flg = false;	// 支給合計3項目4出力フラグ
			paymntTotal3Amt5Flg = false;	// 支給合計3項目5出力フラグ
			paymntTotal3Amt6Flg = false;	// 支給合計3項目6出力フラグ
// 管理番号 K24565 From
//			paymntTotal3Amt7Flg		= false;	// 支給合計3項目7出力フラグ
//			paymntTotal3Amt8Flg		= false;	// 支給合計3項目8出力フラグ
//			paymntTotal3Amt9Flg		= false;	// 支給合計3項目9出力フラグ
//			paymntTotal3Amt10Flg	= false;	// 支給合計3項目10出力フラグ
//			paymntTotal3Amt11Flg	= false;	// 支給合計3項目11出力フラグ
//			paymntTotal3Amt12Flg	= false;	// 支給合計2項目12出力フラグ
// 管理番号 K24565 To
			dedTotal3Amt1Flg = false;	// 支給合計3項目1出力フラグ
			dedTotal3Amt2Flg = false;	// 支給合計3項目2出力フラグ
			dedTotal3Amt3Flg = false;	// 支給合計3項目3出力フラグ
			dedTotal3Amt4Flg = false;	// 支給合計3項目4出力フラグ
			dedTotal3Amt5Flg = false;	// 支給合計3項目5出力フラグ
			dedTotal3Amt6Flg = false;	// 支給合計3項目6出力フラグ
// 管理番号 K24565 From
//			dedTotal3Amt7Flg		= false;	// 支給合計3項目7出力フラグ
//			dedTotal3Amt8Flg		= false;	// 支給合計3項目8出力フラグ
//			dedTotal3Amt9Flg		= false;	// 支給合計3項目9出力フラグ
//			dedTotal3Amt10Flg		= false;	// 支給合計3項目10出力フラグ
//			dedTotal3Amt11Flg		= false;	// 支給合計3項目11出力フラグ
//			dedTotal3Amt12Flg		= false;	// 支給合計3項目12出力フラグ
// 管理番号 K24565 To
// 管理番号 B15940 To
			if ((EnterComp2.Text != null) && (EnterComp2.Text != ""))
			{
				EnterComp3.Text = EnterComp2.Text;
			}
			else
			{
				EnterComp3.Text = EnterComp1.Text;
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if((Ded18Amt13.Text != null)&&(Ded18Amt13.Text != "")&&(Ded18Amt13.Text != "0"))
//			{
//// 管理番号 K24680 From
////// 管理番号 B16920 From
//////				Title.Text = "特別減税";
////                Title.Text = "年調定率控除";
////// 管理番号 B16920 To
//// 管理番号 K24680 To
//			}
//			else
//			{
//				Title.Text = "";
//			}
// 管理番号 K24565 To

			//給与支給額、賞与支給額、前職等修正分、年末調整の空白処理
// 管理番号 B15940 From
			//if((Paymnt1Amt1.Text == "0")||(Paymnt1Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt1Amt1.Text == "0") || (Paymnt1Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt1.Text = "";
			}
// 管理番号 B15940 From
			//if((Paymnt1Amt2.Text == "0")||(Paymnt1Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt1Amt2.Text == "0") || (Paymnt1Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt1Amt3.Text == "0")||(Paymnt1Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt1Amt3.Text == "0") || (Paymnt1Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt1Amt4.Text == "0")||(Paymnt1Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt1Amt4.Text == "0") || (Paymnt1Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt1Amt5.Text == "0")||(Paymnt1Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt1Amt5.Text == "0") || (Paymnt1Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt1Amt6.Text == "0")||(Paymnt1Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt1Amt6.Text == "0") || (Paymnt1Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt1Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From			
//			//if((Paymnt1Amt7.Text == "0")||(Paymnt1Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt1Amt7.Text == "0") || (Paymnt1Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt1Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt1Amt8.Text == "0")||(Paymnt1Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt1Amt8.Text == "0") || (Paymnt1Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt1Amt8.Text = "";
//			}
//			
//// 管理番号 B18680 From
////// 管理番号 B15940 From
////			//if((Paymnt1Amt9.Text == "0")||(Paymnt2Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
////			if(((Paymnt1Amt9.Text == "0") || (Paymnt2Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
////// 管理番号 B15940 To
//			if(((Paymnt1Amt9.Text == "0") || (Paymnt1Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B18680 To
//			{
//				Paymnt1Amt9.Text = "";
//			}
//			
//// 管理番号 B18680 From
////// 管理番号 B15940 From
////			//if((Paymnt1Amt10.Text == "0")||(Paymnt2Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
////			if(((Paymnt1Amt10.Text == "0") || (Paymnt2Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
////// 管理番号 B15940 To
//			if(((Paymnt1Amt10.Text == "0") || (Paymnt1Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B18680 To
//			{
//				Paymnt1Amt10.Text = "";
//			}
//			
//// 管理番号 B18680 From
////// 管理番号 B15940 From
////			//if((Paymnt1Amt11.Text == "0")||(Paymnt2Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
////			if(((Paymnt1Amt11.Text == "0") || (Paymnt2Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
////// 管理番号 B15940 To
//			if(((Paymnt1Amt11.Text == "0") || (Paymnt1Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B18680 To
//			{
//				Paymnt1Amt11.Text = "";
//			}
//
//// 管理番号 B18680 From
////// 管理番号 B15940 From
////			//if((Paymnt1Amt12.Text == "0")||(Paymnt2Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
////			if(((Paymnt1Amt12.Text == "0") || (Paymnt2Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
////// 管理番号 B15940 To
//			if(((Paymnt1Amt12.Text == "0") || (Paymnt1Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B18680 To
//			{
//				Paymnt1Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt2Amt1.Text == "0")||(Paymnt2Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt2Amt1.Text == "0") || (Paymnt2Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt2Amt2.Text == "0")||(Paymnt2Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt2Amt2.Text == "0") || (Paymnt2Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt2Amt3.Text == "0")||(Paymnt2Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt2Amt3.Text == "0") || (Paymnt2Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt2Amt4.Text == "0")||(Paymnt2Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt2Amt4.Text == "0") || (Paymnt2Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt4.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt2Amt5.Text == "0")||(Paymnt2Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt2Amt5.Text == "0") || (Paymnt2Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt5.Text = "";
			}

// 管理番号 B15940 From		
			//if((Paymnt2Amt6.Text == "0")||(Paymnt2Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt2Amt6.Text == "0") || (Paymnt2Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt2Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt2Amt7.Text == "0")||(Paymnt2Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt2Amt7.Text == "0") || (Paymnt2Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt2Amt8.Text == "0")||(Paymnt2Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt2Amt8.Text == "0") || (Paymnt2Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt2Amt9.Text == "0")||(Paymnt2Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt2Amt9.Text == "0") || (Paymnt2Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt2Amt10.Text == "0")||(Paymnt2Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt2Amt10.Text == "0") || (Paymnt2Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt2Amt11.Text == "0")||(Paymnt2Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt2Amt11.Text == "0") || (Paymnt2Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt2Amt12.Text == "0")||(Paymnt2Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt2Amt12.Text == "0") || (Paymnt2Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt2Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt3Amt1.Text == "0")||(Paymnt3Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt3Amt1.Text == "0") || (Paymnt3Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt3Amt2.Text == "0")||(Paymnt3Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt3Amt2.Text == "0") || (Paymnt3Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt3Amt3.Text == "0")||(Paymnt3Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt3Amt3.Text == "0") || (Paymnt3Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt3Amt4.Text == "0")||(Paymnt3Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt3Amt4.Text == "0") || (Paymnt3Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt3Amt5.Text == "0")||(Paymnt3Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt3Amt5.Text == "0") || (Paymnt3Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt3Amt6.Text == "0")||(Paymnt3Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt3Amt6.Text == "0") || (Paymnt3Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt3Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From			
//			//if((Paymnt3Amt7.Text == "0")||(Paymnt3Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt3Amt7.Text == "0")||(Paymnt3Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt3Amt8.Text == "0")||(Paymnt3Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt3Amt8.Text == "0")||(Paymnt3Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt3Amt9.Text == "0")||(Paymnt3Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt3Amt9.Text == "0") || (Paymnt3Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt3Amt10.Text == "0")||(Paymnt3Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt3Amt10.Text == "0")||(Paymnt3Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt3Amt11.Text == "0")||(Paymnt3Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt3Amt11.Text == "0")||(Paymnt3Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt3Amt12.Text == "0")||(Paymnt3Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt3Amt12.Text == "0")||(Paymnt3Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt3Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt4Amt1.Text == "0")||(Paymnt4Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt4Amt1.Text == "0") || (Paymnt4Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt4Amt2.Text == "0")||(Paymnt4Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt4Amt2.Text == "0") || (Paymnt4Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt4Amt3.Text == "0")||(Paymnt4Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt4Amt3.Text == "0") || (Paymnt4Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt4Amt4.Text == "0")||(Paymnt4Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt4Amt4.Text == "0") || (Paymnt4Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt4Amt5.Text == "0")||(Paymnt4Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt4Amt5.Text == "0") || (Paymnt4Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt4Amt6.Text == "0")||(Paymnt4Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt4Amt6.Text == "0") || (Paymnt4Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt4Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt4Amt7.Text == "0")||(Paymnt4Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt4Amt7.Text == "0") || (Paymnt4Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt4Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt4Amt8.Text == "0")||(Paymnt4Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt4Amt8.Text == "0")||(Paymnt4Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt4Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt4Amt9.Text == "0")||(Paymnt4Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt4Amt9.Text == "0") || (Paymnt4Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt4Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt4Amt10.Text == "0")||(Paymnt4Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt4Amt10.Text == "0")||(Paymnt4Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt4Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt4Amt11.Text == "0")||(Paymnt4Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt4Amt11.Text == "0")||(Paymnt4Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt4Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt4Amt12.Text == "0")||(Paymnt4Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt4Amt12.Text == "0")||(Paymnt4Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 From			
//			{
//				Paymnt4Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt5Amt1.Text == "0")||(Paymnt5Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt5Amt1.Text == "0") || (Paymnt5Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt5Amt2.Text == "0")||(Paymnt5Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt5Amt2.Text == "0") || (Paymnt5Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt5Amt3.Text == "0")||(Paymnt5Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt5Amt3.Text == "0") || (Paymnt5Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt5Amt4.Text == "0")||(Paymnt5Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt5Amt4.Text == "0") || (Paymnt5Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt5Amt5.Text == "0")||(Paymnt5Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt5Amt5.Text == "0") || (Paymnt5Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt5Amt6.Text == "0")||(Paymnt5Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt5Amt6.Text == "0") || (Paymnt5Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt5Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt5Amt7.Text == "0")||(Paymnt5Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt5Amt7.Text == "0") || (Paymnt5Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt5Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt5Amt8.Text == "0")||(Paymnt5Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt5Amt8.Text == "0")||(Paymnt5Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt5Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt5Amt9.Text == "0")||(Paymnt5Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt5Amt9.Text == "0") || (Paymnt5Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt5Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt5Amt10.Text == "0")||(Paymnt5Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt5Amt10.Text == "0") || (Paymnt5Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt5Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt5Amt11.Text == "0")||(Paymnt5Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt5Amt11.Text == "0") || (Paymnt5Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt5Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt5Amt12.Text == "0")||(Paymnt5Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt5Amt12.Text == "0") || (Paymnt5Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 From			
//			{
//				Paymnt5Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt6Amt1.Text == "0")||(Paymnt6Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt6Amt1.Text == "0") || (Paymnt6Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt6Amt2.Text == "0")||(Paymnt6Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt6Amt2.Text == "0") || (Paymnt6Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt6Amt3.Text == "0")||(Paymnt6Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt6Amt3.Text == "0") || (Paymnt6Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt6Amt4.Text == "0")||(Paymnt6Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt6Amt4.Text == "0") || (Paymnt6Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt6Amt5.Text == "0")||(Paymnt6Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt6Amt5.Text == "0") || (Paymnt6Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt6Amt6.Text == "0")||(Paymnt6Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt6Amt6.Text == "0") || (Paymnt6Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt6Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt6Amt7.Text == "0")||(Paymnt6Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt6Amt7.Text == "0") || (Paymnt6Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt6Amt8.Text == "0")||(Paymnt6Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt6Amt8.Text == "0") || (Paymnt6Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt6Amt9.Text == "0")||(Paymnt6Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt6Amt9.Text == "0")||(Paymnt6Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt6Amt10.Text == "0")||(Paymnt6Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt6Amt10.Text == "0")||(Paymnt6Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt6Amt11.Text == "0")||(Paymnt6Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt6Amt11.Text == "0")||(Paymnt6Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt11.Text = "";
//			}
//// 管理番号 B15940 From	
//			//if((Paymnt6Amt12.Text == "0")||(Paymnt6Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt6Amt12.Text == "0") || (Paymnt6Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt6Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt7Amt1.Text == "0")||(Paymnt7Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt7Amt1.Text == "0") || (Paymnt7Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt7Amt2.Text == "0")||(Paymnt7Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt7Amt2.Text == "0") || (Paymnt7Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt7Amt3.Text == "0")||(Paymnt7Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt7Amt3.Text == "0") || (Paymnt7Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt7Amt4.Text == "0")||(Paymnt7Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt7Amt4.Text == "0") || (Paymnt7Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt7Amt5.Text == "0")||(Paymnt7Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt7Amt5.Text == "0") || (Paymnt7Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt7Amt6.Text == "0")||(Paymnt7Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt7Amt6.Text == "0") || (Paymnt7Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt7Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt7Amt7.Text == "0")||(Paymnt7Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt7Amt7.Text == "0")||(Paymnt7Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt7Amt8.Text == "0")||(Paymnt7Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt7Amt8.Text == "0")||(Paymnt7Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt8.Text = "";
//			}
//// 管理番号 B15940 From
//			//if((Paymnt7Amt9.Text == "0")||(Paymnt7Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt7Amt9.Text == "0") || (Paymnt7Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt7Amt10.Text == "0")||(Paymnt7Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt7Amt10.Text == "0") || (Paymnt7Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt7Amt11.Text == "0")||(Paymnt7Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt7Amt11.Text == "0")||(Paymnt7Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt7Amt12.Text == "0")||(Paymnt7Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt7Amt12.Text == "0")||(Paymnt7Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt7Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt8Amt1.Text == "0")||(Paymnt8Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt8Amt1.Text == "0") || (Paymnt8Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt8Amt2.Text == "0")||(Paymnt8Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt8Amt2.Text == "0") || (Paymnt8Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt8Amt3.Text == "0")||(Paymnt8Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt8Amt3.Text == "0") || (Paymnt8Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt8Amt4.Text == "0")||(Paymnt8Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt8Amt4.Text == "0") || (Paymnt8Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt8Amt5.Text == "0")||(Paymnt8Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt8Amt5.Text == "0") || (Paymnt8Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt8Amt6.Text == "0")||(Paymnt8Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt8Amt6.Text == "0") || (Paymnt8Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt8Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt8Amt7.Text == "0")||(Paymnt8Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt8Amt7.Text == "0") || (Paymnt8Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt8Amt8.Text == "0")||(Paymnt8Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt8Amt8.Text == "0") || (Paymnt8Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt8Amt9.Text == "0")||(Paymnt8Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt8Amt9.Text == "0") || (Paymnt8Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt8Amt10.Text == "0")||(Paymnt8Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt8Amt10.Text == "0") || (Paymnt8Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt8Amt11.Text == "0")||(Paymnt8Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt8Amt11.Text == "0")||(Paymnt8Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt8Amt12.Text == "0")||(Paymnt8Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt8Amt12.Text == "0") || (Paymnt8Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt8Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt9Amt1.Text == "0")||(Paymnt9Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt9Amt1.Text == "0") || (Paymnt9Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt9Amt2.Text == "0")||(Paymnt9Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt9Amt2.Text == "0") || (Paymnt9Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt9Amt3.Text == "0")||(Paymnt9Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt9Amt3.Text == "0") || (Paymnt9Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt9Amt4.Text == "0")||(Paymnt9Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt9Amt4.Text == "0") || (Paymnt9Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt4.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt9Amt5.Text == "0")||(Paymnt9Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt9Amt5.Text == "0") || (Paymnt9Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt9Amt6.Text == "0")||(Paymnt9Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt9Amt6.Text == "0") || (Paymnt9Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt9Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt9Amt7.Text == "0")||(Paymnt9Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt9Amt7.Text == "0")||(Paymnt9Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt9Amt8.Text == "0")||(Paymnt9Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt9Amt8.Text == "0")||(Paymnt9Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt9Amt9.Text == "0")||(Paymnt9Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt9Amt9.Text == "0")||(Paymnt9Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt9Amt10.Text == "0")||(Paymnt9Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt9Amt10.Text == "0")||(Paymnt9Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From		
//			//if((Paymnt9Amt11.Text == "0")||(Paymnt9Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt9Amt11.Text == "0") || (Paymnt9Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt9Amt12.Text == "0")||(Paymnt9Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt9Amt12.Text == "0") || (Paymnt9Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt9Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt10Amt1.Text == "0")||(Paymnt10Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt10Amt1.Text == "0") || (Paymnt10Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt10Amt2.Text == "0")||(Paymnt10Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt10Amt2.Text == "0") || (Paymnt10Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt10Amt3.Text == "0")||(Paymnt10Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt10Amt3.Text == "0") || (Paymnt10Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt10Amt4.Text == "0")||(Paymnt10Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt10Amt4.Text == "0") || (Paymnt10Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt10Amt5.Text == "0")||(Paymnt10Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt10Amt5.Text == "0") || (Paymnt10Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt10Amt6.Text == "0")||(Paymnt10Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt10Amt6.Text == "0") || (Paymnt10Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt10Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt10Amt7.Text == "0")||(Paymnt10Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt10Amt7.Text == "0") || (Paymnt10Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt10Amt8.Text == "0")||(Paymnt10Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt10Amt8.Text == "0") || (Paymnt10Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt10Amt9.Text == "0")||(Paymnt10Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt10Amt9.Text == "0") || (Paymnt10Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt10Amt10.Text == "0")||(Paymnt10Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt10Amt10.Text == "0") || (Paymnt10Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt10Amt11.Text == "0")||(Paymnt10Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt10Amt11.Text == "0")||(Paymnt10Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt10Amt12.Text == "0")||(Paymnt10Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt10Amt12.Text == "0") || (Paymnt10Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt10Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From			
			//if((Paymnt11Amt1.Text == "0")||(Paymnt11Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt11Amt1.Text == "0") || (Paymnt11Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt1.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt11Amt2.Text == "0")||(Paymnt11Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt11Amt2.Text == "0") || (Paymnt11Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt2.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt11Amt3.Text == "0")||(Paymnt11Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt11Amt3.Text == "0") || (Paymnt11Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt3.Text = "";
			}

// 管理番号 B15940 From	
			//if((Paymnt11Amt4.Text == "0")||(Paymnt11Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt11Amt4.Text == "0") || (Paymnt11Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt11Amt5.Text == "0")||(Paymnt11Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt11Amt5.Text == "0") || (Paymnt11Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt11Amt6.Text == "0")||(Paymnt11Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt11Amt6.Text == "0") || (Paymnt11Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt11Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From			
//			//if((Paymnt11Amt7.Text == "0")||(Paymnt11Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt11Amt7.Text == "0") || (Paymnt11Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt11Amt8.Text == "0")||(Paymnt11Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt11Amt8.Text == "0") || (Paymnt11Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt11Amt9.Text == "0")||(Paymnt11Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt11Amt9.Text == "0") || (Paymnt11Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt11Amt10.Text == "0")||(Paymnt11Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt11Amt10.Text == "0") || (Paymnt11Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt11Amt11.Text == "0")||(Paymnt11Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt11Amt11.Text == "0") || (Paymnt11Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt11Amt12.Text == "0")||(Paymnt11Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt11Amt12.Text == "0")||(Paymnt11Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt11Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt12Amt1.Text == "0")||(Paymnt12Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt12Amt1.Text == "0") || (Paymnt12Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt12Amt2.Text == "0")||(Paymnt12Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt12Amt2.Text == "0") || (Paymnt12Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt2.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt12Amt3.Text == "0")||(Paymnt12Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt12Amt3.Text == "0") || (Paymnt12Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt12Amt4.Text == "0")||(Paymnt12Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt12Amt4.Text == "0") || (Paymnt12Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt12Amt5.Text == "0")||(Paymnt12Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt12Amt5.Text == "0") || (Paymnt12Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt12Amt6.Text == "0")||(Paymnt12Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt12Amt6.Text == "0") || (Paymnt12Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt12Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt12Amt7.Text == "0")||(Paymnt12Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt12Amt7.Text == "0") || (Paymnt12Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt12Amt8.Text == "0")||(Paymnt12Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt12Amt8.Text == "0") || (Paymnt12Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt12Amt9.Text == "0")||(Paymnt12Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt12Amt9.Text == "0") || (Paymnt12Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From		
//			//if((Paymnt12Amt10.Text == "0")||(Paymnt12Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt12Amt10.Text == "0")||(Paymnt12Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt12Amt11.Text == "0")||(Paymnt12Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt12Amt11.Text == "0") || (Paymnt12Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt12Amt12.Text == "0")||(Paymnt12Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt12Amt12.Text == "0") || (Paymnt12Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt12Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt13Amt1.Text == "0")||(Paymnt13Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt13Amt1.Text == "0") || (Paymnt13Amt1.Text == "0.00")) && (PaymntBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt13Amt2.Text == "0")||(Paymnt13Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt13Amt2.Text == "0") || (Paymnt13Amt2.Text == "0.00")) && (PaymntBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt13Amt3.Text == "0")||(Paymnt13Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt13Amt3.Text == "0") || (Paymnt13Amt3.Text == "0.00")) && (PaymntBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt13Amt4.Text == "0")||(Paymnt13Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt13Amt4.Text == "0") || (Paymnt13Amt4.Text == "0.00")) && (PaymntBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt4.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt13Amt5.Text == "0")||(Paymnt13Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt13Amt5.Text == "0") || (Paymnt13Amt5.Text == "0.00")) && (PaymntBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt13Amt6.Text == "0")||(Paymnt13Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt13Amt6.Text == "0") || (Paymnt13Amt6.Text == "0.00")) && (PaymntBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt13Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt13Amt7.Text == "0")||(Paymnt13Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt13Amt7.Text == "0") || (Paymnt13Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt13Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt13Amt8.Text == "0")||(Paymnt13Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt13Amt8.Text == "0")||(Paymnt13Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt13Amt8.Text = "";
//			}
//		
//// 管理番号 B15940 From
//			//if((Paymnt13Amt9.Text == "0")||(Paymnt13Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt13Amt9.Text == "0") || (Paymnt13Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt13Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt13Amt10.Text == "0")||(Paymnt13Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt13Amt10.Text == "0")||(Paymnt13Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
/// 管理番号 B15940 To
//			{
//				Paymnt13Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt13Amt11.Text == "0")||(Paymnt13Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt13Amt11.Text == "0") || (Paymnt13Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt13Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Paymnt13Amt12.Text == "0")||(Paymnt13Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt13Amt12.Text == "0") || (Paymnt13Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt13Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt14Amt1.Text == "0")||(Paymnt14Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt14Amt1.Text == "0") || (Paymnt14Amt1.Text == "0.00")) && (PaymntBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt14Amt2.Text == "0")||(Paymnt14Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt14Amt2.Text == "0") || (Paymnt14Amt2.Text == "0.00")) && (PaymntBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt14Amt3.Text == "0")||(Paymnt14Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt14Amt3.Text == "0") || (Paymnt14Amt3.Text == "0.00")) && (PaymntBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt14Amt4.Text == "0")||(Paymnt14Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt14Amt4.Text == "0") || (Paymnt14Amt4.Text == "0.00")) && (PaymntBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt14Amt5.Text == "0")||(Paymnt14Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt14Amt5.Text == "0") || (Paymnt14Amt5.Text == "0.00")) && (PaymntBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt5.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt14Amt6.Text == "0")||(Paymnt14Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt14Amt6.Text == "0") || (Paymnt14Amt6.Text == "0.00")) && (PaymntBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt14Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From			
//			//if((Paymnt14Amt7.Text == "0")||(Paymnt14Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt14Amt7.Text == "0")||(Paymnt14Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt14Amt8.Text == "0")||(Paymnt14Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt14Amt8.Text == "0")||(Paymnt14Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt14Amt9.Text == "0")||(Paymnt14Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt14Amt9.Text == "0")||(Paymnt14Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt14Amt10.Text == "0")||(Paymnt14Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt14Amt10.Text == "0") || (Paymnt14Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt14Amt11.Text == "0")||(Paymnt14Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt14Amt11.Text == "0") || (Paymnt14Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt14Amt12.Text == "0")||(Paymnt14Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt14Amt12.Text == "0") || (Paymnt14Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt14Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt15Amt1.Text == "0")||(Paymnt15Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt15Amt1.Text == "0") || (Paymnt15Amt1.Text == "0.00")) && (PaymntBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt15Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt15Amt2.Text == "0")||(Paymnt15Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt15Amt2.Text == "0") || (Paymnt15Amt2.Text == "0.00")) && (PaymntBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt15Amt2.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt15Amt3.Text == "0")||(Paymnt15Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt15Amt3.Text == "0") || (Paymnt15Amt3.Text == "0.00")) && (PaymntBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt15Amt3.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt15Amt4.Text == "0")||(Paymnt15Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt15Amt4.Text == "0") || (Paymnt15Amt4.Text == "0.00")) && (PaymntBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To	
			{
				Paymnt15Amt4.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt15Amt5.Text == "0")||(Paymnt15Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt15Amt5.Text == "0") || (Paymnt15Amt5.Text == "0.00")) && (PaymntBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt15Amt5.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt15Amt6.Text == "0")||(Paymnt15Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt15Amt6.Text == "0") || (Paymnt15Amt6.Text == "0.00")) && (PaymntBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt15Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt15Amt7.Text == "0")||(Paymnt15Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt15Amt7.Text == "0") || (Paymnt15Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt15Amt8.Text == "0")||(Paymnt15Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt15Amt8.Text == "0") || (Paymnt15Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt15Amt9.Text == "0")||(Paymnt15Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt15Amt9.Text == "0")||(Paymnt15Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt15Amt10.Text == "0")||(Paymnt15Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt15Amt10.Text == "0")||(Paymnt15Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Paymnt15Amt11.Text == "0")||(Paymnt15Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt15Amt11.Text == "0")||(Paymnt15Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt11.Text = "";
//			}
//	
//// 管理番号 B15940 From
//			//if((Paymnt15Amt12.Text == "0")||(Paymnt15Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt15Amt12.Text == "0")||(Paymnt15Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt15Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Paymnt16Amt1.Text == "0")||(Paymnt16Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((Paymnt16Amt1.Text == "0") || (Paymnt16Amt1.Text == "0.00")) && (PaymntBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt16Amt2.Text == "0")||(Paymnt16Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((Paymnt16Amt2.Text == "0") || (Paymnt16Amt2.Text == "0.00")) && (PaymntBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt16Amt3.Text == "0")||(Paymnt16Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((Paymnt16Amt3.Text == "0") || (Paymnt16Amt3.Text == "0.00")) && (PaymntBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt16Amt4.Text == "0")||(Paymnt16Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((Paymnt16Amt4.Text == "0") || (Paymnt16Amt4.Text == "0.00")) && (PaymntBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Paymnt16Amt5.Text == "0")||(Paymnt16Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((Paymnt16Amt5.Text == "0") || (Paymnt16Amt5.Text == "0.00")) && (PaymntBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt5.Text = "";
			}

// 管理番号 B15940 From			
			//if((Paymnt16Amt6.Text == "0")||(Paymnt16Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((Paymnt16Amt6.Text == "0") || (Paymnt16Amt6.Text == "0.00")) && (PaymntBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Paymnt16Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt16Amt7.Text == "0")||(Paymnt16Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((Paymnt16Amt7.Text == "0") || (Paymnt16Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt16Amt8.Text == "0")||(Paymnt16Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((Paymnt16Amt8.Text == "0") || (Paymnt16Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt16Amt9.Text == "0")||(Paymnt16Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((Paymnt16Amt9.Text == "0")||(Paymnt16Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt16Amt10.Text == "0")||(Paymnt16Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((Paymnt16Amt10.Text == "0") || (Paymnt16Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt16Amt11.Text == "0")||(Paymnt16Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt16Amt11.Text == "0") || (Paymnt16Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt16Amt12.Text == "0")||(Paymnt16Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt16Amt12.Text == "0")||(Paymnt16Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt16Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
//			if(((Paymnt18Amt1.Text == "0") || (Paymnt18Amt1.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))			
//			{
//				Paymnt18Amt1.Text = "";
//			}
//
//			if(((Paymnt18Amt2.Text == "0") || (Paymnt18Amt2.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))			
//			{
//				Paymnt18Amt2.Text = "";
//			}
//
//			if(((Paymnt18Amt3.Text == "0")||(Paymnt18Amt3.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//			{
//				Paymnt18Amt3.Text = "";
//			}
//
//			if(((Paymnt18Amt4.Text == "0") || (Paymnt18Amt4.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))		
//			{
//				Paymnt18Amt4.Text = "";
//			}
//			
//			if(((Paymnt18Amt5.Text == "0")||(Paymnt18Amt5.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//			{
//				Paymnt18Amt5.Text = "";
//			}
//
//			if(((Paymnt18Amt6.Text == "0")||(Paymnt18Amt6.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))			
//			{
//				Paymnt18Amt6.Text = "";
//			}
//
//			if(((Paymnt18Amt7.Text == "0") || (Paymnt18Amt7.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))		
//			{
//				Paymnt18Amt7.Text = "";
//			}
//
//			if(((Paymnt18Amt8.Text == "0") || (Paymnt18Amt8.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))		
//			{
//				Paymnt18Amt8.Text = "";
//			}
//
//			if(((Paymnt18Amt9.Text == "0") || (Paymnt18Amt9.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))			
//			{
//				Paymnt18Amt9.Text = "";
//			}
//
//			if(((Paymnt18Amt10.Text == "0") || (Paymnt18Amt10.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))	
//			{
//				Paymnt18Amt10.Text = "";
//			}
//
//			if(((Paymnt18Amt11.Text == "0") || (Paymnt18Amt11.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//		
//			{
//				Paymnt18Amt11.Text = "";
//			}
//			if(((Paymnt18Amt12.Text == "0") || (Paymnt18Amt1.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))		
//			{
//				Paymnt18Amt12.Text = "";
//			}
// 管理番号 B15940 To



			//給与控除、賞与控除、前職等修正分下段、年末調整控除の空白処理
// 管理番号 B15940 From
			//if((Ded1Amt1.Text == "0")||(Ded1Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded1Amt1.Text == "0") || (Ded1Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded1Amt2.Text == "0")||(Ded1Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded1Amt2.Text == "0") || (Ded1Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded1Amt3.Text == "0")||(Ded1Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded1Amt3.Text == "0") || (Ded1Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded1Amt4.Text == "0")||(Ded1Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded1Amt4.Text == "0") || (Ded1Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded1Amt5.Text == "0")||(Ded1Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded1Amt5.Text == "0") || (Ded1Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt5.Text = "";
			}

// 管理番号 B15940 From		
			//if((Ded1Amt6.Text == "0")||(Ded1Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded1Amt6.Text == "0") || (Ded1Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded1Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded1Amt7.Text == "0")||(Ded1Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded1Amt7.Text == "0")||(Ded1Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded1Amt8.Text == "0")||(Ded1Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded1Amt8.Text == "0") || (Ded1Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded1Amt9.Text == "0")||(Ded1Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded1Amt9.Text == "0") || (Ded1Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded1Amt10.Text == "0")||(Ded1Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded1Amt10.Text == "0") || (Ded1Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded1Amt11.Text == "0")||(Ded1Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded1Amt11.Text == "0") || (Ded1Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded1Amt12.Text == "0")||(Ded1Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded1Amt12.Text == "0") || (Ded1Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded1Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded2Amt1.Text == "0")||(Ded2Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded2Amt1.Text == "0") || (Ded2Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded2Amt2.Text == "0")||(Ded2Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded2Amt2.Text == "0") || (Ded2Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded2Amt3.Text == "0")||(Ded2Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded2Amt3.Text == "0") || (Ded2Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded2Amt4.Text == "0")||(Ded2Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded2Amt4.Text == "0") || (Ded2Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded2Amt5.Text == "0")||(Ded2Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded2Amt5.Text == "0") || (Ded2Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded2Amt6.Text == "0")||(Ded2Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded2Amt6.Text == "0") || (Ded2Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded2Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded2Amt7.Text == "0")||(Ded2Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded2Amt7.Text == "0") || (Ded2Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded2Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded2Amt8.Text == "0")||(Ded2Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded2Amt8.Text == "0") || (Ded2Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded2Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded2Amt9.Text == "0")||(Ded2Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded2Amt9.Text == "0") || (Ded2Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded2Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded2Amt10.Text == "0")||(Ded2Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded2Amt10.Text == "0") || (Ded2Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded2Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded2Amt11.Text == "0")||(Ded2Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded2Amt11.Text == "0") || (Ded2Amt11.Text == "0.00")) &&(DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded2Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded2Amt12.Text == "0")||(Ded2Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded2Amt12.Text == "0") || (Ded2Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 From			
//			{
//				Ded2Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded3Amt1.Text == "0")||(Ded3Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded3Amt1.Text == "0") || (Ded3Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt1.Text = "";
			}

// 管理番号 B15940 From	
			//if((Ded3Amt2.Text == "0")||(Ded3Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded3Amt2.Text == "0") || (Ded3Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded3Amt3.Text == "0")||(Ded3Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded3Amt3.Text == "0") || (Ded3Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded3Amt4.Text == "0")||(Ded3Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded3Amt4.Text == "0") || (Ded3Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded3Amt5.Text == "0")||(Ded3Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded3Amt5.Text == "0") || (Ded3Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded3Amt6.Text == "0")||(Ded3Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded3Amt6.Text == "0") || (Ded3Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded3Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded3Amt7.Text == "0")||(Ded3Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded3Amt7.Text == "0")||(Ded3Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt7.Text = "";
//			}
//// 管理番号 B15940 From
//			//if((Ded3Amt8.Text == "0")||(Ded3Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded3Amt8.Text == "0")||(Ded3Amt8.Text == "0.00"))&&(DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt8.Text = "";
//			}
//// 管理番号 B15940 From
//			//if((Ded3Amt9.Text == "0")||(Ded3Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded3Amt9.Text == "0") || (Ded3Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded3Amt10.Text == "0")||(Ded3Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded3Amt10.Text == "0")||(Ded3Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded3Amt11.Text == "0")||(Ded3Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded3Amt11.Text == "0")||(Ded3Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded3Amt12.Text == "0")||(Ded3Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded3Amt12.Text == "0")||(Ded3Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded3Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From			
			//if((Ded4Amt1.Text == "0")||(Ded4Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded4Amt1.Text == "0") || (Ded4Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt1.Text = "";
			}
// 管理番号 B15940 From			
			//if((Ded4Amt2.Text == "0")||(Ded4Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded4Amt2.Text == "0") || (Ded4Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded4Amt3.Text == "0")||(Ded4Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded4Amt3.Text == "0") || (Ded4Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded4Amt4.Text == "0")||(Ded4Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded4Amt4.Text == "0") || (Ded4Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt4.Text = "";
			}

// 管理番号 B15940 From			
			//if((Ded4Amt5.Text == "0")||(Ded4Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded4Amt5.Text == "0") || (Ded4Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt5.Text = "";
			}

// 管理番号 B15940 From			
			//if((Ded4Amt6.Text == "0")||(Ded4Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded4Amt6.Text == "0") || (Ded4Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded4Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded4Amt7.Text == "0")||(Ded4Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded4Amt7.Text == "0") || (Ded4Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded4Amt8.Text == "0")||(Ded4Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded4Amt8.Text == "0")||(Ded4Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded4Amt9.Text == "0")||(Ded4Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded4Amt9.Text == "0") || (Ded4Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded4Amt10.Text == "0")||(Ded4Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded4Amt10.Text == "0") || (Ded4Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt10.Text = "";
//			}
//	
//// 管理番号 B15940 From
//			//if((Ded4Amt11.Text == "0")||(Ded4Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded4Amt11.Text == "0") || (Ded4Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded4Amt12.Text == "0")||(Ded4Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded4Amt12.Text == "0") || (Ded4Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded4Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded5Amt1.Text == "0")||(Ded5Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded5Amt1.Text == "0") || (Ded5Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded5Amt2.Text == "0")||(Ded5Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded5Amt2.Text == "0") || (Ded5Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded5Amt3.Text == "0")||(Ded5Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded5Amt3.Text == "0") || (Ded5Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded5Amt4.Text == "0")||(Ded5Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded5Amt4.Text == "0") || (Ded5Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded5Amt5.Text == "0")||(Ded5Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded5Amt5.Text == "0") || (Ded5Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded5Amt6.Text == "0")||(Ded5Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded5Amt6.Text == "0") || (Ded5Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded5Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded5Amt7.Text == "0")||(Ded5Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded5Amt7.Text == "0") || (Ded5Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded5Amt8.Text == "0")||(Ded5Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded5Amt8.Text == "0")||(Ded5Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded5Amt9.Text == "0")||(Ded5Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded5Amt9.Text == "0")||(Ded5Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From			
//			//if((Ded5Amt10.Text == "0")||(Ded5Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded5Amt10.Text == "0")||(Ded5Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded5Amt11.Text == "0")||(Ded5Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded5Amt11.Text == "0") || (Ded5Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded5Amt12.Text == "0")||(Ded5Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded5Amt12.Text == "0") || (Ded5Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded5Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded6Amt1.Text == "0")||(Ded6Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded6Amt1.Text == "0") || (Ded6Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded6Amt2.Text == "0")||(Ded6Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded6Amt2.Text == "0") || (Ded6Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded6Amt3.Text == "0")||(Ded6Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded6Amt3.Text == "0") || (Ded6Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded6Amt4.Text == "0")||(Ded6Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded6Amt4.Text == "0") || (Ded6Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded6Amt5.Text == "0")||(Ded6Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded6Amt5.Text == "0") || (Ded6Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded6Amt6.Text == "0")||(Ded6Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded6Amt6.Text == "0") || (Ded6Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded6Amt6.Text = "";
			}
// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
////			if((Ded6Amt7.Text == "0")||(Ded6Amt7.Text == "0.00")&&// 管理番号 B15940 FromdZeroFlg7.Text == "0"))
//			if(((Ded6Amt7.Text == "0")||(Ded6Amt7.Text == "0.00"))&&(DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded6Amt8.Text == "0")||(Ded6Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded6Amt8.Text == "0") || (Ded6Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded6Amt9.Text == "0")||(Ded6Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded6Amt9.Text == "0")||(Ded6Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded6Amt10.Text == "0")||(Ded6Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded6Amt10.Text == "0")||(Ded6Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From		
//			//if((Ded6Amt11.Text == "0")||(Ded6Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded6Amt11.Text == "0")||(Ded6Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded6Amt12.Text == "0")||(Ded6Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded6Amt12.Text == "0")||(Ded6Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded6Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded7Amt1.Text == "0")||(Ded7Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded7Amt1.Text == "0") || (Ded7Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded7Amt2.Text == "0")||(Ded7Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded7Amt2.Text == "0") || (Ded7Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded7Amt3.Text == "0")||(Ded7Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded7Amt3.Text == "0") || (Ded7Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded7Amt4.Text == "0")||(Ded7Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded7Amt4.Text == "0") || (Ded7Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded7Amt5.Text == "0")||(Ded7Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded7Amt5.Text == "0") || (Ded7Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded7Amt6.Text == "0")||(Ded7Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded7Amt6.Text == "0") || (Ded7Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded7Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded7Amt7.Text == "0")||(Ded7Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded7Amt7.Text == "0") || (Ded7Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded7Amt8.Text == "0")||(Ded7Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded7Amt8.Text == "0") || (Ded7Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded7Amt9.Text == "0")||(Ded7Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded7Amt9.Text == "0") || (Ded7Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded7Amt10.Text == "0")||(Ded7Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded7Amt10.Text == "0") || (Ded7Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded7Amt11.Text == "0")||(Ded7Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded7Amt11.Text == "0")||(Ded7Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded7Amt12.Text == "0")||(Ded7Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded7Amt12.Text == "0") || (Ded7Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded7Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded8Amt1.Text == "0")||(Ded8Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded8Amt1.Text == "0") || (Ded8Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded8Amt2.Text == "0")||(Ded8Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded8Amt2.Text == "0") || (Ded8Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded8Amt3.Text == "0")||(Ded8Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded8Amt3.Text == "0") || (Ded8Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded8Amt4.Text == "0")||(Ded8Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded8Amt4.Text == "0") || (Ded8Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded8Amt5.Text == "0")||(Ded8Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded8Amt5.Text == "0") || (Ded8Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded8Amt6.Text == "0")||(Ded8Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded8Amt6.Text == "0") || (Ded8Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded8Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded8Amt7.Text == "0")||(Ded8Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded8Amt7.Text == "0") || (Ded8Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded8Amt8.Text == "0")||(Ded8Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded8Amt8.Text == "0")||(Ded8Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded8Amt9.Text == "0")||(Ded8Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded8Amt9.Text == "0") || (Ded8Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded8Amt10.Text == "0")||(Ded8Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded8Amt10.Text == "0") || (Ded8Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded8Amt11.Text == "0")||(Ded8Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded8Amt11.Text == "0") || (Ded8Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded8Amt12.Text == "0")||(Ded8Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded8Amt12.Text == "0") || (Ded8Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded8Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded9Amt1.Text == "0")||(Ded9Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded9Amt1.Text == "0") || (Ded9Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded9Amt2.Text == "0")||(Ded9Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded9Amt2.Text == "0") || (Ded9Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded9Amt3.Text == "0")||(Ded9Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded9Amt3.Text == "0") || (Ded9Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded9Amt4.Text == "0")||(Ded9Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded9Amt4.Text == "0") || (Ded9Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded9Amt5.Text == "0")||(Ded9Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded9Amt5.Text == "0") || (Ded9Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded9Amt6.Text == "0")||(Ded9Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded9Amt6.Text == "0") || (Ded9Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded9Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded9Amt7.Text == "0")||(Ded9Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded9Amt7.Text == "0")||(Ded9Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded9Amt8.Text == "0")||(Ded9Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded9Amt8.Text == "0") || (Ded9Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded9Amt9.Text == "0")||(Ded9Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded9Amt9.Text == "0")||(Ded9Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded9Amt10.Text == "0")||(Ded9Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded9Amt10.Text == "0")||(Ded9Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded9Amt11.Text == "0")||(Ded9Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded9Amt11.Text == "0") || (Ded9Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded9Amt12.Text == "0")||(Ded9Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded9Amt12.Text == "0") || (Ded9Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded9Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded10Amt1.Text == "0")||(Ded10Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded10Amt1.Text == "0") || (Ded10Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded10Amt2.Text == "0")||(Ded10Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded10Amt2.Text == "0") || (Ded10Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded10Amt3.Text == "0")||(Ded10Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded10Amt3.Text == "0") || (Ded10Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded10Amt4.Text == "0")||(Ded10Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded10Amt4.Text == "0") || (Ded10Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded10Amt5.Text == "0")||(Ded10Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded10Amt5.Text == "0") || (Ded10Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded10Amt6.Text == "0")||(Ded10Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded10Amt6.Text == "0") || (Ded10Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded10Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded10Amt7.Text == "0")||(Ded10Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded10Amt7.Text == "0")||(Ded10Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded10Amt8.Text == "0")||(Ded10Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded10Amt8.Text == "0") || (Ded10Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded10Amt9.Text == "0")||(Ded10Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded10Amt9.Text == "0")||(Ded10Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Ded10Amt10.Text == "0")||(Ded10Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded10Amt10.Text == "0") || (Ded10Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded10Amt11.Text == "0")||(Ded10Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded10Amt11.Text == "0") || (Ded10Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded10Amt12.Text == "0")||(Ded10Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded10Amt12.Text == "0")||(Ded10Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded10Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded11Amt1.Text == "0")||(Ded11Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded11Amt1.Text == "0") || (Ded11Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded11Amt2.Text == "0")||(Ded11Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded11Amt2.Text == "0") || (Ded11Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded11Amt3.Text == "0")||(Ded11Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded11Amt3.Text == "0") || (Ded11Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded11Amt4.Text == "0")||(Ded11Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded11Amt4.Text == "0") || (Ded11Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded11Amt5.Text == "0")||(Ded11Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded11Amt5.Text == "0") || (Ded11Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded11Amt6.Text == "0")||(Ded11Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded11Amt6.Text == "0") || (Ded11Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded11Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded11Amt7.Text == "0")||(Ded11Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded11Amt7.Text == "0")||(Ded11Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded11Amt8.Text == "0")||(Ded11Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded11Amt8.Text == "0") || (Ded11Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded11Amt9.Text == "0")||(Ded11Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded11Amt9.Text == "0") || (Ded11Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded11Amt10.Text == "0")||(Ded11Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded11Amt10.Text == "0")||(Ded11Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded11Amt11.Text == "0")||(Ded11Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded11Amt11.Text == "0")||(Ded11Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded11Amt12.Text == "0")||(Ded11Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded11Amt12.Text == "0")||(Ded11Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded11Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded12Amt1.Text == "0")||(Ded12Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded12Amt1.Text == "0") || (Ded12Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded12Amt2.Text == "0")||(Ded12Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded12Amt2.Text == "0") || (Ded12Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded12Amt3.Text == "0")||(Ded12Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded12Amt3.Text == "0") || (Ded12Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded12Amt4.Text == "0")||(Ded12Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded12Amt4.Text == "0") || (Ded12Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded12Amt5.Text == "0")||(Ded12Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded12Amt5.Text == "0") || (Ded12Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded12Amt6.Text == "0")||(Ded12Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded12Amt6.Text == "0") || (Ded12Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded12Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded12Amt7.Text == "0")||(Ded12Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded12Amt7.Text == "0")||(Ded12Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded12Amt8.Text == "0")||(Ded12Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded12Amt8.Text == "0")||(Ded12Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded12Amt9.Text == "0")||(Ded12Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded12Amt9.Text == "0") || (Ded12Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded12Amt10.Text == "0")||(Ded12Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded12Amt10.Text == "0") || (Ded12Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded12Amt11.Text == "0")||(Ded12Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded12Amt11.Text == "0") || (Ded12Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded12Amt12.Text == "0")||(Ded12Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded12Amt12.Text == "0") || (Ded12Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded12Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded13Amt1.Text == "0")||(Ded13Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded13Amt1.Text == "0") || (Ded13Amt1.Text == "0.00")) && (DedBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded13Amt2.Text == "0")||(Ded13Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded13Amt2.Text == "0") || (Ded13Amt2.Text == "0.00")) && (DedBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded13Amt3.Text == "0")||(Ded13Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded13Amt3.Text == "0") || (Ded13Amt3.Text == "0.00")) && (DedBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded13Amt4.Text == "0")||(Ded13Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded13Amt4.Text == "0") || (Ded13Amt4.Text == "0.00")) && (DedBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded13Amt5.Text == "0")||(Ded13Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded13Amt5.Text == "0") || (Ded13Amt5.Text == "0.00")) && (DedBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded13Amt6.Text == "0")||(Ded13Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded13Amt6.Text == "0") || (Ded13Amt6.Text == "0.00")) && (DedBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded13Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded13Amt7.Text == "0")||(Ded13Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded13Amt7.Text == "0")||(Ded13Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded13Amt8.Text == "0")||(Ded13Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded13Amt8.Text == "0") || (Ded13Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded13Amt9.Text == "0")||(Ded13Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded13Amt9.Text == "0")||(Ded13Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded13Amt10.Text == "0")||(Ded13Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded13Amt10.Text == "0")||(Ded13Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded13Amt11.Text == "0")||(Ded13Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded13Amt11.Text == "0") || (Ded13Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded13Amt12.Text == "0")||(Ded13Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded13Amt12.Text == "0") || (Ded13Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded13Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded14Amt1.Text == "0")||(Ded14Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded14Amt1.Text == "0") || (Ded14Amt1.Text == "0.00")) && (DedBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded14Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded14Amt2.Text == "0")||(Ded14Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded14Amt2.Text == "0") || (Ded14Amt2.Text == "0.00")) && (DedBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded14Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded14Amt3.Text == "0")||(Ded14Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded14Amt3.Text == "0") || (Ded14Amt3.Text == "0.00")) && (DedBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded14Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded14Amt4.Text == "0")||(Ded14Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded14Amt4.Text == "0") || (Ded14Amt4.Text == "0.00")) && (DedBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 From		
			{
				Ded14Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded14Amt5.Text == "0")||(Ded14Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded14Amt5.Text == "0") || (Ded14Amt5.Text == "0.00")) && (DedBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded14Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded14Amt6.Text == "0")||(Ded14Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded14Amt6.Text == "0") || (Ded14Amt6.Text == "0.00")) && (DedBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded14Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded14Amt7.Text == "0")||(Ded14Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded14Amt7.Text == "0") || (Ded14Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded14Amt8.Text == "0")||(Ded14Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded14Amt8.Text == "0") || (Ded14Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded14Amt9.Text == "0")||(Ded14Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded14Amt9.Text == "0") || (Ded14Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded14Amt10.Text == "0")||(Ded14Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded14Amt10.Text == "0") || (Ded14Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded14Amt11.Text == "0")||(Ded14Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded14Amt11.Text == "0") || (Ded14Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded14Amt12.Text == "0")||(Ded14Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded14Amt12.Text == "0") || (Ded14Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded14Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded15Amt1.Text == "0")||(Ded15Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded15Amt1.Text == "0") || (Ded15Amt1.Text == "0.00")) && (DedBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded15Amt2.Text == "0")||(Ded15Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded15Amt2.Text == "0") || (Ded15Amt2.Text == "0.00")) && (DedBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded15Amt3.Text == "0")||(Ded15Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded15Amt3.Text == "0") || (Ded15Amt3.Text == "0.00")) && (DedBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded15Amt4.Text == "0")||(Ded15Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded15Amt4.Text == "0") || (Ded15Amt4.Text == "0.00")) && (DedBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded15Amt5.Text == "0")||(Ded15Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded15Amt5.Text == "0") || (Ded15Amt5.Text == "0.00")) && (DedBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded15Amt6.Text == "0")||(Ded15Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded15Amt6.Text == "0") || (Ded15Amt6.Text == "0.00")) && (DedBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded15Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded15Amt7.Text == "0")||(Ded15Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded15Amt7.Text == "0") || (Ded15Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded15Amt8.Text == "0")||(Ded15Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded15Amt8.Text == "0")||(Ded15Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded15Amt9.Text == "0")||(Ded15Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded15Amt9.Text == "0")||(Ded15Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded15Amt10.Text == "0")||(Ded15Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded15Amt10.Text == "0")||(Ded15Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded15Amt11.Text == "0")||(Ded15Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded15Amt11.Text == "0")||(Ded15Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt11.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded15Amt12.Text == "0")||(Ded15Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((Ded15Amt12.Text == "0") || (Ded15Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded15Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded16Amt1.Text == "0")||(Ded16Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((Ded16Amt1.Text == "0") || (Ded16Amt1.Text == "0.00")) && (DedBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded16Amt2.Text == "0")||(Ded16Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((Ded16Amt2.Text == "0") || (Ded16Amt2.Text == "0.00")) && (DedBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded16Amt3.Text == "0")||(Ded16Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((Ded16Amt3.Text == "0") || (Ded16Amt3.Text == "0.00")) && (DedBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded16Amt4.Text == "0")||(Ded16Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((Ded16Amt4.Text == "0") || (Ded16Amt4.Text == "0.00")) && (DedBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded16Amt5.Text == "0")||(Ded16Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded16Amt5.Text == "0") || (Ded16Amt5.Text == "0.00")) && (DedBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((Ded16Amt6.Text == "0")||(Ded16Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((Ded16Amt6.Text == "0") || (Ded16Amt6.Text == "0.00")) && (DedBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				Ded16Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded16Amt7.Text == "0")||(Ded16Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded16Amt7.Text == "0") || (Ded16Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded16Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded16Amt8.Text == "0")||(Ded16Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((Ded16Amt8.Text == "0") || (Ded16Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded16Amt8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded16Amt9.Text == "0")||(Ded16Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((Ded16Amt9.Text == "0") || (Ded16Amt9.Text == "0.00")) && (DedBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded16Amt9.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded16Amt10.Text == "0")||(Ded16Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((Ded16Amt10.Text == "0")||(Ded16Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded16Amt10.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded16Amt11.Text == "0")||(Ded16Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded16Amt11.Text == "0") || (Ded16Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded16Amt11.Text = "";
//			}
//// 管理番号 B15940 From
//			//if((Ded16Amt12.Text == "0") || (Ded16Amt12.Text == "0.00") && (DedBnsZeroFlg12.Text == "0"))			
//			if(((Ded16Amt12.Text == "0") || (Ded16Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))			
//// 管理番号 B15940 To
//			{
//				Ded16Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
//			if(((Ded18Amt1.Text == "0") || (Ded18Amt1.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//			{
//				Ded18Amt1.Text = "";
//			}
//			
//			if(((Ded18Amt2.Text == "0") || (Ded18Amt2.Text == "0.00")) && (DedZeroFlg12.Text == "0"))		
//			{
//				Ded18Amt2.Text = "";
//			}
//			
//			if(((Ded18Amt3.Text == "0") || (Ded18Amt3.Text == "0.00")) && (DedZeroFlg12.Text == "0"))		
//			{
//				Ded18Amt3.Text = "";
//			}
//
//			//課税給与所得の計算結果が0の時は0を表示。
////			if((Ded18Amt4.Text == "0")||(Ded18Amt4.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
////			{
////				Ded18Amt4.Text = "";
////			}
////			
//			//年税額の計算結果が0の時は0を表示。
////			if((Ded18Amt5.Text == "0")||(Ded18Amt5.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
////			{
////				Ded18Amt5.Text = "";
////			}
////			
//			if(((Ded18Amt6.Text == "0")||(Ded18Amt6.Text == "0.00")) && (DedZeroFlg12.Text == "0"))			
//			{
//				Ded18Amt6.Text = "";
//			}
//			
//			//差引年税額の計算結果が0の時は0を表示。
////			if((Ded18Amt7.Text == "0")||(Ded18Amt7.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
////			{
////				Ded18Amt7.Text = "0";
////			}
//			
//			if((Ded18Amt13.Text != "0")||(Ded18Amt13.Text == "0.00")&&(Ded18Amt13.Text != "")&&(Ded18Amt13.Text != null))
//			{
//				Ded18Amt8.Text = Ded18Amt13.Text;
//			}
//			else
//			{
//				Ded18Amt8.Text = "";
//			}
//			
//			if(((Ded18Amt9.Text == "0") || (Ded18Amt9.Text == "0.00")) && (DedZeroFlg12.Text == "0"))		
//			{
//				Ded18Amt9.Text = "";
//			}
//		
//			if(((Ded18Amt10.Text == "0")||(Ded18Amt10.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//			{
//				Ded18Amt10.Text = "";
//			}
//			
//			if(((Ded18Amt11.Text == "0") || (Ded18Amt11.Text == "0.00")) && (DedZeroFlg12.Text == "0"))		
//			{
//				Ded18Amt11.Text = "";
//			}
//			
//			if(((Ded18Amt12.Text == "0")||(Ded18Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))		
//			{
//				Ded18Amt12.Text = "";
//			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 K24680 From
////			if((Ded18Amt13.Text != "0") && (Ded18Amt13.Text != "0.00") && (Ded18Amt13.Text != "") && (Ded18Amt13.Text != null))
//			if((Ded18Amt13.Text != "0") && (Ded18Amt13.Text != "0.00") && (Ded18Amt13.Text != "") && (Ded18Amt13.Text != null) && (Title.Text.Length > 0))
//// 管理番号 K24680 To
//			{
//// 管理番号 K24680 From
//				// 絶対値を表示する
//				Ded18Amt13.Text = Ded18Amt13.Text.Replace("-", "");
//// 管理番号 K24680 To
//				Ded18Amt8.Text = Ded18Amt13.Text;
//			}
//			else
//			{
//				Ded18Amt8.Text = "";
//			}
// 管理番号 K24565 To
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R98へ移動
//			//勤怠の空白処理
//// 管理番号 B15940 From
//			//if((Dty1Num1.Text == "0")||(Dty1Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty1Num1.Text == "0") || (Dty1Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num2.Text == "0")||(Dty1Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty1Num2.Text == "0") || (Dty1Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num3.Text == "0")||(Dty1Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty1Num3.Text == "0") || (Dty1Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num4.Text == "0")||(Dty1Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty1Num4.Text == "0")||(Dty1Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num5.Text == "0")||(Dty1Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty1Num5.Text == "0")||(Dty1Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num6.Text == "0")||(Dty1Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty1Num6.Text == "0")||(Dty1Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num7.Text == "0")||(Dty1Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty1Num7.Text == "0")||(Dty1Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty1Num8.Text == "0")||(Dty1Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty1Num8.Text == "0") || (Dty1Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty1Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num1.Text == "0")||(Dty2Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty2Num1.Text == "0") || (Dty2Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num2.Text == "0")||(Dty2Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty2Num2.Text == "0") || (Dty2Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num3.Text == "0")||(Dty2Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty2Num3.Text == "0") || (Dty2Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num4.Text == "0")||(Dty2Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty2Num4.Text == "0") || (Dty2Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num5.Text == "0")||(Dty2Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty2Num5.Text == "0")||(Dty2Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num6.Text == "0")||(Dty2Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty2Num6.Text == "0")||(Dty2Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num7.Text == "0")||(Dty2Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty2Num7.Text == "0") || (Dty2Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty2Num8.Text == "0")||(Dty2Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty2Num8.Text == "0") || (Dty2Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty2Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num1.Text == "0")||(Dty3Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty3Num1.Text == "0") || (Dty3Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num2.Text == "0")||(Dty3Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty3Num2.Text == "0") || (Dty3Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num3.Text == "0")||(Dty3Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty3Num3.Text == "0") || (Dty3Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num4.Text == "0")||(Dty3Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty3Num4.Text == "0")||(Dty3Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num5.Text == "0")||(Dty3Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty3Num5.Text == "0") || (Dty3Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num6.Text == "0")||(Dty3Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty3Num6.Text == "0") || (Dty3Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num7.Text == "0")||(Dty3Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty3Num7.Text == "0") || (Dty3Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty3Num8.Text == "0")||(Dty3Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty3Num8.Text == "0")||(Dty3Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty3Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num1.Text == "0")||(Dty4Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty4Num1.Text == "0")||(Dty4Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num2.Text == "0")||(Dty4Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty4Num2.Text == "0")||(Dty4Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num3.Text == "0")||(Dty4Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty4Num3.Text == "0")||(Dty4Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num4.Text == "0")||(Dty4Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty4Num4.Text == "0") || (Dty4Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num5.Text == "0")||(Dty4Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty4Num5.Text == "0")||(Dty4Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num6.Text == "0")||(Dty4Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty4Num6.Text == "0") || (Dty4Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num7.Text == "0")||(Dty4Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty4Num7.Text == "0") || (Dty4Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty4Num8.Text == "0")||(Dty4Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty4Num8.Text == "0") || (Dty4Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty4Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num1.Text == "0")||(Dty5Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty5Num1.Text == "0") || (Dty5Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num2.Text == "0")||(Dty5Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty5Num2.Text == "0") || (Dty5Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num3.Text == "0")||(Dty5Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty5Num3.Text == "0") || (Dty5Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num4.Text == "0")||(Dty5Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty5Num4.Text == "0") || (Dty5Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num5.Text == "0")||(Dty5Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty5Num5.Text == "0") || (Dty5Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num6.Text == "0")||(Dty5Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty5Num6.Text == "0")||(Dty5Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num7.Text == "0")||(Dty5Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty5Num7.Text == "0")||(Dty5Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty5Num8.Text == "0")||(Dty5Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty5Num8.Text == "0") || (Dty5Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty5Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num1.Text == "0")||(Dty6Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty6Num1.Text == "0")||(Dty6Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num2.Text == "0")||(Dty6Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty6Num2.Text == "0") || (Dty6Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num3.Text == "0")||(Dty6Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty6Num3.Text == "0") || (Dty6Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num4.Text == "0")||(Dty6Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty6Num4.Text == "0") || (Dty6Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num5.Text == "0")||(Dty6Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty6Num5.Text == "0") || (Dty6Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num6.Text == "0")||(Dty6Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty6Num6.Text == "0") || (Dty6Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num7.Text == "0")||(Dty6Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty6Num7.Text == "0")||(Dty6Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty6Num8.Text == "0")||(Dty6Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty6Num8.Text == "0") || (Dty6Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty6Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num1.Text == "0")||(Dty7Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty7Num1.Text == "0") || (Dty7Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num2.Text == "0")||(Dty7Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty7Num2.Text == "0") || (Dty7Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num3.Text == "0")||(Dty7Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty7Num3.Text == "0") || (Dty7Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num4.Text == "0")||(Dty7Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty7Num4.Text == "0") || (Dty7Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num5.Text == "0")||(Dty7Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty7Num5.Text == "0") || (Dty7Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num6.Text == "0")||(Dty7Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty7Num6.Text == "0") || (Dty7Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num7.Text == "0")||(Dty7Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty7Num7.Text == "0")||(Dty7Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty7Num8.Text == "0")||(Dty7Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty7Num8.Text == "0")||(Dty7Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty7Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num1.Text == "0")||(Dty8Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty8Num1.Text == "0") || (Dty8Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num2.Text == "0")||(Dty8Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty8Num2.Text == "0")||(Dty8Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num3.Text == "0")||(Dty8Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty8Num3.Text == "0")||(Dty8Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num4.Text == "0")||(Dty8Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty8Num4.Text == "0") || (Dty8Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num5.Text == "0")||(Dty8Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty8Num5.Text == "0") || (Dty8Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num6.Text == "0")||(Dty8Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty8Num6.Text == "0") || (Dty8Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num7.Text == "0")||(Dty8Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty8Num7.Text == "0")||(Dty8Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty8Num8.Text == "0")||(Dty8Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty8Num8.Text == "0")||(Dty8Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty8Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num1.Text == "0")||(Dty9Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty9Num1.Text == "0")||(Dty9Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num2.Text == "0")||(Dty9Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty9Num2.Text == "0") || (Dty9Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num3.Text == "0")||(Dty9Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty9Num3.Text == "0") || (Dty9Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num4.Text == "0")||(Dty9Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty9Num4.Text == "0") || (Dty9Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num5.Text == "0")||(Dty9Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty9Num5.Text == "0")||(Dty9Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num6.Text == "0")||(Dty9Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty9Num6.Text == "0") || (Dty9Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num7.Text == "0")||(Dty9Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty9Num7.Text == "0") || (Dty9Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty9Num8.Text == "0")||(Dty9Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty9Num8.Text == "0")||(Dty9Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty9Num8.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num1.Text == "0")||(Dty10Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty10Num1.Text == "0")||(Dty10Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num2.Text == "0")||(Dty10Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty10Num2.Text == "0") || (Dty10Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num3.Text == "0")||(Dty10Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty10Num3.Text == "0") || (Dty10Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num4.Text == "0")||(Dty10Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty10Num4.Text == "0") || (Dty10Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num5.Text == "0")||(Dty10Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty10Num5.Text == "0") || (Dty10Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num6.Text == "0")||(Dty10Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty10Num6.Text == "0") || (Dty10Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num7.Text == "0")||(Dty10Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty10Num7.Text == "0")||(Dty10Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
// 管理番号 B15940 To
//			{
//				Dty10Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty10Num8.Text == "0")||(Dty10Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty10Num8.Text == "0")||(Dty10Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty10Num8.Text = "";
//			}
//		
//// 管理番号 B15940 From
//			//if((Dty11Num1.Text == "0")||(Dty11Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty11Num1.Text == "0")||(Dty11Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num2.Text == "0")||(Dty11Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty11Num2.Text == "0") || (Dty11Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num2.Text = "";
//			}
//		
//// 管理番号 B15940 From
//			//if((Dty11Num3.Text == "0")||(Dty11Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty11Num3.Text == "0") || (Dty11Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num4.Text == "0")||(Dty11Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty11Num4.Text == "0") || (Dty11Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num5.Text == "0")||(Dty11Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty11Num5.Text == "0") || (Dty11Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num6.Text == "0")||(Dty11Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty11Num6.Text == "0") || (Dty11Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num7.Text == "0")||(Dty11Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty11Num7.Text == "0") || (Dty11Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty11Num8.Text == "0")||(Dty11Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty11Num8.Text == "0") || (Dty11Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty11Num8.Text = "";
//			}
//		
//// 管理番号 B15940 From
//			//if((Dty12Num1.Text == "0")||(Dty12Num1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((Dty12Num1.Text == "0") || (Dty12Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num1.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num2.Text == "0")||(Dty12Num2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((Dty12Num2.Text == "0") || (Dty12Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num2.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num3.Text == "0")||(Dty12Num3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((Dty12Num3.Text == "0") || (Dty12Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num3.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num4.Text == "0")||(Dty12Num4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((Dty12Num4.Text == "0") || (Dty12Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num4.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num5.Text == "0")||(Dty12Num5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((Dty12Num5.Text == "0")||(Dty12Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num5.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num6.Text == "0")||(Dty12Num6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((Dty12Num6.Text == "0") || (Dty12Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num6.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num7.Text == "0")||(Dty12Num7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((Dty12Num7.Text == "0") || (Dty12Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Dty12Num8.Text == "0")||(Dty12Num8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((Dty12Num8.Text == "0") || (Dty12Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Dty12Num8.Text = "";
//			}
// 管理番号 K24565 To

			//給与支給額の合計処理
			if ((Paymnt1Amt1.Text == null) || (Paymnt1Amt1.Text == ""))
			{
				paymntTotal1Amt1 = 0;
			}
			else
			{
				paymntTotal1Amt1 = Convert.ToDouble(Paymnt1Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt1.Text == null) || (Paymnt2Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt2Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt1.Text == null) || (Paymnt3Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt3Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt1.Text == null) || (Paymnt4Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt4Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt1.Text == null) || (Paymnt5Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt5Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt1.Text == null) || (Paymnt6Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt6Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt1.Text == null) || (Paymnt7Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt7Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt1.Text == null) || (Paymnt8Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt8Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt1.Text == null) || (Paymnt9Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt9Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt1.Text == null) || (Paymnt10Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt10Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From			
			//if((Paymnt11Amt1.Text == null)||(Paymnt11Amt11.Text == ""))
			if ((Paymnt11Amt1.Text == null) || (Paymnt11Amt1.Text == ""))
// 管理番号 B15940 To
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt11Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt1.Text == null) || (Paymnt12Amt1.Text == ""))
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + 0;
			}
			else
			{
				paymntTotal1Amt1 = paymntTotal1Amt1 + Convert.ToDouble(Paymnt12Amt1.Text);
// 管理番号 B15940 From
				paymntTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt1Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType1.Text == "2")
				{
					PaymntTotal1Amt1.Text = paymntTotal1Amt1.ToString("###0");
				}

				else if (PaymntDispType1.Text == "3")
				{
					PaymntTotal1Amt1.Text = paymntTotal1Amt1.ToString("#,##0.00");
				}

				else if (PaymntDispType1.Text == "4")
				{
					PaymntTotal1Amt1.Text = paymntTotal1Amt1.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt1.Text = paymntTotal1Amt1.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt1.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt1Amt2.Text == null) || (Paymnt1Amt2.Text == ""))
			{
				paymntTotal1Amt2 = 0;
			}
			else
			{
				paymntTotal1Amt2 = Convert.ToDouble(Paymnt1Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt2.Text == null) || (Paymnt2Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt2Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt2.Text == null) || (Paymnt3Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt3Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt2.Text == null) || (Paymnt4Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt4Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt2.Text == null) || (Paymnt5Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt5Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt2.Text == null) || (Paymnt6Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt6Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt2.Text == null) || (Paymnt7Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt7Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt2.Text == null) || (Paymnt8Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt8Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt2.Text == null) || (Paymnt9Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt9Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt2.Text == null) || (Paymnt10Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt10Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt11Amt2.Text == null) || (Paymnt11Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt11Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt2.Text == null) || (Paymnt12Amt2.Text == ""))
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + 0;
			}
			else
			{
				paymntTotal1Amt2 = paymntTotal1Amt2 + Convert.ToDouble(Paymnt12Amt2.Text);
// 管理番号 B15940 From
				paymntTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt2Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType2.Text == "2")
				{
					PaymntTotal1Amt2.Text = paymntTotal1Amt2.ToString("###0");
				}

				else if (PaymntDispType2.Text == "3")
				{
					PaymntTotal1Amt2.Text = paymntTotal1Amt2.ToString("#,##0.00");
				}

				else if (PaymntDispType2.Text == "4")
				{
					PaymntTotal1Amt2.Text = paymntTotal1Amt2.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt2.Text = paymntTotal1Amt2.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt2.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt1Amt3.Text == null) || (Paymnt1Amt3.Text == ""))
			{
				paymntTotal1Amt3 = 0;
			}
			else
			{
				paymntTotal1Amt3 = Convert.ToDouble(Paymnt1Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt3.Text == null) || (Paymnt2Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt2Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt3.Text == null) || (Paymnt3Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt3Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt3.Text == null) || (Paymnt4Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt4Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt3.Text == null) || (Paymnt5Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt5Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt3.Text == null) || (Paymnt6Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt6Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt3.Text == null) || (Paymnt7Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt7Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt3.Text == null) || (Paymnt8Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt8Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt3.Text == null) || (Paymnt9Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt9Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt3.Text == null) || (Paymnt10Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt10Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt11Amt3.Text == null) || (Paymnt11Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt11Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt3.Text == null) || (Paymnt12Amt3.Text == ""))
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + 0;
			}
			else
			{
				paymntTotal1Amt3 = paymntTotal1Amt3 + Convert.ToDouble(Paymnt12Amt3.Text);
// 管理番号 B15940 From
				paymntTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt3Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType3.Text == "2")
				{
					PaymntTotal1Amt3.Text = paymntTotal1Amt3.ToString("###0");
				}

				else if (PaymntDispType3.Text == "3")
				{
					PaymntTotal1Amt3.Text = paymntTotal1Amt3.ToString("#,##0.00");
				}

				else if (PaymntDispType3.Text == "4")
				{
					PaymntTotal1Amt3.Text = paymntTotal1Amt3.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt3.Text = paymntTotal1Amt3.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt3.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt1Amt4.Text == null) || (Paymnt1Amt4.Text == ""))
			{
				paymntTotal1Amt4 = 0;
			}
			else
			{
				paymntTotal1Amt4 = Convert.ToDouble(Paymnt1Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt4.Text == null) || (Paymnt2Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt2Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt4.Text == null) || (Paymnt3Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt3Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt4.Text == null) || (Paymnt4Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt4Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt4.Text == null) || (Paymnt5Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt5Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt4.Text == null) || (Paymnt6Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt6Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt4.Text == null) || (Paymnt7Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt7Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt4.Text == null) || (Paymnt8Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt8Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt4.Text == null) || (Paymnt9Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt9Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt4.Text == null) || (Paymnt10Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt10Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt11Amt4.Text == null) || (Paymnt11Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt11Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt4.Text == null) || (Paymnt12Amt4.Text == ""))
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + 0;
			}
			else
			{
				paymntTotal1Amt4 = paymntTotal1Amt4 + Convert.ToDouble(Paymnt12Amt4.Text);
// 管理番号 B15940 From
				paymntTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt4Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType4.Text == "2")
				{
					PaymntTotal1Amt4.Text = paymntTotal1Amt4.ToString("###0");
				}

				else if (PaymntDispType4.Text == "3")
				{
					PaymntTotal1Amt4.Text = paymntTotal1Amt4.ToString("#,##0.00");
				}

				else if (PaymntDispType4.Text == "4")
				{
					PaymntTotal1Amt4.Text = paymntTotal1Amt4.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt4.Text = paymntTotal1Amt4.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt4.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt1Amt5.Text == null) || (Paymnt1Amt5.Text == ""))
			{
				paymntTotal1Amt5 = 0;
			}
			else
			{
				paymntTotal1Amt5 = Convert.ToDouble(Paymnt1Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt5.Text == null) || (Paymnt2Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt2Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt5.Text == null) || (Paymnt3Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt3Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt5.Text == null) || (Paymnt4Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt4Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt5.Text == null) || (Paymnt5Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt5Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt5.Text == null) || (Paymnt6Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt6Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt5.Text == null) || (Paymnt7Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt7Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt5.Text == null) || (Paymnt8Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt8Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt5.Text == null) || (Paymnt9Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt9Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt5.Text == null) || (Paymnt10Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt10Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt11Amt5.Text == null) || (Paymnt11Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt11Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt5.Text == null) || (Paymnt12Amt5.Text == ""))
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + 0;
			}
			else
			{
				paymntTotal1Amt5 = paymntTotal1Amt5 + Convert.ToDouble(Paymnt12Amt5.Text);
// 管理番号 B15940 From
				paymntTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt5Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType5.Text == "2")
				{
					PaymntTotal1Amt5.Text = paymntTotal1Amt5.ToString("###0");
				}

				else if (PaymntDispType5.Text == "3")
				{
					PaymntTotal1Amt5.Text = paymntTotal1Amt5.ToString("#,##0.00");
				}

				else if (PaymntDispType5.Text == "4")
				{
					PaymntTotal1Amt5.Text = paymntTotal1Amt5.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt5.Text = paymntTotal1Amt5.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt5.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt1Amt6.Text == null) || (Paymnt1Amt6.Text == ""))
			{
				paymntTotal1Amt6 = 0;
			}
			else
			{
				paymntTotal1Amt6 = Convert.ToDouble(Paymnt1Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt2Amt6.Text == null) || (Paymnt2Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt2Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt3Amt6.Text == null) || (Paymnt3Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt3Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt4Amt6.Text == null) || (Paymnt4Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt4Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt5Amt6.Text == null) || (Paymnt5Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt5Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt6Amt6.Text == null) || (Paymnt6Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt6Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt7Amt6.Text == null) || (Paymnt7Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt7Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt8Amt6.Text == null) || (Paymnt8Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt8Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt9Amt6.Text == null) || (Paymnt9Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt9Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt10Amt6.Text == null) || (Paymnt10Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt10Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt11Amt6.Text == null) || (Paymnt11Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt11Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt12Amt6.Text == null) || (Paymnt12Amt6.Text == ""))
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + 0;
			}
			else
			{
				paymntTotal1Amt6 = paymntTotal1Amt6 + Convert.ToDouble(Paymnt12Amt6.Text);
// 管理番号 B15940 From
				paymntTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal1Amt6Flg)
			{
// 管理番号 B15940 To
				if (PaymntDispType6.Text == "2")
				{
					PaymntTotal1Amt6.Text = paymntTotal1Amt6.ToString("###0");
				}

				else if (PaymntDispType6.Text == "3")
				{
					PaymntTotal1Amt6.Text = paymntTotal1Amt6.ToString("#,##0.00");
				}

				else if (PaymntDispType6.Text == "4")
				{
					PaymntTotal1Amt6.Text = paymntTotal1Amt6.ToString("###0.00");
				}

				else
				{
					PaymntTotal1Amt6.Text = paymntTotal1Amt6.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal1Amt6.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if ((Paymnt1Amt7.Text == null) || (Paymnt1Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = Convert.ToDouble(Paymnt1Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt7.Text == null)||(Paymnt2Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt2Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt7.Text == null)||(Paymnt3Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt3Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt7.Text == null)||(Paymnt4Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt4Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt7.Text == null)||(Paymnt5Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt5Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt7.Text == null)||(Paymnt6Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt6Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt7.Text == null)||(Paymnt7Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt7Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt7.Text == null)||(Paymnt8Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt8Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt7.Text == null)||(Paymnt9Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt9Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt7.Text == null)||(Paymnt10Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt10Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt7.Text == null)||(Paymnt11Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt11Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt7.Text == null)||(Paymnt12Amt7.Text == ""))
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt7 = paymntTotal1Amt7 + Convert.ToDouble(Paymnt12Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt7Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType7.Text == "2")
//				{
//					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("###0");
//				}
//
//				else if(PaymntDispType7.Text == "3")
//				{
//					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType7.Text == "4")
//				{
//					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt7.Text = paymntTotal1Amt7.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt1Amt8.Text == null)||(Paymnt1Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = Convert.ToDouble(Paymnt1Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt8.Text == null)||(Paymnt2Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt2Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt8.Text == null)||(Paymnt3Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt3Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt8.Text == null)||(Paymnt4Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt4Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt8.Text == null)||(Paymnt5Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt5Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt8.Text == null)||(Paymnt6Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt6Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt8.Text == null)||(Paymnt7Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt7Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt8.Text == null)||(Paymnt8Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt8Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt8.Text == null)||(Paymnt9Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt9Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt8.Text == null)||(Paymnt10Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt10Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt8.Text == null)||(Paymnt11Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt11Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt8.Text == null)||(Paymnt12Amt8.Text == ""))
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt8 = paymntTotal1Amt8 + Convert.ToDouble(Paymnt12Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt8Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType8.Text == "2")
//				{
//					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("###0");
//				}
//
//				else if(PaymntDispType8.Text == "3")
//				{
//					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType8.Text == "4")
//				{
//					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt8.Text = paymntTotal1Amt8.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt8.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt1Amt9.Text == null)||(Paymnt1Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = Convert.ToDouble(Paymnt1Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt9.Text == null)||(Paymnt2Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt2Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt9.Text == null)||(Paymnt3Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt3Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt9.Text == null)||(Paymnt4Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt4Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt9.Text == null)||(Paymnt5Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt5Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt9.Text == null)||(Paymnt6Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt6Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt9.Text == null)||(Paymnt7Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt7Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt9.Text == null)||(Paymnt8Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt8Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt9.Text == null)||(Paymnt9Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt9Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt9.Text == null)||(Paymnt10Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt10Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt9.Text == null)||(Paymnt11Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt11Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt9.Text == null)||(Paymnt12Amt9.Text == ""))
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt9 = paymntTotal1Amt9 + Convert.ToDouble(Paymnt12Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt9Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType9.Text == "2")
//				{
//					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("###0");
//				}
//
//				else if(PaymntDispType9.Text == "3")
//				{
//					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType9.Text == "4")
//				{
//					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt9.Text = paymntTotal1Amt9.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//			
//			if((Paymnt1Amt10.Text == null)||(Paymnt1Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = Convert.ToDouble(Paymnt1Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt10.Text == null)||(Paymnt2Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt2Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt10.Text == null)||(Paymnt3Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt3Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt10.Text == null)||(Paymnt4Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt4Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt10.Text == null)||(Paymnt5Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt5Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt10.Text == null)||(Paymnt6Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt6Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt10.Text == null)||(Paymnt7Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt7Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt10.Text == null)||(Paymnt8Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt8Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt10.Text == null)||(Paymnt9Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt9Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt10.Text == null)||(Paymnt10Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt10Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt10.Text == null)||(Paymnt11Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt11Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt10.Text == null)||(Paymnt12Amt10.Text == ""))
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt10 = paymntTotal1Amt10 + Convert.ToDouble(Paymnt12Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt10Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType10.Text == "2")
//				{
//					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("###0");
//				}
//
//				else if(PaymntDispType10.Text == "3")
//				{
//					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType10.Text == "4")
//				{
//					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt10.Text = paymntTotal1Amt10.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt1Amt11.Text == null)||(Paymnt1Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = Convert.ToDouble(Paymnt1Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt11.Text == null)||(Paymnt2Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt2Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt11.Text == null)||(Paymnt3Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt3Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt11.Text == null)||(Paymnt4Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt4Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt11.Text == null)||(Paymnt5Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt5Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt11.Text == null)||(Paymnt6Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt6Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt11.Text == null)||(Paymnt7Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt7Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt11.Text == null)||(Paymnt8Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt8Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt11.Text == null)||(Paymnt9Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt9Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt11.Text == null)||(Paymnt10Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt10Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt11.Text == null)||(Paymnt11Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt11Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt11.Text == null)||(Paymnt12Amt11.Text == ""))
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt11 = paymntTotal1Amt11 + Convert.ToDouble(Paymnt12Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt11Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType11.Text == "2")
//				{
//					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("###0");
//				}
//
//				else if(PaymntDispType11.Text == "3")
//				{
//					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType12.Text == "4")
//				{
//					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt11.Text = paymntTotal1Amt11.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt1Amt12.Text == null)||(Paymnt1Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = Convert.ToDouble(Paymnt1Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt2Amt12.Text == null)||(Paymnt2Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt2Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt3Amt12.Text == null)||(Paymnt3Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt3Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt4Amt12.Text == null)||(Paymnt4Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt4Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt5Amt12.Text == null)||(Paymnt5Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt5Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt6Amt12.Text == null)||(Paymnt6Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt6Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt7Amt12.Text == null)||(Paymnt7Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt7Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt8Amt12.Text == null)||(Paymnt8Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt8Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Paymnt9Amt12.Text == null)||(Paymnt9Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt9Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt10Amt12.Text == null)||(Paymnt10Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt10Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt11Amt12.Text == null)||(Paymnt11Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt11Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt12Amt12.Text == null)||(Paymnt12Amt12.Text == ""))
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal1Amt12 = paymntTotal1Amt12 + Convert.ToDouble(Paymnt12Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(paymntTotal1Amt12Flg)
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType12.Text == "2")
//				{
//					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("###0");
//				}
//
//				else if(PaymntDispType12.Text == "3")
//				{
//					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType12.Text == "4")
//				{
//					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal1Amt12.Text = paymntTotal1Amt12.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal1Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To

			//賞与支給総合計の処理
			if ((Paymnt13Amt1.Text == null) || (Paymnt13Amt1.Text == ""))
			{
				paymntTotal2Amt1 = 0;
			}
			else
			{
				paymntTotal2Amt1 = Convert.ToDouble(Paymnt13Amt1.Text);
// 管理番号 B15940 From
				paymntTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt1.Text == null) || (Paymnt14Amt1.Text == ""))
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + 0;
			}
			else
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + Convert.ToDouble(Paymnt14Amt1.Text);
// 管理番号 B15940 From
				paymntTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt1.Text == null) || (Paymnt15Amt1.Text == ""))
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + 0;
			}
			else
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + Convert.ToDouble(Paymnt15Amt1.Text);
// 管理番号 B15940 From
				paymntTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt1.Text == null) || (Paymnt16Amt1.Text == ""))
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + 0;
			}
			else
			{
				paymntTotal2Amt1 = paymntTotal2Amt1 + Convert.ToDouble(Paymnt16Amt1.Text);
// 管理番号 B15940 From
				paymntTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt1Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType1.Text == "2")
				if (PaymntBnsDispType1.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt1.Text = paymntTotal2Amt1.ToString("###0");
				}
// 管理番号 B15940 From
				//else if(PaymntDispType1.Text == "3")
				else if (PaymntBnsDispType1.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt1.Text = paymntTotal2Amt1.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType1.Text == "4")
				else if (PaymntBnsDispType1.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt1.Text = paymntTotal2Amt1.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt1.Text = paymntTotal2Amt1.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt1.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt13Amt2.Text == null) || (Paymnt13Amt2.Text == ""))
			{
				paymntTotal2Amt2 = 0;
			}
			else
			{
				paymntTotal2Amt2 = Convert.ToDouble(Paymnt13Amt2.Text);
// 管理番号 B15940 From
				paymntTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt2.Text == null) || (Paymnt14Amt2.Text == ""))
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + 0;
			}
			else
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + Convert.ToDouble(Paymnt14Amt2.Text);
// 管理番号 B15940 From
				paymntTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt2.Text == null) || (Paymnt15Amt2.Text == ""))
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + 0;
			}
			else
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + Convert.ToDouble(Paymnt15Amt2.Text);
// 管理番号 B15940 From
				paymntTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt2.Text == null) || (Paymnt16Amt2.Text == ""))
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + 0;
			}
			else
			{
				paymntTotal2Amt2 = paymntTotal2Amt2 + Convert.ToDouble(Paymnt16Amt2.Text);
// 管理番号 B15940 From
				paymntTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt2Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType2.Text == "2")
				if (PaymntBnsDispType2.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt2.Text = paymntTotal2Amt2.ToString("###0");
				}
// 管理番号 B15940 From
				//else if(PaymntDispType2.Text == "3")
				else if (PaymntBnsDispType2.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt2.Text = paymntTotal2Amt2.ToString("#,##0.00");
				}
// 管理番号 B15940 From
				//else if(PaymntDispType2.Text == "4")
				else if (PaymntBnsDispType2.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt2.Text = paymntTotal2Amt2.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt2.Text = paymntTotal2Amt2.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt2.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt13Amt3.Text == null) || (Paymnt13Amt3.Text == ""))
			{
				paymntTotal2Amt3 = 0;
			}
			else
			{
				paymntTotal2Amt3 = Convert.ToDouble(Paymnt13Amt3.Text);
// 管理番号 B15940 From
				paymntTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt3.Text == null) || (Paymnt14Amt3.Text == ""))
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + 0;
			}
			else
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + Convert.ToDouble(Paymnt14Amt3.Text);
// 管理番号 B15940 From
				paymntTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt3.Text == null) || (Paymnt15Amt3.Text == ""))
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + 0;
			}
			else
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + Convert.ToDouble(Paymnt15Amt3.Text);
// 管理番号 B15940 From
				paymntTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt3.Text == null) || (Paymnt16Amt3.Text == ""))
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + 0;
			}
			else
			{
				paymntTotal2Amt3 = paymntTotal2Amt3 + Convert.ToDouble(Paymnt16Amt3.Text);
// 管理番号 B15940 From
				paymntTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt3Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType3.Text == "2")
				if (PaymntBnsDispType3.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt3.Text = paymntTotal2Amt3.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType3.Text == "3")
				else if (PaymntBnsDispType3.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt3.Text = paymntTotal2Amt3.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType3.Text == "4")
				else if (PaymntBnsDispType3.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt3.Text = paymntTotal2Amt3.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt3.Text = paymntTotal2Amt3.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt3.Text = "";
			}
// 管理番号 B15940 To


			if ((Paymnt13Amt4.Text == null) || (Paymnt13Amt4.Text == ""))
			{
				paymntTotal2Amt4 = 0;
			}
			else
			{
				paymntTotal2Amt4 = Convert.ToDouble(Paymnt13Amt4.Text);
// 管理番号 B15940 From
				paymntTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt4.Text == null) || (Paymnt14Amt4.Text == ""))
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + 0;
			}
			else
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + Convert.ToDouble(Paymnt14Amt4.Text);
// 管理番号 B15940 From
				paymntTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt4.Text == null) || (Paymnt15Amt4.Text == ""))
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + 0;
			}
			else
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + Convert.ToDouble(Paymnt15Amt4.Text);
// 管理番号 B15940 From
				paymntTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt4.Text == null) || (Paymnt16Amt4.Text == ""))
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + 0;
			}
			else
			{
				paymntTotal2Amt4 = paymntTotal2Amt4 + Convert.ToDouble(Paymnt16Amt4.Text);
// 管理番号 B15940 From
				paymntTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt4Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType4.Text == "2")
				if (PaymntBnsDispType4.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt4.Text = paymntTotal2Amt4.ToString("###0");
				}
// 管理番号 B15940 From
				//else if(PaymntDispType4.Text == "3")
				else if (PaymntBnsDispType4.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt4.Text = paymntTotal2Amt4.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType4.Text == "4")
				else if (PaymntBnsDispType4.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt4.Text = paymntTotal2Amt4.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt4.Text = paymntTotal2Amt4.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt4.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt13Amt5.Text == null) || (Paymnt13Amt5.Text == ""))
			{
				paymntTotal2Amt5 = 0;
			}
			else
			{
				paymntTotal2Amt5 = Convert.ToDouble(Paymnt13Amt5.Text);
// 管理番号 B15940 From
				paymntTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt5.Text == null) || (Paymnt14Amt5.Text == ""))
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + 0;
			}
			else
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + Convert.ToDouble(Paymnt14Amt5.Text);
// 管理番号 B15940 From
				paymntTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt5.Text == null) || (Paymnt15Amt5.Text == ""))
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + 0;
			}
			else
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + Convert.ToDouble(Paymnt15Amt5.Text);
// 管理番号 B15940 From
				paymntTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt5.Text == null) || (Paymnt16Amt5.Text == ""))
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + 0;
			}
			else
			{
				paymntTotal2Amt5 = paymntTotal2Amt5 + Convert.ToDouble(Paymnt16Amt5.Text);
// 管理番号 B15940 From
				paymntTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt5Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType5.Text == "2")
				if (PaymntBnsDispType5.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt5.Text = paymntTotal2Amt5.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType5.Text == "3")
				else if (PaymntBnsDispType5.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt5.Text = paymntTotal2Amt5.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType5.Text == "4")
				else if (PaymntBnsDispType5.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt5.Text = paymntTotal2Amt5.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt5.Text = paymntTotal2Amt5.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt5.Text = "";
			}
// 管理番号 B15940 To

			if ((Paymnt13Amt6.Text == null) || (Paymnt13Amt6.Text == ""))
			{
				paymntTotal2Amt6 = 0;
			}
			else
			{
				paymntTotal2Amt6 = Convert.ToDouble(Paymnt13Amt6.Text);
// 管理番号 B15940 From
				paymntTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt14Amt6.Text == null) || (Paymnt14Amt6.Text == ""))
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + 0;
			}
			else
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + Convert.ToDouble(Paymnt14Amt6.Text);
// 管理番号 B15940 From
				paymntTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt15Amt6.Text == null) || (Paymnt15Amt6.Text == ""))
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + 0;
			}
			else
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + Convert.ToDouble(Paymnt15Amt6.Text);
// 管理番号 B15940 From
				paymntTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt16Amt6.Text == null) || (Paymnt16Amt6.Text == ""))
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + 0;
			}
			else
			{
				paymntTotal2Amt6 = paymntTotal2Amt6 + Convert.ToDouble(Paymnt16Amt6.Text);
// 管理番号 B15940 From
				paymntTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (paymntTotal2Amt6Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(PaymntDispType6.Text == "2")
				if (PaymntBnsDispType6.Text == "2")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt6.Text = paymntTotal2Amt6.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType6.Text == "3")
				else if (PaymntBnsDispType6.Text == "3")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt6.Text = paymntTotal2Amt6.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(PaymntDispType6.Text == "4")
				else if (PaymntBnsDispType6.Text == "4")
// 管理番号 B15940 To
				{
					PaymntTotal2Amt6.Text = paymntTotal2Amt6.ToString("###0.00");
				}

				else
				{
					PaymntTotal2Amt6.Text = paymntTotal2Amt6.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal2Amt6.Text = "";
			}
// 管理番号 B15940 To


// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if ((Paymnt13Amt7.Text == null) || (Paymnt13Amt7.Text == ""))
//			{
//				paymntTotal2Amt7 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt7 = Convert.ToDouble(Paymnt13Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt7.Text == null)||(Paymnt14Amt7.Text == ""))
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt14Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt7.Text == null)||(Paymnt15Amt7.Text == ""))
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt15Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt7.Text == null)||(Paymnt16Amt7.Text == ""))
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt7 = paymntTotal2Amt7 + Convert.ToDouble(Paymnt16Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt7Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType7.Text == "2")
//				if(PaymntBnsDispType7.Text == "2")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("###0");
//				}
//// 管理番号 B15940 From
//				//else if(PaymntDispType7.Text == "3")
//				else if(PaymntBnsDispType7.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType7.Text == "4")
//				else if(PaymntBnsDispType7.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt7.Text = paymntTotal2Amt7.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt13Amt8.Text == null)||(Paymnt13Amt8.Text == ""))
//			{
//				paymntTotal2Amt8 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt8 = Convert.ToDouble(Paymnt13Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt8.Text == null)||(Paymnt14Amt8.Text == ""))
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt14Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt8.Text == null)||(Paymnt15Amt8.Text == ""))
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt15Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt8.Text == null)||(Paymnt16Amt8.Text == ""))
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt8 = paymntTotal2Amt8 + Convert.ToDouble(Paymnt16Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt8Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType8.Text == "2")
//				if(PaymntBnsDispType8.Text == "2")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType8.Text == "3")
//				else if(PaymntBnsDispType8.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType8.Text == "4")
//				else if(PaymntBnsDispType8.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt8.Text = paymntTotal2Amt8.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt8.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt13Amt9.Text == null)||(Paymnt13Amt9.Text == ""))
//			{
//				paymntTotal2Amt9 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt9 = Convert.ToDouble(Paymnt13Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt9.Text == null)||(Paymnt14Amt9.Text == ""))
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt14Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt9.Text == null)||(Paymnt15Amt9.Text == ""))
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt15Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt9.Text == null)||(Paymnt16Amt9.Text == ""))
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt9 = paymntTotal2Amt9 + Convert.ToDouble(Paymnt16Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt9Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt9Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType9.Text == "2")
//				if(PaymntBnsDispType9.Text == "2")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType9.Text == "3")
//				else if(PaymntBnsDispType9.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType9.Text == "4")
//				else if(PaymntBnsDispType9.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt9.Text = paymntTotal2Amt9.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt13Amt10.Text == null)||(Paymnt13Amt10.Text == ""))
//			{
//				paymntTotal2Amt10 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt10 = Convert.ToDouble(Paymnt13Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt10.Text == null)||(Paymnt14Amt10.Text == ""))
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt14Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt10.Text == null)||(Paymnt15Amt10.Text == ""))
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt15Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt10.Text == null)||(Paymnt16Amt10.Text == ""))
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt10 = paymntTotal2Amt10 + Convert.ToDouble(Paymnt16Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt10Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType10.Text == "2")
//				if(PaymntBnsDispType10.Text == "2")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType10.Text == "3")
//				else if(PaymntBnsDispType10.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("#,##0.00");
//				}
//// 管理番号 B15940 From
//				//else if(PaymntDispType10.Text == "4")
//				else if(PaymntBnsDispType10.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt10.Text = paymntTotal2Amt10.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt13Amt11.Text == null)||(Paymnt13Amt11.Text == ""))
//			{
//				paymntTotal2Amt11 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt11 = Convert.ToDouble(Paymnt13Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt11.Text == null)||(Paymnt14Amt11.Text == ""))
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt14Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt11.Text == null)||(Paymnt15Amt11.Text == ""))
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt15Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt11.Text == null)||(Paymnt16Amt11.Text == ""))
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt11 = paymntTotal2Amt11 + Convert.ToDouble(Paymnt16Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt11Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt11Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType11.Text == "2")
//				if(PaymntBnsDispType11.Text == "2")
//// 管理番号 B15940 From			
//				{
//					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType11.Text == "3")
//				else if(PaymntBnsDispType11.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType11.Text == "4")
//				else if(PaymntBnsDispType11.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt11.Text = paymntTotal2Amt11.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Paymnt13Amt12.Text == null)||(Paymnt13Amt12.Text == ""))
//			{
//				paymntTotal2Amt12 = 0;
//			}
//			else
//			{
//				paymntTotal2Amt12 = Convert.ToDouble(Paymnt13Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Paymnt14Amt12.Text == null)||(Paymnt14Amt12.Text == ""))
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt14Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt15Amt12.Text == null)||(Paymnt15Amt12.Text == ""))
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt15Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt16Amt12.Text == null)||(Paymnt16Amt12.Text == ""))
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + 0;
//			}
//			else
//			{
//				paymntTotal2Amt12 = paymntTotal2Amt12 + Convert.ToDouble(Paymnt16Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(paymntTotal2Amt12Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(PaymntDispType12.Text == "2")
//				if(PaymntBnsDispType12.Text == "2")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("###0");
//				}
//// 管理番号 B15940 From
//				//else if(PaymntDispType12.Text == "3")
//				else if(PaymntBnsDispType12.Text == "3")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(PaymntDispType12.Text == "4")
//				else if(PaymntBnsDispType12.Text == "4")
//// 管理番号 B15940 To
//				{
//					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("###0.00");
//				}
//
//				else
//				{
//					PaymntTotal2Amt12.Text = paymntTotal2Amt12.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal2Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To








			//給与控除額の合計処理
			if ((Ded1Amt1.Text == null) || (Ded1Amt1.Text == ""))
			{
				dedTotal1Amt1 = 0;
			}
			else
			{
				dedTotal1Amt1 = Convert.ToDouble(Ded1Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt1.Text == null) || (Ded2Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded2Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt1.Text == null) || (Ded3Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded3Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt1.Text == null) || (Ded4Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded4Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt1.Text == null) || (Ded5Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded5Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt1.Text == null) || (Ded6Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded6Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt1.Text == null) || (Ded7Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded7Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt1.Text == null) || (Ded8Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded8Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt1.Text == null) || (Ded9Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded9Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B24738 From
//			if ((Ded10Amt11.Text == null) || (Ded10Amt1.Text == ""))
			if ((Ded10Amt1.Text == null) || (Ded10Amt1.Text == ""))
// 管理番号 B24738 To
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded10Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt1.Text == null) || (Ded11Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded11Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt1.Text == null) || (Ded12Amt1.Text == ""))
			{
				dedTotal1Amt1 = dedTotal1Amt1 + 0;
			}
			else
			{
				dedTotal1Amt1 = dedTotal1Amt1 + Convert.ToDouble(Ded12Amt1.Text);
// 管理番号 B15940 From
				dedTotal1Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt1Flg)
			{
// 管理番号 B15940 To
				if (DedDispType1.Text == "2")
				{
					DedTotal1Amt1.Text = dedTotal1Amt1.ToString("###0");
				}

				else if (DedDispType1.Text == "3")
				{
					DedTotal1Amt1.Text = dedTotal1Amt1.ToString("#,##0.00");
				}

				else if (DedDispType1.Text == "4")
				{
					DedTotal1Amt1.Text = dedTotal1Amt1.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt1.Text = dedTotal1Amt1.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt1.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded1Amt2.Text == null) || (Ded1Amt2.Text == ""))
			{
				dedTotal1Amt2 = 0;
			}
			else
			{
				dedTotal1Amt2 = Convert.ToDouble(Ded1Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt2.Text == null) || (Ded2Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded2Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt2.Text == null) || (Ded3Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded3Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt2.Text == null) || (Ded4Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded4Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt2.Text == null) || (Ded5Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded5Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt2.Text == null) || (Ded6Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded6Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt2.Text == null) || (Ded7Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded7Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt2.Text == null) || (Ded8Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded8Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt2.Text == null) || (Ded9Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded9Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded10Amt2.Text == null) || (Ded10Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded10Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt2.Text == null) || (Ded11Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded11Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt2.Text == null) || (Ded12Amt2.Text == ""))
			{
				dedTotal1Amt2 = dedTotal1Amt2 + 0;
			}
			else
			{
				dedTotal1Amt2 = dedTotal1Amt2 + Convert.ToDouble(Ded12Amt2.Text);
// 管理番号 B15940 From
				dedTotal1Amt2Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt2Flg)
			{
// 管理番号 B15940 To
				if (DedDispType2.Text == "2")
				{
					DedTotal1Amt2.Text = dedTotal1Amt2.ToString("###0");
				}

				else if (DedDispType2.Text == "3")
				{
					DedTotal1Amt2.Text = dedTotal1Amt2.ToString("#,##0.00");
				}

				else if (DedDispType2.Text == "4")
				{
					DedTotal1Amt2.Text = dedTotal1Amt2.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt2.Text = dedTotal1Amt2.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt2.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded1Amt3.Text == null) || (Ded1Amt3.Text == ""))
			{
				dedTotal1Amt3 = 0;
			}
			else
			{
				dedTotal1Amt3 = Convert.ToDouble(Ded1Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt3.Text == null) || (Ded2Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded2Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt3.Text == null) || (Ded3Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded3Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt3.Text == null) || (Ded4Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded4Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt3.Text == null) || (Ded5Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded5Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt3.Text == null) || (Ded6Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded6Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt3.Text == null) || (Ded7Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded7Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt3.Text == null) || (Ded8Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded8Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt3.Text == null) || (Ded9Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded9Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded10Amt3.Text == null) || (Ded10Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded10Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt3.Text == null) || (Ded11Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded11Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt3.Text == null) || (Ded12Amt3.Text == ""))
			{
				dedTotal1Amt3 = dedTotal1Amt3 + 0;
			}
			else
			{
				dedTotal1Amt3 = dedTotal1Amt3 + Convert.ToDouble(Ded12Amt3.Text);
// 管理番号 B15940 From
				dedTotal1Amt3Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt3Flg)
			{
// 管理番号 B15940 To
				if (DedDispType3.Text == "2")
				{
					DedTotal1Amt3.Text = dedTotal1Amt3.ToString("###0");
				}

				else if (DedDispType3.Text == "3")
				{
					DedTotal1Amt3.Text = dedTotal1Amt3.ToString("#,##0.00");
				}

				else if (DedDispType3.Text == "4")
				{
					DedTotal1Amt3.Text = dedTotal1Amt3.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt3.Text = dedTotal1Amt3.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt3.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded1Amt4.Text == null) || (Ded1Amt4.Text == ""))
			{
				dedTotal1Amt4 = 0;
			}
			else
			{
				dedTotal1Amt4 = Convert.ToDouble(Ded1Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt4.Text == null) || (Ded2Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded2Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt4.Text == null) || (Ded3Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded3Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt4.Text == null) || (Ded4Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded4Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt4.Text == null) || (Ded5Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded5Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt4.Text == null) || (Ded6Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded6Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt4.Text == null) || (Ded7Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded7Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt4.Text == null) || (Ded8Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded8Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt4.Text == null) || (Ded9Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded9Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded10Amt4.Text == null) || (Ded10Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded10Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt4.Text == null) || (Ded11Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded11Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt4.Text == null) || (Ded12Amt4.Text == ""))
			{
				dedTotal1Amt4 = dedTotal1Amt4 + 0;
			}
			else
			{
				dedTotal1Amt4 = dedTotal1Amt4 + Convert.ToDouble(Ded12Amt4.Text);
// 管理番号 B15940 From
				dedTotal1Amt4Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt4Flg)
			{
// 管理番号 B15940 To
				if (DedDispType4.Text == "2")
				{
					DedTotal1Amt4.Text = dedTotal1Amt4.ToString("###0");
				}

				else if (DedDispType4.Text == "3")
				{
					DedTotal1Amt4.Text = dedTotal1Amt4.ToString("#,##0.00");
				}

				else if (DedDispType4.Text == "4")
				{
					DedTotal1Amt4.Text = dedTotal1Amt4.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt4.Text = dedTotal1Amt4.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt4.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded1Amt5.Text == null) || (Ded1Amt5.Text == ""))
			{
				dedTotal1Amt5 = 0;
			}
			else
			{
				dedTotal1Amt5 = Convert.ToDouble(Ded1Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt5.Text == null) || (Ded2Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded2Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt5.Text == null) || (Ded3Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded3Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt5.Text == null) || (Ded4Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded4Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt5.Text == null) || (Ded5Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded5Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt5.Text == null) || (Ded6Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded6Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt5.Text == null) || (Ded7Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded7Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt5.Text == null) || (Ded8Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded8Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt5.Text == null) || (Ded9Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded9Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded10Amt5.Text == null) || (Ded10Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded10Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt5.Text == null) || (Ded11Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded11Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt5.Text == null) || (Ded12Amt5.Text == ""))
			{
				dedTotal1Amt5 = dedTotal1Amt5 + 0;
			}
			else
			{
				dedTotal1Amt5 = dedTotal1Amt5 + Convert.ToDouble(Ded12Amt5.Text);
// 管理番号 B15940 From
				dedTotal1Amt5Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt5Flg)
			{
// 管理番号 B15940 To
				if (DedDispType5.Text == "2")
				{
					DedTotal1Amt5.Text = dedTotal1Amt5.ToString("###0");
				}

				else if (DedDispType5.Text == "3")
				{
					DedTotal1Amt5.Text = dedTotal1Amt5.ToString("#,##0.00");
				}

				else if (DedDispType5.Text == "4")
				{
					DedTotal1Amt5.Text = dedTotal1Amt5.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt5.Text = dedTotal1Amt5.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt5.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded1Amt6.Text == null) || (Ded1Amt6.Text == ""))
			{
				dedTotal1Amt6 = 0;
			}
			else
			{
				dedTotal1Amt6 = Convert.ToDouble(Ded1Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded2Amt6.Text == null) || (Ded2Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded2Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded3Amt6.Text == null) || (Ded3Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded3Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded4Amt6.Text == null) || (Ded4Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded4Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded5Amt6.Text == null) || (Ded5Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded5Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded6Amt6.Text == null) || (Ded6Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded6Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded7Amt6.Text == null) || (Ded7Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded7Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded8Amt6.Text == null) || (Ded8Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded8Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded9Amt6.Text == null) || (Ded9Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded9Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded10Amt6.Text == null) || (Ded10Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded10Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded11Amt6.Text == null) || (Ded11Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded11Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded12Amt6.Text == null) || (Ded12Amt6.Text == ""))
			{
				dedTotal1Amt6 = dedTotal1Amt6 + 0;
			}
			else
			{
				dedTotal1Amt6 = dedTotal1Amt6 + Convert.ToDouble(Ded12Amt6.Text);
// 管理番号 B15940 From
				dedTotal1Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal1Amt6Flg)
			{
// 管理番号 B15940 To
				if (DedDispType6.Text == "2")
				{
					DedTotal1Amt6.Text = dedTotal1Amt6.ToString("###0");
				}

				else if (DedDispType6.Text == "3")
				{
					DedTotal1Amt6.Text = dedTotal1Amt6.ToString("#,##0.00");
				}

				else if (DedDispType6.Text == "4")
				{
					DedTotal1Amt6.Text = dedTotal1Amt6.ToString("###0.00");
				}

				else
				{
					DedTotal1Amt6.Text = dedTotal1Amt6.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal1Amt6.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if((Ded1Amt7.Text == null)||(Ded1Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = Convert.ToDouble(Ded1Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt7.Text == null)||(Ded2Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded2Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt7.Text == null)||(Ded3Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded3Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt7.Text == null)||(Ded4Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded4Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt7.Text == null)||(Ded5Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded5Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt7.Text == null)||(Ded6Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded6Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt7.Text == null)||(Ded7Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded7Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt7.Text == null)||(Ded8Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded8Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt7.Text == null)||(Ded9Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded9Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt7.Text == null)||(Ded10Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded10Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt7.Text == null)||(Ded11Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded11Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt7.Text == null)||(Ded12Amt7.Text == ""))
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + 0;
//			}
//			else
//			{
//				dedTotal1Amt7 = dedTotal1Amt7 + Convert.ToDouble(Ded12Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt7Flg)
//			{
//// 管理番号 B15940 To
//				if(DedDispType7.Text == "2")
//				{
//					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("###0");
//				}
//
//				else if(DedDispType7.Text == "3")
//				{
//					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("#,##0.00");
//				}
//
//				else if(DedDispType7.Text == "4")
//				{
//					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal1Amt7.Text = dedTotal1Amt7.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded1Amt8.Text == null)||(Ded1Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = Convert.ToDouble(Ded1Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt8.Text == null)||(Ded2Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded2Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt8.Text == null)||(Ded3Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded3Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt8.Text == null)||(Ded4Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded4Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt8.Text == null)||(Ded5Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded5Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt8.Text == null)||(Ded6Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded6Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt8.Text == null)||(Ded7Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded7Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt8.Text == null)||(Ded8Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded8Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt8.Text == null)||(Ded9Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded9Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt8.Text == null)||(Ded10Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded10Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt8.Text == null)||(Ded11Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded11Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt8.Text == null)||(Ded12Amt8.Text == ""))
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + 0;
//			}
//			else
//			{
//				dedTotal1Amt8 = dedTotal1Amt8 + Convert.ToDouble(Ded12Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt8Flg)
//			{
//// 管理番号 B15940 To
//				if(DedDispType8.Text == "2")
//				{
//					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("###0");
//				}
//
//				else if(DedDispType8.Text == "3")
//				{
//					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("#,##0.00");
//				}
//
//				else if(DedDispType8.Text == "4")
//				{
//					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal1Amt8.Text = dedTotal1Amt8.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt8.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded1Amt9.Text == null)||(Ded1Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = Convert.ToDouble(Ded1Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt9.Text == null)||(Ded2Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded2Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt9.Text == null)||(Ded3Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded3Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt9.Text == null)||(Ded4Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded4Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt9.Text == null)||(Ded5Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded5Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt9.Text == null)||(Ded6Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded6Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt9.Text == null)||(Ded7Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded7Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt9.Text == null)||(Ded8Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded8Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt9.Text == null)||(Ded9Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded9Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt9.Text == null)||(Ded10Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded10Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt9.Text == null)||(Ded11Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded11Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt9.Text == null)||(Ded12Amt9.Text == ""))
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + 0;
//			}
//			else
//			{
//				dedTotal1Amt9 = dedTotal1Amt9 + Convert.ToDouble(Ded12Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt9Flg)
//			{
//// 管理番号 B15940 To
//				if(DedDispType9.Text == "2")
//				{
//					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("###0");
//				}
//
//				else if(DedDispType9.Text == "3")
//				{
//					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("#,##0.00");
//				}
//
//				else if(DedDispType9.Text == "4")
//				{
//					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal1Amt9.Text = dedTotal1Amt9.ToString("#,##0");
//				}			
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded1Amt10.Text == null)||(Ded1Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = Convert.ToDouble(Ded1Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt10.Text == null)||(Ded2Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded2Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt10.Text == null)||(Ded3Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded3Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt10.Text == null)||(Ded4Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded4Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt10.Text == null)||(Ded5Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded5Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt10.Text == null)||(Ded6Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded6Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt10.Text == null)||(Ded7Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded7Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt10.Text == null)||(Ded8Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded8Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt10.Text == null)||(Ded9Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded9Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt10.Text == null)||(Ded10Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded10Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt10.Text == null)||(Ded11Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded11Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt10.Text == null)||(Ded12Amt10.Text == ""))
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + 0;
//			}
//			else
//			{
//				dedTotal1Amt10 = dedTotal1Amt10 + Convert.ToDouble(Ded12Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt10Flg)
//			{
//// 管理番号 B15940 To
//				if(DedDispType10.Text == "2")
//				{
//					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("###0");
//				}
//
//				else if(DedDispType10.Text == "3")
//				{
//					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("#,##0.00");
//				}
//
//				else if(DedDispType10.Text == "4")
//				{
//					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal1Amt10.Text = dedTotal1Amt10.ToString("#,##0");
//				}			
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded1Amt11.Text == null)||(Ded1Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = Convert.ToDouble(Ded1Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt11.Text == null)||(Ded2Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded2Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt11.Text == null)||(Ded3Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded3Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt11.Text == null)||(Ded4Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded4Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt11.Text == null)||(Ded5Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded5Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt11.Text == null)||(Ded6Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded6Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt11.Text == null)||(Ded7Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded7Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt11.Text == null)||(Ded8Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded8Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt11.Text == null)||(Ded9Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded9Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt11.Text == null)||(Ded10Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded10Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt11.Text == null)||(Ded11Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded11Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt11.Text == null)||(Ded12Amt11.Text == ""))
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + 0;
//			}
//			else
//			{
//				dedTotal1Amt11 = dedTotal1Amt11 + Convert.ToDouble(Ded12Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt11Flg)
//			{
//// 管理番号 B15940 To
//			if(DedDispType11.Text == "2")
//			{
//				DedTotal1Amt11.Text = dedTotal1Amt11.ToString("###0");
//			}
//
//			else if(DedDispType11.Text == "3")
//			{
//				DedTotal1Amt11.Text = dedTotal1Amt11.ToString("#,##0.00");
//			}
//
//			else if(DedDispType11.Text == "4")
//			{
//				DedTotal1Amt11.Text = dedTotal1Amt11.ToString("###0.00");
//			}
//
//			else
//			{
//				DedTotal1Amt11.Text = dedTotal1Amt11.ToString("#,##0");
//			}			
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded1Amt12.Text == null)||(Ded1Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = Convert.ToDouble(Ded1Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded2Amt12.Text == null)||(Ded2Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded2Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded3Amt12.Text == null)||(Ded3Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded3Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded4Amt12.Text == null)||(Ded4Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded4Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded5Amt12.Text == null)||(Ded5Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded5Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded6Amt12.Text == null)||(Ded6Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded6Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded7Amt12.Text == null)||(Ded7Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded7Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded8Amt12.Text == null)||(Ded8Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded8Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Ded9Amt12.Text == null)||(Ded9Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded9Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded10Amt12.Text == null)||(Ded10Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded10Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded11Amt12.Text == null)||(Ded11Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded11Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded12Amt12.Text == null)||(Ded12Amt12.Text == ""))
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + 0;
//			}
//			else
//			{
//				dedTotal1Amt12 = dedTotal1Amt12 + Convert.ToDouble(Ded12Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal1Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dedTotal1Amt12Flg)
//			{
//// 管理番号 B15940 To
//				if(DedDispType12.Text == "2")
//				{
//					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("###0");
//				}
//
//				else if(DedDispType12.Text == "3")
//				{
//					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("#,##0.00");
//				}
//
//				else if(DedDispType12.Text == "4")
//				{
//					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal1Amt12.Text = dedTotal1Amt12.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal1Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To


			//賞与控除合計の処理
			if ((Ded13Amt1.Text == null) || (Ded13Amt1.Text == ""))
			{
				dedTotal2Amt1 = 0;
			}
			else
			{
				dedTotal2Amt1 = Convert.ToDouble(Ded13Amt1.Text);
// 管理番号 B15940 From
				dedTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt1.Text == null) || (Ded14Amt1.Text == ""))
			{
				dedTotal2Amt1 = dedTotal2Amt1 + 0;
			}
			else
			{
				dedTotal2Amt1 = dedTotal2Amt1 + Convert.ToDouble(Ded14Amt1.Text);
// 管理番号 B15940 From
				dedTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt1.Text == null) || (Ded15Amt1.Text == ""))
			{
				dedTotal2Amt1 = dedTotal2Amt1 + 0;
			}
			else
			{
				dedTotal2Amt1 = dedTotal2Amt1 + Convert.ToDouble(Ded15Amt1.Text);
// 管理番号 B15940 From
				dedTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt1.Text == null) || (Ded16Amt1.Text == ""))
			{
				dedTotal2Amt1 = dedTotal2Amt1 + 0;
			}
			else
			{
				dedTotal2Amt1 = dedTotal2Amt1 + Convert.ToDouble(Ded16Amt1.Text);
// 管理番号 B15940 From
				dedTotal2Amt1Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt1Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType1.Text == "2")
				if (DedBnsDispType1.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt1.Text = dedTotal2Amt1.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(DedDispType1.Text == "3")
				else if (DedBnsDispType1.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt1.Text = dedTotal2Amt1.ToString("#,##0.00");
				}
// 管理番号 B15940 From
				//else if(DedDispType1.Text == "4")
				else if (DedBnsDispType1.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt1.Text = dedTotal2Amt1.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt1.Text = dedTotal2Amt1.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt1.Text = "";
			}
// 管理番号 B15940 To


			if ((Ded13Amt2.Text == null) || (Ded13Amt2.Text == ""))
			{
				dedTotal2Amt2 = 0;
			}
			else
			{
				dedTotal2Amt2 = Convert.ToDouble(Ded13Amt2.Text);
// 管理番号 B15940 From
				dedTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt2.Text == null) || (Ded14Amt2.Text == ""))
			{
				dedTotal2Amt2 = dedTotal2Amt2 + 0;
			}
			else
			{
				dedTotal2Amt2 = dedTotal2Amt2 + Convert.ToDouble(Ded14Amt2.Text);
// 管理番号 B15940 From
				dedTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt2.Text == null) || (Ded15Amt2.Text == ""))
			{
				dedTotal2Amt2 = dedTotal2Amt2 + 0;
			}
			else
			{
				dedTotal2Amt2 = dedTotal2Amt2 + Convert.ToDouble(Ded15Amt2.Text);
// 管理番号 B15940 From
				dedTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt2.Text == null) || (Ded16Amt2.Text == ""))
			{
				dedTotal2Amt2 = dedTotal2Amt2 + 0;
			}
			else
			{
				dedTotal2Amt2 = dedTotal2Amt2 + Convert.ToDouble(Ded16Amt2.Text);
// 管理番号 B15940 From
				dedTotal2Amt2Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt2Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType2.Text == "2")
				if (DedBnsDispType2.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt2.Text = dedTotal2Amt2.ToString("###0");
				}
// 管理番号 B15940 From
				//else if(DedDispType2.Text == "3")
				else if (DedBnsDispType2.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt2.Text = dedTotal2Amt2.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(DedDispType2.Text == "4")
				else if (DedBnsDispType2.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt2.Text = dedTotal2Amt2.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt2.Text = dedTotal2Amt2.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt2.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded13Amt3.Text == null) || (Ded13Amt3.Text == ""))
			{
				dedTotal2Amt3 = 0;
			}
			else
			{
				dedTotal2Amt3 = Convert.ToDouble(Ded13Amt3.Text);
// 管理番号 B15940 From
				dedTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt3.Text == null) || (Ded14Amt3.Text == ""))
			{
				dedTotal2Amt3 = dedTotal2Amt3 + 0;
			}
			else
			{
				dedTotal2Amt3 = dedTotal2Amt3 + Convert.ToDouble(Ded14Amt3.Text);
// 管理番号 B15940 From
				dedTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt3.Text == null) || (Ded15Amt3.Text == ""))
			{
				dedTotal2Amt3 = dedTotal2Amt3 + 0;
			}
			else
			{
				dedTotal2Amt3 = dedTotal2Amt3 + Convert.ToDouble(Ded15Amt3.Text);
// 管理番号 B15940 From
				dedTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt3.Text == null) || (Ded16Amt3.Text == ""))
			{
				dedTotal2Amt3 = dedTotal2Amt3 + 0;
			}
			else
			{
				dedTotal2Amt3 = dedTotal2Amt3 + Convert.ToDouble(Ded16Amt3.Text);
// 管理番号 B15940 From
				dedTotal2Amt3Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt3Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType3.Text == "2")
				if (DedBnsDispType3.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt3.Text = dedTotal2Amt3.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(DedDispType3.Text == "3")
				else if (DedBnsDispType3.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt3.Text = dedTotal2Amt3.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(DedDispType3.Text == "4")
				else if (DedBnsDispType3.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt3.Text = dedTotal2Amt3.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt3.Text = dedTotal2Amt3.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt3.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded13Amt4.Text == null) || (Ded13Amt4.Text == ""))
			{
				dedTotal2Amt4 = 0;
			}
			else
			{
				dedTotal2Amt4 = Convert.ToDouble(Ded13Amt4.Text);
// 管理番号 B15940 From
				dedTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt4.Text == null) || (Ded14Amt4.Text == ""))
			{
				dedTotal2Amt4 = dedTotal2Amt4 + 0;
			}
			else
			{
				dedTotal2Amt4 = dedTotal2Amt4 + Convert.ToDouble(Ded14Amt4.Text);
// 管理番号 B15940 From
				dedTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt4.Text == null) || (Ded15Amt4.Text == ""))
			{
				dedTotal2Amt4 = dedTotal2Amt4 + 0;
			}
			else
			{
				dedTotal2Amt4 = dedTotal2Amt4 + Convert.ToDouble(Ded15Amt4.Text);
// 管理番号 B15940 From
				dedTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt4.Text == null) || (Ded16Amt4.Text == ""))
			{
				dedTotal2Amt4 = dedTotal2Amt4 + 0;
			}
			else
			{
				dedTotal2Amt4 = dedTotal2Amt4 + Convert.ToDouble(Ded16Amt4.Text);
// 管理番号 B15940 From
				dedTotal2Amt4Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt4Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType4.Text == "2")
				if (DedBnsDispType4.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt4.Text = dedTotal2Amt4.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(DedDispType4.Text == "3")
				else if (DedBnsDispType4.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt4.Text = dedTotal2Amt4.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(DedDispType4.Text == "4")
				else if (DedBnsDispType4.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt4.Text = dedTotal2Amt4.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt4.Text = dedTotal2Amt4.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt4.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded13Amt5.Text == null) || (Ded13Amt5.Text == ""))
			{
				dedTotal2Amt5 = 0;
			}
			else
			{
				dedTotal2Amt5 = Convert.ToDouble(Ded13Amt5.Text);
// 管理番号 B15940 From
				dedTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt5.Text == null) || (Ded14Amt5.Text == ""))
			{
				dedTotal2Amt5 = dedTotal2Amt5 + 0;
			}
			else
			{
				dedTotal2Amt5 = dedTotal2Amt5 + Convert.ToDouble(Ded14Amt5.Text);
// 管理番号 B15940 From
				dedTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt5.Text == null) || (Ded15Amt5.Text == ""))
			{
				dedTotal2Amt5 = dedTotal2Amt5 + 0;
			}
			else
			{
				dedTotal2Amt5 = dedTotal2Amt5 + Convert.ToDouble(Ded15Amt5.Text);
// 管理番号 B15940 From
				dedTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt5.Text == null) || (Ded16Amt5.Text == ""))
			{
				dedTotal2Amt5 = dedTotal2Amt5 + 0;
			}
			else
			{
				dedTotal2Amt5 = dedTotal2Amt5 + Convert.ToDouble(Ded16Amt5.Text);
// 管理番号 B15940 From
				dedTotal2Amt5Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt5Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType5.Text == "2")
				if (DedBnsDispType5.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt5.Text = dedTotal2Amt5.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(DedDispType5.Text == "3")
				else if (DedBnsDispType5.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt5.Text = dedTotal2Amt5.ToString("#,##0.00");
				}

// 管理番号 B15940 From
				//else if(DedDispType5.Text == "4")
				else if (DedBnsDispType5.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt5.Text = dedTotal2Amt5.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt5.Text = dedTotal2Amt5.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt5.Text = "";
			}
// 管理番号 B15940 To

			if ((Ded13Amt6.Text == null) || (Ded13Amt6.Text == ""))
			{
				dedTotal2Amt6 = 0;
			}
			else
			{
				dedTotal2Amt6 = Convert.ToDouble(Ded13Amt6.Text);
// 管理番号 B15940 From
				dedTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded14Amt6.Text == null) || (Ded14Amt6.Text == ""))
			{
				dedTotal2Amt6 = dedTotal2Amt6 + 0;
			}
			else
			{
				dedTotal2Amt6 = dedTotal2Amt6 + Convert.ToDouble(Ded14Amt6.Text);
// 管理番号 B15940 From
				dedTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded15Amt6.Text == null) || (Ded15Amt6.Text == ""))
			{
				dedTotal2Amt6 = dedTotal2Amt6 + 0;
			}
			else
			{
				dedTotal2Amt6 = dedTotal2Amt6 + Convert.ToDouble(Ded15Amt6.Text);
// 管理番号 B15940 From
				dedTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded16Amt6.Text == null) || (Ded16Amt6.Text == ""))
			{
				dedTotal2Amt6 = dedTotal2Amt6 + 0;
			}
			else
			{
				dedTotal2Amt6 = dedTotal2Amt6 + Convert.ToDouble(Ded16Amt6.Text);
// 管理番号 B15940 From
				dedTotal2Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 B15940 From
			if (dedTotal2Amt6Flg)
			{
// 管理番号 B15940 To
// 管理番号 B15940 From
				//if(DedDispType6.Text == "2")
				if (DedBnsDispType6.Text == "2")
// 管理番号 B15940 To
				{
					DedTotal2Amt6.Text = dedTotal2Amt6.ToString("###0");
				}

// 管理番号 B15940 From
				//else if(DedDispType6.Text == "3")
				else if (DedBnsDispType6.Text == "3")
// 管理番号 B15940 To
				{
					DedTotal2Amt6.Text = dedTotal2Amt6.ToString("#,##0.00");
				}
// 管理番号 B15940 From
				//else if(DedDispType6.Text == "4")
				else if (DedBnsDispType6.Text == "4")
// 管理番号 B15940 To
				{
					DedTotal2Amt6.Text = dedTotal2Amt6.ToString("###0.00");
				}

				else
				{
					DedTotal2Amt6.Text = dedTotal2Amt6.ToString("#,##0");
				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal2Amt6.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if((Ded13Amt7.Text == null)||(Ded13Amt7.Text == ""))
//			{
//				dedTotal2Amt7 = 0;
//			}
//			else
//			{
//				dedTotal2Amt7 = Convert.ToDouble(Ded13Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded14Amt7.Text == null)||(Ded14Amt7.Text == ""))
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + 0;
//			}
//			else
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded14Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded15Amt7.Text == null)||(Ded15Amt7.Text == ""))
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + 0;
//			}
//			else
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded15Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded16Amt7.Text == null)||(Ded16Amt7.Text == ""))
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + 0;
//			}
//			else
//			{
//				dedTotal2Amt7 = dedTotal2Amt7 + Convert.ToDouble(Ded16Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt7Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(dedTotal2Amt7Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(DedDispType7.Text == "2")
//				if(DedBnsDispType7.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("###0");
//				}
//// 管理番号 B15940 From
//				//else if(DedDispType7.Text == "3")
//				else if(DedBnsDispType7.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("#,##0.00");
//				}
//// 管理番号 B15940 From
//				//else if(DedDispType7.Text == "4")
//				else if(DedBnsDispType7.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt7.Text = dedTotal2Amt7.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal2Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//
//			if((Ded13Amt8.Text == null)||(Ded13Amt8.Text == ""))
//			{
//				dedTotal2Amt8 = 0;
//			}
//			else
//			{
//				dedTotal2Amt8 = Convert.ToDouble(Ded13Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded14Amt8.Text == null)||(Ded14Amt8.Text == ""))
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + 0;
//			}
//			else
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded14Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded15Amt8.Text == null)||(Ded15Amt8.Text == ""))
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + 0;
//			}
//			else
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded15Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//
//			}
//
//			if((Ded16Amt8.Text == null)||(Ded16Amt8.Text == ""))
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + 0;
//			}
//			else
//			{
//				dedTotal2Amt8 = dedTotal2Amt8 + Convert.ToDouble(Ded16Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt8Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(dedTotal2Amt8Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(DedDispType8.Text == "2")
//				if(DedBnsDispType8.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType8.Text == "3")
//				else if(DedBnsDispType8.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("#,##0.00");
//				}
//// 管理番号 B15940 From
//				//else if(DedDispType8.Text == "4")
//				else if(DedBnsDispType8.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt8.Text = dedTotal2Amt8.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal2Amt8.Text = "";
//			}
//
//			if((Ded13Amt9.Text == null)||(Ded13Amt9.Text == ""))
//			{
//				dedTotal2Amt9 = 0;
//			}
//			else
//			{
//				dedTotal2Amt9 = Convert.ToDouble(Ded13Amt9.Text);
//				dedTotal2Amt9Flg = true;
//			}
//			
//			if((Ded14Amt9.Text == null)||(Ded14Amt9.Text == ""))
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + 0;
//			}
//			else
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded14Amt9.Text);
//				dedTotal2Amt9Flg = true;
//			}
//
//			if((Ded15Amt9.Text == null)||(Ded15Amt9.Text == ""))
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + 0;
//			}
//			else
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded15Amt9.Text);
//				dedTotal2Amt9Flg = true;
//			}
//
//			if((Ded16Amt9.Text == null)||(Ded16Amt9.Text == ""))
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + 0;
//			}
//			else
//			{
//				dedTotal2Amt9 = dedTotal2Amt9 + Convert.ToDouble(Ded16Amt9.Text);
//				dedTotal2Amt9Flg = true;
//			}			
//
//			if(dedTotal2Amt9Flg)
//			{
//// 管理番号 B15940 From
//				//if(DedDispType9.Text == "2")
//				if(DedBnsDispType9.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType9.Text == "3")
//				else if(DedBnsDispType9.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType9.Text == "4")
//				else if(DedBnsDispType9.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt9.Text = dedTotal2Amt9.ToString("#,##0");
//				}
//			}
//			else
//			{
//				DedTotal2Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded13Amt10.Text == null)||(Ded13Amt10.Text == ""))
//			{
//				dedTotal2Amt10 = 0;
//			}
//			else
//			{
//				dedTotal2Amt10 = Convert.ToDouble(Ded13Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded14Amt10.Text == null)||(Ded14Amt10.Text == ""))
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + 0;
//			}
//			else
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded14Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded15Amt10.Text == null)||(Ded15Amt10.Text == ""))
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + 0;
//			}
//			else
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded15Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded16Amt10.Text == null)||(Ded16Amt10.Text == ""))
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + 0;
//			}
//			else
//			{
//				dedTotal2Amt10 = dedTotal2Amt10 + Convert.ToDouble(Ded16Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt10Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(dedTotal2Amt10Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(DedDispType10.Text == "2")
//				if(DedBnsDispType10.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("###0");
//				}
//// 管理番号 B15940 From
//				//else if(DedDispType10.Text == "3")
//				else if(DedBnsDispType10.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType10.Text == "4")
//				else if(DedBnsDispType10.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt10.Text = dedTotal2Amt10.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal2Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded13Amt11.Text == null)||(Ded13Amt11.Text == ""))
//			{
//				dedTotal2Amt11 = 0;
//			}
//			else
//			{
//				dedTotal2Amt11 = Convert.ToDouble(Ded13Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt11Flg = true;
//// 管理番号 B15940 From
//			}
//			
//			if((Ded14Amt11.Text == null)||(Ded14Amt11.Text == ""))
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + 0;
//			}
//			else
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded14Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt11Flg = true;
//// 管理番号 B15940 From
//			}
//
//			if((Ded15Amt11.Text == null)||(Ded15Amt11.Text == ""))
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + 0;
//			}
//			else
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded15Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt11Flg = true;
//// 管理番号 B15940 From
//			}
//
//			if((Ded16Amt11.Text == null)||(Ded16Amt11.Text == ""))
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + 0;
//			}
//			else
//			{
//				dedTotal2Amt11 = dedTotal2Amt11 + Convert.ToDouble(Ded16Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt11Flg = true;
//// 管理番号 B15940 From
//			}			
//
//// 管理番号 B15940 From
//			if(dedTotal2Amt11Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(DedDispType11.Text == "2")
//				if(DedBnsDispType11.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("###0");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType11.Text == "3")
//				else if(DedBnsDispType11.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType11.Text == "4")
//				else if(DedBnsDispType11.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt11.Text = dedTotal2Amt11.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal2Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//			if((Ded13Amt12.Text == null)||(Ded13Amt12.Text == ""))
//			{
//				dedTotal2Amt12 = 0;
//			}
//			else
//			{
//				dedTotal2Amt12 = Convert.ToDouble(Ded13Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Ded14Amt12.Text == null)||(Ded14Amt12.Text == ""))
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + 0;
//			}
//			else
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded14Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded15Amt12.Text == null)||(Ded15Amt12.Text == ""))
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + 0;
//			}
//			else
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded15Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded16Amt12.Text == null)||(Ded16Amt12.Text == ""))
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + 0;
//			}
//			else
//			{
//				dedTotal2Amt12 = dedTotal2Amt12 + Convert.ToDouble(Ded16Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal2Amt12Flg = true;
//// 管理番号 B15940 To
//			}			
//
//// 管理番号 B15940 From
//			if(dedTotal2Amt12Flg)
//			{
//// 管理番号 B15940 To
//// 管理番号 B15940 From
//				//if(DedDispType12.Text == "2")
//				if(DedBnsDispType12.Text == "2")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("###0");
//				}
//// 管理番号 B15940 From
//				//else if(DedDispType12.Text == "3")
//				else if(DedBnsDispType12.Text == "3")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("#,##0.00");
//				}
//
//// 管理番号 B15940 From
//				//else if(DedDispType12.Text == "4")
//				else if(DedBnsDispType12.Text == "4")
//// 管理番号 B15940 To
//				{
//					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("###0.00");
//				}
//
//				else
//				{
//					DedTotal2Amt12.Text = dedTotal2Amt12.ToString("#,##0");
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal2Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To

// 管理番号 B24534 From
//			//勤怠合計処理
//// 管理番号 B14921 From
//			if(DtyName1.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num1.Text == null)||(Dty1Num1.Text == ""))
//				{
//					dtyTotal1 = 0;
//				}
//				else
//				{
//					dtyTotal1 = Convert.ToDouble(Dty1Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//			
//				if((Dty2Num1.Text == null)||(Dty2Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty2Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num1.Text == null)||(Dty3Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty3Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num1.Text == null)||(Dty4Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty4Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num1.Text == null)||(Dty5Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty5Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//			
//				if((Dty6Num1.Text == null)||(Dty6Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty6Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num1.Text == null)||(Dty7Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty7Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num1.Text == null)||(Dty8Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty8Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//            			
//				if((Dty9Num1.Text == null)||(Dty9Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty9Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num1.Text == null)||(Dty10Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty10Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//			
//				if((Dty11Num1.Text == null)||(Dty11Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty11Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num1.Text == null)||(Dty12Num1.Text == ""))
//				{
//					dtyTotal1 = dtyTotal1 + 0;
//				}
//				else
//				{
//					dtyTotal1 = dtyTotal1 + Convert.ToDouble(Dty12Num1.Text);
//// 管理番号 B15940 From
//					dtyTotal1Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal1Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType1.Text == "2")
//					{
//						DtyTotal1.Text = dtyTotal1.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType1.Text == "3")
//					{
//						DtyTotal1.Text = dtyTotal1.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType1.Text == "4")
//					{
//						DtyTotal1.Text = dtyTotal1.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal1.Text = dtyTotal1.ToString("#,##0.00");
//						DtyTotal1.Text = dtyTotal1.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal1.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName2.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//			if((Dty1Num2.Text == null)||(Dty1Num2.Text == ""))
//			{
//				dtyTotal2 = 0;
//			}
//			else
//			{
//				dtyTotal2 = Convert.ToDouble(Dty1Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Dty2Num2.Text == null)||(Dty2Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty2Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty3Num2.Text == null)||(Dty3Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty3Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty4Num2.Text == null)||(Dty4Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty4Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty5Num2.Text == null)||(Dty5Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty5Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Dty6Num2.Text == null)||(Dty6Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty6Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty7Num2.Text == null)||(Dty7Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty7Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty8Num2.Text == null)||(Dty8Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty8Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//            			
//			if((Dty9Num2.Text == null)||(Dty9Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty9Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty10Num2.Text == null)||(Dty10Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty10Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//			
//			if((Dty11Num2.Text == null)||(Dty11Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty11Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Dty12Num2.Text == null)||(Dty12Num2.Text == ""))
//			{
//				dtyTotal2 = dtyTotal2 + 0;
//			}
//			else
//			{
//				dtyTotal2 = dtyTotal2 + Convert.ToDouble(Dty12Num2.Text);
//// 管理番号 B15940 From
//				dtyTotal2Flg = true;
//// 管理番号 B15940 To
//			}
//
//// 管理番号 B15940 From
//			if(dtyTotal2Flg)
//			{
//// 管理番号 B15940 To
//				if(DtyDispType2.Text == "2")
//				{
//					DtyTotal2.Text = dtyTotal2.ToString("#,##0.00");
//				}
//
//				else if(DtyDispType2.Text == "3")
//				{
//					DtyTotal2.Text = dtyTotal2.ToString("#,##0.00");
//				}
//
//				else if(DtyDispType2.Text == "4")
//				{
//					DtyTotal2.Text = dtyTotal2.ToString("#,##0.00");
//				}
//
//				else
//				{
//// 管理番号 B14921 From
//					//DtyTotal2.Text = dtyTotal2.ToString("#,##0.00");
//					DtyTotal2.Text = dtyTotal2.ToString("#,##0");
//// 管理番号 B14921 To
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DtyTotal2.Text = "";
//			}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName3.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num3.Text == null)||(Dty1Num3.Text == ""))
//				{
//					dtyTotal3 = 0;
//				}
//				else
//				{
//					dtyTotal3 = Convert.ToDouble(Dty1Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num3.Text == null)||(Dty2Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty2Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num3.Text == null)||(Dty3Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty3Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num3.Text == null)||(Dty4Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty4Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num3.Text == null)||(Dty5Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty5Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num3.Text == null)||(Dty6Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty6Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num3.Text == null)||(Dty7Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty7Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num3.Text == null)||(Dty8Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty8Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num3.Text == null)||(Dty9Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty9Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num3.Text == null)||(Dty10Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty10Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num3.Text == null)||(Dty11Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty11Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num3.Text == null)||(Dty12Num3.Text == ""))
//				{
//					dtyTotal3 = dtyTotal3 + 0;
//				}
//				else
//				{
//					dtyTotal3 = dtyTotal3 + Convert.ToDouble(Dty12Num3.Text);
//// 管理番号 B15940 From
//					dtyTotal3Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal3Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType3.Text == "2")
//					{
//						DtyTotal3.Text = dtyTotal3.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType3.Text == "3")
//					{
//						DtyTotal3.Text = dtyTotal3.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType3.Text == "4")
//					{
//						DtyTotal3.Text = dtyTotal3.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal3.Text = dtyTotal3.ToString("#,##0.00");
//						DtyTotal3.Text = dtyTotal3.ToString("#,##0");
//// 管理番号 B14921 To
//				}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal3.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName4.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num4.Text == null)||(Dty1Num4.Text == ""))
//				{
//					dtyTotal4 = 0;
//				}
//				else
//				{
//					dtyTotal4 = Convert.ToDouble(Dty1Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num4.Text == null)||(Dty2Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty2Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num4.Text == null)||(Dty3Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty3Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num4.Text == null)||(Dty4Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty4Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num4.Text == null)||(Dty5Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty5Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num4.Text == null)||(Dty6Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty6Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num4.Text == null)||(Dty7Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty7Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num4.Text == null)||(Dty8Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty8Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num4.Text == null)||(Dty9Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty9Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num4.Text == null)||(Dty10Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty10Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num4.Text == null)||(Dty11Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty11Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num4.Text == null)||(Dty12Num4.Text == ""))
//				{
//					dtyTotal4 = dtyTotal4 + 0;
//				}
//				else
//				{
//					dtyTotal4 = dtyTotal4 + Convert.ToDouble(Dty12Num4.Text);
//// 管理番号 B15940 From
//					dtyTotal4Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal4Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType4.Text == "2")
//					{
//						DtyTotal4.Text = dtyTotal4.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType4.Text == "3")
//					{
//						DtyTotal4.Text = dtyTotal4.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType4.Text == "4")
//					{
//						DtyTotal4.Text = dtyTotal4.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal4.Text = dtyTotal4.ToString("#,##0.00");
//						DtyTotal4.Text = dtyTotal4.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal4.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName5.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num5.Text == null)||(Dty1Num5.Text == ""))
//				{
//					dtyTotal5 = 0;
//				}
//				else
//				{
//					dtyTotal5 = Convert.ToDouble(Dty1Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num5.Text == null)||(Dty2Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty2Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num5.Text == null)||(Dty3Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty3Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num5.Text == null)||(Dty4Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty4Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num5.Text == null)||(Dty5Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty5Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num5.Text == null)||(Dty6Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty6Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num5.Text == null)||(Dty7Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty7Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num5.Text == null)||(Dty8Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty8Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num5.Text == null)||(Dty9Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty9Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num5.Text == null)||(Dty10Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty10Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num5.Text == null)||(Dty11Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty11Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num5.Text == null)||(Dty12Num5.Text == ""))
//				{
//					dtyTotal5 = dtyTotal5 + 0;
//				}
//				else
//				{
//					dtyTotal5 = dtyTotal5 + Convert.ToDouble(Dty12Num5.Text);
//// 管理番号 B15940 From
//					dtyTotal5Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal5Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType5.Text == "2")
//					{
//						DtyTotal5.Text = dtyTotal5.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType5.Text == "3")
//					{
//						DtyTotal5.Text = dtyTotal5.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType5.Text == "4")
//					{
//						DtyTotal5.Text = dtyTotal5.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal5.Text = dtyTotal5.ToString("#,##0.00");
//						DtyTotal5.Text = dtyTotal5.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal5.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName6.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num6.Text == null)||(Dty1Num6.Text == ""))
//				{
//					dtyTotal6 = 0;
//				}
//				else
//				{
//					dtyTotal6 = Convert.ToDouble(Dty1Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num6.Text == null)||(Dty2Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty2Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num6.Text == null)||(Dty3Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty3Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num6.Text == null)||(Dty4Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty4Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num6.Text == null)||(Dty5Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty5Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num6.Text == null)||(Dty6Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty6Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num6.Text == null)||(Dty7Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty7Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num6.Text == null)||(Dty8Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty8Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num6.Text == null)||(Dty9Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty9Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num6.Text == null)||(Dty10Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty10Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num6.Text == null)||(Dty11Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty11Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num6.Text == null)||(Dty12Num6.Text == ""))
//				{
//					dtyTotal6 = dtyTotal6 + 0;
//				}
//				else
//				{
//					dtyTotal6 = dtyTotal6 + Convert.ToDouble(Dty12Num6.Text);
//// 管理番号 B15940 From
//					dtyTotal6Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal6Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType6.Text == "2")
//					{
//						DtyTotal6.Text = dtyTotal6.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType6.Text == "3")
//					{
//						DtyTotal6.Text = dtyTotal6.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType6.Text == "4")
//					{
//						DtyTotal6.Text = dtyTotal6.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal6.Text = dtyTotal6.ToString("#,##0.00");
//						DtyTotal6.Text = dtyTotal6.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal6.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName7.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num7.Text == null)||(Dty1Num7.Text == ""))
//				{
//					dtyTotal7 = 0;
//				}
//				else
//				{
//					dtyTotal7 = Convert.ToDouble(Dty1Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num7.Text == null)||(Dty2Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty2Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num7.Text == null)||(Dty3Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty3Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num7.Text == null)||(Dty4Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty4Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num7.Text == null)||(Dty5Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty5Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num7.Text == null)||(Dty6Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty6Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num7.Text == null)||(Dty7Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty7Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num7.Text == null)||(Dty8Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty8Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num7.Text == null)||(Dty9Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty9Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num7.Text == null)||(Dty10Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty10Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num7.Text == null)||(Dty11Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty11Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num7.Text == null)||(Dty12Num7.Text == ""))
//				{
//					dtyTotal7 = dtyTotal7 + 0;
//				}
//				else
//				{
//					dtyTotal7 = dtyTotal7 + Convert.ToDouble(Dty12Num7.Text);
//// 管理番号 B15940 From
//					dtyTotal7Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal7Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType7.Text == "2")
//					{
//						DtyTotal7.Text = dtyTotal7.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType7.Text == "3")
//					{
//						DtyTotal7.Text = dtyTotal7.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType7.Text == "4")
//					{
//						DtyTotal7.Text = dtyTotal7.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal7.Text = dtyTotal7.ToString("#,##0.00");
//						DtyTotal7.Text = dtyTotal7.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal7.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//
//			if(DtyName8.Text != string.Empty)
//			{
//// 管理番号 B14921 To
//				if((Dty1Num8.Text == null)||(Dty1Num8.Text == ""))
//				{
//					dtyTotal8 = 0;
//				}
//				else
//				{
//					dtyTotal8 = Convert.ToDouble(Dty1Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty2Num8.Text == null)||(Dty2Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty2Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty3Num8.Text == null)||(Dty3Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty3Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty4Num8.Text == null)||(Dty4Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty4Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty5Num8.Text == null)||(Dty5Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty5Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty6Num8.Text == null)||(Dty6Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty6Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty7Num8.Text == null)||(Dty7Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty7Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty8Num8.Text == null)||(Dty8Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty8Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//	            			
//				if((Dty9Num8.Text == null)||(Dty9Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty9Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty10Num8.Text == null)||(Dty10Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty10Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//				
//				if((Dty11Num8.Text == null)||(Dty11Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty11Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//				if((Dty12Num8.Text == null)||(Dty12Num8.Text == ""))
//				{
//					dtyTotal8 = dtyTotal8 + 0;
//				}
//				else
//				{
//					dtyTotal8 = dtyTotal8 + Convert.ToDouble(Dty12Num8.Text);
//// 管理番号 B15940 From
//					dtyTotal8Flg = true;
//// 管理番号 B15940 To
//				}
//
//// 管理番号 B15940 From
//				if(dtyTotal8Flg)
//				{
//// 管理番号 B15940 To
//					if(DtyDispType8.Text == "2")
//					{
//						DtyTotal8.Text = dtyTotal8.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType8.Text == "3")
//					{
//						DtyTotal8.Text = dtyTotal8.ToString("#,##0.00");
//					}
//
//					else if(DtyDispType8.Text == "4")
//					{
//						DtyTotal8.Text = dtyTotal8.ToString("#,##0.00");
//					}
//
//					else
//					{
//// 管理番号 B14921 From
//						//DtyTotal8.Text = dtyTotal8.ToString("#,##0.00");
//						DtyTotal8.Text = dtyTotal8.ToString("#,##0");
//// 管理番号 B14921 To
//					}
//// 管理番号 B15940 From
//				}
//				else
//				{
//					DtyTotal8.Text = "";
//				}
//// 管理番号 B15940 To
//// 管理番号 B14921 From
//			}
//// 管理番号 B14921 To
// 管理番号 B24534 To

			//給与支給合計の空白処理
// 管理番号 B15940 From
			//if((PaymntTotal1Amt1.Text == "0")||(PaymntTotal1Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((PaymntTotal1Amt1.Text == "0") || (PaymntTotal1Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt1.Text = "";
			}
			if ((PaymntItemId1.Text == null) || (PaymntItemId1.Text == ""))
			{
				PaymntTotal1Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal1Amt2.Text == "0")||(PaymntTotal1Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((PaymntTotal1Amt2.Text == "0") || (PaymntTotal1Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt2.Text = "";
			}
			if ((PaymntItemId2.Text == null) || (PaymntItemId2.Text == ""))
			{
				PaymntTotal1Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal1Amt3.Text == "0")||(PaymntTotal1Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((PaymntTotal1Amt3.Text == "0") || (PaymntTotal1Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt3.Text = "";
			}
			if ((PaymntItemId3.Text == null) || (PaymntItemId3.Text == ""))
			{
				PaymntTotal1Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal1Amt4.Text == "0")||(PaymntTotal1Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((PaymntTotal1Amt4.Text == "0") || (PaymntTotal1Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt4.Text = "";
			}
			if ((PaymntItemId4.Text == null) || (PaymntItemId4.Text == ""))
			{
				PaymntTotal1Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal1Amt5.Text == "0")||(PaymntTotal1Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text =="0"))
			if (((PaymntTotal1Amt5.Text == "0") || (PaymntTotal1Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt5.Text = "";
			}
			if ((PaymntItemId5.Text == null) || (PaymntItemId5.Text == ""))
			{
				PaymntTotal1Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal1Amt6.Text == "0")||(PaymntTotal1Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((PaymntTotal1Amt6.Text == "0") || (PaymntTotal1Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal1Amt6.Text = "";
			}
			if ((PaymntItemId6.Text == null) || (PaymntItemId6.Text == ""))
			{
				PaymntTotal1Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt7.Text == "0")||(PaymntTotal1Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((PaymntTotal1Amt7.Text == "0") || (PaymntTotal1Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt7.Text = "";
//			}
//			if((PaymntItemId7.Text == null)||(PaymntItemId7.Text == ""))
//			{
//				PaymntTotal1Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt8.Text == "0")||(PaymntTotal1Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((PaymntTotal1Amt8.Text == "0") || (PaymntTotal1Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt8.Text = "";
//			}
//			if((PaymntItemId8.Text == null)||(PaymntItemId8.Text == ""))
//			{
//				PaymntTotal1Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt9.Text == "0")||(PaymntTotal1Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((PaymntTotal1Amt9.Text == "0") || (PaymntTotal1Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt9.Text = "";
//			}
//			if((PaymntItemId9.Text == null)||(PaymntItemId9.Text == ""))
//			{
//				PaymntTotal1Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt10.Text == "0")||(PaymntTotal1Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((PaymntTotal1Amt10.Text == "0") || (PaymntTotal1Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt10.Text = "";
//			}
//			if((PaymntItemId10.Text == null)||(PaymntItemId10.Text == ""))
//			{
//				PaymntTotal1Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt11.Text == "0")||(PaymntTotal1Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((PaymntTotal1Amt11.Text == "0")||(PaymntTotal1Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt11.Text = "";
//			}
//			if((PaymntItemId11.Text == null)||(PaymntItemId11.Text == ""))
//			{
//				PaymntTotal1Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal1Amt12.Text == "0")||(PaymntTotal1Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((PaymntTotal1Amt12.Text == "0")||(PaymntTotal1Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal1Amt12.Text = "";
//			}
//			if((PaymntItemId12.Text == null)||(PaymntItemId12.Text == ""))
//			{
//				PaymntTotal1Amt12.Text = "";
//			}
// 管理番号 K24565 To

			//給与控除合計の空白処理
// 管理番号 B15940 From
			//if((DedTotal1Amt1.Text == "0")||(DedTotal1Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((DedTotal1Amt1.Text == "0") || (DedTotal1Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt1.Text = "";
			}
			if ((DedItemId1.Text == null) || (DedItemId1.Text == ""))
			{
				DedTotal1Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal1Amt2.Text == "0")||(DedTotal1Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((DedTotal1Amt2.Text == "0") || (DedTotal1Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt2.Text = "";
			}
			if ((DedItemId2.Text == null) || (DedItemId2.Text == ""))
			{
				DedTotal1Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal1Amt3.Text == "0")||(DedTotal1Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((DedTotal1Amt3.Text == "0") || (DedTotal1Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt3.Text = "";
			}
			if ((DedItemId3.Text == null) || (DedItemId3.Text == ""))
			{
				DedTotal1Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal1Amt4.Text == "0")||(DedTotal1Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((DedTotal1Amt4.Text == "0") || (DedTotal1Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt4.Text = "";
			}
			if ((DedItemId4.Text == null) || (DedItemId4.Text == ""))
			{
				DedTotal1Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal1Amt5.Text == "0")||(DedTotal1Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((DedTotal1Amt5.Text == "0") || (DedTotal1Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt5.Text = "";
			}
			if ((DedItemId5.Text == null) || (DedItemId5.Text == ""))
			{
				DedTotal1Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal1Amt6.Text == "0")||(DedTotal1Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((DedTotal1Amt6.Text == "0") || (DedTotal1Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal1Amt6.Text = "";
			}
			if ((DedItemId6.Text == null) || (DedItemId6.Text == ""))
			{
				DedTotal1Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((DedTotal1Amt7.Text == "0")||(DedTotal1Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((DedTotal1Amt7.Text == "0") || (DedTotal1Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt7.Text = "";
//			}
//			if((DedItemId7.Text == null)||(DedItemId7.Text == ""))
//			{
//				DedTotal1Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal1Amt8.Text == "0")||(DedTotal1Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((DedTotal1Amt8.Text == "0") || (DedTotal1Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt8.Text = "";
//			}
//			if((DedItemId8.Text == null)||(DedItemId8.Text == ""))
//			{
//				DedTotal1Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal1Amt9.Text == "0")||(DedTotal1Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			if(((DedTotal1Amt9.Text == "0") || (DedTotal1Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt9.Text = "";
//			}
//			if((DedItemId9.Text == null)||(DedItemId9.Text == ""))
//			{
//				DedTotal1Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal1Amt10.Text == "0")||(DedTotal1Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((DedTotal1Amt10.Text == "0") || (DedTotal1Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt10.Text = "";
//			}
//			if((DedItemId10.Text == null)||(DedItemId10.Text == ""))
//			{
//				DedTotal1Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal1Amt11.Text == "0")||(DedTotal1Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((DedTotal1Amt11.Text == "0") || (DedTotal1Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt11.Text = "";
//			}
//			if((DedItemId11.Text == null)||(DedItemId11.Text == ""))
//			{
//				DedTotal1Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal1Amt12.Text == "0")||(DedTotal1Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((DedTotal1Amt12.Text == "0") || (DedTotal1Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal1Amt12.Text = "";
//			}
//			if((DedItemId12.Text == null)||(DedItemId12.Text == ""))
//			{
//				DedTotal1Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R98へ移動
//			//勤怠合計の空白処理
//// 管理番号 B15940 From
//			//if((DtyTotal1.Text == "0")||(DtyTotal1.Text == "0.00")&&(DtyZeroFlg1.Text == "0"))
//			if(((DtyTotal1.Text == "0") || (DtyTotal1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal1.Text = "";
//			}
//			if((DtyItemId1.Text == null)||(DtyItemId1.Text == ""))
//			{
//				DtyTotal1.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal2.Text == "0")||(DtyTotal2.Text == "0.00")&&(DtyZeroFlg2.Text == "0"))
//			if(((DtyTotal2.Text == "0") || (DtyTotal2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal2.Text = "";
//			}
//			if((DtyItemId2.Text == null)||(DtyItemId2.Text == ""))
//			{
//				DtyTotal2.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal3.Text == "0")||(DtyTotal3.Text == "0.00")&&(DtyZeroFlg3.Text == "0"))
//			if(((DtyTotal3.Text == "0") || (DtyTotal3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal3.Text = "";
//			}
//			if((DtyItemId3.Text == null)||(DtyItemId3.Text == ""))
//			{
//				DtyTotal3.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal4.Text == "0")||(DtyTotal4.Text == "0.00")&&(DtyZeroFlg4.Text == "0"))
//			if(((DtyTotal4.Text == "0") || (DtyTotal4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal4.Text = "";
//			}
//			if((DtyItemId4.Text == null)||(DtyItemId4.Text == ""))
//			{
//				DtyTotal4.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal5.Text == "0")||(DtyTotal5.Text == "0.00")&&(DtyZeroFlg5.Text == "0"))
//			if(((DtyTotal5.Text == "0") || (DtyTotal5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal5.Text = "";
//			}
//			if((DtyItemId5.Text == null)||(DtyItemId5.Text == ""))
//			{
//				DtyTotal5.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal6.Text == "0")||(DtyTotal6.Text == "0.00")&&(DtyZeroFlg6.Text == "0"))
//			if(((DtyTotal6.Text == "0") || (DtyTotal6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal6.Text = "";
//			}
//			if((DtyItemId6.Text == null)||(DtyItemId6.Text == ""))
//			{
//				DtyTotal6.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal7.Text == "0")||(DtyTotal7.Text == "0.00")||(DtyTotal7.Text == "0.00")&&(DtyZeroFlg7.Text == "0"))
//			if(((DtyTotal7.Text == "0") || (DtyTotal7.Text == "0.00")||(DtyTotal7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal7.Text = "";
//			}
//			if((DtyItemId7.Text == null)||(DtyItemId7.Text == ""))
//			{
//				DtyTotal7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DtyTotal8.Text == "0")||(DtyTotal8.Text == "0.00")&&(DtyZeroFlg8.Text == "0"))
//			if(((DtyTotal8.Text == "0") || (DtyTotal8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DtyTotal8.Text = "";
//			}
//			if((DtyItemId8.Text == null)||(DtyItemId8.Text == ""))
//			{
//				DtyTotal8.Text = "";
//			}
// 管理番号 K24565 To

			//賞与取得合計の空白処理
// 管理番号 B15940 From
			//if((PaymntTotal2Amt1.Text =="0")||(PaymntTotal2Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
			if (((PaymntTotal2Amt1.Text == "0") || (PaymntTotal2Amt1.Text == "0.00")) && (PaymntBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt1.Text = "";
			}
			if ((PaymntItemId1.Text == null) || (PaymntItemId1.Text == ""))
			{
				PaymntTotal2Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal2Amt2.Text == "0")||(PaymntTotal2Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
			if (((PaymntTotal2Amt2.Text == "0") || (PaymntTotal2Amt2.Text == "0.00")) && (PaymntBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt2.Text = "";
			}
			if ((PaymntItemId2.Text == null) || (PaymntItemId2.Text == ""))
			{
				PaymntTotal2Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal2Amt3.Text == "0")||(PaymntTotal2Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
			if (((PaymntTotal2Amt3.Text == "0") || (PaymntTotal2Amt3.Text == "0.00")) && (PaymntBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt3.Text = "";
			}
			if ((PaymntItemId3.Text == null) || (PaymntItemId3.Text == ""))
			{
				PaymntTotal2Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal2Amt4.Text == "0")||(PaymntTotal2Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
			if (((PaymntTotal2Amt4.Text == "0") || (PaymntTotal2Amt4.Text == "0.00")) && (PaymntBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt4.Text = "";
			}
			if ((PaymntItemId4.Text == null) || (PaymntItemId4.Text == ""))
			{
				PaymntTotal2Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal2Amt5.Text == "0")||(PaymntTotal2Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
			if (((PaymntTotal2Amt5.Text == "0") || (PaymntTotal2Amt5.Text == "0.00")) && (PaymntBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt5.Text = "";
			}
			if ((PaymntItemId5.Text == null) || (PaymntItemId5.Text == ""))
			{
				PaymntTotal2Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((PaymntTotal2Amt6.Text == "0")||(PaymntTotal2Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
			if (((PaymntTotal2Amt6.Text == "0") || (PaymntTotal2Amt6.Text == "0.00")) && (PaymntBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				PaymntTotal2Amt6.Text = "";
			}
			if ((PaymntItemId6.Text == null) || (PaymntItemId6.Text == ""))
			{
				PaymntTotal2Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt7.Text == "0")||(PaymntTotal2Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			if(((PaymntTotal2Amt7.Text == "0") || (PaymntTotal2Amt7.Text == "0.00")) && (PaymntBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt7.Text = "";
//			}
//			if((PaymntItemId7.Text == null)||(PaymntItemId7.Text == ""))
//			{
//				PaymntTotal2Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt8.Text == "0")||(PaymntTotal2Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			if(((PaymntTotal2Amt8.Text == "0") || (PaymntTotal2Amt8.Text == "0.00")) && (PaymntBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt8.Text = "";
//			}
//			if((PaymntItemId8.Text == null)||(PaymntItemId8.Text == ""))
//			{
//				PaymntTotal2Amt8.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt9.Text == "0")||(PaymntTotal2Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			if(((PaymntTotal2Amt9.Text == "0") || (PaymntTotal2Amt9.Text == "0.00")) && (PaymntBnsZeroFlg9.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt9.Text = "";
//			}
//			if((PaymntItemId9.Text == null)||(PaymntItemId9.Text == ""))
//			{
//				PaymntTotal2Amt9.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt10.Text == "0")||(PaymntTotal2Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			if(((PaymntTotal2Amt10.Text == "0") || (PaymntTotal2Amt10.Text == "0.00")) && (PaymntBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt10.Text = "";
//			}
//			if((PaymntItemId10.Text == null)||(PaymntItemId10.Text == ""))
//			{
//				PaymntTotal2Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt11.Text == "0")||(PaymntTotal2Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((PaymntTotal2Amt11.Text == "0") || (PaymntTotal2Amt11.Text == "0.00")) && (PaymntBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt11.Text = "";
//			}
//			if((PaymntItemId11.Text == null)||(PaymntItemId11.Text == ""))
//			{
//				PaymntTotal2Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((PaymntTotal2Amt12.Text == "0")||(PaymntTotal2Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((PaymntTotal2Amt12.Text == "0") || (PaymntTotal2Amt12.Text == "0.00")) && (PaymntBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				PaymntTotal2Amt12.Text = "";
//			}
//			if((PaymntItemId12.Text == null)||(PaymntItemId12.Text == ""))
//			{
//				PaymntTotal2Amt12.Text = "";
//			}
// 管理番号 K24565 To

			//賞与控除合計の空白処理
// 管理番号 B15940 From
			//if((DedTotal2Amt1.Text == "0")||(DedTotal2Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
			if (((DedTotal2Amt1.Text == "0") || (DedTotal2Amt1.Text == "0.00")) && (DedBnsZeroFlg1.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt1.Text = "";
			}
			if ((DedItemId1.Text == null) || (DedItemId1.Text == ""))
			{
				DedTotal2Amt1.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal2Amt2.Text == "0")||(DedTotal2Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
			if (((DedTotal2Amt2.Text == "0") || (DedTotal2Amt2.Text == "0.00")) && (DedBnsZeroFlg2.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt2.Text = "";
			}
			if ((DedItemId2.Text == null) || (DedItemId2.Text == ""))
			{
				DedTotal2Amt2.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal2Amt3.Text == "0")||(DedTotal2Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
			if (((DedTotal2Amt3.Text == "0") || (DedTotal2Amt3.Text == "0.00")) && (DedBnsZeroFlg3.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt3.Text = "";
			}
			if ((DedItemId3.Text == null) || (DedItemId3.Text == ""))
			{
				DedTotal2Amt3.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal2Amt4.Text == "0")||(DedTotal2Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
			if (((DedTotal2Amt4.Text == "0") || (DedTotal2Amt4.Text == "0.00")) && (DedBnsZeroFlg4.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt4.Text = "";
			}
			if ((DedItemId4.Text == null) || (DedItemId4.Text == ""))
			{
				DedTotal2Amt4.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal2Amt5.Text == "0")||(DedTotal2Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((DedTotal2Amt5.Text == "0") || (DedTotal2Amt5.Text == "0.00")) && (DedBnsZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt5.Text = "";
			}
			if ((DedItemId5.Text == null) || (DedItemId5.Text == ""))
			{
				DedTotal2Amt5.Text = "";
			}

// 管理番号 B15940 From
			//if((DedTotal2Amt6.Text == "0")||(DedTotal2Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
			if (((DedTotal2Amt6.Text == "0") || (DedTotal2Amt6.Text == "0.00")) && (DedBnsZeroFlg6.Text == "0"))
// 管理番号 B15940 To
			{
				DedTotal2Amt6.Text = "";
			}
			if ((DedItemId6.Text == null) || (DedItemId6.Text == ""))
			{
				DedTotal2Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((DedTotal2Amt7.Text == "0")||(DedTotal2Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((DedTotal2Amt7.Text == "0") || (DedTotal2Amt7.Text == "0.00")) && (DedBnsZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal2Amt7.Text = "";
//			}
//			if((DedItemId7.Text == null)||(DedItemId7.Text == ""))
//			{
//				DedTotal2Amt7.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal2Amt8.Text == "0")||(DedTotal2Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			if(((DedTotal2Amt8.Text == "0") || (DedTotal2Amt8.Text == "0.00")) && (DedBnsZeroFlg8.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal2Amt8.Text = "";
//			}
//			if((DedItemId8.Text == null)||(DedItemId8.Text == ""))
//			{
//				DedTotal2Amt8.Text = "";
//			}
//// 管理番号 B15940 From
//			//if((DedTotal2Amt10.Text == "0")||(DedTotal2Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			if(((DedTotal2Amt10.Text == "0") || (DedTotal2Amt10.Text == "0.00")) && (DedBnsZeroFlg10.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal2Amt10.Text = "";
//			}
//			if((DedItemId10.Text == null)||(DedItemId10.Text == ""))
//			{
//				DedTotal2Amt10.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal2Amt11.Text == "0")||(DedTotal2Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((DedTotal2Amt11.Text == "0") || (DedTotal2Amt11.Text == "0.00")) && (DedBnsZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal2Amt11.Text = "";
//			}
//			if((DedItemId11.Text == null)||(DedItemId11.Text == ""))
//			{
//				DedTotal2Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((DedTotal2Amt12.Text == "0")||(DedTotal2Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			if(((DedTotal2Amt12.Text == "0") || (DedTotal2Amt12.Text == "0.00")) && (DedBnsZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				DedTotal2Amt12.Text = "";
//			}
//			if((DedItemId12.Text == null)||(DedItemId12.Text == ""))
//			{
//				DedTotal2Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
//			//総合計支給合計の空白処理
//			if((PaymntTotal3Amt1.Text == "0")||(PaymntTotal3Amt1.Text == "0.00")&&(PaymntZeroFlg1.Text == "0"))
//			{
//				PaymntTotal3Amt1.Text = "";
//			}
//			if((PaymntItemId1.Text == null)||(PaymntItemId1.Text == ""))
//			{
//				PaymntTotal3Amt1.Text = "";
//			}
//
//			if((PaymntTotal3Amt2.Text == "0")||(PaymntTotal3Amt2.Text == "0.00")&&(PaymntZeroFlg2.Text == "0"))
//			{
//				PaymntTotal3Amt2.Text = "";
//			}
//			if((PaymntItemId2.Text == null)||(PaymntItemId2.Text == ""))
//			{
//				PaymntTotal3Amt2.Text = "";
//			}
//
//			if((PaymntTotal3Amt3.Text == "0")||(PaymntTotal3Amt3.Text == "0.00")&&(PaymntZeroFlg3.Text == "0"))
//			{
//				PaymntTotal3Amt3.Text = "";
//			}
//			if((PaymntItemId3.Text == null)||(PaymntItemId3.Text == ""))
//			{
//				PaymntTotal3Amt3.Text = "";
//			}
//
//			if((PaymntTotal3Amt4.Text == "0")||(PaymntTotal3Amt4.Text == "0.00")&&(PaymntZeroFlg4.Text == "0"))
//			{
//				PaymntTotal3Amt4.Text = "";
//			}
//			if((PaymntItemId4.Text == null)||(PaymntItemId4.Text == ""))
//			{
//				PaymntTotal3Amt4.Text = "";
//			}
//
//			if((PaymntTotal3Amt5.Text == "0")||(PaymntTotal3Amt5.Text == "0.00")&&(PaymntZeroFlg5.Text == "0"))
//			{
//				PaymntTotal3Amt5.Text = "";
//			}
//			if((PaymntItemId5.Text == null)||(PaymntItemId5.Text == ""))
//			{
//				PaymntTotal3Amt5.Text = "";
//			}
//
//			if((PaymntTotal3Amt6.Text == "0")||(PaymntTotal3Amt6.Text == "0.00")&&(PaymntZeroFlg6.Text == "0"))
//			{
//				PaymntTotal3Amt6.Text = "";
//			}
//			if((PaymntItemId6.Text == null)||(PaymntItemId6.Text == ""))
//			{
//				PaymntTotal3Amt6.Text = "";
//			}
//
//			if((PaymntTotal3Amt7.Text == "0")||(PaymntTotal3Amt7.Text == "0.00")&&(PaymntZeroFlg7.Text == "0"))
//			{
//				PaymntTotal3Amt7.Text = "";
//			}
//			if((PaymntItemId7.Text == null)||(PaymntItemId7.Text == ""))
//			{
//				PaymntTotal3Amt7.Text = "";
//			}
//
//			if((PaymntTotal3Amt8.Text == "0")||(PaymntTotal3Amt8.Text == "0.00")&&(PaymntZeroFlg8.Text == "0"))
//			{
//				PaymntTotal3Amt8.Text = "";
//			}
//			if((PaymntItemId8.Text == null)||(PaymntItemId8.Text == ""))
//			{
//				PaymntTotal3Amt8.Text = "";
//			}
//
//			if((PaymntTotal3Amt9.Text == "0")||(PaymntTotal3Amt9.Text == "0.00")&&(PaymntZeroFlg9.Text == "0"))
//			{
//				PaymntTotal3Amt9.Text = "";
//			}
//			if((PaymntItemId9.Text == null)||(PaymntItemId9.Text == ""))
//			{
//				PaymntTotal3Amt9.Text = "";
//			}
//
//			if((PaymntTotal3Amt10.Text == "0")||(PaymntTotal3Amt10.Text == "0.00")&&(PaymntZeroFlg10.Text == "0"))
//			{
//				PaymntTotal3Amt10.Text = "";
//			}
//			if((PaymntItemId10.Text == null)||(PaymntItemId10.Text == ""))
//			{
//				PaymntTotal3Amt10.Text = "";
//			}
//
//			if((PaymntTotal3Amt11.Text == "0")||(PaymntTotal3Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			{
//				PaymntTotal3Amt11.Text = "";
//			}
//			if((PaymntItemId11.Text == null)||(PaymntItemId11.Text == ""))
//			{
//				PaymntTotal3Amt11.Text = "";
//			}
//
//			if((PaymntTotal3Amt12.Text == "0")||(PaymntTotal3Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			{
//				PaymntTotal3Amt12.Text = "";
//			}
//			if((PaymntItemId12.Text == null)||(PaymntItemId12.Text == ""))
//			{
//				PaymntTotal3Amt12.Text = "";
//			}
//
//			//総合計控除合計の空白処理
//			if((DedTotal3Amt1.Text == "0")||(DedTotal3Amt1.Text == "0.00")&&(DedZeroFlg1.Text == "0"))
//			{
//				DedTotal3Amt1.Text = "";
//			}
//			if((DedItemId1.Text == null)||(DedItemId1.Text == ""))
//			{
//				DedTotal3Amt1.Text = "";
//			}
//
//			if((DedTotal3Amt2.Text == "0")||(DedTotal3Amt2.Text == "0.00")&&(DedZeroFlg2.Text == "0"))
//			{
//				DedTotal3Amt2.Text = "";
//			}
//			if((DedItemId2.Text == null)||(DedItemId2.Text == ""))
//			{
//				DedTotal3Amt2.Text = "";
//			}
//
//			if((DedTotal3Amt3.Text == "0")||(DedTotal3Amt3.Text == "0.00")&&(DedZeroFlg3.Text == "0"))
//			{
//				DedTotal3Amt3.Text = "";
//			}
//			if((DedItemId3.Text == null)||(DedItemId3.Text == ""))
//			{
//				DedTotal3Amt3.Text = "";
//			}
//
//			if((DedTotal3Amt4.Text == "0")||(DedTotal3Amt4.Text == "0.00")&&(DedZeroFlg4.Text == "0"))
//			{
//				DedTotal3Amt4.Text = "";
//			}
//			if((DedItemId4.Text == null)||(DedItemId4.Text == ""))
//			{
//				DedTotal3Amt4.Text = "";
//			}
//
//			if((DedTotal3Amt5.Text == "0")||(DedTotal3Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
//			{
//				DedTotal3Amt5.Text = "";
//			}
//			if((DedItemId5.Text == null)||(DedItemId5.Text == ""))
//			{
//				DedTotal3Amt5.Text = "";
//			}
//
//			if((DedTotal3Amt6.Text == "0")||(DedTotal3Amt6.Text == "0.00")&&(DedZeroFlg6.Text == "0"))
//			{
//				DedTotal3Amt6.Text = "";
//			}
//			if((DedItemId6.Text == null)||(DedItemId6.Text == ""))
//			{
//				DedTotal3Amt6.Text = "";
//			}
//
//			if((DedTotal3Amt7.Text == "0")||(DedTotal3Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			{
//				DedTotal3Amt7.Text = "";
//			}
//			if((DedItemId7.Text == null)||(DedItemId7.Text == ""))
//			{
//				DedTotal3Amt7.Text = "";
//			}
//
//			if((DedTotal3Amt8.Text == "0")||(DedTotal3Amt8.Text == "0.00")&&(DedZeroFlg8.Text == "0"))
//			{
//				DedTotal3Amt8.Text = "";
//			}
//			if((DedItemId8.Text == null)||(DedItemId8.Text == ""))
//			{
//				DedTotal3Amt8.Text = "";
//			}
//
//			if((DedTotal3Amt9.Text == "0")||(DedTotal3Amt9.Text == "0.00")&&(DedZeroFlg9.Text == "0"))
//			{
//				DedTotal3Amt9.Text = "";
//			}
//			if((DedItemId9.Text == null)||(DedItemId9.Text == ""))
//			{
//				DedTotal3Amt9.Text = "";
//			}
//
//			if((DedTotal3Amt10.Text == "0")||(DedTotal3Amt10.Text == "0.00")&&(DedZeroFlg10.Text == "0"))
//			{
//				DedTotal3Amt10.Text = "";
//			}
//			if((DedItemId10.Text == null)||(DedItemId10.Text == ""))
//			{
//				DedTotal3Amt10.Text = "";
//			}
//
//			if((DedTotal3Amt11.Text == "0")||(DedTotal3Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			{
//				DedTotal3Amt11.Text = "";
//			}
//			if((DedItemId11.Text == null)||(DedItemId11.Text == ""))
//			{
//				DedTotal3Amt11.Text = "";
//			}
//
//			if((DedTotal3Amt12.Text == "0")||(DedTotal3Amt12.Text == "0.00")&&(DedZeroFlg12.Text == "0"))
//			{
//				DedTotal3Amt12.Text = "";
//			}
//			if((DedItemId12.Text == null)||(DedItemId12.Text == ""))
//			{
//				DedTotal3Amt12.Text = "";
//			}
// 管理番号 B15940 To
			//前職等修正分の空白処理
// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Paymnt17Amt11.Text == "0")||(Paymnt17Amt11.Text == "0.00")&&(PaymntZeroFlg11.Text == "0"))
//			if(((Paymnt17Amt11.Text == "0") || (Paymnt17Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt17Amt11.Text = "";
//			}
//
//// 管理番号 B15940 From
//			//if((Paymnt17Amt12.Text == "0")||(Paymnt17Amt12.Text == "0.00")&&(PaymntZeroFlg12.Text == "0"))
//			if(((Paymnt17Amt12.Text == "0")||(Paymnt17Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Paymnt17Amt12.Text = "";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			//if((Ded17Amt5.Text == "0")||(Ded17Amt5.Text == "0.00")&&(DedZeroFlg5.Text == "0"))
			if (((Ded17Amt5.Text == "0") || (Ded17Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
// 管理番号 B15940 To
			{
				Ded17Amt5.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			//if((Ded17Amt7.Text == "0")||(Ded17Amt7.Text == "0.00")&&(DedZeroFlg7.Text == "0"))
//			if(((Ded17Amt7.Text == "0") || (Ded17Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded17Amt7.Text = "";
//			}
//			
//// 管理番号 B15940 From
//			//if((Ded17Amt11.Text == "0")||(Ded17Amt11.Text == "0.00")&&(DedZeroFlg11.Text == "0"))
//			if(((Ded17Amt11.Text == "0") || (Ded17Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//// 管理番号 B15940 To
//			{
//				Ded17Amt11.Text = "";
//			}
// 管理番号 K24565 To

			//前職等修正分の処理
			if ((Paymnt17Amt1.Text == null) || (Paymnt17Amt1.Text == ""))
			{
				paymntTotal3Amt1 = 0;
			}
			else
			{
				paymntTotal3Amt1 = Convert.ToDouble(Paymnt17Amt1.Text);
// 管理番号 B15940 From
				paymntTotal3Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt17Amt2.Text == null) || (Paymnt17Amt2.Text == ""))
			{
				paymntTotal3Amt2 = 0;
			}
			else
			{
				paymntTotal3Amt2 = Convert.ToDouble(Paymnt17Amt2.Text);
// 管理番号 B15940 From
				paymntTotal3Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt17Amt3.Text == null) || (Paymnt17Amt3.Text == ""))
			{
				paymntTotal3Amt3 = 0;
			}
			else
			{
				paymntTotal3Amt3 = Convert.ToDouble(Paymnt17Amt3.Text);
// 管理番号 B15940 From
				paymntTotal3Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt17Amt4.Text == null) || (Paymnt17Amt4.Text == ""))
			{
				paymntTotal3Amt4 = 0;
			}
			else
			{
				paymntTotal3Amt4 = Convert.ToDouble(Paymnt17Amt4.Text);
// 管理番号 B15940 From
				paymntTotal3Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt17Amt5.Text == null) || (Paymnt17Amt5.Text == ""))
			{
				paymntTotal3Amt5 = 0;
			}
			else
			{
				paymntTotal3Amt5 = Convert.ToDouble(Paymnt17Amt5.Text);
// 管理番号 B15940 From
				paymntTotal3Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Paymnt17Amt6.Text == null) || (Paymnt17Amt6.Text == ""))
			{
				paymntTotal3Amt6 = 0;
			}
			else
			{
				paymntTotal3Amt6 = Convert.ToDouble(Paymnt17Amt6.Text);
// 管理番号 B15940 From
				paymntTotal3Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if ((Paymnt17Amt7.Text == null) || (Paymnt17Amt7.Text == ""))
//			{
//				paymntTotal3Amt7 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt7 = Convert.ToDouble(Paymnt17Amt7.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt17Amt8.Text == null)||(Paymnt17Amt8.Text == ""))
//			{
//				paymntTotal3Amt8 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt8 = Convert.ToDouble(Paymnt17Amt8.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt17Amt9.Text == null)||(Paymnt17Amt9.Text == ""))
//			{
//				paymntTotal3Amt9 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt9 = Convert.ToDouble(Paymnt17Amt9.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt17Amt10.Text == null)||(Paymnt17Amt10.Text == ""))
//			{
//				paymntTotal3Amt10 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt10 = Convert.ToDouble(Paymnt17Amt10.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt17Amt11.Text == null)||(Paymnt17Amt11.Text == ""))
//			{
//				paymntTotal3Amt11 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt11 = Convert.ToDouble(Paymnt17Amt11.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Paymnt17Amt12.Text == null)||(Paymnt17Amt12.Text == ""))
//			{
//				paymntTotal3Amt12 = 0;
//			}
//			else
//			{
//				paymntTotal3Amt12 = Convert.ToDouble(Paymnt17Amt12.Text);
//// 管理番号 B15940 From
//				paymntTotal3Amt12Flg = true;
//// 管理番号 B15940 To
//			}
// 管理番号 K24565 To

			if ((Ded17Amt1.Text == null) || (Ded17Amt1.Text == ""))
			{
				dedTotal3Amt1 = 0;
			}
			else
			{
				dedTotal3Amt1 = Convert.ToDouble(Ded17Amt1.Text);
// 管理番号 B15940 From
				dedTotal3Amt1Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded17Amt2.Text == null) || (Ded17Amt2.Text == ""))
			{
				dedTotal3Amt2 = 0;
			}
			else
			{
				dedTotal3Amt2 = Convert.ToDouble(Ded17Amt2.Text);
// 管理番号 B15940 From
				dedTotal3Amt2Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded17Amt3.Text == null) || (Ded17Amt3.Text == ""))
			{
				dedTotal3Amt3 = 0;
			}
			else
			{
				dedTotal3Amt3 = Convert.ToDouble(Ded17Amt3.Text);
// 管理番号 B15940 From
				dedTotal3Amt3Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded17Amt4.Text == null) || (Ded17Amt4.Text == ""))
			{
				dedTotal3Amt4 = 0;
			}
			else
			{
				dedTotal3Amt4 = Convert.ToDouble(Ded17Amt4.Text);
// 管理番号 B15940 From
				dedTotal3Amt4Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded17Amt5.Text == null) || (Ded17Amt5.Text == ""))
			{
				dedTotal3Amt5 = 0;
			}
			else
			{
				dedTotal3Amt5 = Convert.ToDouble(Ded17Amt5.Text);
// 管理番号 B15940 From
				dedTotal3Amt5Flg = true;
// 管理番号 B15940 To
			}

			if ((Ded17Amt6.Text == null) || (Ded17Amt6.Text == ""))
			{
				dedTotal3Amt6 = 0;
			}
			else
			{
				dedTotal3Amt6 = Convert.ToDouble(Ded17Amt6.Text);
// 管理番号 B15940 From
				dedTotal3Amt6Flg = true;
// 管理番号 B15940 To
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if ((Ded17Amt7.Text == null) || (Ded17Amt7.Text == ""))
//			{
//				dedTotal3Amt7 = 0;
//			}
//			else
//			{
//				dedTotal3Amt7 = Convert.ToDouble(Ded17Amt7.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt7Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded17Amt8.Text == null)||(Ded17Amt8.Text == ""))
//			{
//				dedTotal3Amt8 = 0;
//			}
//			else
//			{
//				dedTotal3Amt8 = Convert.ToDouble(Ded17Amt8.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt8Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded17Amt9.Text == null)||(Ded17Amt9.Text == ""))
//			{
//				dedTotal3Amt9 = 0;
//			}
//			else
//			{
//				dedTotal3Amt9 = Convert.ToDouble(Ded17Amt9.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt9Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded17Amt10.Text == null)||(Ded17Amt10.Text == ""))
//			{
//				dedTotal3Amt10 = 0;
//			}
//			else
//			{
//				dedTotal3Amt10 = Convert.ToDouble(Ded17Amt10.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt10Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded17Amt11.Text == null)||(Ded17Amt11.Text == ""))
//			{
//				dedTotal3Amt11 = 0;
//			}
//			else
//			{
//				dedTotal3Amt11 = Convert.ToDouble(Ded17Amt11.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt11Flg = true;
//// 管理番号 B15940 To
//			}
//
//			if((Ded17Amt12.Text == null)||(Ded17Amt12.Text == ""))
//			{
//				dedTotal3Amt12 = 0;
//			}
//			else
//			{
//				dedTotal3Amt12 = Convert.ToDouble(Ded17Amt12.Text);
//// 管理番号 B15940 From
//				dedTotal3Amt12Flg = true;
//// 管理番号 B15940 To
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			if ((paymntTotal1Amt1Flg) || (paymntTotal2Amt1Flg) || (paymntTotal3Amt1Flg))
			{
				// 管理番号 B15940 To
				//支給総合計処理
				if (PaymntDispType1.Text == "2")
				{
					paymntTotal4Amt1 = paymntTotal1Amt1 + paymntTotal2Amt1 + paymntTotal3Amt1;
					PaymntTotal3Amt1.Text = paymntTotal4Amt1.ToString("###0");
				}

				else if (PaymntDispType1.Text == "3")
				{
					paymntTotal4Amt1 = paymntTotal1Amt1 + paymntTotal2Amt1 + paymntTotal3Amt1;
					PaymntTotal3Amt1.Text = paymntTotal4Amt1.ToString("#,##0.00");
				}

				else if (PaymntDispType1.Text == "4")
				{
					paymntTotal4Amt1 = paymntTotal1Amt1 + paymntTotal2Amt1 + paymntTotal3Amt1;
					PaymntTotal3Amt1.Text = paymntTotal4Amt1.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt1 = paymntTotal1Amt1 + paymntTotal2Amt1 + paymntTotal3Amt1;
					PaymntTotal3Amt1.Text = paymntTotal4Amt1.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt1.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((paymntTotal1Amt2Flg) || (paymntTotal2Amt2Flg) || (paymntTotal3Amt2Flg))
			{
// 管理番号 B15940 To
				if (PaymntDispType2.Text == "2")
				{
					paymntTotal4Amt2 = paymntTotal1Amt2 + paymntTotal2Amt2 + paymntTotal3Amt2;
					PaymntTotal3Amt2.Text = paymntTotal4Amt2.ToString("###0");
				}

				else if (PaymntDispType2.Text == "3")
				{
					paymntTotal4Amt2 = paymntTotal1Amt2 + paymntTotal2Amt2 + paymntTotal3Amt2;
					PaymntTotal3Amt2.Text = paymntTotal4Amt2.ToString("#,##0.00");
				}

				else if (PaymntDispType2.Text == "4")
				{
					paymntTotal4Amt2 = paymntTotal1Amt2 + paymntTotal2Amt2 + paymntTotal3Amt2;
					PaymntTotal3Amt2.Text = paymntTotal4Amt2.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt2 = paymntTotal1Amt2 + paymntTotal2Amt2 + paymntTotal3Amt2;
					PaymntTotal3Amt2.Text = paymntTotal4Amt2.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt2.Text = "";
			}
// 管理番号 B15940 To
// 管理番号 B15940 From
			if ((paymntTotal1Amt3Flg) || (paymntTotal2Amt3Flg) || (paymntTotal3Amt3Flg))
			{
// 管理番号 B15940 To
				if (PaymntDispType3.Text == "2")
				{
					paymntTotal4Amt3 = paymntTotal1Amt3 + paymntTotal2Amt3 + paymntTotal3Amt3;
					PaymntTotal3Amt3.Text = paymntTotal4Amt3.ToString("###0");
				}

				else if (PaymntDispType3.Text == "3")
				{
					paymntTotal4Amt3 = paymntTotal1Amt3 + paymntTotal2Amt3 + paymntTotal3Amt3;
					PaymntTotal3Amt3.Text = paymntTotal4Amt3.ToString("#,##0.00");
				}

				else if (PaymntDispType3.Text == "4")
				{
					paymntTotal4Amt3 = paymntTotal1Amt3 + paymntTotal2Amt3 + paymntTotal3Amt3;
					PaymntTotal3Amt3.Text = paymntTotal4Amt3.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt3 = paymntTotal1Amt3 + paymntTotal2Amt3 + paymntTotal3Amt3;
					PaymntTotal3Amt3.Text = paymntTotal4Amt3.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt3.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((paymntTotal1Amt4Flg) || (paymntTotal2Amt4Flg) || (paymntTotal3Amt4Flg))
			{
// 管理番号 B15940 To
				if (PaymntDispType4.Text == "2")
				{
					paymntTotal4Amt4 = paymntTotal1Amt4 + paymntTotal2Amt4 + paymntTotal3Amt4;
					PaymntTotal3Amt4.Text = paymntTotal4Amt4.ToString("###0");
				}

				else if (PaymntDispType4.Text == "3")
				{
					paymntTotal4Amt4 = paymntTotal1Amt4 + paymntTotal2Amt4 + paymntTotal3Amt4;
					PaymntTotal3Amt4.Text = paymntTotal4Amt4.ToString("#,##0.00");
				}

				else if (PaymntDispType4.Text == "4")
				{
					paymntTotal4Amt4 = paymntTotal1Amt4 + paymntTotal2Amt4 + paymntTotal3Amt4;
					PaymntTotal3Amt4.Text = paymntTotal4Amt4.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt4 = paymntTotal1Amt4 + paymntTotal2Amt4 + paymntTotal3Amt4;
					PaymntTotal3Amt4.Text = paymntTotal4Amt4.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt4.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((paymntTotal1Amt5Flg) || (paymntTotal2Amt5Flg) || (paymntTotal3Amt5Flg))
			{
// 管理番号 B15940 To
				if (PaymntDispType5.Text == "2")
				{
					paymntTotal4Amt5 = paymntTotal1Amt5 + paymntTotal2Amt5 + paymntTotal3Amt5;
					PaymntTotal3Amt5.Text = paymntTotal4Amt5.ToString("###0");
				}

				else if (PaymntDispType5.Text == "3")
				{
					paymntTotal4Amt5 = paymntTotal1Amt5 + paymntTotal2Amt5 + paymntTotal3Amt5;
					PaymntTotal3Amt5.Text = paymntTotal4Amt5.ToString("#,##0.00");
				}

				else if (PaymntDispType5.Text == "4")
				{
					paymntTotal4Amt5 = paymntTotal1Amt5 + paymntTotal2Amt5 + paymntTotal3Amt5;
					PaymntTotal3Amt5.Text = paymntTotal4Amt5.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt5 = paymntTotal1Amt5 + paymntTotal2Amt5 + paymntTotal3Amt5;
					PaymntTotal3Amt5.Text = paymntTotal4Amt5.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt5.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((paymntTotal1Amt6Flg) || (paymntTotal2Amt6Flg) || (paymntTotal3Amt6Flg))
			{
// 管理番号 B15940 To
				if (PaymntDispType6.Text == "2")
				{
					paymntTotal4Amt6 = paymntTotal1Amt6 + paymntTotal2Amt6 + paymntTotal3Amt6;
					PaymntTotal3Amt6.Text = paymntTotal4Amt6.ToString("###0");
				}

				else if (PaymntDispType6.Text == "3")
				{
					paymntTotal4Amt6 = paymntTotal1Amt6 + paymntTotal2Amt6 + paymntTotal3Amt6;
					PaymntTotal3Amt6.Text = paymntTotal4Amt6.ToString("#,##0.00");
				}

				else if (PaymntDispType6.Text == "4")
				{
					paymntTotal4Amt6 = paymntTotal1Amt6 + paymntTotal2Amt6 + paymntTotal3Amt6;
					PaymntTotal3Amt6.Text = paymntTotal4Amt6.ToString("###0.00");

				}

				else
				{
					paymntTotal4Amt6 = paymntTotal1Amt6 + paymntTotal2Amt6 + paymntTotal3Amt6;
					PaymntTotal3Amt6.Text = paymntTotal4Amt6.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				PaymntTotal3Amt6.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			if((paymntTotal1Amt7Flg) || (paymntTotal2Amt7Flg) || (paymntTotal3Amt7Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType7.Text == "2")
//				{
//					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
//					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("###0"); 
//				}
//
//				else if(PaymntDispType7.Text == "3")
//				{
//					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
//					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType7.Text == "4")
//				{
//					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
//					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt7 = paymntTotal1Amt7 + paymntTotal2Amt7 + paymntTotal3Amt7;
//					PaymntTotal3Amt7.Text = paymntTotal4Amt7.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((paymntTotal1Amt8Flg) || (paymntTotal2Amt8Flg) || (paymntTotal3Amt8Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType8.Text == "2")
//				{
//					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
//					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("###0"); 
//				}
//
//				else if(PaymntDispType8.Text == "3")
//				{
//					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
//					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType8.Text == "4")
//				{
//					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
//					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt8 = paymntTotal1Amt8 + paymntTotal2Amt8 + paymntTotal3Amt8;
//					PaymntTotal3Amt8.Text = paymntTotal4Amt8.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt8.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((paymntTotal1Amt9Flg) || (paymntTotal2Amt9Flg) || (paymntTotal3Amt9Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType9.Text == "2")
//				{
//					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
//					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("###0"); 
//				}
//
//				else if(PaymntDispType9.Text == "3")
//				{
//					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
//					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType9.Text == "4")
//				{
//					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
//					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt9 = paymntTotal1Amt9 + paymntTotal2Amt9 + paymntTotal3Amt9;
//					PaymntTotal3Amt9.Text = paymntTotal4Amt9.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((paymntTotal1Amt10Flg) || (paymntTotal2Amt10Flg) || (paymntTotal3Amt10Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType10.Text == "2")
//				{
//					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
//					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("###0"); 
//				}
//
//				else if(PaymntDispType10.Text == "3")
//				{
//					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
//					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType10.Text == "4")
//				{
//					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
//					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt10 = paymntTotal1Amt10 + paymntTotal2Amt10 + paymntTotal3Amt10;
//					PaymntTotal3Amt10.Text = paymntTotal4Amt10.ToString("#,##0"); 
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((paymntTotal1Amt11Flg) || (paymntTotal2Amt11Flg) || (paymntTotal3Amt11Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType11.Text == "2")
//				{
//					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
//					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("###0"); 
//				}
//
//				else if(PaymntDispType11.Text == "3")
//				{
//					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
//					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType11.Text == "4")
//				{
//					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
//					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt11 = paymntTotal1Amt11 + paymntTotal2Amt11 + paymntTotal3Amt11;
//					PaymntTotal3Amt11.Text = paymntTotal4Amt11.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((paymntTotal1Amt12Flg) || (paymntTotal2Amt12Flg) || (paymntTotal3Amt12Flg))
//			{
//// 管理番号 B15940 To
//				if(PaymntDispType12.Text == "2")
//				{
//					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
//					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("###0"); 
//				}
//
//				else if(PaymntDispType12.Text == "3")
//				{
//					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
//					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("#,##0.00");
//				}
//
//				else if(PaymntDispType12.Text == "4")
//				{
//					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
//					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					paymntTotal4Amt12 = paymntTotal1Amt12 + paymntTotal2Amt12 + paymntTotal3Amt12;
//					PaymntTotal3Amt12.Text = paymntTotal4Amt12.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				PaymntTotal3Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To

// 管理番号 B15940 From
			if ((dedTotal1Amt1Flg) || (dedTotal2Amt1Flg) || (dedTotal3Amt1Flg))
			{
// 管理番号 B15940 To
				//総合計控除の処理
				if (DedDispType1.Text == "2")
				{
					dedTotal4Amt1 = dedTotal1Amt1 + dedTotal2Amt1 + dedTotal3Amt1;
					DedTotal3Amt1.Text = dedTotal4Amt1.ToString("###0");
				}

				else if (DedDispType1.Text == "3")
				{
					dedTotal4Amt1 = dedTotal1Amt1 + dedTotal2Amt1 + dedTotal3Amt1;
					DedTotal3Amt1.Text = dedTotal4Amt1.ToString("#,##0.00");
				}

				else if (DedDispType1.Text == "4")
				{
					dedTotal4Amt1 = dedTotal1Amt1 + dedTotal2Amt1 + dedTotal3Amt1;
					DedTotal3Amt1.Text = dedTotal4Amt1.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt1 = dedTotal1Amt1 + dedTotal2Amt1 + dedTotal3Amt1;
					DedTotal3Amt1.Text = dedTotal4Amt1.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt1.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((dedTotal1Amt2Flg) || (dedTotal2Amt2Flg) || (dedTotal3Amt2Flg))
			{
// 管理番号 B15940 To
				if (DedDispType2.Text == "2")
				{
					dedTotal4Amt2 = dedTotal1Amt2 + dedTotal2Amt2 + dedTotal3Amt2;
					DedTotal3Amt2.Text = dedTotal4Amt2.ToString("###0");
				}

				else if (DedDispType2.Text == "3")
				{
					dedTotal4Amt2 = dedTotal1Amt2 + dedTotal2Amt2 + dedTotal3Amt2;
					DedTotal3Amt2.Text = dedTotal4Amt2.ToString("#,##0.00");
				}

				else if (DedDispType2.Text == "4")
				{
					dedTotal4Amt2 = dedTotal1Amt2 + dedTotal2Amt2 + dedTotal3Amt2;
					DedTotal3Amt2.Text = dedTotal4Amt2.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt2 = dedTotal1Amt2 + dedTotal2Amt2 + dedTotal3Amt2;
					DedTotal3Amt2.Text = dedTotal4Amt2.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt2.Text = "";
			}
// 管理番号 B15940 From		

// 管理番号 B15940 From
			if ((dedTotal1Amt3Flg) || (dedTotal2Amt3Flg) || (dedTotal3Amt3Flg))
			{
// 管理番号 B15940 To
				if (DedDispType3.Text == "2")
				{
					dedTotal4Amt3 = dedTotal1Amt3 + dedTotal2Amt3 + dedTotal3Amt3;
					DedTotal3Amt3.Text = dedTotal4Amt3.ToString("###0");
				}

				else if (DedDispType3.Text == "3")
				{
					dedTotal4Amt3 = dedTotal1Amt3 + dedTotal2Amt3 + dedTotal3Amt3;
					DedTotal3Amt3.Text = dedTotal4Amt3.ToString("#,##0.00");
				}

				else if (DedDispType3.Text == "4")
				{
					dedTotal4Amt3 = dedTotal1Amt3 + dedTotal2Amt3 + dedTotal3Amt3;
					DedTotal3Amt3.Text = dedTotal4Amt3.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt3 = dedTotal1Amt3 + dedTotal2Amt3 + dedTotal3Amt3;
					DedTotal3Amt3.Text = dedTotal4Amt3.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt3.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((dedTotal1Amt4Flg) || (dedTotal2Amt4Flg) || (dedTotal3Amt4Flg))
			{
// 管理番号 B15940 To
				if (DedDispType4.Text == "2")
				{
					dedTotal4Amt4 = dedTotal1Amt4 + dedTotal2Amt4 + dedTotal3Amt4;
					DedTotal3Amt4.Text = dedTotal4Amt4.ToString("###0");
				}

				else if (DedDispType4.Text == "3")
				{
					dedTotal4Amt4 = dedTotal1Amt4 + dedTotal2Amt4 + dedTotal3Amt4;
					DedTotal3Amt4.Text = dedTotal4Amt4.ToString("#,##0.00");
				}

				else if (DedDispType4.Text == "4")
				{
					dedTotal4Amt4 = dedTotal1Amt4 + dedTotal2Amt4 + dedTotal3Amt4;
					DedTotal3Amt4.Text = dedTotal4Amt4.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt4 = dedTotal1Amt4 + dedTotal2Amt4 + dedTotal3Amt4;
					DedTotal3Amt4.Text = dedTotal4Amt4.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt4.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((dedTotal1Amt5Flg) || (dedTotal2Amt5Flg) || (dedTotal3Amt5Flg))
			{
// 管理番号 B15940 To
				if (DedDispType5.Text == "2")
				{
					dedTotal4Amt5 = dedTotal1Amt5 + dedTotal2Amt5 + dedTotal3Amt5;
					DedTotal3Amt5.Text = dedTotal4Amt5.ToString("###0");
				}

				else if (DedDispType5.Text == "3")
				{
					dedTotal4Amt5 = dedTotal1Amt5 + dedTotal2Amt5 + dedTotal3Amt5;
					DedTotal3Amt5.Text = dedTotal4Amt5.ToString("#,##0.00");
				}

				else if (DedDispType5.Text == "4")
				{
					dedTotal4Amt5 = dedTotal1Amt5 + dedTotal2Amt5 + dedTotal3Amt5;
					DedTotal3Amt5.Text = dedTotal4Amt5.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt5 = dedTotal1Amt5 + dedTotal2Amt5 + dedTotal3Amt5;
					DedTotal3Amt5.Text = dedTotal4Amt5.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt5.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 B15940 From
			if ((dedTotal1Amt6Flg) || (dedTotal2Amt6Flg) || (dedTotal3Amt6Flg))
			{
// 管理番号 B15940 To
				if (DedDispType6.Text == "2")
				{
					dedTotal4Amt6 = dedTotal1Amt6 + dedTotal2Amt6 + dedTotal3Amt6;
					DedTotal3Amt6.Text = dedTotal4Amt6.ToString("###0");
				}

				else if (DedDispType6.Text == "3")
				{
					dedTotal4Amt6 = dedTotal1Amt6 + dedTotal2Amt6 + dedTotal3Amt6;
					DedTotal3Amt6.Text = dedTotal4Amt6.ToString("#,##0.00");
				}

				else if (DedDispType6.Text == "4")
				{
					dedTotal4Amt6 = dedTotal1Amt6 + dedTotal2Amt6 + dedTotal3Amt6;
					DedTotal3Amt6.Text = dedTotal4Amt6.ToString("###0.00");

				}

				else
				{
					dedTotal4Amt6 = dedTotal1Amt6 + dedTotal2Amt6 + dedTotal3Amt6;
					DedTotal3Amt6.Text = dedTotal4Amt6.ToString("#,##0");

				}
// 管理番号 B15940 From
			}
			else
			{
				DedTotal3Amt6.Text = "";
			}
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//// 管理番号 B15940 From
//			if((dedTotal1Amt7Flg) || (dedTotal2Amt7Flg) || (dedTotal3Amt7Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType7.Text == "2")
//				{
//					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
//					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("###0"); 
//				}
//
//				else if(DedDispType7.Text == "3")
//				{
//					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
//					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("#,##0.00");
//				}
//
//				else if(DedDispType7.Text == "4")
//				{
//					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
//					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt7 = dedTotal1Amt7 + dedTotal2Amt7 + dedTotal3Amt7;
//					DedTotal3Amt7.Text = dedTotal4Amt7.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt7.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((dedTotal1Amt8Flg) || (dedTotal2Amt8Flg) || (dedTotal3Amt8Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType8.Text == "2")
//				{
//					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
//					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("###0"); 
//				}
//
//				else if(DedDispType8.Text == "3")
//				{
//					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
//					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("#,##0.00");
//				}
//
//				else if(DedDispType8.Text == "4")
//				{
//					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
//					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt8 = dedTotal1Amt8 + dedTotal2Amt8 + dedTotal3Amt8;
//					DedTotal3Amt8.Text = dedTotal4Amt8.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt8.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((dedTotal1Amt9Flg) || (dedTotal2Amt9Flg) || (dedTotal3Amt9Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType9.Text == "2")
//				{
//					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
//					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("###0"); 
//				}
//
//				else if(DedDispType9.Text == "3")
//				{
//					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
//					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("#,##0.00");
//				}
//
//				else if(DedDispType9.Text == "4")
//				{
//					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
//					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt9 = dedTotal1Amt9 + dedTotal2Amt9 + dedTotal3Amt9;
//					DedTotal3Amt9.Text = dedTotal4Amt9.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt9.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((dedTotal1Amt10Flg) || (dedTotal2Amt10Flg) || (dedTotal3Amt10Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType10.Text == "2")
//				{
//					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
//					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("###0"); 
//				}
//
//				else if(DedDispType10.Text == "3")
//				{
//					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
//					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("#,##0.00");
//				}
//
//				else if(DedDispType10.Text == "4")
//				{
//					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
//					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt10 = dedTotal1Amt10 + dedTotal2Amt10 + dedTotal3Amt10;
//					DedTotal3Amt10.Text = dedTotal4Amt10.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt10.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((dedTotal1Amt11Flg) || (dedTotal2Amt11Flg) || (dedTotal3Amt11Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType11.Text == "2")
//				{
//					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
//					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("###0"); 
//				}
//
//				else if(DedDispType11.Text == "3")
//				{
//					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
//					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("#,##0.00");
//				}
//
//				else if(DedDispType11.Text == "4")
//				{
//					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
//					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt11 = dedTotal1Amt11 + dedTotal2Amt11 + dedTotal3Amt11;
//					DedTotal3Amt11.Text = dedTotal4Amt11.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt11.Text = "";
//			}
//// 管理番号 B15940 To
//
//// 管理番号 B15940 From
//			if((dedTotal1Amt12Flg) || (dedTotal2Amt12Flg) || (dedTotal3Amt12Flg))
//			{
//// 管理番号 B15940 To
//				if(DedDispType12.Text == "2")
//				{
//					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
//					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("###0"); 
//				}
//
//				else if(DedDispType12.Text == "3")
//				{
//					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
//					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("#,##0.00");
//				}
//
//				else if(DedDispType12.Text == "4")
//				{
//					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
//					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("###0.00");
//				
//				}
//
//				else
//				{
//					dedTotal4Amt12 = dedTotal1Amt12 + dedTotal2Amt12 + dedTotal3Amt12;
//					DedTotal3Amt12.Text = dedTotal4Amt12.ToString("#,##0"); 
//				
//				}
//// 管理番号 B15940 From
//			}
//			else
//			{
//				DedTotal3Amt12.Text = "";
//			}
//// 管理番号 B15940 To
// 管理番号 K24565 To

			// 管理番号 B15940 From
			if (((PaymntTotal3Amt1.Text == "0") || (PaymntTotal3Amt1.Text == "0.00")) && (PaymntZeroFlg1.Text == "0"))
			{
				PaymntTotal3Amt1.Text = "";
			}
			if ((PaymntItemId1.Text == null) || (PaymntItemId1.Text == ""))
			{
				PaymntTotal3Amt1.Text = "";
			}

			if (((PaymntTotal3Amt2.Text == "0") || (PaymntTotal3Amt2.Text == "0.00")) && (PaymntZeroFlg2.Text == "0"))
			{
				PaymntTotal3Amt2.Text = "";
			}
			if ((PaymntItemId2.Text == null) || (PaymntItemId2.Text == ""))
			{
				PaymntTotal3Amt2.Text = "";
			}

			if (((PaymntTotal3Amt3.Text == "0") || (PaymntTotal3Amt3.Text == "0.00")) && (PaymntZeroFlg3.Text == "0"))
			{
				PaymntTotal3Amt3.Text = "";
			}
			if ((PaymntItemId3.Text == null) || (PaymntItemId3.Text == ""))
			{
				PaymntTotal3Amt3.Text = "";
			}

			if (((PaymntTotal3Amt4.Text == "0") || (PaymntTotal3Amt4.Text == "0.00")) && (PaymntZeroFlg4.Text == "0"))
			{
				PaymntTotal3Amt4.Text = "";
			}
			if ((PaymntItemId4.Text == null) || (PaymntItemId4.Text == ""))
			{
				PaymntTotal3Amt4.Text = "";
			}

			if (((PaymntTotal3Amt5.Text == "0") || (PaymntTotal3Amt5.Text == "0.00")) && (PaymntZeroFlg5.Text == "0"))
			{
				PaymntTotal3Amt5.Text = "";
			}
			if ((PaymntItemId5.Text == null) || (PaymntItemId5.Text == ""))
			{
				PaymntTotal3Amt5.Text = "";
			}

			if (((PaymntTotal3Amt6.Text == "0") || (PaymntTotal3Amt6.Text == "0.00")) && (PaymntZeroFlg6.Text == "0"))
			{
				PaymntTotal3Amt6.Text = "";
			}
			if ((PaymntItemId6.Text == null) || (PaymntItemId6.Text == ""))
			{
				PaymntTotal3Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if (((PaymntTotal3Amt7.Text == "0") || (PaymntTotal3Amt7.Text == "0.00")) && (PaymntZeroFlg7.Text == "0"))
//			{
//				PaymntTotal3Amt7.Text = "";
//			}
//			if((PaymntItemId7.Text == null)||(PaymntItemId7.Text == ""))
//			{
//				PaymntTotal3Amt7.Text = "";
//			}
//
//			if(((PaymntTotal3Amt8.Text == "0") || (PaymntTotal3Amt8.Text == "0.00")) && (PaymntZeroFlg8.Text == "0"))
//			{
//				PaymntTotal3Amt8.Text = "";
//			}
//			if((PaymntItemId8.Text == null)||(PaymntItemId8.Text == ""))
//			{
//				PaymntTotal3Amt8.Text = "";
//			}
//
//			if(((PaymntTotal3Amt9.Text == "0") || (PaymntTotal3Amt9.Text == "0.00")) && (PaymntZeroFlg9.Text == "0"))
//			{
//				PaymntTotal3Amt9.Text = "";
//			}
//			if((PaymntItemId9.Text == null)||(PaymntItemId9.Text == ""))
//			{
//				PaymntTotal3Amt9.Text = "";
//			}
//
//			if(((PaymntTotal3Amt10.Text == "0") || (PaymntTotal3Amt10.Text == "0.00")) && (PaymntZeroFlg10.Text == "0"))
//			{
//				PaymntTotal3Amt10.Text = "";
//			}
//			if((PaymntItemId10.Text == null)||(PaymntItemId10.Text == ""))
//			{
//				PaymntTotal3Amt10.Text = "";
//			}
//
//			if(((PaymntTotal3Amt11.Text == "0") || (PaymntTotal3Amt11.Text == "0.00")) && (PaymntZeroFlg11.Text == "0"))
//			{
//				PaymntTotal3Amt11.Text = "";
//			}
//			if((PaymntItemId11.Text == null)||(PaymntItemId11.Text == ""))
//			{
//				PaymntTotal3Amt11.Text = "";
//			}
//
//			if(((PaymntTotal3Amt12.Text == "0") || (PaymntTotal3Amt12.Text == "0.00")) && (PaymntZeroFlg12.Text == "0"))
//			{
//				PaymntTotal3Amt12.Text = "";
//			}
//			if((PaymntItemId12.Text == null)||(PaymntItemId12.Text == ""))
//			{
//				PaymntTotal3Amt12.Text = "";
//			}
// 管理番号 K24565 To

			//給与控除合計の空白処理
			if (((DedTotal3Amt1.Text == "0") || (DedTotal3Amt1.Text == "0.00")) && (DedZeroFlg1.Text == "0"))
			{
				DedTotal3Amt1.Text = "";
			}
			if ((DedItemId1.Text == null) || (DedItemId1.Text == ""))
			{
				DedTotal3Amt1.Text = "";
			}

			if (((DedTotal3Amt2.Text == "0") || (DedTotal3Amt2.Text == "0.00")) && (DedZeroFlg2.Text == "0"))
			{
				DedTotal3Amt2.Text = "";
			}
			if ((DedItemId2.Text == null) || (DedItemId2.Text == ""))
			{
				DedTotal3Amt2.Text = "";
			}

			if (((DedTotal3Amt3.Text == "0") || (DedTotal3Amt3.Text == "0.00")) && (DedZeroFlg3.Text == "0"))
			{
				DedTotal3Amt3.Text = "";
			}
			if ((DedItemId3.Text == null) || (DedItemId3.Text == ""))
			{
				DedTotal3Amt3.Text = "";
			}

			if (((DedTotal3Amt4.Text == "0") || (DedTotal3Amt4.Text == "0.00")) && (DedZeroFlg4.Text == "0"))
			{
				DedTotal3Amt4.Text = "";
			}
			if ((DedItemId4.Text == null) || (DedItemId4.Text == ""))
			{
				DedTotal3Amt4.Text = "";
			}

			if (((DedTotal3Amt5.Text == "0") || (DedTotal3Amt5.Text == "0.00")) && (DedZeroFlg5.Text == "0"))
			{
				DedTotal3Amt5.Text = "";
			}
			if ((DedItemId5.Text == null) || (DedItemId5.Text == ""))
			{
				DedTotal3Amt5.Text = "";
			}

			if (((DedTotal3Amt6.Text == "0") || (DedTotal3Amt6.Text == "0.00")) && (DedZeroFlg6.Text == "0"))
			{
				DedTotal3Amt6.Text = "";
			}
			if ((DedItemId6.Text == null) || (DedItemId6.Text == ""))
			{
				DedTotal3Amt6.Text = "";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if (((DedTotal3Amt7.Text == "0") || (DedTotal3Amt7.Text == "0.00")) && (DedZeroFlg7.Text == "0"))
//			{
//				DedTotal3Amt7.Text = "";
//			}
//			if((DedItemId7.Text == null)||(DedItemId7.Text == ""))
//			{
//				DedTotal3Amt7.Text = "";
//			}
//
//			if(((DedTotal3Amt8.Text == "0") || (DedTotal3Amt8.Text == "0.00")) && (DedZeroFlg8.Text == "0"))
//			{
//				DedTotal3Amt8.Text = "";
//			}
//			if((DedItemId8.Text == null)||(DedItemId8.Text == ""))
//			{
//				DedTotal3Amt8.Text = "";
//			}
//
//			if(((DedTotal3Amt9.Text == "0") || (DedTotal3Amt9.Text == "0.00")) && (DedZeroFlg9.Text == "0"))
//			{
//				DedTotal3Amt9.Text = "";
//			}
//			if((DedItemId9.Text == null)||(DedItemId9.Text == ""))
//			{
//				DedTotal3Amt9.Text = "";
//			}
//
//			if(((DedTotal3Amt10.Text == "0") || (DedTotal3Amt10.Text == "0.00")) && (DedZeroFlg10.Text == "0"))
//			{
//				DedTotal3Amt10.Text = "";
//			}
//			if((DedItemId10.Text == null)||(DedItemId10.Text == ""))
//			{
//				DedTotal3Amt10.Text = "";
//			}
//
//			if(((DedTotal3Amt11.Text == "0") || (DedTotal3Amt11.Text == "0.00")) && (DedZeroFlg11.Text == "0"))
//			{
//				DedTotal3Amt11.Text = "";
//			}
//			if((DedItemId11.Text == null)||(DedItemId11.Text == ""))
//			{
//				DedTotal3Amt11.Text = "";
//			}
//
//			if(((DedTotal3Amt12.Text == "0") || (DedTotal3Amt12.Text == "0.00")) && (DedZeroFlg12.Text == "0"))
//			{
//				DedTotal3Amt12.Text = "";
//			}
//			if((DedItemId12.Text == null)||(DedItemId12.Text == ""))
//			{
//				DedTotal3Amt12.Text = "";
//			}
// 管理番号 K24565 To
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97、HR_PY_06_R98へ移動
//// 管理番号 B18529 From
//			//普通障害
//			//特別障害
//			//同居特障の数を普通障害、特別障害から差算する
//			TextBox465.Text = (Convert.ToInt32(TextBox465.Text) - Convert.ToInt32(TextBox476.Text)).ToString();
//			TextBox466.Text = (Convert.ToInt32(TextBox466.Text) - Convert.ToInt32(TextBox476.Text)).ToString();
//			//上記で求めた特別障害の数を普通障害から差算する
//			TextBox465.Text = (Convert.ToInt32(TextBox465.Text) - Convert.ToInt32(TextBox466.Text)).ToString();
//// 管理番号 B18529 To
//// 管理番号 B18526 From
//			TextBox473.Text = TextBox473.Text == "○" & TextBox472.Text != "○" ? TextBox473.Text:string.Empty;
//// 管理番号 B18526 To
//// 管理番号 K19592 From
//			// 地震保険料控除対応
//			if (SlryPaymntYy.Text.Substring(0,4).CompareTo(TAX_REVISION_YEAR) > 0)
//			{
//				// コメント欄表示
//				Label153.Visible	= false;
//// 管理番号 K24060 From
////				Label102.Text = EARTHQUAKE_INSURANCE_DED;
//				Label154.Text = EARTHQUAKE_INSURANCE_DED;
//// 管理番号 K24060 To
//			}
//			else
//			{
//				Label153.Visible	= true;
//			}
//// 管理番号 K19592 To
//// 管理番号 K20794 From
//			if (SlryPaymntYy.Text.Substring(0,4).CompareTo(TAX_REVISION_YEAR) > 0)
//			{
//// 管理番号 K24060 From
////                // 年税額(Ｈ１８年ベース)
////                if ((this.Paymnt18Amt12.Text != null) && (this.Paymnt18Amt12.Text  != ""))
////                {
////                    if(Convert.ToDecimal(this.Paymnt18Amt12.Text) == 0)
////                    {
////                        this.Label154.Text = "";
////                        this.Paymnt18Amt12.Text = "";
////                    }
////// 管理番号 B21167 From
////                    else
////                    {
////                        this.Label154.Text = "H18年税額";
////                    }
////// 管理番号 B21167 To
////                }
////                else
////                {
////                    this.Label154.Text = "";
////                    this.Paymnt18Amt12.Text = "";
////                }
//// 管理番号 K24060 To
//
//				// 住宅取得控除可能額
//				if ((this.Ded18Amt12.Text != null) && (this.Ded18Amt12.Text  != ""))
//				{
//					if(Convert.ToDecimal(this.Ded18Amt12.Text) == 0)
//					{
//						this.Label155.Text = "";
//						this.Ded18Amt12.Text = "";	
//					}
//// 管理番号 B21167 From
//					else
//					{
//						this.Label155.Text = "住宅可能額";
//					}
//// 管理番号 B21167 To
//				}
//				else
//				{
//					this.Label155.Text = "";
//					this.Ded18Amt12.Text = "";	
//				}
//
//			}
//			else
//			{
//// 管理番号 K24060 From
////				this.Label154.Text = "";
////				this.Paymnt18Amt12.Text = "";
//// 管理番号 K24060 To
//				this.Label155.Text = "";
//				this.Ded18Amt12.Text = "";	
//			}
//// 管理番号 K20794 To
//// 管理番号 K23647 From
//			// 年少扶養対応（年調年度≧2011年の場合にのみ表示）
//			if (SlryPaymntYy.Text.Substring(0, 4).CompareTo(H23_TAX_REVISION_YEAR) >= 0)
//			{
//				// 年少扶養人数表示
//				Label156.Visible = true;
//				TextBox484.Visible = true;
//			}
//			else
//			{
//				Label156.Visible = false;
//				TextBox484.Visible = false;
//			}
//// 管理番号 K23647 To
//// 管理番号 K24060 From
//			//年調年度＜2012年の時は、介護医療控除の金額は空白で印字
//			if (SlryPaymntYy.Text.Substring(0, 4).CompareTo(TAX_REVISION_CARE_YEAR) < 0)
//			{
//				this.Paymnt18Amt10.Text = "";
//			}
//// 管理番号 K24060 To
// 管理番号 K24565 To
// 管理番号K27274 From
//// 管理番号K26643 From
//			// 配偶者特別（年調年度≧2018年の場合は特別に()を付ける）
//			if (SlryPaymntYy.Text.Substring(0, 4).CompareTo(H30_TAX_REVISION_YEAR) >= 0)
//			{
//				// 括弧付き
//				Label104.Text = "配偶者(特別)";
//			}
//			else
//			{
//				// 括弧なし
//				Label104.Text = "配偶者特別";
//			}
//// 管理番号K26643 To
			// 地震保険料控除対応
			if (int.Parse(SlryPaymntYy.Text.Substring(0, 4)) > int.Parse(TAX_REVISION_YEAR))
			{
				// 2007年以降
				Label103.Text = EARTHQUAKE_INSURANCE_DED;
			}
			else
			{
				// 2006年以前
				Label103.Text = "損害保険控除";
			}

			// 配偶者特別（年調年度≧2018年の場合は特別に()を付ける）
			if (int.Parse(SlryPaymntYy.Text.Substring(0, 4)) >= int.Parse(H30_TAX_REVISION_YEAR))
			{
				// 括弧付き
				Label106.Text = "配偶者(特別)";
			}
			else
			{
				// 括弧なし
				Label106.Text = "配偶者特別";
			}
// 管理番号K27274 To
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
// 管理番号 K24565 From
			DataRow[] dtR29 = ((System.Data.DataView)DataSource).Table.Select("[EMP_CODE] = '" + EmpCode.Text.Trim() + "'", "[EMP_CODE]");

			// 給与・手当等、賞与等、前職修正分、総合計、年末調整の7-12列目のサブレポート
			rpt.HR_PY_06_R97 rptR97 = new HR_PY_06_R97();
			//データソースを渡す
			rptR97.DataSource = dtR29;
			this.SubReport1.Report = rptR97;
			this.SubReport1.Visible = true;

			// 勤怠、税情報のサブレポート
			rpt.HR_PY_06_R98 rptR98 = new HR_PY_06_R98();
			//データソースを渡す
			rptR98.DataSource = dtR29;
			this.SubReport2.Report = rptR98;
			this.SubReport2.Visible = true;
// 管理番号 K24565 To
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
			if (PaymntDispType1.Text == "2")
			{
				Paymnt1Amt1.OutputFormat = "###0";
				Paymnt2Amt1.OutputFormat = "###0";
				Paymnt3Amt1.OutputFormat = "###0";
				Paymnt4Amt1.OutputFormat = "###0";
				Paymnt5Amt1.OutputFormat = "###0";
				Paymnt6Amt1.OutputFormat = "###0";
				Paymnt7Amt1.OutputFormat = "###0";
				Paymnt8Amt1.OutputFormat = "###0";
				Paymnt9Amt1.OutputFormat = "###0";
				Paymnt10Amt1.OutputFormat = "###0";
				Paymnt11Amt1.OutputFormat = "###0";
				Paymnt12Amt1.OutputFormat = "###0";
				PaymntTotal1Amt1.OutputFormat = "###0";
				Paymnt13Amt1.OutputFormat = "###0";
				Paymnt14Amt1.OutputFormat = "###0";
				Paymnt15Amt1.OutputFormat = "###0";
				Paymnt16Amt1.OutputFormat = "###0";
				PaymntTotal2Amt1.OutputFormat = "###0";
				Paymnt17Amt1.OutputFormat = "###0";
				PaymntTotal3Amt1.OutputFormat = "###0";
			}

			else if (PaymntDispType1.Text == "3")
			{
				Paymnt1Amt1.OutputFormat = "#,##0.00";
				Paymnt2Amt1.OutputFormat = "#,##0.00";
				Paymnt3Amt1.OutputFormat = "#,##0.00";
				Paymnt4Amt1.OutputFormat = "#,##0.00";
				Paymnt5Amt1.OutputFormat = "#,##0.00";
				Paymnt6Amt1.OutputFormat = "#,##0.00";
				Paymnt7Amt1.OutputFormat = "#,##0.00";
				Paymnt8Amt1.OutputFormat = "#,##0.00";
				Paymnt9Amt1.OutputFormat = "#,##0.00";
				Paymnt10Amt1.OutputFormat = "#,##0.00";
				Paymnt11Amt1.OutputFormat = "#,##0.00";
				Paymnt12Amt1.OutputFormat = "#,##0.00";
				PaymntTotal1Amt1.OutputFormat = "#,##0.00";
				Paymnt13Amt1.OutputFormat = "#,##0.00";
				Paymnt14Amt1.OutputFormat = "#,##0.00";
				Paymnt15Amt1.OutputFormat = "#,##0.00";
				Paymnt16Amt1.OutputFormat = "#,##0.00";
				PaymntTotal2Amt1.OutputFormat = "#,##0.00";
				Paymnt17Amt1.OutputFormat = "#,##0.00";
				PaymntTotal3Amt1.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType1.Text == "4")
			{
				Paymnt1Amt1.OutputFormat = "###0.00";
				Paymnt2Amt1.OutputFormat = "###0.00";
				Paymnt3Amt1.OutputFormat = "###0.00";
				Paymnt4Amt1.OutputFormat = "###0.00";
				Paymnt5Amt1.OutputFormat = "###0.00";
				Paymnt6Amt1.OutputFormat = "###0.00";
				Paymnt7Amt1.OutputFormat = "###0.00";
				Paymnt8Amt1.OutputFormat = "###0.00";
				Paymnt9Amt1.OutputFormat = "###0.00";
				Paymnt10Amt1.OutputFormat = "###0.00";
				Paymnt11Amt1.OutputFormat = "###0.00";
				Paymnt12Amt1.OutputFormat = "###0.00";
				PaymntTotal1Amt1.OutputFormat = "###0.00";
				Paymnt13Amt1.OutputFormat = "###0.00";
				Paymnt14Amt1.OutputFormat = "###0.00";
				Paymnt15Amt1.OutputFormat = "###0.00";
				Paymnt16Amt1.OutputFormat = "###0.00";
				PaymntTotal2Amt1.OutputFormat = "###0.00";
				Paymnt17Amt1.OutputFormat = "###0.00";
				PaymntTotal3Amt1.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt1.OutputFormat = "#,##0";
				Paymnt2Amt1.OutputFormat = "#,##0";
				Paymnt3Amt1.OutputFormat = "#,##0";
				Paymnt4Amt1.OutputFormat = "#,##0";
				Paymnt5Amt1.OutputFormat = "#,##0";
				Paymnt6Amt1.OutputFormat = "#,##0";
				Paymnt7Amt1.OutputFormat = "#,##0";
				Paymnt8Amt1.OutputFormat = "#,##0";
				Paymnt9Amt1.OutputFormat = "#,##0";
				Paymnt10Amt1.OutputFormat = "#,##0";
				Paymnt11Amt1.OutputFormat = "#,##0";
				Paymnt12Amt1.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt1.OutputFormat = "###0";
				PaymntTotal1Amt1.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt1.OutputFormat = "#,##0";
				Paymnt14Amt1.OutputFormat = "#,##0";
				Paymnt15Amt1.OutputFormat = "#,##0";
				Paymnt16Amt1.OutputFormat = "#,##0";
				PaymntTotal2Amt1.OutputFormat = "#,##0";
				Paymnt17Amt1.OutputFormat = "#,##0";
				PaymntTotal3Amt1.OutputFormat = "#,##0";
			}

			if (PaymntDispType2.Text == "2")
			{
				Paymnt1Amt2.OutputFormat = "###0";
				Paymnt2Amt2.OutputFormat = "###0";
				Paymnt3Amt2.OutputFormat = "###0";
				Paymnt4Amt2.OutputFormat = "###0";
				Paymnt5Amt2.OutputFormat = "###0";
				Paymnt6Amt2.OutputFormat = "###0";
				Paymnt7Amt2.OutputFormat = "###0";
				Paymnt8Amt2.OutputFormat = "###0";
				Paymnt9Amt2.OutputFormat = "###0";
				Paymnt10Amt2.OutputFormat = "###0";
				Paymnt11Amt2.OutputFormat = "###0";
				Paymnt12Amt2.OutputFormat = "###0";
				PaymntTotal1Amt2.OutputFormat = "###0";
				Paymnt13Amt2.OutputFormat = "###0";
				Paymnt14Amt2.OutputFormat = "###0";
				Paymnt15Amt2.OutputFormat = "###0";
				Paymnt16Amt2.OutputFormat = "###0";
				PaymntTotal2Amt2.OutputFormat = "###0";
				Paymnt17Amt2.OutputFormat = "###0";
				PaymntTotal3Amt2.OutputFormat = "###0";
			}

			else if (PaymntDispType2.Text == "3")
			{
				Paymnt1Amt2.OutputFormat = "#,##0.00";
				Paymnt2Amt2.OutputFormat = "#,##0.00";
				Paymnt3Amt2.OutputFormat = "#,##0.00";
				Paymnt4Amt2.OutputFormat = "#,##0.00";
				Paymnt5Amt2.OutputFormat = "#,##0.00";
				Paymnt6Amt2.OutputFormat = "#,##0.00";
				Paymnt7Amt2.OutputFormat = "#,##0.00";
				Paymnt8Amt2.OutputFormat = "#,##0.00";
				Paymnt9Amt2.OutputFormat = "#,##0.00";
				Paymnt10Amt2.OutputFormat = "#,##0.00";
				Paymnt11Amt2.OutputFormat = "#,##0.00";
				Paymnt12Amt2.OutputFormat = "#,##0.00";
				PaymntTotal1Amt2.OutputFormat = "#,##0.00";
				Paymnt13Amt2.OutputFormat = "#,##0.00";
				Paymnt14Amt2.OutputFormat = "#,##0.00";
				Paymnt15Amt2.OutputFormat = "#,##0.00";
				Paymnt16Amt2.OutputFormat = "#,##0.00";
				PaymntTotal2Amt2.OutputFormat = "#,##0.00";
				Paymnt17Amt2.OutputFormat = "#,##0.00";
				PaymntTotal3Amt2.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType2.Text == "4")
			{
				Paymnt1Amt2.OutputFormat = "###0.00";
				Paymnt2Amt2.OutputFormat = "###0.00";
				Paymnt3Amt2.OutputFormat = "###0.00";
				Paymnt4Amt2.OutputFormat = "###0.00";
				Paymnt5Amt2.OutputFormat = "###0.00";
				Paymnt6Amt2.OutputFormat = "###0.00";
				Paymnt7Amt2.OutputFormat = "###0.00";
				Paymnt8Amt2.OutputFormat = "###0.00";
				Paymnt9Amt2.OutputFormat = "###0.00";
				Paymnt10Amt2.OutputFormat = "###0.00";
				Paymnt11Amt2.OutputFormat = "###0.00";
				Paymnt12Amt2.OutputFormat = "###0.00";
				PaymntTotal1Amt2.OutputFormat = "###0.00";
				Paymnt13Amt2.OutputFormat = "###0.00";
				Paymnt14Amt2.OutputFormat = "###0.00";
				Paymnt15Amt2.OutputFormat = "###0.00";
				Paymnt16Amt2.OutputFormat = "###0.00";
				PaymntTotal2Amt2.OutputFormat = "###0.00";
				Paymnt17Amt2.OutputFormat = "###0.00";
				PaymntTotal3Amt2.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt2.OutputFormat = "#,##0";
				Paymnt2Amt2.OutputFormat = "#,##0";
				Paymnt3Amt2.OutputFormat = "#,##0";
				Paymnt4Amt2.OutputFormat = "#,##0";
				Paymnt5Amt2.OutputFormat = "#,##0";
				Paymnt6Amt2.OutputFormat = "#,##0";
				Paymnt7Amt2.OutputFormat = "#,##0";
				Paymnt8Amt2.OutputFormat = "#,##0";
				Paymnt9Amt2.OutputFormat = "#,##0";
				Paymnt10Amt2.OutputFormat = "#,##0";
				Paymnt11Amt2.OutputFormat = "#,##0";
				Paymnt12Amt2.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt2.OutputFormat = "###0";
				PaymntTotal1Amt2.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt2.OutputFormat = "#,##0";
				Paymnt14Amt2.OutputFormat = "#,##0";
				Paymnt15Amt2.OutputFormat = "#,##0";
				Paymnt16Amt2.OutputFormat = "#,##0";
				PaymntTotal2Amt2.OutputFormat = "#,##0";
				Paymnt17Amt2.OutputFormat = "#,##0";
				PaymntTotal3Amt2.OutputFormat = "#,##0";
			}

			if (PaymntDispType3.Text == "2")
			{
				Paymnt1Amt3.OutputFormat = "###0";
				Paymnt2Amt3.OutputFormat = "###0";
				Paymnt3Amt3.OutputFormat = "###0";
				Paymnt4Amt3.OutputFormat = "###0";
				Paymnt5Amt3.OutputFormat = "###0";
				Paymnt6Amt3.OutputFormat = "###0";
				Paymnt7Amt3.OutputFormat = "###0";
				Paymnt8Amt3.OutputFormat = "###0";
				Paymnt9Amt3.OutputFormat = "###0";
				Paymnt10Amt3.OutputFormat = "###0";
				Paymnt11Amt3.OutputFormat = "###0";
				Paymnt12Amt3.OutputFormat = "###0";
			}

			if (PaymntDispType3.Text == "2")
			{
				Paymnt1Amt3.OutputFormat = "###0";
				Paymnt2Amt3.OutputFormat = "###0";
				Paymnt3Amt3.OutputFormat = "###0";
				Paymnt4Amt3.OutputFormat = "###0";
				Paymnt5Amt3.OutputFormat = "###0";
				Paymnt6Amt3.OutputFormat = "###0";
				Paymnt7Amt3.OutputFormat = "###0";
				Paymnt8Amt3.OutputFormat = "###0";
				Paymnt9Amt3.OutputFormat = "###0";
				Paymnt10Amt3.OutputFormat = "###0";
				Paymnt11Amt3.OutputFormat = "###0";
				Paymnt12Amt3.OutputFormat = "###0";
				PaymntTotal1Amt3.OutputFormat = "###0";
				Paymnt13Amt3.OutputFormat = "###0";
				Paymnt14Amt3.OutputFormat = "###0";
				Paymnt15Amt3.OutputFormat = "###0";
				Paymnt16Amt3.OutputFormat = "###0";
				PaymntTotal2Amt3.OutputFormat = "###0";
				Paymnt17Amt3.OutputFormat = "###0";
				PaymntTotal3Amt3.OutputFormat = "###0";
			}

			else if (PaymntDispType3.Text == "3")
			{
				Paymnt1Amt3.OutputFormat = "#,##0.00";
				Paymnt2Amt3.OutputFormat = "#,##0.00";
				Paymnt3Amt3.OutputFormat = "#,##0.00";
				Paymnt4Amt3.OutputFormat = "#,##0.00";
				Paymnt5Amt3.OutputFormat = "#,##0.00";
				Paymnt6Amt3.OutputFormat = "#,##0.00";
				Paymnt7Amt3.OutputFormat = "#,##0.00";
				Paymnt8Amt3.OutputFormat = "#,##0.00";
				Paymnt9Amt3.OutputFormat = "#,##0.00";
				Paymnt10Amt3.OutputFormat = "#,##0.00";
				Paymnt11Amt3.OutputFormat = "#,##0.00";
				Paymnt12Amt3.OutputFormat = "#,##0.00";
				PaymntTotal1Amt3.OutputFormat = "#,##0.00";
				Paymnt13Amt3.OutputFormat = "#,##0.00";
				Paymnt14Amt3.OutputFormat = "#,##0.00";
				Paymnt15Amt3.OutputFormat = "#,##0.00";
				Paymnt16Amt3.OutputFormat = "#,##0.00";
				PaymntTotal2Amt3.OutputFormat = "#,##0.00";
				Paymnt17Amt3.OutputFormat = "#,##0.00";
				PaymntTotal3Amt3.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType3.Text == "4")
			{
				Paymnt1Amt3.OutputFormat = "###0.00";
				Paymnt2Amt3.OutputFormat = "###0.00";
				Paymnt3Amt3.OutputFormat = "###0.00";
				Paymnt4Amt3.OutputFormat = "###0.00";
				Paymnt5Amt3.OutputFormat = "###0.00";
				Paymnt6Amt3.OutputFormat = "###0.00";
				Paymnt7Amt3.OutputFormat = "###0.00";
				Paymnt8Amt3.OutputFormat = "###0.00";
				Paymnt9Amt3.OutputFormat = "###0.00";
				Paymnt10Amt3.OutputFormat = "###0.00";
				Paymnt11Amt3.OutputFormat = "###0.00";
				Paymnt12Amt3.OutputFormat = "###0.00";
				PaymntTotal1Amt3.OutputFormat = "###0.00";
				Paymnt13Amt3.OutputFormat = "###0.00";
				Paymnt14Amt3.OutputFormat = "###0.00";
				Paymnt15Amt3.OutputFormat = "###0.00";
				Paymnt16Amt3.OutputFormat = "###0.00";
				PaymntTotal2Amt3.OutputFormat = "###0.00";
				Paymnt17Amt3.OutputFormat = "###0.00";
				PaymntTotal3Amt3.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt3.OutputFormat = "#,##0";
				Paymnt2Amt3.OutputFormat = "#,##0";
				Paymnt3Amt3.OutputFormat = "#,##0";
				Paymnt4Amt3.OutputFormat = "#,##0";
				Paymnt5Amt3.OutputFormat = "#,##0";
				Paymnt6Amt3.OutputFormat = "#,##0";
				Paymnt7Amt3.OutputFormat = "#,##0";
				Paymnt8Amt3.OutputFormat = "#,##0";
				Paymnt9Amt3.OutputFormat = "#,##0";
				Paymnt10Amt3.OutputFormat = "#,##0";
				Paymnt11Amt3.OutputFormat = "#,##0";
				Paymnt12Amt3.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt3.OutputFormat = "###0";
				PaymntTotal1Amt3.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt3.OutputFormat = "#,##0";
				Paymnt14Amt3.OutputFormat = "#,##0";
				Paymnt15Amt3.OutputFormat = "#,##0";
				Paymnt16Amt3.OutputFormat = "#,##0";
				PaymntTotal2Amt3.OutputFormat = "#,##0";
				Paymnt17Amt3.OutputFormat = "#,##0";
				PaymntTotal3Amt3.OutputFormat = "#,##0";
			}

			if (PaymntDispType4.Text == "2")
			{
				Paymnt1Amt4.OutputFormat = "###0";
				Paymnt2Amt4.OutputFormat = "###0";
				Paymnt3Amt4.OutputFormat = "###0";
				Paymnt4Amt4.OutputFormat = "###0";
				Paymnt5Amt4.OutputFormat = "###0";
				Paymnt6Amt4.OutputFormat = "###0";
				Paymnt7Amt4.OutputFormat = "###0";
				Paymnt8Amt4.OutputFormat = "###0";
				Paymnt9Amt4.OutputFormat = "###0";
				Paymnt10Amt4.OutputFormat = "###0";
				Paymnt11Amt4.OutputFormat = "###0";
				Paymnt12Amt4.OutputFormat = "###0";
				PaymntTotal1Amt4.OutputFormat = "###0";
				Paymnt13Amt4.OutputFormat = "###0";
				Paymnt14Amt4.OutputFormat = "###0";
				Paymnt15Amt4.OutputFormat = "###0";
				Paymnt16Amt4.OutputFormat = "###0";
				PaymntTotal2Amt4.OutputFormat = "###0";
				Paymnt17Amt4.OutputFormat = "###0";
				PaymntTotal3Amt4.OutputFormat = "###0";
			}

			else if (PaymntDispType4.Text == "3")
			{
				Paymnt1Amt4.OutputFormat = "#,##0.00";
				Paymnt2Amt4.OutputFormat = "#,##0.00";
				Paymnt3Amt4.OutputFormat = "#,##0.00";
				Paymnt4Amt4.OutputFormat = "#,##0.00";
				Paymnt5Amt4.OutputFormat = "#,##0.00";
				Paymnt6Amt4.OutputFormat = "#,##0.00";
				Paymnt7Amt4.OutputFormat = "#,##0.00";
				Paymnt8Amt4.OutputFormat = "#,##0.00";
				Paymnt9Amt4.OutputFormat = "#,##0.00";
				Paymnt10Amt4.OutputFormat = "#,##0.00";
				Paymnt11Amt4.OutputFormat = "#,##0.00";
				Paymnt12Amt4.OutputFormat = "#,##0.00";
				PaymntTotal1Amt4.OutputFormat = "#,##0.00";
				Paymnt13Amt4.OutputFormat = "#,##0.00";
				Paymnt14Amt4.OutputFormat = "#,##0.00";
				Paymnt15Amt4.OutputFormat = "#,##0.00";
				Paymnt16Amt4.OutputFormat = "#,##0.00";
				PaymntTotal2Amt4.OutputFormat = "#,##0.00";
				Paymnt17Amt4.OutputFormat = "#,##0.00";
				PaymntTotal3Amt4.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType4.Text == "4")
			{
				Paymnt1Amt4.OutputFormat = "###0.00";
				Paymnt2Amt4.OutputFormat = "###0.00";
				Paymnt3Amt4.OutputFormat = "###0.00";
				Paymnt4Amt4.OutputFormat = "###0.00";
				Paymnt5Amt4.OutputFormat = "###0.00";
				Paymnt6Amt4.OutputFormat = "###0.00";
				Paymnt7Amt4.OutputFormat = "###0.00";
				Paymnt8Amt4.OutputFormat = "###0.00";
				Paymnt9Amt4.OutputFormat = "###0.00";
				Paymnt10Amt4.OutputFormat = "###0.00";
				Paymnt11Amt4.OutputFormat = "###0.00";
				Paymnt12Amt4.OutputFormat = "###0.00";
				PaymntTotal1Amt4.OutputFormat = "###0.00";
				Paymnt13Amt4.OutputFormat = "###0.00";
				Paymnt14Amt4.OutputFormat = "###0.00";
				Paymnt15Amt4.OutputFormat = "###0.00";
				Paymnt16Amt4.OutputFormat = "###0.00";
				PaymntTotal2Amt4.OutputFormat = "###0.00";
				Paymnt17Amt4.OutputFormat = "###0.00";
				PaymntTotal3Amt4.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt4.OutputFormat = "#,##0";
				Paymnt2Amt4.OutputFormat = "#,##0";
				Paymnt3Amt4.OutputFormat = "#,##0";
				Paymnt4Amt4.OutputFormat = "#,##0";
				Paymnt5Amt4.OutputFormat = "#,##0";
				Paymnt6Amt4.OutputFormat = "#,##0";
				Paymnt7Amt4.OutputFormat = "#,##0";
				Paymnt8Amt4.OutputFormat = "#,##0";
				Paymnt9Amt4.OutputFormat = "#,##0";
				Paymnt10Amt4.OutputFormat = "#,##0";
				Paymnt11Amt4.OutputFormat = "#,##0";
				Paymnt12Amt4.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt4.OutputFormat = "###0";
				PaymntTotal1Amt4.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt4.OutputFormat = "#,##0";
				Paymnt14Amt4.OutputFormat = "#,##0";
				Paymnt15Amt4.OutputFormat = "#,##0";
				Paymnt16Amt4.OutputFormat = "#,##0";
				PaymntTotal2Amt4.OutputFormat = "#,##0";
				Paymnt17Amt4.OutputFormat = "#,##0";
				PaymntTotal3Amt4.OutputFormat = "#,##0";
			}

			if (PaymntDispType5.Text == "2")
			{
				Paymnt1Amt5.OutputFormat = "###0";
				Paymnt2Amt5.OutputFormat = "###0";
				Paymnt3Amt5.OutputFormat = "###0";
				Paymnt4Amt5.OutputFormat = "###0";
				Paymnt5Amt5.OutputFormat = "###0";
				Paymnt6Amt5.OutputFormat = "###0";
				Paymnt7Amt5.OutputFormat = "###0";
				Paymnt8Amt5.OutputFormat = "###0";
				Paymnt9Amt5.OutputFormat = "###0";
				Paymnt10Amt5.OutputFormat = "###0";
				Paymnt11Amt5.OutputFormat = "###0";
				Paymnt12Amt5.OutputFormat = "###0";
				PaymntTotal1Amt5.OutputFormat = "###0";
				Paymnt13Amt5.OutputFormat = "###0";
				Paymnt14Amt5.OutputFormat = "###0";
				Paymnt15Amt5.OutputFormat = "###0";
				Paymnt16Amt5.OutputFormat = "###0";
				PaymntTotal2Amt5.OutputFormat = "###0";
				Paymnt17Amt5.OutputFormat = "###0";
				PaymntTotal3Amt5.OutputFormat = "###0";
			}

			else if (PaymntDispType5.Text == "3")
			{
				Paymnt1Amt5.OutputFormat = "#,##0.00";
				Paymnt2Amt5.OutputFormat = "#,##0.00";
				Paymnt3Amt5.OutputFormat = "#,##0.00";
				Paymnt4Amt5.OutputFormat = "#,##0.00";
				Paymnt5Amt5.OutputFormat = "#,##0.00";
				Paymnt6Amt5.OutputFormat = "#,##0.00";
				Paymnt7Amt5.OutputFormat = "#,##0.00";
				Paymnt8Amt5.OutputFormat = "#,##0.00";
				Paymnt9Amt5.OutputFormat = "#,##0.00";
				Paymnt10Amt5.OutputFormat = "#,##0.00";
				Paymnt11Amt5.OutputFormat = "#,##0.00";
				Paymnt12Amt5.OutputFormat = "#,##0.00";
				PaymntTotal1Amt5.OutputFormat = "#,##0.00";
				Paymnt13Amt5.OutputFormat = "#,##0.00";
				Paymnt14Amt5.OutputFormat = "#,##0.00";
				Paymnt15Amt5.OutputFormat = "#,##0.00";
				Paymnt16Amt5.OutputFormat = "#,##0.00";
				PaymntTotal2Amt5.OutputFormat = "#,##0.00";
				Paymnt17Amt5.OutputFormat = "#,##0.00";
				PaymntTotal3Amt5.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType5.Text == "4")
			{
				Paymnt1Amt5.OutputFormat = "###0.00";
				Paymnt2Amt5.OutputFormat = "###0.00";
				Paymnt3Amt5.OutputFormat = "###0.00";
				Paymnt4Amt5.OutputFormat = "###0.00";
				Paymnt5Amt5.OutputFormat = "###0.00";
				Paymnt6Amt5.OutputFormat = "###0.00";
				Paymnt7Amt5.OutputFormat = "###0.00";
				Paymnt8Amt5.OutputFormat = "###0.00";
				Paymnt9Amt5.OutputFormat = "###0.00";
				Paymnt10Amt5.OutputFormat = "###0.00";
				Paymnt11Amt5.OutputFormat = "###0.00";
				Paymnt12Amt5.OutputFormat = "###0.00";
				PaymntTotal1Amt5.OutputFormat = "###0.00";
				Paymnt13Amt5.OutputFormat = "###0.00";
				Paymnt14Amt5.OutputFormat = "###0.00";
				Paymnt15Amt5.OutputFormat = "###0.00";
				Paymnt16Amt5.OutputFormat = "###0.00";
				PaymntTotal2Amt5.OutputFormat = "###0.00";
				Paymnt17Amt5.OutputFormat = "###0.00";
				PaymntTotal3Amt5.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt5.OutputFormat = "#,##0";
				Paymnt2Amt5.OutputFormat = "#,##0";
				Paymnt3Amt5.OutputFormat = "#,##0";
				Paymnt4Amt5.OutputFormat = "#,##0";
				Paymnt5Amt5.OutputFormat = "#,##0";
				Paymnt6Amt5.OutputFormat = "#,##0";
				Paymnt7Amt5.OutputFormat = "#,##0";
				Paymnt8Amt5.OutputFormat = "#,##0";
				Paymnt9Amt5.OutputFormat = "#,##0";
				Paymnt10Amt5.OutputFormat = "#,##0";
				Paymnt11Amt5.OutputFormat = "#,##0";
				Paymnt12Amt5.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt5.OutputFormat = "###0";
				PaymntTotal1Amt5.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt5.OutputFormat = "#,##0";
				Paymnt14Amt5.OutputFormat = "#,##0";
				Paymnt15Amt5.OutputFormat = "#,##0";
				Paymnt16Amt5.OutputFormat = "#,##0";
				PaymntTotal2Amt5.OutputFormat = "#,##0";
				Paymnt17Amt5.OutputFormat = "#,##0";
				PaymntTotal3Amt5.OutputFormat = "#,##0";
			}

			if (PaymntDispType6.Text == "2")
			{
				Paymnt1Amt6.OutputFormat = "###0";
				Paymnt2Amt6.OutputFormat = "###0";
				Paymnt3Amt6.OutputFormat = "###0";
				Paymnt4Amt6.OutputFormat = "###0";
				Paymnt5Amt6.OutputFormat = "###0";
				Paymnt6Amt6.OutputFormat = "###0";
				Paymnt7Amt6.OutputFormat = "###0";
				Paymnt8Amt6.OutputFormat = "###0";
				Paymnt9Amt6.OutputFormat = "###0";
				Paymnt10Amt6.OutputFormat = "###0";
				Paymnt11Amt6.OutputFormat = "###0";
				Paymnt12Amt6.OutputFormat = "###0";
				PaymntTotal1Amt6.OutputFormat = "###0";
				Paymnt13Amt6.OutputFormat = "###0";
				Paymnt14Amt6.OutputFormat = "###0";
				Paymnt15Amt6.OutputFormat = "###0";
				Paymnt16Amt6.OutputFormat = "###0";
				PaymntTotal2Amt6.OutputFormat = "###0";
				Paymnt17Amt6.OutputFormat = "###0";
				PaymntTotal3Amt6.OutputFormat = "###0";
			}

			else if (PaymntDispType6.Text == "3")
			{
				Paymnt1Amt6.OutputFormat = "#,##0.00";
				Paymnt2Amt6.OutputFormat = "#,##0.00";
				Paymnt3Amt6.OutputFormat = "#,##0.00";
				Paymnt4Amt6.OutputFormat = "#,##0.00";
				Paymnt5Amt6.OutputFormat = "#,##0.00";
				Paymnt6Amt6.OutputFormat = "#,##0.00";
				Paymnt7Amt6.OutputFormat = "#,##0.00";
				Paymnt8Amt6.OutputFormat = "#,##0.00";
				Paymnt9Amt6.OutputFormat = "#,##0.00";
				Paymnt10Amt6.OutputFormat = "#,##0.00";
				Paymnt11Amt6.OutputFormat = "#,##0.00";
				Paymnt12Amt6.OutputFormat = "#,##0.00";
				PaymntTotal1Amt6.OutputFormat = "#,##0.00";
				Paymnt13Amt6.OutputFormat = "#,##0.00";
				Paymnt14Amt6.OutputFormat = "#,##0.00";
				Paymnt15Amt6.OutputFormat = "#,##0.00";
				Paymnt16Amt6.OutputFormat = "#,##0.00";
				PaymntTotal2Amt6.OutputFormat = "#,##0.00";
				Paymnt17Amt6.OutputFormat = "#,##0.00";
				PaymntTotal3Amt6.OutputFormat = "#,##0.00";
			}

			else if (PaymntDispType6.Text == "4")
			{
				Paymnt1Amt6.OutputFormat = "###0.00";
				Paymnt2Amt6.OutputFormat = "###0.00";
				Paymnt3Amt6.OutputFormat = "###0.00";
				Paymnt4Amt6.OutputFormat = "###0.00";
				Paymnt5Amt6.OutputFormat = "###0.00";
				Paymnt6Amt6.OutputFormat = "###0.00";
				Paymnt7Amt6.OutputFormat = "###0.00";
				Paymnt8Amt6.OutputFormat = "###0.00";
				Paymnt9Amt6.OutputFormat = "###0.00";
				Paymnt10Amt6.OutputFormat = "###0.00";
				Paymnt11Amt6.OutputFormat = "###0.00";
				Paymnt12Amt6.OutputFormat = "###0.00";
				PaymntTotal1Amt6.OutputFormat = "###0.00";
				Paymnt13Amt6.OutputFormat = "###0.00";
				Paymnt14Amt6.OutputFormat = "###0.00";
				Paymnt15Amt6.OutputFormat = "###0.00";
				Paymnt16Amt6.OutputFormat = "###0.00";
				PaymntTotal2Amt6.OutputFormat = "###0.00";
				Paymnt17Amt6.OutputFormat = "###0.00";
				PaymntTotal3Amt6.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt1Amt6.OutputFormat = "#,##0";
				Paymnt2Amt6.OutputFormat = "#,##0";
				Paymnt3Amt6.OutputFormat = "#,##0";
				Paymnt4Amt6.OutputFormat = "#,##0";
				Paymnt5Amt6.OutputFormat = "#,##0";
				Paymnt6Amt6.OutputFormat = "#,##0";
				Paymnt7Amt6.OutputFormat = "#,##0";
				Paymnt8Amt6.OutputFormat = "#,##0";
				Paymnt9Amt6.OutputFormat = "#,##0";
				Paymnt10Amt6.OutputFormat = "#,##0";
				Paymnt11Amt6.OutputFormat = "#,##0";
				Paymnt12Amt6.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//PaymntTotal1Amt6.OutputFormat = "###0";
				PaymntTotal1Amt6.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Paymnt13Amt6.OutputFormat = "#,##0";
				Paymnt14Amt6.OutputFormat = "#,##0";
				Paymnt15Amt6.OutputFormat = "#,##0";
				Paymnt16Amt6.OutputFormat = "#,##0";
				PaymntTotal2Amt6.OutputFormat = "#,##0";
				Paymnt17Amt6.OutputFormat = "#,##0";
				PaymntTotal3Amt6.OutputFormat = "#,##0";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if(PaymntDispType7.Text == "2")
//			{
//				Paymnt1Amt7.OutputFormat = "###0";
//				Paymnt2Amt7.OutputFormat = "###0";
//				Paymnt3Amt7.OutputFormat = "###0";
//				Paymnt4Amt7.OutputFormat = "###0";
//				Paymnt5Amt7.OutputFormat = "###0";
//				Paymnt6Amt7.OutputFormat = "###0";
//				Paymnt7Amt7.OutputFormat = "###0";
//				Paymnt8Amt7.OutputFormat = "###0";
//				Paymnt9Amt7.OutputFormat = "###0";
//				Paymnt10Amt7.OutputFormat = "###0";
//				Paymnt11Amt7.OutputFormat = "###0";
//				Paymnt12Amt7.OutputFormat = "###0";
//				PaymntTotal1Amt7.OutputFormat = "###0";
//				Paymnt13Amt7.OutputFormat = "###0";
//				Paymnt14Amt7.OutputFormat = "###0";
//				Paymnt15Amt7.OutputFormat = "###0";
//				Paymnt16Amt7.OutputFormat = "###0";
//				PaymntTotal2Amt7.OutputFormat = "###0";
//				Paymnt17Amt7.OutputFormat = "###0";
//				PaymntTotal3Amt7.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType7.Text == "3")
//			{
//				Paymnt1Amt7.OutputFormat = "#,##0.00";
//				Paymnt2Amt7.OutputFormat = "#,##0.00";
//				Paymnt3Amt7.OutputFormat = "#,##0.00";
//				Paymnt4Amt7.OutputFormat = "#,##0.00";
//				Paymnt5Amt7.OutputFormat = "#,##0.00";
//				Paymnt6Amt7.OutputFormat = "#,##0.00";
//				Paymnt7Amt7.OutputFormat = "#,##0.00";
//				Paymnt8Amt7.OutputFormat = "#,##0.00";
//				Paymnt9Amt7.OutputFormat = "#,##0.00";
//				Paymnt10Amt7.OutputFormat = "#,##0.00";
//				Paymnt11Amt7.OutputFormat = "#,##0.00";
//				Paymnt12Amt7.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt7.OutputFormat = "#,##0.00";
//				Paymnt13Amt7.OutputFormat = "#,##0.00";
//				Paymnt14Amt7.OutputFormat = "#,##0.00";
//				Paymnt15Amt7.OutputFormat = "#,##0.00";
//				Paymnt16Amt7.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt7.OutputFormat = "#,##0.00";
//				Paymnt17Amt7.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt7.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType7.Text == "4")
//			{
//				Paymnt1Amt7.OutputFormat = "###0.00";
//				Paymnt2Amt7.OutputFormat = "###0.00";
//				Paymnt3Amt7.OutputFormat = "###0.00";
//				Paymnt4Amt7.OutputFormat = "###0.00";
//				Paymnt5Amt7.OutputFormat = "###0.00";
//				Paymnt6Amt7.OutputFormat = "###0.00";
//				Paymnt7Amt7.OutputFormat = "###0.00";
//				Paymnt8Amt7.OutputFormat = "###0.00";
//				Paymnt9Amt7.OutputFormat = "###0.00";
//				Paymnt10Amt7.OutputFormat = "###0.00";
//				Paymnt11Amt7.OutputFormat = "###0.00";
//				Paymnt12Amt7.OutputFormat = "###0.00";
//				PaymntTotal1Amt7.OutputFormat = "###0.00";
//				Paymnt13Amt7.OutputFormat = "###0.00";
//				Paymnt14Amt7.OutputFormat = "###0.00";
//				Paymnt15Amt7.OutputFormat = "###0.00";
//				Paymnt16Amt7.OutputFormat = "###0.00";
//				PaymntTotal2Amt7.OutputFormat = "###0.00";
//				Paymnt17Amt7.OutputFormat = "###0.00";
//				PaymntTotal3Amt7.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt7.OutputFormat = "#,##0";
//				Paymnt2Amt7.OutputFormat = "#,##0";
//				Paymnt3Amt7.OutputFormat = "#,##0";
//				Paymnt4Amt7.OutputFormat = "#,##0";
//				Paymnt5Amt7.OutputFormat = "#,##0";
//				Paymnt6Amt7.OutputFormat = "#,##0";
//				Paymnt7Amt7.OutputFormat = "#,##0";
//				Paymnt8Amt7.OutputFormat = "#,##0";
//				Paymnt9Amt7.OutputFormat = "#,##0";
//				Paymnt10Amt7.OutputFormat = "#,##0";
//				Paymnt11Amt7.OutputFormat = "#,##0";
//				Paymnt12Amt7.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//PaymntTotal1Amt7.OutputFormat = "###0";
//				PaymntTotal1Amt7.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Paymnt13Amt7.OutputFormat = "#,##0";
//				Paymnt14Amt7.OutputFormat = "#,##0";
//				Paymnt15Amt7.OutputFormat = "#,##0";
//				Paymnt16Amt7.OutputFormat = "#,##0";
//				PaymntTotal2Amt7.OutputFormat = "#,##0";
//				Paymnt17Amt7.OutputFormat = "#,##0";
//				PaymntTotal3Amt7.OutputFormat = "#,##0";
//			}
//
//			if(PaymntDispType8.Text == "2")
//			{
//				Paymnt1Amt8.OutputFormat = "###0";
//				Paymnt2Amt8.OutputFormat = "###0";
//				Paymnt3Amt8.OutputFormat = "###0";
//				Paymnt4Amt8.OutputFormat = "###0";
//				Paymnt5Amt8.OutputFormat = "###0";
//				Paymnt6Amt8.OutputFormat = "###0";
//				Paymnt7Amt8.OutputFormat = "###0";
//				Paymnt8Amt8.OutputFormat = "###0";
//				Paymnt9Amt8.OutputFormat = "###0";
//				Paymnt10Amt8.OutputFormat = "###0";
//				Paymnt11Amt8.OutputFormat = "###0";
//				Paymnt12Amt8.OutputFormat = "###0";
//				PaymntTotal1Amt8.OutputFormat = "###0";
//				Paymnt13Amt8.OutputFormat = "###0";
//				Paymnt14Amt8.OutputFormat = "###0";
//				Paymnt15Amt8.OutputFormat = "###0";
//				Paymnt16Amt8.OutputFormat = "###0";
//				PaymntTotal2Amt8.OutputFormat = "###0";
//				Paymnt17Amt8.OutputFormat = "###0";
//				PaymntTotal3Amt8.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType8.Text == "3")
//			{
//				Paymnt1Amt8.OutputFormat = "#,##0.00";
//				Paymnt2Amt8.OutputFormat = "#,##0.00";
//				Paymnt3Amt8.OutputFormat = "#,##0.00";
//				Paymnt4Amt8.OutputFormat = "#,##0.00";
//				Paymnt5Amt8.OutputFormat = "#,##0.00";
//				Paymnt6Amt8.OutputFormat = "#,##0.00";
//				Paymnt7Amt8.OutputFormat = "#,##0.00";
//				Paymnt8Amt8.OutputFormat = "#,##0.00";
//				Paymnt9Amt8.OutputFormat = "#,##0.00";
//				Paymnt10Amt8.OutputFormat = "#,##0.00";
//				Paymnt11Amt8.OutputFormat = "#,##0.00";
//				Paymnt12Amt8.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt8.OutputFormat = "#,##0.00";
//				Paymnt13Amt8.OutputFormat = "#,##0.00";
//				Paymnt14Amt8.OutputFormat = "#,##0.00";
//				Paymnt15Amt8.OutputFormat = "#,##0.00";
//				Paymnt16Amt8.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt8.OutputFormat = "#,##0.00";
//				Paymnt17Amt8.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt8.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType8.Text == "4")
//			{
//				Paymnt1Amt8.OutputFormat = "###0.00";
//				Paymnt2Amt8.OutputFormat = "###0.00";
//				Paymnt3Amt8.OutputFormat = "###0.00";
//				Paymnt4Amt8.OutputFormat = "###0.00";
//				Paymnt5Amt8.OutputFormat = "###0.00";
//				Paymnt6Amt8.OutputFormat = "###0.00";
//				Paymnt7Amt8.OutputFormat = "###0.00";
//				Paymnt8Amt8.OutputFormat = "###0.00";
//				Paymnt9Amt8.OutputFormat = "###0.00";
//				Paymnt10Amt8.OutputFormat = "###0.00";
//				Paymnt11Amt8.OutputFormat = "###0.00";
//				Paymnt12Amt8.OutputFormat = "###0.00";
//				PaymntTotal1Amt8.OutputFormat = "###0.00";
//				Paymnt13Amt8.OutputFormat = "###0.00";
//				Paymnt14Amt8.OutputFormat = "###0.00";
//				Paymnt15Amt8.OutputFormat = "###0.00";
//				Paymnt16Amt8.OutputFormat = "###0.00";
//				PaymntTotal2Amt8.OutputFormat = "###0.00";
//				Paymnt17Amt8.OutputFormat = "###0.00";
//				PaymntTotal3Amt8.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt8.OutputFormat = "#,##0";
//				Paymnt2Amt8.OutputFormat = "#,##0";
//				Paymnt3Amt8.OutputFormat = "#,##0";
//				Paymnt4Amt8.OutputFormat = "#,##0";
//				Paymnt5Amt8.OutputFormat = "#,##0";
//				Paymnt6Amt8.OutputFormat = "#,##0";
//				Paymnt7Amt8.OutputFormat = "#,##0";
//				Paymnt8Amt8.OutputFormat = "#,##0";
//				Paymnt9Amt8.OutputFormat = "#,##0";
//				Paymnt10Amt8.OutputFormat = "#,##0";
//				Paymnt11Amt8.OutputFormat = "#,##0";
//				Paymnt12Amt8.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//PaymntTotal1Amt8.OutputFormat = "###0";
//				PaymntTotal1Amt8.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Paymnt13Amt8.OutputFormat = "#,##0";
//				Paymnt14Amt8.OutputFormat = "#,##0";
//				Paymnt15Amt8.OutputFormat = "#,##0";
//				Paymnt16Amt8.OutputFormat = "#,##0";
//				PaymntTotal2Amt8.OutputFormat = "#,##0";
//				Paymnt17Amt8.OutputFormat = "#,##0";
//				PaymntTotal3Amt8.OutputFormat = "#,##0";
//			}
//
//			if(PaymntDispType9.Text == "2")
//			{
//				Paymnt1Amt9.OutputFormat = "###0";
//				Paymnt2Amt9.OutputFormat = "###0";
//				Paymnt3Amt9.OutputFormat = "###0";
//				Paymnt4Amt9.OutputFormat = "###0";
//				Paymnt5Amt9.OutputFormat = "###0";
//				Paymnt6Amt9.OutputFormat = "###0";
//				Paymnt7Amt9.OutputFormat = "###0";
//				Paymnt8Amt9.OutputFormat = "###0";
//				Paymnt9Amt9.OutputFormat = "###0";
//				Paymnt10Amt9.OutputFormat = "###0";
//				Paymnt11Amt9.OutputFormat = "###0";
//				Paymnt12Amt9.OutputFormat = "###0";
//				PaymntTotal1Amt9.OutputFormat = "###0";
//				Paymnt13Amt9.OutputFormat = "###0";
//				Paymnt14Amt9.OutputFormat = "###0";
//				Paymnt15Amt9.OutputFormat = "###0";
//				Paymnt16Amt9.OutputFormat = "###0";
//				PaymntTotal2Amt9.OutputFormat = "###0";
//				Paymnt17Amt9.OutputFormat = "###0";
//				PaymntTotal3Amt9.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType9.Text == "3")
//			{
//				Paymnt1Amt9.OutputFormat = "#,##0.00";
//				Paymnt2Amt9.OutputFormat = "#,##0.00";
//				Paymnt3Amt9.OutputFormat = "#,##0.00";
//				Paymnt4Amt9.OutputFormat = "#,##0.00";
//				Paymnt5Amt9.OutputFormat = "#,##0.00";
//				Paymnt6Amt9.OutputFormat = "#,##0.00";
//				Paymnt7Amt9.OutputFormat = "#,##0.00";
//				Paymnt8Amt9.OutputFormat = "#,##0.00";
//				Paymnt9Amt9.OutputFormat = "#,##0.00";
//				Paymnt10Amt9.OutputFormat = "#,##0.00";
//				Paymnt11Amt9.OutputFormat = "#,##0.00";
//				Paymnt12Amt9.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt9.OutputFormat = "#,##0.00";
//				Paymnt13Amt9.OutputFormat = "#,##0.00";
//				Paymnt14Amt9.OutputFormat = "#,##0.00";
//				Paymnt15Amt9.OutputFormat = "#,##0.00";
//				Paymnt16Amt9.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt9.OutputFormat = "#,##0.00";
//				Paymnt17Amt9.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt9.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType9.Text == "4")
//			{
//				Paymnt1Amt9.OutputFormat = "###0.00";
//				Paymnt2Amt9.OutputFormat = "###0.00";
//				Paymnt3Amt9.OutputFormat = "###0.00";
//				Paymnt4Amt9.OutputFormat = "###0.00";
//				Paymnt5Amt9.OutputFormat = "###0.00";
//				Paymnt6Amt9.OutputFormat = "###0.00";
//				Paymnt7Amt9.OutputFormat = "###0.00";
//				Paymnt8Amt9.OutputFormat = "###0.00";
//				Paymnt9Amt9.OutputFormat = "###0.00";
//				Paymnt10Amt9.OutputFormat = "###0.00";
//				Paymnt11Amt9.OutputFormat = "###0.00";
//				Paymnt12Amt9.OutputFormat = "###0.00";
//				PaymntTotal1Amt9.OutputFormat = "###0.00";
//				Paymnt13Amt9.OutputFormat = "###0.00";
//				Paymnt14Amt9.OutputFormat = "###0.00";
//				Paymnt15Amt9.OutputFormat = "###0.00";
//				Paymnt16Amt9.OutputFormat = "###0.00";
//				PaymntTotal2Amt9.OutputFormat = "###0.00";
//				Paymnt17Amt9.OutputFormat = "###0.00";
//				PaymntTotal3Amt9.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt9.OutputFormat = "#,##0";
//				Paymnt2Amt9.OutputFormat = "#,##0";
//				Paymnt3Amt9.OutputFormat = "#,##0";
//				Paymnt4Amt9.OutputFormat = "#,##0";
//				Paymnt5Amt9.OutputFormat = "#,##0";
//				Paymnt6Amt9.OutputFormat = "#,##0";
//				Paymnt7Amt9.OutputFormat = "#,##0";
//				Paymnt8Amt9.OutputFormat = "#,##0";
//				Paymnt9Amt9.OutputFormat = "#,##0";
//				Paymnt10Amt9.OutputFormat = "#,##0";
//				Paymnt11Amt9.OutputFormat = "#,##0";
//				Paymnt12Amt9.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//PaymntTotal1Amt9.OutputFormat = "###0";
//				PaymntTotal1Amt9.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Paymnt13Amt9.OutputFormat = "#,##0";
//				Paymnt14Amt9.OutputFormat = "#,##0";
//				Paymnt15Amt9.OutputFormat = "#,##0";
//				Paymnt16Amt9.OutputFormat = "#,##0";
//				PaymntTotal2Amt9.OutputFormat = "#,##0";
//				Paymnt17Amt9.OutputFormat = "#,##0";
//				PaymntTotal3Amt9.OutputFormat = "#,##0";
//			}
//
//			if(PaymntDispType10.Text == "2")
//			{
//				Paymnt1Amt10.OutputFormat = "###0";
//				Paymnt2Amt10.OutputFormat = "###0";
//				Paymnt3Amt10.OutputFormat = "###0";
//				Paymnt4Amt10.OutputFormat = "###0";
//				Paymnt5Amt10.OutputFormat = "###0";
//				Paymnt6Amt10.OutputFormat = "###0";
//				Paymnt7Amt10.OutputFormat = "###0";
//				Paymnt8Amt10.OutputFormat = "###0";
//				Paymnt9Amt10.OutputFormat = "###0";
//				Paymnt10Amt10.OutputFormat = "###0";
//				Paymnt11Amt10.OutputFormat = "###0";
//				Paymnt12Amt10.OutputFormat = "###0";
//				PaymntTotal1Amt10.OutputFormat = "###0";
//				Paymnt13Amt10.OutputFormat = "###0";
//				Paymnt14Amt10.OutputFormat = "###0";
//				Paymnt15Amt10.OutputFormat = "###0";
//				Paymnt16Amt10.OutputFormat = "###0";
//				PaymntTotal2Amt10.OutputFormat = "###0";
//				Paymnt17Amt10.OutputFormat = "###0";
//				PaymntTotal3Amt10.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType10.Text == "3")
//			{
//				Paymnt1Amt10.OutputFormat = "#,##0.00";
//				Paymnt2Amt10.OutputFormat = "#,##0.00";
//				Paymnt3Amt10.OutputFormat = "#,##0.00";
//				Paymnt4Amt10.OutputFormat = "#,##0.00";
//				Paymnt5Amt10.OutputFormat = "#,##0.00";
//				Paymnt6Amt10.OutputFormat = "#,##0.00";
//				Paymnt7Amt10.OutputFormat = "#,##0.00";
//				Paymnt8Amt10.OutputFormat = "#,##0.00";
//				Paymnt9Amt10.OutputFormat = "#,##0.00";
//				Paymnt10Amt10.OutputFormat = "#,##0.00";
//				Paymnt11Amt10.OutputFormat = "#,##0.00";
//				Paymnt12Amt10.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt10.OutputFormat = "#,##0.00";
//				Paymnt13Amt10.OutputFormat = "#,##0.00";
//				Paymnt14Amt10.OutputFormat = "#,##0.00";
//				Paymnt15Amt10.OutputFormat = "#,##0.00";
//				Paymnt16Amt10.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt10.OutputFormat = "#,##0.00";
//				Paymnt17Amt10.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt10.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType10.Text == "4")
//			{
//				Paymnt1Amt10.OutputFormat = "###0.00";
//				Paymnt2Amt10.OutputFormat = "###0.00";
//				Paymnt3Amt10.OutputFormat = "###0.00";
//				Paymnt4Amt10.OutputFormat = "###0.00";
//				Paymnt5Amt10.OutputFormat = "###0.00";
//				Paymnt6Amt10.OutputFormat = "###0.00";
//				Paymnt7Amt10.OutputFormat = "###0.00";
//				Paymnt8Amt10.OutputFormat = "###0.00";
//				Paymnt9Amt10.OutputFormat = "###0.00";
//				Paymnt10Amt10.OutputFormat = "###0.00";
//				Paymnt11Amt10.OutputFormat = "###0.00";
//				Paymnt12Amt10.OutputFormat = "###0.00";
//				PaymntTotal1Amt10.OutputFormat = "###0.00";
//				Paymnt13Amt10.OutputFormat = "###0.00";
//				Paymnt14Amt10.OutputFormat = "###0.00";
//				Paymnt15Amt10.OutputFormat = "###0.00";
//				Paymnt16Amt10.OutputFormat = "###0.00";
//				PaymntTotal2Amt10.OutputFormat = "###0.00";
//				Paymnt17Amt10.OutputFormat = "###0.00";
//				PaymntTotal3Amt10.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt10.OutputFormat = "#,##0";
//				Paymnt2Amt10.OutputFormat = "#,##0";
//				Paymnt3Amt10.OutputFormat = "#,##0";
//				Paymnt4Amt10.OutputFormat = "#,##0";
//				Paymnt5Amt10.OutputFormat = "#,##0";
//				Paymnt6Amt10.OutputFormat = "#,##0";
//				Paymnt7Amt10.OutputFormat = "#,##0";
//				Paymnt8Amt10.OutputFormat = "#,##0";
//				Paymnt9Amt10.OutputFormat = "#,##0";
//				Paymnt10Amt10.OutputFormat = "#,##0";
//				Paymnt11Amt10.OutputFormat = "#,##0";
//				Paymnt12Amt10.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//PaymntTotal1Amt10.OutputFormat = "###0";
//				PaymntTotal1Amt10.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Paymnt13Amt10.OutputFormat = "#,##0";
//				Paymnt14Amt10.OutputFormat = "#,##0";
//				Paymnt15Amt10.OutputFormat = "#,##0";
//				Paymnt16Amt10.OutputFormat = "#,##0";
//				PaymntTotal2Amt10.OutputFormat = "#,##0";
//				Paymnt17Amt10.OutputFormat = "#,##0";
//				PaymntTotal3Amt10.OutputFormat = "#,##0";
//			}
//
//			if(PaymntDispType11.Text == "2")
//			{
//				Paymnt1Amt11.OutputFormat = "###0";
//				Paymnt2Amt11.OutputFormat = "###0";
//				Paymnt3Amt11.OutputFormat = "###0";
//				Paymnt4Amt11.OutputFormat = "###0";
//				Paymnt5Amt11.OutputFormat = "###0";
//				Paymnt6Amt11.OutputFormat = "###0";
//				Paymnt7Amt11.OutputFormat = "###0";
//				Paymnt8Amt11.OutputFormat = "###0";
//				Paymnt9Amt11.OutputFormat = "###0";
//				Paymnt10Amt11.OutputFormat = "###0";
//				Paymnt11Amt11.OutputFormat = "###0";
//				Paymnt12Amt11.OutputFormat = "###0";
//				PaymntTotal1Amt11.OutputFormat = "###0";
//				Paymnt13Amt11.OutputFormat = "###0";
//				Paymnt14Amt11.OutputFormat = "###0";
//				Paymnt15Amt11.OutputFormat = "###0";
//				Paymnt16Amt11.OutputFormat = "###0";
//				PaymntTotal2Amt11.OutputFormat = "###0";
//				Paymnt17Amt11.OutputFormat = "###0";
//				PaymntTotal3Amt11.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType11.Text == "3")
//			{
//				Paymnt1Amt11.OutputFormat = "#,##0.00";
//				Paymnt2Amt11.OutputFormat = "#,##0.00";
//				Paymnt3Amt11.OutputFormat = "#,##0.00";
//				Paymnt4Amt11.OutputFormat = "#,##0.00";
//				Paymnt5Amt11.OutputFormat = "#,##0.00";
//				Paymnt6Amt11.OutputFormat = "#,##0.00";
//				Paymnt7Amt11.OutputFormat = "#,##0.00";
//				Paymnt8Amt11.OutputFormat = "#,##0.00";
//				Paymnt9Amt11.OutputFormat = "#,##0.00";
//				Paymnt10Amt11.OutputFormat = "#,##0.00";
//				Paymnt11Amt11.OutputFormat = "#,##0.00";
//				Paymnt12Amt11.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt11.OutputFormat = "#,##0.00";
//				Paymnt13Amt11.OutputFormat = "#,##0.00";
//				Paymnt14Amt11.OutputFormat = "#,##0.00";
//				Paymnt15Amt11.OutputFormat = "#,##0.00";
//				Paymnt16Amt11.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt11.OutputFormat = "#,##0.00";
//				Paymnt17Amt11.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt11.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType11.Text == "4")
//			{
//				Paymnt1Amt11.OutputFormat = "###0.00";
//				Paymnt2Amt11.OutputFormat = "###0.00";
//				Paymnt3Amt11.OutputFormat = "###0.00";
//				Paymnt4Amt11.OutputFormat = "###0.00";
//				Paymnt5Amt11.OutputFormat = "###0.00";
//				Paymnt6Amt11.OutputFormat = "###0.00";
//				Paymnt7Amt11.OutputFormat = "###0.00";
//				Paymnt8Amt11.OutputFormat = "###0.00";
//				Paymnt9Amt11.OutputFormat = "###0.00";
//				Paymnt10Amt11.OutputFormat = "###0.00";
//				Paymnt11Amt11.OutputFormat = "###0.00";
//				Paymnt12Amt11.OutputFormat = "###0.00";
//				PaymntTotal1Amt11.OutputFormat = "###0.00";
//				Paymnt13Amt11.OutputFormat = "###0.00";
//				Paymnt14Amt11.OutputFormat = "###0.00";
//				Paymnt15Amt11.OutputFormat = "###0.00";
//				Paymnt16Amt11.OutputFormat = "###0.00";
//				PaymntTotal2Amt11.OutputFormat = "###0.00";
//				Paymnt17Amt11.OutputFormat = "###0.00";
//				PaymntTotal3Amt11.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt11.OutputFormat = "#,##0";
//				Paymnt2Amt11.OutputFormat = "#,##0";
//				Paymnt3Amt11.OutputFormat = "#,##0";
//				Paymnt4Amt11.OutputFormat = "#,##0";
//				Paymnt5Amt11.OutputFormat = "#,##0";
//				Paymnt6Amt11.OutputFormat = "#,##0";
//				Paymnt7Amt11.OutputFormat = "#,##0";
//				Paymnt8Amt11.OutputFormat = "#,##0";
//				Paymnt9Amt11.OutputFormat = "#,##0";
//				Paymnt10Amt11.OutputFormat = "#,##0";
//				Paymnt11Amt11.OutputFormat = "#,##0";
//				Paymnt12Amt11.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//PaymntTotal1Amt11.OutputFormat = "###0";
//				PaymntTotal1Amt11.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Paymnt13Amt11.OutputFormat = "#,##0";
//				Paymnt14Amt11.OutputFormat = "#,##0";
//				Paymnt15Amt11.OutputFormat = "#,##0";
//				Paymnt16Amt11.OutputFormat = "#,##0";
//				PaymntTotal2Amt11.OutputFormat = "#,##0";
//				Paymnt17Amt11.OutputFormat = "#,##0";
//				PaymntTotal3Amt11.OutputFormat = "#,##0";
//			}
//
//			if(PaymntDispType12.Text == "2")
//			{
//				Paymnt1Amt12.OutputFormat = "###0";
//				Paymnt2Amt12.OutputFormat = "###0";
//				Paymnt3Amt12.OutputFormat = "###0";
//				Paymnt4Amt12.OutputFormat = "###0";
//				Paymnt5Amt12.OutputFormat = "###0";
//				Paymnt6Amt12.OutputFormat = "###0";
//				Paymnt7Amt12.OutputFormat = "###0";
//				Paymnt8Amt12.OutputFormat = "###0";
//				Paymnt9Amt12.OutputFormat = "###0";
//				Paymnt10Amt12.OutputFormat = "###0";
//				Paymnt11Amt12.OutputFormat = "###0";
//				Paymnt12Amt12.OutputFormat = "###0";
//				PaymntTotal1Amt12.OutputFormat = "###0";
//				Paymnt13Amt12.OutputFormat = "###0";
//				Paymnt14Amt12.OutputFormat = "###0";
//				Paymnt15Amt12.OutputFormat = "###0";
//				Paymnt16Amt12.OutputFormat = "###0";
//				PaymntTotal2Amt12.OutputFormat = "###0";
//				Paymnt17Amt12.OutputFormat = "###0";
//				PaymntTotal3Amt12.OutputFormat = "###0";
//				Paymnt18Amt1.OutputFormat = "###0";
//				Paymnt18Amt2.OutputFormat = "###0";
//				Paymnt18Amt3.OutputFormat = "###0";
//				Paymnt18Amt4.OutputFormat = "###0";
//				Paymnt18Amt5.OutputFormat = "###0";
//				Paymnt18Amt6.OutputFormat = "###0";
//				Paymnt18Amt7.OutputFormat = "###0";
//				Paymnt18Amt8.OutputFormat = "###0";
//				Paymnt18Amt9.OutputFormat = "###0";
//				Paymnt18Amt10.OutputFormat = "###0";
//				Paymnt18Amt11.OutputFormat = "###0";
//				Paymnt18Amt12.OutputFormat = "###0";
//				Ded18Amt1.OutputFormat = "###0";
//				Ded18Amt2.OutputFormat = "###0";
//				Ded18Amt3.OutputFormat = "###0";
//				Ded18Amt4.OutputFormat = "###0";
//				Ded18Amt5.OutputFormat = "###0";
//				Ded18Amt6.OutputFormat = "###0";
//				Ded18Amt7.OutputFormat = "###0";
//				Ded18Amt8.OutputFormat = "###0";
//				Ded18Amt9.OutputFormat = "###0";
//				Ded18Amt10.OutputFormat = "###0";
//				Ded18Amt11.OutputFormat = "###0";
//				Ded18Amt12.OutputFormat = "###0";
//				Ded18Amt13.OutputFormat = "###0";
//			}
//
//			else if(PaymntDispType12.Text == "3")
//			{
//				Paymnt1Amt12.OutputFormat = "#,##0.00";
//				Paymnt2Amt12.OutputFormat = "#,##0.00";
//				Paymnt3Amt12.OutputFormat = "#,##0.00";
//				Paymnt4Amt12.OutputFormat = "#,##0.00";
//				Paymnt5Amt12.OutputFormat = "#,##0.00";
//				Paymnt6Amt12.OutputFormat = "#,##0.00";
//				Paymnt7Amt12.OutputFormat = "#,##0.00";
//				Paymnt8Amt12.OutputFormat = "#,##0.00";
//				Paymnt9Amt12.OutputFormat = "#,##0.00";
//				Paymnt10Amt12.OutputFormat = "#,##0.00";
//				Paymnt11Amt12.OutputFormat = "#,##0.00";
//				Paymnt12Amt12.OutputFormat = "#,##0.00";
//				PaymntTotal1Amt12.OutputFormat = "#,##0.00";
//				Paymnt13Amt12.OutputFormat = "#,##0.00";
//				Paymnt14Amt12.OutputFormat = "#,##0.00";
//				Paymnt15Amt12.OutputFormat = "#,##0.00";
//				Paymnt16Amt12.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt12.OutputFormat = "#,##0.00";
//				Paymnt17Amt12.OutputFormat = "#,##0.00";
//				PaymntTotal3Amt12.OutputFormat = "#,##0.00";
//				Paymnt18Amt1.OutputFormat = "#,##0.00";
//				Paymnt18Amt2.OutputFormat = "#,##0.00";
//				Paymnt18Amt3.OutputFormat = "#,##0.00";
//				Paymnt18Amt4.OutputFormat = "#,##0.00";
//				Paymnt18Amt5.OutputFormat = "#,##0.00";
//				Paymnt18Amt6.OutputFormat = "#,##0.00";
//				Paymnt18Amt7.OutputFormat = "#,##0.00";
//				Paymnt18Amt8.OutputFormat = "#,##0.00";
//				Paymnt18Amt9.OutputFormat = "#,##0.00";
//				Paymnt18Amt10.OutputFormat = "#,##0.00";
//				Paymnt18Amt11.OutputFormat = "#,##0.00";
//				Paymnt18Amt12.OutputFormat = "#,##0.00";
//				Ded18Amt1.OutputFormat = "#,##0.00";
//				Ded18Amt2.OutputFormat = "#,##0.00";
//				Ded18Amt3.OutputFormat = "#,##0.00";
//				Ded18Amt4.OutputFormat = "#,##0.00";
//				Ded18Amt5.OutputFormat = "#,##0.00";
//				Ded18Amt6.OutputFormat = "#,##0.00";
//				Ded18Amt7.OutputFormat = "#,##0.00";
//				Ded18Amt8.OutputFormat = "#,##0.00";
//				Ded18Amt9.OutputFormat = "#,##0.00";
//				Ded18Amt10.OutputFormat = "#,##0.00";
//				Ded18Amt11.OutputFormat = "#,##0.00";
//				Ded18Amt12.OutputFormat = "#,##0.00";
//				Ded18Amt13.OutputFormat = "#,##0.00";
//			}
//
//			else if(PaymntDispType12.Text == "4")
//			{
//				Paymnt1Amt12.OutputFormat = "###0.00";
//				Paymnt2Amt12.OutputFormat = "###0.00";
//				Paymnt3Amt12.OutputFormat = "###0.00";
//				Paymnt4Amt12.OutputFormat = "###0.00";
//				Paymnt5Amt12.OutputFormat = "###0.00";
//				Paymnt6Amt12.OutputFormat = "###0.00";
//				Paymnt7Amt12.OutputFormat = "###0.00";
//				Paymnt8Amt12.OutputFormat = "###0.00";
//				Paymnt9Amt12.OutputFormat = "###0.00";
//				Paymnt10Amt12.OutputFormat = "###0.00";
//				Paymnt11Amt12.OutputFormat = "###0.00";
//				Paymnt12Amt12.OutputFormat = "###0.00";
//				PaymntTotal1Amt12.OutputFormat = "###0.00";
//				Paymnt13Amt12.OutputFormat = "###0.00";
//				Paymnt14Amt12.OutputFormat = "###0.00";
//				Paymnt15Amt12.OutputFormat = "###0.00";
//				Paymnt16Amt12.OutputFormat = "###0.00";
//				PaymntTotal2Amt12.OutputFormat = "###0.00";
//				Paymnt17Amt12.OutputFormat = "###0.00";
//				PaymntTotal3Amt12.OutputFormat = "###0.00";
//				Paymnt18Amt1.OutputFormat = "###0.00";
//				Paymnt18Amt2.OutputFormat = "###0.00";
//				Paymnt18Amt3.OutputFormat = "###0.00";
//				Paymnt18Amt4.OutputFormat = "###0.00";
//				Paymnt18Amt5.OutputFormat = "###0.00";
//				Paymnt18Amt6.OutputFormat = "###0.00";
//				Paymnt18Amt7.OutputFormat = "###0.00";
//				Paymnt18Amt8.OutputFormat = "###0.00";
//				Paymnt18Amt9.OutputFormat = "###0.00";
//				Paymnt18Amt10.OutputFormat = "###0.00";
//				Paymnt18Amt11.OutputFormat = "###0.00";
//				Paymnt18Amt12.OutputFormat = "###0.00";
//				Ded18Amt1.OutputFormat = "###0.00";
//				Ded18Amt2.OutputFormat = "###0.00";
//				Ded18Amt3.OutputFormat = "###0.00";
//				Ded18Amt4.OutputFormat = "###0.00";
//				Ded18Amt5.OutputFormat = "###0.00";
//				Ded18Amt6.OutputFormat = "###0.00";
//				Ded18Amt7.OutputFormat = "###0.00";
//				Ded18Amt8.OutputFormat = "###0.00";
//				Ded18Amt9.OutputFormat = "###0.00";
//				Ded18Amt10.OutputFormat = "###0.00";
//				Ded18Amt11.OutputFormat = "###0.00";
//				Ded18Amt12.OutputFormat = "###0.00";
//				Ded18Amt13.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Paymnt1Amt12.OutputFormat = "#,##0";
//				Paymnt2Amt12.OutputFormat = "#,##0";
//				Paymnt3Amt12.OutputFormat = "#,##0";
//				Paymnt4Amt12.OutputFormat = "#,##0";
//				Paymnt5Amt12.OutputFormat = "#,##0";
//				Paymnt6Amt12.OutputFormat = "#,##0";
//				Paymnt7Amt12.OutputFormat = "#,##0";
//				Paymnt8Amt12.OutputFormat = "#,##0";
//				Paymnt9Amt12.OutputFormat = "#,##0";
//				Paymnt10Amt12.OutputFormat = "#,##0";
//				Paymnt11Amt12.OutputFormat = "#,##0";
//				Paymnt12Amt12.OutputFormat = "#,##0";
//				PaymntTotal1Amt12.OutputFormat = "###0";
//				Paymnt13Amt12.OutputFormat = "#,##0";
//				Paymnt14Amt12.OutputFormat = "#,##0";
//				Paymnt15Amt12.OutputFormat = "#,##0";
//				Paymnt16Amt12.OutputFormat = "#,##0";
//				PaymntTotal2Amt12.OutputFormat = "#,##0";
//				Paymnt17Amt12.OutputFormat = "#,##0";
//				PaymntTotal3Amt12.OutputFormat = "#,##0";
//				Paymnt18Amt1.OutputFormat = "#,##0";
//				Paymnt18Amt2.OutputFormat = "#,##0";
//				Paymnt18Amt3.OutputFormat = "#,##0";
//				Paymnt18Amt4.OutputFormat = "#,##0";
//				Paymnt18Amt5.OutputFormat = "#,##0";
//				Paymnt18Amt6.OutputFormat = "#,##0";
//				Paymnt18Amt7.OutputFormat = "#,##0";
//				Paymnt18Amt8.OutputFormat = "#,##0";
//				Paymnt18Amt9.OutputFormat = "#,##0";
//				Paymnt18Amt10.OutputFormat = "#,##0";
//				Paymnt18Amt11.OutputFormat = "#,##0";
//				Paymnt18Amt12.OutputFormat = "#,##0";
//				Ded18Amt1.OutputFormat = "#,##0";
//				Ded18Amt2.OutputFormat = "#,##0";
//				Ded18Amt3.OutputFormat = "#,##0";
//				Ded18Amt4.OutputFormat = "#,##0";
//				Ded18Amt5.OutputFormat = "#,##0";
//				Ded18Amt6.OutputFormat = "#,##0";
//				Ded18Amt7.OutputFormat = "#,##0";
//				Ded18Amt8.OutputFormat = "#,##0";
//				Ded18Amt9.OutputFormat = "#,##0";
//				Ded18Amt10.OutputFormat = "#,##0";
//				Ded18Amt11.OutputFormat = "#,##0";
//				Ded18Amt12.OutputFormat = "#,##0";
//				Ded18Amt13.OutputFormat = "#,##0";
//			}

			DataRow[] dr = ((System.Data.DataView)DataSource).Table.Select("[EMP_CODE] = '" + EmpCode.Text.Trim() + "'", "[EMP_CODE]");
			string paymntDispType12 = dr[0]["PAYMNT_DISP_TYPE12"].ToString();
			if (paymntDispType12 == "2")
			{
				Paymnt18Amt1.OutputFormat = "###0";
				Paymnt18Amt2.OutputFormat = "###0";
				Paymnt18Amt3.OutputFormat = "###0";
				Paymnt18Amt4.OutputFormat = "###0";
				Paymnt18Amt5.OutputFormat = "###0";
				Paymnt18Amt6.OutputFormat = "###0";
				Ded18Amt1.OutputFormat = "###0";
				Ded18Amt2.OutputFormat = "###0";
				Ded18Amt3.OutputFormat = "###0";
				Ded18Amt4.OutputFormat = "###0";
				Ded18Amt5.OutputFormat = "###0";
				Ded18Amt6.OutputFormat = "###0";
			}

			else if (paymntDispType12 == "3")
			{
				Paymnt18Amt1.OutputFormat = "#,##0.00";
				Paymnt18Amt2.OutputFormat = "#,##0.00";
				Paymnt18Amt3.OutputFormat = "#,##0.00";
				Paymnt18Amt4.OutputFormat = "#,##0.00";
				Paymnt18Amt5.OutputFormat = "#,##0.00";
				Paymnt18Amt6.OutputFormat = "#,##0.00";
				Ded18Amt1.OutputFormat = "#,##0.00";
				Ded18Amt2.OutputFormat = "#,##0.00";
				Ded18Amt3.OutputFormat = "#,##0.00";
				Ded18Amt4.OutputFormat = "#,##0.00";
				Ded18Amt5.OutputFormat = "#,##0.00";
				Ded18Amt6.OutputFormat = "#,##0.00";
			}

			else if (paymntDispType12 == "4")
			{
				Paymnt18Amt1.OutputFormat = "###0.00";
				Paymnt18Amt2.OutputFormat = "###0.00";
				Paymnt18Amt3.OutputFormat = "###0.00";
				Paymnt18Amt4.OutputFormat = "###0.00";
				Paymnt18Amt5.OutputFormat = "###0.00";
				Paymnt18Amt6.OutputFormat = "###0.00";
				Ded18Amt1.OutputFormat = "###0.00";
				Ded18Amt2.OutputFormat = "###0.00";
				Ded18Amt3.OutputFormat = "###0.00";
				Ded18Amt4.OutputFormat = "###0.00";
				Ded18Amt5.OutputFormat = "###0.00";
				Ded18Amt6.OutputFormat = "###0.00";
			}

			else
			{
				Paymnt18Amt1.OutputFormat = "#,##0";
				Paymnt18Amt2.OutputFormat = "#,##0";
				Paymnt18Amt3.OutputFormat = "#,##0";
				Paymnt18Amt4.OutputFormat = "#,##0";
				Paymnt18Amt5.OutputFormat = "#,##0";
				Paymnt18Amt6.OutputFormat = "#,##0";
				Ded18Amt1.OutputFormat = "#,##0";
				Ded18Amt2.OutputFormat = "#,##0";
				Ded18Amt3.OutputFormat = "#,##0";
				Ded18Amt4.OutputFormat = "#,##0";
				Ded18Amt5.OutputFormat = "#,##0";
				Ded18Amt6.OutputFormat = "#,##0";
			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			if (PaymntBnsDispType1.Text == "2")
			{
				Paymnt13Amt1.OutputFormat = "###0";
				Paymnt14Amt1.OutputFormat = "###0";
				Paymnt15Amt1.OutputFormat = "###0";
				Paymnt16Amt1.OutputFormat = "###0";
				PaymntTotal2Amt1.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType1.Text == "3")
			{
				Paymnt13Amt1.OutputFormat = "#,##0.00";
				Paymnt14Amt1.OutputFormat = "#,##0.00";
				Paymnt15Amt1.OutputFormat = "#,##0.00";
				Paymnt16Amt1.OutputFormat = "#,##0.00";
				PaymntTotal2Amt1.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType1.Text == "4")
			{
				Paymnt13Amt1.OutputFormat = "###0.00";
				Paymnt14Amt1.OutputFormat = "###0.00";
				Paymnt15Amt1.OutputFormat = "###0.00";
				Paymnt16Amt1.OutputFormat = "###0.00";
				PaymntTotal2Amt1.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt1.OutputFormat = "#,##0";
				Paymnt14Amt1.OutputFormat = "#,##0";
				Paymnt15Amt1.OutputFormat = "#,##0";
				Paymnt16Amt1.OutputFormat = "#,##0";
				PaymntTotal2Amt1.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType2.Text == "2")
			{
				Paymnt13Amt2.OutputFormat = "###0";
				Paymnt14Amt2.OutputFormat = "###0";
				Paymnt15Amt2.OutputFormat = "###0";
				Paymnt16Amt2.OutputFormat = "###0";
				PaymntTotal2Amt2.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType2.Text == "3")
			{
				Paymnt13Amt2.OutputFormat = "#,##0.00";
				Paymnt14Amt2.OutputFormat = "#,##0.00";
				Paymnt15Amt2.OutputFormat = "#,##0.00";
				Paymnt16Amt2.OutputFormat = "#,##0.00";
				PaymntTotal2Amt2.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType2.Text == "4")
			{
				Paymnt13Amt2.OutputFormat = "###0.00";
				Paymnt14Amt2.OutputFormat = "###0.00";
				Paymnt15Amt2.OutputFormat = "###0.00";
				Paymnt16Amt2.OutputFormat = "###0.00";
				PaymntTotal2Amt2.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt2.OutputFormat = "#,##0";
				Paymnt14Amt2.OutputFormat = "#,##0";
				Paymnt15Amt2.OutputFormat = "#,##0";
				Paymnt16Amt2.OutputFormat = "#,##0";
				PaymntTotal2Amt2.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType3.Text == "2")
			{
				Paymnt13Amt3.OutputFormat = "###0";
				Paymnt14Amt3.OutputFormat = "###0";
				Paymnt15Amt3.OutputFormat = "###0";
				Paymnt16Amt3.OutputFormat = "###0";
				PaymntTotal2Amt3.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType3.Text == "3")
			{
				Paymnt13Amt3.OutputFormat = "#,##0.00";
				Paymnt14Amt3.OutputFormat = "#,##0.00";
				Paymnt15Amt3.OutputFormat = "#,##0.00";
				Paymnt16Amt3.OutputFormat = "#,##0.00";
				PaymntTotal2Amt3.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType3.Text == "4")
			{
				Paymnt13Amt3.OutputFormat = "###0.00";
				Paymnt14Amt3.OutputFormat = "###0.00";
				Paymnt15Amt3.OutputFormat = "###0.00";
				Paymnt16Amt3.OutputFormat = "###0.00";
				PaymntTotal2Amt3.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt3.OutputFormat = "#,##0";
				Paymnt14Amt3.OutputFormat = "#,##0";
				Paymnt15Amt3.OutputFormat = "#,##0";
				Paymnt16Amt3.OutputFormat = "#,##0";
				PaymntTotal2Amt3.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType4.Text == "2")
			{
				Paymnt13Amt4.OutputFormat = "###0";
				Paymnt14Amt4.OutputFormat = "###0";
				Paymnt15Amt4.OutputFormat = "###0";
				Paymnt16Amt4.OutputFormat = "###0";
				PaymntTotal2Amt4.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType4.Text == "3")
			{
				Paymnt13Amt4.OutputFormat = "#,##0.00";
				Paymnt14Amt4.OutputFormat = "#,##0.00";
				Paymnt15Amt4.OutputFormat = "#,##0.00";
				Paymnt16Amt4.OutputFormat = "#,##0.00";
				PaymntTotal2Amt4.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType4.Text == "4")
			{
				Paymnt13Amt4.OutputFormat = "###0.00";
				Paymnt14Amt4.OutputFormat = "###0.00";
				Paymnt15Amt4.OutputFormat = "###0.00";
				Paymnt16Amt4.OutputFormat = "###0.00";
				PaymntTotal2Amt4.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt4.OutputFormat = "#,##0";
				Paymnt14Amt4.OutputFormat = "#,##0";
				Paymnt15Amt4.OutputFormat = "#,##0";
				Paymnt16Amt4.OutputFormat = "#,##0";
				PaymntTotal2Amt4.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType5.Text == "2")
			{
				Paymnt13Amt5.OutputFormat = "###0";
				Paymnt14Amt5.OutputFormat = "###0";
				Paymnt15Amt5.OutputFormat = "###0";
				Paymnt16Amt5.OutputFormat = "###0";
				PaymntTotal2Amt5.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType5.Text == "3")
			{
				Paymnt13Amt5.OutputFormat = "#,##0.00";
				Paymnt14Amt5.OutputFormat = "#,##0.00";
				Paymnt15Amt5.OutputFormat = "#,##0.00";
				Paymnt16Amt5.OutputFormat = "#,##0.00";
				PaymntTotal2Amt5.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType5.Text == "4")
			{
				Paymnt13Amt5.OutputFormat = "###0.00";
				Paymnt14Amt5.OutputFormat = "###0.00";
				Paymnt15Amt5.OutputFormat = "###0.00";
				Paymnt16Amt5.OutputFormat = "###0.00";
				PaymntTotal2Amt5.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt5.OutputFormat = "#,##0";
				Paymnt14Amt5.OutputFormat = "#,##0";
				Paymnt15Amt5.OutputFormat = "#,##0";
				Paymnt16Amt5.OutputFormat = "#,##0";
				PaymntTotal2Amt5.OutputFormat = "#,##0";
			}

			if (PaymntBnsDispType6.Text == "2")
			{
				Paymnt13Amt6.OutputFormat = "###0";
				Paymnt14Amt6.OutputFormat = "###0";
				Paymnt15Amt6.OutputFormat = "###0";
				Paymnt16Amt6.OutputFormat = "###0";
				PaymntTotal2Amt6.OutputFormat = "###0";
			}
			else if (PaymntBnsDispType6.Text == "3")
			{
				Paymnt13Amt6.OutputFormat = "#,##0.00";
				Paymnt14Amt6.OutputFormat = "#,##0.00";
				Paymnt15Amt6.OutputFormat = "#,##0.00";
				Paymnt16Amt6.OutputFormat = "#,##0.00";
				PaymntTotal2Amt6.OutputFormat = "#,##0.00";
			}
			else if (PaymntBnsDispType6.Text == "4")
			{
				Paymnt13Amt6.OutputFormat = "###0.00";
				Paymnt14Amt6.OutputFormat = "###0.00";
				Paymnt15Amt6.OutputFormat = "###0.00";
				Paymnt16Amt6.OutputFormat = "###0.00";
				PaymntTotal2Amt6.OutputFormat = "###0.00";
			}
			else
			{
				Paymnt13Amt6.OutputFormat = "#,##0";
				Paymnt14Amt6.OutputFormat = "#,##0";
				Paymnt15Amt6.OutputFormat = "#,##0";
				Paymnt16Amt6.OutputFormat = "#,##0";
				PaymntTotal2Amt6.OutputFormat = "#,##0";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if(PaymntBnsDispType7.Text == "2")
//			{
//				Paymnt13Amt7.OutputFormat = "###0";
//				Paymnt14Amt7.OutputFormat = "###0";
//				Paymnt15Amt7.OutputFormat = "###0";
//				Paymnt16Amt7.OutputFormat = "###0";
//				PaymntTotal2Amt7.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType7.Text == "3")
//			{
//				Paymnt13Amt7.OutputFormat = "#,##0.00";
//				Paymnt14Amt7.OutputFormat = "#,##0.00";
//				Paymnt15Amt7.OutputFormat = "#,##0.00";
//				Paymnt16Amt7.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt7.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType7.Text == "4")
//			{
//				Paymnt13Amt7.OutputFormat = "###0.00";
//				Paymnt14Amt7.OutputFormat = "###0.00";
//				Paymnt15Amt7.OutputFormat = "###0.00";
//				Paymnt16Amt7.OutputFormat = "###0.00";
//				PaymntTotal2Amt7.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt7.OutputFormat = "#,##0";
//				Paymnt14Amt7.OutputFormat = "#,##0";
//				Paymnt15Amt7.OutputFormat = "#,##0";
//				Paymnt16Amt7.OutputFormat = "#,##0";
//				PaymntTotal2Amt7.OutputFormat = "#,##0";
//			}
//	
//			if(PaymntBnsDispType8.Text == "2")
//			{
//				Paymnt13Amt8.OutputFormat = "###0";
//				Paymnt14Amt8.OutputFormat = "###0";
//				Paymnt15Amt8.OutputFormat = "###0";
//				Paymnt16Amt8.OutputFormat = "###0";
//				PaymntTotal2Amt8.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType8.Text == "3")
//			{
//				Paymnt13Amt8.OutputFormat = "#,##0.00";
//				Paymnt14Amt8.OutputFormat = "#,##0.00";
//				Paymnt15Amt8.OutputFormat = "#,##0.00";
//				Paymnt16Amt8.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt8.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType8.Text == "4")
//			{
//				Paymnt13Amt8.OutputFormat = "###0.00";
//				Paymnt14Amt8.OutputFormat = "###0.00";
//				Paymnt15Amt8.OutputFormat = "###0.00";
//				Paymnt16Amt8.OutputFormat = "###0.00";
//				PaymntTotal2Amt8.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt8.OutputFormat = "#,##0";
//				Paymnt14Amt8.OutputFormat = "#,##0";
//				Paymnt15Amt8.OutputFormat = "#,##0";
//				Paymnt16Amt8.OutputFormat = "#,##0";
//				PaymntTotal2Amt8.OutputFormat = "#,##0";
//			}
//
//			if(PaymntBnsDispType9.Text == "2")
//			{
//				Paymnt13Amt9.OutputFormat = "###0";
//				Paymnt14Amt9.OutputFormat = "###0";
//				Paymnt15Amt9.OutputFormat = "###0";
//				Paymnt16Amt9.OutputFormat = "###0";
//				PaymntTotal2Amt9.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType9.Text == "3")
//			{
//				Paymnt13Amt9.OutputFormat = "#,##0.00";
//				Paymnt14Amt9.OutputFormat = "#,##0.00";
//				Paymnt15Amt9.OutputFormat = "#,##0.00";
//				Paymnt16Amt9.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt9.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType9.Text == "4")
//			{
//				Paymnt13Amt9.OutputFormat = "###0.00";
//				Paymnt14Amt9.OutputFormat = "###0.00";
//				Paymnt15Amt9.OutputFormat = "###0.00";
//				Paymnt16Amt9.OutputFormat = "###0.00";
//				PaymntTotal2Amt9.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt9.OutputFormat = "#,##0";
//				Paymnt14Amt9.OutputFormat = "#,##0";
//				Paymnt15Amt9.OutputFormat = "#,##0";
//				Paymnt16Amt9.OutputFormat = "#,##0";
//				PaymntTotal2Amt9.OutputFormat = "#,##0";
//			}
//
//			if(PaymntBnsDispType10.Text == "2")
//			{
//				Paymnt13Amt10.OutputFormat = "###0";
//				Paymnt14Amt10.OutputFormat = "###0";
//				Paymnt15Amt10.OutputFormat = "###0";
//				Paymnt16Amt10.OutputFormat = "###0";
//				PaymntTotal2Amt10.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType10.Text == "3")
//			{
//				Paymnt13Amt10.OutputFormat = "#,##0.00";
//				Paymnt14Amt10.OutputFormat = "#,##0.00";
//				Paymnt15Amt10.OutputFormat = "#,##0.00";
//				Paymnt16Amt10.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt10.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType10.Text == "4")
//			{
//				Paymnt13Amt10.OutputFormat = "###0.00";
//				Paymnt14Amt10.OutputFormat = "###0.00";
//				Paymnt15Amt10.OutputFormat = "###0.00";
//				Paymnt16Amt10.OutputFormat = "###0.00";
//				PaymntTotal2Amt10.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt10.OutputFormat = "#,##0";
//				Paymnt14Amt10.OutputFormat = "#,##0";
//				Paymnt15Amt10.OutputFormat = "#,##0";
//				Paymnt16Amt10.OutputFormat = "#,##0";
//				PaymntTotal2Amt10.OutputFormat = "#,##0";
//			}
//
//			if(PaymntBnsDispType11.Text == "2")
//			{
//				Paymnt13Amt11.OutputFormat = "###0";
//				Paymnt14Amt11.OutputFormat = "###0";
//				Paymnt15Amt11.OutputFormat = "###0";
//				Paymnt16Amt11.OutputFormat = "###0";
//				PaymntTotal2Amt11.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType11.Text == "3")
//			{
//				Paymnt13Amt11.OutputFormat = "#,##0.00";
//				Paymnt14Amt11.OutputFormat = "#,##0.00";
//				Paymnt15Amt11.OutputFormat = "#,##0.00";
//				Paymnt16Amt11.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt11.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType11.Text == "4")
//			{
//				Paymnt13Amt11.OutputFormat = "###0.00";
//				Paymnt14Amt11.OutputFormat = "###0.00";
//				Paymnt15Amt11.OutputFormat = "###0.00";
//				Paymnt16Amt11.OutputFormat = "###0.00";
//				PaymntTotal2Amt11.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt11.OutputFormat = "#,##0";
//				Paymnt14Amt11.OutputFormat = "#,##0";
//				Paymnt15Amt11.OutputFormat = "#,##0";
//				Paymnt16Amt11.OutputFormat = "#,##0";
//				PaymntTotal2Amt11.OutputFormat = "#,##0";
//			}
//
//			if(PaymntBnsDispType12.Text == "2")
//			{
//				Paymnt13Amt12.OutputFormat = "###0";
//				Paymnt14Amt12.OutputFormat = "###0";
//				Paymnt15Amt12.OutputFormat = "###0";
//				Paymnt16Amt12.OutputFormat = "###0";
//				PaymntTotal2Amt12.OutputFormat = "###0";
//			}
//			else if(PaymntBnsDispType12.Text == "3")
//			{
//				Paymnt13Amt12.OutputFormat = "#,##0.00";
//				Paymnt14Amt12.OutputFormat = "#,##0.00";
//				Paymnt15Amt12.OutputFormat = "#,##0.00";
//				Paymnt16Amt12.OutputFormat = "#,##0.00";
//				PaymntTotal2Amt12.OutputFormat = "#,##0.00";
//			}
//			else if(PaymntBnsDispType12.Text == "4")
//			{
//				Paymnt13Amt12.OutputFormat = "###0.00";
//				Paymnt14Amt12.OutputFormat = "###0.00";
//				Paymnt15Amt12.OutputFormat = "###0.00";
//				Paymnt16Amt12.OutputFormat = "###0.00";
//				PaymntTotal2Amt12.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Paymnt13Amt12.OutputFormat = "#,##0";
//				Paymnt14Amt12.OutputFormat = "#,##0";
//				Paymnt15Amt12.OutputFormat = "#,##0";
//				Paymnt16Amt12.OutputFormat = "#,##0";
//				PaymntTotal2Amt12.OutputFormat = "#,##0";
//			}
// 管理番号 K24565 To
// 管理番号 B15940 To

			if (DedDispType1.Text == "2")
			{
				Ded1Amt1.OutputFormat = "###0";
				Ded2Amt1.OutputFormat = "###0";
				Ded3Amt1.OutputFormat = "###0";
				Ded4Amt1.OutputFormat = "###0";
				Ded5Amt1.OutputFormat = "###0";
				Ded6Amt1.OutputFormat = "###0";
				Ded7Amt1.OutputFormat = "###0";
				Ded8Amt1.OutputFormat = "###0";
				Ded9Amt1.OutputFormat = "###0";
				Ded10Amt1.OutputFormat = "###0";
				Ded11Amt1.OutputFormat = "###0";
				Ded12Amt1.OutputFormat = "###0";
				DedTotal1Amt1.OutputFormat = "###0";
				Ded13Amt1.OutputFormat = "###0";
				Ded14Amt1.OutputFormat = "###0";
				Ded15Amt1.OutputFormat = "###0";
				Ded16Amt1.OutputFormat = "###0";
				DedTotal2Amt1.OutputFormat = "###0";
				Ded17Amt1.OutputFormat = "###0";
				DedTotal3Amt1.OutputFormat = "###0";
			}

			else if (DedDispType1.Text == "3")
			{
				Ded1Amt1.OutputFormat = "#,##0.00";
				Ded2Amt1.OutputFormat = "#,##0.00";
				Ded3Amt1.OutputFormat = "#,##0.00";
				Ded4Amt1.OutputFormat = "#,##0.00";
				Ded5Amt1.OutputFormat = "#,##0.00";
				Ded6Amt1.OutputFormat = "#,##0.00";
				Ded7Amt1.OutputFormat = "#,##0.00";
				Ded8Amt1.OutputFormat = "#,##0.00";
				Ded9Amt1.OutputFormat = "#,##0.00";
				Ded10Amt1.OutputFormat = "#,##0.00";
				Ded11Amt1.OutputFormat = "#,##0.00";
				Ded12Amt1.OutputFormat = "#,##0.00";
				DedTotal1Amt1.OutputFormat = "#,##0.00";
				Ded13Amt1.OutputFormat = "#,##0.00";
				Ded14Amt1.OutputFormat = "#,##0.00";
				Ded15Amt1.OutputFormat = "#,##0.00";
				Ded16Amt1.OutputFormat = "#,##0.00";
				DedTotal2Amt1.OutputFormat = "#,##0.00";
				Ded17Amt1.OutputFormat = "#,##0.00";
				DedTotal3Amt1.OutputFormat = "#,##0.00";
			}

			else if (DedDispType1.Text == "4")
			{
				Ded1Amt1.OutputFormat = "###0.00";
				Ded2Amt1.OutputFormat = "###0.00";
				Ded3Amt1.OutputFormat = "###0.00";
				Ded4Amt1.OutputFormat = "###0.00";
				Ded5Amt1.OutputFormat = "###0.00";
				Ded6Amt1.OutputFormat = "###0.00";
				Ded7Amt1.OutputFormat = "###0.00";
				Ded8Amt1.OutputFormat = "###0.00";
				Ded9Amt1.OutputFormat = "###0.00";
				Ded10Amt1.OutputFormat = "###0.00";
				Ded11Amt1.OutputFormat = "###0.00";
				Ded12Amt1.OutputFormat = "###0.00";
				DedTotal1Amt1.OutputFormat = "###0.00";
				Ded13Amt1.OutputFormat = "###0.00";
				Ded14Amt1.OutputFormat = "###0.00";
				Ded15Amt1.OutputFormat = "###0.00";
				Ded16Amt1.OutputFormat = "###0.00";
				DedTotal2Amt1.OutputFormat = "###0.00";
				Ded17Amt1.OutputFormat = "###0.00";
				DedTotal3Amt1.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt1.OutputFormat = "#,##0";
				Ded2Amt1.OutputFormat = "#,##0";
				Ded3Amt1.OutputFormat = "#,##0";
				Ded4Amt1.OutputFormat = "#,##0";
				Ded5Amt1.OutputFormat = "#,##0";
				Ded6Amt1.OutputFormat = "#,##0";
				Ded7Amt1.OutputFormat = "#,##0";
				Ded8Amt1.OutputFormat = "#,##0";
				Ded9Amt1.OutputFormat = "#,##0";
				Ded10Amt1.OutputFormat = "#,##0";
				Ded11Amt1.OutputFormat = "#,##0";
				Ded12Amt1.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt1.OutputFormat = "###0";
				DedTotal1Amt1.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt1.OutputFormat = "#,##0";
				Ded14Amt1.OutputFormat = "#,##0";
				Ded15Amt1.OutputFormat = "#,##0";
				Ded16Amt1.OutputFormat = "#,##0";
				DedTotal2Amt1.OutputFormat = "#,##0";
				Ded17Amt1.OutputFormat = "#,##0";
				DedTotal3Amt1.OutputFormat = "#,##0";
			}

			if (DedDispType2.Text == "2")
			{
				Ded1Amt2.OutputFormat = "###0";
				Ded2Amt2.OutputFormat = "###0";
				Ded3Amt2.OutputFormat = "###0";
				Ded4Amt2.OutputFormat = "###0";
				Ded5Amt2.OutputFormat = "###0";
				Ded6Amt2.OutputFormat = "###0";
				Ded7Amt2.OutputFormat = "###0";
				Ded8Amt2.OutputFormat = "###0";
				Ded9Amt2.OutputFormat = "###0";
				Ded10Amt2.OutputFormat = "###0";
				Ded11Amt2.OutputFormat = "###0";
				Ded12Amt2.OutputFormat = "###0";
				DedTotal1Amt2.OutputFormat = "###0";
				Ded13Amt2.OutputFormat = "###0";
				Ded14Amt2.OutputFormat = "###0";
				Ded15Amt2.OutputFormat = "###0";
				Ded16Amt2.OutputFormat = "###0";
				DedTotal2Amt2.OutputFormat = "###0";
				Ded17Amt2.OutputFormat = "###0";
				DedTotal3Amt2.OutputFormat = "###0";
			}

			else if (DedDispType2.Text == "3")
			{
				Ded1Amt2.OutputFormat = "#,##0.00";
				Ded2Amt2.OutputFormat = "#,##0.00";
				Ded3Amt2.OutputFormat = "#,##0.00";
				Ded4Amt2.OutputFormat = "#,##0.00";
				Ded5Amt2.OutputFormat = "#,##0.00";
				Ded6Amt2.OutputFormat = "#,##0.00";
				Ded7Amt2.OutputFormat = "#,##0.00";
				Ded8Amt2.OutputFormat = "#,##0.00";
				Ded9Amt2.OutputFormat = "#,##0.00";
				Ded10Amt2.OutputFormat = "#,##0.00";
				Ded11Amt2.OutputFormat = "#,##0.00";
				Ded12Amt2.OutputFormat = "#,##0.00";
				DedTotal1Amt2.OutputFormat = "#,##0.00";
				Ded13Amt2.OutputFormat = "#,##0.00";
				Ded14Amt2.OutputFormat = "#,##0.00";
				Ded15Amt2.OutputFormat = "#,##0.00";
				Ded16Amt2.OutputFormat = "#,##0.00";
				DedTotal2Amt2.OutputFormat = "#,##0.00";
				Ded17Amt2.OutputFormat = "#,##0.00";
				DedTotal3Amt2.OutputFormat = "#,##0.00";
			}

			else if (DedDispType2.Text == "4")
			{
				Ded1Amt2.OutputFormat = "###0.00";
				Ded2Amt2.OutputFormat = "###0.00";
				Ded3Amt2.OutputFormat = "###0.00";
				Ded4Amt2.OutputFormat = "###0.00";
				Ded5Amt2.OutputFormat = "###0.00";
				Ded6Amt2.OutputFormat = "###0.00";
				Ded7Amt2.OutputFormat = "###0.00";
				Ded8Amt2.OutputFormat = "###0.00";
				Ded9Amt2.OutputFormat = "###0.00";
				Ded10Amt2.OutputFormat = "###0.00";
				Ded11Amt2.OutputFormat = "###0.00";
				Ded12Amt2.OutputFormat = "###0.00";
				DedTotal1Amt2.OutputFormat = "###0.00";
				Ded13Amt2.OutputFormat = "###0.00";
				Ded14Amt2.OutputFormat = "###0.00";
				Ded15Amt2.OutputFormat = "###0.00";
				Ded16Amt2.OutputFormat = "###0.00";
				DedTotal2Amt2.OutputFormat = "###0.00";
				Ded17Amt2.OutputFormat = "###0.00";
				DedTotal3Amt2.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt2.OutputFormat = "#,##0";
				Ded2Amt2.OutputFormat = "#,##0";
				Ded3Amt2.OutputFormat = "#,##0";
				Ded4Amt2.OutputFormat = "#,##0";
				Ded5Amt2.OutputFormat = "#,##0";
				Ded6Amt2.OutputFormat = "#,##0";
				Ded7Amt2.OutputFormat = "#,##0";
				Ded8Amt2.OutputFormat = "#,##0";
				Ded9Amt2.OutputFormat = "#,##0";
				Ded10Amt2.OutputFormat = "#,##0";
				Ded11Amt2.OutputFormat = "#,##0";
				Ded12Amt2.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt2.OutputFormat = "###0";
				DedTotal1Amt2.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt2.OutputFormat = "#,##0";
				Ded14Amt2.OutputFormat = "#,##0";
				Ded15Amt2.OutputFormat = "#,##0";
				Ded16Amt2.OutputFormat = "#,##0";
				DedTotal2Amt2.OutputFormat = "#,##0";
				Ded17Amt2.OutputFormat = "#,##0";
				DedTotal3Amt2.OutputFormat = "#,##0";
			}

			if (DedDispType3.Text == "2")
			{
				Ded1Amt3.OutputFormat = "###0";
				Ded2Amt3.OutputFormat = "###0";
				Ded3Amt3.OutputFormat = "###0";
				Ded4Amt3.OutputFormat = "###0";
				Ded5Amt3.OutputFormat = "###0";
				Ded6Amt3.OutputFormat = "###0";
				Ded7Amt3.OutputFormat = "###0";
				Ded8Amt3.OutputFormat = "###0";
				Ded9Amt3.OutputFormat = "###0";
				Ded10Amt3.OutputFormat = "###0";
				Ded11Amt3.OutputFormat = "###0";
				Ded12Amt3.OutputFormat = "###0";
			}

			if (DedDispType3.Text == "2")
			{
				Ded1Amt3.OutputFormat = "###0";
				Ded2Amt3.OutputFormat = "###0";
				Ded3Amt3.OutputFormat = "###0";
				Ded4Amt3.OutputFormat = "###0";
				Ded5Amt3.OutputFormat = "###0";
				Ded6Amt3.OutputFormat = "###0";
				Ded7Amt3.OutputFormat = "###0";
				Ded8Amt3.OutputFormat = "###0";
				Ded9Amt3.OutputFormat = "###0";
				Ded10Amt3.OutputFormat = "###0";
				Ded11Amt3.OutputFormat = "###0";
				Ded12Amt3.OutputFormat = "###0";
				DedTotal1Amt3.OutputFormat = "###0";
				Ded13Amt3.OutputFormat = "###0";
				Ded14Amt3.OutputFormat = "###0";
				Ded15Amt3.OutputFormat = "###0";
				Ded16Amt3.OutputFormat = "###0";
				DedTotal2Amt3.OutputFormat = "###0";
				Ded17Amt3.OutputFormat = "###0";
				DedTotal3Amt3.OutputFormat = "###0";
			}

			else if (DedDispType3.Text == "3")
			{
				Ded1Amt3.OutputFormat = "#,##0.00";
				Ded2Amt3.OutputFormat = "#,##0.00";
				Ded3Amt3.OutputFormat = "#,##0.00";
				Ded4Amt3.OutputFormat = "#,##0.00";
				Ded5Amt3.OutputFormat = "#,##0.00";
				Ded6Amt3.OutputFormat = "#,##0.00";
				Ded7Amt3.OutputFormat = "#,##0.00";
				Ded8Amt3.OutputFormat = "#,##0.00";
				Ded9Amt3.OutputFormat = "#,##0.00";
				Ded10Amt3.OutputFormat = "#,##0.00";
				Ded11Amt3.OutputFormat = "#,##0.00";
				Ded12Amt3.OutputFormat = "#,##0.00";
				DedTotal1Amt3.OutputFormat = "#,##0.00";
				Ded13Amt3.OutputFormat = "#,##0.00";
				Ded14Amt3.OutputFormat = "#,##0.00";
				Ded15Amt3.OutputFormat = "#,##0.00";
				Ded16Amt3.OutputFormat = "#,##0.00";
				DedTotal2Amt3.OutputFormat = "#,##0.00";
				Ded17Amt3.OutputFormat = "#,##0.00";
				DedTotal3Amt3.OutputFormat = "#,##0.00";
			}

			else if (DedDispType3.Text == "4")
			{
				Ded1Amt3.OutputFormat = "###0.00";
				Ded2Amt3.OutputFormat = "###0.00";
				Ded3Amt3.OutputFormat = "###0.00";
				Ded4Amt3.OutputFormat = "###0.00";
				Ded5Amt3.OutputFormat = "###0.00";
				Ded6Amt3.OutputFormat = "###0.00";
				Ded7Amt3.OutputFormat = "###0.00";
				Ded8Amt3.OutputFormat = "###0.00";
				Ded9Amt3.OutputFormat = "###0.00";
				Ded10Amt3.OutputFormat = "###0.00";
				Ded11Amt3.OutputFormat = "###0.00";
				Ded12Amt3.OutputFormat = "###0.00";
				DedTotal1Amt3.OutputFormat = "###0.00";
				Ded13Amt3.OutputFormat = "###0.00";
				Ded14Amt3.OutputFormat = "###0.00";
				Ded15Amt3.OutputFormat = "###0.00";
				Ded16Amt3.OutputFormat = "###0.00";
				DedTotal2Amt3.OutputFormat = "###0.00";
				Ded17Amt3.OutputFormat = "###0.00";
				DedTotal3Amt3.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt3.OutputFormat = "#,##0";
				Ded2Amt3.OutputFormat = "#,##0";
				Ded3Amt3.OutputFormat = "#,##0";
				Ded4Amt3.OutputFormat = "#,##0";
				Ded5Amt3.OutputFormat = "#,##0";
				Ded6Amt3.OutputFormat = "#,##0";
				Ded7Amt3.OutputFormat = "#,##0";
				Ded8Amt3.OutputFormat = "#,##0";
				Ded9Amt3.OutputFormat = "#,##0";
				Ded10Amt3.OutputFormat = "#,##0";
				Ded11Amt3.OutputFormat = "#,##0";
				Ded12Amt3.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt3.OutputFormat = "###0";
				DedTotal1Amt3.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt3.OutputFormat = "#,##0";
				Ded14Amt3.OutputFormat = "#,##0";
				Ded15Amt3.OutputFormat = "#,##0";
				Ded16Amt3.OutputFormat = "#,##0";
				DedTotal2Amt3.OutputFormat = "#,##0";
				Ded17Amt3.OutputFormat = "#,##0";
				DedTotal3Amt3.OutputFormat = "#,##0";
			}

			if (DedDispType4.Text == "2")
			{
				Ded1Amt4.OutputFormat = "###0";
				Ded2Amt4.OutputFormat = "###0";
				Ded3Amt4.OutputFormat = "###0";
				Ded4Amt4.OutputFormat = "###0";
				Ded5Amt4.OutputFormat = "###0";
				Ded6Amt4.OutputFormat = "###0";
				Ded7Amt4.OutputFormat = "###0";
				Ded8Amt4.OutputFormat = "###0";
				Ded9Amt4.OutputFormat = "###0";
				Ded10Amt4.OutputFormat = "###0";
				Ded11Amt4.OutputFormat = "###0";
				Ded12Amt4.OutputFormat = "###0";
				DedTotal1Amt4.OutputFormat = "###0";
				Ded13Amt4.OutputFormat = "###0";
				Ded14Amt4.OutputFormat = "###0";
				Ded15Amt4.OutputFormat = "###0";
				Ded16Amt4.OutputFormat = "###0";
				DedTotal2Amt4.OutputFormat = "###0";
				Ded17Amt4.OutputFormat = "###0";
				DedTotal3Amt4.OutputFormat = "###0";
			}

			else if (DedDispType4.Text == "3")
			{
				Ded1Amt4.OutputFormat = "#,##0.00";
				Ded2Amt4.OutputFormat = "#,##0.00";
				Ded3Amt4.OutputFormat = "#,##0.00";
				Ded4Amt4.OutputFormat = "#,##0.00";
				Ded5Amt4.OutputFormat = "#,##0.00";
				Ded6Amt4.OutputFormat = "#,##0.00";
				Ded7Amt4.OutputFormat = "#,##0.00";
				Ded8Amt4.OutputFormat = "#,##0.00";
				Ded9Amt4.OutputFormat = "#,##0.00";
				Ded10Amt4.OutputFormat = "#,##0.00";
				Ded11Amt4.OutputFormat = "#,##0.00";
				Ded12Amt4.OutputFormat = "#,##0.00";
				DedTotal1Amt4.OutputFormat = "#,##0.00";
				Ded13Amt4.OutputFormat = "#,##0.00";
				Ded14Amt4.OutputFormat = "#,##0.00";
				Ded15Amt4.OutputFormat = "#,##0.00";
				Ded16Amt4.OutputFormat = "#,##0.00";
				DedTotal2Amt4.OutputFormat = "#,##0.00";
				Ded17Amt4.OutputFormat = "#,##0.00";
				DedTotal3Amt4.OutputFormat = "#,##0.00";
			}

			else if (DedDispType4.Text == "4")
			{
				Ded1Amt4.OutputFormat = "###0.00";
				Ded2Amt4.OutputFormat = "###0.00";
				Ded3Amt4.OutputFormat = "###0.00";
				Ded4Amt4.OutputFormat = "###0.00";
				Ded5Amt4.OutputFormat = "###0.00";
				Ded6Amt4.OutputFormat = "###0.00";
				Ded7Amt4.OutputFormat = "###0.00";
				Ded8Amt4.OutputFormat = "###0.00";
				Ded9Amt4.OutputFormat = "###0.00";
				Ded10Amt4.OutputFormat = "###0.00";
				Ded11Amt4.OutputFormat = "###0.00";
				Ded12Amt4.OutputFormat = "###0.00";
				DedTotal1Amt4.OutputFormat = "###0.00";
				Ded13Amt4.OutputFormat = "###0.00";
				Ded14Amt4.OutputFormat = "###0.00";
				Ded15Amt4.OutputFormat = "###0.00";
				Ded16Amt4.OutputFormat = "###0.00";
				DedTotal2Amt4.OutputFormat = "###0.00";
				Ded17Amt4.OutputFormat = "###0.00";
				DedTotal3Amt4.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt4.OutputFormat = "#,##0";
				Ded2Amt4.OutputFormat = "#,##0";
				Ded3Amt4.OutputFormat = "#,##0";
				Ded4Amt4.OutputFormat = "#,##0";
				Ded5Amt4.OutputFormat = "#,##0";
				Ded6Amt4.OutputFormat = "#,##0";
				Ded7Amt4.OutputFormat = "#,##0";
				Ded8Amt4.OutputFormat = "#,##0";
				Ded9Amt4.OutputFormat = "#,##0";
				Ded10Amt4.OutputFormat = "#,##0";
				Ded11Amt4.OutputFormat = "#,##0";
				Ded12Amt4.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt4.OutputFormat = "###0";
				DedTotal1Amt4.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt4.OutputFormat = "#,##0";
				Ded14Amt4.OutputFormat = "#,##0";
				Ded15Amt4.OutputFormat = "#,##0";
				Ded16Amt4.OutputFormat = "#,##0";
				DedTotal2Amt4.OutputFormat = "#,##0";
				Ded17Amt4.OutputFormat = "#,##0";
				DedTotal3Amt4.OutputFormat = "#,##0";
			}

			if (DedDispType5.Text == "2")
			{
				Ded1Amt5.OutputFormat = "###0";
				Ded2Amt5.OutputFormat = "###0";
				Ded3Amt5.OutputFormat = "###0";
				Ded4Amt5.OutputFormat = "###0";
				Ded5Amt5.OutputFormat = "###0";
				Ded6Amt5.OutputFormat = "###0";
				Ded7Amt5.OutputFormat = "###0";
				Ded8Amt5.OutputFormat = "###0";
				Ded9Amt5.OutputFormat = "###0";
				Ded10Amt5.OutputFormat = "###0";
				Ded11Amt5.OutputFormat = "###0";
				Ded12Amt5.OutputFormat = "###0";
				DedTotal1Amt5.OutputFormat = "###0";
				Ded13Amt5.OutputFormat = "###0";
				Ded14Amt5.OutputFormat = "###0";
				Ded15Amt5.OutputFormat = "###0";
				Ded16Amt5.OutputFormat = "###0";
				DedTotal2Amt5.OutputFormat = "###0";
				Ded17Amt5.OutputFormat = "###0";
				DedTotal3Amt5.OutputFormat = "###0";
			}

			else if (DedDispType5.Text == "3")
			{
				Ded1Amt5.OutputFormat = "#,##0.00";
				Ded2Amt5.OutputFormat = "#,##0.00";
				Ded3Amt5.OutputFormat = "#,##0.00";
				Ded4Amt5.OutputFormat = "#,##0.00";
				Ded5Amt5.OutputFormat = "#,##0.00";
				Ded6Amt5.OutputFormat = "#,##0.00";
				Ded7Amt5.OutputFormat = "#,##0.00";
				Ded8Amt5.OutputFormat = "#,##0.00";
				Ded9Amt5.OutputFormat = "#,##0.00";
				Ded10Amt5.OutputFormat = "#,##0.00";
				Ded11Amt5.OutputFormat = "#,##0.00";
				Ded12Amt5.OutputFormat = "#,##0.00";
				DedTotal1Amt5.OutputFormat = "#,##0.00";
				Ded13Amt5.OutputFormat = "#,##0.00";
				Ded14Amt5.OutputFormat = "#,##0.00";
				Ded15Amt5.OutputFormat = "#,##0.00";
				Ded16Amt5.OutputFormat = "#,##0.00";
				DedTotal2Amt5.OutputFormat = "#,##0.00";
				Ded17Amt5.OutputFormat = "#,##0.00";
				DedTotal3Amt5.OutputFormat = "#,##0.00";
			}

			else if (DedDispType5.Text == "4")
			{
				Ded1Amt5.OutputFormat = "###0.00";
				Ded2Amt5.OutputFormat = "###0.00";
				Ded3Amt5.OutputFormat = "###0.00";
				Ded4Amt5.OutputFormat = "###0.00";
				Ded5Amt5.OutputFormat = "###0.00";
				Ded6Amt5.OutputFormat = "###0.00";
				Ded7Amt5.OutputFormat = "###0.00";
				Ded8Amt5.OutputFormat = "###0.00";
				Ded9Amt5.OutputFormat = "###0.00";
				Ded10Amt5.OutputFormat = "###0.00";
				Ded11Amt5.OutputFormat = "###0.00";
				Ded12Amt5.OutputFormat = "###0.00";
				DedTotal1Amt5.OutputFormat = "###0.00";
				Ded13Amt5.OutputFormat = "###0.00";
				Ded14Amt5.OutputFormat = "###0.00";
				Ded15Amt5.OutputFormat = "###0.00";
				Ded16Amt5.OutputFormat = "###0.00";
				DedTotal2Amt5.OutputFormat = "###0.00";
				Ded17Amt5.OutputFormat = "###0.00";
				DedTotal3Amt5.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt5.OutputFormat = "#,##0";
				Ded2Amt5.OutputFormat = "#,##0";
				Ded3Amt5.OutputFormat = "#,##0";
				Ded4Amt5.OutputFormat = "#,##0";
				Ded5Amt5.OutputFormat = "#,##0";
				Ded6Amt5.OutputFormat = "#,##0";
				Ded7Amt5.OutputFormat = "#,##0";
				Ded8Amt5.OutputFormat = "#,##0";
				Ded9Amt5.OutputFormat = "#,##0";
				Ded10Amt5.OutputFormat = "#,##0";
				Ded11Amt5.OutputFormat = "#,##0";
				Ded12Amt5.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt5.OutputFormat = "###0";
				DedTotal1Amt5.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt5.OutputFormat = "#,##0";
				Ded14Amt5.OutputFormat = "#,##0";
				Ded15Amt5.OutputFormat = "#,##0";
				Ded16Amt5.OutputFormat = "#,##0";
				DedTotal2Amt5.OutputFormat = "#,##0";
				Ded17Amt5.OutputFormat = "#,##0";
				DedTotal3Amt5.OutputFormat = "#,##0";
			}

			if (DedDispType6.Text == "2")
			{
				Ded1Amt6.OutputFormat = "###0";
				Ded2Amt6.OutputFormat = "###0";
				Ded3Amt6.OutputFormat = "###0";
				Ded4Amt6.OutputFormat = "###0";
				Ded5Amt6.OutputFormat = "###0";
				Ded6Amt6.OutputFormat = "###0";
				Ded7Amt6.OutputFormat = "###0";
				Ded8Amt6.OutputFormat = "###0";
				Ded9Amt6.OutputFormat = "###0";
				Ded10Amt6.OutputFormat = "###0";
				Ded11Amt6.OutputFormat = "###0";
				Ded12Amt6.OutputFormat = "###0";
				DedTotal1Amt6.OutputFormat = "###0";
				Ded13Amt6.OutputFormat = "###0";
				Ded14Amt6.OutputFormat = "###0";
				Ded15Amt6.OutputFormat = "###0";
				Ded16Amt6.OutputFormat = "###0";
				DedTotal2Amt6.OutputFormat = "###0";
				Ded17Amt6.OutputFormat = "###0";
				DedTotal3Amt6.OutputFormat = "###0";
			}

			else if (DedDispType6.Text == "3")
			{
				Ded1Amt6.OutputFormat = "#,##0.00";
				Ded2Amt6.OutputFormat = "#,##0.00";
				Ded3Amt6.OutputFormat = "#,##0.00";
				Ded4Amt6.OutputFormat = "#,##0.00";
				Ded5Amt6.OutputFormat = "#,##0.00";
				Ded6Amt6.OutputFormat = "#,##0.00";
				Ded7Amt6.OutputFormat = "#,##0.00";
				Ded8Amt6.OutputFormat = "#,##0.00";
				Ded9Amt6.OutputFormat = "#,##0.00";
				Ded10Amt6.OutputFormat = "#,##0.00";
				Ded11Amt6.OutputFormat = "#,##0.00";
				Ded12Amt6.OutputFormat = "#,##0.00";
				DedTotal1Amt6.OutputFormat = "#,##0.00";
				Ded13Amt6.OutputFormat = "#,##0.00";
				Ded14Amt6.OutputFormat = "#,##0.00";
				Ded15Amt6.OutputFormat = "#,##0.00";
				Ded16Amt6.OutputFormat = "#,##0.00";
				DedTotal2Amt6.OutputFormat = "#,##0.00";
				Ded17Amt6.OutputFormat = "#,##0.00";
				DedTotal3Amt6.OutputFormat = "#,##0.00";
			}

			else if (DedDispType6.Text == "4")
			{
				Ded1Amt6.OutputFormat = "###0.00";
				Ded2Amt6.OutputFormat = "###0.00";
				Ded3Amt6.OutputFormat = "###0.00";
				Ded4Amt6.OutputFormat = "###0.00";
				Ded5Amt6.OutputFormat = "###0.00";
				Ded6Amt6.OutputFormat = "###0.00";
				Ded7Amt6.OutputFormat = "###0.00";
				Ded8Amt6.OutputFormat = "###0.00";
				Ded9Amt6.OutputFormat = "###0.00";
				Ded10Amt6.OutputFormat = "###0.00";
				Ded11Amt6.OutputFormat = "###0.00";
				Ded12Amt6.OutputFormat = "###0.00";
				DedTotal1Amt6.OutputFormat = "###0.00";
				Ded13Amt6.OutputFormat = "###0.00";
				Ded14Amt6.OutputFormat = "###0.00";
				Ded15Amt6.OutputFormat = "###0.00";
				Ded16Amt6.OutputFormat = "###0.00";
				DedTotal2Amt6.OutputFormat = "###0.00";
				Ded17Amt6.OutputFormat = "###0.00";
				DedTotal3Amt6.OutputFormat = "###0.00";
			}

			else
			{
				Ded1Amt6.OutputFormat = "#,##0";
				Ded2Amt6.OutputFormat = "#,##0";
				Ded3Amt6.OutputFormat = "#,##0";
				Ded4Amt6.OutputFormat = "#,##0";
				Ded5Amt6.OutputFormat = "#,##0";
				Ded6Amt6.OutputFormat = "#,##0";
				Ded7Amt6.OutputFormat = "#,##0";
				Ded8Amt6.OutputFormat = "#,##0";
				Ded9Amt6.OutputFormat = "#,##0";
				Ded10Amt6.OutputFormat = "#,##0";
				Ded11Amt6.OutputFormat = "#,##0";
				Ded12Amt6.OutputFormat = "#,##0";
// 管理番号 B14921 From
				//DedTotal1Amt6.OutputFormat = "###0";
				DedTotal1Amt6.OutputFormat = "#,##0";
// 管理番号 B14921 To
				Ded13Amt6.OutputFormat = "#,##0";
				Ded14Amt6.OutputFormat = "#,##0";
				Ded15Amt6.OutputFormat = "#,##0";
				Ded16Amt6.OutputFormat = "#,##0";
				DedTotal2Amt6.OutputFormat = "#,##0";
				Ded17Amt6.OutputFormat = "#,##0";
				DedTotal3Amt6.OutputFormat = "#,##0";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if(DedDispType7.Text == "2")
//			{
//				Ded1Amt7.OutputFormat = "###0";
//				Ded2Amt7.OutputFormat = "###0";
//				Ded3Amt7.OutputFormat = "###0";
//				Ded4Amt7.OutputFormat = "###0";
//				Ded5Amt7.OutputFormat = "###0";
//				Ded6Amt7.OutputFormat = "###0";
//				Ded7Amt7.OutputFormat = "###0";
//				Ded8Amt7.OutputFormat = "###0";
//				Ded9Amt7.OutputFormat = "###0";
//				Ded10Amt7.OutputFormat = "###0";
//				Ded11Amt7.OutputFormat = "###0";
//				Ded12Amt7.OutputFormat = "###0";
//				DedTotal1Amt7.OutputFormat = "###0";
//				Ded13Amt7.OutputFormat = "###0";
//				Ded14Amt7.OutputFormat = "###0";
//				Ded15Amt7.OutputFormat = "###0";
//				Ded16Amt7.OutputFormat = "###0";
//				DedTotal2Amt7.OutputFormat = "###0";
//				Ded17Amt7.OutputFormat = "###0";
//				DedTotal3Amt7.OutputFormat = "###0";
//			}
//
//			else if(DedDispType7.Text == "3")
//			{
//				Ded1Amt7.OutputFormat = "#,##0.00";
//				Ded2Amt7.OutputFormat = "#,##0.00";
//				Ded3Amt7.OutputFormat = "#,##0.00";
//				Ded4Amt7.OutputFormat = "#,##0.00";
//				Ded5Amt7.OutputFormat = "#,##0.00";
//				Ded6Amt7.OutputFormat = "#,##0.00";
//				Ded7Amt7.OutputFormat = "#,##0.00";
//				Ded8Amt7.OutputFormat = "#,##0.00";
//				Ded9Amt7.OutputFormat = "#,##0.00";
//				Ded10Amt7.OutputFormat = "#,##0.00";
//				Ded11Amt7.OutputFormat = "#,##0.00";
//				Ded12Amt7.OutputFormat = "#,##0.00";
//				DedTotal1Amt7.OutputFormat = "#,##0.00";
//				Ded13Amt7.OutputFormat = "#,##0.00";
//				Ded14Amt7.OutputFormat = "#,##0.00";
//				Ded15Amt7.OutputFormat = "#,##0.00";
//				Ded16Amt7.OutputFormat = "#,##0.00";
//				DedTotal2Amt7.OutputFormat = "#,##0.00";
//				Ded17Amt7.OutputFormat = "#,##0.00";
//				DedTotal3Amt7.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType7.Text == "4")
//			{
//				Ded1Amt7.OutputFormat = "###0.00";
//				Ded2Amt7.OutputFormat = "###0.00";
//				Ded3Amt7.OutputFormat = "###0.00";
//				Ded4Amt7.OutputFormat = "###0.00";
//				Ded5Amt7.OutputFormat = "###0.00";
//				Ded6Amt7.OutputFormat = "###0.00";
//				Ded7Amt7.OutputFormat = "###0.00";
//				Ded8Amt7.OutputFormat = "###0.00";
//				Ded9Amt7.OutputFormat = "###0.00";
//				Ded10Amt7.OutputFormat = "###0.00";
//				Ded11Amt7.OutputFormat = "###0.00";
//				Ded12Amt7.OutputFormat = "###0.00";
//				DedTotal1Amt7.OutputFormat = "###0.00";
//				Ded13Amt7.OutputFormat = "###0.00";
//				Ded14Amt7.OutputFormat = "###0.00";
//				Ded15Amt7.OutputFormat = "###0.00";
//				Ded16Amt7.OutputFormat = "###0.00";
//				DedTotal2Amt7.OutputFormat = "###0.00";
//				Ded17Amt7.OutputFormat = "###0.00";
//				DedTotal3Amt7.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt7.OutputFormat = "#,##0";
//				Ded2Amt7.OutputFormat = "#,##0";
//				Ded3Amt7.OutputFormat = "#,##0";
//				Ded4Amt7.OutputFormat = "#,##0";
//				Ded5Amt7.OutputFormat = "#,##0";
//				Ded6Amt7.OutputFormat = "#,##0";
//				Ded7Amt7.OutputFormat = "#,##0";
//				Ded8Amt7.OutputFormat = "#,##0";
//				Ded9Amt7.OutputFormat = "#,##0";
//				Ded10Amt7.OutputFormat = "#,##0";
//				Ded11Amt7.OutputFormat = "#,##0";
//				Ded12Amt7.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt7.OutputFormat = "###0";
//				DedTotal1Amt7.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Ded13Amt7.OutputFormat = "#,##0";
//				Ded14Amt7.OutputFormat = "#,##0";
//				Ded15Amt7.OutputFormat = "#,##0";
//				Ded16Amt7.OutputFormat = "#,##0";
//				DedTotal2Amt7.OutputFormat = "#,##0";
//				Ded17Amt7.OutputFormat = "#,##0";
//				DedTotal3Amt7.OutputFormat = "#,##0";
//			}
//
//			if(DedDispType8.Text == "2")
//			{
//				Ded1Amt8.OutputFormat = "###0";
//				Ded2Amt8.OutputFormat = "###0";
//				Ded3Amt8.OutputFormat = "###0";
//				Ded4Amt8.OutputFormat = "###0";
//				Ded5Amt8.OutputFormat = "###0";
//				Ded6Amt8.OutputFormat = "###0";
//				Ded7Amt8.OutputFormat = "###0";
//				Ded8Amt8.OutputFormat = "###0";
//				Ded9Amt8.OutputFormat = "###0";
//				Ded10Amt8.OutputFormat = "###0";
//				Ded11Amt8.OutputFormat = "###0";
//				Ded12Amt8.OutputFormat = "###0";
//				DedTotal1Amt8.OutputFormat = "###0";
//				Ded13Amt8.OutputFormat = "###0";
//				Ded14Amt8.OutputFormat = "###0";
//				Ded15Amt8.OutputFormat = "###0";
//				Ded16Amt8.OutputFormat = "###0";
//				DedTotal2Amt8.OutputFormat = "###0";
//				Ded17Amt8.OutputFormat = "###0";
//				DedTotal3Amt8.OutputFormat = "###0";
//			}
//
//			else if(DedDispType8.Text == "3")
//			{
//				Ded1Amt8.OutputFormat = "#,##0.00";
//				Ded2Amt8.OutputFormat = "#,##0.00";
//				Ded3Amt8.OutputFormat = "#,##0.00";
//				Ded4Amt8.OutputFormat = "#,##0.00";
//				Ded5Amt8.OutputFormat = "#,##0.00";
//				Ded6Amt8.OutputFormat = "#,##0.00";
//				Ded7Amt8.OutputFormat = "#,##0.00";
//				Ded8Amt8.OutputFormat = "#,##0.00";
//				Ded9Amt8.OutputFormat = "#,##0.00";
//				Ded10Amt8.OutputFormat = "#,##0.00";
//				Ded11Amt8.OutputFormat = "#,##0.00";
//				Ded12Amt8.OutputFormat = "#,##0.00";
//				DedTotal1Amt8.OutputFormat = "#,##0.00";
//				Ded13Amt8.OutputFormat = "#,##0.00";
//				Ded14Amt8.OutputFormat = "#,##0.00";
//				Ded15Amt8.OutputFormat = "#,##0.00";
//				Ded16Amt8.OutputFormat = "#,##0.00";
//				DedTotal2Amt8.OutputFormat = "#,##0.00";
//				Ded17Amt8.OutputFormat = "#,##0.00";
//				DedTotal3Amt8.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType8.Text == "4")
//			{
//				Ded1Amt8.OutputFormat = "###0.00";
//				Ded2Amt8.OutputFormat = "###0.00";
//				Ded3Amt8.OutputFormat = "###0.00";
//				Ded4Amt8.OutputFormat = "###0.00";
//				Ded5Amt8.OutputFormat = "###0.00";
//				Ded6Amt8.OutputFormat = "###0.00";
//				Ded7Amt8.OutputFormat = "###0.00";
//				Ded8Amt8.OutputFormat = "###0.00";
//				Ded9Amt8.OutputFormat = "###0.00";
//				Ded10Amt8.OutputFormat = "###0.00";
//				Ded11Amt8.OutputFormat = "###0.00";
//				Ded12Amt8.OutputFormat = "###0.00";
//				DedTotal1Amt8.OutputFormat = "###0.00";
//				Ded13Amt8.OutputFormat = "###0.00";
//				Ded14Amt8.OutputFormat = "###0.00";
//				Ded15Amt8.OutputFormat = "###0.00";
//				Ded16Amt8.OutputFormat = "###0.00";
//				DedTotal2Amt8.OutputFormat = "###0.00";
//				Ded17Amt8.OutputFormat = "###0.00";
//				DedTotal3Amt8.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt8.OutputFormat = "#,##0";
//				Ded2Amt8.OutputFormat = "#,##0";
//				Ded3Amt8.OutputFormat = "#,##0";
//				Ded4Amt8.OutputFormat = "#,##0";
//				Ded5Amt8.OutputFormat = "#,##0";
//				Ded6Amt8.OutputFormat = "#,##0";
//				Ded7Amt8.OutputFormat = "#,##0";
//				Ded8Amt8.OutputFormat = "#,##0";
//				Ded9Amt8.OutputFormat = "#,##0";
//				Ded10Amt8.OutputFormat = "#,##0";
//				Ded11Amt8.OutputFormat = "#,##0";
//				Ded12Amt8.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt8.OutputFormat = "###0";
//				DedTotal1Amt8.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Ded13Amt8.OutputFormat = "#,##0";
//				Ded14Amt8.OutputFormat = "#,##0";
//				Ded15Amt8.OutputFormat = "#,##0";
//				Ded16Amt8.OutputFormat = "#,##0";
//				DedTotal2Amt8.OutputFormat = "#,##0";
//				Ded17Amt8.OutputFormat = "#,##0";
//				DedTotal3Amt8.OutputFormat = "#,##0";
//			}
//
//			if(DedDispType9.Text == "2")
//			{
//				Ded1Amt9.OutputFormat = "###0";
//				Ded2Amt9.OutputFormat = "###0";
//				Ded3Amt9.OutputFormat = "###0";
//				Ded4Amt9.OutputFormat = "###0";
//				Ded5Amt9.OutputFormat = "###0";
//				Ded6Amt9.OutputFormat = "###0";
//				Ded7Amt9.OutputFormat = "###0";
//				Ded8Amt9.OutputFormat = "###0";
//				Ded9Amt9.OutputFormat = "###0";
//				Ded10Amt9.OutputFormat = "###0";
//				Ded11Amt9.OutputFormat = "###0";
//				Ded12Amt9.OutputFormat = "###0";
//				DedTotal1Amt9.OutputFormat = "###0";
//				Ded13Amt9.OutputFormat = "###0";
//				Ded14Amt9.OutputFormat = "###0";
//				Ded15Amt9.OutputFormat = "###0";
//				Ded16Amt9.OutputFormat = "###0";
//				DedTotal2Amt9.OutputFormat = "###0";
//				Ded17Amt9.OutputFormat = "###0";
//				DedTotal3Amt9.OutputFormat = "###0";
//			}
//
//			else if(DedDispType9.Text == "3")
//			{
//				Ded1Amt9.OutputFormat = "#,##0.00";
//				Ded2Amt9.OutputFormat = "#,##0.00";
//				Ded3Amt9.OutputFormat = "#,##0.00";
//				Ded4Amt9.OutputFormat = "#,##0.00";
//				Ded5Amt9.OutputFormat = "#,##0.00";
//				Ded6Amt9.OutputFormat = "#,##0.00";
//				Ded7Amt9.OutputFormat = "#,##0.00";
//				Ded8Amt9.OutputFormat = "#,##0.00";
//				Ded9Amt9.OutputFormat = "#,##0.00";
//				Ded10Amt9.OutputFormat = "#,##0.00";
//				Ded11Amt9.OutputFormat = "#,##0.00";
//				Ded12Amt9.OutputFormat = "#,##0.00";
//				DedTotal1Amt9.OutputFormat = "#,##0.00";
//				Ded13Amt9.OutputFormat = "#,##0.00";
//				Ded14Amt9.OutputFormat = "#,##0.00";
//				Ded15Amt9.OutputFormat = "#,##0.00";
//				Ded16Amt9.OutputFormat = "#,##0.00";
//				DedTotal2Amt9.OutputFormat = "#,##0.00";
//				Ded17Amt9.OutputFormat = "#,##0.00";
//				DedTotal3Amt9.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType9.Text == "4")
//			{
//				Ded1Amt9.OutputFormat = "###0.00";
//				Ded2Amt9.OutputFormat = "###0.00";
//				Ded3Amt9.OutputFormat = "###0.00";
//				Ded4Amt9.OutputFormat = "###0.00";
//				Ded5Amt9.OutputFormat = "###0.00";
//				Ded6Amt9.OutputFormat = "###0.00";
//				Ded7Amt9.OutputFormat = "###0.00";
//				Ded8Amt9.OutputFormat = "###0.00";
//				Ded9Amt9.OutputFormat = "###0.00";
//				Ded10Amt9.OutputFormat = "###0.00";
//				Ded11Amt9.OutputFormat = "###0.00";
//				Ded12Amt9.OutputFormat = "###0.00";
//				DedTotal1Amt9.OutputFormat = "###0.00";
//				Ded13Amt9.OutputFormat = "###0.00";
//				Ded14Amt9.OutputFormat = "###0.00";
//				Ded15Amt9.OutputFormat = "###0.00";
//				Ded16Amt9.OutputFormat = "###0.00";
//				DedTotal2Amt9.OutputFormat = "###0.00";
//				Ded17Amt9.OutputFormat = "###0.00";
//				DedTotal3Amt9.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt9.OutputFormat = "#,##0";
//				Ded2Amt9.OutputFormat = "#,##0";
//				Ded3Amt9.OutputFormat = "#,##0";
//				Ded4Amt9.OutputFormat = "#,##0";
//				Ded5Amt9.OutputFormat = "#,##0";
//				Ded6Amt9.OutputFormat = "#,##0";
//				Ded7Amt9.OutputFormat = "#,##0";
//				Ded8Amt9.OutputFormat = "#,##0";
//				Ded9Amt9.OutputFormat = "#,##0";
//				Ded10Amt9.OutputFormat = "#,##0";
//				Ded11Amt9.OutputFormat = "#,##0";
//				Ded12Amt9.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt9.OutputFormat = "###0";
//				DedTotal1Amt9.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Ded13Amt9.OutputFormat = "#,##0";
//				Ded14Amt9.OutputFormat = "#,##0";
//				Ded15Amt9.OutputFormat = "#,##0";
//				Ded16Amt9.OutputFormat = "#,##0";
//				DedTotal2Amt9.OutputFormat = "#,##0";
//				Ded17Amt9.OutputFormat = "#,##0";
//				DedTotal3Amt9.OutputFormat = "#,##0";
//			}
//
//			if(DedDispType10.Text == "2")
//			{
//				Ded1Amt10.OutputFormat = "###0";
//				Ded2Amt10.OutputFormat = "###0";
//				Ded3Amt10.OutputFormat = "###0";
//				Ded4Amt10.OutputFormat = "###0";
//				Ded5Amt10.OutputFormat = "###0";
//				Ded6Amt10.OutputFormat = "###0";
//				Ded7Amt10.OutputFormat = "###0";
//				Ded8Amt10.OutputFormat = "###0";
//				Ded9Amt10.OutputFormat = "###0";
//				Ded10Amt10.OutputFormat = "###0";
//				Ded11Amt10.OutputFormat = "###0";
//				Ded12Amt10.OutputFormat = "###0";
//				DedTotal1Amt10.OutputFormat = "###0";
//				Ded13Amt10.OutputFormat = "###0";
//				Ded14Amt10.OutputFormat = "###0";
//				Ded15Amt10.OutputFormat = "###0";
//				Ded16Amt10.OutputFormat = "###0";
//				DedTotal2Amt10.OutputFormat = "###0";
//				Ded17Amt10.OutputFormat = "###0";
//				DedTotal3Amt10.OutputFormat = "###0";
//			}
//
//			else if(DedDispType10.Text == "3")
//			{
//				Ded1Amt10.OutputFormat = "#,##0.00";
//				Ded2Amt10.OutputFormat = "#,##0.00";
//				Ded3Amt10.OutputFormat = "#,##0.00";
//				Ded4Amt10.OutputFormat = "#,##0.00";
//				Ded5Amt10.OutputFormat = "#,##0.00";
//				Ded6Amt10.OutputFormat = "#,##0.00";
//				Ded7Amt10.OutputFormat = "#,##0.00";
//				Ded8Amt10.OutputFormat = "#,##0.00";
//				Ded9Amt10.OutputFormat = "#,##0.00";
//				Ded10Amt10.OutputFormat = "#,##0.00";
//				Ded11Amt10.OutputFormat = "#,##0.00";
//				Ded12Amt10.OutputFormat = "#,##0.00";
//				DedTotal1Amt10.OutputFormat = "#,##0.00";
//				Ded13Amt10.OutputFormat = "#,##0.00";
//				Ded14Amt10.OutputFormat = "#,##0.00";
//				Ded15Amt10.OutputFormat = "#,##0.00";
//				Ded16Amt10.OutputFormat = "#,##0.00";
//				DedTotal2Amt10.OutputFormat = "#,##0.00";
//				Ded17Amt10.OutputFormat = "#,##0.00";
//				DedTotal3Amt10.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType10.Text == "4")
//			{
//				Ded1Amt10.OutputFormat = "###0.00";
//				Ded2Amt10.OutputFormat = "###0.00";
//				Ded3Amt10.OutputFormat = "###0.00";
//				Ded4Amt10.OutputFormat = "###0.00";
//				Ded5Amt10.OutputFormat = "###0.00";
//				Ded6Amt10.OutputFormat = "###0.00";
//				Ded7Amt10.OutputFormat = "###0.00";
//				Ded8Amt10.OutputFormat = "###0.00";
//				Ded9Amt10.OutputFormat = "###0.00";
//				Ded10Amt10.OutputFormat = "###0.00";
//				Ded11Amt10.OutputFormat = "###0.00";
//				Ded12Amt10.OutputFormat = "###0.00";
//				DedTotal1Amt10.OutputFormat = "###0.00";
//				Ded13Amt10.OutputFormat = "###0.00";
//				Ded14Amt10.OutputFormat = "###0.00";
//				Ded15Amt10.OutputFormat = "###0.00";
//				Ded16Amt10.OutputFormat = "###0.00";
//				DedTotal2Amt10.OutputFormat = "###0.00";
//				Ded17Amt10.OutputFormat = "###0.00";
//				DedTotal3Amt10.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt10.OutputFormat = "#,##0";
//				Ded2Amt10.OutputFormat = "#,##0";
//				Ded3Amt10.OutputFormat = "#,##0";
//				Ded4Amt10.OutputFormat = "#,##0";
//				Ded5Amt10.OutputFormat = "#,##0";
//				Ded6Amt10.OutputFormat = "#,##0";
//				Ded7Amt10.OutputFormat = "#,##0";
//				Ded8Amt10.OutputFormat = "#,##0";
//				Ded9Amt10.OutputFormat = "#,##0";
//				Ded10Amt10.OutputFormat = "#,##0";
//				Ded11Amt10.OutputFormat = "#,##0";
//				Ded12Amt10.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt10.OutputFormat = "###0";
//				DedTotal1Amt10.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Ded13Amt10.OutputFormat = "#,##0";
//				Ded14Amt10.OutputFormat = "#,##0";
//				Ded15Amt10.OutputFormat = "#,##0";
//				Ded16Amt10.OutputFormat = "#,##0";
//				DedTotal2Amt10.OutputFormat = "#,##0";
//				Ded17Amt10.OutputFormat = "#,##0";
//				DedTotal3Amt10.OutputFormat = "#,##0";
//			}
//
//			if(DedDispType11.Text == "2")
//			{
//				Ded1Amt11.OutputFormat = "###0";
//				Ded2Amt11.OutputFormat = "###0";
//				Ded3Amt11.OutputFormat = "###0";
//				Ded4Amt11.OutputFormat = "###0";
//				Ded5Amt11.OutputFormat = "###0";
//				Ded6Amt11.OutputFormat = "###0";
//				Ded7Amt11.OutputFormat = "###0";
//				Ded8Amt11.OutputFormat = "###0";
//				Ded9Amt11.OutputFormat = "###0";
//				Ded10Amt11.OutputFormat = "###0";
//				Ded11Amt11.OutputFormat = "###0";
//				Ded12Amt11.OutputFormat = "###0";
//				DedTotal1Amt11.OutputFormat = "###0";
//				Ded13Amt11.OutputFormat = "###0";
//				Ded14Amt11.OutputFormat = "###0";
//				Ded15Amt11.OutputFormat = "###0";
//				Ded16Amt11.OutputFormat = "###0";
//				DedTotal2Amt11.OutputFormat = "###0";
//				Ded17Amt11.OutputFormat = "###0";
//				DedTotal3Amt11.OutputFormat = "###0";
//			}
//
//			else if(DedDispType11.Text == "3")
//			{
//				Ded1Amt11.OutputFormat = "#,##0.00";
//				Ded2Amt11.OutputFormat = "#,##0.00";
//				Ded3Amt11.OutputFormat = "#,##0.00";
//				Ded4Amt11.OutputFormat = "#,##0.00";
//				Ded5Amt11.OutputFormat = "#,##0.00";
//				Ded6Amt11.OutputFormat = "#,##0.00";
//				Ded7Amt11.OutputFormat = "#,##0.00";
//				Ded8Amt11.OutputFormat = "#,##0.00";
//				Ded9Amt11.OutputFormat = "#,##0.00";
//				Ded10Amt11.OutputFormat = "#,##0.00";
//				Ded11Amt11.OutputFormat = "#,##0.00";
//				Ded12Amt11.OutputFormat = "#,##0.00";
//				DedTotal1Amt11.OutputFormat = "#,##0.00";
//				Ded13Amt11.OutputFormat = "#,##0.00";
//				Ded14Amt11.OutputFormat = "#,##0.00";
//				Ded15Amt11.OutputFormat = "#,##0.00";
//				Ded16Amt11.OutputFormat = "#,##0.00";
//				DedTotal2Amt11.OutputFormat = "#,##0.00";
//				Ded17Amt11.OutputFormat = "#,##0.00";
//				DedTotal3Amt11.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType11.Text == "4")
//			{
//				Ded1Amt11.OutputFormat = "###0.00";
//				Ded2Amt11.OutputFormat = "###0.00";
//				Ded3Amt11.OutputFormat = "###0.00";
//				Ded4Amt11.OutputFormat = "###0.00";
//				Ded5Amt11.OutputFormat = "###0.00";
//				Ded6Amt11.OutputFormat = "###0.00";
//				Ded7Amt11.OutputFormat = "###0.00";
//				Ded8Amt11.OutputFormat = "###0.00";
//				Ded9Amt11.OutputFormat = "###0.00";
//				Ded10Amt11.OutputFormat = "###0.00";
//				Ded11Amt11.OutputFormat = "###0.00";
//				Ded12Amt11.OutputFormat = "###0.00";
//				DedTotal1Amt11.OutputFormat = "###0.00";
//				Ded13Amt11.OutputFormat = "###0.00";
//				Ded14Amt11.OutputFormat = "###0.00";
//				Ded15Amt11.OutputFormat = "###0.00";
//				Ded16Amt11.OutputFormat = "###0.00";
//				DedTotal2Amt11.OutputFormat = "###0.00";
//				Ded17Amt11.OutputFormat = "###0.00";
//				DedTotal3Amt11.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt11.OutputFormat = "#,##0";
//				Ded2Amt11.OutputFormat = "#,##0";
//				Ded3Amt11.OutputFormat = "#,##0";
//				Ded4Amt11.OutputFormat = "#,##0";
//				Ded5Amt11.OutputFormat = "#,##0";
//				Ded6Amt11.OutputFormat = "#,##0";
//				Ded7Amt11.OutputFormat = "#,##0";
//				Ded8Amt11.OutputFormat = "#,##0";
//				Ded9Amt11.OutputFormat = "#,##0";
//				Ded10Amt11.OutputFormat = "#,##0";
//				Ded11Amt11.OutputFormat = "#,##0";
//				Ded12Amt11.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt11.OutputFormat = "###0";
//				DedTotal1Amt11.OutputFormat = "#,##0";
//// 管理番号 B14921 To
//				Ded13Amt11.OutputFormat = "#,##0";
//				Ded14Amt11.OutputFormat = "#,##0";
//				Ded15Amt11.OutputFormat = "#,##0";
//				Ded16Amt11.OutputFormat = "#,##0";
//				DedTotal2Amt11.OutputFormat = "#,##0";
//				Ded17Amt11.OutputFormat = "#,##0";
//				DedTotal3Amt11.OutputFormat = "#,##0";
//			}
//
//			if(DedDispType12.Text == "2")
//			{
//				Ded1Amt12.OutputFormat = "###0";
//				Ded2Amt12.OutputFormat = "###0";
//				Ded3Amt12.OutputFormat = "###0";
//				Ded4Amt12.OutputFormat = "###0";
//				Ded5Amt12.OutputFormat = "###0";
//				Ded6Amt12.OutputFormat = "###0";
//				Ded7Amt12.OutputFormat = "###0";
//				Ded8Amt12.OutputFormat = "###0";
//				Ded9Amt12.OutputFormat = "###0";
//				Ded10Amt12.OutputFormat = "###0";
//				Ded11Amt12.OutputFormat = "###0";
//				Ded12Amt12.OutputFormat = "###0";
//				DedTotal1Amt12.OutputFormat = "###0";
//				Ded13Amt12.OutputFormat = "###0";
//				Ded14Amt12.OutputFormat = "###0";
//				Ded15Amt12.OutputFormat = "###0";
//				Ded16Amt12.OutputFormat = "###0";
//				DedTotal2Amt12.OutputFormat = "###0";
//				Ded17Amt12.OutputFormat = "###0";
//				DedTotal3Amt12.OutputFormat = "###0";
//			}
//
//			else if(DedDispType12.Text == "3")
//			{
//				Ded1Amt12.OutputFormat = "#,##0.00";
//				Ded2Amt12.OutputFormat = "#,##0.00";
//				Ded3Amt12.OutputFormat = "#,##0.00";
//				Ded4Amt12.OutputFormat = "#,##0.00";
//				Ded5Amt12.OutputFormat = "#,##0.00";
//				Ded6Amt12.OutputFormat = "#,##0.00";
//				Ded7Amt12.OutputFormat = "#,##0.00";
//				Ded8Amt12.OutputFormat = "#,##0.00";
//				Ded9Amt12.OutputFormat = "#,##0.00";
//				Ded10Amt12.OutputFormat = "#,##0.00";
//				Ded11Amt12.OutputFormat = "#,##0.00";
//				Ded12Amt12.OutputFormat = "#,##0.00";
//				DedTotal1Amt12.OutputFormat = "#,##0.00";
//				Ded13Amt12.OutputFormat = "#,##0.00";
//				Ded14Amt12.OutputFormat = "#,##0.00";
//				Ded15Amt12.OutputFormat = "#,##0.00";
//				Ded16Amt12.OutputFormat = "#,##0.00";
//				DedTotal2Amt12.OutputFormat = "#,##0.00";
//				Ded17Amt12.OutputFormat = "#,##0.00";
//				DedTotal3Amt12.OutputFormat = "#,##0.00";
//			}
//
//			else if(DedDispType12.Text == "4")
//			{
//				Ded1Amt12.OutputFormat = "###0.00";
//				Ded2Amt12.OutputFormat = "###0.00";
//				Ded3Amt12.OutputFormat = "###0.00";
//				Ded4Amt12.OutputFormat = "###0.00";
//				Ded5Amt12.OutputFormat = "###0.00";
//				Ded6Amt12.OutputFormat = "###0.00";
//				Ded7Amt12.OutputFormat = "###0.00";
//				Ded8Amt12.OutputFormat = "###0.00";
//				Ded9Amt12.OutputFormat = "###0.00";
//				Ded10Amt12.OutputFormat = "###0.00";
//				Ded11Amt12.OutputFormat = "###0.00";
//				Ded12Amt12.OutputFormat = "###0.00";
//				DedTotal1Amt12.OutputFormat = "###0.00";
//				Ded13Amt12.OutputFormat = "###0.00";
//				Ded14Amt12.OutputFormat = "###0.00";
//				Ded15Amt12.OutputFormat = "###0.00";
//				Ded16Amt12.OutputFormat = "###0.00";
//				DedTotal2Amt12.OutputFormat = "###0.00";
//				Ded17Amt12.OutputFormat = "###0.00";
//				DedTotal3Amt12.OutputFormat = "###0.00";
//			}
//
//			else
//			{
//				Ded1Amt12.OutputFormat = "#,##0";
//				Ded2Amt12.OutputFormat = "#,##0";
//				Ded3Amt12.OutputFormat = "#,##0";
//				Ded4Amt12.OutputFormat = "#,##0";
//				Ded5Amt12.OutputFormat = "#,##0";
//				Ded6Amt12.OutputFormat = "#,##0";
//				Ded7Amt12.OutputFormat = "#,##0";
//				Ded8Amt12.OutputFormat = "#,##0";
//				Ded9Amt12.OutputFormat = "#,##0";
//				Ded10Amt12.OutputFormat = "#,##0";
//				Ded11Amt12.OutputFormat = "#,##0";
//				Ded12Amt12.OutputFormat = "#,##0";
//// 管理番号 B14921 From
//				//DedTotal1Amt12.OutputFormat = "###0";
//				DedTotal1Amt12.OutputFormat = "#,##0";
//// 管理番号 B14921 To				
//				Ded13Amt12.OutputFormat = "#,##0";
//				Ded14Amt12.OutputFormat = "#,##0";
//				Ded15Amt12.OutputFormat = "#,##0";
//				Ded16Amt12.OutputFormat = "#,##0";
//				DedTotal2Amt12.OutputFormat = "#,##0";
//				Ded17Amt12.OutputFormat = "#,##0";
//				DedTotal3Amt12.OutputFormat = "#,##0";
//			}
// 管理番号 K24565 To

// 管理番号 B15940 From
			if (DedBnsDispType1.Text == "2")
			{
				Ded13Amt1.OutputFormat = "###0";
				Ded14Amt1.OutputFormat = "###0";
				Ded15Amt1.OutputFormat = "###0";
				Ded16Amt1.OutputFormat = "###0";
				DedTotal2Amt1.OutputFormat = "###0";
			}

			else if (DedBnsDispType1.Text == "3")
			{
				Ded13Amt1.OutputFormat = "#,##0.00";
				Ded14Amt1.OutputFormat = "#,##0.00";
				Ded15Amt1.OutputFormat = "#,##0.00";
				Ded16Amt1.OutputFormat = "#,##0.00";
				DedTotal2Amt1.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType1.Text == "4")
			{
				Ded13Amt1.OutputFormat = "###0.00";
				Ded14Amt1.OutputFormat = "###0.00";
				Ded15Amt1.OutputFormat = "###0.00";
				Ded16Amt1.OutputFormat = "###0.00";
				DedTotal2Amt1.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt1.OutputFormat = "#,##0";
				Ded14Amt1.OutputFormat = "#,##0";
				Ded15Amt1.OutputFormat = "#,##0";
				Ded16Amt1.OutputFormat = "#,##0";
				DedTotal2Amt1.OutputFormat = "#,##0";
			}

			if (DedBnsDispType2.Text == "2")
			{
				Ded13Amt2.OutputFormat = "###0";
				Ded14Amt2.OutputFormat = "###0";
				Ded15Amt2.OutputFormat = "###0";
				Ded16Amt2.OutputFormat = "###0";
				DedTotal2Amt2.OutputFormat = "###0";
			}
			else if (DedBnsDispType2.Text == "3")
			{
				Ded13Amt2.OutputFormat = "#,##0.00";
				Ded14Amt2.OutputFormat = "#,##0.00";
				Ded15Amt2.OutputFormat = "#,##0.00";
				Ded16Amt2.OutputFormat = "#,##0.00";
				DedTotal2Amt2.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType2.Text == "4")
			{
				Ded13Amt2.OutputFormat = "###0.00";
				Ded14Amt2.OutputFormat = "###0.00";
				Ded15Amt2.OutputFormat = "###0.00";
				Ded16Amt2.OutputFormat = "###0.00";
				DedTotal2Amt2.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt2.OutputFormat = "#,##0";
				Ded14Amt2.OutputFormat = "#,##0";
				Ded15Amt2.OutputFormat = "#,##0";
				Ded16Amt2.OutputFormat = "#,##0";
				DedTotal2Amt2.OutputFormat = "#,##0";
			}

			if (DedBnsDispType3.Text == "2")
			{
				Ded13Amt3.OutputFormat = "###0";
				Ded14Amt3.OutputFormat = "###0";
				Ded15Amt3.OutputFormat = "###0";
				Ded16Amt3.OutputFormat = "###0";
				DedTotal2Amt3.OutputFormat = "###0";
			}
			else if (DedBnsDispType3.Text == "3")
			{
				Ded13Amt3.OutputFormat = "#,##0.00";
				Ded14Amt3.OutputFormat = "#,##0.00";
				Ded15Amt3.OutputFormat = "#,##0.00";
				Ded16Amt3.OutputFormat = "#,##0.00";
				DedTotal2Amt3.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType3.Text == "4")
			{
				Ded13Amt3.OutputFormat = "###0.00";
				Ded14Amt3.OutputFormat = "###0.00";
				Ded15Amt3.OutputFormat = "###0.00";
				Ded16Amt3.OutputFormat = "###0.00";
				DedTotal2Amt3.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt3.OutputFormat = "#,##0";
				Ded14Amt3.OutputFormat = "#,##0";
				Ded15Amt3.OutputFormat = "#,##0";
				Ded16Amt3.OutputFormat = "#,##0";
				DedTotal2Amt3.OutputFormat = "#,##0";
			}

			if (DedBnsDispType4.Text == "2")
			{
				Ded13Amt4.OutputFormat = "###0";
				Ded14Amt4.OutputFormat = "###0";
				Ded15Amt4.OutputFormat = "###0";
				Ded16Amt4.OutputFormat = "###0";
				DedTotal2Amt4.OutputFormat = "###0";
			}
			else if (DedBnsDispType4.Text == "3")
			{
				Ded13Amt4.OutputFormat = "#,##0.00";
				Ded14Amt4.OutputFormat = "#,##0.00";
				Ded15Amt4.OutputFormat = "#,##0.00";
				Ded16Amt4.OutputFormat = "#,##0.00";
				DedTotal2Amt4.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType4.Text == "4")
			{
				Ded13Amt4.OutputFormat = "###0.00";
				Ded14Amt4.OutputFormat = "###0.00";
				Ded15Amt4.OutputFormat = "###0.00";
				Ded16Amt4.OutputFormat = "###0.00";
				DedTotal2Amt4.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt4.OutputFormat = "#,##0";
				Ded14Amt4.OutputFormat = "#,##0";
				Ded15Amt4.OutputFormat = "#,##0";
				Ded16Amt4.OutputFormat = "#,##0";
				DedTotal2Amt4.OutputFormat = "#,##0";
			}

			if (DedBnsDispType5.Text == "2")
			{
				Ded13Amt5.OutputFormat = "###0";
				Ded14Amt5.OutputFormat = "###0";
				Ded15Amt5.OutputFormat = "###0";
				Ded16Amt5.OutputFormat = "###0";
				DedTotal2Amt5.OutputFormat = "###0";
			}
			else if (DedBnsDispType5.Text == "3")
			{
				Ded13Amt5.OutputFormat = "#,##0.00";
				Ded14Amt5.OutputFormat = "#,##0.00";
				Ded15Amt5.OutputFormat = "#,##0.00";
				Ded16Amt5.OutputFormat = "#,##0.00";
				DedTotal2Amt5.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType5.Text == "4")
			{
				Ded13Amt5.OutputFormat = "###0.00";
				Ded14Amt5.OutputFormat = "###0.00";
				Ded15Amt5.OutputFormat = "###0.00";
				Ded16Amt5.OutputFormat = "###0.00";
				DedTotal2Amt5.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt5.OutputFormat = "#,##0";
				Ded14Amt5.OutputFormat = "#,##0";
				Ded15Amt5.OutputFormat = "#,##0";
				Ded16Amt5.OutputFormat = "#,##0";
				DedTotal2Amt5.OutputFormat = "#,##0";
			}

			if (DedBnsDispType6.Text == "2")
			{
				Ded13Amt6.OutputFormat = "###0";
				Ded14Amt6.OutputFormat = "###0";
				Ded15Amt6.OutputFormat = "###0";
				Ded16Amt6.OutputFormat = "###0";
				DedTotal2Amt6.OutputFormat = "###0";
			}
			else if (DedBnsDispType6.Text == "3")
			{
				Ded13Amt6.OutputFormat = "#,##0.00";
				Ded14Amt6.OutputFormat = "#,##0.00";
				Ded15Amt6.OutputFormat = "#,##0.00";
				Ded16Amt6.OutputFormat = "#,##0.00";
				DedTotal2Amt6.OutputFormat = "#,##0.00";
			}
			else if (DedBnsDispType6.Text == "4")
			{
				Ded13Amt6.OutputFormat = "###0.00";
				Ded14Amt6.OutputFormat = "###0.00";
				Ded15Amt6.OutputFormat = "###0.00";
				Ded16Amt6.OutputFormat = "###0.00";
				DedTotal2Amt6.OutputFormat = "###0.00";
			}
			else
			{
				Ded13Amt6.OutputFormat = "#,##0";
				Ded14Amt6.OutputFormat = "#,##0";
				Ded15Amt6.OutputFormat = "#,##0";
				Ded16Amt6.OutputFormat = "#,##0";
				DedTotal2Amt6.OutputFormat = "#,##0";
			}

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R97へ移動
//			if(DedBnsDispType7.Text == "2")
//			{
//				Ded13Amt7.OutputFormat = "###0";
//				Ded14Amt7.OutputFormat = "###0";
//				Ded15Amt7.OutputFormat = "###0";
//				Ded16Amt7.OutputFormat = "###0";
//				DedTotal2Amt7.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType7.Text == "3")
//			{
//				Ded13Amt7.OutputFormat = "#,##0.00";
//				Ded14Amt7.OutputFormat = "#,##0.00";
//				Ded15Amt7.OutputFormat = "#,##0.00";
//				Ded16Amt7.OutputFormat = "#,##0.00";
//				DedTotal2Amt7.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType7.Text == "4")
//			{
//				Ded13Amt7.OutputFormat = "###0.00";
//				Ded14Amt7.OutputFormat = "###0.00";
//				Ded15Amt7.OutputFormat = "###0.00";
//				Ded16Amt7.OutputFormat = "###0.00";
//				DedTotal2Amt7.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt7.OutputFormat = "#,##0";
//				Ded14Amt7.OutputFormat = "#,##0";
//				Ded15Amt7.OutputFormat = "#,##0";
//				Ded16Amt7.OutputFormat = "#,##0";
//				DedTotal2Amt7.OutputFormat = "#,##0";
//			}
//
//			if(DedBnsDispType8.Text == "2")
//			{
//				Ded13Amt8.OutputFormat = "###0";
//				Ded14Amt8.OutputFormat = "###0";
//				Ded15Amt8.OutputFormat = "###0";
//				Ded16Amt8.OutputFormat = "###0";
//				DedTotal2Amt8.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType8.Text == "3")
//			{
//				Ded13Amt8.OutputFormat = "#,##0.00";
//				Ded14Amt8.OutputFormat = "#,##0.00";
//				Ded15Amt8.OutputFormat = "#,##0.00";
//				Ded16Amt8.OutputFormat = "#,##0.00";
//				DedTotal2Amt8.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType8.Text == "4")
//			{
//				Ded13Amt8.OutputFormat = "###0.00";
//				Ded14Amt8.OutputFormat = "###0.00";
//				Ded15Amt8.OutputFormat = "###0.00";
//				Ded16Amt8.OutputFormat = "###0.00";
//				DedTotal2Amt8.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt8.OutputFormat = "#,##0";
//				Ded14Amt8.OutputFormat = "#,##0";
//				Ded15Amt8.OutputFormat = "#,##0";
//				Ded16Amt8.OutputFormat = "#,##0";
//				DedTotal2Amt8.OutputFormat = "#,##0";
//			}
//
//			if(DedBnsDispType9.Text == "2")
//			{
//				Ded13Amt9.OutputFormat = "###0";
//				Ded14Amt9.OutputFormat = "###0";
//				Ded15Amt9.OutputFormat = "###0";
//				Ded16Amt9.OutputFormat = "###0";
//				DedTotal2Amt9.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType9.Text == "3")
//			{
//				Ded13Amt9.OutputFormat = "#,##0.00";
//				Ded14Amt9.OutputFormat = "#,##0.00";
//				Ded15Amt9.OutputFormat = "#,##0.00";
//				Ded16Amt9.OutputFormat = "#,##0.00";
//				DedTotal2Amt9.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType9.Text == "4")
//			{
//				Ded13Amt9.OutputFormat = "###0.00";
//				Ded14Amt9.OutputFormat = "###0.00";
//				Ded15Amt9.OutputFormat = "###0.00";
//				Ded16Amt9.OutputFormat = "###0.00";
//				DedTotal2Amt9.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt9.OutputFormat = "#,##0";
//				Ded14Amt9.OutputFormat = "#,##0";
//				Ded15Amt9.OutputFormat = "#,##0";
//				Ded16Amt9.OutputFormat = "#,##0";
//				DedTotal2Amt9.OutputFormat = "#,##0";
//			}
//
//			if(DedBnsDispType10.Text == "2")
//			{
//				Ded13Amt10.OutputFormat = "###0";
//				Ded14Amt10.OutputFormat = "###0";
//				Ded15Amt10.OutputFormat = "###0";
//				Ded16Amt10.OutputFormat = "###0";
//				DedTotal2Amt10.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType10.Text == "3")
//			{
//				Ded13Amt10.OutputFormat = "#,##0.00";
//				Ded14Amt10.OutputFormat = "#,##0.00";
//				Ded15Amt10.OutputFormat = "#,##0.00";
//				Ded16Amt10.OutputFormat = "#,##0.00";
//				DedTotal2Amt10.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType10.Text == "4")
//			{
//				Ded13Amt10.OutputFormat = "###0.00";
//				Ded14Amt10.OutputFormat = "###0.00";
//				Ded15Amt10.OutputFormat = "###0.00";
//				Ded16Amt10.OutputFormat = "###0.00";
//				DedTotal2Amt10.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt10.OutputFormat = "#,##0";
//				Ded14Amt10.OutputFormat = "#,##0";
//				Ded15Amt10.OutputFormat = "#,##0";
//				Ded16Amt10.OutputFormat = "#,##0";
//				DedTotal2Amt10.OutputFormat = "#,##0";
//			}
//
//			if(DedBnsDispType11.Text == "2")
//			{
//				Ded13Amt11.OutputFormat = "###0";
//				Ded14Amt11.OutputFormat = "###0";
//				Ded15Amt11.OutputFormat = "###0";
//				Ded16Amt11.OutputFormat = "###0";
//				DedTotal2Amt11.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType11.Text == "3")
//			{
//				Ded13Amt11.OutputFormat = "#,##0.00";
//				Ded14Amt11.OutputFormat = "#,##0.00";
//				Ded15Amt11.OutputFormat = "#,##0.00";
//				Ded16Amt11.OutputFormat = "#,##0.00";
//				DedTotal2Amt11.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType11.Text == "4")
//			{
//				Ded13Amt11.OutputFormat = "###0.00";
//				Ded14Amt11.OutputFormat = "###0.00";
//				Ded15Amt11.OutputFormat = "###0.00";
//				Ded16Amt11.OutputFormat = "###0.00";
//				DedTotal2Amt11.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt11.OutputFormat = "#,##0";
//				Ded14Amt11.OutputFormat = "#,##0";
//				Ded15Amt11.OutputFormat = "#,##0";
//				Ded16Amt11.OutputFormat = "#,##0";
//				DedTotal2Amt11.OutputFormat = "#,##0";
//			}
//
//			if(DedBnsDispType12.Text == "2")
//			{
//				Ded13Amt12.OutputFormat = "###0";
//				Ded14Amt12.OutputFormat = "###0";
//				Ded15Amt12.OutputFormat = "###0";
//				Ded16Amt12.OutputFormat = "###0";
//				DedTotal2Amt12.OutputFormat = "###0";
//			}
//			else if(DedBnsDispType12.Text == "3")
//			{
//				Ded13Amt12.OutputFormat = "#,##0.00";
//				Ded14Amt12.OutputFormat = "#,##0.00";
//				Ded15Amt12.OutputFormat = "#,##0.00";
//				Ded16Amt12.OutputFormat = "#,##0.00";
//				DedTotal2Amt12.OutputFormat = "#,##0.00";
//			}
//			else if(DedBnsDispType12.Text == "4")
//			{
//				Ded13Amt12.OutputFormat = "###0.00";
//				Ded14Amt12.OutputFormat = "###0.00";
//				Ded15Amt12.OutputFormat = "###0.00";
//				Ded16Amt12.OutputFormat = "###0.00";
//				DedTotal2Amt12.OutputFormat = "###0.00";
//			}
//			else
//			{
//				Ded13Amt12.OutputFormat = "#,##0";
//				Ded14Amt12.OutputFormat = "#,##0";
//				Ded15Amt12.OutputFormat = "#,##0";
//				Ded16Amt12.OutputFormat = "#,##0";
//				DedTotal2Amt12.OutputFormat = "#,##0";
//			}
// 管理番号 K24565 To
// 管理番号 B15940 To

// 管理番号 K24565 From
// サブレポート化に伴い、HR_PY_06_R98へ移動
//			if(DtyDispType1.Text == "2")
//			{
//				Dty1Num1.OutputFormat = "###0";
//				Dty2Num1.OutputFormat = "###0";
//				Dty3Num1.OutputFormat = "###0";
//				Dty4Num1.OutputFormat = "###0";
//				Dty5Num1.OutputFormat = "###0";
//				Dty6Num1.OutputFormat = "###0";
//				Dty7Num1.OutputFormat = "###0";
//				Dty8Num1.OutputFormat = "###0";
//				Dty9Num1.OutputFormat = "###0";
//				Dty10Num1.OutputFormat = "###0";
//				Dty11Num1.OutputFormat = "###0";
//				Dty12Num1.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal1.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType1.Text == "3")
//			{
//				Dty1Num1.OutputFormat = "#,##0.00";
//				Dty2Num1.OutputFormat = "#,##0.00";
//				Dty3Num1.OutputFormat = "#,##0.00";
//				Dty4Num1.OutputFormat = "#,##0.00";
//				Dty5Num1.OutputFormat = "#,##0.00";
//				Dty6Num1.OutputFormat = "#,##0.00";
//				Dty7Num1.OutputFormat = "#,##0.00";
//				Dty8Num1.OutputFormat = "#,##0.00";
//				Dty9Num1.OutputFormat = "#,##0.00";
//				Dty10Num1.OutputFormat = "#,##0.00";
//				Dty11Num1.OutputFormat = "#,##0.00";
//				Dty12Num1.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal1.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//
//			}
//
//			else if(DtyDispType1.Text == "4")
//			{
//				Dty1Num1.OutputFormat = "###0.00";
//				Dty2Num1.OutputFormat = "###0.00";
//				Dty3Num1.OutputFormat = "###0.00";
//				Dty4Num1.OutputFormat = "###0.00";
//				Dty5Num1.OutputFormat = "###0.00";
//				Dty6Num1.OutputFormat = "###0.00";
//				Dty7Num1.OutputFormat = "###0.00";
//				Dty8Num1.OutputFormat = "###0.00";
//				Dty9Num1.OutputFormat = "###0.00";
//				Dty10Num1.OutputFormat = "###0.00";
//				Dty11Num1.OutputFormat = "###0.00";
//				Dty12Num1.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal1.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num1.OutputFormat = "#,##0.00";
////				Dty2Num1.OutputFormat = "#,##0.00";
////				Dty3Num1.OutputFormat = "#,##0.00";
////				Dty4Num1.OutputFormat = "#,##0.00";
////				Dty5Num1.OutputFormat = "#,##0.00";
////				Dty6Num1.OutputFormat = "#,##0.00";
////				Dty7Num1.OutputFormat = "#,##0.00";
////				Dty8Num1.OutputFormat = "#,##0.00";
////				Dty9Num1.OutputFormat = "#,##0.00";
////				Dty10Num1.OutputFormat = "#,##0.00";
////				Dty11Num1.OutputFormat = "#,##0.00";
////				Dty12Num1.OutputFormat = "#,##0.00";
//
//				Dty1Num1.OutputFormat = "#,##0";
//				Dty2Num1.OutputFormat = "#,##0";
//				Dty3Num1.OutputFormat = "#,##0";
//				Dty4Num1.OutputFormat = "#,##0";
//				Dty5Num1.OutputFormat = "#,##0";
//				Dty6Num1.OutputFormat = "#,##0";
//				Dty7Num1.OutputFormat = "#,##0";
//				Dty8Num1.OutputFormat = "#,##0";
//				Dty9Num1.OutputFormat = "#,##0";
//				Dty10Num1.OutputFormat = "#,##0";
//				Dty11Num1.OutputFormat = "#,##0";
//				Dty12Num1.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal1.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyDispType2.Text == "2")
//			{
//				Dty1Num2.OutputFormat = "###0";
//				Dty2Num2.OutputFormat = "###0";
//				Dty3Num2.OutputFormat = "###0";
//				Dty4Num2.OutputFormat = "###0";
//				Dty5Num2.OutputFormat = "###0";
//				Dty6Num2.OutputFormat = "###0";
//				Dty7Num2.OutputFormat = "###0";
//				Dty8Num2.OutputFormat = "###0";
//				Dty9Num2.OutputFormat = "###0";
//				Dty10Num2.OutputFormat = "###0";
//				Dty11Num2.OutputFormat = "###0";
//				Dty12Num2.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal2.OutputFormat = "###0";
//// 管理番号 B24534 To
//
//			}
//
//			else if(DtyDispType2.Text == "3")
//			{
//				Dty1Num2.OutputFormat = "#,##0.00";
//				Dty2Num2.OutputFormat = "#,##0.00";
//				Dty3Num2.OutputFormat = "#,##0.00";
//				Dty4Num2.OutputFormat = "#,##0.00";
//				Dty5Num2.OutputFormat = "#,##0.00";
//				Dty6Num2.OutputFormat = "#,##0.00";
//				Dty7Num2.OutputFormat = "#,##0.00";
//				Dty8Num2.OutputFormat = "#,##0.00";
//				Dty9Num2.OutputFormat = "#,##0.00";
//				Dty10Num2.OutputFormat = "#,##0.00";
//				Dty11Num2.OutputFormat = "#,##0.00";
//				Dty12Num2.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal2.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType2.Text == "4")
//			{
//				Dty1Num2.OutputFormat = "###0.00";
//				Dty2Num2.OutputFormat = "###0.00";
//				Dty3Num2.OutputFormat = "###0.00";
//				Dty4Num2.OutputFormat = "###0.00";
//				Dty5Num2.OutputFormat = "###0.00";
//				Dty6Num2.OutputFormat = "###0.00";
//				Dty7Num2.OutputFormat = "###0.00";
//				Dty8Num2.OutputFormat = "###0.00";
//				Dty9Num2.OutputFormat = "###0.00";
//				Dty10Num2.OutputFormat = "###0.00";
//				Dty11Num2.OutputFormat = "###0.00";
//				Dty12Num2.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal2.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num2.OutputFormat = "#,##0.00";
////				Dty2Num2.OutputFormat = "#,##0.00";
////				Dty3Num2.OutputFormat = "#,##0.00";
////				Dty4Num2.OutputFormat = "#,##0.00";
////				Dty5Num2.OutputFormat = "#,##0.00";
////				Dty6Num2.OutputFormat = "#,##0.00";
////				Dty7Num2.OutputFormat = "#,##0.00";
////				Dty8Num2.OutputFormat = "#,##0.00";
////				Dty9Num2.OutputFormat = "#,##0.00";
////				Dty10Num2.OutputFormat = "#,##0.00";
////				Dty11Num2.OutputFormat = "#,##0.00";
////				Dty12Num2.OutputFormat = "#,##0.00";
//
//				Dty1Num2.OutputFormat = "#,##0";
//				Dty2Num2.OutputFormat = "#,##0";
//				Dty3Num2.OutputFormat = "#,##0";
//				Dty4Num2.OutputFormat = "#,##0";
//				Dty5Num2.OutputFormat = "#,##0";
//				Dty6Num2.OutputFormat = "#,##0";
//				Dty7Num2.OutputFormat = "#,##0";
//				Dty8Num2.OutputFormat = "#,##0";
//				Dty9Num2.OutputFormat = "#,##0";
//				Dty10Num2.OutputFormat = "#,##0";
//				Dty11Num2.OutputFormat = "#,##0";
//				Dty12Num2.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal2.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyDispType3.Text == "2")
//			{
//				Dty1Num3.OutputFormat = "###0";
//				Dty2Num3.OutputFormat = "###0";
//				Dty3Num3.OutputFormat = "###0";
//				Dty4Num3.OutputFormat = "###0";
//				Dty5Num3.OutputFormat = "###0";
//				Dty6Num3.OutputFormat = "###0";
//				Dty7Num3.OutputFormat = "###0";
//				Dty8Num3.OutputFormat = "###0";
//				Dty9Num3.OutputFormat = "###0";
//				Dty10Num3.OutputFormat = "###0";
//				Dty11Num3.OutputFormat = "###0";
//				Dty12Num3.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal3.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType3.Text == "3")
//			{
//				Dty1Num3.OutputFormat = "#,##0.00";
//				Dty2Num3.OutputFormat = "#,##0.00";
//				Dty3Num3.OutputFormat = "#,##0.00";
//				Dty4Num3.OutputFormat = "#,##0.00";
//				Dty5Num3.OutputFormat = "#,##0.00";
//				Dty6Num3.OutputFormat = "#,##0.00";
//				Dty7Num3.OutputFormat = "#,##0.00";
//				Dty8Num3.OutputFormat = "#,##0.00";
//				Dty9Num3.OutputFormat = "#,##0.00";
//				Dty10Num3.OutputFormat = "#,##0.00";
//				Dty11Num3.OutputFormat = "#,##0.00";
//				Dty12Num3.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal3.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType3.Text == "4")
//			{
//				Dty1Num3.OutputFormat = "###0.00";
//				Dty2Num3.OutputFormat = "###0.00";
//				Dty3Num3.OutputFormat = "###0.00";
//				Dty4Num3.OutputFormat = "###0.00";
//				Dty5Num3.OutputFormat = "###0.00";
//				Dty6Num3.OutputFormat = "###0.00";
//				Dty7Num3.OutputFormat = "###0.00";
//				Dty8Num3.OutputFormat = "###0.00";
//				Dty9Num3.OutputFormat = "###0.00";
//				Dty10Num3.OutputFormat = "###0.00";
//				Dty11Num3.OutputFormat = "###0.00";
//				Dty12Num3.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal3.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num3.OutputFormat = "#,##0.00";
////				Dty2Num3.OutputFormat = "#,##0.00";
////				Dty3Num3.OutputFormat = "#,##0.00";
////				Dty4Num3.OutputFormat = "#,##0.00";
////				Dty5Num3.OutputFormat = "#,##0.00";
////				Dty6Num3.OutputFormat = "#,##0.00";
////				Dty7Num3.OutputFormat = "#,##0.00";
////				Dty8Num3.OutputFormat = "#,##0.00";
////				Dty9Num3.OutputFormat = "#,##0.00";
////				Dty10Num3.OutputFormat = "#,##0.00";
////				Dty11Num3.OutputFormat = "#,##0.00";
////				Dty12Num3.OutputFormat = "#,##0.00";
//
//				Dty1Num3.OutputFormat = "#,##0";
//				Dty2Num3.OutputFormat = "#,##0";
//				Dty3Num3.OutputFormat = "#,##0";
//				Dty4Num3.OutputFormat = "#,##0";
//				Dty5Num3.OutputFormat = "#,##0";
//				Dty6Num3.OutputFormat = "#,##0";
//				Dty7Num3.OutputFormat = "#,##0";
//				Dty8Num3.OutputFormat = "#,##0";
//				Dty9Num3.OutputFormat = "#,##0";
//				Dty10Num3.OutputFormat = "#,##0";
//				Dty11Num3.OutputFormat = "#,##0";
//				Dty12Num3.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal3.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyDispType4.Text == "2")
//			{
//				Dty1Num4.OutputFormat = "###0";
//				Dty2Num4.OutputFormat = "###0";
//				Dty3Num4.OutputFormat = "###0";
//				Dty4Num4.OutputFormat = "###0";
//				Dty5Num4.OutputFormat = "###0";
//				Dty6Num4.OutputFormat = "###0";
//				Dty7Num4.OutputFormat = "###0";
//				Dty8Num4.OutputFormat = "###0";
//				Dty9Num4.OutputFormat = "###0";
//				Dty10Num4.OutputFormat = "###0";
//				Dty11Num4.OutputFormat = "###0";
//				Dty12Num4.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal4.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType4.Text == "3")
//			{
//				Dty1Num4.OutputFormat = "#,##0.00";
//				Dty2Num4.OutputFormat = "#,##0.00";
//				Dty3Num4.OutputFormat = "#,##0.00";
//				Dty4Num4.OutputFormat = "#,##0.00";
//				Dty5Num4.OutputFormat = "#,##0.00";
//				Dty6Num4.OutputFormat = "#,##0.00";
//				Dty7Num4.OutputFormat = "#,##0.00";
//				Dty8Num4.OutputFormat = "#,##0.00";
//				Dty9Num4.OutputFormat = "#,##0.00";
//				Dty10Num4.OutputFormat = "#,##0.00";
//				Dty11Num4.OutputFormat = "#,##0.00";
//				Dty12Num4.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal4.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType4.Text == "4")
//			{
//				Dty1Num4.OutputFormat = "###0.00";
//				Dty2Num4.OutputFormat = "###0.00";
//				Dty3Num4.OutputFormat = "###0.00";
//				Dty4Num4.OutputFormat = "###0.00";
//				Dty5Num4.OutputFormat = "###0.00";
//				Dty6Num4.OutputFormat = "###0.00";
//				Dty7Num4.OutputFormat = "###0.00";
//				Dty8Num4.OutputFormat = "###0.00";
//				Dty9Num4.OutputFormat = "###0.00";
//				Dty10Num4.OutputFormat = "###0.00";
//				Dty11Num4.OutputFormat = "###0.00";
//				Dty12Num4.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal4.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//				Dty1Num4.OutputFormat = "#,##0";
//				Dty2Num4.OutputFormat = "#,##0";
//				Dty3Num4.OutputFormat = "#,##0";
//				Dty4Num4.OutputFormat = "#,##0";
//				Dty5Num4.OutputFormat = "#,##0";
//				Dty6Num4.OutputFormat = "#,##0";
//				Dty7Num4.OutputFormat = "#,##0";
//				Dty8Num4.OutputFormat = "#,##0";
//				Dty9Num4.OutputFormat = "#,##0";
//				Dty10Num4.OutputFormat = "#,##0";
//				Dty11Num4.OutputFormat = "#,##0";
//				Dty12Num4.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal4.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//			}
//
//			if(DtyDispType5.Text == "2")
//			{
//				Dty1Num5.OutputFormat = "###0";
//				Dty2Num5.OutputFormat = "###0";
//				Dty3Num5.OutputFormat = "###0";
//				Dty4Num5.OutputFormat = "###0";
//				Dty5Num5.OutputFormat = "###0";
//				Dty6Num5.OutputFormat = "###0";
//				Dty7Num5.OutputFormat = "###0";
//				Dty8Num5.OutputFormat = "###0";
//				Dty9Num5.OutputFormat = "###0";
//				Dty10Num5.OutputFormat = "###0";
//				Dty11Num5.OutputFormat = "###0";
//				Dty12Num5.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal5.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType5.Text == "3")
//			{
//				Dty1Num5.OutputFormat = "#,##0.00";
//				Dty2Num5.OutputFormat = "#,##0.00";
//				Dty3Num5.OutputFormat = "#,##0.00";
//				Dty4Num5.OutputFormat = "#,##0.00";
//				Dty5Num5.OutputFormat = "#,##0.00";
//				Dty6Num5.OutputFormat = "#,##0.00";
//				Dty7Num5.OutputFormat = "#,##0.00";
//				Dty8Num5.OutputFormat = "#,##0.00";
//				Dty9Num5.OutputFormat = "#,##0.00";
//				Dty10Num5.OutputFormat = "#,##0.00";
//				Dty11Num5.OutputFormat = "#,##0.00";
//				Dty12Num5.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal5.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType5.Text == "4")
//			{
//				Dty1Num5.OutputFormat = "###0.00";
//				Dty2Num5.OutputFormat = "###0.00";
//				Dty3Num5.OutputFormat = "###0.00";
//				Dty4Num5.OutputFormat = "###0.00";
//				Dty5Num5.OutputFormat = "###0.00";
//				Dty6Num5.OutputFormat = "###0.00";
//				Dty7Num5.OutputFormat = "###0.00";
//				Dty8Num5.OutputFormat = "###0.00";
//				Dty9Num5.OutputFormat = "###0.00";
//				Dty10Num5.OutputFormat = "###0.00";
//				Dty11Num5.OutputFormat = "###0.00";
//				Dty12Num5.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal5.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num5.OutputFormat = "#,##0.00";
////				Dty2Num5.OutputFormat = "#,##0.00";
////				Dty3Num5.OutputFormat = "#,##0.00";
////				Dty4Num5.OutputFormat = "#,##0.00";
////				Dty5Num5.OutputFormat = "#,##0.00";
////				Dty6Num5.OutputFormat = "#,##0.00";
////				Dty7Num5.OutputFormat = "#,##0.00";
////				Dty8Num5.OutputFormat = "#,##0.00";
////				Dty9Num5.OutputFormat = "#,##0.00";
////				Dty10Num5.OutputFormat = "#,##0.00";
////				Dty11Num5.OutputFormat = "#,##0.00";
////				Dty12Num5.OutputFormat = "#,##0.00";
//
//				Dty1Num5.OutputFormat = "#,##0";
//				Dty2Num5.OutputFormat = "#,##0";
//				Dty3Num5.OutputFormat = "#,##0";
//				Dty4Num5.OutputFormat = "#,##0";
//				Dty5Num5.OutputFormat = "#,##0";
//				Dty6Num5.OutputFormat = "#,##0";
//				Dty7Num5.OutputFormat = "#,##0";
//				Dty8Num5.OutputFormat = "#,##0";
//				Dty9Num5.OutputFormat = "#,##0";
//				Dty10Num5.OutputFormat = "#,##0";
//				Dty11Num5.OutputFormat = "#,##0";
//				Dty12Num5.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal5.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyDispType6.Text == "2")
//			{
//				Dty1Num6.OutputFormat = "###0";
//				Dty2Num6.OutputFormat = "###0";
//				Dty3Num6.OutputFormat = "###0";
//				Dty4Num6.OutputFormat = "###0";
//				Dty5Num6.OutputFormat = "###0";
//				Dty6Num6.OutputFormat = "###0";
//				Dty7Num6.OutputFormat = "###0";
//				Dty8Num6.OutputFormat = "###0";
//				Dty9Num6.OutputFormat = "###0";
//				Dty10Num6.OutputFormat = "###0";
//				Dty11Num6.OutputFormat = "###0";
//				Dty12Num6.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal6.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType6.Text == "3")
//			{
//				Dty1Num6.OutputFormat = "#,##0.00";
//				Dty2Num6.OutputFormat = "#,##0.00";
//				Dty3Num6.OutputFormat = "#,##0.00";
//				Dty4Num6.OutputFormat = "#,##0.00";
//				Dty5Num6.OutputFormat = "#,##0.00";
//				Dty6Num6.OutputFormat = "#,##0.00";
//				Dty7Num6.OutputFormat = "#,##0.00";
//				Dty8Num6.OutputFormat = "#,##0.00";
//				Dty9Num6.OutputFormat = "#,##0.00";
//				Dty10Num6.OutputFormat = "#,##0.00";
//				Dty11Num6.OutputFormat = "#,##0.00";
//				Dty12Num6.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal6.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType6.Text == "4")
//			{
//				Dty1Num6.OutputFormat = "###0.00";
//				Dty2Num6.OutputFormat = "###0.00";
//				Dty3Num6.OutputFormat = "###0.00";
//				Dty4Num6.OutputFormat = "###0.00";
//				Dty5Num6.OutputFormat = "###0.00";
//				Dty6Num6.OutputFormat = "###0.00";
//				Dty7Num6.OutputFormat = "###0.00";
//				Dty8Num6.OutputFormat = "###0.00";
//				Dty9Num6.OutputFormat = "###0.00";
//				Dty10Num6.OutputFormat = "###0.00";
//				Dty11Num6.OutputFormat = "###0.00";
//				Dty12Num6.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal6.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num6.OutputFormat = "#,##0.00";
////				Dty2Num6.OutputFormat = "#,##0.00";
////				Dty3Num6.OutputFormat = "#,##0.00";
////				Dty4Num6.OutputFormat = "#,##0.00";
////				Dty5Num6.OutputFormat = "#,##0.00";
////				Dty6Num6.OutputFormat = "#,##0.00";
////				Dty7Num6.OutputFormat = "#,##0.00";
////				Dty8Num6.OutputFormat = "#,##0.00";
////				Dty9Num6.OutputFormat = "#,##0.00";
////				Dty10Num6.OutputFormat = "#,##0.00";
////				Dty11Num6.OutputFormat = "#,##0.00";
////				Dty12Num6.OutputFormat = "#,##0.00";
//
//				Dty1Num6.OutputFormat = "#,##0";
//				Dty2Num6.OutputFormat = "#,##0";
//				Dty3Num6.OutputFormat = "#,##0";
//				Dty4Num6.OutputFormat = "#,##0";
//				Dty5Num6.OutputFormat = "#,##0";
//				Dty6Num6.OutputFormat = "#,##0";
//				Dty7Num6.OutputFormat = "#,##0";
//				Dty8Num6.OutputFormat = "#,##0";
//				Dty9Num6.OutputFormat = "#,##0";
//				Dty10Num6.OutputFormat = "#,##0";
//				Dty11Num6.OutputFormat = "#,##0";
//				Dty12Num6.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal6.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To			
//			}
//
//			if(DtyDispType7.Text == "2")
//			{
//				Dty1Num7.OutputFormat = "###0";
//				Dty2Num7.OutputFormat = "###0";
//				Dty3Num7.OutputFormat = "###0";
//				Dty4Num7.OutputFormat = "###0";
//				Dty5Num7.OutputFormat = "###0";
//				Dty6Num7.OutputFormat = "###0";
//				Dty7Num7.OutputFormat = "###0";
//				Dty8Num7.OutputFormat = "###0";
//				Dty9Num7.OutputFormat = "###0";
//				Dty10Num7.OutputFormat = "###0";
//				Dty11Num7.OutputFormat = "###0";
//				Dty12Num7.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal7.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType7.Text == "3")
//			{
//				Dty1Num7.OutputFormat = "#,##0.00";
//				Dty2Num7.OutputFormat = "#,##0.00";
//				Dty3Num7.OutputFormat = "#,##0.00";
//				Dty4Num7.OutputFormat = "#,##0.00";
//				Dty5Num7.OutputFormat = "#,##0.00";
//				Dty6Num7.OutputFormat = "#,##0.00";
//				Dty7Num7.OutputFormat = "#,##0.00";
//				Dty8Num7.OutputFormat = "#,##0.00";
//				Dty9Num7.OutputFormat = "#,##0.00";
//				Dty10Num7.OutputFormat = "#,##0.00";
//				Dty11Num7.OutputFormat = "#,##0.00";
//				Dty12Num7.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal7.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType7.Text == "4")
//			{
//				Dty1Num7.OutputFormat = "###0.00";
//				Dty2Num7.OutputFormat = "###0.00";
//				Dty3Num7.OutputFormat = "###0.00";
//				Dty4Num7.OutputFormat = "###0.00";
//				Dty5Num7.OutputFormat = "###0.00";
//				Dty6Num7.OutputFormat = "###0.00";
//				Dty7Num7.OutputFormat = "###0.00";
//				Dty8Num7.OutputFormat = "###0.00";
//				Dty9Num7.OutputFormat = "###0.00";
//				Dty10Num7.OutputFormat = "###0.00";
//				Dty11Num7.OutputFormat = "###0.00";
//				Dty12Num7.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal7.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
////				Dty1Num7.OutputFormat = "#,##0.00";
////				Dty2Num7.OutputFormat = "#,##0.00";
////				Dty3Num7.OutputFormat = "#,##0.00";
////				Dty4Num7.OutputFormat = "#,##0.00";
////				Dty5Num7.OutputFormat = "#,##0.00";
////				Dty6Num7.OutputFormat = "#,##0.00";
////				Dty7Num7.OutputFormat = "#,##0.00";
////				Dty8Num7.OutputFormat = "#,##0.00";
////				Dty9Num7.OutputFormat = "#,##0.00";
////				Dty10Num7.OutputFormat = "#,##0.00";
////				Dty11Num7.OutputFormat = "#,##0.00";
////				Dty12Num7.OutputFormat = "#,##0.00";
//				
//				Dty1Num7.OutputFormat = "#,##0";
//				Dty2Num7.OutputFormat = "#,##0";
//				Dty3Num7.OutputFormat = "#,##0";
//				Dty4Num7.OutputFormat = "#,##0";
//				Dty5Num7.OutputFormat = "#,##0";
//				Dty6Num7.OutputFormat = "#,##0";
//				Dty7Num7.OutputFormat = "#,##0";
//				Dty8Num7.OutputFormat = "#,##0";
//				Dty9Num7.OutputFormat = "#,##0";
//				Dty10Num7.OutputFormat = "#,##0";
//				Dty11Num7.OutputFormat = "#,##0";
//				Dty12Num7.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal7.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyDispType8.Text == "2")
//			{
//				Dty1Num8.OutputFormat = "###0";
//				Dty2Num8.OutputFormat = "###0";
//				Dty3Num8.OutputFormat = "###0";
//				Dty4Num8.OutputFormat = "###0";
//				Dty5Num8.OutputFormat = "###0";
//				Dty6Num8.OutputFormat = "###0";
//				Dty7Num8.OutputFormat = "###0";
//				Dty8Num8.OutputFormat = "###0";
//				Dty9Num8.OutputFormat = "###0";
//				Dty10Num8.OutputFormat = "###0";
//				Dty11Num8.OutputFormat = "###0";
//				Dty12Num8.OutputFormat = "###0";
//// 管理番号 B24534 From
//				DtyTotal8.OutputFormat = "###0";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType8.Text == "3")
//			{
//				Dty1Num8.OutputFormat = "#,##0.00";
//				Dty2Num8.OutputFormat = "#,##0.00";
//				Dty3Num8.OutputFormat = "#,##0.00";
//				Dty4Num8.OutputFormat = "#,##0.00";
//				Dty5Num8.OutputFormat = "#,##0.00";
//				Dty6Num8.OutputFormat = "#,##0.00";
//				Dty7Num8.OutputFormat = "#,##0.00";
//				Dty8Num8.OutputFormat = "#,##0.00";
//				Dty9Num8.OutputFormat = "#,##0.00";
//				Dty10Num8.OutputFormat = "#,##0.00";
//				Dty11Num8.OutputFormat = "#,##0.00";
//				Dty12Num8.OutputFormat = "#,##0.00";
//// 管理番号 B24534 From
//				DtyTotal8.OutputFormat = "#,##0.00";
//// 管理番号 B24534 To
//			}
//
//			else if(DtyDispType8.Text == "4")
//			{
//				Dty1Num8.OutputFormat = "###0.00";
//				Dty2Num8.OutputFormat = "###0.00";
//				Dty3Num8.OutputFormat = "###0.00";
//				Dty4Num8.OutputFormat = "###0.00";
//				Dty5Num8.OutputFormat = "###0.00";
//				Dty6Num8.OutputFormat = "###0.00";
//				Dty7Num8.OutputFormat = "###0.00";
//				Dty8Num8.OutputFormat = "###0.00";
//				Dty9Num8.OutputFormat = "###0.00";
//				Dty10Num8.OutputFormat = "###0.00";
//				Dty11Num8.OutputFormat = "###0.00";
//				Dty12Num8.OutputFormat = "###0.00";
//// 管理番号 B24534 From
//				DtyTotal8.OutputFormat = "###0.00";
//// 管理番号 B24534 To
//			}
//
//			else
//			{
//// 管理番号 B14921 From
//				//Dty1Num8.OutputFormat = "#,##0.00";
//				//Dty2Num8.OutputFormat = "#,##0.00";
//				//Dty3Num8.OutputFormat = "#,##0.00";
//				//Dty4Num8.OutputFormat = "#,##0.00";
//				//Dty5Num8.OutputFormat = "#,##0.00";
//				//Dty6Num8.OutputFormat = "#,##0.00";
//				//Dty7Num8.OutputFormat = "#,##0.00";
//				//Dty8Num8.OutputFormat = "#,##0.00";
//				//Dty9Num8.OutputFormat = "#,##0.00";
//				//Dty10Num8.OutputFormat = "#,##0.00";
//				//Dty11Num8.OutputFormat = "#,##0.00";
//				//Dty12Num8.OutputFormat = "#,##0.00";
//
//				Dty1Num8.OutputFormat = "#,##0";
//				Dty2Num8.OutputFormat = "#,##0";
//				Dty3Num8.OutputFormat = "#,##0";
//				Dty4Num8.OutputFormat = "#,##0";
//				Dty5Num8.OutputFormat = "#,##0";
//				Dty6Num8.OutputFormat = "#,##0";
//				Dty7Num8.OutputFormat = "#,##0";
//				Dty8Num8.OutputFormat = "#,##0";
//				Dty9Num8.OutputFormat = "#,##0";
//				Dty10Num8.OutputFormat = "#,##0";
//				Dty11Num8.OutputFormat = "#,##0";
//				Dty12Num8.OutputFormat = "#,##0";
//// 管理番号 B24534 From
//				DtyTotal8.OutputFormat = "#,##0";
//// 管理番号 B24534 To
//// 管理番号 B14921 To
//			}
//
//			if(DtyName1.Text == string.Empty)
//			{
//				Dty1Num1.OutputFormat = string.Empty;
//				Dty2Num1.OutputFormat = string.Empty;
//				Dty3Num1.OutputFormat = string.Empty;
//				Dty4Num1.OutputFormat = string.Empty;
//				Dty5Num1.OutputFormat = string.Empty;
//				Dty6Num1.OutputFormat = string.Empty;
//				Dty7Num1.OutputFormat = string.Empty;
//				Dty8Num1.OutputFormat = string.Empty;
//				Dty9Num1.OutputFormat = string.Empty;
//				Dty10Num1.OutputFormat = string.Empty;
//				Dty11Num1.OutputFormat = string.Empty;
//				Dty12Num1.OutputFormat = string.Empty;
//				DtyTotal1.OutputFormat = string.Empty;
//
//				Dty1Num1.Text = string.Empty;
//				Dty2Num1.Text = string.Empty;
//				Dty3Num1.Text = string.Empty;
//				Dty4Num1.Text = string.Empty;
//				Dty5Num1.Text = string.Empty;
//				Dty6Num1.Text = string.Empty;
//				Dty7Num1.Text = string.Empty;
//				Dty8Num1.Text = string.Empty;
//				Dty9Num1.Text = string.Empty;
//				Dty10Num1.Text = string.Empty;
//				Dty11Num1.Text = string.Empty;
//				Dty12Num1.Text = string.Empty;
//				DtyTotal1.Text = string.Empty;
//					
//			}
//
//			if(DtyName2.Text == string.Empty)
//			{
//				Dty1Num2.OutputFormat = "###";
//				Dty2Num2.OutputFormat = "###";
//				Dty3Num2.OutputFormat = "###";
//				Dty4Num2.OutputFormat = "###";
//				Dty5Num2.OutputFormat = "###";
//				Dty6Num2.OutputFormat = "###";
//				Dty7Num2.OutputFormat = "###";
//				Dty8Num2.OutputFormat = "###";
//				Dty9Num2.OutputFormat = "###";
//				Dty10Num2.OutputFormat = "###";
//				Dty11Num2.OutputFormat = "###";
//				Dty12Num2.OutputFormat = "###";
//				DtyTotal2.OutputFormat = "###";
//
//				Dty1Num2.Text = string.Empty;
//				Dty2Num2.Text = string.Empty;
//				Dty3Num2.Text = string.Empty;
//				Dty4Num2.Text = string.Empty;
//				Dty5Num2.Text = string.Empty;
//				Dty6Num2.Text = string.Empty;
//				Dty7Num2.Text = string.Empty;
//				Dty8Num2.Text = string.Empty;
//				Dty9Num2.Text = string.Empty;
//				Dty10Num2.Text = string.Empty;
//				Dty11Num2.Text = string.Empty;
//				Dty12Num2.Text = string.Empty;
//				DtyTotal2.Text = string.Empty;
//			}
//			
//			if(DtyName3.Text == string.Empty)
//			{
//				Dty1Num3.OutputFormat = "###";
//				Dty2Num3.OutputFormat = "###";
//				Dty3Num3.OutputFormat = "###";
//				Dty4Num3.OutputFormat = "###";
//				Dty5Num3.OutputFormat = "###";
//				Dty6Num3.OutputFormat = "###";
//				Dty7Num3.OutputFormat = "###";
//				Dty8Num3.OutputFormat = "###";
//				Dty9Num3.OutputFormat = "###";
//				Dty10Num3.OutputFormat = "###";
//				Dty11Num3.OutputFormat = "###";
//				Dty12Num3.OutputFormat = "###";
//				DtyTotal3.OutputFormat = "###";
//
//				Dty1Num3.Text = string.Empty;
//				Dty2Num3.Text = string.Empty;
//				Dty3Num3.Text = string.Empty;
//				Dty4Num3.Text = string.Empty;
//				Dty5Num3.Text = string.Empty;
//				Dty6Num3.Text = string.Empty;
//				Dty7Num3.Text = string.Empty;
//				Dty8Num3.Text = string.Empty;
//				Dty9Num3.Text = string.Empty;
//				Dty10Num3.Text = string.Empty;
//				Dty11Num3.Text = string.Empty;
//				Dty12Num3.Text = string.Empty;
//				DtyTotal3.Text = string.Empty;
//			}
//		
//			if(DtyName4.Text == string.Empty)
//			{
//				Dty1Num4.OutputFormat = "###";
//				Dty2Num4.OutputFormat = "###";
//				Dty3Num4.OutputFormat = "###";
//				Dty4Num4.OutputFormat = "###";
//				Dty5Num4.OutputFormat = "###";
//				Dty6Num4.OutputFormat = "###";
//				Dty7Num4.OutputFormat = "###";
//				Dty8Num4.OutputFormat = "###";
//				Dty9Num4.OutputFormat = "###";
//				Dty10Num4.OutputFormat = "###";
//				Dty11Num4.OutputFormat = "###";
//				Dty12Num4.OutputFormat = "###";
//				DtyTotal4.OutputFormat = "###";
//
//				Dty1Num4.Text = string.Empty;
//				Dty2Num4.Text = string.Empty;
//				Dty3Num4.Text = string.Empty;
//				Dty4Num4.Text = string.Empty;
//				Dty5Num4.Text = string.Empty;
//				Dty6Num4.Text = string.Empty;
//				Dty7Num4.Text = string.Empty;
//				Dty8Num4.Text = string.Empty;
//				Dty9Num4.Text = string.Empty;
//				Dty10Num4.Text = string.Empty;
//				Dty11Num4.Text = string.Empty;
//				Dty12Num4.Text = string.Empty;
//				DtyTotal4.Text = string.Empty;
//			}
//
//			if(DtyName5.Text == string.Empty)
//			{
//				Dty1Num5.OutputFormat = "###";
//				Dty2Num5.OutputFormat = "###";
//				Dty3Num5.OutputFormat = "###";
//				Dty4Num5.OutputFormat = "###";
//				Dty5Num5.OutputFormat = "###";
//				Dty6Num5.OutputFormat = "###";
//				Dty7Num5.OutputFormat = "###";
//				Dty8Num5.OutputFormat = "###";
//				Dty9Num5.OutputFormat = "###";
//				Dty10Num5.OutputFormat = "###";
//				Dty11Num5.OutputFormat = "###";
//				Dty12Num5.OutputFormat = "###";
//				DtyTotal5.OutputFormat = "###";
//
//				Dty1Num5.Text = string.Empty;
//				Dty2Num5.Text = string.Empty;
//				Dty3Num5.Text = string.Empty;
//				Dty4Num5.Text = string.Empty;
//				Dty5Num5.Text = string.Empty;
//				Dty6Num5.Text = string.Empty;
//				Dty7Num5.Text = string.Empty;
//				Dty8Num5.Text = string.Empty;
//				Dty9Num5.Text = string.Empty;
//				Dty10Num5.Text = string.Empty;
//				Dty11Num5.Text = string.Empty;
//				Dty12Num5.Text = string.Empty;
//				DtyTotal5.Text = string.Empty;
//			}
//			
//			if(DtyName6.Text == string.Empty)
//			{
//				Dty1Num6.OutputFormat = "###";
//				Dty2Num6.OutputFormat = "###";
//				Dty3Num6.OutputFormat = "###";
//				Dty4Num6.OutputFormat = "###";
//				Dty5Num6.OutputFormat = "###";
//				Dty6Num6.OutputFormat = "###";
//				Dty7Num6.OutputFormat = "###";
//				Dty8Num6.OutputFormat = "###";
//				Dty9Num6.OutputFormat = "###";
//				Dty10Num6.OutputFormat = "###";
//				Dty11Num6.OutputFormat = "###";
//				Dty12Num6.OutputFormat = "###";
//				DtyTotal6.OutputFormat = "###";
//
//				Dty1Num6.Text = string.Empty;
//				Dty2Num6.Text = string.Empty;
//				Dty3Num6.Text = string.Empty;
//				Dty4Num6.Text = string.Empty;
//				Dty5Num6.Text = string.Empty;
//				Dty6Num6.Text = string.Empty;
//				Dty7Num6.Text = string.Empty;
//				Dty8Num6.Text = string.Empty;
//				Dty9Num6.Text = string.Empty;
//				Dty10Num6.Text = string.Empty;
//				Dty11Num6.Text = string.Empty;
//				Dty12Num6.Text = string.Empty;
//				DtyTotal6.Text = string.Empty;
//			}
//
//			if(DtyName7.Text == string.Empty)
//			{
//				Dty1Num7.OutputFormat = "###";
//				Dty2Num7.OutputFormat = "###";
//				Dty3Num7.OutputFormat = "###";
//				Dty4Num7.OutputFormat = "###";
//				Dty5Num7.OutputFormat = "###";
//				Dty6Num7.OutputFormat = "###";
//				Dty7Num7.OutputFormat = "###";
//				Dty8Num7.OutputFormat = "###";
//				Dty9Num7.OutputFormat = "###";
//				Dty10Num7.OutputFormat = "###";
//				Dty11Num7.OutputFormat = "###";
//				Dty12Num7.OutputFormat = "###";
//				DtyTotal7.OutputFormat = "###";
//
//				Dty1Num7.Text = string.Empty;
//				Dty2Num7.Text = string.Empty;
//				Dty3Num7.Text = string.Empty;
//				Dty4Num7.Text = string.Empty;
//				Dty5Num7.Text = string.Empty;
//				Dty6Num7.Text = string.Empty;
//				Dty7Num7.Text = string.Empty;
//				Dty8Num7.Text = string.Empty;
//				Dty9Num7.Text = string.Empty;
//				Dty10Num7.Text = string.Empty;
//				Dty11Num7.Text = string.Empty;
//				Dty12Num7.Text = string.Empty;
//				DtyTotal7.Text = string.Empty;
//			}
//
//			if(DtyName8.Text == string.Empty)
//			{
//				Dty1Num8.OutputFormat = "###";
//				Dty2Num8.OutputFormat = "###";
//				Dty3Num8.OutputFormat = "###";
//				Dty4Num8.OutputFormat = "###";
//				Dty5Num8.OutputFormat = "###";
//				Dty6Num8.OutputFormat = "###";
//				Dty7Num8.OutputFormat = "###";
//				Dty8Num8.OutputFormat = "###";
//				Dty9Num8.OutputFormat = "###";
//				Dty10Num8.OutputFormat = "###";
//				Dty11Num8.OutputFormat = "###";
//				Dty12Num8.OutputFormat = "###";
//				DtyTotal8.OutputFormat = "###";
//
//				Dty1Num8.Text = string.Empty;
//				Dty2Num8.Text = string.Empty;
//				Dty3Num8.Text = string.Empty;
//				Dty4Num8.Text = string.Empty;
//				Dty5Num8.Text = string.Empty;
//				Dty6Num8.Text = string.Empty;
//				Dty7Num8.Text = string.Empty;
//				Dty8Num8.Text = string.Empty;
//				Dty9Num8.Text = string.Empty;
//				Dty10Num8.Text = string.Empty;
//				Dty11Num8.Text = string.Empty;
//				Dty12Num8.Text = string.Empty;
//				DtyTotal8.Text = string.Empty;
//			}
//// 管理番号 B14921 To
// 管理番号 K24565 To
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGE = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGESUM = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ReportIDText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PrintName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line208 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntYy = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line215 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line221 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line212 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line225 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line213 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line226 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line251 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line252 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexTypeName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EnterComp3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line253 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line254 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line255 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line256 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line257 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line258 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line259 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line260 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line271 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line272 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ChgDate = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostCodeName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpAddress = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line273 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsNo = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensRefeNum = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndNo = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmplyInsMarkNo = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line274 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line275 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line276 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymnt1mm = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line277 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymnt1dd = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt1Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded1Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line282 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line283 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox55 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt2Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded2Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line286 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line287 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox89 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox90 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt3Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded3Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line289 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line291 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox132 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt4Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded4Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line294 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line295 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt5Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded5Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line298 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line299 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox191 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox192 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt6Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded6Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line301 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox233 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line303 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox234 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt7Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded7Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line306 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line307 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox259 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox260 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt8Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded8Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line310 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line311 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox293 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox294 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt9Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded9Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line313 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox335 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line315 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox336 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt10Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded10Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line318 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line319 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label50 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox361 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox362 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt11Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded11Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line322 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line323 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label53 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox395 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox396 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt12Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded12Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line325 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line327 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal1Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal1Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line328 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line373 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label84 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox482 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox483 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt13Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded13Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line374 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label85 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox508 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line375 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox509 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt14Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded14Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line376 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line377 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label86 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox534 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox535 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt15Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded15Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line378 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label87 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox560 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox561 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt16Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded16Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line380 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label88 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line381 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal2Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal2Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line382 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label89 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line383 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt17Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded17Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line384 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line385 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label90 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntTotal3Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedTotal3Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line386 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label91 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label92 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label93 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label94 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label95 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label96 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label97 = null;
// 管理番号 K20794 From
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox658 = null;
// 管理番号 K20794 To		
		private GrapeCity.ActiveReports.SectionReportModel.Line Line387 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Paymnt18Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line388 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line389 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line390 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label103 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label104 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label105 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label106 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label107 = null;
// 管理番号 K20794 From	
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox671 = null;
// 管理番号 K20794 To
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Ded18Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line391 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line392 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line393 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label128 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label130 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label132 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label133 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label134 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label135 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label136 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line402 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line403 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line404 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line405 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntZeroFlg6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedZeroFlg6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EnterComp1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EnterComp2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntItemId6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemId6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDispType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedDispType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label108 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsZeroFlg6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsZeroFlg6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsDispType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsDispType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line410 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line411 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label146 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedBnsName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntBnsName6 = null;
		// 管理番号 K20794 From
// 管理番号 K20794 To
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_06_R29));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.Line215 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line221 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line212 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line225 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.AtacName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line213 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line226 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.AtacCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line251 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line252 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SexTypeName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EnterComp3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line253 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line254 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line255 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line256 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line257 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line258 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line259 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line260 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line271 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line272 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.ChgDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PostCodeName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label11 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label12 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label13 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label14 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label15 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line273 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label16 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label17 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HeltInsNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensRefeNum = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label18 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PensFndNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label19 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmplyInsMarkNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line274 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line275 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label20 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line276 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryPaymnt1mm = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line277 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryPaymnt1dd = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt1Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded1Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line282 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line283 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label23 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox55 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox56 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt2Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded2Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line286 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line287 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label26 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox89 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox90 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt3Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded3Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line289 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label29 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox131 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line291 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TextBox132 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt4Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded4Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line294 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line295 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label32 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox157 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox158 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt5Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded5Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line298 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line299 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox191 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox192 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt6Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded6Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line301 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label38 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox233 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line303 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TextBox234 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt7Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded7Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line306 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line307 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label41 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox259 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox260 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt8Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded8Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line310 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line311 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox293 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox294 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt9Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded9Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line313 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox335 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line315 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TextBox336 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt10Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded10Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line318 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line319 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label50 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox361 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox362 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt11Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded11Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line322 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line323 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label53 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox395 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox396 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt12Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded12Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line325 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label56 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line327 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntTotal1Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal1Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal1Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line328 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line373 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label84 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox482 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox483 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt13Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded13Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line374 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label85 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox508 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line375 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TextBox509 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt14Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded14Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line376 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line377 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label86 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox534 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox535 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt15Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded15Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line378 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label87 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox560 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox561 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt16Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded16Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line380 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label88 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line381 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntTotal2Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal2Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal2Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line382 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label89 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line383 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Ded17Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt17Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded17Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line384 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line385 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label90 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DedTotal3Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntTotal3Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedTotal3Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line386 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label91 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label92 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label93 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label94 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label95 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label96 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label97 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line387 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Paymnt18Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Paymnt18Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line388 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line389 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line390 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label103 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label104 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label106 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label107 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Ded18Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Ded18Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line391 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line392 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line393 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label128 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label132 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label133 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label134 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label135 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label136 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line402 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line403 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line404 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line405 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntZeroFlg1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntZeroFlg6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedZeroFlg6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EnterComp1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EnterComp2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntItemId6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemId6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDispType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedDispType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label108 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntBnsZeroFlg1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsZeroFlg6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsZeroFlg6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsDispType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsDispType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line410 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line411 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label146 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntBnsName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedBnsName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntBnsName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.SubReport2 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGE = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGESUM = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ReportIDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PrintName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryPaymntYy = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.CompanyNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.AtacName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChgDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostCodeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensRefeNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmplyInsMarkNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymnt1mm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymnt1dd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox89)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox90)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox191)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox192)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox233)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox234)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox259)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox260)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox293)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox294)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox335)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox336)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox361)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox362)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox395)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox396)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label84)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox482)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox483)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label85)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox508)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox509)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label86)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox534)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox535)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label87)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox560)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox561)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label88)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label89)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label90)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label91)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label92)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label107)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Line215,
            this.Line221,
            this.Line212,
            this.Line225,
            this.AtacName,
            this.Line213,
            this.Line226,
            this.AtacCode,
            this.Label5,
            this.Line251,
            this.Label6,
            this.EmpCode,
            this.EmpName,
            this.Line252,
            this.SexTypeName,
            this.EnterComp3,
            this.BirthDay,
            this.Label7,
            this.Label8,
            this.PaymntName1,
            this.DedName1,
            this.Line253,
            this.Line254,
            this.PaymntName2,
            this.DedName2,
            this.Line255,
            this.PaymntName3,
            this.DedName3,
            this.Line256,
            this.PaymntName4,
            this.DedName4,
            this.Line257,
            this.PaymntName5,
            this.DedName5,
            this.Line258,
            this.PaymntName6,
            this.DedName6,
            this.Line259,
            this.Line260,
            this.Line271,
            this.Line272,
            this.ChgDate,
            this.PostCodeName,
            this.Label11,
            this.Label12,
            this.Label13,
            this.Label14,
            this.Label15,
            this.EmpAddress,
            this.Line273,
            this.Label16,
            this.Label17,
            this.HeltInsNo,
            this.PensRefeNum,
            this.Label18,
            this.PensFndNo,
            this.Label19,
            this.EmplyInsMarkNo,
            this.Line274,
            this.Line275,
            this.Label20,
            this.Line276,
            this.SlryPaymnt1mm,
            this.Line277,
            this.SlryPaymnt1dd,
            this.Paymnt1Amt1,
            this.Ded1Amt1,
            this.Paymnt1Amt2,
            this.Ded1Amt2,
            this.Paymnt1Amt3,
            this.Ded1Amt3,
            this.Paymnt1Amt4,
            this.Ded1Amt4,
            this.Paymnt1Amt5,
            this.Ded1Amt5,
            this.Paymnt1Amt6,
            this.Ded1Amt6,
            this.Line282,
            this.Line283,
            this.Label23,
            this.TextBox55,
            this.TextBox56,
            this.Paymnt2Amt1,
            this.Ded2Amt1,
            this.Paymnt2Amt2,
            this.Ded2Amt2,
            this.Paymnt2Amt3,
            this.Ded2Amt3,
            this.Paymnt2Amt4,
            this.Ded2Amt4,
            this.Paymnt2Amt5,
            this.Ded2Amt5,
            this.Paymnt2Amt6,
            this.Ded2Amt6,
            this.Line286,
            this.Line287,
            this.Label26,
            this.TextBox89,
            this.TextBox90,
            this.Paymnt3Amt1,
            this.Ded3Amt1,
            this.Paymnt3Amt2,
            this.Ded3Amt2,
            this.Paymnt3Amt3,
            this.Ded3Amt3,
            this.Paymnt3Amt4,
            this.Ded3Amt4,
            this.Paymnt3Amt5,
            this.Ded3Amt5,
            this.Paymnt3Amt6,
            this.Ded3Amt6,
            this.Line289,
            this.Label29,
            this.TextBox131,
            this.Line291,
            this.TextBox132,
            this.Paymnt4Amt1,
            this.Ded4Amt1,
            this.Paymnt4Amt2,
            this.Ded4Amt2,
            this.Paymnt4Amt3,
            this.Ded4Amt3,
            this.Paymnt4Amt4,
            this.Ded4Amt4,
            this.Paymnt4Amt5,
            this.Ded4Amt5,
            this.Paymnt4Amt6,
            this.Ded4Amt6,
            this.Line294,
            this.Line295,
            this.Label32,
            this.TextBox157,
            this.TextBox158,
            this.Paymnt5Amt1,
            this.Ded5Amt1,
            this.Paymnt5Amt2,
            this.Ded5Amt2,
            this.Paymnt5Amt3,
            this.Ded5Amt3,
            this.Paymnt5Amt4,
            this.Ded5Amt4,
            this.Paymnt5Amt5,
            this.Ded5Amt5,
            this.Paymnt5Amt6,
            this.Ded5Amt6,
            this.Line298,
            this.Line299,
            this.Label35,
            this.TextBox191,
            this.TextBox192,
            this.Paymnt6Amt1,
            this.Ded6Amt1,
            this.Paymnt6Amt2,
            this.Ded6Amt2,
            this.Paymnt6Amt3,
            this.Ded6Amt3,
            this.Paymnt6Amt4,
            this.Ded6Amt4,
            this.Paymnt6Amt5,
            this.Ded6Amt5,
            this.Paymnt6Amt6,
            this.Ded6Amt6,
            this.Line301,
            this.Label38,
            this.TextBox233,
            this.Line303,
            this.TextBox234,
            this.Paymnt7Amt1,
            this.Ded7Amt1,
            this.Paymnt7Amt2,
            this.Ded7Amt2,
            this.Paymnt7Amt3,
            this.Ded7Amt3,
            this.Paymnt7Amt4,
            this.Ded7Amt4,
            this.Paymnt7Amt5,
            this.Ded7Amt5,
            this.Paymnt7Amt6,
            this.Ded7Amt6,
            this.Line306,
            this.Line307,
            this.Label41,
            this.TextBox259,
            this.TextBox260,
            this.Paymnt8Amt1,
            this.Ded8Amt1,
            this.Paymnt8Amt2,
            this.Ded8Amt2,
            this.Paymnt8Amt3,
            this.Ded8Amt3,
            this.Paymnt8Amt4,
            this.Ded8Amt4,
            this.Paymnt8Amt5,
            this.Ded8Amt5,
            this.Paymnt8Amt6,
            this.Ded8Amt6,
            this.Line310,
            this.Line311,
            this.Label44,
            this.TextBox293,
            this.TextBox294,
            this.Paymnt9Amt1,
            this.Ded9Amt1,
            this.Paymnt9Amt2,
            this.Ded9Amt2,
            this.Paymnt9Amt3,
            this.Ded9Amt3,
            this.Paymnt9Amt4,
            this.Ded9Amt4,
            this.Paymnt9Amt5,
            this.Ded9Amt5,
            this.Paymnt9Amt6,
            this.Ded9Amt6,
            this.Line313,
            this.Label47,
            this.TextBox335,
            this.Line315,
            this.TextBox336,
            this.Paymnt10Amt1,
            this.Ded10Amt1,
            this.Paymnt10Amt2,
            this.Ded10Amt2,
            this.Paymnt10Amt3,
            this.Ded10Amt3,
            this.Paymnt10Amt4,
            this.Ded10Amt4,
            this.Paymnt10Amt5,
            this.Ded10Amt5,
            this.Paymnt10Amt6,
            this.Ded10Amt6,
            this.Line318,
            this.Line319,
            this.Label50,
            this.TextBox361,
            this.TextBox362,
            this.Paymnt11Amt1,
            this.Ded11Amt1,
            this.Paymnt11Amt2,
            this.Ded11Amt2,
            this.Paymnt11Amt3,
            this.Ded11Amt3,
            this.Paymnt11Amt4,
            this.Ded11Amt4,
            this.Paymnt11Amt5,
            this.Ded11Amt5,
            this.Paymnt11Amt6,
            this.Ded11Amt6,
            this.Line322,
            this.Line323,
            this.Label53,
            this.TextBox395,
            this.TextBox396,
            this.Paymnt12Amt1,
            this.Ded12Amt1,
            this.Paymnt12Amt2,
            this.Ded12Amt2,
            this.Paymnt12Amt3,
            this.Ded12Amt3,
            this.Paymnt12Amt4,
            this.Ded12Amt4,
            this.Paymnt12Amt5,
            this.Ded12Amt5,
            this.Paymnt12Amt6,
            this.Ded12Amt6,
            this.Line325,
            this.Label56,
            this.Line327,
            this.PaymntTotal1Amt1,
            this.DedTotal1Amt1,
            this.PaymntTotal1Amt2,
            this.DedTotal1Amt2,
            this.PaymntTotal1Amt3,
            this.DedTotal1Amt3,
            this.PaymntTotal1Amt4,
            this.DedTotal1Amt4,
            this.PaymntTotal1Amt5,
            this.DedTotal1Amt5,
            this.PaymntTotal1Amt6,
            this.DedTotal1Amt6,
            this.Line328,
            this.Line373,
            this.Label84,
            this.TextBox482,
            this.TextBox483,
            this.Paymnt13Amt1,
            this.Ded13Amt1,
            this.Paymnt13Amt2,
            this.Ded13Amt2,
            this.Paymnt13Amt3,
            this.Ded13Amt3,
            this.Paymnt13Amt4,
            this.Ded13Amt4,
            this.Paymnt13Amt5,
            this.Ded13Amt5,
            this.Paymnt13Amt6,
            this.Ded13Amt6,
            this.Line374,
            this.Label85,
            this.TextBox508,
            this.Line375,
            this.TextBox509,
            this.Paymnt14Amt1,
            this.Ded14Amt1,
            this.Paymnt14Amt2,
            this.Ded14Amt2,
            this.Paymnt14Amt3,
            this.Ded14Amt3,
            this.Paymnt14Amt4,
            this.Ded14Amt4,
            this.Paymnt14Amt5,
            this.Ded14Amt5,
            this.Paymnt14Amt6,
            this.Ded14Amt6,
            this.Line376,
            this.Line377,
            this.Label86,
            this.TextBox534,
            this.TextBox535,
            this.Paymnt15Amt1,
            this.Ded15Amt1,
            this.Paymnt15Amt2,
            this.Ded15Amt2,
            this.Paymnt15Amt3,
            this.Ded15Amt3,
            this.Paymnt15Amt4,
            this.Ded15Amt4,
            this.Paymnt15Amt5,
            this.Ded15Amt5,
            this.Paymnt15Amt6,
            this.Ded15Amt6,
            this.Line378,
            this.Label87,
            this.TextBox560,
            this.TextBox561,
            this.Paymnt16Amt1,
            this.Ded16Amt1,
            this.Paymnt16Amt2,
            this.Ded16Amt2,
            this.Paymnt16Amt3,
            this.Ded16Amt3,
            this.Paymnt16Amt4,
            this.Ded16Amt4,
            this.Paymnt16Amt5,
            this.Ded16Amt5,
            this.Paymnt16Amt6,
            this.Ded16Amt6,
            this.Line380,
            this.Label88,
            this.Line381,
            this.PaymntTotal2Amt1,
            this.DedTotal2Amt1,
            this.PaymntTotal2Amt2,
            this.DedTotal2Amt2,
            this.PaymntTotal2Amt3,
            this.DedTotal2Amt3,
            this.PaymntTotal2Amt4,
            this.DedTotal2Amt4,
            this.PaymntTotal2Amt5,
            this.DedTotal2Amt5,
            this.PaymntTotal2Amt6,
            this.DedTotal2Amt6,
            this.Line382,
            this.Label89,
            this.Line383,
            this.Ded17Amt1,
            this.Paymnt17Amt1,
            this.Paymnt17Amt2,
            this.Ded17Amt2,
            this.Paymnt17Amt3,
            this.Ded17Amt3,
            this.Paymnt17Amt4,
            this.Ded17Amt4,
            this.Paymnt17Amt5,
            this.Ded17Amt5,
            this.Paymnt17Amt6,
            this.Ded17Amt6,
            this.Line384,
            this.Line385,
            this.Label90,
            this.DedTotal3Amt1,
            this.PaymntTotal3Amt1,
            this.PaymntTotal3Amt2,
            this.DedTotal3Amt2,
            this.PaymntTotal3Amt3,
            this.DedTotal3Amt3,
            this.PaymntTotal3Amt4,
            this.DedTotal3Amt4,
            this.PaymntTotal3Amt5,
            this.DedTotal3Amt5,
            this.PaymntTotal3Amt6,
            this.DedTotal3Amt6,
            this.Line386,
            this.Label91,
            this.Label92,
            this.Label93,
            this.Label94,
            this.Label95,
            this.Label96,
            this.Label97,
            this.Line387,
            this.Paymnt18Amt1,
            this.Paymnt18Amt2,
            this.Paymnt18Amt3,
            this.Paymnt18Amt4,
            this.Paymnt18Amt5,
            this.Paymnt18Amt6,
            this.Line388,
            this.Line389,
            this.Line390,
            this.Label103,
            this.Label104,
            this.Label105,
            this.Label106,
            this.Label107,
            this.Ded18Amt1,
            this.Ded18Amt2,
            this.Ded18Amt3,
            this.Ded18Amt4,
            this.Ded18Amt5,
            this.Ded18Amt6,
            this.Line391,
            this.Line392,
            this.Line393,
            this.Label128,
            this.Label129,
            this.Label130,
            this.Label131,
            this.Label132,
            this.Label133,
            this.Label134,
            this.Label135,
            this.Label136,
            this.Line402,
            this.Line403,
            this.Line404,
            this.Line405,
            this.PaymntZeroFlg1,
            this.PaymntZeroFlg2,
            this.PaymntZeroFlg3,
            this.PaymntZeroFlg4,
            this.PaymntZeroFlg5,
            this.PaymntZeroFlg6,
            this.DedZeroFlg1,
            this.DedZeroFlg2,
            this.DedZeroFlg3,
            this.DedZeroFlg4,
            this.DedZeroFlg5,
            this.DedZeroFlg6,
            this.EnterComp1,
            this.EnterComp2,
            this.DedItemId1,
            this.PaymntItemId1,
            this.DedItemId2,
            this.PaymntItemId2,
            this.DedItemId4,
            this.PaymntItemId3,
            this.DedItemId3,
            this.PaymntItemId4,
            this.PaymntItemId5,
            this.DedItemId5,
            this.PaymntItemId6,
            this.DedItemId6,
            this.PaymntDispType1,
            this.DedDispType1,
            this.DedDispType2,
            this.PaymntDispType2,
            this.PaymntDispType3,
            this.DedDispType3,
            this.PaymntDispType4,
            this.DedDispType4,
            this.PaymntDispType5,
            this.PaymntDispType6,
            this.DedDispType5,
            this.DedDispType6,
            this.Label108,
            this.PaymntBnsZeroFlg1,
            this.PaymntBnsZeroFlg2,
            this.PaymntBnsZeroFlg3,
            this.PaymntBnsZeroFlg4,
            this.PaymntBnsZeroFlg5,
            this.PaymntBnsZeroFlg6,
            this.DedBnsZeroFlg1,
            this.DedBnsZeroFlg2,
            this.DedBnsZeroFlg3,
            this.DedBnsZeroFlg4,
            this.DedBnsZeroFlg5,
            this.DedBnsZeroFlg6,
            this.PaymntBnsDispType1,
            this.PaymntBnsDispType2,
            this.PaymntBnsDispType3,
            this.PaymntBnsDispType4,
            this.PaymntBnsDispType5,
            this.PaymntBnsDispType6,
            this.DedBnsDispType1,
            this.DedBnsDispType2,
            this.DedBnsDispType3,
            this.DedBnsDispType4,
            this.DedBnsDispType5,
            this.DedBnsDispType6,
            this.Line410,
            this.Label145,
            this.Line411,
            this.Label146,
            this.PaymntBnsName1,
            this.DedBnsName1,
            this.PaymntBnsName2,
            this.DedBnsName2,
            this.PaymntBnsName3,
            this.DedBnsName3,
            this.PaymntBnsName4,
            this.DedBnsName4,
            this.PaymntBnsName5,
            this.DedBnsName5,
            this.DedBnsName6,
            this.PaymntBnsName6,
            this.SubReport1,
            this.SubReport2});
			this.Detail.Height = 7.228472F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// Line215
			// 
			this.Line215.Height = 0.286F;
			this.Line215.Left = 2.4405F;
			this.Line215.LineWeight = 1F;
			this.Line215.Name = "Line215";
			this.Line215.Top = 0F;
			this.Line215.Width = 0F;
			this.Line215.X1 = 2.4405F;
			this.Line215.X2 = 2.4405F;
			this.Line215.Y1 = 0F;
			this.Line215.Y2 = 0.286F;
			// 
			// Line221
			// 
			this.Line221.Height = 0.286F;
			this.Line221.Left = 8.128F;
			this.Line221.LineWeight = 1F;
			this.Line221.Name = "Line221";
			this.Line221.Top = 0F;
			this.Line221.Width = 0F;
			this.Line221.X1 = 8.128F;
			this.Line221.X2 = 8.128F;
			this.Line221.Y1 = 0F;
			this.Line221.Y2 = 0.286F;
			// 
			// Line212
			// 
			this.Line212.Height = 7.177F;
			this.Line212.Left = 0.0625F;
			this.Line212.LineWeight = 1F;
			this.Line212.Name = "Line212";
			this.Line212.Top = 0.0004999935F;
			this.Line212.Width = 0F;
			this.Line212.X1 = 0.0625F;
			this.Line212.X2 = 0.0625F;
			this.Line212.Y1 = 0.0004999935F;
			this.Line212.Y2 = 7.1775F;
			// 
			// Line225
			// 
			this.Line225.Height = 6.033F;
			this.Line225.Left = 0.315F;
			this.Line225.LineWeight = 1F;
			this.Line225.Name = "Line225";
			this.Line225.Top = 0F;
			this.Line225.Width = 0F;
			this.Line225.X1 = 0.315F;
			this.Line225.X2 = 0.315F;
			this.Line225.Y1 = 0F;
			this.Line225.Y2 = 6.033F;
			// 
			// AtacName
			// 
			this.AtacName.DataField = "ATAC_NAME";
			this.AtacName.Height = 0.143F;
			this.AtacName.Left = 0.8775F;
			this.AtacName.Name = "AtacName";
			this.AtacName.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.AtacName.Text = "あいうえおかきくけこ";
			this.AtacName.Top = 0F;
			this.AtacName.Width = 1F;
			// 
			// Line213
			// 
			this.Line213.Height = 0.286F;
			this.Line213.Left = 2.0025F;
			this.Line213.LineWeight = 1F;
			this.Line213.Name = "Line213";
			this.Line213.Top = 0F;
			this.Line213.Width = 0F;
			this.Line213.X1 = 2.0025F;
			this.Line213.X2 = 2.0025F;
			this.Line213.Y1 = 0F;
			this.Line213.Y2 = 0.286F;
			// 
			// Line226
			// 
			this.Line226.Height = 0F;
			this.Line226.Left = 0.0625F;
			this.Line226.LineWeight = 1F;
			this.Line226.Name = "Line226";
			this.Line226.Top = 0.143F;
			this.Line226.Width = 4.813F;
			this.Line226.X1 = 0.0625F;
			this.Line226.X2 = 4.8755F;
			this.Line226.Y1 = 0.143F;
			this.Line226.Y2 = 0.143F;
			// 
			// AtacCode
			// 
			this.AtacCode.DataField = "ATAC_CODE";
			this.AtacCode.Height = 0.143F;
			this.AtacCode.Left = 0.3155F;
			this.AtacCode.Name = "AtacCode";
			this.AtacCode.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: nowrap; ddo-c" +
    "har-set: 1";
			this.AtacCode.Text = "0000000000";
			this.AtacCode.Top = 0F;
			this.AtacCode.Width = 0.54F;
			// 
			// Label5
			// 
			this.Label5.Height = 0.143F;
			this.Label5.HyperLink = null;
			this.Label5.Left = 0.0625F;
			this.Label5.Name = "Label5";
			this.Label5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label5.Text = "所属";
			this.Label5.Top = 0F;
			this.Label5.Width = 0.253F;
			// 
			// Line251
			// 
			this.Line251.Height = 0F;
			this.Line251.Left = 0.0625F;
			this.Line251.LineWeight = 1F;
			this.Line251.Name = "Line251";
			this.Line251.Top = 0F;
			this.Line251.Width = 10.816F;
			this.Line251.X1 = 0.0625F;
			this.Line251.X2 = 10.8785F;
			this.Line251.Y1 = 0F;
			this.Line251.Y2 = 0F;
			// 
			// Label6
			// 
			this.Label6.Height = 0.143F;
			this.Label6.HyperLink = null;
			this.Label6.Left = 0.0625F;
			this.Label6.Name = "Label6";
			this.Label6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label6.Text = "社員";
			this.Label6.Top = 0.143F;
			this.Label6.Width = 0.253F;
			// 
			// EmpCode
			// 
			this.EmpCode.DataField = "EMP_CODE";
			this.EmpCode.Height = 0.143F;
			this.EmpCode.Left = 0.3155F;
			this.EmpCode.Name = "EmpCode";
			this.EmpCode.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: nowrap; ddo-c" +
    "har-set: 1";
			this.EmpCode.Text = "0000000000";
			this.EmpCode.Top = 0.143F;
			this.EmpCode.Width = 0.54F;
			// 
			// EmpName
			// 
			this.EmpName.DataField = "EMP_NAME";
			this.EmpName.Height = 0.143F;
			this.EmpName.Left = 0.878F;
			this.EmpName.Name = "EmpName";
			this.EmpName.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EmpName.Text = "あいうえおかきくけこ";
			this.EmpName.Top = 0.143F;
			this.EmpName.Width = 1F;
			// 
			// Line252
			// 
			this.Line252.Height = 0F;
			this.Line252.Left = 0.0625F;
			this.Line252.LineWeight = 1F;
			this.Line252.Name = "Line252";
			this.Line252.Top = 0.286F;
			this.Line252.Width = 10.816F;
			this.Line252.X1 = 0.0625F;
			this.Line252.X2 = 10.8785F;
			this.Line252.Y1 = 0.286F;
			this.Line252.Y2 = 0.286F;
			// 
			// SexTypeName
			// 
			this.SexTypeName.DataField = "SEX_TYPE_NAME";
			this.SexTypeName.Height = 0.143F;
			this.SexTypeName.Left = 1.8775F;
			this.SexTypeName.Name = "SexTypeName";
			this.SexTypeName.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.SexTypeName.Text = "あ";
			this.SexTypeName.Top = 0.143F;
			this.SexTypeName.Width = 0.125F;
			// 
			// EnterComp3
			// 
			this.EnterComp3.Height = 0.143F;
			this.EnterComp3.Left = 2.44F;
			this.EnterComp3.Name = "EnterComp3";
			this.EnterComp3.OutputFormat = "yyyy/MM/dd";
			this.EnterComp3.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EnterComp3.Text = "6666/66/66";
			this.EnterComp3.Top = 0F;
			this.EnterComp3.Width = 0.813F;
			// 
			// BirthDay
			// 
			this.BirthDay.DataField = "BIRTH_DAY";
			this.BirthDay.Height = 0.143F;
			this.BirthDay.Left = 2.4405F;
			this.BirthDay.Name = "BirthDay";
			this.BirthDay.OutputFormat = "yyyy/MM/dd";
			this.BirthDay.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.BirthDay.Text = "6666/66/66";
			this.BirthDay.Top = 0.143F;
			this.BirthDay.Width = 0.813F;
			// 
			// Label7
			// 
			this.Label7.Height = 0.143F;
			this.Label7.HyperLink = null;
			this.Label7.Left = 0.3125F;
			this.Label7.Name = "Label7";
			this.Label7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label7.Text = "支給";
			this.Label7.Top = 0.286F;
			this.Label7.Width = 0.44F;
			// 
			// Label8
			// 
			this.Label8.Height = 0.16F;
			this.Label8.HyperLink = null;
			this.Label8.Left = 0.3125F;
			this.Label8.Name = "Label8";
			this.Label8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label8.Text = "月日";
			this.Label8.Top = 0.429F;
			this.Label8.Width = 0.44F;
			// 
			// PaymntName1
			// 
			this.PaymntName1.DataField = "PAYMNT_NAME1";
			this.PaymntName1.Height = 0.143F;
			this.PaymntName1.Left = 0.7525F;
			this.PaymntName1.Name = "PaymntName1";
			this.PaymntName1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName1.Text = "あいうえおか";
			this.PaymntName1.Top = 0.286F;
			this.PaymntName1.Width = 0.625F;
			// 
			// DedName1
			// 
			this.DedName1.DataField = "DED_NAME1";
			this.DedName1.Height = 0.143F;
			this.DedName1.Left = 0.7525F;
			this.DedName1.Name = "DedName1";
			this.DedName1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName1.Text = "あいうえおか";
			this.DedName1.Top = 0.429F;
			this.DedName1.Width = 0.625F;
			// 
			// Line253
			// 
			this.Line253.Height = 6.891F;
			this.Line253.Left = 1.378F;
			this.Line253.LineWeight = 1F;
			this.Line253.Name = "Line253";
			this.Line253.Top = 0.286F;
			this.Line253.Width = 0F;
			this.Line253.X1 = 1.378F;
			this.Line253.X2 = 1.378F;
			this.Line253.Y1 = 0.286F;
			this.Line253.Y2 = 7.177F;
			// 
			// Line254
			// 
			this.Line254.Height = 6.891F;
			this.Line254.Left = 0.753F;
			this.Line254.LineWeight = 1F;
			this.Line254.Name = "Line254";
			this.Line254.Top = 0.286F;
			this.Line254.Width = 0F;
			this.Line254.X1 = 0.753F;
			this.Line254.X2 = 0.753F;
			this.Line254.Y1 = 0.286F;
			this.Line254.Y2 = 7.177F;
			// 
			// PaymntName2
			// 
			this.PaymntName2.DataField = "PAYMNT_NAME2";
			this.PaymntName2.Height = 0.143F;
			this.PaymntName2.Left = 1.3775F;
			this.PaymntName2.Name = "PaymntName2";
			this.PaymntName2.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName2.Text = "あいうえおか";
			this.PaymntName2.Top = 0.286F;
			this.PaymntName2.Width = 0.625F;
			// 
			// DedName2
			// 
			this.DedName2.DataField = "DED_NAME2";
			this.DedName2.Height = 0.143F;
			this.DedName2.Left = 1.3775F;
			this.DedName2.Name = "DedName2";
			this.DedName2.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName2.Text = "あいうえおか";
			this.DedName2.Top = 0.429F;
			this.DedName2.Width = 0.625F;
			// 
			// Line255
			// 
			this.Line255.Height = 6.891F;
			this.Line255.Left = 2.003F;
			this.Line255.LineWeight = 1F;
			this.Line255.Name = "Line255";
			this.Line255.Top = 0.286F;
			this.Line255.Width = 0F;
			this.Line255.X1 = 2.003F;
			this.Line255.X2 = 2.003F;
			this.Line255.Y1 = 0.286F;
			this.Line255.Y2 = 7.177F;
			// 
			// PaymntName3
			// 
			this.PaymntName3.DataField = "PAYMNT_NAME3";
			this.PaymntName3.Height = 0.143F;
			this.PaymntName3.Left = 2.0025F;
			this.PaymntName3.Name = "PaymntName3";
			this.PaymntName3.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName3.Text = "あいうえおか";
			this.PaymntName3.Top = 0.286F;
			this.PaymntName3.Width = 0.625F;
			// 
			// DedName3
			// 
			this.DedName3.DataField = "DED_NAME3";
			this.DedName3.Height = 0.143F;
			this.DedName3.Left = 2.0025F;
			this.DedName3.Name = "DedName3";
			this.DedName3.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName3.Text = "あいうえおか";
			this.DedName3.Top = 0.429F;
			this.DedName3.Width = 0.625F;
			// 
			// Line256
			// 
			this.Line256.Height = 6.891F;
			this.Line256.Left = 2.628F;
			this.Line256.LineWeight = 1F;
			this.Line256.Name = "Line256";
			this.Line256.Top = 0.286F;
			this.Line256.Width = 0F;
			this.Line256.X1 = 2.628F;
			this.Line256.X2 = 2.628F;
			this.Line256.Y1 = 0.286F;
			this.Line256.Y2 = 7.177F;
			// 
			// PaymntName4
			// 
			this.PaymntName4.DataField = "PAYMNT_NAME4";
			this.PaymntName4.Height = 0.143F;
			this.PaymntName4.Left = 2.6275F;
			this.PaymntName4.Name = "PaymntName4";
			this.PaymntName4.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName4.Text = "あいうえおか";
			this.PaymntName4.Top = 0.286F;
			this.PaymntName4.Width = 0.625F;
			// 
			// DedName4
			// 
			this.DedName4.DataField = "DED_NAME4";
			this.DedName4.Height = 0.143F;
			this.DedName4.Left = 2.6275F;
			this.DedName4.Name = "DedName4";
			this.DedName4.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName4.Text = "あいうえおか";
			this.DedName4.Top = 0.429F;
			this.DedName4.Width = 0.625F;
			// 
			// Line257
			// 
			this.Line257.Height = 7.177F;
			this.Line257.Left = 3.253F;
			this.Line257.LineWeight = 1F;
			this.Line257.Name = "Line257";
			this.Line257.Top = 0F;
			this.Line257.Width = 0F;
			this.Line257.X1 = 3.253F;
			this.Line257.X2 = 3.253F;
			this.Line257.Y1 = 0F;
			this.Line257.Y2 = 7.177F;
			// 
			// PaymntName5
			// 
			this.PaymntName5.DataField = "PAYMNT_NAME5";
			this.PaymntName5.Height = 0.143F;
			this.PaymntName5.Left = 3.2525F;
			this.PaymntName5.Name = "PaymntName5";
			this.PaymntName5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName5.Text = "あいうえおか";
			this.PaymntName5.Top = 0.286F;
			this.PaymntName5.Width = 0.625F;
			// 
			// DedName5
			// 
			this.DedName5.DataField = "DED_NAME5";
			this.DedName5.Height = 0.143F;
			this.DedName5.Left = 3.2525F;
			this.DedName5.Name = "DedName5";
			this.DedName5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName5.Text = "あいうえおか";
			this.DedName5.Top = 0.429F;
			this.DedName5.Width = 0.625F;
			// 
			// Line258
			// 
			this.Line258.Height = 6.891F;
			this.Line258.Left = 3.878F;
			this.Line258.LineWeight = 1F;
			this.Line258.Name = "Line258";
			this.Line258.Top = 0.286F;
			this.Line258.Width = 0F;
			this.Line258.X1 = 3.878F;
			this.Line258.X2 = 3.878F;
			this.Line258.Y1 = 0.286F;
			this.Line258.Y2 = 7.177F;
			// 
			// PaymntName6
			// 
			this.PaymntName6.DataField = "PAYMNT_NAME6";
			this.PaymntName6.Height = 0.143F;
			this.PaymntName6.Left = 3.8775F;
			this.PaymntName6.Name = "PaymntName6";
			this.PaymntName6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntName6.Text = "あいうえおか";
			this.PaymntName6.Top = 0.286F;
			this.PaymntName6.Width = 0.624F;
			// 
			// DedName6
			// 
			this.DedName6.DataField = "DED_NAME6";
			this.DedName6.Height = 0.143F;
			this.DedName6.Left = 3.8775F;
			this.DedName6.Name = "DedName6";
			this.DedName6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedName6.Text = "あいうえおか";
			this.DedName6.Top = 0.429F;
			this.DedName6.Width = 0.624F;
			// 
			// Line259
			// 
			this.Line259.Height = 6.891F;
			this.Line259.Left = 4.503F;
			this.Line259.LineWeight = 1F;
			this.Line259.Name = "Line259";
			this.Line259.Top = 0.286F;
			this.Line259.Width = 0F;
			this.Line259.X1 = 4.503F;
			this.Line259.X2 = 4.503F;
			this.Line259.Y1 = 0.286F;
			this.Line259.Y2 = 7.177F;
			// 
			// Line260
			// 
			this.Line260.Height = 0.286F;
			this.Line260.Left = 5.128F;
			this.Line260.LineWeight = 1F;
			this.Line260.Name = "Line260";
			this.Line260.Top = 0F;
			this.Line260.Width = 0F;
			this.Line260.X1 = 5.128F;
			this.Line260.X2 = 5.128F;
			this.Line260.Y1 = 0F;
			this.Line260.Y2 = 0.286F;
			// 
			// Line271
			// 
			this.Line271.Height = 0.286F;
			this.Line271.Left = 10.878F;
			this.Line271.LineWeight = 1F;
			this.Line271.Name = "Line271";
			this.Line271.Top = 0F;
			this.Line271.Width = 0F;
			this.Line271.X1 = 10.878F;
			this.Line271.X2 = 10.878F;
			this.Line271.Y1 = 0F;
			this.Line271.Y2 = 0.286F;
			// 
			// Line272
			// 
			this.Line272.Height = 0.286F;
			this.Line272.Left = 3.878F;
			this.Line272.LineWeight = 1F;
			this.Line272.Name = "Line272";
			this.Line272.Top = 0F;
			this.Line272.Width = 0F;
			this.Line272.X1 = 3.878F;
			this.Line272.X2 = 3.878F;
			this.Line272.Y1 = 0F;
			this.Line272.Y2 = 0.286F;
			// 
			// ChgDate
			// 
			this.ChgDate.DataField = "CHG_DATE";
			this.ChgDate.Height = 0.143F;
			this.ChgDate.Left = 3.8775F;
			this.ChgDate.Name = "ChgDate";
			this.ChgDate.OutputFormat = "yyyy/MM/dd";
			this.ChgDate.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.ChgDate.Text = "6666/66/66";
			this.ChgDate.Top = 0F;
			this.ChgDate.Width = 1.0005F;
			// 
			// PostCodeName
			// 
			this.PostCodeName.DataField = "POST_CODE_NAME";
			this.PostCodeName.Height = 0.143F;
			this.PostCodeName.Left = 3.8775F;
			this.PostCodeName.Name = "PostCodeName";
			this.PostCodeName.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.PostCodeName.Text = "ああああああああああ";
			this.PostCodeName.Top = 0.143F;
			this.PostCodeName.Width = 1.001F;
			// 
			// Label11
			// 
			this.Label11.Height = 0.143F;
			this.Label11.HyperLink = null;
			this.Label11.Left = 2.0025F;
			this.Label11.Name = "Label11";
			this.Label11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label11.Text = "入 社 日";
			this.Label11.Top = 0F;
			this.Label11.Width = 0.4375F;
			// 
			// Label12
			// 
			this.Label12.Height = 0.143F;
			this.Label12.HyperLink = null;
			this.Label12.Left = 2.0025F;
			this.Label12.Name = "Label12";
			this.Label12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label12.Text = "生年月日";
			this.Label12.Top = 0.143F;
			this.Label12.Width = 0.438F;
			// 
			// Label13
			// 
			this.Label13.Height = 0.143F;
			this.Label13.HyperLink = null;
			this.Label13.Left = 3.25F;
			this.Label13.Name = "Label13";
			this.Label13.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label13.Text = "退職日";
			this.Label13.Top = 0F;
			this.Label13.Width = 0.6275001F;
			// 
			// Label14
			// 
			this.Label14.Height = 0.143F;
			this.Label14.HyperLink = null;
			this.Label14.Left = 3.2505F;
			this.Label14.Name = "Label14";
			this.Label14.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label14.Text = "役　職";
			this.Label14.Top = 0.143F;
			this.Label14.Width = 0.6270001F;
			// 
			// Label15
			// 
			this.Label15.Height = 0.286F;
			this.Label15.HyperLink = null;
			this.Label15.Left = 4.875F;
			this.Label15.Name = "Label15";
			this.Label15.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.Label15.Text = "住所";
			this.Label15.Top = 0F;
			this.Label15.Width = 0.253F;
			// 
			// EmpAddress
			// 
			this.EmpAddress.DataField = "EMP_ADDRESS";
			this.EmpAddress.Height = 0.286F;
			this.EmpAddress.Left = 5.1275F;
			this.EmpAddress.Name = "EmpAddress";
			this.EmpAddress.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EmpAddress.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほ";
			this.EmpAddress.Top = 0F;
			this.EmpAddress.Width = 3F;
			// 
			// Line273
			// 
			this.Line273.Height = 0.3199999F;
			this.Line273.Left = 8.628F;
			this.Line273.LineWeight = 1F;
			this.Line273.Name = "Line273";
			this.Line273.Top = 0F;
			this.Line273.Width = 0F;
			this.Line273.X1 = 8.628F;
			this.Line273.X2 = 8.628F;
			this.Line273.Y1 = 0F;
			this.Line273.Y2 = 0.3199999F;
			// 
			// Label16
			// 
			this.Label16.Height = 0.143F;
			this.Label16.HyperLink = null;
			this.Label16.Left = 8.125F;
			this.Label16.Name = "Label16";
			this.Label16.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label16.Text = "健保番号";
			this.Label16.Top = 0F;
			this.Label16.Width = 0.503F;
			// 
			// Label17
			// 
			this.Label17.Height = 0.143F;
			this.Label17.HyperLink = null;
			this.Label17.Left = 8.1255F;
			this.Label17.Name = "Label17";
			this.Label17.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label17.Text = "厚生年金";
			this.Label17.Top = 0.143F;
			this.Label17.Width = 0.503F;
			// 
			// HeltInsNo
			// 
			this.HeltInsNo.DataField = "HELT_INS_NO";
			this.HeltInsNo.Height = 0.143F;
			this.HeltInsNo.Left = 8.6275F;
			this.HeltInsNo.Name = "HeltInsNo";
			this.HeltInsNo.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.HeltInsNo.Text = "0000000000";
			this.HeltInsNo.Top = 0F;
			this.HeltInsNo.Width = 0.875F;
			// 
			// PensRefeNum
			// 
			this.PensRefeNum.DataField = "PENS_REFE_NUM";
			this.PensRefeNum.Height = 0.143F;
			this.PensRefeNum.Left = 8.6275F;
			this.PensRefeNum.Name = "PensRefeNum";
			this.PensRefeNum.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.PensRefeNum.Text = "0000000000";
			this.PensRefeNum.Top = 0.143F;
			this.PensRefeNum.Width = 0.875F;
			// 
			// Label18
			// 
			this.Label18.Height = 0.143F;
			this.Label18.HyperLink = null;
			this.Label18.Left = 9.5F;
			this.Label18.Name = "Label18";
			this.Label18.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label18.Text = "基金番号";
			this.Label18.Top = 0F;
			this.Label18.Width = 0.5024996F;
			// 
			// PensFndNo
			// 
			this.PensFndNo.DataField = "PENS_FND_NO";
			this.PensFndNo.Height = 0.143F;
			this.PensFndNo.Left = 10.0025F;
			this.PensFndNo.Name = "PensFndNo";
			this.PensFndNo.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.PensFndNo.Text = "0000000000";
			this.PensFndNo.Top = 0F;
			this.PensFndNo.Width = 0.875F;
			// 
			// Label19
			// 
			this.Label19.Height = 0.143F;
			this.Label19.HyperLink = null;
			this.Label19.Left = 9.5005F;
			this.Label19.Name = "Label19";
			this.Label19.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label19.Text = "雇用保険";
			this.Label19.Top = 0.143F;
			this.Label19.Width = 0.5019999F;
			// 
			// EmplyInsMarkNo
			// 
			this.EmplyInsMarkNo.DataField = "EMPLY_INS_MARK_NO";
			this.EmplyInsMarkNo.Height = 0.143F;
			this.EmplyInsMarkNo.Left = 10.0025F;
			this.EmplyInsMarkNo.Name = "EmplyInsMarkNo";
			this.EmplyInsMarkNo.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EmplyInsMarkNo.Text = "0000000000";
			this.EmplyInsMarkNo.Top = 0.143F;
			this.EmplyInsMarkNo.Width = 0.875F;
			// 
			// Line274
			// 
			this.Line274.Height = 0F;
			this.Line274.Left = 0.0625F;
			this.Line274.LineWeight = 1F;
			this.Line274.Name = "Line274";
			this.Line274.Top = 0.5720001F;
			this.Line274.Width = 4.4405F;
			this.Line274.X1 = 0.0625F;
			this.Line274.X2 = 4.503F;
			this.Line274.Y1 = 0.5720001F;
			this.Line274.Y2 = 0.5720001F;
			// 
			// Line275
			// 
			this.Line275.Height = 0F;
			this.Line275.Left = 0.7535F;
			this.Line275.LineWeight = 1F;
			this.Line275.Name = "Line275";
			this.Line275.Top = 0.429F;
			this.Line275.Width = 3.7495F;
			this.Line275.X1 = 0.7535F;
			this.Line275.X2 = 4.503F;
			this.Line275.Y1 = 0.429F;
			this.Line275.Y2 = 0.429F;
			// 
			// Label20
			// 
			this.Label20.Height = 0.286F;
			this.Label20.HyperLink = null;
			this.Label20.Left = 0.3125F;
			this.Label20.Name = "Label20";
			this.Label20.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label20.Text = "1";
			this.Label20.Top = 0.5720001F;
			this.Label20.Width = 0.253F;
			// 
			// Line276
			// 
			this.Line276.Height = 3.432F;
			this.Line276.Left = 0.5654999F;
			this.Line276.LineWeight = 1F;
			this.Line276.Name = "Line276";
			this.Line276.Top = 0.5720001F;
			this.Line276.Width = 0F;
			this.Line276.X1 = 0.5654999F;
			this.Line276.X2 = 0.5654999F;
			this.Line276.Y1 = 0.5720001F;
			this.Line276.Y2 = 4.004F;
			// 
			// SlryPaymnt1mm
			// 
			this.SlryPaymnt1mm.DataField = "SLRY_PAYMNT_1MM";
			this.SlryPaymnt1mm.Height = 0.143F;
			this.SlryPaymnt1mm.Left = 0.5654999F;
			this.SlryPaymnt1mm.Name = "SlryPaymnt1mm";
			this.SlryPaymnt1mm.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.SlryPaymnt1mm.Text = "66";
			this.SlryPaymnt1mm.Top = 0.5720001F;
			this.SlryPaymnt1mm.Width = 0.187F;
			// 
			// Line277
			// 
			this.Line277.Height = 0F;
			this.Line277.Left = 0.5654999F;
			this.Line277.LineWeight = 1F;
			this.Line277.Name = "Line277";
			this.Line277.Top = 0.715F;
			this.Line277.Width = 3.9375F;
			this.Line277.X1 = 0.5654999F;
			this.Line277.X2 = 4.503F;
			this.Line277.Y1 = 0.715F;
			this.Line277.Y2 = 0.715F;
			// 
			// SlryPaymnt1dd
			// 
			this.SlryPaymnt1dd.DataField = "SLRY_PAYMNT_1DD";
			this.SlryPaymnt1dd.Height = 0.143F;
			this.SlryPaymnt1dd.Left = 0.5654999F;
			this.SlryPaymnt1dd.Name = "SlryPaymnt1dd";
			this.SlryPaymnt1dd.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.SlryPaymnt1dd.Text = "66";
			this.SlryPaymnt1dd.Top = 0.715F;
			this.SlryPaymnt1dd.Width = 0.187F;
			// 
			// Paymnt1Amt1
			// 
			this.Paymnt1Amt1.DataField = "PAYMNT_1AMT1";
			this.Paymnt1Amt1.Height = 0.143F;
			this.Paymnt1Amt1.Left = 0.7525F;
			this.Paymnt1Amt1.Name = "Paymnt1Amt1";
			this.Paymnt1Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt1.Top = 0.5720001F;
			this.Paymnt1Amt1.Width = 0.625F;
			// 
			// Ded1Amt1
			// 
			this.Ded1Amt1.DataField = "DED_1AMT1";
			this.Ded1Amt1.Height = 0.143F;
			this.Ded1Amt1.Left = 0.7525F;
			this.Ded1Amt1.Name = "Ded1Amt1";
			this.Ded1Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt1.Top = 0.715F;
			this.Ded1Amt1.Width = 0.625F;
			// 
			// Paymnt1Amt2
			// 
			this.Paymnt1Amt2.DataField = "PAYMNT_1AMT2";
			this.Paymnt1Amt2.Height = 0.143F;
			this.Paymnt1Amt2.Left = 1.3775F;
			this.Paymnt1Amt2.Name = "Paymnt1Amt2";
			this.Paymnt1Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt2.Top = 0.5720001F;
			this.Paymnt1Amt2.Width = 0.625F;
			// 
			// Ded1Amt2
			// 
			this.Ded1Amt2.DataField = "DED_1AMT2";
			this.Ded1Amt2.Height = 0.143F;
			this.Ded1Amt2.Left = 1.3775F;
			this.Ded1Amt2.Name = "Ded1Amt2";
			this.Ded1Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt2.Top = 0.715F;
			this.Ded1Amt2.Width = 0.625F;
			// 
			// Paymnt1Amt3
			// 
			this.Paymnt1Amt3.DataField = "PAYMNT_1AMT3";
			this.Paymnt1Amt3.Height = 0.143F;
			this.Paymnt1Amt3.Left = 2.0025F;
			this.Paymnt1Amt3.Name = "Paymnt1Amt3";
			this.Paymnt1Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt3.Top = 0.5720001F;
			this.Paymnt1Amt3.Width = 0.625F;
			// 
			// Ded1Amt3
			// 
			this.Ded1Amt3.DataField = "DED_1AMT3";
			this.Ded1Amt3.Height = 0.143F;
			this.Ded1Amt3.Left = 2.0025F;
			this.Ded1Amt3.Name = "Ded1Amt3";
			this.Ded1Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt3.Top = 0.715F;
			this.Ded1Amt3.Width = 0.625F;
			// 
			// Paymnt1Amt4
			// 
			this.Paymnt1Amt4.DataField = "PAYMNT_1AMT4";
			this.Paymnt1Amt4.Height = 0.143F;
			this.Paymnt1Amt4.Left = 2.6275F;
			this.Paymnt1Amt4.Name = "Paymnt1Amt4";
			this.Paymnt1Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt4.Top = 0.5720001F;
			this.Paymnt1Amt4.Width = 0.625F;
			// 
			// Ded1Amt4
			// 
			this.Ded1Amt4.DataField = "DED_1AMT4";
			this.Ded1Amt4.Height = 0.143F;
			this.Ded1Amt4.Left = 2.6275F;
			this.Ded1Amt4.Name = "Ded1Amt4";
			this.Ded1Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt4.Top = 0.715F;
			this.Ded1Amt4.Width = 0.625F;
			// 
			// Paymnt1Amt5
			// 
			this.Paymnt1Amt5.DataField = "PAYMNT_1AMT5";
			this.Paymnt1Amt5.Height = 0.143F;
			this.Paymnt1Amt5.Left = 3.2525F;
			this.Paymnt1Amt5.Name = "Paymnt1Amt5";
			this.Paymnt1Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt5.Top = 0.5720001F;
			this.Paymnt1Amt5.Width = 0.625F;
			// 
			// Ded1Amt5
			// 
			this.Ded1Amt5.DataField = "DED_1AMT5";
			this.Ded1Amt5.Height = 0.143F;
			this.Ded1Amt5.Left = 3.2525F;
			this.Ded1Amt5.Name = "Ded1Amt5";
			this.Ded1Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt5.Top = 0.715F;
			this.Ded1Amt5.Width = 0.625F;
			// 
			// Paymnt1Amt6
			// 
			this.Paymnt1Amt6.DataField = "PAYMNT_1AMT6";
			this.Paymnt1Amt6.Height = 0.143F;
			this.Paymnt1Amt6.Left = 3.8775F;
			this.Paymnt1Amt6.Name = "Paymnt1Amt6";
			this.Paymnt1Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt1Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt1Amt6.Top = 0.5720001F;
			this.Paymnt1Amt6.Width = 0.624F;
			// 
			// Ded1Amt6
			// 
			this.Ded1Amt6.DataField = "DED_1AMT6";
			this.Ded1Amt6.Height = 0.143F;
			this.Ded1Amt6.Left = 3.8775F;
			this.Ded1Amt6.Name = "Ded1Amt6";
			this.Ded1Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded1Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded1Amt6.Top = 0.715F;
			this.Ded1Amt6.Width = 0.624F;
			// 
			// Line282
			// 
			this.Line282.Height = 0F;
			this.Line282.Left = 0.3154999F;
			this.Line282.LineWeight = 1F;
			this.Line282.Name = "Line282";
			this.Line282.Top = 0.858F;
			this.Line282.Width = 4.1875F;
			this.Line282.X1 = 0.3154999F;
			this.Line282.X2 = 4.503F;
			this.Line282.Y1 = 0.858F;
			this.Line282.Y2 = 0.858F;
			// 
			// Line283
			// 
			this.Line283.Height = 0F;
			this.Line283.Left = 0.5654999F;
			this.Line283.LineWeight = 1F;
			this.Line283.Name = "Line283";
			this.Line283.Top = 1.001F;
			this.Line283.Width = 3.9375F;
			this.Line283.X1 = 0.5654999F;
			this.Line283.X2 = 4.503F;
			this.Line283.Y1 = 1.001F;
			this.Line283.Y2 = 1.001F;
			// 
			// Label23
			// 
			this.Label23.Height = 0.286F;
			this.Label23.HyperLink = null;
			this.Label23.Left = 0.3125F;
			this.Label23.Name = "Label23";
			this.Label23.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label23.Text = "2";
			this.Label23.Top = 0.858F;
			this.Label23.Width = 0.253F;
			// 
			// TextBox55
			// 
			this.TextBox55.DataField = "SLRY_PAYMNT_2MM";
			this.TextBox55.Height = 0.143F;
			this.TextBox55.Left = 0.5654999F;
			this.TextBox55.Name = "TextBox55";
			this.TextBox55.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox55.Text = "66";
			this.TextBox55.Top = 0.8586F;
			this.TextBox55.Width = 0.187F;
			// 
			// TextBox56
			// 
			this.TextBox56.DataField = "SLRY_PAYMNT_2DD";
			this.TextBox56.Height = 0.143F;
			this.TextBox56.Left = 0.5654999F;
			this.TextBox56.Name = "TextBox56";
			this.TextBox56.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox56.Text = "66";
			this.TextBox56.Top = 1.001F;
			this.TextBox56.Width = 0.187F;
			// 
			// Paymnt2Amt1
			// 
			this.Paymnt2Amt1.DataField = "PAYMNT_2AMT1";
			this.Paymnt2Amt1.Height = 0.143F;
			this.Paymnt2Amt1.Left = 0.7525F;
			this.Paymnt2Amt1.Name = "Paymnt2Amt1";
			this.Paymnt2Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt1.Top = 0.858F;
			this.Paymnt2Amt1.Width = 0.625F;
			// 
			// Ded2Amt1
			// 
			this.Ded2Amt1.DataField = "DED_2AMT1";
			this.Ded2Amt1.Height = 0.143F;
			this.Ded2Amt1.Left = 0.7525F;
			this.Ded2Amt1.Name = "Ded2Amt1";
			this.Ded2Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt1.Top = 1.001F;
			this.Ded2Amt1.Width = 0.625F;
			// 
			// Paymnt2Amt2
			// 
			this.Paymnt2Amt2.DataField = "PAYMNT_2AMT2";
			this.Paymnt2Amt2.Height = 0.143F;
			this.Paymnt2Amt2.Left = 1.3775F;
			this.Paymnt2Amt2.Name = "Paymnt2Amt2";
			this.Paymnt2Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt2.Top = 0.858F;
			this.Paymnt2Amt2.Width = 0.625F;
			// 
			// Ded2Amt2
			// 
			this.Ded2Amt2.DataField = "DED_2AMT2";
			this.Ded2Amt2.Height = 0.143F;
			this.Ded2Amt2.Left = 1.3775F;
			this.Ded2Amt2.Name = "Ded2Amt2";
			this.Ded2Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt2.Top = 1.001F;
			this.Ded2Amt2.Width = 0.625F;
			// 
			// Paymnt2Amt3
			// 
			this.Paymnt2Amt3.DataField = "PAYMNT_2AMT3";
			this.Paymnt2Amt3.Height = 0.143F;
			this.Paymnt2Amt3.Left = 2.0025F;
			this.Paymnt2Amt3.Name = "Paymnt2Amt3";
			this.Paymnt2Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt3.Top = 0.858F;
			this.Paymnt2Amt3.Width = 0.625F;
			// 
			// Ded2Amt3
			// 
			this.Ded2Amt3.DataField = "DED_2AMT3";
			this.Ded2Amt3.Height = 0.143F;
			this.Ded2Amt3.Left = 2.0025F;
			this.Ded2Amt3.Name = "Ded2Amt3";
			this.Ded2Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt3.Top = 1.001F;
			this.Ded2Amt3.Width = 0.625F;
			// 
			// Paymnt2Amt4
			// 
			this.Paymnt2Amt4.DataField = "PAYMNT_2AMT4";
			this.Paymnt2Amt4.Height = 0.143F;
			this.Paymnt2Amt4.Left = 2.6275F;
			this.Paymnt2Amt4.Name = "Paymnt2Amt4";
			this.Paymnt2Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt4.Top = 0.858F;
			this.Paymnt2Amt4.Width = 0.625F;
			// 
			// Ded2Amt4
			// 
			this.Ded2Amt4.DataField = "DED_2AMT4";
			this.Ded2Amt4.Height = 0.143F;
			this.Ded2Amt4.Left = 2.6275F;
			this.Ded2Amt4.Name = "Ded2Amt4";
			this.Ded2Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt4.Top = 1.001F;
			this.Ded2Amt4.Width = 0.625F;
			// 
			// Paymnt2Amt5
			// 
			this.Paymnt2Amt5.DataField = "PAYMNT_2AMT5";
			this.Paymnt2Amt5.Height = 0.143F;
			this.Paymnt2Amt5.Left = 3.2525F;
			this.Paymnt2Amt5.Name = "Paymnt2Amt5";
			this.Paymnt2Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt5.Top = 0.858F;
			this.Paymnt2Amt5.Width = 0.625F;
			// 
			// Ded2Amt5
			// 
			this.Ded2Amt5.DataField = "DED_2AMT5";
			this.Ded2Amt5.Height = 0.143F;
			this.Ded2Amt5.Left = 3.2525F;
			this.Ded2Amt5.Name = "Ded2Amt5";
			this.Ded2Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt5.Top = 1.001F;
			this.Ded2Amt5.Width = 0.625F;
			// 
			// Paymnt2Amt6
			// 
			this.Paymnt2Amt6.DataField = "PAYMNT_2AMT6";
			this.Paymnt2Amt6.Height = 0.143F;
			this.Paymnt2Amt6.Left = 3.8775F;
			this.Paymnt2Amt6.Name = "Paymnt2Amt6";
			this.Paymnt2Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt2Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt2Amt6.Top = 0.858F;
			this.Paymnt2Amt6.Width = 0.624F;
			// 
			// Ded2Amt6
			// 
			this.Ded2Amt6.DataField = "DED_2AMT6";
			this.Ded2Amt6.Height = 0.143F;
			this.Ded2Amt6.Left = 3.8775F;
			this.Ded2Amt6.Name = "Ded2Amt6";
			this.Ded2Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded2Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded2Amt6.Top = 1.001F;
			this.Ded2Amt6.Width = 0.624F;
			// 
			// Line286
			// 
			this.Line286.Height = 0F;
			this.Line286.Left = 0.3219444F;
			this.Line286.LineWeight = 1F;
			this.Line286.Name = "Line286";
			this.Line286.Top = 1.144F;
			this.Line286.Width = 4.181056F;
			this.Line286.X1 = 0.3219444F;
			this.Line286.X2 = 4.503F;
			this.Line286.Y1 = 1.144F;
			this.Line286.Y2 = 1.144F;
			// 
			// Line287
			// 
			this.Line287.Height = 0F;
			this.Line287.Left = 0.5654999F;
			this.Line287.LineWeight = 1F;
			this.Line287.Name = "Line287";
			this.Line287.Top = 1.287F;
			this.Line287.Width = 3.9375F;
			this.Line287.X1 = 0.5654999F;
			this.Line287.X2 = 4.503F;
			this.Line287.Y1 = 1.287F;
			this.Line287.Y2 = 1.287F;
			// 
			// Label26
			// 
			this.Label26.Height = 0.286F;
			this.Label26.HyperLink = null;
			this.Label26.Left = 0.3125F;
			this.Label26.Name = "Label26";
			this.Label26.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label26.Text = "3";
			this.Label26.Top = 1.144F;
			this.Label26.Width = 0.253F;
			// 
			// TextBox89
			// 
			this.TextBox89.DataField = "SLRY_PAYMNT_3MM";
			this.TextBox89.Height = 0.143F;
			this.TextBox89.Left = 0.5654999F;
			this.TextBox89.Name = "TextBox89";
			this.TextBox89.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox89.Text = "66";
			this.TextBox89.Top = 1.144F;
			this.TextBox89.Width = 0.187F;
			// 
			// TextBox90
			// 
			this.TextBox90.DataField = "SLRY_PAYMNT_3DD";
			this.TextBox90.Height = 0.143F;
			this.TextBox90.Left = 0.5654999F;
			this.TextBox90.Name = "TextBox90";
			this.TextBox90.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox90.Text = "66";
			this.TextBox90.Top = 1.287F;
			this.TextBox90.Width = 0.187F;
			// 
			// Paymnt3Amt1
			// 
			this.Paymnt3Amt1.DataField = "PAYMNT_3AMT1";
			this.Paymnt3Amt1.Height = 0.143F;
			this.Paymnt3Amt1.Left = 0.7525F;
			this.Paymnt3Amt1.Name = "Paymnt3Amt1";
			this.Paymnt3Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt1.Top = 1.144F;
			this.Paymnt3Amt1.Width = 0.625F;
			// 
			// Ded3Amt1
			// 
			this.Ded3Amt1.DataField = "DED_3AMT1";
			this.Ded3Amt1.Height = 0.143F;
			this.Ded3Amt1.Left = 0.7525F;
			this.Ded3Amt1.Name = "Ded3Amt1";
			this.Ded3Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt1.Top = 1.287F;
			this.Ded3Amt1.Width = 0.625F;
			// 
			// Paymnt3Amt2
			// 
			this.Paymnt3Amt2.DataField = "PAYMNT_3AMT2";
			this.Paymnt3Amt2.Height = 0.143F;
			this.Paymnt3Amt2.Left = 1.3775F;
			this.Paymnt3Amt2.Name = "Paymnt3Amt2";
			this.Paymnt3Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt2.Top = 1.144F;
			this.Paymnt3Amt2.Width = 0.625F;
			// 
			// Ded3Amt2
			// 
			this.Ded3Amt2.DataField = "DED_3AMT2";
			this.Ded3Amt2.Height = 0.143F;
			this.Ded3Amt2.Left = 1.3775F;
			this.Ded3Amt2.Name = "Ded3Amt2";
			this.Ded3Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt2.Top = 1.287F;
			this.Ded3Amt2.Width = 0.625F;
			// 
			// Paymnt3Amt3
			// 
			this.Paymnt3Amt3.DataField = "PAYMNT_3AMT3";
			this.Paymnt3Amt3.Height = 0.143F;
			this.Paymnt3Amt3.Left = 2.0025F;
			this.Paymnt3Amt3.Name = "Paymnt3Amt3";
			this.Paymnt3Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt3.Top = 1.144F;
			this.Paymnt3Amt3.Width = 0.625F;
			// 
			// Ded3Amt3
			// 
			this.Ded3Amt3.DataField = "DED_3AMT3";
			this.Ded3Amt3.Height = 0.143F;
			this.Ded3Amt3.Left = 2.0025F;
			this.Ded3Amt3.Name = "Ded3Amt3";
			this.Ded3Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt3.Top = 1.287F;
			this.Ded3Amt3.Width = 0.625F;
			// 
			// Paymnt3Amt4
			// 
			this.Paymnt3Amt4.DataField = "PAYMNT_3AMT4";
			this.Paymnt3Amt4.Height = 0.143F;
			this.Paymnt3Amt4.Left = 2.6275F;
			this.Paymnt3Amt4.Name = "Paymnt3Amt4";
			this.Paymnt3Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt4.Top = 1.144F;
			this.Paymnt3Amt4.Width = 0.625F;
			// 
			// Ded3Amt4
			// 
			this.Ded3Amt4.DataField = "DED_3AMT4";
			this.Ded3Amt4.Height = 0.143F;
			this.Ded3Amt4.Left = 2.6275F;
			this.Ded3Amt4.Name = "Ded3Amt4";
			this.Ded3Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt4.Top = 1.287F;
			this.Ded3Amt4.Width = 0.625F;
			// 
			// Paymnt3Amt5
			// 
			this.Paymnt3Amt5.DataField = "PAYMNT_3AMT5";
			this.Paymnt3Amt5.Height = 0.143F;
			this.Paymnt3Amt5.Left = 3.2525F;
			this.Paymnt3Amt5.Name = "Paymnt3Amt5";
			this.Paymnt3Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt5.Top = 1.144F;
			this.Paymnt3Amt5.Width = 0.625F;
			// 
			// Ded3Amt5
			// 
			this.Ded3Amt5.DataField = "DED_3AMT5";
			this.Ded3Amt5.Height = 0.143F;
			this.Ded3Amt5.Left = 3.2525F;
			this.Ded3Amt5.Name = "Ded3Amt5";
			this.Ded3Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt5.Top = 1.287F;
			this.Ded3Amt5.Width = 0.625F;
			// 
			// Paymnt3Amt6
			// 
			this.Paymnt3Amt6.DataField = "PAYMNT_3AMT6";
			this.Paymnt3Amt6.Height = 0.143F;
			this.Paymnt3Amt6.Left = 3.8775F;
			this.Paymnt3Amt6.Name = "Paymnt3Amt6";
			this.Paymnt3Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt3Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt3Amt6.Top = 1.144F;
			this.Paymnt3Amt6.Width = 0.624F;
			// 
			// Ded3Amt6
			// 
			this.Ded3Amt6.DataField = "DED_3AMT6";
			this.Ded3Amt6.Height = 0.143F;
			this.Ded3Amt6.Left = 3.8775F;
			this.Ded3Amt6.Name = "Ded3Amt6";
			this.Ded3Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded3Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded3Amt6.Top = 1.287F;
			this.Ded3Amt6.Width = 0.624F;
			// 
			// Line289
			// 
			this.Line289.Height = 0F;
			this.Line289.Left = 0.3154999F;
			this.Line289.LineWeight = 1F;
			this.Line289.Name = "Line289";
			this.Line289.Top = 1.43F;
			this.Line289.Width = 4.1875F;
			this.Line289.X1 = 0.3154999F;
			this.Line289.X2 = 4.503F;
			this.Line289.Y1 = 1.43F;
			this.Line289.Y2 = 1.43F;
			// 
			// Label29
			// 
			this.Label29.Height = 0.286F;
			this.Label29.HyperLink = null;
			this.Label29.Left = 0.3125F;
			this.Label29.Name = "Label29";
			this.Label29.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label29.Text = "4";
			this.Label29.Top = 1.43F;
			this.Label29.Width = 0.253F;
			// 
			// TextBox131
			// 
			this.TextBox131.DataField = "SLRY_PAYMNT_4MM";
			this.TextBox131.Height = 0.143F;
			this.TextBox131.Left = 0.5654999F;
			this.TextBox131.Name = "TextBox131";
			this.TextBox131.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox131.Text = "66";
			this.TextBox131.Top = 1.43F;
			this.TextBox131.Width = 0.187F;
			// 
			// Line291
			// 
			this.Line291.Height = 0F;
			this.Line291.Left = 0.5654999F;
			this.Line291.LineWeight = 1F;
			this.Line291.Name = "Line291";
			this.Line291.Top = 1.573F;
			this.Line291.Width = 3.9375F;
			this.Line291.X1 = 0.5654999F;
			this.Line291.X2 = 4.503F;
			this.Line291.Y1 = 1.573F;
			this.Line291.Y2 = 1.573F;
			// 
			// TextBox132
			// 
			this.TextBox132.DataField = "SLRY_PAYMNT_4DD";
			this.TextBox132.Height = 0.143F;
			this.TextBox132.Left = 0.5654999F;
			this.TextBox132.Name = "TextBox132";
			this.TextBox132.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox132.Text = "66";
			this.TextBox132.Top = 1.573F;
			this.TextBox132.Width = 0.187F;
			// 
			// Paymnt4Amt1
			// 
			this.Paymnt4Amt1.DataField = "PAYMNT_4AMT1";
			this.Paymnt4Amt1.Height = 0.143F;
			this.Paymnt4Amt1.Left = 0.7525F;
			this.Paymnt4Amt1.Name = "Paymnt4Amt1";
			this.Paymnt4Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt1.Top = 1.43F;
			this.Paymnt4Amt1.Width = 0.625F;
			// 
			// Ded4Amt1
			// 
			this.Ded4Amt1.DataField = "DED_4AMT1";
			this.Ded4Amt1.Height = 0.143F;
			this.Ded4Amt1.Left = 0.7525F;
			this.Ded4Amt1.Name = "Ded4Amt1";
			this.Ded4Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt1.Top = 1.573F;
			this.Ded4Amt1.Width = 0.625F;
			// 
			// Paymnt4Amt2
			// 
			this.Paymnt4Amt2.DataField = "PAYMNT_4AMT2";
			this.Paymnt4Amt2.Height = 0.143F;
			this.Paymnt4Amt2.Left = 1.3775F;
			this.Paymnt4Amt2.Name = "Paymnt4Amt2";
			this.Paymnt4Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt2.Top = 1.43F;
			this.Paymnt4Amt2.Width = 0.625F;
			// 
			// Ded4Amt2
			// 
			this.Ded4Amt2.DataField = "DED_4AMT2";
			this.Ded4Amt2.Height = 0.143F;
			this.Ded4Amt2.Left = 1.3775F;
			this.Ded4Amt2.Name = "Ded4Amt2";
			this.Ded4Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt2.Top = 1.573F;
			this.Ded4Amt2.Width = 0.625F;
			// 
			// Paymnt4Amt3
			// 
			this.Paymnt4Amt3.DataField = "PAYMNT_4AMT3";
			this.Paymnt4Amt3.Height = 0.143F;
			this.Paymnt4Amt3.Left = 2.0025F;
			this.Paymnt4Amt3.Name = "Paymnt4Amt3";
			this.Paymnt4Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt3.Top = 1.43F;
			this.Paymnt4Amt3.Width = 0.625F;
			// 
			// Ded4Amt3
			// 
			this.Ded4Amt3.DataField = "DED_4AMT3";
			this.Ded4Amt3.Height = 0.143F;
			this.Ded4Amt3.Left = 2.0025F;
			this.Ded4Amt3.Name = "Ded4Amt3";
			this.Ded4Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt3.Top = 1.573F;
			this.Ded4Amt3.Width = 0.625F;
			// 
			// Paymnt4Amt4
			// 
			this.Paymnt4Amt4.DataField = "PAYMNT_4AMT4";
			this.Paymnt4Amt4.Height = 0.143F;
			this.Paymnt4Amt4.Left = 2.6275F;
			this.Paymnt4Amt4.Name = "Paymnt4Amt4";
			this.Paymnt4Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt4.Top = 1.43F;
			this.Paymnt4Amt4.Width = 0.625F;
			// 
			// Ded4Amt4
			// 
			this.Ded4Amt4.DataField = "DED_4AMT4";
			this.Ded4Amt4.Height = 0.143F;
			this.Ded4Amt4.Left = 2.6275F;
			this.Ded4Amt4.Name = "Ded4Amt4";
			this.Ded4Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt4.Top = 1.573F;
			this.Ded4Amt4.Width = 0.625F;
			// 
			// Paymnt4Amt5
			// 
			this.Paymnt4Amt5.DataField = "PAYMNT_4AMT5";
			this.Paymnt4Amt5.Height = 0.143F;
			this.Paymnt4Amt5.Left = 3.2525F;
			this.Paymnt4Amt5.Name = "Paymnt4Amt5";
			this.Paymnt4Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt5.Top = 1.43F;
			this.Paymnt4Amt5.Width = 0.625F;
			// 
			// Ded4Amt5
			// 
			this.Ded4Amt5.DataField = "DED_4AMT5";
			this.Ded4Amt5.Height = 0.143F;
			this.Ded4Amt5.Left = 3.2525F;
			this.Ded4Amt5.Name = "Ded4Amt5";
			this.Ded4Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt5.Top = 1.573F;
			this.Ded4Amt5.Width = 0.625F;
			// 
			// Paymnt4Amt6
			// 
			this.Paymnt4Amt6.DataField = "PAYMNT_4AMT6";
			this.Paymnt4Amt6.Height = 0.143F;
			this.Paymnt4Amt6.Left = 3.8775F;
			this.Paymnt4Amt6.Name = "Paymnt4Amt6";
			this.Paymnt4Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt4Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt4Amt6.Top = 1.43F;
			this.Paymnt4Amt6.Width = 0.624F;
			// 
			// Ded4Amt6
			// 
			this.Ded4Amt6.DataField = "DED_4AMT6";
			this.Ded4Amt6.Height = 0.143F;
			this.Ded4Amt6.Left = 3.8775F;
			this.Ded4Amt6.Name = "Ded4Amt6";
			this.Ded4Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded4Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded4Amt6.Top = 1.573F;
			this.Ded4Amt6.Width = 0.625F;
			// 
			// Line294
			// 
			this.Line294.Height = 0F;
			this.Line294.Left = 0.3154999F;
			this.Line294.LineWeight = 1F;
			this.Line294.Name = "Line294";
			this.Line294.Top = 1.716F;
			this.Line294.Width = 4.1875F;
			this.Line294.X1 = 0.3154999F;
			this.Line294.X2 = 4.503F;
			this.Line294.Y1 = 1.716F;
			this.Line294.Y2 = 1.716F;
			// 
			// Line295
			// 
			this.Line295.Height = 0F;
			this.Line295.Left = 0.5654999F;
			this.Line295.LineWeight = 1F;
			this.Line295.Name = "Line295";
			this.Line295.Top = 1.859F;
			this.Line295.Width = 3.9375F;
			this.Line295.X1 = 0.5654999F;
			this.Line295.X2 = 4.503F;
			this.Line295.Y1 = 1.859F;
			this.Line295.Y2 = 1.859F;
			// 
			// Label32
			// 
			this.Label32.Height = 0.286F;
			this.Label32.HyperLink = null;
			this.Label32.Left = 0.3125F;
			this.Label32.Name = "Label32";
			this.Label32.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label32.Text = "5";
			this.Label32.Top = 1.716F;
			this.Label32.Width = 0.253F;
			// 
			// TextBox157
			// 
			this.TextBox157.DataField = "SLRY_PAYMNT_5MM";
			this.TextBox157.Height = 0.143F;
			this.TextBox157.Left = 0.5654999F;
			this.TextBox157.Name = "TextBox157";
			this.TextBox157.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox157.Text = "66";
			this.TextBox157.Top = 1.716F;
			this.TextBox157.Width = 0.187F;
			// 
			// TextBox158
			// 
			this.TextBox158.DataField = "SLRY_PAYMNT_5DD";
			this.TextBox158.Height = 0.143F;
			this.TextBox158.Left = 0.5654999F;
			this.TextBox158.Name = "TextBox158";
			this.TextBox158.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox158.Text = "66";
			this.TextBox158.Top = 1.859F;
			this.TextBox158.Width = 0.187F;
			// 
			// Paymnt5Amt1
			// 
			this.Paymnt5Amt1.DataField = "PAYMNT_5AMT1";
			this.Paymnt5Amt1.Height = 0.143F;
			this.Paymnt5Amt1.Left = 0.7525F;
			this.Paymnt5Amt1.Name = "Paymnt5Amt1";
			this.Paymnt5Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt1.Top = 1.716F;
			this.Paymnt5Amt1.Width = 0.625F;
			// 
			// Ded5Amt1
			// 
			this.Ded5Amt1.DataField = "DED_5AMT1";
			this.Ded5Amt1.Height = 0.143F;
			this.Ded5Amt1.Left = 0.7525F;
			this.Ded5Amt1.Name = "Ded5Amt1";
			this.Ded5Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt1.Top = 1.859F;
			this.Ded5Amt1.Width = 0.625F;
			// 
			// Paymnt5Amt2
			// 
			this.Paymnt5Amt2.DataField = "PAYMNT_5AMT2";
			this.Paymnt5Amt2.Height = 0.143F;
			this.Paymnt5Amt2.Left = 1.3775F;
			this.Paymnt5Amt2.Name = "Paymnt5Amt2";
			this.Paymnt5Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt2.Top = 1.716F;
			this.Paymnt5Amt2.Width = 0.625F;
			// 
			// Ded5Amt2
			// 
			this.Ded5Amt2.DataField = "DED_5AMT2";
			this.Ded5Amt2.Height = 0.143F;
			this.Ded5Amt2.Left = 1.3775F;
			this.Ded5Amt2.Name = "Ded5Amt2";
			this.Ded5Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt2.Top = 1.859F;
			this.Ded5Amt2.Width = 0.625F;
			// 
			// Paymnt5Amt3
			// 
			this.Paymnt5Amt3.DataField = "PAYMNT_5AMT3";
			this.Paymnt5Amt3.Height = 0.143F;
			this.Paymnt5Amt3.Left = 2.0025F;
			this.Paymnt5Amt3.Name = "Paymnt5Amt3";
			this.Paymnt5Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt3.Top = 1.716F;
			this.Paymnt5Amt3.Width = 0.625F;
			// 
			// Ded5Amt3
			// 
			this.Ded5Amt3.DataField = "DED_5AMT3";
			this.Ded5Amt3.Height = 0.143F;
			this.Ded5Amt3.Left = 2.0025F;
			this.Ded5Amt3.Name = "Ded5Amt3";
			this.Ded5Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt3.Top = 1.859F;
			this.Ded5Amt3.Width = 0.625F;
			// 
			// Paymnt5Amt4
			// 
			this.Paymnt5Amt4.DataField = "PAYMNT_5AMT4";
			this.Paymnt5Amt4.Height = 0.143F;
			this.Paymnt5Amt4.Left = 2.6275F;
			this.Paymnt5Amt4.Name = "Paymnt5Amt4";
			this.Paymnt5Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt4.Top = 1.716F;
			this.Paymnt5Amt4.Width = 0.625F;
			// 
			// Ded5Amt4
			// 
			this.Ded5Amt4.DataField = "DED_5AMT4";
			this.Ded5Amt4.Height = 0.143F;
			this.Ded5Amt4.Left = 2.6275F;
			this.Ded5Amt4.Name = "Ded5Amt4";
			this.Ded5Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt4.Top = 1.859F;
			this.Ded5Amt4.Width = 0.625F;
			// 
			// Paymnt5Amt5
			// 
			this.Paymnt5Amt5.DataField = "PAYMNT_5AMT5";
			this.Paymnt5Amt5.Height = 0.143F;
			this.Paymnt5Amt5.Left = 3.2525F;
			this.Paymnt5Amt5.Name = "Paymnt5Amt5";
			this.Paymnt5Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt5.Top = 1.716F;
			this.Paymnt5Amt5.Width = 0.625F;
			// 
			// Ded5Amt5
			// 
			this.Ded5Amt5.DataField = "DED_5AMT5";
			this.Ded5Amt5.Height = 0.143F;
			this.Ded5Amt5.Left = 3.2525F;
			this.Ded5Amt5.Name = "Ded5Amt5";
			this.Ded5Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt5.Top = 1.859F;
			this.Ded5Amt5.Width = 0.625F;
			// 
			// Paymnt5Amt6
			// 
			this.Paymnt5Amt6.DataField = "PAYMNT_5AMT6";
			this.Paymnt5Amt6.Height = 0.143F;
			this.Paymnt5Amt6.Left = 3.8775F;
			this.Paymnt5Amt6.Name = "Paymnt5Amt6";
			this.Paymnt5Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt5Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt5Amt6.Top = 1.716F;
			this.Paymnt5Amt6.Width = 0.625F;
			// 
			// Ded5Amt6
			// 
			this.Ded5Amt6.DataField = "DED_5AMT6";
			this.Ded5Amt6.Height = 0.143F;
			this.Ded5Amt6.Left = 3.8775F;
			this.Ded5Amt6.Name = "Ded5Amt6";
			this.Ded5Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded5Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded5Amt6.Top = 1.859F;
			this.Ded5Amt6.Width = 0.625F;
			// 
			// Line298
			// 
			this.Line298.Height = 0F;
			this.Line298.Left = 0.3154999F;
			this.Line298.LineWeight = 1F;
			this.Line298.Name = "Line298";
			this.Line298.Top = 2.002F;
			this.Line298.Width = 4.1875F;
			this.Line298.X1 = 0.3154999F;
			this.Line298.X2 = 4.503F;
			this.Line298.Y1 = 2.002F;
			this.Line298.Y2 = 2.002F;
			// 
			// Line299
			// 
			this.Line299.Height = 0F;
			this.Line299.Left = 0.5654999F;
			this.Line299.LineWeight = 1F;
			this.Line299.Name = "Line299";
			this.Line299.Top = 2.145F;
			this.Line299.Width = 3.9375F;
			this.Line299.X1 = 0.5654999F;
			this.Line299.X2 = 4.503F;
			this.Line299.Y1 = 2.145F;
			this.Line299.Y2 = 2.145F;
			// 
			// Label35
			// 
			this.Label35.Height = 0.286F;
			this.Label35.HyperLink = null;
			this.Label35.Left = 0.3125F;
			this.Label35.Name = "Label35";
			this.Label35.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label35.Text = "6";
			this.Label35.Top = 2.002F;
			this.Label35.Width = 0.253F;
			// 
			// TextBox191
			// 
			this.TextBox191.DataField = "SLRY_PAYMNT_6MM";
			this.TextBox191.Height = 0.143F;
			this.TextBox191.Left = 0.5654999F;
			this.TextBox191.Name = "TextBox191";
			this.TextBox191.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox191.Text = "66";
			this.TextBox191.Top = 2.002F;
			this.TextBox191.Width = 0.187F;
			// 
			// TextBox192
			// 
			this.TextBox192.DataField = "SLRY_PAYMNT_6DD";
			this.TextBox192.Height = 0.143F;
			this.TextBox192.Left = 0.5654999F;
			this.TextBox192.Name = "TextBox192";
			this.TextBox192.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox192.Text = "66";
			this.TextBox192.Top = 2.145F;
			this.TextBox192.Width = 0.187F;
			// 
			// Paymnt6Amt1
			// 
			this.Paymnt6Amt1.DataField = "PAYMNT_6AMT1";
			this.Paymnt6Amt1.Height = 0.143F;
			this.Paymnt6Amt1.Left = 0.7525F;
			this.Paymnt6Amt1.Name = "Paymnt6Amt1";
			this.Paymnt6Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt1.Top = 2.002F;
			this.Paymnt6Amt1.Width = 0.625F;
			// 
			// Ded6Amt1
			// 
			this.Ded6Amt1.DataField = "DED_6AMT1";
			this.Ded6Amt1.Height = 0.143F;
			this.Ded6Amt1.Left = 0.7525F;
			this.Ded6Amt1.Name = "Ded6Amt1";
			this.Ded6Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt1.Top = 2.145F;
			this.Ded6Amt1.Width = 0.625F;
			// 
			// Paymnt6Amt2
			// 
			this.Paymnt6Amt2.DataField = "PAYMNT_6AMT2";
			this.Paymnt6Amt2.Height = 0.143F;
			this.Paymnt6Amt2.Left = 1.3775F;
			this.Paymnt6Amt2.Name = "Paymnt6Amt2";
			this.Paymnt6Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt2.Top = 2.002F;
			this.Paymnt6Amt2.Width = 0.625F;
			// 
			// Ded6Amt2
			// 
			this.Ded6Amt2.DataField = "DED_6AMT2";
			this.Ded6Amt2.Height = 0.143F;
			this.Ded6Amt2.Left = 1.3775F;
			this.Ded6Amt2.Name = "Ded6Amt2";
			this.Ded6Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt2.Top = 2.145F;
			this.Ded6Amt2.Width = 0.625F;
			// 
			// Paymnt6Amt3
			// 
			this.Paymnt6Amt3.DataField = "PAYMNT_6AMT3";
			this.Paymnt6Amt3.Height = 0.143F;
			this.Paymnt6Amt3.Left = 2.0025F;
			this.Paymnt6Amt3.Name = "Paymnt6Amt3";
			this.Paymnt6Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt3.Top = 2.002F;
			this.Paymnt6Amt3.Width = 0.625F;
			// 
			// Ded6Amt3
			// 
			this.Ded6Amt3.DataField = "DED_6AMT3";
			this.Ded6Amt3.Height = 0.143F;
			this.Ded6Amt3.Left = 2.0025F;
			this.Ded6Amt3.Name = "Ded6Amt3";
			this.Ded6Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt3.Top = 2.145F;
			this.Ded6Amt3.Width = 0.625F;
			// 
			// Paymnt6Amt4
			// 
			this.Paymnt6Amt4.DataField = "PAYMNT_6AMT4";
			this.Paymnt6Amt4.Height = 0.143F;
			this.Paymnt6Amt4.Left = 2.6275F;
			this.Paymnt6Amt4.Name = "Paymnt6Amt4";
			this.Paymnt6Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt4.Top = 2.002F;
			this.Paymnt6Amt4.Width = 0.625F;
			// 
			// Ded6Amt4
			// 
			this.Ded6Amt4.DataField = "DED_6AMT4";
			this.Ded6Amt4.Height = 0.143F;
			this.Ded6Amt4.Left = 2.6275F;
			this.Ded6Amt4.Name = "Ded6Amt4";
			this.Ded6Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt4.Top = 2.145F;
			this.Ded6Amt4.Width = 0.625F;
			// 
			// Paymnt6Amt5
			// 
			this.Paymnt6Amt5.DataField = "PAYMNT_6AMT5";
			this.Paymnt6Amt5.Height = 0.143F;
			this.Paymnt6Amt5.Left = 3.2525F;
			this.Paymnt6Amt5.Name = "Paymnt6Amt5";
			this.Paymnt6Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt5.Top = 2.002F;
			this.Paymnt6Amt5.Width = 0.625F;
			// 
			// Ded6Amt5
			// 
			this.Ded6Amt5.DataField = "DED_6AMT5";
			this.Ded6Amt5.Height = 0.143F;
			this.Ded6Amt5.Left = 3.2525F;
			this.Ded6Amt5.Name = "Ded6Amt5";
			this.Ded6Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt5.Top = 2.145F;
			this.Ded6Amt5.Width = 0.625F;
			// 
			// Paymnt6Amt6
			// 
			this.Paymnt6Amt6.DataField = "PAYMNT_6AMT6";
			this.Paymnt6Amt6.Height = 0.143F;
			this.Paymnt6Amt6.Left = 3.8775F;
			this.Paymnt6Amt6.Name = "Paymnt6Amt6";
			this.Paymnt6Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt6Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt6Amt6.Top = 2.002F;
			this.Paymnt6Amt6.Width = 0.625F;
			// 
			// Ded6Amt6
			// 
			this.Ded6Amt6.DataField = "DED_6AMT6";
			this.Ded6Amt6.Height = 0.143F;
			this.Ded6Amt6.Left = 3.8775F;
			this.Ded6Amt6.Name = "Ded6Amt6";
			this.Ded6Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded6Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded6Amt6.Top = 2.145F;
			this.Ded6Amt6.Width = 0.625F;
			// 
			// Line301
			// 
			this.Line301.Height = 0F;
			this.Line301.Left = 0.3154999F;
			this.Line301.LineWeight = 1F;
			this.Line301.Name = "Line301";
			this.Line301.Top = 2.288F;
			this.Line301.Width = 4.1875F;
			this.Line301.X1 = 0.3154999F;
			this.Line301.X2 = 4.503F;
			this.Line301.Y1 = 2.288F;
			this.Line301.Y2 = 2.288F;
			// 
			// Label38
			// 
			this.Label38.Height = 0.286F;
			this.Label38.HyperLink = null;
			this.Label38.Left = 0.3125F;
			this.Label38.Name = "Label38";
			this.Label38.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label38.Text = "7";
			this.Label38.Top = 2.288F;
			this.Label38.Width = 0.253F;
			// 
			// TextBox233
			// 
			this.TextBox233.DataField = "SLRY_PAYMNT_7MM";
			this.TextBox233.Height = 0.143F;
			this.TextBox233.Left = 0.5654999F;
			this.TextBox233.Name = "TextBox233";
			this.TextBox233.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox233.Text = "66";
			this.TextBox233.Top = 2.288F;
			this.TextBox233.Width = 0.187F;
			// 
			// Line303
			// 
			this.Line303.Height = 0F;
			this.Line303.Left = 0.5654999F;
			this.Line303.LineWeight = 1F;
			this.Line303.Name = "Line303";
			this.Line303.Top = 2.431F;
			this.Line303.Width = 3.9375F;
			this.Line303.X1 = 0.5654999F;
			this.Line303.X2 = 4.503F;
			this.Line303.Y1 = 2.431F;
			this.Line303.Y2 = 2.431F;
			// 
			// TextBox234
			// 
			this.TextBox234.DataField = "SLRY_PAYMNT_7DD";
			this.TextBox234.Height = 0.143F;
			this.TextBox234.Left = 0.5654999F;
			this.TextBox234.Name = "TextBox234";
			this.TextBox234.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox234.Text = "66";
			this.TextBox234.Top = 2.431F;
			this.TextBox234.Width = 0.187F;
			// 
			// Paymnt7Amt1
			// 
			this.Paymnt7Amt1.DataField = "PAYMNT_7AMT1";
			this.Paymnt7Amt1.Height = 0.143F;
			this.Paymnt7Amt1.Left = 0.7525F;
			this.Paymnt7Amt1.Name = "Paymnt7Amt1";
			this.Paymnt7Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt1.Top = 2.288F;
			this.Paymnt7Amt1.Width = 0.625F;
			// 
			// Ded7Amt1
			// 
			this.Ded7Amt1.DataField = "DED_7AMT1";
			this.Ded7Amt1.Height = 0.143F;
			this.Ded7Amt1.Left = 0.7525F;
			this.Ded7Amt1.Name = "Ded7Amt1";
			this.Ded7Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt1.Top = 2.431F;
			this.Ded7Amt1.Width = 0.625F;
			// 
			// Paymnt7Amt2
			// 
			this.Paymnt7Amt2.DataField = "PAYMNT_7AMT2";
			this.Paymnt7Amt2.Height = 0.143F;
			this.Paymnt7Amt2.Left = 1.3775F;
			this.Paymnt7Amt2.Name = "Paymnt7Amt2";
			this.Paymnt7Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt2.Top = 2.288F;
			this.Paymnt7Amt2.Width = 0.625F;
			// 
			// Ded7Amt2
			// 
			this.Ded7Amt2.DataField = "DED_7AMT2";
			this.Ded7Amt2.Height = 0.143F;
			this.Ded7Amt2.Left = 1.3775F;
			this.Ded7Amt2.Name = "Ded7Amt2";
			this.Ded7Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt2.Top = 2.431F;
			this.Ded7Amt2.Width = 0.625F;
			// 
			// Paymnt7Amt3
			// 
			this.Paymnt7Amt3.DataField = "PAYMNT_7AMT3";
			this.Paymnt7Amt3.Height = 0.143F;
			this.Paymnt7Amt3.Left = 2.0025F;
			this.Paymnt7Amt3.Name = "Paymnt7Amt3";
			this.Paymnt7Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt3.Top = 2.288F;
			this.Paymnt7Amt3.Width = 0.625F;
			// 
			// Ded7Amt3
			// 
			this.Ded7Amt3.DataField = "DED_7AMT3";
			this.Ded7Amt3.Height = 0.143F;
			this.Ded7Amt3.Left = 2.0025F;
			this.Ded7Amt3.Name = "Ded7Amt3";
			this.Ded7Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt3.Top = 2.431F;
			this.Ded7Amt3.Width = 0.625F;
			// 
			// Paymnt7Amt4
			// 
			this.Paymnt7Amt4.DataField = "PAYMNT_7AMT4";
			this.Paymnt7Amt4.Height = 0.143F;
			this.Paymnt7Amt4.Left = 2.6275F;
			this.Paymnt7Amt4.Name = "Paymnt7Amt4";
			this.Paymnt7Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt4.Top = 2.288F;
			this.Paymnt7Amt4.Width = 0.625F;
			// 
			// Ded7Amt4
			// 
			this.Ded7Amt4.DataField = "DED_7AMT4";
			this.Ded7Amt4.Height = 0.143F;
			this.Ded7Amt4.Left = 2.6275F;
			this.Ded7Amt4.Name = "Ded7Amt4";
			this.Ded7Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt4.Top = 2.431F;
			this.Ded7Amt4.Width = 0.625F;
			// 
			// Paymnt7Amt5
			// 
			this.Paymnt7Amt5.DataField = "PAYMNT_7AMT5";
			this.Paymnt7Amt5.Height = 0.143F;
			this.Paymnt7Amt5.Left = 3.2525F;
			this.Paymnt7Amt5.Name = "Paymnt7Amt5";
			this.Paymnt7Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt5.Top = 2.288F;
			this.Paymnt7Amt5.Width = 0.625F;
			// 
			// Ded7Amt5
			// 
			this.Ded7Amt5.DataField = "DED_7AMT5";
			this.Ded7Amt5.Height = 0.143F;
			this.Ded7Amt5.Left = 3.2525F;
			this.Ded7Amt5.Name = "Ded7Amt5";
			this.Ded7Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt5.Top = 2.431F;
			this.Ded7Amt5.Width = 0.625F;
			// 
			// Paymnt7Amt6
			// 
			this.Paymnt7Amt6.DataField = "PAYMNT_7AMT6";
			this.Paymnt7Amt6.Height = 0.143F;
			this.Paymnt7Amt6.Left = 3.8775F;
			this.Paymnt7Amt6.Name = "Paymnt7Amt6";
			this.Paymnt7Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt7Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt7Amt6.Top = 2.288F;
			this.Paymnt7Amt6.Width = 0.625F;
			// 
			// Ded7Amt6
			// 
			this.Ded7Amt6.DataField = "DED_7AMT6";
			this.Ded7Amt6.Height = 0.143F;
			this.Ded7Amt6.Left = 3.8775F;
			this.Ded7Amt6.Name = "Ded7Amt6";
			this.Ded7Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded7Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded7Amt6.Top = 2.431F;
			this.Ded7Amt6.Width = 0.625F;
			// 
			// Line306
			// 
			this.Line306.Height = 0F;
			this.Line306.Left = 0.3154999F;
			this.Line306.LineWeight = 1F;
			this.Line306.Name = "Line306";
			this.Line306.Top = 2.574F;
			this.Line306.Width = 4.1875F;
			this.Line306.X1 = 0.3154999F;
			this.Line306.X2 = 4.503F;
			this.Line306.Y1 = 2.574F;
			this.Line306.Y2 = 2.574F;
			// 
			// Line307
			// 
			this.Line307.Height = 0F;
			this.Line307.Left = 0.5654999F;
			this.Line307.LineWeight = 1F;
			this.Line307.Name = "Line307";
			this.Line307.Top = 2.717F;
			this.Line307.Width = 3.9375F;
			this.Line307.X1 = 0.5654999F;
			this.Line307.X2 = 4.503F;
			this.Line307.Y1 = 2.717F;
			this.Line307.Y2 = 2.717F;
			// 
			// Label41
			// 
			this.Label41.Height = 0.286F;
			this.Label41.HyperLink = null;
			this.Label41.Left = 0.3125F;
			this.Label41.Name = "Label41";
			this.Label41.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label41.Text = "8";
			this.Label41.Top = 2.574F;
			this.Label41.Width = 0.253F;
			// 
			// TextBox259
			// 
			this.TextBox259.DataField = "SLRY_PAYMNT_8MM";
			this.TextBox259.Height = 0.143F;
			this.TextBox259.Left = 0.5654999F;
			this.TextBox259.Name = "TextBox259";
			this.TextBox259.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox259.Text = "66";
			this.TextBox259.Top = 2.574F;
			this.TextBox259.Width = 0.187F;
			// 
			// TextBox260
			// 
			this.TextBox260.DataField = "SLRY_PAYMNT_8DD";
			this.TextBox260.Height = 0.143F;
			this.TextBox260.Left = 0.5654999F;
			this.TextBox260.Name = "TextBox260";
			this.TextBox260.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox260.Text = "66";
			this.TextBox260.Top = 2.717F;
			this.TextBox260.Width = 0.187F;
			// 
			// Paymnt8Amt1
			// 
			this.Paymnt8Amt1.DataField = "PAYMNT_8AMT1";
			this.Paymnt8Amt1.Height = 0.143F;
			this.Paymnt8Amt1.Left = 0.7525F;
			this.Paymnt8Amt1.Name = "Paymnt8Amt1";
			this.Paymnt8Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt1.Top = 2.574F;
			this.Paymnt8Amt1.Width = 0.625F;
			// 
			// Ded8Amt1
			// 
			this.Ded8Amt1.DataField = "DED_8AMT1";
			this.Ded8Amt1.Height = 0.143F;
			this.Ded8Amt1.Left = 0.7525F;
			this.Ded8Amt1.Name = "Ded8Amt1";
			this.Ded8Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt1.Top = 2.717F;
			this.Ded8Amt1.Width = 0.625F;
			// 
			// Paymnt8Amt2
			// 
			this.Paymnt8Amt2.DataField = "PAYMNT_8AMT2";
			this.Paymnt8Amt2.Height = 0.143F;
			this.Paymnt8Amt2.Left = 1.3775F;
			this.Paymnt8Amt2.Name = "Paymnt8Amt2";
			this.Paymnt8Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt2.Top = 2.574F;
			this.Paymnt8Amt2.Width = 0.625F;
			// 
			// Ded8Amt2
			// 
			this.Ded8Amt2.DataField = "DED_8AMT2";
			this.Ded8Amt2.Height = 0.143F;
			this.Ded8Amt2.Left = 1.3775F;
			this.Ded8Amt2.Name = "Ded8Amt2";
			this.Ded8Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt2.Top = 2.717F;
			this.Ded8Amt2.Width = 0.625F;
			// 
			// Paymnt8Amt3
			// 
			this.Paymnt8Amt3.DataField = "PAYMNT_8AMT3";
			this.Paymnt8Amt3.Height = 0.143F;
			this.Paymnt8Amt3.Left = 2.0025F;
			this.Paymnt8Amt3.Name = "Paymnt8Amt3";
			this.Paymnt8Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt3.Top = 2.574F;
			this.Paymnt8Amt3.Width = 0.625F;
			// 
			// Ded8Amt3
			// 
			this.Ded8Amt3.DataField = "DED_8AMT3";
			this.Ded8Amt3.Height = 0.143F;
			this.Ded8Amt3.Left = 2.0025F;
			this.Ded8Amt3.Name = "Ded8Amt3";
			this.Ded8Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt3.Top = 2.717F;
			this.Ded8Amt3.Width = 0.625F;
			// 
			// Paymnt8Amt4
			// 
			this.Paymnt8Amt4.DataField = "PAYMNT_8AMT4";
			this.Paymnt8Amt4.Height = 0.143F;
			this.Paymnt8Amt4.Left = 2.6275F;
			this.Paymnt8Amt4.Name = "Paymnt8Amt4";
			this.Paymnt8Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt4.Top = 2.574F;
			this.Paymnt8Amt4.Width = 0.625F;
			// 
			// Ded8Amt4
			// 
			this.Ded8Amt4.DataField = "DED_8AMT4";
			this.Ded8Amt4.Height = 0.143F;
			this.Ded8Amt4.Left = 2.6275F;
			this.Ded8Amt4.Name = "Ded8Amt4";
			this.Ded8Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt4.Top = 2.717F;
			this.Ded8Amt4.Width = 0.625F;
			// 
			// Paymnt8Amt5
			// 
			this.Paymnt8Amt5.DataField = "PAYMNT_8AMT5";
			this.Paymnt8Amt5.Height = 0.143F;
			this.Paymnt8Amt5.Left = 3.2525F;
			this.Paymnt8Amt5.Name = "Paymnt8Amt5";
			this.Paymnt8Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt5.Top = 2.574F;
			this.Paymnt8Amt5.Width = 0.625F;
			// 
			// Ded8Amt5
			// 
			this.Ded8Amt5.DataField = "DED_8AMT5";
			this.Ded8Amt5.Height = 0.143F;
			this.Ded8Amt5.Left = 3.2525F;
			this.Ded8Amt5.Name = "Ded8Amt5";
			this.Ded8Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt5.Top = 2.717F;
			this.Ded8Amt5.Width = 0.625F;
			// 
			// Paymnt8Amt6
			// 
			this.Paymnt8Amt6.DataField = "PAYMNT_8AMT6";
			this.Paymnt8Amt6.Height = 0.143F;
			this.Paymnt8Amt6.Left = 3.8775F;
			this.Paymnt8Amt6.Name = "Paymnt8Amt6";
			this.Paymnt8Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt8Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt8Amt6.Top = 2.574F;
			this.Paymnt8Amt6.Width = 0.625F;
			// 
			// Ded8Amt6
			// 
			this.Ded8Amt6.DataField = "DED_8AMT6";
			this.Ded8Amt6.Height = 0.143F;
			this.Ded8Amt6.Left = 3.8775F;
			this.Ded8Amt6.Name = "Ded8Amt6";
			this.Ded8Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded8Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded8Amt6.Top = 2.717F;
			this.Ded8Amt6.Width = 0.625F;
			// 
			// Line310
			// 
			this.Line310.Height = 0F;
			this.Line310.Left = 0.3154999F;
			this.Line310.LineWeight = 1F;
			this.Line310.Name = "Line310";
			this.Line310.Top = 2.86F;
			this.Line310.Width = 4.1875F;
			this.Line310.X1 = 0.3154999F;
			this.Line310.X2 = 4.503F;
			this.Line310.Y1 = 2.86F;
			this.Line310.Y2 = 2.86F;
			// 
			// Line311
			// 
			this.Line311.Height = 0F;
			this.Line311.Left = 0.5654999F;
			this.Line311.LineWeight = 1F;
			this.Line311.Name = "Line311";
			this.Line311.Top = 3.003F;
			this.Line311.Width = 3.9375F;
			this.Line311.X1 = 0.5654999F;
			this.Line311.X2 = 4.503F;
			this.Line311.Y1 = 3.003F;
			this.Line311.Y2 = 3.003F;
			// 
			// Label44
			// 
			this.Label44.Height = 0.286F;
			this.Label44.HyperLink = null;
			this.Label44.Left = 0.3125F;
			this.Label44.Name = "Label44";
			this.Label44.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label44.Text = "9";
			this.Label44.Top = 2.86F;
			this.Label44.Width = 0.253F;
			// 
			// TextBox293
			// 
			this.TextBox293.DataField = "SLRY_PAYMNT_9MM";
			this.TextBox293.Height = 0.143F;
			this.TextBox293.Left = 0.5654999F;
			this.TextBox293.Name = "TextBox293";
			this.TextBox293.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox293.Text = "66";
			this.TextBox293.Top = 2.86F;
			this.TextBox293.Width = 0.187F;
			// 
			// TextBox294
			// 
			this.TextBox294.DataField = "SLRY_PAYMNT_9DD";
			this.TextBox294.Height = 0.143F;
			this.TextBox294.Left = 0.5654999F;
			this.TextBox294.Name = "TextBox294";
			this.TextBox294.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox294.Text = "66";
			this.TextBox294.Top = 3.003F;
			this.TextBox294.Width = 0.187F;
			// 
			// Paymnt9Amt1
			// 
			this.Paymnt9Amt1.DataField = "PAYMNT_9AMT1";
			this.Paymnt9Amt1.Height = 0.143F;
			this.Paymnt9Amt1.Left = 0.7525F;
			this.Paymnt9Amt1.Name = "Paymnt9Amt1";
			this.Paymnt9Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt1.Top = 2.86F;
			this.Paymnt9Amt1.Width = 0.625F;
			// 
			// Ded9Amt1
			// 
			this.Ded9Amt1.DataField = "DED_9AMT1";
			this.Ded9Amt1.Height = 0.143F;
			this.Ded9Amt1.Left = 0.7525F;
			this.Ded9Amt1.Name = "Ded9Amt1";
			this.Ded9Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt1.Top = 3.003F;
			this.Ded9Amt1.Width = 0.625F;
			// 
			// Paymnt9Amt2
			// 
			this.Paymnt9Amt2.DataField = "PAYMNT_9AMT2";
			this.Paymnt9Amt2.Height = 0.143F;
			this.Paymnt9Amt2.Left = 1.3775F;
			this.Paymnt9Amt2.Name = "Paymnt9Amt2";
			this.Paymnt9Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt2.Top = 2.86F;
			this.Paymnt9Amt2.Width = 0.625F;
			// 
			// Ded9Amt2
			// 
			this.Ded9Amt2.DataField = "DED_9AMT2";
			this.Ded9Amt2.Height = 0.143F;
			this.Ded9Amt2.Left = 1.3775F;
			this.Ded9Amt2.Name = "Ded9Amt2";
			this.Ded9Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt2.Top = 3.003F;
			this.Ded9Amt2.Width = 0.625F;
			// 
			// Paymnt9Amt3
			// 
			this.Paymnt9Amt3.DataField = "PAYMNT_9AMT3";
			this.Paymnt9Amt3.Height = 0.143F;
			this.Paymnt9Amt3.Left = 2.0025F;
			this.Paymnt9Amt3.Name = "Paymnt9Amt3";
			this.Paymnt9Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt3.Top = 2.86F;
			this.Paymnt9Amt3.Width = 0.625F;
			// 
			// Ded9Amt3
			// 
			this.Ded9Amt3.DataField = "DED_9AMT3";
			this.Ded9Amt3.Height = 0.143F;
			this.Ded9Amt3.Left = 2.0025F;
			this.Ded9Amt3.Name = "Ded9Amt3";
			this.Ded9Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt3.Top = 3.003F;
			this.Ded9Amt3.Width = 0.625F;
			// 
			// Paymnt9Amt4
			// 
			this.Paymnt9Amt4.DataField = "PAYMNT_9AMT4";
			this.Paymnt9Amt4.Height = 0.143F;
			this.Paymnt9Amt4.Left = 2.6275F;
			this.Paymnt9Amt4.Name = "Paymnt9Amt4";
			this.Paymnt9Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt4.Top = 2.86F;
			this.Paymnt9Amt4.Width = 0.625F;
			// 
			// Ded9Amt4
			// 
			this.Ded9Amt4.DataField = "DED_9AMT4";
			this.Ded9Amt4.Height = 0.143F;
			this.Ded9Amt4.Left = 2.6275F;
			this.Ded9Amt4.Name = "Ded9Amt4";
			this.Ded9Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt4.Top = 3.003F;
			this.Ded9Amt4.Width = 0.625F;
			// 
			// Paymnt9Amt5
			// 
			this.Paymnt9Amt5.DataField = "PAYMNT_9AMT5";
			this.Paymnt9Amt5.Height = 0.143F;
			this.Paymnt9Amt5.Left = 3.2525F;
			this.Paymnt9Amt5.Name = "Paymnt9Amt5";
			this.Paymnt9Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt5.Top = 2.86F;
			this.Paymnt9Amt5.Width = 0.625F;
			// 
			// Ded9Amt5
			// 
			this.Ded9Amt5.DataField = "DED_9AMT5";
			this.Ded9Amt5.Height = 0.143F;
			this.Ded9Amt5.Left = 3.2525F;
			this.Ded9Amt5.Name = "Ded9Amt5";
			this.Ded9Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt5.Top = 3.003F;
			this.Ded9Amt5.Width = 0.625F;
			// 
			// Paymnt9Amt6
			// 
			this.Paymnt9Amt6.DataField = "PAYMNT_9AMT6";
			this.Paymnt9Amt6.Height = 0.143F;
			this.Paymnt9Amt6.Left = 3.8775F;
			this.Paymnt9Amt6.Name = "Paymnt9Amt6";
			this.Paymnt9Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Paymnt9Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt9Amt6.Top = 2.86F;
			this.Paymnt9Amt6.Width = 0.625F;
			// 
			// Ded9Amt6
			// 
			this.Ded9Amt6.DataField = "DED_9AMT6";
			this.Ded9Amt6.Height = 0.143F;
			this.Ded9Amt6.Left = 3.8775F;
			this.Ded9Amt6.Name = "Ded9Amt6";
			this.Ded9Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Ded9Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded9Amt6.Top = 3.003F;
			this.Ded9Amt6.Width = 0.625F;
			// 
			// Line313
			// 
			this.Line313.Height = 0F;
			this.Line313.Left = 0.3154999F;
			this.Line313.LineWeight = 1F;
			this.Line313.Name = "Line313";
			this.Line313.Top = 3.146F;
			this.Line313.Width = 4.1875F;
			this.Line313.X1 = 0.3154999F;
			this.Line313.X2 = 4.503F;
			this.Line313.Y1 = 3.146F;
			this.Line313.Y2 = 3.146F;
			// 
			// Label47
			// 
			this.Label47.Height = 0.286F;
			this.Label47.HyperLink = null;
			this.Label47.Left = 0.3125F;
			this.Label47.Name = "Label47";
			this.Label47.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label47.Text = "10";
			this.Label47.Top = 3.146F;
			this.Label47.Width = 0.253F;
			// 
			// TextBox335
			// 
			this.TextBox335.DataField = "SLRY_PAYMNT_10MM";
			this.TextBox335.Height = 0.143F;
			this.TextBox335.Left = 0.5654999F;
			this.TextBox335.Name = "TextBox335";
			this.TextBox335.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox335.Text = "66";
			this.TextBox335.Top = 3.146F;
			this.TextBox335.Width = 0.187F;
			// 
			// Line315
			// 
			this.Line315.Height = 0F;
			this.Line315.Left = 0.5654999F;
			this.Line315.LineWeight = 1F;
			this.Line315.Name = "Line315";
			this.Line315.Top = 3.289F;
			this.Line315.Width = 3.9375F;
			this.Line315.X1 = 0.5654999F;
			this.Line315.X2 = 4.503F;
			this.Line315.Y1 = 3.289F;
			this.Line315.Y2 = 3.289F;
			// 
			// TextBox336
			// 
			this.TextBox336.DataField = "SLRY_PAYMNT_10DD";
			this.TextBox336.Height = 0.143F;
			this.TextBox336.Left = 0.5654999F;
			this.TextBox336.Name = "TextBox336";
			this.TextBox336.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox336.Text = "66";
			this.TextBox336.Top = 3.289F;
			this.TextBox336.Width = 0.187F;
			// 
			// Paymnt10Amt1
			// 
			this.Paymnt10Amt1.DataField = "PAYMNT_10AMT1";
			this.Paymnt10Amt1.Height = 0.143F;
			this.Paymnt10Amt1.Left = 0.7525F;
			this.Paymnt10Amt1.Name = "Paymnt10Amt1";
			this.Paymnt10Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt1.Top = 3.146F;
			this.Paymnt10Amt1.Width = 0.625F;
			// 
			// Ded10Amt1
			// 
			this.Ded10Amt1.DataField = "DED_10AMT1";
			this.Ded10Amt1.Height = 0.143F;
			this.Ded10Amt1.Left = 0.7525F;
			this.Ded10Amt1.Name = "Ded10Amt1";
			this.Ded10Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt1.Top = 3.289F;
			this.Ded10Amt1.Width = 0.625F;
			// 
			// Paymnt10Amt2
			// 
			this.Paymnt10Amt2.DataField = "PAYMNT_10AMT2";
			this.Paymnt10Amt2.Height = 0.143F;
			this.Paymnt10Amt2.Left = 1.3775F;
			this.Paymnt10Amt2.Name = "Paymnt10Amt2";
			this.Paymnt10Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt2.Top = 3.146F;
			this.Paymnt10Amt2.Width = 0.625F;
			// 
			// Ded10Amt2
			// 
			this.Ded10Amt2.DataField = "DED_10AMT2";
			this.Ded10Amt2.Height = 0.143F;
			this.Ded10Amt2.Left = 1.3775F;
			this.Ded10Amt2.Name = "Ded10Amt2";
			this.Ded10Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt2.Top = 3.289F;
			this.Ded10Amt2.Width = 0.625F;
			// 
			// Paymnt10Amt3
			// 
			this.Paymnt10Amt3.DataField = "PAYMNT_10AMT3";
			this.Paymnt10Amt3.Height = 0.143F;
			this.Paymnt10Amt3.Left = 2.0025F;
			this.Paymnt10Amt3.Name = "Paymnt10Amt3";
			this.Paymnt10Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt3.Top = 3.146F;
			this.Paymnt10Amt3.Width = 0.625F;
			// 
			// Ded10Amt3
			// 
			this.Ded10Amt3.DataField = "DED_10AMT3";
			this.Ded10Amt3.Height = 0.143F;
			this.Ded10Amt3.Left = 2.0025F;
			this.Ded10Amt3.Name = "Ded10Amt3";
			this.Ded10Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt3.Top = 3.289F;
			this.Ded10Amt3.Width = 0.625F;
			// 
			// Paymnt10Amt4
			// 
			this.Paymnt10Amt4.DataField = "PAYMNT_10AMT4";
			this.Paymnt10Amt4.Height = 0.143F;
			this.Paymnt10Amt4.Left = 2.6275F;
			this.Paymnt10Amt4.Name = "Paymnt10Amt4";
			this.Paymnt10Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt4.Top = 3.146F;
			this.Paymnt10Amt4.Width = 0.625F;
			// 
			// Ded10Amt4
			// 
			this.Ded10Amt4.DataField = "DED_10AMT4";
			this.Ded10Amt4.Height = 0.143F;
			this.Ded10Amt4.Left = 2.6275F;
			this.Ded10Amt4.Name = "Ded10Amt4";
			this.Ded10Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt4.Top = 3.289F;
			this.Ded10Amt4.Width = 0.625F;
			// 
			// Paymnt10Amt5
			// 
			this.Paymnt10Amt5.DataField = "PAYMNT_10AMT5";
			this.Paymnt10Amt5.Height = 0.143F;
			this.Paymnt10Amt5.Left = 3.2525F;
			this.Paymnt10Amt5.Name = "Paymnt10Amt5";
			this.Paymnt10Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt5.Top = 3.146F;
			this.Paymnt10Amt5.Width = 0.625F;
			// 
			// Ded10Amt5
			// 
			this.Ded10Amt5.DataField = "DED_10AMT5";
			this.Ded10Amt5.Height = 0.143F;
			this.Ded10Amt5.Left = 3.2525F;
			this.Ded10Amt5.Name = "Ded10Amt5";
			this.Ded10Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt5.Top = 3.289F;
			this.Ded10Amt5.Width = 0.625F;
			// 
			// Paymnt10Amt6
			// 
			this.Paymnt10Amt6.DataField = "PAYMNT_10AMT6";
			this.Paymnt10Amt6.Height = 0.143F;
			this.Paymnt10Amt6.Left = 3.8775F;
			this.Paymnt10Amt6.Name = "Paymnt10Amt6";
			this.Paymnt10Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt10Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt10Amt6.Top = 3.146F;
			this.Paymnt10Amt6.Width = 0.625F;
			// 
			// Ded10Amt6
			// 
			this.Ded10Amt6.DataField = "DED_10AMT6";
			this.Ded10Amt6.Height = 0.143F;
			this.Ded10Amt6.Left = 3.8775F;
			this.Ded10Amt6.Name = "Ded10Amt6";
			this.Ded10Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded10Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded10Amt6.Top = 3.289F;
			this.Ded10Amt6.Width = 0.625F;
			// 
			// Line318
			// 
			this.Line318.Height = 0F;
			this.Line318.Left = 0.3154999F;
			this.Line318.LineWeight = 1F;
			this.Line318.Name = "Line318";
			this.Line318.Top = 3.432F;
			this.Line318.Width = 4.1875F;
			this.Line318.X1 = 0.3154999F;
			this.Line318.X2 = 4.503F;
			this.Line318.Y1 = 3.432F;
			this.Line318.Y2 = 3.432F;
			// 
			// Line319
			// 
			this.Line319.Height = 0F;
			this.Line319.Left = 0.5654999F;
			this.Line319.LineWeight = 1F;
			this.Line319.Name = "Line319";
			this.Line319.Top = 3.575F;
			this.Line319.Width = 3.9375F;
			this.Line319.X1 = 0.5654999F;
			this.Line319.X2 = 4.503F;
			this.Line319.Y1 = 3.575F;
			this.Line319.Y2 = 3.575F;
			// 
			// Label50
			// 
			this.Label50.Height = 0.286F;
			this.Label50.HyperLink = null;
			this.Label50.Left = 0.3125F;
			this.Label50.Name = "Label50";
			this.Label50.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label50.Text = "11";
			this.Label50.Top = 3.432F;
			this.Label50.Width = 0.253F;
			// 
			// TextBox361
			// 
			this.TextBox361.DataField = "SLRY_PAYMNT_11MM";
			this.TextBox361.Height = 0.143F;
			this.TextBox361.Left = 0.5654999F;
			this.TextBox361.Name = "TextBox361";
			this.TextBox361.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox361.Text = "66";
			this.TextBox361.Top = 3.432F;
			this.TextBox361.Width = 0.187F;
			// 
			// TextBox362
			// 
			this.TextBox362.DataField = "SLRY_PAYMNT_11DD";
			this.TextBox362.Height = 0.143F;
			this.TextBox362.Left = 0.5654999F;
			this.TextBox362.Name = "TextBox362";
			this.TextBox362.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox362.Text = "66";
			this.TextBox362.Top = 3.575F;
			this.TextBox362.Width = 0.187F;
			// 
			// Paymnt11Amt1
			// 
			this.Paymnt11Amt1.DataField = "PAYMNT_11AMT1";
			this.Paymnt11Amt1.Height = 0.143F;
			this.Paymnt11Amt1.Left = 0.7525F;
			this.Paymnt11Amt1.Name = "Paymnt11Amt1";
			this.Paymnt11Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt1.Top = 3.432F;
			this.Paymnt11Amt1.Width = 0.625F;
			// 
			// Ded11Amt1
			// 
			this.Ded11Amt1.DataField = "DED_11AMT1";
			this.Ded11Amt1.Height = 0.143F;
			this.Ded11Amt1.Left = 0.7525F;
			this.Ded11Amt1.Name = "Ded11Amt1";
			this.Ded11Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt1.Top = 3.575F;
			this.Ded11Amt1.Width = 0.625F;
			// 
			// Paymnt11Amt2
			// 
			this.Paymnt11Amt2.DataField = "PAYMNT_11AMT2";
			this.Paymnt11Amt2.Height = 0.143F;
			this.Paymnt11Amt2.Left = 1.3775F;
			this.Paymnt11Amt2.Name = "Paymnt11Amt2";
			this.Paymnt11Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt2.Top = 3.432F;
			this.Paymnt11Amt2.Width = 0.625F;
			// 
			// Ded11Amt2
			// 
			this.Ded11Amt2.DataField = "DED_11AMT2";
			this.Ded11Amt2.Height = 0.143F;
			this.Ded11Amt2.Left = 1.3775F;
			this.Ded11Amt2.Name = "Ded11Amt2";
			this.Ded11Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt2.Top = 3.575F;
			this.Ded11Amt2.Width = 0.625F;
			// 
			// Paymnt11Amt3
			// 
			this.Paymnt11Amt3.DataField = "PAYMNT_11AMT3";
			this.Paymnt11Amt3.Height = 0.143F;
			this.Paymnt11Amt3.Left = 2.0025F;
			this.Paymnt11Amt3.Name = "Paymnt11Amt3";
			this.Paymnt11Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt3.Top = 3.432F;
			this.Paymnt11Amt3.Width = 0.625F;
			// 
			// Ded11Amt3
			// 
			this.Ded11Amt3.DataField = "DED_11AMT3";
			this.Ded11Amt3.Height = 0.143F;
			this.Ded11Amt3.Left = 2.0025F;
			this.Ded11Amt3.Name = "Ded11Amt3";
			this.Ded11Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt3.Top = 3.575F;
			this.Ded11Amt3.Width = 0.625F;
			// 
			// Paymnt11Amt4
			// 
			this.Paymnt11Amt4.DataField = "PAYMNT_11AMT4";
			this.Paymnt11Amt4.Height = 0.143F;
			this.Paymnt11Amt4.Left = 2.6275F;
			this.Paymnt11Amt4.Name = "Paymnt11Amt4";
			this.Paymnt11Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt4.Top = 3.432F;
			this.Paymnt11Amt4.Width = 0.625F;
			// 
			// Ded11Amt4
			// 
			this.Ded11Amt4.DataField = "DED_11AMT4";
			this.Ded11Amt4.Height = 0.143F;
			this.Ded11Amt4.Left = 2.6275F;
			this.Ded11Amt4.Name = "Ded11Amt4";
			this.Ded11Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt4.Top = 3.575F;
			this.Ded11Amt4.Width = 0.625F;
			// 
			// Paymnt11Amt5
			// 
			this.Paymnt11Amt5.DataField = "PAYMNT_11AMT5";
			this.Paymnt11Amt5.Height = 0.143F;
			this.Paymnt11Amt5.Left = 3.2525F;
			this.Paymnt11Amt5.Name = "Paymnt11Amt5";
			this.Paymnt11Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt5.Top = 3.432F;
			this.Paymnt11Amt5.Width = 0.625F;
			// 
			// Ded11Amt5
			// 
			this.Ded11Amt5.DataField = "DED_11AMT5";
			this.Ded11Amt5.Height = 0.143F;
			this.Ded11Amt5.Left = 3.2525F;
			this.Ded11Amt5.Name = "Ded11Amt5";
			this.Ded11Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt5.Top = 3.575F;
			this.Ded11Amt5.Width = 0.625F;
			// 
			// Paymnt11Amt6
			// 
			this.Paymnt11Amt6.DataField = "PAYMNT_11AMT6";
			this.Paymnt11Amt6.Height = 0.143F;
			this.Paymnt11Amt6.Left = 3.8775F;
			this.Paymnt11Amt6.Name = "Paymnt11Amt6";
			this.Paymnt11Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt11Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt11Amt6.Top = 3.432F;
			this.Paymnt11Amt6.Width = 0.625F;
			// 
			// Ded11Amt6
			// 
			this.Ded11Amt6.DataField = "DED_11AMT6";
			this.Ded11Amt6.Height = 0.143F;
			this.Ded11Amt6.Left = 3.8775F;
			this.Ded11Amt6.Name = "Ded11Amt6";
			this.Ded11Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded11Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded11Amt6.Top = 3.575F;
			this.Ded11Amt6.Width = 0.625F;
			// 
			// Line322
			// 
			this.Line322.Height = 0F;
			this.Line322.Left = 0.3154999F;
			this.Line322.LineWeight = 1F;
			this.Line322.Name = "Line322";
			this.Line322.Top = 3.718F;
			this.Line322.Width = 4.1875F;
			this.Line322.X1 = 0.3154999F;
			this.Line322.X2 = 4.503F;
			this.Line322.Y1 = 3.718F;
			this.Line322.Y2 = 3.718F;
			// 
			// Line323
			// 
			this.Line323.Height = 0F;
			this.Line323.Left = 0.5654999F;
			this.Line323.LineWeight = 1F;
			this.Line323.Name = "Line323";
			this.Line323.Top = 3.861F;
			this.Line323.Width = 3.9375F;
			this.Line323.X1 = 0.5654999F;
			this.Line323.X2 = 4.503F;
			this.Line323.Y1 = 3.861F;
			this.Line323.Y2 = 3.861F;
			// 
			// Label53
			// 
			this.Label53.Height = 0.286F;
			this.Label53.HyperLink = null;
			this.Label53.Left = 0.3125F;
			this.Label53.Name = "Label53";
			this.Label53.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label53.Text = "12";
			this.Label53.Top = 3.718F;
			this.Label53.Width = 0.253F;
			// 
			// TextBox395
			// 
			this.TextBox395.DataField = "SLRY_PAYMNT_12MM";
			this.TextBox395.Height = 0.143F;
			this.TextBox395.Left = 0.5654999F;
			this.TextBox395.Name = "TextBox395";
			this.TextBox395.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox395.Text = "66";
			this.TextBox395.Top = 3.718F;
			this.TextBox395.Width = 0.187F;
			// 
			// TextBox396
			// 
			this.TextBox396.DataField = "SLRY_PAYMNT_12DD";
			this.TextBox396.Height = 0.143F;
			this.TextBox396.Left = 0.5654999F;
			this.TextBox396.Name = "TextBox396";
			this.TextBox396.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox396.Text = "66";
			this.TextBox396.Top = 3.861F;
			this.TextBox396.Width = 0.187F;
			// 
			// Paymnt12Amt1
			// 
			this.Paymnt12Amt1.DataField = "PAYMNT_12AMT1";
			this.Paymnt12Amt1.Height = 0.143F;
			this.Paymnt12Amt1.Left = 0.7525F;
			this.Paymnt12Amt1.Name = "Paymnt12Amt1";
			this.Paymnt12Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt1.Top = 3.718F;
			this.Paymnt12Amt1.Width = 0.625F;
			// 
			// Ded12Amt1
			// 
			this.Ded12Amt1.DataField = "DED_12AMT1";
			this.Ded12Amt1.Height = 0.143F;
			this.Ded12Amt1.Left = 0.7525F;
			this.Ded12Amt1.Name = "Ded12Amt1";
			this.Ded12Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt1.Top = 3.861F;
			this.Ded12Amt1.Width = 0.625F;
			// 
			// Paymnt12Amt2
			// 
			this.Paymnt12Amt2.DataField = "PAYMNT_12AMT2";
			this.Paymnt12Amt2.Height = 0.143F;
			this.Paymnt12Amt2.Left = 1.3775F;
			this.Paymnt12Amt2.Name = "Paymnt12Amt2";
			this.Paymnt12Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt2.Top = 3.718F;
			this.Paymnt12Amt2.Width = 0.625F;
			// 
			// Ded12Amt2
			// 
			this.Ded12Amt2.DataField = "DED_12AMT2";
			this.Ded12Amt2.Height = 0.143F;
			this.Ded12Amt2.Left = 1.3775F;
			this.Ded12Amt2.Name = "Ded12Amt2";
			this.Ded12Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt2.Top = 3.861F;
			this.Ded12Amt2.Width = 0.625F;
			// 
			// Paymnt12Amt3
			// 
			this.Paymnt12Amt3.DataField = "PAYMNT_12AMT3";
			this.Paymnt12Amt3.Height = 0.143F;
			this.Paymnt12Amt3.Left = 2.0025F;
			this.Paymnt12Amt3.Name = "Paymnt12Amt3";
			this.Paymnt12Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt3.Top = 3.718F;
			this.Paymnt12Amt3.Width = 0.625F;
			// 
			// Ded12Amt3
			// 
			this.Ded12Amt3.DataField = "DED_12AMT3";
			this.Ded12Amt3.Height = 0.143F;
			this.Ded12Amt3.Left = 2.0025F;
			this.Ded12Amt3.Name = "Ded12Amt3";
			this.Ded12Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt3.Top = 3.861F;
			this.Ded12Amt3.Width = 0.625F;
			// 
			// Paymnt12Amt4
			// 
			this.Paymnt12Amt4.DataField = "PAYMNT_12AMT4";
			this.Paymnt12Amt4.Height = 0.143F;
			this.Paymnt12Amt4.Left = 2.6275F;
			this.Paymnt12Amt4.Name = "Paymnt12Amt4";
			this.Paymnt12Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt4.Top = 3.718F;
			this.Paymnt12Amt4.Width = 0.625F;
			// 
			// Ded12Amt4
			// 
			this.Ded12Amt4.DataField = "DED_12AMT4";
			this.Ded12Amt4.Height = 0.143F;
			this.Ded12Amt4.Left = 2.6275F;
			this.Ded12Amt4.Name = "Ded12Amt4";
			this.Ded12Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt4.Top = 3.861F;
			this.Ded12Amt4.Width = 0.625F;
			// 
			// Paymnt12Amt5
			// 
			this.Paymnt12Amt5.DataField = "PAYMNT_12AMT5";
			this.Paymnt12Amt5.Height = 0.143F;
			this.Paymnt12Amt5.Left = 3.2525F;
			this.Paymnt12Amt5.Name = "Paymnt12Amt5";
			this.Paymnt12Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt5.Top = 3.718F;
			this.Paymnt12Amt5.Width = 0.625F;
			// 
			// Ded12Amt5
			// 
			this.Ded12Amt5.DataField = "DED_12AMT5";
			this.Ded12Amt5.Height = 0.143F;
			this.Ded12Amt5.Left = 3.2525F;
			this.Ded12Amt5.Name = "Ded12Amt5";
			this.Ded12Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt5.Top = 3.861F;
			this.Ded12Amt5.Width = 0.625F;
			// 
			// Paymnt12Amt6
			// 
			this.Paymnt12Amt6.DataField = "PAYMNT_12AMT6";
			this.Paymnt12Amt6.Height = 0.143F;
			this.Paymnt12Amt6.Left = 3.8775F;
			this.Paymnt12Amt6.Name = "Paymnt12Amt6";
			this.Paymnt12Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt12Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt12Amt6.Top = 3.718F;
			this.Paymnt12Amt6.Width = 0.625F;
			// 
			// Ded12Amt6
			// 
			this.Ded12Amt6.DataField = "DED_12AMT6";
			this.Ded12Amt6.Height = 0.143F;
			this.Ded12Amt6.Left = 3.8775F;
			this.Ded12Amt6.Name = "Ded12Amt6";
			this.Ded12Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded12Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded12Amt6.Top = 3.861F;
			this.Ded12Amt6.Width = 0.625F;
			// 
			// Line325
			// 
			this.Line325.Height = 0F;
			this.Line325.Left = 0.3154999F;
			this.Line325.LineWeight = 1F;
			this.Line325.Name = "Line325";
			this.Line325.Top = 4.004F;
			this.Line325.Width = 4.1875F;
			this.Line325.X1 = 0.3154999F;
			this.Line325.X2 = 4.503F;
			this.Line325.Y1 = 4.004F;
			this.Line325.Y2 = 4.004F;
			// 
			// Label56
			// 
			this.Label56.Height = 0.286F;
			this.Label56.HyperLink = null;
			this.Label56.Left = 0.3125F;
			this.Label56.Name = "Label56";
			this.Label56.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label56.Text = "合計";
			this.Label56.Top = 4.004F;
			this.Label56.Width = 0.44F;
			// 
			// Line327
			// 
			this.Line327.Height = 0F;
			this.Line327.Left = 0.7525F;
			this.Line327.LineWeight = 1F;
			this.Line327.Name = "Line327";
			this.Line327.Top = 4.147001F;
			this.Line327.Width = 3.7505F;
			this.Line327.X1 = 0.7525F;
			this.Line327.X2 = 4.503F;
			this.Line327.Y1 = 4.147001F;
			this.Line327.Y2 = 4.147001F;
			// 
			// PaymntTotal1Amt1
			// 
			this.PaymntTotal1Amt1.Height = 0.143F;
			this.PaymntTotal1Amt1.Left = 0.7525F;
			this.PaymntTotal1Amt1.Name = "PaymntTotal1Amt1";
			this.PaymntTotal1Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt1.Top = 4.004F;
			this.PaymntTotal1Amt1.Width = 0.625F;
			// 
			// DedTotal1Amt1
			// 
			this.DedTotal1Amt1.Height = 0.143F;
			this.DedTotal1Amt1.Left = 0.7525F;
			this.DedTotal1Amt1.Name = "DedTotal1Amt1";
			this.DedTotal1Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt1.Top = 4.147001F;
			this.DedTotal1Amt1.Width = 0.625F;
			// 
			// PaymntTotal1Amt2
			// 
			this.PaymntTotal1Amt2.Height = 0.143F;
			this.PaymntTotal1Amt2.Left = 1.3775F;
			this.PaymntTotal1Amt2.Name = "PaymntTotal1Amt2";
			this.PaymntTotal1Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt2.Top = 4.004F;
			this.PaymntTotal1Amt2.Width = 0.625F;
			// 
			// DedTotal1Amt2
			// 
			this.DedTotal1Amt2.Height = 0.143F;
			this.DedTotal1Amt2.Left = 1.3775F;
			this.DedTotal1Amt2.Name = "DedTotal1Amt2";
			this.DedTotal1Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt2.Top = 4.147001F;
			this.DedTotal1Amt2.Width = 0.625F;
			// 
			// PaymntTotal1Amt3
			// 
			this.PaymntTotal1Amt3.Height = 0.143F;
			this.PaymntTotal1Amt3.Left = 2.0025F;
			this.PaymntTotal1Amt3.Name = "PaymntTotal1Amt3";
			this.PaymntTotal1Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt3.Top = 4.004F;
			this.PaymntTotal1Amt3.Width = 0.625F;
			// 
			// DedTotal1Amt3
			// 
			this.DedTotal1Amt3.Height = 0.143F;
			this.DedTotal1Amt3.Left = 2.0025F;
			this.DedTotal1Amt3.Name = "DedTotal1Amt3";
			this.DedTotal1Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt3.Top = 4.147001F;
			this.DedTotal1Amt3.Width = 0.625F;
			// 
			// PaymntTotal1Amt4
			// 
			this.PaymntTotal1Amt4.Height = 0.143F;
			this.PaymntTotal1Amt4.Left = 2.6275F;
			this.PaymntTotal1Amt4.Name = "PaymntTotal1Amt4";
			this.PaymntTotal1Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt4.Top = 4.004F;
			this.PaymntTotal1Amt4.Width = 0.625F;
			// 
			// DedTotal1Amt4
			// 
			this.DedTotal1Amt4.Height = 0.143F;
			this.DedTotal1Amt4.Left = 2.6275F;
			this.DedTotal1Amt4.Name = "DedTotal1Amt4";
			this.DedTotal1Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt4.Top = 4.147001F;
			this.DedTotal1Amt4.Width = 0.625F;
			// 
			// PaymntTotal1Amt5
			// 
			this.PaymntTotal1Amt5.Height = 0.143F;
			this.PaymntTotal1Amt5.Left = 3.2525F;
			this.PaymntTotal1Amt5.Name = "PaymntTotal1Amt5";
			this.PaymntTotal1Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt5.Top = 4.004F;
			this.PaymntTotal1Amt5.Width = 0.625F;
			// 
			// DedTotal1Amt5
			// 
			this.DedTotal1Amt5.Height = 0.143F;
			this.DedTotal1Amt5.Left = 3.2525F;
			this.DedTotal1Amt5.Name = "DedTotal1Amt5";
			this.DedTotal1Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt5.Top = 4.147001F;
			this.DedTotal1Amt5.Width = 0.625F;
			// 
			// PaymntTotal1Amt6
			// 
			this.PaymntTotal1Amt6.Height = 0.143F;
			this.PaymntTotal1Amt6.Left = 3.8775F;
			this.PaymntTotal1Amt6.Name = "PaymntTotal1Amt6";
			this.PaymntTotal1Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal1Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal1Amt6.Top = 4.004F;
			this.PaymntTotal1Amt6.Width = 0.625F;
			// 
			// DedTotal1Amt6
			// 
			this.DedTotal1Amt6.Height = 0.143F;
			this.DedTotal1Amt6.Left = 3.8775F;
			this.DedTotal1Amt6.Name = "DedTotal1Amt6";
			this.DedTotal1Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal1Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal1Amt6.Top = 4.147001F;
			this.DedTotal1Amt6.Width = 0.625F;
			// 
			// Line328
			// 
			this.Line328.Height = 0F;
			this.Line328.Left = 0.0625F;
			this.Line328.LineWeight = 1F;
			this.Line328.Name = "Line328";
			this.Line328.Top = 4.29F;
			this.Line328.Width = 4.4405F;
			this.Line328.X1 = 0.0625F;
			this.Line328.X2 = 4.503F;
			this.Line328.Y1 = 4.29F;
			this.Line328.Y2 = 4.29F;
			// 
			// Line373
			// 
			this.Line373.Height = 0F;
			this.Line373.Left = 0.5654999F;
			this.Line373.LineWeight = 1F;
			this.Line373.Name = "Line373";
			this.Line373.Top = 4.7455F;
			this.Line373.Width = 3.9375F;
			this.Line373.X1 = 0.5654999F;
			this.Line373.X2 = 4.503F;
			this.Line373.Y1 = 4.7455F;
			this.Line373.Y2 = 4.7455F;
			// 
			// Label84
			// 
			this.Label84.Height = 0.286F;
			this.Label84.HyperLink = null;
			this.Label84.Left = 0.3125F;
			this.Label84.Name = "Label84";
			this.Label84.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label84.Text = "1";
			this.Label84.Top = 4.6025F;
			this.Label84.Width = 0.253F;
			// 
			// TextBox482
			// 
			this.TextBox482.DataField = "SLRY_PAYMNT_13MM";
			this.TextBox482.Height = 0.143F;
			this.TextBox482.Left = 0.5654999F;
			this.TextBox482.Name = "TextBox482";
			this.TextBox482.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox482.Text = "66";
			this.TextBox482.Top = 4.6025F;
			this.TextBox482.Width = 0.187F;
			// 
			// TextBox483
			// 
			this.TextBox483.DataField = "SLRY_PAYMNT_13DD";
			this.TextBox483.Height = 0.143F;
			this.TextBox483.Left = 0.5654999F;
			this.TextBox483.Name = "TextBox483";
			this.TextBox483.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox483.Text = "66";
			this.TextBox483.Top = 4.7455F;
			this.TextBox483.Width = 0.187F;
			// 
			// Paymnt13Amt1
			// 
			this.Paymnt13Amt1.DataField = "PAYMNT_13AMT1";
			this.Paymnt13Amt1.Height = 0.143F;
			this.Paymnt13Amt1.Left = 0.7525F;
			this.Paymnt13Amt1.Name = "Paymnt13Amt1";
			this.Paymnt13Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt1.Top = 4.6025F;
			this.Paymnt13Amt1.Width = 0.625F;
			// 
			// Ded13Amt1
			// 
			this.Ded13Amt1.DataField = "DED_13AMT1";
			this.Ded13Amt1.Height = 0.143F;
			this.Ded13Amt1.Left = 0.7525F;
			this.Ded13Amt1.Name = "Ded13Amt1";
			this.Ded13Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt1.Top = 4.7455F;
			this.Ded13Amt1.Width = 0.625F;
			// 
			// Paymnt13Amt2
			// 
			this.Paymnt13Amt2.DataField = "PAYMNT_13AMT2";
			this.Paymnt13Amt2.Height = 0.143F;
			this.Paymnt13Amt2.Left = 1.3775F;
			this.Paymnt13Amt2.Name = "Paymnt13Amt2";
			this.Paymnt13Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt2.Top = 4.6025F;
			this.Paymnt13Amt2.Width = 0.625F;
			// 
			// Ded13Amt2
			// 
			this.Ded13Amt2.DataField = "DED_13AMT2";
			this.Ded13Amt2.Height = 0.143F;
			this.Ded13Amt2.Left = 1.3775F;
			this.Ded13Amt2.Name = "Ded13Amt2";
			this.Ded13Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt2.Top = 4.7455F;
			this.Ded13Amt2.Width = 0.625F;
			// 
			// Paymnt13Amt3
			// 
			this.Paymnt13Amt3.DataField = "PAYMNT_13AMT3";
			this.Paymnt13Amt3.Height = 0.143F;
			this.Paymnt13Amt3.Left = 2.0025F;
			this.Paymnt13Amt3.Name = "Paymnt13Amt3";
			this.Paymnt13Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt3.Top = 4.6025F;
			this.Paymnt13Amt3.Width = 0.625F;
			// 
			// Ded13Amt3
			// 
			this.Ded13Amt3.DataField = "DED_13AMT3";
			this.Ded13Amt3.Height = 0.143F;
			this.Ded13Amt3.Left = 2.0025F;
			this.Ded13Amt3.Name = "Ded13Amt3";
			this.Ded13Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt3.Top = 4.7455F;
			this.Ded13Amt3.Width = 0.625F;
			// 
			// Paymnt13Amt4
			// 
			this.Paymnt13Amt4.DataField = "PAYMNT_13AMT4";
			this.Paymnt13Amt4.Height = 0.143F;
			this.Paymnt13Amt4.Left = 2.6275F;
			this.Paymnt13Amt4.Name = "Paymnt13Amt4";
			this.Paymnt13Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt4.Top = 4.6025F;
			this.Paymnt13Amt4.Width = 0.625F;
			// 
			// Ded13Amt4
			// 
			this.Ded13Amt4.DataField = "DED_13AMT4";
			this.Ded13Amt4.Height = 0.143F;
			this.Ded13Amt4.Left = 2.6275F;
			this.Ded13Amt4.Name = "Ded13Amt4";
			this.Ded13Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt4.Top = 4.7455F;
			this.Ded13Amt4.Width = 0.625F;
			// 
			// Paymnt13Amt5
			// 
			this.Paymnt13Amt5.DataField = "PAYMNT_13AMT5";
			this.Paymnt13Amt5.Height = 0.143F;
			this.Paymnt13Amt5.Left = 3.2525F;
			this.Paymnt13Amt5.Name = "Paymnt13Amt5";
			this.Paymnt13Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt5.Top = 4.6025F;
			this.Paymnt13Amt5.Width = 0.625F;
			// 
			// Ded13Amt5
			// 
			this.Ded13Amt5.DataField = "DED_13AMT5";
			this.Ded13Amt5.Height = 0.143F;
			this.Ded13Amt5.Left = 3.2525F;
			this.Ded13Amt5.Name = "Ded13Amt5";
			this.Ded13Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt5.Top = 4.7455F;
			this.Ded13Amt5.Width = 0.625F;
			// 
			// Paymnt13Amt6
			// 
			this.Paymnt13Amt6.DataField = "PAYMNT_13AMT6";
			this.Paymnt13Amt6.Height = 0.143F;
			this.Paymnt13Amt6.Left = 3.8775F;
			this.Paymnt13Amt6.Name = "Paymnt13Amt6";
			this.Paymnt13Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt13Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt13Amt6.Top = 4.6025F;
			this.Paymnt13Amt6.Width = 0.625F;
			// 
			// Ded13Amt6
			// 
			this.Ded13Amt6.DataField = "DED_13AMT6";
			this.Ded13Amt6.Height = 0.143F;
			this.Ded13Amt6.Left = 3.8775F;
			this.Ded13Amt6.Name = "Ded13Amt6";
			this.Ded13Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded13Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded13Amt6.Top = 4.7455F;
			this.Ded13Amt6.Width = 0.625F;
			// 
			// Line374
			// 
			this.Line374.Height = 0F;
			this.Line374.Left = 0.3154999F;
			this.Line374.LineWeight = 1F;
			this.Line374.Name = "Line374";
			this.Line374.Top = 4.888499F;
			this.Line374.Width = 4.1875F;
			this.Line374.X1 = 0.3154999F;
			this.Line374.X2 = 4.503F;
			this.Line374.Y1 = 4.888499F;
			this.Line374.Y2 = 4.888499F;
			// 
			// Label85
			// 
			this.Label85.Height = 0.286F;
			this.Label85.HyperLink = null;
			this.Label85.Left = 0.3125F;
			this.Label85.Name = "Label85";
			this.Label85.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label85.Text = "2";
			this.Label85.Top = 4.888499F;
			this.Label85.Width = 0.253F;
			// 
			// TextBox508
			// 
			this.TextBox508.DataField = "SLRY_PAYMNT_14MM";
			this.TextBox508.Height = 0.143F;
			this.TextBox508.Left = 0.5654999F;
			this.TextBox508.Name = "TextBox508";
			this.TextBox508.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox508.Text = "66";
			this.TextBox508.Top = 4.888499F;
			this.TextBox508.Width = 0.187F;
			// 
			// Line375
			// 
			this.Line375.Height = 0F;
			this.Line375.Left = 0.5654999F;
			this.Line375.LineWeight = 1F;
			this.Line375.Name = "Line375";
			this.Line375.Top = 5.3175F;
			this.Line375.Width = 3.9375F;
			this.Line375.X1 = 0.5654999F;
			this.Line375.X2 = 4.503F;
			this.Line375.Y1 = 5.3175F;
			this.Line375.Y2 = 5.3175F;
			// 
			// TextBox509
			// 
			this.TextBox509.DataField = "SLRY_PAYMNT_14DD";
			this.TextBox509.Height = 0.143F;
			this.TextBox509.Left = 0.5654999F;
			this.TextBox509.Name = "TextBox509";
			this.TextBox509.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox509.Text = "66";
			this.TextBox509.Top = 5.0315F;
			this.TextBox509.Width = 0.187F;
			// 
			// Paymnt14Amt1
			// 
			this.Paymnt14Amt1.DataField = "PAYMNT_14AMT1";
			this.Paymnt14Amt1.Height = 0.143F;
			this.Paymnt14Amt1.Left = 0.7525F;
			this.Paymnt14Amt1.Name = "Paymnt14Amt1";
			this.Paymnt14Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt1.Top = 4.888499F;
			this.Paymnt14Amt1.Width = 0.625F;
			// 
			// Ded14Amt1
			// 
			this.Ded14Amt1.DataField = "DED_14AMT1";
			this.Ded14Amt1.Height = 0.143F;
			this.Ded14Amt1.Left = 0.7525F;
			this.Ded14Amt1.Name = "Ded14Amt1";
			this.Ded14Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt1.Top = 5.0315F;
			this.Ded14Amt1.Width = 0.625F;
			// 
			// Paymnt14Amt2
			// 
			this.Paymnt14Amt2.DataField = "PAYMNT_14AMT2";
			this.Paymnt14Amt2.Height = 0.143F;
			this.Paymnt14Amt2.Left = 1.3775F;
			this.Paymnt14Amt2.Name = "Paymnt14Amt2";
			this.Paymnt14Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt2.Top = 4.888499F;
			this.Paymnt14Amt2.Width = 0.625F;
			// 
			// Ded14Amt2
			// 
			this.Ded14Amt2.DataField = "DED_14AMT2";
			this.Ded14Amt2.Height = 0.143F;
			this.Ded14Amt2.Left = 1.3775F;
			this.Ded14Amt2.Name = "Ded14Amt2";
			this.Ded14Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt2.Top = 5.0315F;
			this.Ded14Amt2.Width = 0.625F;
			// 
			// Paymnt14Amt3
			// 
			this.Paymnt14Amt3.DataField = "PAYMNT_14AMT3";
			this.Paymnt14Amt3.Height = 0.143F;
			this.Paymnt14Amt3.Left = 2.0025F;
			this.Paymnt14Amt3.Name = "Paymnt14Amt3";
			this.Paymnt14Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt3.Top = 4.888499F;
			this.Paymnt14Amt3.Width = 0.625F;
			// 
			// Ded14Amt3
			// 
			this.Ded14Amt3.DataField = "DED_14AMT3";
			this.Ded14Amt3.Height = 0.143F;
			this.Ded14Amt3.Left = 2.0025F;
			this.Ded14Amt3.Name = "Ded14Amt3";
			this.Ded14Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt3.Top = 5.0315F;
			this.Ded14Amt3.Width = 0.625F;
			// 
			// Paymnt14Amt4
			// 
			this.Paymnt14Amt4.DataField = "PAYMNT_14AMT4";
			this.Paymnt14Amt4.Height = 0.143F;
			this.Paymnt14Amt4.Left = 2.6275F;
			this.Paymnt14Amt4.Name = "Paymnt14Amt4";
			this.Paymnt14Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt4.Top = 4.888499F;
			this.Paymnt14Amt4.Width = 0.625F;
			// 
			// Ded14Amt4
			// 
			this.Ded14Amt4.DataField = "DED_14AMT4";
			this.Ded14Amt4.Height = 0.143F;
			this.Ded14Amt4.Left = 2.6275F;
			this.Ded14Amt4.Name = "Ded14Amt4";
			this.Ded14Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt4.Top = 5.0315F;
			this.Ded14Amt4.Width = 0.625F;
			// 
			// Paymnt14Amt5
			// 
			this.Paymnt14Amt5.DataField = "PAYMNT_14AMT5";
			this.Paymnt14Amt5.Height = 0.143F;
			this.Paymnt14Amt5.Left = 3.2525F;
			this.Paymnt14Amt5.Name = "Paymnt14Amt5";
			this.Paymnt14Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt5.Top = 4.888499F;
			this.Paymnt14Amt5.Width = 0.625F;
			// 
			// Ded14Amt5
			// 
			this.Ded14Amt5.DataField = "DED_14AMT5";
			this.Ded14Amt5.Height = 0.143F;
			this.Ded14Amt5.Left = 3.2525F;
			this.Ded14Amt5.Name = "Ded14Amt5";
			this.Ded14Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt5.Top = 5.0315F;
			this.Ded14Amt5.Width = 0.625F;
			// 
			// Paymnt14Amt6
			// 
			this.Paymnt14Amt6.DataField = "PAYMNT_14AMT6";
			this.Paymnt14Amt6.Height = 0.143F;
			this.Paymnt14Amt6.Left = 3.8775F;
			this.Paymnt14Amt6.Name = "Paymnt14Amt6";
			this.Paymnt14Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt14Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt14Amt6.Top = 4.888499F;
			this.Paymnt14Amt6.Width = 0.625F;
			// 
			// Ded14Amt6
			// 
			this.Ded14Amt6.DataField = "DED_14AMT6";
			this.Ded14Amt6.Height = 0.143F;
			this.Ded14Amt6.Left = 3.8775F;
			this.Ded14Amt6.Name = "Ded14Amt6";
			this.Ded14Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded14Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded14Amt6.Top = 5.0315F;
			this.Ded14Amt6.Width = 0.625F;
			// 
			// Line376
			// 
			this.Line376.Height = 0F;
			this.Line376.Left = 0.3154999F;
			this.Line376.LineWeight = 1F;
			this.Line376.Name = "Line376";
			this.Line376.Top = 5.1745F;
			this.Line376.Width = 4.1875F;
			this.Line376.X1 = 0.3154999F;
			this.Line376.X2 = 4.503F;
			this.Line376.Y1 = 5.1745F;
			this.Line376.Y2 = 5.1745F;
			// 
			// Line377
			// 
			this.Line377.Height = 0F;
			this.Line377.Left = 0.5654999F;
			this.Line377.LineWeight = 1F;
			this.Line377.Name = "Line377";
			this.Line377.Top = 5.6035F;
			this.Line377.Width = 3.9375F;
			this.Line377.X1 = 0.5654999F;
			this.Line377.X2 = 4.503F;
			this.Line377.Y1 = 5.6035F;
			this.Line377.Y2 = 5.6035F;
			// 
			// Label86
			// 
			this.Label86.Height = 0.286F;
			this.Label86.HyperLink = null;
			this.Label86.Left = 0.3125F;
			this.Label86.Name = "Label86";
			this.Label86.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label86.Text = "3";
			this.Label86.Top = 5.1745F;
			this.Label86.Width = 0.253F;
			// 
			// TextBox534
			// 
			this.TextBox534.DataField = "SLRY_PAYMNT_15MM";
			this.TextBox534.Height = 0.143F;
			this.TextBox534.Left = 0.5654999F;
			this.TextBox534.Name = "TextBox534";
			this.TextBox534.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox534.Text = "66";
			this.TextBox534.Top = 5.1745F;
			this.TextBox534.Width = 0.187F;
			// 
			// TextBox535
			// 
			this.TextBox535.DataField = "SLRY_PAYMNT_15DD";
			this.TextBox535.Height = 0.143F;
			this.TextBox535.Left = 0.5654999F;
			this.TextBox535.Name = "TextBox535";
			this.TextBox535.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox535.Text = "66";
			this.TextBox535.Top = 5.3175F;
			this.TextBox535.Width = 0.187F;
			// 
			// Paymnt15Amt1
			// 
			this.Paymnt15Amt1.DataField = "PAYMNT_15AMT1";
			this.Paymnt15Amt1.Height = 0.143F;
			this.Paymnt15Amt1.Left = 0.7525F;
			this.Paymnt15Amt1.Name = "Paymnt15Amt1";
			this.Paymnt15Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt1.Top = 5.1745F;
			this.Paymnt15Amt1.Width = 0.625F;
			// 
			// Ded15Amt1
			// 
			this.Ded15Amt1.DataField = "DED_15AMT1";
			this.Ded15Amt1.Height = 0.143F;
			this.Ded15Amt1.Left = 0.7525F;
			this.Ded15Amt1.Name = "Ded15Amt1";
			this.Ded15Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt1.Top = 5.3175F;
			this.Ded15Amt1.Width = 0.625F;
			// 
			// Paymnt15Amt2
			// 
			this.Paymnt15Amt2.DataField = "PAYMNT_15AMT2";
			this.Paymnt15Amt2.Height = 0.143F;
			this.Paymnt15Amt2.Left = 1.3775F;
			this.Paymnt15Amt2.Name = "Paymnt15Amt2";
			this.Paymnt15Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt2.Top = 5.1745F;
			this.Paymnt15Amt2.Width = 0.625F;
			// 
			// Ded15Amt2
			// 
			this.Ded15Amt2.DataField = "DED_15AMT2";
			this.Ded15Amt2.Height = 0.143F;
			this.Ded15Amt2.Left = 1.3775F;
			this.Ded15Amt2.Name = "Ded15Amt2";
			this.Ded15Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt2.Top = 5.3175F;
			this.Ded15Amt2.Width = 0.625F;
			// 
			// Paymnt15Amt3
			// 
			this.Paymnt15Amt3.DataField = "PAYMNT_15AMT3";
			this.Paymnt15Amt3.Height = 0.143F;
			this.Paymnt15Amt3.Left = 2.0025F;
			this.Paymnt15Amt3.Name = "Paymnt15Amt3";
			this.Paymnt15Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt3.Top = 5.1745F;
			this.Paymnt15Amt3.Width = 0.625F;
			// 
			// Ded15Amt3
			// 
			this.Ded15Amt3.DataField = "DED_15AMT3";
			this.Ded15Amt3.Height = 0.143F;
			this.Ded15Amt3.Left = 2.0025F;
			this.Ded15Amt3.Name = "Ded15Amt3";
			this.Ded15Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt3.Top = 5.3175F;
			this.Ded15Amt3.Width = 0.625F;
			// 
			// Paymnt15Amt4
			// 
			this.Paymnt15Amt4.DataField = "PAYMNT_15AMT4";
			this.Paymnt15Amt4.Height = 0.143F;
			this.Paymnt15Amt4.Left = 2.6275F;
			this.Paymnt15Amt4.Name = "Paymnt15Amt4";
			this.Paymnt15Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt4.Top = 5.1745F;
			this.Paymnt15Amt4.Width = 0.625F;
			// 
			// Ded15Amt4
			// 
			this.Ded15Amt4.DataField = "DED_15AMT4";
			this.Ded15Amt4.Height = 0.143F;
			this.Ded15Amt4.Left = 2.6275F;
			this.Ded15Amt4.Name = "Ded15Amt4";
			this.Ded15Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt4.Top = 5.3175F;
			this.Ded15Amt4.Width = 0.625F;
			// 
			// Paymnt15Amt5
			// 
			this.Paymnt15Amt5.DataField = "PAYMNT_15AMT5";
			this.Paymnt15Amt5.Height = 0.143F;
			this.Paymnt15Amt5.Left = 3.2525F;
			this.Paymnt15Amt5.Name = "Paymnt15Amt5";
			this.Paymnt15Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt5.Top = 5.1745F;
			this.Paymnt15Amt5.Width = 0.625F;
			// 
			// Ded15Amt5
			// 
			this.Ded15Amt5.DataField = "DED_15AMT5";
			this.Ded15Amt5.Height = 0.143F;
			this.Ded15Amt5.Left = 3.2525F;
			this.Ded15Amt5.Name = "Ded15Amt5";
			this.Ded15Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt5.Top = 5.3175F;
			this.Ded15Amt5.Width = 0.625F;
			// 
			// Paymnt15Amt6
			// 
			this.Paymnt15Amt6.DataField = "PAYMNT_15AMT6";
			this.Paymnt15Amt6.Height = 0.143F;
			this.Paymnt15Amt6.Left = 3.8775F;
			this.Paymnt15Amt6.Name = "Paymnt15Amt6";
			this.Paymnt15Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt15Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt15Amt6.Top = 5.1745F;
			this.Paymnt15Amt6.Width = 0.625F;
			// 
			// Ded15Amt6
			// 
			this.Ded15Amt6.DataField = "DED_15AMT6";
			this.Ded15Amt6.Height = 0.143F;
			this.Ded15Amt6.Left = 3.8775F;
			this.Ded15Amt6.Name = "Ded15Amt6";
			this.Ded15Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded15Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded15Amt6.Top = 5.3125F;
			this.Ded15Amt6.Width = 0.625F;
			// 
			// Line378
			// 
			this.Line378.Height = 0F;
			this.Line378.Left = 0.3154999F;
			this.Line378.LineWeight = 1F;
			this.Line378.Name = "Line378";
			this.Line378.Top = 5.4605F;
			this.Line378.Width = 4.1875F;
			this.Line378.X1 = 0.3154999F;
			this.Line378.X2 = 4.503F;
			this.Line378.Y1 = 5.4605F;
			this.Line378.Y2 = 5.4605F;
			// 
			// Label87
			// 
			this.Label87.Height = 0.286F;
			this.Label87.HyperLink = null;
			this.Label87.Left = 0.3125F;
			this.Label87.Name = "Label87";
			this.Label87.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label87.Text = "4";
			this.Label87.Top = 5.4605F;
			this.Label87.Width = 0.253F;
			// 
			// TextBox560
			// 
			this.TextBox560.DataField = "SLRY_PAYMNT_16MM";
			this.TextBox560.Height = 0.143F;
			this.TextBox560.Left = 0.5654999F;
			this.TextBox560.Name = "TextBox560";
			this.TextBox560.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox560.Text = "66";
			this.TextBox560.Top = 5.4605F;
			this.TextBox560.Width = 0.187F;
			// 
			// TextBox561
			// 
			this.TextBox561.DataField = "SLRY_PAYMNT_16DD";
			this.TextBox561.Height = 0.143F;
			this.TextBox561.Left = 0.5654999F;
			this.TextBox561.Name = "TextBox561";
			this.TextBox561.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox561.Text = "66";
			this.TextBox561.Top = 5.6035F;
			this.TextBox561.Width = 0.187F;
			// 
			// Paymnt16Amt1
			// 
			this.Paymnt16Amt1.DataField = "PAYMNT_16AMT1";
			this.Paymnt16Amt1.Height = 0.143F;
			this.Paymnt16Amt1.Left = 0.7525F;
			this.Paymnt16Amt1.Name = "Paymnt16Amt1";
			this.Paymnt16Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt1.Top = 5.4605F;
			this.Paymnt16Amt1.Width = 0.625F;
			// 
			// Ded16Amt1
			// 
			this.Ded16Amt1.DataField = "DED_16AMT1";
			this.Ded16Amt1.Height = 0.143F;
			this.Ded16Amt1.Left = 0.7525F;
			this.Ded16Amt1.Name = "Ded16Amt1";
			this.Ded16Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt1.Top = 5.6035F;
			this.Ded16Amt1.Width = 0.625F;
			// 
			// Paymnt16Amt2
			// 
			this.Paymnt16Amt2.DataField = "PAYMNT_16AMT2";
			this.Paymnt16Amt2.Height = 0.143F;
			this.Paymnt16Amt2.Left = 1.3775F;
			this.Paymnt16Amt2.Name = "Paymnt16Amt2";
			this.Paymnt16Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt2.Top = 5.4605F;
			this.Paymnt16Amt2.Width = 0.625F;
			// 
			// Ded16Amt2
			// 
			this.Ded16Amt2.DataField = "DED_16AMT2";
			this.Ded16Amt2.Height = 0.143F;
			this.Ded16Amt2.Left = 1.3775F;
			this.Ded16Amt2.Name = "Ded16Amt2";
			this.Ded16Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt2.Top = 5.6035F;
			this.Ded16Amt2.Width = 0.625F;
			// 
			// Paymnt16Amt3
			// 
			this.Paymnt16Amt3.DataField = "PAYMNT_16AMT3";
			this.Paymnt16Amt3.Height = 0.143F;
			this.Paymnt16Amt3.Left = 2.0025F;
			this.Paymnt16Amt3.Name = "Paymnt16Amt3";
			this.Paymnt16Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt3.Top = 5.4605F;
			this.Paymnt16Amt3.Width = 0.625F;
			// 
			// Ded16Amt3
			// 
			this.Ded16Amt3.DataField = "DED_16AMT3";
			this.Ded16Amt3.Height = 0.143F;
			this.Ded16Amt3.Left = 2.0025F;
			this.Ded16Amt3.Name = "Ded16Amt3";
			this.Ded16Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt3.Top = 5.6035F;
			this.Ded16Amt3.Width = 0.625F;
			// 
			// Paymnt16Amt4
			// 
			this.Paymnt16Amt4.DataField = "PAYMNT_16AMT4";
			this.Paymnt16Amt4.Height = 0.143F;
			this.Paymnt16Amt4.Left = 2.6275F;
			this.Paymnt16Amt4.Name = "Paymnt16Amt4";
			this.Paymnt16Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt4.Top = 5.4605F;
			this.Paymnt16Amt4.Width = 0.625F;
			// 
			// Ded16Amt4
			// 
			this.Ded16Amt4.DataField = "DED_16AMT4";
			this.Ded16Amt4.Height = 0.143F;
			this.Ded16Amt4.Left = 2.6275F;
			this.Ded16Amt4.Name = "Ded16Amt4";
			this.Ded16Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt4.Top = 5.6035F;
			this.Ded16Amt4.Width = 0.625F;
			// 
			// Paymnt16Amt5
			// 
			this.Paymnt16Amt5.DataField = "PAYMNT_16AMT5";
			this.Paymnt16Amt5.Height = 0.143F;
			this.Paymnt16Amt5.Left = 3.2525F;
			this.Paymnt16Amt5.Name = "Paymnt16Amt5";
			this.Paymnt16Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt5.Top = 5.4605F;
			this.Paymnt16Amt5.Width = 0.625F;
			// 
			// Ded16Amt5
			// 
			this.Ded16Amt5.DataField = "DED_16AMT5";
			this.Ded16Amt5.Height = 0.143F;
			this.Ded16Amt5.Left = 3.2525F;
			this.Ded16Amt5.Name = "Ded16Amt5";
			this.Ded16Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt5.Top = 5.6035F;
			this.Ded16Amt5.Width = 0.625F;
			// 
			// Paymnt16Amt6
			// 
			this.Paymnt16Amt6.DataField = "PAYMNT_16AMT6";
			this.Paymnt16Amt6.Height = 0.143F;
			this.Paymnt16Amt6.Left = 3.8775F;
			this.Paymnt16Amt6.Name = "Paymnt16Amt6";
			this.Paymnt16Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt16Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt16Amt6.Top = 5.4605F;
			this.Paymnt16Amt6.Width = 0.625F;
			// 
			// Ded16Amt6
			// 
			this.Ded16Amt6.DataField = "DED_16AMT6";
			this.Ded16Amt6.Height = 0.143F;
			this.Ded16Amt6.Left = 3.8775F;
			this.Ded16Amt6.Name = "Ded16Amt6";
			this.Ded16Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded16Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded16Amt6.Top = 5.6035F;
			this.Ded16Amt6.Width = 0.625F;
			// 
			// Line380
			// 
			this.Line380.Height = 0F;
			this.Line380.Left = 0.3154999F;
			this.Line380.LineWeight = 1F;
			this.Line380.Name = "Line380";
			this.Line380.Top = 5.7465F;
			this.Line380.Width = 4.1875F;
			this.Line380.X1 = 0.3154999F;
			this.Line380.X2 = 4.503F;
			this.Line380.Y1 = 5.7465F;
			this.Line380.Y2 = 5.7465F;
			// 
			// Label88
			// 
			this.Label88.Height = 0.286F;
			this.Label88.HyperLink = null;
			this.Label88.Left = 0.3125F;
			this.Label88.Name = "Label88";
			this.Label88.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label88.Text = "合計";
			this.Label88.Top = 5.7465F;
			this.Label88.Width = 0.44F;
			// 
			// Line381
			// 
			this.Line381.Height = 0F;
			this.Line381.Left = 0.7525F;
			this.Line381.LineWeight = 1F;
			this.Line381.Name = "Line381";
			this.Line381.Top = 5.8895F;
			this.Line381.Width = 3.7505F;
			this.Line381.X1 = 0.7525F;
			this.Line381.X2 = 4.503F;
			this.Line381.Y1 = 5.8895F;
			this.Line381.Y2 = 5.8895F;
			// 
			// PaymntTotal2Amt1
			// 
			this.PaymntTotal2Amt1.Height = 0.143F;
			this.PaymntTotal2Amt1.Left = 0.7525F;
			this.PaymntTotal2Amt1.Name = "PaymntTotal2Amt1";
			this.PaymntTotal2Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt1.Top = 5.7465F;
			this.PaymntTotal2Amt1.Width = 0.625F;
			// 
			// DedTotal2Amt1
			// 
			this.DedTotal2Amt1.Height = 0.143F;
			this.DedTotal2Amt1.Left = 0.7525F;
			this.DedTotal2Amt1.Name = "DedTotal2Amt1";
			this.DedTotal2Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt1.Top = 5.8895F;
			this.DedTotal2Amt1.Width = 0.625F;
			// 
			// PaymntTotal2Amt2
			// 
			this.PaymntTotal2Amt2.Height = 0.143F;
			this.PaymntTotal2Amt2.Left = 1.3775F;
			this.PaymntTotal2Amt2.Name = "PaymntTotal2Amt2";
			this.PaymntTotal2Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt2.Top = 5.7465F;
			this.PaymntTotal2Amt2.Width = 0.625F;
			// 
			// DedTotal2Amt2
			// 
			this.DedTotal2Amt2.Height = 0.143F;
			this.DedTotal2Amt2.Left = 1.3775F;
			this.DedTotal2Amt2.Name = "DedTotal2Amt2";
			this.DedTotal2Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt2.Top = 5.8895F;
			this.DedTotal2Amt2.Width = 0.625F;
			// 
			// PaymntTotal2Amt3
			// 
			this.PaymntTotal2Amt3.Height = 0.143F;
			this.PaymntTotal2Amt3.Left = 2.0025F;
			this.PaymntTotal2Amt3.Name = "PaymntTotal2Amt3";
			this.PaymntTotal2Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt3.Top = 5.7465F;
			this.PaymntTotal2Amt3.Width = 0.625F;
			// 
			// DedTotal2Amt3
			// 
			this.DedTotal2Amt3.Height = 0.143F;
			this.DedTotal2Amt3.Left = 2.0025F;
			this.DedTotal2Amt3.Name = "DedTotal2Amt3";
			this.DedTotal2Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt3.Top = 5.8895F;
			this.DedTotal2Amt3.Width = 0.625F;
			// 
			// PaymntTotal2Amt4
			// 
			this.PaymntTotal2Amt4.Height = 0.143F;
			this.PaymntTotal2Amt4.Left = 2.6275F;
			this.PaymntTotal2Amt4.Name = "PaymntTotal2Amt4";
			this.PaymntTotal2Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt4.Top = 5.7465F;
			this.PaymntTotal2Amt4.Width = 0.625F;
			// 
			// DedTotal2Amt4
			// 
			this.DedTotal2Amt4.Height = 0.143F;
			this.DedTotal2Amt4.Left = 2.6275F;
			this.DedTotal2Amt4.Name = "DedTotal2Amt4";
			this.DedTotal2Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt4.Top = 5.8895F;
			this.DedTotal2Amt4.Width = 0.625F;
			// 
			// PaymntTotal2Amt5
			// 
			this.PaymntTotal2Amt5.Height = 0.143F;
			this.PaymntTotal2Amt5.Left = 3.2525F;
			this.PaymntTotal2Amt5.Name = "PaymntTotal2Amt5";
			this.PaymntTotal2Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt5.Top = 5.7465F;
			this.PaymntTotal2Amt5.Width = 0.625F;
			// 
			// DedTotal2Amt5
			// 
			this.DedTotal2Amt5.Height = 0.143F;
			this.DedTotal2Amt5.Left = 3.2525F;
			this.DedTotal2Amt5.Name = "DedTotal2Amt5";
			this.DedTotal2Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal2Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt5.Top = 5.8895F;
			this.DedTotal2Amt5.Width = 0.625F;
			// 
			// PaymntTotal2Amt6
			// 
			this.PaymntTotal2Amt6.Height = 0.143F;
			this.PaymntTotal2Amt6.Left = 3.8775F;
			this.PaymntTotal2Amt6.Name = "PaymntTotal2Amt6";
			this.PaymntTotal2Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal2Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal2Amt6.Top = 5.7465F;
			this.PaymntTotal2Amt6.Width = 0.625F;
			// 
			// DedTotal2Amt6
			// 
			this.DedTotal2Amt6.Height = 0.143F;
			this.DedTotal2Amt6.Left = 3.8775F;
			this.DedTotal2Amt6.Name = "DedTotal2Amt6";
			this.DedTotal2Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DedTotal2Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal2Amt6.Top = 5.8895F;
			this.DedTotal2Amt6.Width = 0.625F;
			// 
			// Line382
			// 
			this.Line382.Height = 0F;
			this.Line382.Left = 0.0625F;
			this.Line382.LineWeight = 1F;
			this.Line382.Name = "Line382";
			this.Line382.Top = 6.0325F;
			this.Line382.Width = 4.4405F;
			this.Line382.X1 = 0.0625F;
			this.Line382.X2 = 4.503F;
			this.Line382.Y1 = 6.0325F;
			this.Line382.Y2 = 6.0325F;
			// 
			// Label89
			// 
			this.Label89.Height = 0.286F;
			this.Label89.HyperLink = null;
			this.Label89.Left = 0.0625F;
			this.Label89.Name = "Label89";
			this.Label89.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label89.Text = "前職等修正分";
			this.Label89.Top = 6.0325F;
			this.Label89.Width = 0.691F;
			// 
			// Line383
			// 
			this.Line383.Height = 0F;
			this.Line383.Left = 0.7525F;
			this.Line383.LineWeight = 1F;
			this.Line383.Name = "Line383";
			this.Line383.Top = 6.1755F;
			this.Line383.Width = 3.7505F;
			this.Line383.X1 = 0.7525F;
			this.Line383.X2 = 4.503F;
			this.Line383.Y1 = 6.1755F;
			this.Line383.Y2 = 6.1755F;
			// 
			// Ded17Amt1
			// 
			this.Ded17Amt1.DataField = "DED_17AMT1";
			this.Ded17Amt1.Height = 0.143F;
			this.Ded17Amt1.Left = 0.7525F;
			this.Ded17Amt1.Name = "Ded17Amt1";
			this.Ded17Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt1.Top = 6.1755F;
			this.Ded17Amt1.Width = 0.625F;
			// 
			// Paymnt17Amt1
			// 
			this.Paymnt17Amt1.DataField = "PAYMNT_17AMT1";
			this.Paymnt17Amt1.Height = 0.143F;
			this.Paymnt17Amt1.Left = 0.7525F;
			this.Paymnt17Amt1.Name = "Paymnt17Amt1";
			this.Paymnt17Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt1.Top = 6.0325F;
			this.Paymnt17Amt1.Width = 0.625F;
			// 
			// Paymnt17Amt2
			// 
			this.Paymnt17Amt2.DataField = "PAYMNT_17AMT2";
			this.Paymnt17Amt2.Height = 0.143F;
			this.Paymnt17Amt2.Left = 1.3775F;
			this.Paymnt17Amt2.Name = "Paymnt17Amt2";
			this.Paymnt17Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt2.Top = 6.0325F;
			this.Paymnt17Amt2.Width = 0.625F;
			// 
			// Ded17Amt2
			// 
			this.Ded17Amt2.DataField = "DED_17AMT2";
			this.Ded17Amt2.Height = 0.143F;
			this.Ded17Amt2.Left = 1.3775F;
			this.Ded17Amt2.Name = "Ded17Amt2";
			this.Ded17Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt2.Top = 6.1755F;
			this.Ded17Amt2.Width = 0.625F;
			// 
			// Paymnt17Amt3
			// 
			this.Paymnt17Amt3.DataField = "PAYMNT_17AMT3";
			this.Paymnt17Amt3.Height = 0.143F;
			this.Paymnt17Amt3.Left = 2.0025F;
			this.Paymnt17Amt3.Name = "Paymnt17Amt3";
			this.Paymnt17Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt3.Top = 6.0325F;
			this.Paymnt17Amt3.Width = 0.625F;
			// 
			// Ded17Amt3
			// 
			this.Ded17Amt3.DataField = "DED_17AMT3";
			this.Ded17Amt3.Height = 0.143F;
			this.Ded17Amt3.Left = 2.0025F;
			this.Ded17Amt3.Name = "Ded17Amt3";
			this.Ded17Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt3.Top = 6.1755F;
			this.Ded17Amt3.Width = 0.625F;
			// 
			// Paymnt17Amt4
			// 
			this.Paymnt17Amt4.DataField = "PAYMNT_17AMT4";
			this.Paymnt17Amt4.Height = 0.143F;
			this.Paymnt17Amt4.Left = 2.6275F;
			this.Paymnt17Amt4.Name = "Paymnt17Amt4";
			this.Paymnt17Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt4.Top = 6.0325F;
			this.Paymnt17Amt4.Width = 0.625F;
			// 
			// Ded17Amt4
			// 
			this.Ded17Amt4.DataField = "DED_17AMT4";
			this.Ded17Amt4.Height = 0.143F;
			this.Ded17Amt4.Left = 2.6275F;
			this.Ded17Amt4.Name = "Ded17Amt4";
			this.Ded17Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt4.Top = 6.1755F;
			this.Ded17Amt4.Width = 0.625F;
			// 
			// Paymnt17Amt5
			// 
			this.Paymnt17Amt5.DataField = "PAYMNT_17AMT5";
			this.Paymnt17Amt5.Height = 0.143F;
			this.Paymnt17Amt5.Left = 3.2525F;
			this.Paymnt17Amt5.Name = "Paymnt17Amt5";
			this.Paymnt17Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt5.Top = 6.0325F;
			this.Paymnt17Amt5.Width = 0.625F;
			// 
			// Ded17Amt5
			// 
			this.Ded17Amt5.DataField = "DED_17AMT5";
			this.Ded17Amt5.Height = 0.143F;
			this.Ded17Amt5.Left = 3.2525F;
			this.Ded17Amt5.Name = "Ded17Amt5";
			this.Ded17Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt5.Top = 6.1755F;
			this.Ded17Amt5.Width = 0.625F;
			// 
			// Paymnt17Amt6
			// 
			this.Paymnt17Amt6.DataField = "PAYMNT_17AMT6";
			this.Paymnt17Amt6.Height = 0.143F;
			this.Paymnt17Amt6.Left = 3.8775F;
			this.Paymnt17Amt6.Name = "Paymnt17Amt6";
			this.Paymnt17Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt17Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt17Amt6.Top = 6.0325F;
			this.Paymnt17Amt6.Width = 0.625F;
			// 
			// Ded17Amt6
			// 
			this.Ded17Amt6.DataField = "DED_17AMT6";
			this.Ded17Amt6.Height = 0.143F;
			this.Ded17Amt6.Left = 3.8775F;
			this.Ded17Amt6.Name = "Ded17Amt6";
			this.Ded17Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded17Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded17Amt6.Top = 6.1755F;
			this.Ded17Amt6.Width = 0.625F;
			// 
			// Line384
			// 
			this.Line384.Height = 0F;
			this.Line384.Left = 0.0625F;
			this.Line384.LineWeight = 1F;
			this.Line384.Name = "Line384";
			this.Line384.Top = 6.3185F;
			this.Line384.Width = 4.4405F;
			this.Line384.X1 = 0.0625F;
			this.Line384.X2 = 4.503F;
			this.Line384.Y1 = 6.3185F;
			this.Line384.Y2 = 6.3185F;
			// 
			// Line385
			// 
			this.Line385.Height = 0F;
			this.Line385.Left = 0.7525F;
			this.Line385.LineWeight = 1F;
			this.Line385.Name = "Line385";
			this.Line385.Top = 6.4615F;
			this.Line385.Width = 3.7505F;
			this.Line385.X1 = 0.7525F;
			this.Line385.X2 = 4.503F;
			this.Line385.Y1 = 6.4615F;
			this.Line385.Y2 = 6.4615F;
			// 
			// Label90
			// 
			this.Label90.Height = 0.286F;
			this.Label90.HyperLink = null;
			this.Label90.Left = 0.0625F;
			this.Label90.Name = "Label90";
			this.Label90.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label90.Text = "総合計";
			this.Label90.Top = 6.3185F;
			this.Label90.Width = 0.691F;
			// 
			// DedTotal3Amt1
			// 
			this.DedTotal3Amt1.Height = 0.143F;
			this.DedTotal3Amt1.Left = 0.7525F;
			this.DedTotal3Amt1.Name = "DedTotal3Amt1";
			this.DedTotal3Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt1.Top = 6.4615F;
			this.DedTotal3Amt1.Width = 0.625F;
			// 
			// PaymntTotal3Amt1
			// 
			this.PaymntTotal3Amt1.Height = 0.143F;
			this.PaymntTotal3Amt1.Left = 0.7525F;
			this.PaymntTotal3Amt1.Name = "PaymntTotal3Amt1";
			this.PaymntTotal3Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt1.Top = 6.3185F;
			this.PaymntTotal3Amt1.Width = 0.625F;
			// 
			// PaymntTotal3Amt2
			// 
			this.PaymntTotal3Amt2.Height = 0.143F;
			this.PaymntTotal3Amt2.Left = 1.3775F;
			this.PaymntTotal3Amt2.Name = "PaymntTotal3Amt2";
			this.PaymntTotal3Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt2.Top = 6.3185F;
			this.PaymntTotal3Amt2.Width = 0.625F;
			// 
			// DedTotal3Amt2
			// 
			this.DedTotal3Amt2.Height = 0.143F;
			this.DedTotal3Amt2.Left = 1.3775F;
			this.DedTotal3Amt2.Name = "DedTotal3Amt2";
			this.DedTotal3Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt2.Top = 6.4615F;
			this.DedTotal3Amt2.Width = 0.625F;
			// 
			// PaymntTotal3Amt3
			// 
			this.PaymntTotal3Amt3.Height = 0.143F;
			this.PaymntTotal3Amt3.Left = 2.0025F;
			this.PaymntTotal3Amt3.Name = "PaymntTotal3Amt3";
			this.PaymntTotal3Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt3.Top = 6.3185F;
			this.PaymntTotal3Amt3.Width = 0.625F;
			// 
			// DedTotal3Amt3
			// 
			this.DedTotal3Amt3.Height = 0.143F;
			this.DedTotal3Amt3.Left = 2.0025F;
			this.DedTotal3Amt3.Name = "DedTotal3Amt3";
			this.DedTotal3Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt3.Top = 6.4615F;
			this.DedTotal3Amt3.Width = 0.625F;
			// 
			// PaymntTotal3Amt4
			// 
			this.PaymntTotal3Amt4.Height = 0.143F;
			this.PaymntTotal3Amt4.Left = 2.6275F;
			this.PaymntTotal3Amt4.Name = "PaymntTotal3Amt4";
			this.PaymntTotal3Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt4.Top = 6.3185F;
			this.PaymntTotal3Amt4.Width = 0.625F;
			// 
			// DedTotal3Amt4
			// 
			this.DedTotal3Amt4.Height = 0.143F;
			this.DedTotal3Amt4.Left = 2.6275F;
			this.DedTotal3Amt4.Name = "DedTotal3Amt4";
			this.DedTotal3Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt4.Top = 6.4615F;
			this.DedTotal3Amt4.Width = 0.625F;
			// 
			// PaymntTotal3Amt5
			// 
			this.PaymntTotal3Amt5.Height = 0.143F;
			this.PaymntTotal3Amt5.Left = 3.2525F;
			this.PaymntTotal3Amt5.Name = "PaymntTotal3Amt5";
			this.PaymntTotal3Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt5.Top = 6.3185F;
			this.PaymntTotal3Amt5.Width = 0.625F;
			// 
			// DedTotal3Amt5
			// 
			this.DedTotal3Amt5.Height = 0.143F;
			this.DedTotal3Amt5.Left = 3.2525F;
			this.DedTotal3Amt5.Name = "DedTotal3Amt5";
			this.DedTotal3Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt5.Top = 6.4615F;
			this.DedTotal3Amt5.Width = 0.625F;
			// 
			// PaymntTotal3Amt6
			// 
			this.PaymntTotal3Amt6.Height = 0.143F;
			this.PaymntTotal3Amt6.Left = 3.8775F;
			this.PaymntTotal3Amt6.Name = "PaymntTotal3Amt6";
			this.PaymntTotal3Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntTotal3Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.PaymntTotal3Amt6.Top = 6.3185F;
			this.PaymntTotal3Amt6.Width = 0.625F;
			// 
			// DedTotal3Amt6
			// 
			this.DedTotal3Amt6.Height = 0.143F;
			this.DedTotal3Amt6.Left = 3.8775F;
			this.DedTotal3Amt6.Name = "DedTotal3Amt6";
			this.DedTotal3Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedTotal3Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.DedTotal3Amt6.Top = 6.4615F;
			this.DedTotal3Amt6.Width = 0.625F;
			// 
			// Line386
			// 
			this.Line386.Height = 0F;
			this.Line386.Left = 0.0625F;
			this.Line386.LineWeight = 1F;
			this.Line386.Name = "Line386";
			this.Line386.Top = 6.604499F;
			this.Line386.Width = 4.4405F;
			this.Line386.X1 = 0.0625F;
			this.Line386.X2 = 4.503F;
			this.Line386.Y1 = 6.604499F;
			this.Line386.Y2 = 6.604499F;
			// 
			// Label91
			// 
			this.Label91.Height = 0.5720001F;
			this.Label91.HyperLink = null;
			this.Label91.Left = 0.0625F;
			this.Label91.Name = "Label91";
			this.Label91.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label91.Text = "年末調整";
			this.Label91.Top = 6.604499F;
			this.Label91.Width = 0.691F;
			// 
			// Label92
			// 
			this.Label92.Height = 0.143F;
			this.Label92.HyperLink = null;
			this.Label92.Left = 0.7525F;
			this.Label92.Name = "Label92";
			this.Label92.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label92.Text = "給与手当等";
			this.Label92.Top = 6.604499F;
			this.Label92.Width = 0.625F;
			// 
			// Label93
			// 
			this.Label93.Height = 0.143F;
			this.Label93.HyperLink = null;
			this.Label93.Left = 1.3775F;
			this.Label93.Name = "Label93";
			this.Label93.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label93.Text = "賞与等";
			this.Label93.Top = 6.604499F;
			this.Label93.Width = 0.625F;
			// 
			// Label94
			// 
			this.Label94.Height = 0.143F;
			this.Label94.HyperLink = null;
			this.Label94.Left = 2.6275F;
			this.Label94.Name = "Label94";
			this.Label94.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label94.Text = "総支給額";
			this.Label94.Top = 6.604499F;
			this.Label94.Width = 0.625F;
			// 
			// Label95
			// 
			this.Label95.Height = 0.143F;
			this.Label95.HyperLink = null;
			this.Label95.Left = 2.0025F;
			this.Label95.Name = "Label95";
			this.Label95.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label95.Text = "前職修正分";
			this.Label95.Top = 6.604499F;
			this.Label95.Width = 0.625F;
			// 
			// Label96
			// 
			this.Label96.Height = 0.143F;
			this.Label96.HyperLink = null;
			this.Label96.Left = 3.2525F;
			this.Label96.Name = "Label96";
			this.Label96.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label96.Text = "所得控除後額";
			this.Label96.Top = 6.604499F;
			this.Label96.Width = 0.625F;
			// 
			// Label97
			// 
			this.Label97.Height = 0.143F;
			this.Label97.HyperLink = null;
			this.Label97.Left = 3.8775F;
			this.Label97.Name = "Label97";
			this.Label97.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label97.Text = "調整控除後額";
			this.Label97.Top = 6.604499F;
			this.Label97.Width = 0.625F;
			// 
			// Line387
			// 
			this.Line387.Height = 0F;
			this.Line387.Left = 0.7525F;
			this.Line387.LineWeight = 1F;
			this.Line387.Name = "Line387";
			this.Line387.Top = 6.7475F;
			this.Line387.Width = 3.7505F;
			this.Line387.X1 = 0.7525F;
			this.Line387.X2 = 4.503F;
			this.Line387.Y1 = 6.7475F;
			this.Line387.Y2 = 6.7475F;
			// 
			// Paymnt18Amt1
			// 
			this.Paymnt18Amt1.DataField = "PAYMNT_18AMT1";
			this.Paymnt18Amt1.Height = 0.143F;
			this.Paymnt18Amt1.Left = 0.7525F;
			this.Paymnt18Amt1.Name = "Paymnt18Amt1";
			this.Paymnt18Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt1.Top = 6.7475F;
			this.Paymnt18Amt1.Width = 0.625F;
			// 
			// Paymnt18Amt2
			// 
			this.Paymnt18Amt2.DataField = "PAYMNT_18AMT2";
			this.Paymnt18Amt2.Height = 0.143F;
			this.Paymnt18Amt2.Left = 1.3775F;
			this.Paymnt18Amt2.Name = "Paymnt18Amt2";
			this.Paymnt18Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt2.Top = 6.7475F;
			this.Paymnt18Amt2.Width = 0.625F;
			// 
			// Paymnt18Amt3
			// 
			this.Paymnt18Amt3.DataField = "PAYMNT_18AMT3";
			this.Paymnt18Amt3.Height = 0.143F;
			this.Paymnt18Amt3.Left = 2.0025F;
			this.Paymnt18Amt3.Name = "Paymnt18Amt3";
			this.Paymnt18Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt3.Top = 6.7475F;
			this.Paymnt18Amt3.Width = 0.625F;
			// 
			// Paymnt18Amt4
			// 
			this.Paymnt18Amt4.DataField = "PAYMNT_18AMT4";
			this.Paymnt18Amt4.Height = 0.143F;
			this.Paymnt18Amt4.Left = 2.6275F;
			this.Paymnt18Amt4.Name = "Paymnt18Amt4";
			this.Paymnt18Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt4.Top = 6.7475F;
			this.Paymnt18Amt4.Width = 0.625F;
			// 
			// Paymnt18Amt5
			// 
			this.Paymnt18Amt5.DataField = "PAYMNT_18AMT5";
			this.Paymnt18Amt5.Height = 0.143F;
			this.Paymnt18Amt5.Left = 3.2525F;
			this.Paymnt18Amt5.Name = "Paymnt18Amt5";
			this.Paymnt18Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt5.Top = 6.7475F;
			this.Paymnt18Amt5.Width = 0.625F;
			// 
			// Paymnt18Amt6
			// 
			this.Paymnt18Amt6.DataField = "PAYMNT_18AMT6";
			this.Paymnt18Amt6.Height = 0.143F;
			this.Paymnt18Amt6.Left = 3.8775F;
			this.Paymnt18Amt6.Name = "Paymnt18Amt6";
			this.Paymnt18Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Paymnt18Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Paymnt18Amt6.Top = 6.7475F;
			this.Paymnt18Amt6.Width = 0.625F;
			// 
			// Line388
			// 
			this.Line388.Height = 0F;
			this.Line388.Left = 0.7525F;
			this.Line388.LineWeight = 1F;
			this.Line388.Name = "Line388";
			this.Line388.Top = 6.8905F;
			this.Line388.Width = 3.7505F;
			this.Line388.X1 = 0.7525F;
			this.Line388.X2 = 4.503F;
			this.Line388.Y1 = 6.8905F;
			this.Line388.Y2 = 6.8905F;
			// 
			// Line389
			// 
			this.Line389.Height = 0F;
			this.Line389.Left = 0.7525F;
			this.Line389.LineWeight = 1F;
			this.Line389.Name = "Line389";
			this.Line389.Top = 6.8905F;
			this.Line389.Width = 3.7505F;
			this.Line389.X1 = 0.7525F;
			this.Line389.X2 = 4.503F;
			this.Line389.Y1 = 6.8905F;
			this.Line389.Y2 = 6.8905F;
			// 
			// Line390
			// 
			this.Line390.Height = 0F;
			this.Line390.Left = 0.7525F;
			this.Line390.LineWeight = 1F;
			this.Line390.Name = "Line390";
			this.Line390.Top = 7.0335F;
			this.Line390.Width = 3.7505F;
			this.Line390.X1 = 0.7525F;
			this.Line390.X2 = 4.503F;
			this.Line390.Y1 = 7.0335F;
			this.Line390.Y2 = 7.0335F;
			// 
			// Label103
			// 
			this.Label103.Height = 0.143F;
			this.Label103.HyperLink = null;
			this.Label103.Left = 0.7525F;
			this.Label103.Name = "Label103";
			this.Label103.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label103.Text = "損害保険控除";
			this.Label103.Top = 6.8905F;
			this.Label103.Width = 0.625F;
			// 
			// Label104
			// 
			this.Label104.Height = 0.143F;
			this.Label104.HyperLink = null;
			this.Label104.Left = 1.3775F;
			this.Label104.Name = "Label104";
			this.Label104.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label104.Text = "基礎控除額";
			this.Label104.Top = 6.8905F;
			this.Label104.Width = 0.625F;
			// 
			// Label105
			// 
			this.Label105.Height = 0.143F;
			this.Label105.HyperLink = null;
			this.Label105.Left = 2.6275F;
			this.Label105.Name = "Label105";
			this.Label105.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label105.Text = "扶養控除等額";
			this.Label105.Top = 6.8905F;
			this.Label105.Width = 0.625F;
			// 
			// Label106
			// 
			this.Label106.Height = 0.143F;
			this.Label106.HyperLink = null;
			this.Label106.Left = 2.0025F;
			this.Label106.Name = "Label106";
			this.Label106.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label106.Text = "配偶者特別";
			this.Label106.Top = 6.8905F;
			this.Label106.Width = 0.625F;
			// 
			// Label107
			// 
			this.Label107.Height = 0.143F;
			this.Label107.HyperLink = null;
			this.Label107.Left = 3.2525F;
			this.Label107.Name = "Label107";
			this.Label107.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label107.Text = "所得控除合計";
			this.Label107.Top = 6.8905F;
			this.Label107.Width = 0.625F;
			// 
			// Ded18Amt1
			// 
			this.Ded18Amt1.DataField = "DED_18AMT1";
			this.Ded18Amt1.Height = 0.143F;
			this.Ded18Amt1.Left = 0.7525F;
			this.Ded18Amt1.Name = "Ded18Amt1";
			this.Ded18Amt1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt1.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt1.Top = 7.0335F;
			this.Ded18Amt1.Width = 0.625F;
			// 
			// Ded18Amt2
			// 
			this.Ded18Amt2.DataField = "DED_18AMT2";
			this.Ded18Amt2.Height = 0.143F;
			this.Ded18Amt2.Left = 1.3775F;
			this.Ded18Amt2.Name = "Ded18Amt2";
			this.Ded18Amt2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt2.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt2.Top = 7.0335F;
			this.Ded18Amt2.Width = 0.625F;
			// 
			// Ded18Amt3
			// 
			this.Ded18Amt3.DataField = "DED_18AMT3";
			this.Ded18Amt3.Height = 0.143F;
			this.Ded18Amt3.Left = 2.0025F;
			this.Ded18Amt3.Name = "Ded18Amt3";
			this.Ded18Amt3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt3.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt3.Top = 7.0335F;
			this.Ded18Amt3.Width = 0.625F;
			// 
			// Ded18Amt4
			// 
			this.Ded18Amt4.DataField = "DED_18AMT4";
			this.Ded18Amt4.Height = 0.143F;
			this.Ded18Amt4.Left = 2.6275F;
			this.Ded18Amt4.Name = "Ded18Amt4";
			this.Ded18Amt4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt4.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt4.Top = 7.0335F;
			this.Ded18Amt4.Width = 0.625F;
			// 
			// Ded18Amt5
			// 
			this.Ded18Amt5.DataField = "DED_18AMT5";
			this.Ded18Amt5.Height = 0.143F;
			this.Ded18Amt5.Left = 3.2525F;
			this.Ded18Amt5.Name = "Ded18Amt5";
			this.Ded18Amt5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt5.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt5.Top = 7.0335F;
			this.Ded18Amt5.Width = 0.625F;
			// 
			// Ded18Amt6
			// 
			this.Ded18Amt6.DataField = "DED_18AMT6";
			this.Ded18Amt6.Height = 0.143F;
			this.Ded18Amt6.Left = 3.8775F;
			this.Ded18Amt6.Name = "Ded18Amt6";
			this.Ded18Amt6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Ded18Amt6.Text = "ZZ,ZZZ,ZZ6";
			this.Ded18Amt6.Top = 7.0335F;
			this.Ded18Amt6.Width = 0.625F;
			// 
			// Line391
			// 
			this.Line391.Height = 0F;
			this.Line391.Left = 0.0625F;
			this.Line391.LineWeight = 1F;
			this.Line391.Name = "Line391";
			this.Line391.Top = 7.1765F;
			this.Line391.Width = 4.4405F;
			this.Line391.X1 = 0.0625F;
			this.Line391.X2 = 4.503F;
			this.Line391.Y1 = 7.1765F;
			this.Line391.Y2 = 7.1765F;
			// 
			// Line392
			// 
			this.Line392.Height = 1.144F;
			this.Line392.Left = 0.5654999F;
			this.Line392.LineWeight = 1F;
			this.Line392.Name = "Line392";
			this.Line392.Top = 4.6025F;
			this.Line392.Width = 0F;
			this.Line392.X1 = 0.5654999F;
			this.Line392.X2 = 0.5654999F;
			this.Line392.Y1 = 4.6025F;
			this.Line392.Y2 = 5.7465F;
			// 
			// Line393
			// 
			this.Line393.Height = 0.286F;
			this.Line393.Left = 4.8755F;
			this.Line393.LineWeight = 1F;
			this.Line393.Name = "Line393";
			this.Line393.Top = 0F;
			this.Line393.Width = 0F;
			this.Line393.X1 = 4.8755F;
			this.Line393.X2 = 4.8755F;
			this.Line393.Y1 = 0F;
			this.Line393.Y2 = 0.286F;
			// 
			// Label128
			// 
			this.Label128.Height = 0.235F;
			this.Label128.HyperLink = null;
			this.Label128.Left = 0.0625F;
			this.Label128.Name = "Label128";
			this.Label128.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label128.Text = "給";
			this.Label128.Top = 1.64F;
			this.Label128.Width = 0.253F;
			// 
			// Label129
			// 
			this.Label129.Height = 0.235F;
			this.Label129.HyperLink = null;
			this.Label129.Left = 0.0625F;
			this.Label129.Name = "Label129";
			this.Label129.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label129.Text = "与";
			this.Label129.Top = 1.875F;
			this.Label129.Width = 0.253F;
			// 
			// Label130
			// 
			this.Label130.Height = 0.235F;
			this.Label130.HyperLink = null;
			this.Label130.Left = 0.0625F;
			this.Label130.Name = "Label130";
			this.Label130.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label130.Text = "・";
			this.Label130.Top = 2.11F;
			this.Label130.Width = 0.253F;
			// 
			// Label131
			// 
			this.Label131.Height = 0.235F;
			this.Label131.HyperLink = null;
			this.Label131.Left = 0.0625F;
			this.Label131.Name = "Label131";
			this.Label131.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label131.Text = "手";
			this.Label131.Top = 2.345F;
			this.Label131.Width = 0.253F;
			// 
			// Label132
			// 
			this.Label132.Height = 0.235F;
			this.Label132.HyperLink = null;
			this.Label132.Left = 0.0625F;
			this.Label132.Name = "Label132";
			this.Label132.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label132.Text = "当";
			this.Label132.Top = 2.58F;
			this.Label132.Width = 0.253F;
			// 
			// Label133
			// 
			this.Label133.Height = 0.235F;
			this.Label133.HyperLink = null;
			this.Label133.Left = 0.0625F;
			this.Label133.Name = "Label133";
			this.Label133.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label133.Text = "等";
			this.Label133.Top = 2.815F;
			this.Label133.Width = 0.253F;
			// 
			// Label134
			// 
			this.Label134.Height = 0.1999998F;
			this.Label134.HyperLink = null;
			this.Label134.Left = 0.0625F;
			this.Label134.Name = "Label134";
			this.Label134.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label134.Text = "賞";
			this.Label134.Top = 4.9875F;
			this.Label134.Width = 0.253F;
			// 
			// Label135
			// 
			this.Label135.Height = 0.1999998F;
			this.Label135.HyperLink = null;
			this.Label135.Left = 0.0625F;
			this.Label135.Name = "Label135";
			this.Label135.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label135.Text = "与";
			this.Label135.Top = 5.1875F;
			this.Label135.Width = 0.253F;
			// 
			// Label136
			// 
			this.Label136.Height = 0.1999998F;
			this.Label136.HyperLink = null;
			this.Label136.Left = 0.0625F;
			this.Label136.Name = "Label136";
			this.Label136.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label136.Text = "等";
			this.Label136.Top = 5.3875F;
			this.Label136.Width = 0.253F;
			// 
			// Line402
			// 
			this.Line402.Height = 0F;
			this.Line402.Left = 8.1255F;
			this.Line402.LineWeight = 1F;
			this.Line402.Name = "Line402";
			this.Line402.Top = 0.143F;
			this.Line402.Width = 2.753F;
			this.Line402.X1 = 8.1255F;
			this.Line402.X2 = 10.8785F;
			this.Line402.Y1 = 0.143F;
			this.Line402.Y2 = 0.143F;
			// 
			// Line403
			// 
			this.Line403.Height = 0.286F;
			this.Line403.Left = 9.503F;
			this.Line403.LineWeight = 1F;
			this.Line403.Name = "Line403";
			this.Line403.Top = 0F;
			this.Line403.Width = 0F;
			this.Line403.X1 = 9.503F;
			this.Line403.X2 = 9.503F;
			this.Line403.Y1 = 0F;
			this.Line403.Y2 = 0.286F;
			// 
			// Line404
			// 
			this.Line404.Height = 0.286F;
			this.Line404.Left = 10.003F;
			this.Line404.LineWeight = 1F;
			this.Line404.Name = "Line404";
			this.Line404.Top = 0F;
			this.Line404.Width = 0F;
			this.Line404.X1 = 10.003F;
			this.Line404.X2 = 10.003F;
			this.Line404.Y1 = 0F;
			this.Line404.Y2 = 0.286F;
			// 
			// Line405
			// 
			this.Line405.Height = 0F;
			this.Line405.Left = 0.5654999F;
			this.Line405.LineWeight = 1F;
			this.Line405.Name = "Line405";
			this.Line405.Top = 5.0315F;
			this.Line405.Width = 3.9375F;
			this.Line405.X1 = 0.5654999F;
			this.Line405.X2 = 4.503F;
			this.Line405.Y1 = 5.0315F;
			this.Line405.Y2 = 5.0315F;
			// 
			// PaymntZeroFlg1
			// 
			this.PaymntZeroFlg1.DataField = "PAYMNT_ZERO_FLG1";
			this.PaymntZeroFlg1.Height = 0.143F;
			this.PaymntZeroFlg1.Left = 0.7525F;
			this.PaymntZeroFlg1.Name = "PaymntZeroFlg1";
			this.PaymntZeroFlg1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg1.Text = null;
			this.PaymntZeroFlg1.Top = 0.5720001F;
			this.PaymntZeroFlg1.Visible = false;
			this.PaymntZeroFlg1.Width = 0.625F;
			// 
			// PaymntZeroFlg2
			// 
			this.PaymntZeroFlg2.DataField = "PAYMNT_ZERO_FLG2";
			this.PaymntZeroFlg2.Height = 0.143F;
			this.PaymntZeroFlg2.Left = 1.3775F;
			this.PaymntZeroFlg2.Name = "PaymntZeroFlg2";
			this.PaymntZeroFlg2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg2.Text = null;
			this.PaymntZeroFlg2.Top = 0.5720001F;
			this.PaymntZeroFlg2.Visible = false;
			this.PaymntZeroFlg2.Width = 0.625F;
			// 
			// PaymntZeroFlg3
			// 
			this.PaymntZeroFlg3.DataField = "PAYMNT_ZERO_FLG3";
			this.PaymntZeroFlg3.Height = 0.143F;
			this.PaymntZeroFlg3.Left = 2.0025F;
			this.PaymntZeroFlg3.Name = "PaymntZeroFlg3";
			this.PaymntZeroFlg3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg3.Text = null;
			this.PaymntZeroFlg3.Top = 0.5720001F;
			this.PaymntZeroFlg3.Visible = false;
			this.PaymntZeroFlg3.Width = 0.625F;
			// 
			// PaymntZeroFlg4
			// 
			this.PaymntZeroFlg4.DataField = "PAYMNT_ZERO_FLG4";
			this.PaymntZeroFlg4.Height = 0.143F;
			this.PaymntZeroFlg4.Left = 2.6275F;
			this.PaymntZeroFlg4.Name = "PaymntZeroFlg4";
			this.PaymntZeroFlg4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg4.Text = null;
			this.PaymntZeroFlg4.Top = 0.5720001F;
			this.PaymntZeroFlg4.Visible = false;
			this.PaymntZeroFlg4.Width = 0.625F;
			// 
			// PaymntZeroFlg5
			// 
			this.PaymntZeroFlg5.DataField = "PAYMNT_ZERO_FLG5";
			this.PaymntZeroFlg5.Height = 0.143F;
			this.PaymntZeroFlg5.Left = 3.2525F;
			this.PaymntZeroFlg5.Name = "PaymntZeroFlg5";
			this.PaymntZeroFlg5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg5.Text = null;
			this.PaymntZeroFlg5.Top = 0.5720001F;
			this.PaymntZeroFlg5.Visible = false;
			this.PaymntZeroFlg5.Width = 0.625F;
			// 
			// PaymntZeroFlg6
			// 
			this.PaymntZeroFlg6.DataField = "PAYMNT_ZERO_FLG6";
			this.PaymntZeroFlg6.Height = 0.143F;
			this.PaymntZeroFlg6.Left = 3.8775F;
			this.PaymntZeroFlg6.Name = "PaymntZeroFlg6";
			this.PaymntZeroFlg6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntZeroFlg6.Text = null;
			this.PaymntZeroFlg6.Top = 0.5720001F;
			this.PaymntZeroFlg6.Visible = false;
			this.PaymntZeroFlg6.Width = 0.625F;
			// 
			// DedZeroFlg1
			// 
			this.DedZeroFlg1.DataField = "DED_ZERO_FLG1";
			this.DedZeroFlg1.Height = 0.143F;
			this.DedZeroFlg1.Left = 0.7525F;
			this.DedZeroFlg1.Name = "DedZeroFlg1";
			this.DedZeroFlg1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg1.Text = null;
			this.DedZeroFlg1.Top = 0.715F;
			this.DedZeroFlg1.Visible = false;
			this.DedZeroFlg1.Width = 0.625F;
			// 
			// DedZeroFlg2
			// 
			this.DedZeroFlg2.DataField = "DED_ZERO_FLG2";
			this.DedZeroFlg2.Height = 0.143F;
			this.DedZeroFlg2.Left = 1.3775F;
			this.DedZeroFlg2.Name = "DedZeroFlg2";
			this.DedZeroFlg2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg2.Text = null;
			this.DedZeroFlg2.Top = 0.715F;
			this.DedZeroFlg2.Visible = false;
			this.DedZeroFlg2.Width = 0.625F;
			// 
			// DedZeroFlg3
			// 
			this.DedZeroFlg3.DataField = "DED_ZERO_FLG3";
			this.DedZeroFlg3.Height = 0.143F;
			this.DedZeroFlg3.Left = 2.0025F;
			this.DedZeroFlg3.Name = "DedZeroFlg3";
			this.DedZeroFlg3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg3.Text = null;
			this.DedZeroFlg3.Top = 0.715F;
			this.DedZeroFlg3.Visible = false;
			this.DedZeroFlg3.Width = 0.625F;
			// 
			// DedZeroFlg4
			// 
			this.DedZeroFlg4.DataField = "DED_ZERO_FLG4";
			this.DedZeroFlg4.Height = 0.143F;
			this.DedZeroFlg4.Left = 2.6275F;
			this.DedZeroFlg4.Name = "DedZeroFlg4";
			this.DedZeroFlg4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg4.Text = null;
			this.DedZeroFlg4.Top = 0.715F;
			this.DedZeroFlg4.Visible = false;
			this.DedZeroFlg4.Width = 0.625F;
			// 
			// DedZeroFlg5
			// 
			this.DedZeroFlg5.DataField = "DED_ZERO_FLG5";
			this.DedZeroFlg5.Height = 0.143F;
			this.DedZeroFlg5.Left = 3.2525F;
			this.DedZeroFlg5.Name = "DedZeroFlg5";
			this.DedZeroFlg5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg5.Text = null;
			this.DedZeroFlg5.Top = 0.715F;
			this.DedZeroFlg5.Visible = false;
			this.DedZeroFlg5.Width = 0.625F;
			// 
			// DedZeroFlg6
			// 
			this.DedZeroFlg6.DataField = "DED_ZERO_FLG6";
			this.DedZeroFlg6.Height = 0.143F;
			this.DedZeroFlg6.Left = 3.8775F;
			this.DedZeroFlg6.Name = "DedZeroFlg6";
			this.DedZeroFlg6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedZeroFlg6.Text = null;
			this.DedZeroFlg6.Top = 0.715F;
			this.DedZeroFlg6.Visible = false;
			this.DedZeroFlg6.Width = 0.625F;
			// 
			// EnterComp1
			// 
			this.EnterComp1.DataField = "ENTER_COMP_1";
			this.EnterComp1.Height = 0.143F;
			this.EnterComp1.Left = 2.44F;
			this.EnterComp1.Name = "EnterComp1";
			this.EnterComp1.OutputFormat = "yyyy/MM/dd";
			this.EnterComp1.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EnterComp1.Text = "6666/66/66";
			this.EnterComp1.Top = 0F;
			this.EnterComp1.Visible = false;
			this.EnterComp1.Width = 0.813F;
			// 
			// EnterComp2
			// 
			this.EnterComp2.DataField = "ENTER_COMP_2";
			this.EnterComp2.Height = 0.143F;
			this.EnterComp2.Left = 2.44F;
			this.EnterComp2.Name = "EnterComp2";
			this.EnterComp2.OutputFormat = "yyyy/MM/dd";
			this.EnterComp2.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 1";
			this.EnterComp2.Text = "6666/66/66";
			this.EnterComp2.Top = 0F;
			this.EnterComp2.Visible = false;
			this.EnterComp2.Width = 0.813F;
			// 
			// DedItemId1
			// 
			this.DedItemId1.DataField = "DED_ITEM_ID1";
			this.DedItemId1.Height = 0.143F;
			this.DedItemId1.Left = 0.7525F;
			this.DedItemId1.Name = "DedItemId1";
			this.DedItemId1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId1.Text = null;
			this.DedItemId1.Top = 1.001F;
			this.DedItemId1.Visible = false;
			this.DedItemId1.Width = 0.625F;
			// 
			// PaymntItemId1
			// 
			this.PaymntItemId1.DataField = "PAYMNT_ITEM_ID1";
			this.PaymntItemId1.Height = 0.143F;
			this.PaymntItemId1.Left = 0.7525F;
			this.PaymntItemId1.Name = "PaymntItemId1";
			this.PaymntItemId1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId1.Text = null;
			this.PaymntItemId1.Top = 0.858F;
			this.PaymntItemId1.Visible = false;
			this.PaymntItemId1.Width = 0.625F;
			// 
			// DedItemId2
			// 
			this.DedItemId2.DataField = "DED_ITEM_ID2";
			this.DedItemId2.Height = 0.143F;
			this.DedItemId2.Left = 1.3775F;
			this.DedItemId2.Name = "DedItemId2";
			this.DedItemId2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId2.Text = null;
			this.DedItemId2.Top = 1.001F;
			this.DedItemId2.Visible = false;
			this.DedItemId2.Width = 0.625F;
			// 
			// PaymntItemId2
			// 
			this.PaymntItemId2.DataField = "PAYMNT_ITEM_ID2";
			this.PaymntItemId2.Height = 0.143F;
			this.PaymntItemId2.Left = 1.3775F;
			this.PaymntItemId2.Name = "PaymntItemId2";
			this.PaymntItemId2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId2.Text = null;
			this.PaymntItemId2.Top = 0.858F;
			this.PaymntItemId2.Visible = false;
			this.PaymntItemId2.Width = 0.625F;
			// 
			// DedItemId4
			// 
			this.DedItemId4.DataField = "DED_ITEM_ID4";
			this.DedItemId4.Height = 0.143F;
			this.DedItemId4.Left = 2.6275F;
			this.DedItemId4.Name = "DedItemId4";
			this.DedItemId4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId4.Text = null;
			this.DedItemId4.Top = 1.001F;
			this.DedItemId4.Visible = false;
			this.DedItemId4.Width = 0.625F;
			// 
			// PaymntItemId3
			// 
			this.PaymntItemId3.DataField = "PAYMNT_ITEM_ID3";
			this.PaymntItemId3.Height = 0.143F;
			this.PaymntItemId3.Left = 2.0025F;
			this.PaymntItemId3.Name = "PaymntItemId3";
			this.PaymntItemId3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId3.Text = null;
			this.PaymntItemId3.Top = 0.858F;
			this.PaymntItemId3.Visible = false;
			this.PaymntItemId3.Width = 0.625F;
			// 
			// DedItemId3
			// 
			this.DedItemId3.DataField = "DED_ITEM_ID3";
			this.DedItemId3.Height = 0.143F;
			this.DedItemId3.Left = 2.0025F;
			this.DedItemId3.Name = "DedItemId3";
			this.DedItemId3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId3.Text = null;
			this.DedItemId3.Top = 1.001F;
			this.DedItemId3.Visible = false;
			this.DedItemId3.Width = 0.625F;
			// 
			// PaymntItemId4
			// 
			this.PaymntItemId4.DataField = "PAYMNT_ITEM_ID4";
			this.PaymntItemId4.Height = 0.143F;
			this.PaymntItemId4.Left = 2.6275F;
			this.PaymntItemId4.Name = "PaymntItemId4";
			this.PaymntItemId4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId4.Text = null;
			this.PaymntItemId4.Top = 0.858F;
			this.PaymntItemId4.Visible = false;
			this.PaymntItemId4.Width = 0.625F;
			// 
			// PaymntItemId5
			// 
			this.PaymntItemId5.DataField = "PAYMNT_ITEM_ID5";
			this.PaymntItemId5.Height = 0.143F;
			this.PaymntItemId5.Left = 3.2525F;
			this.PaymntItemId5.Name = "PaymntItemId5";
			this.PaymntItemId5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId5.Text = null;
			this.PaymntItemId5.Top = 0.858F;
			this.PaymntItemId5.Visible = false;
			this.PaymntItemId5.Width = 0.625F;
			// 
			// DedItemId5
			// 
			this.DedItemId5.DataField = "DED_ITEM_ID5";
			this.DedItemId5.Height = 0.143F;
			this.DedItemId5.Left = 3.2525F;
			this.DedItemId5.Name = "DedItemId5";
			this.DedItemId5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId5.Text = null;
			this.DedItemId5.Top = 1.001F;
			this.DedItemId5.Visible = false;
			this.DedItemId5.Width = 0.625F;
			// 
			// PaymntItemId6
			// 
			this.PaymntItemId6.DataField = "PAYMNT_ITEM_ID6";
			this.PaymntItemId6.Height = 0.143F;
			this.PaymntItemId6.Left = 3.8775F;
			this.PaymntItemId6.Name = "PaymntItemId6";
			this.PaymntItemId6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntItemId6.Text = null;
			this.PaymntItemId6.Top = 0.858F;
			this.PaymntItemId6.Visible = false;
			this.PaymntItemId6.Width = 0.625F;
			// 
			// DedItemId6
			// 
			this.DedItemId6.DataField = "DED_ITEM_ID6";
			this.DedItemId6.Height = 0.143F;
			this.DedItemId6.Left = 3.8775F;
			this.DedItemId6.Name = "DedItemId6";
			this.DedItemId6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedItemId6.Text = null;
			this.DedItemId6.Top = 1.001F;
			this.DedItemId6.Visible = false;
			this.DedItemId6.Width = 0.625F;
			// 
			// PaymntDispType1
			// 
			this.PaymntDispType1.DataField = "PAYMNT_DISP_TYPE1";
			this.PaymntDispType1.Height = 0.143F;
			this.PaymntDispType1.Left = 0.7525F;
			this.PaymntDispType1.Name = "PaymntDispType1";
			this.PaymntDispType1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType1.Text = null;
			this.PaymntDispType1.Top = 1.144F;
			this.PaymntDispType1.Visible = false;
			this.PaymntDispType1.Width = 0.625F;
			// 
			// DedDispType1
			// 
			this.DedDispType1.DataField = "DED_DISP_TYPE1";
			this.DedDispType1.Height = 0.143F;
			this.DedDispType1.Left = 0.7525F;
			this.DedDispType1.Name = "DedDispType1";
			this.DedDispType1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType1.Text = null;
			this.DedDispType1.Top = 1.287F;
			this.DedDispType1.Visible = false;
			this.DedDispType1.Width = 0.625F;
			// 
			// DedDispType2
			// 
			this.DedDispType2.DataField = "DED_DISP_TYPE2";
			this.DedDispType2.Height = 0.143F;
			this.DedDispType2.Left = 1.3775F;
			this.DedDispType2.Name = "DedDispType2";
			this.DedDispType2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType2.Text = null;
			this.DedDispType2.Top = 1.287F;
			this.DedDispType2.Visible = false;
			this.DedDispType2.Width = 0.625F;
			// 
			// PaymntDispType2
			// 
			this.PaymntDispType2.DataField = "PAYMNT_DISP_TYPE2";
			this.PaymntDispType2.Height = 0.143F;
			this.PaymntDispType2.Left = 1.3775F;
			this.PaymntDispType2.Name = "PaymntDispType2";
			this.PaymntDispType2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType2.Text = null;
			this.PaymntDispType2.Top = 1.144F;
			this.PaymntDispType2.Visible = false;
			this.PaymntDispType2.Width = 0.625F;
			// 
			// PaymntDispType3
			// 
			this.PaymntDispType3.DataField = "PAYMNT_DISP_TYPE3";
			this.PaymntDispType3.Height = 0.143F;
			this.PaymntDispType3.Left = 2.0025F;
			this.PaymntDispType3.Name = "PaymntDispType3";
			this.PaymntDispType3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType3.Text = null;
			this.PaymntDispType3.Top = 1.144F;
			this.PaymntDispType3.Visible = false;
			this.PaymntDispType3.Width = 0.625F;
			// 
			// DedDispType3
			// 
			this.DedDispType3.DataField = "DED_DISP_TYPE3";
			this.DedDispType3.Height = 0.143F;
			this.DedDispType3.Left = 2.0025F;
			this.DedDispType3.Name = "DedDispType3";
			this.DedDispType3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType3.Text = null;
			this.DedDispType3.Top = 1.287F;
			this.DedDispType3.Visible = false;
			this.DedDispType3.Width = 0.625F;
			// 
			// PaymntDispType4
			// 
			this.PaymntDispType4.DataField = "PAYMNT_DISP_TYPE4";
			this.PaymntDispType4.Height = 0.143F;
			this.PaymntDispType4.Left = 2.6275F;
			this.PaymntDispType4.Name = "PaymntDispType4";
			this.PaymntDispType4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType4.Text = null;
			this.PaymntDispType4.Top = 1.144F;
			this.PaymntDispType4.Visible = false;
			this.PaymntDispType4.Width = 0.625F;
			// 
			// DedDispType4
			// 
			this.DedDispType4.DataField = "DED_DISP_TYPE4";
			this.DedDispType4.Height = 0.143F;
			this.DedDispType4.Left = 2.6275F;
			this.DedDispType4.Name = "DedDispType4";
			this.DedDispType4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType4.Text = null;
			this.DedDispType4.Top = 1.287F;
			this.DedDispType4.Visible = false;
			this.DedDispType4.Width = 0.625F;
			// 
			// PaymntDispType5
			// 
			this.PaymntDispType5.DataField = "PAYMNT_DISP_TYPE5";
			this.PaymntDispType5.Height = 0.143F;
			this.PaymntDispType5.Left = 3.2525F;
			this.PaymntDispType5.Name = "PaymntDispType5";
			this.PaymntDispType5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType5.Text = null;
			this.PaymntDispType5.Top = 1.144F;
			this.PaymntDispType5.Visible = false;
			this.PaymntDispType5.Width = 0.625F;
			// 
			// PaymntDispType6
			// 
			this.PaymntDispType6.DataField = "PAYMNT_DISP_TYPE6";
			this.PaymntDispType6.Height = 0.143F;
			this.PaymntDispType6.Left = 3.8775F;
			this.PaymntDispType6.Name = "PaymntDispType6";
			this.PaymntDispType6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntDispType6.Text = null;
			this.PaymntDispType6.Top = 1.144F;
			this.PaymntDispType6.Visible = false;
			this.PaymntDispType6.Width = 0.625F;
			// 
			// DedDispType5
			// 
			this.DedDispType5.DataField = "DED_DISP_TYPE5";
			this.DedDispType5.Height = 0.143F;
			this.DedDispType5.Left = 3.2525F;
			this.DedDispType5.Name = "DedDispType5";
			this.DedDispType5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType5.Text = null;
			this.DedDispType5.Top = 1.287F;
			this.DedDispType5.Visible = false;
			this.DedDispType5.Width = 0.625F;
			// 
			// DedDispType6
			// 
			this.DedDispType6.DataField = "DED_DISP_TYPE6";
			this.DedDispType6.Height = 0.143F;
			this.DedDispType6.Left = 3.8775F;
			this.DedDispType6.Name = "DedDispType6";
			this.DedDispType6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedDispType6.Text = null;
			this.DedDispType6.Top = 1.287F;
			this.DedDispType6.Visible = false;
			this.DedDispType6.Width = 0.625F;
			// 
			// Label108
			// 
			this.Label108.Height = 0.143F;
			this.Label108.HyperLink = null;
			this.Label108.Left = 3.8775F;
			this.Label108.Name = "Label108";
			this.Label108.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label108.Text = "課税給与所得";
			this.Label108.Top = 6.8905F;
			this.Label108.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg1
			// 
			this.PaymntBnsZeroFlg1.DataField = "PAYMNT_BNS_ZERO_FLG1";
			this.PaymntBnsZeroFlg1.Height = 0.143F;
			this.PaymntBnsZeroFlg1.Left = 0.7525F;
			this.PaymntBnsZeroFlg1.Name = "PaymntBnsZeroFlg1";
			this.PaymntBnsZeroFlg1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg1.Text = null;
			this.PaymntBnsZeroFlg1.Top = 4.625F;
			this.PaymntBnsZeroFlg1.Visible = false;
			this.PaymntBnsZeroFlg1.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg2
			// 
			this.PaymntBnsZeroFlg2.DataField = "PAYMNT_BNS_ZERO_FLG2";
			this.PaymntBnsZeroFlg2.Height = 0.143F;
			this.PaymntBnsZeroFlg2.Left = 1.3775F;
			this.PaymntBnsZeroFlg2.Name = "PaymntBnsZeroFlg2";
			this.PaymntBnsZeroFlg2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg2.Text = null;
			this.PaymntBnsZeroFlg2.Top = 4.625F;
			this.PaymntBnsZeroFlg2.Visible = false;
			this.PaymntBnsZeroFlg2.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg3
			// 
			this.PaymntBnsZeroFlg3.DataField = "PAYMNT_BNS_ZERO_FLG3";
			this.PaymntBnsZeroFlg3.Height = 0.143F;
			this.PaymntBnsZeroFlg3.Left = 2.0025F;
			this.PaymntBnsZeroFlg3.Name = "PaymntBnsZeroFlg3";
			this.PaymntBnsZeroFlg3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg3.Text = null;
			this.PaymntBnsZeroFlg3.Top = 4.625F;
			this.PaymntBnsZeroFlg3.Visible = false;
			this.PaymntBnsZeroFlg3.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg4
			// 
			this.PaymntBnsZeroFlg4.DataField = "PAYMNT_BNS_ZERO_FLG4";
			this.PaymntBnsZeroFlg4.Height = 0.143F;
			this.PaymntBnsZeroFlg4.Left = 2.6275F;
			this.PaymntBnsZeroFlg4.Name = "PaymntBnsZeroFlg4";
			this.PaymntBnsZeroFlg4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg4.Text = null;
			this.PaymntBnsZeroFlg4.Top = 4.625F;
			this.PaymntBnsZeroFlg4.Visible = false;
			this.PaymntBnsZeroFlg4.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg5
			// 
			this.PaymntBnsZeroFlg5.DataField = "PAYMNT_BNS_ZERO_FLG5";
			this.PaymntBnsZeroFlg5.Height = 0.143F;
			this.PaymntBnsZeroFlg5.Left = 3.2525F;
			this.PaymntBnsZeroFlg5.Name = "PaymntBnsZeroFlg5";
			this.PaymntBnsZeroFlg5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg5.Text = null;
			this.PaymntBnsZeroFlg5.Top = 4.625F;
			this.PaymntBnsZeroFlg5.Visible = false;
			this.PaymntBnsZeroFlg5.Width = 0.625F;
			// 
			// PaymntBnsZeroFlg6
			// 
			this.PaymntBnsZeroFlg6.DataField = "PAYMNT_BNS_ZERO_FLG6";
			this.PaymntBnsZeroFlg6.Height = 0.143F;
			this.PaymntBnsZeroFlg6.Left = 3.8775F;
			this.PaymntBnsZeroFlg6.Name = "PaymntBnsZeroFlg6";
			this.PaymntBnsZeroFlg6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsZeroFlg6.Text = null;
			this.PaymntBnsZeroFlg6.Top = 4.625F;
			this.PaymntBnsZeroFlg6.Visible = false;
			this.PaymntBnsZeroFlg6.Width = 0.625F;
			// 
			// DedBnsZeroFlg1
			// 
			this.DedBnsZeroFlg1.DataField = "DED_BNS_ZERO_FLG1";
			this.DedBnsZeroFlg1.Height = 0.143F;
			this.DedBnsZeroFlg1.Left = 0.7525F;
			this.DedBnsZeroFlg1.Name = "DedBnsZeroFlg1";
			this.DedBnsZeroFlg1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg1.Text = null;
			this.DedBnsZeroFlg1.Top = 4.75F;
			this.DedBnsZeroFlg1.Visible = false;
			this.DedBnsZeroFlg1.Width = 0.625F;
			// 
			// DedBnsZeroFlg2
			// 
			this.DedBnsZeroFlg2.DataField = "DED_BNS_ZERO_FLG2";
			this.DedBnsZeroFlg2.Height = 0.143F;
			this.DedBnsZeroFlg2.Left = 1.3775F;
			this.DedBnsZeroFlg2.Name = "DedBnsZeroFlg2";
			this.DedBnsZeroFlg2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg2.Text = null;
			this.DedBnsZeroFlg2.Top = 4.75F;
			this.DedBnsZeroFlg2.Visible = false;
			this.DedBnsZeroFlg2.Width = 0.625F;
			// 
			// DedBnsZeroFlg3
			// 
			this.DedBnsZeroFlg3.DataField = "DED_BNS_ZERO_FLG3";
			this.DedBnsZeroFlg3.Height = 0.143F;
			this.DedBnsZeroFlg3.Left = 2.0025F;
			this.DedBnsZeroFlg3.Name = "DedBnsZeroFlg3";
			this.DedBnsZeroFlg3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg3.Text = null;
			this.DedBnsZeroFlg3.Top = 4.75F;
			this.DedBnsZeroFlg3.Visible = false;
			this.DedBnsZeroFlg3.Width = 0.625F;
			// 
			// DedBnsZeroFlg4
			// 
			this.DedBnsZeroFlg4.DataField = "DED_BNS_ZERO_FLG4";
			this.DedBnsZeroFlg4.Height = 0.143F;
			this.DedBnsZeroFlg4.Left = 2.6275F;
			this.DedBnsZeroFlg4.Name = "DedBnsZeroFlg4";
			this.DedBnsZeroFlg4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg4.Text = null;
			this.DedBnsZeroFlg4.Top = 4.75F;
			this.DedBnsZeroFlg4.Visible = false;
			this.DedBnsZeroFlg4.Width = 0.625F;
			// 
			// DedBnsZeroFlg5
			// 
			this.DedBnsZeroFlg5.DataField = "DED_BNS_ZERO_FLG5";
			this.DedBnsZeroFlg5.Height = 0.143F;
			this.DedBnsZeroFlg5.Left = 3.2525F;
			this.DedBnsZeroFlg5.Name = "DedBnsZeroFlg5";
			this.DedBnsZeroFlg5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg5.Text = null;
			this.DedBnsZeroFlg5.Top = 4.75F;
			this.DedBnsZeroFlg5.Visible = false;
			this.DedBnsZeroFlg5.Width = 0.625F;
			// 
			// DedBnsZeroFlg6
			// 
			this.DedBnsZeroFlg6.DataField = "DED_BNS_ZERO_FLG6";
			this.DedBnsZeroFlg6.Height = 0.143F;
			this.DedBnsZeroFlg6.Left = 3.8775F;
			this.DedBnsZeroFlg6.Name = "DedBnsZeroFlg6";
			this.DedBnsZeroFlg6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsZeroFlg6.Text = null;
			this.DedBnsZeroFlg6.Top = 4.75F;
			this.DedBnsZeroFlg6.Visible = false;
			this.DedBnsZeroFlg6.Width = 0.625F;
			// 
			// PaymntBnsDispType1
			// 
			this.PaymntBnsDispType1.DataField = "PAYMNT_BNS_DISP_TYPE1";
			this.PaymntBnsDispType1.Height = 0.143F;
			this.PaymntBnsDispType1.Left = 0.7525F;
			this.PaymntBnsDispType1.Name = "PaymntBnsDispType1";
			this.PaymntBnsDispType1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType1.Text = null;
			this.PaymntBnsDispType1.Top = 4.875F;
			this.PaymntBnsDispType1.Visible = false;
			this.PaymntBnsDispType1.Width = 0.625F;
			// 
			// PaymntBnsDispType2
			// 
			this.PaymntBnsDispType2.DataField = "PAYMNT_BNS_DISP_TYPE2";
			this.PaymntBnsDispType2.Height = 0.143F;
			this.PaymntBnsDispType2.Left = 1.3775F;
			this.PaymntBnsDispType2.Name = "PaymntBnsDispType2";
			this.PaymntBnsDispType2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType2.Text = null;
			this.PaymntBnsDispType2.Top = 4.875F;
			this.PaymntBnsDispType2.Visible = false;
			this.PaymntBnsDispType2.Width = 0.625F;
			// 
			// PaymntBnsDispType3
			// 
			this.PaymntBnsDispType3.DataField = "PAYMNT_BNS_DISP_TYPE3";
			this.PaymntBnsDispType3.Height = 0.143F;
			this.PaymntBnsDispType3.Left = 2.0025F;
			this.PaymntBnsDispType3.Name = "PaymntBnsDispType3";
			this.PaymntBnsDispType3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType3.Text = null;
			this.PaymntBnsDispType3.Top = 4.875F;
			this.PaymntBnsDispType3.Visible = false;
			this.PaymntBnsDispType3.Width = 0.625F;
			// 
			// PaymntBnsDispType4
			// 
			this.PaymntBnsDispType4.DataField = "PAYMNT_BNS_DISP_TYPE4";
			this.PaymntBnsDispType4.Height = 0.143F;
			this.PaymntBnsDispType4.Left = 2.6275F;
			this.PaymntBnsDispType4.Name = "PaymntBnsDispType4";
			this.PaymntBnsDispType4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType4.Text = null;
			this.PaymntBnsDispType4.Top = 4.875F;
			this.PaymntBnsDispType4.Visible = false;
			this.PaymntBnsDispType4.Width = 0.625F;
			// 
			// PaymntBnsDispType5
			// 
			this.PaymntBnsDispType5.DataField = "PAYMNT_BNS_DISP_TYPE5";
			this.PaymntBnsDispType5.Height = 0.143F;
			this.PaymntBnsDispType5.Left = 3.2525F;
			this.PaymntBnsDispType5.Name = "PaymntBnsDispType5";
			this.PaymntBnsDispType5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType5.Text = null;
			this.PaymntBnsDispType5.Top = 4.875F;
			this.PaymntBnsDispType5.Visible = false;
			this.PaymntBnsDispType5.Width = 0.625F;
			// 
			// PaymntBnsDispType6
			// 
			this.PaymntBnsDispType6.DataField = "PAYMNT_BNS_DISP_TYPE6";
			this.PaymntBnsDispType6.Height = 0.143F;
			this.PaymntBnsDispType6.Left = 3.8775F;
			this.PaymntBnsDispType6.Name = "PaymntBnsDispType6";
			this.PaymntBnsDispType6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PaymntBnsDispType6.Text = null;
			this.PaymntBnsDispType6.Top = 4.875F;
			this.PaymntBnsDispType6.Visible = false;
			this.PaymntBnsDispType6.Width = 0.625F;
			// 
			// DedBnsDispType1
			// 
			this.DedBnsDispType1.DataField = "DED_BNS_DISP_TYPE1";
			this.DedBnsDispType1.Height = 0.143F;
			this.DedBnsDispType1.Left = 0.7525F;
			this.DedBnsDispType1.Name = "DedBnsDispType1";
			this.DedBnsDispType1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType1.Text = null;
			this.DedBnsDispType1.Top = 5F;
			this.DedBnsDispType1.Visible = false;
			this.DedBnsDispType1.Width = 0.625F;
			// 
			// DedBnsDispType2
			// 
			this.DedBnsDispType2.DataField = "DED_BNS_DISP_TYPE2";
			this.DedBnsDispType2.Height = 0.143F;
			this.DedBnsDispType2.Left = 1.3775F;
			this.DedBnsDispType2.Name = "DedBnsDispType2";
			this.DedBnsDispType2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType2.Text = null;
			this.DedBnsDispType2.Top = 5F;
			this.DedBnsDispType2.Visible = false;
			this.DedBnsDispType2.Width = 0.625F;
			// 
			// DedBnsDispType3
			// 
			this.DedBnsDispType3.DataField = "DED_BNS_DISP_TYPE3";
			this.DedBnsDispType3.Height = 0.143F;
			this.DedBnsDispType3.Left = 2.0025F;
			this.DedBnsDispType3.Name = "DedBnsDispType3";
			this.DedBnsDispType3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType3.Text = null;
			this.DedBnsDispType3.Top = 5F;
			this.DedBnsDispType3.Visible = false;
			this.DedBnsDispType3.Width = 0.625F;
			// 
			// DedBnsDispType4
			// 
			this.DedBnsDispType4.DataField = "DED_BNS_DISP_TYPE4";
			this.DedBnsDispType4.Height = 0.143F;
			this.DedBnsDispType4.Left = 2.6275F;
			this.DedBnsDispType4.Name = "DedBnsDispType4";
			this.DedBnsDispType4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType4.Text = null;
			this.DedBnsDispType4.Top = 5F;
			this.DedBnsDispType4.Visible = false;
			this.DedBnsDispType4.Width = 0.625F;
			// 
			// DedBnsDispType5
			// 
			this.DedBnsDispType5.DataField = "DED_BNS_DISP_TYPE5";
			this.DedBnsDispType5.Height = 0.143F;
			this.DedBnsDispType5.Left = 3.2525F;
			this.DedBnsDispType5.Name = "DedBnsDispType5";
			this.DedBnsDispType5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType5.Text = null;
			this.DedBnsDispType5.Top = 5F;
			this.DedBnsDispType5.Visible = false;
			this.DedBnsDispType5.Width = 0.625F;
			// 
			// DedBnsDispType6
			// 
			this.DedBnsDispType6.DataField = "DED_BNS_DISP_TYPE6";
			this.DedBnsDispType6.Height = 0.143F;
			this.DedBnsDispType6.Left = 3.8775F;
			this.DedBnsDispType6.Name = "DedBnsDispType6";
			this.DedBnsDispType6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DedBnsDispType6.Text = null;
			this.DedBnsDispType6.Top = 5F;
			this.DedBnsDispType6.Visible = false;
			this.DedBnsDispType6.Width = 0.625F;
			// 
			// Line410
			// 
			this.Line410.Height = 0F;
			this.Line410.Left = 0.063F;
			this.Line410.LineWeight = 1F;
			this.Line410.Name = "Line410";
			this.Line410.Top = 4.602999F;
			this.Line410.Width = 4.44F;
			this.Line410.X1 = 0.063F;
			this.Line410.X2 = 4.503F;
			this.Line410.Y1 = 4.602999F;
			this.Line410.Y2 = 4.602999F;
			// 
			// Label145
			// 
			this.Label145.Height = 0.143F;
			this.Label145.HyperLink = null;
			this.Label145.Left = 0.313F;
			this.Label145.Name = "Label145";
			this.Label145.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label145.Text = "支給";
			this.Label145.Top = 4.317F;
			this.Label145.Width = 0.44F;
			// 
			// Line411
			// 
			this.Line411.Height = 0F;
			this.Line411.Left = 0.754F;
			this.Line411.LineWeight = 1F;
			this.Line411.Name = "Line411";
			this.Line411.Top = 4.445F;
			this.Line411.Width = 3.749F;
			this.Line411.X1 = 0.754F;
			this.Line411.X2 = 4.503F;
			this.Line411.Y1 = 4.445F;
			this.Line411.Y2 = 4.445F;
			// 
			// Label146
			// 
			this.Label146.Height = 0.16F;
			this.Label146.HyperLink = null;
			this.Label146.Left = 0.313F;
			this.Label146.Name = "Label146";
			this.Label146.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label146.Text = "月日";
			this.Label146.Top = 4.471F;
			this.Label146.Width = 0.44F;
			// 
			// PaymntBnsName1
			// 
			this.PaymntBnsName1.DataField = "PAYMNT_BNS_NAME1";
			this.PaymntBnsName1.Height = 0.143F;
			this.PaymntBnsName1.Left = 0.753F;
			this.PaymntBnsName1.Name = "PaymntBnsName1";
			this.PaymntBnsName1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName1.Text = "あいうえおか";
			this.PaymntBnsName1.Top = 4.307F;
			this.PaymntBnsName1.Width = 0.625F;
			// 
			// DedBnsName1
			// 
			this.DedBnsName1.DataField = "DED_BNS_NAME1";
			this.DedBnsName1.Height = 0.143F;
			this.DedBnsName1.Left = 0.753F;
			this.DedBnsName1.Name = "DedBnsName1";
			this.DedBnsName1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName1.Text = "あいうえおか";
			this.DedBnsName1.Top = 4.46F;
			this.DedBnsName1.Width = 0.625F;
			// 
			// PaymntBnsName2
			// 
			this.PaymntBnsName2.DataField = "PAYMNT_BNS_NAME2";
			this.PaymntBnsName2.Height = 0.143F;
			this.PaymntBnsName2.Left = 1.378F;
			this.PaymntBnsName2.Name = "PaymntBnsName2";
			this.PaymntBnsName2.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName2.Text = "あいうえおか";
			this.PaymntBnsName2.Top = 4.307F;
			this.PaymntBnsName2.Width = 0.625F;
			// 
			// DedBnsName2
			// 
			this.DedBnsName2.DataField = "DED_BNS_NAME2";
			this.DedBnsName2.Height = 0.143F;
			this.DedBnsName2.Left = 1.378F;
			this.DedBnsName2.Name = "DedBnsName2";
			this.DedBnsName2.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName2.Text = "あいうえおか";
			this.DedBnsName2.Top = 4.46F;
			this.DedBnsName2.Width = 0.625F;
			// 
			// PaymntBnsName3
			// 
			this.PaymntBnsName3.DataField = "PAYMNT_BNS_NAME3";
			this.PaymntBnsName3.Height = 0.143F;
			this.PaymntBnsName3.Left = 2.003F;
			this.PaymntBnsName3.Name = "PaymntBnsName3";
			this.PaymntBnsName3.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName3.Text = "あいうえおか";
			this.PaymntBnsName3.Top = 4.307F;
			this.PaymntBnsName3.Width = 0.625F;
			// 
			// DedBnsName3
			// 
			this.DedBnsName3.DataField = "DED_BNS_NAME3";
			this.DedBnsName3.Height = 0.143F;
			this.DedBnsName3.Left = 2.003F;
			this.DedBnsName3.Name = "DedBnsName3";
			this.DedBnsName3.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName3.Text = "あいうえおか";
			this.DedBnsName3.Top = 4.46F;
			this.DedBnsName3.Width = 0.625F;
			// 
			// PaymntBnsName4
			// 
			this.PaymntBnsName4.DataField = "PAYMNT_BNS_NAME4";
			this.PaymntBnsName4.Height = 0.143F;
			this.PaymntBnsName4.Left = 2.628F;
			this.PaymntBnsName4.Name = "PaymntBnsName4";
			this.PaymntBnsName4.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName4.Text = "あいうえおか";
			this.PaymntBnsName4.Top = 4.307F;
			this.PaymntBnsName4.Width = 0.625F;
			// 
			// DedBnsName4
			// 
			this.DedBnsName4.DataField = "DED_BNS_NAME4";
			this.DedBnsName4.Height = 0.143F;
			this.DedBnsName4.Left = 2.628F;
			this.DedBnsName4.Name = "DedBnsName4";
			this.DedBnsName4.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName4.Text = "あいうえおか";
			this.DedBnsName4.Top = 4.46F;
			this.DedBnsName4.Width = 0.625F;
			// 
			// PaymntBnsName5
			// 
			this.PaymntBnsName5.DataField = "PAYMNT_BNS_NAME5";
			this.PaymntBnsName5.Height = 0.143F;
			this.PaymntBnsName5.Left = 3.253F;
			this.PaymntBnsName5.Name = "PaymntBnsName5";
			this.PaymntBnsName5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName5.Text = "あいうえおか";
			this.PaymntBnsName5.Top = 4.307F;
			this.PaymntBnsName5.Width = 0.625F;
			// 
			// DedBnsName5
			// 
			this.DedBnsName5.DataField = "DED_BNS_NAME5";
			this.DedBnsName5.Height = 0.143F;
			this.DedBnsName5.Left = 3.253F;
			this.DedBnsName5.Name = "DedBnsName5";
			this.DedBnsName5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName5.Text = "あいうえおか";
			this.DedBnsName5.Top = 4.46F;
			this.DedBnsName5.Width = 0.625F;
			// 
			// DedBnsName6
			// 
			this.DedBnsName6.DataField = "DED_BNS_NAME6";
			this.DedBnsName6.Height = 0.143F;
			this.DedBnsName6.Left = 3.878F;
			this.DedBnsName6.Name = "DedBnsName6";
			this.DedBnsName6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DedBnsName6.Text = "あいうえおか";
			this.DedBnsName6.Top = 4.46F;
			this.DedBnsName6.Width = 0.624F;
			// 
			// PaymntBnsName6
			// 
			this.PaymntBnsName6.DataField = "PAYMNT_BNS_NAME6";
			this.PaymntBnsName6.Height = 0.143F;
			this.PaymntBnsName6.Left = 3.878F;
			this.PaymntBnsName6.Name = "PaymntBnsName6";
			this.PaymntBnsName6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.PaymntBnsName6.Text = "あいうえおか";
			this.PaymntBnsName6.Top = 4.307F;
			this.PaymntBnsName6.Width = 0.624F;
			// 
			// SubReport1
			// 
			this.SubReport1.CloseBorder = false;
			this.SubReport1.Height = 6.891F;
			this.SubReport1.Left = 4.502F;
			this.SubReport1.Name = "SubReport1";
			this.SubReport1.Report = null;
			this.SubReport1.ReportName = "HR_PY06_R97";
			this.SubReport1.Top = 0.286F;
			this.SubReport1.Width = 3.78F;
			// 
			// SubReport2
			// 
			this.SubReport2.CloseBorder = false;
			this.SubReport2.Height = 10.58F;
			this.SubReport2.Left = 8.312F;
			this.SubReport2.Name = "SubReport2";
			this.SubReport2.Report = null;
			this.SubReport2.ReportName = "HR_PY_06_R98";
			this.SubReport2.Top = 0.275F;
			this.SubReport2.Width = 2.574F;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label2,
            this.PAGE,
            this.Label3,
            this.PAGESUM,
            this.Label4,
            this.DateText,
            this.ReportIDText,
            this.PrintName,
            this.Line208,
            this.SlryPaymntYy});
			this.PageHeader.Height = 0.3645833F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			this.PageHeader.BeforePrint += new System.EventHandler(this.PageHeader_BeforePrint);
			this.PageHeader.AfterPrint += new System.EventHandler(this.PageHeader_AfterPrint);
			// 
			// Label2
			// 
			this.Label2.Height = 0.2F;
			this.Label2.HyperLink = null;
			this.Label2.Left = 9F;
			this.Label2.Name = "Label2";
			this.Label2.Style = "font-size: 9pt; ddo-char-set: 1";
			this.Label2.Text = "　ページ：";
			this.Label2.Top = 0F;
			this.Label2.Width = 0.6875F;
			// 
			// PAGE
			// 
			this.PAGE.CanGrow = false;
			this.PAGE.Height = 0.1875F;
			this.PAGE.Left = 9.5625F;
			this.PAGE.Name = "PAGE";
			this.PAGE.OutputFormat = "####0";
			this.PAGE.Style = "font-size: 9pt; text-align: right; white-space: nowrap; ddo-char-set: 1";
			this.PAGE.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All;
			this.PAGE.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount;
			this.PAGE.Tag = "";
			this.PAGE.Text = "12345";
			this.PAGE.Top = 0F;
			this.PAGE.Width = 0.375F;
			// 
			// Label3
			// 
			this.Label3.Height = 0.1875F;
			this.Label3.HyperLink = null;
			this.Label3.Left = 9.9375F;
			this.Label3.Name = "Label3";
			this.Label3.Style = "font-size: 9pt; ddo-char-set: 1";
			this.Label3.Text = "/";
			this.Label3.Top = 0F;
			this.Label3.Width = 0.1875F;
			// 
			// PAGESUM
			// 
			this.PAGESUM.CanGrow = false;
			this.PAGESUM.Height = 0.1875F;
			this.PAGESUM.Left = 10.02083F;
			this.PAGESUM.Name = "PAGESUM";
			this.PAGESUM.OutputFormat = "####0";
			this.PAGESUM.Style = "font-size: 9pt; text-align: left; white-space: nowrap; ddo-char-set: 1";
			this.PAGESUM.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount;
			this.PAGESUM.Text = "12345";
			this.PAGESUM.Top = 0F;
			this.PAGESUM.Width = 0.375F;
			// 
			// Label4
			// 
			this.Label4.Height = 0.2F;
			this.Label4.HyperLink = null;
			this.Label4.Left = 9F;
			this.Label4.Name = "Label4";
			this.Label4.Style = "font-size: 9pt; ddo-char-set: 1";
			this.Label4.Text = "作成日時：";
			this.Label4.Top = 0.1875F;
			this.Label4.Width = 0.6875F;
			// 
			// DateText
			// 
			this.DateText.CanGrow = false;
			this.DateText.Height = 0.188F;
			this.DateText.Left = 9.625F;
			this.DateText.Name = "DateText";
			this.DateText.Style = "font-size: 9pt; text-align: left; white-space: nowrap; ddo-char-set: 1";
			this.DateText.Text = "6666/66/66 66:66:66";
			this.DateText.Top = 0.1875F;
			this.DateText.Width = 1.25F;
			// 
			// ReportIDText
			// 
			this.ReportIDText.CanGrow = false;
			this.ReportIDText.Height = 0.1875F;
			this.ReportIDText.Left = 0.0625F;
			this.ReportIDText.Name = "ReportIDText";
			this.ReportIDText.Style = "font-size: 9pt; white-space: nowrap; ddo-char-set: 1";
			this.ReportIDText.Text = "(HR_PY_06_R29)";
			this.ReportIDText.Top = 0F;
			this.ReportIDText.Width = 1.6875F;
			// 
			// PrintName
			// 
			this.PrintName.Height = 0.22F;
			this.PrintName.Left = 3.25F;
			this.PrintName.Name = "PrintName";
			this.PrintName.Style = "font-size: 14pt; text-align: center; ddo-char-set: 1";
			this.PrintName.Text = "賃金台帳兼源泉徴収簿";
			this.PrintName.Top = 0F;
			this.PrintName.Width = 3.75F;
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
			// SlryPaymntYy
			// 
			this.SlryPaymntYy.DataField = "SLRY_PAYMNT_YY";
			this.SlryPaymntYy.Height = 0.18F;
			this.SlryPaymntYy.Left = 4.875F;
			this.SlryPaymntYy.Name = "SlryPaymntYy";
			this.SlryPaymntYy.Style = "font-size: 9pt; font-weight: normal; vertical-align: middle; ddo-char-set: 128";
			this.SlryPaymntYy.Text = "9999年度";
			this.SlryPaymntYy.Top = 0.1875F;
			this.SlryPaymntYy.Width = 0.5625F;
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.CompanyNameText});
			this.PageFooter.Height = 0.1979167F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Format += new System.EventHandler(this.PageFooter_Format);
			this.PageFooter.AfterPrint += new System.EventHandler(this.PageFooter_AfterPrint);
			// 
			// CompanyNameText
			// 
			this.CompanyNameText.CanGrow = false;
			this.CompanyNameText.Height = 0.1875F;
			this.CompanyNameText.Left = 0.6875F;
			this.CompanyNameText.Name = "CompanyNameText";
			this.CompanyNameText.Style = "font-size: 9pt; text-align: right; white-space: nowrap; ddo-char-set: 1";
			this.CompanyNameText.Text = null;
			this.CompanyNameText.Top = 0F;
			this.CompanyNameText.Width = 10.17708F;
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
			// HR_PY_06_R29
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
			this.ReportStart += new System.EventHandler(this.HR_PY_06_R29_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.AtacName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChgDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostCodeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensRefeNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmplyInsMarkNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymnt1mm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymnt1dd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt1Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded1Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt2Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded2Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox89)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox90)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt3Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded3Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt4Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded4Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt5Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded5Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox191)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox192)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt6Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded6Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox233)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox234)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt7Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded7Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox259)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox260)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt8Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded8Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox293)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox294)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt9Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded9Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox335)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox336)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt10Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded10Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox361)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox362)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt11Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded11Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox395)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox396)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt12Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded12Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal1Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal1Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label84)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox482)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox483)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt13Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded13Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label85)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox508)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox509)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt14Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded14Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label86)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox534)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox535)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt15Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded15Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label87)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox560)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox561)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt16Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded16Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label88)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal2Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal2Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label89)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt17Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded17Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label90)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntTotal3Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedTotal3Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label91)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label92)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paymnt18Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label107)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ded18Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntZeroFlg6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedZeroFlg6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EnterComp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntItemId6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemId6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDispType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedDispType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsZeroFlg6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsZeroFlg6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsDispType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsDispType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedBnsName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntBnsName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
