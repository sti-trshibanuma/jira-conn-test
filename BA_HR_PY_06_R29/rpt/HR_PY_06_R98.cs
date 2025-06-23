// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 06
// File Name   : HR_PY_06_R98.cs
// 機能名      : HR_PY_06_R98 賃金台帳兼源泉徴収簿(サブレポート)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K24565 2012/10/03 ActiveReportsバージョンアップ対応
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
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_06_R98 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_06_R98()
		{


			InitializeComponent();
		}

		#region Protected Fields
		private const string TAX_REVISION_YEAR = "2006";
		private const string EARTHQUAKE_INSURANCE_DED = "地震保険控除";
		private const string H23_TAX_REVISION_YEAR = "2011";
		//平成24年以後の所得税改正（介護医療保険控除創設）の西暦年
		private const string TAX_REVISION_CARE_YEAR = "2012";
// 管理番号K26643 From
		private const string H30_TAX_REVISION_YEAR = "2018";
// 管理番号K26643 To
// 管理番号K27274 From
		private const string R02_TAX_REVISION_YEAR = "2020";
// 管理番号K27274 To
		protected string reportID;
		protected string companyName;
		protected CommonData cd;

		private Label Label156;
		private TextBox TextBox484;
		private GroupHeader GroupHeader1;
		private GroupFooter GroupFooter1;
		private Label Label9;
		private Line Line266;
		private Label Label1;
		private TextBox DtyName1;		// 支給合計3項目11出力フラグ

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

		private void HR_PY_06_R98_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;

			// 制御用の値をコントロールに設定
			DtyDispType1.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE1"].ToString();
			DtyDispType2.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE2"].ToString();
			DtyDispType3.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE3"].ToString();
			DtyDispType4.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE4"].ToString();
			DtyDispType5.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE5"].ToString();
			DtyDispType6.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE6"].ToString();
			DtyDispType7.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE7"].ToString();
			DtyDispType8.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_DISP_TYPE8"].ToString();

			DtyName1.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME1"].ToString();
			DtyName2.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME2"].ToString();
			DtyName3.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME3"].ToString();
			DtyName4.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME4"].ToString();
			DtyName5.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME5"].ToString();
			DtyName6.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME6"].ToString();
			DtyName7.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME7"].ToString();
			DtyName8.Text = ((System.Data.DataRow[])(DataSource))[0]["DTY_NAME8"].ToString();

			if (DtyDispType1.Text == "2")
			{
				Dty1Num1.OutputFormat = "###0";
				Dty2Num1.OutputFormat = "###0";
				Dty3Num1.OutputFormat = "###0";
				Dty4Num1.OutputFormat = "###0";
				Dty5Num1.OutputFormat = "###0";
				Dty6Num1.OutputFormat = "###0";
				Dty7Num1.OutputFormat = "###0";
				Dty8Num1.OutputFormat = "###0";
				Dty9Num1.OutputFormat = "###0";
				Dty10Num1.OutputFormat = "###0";
				Dty11Num1.OutputFormat = "###0";
				Dty12Num1.OutputFormat = "###0";
				DtyTotal1.OutputFormat = "###0";
			}

			else if (DtyDispType1.Text == "3")
			{
				Dty1Num1.OutputFormat = "#,##0.00";
				Dty2Num1.OutputFormat = "#,##0.00";
				Dty3Num1.OutputFormat = "#,##0.00";
				Dty4Num1.OutputFormat = "#,##0.00";
				Dty5Num1.OutputFormat = "#,##0.00";
				Dty6Num1.OutputFormat = "#,##0.00";
				Dty7Num1.OutputFormat = "#,##0.00";
				Dty8Num1.OutputFormat = "#,##0.00";
				Dty9Num1.OutputFormat = "#,##0.00";
				Dty10Num1.OutputFormat = "#,##0.00";
				Dty11Num1.OutputFormat = "#,##0.00";
				Dty12Num1.OutputFormat = "#,##0.00";
				DtyTotal1.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType1.Text == "4")
			{
				Dty1Num1.OutputFormat = "###0.00";
				Dty2Num1.OutputFormat = "###0.00";
				Dty3Num1.OutputFormat = "###0.00";
				Dty4Num1.OutputFormat = "###0.00";
				Dty5Num1.OutputFormat = "###0.00";
				Dty6Num1.OutputFormat = "###0.00";
				Dty7Num1.OutputFormat = "###0.00";
				Dty8Num1.OutputFormat = "###0.00";
				Dty9Num1.OutputFormat = "###0.00";
				Dty10Num1.OutputFormat = "###0.00";
				Dty11Num1.OutputFormat = "###0.00";
				Dty12Num1.OutputFormat = "###0.00";
				DtyTotal1.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num1.OutputFormat = "#,##0";
				Dty2Num1.OutputFormat = "#,##0";
				Dty3Num1.OutputFormat = "#,##0";
				Dty4Num1.OutputFormat = "#,##0";
				Dty5Num1.OutputFormat = "#,##0";
				Dty6Num1.OutputFormat = "#,##0";
				Dty7Num1.OutputFormat = "#,##0";
				Dty8Num1.OutputFormat = "#,##0";
				Dty9Num1.OutputFormat = "#,##0";
				Dty10Num1.OutputFormat = "#,##0";
				Dty11Num1.OutputFormat = "#,##0";
				Dty12Num1.OutputFormat = "#,##0";
				DtyTotal1.OutputFormat = "#,##0";
			}

			if (DtyDispType2.Text == "2")
			{
				Dty1Num2.OutputFormat = "###0";
				Dty2Num2.OutputFormat = "###0";
				Dty3Num2.OutputFormat = "###0";
				Dty4Num2.OutputFormat = "###0";
				Dty5Num2.OutputFormat = "###0";
				Dty6Num2.OutputFormat = "###0";
				Dty7Num2.OutputFormat = "###0";
				Dty8Num2.OutputFormat = "###0";
				Dty9Num2.OutputFormat = "###0";
				Dty10Num2.OutputFormat = "###0";
				Dty11Num2.OutputFormat = "###0";
				Dty12Num2.OutputFormat = "###0";
				DtyTotal2.OutputFormat = "###0";
			}

			else if (DtyDispType2.Text == "3")
			{
				Dty1Num2.OutputFormat = "#,##0.00";
				Dty2Num2.OutputFormat = "#,##0.00";
				Dty3Num2.OutputFormat = "#,##0.00";
				Dty4Num2.OutputFormat = "#,##0.00";
				Dty5Num2.OutputFormat = "#,##0.00";
				Dty6Num2.OutputFormat = "#,##0.00";
				Dty7Num2.OutputFormat = "#,##0.00";
				Dty8Num2.OutputFormat = "#,##0.00";
				Dty9Num2.OutputFormat = "#,##0.00";
				Dty10Num2.OutputFormat = "#,##0.00";
				Dty11Num2.OutputFormat = "#,##0.00";
				Dty12Num2.OutputFormat = "#,##0.00";
				DtyTotal2.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType2.Text == "4")
			{
				Dty1Num2.OutputFormat = "###0.00";
				Dty2Num2.OutputFormat = "###0.00";
				Dty3Num2.OutputFormat = "###0.00";
				Dty4Num2.OutputFormat = "###0.00";
				Dty5Num2.OutputFormat = "###0.00";
				Dty6Num2.OutputFormat = "###0.00";
				Dty7Num2.OutputFormat = "###0.00";
				Dty8Num2.OutputFormat = "###0.00";
				Dty9Num2.OutputFormat = "###0.00";
				Dty10Num2.OutputFormat = "###0.00";
				Dty11Num2.OutputFormat = "###0.00";
				Dty12Num2.OutputFormat = "###0.00";
				DtyTotal2.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num2.OutputFormat = "#,##0";
				Dty2Num2.OutputFormat = "#,##0";
				Dty3Num2.OutputFormat = "#,##0";
				Dty4Num2.OutputFormat = "#,##0";
				Dty5Num2.OutputFormat = "#,##0";
				Dty6Num2.OutputFormat = "#,##0";
				Dty7Num2.OutputFormat = "#,##0";
				Dty8Num2.OutputFormat = "#,##0";
				Dty9Num2.OutputFormat = "#,##0";
				Dty10Num2.OutputFormat = "#,##0";
				Dty11Num2.OutputFormat = "#,##0";
				Dty12Num2.OutputFormat = "#,##0";
				DtyTotal2.OutputFormat = "#,##0";
			}

			if (DtyDispType3.Text == "2")
			{
				Dty1Num3.OutputFormat = "###0";
				Dty2Num3.OutputFormat = "###0";
				Dty3Num3.OutputFormat = "###0";
				Dty4Num3.OutputFormat = "###0";
				Dty5Num3.OutputFormat = "###0";
				Dty6Num3.OutputFormat = "###0";
				Dty7Num3.OutputFormat = "###0";
				Dty8Num3.OutputFormat = "###0";
				Dty9Num3.OutputFormat = "###0";
				Dty10Num3.OutputFormat = "###0";
				Dty11Num3.OutputFormat = "###0";
				Dty12Num3.OutputFormat = "###0";
				DtyTotal3.OutputFormat = "###0";
			}

			else if (DtyDispType3.Text == "3")
			{
				Dty1Num3.OutputFormat = "#,##0.00";
				Dty2Num3.OutputFormat = "#,##0.00";
				Dty3Num3.OutputFormat = "#,##0.00";
				Dty4Num3.OutputFormat = "#,##0.00";
				Dty5Num3.OutputFormat = "#,##0.00";
				Dty6Num3.OutputFormat = "#,##0.00";
				Dty7Num3.OutputFormat = "#,##0.00";
				Dty8Num3.OutputFormat = "#,##0.00";
				Dty9Num3.OutputFormat = "#,##0.00";
				Dty10Num3.OutputFormat = "#,##0.00";
				Dty11Num3.OutputFormat = "#,##0.00";
				Dty12Num3.OutputFormat = "#,##0.00";
				DtyTotal3.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType3.Text == "4")
			{
				Dty1Num3.OutputFormat = "###0.00";
				Dty2Num3.OutputFormat = "###0.00";
				Dty3Num3.OutputFormat = "###0.00";
				Dty4Num3.OutputFormat = "###0.00";
				Dty5Num3.OutputFormat = "###0.00";
				Dty6Num3.OutputFormat = "###0.00";
				Dty7Num3.OutputFormat = "###0.00";
				Dty8Num3.OutputFormat = "###0.00";
				Dty9Num3.OutputFormat = "###0.00";
				Dty10Num3.OutputFormat = "###0.00";
				Dty11Num3.OutputFormat = "###0.00";
				Dty12Num3.OutputFormat = "###0.00";
				DtyTotal3.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num3.OutputFormat = "#,##0";
				Dty2Num3.OutputFormat = "#,##0";
				Dty3Num3.OutputFormat = "#,##0";
				Dty4Num3.OutputFormat = "#,##0";
				Dty5Num3.OutputFormat = "#,##0";
				Dty6Num3.OutputFormat = "#,##0";
				Dty7Num3.OutputFormat = "#,##0";
				Dty8Num3.OutputFormat = "#,##0";
				Dty9Num3.OutputFormat = "#,##0";
				Dty10Num3.OutputFormat = "#,##0";
				Dty11Num3.OutputFormat = "#,##0";
				Dty12Num3.OutputFormat = "#,##0";
				DtyTotal3.OutputFormat = "#,##0";
			}

			if (DtyDispType4.Text == "2")
			{
				Dty1Num4.OutputFormat = "###0";
				Dty2Num4.OutputFormat = "###0";
				Dty3Num4.OutputFormat = "###0";
				Dty4Num4.OutputFormat = "###0";
				Dty5Num4.OutputFormat = "###0";
				Dty6Num4.OutputFormat = "###0";
				Dty7Num4.OutputFormat = "###0";
				Dty8Num4.OutputFormat = "###0";
				Dty9Num4.OutputFormat = "###0";
				Dty10Num4.OutputFormat = "###0";
				Dty11Num4.OutputFormat = "###0";
				Dty12Num4.OutputFormat = "###0";
				DtyTotal4.OutputFormat = "###0";
			}

			else if (DtyDispType4.Text == "3")
			{
				Dty1Num4.OutputFormat = "#,##0.00";
				Dty2Num4.OutputFormat = "#,##0.00";
				Dty3Num4.OutputFormat = "#,##0.00";
				Dty4Num4.OutputFormat = "#,##0.00";
				Dty5Num4.OutputFormat = "#,##0.00";
				Dty6Num4.OutputFormat = "#,##0.00";
				Dty7Num4.OutputFormat = "#,##0.00";
				Dty8Num4.OutputFormat = "#,##0.00";
				Dty9Num4.OutputFormat = "#,##0.00";
				Dty10Num4.OutputFormat = "#,##0.00";
				Dty11Num4.OutputFormat = "#,##0.00";
				Dty12Num4.OutputFormat = "#,##0.00";
				DtyTotal4.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType4.Text == "4")
			{
				Dty1Num4.OutputFormat = "###0.00";
				Dty2Num4.OutputFormat = "###0.00";
				Dty3Num4.OutputFormat = "###0.00";
				Dty4Num4.OutputFormat = "###0.00";
				Dty5Num4.OutputFormat = "###0.00";
				Dty6Num4.OutputFormat = "###0.00";
				Dty7Num4.OutputFormat = "###0.00";
				Dty8Num4.OutputFormat = "###0.00";
				Dty9Num4.OutputFormat = "###0.00";
				Dty10Num4.OutputFormat = "###0.00";
				Dty11Num4.OutputFormat = "###0.00";
				Dty12Num4.OutputFormat = "###0.00";
				DtyTotal4.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num4.OutputFormat = "#,##0";
				Dty2Num4.OutputFormat = "#,##0";
				Dty3Num4.OutputFormat = "#,##0";
				Dty4Num4.OutputFormat = "#,##0";
				Dty5Num4.OutputFormat = "#,##0";
				Dty6Num4.OutputFormat = "#,##0";
				Dty7Num4.OutputFormat = "#,##0";
				Dty8Num4.OutputFormat = "#,##0";
				Dty9Num4.OutputFormat = "#,##0";
				Dty10Num4.OutputFormat = "#,##0";
				Dty11Num4.OutputFormat = "#,##0";
				Dty12Num4.OutputFormat = "#,##0";
				DtyTotal4.OutputFormat = "#,##0";
			}

			if (DtyDispType5.Text == "2")
			{
				Dty1Num5.OutputFormat = "###0";
				Dty2Num5.OutputFormat = "###0";
				Dty3Num5.OutputFormat = "###0";
				Dty4Num5.OutputFormat = "###0";
				Dty5Num5.OutputFormat = "###0";
				Dty6Num5.OutputFormat = "###0";
				Dty7Num5.OutputFormat = "###0";
				Dty8Num5.OutputFormat = "###0";
				Dty9Num5.OutputFormat = "###0";
				Dty10Num5.OutputFormat = "###0";
				Dty11Num5.OutputFormat = "###0";
				Dty12Num5.OutputFormat = "###0";
				DtyTotal5.OutputFormat = "###0";
			}

			else if (DtyDispType5.Text == "3")
			{
				Dty1Num5.OutputFormat = "#,##0.00";
				Dty2Num5.OutputFormat = "#,##0.00";
				Dty3Num5.OutputFormat = "#,##0.00";
				Dty4Num5.OutputFormat = "#,##0.00";
				Dty5Num5.OutputFormat = "#,##0.00";
				Dty6Num5.OutputFormat = "#,##0.00";
				Dty7Num5.OutputFormat = "#,##0.00";
				Dty8Num5.OutputFormat = "#,##0.00";
				Dty9Num5.OutputFormat = "#,##0.00";
				Dty10Num5.OutputFormat = "#,##0.00";
				Dty11Num5.OutputFormat = "#,##0.00";
				Dty12Num5.OutputFormat = "#,##0.00";
				DtyTotal5.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType5.Text == "4")
			{
				Dty1Num5.OutputFormat = "###0.00";
				Dty2Num5.OutputFormat = "###0.00";
				Dty3Num5.OutputFormat = "###0.00";
				Dty4Num5.OutputFormat = "###0.00";
				Dty5Num5.OutputFormat = "###0.00";
				Dty6Num5.OutputFormat = "###0.00";
				Dty7Num5.OutputFormat = "###0.00";
				Dty8Num5.OutputFormat = "###0.00";
				Dty9Num5.OutputFormat = "###0.00";
				Dty10Num5.OutputFormat = "###0.00";
				Dty11Num5.OutputFormat = "###0.00";
				Dty12Num5.OutputFormat = "###0.00";
				DtyTotal5.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num5.OutputFormat = "#,##0";
				Dty2Num5.OutputFormat = "#,##0";
				Dty3Num5.OutputFormat = "#,##0";
				Dty4Num5.OutputFormat = "#,##0";
				Dty5Num5.OutputFormat = "#,##0";
				Dty6Num5.OutputFormat = "#,##0";
				Dty7Num5.OutputFormat = "#,##0";
				Dty8Num5.OutputFormat = "#,##0";
				Dty9Num5.OutputFormat = "#,##0";
				Dty10Num5.OutputFormat = "#,##0";
				Dty11Num5.OutputFormat = "#,##0";
				Dty12Num5.OutputFormat = "#,##0";
				DtyTotal5.OutputFormat = "#,##0";
			}

			if (DtyDispType6.Text == "2")
			{
				Dty1Num6.OutputFormat = "###0";
				Dty2Num6.OutputFormat = "###0";
				Dty3Num6.OutputFormat = "###0";
				Dty4Num6.OutputFormat = "###0";
				Dty5Num6.OutputFormat = "###0";
				Dty6Num6.OutputFormat = "###0";
				Dty7Num6.OutputFormat = "###0";
				Dty8Num6.OutputFormat = "###0";
				Dty9Num6.OutputFormat = "###0";
				Dty10Num6.OutputFormat = "###0";
				Dty11Num6.OutputFormat = "###0";
				Dty12Num6.OutputFormat = "###0";
				DtyTotal6.OutputFormat = "###0";
			}

			else if (DtyDispType6.Text == "3")
			{
				Dty1Num6.OutputFormat = "#,##0.00";
				Dty2Num6.OutputFormat = "#,##0.00";
				Dty3Num6.OutputFormat = "#,##0.00";
				Dty4Num6.OutputFormat = "#,##0.00";
				Dty5Num6.OutputFormat = "#,##0.00";
				Dty6Num6.OutputFormat = "#,##0.00";
				Dty7Num6.OutputFormat = "#,##0.00";
				Dty8Num6.OutputFormat = "#,##0.00";
				Dty9Num6.OutputFormat = "#,##0.00";
				Dty10Num6.OutputFormat = "#,##0.00";
				Dty11Num6.OutputFormat = "#,##0.00";
				Dty12Num6.OutputFormat = "#,##0.00";
				DtyTotal6.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType6.Text == "4")
			{
				Dty1Num6.OutputFormat = "###0.00";
				Dty2Num6.OutputFormat = "###0.00";
				Dty3Num6.OutputFormat = "###0.00";
				Dty4Num6.OutputFormat = "###0.00";
				Dty5Num6.OutputFormat = "###0.00";
				Dty6Num6.OutputFormat = "###0.00";
				Dty7Num6.OutputFormat = "###0.00";
				Dty8Num6.OutputFormat = "###0.00";
				Dty9Num6.OutputFormat = "###0.00";
				Dty10Num6.OutputFormat = "###0.00";
				Dty11Num6.OutputFormat = "###0.00";
				Dty12Num6.OutputFormat = "###0.00";
				DtyTotal6.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num6.OutputFormat = "#,##0";
				Dty2Num6.OutputFormat = "#,##0";
				Dty3Num6.OutputFormat = "#,##0";
				Dty4Num6.OutputFormat = "#,##0";
				Dty5Num6.OutputFormat = "#,##0";
				Dty6Num6.OutputFormat = "#,##0";
				Dty7Num6.OutputFormat = "#,##0";
				Dty8Num6.OutputFormat = "#,##0";
				Dty9Num6.OutputFormat = "#,##0";
				Dty10Num6.OutputFormat = "#,##0";
				Dty11Num6.OutputFormat = "#,##0";
				Dty12Num6.OutputFormat = "#,##0";
				DtyTotal6.OutputFormat = "#,##0";
			}

			if (DtyDispType7.Text == "2")
			{
				Dty1Num7.OutputFormat = "###0";
				Dty2Num7.OutputFormat = "###0";
				Dty3Num7.OutputFormat = "###0";
				Dty4Num7.OutputFormat = "###0";
				Dty5Num7.OutputFormat = "###0";
				Dty6Num7.OutputFormat = "###0";
				Dty7Num7.OutputFormat = "###0";
				Dty8Num7.OutputFormat = "###0";
				Dty9Num7.OutputFormat = "###0";
				Dty10Num7.OutputFormat = "###0";
				Dty11Num7.OutputFormat = "###0";
				Dty12Num7.OutputFormat = "###0";
				DtyTotal7.OutputFormat = "###0";
			}

			else if (DtyDispType7.Text == "3")
			{
				Dty1Num7.OutputFormat = "#,##0.00";
				Dty2Num7.OutputFormat = "#,##0.00";
				Dty3Num7.OutputFormat = "#,##0.00";
				Dty4Num7.OutputFormat = "#,##0.00";
				Dty5Num7.OutputFormat = "#,##0.00";
				Dty6Num7.OutputFormat = "#,##0.00";
				Dty7Num7.OutputFormat = "#,##0.00";
				Dty8Num7.OutputFormat = "#,##0.00";
				Dty9Num7.OutputFormat = "#,##0.00";
				Dty10Num7.OutputFormat = "#,##0.00";
				Dty11Num7.OutputFormat = "#,##0.00";
				Dty12Num7.OutputFormat = "#,##0.00";
				DtyTotal7.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType7.Text == "4")
			{
				Dty1Num7.OutputFormat = "###0.00";
				Dty2Num7.OutputFormat = "###0.00";
				Dty3Num7.OutputFormat = "###0.00";
				Dty4Num7.OutputFormat = "###0.00";
				Dty5Num7.OutputFormat = "###0.00";
				Dty6Num7.OutputFormat = "###0.00";
				Dty7Num7.OutputFormat = "###0.00";
				Dty8Num7.OutputFormat = "###0.00";
				Dty9Num7.OutputFormat = "###0.00";
				Dty10Num7.OutputFormat = "###0.00";
				Dty11Num7.OutputFormat = "###0.00";
				Dty12Num7.OutputFormat = "###0.00";
				DtyTotal7.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num7.OutputFormat = "#,##0";
				Dty2Num7.OutputFormat = "#,##0";
				Dty3Num7.OutputFormat = "#,##0";
				Dty4Num7.OutputFormat = "#,##0";
				Dty5Num7.OutputFormat = "#,##0";
				Dty6Num7.OutputFormat = "#,##0";
				Dty7Num7.OutputFormat = "#,##0";
				Dty8Num7.OutputFormat = "#,##0";
				Dty9Num7.OutputFormat = "#,##0";
				Dty10Num7.OutputFormat = "#,##0";
				Dty11Num7.OutputFormat = "#,##0";
				Dty12Num7.OutputFormat = "#,##0";
				DtyTotal7.OutputFormat = "#,##0";
			}

			if (DtyDispType8.Text == "2")
			{
				Dty1Num8.OutputFormat = "###0";
				Dty2Num8.OutputFormat = "###0";
				Dty3Num8.OutputFormat = "###0";
				Dty4Num8.OutputFormat = "###0";
				Dty5Num8.OutputFormat = "###0";
				Dty6Num8.OutputFormat = "###0";
				Dty7Num8.OutputFormat = "###0";
				Dty8Num8.OutputFormat = "###0";
				Dty9Num8.OutputFormat = "###0";
				Dty10Num8.OutputFormat = "###0";
				Dty11Num8.OutputFormat = "###0";
				Dty12Num8.OutputFormat = "###0";
				DtyTotal8.OutputFormat = "###0";
			}

			else if (DtyDispType8.Text == "3")
			{
				Dty1Num8.OutputFormat = "#,##0.00";
				Dty2Num8.OutputFormat = "#,##0.00";
				Dty3Num8.OutputFormat = "#,##0.00";
				Dty4Num8.OutputFormat = "#,##0.00";
				Dty5Num8.OutputFormat = "#,##0.00";
				Dty6Num8.OutputFormat = "#,##0.00";
				Dty7Num8.OutputFormat = "#,##0.00";
				Dty8Num8.OutputFormat = "#,##0.00";
				Dty9Num8.OutputFormat = "#,##0.00";
				Dty10Num8.OutputFormat = "#,##0.00";
				Dty11Num8.OutputFormat = "#,##0.00";
				Dty12Num8.OutputFormat = "#,##0.00";
				DtyTotal8.OutputFormat = "#,##0.00";
			}

			else if (DtyDispType8.Text == "4")
			{
				Dty1Num8.OutputFormat = "###0.00";
				Dty2Num8.OutputFormat = "###0.00";
				Dty3Num8.OutputFormat = "###0.00";
				Dty4Num8.OutputFormat = "###0.00";
				Dty5Num8.OutputFormat = "###0.00";
				Dty6Num8.OutputFormat = "###0.00";
				Dty7Num8.OutputFormat = "###0.00";
				Dty8Num8.OutputFormat = "###0.00";
				Dty9Num8.OutputFormat = "###0.00";
				Dty10Num8.OutputFormat = "###0.00";
				Dty11Num8.OutputFormat = "###0.00";
				Dty12Num8.OutputFormat = "###0.00";
				DtyTotal8.OutputFormat = "###0.00";
			}

			else
			{
				Dty1Num8.OutputFormat = "#,##0";
				Dty2Num8.OutputFormat = "#,##0";
				Dty3Num8.OutputFormat = "#,##0";
				Dty4Num8.OutputFormat = "#,##0";
				Dty5Num8.OutputFormat = "#,##0";
				Dty6Num8.OutputFormat = "#,##0";
				Dty7Num8.OutputFormat = "#,##0";
				Dty8Num8.OutputFormat = "#,##0";
				Dty9Num8.OutputFormat = "#,##0";
				Dty10Num8.OutputFormat = "#,##0";
				Dty11Num8.OutputFormat = "#,##0";
				Dty12Num8.OutputFormat = "#,##0";
				DtyTotal8.OutputFormat = "#,##0";
			}

			if (DtyName1.Text == string.Empty)
			{
				Dty1Num1.OutputFormat = string.Empty;
				Dty2Num1.OutputFormat = string.Empty;
				Dty3Num1.OutputFormat = string.Empty;
				Dty4Num1.OutputFormat = string.Empty;
				Dty5Num1.OutputFormat = string.Empty;
				Dty6Num1.OutputFormat = string.Empty;
				Dty7Num1.OutputFormat = string.Empty;
				Dty8Num1.OutputFormat = string.Empty;
				Dty9Num1.OutputFormat = string.Empty;
				Dty10Num1.OutputFormat = string.Empty;
				Dty11Num1.OutputFormat = string.Empty;
				Dty12Num1.OutputFormat = string.Empty;
				DtyTotal1.OutputFormat = string.Empty;

				Dty1Num1.Text = string.Empty;
				Dty2Num1.Text = string.Empty;
				Dty3Num1.Text = string.Empty;
				Dty4Num1.Text = string.Empty;
				Dty5Num1.Text = string.Empty;
				Dty6Num1.Text = string.Empty;
				Dty7Num1.Text = string.Empty;
				Dty8Num1.Text = string.Empty;
				Dty9Num1.Text = string.Empty;
				Dty10Num1.Text = string.Empty;
				Dty11Num1.Text = string.Empty;
				Dty12Num1.Text = string.Empty;
				DtyTotal1.Text = string.Empty;

			}

			if (DtyName2.Text == string.Empty)
			{
				Dty1Num2.OutputFormat = "###";
				Dty2Num2.OutputFormat = "###";
				Dty3Num2.OutputFormat = "###";
				Dty4Num2.OutputFormat = "###";
				Dty5Num2.OutputFormat = "###";
				Dty6Num2.OutputFormat = "###";
				Dty7Num2.OutputFormat = "###";
				Dty8Num2.OutputFormat = "###";
				Dty9Num2.OutputFormat = "###";
				Dty10Num2.OutputFormat = "###";
				Dty11Num2.OutputFormat = "###";
				Dty12Num2.OutputFormat = "###";
				DtyTotal2.OutputFormat = "###";

				Dty1Num2.Text = string.Empty;
				Dty2Num2.Text = string.Empty;
				Dty3Num2.Text = string.Empty;
				Dty4Num2.Text = string.Empty;
				Dty5Num2.Text = string.Empty;
				Dty6Num2.Text = string.Empty;
				Dty7Num2.Text = string.Empty;
				Dty8Num2.Text = string.Empty;
				Dty9Num2.Text = string.Empty;
				Dty10Num2.Text = string.Empty;
				Dty11Num2.Text = string.Empty;
				Dty12Num2.Text = string.Empty;
				DtyTotal2.Text = string.Empty;
			}

			if (DtyName3.Text == string.Empty)
			{
				Dty1Num3.OutputFormat = "###";
				Dty2Num3.OutputFormat = "###";
				Dty3Num3.OutputFormat = "###";
				Dty4Num3.OutputFormat = "###";
				Dty5Num3.OutputFormat = "###";
				Dty6Num3.OutputFormat = "###";
				Dty7Num3.OutputFormat = "###";
				Dty8Num3.OutputFormat = "###";
				Dty9Num3.OutputFormat = "###";
				Dty10Num3.OutputFormat = "###";
				Dty11Num3.OutputFormat = "###";
				Dty12Num3.OutputFormat = "###";
				DtyTotal3.OutputFormat = "###";

				Dty1Num3.Text = string.Empty;
				Dty2Num3.Text = string.Empty;
				Dty3Num3.Text = string.Empty;
				Dty4Num3.Text = string.Empty;
				Dty5Num3.Text = string.Empty;
				Dty6Num3.Text = string.Empty;
				Dty7Num3.Text = string.Empty;
				Dty8Num3.Text = string.Empty;
				Dty9Num3.Text = string.Empty;
				Dty10Num3.Text = string.Empty;
				Dty11Num3.Text = string.Empty;
				Dty12Num3.Text = string.Empty;
				DtyTotal3.Text = string.Empty;
			}

			if (DtyName4.Text == string.Empty)
			{
				Dty1Num4.OutputFormat = "###";
				Dty2Num4.OutputFormat = "###";
				Dty3Num4.OutputFormat = "###";
				Dty4Num4.OutputFormat = "###";
				Dty5Num4.OutputFormat = "###";
				Dty6Num4.OutputFormat = "###";
				Dty7Num4.OutputFormat = "###";
				Dty8Num4.OutputFormat = "###";
				Dty9Num4.OutputFormat = "###";
				Dty10Num4.OutputFormat = "###";
				Dty11Num4.OutputFormat = "###";
				Dty12Num4.OutputFormat = "###";
				DtyTotal4.OutputFormat = "###";

				Dty1Num4.Text = string.Empty;
				Dty2Num4.Text = string.Empty;
				Dty3Num4.Text = string.Empty;
				Dty4Num4.Text = string.Empty;
				Dty5Num4.Text = string.Empty;
				Dty6Num4.Text = string.Empty;
				Dty7Num4.Text = string.Empty;
				Dty8Num4.Text = string.Empty;
				Dty9Num4.Text = string.Empty;
				Dty10Num4.Text = string.Empty;
				Dty11Num4.Text = string.Empty;
				Dty12Num4.Text = string.Empty;
				DtyTotal4.Text = string.Empty;
			}

			if (DtyName5.Text == string.Empty)
			{
				Dty1Num5.OutputFormat = "###";
				Dty2Num5.OutputFormat = "###";
				Dty3Num5.OutputFormat = "###";
				Dty4Num5.OutputFormat = "###";
				Dty5Num5.OutputFormat = "###";
				Dty6Num5.OutputFormat = "###";
				Dty7Num5.OutputFormat = "###";
				Dty8Num5.OutputFormat = "###";
				Dty9Num5.OutputFormat = "###";
				Dty10Num5.OutputFormat = "###";
				Dty11Num5.OutputFormat = "###";
				Dty12Num5.OutputFormat = "###";
				DtyTotal5.OutputFormat = "###";

				Dty1Num5.Text = string.Empty;
				Dty2Num5.Text = string.Empty;
				Dty3Num5.Text = string.Empty;
				Dty4Num5.Text = string.Empty;
				Dty5Num5.Text = string.Empty;
				Dty6Num5.Text = string.Empty;
				Dty7Num5.Text = string.Empty;
				Dty8Num5.Text = string.Empty;
				Dty9Num5.Text = string.Empty;
				Dty10Num5.Text = string.Empty;
				Dty11Num5.Text = string.Empty;
				Dty12Num5.Text = string.Empty;
				DtyTotal5.Text = string.Empty;
			}

			if (DtyName6.Text == string.Empty)
			{
				Dty1Num6.OutputFormat = "###";
				Dty2Num6.OutputFormat = "###";
				Dty3Num6.OutputFormat = "###";
				Dty4Num6.OutputFormat = "###";
				Dty5Num6.OutputFormat = "###";
				Dty6Num6.OutputFormat = "###";
				Dty7Num6.OutputFormat = "###";
				Dty8Num6.OutputFormat = "###";
				Dty9Num6.OutputFormat = "###";
				Dty10Num6.OutputFormat = "###";
				Dty11Num6.OutputFormat = "###";
				Dty12Num6.OutputFormat = "###";
				DtyTotal6.OutputFormat = "###";

				Dty1Num6.Text = string.Empty;
				Dty2Num6.Text = string.Empty;
				Dty3Num6.Text = string.Empty;
				Dty4Num6.Text = string.Empty;
				Dty5Num6.Text = string.Empty;
				Dty6Num6.Text = string.Empty;
				Dty7Num6.Text = string.Empty;
				Dty8Num6.Text = string.Empty;
				Dty9Num6.Text = string.Empty;
				Dty10Num6.Text = string.Empty;
				Dty11Num6.Text = string.Empty;
				Dty12Num6.Text = string.Empty;
				DtyTotal6.Text = string.Empty;
			}

			if (DtyName7.Text == string.Empty)
			{
				Dty1Num7.OutputFormat = "###";
				Dty2Num7.OutputFormat = "###";
				Dty3Num7.OutputFormat = "###";
				Dty4Num7.OutputFormat = "###";
				Dty5Num7.OutputFormat = "###";
				Dty6Num7.OutputFormat = "###";
				Dty7Num7.OutputFormat = "###";
				Dty8Num7.OutputFormat = "###";
				Dty9Num7.OutputFormat = "###";
				Dty10Num7.OutputFormat = "###";
				Dty11Num7.OutputFormat = "###";
				Dty12Num7.OutputFormat = "###";
				DtyTotal7.OutputFormat = "###";

				Dty1Num7.Text = string.Empty;
				Dty2Num7.Text = string.Empty;
				Dty3Num7.Text = string.Empty;
				Dty4Num7.Text = string.Empty;
				Dty5Num7.Text = string.Empty;
				Dty6Num7.Text = string.Empty;
				Dty7Num7.Text = string.Empty;
				Dty8Num7.Text = string.Empty;
				Dty9Num7.Text = string.Empty;
				Dty10Num7.Text = string.Empty;
				Dty11Num7.Text = string.Empty;
				Dty12Num7.Text = string.Empty;
				DtyTotal7.Text = string.Empty;
			}

			if (DtyName8.Text == string.Empty)
			{
				Dty1Num8.OutputFormat = "###";
				Dty2Num8.OutputFormat = "###";
				Dty3Num8.OutputFormat = "###";
				Dty4Num8.OutputFormat = "###";
				Dty5Num8.OutputFormat = "###";
				Dty6Num8.OutputFormat = "###";
				Dty7Num8.OutputFormat = "###";
				Dty8Num8.OutputFormat = "###";
				Dty9Num8.OutputFormat = "###";
				Dty10Num8.OutputFormat = "###";
				Dty11Num8.OutputFormat = "###";
				Dty12Num8.OutputFormat = "###";
				DtyTotal8.OutputFormat = "###";

				Dty1Num8.Text = string.Empty;
				Dty2Num8.Text = string.Empty;
				Dty3Num8.Text = string.Empty;
				Dty4Num8.Text = string.Empty;
				Dty5Num8.Text = string.Empty;
				Dty6Num8.Text = string.Empty;
				Dty7Num8.Text = string.Empty;
				Dty8Num8.Text = string.Empty;
				Dty9Num8.Text = string.Empty;
				Dty10Num8.Text = string.Empty;
				Dty11Num8.Text = string.Empty;
				Dty12Num8.Text = string.Empty;
				DtyTotal8.Text = string.Empty;
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

		private void GroupHeader2_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
			//勤怠の空白処理
			if (((Dty1Num1.Text == "0") || (Dty1Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty1Num1.Text = "";
			}

			if (((Dty1Num2.Text == "0") || (Dty1Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty1Num2.Text = "";
			}

			if (((Dty1Num3.Text == "0") || (Dty1Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty1Num3.Text = "";
			}

			if (((Dty1Num4.Text == "0") || (Dty1Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty1Num4.Text = "";
			}

			if (((Dty1Num5.Text == "0") || (Dty1Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty1Num5.Text = "";
			}

			if (((Dty1Num6.Text == "0") || (Dty1Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty1Num6.Text = "";
			}

			if (((Dty1Num7.Text == "0") || (Dty1Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty1Num7.Text = "";
			}

			if (((Dty1Num8.Text == "0") || (Dty1Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty1Num8.Text = "";
			}

			if (((Dty2Num1.Text == "0") || (Dty2Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty2Num1.Text = "";
			}

			if (((Dty2Num2.Text == "0") || (Dty2Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty2Num2.Text = "";
			}

			if (((Dty2Num3.Text == "0") || (Dty2Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty2Num3.Text = "";
			}

			if (((Dty2Num4.Text == "0") || (Dty2Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty2Num4.Text = "";
			}

			if (((Dty2Num5.Text == "0") || (Dty2Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty2Num5.Text = "";
			}

			if (((Dty2Num6.Text == "0") || (Dty2Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty2Num6.Text = "";
			}

			if (((Dty2Num7.Text == "0") || (Dty2Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty2Num7.Text = "";
			}

			if (((Dty2Num8.Text == "0") || (Dty2Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty2Num8.Text = "";
			}

			if (((Dty3Num1.Text == "0") || (Dty3Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty3Num1.Text = "";
			}

			if (((Dty3Num2.Text == "0") || (Dty3Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty3Num2.Text = "";
			}

			if (((Dty3Num3.Text == "0") || (Dty3Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty3Num3.Text = "";
			}

			if (((Dty3Num4.Text == "0") || (Dty3Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty3Num4.Text = "";
			}

			if (((Dty3Num5.Text == "0") || (Dty3Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty3Num5.Text = "";
			}

			if (((Dty3Num6.Text == "0") || (Dty3Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty3Num6.Text = "";
			}

			if (((Dty3Num7.Text == "0") || (Dty3Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty3Num7.Text = "";
			}

			if (((Dty3Num8.Text == "0") || (Dty3Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty3Num8.Text = "";
			}

			if (((Dty4Num1.Text == "0") || (Dty4Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty4Num1.Text = "";
			}

			if (((Dty4Num2.Text == "0") || (Dty4Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty4Num2.Text = "";
			}

			if (((Dty4Num3.Text == "0") || (Dty4Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty4Num3.Text = "";
			}

			if (((Dty4Num4.Text == "0") || (Dty4Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty4Num4.Text = "";
			}

			if (((Dty4Num5.Text == "0") || (Dty4Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty4Num5.Text = "";
			}

			if (((Dty4Num6.Text == "0") || (Dty4Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty4Num6.Text = "";
			}

			if (((Dty4Num7.Text == "0") || (Dty4Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty4Num7.Text = "";
			}

			if (((Dty4Num8.Text == "0") || (Dty4Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty4Num8.Text = "";
			}

			if (((Dty5Num1.Text == "0") || (Dty5Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty5Num1.Text = "";
			}

			if (((Dty5Num2.Text == "0") || (Dty5Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty5Num2.Text = "";
			}

			if (((Dty5Num3.Text == "0") || (Dty5Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty5Num3.Text = "";
			}

			if (((Dty5Num4.Text == "0") || (Dty5Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty5Num4.Text = "";
			}

			if (((Dty5Num5.Text == "0") || (Dty5Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty5Num5.Text = "";
			}

			if (((Dty5Num6.Text == "0") || (Dty5Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty5Num6.Text = "";
			}

			if (((Dty5Num7.Text == "0") || (Dty5Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty5Num7.Text = "";
			}

			if (((Dty5Num8.Text == "0") || (Dty5Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty5Num8.Text = "";
			}

			if (((Dty6Num1.Text == "0") || (Dty6Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty6Num1.Text = "";
			}

			if (((Dty6Num2.Text == "0") || (Dty6Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty6Num2.Text = "";
			}

			if (((Dty6Num3.Text == "0") || (Dty6Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty6Num3.Text = "";
			}

			if (((Dty6Num4.Text == "0") || (Dty6Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty6Num4.Text = "";
			}

			if (((Dty6Num5.Text == "0") || (Dty6Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty6Num5.Text = "";
			}

			if (((Dty6Num6.Text == "0") || (Dty6Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty6Num6.Text = "";
			}

			if (((Dty6Num7.Text == "0") || (Dty6Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty6Num7.Text = "";
			}

			if (((Dty6Num8.Text == "0") || (Dty6Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty6Num8.Text = "";
			}

			if (((Dty7Num1.Text == "0") || (Dty7Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty7Num1.Text = "";
			}

			if (((Dty7Num2.Text == "0") || (Dty7Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty7Num2.Text = "";
			}

			if (((Dty7Num3.Text == "0") || (Dty7Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty7Num3.Text = "";
			}

			if (((Dty7Num4.Text == "0") || (Dty7Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty7Num4.Text = "";
			}

			if (((Dty7Num5.Text == "0") || (Dty7Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty7Num5.Text = "";
			}

			if (((Dty7Num6.Text == "0") || (Dty7Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty7Num6.Text = "";
			}

			if (((Dty7Num7.Text == "0") || (Dty7Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty7Num7.Text = "";
			}

			if (((Dty7Num8.Text == "0") || (Dty7Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty7Num8.Text = "";
			}

			if (((Dty8Num1.Text == "0") || (Dty8Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty8Num1.Text = "";
			}

			if (((Dty8Num2.Text == "0") || (Dty8Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty8Num2.Text = "";
			}

			if (((Dty8Num3.Text == "0") || (Dty8Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty8Num3.Text = "";
			}

			if (((Dty8Num4.Text == "0") || (Dty8Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty8Num4.Text = "";
			}

			if (((Dty8Num5.Text == "0") || (Dty8Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty8Num5.Text = "";
			}

			if (((Dty8Num6.Text == "0") || (Dty8Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty8Num6.Text = "";
			}

			if (((Dty8Num7.Text == "0") || (Dty8Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty8Num7.Text = "";
			}

			if (((Dty8Num8.Text == "0") || (Dty8Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty8Num8.Text = "";
			}

			if (((Dty9Num1.Text == "0") || (Dty9Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty9Num1.Text = "";
			}

			if (((Dty9Num2.Text == "0") || (Dty9Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty9Num2.Text = "";
			}

			if (((Dty9Num3.Text == "0") || (Dty9Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty9Num3.Text = "";
			}

			if (((Dty9Num4.Text == "0") || (Dty9Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty9Num4.Text = "";
			}

			if (((Dty9Num5.Text == "0") || (Dty9Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty9Num5.Text = "";
			}

			if (((Dty9Num6.Text == "0") || (Dty9Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty9Num6.Text = "";
			}

			if (((Dty9Num7.Text == "0") || (Dty9Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty9Num7.Text = "";
			}

			if (((Dty9Num8.Text == "0") || (Dty9Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty9Num8.Text = "";
			}

			if (((Dty10Num1.Text == "0") || (Dty10Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty10Num1.Text = "";
			}

			if (((Dty10Num2.Text == "0") || (Dty10Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty10Num2.Text = "";
			}

			if (((Dty10Num3.Text == "0") || (Dty10Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty10Num3.Text = "";
			}

			if (((Dty10Num4.Text == "0") || (Dty10Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty10Num4.Text = "";
			}

			if (((Dty10Num5.Text == "0") || (Dty10Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty10Num5.Text = "";
			}

			if (((Dty10Num6.Text == "0") || (Dty10Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty10Num6.Text = "";
			}

			if (((Dty10Num7.Text == "0") || (Dty10Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty10Num7.Text = "";
			}

			if (((Dty10Num8.Text == "0") || (Dty10Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty10Num8.Text = "";
			}

			if (((Dty11Num1.Text == "0") || (Dty11Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty11Num1.Text = "";
			}

			if (((Dty11Num2.Text == "0") || (Dty11Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty11Num2.Text = "";
			}

			if (((Dty11Num3.Text == "0") || (Dty11Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty11Num3.Text = "";
			}

			if (((Dty11Num4.Text == "0") || (Dty11Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty11Num4.Text = "";
			}

			if (((Dty11Num5.Text == "0") || (Dty11Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty11Num5.Text = "";
			}

			if (((Dty11Num6.Text == "0") || (Dty11Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty11Num6.Text = "";
			}

			if (((Dty11Num7.Text == "0") || (Dty11Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty11Num7.Text = "";
			}

			if (((Dty11Num8.Text == "0") || (Dty11Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty11Num8.Text = "";
			}

			if (((Dty12Num1.Text == "0") || (Dty12Num1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				Dty12Num1.Text = "";
			}


			if (((Dty12Num2.Text == "0") || (Dty12Num2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				Dty12Num2.Text = "";
			}

			if (((Dty12Num3.Text == "0") || (Dty12Num3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				Dty12Num3.Text = "";
			}

			if (((Dty12Num4.Text == "0") || (Dty12Num4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				Dty12Num4.Text = "";
			}

			if (((Dty12Num5.Text == "0") || (Dty12Num5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				Dty12Num5.Text = "";
			}

			if (((Dty12Num6.Text == "0") || (Dty12Num6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				Dty12Num6.Text = "";
			}

			if (((Dty12Num7.Text == "0") || (Dty12Num7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				Dty12Num7.Text = "";
			}

			if (((Dty12Num8.Text == "0") || (Dty12Num8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				Dty12Num8.Text = "";
			}

			//勤怠合計の空白処理
			if (((DtyTotal1.Text == "0") || (DtyTotal1.Text == "0.00")) && (DtyZeroFlg1.Text == "0"))
			{
				DtyTotal1.Text = "";
			}
			if ((DtyItemId1.Text == null) || (DtyItemId1.Text == ""))
			{
				DtyTotal1.Text = "";
			}

			if (((DtyTotal2.Text == "0") || (DtyTotal2.Text == "0.00")) && (DtyZeroFlg2.Text == "0"))
			{
				DtyTotal2.Text = "";
			}
			if ((DtyItemId2.Text == null) || (DtyItemId2.Text == ""))
			{
				DtyTotal2.Text = "";
			}

			if (((DtyTotal3.Text == "0") || (DtyTotal3.Text == "0.00")) && (DtyZeroFlg3.Text == "0"))
			{
				DtyTotal3.Text = "";
			}
			if ((DtyItemId3.Text == null) || (DtyItemId3.Text == ""))
			{
				DtyTotal3.Text = "";
			}

			if (((DtyTotal4.Text == "0") || (DtyTotal4.Text == "0.00")) && (DtyZeroFlg4.Text == "0"))
			{
				DtyTotal4.Text = "";
			}
			if ((DtyItemId4.Text == null) || (DtyItemId4.Text == ""))
			{
				DtyTotal4.Text = "";
			}

			if (((DtyTotal5.Text == "0") || (DtyTotal5.Text == "0.00")) && (DtyZeroFlg5.Text == "0"))
			{
				DtyTotal5.Text = "";
			}
			if ((DtyItemId5.Text == null) || (DtyItemId5.Text == ""))
			{
				DtyTotal5.Text = "";
			}

			if (((DtyTotal6.Text == "0") || (DtyTotal6.Text == "0.00")) && (DtyZeroFlg6.Text == "0"))
			{
				DtyTotal6.Text = "";
			}
			if ((DtyItemId6.Text == null) || (DtyItemId6.Text == ""))
			{
				DtyTotal6.Text = "";
			}

			if (((DtyTotal7.Text == "0") || (DtyTotal7.Text == "0.00") || (DtyTotal7.Text == "0.00")) && (DtyZeroFlg7.Text == "0"))
			{
				DtyTotal7.Text = "";
			}
			if ((DtyItemId7.Text == null) || (DtyItemId7.Text == ""))
			{
				DtyTotal7.Text = "";
			}

			if (((DtyTotal8.Text == "0") || (DtyTotal8.Text == "0.00")) && (DtyZeroFlg8.Text == "0"))
			{
				DtyTotal8.Text = "";
			}
			if ((DtyItemId8.Text == null) || (DtyItemId8.Text == ""))
			{
				DtyTotal8.Text = "";
			}

			//普通障害
			//特別障害
			//同居特障の数を普通障害、特別障害から差算する
			TextBox465.Text = (Convert.ToInt32(TextBox465.Text) - Convert.ToInt32(TextBox476.Text)).ToString();
			TextBox466.Text = (Convert.ToInt32(TextBox466.Text) - Convert.ToInt32(TextBox476.Text)).ToString();
			//上記で求めた特別障害の数を普通障害から差算する
			TextBox465.Text = (Convert.ToInt32(TextBox465.Text) - Convert.ToInt32(TextBox466.Text)).ToString();
			TextBox473.Text = TextBox473.Text == "○" & TextBox472.Text != "○" ? TextBox473.Text : string.Empty;

			string slryPaymntYy = ((System.Data.DataRow[])(DataSource))[0]["SLRY_PAYMNT_YY"].ToString();

			// 地震保険料控除対応
			if (slryPaymntYy.Substring(0, 4).CompareTo(TAX_REVISION_YEAR) > 0)
			{
				// コメント欄表示
				Label153.Visible = false;
			}
			else
			{
				Label153.Visible = true;
			}

			// 年少扶養対応（年調年度≧2011年の場合にのみ表示）
			if (slryPaymntYy.Substring(0, 4).CompareTo(H23_TAX_REVISION_YEAR) >= 0)
			{
				// 年少扶養人数表示
				Label156.Visible = true;
				TextBox484.Visible = true;
			}
			else
			{
				Label156.Visible = false;
				TextBox484.Visible = false;
			}

// 管理番号K26643 From
			if (slryPaymntYy.Substring(0, 4).CompareTo(H30_TAX_REVISION_YEAR) >= 0)
			{
				//2018年以降
				// 源泉を表示
				Label1.Visible = true;
				Label60.Top = 4.737F;
				Label137.Top = 4.88F;
				Label140.Top = 4.88F;
				Label141.Top = 4.88F;

				// 配偶老年者を非表示
				Label63.Visible = false;
			}
			else
			{
				//2017年以前
				// 源泉を非表示
				Label1.Visible = false;
				Label60.Top = 4.615F;
				Label137.Top = 4.81F;
				Label140.Top = 4.81F;
				Label141.Top = 4.81F;

				// 配偶老年者を表示
				Label63.Visible = true;
			}
// 管理番号K26643 To
// 管理番号K27274 From
			if (int.Parse(slryPaymntYy.Substring(0, 4)) >= int.Parse(R02_TAX_REVISION_YEAR))
			{
				//2020年以降
				Label73.Text = "ひとり親";
				Label74.Text = "";
			}
			else
			{
				//2019年以前
				Label73.Text = "寡　　夫";
				Label74.Text = "特別寡婦";
			}
// 管理番号K27274 To
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
		private GrapeCity.ActiveReports.SectionReportModel.Line Line267 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line268 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line269 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line270 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line271 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty1Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line278 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line279 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line280 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line281 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line284 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line285 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty2Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line288 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty3Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line290 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty4Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line292 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line293 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line296 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line297 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty5Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line300 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty6Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line302 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty7Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line304 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line305 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label39 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line308 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line309 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line312 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label45 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty9Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line314 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty10Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line316 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line317 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label51 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line320 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line321 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty11Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label54 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty12Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line324 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line326 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line329 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line330 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label57 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyTotal8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label58 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxTypeName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line331 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line332 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line333 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line334 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line335 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line336 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line337 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line338 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label59 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line339 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line340 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line341 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line342 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line343 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line344 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line345 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label60 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line346 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line347 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line348 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line349 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label61 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label62 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label63 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label64 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label65 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line350 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line351 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox462 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox463 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox464 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox465 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox466 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox467 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox468 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line352 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line353 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line354 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label66 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label67 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label68 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line355 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label69 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label70 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label74 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label75 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label76 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox469 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox472 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox473 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox474 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox475 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label77 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label78 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label79 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label80 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line356 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line357 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label81 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label82 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox476 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox477 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox478 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox479 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox480 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox481 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line394 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line395 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line396 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line397 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line398 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line399 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line400 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line401 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label114 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label115 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label116 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label117 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label118 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label119 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label120 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label121 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label124 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label125 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label126 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label127 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line406 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyZeroFlg8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemId7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyDispType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label138 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox672 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox673 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line407 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line408 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dty8Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label142 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label144 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox674 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label152 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_06_R98));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.Label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line266 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line267 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DtyName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line268 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DtyName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line269 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DtyName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line270 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DtyName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line271 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty1Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty1Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line278 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line279 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line280 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line281 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label21 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label24 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line284 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line285 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty2Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty2Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line288 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty3Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label27 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Dty3Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty3Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line290 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty4Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty4Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line292 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line293 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label30 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label33 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line296 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line297 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty5Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty5Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line300 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty6Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Dty6Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty6Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line302 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty7Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty7Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line304 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line305 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label39 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label42 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line308 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line309 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty8Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty8Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty8Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty8Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty8Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty8Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line312 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty9Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Dty8Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty9Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line314 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty10Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty10Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line316 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line317 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label51 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line320 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line321 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty11Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty11Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label54 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Dty12Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dty12Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line324 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line326 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line329 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line330 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label57 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DtyTotal1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyTotal8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label58 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TaxTypeName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line331 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line332 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line333 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line334 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line335 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line336 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line337 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line338 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label59 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line339 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line340 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line341 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line342 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line343 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line344 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line345 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label60 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line346 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line347 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line348 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line349 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label61 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label62 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label63 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label64 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label65 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line350 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line351 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TextBox462 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox463 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox464 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox465 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox466 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox467 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox468 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line352 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line353 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line354 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label66 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label67 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label68 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line355 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label69 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label70 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label73 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label74 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label75 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label76 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox469 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox472 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox473 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox474 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox475 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label77 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label78 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label79 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label80 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line356 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line357 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label81 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label82 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox476 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox477 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox478 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox479 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox480 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox481 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line394 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line395 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line396 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line397 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line398 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line399 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line400 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line401 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label114 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label115 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label116 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label117 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label118 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label119 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label120 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label121 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label122 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label124 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label125 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label126 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label127 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line406 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DtyZeroFlg1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyZeroFlg8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemId7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyDispType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label138 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox672 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox673 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line407 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line408 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dty8Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox674 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label149 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label152 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label153 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label156 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox484 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.Label9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxTypeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox462)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox463)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox464)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox465)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox466)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox467)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox468)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox469)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox472)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox473)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox474)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox475)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label82)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox476)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox477)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox478)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox479)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox480)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox481)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label116)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label117)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label118)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label119)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label120)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label121)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label138)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox672)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox673)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox674)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label156)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox484)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label9,
            this.Line266,
            this.Line267,
            this.DtyName1,
            this.DtyName5,
            this.Line268,
            this.DtyName2,
            this.DtyName6,
            this.Line269,
            this.DtyName3,
            this.DtyName7,
            this.Line270,
            this.DtyName4,
            this.DtyName8,
            this.Line271,
            this.Dty1Num1,
            this.Dty1Num5,
            this.Dty1Num2,
            this.Dty1Num6,
            this.Dty1Num3,
            this.Dty1Num7,
            this.Dty1Num4,
            this.Dty1Num8,
            this.Line278,
            this.Line279,
            this.Line280,
            this.Line281,
            this.Label21,
            this.Label24,
            this.Line284,
            this.Line285,
            this.Dty2Num1,
            this.Dty2Num5,
            this.Dty2Num2,
            this.Dty2Num6,
            this.Dty2Num3,
            this.Dty2Num7,
            this.Dty2Num4,
            this.Dty2Num8,
            this.Line288,
            this.Dty3Num5,
            this.Dty3Num6,
            this.Dty3Num7,
            this.Dty3Num8,
            this.Label27,
            this.Dty3Num1,
            this.Dty3Num2,
            this.Dty3Num3,
            this.Dty3Num4,
            this.Line290,
            this.Dty4Num1,
            this.Dty4Num5,
            this.Dty4Num2,
            this.Dty4Num6,
            this.Dty4Num3,
            this.Dty4Num7,
            this.Dty4Num4,
            this.Dty4Num8,
            this.Line292,
            this.Line293,
            this.Label30,
            this.Label33,
            this.Line296,
            this.Line297,
            this.Dty5Num1,
            this.Dty5Num5,
            this.Dty5Num2,
            this.Dty5Num6,
            this.Dty5Num3,
            this.Dty5Num7,
            this.Dty5Num4,
            this.Dty5Num8,
            this.Line300,
            this.Dty6Num5,
            this.Dty6Num6,
            this.Dty6Num7,
            this.Dty6Num8,
            this.Label36,
            this.Dty6Num1,
            this.Dty6Num2,
            this.Dty6Num3,
            this.Dty6Num4,
            this.Line302,
            this.Dty7Num1,
            this.Dty7Num5,
            this.Dty7Num2,
            this.Dty7Num6,
            this.Dty7Num3,
            this.Dty7Num7,
            this.Dty7Num4,
            this.Dty7Num8,
            this.Line304,
            this.Line305,
            this.Label39,
            this.Label42,
            this.Line308,
            this.Line309,
            this.Dty8Num1,
            this.Dty9Num1,
            this.Dty8Num6,
            this.Dty8Num3,
            this.Dty8Num7,
            this.Dty8Num4,
            this.Dty8Num8,
            this.Line312,
            this.Dty9Num5,
            this.Dty9Num6,
            this.Dty9Num7,
            this.Dty9Num8,
            this.Label45,
            this.Dty8Num5,
            this.Dty9Num2,
            this.Dty9Num3,
            this.Dty9Num4,
            this.Line314,
            this.Dty10Num1,
            this.Dty10Num5,
            this.Dty10Num2,
            this.Dty10Num6,
            this.Dty10Num3,
            this.Dty10Num7,
            this.Dty10Num4,
            this.Dty10Num8,
            this.Line316,
            this.Line317,
            this.Label48,
            this.Label51,
            this.Line320,
            this.Line321,
            this.Dty11Num1,
            this.Dty11Num5,
            this.Dty11Num2,
            this.Dty11Num6,
            this.Dty11Num3,
            this.Dty11Num7,
            this.Dty11Num4,
            this.Dty11Num8,
            this.Dty12Num5,
            this.Dty12Num6,
            this.Dty12Num7,
            this.Dty12Num8,
            this.Label54,
            this.Dty12Num1,
            this.Dty12Num2,
            this.Dty12Num3,
            this.Dty12Num4,
            this.Line324,
            this.Line326,
            this.Line329,
            this.Line330,
            this.Label57,
            this.DtyTotal1,
            this.DtyTotal5,
            this.DtyTotal2,
            this.DtyTotal6,
            this.DtyTotal3,
            this.DtyTotal7,
            this.DtyTotal4,
            this.DtyTotal8,
            this.Label58,
            this.TaxTypeName,
            this.Line331,
            this.Line332,
            this.Line333,
            this.Line334,
            this.Line335,
            this.Line336,
            this.Line337,
            this.Line338,
            this.Label59,
            this.Line339,
            this.Line340,
            this.Line341,
            this.Line342,
            this.Line343,
            this.Line344,
            this.Line345,
            this.Label60,
            this.Line346,
            this.Line347,
            this.Line348,
            this.Line349,
            this.Label61,
            this.Label62,
            this.Label63,
            this.Label64,
            this.Label65,
            this.Line350,
            this.Line351,
            this.TextBox462,
            this.TextBox463,
            this.TextBox464,
            this.TextBox465,
            this.TextBox466,
            this.TextBox467,
            this.TextBox468,
            this.Line352,
            this.Line353,
            this.Line354,
            this.Label66,
            this.Label67,
            this.Label68,
            this.Line355,
            this.Label69,
            this.Label70,
            this.Label73,
            this.Label74,
            this.Label75,
            this.Label76,
            this.TextBox469,
            this.TextBox472,
            this.TextBox473,
            this.TextBox474,
            this.TextBox475,
            this.Label77,
            this.Label78,
            this.Label79,
            this.Label80,
            this.Line356,
            this.Line357,
            this.Label81,
            this.Label82,
            this.TextBox476,
            this.TextBox477,
            this.TextBox478,
            this.TextBox479,
            this.TextBox480,
            this.TextBox481,
            this.Line394,
            this.Line395,
            this.Line396,
            this.Line397,
            this.Line398,
            this.Line399,
            this.Line400,
            this.Line401,
            this.Label114,
            this.Label115,
            this.Label116,
            this.Label117,
            this.Label118,
            this.Label119,
            this.Label120,
            this.Label121,
            this.Label122,
            this.Label123,
            this.Label124,
            this.Label125,
            this.Label126,
            this.Label127,
            this.Line406,
            this.Label137,
            this.DtyZeroFlg1,
            this.DtyZeroFlg2,
            this.DtyZeroFlg3,
            this.DtyZeroFlg4,
            this.DtyZeroFlg5,
            this.DtyZeroFlg6,
            this.DtyZeroFlg7,
            this.DtyZeroFlg8,
            this.DtyItemId1,
            this.DtyItemId5,
            this.DtyItemId6,
            this.DtyItemId2,
            this.DtyItemId8,
            this.DtyItemId4,
            this.DtyItemId3,
            this.DtyItemId7,
            this.DtyDispType1,
            this.DtyDispType5,
            this.DtyDispType2,
            this.DtyDispType6,
            this.DtyDispType3,
            this.DtyDispType4,
            this.DtyDispType7,
            this.DtyDispType8,
            this.Label138,
            this.Label139,
            this.TextBox672,
            this.TextBox673,
            this.Line407,
            this.Line408,
            this.Dty8Num2,
            this.Label140,
            this.Label141,
            this.Label142,
            this.Label143,
            this.Label144,
            this.TextBox674,
            this.Label148,
            this.Label149,
            this.Label150,
            this.Label151,
            this.Label152,
            this.Label147,
            this.Label153,
            this.Label156,
            this.TextBox484,
            this.Label1});
			this.Detail.Height = 6.957639F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// Label9
			// 
			this.Label9.Height = 0.286F;
			this.Label9.HyperLink = null;
			this.Label9.Left = 0.06299973F;
			this.Label9.Name = "Label9";
			this.Label9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label9.Text = "勤怠";
			this.Label9.Top = 0.01800001F;
			this.Label9.Width = 0.253F;
			// 
			// Line266
			// 
			this.Line266.Height = 4.004F;
			this.Line266.Left = 0.06550026F;
			this.Line266.LineWeight = 1F;
			this.Line266.Name = "Line266";
			this.Line266.Top = 0.01800001F;
			this.Line266.Width = 0F;
			this.Line266.X1 = 0.06550026F;
			this.Line266.X2 = 0.06550026F;
			this.Line266.Y1 = 0.01800001F;
			this.Line266.Y2 = 4.022F;
			// 
			// Line267
			// 
			this.Line267.Height = 4.022F;
			this.Line267.Left = 0.3155003F;
			this.Line267.LineWeight = 1F;
			this.Line267.Name = "Line267";
			this.Line267.Top = 0F;
			this.Line267.Width = 0F;
			this.Line267.X1 = 0.3155003F;
			this.Line267.X2 = 0.3155003F;
			this.Line267.Y1 = 0F;
			this.Line267.Y2 = 4.022F;
			// 
			// DtyName1
			// 
			this.DtyName1.DataField = "DTY_NAME1";
			this.DtyName1.Height = 0.143F;
			this.DtyName1.Left = 0.3149996F;
			this.DtyName1.Name = "DtyName1";
			this.DtyName1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName1.Text = "あいうえ";
			this.DtyName1.Top = 0.01800001F;
			this.DtyName1.Width = 0.5625F;
			// 
			// DtyName5
			// 
			this.DtyName5.DataField = "DTY_NAME5";
			this.DtyName5.Height = 0.143F;
			this.DtyName5.Left = 0.3149996F;
			this.DtyName5.Name = "DtyName5";
			this.DtyName5.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName5.Text = "あいうえ";
			this.DtyName5.Top = 0.161F;
			this.DtyName5.Width = 0.5625F;
			// 
			// Line268
			// 
			this.Line268.Height = 4.004F;
			this.Line268.Left = 0.8780003F;
			this.Line268.LineWeight = 1F;
			this.Line268.Name = "Line268";
			this.Line268.Top = 0.01800001F;
			this.Line268.Width = 0F;
			this.Line268.X1 = 0.8780003F;
			this.Line268.X2 = 0.8780003F;
			this.Line268.Y1 = 0.01800001F;
			this.Line268.Y2 = 4.022F;
			// 
			// DtyName2
			// 
			this.DtyName2.DataField = "DTY_NAME2";
			this.DtyName2.Height = 0.143F;
			this.DtyName2.Left = 0.8774996F;
			this.DtyName2.Name = "DtyName2";
			this.DtyName2.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName2.Text = "あいうえ";
			this.DtyName2.Top = 0.01800001F;
			this.DtyName2.Width = 0.5625F;
			// 
			// DtyName6
			// 
			this.DtyName6.DataField = "DTY_NAME6";
			this.DtyName6.Height = 0.143F;
			this.DtyName6.Left = 0.8774996F;
			this.DtyName6.Name = "DtyName6";
			this.DtyName6.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName6.Text = "あいうえ";
			this.DtyName6.Top = 0.161F;
			this.DtyName6.Width = 0.5625F;
			// 
			// Line269
			// 
			this.Line269.Height = 4.004F;
			this.Line269.Left = 1.4405F;
			this.Line269.LineWeight = 1F;
			this.Line269.Name = "Line269";
			this.Line269.Top = 0.01800001F;
			this.Line269.Width = 0F;
			this.Line269.X1 = 1.4405F;
			this.Line269.X2 = 1.4405F;
			this.Line269.Y1 = 0.01800001F;
			this.Line269.Y2 = 4.022F;
			// 
			// DtyName3
			// 
			this.DtyName3.CanGrow = false;
			this.DtyName3.DataField = "DTY_NAME3";
			this.DtyName3.Height = 0.143F;
			this.DtyName3.Left = 1.44F;
			this.DtyName3.Name = "DtyName3";
			this.DtyName3.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.DtyName3.Text = "あいうえ";
			this.DtyName3.Top = 0.01800001F;
			this.DtyName3.Width = 0.5625F;
			// 
			// DtyName7
			// 
			this.DtyName7.DataField = "DTY_NAME7";
			this.DtyName7.Height = 0.143F;
			this.DtyName7.Left = 1.44F;
			this.DtyName7.Name = "DtyName7";
			this.DtyName7.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName7.Text = "あいうえ";
			this.DtyName7.Top = 0.161F;
			this.DtyName7.Width = 0.5625F;
			// 
			// Line270
			// 
			this.Line270.Height = 4.004F;
			this.Line270.Left = 2.003F;
			this.Line270.LineWeight = 1F;
			this.Line270.Name = "Line270";
			this.Line270.Top = 0.01800001F;
			this.Line270.Width = 0F;
			this.Line270.X1 = 2.003F;
			this.Line270.X2 = 2.003F;
			this.Line270.Y1 = 0.01800001F;
			this.Line270.Y2 = 4.022F;
			// 
			// DtyName4
			// 
			this.DtyName4.DataField = "DTY_NAME4";
			this.DtyName4.Height = 0.143F;
			this.DtyName4.Left = 2.0025F;
			this.DtyName4.Name = "DtyName4";
			this.DtyName4.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName4.Text = "あいうえお";
			this.DtyName4.Top = 0.01800001F;
			this.DtyName4.Width = 0.5625F;
			// 
			// DtyName8
			// 
			this.DtyName8.DataField = "DTY_NAME8";
			this.DtyName8.Height = 0.143F;
			this.DtyName8.Left = 2.0025F;
			this.DtyName8.Name = "DtyName8";
			this.DtyName8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DtyName8.Text = "あいうえ";
			this.DtyName8.Top = 0.161F;
			this.DtyName8.Width = 0.5625F;
			// 
			// Line271
			// 
			this.Line271.Height = 4.022F;
			this.Line271.Left = 2.5655F;
			this.Line271.LineWeight = 1F;
			this.Line271.Name = "Line271";
			this.Line271.Top = 0F;
			this.Line271.Width = 0F;
			this.Line271.X1 = 2.5655F;
			this.Line271.X2 = 2.5655F;
			this.Line271.Y1 = 0F;
			this.Line271.Y2 = 4.022F;
			// 
			// Dty1Num1
			// 
			this.Dty1Num1.DataField = "DTY_1NUM1";
			this.Dty1Num1.Height = 0.143F;
			this.Dty1Num1.Left = 0.3149996F;
			this.Dty1Num1.Name = "Dty1Num1";
			this.Dty1Num1.OutputFormat = "#,##0.00";
			this.Dty1Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num1.Text = "ZZZ6.66";
			this.Dty1Num1.Top = 0.3040001F;
			this.Dty1Num1.Width = 0.5625F;
			// 
			// Dty1Num5
			// 
			this.Dty1Num5.DataField = "DTY_1NUM5";
			this.Dty1Num5.Height = 0.143F;
			this.Dty1Num5.Left = 0.3149996F;
			this.Dty1Num5.Name = "Dty1Num5";
			this.Dty1Num5.OutputFormat = "#,##0.00";
			this.Dty1Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num5.Text = "ZZZ6.66";
			this.Dty1Num5.Top = 0.447F;
			this.Dty1Num5.Width = 0.5625F;
			// 
			// Dty1Num2
			// 
			this.Dty1Num2.DataField = "DTY_1NUM2";
			this.Dty1Num2.Height = 0.143F;
			this.Dty1Num2.Left = 0.8774996F;
			this.Dty1Num2.Name = "Dty1Num2";
			this.Dty1Num2.OutputFormat = "#,##0.00";
			this.Dty1Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num2.Text = "ZZZ6.66";
			this.Dty1Num2.Top = 0.3040001F;
			this.Dty1Num2.Width = 0.5625F;
			// 
			// Dty1Num6
			// 
			this.Dty1Num6.DataField = "DTY_1NUM6";
			this.Dty1Num6.Height = 0.143F;
			this.Dty1Num6.Left = 0.8774996F;
			this.Dty1Num6.Name = "Dty1Num6";
			this.Dty1Num6.OutputFormat = "#,##0.00";
			this.Dty1Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num6.Text = "ZZZ6.66";
			this.Dty1Num6.Top = 0.447F;
			this.Dty1Num6.Width = 0.5625F;
			// 
			// Dty1Num3
			// 
			this.Dty1Num3.DataField = "DTY_1NUM3";
			this.Dty1Num3.Height = 0.143F;
			this.Dty1Num3.Left = 1.44F;
			this.Dty1Num3.Name = "Dty1Num3";
			this.Dty1Num3.OutputFormat = "#,##0.00";
			this.Dty1Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num3.Text = "ZZZ6.66";
			this.Dty1Num3.Top = 0.2945F;
			this.Dty1Num3.Width = 0.5625F;
			// 
			// Dty1Num7
			// 
			this.Dty1Num7.DataField = "DTY_1NUM7";
			this.Dty1Num7.Height = 0.143F;
			this.Dty1Num7.Left = 1.44F;
			this.Dty1Num7.Name = "Dty1Num7";
			this.Dty1Num7.OutputFormat = "#,##0.00";
			this.Dty1Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num7.Text = "ZZZ6.66";
			this.Dty1Num7.Top = 0.447F;
			this.Dty1Num7.Width = 0.5625F;
			// 
			// Dty1Num4
			// 
			this.Dty1Num4.DataField = "DTY_1NUM4";
			this.Dty1Num4.Height = 0.143F;
			this.Dty1Num4.Left = 2.0025F;
			this.Dty1Num4.Name = "Dty1Num4";
			this.Dty1Num4.OutputFormat = "#,##0.00";
			this.Dty1Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num4.Text = "ZZZ6.66";
			this.Dty1Num4.Top = 0.3040001F;
			this.Dty1Num4.Width = 0.5625F;
			// 
			// Dty1Num8
			// 
			this.Dty1Num8.DataField = "DTY_1NUM8";
			this.Dty1Num8.Height = 0.143F;
			this.Dty1Num8.Left = 2.0025F;
			this.Dty1Num8.Name = "Dty1Num8";
			this.Dty1Num8.OutputFormat = "#,##0.00";
			this.Dty1Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty1Num8.Text = "ZZZ6.66";
			this.Dty1Num8.Top = 0.447F;
			this.Dty1Num8.Width = 0.5625F;
			// 
			// Line278
			// 
			this.Line278.Height = 0F;
			this.Line278.Left = 0.3149996F;
			this.Line278.LineWeight = 1F;
			this.Line278.Name = "Line278";
			this.Line278.Top = 0.161F;
			this.Line278.Width = 2.251F;
			this.Line278.X1 = 0.3149996F;
			this.Line278.X2 = 2.566F;
			this.Line278.Y1 = 0.161F;
			this.Line278.Y2 = 0.161F;
			// 
			// Line279
			// 
			this.Line279.Height = 0F;
			this.Line279.Left = 0.06599998F;
			this.Line279.LineWeight = 1F;
			this.Line279.Name = "Line279";
			this.Line279.Top = 0.3040001F;
			this.Line279.Width = 2.5F;
			this.Line279.X1 = 0.06599998F;
			this.Line279.X2 = 2.566F;
			this.Line279.Y1 = 0.3040001F;
			this.Line279.Y2 = 0.3040001F;
			// 
			// Line280
			// 
			this.Line280.Height = 0F;
			this.Line280.Left = 0.3149996F;
			this.Line280.LineWeight = 1F;
			this.Line280.Name = "Line280";
			this.Line280.Top = 0.447F;
			this.Line280.Width = 2.251F;
			this.Line280.X1 = 0.3149996F;
			this.Line280.X2 = 2.566F;
			this.Line280.Y1 = 0.447F;
			this.Line280.Y2 = 0.447F;
			// 
			// Line281
			// 
			this.Line281.Height = 0F;
			this.Line281.Left = 0.06599998F;
			this.Line281.LineWeight = 1F;
			this.Line281.Name = "Line281";
			this.Line281.Top = 0.59F;
			this.Line281.Width = 2.5F;
			this.Line281.X1 = 0.06599998F;
			this.Line281.X2 = 2.566F;
			this.Line281.Y1 = 0.59F;
			this.Line281.Y2 = 0.59F;
			// 
			// Label21
			// 
			this.Label21.Height = 0.286F;
			this.Label21.HyperLink = null;
			this.Label21.Left = 0.06299973F;
			this.Label21.Name = "Label21";
			this.Label21.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label21.Text = "1";
			this.Label21.Top = 0.3040001F;
			this.Label21.Width = 0.253F;
			// 
			// Label24
			// 
			this.Label24.Height = 0.286F;
			this.Label24.HyperLink = null;
			this.Label24.Left = 0.06599998F;
			this.Label24.Name = "Label24";
			this.Label24.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label24.Text = "2";
			this.Label24.Top = 0.59F;
			this.Label24.Width = 0.253F;
			// 
			// Line284
			// 
			this.Line284.Height = 0F;
			this.Line284.Left = 0.06599998F;
			this.Line284.LineWeight = 1F;
			this.Line284.Name = "Line284";
			this.Line284.Top = 0.876F;
			this.Line284.Width = 2.5F;
			this.Line284.X1 = 0.06599998F;
			this.Line284.X2 = 2.566F;
			this.Line284.Y1 = 0.876F;
			this.Line284.Y2 = 0.876F;
			// 
			// Line285
			// 
			this.Line285.Height = 0F;
			this.Line285.Left = 0.3149996F;
			this.Line285.LineWeight = 1F;
			this.Line285.Name = "Line285";
			this.Line285.Top = 0.733F;
			this.Line285.Width = 2.251F;
			this.Line285.X1 = 0.3149996F;
			this.Line285.X2 = 2.566F;
			this.Line285.Y1 = 0.733F;
			this.Line285.Y2 = 0.733F;
			// 
			// Dty2Num1
			// 
			this.Dty2Num1.DataField = "DTY_2NUM1";
			this.Dty2Num1.Height = 0.143F;
			this.Dty2Num1.Left = 0.3149996F;
			this.Dty2Num1.Name = "Dty2Num1";
			this.Dty2Num1.OutputFormat = "#,##0.00";
			this.Dty2Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num1.Text = "ZZZ6.66";
			this.Dty2Num1.Top = 0.59F;
			this.Dty2Num1.Width = 0.5625F;
			// 
			// Dty2Num5
			// 
			this.Dty2Num5.DataField = "DTY_2NUM5";
			this.Dty2Num5.Height = 0.143F;
			this.Dty2Num5.Left = 0.3149996F;
			this.Dty2Num5.Name = "Dty2Num5";
			this.Dty2Num5.OutputFormat = "#,##0.00";
			this.Dty2Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num5.Text = "ZZZ6.66";
			this.Dty2Num5.Top = 0.733F;
			this.Dty2Num5.Width = 0.5625F;
			// 
			// Dty2Num2
			// 
			this.Dty2Num2.DataField = "DTY_2NUM2";
			this.Dty2Num2.Height = 0.143F;
			this.Dty2Num2.Left = 0.8774996F;
			this.Dty2Num2.Name = "Dty2Num2";
			this.Dty2Num2.OutputFormat = "#,##0.00";
			this.Dty2Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num2.Text = "ZZZ6.66";
			this.Dty2Num2.Top = 0.59F;
			this.Dty2Num2.Width = 0.5625F;
			// 
			// Dty2Num6
			// 
			this.Dty2Num6.DataField = "DTY_2NUM6";
			this.Dty2Num6.Height = 0.143F;
			this.Dty2Num6.Left = 0.8774996F;
			this.Dty2Num6.Name = "Dty2Num6";
			this.Dty2Num6.OutputFormat = "#,##0.00";
			this.Dty2Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num6.Text = "ZZZ6.66";
			this.Dty2Num6.Top = 0.733F;
			this.Dty2Num6.Width = 0.5625F;
			// 
			// Dty2Num3
			// 
			this.Dty2Num3.DataField = "DTY_2NUM3";
			this.Dty2Num3.Height = 0.143F;
			this.Dty2Num3.Left = 1.44F;
			this.Dty2Num3.Name = "Dty2Num3";
			this.Dty2Num3.OutputFormat = "#,##0.00";
			this.Dty2Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num3.Text = "ZZZ6.66";
			this.Dty2Num3.Top = 0.59F;
			this.Dty2Num3.Width = 0.5625F;
			// 
			// Dty2Num7
			// 
			this.Dty2Num7.DataField = "DTY_2NUM7";
			this.Dty2Num7.Height = 0.143F;
			this.Dty2Num7.Left = 1.44F;
			this.Dty2Num7.Name = "Dty2Num7";
			this.Dty2Num7.OutputFormat = "#,##0.00";
			this.Dty2Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num7.Text = "ZZZ6.66";
			this.Dty2Num7.Top = 0.733F;
			this.Dty2Num7.Width = 0.5625F;
			// 
			// Dty2Num4
			// 
			this.Dty2Num4.DataField = "DTY_2NUM4";
			this.Dty2Num4.Height = 0.143F;
			this.Dty2Num4.Left = 2.0025F;
			this.Dty2Num4.Name = "Dty2Num4";
			this.Dty2Num4.OutputFormat = "#,##0.00";
			this.Dty2Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num4.Text = "ZZZ6.66";
			this.Dty2Num4.Top = 0.59F;
			this.Dty2Num4.Width = 0.5625F;
			// 
			// Dty2Num8
			// 
			this.Dty2Num8.DataField = "DTY_2NUM8";
			this.Dty2Num8.Height = 0.143F;
			this.Dty2Num8.Left = 2.0025F;
			this.Dty2Num8.Name = "Dty2Num8";
			this.Dty2Num8.OutputFormat = "#,##0.00";
			this.Dty2Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty2Num8.Text = "ZZZ6.66";
			this.Dty2Num8.Top = 0.733F;
			this.Dty2Num8.Width = 0.5625F;
			// 
			// Line288
			// 
			this.Line288.Height = 0F;
			this.Line288.Left = 0.06599998F;
			this.Line288.LineWeight = 1F;
			this.Line288.Name = "Line288";
			this.Line288.Top = 1.162F;
			this.Line288.Width = 2.5F;
			this.Line288.X1 = 0.06599998F;
			this.Line288.X2 = 2.566F;
			this.Line288.Y1 = 1.162F;
			this.Line288.Y2 = 1.162F;
			// 
			// Dty3Num5
			// 
			this.Dty3Num5.DataField = "DTY_3NUM5";
			this.Dty3Num5.Height = 0.143F;
			this.Dty3Num5.Left = 0.3149996F;
			this.Dty3Num5.Name = "Dty3Num5";
			this.Dty3Num5.OutputFormat = "#,##0.00";
			this.Dty3Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num5.Text = "ZZZ6.66";
			this.Dty3Num5.Top = 1.019F;
			this.Dty3Num5.Width = 0.5625F;
			// 
			// Dty3Num6
			// 
			this.Dty3Num6.DataField = "DTY_3NUM6";
			this.Dty3Num6.Height = 0.143F;
			this.Dty3Num6.Left = 0.8774996F;
			this.Dty3Num6.Name = "Dty3Num6";
			this.Dty3Num6.OutputFormat = "#,##0.00";
			this.Dty3Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num6.Text = "ZZZ6.66";
			this.Dty3Num6.Top = 1.019F;
			this.Dty3Num6.Width = 0.5625F;
			// 
			// Dty3Num7
			// 
			this.Dty3Num7.DataField = "DTY_3NUM7";
			this.Dty3Num7.Height = 0.143F;
			this.Dty3Num7.Left = 1.44F;
			this.Dty3Num7.Name = "Dty3Num7";
			this.Dty3Num7.OutputFormat = "#,##0.00";
			this.Dty3Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num7.Text = "ZZZ6.66";
			this.Dty3Num7.Top = 1.019F;
			this.Dty3Num7.Width = 0.5625F;
			// 
			// Dty3Num8
			// 
			this.Dty3Num8.DataField = "DTY_3NUM8";
			this.Dty3Num8.Height = 0.143F;
			this.Dty3Num8.Left = 2.0025F;
			this.Dty3Num8.Name = "Dty3Num8";
			this.Dty3Num8.OutputFormat = "#,##0.00";
			this.Dty3Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num8.Text = "ZZZ6.66";
			this.Dty3Num8.Top = 1.019F;
			this.Dty3Num8.Width = 0.5625F;
			// 
			// Label27
			// 
			this.Label27.Height = 0.286F;
			this.Label27.HyperLink = null;
			this.Label27.Left = 0.06599998F;
			this.Label27.Name = "Label27";
			this.Label27.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label27.Text = "3";
			this.Label27.Top = 0.876F;
			this.Label27.Width = 0.253F;
			// 
			// Dty3Num1
			// 
			this.Dty3Num1.DataField = "DTY_3NUM1";
			this.Dty3Num1.Height = 0.143F;
			this.Dty3Num1.Left = 0.3149996F;
			this.Dty3Num1.Name = "Dty3Num1";
			this.Dty3Num1.OutputFormat = "#,##0.00";
			this.Dty3Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num1.Text = "ZZZ6.66";
			this.Dty3Num1.Top = 0.876F;
			this.Dty3Num1.Width = 0.5625F;
			// 
			// Dty3Num2
			// 
			this.Dty3Num2.DataField = "DTY_3NUM2";
			this.Dty3Num2.Height = 0.143F;
			this.Dty3Num2.Left = 0.8774996F;
			this.Dty3Num2.Name = "Dty3Num2";
			this.Dty3Num2.OutputFormat = "#,##0.00";
			this.Dty3Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num2.Text = "ZZZ6.66";
			this.Dty3Num2.Top = 0.876F;
			this.Dty3Num2.Width = 0.5625F;
			// 
			// Dty3Num3
			// 
			this.Dty3Num3.DataField = "DTY_3NUM3";
			this.Dty3Num3.Height = 0.143F;
			this.Dty3Num3.Left = 1.44F;
			this.Dty3Num3.Name = "Dty3Num3";
			this.Dty3Num3.OutputFormat = "#,##0.00";
			this.Dty3Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num3.Text = "ZZZ6.66";
			this.Dty3Num3.Top = 0.876F;
			this.Dty3Num3.Width = 0.5625F;
			// 
			// Dty3Num4
			// 
			this.Dty3Num4.DataField = "DTY_3NUM4";
			this.Dty3Num4.Height = 0.143F;
			this.Dty3Num4.Left = 2.0025F;
			this.Dty3Num4.Name = "Dty3Num4";
			this.Dty3Num4.OutputFormat = "#,##0.00";
			this.Dty3Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty3Num4.Text = "ZZZ6.66";
			this.Dty3Num4.Top = 0.876F;
			this.Dty3Num4.Width = 0.5625F;
			// 
			// Line290
			// 
			this.Line290.Height = 0F;
			this.Line290.Left = 0.3149996F;
			this.Line290.LineWeight = 1F;
			this.Line290.Name = "Line290";
			this.Line290.Top = 1.019F;
			this.Line290.Width = 2.251F;
			this.Line290.X1 = 0.3149996F;
			this.Line290.X2 = 2.566F;
			this.Line290.Y1 = 1.019F;
			this.Line290.Y2 = 1.019F;
			// 
			// Dty4Num1
			// 
			this.Dty4Num1.DataField = "DTY_4NUM1";
			this.Dty4Num1.Height = 0.143F;
			this.Dty4Num1.Left = 0.3149996F;
			this.Dty4Num1.Name = "Dty4Num1";
			this.Dty4Num1.OutputFormat = "#,##0.00";
			this.Dty4Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Dty4Num1.Text = "ZZZ6.66";
			this.Dty4Num1.Top = 1.162F;
			this.Dty4Num1.Width = 0.5625F;
			// 
			// Dty4Num5
			// 
			this.Dty4Num5.DataField = "DTY_4NUM5";
			this.Dty4Num5.Height = 0.143F;
			this.Dty4Num5.Left = 0.3149996F;
			this.Dty4Num5.Name = "Dty4Num5";
			this.Dty4Num5.OutputFormat = "#,##0.00";
			this.Dty4Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty4Num5.Text = "ZZZ6.66";
			this.Dty4Num5.Top = 1.305F;
			this.Dty4Num5.Width = 0.5625F;
			// 
			// Dty4Num2
			// 
			this.Dty4Num2.DataField = "DTY_4NUM2";
			this.Dty4Num2.Height = 0.143F;
			this.Dty4Num2.Left = 0.8774996F;
			this.Dty4Num2.Name = "Dty4Num2";
			this.Dty4Num2.OutputFormat = "#,##0.00";
			this.Dty4Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Dty4Num2.Text = "ZZZ6.66";
			this.Dty4Num2.Top = 1.162F;
			this.Dty4Num2.Width = 0.5625F;
			// 
			// Dty4Num6
			// 
			this.Dty4Num6.DataField = "DTY_4NUM6";
			this.Dty4Num6.Height = 0.143F;
			this.Dty4Num6.Left = 0.8774996F;
			this.Dty4Num6.Name = "Dty4Num6";
			this.Dty4Num6.OutputFormat = "#,##0.00";
			this.Dty4Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty4Num6.Text = "ZZZ6.66";
			this.Dty4Num6.Top = 1.305F;
			this.Dty4Num6.Width = 0.5625F;
			// 
			// Dty4Num3
			// 
			this.Dty4Num3.DataField = "DTY_4NUM3";
			this.Dty4Num3.Height = 0.143F;
			this.Dty4Num3.Left = 1.44F;
			this.Dty4Num3.Name = "Dty4Num3";
			this.Dty4Num3.OutputFormat = "#,##0.00";
			this.Dty4Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Dty4Num3.Text = "ZZZ6.66";
			this.Dty4Num3.Top = 1.162F;
			this.Dty4Num3.Width = 0.5625F;
			// 
			// Dty4Num7
			// 
			this.Dty4Num7.DataField = "DTY_4NUM7";
			this.Dty4Num7.Height = 0.143F;
			this.Dty4Num7.Left = 1.44F;
			this.Dty4Num7.Name = "Dty4Num7";
			this.Dty4Num7.OutputFormat = "#,##0.00";
			this.Dty4Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty4Num7.Text = "ZZZ6.66";
			this.Dty4Num7.Top = 1.305F;
			this.Dty4Num7.Width = 0.5625F;
			// 
			// Dty4Num4
			// 
			this.Dty4Num4.DataField = "DTY_4NUM4";
			this.Dty4Num4.Height = 0.143F;
			this.Dty4Num4.Left = 1.94F;
			this.Dty4Num4.Name = "Dty4Num4";
			this.Dty4Num4.OutputFormat = "#,##0.00";
			this.Dty4Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Dty4Num4.Text = "ZZZ6.66";
			this.Dty4Num4.Top = 1.162F;
			this.Dty4Num4.Width = 0.625F;
			// 
			// Dty4Num8
			// 
			this.Dty4Num8.DataField = "DTY_4NUM8";
			this.Dty4Num8.Height = 0.143F;
			this.Dty4Num8.Left = 2.0025F;
			this.Dty4Num8.Name = "Dty4Num8";
			this.Dty4Num8.OutputFormat = "#,##0.00";
			this.Dty4Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty4Num8.Text = "ZZZ6.66";
			this.Dty4Num8.Top = 1.305F;
			this.Dty4Num8.Width = 0.5625F;
			// 
			// Line292
			// 
			this.Line292.Height = 0F;
			this.Line292.Left = 0.3149996F;
			this.Line292.LineWeight = 1F;
			this.Line292.Name = "Line292";
			this.Line292.Top = 1.305F;
			this.Line292.Width = 2.251F;
			this.Line292.X1 = 0.3149996F;
			this.Line292.X2 = 2.566F;
			this.Line292.Y1 = 1.305F;
			this.Line292.Y2 = 1.305F;
			// 
			// Line293
			// 
			this.Line293.Height = 0F;
			this.Line293.Left = 0.06599998F;
			this.Line293.LineWeight = 1F;
			this.Line293.Name = "Line293";
			this.Line293.Top = 1.448F;
			this.Line293.Width = 2.5F;
			this.Line293.X1 = 0.06599998F;
			this.Line293.X2 = 2.566F;
			this.Line293.Y1 = 1.448F;
			this.Line293.Y2 = 1.448F;
			// 
			// Label30
			// 
			this.Label30.Height = 0.286F;
			this.Label30.HyperLink = null;
			this.Label30.Left = 0.06299973F;
			this.Label30.Name = "Label30";
			this.Label30.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label30.Text = "4";
			this.Label30.Top = 1.162F;
			this.Label30.Width = 0.253F;
			// 
			// Label33
			// 
			this.Label33.Height = 0.286F;
			this.Label33.HyperLink = null;
			this.Label33.Left = 0.06599998F;
			this.Label33.Name = "Label33";
			this.Label33.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label33.Text = "5";
			this.Label33.Top = 1.448F;
			this.Label33.Width = 0.253F;
			// 
			// Line296
			// 
			this.Line296.Height = 0F;
			this.Line296.Left = 0.06599998F;
			this.Line296.LineWeight = 1F;
			this.Line296.Name = "Line296";
			this.Line296.Top = 1.734F;
			this.Line296.Width = 2.5F;
			this.Line296.X1 = 0.06599998F;
			this.Line296.X2 = 2.566F;
			this.Line296.Y1 = 1.734F;
			this.Line296.Y2 = 1.734F;
			// 
			// Line297
			// 
			this.Line297.Height = 0F;
			this.Line297.Left = 0.3149996F;
			this.Line297.LineWeight = 1F;
			this.Line297.Name = "Line297";
			this.Line297.Top = 1.591F;
			this.Line297.Width = 2.251F;
			this.Line297.X1 = 0.3149996F;
			this.Line297.X2 = 2.566F;
			this.Line297.Y1 = 1.591F;
			this.Line297.Y2 = 1.591F;
			// 
			// Dty5Num1
			// 
			this.Dty5Num1.DataField = "DTY_5NUM1";
			this.Dty5Num1.Height = 0.143F;
			this.Dty5Num1.Left = 0.3149996F;
			this.Dty5Num1.Name = "Dty5Num1";
			this.Dty5Num1.OutputFormat = "#,##0.00";
			this.Dty5Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num1.Text = "ZZZ6.66";
			this.Dty5Num1.Top = 1.448F;
			this.Dty5Num1.Width = 0.5625F;
			// 
			// Dty5Num5
			// 
			this.Dty5Num5.DataField = "DTY_5NUM5";
			this.Dty5Num5.Height = 0.143F;
			this.Dty5Num5.Left = 0.3149996F;
			this.Dty5Num5.Name = "Dty5Num5";
			this.Dty5Num5.OutputFormat = "#,##0.00";
			this.Dty5Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num5.Text = "ZZZ6.66";
			this.Dty5Num5.Top = 1.591F;
			this.Dty5Num5.Width = 0.5625F;
			// 
			// Dty5Num2
			// 
			this.Dty5Num2.DataField = "DTY_5NUM2";
			this.Dty5Num2.Height = 0.143F;
			this.Dty5Num2.Left = 0.8774996F;
			this.Dty5Num2.Name = "Dty5Num2";
			this.Dty5Num2.OutputFormat = "#,##0.00";
			this.Dty5Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num2.Text = "ZZZ6.66";
			this.Dty5Num2.Top = 1.448F;
			this.Dty5Num2.Width = 0.5625F;
			// 
			// Dty5Num6
			// 
			this.Dty5Num6.DataField = "DTY_5NUM6";
			this.Dty5Num6.Height = 0.143F;
			this.Dty5Num6.Left = 0.8774996F;
			this.Dty5Num6.Name = "Dty5Num6";
			this.Dty5Num6.OutputFormat = "#,##0.00";
			this.Dty5Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num6.Text = "ZZZ6.66";
			this.Dty5Num6.Top = 1.591F;
			this.Dty5Num6.Width = 0.5625F;
			// 
			// Dty5Num3
			// 
			this.Dty5Num3.DataField = "DTY_5NUM3";
			this.Dty5Num3.Height = 0.143F;
			this.Dty5Num3.Left = 1.44F;
			this.Dty5Num3.Name = "Dty5Num3";
			this.Dty5Num3.OutputFormat = "#,##0.00";
			this.Dty5Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num3.Text = "ZZZ6.66";
			this.Dty5Num3.Top = 1.448F;
			this.Dty5Num3.Width = 0.5625F;
			// 
			// Dty5Num7
			// 
			this.Dty5Num7.DataField = "DTY_5NUM7";
			this.Dty5Num7.Height = 0.143F;
			this.Dty5Num7.Left = 1.44F;
			this.Dty5Num7.Name = "Dty5Num7";
			this.Dty5Num7.OutputFormat = "#,##0.00";
			this.Dty5Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num7.Text = "ZZZ6.66";
			this.Dty5Num7.Top = 1.591F;
			this.Dty5Num7.Width = 0.5625F;
			// 
			// Dty5Num4
			// 
			this.Dty5Num4.DataField = "DTY_5NUM4";
			this.Dty5Num4.Height = 0.143F;
			this.Dty5Num4.Left = 2.0025F;
			this.Dty5Num4.Name = "Dty5Num4";
			this.Dty5Num4.OutputFormat = "#,##0.00";
			this.Dty5Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num4.Text = "ZZZ6.66";
			this.Dty5Num4.Top = 1.448F;
			this.Dty5Num4.Width = 0.5625F;
			// 
			// Dty5Num8
			// 
			this.Dty5Num8.DataField = "DTY_5NUM8";
			this.Dty5Num8.Height = 0.143F;
			this.Dty5Num8.Left = 2.0025F;
			this.Dty5Num8.Name = "Dty5Num8";
			this.Dty5Num8.OutputFormat = "#,##0.00";
			this.Dty5Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty5Num8.Text = "ZZZ6.66";
			this.Dty5Num8.Top = 1.591F;
			this.Dty5Num8.Width = 0.5625F;
			// 
			// Line300
			// 
			this.Line300.Height = 0F;
			this.Line300.Left = 0.07194424F;
			this.Line300.LineWeight = 1F;
			this.Line300.Name = "Line300";
			this.Line300.Top = 2.02F;
			this.Line300.Width = 2.494056F;
			this.Line300.X1 = 0.07194424F;
			this.Line300.X2 = 2.566F;
			this.Line300.Y1 = 2.02F;
			this.Line300.Y2 = 2.02F;
			// 
			// Dty6Num5
			// 
			this.Dty6Num5.DataField = "DTY_6NUM5";
			this.Dty6Num5.Height = 0.143F;
			this.Dty6Num5.Left = 0.3149996F;
			this.Dty6Num5.Name = "Dty6Num5";
			this.Dty6Num5.OutputFormat = "#,##0.00";
			this.Dty6Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num5.Text = "ZZZ6.66";
			this.Dty6Num5.Top = 1.877F;
			this.Dty6Num5.Width = 0.5625F;
			// 
			// Dty6Num6
			// 
			this.Dty6Num6.DataField = "DTY_6NUM6";
			this.Dty6Num6.Height = 0.143F;
			this.Dty6Num6.Left = 0.8774996F;
			this.Dty6Num6.Name = "Dty6Num6";
			this.Dty6Num6.OutputFormat = "#,##0.00";
			this.Dty6Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num6.Text = "ZZZ6.66";
			this.Dty6Num6.Top = 1.877F;
			this.Dty6Num6.Width = 0.5625F;
			// 
			// Dty6Num7
			// 
			this.Dty6Num7.DataField = "DTY_6NUM7";
			this.Dty6Num7.Height = 0.143F;
			this.Dty6Num7.Left = 1.44F;
			this.Dty6Num7.Name = "Dty6Num7";
			this.Dty6Num7.OutputFormat = "#,##0.00";
			this.Dty6Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num7.Text = "ZZZ6.66";
			this.Dty6Num7.Top = 1.877F;
			this.Dty6Num7.Width = 0.5625F;
			// 
			// Dty6Num8
			// 
			this.Dty6Num8.DataField = "DTY_6NUM8";
			this.Dty6Num8.Height = 0.143F;
			this.Dty6Num8.Left = 2.0025F;
			this.Dty6Num8.Name = "Dty6Num8";
			this.Dty6Num8.OutputFormat = "#,##0.00";
			this.Dty6Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num8.Text = "ZZZ6.66";
			this.Dty6Num8.Top = 1.877F;
			this.Dty6Num8.Width = 0.5625F;
			// 
			// Label36
			// 
			this.Label36.Height = 0.286F;
			this.Label36.HyperLink = null;
			this.Label36.Left = 0.06599998F;
			this.Label36.Name = "Label36";
			this.Label36.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label36.Text = "6";
			this.Label36.Top = 1.734F;
			this.Label36.Width = 0.253F;
			// 
			// Dty6Num1
			// 
			this.Dty6Num1.DataField = "DTY_6NUM1";
			this.Dty6Num1.Height = 0.143F;
			this.Dty6Num1.Left = 0.3149996F;
			this.Dty6Num1.Name = "Dty6Num1";
			this.Dty6Num1.OutputFormat = "#,##0.00";
			this.Dty6Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num1.Text = "ZZZ6.66";
			this.Dty6Num1.Top = 1.734F;
			this.Dty6Num1.Width = 0.5625F;
			// 
			// Dty6Num2
			// 
			this.Dty6Num2.DataField = "DTY_6NUM2";
			this.Dty6Num2.Height = 0.143F;
			this.Dty6Num2.Left = 0.8774996F;
			this.Dty6Num2.Name = "Dty6Num2";
			this.Dty6Num2.OutputFormat = "#,##0.00";
			this.Dty6Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num2.Text = "ZZZ6.66";
			this.Dty6Num2.Top = 1.734F;
			this.Dty6Num2.Width = 0.5625F;
			// 
			// Dty6Num3
			// 
			this.Dty6Num3.DataField = "DTY_6NUM3";
			this.Dty6Num3.Height = 0.143F;
			this.Dty6Num3.Left = 1.44F;
			this.Dty6Num3.Name = "Dty6Num3";
			this.Dty6Num3.OutputFormat = "#,##0.00";
			this.Dty6Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num3.Text = "ZZZ6.66";
			this.Dty6Num3.Top = 1.734F;
			this.Dty6Num3.Width = 0.5625F;
			// 
			// Dty6Num4
			// 
			this.Dty6Num4.DataField = "DTY_6NUM4";
			this.Dty6Num4.Height = 0.143F;
			this.Dty6Num4.Left = 2.0025F;
			this.Dty6Num4.Name = "Dty6Num4";
			this.Dty6Num4.OutputFormat = "#,##0.00";
			this.Dty6Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty6Num4.Text = "ZZZ6.66";
			this.Dty6Num4.Top = 1.734F;
			this.Dty6Num4.Width = 0.5625F;
			// 
			// Line302
			// 
			this.Line302.Height = 0F;
			this.Line302.Left = 0.3149996F;
			this.Line302.LineWeight = 1F;
			this.Line302.Name = "Line302";
			this.Line302.Top = 1.877F;
			this.Line302.Width = 2.251F;
			this.Line302.X1 = 0.3149996F;
			this.Line302.X2 = 2.566F;
			this.Line302.Y1 = 1.877F;
			this.Line302.Y2 = 1.877F;
			// 
			// Dty7Num1
			// 
			this.Dty7Num1.DataField = "DTY_7NUM1";
			this.Dty7Num1.Height = 0.143F;
			this.Dty7Num1.Left = 0.3149996F;
			this.Dty7Num1.Name = "Dty7Num1";
			this.Dty7Num1.OutputFormat = "#,##0.00";
			this.Dty7Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num1.Text = "ZZZ6.66";
			this.Dty7Num1.Top = 2.02F;
			this.Dty7Num1.Width = 0.5625F;
			// 
			// Dty7Num5
			// 
			this.Dty7Num5.DataField = "DTY_7NUM5";
			this.Dty7Num5.Height = 0.143F;
			this.Dty7Num5.Left = 0.3149996F;
			this.Dty7Num5.Name = "Dty7Num5";
			this.Dty7Num5.OutputFormat = "#,##0.00";
			this.Dty7Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num5.Text = "ZZZ6.66";
			this.Dty7Num5.Top = 2.163F;
			this.Dty7Num5.Width = 0.5625F;
			// 
			// Dty7Num2
			// 
			this.Dty7Num2.DataField = "DTY_7NUM2";
			this.Dty7Num2.Height = 0.143F;
			this.Dty7Num2.Left = 0.8774996F;
			this.Dty7Num2.Name = "Dty7Num2";
			this.Dty7Num2.OutputFormat = "#,##0.00";
			this.Dty7Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num2.Text = "ZZZ6.66";
			this.Dty7Num2.Top = 2.02F;
			this.Dty7Num2.Width = 0.5625F;
			// 
			// Dty7Num6
			// 
			this.Dty7Num6.DataField = "DTY_7NUM6";
			this.Dty7Num6.Height = 0.143F;
			this.Dty7Num6.Left = 0.8774996F;
			this.Dty7Num6.Name = "Dty7Num6";
			this.Dty7Num6.OutputFormat = "#,##0.00";
			this.Dty7Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num6.Text = "ZZZ6.66";
			this.Dty7Num6.Top = 2.163F;
			this.Dty7Num6.Width = 0.5625F;
			// 
			// Dty7Num3
			// 
			this.Dty7Num3.DataField = "DTY_7NUM3";
			this.Dty7Num3.Height = 0.143F;
			this.Dty7Num3.Left = 1.44F;
			this.Dty7Num3.Name = "Dty7Num3";
			this.Dty7Num3.OutputFormat = "#,##0.00";
			this.Dty7Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num3.Text = "ZZZ6.66";
			this.Dty7Num3.Top = 2.02F;
			this.Dty7Num3.Width = 0.5625F;
			// 
			// Dty7Num7
			// 
			this.Dty7Num7.DataField = "DTY_7NUM7";
			this.Dty7Num7.Height = 0.143F;
			this.Dty7Num7.Left = 1.44F;
			this.Dty7Num7.Name = "Dty7Num7";
			this.Dty7Num7.OutputFormat = "#,##0.00";
			this.Dty7Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num7.Text = "ZZZ6.66";
			this.Dty7Num7.Top = 2.163F;
			this.Dty7Num7.Width = 0.5625F;
			// 
			// Dty7Num4
			// 
			this.Dty7Num4.DataField = "DTY_7NUM4";
			this.Dty7Num4.Height = 0.143F;
			this.Dty7Num4.Left = 2.0025F;
			this.Dty7Num4.Name = "Dty7Num4";
			this.Dty7Num4.OutputFormat = "#,##0.00";
			this.Dty7Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num4.Text = "ZZZ6.66";
			this.Dty7Num4.Top = 2.02F;
			this.Dty7Num4.Width = 0.5625F;
			// 
			// Dty7Num8
			// 
			this.Dty7Num8.DataField = "DTY_7NUM8";
			this.Dty7Num8.Height = 0.143F;
			this.Dty7Num8.Left = 2.0025F;
			this.Dty7Num8.Name = "Dty7Num8";
			this.Dty7Num8.OutputFormat = "#,##0.00";
			this.Dty7Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty7Num8.Text = "ZZZ6.66";
			this.Dty7Num8.Top = 2.163F;
			this.Dty7Num8.Width = 0.5625F;
			// 
			// Line304
			// 
			this.Line304.Height = 0F;
			this.Line304.Left = 0.3149996F;
			this.Line304.LineWeight = 1F;
			this.Line304.Name = "Line304";
			this.Line304.Top = 2.163F;
			this.Line304.Width = 2.251F;
			this.Line304.X1 = 0.3149996F;
			this.Line304.X2 = 2.566F;
			this.Line304.Y1 = 2.163F;
			this.Line304.Y2 = 2.163F;
			// 
			// Line305
			// 
			this.Line305.Height = 0F;
			this.Line305.Left = 0.06599998F;
			this.Line305.LineWeight = 1F;
			this.Line305.Name = "Line305";
			this.Line305.Top = 2.306F;
			this.Line305.Width = 2.5F;
			this.Line305.X1 = 0.06599998F;
			this.Line305.X2 = 2.566F;
			this.Line305.Y1 = 2.306F;
			this.Line305.Y2 = 2.306F;
			// 
			// Label39
			// 
			this.Label39.Height = 0.286F;
			this.Label39.HyperLink = null;
			this.Label39.Left = 0.06299973F;
			this.Label39.Name = "Label39";
			this.Label39.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label39.Text = "7";
			this.Label39.Top = 2.02F;
			this.Label39.Width = 0.253F;
			// 
			// Label42
			// 
			this.Label42.Height = 0.286F;
			this.Label42.HyperLink = null;
			this.Label42.Left = 0.06599998F;
			this.Label42.Name = "Label42";
			this.Label42.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label42.Text = "8";
			this.Label42.Top = 2.306F;
			this.Label42.Width = 0.253F;
			// 
			// Line308
			// 
			this.Line308.Height = 0F;
			this.Line308.Left = 0.06599998F;
			this.Line308.LineWeight = 1F;
			this.Line308.Name = "Line308";
			this.Line308.Top = 2.592F;
			this.Line308.Width = 2.5F;
			this.Line308.X1 = 0.06599998F;
			this.Line308.X2 = 2.566F;
			this.Line308.Y1 = 2.592F;
			this.Line308.Y2 = 2.592F;
			// 
			// Line309
			// 
			this.Line309.Height = 0F;
			this.Line309.Left = 0.3149996F;
			this.Line309.LineWeight = 1F;
			this.Line309.Name = "Line309";
			this.Line309.Top = 2.449F;
			this.Line309.Width = 2.251F;
			this.Line309.X1 = 0.3149996F;
			this.Line309.X2 = 2.566F;
			this.Line309.Y1 = 2.449F;
			this.Line309.Y2 = 2.449F;
			// 
			// Dty8Num1
			// 
			this.Dty8Num1.DataField = "DTY_8NUM1";
			this.Dty8Num1.Height = 0.143F;
			this.Dty8Num1.Left = 0.3149996F;
			this.Dty8Num1.Name = "Dty8Num1";
			this.Dty8Num1.OutputFormat = "#,##0.00";
			this.Dty8Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num1.Text = "ZZZ6.66";
			this.Dty8Num1.Top = 2.306F;
			this.Dty8Num1.Width = 0.5625F;
			// 
			// Dty9Num1
			// 
			this.Dty9Num1.DataField = "DTY_9NUM1";
			this.Dty9Num1.Height = 0.143F;
			this.Dty9Num1.Left = 0.3149996F;
			this.Dty9Num1.Name = "Dty9Num1";
			this.Dty9Num1.OutputFormat = "#,##0.00";
			this.Dty9Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num1.Text = "ZZZ6.66";
			this.Dty9Num1.Top = 2.592F;
			this.Dty9Num1.Width = 0.5625F;
			// 
			// Dty8Num6
			// 
			this.Dty8Num6.DataField = "DTY_8NUM6";
			this.Dty8Num6.Height = 0.143F;
			this.Dty8Num6.Left = 0.8774996F;
			this.Dty8Num6.Name = "Dty8Num6";
			this.Dty8Num6.OutputFormat = "#,##0.00";
			this.Dty8Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num6.Text = "ZZZ6.66";
			this.Dty8Num6.Top = 2.449F;
			this.Dty8Num6.Width = 0.5625F;
			// 
			// Dty8Num3
			// 
			this.Dty8Num3.DataField = "DTY_8NUM3";
			this.Dty8Num3.Height = 0.143F;
			this.Dty8Num3.Left = 1.44F;
			this.Dty8Num3.Name = "Dty8Num3";
			this.Dty8Num3.OutputFormat = "#,##0.00";
			this.Dty8Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num3.Text = "ZZZ6.66";
			this.Dty8Num3.Top = 2.306F;
			this.Dty8Num3.Width = 0.5625F;
			// 
			// Dty8Num7
			// 
			this.Dty8Num7.DataField = "DTY_8NUM7";
			this.Dty8Num7.Height = 0.143F;
			this.Dty8Num7.Left = 1.44F;
			this.Dty8Num7.Name = "Dty8Num7";
			this.Dty8Num7.OutputFormat = "#,##0.00";
			this.Dty8Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num7.Text = "ZZZ6.66";
			this.Dty8Num7.Top = 2.449F;
			this.Dty8Num7.Width = 0.5625F;
			// 
			// Dty8Num4
			// 
			this.Dty8Num4.DataField = "DTY_8NUM4";
			this.Dty8Num4.Height = 0.143F;
			this.Dty8Num4.Left = 2.0025F;
			this.Dty8Num4.Name = "Dty8Num4";
			this.Dty8Num4.OutputFormat = "#,##0.00";
			this.Dty8Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num4.Text = "ZZZ6.66";
			this.Dty8Num4.Top = 2.306F;
			this.Dty8Num4.Width = 0.5625F;
			// 
			// Dty8Num8
			// 
			this.Dty8Num8.DataField = "DTY_8NUM8";
			this.Dty8Num8.Height = 0.143F;
			this.Dty8Num8.Left = 2.0025F;
			this.Dty8Num8.Name = "Dty8Num8";
			this.Dty8Num8.OutputFormat = "#,##0.00";
			this.Dty8Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num8.Text = "ZZZ6.66";
			this.Dty8Num8.Top = 2.449F;
			this.Dty8Num8.Width = 0.5625F;
			// 
			// Line312
			// 
			this.Line312.Height = 0F;
			this.Line312.Left = 0.06599998F;
			this.Line312.LineWeight = 1F;
			this.Line312.Name = "Line312";
			this.Line312.Top = 2.878F;
			this.Line312.Width = 2.5F;
			this.Line312.X1 = 0.06599998F;
			this.Line312.X2 = 2.566F;
			this.Line312.Y1 = 2.878F;
			this.Line312.Y2 = 2.878F;
			// 
			// Dty9Num5
			// 
			this.Dty9Num5.DataField = "DTY_9NUM5";
			this.Dty9Num5.Height = 0.143F;
			this.Dty9Num5.Left = 0.3149996F;
			this.Dty9Num5.Name = "Dty9Num5";
			this.Dty9Num5.OutputFormat = "#,##0.00";
			this.Dty9Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num5.Text = "ZZZ6.66";
			this.Dty9Num5.Top = 2.735F;
			this.Dty9Num5.Width = 0.5625F;
			// 
			// Dty9Num6
			// 
			this.Dty9Num6.DataField = "DTY_9NUM6";
			this.Dty9Num6.Height = 0.143F;
			this.Dty9Num6.Left = 0.8774996F;
			this.Dty9Num6.Name = "Dty9Num6";
			this.Dty9Num6.OutputFormat = "#,##0.00";
			this.Dty9Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num6.Text = "ZZZ6.66";
			this.Dty9Num6.Top = 2.735F;
			this.Dty9Num6.Width = 0.5625F;
			// 
			// Dty9Num7
			// 
			this.Dty9Num7.DataField = "DTY_9NUM7";
			this.Dty9Num7.Height = 0.143F;
			this.Dty9Num7.Left = 1.44F;
			this.Dty9Num7.Name = "Dty9Num7";
			this.Dty9Num7.OutputFormat = "#,##0.00";
			this.Dty9Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num7.Text = "ZZZ6.66";
			this.Dty9Num7.Top = 2.735F;
			this.Dty9Num7.Width = 0.5625F;
			// 
			// Dty9Num8
			// 
			this.Dty9Num8.DataField = "DTY_9NUM8";
			this.Dty9Num8.Height = 0.143F;
			this.Dty9Num8.Left = 2.0025F;
			this.Dty9Num8.Name = "Dty9Num8";
			this.Dty9Num8.OutputFormat = "#,##0.00";
			this.Dty9Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num8.Text = "ZZZ6.66";
			this.Dty9Num8.Top = 2.735F;
			this.Dty9Num8.Width = 0.5625F;
			// 
			// Label45
			// 
			this.Label45.Height = 0.286F;
			this.Label45.HyperLink = null;
			this.Label45.Left = 0.06599998F;
			this.Label45.Name = "Label45";
			this.Label45.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label45.Text = "9";
			this.Label45.Top = 2.592F;
			this.Label45.Width = 0.253F;
			// 
			// Dty8Num5
			// 
			this.Dty8Num5.DataField = "DTY_8NUM5";
			this.Dty8Num5.Height = 0.143F;
			this.Dty8Num5.Left = 0.3149996F;
			this.Dty8Num5.Name = "Dty8Num5";
			this.Dty8Num5.OutputFormat = "#,##0.00";
			this.Dty8Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num5.Text = "ZZZ6.66";
			this.Dty8Num5.Top = 2.449F;
			this.Dty8Num5.Width = 0.5625F;
			// 
			// Dty9Num2
			// 
			this.Dty9Num2.DataField = "DTY_9NUM2";
			this.Dty9Num2.Height = 0.143F;
			this.Dty9Num2.Left = 0.8774996F;
			this.Dty9Num2.Name = "Dty9Num2";
			this.Dty9Num2.OutputFormat = "#,##0.00";
			this.Dty9Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num2.Text = "ZZZ6.66";
			this.Dty9Num2.Top = 2.592F;
			this.Dty9Num2.Width = 0.5625F;
			// 
			// Dty9Num3
			// 
			this.Dty9Num3.DataField = "DTY_9NUM3";
			this.Dty9Num3.Height = 0.143F;
			this.Dty9Num3.Left = 1.44F;
			this.Dty9Num3.Name = "Dty9Num3";
			this.Dty9Num3.OutputFormat = "#,##0.00";
			this.Dty9Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num3.Text = "ZZZ6.66";
			this.Dty9Num3.Top = 2.592F;
			this.Dty9Num3.Width = 0.5625F;
			// 
			// Dty9Num4
			// 
			this.Dty9Num4.DataField = "DTY_9NUM4";
			this.Dty9Num4.Height = 0.143F;
			this.Dty9Num4.Left = 2.0025F;
			this.Dty9Num4.Name = "Dty9Num4";
			this.Dty9Num4.OutputFormat = "#,##0.00";
			this.Dty9Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty9Num4.Text = "ZZZ6.66";
			this.Dty9Num4.Top = 2.592F;
			this.Dty9Num4.Width = 0.5625F;
			// 
			// Line314
			// 
			this.Line314.Height = 0F;
			this.Line314.Left = 0.3149996F;
			this.Line314.LineWeight = 1F;
			this.Line314.Name = "Line314";
			this.Line314.Top = 2.735F;
			this.Line314.Width = 2.251F;
			this.Line314.X1 = 0.3149996F;
			this.Line314.X2 = 2.566F;
			this.Line314.Y1 = 2.735F;
			this.Line314.Y2 = 2.735F;
			// 
			// Dty10Num1
			// 
			this.Dty10Num1.DataField = "DTY_10NUM1";
			this.Dty10Num1.Height = 0.143F;
			this.Dty10Num1.Left = 0.3149996F;
			this.Dty10Num1.Name = "Dty10Num1";
			this.Dty10Num1.OutputFormat = "#,##0.00";
			this.Dty10Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num1.Text = "ZZZ6.66";
			this.Dty10Num1.Top = 2.878F;
			this.Dty10Num1.Width = 0.5625F;
			// 
			// Dty10Num5
			// 
			this.Dty10Num5.DataField = "DTY_10NUM5";
			this.Dty10Num5.Height = 0.143F;
			this.Dty10Num5.Left = 0.3149996F;
			this.Dty10Num5.Name = "Dty10Num5";
			this.Dty10Num5.OutputFormat = "#,##0.00";
			this.Dty10Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num5.Text = "ZZZ6.66";
			this.Dty10Num5.Top = 3.021F;
			this.Dty10Num5.Width = 0.5625F;
			// 
			// Dty10Num2
			// 
			this.Dty10Num2.DataField = "DTY_10NUM2";
			this.Dty10Num2.Height = 0.143F;
			this.Dty10Num2.Left = 0.8774996F;
			this.Dty10Num2.Name = "Dty10Num2";
			this.Dty10Num2.OutputFormat = "#,##0.00";
			this.Dty10Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num2.Text = "ZZZ6.66";
			this.Dty10Num2.Top = 2.878F;
			this.Dty10Num2.Width = 0.5625F;
			// 
			// Dty10Num6
			// 
			this.Dty10Num6.DataField = "DTY_10NUM6";
			this.Dty10Num6.Height = 0.143F;
			this.Dty10Num6.Left = 0.8774996F;
			this.Dty10Num6.Name = "Dty10Num6";
			this.Dty10Num6.OutputFormat = "#,##0.00";
			this.Dty10Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num6.Text = "ZZZ6.66";
			this.Dty10Num6.Top = 3.021F;
			this.Dty10Num6.Width = 0.5625F;
			// 
			// Dty10Num3
			// 
			this.Dty10Num3.DataField = "DTY_10NUM3";
			this.Dty10Num3.Height = 0.143F;
			this.Dty10Num3.Left = 1.44F;
			this.Dty10Num3.Name = "Dty10Num3";
			this.Dty10Num3.OutputFormat = "#,##0.00";
			this.Dty10Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num3.Text = "ZZZ6.66";
			this.Dty10Num3.Top = 2.878F;
			this.Dty10Num3.Width = 0.5625F;
			// 
			// Dty10Num7
			// 
			this.Dty10Num7.DataField = "DTY_10NUM7";
			this.Dty10Num7.Height = 0.143F;
			this.Dty10Num7.Left = 1.44F;
			this.Dty10Num7.Name = "Dty10Num7";
			this.Dty10Num7.OutputFormat = "#,##0.00";
			this.Dty10Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num7.Text = "ZZZ6.66";
			this.Dty10Num7.Top = 3.021F;
			this.Dty10Num7.Width = 0.5625F;
			// 
			// Dty10Num4
			// 
			this.Dty10Num4.DataField = "DTY_10NUM4";
			this.Dty10Num4.Height = 0.143F;
			this.Dty10Num4.Left = 2.0025F;
			this.Dty10Num4.Name = "Dty10Num4";
			this.Dty10Num4.OutputFormat = "#,##0.00";
			this.Dty10Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num4.Text = "ZZZ6.66";
			this.Dty10Num4.Top = 2.878F;
			this.Dty10Num4.Width = 0.5625F;
			// 
			// Dty10Num8
			// 
			this.Dty10Num8.DataField = "DTY_10NUM8";
			this.Dty10Num8.Height = 0.143F;
			this.Dty10Num8.Left = 2.0025F;
			this.Dty10Num8.Name = "Dty10Num8";
			this.Dty10Num8.OutputFormat = "#,##0.00";
			this.Dty10Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty10Num8.Text = "ZZZ6.66";
			this.Dty10Num8.Top = 3.021F;
			this.Dty10Num8.Width = 0.5625F;
			// 
			// Line316
			// 
			this.Line316.Height = 0F;
			this.Line316.Left = 0.3149996F;
			this.Line316.LineWeight = 1F;
			this.Line316.Name = "Line316";
			this.Line316.Top = 3.021F;
			this.Line316.Width = 2.251F;
			this.Line316.X1 = 0.3149996F;
			this.Line316.X2 = 2.566F;
			this.Line316.Y1 = 3.021F;
			this.Line316.Y2 = 3.021F;
			// 
			// Line317
			// 
			this.Line317.Height = 0F;
			this.Line317.Left = 0.06599998F;
			this.Line317.LineWeight = 1F;
			this.Line317.Name = "Line317";
			this.Line317.Top = 3.164F;
			this.Line317.Width = 2.5F;
			this.Line317.X1 = 0.06599998F;
			this.Line317.X2 = 2.566F;
			this.Line317.Y1 = 3.164F;
			this.Line317.Y2 = 3.164F;
			// 
			// Label48
			// 
			this.Label48.Height = 0.286F;
			this.Label48.HyperLink = null;
			this.Label48.Left = 0.06299973F;
			this.Label48.Name = "Label48";
			this.Label48.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label48.Text = "10";
			this.Label48.Top = 2.878F;
			this.Label48.Width = 0.253F;
			// 
			// Label51
			// 
			this.Label51.Height = 0.286F;
			this.Label51.HyperLink = null;
			this.Label51.Left = 0.06599998F;
			this.Label51.Name = "Label51";
			this.Label51.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label51.Text = "11";
			this.Label51.Top = 3.164F;
			this.Label51.Width = 0.253F;
			// 
			// Line320
			// 
			this.Line320.Height = 0F;
			this.Line320.Left = 0.06599998F;
			this.Line320.LineWeight = 1F;
			this.Line320.Name = "Line320";
			this.Line320.Top = 3.45F;
			this.Line320.Width = 2.4966F;
			this.Line320.X1 = 0.06599998F;
			this.Line320.X2 = 2.5626F;
			this.Line320.Y1 = 3.45F;
			this.Line320.Y2 = 3.45F;
			// 
			// Line321
			// 
			this.Line321.Height = 0F;
			this.Line321.Left = 0.3149996F;
			this.Line321.LineWeight = 1F;
			this.Line321.Name = "Line321";
			this.Line321.Top = 3.307F;
			this.Line321.Width = 2.251F;
			this.Line321.X1 = 0.3149996F;
			this.Line321.X2 = 2.566F;
			this.Line321.Y1 = 3.307F;
			this.Line321.Y2 = 3.307F;
			// 
			// Dty11Num1
			// 
			this.Dty11Num1.DataField = "DTY_11NUM1";
			this.Dty11Num1.Height = 0.143F;
			this.Dty11Num1.Left = 0.3149996F;
			this.Dty11Num1.Name = "Dty11Num1";
			this.Dty11Num1.OutputFormat = "#,##0.00";
			this.Dty11Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num1.Text = "ZZZ6.66";
			this.Dty11Num1.Top = 3.164F;
			this.Dty11Num1.Width = 0.5625F;
			// 
			// Dty11Num5
			// 
			this.Dty11Num5.DataField = "DTY_11NUM5";
			this.Dty11Num5.Height = 0.143F;
			this.Dty11Num5.Left = 0.3149996F;
			this.Dty11Num5.Name = "Dty11Num5";
			this.Dty11Num5.OutputFormat = "#,##0.00";
			this.Dty11Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num5.Text = "ZZZ6.66";
			this.Dty11Num5.Top = 3.307F;
			this.Dty11Num5.Width = 0.5625F;
			// 
			// Dty11Num2
			// 
			this.Dty11Num2.DataField = "DTY_11NUM2";
			this.Dty11Num2.Height = 0.143F;
			this.Dty11Num2.Left = 0.8774996F;
			this.Dty11Num2.Name = "Dty11Num2";
			this.Dty11Num2.OutputFormat = "#,##0.00";
			this.Dty11Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num2.Text = "ZZZ6.66";
			this.Dty11Num2.Top = 3.164F;
			this.Dty11Num2.Width = 0.5625F;
			// 
			// Dty11Num6
			// 
			this.Dty11Num6.DataField = "DTY_11NUM6";
			this.Dty11Num6.Height = 0.143F;
			this.Dty11Num6.Left = 0.8774996F;
			this.Dty11Num6.Name = "Dty11Num6";
			this.Dty11Num6.OutputFormat = "#,##0.00";
			this.Dty11Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num6.Text = "ZZZ6.66";
			this.Dty11Num6.Top = 3.307F;
			this.Dty11Num6.Width = 0.5625F;
			// 
			// Dty11Num3
			// 
			this.Dty11Num3.DataField = "DTY_11NUM3";
			this.Dty11Num3.Height = 0.143F;
			this.Dty11Num3.Left = 1.44F;
			this.Dty11Num3.Name = "Dty11Num3";
			this.Dty11Num3.OutputFormat = "#,##0.00";
			this.Dty11Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num3.Text = "ZZZ6.66";
			this.Dty11Num3.Top = 3.164F;
			this.Dty11Num3.Width = 0.5625F;
			// 
			// Dty11Num7
			// 
			this.Dty11Num7.DataField = "DTY_11NUM7";
			this.Dty11Num7.Height = 0.143F;
			this.Dty11Num7.Left = 1.44F;
			this.Dty11Num7.Name = "Dty11Num7";
			this.Dty11Num7.OutputFormat = "#,##0.00";
			this.Dty11Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num7.Text = "ZZZ6.66";
			this.Dty11Num7.Top = 3.307F;
			this.Dty11Num7.Width = 0.5625F;
			// 
			// Dty11Num4
			// 
			this.Dty11Num4.DataField = "DTY_11NUM4";
			this.Dty11Num4.Height = 0.143F;
			this.Dty11Num4.Left = 2.0025F;
			this.Dty11Num4.Name = "Dty11Num4";
			this.Dty11Num4.OutputFormat = "#,##0.00";
			this.Dty11Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num4.Text = "ZZZ6.66";
			this.Dty11Num4.Top = 3.164F;
			this.Dty11Num4.Width = 0.5625F;
			// 
			// Dty11Num8
			// 
			this.Dty11Num8.DataField = "DTY_11NUM8";
			this.Dty11Num8.Height = 0.143F;
			this.Dty11Num8.Left = 2.0025F;
			this.Dty11Num8.Name = "Dty11Num8";
			this.Dty11Num8.OutputFormat = "#,##0.00";
			this.Dty11Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty11Num8.Text = "ZZZ6.66";
			this.Dty11Num8.Top = 3.307F;
			this.Dty11Num8.Width = 0.5625F;
			// 
			// Dty12Num5
			// 
			this.Dty12Num5.DataField = "DTY_12NUM5";
			this.Dty12Num5.Height = 0.143F;
			this.Dty12Num5.Left = 0.3149996F;
			this.Dty12Num5.Name = "Dty12Num5";
			this.Dty12Num5.OutputFormat = "#,##0.00";
			this.Dty12Num5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num5.Text = "ZZZ6.66";
			this.Dty12Num5.Top = 3.593F;
			this.Dty12Num5.Width = 0.5625F;
			// 
			// Dty12Num6
			// 
			this.Dty12Num6.DataField = "DTY_12NUM6";
			this.Dty12Num6.Height = 0.143F;
			this.Dty12Num6.Left = 0.8774996F;
			this.Dty12Num6.Name = "Dty12Num6";
			this.Dty12Num6.OutputFormat = "#,##0.00";
			this.Dty12Num6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num6.Text = "ZZZ6.66";
			this.Dty12Num6.Top = 3.593F;
			this.Dty12Num6.Width = 0.5625F;
			// 
			// Dty12Num7
			// 
			this.Dty12Num7.DataField = "DTY_12NUM7";
			this.Dty12Num7.Height = 0.143F;
			this.Dty12Num7.Left = 1.44F;
			this.Dty12Num7.Name = "Dty12Num7";
			this.Dty12Num7.OutputFormat = "#,##0.00";
			this.Dty12Num7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num7.Text = "ZZZ6.66";
			this.Dty12Num7.Top = 3.593F;
			this.Dty12Num7.Width = 0.5625F;
			// 
			// Dty12Num8
			// 
			this.Dty12Num8.DataField = "DTY_12NUM8";
			this.Dty12Num8.Height = 0.143F;
			this.Dty12Num8.Left = 2.0025F;
			this.Dty12Num8.Name = "Dty12Num8";
			this.Dty12Num8.OutputFormat = "#,##0.00";
			this.Dty12Num8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num8.Text = "ZZZ6.66";
			this.Dty12Num8.Top = 3.593F;
			this.Dty12Num8.Width = 0.5625F;
			// 
			// Label54
			// 
			this.Label54.Height = 0.286F;
			this.Label54.HyperLink = null;
			this.Label54.Left = 0.06299973F;
			this.Label54.Name = "Label54";
			this.Label54.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label54.Text = "12";
			this.Label54.Top = 3.45F;
			this.Label54.Width = 0.253F;
			// 
			// Dty12Num1
			// 
			this.Dty12Num1.DataField = "DTY_12NUM1";
			this.Dty12Num1.Height = 0.143F;
			this.Dty12Num1.Left = 0.3149996F;
			this.Dty12Num1.Name = "Dty12Num1";
			this.Dty12Num1.OutputFormat = "#,##0.00";
			this.Dty12Num1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num1.Text = "ZZZ6.66";
			this.Dty12Num1.Top = 3.45F;
			this.Dty12Num1.Width = 0.5625F;
			// 
			// Dty12Num2
			// 
			this.Dty12Num2.DataField = "DTY_12NUM2";
			this.Dty12Num2.Height = 0.143F;
			this.Dty12Num2.Left = 0.8774996F;
			this.Dty12Num2.Name = "Dty12Num2";
			this.Dty12Num2.OutputFormat = "#,##0.00";
			this.Dty12Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num2.Text = "ZZZ6.66";
			this.Dty12Num2.Top = 3.45F;
			this.Dty12Num2.Width = 0.5625F;
			// 
			// Dty12Num3
			// 
			this.Dty12Num3.DataField = "DTY_12NUM3";
			this.Dty12Num3.Height = 0.143F;
			this.Dty12Num3.Left = 1.44F;
			this.Dty12Num3.Name = "Dty12Num3";
			this.Dty12Num3.OutputFormat = "#,##0.00";
			this.Dty12Num3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num3.Text = "ZZZ6.66";
			this.Dty12Num3.Top = 3.45F;
			this.Dty12Num3.Width = 0.5625F;
			// 
			// Dty12Num4
			// 
			this.Dty12Num4.DataField = "DTY_12NUM4";
			this.Dty12Num4.Height = 0.143F;
			this.Dty12Num4.Left = 2.0025F;
			this.Dty12Num4.Name = "Dty12Num4";
			this.Dty12Num4.OutputFormat = "#,##0.00";
			this.Dty12Num4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty12Num4.Text = "ZZZ6.66";
			this.Dty12Num4.Top = 3.45F;
			this.Dty12Num4.Width = 0.5625F;
			// 
			// Line324
			// 
			this.Line324.Height = 0F;
			this.Line324.Left = 0.3149996F;
			this.Line324.LineWeight = 1F;
			this.Line324.Name = "Line324";
			this.Line324.Top = 3.593F;
			this.Line324.Width = 2.251F;
			this.Line324.X1 = 0.3149996F;
			this.Line324.X2 = 2.566F;
			this.Line324.Y1 = 3.593F;
			this.Line324.Y2 = 3.593F;
			// 
			// Line326
			// 
			this.Line326.Height = 0F;
			this.Line326.Left = 0.06299973F;
			this.Line326.LineWeight = 1F;
			this.Line326.Name = "Line326";
			this.Line326.Top = 3.736F;
			this.Line326.Width = 2.503F;
			this.Line326.X1 = 0.06299973F;
			this.Line326.X2 = 2.566F;
			this.Line326.Y1 = 3.736F;
			this.Line326.Y2 = 3.736F;
			// 
			// Line329
			// 
			this.Line329.Height = 0F;
			this.Line329.Left = 0.06299973F;
			this.Line329.LineWeight = 1F;
			this.Line329.Name = "Line329";
			this.Line329.Top = 4.022F;
			this.Line329.Width = 2.503F;
			this.Line329.X1 = 0.06299973F;
			this.Line329.X2 = 2.566F;
			this.Line329.Y1 = 4.022F;
			this.Line329.Y2 = 4.022F;
			// 
			// Line330
			// 
			this.Line330.Height = 0F;
			this.Line330.Left = 0.3149996F;
			this.Line330.LineWeight = 1F;
			this.Line330.Name = "Line330";
			this.Line330.Top = 3.879001F;
			this.Line330.Width = 2.251F;
			this.Line330.X1 = 0.3149996F;
			this.Line330.X2 = 2.566F;
			this.Line330.Y1 = 3.879001F;
			this.Line330.Y2 = 3.879001F;
			// 
			// Label57
			// 
			this.Label57.Height = 0.286F;
			this.Label57.HyperLink = null;
			this.Label57.Left = 0.06299973F;
			this.Label57.Name = "Label57";
			this.Label57.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label57.Text = "合計";
			this.Label57.Top = 3.736F;
			this.Label57.Width = 0.253F;
			// 
			// DtyTotal1
			// 
			this.DtyTotal1.DataField = "DTY_TOTAL1";
			this.DtyTotal1.Height = 0.143F;
			this.DtyTotal1.Left = 0.3149996F;
			this.DtyTotal1.Name = "DtyTotal1";
			this.DtyTotal1.OutputFormat = "#,##0.00";
			this.DtyTotal1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal1.Text = "ZZZ6.66";
			this.DtyTotal1.Top = 3.736F;
			this.DtyTotal1.Width = 0.5625F;
			// 
			// DtyTotal5
			// 
			this.DtyTotal5.DataField = "DTY_TOTAL5";
			this.DtyTotal5.Height = 0.143F;
			this.DtyTotal5.Left = 0.3149996F;
			this.DtyTotal5.Name = "DtyTotal5";
			this.DtyTotal5.OutputFormat = "#,##0.00";
			this.DtyTotal5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal5.Text = "ZZZ6.66";
			this.DtyTotal5.Top = 3.879001F;
			this.DtyTotal5.Width = 0.5625F;
			// 
			// DtyTotal2
			// 
			this.DtyTotal2.DataField = "DTY_TOTAL2";
			this.DtyTotal2.Height = 0.143F;
			this.DtyTotal2.Left = 0.8774996F;
			this.DtyTotal2.Name = "DtyTotal2";
			this.DtyTotal2.OutputFormat = "#,##0.00";
			this.DtyTotal2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal2.Text = "ZZZ6.66";
			this.DtyTotal2.Top = 3.736F;
			this.DtyTotal2.Width = 0.5625F;
			// 
			// DtyTotal6
			// 
			this.DtyTotal6.DataField = "DTY_TOTAL6";
			this.DtyTotal6.Height = 0.143F;
			this.DtyTotal6.Left = 0.8774996F;
			this.DtyTotal6.Name = "DtyTotal6";
			this.DtyTotal6.OutputFormat = "#,##0.00";
			this.DtyTotal6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal6.Text = "ZZZ6.66";
			this.DtyTotal6.Top = 3.879001F;
			this.DtyTotal6.Width = 0.5625F;
			// 
			// DtyTotal3
			// 
			this.DtyTotal3.DataField = "DTY_TOTAL3";
			this.DtyTotal3.Height = 0.143F;
			this.DtyTotal3.Left = 1.44F;
			this.DtyTotal3.Name = "DtyTotal3";
			this.DtyTotal3.OutputFormat = "#,##0.00";
			this.DtyTotal3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal3.Text = "ZZZ6.66";
			this.DtyTotal3.Top = 3.736F;
			this.DtyTotal3.Width = 0.5625F;
			// 
			// DtyTotal7
			// 
			this.DtyTotal7.DataField = "DTY_TOTAL7";
			this.DtyTotal7.Height = 0.143F;
			this.DtyTotal7.Left = 1.44F;
			this.DtyTotal7.Name = "DtyTotal7";
			this.DtyTotal7.OutputFormat = "#,##0.00";
			this.DtyTotal7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal7.Text = "ZZZ6.66";
			this.DtyTotal7.Top = 3.879001F;
			this.DtyTotal7.Width = 0.5625F;
			// 
			// DtyTotal4
			// 
			this.DtyTotal4.DataField = "DTY_TOTAL4";
			this.DtyTotal4.Height = 0.143F;
			this.DtyTotal4.Left = 2.0025F;
			this.DtyTotal4.Name = "DtyTotal4";
			this.DtyTotal4.OutputFormat = "#,##0.00";
			this.DtyTotal4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal4.Text = "ZZZ6.66";
			this.DtyTotal4.Top = 3.736F;
			this.DtyTotal4.Width = 0.5625F;
			// 
			// DtyTotal8
			// 
			this.DtyTotal8.DataField = "DTY_TOTAL8";
			this.DtyTotal8.Height = 0.143F;
			this.DtyTotal8.Left = 2.0025F;
			this.DtyTotal8.Name = "DtyTotal8";
			this.DtyTotal8.OutputFormat = "#,##0.00";
			this.DtyTotal8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DtyTotal8.Text = "ZZZ6.66";
			this.DtyTotal8.Top = 3.879001F;
			this.DtyTotal8.Width = 0.5625F;
			// 
			// Label58
			// 
			this.Label58.Height = 0.134F;
			this.Label58.HyperLink = null;
			this.Label58.Left = 0.06299973F;
			this.Label58.Name = "Label58";
			this.Label58.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label58.Text = "税表区分";
			this.Label58.Top = 4.165F;
			this.Label58.Width = 0.8145F;
			// 
			// TaxTypeName
			// 
			this.TaxTypeName.DataField = "TAX_TYPE_NAME";
			this.TaxTypeName.Height = 0.134F;
			this.TaxTypeName.Left = 0.8769999F;
			this.TaxTypeName.Name = "TaxTypeName";
			this.TaxTypeName.Style = "font-size: 7pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
			this.TaxTypeName.Text = "ああああああああああ";
			this.TaxTypeName.Top = 4.165F;
			this.TaxTypeName.Width = 1.688F;
			// 
			// Line331
			// 
			this.Line331.Height = 0F;
			this.Line331.Left = 0.06299973F;
			this.Line331.LineWeight = 1F;
			this.Line331.Name = "Line331";
			this.Line331.Top = 4.165F;
			this.Line331.Width = 2.503F;
			this.Line331.X1 = 0.06299973F;
			this.Line331.X2 = 2.566F;
			this.Line331.Y1 = 4.165F;
			this.Line331.Y2 = 4.165F;
			// 
			// Line332
			// 
			this.Line332.Height = 0F;
			this.Line332.Left = 0.06299973F;
			this.Line332.LineWeight = 1F;
			this.Line332.Name = "Line332";
			this.Line332.Top = 4.299F;
			this.Line332.Width = 2.503F;
			this.Line332.X1 = 0.06299973F;
			this.Line332.X2 = 2.566F;
			this.Line332.Y1 = 4.299F;
			this.Line332.Y2 = 4.299F;
			// 
			// Line333
			// 
			this.Line333.Height = 0.1339998F;
			this.Line333.Left = 0.06550026F;
			this.Line333.LineWeight = 1F;
			this.Line333.Name = "Line333";
			this.Line333.Top = 4.165F;
			this.Line333.Width = 0F;
			this.Line333.X1 = 0.06550026F;
			this.Line333.X2 = 0.06550026F;
			this.Line333.Y1 = 4.165F;
			this.Line333.Y2 = 4.299F;
			// 
			// Line334
			// 
			this.Line334.Height = 0.1339998F;
			this.Line334.Left = 2.5655F;
			this.Line334.LineWeight = 1F;
			this.Line334.Name = "Line334";
			this.Line334.Top = 4.165F;
			this.Line334.Width = 0F;
			this.Line334.X1 = 2.5655F;
			this.Line334.X2 = 2.5655F;
			this.Line334.Y1 = 4.165F;
			this.Line334.Y2 = 4.299F;
			// 
			// Line335
			// 
			this.Line335.Height = 0F;
			this.Line335.Left = 0.06299973F;
			this.Line335.LineWeight = 1F;
			this.Line335.Name = "Line335";
			this.Line335.Top = 4.451F;
			this.Line335.Width = 2.503F;
			this.Line335.X1 = 0.06299973F;
			this.Line335.X2 = 2.566F;
			this.Line335.Y1 = 4.451F;
			this.Line335.Y2 = 4.451F;
			// 
			// Line336
			// 
			this.Line336.Height = 1.868F;
			this.Line336.Left = 0.06550026F;
			this.Line336.LineWeight = 1F;
			this.Line336.Name = "Line336";
			this.Line336.Top = 4.451F;
			this.Line336.Width = 0F;
			this.Line336.X1 = 0.06550026F;
			this.Line336.X2 = 0.06550026F;
			this.Line336.Y1 = 4.451F;
			this.Line336.Y2 = 6.319F;
			// 
			// Line337
			// 
			this.Line337.Height = 1.8675F;
			this.Line337.Left = 2.565F;
			this.Line337.LineWeight = 1F;
			this.Line337.Name = "Line337";
			this.Line337.Top = 4.4515F;
			this.Line337.Width = 0F;
			this.Line337.X1 = 2.565F;
			this.Line337.X2 = 2.565F;
			this.Line337.Y1 = 4.4515F;
			this.Line337.Y2 = 6.319F;
			// 
			// Line338
			// 
			this.Line338.Height = 0F;
			this.Line338.Left = 0.06299973F;
			this.Line338.LineWeight = 1F;
			this.Line338.Name = "Line338";
			this.Line338.Top = 4.594F;
			this.Line338.Width = 2.503F;
			this.Line338.X1 = 0.06299973F;
			this.Line338.X2 = 2.566F;
			this.Line338.Y1 = 4.594F;
			this.Line338.Y2 = 4.594F;
			// 
			// Label59
			// 
			this.Label59.Height = 0.143F;
			this.Label59.HyperLink = null;
			this.Label59.Left = 0.06299973F;
			this.Label59.Name = "Label59";
			this.Label59.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label59.Text = "税　情　報";
			this.Label59.Top = 4.451F;
			this.Label59.Width = 2.502F;
			// 
			// Line339
			// 
			this.Line339.Height = 0.1339998F;
			this.Line339.Left = 0.8769999F;
			this.Line339.LineWeight = 1F;
			this.Line339.Name = "Line339";
			this.Line339.Top = 4.165F;
			this.Line339.Width = 0F;
			this.Line339.X1 = 0.8769999F;
			this.Line339.X2 = 0.8769999F;
			this.Line339.Y1 = 4.165F;
			this.Line339.Y2 = 4.299F;
			// 
			// Line340
			// 
			this.Line340.Height = 0F;
			this.Line340.Left = 0.2535F;
			this.Line340.LineWeight = 1F;
			this.Line340.Name = "Line340";
			this.Line340.Top = 6.1675F;
			this.Line340.Width = 1.1195F;
			this.Line340.X1 = 0.2535F;
			this.Line340.X2 = 1.373F;
			this.Line340.Y1 = 6.1675F;
			this.Line340.Y2 = 6.1675F;
			// 
			// Line341
			// 
			this.Line341.Height = 0F;
			this.Line341.Left = 0.0635004F;
			this.Line341.LineWeight = 1F;
			this.Line341.Name = "Line341";
			this.Line341.Top = 6.319F;
			this.Line341.Width = 2.503F;
			this.Line341.X1 = 0.0635004F;
			this.Line341.X2 = 2.5665F;
			this.Line341.Y1 = 6.319F;
			this.Line341.Y2 = 6.319F;
			// 
			// Line342
			// 
			this.Line342.Height = 1.725F;
			this.Line342.Left = 0.2530003F;
			this.Line342.LineWeight = 1F;
			this.Line342.Name = "Line342";
			this.Line342.Top = 4.594F;
			this.Line342.Width = 0F;
			this.Line342.X1 = 0.2530003F;
			this.Line342.X2 = 0.2530003F;
			this.Line342.Y1 = 4.594F;
			this.Line342.Y2 = 6.319F;
			// 
			// Line343
			// 
			this.Line343.Height = 0F;
			this.Line343.Left = 0.2535F;
			this.Line343.LineWeight = 1F;
			this.Line343.Name = "Line343";
			this.Line343.Top = 5.023F;
			this.Line343.Width = 1.1245F;
			this.Line343.X1 = 0.2535F;
			this.Line343.X2 = 1.378F;
			this.Line343.Y1 = 5.023F;
			this.Line343.Y2 = 5.023F;
			// 
			// Line344
			// 
			this.Line344.Height = 0F;
			this.Line344.Left = 0.2535F;
			this.Line344.LineWeight = 1F;
			this.Line344.Name = "Line344";
			this.Line344.Top = 5.309F;
			this.Line344.Width = 1.1245F;
			this.Line344.X1 = 0.2535F;
			this.Line344.X2 = 1.378F;
			this.Line344.Y1 = 5.309F;
			this.Line344.Y2 = 5.309F;
			// 
			// Line345
			// 
			this.Line345.Height = 0F;
			this.Line345.Left = 0.2535F;
			this.Line345.LineWeight = 1F;
			this.Line345.Name = "Line345";
			this.Line345.Top = 5.595F;
			this.Line345.Width = 1.1245F;
			this.Line345.X1 = 0.2535F;
			this.Line345.X2 = 1.378F;
			this.Line345.Y1 = 5.595F;
			this.Line345.Y2 = 5.595F;
			// 
			// Label60
			// 
			this.Label60.Height = 0.143F;
			this.Label60.HyperLink = null;
			this.Label60.Left = 0.2524996F;
			this.Label60.Name = "Label60";
			this.Label60.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label60.Text = "控除対象";
			this.Label60.Top = 4.737F;
			this.Label60.Width = 0.5F;
			// 
			// Line346
			// 
			this.Line346.Height = 1.001F;
			this.Line346.Left = 0.7519999F;
			this.Line346.LineWeight = 1F;
			this.Line346.Name = "Line346";
			this.Line346.Top = 4.594F;
			this.Line346.Width = 0F;
			this.Line346.X1 = 0.7519999F;
			this.Line346.X2 = 0.7519999F;
			this.Line346.Y1 = 4.594F;
			this.Line346.Y2 = 5.595F;
			// 
			// Line347
			// 
			this.Line347.Height = 1.725F;
			this.Line347.Left = 1.0645F;
			this.Line347.LineWeight = 1F;
			this.Line347.Name = "Line347";
			this.Line347.Top = 4.594F;
			this.Line347.Width = 0F;
			this.Line347.X1 = 1.0645F;
			this.Line347.X2 = 1.0645F;
			this.Line347.Y1 = 4.594F;
			this.Line347.Y2 = 6.319F;
			// 
			// Line348
			// 
			this.Line348.Height = 0F;
			this.Line348.Left = 0.7530003F;
			this.Line348.LineWeight = 1F;
			this.Line348.Name = "Line348";
			this.Line348.Top = 4.737F;
			this.Line348.Width = 0.6249997F;
			this.Line348.X1 = 0.7530003F;
			this.Line348.X2 = 1.378F;
			this.Line348.Y1 = 4.737F;
			this.Line348.Y2 = 4.737F;
			// 
			// Line349
			// 
			this.Line349.Height = 0F;
			this.Line349.Left = 0.7530003F;
			this.Line349.LineWeight = 1F;
			this.Line349.Name = "Line349";
			this.Line349.Top = 4.88F;
			this.Line349.Width = 0.6249997F;
			this.Line349.X1 = 0.7530003F;
			this.Line349.X2 = 1.378F;
			this.Line349.Y1 = 4.88F;
			this.Line349.Y2 = 4.88F;
			// 
			// Label61
			// 
			this.Label61.Height = 0.143F;
			this.Label61.HyperLink = null;
			this.Label61.Left = 0.7530003F;
			this.Label61.Name = "Label61";
			this.Label61.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label61.Text = "有";
			this.Label61.Top = 4.594F;
			this.Label61.Width = 0.313F;
			// 
			// Label62
			// 
			this.Label62.Height = 0.143F;
			this.Label62.HyperLink = null;
			this.Label62.Left = 0.7530003F;
			this.Label62.Name = "Label62";
			this.Label62.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label62.Text = "無";
			this.Label62.Top = 4.737F;
			this.Label62.Width = 0.313F;
			// 
			// Label63
			// 
			this.Label63.Height = 0.143F;
			this.Label63.HyperLink = null;
			this.Label63.Left = 0.7530003F;
			this.Label63.Name = "Label63";
			this.Label63.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label63.Text = "老人";
			this.Label63.Top = 4.88F;
			this.Label63.Width = 0.313F;
			// 
			// Label64
			// 
			this.Label64.Height = 0.286F;
			this.Label64.HyperLink = null;
			this.Label64.Left = 0.2524996F;
			this.Label64.Name = "Label64";
			this.Label64.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label64.Text = "障　　害";
			this.Label64.Top = 5.023F;
			this.Label64.Width = 0.5F;
			// 
			// Label65
			// 
			this.Label65.Height = 0.286F;
			this.Label65.HyperLink = null;
			this.Label65.Left = 0.2524996F;
			this.Label65.Name = "Label65";
			this.Label65.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label65.Text = "老　　親";
			this.Label65.Top = 5.309F;
			this.Label65.Width = 0.5F;
			// 
			// Line350
			// 
			this.Line350.Height = 0F;
			this.Line350.Left = 0.7530003F;
			this.Line350.LineWeight = 1F;
			this.Line350.Name = "Line350";
			this.Line350.Top = 5.166F;
			this.Line350.Width = 0.6249997F;
			this.Line350.X1 = 0.7530003F;
			this.Line350.X2 = 1.378F;
			this.Line350.Y1 = 5.166F;
			this.Line350.Y2 = 5.166F;
			// 
			// Line351
			// 
			this.Line351.Height = 0F;
			this.Line351.Left = 0.7530003F;
			this.Line351.LineWeight = 1F;
			this.Line351.Name = "Line351";
			this.Line351.Top = 5.452F;
			this.Line351.Width = 0.6249997F;
			this.Line351.X1 = 0.7530003F;
			this.Line351.X2 = 1.378F;
			this.Line351.Y1 = 5.452F;
			this.Line351.Y2 = 5.452F;
			// 
			// TextBox462
			// 
			this.TextBox462.DataField = "DED_SPOS_YES_NAME";
			this.TextBox462.Height = 0.143F;
			this.TextBox462.Left = 1.064F;
			this.TextBox462.Name = "TextBox462";
			this.TextBox462.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox462.Text = "あ";
			this.TextBox462.Top = 4.594F;
			this.TextBox462.Width = 0.3135004F;
			// 
			// TextBox463
			// 
			this.TextBox463.DataField = "DED_SPOS_NON_NAME";
			this.TextBox463.Height = 0.143F;
			this.TextBox463.Left = 1.065F;
			this.TextBox463.Name = "TextBox463";
			this.TextBox463.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox463.Text = "あ";
			this.TextBox463.Top = 4.737F;
			this.TextBox463.Width = 0.3125F;
			// 
			// TextBox464
			// 
			this.TextBox464.DataField = "SPOS_OLD_AGE_NAME";
			this.TextBox464.Height = 0.143F;
			this.TextBox464.Left = 1.065F;
			this.TextBox464.Name = "TextBox464";
			this.TextBox464.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox464.Text = "あ";
			this.TextBox464.Top = 4.88F;
			this.TextBox464.Width = 0.3125F;
			// 
			// TextBox465
			// 
			this.TextBox465.DataField = "HANDI_NUM";
			this.TextBox465.Height = 0.143F;
			this.TextBox465.Left = 1.065F;
			this.TextBox465.Name = "TextBox465";
			this.TextBox465.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox465.Text = "Z6";
			this.TextBox465.Top = 5.023F;
			this.TextBox465.Width = 0.3125F;
			// 
			// TextBox466
			// 
			this.TextBox466.DataField = "EXT_HANDI_NUM";
			this.TextBox466.Height = 0.143F;
			this.TextBox466.Left = 1.065F;
			this.TextBox466.Name = "TextBox466";
			this.TextBox466.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox466.Text = "Z6";
			this.TextBox466.Top = 5.166F;
			this.TextBox466.Width = 0.3125F;
			// 
			// TextBox467
			// 
			this.TextBox467.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.TextBox467.Height = 0.143F;
			this.TextBox467.Left = 1.065F;
			this.TextBox467.Name = "TextBox467";
			this.TextBox467.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox467.Text = "Z6";
			this.TextBox467.Top = 5.309F;
			this.TextBox467.Width = 0.3125F;
			// 
			// TextBox468
			// 
			this.TextBox468.DataField = "AGE_PRE_NUM";
			this.TextBox468.Height = 0.143F;
			this.TextBox468.Left = 1.065F;
			this.TextBox468.Name = "TextBox468";
			this.TextBox468.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox468.Text = "Z6";
			this.TextBox468.Top = 5.482F;
			this.TextBox468.Width = 0.3125F;
			// 
			// Line352
			// 
			this.Line352.Height = 1.7245F;
			this.Line352.Left = 1.3775F;
			this.Line352.LineWeight = 1F;
			this.Line352.Name = "Line352";
			this.Line352.Top = 4.594F;
			this.Line352.Width = 0F;
			this.Line352.X1 = 1.3775F;
			this.Line352.X2 = 1.3775F;
			this.Line352.Y1 = 4.594F;
			this.Line352.Y2 = 6.3185F;
			// 
			// Line353
			// 
			this.Line353.Height = 1.7245F;
			this.Line353.Left = 1.565F;
			this.Line353.LineWeight = 1F;
			this.Line353.Name = "Line353";
			this.Line353.Top = 4.594F;
			this.Line353.Width = 0F;
			this.Line353.X1 = 1.565F;
			this.Line353.X2 = 1.565F;
			this.Line353.Y1 = 4.594F;
			this.Line353.Y2 = 6.3185F;
			// 
			// Line354
			// 
			this.Line354.Height = 1.7245F;
			this.Line354.Left = 2.2535F;
			this.Line354.LineWeight = 1F;
			this.Line354.Name = "Line354";
			this.Line354.Top = 4.594F;
			this.Line354.Width = 0F;
			this.Line354.X1 = 2.2535F;
			this.Line354.X2 = 2.2535F;
			this.Line354.Y1 = 4.594F;
			this.Line354.Y2 = 6.3185F;
			// 
			// Label66
			// 
			this.Label66.Height = 0.286F;
			this.Label66.HyperLink = null;
			this.Label66.Left = 1.5635F;
			this.Label66.Name = "Label66";
			this.Label66.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label66.Text = "配偶者";
			this.Label66.Top = 4.594F;
			this.Label66.Width = 0.375F;
			// 
			// Label67
			// 
			this.Label67.Height = 0.143F;
			this.Label67.HyperLink = null;
			this.Label67.Left = 1.9385F;
			this.Label67.Name = "Label67";
			this.Label67.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label67.Text = "有";
			this.Label67.Top = 4.594F;
			this.Label67.Width = 0.3140001F;
			// 
			// Label68
			// 
			this.Label68.Height = 0.143F;
			this.Label68.HyperLink = null;
			this.Label68.Left = 1.9405F;
			this.Label68.Name = "Label68";
			this.Label68.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label68.Text = "無";
			this.Label68.Top = 4.737F;
			this.Label68.Width = 0.313F;
			// 
			// Line355
			// 
			this.Line355.Height = 0.2860003F;
			this.Line355.Left = 1.9395F;
			this.Line355.LineWeight = 1F;
			this.Line355.Name = "Line355";
			this.Line355.Top = 4.594F;
			this.Line355.Width = 0F;
			this.Line355.X1 = 1.9395F;
			this.Line355.X2 = 1.9395F;
			this.Line355.Y1 = 4.594F;
			this.Line355.Y2 = 4.88F;
			// 
			// Label69
			// 
			this.Label69.Height = 0.143F;
			this.Label69.HyperLink = null;
			this.Label69.Left = 1.5645F;
			this.Label69.Name = "Label69";
			this.Label69.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label69.Text = "普通障害";
			this.Label69.Top = 4.88F;
			this.Label69.Width = 0.688F;
			// 
			// Label70
			// 
			this.Label70.Height = 0.143F;
			this.Label70.HyperLink = null;
			this.Label70.Left = 1.5645F;
			this.Label70.Name = "Label70";
			this.Label70.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label70.Text = "特別障害";
			this.Label70.Top = 5.023F;
			this.Label70.Width = 0.688F;
			// 
			// Label73
			// 
			this.Label73.Height = 0.143F;
			this.Label73.HyperLink = null;
			this.Label73.Left = 1.565F;
			this.Label73.Name = "Label73";
			this.Label73.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label73.Text = "寡　　夫";
			this.Label73.Top = 5.3135F;
			this.Label73.Width = 0.688F;
			// 
			// Label74
			// 
			this.Label74.Height = 0.143F;
			this.Label74.HyperLink = null;
			this.Label74.Left = 1.565F;
			this.Label74.Name = "Label74";
			this.Label74.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label74.Text = "特別寡婦";
			this.Label74.Top = 5.4565F;
			this.Label74.Width = 0.688F;
			// 
			// Label75
			// 
			this.Label75.Height = 0.143F;
			this.Label75.HyperLink = null;
			this.Label75.Left = 1.565F;
			this.Label75.Name = "Label75";
			this.Label75.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label75.Text = "勤労学生";
			this.Label75.Top = 5.5995F;
			this.Label75.Width = 0.688F;
			// 
			// Label76
			// 
			this.Label76.Height = 0.143F;
			this.Label76.HyperLink = null;
			this.Label76.Left = 1.565F;
			this.Label76.Name = "Label76";
			this.Label76.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label76.Text = "未 成 年";
			this.Label76.Top = 5.7435F;
			this.Label76.Width = 0.688F;
			// 
			// TextBox469
			// 
			this.TextBox469.DataField = "WIDOW_2_NAME";
			this.TextBox469.Height = 0.143F;
			this.TextBox469.Left = 2.253F;
			this.TextBox469.Name = "TextBox469";
			this.TextBox469.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox469.Text = "あ";
			this.TextBox469.Top = 5.3135F;
			this.TextBox469.Width = 0.3125F;
			// 
			// TextBox472
			// 
			this.TextBox472.DataField = "EXT_HANDI_NAME";
			this.TextBox472.Height = 0.143F;
			this.TextBox472.Left = 2.2525F;
			this.TextBox472.Name = "TextBox472";
			this.TextBox472.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox472.Text = "あ";
			this.TextBox472.Top = 5.023F;
			this.TextBox472.Width = 0.3125F;
			// 
			// TextBox473
			// 
			this.TextBox473.DataField = "HANDI_NAME";
			this.TextBox473.Height = 0.143F;
			this.TextBox473.Left = 2.2525F;
			this.TextBox473.Name = "TextBox473";
			this.TextBox473.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox473.Text = "あ";
			this.TextBox473.Top = 4.88F;
			this.TextBox473.Width = 0.3125F;
			// 
			// TextBox474
			// 
			this.TextBox474.DataField = "SPOS_NON";
			this.TextBox474.Height = 0.143F;
			this.TextBox474.Left = 2.2525F;
			this.TextBox474.Name = "TextBox474";
			this.TextBox474.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox474.Text = "あ";
			this.TextBox474.Top = 4.737F;
			this.TextBox474.Width = 0.3125F;
			// 
			// TextBox475
			// 
			this.TextBox475.DataField = "SPOS_YES";
			this.TextBox475.Height = 0.143F;
			this.TextBox475.Left = 2.2525F;
			this.TextBox475.Name = "TextBox475";
			this.TextBox475.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox475.Text = "あ";
			this.TextBox475.Top = 4.594F;
			this.TextBox475.Width = 0.3125F;
			// 
			// Label77
			// 
			this.Label77.Height = 0.143F;
			this.Label77.HyperLink = null;
			this.Label77.Left = 0.7530003F;
			this.Label77.Name = "Label77";
			this.Label77.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label77.Text = "普通";
			this.Label77.Top = 5.023F;
			this.Label77.Width = 0.313F;
			// 
			// Label78
			// 
			this.Label78.Height = 0.1395001F;
			this.Label78.HyperLink = null;
			this.Label78.Left = 0.7524996F;
			this.Label78.Name = "Label78";
			this.Label78.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label78.Text = "特別";
			this.Label78.Top = 5.1695F;
			this.Label78.Width = 0.3125F;
			// 
			// Label79
			// 
			this.Label79.Height = 0.143F;
			this.Label79.HyperLink = null;
			this.Label79.Left = 0.7530003F;
			this.Label79.Name = "Label79";
			this.Label79.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label79.Text = "同居";
			this.Label79.Top = 5.309F;
			this.Label79.Width = 0.313F;
			// 
			// Label80
			// 
			this.Label80.Height = 0.143F;
			this.Label80.HyperLink = null;
			this.Label80.Left = 0.7530003F;
			this.Label80.Name = "Label80";
			this.Label80.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label80.Text = "総数";
			this.Label80.Top = 5.452F;
			this.Label80.Width = 0.313F;
			// 
			// Line356
			// 
			this.Line356.Height = 0F;
			this.Line356.Left = 0.2535F;
			this.Line356.LineWeight = 1F;
			this.Line356.Name = "Line356";
			this.Line356.Top = 5.738F;
			this.Line356.Width = 1.1245F;
			this.Line356.X1 = 0.2535F;
			this.Line356.X2 = 1.378F;
			this.Line356.Y1 = 5.738F;
			this.Line356.Y2 = 5.738F;
			// 
			// Line357
			// 
			this.Line357.Height = 0F;
			this.Line357.Left = 0.2535F;
			this.Line357.LineWeight = 1F;
			this.Line357.Name = "Line357";
			this.Line357.Top = 5.881F;
			this.Line357.Width = 1.1245F;
			this.Line357.X1 = 0.2535F;
			this.Line357.X2 = 1.378F;
			this.Line357.Y1 = 5.881F;
			this.Line357.Y2 = 5.881F;
			// 
			// Label81
			// 
			this.Label81.Height = 0.143F;
			this.Label81.HyperLink = null;
			this.Label81.Left = 0.2530003F;
			this.Label81.Name = "Label81";
			this.Label81.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label81.Text = "同特別障害";
			this.Label81.Top = 5.595F;
			this.Label81.Width = 0.813F;
			// 
			// Label82
			// 
			this.Label82.Height = 0.1489997F;
			this.Label82.HyperLink = null;
			this.Label82.Left = 0.2530003F;
			this.Label82.Name = "Label82";
			this.Label82.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label82.Text = "特 定 扶 養";
			this.Label82.Top = 5.738F;
			this.Label82.Width = 0.8125F;
			// 
			// TextBox476
			// 
			this.TextBox476.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.TextBox476.Height = 0.143F;
			this.TextBox476.Left = 1.065F;
			this.TextBox476.Name = "TextBox476";
			this.TextBox476.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox476.Text = "Z6";
			this.TextBox476.Top = 5.595F;
			this.TextBox476.Width = 0.3125F;
			// 
			// TextBox477
			// 
			this.TextBox477.DataField = "SPEC_DPND_NUM";
			this.TextBox477.Height = 0.143F;
			this.TextBox477.Left = 1.065F;
			this.TextBox477.Name = "TextBox477";
			this.TextBox477.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox477.Text = "Z6";
			this.TextBox477.Top = 5.738F;
			this.TextBox477.Width = 0.3125F;
			// 
			// TextBox478
			// 
			this.TextBox478.DataField = "DPND_TOTAL_NUM";
			this.TextBox478.Height = 0.143F;
			this.TextBox478.Left = 1.065F;
			this.TextBox478.Name = "TextBox478";
			this.TextBox478.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox478.Text = "Z6";
			this.TextBox478.Top = 5.9565F;
			this.TextBox478.Width = 0.3125F;
			// 
			// TextBox479
			// 
			this.TextBox479.DataField = "WIDOW_3_NAME";
			this.TextBox479.Height = 0.143F;
			this.TextBox479.Left = 2.253F;
			this.TextBox479.Name = "TextBox479";
			this.TextBox479.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox479.Text = "あ";
			this.TextBox479.Top = 5.4565F;
			this.TextBox479.Width = 0.3125F;
			// 
			// TextBox480
			// 
			this.TextBox480.DataField = "WRK_STD_NAME";
			this.TextBox480.Height = 0.143F;
			this.TextBox480.Left = 2.253F;
			this.TextBox480.Name = "TextBox480";
			this.TextBox480.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox480.Text = "あ";
			this.TextBox480.Top = 5.5995F;
			this.TextBox480.Width = 0.3125F;
			// 
			// TextBox481
			// 
			this.TextBox481.DataField = "MINR_NAME";
			this.TextBox481.Height = 0.143F;
			this.TextBox481.Left = 2.253F;
			this.TextBox481.Name = "TextBox481";
			this.TextBox481.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox481.Text = "あ";
			this.TextBox481.Top = 5.7435F;
			this.TextBox481.Width = 0.3125F;
			// 
			// Line394
			// 
			this.Line394.Height = 0F;
			this.Line394.Left = 1.565F;
			this.Line394.LineWeight = 1F;
			this.Line394.Name = "Line394";
			this.Line394.Top = 4.88F;
			this.Line394.Width = 1.001F;
			this.Line394.X1 = 1.565F;
			this.Line394.X2 = 2.566F;
			this.Line394.Y1 = 4.88F;
			this.Line394.Y2 = 4.88F;
			// 
			// Line395
			// 
			this.Line395.Height = 0F;
			this.Line395.Left = 1.565F;
			this.Line395.LineWeight = 1F;
			this.Line395.Name = "Line395";
			this.Line395.Top = 5.023F;
			this.Line395.Width = 1.001F;
			this.Line395.X1 = 1.565F;
			this.Line395.X2 = 2.566F;
			this.Line395.Y1 = 5.023F;
			this.Line395.Y2 = 5.023F;
			// 
			// Line396
			// 
			this.Line396.Height = 0F;
			this.Line396.Left = 1.565F;
			this.Line396.LineWeight = 1F;
			this.Line396.Name = "Line396";
			this.Line396.Top = 5.166F;
			this.Line396.Width = 1.001F;
			this.Line396.X1 = 1.565F;
			this.Line396.X2 = 2.566F;
			this.Line396.Y1 = 5.166F;
			this.Line396.Y2 = 5.166F;
			// 
			// Line397
			// 
			this.Line397.Height = 0F;
			this.Line397.Left = 1.565F;
			this.Line397.LineWeight = 1F;
			this.Line397.Name = "Line397";
			this.Line397.Top = 5.309F;
			this.Line397.Width = 1.001F;
			this.Line397.X1 = 1.565F;
			this.Line397.X2 = 2.566F;
			this.Line397.Y1 = 5.309F;
			this.Line397.Y2 = 5.309F;
			// 
			// Line398
			// 
			this.Line398.Height = 0F;
			this.Line398.Left = 1.565F;
			this.Line398.LineWeight = 1F;
			this.Line398.Name = "Line398";
			this.Line398.Top = 5.452F;
			this.Line398.Width = 1.001F;
			this.Line398.X1 = 1.565F;
			this.Line398.X2 = 2.566F;
			this.Line398.Y1 = 5.452F;
			this.Line398.Y2 = 5.452F;
			// 
			// Line399
			// 
			this.Line399.Height = 0F;
			this.Line399.Left = 1.565F;
			this.Line399.LineWeight = 1F;
			this.Line399.Name = "Line399";
			this.Line399.Top = 5.595F;
			this.Line399.Width = 1.001F;
			this.Line399.X1 = 1.565F;
			this.Line399.X2 = 2.566F;
			this.Line399.Y1 = 5.595F;
			this.Line399.Y2 = 5.595F;
			// 
			// Line400
			// 
			this.Line400.Height = 0F;
			this.Line400.Left = 1.565F;
			this.Line400.LineWeight = 1F;
			this.Line400.Name = "Line400";
			this.Line400.Top = 5.738F;
			this.Line400.Width = 1.001F;
			this.Line400.X1 = 1.565F;
			this.Line400.X2 = 2.566F;
			this.Line400.Y1 = 5.738F;
			this.Line400.Y2 = 5.738F;
			// 
			// Line401
			// 
			this.Line401.Height = 0F;
			this.Line401.Left = 1.565F;
			this.Line401.LineWeight = 1F;
			this.Line401.Name = "Line401";
			this.Line401.Top = 5.881F;
			this.Line401.Width = 1.001F;
			this.Line401.X1 = 1.565F;
			this.Line401.X2 = 2.566F;
			this.Line401.Y1 = 5.881F;
			this.Line401.Y2 = 5.881F;
			// 
			// Label114
			// 
			this.Label114.Height = 0.1849999F;
			this.Label114.HyperLink = null;
			this.Label114.Left = 0.06499958F;
			this.Label114.Name = "Label114";
			this.Label114.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label114.Text = "扶";
			this.Label114.Top = 4.594F;
			this.Label114.Width = 0.1859999F;
			// 
			// Label115
			// 
			this.Label115.Height = 0.1849999F;
			this.Label115.HyperLink = null;
			this.Label115.Left = 0.06700039F;
			this.Label115.Name = "Label115";
			this.Label115.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label115.Text = "養";
			this.Label115.Top = 4.779F;
			this.Label115.Width = 0.1859999F;
			// 
			// Label116
			// 
			this.Label116.Height = 0.1849999F;
			this.Label116.HyperLink = null;
			this.Label116.Left = 0.06700039F;
			this.Label116.Name = "Label116";
			this.Label116.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label116.Text = "控";
			this.Label116.Top = 4.964F;
			this.Label116.Width = 0.1859999F;
			// 
			// Label117
			// 
			this.Label117.Height = 0.1849999F;
			this.Label117.HyperLink = null;
			this.Label117.Left = 0.06700039F;
			this.Label117.Name = "Label117";
			this.Label117.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label117.Text = "除";
			this.Label117.Top = 5.148999F;
			this.Label117.Width = 0.1859999F;
			// 
			// Label118
			// 
			this.Label118.Height = 0.1849999F;
			this.Label118.HyperLink = null;
			this.Label118.Left = 0.06700039F;
			this.Label118.Name = "Label118";
			this.Label118.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label118.Text = "等";
			this.Label118.Top = 5.334F;
			this.Label118.Width = 0.1859999F;
			// 
			// Label119
			// 
			this.Label119.Height = 0.1849999F;
			this.Label119.HyperLink = null;
			this.Label119.Left = 0.06700039F;
			this.Label119.Name = "Label119";
			this.Label119.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label119.Text = "申";
			this.Label119.Top = 5.519F;
			this.Label119.Width = 0.1859999F;
			// 
			// Label120
			// 
			this.Label120.Height = 0.1849999F;
			this.Label120.HyperLink = null;
			this.Label120.Left = 0.06700039F;
			this.Label120.Name = "Label120";
			this.Label120.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label120.Text = "告";
			this.Label120.Top = 5.704F;
			this.Label120.Width = 0.1859999F;
			// 
			// Label121
			// 
			this.Label121.Height = 0.185F;
			this.Label121.HyperLink = null;
			this.Label121.Left = 1.3775F;
			this.Label121.Name = "Label121";
			this.Label121.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label121.Text = "本";
			this.Label121.Top = 4.594F;
			this.Label121.Width = 0.188F;
			// 
			// Label122
			// 
			this.Label122.Height = 0.185F;
			this.Label122.HyperLink = null;
			this.Label122.Left = 1.378F;
			this.Label122.Name = "Label122";
			this.Label122.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label122.Text = "人";
			this.Label122.Top = 4.7795F;
			this.Label122.Width = 0.188F;
			// 
			// Label123
			// 
			this.Label123.Height = 0.185F;
			this.Label123.HyperLink = null;
			this.Label123.Left = 1.378F;
			this.Label123.Name = "Label123";
			this.Label123.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label123.Text = "控";
			this.Label123.Top = 4.9645F;
			this.Label123.Width = 0.188F;
			// 
			// Label124
			// 
			this.Label124.Height = 0.185F;
			this.Label124.HyperLink = null;
			this.Label124.Left = 1.378F;
			this.Label124.Name = "Label124";
			this.Label124.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label124.Text = "除";
			this.Label124.Top = 5.148499F;
			this.Label124.Width = 0.188F;
			// 
			// Label125
			// 
			this.Label125.Height = 0.185F;
			this.Label125.HyperLink = null;
			this.Label125.Left = 1.378F;
			this.Label125.Name = "Label125";
			this.Label125.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label125.Text = "等";
			this.Label125.Top = 5.3345F;
			this.Label125.Width = 0.188F;
			// 
			// Label126
			// 
			this.Label126.Height = 0.185F;
			this.Label126.HyperLink = null;
			this.Label126.Left = 1.378F;
			this.Label126.Name = "Label126";
			this.Label126.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label126.Text = "申";
			this.Label126.Top = 5.5195F;
			this.Label126.Width = 0.188F;
			// 
			// Label127
			// 
			this.Label127.Height = 0.185F;
			this.Label127.HyperLink = null;
			this.Label127.Left = 1.378F;
			this.Label127.Name = "Label127";
			this.Label127.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label127.Text = "告";
			this.Label127.Top = 5.704499F;
			this.Label127.Width = 0.188F;
			// 
			// Line406
			// 
			this.Line406.Height = 0F;
			this.Line406.Left = 1.94F;
			this.Line406.LineWeight = 1F;
			this.Line406.Name = "Line406";
			this.Line406.Top = 4.737F;
			this.Line406.Width = 0.6259999F;
			this.Line406.X1 = 1.94F;
			this.Line406.X2 = 2.566F;
			this.Line406.Y1 = 4.737F;
			this.Line406.Y2 = 4.737F;
			// 
			// Label137
			// 
			this.Label137.Height = 0.143F;
			this.Label137.HyperLink = null;
			this.Label137.Left = 0.26F;
			this.Label137.Name = "Label137";
			this.Label137.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label137.Text = "配";
			this.Label137.Top = 4.88F;
			this.Label137.Width = 0.1875F;
			// 
			// DtyZeroFlg1
			// 
			this.DtyZeroFlg1.DataField = "DTY_ZERO_FLG1";
			this.DtyZeroFlg1.Height = 0.143F;
			this.DtyZeroFlg1.Left = 0.06499958F;
			this.DtyZeroFlg1.Name = "DtyZeroFlg1";
			this.DtyZeroFlg1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg1.Text = null;
			this.DtyZeroFlg1.Top = 0.3040001F;
			this.DtyZeroFlg1.Visible = false;
			this.DtyZeroFlg1.Width = 0.5625F;
			// 
			// DtyZeroFlg2
			// 
			this.DtyZeroFlg2.DataField = "DTY_ZERO_FLG2";
			this.DtyZeroFlg2.Height = 0.143F;
			this.DtyZeroFlg2.Left = 0.8774996F;
			this.DtyZeroFlg2.Name = "DtyZeroFlg2";
			this.DtyZeroFlg2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg2.Text = null;
			this.DtyZeroFlg2.Top = 0.3040001F;
			this.DtyZeroFlg2.Visible = false;
			this.DtyZeroFlg2.Width = 0.5625F;
			// 
			// DtyZeroFlg3
			// 
			this.DtyZeroFlg3.DataField = "DTY_ZERO_FLG3";
			this.DtyZeroFlg3.Height = 0.143F;
			this.DtyZeroFlg3.Left = 1.44F;
			this.DtyZeroFlg3.Name = "DtyZeroFlg3";
			this.DtyZeroFlg3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg3.Text = null;
			this.DtyZeroFlg3.Top = 0.2945F;
			this.DtyZeroFlg3.Visible = false;
			this.DtyZeroFlg3.Width = 0.5625F;
			// 
			// DtyZeroFlg4
			// 
			this.DtyZeroFlg4.DataField = "DTY_ZERO_FLG4";
			this.DtyZeroFlg4.Height = 0.143F;
			this.DtyZeroFlg4.Left = 2.0025F;
			this.DtyZeroFlg4.Name = "DtyZeroFlg4";
			this.DtyZeroFlg4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg4.Text = null;
			this.DtyZeroFlg4.Top = 0.3040001F;
			this.DtyZeroFlg4.Visible = false;
			this.DtyZeroFlg4.Width = 0.5625F;
			// 
			// DtyZeroFlg5
			// 
			this.DtyZeroFlg5.DataField = "DTY_ZERO_FLG5";
			this.DtyZeroFlg5.Height = 0.143F;
			this.DtyZeroFlg5.Left = 0.3149996F;
			this.DtyZeroFlg5.Name = "DtyZeroFlg5";
			this.DtyZeroFlg5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg5.Text = null;
			this.DtyZeroFlg5.Top = 0.4195F;
			this.DtyZeroFlg5.Visible = false;
			this.DtyZeroFlg5.Width = 0.5625F;
			// 
			// DtyZeroFlg6
			// 
			this.DtyZeroFlg6.DataField = "DTY_ZERO_FLG6";
			this.DtyZeroFlg6.Height = 0.143F;
			this.DtyZeroFlg6.Left = 0.8774996F;
			this.DtyZeroFlg6.Name = "DtyZeroFlg6";
			this.DtyZeroFlg6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg6.Text = null;
			this.DtyZeroFlg6.Top = 0.447F;
			this.DtyZeroFlg6.Visible = false;
			this.DtyZeroFlg6.Width = 0.5625F;
			// 
			// DtyZeroFlg7
			// 
			this.DtyZeroFlg7.DataField = "DTY_ZERO_FLG7";
			this.DtyZeroFlg7.Height = 0.143F;
			this.DtyZeroFlg7.Left = 1.44F;
			this.DtyZeroFlg7.Name = "DtyZeroFlg7";
			this.DtyZeroFlg7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg7.Text = null;
			this.DtyZeroFlg7.Top = 0.447F;
			this.DtyZeroFlg7.Visible = false;
			this.DtyZeroFlg7.Width = 0.5625F;
			// 
			// DtyZeroFlg8
			// 
			this.DtyZeroFlg8.DataField = "DTY_ZERO_FLG8";
			this.DtyZeroFlg8.Height = 0.143F;
			this.DtyZeroFlg8.Left = 2.0025F;
			this.DtyZeroFlg8.Name = "DtyZeroFlg8";
			this.DtyZeroFlg8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyZeroFlg8.Text = null;
			this.DtyZeroFlg8.Top = 0.447F;
			this.DtyZeroFlg8.Visible = false;
			this.DtyZeroFlg8.Width = 0.5625F;
			// 
			// DtyItemId1
			// 
			this.DtyItemId1.DataField = "DTY_ITEM_ID1";
			this.DtyItemId1.Height = 0.143F;
			this.DtyItemId1.Left = 0.3149996F;
			this.DtyItemId1.Name = "DtyItemId1";
			this.DtyItemId1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId1.Text = null;
			this.DtyItemId1.Top = 0.59F;
			this.DtyItemId1.Visible = false;
			this.DtyItemId1.Width = 0.5625F;
			// 
			// DtyItemId5
			// 
			this.DtyItemId5.DataField = "DTY_ITEM_ID5";
			this.DtyItemId5.Height = 0.143F;
			this.DtyItemId5.Left = 0.3149996F;
			this.DtyItemId5.Name = "DtyItemId5";
			this.DtyItemId5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId5.Text = null;
			this.DtyItemId5.Top = 0.732F;
			this.DtyItemId5.Visible = false;
			this.DtyItemId5.Width = 0.5625F;
			// 
			// DtyItemId6
			// 
			this.DtyItemId6.DataField = "DTY_ITEM_ID6";
			this.DtyItemId6.Height = 0.143F;
			this.DtyItemId6.Left = 0.8774996F;
			this.DtyItemId6.Name = "DtyItemId6";
			this.DtyItemId6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId6.Text = null;
			this.DtyItemId6.Top = 0.732F;
			this.DtyItemId6.Visible = false;
			this.DtyItemId6.Width = 0.5625F;
			// 
			// DtyItemId2
			// 
			this.DtyItemId2.DataField = "DTY_ITEM_ID2";
			this.DtyItemId2.Height = 0.143F;
			this.DtyItemId2.Left = 0.8774996F;
			this.DtyItemId2.Name = "DtyItemId2";
			this.DtyItemId2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId2.Text = null;
			this.DtyItemId2.Top = 0.59F;
			this.DtyItemId2.Visible = false;
			this.DtyItemId2.Width = 0.5625F;
			// 
			// DtyItemId8
			// 
			this.DtyItemId8.DataField = "DTY_ITEM_ID8";
			this.DtyItemId8.Height = 0.143F;
			this.DtyItemId8.Left = 2.0025F;
			this.DtyItemId8.Name = "DtyItemId8";
			this.DtyItemId8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId8.Text = null;
			this.DtyItemId8.Top = 0.733F;
			this.DtyItemId8.Visible = false;
			this.DtyItemId8.Width = 0.5625F;
			// 
			// DtyItemId4
			// 
			this.DtyItemId4.DataField = "DTY_ITEM_ID4";
			this.DtyItemId4.Height = 0.143F;
			this.DtyItemId4.Left = 2.0025F;
			this.DtyItemId4.Name = "DtyItemId4";
			this.DtyItemId4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId4.Text = null;
			this.DtyItemId4.Top = 0.59F;
			this.DtyItemId4.Visible = false;
			this.DtyItemId4.Width = 0.5625F;
			// 
			// DtyItemId3
			// 
			this.DtyItemId3.DataField = "DTY_ITEM_ID3";
			this.DtyItemId3.Height = 0.143F;
			this.DtyItemId3.Left = 1.44F;
			this.DtyItemId3.Name = "DtyItemId3";
			this.DtyItemId3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId3.Text = null;
			this.DtyItemId3.Top = 0.59F;
			this.DtyItemId3.Visible = false;
			this.DtyItemId3.Width = 0.5625F;
			// 
			// DtyItemId7
			// 
			this.DtyItemId7.DataField = "DTY_ITEM_ID7";
			this.DtyItemId7.Height = 0.143F;
			this.DtyItemId7.Left = 1.44F;
			this.DtyItemId7.Name = "DtyItemId7";
			this.DtyItemId7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemId7.Text = null;
			this.DtyItemId7.Top = 0.732F;
			this.DtyItemId7.Visible = false;
			this.DtyItemId7.Width = 0.5625F;
			// 
			// DtyDispType1
			// 
			this.DtyDispType1.DataField = "DTY_DISP_TYPE1";
			this.DtyDispType1.Height = 0.143F;
			this.DtyDispType1.Left = 0.3149996F;
			this.DtyDispType1.Name = "DtyDispType1";
			this.DtyDispType1.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType1.Text = null;
			this.DtyDispType1.Top = 0.876F;
			this.DtyDispType1.Visible = false;
			this.DtyDispType1.Width = 0.5625F;
			// 
			// DtyDispType5
			// 
			this.DtyDispType5.DataField = "DTY_DISP_TYPE5";
			this.DtyDispType5.Height = 0.143F;
			this.DtyDispType5.Left = 0.3149996F;
			this.DtyDispType5.Name = "DtyDispType5";
			this.DtyDispType5.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType5.Text = null;
			this.DtyDispType5.Top = 1.019F;
			this.DtyDispType5.Visible = false;
			this.DtyDispType5.Width = 0.5625F;
			// 
			// DtyDispType2
			// 
			this.DtyDispType2.DataField = "DTY_DISP_TYPE2";
			this.DtyDispType2.Height = 0.143F;
			this.DtyDispType2.Left = 0.8774996F;
			this.DtyDispType2.Name = "DtyDispType2";
			this.DtyDispType2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType2.Text = null;
			this.DtyDispType2.Top = 0.876F;
			this.DtyDispType2.Visible = false;
			this.DtyDispType2.Width = 0.5625F;
			// 
			// DtyDispType6
			// 
			this.DtyDispType6.DataField = "DTY_DISP_TYPE6";
			this.DtyDispType6.Height = 0.143F;
			this.DtyDispType6.Left = 0.8774996F;
			this.DtyDispType6.Name = "DtyDispType6";
			this.DtyDispType6.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType6.Text = null;
			this.DtyDispType6.Top = 1.019F;
			this.DtyDispType6.Visible = false;
			this.DtyDispType6.Width = 0.5625F;
			// 
			// DtyDispType3
			// 
			this.DtyDispType3.DataField = "DTY_DISP_TYPE3";
			this.DtyDispType3.Height = 0.143F;
			this.DtyDispType3.Left = 1.44F;
			this.DtyDispType3.Name = "DtyDispType3";
			this.DtyDispType3.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType3.Text = null;
			this.DtyDispType3.Top = 0.876F;
			this.DtyDispType3.Visible = false;
			this.DtyDispType3.Width = 0.5625F;
			// 
			// DtyDispType4
			// 
			this.DtyDispType4.DataField = "DTY_DISP_TYPE4";
			this.DtyDispType4.Height = 0.143F;
			this.DtyDispType4.Left = 2.0025F;
			this.DtyDispType4.Name = "DtyDispType4";
			this.DtyDispType4.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType4.Text = null;
			this.DtyDispType4.Top = 0.876F;
			this.DtyDispType4.Visible = false;
			this.DtyDispType4.Width = 0.5625F;
			// 
			// DtyDispType7
			// 
			this.DtyDispType7.DataField = "DTY_DISP_TYPE7";
			this.DtyDispType7.Height = 0.143F;
			this.DtyDispType7.Left = 1.44F;
			this.DtyDispType7.Name = "DtyDispType7";
			this.DtyDispType7.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType7.Text = null;
			this.DtyDispType7.Top = 1.019F;
			this.DtyDispType7.Visible = false;
			this.DtyDispType7.Width = 0.5625F;
			// 
			// DtyDispType8
			// 
			this.DtyDispType8.DataField = "DTY_DISP_TYPE8";
			this.DtyDispType8.Height = 0.143F;
			this.DtyDispType8.Left = 2.0025F;
			this.DtyDispType8.Name = "DtyDispType8";
			this.DtyDispType8.Style = "font-size: 7pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.DtyDispType8.Text = null;
			this.DtyDispType8.Top = 1.019F;
			this.DtyDispType8.Visible = false;
			this.DtyDispType8.Width = 0.5625F;
			// 
			// Label138
			// 
			this.Label138.Height = 0.143F;
			this.Label138.HyperLink = null;
			this.Label138.Left = 1.565F;
			this.Label138.Name = "Label138";
			this.Label138.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label138.Text = "外 国 人";
			this.Label138.Top = 5.8765F;
			this.Label138.Width = 0.688F;
			// 
			// Label139
			// 
			this.Label139.Height = 0.143F;
			this.Label139.HyperLink = null;
			this.Label139.Left = 1.565F;
			this.Label139.Name = "Label139";
			this.Label139.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label139.Text = "災 害 者";
			this.Label139.Top = 6.0295F;
			this.Label139.Width = 0.688F;
			// 
			// TextBox672
			// 
			this.TextBox672.DataField = "FOREIGN_NAME";
			this.TextBox672.Height = 0.143F;
			this.TextBox672.Left = 2.253F;
			this.TextBox672.Name = "TextBox672";
			this.TextBox672.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox672.Text = "あ";
			this.TextBox672.Top = 5.8765F;
			this.TextBox672.Width = 0.3125F;
			// 
			// TextBox673
			// 
			this.TextBox673.DataField = "DISASTER_NAME";
			this.TextBox673.Height = 0.143F;
			this.TextBox673.Left = 2.253F;
			this.TextBox673.Name = "TextBox673";
			this.TextBox673.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox673.Text = "あ";
			this.TextBox673.Top = 6.0255F;
			this.TextBox673.Width = 0.3125F;
			// 
			// Line407
			// 
			this.Line407.Height = 0F;
			this.Line407.Left = 1.565F;
			this.Line407.LineWeight = 1F;
			this.Line407.Name = "Line407";
			this.Line407.Top = 6.0245F;
			this.Line407.Width = 1.001F;
			this.Line407.X1 = 1.565F;
			this.Line407.X2 = 2.566F;
			this.Line407.Y1 = 6.0245F;
			this.Line407.Y2 = 6.0245F;
			// 
			// Line408
			// 
			this.Line408.Height = 0F;
			this.Line408.Left = 1.565F;
			this.Line408.LineWeight = 1F;
			this.Line408.Name = "Line408";
			this.Line408.Top = 6.1675F;
			this.Line408.Width = 1.001F;
			this.Line408.X1 = 1.565F;
			this.Line408.X2 = 2.566F;
			this.Line408.Y1 = 6.1675F;
			this.Line408.Y2 = 6.1675F;
			// 
			// Dty8Num2
			// 
			this.Dty8Num2.DataField = "DTY_8NUM2";
			this.Dty8Num2.Height = 0.143F;
			this.Dty8Num2.Left = 0.8780003F;
			this.Dty8Num2.Name = "Dty8Num2";
			this.Dty8Num2.OutputFormat = "#,##0.00";
			this.Dty8Num2.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.Dty8Num2.Text = "ZZZ6.66";
			this.Dty8Num2.Top = 2.3065F;
			this.Dty8Num2.Width = 0.5625F;
			// 
			// Label140
			// 
			this.Label140.Height = 0.143F;
			this.Label140.HyperLink = null;
			this.Label140.Left = 0.4099998F;
			this.Label140.Name = "Label140";
			this.Label140.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label140.Text = "偶";
			this.Label140.Top = 4.88F;
			this.Label140.Width = 0.188F;
			// 
			// Label141
			// 
			this.Label141.Height = 0.143F;
			this.Label141.HyperLink = null;
			this.Label141.Left = 0.5500002F;
			this.Label141.Name = "Label141";
			this.Label141.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label141.Text = "者";
			this.Label141.Top = 4.88F;
			this.Label141.Width = 0.188F;
			// 
			// Label142
			// 
			this.Label142.Height = 0.1629996F;
			this.Label142.HyperLink = null;
			this.Label142.Left = 0.2530003F;
			this.Label142.Name = "Label142";
			this.Label142.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label142.Text = "（配偶者を除く）";
			this.Label142.Top = 6.0065F;
			this.Label142.Width = 0.813F;
			// 
			// Label143
			// 
			this.Label143.Height = 0.1629996F;
			this.Label143.HyperLink = null;
			this.Label143.Left = 0.2530003F;
			this.Label143.Name = "Label143";
			this.Label143.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label143.Text = "総　人　数";
			this.Label143.Top = 5.8815F;
			this.Label143.Width = 0.813F;
			// 
			// Label144
			// 
			this.Label144.Height = 0.143F;
			this.Label144.HyperLink = null;
			this.Label144.Left = 1.565F;
			this.Label144.Name = "Label144";
			this.Label144.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label144.Text = "寡　　婦";
			this.Label144.Top = 5.1705F;
			this.Label144.Width = 0.688F;
			// 
			// TextBox674
			// 
			this.TextBox674.DataField = "WIDOW_NAME";
			this.TextBox674.Height = 0.143F;
			this.TextBox674.Left = 2.253F;
			this.TextBox674.Name = "TextBox674";
			this.TextBox674.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox674.Text = "あ";
			this.TextBox674.Top = 5.1705F;
			this.TextBox674.Width = 0.313F;
			// 
			// Label148
			// 
			this.Label148.Height = 0.125F;
			this.Label148.HyperLink = null;
			this.Label148.Left = 0.1875F;
			this.Label148.Name = "Label148";
			this.Label148.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label148.Text = "損害保険控除は地震保険控除に含まれています。";
			this.Label148.Top = 6.732F;
			this.Label148.Width = 2.375F;
			// 
			// Label149
			// 
			this.Label149.Height = 0.1629996F;
			this.Label149.HyperLink = null;
			this.Label149.Left = 0.0625F;
			this.Label149.Name = "Label149";
			this.Label149.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label149.Text = "※";
			this.Label149.Top = 6.732F;
			this.Label149.Width = 0.125F;
			// 
			// Label150
			// 
			this.Label150.Height = 0.125F;
			this.Label150.HyperLink = null;
			this.Label150.Left = 0.1875F;
			this.Label150.Name = "Label150";
			this.Label150.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label150.Text = "経過措置として平成18年12月31日までに締結した「長";
			this.Label150.Top = 6.357F;
			this.Label150.Width = 2.375F;
			// 
			// Label151
			// 
			this.Label151.Height = 0.125F;
			this.Label151.HyperLink = null;
			this.Label151.Left = 0.1875F;
			this.Label151.Name = "Label151";
			this.Label151.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label151.Text = "期損害保険契約等」に係る保険料等については従前の";
			this.Label151.Top = 6.482F;
			this.Label151.Width = 2.375F;
			// 
			// Label152
			// 
			this.Label152.Height = 0.125F;
			this.Label152.HyperLink = null;
			this.Label152.Left = 0.1875F;
			this.Label152.Name = "Label152";
			this.Label152.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label152.Text = "損害保険控除が適用されます。";
			this.Label152.Top = 6.607F;
			this.Label152.Width = 2.375F;
			// 
			// Label147
			// 
			this.Label147.Height = 0.125F;
			this.Label147.HyperLink = null;
			this.Label147.Left = 0.0625F;
			this.Label147.Name = "Label147";
			this.Label147.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label147.Text = "※";
			this.Label147.Top = 6.357F;
			this.Label147.Width = 0.125F;
			// 
			// Label153
			// 
			this.Label153.Height = 0.5625F;
			this.Label153.HyperLink = null;
			this.Label153.Left = 0F;
			this.Label153.Name = "Label153";
			this.Label153.Style = "background-color: White";
			this.Label153.Text = "";
			this.Label153.Top = 6.357F;
			this.Label153.Width = 2.5625F;
			// 
			// Label156
			// 
			this.Label156.Height = 0.1629996F;
			this.Label156.HyperLink = null;
			this.Label156.Left = 0.2535F;
			this.Label156.Name = "Label156";
			this.Label156.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label156.Text = "年 少 扶 養";
			this.Label156.Top = 6.172F;
			this.Label156.Width = 0.813F;
			// 
			// TextBox484
			// 
			this.TextBox484.DataField = "YOUNG_DPND_NUM";
			this.TextBox484.Height = 0.143F;
			this.TextBox484.Left = 1.0655F;
			this.TextBox484.Name = "TextBox484";
			this.TextBox484.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TextBox484.Text = "Z6";
			this.TextBox484.Top = 6.176F;
			this.TextBox484.Width = 0.3125F;
			// 
			// Label1
			// 
			this.Label1.Height = 0.143F;
			this.Label1.HyperLink = null;
			this.Label1.Left = 0.252F;
			this.Label1.Name = "Label1";
			this.Label1.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1.Text = "源泉";
			this.Label1.Top = 4.594F;
			this.Label1.Width = 0.5F;
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
			// HR_PY_06_R98
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
			this.ReportStart += new System.EventHandler(this.HR_PY_06_R98_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.Label9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty1Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty2Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty3Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty4Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty5Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty6Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty7Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty9Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty10Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty11Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty12Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyTotal8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxTypeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox462)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox463)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox464)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox465)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox466)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox467)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox468)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox469)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox472)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox473)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox474)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox475)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label82)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox476)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox477)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox478)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox479)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox480)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox481)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label116)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label117)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label118)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label119)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label120)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label121)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyZeroFlg8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemId7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyDispType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label138)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox672)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox673)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dty8Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox674)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label156)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox484)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
