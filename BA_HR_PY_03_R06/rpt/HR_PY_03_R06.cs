// Product     : GRANDIT
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R06.cs
// 機能名      : HR_PY_03_R06 給与支給明細書（ヒサゴ）
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号B13181 2005/01/14 給与明細コメント欄追加
// 1.3.2 2005/03/31
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 K23028 2009/10/27 労働基準法改正対応
// 管理番号 B23522 2010/05/18 環境によって帳票出力されない場合がある不具合
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
	public class HR_PY_03_R06 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R06()
		{


			InitializeComponent();
		}
		#region Protected Fields
		protected string title;
		protected string companyName;
		protected CommonData cd;
// 管理番号 K23028 From
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox TaxType;
		private TextBox HandiType;
		private TextBox WidowType;
		private TextBox WrkStdType;
		private TextBox DpndTotalNum;
		private Line line3;
		private Line line4;
		private Line line5;
		private Line line6;
		private Line line7;
		private Line line8;
		private Line line17;
		private Line line18;
		private Line line19;
		private TextBox ItemName80;
		private TextBox ItemValue81;
		private TextBox ItemValue80;
		private TextBox ItemName81;
		private TextBox ItemForm80;
		private TextBox ItemForm81;
		private TextBox SlryRemitBankCode1;
		private TextBox SlryRemitBranchCode1;
		private TextBox SlryAcCode1;
		private TextBox SlryRemitBankCode2;
		private TextBox SlryRemitBranchCode2;
		private TextBox SlryAcCode2;
		private TextBox MycompName;
// 管理番号 K23028 To
// 管理番号 B13181 From
		protected string flg;
