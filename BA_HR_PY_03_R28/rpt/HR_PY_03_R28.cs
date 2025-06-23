// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R28.cs
// 機能名      : HR_PY_03_R28 賃金台帳
// Version     : 2.3.0
// Last Update : 2016/06/30
// Copyright (c) 2004-2016 Grandit Corp. All Rights Reserved.
//
// 1.0.0 2004/04/01
// 1.4.0 2005/10/31
// 管理番号 B17275 2006/02/27 賃金台帳(休日勤務・残業の表示不具合等)
// 1.4.1 2006/09/30
// 管理番号 B19330 2006/10/31 賃金台帳(性別の印字)
// 1.4.2 2006/11/30
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 K23028 2009/11/11 労働基準法改正対応
// 管理番号 K23847 2010/12/27 Ｈ２２労基法改正での変更仕様の廃止
// 管理番号 K24565 2012/06/06 ActiveReportsバージョンアップ対応
// 2.0.0 2012/10/31
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30

using System;
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_03_R28 : GrapeCity.ActiveReports.SectionReport
	{
// 管理番号 K23028 From
		public HR_PY_03_R28()
		{
			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
		private Line Line212;
		protected CommonData cd;
		protected string beforeSortKey = string.Empty;
		private Line line2;
		protected string beforeTitle;
		private TextBox PaymntYmFrom;
		private Label Label43;
		private TextBox EmpCode;
		private Label Label46;
		private TextBox EmpName;
		private Label Label47;
		private TextBox PaymntYmto;
		private Label Label48;
		private Line Line86;
		private Label Label8;
		private Line Line198;
		private Label Label44;
		private Line Line199;
		private TextBox PaymntYm1;
		private Line Line82;
		private Line Line95;
		private Label Label45;
		private TextBox AtacName1;
		private TextBox PaymntDate1;
		private TextBox Kubun1;
		private TextBox PaymntDate2;
		private TextBox AtacName2;
		private TextBox Kubun2;
		private TextBox PaymntYm2;
		private Line Line227;
		private Line Line228;
		private Line Line229;
		private TextBox PaymntYm3;
		private TextBox AtacName3;
		private TextBox PaymntDate3;
		private TextBox Kubun3;
		private TextBox AtacName4;
		private TextBox Kubun4;
		private TextBox PaymntYm4;
		private TextBox PaymntDate4;
		private Line Line230;
		private Line Line231;
		private TextBox PaymntYm5;
		private TextBox AtacName5;
		private TextBox PaymntDate5;
		private TextBox PaymntDate6;
		private TextBox AtacName6;
		private TextBox Kubun6;
		private TextBox PaymntYm6;
		private Line Line232;
		private Line Line233;
		private TextBox PaymntYm7;
		private TextBox AtacName7;
		private TextBox PaymntDate7;
		private TextBox Kubun7;
		private TextBox AtacName8;
		private TextBox Kubun8;
		private TextBox PaymntYm8;
		private TextBox PaymntDate8;
		private TextBox Kubun5;
		private Line Line234;
		private Line Line235;
		private TextBox PaymntYm9;
		private TextBox AtacName9;
		private TextBox Kubun9;
		private TextBox AtacName10;
		private TextBox Kubun10;
		private TextBox PaymntYm10;
		private Line Line236;
		private Line Line237;
		private TextBox PaymntYm11;
		private TextBox AtacName11;
		private TextBox Kubun11;
		private TextBox AtacName12;
		private TextBox Kubun12;
		private TextBox PaymntYm12;
		private Line Line238;
		private Line Line239;
		private TextBox PaymntYm13;
		private TextBox AtacName13;
		private TextBox AtacName14;
		private TextBox Kubun14;
		private TextBox PaymntYm14;
		private Line Line240;
		private Line Line241;
		private TextBox Kubun13;
		private TextBox PaymntDate9;
		private TextBox PaymntDate10;
		private TextBox PaymntDate11;
		private TextBox PaymntDate12;
		private TextBox PaymntDate13;
		private TextBox PaymntDate14;
		private Line Line242;
		private Label Label49;
		private Label Label50;
		private Label Label51;
		private Label Label52;
		private Label Label53;
		private TextBox Sex_Name;
		private TextBox Sex_Type;
		private Line line3;
		private Line Line110;
		protected decimal cnt;

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

		private void HR_PY_03_R28_ReportStart(object sender, System.EventArgs eArgs)
		{
// 管理番号 K23847 From
//			//仮想プリンタの設定
//			this.Document.Printer.PrinterName="";
//			// 用紙サイズ:A4
//			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
//			// 用紙方向:横
//			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			int i;
			bool isA3PaperKind = false;

			for (i = 0; i < this.Document.Printer.PaperSizes.Count; i++)
			{
				// A3サイズの存在チェック
				if (this.Document.Printer.PaperSizes[i].Kind == System.Drawing.Printing.PaperKind.A3)
				{
					isA3PaperKind = true;
					break;
				}
			}
			if (!isA3PaperKind)
			{
				// 仮想プリンタの設定
				this.Document.Printer.PrinterName = "";
			}

			// 用紙サイズ:A3
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3;
			// 用紙方向:縦
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
// 管理番号 K23847 To
			DateText.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
		}

		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
			CompanyNameText.Text = companyName;
		}

		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{
			ReportIDText.Text = reportID;

			if ((PaymntDate1.Text == null) || (PaymntDate1.Text.Length == 0))
			{
				Kubun1.Text = "";
				Amt1.Visible = false;
			}
			else
			{
				Kubun1.Text = "給";
			}

			if ((PaymntDate2.Text == null) || (PaymntDate2.Text.Length == 0))
			{
				Kubun2.Text = "";
				Amt2.Visible = false;
			}
			else
			{
				Kubun2.Text = "給";
			}

			if ((PaymntDate3.Text == null) || (PaymntDate3.Text.Length == 0))
			{
				Kubun3.Text = "";
				Amt3.Visible = false;
			}
			else
			{
				Kubun3.Text = "給";
			}

			if ((PaymntDate4.Text == null) || (PaymntDate4.Text.Length == 0))
			{
				Kubun4.Text = "";
				Amt4.Visible = false;
			}
			else
			{
				Kubun4.Text = "給";
			}

			if ((PaymntDate5.Text == null) || (PaymntDate5.Text.Length == 0))
			{
				Kubun5.Text = "";
				Amt5.Visible = false;
			}
			else
			{
				Kubun5.Text = "給";
			}

			if ((PaymntDate6.Text == null) || (PaymntDate6.Text.Length == 0))
			{
				Kubun6.Text = "";
				Amt6.Visible = false;
			}
			else
			{
				Kubun6.Text = "給";
			}

			if ((PaymntDate7.Text == null) || (PaymntDate7.Text.Length == 0))
			{
				Kubun7.Text = "";
				Amt7.Visible = false;
			}
			else
			{
				Kubun7.Text = "給";
			}

			if ((PaymntDate8.Text == null) || (PaymntDate8.Text.Length == 0))
			{
				Kubun8.Text = "";
				Amt8.Visible = false;
			}
			else
			{
				Kubun8.Text = "給";
			}

			if ((PaymntDate9.Text == null) || (PaymntDate9.Text.Length == 0))
			{
				Kubun9.Text = "";
				Amt9.Visible = false;
			}
			else
			{
				Kubun9.Text = "給";
			}

			if ((PaymntDate10.Text == null) || (PaymntDate10.Text.Length == 0))
			{
				Kubun10.Text = "";
				Amt10.Visible = false;
			}
			else
			{
				Kubun10.Text = "給";
			}

			if ((PaymntDate11.Text == null) || (PaymntDate11.Text.Length == 0))
			{
				Kubun11.Text = "";
				Amt11.Visible = false;
			}
			else
			{
				Kubun11.Text = "給";
			}

			if ((PaymntDate12.Text == null) || (PaymntDate12.Text.Length == 0))
			{
				Kubun12.Text = "";
				Amt12.Visible = false;
			}
			else
			{
				Kubun12.Text = "給";
			}

			if ((PaymntDate13.Text == null) || (PaymntDate13.Text.Length == 0))
			{
				Kubun13.Text = "";
			}
			else
			{
				Kubun13.Text = "賞";
			}

			if ((PaymntDate14.Text == null) || (PaymntDate14.Text.Length == 0))
			{
				Kubun14.Text = "";
			}
			else
			{
				Kubun14.Text = "賞";
			}

			if (EmpName.Text.Trim().Length > 15)
			{
				EmpName.Text = EmpName.Text.Substring(0, 15);
			}

			if (Sex_Type.Text == "1")
			{
				Sex_Name.Text = "男";
			}
			else if (Sex_Type.Text == "2")
			{
				Sex_Name.Text = "女";
			}
			else
			{
				Sex_Name.Text = "";
			}

		}

		private void GroupHeader2_Format(object sender, EventArgs e)
		{
		}

		private void GroupHeader2_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void GroupHeader1_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
			if (beforeSortKey != string.Empty && beforeSortKey != SortKey.Text)
			{
				Line23.Visible = true;
			}
			else
			{
				Line23.Visible = false;
			}

			if (beforeTitle != "" && beforeTitle != Title.Text)
			{
				Title.Visible = true;
			}
			else
			{
				Title.Visible = false;
			}

			beforeSortKey = SortKey.Text;
			beforeTitle = Title.Text;
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_AfterPrint(object sender, System.EventArgs eArgs)
		{
			Amt1.Visible = true;
			Amt2.Visible = true;
			Amt3.Visible = true;
			Amt4.Visible = true;
			Amt5.Visible = true;
			Amt6.Visible = true;
			Amt7.Visible = true;
			Amt8.Visible = true;
			Amt9.Visible = true;
			Amt10.Visible = true;
			Amt11.Visible = true;
			Amt12.Visible = true;
			Amt13.Visible = true;
			Amt14.Visible = true;
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
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Title = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line31 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line34 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line37 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line39 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line40 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line43 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SortKey = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R28));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ItemName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line212 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Title = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line23 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line24 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line25 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line26 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line27 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line28 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line29 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line30 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line31 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line32 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line33 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line34 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line35 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line36 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line37 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line38 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line39 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line40 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line41 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line42 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line43 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SortKey = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGE = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGESUM = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ReportIDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PrintName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.CompanyNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.PaymntYmFrom = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label43 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label46 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntYmto = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line86 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line198 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line199 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line82 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line95 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AtacName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line227 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line228 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line229 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line230 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line231 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line232 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line233 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line234 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line235 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line236 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line237 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line238 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line239 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaymntYm13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Kubun14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntYm14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line240 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line241 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Kubun13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line242 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label49 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label50 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label51 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label52 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label53 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Sex_Name = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Sex_Type = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line110 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.GroupHeader2 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter2 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			((System.ComponentModel.ISupportInitialize)(this.ItemName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SortKey)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYmFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYmto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sex_Name)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sex_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.ItemName,
            this.Line212,
            this.Title,
            this.Amt1,
            this.Amt2,
            this.Amt3,
            this.Amt4,
            this.Amt5,
            this.Amt6,
            this.Amt7,
            this.Amt8,
            this.Amt9,
            this.Amt10,
            this.Amt11,
            this.Amt12,
            this.Amt13,
            this.Amt14,
            this.Amt17,
            this.Amt18,
            this.Amt19,
            this.Line23,
            this.Line24,
            this.Line25,
            this.Line26,
            this.Line27,
            this.Line28,
            this.Line29,
            this.Line30,
            this.Line31,
            this.Line32,
            this.Line33,
            this.Line34,
            this.Line35,
            this.Line36,
            this.Line37,
            this.Line38,
            this.Line39,
            this.Line40,
            this.Line41,
            this.Line42,
            this.Line43,
            this.Line1,
            this.SortKey});
			this.Detail.Height = 0.188F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			// 
			// ItemName
			// 
			this.ItemName.Border.BottomColor = System.Drawing.Color.Black;
			this.ItemName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ItemName.Border.LeftColor = System.Drawing.Color.Black;
			this.ItemName.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ItemName.Border.RightColor = System.Drawing.Color.Black;
			this.ItemName.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ItemName.Border.TopColor = System.Drawing.Color.Black;
			this.ItemName.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ItemName.DataField = "ITEM_NAME";
			this.ItemName.Height = 0.1875F;
			this.ItemName.Left = 0.25F;
			this.ItemName.Name = "ItemName";
			this.ItemName.Style = "ddo-char-set: 1; font-size: 6pt; white-space: nowrap; vertical-align: middle; ";
			this.ItemName.Text = "あいうえおか";
			this.ItemName.Top = 0F;
			this.ItemName.Width = 0.75F;
			// 
			// Line212
			// 
			this.Line212.Border.BottomColor = System.Drawing.Color.Black;
			this.Line212.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line212.Border.LeftColor = System.Drawing.Color.Black;
			this.Line212.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line212.Border.RightColor = System.Drawing.Color.Black;
			this.Line212.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line212.Border.TopColor = System.Drawing.Color.Black;
			this.Line212.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line212.Height = 0.173F;
			this.Line212.Left = 0F;
			this.Line212.LineWeight = 1F;
			this.Line212.Name = "Line212";
			this.Line212.Top = 0F;
			this.Line212.Width = 0F;
			this.Line212.X1 = 0F;
			this.Line212.X2 = 0F;
			this.Line212.Y1 = 0F;
			this.Line212.Y2 = 0.173F;
			// 
			// Title
			// 
			this.Title.Border.BottomColor = System.Drawing.Color.Black;
			this.Title.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Title.Border.LeftColor = System.Drawing.Color.Black;
			this.Title.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Title.Border.RightColor = System.Drawing.Color.Black;
			this.Title.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Title.Border.TopColor = System.Drawing.Color.Black;
			this.Title.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Title.DataField = "TITLE";
			this.Title.Height = 0.19F;
			this.Title.Left = 0F;
			this.Title.Name = "Title";
			this.Title.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: middle; ";
			this.Title.Text = "支給";
			this.Title.Top = 0F;
			this.Title.Width = 0.25F;
			// 
			// Amt1
			// 
			this.Amt1.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt1.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt1.Border.RightColor = System.Drawing.Color.Black;
			this.Amt1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt1.Border.TopColor = System.Drawing.Color.Black;
			this.Amt1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt1.DataField = "AMT1";
			this.Amt1.Height = 0.1875F;
			this.Amt1.Left = 1F;
			this.Amt1.Name = "Amt1";
			this.Amt1.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt1.Text = "ZZZ,ZZZ,ZZ6.66";
			this.Amt1.Top = 0F;
			this.Amt1.Width = 0.5625F;
			// 
			// Amt2
			// 
			this.Amt2.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt2.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt2.Border.RightColor = System.Drawing.Color.Black;
			this.Amt2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt2.Border.TopColor = System.Drawing.Color.Black;
			this.Amt2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt2.DataField = "AMT2";
			this.Amt2.Height = 0.188F;
			this.Amt2.Left = 1.5625F;
			this.Amt2.Name = "Amt2";
			this.Amt2.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt2.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt2.Top = 0F;
			this.Amt2.Width = 0.563F;
			// 
			// Amt3
			// 
			this.Amt3.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt3.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt3.Border.RightColor = System.Drawing.Color.Black;
			this.Amt3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt3.Border.TopColor = System.Drawing.Color.Black;
			this.Amt3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt3.DataField = "AMT3";
			this.Amt3.Height = 0.188F;
			this.Amt3.Left = 2.125F;
			this.Amt3.Name = "Amt3";
			this.Amt3.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt3.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt3.Top = 0F;
			this.Amt3.Width = 0.563F;
			// 
			// Amt4
			// 
			this.Amt4.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt4.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt4.Border.RightColor = System.Drawing.Color.Black;
			this.Amt4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt4.Border.TopColor = System.Drawing.Color.Black;
			this.Amt4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt4.DataField = "AMT4";
			this.Amt4.Height = 0.188F;
			this.Amt4.Left = 2.6875F;
			this.Amt4.Name = "Amt4";
			this.Amt4.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt4.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt4.Top = 0F;
			this.Amt4.Width = 0.563F;
			// 
			// Amt5
			// 
			this.Amt5.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt5.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt5.Border.RightColor = System.Drawing.Color.Black;
			this.Amt5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt5.Border.TopColor = System.Drawing.Color.Black;
			this.Amt5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt5.DataField = "AMT5";
			this.Amt5.Height = 0.188F;
			this.Amt5.Left = 3.25F;
			this.Amt5.Name = "Amt5";
			this.Amt5.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt5.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt5.Top = 0F;
			this.Amt5.Width = 0.563F;
			// 
			// Amt6
			// 
			this.Amt6.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt6.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt6.Border.RightColor = System.Drawing.Color.Black;
			this.Amt6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt6.Border.TopColor = System.Drawing.Color.Black;
			this.Amt6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt6.DataField = "AMT6";
			this.Amt6.Height = 0.188F;
			this.Amt6.Left = 3.8125F;
			this.Amt6.Name = "Amt6";
			this.Amt6.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt6.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt6.Top = 0F;
			this.Amt6.Width = 0.563F;
			// 
			// Amt7
			// 
			this.Amt7.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt7.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt7.Border.RightColor = System.Drawing.Color.Black;
			this.Amt7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt7.Border.TopColor = System.Drawing.Color.Black;
			this.Amt7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt7.DataField = "AMT7";
			this.Amt7.Height = 0.188F;
			this.Amt7.Left = 4.375F;
			this.Amt7.Name = "Amt7";
			this.Amt7.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt7.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt7.Top = 0F;
			this.Amt7.Width = 0.563F;
			// 
			// Amt8
			// 
			this.Amt8.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt8.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt8.Border.RightColor = System.Drawing.Color.Black;
			this.Amt8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt8.Border.TopColor = System.Drawing.Color.Black;
			this.Amt8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt8.DataField = "AMT8";
			this.Amt8.Height = 0.188F;
			this.Amt8.Left = 4.9375F;
			this.Amt8.Name = "Amt8";
			this.Amt8.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt8.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt8.Top = 0F;
			this.Amt8.Width = 0.563F;
			// 
			// Amt9
			// 
			this.Amt9.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt9.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt9.Border.RightColor = System.Drawing.Color.Black;
			this.Amt9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt9.Border.TopColor = System.Drawing.Color.Black;
			this.Amt9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt9.DataField = "AMT9";
			this.Amt9.Height = 0.188F;
			this.Amt9.Left = 5.5F;
			this.Amt9.Name = "Amt9";
			this.Amt9.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt9.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt9.Top = 0F;
			this.Amt9.Width = 0.563F;
			// 
			// Amt10
			// 
			this.Amt10.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt10.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt10.Border.RightColor = System.Drawing.Color.Black;
			this.Amt10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt10.Border.TopColor = System.Drawing.Color.Black;
			this.Amt10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt10.DataField = "AMT10";
			this.Amt10.Height = 0.188F;
			this.Amt10.Left = 6.0625F;
			this.Amt10.Name = "Amt10";
			this.Amt10.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt10.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt10.Top = 0F;
			this.Amt10.Width = 0.563F;
			// 
			// Amt11
			// 
			this.Amt11.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt11.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt11.Border.RightColor = System.Drawing.Color.Black;
			this.Amt11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt11.Border.TopColor = System.Drawing.Color.Black;
			this.Amt11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt11.DataField = "AMT11";
			this.Amt11.Height = 0.188F;
			this.Amt11.Left = 6.625F;
			this.Amt11.Name = "Amt11";
			this.Amt11.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt11.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt11.Top = 0F;
			this.Amt11.Width = 0.563F;
			// 
			// Amt12
			// 
			this.Amt12.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt12.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt12.Border.RightColor = System.Drawing.Color.Black;
			this.Amt12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt12.Border.TopColor = System.Drawing.Color.Black;
			this.Amt12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt12.DataField = "AMT12";
			this.Amt12.Height = 0.188F;
			this.Amt12.Left = 7.1875F;
			this.Amt12.Name = "Amt12";
			this.Amt12.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt12.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt12.Top = 0F;
			this.Amt12.Width = 0.563F;
			// 
			// Amt13
			// 
			this.Amt13.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt13.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt13.Border.RightColor = System.Drawing.Color.Black;
			this.Amt13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt13.Border.TopColor = System.Drawing.Color.Black;
			this.Amt13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt13.DataField = "AMT13";
			this.Amt13.Height = 0.188F;
			this.Amt13.Left = 7.75F;
			this.Amt13.Name = "Amt13";
			this.Amt13.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt13.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt13.Top = 0F;
			this.Amt13.Width = 0.563F;
			// 
			// Amt14
			// 
			this.Amt14.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt14.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt14.Border.RightColor = System.Drawing.Color.Black;
			this.Amt14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt14.Border.TopColor = System.Drawing.Color.Black;
			this.Amt14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt14.DataField = "AMT14";
			this.Amt14.Height = 0.188F;
			this.Amt14.Left = 8.3125F;
			this.Amt14.Name = "Amt14";
			this.Amt14.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt14.Text = "ZZZ,ZZZ,ZZ6";
			this.Amt14.Top = 0F;
			this.Amt14.Width = 0.563F;
			// 
			// Amt17
			// 
			this.Amt17.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt17.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt17.Border.RightColor = System.Drawing.Color.Black;
			this.Amt17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt17.Border.TopColor = System.Drawing.Color.Black;
			this.Amt17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt17.DataField = "AMT17";
			this.Amt17.Height = 0.1875F;
			this.Amt17.Left = 8.875F;
			this.Amt17.Name = "Amt17";
			this.Amt17.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt17.Text = "ZZZ,ZZZ,ZZ6.66";
			this.Amt17.Top = 0F;
			this.Amt17.Width = 0.6250002F;
			// 
			// Amt18
			// 
			this.Amt18.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt18.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt18.Border.RightColor = System.Drawing.Color.Black;
			this.Amt18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt18.Border.TopColor = System.Drawing.Color.Black;
			this.Amt18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt18.DataField = "AMT18";
			this.Amt18.Height = 0.1875F;
			this.Amt18.Left = 9.5F;
			this.Amt18.Name = "Amt18";
			this.Amt18.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt18.Text = "ZZZ,ZZZ,ZZ6.66";
			this.Amt18.Top = 0F;
			this.Amt18.Width = 0.6249997F;
			// 
			// Amt19
			// 
			this.Amt19.Border.BottomColor = System.Drawing.Color.Black;
			this.Amt19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt19.Border.LeftColor = System.Drawing.Color.Black;
			this.Amt19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt19.Border.RightColor = System.Drawing.Color.Black;
			this.Amt19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt19.Border.TopColor = System.Drawing.Color.Black;
			this.Amt19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Amt19.DataField = "AMT19";
			this.Amt19.Height = 0.1875F;
			this.Amt19.Left = 10.125F;
			this.Amt19.Name = "Amt19";
			this.Amt19.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; white-space: nowrap; vertical" +
				"-align: middle; ";
			this.Amt19.Text = "ZZZ,ZZZ,ZZ6.66";
			this.Amt19.Top = 0F;
			this.Amt19.Width = 0.6250002F;
			// 
			// Line23
			// 
			this.Line23.Border.BottomColor = System.Drawing.Color.Black;
			this.Line23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line23.Border.LeftColor = System.Drawing.Color.Black;
			this.Line23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line23.Border.RightColor = System.Drawing.Color.Black;
			this.Line23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line23.Border.TopColor = System.Drawing.Color.Black;
			this.Line23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line23.Height = 0F;
			this.Line23.Left = 0F;
			this.Line23.LineWeight = 1F;
			this.Line23.Name = "Line23";
			this.Line23.Top = 0F;
			this.Line23.Width = 10.75F;
			this.Line23.X1 = 0F;
			this.Line23.X2 = 10.75F;
			this.Line23.Y1 = 0F;
			this.Line23.Y2 = 0F;
			// 
			// Line24
			// 
			this.Line24.Border.BottomColor = System.Drawing.Color.Black;
			this.Line24.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line24.Border.LeftColor = System.Drawing.Color.Black;
			this.Line24.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line24.Border.RightColor = System.Drawing.Color.Black;
			this.Line24.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line24.Border.TopColor = System.Drawing.Color.Black;
			this.Line24.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line24.Height = 0F;
			this.Line24.Left = 0.25F;
			this.Line24.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line24.LineWeight = 1F;
			this.Line24.Name = "Line24";
			this.Line24.Top = 0.1875F;
			this.Line24.Width = 10.5F;
			this.Line24.X1 = 0.25F;
			this.Line24.X2 = 10.75F;
			this.Line24.Y1 = 0.1875F;
			this.Line24.Y2 = 0.1875F;
			// 
			// Line25
			// 
			this.Line25.Border.BottomColor = System.Drawing.Color.Black;
			this.Line25.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line25.Border.LeftColor = System.Drawing.Color.Black;
			this.Line25.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line25.Border.RightColor = System.Drawing.Color.Black;
			this.Line25.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line25.Border.TopColor = System.Drawing.Color.Black;
			this.Line25.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line25.Height = 0.191F;
			this.Line25.Left = 1F;
			this.Line25.LineWeight = 1F;
			this.Line25.Name = "Line25";
			this.Line25.Top = 0F;
			this.Line25.Width = 0F;
			this.Line25.X1 = 1F;
			this.Line25.X2 = 1F;
			this.Line25.Y1 = 0F;
			this.Line25.Y2 = 0.191F;
			// 
			// Line26
			// 
			this.Line26.Border.BottomColor = System.Drawing.Color.Black;
			this.Line26.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line26.Border.LeftColor = System.Drawing.Color.Black;
			this.Line26.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line26.Border.RightColor = System.Drawing.Color.Black;
			this.Line26.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line26.Border.TopColor = System.Drawing.Color.Black;
			this.Line26.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line26.Height = 0.191F;
			this.Line26.Left = 0.25F;
			this.Line26.LineWeight = 1F;
			this.Line26.Name = "Line26";
			this.Line26.Top = 0F;
			this.Line26.Width = 0F;
			this.Line26.X1 = 0.25F;
			this.Line26.X2 = 0.25F;
			this.Line26.Y1 = 0F;
			this.Line26.Y2 = 0.191F;
			// 
			// Line27
			// 
			this.Line27.Border.BottomColor = System.Drawing.Color.Black;
			this.Line27.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line27.Border.LeftColor = System.Drawing.Color.Black;
			this.Line27.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line27.Border.RightColor = System.Drawing.Color.Black;
			this.Line27.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line27.Border.TopColor = System.Drawing.Color.Black;
			this.Line27.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line27.Height = 0.191F;
			this.Line27.Left = 2.125F;
			this.Line27.LineWeight = 1F;
			this.Line27.Name = "Line27";
			this.Line27.Top = 0F;
			this.Line27.Width = 0F;
			this.Line27.X1 = 2.125F;
			this.Line27.X2 = 2.125F;
			this.Line27.Y1 = 0F;
			this.Line27.Y2 = 0.191F;
			// 
			// Line28
			// 
			this.Line28.Border.BottomColor = System.Drawing.Color.Black;
			this.Line28.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line28.Border.LeftColor = System.Drawing.Color.Black;
			this.Line28.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line28.Border.RightColor = System.Drawing.Color.Black;
			this.Line28.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line28.Border.TopColor = System.Drawing.Color.Black;
			this.Line28.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line28.Height = 0.191F;
			this.Line28.Left = 1.5625F;
			this.Line28.LineWeight = 1F;
			this.Line28.Name = "Line28";
			this.Line28.Top = 0F;
			this.Line28.Width = 0F;
			this.Line28.X1 = 1.5625F;
			this.Line28.X2 = 1.5625F;
			this.Line28.Y1 = 0F;
			this.Line28.Y2 = 0.191F;
			// 
			// Line29
			// 
			this.Line29.Border.BottomColor = System.Drawing.Color.Black;
			this.Line29.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line29.Border.LeftColor = System.Drawing.Color.Black;
			this.Line29.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line29.Border.RightColor = System.Drawing.Color.Black;
			this.Line29.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line29.Border.TopColor = System.Drawing.Color.Black;
			this.Line29.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line29.Height = 0.191F;
			this.Line29.Left = 2.6875F;
			this.Line29.LineWeight = 1F;
			this.Line29.Name = "Line29";
			this.Line29.Top = 0F;
			this.Line29.Width = 0F;
			this.Line29.X1 = 2.6875F;
			this.Line29.X2 = 2.6875F;
			this.Line29.Y1 = 0F;
			this.Line29.Y2 = 0.191F;
			// 
			// Line30
			// 
			this.Line30.Border.BottomColor = System.Drawing.Color.Black;
			this.Line30.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line30.Border.LeftColor = System.Drawing.Color.Black;
			this.Line30.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line30.Border.RightColor = System.Drawing.Color.Black;
			this.Line30.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line30.Border.TopColor = System.Drawing.Color.Black;
			this.Line30.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line30.Height = 0.191F;
			this.Line30.Left = 3.25F;
			this.Line30.LineWeight = 1F;
			this.Line30.Name = "Line30";
			this.Line30.Top = 0F;
			this.Line30.Width = 0F;
			this.Line30.X1 = 3.25F;
			this.Line30.X2 = 3.25F;
			this.Line30.Y1 = 0F;
			this.Line30.Y2 = 0.191F;
			// 
			// Line31
			// 
			this.Line31.Border.BottomColor = System.Drawing.Color.Black;
			this.Line31.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line31.Border.LeftColor = System.Drawing.Color.Black;
			this.Line31.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line31.Border.RightColor = System.Drawing.Color.Black;
			this.Line31.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line31.Border.TopColor = System.Drawing.Color.Black;
			this.Line31.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line31.Height = 0.191F;
			this.Line31.Left = 3.8125F;
			this.Line31.LineWeight = 1F;
			this.Line31.Name = "Line31";
			this.Line31.Top = 0F;
			this.Line31.Width = 0F;
			this.Line31.X1 = 3.8125F;
			this.Line31.X2 = 3.8125F;
			this.Line31.Y1 = 0F;
			this.Line31.Y2 = 0.191F;
			// 
			// Line32
			// 
			this.Line32.Border.BottomColor = System.Drawing.Color.Black;
			this.Line32.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line32.Border.LeftColor = System.Drawing.Color.Black;
			this.Line32.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line32.Border.RightColor = System.Drawing.Color.Black;
			this.Line32.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line32.Border.TopColor = System.Drawing.Color.Black;
			this.Line32.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line32.Height = 0.191F;
			this.Line32.Left = 4.375F;
			this.Line32.LineWeight = 1F;
			this.Line32.Name = "Line32";
			this.Line32.Top = 0F;
			this.Line32.Width = 0F;
			this.Line32.X1 = 4.375F;
			this.Line32.X2 = 4.375F;
			this.Line32.Y1 = 0F;
			this.Line32.Y2 = 0.191F;
			// 
			// Line33
			// 
			this.Line33.Border.BottomColor = System.Drawing.Color.Black;
			this.Line33.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line33.Border.LeftColor = System.Drawing.Color.Black;
			this.Line33.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line33.Border.RightColor = System.Drawing.Color.Black;
			this.Line33.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line33.Border.TopColor = System.Drawing.Color.Black;
			this.Line33.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line33.Height = 0.191F;
			this.Line33.Left = 4.9375F;
			this.Line33.LineWeight = 1F;
			this.Line33.Name = "Line33";
			this.Line33.Top = 0F;
			this.Line33.Width = 0F;
			this.Line33.X1 = 4.9375F;
			this.Line33.X2 = 4.9375F;
			this.Line33.Y1 = 0F;
			this.Line33.Y2 = 0.191F;
			// 
			// Line34
			// 
			this.Line34.Border.BottomColor = System.Drawing.Color.Black;
			this.Line34.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line34.Border.LeftColor = System.Drawing.Color.Black;
			this.Line34.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line34.Border.RightColor = System.Drawing.Color.Black;
			this.Line34.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line34.Border.TopColor = System.Drawing.Color.Black;
			this.Line34.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line34.Height = 0.191F;
			this.Line34.Left = 5.5F;
			this.Line34.LineWeight = 1F;
			this.Line34.Name = "Line34";
			this.Line34.Top = 0F;
			this.Line34.Width = 0F;
			this.Line34.X1 = 5.5F;
			this.Line34.X2 = 5.5F;
			this.Line34.Y1 = 0F;
			this.Line34.Y2 = 0.191F;
			// 
			// Line35
			// 
			this.Line35.Border.BottomColor = System.Drawing.Color.Black;
			this.Line35.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line35.Border.LeftColor = System.Drawing.Color.Black;
			this.Line35.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line35.Border.RightColor = System.Drawing.Color.Black;
			this.Line35.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line35.Border.TopColor = System.Drawing.Color.Black;
			this.Line35.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line35.Height = 0.191F;
			this.Line35.Left = 6.0625F;
			this.Line35.LineWeight = 1F;
			this.Line35.Name = "Line35";
			this.Line35.Top = 0F;
			this.Line35.Width = 0F;
			this.Line35.X1 = 6.0625F;
			this.Line35.X2 = 6.0625F;
			this.Line35.Y1 = 0F;
			this.Line35.Y2 = 0.191F;
			// 
			// Line36
			// 
			this.Line36.Border.BottomColor = System.Drawing.Color.Black;
			this.Line36.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line36.Border.LeftColor = System.Drawing.Color.Black;
			this.Line36.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line36.Border.RightColor = System.Drawing.Color.Black;
			this.Line36.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line36.Border.TopColor = System.Drawing.Color.Black;
			this.Line36.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line36.Height = 0.191F;
			this.Line36.Left = 6.625F;
			this.Line36.LineWeight = 1F;
			this.Line36.Name = "Line36";
			this.Line36.Top = 0F;
			this.Line36.Width = 0F;
			this.Line36.X1 = 6.625F;
			this.Line36.X2 = 6.625F;
			this.Line36.Y1 = 0F;
			this.Line36.Y2 = 0.191F;
			// 
			// Line37
			// 
			this.Line37.Border.BottomColor = System.Drawing.Color.Black;
			this.Line37.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line37.Border.LeftColor = System.Drawing.Color.Black;
			this.Line37.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line37.Border.RightColor = System.Drawing.Color.Black;
			this.Line37.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line37.Border.TopColor = System.Drawing.Color.Black;
			this.Line37.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line37.Height = 0.191F;
			this.Line37.Left = 7.1875F;
			this.Line37.LineWeight = 1F;
			this.Line37.Name = "Line37";
			this.Line37.Top = 0F;
			this.Line37.Width = 0F;
			this.Line37.X1 = 7.1875F;
			this.Line37.X2 = 7.1875F;
			this.Line37.Y1 = 0F;
			this.Line37.Y2 = 0.191F;
			// 
			// Line38
			// 
			this.Line38.Border.BottomColor = System.Drawing.Color.Black;
			this.Line38.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line38.Border.LeftColor = System.Drawing.Color.Black;
			this.Line38.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line38.Border.RightColor = System.Drawing.Color.Black;
			this.Line38.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line38.Border.TopColor = System.Drawing.Color.Black;
			this.Line38.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line38.Height = 0.191F;
			this.Line38.Left = 7.75F;
			this.Line38.LineWeight = 1F;
			this.Line38.Name = "Line38";
			this.Line38.Top = 0F;
			this.Line38.Width = 0F;
			this.Line38.X1 = 7.75F;
			this.Line38.X2 = 7.75F;
			this.Line38.Y1 = 0F;
			this.Line38.Y2 = 0.191F;
			// 
			// Line39
			// 
			this.Line39.Border.BottomColor = System.Drawing.Color.Black;
			this.Line39.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line39.Border.LeftColor = System.Drawing.Color.Black;
			this.Line39.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line39.Border.RightColor = System.Drawing.Color.Black;
			this.Line39.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line39.Border.TopColor = System.Drawing.Color.Black;
			this.Line39.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line39.Height = 0.191F;
			this.Line39.Left = 8.3125F;
			this.Line39.LineWeight = 1F;
			this.Line39.Name = "Line39";
			this.Line39.Top = 0F;
			this.Line39.Width = 0F;
			this.Line39.X1 = 8.3125F;
			this.Line39.X2 = 8.3125F;
			this.Line39.Y1 = 0F;
			this.Line39.Y2 = 0.191F;
			// 
			// Line40
			// 
			this.Line40.Border.BottomColor = System.Drawing.Color.Black;
			this.Line40.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line40.Border.LeftColor = System.Drawing.Color.Black;
			this.Line40.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line40.Border.RightColor = System.Drawing.Color.Black;
			this.Line40.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line40.Border.TopColor = System.Drawing.Color.Black;
			this.Line40.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line40.Height = 0.191F;
			this.Line40.Left = 8.875F;
			this.Line40.LineWeight = 1F;
			this.Line40.Name = "Line40";
			this.Line40.Top = 0F;
			this.Line40.Width = 0F;
			this.Line40.X1 = 8.875F;
			this.Line40.X2 = 8.875F;
			this.Line40.Y1 = 0F;
			this.Line40.Y2 = 0.191F;
			// 
			// Line41
			// 
			this.Line41.Border.BottomColor = System.Drawing.Color.Black;
			this.Line41.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line41.Border.LeftColor = System.Drawing.Color.Black;
			this.Line41.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line41.Border.RightColor = System.Drawing.Color.Black;
			this.Line41.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line41.Border.TopColor = System.Drawing.Color.Black;
			this.Line41.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line41.Height = 0.191F;
			this.Line41.Left = 9.5F;
			this.Line41.LineWeight = 1F;
			this.Line41.Name = "Line41";
			this.Line41.Top = 0F;
			this.Line41.Width = 0F;
			this.Line41.X1 = 9.5F;
			this.Line41.X2 = 9.5F;
			this.Line41.Y1 = 0F;
			this.Line41.Y2 = 0.191F;
			// 
			// Line42
			// 
			this.Line42.Border.BottomColor = System.Drawing.Color.Black;
			this.Line42.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line42.Border.LeftColor = System.Drawing.Color.Black;
			this.Line42.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line42.Border.RightColor = System.Drawing.Color.Black;
			this.Line42.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line42.Border.TopColor = System.Drawing.Color.Black;
			this.Line42.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line42.Height = 0.191F;
			this.Line42.Left = 10.125F;
			this.Line42.LineWeight = 1F;
			this.Line42.Name = "Line42";
			this.Line42.Top = 0F;
			this.Line42.Width = 0F;
			this.Line42.X1 = 10.125F;
			this.Line42.X2 = 10.125F;
			this.Line42.Y1 = 0F;
			this.Line42.Y2 = 0.191F;
			// 
			// Line43
			// 
			this.Line43.Border.BottomColor = System.Drawing.Color.Black;
			this.Line43.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line43.Border.LeftColor = System.Drawing.Color.Black;
			this.Line43.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line43.Border.RightColor = System.Drawing.Color.Black;
			this.Line43.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line43.Border.TopColor = System.Drawing.Color.Black;
			this.Line43.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line43.Height = 0.191F;
			this.Line43.Left = 10.75F;
			this.Line43.LineWeight = 1F;
			this.Line43.Name = "Line43";
			this.Line43.Top = 0F;
			this.Line43.Width = 0F;
			this.Line43.X1 = 10.75F;
			this.Line43.X2 = 10.75F;
			this.Line43.Y1 = 0F;
			this.Line43.Y2 = 0.191F;
			// 
			// Line1
			// 
			this.Line1.Border.BottomColor = System.Drawing.Color.Black;
			this.Line1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line1.Border.LeftColor = System.Drawing.Color.Black;
			this.Line1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line1.Border.RightColor = System.Drawing.Color.Black;
			this.Line1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line1.Border.TopColor = System.Drawing.Color.Black;
			this.Line1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line1.Height = 0.191F;
			this.Line1.Left = 0F;
			this.Line1.LineWeight = 1F;
			this.Line1.Name = "Line1";
			this.Line1.Top = 0F;
			this.Line1.Width = 0F;
			this.Line1.X1 = 0F;
			this.Line1.X2 = 0F;
			this.Line1.Y1 = 0F;
			this.Line1.Y2 = 0.191F;
			// 
			// SortKey
			// 
			this.SortKey.Border.BottomColor = System.Drawing.Color.Black;
			this.SortKey.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.SortKey.Border.LeftColor = System.Drawing.Color.Black;
			this.SortKey.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.SortKey.Border.RightColor = System.Drawing.Color.Black;
			this.SortKey.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.SortKey.Border.TopColor = System.Drawing.Color.Black;
			this.SortKey.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.SortKey.DataField = "SORT_KEY";
			this.SortKey.Height = 0.1875F;
			this.SortKey.Left = 0.8124999F;
			this.SortKey.Name = "SortKey";
			this.SortKey.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; ";
			this.SortKey.Text = null;
			this.SortKey.Top = 0F;
			this.SortKey.Visible = false;
			this.SortKey.Width = 0.06250002F;
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
            this.PrintName});
			this.PageHeader.Height = 0.3720238F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			// 
			// Label2
			// 
			this.Label2.Border.BottomColor = System.Drawing.Color.Black;
			this.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label2.Border.LeftColor = System.Drawing.Color.Black;
			this.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label2.Border.RightColor = System.Drawing.Color.Black;
			this.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label2.Border.TopColor = System.Drawing.Color.Black;
			this.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label2.Height = 0.2F;
			this.Label2.HyperLink = null;
			this.Label2.Left = 8.875F;
			this.Label2.Name = "Label2";
			this.Label2.Style = "ddo-char-set: 1; font-size: 9pt; ";
			this.Label2.Text = "　ページ：";
			this.Label2.Top = 0F;
			this.Label2.Width = 0.6875F;
			// 
			// PAGE
			// 
			this.PAGE.Border.BottomColor = System.Drawing.Color.Black;
			this.PAGE.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGE.Border.LeftColor = System.Drawing.Color.Black;
			this.PAGE.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGE.Border.RightColor = System.Drawing.Color.Black;
			this.PAGE.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGE.Border.TopColor = System.Drawing.Color.Black;
			this.PAGE.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGE.CanGrow = false;
			this.PAGE.Height = 0.1875F;
			this.PAGE.Left = 9.5F;
			this.PAGE.Name = "PAGE";
			this.PAGE.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; white-space: nowrap; ";
			this.PAGE.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All;
			this.PAGE.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount;
			this.PAGE.Tag = "";
			this.PAGE.Text = "12345";
			this.PAGE.Top = 0F;
			this.PAGE.Width = 0.375F;
			// 
			// Label3
			// 
			this.Label3.Border.BottomColor = System.Drawing.Color.Black;
			this.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label3.Border.LeftColor = System.Drawing.Color.Black;
			this.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label3.Border.RightColor = System.Drawing.Color.Black;
			this.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label3.Border.TopColor = System.Drawing.Color.Black;
			this.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label3.Height = 0.1875F;
			this.Label3.HyperLink = null;
			this.Label3.Left = 9.875F;
			this.Label3.Name = "Label3";
			this.Label3.Style = "ddo-char-set: 1; font-size: 9pt; ";
			this.Label3.Text = "/";
			this.Label3.Top = 0F;
			this.Label3.Width = 0.1875F;
			// 
			// PAGESUM
			// 
			this.PAGESUM.Border.BottomColor = System.Drawing.Color.Black;
			this.PAGESUM.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGESUM.Border.LeftColor = System.Drawing.Color.Black;
			this.PAGESUM.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGESUM.Border.RightColor = System.Drawing.Color.Black;
			this.PAGESUM.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGESUM.Border.TopColor = System.Drawing.Color.Black;
			this.PAGESUM.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PAGESUM.CanGrow = false;
			this.PAGESUM.Height = 0.1875F;
			this.PAGESUM.Left = 9.958333F;
			this.PAGESUM.Name = "PAGESUM";
			this.PAGESUM.Style = "ddo-char-set: 1; text-align: left; font-size: 9pt; white-space: nowrap; ";
			this.PAGESUM.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount;
			this.PAGESUM.Text = "12345";
			this.PAGESUM.Top = 0F;
			this.PAGESUM.Width = 0.375F;
			// 
			// Label4
			// 
			this.Label4.Border.BottomColor = System.Drawing.Color.Black;
			this.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label4.Border.LeftColor = System.Drawing.Color.Black;
			this.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label4.Border.RightColor = System.Drawing.Color.Black;
			this.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label4.Border.TopColor = System.Drawing.Color.Black;
			this.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label4.Height = 0.1875F;
			this.Label4.HyperLink = null;
			this.Label4.Left = 8.875F;
			this.Label4.Name = "Label4";
			this.Label4.Style = "ddo-char-set: 1; font-size: 9pt; ";
			this.Label4.Text = "作成日時：";
			this.Label4.Top = 0.1875F;
			this.Label4.Width = 0.6875F;
			// 
			// DateText
			// 
			this.DateText.Border.BottomColor = System.Drawing.Color.Black;
			this.DateText.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.DateText.Border.LeftColor = System.Drawing.Color.Black;
			this.DateText.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.DateText.Border.RightColor = System.Drawing.Color.Black;
			this.DateText.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.DateText.Border.TopColor = System.Drawing.Color.Black;
			this.DateText.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.DateText.CanGrow = false;
			this.DateText.Height = 0.188F;
			this.DateText.Left = 9.5F;
			this.DateText.Name = "DateText";
			this.DateText.Style = "ddo-char-set: 1; text-align: left; font-size: 9pt; white-space: nowrap; ";
			this.DateText.Text = "6666/66/66 66:66:66";
			this.DateText.Top = 0.1875F;
			this.DateText.Width = 1.25F;
			// 
			// ReportIDText
			// 
			this.ReportIDText.Border.BottomColor = System.Drawing.Color.Black;
			this.ReportIDText.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ReportIDText.Border.LeftColor = System.Drawing.Color.Black;
			this.ReportIDText.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ReportIDText.Border.RightColor = System.Drawing.Color.Black;
			this.ReportIDText.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ReportIDText.Border.TopColor = System.Drawing.Color.Black;
			this.ReportIDText.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.ReportIDText.CanGrow = false;
			this.ReportIDText.Height = 0.1875F;
			this.ReportIDText.Left = 0F;
			this.ReportIDText.Name = "ReportIDText";
			this.ReportIDText.Style = "ddo-char-set: 1; font-size: 9pt; white-space: nowrap; ";
			this.ReportIDText.Text = "(HR_PY_03_R28)";
			this.ReportIDText.Top = 0F;
			this.ReportIDText.Width = 1.6875F;
			// 
			// PrintName
			// 
			this.PrintName.Border.BottomColor = System.Drawing.Color.Black;
			this.PrintName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PrintName.Border.LeftColor = System.Drawing.Color.Black;
			this.PrintName.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PrintName.Border.RightColor = System.Drawing.Color.Black;
			this.PrintName.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PrintName.Border.TopColor = System.Drawing.Color.Black;
			this.PrintName.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PrintName.DataField = "PRINT_NAME";
			this.PrintName.Height = 0.25F;
			this.PrintName.Left = 3.375F;
			this.PrintName.Name = "PrintName";
			this.PrintName.Style = "ddo-char-set: 1; text-align: center; font-size: 14pt; ";
			this.PrintName.Text = "タイトル";
			this.PrintName.Top = 0.0625F;
			this.PrintName.Width = 4F;
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
			this.CompanyNameText.Border.BottomColor = System.Drawing.Color.Black;
			this.CompanyNameText.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.CompanyNameText.Border.LeftColor = System.Drawing.Color.Black;
			this.CompanyNameText.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.CompanyNameText.Border.RightColor = System.Drawing.Color.Black;
			this.CompanyNameText.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.CompanyNameText.Border.TopColor = System.Drawing.Color.Black;
			this.CompanyNameText.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.CompanyNameText.CanGrow = false;
			this.CompanyNameText.Height = 0.1875F;
			this.CompanyNameText.Left = 0.5625F;
			this.CompanyNameText.Name = "CompanyNameText";
			this.CompanyNameText.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; white-space: nowrap; ";
			this.CompanyNameText.Text = null;
			this.CompanyNameText.Top = 0F;
			this.CompanyNameText.Width = 10.17708F;
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.PaymntYmFrom,
            this.Label43,
            this.EmpCode,
            this.Label46,
            this.EmpName,
            this.Label47,
            this.PaymntYmto,
            this.Label48,
            this.Line86,
            this.Label8,
            this.Line198,
            this.Label44,
            this.Line199,
            this.PaymntYm1,
            this.Line82,
            this.Line95,
            this.Label45,
            this.AtacName1,
            this.PaymntDate1,
            this.Kubun1,
            this.PaymntDate2,
            this.AtacName2,
            this.Kubun2,
            this.PaymntYm2,
            this.Line227,
            this.Line228,
            this.Line229,
            this.PaymntYm3,
            this.AtacName3,
            this.PaymntDate3,
            this.Kubun3,
            this.AtacName4,
            this.Kubun4,
            this.PaymntYm4,
            this.PaymntDate4,
            this.Line230,
            this.Line231,
            this.PaymntYm5,
            this.AtacName5,
            this.PaymntDate5,
            this.PaymntDate6,
            this.AtacName6,
            this.Kubun6,
            this.PaymntYm6,
            this.Line232,
            this.Line233,
            this.PaymntYm7,
            this.AtacName7,
            this.PaymntDate7,
            this.Kubun7,
            this.AtacName8,
            this.Kubun8,
            this.PaymntYm8,
            this.PaymntDate8,
            this.Kubun5,
            this.Line234,
            this.Line235,
            this.PaymntYm9,
            this.AtacName9,
            this.Kubun9,
            this.AtacName10,
            this.Kubun10,
            this.PaymntYm10,
            this.Line236,
            this.Line237,
            this.PaymntYm11,
            this.AtacName11,
            this.Kubun11,
            this.AtacName12,
            this.Kubun12,
            this.PaymntYm12,
            this.Line238,
            this.Line239,
            this.PaymntYm13,
            this.AtacName13,
            this.AtacName14,
            this.Kubun14,
            this.PaymntYm14,
            this.Line240,
            this.Line241,
            this.Kubun13,
            this.PaymntDate9,
            this.PaymntDate10,
            this.PaymntDate11,
            this.PaymntDate12,
            this.PaymntDate13,
            this.PaymntDate14,
            this.Line242,
            this.Label49,
            this.Label50,
            this.Label51,
            this.Label52,
            this.Label53,
            this.Sex_Name,
            this.Sex_Type,
            this.line3,
            this.Line110});
			this.GroupHeader1.DataField = "EMP_CODE";
			this.GroupHeader1.Height = 0.944F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before;
			this.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail;
			this.GroupHeader1.Format += new System.EventHandler(this.GroupHeader1_Format);
			this.GroupHeader1.AfterPrint += new System.EventHandler(this.GroupHeader1_AfterPrint);
			// 
			// PaymntYmFrom
			// 
			this.PaymntYmFrom.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYmFrom.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmFrom.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYmFrom.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmFrom.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYmFrom.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmFrom.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYmFrom.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmFrom.DataField = "PAYMNT_YM_FROM";
			this.PaymntYmFrom.Height = 0.18F;
			this.PaymntYmFrom.Left = 4.4375F;
			this.PaymntYmFrom.Name = "PaymntYmFrom";
			this.PaymntYmFrom.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.PaymntYmFrom.Text = "9999/99";
			this.PaymntYmFrom.Top = 0F;
			this.PaymntYmFrom.Width = 0.5F;
			// 
			// Label43
			// 
			this.Label43.Border.BottomColor = System.Drawing.Color.Black;
			this.Label43.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label43.Border.LeftColor = System.Drawing.Color.Black;
			this.Label43.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label43.Border.RightColor = System.Drawing.Color.Black;
			this.Label43.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label43.Border.TopColor = System.Drawing.Color.Black;
			this.Label43.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label43.Height = 0.18F;
			this.Label43.HyperLink = null;
			this.Label43.Left = 4.9375F;
			this.Label43.Name = "Label43";
			this.Label43.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.Label43.Text = "月度";
			this.Label43.Top = 0F;
			this.Label43.Width = 0.438F;
			// 
			// EmpCode
			// 
			this.EmpCode.Border.BottomColor = System.Drawing.Color.Black;
			this.EmpCode.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpCode.Border.LeftColor = System.Drawing.Color.Black;
			this.EmpCode.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpCode.Border.RightColor = System.Drawing.Color.Black;
			this.EmpCode.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpCode.Border.TopColor = System.Drawing.Color.Black;
			this.EmpCode.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpCode.DataField = "EMP_CODE";
			this.EmpCode.Height = 0.18F;
			this.EmpCode.Left = 0.5625F;
			this.EmpCode.Name = "EmpCode";
			this.EmpCode.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.EmpCode.Text = "0000000000";
			this.EmpCode.Top = 0F;
			this.EmpCode.Width = 0.6875F;
			// 
			// Label46
			// 
			this.Label46.Border.BottomColor = System.Drawing.Color.Black;
			this.Label46.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label46.Border.LeftColor = System.Drawing.Color.Black;
			this.Label46.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label46.Border.RightColor = System.Drawing.Color.Black;
			this.Label46.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label46.Border.TopColor = System.Drawing.Color.Black;
			this.Label46.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label46.Height = 0.18F;
			this.Label46.HyperLink = null;
			this.Label46.Left = 0F;
			this.Label46.Name = "Label46";
			this.Label46.Style = "font-size: 9pt; vertical-align: middle; ";
			this.Label46.Text = "社員番号";
			this.Label46.Top = 0F;
			this.Label46.Width = 0.5625F;
			// 
			// EmpName
			// 
			this.EmpName.Border.BottomColor = System.Drawing.Color.Black;
			this.EmpName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpName.Border.LeftColor = System.Drawing.Color.Black;
			this.EmpName.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpName.Border.RightColor = System.Drawing.Color.Black;
			this.EmpName.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpName.Border.TopColor = System.Drawing.Color.Black;
			this.EmpName.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.EmpName.DataField = "EMP_NAME";
			this.EmpName.Height = 0.18F;
			this.EmpName.Left = 1.25F;
			this.EmpName.Name = "EmpName";
			this.EmpName.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.EmpName.Text = "あいうえおかきくけこさしすせそ";
			this.EmpName.Top = 0F;
			this.EmpName.Width = 1.9375F;
			// 
			// Label47
			// 
			this.Label47.Border.BottomColor = System.Drawing.Color.Black;
			this.Label47.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label47.Border.LeftColor = System.Drawing.Color.Black;
			this.Label47.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label47.Border.RightColor = System.Drawing.Color.Black;
			this.Label47.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label47.Border.TopColor = System.Drawing.Color.Black;
			this.Label47.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label47.Height = 0.18F;
			this.Label47.HyperLink = null;
			this.Label47.Left = 5.25F;
			this.Label47.Name = "Label47";
			this.Label47.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.Label47.Text = "～";
			this.Label47.Top = 0F;
			this.Label47.Width = 0.438F;
			// 
			// PaymntYmto
			// 
			this.PaymntYmto.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYmto.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmto.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYmto.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmto.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYmto.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmto.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYmto.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYmto.DataField = "PAYMNT_YM_TO";
			this.PaymntYmto.Height = 0.18F;
			this.PaymntYmto.Left = 5.4375F;
			this.PaymntYmto.Name = "PaymntYmto";
			this.PaymntYmto.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.PaymntYmto.Text = "9999/99";
			this.PaymntYmto.Top = 0F;
			this.PaymntYmto.Width = 0.5F;
			// 
			// Label48
			// 
			this.Label48.Border.BottomColor = System.Drawing.Color.Black;
			this.Label48.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label48.Border.LeftColor = System.Drawing.Color.Black;
			this.Label48.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label48.Border.RightColor = System.Drawing.Color.Black;
			this.Label48.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label48.Border.TopColor = System.Drawing.Color.Black;
			this.Label48.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label48.Height = 0.18F;
			this.Label48.HyperLink = null;
			this.Label48.Left = 5.9375F;
			this.Label48.Name = "Label48";
			this.Label48.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.Label48.Text = "月度";
			this.Label48.Top = 0F;
			this.Label48.Width = 0.438F;
			// 
			// Line86
			// 
			this.Line86.Border.BottomColor = System.Drawing.Color.Black;
			this.Line86.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line86.Border.LeftColor = System.Drawing.Color.Black;
			this.Line86.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line86.Border.RightColor = System.Drawing.Color.Black;
			this.Line86.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line86.Border.TopColor = System.Drawing.Color.Black;
			this.Line86.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line86.Height = 0.75F;
			this.Line86.Left = 1.5625F;
			this.Line86.LineWeight = 1F;
			this.Line86.Name = "Line86";
			this.Line86.Top = 0.1875F;
			this.Line86.Width = 0F;
			this.Line86.X1 = 1.5625F;
			this.Line86.X2 = 1.5625F;
			this.Line86.Y1 = 0.1875F;
			this.Line86.Y2 = 0.9375F;
			// 
			// Label8
			// 
			this.Label8.Border.BottomColor = System.Drawing.Color.Black;
			this.Label8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label8.Border.LeftColor = System.Drawing.Color.Black;
			this.Label8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label8.Border.RightColor = System.Drawing.Color.Black;
			this.Label8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label8.Border.TopColor = System.Drawing.Color.Black;
			this.Label8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label8.Height = 0.145F;
			this.Label8.HyperLink = null;
			this.Label8.Left = 0.5624999F;
			this.Label8.Name = "Label8";
			this.Label8.Style = "ddo-char-set: 1; text-align: left; font-size: 6pt; vertical-align: top; ";
			this.Label8.Text = "年 月";
			this.Label8.Top = 0.25F;
			this.Label8.Width = 0.375F;
			// 
			// Line198
			// 
			this.Line198.Border.BottomColor = System.Drawing.Color.Black;
			this.Line198.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line198.Border.LeftColor = System.Drawing.Color.Black;
			this.Line198.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line198.Border.RightColor = System.Drawing.Color.Black;
			this.Line198.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line198.Border.TopColor = System.Drawing.Color.Black;
			this.Line198.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line198.Height = 0.564F;
			this.Line198.Left = 0F;
			this.Line198.LineWeight = 1F;
			this.Line198.Name = "Line198";
			this.Line198.Top = 0.186F;
			this.Line198.Width = 1F;
			this.Line198.X1 = 0F;
			this.Line198.X2 = 1F;
			this.Line198.Y1 = 0.186F;
			this.Line198.Y2 = 0.75F;
			// 
			// Label44
			// 
			this.Label44.Border.BottomColor = System.Drawing.Color.Black;
			this.Label44.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label44.Border.LeftColor = System.Drawing.Color.Black;
			this.Label44.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label44.Border.RightColor = System.Drawing.Color.Black;
			this.Label44.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label44.Border.TopColor = System.Drawing.Color.Black;
			this.Label44.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label44.Height = 0.145F;
			this.Label44.HyperLink = null;
			this.Label44.Left = 0.125F;
			this.Label44.Name = "Label44";
			this.Label44.Style = "ddo-char-set: 1; text-align: left; font-size: 6pt; vertical-align: middle; ";
			this.Label44.Text = "項 目";
			this.Label44.Top = 0.5F;
			this.Label44.Width = 0.375F;
			// 
			// Line199
			// 
			this.Line199.Border.BottomColor = System.Drawing.Color.Black;
			this.Line199.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line199.Border.LeftColor = System.Drawing.Color.Black;
			this.Line199.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line199.Border.RightColor = System.Drawing.Color.Black;
			this.Line199.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line199.Border.TopColor = System.Drawing.Color.Black;
			this.Line199.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line199.Height = 0.75F;
			this.Line199.Left = 2.125F;
			this.Line199.LineWeight = 1F;
			this.Line199.Name = "Line199";
			this.Line199.Top = 0.1875F;
			this.Line199.Width = 0F;
			this.Line199.X1 = 2.125F;
			this.Line199.X2 = 2.125F;
			this.Line199.Y1 = 0.1875F;
			this.Line199.Y2 = 0.9375F;
			// 
			// PaymntYm1
			// 
			this.PaymntYm1.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm1.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm1.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm1.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm1.DataField = "PAYMNT_YM1";
			this.PaymntYm1.Height = 0.145F;
			this.PaymntYm1.Left = 1.1875F;
			this.PaymntYm1.Name = "PaymntYm1";
			this.PaymntYm1.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm1.Text = "6666/66";
			this.PaymntYm1.Top = 0.25F;
			this.PaymntYm1.Width = 0.3749999F;
			// 
			// Line82
			// 
			this.Line82.Border.BottomColor = System.Drawing.Color.Black;
			this.Line82.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line82.Border.LeftColor = System.Drawing.Color.Black;
			this.Line82.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line82.Border.RightColor = System.Drawing.Color.Black;
			this.Line82.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line82.Border.TopColor = System.Drawing.Color.Black;
			this.Line82.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line82.Height = 0.75F;
			this.Line82.Left = 1F;
			this.Line82.LineWeight = 1F;
			this.Line82.Name = "Line82";
			this.Line82.Top = 0.1875F;
			this.Line82.Width = 0F;
			this.Line82.X1 = 1F;
			this.Line82.X2 = 1F;
			this.Line82.Y1 = 0.1875F;
			this.Line82.Y2 = 0.9375F;
			// 
			// Line95
			// 
			this.Line95.Border.BottomColor = System.Drawing.Color.Black;
			this.Line95.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line95.Border.LeftColor = System.Drawing.Color.Black;
			this.Line95.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line95.Border.RightColor = System.Drawing.Color.Black;
			this.Line95.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line95.Border.TopColor = System.Drawing.Color.Black;
			this.Line95.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line95.Height = 0.001499996F;
			this.Line95.Left = 0F;
			this.Line95.LineWeight = 1F;
			this.Line95.Name = "Line95";
			this.Line95.Top = 0.186F;
			this.Line95.Width = 10.75F;
			this.Line95.X1 = 0F;
			this.Line95.X2 = 10.75F;
			this.Line95.Y1 = 0.186F;
			this.Line95.Y2 = 0.1875F;
			// 
			// Label45
			// 
			this.Label45.Border.BottomColor = System.Drawing.Color.Black;
			this.Label45.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label45.Border.LeftColor = System.Drawing.Color.Black;
			this.Label45.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label45.Border.RightColor = System.Drawing.Color.Black;
			this.Label45.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label45.Border.TopColor = System.Drawing.Color.Black;
			this.Label45.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label45.Height = 0.1875F;
			this.Label45.HyperLink = null;
			this.Label45.Left = 0F;
			this.Label45.Name = "Label45";
			this.Label45.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.Label45.Text = "支給日";
			this.Label45.Top = 0.75F;
			this.Label45.Width = 1F;
			// 
			// AtacName1
			// 
			this.AtacName1.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName1.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName1.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName1.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName1.DataField = "ATAC_NAME1";
			this.AtacName1.Height = 0.25F;
			this.AtacName1.Left = 1F;
			this.AtacName1.Name = "AtacName1";
			this.AtacName1.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName1.Text = "あいうえおかきくけこ";
			this.AtacName1.Top = 0.4375001F;
			this.AtacName1.Width = 0.563F;
			// 
			// PaymntDate1
			// 
			this.PaymntDate1.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate1.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate1.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate1.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate1.DataField = "PAYMNT_DATE1";
			this.PaymntDate1.Height = 0.18F;
			this.PaymntDate1.Left = 1F;
			this.PaymntDate1.Name = "PaymntDate1";
			this.PaymntDate1.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate1.Text = "9999/99/99";
			this.PaymntDate1.Top = 0.75F;
			this.PaymntDate1.Width = 0.563F;
			// 
			// Kubun1
			// 
			this.Kubun1.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun1.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun1.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun1.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun1.Height = 0.145F;
			this.Kubun1.Left = 1F;
			this.Kubun1.Name = "Kubun1";
			this.Kubun1.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun1.Text = "あ";
			this.Kubun1.Top = 0.25F;
			this.Kubun1.Width = 0.1875F;
			// 
			// PaymntDate2
			// 
			this.PaymntDate2.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate2.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate2.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate2.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate2.DataField = "PAYMNT_DATE2";
			this.PaymntDate2.Height = 0.18F;
			this.PaymntDate2.Left = 1.5625F;
			this.PaymntDate2.Name = "PaymntDate2";
			this.PaymntDate2.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate2.Text = "9999/99/99";
			this.PaymntDate2.Top = 0.75F;
			this.PaymntDate2.Width = 0.563F;
			// 
			// AtacName2
			// 
			this.AtacName2.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName2.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName2.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName2.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName2.DataField = "ATAC_NAME2";
			this.AtacName2.Height = 0.25F;
			this.AtacName2.Left = 1.5625F;
			this.AtacName2.Name = "AtacName2";
			this.AtacName2.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName2.Text = "あいうえおかきくけこ";
			this.AtacName2.Top = 0.4375001F;
			this.AtacName2.Width = 0.563F;
			// 
			// Kubun2
			// 
			this.Kubun2.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun2.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun2.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun2.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun2.Height = 0.145F;
			this.Kubun2.Left = 1.5625F;
			this.Kubun2.Name = "Kubun2";
			this.Kubun2.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun2.Text = "あ";
			this.Kubun2.Top = 0.25F;
			this.Kubun2.Width = 0.1875F;
			// 
			// PaymntYm2
			// 
			this.PaymntYm2.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm2.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm2.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm2.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm2.DataField = "PAYMNT_YM2";
			this.PaymntYm2.Height = 0.145F;
			this.PaymntYm2.Left = 1.75F;
			this.PaymntYm2.Name = "PaymntYm2";
			this.PaymntYm2.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm2.Text = "6666/66";
			this.PaymntYm2.Top = 0.25F;
			this.PaymntYm2.Width = 0.3749999F;
			// 
			// Line227
			// 
			this.Line227.Border.BottomColor = System.Drawing.Color.Black;
			this.Line227.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line227.Border.LeftColor = System.Drawing.Color.Black;
			this.Line227.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line227.Border.RightColor = System.Drawing.Color.Black;
			this.Line227.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line227.Border.TopColor = System.Drawing.Color.Black;
			this.Line227.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line227.Height = 0.75F;
			this.Line227.Left = 2.6875F;
			this.Line227.LineWeight = 1F;
			this.Line227.Name = "Line227";
			this.Line227.Top = 0.1875F;
			this.Line227.Width = 0F;
			this.Line227.X1 = 2.6875F;
			this.Line227.X2 = 2.6875F;
			this.Line227.Y1 = 0.1875F;
			this.Line227.Y2 = 0.9375F;
			// 
			// Line228
			// 
			this.Line228.Border.BottomColor = System.Drawing.Color.Black;
			this.Line228.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line228.Border.LeftColor = System.Drawing.Color.Black;
			this.Line228.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line228.Border.RightColor = System.Drawing.Color.Black;
			this.Line228.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line228.Border.TopColor = System.Drawing.Color.Black;
			this.Line228.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line228.Height = 0.0005000234F;
			this.Line228.Left = 0F;
			this.Line228.LineWeight = 1F;
			this.Line228.Name = "Line228";
			this.Line228.Top = 0.75F;
			this.Line228.Width = 10.75F;
			this.Line228.X1 = 0F;
			this.Line228.X2 = 10.75F;
			this.Line228.Y1 = 0.7505F;
			this.Line228.Y2 = 0.75F;
			// 
			// Line229
			// 
			this.Line229.Border.BottomColor = System.Drawing.Color.Black;
			this.Line229.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line229.Border.LeftColor = System.Drawing.Color.Black;
			this.Line229.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line229.Border.RightColor = System.Drawing.Color.Black;
			this.Line229.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line229.Border.TopColor = System.Drawing.Color.Black;
			this.Line229.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line229.Height = 0.75F;
			this.Line229.Left = 3.25F;
			this.Line229.LineWeight = 1F;
			this.Line229.Name = "Line229";
			this.Line229.Top = 0.1875F;
			this.Line229.Width = 0F;
			this.Line229.X1 = 3.25F;
			this.Line229.X2 = 3.25F;
			this.Line229.Y1 = 0.1875F;
			this.Line229.Y2 = 0.9375F;
			// 
			// PaymntYm3
			// 
			this.PaymntYm3.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm3.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm3.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm3.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm3.DataField = "PAYMNT_YM3";
			this.PaymntYm3.Height = 0.145F;
			this.PaymntYm3.Left = 2.3125F;
			this.PaymntYm3.Name = "PaymntYm3";
			this.PaymntYm3.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm3.Text = "6666/66";
			this.PaymntYm3.Top = 0.25F;
			this.PaymntYm3.Width = 0.3749999F;
			// 
			// AtacName3
			// 
			this.AtacName3.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName3.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName3.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName3.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName3.DataField = "ATAC_NAME3";
			this.AtacName3.Height = 0.25F;
			this.AtacName3.Left = 2.125F;
			this.AtacName3.Name = "AtacName3";
			this.AtacName3.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName3.Text = "あいうえおかきくけこ";
			this.AtacName3.Top = 0.4375001F;
			this.AtacName3.Width = 0.563F;
			// 
			// PaymntDate3
			// 
			this.PaymntDate3.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate3.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate3.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate3.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate3.DataField = "PAYMNT_DATE3";
			this.PaymntDate3.Height = 0.18F;
			this.PaymntDate3.Left = 2.125F;
			this.PaymntDate3.Name = "PaymntDate3";
			this.PaymntDate3.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate3.Text = "9999/99/99";
			this.PaymntDate3.Top = 0.75F;
			this.PaymntDate3.Width = 0.563F;
			// 
			// Kubun3
			// 
			this.Kubun3.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun3.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun3.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun3.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun3.Height = 0.145F;
			this.Kubun3.Left = 2.125F;
			this.Kubun3.Name = "Kubun3";
			this.Kubun3.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun3.Text = "あ";
			this.Kubun3.Top = 0.25F;
			this.Kubun3.Width = 0.1875F;
			// 
			// AtacName4
			// 
			this.AtacName4.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName4.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName4.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName4.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName4.DataField = "ATAC_NAME4";
			this.AtacName4.Height = 0.25F;
			this.AtacName4.Left = 2.6875F;
			this.AtacName4.Name = "AtacName4";
			this.AtacName4.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName4.Text = "あいうえおかきくけこ";
			this.AtacName4.Top = 0.4375001F;
			this.AtacName4.Width = 0.5625F;
			// 
			// Kubun4
			// 
			this.Kubun4.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun4.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun4.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun4.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun4.Height = 0.145F;
			this.Kubun4.Left = 2.6875F;
			this.Kubun4.Name = "Kubun4";
			this.Kubun4.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun4.Text = "あ";
			this.Kubun4.Top = 0.25F;
			this.Kubun4.Width = 0.1875F;
			// 
			// PaymntYm4
			// 
			this.PaymntYm4.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm4.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm4.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm4.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm4.DataField = "PAYMNT_YM4";
			this.PaymntYm4.Height = 0.145F;
			this.PaymntYm4.Left = 2.875F;
			this.PaymntYm4.Name = "PaymntYm4";
			this.PaymntYm4.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm4.Text = "6666/66";
			this.PaymntYm4.Top = 0.25F;
			this.PaymntYm4.Width = 0.3749999F;
			// 
			// PaymntDate4
			// 
			this.PaymntDate4.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate4.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate4.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate4.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate4.DataField = "PAYMNT_DATE4";
			this.PaymntDate4.Height = 0.18F;
			this.PaymntDate4.Left = 2.6875F;
			this.PaymntDate4.Name = "PaymntDate4";
			this.PaymntDate4.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate4.Text = "9999/99/99";
			this.PaymntDate4.Top = 0.75F;
			this.PaymntDate4.Width = 0.563F;
			// 
			// Line230
			// 
			this.Line230.Border.BottomColor = System.Drawing.Color.Black;
			this.Line230.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line230.Border.LeftColor = System.Drawing.Color.Black;
			this.Line230.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line230.Border.RightColor = System.Drawing.Color.Black;
			this.Line230.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line230.Border.TopColor = System.Drawing.Color.Black;
			this.Line230.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line230.Height = 0.75F;
			this.Line230.Left = 3.8125F;
			this.Line230.LineWeight = 1F;
			this.Line230.Name = "Line230";
			this.Line230.Top = 0.1875F;
			this.Line230.Width = 0F;
			this.Line230.X1 = 3.8125F;
			this.Line230.X2 = 3.8125F;
			this.Line230.Y1 = 0.1875F;
			this.Line230.Y2 = 0.9375F;
			// 
			// Line231
			// 
			this.Line231.Border.BottomColor = System.Drawing.Color.Black;
			this.Line231.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line231.Border.LeftColor = System.Drawing.Color.Black;
			this.Line231.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line231.Border.RightColor = System.Drawing.Color.Black;
			this.Line231.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line231.Border.TopColor = System.Drawing.Color.Black;
			this.Line231.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line231.Height = 0.75F;
			this.Line231.Left = 4.375F;
			this.Line231.LineWeight = 1F;
			this.Line231.Name = "Line231";
			this.Line231.Top = 0.1875F;
			this.Line231.Width = 0F;
			this.Line231.X1 = 4.375F;
			this.Line231.X2 = 4.375F;
			this.Line231.Y1 = 0.1875F;
			this.Line231.Y2 = 0.9375F;
			// 
			// PaymntYm5
			// 
			this.PaymntYm5.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm5.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm5.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm5.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm5.DataField = "PAYMNT_YM5";
			this.PaymntYm5.Height = 0.145F;
			this.PaymntYm5.Left = 3.4375F;
			this.PaymntYm5.Name = "PaymntYm5";
			this.PaymntYm5.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm5.Text = "6666/66";
			this.PaymntYm5.Top = 0.25F;
			this.PaymntYm5.Width = 0.3749999F;
			// 
			// AtacName5
			// 
			this.AtacName5.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName5.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName5.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName5.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName5.DataField = "ATAC_NAME5";
			this.AtacName5.Height = 0.25F;
			this.AtacName5.Left = 3.25F;
			this.AtacName5.Name = "AtacName5";
			this.AtacName5.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName5.Text = "あいうえおかきくけこ";
			this.AtacName5.Top = 0.4375001F;
			this.AtacName5.Width = 0.5625F;
			// 
			// PaymntDate5
			// 
			this.PaymntDate5.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate5.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate5.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate5.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate5.DataField = "PAYMNT_DATE5";
			this.PaymntDate5.Height = 0.18F;
			this.PaymntDate5.Left = 3.25F;
			this.PaymntDate5.Name = "PaymntDate5";
			this.PaymntDate5.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate5.Text = "9999/99/99";
			this.PaymntDate5.Top = 0.75F;
			this.PaymntDate5.Width = 0.563F;
			// 
			// PaymntDate6
			// 
			this.PaymntDate6.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate6.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate6.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate6.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate6.DataField = "PAYMNT_DATE6";
			this.PaymntDate6.Height = 0.18F;
			this.PaymntDate6.Left = 3.8125F;
			this.PaymntDate6.Name = "PaymntDate6";
			this.PaymntDate6.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate6.Text = "9999/99/99";
			this.PaymntDate6.Top = 0.75F;
			this.PaymntDate6.Width = 0.563F;
			// 
			// AtacName6
			// 
			this.AtacName6.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName6.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName6.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName6.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName6.DataField = "ATAC_NAME6";
			this.AtacName6.Height = 0.25F;
			this.AtacName6.Left = 3.8125F;
			this.AtacName6.Name = "AtacName6";
			this.AtacName6.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName6.Text = "あいうえおかきくけこ";
			this.AtacName6.Top = 0.4375001F;
			this.AtacName6.Width = 0.563F;
			// 
			// Kubun6
			// 
			this.Kubun6.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun6.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun6.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun6.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun6.Height = 0.145F;
			this.Kubun6.Left = 3.8125F;
			this.Kubun6.Name = "Kubun6";
			this.Kubun6.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun6.Text = "あ";
			this.Kubun6.Top = 0.25F;
			this.Kubun6.Width = 0.1875F;
			// 
			// PaymntYm6
			// 
			this.PaymntYm6.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm6.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm6.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm6.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm6.DataField = "PAYMNT_YM6";
			this.PaymntYm6.Height = 0.145F;
			this.PaymntYm6.Left = 4F;
			this.PaymntYm6.Name = "PaymntYm6";
			this.PaymntYm6.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm6.Text = "6666/66";
			this.PaymntYm6.Top = 0.25F;
			this.PaymntYm6.Width = 0.3749999F;
			// 
			// Line232
			// 
			this.Line232.Border.BottomColor = System.Drawing.Color.Black;
			this.Line232.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line232.Border.LeftColor = System.Drawing.Color.Black;
			this.Line232.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line232.Border.RightColor = System.Drawing.Color.Black;
			this.Line232.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line232.Border.TopColor = System.Drawing.Color.Black;
			this.Line232.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line232.Height = 0.75F;
			this.Line232.Left = 4.9375F;
			this.Line232.LineWeight = 1F;
			this.Line232.Name = "Line232";
			this.Line232.Top = 0.1875F;
			this.Line232.Width = 0F;
			this.Line232.X1 = 4.9375F;
			this.Line232.X2 = 4.9375F;
			this.Line232.Y1 = 0.1875F;
			this.Line232.Y2 = 0.9375F;
			// 
			// Line233
			// 
			this.Line233.Border.BottomColor = System.Drawing.Color.Black;
			this.Line233.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line233.Border.LeftColor = System.Drawing.Color.Black;
			this.Line233.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line233.Border.RightColor = System.Drawing.Color.Black;
			this.Line233.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line233.Border.TopColor = System.Drawing.Color.Black;
			this.Line233.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line233.Height = 0.75F;
			this.Line233.Left = 5.5F;
			this.Line233.LineWeight = 1F;
			this.Line233.Name = "Line233";
			this.Line233.Top = 0.1875F;
			this.Line233.Width = 0F;
			this.Line233.X1 = 5.5F;
			this.Line233.X2 = 5.5F;
			this.Line233.Y1 = 0.1875F;
			this.Line233.Y2 = 0.9375F;
			// 
			// PaymntYm7
			// 
			this.PaymntYm7.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm7.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm7.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm7.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm7.DataField = "PAYMNT_YM7";
			this.PaymntYm7.Height = 0.145F;
			this.PaymntYm7.Left = 4.5625F;
			this.PaymntYm7.Name = "PaymntYm7";
			this.PaymntYm7.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm7.Text = "6666/66";
			this.PaymntYm7.Top = 0.25F;
			this.PaymntYm7.Width = 0.3749999F;
			// 
			// AtacName7
			// 
			this.AtacName7.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName7.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName7.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName7.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName7.DataField = "ATAC_NAME7";
			this.AtacName7.Height = 0.25F;
			this.AtacName7.Left = 4.375F;
			this.AtacName7.Name = "AtacName7";
			this.AtacName7.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName7.Text = "あいうえおかきくけこ";
			this.AtacName7.Top = 0.4375001F;
			this.AtacName7.Width = 0.563F;
			// 
			// PaymntDate7
			// 
			this.PaymntDate7.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate7.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate7.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate7.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate7.DataField = "PAYMNT_DATE7";
			this.PaymntDate7.Height = 0.18F;
			this.PaymntDate7.Left = 4.375F;
			this.PaymntDate7.Name = "PaymntDate7";
			this.PaymntDate7.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate7.Text = "9999/99/99";
			this.PaymntDate7.Top = 0.75F;
			this.PaymntDate7.Width = 0.563F;
			// 
			// Kubun7
			// 
			this.Kubun7.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun7.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun7.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun7.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun7.Height = 0.145F;
			this.Kubun7.Left = 4.375F;
			this.Kubun7.Name = "Kubun7";
			this.Kubun7.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun7.Text = "あ";
			this.Kubun7.Top = 0.25F;
			this.Kubun7.Width = 0.1875F;
			// 
			// AtacName8
			// 
			this.AtacName8.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName8.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName8.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName8.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName8.DataField = "ATAC_NAME8";
			this.AtacName8.Height = 0.25F;
			this.AtacName8.Left = 4.9375F;
			this.AtacName8.Name = "AtacName8";
			this.AtacName8.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName8.Text = "あいうえおかきくけこ";
			this.AtacName8.Top = 0.4375001F;
			this.AtacName8.Width = 0.563F;
			// 
			// Kubun8
			// 
			this.Kubun8.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun8.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun8.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun8.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun8.Height = 0.145F;
			this.Kubun8.Left = 4.9375F;
			this.Kubun8.Name = "Kubun8";
			this.Kubun8.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun8.Text = "あ";
			this.Kubun8.Top = 0.25F;
			this.Kubun8.Width = 0.1875F;
			// 
			// PaymntYm8
			// 
			this.PaymntYm8.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm8.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm8.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm8.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm8.DataField = "PAYMNT_YM8";
			this.PaymntYm8.Height = 0.145F;
			this.PaymntYm8.Left = 5.125F;
			this.PaymntYm8.Name = "PaymntYm8";
			this.PaymntYm8.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm8.Text = "6666/66";
			this.PaymntYm8.Top = 0.25F;
			this.PaymntYm8.Width = 0.3749999F;
			// 
			// PaymntDate8
			// 
			this.PaymntDate8.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate8.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate8.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate8.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate8.DataField = "PAYMNT_DATE8";
			this.PaymntDate8.Height = 0.18F;
			this.PaymntDate8.Left = 4.9375F;
			this.PaymntDate8.Name = "PaymntDate8";
			this.PaymntDate8.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate8.Text = "9999/99/99";
			this.PaymntDate8.Top = 0.75F;
			this.PaymntDate8.Width = 0.563F;
			// 
			// Kubun5
			// 
			this.Kubun5.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun5.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun5.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun5.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun5.Height = 0.145F;
			this.Kubun5.Left = 3.25F;
			this.Kubun5.Name = "Kubun5";
			this.Kubun5.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun5.Text = "あ";
			this.Kubun5.Top = 0.25F;
			this.Kubun5.Width = 0.1875F;
			// 
			// Line234
			// 
			this.Line234.Border.BottomColor = System.Drawing.Color.Black;
			this.Line234.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line234.Border.LeftColor = System.Drawing.Color.Black;
			this.Line234.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line234.Border.RightColor = System.Drawing.Color.Black;
			this.Line234.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line234.Border.TopColor = System.Drawing.Color.Black;
			this.Line234.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line234.Height = 0.75F;
			this.Line234.Left = 6.0625F;
			this.Line234.LineWeight = 1F;
			this.Line234.Name = "Line234";
			this.Line234.Top = 0.1875F;
			this.Line234.Width = 0F;
			this.Line234.X1 = 6.0625F;
			this.Line234.X2 = 6.0625F;
			this.Line234.Y1 = 0.1875F;
			this.Line234.Y2 = 0.9375F;
			// 
			// Line235
			// 
			this.Line235.Border.BottomColor = System.Drawing.Color.Black;
			this.Line235.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line235.Border.LeftColor = System.Drawing.Color.Black;
			this.Line235.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line235.Border.RightColor = System.Drawing.Color.Black;
			this.Line235.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line235.Border.TopColor = System.Drawing.Color.Black;
			this.Line235.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line235.Height = 0.75F;
			this.Line235.Left = 6.625F;
			this.Line235.LineWeight = 1F;
			this.Line235.Name = "Line235";
			this.Line235.Top = 0.1875F;
			this.Line235.Width = 0F;
			this.Line235.X1 = 6.625F;
			this.Line235.X2 = 6.625F;
			this.Line235.Y1 = 0.1875F;
			this.Line235.Y2 = 0.9375F;
			// 
			// PaymntYm9
			// 
			this.PaymntYm9.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm9.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm9.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm9.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm9.DataField = "PAYMNT_YM9";
			this.PaymntYm9.Height = 0.145F;
			this.PaymntYm9.Left = 5.6875F;
			this.PaymntYm9.Name = "PaymntYm9";
			this.PaymntYm9.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm9.Text = "6666/66";
			this.PaymntYm9.Top = 0.25F;
			this.PaymntYm9.Width = 0.3749999F;
			// 
			// AtacName9
			// 
			this.AtacName9.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName9.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName9.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName9.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName9.DataField = "ATAC_NAME9";
			this.AtacName9.Height = 0.25F;
			this.AtacName9.Left = 5.5F;
			this.AtacName9.Name = "AtacName9";
			this.AtacName9.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName9.Text = "あいうえおかきくけこ";
			this.AtacName9.Top = 0.4375001F;
			this.AtacName9.Width = 0.563F;
			// 
			// Kubun9
			// 
			this.Kubun9.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun9.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun9.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun9.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun9.Height = 0.145F;
			this.Kubun9.Left = 5.5F;
			this.Kubun9.Name = "Kubun9";
			this.Kubun9.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun9.Text = "あ";
			this.Kubun9.Top = 0.25F;
			this.Kubun9.Width = 0.1875F;
			// 
			// AtacName10
			// 
			this.AtacName10.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName10.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName10.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName10.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName10.DataField = "ATAC_NAME10";
			this.AtacName10.Height = 0.25F;
			this.AtacName10.Left = 6.0625F;
			this.AtacName10.Name = "AtacName10";
			this.AtacName10.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName10.Text = "あいうえおかきくけこ";
			this.AtacName10.Top = 0.4375001F;
			this.AtacName10.Width = 0.563F;
			// 
			// Kubun10
			// 
			this.Kubun10.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun10.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun10.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun10.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun10.Height = 0.145F;
			this.Kubun10.Left = 6.0625F;
			this.Kubun10.Name = "Kubun10";
			this.Kubun10.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun10.Text = "あ";
			this.Kubun10.Top = 0.25F;
			this.Kubun10.Width = 0.1875F;
			// 
			// PaymntYm10
			// 
			this.PaymntYm10.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm10.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm10.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm10.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm10.DataField = "PAYMNT_YM10";
			this.PaymntYm10.Height = 0.145F;
			this.PaymntYm10.Left = 6.25F;
			this.PaymntYm10.Name = "PaymntYm10";
			this.PaymntYm10.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm10.Text = "6666/66";
			this.PaymntYm10.Top = 0.25F;
			this.PaymntYm10.Width = 0.3749999F;
			// 
			// Line236
			// 
			this.Line236.Border.BottomColor = System.Drawing.Color.Black;
			this.Line236.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line236.Border.LeftColor = System.Drawing.Color.Black;
			this.Line236.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line236.Border.RightColor = System.Drawing.Color.Black;
			this.Line236.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line236.Border.TopColor = System.Drawing.Color.Black;
			this.Line236.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line236.Height = 0.75F;
			this.Line236.Left = 7.1875F;
			this.Line236.LineWeight = 1F;
			this.Line236.Name = "Line236";
			this.Line236.Top = 0.1875F;
			this.Line236.Width = 0F;
			this.Line236.X1 = 7.1875F;
			this.Line236.X2 = 7.1875F;
			this.Line236.Y1 = 0.1875F;
			this.Line236.Y2 = 0.9375F;
			// 
			// Line237
			// 
			this.Line237.Border.BottomColor = System.Drawing.Color.Black;
			this.Line237.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line237.Border.LeftColor = System.Drawing.Color.Black;
			this.Line237.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line237.Border.RightColor = System.Drawing.Color.Black;
			this.Line237.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line237.Border.TopColor = System.Drawing.Color.Black;
			this.Line237.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line237.Height = 0.75F;
			this.Line237.Left = 7.75F;
			this.Line237.LineWeight = 1F;
			this.Line237.Name = "Line237";
			this.Line237.Top = 0.1875F;
			this.Line237.Width = 0F;
			this.Line237.X1 = 7.75F;
			this.Line237.X2 = 7.75F;
			this.Line237.Y1 = 0.1875F;
			this.Line237.Y2 = 0.9375F;
			// 
			// PaymntYm11
			// 
			this.PaymntYm11.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm11.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm11.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm11.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm11.DataField = "PAYMNT_YM11";
			this.PaymntYm11.Height = 0.145F;
			this.PaymntYm11.Left = 6.8125F;
			this.PaymntYm11.Name = "PaymntYm11";
			this.PaymntYm11.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm11.Text = "6666/66";
			this.PaymntYm11.Top = 0.25F;
			this.PaymntYm11.Width = 0.3749999F;
			// 
			// AtacName11
			// 
			this.AtacName11.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName11.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName11.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName11.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName11.DataField = "ATAC_NAME11";
			this.AtacName11.Height = 0.25F;
			this.AtacName11.Left = 6.625F;
			this.AtacName11.Name = "AtacName11";
			this.AtacName11.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName11.Text = "あいうえおかきくけこ";
			this.AtacName11.Top = 0.4375001F;
			this.AtacName11.Width = 0.563F;
			// 
			// Kubun11
			// 
			this.Kubun11.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun11.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun11.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun11.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun11.Height = 0.145F;
			this.Kubun11.Left = 6.625F;
			this.Kubun11.Name = "Kubun11";
			this.Kubun11.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun11.Text = "あ";
			this.Kubun11.Top = 0.25F;
			this.Kubun11.Width = 0.1875F;
			// 
			// AtacName12
			// 
			this.AtacName12.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName12.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName12.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName12.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName12.DataField = "ATAC_NAME12";
			this.AtacName12.Height = 0.25F;
			this.AtacName12.Left = 7.1875F;
			this.AtacName12.Name = "AtacName12";
			this.AtacName12.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName12.Text = "あいうえおかきくけこ";
			this.AtacName12.Top = 0.4375001F;
			this.AtacName12.Width = 0.5625F;
			// 
			// Kubun12
			// 
			this.Kubun12.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun12.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun12.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun12.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun12.Height = 0.145F;
			this.Kubun12.Left = 7.1875F;
			this.Kubun12.Name = "Kubun12";
			this.Kubun12.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun12.Text = "あ";
			this.Kubun12.Top = 0.25F;
			this.Kubun12.Width = 0.1875F;
			// 
			// PaymntYm12
			// 
			this.PaymntYm12.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm12.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm12.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm12.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm12.DataField = "PAYMNT_YM12";
			this.PaymntYm12.Height = 0.145F;
			this.PaymntYm12.Left = 7.375F;
			this.PaymntYm12.Name = "PaymntYm12";
			this.PaymntYm12.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm12.Text = "6666/66";
			this.PaymntYm12.Top = 0.25F;
			this.PaymntYm12.Width = 0.3749999F;
			// 
			// Line238
			// 
			this.Line238.Border.BottomColor = System.Drawing.Color.Black;
			this.Line238.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line238.Border.LeftColor = System.Drawing.Color.Black;
			this.Line238.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line238.Border.RightColor = System.Drawing.Color.Black;
			this.Line238.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line238.Border.TopColor = System.Drawing.Color.Black;
			this.Line238.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line238.Height = 0.75F;
			this.Line238.Left = 8.3125F;
			this.Line238.LineWeight = 1F;
			this.Line238.Name = "Line238";
			this.Line238.Top = 0.1875F;
			this.Line238.Width = 0F;
			this.Line238.X1 = 8.3125F;
			this.Line238.X2 = 8.3125F;
			this.Line238.Y1 = 0.1875F;
			this.Line238.Y2 = 0.9375F;
			// 
			// Line239
			// 
			this.Line239.Border.BottomColor = System.Drawing.Color.Black;
			this.Line239.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line239.Border.LeftColor = System.Drawing.Color.Black;
			this.Line239.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line239.Border.RightColor = System.Drawing.Color.Black;
			this.Line239.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line239.Border.TopColor = System.Drawing.Color.Black;
			this.Line239.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line239.Height = 0.75F;
			this.Line239.Left = 8.875F;
			this.Line239.LineWeight = 1F;
			this.Line239.Name = "Line239";
			this.Line239.Top = 0.1875F;
			this.Line239.Width = 0F;
			this.Line239.X1 = 8.875F;
			this.Line239.X2 = 8.875F;
			this.Line239.Y1 = 0.1875F;
			this.Line239.Y2 = 0.9375F;
			// 
			// PaymntYm13
			// 
			this.PaymntYm13.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm13.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm13.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm13.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm13.DataField = "PAYMNT_YM13";
			this.PaymntYm13.Height = 0.145F;
			this.PaymntYm13.Left = 7.9375F;
			this.PaymntYm13.Name = "PaymntYm13";
			this.PaymntYm13.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm13.Text = "6666/66";
			this.PaymntYm13.Top = 0.25F;
			this.PaymntYm13.Width = 0.3749999F;
			// 
			// AtacName13
			// 
			this.AtacName13.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName13.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName13.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName13.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName13.DataField = "ATAC_NAME13";
			this.AtacName13.Height = 0.25F;
			this.AtacName13.Left = 7.75F;
			this.AtacName13.Name = "AtacName13";
			this.AtacName13.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.AtacName13.Text = "あいうえおかきくけこ";
			this.AtacName13.Top = 0.4375001F;
			this.AtacName13.Width = 0.5625F;
			// 
			// AtacName14
			// 
			this.AtacName14.Border.BottomColor = System.Drawing.Color.Black;
			this.AtacName14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName14.Border.LeftColor = System.Drawing.Color.Black;
			this.AtacName14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName14.Border.RightColor = System.Drawing.Color.Black;
			this.AtacName14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName14.Border.TopColor = System.Drawing.Color.Black;
			this.AtacName14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.AtacName14.DataField = "ATAC_NAME14";
			this.AtacName14.Height = 0.25F;
			this.AtacName14.Left = 8.3125F;
			this.AtacName14.Name = "AtacName14";
			this.AtacName14.Style = "ddo-char-set: 1; text-align: left; font-size: 6pt; white-space: inherit; vertical" +
				"-align: top; ";
			this.AtacName14.Text = "あいうえおかきくけこ";
			this.AtacName14.Top = 0.4375001F;
			this.AtacName14.Width = 0.5625F;
			// 
			// Kubun14
			// 
			this.Kubun14.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun14.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun14.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun14.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun14.Height = 0.145F;
			this.Kubun14.Left = 8.3125F;
			this.Kubun14.Name = "Kubun14";
			this.Kubun14.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun14.Text = "あ";
			this.Kubun14.Top = 0.25F;
			this.Kubun14.Width = 0.1875F;
			// 
			// PaymntYm14
			// 
			this.PaymntYm14.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntYm14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm14.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntYm14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm14.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntYm14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm14.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntYm14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntYm14.DataField = "PAYMNT_YM14";
			this.PaymntYm14.Height = 0.145F;
			this.PaymntYm14.Left = 8.5F;
			this.PaymntYm14.Name = "PaymntYm14";
			this.PaymntYm14.Style = "ddo-char-set: 1; font-size: 6pt; white-space: inherit; vertical-align: top; ";
			this.PaymntYm14.Text = "6666/66";
			this.PaymntYm14.Top = 0.25F;
			this.PaymntYm14.Width = 0.3749999F;
			// 
			// Line240
			// 
			this.Line240.Border.BottomColor = System.Drawing.Color.Black;
			this.Line240.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line240.Border.LeftColor = System.Drawing.Color.Black;
			this.Line240.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line240.Border.RightColor = System.Drawing.Color.Black;
			this.Line240.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line240.Border.TopColor = System.Drawing.Color.Black;
			this.Line240.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line240.Height = 0.75F;
			this.Line240.Left = 9.5F;
			this.Line240.LineWeight = 1F;
			this.Line240.Name = "Line240";
			this.Line240.Top = 0.1875F;
			this.Line240.Width = 0F;
			this.Line240.X1 = 9.5F;
			this.Line240.X2 = 9.5F;
			this.Line240.Y1 = 0.1875F;
			this.Line240.Y2 = 0.9375F;
			// 
			// Line241
			// 
			this.Line241.Border.BottomColor = System.Drawing.Color.Black;
			this.Line241.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line241.Border.LeftColor = System.Drawing.Color.Black;
			this.Line241.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line241.Border.RightColor = System.Drawing.Color.Black;
			this.Line241.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line241.Border.TopColor = System.Drawing.Color.Black;
			this.Line241.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line241.Height = 0.75F;
			this.Line241.Left = 10.125F;
			this.Line241.LineWeight = 1F;
			this.Line241.Name = "Line241";
			this.Line241.Top = 0.1875F;
			this.Line241.Width = 0F;
			this.Line241.X1 = 10.125F;
			this.Line241.X2 = 10.125F;
			this.Line241.Y1 = 0.1875F;
			this.Line241.Y2 = 0.9375F;
			// 
			// Kubun13
			// 
			this.Kubun13.Border.BottomColor = System.Drawing.Color.Black;
			this.Kubun13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun13.Border.LeftColor = System.Drawing.Color.Black;
			this.Kubun13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun13.Border.RightColor = System.Drawing.Color.Black;
			this.Kubun13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun13.Border.TopColor = System.Drawing.Color.Black;
			this.Kubun13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Kubun13.Height = 0.145F;
			this.Kubun13.Left = 7.75F;
			this.Kubun13.Name = "Kubun13";
			this.Kubun13.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; white-space: inherit; vertic" +
				"al-align: top; ";
			this.Kubun13.Text = "あ";
			this.Kubun13.Top = 0.25F;
			this.Kubun13.Width = 0.1875F;
			// 
			// PaymntDate9
			// 
			this.PaymntDate9.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate9.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate9.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate9.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate9.DataField = "PAYMNT_DATE9";
			this.PaymntDate9.Height = 0.18F;
			this.PaymntDate9.Left = 5.5F;
			this.PaymntDate9.Name = "PaymntDate9";
			this.PaymntDate9.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate9.Text = "9999/99/99";
			this.PaymntDate9.Top = 0.75F;
			this.PaymntDate9.Width = 0.563F;
			// 
			// PaymntDate10
			// 
			this.PaymntDate10.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate10.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate10.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate10.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate10.DataField = "PAYMNT_DATE10";
			this.PaymntDate10.Height = 0.18F;
			this.PaymntDate10.Left = 6.0625F;
			this.PaymntDate10.Name = "PaymntDate10";
			this.PaymntDate10.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate10.Text = "9999/99/99";
			this.PaymntDate10.Top = 0.75F;
			this.PaymntDate10.Width = 0.563F;
			// 
			// PaymntDate11
			// 
			this.PaymntDate11.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate11.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate11.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate11.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate11.DataField = "PAYMNT_DATE11";
			this.PaymntDate11.Height = 0.18F;
			this.PaymntDate11.Left = 6.625F;
			this.PaymntDate11.Name = "PaymntDate11";
			this.PaymntDate11.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate11.Text = "9999/99/99";
			this.PaymntDate11.Top = 0.75F;
			this.PaymntDate11.Width = 0.563F;
			// 
			// PaymntDate12
			// 
			this.PaymntDate12.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate12.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate12.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate12.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate12.DataField = "PAYMNT_DATE12";
			this.PaymntDate12.Height = 0.18F;
			this.PaymntDate12.Left = 7.1875F;
			this.PaymntDate12.Name = "PaymntDate12";
			this.PaymntDate12.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate12.Text = "9999/99/99";
			this.PaymntDate12.Top = 0.75F;
			this.PaymntDate12.Width = 0.563F;
			// 
			// PaymntDate13
			// 
			this.PaymntDate13.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate13.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate13.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate13.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate13.DataField = "PAYMNT_DATE13";
			this.PaymntDate13.Height = 0.18F;
			this.PaymntDate13.Left = 7.75F;
			this.PaymntDate13.Name = "PaymntDate13";
			this.PaymntDate13.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate13.Text = "9999/99/99";
			this.PaymntDate13.Top = 0.75F;
			this.PaymntDate13.Width = 0.563F;
			// 
			// PaymntDate14
			// 
			this.PaymntDate14.Border.BottomColor = System.Drawing.Color.Black;
			this.PaymntDate14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate14.Border.LeftColor = System.Drawing.Color.Black;
			this.PaymntDate14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate14.Border.RightColor = System.Drawing.Color.Black;
			this.PaymntDate14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate14.Border.TopColor = System.Drawing.Color.Black;
			this.PaymntDate14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.PaymntDate14.DataField = "PAYMNT_DATE14";
			this.PaymntDate14.Height = 0.18F;
			this.PaymntDate14.Left = 8.3125F;
			this.PaymntDate14.Name = "PaymntDate14";
			this.PaymntDate14.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.PaymntDate14.Text = "9999/99/99";
			this.PaymntDate14.Top = 0.75F;
			this.PaymntDate14.Width = 0.563F;
			// 
			// Line242
			// 
			this.Line242.Border.BottomColor = System.Drawing.Color.Black;
			this.Line242.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line242.Border.LeftColor = System.Drawing.Color.Black;
			this.Line242.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line242.Border.RightColor = System.Drawing.Color.Black;
			this.Line242.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line242.Border.TopColor = System.Drawing.Color.Black;
			this.Line242.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line242.Height = 0.75F;
			this.Line242.Left = 10.75F;
			this.Line242.LineWeight = 1F;
			this.Line242.Name = "Line242";
			this.Line242.Top = 0.1875F;
			this.Line242.Width = 0F;
			this.Line242.X1 = 10.75F;
			this.Line242.X2 = 10.75F;
			this.Line242.Y1 = 0.1875F;
			this.Line242.Y2 = 0.9375F;
			// 
			// Label49
			// 
			this.Label49.Border.BottomColor = System.Drawing.Color.Black;
			this.Label49.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label49.Border.LeftColor = System.Drawing.Color.Black;
			this.Label49.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label49.Border.RightColor = System.Drawing.Color.Black;
			this.Label49.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label49.Border.TopColor = System.Drawing.Color.Black;
			this.Label49.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label49.Height = 0.3125F;
			this.Label49.HyperLink = null;
			this.Label49.Left = 8.875F;
			this.Label49.Name = "Label49";
			this.Label49.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.Label49.Text = "給与計";
			this.Label49.Top = 0.3124999F;
			this.Label49.Width = 0.6249998F;
			// 
			// Label50
			// 
			this.Label50.Border.BottomColor = System.Drawing.Color.Black;
			this.Label50.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label50.Border.LeftColor = System.Drawing.Color.Black;
			this.Label50.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label50.Border.RightColor = System.Drawing.Color.Black;
			this.Label50.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label50.Border.TopColor = System.Drawing.Color.Black;
			this.Label50.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label50.Height = 0.3125F;
			this.Label50.HyperLink = null;
			this.Label50.Left = 9.5F;
			this.Label50.Name = "Label50";
			this.Label50.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.Label50.Text = "賞与計";
			this.Label50.Top = 0.3124999F;
			this.Label50.Width = 0.6249997F;
			// 
			// Label51
			// 
			this.Label51.Border.BottomColor = System.Drawing.Color.Black;
			this.Label51.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label51.Border.LeftColor = System.Drawing.Color.Black;
			this.Label51.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label51.Border.RightColor = System.Drawing.Color.Black;
			this.Label51.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label51.Border.TopColor = System.Drawing.Color.Black;
			this.Label51.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label51.Height = 0.3125F;
			this.Label51.HyperLink = null;
			this.Label51.Left = 10.125F;
			this.Label51.Name = "Label51";
			this.Label51.Style = "ddo-char-set: 1; text-align: center; font-size: 6pt; vertical-align: middle; ";
			this.Label51.Text = "総合計";
			this.Label51.Top = 0.3124999F;
			this.Label51.Width = 0.6250002F;
			// 
			// Label52
			// 
			this.Label52.Border.BottomColor = System.Drawing.Color.Black;
			this.Label52.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label52.Border.LeftColor = System.Drawing.Color.Black;
			this.Label52.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label52.Border.RightColor = System.Drawing.Color.Black;
			this.Label52.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label52.Border.TopColor = System.Drawing.Color.Black;
			this.Label52.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label52.Height = 0.1875F;
			this.Label52.HyperLink = null;
			this.Label52.Left = 3.1875F;
			this.Label52.Name = "Label52";
			this.Label52.Style = "text-align: center; font-size: 9pt; vertical-align: middle; ";
			this.Label52.Text = "(";
			this.Label52.Top = 0F;
			this.Label52.Width = 0.125F;
			// 
			// Label53
			// 
			this.Label53.Border.BottomColor = System.Drawing.Color.Black;
			this.Label53.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label53.Border.LeftColor = System.Drawing.Color.Black;
			this.Label53.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label53.Border.RightColor = System.Drawing.Color.Black;
			this.Label53.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label53.Border.TopColor = System.Drawing.Color.Black;
			this.Label53.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Label53.Height = 0.1875F;
			this.Label53.HyperLink = null;
			this.Label53.Left = 3.5F;
			this.Label53.Name = "Label53";
			this.Label53.Style = "text-align: center; font-size: 9pt; vertical-align: middle; ";
			this.Label53.Text = ")";
			this.Label53.Top = 0F;
			this.Label53.Width = 0.125F;
			// 
			// Sex_Name
			// 
			this.Sex_Name.Border.BottomColor = System.Drawing.Color.Black;
			this.Sex_Name.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Name.Border.LeftColor = System.Drawing.Color.Black;
			this.Sex_Name.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Name.Border.RightColor = System.Drawing.Color.Black;
			this.Sex_Name.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Name.Border.TopColor = System.Drawing.Color.Black;
			this.Sex_Name.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Name.Height = 0.18F;
			this.Sex_Name.Left = 3.3125F;
			this.Sex_Name.Name = "Sex_Name";
			this.Sex_Name.Style = "ddo-char-set: 128; font-size: 9pt; vertical-align: middle; ";
			this.Sex_Name.Text = "男";
			this.Sex_Name.Top = 0F;
			this.Sex_Name.Width = 0.1875F;
			// 
			// Sex_Type
			// 
			this.Sex_Type.Border.BottomColor = System.Drawing.Color.Black;
			this.Sex_Type.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Type.Border.LeftColor = System.Drawing.Color.Black;
			this.Sex_Type.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Type.Border.RightColor = System.Drawing.Color.Black;
			this.Sex_Type.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Type.Border.TopColor = System.Drawing.Color.Black;
			this.Sex_Type.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Sex_Type.DataField = "SEX_TYPE";
			this.Sex_Type.Height = 0.1175F;
			this.Sex_Type.Left = 3.6875F;
			this.Sex_Type.Name = "Sex_Type";
			this.Sex_Type.Style = "ddo-char-set: 128; font-size: 8.25pt; vertical-align: middle; ";
			this.Sex_Type.Text = "DUMMY";
			this.Sex_Type.Top = 0.0625F;
			this.Sex_Type.Visible = false;
			this.Sex_Type.Width = 0.125F;
			// 
			// line3
			// 
			this.line3.Border.BottomColor = System.Drawing.Color.Black;
			this.line3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line3.Border.LeftColor = System.Drawing.Color.Black;
			this.line3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line3.Border.RightColor = System.Drawing.Color.Black;
			this.line3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line3.Border.TopColor = System.Drawing.Color.Black;
			this.line3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line3.Height = 0F;
			this.line3.Left = 0F;
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.Top = 0.9375F;
			this.line3.Width = 10.75F;
			this.line3.X1 = 0F;
			this.line3.X2 = 10.75F;
			this.line3.Y1 = 0.9375F;
			this.line3.Y2 = 0.9375F;
			// 
			// Line110
			// 
			this.Line110.AnchorBottom = true;
			this.Line110.Border.BottomColor = System.Drawing.Color.Black;
			this.Line110.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line110.Border.LeftColor = System.Drawing.Color.Black;
			this.Line110.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line110.Border.RightColor = System.Drawing.Color.Black;
			this.Line110.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line110.Border.TopColor = System.Drawing.Color.Black;
			this.Line110.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.Line110.Height = 0.75F;
			this.Line110.Left = 0F;
			this.Line110.LineWeight = 1F;
			this.Line110.Name = "Line110";
			this.Line110.Top = 0.1875F;
			this.Line110.Width = 0F;
			this.Line110.X1 = 0F;
			this.Line110.X2 = 0F;
			this.Line110.Y1 = 0.1875F;
			this.Line110.Y2 = 0.9375F;
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// GroupHeader2
			// 
			this.GroupHeader2.CanShrink = true;
			this.GroupHeader2.Height = 0F;
			this.GroupHeader2.Name = "GroupHeader2";
			this.GroupHeader2.UnderlayNext = true;
			this.GroupHeader2.Visible = false;
			this.GroupHeader2.Format += new System.EventHandler(this.GroupHeader2_Format);
			this.GroupHeader2.AfterPrint += new System.EventHandler(this.GroupHeader2_AfterPrint);
			// 
			// GroupFooter2
			// 
			this.GroupFooter2.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.line2});
			this.GroupFooter2.Height = 0F;
			this.GroupFooter2.Name = "GroupFooter2";
			// 
			// line2
			// 
			this.line2.Border.BottomColor = System.Drawing.Color.Black;
			this.line2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line2.Border.LeftColor = System.Drawing.Color.Black;
			this.line2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line2.Border.RightColor = System.Drawing.Color.Black;
			this.line2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line2.Border.TopColor = System.Drawing.Color.Black;
			this.line2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None;
			this.line2.Height = 0F;
			this.line2.Left = 0F;
			this.line2.LineWeight = 1F;
			this.line2.Name = "line2";
			this.line2.Top = 0F;
			this.line2.Width = 10.75F;
			this.line2.X1 = 0F;
			this.line2.X2 = 10.75F;
			this.line2.Y1 = 0F;
			this.line2.Y2 = 0F;
			// 
			// HR_PY_03_R28
			// 
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.5F;
			this.PageSettings.Margins.Left = 0.4F;
			this.PageSettings.Margins.Right = 0.4F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.268056F;
			this.PrintWidth = 10.78F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.GroupHeader2);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter2);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
						"ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
						"ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
						"ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R28_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.ItemName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SortKey)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYmFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYmto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kubun13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sex_Name)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sex_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		#region コメントアウト
