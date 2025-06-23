// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R61.cs
// 機能名      : HR_PY_03_R61 給与支給明細書（A4）
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K15504 2007/02/09 支給体系毎の明細対応
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
	public class HR_PY_03_R61 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R61()
		{
			InitializeComponent();
		}
		#region Protected Fields
		protected string reportID;
		protected string companyName;
		protected string title;
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

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		public CommonData commonData
		{
			get { return cd; }
			set { cd = value; }
		}
		#endregion

		private void HR_PY_03_R61_ReportStart(object sender, System.EventArgs eArgs)
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


			TitleLabel.Text = title + "支給明細書";
			Title2Label.Text = title + "支給明細書";

			//年末調整のときは月度を表示しない
			if (title == "年末調整")
			{
				SlryPaymntMonth.Visible = false;
				SlryPaymntMonth2.Visible = false;
			}

			//振込銀行名がNULLの時は、振込額を表示しない。
			if ((RemitBankName1.Text == null) || (RemitBankName1.Text.Length == 0))
			{
				Remit1RemitAmt.Visible = false;
			}
			else
			{
				Remit1RemitAmt.Visible = true;
			}
			if ((RemitBankName2.Text == null) || (RemitBankName2.Text.Length == 0))
			{
				Remit2RemitAmt.Visible = false;
			}
			else
			{
				Remit2RemitAmt.Visible = true;
			}
			if ((RemitBankName3.Text == null) || (RemitBankName3.Text.Length == 0))
			{
				Remit3RemitAmt.Visible = false;
			}
			else
			{
				Remit3RemitAmt.Visible = true;
			}
		}

		private void GroupHeader1_AfterPrint(object sender, System.EventArgs eArgs)
		{
			SlryItemValue1.OutputFormat = SlryItemForm1.Text;
			SlryItemValue2.OutputFormat = SlryItemForm2.Text;
			SlryItemValue3.OutputFormat = SlryItemForm3.Text;
			SlryItemValue4.OutputFormat = SlryItemForm4.Text;
			SlryItemValue5.OutputFormat = SlryItemForm5.Text;
			SlryItemValue6.OutputFormat = SlryItemForm6.Text;
			SlryItemValue7.OutputFormat = SlryItemForm7.Text;
			SlryItemValue8.OutputFormat = SlryItemForm8.Text;
			SlryItemValue9.OutputFormat = SlryItemForm9.Text;
			SlryItemValue10.OutputFormat = SlryItemForm10.Text;
			SlryItemValue11.OutputFormat = SlryItemForm11.Text;
			SlryItemValue12.OutputFormat = SlryItemForm12.Text;
			SlryItemValue13.OutputFormat = SlryItemForm13.Text;
			SlryItemValue14.OutputFormat = SlryItemForm14.Text;
			SlryItemValue15.OutputFormat = SlryItemForm15.Text;
			SlryItemValue16.OutputFormat = SlryItemForm16.Text;
			SlryItemValue17.OutputFormat = SlryItemForm17.Text;
			SlryItemValue18.OutputFormat = SlryItemForm18.Text;
			SlryItemValue19.OutputFormat = SlryItemForm19.Text;
			SlryItemValue20.OutputFormat = SlryItemForm20.Text;
			SlryItemValue21.OutputFormat = SlryItemForm21.Text;
			SlryItemValue22.OutputFormat = SlryItemForm22.Text;
			SlryItemValue23.OutputFormat = SlryItemForm23.Text;
			SlryItemValue24.OutputFormat = SlryItemForm24.Text;
			SlryItemValue25.OutputFormat = SlryItemForm25.Text;
			SlryItemValue26.OutputFormat = SlryItemForm26.Text;
			SlryItemValue27.OutputFormat = SlryItemForm27.Text;
			SlryItemValue28.OutputFormat = SlryItemForm28.Text;
			SlryItemValue29.OutputFormat = SlryItemForm29.Text;
			SlryItemValue30.OutputFormat = SlryItemForm30.Text;
			DedItemValue1.OutputFormat = DedItemForm1.Text;
			DedItemValue2.OutputFormat = DedItemForm2.Text;
			DedItemValue3.OutputFormat = DedItemForm3.Text;
			DedItemValue4.OutputFormat = DedItemForm4.Text;
			DedItemValue5.OutputFormat = DedItemForm5.Text;
			DedItemValue6.OutputFormat = DedItemForm6.Text;
			DedItemValue7.OutputFormat = DedItemForm7.Text;
			DedItemValue8.OutputFormat = DedItemForm8.Text;
			DedItemValue9.OutputFormat = DedItemForm9.Text;
			DedItemValue10.OutputFormat = DedItemForm10.Text;
			DedItemValue11.OutputFormat = DedItemForm11.Text;
			DedItemValue12.OutputFormat = DedItemForm12.Text;
			DedItemValue13.OutputFormat = DedItemForm13.Text;
			DedItemValue14.OutputFormat = DedItemForm14.Text;
			DedItemValue15.OutputFormat = DedItemForm15.Text;
			DedItemValue16.OutputFormat = DedItemForm16.Text;
			DedItemValue17.OutputFormat = DedItemForm17.Text;
			DedItemValue18.OutputFormat = DedItemForm18.Text;
			DedItemValue19.OutputFormat = DedItemForm19.Text;
			DedItemValue20.OutputFormat = DedItemForm20.Text;
			DedItemValue21.OutputFormat = DedItemForm21.Text;
			DedItemValue22.OutputFormat = DedItemForm22.Text;
			DedItemValue23.OutputFormat = DedItemForm23.Text;
			DedItemValue24.OutputFormat = DedItemForm24.Text;
			DedItemValue25.OutputFormat = DedItemForm25.Text;
			DedItemValue26.OutputFormat = DedItemForm26.Text;
			DedItemValue27.OutputFormat = DedItemForm27.Text;
			DedItemValue28.OutputFormat = DedItemForm28.Text;
			DedItemValue29.OutputFormat = DedItemForm29.Text;
			DedItemValue30.OutputFormat = DedItemForm30.Text;
			DtyItemValue1.OutputFormat = DtyItemForm1.Text;
			DtyItemValue2.OutputFormat = DtyItemForm2.Text;
			DtyItemValue3.OutputFormat = DtyItemForm3.Text;
			DtyItemValue4.OutputFormat = DtyItemForm4.Text;
			DtyItemValue5.OutputFormat = DtyItemForm5.Text;
			DtyItemValue6.OutputFormat = DtyItemForm6.Text;
			DtyItemValue7.OutputFormat = DtyItemForm7.Text;
			DtyItemValue8.OutputFormat = DtyItemForm8.Text;
			DtyItemValue9.OutputFormat = DtyItemForm9.Text;
			DtyItemValue10.OutputFormat = DtyItemForm10.Text;
			DtyItemValue11.OutputFormat = DtyItemForm11.Text;
			DtyItemValue12.OutputFormat = DtyItemForm12.Text;
			DtyItemValue13.OutputFormat = DtyItemForm13.Text;
			DtyItemValue14.OutputFormat = DtyItemForm14.Text;
			DtyItemValue15.OutputFormat = DtyItemForm15.Text;
			DtyItemValue16.OutputFormat = DtyItemForm16.Text;
			DtyItemValue17.OutputFormat = DtyItemForm17.Text;
			DtyItemValue18.OutputFormat = DtyItemForm18.Text;
			DtyItemValue19.OutputFormat = DtyItemForm19.Text;
			DtyItemValue20.OutputFormat = DtyItemForm20.Text;
			DtyItemValue21.OutputFormat = DtyItemForm21.Text;
			DtyItemValue22.OutputFormat = DtyItemForm22.Text;
			DtyItemValue23.OutputFormat = DtyItemForm23.Text;
			DtyItemValue24.OutputFormat = DtyItemForm24.Text;
			DtyItemValue25.OutputFormat = DtyItemForm25.Text;
			DtyItemValue26.OutputFormat = DtyItemForm26.Text;
			DtyItemValue27.OutputFormat = DtyItemForm27.Text;
			DtyItemValue28.OutputFormat = DtyItemForm28.Text;
			DtyItemValue29.OutputFormat = DtyItemForm29.Text;
			DtyItemValue30.OutputFormat = DtyItemForm30.Text;
			CashPaymntAmt.OutputFormat = CashPaymntAmtForm.Text;
		}

		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{

		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntYear = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntMonth = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label TitleLabel = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox MyCompName = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label127 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line361 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntYear2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Title2Label = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemName25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemValue25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line362 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBankName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBankName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBankName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBranchName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBranchName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RemitBranchName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remit1RemitAmt = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remit2RemitAmt = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remit3RemitAmt = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label CashPaymntAmtName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CashPaymntAmt = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox MyCompName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line364 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line366 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line367 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line368 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line369 = null;
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
		private GrapeCity.ActiveReports.SectionReportModel.Line Line390 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line392 = null;
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
		private GrapeCity.ActiveReports.SectionReportModel.Line Line407 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line408 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line409 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line410 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line411 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line412 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line413 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line414 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line415 = null;
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
		private GrapeCity.ActiveReports.SectionReportModel.Line Line430 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line431 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line432 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line433 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line434 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line435 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line436 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line439 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line444 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line445 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line447 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line448 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line451 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntMonth2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line391 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line395 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line393 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line452 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line455 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line456 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line457 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaySlipComment = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line354 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line450 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line363 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line449 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line389 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line394 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line417 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line284 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line416 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line355 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemName29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemValue29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemName30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemValue30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line458 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line459 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line460 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line461 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line462 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line463 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line464 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line465 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line466 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line467 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line468 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line469 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line470 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line471 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line472 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line473 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line443 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line441 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line438 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line437 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line442 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line440 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryItemForm30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DedItemForm30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DtyItemForm30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CashPaymntAmtForm = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SlryPaymntYMD = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R61));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.DtyItemValue30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryPaymntYear = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryPaymntMonth = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TitleLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyCompName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label127 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SlryItemName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line361 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DtyItemName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryPaymntYear2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Title2Label = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DtyItemName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemName25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemValue25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line362 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DedItemName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DedItemValue1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBankName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBankName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBankName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBranchName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBranchName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RemitBranchName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remit1RemitAmt = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remit2RemitAmt = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remit3RemitAmt = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CashPaymntAmtName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.CashPaymntAmt = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyCompName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line364 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line366 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line367 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line368 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line369 = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.Line390 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line392 = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.Line407 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line408 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line409 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line410 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line411 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line412 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line413 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line414 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line415 = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.Line430 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line431 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line432 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line433 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line434 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line435 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line436 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line439 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line444 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line445 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line447 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line448 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryItemValue26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line451 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryItemName25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryPaymntMonth2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line391 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line395 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line393 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line452 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line455 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line456 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line457 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PaySlipComment = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line354 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line450 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line363 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line449 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line389 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line394 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line417 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line284 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line416 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line355 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryItemName28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemName29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemValue29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemName30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemValue30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line458 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line459 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line460 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line461 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line462 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line463 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line464 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line465 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line466 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line467 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line468 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line469 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line470 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line471 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line472 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line473 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line443 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line441 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line438 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line437 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line442 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line440 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SlryItemForm1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryItemForm30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DedItemForm30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DtyItemForm30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CashPaymntAmtForm = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryPaymntYMD = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyCompName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYear2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Title2Label)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit1RemitAmt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit2RemitAmt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit3RemitAmt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyCompName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntMonth2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaySlipComment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmtForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYMD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.DtyItemValue30,
            this.DtyItemValue29,
            this.DtyItemValue28,
            this.DtyItemValue27,
            this.DtyItemValue26,
            this.DtyItemName30,
            this.DtyItemName29,
            this.DtyItemName28,
            this.DtyItemName26,
            this.DtyItemName27,
            this.DedItemName26,
            this.DedItemValue26,
            this.DedItemName25,
            this.DedItemValue25,
            this.DedItemName24,
            this.DedItemValue24,
            this.DedItemValue23,
            this.DedItemName23,
            this.DtyItemValue21,
            this.EmpCode,
            this.SlryPaymntYear,
            this.SlryPaymntMonth,
            this.TitleLabel,
            this.EmpName,
            this.AtacName,
            this.AtacCode,
            this.MyCompName,
            this.Label127,
            this.SlryItemName1,
            this.SlryItemValue1,
            this.Line361,
            this.Label129,
            this.DtyItemName1,
            this.DtyItemName2,
            this.DtyItemName3,
            this.DtyItemName4,
            this.DtyItemName5,
            this.DtyItemValue1,
            this.DtyItemValue2,
            this.DtyItemValue3,
            this.DtyItemValue4,
            this.DtyItemValue5,
            this.SlryItemName2,
            this.SlryItemValue2,
            this.SlryItemName3,
            this.SlryItemValue3,
            this.SlryItemName4,
            this.SlryItemValue4,
            this.SlryItemName5,
            this.SlryItemValue5,
            this.SlryItemName6,
            this.SlryItemValue6,
            this.SlryItemName7,
            this.SlryItemValue7,
            this.SlryItemName8,
            this.SlryItemValue8,
            this.SlryItemName9,
            this.SlryItemValue9,
            this.SlryItemName10,
            this.SlryItemValue10,
            this.SlryItemName11,
            this.SlryItemValue11,
            this.SlryItemName12,
            this.SlryItemValue12,
            this.SlryItemName13,
            this.SlryItemValue13,
            this.SlryItemName14,
            this.SlryItemValue14,
            this.SlryItemName15,
            this.SlryItemValue15,
            this.SlryItemName16,
            this.SlryItemValue16,
            this.SlryItemName17,
            this.SlryItemValue17,
            this.SlryItemName18,
            this.SlryItemValue18,
            this.SlryItemName19,
            this.SlryItemValue19,
            this.SlryItemName20,
            this.SlryItemValue20,
            this.SlryItemName21,
            this.SlryItemValue21,
            this.SlryItemName22,
            this.SlryItemValue22,
            this.SlryItemName23,
            this.SlryItemValue23,
            this.SlryItemName24,
            this.SlryItemValue24,
            this.SlryItemValue25,
            this.SlryPaymntYear2,
            this.Label137,
            this.Title2Label,
            this.DtyItemName6,
            this.DtyItemName7,
            this.DtyItemName8,
            this.DtyItemName9,
            this.DtyItemName10,
            this.DtyItemValue6,
            this.DtyItemValue7,
            this.DtyItemValue8,
            this.DtyItemValue9,
            this.DtyItemValue10,
            this.DtyItemName11,
            this.DtyItemName12,
            this.DtyItemName13,
            this.DtyItemName14,
            this.DtyItemName15,
            this.DtyItemValue11,
            this.DtyItemValue12,
            this.DtyItemValue13,
            this.DtyItemValue14,
            this.DtyItemValue15,
            this.DtyItemName16,
            this.DtyItemName17,
            this.DtyItemName18,
            this.DtyItemName19,
            this.DtyItemName20,
            this.DtyItemValue16,
            this.DtyItemValue17,
            this.DtyItemValue18,
            this.DtyItemValue19,
            this.DtyItemValue20,
            this.DtyItemName21,
            this.DtyItemName22,
            this.DtyItemName23,
            this.DtyItemName24,
            this.DtyItemName25,
            this.DtyItemValue22,
            this.DtyItemValue23,
            this.DtyItemValue24,
            this.DtyItemValue25,
            this.Label139,
            this.Label140,
            this.Label141,
            this.Line362,
            this.DedItemName2,
            this.DedItemValue2,
            this.DedItemName3,
            this.DedItemValue3,
            this.DedItemName4,
            this.DedItemValue4,
            this.DedItemName5,
            this.DedItemValue5,
            this.DedItemName6,
            this.DedItemValue6,
            this.DedItemName7,
            this.DedItemValue7,
            this.DedItemName8,
            this.DedItemValue8,
            this.DedItemName9,
            this.DedItemValue9,
            this.DedItemName10,
            this.DedItemValue10,
            this.DedItemName11,
            this.DedItemValue11,
            this.DedItemName12,
            this.DedItemValue12,
            this.DedItemName13,
            this.DedItemValue13,
            this.DedItemName14,
            this.DedItemValue14,
            this.DedItemName15,
            this.DedItemValue15,
            this.DedItemName16,
            this.DedItemValue16,
            this.DedItemName17,
            this.DedItemValue17,
            this.DedItemName18,
            this.DedItemValue18,
            this.DedItemName19,
            this.DedItemValue19,
            this.DedItemName20,
            this.DedItemValue20,
            this.DedItemValue21,
            this.DedItemValue22,
            this.DedItemName1,
            this.Label143,
            this.DedItemValue1,
            this.DedItemName21,
            this.RemitBankName1,
            this.RemitBankName2,
            this.RemitBankName3,
            this.RemitBranchName1,
            this.RemitBranchName2,
            this.RemitBranchName3,
            this.Remit1RemitAmt,
            this.Remit2RemitAmt,
            this.Remit3RemitAmt,
            this.CashPaymntAmtName,
            this.CashPaymntAmt,
            this.MyCompName2,
            this.Line364,
            this.Line366,
            this.Line367,
            this.Line368,
            this.Line369,
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
            this.Line390,
            this.Line392,
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
            this.Line407,
            this.Line408,
            this.Line409,
            this.Line410,
            this.Line411,
            this.Line412,
            this.Line413,
            this.Line414,
            this.Line415,
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
            this.Line430,
            this.Line431,
            this.Line432,
            this.Line433,
            this.Line434,
            this.Line435,
            this.Line436,
            this.Line439,
            this.Line444,
            this.Line445,
            this.Line447,
            this.Line448,
            this.SlryItemValue26,
            this.Line451,
            this.SlryItemName25,
            this.DedItemName22,
            this.SlryPaymntMonth2,
            this.Line391,
            this.Line395,
            this.Line393,
            this.Line452,
            this.Line455,
            this.Line456,
            this.Line457,
            this.PaySlipComment,
            this.SlryItemName26,
            this.Line354,
            this.Line450,
            this.Line363,
            this.Line449,
            this.Line389,
            this.Line394,
            this.Line417,
            this.Line284,
            this.Line416,
            this.Line355,
            this.SlryItemName28,
            this.SlryItemValue28,
            this.SlryItemName27,
            this.SlryItemValue27,
            this.SlryItemName30,
            this.SlryItemValue30,
            this.SlryItemName29,
            this.SlryItemValue29,
            this.DedItemName27,
            this.DedItemValue27,
            this.DedItemName28,
            this.DedItemValue28,
            this.DedItemName29,
            this.DedItemValue29,
            this.DedItemName30,
            this.DedItemValue30,
            this.Line458,
            this.Line459,
            this.Line460,
            this.Line461,
            this.Line462,
            this.Line463,
            this.Line464,
            this.Line465,
            this.Line466,
            this.Line467,
            this.Line468,
            this.Line469,
            this.Line470,
            this.Line471,
            this.Line472,
            this.Line473,
            this.Line443,
            this.Line441,
            this.Line438,
            this.Line437,
            this.Line442,
            this.Line440,
            this.SlryItemForm1,
            this.DedItemForm1,
            this.DtyItemForm1,
            this.SlryItemForm2,
            this.SlryItemForm3,
            this.SlryItemForm4,
            this.SlryItemForm5,
            this.SlryItemForm6,
            this.SlryItemForm7,
            this.SlryItemForm8,
            this.SlryItemForm9,
            this.SlryItemForm10,
            this.SlryItemForm11,
            this.SlryItemForm12,
            this.SlryItemForm13,
            this.SlryItemForm14,
            this.SlryItemForm15,
            this.SlryItemForm16,
            this.SlryItemForm17,
            this.SlryItemForm18,
            this.SlryItemForm19,
            this.SlryItemForm20,
            this.SlryItemForm21,
            this.SlryItemForm22,
            this.SlryItemForm23,
            this.SlryItemForm24,
            this.SlryItemForm25,
            this.SlryItemForm26,
            this.SlryItemForm27,
            this.SlryItemForm28,
            this.SlryItemForm29,
            this.SlryItemForm30,
            this.DedItemForm2,
            this.DedItemForm3,
            this.DedItemForm4,
            this.DedItemForm5,
            this.DedItemForm6,
            this.DedItemForm7,
            this.DedItemForm8,
            this.DedItemForm9,
            this.DedItemForm10,
            this.DedItemForm11,
            this.DedItemForm12,
            this.DedItemForm13,
            this.DedItemForm14,
            this.DedItemForm15,
            this.DedItemForm16,
            this.DedItemForm17,
            this.DedItemForm18,
            this.DedItemForm19,
            this.DedItemForm20,
            this.DedItemForm21,
            this.DedItemForm22,
            this.DedItemForm23,
            this.DedItemForm24,
            this.DedItemForm25,
            this.DedItemForm26,
            this.DedItemForm27,
            this.DedItemForm28,
            this.DedItemForm29,
            this.DedItemForm30,
            this.DtyItemForm2,
            this.DtyItemForm3,
            this.DtyItemForm4,
            this.DtyItemForm5,
            this.DtyItemForm6,
            this.DtyItemForm7,
            this.DtyItemForm8,
            this.DtyItemForm9,
            this.DtyItemForm10,
            this.DtyItemForm11,
            this.DtyItemForm12,
            this.DtyItemForm13,
            this.DtyItemForm14,
            this.DtyItemForm15,
            this.DtyItemForm16,
            this.DtyItemForm17,
            this.DtyItemForm18,
            this.DtyItemForm19,
            this.DtyItemForm20,
            this.DtyItemForm21,
            this.DtyItemForm22,
            this.DtyItemForm23,
            this.DtyItemForm24,
            this.DtyItemForm25,
            this.DtyItemForm26,
            this.DtyItemForm27,
            this.DtyItemForm28,
            this.DtyItemForm29,
            this.DtyItemForm30,
            this.CashPaymntAmtForm,
            this.SlryPaymntYMD});
			this.Detail.Height = 8.197917F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// DtyItemValue30
			// 
			this.DtyItemValue30.CanGrow = false;
			this.DtyItemValue30.DataField = "ITEM_VALUE_90";
			this.DtyItemValue30.Height = 0.1875F;
			this.DtyItemValue30.Left = 9.9375F;
			this.DtyItemValue30.Name = "DtyItemValue30";
			this.DtyItemValue30.OutputFormat = "0.00";
			this.DtyItemValue30.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue30.Text = "ZZ9.99";
			this.DtyItemValue30.Top = 3.1875F;
			this.DtyItemValue30.Width = 0.6875F;
			// 
			// DtyItemValue29
			// 
			this.DtyItemValue29.CanGrow = false;
			this.DtyItemValue29.DataField = "ITEM_VALUE_89";
			this.DtyItemValue29.Height = 0.1875F;
			this.DtyItemValue29.Left = 9.3125F;
			this.DtyItemValue29.Name = "DtyItemValue29";
			this.DtyItemValue29.OutputFormat = "0.00";
			this.DtyItemValue29.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue29.Text = "ZZ9.99";
			this.DtyItemValue29.Top = 3.1875F;
			this.DtyItemValue29.Width = 0.625F;
			// 
			// DtyItemValue28
			// 
			this.DtyItemValue28.CanGrow = false;
			this.DtyItemValue28.DataField = "ITEM_VALUE_88";
			this.DtyItemValue28.Height = 0.1875F;
			this.DtyItemValue28.Left = 8.6875F;
			this.DtyItemValue28.Name = "DtyItemValue28";
			this.DtyItemValue28.OutputFormat = "0.00";
			this.DtyItemValue28.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue28.Text = "ZZ9.99";
			this.DtyItemValue28.Top = 3.1875F;
			this.DtyItemValue28.Width = 0.625F;
			// 
			// DtyItemValue27
			// 
			this.DtyItemValue27.CanGrow = false;
			this.DtyItemValue27.DataField = "ITEM_VALUE_87";
			this.DtyItemValue27.Height = 0.1875F;
			this.DtyItemValue27.Left = 8.0625F;
			this.DtyItemValue27.Name = "DtyItemValue27";
			this.DtyItemValue27.OutputFormat = "0.00";
			this.DtyItemValue27.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue27.Text = "ZZ9.99";
			this.DtyItemValue27.Top = 3.1875F;
			this.DtyItemValue27.Width = 0.625F;
			// 
			// DtyItemValue26
			// 
			this.DtyItemValue26.CanGrow = false;
			this.DtyItemValue26.DataField = "ITEM_VALUE_86";
			this.DtyItemValue26.Height = 0.188F;
			this.DtyItemValue26.Left = 7.438F;
			this.DtyItemValue26.Name = "DtyItemValue26";
			this.DtyItemValue26.OutputFormat = "0.00";
			this.DtyItemValue26.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue26.Text = "ZZ9.99";
			this.DtyItemValue26.Top = 3.1875F;
			this.DtyItemValue26.Width = 0.625F;
			// 
			// DtyItemName30
			// 
			this.DtyItemName30.CanGrow = false;
			this.DtyItemName30.DataField = "ITEM_NAME_90";
			this.DtyItemName30.Height = 0.1875F;
			this.DtyItemName30.Left = 9.9375F;
			this.DtyItemName30.Name = "DtyItemName30";
			this.DtyItemName30.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName30.Text = "あああああ";
			this.DtyItemName30.Top = 3F;
			this.DtyItemName30.Width = 0.6875F;
			// 
			// DtyItemName29
			// 
			this.DtyItemName29.CanGrow = false;
			this.DtyItemName29.DataField = "ITEM_NAME_89";
			this.DtyItemName29.Height = 0.1875F;
			this.DtyItemName29.Left = 9.3125F;
			this.DtyItemName29.Name = "DtyItemName29";
			this.DtyItemName29.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName29.Text = "あああああ";
			this.DtyItemName29.Top = 3F;
			this.DtyItemName29.Width = 0.625F;
			// 
			// DtyItemName28
			// 
			this.DtyItemName28.CanGrow = false;
			this.DtyItemName28.DataField = "ITEM_NAME_88";
			this.DtyItemName28.Height = 0.1875F;
			this.DtyItemName28.Left = 8.6875F;
			this.DtyItemName28.Name = "DtyItemName28";
			this.DtyItemName28.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName28.Text = "あああああ";
			this.DtyItemName28.Top = 3F;
			this.DtyItemName28.Width = 0.625F;
			// 
			// DtyItemName26
			// 
			this.DtyItemName26.CanGrow = false;
			this.DtyItemName26.DataField = "ITEM_NAME_86";
			this.DtyItemName26.Height = 0.188F;
			this.DtyItemName26.Left = 7.438F;
			this.DtyItemName26.Name = "DtyItemName26";
			this.DtyItemName26.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName26.Text = "あああああ";
			this.DtyItemName26.Top = 3F;
			this.DtyItemName26.Width = 0.625F;
			// 
			// DtyItemName27
			// 
			this.DtyItemName27.CanGrow = false;
			this.DtyItemName27.DataField = "ITEM_NAME_87";
			this.DtyItemName27.Height = 0.1875F;
			this.DtyItemName27.Left = 8.0625F;
			this.DtyItemName27.Name = "DtyItemName27";
			this.DtyItemName27.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName27.Text = "あああああ";
			this.DtyItemName27.Top = 3F;
			this.DtyItemName27.Width = 0.625F;
			// 
			// DedItemName26
			// 
			this.DedItemName26.CanGrow = false;
			this.DedItemName26.DataField = "ITEM_NAME_56";
			this.DedItemName26.Height = 0.188F;
			this.DedItemName26.Left = 5.5F;
			this.DedItemName26.Name = "DedItemName26";
			this.DedItemName26.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName26.Text = "ああああああああ";
			this.DedItemName26.Top = 5.8125F;
			this.DedItemName26.Width = 1.02F;
			// 
			// DedItemValue26
			// 
			this.DedItemValue26.CanGrow = false;
			this.DedItemValue26.DataField = "ITEM_VALUE_56";
			this.DedItemValue26.Height = 0.188F;
			this.DedItemValue26.Left = 6.520501F;
			this.DedItemValue26.Name = "DedItemValue26";
			this.DedItemValue26.OutputFormat = "#,##0";
			this.DedItemValue26.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue26.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue26.Top = 5.813502F;
			this.DedItemValue26.Width = 0.68F;
			// 
			// DedItemName25
			// 
			this.DedItemName25.CanGrow = false;
			this.DedItemName25.DataField = "ITEM_NAME_55";
			this.DedItemName25.Height = 0.188F;
			this.DedItemName25.Left = 5.5F;
			this.DedItemName25.Name = "DedItemName25";
			this.DedItemName25.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName25.Text = "ああああああああ";
			this.DedItemName25.Top = 5.625F;
			this.DedItemName25.Width = 1.02F;
			// 
			// DedItemValue25
			// 
			this.DedItemValue25.CanGrow = false;
			this.DedItemValue25.DataField = "ITEM_VALUE_55";
			this.DedItemValue25.Height = 0.188F;
			this.DedItemValue25.Left = 6.520501F;
			this.DedItemValue25.Name = "DedItemValue25";
			this.DedItemValue25.OutputFormat = "#,##0";
			this.DedItemValue25.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue25.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue25.Top = 5.626002F;
			this.DedItemValue25.Width = 0.68F;
			// 
			// DedItemName24
			// 
			this.DedItemName24.CanGrow = false;
			this.DedItemName24.DataField = "ITEM_NAME_54";
			this.DedItemName24.Height = 0.188F;
			this.DedItemName24.Left = 5.5F;
			this.DedItemName24.Name = "DedItemName24";
			this.DedItemName24.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName24.Text = "ああああああああ";
			this.DedItemName24.Top = 5.4375F;
			this.DedItemName24.Width = 1.02F;
			// 
			// DedItemValue24
			// 
			this.DedItemValue24.CanGrow = false;
			this.DedItemValue24.DataField = "ITEM_VALUE_54";
			this.DedItemValue24.Height = 0.188F;
			this.DedItemValue24.Left = 6.520501F;
			this.DedItemValue24.Name = "DedItemValue24";
			this.DedItemValue24.OutputFormat = "#,##0";
			this.DedItemValue24.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue24.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue24.Top = 5.438502F;
			this.DedItemValue24.Width = 0.68F;
			// 
			// DedItemValue23
			// 
			this.DedItemValue23.CanGrow = false;
			this.DedItemValue23.DataField = "ITEM_VALUE_53";
			this.DedItemValue23.Height = 0.188F;
			this.DedItemValue23.Left = 6.520501F;
			this.DedItemValue23.Name = "DedItemValue23";
			this.DedItemValue23.OutputFormat = "#,##0";
			this.DedItemValue23.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue23.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue23.Top = 5.251002F;
			this.DedItemValue23.Width = 0.68F;
			// 
			// DedItemName23
			// 
			this.DedItemName23.CanGrow = false;
			this.DedItemName23.DataField = "ITEM_NAME_53";
			this.DedItemName23.Height = 0.188F;
			this.DedItemName23.Left = 5.5F;
			this.DedItemName23.Name = "DedItemName23";
			this.DedItemName23.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName23.Text = "ああああああああ";
			this.DedItemName23.Top = 5.25F;
			this.DedItemName23.Width = 1.02F;
			// 
			// DtyItemValue21
			// 
			this.DtyItemValue21.CanGrow = false;
			this.DtyItemValue21.DataField = "ITEM_VALUE_81";
			this.DtyItemValue21.Height = 0.188F;
			this.DtyItemValue21.Left = 7.438F;
			this.DtyItemValue21.Name = "DtyItemValue21";
			this.DtyItemValue21.OutputFormat = "0.00";
			this.DtyItemValue21.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue21.Text = "ZZ9.99";
			this.DtyItemValue21.Top = 2.8125F;
			this.DtyItemValue21.Width = 0.625F;
			// 
			// EmpCode
			// 
			this.EmpCode.CanGrow = false;
			this.EmpCode.DataField = "EMP_CODE";
			this.EmpCode.Height = 0.1875F;
			this.EmpCode.Left = 0.1875F;
			this.EmpCode.Name = "EmpCode";
			this.EmpCode.Style = "font-size: 9.75pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.EmpCode.Text = "BBBBBBBBBB";
			this.EmpCode.Top = 6F;
			this.EmpCode.Width = 0.75F;
			// 
			// SlryPaymntYear
			// 
			this.SlryPaymntYear.CanGrow = false;
			this.SlryPaymntYear.DataField = "SLRY_PAYMNT_YEAR";
			this.SlryPaymntYear.Height = 0.1875F;
			this.SlryPaymntYear.Left = 0.875F;
			this.SlryPaymntYear.Name = "SlryPaymntYear";
			this.SlryPaymntYear.Style = "font-size: 11.25pt; text-align: left; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 128";
			this.SlryPaymntYear.Text = "平成00年";
			this.SlryPaymntYear.Top = 0.75F;
			this.SlryPaymntYear.Width = 0.625F;
			// 
			// SlryPaymntMonth
			// 
			this.SlryPaymntMonth.CanGrow = false;
			this.SlryPaymntMonth.DataField = "SLRY_PAYMNT_MONTH";
			this.SlryPaymntMonth.Height = 0.1875F;
			this.SlryPaymntMonth.Left = 1.5F;
			this.SlryPaymntMonth.Name = "SlryPaymntMonth";
			this.SlryPaymntMonth.Style = "font-size: 11.25pt; text-align: left; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 128";
			this.SlryPaymntMonth.Text = "00月度";
			this.SlryPaymntMonth.Top = 0.75F;
			this.SlryPaymntMonth.Width = 0.5625F;
			// 
			// TitleLabel
			// 
			this.TitleLabel.Height = 0.3125F;
			this.TitleLabel.HyperLink = null;
			this.TitleLabel.Left = 0.0625F;
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Style = "font-size: 18pt; font-weight: normal; text-align: center; ddo-char-set: 128";
			this.TitleLabel.Text = "給与支給明細書";
			this.TitleLabel.Top = 1.5625F;
			this.TitleLabel.Width = 2.8125F;
			// 
			// EmpName
			// 
			this.EmpName.CanGrow = false;
			this.EmpName.DataField = "EMP_NAME";
			this.EmpName.Height = 0.1875F;
			this.EmpName.Left = 1F;
			this.EmpName.Name = "EmpName";
			this.EmpName.Style = "font-size: 9.75pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.EmpName.Text = "あああああああああああああああ";
			this.EmpName.Top = 6F;
			this.EmpName.Width = 2.25F;
			// 
			// AtacName
			// 
			this.AtacName.CanGrow = false;
			this.AtacName.DataField = "ATAC_NAME";
			this.AtacName.Height = 0.3125F;
			this.AtacName.Left = 1F;
			this.AtacName.Name = "AtacName";
			this.AtacName.Style = "font-size: 9.75pt; text-align: left; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 128";
			this.AtacName.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.AtacName.Top = 6.3125F;
			this.AtacName.Width = 2.25F;
			// 
			// AtacCode
			// 
			this.AtacCode.CanGrow = false;
			this.AtacCode.DataField = "ATAC_CODE";
			this.AtacCode.Height = 0.1875F;
			this.AtacCode.Left = 0.1875F;
			this.AtacCode.Name = "AtacCode";
			this.AtacCode.Style = "font-size: 9.75pt; text-align: left; vertical-align: top; white-space: nowrap; dd" +
    "o-char-set: 128";
			this.AtacCode.Text = "BBBBBBBBBB";
			this.AtacCode.Top = 6.3125F;
			this.AtacCode.Width = 0.75F;
			// 
			// MyCompName
			// 
			this.MyCompName.CanGrow = false;
			this.MyCompName.DataField = "MYCOMP_NAME";
			this.MyCompName.Height = 0.5625F;
			this.MyCompName.Left = 1F;
			this.MyCompName.Name = "MyCompName";
			this.MyCompName.Style = "font-size: 9.75pt; text-align: left; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 1";
			this.MyCompName.Text = "ああああああああああああああああああああああああああああああああああああああああああああああああああ";
			this.MyCompName.Top = 7.25F;
			this.MyCompName.Width = 2.25F;
			// 
			// Label127
			// 
			this.Label127.Height = 0.188F;
			this.Label127.HyperLink = null;
			this.Label127.Left = 3.75F;
			this.Label127.Name = "Label127";
			this.Label127.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label127.Text = "支　給";
			this.Label127.Top = 0.9375F;
			this.Label127.Width = 1.7F;
			// 
			// SlryItemName1
			// 
			this.SlryItemName1.CanGrow = false;
			this.SlryItemName1.DataField = "ITEM_NAME_1";
			this.SlryItemName1.Height = 0.188F;
			this.SlryItemName1.Left = 3.75F;
			this.SlryItemName1.Name = "SlryItemName1";
			this.SlryItemName1.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName1.Text = "ああああああああ";
			this.SlryItemName1.Top = 1.125F;
			this.SlryItemName1.Width = 1.02F;
			// 
			// SlryItemValue1
			// 
			this.SlryItemValue1.CanGrow = false;
			this.SlryItemValue1.DataField = "ITEM_VALUE_1";
			this.SlryItemValue1.Height = 0.188F;
			this.SlryItemValue1.Left = 4.771001F;
			this.SlryItemValue1.Name = "SlryItemValue1";
			this.SlryItemValue1.OutputFormat = "#,##0";
			this.SlryItemValue1.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue1.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue1.Top = 1.125F;
			this.SlryItemValue1.Width = 0.68F;
			// 
			// Line361
			// 
			this.Line361.Height = 0F;
			this.Line361.Left = 3.7505F;
			this.Line361.LineWeight = 1F;
			this.Line361.Name = "Line361";
			this.Line361.Top = 1.313F;
			this.Line361.Width = 1.7F;
			this.Line361.X1 = 3.7505F;
			this.Line361.X2 = 5.4505F;
			this.Line361.Y1 = 1.313F;
			this.Line361.Y2 = 1.313F;
			// 
			// Label129
			// 
			this.Label129.Height = 0.1875F;
			this.Label129.HyperLink = null;
			this.Label129.Left = 7.469F;
			this.Label129.Name = "Label129";
			this.Label129.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label129.Text = "勤　怠／その他";
			this.Label129.Top = 0.938F;
			this.Label129.Width = 3.125F;
			// 
			// DtyItemName1
			// 
			this.DtyItemName1.CanGrow = false;
			this.DtyItemName1.DataField = "ITEM_NAME_61";
			this.DtyItemName1.Height = 0.188F;
			this.DtyItemName1.Left = 7.438F;
			this.DtyItemName1.Name = "DtyItemName1";
			this.DtyItemName1.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName1.Text = "あああああ";
			this.DtyItemName1.Top = 1.125F;
			this.DtyItemName1.Width = 0.625F;
			// 
			// DtyItemName2
			// 
			this.DtyItemName2.CanGrow = false;
			this.DtyItemName2.DataField = "ITEM_NAME_62";
			this.DtyItemName2.Height = 0.1875F;
			this.DtyItemName2.Left = 8.0625F;
			this.DtyItemName2.Name = "DtyItemName2";
			this.DtyItemName2.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName2.Text = "あああああ";
			this.DtyItemName2.Top = 1.125F;
			this.DtyItemName2.Width = 0.625F;
			// 
			// DtyItemName3
			// 
			this.DtyItemName3.CanGrow = false;
			this.DtyItemName3.DataField = "ITEM_NAME_63";
			this.DtyItemName3.Height = 0.1875F;
			this.DtyItemName3.Left = 8.6875F;
			this.DtyItemName3.Name = "DtyItemName3";
			this.DtyItemName3.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName3.Text = "あああああ";
			this.DtyItemName3.Top = 1.125F;
			this.DtyItemName3.Width = 0.625F;
			// 
			// DtyItemName4
			// 
			this.DtyItemName4.CanGrow = false;
			this.DtyItemName4.DataField = "ITEM_NAME_64";
			this.DtyItemName4.Height = 0.1875F;
			this.DtyItemName4.Left = 9.3125F;
			this.DtyItemName4.Name = "DtyItemName4";
			this.DtyItemName4.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName4.Text = "あああああ";
			this.DtyItemName4.Top = 1.125F;
			this.DtyItemName4.Width = 0.625F;
			// 
			// DtyItemName5
			// 
			this.DtyItemName5.CanGrow = false;
			this.DtyItemName5.DataField = "ITEM_NAME_65";
			this.DtyItemName5.Height = 0.1875F;
			this.DtyItemName5.Left = 9.9375F;
			this.DtyItemName5.Name = "DtyItemName5";
			this.DtyItemName5.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName5.Text = "あああああ";
			this.DtyItemName5.Top = 1.125F;
			this.DtyItemName5.Width = 0.6875F;
			// 
			// DtyItemValue1
			// 
			this.DtyItemValue1.CanGrow = false;
			this.DtyItemValue1.DataField = "ITEM_VALUE_61";
			this.DtyItemValue1.Height = 0.188F;
			this.DtyItemValue1.Left = 7.438F;
			this.DtyItemValue1.Name = "DtyItemValue1";
			this.DtyItemValue1.OutputFormat = "0.00";
			this.DtyItemValue1.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue1.Text = "ZZ9.99";
			this.DtyItemValue1.Top = 1.313F;
			this.DtyItemValue1.Width = 0.625F;
			// 
			// DtyItemValue2
			// 
			this.DtyItemValue2.CanGrow = false;
			this.DtyItemValue2.DataField = "ITEM_VALUE_62";
			this.DtyItemValue2.Height = 0.1875F;
			this.DtyItemValue2.Left = 8.0625F;
			this.DtyItemValue2.Name = "DtyItemValue2";
			this.DtyItemValue2.OutputFormat = "0.00";
			this.DtyItemValue2.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue2.Text = "ZZ9.99";
			this.DtyItemValue2.Top = 1.3125F;
			this.DtyItemValue2.Width = 0.625F;
			// 
			// DtyItemValue3
			// 
			this.DtyItemValue3.CanGrow = false;
			this.DtyItemValue3.DataField = "ITEM_VALUE_63";
			this.DtyItemValue3.Height = 0.1875F;
			this.DtyItemValue3.Left = 8.6875F;
			this.DtyItemValue3.Name = "DtyItemValue3";
			this.DtyItemValue3.OutputFormat = "0.00";
			this.DtyItemValue3.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue3.Text = "ZZ9.99";
			this.DtyItemValue3.Top = 1.3125F;
			this.DtyItemValue3.Width = 0.625F;
			// 
			// DtyItemValue4
			// 
			this.DtyItemValue4.CanGrow = false;
			this.DtyItemValue4.DataField = "ITEM_VALUE_64";
			this.DtyItemValue4.Height = 0.1875F;
			this.DtyItemValue4.Left = 9.3125F;
			this.DtyItemValue4.Name = "DtyItemValue4";
			this.DtyItemValue4.OutputFormat = "0.00";
			this.DtyItemValue4.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue4.Text = "ZZ9.99";
			this.DtyItemValue4.Top = 1.3125F;
			this.DtyItemValue4.Width = 0.625F;
			// 
			// DtyItemValue5
			// 
			this.DtyItemValue5.CanGrow = false;
			this.DtyItemValue5.DataField = "ITEM_VALUE_65";
			this.DtyItemValue5.Height = 0.1875F;
			this.DtyItemValue5.Left = 9.9375F;
			this.DtyItemValue5.Name = "DtyItemValue5";
			this.DtyItemValue5.OutputFormat = "0.00";
			this.DtyItemValue5.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue5.Text = "ZZ9.99";
			this.DtyItemValue5.Top = 1.3125F;
			this.DtyItemValue5.Width = 0.6875F;
			// 
			// SlryItemName2
			// 
			this.SlryItemName2.CanGrow = false;
			this.SlryItemName2.DataField = "ITEM_NAME_2";
			this.SlryItemName2.Height = 0.188F;
			this.SlryItemName2.Left = 3.75F;
			this.SlryItemName2.Name = "SlryItemName2";
			this.SlryItemName2.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName2.Text = "ああああああああ";
			this.SlryItemName2.Top = 1.3125F;
			this.SlryItemName2.Width = 1.02F;
			// 
			// SlryItemValue2
			// 
			this.SlryItemValue2.CanGrow = false;
			this.SlryItemValue2.DataField = "ITEM_VALUE_2";
			this.SlryItemValue2.Height = 0.188F;
			this.SlryItemValue2.Left = 4.770501F;
			this.SlryItemValue2.Name = "SlryItemValue2";
			this.SlryItemValue2.OutputFormat = "#,##0";
			this.SlryItemValue2.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue2.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue2.Top = 1.313F;
			this.SlryItemValue2.Width = 0.68F;
			// 
			// SlryItemName3
			// 
			this.SlryItemName3.CanGrow = false;
			this.SlryItemName3.DataField = "ITEM_NAME_3";
			this.SlryItemName3.Height = 0.188F;
			this.SlryItemName3.Left = 3.75F;
			this.SlryItemName3.Name = "SlryItemName3";
			this.SlryItemName3.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName3.Text = "ああああああああ";
			this.SlryItemName3.Top = 1.5F;
			this.SlryItemName3.Width = 1.02F;
			// 
			// SlryItemValue3
			// 
			this.SlryItemValue3.CanGrow = false;
			this.SlryItemValue3.DataField = "ITEM_VALUE_3";
			this.SlryItemValue3.Height = 0.188F;
			this.SlryItemValue3.Left = 4.770501F;
			this.SlryItemValue3.Name = "SlryItemValue3";
			this.SlryItemValue3.OutputFormat = "#,##0";
			this.SlryItemValue3.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue3.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue3.Top = 1.5F;
			this.SlryItemValue3.Width = 0.68F;
			// 
			// SlryItemName4
			// 
			this.SlryItemName4.CanGrow = false;
			this.SlryItemName4.DataField = "ITEM_NAME_4";
			this.SlryItemName4.Height = 0.188F;
			this.SlryItemName4.Left = 3.75F;
			this.SlryItemName4.Name = "SlryItemName4";
			this.SlryItemName4.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName4.Text = "ああああああああ";
			this.SlryItemName4.Top = 1.6875F;
			this.SlryItemName4.Width = 1.02F;
			// 
			// SlryItemValue4
			// 
			this.SlryItemValue4.CanGrow = false;
			this.SlryItemValue4.DataField = "ITEM_VALUE_4";
			this.SlryItemValue4.Height = 0.188F;
			this.SlryItemValue4.Left = 4.770501F;
			this.SlryItemValue4.Name = "SlryItemValue4";
			this.SlryItemValue4.OutputFormat = "#,##0";
			this.SlryItemValue4.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue4.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue4.Top = 1.688F;
			this.SlryItemValue4.Width = 0.68F;
			// 
			// SlryItemName5
			// 
			this.SlryItemName5.CanGrow = false;
			this.SlryItemName5.DataField = "ITEM_NAME_5";
			this.SlryItemName5.Height = 0.188F;
			this.SlryItemName5.Left = 3.75F;
			this.SlryItemName5.Name = "SlryItemName5";
			this.SlryItemName5.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName5.Text = "ああああああああ";
			this.SlryItemName5.Top = 1.875F;
			this.SlryItemName5.Width = 1.02F;
			// 
			// SlryItemValue5
			// 
			this.SlryItemValue5.CanGrow = false;
			this.SlryItemValue5.DataField = "ITEM_VALUE_5";
			this.SlryItemValue5.Height = 0.188F;
			this.SlryItemValue5.Left = 4.770501F;
			this.SlryItemValue5.Name = "SlryItemValue5";
			this.SlryItemValue5.OutputFormat = "#,##0";
			this.SlryItemValue5.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue5.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue5.Top = 1.875F;
			this.SlryItemValue5.Width = 0.68F;
			// 
			// SlryItemName6
			// 
			this.SlryItemName6.CanGrow = false;
			this.SlryItemName6.DataField = "ITEM_NAME_6";
			this.SlryItemName6.Height = 0.188F;
			this.SlryItemName6.Left = 3.75F;
			this.SlryItemName6.Name = "SlryItemName6";
			this.SlryItemName6.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName6.Text = "ああああああああ";
			this.SlryItemName6.Top = 2.0625F;
			this.SlryItemName6.Width = 1.02F;
			// 
			// SlryItemValue6
			// 
			this.SlryItemValue6.CanGrow = false;
			this.SlryItemValue6.DataField = "ITEM_VALUE_6";
			this.SlryItemValue6.Height = 0.188F;
			this.SlryItemValue6.Left = 4.770501F;
			this.SlryItemValue6.Name = "SlryItemValue6";
			this.SlryItemValue6.OutputFormat = "#,##0";
			this.SlryItemValue6.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue6.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue6.Top = 2.063F;
			this.SlryItemValue6.Width = 0.68F;
			// 
			// SlryItemName7
			// 
			this.SlryItemName7.CanGrow = false;
			this.SlryItemName7.DataField = "ITEM_NAME_7";
			this.SlryItemName7.Height = 0.188F;
			this.SlryItemName7.Left = 3.75F;
			this.SlryItemName7.Name = "SlryItemName7";
			this.SlryItemName7.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName7.Text = "ああああああああ";
			this.SlryItemName7.Top = 2.25F;
			this.SlryItemName7.Width = 1.02F;
			// 
			// SlryItemValue7
			// 
			this.SlryItemValue7.CanGrow = false;
			this.SlryItemValue7.DataField = "ITEM_VALUE_7";
			this.SlryItemValue7.Height = 0.188F;
			this.SlryItemValue7.Left = 4.770501F;
			this.SlryItemValue7.Name = "SlryItemValue7";
			this.SlryItemValue7.OutputFormat = "#,##0";
			this.SlryItemValue7.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue7.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue7.Top = 2.25F;
			this.SlryItemValue7.Width = 0.68F;
			// 
			// SlryItemName8
			// 
			this.SlryItemName8.CanGrow = false;
			this.SlryItemName8.DataField = "ITEM_NAME_8";
			this.SlryItemName8.Height = 0.188F;
			this.SlryItemName8.Left = 3.75F;
			this.SlryItemName8.Name = "SlryItemName8";
			this.SlryItemName8.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName8.Text = "ああああああああ";
			this.SlryItemName8.Top = 2.4375F;
			this.SlryItemName8.Width = 1.02F;
			// 
			// SlryItemValue8
			// 
			this.SlryItemValue8.CanGrow = false;
			this.SlryItemValue8.DataField = "ITEM_VALUE_8";
			this.SlryItemValue8.Height = 0.188F;
			this.SlryItemValue8.Left = 4.770501F;
			this.SlryItemValue8.Name = "SlryItemValue8";
			this.SlryItemValue8.OutputFormat = "#,##0";
			this.SlryItemValue8.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue8.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue8.Top = 2.438F;
			this.SlryItemValue8.Width = 0.68F;
			// 
			// SlryItemName9
			// 
			this.SlryItemName9.CanGrow = false;
			this.SlryItemName9.DataField = "ITEM_NAME_9";
			this.SlryItemName9.Height = 0.188F;
			this.SlryItemName9.Left = 3.75F;
			this.SlryItemName9.Name = "SlryItemName9";
			this.SlryItemName9.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName9.Text = "ああああああああ";
			this.SlryItemName9.Top = 2.625F;
			this.SlryItemName9.Width = 1.02F;
			// 
			// SlryItemValue9
			// 
			this.SlryItemValue9.CanGrow = false;
			this.SlryItemValue9.DataField = "ITEM_VALUE_9";
			this.SlryItemValue9.Height = 0.188F;
			this.SlryItemValue9.Left = 4.770501F;
			this.SlryItemValue9.Name = "SlryItemValue9";
			this.SlryItemValue9.OutputFormat = "#,##0";
			this.SlryItemValue9.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue9.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue9.Top = 2.625F;
			this.SlryItemValue9.Width = 0.68F;
			// 
			// SlryItemName10
			// 
			this.SlryItemName10.CanGrow = false;
			this.SlryItemName10.DataField = "ITEM_NAME_10";
			this.SlryItemName10.Height = 0.188F;
			this.SlryItemName10.Left = 3.75F;
			this.SlryItemName10.Name = "SlryItemName10";
			this.SlryItemName10.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName10.Text = "ああああああああ";
			this.SlryItemName10.Top = 2.8125F;
			this.SlryItemName10.Width = 1.02F;
			// 
			// SlryItemValue10
			// 
			this.SlryItemValue10.CanGrow = false;
			this.SlryItemValue10.DataField = "ITEM_VALUE_10";
			this.SlryItemValue10.Height = 0.188F;
			this.SlryItemValue10.Left = 4.770501F;
			this.SlryItemValue10.Name = "SlryItemValue10";
			this.SlryItemValue10.OutputFormat = "#,##0";
			this.SlryItemValue10.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue10.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue10.Top = 2.813F;
			this.SlryItemValue10.Width = 0.68F;
			// 
			// SlryItemName11
			// 
			this.SlryItemName11.CanGrow = false;
			this.SlryItemName11.DataField = "ITEM_NAME_11";
			this.SlryItemName11.Height = 0.188F;
			this.SlryItemName11.Left = 3.75F;
			this.SlryItemName11.Name = "SlryItemName11";
			this.SlryItemName11.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName11.Text = "ああああああああ";
			this.SlryItemName11.Top = 3F;
			this.SlryItemName11.Width = 1.02F;
			// 
			// SlryItemValue11
			// 
			this.SlryItemValue11.CanGrow = false;
			this.SlryItemValue11.DataField = "ITEM_VALUE_11";
			this.SlryItemValue11.Height = 0.188F;
			this.SlryItemValue11.Left = 4.771001F;
			this.SlryItemValue11.Name = "SlryItemValue11";
			this.SlryItemValue11.OutputFormat = "#,##0";
			this.SlryItemValue11.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue11.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue11.Top = 3F;
			this.SlryItemValue11.Width = 0.68F;
			// 
			// SlryItemName12
			// 
			this.SlryItemName12.CanGrow = false;
			this.SlryItemName12.DataField = "ITEM_NAME_12";
			this.SlryItemName12.Height = 0.188F;
			this.SlryItemName12.Left = 3.75F;
			this.SlryItemName12.Name = "SlryItemName12";
			this.SlryItemName12.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName12.Text = "ああああああああ";
			this.SlryItemName12.Top = 3.1875F;
			this.SlryItemName12.Width = 1.02F;
			// 
			// SlryItemValue12
			// 
			this.SlryItemValue12.CanGrow = false;
			this.SlryItemValue12.DataField = "ITEM_VALUE_12";
			this.SlryItemValue12.Height = 0.188F;
			this.SlryItemValue12.Left = 4.770501F;
			this.SlryItemValue12.Name = "SlryItemValue12";
			this.SlryItemValue12.OutputFormat = "#,##0";
			this.SlryItemValue12.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue12.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue12.Top = 3.188F;
			this.SlryItemValue12.Width = 0.68F;
			// 
			// SlryItemName13
			// 
			this.SlryItemName13.CanGrow = false;
			this.SlryItemName13.DataField = "ITEM_NAME_13";
			this.SlryItemName13.Height = 0.188F;
			this.SlryItemName13.Left = 3.75F;
			this.SlryItemName13.Name = "SlryItemName13";
			this.SlryItemName13.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName13.Text = "ああああああああ";
			this.SlryItemName13.Top = 3.375F;
			this.SlryItemName13.Width = 1.02F;
			// 
			// SlryItemValue13
			// 
			this.SlryItemValue13.CanGrow = false;
			this.SlryItemValue13.DataField = "ITEM_VALUE_13";
			this.SlryItemValue13.Height = 0.188F;
			this.SlryItemValue13.Left = 4.770501F;
			this.SlryItemValue13.Name = "SlryItemValue13";
			this.SlryItemValue13.OutputFormat = "#,##0";
			this.SlryItemValue13.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue13.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue13.Top = 3.375F;
			this.SlryItemValue13.Width = 0.68F;
			// 
			// SlryItemName14
			// 
			this.SlryItemName14.CanGrow = false;
			this.SlryItemName14.DataField = "ITEM_NAME_14";
			this.SlryItemName14.Height = 0.188F;
			this.SlryItemName14.Left = 3.75F;
			this.SlryItemName14.Name = "SlryItemName14";
			this.SlryItemName14.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName14.Text = "ああああああああ";
			this.SlryItemName14.Top = 3.5625F;
			this.SlryItemName14.Width = 1.02F;
			// 
			// SlryItemValue14
			// 
			this.SlryItemValue14.CanGrow = false;
			this.SlryItemValue14.DataField = "ITEM_VALUE_14";
			this.SlryItemValue14.Height = 0.188F;
			this.SlryItemValue14.Left = 4.770501F;
			this.SlryItemValue14.Name = "SlryItemValue14";
			this.SlryItemValue14.OutputFormat = "#,##0";
			this.SlryItemValue14.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue14.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue14.Top = 3.563F;
			this.SlryItemValue14.Width = 0.68F;
			// 
			// SlryItemName15
			// 
			this.SlryItemName15.CanGrow = false;
			this.SlryItemName15.DataField = "ITEM_NAME_15";
			this.SlryItemName15.Height = 0.188F;
			this.SlryItemName15.Left = 3.75F;
			this.SlryItemName15.Name = "SlryItemName15";
			this.SlryItemName15.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName15.Text = "ああああああああ";
			this.SlryItemName15.Top = 3.75F;
			this.SlryItemName15.Width = 1.02F;
			// 
			// SlryItemValue15
			// 
			this.SlryItemValue15.CanGrow = false;
			this.SlryItemValue15.DataField = "ITEM_VALUE_15";
			this.SlryItemValue15.Height = 0.188F;
			this.SlryItemValue15.Left = 4.770501F;
			this.SlryItemValue15.Name = "SlryItemValue15";
			this.SlryItemValue15.OutputFormat = "#,##0";
			this.SlryItemValue15.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue15.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue15.Top = 3.75F;
			this.SlryItemValue15.Width = 0.68F;
			// 
			// SlryItemName16
			// 
			this.SlryItemName16.CanGrow = false;
			this.SlryItemName16.DataField = "ITEM_NAME_16";
			this.SlryItemName16.Height = 0.188F;
			this.SlryItemName16.Left = 3.75F;
			this.SlryItemName16.Name = "SlryItemName16";
			this.SlryItemName16.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName16.Text = "ああああああああ";
			this.SlryItemName16.Top = 3.9375F;
			this.SlryItemName16.Width = 1.02F;
			// 
			// SlryItemValue16
			// 
			this.SlryItemValue16.CanGrow = false;
			this.SlryItemValue16.DataField = "ITEM_VALUE_16";
			this.SlryItemValue16.Height = 0.188F;
			this.SlryItemValue16.Left = 4.770501F;
			this.SlryItemValue16.Name = "SlryItemValue16";
			this.SlryItemValue16.OutputFormat = "#,##0";
			this.SlryItemValue16.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue16.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue16.Top = 3.938F;
			this.SlryItemValue16.Width = 0.68F;
			// 
			// SlryItemName17
			// 
			this.SlryItemName17.CanGrow = false;
			this.SlryItemName17.DataField = "ITEM_NAME_17";
			this.SlryItemName17.Height = 0.188F;
			this.SlryItemName17.Left = 3.75F;
			this.SlryItemName17.Name = "SlryItemName17";
			this.SlryItemName17.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName17.Text = "ああああああああ";
			this.SlryItemName17.Top = 4.125F;
			this.SlryItemName17.Width = 1.02F;
			// 
			// SlryItemValue17
			// 
			this.SlryItemValue17.CanGrow = false;
			this.SlryItemValue17.DataField = "ITEM_VALUE_17";
			this.SlryItemValue17.Height = 0.188F;
			this.SlryItemValue17.Left = 4.770501F;
			this.SlryItemValue17.Name = "SlryItemValue17";
			this.SlryItemValue17.OutputFormat = "#,##0";
			this.SlryItemValue17.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue17.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue17.Top = 4.125F;
			this.SlryItemValue17.Width = 0.68F;
			// 
			// SlryItemName18
			// 
			this.SlryItemName18.CanGrow = false;
			this.SlryItemName18.DataField = "ITEM_NAME_18";
			this.SlryItemName18.Height = 0.188F;
			this.SlryItemName18.Left = 3.75F;
			this.SlryItemName18.Name = "SlryItemName18";
			this.SlryItemName18.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName18.Text = "ああああああああ";
			this.SlryItemName18.Top = 4.3125F;
			this.SlryItemName18.Width = 1.02F;
			// 
			// SlryItemValue18
			// 
			this.SlryItemValue18.CanGrow = false;
			this.SlryItemValue18.DataField = "ITEM_VALUE_18";
			this.SlryItemValue18.Height = 0.188F;
			this.SlryItemValue18.Left = 4.770501F;
			this.SlryItemValue18.Name = "SlryItemValue18";
			this.SlryItemValue18.OutputFormat = "#,##0";
			this.SlryItemValue18.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue18.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue18.Top = 4.313F;
			this.SlryItemValue18.Width = 0.68F;
			// 
			// SlryItemName19
			// 
			this.SlryItemName19.CanGrow = false;
			this.SlryItemName19.DataField = "ITEM_NAME_19";
			this.SlryItemName19.Height = 0.188F;
			this.SlryItemName19.Left = 3.75F;
			this.SlryItemName19.Name = "SlryItemName19";
			this.SlryItemName19.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName19.Text = "ああああああああ";
			this.SlryItemName19.Top = 4.5F;
			this.SlryItemName19.Width = 1.02F;
			// 
			// SlryItemValue19
			// 
			this.SlryItemValue19.CanGrow = false;
			this.SlryItemValue19.DataField = "ITEM_VALUE_19";
			this.SlryItemValue19.Height = 0.188F;
			this.SlryItemValue19.Left = 4.770501F;
			this.SlryItemValue19.Name = "SlryItemValue19";
			this.SlryItemValue19.OutputFormat = "#,##0";
			this.SlryItemValue19.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue19.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue19.Top = 4.5F;
			this.SlryItemValue19.Width = 0.68F;
			// 
			// SlryItemName20
			// 
			this.SlryItemName20.CanGrow = false;
			this.SlryItemName20.DataField = "ITEM_NAME_20";
			this.SlryItemName20.Height = 0.188F;
			this.SlryItemName20.Left = 3.75F;
			this.SlryItemName20.Name = "SlryItemName20";
			this.SlryItemName20.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName20.Text = "ああああああああ";
			this.SlryItemName20.Top = 4.6875F;
			this.SlryItemName20.Width = 1.02F;
			// 
			// SlryItemValue20
			// 
			this.SlryItemValue20.CanGrow = false;
			this.SlryItemValue20.DataField = "ITEM_VALUE_20";
			this.SlryItemValue20.Height = 0.188F;
			this.SlryItemValue20.Left = 4.770501F;
			this.SlryItemValue20.Name = "SlryItemValue20";
			this.SlryItemValue20.OutputFormat = "#,##0";
			this.SlryItemValue20.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue20.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue20.Top = 4.688F;
			this.SlryItemValue20.Width = 0.68F;
			// 
			// SlryItemName21
			// 
			this.SlryItemName21.CanGrow = false;
			this.SlryItemName21.DataField = "ITEM_NAME_21";
			this.SlryItemName21.Height = 0.188F;
			this.SlryItemName21.Left = 3.75F;
			this.SlryItemName21.Name = "SlryItemName21";
			this.SlryItemName21.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName21.Text = "ああああああああ";
			this.SlryItemName21.Top = 4.875F;
			this.SlryItemName21.Width = 1.02F;
			// 
			// SlryItemValue21
			// 
			this.SlryItemValue21.CanGrow = false;
			this.SlryItemValue21.DataField = "ITEM_VALUE_21";
			this.SlryItemValue21.Height = 0.188F;
			this.SlryItemValue21.Left = 4.770501F;
			this.SlryItemValue21.Name = "SlryItemValue21";
			this.SlryItemValue21.OutputFormat = "#,##0";
			this.SlryItemValue21.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue21.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue21.Top = 4.875F;
			this.SlryItemValue21.Width = 0.68F;
			// 
			// SlryItemName22
			// 
			this.SlryItemName22.CanGrow = false;
			this.SlryItemName22.DataField = "ITEM_NAME_22";
			this.SlryItemName22.Height = 0.188F;
			this.SlryItemName22.Left = 3.75F;
			this.SlryItemName22.Name = "SlryItemName22";
			this.SlryItemName22.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName22.Text = "ああああああああ";
			this.SlryItemName22.Top = 5.0625F;
			this.SlryItemName22.Width = 1.02F;
			// 
			// SlryItemValue22
			// 
			this.SlryItemValue22.CanGrow = false;
			this.SlryItemValue22.DataField = "ITEM_VALUE_22";
			this.SlryItemValue22.Height = 0.188F;
			this.SlryItemValue22.Left = 4.770501F;
			this.SlryItemValue22.Name = "SlryItemValue22";
			this.SlryItemValue22.OutputFormat = "#,##0";
			this.SlryItemValue22.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue22.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue22.Top = 5.063001F;
			this.SlryItemValue22.Width = 0.68F;
			// 
			// SlryItemName23
			// 
			this.SlryItemName23.CanGrow = false;
			this.SlryItemName23.DataField = "ITEM_NAME_23";
			this.SlryItemName23.Height = 0.188F;
			this.SlryItemName23.Left = 3.75F;
			this.SlryItemName23.Name = "SlryItemName23";
			this.SlryItemName23.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName23.Text = "ああああああああ";
			this.SlryItemName23.Top = 5.25F;
			this.SlryItemName23.Width = 1.02F;
			// 
			// SlryItemValue23
			// 
			this.SlryItemValue23.CanGrow = false;
			this.SlryItemValue23.DataField = "ITEM_VALUE_23";
			this.SlryItemValue23.Height = 0.188F;
			this.SlryItemValue23.Left = 4.770501F;
			this.SlryItemValue23.Name = "SlryItemValue23";
			this.SlryItemValue23.OutputFormat = "#,##0";
			this.SlryItemValue23.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue23.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue23.Top = 5.25F;
			this.SlryItemValue23.Width = 0.68F;
			// 
			// SlryItemName24
			// 
			this.SlryItemName24.CanGrow = false;
			this.SlryItemName24.DataField = "ITEM_NAME_24";
			this.SlryItemName24.Height = 0.188F;
			this.SlryItemName24.Left = 3.75F;
			this.SlryItemName24.Name = "SlryItemName24";
			this.SlryItemName24.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName24.Text = "ああああああああ";
			this.SlryItemName24.Top = 5.4375F;
			this.SlryItemName24.Width = 1.02F;
			// 
			// SlryItemValue24
			// 
			this.SlryItemValue24.CanGrow = false;
			this.SlryItemValue24.DataField = "ITEM_VALUE_24";
			this.SlryItemValue24.Height = 0.188F;
			this.SlryItemValue24.Left = 4.770501F;
			this.SlryItemValue24.Name = "SlryItemValue24";
			this.SlryItemValue24.OutputFormat = "#,##0";
			this.SlryItemValue24.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue24.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue24.Top = 5.438001F;
			this.SlryItemValue24.Width = 0.68F;
			// 
			// SlryItemValue25
			// 
			this.SlryItemValue25.CanGrow = false;
			this.SlryItemValue25.DataField = "ITEM_VALUE_25";
			this.SlryItemValue25.Height = 0.188F;
			this.SlryItemValue25.Left = 4.770501F;
			this.SlryItemValue25.Name = "SlryItemValue25";
			this.SlryItemValue25.OutputFormat = "#,##0";
			this.SlryItemValue25.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue25.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue25.Top = 5.625999F;
			this.SlryItemValue25.Width = 0.68F;
			// 
			// SlryPaymntYear2
			// 
			this.SlryPaymntYear2.CanGrow = false;
			this.SlryPaymntYear2.DataField = "SLRY_PAYMNT_YEAR";
			this.SlryPaymntYear2.Height = 0.1875F;
			this.SlryPaymntYear2.Left = 3.75F;
			this.SlryPaymntYear2.Name = "SlryPaymntYear2";
			this.SlryPaymntYear2.Style = "font-size: 9.75pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.SlryPaymntYear2.Text = "平成00年";
			this.SlryPaymntYear2.Top = 0.375F;
			this.SlryPaymntYear2.Width = 0.5625F;
			// 
			// Label137
			// 
			this.Label137.Height = 0.1875F;
			this.Label137.HyperLink = null;
			this.Label137.Left = 4.875F;
			this.Label137.Name = "Label137";
			this.Label137.Style = "font-size: 9.75pt; vertical-align: middle; ddo-char-set: 128";
			this.Label137.Text = "支給日";
			this.Label137.Top = 0.375F;
			this.Label137.Width = 0.4375F;
			// 
			// Title2Label
			// 
			this.Title2Label.Height = 0.25F;
			this.Title2Label.HyperLink = null;
			this.Title2Label.Left = 7.5F;
			this.Title2Label.Name = "Title2Label";
			this.Title2Label.Style = "font-size: 14pt; font-weight: normal; text-align: center; ddo-char-set: 1";
			this.Title2Label.Text = "給与支給明細書";
			this.Title2Label.Top = 0.375F;
			this.Title2Label.Width = 3.125F;
			// 
			// DtyItemName6
			// 
			this.DtyItemName6.CanGrow = false;
			this.DtyItemName6.DataField = "ITEM_NAME_66";
			this.DtyItemName6.Height = 0.188F;
			this.DtyItemName6.Left = 7.438F;
			this.DtyItemName6.Name = "DtyItemName6";
			this.DtyItemName6.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName6.Text = "あああああ";
			this.DtyItemName6.Top = 1.5F;
			this.DtyItemName6.Width = 0.625F;
			// 
			// DtyItemName7
			// 
			this.DtyItemName7.CanGrow = false;
			this.DtyItemName7.DataField = "ITEM_NAME_67";
			this.DtyItemName7.Height = 0.1875F;
			this.DtyItemName7.Left = 8.0625F;
			this.DtyItemName7.Name = "DtyItemName7";
			this.DtyItemName7.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName7.Text = "あああああ";
			this.DtyItemName7.Top = 1.5F;
			this.DtyItemName7.Width = 0.625F;
			// 
			// DtyItemName8
			// 
			this.DtyItemName8.CanGrow = false;
			this.DtyItemName8.DataField = "ITEM_NAME_68";
			this.DtyItemName8.Height = 0.1875F;
			this.DtyItemName8.Left = 8.6875F;
			this.DtyItemName8.Name = "DtyItemName8";
			this.DtyItemName8.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName8.Text = "あああああ";
			this.DtyItemName8.Top = 1.5F;
			this.DtyItemName8.Width = 0.625F;
			// 
			// DtyItemName9
			// 
			this.DtyItemName9.CanGrow = false;
			this.DtyItemName9.DataField = "ITEM_NAME_69";
			this.DtyItemName9.Height = 0.1875F;
			this.DtyItemName9.Left = 9.3125F;
			this.DtyItemName9.Name = "DtyItemName9";
			this.DtyItemName9.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName9.Text = "あああああ";
			this.DtyItemName9.Top = 1.5F;
			this.DtyItemName9.Width = 0.625F;
			// 
			// DtyItemName10
			// 
			this.DtyItemName10.CanGrow = false;
			this.DtyItemName10.DataField = "ITEM_NAME_70";
			this.DtyItemName10.Height = 0.1875F;
			this.DtyItemName10.Left = 9.9375F;
			this.DtyItemName10.Name = "DtyItemName10";
			this.DtyItemName10.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName10.Text = "あああああ";
			this.DtyItemName10.Top = 1.5F;
			this.DtyItemName10.Width = 0.6875F;
			// 
			// DtyItemValue6
			// 
			this.DtyItemValue6.CanGrow = false;
			this.DtyItemValue6.DataField = "ITEM_VALUE_66";
			this.DtyItemValue6.Height = 0.188F;
			this.DtyItemValue6.Left = 7.438F;
			this.DtyItemValue6.Name = "DtyItemValue6";
			this.DtyItemValue6.OutputFormat = "0.00";
			this.DtyItemValue6.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue6.Text = "ZZ9.99";
			this.DtyItemValue6.Top = 1.6875F;
			this.DtyItemValue6.Width = 0.625F;
			// 
			// DtyItemValue7
			// 
			this.DtyItemValue7.CanGrow = false;
			this.DtyItemValue7.DataField = "ITEM_VALUE_67";
			this.DtyItemValue7.Height = 0.1875F;
			this.DtyItemValue7.Left = 8.0625F;
			this.DtyItemValue7.Name = "DtyItemValue7";
			this.DtyItemValue7.OutputFormat = "0.00";
			this.DtyItemValue7.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue7.Text = "ZZ9.99";
			this.DtyItemValue7.Top = 1.6875F;
			this.DtyItemValue7.Width = 0.625F;
			// 
			// DtyItemValue8
			// 
			this.DtyItemValue8.CanGrow = false;
			this.DtyItemValue8.DataField = "ITEM_VALUE_68";
			this.DtyItemValue8.Height = 0.1875F;
			this.DtyItemValue8.Left = 8.6875F;
			this.DtyItemValue8.Name = "DtyItemValue8";
			this.DtyItemValue8.OutputFormat = "0.00";
			this.DtyItemValue8.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue8.Text = "ZZ9.99";
			this.DtyItemValue8.Top = 1.6875F;
			this.DtyItemValue8.Width = 0.625F;
			// 
			// DtyItemValue9
			// 
			this.DtyItemValue9.CanGrow = false;
			this.DtyItemValue9.DataField = "ITEM_VALUE_69";
			this.DtyItemValue9.Height = 0.1875F;
			this.DtyItemValue9.Left = 9.3125F;
			this.DtyItemValue9.Name = "DtyItemValue9";
			this.DtyItemValue9.OutputFormat = "0.00";
			this.DtyItemValue9.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue9.Text = "ZZ9.99";
			this.DtyItemValue9.Top = 1.6875F;
			this.DtyItemValue9.Width = 0.625F;
			// 
			// DtyItemValue10
			// 
			this.DtyItemValue10.CanGrow = false;
			this.DtyItemValue10.DataField = "ITEM_VALUE_70";
			this.DtyItemValue10.Height = 0.1875F;
			this.DtyItemValue10.Left = 9.9375F;
			this.DtyItemValue10.Name = "DtyItemValue10";
			this.DtyItemValue10.OutputFormat = "0.00";
			this.DtyItemValue10.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue10.Text = "ZZ9.99";
			this.DtyItemValue10.Top = 1.6875F;
			this.DtyItemValue10.Width = 0.6875F;
			// 
			// DtyItemName11
			// 
			this.DtyItemName11.CanGrow = false;
			this.DtyItemName11.DataField = "ITEM_NAME_71";
			this.DtyItemName11.Height = 0.188F;
			this.DtyItemName11.Left = 7.438F;
			this.DtyItemName11.Name = "DtyItemName11";
			this.DtyItemName11.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName11.Text = "あああああ";
			this.DtyItemName11.Top = 1.875F;
			this.DtyItemName11.Width = 0.625F;
			// 
			// DtyItemName12
			// 
			this.DtyItemName12.CanGrow = false;
			this.DtyItemName12.DataField = "ITEM_NAME_72";
			this.DtyItemName12.Height = 0.1875F;
			this.DtyItemName12.Left = 8.0625F;
			this.DtyItemName12.Name = "DtyItemName12";
			this.DtyItemName12.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName12.Text = "あああああ";
			this.DtyItemName12.Top = 1.875F;
			this.DtyItemName12.Width = 0.625F;
			// 
			// DtyItemName13
			// 
			this.DtyItemName13.CanGrow = false;
			this.DtyItemName13.DataField = "ITEM_NAME_73";
			this.DtyItemName13.Height = 0.1875F;
			this.DtyItemName13.Left = 8.6875F;
			this.DtyItemName13.Name = "DtyItemName13";
			this.DtyItemName13.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName13.Text = "あああああ";
			this.DtyItemName13.Top = 1.875F;
			this.DtyItemName13.Width = 0.625F;
			// 
			// DtyItemName14
			// 
			this.DtyItemName14.CanGrow = false;
			this.DtyItemName14.DataField = "ITEM_NAME_74";
			this.DtyItemName14.Height = 0.1875F;
			this.DtyItemName14.Left = 9.3125F;
			this.DtyItemName14.Name = "DtyItemName14";
			this.DtyItemName14.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName14.Text = "あああああ";
			this.DtyItemName14.Top = 1.875F;
			this.DtyItemName14.Width = 0.625F;
			// 
			// DtyItemName15
			// 
			this.DtyItemName15.CanGrow = false;
			this.DtyItemName15.DataField = "ITEM_NAME_75";
			this.DtyItemName15.Height = 0.1875F;
			this.DtyItemName15.Left = 9.9375F;
			this.DtyItemName15.Name = "DtyItemName15";
			this.DtyItemName15.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName15.Text = "あああああ";
			this.DtyItemName15.Top = 1.875F;
			this.DtyItemName15.Width = 0.6875F;
			// 
			// DtyItemValue11
			// 
			this.DtyItemValue11.CanGrow = false;
			this.DtyItemValue11.DataField = "ITEM_VALUE_71";
			this.DtyItemValue11.Height = 0.188F;
			this.DtyItemValue11.Left = 7.438F;
			this.DtyItemValue11.Name = "DtyItemValue11";
			this.DtyItemValue11.OutputFormat = "0.00";
			this.DtyItemValue11.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue11.Text = "ZZ9.99";
			this.DtyItemValue11.Top = 2.0625F;
			this.DtyItemValue11.Width = 0.625F;
			// 
			// DtyItemValue12
			// 
			this.DtyItemValue12.CanGrow = false;
			this.DtyItemValue12.DataField = "ITEM_VALUE_72";
			this.DtyItemValue12.Height = 0.1875F;
			this.DtyItemValue12.Left = 8.0625F;
			this.DtyItemValue12.Name = "DtyItemValue12";
			this.DtyItemValue12.OutputFormat = "0.00";
			this.DtyItemValue12.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue12.Text = "ZZ9.99";
			this.DtyItemValue12.Top = 2.0625F;
			this.DtyItemValue12.Width = 0.625F;
			// 
			// DtyItemValue13
			// 
			this.DtyItemValue13.CanGrow = false;
			this.DtyItemValue13.DataField = "ITEM_VALUE_73";
			this.DtyItemValue13.Height = 0.1875F;
			this.DtyItemValue13.Left = 8.6875F;
			this.DtyItemValue13.Name = "DtyItemValue13";
			this.DtyItemValue13.OutputFormat = "0.00";
			this.DtyItemValue13.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue13.Text = "ZZ9.99";
			this.DtyItemValue13.Top = 2.0625F;
			this.DtyItemValue13.Width = 0.625F;
			// 
			// DtyItemValue14
			// 
			this.DtyItemValue14.CanGrow = false;
			this.DtyItemValue14.DataField = "ITEM_VALUE_74";
			this.DtyItemValue14.Height = 0.1875F;
			this.DtyItemValue14.Left = 9.3125F;
			this.DtyItemValue14.Name = "DtyItemValue14";
			this.DtyItemValue14.OutputFormat = "0.00";
			this.DtyItemValue14.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue14.Text = "ZZ9.99";
			this.DtyItemValue14.Top = 2.0625F;
			this.DtyItemValue14.Width = 0.625F;
			// 
			// DtyItemValue15
			// 
			this.DtyItemValue15.CanGrow = false;
			this.DtyItemValue15.DataField = "ITEM_VALUE_75";
			this.DtyItemValue15.Height = 0.1875F;
			this.DtyItemValue15.Left = 9.9375F;
			this.DtyItemValue15.Name = "DtyItemValue15";
			this.DtyItemValue15.OutputFormat = "0.00";
			this.DtyItemValue15.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue15.Text = "ZZ9.99";
			this.DtyItemValue15.Top = 2.0625F;
			this.DtyItemValue15.Width = 0.6875F;
			// 
			// DtyItemName16
			// 
			this.DtyItemName16.CanGrow = false;
			this.DtyItemName16.DataField = "ITEM_NAME_76";
			this.DtyItemName16.Height = 0.188F;
			this.DtyItemName16.Left = 7.438F;
			this.DtyItemName16.Name = "DtyItemName16";
			this.DtyItemName16.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName16.Text = "あああああ";
			this.DtyItemName16.Top = 2.25F;
			this.DtyItemName16.Width = 0.625F;
			// 
			// DtyItemName17
			// 
			this.DtyItemName17.CanGrow = false;
			this.DtyItemName17.DataField = "ITEM_NAME_77";
			this.DtyItemName17.Height = 0.1875F;
			this.DtyItemName17.Left = 8.0625F;
			this.DtyItemName17.Name = "DtyItemName17";
			this.DtyItemName17.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName17.Text = "あああああ";
			this.DtyItemName17.Top = 2.25F;
			this.DtyItemName17.Width = 0.625F;
			// 
			// DtyItemName18
			// 
			this.DtyItemName18.CanGrow = false;
			this.DtyItemName18.DataField = "ITEM_NAME_78";
			this.DtyItemName18.Height = 0.1875F;
			this.DtyItemName18.Left = 8.6875F;
			this.DtyItemName18.Name = "DtyItemName18";
			this.DtyItemName18.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName18.Text = "あああああ";
			this.DtyItemName18.Top = 2.25F;
			this.DtyItemName18.Width = 0.625F;
			// 
			// DtyItemName19
			// 
			this.DtyItemName19.CanGrow = false;
			this.DtyItemName19.DataField = "ITEM_NAME_79";
			this.DtyItemName19.Height = 0.1875F;
			this.DtyItemName19.Left = 9.3125F;
			this.DtyItemName19.Name = "DtyItemName19";
			this.DtyItemName19.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName19.Text = "あああああ";
			this.DtyItemName19.Top = 2.25F;
			this.DtyItemName19.Width = 0.625F;
			// 
			// DtyItemName20
			// 
			this.DtyItemName20.CanGrow = false;
			this.DtyItemName20.DataField = "ITEM_NAME_80";
			this.DtyItemName20.Height = 0.1875F;
			this.DtyItemName20.Left = 9.9375F;
			this.DtyItemName20.Name = "DtyItemName20";
			this.DtyItemName20.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName20.Text = "あああああ";
			this.DtyItemName20.Top = 2.25F;
			this.DtyItemName20.Width = 0.6875F;
			// 
			// DtyItemValue16
			// 
			this.DtyItemValue16.CanGrow = false;
			this.DtyItemValue16.DataField = "ITEM_VALUE_76";
			this.DtyItemValue16.Height = 0.188F;
			this.DtyItemValue16.Left = 7.438F;
			this.DtyItemValue16.Name = "DtyItemValue16";
			this.DtyItemValue16.OutputFormat = "0.00";
			this.DtyItemValue16.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue16.Text = "ZZ9.99";
			this.DtyItemValue16.Top = 2.4375F;
			this.DtyItemValue16.Width = 0.625F;
			// 
			// DtyItemValue17
			// 
			this.DtyItemValue17.CanGrow = false;
			this.DtyItemValue17.DataField = "ITEM_VALUE_77";
			this.DtyItemValue17.Height = 0.1875F;
			this.DtyItemValue17.Left = 8.0625F;
			this.DtyItemValue17.Name = "DtyItemValue17";
			this.DtyItemValue17.OutputFormat = "0.00";
			this.DtyItemValue17.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue17.Text = "ZZ9.99";
			this.DtyItemValue17.Top = 2.4375F;
			this.DtyItemValue17.Width = 0.625F;
			// 
			// DtyItemValue18
			// 
			this.DtyItemValue18.CanGrow = false;
			this.DtyItemValue18.DataField = "ITEM_VALUE_78";
			this.DtyItemValue18.Height = 0.1875F;
			this.DtyItemValue18.Left = 8.6875F;
			this.DtyItemValue18.Name = "DtyItemValue18";
			this.DtyItemValue18.OutputFormat = "0.00";
			this.DtyItemValue18.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue18.Text = "ZZ9.99";
			this.DtyItemValue18.Top = 2.4375F;
			this.DtyItemValue18.Width = 0.625F;
			// 
			// DtyItemValue19
			// 
			this.DtyItemValue19.CanGrow = false;
			this.DtyItemValue19.DataField = "ITEM_VALUE_79";
			this.DtyItemValue19.Height = 0.1875F;
			this.DtyItemValue19.Left = 9.3125F;
			this.DtyItemValue19.Name = "DtyItemValue19";
			this.DtyItemValue19.OutputFormat = "0.00";
			this.DtyItemValue19.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue19.Text = "ZZ9.99";
			this.DtyItemValue19.Top = 2.4375F;
			this.DtyItemValue19.Width = 0.625F;
			// 
			// DtyItemValue20
			// 
			this.DtyItemValue20.CanGrow = false;
			this.DtyItemValue20.DataField = "ITEM_VALUE_80";
			this.DtyItemValue20.Height = 0.1875F;
			this.DtyItemValue20.Left = 9.9375F;
			this.DtyItemValue20.Name = "DtyItemValue20";
			this.DtyItemValue20.OutputFormat = "0.00";
			this.DtyItemValue20.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue20.Text = "ZZ9.99";
			this.DtyItemValue20.Top = 2.4375F;
			this.DtyItemValue20.Width = 0.6875F;
			// 
			// DtyItemName21
			// 
			this.DtyItemName21.CanGrow = false;
			this.DtyItemName21.DataField = "ITEM_NAME_81";
			this.DtyItemName21.Height = 0.188F;
			this.DtyItemName21.Left = 7.438F;
			this.DtyItemName21.Name = "DtyItemName21";
			this.DtyItemName21.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName21.Text = "あああああ";
			this.DtyItemName21.Top = 2.625F;
			this.DtyItemName21.Width = 0.625F;
			// 
			// DtyItemName22
			// 
			this.DtyItemName22.CanGrow = false;
			this.DtyItemName22.DataField = "ITEM_NAME_82";
			this.DtyItemName22.Height = 0.1875F;
			this.DtyItemName22.Left = 8.0625F;
			this.DtyItemName22.Name = "DtyItemName22";
			this.DtyItemName22.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName22.Text = "あああああ";
			this.DtyItemName22.Top = 2.625F;
			this.DtyItemName22.Width = 0.625F;
			// 
			// DtyItemName23
			// 
			this.DtyItemName23.CanGrow = false;
			this.DtyItemName23.DataField = "ITEM_NAME_83";
			this.DtyItemName23.Height = 0.1875F;
			this.DtyItemName23.Left = 8.6875F;
			this.DtyItemName23.Name = "DtyItemName23";
			this.DtyItemName23.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName23.Text = "あああああ";
			this.DtyItemName23.Top = 2.625F;
			this.DtyItemName23.Width = 0.625F;
			// 
			// DtyItemName24
			// 
			this.DtyItemName24.CanGrow = false;
			this.DtyItemName24.DataField = "ITEM_NAME_84";
			this.DtyItemName24.Height = 0.1875F;
			this.DtyItemName24.Left = 9.3125F;
			this.DtyItemName24.Name = "DtyItemName24";
			this.DtyItemName24.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName24.Text = "あああああ";
			this.DtyItemName24.Top = 2.625F;
			this.DtyItemName24.Width = 0.625F;
			// 
			// DtyItemName25
			// 
			this.DtyItemName25.CanGrow = false;
			this.DtyItemName25.DataField = "ITEM_NAME_85";
			this.DtyItemName25.Height = 0.1875F;
			this.DtyItemName25.Left = 9.9375F;
			this.DtyItemName25.Name = "DtyItemName25";
			this.DtyItemName25.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.DtyItemName25.Text = "あああああ";
			this.DtyItemName25.Top = 2.625F;
			this.DtyItemName25.Width = 0.6875F;
			// 
			// DtyItemValue22
			// 
			this.DtyItemValue22.CanGrow = false;
			this.DtyItemValue22.DataField = "ITEM_VALUE_82";
			this.DtyItemValue22.Height = 0.1875F;
			this.DtyItemValue22.Left = 8.0625F;
			this.DtyItemValue22.Name = "DtyItemValue22";
			this.DtyItemValue22.OutputFormat = "0.00";
			this.DtyItemValue22.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue22.Text = "ZZ9.99";
			this.DtyItemValue22.Top = 2.8125F;
			this.DtyItemValue22.Width = 0.625F;
			// 
			// DtyItemValue23
			// 
			this.DtyItemValue23.CanGrow = false;
			this.DtyItemValue23.DataField = "ITEM_VALUE_83";
			this.DtyItemValue23.Height = 0.1875F;
			this.DtyItemValue23.Left = 8.6875F;
			this.DtyItemValue23.Name = "DtyItemValue23";
			this.DtyItemValue23.OutputFormat = "0.00";
			this.DtyItemValue23.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue23.Text = "ZZ9.99";
			this.DtyItemValue23.Top = 2.8125F;
			this.DtyItemValue23.Width = 0.625F;
			// 
			// DtyItemValue24
			// 
			this.DtyItemValue24.CanGrow = false;
			this.DtyItemValue24.DataField = "ITEM_VALUE_84";
			this.DtyItemValue24.Height = 0.1875F;
			this.DtyItemValue24.Left = 9.3125F;
			this.DtyItemValue24.Name = "DtyItemValue24";
			this.DtyItemValue24.OutputFormat = "0.00";
			this.DtyItemValue24.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue24.Text = "ZZ9.99";
			this.DtyItemValue24.Top = 2.8125F;
			this.DtyItemValue24.Width = 0.625F;
			// 
			// DtyItemValue25
			// 
			this.DtyItemValue25.CanGrow = false;
			this.DtyItemValue25.DataField = "ITEM_VALUE_85";
			this.DtyItemValue25.Height = 0.1875F;
			this.DtyItemValue25.Left = 9.9375F;
			this.DtyItemValue25.Name = "DtyItemValue25";
			this.DtyItemValue25.OutputFormat = "0.00";
			this.DtyItemValue25.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DtyItemValue25.Text = "ZZ9.99";
			this.DtyItemValue25.Top = 2.8125F;
			this.DtyItemValue25.Width = 0.6875F;
			// 
			// Label139
			// 
			this.Label139.Height = 0.1875F;
			this.Label139.HyperLink = null;
			this.Label139.Left = 7.469F;
			this.Label139.Name = "Label139";
			this.Label139.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label139.Text = "振込銀行";
			this.Label139.Top = 3.375F;
			this.Label139.Width = 1.1875F;
			// 
			// Label140
			// 
			this.Label140.Height = 0.1875F;
			this.Label140.HyperLink = null;
			this.Label140.Left = 8.6875F;
			this.Label140.Name = "Label140";
			this.Label140.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label140.Text = "支店";
			this.Label140.Top = 3.375F;
			this.Label140.Width = 1.25F;
			// 
			// Label141
			// 
			this.Label141.Height = 0.1875F;
			this.Label141.HyperLink = null;
			this.Label141.Left = 10F;
			this.Label141.Name = "Label141";
			this.Label141.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label141.Text = "振込額";
			this.Label141.Top = 3.375F;
			this.Label141.Width = 0.6875F;
			// 
			// Line362
			// 
			this.Line362.Height = 4.688001F;
			this.Line362.Left = 6.520501F;
			this.Line362.LineWeight = 1F;
			this.Line362.Name = "Line362";
			this.Line362.Top = 1.125F;
			this.Line362.Width = 0F;
			this.Line362.X1 = 6.520501F;
			this.Line362.X2 = 6.520501F;
			this.Line362.Y1 = 1.125F;
			this.Line362.Y2 = 5.813001F;
			// 
			// DedItemName2
			// 
			this.DedItemName2.CanGrow = false;
			this.DedItemName2.DataField = "ITEM_NAME_32";
			this.DedItemName2.Height = 0.188F;
			this.DedItemName2.Left = 5.5F;
			this.DedItemName2.Name = "DedItemName2";
			this.DedItemName2.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName2.Text = "ああああああああ";
			this.DedItemName2.Top = 1.3125F;
			this.DedItemName2.Width = 1.02F;
			// 
			// DedItemValue2
			// 
			this.DedItemValue2.CanGrow = false;
			this.DedItemValue2.DataField = "ITEM_VALUE_32";
			this.DedItemValue2.Height = 0.188F;
			this.DedItemValue2.Left = 6.520501F;
			this.DedItemValue2.Name = "DedItemValue2";
			this.DedItemValue2.OutputFormat = "#,##0";
			this.DedItemValue2.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue2.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue2.Top = 1.313F;
			this.DedItemValue2.Width = 0.68F;
			// 
			// DedItemName3
			// 
			this.DedItemName3.CanGrow = false;
			this.DedItemName3.DataField = "ITEM_NAME_33";
			this.DedItemName3.Height = 0.188F;
			this.DedItemName3.Left = 5.5F;
			this.DedItemName3.Name = "DedItemName3";
			this.DedItemName3.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName3.Text = "ああああああああ";
			this.DedItemName3.Top = 1.5F;
			this.DedItemName3.Width = 1.02F;
			// 
			// DedItemValue3
			// 
			this.DedItemValue3.CanGrow = false;
			this.DedItemValue3.DataField = "ITEM_VALUE_33";
			this.DedItemValue3.Height = 0.188F;
			this.DedItemValue3.Left = 6.520501F;
			this.DedItemValue3.Name = "DedItemValue3";
			this.DedItemValue3.OutputFormat = "#,##0";
			this.DedItemValue3.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue3.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue3.Top = 1.5F;
			this.DedItemValue3.Width = 0.68F;
			// 
			// DedItemName4
			// 
			this.DedItemName4.CanGrow = false;
			this.DedItemName4.DataField = "ITEM_NAME_34";
			this.DedItemName4.Height = 0.188F;
			this.DedItemName4.Left = 5.5F;
			this.DedItemName4.Name = "DedItemName4";
			this.DedItemName4.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName4.Text = "ああああああああ";
			this.DedItemName4.Top = 1.6875F;
			this.DedItemName4.Width = 1.02F;
			// 
			// DedItemValue4
			// 
			this.DedItemValue4.CanGrow = false;
			this.DedItemValue4.DataField = "ITEM_VALUE_34";
			this.DedItemValue4.Height = 0.188F;
			this.DedItemValue4.Left = 6.520501F;
			this.DedItemValue4.Name = "DedItemValue4";
			this.DedItemValue4.OutputFormat = "#,##0";
			this.DedItemValue4.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue4.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue4.Top = 1.688F;
			this.DedItemValue4.Width = 0.68F;
			// 
			// DedItemName5
			// 
			this.DedItemName5.CanGrow = false;
			this.DedItemName5.DataField = "ITEM_NAME_35";
			this.DedItemName5.Height = 0.188F;
			this.DedItemName5.Left = 5.5F;
			this.DedItemName5.Name = "DedItemName5";
			this.DedItemName5.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName5.Text = "ああああああああ";
			this.DedItemName5.Top = 1.875F;
			this.DedItemName5.Width = 1.02F;
			// 
			// DedItemValue5
			// 
			this.DedItemValue5.CanGrow = false;
			this.DedItemValue5.DataField = "ITEM_VALUE_35";
			this.DedItemValue5.Height = 0.188F;
			this.DedItemValue5.Left = 6.520501F;
			this.DedItemValue5.Name = "DedItemValue5";
			this.DedItemValue5.OutputFormat = "#,##0";
			this.DedItemValue5.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue5.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue5.Top = 1.875F;
			this.DedItemValue5.Width = 0.68F;
			// 
			// DedItemName6
			// 
			this.DedItemName6.CanGrow = false;
			this.DedItemName6.DataField = "ITEM_NAME_36";
			this.DedItemName6.Height = 0.188F;
			this.DedItemName6.Left = 5.5F;
			this.DedItemName6.Name = "DedItemName6";
			this.DedItemName6.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName6.Text = "ああああああああ";
			this.DedItemName6.Top = 2.0625F;
			this.DedItemName6.Width = 1.02F;
			// 
			// DedItemValue6
			// 
			this.DedItemValue6.CanGrow = false;
			this.DedItemValue6.DataField = "ITEM_VALUE_36";
			this.DedItemValue6.Height = 0.188F;
			this.DedItemValue6.Left = 6.520501F;
			this.DedItemValue6.Name = "DedItemValue6";
			this.DedItemValue6.OutputFormat = "#,##0";
			this.DedItemValue6.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue6.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue6.Top = 2.063F;
			this.DedItemValue6.Width = 0.68F;
			// 
			// DedItemName7
			// 
			this.DedItemName7.CanGrow = false;
			this.DedItemName7.DataField = "ITEM_NAME_37";
			this.DedItemName7.Height = 0.188F;
			this.DedItemName7.Left = 5.5F;
			this.DedItemName7.Name = "DedItemName7";
			this.DedItemName7.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName7.Text = "ああああああああ";
			this.DedItemName7.Top = 2.25F;
			this.DedItemName7.Width = 1.02F;
			// 
			// DedItemValue7
			// 
			this.DedItemValue7.CanGrow = false;
			this.DedItemValue7.DataField = "ITEM_VALUE_37";
			this.DedItemValue7.Height = 0.188F;
			this.DedItemValue7.Left = 6.520501F;
			this.DedItemValue7.Name = "DedItemValue7";
			this.DedItemValue7.OutputFormat = "#,##0";
			this.DedItemValue7.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue7.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue7.Top = 2.25F;
			this.DedItemValue7.Width = 0.68F;
			// 
			// DedItemName8
			// 
			this.DedItemName8.CanGrow = false;
			this.DedItemName8.DataField = "ITEM_NAME_38";
			this.DedItemName8.Height = 0.188F;
			this.DedItemName8.Left = 5.5F;
			this.DedItemName8.Name = "DedItemName8";
			this.DedItemName8.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName8.Text = "ああああああああ";
			this.DedItemName8.Top = 2.4375F;
			this.DedItemName8.Width = 1.02F;
			// 
			// DedItemValue8
			// 
			this.DedItemValue8.CanGrow = false;
			this.DedItemValue8.DataField = "ITEM_VALUE_38";
			this.DedItemValue8.Height = 0.188F;
			this.DedItemValue8.Left = 6.520501F;
			this.DedItemValue8.Name = "DedItemValue8";
			this.DedItemValue8.OutputFormat = "#,##0";
			this.DedItemValue8.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue8.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue8.Top = 2.438F;
			this.DedItemValue8.Width = 0.68F;
			// 
			// DedItemName9
			// 
			this.DedItemName9.CanGrow = false;
			this.DedItemName9.DataField = "ITEM_NAME_39";
			this.DedItemName9.Height = 0.188F;
			this.DedItemName9.Left = 5.5F;
			this.DedItemName9.Name = "DedItemName9";
			this.DedItemName9.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName9.Text = "ああああああああ";
			this.DedItemName9.Top = 2.625F;
			this.DedItemName9.Width = 1.02F;
			// 
			// DedItemValue9
			// 
			this.DedItemValue9.CanGrow = false;
			this.DedItemValue9.DataField = "ITEM_VALUE_39";
			this.DedItemValue9.Height = 0.188F;
			this.DedItemValue9.Left = 6.520501F;
			this.DedItemValue9.Name = "DedItemValue9";
			this.DedItemValue9.OutputFormat = "#,##0";
			this.DedItemValue9.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue9.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue9.Top = 2.625F;
			this.DedItemValue9.Width = 0.68F;
			// 
			// DedItemName10
			// 
			this.DedItemName10.CanGrow = false;
			this.DedItemName10.DataField = "ITEM_NAME_40";
			this.DedItemName10.Height = 0.188F;
			this.DedItemName10.Left = 5.5F;
			this.DedItemName10.Name = "DedItemName10";
			this.DedItemName10.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName10.Text = "ああああああああ";
			this.DedItemName10.Top = 2.8125F;
			this.DedItemName10.Width = 1.02F;
			// 
			// DedItemValue10
			// 
			this.DedItemValue10.CanGrow = false;
			this.DedItemValue10.DataField = "ITEM_VALUE_40";
			this.DedItemValue10.Height = 0.188F;
			this.DedItemValue10.Left = 6.520501F;
			this.DedItemValue10.Name = "DedItemValue10";
			this.DedItemValue10.OutputFormat = "#,##0";
			this.DedItemValue10.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue10.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue10.Top = 2.813F;
			this.DedItemValue10.Width = 0.68F;
			// 
			// DedItemName11
			// 
			this.DedItemName11.CanGrow = false;
			this.DedItemName11.DataField = "ITEM_NAME_41";
			this.DedItemName11.Height = 0.188F;
			this.DedItemName11.Left = 5.5F;
			this.DedItemName11.Name = "DedItemName11";
			this.DedItemName11.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName11.Text = "ああああああああ";
			this.DedItemName11.Top = 3F;
			this.DedItemName11.Width = 1.02F;
			// 
			// DedItemValue11
			// 
			this.DedItemValue11.CanGrow = false;
			this.DedItemValue11.DataField = "ITEM_VALUE_41";
			this.DedItemValue11.Height = 0.188F;
			this.DedItemValue11.Left = 6.520501F;
			this.DedItemValue11.Name = "DedItemValue11";
			this.DedItemValue11.OutputFormat = "#,##0";
			this.DedItemValue11.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue11.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue11.Top = 3F;
			this.DedItemValue11.Width = 0.68F;
			// 
			// DedItemName12
			// 
			this.DedItemName12.CanGrow = false;
			this.DedItemName12.DataField = "ITEM_NAME_42";
			this.DedItemName12.Height = 0.188F;
			this.DedItemName12.Left = 5.5F;
			this.DedItemName12.Name = "DedItemName12";
			this.DedItemName12.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName12.Text = "ああああああああ";
			this.DedItemName12.Top = 3.1875F;
			this.DedItemName12.Width = 1.02F;
			// 
			// DedItemValue12
			// 
			this.DedItemValue12.CanGrow = false;
			this.DedItemValue12.DataField = "ITEM_VALUE_42";
			this.DedItemValue12.Height = 0.188F;
			this.DedItemValue12.Left = 6.520501F;
			this.DedItemValue12.Name = "DedItemValue12";
			this.DedItemValue12.OutputFormat = "#,##0";
			this.DedItemValue12.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue12.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue12.Top = 3.188F;
			this.DedItemValue12.Width = 0.68F;
			// 
			// DedItemName13
			// 
			this.DedItemName13.CanGrow = false;
			this.DedItemName13.DataField = "ITEM_NAME_43";
			this.DedItemName13.Height = 0.188F;
			this.DedItemName13.Left = 5.5F;
			this.DedItemName13.Name = "DedItemName13";
			this.DedItemName13.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName13.Text = "ああああああああ";
			this.DedItemName13.Top = 3.375F;
			this.DedItemName13.Width = 1.02F;
			// 
			// DedItemValue13
			// 
			this.DedItemValue13.CanGrow = false;
			this.DedItemValue13.DataField = "ITEM_VALUE_43";
			this.DedItemValue13.Height = 0.188F;
			this.DedItemValue13.Left = 6.520501F;
			this.DedItemValue13.Name = "DedItemValue13";
			this.DedItemValue13.OutputFormat = "#,##0";
			this.DedItemValue13.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue13.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue13.Top = 3.375F;
			this.DedItemValue13.Width = 0.68F;
			// 
			// DedItemName14
			// 
			this.DedItemName14.CanGrow = false;
			this.DedItemName14.DataField = "ITEM_NAME_44";
			this.DedItemName14.Height = 0.188F;
			this.DedItemName14.Left = 5.5F;
			this.DedItemName14.Name = "DedItemName14";
			this.DedItemName14.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName14.Text = "ああああああああ";
			this.DedItemName14.Top = 3.5625F;
			this.DedItemName14.Width = 1.02F;
			// 
			// DedItemValue14
			// 
			this.DedItemValue14.CanGrow = false;
			this.DedItemValue14.DataField = "ITEM_VALUE_44";
			this.DedItemValue14.Height = 0.188F;
			this.DedItemValue14.Left = 6.520501F;
			this.DedItemValue14.Name = "DedItemValue14";
			this.DedItemValue14.OutputFormat = "#,##0";
			this.DedItemValue14.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue14.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue14.Top = 3.563F;
			this.DedItemValue14.Width = 0.68F;
			// 
			// DedItemName15
			// 
			this.DedItemName15.CanGrow = false;
			this.DedItemName15.DataField = "ITEM_NAME_45";
			this.DedItemName15.Height = 0.188F;
			this.DedItemName15.Left = 5.5F;
			this.DedItemName15.Name = "DedItemName15";
			this.DedItemName15.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName15.Text = "ああああああああ";
			this.DedItemName15.Top = 3.75F;
			this.DedItemName15.Width = 1.02F;
			// 
			// DedItemValue15
			// 
			this.DedItemValue15.CanGrow = false;
			this.DedItemValue15.DataField = "ITEM_VALUE_45";
			this.DedItemValue15.Height = 0.188F;
			this.DedItemValue15.Left = 6.520501F;
			this.DedItemValue15.Name = "DedItemValue15";
			this.DedItemValue15.OutputFormat = "#,##0";
			this.DedItemValue15.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue15.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue15.Top = 3.75F;
			this.DedItemValue15.Width = 0.68F;
			// 
			// DedItemName16
			// 
			this.DedItemName16.CanGrow = false;
			this.DedItemName16.DataField = "ITEM_NAME_46";
			this.DedItemName16.Height = 0.188F;
			this.DedItemName16.Left = 5.5F;
			this.DedItemName16.Name = "DedItemName16";
			this.DedItemName16.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName16.Text = "ああああああああ";
			this.DedItemName16.Top = 3.9375F;
			this.DedItemName16.Width = 1.02F;
			// 
			// DedItemValue16
			// 
			this.DedItemValue16.CanGrow = false;
			this.DedItemValue16.DataField = "ITEM_VALUE_46";
			this.DedItemValue16.Height = 0.188F;
			this.DedItemValue16.Left = 6.520501F;
			this.DedItemValue16.Name = "DedItemValue16";
			this.DedItemValue16.OutputFormat = "#,##0";
			this.DedItemValue16.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue16.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue16.Top = 3.938F;
			this.DedItemValue16.Width = 0.68F;
			// 
			// DedItemName17
			// 
			this.DedItemName17.CanGrow = false;
			this.DedItemName17.DataField = "ITEM_NAME_47";
			this.DedItemName17.Height = 0.188F;
			this.DedItemName17.Left = 5.5F;
			this.DedItemName17.Name = "DedItemName17";
			this.DedItemName17.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName17.Text = "ああああああああ";
			this.DedItemName17.Top = 4.125F;
			this.DedItemName17.Width = 1.02F;
			// 
			// DedItemValue17
			// 
			this.DedItemValue17.CanGrow = false;
			this.DedItemValue17.DataField = "ITEM_VALUE_47";
			this.DedItemValue17.Height = 0.188F;
			this.DedItemValue17.Left = 6.520501F;
			this.DedItemValue17.Name = "DedItemValue17";
			this.DedItemValue17.OutputFormat = "#,##0";
			this.DedItemValue17.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue17.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue17.Top = 4.125F;
			this.DedItemValue17.Width = 0.68F;
			// 
			// DedItemName18
			// 
			this.DedItemName18.CanGrow = false;
			this.DedItemName18.DataField = "ITEM_NAME_48";
			this.DedItemName18.Height = 0.188F;
			this.DedItemName18.Left = 5.5F;
			this.DedItemName18.Name = "DedItemName18";
			this.DedItemName18.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName18.Text = "ああああああああ";
			this.DedItemName18.Top = 4.3125F;
			this.DedItemName18.Width = 1.02F;
			// 
			// DedItemValue18
			// 
			this.DedItemValue18.CanGrow = false;
			this.DedItemValue18.DataField = "ITEM_VALUE_48";
			this.DedItemValue18.Height = 0.188F;
			this.DedItemValue18.Left = 6.520501F;
			this.DedItemValue18.Name = "DedItemValue18";
			this.DedItemValue18.OutputFormat = "#,##0";
			this.DedItemValue18.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue18.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue18.Top = 4.313F;
			this.DedItemValue18.Width = 0.68F;
			// 
			// DedItemName19
			// 
			this.DedItemName19.CanGrow = false;
			this.DedItemName19.DataField = "ITEM_NAME_49";
			this.DedItemName19.Height = 0.188F;
			this.DedItemName19.Left = 5.5F;
			this.DedItemName19.Name = "DedItemName19";
			this.DedItemName19.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName19.Text = "ああああああああ";
			this.DedItemName19.Top = 4.5F;
			this.DedItemName19.Width = 1.02F;
			// 
			// DedItemValue19
			// 
			this.DedItemValue19.CanGrow = false;
			this.DedItemValue19.DataField = "ITEM_VALUE_49";
			this.DedItemValue19.Height = 0.188F;
			this.DedItemValue19.Left = 6.520501F;
			this.DedItemValue19.Name = "DedItemValue19";
			this.DedItemValue19.OutputFormat = "#,##0";
			this.DedItemValue19.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue19.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue19.Top = 4.5F;
			this.DedItemValue19.Width = 0.68F;
			// 
			// DedItemName20
			// 
			this.DedItemName20.CanGrow = false;
			this.DedItemName20.DataField = "ITEM_NAME_50";
			this.DedItemName20.Height = 0.188F;
			this.DedItemName20.Left = 5.5F;
			this.DedItemName20.Name = "DedItemName20";
			this.DedItemName20.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName20.Text = "ああああああああ";
			this.DedItemName20.Top = 4.6875F;
			this.DedItemName20.Width = 1.02F;
			// 
			// DedItemValue20
			// 
			this.DedItemValue20.CanGrow = false;
			this.DedItemValue20.DataField = "ITEM_VALUE_50";
			this.DedItemValue20.Height = 0.188F;
			this.DedItemValue20.Left = 6.520501F;
			this.DedItemValue20.Name = "DedItemValue20";
			this.DedItemValue20.OutputFormat = "#,##0";
			this.DedItemValue20.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue20.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue20.Top = 4.688F;
			this.DedItemValue20.Width = 0.68F;
			// 
			// DedItemValue21
			// 
			this.DedItemValue21.CanGrow = false;
			this.DedItemValue21.DataField = "ITEM_VALUE_51";
			this.DedItemValue21.Height = 0.188F;
			this.DedItemValue21.Left = 6.520501F;
			this.DedItemValue21.Name = "DedItemValue21";
			this.DedItemValue21.OutputFormat = "#,##0";
			this.DedItemValue21.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue21.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue21.Top = 4.875F;
			this.DedItemValue21.Width = 0.68F;
			// 
			// DedItemValue22
			// 
			this.DedItemValue22.CanGrow = false;
			this.DedItemValue22.DataField = "ITEM_VALUE_52";
			this.DedItemValue22.Height = 0.188F;
			this.DedItemValue22.Left = 6.520501F;
			this.DedItemValue22.Name = "DedItemValue22";
			this.DedItemValue22.OutputFormat = "#,##0";
			this.DedItemValue22.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue22.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue22.Top = 5.063001F;
			this.DedItemValue22.Width = 0.68F;
			// 
			// DedItemName1
			// 
			this.DedItemName1.CanGrow = false;
			this.DedItemName1.DataField = "ITEM_NAME_31";
			this.DedItemName1.Height = 0.188F;
			this.DedItemName1.Left = 5.5F;
			this.DedItemName1.Name = "DedItemName1";
			this.DedItemName1.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName1.Text = "ああああああああ";
			this.DedItemName1.Top = 1.125F;
			this.DedItemName1.Width = 1.02F;
			// 
			// Label143
			// 
			this.Label143.Height = 0.188F;
			this.Label143.HyperLink = null;
			this.Label143.Left = 5.5F;
			this.Label143.Name = "Label143";
			this.Label143.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label143.Text = "控　除";
			this.Label143.Top = 0.9375F;
			this.Label143.Width = 1.7F;
			// 
			// DedItemValue1
			// 
			this.DedItemValue1.CanGrow = false;
			this.DedItemValue1.DataField = "ITEM_VALUE_31";
			this.DedItemValue1.Height = 0.188F;
			this.DedItemValue1.Left = 6.520501F;
			this.DedItemValue1.Name = "DedItemValue1";
			this.DedItemValue1.OutputFormat = "#,##0";
			this.DedItemValue1.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue1.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue1.Top = 1.125F;
			this.DedItemValue1.Width = 0.68F;
			// 
			// DedItemName21
			// 
			this.DedItemName21.CanGrow = false;
			this.DedItemName21.DataField = "ITEM_NAME_51";
			this.DedItemName21.Height = 0.188F;
			this.DedItemName21.Left = 5.5F;
			this.DedItemName21.Name = "DedItemName21";
			this.DedItemName21.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName21.Text = "ああああああああ";
			this.DedItemName21.Top = 4.875F;
			this.DedItemName21.Width = 1.02F;
			// 
			// RemitBankName1
			// 
			this.RemitBankName1.CanGrow = false;
			this.RemitBankName1.DataField = "REMIT_BANK_NAME_1";
			this.RemitBankName1.Height = 0.188F;
			this.RemitBankName1.Left = 7.438F;
			this.RemitBankName1.Name = "RemitBankName1";
			this.RemitBankName1.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBankName1.Text = "ああああああああ";
			this.RemitBankName1.Top = 3.5625F;
			this.RemitBankName1.Width = 1.1875F;
			// 
			// RemitBankName2
			// 
			this.RemitBankName2.CanGrow = false;
			this.RemitBankName2.DataField = "REMIT_BANK_NAME_2";
			this.RemitBankName2.Height = 0.188F;
			this.RemitBankName2.Left = 7.438F;
			this.RemitBankName2.Name = "RemitBankName2";
			this.RemitBankName2.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBankName2.Text = "ああああああああ";
			this.RemitBankName2.Top = 3.75F;
			this.RemitBankName2.Width = 1.1875F;
			// 
			// RemitBankName3
			// 
			this.RemitBankName3.CanGrow = false;
			this.RemitBankName3.DataField = "REMIT_BANK_NAME_3";
			this.RemitBankName3.Height = 0.188F;
			this.RemitBankName3.Left = 7.438F;
			this.RemitBankName3.Name = "RemitBankName3";
			this.RemitBankName3.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBankName3.Text = "ああああああああ";
			this.RemitBankName3.Top = 3.9375F;
			this.RemitBankName3.Width = 1.1875F;
			// 
			// RemitBranchName1
			// 
			this.RemitBranchName1.CanGrow = false;
			this.RemitBranchName1.DataField = "REMIT_BRANCH_NAME_1";
			this.RemitBranchName1.Height = 0.188F;
			this.RemitBranchName1.Left = 8.6875F;
			this.RemitBranchName1.Name = "RemitBranchName1";
			this.RemitBranchName1.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBranchName1.Text = "ああああああああ";
			this.RemitBranchName1.Top = 3.5625F;
			this.RemitBranchName1.Width = 1.25F;
			// 
			// RemitBranchName2
			// 
			this.RemitBranchName2.CanGrow = false;
			this.RemitBranchName2.DataField = "REMIT_BRANCH_NAME_2";
			this.RemitBranchName2.Height = 0.188F;
			this.RemitBranchName2.Left = 8.6875F;
			this.RemitBranchName2.Name = "RemitBranchName2";
			this.RemitBranchName2.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBranchName2.Text = "ああああああああ";
			this.RemitBranchName2.Top = 3.75F;
			this.RemitBranchName2.Width = 1.25F;
			// 
			// RemitBranchName3
			// 
			this.RemitBranchName3.CanGrow = false;
			this.RemitBranchName3.DataField = "REMIT_BRANCH_NAME_3";
			this.RemitBranchName3.Height = 0.188F;
			this.RemitBranchName3.Left = 8.6875F;
			this.RemitBranchName3.Name = "RemitBranchName3";
			this.RemitBranchName3.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.RemitBranchName3.Text = "ああああああああ";
			this.RemitBranchName3.Top = 3.9375F;
			this.RemitBranchName3.Width = 1.25F;
			// 
			// Remit1RemitAmt
			// 
			this.Remit1RemitAmt.CanGrow = false;
			this.Remit1RemitAmt.DataField = "REMIT_1_REMIT_AMT";
			this.Remit1RemitAmt.Height = 0.188F;
			this.Remit1RemitAmt.Left = 9.9375F;
			this.Remit1RemitAmt.Name = "Remit1RemitAmt";
			this.Remit1RemitAmt.OutputFormat = "#,##0";
			this.Remit1RemitAmt.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.Remit1RemitAmt.Text = "ZZ,ZZZ,ZZ6-";
			this.Remit1RemitAmt.Top = 3.5625F;
			this.Remit1RemitAmt.Width = 0.688F;
			// 
			// Remit2RemitAmt
			// 
			this.Remit2RemitAmt.CanGrow = false;
			this.Remit2RemitAmt.DataField = "REMIT_2_REMIT_AMT";
			this.Remit2RemitAmt.Height = 0.188F;
			this.Remit2RemitAmt.Left = 9.9375F;
			this.Remit2RemitAmt.Name = "Remit2RemitAmt";
			this.Remit2RemitAmt.OutputFormat = "#,##0";
			this.Remit2RemitAmt.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.Remit2RemitAmt.Text = "ZZ,ZZZ,ZZ6-";
			this.Remit2RemitAmt.Top = 3.75F;
			this.Remit2RemitAmt.Width = 0.688F;
			// 
			// Remit3RemitAmt
			// 
			this.Remit3RemitAmt.CanGrow = false;
			this.Remit3RemitAmt.DataField = "REMIT_3_REMIT_AMT";
			this.Remit3RemitAmt.Height = 0.188F;
			this.Remit3RemitAmt.Left = 9.9375F;
			this.Remit3RemitAmt.Name = "Remit3RemitAmt";
			this.Remit3RemitAmt.OutputFormat = "#,##0";
			this.Remit3RemitAmt.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.Remit3RemitAmt.Text = "ZZ,ZZZ,ZZ6-";
			this.Remit3RemitAmt.Top = 3.9375F;
			this.Remit3RemitAmt.Width = 0.688F;
			// 
			// CashPaymntAmtName
			// 
			this.CashPaymntAmtName.DataField = "ITEM_NAME_91";
			this.CashPaymntAmtName.Height = 0.188F;
			this.CashPaymntAmtName.HyperLink = null;
			this.CashPaymntAmtName.Left = 7.5F;
			this.CashPaymntAmtName.Name = "CashPaymntAmtName";
			this.CashPaymntAmtName.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.CashPaymntAmtName.Text = "現金支給額";
			this.CashPaymntAmtName.Top = 4.125F;
			this.CashPaymntAmtName.Width = 2.438F;
			// 
			// CashPaymntAmt
			// 
			this.CashPaymntAmt.CanGrow = false;
			this.CashPaymntAmt.DataField = "ITEM_VALUE_91";
			this.CashPaymntAmt.Height = 0.188F;
			this.CashPaymntAmt.Left = 9.9375F;
			this.CashPaymntAmt.Name = "CashPaymntAmt";
			this.CashPaymntAmt.OutputFormat = "#,##0";
			this.CashPaymntAmt.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.CashPaymntAmt.Text = "ZZ,ZZZ,ZZ6-";
			this.CashPaymntAmt.Top = 4.125F;
			this.CashPaymntAmt.Width = 0.688F;
			// 
			// MyCompName2
			// 
			this.MyCompName2.CanGrow = false;
			this.MyCompName2.DataField = "MYCOMP_NAME";
			this.MyCompName2.Height = 0.5F;
			this.MyCompName2.Left = 7.375F;
			this.MyCompName2.Name = "MyCompName2";
			this.MyCompName2.Style = "font-size: 9.75pt; text-align: right; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.MyCompName2.Text = "ああああああああああああああああああああああああああああああああああああああああああああああああああ";
			this.MyCompName2.Top = 7.25F;
			this.MyCompName2.Width = 3.25F;
			// 
			// Line364
			// 
			this.Line364.Height = 0F;
			this.Line364.Left = 3.75F;
			this.Line364.LineWeight = 1F;
			this.Line364.Name = "Line364";
			this.Line364.Top = 0.9375F;
			this.Line364.Width = 1.7005F;
			this.Line364.X1 = 3.75F;
			this.Line364.X2 = 5.4505F;
			this.Line364.Y1 = 0.9375F;
			this.Line364.Y2 = 0.9375F;
			// 
			// Line366
			// 
			this.Line366.Height = 0F;
			this.Line366.Left = 3.75F;
			this.Line366.LineWeight = 1F;
			this.Line366.Name = "Line366";
			this.Line366.Top = 1.3125F;
			this.Line366.Width = 1.7005F;
			this.Line366.X1 = 3.75F;
			this.Line366.X2 = 5.4505F;
			this.Line366.Y1 = 1.3125F;
			this.Line366.Y2 = 1.3125F;
			// 
			// Line367
			// 
			this.Line367.Height = 0F;
			this.Line367.Left = 3.75F;
			this.Line367.LineWeight = 1F;
			this.Line367.Name = "Line367";
			this.Line367.Top = 1.5F;
			this.Line367.Width = 1.7005F;
			this.Line367.X1 = 3.75F;
			this.Line367.X2 = 5.4505F;
			this.Line367.Y1 = 1.5F;
			this.Line367.Y2 = 1.5F;
			// 
			// Line368
			// 
			this.Line368.Height = 0F;
			this.Line368.Left = 3.75F;
			this.Line368.LineWeight = 1F;
			this.Line368.Name = "Line368";
			this.Line368.Top = 1.6875F;
			this.Line368.Width = 1.7005F;
			this.Line368.X1 = 3.75F;
			this.Line368.X2 = 5.4505F;
			this.Line368.Y1 = 1.6875F;
			this.Line368.Y2 = 1.6875F;
			// 
			// Line369
			// 
			this.Line369.Height = 0F;
			this.Line369.Left = 3.75F;
			this.Line369.LineWeight = 1F;
			this.Line369.Name = "Line369";
			this.Line369.Top = 2.0625F;
			this.Line369.Width = 1.7005F;
			this.Line369.X1 = 3.75F;
			this.Line369.X2 = 5.4505F;
			this.Line369.Y1 = 2.0625F;
			this.Line369.Y2 = 2.0625F;
			// 
			// Line370
			// 
			this.Line370.Height = 0F;
			this.Line370.Left = 3.75F;
			this.Line370.LineWeight = 1F;
			this.Line370.Name = "Line370";
			this.Line370.Top = 2.25F;
			this.Line370.Width = 1.7005F;
			this.Line370.X1 = 3.75F;
			this.Line370.X2 = 5.4505F;
			this.Line370.Y1 = 2.25F;
			this.Line370.Y2 = 2.25F;
			// 
			// Line371
			// 
			this.Line371.Height = 0F;
			this.Line371.Left = 3.75F;
			this.Line371.LineWeight = 1F;
			this.Line371.Name = "Line371";
			this.Line371.Top = 1.875F;
			this.Line371.Width = 1.7005F;
			this.Line371.X1 = 3.75F;
			this.Line371.X2 = 5.4505F;
			this.Line371.Y1 = 1.875F;
			this.Line371.Y2 = 1.875F;
			// 
			// Line372
			// 
			this.Line372.Height = 0F;
			this.Line372.Left = 3.75F;
			this.Line372.LineWeight = 1F;
			this.Line372.Name = "Line372";
			this.Line372.Top = 2.625F;
			this.Line372.Width = 1.7005F;
			this.Line372.X1 = 3.75F;
			this.Line372.X2 = 5.4505F;
			this.Line372.Y1 = 2.625F;
			this.Line372.Y2 = 2.625F;
			// 
			// Line373
			// 
			this.Line373.Height = 0F;
			this.Line373.Left = 3.75F;
			this.Line373.LineWeight = 1F;
			this.Line373.Name = "Line373";
			this.Line373.Top = 2.4375F;
			this.Line373.Width = 1.7005F;
			this.Line373.X1 = 3.75F;
			this.Line373.X2 = 5.4505F;
			this.Line373.Y1 = 2.4375F;
			this.Line373.Y2 = 2.4375F;
			// 
			// Line374
			// 
			this.Line374.Height = 0F;
			this.Line374.Left = 3.75F;
			this.Line374.LineWeight = 1F;
			this.Line374.Name = "Line374";
			this.Line374.Top = 2.8125F;
			this.Line374.Width = 1.7005F;
			this.Line374.X1 = 3.75F;
			this.Line374.X2 = 5.4505F;
			this.Line374.Y1 = 2.8125F;
			this.Line374.Y2 = 2.8125F;
			// 
			// Line375
			// 
			this.Line375.Height = 0F;
			this.Line375.Left = 3.75F;
			this.Line375.LineWeight = 1F;
			this.Line375.Name = "Line375";
			this.Line375.Top = 3F;
			this.Line375.Width = 1.7005F;
			this.Line375.X1 = 3.75F;
			this.Line375.X2 = 5.4505F;
			this.Line375.Y1 = 3F;
			this.Line375.Y2 = 3F;
			// 
			// Line376
			// 
			this.Line376.Height = 0F;
			this.Line376.Left = 3.75F;
			this.Line376.LineWeight = 1F;
			this.Line376.Name = "Line376";
			this.Line376.Top = 3.1875F;
			this.Line376.Width = 1.7005F;
			this.Line376.X1 = 3.75F;
			this.Line376.X2 = 5.4505F;
			this.Line376.Y1 = 3.1875F;
			this.Line376.Y2 = 3.1875F;
			// 
			// Line377
			// 
			this.Line377.Height = 0F;
			this.Line377.Left = 3.75F;
			this.Line377.LineWeight = 1F;
			this.Line377.Name = "Line377";
			this.Line377.Top = 3.375F;
			this.Line377.Width = 1.7005F;
			this.Line377.X1 = 3.75F;
			this.Line377.X2 = 5.4505F;
			this.Line377.Y1 = 3.375F;
			this.Line377.Y2 = 3.375F;
			// 
			// Line378
			// 
			this.Line378.Height = 0F;
			this.Line378.Left = 3.75F;
			this.Line378.LineWeight = 1F;
			this.Line378.Name = "Line378";
			this.Line378.Top = 3.5625F;
			this.Line378.Width = 1.7005F;
			this.Line378.X1 = 3.75F;
			this.Line378.X2 = 5.4505F;
			this.Line378.Y1 = 3.5625F;
			this.Line378.Y2 = 3.5625F;
			// 
			// Line379
			// 
			this.Line379.Height = 0F;
			this.Line379.Left = 3.75F;
			this.Line379.LineWeight = 1F;
			this.Line379.Name = "Line379";
			this.Line379.Top = 3.75F;
			this.Line379.Width = 1.7005F;
			this.Line379.X1 = 3.75F;
			this.Line379.X2 = 5.4505F;
			this.Line379.Y1 = 3.75F;
			this.Line379.Y2 = 3.75F;
			// 
			// Line380
			// 
			this.Line380.Height = 0F;
			this.Line380.Left = 3.75F;
			this.Line380.LineWeight = 1F;
			this.Line380.Name = "Line380";
			this.Line380.Top = 4.125F;
			this.Line380.Width = 1.7005F;
			this.Line380.X1 = 3.75F;
			this.Line380.X2 = 5.4505F;
			this.Line380.Y1 = 4.125F;
			this.Line380.Y2 = 4.125F;
			// 
			// Line381
			// 
			this.Line381.Height = 0F;
			this.Line381.Left = 3.75F;
			this.Line381.LineWeight = 1F;
			this.Line381.Name = "Line381";
			this.Line381.Top = 3.9375F;
			this.Line381.Width = 1.7005F;
			this.Line381.X1 = 3.75F;
			this.Line381.X2 = 5.4505F;
			this.Line381.Y1 = 3.9375F;
			this.Line381.Y2 = 3.9375F;
			// 
			// Line382
			// 
			this.Line382.Height = 0F;
			this.Line382.Left = 3.75F;
			this.Line382.LineWeight = 1F;
			this.Line382.Name = "Line382";
			this.Line382.Top = 4.3125F;
			this.Line382.Width = 1.7005F;
			this.Line382.X1 = 3.75F;
			this.Line382.X2 = 5.4505F;
			this.Line382.Y1 = 4.3125F;
			this.Line382.Y2 = 4.3125F;
			// 
			// Line383
			// 
			this.Line383.Height = 0F;
			this.Line383.Left = 3.75F;
			this.Line383.LineWeight = 1F;
			this.Line383.Name = "Line383";
			this.Line383.Top = 4.5F;
			this.Line383.Width = 1.7005F;
			this.Line383.X1 = 3.75F;
			this.Line383.X2 = 5.4505F;
			this.Line383.Y1 = 4.5F;
			this.Line383.Y2 = 4.5F;
			// 
			// Line384
			// 
			this.Line384.Height = 0F;
			this.Line384.Left = 3.75F;
			this.Line384.LineWeight = 1F;
			this.Line384.Name = "Line384";
			this.Line384.Top = 4.6875F;
			this.Line384.Width = 1.7005F;
			this.Line384.X1 = 3.75F;
			this.Line384.X2 = 5.4505F;
			this.Line384.Y1 = 4.6875F;
			this.Line384.Y2 = 4.6875F;
			// 
			// Line385
			// 
			this.Line385.Height = 0F;
			this.Line385.Left = 3.75F;
			this.Line385.LineWeight = 1F;
			this.Line385.Name = "Line385";
			this.Line385.Top = 4.875F;
			this.Line385.Width = 1.7005F;
			this.Line385.X1 = 3.75F;
			this.Line385.X2 = 5.4505F;
			this.Line385.Y1 = 4.875F;
			this.Line385.Y2 = 4.875F;
			// 
			// Line386
			// 
			this.Line386.Height = 0F;
			this.Line386.Left = 3.75F;
			this.Line386.LineWeight = 1F;
			this.Line386.Name = "Line386";
			this.Line386.Top = 5.0625F;
			this.Line386.Width = 1.7005F;
			this.Line386.X1 = 3.75F;
			this.Line386.X2 = 5.4505F;
			this.Line386.Y1 = 5.0625F;
			this.Line386.Y2 = 5.0625F;
			// 
			// Line387
			// 
			this.Line387.Height = 0F;
			this.Line387.Left = 3.75F;
			this.Line387.LineWeight = 1F;
			this.Line387.Name = "Line387";
			this.Line387.Top = 5.25F;
			this.Line387.Width = 1.7005F;
			this.Line387.X1 = 3.75F;
			this.Line387.X2 = 5.4505F;
			this.Line387.Y1 = 5.25F;
			this.Line387.Y2 = 5.25F;
			// 
			// Line388
			// 
			this.Line388.Height = 0F;
			this.Line388.Left = 3.75F;
			this.Line388.LineWeight = 1F;
			this.Line388.Name = "Line388";
			this.Line388.Top = 5.4375F;
			this.Line388.Width = 1.7005F;
			this.Line388.X1 = 3.75F;
			this.Line388.X2 = 5.4505F;
			this.Line388.Y1 = 5.4375F;
			this.Line388.Y2 = 5.4375F;
			// 
			// Line390
			// 
			this.Line390.Height = 0F;
			this.Line390.Left = 3.75F;
			this.Line390.LineWeight = 1F;
			this.Line390.Name = "Line390";
			this.Line390.Top = 5.8125F;
			this.Line390.Width = 1.7005F;
			this.Line390.X1 = 3.75F;
			this.Line390.X2 = 5.4505F;
			this.Line390.Y1 = 5.8125F;
			this.Line390.Y2 = 5.8125F;
			// 
			// Line392
			// 
			this.Line392.Height = 0F;
			this.Line392.Left = 5.5F;
			this.Line392.LineWeight = 1F;
			this.Line392.Name = "Line392";
			this.Line392.Top = 0.9375F;
			this.Line392.Width = 1.7F;
			this.Line392.X1 = 5.5F;
			this.Line392.X2 = 7.2F;
			this.Line392.Y1 = 0.9375F;
			this.Line392.Y2 = 0.9375F;
			// 
			// Line396
			// 
			this.Line396.Height = 0F;
			this.Line396.Left = 5.5F;
			this.Line396.LineWeight = 1F;
			this.Line396.Name = "Line396";
			this.Line396.Top = 1.3125F;
			this.Line396.Width = 1.7F;
			this.Line396.X1 = 5.5F;
			this.Line396.X2 = 7.2F;
			this.Line396.Y1 = 1.3125F;
			this.Line396.Y2 = 1.3125F;
			// 
			// Line397
			// 
			this.Line397.Height = 0F;
			this.Line397.Left = 5.5F;
			this.Line397.LineWeight = 1F;
			this.Line397.Name = "Line397";
			this.Line397.Top = 1.5F;
			this.Line397.Width = 1.7F;
			this.Line397.X1 = 5.5F;
			this.Line397.X2 = 7.2F;
			this.Line397.Y1 = 1.5F;
			this.Line397.Y2 = 1.5F;
			// 
			// Line398
			// 
			this.Line398.Height = 0F;
			this.Line398.Left = 5.5F;
			this.Line398.LineWeight = 1F;
			this.Line398.Name = "Line398";
			this.Line398.Top = 1.6875F;
			this.Line398.Width = 1.7F;
			this.Line398.X1 = 5.5F;
			this.Line398.X2 = 7.2F;
			this.Line398.Y1 = 1.6875F;
			this.Line398.Y2 = 1.6875F;
			// 
			// Line399
			// 
			this.Line399.Height = 0F;
			this.Line399.Left = 5.5F;
			this.Line399.LineWeight = 1F;
			this.Line399.Name = "Line399";
			this.Line399.Top = 1.875F;
			this.Line399.Width = 1.7F;
			this.Line399.X1 = 5.5F;
			this.Line399.X2 = 7.2F;
			this.Line399.Y1 = 1.875F;
			this.Line399.Y2 = 1.875F;
			// 
			// Line400
			// 
			this.Line400.Height = 0F;
			this.Line400.Left = 5.5F;
			this.Line400.LineWeight = 1F;
			this.Line400.Name = "Line400";
			this.Line400.Top = 2.0625F;
			this.Line400.Width = 1.7F;
			this.Line400.X1 = 5.5F;
			this.Line400.X2 = 7.2F;
			this.Line400.Y1 = 2.0625F;
			this.Line400.Y2 = 2.0625F;
			// 
			// Line401
			// 
			this.Line401.Height = 0F;
			this.Line401.Left = 5.5F;
			this.Line401.LineWeight = 1F;
			this.Line401.Name = "Line401";
			this.Line401.Top = 2.25F;
			this.Line401.Width = 1.7F;
			this.Line401.X1 = 5.5F;
			this.Line401.X2 = 7.2F;
			this.Line401.Y1 = 2.25F;
			this.Line401.Y2 = 2.25F;
			// 
			// Line402
			// 
			this.Line402.Height = 0F;
			this.Line402.Left = 5.5F;
			this.Line402.LineWeight = 1F;
			this.Line402.Name = "Line402";
			this.Line402.Top = 2.4375F;
			this.Line402.Width = 1.7F;
			this.Line402.X1 = 5.5F;
			this.Line402.X2 = 7.2F;
			this.Line402.Y1 = 2.4375F;
			this.Line402.Y2 = 2.4375F;
			// 
			// Line403
			// 
			this.Line403.Height = 0F;
			this.Line403.Left = 5.5F;
			this.Line403.LineWeight = 1F;
			this.Line403.Name = "Line403";
			this.Line403.Top = 2.625F;
			this.Line403.Width = 1.7F;
			this.Line403.X1 = 5.5F;
			this.Line403.X2 = 7.2F;
			this.Line403.Y1 = 2.625F;
			this.Line403.Y2 = 2.625F;
			// 
			// Line404
			// 
			this.Line404.Height = 0F;
			this.Line404.Left = 5.5F;
			this.Line404.LineWeight = 1F;
			this.Line404.Name = "Line404";
			this.Line404.Top = 2.8125F;
			this.Line404.Width = 1.7F;
			this.Line404.X1 = 5.5F;
			this.Line404.X2 = 7.2F;
			this.Line404.Y1 = 2.8125F;
			this.Line404.Y2 = 2.8125F;
			// 
			// Line405
			// 
			this.Line405.Height = 0F;
			this.Line405.Left = 5.5F;
			this.Line405.LineWeight = 1F;
			this.Line405.Name = "Line405";
			this.Line405.Top = 3F;
			this.Line405.Width = 1.7F;
			this.Line405.X1 = 5.5F;
			this.Line405.X2 = 7.2F;
			this.Line405.Y1 = 3F;
			this.Line405.Y2 = 3F;
			// 
			// Line406
			// 
			this.Line406.Height = 0F;
			this.Line406.Left = 5.5F;
			this.Line406.LineWeight = 1F;
			this.Line406.Name = "Line406";
			this.Line406.Top = 3.1875F;
			this.Line406.Width = 1.7F;
			this.Line406.X1 = 5.5F;
			this.Line406.X2 = 7.2F;
			this.Line406.Y1 = 3.1875F;
			this.Line406.Y2 = 3.1875F;
			// 
			// Line407
			// 
			this.Line407.Height = 0F;
			this.Line407.Left = 5.5F;
			this.Line407.LineWeight = 1F;
			this.Line407.Name = "Line407";
			this.Line407.Top = 3.375F;
			this.Line407.Width = 1.7F;
			this.Line407.X1 = 5.5F;
			this.Line407.X2 = 7.2F;
			this.Line407.Y1 = 3.375F;
			this.Line407.Y2 = 3.375F;
			// 
			// Line408
			// 
			this.Line408.Height = 0F;
			this.Line408.Left = 5.5F;
			this.Line408.LineWeight = 1F;
			this.Line408.Name = "Line408";
			this.Line408.Top = 3.5625F;
			this.Line408.Width = 1.7F;
			this.Line408.X1 = 5.5F;
			this.Line408.X2 = 7.2F;
			this.Line408.Y1 = 3.5625F;
			this.Line408.Y2 = 3.5625F;
			// 
			// Line409
			// 
			this.Line409.Height = 0F;
			this.Line409.Left = 5.5F;
			this.Line409.LineWeight = 1F;
			this.Line409.Name = "Line409";
			this.Line409.Top = 3.75F;
			this.Line409.Width = 1.7F;
			this.Line409.X1 = 5.5F;
			this.Line409.X2 = 7.2F;
			this.Line409.Y1 = 3.75F;
			this.Line409.Y2 = 3.75F;
			// 
			// Line410
			// 
			this.Line410.Height = 0F;
			this.Line410.Left = 5.5F;
			this.Line410.LineWeight = 1F;
			this.Line410.Name = "Line410";
			this.Line410.Top = 3.9375F;
			this.Line410.Width = 1.7F;
			this.Line410.X1 = 5.5F;
			this.Line410.X2 = 7.2F;
			this.Line410.Y1 = 3.9375F;
			this.Line410.Y2 = 3.9375F;
			// 
			// Line411
			// 
			this.Line411.Height = 0F;
			this.Line411.Left = 5.5F;
			this.Line411.LineWeight = 1F;
			this.Line411.Name = "Line411";
			this.Line411.Top = 4.125F;
			this.Line411.Width = 1.7F;
			this.Line411.X1 = 5.5F;
			this.Line411.X2 = 7.2F;
			this.Line411.Y1 = 4.125F;
			this.Line411.Y2 = 4.125F;
			// 
			// Line412
			// 
			this.Line412.Height = 0F;
			this.Line412.Left = 5.5F;
			this.Line412.LineWeight = 1F;
			this.Line412.Name = "Line412";
			this.Line412.Top = 4.3125F;
			this.Line412.Width = 1.7F;
			this.Line412.X1 = 5.5F;
			this.Line412.X2 = 7.2F;
			this.Line412.Y1 = 4.3125F;
			this.Line412.Y2 = 4.3125F;
			// 
			// Line413
			// 
			this.Line413.Height = 0F;
			this.Line413.Left = 5.5F;
			this.Line413.LineWeight = 1F;
			this.Line413.Name = "Line413";
			this.Line413.Top = 4.5F;
			this.Line413.Width = 1.7F;
			this.Line413.X1 = 5.5F;
			this.Line413.X2 = 7.2F;
			this.Line413.Y1 = 4.5F;
			this.Line413.Y2 = 4.5F;
			// 
			// Line414
			// 
			this.Line414.Height = 0F;
			this.Line414.Left = 5.5F;
			this.Line414.LineWeight = 1F;
			this.Line414.Name = "Line414";
			this.Line414.Top = 4.6875F;
			this.Line414.Width = 1.7F;
			this.Line414.X1 = 5.5F;
			this.Line414.X2 = 7.2F;
			this.Line414.Y1 = 4.6875F;
			this.Line414.Y2 = 4.6875F;
			// 
			// Line415
			// 
			this.Line415.Height = 0F;
			this.Line415.Left = 5.5F;
			this.Line415.LineWeight = 1F;
			this.Line415.Name = "Line415";
			this.Line415.Top = 4.875F;
			this.Line415.Width = 1.7F;
			this.Line415.X1 = 5.5F;
			this.Line415.X2 = 7.2F;
			this.Line415.Y1 = 4.875F;
			this.Line415.Y2 = 4.875F;
			// 
			// Line418
			// 
			this.Line418.Height = 0F;
			this.Line418.Left = 5.5F;
			this.Line418.LineWeight = 1F;
			this.Line418.Name = "Line418";
			this.Line418.Top = 5.4375F;
			this.Line418.Width = 1.7F;
			this.Line418.X1 = 5.5F;
			this.Line418.X2 = 7.2F;
			this.Line418.Y1 = 5.4375F;
			this.Line418.Y2 = 5.4375F;
			// 
			// Line419
			// 
			this.Line419.Height = 0F;
			this.Line419.Left = 5.5F;
			this.Line419.LineWeight = 1F;
			this.Line419.Name = "Line419";
			this.Line419.Top = 5.625F;
			this.Line419.Width = 1.7F;
			this.Line419.X1 = 5.5F;
			this.Line419.X2 = 7.2F;
			this.Line419.Y1 = 5.625F;
			this.Line419.Y2 = 5.625F;
			// 
			// Line420
			// 
			this.Line420.Height = 0F;
			this.Line420.Left = 5.5F;
			this.Line420.LineWeight = 1F;
			this.Line420.Name = "Line420";
			this.Line420.Top = 1.125F;
			this.Line420.Width = 1.7F;
			this.Line420.X1 = 5.5F;
			this.Line420.X2 = 7.2F;
			this.Line420.Y1 = 1.125F;
			this.Line420.Y2 = 1.125F;
			// 
			// Line421
			// 
			this.Line421.Height = 0F;
			this.Line421.Left = 7.438F;
			this.Line421.LineWeight = 1F;
			this.Line421.Name = "Line421";
			this.Line421.Top = 0.9375F;
			this.Line421.Width = 3.187F;
			this.Line421.X1 = 7.438F;
			this.Line421.X2 = 10.625F;
			this.Line421.Y1 = 0.9375F;
			this.Line421.Y2 = 0.9375F;
			// 
			// Line422
			// 
			this.Line422.Height = 0F;
			this.Line422.Left = 7.438F;
			this.Line422.LineWeight = 1F;
			this.Line422.Name = "Line422";
			this.Line422.Top = 1.125F;
			this.Line422.Width = 3.187F;
			this.Line422.X1 = 7.438F;
			this.Line422.X2 = 10.625F;
			this.Line422.Y1 = 1.125F;
			this.Line422.Y2 = 1.125F;
			// 
			// Line423
			// 
			this.Line423.Height = 0F;
			this.Line423.Left = 7.438F;
			this.Line423.LineWeight = 1F;
			this.Line423.Name = "Line423";
			this.Line423.Top = 1.3125F;
			this.Line423.Width = 3.187F;
			this.Line423.X1 = 7.438F;
			this.Line423.X2 = 10.625F;
			this.Line423.Y1 = 1.3125F;
			this.Line423.Y2 = 1.3125F;
			// 
			// Line424
			// 
			this.Line424.Height = 0F;
			this.Line424.Left = 7.438F;
			this.Line424.LineWeight = 1F;
			this.Line424.Name = "Line424";
			this.Line424.Top = 1.5F;
			this.Line424.Width = 3.187F;
			this.Line424.X1 = 7.438F;
			this.Line424.X2 = 10.625F;
			this.Line424.Y1 = 1.5F;
			this.Line424.Y2 = 1.5F;
			// 
			// Line425
			// 
			this.Line425.Height = 0F;
			this.Line425.Left = 7.438F;
			this.Line425.LineWeight = 1F;
			this.Line425.Name = "Line425";
			this.Line425.Top = 1.6875F;
			this.Line425.Width = 3.187F;
			this.Line425.X1 = 7.438F;
			this.Line425.X2 = 10.625F;
			this.Line425.Y1 = 1.6875F;
			this.Line425.Y2 = 1.6875F;
			// 
			// Line426
			// 
			this.Line426.Height = 0F;
			this.Line426.Left = 7.438F;
			this.Line426.LineWeight = 1F;
			this.Line426.Name = "Line426";
			this.Line426.Top = 1.875F;
			this.Line426.Width = 3.187F;
			this.Line426.X1 = 7.438F;
			this.Line426.X2 = 10.625F;
			this.Line426.Y1 = 1.875F;
			this.Line426.Y2 = 1.875F;
			// 
			// Line427
			// 
			this.Line427.Height = 0F;
			this.Line427.Left = 7.438F;
			this.Line427.LineWeight = 1F;
			this.Line427.Name = "Line427";
			this.Line427.Top = 2.0625F;
			this.Line427.Width = 3.187F;
			this.Line427.X1 = 7.438F;
			this.Line427.X2 = 10.625F;
			this.Line427.Y1 = 2.0625F;
			this.Line427.Y2 = 2.0625F;
			// 
			// Line428
			// 
			this.Line428.Height = 0F;
			this.Line428.Left = 7.438F;
			this.Line428.LineWeight = 1F;
			this.Line428.Name = "Line428";
			this.Line428.Top = 2.25F;
			this.Line428.Width = 3.187F;
			this.Line428.X1 = 7.438F;
			this.Line428.X2 = 10.625F;
			this.Line428.Y1 = 2.25F;
			this.Line428.Y2 = 2.25F;
			// 
			// Line429
			// 
			this.Line429.Height = 0F;
			this.Line429.Left = 7.438F;
			this.Line429.LineWeight = 1F;
			this.Line429.Name = "Line429";
			this.Line429.Top = 2.4375F;
			this.Line429.Width = 3.187F;
			this.Line429.X1 = 7.438F;
			this.Line429.X2 = 10.625F;
			this.Line429.Y1 = 2.4375F;
			this.Line429.Y2 = 2.4375F;
			// 
			// Line430
			// 
			this.Line430.Height = 0F;
			this.Line430.Left = 7.438F;
			this.Line430.LineWeight = 1F;
			this.Line430.Name = "Line430";
			this.Line430.Top = 2.625F;
			this.Line430.Width = 3.187F;
			this.Line430.X1 = 7.438F;
			this.Line430.X2 = 10.625F;
			this.Line430.Y1 = 2.625F;
			this.Line430.Y2 = 2.625F;
			// 
			// Line431
			// 
			this.Line431.Height = 0F;
			this.Line431.Left = 7.438F;
			this.Line431.LineWeight = 1F;
			this.Line431.Name = "Line431";
			this.Line431.Top = 2.8125F;
			this.Line431.Width = 3.187F;
			this.Line431.X1 = 7.438F;
			this.Line431.X2 = 10.625F;
			this.Line431.Y1 = 2.8125F;
			this.Line431.Y2 = 2.8125F;
			// 
			// Line432
			// 
			this.Line432.Height = 0F;
			this.Line432.Left = 7.438F;
			this.Line432.LineWeight = 1F;
			this.Line432.Name = "Line432";
			this.Line432.Top = 3.0065F;
			this.Line432.Width = 3.187F;
			this.Line432.X1 = 7.438F;
			this.Line432.X2 = 10.625F;
			this.Line432.Y1 = 3.0065F;
			this.Line432.Y2 = 3.0065F;
			// 
			// Line433
			// 
			this.Line433.Height = 0F;
			this.Line433.Left = 7.438F;
			this.Line433.LineWeight = 1F;
			this.Line433.Name = "Line433";
			this.Line433.Top = 3.5695F;
			this.Line433.Width = 3.187F;
			this.Line433.X1 = 7.438F;
			this.Line433.X2 = 10.625F;
			this.Line433.Y1 = 3.5695F;
			this.Line433.Y2 = 3.5695F;
			// 
			// Line434
			// 
			this.Line434.Height = 0F;
			this.Line434.Left = 7.438F;
			this.Line434.LineWeight = 1F;
			this.Line434.Name = "Line434";
			this.Line434.Top = 3.7565F;
			this.Line434.Width = 3.187F;
			this.Line434.X1 = 7.438F;
			this.Line434.X2 = 10.625F;
			this.Line434.Y1 = 3.7565F;
			this.Line434.Y2 = 3.7565F;
			// 
			// Line435
			// 
			this.Line435.Height = 0F;
			this.Line435.Left = 7.438F;
			this.Line435.LineWeight = 1F;
			this.Line435.Name = "Line435";
			this.Line435.Top = 3.9445F;
			this.Line435.Width = 3.187F;
			this.Line435.X1 = 7.438F;
			this.Line435.X2 = 10.625F;
			this.Line435.Y1 = 3.9445F;
			this.Line435.Y2 = 3.9445F;
			// 
			// Line436
			// 
			this.Line436.Height = 0F;
			this.Line436.Left = 7.438F;
			this.Line436.LineWeight = 1F;
			this.Line436.Name = "Line436";
			this.Line436.Top = 4.1315F;
			this.Line436.Width = 3.187F;
			this.Line436.X1 = 7.438F;
			this.Line436.X2 = 10.625F;
			this.Line436.Y1 = 4.1315F;
			this.Line436.Y2 = 4.1315F;
			// 
			// Line439
			// 
			this.Line439.Height = 0F;
			this.Line439.Left = 7.438F;
			this.Line439.LineWeight = 1F;
			this.Line439.Name = "Line439";
			this.Line439.Top = 4.3125F;
			this.Line439.Width = 3.187F;
			this.Line439.X1 = 7.438F;
			this.Line439.X2 = 10.625F;
			this.Line439.Y1 = 4.3125F;
			this.Line439.Y2 = 4.3125F;
			// 
			// Line444
			// 
			this.Line444.Height = 0F;
			this.Line444.Left = 7.438F;
			this.Line444.LineWeight = 1F;
			this.Line444.Name = "Line444";
			this.Line444.Top = 4.4375F;
			this.Line444.Width = 3.187F;
			this.Line444.X1 = 7.438F;
			this.Line444.X2 = 10.625F;
			this.Line444.Y1 = 4.4375F;
			this.Line444.Y2 = 4.4375F;
			// 
			// Line445
			// 
			this.Line445.Height = 0F;
			this.Line445.Left = 7.438F;
			this.Line445.LineWeight = 1F;
			this.Line445.Name = "Line445";
			this.Line445.Top = 6.938001F;
			this.Line445.Width = 3.187F;
			this.Line445.X1 = 7.438F;
			this.Line445.X2 = 10.625F;
			this.Line445.Y1 = 6.938001F;
			this.Line445.Y2 = 6.938001F;
			// 
			// Line447
			// 
			this.Line447.Height = 2.500001F;
			this.Line447.Left = 7.438F;
			this.Line447.LineWeight = 1F;
			this.Line447.Name = "Line447";
			this.Line447.Top = 4.438F;
			this.Line447.Width = 0F;
			this.Line447.X1 = 7.438F;
			this.Line447.X2 = 7.438F;
			this.Line447.Y1 = 4.438F;
			this.Line447.Y2 = 6.938001F;
			// 
			// Line448
			// 
			this.Line448.Height = 2.5F;
			this.Line448.Left = 10.625F;
			this.Line448.LineWeight = 1F;
			this.Line448.Name = "Line448";
			this.Line448.Top = 4.4375F;
			this.Line448.Width = 0F;
			this.Line448.X1 = 10.625F;
			this.Line448.X2 = 10.625F;
			this.Line448.Y1 = 4.4375F;
			this.Line448.Y2 = 6.9375F;
			// 
			// SlryItemValue26
			// 
			this.SlryItemValue26.CanGrow = false;
			this.SlryItemValue26.DataField = "ITEM_VALUE_26";
			this.SlryItemValue26.Height = 0.188F;
			this.SlryItemValue26.Left = 4.770501F;
			this.SlryItemValue26.Name = "SlryItemValue26";
			this.SlryItemValue26.OutputFormat = "#,##0";
			this.SlryItemValue26.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue26.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue26.Top = 5.814F;
			this.SlryItemValue26.Width = 0.68F;
			// 
			// Line451
			// 
			this.Line451.Height = 0F;
			this.Line451.Left = 5.5F;
			this.Line451.LineWeight = 1F;
			this.Line451.Name = "Line451";
			this.Line451.Top = 6F;
			this.Line451.Width = 1.7F;
			this.Line451.X1 = 5.5F;
			this.Line451.X2 = 7.2F;
			this.Line451.Y1 = 6F;
			this.Line451.Y2 = 6F;
			// 
			// SlryItemName25
			// 
			this.SlryItemName25.CanGrow = false;
			this.SlryItemName25.DataField = "ITEM_NAME_25";
			this.SlryItemName25.Height = 0.188F;
			this.SlryItemName25.Left = 3.75F;
			this.SlryItemName25.Name = "SlryItemName25";
			this.SlryItemName25.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName25.Text = "ああああああああ";
			this.SlryItemName25.Top = 5.625501F;
			this.SlryItemName25.Width = 1.02F;
			// 
			// DedItemName22
			// 
			this.DedItemName22.CanGrow = false;
			this.DedItemName22.DataField = "ITEM_NAME_52";
			this.DedItemName22.Height = 0.188F;
			this.DedItemName22.Left = 5.5F;
			this.DedItemName22.Name = "DedItemName22";
			this.DedItemName22.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName22.Text = "ああああああああ";
			this.DedItemName22.Top = 5.0625F;
			this.DedItemName22.Width = 1.02F;
			// 
			// SlryPaymntMonth2
			// 
			this.SlryPaymntMonth2.CanGrow = false;
			this.SlryPaymntMonth2.DataField = "SLRY_PAYMNT_MONTH";
			this.SlryPaymntMonth2.Height = 0.1875F;
			this.SlryPaymntMonth2.Left = 4.3125F;
			this.SlryPaymntMonth2.Name = "SlryPaymntMonth2";
			this.SlryPaymntMonth2.Style = "font-size: 9.75pt; text-align: left; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 128";
			this.SlryPaymntMonth2.Text = "00月度";
			this.SlryPaymntMonth2.Top = 0.375F;
			this.SlryPaymntMonth2.Width = 0.4375F;
			// 
			// Line391
			// 
			this.Line391.Height = 5.062F;
			this.Line391.Left = 5.5F;
			this.Line391.LineWeight = 1F;
			this.Line391.Name = "Line391";
			this.Line391.Top = 0.938F;
			this.Line391.Width = 0F;
			this.Line391.X1 = 5.5F;
			this.Line391.X2 = 5.5F;
			this.Line391.Y1 = 0.938F;
			this.Line391.Y2 = 6F;
			// 
			// Line395
			// 
			this.Line395.Height = 4.875F;
			this.Line395.Left = 6.520501F;
			this.Line395.LineWeight = 1F;
			this.Line395.Name = "Line395";
			this.Line395.Top = 1.125F;
			this.Line395.Width = 0F;
			this.Line395.X1 = 6.520501F;
			this.Line395.X2 = 6.520501F;
			this.Line395.Y1 = 1.125F;
			this.Line395.Y2 = 6F;
			// 
			// Line393
			// 
			this.Line393.Height = 5.062F;
			this.Line393.Left = 7.2F;
			this.Line393.LineWeight = 1F;
			this.Line393.Name = "Line393";
			this.Line393.Top = 0.938F;
			this.Line393.Width = 0F;
			this.Line393.X1 = 7.2F;
			this.Line393.X2 = 7.2F;
			this.Line393.Y1 = 0.938F;
			this.Line393.Y2 = 6F;
			// 
			// Line452
			// 
			this.Line452.Height = 0.3125F;
			this.Line452.Left = 3.3575F;
			this.Line452.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line452.LineWeight = 1F;
			this.Line452.Name = "Line452";
			this.Line452.Top = 0F;
			this.Line452.Width = 0F;
			this.Line452.X1 = 3.3575F;
			this.Line452.X2 = 3.3575F;
			this.Line452.Y1 = 0F;
			this.Line452.Y2 = 0.3125F;
			// 
			// Line455
			// 
			this.Line455.Height = 0.2499995F;
			this.Line455.Left = 3.358F;
			this.Line455.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line455.LineWeight = 1F;
			this.Line455.Name = "Line455";
			this.Line455.Top = 7.938F;
			this.Line455.Width = 0F;
			this.Line455.X1 = 3.358F;
			this.Line455.X2 = 3.358F;
			this.Line455.Y1 = 7.938F;
			this.Line455.Y2 = 8.188F;
			// 
			// Line456
			// 
			this.Line456.Height = 0F;
			this.Line456.Left = 7.438F;
			this.Line456.LineWeight = 1F;
			this.Line456.Name = "Line456";
			this.Line456.Top = 3.3815F;
			this.Line456.Width = 3.187F;
			this.Line456.X1 = 7.438F;
			this.Line456.X2 = 10.625F;
			this.Line456.Y1 = 3.3815F;
			this.Line456.Y2 = 3.3815F;
			// 
			// Line457
			// 
			this.Line457.Height = 0F;
			this.Line457.Left = 7.438F;
			this.Line457.LineWeight = 1F;
			this.Line457.Name = "Line457";
			this.Line457.Top = 3.1945F;
			this.Line457.Width = 3.187F;
			this.Line457.X1 = 7.438F;
			this.Line457.X2 = 10.625F;
			this.Line457.Y1 = 3.1945F;
			this.Line457.Y2 = 3.1945F;
			// 
			// PaySlipComment
			// 
			this.PaySlipComment.CanGrow = false;
			this.PaySlipComment.DataField = "PAYSLIP_COMMENT";
			this.PaySlipComment.Height = 0.75F;
			this.PaySlipComment.Left = 7.657F;
			this.PaySlipComment.Name = "PaySlipComment";
			this.PaySlipComment.Style = "font-size: 9.75pt; text-align: left; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 1";
			this.PaySlipComment.Text = "　";
			this.PaySlipComment.Top = 4.625F;
			this.PaySlipComment.Width = 2.75F;
			// 
			// SlryItemName26
			// 
			this.SlryItemName26.CanGrow = false;
			this.SlryItemName26.DataField = "ITEM_NAME_26";
			this.SlryItemName26.Height = 0.188F;
			this.SlryItemName26.Left = 3.75F;
			this.SlryItemName26.Name = "SlryItemName26";
			this.SlryItemName26.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName26.Text = "ああああああああ";
			this.SlryItemName26.Top = 5.8125F;
			this.SlryItemName26.Width = 1.02F;
			// 
			// Line354
			// 
			this.Line354.Height = 5.062F;
			this.Line354.Left = 3.75F;
			this.Line354.LineWeight = 1F;
			this.Line354.Name = "Line354";
			this.Line354.Top = 0.938F;
			this.Line354.Width = 0F;
			this.Line354.X1 = 3.75F;
			this.Line354.X2 = 3.75F;
			this.Line354.Y1 = 0.938F;
			this.Line354.Y2 = 6F;
			// 
			// Line450
			// 
			this.Line450.Height = 0F;
			this.Line450.Left = 3.75F;
			this.Line450.LineWeight = 1F;
			this.Line450.Name = "Line450";
			this.Line450.Top = 6.002F;
			this.Line450.Width = 1.7005F;
			this.Line450.X1 = 3.75F;
			this.Line450.X2 = 5.4505F;
			this.Line450.Y1 = 6.002F;
			this.Line450.Y2 = 6.002F;
			// 
			// Line363
			// 
			this.Line363.Height = 5.062F;
			this.Line363.Left = 5.4505F;
			this.Line363.LineWeight = 1F;
			this.Line363.Name = "Line363";
			this.Line363.Top = 0.938F;
			this.Line363.Width = 0F;
			this.Line363.X1 = 5.4505F;
			this.Line363.X2 = 5.4505F;
			this.Line363.Y1 = 0.938F;
			this.Line363.Y2 = 6F;
			// 
			// Line449
			// 
			this.Line449.Height = 0F;
			this.Line449.Left = 3.75F;
			this.Line449.LineWeight = 1F;
			this.Line449.Name = "Line449";
			this.Line449.Top = 5.814F;
			this.Line449.Width = 1.7005F;
			this.Line449.X1 = 3.75F;
			this.Line449.X2 = 5.4505F;
			this.Line449.Y1 = 5.814F;
			this.Line449.Y2 = 5.814F;
			// 
			// Line389
			// 
			this.Line389.Height = 0F;
			this.Line389.Left = 3.75F;
			this.Line389.LineWeight = 1F;
			this.Line389.Name = "Line389";
			this.Line389.Top = 5.625999F;
			this.Line389.Width = 1.7005F;
			this.Line389.X1 = 3.75F;
			this.Line389.X2 = 5.4505F;
			this.Line389.Y1 = 5.625999F;
			this.Line389.Y2 = 5.625999F;
			// 
			// Line394
			// 
			this.Line394.Height = 0F;
			this.Line394.Left = 5.5F;
			this.Line394.LineWeight = 1F;
			this.Line394.Name = "Line394";
			this.Line394.Top = 5.8125F;
			this.Line394.Width = 1.7F;
			this.Line394.X1 = 5.5F;
			this.Line394.X2 = 7.2F;
			this.Line394.Y1 = 5.8125F;
			this.Line394.Y2 = 5.8125F;
			// 
			// Line417
			// 
			this.Line417.Height = 0F;
			this.Line417.Left = 5.5F;
			this.Line417.LineWeight = 1F;
			this.Line417.Name = "Line417";
			this.Line417.Top = 5.25F;
			this.Line417.Width = 1.7F;
			this.Line417.X1 = 5.5F;
			this.Line417.X2 = 7.2F;
			this.Line417.Y1 = 5.25F;
			this.Line417.Y2 = 5.25F;
			// 
			// Line284
			// 
			this.Line284.Height = 0F;
			this.Line284.Left = 3.75F;
			this.Line284.LineWeight = 1F;
			this.Line284.Name = "Line284";
			this.Line284.Top = 1.125F;
			this.Line284.Width = 1.7005F;
			this.Line284.X1 = 3.75F;
			this.Line284.X2 = 5.4505F;
			this.Line284.Y1 = 1.125F;
			this.Line284.Y2 = 1.125F;
			// 
			// Line416
			// 
			this.Line416.Height = 0F;
			this.Line416.Left = 5.5F;
			this.Line416.LineWeight = 1F;
			this.Line416.Name = "Line416";
			this.Line416.Top = 5.0625F;
			this.Line416.Width = 1.7F;
			this.Line416.X1 = 5.5F;
			this.Line416.X2 = 7.2F;
			this.Line416.Y1 = 5.0625F;
			this.Line416.Y2 = 5.0625F;
			// 
			// Line355
			// 
			this.Line355.Height = 4.875F;
			this.Line355.Left = 4.770501F;
			this.Line355.LineWeight = 1F;
			this.Line355.Name = "Line355";
			this.Line355.Top = 1.125F;
			this.Line355.Width = 0F;
			this.Line355.X1 = 4.770501F;
			this.Line355.X2 = 4.770501F;
			this.Line355.Y1 = 1.125F;
			this.Line355.Y2 = 6F;
			// 
			// SlryItemName28
			// 
			this.SlryItemName28.CanGrow = false;
			this.SlryItemName28.DataField = "ITEM_NAME_28";
			this.SlryItemName28.Height = 0.188F;
			this.SlryItemName28.Left = 3.75F;
			this.SlryItemName28.Name = "SlryItemName28";
			this.SlryItemName28.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName28.Text = "ああああああああ";
			this.SlryItemName28.Top = 6.375F;
			this.SlryItemName28.Width = 1.02F;
			// 
			// SlryItemValue28
			// 
			this.SlryItemValue28.CanGrow = false;
			this.SlryItemValue28.DataField = "ITEM_VALUE_28";
			this.SlryItemValue28.Height = 0.188F;
			this.SlryItemValue28.Left = 4.770501F;
			this.SlryItemValue28.Name = "SlryItemValue28";
			this.SlryItemValue28.OutputFormat = "#,##0";
			this.SlryItemValue28.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue28.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue28.Top = 6.3765F;
			this.SlryItemValue28.Width = 0.68F;
			// 
			// SlryItemName27
			// 
			this.SlryItemName27.CanGrow = false;
			this.SlryItemName27.DataField = "ITEM_NAME_27";
			this.SlryItemName27.Height = 0.188F;
			this.SlryItemName27.Left = 3.75F;
			this.SlryItemName27.Name = "SlryItemName27";
			this.SlryItemName27.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName27.Text = "ああああああああ";
			this.SlryItemName27.Top = 6.1875F;
			this.SlryItemName27.Width = 1.02F;
			// 
			// SlryItemValue27
			// 
			this.SlryItemValue27.CanGrow = false;
			this.SlryItemValue27.DataField = "ITEM_VALUE_27";
			this.SlryItemValue27.Height = 0.188F;
			this.SlryItemValue27.Left = 4.770501F;
			this.SlryItemValue27.Name = "SlryItemValue27";
			this.SlryItemValue27.OutputFormat = "#,##0";
			this.SlryItemValue27.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue27.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue27.Top = 6.189F;
			this.SlryItemValue27.Width = 0.68F;
			// 
			// SlryItemName30
			// 
			this.SlryItemName30.CanGrow = false;
			this.SlryItemName30.DataField = "ITEM_NAME_30";
			this.SlryItemName30.Height = 0.188F;
			this.SlryItemName30.Left = 3.75F;
			this.SlryItemName30.Name = "SlryItemName30";
			this.SlryItemName30.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName30.Text = "ああああああああ";
			this.SlryItemName30.Top = 6.75F;
			this.SlryItemName30.Width = 1.02F;
			// 
			// SlryItemValue30
			// 
			this.SlryItemValue30.CanGrow = false;
			this.SlryItemValue30.DataField = "ITEM_VALUE_30";
			this.SlryItemValue30.Height = 0.188F;
			this.SlryItemValue30.Left = 4.770501F;
			this.SlryItemValue30.Name = "SlryItemValue30";
			this.SlryItemValue30.OutputFormat = "#,##0";
			this.SlryItemValue30.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue30.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue30.Top = 6.7515F;
			this.SlryItemValue30.Width = 0.68F;
			// 
			// SlryItemName29
			// 
			this.SlryItemName29.CanGrow = false;
			this.SlryItemName29.DataField = "ITEM_NAME_29";
			this.SlryItemName29.Height = 0.188F;
			this.SlryItemName29.Left = 3.75F;
			this.SlryItemName29.Name = "SlryItemName29";
			this.SlryItemName29.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SlryItemName29.Text = "ああああああああ";
			this.SlryItemName29.Top = 6.5625F;
			this.SlryItemName29.Width = 1.02F;
			// 
			// SlryItemValue29
			// 
			this.SlryItemValue29.CanGrow = false;
			this.SlryItemValue29.DataField = "ITEM_VALUE_29";
			this.SlryItemValue29.Height = 0.188F;
			this.SlryItemValue29.Left = 4.770501F;
			this.SlryItemValue29.Name = "SlryItemValue29";
			this.SlryItemValue29.OutputFormat = "#,##0";
			this.SlryItemValue29.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.SlryItemValue29.Text = "ZZ,ZZZ,ZZ6-";
			this.SlryItemValue29.Top = 6.564F;
			this.SlryItemValue29.Width = 0.68F;
			// 
			// DedItemName27
			// 
			this.DedItemName27.CanGrow = false;
			this.DedItemName27.DataField = "ITEM_NAME_57";
			this.DedItemName27.Height = 0.188F;
			this.DedItemName27.Left = 5.5F;
			this.DedItemName27.Name = "DedItemName27";
			this.DedItemName27.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName27.Text = "ああああああああ";
			this.DedItemName27.Top = 6.1875F;
			this.DedItemName27.Width = 1.02F;
			// 
			// DedItemValue27
			// 
			this.DedItemValue27.CanGrow = false;
			this.DedItemValue27.DataField = "ITEM_VALUE_57";
			this.DedItemValue27.Height = 0.188F;
			this.DedItemValue27.Left = 6.520501F;
			this.DedItemValue27.Name = "DedItemValue27";
			this.DedItemValue27.OutputFormat = "#,##0";
			this.DedItemValue27.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue27.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue27.Top = 6.188502F;
			this.DedItemValue27.Width = 0.68F;
			// 
			// DedItemName28
			// 
			this.DedItemName28.CanGrow = false;
			this.DedItemName28.DataField = "ITEM_NAME_58";
			this.DedItemName28.Height = 0.188F;
			this.DedItemName28.Left = 5.5F;
			this.DedItemName28.Name = "DedItemName28";
			this.DedItemName28.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName28.Text = "ああああああああ";
			this.DedItemName28.Top = 6.375F;
			this.DedItemName28.Width = 1.02F;
			// 
			// DedItemValue28
			// 
			this.DedItemValue28.CanGrow = false;
			this.DedItemValue28.DataField = "ITEM_VALUE_58";
			this.DedItemValue28.Height = 0.188F;
			this.DedItemValue28.Left = 6.520501F;
			this.DedItemValue28.Name = "DedItemValue28";
			this.DedItemValue28.OutputFormat = "#,##0";
			this.DedItemValue28.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue28.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue28.Top = 6.376F;
			this.DedItemValue28.Width = 0.68F;
			// 
			// DedItemName29
			// 
			this.DedItemName29.CanGrow = false;
			this.DedItemName29.DataField = "ITEM_NAME_59";
			this.DedItemName29.Height = 0.188F;
			this.DedItemName29.Left = 5.5F;
			this.DedItemName29.Name = "DedItemName29";
			this.DedItemName29.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName29.Text = "ああああああああ";
			this.DedItemName29.Top = 6.5625F;
			this.DedItemName29.Width = 1.02F;
			// 
			// DedItemValue29
			// 
			this.DedItemValue29.CanGrow = false;
			this.DedItemValue29.DataField = "ITEM_VALUE_59";
			this.DedItemValue29.Height = 0.188F;
			this.DedItemValue29.Left = 6.520501F;
			this.DedItemValue29.Name = "DedItemValue29";
			this.DedItemValue29.OutputFormat = "#,##0";
			this.DedItemValue29.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue29.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue29.Top = 6.5635F;
			this.DedItemValue29.Width = 0.68F;
			// 
			// DedItemName30
			// 
			this.DedItemName30.CanGrow = false;
			this.DedItemName30.DataField = "ITEM_NAME_60";
			this.DedItemName30.Height = 0.188F;
			this.DedItemName30.Left = 5.5F;
			this.DedItemName30.Name = "DedItemName30";
			this.DedItemName30.Style = "font-size: 8.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DedItemName30.Text = "ああああああああ";
			this.DedItemName30.Top = 6.75F;
			this.DedItemName30.Width = 1.02F;
			// 
			// DedItemValue30
			// 
			this.DedItemValue30.CanGrow = false;
			this.DedItemValue30.DataField = "ITEM_VALUE_60";
			this.DedItemValue30.Height = 0.188F;
			this.DedItemValue30.Left = 6.520501F;
			this.DedItemValue30.Name = "DedItemValue30";
			this.DedItemValue30.OutputFormat = "#,##0";
			this.DedItemValue30.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; white-space: nowrap;" +
    " ddo-char-set: 1";
			this.DedItemValue30.Text = "ZZ,ZZZ,ZZ6-";
			this.DedItemValue30.Top = 6.751F;
			this.DedItemValue30.Width = 0.68F;
			// 
			// Line458
			// 
			this.Line458.Height = 0.75F;
			this.Line458.Left = 3.75F;
			this.Line458.LineWeight = 1F;
			this.Line458.Name = "Line458";
			this.Line458.Top = 6.1875F;
			this.Line458.Width = 0F;
			this.Line458.X1 = 3.75F;
			this.Line458.X2 = 3.75F;
			this.Line458.Y1 = 6.1875F;
			this.Line458.Y2 = 6.9375F;
			// 
			// Line459
			// 
			this.Line459.Height = 0.75F;
			this.Line459.Left = 4.771001F;
			this.Line459.LineWeight = 1F;
			this.Line459.Name = "Line459";
			this.Line459.Top = 6.1875F;
			this.Line459.Width = 0F;
			this.Line459.X1 = 4.771001F;
			this.Line459.X2 = 4.771001F;
			this.Line459.Y1 = 6.1875F;
			this.Line459.Y2 = 6.9375F;
			// 
			// Line460
			// 
			this.Line460.Height = 0.75F;
			this.Line460.Left = 5.450999F;
			this.Line460.LineWeight = 1F;
			this.Line460.Name = "Line460";
			this.Line460.Top = 6.1875F;
			this.Line460.Width = 0F;
			this.Line460.X1 = 5.450999F;
			this.Line460.X2 = 5.450999F;
			this.Line460.Y1 = 6.1875F;
			this.Line460.Y2 = 6.9375F;
			// 
			// Line461
			// 
			this.Line461.Height = 0.75F;
			this.Line461.Left = 5.5F;
			this.Line461.LineWeight = 1F;
			this.Line461.Name = "Line461";
			this.Line461.Top = 6.1875F;
			this.Line461.Width = 0F;
			this.Line461.X1 = 5.5F;
			this.Line461.X2 = 5.5F;
			this.Line461.Y1 = 6.1875F;
			this.Line461.Y2 = 6.9375F;
			// 
			// Line462
			// 
			this.Line462.Height = 0.75F;
			this.Line462.Left = 6.521F;
			this.Line462.LineWeight = 1F;
			this.Line462.Name = "Line462";
			this.Line462.Top = 6.1875F;
			this.Line462.Width = 0F;
			this.Line462.X1 = 6.521F;
			this.Line462.X2 = 6.521F;
			this.Line462.Y1 = 6.1875F;
			this.Line462.Y2 = 6.9375F;
			// 
			// Line463
			// 
			this.Line463.Height = 0.75F;
			this.Line463.Left = 7.2F;
			this.Line463.LineWeight = 1F;
			this.Line463.Name = "Line463";
			this.Line463.Top = 6.1875F;
			this.Line463.Width = 0F;
			this.Line463.X1 = 7.2F;
			this.Line463.X2 = 7.2F;
			this.Line463.Y1 = 6.1875F;
			this.Line463.Y2 = 6.9375F;
			// 
			// Line464
			// 
			this.Line464.Height = 0F;
			this.Line464.Left = 3.75F;
			this.Line464.LineWeight = 1F;
			this.Line464.Name = "Line464";
			this.Line464.Top = 6.1875F;
			this.Line464.Width = 1.700999F;
			this.Line464.X1 = 3.75F;
			this.Line464.X2 = 5.450999F;
			this.Line464.Y1 = 6.1875F;
			this.Line464.Y2 = 6.1875F;
			// 
			// Line465
			// 
			this.Line465.Height = 0F;
			this.Line465.Left = 3.75F;
			this.Line465.LineWeight = 1F;
			this.Line465.Name = "Line465";
			this.Line465.Top = 6.375F;
			this.Line465.Width = 1.700999F;
			this.Line465.X1 = 3.75F;
			this.Line465.X2 = 5.450999F;
			this.Line465.Y1 = 6.375F;
			this.Line465.Y2 = 6.375F;
			// 
			// Line466
			// 
			this.Line466.Height = 0F;
			this.Line466.Left = 3.75F;
			this.Line466.LineWeight = 1F;
			this.Line466.Name = "Line466";
			this.Line466.Top = 6.5625F;
			this.Line466.Width = 1.700999F;
			this.Line466.X1 = 3.75F;
			this.Line466.X2 = 5.450999F;
			this.Line466.Y1 = 6.5625F;
			this.Line466.Y2 = 6.5625F;
			// 
			// Line467
			// 
			this.Line467.Height = 0F;
			this.Line467.Left = 3.75F;
			this.Line467.LineWeight = 1F;
			this.Line467.Name = "Line467";
			this.Line467.Top = 6.75F;
			this.Line467.Width = 1.700999F;
			this.Line467.X1 = 3.75F;
			this.Line467.X2 = 5.450999F;
			this.Line467.Y1 = 6.75F;
			this.Line467.Y2 = 6.75F;
			// 
			// Line468
			// 
			this.Line468.Height = 0F;
			this.Line468.Left = 3.75F;
			this.Line468.LineWeight = 1F;
			this.Line468.Name = "Line468";
			this.Line468.Top = 6.9375F;
			this.Line468.Width = 1.700999F;
			this.Line468.X1 = 3.75F;
			this.Line468.X2 = 5.450999F;
			this.Line468.Y1 = 6.9375F;
			this.Line468.Y2 = 6.9375F;
			// 
			// Line469
			// 
			this.Line469.Height = 0F;
			this.Line469.Left = 5.5F;
			this.Line469.LineWeight = 1F;
			this.Line469.Name = "Line469";
			this.Line469.Top = 6.1875F;
			this.Line469.Width = 1.7F;
			this.Line469.X1 = 5.5F;
			this.Line469.X2 = 7.2F;
			this.Line469.Y1 = 6.1875F;
			this.Line469.Y2 = 6.1875F;
			// 
			// Line470
			// 
			this.Line470.Height = 0F;
			this.Line470.Left = 5.5F;
			this.Line470.LineWeight = 1F;
			this.Line470.Name = "Line470";
			this.Line470.Top = 6.375F;
			this.Line470.Width = 1.7F;
			this.Line470.X1 = 5.5F;
			this.Line470.X2 = 7.2F;
			this.Line470.Y1 = 6.375F;
			this.Line470.Y2 = 6.375F;
			// 
			// Line471
			// 
			this.Line471.Height = 0F;
			this.Line471.Left = 5.5F;
			this.Line471.LineWeight = 1F;
			this.Line471.Name = "Line471";
			this.Line471.Top = 6.5625F;
			this.Line471.Width = 1.7F;
			this.Line471.X1 = 5.5F;
			this.Line471.X2 = 7.2F;
			this.Line471.Y1 = 6.5625F;
			this.Line471.Y2 = 6.5625F;
			// 
			// Line472
			// 
			this.Line472.Height = 0F;
			this.Line472.Left = 5.5F;
			this.Line472.LineWeight = 1F;
			this.Line472.Name = "Line472";
			this.Line472.Top = 6.75F;
			this.Line472.Width = 1.7F;
			this.Line472.X1 = 5.5F;
			this.Line472.X2 = 7.2F;
			this.Line472.Y1 = 6.75F;
			this.Line472.Y2 = 6.75F;
			// 
			// Line473
			// 
			this.Line473.Height = 0F;
			this.Line473.Left = 5.5F;
			this.Line473.LineWeight = 1F;
			this.Line473.Name = "Line473";
			this.Line473.Top = 6.9375F;
			this.Line473.Width = 1.7F;
			this.Line473.X1 = 5.5F;
			this.Line473.X2 = 7.2F;
			this.Line473.Y1 = 6.9375F;
			this.Line473.Y2 = 6.9375F;
			// 
			// Line443
			// 
			this.Line443.Height = 2.257F;
			this.Line443.Left = 9.3125F;
			this.Line443.LineWeight = 1F;
			this.Line443.Name = "Line443";
			this.Line443.Top = 1.125F;
			this.Line443.Width = 0.0004997253F;
			this.Line443.X1 = 9.313F;
			this.Line443.X2 = 9.3125F;
			this.Line443.Y1 = 1.125F;
			this.Line443.Y2 = 3.382F;
			// 
			// Line441
			// 
			this.Line441.Height = 3.1875F;
			this.Line441.Left = 9.9375F;
			this.Line441.LineWeight = 1F;
			this.Line441.Name = "Line441";
			this.Line441.Top = 1.125F;
			this.Line441.Width = 0F;
			this.Line441.X1 = 9.9375F;
			this.Line441.X2 = 9.9375F;
			this.Line441.Y1 = 1.125F;
			this.Line441.Y2 = 4.3125F;
			// 
			// Line438
			// 
			this.Line438.Height = 3.375F;
			this.Line438.Left = 10.625F;
			this.Line438.LineWeight = 1F;
			this.Line438.Name = "Line438";
			this.Line438.Top = 0.9375F;
			this.Line438.Width = 0F;
			this.Line438.X1 = 10.625F;
			this.Line438.X2 = 10.625F;
			this.Line438.Y1 = 0.9375F;
			this.Line438.Y2 = 4.3125F;
			// 
			// Line437
			// 
			this.Line437.Height = 3.368F;
			this.Line437.Left = 7.438F;
			this.Line437.LineWeight = 1F;
			this.Line437.Name = "Line437";
			this.Line437.Top = 0.9445F;
			this.Line437.Width = 0F;
			this.Line437.X1 = 7.438F;
			this.Line437.X2 = 7.438F;
			this.Line437.Y1 = 0.9445F;
			this.Line437.Y2 = 4.3125F;
			// 
			// Line442
			// 
			this.Line442.Height = 2.257F;
			this.Line442.Left = 8.0625F;
			this.Line442.LineWeight = 1F;
			this.Line442.Name = "Line442";
			this.Line442.Top = 1.125F;
			this.Line442.Width = 0F;
			this.Line442.X1 = 8.0625F;
			this.Line442.X2 = 8.0625F;
			this.Line442.Y1 = 1.125F;
			this.Line442.Y2 = 3.382F;
			// 
			// Line440
			// 
			this.Line440.Height = 3.007F;
			this.Line440.Left = 8.6875F;
			this.Line440.LineWeight = 1F;
			this.Line440.Name = "Line440";
			this.Line440.Top = 1.125F;
			this.Line440.Width = 0.0004997253F;
			this.Line440.X1 = 8.688F;
			this.Line440.X2 = 8.6875F;
			this.Line440.Y1 = 1.125F;
			this.Line440.Y2 = 4.132F;
			// 
			// SlryItemForm1
			// 
			this.SlryItemForm1.DataField = "ITEM_FORM_1";
			this.SlryItemForm1.Height = 0.1875F;
			this.SlryItemForm1.Left = 0.0625F;
			this.SlryItemForm1.Name = "SlryItemForm1";
			this.SlryItemForm1.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm1.Text = "FORMAT";
			this.SlryItemForm1.Top = 2F;
			this.SlryItemForm1.Visible = false;
			this.SlryItemForm1.Width = 0.4375F;
			// 
			// DedItemForm1
			// 
			this.DedItemForm1.DataField = "ITEM_FORM_31";
			this.DedItemForm1.Height = 0.1875F;
			this.DedItemForm1.Left = 1F;
			this.DedItemForm1.Name = "DedItemForm1";
			this.DedItemForm1.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm1.Text = "FORMAT";
			this.DedItemForm1.Top = 2F;
			this.DedItemForm1.Visible = false;
			this.DedItemForm1.Width = 0.4375F;
			// 
			// DtyItemForm1
			// 
			this.DtyItemForm1.DataField = "ITEM_FORM_61";
			this.DtyItemForm1.Height = 0.1875F;
			this.DtyItemForm1.Left = 1.9375F;
			this.DtyItemForm1.Name = "DtyItemForm1";
			this.DtyItemForm1.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm1.Text = "FORMAT";
			this.DtyItemForm1.Top = 2F;
			this.DtyItemForm1.Visible = false;
			this.DtyItemForm1.Width = 0.4375F;
			// 
			// SlryItemForm2
			// 
			this.SlryItemForm2.DataField = "ITEM_FORM_2";
			this.SlryItemForm2.Height = 0.1875F;
			this.SlryItemForm2.Left = 0.0625F;
			this.SlryItemForm2.Name = "SlryItemForm2";
			this.SlryItemForm2.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm2.Text = "FORMAT";
			this.SlryItemForm2.Top = 2.1875F;
			this.SlryItemForm2.Visible = false;
			this.SlryItemForm2.Width = 0.4375F;
			// 
			// SlryItemForm3
			// 
			this.SlryItemForm3.DataField = "ITEM_FORM_3";
			this.SlryItemForm3.Height = 0.1875F;
			this.SlryItemForm3.Left = 0.0625F;
			this.SlryItemForm3.Name = "SlryItemForm3";
			this.SlryItemForm3.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm3.Text = "FORMAT";
			this.SlryItemForm3.Top = 2.375F;
			this.SlryItemForm3.Visible = false;
			this.SlryItemForm3.Width = 0.4375F;
			// 
			// SlryItemForm4
			// 
			this.SlryItemForm4.DataField = "ITEM_FORM_4";
			this.SlryItemForm4.Height = 0.1875F;
			this.SlryItemForm4.Left = 0.0625F;
			this.SlryItemForm4.Name = "SlryItemForm4";
			this.SlryItemForm4.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm4.Text = "FORMAT";
			this.SlryItemForm4.Top = 2.5625F;
			this.SlryItemForm4.Visible = false;
			this.SlryItemForm4.Width = 0.4375F;
			// 
			// SlryItemForm5
			// 
			this.SlryItemForm5.DataField = "ITEM_FORM_5";
			this.SlryItemForm5.Height = 0.1875F;
			this.SlryItemForm5.Left = 0.0625F;
			this.SlryItemForm5.Name = "SlryItemForm5";
			this.SlryItemForm5.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm5.Text = "FORMAT";
			this.SlryItemForm5.Top = 2.75F;
			this.SlryItemForm5.Visible = false;
			this.SlryItemForm5.Width = 0.4375F;
			// 
			// SlryItemForm6
			// 
			this.SlryItemForm6.DataField = "ITEM_FORM_6";
			this.SlryItemForm6.Height = 0.1875F;
			this.SlryItemForm6.Left = 0.0625F;
			this.SlryItemForm6.Name = "SlryItemForm6";
			this.SlryItemForm6.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm6.Text = "FORMAT";
			this.SlryItemForm6.Top = 2.9375F;
			this.SlryItemForm6.Visible = false;
			this.SlryItemForm6.Width = 0.4375F;
			// 
			// SlryItemForm7
			// 
			this.SlryItemForm7.DataField = "ITEM_FORM_7";
			this.SlryItemForm7.Height = 0.1875F;
			this.SlryItemForm7.Left = 0.0625F;
			this.SlryItemForm7.Name = "SlryItemForm7";
			this.SlryItemForm7.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm7.Text = "FORMAT";
			this.SlryItemForm7.Top = 3.125F;
			this.SlryItemForm7.Visible = false;
			this.SlryItemForm7.Width = 0.4375F;
			// 
			// SlryItemForm8
			// 
			this.SlryItemForm8.DataField = "ITEM_FORM_8";
			this.SlryItemForm8.Height = 0.1875F;
			this.SlryItemForm8.Left = 0.0625F;
			this.SlryItemForm8.Name = "SlryItemForm8";
			this.SlryItemForm8.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm8.Text = "FORMAT";
			this.SlryItemForm8.Top = 3.3125F;
			this.SlryItemForm8.Visible = false;
			this.SlryItemForm8.Width = 0.4375F;
			// 
			// SlryItemForm9
			// 
			this.SlryItemForm9.DataField = "ITEM_FORM_9";
			this.SlryItemForm9.Height = 0.1875F;
			this.SlryItemForm9.Left = 0.0625F;
			this.SlryItemForm9.Name = "SlryItemForm9";
			this.SlryItemForm9.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm9.Text = "FORMAT";
			this.SlryItemForm9.Top = 3.5F;
			this.SlryItemForm9.Visible = false;
			this.SlryItemForm9.Width = 0.4375F;
			// 
			// SlryItemForm10
			// 
			this.SlryItemForm10.DataField = "ITEM_FORM_10";
			this.SlryItemForm10.Height = 0.1875F;
			this.SlryItemForm10.Left = 0.0625F;
			this.SlryItemForm10.Name = "SlryItemForm10";
			this.SlryItemForm10.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm10.Text = "FORMAT";
			this.SlryItemForm10.Top = 3.6875F;
			this.SlryItemForm10.Visible = false;
			this.SlryItemForm10.Width = 0.4375F;
			// 
			// SlryItemForm11
			// 
			this.SlryItemForm11.DataField = "ITEM_FORM_11";
			this.SlryItemForm11.Height = 0.1875F;
			this.SlryItemForm11.Left = 0.0625F;
			this.SlryItemForm11.Name = "SlryItemForm11";
			this.SlryItemForm11.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm11.Text = "FORMAT";
			this.SlryItemForm11.Top = 3.875F;
			this.SlryItemForm11.Visible = false;
			this.SlryItemForm11.Width = 0.4375F;
			// 
			// SlryItemForm12
			// 
			this.SlryItemForm12.DataField = "ITEM_FORM_12";
			this.SlryItemForm12.Height = 0.1875F;
			this.SlryItemForm12.Left = 0.0625F;
			this.SlryItemForm12.Name = "SlryItemForm12";
			this.SlryItemForm12.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm12.Text = "FORMAT";
			this.SlryItemForm12.Top = 4.0625F;
			this.SlryItemForm12.Visible = false;
			this.SlryItemForm12.Width = 0.4375F;
			// 
			// SlryItemForm13
			// 
			this.SlryItemForm13.DataField = "ITEM_FORM_13";
			this.SlryItemForm13.Height = 0.1875F;
			this.SlryItemForm13.Left = 0.0625F;
			this.SlryItemForm13.Name = "SlryItemForm13";
			this.SlryItemForm13.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm13.Text = "FORMAT";
			this.SlryItemForm13.Top = 4.25F;
			this.SlryItemForm13.Visible = false;
			this.SlryItemForm13.Width = 0.4375F;
			// 
			// SlryItemForm14
			// 
			this.SlryItemForm14.DataField = "ITEM_FORM_14";
			this.SlryItemForm14.Height = 0.1875F;
			this.SlryItemForm14.Left = 0.0625F;
			this.SlryItemForm14.Name = "SlryItemForm14";
			this.SlryItemForm14.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm14.Text = "FORMAT";
			this.SlryItemForm14.Top = 4.4375F;
			this.SlryItemForm14.Visible = false;
			this.SlryItemForm14.Width = 0.4375F;
			// 
			// SlryItemForm15
			// 
			this.SlryItemForm15.DataField = "ITEM_FORM_15";
			this.SlryItemForm15.Height = 0.1875F;
			this.SlryItemForm15.Left = 0.0625F;
			this.SlryItemForm15.Name = "SlryItemForm15";
			this.SlryItemForm15.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm15.Text = "FORMAT";
			this.SlryItemForm15.Top = 4.625F;
			this.SlryItemForm15.Visible = false;
			this.SlryItemForm15.Width = 0.4375F;
			// 
			// SlryItemForm16
			// 
			this.SlryItemForm16.DataField = "ITEM_FORM_16";
			this.SlryItemForm16.Height = 0.1875F;
			this.SlryItemForm16.Left = 0.5F;
			this.SlryItemForm16.Name = "SlryItemForm16";
			this.SlryItemForm16.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm16.Text = "FORMAT";
			this.SlryItemForm16.Top = 2F;
			this.SlryItemForm16.Visible = false;
			this.SlryItemForm16.Width = 0.4375F;
			// 
			// SlryItemForm17
			// 
			this.SlryItemForm17.DataField = "ITEM_FORM_17";
			this.SlryItemForm17.Height = 0.1875F;
			this.SlryItemForm17.Left = 0.5F;
			this.SlryItemForm17.Name = "SlryItemForm17";
			this.SlryItemForm17.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm17.Text = "FORMAT";
			this.SlryItemForm17.Top = 2.1875F;
			this.SlryItemForm17.Visible = false;
			this.SlryItemForm17.Width = 0.4375F;
			// 
			// SlryItemForm18
			// 
			this.SlryItemForm18.DataField = "ITEM_FORM_18";
			this.SlryItemForm18.Height = 0.1875F;
			this.SlryItemForm18.Left = 0.5F;
			this.SlryItemForm18.Name = "SlryItemForm18";
			this.SlryItemForm18.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm18.Text = "FORMAT";
			this.SlryItemForm18.Top = 2.375F;
			this.SlryItemForm18.Visible = false;
			this.SlryItemForm18.Width = 0.4375F;
			// 
			// SlryItemForm19
			// 
			this.SlryItemForm19.DataField = "ITEM_FORM_19";
			this.SlryItemForm19.Height = 0.1875F;
			this.SlryItemForm19.Left = 0.5F;
			this.SlryItemForm19.Name = "SlryItemForm19";
			this.SlryItemForm19.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm19.Text = "FORMAT";
			this.SlryItemForm19.Top = 2.5625F;
			this.SlryItemForm19.Visible = false;
			this.SlryItemForm19.Width = 0.4375F;
			// 
			// SlryItemForm20
			// 
			this.SlryItemForm20.DataField = "ITEM_FORM_20";
			this.SlryItemForm20.Height = 0.1875F;
			this.SlryItemForm20.Left = 0.5F;
			this.SlryItemForm20.Name = "SlryItemForm20";
			this.SlryItemForm20.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm20.Text = "FORMAT";
			this.SlryItemForm20.Top = 2.75F;
			this.SlryItemForm20.Visible = false;
			this.SlryItemForm20.Width = 0.4375F;
			// 
			// SlryItemForm21
			// 
			this.SlryItemForm21.DataField = "ITEM_FORM_21";
			this.SlryItemForm21.Height = 0.1875F;
			this.SlryItemForm21.Left = 0.5F;
			this.SlryItemForm21.Name = "SlryItemForm21";
			this.SlryItemForm21.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm21.Text = "FORMAT";
			this.SlryItemForm21.Top = 2.9375F;
			this.SlryItemForm21.Visible = false;
			this.SlryItemForm21.Width = 0.4375F;
			// 
			// SlryItemForm22
			// 
			this.SlryItemForm22.DataField = "ITEM_FORM_22";
			this.SlryItemForm22.Height = 0.1875F;
			this.SlryItemForm22.Left = 0.5F;
			this.SlryItemForm22.Name = "SlryItemForm22";
			this.SlryItemForm22.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm22.Text = "FORMAT";
			this.SlryItemForm22.Top = 3.125F;
			this.SlryItemForm22.Visible = false;
			this.SlryItemForm22.Width = 0.4375F;
			// 
			// SlryItemForm23
			// 
			this.SlryItemForm23.DataField = "ITEM_FORM_23";
			this.SlryItemForm23.Height = 0.1875F;
			this.SlryItemForm23.Left = 0.5F;
			this.SlryItemForm23.Name = "SlryItemForm23";
			this.SlryItemForm23.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm23.Text = "FORMAT";
			this.SlryItemForm23.Top = 3.3125F;
			this.SlryItemForm23.Visible = false;
			this.SlryItemForm23.Width = 0.4375F;
			// 
			// SlryItemForm24
			// 
			this.SlryItemForm24.DataField = "ITEM_FORM_24";
			this.SlryItemForm24.Height = 0.1875F;
			this.SlryItemForm24.Left = 0.5F;
			this.SlryItemForm24.Name = "SlryItemForm24";
			this.SlryItemForm24.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm24.Text = "FORMAT";
			this.SlryItemForm24.Top = 3.5F;
			this.SlryItemForm24.Visible = false;
			this.SlryItemForm24.Width = 0.4375F;
			// 
			// SlryItemForm25
			// 
			this.SlryItemForm25.DataField = "ITEM_FORM_25";
			this.SlryItemForm25.Height = 0.1875F;
			this.SlryItemForm25.Left = 0.5F;
			this.SlryItemForm25.Name = "SlryItemForm25";
			this.SlryItemForm25.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm25.Text = "FORMAT";
			this.SlryItemForm25.Top = 3.6875F;
			this.SlryItemForm25.Visible = false;
			this.SlryItemForm25.Width = 0.4375F;
			// 
			// SlryItemForm26
			// 
			this.SlryItemForm26.DataField = "ITEM_FORM_26";
			this.SlryItemForm26.Height = 0.1875F;
			this.SlryItemForm26.Left = 0.5F;
			this.SlryItemForm26.Name = "SlryItemForm26";
			this.SlryItemForm26.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm26.Text = "FORMAT";
			this.SlryItemForm26.Top = 3.875F;
			this.SlryItemForm26.Visible = false;
			this.SlryItemForm26.Width = 0.4375F;
			// 
			// SlryItemForm27
			// 
			this.SlryItemForm27.DataField = "ITEM_FORM_27";
			this.SlryItemForm27.Height = 0.1875F;
			this.SlryItemForm27.Left = 0.5F;
			this.SlryItemForm27.Name = "SlryItemForm27";
			this.SlryItemForm27.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm27.Text = "FORMAT";
			this.SlryItemForm27.Top = 4.0625F;
			this.SlryItemForm27.Visible = false;
			this.SlryItemForm27.Width = 0.4375F;
			// 
			// SlryItemForm28
			// 
			this.SlryItemForm28.DataField = "ITEM_FORM_28";
			this.SlryItemForm28.Height = 0.1875F;
			this.SlryItemForm28.Left = 0.5F;
			this.SlryItemForm28.Name = "SlryItemForm28";
			this.SlryItemForm28.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm28.Text = "FORMAT";
			this.SlryItemForm28.Top = 4.25F;
			this.SlryItemForm28.Visible = false;
			this.SlryItemForm28.Width = 0.4375F;
			// 
			// SlryItemForm29
			// 
			this.SlryItemForm29.DataField = "ITEM_FORM_29";
			this.SlryItemForm29.Height = 0.1875F;
			this.SlryItemForm29.Left = 0.5F;
			this.SlryItemForm29.Name = "SlryItemForm29";
			this.SlryItemForm29.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm29.Text = "FORMAT";
			this.SlryItemForm29.Top = 4.4375F;
			this.SlryItemForm29.Visible = false;
			this.SlryItemForm29.Width = 0.4375F;
			// 
			// SlryItemForm30
			// 
			this.SlryItemForm30.DataField = "ITEM_FORM_30";
			this.SlryItemForm30.Height = 0.1875F;
			this.SlryItemForm30.Left = 0.5F;
			this.SlryItemForm30.Name = "SlryItemForm30";
			this.SlryItemForm30.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.SlryItemForm30.Text = "FORMAT";
			this.SlryItemForm30.Top = 4.625F;
			this.SlryItemForm30.Visible = false;
			this.SlryItemForm30.Width = 0.4375F;
			// 
			// DedItemForm2
			// 
			this.DedItemForm2.DataField = "ITEM_FORM_32";
			this.DedItemForm2.Height = 0.1875F;
			this.DedItemForm2.Left = 1F;
			this.DedItemForm2.Name = "DedItemForm2";
			this.DedItemForm2.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm2.Text = "FORMAT";
			this.DedItemForm2.Top = 2.1875F;
			this.DedItemForm2.Visible = false;
			this.DedItemForm2.Width = 0.4375F;
			// 
			// DedItemForm3
			// 
			this.DedItemForm3.DataField = "ITEM_FORM_33";
			this.DedItemForm3.Height = 0.1875F;
			this.DedItemForm3.Left = 1F;
			this.DedItemForm3.Name = "DedItemForm3";
			this.DedItemForm3.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm3.Text = "FORMAT";
			this.DedItemForm3.Top = 2.375F;
			this.DedItemForm3.Visible = false;
			this.DedItemForm3.Width = 0.4375F;
			// 
			// DedItemForm4
			// 
			this.DedItemForm4.DataField = "ITEM_FORM_34";
			this.DedItemForm4.Height = 0.1875F;
			this.DedItemForm4.Left = 1F;
			this.DedItemForm4.Name = "DedItemForm4";
			this.DedItemForm4.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm4.Text = "FORMAT";
			this.DedItemForm4.Top = 2.5625F;
			this.DedItemForm4.Visible = false;
			this.DedItemForm4.Width = 0.4375F;
			// 
			// DedItemForm5
			// 
			this.DedItemForm5.DataField = "ITEM_FORM_35";
			this.DedItemForm5.Height = 0.1875F;
			this.DedItemForm5.Left = 1F;
			this.DedItemForm5.Name = "DedItemForm5";
			this.DedItemForm5.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm5.Text = "FORMAT";
			this.DedItemForm5.Top = 2.75F;
			this.DedItemForm5.Visible = false;
			this.DedItemForm5.Width = 0.4375F;
			// 
			// DedItemForm6
			// 
			this.DedItemForm6.DataField = "ITEM_FORM_36";
			this.DedItemForm6.Height = 0.1875F;
			this.DedItemForm6.Left = 1F;
			this.DedItemForm6.Name = "DedItemForm6";
			this.DedItemForm6.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm6.Text = "FORMAT";
			this.DedItemForm6.Top = 2.9375F;
			this.DedItemForm6.Visible = false;
			this.DedItemForm6.Width = 0.4375F;
			// 
			// DedItemForm7
			// 
			this.DedItemForm7.DataField = "ITEM_FORM_37";
			this.DedItemForm7.Height = 0.1875F;
			this.DedItemForm7.Left = 1F;
			this.DedItemForm7.Name = "DedItemForm7";
			this.DedItemForm7.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm7.Text = "FORMAT";
			this.DedItemForm7.Top = 3.125F;
			this.DedItemForm7.Visible = false;
			this.DedItemForm7.Width = 0.4375F;
			// 
			// DedItemForm8
			// 
			this.DedItemForm8.DataField = "ITEM_FORM_38";
			this.DedItemForm8.Height = 0.1875F;
			this.DedItemForm8.Left = 1F;
			this.DedItemForm8.Name = "DedItemForm8";
			this.DedItemForm8.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm8.Text = "FORMAT";
			this.DedItemForm8.Top = 3.3125F;
			this.DedItemForm8.Visible = false;
			this.DedItemForm8.Width = 0.4375F;
			// 
			// DedItemForm9
			// 
			this.DedItemForm9.DataField = "ITEM_FORM_39";
			this.DedItemForm9.Height = 0.1875F;
			this.DedItemForm9.Left = 1F;
			this.DedItemForm9.Name = "DedItemForm9";
			this.DedItemForm9.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm9.Text = "FORMAT";
			this.DedItemForm9.Top = 3.5F;
			this.DedItemForm9.Visible = false;
			this.DedItemForm9.Width = 0.4375F;
			// 
			// DedItemForm10
			// 
			this.DedItemForm10.DataField = "ITEM_FORM_40";
			this.DedItemForm10.Height = 0.1875F;
			this.DedItemForm10.Left = 1F;
			this.DedItemForm10.Name = "DedItemForm10";
			this.DedItemForm10.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm10.Text = "FORMAT";
			this.DedItemForm10.Top = 3.6875F;
			this.DedItemForm10.Visible = false;
			this.DedItemForm10.Width = 0.4375F;
			// 
			// DedItemForm11
			// 
			this.DedItemForm11.DataField = "ITEM_FORM_41";
			this.DedItemForm11.Height = 0.1875F;
			this.DedItemForm11.Left = 1F;
			this.DedItemForm11.Name = "DedItemForm11";
			this.DedItemForm11.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm11.Text = "FORMAT";
			this.DedItemForm11.Top = 3.875F;
			this.DedItemForm11.Visible = false;
			this.DedItemForm11.Width = 0.4375F;
			// 
			// DedItemForm12
			// 
			this.DedItemForm12.DataField = "ITEM_FORM_42";
			this.DedItemForm12.Height = 0.1875F;
			this.DedItemForm12.Left = 1F;
			this.DedItemForm12.Name = "DedItemForm12";
			this.DedItemForm12.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm12.Text = "FORMAT";
			this.DedItemForm12.Top = 4.0625F;
			this.DedItemForm12.Visible = false;
			this.DedItemForm12.Width = 0.4375F;
			// 
			// DedItemForm13
			// 
			this.DedItemForm13.DataField = "ITEM_FORM_43";
			this.DedItemForm13.Height = 0.1875F;
			this.DedItemForm13.Left = 1F;
			this.DedItemForm13.Name = "DedItemForm13";
			this.DedItemForm13.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm13.Text = "FORMAT";
			this.DedItemForm13.Top = 4.25F;
			this.DedItemForm13.Visible = false;
			this.DedItemForm13.Width = 0.4375F;
			// 
			// DedItemForm14
			// 
			this.DedItemForm14.DataField = "ITEM_FORM_44";
			this.DedItemForm14.Height = 0.1875F;
			this.DedItemForm14.Left = 1F;
			this.DedItemForm14.Name = "DedItemForm14";
			this.DedItemForm14.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm14.Text = "FORMAT";
			this.DedItemForm14.Top = 4.4375F;
			this.DedItemForm14.Visible = false;
			this.DedItemForm14.Width = 0.4375F;
			// 
			// DedItemForm15
			// 
			this.DedItemForm15.DataField = "ITEM_FORM_45";
			this.DedItemForm15.Height = 0.1875F;
			this.DedItemForm15.Left = 1F;
			this.DedItemForm15.Name = "DedItemForm15";
			this.DedItemForm15.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm15.Text = "FORMAT";
			this.DedItemForm15.Top = 4.625F;
			this.DedItemForm15.Visible = false;
			this.DedItemForm15.Width = 0.4375F;
			// 
			// DedItemForm16
			// 
			this.DedItemForm16.DataField = "ITEM_FORM_46";
			this.DedItemForm16.Height = 0.1875F;
			this.DedItemForm16.Left = 1.4375F;
			this.DedItemForm16.Name = "DedItemForm16";
			this.DedItemForm16.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm16.Text = "FORMAT";
			this.DedItemForm16.Top = 2F;
			this.DedItemForm16.Visible = false;
			this.DedItemForm16.Width = 0.4375F;
			// 
			// DedItemForm17
			// 
			this.DedItemForm17.DataField = "ITEM_FORM_47";
			this.DedItemForm17.Height = 0.1875F;
			this.DedItemForm17.Left = 1.4375F;
			this.DedItemForm17.Name = "DedItemForm17";
			this.DedItemForm17.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm17.Text = "FORMAT";
			this.DedItemForm17.Top = 2.1875F;
			this.DedItemForm17.Visible = false;
			this.DedItemForm17.Width = 0.4375F;
			// 
			// DedItemForm18
			// 
			this.DedItemForm18.DataField = "ITEM_FORM_48";
			this.DedItemForm18.Height = 0.1875F;
			this.DedItemForm18.Left = 1.4375F;
			this.DedItemForm18.Name = "DedItemForm18";
			this.DedItemForm18.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm18.Text = "FORMAT";
			this.DedItemForm18.Top = 2.375F;
			this.DedItemForm18.Visible = false;
			this.DedItemForm18.Width = 0.4375F;
			// 
			// DedItemForm19
			// 
			this.DedItemForm19.DataField = "ITEM_FORM_49";
			this.DedItemForm19.Height = 0.1875F;
			this.DedItemForm19.Left = 1.4375F;
			this.DedItemForm19.Name = "DedItemForm19";
			this.DedItemForm19.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm19.Text = "FORMAT";
			this.DedItemForm19.Top = 2.5625F;
			this.DedItemForm19.Visible = false;
			this.DedItemForm19.Width = 0.4375F;
			// 
			// DedItemForm20
			// 
			this.DedItemForm20.DataField = "ITEM_FORM_50";
			this.DedItemForm20.Height = 0.1875F;
			this.DedItemForm20.Left = 1.4375F;
			this.DedItemForm20.Name = "DedItemForm20";
			this.DedItemForm20.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm20.Text = "FORMAT";
			this.DedItemForm20.Top = 2.75F;
			this.DedItemForm20.Visible = false;
			this.DedItemForm20.Width = 0.4375F;
			// 
			// DedItemForm21
			// 
			this.DedItemForm21.DataField = "ITEM_FORM_51";
			this.DedItemForm21.Height = 0.1875F;
			this.DedItemForm21.Left = 1.4375F;
			this.DedItemForm21.Name = "DedItemForm21";
			this.DedItemForm21.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm21.Text = "FORMAT";
			this.DedItemForm21.Top = 2.9375F;
			this.DedItemForm21.Visible = false;
			this.DedItemForm21.Width = 0.4375F;
			// 
			// DedItemForm22
			// 
			this.DedItemForm22.DataField = "ITEM_FORM_52";
			this.DedItemForm22.Height = 0.1875F;
			this.DedItemForm22.Left = 1.4375F;
			this.DedItemForm22.Name = "DedItemForm22";
			this.DedItemForm22.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm22.Text = "FORMAT";
			this.DedItemForm22.Top = 3.125F;
			this.DedItemForm22.Visible = false;
			this.DedItemForm22.Width = 0.4375F;
			// 
			// DedItemForm23
			// 
			this.DedItemForm23.DataField = "ITEM_FORM_53";
			this.DedItemForm23.Height = 0.1875F;
			this.DedItemForm23.Left = 1.4375F;
			this.DedItemForm23.Name = "DedItemForm23";
			this.DedItemForm23.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm23.Text = "FORMAT";
			this.DedItemForm23.Top = 3.3125F;
			this.DedItemForm23.Visible = false;
			this.DedItemForm23.Width = 0.4375F;
			// 
			// DedItemForm24
			// 
			this.DedItemForm24.DataField = "ITEM_FORM_54";
			this.DedItemForm24.Height = 0.1875F;
			this.DedItemForm24.Left = 1.4375F;
			this.DedItemForm24.Name = "DedItemForm24";
			this.DedItemForm24.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm24.Text = "FORMAT";
			this.DedItemForm24.Top = 3.5F;
			this.DedItemForm24.Visible = false;
			this.DedItemForm24.Width = 0.4375F;
			// 
			// DedItemForm25
			// 
			this.DedItemForm25.DataField = "ITEM_FORM_55";
			this.DedItemForm25.Height = 0.1875F;
			this.DedItemForm25.Left = 1.4375F;
			this.DedItemForm25.Name = "DedItemForm25";
			this.DedItemForm25.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm25.Text = "FORMAT";
			this.DedItemForm25.Top = 3.6875F;
			this.DedItemForm25.Visible = false;
			this.DedItemForm25.Width = 0.4375F;
			// 
			// DedItemForm26
			// 
			this.DedItemForm26.DataField = "ITEM_FORM_56";
			this.DedItemForm26.Height = 0.1875F;
			this.DedItemForm26.Left = 1.4375F;
			this.DedItemForm26.Name = "DedItemForm26";
			this.DedItemForm26.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm26.Text = "FORMAT";
			this.DedItemForm26.Top = 3.875F;
			this.DedItemForm26.Visible = false;
			this.DedItemForm26.Width = 0.4375F;
			// 
			// DedItemForm27
			// 
			this.DedItemForm27.DataField = "ITEM_FORM_57";
			this.DedItemForm27.Height = 0.1875F;
			this.DedItemForm27.Left = 1.4375F;
			this.DedItemForm27.Name = "DedItemForm27";
			this.DedItemForm27.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm27.Text = "FORMAT";
			this.DedItemForm27.Top = 4.0625F;
			this.DedItemForm27.Visible = false;
			this.DedItemForm27.Width = 0.4375F;
			// 
			// DedItemForm28
			// 
			this.DedItemForm28.DataField = "ITEM_FORM_58";
			this.DedItemForm28.Height = 0.1875F;
			this.DedItemForm28.Left = 1.4375F;
			this.DedItemForm28.Name = "DedItemForm28";
			this.DedItemForm28.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm28.Text = "FORMAT";
			this.DedItemForm28.Top = 4.25F;
			this.DedItemForm28.Visible = false;
			this.DedItemForm28.Width = 0.4375F;
			// 
			// DedItemForm29
			// 
			this.DedItemForm29.DataField = "ITEM_FORM_59";
			this.DedItemForm29.Height = 0.1875F;
			this.DedItemForm29.Left = 1.4375F;
			this.DedItemForm29.Name = "DedItemForm29";
			this.DedItemForm29.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm29.Text = "FORMAT";
			this.DedItemForm29.Top = 4.4375F;
			this.DedItemForm29.Visible = false;
			this.DedItemForm29.Width = 0.4375F;
			// 
			// DedItemForm30
			// 
			this.DedItemForm30.DataField = "ITEM_FORM_60";
			this.DedItemForm30.Height = 0.1875F;
			this.DedItemForm30.Left = 1.4375F;
			this.DedItemForm30.Name = "DedItemForm30";
			this.DedItemForm30.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DedItemForm30.Text = "FORMAT";
			this.DedItemForm30.Top = 4.625F;
			this.DedItemForm30.Visible = false;
			this.DedItemForm30.Width = 0.4375F;
			// 
			// DtyItemForm2
			// 
			this.DtyItemForm2.DataField = "ITEM_FORM_62";
			this.DtyItemForm2.Height = 0.1875F;
			this.DtyItemForm2.Left = 1.9375F;
			this.DtyItemForm2.Name = "DtyItemForm2";
			this.DtyItemForm2.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm2.Text = "FORMAT";
			this.DtyItemForm2.Top = 2.1875F;
			this.DtyItemForm2.Visible = false;
			this.DtyItemForm2.Width = 0.4375F;
			// 
			// DtyItemForm3
			// 
			this.DtyItemForm3.DataField = "ITEM_FORM_63";
			this.DtyItemForm3.Height = 0.1875F;
			this.DtyItemForm3.Left = 1.9375F;
			this.DtyItemForm3.Name = "DtyItemForm3";
			this.DtyItemForm3.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm3.Text = "FORMAT";
			this.DtyItemForm3.Top = 2.375F;
			this.DtyItemForm3.Visible = false;
			this.DtyItemForm3.Width = 0.4375F;
			// 
			// DtyItemForm4
			// 
			this.DtyItemForm4.DataField = "ITEM_FORM_64";
			this.DtyItemForm4.Height = 0.1875F;
			this.DtyItemForm4.Left = 1.9375F;
			this.DtyItemForm4.Name = "DtyItemForm4";
			this.DtyItemForm4.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm4.Text = "FORMAT";
			this.DtyItemForm4.Top = 2.5625F;
			this.DtyItemForm4.Visible = false;
			this.DtyItemForm4.Width = 0.4375F;
			// 
			// DtyItemForm5
			// 
			this.DtyItemForm5.DataField = "ITEM_FORM_65";
			this.DtyItemForm5.Height = 0.1875F;
			this.DtyItemForm5.Left = 1.9375F;
			this.DtyItemForm5.Name = "DtyItemForm5";
			this.DtyItemForm5.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm5.Text = "FORMAT";
			this.DtyItemForm5.Top = 2.75F;
			this.DtyItemForm5.Visible = false;
			this.DtyItemForm5.Width = 0.4375F;
			// 
			// DtyItemForm6
			// 
			this.DtyItemForm6.DataField = "ITEM_FORM_66";
			this.DtyItemForm6.Height = 0.1875F;
			this.DtyItemForm6.Left = 1.9375F;
			this.DtyItemForm6.Name = "DtyItemForm6";
			this.DtyItemForm6.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm6.Text = "FORMAT";
			this.DtyItemForm6.Top = 2.9375F;
			this.DtyItemForm6.Visible = false;
			this.DtyItemForm6.Width = 0.4375F;
			// 
			// DtyItemForm7
			// 
			this.DtyItemForm7.DataField = "ITEM_FORM_67";
			this.DtyItemForm7.Height = 0.1875F;
			this.DtyItemForm7.Left = 1.9375F;
			this.DtyItemForm7.Name = "DtyItemForm7";
			this.DtyItemForm7.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm7.Text = "FORMAT";
			this.DtyItemForm7.Top = 3.125F;
			this.DtyItemForm7.Visible = false;
			this.DtyItemForm7.Width = 0.4375F;
			// 
			// DtyItemForm8
			// 
			this.DtyItemForm8.DataField = "ITEM_FORM_68";
			this.DtyItemForm8.Height = 0.1875F;
			this.DtyItemForm8.Left = 1.9375F;
			this.DtyItemForm8.Name = "DtyItemForm8";
			this.DtyItemForm8.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm8.Text = "FORMAT";
			this.DtyItemForm8.Top = 3.3125F;
			this.DtyItemForm8.Visible = false;
			this.DtyItemForm8.Width = 0.4375F;
			// 
			// DtyItemForm9
			// 
			this.DtyItemForm9.DataField = "ITEM_FORM_69";
			this.DtyItemForm9.Height = 0.1875F;
			this.DtyItemForm9.Left = 1.9375F;
			this.DtyItemForm9.Name = "DtyItemForm9";
			this.DtyItemForm9.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm9.Text = "FORMAT";
			this.DtyItemForm9.Top = 3.5F;
			this.DtyItemForm9.Visible = false;
			this.DtyItemForm9.Width = 0.4375F;
			// 
			// DtyItemForm10
			// 
			this.DtyItemForm10.DataField = "ITEM_FORM_70";
			this.DtyItemForm10.Height = 0.1875F;
			this.DtyItemForm10.Left = 1.9375F;
			this.DtyItemForm10.Name = "DtyItemForm10";
			this.DtyItemForm10.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm10.Text = "FORMAT";
			this.DtyItemForm10.Top = 3.6875F;
			this.DtyItemForm10.Visible = false;
			this.DtyItemForm10.Width = 0.4375F;
			// 
			// DtyItemForm11
			// 
			this.DtyItemForm11.DataField = "ITEM_FORM_71";
			this.DtyItemForm11.Height = 0.1875F;
			this.DtyItemForm11.Left = 1.9375F;
			this.DtyItemForm11.Name = "DtyItemForm11";
			this.DtyItemForm11.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm11.Text = "FORMAT";
			this.DtyItemForm11.Top = 3.875F;
			this.DtyItemForm11.Visible = false;
			this.DtyItemForm11.Width = 0.4375F;
			// 
			// DtyItemForm12
			// 
			this.DtyItemForm12.DataField = "ITEM_FORM_72";
			this.DtyItemForm12.Height = 0.1875F;
			this.DtyItemForm12.Left = 1.9375F;
			this.DtyItemForm12.Name = "DtyItemForm12";
			this.DtyItemForm12.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm12.Text = "FORMAT";
			this.DtyItemForm12.Top = 4.0625F;
			this.DtyItemForm12.Visible = false;
			this.DtyItemForm12.Width = 0.4375F;
			// 
			// DtyItemForm13
			// 
			this.DtyItemForm13.DataField = "ITEM_FORM_73";
			this.DtyItemForm13.Height = 0.1875F;
			this.DtyItemForm13.Left = 1.9375F;
			this.DtyItemForm13.Name = "DtyItemForm13";
			this.DtyItemForm13.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm13.Text = "FORMAT";
			this.DtyItemForm13.Top = 4.25F;
			this.DtyItemForm13.Visible = false;
			this.DtyItemForm13.Width = 0.4375F;
			// 
			// DtyItemForm14
			// 
			this.DtyItemForm14.DataField = "ITEM_FORM_74";
			this.DtyItemForm14.Height = 0.1875F;
			this.DtyItemForm14.Left = 1.9375F;
			this.DtyItemForm14.Name = "DtyItemForm14";
			this.DtyItemForm14.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm14.Text = "FORMAT";
			this.DtyItemForm14.Top = 4.4375F;
			this.DtyItemForm14.Visible = false;
			this.DtyItemForm14.Width = 0.4375F;
			// 
			// DtyItemForm15
			// 
			this.DtyItemForm15.DataField = "ITEM_FORM_75";
			this.DtyItemForm15.Height = 0.1875F;
			this.DtyItemForm15.Left = 1.9375F;
			this.DtyItemForm15.Name = "DtyItemForm15";
			this.DtyItemForm15.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm15.Text = "FORMAT";
			this.DtyItemForm15.Top = 4.625F;
			this.DtyItemForm15.Visible = false;
			this.DtyItemForm15.Width = 0.4375F;
			// 
			// DtyItemForm16
			// 
			this.DtyItemForm16.DataField = "ITEM_FORM_76";
			this.DtyItemForm16.Height = 0.1875F;
			this.DtyItemForm16.Left = 2.375F;
			this.DtyItemForm16.Name = "DtyItemForm16";
			this.DtyItemForm16.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm16.Text = "FORMAT";
			this.DtyItemForm16.Top = 2F;
			this.DtyItemForm16.Visible = false;
			this.DtyItemForm16.Width = 0.4375F;
			// 
			// DtyItemForm17
			// 
			this.DtyItemForm17.DataField = "ITEM_FORM_77";
			this.DtyItemForm17.Height = 0.1875F;
			this.DtyItemForm17.Left = 2.375F;
			this.DtyItemForm17.Name = "DtyItemForm17";
			this.DtyItemForm17.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm17.Text = "FORMAT";
			this.DtyItemForm17.Top = 2.1875F;
			this.DtyItemForm17.Visible = false;
			this.DtyItemForm17.Width = 0.4375F;
			// 
			// DtyItemForm18
			// 
			this.DtyItemForm18.DataField = "ITEM_FORM_78";
			this.DtyItemForm18.Height = 0.1875F;
			this.DtyItemForm18.Left = 2.375F;
			this.DtyItemForm18.Name = "DtyItemForm18";
			this.DtyItemForm18.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm18.Text = "FORMAT";
			this.DtyItemForm18.Top = 2.375F;
			this.DtyItemForm18.Visible = false;
			this.DtyItemForm18.Width = 0.4375F;
			// 
			// DtyItemForm19
			// 
			this.DtyItemForm19.DataField = "ITEM_FORM_79";
			this.DtyItemForm19.Height = 0.1875F;
			this.DtyItemForm19.Left = 2.375F;
			this.DtyItemForm19.Name = "DtyItemForm19";
			this.DtyItemForm19.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm19.Text = "FORMAT";
			this.DtyItemForm19.Top = 2.5625F;
			this.DtyItemForm19.Visible = false;
			this.DtyItemForm19.Width = 0.4375F;
			// 
			// DtyItemForm20
			// 
			this.DtyItemForm20.DataField = "ITEM_FORM_80";
			this.DtyItemForm20.Height = 0.1875F;
			this.DtyItemForm20.Left = 2.375F;
			this.DtyItemForm20.Name = "DtyItemForm20";
			this.DtyItemForm20.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm20.Text = "FORMAT";
			this.DtyItemForm20.Top = 2.75F;
			this.DtyItemForm20.Visible = false;
			this.DtyItemForm20.Width = 0.4375F;
			// 
			// DtyItemForm21
			// 
			this.DtyItemForm21.DataField = "ITEM_FORM_81";
			this.DtyItemForm21.Height = 0.1875F;
			this.DtyItemForm21.Left = 2.375F;
			this.DtyItemForm21.Name = "DtyItemForm21";
			this.DtyItemForm21.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm21.Text = "FORMAT";
			this.DtyItemForm21.Top = 2.9375F;
			this.DtyItemForm21.Visible = false;
			this.DtyItemForm21.Width = 0.4375F;
			// 
			// DtyItemForm22
			// 
			this.DtyItemForm22.DataField = "ITEM_FORM_82";
			this.DtyItemForm22.Height = 0.1875F;
			this.DtyItemForm22.Left = 2.375F;
			this.DtyItemForm22.Name = "DtyItemForm22";
			this.DtyItemForm22.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm22.Text = "FORMAT";
			this.DtyItemForm22.Top = 3.125F;
			this.DtyItemForm22.Visible = false;
			this.DtyItemForm22.Width = 0.4375F;
			// 
			// DtyItemForm23
			// 
			this.DtyItemForm23.DataField = "ITEM_FORM_83";
			this.DtyItemForm23.Height = 0.1875F;
			this.DtyItemForm23.Left = 2.375F;
			this.DtyItemForm23.Name = "DtyItemForm23";
			this.DtyItemForm23.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm23.Text = "FORMAT";
			this.DtyItemForm23.Top = 3.3125F;
			this.DtyItemForm23.Visible = false;
			this.DtyItemForm23.Width = 0.4375F;
			// 
			// DtyItemForm24
			// 
			this.DtyItemForm24.DataField = "ITEM_FORM_84";
			this.DtyItemForm24.Height = 0.1875F;
			this.DtyItemForm24.Left = 2.375F;
			this.DtyItemForm24.Name = "DtyItemForm24";
			this.DtyItemForm24.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm24.Text = "FORMAT";
			this.DtyItemForm24.Top = 3.5F;
			this.DtyItemForm24.Visible = false;
			this.DtyItemForm24.Width = 0.4375F;
			// 
			// DtyItemForm25
			// 
			this.DtyItemForm25.DataField = "ITEM_FORM_85";
			this.DtyItemForm25.Height = 0.1875F;
			this.DtyItemForm25.Left = 2.375F;
			this.DtyItemForm25.Name = "DtyItemForm25";
			this.DtyItemForm25.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm25.Text = "FORMAT";
			this.DtyItemForm25.Top = 3.6875F;
			this.DtyItemForm25.Visible = false;
			this.DtyItemForm25.Width = 0.4375F;
			// 
			// DtyItemForm26
			// 
			this.DtyItemForm26.DataField = "ITEM_FORM_86";
			this.DtyItemForm26.Height = 0.1875F;
			this.DtyItemForm26.Left = 2.375F;
			this.DtyItemForm26.Name = "DtyItemForm26";
			this.DtyItemForm26.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm26.Text = "FORMAT";
			this.DtyItemForm26.Top = 3.875F;
			this.DtyItemForm26.Visible = false;
			this.DtyItemForm26.Width = 0.4375F;
			// 
			// DtyItemForm27
			// 
			this.DtyItemForm27.DataField = "ITEM_FORM_87";
			this.DtyItemForm27.Height = 0.1875F;
			this.DtyItemForm27.Left = 2.375F;
			this.DtyItemForm27.Name = "DtyItemForm27";
			this.DtyItemForm27.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm27.Text = "FORMAT";
			this.DtyItemForm27.Top = 4.0625F;
			this.DtyItemForm27.Visible = false;
			this.DtyItemForm27.Width = 0.4375F;
			// 
			// DtyItemForm28
			// 
			this.DtyItemForm28.DataField = "ITEM_FORM_88";
			this.DtyItemForm28.Height = 0.1875F;
			this.DtyItemForm28.Left = 2.375F;
			this.DtyItemForm28.Name = "DtyItemForm28";
			this.DtyItemForm28.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm28.Text = "FORMAT";
			this.DtyItemForm28.Top = 4.25F;
			this.DtyItemForm28.Visible = false;
			this.DtyItemForm28.Width = 0.4375F;
			// 
			// DtyItemForm29
			// 
			this.DtyItemForm29.DataField = "ITEM_FORM_89";
			this.DtyItemForm29.Height = 0.1875F;
			this.DtyItemForm29.Left = 2.375F;
			this.DtyItemForm29.Name = "DtyItemForm29";
			this.DtyItemForm29.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm29.Text = "FORMAT";
			this.DtyItemForm29.Top = 4.4375F;
			this.DtyItemForm29.Visible = false;
			this.DtyItemForm29.Width = 0.4375F;
			// 
			// DtyItemForm30
			// 
			this.DtyItemForm30.DataField = "ITEM_FORM_90";
			this.DtyItemForm30.Height = 0.1875F;
			this.DtyItemForm30.Left = 2.375F;
			this.DtyItemForm30.Name = "DtyItemForm30";
			this.DtyItemForm30.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.DtyItemForm30.Text = "FORMAT";
			this.DtyItemForm30.Top = 4.625F;
			this.DtyItemForm30.Visible = false;
			this.DtyItemForm30.Width = 0.4375F;
			// 
			// CashPaymntAmtForm
			// 
			this.CashPaymntAmtForm.DataField = "ITEM_FORM_91";
			this.CashPaymntAmtForm.Height = 0.1875F;
			this.CashPaymntAmtForm.Left = 2.875F;
			this.CashPaymntAmtForm.Name = "CashPaymntAmtForm";
			this.CashPaymntAmtForm.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.CashPaymntAmtForm.Text = "FORMAT";
			this.CashPaymntAmtForm.Top = 2F;
			this.CashPaymntAmtForm.Visible = false;
			this.CashPaymntAmtForm.Width = 0.4375F;
			// 
			// SlryPaymntYMD
			// 
			this.SlryPaymntYMD.DataField = "SLRY_PAYMNT_YMD";
			this.SlryPaymntYMD.Height = 0.1875F;
			this.SlryPaymntYMD.Left = 5.3125F;
			this.SlryPaymntYMD.Name = "SlryPaymntYMD";
			this.SlryPaymntYMD.Style = "font-size: 9.75pt; vertical-align: middle";
			this.SlryPaymntYMD.Text = "平成00年00月00日";
			this.SlryPaymntYMD.Top = 0.375F;
			this.SlryPaymntYMD.Width = 1.3125F;
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.DataField = "EMP_CODE";
			this.GroupHeader1.Height = 0F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.Format += new System.EventHandler(this.GroupHeader1_Format);
			this.GroupHeader1.AfterPrint += new System.EventHandler(this.GroupHeader1_AfterPrint);
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// HR_PY_03_R61
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0F;
			this.PageSettings.Margins.Left = 0.5F;
			this.PageSettings.Margins.Right = 0.4F;
			this.PageSettings.Margins.Top = 0F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.268056F;
			this.PrintWidth = 10.65F;
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R61_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyCompName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYear2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Title2Label)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemName25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemValue25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBankName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemitBranchName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit1RemitAmt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit2RemitAmt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remit3RemitAmt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyCompName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntMonth2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaySlipComment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemName29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemValue29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemName30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemValue30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryItemForm30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DedItemForm30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DtyItemForm30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CashPaymntAmtForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryPaymntYMD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