// 管理番号 B13181 To

		#endregion
		#region Properties
		public string Title
		{
			get { return title; }
			set { title = value; }
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
// 管理番号 B13181 From		
		public string Flg
		{
			get { return flg; }
			set { flg = value; }
		}
// 管理番号 B13181 To	

		#endregion

		private void HR_PY_03_R06_ReportStart(object sender, System.EventArgs eArgs)
		{
//			//仮想プリンタの設定
//			this.Document.Printer.PrinterName="";
//　		// 用紙サイズ:連帳
//　		this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
//			// 用紙方向:縦
//　		this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			this.PrintWidth = this.PageSettings.PaperWidth - (this.PageSettings.Margins.Left + this.PageSettings.Margins.Right);
//　			// 用紙方向:縦
//　			this.PageSettings.Orientation　
//				= GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
// 管理番号B23522 From
			// 用紙サイズ:
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			// 用紙方向:縦
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
// 管理番号B23522 To
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			TitleText.Text = title;
// 管理番号 B13181 From
			//積立有給を使用しない場合は印字しない
			if (flg == "0")
			{
				ItemValue79.Visible = false;
				ItemForm79.Visible = false;
				ItemName79.Visible = false;
			}
// 管理番号 B13181 To
		}

		private void GroupHeader1_AfterPrint(object sender, System.EventArgs eArgs)
		{
			ItemValue1.OutputFormat = ItemForm1.Text;
			ItemValue2.OutputFormat = ItemForm2.Text;
			ItemValue3.OutputFormat = ItemForm3.Text;
			ItemValue4.OutputFormat = ItemForm4.Text;
			ItemValue5.OutputFormat = ItemForm5.Text;
			ItemValue6.OutputFormat = ItemForm6.Text;
			ItemValue7.OutputFormat = ItemForm7.Text;
			ItemValue8.OutputFormat = ItemForm8.Text;
			ItemValue9.OutputFormat = ItemForm9.Text;
			ItemValue10.OutputFormat = ItemForm10.Text;
			ItemValue11.OutputFormat = ItemForm11.Text;
			ItemValue12.OutputFormat = ItemForm12.Text;
			ItemValue13.OutputFormat = ItemForm13.Text;
			ItemValue14.OutputFormat = ItemForm14.Text;
			ItemValue15.OutputFormat = ItemForm15.Text;
			ItemValue16.OutputFormat = ItemForm16.Text;
			ItemValue17.OutputFormat = ItemForm17.Text;
			ItemValue18.OutputFormat = ItemForm18.Text;
			ItemValue19.OutputFormat = ItemForm19.Text;
			ItemValue20.OutputFormat = ItemForm20.Text;
			ItemValue21.OutputFormat = ItemForm21.Text;
			ItemValue22.OutputFormat = ItemForm22.Text;
			ItemValue23.OutputFormat = ItemForm23.Text;
			ItemValue24.OutputFormat = ItemForm24.Text;
			ItemValue25.OutputFormat = ItemForm25.Text;
			ItemValue26.OutputFormat = ItemForm26.Text;
			ItemValue27.OutputFormat = ItemForm27.Text;
			ItemValue28.OutputFormat = ItemForm28.Text;
			ItemValue29.OutputFormat = ItemForm29.Text;
			ItemValue30.OutputFormat = ItemForm30.Text;
			ItemValue31.OutputFormat = ItemForm31.Text;
			ItemValue32.OutputFormat = ItemForm32.Text;
			ItemValue33.OutputFormat = ItemForm33.Text;
			ItemValue34.OutputFormat = ItemForm34.Text;
			ItemValue35.OutputFormat = ItemForm35.Text;
			ItemValue36.OutputFormat = ItemForm36.Text;
			ItemValue37.OutputFormat = ItemForm37.Text;
			ItemValue38.OutputFormat = ItemForm38.Text;
			ItemValue39.OutputFormat = ItemForm39.Text;
			ItemValue40.OutputFormat = ItemForm40.Text;
			ItemValue41.OutputFormat = ItemForm41.Text;
			ItemValue42.OutputFormat = ItemForm42.Text;
			ItemValue43.OutputFormat = ItemForm43.Text;
			ItemValue44.OutputFormat = ItemForm44.Text;
			ItemValue45.OutputFormat = ItemForm45.Text;
			ItemValue46.OutputFormat = ItemForm46.Text;
			ItemValue47.OutputFormat = ItemForm47.Text;
			ItemValue48.OutputFormat = ItemForm48.Text;
			ItemValue49.OutputFormat = ItemForm49.Text;
			ItemValue50.OutputFormat = ItemForm50.Text;
			ItemValue51.OutputFormat = ItemForm51.Text;
			ItemValue52.OutputFormat = ItemForm52.Text;
			ItemValue53.OutputFormat = ItemForm53.Text;
			ItemValue54.OutputFormat = ItemForm54.Text;
			ItemValue55.OutputFormat = ItemForm55.Text;
			ItemValue56.OutputFormat = ItemForm56.Text;
			ItemValue57.OutputFormat = ItemForm57.Text;
			ItemValue58.OutputFormat = ItemForm58.Text;
			ItemValue59.OutputFormat = ItemForm59.Text;
			ItemValue60.OutputFormat = ItemForm60.Text;
			ItemValue61.OutputFormat = ItemForm61.Text;
			ItemValue62.OutputFormat = ItemForm62.Text;
			ItemValue63.OutputFormat = ItemForm63.Text;
			ItemValue64.OutputFormat = ItemForm64.Text;
			ItemValue65.OutputFormat = ItemForm65.Text;
			ItemValue66.OutputFormat = ItemForm66.Text;
			ItemValue67.OutputFormat = ItemForm67.Text;
			ItemValue68.OutputFormat = ItemForm68.Text;
			ItemValue69.OutputFormat = ItemForm69.Text;
			ItemValue70.OutputFormat = ItemForm70.Text;
			ItemValue71.OutputFormat = ItemForm71.Text;
			ItemValue72.OutputFormat = ItemForm72.Text;
			ItemValue73.OutputFormat = ItemForm73.Text;
			ItemValue74.OutputFormat = ItemForm74.Text;
			ItemValue75.OutputFormat = ItemForm75.Text;
			ItemValue76.OutputFormat = ItemForm76.Text;
			ItemValue77.OutputFormat = ItemForm77.Text;
// 管理番号 B13181 From
			ItemValue78.OutputFormat = ItemForm78.Text;
			ItemValue79.OutputFormat = ItemForm79.Text;
// 管理番号 B13181 To
// 管理番号 K23028 From
			ItemValue80.OutputFormat = ItemForm80.Text;
			ItemValue81.OutputFormat = ItemForm81.Text;
// 管理番号 K23028 To
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCode = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpName = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TitleText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName31 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue31 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName34 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue34 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName37 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue37 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName39 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue39 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName40 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue40 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName43 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue43 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue45 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName45 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName46 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue46 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName49 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue49 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName50 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue50 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName51 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue51 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName52 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue52 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName53 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue53 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue54 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName54 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName55 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue55 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName57 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue57 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName58 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue58 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName59 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue59 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName60 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue60 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName61 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue61 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName62 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue62 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue63 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName63 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName64 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue64 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName65 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue65 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName66 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue66 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName67 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue67 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName68 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue68 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName69 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue69 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName70 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue70 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName71 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue71 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue72 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName72 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName74 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue74 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName75 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue75 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName76 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue76 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue77 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName77 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm31 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm22 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm29 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm34 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm37 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm39 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm40 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm43 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm45 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm46 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm49 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm50 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm51 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm52 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm53 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm54 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm55 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm57 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm58 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm59 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm60 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm61 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm62 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm63 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm64 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm65 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm66 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm67 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm68 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm69 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm70 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm71 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm72 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm74 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm75 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm76 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm77 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PaymntYm = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BnsDate = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName78 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue78 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemName79 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemValue79 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm78 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemForm79 = null;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R06));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.AtacCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TitleText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName31 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue31 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName32 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue32 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName33 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue33 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName34 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue34 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName35 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue35 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue36 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName36 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName37 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue37 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName38 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue38 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName39 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue39 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName40 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue40 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName41 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue41 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName42 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue42 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName43 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue43 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName44 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue44 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue45 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName45 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName46 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue46 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName47 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue47 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName48 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue48 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName49 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue49 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName50 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue50 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName51 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue51 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName52 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue52 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName53 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue53 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue54 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName54 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName55 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue55 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName56 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue56 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName57 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue57 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName58 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue58 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName59 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue59 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName60 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue60 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName61 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue61 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName62 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue62 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue63 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName63 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName64 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue64 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName65 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue65 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName66 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue66 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName67 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue67 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName68 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue68 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName69 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue69 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName70 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue70 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName71 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue71 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue72 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName72 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName73 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue73 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName74 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue74 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName75 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue75 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName76 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue76 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue77 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName77 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm31 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm32 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm33 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm34 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm35 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm36 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm37 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm38 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm39 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm40 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm41 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm42 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm43 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm44 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm45 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm46 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm47 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm48 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm49 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm50 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm51 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm52 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm53 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm54 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm55 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm56 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm57 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm58 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm59 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm60 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm61 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm62 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm63 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm64 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm65 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm66 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm67 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm68 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm69 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm70 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm71 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm72 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm73 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm74 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm75 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm76 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm77 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PaymntYm = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BnsDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName78 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue78 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName79 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue79 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm78 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm79 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TaxType = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HandiType = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WidowType = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WrkStdType = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndTotalNum = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line17 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line18 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line19 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.ItemName80 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue81 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemValue80 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemName81 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm80 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemForm81 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryRemitBankCode1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryRemitBranchCode1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryAcCode1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryRemitBankCode2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryRemitBranchCode2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SlryAcCode2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MycompName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BnsDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WidowType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WrkStdType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndTotalNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBankCode1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBranchCode1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryAcCode1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBankCode2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBranchCode2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryAcCode2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MycompName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.AtacCode,
            this.EmpCode,
            this.EmpName,
            this.TitleText,
            this.ItemName1,
            this.ItemValue1,
            this.ItemName2,
            this.ItemValue2,
            this.ItemName3,
            this.ItemValue3,
            this.ItemName4,
            this.ItemValue4,
            this.ItemName5,
            this.ItemValue5,
            this.ItemName6,
            this.ItemValue6,
            this.ItemName7,
            this.ItemValue7,
            this.ItemName8,
            this.ItemValue8,
            this.ItemValue9,
            this.ItemName9,
            this.ItemName10,
            this.ItemValue10,
            this.ItemName11,
            this.ItemValue11,
            this.ItemName12,
            this.ItemValue12,
            this.ItemName13,
            this.ItemValue13,
            this.ItemName14,
            this.ItemValue14,
            this.ItemName15,
            this.ItemValue15,
            this.ItemName16,
            this.ItemValue16,
            this.ItemName17,
            this.ItemValue17,
            this.ItemValue18,
            this.ItemName18,
            this.ItemName19,
            this.ItemValue19,
            this.ItemName20,
            this.ItemValue20,
            this.ItemName21,
            this.ItemValue21,
            this.TextBox27,
            this.ItemValue22,
            this.ItemName23,
            this.ItemValue23,
            this.ItemName24,
            this.ItemValue24,
            this.ItemName25,
            this.ItemValue25,
            this.ItemName26,
            this.ItemValue26,
            this.ItemValue27,
            this.ItemName27,
            this.ItemName28,
            this.ItemValue28,
            this.ItemName29,
            this.ItemValue29,
            this.ItemName30,
            this.ItemValue30,
            this.ItemName31,
            this.ItemValue31,
            this.ItemName32,
            this.ItemValue32,
            this.ItemName33,
            this.ItemValue33,
            this.ItemName34,
            this.ItemValue34,
            this.ItemName35,
            this.ItemValue35,
            this.ItemValue36,
            this.ItemName36,
            this.ItemName37,
            this.ItemValue37,
            this.ItemName38,
            this.ItemValue38,
            this.ItemName39,
            this.ItemValue39,
            this.ItemName40,
            this.ItemValue40,
            this.ItemName41,
            this.ItemValue41,
            this.ItemName42,
            this.ItemValue42,
            this.ItemName43,
            this.ItemValue43,
            this.ItemName44,
            this.ItemValue44,
            this.ItemValue45,
            this.ItemName45,
            this.ItemName46,
            this.ItemValue46,
            this.ItemName47,
            this.ItemValue47,
            this.ItemName48,
            this.ItemValue48,
            this.ItemName49,
            this.ItemValue49,
            this.ItemName50,
            this.ItemValue50,
            this.ItemName51,
            this.ItemValue51,
            this.ItemName52,
            this.ItemValue52,
            this.ItemName53,
            this.ItemValue53,
            this.ItemValue54,
            this.ItemName54,
            this.ItemName55,
            this.ItemValue55,
            this.ItemName56,
            this.ItemValue56,
            this.ItemName57,
            this.ItemValue57,
            this.ItemName58,
            this.ItemValue58,
            this.ItemName59,
            this.ItemValue59,
            this.ItemName60,
            this.ItemValue60,
            this.ItemName61,
            this.ItemValue61,
            this.ItemName62,
            this.ItemValue62,
            this.ItemValue63,
            this.ItemName63,
            this.ItemName64,
            this.ItemValue64,
            this.ItemName65,
            this.ItemValue65,
            this.ItemName66,
            this.ItemValue66,
            this.ItemName67,
            this.ItemValue67,
            this.ItemName68,
            this.ItemValue68,
            this.ItemName69,
            this.ItemValue69,
            this.ItemName70,
            this.ItemValue70,
            this.ItemName71,
            this.ItemValue71,
            this.ItemValue72,
            this.ItemName72,
            this.ItemName73,
            this.ItemValue73,
            this.ItemName74,
            this.ItemValue74,
            this.ItemName75,
            this.ItemValue75,
            this.ItemName76,
            this.ItemValue76,
            this.ItemValue77,
            this.ItemName77,
            this.ItemForm1,
            this.ItemForm2,
            this.ItemForm3,
            this.ItemForm4,
            this.ItemForm5,
            this.ItemForm6,
            this.ItemForm7,
            this.ItemForm8,
            this.ItemForm9,
            this.ItemForm10,
            this.ItemForm11,
            this.ItemForm12,
            this.ItemForm13,
            this.ItemForm14,
            this.ItemForm15,
            this.ItemForm16,
            this.ItemForm17,
            this.ItemForm18,
            this.ItemForm19,
            this.ItemForm20,
            this.ItemForm31,
            this.ItemForm22,
            this.ItemForm23,
            this.ItemForm24,
            this.ItemForm25,
            this.ItemForm26,
            this.ItemForm27,
            this.ItemForm28,
            this.ItemForm29,
            this.ItemForm30,
            this.ItemForm21,
            this.ItemForm32,
            this.ItemForm33,
            this.ItemForm34,
            this.ItemForm35,
            this.ItemForm36,
            this.ItemForm37,
            this.ItemForm38,
            this.ItemForm39,
            this.ItemForm40,
            this.ItemForm41,
            this.ItemForm42,
            this.ItemForm43,
            this.ItemForm44,
            this.ItemForm45,
            this.ItemForm46,
            this.ItemForm47,
            this.ItemForm48,
            this.ItemForm49,
            this.ItemForm50,
            this.ItemForm51,
            this.ItemForm52,
            this.ItemForm53,
            this.ItemForm54,
            this.ItemForm55,
            this.ItemForm56,
            this.ItemForm57,
            this.ItemForm58,
            this.ItemForm59,
            this.ItemForm60,
            this.ItemForm61,
            this.ItemForm62,
            this.ItemForm63,
            this.ItemForm64,
            this.ItemForm65,
            this.ItemForm66,
            this.ItemForm67,
            this.ItemForm68,
            this.ItemForm69,
            this.ItemForm70,
            this.ItemForm71,
            this.ItemForm72,
            this.ItemForm73,
            this.ItemForm74,
            this.ItemForm75,
            this.ItemForm76,
            this.ItemForm77,
            this.Label1,
            this.PaymntYm,
            this.BnsDate,
            this.ItemName78,
            this.ItemValue78,
            this.ItemName79,
            this.ItemValue79,
            this.ItemForm78,
            this.ItemForm79,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.TaxType,
            this.HandiType,
            this.WidowType,
            this.WrkStdType,
            this.DpndTotalNum,
            this.line3,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line17,
            this.line18,
            this.line19,
            this.ItemName80,
            this.ItemValue81,
            this.ItemValue80,
            this.ItemName81,
            this.ItemForm80,
            this.ItemForm81,
            this.SlryRemitBankCode1,
            this.SlryRemitBranchCode1,
            this.SlryAcCode1,
            this.SlryRemitBankCode2,
            this.SlryRemitBranchCode2,
            this.SlryAcCode2,
            this.MycompName});
			this.Detail.Height = 5F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// AtacCode
			// 
			this.AtacCode.DataField = "ATAC_CODE";
			this.AtacCode.Height = 0.15F;
			this.AtacCode.Left = 0.8125F;
			this.AtacCode.Name = "AtacCode";
			this.AtacCode.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.AtacCode.Text = "ZZZZZZZZZZ";
			this.AtacCode.Top = 0.7F;
			this.AtacCode.Width = 0.75F;
			// 
			// EmpCode
			// 
			this.EmpCode.DataField = "EMP_CODE";
			this.EmpCode.Height = 0.15F;
			this.EmpCode.Left = 1.8125F;
			this.EmpCode.Name = "EmpCode";
			this.EmpCode.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.EmpCode.Text = "ZZZZZZZZZZ";
			this.EmpCode.Top = 0.7F;
			this.EmpCode.Width = 0.75F;
			// 
			// EmpName
			// 
			this.EmpName.DataField = "EMP_NAME";
			this.EmpName.Height = 0.15F;
			this.EmpName.Left = 2.8125F;
			this.EmpName.Name = "EmpName";
			this.EmpName.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.EmpName.Text = "あいうえおかきくけこさしすせそ";
			this.EmpName.Top = 0.7F;
			this.EmpName.Width = 2.063F;
			// 
			// TitleText
			// 
			this.TitleText.Height = 0.2175F;
			this.TitleText.Left = 5.125F;
			this.TitleText.Name = "TitleText";
			this.TitleText.Style = "font-size: 14.25pt";
			this.TitleText.Text = "給与支給";
			this.TitleText.Top = 0.3125F;
			this.TitleText.Width = 1.0625F;
			// 
			// ItemName1
			// 
			this.ItemName1.DataField = "ITEM_NAME_1";
			this.ItemName1.Height = 0.15F;
			this.ItemName1.Left = 1.0325F;
			this.ItemName1.Name = "ItemName1";
			this.ItemName1.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName1.Text = "あいうえおかきく";
			this.ItemName1.Top = 1.035F;
			this.ItemName1.Width = 0.95F;
			// 
			// ItemValue1
			// 
			this.ItemValue1.DataField = "ITEM_VALUE_1";
			this.ItemValue1.Height = 0.15F;
			this.ItemValue1.Left = 1.0325F;
			this.ItemValue1.Name = "ItemValue1";
			this.ItemValue1.OutputFormat = "#,##0.000";
			this.ItemValue1.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue1.Text = "99,999,999.999";
			this.ItemValue1.Top = 1.2F;
			this.ItemValue1.Width = 0.88F;
			// 
			// ItemName2
			// 
			this.ItemName2.DataField = "ITEM_NAME_2";
			this.ItemName2.Height = 0.15F;
			this.ItemName2.Left = 1.9305F;
			this.ItemName2.Name = "ItemName2";
			this.ItemName2.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName2.Text = "あいうえおかきく";
			this.ItemName2.Top = 1.035F;
			this.ItemName2.Width = 0.95F;
			// 
			// ItemValue2
			// 
			this.ItemValue2.DataField = "ITEM_VALUE_2";
			this.ItemValue2.Height = 0.15F;
			this.ItemValue2.Left = 1.9305F;
			this.ItemValue2.Name = "ItemValue2";
			this.ItemValue2.OutputFormat = "#,##0.000";
			this.ItemValue2.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue2.Text = "99,999,999.999";
			this.ItemValue2.Top = 1.2F;
			this.ItemValue2.Width = 0.88F;
			// 
			// ItemName3
			// 
			this.ItemName3.DataField = "ITEM_NAME_3";
			this.ItemName3.Height = 0.15F;
			this.ItemName3.Left = 2.829F;
			this.ItemName3.Name = "ItemName3";
			this.ItemName3.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName3.Text = "あいうえおかきく";
			this.ItemName3.Top = 1.035F;
			this.ItemName3.Width = 0.95F;
			// 
			// ItemValue3
			// 
			this.ItemValue3.DataField = "ITEM_VALUE_3";
			this.ItemValue3.Height = 0.15F;
			this.ItemValue3.Left = 2.829F;
			this.ItemValue3.Name = "ItemValue3";
			this.ItemValue3.OutputFormat = "#,##0.000";
			this.ItemValue3.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue3.Text = "99,999,999.999";
			this.ItemValue3.Top = 1.2F;
			this.ItemValue3.Width = 0.88F;
			// 
			// ItemName4
			// 
			this.ItemName4.DataField = "ITEM_NAME_4";
			this.ItemName4.Height = 0.15F;
			this.ItemName4.Left = 3.727F;
			this.ItemName4.Name = "ItemName4";
			this.ItemName4.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName4.Text = "あいうえおかきく";
			this.ItemName4.Top = 1.035F;
			this.ItemName4.Width = 0.95F;
			// 
			// ItemValue4
			// 
			this.ItemValue4.DataField = "ITEM_VALUE_4";
			this.ItemValue4.Height = 0.15F;
			this.ItemValue4.Left = 3.727F;
			this.ItemValue4.Name = "ItemValue4";
			this.ItemValue4.OutputFormat = "#,##0.000";
			this.ItemValue4.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue4.Text = "99,999,999.999";
			this.ItemValue4.Top = 1.2F;
			this.ItemValue4.Width = 0.88F;
			// 
			// ItemName5
			// 
			this.ItemName5.DataField = "ITEM_NAME_5";
			this.ItemName5.Height = 0.15F;
			this.ItemName5.Left = 4.625F;
			this.ItemName5.Name = "ItemName5";
			this.ItemName5.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName5.Text = "あいうえおかきく";
			this.ItemName5.Top = 1.035F;
			this.ItemName5.Width = 0.95F;
			// 
			// ItemValue5
			// 
			this.ItemValue5.DataField = "ITEM_VALUE_5";
			this.ItemValue5.Height = 0.15F;
			this.ItemValue5.Left = 4.625F;
			this.ItemValue5.Name = "ItemValue5";
			this.ItemValue5.OutputFormat = "#,##0.000";
			this.ItemValue5.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue5.Text = "99,999,999.999";
			this.ItemValue5.Top = 1.2F;
			this.ItemValue5.Width = 0.88F;
			// 
			// ItemName6
			// 
			this.ItemName6.DataField = "ITEM_NAME_6";
			this.ItemName6.Height = 0.15F;
			this.ItemName6.Left = 5.523F;
			this.ItemName6.Name = "ItemName6";
			this.ItemName6.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName6.Text = "あいうえおかきく";
			this.ItemName6.Top = 1.035F;
			this.ItemName6.Width = 0.95F;
			// 
			// ItemValue6
			// 
			this.ItemValue6.DataField = "ITEM_VALUE_6";
			this.ItemValue6.Height = 0.15F;
			this.ItemValue6.Left = 5.523F;
			this.ItemValue6.Name = "ItemValue6";
			this.ItemValue6.OutputFormat = "#,##0.000";
			this.ItemValue6.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue6.Text = "99,999,999.999";
			this.ItemValue6.Top = 1.2F;
			this.ItemValue6.Width = 0.88F;
			// 
			// ItemName7
			// 
			this.ItemName7.DataField = "ITEM_NAME_7";
			this.ItemName7.Height = 0.15F;
			this.ItemName7.Left = 6.421F;
			this.ItemName7.Name = "ItemName7";
			this.ItemName7.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName7.Text = "あいうえおかきく";
			this.ItemName7.Top = 1.035F;
			this.ItemName7.Width = 0.95F;
			// 
			// ItemValue7
			// 
			this.ItemValue7.DataField = "ITEM_VALUE_7";
			this.ItemValue7.Height = 0.15F;
			this.ItemValue7.Left = 6.421F;
			this.ItemValue7.Name = "ItemValue7";
			this.ItemValue7.OutputFormat = "#,##0.000";
			this.ItemValue7.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue7.Text = "99,999,999.999";
			this.ItemValue7.Top = 1.2F;
			this.ItemValue7.Width = 0.88F;
			// 
			// ItemName8
			// 
			this.ItemName8.DataField = "ITEM_NAME_8";
			this.ItemName8.Height = 0.15F;
			this.ItemName8.Left = 7.319F;
			this.ItemName8.Name = "ItemName8";
			this.ItemName8.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName8.Text = "あいうえおかきく";
			this.ItemName8.Top = 1.035F;
			this.ItemName8.Width = 0.95F;
			// 
			// ItemValue8
			// 
			this.ItemValue8.DataField = "ITEM_VALUE_8";
			this.ItemValue8.Height = 0.15F;
			this.ItemValue8.Left = 7.319F;
			this.ItemValue8.Name = "ItemValue8";
			this.ItemValue8.OutputFormat = "#,##0.000";
			this.ItemValue8.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue8.Text = "99,999,999.999";
			this.ItemValue8.Top = 1.2F;
			this.ItemValue8.Width = 0.88F;
			// 
			// ItemValue9
			// 
			this.ItemValue9.DataField = "ITEM_VALUE_9";
			this.ItemValue9.Height = 0.15F;
			this.ItemValue9.Left = 8.217F;
			this.ItemValue9.Name = "ItemValue9";
			this.ItemValue9.OutputFormat = "#,##0.000";
			this.ItemValue9.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue9.Text = "99,999,999.999";
			this.ItemValue9.Top = 1.2F;
			this.ItemValue9.Width = 0.88F;
			// 
			// ItemName9
			// 
			this.ItemName9.DataField = "ITEM_NAME_9";
			this.ItemName9.Height = 0.15F;
			this.ItemName9.Left = 8.217F;
			this.ItemName9.Name = "ItemName9";
			this.ItemName9.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName9.Text = "あいうえおかきく";
			this.ItemName9.Top = 1.035F;
			this.ItemName9.Width = 0.95F;
			// 
			// ItemName10
			// 
			this.ItemName10.DataField = "ITEM_NAME_10";
			this.ItemName10.Height = 0.15F;
			this.ItemName10.Left = 1.0325F;
			this.ItemName10.Name = "ItemName10";
			this.ItemName10.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName10.Text = "あいうえおかきく";
			this.ItemName10.Top = 1.365F;
			this.ItemName10.Width = 0.95F;
			// 
			// ItemValue10
			// 
			this.ItemValue10.DataField = "ITEM_VALUE_10";
			this.ItemValue10.Height = 0.15F;
			this.ItemValue10.Left = 1.0325F;
			this.ItemValue10.Name = "ItemValue10";
			this.ItemValue10.OutputFormat = "#,##0.000";
			this.ItemValue10.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue10.Text = "99,999,999.999";
			this.ItemValue10.Top = 1.53F;
			this.ItemValue10.Width = 0.88F;
			// 
			// ItemName11
			// 
			this.ItemName11.DataField = "ITEM_NAME_11";
			this.ItemName11.Height = 0.15F;
			this.ItemName11.Left = 1.9305F;
			this.ItemName11.Name = "ItemName11";
			this.ItemName11.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName11.Text = "あいうえおかきく";
			this.ItemName11.Top = 1.365F;
			this.ItemName11.Width = 0.95F;
			// 
			// ItemValue11
			// 
			this.ItemValue11.DataField = "ITEM_VALUE_11";
			this.ItemValue11.Height = 0.15F;
			this.ItemValue11.Left = 1.9305F;
			this.ItemValue11.Name = "ItemValue11";
			this.ItemValue11.OutputFormat = "#,##0.000";
			this.ItemValue11.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue11.Text = "99,999,999.999";
			this.ItemValue11.Top = 1.53F;
			this.ItemValue11.Width = 0.88F;
			// 
			// ItemName12
			// 
			this.ItemName12.DataField = "ITEM_NAME_12";
			this.ItemName12.Height = 0.15F;
			this.ItemName12.Left = 2.829F;
			this.ItemName12.Name = "ItemName12";
			this.ItemName12.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName12.Text = "あいうえおかきく";
			this.ItemName12.Top = 1.365F;
			this.ItemName12.Width = 0.95F;
			// 
			// ItemValue12
			// 
			this.ItemValue12.DataField = "ITEM_VALUE_12";
			this.ItemValue12.Height = 0.15F;
			this.ItemValue12.Left = 2.829F;
			this.ItemValue12.Name = "ItemValue12";
			this.ItemValue12.OutputFormat = "#,##0.000";
			this.ItemValue12.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue12.Text = "99,999,999.999";
			this.ItemValue12.Top = 1.53F;
			this.ItemValue12.Width = 0.88F;
			// 
			// ItemName13
			// 
			this.ItemName13.DataField = "ITEM_NAME_13";
			this.ItemName13.Height = 0.15F;
			this.ItemName13.Left = 3.727F;
			this.ItemName13.Name = "ItemName13";
			this.ItemName13.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName13.Text = "あいうえおかきく";
			this.ItemName13.Top = 1.365F;
			this.ItemName13.Width = 0.95F;
			// 
			// ItemValue13
			// 
			this.ItemValue13.DataField = "ITEM_VALUE_13";
			this.ItemValue13.Height = 0.15F;
			this.ItemValue13.Left = 3.727F;
			this.ItemValue13.Name = "ItemValue13";
			this.ItemValue13.OutputFormat = "#,##0.000";
			this.ItemValue13.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue13.Text = "99,999,999.999";
			this.ItemValue13.Top = 1.53F;
			this.ItemValue13.Width = 0.88F;
			// 
			// ItemName14
			// 
			this.ItemName14.DataField = "ITEM_NAME_14";
			this.ItemName14.Height = 0.15F;
			this.ItemName14.Left = 4.625F;
			this.ItemName14.Name = "ItemName14";
			this.ItemName14.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName14.Text = "あいうえおかきく";
			this.ItemName14.Top = 1.365F;
			this.ItemName14.Width = 0.95F;
			// 
			// ItemValue14
			// 
			this.ItemValue14.DataField = "ITEM_VALUE_14";
			this.ItemValue14.Height = 0.15F;
			this.ItemValue14.Left = 4.625F;
			this.ItemValue14.Name = "ItemValue14";
			this.ItemValue14.OutputFormat = "#,##0.000";
			this.ItemValue14.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue14.Text = "99,999,999.999";
			this.ItemValue14.Top = 1.53F;
			this.ItemValue14.Width = 0.88F;
			// 
			// ItemName15
			// 
			this.ItemName15.DataField = "ITEM_NAME_15";
			this.ItemName15.Height = 0.15F;
			this.ItemName15.Left = 5.523F;
			this.ItemName15.Name = "ItemName15";
			this.ItemName15.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName15.Text = "あいうえおかきく";
			this.ItemName15.Top = 1.365F;
			this.ItemName15.Width = 0.95F;
			// 
			// ItemValue15
			// 
			this.ItemValue15.DataField = "ITEM_VALUE_15";
			this.ItemValue15.Height = 0.15F;
			this.ItemValue15.Left = 5.523F;
			this.ItemValue15.Name = "ItemValue15";
			this.ItemValue15.OutputFormat = "#,##0.000";
			this.ItemValue15.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue15.Text = "99,999,999.999";
			this.ItemValue15.Top = 1.53F;
			this.ItemValue15.Width = 0.88F;
			// 
			// ItemName16
			// 
			this.ItemName16.DataField = "ITEM_NAME_16";
			this.ItemName16.Height = 0.15F;
			this.ItemName16.Left = 6.421F;
			this.ItemName16.Name = "ItemName16";
			this.ItemName16.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName16.Text = "あいうえおかきく";
			this.ItemName16.Top = 1.365F;
			this.ItemName16.Width = 0.95F;
			// 
			// ItemValue16
			// 
			this.ItemValue16.DataField = "ITEM_VALUE_16";
			this.ItemValue16.Height = 0.15F;
			this.ItemValue16.Left = 6.421F;
			this.ItemValue16.Name = "ItemValue16";
			this.ItemValue16.OutputFormat = "#,##0.000";
			this.ItemValue16.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue16.Text = "99,999,999.999";
			this.ItemValue16.Top = 1.53F;
			this.ItemValue16.Width = 0.88F;
			// 
			// ItemName17
			// 
			this.ItemName17.DataField = "ITEM_NAME_17";
			this.ItemName17.Height = 0.15F;
			this.ItemName17.Left = 7.319F;
			this.ItemName17.Name = "ItemName17";
			this.ItemName17.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName17.Text = "あいうえおかきく";
			this.ItemName17.Top = 1.365F;
			this.ItemName17.Width = 0.95F;
			// 
			// ItemValue17
			// 
			this.ItemValue17.DataField = "ITEM_VALUE_17";
			this.ItemValue17.Height = 0.15F;
			this.ItemValue17.Left = 7.319F;
			this.ItemValue17.Name = "ItemValue17";
			this.ItemValue17.OutputFormat = "#,##0.000";
			this.ItemValue17.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue17.Text = "99,999,999.999";
			this.ItemValue17.Top = 1.53F;
			this.ItemValue17.Width = 0.88F;
			// 
			// ItemValue18
			// 
			this.ItemValue18.DataField = "ITEM_VALUE_18";
			this.ItemValue18.Height = 0.15F;
			this.ItemValue18.Left = 8.217F;
			this.ItemValue18.Name = "ItemValue18";
			this.ItemValue18.OutputFormat = "#,##0.000";
			this.ItemValue18.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue18.Text = "99,999,999.999";
			this.ItemValue18.Top = 1.53F;
			this.ItemValue18.Width = 0.88F;
			// 
			// ItemName18
			// 
			this.ItemName18.DataField = "ITEM_NAME_18";
			this.ItemName18.Height = 0.15F;
			this.ItemName18.Left = 8.217F;
			this.ItemName18.Name = "ItemName18";
			this.ItemName18.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName18.Text = "あいうえおかきく";
			this.ItemName18.Top = 1.365F;
			this.ItemName18.Width = 0.95F;
			// 
			// ItemName19
			// 
			this.ItemName19.DataField = "ITEM_NAME_19";
			this.ItemName19.Height = 0.15F;
			this.ItemName19.Left = 1.033F;
			this.ItemName19.Name = "ItemName19";
			this.ItemName19.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName19.Text = "あいうえおかきく";
			this.ItemName19.Top = 1.695F;
			this.ItemName19.Width = 0.95F;
			// 
			// ItemValue19
			// 
			this.ItemValue19.DataField = "ITEM_VALUE_19";
			this.ItemValue19.Height = 0.15F;
			this.ItemValue19.Left = 1.0325F;
			this.ItemValue19.Name = "ItemValue19";
			this.ItemValue19.OutputFormat = "#,##0.000";
			this.ItemValue19.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue19.Text = "99,999,999.999";
			this.ItemValue19.Top = 1.86F;
			this.ItemValue19.Width = 0.88F;
			// 
			// ItemName20
			// 
			this.ItemName20.DataField = "ITEM_NAME_20";
			this.ItemName20.Height = 0.15F;
			this.ItemName20.Left = 1.931F;
			this.ItemName20.Name = "ItemName20";
			this.ItemName20.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName20.Text = "あいうえおかきく";
			this.ItemName20.Top = 1.695F;
			this.ItemName20.Width = 0.95F;
			// 
			// ItemValue20
			// 
			this.ItemValue20.DataField = "ITEM_VALUE_20";
			this.ItemValue20.Height = 0.15F;
			this.ItemValue20.Left = 1.9305F;
			this.ItemValue20.Name = "ItemValue20";
			this.ItemValue20.OutputFormat = "#,##0.000";
			this.ItemValue20.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue20.Text = "99,999,999.999";
			this.ItemValue20.Top = 1.86F;
			this.ItemValue20.Width = 0.88F;
			// 
			// ItemName21
			// 
			this.ItemName21.DataField = "ITEM_NAME_21";
			this.ItemName21.Height = 0.15F;
			this.ItemName21.Left = 2.829F;
			this.ItemName21.Name = "ItemName21";
			this.ItemName21.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName21.Text = "あいうえおかきく";
			this.ItemName21.Top = 1.695F;
			this.ItemName21.Width = 0.95F;
			// 
			// ItemValue21
			// 
			this.ItemValue21.DataField = "ITEM_VALUE_21";
			this.ItemValue21.Height = 0.15F;
			this.ItemValue21.Left = 2.829F;
			this.ItemValue21.Name = "ItemValue21";
			this.ItemValue21.OutputFormat = "#,##0.000";
			this.ItemValue21.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue21.Text = "99,999,999.999";
			this.ItemValue21.Top = 1.86F;
			this.ItemValue21.Width = 0.88F;
			// 
			// TextBox27
			// 
			this.TextBox27.DataField = "ITEM_NAME_22";
			this.TextBox27.Height = 0.15F;
			this.TextBox27.Left = 3.727F;
			this.TextBox27.Name = "TextBox27";
			this.TextBox27.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.TextBox27.Text = "あいうえおかきく";
			this.TextBox27.Top = 1.695F;
			this.TextBox27.Width = 0.95F;
			// 
			// ItemValue22
			// 
			this.ItemValue22.DataField = "ITEM_VALUE_22";
			this.ItemValue22.Height = 0.15F;
			this.ItemValue22.Left = 3.727F;
			this.ItemValue22.Name = "ItemValue22";
			this.ItemValue22.OutputFormat = "#,##0.000";
			this.ItemValue22.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue22.Text = "99,999,999.999";
			this.ItemValue22.Top = 1.86F;
			this.ItemValue22.Width = 0.88F;
			// 
			// ItemName23
			// 
			this.ItemName23.DataField = "ITEM_NAME_23";
			this.ItemName23.Height = 0.15F;
			this.ItemName23.Left = 4.625F;
			this.ItemName23.Name = "ItemName23";
			this.ItemName23.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName23.Text = "あいうえおかきく";
			this.ItemName23.Top = 1.695F;
			this.ItemName23.Width = 0.95F;
			// 
			// ItemValue23
			// 
			this.ItemValue23.DataField = "ITEM_VALUE_23";
			this.ItemValue23.Height = 0.15F;
			this.ItemValue23.Left = 4.625F;
			this.ItemValue23.Name = "ItemValue23";
			this.ItemValue23.OutputFormat = "#,##0.000";
			this.ItemValue23.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue23.Text = "99,999,999.999";
			this.ItemValue23.Top = 1.86F;
			this.ItemValue23.Width = 0.88F;
			// 
			// ItemName24
			// 
			this.ItemName24.DataField = "ITEM_NAME_24";
			this.ItemName24.Height = 0.15F;
			this.ItemName24.Left = 5.523F;
			this.ItemName24.Name = "ItemName24";
			this.ItemName24.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName24.Text = "あいうえおかきく";
			this.ItemName24.Top = 1.695F;
			this.ItemName24.Width = 0.95F;
			// 
			// ItemValue24
			// 
			this.ItemValue24.DataField = "ITEM_VALUE_24";
			this.ItemValue24.Height = 0.15F;
			this.ItemValue24.Left = 5.523F;
			this.ItemValue24.Name = "ItemValue24";
			this.ItemValue24.OutputFormat = "#,##0.000";
			this.ItemValue24.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue24.Text = "99,999,999.999";
			this.ItemValue24.Top = 1.86F;
			this.ItemValue24.Width = 0.88F;
			// 
			// ItemName25
			// 
			this.ItemName25.DataField = "ITEM_NAME_25";
			this.ItemName25.Height = 0.15F;
			this.ItemName25.Left = 6.421F;
			this.ItemName25.Name = "ItemName25";
			this.ItemName25.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName25.Text = "あいうえおかきく";
			this.ItemName25.Top = 1.695F;
			this.ItemName25.Width = 0.95F;
			// 
			// ItemValue25
			// 
			this.ItemValue25.DataField = "ITEM_VALUE_25";
			this.ItemValue25.Height = 0.15F;
			this.ItemValue25.Left = 6.421F;
			this.ItemValue25.Name = "ItemValue25";
			this.ItemValue25.OutputFormat = "#,##0.000";
			this.ItemValue25.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue25.Text = "99,999,999.999";
			this.ItemValue25.Top = 1.86F;
			this.ItemValue25.Width = 0.88F;
			// 
			// ItemName26
			// 
			this.ItemName26.DataField = "ITEM_NAME_26";
			this.ItemName26.Height = 0.15F;
			this.ItemName26.Left = 7.319F;
			this.ItemName26.Name = "ItemName26";
			this.ItemName26.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName26.Text = "あいうえおかきく";
			this.ItemName26.Top = 1.695F;
			this.ItemName26.Width = 0.95F;
			// 
			// ItemValue26
			// 
			this.ItemValue26.DataField = "ITEM_VALUE_26";
			this.ItemValue26.Height = 0.15F;
			this.ItemValue26.Left = 7.319F;
			this.ItemValue26.Name = "ItemValue26";
			this.ItemValue26.OutputFormat = "#,##0.000";
			this.ItemValue26.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue26.Text = "99,999,999.999";
			this.ItemValue26.Top = 1.86F;
			this.ItemValue26.Width = 0.88F;
			// 
			// ItemValue27
			// 
			this.ItemValue27.DataField = "ITEM_VALUE_27";
			this.ItemValue27.Height = 0.15F;
			this.ItemValue27.Left = 8.217F;
			this.ItemValue27.Name = "ItemValue27";
			this.ItemValue27.OutputFormat = "#,##0.000";
			this.ItemValue27.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue27.Text = "99,999,999.999";
			this.ItemValue27.Top = 1.86F;
			this.ItemValue27.Width = 0.88F;
			// 
			// ItemName27
			// 
			this.ItemName27.DataField = "ITEM_NAME_27";
			this.ItemName27.Height = 0.15F;
			this.ItemName27.Left = 8.217F;
			this.ItemName27.Name = "ItemName27";
			this.ItemName27.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName27.Text = "あいうえおかきく";
			this.ItemName27.Top = 1.695F;
			this.ItemName27.Width = 0.95F;
			// 
			// ItemName28
			// 
			this.ItemName28.DataField = "ITEM_NAME_28";
			this.ItemName28.Height = 0.15F;
			this.ItemName28.Left = 1.033F;
			this.ItemName28.Name = "ItemName28";
			this.ItemName28.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName28.Text = "あいうえおかきく";
			this.ItemName28.Top = 2.2F;
			this.ItemName28.Width = 0.95F;
			// 
			// ItemValue28
			// 
			this.ItemValue28.DataField = "ITEM_VALUE_28";
			this.ItemValue28.Height = 0.15F;
			this.ItemValue28.Left = 1.033F;
			this.ItemValue28.Name = "ItemValue28";
			this.ItemValue28.OutputFormat = "#,##0.000";
			this.ItemValue28.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue28.Text = "99,999,999.999";
			this.ItemValue28.Top = 2.365F;
			this.ItemValue28.Width = 0.88F;
			// 
			// ItemName29
			// 
			this.ItemName29.DataField = "ITEM_NAME_29";
			this.ItemName29.Height = 0.15F;
			this.ItemName29.Left = 1.931F;
			this.ItemName29.Name = "ItemName29";
			this.ItemName29.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName29.Text = "あいうえおかきく";
			this.ItemName29.Top = 2.2F;
			this.ItemName29.Width = 0.95F;
			// 
			// ItemValue29
			// 
			this.ItemValue29.DataField = "ITEM_VALUE_29";
			this.ItemValue29.Height = 0.15F;
			this.ItemValue29.Left = 1.931F;
			this.ItemValue29.Name = "ItemValue29";
			this.ItemValue29.OutputFormat = "#,##0.000";
			this.ItemValue29.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue29.Text = "99,999,999.999";
			this.ItemValue29.Top = 2.365F;
			this.ItemValue29.Width = 0.88F;
			// 
			// ItemName30
			// 
			this.ItemName30.DataField = "ITEM_NAME_30";
			this.ItemName30.Height = 0.15F;
			this.ItemName30.Left = 2.829F;
			this.ItemName30.Name = "ItemName30";
			this.ItemName30.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName30.Text = "あいうえおかきく";
			this.ItemName30.Top = 2.2F;
			this.ItemName30.Width = 0.95F;
			// 
			// ItemValue30
			// 
			this.ItemValue30.DataField = "ITEM_VALUE_30";
			this.ItemValue30.Height = 0.15F;
			this.ItemValue30.Left = 2.829F;
			this.ItemValue30.Name = "ItemValue30";
			this.ItemValue30.OutputFormat = "#,##0.000";
			this.ItemValue30.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue30.Text = "99,999,999.999";
			this.ItemValue30.Top = 2.365F;
			this.ItemValue30.Width = 0.88F;
			// 
			// ItemName31
			// 
			this.ItemName31.DataField = "ITEM_NAME_31";
			this.ItemName31.Height = 0.15F;
			this.ItemName31.Left = 3.727F;
			this.ItemName31.Name = "ItemName31";
			this.ItemName31.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName31.Text = "あいうえおかきく";
			this.ItemName31.Top = 2.2F;
			this.ItemName31.Width = 0.95F;
			// 
			// ItemValue31
			// 
			this.ItemValue31.DataField = "ITEM_VALUE_31";
			this.ItemValue31.Height = 0.15F;
			this.ItemValue31.Left = 3.727F;
			this.ItemValue31.Name = "ItemValue31";
			this.ItemValue31.OutputFormat = "#,##0.000";
			this.ItemValue31.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue31.Text = "99,999,999.999";
			this.ItemValue31.Top = 2.365F;
			this.ItemValue31.Width = 0.88F;
			// 
			// ItemName32
			// 
			this.ItemName32.DataField = "ITEM_NAME_32";
			this.ItemName32.Height = 0.15F;
			this.ItemName32.Left = 4.625F;
			this.ItemName32.Name = "ItemName32";
			this.ItemName32.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName32.Text = "あいうえおかきく";
			this.ItemName32.Top = 2.2F;
			this.ItemName32.Width = 0.95F;
			// 
			// ItemValue32
			// 
			this.ItemValue32.DataField = "ITEM_VALUE_32";
			this.ItemValue32.Height = 0.15F;
			this.ItemValue32.Left = 4.625F;
			this.ItemValue32.Name = "ItemValue32";
			this.ItemValue32.OutputFormat = "#,##0.000";
			this.ItemValue32.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue32.Text = "99,999,999.999";
			this.ItemValue32.Top = 2.365F;
			this.ItemValue32.Width = 0.88F;
			// 
			// ItemName33
			// 
			this.ItemName33.DataField = "ITEM_NAME_33";
			this.ItemName33.Height = 0.15F;
			this.ItemName33.Left = 5.523F;
			this.ItemName33.Name = "ItemName33";
			this.ItemName33.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName33.Text = "あいうえおかきく";
			this.ItemName33.Top = 2.2F;
			this.ItemName33.Width = 0.95F;
			// 
			// ItemValue33
			// 
			this.ItemValue33.DataField = "ITEM_VALUE_33";
			this.ItemValue33.Height = 0.15F;
			this.ItemValue33.Left = 5.523F;
			this.ItemValue33.Name = "ItemValue33";
			this.ItemValue33.OutputFormat = "#,##0.000";
			this.ItemValue33.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue33.Text = "99,999,999.999";
			this.ItemValue33.Top = 2.365F;
			this.ItemValue33.Width = 0.88F;
			// 
			// ItemName34
			// 
			this.ItemName34.DataField = "ITEM_NAME_34";
			this.ItemName34.Height = 0.15F;
			this.ItemName34.Left = 6.421F;
			this.ItemName34.Name = "ItemName34";
			this.ItemName34.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName34.Text = "あいうえおかきく";
			this.ItemName34.Top = 2.2F;
			this.ItemName34.Width = 0.95F;
			// 
			// ItemValue34
			// 
			this.ItemValue34.DataField = "ITEM_VALUE_34";
			this.ItemValue34.Height = 0.15F;
			this.ItemValue34.Left = 6.421F;
			this.ItemValue34.Name = "ItemValue34";
			this.ItemValue34.OutputFormat = "#,##0.000";
			this.ItemValue34.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue34.Text = "99,999,999.999";
			this.ItemValue34.Top = 2.365F;
			this.ItemValue34.Width = 0.88F;
			// 
			// ItemName35
			// 
			this.ItemName35.DataField = "ITEM_NAME_35";
			this.ItemName35.Height = 0.15F;
			this.ItemName35.Left = 7.319F;
			this.ItemName35.Name = "ItemName35";
			this.ItemName35.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName35.Text = "あいうえおかきく";
			this.ItemName35.Top = 2.2F;
			this.ItemName35.Width = 0.95F;
			// 
			// ItemValue35
			// 
			this.ItemValue35.DataField = "ITEM_VALUE_35";
			this.ItemValue35.Height = 0.15F;
			this.ItemValue35.Left = 7.319F;
			this.ItemValue35.Name = "ItemValue35";
			this.ItemValue35.OutputFormat = "#,##0.000";
			this.ItemValue35.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue35.Text = "99,999,999.999";
			this.ItemValue35.Top = 2.365F;
			this.ItemValue35.Width = 0.88F;
			// 
			// ItemValue36
			// 
			this.ItemValue36.DataField = "ITEM_VALUE_36";
			this.ItemValue36.Height = 0.15F;
			this.ItemValue36.Left = 8.217F;
			this.ItemValue36.Name = "ItemValue36";
			this.ItemValue36.OutputFormat = "#,##0.000";
			this.ItemValue36.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue36.Text = "99,999,999.999";
			this.ItemValue36.Top = 2.365F;
			this.ItemValue36.Width = 0.88F;
			// 
			// ItemName36
			// 
			this.ItemName36.DataField = "ITEM_NAME_36";
			this.ItemName36.Height = 0.15F;
			this.ItemName36.Left = 8.217F;
			this.ItemName36.Name = "ItemName36";
			this.ItemName36.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName36.Text = "あいうえおかきく";
			this.ItemName36.Top = 2.2F;
			this.ItemName36.Width = 0.95F;
			// 
			// ItemName37
			// 
			this.ItemName37.DataField = "ITEM_NAME_37";
			this.ItemName37.Height = 0.15F;
			this.ItemName37.Left = 1.033F;
			this.ItemName37.Name = "ItemName37";
			this.ItemName37.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName37.Text = "あいうえおかきく";
			this.ItemName37.Top = 2.53F;
			this.ItemName37.Width = 0.95F;
			// 
			// ItemValue37
			// 
			this.ItemValue37.DataField = "ITEM_VALUE_37";
			this.ItemValue37.Height = 0.15F;
			this.ItemValue37.Left = 1.033F;
			this.ItemValue37.Name = "ItemValue37";
			this.ItemValue37.OutputFormat = "#,##0.000";
			this.ItemValue37.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue37.Text = "99,999,999.999";
			this.ItemValue37.Top = 2.695F;
			this.ItemValue37.Width = 0.88F;
			// 
			// ItemName38
			// 
			this.ItemName38.DataField = "ITEM_NAME_38";
			this.ItemName38.Height = 0.15F;
			this.ItemName38.Left = 1.931F;
			this.ItemName38.Name = "ItemName38";
			this.ItemName38.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName38.Text = "あいうえおかきく";
			this.ItemName38.Top = 2.53F;
			this.ItemName38.Width = 0.95F;
			// 
			// ItemValue38
			// 
			this.ItemValue38.DataField = "ITEM_VALUE_38";
			this.ItemValue38.Height = 0.15F;
			this.ItemValue38.Left = 1.931F;
			this.ItemValue38.Name = "ItemValue38";
			this.ItemValue38.OutputFormat = "#,##0.000";
			this.ItemValue38.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue38.Text = "99,999,999.999";
			this.ItemValue38.Top = 2.695F;
			this.ItemValue38.Width = 0.88F;
			// 
			// ItemName39
			// 
			this.ItemName39.DataField = "ITEM_NAME_39";
			this.ItemName39.Height = 0.15F;
			this.ItemName39.Left = 2.829F;
			this.ItemName39.Name = "ItemName39";
			this.ItemName39.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName39.Text = "あいうえおかきく";
			this.ItemName39.Top = 2.53F;
			this.ItemName39.Width = 0.95F;
			// 
			// ItemValue39
			// 
			this.ItemValue39.DataField = "ITEM_VALUE_39";
			this.ItemValue39.Height = 0.15F;
			this.ItemValue39.Left = 2.829F;
			this.ItemValue39.Name = "ItemValue39";
			this.ItemValue39.OutputFormat = "#,##0.000";
			this.ItemValue39.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue39.Text = "99,999,999.999";
			this.ItemValue39.Top = 2.695F;
			this.ItemValue39.Width = 0.88F;
			// 
			// ItemName40
			// 
			this.ItemName40.DataField = "ITEM_NAME_40";
			this.ItemName40.Height = 0.15F;
			this.ItemName40.Left = 3.727F;
			this.ItemName40.Name = "ItemName40";
			this.ItemName40.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName40.Text = "あいうえおかきく";
			this.ItemName40.Top = 2.53F;
			this.ItemName40.Width = 0.95F;
			// 
			// ItemValue40
			// 
			this.ItemValue40.DataField = "ITEM_VALUE_40";
			this.ItemValue40.Height = 0.15F;
			this.ItemValue40.Left = 3.727F;
			this.ItemValue40.Name = "ItemValue40";
			this.ItemValue40.OutputFormat = "#,##0.000";
			this.ItemValue40.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue40.Text = "99,999,999.999";
			this.ItemValue40.Top = 2.695F;
			this.ItemValue40.Width = 0.88F;
			// 
			// ItemName41
			// 
			this.ItemName41.DataField = "ITEM_NAME_41";
			this.ItemName41.Height = 0.15F;
			this.ItemName41.Left = 4.625F;
			this.ItemName41.Name = "ItemName41";
			this.ItemName41.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName41.Text = "あいうえおかきく";
			this.ItemName41.Top = 2.53F;
			this.ItemName41.Width = 0.95F;
			// 
			// ItemValue41
			// 
			this.ItemValue41.DataField = "ITEM_VALUE_41";
			this.ItemValue41.Height = 0.15F;
			this.ItemValue41.Left = 4.625F;
			this.ItemValue41.Name = "ItemValue41";
			this.ItemValue41.OutputFormat = "#,##0.000";
			this.ItemValue41.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue41.Text = "99,999,999.999";
			this.ItemValue41.Top = 2.695F;
			this.ItemValue41.Width = 0.88F;
			// 
			// ItemName42
			// 
			this.ItemName42.DataField = "ITEM_NAME_42";
			this.ItemName42.Height = 0.15F;
			this.ItemName42.Left = 5.523F;
			this.ItemName42.Name = "ItemName42";
			this.ItemName42.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName42.Text = "あいうえおかきく";
			this.ItemName42.Top = 2.53F;
			this.ItemName42.Width = 0.95F;
			// 
			// ItemValue42
			// 
			this.ItemValue42.DataField = "ITEM_VALUE_42";
			this.ItemValue42.Height = 0.15F;
			this.ItemValue42.Left = 5.523F;
			this.ItemValue42.Name = "ItemValue42";
			this.ItemValue42.OutputFormat = "#,##0.000";
			this.ItemValue42.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue42.Text = "99,999,999.999";
			this.ItemValue42.Top = 2.695F;
			this.ItemValue42.Width = 0.88F;
			// 
			// ItemName43
			// 
			this.ItemName43.DataField = "ITEM_NAME_43";
			this.ItemName43.Height = 0.15F;
			this.ItemName43.Left = 6.421F;
			this.ItemName43.Name = "ItemName43";
			this.ItemName43.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName43.Text = "あいうえおかきく";
			this.ItemName43.Top = 2.53F;
			this.ItemName43.Width = 0.95F;
			// 
			// ItemValue43
			// 
			this.ItemValue43.DataField = "ITEM_VALUE_43";
			this.ItemValue43.Height = 0.15F;
			this.ItemValue43.Left = 6.421F;
			this.ItemValue43.Name = "ItemValue43";
			this.ItemValue43.OutputFormat = "#,##0.000";
			this.ItemValue43.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue43.Text = "99,999,999.999";
			this.ItemValue43.Top = 2.695F;
			this.ItemValue43.Width = 0.88F;
			// 
			// ItemName44
			// 
			this.ItemName44.DataField = "ITEM_NAME_44";
			this.ItemName44.Height = 0.15F;
			this.ItemName44.Left = 7.319F;
			this.ItemName44.Name = "ItemName44";
			this.ItemName44.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName44.Text = "あいうえおかきく";
			this.ItemName44.Top = 2.53F;
			this.ItemName44.Width = 0.95F;
			// 
			// ItemValue44
			// 
			this.ItemValue44.DataField = "ITEM_VALUE_44";
			this.ItemValue44.Height = 0.15F;
			this.ItemValue44.Left = 7.319F;
			this.ItemValue44.Name = "ItemValue44";
			this.ItemValue44.OutputFormat = "#,##0.000";
			this.ItemValue44.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue44.Text = "99,999,999.999";
			this.ItemValue44.Top = 2.695F;
			this.ItemValue44.Width = 0.88F;
			// 
			// ItemValue45
			// 
			this.ItemValue45.DataField = "ITEM_VALUE_45";
			this.ItemValue45.Height = 0.15F;
			this.ItemValue45.Left = 8.217F;
			this.ItemValue45.Name = "ItemValue45";
			this.ItemValue45.OutputFormat = "#,##0.000";
			this.ItemValue45.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue45.Text = "99,999,999.999";
			this.ItemValue45.Top = 2.695F;
			this.ItemValue45.Width = 0.88F;
			// 
			// ItemName45
			// 
			this.ItemName45.DataField = "ITEM_NAME_45";
			this.ItemName45.Height = 0.15F;
			this.ItemName45.Left = 8.217F;
			this.ItemName45.Name = "ItemName45";
			this.ItemName45.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName45.Text = "あいうえおかきく";
			this.ItemName45.Top = 2.53F;
			this.ItemName45.Width = 0.95F;
			// 
			// ItemName46
			// 
			this.ItemName46.DataField = "ITEM_NAME_46";
			this.ItemName46.Height = 0.15F;
			this.ItemName46.Left = 1.033F;
			this.ItemName46.Name = "ItemName46";
			this.ItemName46.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName46.Text = "あいうえおかきく";
			this.ItemName46.Top = 2.86F;
			this.ItemName46.Width = 0.95F;
			// 
			// ItemValue46
			// 
			this.ItemValue46.DataField = "ITEM_VALUE_46";
			this.ItemValue46.Height = 0.15F;
			this.ItemValue46.Left = 1.033F;
			this.ItemValue46.Name = "ItemValue46";
			this.ItemValue46.OutputFormat = "#,##0.000";
			this.ItemValue46.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue46.Text = "99,999,999.999";
			this.ItemValue46.Top = 3.025F;
			this.ItemValue46.Width = 0.88F;
			// 
			// ItemName47
			// 
			this.ItemName47.DataField = "ITEM_NAME_47";
			this.ItemName47.Height = 0.15F;
			this.ItemName47.Left = 1.931F;
			this.ItemName47.Name = "ItemName47";
			this.ItemName47.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName47.Text = "あいうえおかきく";
			this.ItemName47.Top = 2.86F;
			this.ItemName47.Width = 0.95F;
			// 
			// ItemValue47
			// 
			this.ItemValue47.DataField = "ITEM_VALUE_47";
			this.ItemValue47.Height = 0.15F;
			this.ItemValue47.Left = 1.931F;
			this.ItemValue47.Name = "ItemValue47";
			this.ItemValue47.OutputFormat = "#,##0.000";
			this.ItemValue47.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue47.Text = "99,999,999.999";
			this.ItemValue47.Top = 3.025F;
			this.ItemValue47.Width = 0.88F;
			// 
			// ItemName48
			// 
			this.ItemName48.DataField = "ITEM_NAME_48";
			this.ItemName48.Height = 0.15F;
			this.ItemName48.Left = 2.829F;
			this.ItemName48.Name = "ItemName48";
			this.ItemName48.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName48.Text = "あいうえおかきく";
			this.ItemName48.Top = 2.86F;
			this.ItemName48.Width = 0.95F;
			// 
			// ItemValue48
			// 
			this.ItemValue48.DataField = "ITEM_VALUE_48";
			this.ItemValue48.Height = 0.15F;
			this.ItemValue48.Left = 2.829F;
			this.ItemValue48.Name = "ItemValue48";
			this.ItemValue48.OutputFormat = "#,##0.000";
			this.ItemValue48.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue48.Text = "99,999,999.999";
			this.ItemValue48.Top = 3.025F;
			this.ItemValue48.Width = 0.88F;
			// 
			// ItemName49
			// 
			this.ItemName49.DataField = "ITEM_NAME_49";
			this.ItemName49.Height = 0.15F;
			this.ItemName49.Left = 3.727F;
			this.ItemName49.Name = "ItemName49";
			this.ItemName49.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName49.Text = "あいうえおかきく";
			this.ItemName49.Top = 2.86F;
			this.ItemName49.Width = 0.95F;
			// 
			// ItemValue49
			// 
			this.ItemValue49.DataField = "ITEM_VALUE_49";
			this.ItemValue49.Height = 0.15F;
			this.ItemValue49.Left = 3.727F;
			this.ItemValue49.Name = "ItemValue49";
			this.ItemValue49.OutputFormat = "#,##0.000";
			this.ItemValue49.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue49.Text = "99,999,999.999";
			this.ItemValue49.Top = 3.025F;
			this.ItemValue49.Width = 0.88F;
			// 
			// ItemName50
			// 
			this.ItemName50.DataField = "ITEM_NAME_50";
			this.ItemName50.Height = 0.15F;
			this.ItemName50.Left = 4.625F;
			this.ItemName50.Name = "ItemName50";
			this.ItemName50.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName50.Text = "あいうえおかきく";
			this.ItemName50.Top = 2.86F;
			this.ItemName50.Width = 0.95F;
			// 
			// ItemValue50
			// 
			this.ItemValue50.DataField = "ITEM_VALUE_50";
			this.ItemValue50.Height = 0.15F;
			this.ItemValue50.Left = 4.625F;
			this.ItemValue50.Name = "ItemValue50";
			this.ItemValue50.OutputFormat = "#,##0.000";
			this.ItemValue50.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue50.Text = "99,999,999.999";
			this.ItemValue50.Top = 3.025F;
			this.ItemValue50.Width = 0.88F;
			// 
			// ItemName51
			// 
			this.ItemName51.DataField = "ITEM_NAME_51";
			this.ItemName51.Height = 0.15F;
			this.ItemName51.Left = 5.523F;
			this.ItemName51.Name = "ItemName51";
			this.ItemName51.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName51.Text = "あいうえおかきく";
			this.ItemName51.Top = 2.86F;
			this.ItemName51.Width = 0.95F;
			// 
			// ItemValue51
			// 
			this.ItemValue51.DataField = "ITEM_VALUE_51";
			this.ItemValue51.Height = 0.15F;
			this.ItemValue51.Left = 5.523F;
			this.ItemValue51.Name = "ItemValue51";
			this.ItemValue51.OutputFormat = "#,##0.000";
			this.ItemValue51.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue51.Text = "99,999,999.999";
			this.ItemValue51.Top = 3.025F;
			this.ItemValue51.Width = 0.88F;
			// 
			// ItemName52
			// 
			this.ItemName52.DataField = "ITEM_NAME_52";
			this.ItemName52.Height = 0.15F;
			this.ItemName52.Left = 6.421F;
			this.ItemName52.Name = "ItemName52";
			this.ItemName52.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName52.Text = "あいうえおかきく";
			this.ItemName52.Top = 2.86F;
			this.ItemName52.Width = 0.95F;
			// 
			// ItemValue52
			// 
			this.ItemValue52.DataField = "ITEM_VALUE_52";
			this.ItemValue52.Height = 0.15F;
			this.ItemValue52.Left = 6.421F;
			this.ItemValue52.Name = "ItemValue52";
			this.ItemValue52.OutputFormat = "#,##0.000";
			this.ItemValue52.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue52.Text = "99,999,999.999";
			this.ItemValue52.Top = 3.025F;
			this.ItemValue52.Width = 0.88F;
			// 
			// ItemName53
			// 
			this.ItemName53.DataField = "ITEM_NAME_53";
			this.ItemName53.Height = 0.15F;
			this.ItemName53.Left = 7.319F;
			this.ItemName53.Name = "ItemName53";
			this.ItemName53.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName53.Text = "あいうえおかきく";
			this.ItemName53.Top = 2.86F;
			this.ItemName53.Width = 0.95F;
			// 
			// ItemValue53
			// 
			this.ItemValue53.DataField = "ITEM_VALUE_53";
			this.ItemValue53.Height = 0.15F;
			this.ItemValue53.Left = 7.319F;
			this.ItemValue53.Name = "ItemValue53";
			this.ItemValue53.OutputFormat = "#,##0.000";
			this.ItemValue53.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue53.Text = "99,999,999.999";
			this.ItemValue53.Top = 3.025F;
			this.ItemValue53.Width = 0.88F;
			// 
			// ItemValue54
			// 
			this.ItemValue54.DataField = "ITEM_VALUE_54";
			this.ItemValue54.Height = 0.15F;
			this.ItemValue54.Left = 8.217F;
			this.ItemValue54.Name = "ItemValue54";
			this.ItemValue54.OutputFormat = "#,##0.000";
			this.ItemValue54.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue54.Text = "99,999,999.999";
			this.ItemValue54.Top = 3.025F;
			this.ItemValue54.Width = 0.88F;
			// 
			// ItemName54
			// 
			this.ItemName54.DataField = "ITEM_NAME_54";
			this.ItemName54.Height = 0.15F;
			this.ItemName54.Left = 8.217F;
			this.ItemName54.Name = "ItemName54";
			this.ItemName54.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName54.Text = "あいうえおかきく";
			this.ItemName54.Top = 2.86F;
			this.ItemName54.Width = 0.95F;
			// 
			// ItemName55
			// 
			this.ItemName55.DataField = "ITEM_NAME_55";
			this.ItemName55.Height = 0.15F;
			this.ItemName55.Left = 1.033F;
			this.ItemName55.Name = "ItemName55";
			this.ItemName55.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName55.Text = "あいうえおかきく";
			this.ItemName55.Top = 3.365F;
			this.ItemName55.Width = 0.95F;
			// 
			// ItemValue55
			// 
			this.ItemValue55.DataField = "ITEM_VALUE_55";
			this.ItemValue55.Height = 0.15F;
			this.ItemValue55.Left = 1.033F;
			this.ItemValue55.Name = "ItemValue55";
			this.ItemValue55.OutputFormat = "#,##0.000";
			this.ItemValue55.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue55.Text = "99,999,999.999";
			this.ItemValue55.Top = 3.53F;
			this.ItemValue55.Width = 0.88F;
			// 
			// ItemName56
			// 
			this.ItemName56.DataField = "ITEM_NAME_56";
			this.ItemName56.Height = 0.15F;
			this.ItemName56.Left = 1.931F;
			this.ItemName56.Name = "ItemName56";
			this.ItemName56.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName56.Text = "あいうえおかきく";
			this.ItemName56.Top = 3.365F;
			this.ItemName56.Width = 0.95F;
			// 
			// ItemValue56
			// 
			this.ItemValue56.DataField = "ITEM_VALUE_56";
			this.ItemValue56.Height = 0.15F;
			this.ItemValue56.Left = 1.931F;
			this.ItemValue56.Name = "ItemValue56";
			this.ItemValue56.OutputFormat = "#,##0.000";
			this.ItemValue56.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue56.Text = "99,999,999.999";
			this.ItemValue56.Top = 3.53F;
			this.ItemValue56.Width = 0.88F;
			// 
			// ItemName57
			// 
			this.ItemName57.DataField = "ITEM_NAME_57";
			this.ItemName57.Height = 0.15F;
			this.ItemName57.Left = 2.829F;
			this.ItemName57.Name = "ItemName57";
			this.ItemName57.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName57.Text = "あいうえおかきく";
			this.ItemName57.Top = 3.365F;
			this.ItemName57.Width = 0.95F;
			// 
			// ItemValue57
			// 
			this.ItemValue57.DataField = "ITEM_VALUE_57";
			this.ItemValue57.Height = 0.15F;
			this.ItemValue57.Left = 2.829F;
			this.ItemValue57.Name = "ItemValue57";
			this.ItemValue57.OutputFormat = "#,##0.000";
			this.ItemValue57.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue57.Text = "99,999,999.999";
			this.ItemValue57.Top = 3.53F;
			this.ItemValue57.Width = 0.88F;
			// 
			// ItemName58
			// 
			this.ItemName58.DataField = "ITEM_NAME_58";
			this.ItemName58.Height = 0.15F;
			this.ItemName58.Left = 3.727F;
			this.ItemName58.Name = "ItemName58";
			this.ItemName58.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName58.Text = "あいうえおかきく";
			this.ItemName58.Top = 3.365F;
			this.ItemName58.Width = 0.95F;
			// 
			// ItemValue58
			// 
			this.ItemValue58.DataField = "ITEM_VALUE_58";
			this.ItemValue58.Height = 0.15F;
			this.ItemValue58.Left = 3.727F;
			this.ItemValue58.Name = "ItemValue58";
			this.ItemValue58.OutputFormat = "#,##0.000";
			this.ItemValue58.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue58.Text = "99,999,999.999";
			this.ItemValue58.Top = 3.53F;
			this.ItemValue58.Width = 0.88F;
			// 
			// ItemName59
			// 
			this.ItemName59.DataField = "ITEM_NAME_59";
			this.ItemName59.Height = 0.15F;
			this.ItemName59.Left = 4.625F;
			this.ItemName59.Name = "ItemName59";
			this.ItemName59.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName59.Text = "あいうえおかきく";
			this.ItemName59.Top = 3.365F;
			this.ItemName59.Width = 0.95F;
			// 
			// ItemValue59
			// 
			this.ItemValue59.DataField = "ITEM_VALUE_59";
			this.ItemValue59.Height = 0.15F;
			this.ItemValue59.Left = 4.625F;
			this.ItemValue59.Name = "ItemValue59";
			this.ItemValue59.OutputFormat = "#,##0.000";
			this.ItemValue59.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue59.Text = "99,999,999.999";
			this.ItemValue59.Top = 3.53F;
			this.ItemValue59.Width = 0.88F;
			// 
			// ItemName60
			// 
			this.ItemName60.DataField = "ITEM_NAME_60";
			this.ItemName60.Height = 0.15F;
			this.ItemName60.Left = 5.523F;
			this.ItemName60.Name = "ItemName60";
			this.ItemName60.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName60.Text = "あいうえおかきく";
			this.ItemName60.Top = 3.365F;
			this.ItemName60.Width = 0.95F;
			// 
			// ItemValue60
			// 
			this.ItemValue60.DataField = "ITEM_VALUE_60";
			this.ItemValue60.Height = 0.15F;
			this.ItemValue60.Left = 5.523F;
			this.ItemValue60.Name = "ItemValue60";
			this.ItemValue60.OutputFormat = "#,##0.000";
			this.ItemValue60.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue60.Text = "99,999,999.999";
			this.ItemValue60.Top = 3.53F;
			this.ItemValue60.Width = 0.88F;
			// 
			// ItemName61
			// 
			this.ItemName61.DataField = "ITEM_NAME_61";
			this.ItemName61.Height = 0.15F;
			this.ItemName61.Left = 6.421F;
			this.ItemName61.Name = "ItemName61";
			this.ItemName61.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName61.Text = "あいうえおかきく";
			this.ItemName61.Top = 3.365F;
			this.ItemName61.Width = 0.95F;
			// 
			// ItemValue61
			// 
			this.ItemValue61.DataField = "ITEM_VALUE_61";
			this.ItemValue61.Height = 0.15F;
			this.ItemValue61.Left = 6.421F;
			this.ItemValue61.Name = "ItemValue61";
			this.ItemValue61.OutputFormat = "#,##0.000";
			this.ItemValue61.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue61.Text = "99,999,999.999";
			this.ItemValue61.Top = 3.53F;
			this.ItemValue61.Width = 0.88F;
			// 
			// ItemName62
			// 
			this.ItemName62.DataField = "ITEM_NAME_62";
			this.ItemName62.Height = 0.15F;
			this.ItemName62.Left = 7.319F;
			this.ItemName62.Name = "ItemName62";
			this.ItemName62.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName62.Text = "あいうえおかきく";
			this.ItemName62.Top = 3.365F;
			this.ItemName62.Width = 0.95F;
			// 
			// ItemValue62
			// 
			this.ItemValue62.DataField = "ITEM_VALUE_62";
			this.ItemValue62.Height = 0.15F;
			this.ItemValue62.Left = 7.319F;
			this.ItemValue62.Name = "ItemValue62";
			this.ItemValue62.OutputFormat = "#,##0.000";
			this.ItemValue62.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue62.Text = "99,999,999.999";
			this.ItemValue62.Top = 3.53F;
			this.ItemValue62.Width = 0.88F;
			// 
			// ItemValue63
			// 
			this.ItemValue63.DataField = "ITEM_VALUE_63";
			this.ItemValue63.Height = 0.15F;
			this.ItemValue63.Left = 8.217F;
			this.ItemValue63.Name = "ItemValue63";
			this.ItemValue63.OutputFormat = "#,##0.000";
			this.ItemValue63.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue63.Text = "99,999,999.999";
			this.ItemValue63.Top = 3.53F;
			this.ItemValue63.Width = 0.88F;
			// 
			// ItemName63
			// 
			this.ItemName63.DataField = "ITEM_NAME_63";
			this.ItemName63.Height = 0.15F;
			this.ItemName63.Left = 8.217F;
			this.ItemName63.Name = "ItemName63";
			this.ItemName63.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName63.Text = "あいうえおかきく";
			this.ItemName63.Top = 3.365F;
			this.ItemName63.Width = 0.95F;
			// 
			// ItemName64
			// 
			this.ItemName64.DataField = "ITEM_NAME_64";
			this.ItemName64.Height = 0.15F;
			this.ItemName64.Left = 1.033F;
			this.ItemName64.Name = "ItemName64";
			this.ItemName64.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName64.Text = "あいうえおかきく";
			this.ItemName64.Top = 3.87F;
			this.ItemName64.Width = 0.95F;
			// 
			// ItemValue64
			// 
			this.ItemValue64.DataField = "ITEM_VALUE_64";
			this.ItemValue64.Height = 0.15F;
			this.ItemValue64.Left = 1.033F;
			this.ItemValue64.Name = "ItemValue64";
			this.ItemValue64.OutputFormat = "#,##0.000";
			this.ItemValue64.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue64.Text = "99,999,999.999";
			this.ItemValue64.Top = 4.035F;
			this.ItemValue64.Width = 0.88F;
			// 
			// ItemName65
			// 
			this.ItemName65.DataField = "ITEM_NAME_65";
			this.ItemName65.Height = 0.15F;
			this.ItemName65.Left = 1.931F;
			this.ItemName65.Name = "ItemName65";
			this.ItemName65.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName65.Text = "あいうえおかきく";
			this.ItemName65.Top = 3.87F;
			this.ItemName65.Width = 0.95F;
			// 
			// ItemValue65
			// 
			this.ItemValue65.DataField = "ITEM_VALUE_65";
			this.ItemValue65.Height = 0.15F;
			this.ItemValue65.Left = 1.931F;
			this.ItemValue65.Name = "ItemValue65";
			this.ItemValue65.OutputFormat = "#,##0.000";
			this.ItemValue65.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue65.Text = "99,999,999.999";
			this.ItemValue65.Top = 4.035F;
			this.ItemValue65.Width = 0.88F;
			// 
			// ItemName66
			// 
			this.ItemName66.DataField = "ITEM_NAME_66";
			this.ItemName66.Height = 0.15F;
			this.ItemName66.Left = 2.813F;
			this.ItemName66.Name = "ItemName66";
			this.ItemName66.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName66.Text = "あいうえおかきく";
			this.ItemName66.Top = 3.87F;
			this.ItemName66.Width = 0.95F;
			// 
			// ItemValue66
			// 
			this.ItemValue66.DataField = "ITEM_VALUE_66";
			this.ItemValue66.Height = 0.15F;
			this.ItemValue66.Left = 2.829F;
			this.ItemValue66.Name = "ItemValue66";
			this.ItemValue66.OutputFormat = "#,##0.000";
			this.ItemValue66.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue66.Text = "99,999,999.999";
			this.ItemValue66.Top = 4.035F;
			this.ItemValue66.Width = 0.88F;
			// 
			// ItemName67
			// 
			this.ItemName67.DataField = "ITEM_NAME_67";
			this.ItemName67.Height = 0.15F;
			this.ItemName67.Left = 3.727F;
			this.ItemName67.Name = "ItemName67";
			this.ItemName67.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName67.Text = "あいうえおかきく";
			this.ItemName67.Top = 3.87F;
			this.ItemName67.Width = 0.95F;
			// 
			// ItemValue67
			// 
			this.ItemValue67.DataField = "ITEM_VALUE_67";
			this.ItemValue67.Height = 0.15F;
			this.ItemValue67.Left = 3.727F;
			this.ItemValue67.Name = "ItemValue67";
			this.ItemValue67.OutputFormat = "#,##0.000";
			this.ItemValue67.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue67.Text = "99,999,999.999";
			this.ItemValue67.Top = 4.035F;
			this.ItemValue67.Width = 0.88F;
			// 
			// ItemName68
			// 
			this.ItemName68.DataField = "ITEM_NAME_68";
			this.ItemName68.Height = 0.15F;
			this.ItemName68.Left = 4.625F;
			this.ItemName68.Name = "ItemName68";
			this.ItemName68.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName68.Text = "あいうえおかきく";
			this.ItemName68.Top = 3.87F;
			this.ItemName68.Width = 0.95F;
			// 
			// ItemValue68
			// 
			this.ItemValue68.DataField = "ITEM_VALUE_68";
			this.ItemValue68.Height = 0.15F;
			this.ItemValue68.Left = 4.625F;
			this.ItemValue68.Name = "ItemValue68";
			this.ItemValue68.OutputFormat = "#,##0.000";
			this.ItemValue68.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue68.Text = "99,999,999.999";
			this.ItemValue68.Top = 4.035F;
			this.ItemValue68.Width = 0.88F;
			// 
			// ItemName69
			// 
			this.ItemName69.DataField = "ITEM_NAME_69";
			this.ItemName69.Height = 0.15F;
			this.ItemName69.Left = 5.523F;
			this.ItemName69.Name = "ItemName69";
			this.ItemName69.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName69.Text = "あいうえおかきく";
			this.ItemName69.Top = 3.87F;
			this.ItemName69.Width = 0.95F;
			// 
			// ItemValue69
			// 
			this.ItemValue69.DataField = "ITEM_VALUE_69";
			this.ItemValue69.Height = 0.15F;
			this.ItemValue69.Left = 5.523F;
			this.ItemValue69.Name = "ItemValue69";
			this.ItemValue69.OutputFormat = "#,##0.000";
			this.ItemValue69.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue69.Text = "99,999,999.999";
			this.ItemValue69.Top = 4.035F;
			this.ItemValue69.Width = 0.88F;
			// 
			// ItemName70
			// 
			this.ItemName70.DataField = "ITEM_NAME_70";
			this.ItemName70.Height = 0.15F;
			this.ItemName70.Left = 6.421F;
			this.ItemName70.Name = "ItemName70";
			this.ItemName70.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName70.Text = "あいうえおかきく";
			this.ItemName70.Top = 3.87F;
			this.ItemName70.Width = 0.95F;
			// 
			// ItemValue70
			// 
			this.ItemValue70.DataField = "ITEM_VALUE_70";
			this.ItemValue70.Height = 0.15F;
			this.ItemValue70.Left = 6.421F;
			this.ItemValue70.Name = "ItemValue70";
			this.ItemValue70.OutputFormat = "#,##0.000";
			this.ItemValue70.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue70.Text = "99,999,999.999";
			this.ItemValue70.Top = 4.035F;
			this.ItemValue70.Width = 0.88F;
			// 
			// ItemName71
			// 
			this.ItemName71.DataField = "ITEM_NAME_71";
			this.ItemName71.Height = 0.15F;
			this.ItemName71.Left = 7.319F;
			this.ItemName71.Name = "ItemName71";
			this.ItemName71.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName71.Text = "あいうえおかきく";
			this.ItemName71.Top = 3.87F;
			this.ItemName71.Width = 0.95F;
			// 
			// ItemValue71
			// 
			this.ItemValue71.DataField = "ITEM_VALUE_71";
			this.ItemValue71.Height = 0.15F;
			this.ItemValue71.Left = 7.319F;
			this.ItemValue71.Name = "ItemValue71";
			this.ItemValue71.OutputFormat = "#,##0.000";
			this.ItemValue71.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue71.Text = "99,999,999.999";
			this.ItemValue71.Top = 4.035F;
			this.ItemValue71.Width = 0.88F;
			// 
			// ItemValue72
			// 
			this.ItemValue72.DataField = "ITEM_VALUE_72";
			this.ItemValue72.Height = 0.15F;
			this.ItemValue72.Left = 8.217F;
			this.ItemValue72.Name = "ItemValue72";
			this.ItemValue72.OutputFormat = "#,##0.000";
			this.ItemValue72.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue72.Text = "99,999,999.999";
			this.ItemValue72.Top = 4.035F;
			this.ItemValue72.Width = 0.88F;
			// 
			// ItemName72
			// 
			this.ItemName72.DataField = "ITEM_NAME_72";
			this.ItemName72.Height = 0.15F;
			this.ItemName72.Left = 8.217F;
			this.ItemName72.Name = "ItemName72";
			this.ItemName72.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName72.Text = "あいうえおかきく";
			this.ItemName72.Top = 3.87F;
			this.ItemName72.Width = 0.95F;
			// 
			// ItemName73
			// 
			this.ItemName73.DataField = "ITEM_NAME_73";
			this.ItemName73.Height = 0.15F;
			this.ItemName73.Left = 4.625F;
			this.ItemName73.Name = "ItemName73";
			this.ItemName73.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName73.Text = "あいうえおかきく";
			this.ItemName73.Top = 4.2F;
			this.ItemName73.Width = 0.95F;
			// 
			// ItemValue73
			// 
			this.ItemValue73.DataField = "ITEM_VALUE_73";
			this.ItemValue73.Height = 0.15F;
			this.ItemValue73.Left = 4.625F;
			this.ItemValue73.Name = "ItemValue73";
			this.ItemValue73.OutputFormat = "#,##0.000";
			this.ItemValue73.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue73.Text = "99,999,999.999";
			this.ItemValue73.Top = 4.365001F;
			this.ItemValue73.Width = 0.88F;
			// 
			// ItemName74
			// 
			this.ItemName74.DataField = "ITEM_NAME_74";
			this.ItemName74.Height = 0.15F;
			this.ItemName74.Left = 5.523F;
			this.ItemName74.Name = "ItemName74";
			this.ItemName74.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName74.Text = "あいうえおかきく";
			this.ItemName74.Top = 4.2F;
			this.ItemName74.Width = 0.95F;
			// 
			// ItemValue74
			// 
			this.ItemValue74.DataField = "ITEM_VALUE_74";
			this.ItemValue74.Height = 0.15F;
			this.ItemValue74.Left = 5.523F;
			this.ItemValue74.Name = "ItemValue74";
			this.ItemValue74.OutputFormat = "#,##0.000";
			this.ItemValue74.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue74.Text = "99,999,999.999";
			this.ItemValue74.Top = 4.365001F;
			this.ItemValue74.Width = 0.88F;
			// 
			// ItemName75
			// 
			this.ItemName75.DataField = "ITEM_NAME_75";
			this.ItemName75.Height = 0.15F;
			this.ItemName75.Left = 6.421F;
			this.ItemName75.Name = "ItemName75";
			this.ItemName75.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName75.Text = "あいうえおかきく";
			this.ItemName75.Top = 4.2F;
			this.ItemName75.Width = 0.95F;
			// 
			// ItemValue75
			// 
			this.ItemValue75.DataField = "ITEM_VALUE_75";
			this.ItemValue75.Height = 0.15F;
			this.ItemValue75.Left = 6.421F;
			this.ItemValue75.Name = "ItemValue75";
			this.ItemValue75.OutputFormat = "#,##0.000";
			this.ItemValue75.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue75.Text = "99,999,999.999";
			this.ItemValue75.Top = 4.365001F;
			this.ItemValue75.Width = 0.88F;
			// 
			// ItemName76
			// 
			this.ItemName76.DataField = "ITEM_NAME_76";
			this.ItemName76.Height = 0.15F;
			this.ItemName76.Left = 7.313F;
			this.ItemName76.Name = "ItemName76";
			this.ItemName76.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName76.Text = "あいうえおかきく";
			this.ItemName76.Top = 4.2F;
			this.ItemName76.Width = 0.95F;
			// 
			// ItemValue76
			// 
			this.ItemValue76.DataField = "ITEM_VALUE_76";
			this.ItemValue76.Height = 0.15F;
			this.ItemValue76.Left = 7.319F;
			this.ItemValue76.Name = "ItemValue76";
			this.ItemValue76.OutputFormat = "#,##0.000";
			this.ItemValue76.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue76.Text = "99,999,999.999";
			this.ItemValue76.Top = 4.365001F;
			this.ItemValue76.Width = 0.88F;
			// 
			// ItemValue77
			// 
			this.ItemValue77.DataField = "ITEM_VALUE_77";
			this.ItemValue77.Height = 0.15F;
			this.ItemValue77.Left = 8.217F;
			this.ItemValue77.Name = "ItemValue77";
			this.ItemValue77.OutputFormat = "#,##0.000";
			this.ItemValue77.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue77.Text = "99,999,999.999";
			this.ItemValue77.Top = 4.365001F;
			this.ItemValue77.Width = 0.88F;
			// 
			// ItemName77
			// 
			this.ItemName77.DataField = "ITEM_NAME_77";
			this.ItemName77.Height = 0.15F;
			this.ItemName77.Left = 8.217F;
			this.ItemName77.Name = "ItemName77";
			this.ItemName77.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName77.Text = "あいうえおかきく";
			this.ItemName77.Top = 4.2F;
			this.ItemName77.Width = 0.95F;
			// 
			// ItemForm1
			// 
			this.ItemForm1.DataField = "ITEM_FORM_1";
			this.ItemForm1.Height = 0.15F;
			this.ItemForm1.Left = 0.1875F;
			this.ItemForm1.Name = "ItemForm1";
			this.ItemForm1.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm1.Text = "FORMAT";
			this.ItemForm1.Top = 1F;
			this.ItemForm1.Visible = false;
			this.ItemForm1.Width = 0.75F;
			// 
			// ItemForm2
			// 
			this.ItemForm2.DataField = "ITEM_FORM_2";
			this.ItemForm2.Height = 0.15F;
			this.ItemForm2.Left = 0.1875F;
			this.ItemForm2.Name = "ItemForm2";
			this.ItemForm2.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm2.Text = "FORMAT";
			this.ItemForm2.Top = 1.1875F;
			this.ItemForm2.Visible = false;
			this.ItemForm2.Width = 0.75F;
			// 
			// ItemForm3
			// 
			this.ItemForm3.DataField = "ITEM_FORM_3";
			this.ItemForm3.Height = 0.15F;
			this.ItemForm3.Left = 0.1875F;
			this.ItemForm3.Name = "ItemForm3";
			this.ItemForm3.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm3.Text = "FORMAT";
			this.ItemForm3.Top = 1.375F;
			this.ItemForm3.Visible = false;
			this.ItemForm3.Width = 0.75F;
			// 
			// ItemForm4
			// 
			this.ItemForm4.DataField = "ITEM_FORM_4";
			this.ItemForm4.Height = 0.15F;
			this.ItemForm4.Left = 0.1875F;
			this.ItemForm4.Name = "ItemForm4";
			this.ItemForm4.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm4.Text = "FORMAT";
			this.ItemForm4.Top = 1.5625F;
			this.ItemForm4.Visible = false;
			this.ItemForm4.Width = 0.75F;
			// 
			// ItemForm5
			// 
			this.ItemForm5.DataField = "ITEM_FORM_5";
			this.ItemForm5.Height = 0.15F;
			this.ItemForm5.Left = 0.1875F;
			this.ItemForm5.Name = "ItemForm5";
			this.ItemForm5.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm5.Text = "FORMAT";
			this.ItemForm5.Top = 1.75F;
			this.ItemForm5.Visible = false;
			this.ItemForm5.Width = 0.75F;
			// 
			// ItemForm6
			// 
			this.ItemForm6.DataField = "ITEM_FORM_6";
			this.ItemForm6.Height = 0.15F;
			this.ItemForm6.Left = 0.1875F;
			this.ItemForm6.Name = "ItemForm6";
			this.ItemForm6.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm6.Text = "FORMAT";
			this.ItemForm6.Top = 1.9375F;
			this.ItemForm6.Visible = false;
			this.ItemForm6.Width = 0.75F;
			// 
			// ItemForm7
			// 
			this.ItemForm7.DataField = "ITEM_FORM_7";
			this.ItemForm7.Height = 0.15F;
			this.ItemForm7.Left = 0.1875F;
			this.ItemForm7.Name = "ItemForm7";
			this.ItemForm7.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm7.Text = "FORMAT";
			this.ItemForm7.Top = 2.125F;
			this.ItemForm7.Visible = false;
			this.ItemForm7.Width = 0.75F;
			// 
			// ItemForm8
			// 
			this.ItemForm8.DataField = "ITEM_FORM_8";
			this.ItemForm8.Height = 0.15F;
			this.ItemForm8.Left = 0.1875F;
			this.ItemForm8.Name = "ItemForm8";
			this.ItemForm8.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm8.Text = "FORMAT";
			this.ItemForm8.Top = 2.3125F;
			this.ItemForm8.Visible = false;
			this.ItemForm8.Width = 0.75F;
			// 
			// ItemForm9
			// 
			this.ItemForm9.DataField = "ITEM_FORM_9";
			this.ItemForm9.Height = 0.15F;
			this.ItemForm9.Left = 0.1875F;
			this.ItemForm9.Name = "ItemForm9";
			this.ItemForm9.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm9.Text = "FORMAT";
			this.ItemForm9.Top = 2.5F;
			this.ItemForm9.Visible = false;
			this.ItemForm9.Width = 0.75F;
			// 
			// ItemForm10
			// 
			this.ItemForm10.DataField = "ITEM_FORM_10";
			this.ItemForm10.Height = 0.15F;
			this.ItemForm10.Left = 0.1875F;
			this.ItemForm10.Name = "ItemForm10";
			this.ItemForm10.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm10.Text = "FORMAT";
			this.ItemForm10.Top = 2.6875F;
			this.ItemForm10.Visible = false;
			this.ItemForm10.Width = 0.75F;
			// 
			// ItemForm11
			// 
			this.ItemForm11.DataField = "ITEM_FORM_11";
			this.ItemForm11.Height = 0.15F;
			this.ItemForm11.Left = 0.1875F;
			this.ItemForm11.Name = "ItemForm11";
			this.ItemForm11.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm11.Text = "FORMAT";
			this.ItemForm11.Top = 1F;
			this.ItemForm11.Visible = false;
			this.ItemForm11.Width = 0.75F;
			// 
			// ItemForm12
			// 
			this.ItemForm12.DataField = "ITEM_FORM_12";
			this.ItemForm12.Height = 0.15F;
			this.ItemForm12.Left = 0.1875F;
			this.ItemForm12.Name = "ItemForm12";
			this.ItemForm12.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm12.Text = "FORMAT";
			this.ItemForm12.Top = 1.1875F;
			this.ItemForm12.Visible = false;
			this.ItemForm12.Width = 0.75F;
			// 
			// ItemForm13
			// 
			this.ItemForm13.DataField = "ITEM_FORM_13";
			this.ItemForm13.Height = 0.15F;
			this.ItemForm13.Left = 0.1875F;
			this.ItemForm13.Name = "ItemForm13";
			this.ItemForm13.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm13.Text = "FORMAT";
			this.ItemForm13.Top = 1.375F;
			this.ItemForm13.Visible = false;
			this.ItemForm13.Width = 0.75F;
			// 
			// ItemForm14
			// 
			this.ItemForm14.DataField = "ITEM_FORM_14";
			this.ItemForm14.Height = 0.15F;
			this.ItemForm14.Left = 0.1875F;
			this.ItemForm14.Name = "ItemForm14";
			this.ItemForm14.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm14.Text = "FORMAT";
			this.ItemForm14.Top = 1.5625F;
			this.ItemForm14.Visible = false;
			this.ItemForm14.Width = 0.75F;
			// 
			// ItemForm15
			// 
			this.ItemForm15.DataField = "ITEM_FORM_15";
			this.ItemForm15.Height = 0.15F;
			this.ItemForm15.Left = 0.1875F;
			this.ItemForm15.Name = "ItemForm15";
			this.ItemForm15.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm15.Text = "FORMAT";
			this.ItemForm15.Top = 1.75F;
			this.ItemForm15.Visible = false;
			this.ItemForm15.Width = 0.75F;
			// 
			// ItemForm16
			// 
			this.ItemForm16.DataField = "ITEM_FORM_16";
			this.ItemForm16.Height = 0.15F;
			this.ItemForm16.Left = 0.1875F;
			this.ItemForm16.Name = "ItemForm16";
			this.ItemForm16.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm16.Text = "FORMAT";
			this.ItemForm16.Top = 1.9375F;
			this.ItemForm16.Visible = false;
			this.ItemForm16.Width = 0.75F;
			// 
			// ItemForm17
			// 
			this.ItemForm17.DataField = "ITEM_FORM_17";
			this.ItemForm17.Height = 0.15F;
			this.ItemForm17.Left = 0.1875F;
			this.ItemForm17.Name = "ItemForm17";
			this.ItemForm17.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm17.Text = "FORMAT";
			this.ItemForm17.Top = 2.125F;
			this.ItemForm17.Visible = false;
			this.ItemForm17.Width = 0.75F;
			// 
			// ItemForm18
			// 
			this.ItemForm18.DataField = "ITEM_FORM_18";
			this.ItemForm18.Height = 0.15F;
			this.ItemForm18.Left = 0.1875F;
			this.ItemForm18.Name = "ItemForm18";
			this.ItemForm18.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm18.Text = "FORMAT";
			this.ItemForm18.Top = 2.3125F;
			this.ItemForm18.Visible = false;
			this.ItemForm18.Width = 0.75F;
			// 
			// ItemForm19
			// 
			this.ItemForm19.DataField = "ITEM_FORM_19";
			this.ItemForm19.Height = 0.15F;
			this.ItemForm19.Left = 0.1875F;
			this.ItemForm19.Name = "ItemForm19";
			this.ItemForm19.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm19.Text = "FORMAT";
			this.ItemForm19.Top = 2.5F;
			this.ItemForm19.Visible = false;
			this.ItemForm19.Width = 0.75F;
			// 
			// ItemForm20
			// 
			this.ItemForm20.DataField = "ITEM_FORM_20";
			this.ItemForm20.Height = 0.15F;
			this.ItemForm20.Left = 0.1875F;
			this.ItemForm20.Name = "ItemForm20";
			this.ItemForm20.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm20.Text = "FORMAT";
			this.ItemForm20.Top = 2.6875F;
			this.ItemForm20.Visible = false;
			this.ItemForm20.Width = 0.75F;
			// 
			// ItemForm31
			// 
			this.ItemForm31.DataField = "ITEM_FORM_31";
			this.ItemForm31.Height = 0.15F;
			this.ItemForm31.Left = 0.1875F;
			this.ItemForm31.Name = "ItemForm31";
			this.ItemForm31.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm31.Text = "FORMAT";
			this.ItemForm31.Top = 1F;
			this.ItemForm31.Visible = false;
			this.ItemForm31.Width = 0.75F;
			// 
			// ItemForm22
			// 
			this.ItemForm22.DataField = "ITEM_FORM_22";
			this.ItemForm22.Height = 0.15F;
			this.ItemForm22.Left = 0.1875F;
			this.ItemForm22.Name = "ItemForm22";
			this.ItemForm22.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm22.Text = "FORMAT";
			this.ItemForm22.Top = 1.1875F;
			this.ItemForm22.Visible = false;
			this.ItemForm22.Width = 0.75F;
			// 
			// ItemForm23
			// 
			this.ItemForm23.DataField = "ITEM_FORM_23";
			this.ItemForm23.Height = 0.15F;
			this.ItemForm23.Left = 0.1875F;
			this.ItemForm23.Name = "ItemForm23";
			this.ItemForm23.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm23.Text = "FORMAT";
			this.ItemForm23.Top = 1.375F;
			this.ItemForm23.Visible = false;
			this.ItemForm23.Width = 0.75F;
			// 
			// ItemForm24
			// 
			this.ItemForm24.DataField = "ITEM_FORM_24";
			this.ItemForm24.Height = 0.15F;
			this.ItemForm24.Left = 0.1875F;
			this.ItemForm24.Name = "ItemForm24";
			this.ItemForm24.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm24.Text = "FORMAT";
			this.ItemForm24.Top = 1.5625F;
			this.ItemForm24.Visible = false;
			this.ItemForm24.Width = 0.75F;
			// 
			// ItemForm25
			// 
			this.ItemForm25.DataField = "ITEM_FORM_25";
			this.ItemForm25.Height = 0.15F;
			this.ItemForm25.Left = 0.1875F;
			this.ItemForm25.Name = "ItemForm25";
			this.ItemForm25.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm25.Text = "FORMAT";
			this.ItemForm25.Top = 1.75F;
			this.ItemForm25.Visible = false;
			this.ItemForm25.Width = 0.75F;
			// 
			// ItemForm26
			// 
			this.ItemForm26.DataField = "ITEM_FORM_26";
			this.ItemForm26.Height = 0.15F;
			this.ItemForm26.Left = 0.1875F;
			this.ItemForm26.Name = "ItemForm26";
			this.ItemForm26.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm26.Text = "FORMAT";
			this.ItemForm26.Top = 1.9375F;
			this.ItemForm26.Visible = false;
			this.ItemForm26.Width = 0.75F;
			// 
			// ItemForm27
			// 
			this.ItemForm27.DataField = "ITEM_FORM_27";
			this.ItemForm27.Height = 0.15F;
			this.ItemForm27.Left = 0.1875F;
			this.ItemForm27.Name = "ItemForm27";
			this.ItemForm27.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm27.Text = "FORMAT";
			this.ItemForm27.Top = 2.125F;
			this.ItemForm27.Visible = false;
			this.ItemForm27.Width = 0.75F;
			// 
			// ItemForm28
			// 
			this.ItemForm28.DataField = "ITEM_FORM_28";
			this.ItemForm28.Height = 0.15F;
			this.ItemForm28.Left = 0.1875F;
			this.ItemForm28.Name = "ItemForm28";
			this.ItemForm28.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm28.Text = "FORMAT";
			this.ItemForm28.Top = 2.3125F;
			this.ItemForm28.Visible = false;
			this.ItemForm28.Width = 0.75F;
			// 
			// ItemForm29
			// 
			this.ItemForm29.DataField = "ITEM_FORM_29";
			this.ItemForm29.Height = 0.15F;
			this.ItemForm29.Left = 0.1875F;
			this.ItemForm29.Name = "ItemForm29";
			this.ItemForm29.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm29.Text = "FORMAT";
			this.ItemForm29.Top = 2.5F;
			this.ItemForm29.Visible = false;
			this.ItemForm29.Width = 0.75F;
			// 
			// ItemForm30
			// 
			this.ItemForm30.DataField = "ITEM_FORM_30";
			this.ItemForm30.Height = 0.15F;
			this.ItemForm30.Left = 0.1875F;
			this.ItemForm30.Name = "ItemForm30";
			this.ItemForm30.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm30.Text = "FORMAT";
			this.ItemForm30.Top = 2.6875F;
			this.ItemForm30.Visible = false;
			this.ItemForm30.Width = 0.75F;
			// 
			// ItemForm21
			// 
			this.ItemForm21.DataField = "ITEM_FORM_21";
			this.ItemForm21.Height = 0.15F;
			this.ItemForm21.Left = 0.1875F;
			this.ItemForm21.Name = "ItemForm21";
			this.ItemForm21.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm21.Text = "FORMAT";
			this.ItemForm21.Top = 1F;
			this.ItemForm21.Visible = false;
			this.ItemForm21.Width = 0.75F;
			// 
			// ItemForm32
			// 
			this.ItemForm32.DataField = "ITEM_FORM_32";
			this.ItemForm32.Height = 0.15F;
			this.ItemForm32.Left = 0.1875F;
			this.ItemForm32.Name = "ItemForm32";
			this.ItemForm32.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm32.Text = "FORMAT";
			this.ItemForm32.Top = 1.1875F;
			this.ItemForm32.Visible = false;
			this.ItemForm32.Width = 0.75F;
			// 
			// ItemForm33
			// 
			this.ItemForm33.DataField = "ITEM_FORM_33";
			this.ItemForm33.Height = 0.15F;
			this.ItemForm33.Left = 0.1875F;
			this.ItemForm33.Name = "ItemForm33";
			this.ItemForm33.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm33.Text = "FORMAT";
			this.ItemForm33.Top = 1.375F;
			this.ItemForm33.Visible = false;
			this.ItemForm33.Width = 0.75F;
			// 
			// ItemForm34
			// 
			this.ItemForm34.DataField = "ITEM_FORM_34";
			this.ItemForm34.Height = 0.15F;
			this.ItemForm34.Left = 0.1875F;
			this.ItemForm34.Name = "ItemForm34";
			this.ItemForm34.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm34.Text = "FORMAT";
			this.ItemForm34.Top = 1.5625F;
			this.ItemForm34.Visible = false;
			this.ItemForm34.Width = 0.75F;
			// 
			// ItemForm35
			// 
			this.ItemForm35.DataField = "ITEM_FORM_35";
			this.ItemForm35.Height = 0.15F;
			this.ItemForm35.Left = 0.1875F;
			this.ItemForm35.Name = "ItemForm35";
			this.ItemForm35.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm35.Text = "FORMAT";
			this.ItemForm35.Top = 1.75F;
			this.ItemForm35.Visible = false;
			this.ItemForm35.Width = 0.75F;
			// 
			// ItemForm36
			// 
			this.ItemForm36.DataField = "ITEM_FORM_36";
			this.ItemForm36.Height = 0.15F;
			this.ItemForm36.Left = 0.1875F;
			this.ItemForm36.Name = "ItemForm36";
			this.ItemForm36.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm36.Text = "FORMAT";
			this.ItemForm36.Top = 1.9375F;
			this.ItemForm36.Visible = false;
			this.ItemForm36.Width = 0.75F;
			// 
			// ItemForm37
			// 
			this.ItemForm37.DataField = "ITEM_FORM_37";
			this.ItemForm37.Height = 0.15F;
			this.ItemForm37.Left = 0.1875F;
			this.ItemForm37.Name = "ItemForm37";
			this.ItemForm37.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm37.Text = "FORMAT";
			this.ItemForm37.Top = 2.125F;
			this.ItemForm37.Visible = false;
			this.ItemForm37.Width = 0.75F;
			// 
			// ItemForm38
			// 
			this.ItemForm38.DataField = "ITEM_FORM_38";
			this.ItemForm38.Height = 0.15F;
			this.ItemForm38.Left = 0.1875F;
			this.ItemForm38.Name = "ItemForm38";
			this.ItemForm38.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm38.Text = "FORMAT";
			this.ItemForm38.Top = 2.3125F;
			this.ItemForm38.Visible = false;
			this.ItemForm38.Width = 0.75F;
			// 
			// ItemForm39
			// 
			this.ItemForm39.DataField = "ITEM_FORM_39";
			this.ItemForm39.Height = 0.15F;
			this.ItemForm39.Left = 0.1875F;
			this.ItemForm39.Name = "ItemForm39";
			this.ItemForm39.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm39.Text = "FORMAT";
			this.ItemForm39.Top = 2.5F;
			this.ItemForm39.Visible = false;
			this.ItemForm39.Width = 0.75F;
			// 
			// ItemForm40
			// 
			this.ItemForm40.DataField = "ITEM_FORM_40";
			this.ItemForm40.Height = 0.15F;
			this.ItemForm40.Left = 0.1875F;
			this.ItemForm40.Name = "ItemForm40";
			this.ItemForm40.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm40.Text = "FORMAT";
			this.ItemForm40.Top = 2.6875F;
			this.ItemForm40.Visible = false;
			this.ItemForm40.Width = 0.75F;
			// 
			// ItemForm41
			// 
			this.ItemForm41.DataField = "ITEM_FORM_41";
			this.ItemForm41.Height = 0.15F;
			this.ItemForm41.Left = 0.1875F;
			this.ItemForm41.Name = "ItemForm41";
			this.ItemForm41.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm41.Text = "FORMAT";
			this.ItemForm41.Top = 1F;
			this.ItemForm41.Visible = false;
			this.ItemForm41.Width = 0.75F;
			// 
			// ItemForm42
			// 
			this.ItemForm42.DataField = "ITEM_FORM_42";
			this.ItemForm42.Height = 0.15F;
			this.ItemForm42.Left = 0.1875F;
			this.ItemForm42.Name = "ItemForm42";
			this.ItemForm42.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm42.Text = "FORMAT";
			this.ItemForm42.Top = 1.1875F;
			this.ItemForm42.Visible = false;
			this.ItemForm42.Width = 0.75F;
			// 
			// ItemForm43
			// 
			this.ItemForm43.DataField = "ITEM_FORM_43";
			this.ItemForm43.Height = 0.15F;
			this.ItemForm43.Left = 0.1875F;
			this.ItemForm43.Name = "ItemForm43";
			this.ItemForm43.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm43.Text = "FORMAT";
			this.ItemForm43.Top = 1.375F;
			this.ItemForm43.Visible = false;
			this.ItemForm43.Width = 0.75F;
			// 
			// ItemForm44
			// 
			this.ItemForm44.DataField = "ITEM_FORM_44";
			this.ItemForm44.Height = 0.15F;
			this.ItemForm44.Left = 0.1875F;
			this.ItemForm44.Name = "ItemForm44";
			this.ItemForm44.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm44.Text = "FORMAT";
			this.ItemForm44.Top = 1.5625F;
			this.ItemForm44.Visible = false;
			this.ItemForm44.Width = 0.75F;
			// 
			// ItemForm45
			// 
			this.ItemForm45.DataField = "ITEM_FORM_45";
			this.ItemForm45.Height = 0.15F;
			this.ItemForm45.Left = 0.1875F;
			this.ItemForm45.Name = "ItemForm45";
			this.ItemForm45.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm45.Text = "FORMAT";
			this.ItemForm45.Top = 1.75F;
			this.ItemForm45.Visible = false;
			this.ItemForm45.Width = 0.75F;
			// 
			// ItemForm46
			// 
			this.ItemForm46.DataField = "ITEM_FORM_46";
			this.ItemForm46.Height = 0.15F;
			this.ItemForm46.Left = 0.1875F;
			this.ItemForm46.Name = "ItemForm46";
			this.ItemForm46.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm46.Text = "FORMAT";
			this.ItemForm46.Top = 1.9375F;
			this.ItemForm46.Visible = false;
			this.ItemForm46.Width = 0.75F;
			// 
			// ItemForm47
			// 
			this.ItemForm47.DataField = "ITEM_FORM_47";
			this.ItemForm47.Height = 0.15F;
			this.ItemForm47.Left = 0.1875F;
			this.ItemForm47.Name = "ItemForm47";
			this.ItemForm47.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm47.Text = "FORMAT";
			this.ItemForm47.Top = 2.125F;
			this.ItemForm47.Visible = false;
			this.ItemForm47.Width = 0.75F;
			// 
			// ItemForm48
			// 
			this.ItemForm48.DataField = "ITEM_FORM_48";
			this.ItemForm48.Height = 0.15F;
			this.ItemForm48.Left = 0.1875F;
			this.ItemForm48.Name = "ItemForm48";
			this.ItemForm48.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm48.Text = "FORMAT";
			this.ItemForm48.Top = 2.3125F;
			this.ItemForm48.Visible = false;
			this.ItemForm48.Width = 0.75F;
			// 
			// ItemForm49
			// 
			this.ItemForm49.DataField = "ITEM_FORM_49";
			this.ItemForm49.Height = 0.15F;
			this.ItemForm49.Left = 0.1875F;
			this.ItemForm49.Name = "ItemForm49";
			this.ItemForm49.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm49.Text = "FORMAT";
			this.ItemForm49.Top = 2.5F;
			this.ItemForm49.Visible = false;
			this.ItemForm49.Width = 0.75F;
			// 
			// ItemForm50
			// 
			this.ItemForm50.DataField = "ITEM_FORM_50";
			this.ItemForm50.Height = 0.15F;
			this.ItemForm50.Left = 0.1875F;
			this.ItemForm50.Name = "ItemForm50";
			this.ItemForm50.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm50.Text = "FORMAT";
			this.ItemForm50.Top = 2.6875F;
			this.ItemForm50.Visible = false;
			this.ItemForm50.Width = 0.75F;
			// 
			// ItemForm51
			// 
			this.ItemForm51.DataField = "ITEM_FORM_51";
			this.ItemForm51.Height = 0.15F;
			this.ItemForm51.Left = 0.1875F;
			this.ItemForm51.Name = "ItemForm51";
			this.ItemForm51.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm51.Text = "FORMAT";
			this.ItemForm51.Top = 1F;
			this.ItemForm51.Visible = false;
			this.ItemForm51.Width = 0.75F;
			// 
			// ItemForm52
			// 
			this.ItemForm52.DataField = "ITEM_FORM_52";
			this.ItemForm52.Height = 0.15F;
			this.ItemForm52.Left = 0.1875F;
			this.ItemForm52.Name = "ItemForm52";
			this.ItemForm52.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm52.Text = "FORMAT";
			this.ItemForm52.Top = 1.1875F;
			this.ItemForm52.Visible = false;
			this.ItemForm52.Width = 0.75F;
			// 
			// ItemForm53
			// 
			this.ItemForm53.DataField = "ITEM_FORM_53";
			this.ItemForm53.Height = 0.15F;
			this.ItemForm53.Left = 0.1875F;
			this.ItemForm53.Name = "ItemForm53";
			this.ItemForm53.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm53.Text = "FORMAT";
			this.ItemForm53.Top = 1.375F;
			this.ItemForm53.Visible = false;
			this.ItemForm53.Width = 0.75F;
			// 
			// ItemForm54
			// 
			this.ItemForm54.DataField = "ITEM_FORM_54";
			this.ItemForm54.Height = 0.15F;
			this.ItemForm54.Left = 0.1875F;
			this.ItemForm54.Name = "ItemForm54";
			this.ItemForm54.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm54.Text = "FORMAT";
			this.ItemForm54.Top = 1.5625F;
			this.ItemForm54.Visible = false;
			this.ItemForm54.Width = 0.75F;
			// 
			// ItemForm55
			// 
			this.ItemForm55.DataField = "ITEM_FORM_55";
			this.ItemForm55.Height = 0.15F;
			this.ItemForm55.Left = 0.1875F;
			this.ItemForm55.Name = "ItemForm55";
			this.ItemForm55.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm55.Text = "FORMAT";
			this.ItemForm55.Top = 1.75F;
			this.ItemForm55.Visible = false;
			this.ItemForm55.Width = 0.75F;
			// 
			// ItemForm56
			// 
			this.ItemForm56.DataField = "ITEM_FORM_56";
			this.ItemForm56.Height = 0.15F;
			this.ItemForm56.Left = 0.1875F;
			this.ItemForm56.Name = "ItemForm56";
			this.ItemForm56.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm56.Text = "FORMAT";
			this.ItemForm56.Top = 1.9375F;
			this.ItemForm56.Visible = false;
			this.ItemForm56.Width = 0.75F;
			// 
			// ItemForm57
			// 
			this.ItemForm57.DataField = "ITEM_FORM_57";
			this.ItemForm57.Height = 0.15F;
			this.ItemForm57.Left = 0.1875F;
			this.ItemForm57.Name = "ItemForm57";
			this.ItemForm57.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm57.Text = "FORMAT";
			this.ItemForm57.Top = 2.125F;
			this.ItemForm57.Visible = false;
			this.ItemForm57.Width = 0.75F;
			// 
			// ItemForm58
			// 
			this.ItemForm58.DataField = "ITEM_FORM_58";
			this.ItemForm58.Height = 0.15F;
			this.ItemForm58.Left = 0.1875F;
			this.ItemForm58.Name = "ItemForm58";
			this.ItemForm58.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm58.Text = "FORMAT";
			this.ItemForm58.Top = 2.3125F;
			this.ItemForm58.Visible = false;
			this.ItemForm58.Width = 0.75F;
			// 
			// ItemForm59
			// 
			this.ItemForm59.DataField = "ITEM_FORM_59";
			this.ItemForm59.Height = 0.15F;
			this.ItemForm59.Left = 0.1875F;
			this.ItemForm59.Name = "ItemForm59";
			this.ItemForm59.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm59.Text = "FORMAT";
			this.ItemForm59.Top = 2.5F;
			this.ItemForm59.Visible = false;
			this.ItemForm59.Width = 0.75F;
			// 
			// ItemForm60
			// 
			this.ItemForm60.DataField = "ITEM_FORM_60";
			this.ItemForm60.Height = 0.15F;
			this.ItemForm60.Left = 0.1875F;
			this.ItemForm60.Name = "ItemForm60";
			this.ItemForm60.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm60.Text = "FORMAT";
			this.ItemForm60.Top = 2.6875F;
			this.ItemForm60.Visible = false;
			this.ItemForm60.Width = 0.75F;
			// 
			// ItemForm61
			// 
			this.ItemForm61.DataField = "ITEM_FORM_61";
			this.ItemForm61.Height = 0.15F;
			this.ItemForm61.Left = 0.1875F;
			this.ItemForm61.Name = "ItemForm61";
			this.ItemForm61.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm61.Text = "FORMAT";
			this.ItemForm61.Top = 1F;
			this.ItemForm61.Visible = false;
			this.ItemForm61.Width = 0.75F;
			// 
			// ItemForm62
			// 
			this.ItemForm62.DataField = "ITEM_FORM_62";
			this.ItemForm62.Height = 0.15F;
			this.ItemForm62.Left = 0.1875F;
			this.ItemForm62.Name = "ItemForm62";
			this.ItemForm62.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm62.Text = "FORMAT";
			this.ItemForm62.Top = 1.1875F;
			this.ItemForm62.Visible = false;
			this.ItemForm62.Width = 0.75F;
			// 
			// ItemForm63
			// 
			this.ItemForm63.DataField = "ITEM_FORM_63";
			this.ItemForm63.Height = 0.15F;
			this.ItemForm63.Left = 0.1875F;
			this.ItemForm63.Name = "ItemForm63";
			this.ItemForm63.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm63.Text = "FORMAT";
			this.ItemForm63.Top = 1.375F;
			this.ItemForm63.Visible = false;
			this.ItemForm63.Width = 0.75F;
			// 
			// ItemForm64
			// 
			this.ItemForm64.DataField = "ITEM_FORM_64";
			this.ItemForm64.Height = 0.15F;
			this.ItemForm64.Left = 0.1875F;
			this.ItemForm64.Name = "ItemForm64";
			this.ItemForm64.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm64.Text = "FORMAT";
			this.ItemForm64.Top = 1.5625F;
			this.ItemForm64.Visible = false;
			this.ItemForm64.Width = 0.75F;
			// 
			// ItemForm65
			// 
			this.ItemForm65.DataField = "ITEM_FORM_65";
			this.ItemForm65.Height = 0.15F;
			this.ItemForm65.Left = 0.1875F;
			this.ItemForm65.Name = "ItemForm65";
			this.ItemForm65.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm65.Text = "FORMAT";
			this.ItemForm65.Top = 1.75F;
			this.ItemForm65.Visible = false;
			this.ItemForm65.Width = 0.75F;
			// 
			// ItemForm66
			// 
			this.ItemForm66.DataField = "ITEM_FORM_66";
			this.ItemForm66.Height = 0.15F;
			this.ItemForm66.Left = 0.1875F;
			this.ItemForm66.Name = "ItemForm66";
			this.ItemForm66.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm66.Text = "FORMAT";
			this.ItemForm66.Top = 1.9375F;
			this.ItemForm66.Visible = false;
			this.ItemForm66.Width = 0.75F;
			// 
			// ItemForm67
			// 
			this.ItemForm67.DataField = "ITEM_FORM_67";
			this.ItemForm67.Height = 0.15F;
			this.ItemForm67.Left = 0.1875F;
			this.ItemForm67.Name = "ItemForm67";
			this.ItemForm67.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm67.Text = "FORMAT";
			this.ItemForm67.Top = 2.125F;
			this.ItemForm67.Visible = false;
			this.ItemForm67.Width = 0.75F;
			// 
			// ItemForm68
			// 
			this.ItemForm68.DataField = "ITEM_FORM_68";
			this.ItemForm68.Height = 0.15F;
			this.ItemForm68.Left = 0.1875F;
			this.ItemForm68.Name = "ItemForm68";
			this.ItemForm68.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm68.Text = "FORMAT";
			this.ItemForm68.Top = 2.3125F;
			this.ItemForm68.Visible = false;
			this.ItemForm68.Width = 0.75F;
			// 
			// ItemForm69
			// 
			this.ItemForm69.DataField = "ITEM_FORM_69";
			this.ItemForm69.Height = 0.15F;
			this.ItemForm69.Left = 0.1875F;
			this.ItemForm69.Name = "ItemForm69";
			this.ItemForm69.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm69.Text = "FORMAT";
			this.ItemForm69.Top = 2.5F;
			this.ItemForm69.Visible = false;
			this.ItemForm69.Width = 0.75F;
			// 
			// ItemForm70
			// 
			this.ItemForm70.DataField = "ITEM_FORM_70";
			this.ItemForm70.Height = 0.15F;
			this.ItemForm70.Left = 0.1875F;
			this.ItemForm70.Name = "ItemForm70";
			this.ItemForm70.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm70.Text = "FORMAT";
			this.ItemForm70.Top = 2.6875F;
			this.ItemForm70.Visible = false;
			this.ItemForm70.Width = 0.75F;
			// 
			// ItemForm71
			// 
			this.ItemForm71.DataField = "ITEM_FORM_71";
			this.ItemForm71.Height = 0.15F;
			this.ItemForm71.Left = 0.1875F;
			this.ItemForm71.Name = "ItemForm71";
			this.ItemForm71.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm71.Text = "FORMAT";
			this.ItemForm71.Top = 1F;
			this.ItemForm71.Visible = false;
			this.ItemForm71.Width = 0.75F;
			// 
			// ItemForm72
			// 
			this.ItemForm72.DataField = "ITEM_FORM_72";
			this.ItemForm72.Height = 0.15F;
			this.ItemForm72.Left = 0.1875F;
			this.ItemForm72.Name = "ItemForm72";
			this.ItemForm72.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm72.Text = "FORMAT";
			this.ItemForm72.Top = 1.1875F;
			this.ItemForm72.Visible = false;
			this.ItemForm72.Width = 0.75F;
			// 
			// ItemForm73
			// 
			this.ItemForm73.DataField = "ITEM_FORM_73";
			this.ItemForm73.Height = 0.15F;
			this.ItemForm73.Left = 0.1875F;
			this.ItemForm73.Name = "ItemForm73";
			this.ItemForm73.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm73.Text = "FORMAT";
			this.ItemForm73.Top = 1.375F;
			this.ItemForm73.Visible = false;
			this.ItemForm73.Width = 0.75F;
			// 
			// ItemForm74
			// 
			this.ItemForm74.DataField = "ITEM_FORM_74";
			this.ItemForm74.Height = 0.15F;
			this.ItemForm74.Left = 0.1875F;
			this.ItemForm74.Name = "ItemForm74";
			this.ItemForm74.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm74.Text = "FORMAT";
			this.ItemForm74.Top = 1.5625F;
			this.ItemForm74.Visible = false;
			this.ItemForm74.Width = 0.75F;
			// 
			// ItemForm75
			// 
			this.ItemForm75.DataField = "ITEM_FORM_75";
			this.ItemForm75.Height = 0.15F;
			this.ItemForm75.Left = 0.1875F;
			this.ItemForm75.Name = "ItemForm75";
			this.ItemForm75.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm75.Text = "FORMAT";
			this.ItemForm75.Top = 1.75F;
			this.ItemForm75.Visible = false;
			this.ItemForm75.Width = 0.75F;
			// 
			// ItemForm76
			// 
			this.ItemForm76.DataField = "ITEM_FORM_76";
			this.ItemForm76.Height = 0.15F;
			this.ItemForm76.Left = 0.1875F;
			this.ItemForm76.Name = "ItemForm76";
			this.ItemForm76.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm76.Text = "FORMAT";
			this.ItemForm76.Top = 1.9375F;
			this.ItemForm76.Visible = false;
			this.ItemForm76.Width = 0.75F;
			// 
			// ItemForm77
			// 
			this.ItemForm77.DataField = "ITEM_FORM_77";
			this.ItemForm77.Height = 0.15F;
			this.ItemForm77.Left = 0.1875F;
			this.ItemForm77.Name = "ItemForm77";
			this.ItemForm77.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm77.Text = "FORMAT";
			this.ItemForm77.Top = 2.125F;
			this.ItemForm77.Visible = false;
			this.ItemForm77.Width = 0.75F;
			// 
			// Label1
			// 
			this.Label1.Height = 0.15F;
			this.Label1.HyperLink = null;
			this.Label1.Left = 5.125F;
			this.Label1.Name = "Label1";
			this.Label1.Style = "font-size: 8.5pt; vertical-align: bottom; ddo-char-set: 1";
			this.Label1.Text = "支給日";
			this.Label1.Top = 0.6875F;
			this.Label1.Width = 0.5000001F;
			// 
			// PaymntYm
			// 
			this.PaymntYm.DataField = "PAYMNT_YM";
			this.PaymntYm.Height = 0.1875F;
			this.PaymntYm.Left = 0.8125F;
			this.PaymntYm.Name = "PaymntYm";
			this.PaymntYm.Style = "font-size: 9pt; vertical-align: bottom; ddo-char-set: 1";
			this.PaymntYm.Text = "9999年99月度";
			this.PaymntYm.Top = 0.3125F;
			this.PaymntYm.Width = 1F;
			// 
			// BnsDate
			// 
			this.BnsDate.DataField = "BNS_DATE";
			this.BnsDate.Height = 0.15F;
			this.BnsDate.Left = 5.625F;
			this.BnsDate.Name = "BnsDate";
			this.BnsDate.Style = "font-size: 8.5pt; vertical-align: bottom; ddo-char-set: 1";
			this.BnsDate.Text = "9999年99月99日";
			this.BnsDate.Top = 0.6875F;
			this.BnsDate.Width = 1.0625F;
			// 
			// ItemName78
			// 
			this.ItemName78.DataField = "ITEM_NAME_78";
			this.ItemName78.Height = 0.15F;
			this.ItemName78.Left = 1.033F;
			this.ItemName78.Name = "ItemName78";
			this.ItemName78.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName78.Text = "あいうえおかきく";
			this.ItemName78.Top = 4.188F;
			this.ItemName78.Width = 0.95F;
			// 
			// ItemValue78
			// 
			this.ItemValue78.DataField = "ITEM_VALUE_78";
			this.ItemValue78.Height = 0.15F;
			this.ItemValue78.Left = 1.033F;
			this.ItemValue78.Name = "ItemValue78";
			this.ItemValue78.OutputFormat = "#,##0.000";
			this.ItemValue78.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue78.Text = "99,999,999.999";
			this.ItemValue78.Top = 4.352999F;
			this.ItemValue78.Width = 0.88F;
			// 
			// ItemName79
			// 
			this.ItemName79.DataField = "ITEM_NAME_79";
			this.ItemName79.Height = 0.15F;
			this.ItemName79.Left = 1.931F;
			this.ItemName79.Name = "ItemName79";
			this.ItemName79.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName79.Text = "あいうえおかきく";
			this.ItemName79.Top = 4.188F;
			this.ItemName79.Width = 0.95F;
			// 
			// ItemValue79
			// 
			this.ItemValue79.DataField = "ITEM_VALUE_79";
			this.ItemValue79.Height = 0.15F;
			this.ItemValue79.Left = 1.931F;
			this.ItemValue79.Name = "ItemValue79";
			this.ItemValue79.OutputFormat = "#,##0.000";
			this.ItemValue79.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue79.Text = "99,999,999.999";
			this.ItemValue79.Top = 4.352999F;
			this.ItemValue79.Width = 0.88F;
			// 
			// ItemForm78
			// 
			this.ItemForm78.DataField = "ITEM_FORM_78";
			this.ItemForm78.Height = 0.15F;
			this.ItemForm78.Left = 0.1875F;
			this.ItemForm78.Name = "ItemForm78";
			this.ItemForm78.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm78.Text = "FORMAT";
			this.ItemForm78.Top = 2.6875F;
			this.ItemForm78.Visible = false;
			this.ItemForm78.Width = 0.75F;
			// 
			// ItemForm79
			// 
			this.ItemForm79.DataField = "ITEM_FORM_79";
			this.ItemForm79.Height = 0.15F;
			this.ItemForm79.Left = 0.1875F;
			this.ItemForm79.Name = "ItemForm79";
			this.ItemForm79.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm79.Text = "FORMAT";
			this.ItemForm79.Top = 2.3125F;
			this.ItemForm79.Visible = false;
			this.ItemForm79.Width = 0.75F;
			// 
			// label2
			// 
			this.label2.Height = 0.25F;
			this.label2.HyperLink = null;
			this.label2.Left = 6.8125F;
			this.label2.Name = "label2";
			this.label2.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label2.Text = "表";
			this.label2.Top = 0.3125F;
			this.label2.Width = 0.2499999F;
			// 
			// label3
			// 
			this.label3.Height = 0.25F;
			this.label3.HyperLink = null;
			this.label3.Left = 7.0625F;
			this.label3.Name = "label3";
			this.label3.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label3.Text = "障";
			this.label3.Top = 0.3125F;
			this.label3.Width = 0.2499999F;
			// 
			// label4
			// 
			this.label4.Height = 0.25F;
			this.label4.HyperLink = null;
			this.label4.Left = 7.3125F;
			this.label4.Name = "label4";
			this.label4.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label4.Text = "寡";
			this.label4.Top = 0.3125F;
			this.label4.Width = 0.2499999F;
			// 
			// label5
			// 
			this.label5.Height = 0.25F;
			this.label5.HyperLink = null;
			this.label5.Left = 7.5625F;
			this.label5.Name = "label5";
			this.label5.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label5.Text = "勤";
			this.label5.Top = 0.3125F;
			this.label5.Width = 0.2499999F;
			// 
			// label6
			// 
			this.label6.Height = 0.25F;
			this.label6.HyperLink = null;
			this.label6.Left = 7.8125F;
			this.label6.Name = "label6";
			this.label6.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label6.Text = "扶";
			this.label6.Top = 0.3125F;
			this.label6.Width = 0.25F;
			// 
			// TaxType
			// 
			this.TaxType.DataField = "TAX_TYPE";
			this.TaxType.Height = 0.25F;
			this.TaxType.Left = 6.8125F;
			this.TaxType.Name = "TaxType";
			this.TaxType.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.TaxType.Text = "○";
			this.TaxType.Top = 0.5625F;
			this.TaxType.Width = 0.2499999F;
			// 
			// HandiType
			// 
			this.HandiType.DataField = "HANDI_TYPE";
			this.HandiType.Height = 0.25F;
			this.HandiType.Left = 7.0625F;
			this.HandiType.Name = "HandiType";
			this.HandiType.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.HandiType.Text = "○";
			this.HandiType.Top = 0.5625F;
			this.HandiType.Width = 0.2499999F;
			// 
			// WidowType
			// 
			this.WidowType.DataField = "WIDOW_TYPE";
			this.WidowType.Height = 0.25F;
			this.WidowType.Left = 7.3125F;
			this.WidowType.Name = "WidowType";
			this.WidowType.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.WidowType.Text = "○";
			this.WidowType.Top = 0.5625F;
			this.WidowType.Width = 0.2499999F;
			// 
			// WrkStdType
			// 
			this.WrkStdType.DataField = "WRK_STD_TYPE";
			this.WrkStdType.Height = 0.25F;
			this.WrkStdType.Left = 7.5625F;
			this.WrkStdType.Name = "WrkStdType";
			this.WrkStdType.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.WrkStdType.Text = "○";
			this.WrkStdType.Top = 0.5625F;
			this.WrkStdType.Width = 0.2499999F;
			// 
			// DpndTotalNum
			// 
			this.DpndTotalNum.DataField = "DPND_TOTAL_NUM";
			this.DpndTotalNum.Height = 0.25F;
			this.DpndTotalNum.Left = 7.8125F;
			this.DpndTotalNum.Name = "DpndTotalNum";
			this.DpndTotalNum.Style = "font-size: 8.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.DpndTotalNum.Text = "66";
			this.DpndTotalNum.Top = 0.5625F;
			this.DpndTotalNum.Width = 0.25F;
			// 
			// line3
			// 
			this.line3.Height = 0.5F;
			this.line3.Left = 7.0625F;
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.Top = 0.3125F;
			this.line3.Width = 0F;
			this.line3.X1 = 7.0625F;
			this.line3.X2 = 7.0625F;
			this.line3.Y1 = 0.3125F;
			this.line3.Y2 = 0.8125F;
			// 
			// line4
			// 
			this.line4.Height = 0.5F;
			this.line4.Left = 7.5625F;
			this.line4.LineWeight = 1F;
			this.line4.Name = "line4";
			this.line4.Top = 0.3125F;
			this.line4.Width = 0F;
			this.line4.X1 = 7.5625F;
			this.line4.X2 = 7.5625F;
			this.line4.Y1 = 0.3125F;
			this.line4.Y2 = 0.8125F;
			// 
			// line5
			// 
			this.line5.Height = 0.5F;
			this.line5.Left = 7.3125F;
			this.line5.LineWeight = 1F;
			this.line5.Name = "line5";
			this.line5.Top = 0.3125F;
			this.line5.Width = 0F;
			this.line5.X1 = 7.3125F;
			this.line5.X2 = 7.3125F;
			this.line5.Y1 = 0.3125F;
			this.line5.Y2 = 0.8125F;
			// 
			// line6
			// 
			this.line6.Height = 0.5F;
			this.line6.Left = 7.8125F;
			this.line6.LineWeight = 1F;
			this.line6.Name = "line6";
			this.line6.Top = 0.3125F;
			this.line6.Width = 0F;
			this.line6.X1 = 7.8125F;
			this.line6.X2 = 7.8125F;
			this.line6.Y1 = 0.3125F;
			this.line6.Y2 = 0.8125F;
			// 
			// line7
			// 
			this.line7.Height = 0.5F;
			this.line7.Left = 8.0625F;
			this.line7.LineWeight = 1F;
			this.line7.Name = "line7";
			this.line7.Top = 0.3125F;
			this.line7.Width = 0F;
			this.line7.X1 = 8.0625F;
			this.line7.X2 = 8.0625F;
			this.line7.Y1 = 0.3125F;
			this.line7.Y2 = 0.8125F;
			// 
			// line8
			// 
			this.line8.Height = 0F;
			this.line8.Left = 6.8125F;
			this.line8.LineWeight = 1F;
			this.line8.Name = "line8";
			this.line8.Top = 0.8125F;
			this.line8.Width = 1.25F;
			this.line8.X1 = 8.0625F;
			this.line8.X2 = 6.8125F;
			this.line8.Y1 = 0.8125F;
			this.line8.Y2 = 0.8125F;
			// 
			// line17
			// 
			this.line17.Height = 0F;
			this.line17.Left = 6.8125F;
			this.line17.LineWeight = 1F;
			this.line17.Name = "line17";
			this.line17.Top = 0.5625F;
			this.line17.Width = 1.25F;
			this.line17.X1 = 8.0625F;
			this.line17.X2 = 6.8125F;
			this.line17.Y1 = 0.5625F;
			this.line17.Y2 = 0.5625F;
			// 
			// line18
			// 
			this.line18.Height = 0F;
			this.line18.Left = 6.8125F;
			this.line18.LineWeight = 1F;
			this.line18.Name = "line18";
			this.line18.Top = 0.3125F;
			this.line18.Width = 1.25F;
			this.line18.X1 = 8.0625F;
			this.line18.X2 = 6.8125F;
			this.line18.Y1 = 0.3125F;
			this.line18.Y2 = 0.3125F;
			// 
			// line19
			// 
			this.line19.Height = 0.5F;
			this.line19.Left = 6.8125F;
			this.line19.LineWeight = 1F;
			this.line19.Name = "line19";
			this.line19.Top = 0.3125F;
			this.line19.Width = 0F;
			this.line19.X1 = 6.8125F;
			this.line19.X2 = 6.8125F;
			this.line19.Y1 = 0.3125F;
			this.line19.Y2 = 0.8125F;
			// 
			// ItemName80
			// 
			this.ItemName80.DataField = "ITEM_NAME_80";
			this.ItemName80.Height = 0.15F;
			this.ItemName80.Left = 2.8125F;
			this.ItemName80.Name = "ItemName80";
			this.ItemName80.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName80.Text = "あいうえおかきく";
			this.ItemName80.Top = 4.1875F;
			this.ItemName80.Width = 0.95F;
			// 
			// ItemValue81
			// 
			this.ItemValue81.DataField = "ITEM_VALUE_81";
			this.ItemValue81.Height = 0.15F;
			this.ItemValue81.Left = 3.73F;
			this.ItemValue81.Name = "ItemValue81";
			this.ItemValue81.OutputFormat = "#,##0.000";
			this.ItemValue81.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue81.Text = "99,999,999.999";
			this.ItemValue81.Top = 4.35F;
			this.ItemValue81.Width = 0.88F;
			// 
			// ItemValue80
			// 
			this.ItemValue80.DataField = "ITEM_VALUE_80";
			this.ItemValue80.Height = 0.15F;
			this.ItemValue80.Left = 2.83F;
			this.ItemValue80.Name = "ItemValue80";
			this.ItemValue80.OutputFormat = "#,##0.000";
			this.ItemValue80.Style = "font-size: 8.5pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
			this.ItemValue80.Text = "99,999,999.999";
			this.ItemValue80.Top = 4.35F;
			this.ItemValue80.Width = 0.88F;
			// 
			// ItemName81
			// 
			this.ItemName81.DataField = "ITEM_NAME_81";
			this.ItemName81.Height = 0.15F;
			this.ItemName81.Left = 3.73F;
			this.ItemName81.Name = "ItemName81";
			this.ItemName81.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemName81.Text = "あいうえおかきく";
			this.ItemName81.Top = 4.1875F;
			this.ItemName81.Width = 0.95F;
			// 
			// ItemForm80
			// 
			this.ItemForm80.DataField = "ITEM_FORM_80";
			this.ItemForm80.Height = 0.15F;
			this.ItemForm80.Left = 0.1875F;
			this.ItemForm80.Name = "ItemForm80";
			this.ItemForm80.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm80.Text = "FORMAT";
			this.ItemForm80.Top = 2.875F;
			this.ItemForm80.Visible = false;
			this.ItemForm80.Width = 0.75F;
			// 
			// ItemForm81
			// 
			this.ItemForm81.DataField = "ITEM_FORM_81";
			this.ItemForm81.Height = 0.15F;
			this.ItemForm81.Left = 0.1875F;
			this.ItemForm81.Name = "ItemForm81";
			this.ItemForm81.Style = "font-size: 8.5pt; vertical-align: middle; ddo-char-set: 1";
			this.ItemForm81.Text = "FORMAT";
			this.ItemForm81.Top = 3.0625F;
			this.ItemForm81.Visible = false;
			this.ItemForm81.Width = 0.75F;
			// 
			// SlryRemitBankCode1
			// 
			this.SlryRemitBankCode1.DataField = "SLRY_REMIT_BANK_CODE_1";
			this.SlryRemitBankCode1.Height = 0.15F;
			this.SlryRemitBankCode1.Left = 1.03F;
			this.SlryRemitBankCode1.Name = "SlryRemitBankCode1";
			this.SlryRemitBankCode1.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryRemitBankCode1.Text = "(第1)銀行:0000";
			this.SlryRemitBankCode1.Top = 4.53F;
			this.SlryRemitBankCode1.Width = 0.82F;
			// 
			// SlryRemitBranchCode1
			// 
			this.SlryRemitBranchCode1.DataField = "SLRY_REMIT_BRANCH_CODE_1";
			this.SlryRemitBranchCode1.Height = 0.15F;
			this.SlryRemitBranchCode1.Left = 1.85F;
			this.SlryRemitBranchCode1.Name = "SlryRemitBranchCode1";
			this.SlryRemitBranchCode1.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryRemitBranchCode1.Text = "支店:000";
			this.SlryRemitBranchCode1.Top = 4.53F;
			this.SlryRemitBranchCode1.Width = 0.49F;
			// 
			// SlryAcCode1
			// 
			this.SlryAcCode1.DataField = "SLRY_AC_NO_1";
			this.SlryAcCode1.Height = 0.15F;
			this.SlryAcCode1.Left = 2.35F;
			this.SlryAcCode1.Name = "SlryAcCode1";
			this.SlryAcCode1.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryAcCode1.Text = "口座:0000000000";
			this.SlryAcCode1.Top = 4.53F;
			this.SlryAcCode1.Width = 0.87F;
			// 
			// SlryRemitBankCode2
			// 
			this.SlryRemitBankCode2.DataField = "SLRY_REMIT_BANK_CODE_2";
			this.SlryRemitBankCode2.Height = 0.15F;
			this.SlryRemitBankCode2.Left = 6.94F;
			this.SlryRemitBankCode2.Name = "SlryRemitBankCode2";
			this.SlryRemitBankCode2.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryRemitBankCode2.Text = "(第2)銀行:0000";
			this.SlryRemitBankCode2.Top = 4.53F;
			this.SlryRemitBankCode2.Width = 0.82F;
			// 
			// SlryRemitBranchCode2
			// 
			this.SlryRemitBranchCode2.DataField = "SLRY_REMIT_BRANCH_CODE_2";
			this.SlryRemitBranchCode2.Height = 0.15F;
			this.SlryRemitBranchCode2.Left = 7.76F;
			this.SlryRemitBranchCode2.Name = "SlryRemitBranchCode2";
			this.SlryRemitBranchCode2.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryRemitBranchCode2.Text = "支店:000";
			this.SlryRemitBranchCode2.Top = 4.53F;
			this.SlryRemitBranchCode2.Width = 0.49F;
			// 
			// SlryAcCode2
			// 
			this.SlryAcCode2.DataField = "SLRY_AC_NO_2";
			this.SlryAcCode2.Height = 0.15F;
			this.SlryAcCode2.Left = 8.24F;
			this.SlryAcCode2.Name = "SlryAcCode2";
			this.SlryAcCode2.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.SlryAcCode2.Text = "口座:0000000000";
			this.SlryAcCode2.Top = 4.53F;
			this.SlryAcCode2.Width = 0.87F;
			// 
			// MycompName
			// 
			this.MycompName.DataField = "MYCOMP_NAME";
			this.MycompName.Height = 0.15F;
			this.MycompName.Left = 3.7F;
			this.MycompName.Name = "MycompName";
			this.MycompName.Style = "font-size: 8pt; text-align: left; vertical-align: bottom; ddo-char-set: 1";
			this.MycompName.Text = "○○○○○○○○○○○○○○○○○○○○○○○○○";
			this.MycompName.Top = 4.53F;
			this.MycompName.Width = 2.9F;
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.DataField = "EMP_CODE";
			this.GroupHeader1.Height = 0F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.AfterPrint += new System.EventHandler(this.GroupHeader1_AfterPrint);
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// HR_PY_03_R06
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0F;
			this.PageSettings.Margins.Left = 0F;
			this.PageSettings.Margins.Right = 0F;
			this.PageSettings.Margins.Top = 0F;
			this.PageSettings.PaperHeight = 5F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PageSettings.PaperName = "ユーザー定義のサイズ";
			this.PageSettings.PaperWidth = 10F;
			this.PrintWidth = 10F;
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
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R06_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.AtacCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PaymntYm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BnsDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TaxType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WidowType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WrkStdType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndTotalNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemValue80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemName81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForm81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBankCode1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBranchCode1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryAcCode1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBankCode2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryRemitBranchCode2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlryAcCode2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MycompName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