//		public HR_PY_03_R28()
//		{
//			InitializeComponent();
//		}
//		
//		#region Protected Fields
//		protected string reportID;
//		protected string companyName;
//		private Line Line226;
//		protected CommonData cd;
//
//		#endregion
//		#region Properties
//		public string ReportID
//		{
//			get {return reportID;}
//			set {reportID = value;}
//		}
//
//		public string CompanyName
//		{
//			get {return companyName;}
//			set {companyName = value;}
//		}
//
//		public CommonData commonData
//		{
//			get {return cd;}
//			set {cd = value;}
//		}
//	
//		#endregion

// 管理番号 K23028 コメント削除
// 管理番号 B19330 コメント削除
// 管理番号 B17275 コメント削除

//		#region ActiveReports Designer generated code
//		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGE = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label3 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGESUM = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label4 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox DateText = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox ReportIDText = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PrintName = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYmFrom = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label43 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label46 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label47 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYmto = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label48 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line86 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label8 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line110 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line198 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label44 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line199 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line82 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line95 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label45 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line208 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line227 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line228 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line229 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm3 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName3 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate3 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun3 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName4 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun4 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm4 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate4 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line230 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line231 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm5 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName5 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate5 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate6 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName6 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun6 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm6 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line232 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line233 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm7 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName7 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate7 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun7 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName8 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun8 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm8 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate8 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun5 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line234 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line235 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm9 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName9 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun9 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName10 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun10 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm10 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line236 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line237 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm11 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName11 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun11 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName12 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun12 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm12 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line238 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line239 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm13 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName13 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName14 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun14 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm14 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line240 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line241 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Kubun13 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate9 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate10 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate11 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate12 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate13 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate14 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line242 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label49 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label50 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label51 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label52 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Label Label53 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Sex_Name = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Sex_Type = null;
//		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line211 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line214 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line215 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line216 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line217 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line218 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line219 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line220 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line221 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line222 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line223 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line224 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line212 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line225 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Title = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt1_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt2_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt3_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt5_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt6_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt7_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt4_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt8_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt9_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt10_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt11_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line213 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Format2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt1_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt2_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line243 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt3_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line244 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line245 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line246 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line247 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line248 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line249 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line250 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt12_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt13_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt14_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt6_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt4_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt5_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt7_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt8_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt9_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt10_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt11_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt12_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt17_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt17_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt19_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt19_1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt18_2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox Format1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox CalRsltZeroFlg2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox CalRsltZeroFlg1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PyItemName1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox PyItemName2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox LineNo = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line251 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line252 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line253 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line254 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line255 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line256 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line257 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line258 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line259 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line260 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line261 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line262 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line263 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line264 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.Line Line265 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter2 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
//		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
//		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;

// 管理番号 K23028 コメント削除

//
//		#endregion
		#endregion
// 管理番号 K23028 To
	}
}
