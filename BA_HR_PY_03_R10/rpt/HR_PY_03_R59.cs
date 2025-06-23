// Product     : GRANDIT
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R59.cs
// 機能名      : HR_PY_03_R59 給与台帳
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K17838 2007/02/15 給与関連帳票 新規追加 機能拡充
// 1.5.1 2007/06/30
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 K24565 2012/06/06 ActiveReportsバージョンアップ対応
// 2.0.0 2012/10/31
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

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_03_R59 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R59()
		{


			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
		protected CommonData cd;
		protected string title;
		protected string pageCnt;
		protected int lineCnt;			// 行カウント
		protected int maxLineCnt = 69;	// 最大行数
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

		#region HR_PY_03_R59_ReportStart
		private void HR_PY_03_R59_ReportStart(object sender, System.EventArgs eArgs)
		{
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

			DateText.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
		}
		#endregion

		#region PageHeader_Format
		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
			ReportIDText.Text = reportID;
			lineCnt = 0;
		}
		#endregion

		#region GroupHeader1_Format
		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{
			//支給年月未セット時は表題を非表示		
			if (PaymntYm.Text == null || PaymntYm.Text.Length == 0)
			{
				MonthCaption.Visible = false;
			}
			else
			{
				MonthCaption.Visible = true;
			}
		}
		#endregion

		#region GroupHeader2_AfterPrint
		private void GroupHeader2_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}
		#endregion

		#region GroupHeader3_AfterPrint
		private void GroupHeader3_AfterPrint(object sender, System.EventArgs eArgs)
		{
//			Amt1.OutputFormat = Format.Text;
//			Amt2.OutputFormat = Format.Text;
//			Amt3.OutputFormat = Format.Text;
//			Amt4.OutputFormat = Format.Text;
//			Amt5.OutputFormat = Format.Text;
//			Amt6.OutputFormat = Format.Text;
//			Amt7.OutputFormat = Format.Text;
//			Amt8.OutputFormat = Format.Text;
		}
		#endregion

		#region Detail_BeforePrint
		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
			if (pageCnt != PageCount.Text)
			{
				title = "";
			}

			if (title != Title.Text)
			{
				Title.Visible = true;
				if (title != null && title.Length != 0)
				{
					lineDetailTop.Visible = true;
				}
				else
				{
					lineDetailTop.Visible = false;
				}

			}
			else
			{
				Title.Visible = false;
				lineDetailTop.Visible = false;
			}
			title = Title.Text;
			pageCnt = PageCount.Text;


			lineCnt += 1;	//行カウント
			//最終行の場合は罫線を表示
			if (lineCnt % this.maxLineCnt == 0)
			{
				Line262.Visible = true;
			}
			else
			{
				Line262.Visible = false;
			}
		}
		#endregion

		#region Detail_Format
		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			lineDetailBottom.Visible = true;
		}
		#endregion

		#region Detail_AfterPrint
		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}
		#endregion

		#region GroupFooter1_Format
		private void GroupFooter1_Format(object sender, System.EventArgs eArgs)
		{
			lineDetailBottom.Visible = false;
		}
		#endregion

		#region GroupHeader2_Format
		private void GroupHeader2_Format(object sender, System.EventArgs eArgs)
		{
			//所属名未セット時は表題を非表示
			if (BrkAtacName.Text == null || BrkAtacName.Text.Length == 0)
			{
				ActCaption.Visible = false;
			}
			else
			{
				ActCaption.Visible = true;
			}
			//明細行の表示制御
			this.VisibleAmtControl();
			//合計人数の表示
			this.SetTotalCountText();
		}
		#endregion

		#region GroupHeader3_Format
		private void GroupHeader3_Format(object sender, System.EventArgs eArgs)
		{
			Amt1.OutputFormat = Format.Text;
			Amt2.OutputFormat = Format.Text;
			Amt3.OutputFormat = Format.Text;
			Amt4.OutputFormat = Format.Text;
			Amt5.OutputFormat = Format.Text;
			Amt6.OutputFormat = Format.Text;
			Amt7.OutputFormat = Format.Text;
			Amt8.OutputFormat = Format.Text;
		}
		#endregion

		#region PageFooter_Format
		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
			CompanyNameText.Text = companyName;
		}
		#endregion

		#region PageFooter_AfterPrint
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
		}
		#endregion

		#region 明細行の表示制御
		private void VisibleAmtControl()
		{
			//社員番号がNULLの時、明細行を表示しない
			if ((EmpCode1.Text == null) || (EmpCode1.Text.Length == 0))
			{
				Amt1.Visible = false;
			}
			if ((EmpCode2.Text == null) || (EmpCode2.Text.Length == 0))
			{
				Amt2.Visible = false;
			}
			if ((EmpCode3.Text == null) || (EmpCode3.Text.Length == 0))
			{
				Amt3.Visible = false;
			}
			if ((EmpCode4.Text == null) || (EmpCode4.Text.Length == 0))
			{
				Amt4.Visible = false;
			}
			if ((EmpCode5.Text == null) || (EmpCode5.Text.Length == 0))
			{
				Amt5.Visible = false;
			}
			if ((EmpCode6.Text == null) || (EmpCode6.Text.Length == 0))
			{
				Amt6.Visible = false;
			}
			if ((EmpCode7.Text == null) || (EmpCode7.Text.Length == 0))
			{
				Amt7.Visible = false;
			}
			if ((EmpCode8.Text == null) || (EmpCode8.Text.Length == 0))
			{
				Amt8.Visible = false;
			}
		}
		#endregion

		#region 合計人数の表示
		private void SetTotalCountText()
		{
			//合計の場合、表題の社員番号を表示しない
			if (EmpCode1.Text == "TOTAL")
			{
				EmpCode1.Visible = false;
				TotalCnt1.Visible = true;
				if (TotalCnt1.Text.IndexOf("名") < 0)
				{
					TotalCnt1.Text = TotalCnt1.Text + " 名";
				}
			}
			if (EmpCode2.Text == "TOTAL")
			{
				EmpCode2.Visible = false;
				TotalCnt2.Visible = true;
				if (TotalCnt2.Text.IndexOf("名") < 0)
				{
					TotalCnt2.Text = TotalCnt2.Text + " 名";
				}
			}
			if (EmpCode3.Text == "TOTAL")
			{
				EmpCode3.Visible = false;
				TotalCnt3.Visible = true;
				if (TotalCnt3.Text.IndexOf("名") < 0)
				{
					TotalCnt3.Text = TotalCnt3.Text + " 名";
				}
			}
			if (EmpCode4.Text == "TOTAL")
			{
				EmpCode4.Visible = false;
				TotalCnt4.Visible = true;
				if (TotalCnt4.Text.IndexOf("名") < 0)
				{
					TotalCnt4.Text = TotalCnt4.Text + " 名";
				}
			}
			if (EmpCode5.Text == "TOTAL")
			{
				EmpCode5.Visible = false;
				TotalCnt5.Visible = true;
				if (TotalCnt5.Text.IndexOf("名") < 0)
				{
					TotalCnt5.Text = TotalCnt5.Text + " 名";
				}
			}
			if (EmpCode6.Text == "TOTAL")
			{
				EmpCode6.Visible = false;
				TotalCnt6.Visible = true;
				if (TotalCnt6.Text.IndexOf("名") < 0)
				{
					TotalCnt6.Text = TotalCnt6.Text + " 名";
				}
			}
			if (EmpCode7.Text == "TOTAL")
			{
				EmpCode7.Visible = false;
				TotalCnt7.Visible = true;
				if (TotalCnt7.Text.IndexOf("名") < 0)
				{
					TotalCnt7.Text = TotalCnt7.Text + " 名";
				}
			}
			if (EmpCode8.Text == "TOTAL")
			{
				EmpCode8.Visible = false;
				TotalCnt8.Visible = true;
				if (TotalCnt8.Text.IndexOf("名") < 0)
				{
					TotalCnt8.Text = TotalCnt8.Text + " 名";
				}
			}
		}
		#endregion

		private void GroupFooter2_Format(object sender, System.EventArgs eArgs)
		{
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
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label MonthCaption = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label45 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntDate1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line208 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label49 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PageCount = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line95 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line246 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line259 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line258 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line257 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line256 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line255 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line254 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line253 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line252 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line251 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line248 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line247 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line96 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line110 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Dpnd_Total_Num6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TaxType6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TotalCnt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label ActCaption = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BrkAtacName = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Title = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PyItemName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LineNo = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Item_Code = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line215 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line216 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line217 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line218 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line219 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line220 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line221 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line224 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line212 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Amt6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line lineDetailTop = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line214 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line244 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line225 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Format = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line lineDetailBottom = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line262 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line261 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line260 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R59));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.Title = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PyItemName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LineNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Item_Code = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line215 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line216 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line217 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line218 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line219 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line220 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line221 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line224 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line212 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Amt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Amt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lineDetailTop = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line214 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line244 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line225 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Format = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lineDetailBottom = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line262 = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.PaymntYm = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MonthCaption = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.Line260 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.GroupHeader2 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.AtacName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntDate8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PaymntDate1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label49 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PageCount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line95 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.TotalCnt8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line246 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line259 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line258 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line257 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line256 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line255 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line254 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line253 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line252 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line251 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line248 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line247 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line96 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Dpnd_Total_Num3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line110 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.EmpCode2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Dpnd_Total_Num6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TaxType6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TotalCnt1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ActCaption = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.BrkAtacName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GroupFooter2 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.Line261 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.GroupHeader3 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter3 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PyItemName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LineNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Item_Code)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Format)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MonthCaption)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PageCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActCaption)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BrkAtacName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Title,
            this.Amt2,
            this.Amt1,
            this.Amt7,
            this.PyItemName,
            this.LineNo,
            this.Item_Code,
            this.Amt8,
            this.Line215,
            this.Line216,
            this.Line217,
            this.Line218,
            this.Line219,
            this.Line220,
            this.Line221,
            this.Line224,
            this.Line212,
            this.Amt3,
            this.Amt4,
            this.Amt5,
            this.Amt6,
            this.lineDetailTop,
            this.Line214,
            this.Line244,
            this.Line225,
            this.Format,
            this.lineDetailBottom,
            this.Line262});
			this.Detail.Height = 0.19F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// Title
			// 
			this.Title.DataField = "TITLE";
			this.Title.Height = 0.17F;
			this.Title.Left = 0.195F;
			this.Title.Name = "Title";
			this.Title.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Title.Text = "給与ワーク";
			this.Title.Top = 0F;
			this.Title.Width = 0.68F;
			// 
			// Amt2
			// 
			this.Amt2.DataField = "AMT2";
			this.Amt2.Height = 0.18F;
			this.Amt2.Left = 3.367F;
			this.Amt2.Name = "Amt2";
			this.Amt2.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt2.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt2.Top = 0F;
			this.Amt2.Width = 0.9175F;
			// 
			// Amt1
			// 
			this.Amt1.DataField = "AMT1";
			this.Amt1.Height = 0.18F;
			this.Amt1.Left = 2.395F;
			this.Amt1.Name = "Amt1";
			this.Amt1.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt1.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt1.Top = 0F;
			this.Amt1.Width = 0.9175F;
			// 
			// Amt7
			// 
			this.Amt7.DataField = "AMT7";
			this.Amt7.Height = 0.18F;
			this.Amt7.Left = 8.241F;
			this.Amt7.Name = "Amt7";
			this.Amt7.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt7.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt7.Top = 0F;
			this.Amt7.Width = 0.9175F;
			// 
			// PyItemName
			// 
			this.PyItemName.DataField = "PY_ITEM_NAME";
			this.PyItemName.Height = 0.18F;
			this.PyItemName.Left = 1.467917F;
			this.PyItemName.Name = "PyItemName";
			this.PyItemName.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 1";
			this.PyItemName.Text = "あいうえおか";
			this.PyItemName.Top = 0F;
			this.PyItemName.Width = 0.9070833F;
			// 
			// LineNo
			// 
			this.LineNo.DataField = "LINE_NO";
			this.LineNo.Height = 0.18F;
			this.LineNo.Left = 1.8125F;
			this.LineNo.Name = "LineNo";
			this.LineNo.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.LineNo.Text = null;
			this.LineNo.Top = 0F;
			this.LineNo.Visible = false;
			this.LineNo.Width = 0.54F;
			// 
			// Item_Code
			// 
			this.Item_Code.DataField = "ITEM_CODE";
			this.Item_Code.Height = 0.18F;
			this.Item_Code.Left = 0.925F;
			this.Item_Code.Name = "Item_Code";
			this.Item_Code.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 1";
			this.Item_Code.Text = "MMMMMM";
			this.Item_Code.Top = 0F;
			this.Item_Code.Width = 0.5F;
			// 
			// Amt8
			// 
			this.Amt8.DataField = "AMT8";
			this.Amt8.Height = 0.18F;
			this.Amt8.Left = 9.218F;
			this.Amt8.Name = "Amt8";
			this.Amt8.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt8.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt8.Top = 0F;
			this.Amt8.Width = 0.9175F;
			// 
			// Line215
			// 
			this.Line215.Height = 0.187F;
			this.Line215.Left = 3.349F;
			this.Line215.LineWeight = 1F;
			this.Line215.Name = "Line215";
			this.Line215.Top = 0F;
			this.Line215.Width = 0F;
			this.Line215.X1 = 3.349F;
			this.Line215.X2 = 3.349F;
			this.Line215.Y1 = 0F;
			this.Line215.Y2 = 0.187F;
			// 
			// Line216
			// 
			this.Line216.Height = 0.187F;
			this.Line216.Left = 4.325999F;
			this.Line216.LineWeight = 1F;
			this.Line216.Name = "Line216";
			this.Line216.Top = 0F;
			this.Line216.Width = 0F;
			this.Line216.X1 = 4.325999F;
			this.Line216.X2 = 4.325999F;
			this.Line216.Y1 = 0F;
			this.Line216.Y2 = 0.187F;
			// 
			// Line217
			// 
			this.Line217.Height = 0.187F;
			this.Line217.Left = 5.302F;
			this.Line217.LineWeight = 1F;
			this.Line217.Name = "Line217";
			this.Line217.Top = 0F;
			this.Line217.Width = 0F;
			this.Line217.X1 = 5.302F;
			this.Line217.X2 = 5.302F;
			this.Line217.Y1 = 0F;
			this.Line217.Y2 = 0.187F;
			// 
			// Line218
			// 
			this.Line218.Height = 0.187F;
			this.Line218.Left = 6.279F;
			this.Line218.LineWeight = 1F;
			this.Line218.Name = "Line218";
			this.Line218.Top = 0F;
			this.Line218.Width = 0F;
			this.Line218.X1 = 6.279F;
			this.Line218.X2 = 6.279F;
			this.Line218.Y1 = 0F;
			this.Line218.Y2 = 0.187F;
			// 
			// Line219
			// 
			this.Line219.Height = 0.187F;
			this.Line219.Left = 7.255F;
			this.Line219.LineWeight = 1F;
			this.Line219.Name = "Line219";
			this.Line219.Top = 0F;
			this.Line219.Width = 0F;
			this.Line219.X1 = 7.255F;
			this.Line219.X2 = 7.255F;
			this.Line219.Y1 = 0F;
			this.Line219.Y2 = 0.187F;
			// 
			// Line220
			// 
			this.Line220.Height = 0.187F;
			this.Line220.Left = 8.232F;
			this.Line220.LineWeight = 1F;
			this.Line220.Name = "Line220";
			this.Line220.Top = 0F;
			this.Line220.Width = 0F;
			this.Line220.X1 = 8.232F;
			this.Line220.X2 = 8.232F;
			this.Line220.Y1 = 0F;
			this.Line220.Y2 = 0.187F;
			// 
			// Line221
			// 
			this.Line221.Height = 0.187F;
			this.Line221.Left = 9.207999F;
			this.Line221.LineWeight = 1F;
			this.Line221.Name = "Line221";
			this.Line221.Top = 0F;
			this.Line221.Width = 0F;
			this.Line221.X1 = 9.207999F;
			this.Line221.X2 = 9.207999F;
			this.Line221.Y1 = 0F;
			this.Line221.Y2 = 0.187F;
			// 
			// Line224
			// 
			this.Line224.Height = 0.188F;
			this.Line224.Left = 10.185F;
			this.Line224.LineWeight = 1F;
			this.Line224.Name = "Line224";
			this.Line224.Top = 0F;
			this.Line224.Width = 0F;
			this.Line224.X1 = 10.185F;
			this.Line224.X2 = 10.185F;
			this.Line224.Y1 = 0F;
			this.Line224.Y2 = 0.188F;
			// 
			// Line212
			// 
			this.Line212.Height = 0.19F;
			this.Line212.Left = 0.188F;
			this.Line212.LineWeight = 1F;
			this.Line212.Name = "Line212";
			this.Line212.Top = 0F;
			this.Line212.Width = 0F;
			this.Line212.X1 = 0.188F;
			this.Line212.X2 = 0.188F;
			this.Line212.Y1 = 0F;
			this.Line212.Y2 = 0.19F;
			// 
			// Amt3
			// 
			this.Amt3.DataField = "AMT3";
			this.Amt3.Height = 0.18F;
			this.Amt3.Left = 4.339F;
			this.Amt3.Name = "Amt3";
			this.Amt3.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt3.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt3.Top = 0F;
			this.Amt3.Width = 0.9175F;
			// 
			// Amt4
			// 
			this.Amt4.DataField = "AMT4";
			this.Amt4.Height = 0.18F;
			this.Amt4.Left = 5.31F;
			this.Amt4.Name = "Amt4";
			this.Amt4.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt4.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt4.Top = 0F;
			this.Amt4.Width = 0.9175F;
			// 
			// Amt5
			// 
			this.Amt5.DataField = "AMT5";
			this.Amt5.Height = 0.18F;
			this.Amt5.Left = 6.287F;
			this.Amt5.Name = "Amt5";
			this.Amt5.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt5.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt5.Top = 0F;
			this.Amt5.Width = 0.9175F;
			// 
			// Amt6
			// 
			this.Amt6.DataField = "AMT6";
			this.Amt6.Height = 0.18F;
			this.Amt6.Left = 7.26375F;
			this.Amt6.Name = "Amt6";
			this.Amt6.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Amt6.Text = "-Z,ZZZ,ZZZ,ZZ6";
			this.Amt6.Top = 0F;
			this.Amt6.Width = 0.9175F;
			// 
			// lineDetailTop
			// 
			this.lineDetailTop.Height = 0F;
			this.lineDetailTop.Left = 0.185F;
			this.lineDetailTop.LineWeight = 1F;
			this.lineDetailTop.Name = "lineDetailTop";
			this.lineDetailTop.Top = 0F;
			this.lineDetailTop.Width = 10F;
			this.lineDetailTop.X1 = 0.185F;
			this.lineDetailTop.X2 = 10.185F;
			this.lineDetailTop.Y1 = 0F;
			this.lineDetailTop.Y2 = 0F;
			// 
			// Line214
			// 
			this.Line214.Height = 0.187F;
			this.Line214.Left = 2.375F;
			this.Line214.LineWeight = 1F;
			this.Line214.Name = "Line214";
			this.Line214.Top = 0F;
			this.Line214.Width = 0F;
			this.Line214.X1 = 2.375F;
			this.Line214.X2 = 2.375F;
			this.Line214.Y1 = 0F;
			this.Line214.Y2 = 0.187F;
			// 
			// Line244
			// 
			this.Line244.Height = 0.187F;
			this.Line244.Left = 1.444444F;
			this.Line244.LineWeight = 1F;
			this.Line244.Name = "Line244";
			this.Line244.Top = 0F;
			this.Line244.Width = 0F;
			this.Line244.X1 = 1.444444F;
			this.Line244.X2 = 1.444444F;
			this.Line244.Y1 = 0F;
			this.Line244.Y2 = 0.187F;
			// 
			// Line225
			// 
			this.Line225.Height = 0.187F;
			this.Line225.Left = 0.882F;
			this.Line225.LineWeight = 1F;
			this.Line225.Name = "Line225";
			this.Line225.Top = 0F;
			this.Line225.Width = 0F;
			this.Line225.X1 = 0.882F;
			this.Line225.X2 = 0.882F;
			this.Line225.Y1 = 0F;
			this.Line225.Y2 = 0.187F;
			// 
			// Format
			// 
			this.Format.DataField = "FORMAT";
			this.Format.Height = 0.125F;
			this.Format.Left = 1.6F;
			this.Format.Name = "Format";
			this.Format.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.Format.Text = null;
			this.Format.Top = 0.035F;
			this.Format.Visible = false;
			this.Format.Width = 0.7291667F;
			// 
			// lineDetailBottom
			// 
			this.lineDetailBottom.Height = 0F;
			this.lineDetailBottom.Left = 0.8819444F;
			this.lineDetailBottom.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.lineDetailBottom.LineWeight = 1F;
			this.lineDetailBottom.Name = "lineDetailBottom";
			this.lineDetailBottom.Top = 0.188F;
			this.lineDetailBottom.Width = 9.305495F;
			this.lineDetailBottom.X1 = 0.8819444F;
			this.lineDetailBottom.X2 = 10.18744F;
			this.lineDetailBottom.Y1 = 0.188F;
			this.lineDetailBottom.Y2 = 0.188F;
			// 
			// Line262
			// 
			this.Line262.Height = 0F;
			this.Line262.Left = 0.185F;
			this.Line262.LineWeight = 1F;
			this.Line262.Name = "Line262";
			this.Line262.Top = 0.188F;
			this.Line262.Visible = false;
			this.Line262.Width = 10F;
			this.Line262.X1 = 0.185F;
			this.Line262.X2 = 10.185F;
			this.Line262.Y1 = 0.188F;
			this.Line262.Y2 = 0.188F;
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label2,
            this.PAGE,
            this.Label3,
            this.PAGESUM,
            this.Label4,
            this.DateText,
            this.ReportIDText,
            this.PrintName});
			this.PageHeader.Height = 0.4270833F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			// 
			// Label2
			// 
			this.Label2.Height = 0.2F;
			this.Label2.HyperLink = null;
			this.Label2.Left = 8.3125F;
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
			this.PAGE.Left = 8.9375F;
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
			this.Label3.Left = 9.3125F;
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
			this.PAGESUM.Left = 9.395833F;
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
			this.Label4.Height = 0.1875F;
			this.Label4.HyperLink = null;
			this.Label4.Left = 8.3125F;
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
			this.DateText.Left = 8.9375F;
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
			this.ReportIDText.Left = 0.1875F;
			this.ReportIDText.Name = "ReportIDText";
			this.ReportIDText.Style = "font-size: 9pt; white-space: nowrap; ddo-char-set: 1";
			this.ReportIDText.Text = "(HR_PY_03_R59)";
			this.ReportIDText.Top = 0F;
			this.ReportIDText.Width = 1.6875F;
			// 
			// PrintName
			// 
			this.PrintName.DataField = "PRINT_NAME";
			this.PrintName.Height = 0.25F;
			this.PrintName.Left = 3.1875F;
			this.PrintName.Name = "PrintName";
			this.PrintName.Style = "font-size: 14pt; text-align: center; ddo-char-set: 1";
			this.PrintName.Text = "タイトル";
			this.PrintName.Top = 0F;
			this.PrintName.Width = 4.125F;
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.CompanyNameText});
			this.PageFooter.Height = 0.1875F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Format += new System.EventHandler(this.PageFooter_Format);
			this.PageFooter.AfterPrint += new System.EventHandler(this.PageFooter_AfterPrint);
			// 
			// CompanyNameText
			// 
			this.CompanyNameText.CanGrow = false;
			this.CompanyNameText.Height = 0.1875F;
			this.CompanyNameText.Left = 0.1875F;
			this.CompanyNameText.Name = "CompanyNameText";
			this.CompanyNameText.Style = "font-size: 9pt; text-align: right; white-space: nowrap; ddo-char-set: 1";
			this.CompanyNameText.Text = null;
			this.CompanyNameText.Top = 0F;
			this.CompanyNameText.Width = 10F;
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.ColumnLayout = false;
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.PaymntYm,
            this.MonthCaption});
			this.GroupHeader1.DataField = "PAYMNT_YM";
			this.GroupHeader1.Height = 0.1875F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before;
			this.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			this.GroupHeader1.Format += new System.EventHandler(this.GroupHeader1_Format);
			// 
			// PaymntYm
			// 
			this.PaymntYm.DataField = "PAYMNT_YM";
			this.PaymntYm.Height = 0.18F;
			this.PaymntYm.Left = 4.875F;
			this.PaymntYm.Name = "PaymntYm";
			this.PaymntYm.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 128";
			this.PaymntYm.Text = "9999/99";
			this.PaymntYm.Top = 0F;
			this.PaymntYm.Width = 0.5F;
			// 
			// MonthCaption
			// 
			this.MonthCaption.Height = 0.18F;
			this.MonthCaption.HyperLink = null;
			this.MonthCaption.Left = 5.375F;
			this.MonthCaption.Name = "MonthCaption";
			this.MonthCaption.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 128";
			this.MonthCaption.Text = "月度";
			this.MonthCaption.Top = 0F;
			this.MonthCaption.Width = 0.438F;
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Line260});
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			this.GroupFooter1.Format += new System.EventHandler(this.GroupFooter1_Format);
			// 
			// Line260
			// 
			this.Line260.Height = 0F;
			this.Line260.Left = 0.185F;
			this.Line260.LineWeight = 1F;
			this.Line260.Name = "Line260";
			this.Line260.Top = 0F;
			this.Line260.Width = 10F;
			this.Line260.X1 = 0.185F;
			this.Line260.X2 = 10.185F;
			this.Line260.Y1 = 0F;
			this.Line260.Y2 = 0F;
			// 
			// GroupHeader2
			// 
			this.GroupHeader2.CanGrow = false;
			this.GroupHeader2.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.AtacName1,
            this.Label45,
            this.PaymntDate8,
            this.PaymntDate7,
            this.PaymntDate6,
            this.PaymntDate5,
            this.PaymntDate4,
            this.PaymntDate3,
            this.PaymntDate2,
            this.PaymntDate1,
            this.Line208,
            this.Label8,
            this.Label47,
            this.Label48,
            this.Label44,
            this.Label49,
            this.PageCount,
            this.Line95,
            this.TotalCnt8,
            this.TotalCnt7,
            this.TotalCnt6,
            this.TotalCnt5,
            this.TotalCnt4,
            this.TotalCnt3,
            this.TotalCnt2,
            this.Line246,
            this.Line259,
            this.Line258,
            this.Line257,
            this.Line256,
            this.Line255,
            this.Line254,
            this.Line253,
            this.Line252,
            this.Line251,
            this.Line248,
            this.Line247,
            this.Line96,
            this.Dpnd_Total_Num3,
            this.Dpnd_Total_Num7,
            this.Dpnd_Total_Num5,
            this.Dpnd_Total_Num4,
            this.Dpnd_Total_Num1,
            this.Dpnd_Total_Num8,
            this.TaxType3,
            this.TaxType7,
            this.TaxType5,
            this.TaxType4,
            this.TaxType1,
            this.TaxType8,
            this.EmpName3,
            this.EmpCode3,
            this.AtacName3,
            this.AtacName7,
            this.EmpName7,
            this.EmpCode7,
            this.AtacName5,
            this.EmpName5,
            this.EmpCode5,
            this.AtacName4,
            this.EmpName4,
            this.EmpCode4,
            this.EmpName1,
            this.EmpCode1,
            this.AtacName8,
            this.EmpCode8,
            this.EmpName8,
            this.Line110,
            this.EmpCode2,
            this.EmpName2,
            this.TaxType2,
            this.Dpnd_Total_Num2,
            this.AtacName2,
            this.Dpnd_Total_Num6,
            this.TaxType6,
            this.EmpName6,
            this.EmpCode6,
            this.AtacName6,
            this.TotalCnt1,
            this.ActCaption,
            this.BrkAtacName});
			this.GroupHeader2.DataField = "PAGE_NO";
			this.GroupHeader2.Height = 1.27F;
			this.GroupHeader2.Name = "GroupHeader2";
			this.GroupHeader2.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before;
			this.GroupHeader2.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			this.GroupHeader2.Format += new System.EventHandler(this.GroupHeader2_Format);
			this.GroupHeader2.AfterPrint += new System.EventHandler(this.GroupHeader2_AfterPrint);
			// 
			// AtacName1
			// 
			this.AtacName1.DataField = "ATAC_NAME1";
			this.AtacName1.Height = 0.25F;
			this.AtacName1.Left = 2.395F;
			this.AtacName1.Name = "AtacName1";
			this.AtacName1.Style = "font-size: 8.25pt; text-align: left; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 128";
			this.AtacName1.Text = "あいうえおかきくけこさしすせ";
			this.AtacName1.Top = 0.23F;
			this.AtacName1.Width = 0.9450001F;
			// 
			// Label45
			// 
			this.Label45.Height = 0.15F;
			this.Label45.HyperLink = null;
			this.Label45.Left = 0.25F;
			this.Label45.Name = "Label45";
			this.Label45.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label45.Text = "支給日";
			this.Label45.Top = 1.125F;
			this.Label45.Width = 2.125F;
			// 
			// PaymntDate8
			// 
			this.PaymntDate8.DataField = "PAYMNT_DATE8";
			this.PaymntDate8.Height = 0.15F;
			this.PaymntDate8.Left = 9.2175F;
			this.PaymntDate8.Name = "PaymntDate8";
			this.PaymntDate8.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate8.Text = "9999/99/99";
			this.PaymntDate8.Top = 1.121F;
			this.PaymntDate8.Width = 0.9450001F;
			// 
			// PaymntDate7
			// 
			this.PaymntDate7.DataField = "PAYMNT_DATE7";
			this.PaymntDate7.Height = 0.15F;
			this.PaymntDate7.Left = 8.240715F;
			this.PaymntDate7.Name = "PaymntDate7";
			this.PaymntDate7.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate7.Text = "9999/99/99";
			this.PaymntDate7.Top = 1.121F;
			this.PaymntDate7.Width = 0.9450001F;
			// 
			// PaymntDate6
			// 
			this.PaymntDate6.DataField = "PAYMNT_DATE6";
			this.PaymntDate6.Height = 0.15F;
			this.PaymntDate6.Left = 7.26393F;
			this.PaymntDate6.Name = "PaymntDate6";
			this.PaymntDate6.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate6.Text = "9999/99/99";
			this.PaymntDate6.Top = 1.121F;
			this.PaymntDate6.Width = 0.9450001F;
			// 
			// PaymntDate5
			// 
			this.PaymntDate5.DataField = "PAYMNT_DATE5";
			this.PaymntDate5.Height = 0.15F;
			this.PaymntDate5.Left = 6.287143F;
			this.PaymntDate5.Name = "PaymntDate5";
			this.PaymntDate5.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate5.Text = "9999/99/99";
			this.PaymntDate5.Top = 1.121F;
			this.PaymntDate5.Width = 0.9450001F;
			// 
			// PaymntDate4
			// 
			this.PaymntDate4.DataField = "PAYMNT_DATE4";
			this.PaymntDate4.Height = 0.15F;
			this.PaymntDate4.Left = 5.310357F;
			this.PaymntDate4.Name = "PaymntDate4";
			this.PaymntDate4.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate4.Text = "9999/99/99";
			this.PaymntDate4.Top = 1.121F;
			this.PaymntDate4.Width = 0.9450001F;
			// 
			// PaymntDate3
			// 
			this.PaymntDate3.DataField = "PAYMNT_DATE3";
			this.PaymntDate3.Height = 0.15F;
			this.PaymntDate3.Left = 4.338572F;
			this.PaymntDate3.Name = "PaymntDate3";
			this.PaymntDate3.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate3.Text = "9999/99/99";
			this.PaymntDate3.Top = 1.121F;
			this.PaymntDate3.Width = 0.9450001F;
			// 
			// PaymntDate2
			// 
			this.PaymntDate2.DataField = "PAYMNT_DATE2";
			this.PaymntDate2.Height = 0.15F;
			this.PaymntDate2.Left = 3.366785F;
			this.PaymntDate2.Name = "PaymntDate2";
			this.PaymntDate2.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate2.Text = "9999/99/99";
			this.PaymntDate2.Top = 1.121F;
			this.PaymntDate2.Width = 0.9450001F;
			// 
			// PaymntDate1
			// 
			this.PaymntDate1.DataField = "PAYMNT_DATE1";
			this.PaymntDate1.Height = 0.15F;
			this.PaymntDate1.Left = 2.395F;
			this.PaymntDate1.Name = "PaymntDate1";
			this.PaymntDate1.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; ddo-char-set: 128";
			this.PaymntDate1.Text = "9999/99/99";
			this.PaymntDate1.Top = 1.121F;
			this.PaymntDate1.Width = 0.9450001F;
			// 
			// Line208
			// 
			this.Line208.Height = 0F;
			this.Line208.Left = 0.1875F;
			this.Line208.LineWeight = 1F;
			this.Line208.Name = "Line208";
			this.Line208.Top = 1.26F;
			this.Line208.Width = 10F;
			this.Line208.X1 = 0.1875F;
			this.Line208.X2 = 10.1875F;
			this.Line208.Y1 = 1.26F;
			this.Line208.Y2 = 1.26F;
			// 
			// Label8
			// 
			this.Label8.Height = 0.1875F;
			this.Label8.HyperLink = null;
			this.Label8.Left = 0.25F;
			this.Label8.Name = "Label8";
			this.Label8.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label8.Text = "所属";
			this.Label8.Top = 0.25F;
			this.Label8.Width = 2.125F;
			// 
			// Label47
			// 
			this.Label47.Height = 0.15F;
			this.Label47.HyperLink = null;
			this.Label47.Left = 0.25F;
			this.Label47.Name = "Label47";
			this.Label47.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label47.Text = "社員番号";
			this.Label47.Top = 0.52F;
			this.Label47.Width = 2.125F;
			// 
			// Label48
			// 
			this.Label48.Height = 0.15F;
			this.Label48.HyperLink = null;
			this.Label48.Left = 0.25F;
			this.Label48.Name = "Label48";
			this.Label48.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label48.Text = "氏名";
			this.Label48.Top = 0.6666666F;
			this.Label48.Width = 2.125F;
			// 
			// Label44
			// 
			this.Label44.Height = 0.15F;
			this.Label44.HyperLink = null;
			this.Label44.Left = 0.25F;
			this.Label44.Name = "Label44";
			this.Label44.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label44.Text = "税表区分";
			this.Label44.Top = 0.8133333F;
			this.Label44.Width = 2.125F;
			// 
			// Label49
			// 
			this.Label49.Height = 0.15F;
			this.Label49.HyperLink = null;
			this.Label49.Left = 0.25F;
			this.Label49.Name = "Label49";
			this.Label49.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label49.Text = "扶養親族等の数";
			this.Label49.Top = 0.96F;
			this.Label49.Width = 2.125F;
			// 
			// PageCount
			// 
			this.PageCount.DataField = "PAGE_NO";
			this.PageCount.Height = 0.18F;
			this.PageCount.Left = 0.1875F;
			this.PageCount.Name = "PageCount";
			this.PageCount.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 128";
			this.PageCount.Text = null;
			this.PageCount.Top = 0.1875F;
			this.PageCount.Visible = false;
			this.PageCount.Width = 0.25F;
			// 
			// Line95
			// 
			this.Line95.Height = 0.0004999936F;
			this.Line95.Left = 0.185F;
			this.Line95.LineWeight = 1F;
			this.Line95.Name = "Line95";
			this.Line95.Top = 0.1875F;
			this.Line95.Width = 10.0025F;
			this.Line95.X1 = 0.185F;
			this.Line95.X2 = 10.1875F;
			this.Line95.Y1 = 0.188F;
			this.Line95.Y2 = 0.1875F;
			// 
			// TotalCnt8
			// 
			this.TotalCnt8.DataField = "TOTAL_CNT8";
			this.TotalCnt8.Height = 0.15F;
			this.TotalCnt8.Left = 9.2175F;
			this.TotalCnt8.Name = "TotalCnt8";
			this.TotalCnt8.OutputFormat = "#,##0";
			this.TotalCnt8.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt8.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt8.Top = 0.36F;
			this.TotalCnt8.Visible = false;
			this.TotalCnt8.Width = 0.95F;
			// 
			// TotalCnt7
			// 
			this.TotalCnt7.DataField = "TOTAL_CNT7";
			this.TotalCnt7.Height = 0.15F;
			this.TotalCnt7.Left = 8.25F;
			this.TotalCnt7.Name = "TotalCnt7";
			this.TotalCnt7.OutputFormat = "#,##0";
			this.TotalCnt7.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt7.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt7.Top = 0.36F;
			this.TotalCnt7.Visible = false;
			this.TotalCnt7.Width = 0.95F;
			// 
			// TotalCnt6
			// 
			this.TotalCnt6.DataField = "TOTAL_CNT6";
			this.TotalCnt6.Height = 0.15F;
			this.TotalCnt6.Left = 7.26393F;
			this.TotalCnt6.Name = "TotalCnt6";
			this.TotalCnt6.OutputFormat = "#,##0";
			this.TotalCnt6.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt6.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt6.Top = 0.36F;
			this.TotalCnt6.Visible = false;
			this.TotalCnt6.Width = 0.95F;
			// 
			// TotalCnt5
			// 
			this.TotalCnt5.DataField = "TOTAL_CNT5";
			this.TotalCnt5.Height = 0.15F;
			this.TotalCnt5.Left = 6.287143F;
			this.TotalCnt5.Name = "TotalCnt5";
			this.TotalCnt5.OutputFormat = "#,##0";
			this.TotalCnt5.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt5.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt5.Top = 0.36F;
			this.TotalCnt5.Visible = false;
			this.TotalCnt5.Width = 0.95F;
			// 
			// TotalCnt4
			// 
			this.TotalCnt4.DataField = "TOTAL_CNT4";
			this.TotalCnt4.Height = 0.15F;
			this.TotalCnt4.Left = 5.310357F;
			this.TotalCnt4.Name = "TotalCnt4";
			this.TotalCnt4.OutputFormat = "#,##0";
			this.TotalCnt4.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt4.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt4.Top = 0.36F;
			this.TotalCnt4.Visible = false;
			this.TotalCnt4.Width = 0.95F;
			// 
			// TotalCnt3
			// 
			this.TotalCnt3.DataField = "TOTAL_CNT3";
			this.TotalCnt3.Height = 0.15F;
			this.TotalCnt3.Left = 4.338572F;
			this.TotalCnt3.Name = "TotalCnt3";
			this.TotalCnt3.OutputFormat = "#,##0";
			this.TotalCnt3.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt3.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt3.Top = 0.36F;
			this.TotalCnt3.Visible = false;
			this.TotalCnt3.Width = 0.95F;
			// 
			// TotalCnt2
			// 
			this.TotalCnt2.DataField = "TOTAL_CNT2";
			this.TotalCnt2.Height = 0.15F;
			this.TotalCnt2.Left = 3.366785F;
			this.TotalCnt2.Name = "TotalCnt2";
			this.TotalCnt2.OutputFormat = "#,##0";
			this.TotalCnt2.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt2.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt2.Top = 0.36F;
			this.TotalCnt2.Visible = false;
			this.TotalCnt2.Width = 0.95F;
			// 
			// Line246
			// 
			this.Line246.Height = 0F;
			this.Line246.Left = 0.185F;
			this.Line246.LineWeight = 1F;
			this.Line246.Name = "Line246";
			this.Line246.Top = 0.8083333F;
			this.Line246.Width = 10F;
			this.Line246.X1 = 0.185F;
			this.Line246.X2 = 10.185F;
			this.Line246.Y1 = 0.8083333F;
			this.Line246.Y2 = 0.8083333F;
			// 
			// Line259
			// 
			this.Line259.Height = 1.08F;
			this.Line259.Left = 10.185F;
			this.Line259.LineWeight = 1F;
			this.Line259.Name = "Line259";
			this.Line259.Top = 0.186F;
			this.Line259.Width = 0F;
			this.Line259.X1 = 10.185F;
			this.Line259.X2 = 10.185F;
			this.Line259.Y1 = 0.186F;
			this.Line259.Y2 = 1.266F;
			// 
			// Line258
			// 
			this.Line258.Height = 1.08F;
			this.Line258.Left = 9.207999F;
			this.Line258.LineWeight = 1F;
			this.Line258.Name = "Line258";
			this.Line258.Top = 0.186F;
			this.Line258.Width = 0.0004386902F;
			this.Line258.X1 = 9.208438F;
			this.Line258.X2 = 9.207999F;
			this.Line258.Y1 = 0.186F;
			this.Line258.Y2 = 1.266F;
			// 
			// Line257
			// 
			this.Line257.Height = 1.08F;
			this.Line257.Left = 8.231875F;
			this.Line257.LineWeight = 1F;
			this.Line257.Name = "Line257";
			this.Line257.Top = 0.186F;
			this.Line257.Width = 0.0001249313F;
			this.Line257.X1 = 8.231875F;
			this.Line257.X2 = 8.232F;
			this.Line257.Y1 = 0.186F;
			this.Line257.Y2 = 1.266F;
			// 
			// Line256
			// 
			this.Line256.Height = 1.08F;
			this.Line256.Left = 7.255F;
			this.Line256.LineWeight = 1F;
			this.Line256.Name = "Line256";
			this.Line256.Top = 0.186F;
			this.Line256.Width = 0.0003128052F;
			this.Line256.X1 = 7.255313F;
			this.Line256.X2 = 7.255F;
			this.Line256.Y1 = 0.186F;
			this.Line256.Y2 = 1.266F;
			// 
			// Line255
			// 
			this.Line255.Height = 1.08F;
			this.Line255.Left = 6.27875F;
			this.Line255.LineWeight = 1F;
			this.Line255.Name = "Line255";
			this.Line255.Top = 0.186F;
			this.Line255.Width = 0.0002498627F;
			this.Line255.X1 = 6.27875F;
			this.Line255.X2 = 6.279F;
			this.Line255.Y1 = 0.186F;
			this.Line255.Y2 = 1.266F;
			// 
			// Line254
			// 
			this.Line254.Height = 1.08F;
			this.Line254.Left = 5.302F;
			this.Line254.LineWeight = 1F;
			this.Line254.Name = "Line254";
			this.Line254.Top = 0.186F;
			this.Line254.Width = 0.0001869202F;
			this.Line254.X1 = 5.302187F;
			this.Line254.X2 = 5.302F;
			this.Line254.Y1 = 0.186F;
			this.Line254.Y2 = 1.266F;
			// 
			// Line253
			// 
			this.Line253.Height = 1.08F;
			this.Line253.Left = 4.325625F;
			this.Line253.LineWeight = 1F;
			this.Line253.Name = "Line253";
			this.Line253.Top = 0.186F;
			this.Line253.Width = 0.0003738403F;
			this.Line253.X1 = 4.325625F;
			this.Line253.X2 = 4.325999F;
			this.Line253.Y1 = 0.186F;
			this.Line253.Y2 = 1.266F;
			// 
			// Line252
			// 
			this.Line252.Height = 1.08F;
			this.Line252.Left = 3.349F;
			this.Line252.LineWeight = 1F;
			this.Line252.Name = "Line252";
			this.Line252.Top = 0.186F;
			this.Line252.Width = 6.198883E-05F;
			this.Line252.X1 = 3.349062F;
			this.Line252.X2 = 3.349F;
			this.Line252.Y1 = 0.186F;
			this.Line252.Y2 = 1.266F;
			// 
			// Line251
			// 
			this.Line251.Height = 1.08F;
			this.Line251.Left = 2.375F;
			this.Line251.LineWeight = 1F;
			this.Line251.Name = "Line251";
			this.Line251.Top = 0.186F;
			this.Line251.Width = 0F;
			this.Line251.X1 = 2.375F;
			this.Line251.X2 = 2.375F;
			this.Line251.Y1 = 0.186F;
			this.Line251.Y2 = 1.266F;
			// 
			// Line248
			// 
			this.Line248.Height = 0F;
			this.Line248.Left = 0.185F;
			this.Line248.LineWeight = 1F;
			this.Line248.Name = "Line248";
			this.Line248.Top = 1.11F;
			this.Line248.Width = 10F;
			this.Line248.X1 = 0.185F;
			this.Line248.X2 = 10.185F;
			this.Line248.Y1 = 1.11F;
			this.Line248.Y2 = 1.11F;
			// 
			// Line247
			// 
			this.Line247.Height = 0F;
			this.Line247.Left = 0.185F;
			this.Line247.LineWeight = 1F;
			this.Line247.Name = "Line247";
			this.Line247.Top = 0.9625F;
			this.Line247.Width = 10F;
			this.Line247.X1 = 0.185F;
			this.Line247.X2 = 10.185F;
			this.Line247.Y1 = 0.9625F;
			this.Line247.Y2 = 0.9625F;
			// 
			// Line96
			// 
			this.Line96.Height = 0F;
			this.Line96.Left = 0.185F;
			this.Line96.LineWeight = 1F;
			this.Line96.Name = "Line96";
			this.Line96.Top = 0.5F;
			this.Line96.Width = 10F;
			this.Line96.X1 = 0.185F;
			this.Line96.X2 = 10.185F;
			this.Line96.Y1 = 0.5F;
			this.Line96.Y2 = 0.5F;
			// 
			// Dpnd_Total_Num3
			// 
			this.Dpnd_Total_Num3.DataField = "DPND_TOTAL_NUM3";
			this.Dpnd_Total_Num3.Height = 0.15F;
			this.Dpnd_Total_Num3.Left = 4.338572F;
			this.Dpnd_Total_Num3.Name = "Dpnd_Total_Num3";
			this.Dpnd_Total_Num3.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num3.Text = "ZZ";
			this.Dpnd_Total_Num3.Top = 0.96F;
			this.Dpnd_Total_Num3.Width = 0.9450001F;
			// 
			// Dpnd_Total_Num7
			// 
			this.Dpnd_Total_Num7.DataField = "DPND_TOTAL_NUM7";
			this.Dpnd_Total_Num7.Height = 0.15F;
			this.Dpnd_Total_Num7.Left = 8.240715F;
			this.Dpnd_Total_Num7.Name = "Dpnd_Total_Num7";
			this.Dpnd_Total_Num7.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num7.Text = "ZZ";
			this.Dpnd_Total_Num7.Top = 0.96F;
			this.Dpnd_Total_Num7.Width = 0.95F;
			// 
			// Dpnd_Total_Num5
			// 
			this.Dpnd_Total_Num5.DataField = "DPND_TOTAL_NUM5";
			this.Dpnd_Total_Num5.Height = 0.15F;
			this.Dpnd_Total_Num5.Left = 6.287143F;
			this.Dpnd_Total_Num5.Name = "Dpnd_Total_Num5";
			this.Dpnd_Total_Num5.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num5.Text = "ZZ";
			this.Dpnd_Total_Num5.Top = 0.96F;
			this.Dpnd_Total_Num5.Width = 0.95F;
			// 
			// Dpnd_Total_Num4
			// 
			this.Dpnd_Total_Num4.DataField = "DPND_TOTAL_NUM4";
			this.Dpnd_Total_Num4.Height = 0.15F;
			this.Dpnd_Total_Num4.Left = 5.310357F;
			this.Dpnd_Total_Num4.Name = "Dpnd_Total_Num4";
			this.Dpnd_Total_Num4.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num4.Text = "ZZ";
			this.Dpnd_Total_Num4.Top = 0.96F;
			this.Dpnd_Total_Num4.Width = 0.95F;
			// 
			// Dpnd_Total_Num1
			// 
			this.Dpnd_Total_Num1.DataField = "DPND_TOTAL_NUM1";
			this.Dpnd_Total_Num1.Height = 0.15F;
			this.Dpnd_Total_Num1.Left = 2.395F;
			this.Dpnd_Total_Num1.Name = "Dpnd_Total_Num1";
			this.Dpnd_Total_Num1.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num1.Text = "ZZ";
			this.Dpnd_Total_Num1.Top = 0.96F;
			this.Dpnd_Total_Num1.Width = 0.9450001F;
			// 
			// Dpnd_Total_Num8
			// 
			this.Dpnd_Total_Num8.DataField = "DPND_TOTAL_NUM8";
			this.Dpnd_Total_Num8.Height = 0.15F;
			this.Dpnd_Total_Num8.Left = 9.2175F;
			this.Dpnd_Total_Num8.Name = "Dpnd_Total_Num8";
			this.Dpnd_Total_Num8.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num8.Text = "ZZ";
			this.Dpnd_Total_Num8.Top = 0.96F;
			this.Dpnd_Total_Num8.Width = 0.95F;
			// 
			// TaxType3
			// 
			this.TaxType3.DataField = "TAX_TYPE3";
			this.TaxType3.Height = 0.15F;
			this.TaxType3.Left = 4.338572F;
			this.TaxType3.Name = "TaxType3";
			this.TaxType3.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType3.Text = "あいうえおかきく";
			this.TaxType3.Top = 0.8125F;
			this.TaxType3.Width = 0.9450001F;
			// 
			// TaxType7
			// 
			this.TaxType7.DataField = "TAX_TYPE7";
			this.TaxType7.Height = 0.15F;
			this.TaxType7.Left = 8.240715F;
			this.TaxType7.Name = "TaxType7";
			this.TaxType7.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType7.Text = "あいうえおかきく";
			this.TaxType7.Top = 0.8125F;
			this.TaxType7.Width = 0.95F;
			// 
			// TaxType5
			// 
			this.TaxType5.DataField = "TAX_TYPE5";
			this.TaxType5.Height = 0.15F;
			this.TaxType5.Left = 6.287143F;
			this.TaxType5.Name = "TaxType5";
			this.TaxType5.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType5.Text = "あいうえおかきく";
			this.TaxType5.Top = 0.8125F;
			this.TaxType5.Width = 0.95F;
			// 
			// TaxType4
			// 
			this.TaxType4.DataField = "TAX_TYPE4";
			this.TaxType4.Height = 0.15F;
			this.TaxType4.Left = 5.310357F;
			this.TaxType4.Name = "TaxType4";
			this.TaxType4.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType4.Text = "あいうえおかきく";
			this.TaxType4.Top = 0.8125F;
			this.TaxType4.Width = 0.95F;
			// 
			// TaxType1
			// 
			this.TaxType1.DataField = "TAX_TYPE1";
			this.TaxType1.Height = 0.15F;
			this.TaxType1.Left = 2.395F;
			this.TaxType1.Name = "TaxType1";
			this.TaxType1.Style = "font-size: 8.25pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.TaxType1.Text = "あいうえおかきく";
			this.TaxType1.Top = 0.8125F;
			this.TaxType1.Width = 0.9450001F;
			// 
			// TaxType8
			// 
			this.TaxType8.DataField = "TAX_TYPE8";
			this.TaxType8.Height = 0.15F;
			this.TaxType8.Left = 9.2175F;
			this.TaxType8.Name = "TaxType8";
			this.TaxType8.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType8.Text = "あいうえおかきく";
			this.TaxType8.Top = 0.8125F;
			this.TaxType8.Width = 0.95F;
			// 
			// EmpName3
			// 
			this.EmpName3.DataField = "EMP_NAME3";
			this.EmpName3.Height = 0.15F;
			this.EmpName3.Left = 4.338572F;
			this.EmpName3.Name = "EmpName3";
			this.EmpName3.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName3.Text = "あいうえおかきく";
			this.EmpName3.Top = 0.67F;
			this.EmpName3.Width = 0.9450001F;
			// 
			// EmpCode3
			// 
			this.EmpCode3.DataField = "EMP_CODE3";
			this.EmpCode3.Height = 0.15F;
			this.EmpCode3.Left = 4.338572F;
			this.EmpCode3.Name = "EmpCode3";
			this.EmpCode3.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode3.Text = "MMMMMMMMMM";
			this.EmpCode3.Top = 0.52F;
			this.EmpCode3.Width = 0.9450001F;
			// 
			// AtacName3
			// 
			this.AtacName3.DataField = "ATAC_NAME3";
			this.AtacName3.Height = 0.25F;
			this.AtacName3.Left = 4.338572F;
			this.AtacName3.Name = "AtacName3";
			this.AtacName3.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName3.Text = "あいうえおかきくけこさしすせ";
			this.AtacName3.Top = 0.23F;
			this.AtacName3.Width = 0.9450001F;
			// 
			// AtacName7
			// 
			this.AtacName7.DataField = "ATAC_NAME7";
			this.AtacName7.Height = 0.25F;
			this.AtacName7.Left = 8.25F;
			this.AtacName7.Name = "AtacName7";
			this.AtacName7.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName7.Text = "あいうえおかきくけこさしすせ";
			this.AtacName7.Top = 0.23F;
			this.AtacName7.Width = 0.95F;
			// 
			// EmpName7
			// 
			this.EmpName7.DataField = "EMP_NAME7";
			this.EmpName7.Height = 0.15F;
			this.EmpName7.Left = 8.240715F;
			this.EmpName7.Name = "EmpName7";
			this.EmpName7.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName7.Text = "あいうえおかきく";
			this.EmpName7.Top = 0.67F;
			this.EmpName7.Width = 0.95F;
			// 
			// EmpCode7
			// 
			this.EmpCode7.DataField = "EMP_CODE7";
			this.EmpCode7.Height = 0.15F;
			this.EmpCode7.Left = 8.240715F;
			this.EmpCode7.Name = "EmpCode7";
			this.EmpCode7.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode7.Text = "MMMMMMMMMM";
			this.EmpCode7.Top = 0.52F;
			this.EmpCode7.Width = 0.95F;
			// 
			// AtacName5
			// 
			this.AtacName5.DataField = "ATAC_NAME5";
			this.AtacName5.Height = 0.25F;
			this.AtacName5.Left = 6.287143F;
			this.AtacName5.Name = "AtacName5";
			this.AtacName5.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName5.Text = "あいうえおかきくけこさしすせ";
			this.AtacName5.Top = 0.23F;
			this.AtacName5.Width = 0.95F;
			// 
			// EmpName5
			// 
			this.EmpName5.DataField = "EMP_NAME5";
			this.EmpName5.Height = 0.15F;
			this.EmpName5.Left = 6.287143F;
			this.EmpName5.Name = "EmpName5";
			this.EmpName5.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName5.Text = "あいうえおかきく";
			this.EmpName5.Top = 0.67F;
			this.EmpName5.Width = 0.95F;
			// 
			// EmpCode5
			// 
			this.EmpCode5.DataField = "EMP_CODE5";
			this.EmpCode5.Height = 0.15F;
			this.EmpCode5.Left = 6.287143F;
			this.EmpCode5.Name = "EmpCode5";
			this.EmpCode5.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode5.Text = "MMMMMMMMMM";
			this.EmpCode5.Top = 0.52F;
			this.EmpCode5.Width = 0.95F;
			// 
			// AtacName4
			// 
			this.AtacName4.DataField = "ATAC_NAME4";
			this.AtacName4.Height = 0.25F;
			this.AtacName4.Left = 5.310357F;
			this.AtacName4.Name = "AtacName4";
			this.AtacName4.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName4.Text = "あいうえおかきくけこさしすせ";
			this.AtacName4.Top = 0.23F;
			this.AtacName4.Width = 0.95F;
			// 
			// EmpName4
			// 
			this.EmpName4.DataField = "EMP_NAME4";
			this.EmpName4.Height = 0.15F;
			this.EmpName4.Left = 5.310357F;
			this.EmpName4.Name = "EmpName4";
			this.EmpName4.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName4.Text = "あいうえおかきく";
			this.EmpName4.Top = 0.67F;
			this.EmpName4.Width = 0.95F;
			// 
			// EmpCode4
			// 
			this.EmpCode4.DataField = "EMP_CODE4";
			this.EmpCode4.Height = 0.15F;
			this.EmpCode4.Left = 5.310357F;
			this.EmpCode4.Name = "EmpCode4";
			this.EmpCode4.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode4.Text = "MMMMMMMMMM";
			this.EmpCode4.Top = 0.52F;
			this.EmpCode4.Width = 0.95F;
			// 
			// EmpName1
			// 
			this.EmpName1.DataField = "EMP_NAME1";
			this.EmpName1.Height = 0.15F;
			this.EmpName1.Left = 2.395F;
			this.EmpName1.Name = "EmpName1";
			this.EmpName1.Style = "font-size: 8.25pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.EmpName1.Text = "あいうえおかきく";
			this.EmpName1.Top = 0.67F;
			this.EmpName1.Width = 0.9450001F;
			// 
			// EmpCode1
			// 
			this.EmpCode1.DataField = "EMP_CODE1";
			this.EmpCode1.Height = 0.15F;
			this.EmpCode1.Left = 2.395F;
			this.EmpCode1.Name = "EmpCode1";
			this.EmpCode1.Style = "font-size: 8.25pt; text-align: left; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode1.Text = "MMMMMMMMMM";
			this.EmpCode1.Top = 0.52F;
			this.EmpCode1.Width = 0.9450001F;
			// 
			// AtacName8
			// 
			this.AtacName8.DataField = "ATAC_NAME8";
			this.AtacName8.Height = 0.25F;
			this.AtacName8.Left = 9.2175F;
			this.AtacName8.Name = "AtacName8";
			this.AtacName8.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName8.Text = "あいうえおかきくけこさしすせ";
			this.AtacName8.Top = 0.23F;
			this.AtacName8.Width = 0.95F;
			// 
			// EmpCode8
			// 
			this.EmpCode8.DataField = "EMP_CODE8";
			this.EmpCode8.Height = 0.15F;
			this.EmpCode8.Left = 9.2175F;
			this.EmpCode8.Name = "EmpCode8";
			this.EmpCode8.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode8.Text = "MMMMMMMMMM";
			this.EmpCode8.Top = 0.52F;
			this.EmpCode8.Width = 0.95F;
			// 
			// EmpName8
			// 
			this.EmpName8.DataField = "EMP_NAME8";
			this.EmpName8.Height = 0.15F;
			this.EmpName8.Left = 9.2175F;
			this.EmpName8.Name = "EmpName8";
			this.EmpName8.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName8.Text = "あいうえおかきく";
			this.EmpName8.Top = 0.67F;
			this.EmpName8.Width = 0.95F;
			// 
			// Line110
			// 
			this.Line110.Height = 1.08F;
			this.Line110.Left = 0.1875F;
			this.Line110.LineWeight = 1F;
			this.Line110.Name = "Line110";
			this.Line110.Top = 0.186F;
			this.Line110.Width = 0.0004999936F;
			this.Line110.X1 = 0.188F;
			this.Line110.X2 = 0.1875F;
			this.Line110.Y1 = 0.186F;
			this.Line110.Y2 = 1.266F;
			// 
			// EmpCode2
			// 
			this.EmpCode2.DataField = "EMP_CODE2";
			this.EmpCode2.Height = 0.15F;
			this.EmpCode2.Left = 3.366785F;
			this.EmpCode2.Name = "EmpCode2";
			this.EmpCode2.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode2.Text = "MMMMMMMMMM";
			this.EmpCode2.Top = 0.52F;
			this.EmpCode2.Width = 0.9450001F;
			// 
			// EmpName2
			// 
			this.EmpName2.DataField = "EMP_NAME2";
			this.EmpName2.Height = 0.15F;
			this.EmpName2.Left = 3.366785F;
			this.EmpName2.Name = "EmpName2";
			this.EmpName2.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName2.Text = "あいうえおかきく";
			this.EmpName2.Top = 0.67F;
			this.EmpName2.Width = 0.9450001F;
			// 
			// TaxType2
			// 
			this.TaxType2.DataField = "TAX_TYPE2";
			this.TaxType2.Height = 0.15F;
			this.TaxType2.Left = 3.366785F;
			this.TaxType2.Name = "TaxType2";
			this.TaxType2.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType2.Text = "あいうえおかきく";
			this.TaxType2.Top = 0.8125F;
			this.TaxType2.Width = 0.9450001F;
			// 
			// Dpnd_Total_Num2
			// 
			this.Dpnd_Total_Num2.DataField = "DPND_TOTAL_NUM2";
			this.Dpnd_Total_Num2.Height = 0.15F;
			this.Dpnd_Total_Num2.Left = 3.366785F;
			this.Dpnd_Total_Num2.Name = "Dpnd_Total_Num2";
			this.Dpnd_Total_Num2.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num2.Text = "ZZ";
			this.Dpnd_Total_Num2.Top = 0.96F;
			this.Dpnd_Total_Num2.Width = 0.9450001F;
			// 
			// AtacName2
			// 
			this.AtacName2.DataField = "ATAC_NAME2";
			this.AtacName2.Height = 0.25F;
			this.AtacName2.Left = 3.366785F;
			this.AtacName2.Name = "AtacName2";
			this.AtacName2.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName2.Text = "あいうえおかきくけこさしすせ";
			this.AtacName2.Top = 0.23F;
			this.AtacName2.Width = 0.9450001F;
			// 
			// Dpnd_Total_Num6
			// 
			this.Dpnd_Total_Num6.DataField = "DPND_TOTAL_NUM6";
			this.Dpnd_Total_Num6.Height = 0.15F;
			this.Dpnd_Total_Num6.Left = 7.26393F;
			this.Dpnd_Total_Num6.Name = "Dpnd_Total_Num6";
			this.Dpnd_Total_Num6.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.Dpnd_Total_Num6.Text = "ZZ";
			this.Dpnd_Total_Num6.Top = 0.96F;
			this.Dpnd_Total_Num6.Width = 0.95F;
			// 
			// TaxType6
			// 
			this.TaxType6.DataField = "TAX_TYPE6";
			this.TaxType6.Height = 0.15F;
			this.TaxType6.Left = 7.26393F;
			this.TaxType6.Name = "TaxType6";
			this.TaxType6.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.TaxType6.Text = "あいうえおかきく";
			this.TaxType6.Top = 0.8125F;
			this.TaxType6.Width = 0.95F;
			// 
			// EmpName6
			// 
			this.EmpName6.DataField = "EMP_NAME6";
			this.EmpName6.Height = 0.15F;
			this.EmpName6.Left = 7.26393F;
			this.EmpName6.Name = "EmpName6";
			this.EmpName6.Style = "font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 128" +
    "";
			this.EmpName6.Text = "あいうえおかきく";
			this.EmpName6.Top = 0.67F;
			this.EmpName6.Width = 0.95F;
			// 
			// EmpCode6
			// 
			this.EmpCode6.DataField = "EMP_CODE6";
			this.EmpCode6.Height = 0.15F;
			this.EmpCode6.Left = 7.26393F;
			this.EmpCode6.Name = "EmpCode6";
			this.EmpCode6.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
			this.EmpCode6.Text = "MMMMMMMMMM";
			this.EmpCode6.Top = 0.52F;
			this.EmpCode6.Width = 0.95F;
			// 
			// AtacName6
			// 
			this.AtacName6.DataField = "ATAC_NAME6";
			this.AtacName6.Height = 0.25F;
			this.AtacName6.Left = 7.26393F;
			this.AtacName6.Name = "AtacName6";
			this.AtacName6.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit; ddo-char-set: 128";
			this.AtacName6.Text = "あいうえおかきくけこさしすせ";
			this.AtacName6.Top = 0.23F;
			this.AtacName6.Width = 0.95F;
			// 
			// TotalCnt1
			// 
			this.TotalCnt1.DataField = "TOTAL_CNT1";
			this.TotalCnt1.Height = 0.15F;
			this.TotalCnt1.Left = 2.395F;
			this.TotalCnt1.Name = "TotalCnt1";
			this.TotalCnt1.OutputFormat = "#,##0";
			this.TotalCnt1.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom; white-space: nowra" +
    "p; ddo-char-set: 128";
			this.TotalCnt1.Text = "ZZ,ZZZ,ZZZ名";
			this.TotalCnt1.Top = 0.36F;
			this.TotalCnt1.Visible = false;
			this.TotalCnt1.Width = 0.95F;
			// 
			// ActCaption
			// 
			this.ActCaption.Height = 0.18F;
			this.ActCaption.HyperLink = null;
			this.ActCaption.Left = 0.1875F;
			this.ActCaption.Name = "ActCaption";
			this.ActCaption.Style = "font-size: 9pt; vertical-align: middle";
			this.ActCaption.Text = "所属名";
			this.ActCaption.Top = 0F;
			this.ActCaption.Width = 0.5F;
			// 
			// BrkAtacName
			// 
			this.BrkAtacName.DataField = "BRK_ATAC_NAME";
			this.BrkAtacName.Height = 0.18F;
			this.BrkAtacName.Left = 0.6875F;
			this.BrkAtacName.Name = "BrkAtacName";
			this.BrkAtacName.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 128";
			this.BrkAtacName.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.BrkAtacName.Top = 0F;
			this.BrkAtacName.Width = 8.8125F;
			// 
			// GroupFooter2
			// 
			this.GroupFooter2.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Line261});
			this.GroupFooter2.Height = 0F;
			this.GroupFooter2.Name = "GroupFooter2";
			this.GroupFooter2.Format += new System.EventHandler(this.GroupFooter2_Format);
			// 
			// Line261
			// 
			this.Line261.Height = 0F;
			this.Line261.Left = 0.185F;
			this.Line261.LineWeight = 1F;
			this.Line261.Name = "Line261";
			this.Line261.Top = 0F;
			this.Line261.Width = 10F;
			this.Line261.X1 = 0.185F;
			this.Line261.X2 = 10.185F;
			this.Line261.Y1 = 0F;
			this.Line261.Y2 = 0F;
			// 
			// GroupHeader3
			// 
			this.GroupHeader3.CanGrow = false;
			this.GroupHeader3.CanShrink = true;
			this.GroupHeader3.DataField = "LINE_NO";
			this.GroupHeader3.Height = 0F;
			this.GroupHeader3.Name = "GroupHeader3";
			this.GroupHeader3.Format += new System.EventHandler(this.GroupHeader3_Format);
			this.GroupHeader3.AfterPrint += new System.EventHandler(this.GroupHeader3_AfterPrint);
			// 
			// GroupFooter3
			// 
			this.GroupFooter3.Height = 0F;
			this.GroupFooter3.Name = "GroupFooter3";
			// 
			// HR_PY_03_R59
			// 
			this.MasterReport = false;
			this.PageSettings.Margins.Bottom = 0.5F;
			this.PageSettings.Margins.Left = 0.5F;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.PaperHeight = 11.69F;
			this.PageSettings.PaperWidth = 8.27F;
			this.PrintWidth = 10.27083F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.GroupHeader2);
			this.Sections.Add(this.GroupHeader3);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter3);
			this.Sections.Add(this.GroupFooter2);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R59_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PyItemName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LineNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Item_Code)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Amt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Format)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PrintName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MonthCaption)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PageCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dpnd_Total_Num6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCnt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActCaption)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BrkAtacName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
