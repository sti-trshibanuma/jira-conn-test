// Product     : Allegro
// Unit        : HR
// Module      : PA
// Function    : 03
// File Name   : HR_PA_03_R07.cs
// 機能名      : HR_PA_03_R07 個人経歴書
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 1.4.0 2005/10/31
// 管理番号 K20207 2007/02/07 プロジェクトコード桁数拡張および複数プロジェクト管理
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
// 管理番号B24987 2025/02/17 前職歴情報の職種略名が7文字以上の場合、印刷時APエラーとなる不具合を修正

using System;
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PA_03_R07 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PA_03_R07()
		{


			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
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

		private void HR_PA_03_R07_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:縦
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;

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

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			BL_HR_Common com = BL_HR_Common.GetInstance();

			string birthYmdDateJP = com.GetDateFormatJP(this.BirthYmdJPText.Text);
			string entranceDateJP = com.GetDateFormatJP(this.InDateJPText.Text);
			string entranceDate2JP = com.GetDateFormatJP(this.InDate2JPText.Text);

			// 生年月日和暦表示
			this.BirthYmdJPText.Text = birthYmdDateJP == string.Empty ? " " : birthYmdDateJP;

			// 入社日和暦表示
			this.InDateJPText.Text = entranceDateJP == string.Empty ? " " : entranceDateJP;

			// 入社日２和暦表示
			this.InDate2JPText.Text = entranceDate2JP == string.Empty ? " " : entranceDate2JP;
		}


		private void GroupHeader1_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}


		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ReportIDText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox236 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label174 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label180 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label179 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label178 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label177 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjToDateText5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjToDateText4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjToDateText3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjToDateText2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjToDateText1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName17Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName16Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName20Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName19Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName17Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName18Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line118 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line121 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line125 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCodeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ZipText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AgeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line136 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label93 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label94 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label95 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label96 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label97 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastEduNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label98 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpNameKanaText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexTypeNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label99 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label100 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LengthServYyText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label101 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label102 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthYmdText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label103 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServPlNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label104 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label105 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label106 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label107 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox MarriYmdText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label108 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireDateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label109 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label110 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Adrs1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Adrs2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label111 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PhoneText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label112 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ChangeDateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label113 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label114 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label115 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate6 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate7 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfDate15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label130 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label132 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Job1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Job2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Job3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Job4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Job5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label133 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label134 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label135 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SHF_DATE_18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SHF_DATE_19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SHF_DATE_20 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDateText1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDateText2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDateText3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDateText4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDateText5 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label142 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label144 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpTodate9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpFromDate9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkExpName9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DayNightType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurTodate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurTodate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label152 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniFrom6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TraniName6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfObtainDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfObtainDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfObtainDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfObtainDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfObtainDate5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label159 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RwdPntName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label160 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label161 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label162 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label163 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveFromdate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveTodate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveReason1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveFromdate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveTodate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveFromdate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveTodate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveFromdate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveTodate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpRemarks9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveReason2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveReason3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveReason4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label164 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EndType6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label165 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ObtainType1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label166 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ObtainType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ObtainType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ObtainType4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox235 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName10Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName10Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName11Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName12Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName13Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName14Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName15Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName11Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName12Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName13Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName14Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName15Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName18Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName19Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacName20Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DayNightType2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DayNightType3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurTodate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurTodate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfName5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ObtainType5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line146 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line152 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line156 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line159 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line160 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line161 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line163 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line164 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line165 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line166 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line167 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line168 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line169 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line170 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line171 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line172 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line173 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line174 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line175 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line176 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line182 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line183 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line184 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line185 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line186 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line187 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line188 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line189 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line190 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line191 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line192 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line193 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line194 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line196 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line197 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line198 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line199 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line200 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line201 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line202 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line204 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line205 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line206 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line207 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line208 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line209 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line210 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line211 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line212 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line213 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line214 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line215 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line216 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line217 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line218 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line219 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line220 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line221 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line222 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line223 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line224 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line229 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line230 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line231 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line232 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LengthServMmText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth6Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth7Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth8Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodYear9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WordExpPeriodMonth9Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetirementDate1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetirementDate2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetirementDate3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetirementDate4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetirementDate5Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line234 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line235 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line236 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line237 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label175 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label176 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurAtacName1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurAtacName2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurAtacName3Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ConcurAtacName4Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line179 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line180 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line181 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line177 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthYmdJPText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDateJPText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDate2JPText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line238 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line239 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line240 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line241 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line242 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line243 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line244 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line245 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line246 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SHF_DATE_16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SHF_DATE_17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ShfTypeName16Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line178 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line162 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line247 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line233 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PA_03_R07));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.Label180 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label179 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label178 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label177 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjToDateText5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjToDateText4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjToDateText3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjToDateText2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjToDateText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName17Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName16Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ShfTypeName20Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName19Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName17Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName18Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line118 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line121 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line122 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line125 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.EmpCodeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ZipText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AgeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line136 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label93 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line137 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label94 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line139 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label95 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RankNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label96 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PostNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label97 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LastEduNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line140 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label98 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EmpNameKanaText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmpNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line141 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SexTypeNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label99 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label100 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LengthServYyText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label101 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label102 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.BirthYmdText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label103 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ServPlNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label104 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DutyNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label106 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label107 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.MarriYmdText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label108 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RetireDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label109 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label110 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Adrs1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Adrs2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label111 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PhoneText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label112 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ChangeDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label114 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label115 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ShfTypeName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfDate15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EntranceDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label132 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Job1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Job2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Job3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Job4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Job5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label133 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label134 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label135 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SHF_DATE_18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SHF_DATE_19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SHF_DATE_20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDateText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDateText2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDateText3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDateText4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDateText5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.WorkExpFromDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpTodate9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpFromDate9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WorkExpName9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EntraYm1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ClsName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DayNightType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label149 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ConcurDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurTodate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurTodate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TraniFrom1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniFrom2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniFrom3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniFrom4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label152 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label153 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TraniFrom5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniFrom6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TraniName6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.QualfObtainDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfObtainDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfObtainDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfObtainDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfObtainDate5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label157 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label158 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label159 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RwdPntDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RwdPntName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label160 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label161 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label162 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label163 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LeaveFromdate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveTodate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveReason1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveFromdate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveTodate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveFromdate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveTodate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveFromdate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveTodate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpRemarks9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveReason2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveReason3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LeaveReason4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EndType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label164 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EndType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EndType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EndType4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EndType5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EndType6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label165 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.QualfName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ObtainType1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label166 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.QualfName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ObtainType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ObtainType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ObtainType4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox235 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntraYm3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName10Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName10Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName11Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName12Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName13Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName14Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName15Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName11Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName12Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName13Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName14Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName15Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName18Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName19Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacName20Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ClsName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DayNightType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ClsName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DayNightType3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurTodate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurTodate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfName5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ObtainType5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line146 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line147 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line148 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line149 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line150 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line151 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line152 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line153 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line154 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line155 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line156 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line157 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line158 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line159 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line160 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line161 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line163 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line164 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line165 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line166 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line167 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line168 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line169 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line170 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line171 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line172 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line173 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line174 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line175 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line176 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line182 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line183 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line184 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line185 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line186 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line187 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line188 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line189 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line190 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line191 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line192 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line193 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line194 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line196 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line197 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line198 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line199 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line200 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line201 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line202 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line204 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line205 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line206 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line207 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line209 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line210 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line211 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line212 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line213 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line214 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line215 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line216 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line217 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line218 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line219 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line220 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line221 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line222 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line223 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line224 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line229 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line230 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line231 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line232 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.LengthServMmText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth6Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth7Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth8Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodYear9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.WordExpPeriodMonth9Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetirementDate1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetirementDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetirementDate3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetirementDate4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetirementDate5Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line234 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line235 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line145 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line236 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line237 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label175 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label176 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ConcurAtacName1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurAtacName2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurAtacName3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ConcurAtacName4Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line179 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line180 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line181 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line177 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.BirthYmdJPText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDateJPText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDate2JPText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line238 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line239 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line240 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line241 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line242 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line243 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line244 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line245 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line246 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SHF_DATE_16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SHF_DATE_17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ShfTypeName16Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line178 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line162 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line247 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line233 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ReportIDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox236 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label174 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.CompanyNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Label180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label179)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label178)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName17Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName16Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName20Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName19Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName17Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName18Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCodeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastEduNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpNameKanaText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthServYyText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label107)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MarriYmdText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label110)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChangeDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Job1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Job2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Job3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Job4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Job5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label159)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox235)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName10Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName10Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName11Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName12Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName13Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName14Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName15Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName11Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName12Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName13Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName14Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName15Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName18Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName19Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName20Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthServMmText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth6Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth7Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth8Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth9Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate5Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label176)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName4Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdJPText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateJPText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDate2JPText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName16Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox236)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label180,
            this.Label179,
            this.Label178,
            this.Label177,
            this.ProjToDateText5,
            this.ProjToDateText4,
            this.ProjToDateText3,
            this.ProjToDateText2,
            this.ProjToDateText1,
            this.AtacName17Text,
            this.AtacName16Text,
            this.ConcurDate1Text,
            this.Label148,
            this.ShfTypeName20Text,
            this.ShfTypeName19Text,
            this.ShfTypeName17Text,
            this.ShfTypeName18Text,
            this.Line118,
            this.Line121,
            this.Line122,
            this.Line125,
            this.EmpCodeText,
            this.ZipText,
            this.AgeText,
            this.ConcurNameText,
            this.Label5,
            this.Line136,
            this.Label93,
            this.Line137,
            this.Label94,
            this.Line139,
            this.Label95,
            this.RankNameText,
            this.Label96,
            this.PostNameText,
            this.Label97,
            this.LastEduNameText,
            this.Line140,
            this.Label98,
            this.EmpNameKanaText,
            this.EmpNameText,
            this.Line141,
            this.SexTypeNameText,
            this.Label99,
            this.Label100,
            this.LengthServYyText,
            this.InDate2Text,
            this.Label101,
            this.Label102,
            this.BirthYmdText,
            this.InDateText,
            this.Label103,
            this.ServPlNameText,
            this.Label104,
            this.Label105,
            this.DutyNameText,
            this.Label106,
            this.Label107,
            this.MarriYmdText,
            this.Label108,
            this.RetireDateText,
            this.AtacNameText,
            this.Label109,
            this.Label110,
            this.Adrs1Text,
            this.Adrs2Text,
            this.Label111,
            this.PhoneText,
            this.Label112,
            this.ChangeDateText,
            this.Label113,
            this.Label114,
            this.Label115,
            this.ShfTypeName1Text,
            this.ShfDate1,
            this.ShfDate2,
            this.ShfDate3,
            this.ShfDate4,
            this.ShfDate5,
            this.ShfDate6,
            this.ShfDate7,
            this.ShfDate8,
            this.ShfDate9,
            this.ShfDate10,
            this.ShfDate11,
            this.ShfDate12,
            this.ShfDate13,
            this.ShfDate14,
            this.ShfDate15,
            this.Label129,
            this.Label130,
            this.Label131,
            this.EntranceDate1Text,
            this.CompName1Text,
            this.Label132,
            this.Job1Text,
            this.CompName2Text,
            this.Job2Text,
            this.CompName3Text,
            this.Job3Text,
            this.CompName4Text,
            this.Job4Text,
            this.CompName5Text,
            this.Job5Text,
            this.Label133,
            this.Label134,
            this.Label135,
            this.Label137,
            this.SHF_DATE_18,
            this.SHF_DATE_19,
            this.SHF_DATE_20,
            this.ProjFromDateText1,
            this.ProjFromDateText2,
            this.ProjFromDateText3,
            this.ProjFromDateText4,
            this.ProjFromDateText5,
            this.Label141,
            this.Label142,
            this.Label143,
            this.Label144,
            this.WorkExpFromDate1Text,
            this.WorkExpName1Text,
            this.WorkExpTodate1Text,
            this.WordExpRemarks1Text,
            this.WorkExpFromDate2Text,
            this.WorkExpTodate2Text,
            this.WorkExpName2Text,
            this.WorkExpFromDate3Text,
            this.WorkExpTodate3Text,
            this.WorkExpName3Text,
            this.WorkExpTodate6Text,
            this.WorkExpName6Text,
            this.WorkExpName5Text,
            this.WorkExpName4Text,
            this.WorkExpFromDate4Text,
            this.WorkExpTodate4Text,
            this.WorkExpFromDate5Text,
            this.WorkExpTodate5Text,
            this.WorkExpFromDate6Text,
            this.WorkExpFromDate7Text,
            this.WorkExpTodate7Text,
            this.WorkExpName7Text,
            this.WorkExpFromDate8Text,
            this.WorkExpTodate8Text,
            this.WorkExpName8Text,
            this.WorkExpTodate9Text,
            this.WorkExpFromDate9Text,
            this.WorkExpName9Text,
            this.Label145,
            this.EntraYm1Text,
            this.SchoolName1Text,
            this.ClsName1Text,
            this.DayNightType1Text,
            this.Label147,
            this.Label149,
            this.Label150,
            this.ConcurDate2Text,
            this.ConcurDate3Text,
            this.ConcurDate4Text,
            this.ConcurTodate3Text,
            this.ConcurTodate4Text,
            this.ConcurName1Text,
            this.ConcurName2Text,
            this.ConcurName3Text,
            this.ConcurName4Text,
            this.Label151,
            this.TraniFrom1Text,
            this.TraniName1Text,
            this.TraniFrom2Text,
            this.TraniName2Text,
            this.TraniFrom3Text,
            this.TraniName3Text,
            this.TraniFrom4Text,
            this.TraniName4Text,
            this.Label152,
            this.Label153,
            this.TraniFrom5Text,
            this.TraniName5Text,
            this.TraniFrom6Text,
            this.TraniName6Text,
            this.Label154,
            this.Label155,
            this.QualfObtainDate1Text,
            this.QualfObtainDate2Text,
            this.QualfObtainDate3Text,
            this.QualfObtainDate4Text,
            this.QualfObtainDate5Text,
            this.Label157,
            this.Label158,
            this.Label159,
            this.RwdPntDate1Text,
            this.RwdPntName1Text,
            this.RwdPntDate2Text,
            this.RwdPntName2Text,
            this.RwdPntDate3Text,
            this.RwdPntName3Text,
            this.RwdPntDate4Text,
            this.RwdPntName4Text,
            this.Label160,
            this.Label161,
            this.Label162,
            this.Label163,
            this.LeaveFromdate1Text,
            this.LeaveTodate1Text,
            this.LeaveReason1Text,
            this.LeaveFromdate2Text,
            this.LeaveTodate2Text,
            this.LeaveFromdate3Text,
            this.LeaveTodate3Text,
            this.LeaveFromdate4Text,
            this.LeaveTodate4Text,
            this.WordExpRemarks2Text,
            this.WordExpRemarks3Text,
            this.WordExpRemarks4Text,
            this.WordExpRemarks5Text,
            this.WordExpRemarks6Text,
            this.WordExpRemarks7Text,
            this.WordExpRemarks8Text,
            this.WordExpRemarks9Text,
            this.LeaveReason2Text,
            this.LeaveReason3Text,
            this.LeaveReason4Text,
            this.EndType1Text,
            this.Label164,
            this.EndType2Text,
            this.EndType3Text,
            this.EndType4Text,
            this.EndType5Text,
            this.EndType6Text,
            this.Label165,
            this.QualfName1Text,
            this.ObtainType1Text,
            this.Label166,
            this.QualfName2Text,
            this.ObtainType2Text,
            this.QualfName3Text,
            this.ObtainType3Text,
            this.QualfName4Text,
            this.ObtainType4Text,
            this.GraduYm1Text,
            this.TextBox235,
            this.EntraYm3Text,
            this.AtacName1Text,
            this.ShfTypeName2Text,
            this.AtacName2Text,
            this.ShfTypeName3Text,
            this.AtacName3Text,
            this.ShfTypeName4Text,
            this.AtacName4Text,
            this.ShfTypeName5Text,
            this.AtacName5Text,
            this.ShfTypeName6Text,
            this.ShfTypeName7Text,
            this.ShfTypeName8Text,
            this.ShfTypeName9Text,
            this.ShfTypeName10Text,
            this.AtacName6Text,
            this.AtacName7Text,
            this.AtacName8Text,
            this.AtacName9Text,
            this.AtacName10Text,
            this.ShfTypeName11Text,
            this.ShfTypeName12Text,
            this.ShfTypeName13Text,
            this.ShfTypeName14Text,
            this.ShfTypeName15Text,
            this.AtacName11Text,
            this.AtacName12Text,
            this.AtacName13Text,
            this.AtacName14Text,
            this.AtacName15Text,
            this.AtacName18Text,
            this.AtacName19Text,
            this.AtacName20Text,
            this.ProjShortName1Text,
            this.ProjShortName2Text,
            this.ProjShortName3Text,
            this.ProjShortName4Text,
            this.ProjShortName5Text,
            this.SchoolName2Text,
            this.SchoolName3Text,
            this.GraduYm2Text,
            this.ClsName2Text,
            this.DayNightType2Text,
            this.GraduYm3Text,
            this.ClsName3Text,
            this.DayNightType3Text,
            this.ConcurTodate2Text,
            this.ConcurTodate1Text,
            this.QualfName5Text,
            this.ObtainType5Text,
            this.Line146,
            this.Line147,
            this.Line148,
            this.Line149,
            this.Line150,
            this.Line151,
            this.Line152,
            this.Line153,
            this.Line154,
            this.Line155,
            this.Line156,
            this.Line157,
            this.Line158,
            this.Line159,
            this.Line160,
            this.Line161,
            this.Line163,
            this.Line164,
            this.Line165,
            this.Line166,
            this.Line167,
            this.Line168,
            this.Line169,
            this.Line170,
            this.Line171,
            this.Line172,
            this.Line173,
            this.Line174,
            this.Line175,
            this.Line176,
            this.Line182,
            this.Line183,
            this.Line184,
            this.Line185,
            this.Line186,
            this.Line187,
            this.Line188,
            this.Line189,
            this.Line190,
            this.Line191,
            this.Line192,
            this.Line193,
            this.Line194,
            this.Line196,
            this.Line197,
            this.Line198,
            this.Line199,
            this.Line200,
            this.Line201,
            this.Line202,
            this.Line204,
            this.Line205,
            this.Line206,
            this.Line207,
            this.Line208,
            this.Line209,
            this.Line210,
            this.Line211,
            this.Line212,
            this.Line213,
            this.Line214,
            this.Line215,
            this.Line216,
            this.Line217,
            this.Line218,
            this.Line219,
            this.Line220,
            this.Line221,
            this.Line222,
            this.Line223,
            this.Line224,
            this.Line229,
            this.Line230,
            this.Line231,
            this.Line232,
            this.LengthServMmText,
            this.WordExpPeriodMonth1Text,
            this.WordExpPeriodYear1Text,
            this.WordExpPeriodYear2Text,
            this.WordExpPeriodMonth2Text,
            this.WordExpPeriodYear3Text,
            this.WordExpPeriodMonth3Text,
            this.WordExpPeriodYear4Text,
            this.WordExpPeriodMonth4Text,
            this.WordExpPeriodYear5Text,
            this.WordExpPeriodMonth5Text,
            this.WordExpPeriodYear6Text,
            this.WordExpPeriodMonth6Text,
            this.WordExpPeriodYear7Text,
            this.WordExpPeriodMonth7Text,
            this.WordExpPeriodYear8Text,
            this.WordExpPeriodMonth8Text,
            this.WordExpPeriodYear9Text,
            this.WordExpPeriodMonth9Text,
            this.RetirementDate1Text,
            this.EntranceDate2Text,
            this.RetirementDate2Text,
            this.EntranceDate3Text,
            this.RetirementDate3Text,
            this.EntranceDate4Text,
            this.RetirementDate4Text,
            this.EntranceDate5Text,
            this.RetirementDate5Text,
            this.Line234,
            this.Line235,
            this.Line145,
            this.Line236,
            this.Line237,
            this.Label175,
            this.Label176,
            this.ConcurAtacName1Text,
            this.ConcurAtacName2Text,
            this.ConcurAtacName3Text,
            this.ConcurAtacName4Text,
            this.Line179,
            this.Line180,
            this.Line181,
            this.Line177,
            this.BirthYmdJPText,
            this.InDateJPText,
            this.InDate2JPText,
            this.Line238,
            this.Line239,
            this.Line240,
            this.Line241,
            this.Line242,
            this.Line243,
            this.Line244,
            this.Line245,
            this.Line246,
            this.SHF_DATE_16,
            this.SHF_DATE_17,
            this.ShfTypeName16Text,
            this.Line178,
            this.Line162,
            this.Line247,
            this.Line233});
			this.Detail.Height = 9.84375F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// Label180
			// 
			this.Label180.Height = 0.1888333F;
			this.Label180.HyperLink = null;
			this.Label180.Left = 1.1875F;
			this.Label180.Name = "Label180";
			this.Label180.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label180.Text = "プロジェクト内容";
			this.Label180.Top = 5.374917F;
			this.Label180.Width = 2.235917F;
			// 
			// Label179
			// 
			this.Label179.Height = 0.1888333F;
			this.Label179.HyperLink = null;
			this.Label179.Left = 0.6255F;
			this.Label179.Name = "Label179";
			this.Label179.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label179.Text = "終了日";
			this.Label179.Top = 5.377917F;
			this.Label179.Width = 0.5734166F;
			// 
			// Label178
			// 
			this.Label178.Height = 0.1888333F;
			this.Label178.HyperLink = null;
			this.Label178.Left = 0.06299999F;
			this.Label178.Name = "Label178";
			this.Label178.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label178.Text = "開始日";
			this.Label178.Top = 5.377917F;
			this.Label178.Width = 0.5734166F;
			// 
			// Label177
			// 
			this.Label177.Height = 0.1784167F;
			this.Label177.HyperLink = null;
			this.Label177.Left = 0.063F;
			this.Label177.Name = "Label177";
			this.Label177.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label177.Text = "【プロジェクト履歴情報】";
			this.Label177.Top = 5.209915F;
			this.Label177.Width = 3.360417F;
			// 
			// ProjToDateText5
			// 
			this.ProjToDateText5.CanGrow = false;
			this.ProjToDateText5.DataField = "PROJ_TO_DATE_5";
			this.ProjToDateText5.Height = 0.168F;
			this.ProjToDateText5.Left = 0.626F;
			this.ProjToDateText5.Name = "ProjToDateText5";
			this.ProjToDateText5.OutputFormat = "yyyy/MM/dd";
			this.ProjToDateText5.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjToDateText5.Text = "ZZZ6/Z6/Z6";
			this.ProjToDateText5.Top = 6.216F;
			this.ProjToDateText5.Width = 0.563F;
			// 
			// ProjToDateText4
			// 
			this.ProjToDateText4.CanGrow = false;
			this.ProjToDateText4.DataField = "PROJ_TO_DATE_4";
			this.ProjToDateText4.Height = 0.168F;
			this.ProjToDateText4.Left = 0.626F;
			this.ProjToDateText4.Name = "ProjToDateText4";
			this.ProjToDateText4.OutputFormat = "yyyy/MM/dd";
			this.ProjToDateText4.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjToDateText4.Text = "ZZZ6/Z6/Z6";
			this.ProjToDateText4.Top = 6.048F;
			this.ProjToDateText4.Width = 0.563F;
			// 
			// ProjToDateText3
			// 
			this.ProjToDateText3.CanGrow = false;
			this.ProjToDateText3.DataField = "PROJ_TO_DATE_3";
			this.ProjToDateText3.Height = 0.168F;
			this.ProjToDateText3.Left = 0.626F;
			this.ProjToDateText3.Name = "ProjToDateText3";
			this.ProjToDateText3.OutputFormat = "yyyy/MM/dd";
			this.ProjToDateText3.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjToDateText3.Text = "ZZZ6/Z6/Z6";
			this.ProjToDateText3.Top = 5.88F;
			this.ProjToDateText3.Width = 0.563F;
			// 
			// ProjToDateText2
			// 
			this.ProjToDateText2.CanGrow = false;
			this.ProjToDateText2.DataField = "PROJ_TO_DATE_2";
			this.ProjToDateText2.Height = 0.168F;
			this.ProjToDateText2.Left = 0.626F;
			this.ProjToDateText2.Name = "ProjToDateText2";
			this.ProjToDateText2.OutputFormat = "yyyy/MM/dd";
			this.ProjToDateText2.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjToDateText2.Text = "ZZZ6/Z6/Z6";
			this.ProjToDateText2.Top = 5.712F;
			this.ProjToDateText2.Width = 0.563F;
			// 
			// ProjToDateText1
			// 
			this.ProjToDateText1.CanGrow = false;
			this.ProjToDateText1.DataField = "PROJ_TO_DATE_1";
			this.ProjToDateText1.Height = 0.168F;
			this.ProjToDateText1.Left = 0.626F;
			this.ProjToDateText1.Name = "ProjToDateText1";
			this.ProjToDateText1.OutputFormat = "yyyy/MM/dd";
			this.ProjToDateText1.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjToDateText1.Text = "ZZZ6/Z6/Z6";
			this.ProjToDateText1.Top = 5.543999F;
			this.ProjToDateText1.Width = 0.563F;
			// 
			// AtacName17Text
			// 
			this.AtacName17Text.CanGrow = false;
			this.AtacName17Text.DataField = "ATAC_NAME_17";
			this.AtacName17Text.Height = 0.168F;
			this.AtacName17Text.Left = 1.563F;
			this.AtacName17Text.Name = "AtacName17Text";
			this.AtacName17Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName17Text.Text = "あああああああああああああああ";
			this.AtacName17Text.Top = 4.538F;
			this.AtacName17Text.Width = 1.851F;
			// 
			// AtacName16Text
			// 
			this.AtacName16Text.CanGrow = false;
			this.AtacName16Text.DataField = "ATAC_NAME_16";
			this.AtacName16Text.Height = 0.168F;
			this.AtacName16Text.Left = 1.563F;
			this.AtacName16Text.Name = "AtacName16Text";
			this.AtacName16Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName16Text.Text = "あああああああああああああああ";
			this.AtacName16Text.Top = 4.375F;
			this.AtacName16Text.Width = 1.851F;
			// 
			// ConcurDate1Text
			// 
			this.ConcurDate1Text.CanGrow = false;
			this.ConcurDate1Text.DataField = "CONCUR_DATE_1";
			this.ConcurDate1Text.Height = 0.168F;
			this.ConcurDate1Text.Left = 3.438F;
			this.ConcurDate1Text.Name = "ConcurDate1Text";
			this.ConcurDate1Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurDate1Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurDate1Text.Top = 4.536F;
			this.ConcurDate1Text.Width = 0.625F;
			// 
			// Label148
			// 
			this.Label148.Height = 0.168F;
			this.Label148.HyperLink = null;
			this.Label148.Left = 3.413F;
			this.Label148.Name = "Label148";
			this.Label148.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label148.Text = "兼務日";
			this.Label148.Top = 4.368F;
			this.Label148.Width = 0.625F;
			// 
			// ShfTypeName20Text
			// 
			this.ShfTypeName20Text.CanGrow = false;
			this.ShfTypeName20Text.DataField = "SHF_TYPE_NAME_20";
			this.ShfTypeName20Text.Height = 0.168F;
			this.ShfTypeName20Text.Left = 0.625F;
			this.ShfTypeName20Text.Name = "ShfTypeName20Text";
			this.ShfTypeName20Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName20Text.Text = "ああああああ";
			this.ShfTypeName20Text.Top = 5.04F;
			this.ShfTypeName20Text.Width = 0.875F;
			// 
			// ShfTypeName19Text
			// 
			this.ShfTypeName19Text.CanGrow = false;
			this.ShfTypeName19Text.DataField = "SHF_TYPE_NAME_19";
			this.ShfTypeName19Text.Height = 0.168F;
			this.ShfTypeName19Text.Left = 0.625F;
			this.ShfTypeName19Text.Name = "ShfTypeName19Text";
			this.ShfTypeName19Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName19Text.Text = "ああああああ";
			this.ShfTypeName19Text.Top = 4.8722F;
			this.ShfTypeName19Text.Width = 0.875F;
			// 
			// ShfTypeName17Text
			// 
			this.ShfTypeName17Text.CanGrow = false;
			this.ShfTypeName17Text.DataField = "SHF_TYPE_NAME_17";
			this.ShfTypeName17Text.Height = 0.168F;
			this.ShfTypeName17Text.Left = 0.625F;
			this.ShfTypeName17Text.Name = "ShfTypeName17Text";
			this.ShfTypeName17Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName17Text.Text = "ああああああああ";
			this.ShfTypeName17Text.Top = 4.538F;
			this.ShfTypeName17Text.Width = 0.875F;
			// 
			// ShfTypeName18Text
			// 
			this.ShfTypeName18Text.CanGrow = false;
			this.ShfTypeName18Text.DataField = "SHF_TYPE_NAME_18";
			this.ShfTypeName18Text.Height = 0.168F;
			this.ShfTypeName18Text.Left = 0.625F;
			this.ShfTypeName18Text.Name = "ShfTypeName18Text";
			this.ShfTypeName18Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName18Text.Text = "ああああああ";
			this.ShfTypeName18Text.Top = 4.704F;
			this.ShfTypeName18Text.Width = 0.875F;
			// 
			// Line118
			// 
			this.Line118.Height = 0.672F;
			this.Line118.Left = 0.375F;
			this.Line118.LineWeight = 1F;
			this.Line118.Name = "Line118";
			this.Line118.Top = 0F;
			this.Line118.Width = 0F;
			this.Line118.X1 = 0.375F;
			this.Line118.X2 = 0.375F;
			this.Line118.Y1 = 0F;
			this.Line118.Y2 = 0.672F;
			// 
			// Line121
			// 
			this.Line121.Height = 0.672F;
			this.Line121.Left = 2.125F;
			this.Line121.LineWeight = 1F;
			this.Line121.Name = "Line121";
			this.Line121.Top = 0F;
			this.Line121.Width = 0F;
			this.Line121.X1 = 2.125F;
			this.Line121.X2 = 2.125F;
			this.Line121.Y1 = 0F;
			this.Line121.Y2 = 0.672F;
			// 
			// Line122
			// 
			this.Line122.Height = 1.512F;
			this.Line122.Left = 4.312F;
			this.Line122.LineWeight = 1F;
			this.Line122.Name = "Line122";
			this.Line122.Top = 0F;
			this.Line122.Width = 0F;
			this.Line122.X1 = 4.312F;
			this.Line122.X2 = 4.312F;
			this.Line122.Y1 = 0F;
			this.Line122.Y2 = 1.512F;
			// 
			// Line125
			// 
			this.Line125.Height = 0.5039999F;
			this.Line125.Left = 6.188001F;
			this.Line125.LineWeight = 1F;
			this.Line125.Name = "Line125";
			this.Line125.Top = 1.008F;
			this.Line125.Width = 0F;
			this.Line125.X1 = 6.188001F;
			this.Line125.X2 = 6.188001F;
			this.Line125.Y1 = 1.008F;
			this.Line125.Y2 = 1.512F;
			// 
			// EmpCodeText
			// 
			this.EmpCodeText.CanGrow = false;
			this.EmpCodeText.DataField = "EMP_CODE";
			this.EmpCodeText.Height = 0.155F;
			this.EmpCodeText.Left = 0.375F;
			this.EmpCodeText.Name = "EmpCodeText";
			this.EmpCodeText.Style = "font-size: 7pt; text-align: left; vertical-align: bottom; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmpCodeText.Text = "0000000000";
			this.EmpCodeText.Top = 0.0625F;
			this.EmpCodeText.Width = 1.5F;
			// 
			// ZipText
			// 
			this.ZipText.CanGrow = false;
			this.ZipText.DataField = "ZIP";
			this.ZipText.Height = 0.336F;
			this.ZipText.Left = 0.063F;
			this.ZipText.Name = "ZipText";
			this.ZipText.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: nowrap; ddo-c" +
    "har-set: 1";
			this.ZipText.Text = "0000000";
			this.ZipText.Top = 1.176F;
			this.ZipText.Width = 0.563F;
			// 
			// AgeText
			// 
			this.AgeText.CanGrow = false;
			this.AgeText.DataField = "AGE";
			this.AgeText.Height = 0.155F;
			this.AgeText.Left = 2.375F;
			this.AgeText.Name = "AgeText";
			this.AgeText.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.AgeText.Text = "Ｚ６歳";
			this.AgeText.Top = 0.0625F;
			this.AgeText.Width = 0.563F;
			// 
			// ConcurNameText
			// 
			this.ConcurNameText.CanGrow = false;
			this.ConcurNameText.DataField = "CONCUR_TYPE";
			this.ConcurNameText.Height = 0.168F;
			this.ConcurNameText.Left = 3.938F;
			this.ConcurNameText.Name = "ConcurNameText";
			this.ConcurNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurNameText.Text = "あ";
			this.ConcurNameText.Top = 0.84F;
			this.ConcurNameText.Width = 0.399F;
			// 
			// Label5
			// 
			this.Label5.Height = 0.2952756F;
			this.Label5.HyperLink = null;
			this.Label5.Left = 0.06299213F;
			this.Label5.Name = "Label5";
			this.Label5.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label5.Text = "社員番号";
			this.Label5.Top = 0.03149606F;
			this.Label5.Width = 0.2519685F;
			// 
			// Line136
			// 
			this.Line136.Height = 9.744F;
			this.Line136.Left = 0.063F;
			this.Line136.LineWeight = 1F;
			this.Line136.Name = "Line136";
			this.Line136.Top = 0F;
			this.Line136.Width = 0F;
			this.Line136.X1 = 0.063F;
			this.Line136.X2 = 0.063F;
			this.Line136.Y1 = 0F;
			this.Line136.Y2 = 9.744F;
			// 
			// Label93
			// 
			this.Label93.Height = 0.2952756F;
			this.Label93.HyperLink = null;
			this.Label93.Left = 1.874016F;
			this.Label93.Name = "Label93";
			this.Label93.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label93.Text = "性別";
			this.Label93.Top = 0.03149606F;
			this.Label93.Width = 0.1889764F;
			// 
			// Line137
			// 
			this.Line137.Height = 1.008F;
			this.Line137.Left = 1.875F;
			this.Line137.LineWeight = 1F;
			this.Line137.Name = "Line137";
			this.Line137.Top = 0F;
			this.Line137.Width = 0F;
			this.Line137.X1 = 1.875F;
			this.Line137.X2 = 1.875F;
			this.Line137.Y1 = 0F;
			this.Line137.Y2 = 1.008F;
			// 
			// Label94
			// 
			this.Label94.Height = 0.2952756F;
			this.Label94.HyperLink = null;
			this.Label94.Left = 2.125984F;
			this.Label94.Name = "Label94";
			this.Label94.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label94.Text = "年齢";
			this.Label94.Top = 0.03149606F;
			this.Label94.Width = 0.1850394F;
			// 
			// Line139
			// 
			this.Line139.Height = 1.008F;
			this.Line139.Left = 2.938F;
			this.Line139.LineWeight = 1F;
			this.Line139.Name = "Line139";
			this.Line139.Top = 0F;
			this.Line139.Width = 0F;
			this.Line139.X1 = 2.938F;
			this.Line139.X2 = 2.938F;
			this.Line139.Y1 = 0F;
			this.Line139.Y2 = 1.008F;
			// 
			// Label95
			// 
			this.Label95.Height = 0.2952756F;
			this.Label95.HyperLink = null;
			this.Label95.Left = 2.937008F;
			this.Label95.Name = "Label95";
			this.Label95.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label95.Text = "身分";
			this.Label95.Top = 0.03149606F;
			this.Label95.Width = 0.1850394F;
			// 
			// RankNameText
			// 
			this.RankNameText.CanGrow = false;
			this.RankNameText.DataField = "RANK_NAME";
			this.RankNameText.Height = 0.155F;
			this.RankNameText.Left = 3.188F;
			this.RankNameText.Name = "RankNameText";
			this.RankNameText.Style = "font-size: 7pt; text-align: left; vertical-align: bottom; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RankNameText.Text = "ああああああああああ";
			this.RankNameText.Top = 0.0625F;
			this.RankNameText.Width = 1.124F;
			// 
			// Label96
			// 
			this.Label96.Height = 0.2952756F;
			this.Label96.HyperLink = null;
			this.Label96.Left = 4.311024F;
			this.Label96.Name = "Label96";
			this.Label96.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label96.Text = "役職";
			this.Label96.Top = 0.03149606F;
			this.Label96.Width = 0.1732283F;
			// 
			// PostNameText
			// 
			this.PostNameText.CanGrow = false;
			this.PostNameText.DataField = "POST_NAME";
			this.PostNameText.Height = 0.155F;
			this.PostNameText.Left = 4.562F;
			this.PostNameText.Name = "PostNameText";
			this.PostNameText.Style = "font-size: 7pt; text-align: left; vertical-align: bottom; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PostNameText.Text = "あああああああああああああああ";
			this.PostNameText.Top = 0.0625F;
			this.PostNameText.Width = 1.441937F;
			// 
			// Label97
			// 
			this.Label97.Height = 0.2952756F;
			this.Label97.HyperLink = null;
			this.Label97.Left = 6.023622F;
			this.Label97.Name = "Label97";
			this.Label97.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label97.Text = "学歴";
			this.Label97.Top = 0.03149606F;
			this.Label97.Width = 0.1732283F;
			// 
			// LastEduNameText
			// 
			this.LastEduNameText.CanGrow = false;
			this.LastEduNameText.DataField = "LAST_EDU_NAME";
			this.LastEduNameText.Height = 0.155F;
			this.LastEduNameText.Left = 6.271654F;
			this.LastEduNameText.Name = "LastEduNameText";
			this.LastEduNameText.Style = "font-size: 7pt; text-align: left; vertical-align: bottom; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastEduNameText.Text = "ああああああああ";
			this.LastEduNameText.Top = 0.06299213F;
			this.LastEduNameText.Width = 0.7922208F;
			// 
			// Line140
			// 
			this.Line140.Height = 0F;
			this.Line140.Left = 0.063F;
			this.Line140.LineWeight = 1F;
			this.Line140.Name = "Line140";
			this.Line140.Top = 0.84F;
			this.Line140.Width = 7.037F;
			this.Line140.X1 = 0.063F;
			this.Line140.X2 = 7.1F;
			this.Line140.Y1 = 0.84F;
			this.Line140.Y2 = 0.84F;
			// 
			// Label98
			// 
			this.Label98.Height = 0.35F;
			this.Label98.HyperLink = null;
			this.Label98.Left = 0.063F;
			this.Label98.Name = "Label98";
			this.Label98.Style = "font-size: 7pt; font-weight: normal; text-align: center; ddo-char-set: 1";
			this.Label98.Text = "氏名";
			this.Label98.Top = 0.31F;
			this.Label98.Width = 0.25F;
			// 
			// EmpNameKanaText
			// 
			this.EmpNameKanaText.CanGrow = false;
			this.EmpNameKanaText.DataField = "EMP_NAME_KANA";
			this.EmpNameKanaText.Height = 0.168F;
			this.EmpNameKanaText.Left = 0.375F;
			this.EmpNameKanaText.Name = "EmpNameKanaText";
			this.EmpNameKanaText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmpNameKanaText.Text = "000000000000000000000000000000";
			this.EmpNameKanaText.Top = 0.31F;
			this.EmpNameKanaText.Width = 1.5F;
			// 
			// EmpNameText
			// 
			this.EmpNameText.CanGrow = false;
			this.EmpNameText.DataField = "EMP_NAME";
			this.EmpNameText.Height = 0.168F;
			this.EmpNameText.Left = 0.375F;
			this.EmpNameText.Name = "EmpNameText";
			this.EmpNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmpNameText.Text = "あああああああああああああああ";
			this.EmpNameText.Top = 0.504F;
			this.EmpNameText.Width = 1.5F;
			// 
			// Line141
			// 
			this.Line141.Height = 0F;
			this.Line141.Left = 0.375F;
			this.Line141.LineWeight = 1F;
			this.Line141.Name = "Line141";
			this.Line141.Top = 0.479F;
			this.Line141.Width = 1.5F;
			this.Line141.X1 = 0.375F;
			this.Line141.X2 = 1.875F;
			this.Line141.Y1 = 0.479F;
			this.Line141.Y2 = 0.479F;
			// 
			// SexTypeNameText
			// 
			this.SexTypeNameText.CanGrow = false;
			this.SexTypeNameText.DataField = "SEX";
			this.SexTypeNameText.Height = 0.336F;
			this.SexTypeNameText.Left = 1.875F;
			this.SexTypeNameText.Name = "SexTypeNameText";
			this.SexTypeNameText.OutputFormat = "#,##0";
			this.SexTypeNameText.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexTypeNameText.Text = "あ";
			this.SexTypeNameText.Top = 0.31F;
			this.SexTypeNameText.Width = 0.25F;
			// 
			// Label99
			// 
			this.Label99.Height = 0.168F;
			this.Label99.HyperLink = null;
			this.Label99.Left = 2.125F;
			this.Label99.Name = "Label99";
			this.Label99.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label99.Text = "生年月日";
			this.Label99.Top = 0.31F;
			this.Label99.Width = 0.813F;
			// 
			// Label100
			// 
			this.Label100.Height = 0.168F;
			this.Label100.HyperLink = null;
			this.Label100.Left = 2.125F;
			this.Label100.Name = "Label100";
			this.Label100.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label100.Text = "入社日";
			this.Label100.Top = 0.504F;
			this.Label100.Width = 0.813F;
			// 
			// LengthServYyText
			// 
			this.LengthServYyText.CanGrow = false;
			this.LengthServYyText.DataField = "LENGTH_SERV_YY";
			this.LengthServYyText.Height = 0.168F;
			this.LengthServYyText.Left = 5.5F;
			this.LengthServYyText.Name = "LengthServYyText";
			this.LengthServYyText.OutputFormat = "yy年";
			this.LengthServYyText.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.LengthServYyText.Text = "Z6年";
			this.LengthServYyText.Top = 0.31F;
			this.LengthServYyText.Width = 0.25F;
			// 
			// InDate2Text
			// 
			this.InDate2Text.CanGrow = false;
			this.InDate2Text.DataField = "IN_DATE2";
			this.InDate2Text.Height = 0.168F;
			this.InDate2Text.Left = 5.5F;
			this.InDate2Text.Name = "InDate2Text";
			this.InDate2Text.OutputFormat = "yyyy年MM月dd日";
			this.InDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDate2Text.Text = "ZZZ6年Z6月Z6日";
			this.InDate2Text.Top = 0.504F;
			this.InDate2Text.Width = 0.7F;
			// 
			// Label101
			// 
			this.Label101.Height = 0.168F;
			this.Label101.HyperLink = null;
			this.Label101.Left = 4.312F;
			this.Label101.Name = "Label101";
			this.Label101.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label101.Text = "勤続";
			this.Label101.Top = 0.31F;
			this.Label101.Width = 1.188F;
			// 
			// Label102
			// 
			this.Label102.Height = 0.168F;
			this.Label102.HyperLink = null;
			this.Label102.Left = 4.312F;
			this.Label102.Name = "Label102";
			this.Label102.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label102.Text = "入社日２";
			this.Label102.Top = 0.5F;
			this.Label102.Width = 1.188F;
			// 
			// BirthYmdText
			// 
			this.BirthYmdText.CanGrow = false;
			this.BirthYmdText.DataField = "BIRTH_YMD";
			this.BirthYmdText.Height = 0.168F;
			this.BirthYmdText.Left = 2.938F;
			this.BirthYmdText.Name = "BirthYmdText";
			this.BirthYmdText.OutputFormat = "yyyy年MM月dd日";
			this.BirthYmdText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthYmdText.Text = "ZZZ6年Z6月Z6日";
			this.BirthYmdText.Top = 0.31F;
			this.BirthYmdText.Width = 0.7F;
			// 
			// InDateText
			// 
			this.InDateText.CanGrow = false;
			this.InDateText.DataField = "IN_DATE";
			this.InDateText.Height = 0.168F;
			this.InDateText.Left = 2.938F;
			this.InDateText.Name = "InDateText";
			this.InDateText.OutputFormat = "yyyy年MM月dd日";
			this.InDateText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDateText.Text = "ZZZ6年Z6月Z6日";
			this.InDateText.Top = 0.504F;
			this.InDateText.Width = 0.7F;
			// 
			// Label103
			// 
			this.Label103.Height = 0.168F;
			this.Label103.HyperLink = null;
			this.Label103.Left = 0.063F;
			this.Label103.Name = "Label103";
			this.Label103.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label103.Text = "所属";
			this.Label103.Top = 0.672F;
			this.Label103.Width = 1.812F;
			// 
			// ServPlNameText
			// 
			this.ServPlNameText.CanGrow = false;
			this.ServPlNameText.DataField = "SERV_PL_NAME";
			this.ServPlNameText.Height = 0.168F;
			this.ServPlNameText.Left = 1.875F;
			this.ServPlNameText.Name = "ServPlNameText";
			this.ServPlNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ServPlNameText.Text = "ああああああああああ";
			this.ServPlNameText.Top = 0.84F;
			this.ServPlNameText.Width = 1.063F;
			// 
			// Label104
			// 
			this.Label104.Height = 0.168F;
			this.Label104.HyperLink = null;
			this.Label104.Left = 1.875F;
			this.Label104.Name = "Label104";
			this.Label104.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label104.Text = "勤務地";
			this.Label104.Top = 0.672F;
			this.Label104.Width = 1.063F;
			// 
			// Label105
			// 
			this.Label105.Height = 0.168F;
			this.Label105.HyperLink = null;
			this.Label105.Left = 2.938F;
			this.Label105.Name = "Label105";
			this.Label105.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label105.Text = "職掌";
			this.Label105.Top = 0.672F;
			this.Label105.Width = 1F;
			// 
			// DutyNameText
			// 
			this.DutyNameText.CanGrow = false;
			this.DutyNameText.DataField = "DUTY_NAME";
			this.DutyNameText.Height = 0.168F;
			this.DutyNameText.Left = 2.938F;
			this.DutyNameText.Name = "DutyNameText";
			this.DutyNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DutyNameText.Text = "ああああああああああ";
			this.DutyNameText.Top = 0.84F;
			this.DutyNameText.Width = 1F;
			// 
			// Label106
			// 
			this.Label106.Height = 0.168F;
			this.Label106.HyperLink = null;
			this.Label106.Left = 3.938F;
			this.Label106.Name = "Label106";
			this.Label106.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label106.Text = "兼務";
			this.Label106.Top = 0.672F;
			this.Label106.Width = 0.399F;
			// 
			// Label107
			// 
			this.Label107.Height = 0.168F;
			this.Label107.HyperLink = null;
			this.Label107.Left = 4.312F;
			this.Label107.Name = "Label107";
			this.Label107.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label107.Text = "氏名変更日";
			this.Label107.Top = 0.672F;
			this.Label107.Width = 1.188F;
			// 
			// MarriYmdText
			// 
			this.MarriYmdText.CanGrow = false;
			this.MarriYmdText.DataField = "MARRI_YMD";
			this.MarriYmdText.Height = 0.168F;
			this.MarriYmdText.Left = 5.5F;
			this.MarriYmdText.Name = "MarriYmdText";
			this.MarriYmdText.OutputFormat = "yyyy年MM月dd日";
			this.MarriYmdText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.MarriYmdText.Text = "ZZZ6年Z6月Z6日";
			this.MarriYmdText.Top = 0.672F;
			this.MarriYmdText.Width = 1.6F;
			// 
			// Label108
			// 
			this.Label108.Height = 0.168F;
			this.Label108.HyperLink = null;
			this.Label108.Left = 4.312F;
			this.Label108.Name = "Label108";
			this.Label108.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label108.Text = "退職日";
			this.Label108.Top = 0.84F;
			this.Label108.Width = 1.188F;
			// 
			// RetireDateText
			// 
			this.RetireDateText.CanGrow = false;
			this.RetireDateText.DataField = "RETIRE_DATE";
			this.RetireDateText.Height = 0.168F;
			this.RetireDateText.Left = 5.5F;
			this.RetireDateText.Name = "RetireDateText";
			this.RetireDateText.OutputFormat = "yyyy年MM月dd日";
			this.RetireDateText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireDateText.Text = "ZZZ6年Z6月Z6日";
			this.RetireDateText.Top = 0.84F;
			this.RetireDateText.Width = 1.6F;
			// 
			// AtacNameText
			// 
			this.AtacNameText.CanGrow = false;
			this.AtacNameText.DataField = "ATAC_NAME";
			this.AtacNameText.Height = 0.168F;
			this.AtacNameText.Left = 0.063F;
			this.AtacNameText.Name = "AtacNameText";
			this.AtacNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacNameText.Text = "ああああああああああ";
			this.AtacNameText.Top = 0.84F;
			this.AtacNameText.Width = 1.812F;
			// 
			// Label109
			// 
			this.Label109.Height = 0.168F;
			this.Label109.HyperLink = null;
			this.Label109.Left = 0.063F;
			this.Label109.Name = "Label109";
			this.Label109.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label109.Text = "郵便番号";
			this.Label109.Top = 1.008F;
			this.Label109.Width = 0.563F;
			// 
			// Label110
			// 
			this.Label110.Height = 0.168F;
			this.Label110.HyperLink = null;
			this.Label110.Left = 0.625F;
			this.Label110.Name = "Label110";
			this.Label110.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label110.Text = "住　所";
			this.Label110.Top = 1.008F;
			this.Label110.Width = 3.5F;
			// 
			// Adrs1Text
			// 
			this.Adrs1Text.CanGrow = false;
			this.Adrs1Text.DataField = "ADRS_1";
			this.Adrs1Text.Height = 0.168F;
			this.Adrs1Text.Left = 0.625F;
			this.Adrs1Text.Name = "Adrs1Text";
			this.Adrs1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Adrs1Text.Text = "ああああああああああああああああああああああああああああああ";
			this.Adrs1Text.Top = 1.176F;
			this.Adrs1Text.Width = 3.686024F;
			// 
			// Adrs2Text
			// 
			this.Adrs2Text.CanGrow = false;
			this.Adrs2Text.DataField = "ADRS_2";
			this.Adrs2Text.Height = 0.168F;
			this.Adrs2Text.Left = 0.625F;
			this.Adrs2Text.Name = "Adrs2Text";
			this.Adrs2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Adrs2Text.Text = "ああああああああああああああああああああああああああああああ";
			this.Adrs2Text.Top = 1.344F;
			this.Adrs2Text.Width = 3.5F;
			// 
			// Label111
			// 
			this.Label111.Height = 0.168F;
			this.Label111.HyperLink = null;
			this.Label111.Left = 4.312F;
			this.Label111.Name = "Label111";
			this.Label111.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label111.Text = "電話番号";
			this.Label111.Top = 1.008F;
			this.Label111.Width = 1.8755F;
			// 
			// PhoneText
			// 
			this.PhoneText.CanGrow = false;
			this.PhoneText.DataField = "PHONE";
			this.PhoneText.Height = 0.336F;
			this.PhoneText.Left = 4.312F;
			this.PhoneText.Name = "PhoneText";
			this.PhoneText.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: nowrap; ddo-c" +
    "har-set: 1";
			this.PhoneText.Text = "000000000000000";
			this.PhoneText.Top = 1.176F;
			this.PhoneText.Width = 1.8755F;
			// 
			// Label112
			// 
			this.Label112.Height = 0.168F;
			this.Label112.HyperLink = null;
			this.Label112.Left = 6.1875F;
			this.Label112.Name = "Label112";
			this.Label112.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label112.Text = "変更日";
			this.Label112.Top = 1.008F;
			this.Label112.Width = 0.9125F;
			// 
			// ChangeDateText
			// 
			this.ChangeDateText.CanGrow = false;
			this.ChangeDateText.DataField = "CHANGE_DATE";
			this.ChangeDateText.Height = 0.336F;
			this.ChangeDateText.Left = 6.1875F;
			this.ChangeDateText.Name = "ChangeDateText";
			this.ChangeDateText.OutputFormat = "yyyy年MM月dd日";
			this.ChangeDateText.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: nowrap; ddo-c" +
    "har-set: 1";
			this.ChangeDateText.Text = "ZZZ6年Z6月Z6日";
			this.ChangeDateText.Top = 1.176F;
			this.ChangeDateText.Width = 0.9125F;
			// 
			// Label113
			// 
			this.Label113.Height = 0.168F;
			this.Label113.HyperLink = null;
			this.Label113.Left = 0.063F;
			this.Label113.Name = "Label113";
			this.Label113.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label113.Text = "【異動情報】";
			this.Label113.Top = 1.512F;
			this.Label113.Width = 3.35F;
			// 
			// Label114
			// 
			this.Label114.Height = 0.168F;
			this.Label114.HyperLink = null;
			this.Label114.Left = 0.063F;
			this.Label114.Name = "Label114";
			this.Label114.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label114.Text = "異動年月日";
			this.Label114.Top = 1.68F;
			this.Label114.Width = 0.563F;
			// 
			// Label115
			// 
			this.Label115.Height = 0.168F;
			this.Label115.HyperLink = null;
			this.Label115.Left = 0.625F;
			this.Label115.Name = "Label115";
			this.Label115.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label115.Text = "異動内容";
			this.Label115.Top = 1.68F;
			this.Label115.Width = 2.788F;
			// 
			// ShfTypeName1Text
			// 
			this.ShfTypeName1Text.CanGrow = false;
			this.ShfTypeName1Text.DataField = "SHF_TYPE_NAME_1";
			this.ShfTypeName1Text.Height = 0.168F;
			this.ShfTypeName1Text.Left = 0.625F;
			this.ShfTypeName1Text.Name = "ShfTypeName1Text";
			this.ShfTypeName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName1Text.Text = "ああああああああ";
			this.ShfTypeName1Text.Top = 1.848F;
			this.ShfTypeName1Text.Width = 0.875F;
			// 
			// ShfDate1
			// 
			this.ShfDate1.CanGrow = false;
			this.ShfDate1.DataField = "SHF_DATE_1";
			this.ShfDate1.Height = 0.168F;
			this.ShfDate1.Left = 0.063F;
			this.ShfDate1.Name = "ShfDate1";
			this.ShfDate1.OutputFormat = "yyyy/MM/dd";
			this.ShfDate1.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate1.Text = "ZZZ6/Z6/Z6";
			this.ShfDate1.Top = 1.848F;
			this.ShfDate1.Width = 0.563F;
			// 
			// ShfDate2
			// 
			this.ShfDate2.CanGrow = false;
			this.ShfDate2.DataField = "SHF_DATE_2";
			this.ShfDate2.Height = 0.168F;
			this.ShfDate2.Left = 0.063F;
			this.ShfDate2.Name = "ShfDate2";
			this.ShfDate2.OutputFormat = "yyyy/MM/dd";
			this.ShfDate2.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate2.Text = "ZZZ6/Z6/Z6";
			this.ShfDate2.Top = 2.016F;
			this.ShfDate2.Width = 0.563F;
			// 
			// ShfDate3
			// 
			this.ShfDate3.CanGrow = false;
			this.ShfDate3.DataField = "SHF_DATE_3";
			this.ShfDate3.Height = 0.168F;
			this.ShfDate3.Left = 0.063F;
			this.ShfDate3.Name = "ShfDate3";
			this.ShfDate3.OutputFormat = "yyyy/MM/dd";
			this.ShfDate3.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate3.Text = "ZZZ6/Z6/Z6";
			this.ShfDate3.Top = 2.184F;
			this.ShfDate3.Width = 0.563F;
			// 
			// ShfDate4
			// 
			this.ShfDate4.CanGrow = false;
			this.ShfDate4.DataField = "SHF_DATE_4";
			this.ShfDate4.Height = 0.168F;
			this.ShfDate4.Left = 0.063F;
			this.ShfDate4.Name = "ShfDate4";
			this.ShfDate4.OutputFormat = "yyyy/MM/dd";
			this.ShfDate4.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate4.Text = "ZZZ6/Z6/Z6";
			this.ShfDate4.Top = 2.352F;
			this.ShfDate4.Width = 0.563F;
			// 
			// ShfDate5
			// 
			this.ShfDate5.CanGrow = false;
			this.ShfDate5.DataField = "SHF_DATE_5";
			this.ShfDate5.Height = 0.168F;
			this.ShfDate5.Left = 0.063F;
			this.ShfDate5.Name = "ShfDate5";
			this.ShfDate5.OutputFormat = "yyyy/MM/dd";
			this.ShfDate5.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate5.Text = "ZZZ6/Z6/Z6";
			this.ShfDate5.Top = 2.52F;
			this.ShfDate5.Width = 0.563F;
			// 
			// ShfDate6
			// 
			this.ShfDate6.CanGrow = false;
			this.ShfDate6.DataField = "SHF_DATE_6";
			this.ShfDate6.Height = 0.168F;
			this.ShfDate6.Left = 0.063F;
			this.ShfDate6.Name = "ShfDate6";
			this.ShfDate6.OutputFormat = "yyyy/MM/dd";
			this.ShfDate6.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate6.Text = "ZZZ6/Z6/Z6";
			this.ShfDate6.Top = 2.688F;
			this.ShfDate6.Width = 0.563F;
			// 
			// ShfDate7
			// 
			this.ShfDate7.CanGrow = false;
			this.ShfDate7.DataField = "SHF_DATE_7";
			this.ShfDate7.Height = 0.168F;
			this.ShfDate7.Left = 0.063F;
			this.ShfDate7.Name = "ShfDate7";
			this.ShfDate7.OutputFormat = "yyyy/MM/dd";
			this.ShfDate7.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate7.Text = "ZZZ6/Z6/Z6";
			this.ShfDate7.Top = 2.856F;
			this.ShfDate7.Width = 0.563F;
			// 
			// ShfDate8
			// 
			this.ShfDate8.CanGrow = false;
			this.ShfDate8.DataField = "SHF_DATE_8";
			this.ShfDate8.Height = 0.168F;
			this.ShfDate8.Left = 0.063F;
			this.ShfDate8.Name = "ShfDate8";
			this.ShfDate8.OutputFormat = "yyyy/MM/dd";
			this.ShfDate8.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate8.Text = "ZZZ6/Z6/Z6";
			this.ShfDate8.Top = 3.024F;
			this.ShfDate8.Width = 0.563F;
			// 
			// ShfDate9
			// 
			this.ShfDate9.CanGrow = false;
			this.ShfDate9.DataField = "SHF_DATE_9";
			this.ShfDate9.Height = 0.168F;
			this.ShfDate9.Left = 0.063F;
			this.ShfDate9.Name = "ShfDate9";
			this.ShfDate9.OutputFormat = "yyyy/MM/dd";
			this.ShfDate9.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate9.Text = "ZZZ6/Z6/Z6";
			this.ShfDate9.Top = 3.192F;
			this.ShfDate9.Width = 0.563F;
			// 
			// ShfDate10
			// 
			this.ShfDate10.CanGrow = false;
			this.ShfDate10.DataField = "SHF_DATE_10";
			this.ShfDate10.Height = 0.168F;
			this.ShfDate10.Left = 0.063F;
			this.ShfDate10.Name = "ShfDate10";
			this.ShfDate10.OutputFormat = "yyyy/MM/dd";
			this.ShfDate10.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate10.Text = "ZZZ6/Z6/Z6";
			this.ShfDate10.Top = 3.36F;
			this.ShfDate10.Width = 0.563F;
			// 
			// ShfDate11
			// 
			this.ShfDate11.CanGrow = false;
			this.ShfDate11.DataField = "SHF_DATE_11";
			this.ShfDate11.Height = 0.168F;
			this.ShfDate11.Left = 0.063F;
			this.ShfDate11.Name = "ShfDate11";
			this.ShfDate11.OutputFormat = "yyyy/MM/dd";
			this.ShfDate11.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate11.Text = "ZZZ6/Z6/Z6";
			this.ShfDate11.Top = 3.528F;
			this.ShfDate11.Width = 0.563F;
			// 
			// ShfDate12
			// 
			this.ShfDate12.CanGrow = false;
			this.ShfDate12.DataField = "SHF_DATE_12";
			this.ShfDate12.Height = 0.168F;
			this.ShfDate12.Left = 0.063F;
			this.ShfDate12.Name = "ShfDate12";
			this.ShfDate12.OutputFormat = "yyyy/MM/dd";
			this.ShfDate12.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate12.Text = "ZZZ6/Z6/Z6";
			this.ShfDate12.Top = 3.696F;
			this.ShfDate12.Width = 0.563F;
			// 
			// ShfDate13
			// 
			this.ShfDate13.CanGrow = false;
			this.ShfDate13.DataField = "SHF_DATE_13";
			this.ShfDate13.Height = 0.168F;
			this.ShfDate13.Left = 0.063F;
			this.ShfDate13.Name = "ShfDate13";
			this.ShfDate13.OutputFormat = "yyyy/MM/dd";
			this.ShfDate13.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate13.Text = "ZZZ6/Z6/Z6";
			this.ShfDate13.Top = 3.864F;
			this.ShfDate13.Width = 0.563F;
			// 
			// ShfDate14
			// 
			this.ShfDate14.CanGrow = false;
			this.ShfDate14.DataField = "SHF_DATE_14";
			this.ShfDate14.Height = 0.168F;
			this.ShfDate14.Left = 0.063F;
			this.ShfDate14.Name = "ShfDate14";
			this.ShfDate14.OutputFormat = "yyyy/MM/dd";
			this.ShfDate14.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate14.Text = "ZZZ6/Z6/Z6";
			this.ShfDate14.Top = 4.032F;
			this.ShfDate14.Width = 0.563F;
			// 
			// ShfDate15
			// 
			this.ShfDate15.CanGrow = false;
			this.ShfDate15.DataField = "SHF_DATE_15";
			this.ShfDate15.Height = 0.168F;
			this.ShfDate15.Left = 0.063F;
			this.ShfDate15.Name = "ShfDate15";
			this.ShfDate15.OutputFormat = "yyyy/MM/dd";
			this.ShfDate15.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfDate15.Text = "ZZZ6/Z6/Z6";
			this.ShfDate15.Top = 4.2F;
			this.ShfDate15.Width = 0.563F;
			// 
			// Label129
			// 
			this.Label129.Height = 0.168F;
			this.Label129.HyperLink = null;
			this.Label129.Left = 3.413F;
			this.Label129.Name = "Label129";
			this.Label129.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label129.Text = "【前職歴情報】";
			this.Label129.Top = 1.512F;
			this.Label129.Width = 3.687F;
			// 
			// Label130
			// 
			this.Label130.Height = 0.168F;
			this.Label130.HyperLink = null;
			this.Label130.Left = 3.413F;
			this.Label130.Name = "Label130";
			this.Label130.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label130.Text = "入社";
			this.Label130.Top = 1.68F;
			this.Label130.Width = 0.4F;
			// 
			// Label131
			// 
			this.Label131.Height = 0.168F;
			this.Label131.HyperLink = null;
			this.Label131.Left = 4.461F;
			this.Label131.Name = "Label131";
			this.Label131.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label131.Text = "勤務先名";
			this.Label131.Top = 1.68F;
			this.Label131.Width = 1.97F;
			// 
			// EntranceDate1Text
			// 
			this.EntranceDate1Text.CanGrow = false;
			this.EntranceDate1Text.DataField = "ENTRANCE_DATE1";
			this.EntranceDate1Text.Height = 0.168F;
			this.EntranceDate1Text.Left = 3.438F;
			this.EntranceDate1Text.Name = "EntranceDate1Text";
			this.EntranceDate1Text.OutputFormat = "yyyy/MM";
			this.EntranceDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate1Text.Text = "ZZZ9/Z9";
			this.EntranceDate1Text.Top = 1.848F;
			this.EntranceDate1Text.Width = 0.4995F;
			// 
			// CompName1Text
			// 
			this.CompName1Text.CanGrow = false;
			this.CompName1Text.DataField = "COMP_NAME1";
			this.CompName1Text.Height = 0.168F;
			this.CompName1Text.Left = 4.461F;
			this.CompName1Text.Name = "CompName1Text";
			this.CompName1Text.OutputFormat = "#,##0";
			this.CompName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName1Text.Text = "ああああああああああああああああああああ";
			this.CompName1Text.Top = 1.848F;
			this.CompName1Text.Width = 1.97F;
			// 
			// Label132
			// 
			this.Label132.Height = 0.168F;
			this.Label132.HyperLink = null;
			this.Label132.Left = 6.225F;
			this.Label132.Name = "Label132";
			this.Label132.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label132.Text = "職種";
			this.Label132.Top = 1.68F;
			this.Label132.Width = 0.875F;
			// 
			// Job1Text
			// 
			this.Job1Text.CanGrow = false;
			this.Job1Text.DataField = "JOB1";
			this.Job1Text.Height = 0.168F;
			this.Job1Text.Left = 6.438001F;
			this.Job1Text.Name = "Job1Text";
			this.Job1Text.OutputFormat = "#,##0";
			this.Job1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Job1Text.Text = "ああああああ";
			this.Job1Text.Top = 1.848F;
			this.Job1Text.Width = 0.662F;
			// 
			// CompName2Text
			// 
			this.CompName2Text.CanGrow = false;
			this.CompName2Text.DataField = "COMP_NAME2";
			this.CompName2Text.Height = 0.168F;
			this.CompName2Text.Left = 4.461F;
			this.CompName2Text.Name = "CompName2Text";
			this.CompName2Text.OutputFormat = "#,##0";
			this.CompName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName2Text.Text = "ああああああああああああああああああああ";
			this.CompName2Text.Top = 2.016F;
			this.CompName2Text.Width = 1.97F;
			// 
			// Job2Text
			// 
			this.Job2Text.CanGrow = false;
			this.Job2Text.DataField = "JOB2";
			this.Job2Text.Height = 0.168F;
			this.Job2Text.Left = 6.438001F;
			this.Job2Text.Name = "Job2Text";
			this.Job2Text.OutputFormat = "#,##0";
			this.Job2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Job2Text.Text = "ああああああ";
			this.Job2Text.Top = 2.016F;
			this.Job2Text.Width = 0.662F;
			// 
			// CompName3Text
			// 
			this.CompName3Text.CanGrow = false;
			this.CompName3Text.DataField = "COMP_NAME3";
			this.CompName3Text.Height = 0.168F;
			this.CompName3Text.Left = 4.461F;
			this.CompName3Text.Name = "CompName3Text";
			this.CompName3Text.OutputFormat = "#,##0";
			this.CompName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName3Text.Text = "ああああああああああああああああああああ";
			this.CompName3Text.Top = 2.184F;
			this.CompName3Text.Width = 1.97F;
			// 
			// Job3Text
			// 
			this.Job3Text.CanGrow = false;
			this.Job3Text.DataField = "JOB3";
			this.Job3Text.Height = 0.168F;
			this.Job3Text.Left = 6.438001F;
			this.Job3Text.Name = "Job3Text";
			this.Job3Text.OutputFormat = "#,##0";
			this.Job3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Job3Text.Text = "ああああああ";
			this.Job3Text.Top = 2.184F;
			this.Job3Text.Width = 0.662F;
			// 
			// CompName4Text
			// 
			this.CompName4Text.CanGrow = false;
			this.CompName4Text.DataField = "COMP_NAME4";
			this.CompName4Text.Height = 0.168F;
			this.CompName4Text.Left = 4.461F;
			this.CompName4Text.Name = "CompName4Text";
			this.CompName4Text.OutputFormat = "#,##0";
			this.CompName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName4Text.Text = "ああああああああああああああああああああ";
			this.CompName4Text.Top = 2.352F;
			this.CompName4Text.Width = 1.97F;
			// 
			// Job4Text
			// 
			this.Job4Text.CanGrow = false;
			this.Job4Text.DataField = "JOB4";
			this.Job4Text.Height = 0.168F;
			this.Job4Text.Left = 6.438001F;
			this.Job4Text.Name = "Job4Text";
			this.Job4Text.OutputFormat = "#,##0";
			this.Job4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Job4Text.Text = "ああああああ";
			this.Job4Text.Top = 2.352F;
			this.Job4Text.Width = 0.662F;
			// 
			// CompName5Text
			// 
			this.CompName5Text.CanGrow = false;
			this.CompName5Text.DataField = "COMP_NAME5";
			this.CompName5Text.Height = 0.168F;
			this.CompName5Text.Left = 4.461F;
			this.CompName5Text.Name = "CompName5Text";
			this.CompName5Text.OutputFormat = "#,##0";
			this.CompName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName5Text.Text = "ああああああああああああああああああああ";
			this.CompName5Text.Top = 2.52F;
			this.CompName5Text.Width = 1.97F;
			// 
			// Job5Text
			// 
			this.Job5Text.CanGrow = false;
			this.Job5Text.DataField = "JOB5";
			this.Job5Text.Height = 0.168F;
			this.Job5Text.Left = 6.438001F;
			this.Job5Text.Name = "Job5Text";
			this.Job5Text.OutputFormat = "#,##0";
			this.Job5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Job5Text.Text = "ああああああ";
			this.Job5Text.Top = 2.52F;
			this.Job5Text.Width = 0.662F;
			// 
			// Label133
			// 
			this.Label133.Height = 0.168F;
			this.Label133.HyperLink = null;
			this.Label133.Left = 3.413F;
			this.Label133.Name = "Label133";
			this.Label133.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label133.Text = "【学歴情報】";
			this.Label133.Top = 2.688F;
			this.Label133.Width = 3.687F;
			// 
			// Label134
			// 
			this.Label134.Height = 0.168F;
			this.Label134.HyperLink = null;
			this.Label134.Left = 3.413F;
			this.Label134.Name = "Label134";
			this.Label134.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label134.Text = "年月";
			this.Label134.Top = 2.856F;
			this.Label134.Width = 0.688F;
			// 
			// Label135
			// 
			this.Label135.Height = 0.168F;
			this.Label135.HyperLink = null;
			this.Label135.Left = 4.1F;
			this.Label135.Name = "Label135";
			this.Label135.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label135.Text = "学校名";
			this.Label135.Top = 2.856F;
			this.Label135.Width = 3F;
			// 
			// Label137
			// 
			this.Label137.Height = 0.168F;
			this.Label137.HyperLink = null;
			this.Label137.Left = 4.1F;
			this.Label137.Name = "Label137";
			this.Label137.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label137.Text = "分類";
			this.Label137.Top = 3.024F;
			this.Label137.Width = 1F;
			// 
			// SHF_DATE_18
			// 
			this.SHF_DATE_18.CanGrow = false;
			this.SHF_DATE_18.DataField = "SHF_DATE_18";
			this.SHF_DATE_18.Height = 0.168F;
			this.SHF_DATE_18.Left = 0.063F;
			this.SHF_DATE_18.Name = "SHF_DATE_18";
			this.SHF_DATE_18.OutputFormat = "yyyy/MM/dd";
			this.SHF_DATE_18.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SHF_DATE_18.Text = "ZZZ6/Z6/Z6";
			this.SHF_DATE_18.Top = 4.704F;
			this.SHF_DATE_18.Width = 0.563F;
			// 
			// SHF_DATE_19
			// 
			this.SHF_DATE_19.CanGrow = false;
			this.SHF_DATE_19.DataField = "SHF_DATE_19";
			this.SHF_DATE_19.Height = 0.168F;
			this.SHF_DATE_19.Left = 0.063F;
			this.SHF_DATE_19.Name = "SHF_DATE_19";
			this.SHF_DATE_19.OutputFormat = "yyyy/MM/dd";
			this.SHF_DATE_19.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SHF_DATE_19.Text = "ZZZ6/Z6/Z6";
			this.SHF_DATE_19.Top = 4.872F;
			this.SHF_DATE_19.Width = 0.563F;
			// 
			// SHF_DATE_20
			// 
			this.SHF_DATE_20.CanGrow = false;
			this.SHF_DATE_20.DataField = "SHF_DATE_20";
			this.SHF_DATE_20.Height = 0.168F;
			this.SHF_DATE_20.Left = 0.063F;
			this.SHF_DATE_20.Name = "SHF_DATE_20";
			this.SHF_DATE_20.OutputFormat = "yyyy/MM/dd";
			this.SHF_DATE_20.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SHF_DATE_20.Text = "ZZZ6/Z6/Z6";
			this.SHF_DATE_20.Top = 5.04F;
			this.SHF_DATE_20.Width = 0.563F;
			// 
			// ProjFromDateText1
			// 
			this.ProjFromDateText1.CanGrow = false;
			this.ProjFromDateText1.DataField = "PROJ_FROM_DATE_1";
			this.ProjFromDateText1.Height = 0.168F;
			this.ProjFromDateText1.Left = 0.063F;
			this.ProjFromDateText1.Name = "ProjFromDateText1";
			this.ProjFromDateText1.OutputFormat = "yyyy/MM/dd";
			this.ProjFromDateText1.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDateText1.Text = "ZZZ6/Z6/Z6";
			this.ProjFromDateText1.Top = 5.543999F;
			this.ProjFromDateText1.Width = 0.563F;
			// 
			// ProjFromDateText2
			// 
			this.ProjFromDateText2.CanGrow = false;
			this.ProjFromDateText2.DataField = "PROJ_FROM_DATE_2";
			this.ProjFromDateText2.Height = 0.168F;
			this.ProjFromDateText2.Left = 0.063F;
			this.ProjFromDateText2.Name = "ProjFromDateText2";
			this.ProjFromDateText2.OutputFormat = "yyyy/MM/dd";
			this.ProjFromDateText2.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDateText2.Text = "ZZZ6/Z6/Z6";
			this.ProjFromDateText2.Top = 5.712F;
			this.ProjFromDateText2.Width = 0.563F;
			// 
			// ProjFromDateText3
			// 
			this.ProjFromDateText3.CanGrow = false;
			this.ProjFromDateText3.DataField = "PROJ_FROM_DATE_3";
			this.ProjFromDateText3.Height = 0.168F;
			this.ProjFromDateText3.Left = 0.063F;
			this.ProjFromDateText3.Name = "ProjFromDateText3";
			this.ProjFromDateText3.OutputFormat = "yyyy/MM/dd";
			this.ProjFromDateText3.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDateText3.Text = "ZZZ6/Z6/Z6";
			this.ProjFromDateText3.Top = 5.88F;
			this.ProjFromDateText3.Width = 0.563F;
			// 
			// ProjFromDateText4
			// 
			this.ProjFromDateText4.CanGrow = false;
			this.ProjFromDateText4.DataField = "PROJ_FROM_DATE_4";
			this.ProjFromDateText4.Height = 0.168F;
			this.ProjFromDateText4.Left = 0.063F;
			this.ProjFromDateText4.Name = "ProjFromDateText4";
			this.ProjFromDateText4.OutputFormat = "yyyy/MM/dd";
			this.ProjFromDateText4.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDateText4.Text = "ZZZ6/Z6/Z6";
			this.ProjFromDateText4.Top = 6.048F;
			this.ProjFromDateText4.Width = 0.563F;
			// 
			// ProjFromDateText5
			// 
			this.ProjFromDateText5.CanGrow = false;
			this.ProjFromDateText5.DataField = "PROJ_FROM_DATE_5";
			this.ProjFromDateText5.Height = 0.168F;
			this.ProjFromDateText5.Left = 0.063F;
			this.ProjFromDateText5.Name = "ProjFromDateText5";
			this.ProjFromDateText5.OutputFormat = "yyyy/MM/dd";
			this.ProjFromDateText5.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDateText5.Text = "ZZZ6/Z6/Z6";
			this.ProjFromDateText5.Top = 6.216F;
			this.ProjFromDateText5.Width = 0.563F;
			// 
			// Label141
			// 
			this.Label141.Height = 0.168F;
			this.Label141.HyperLink = null;
			this.Label141.Left = 0.063F;
			this.Label141.Name = "Label141";
			this.Label141.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label141.Text = "【社内職歴情報】";
			this.Label141.Top = 6.384F;
			this.Label141.Width = 3.35F;
			// 
			// Label142
			// 
			this.Label142.Height = 0.168F;
			this.Label142.HyperLink = null;
			this.Label142.Left = 0.063F;
			this.Label142.Name = "Label142";
			this.Label142.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label142.Text = "開始／終了";
			this.Label142.Top = 6.552F;
			this.Label142.Width = 0.563F;
			// 
			// Label143
			// 
			this.Label143.Height = 0.168F;
			this.Label143.HyperLink = null;
			this.Label143.Left = 0.6875F;
			this.Label143.Name = "Label143";
			this.Label143.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label143.Text = "期間／職歴";
			this.Label143.Top = 6.552F;
			this.Label143.Width = 0.9375F;
			// 
			// Label144
			// 
			this.Label144.Height = 0.168F;
			this.Label144.HyperLink = null;
			this.Label144.Left = 1.625F;
			this.Label144.Name = "Label144";
			this.Label144.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label144.Text = "職歴内容";
			this.Label144.Top = 6.552F;
			this.Label144.Width = 1.788F;
			// 
			// WorkExpFromDate1Text
			// 
			this.WorkExpFromDate1Text.CanGrow = false;
			this.WorkExpFromDate1Text.DataField = "WORK_EXP_FROMDATE_1";
			this.WorkExpFromDate1Text.Height = 0.168F;
			this.WorkExpFromDate1Text.Left = 0.063F;
			this.WorkExpFromDate1Text.Name = "WorkExpFromDate1Text";
			this.WorkExpFromDate1Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate1Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate1Text.Top = 6.72F;
			this.WorkExpFromDate1Text.Width = 0.563F;
			// 
			// WorkExpName1Text
			// 
			this.WorkExpName1Text.CanGrow = false;
			this.WorkExpName1Text.DataField = "WORK_EXP_NAME_1";
			this.WorkExpName1Text.Height = 0.168F;
			this.WorkExpName1Text.Left = 0.625F;
			this.WorkExpName1Text.Name = "WorkExpName1Text";
			this.WorkExpName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName1Text.Text = "ああああああああああ";
			this.WorkExpName1Text.Top = 6.888F;
			this.WorkExpName1Text.Width = 1F;
			// 
			// WorkExpTodate1Text
			// 
			this.WorkExpTodate1Text.CanGrow = false;
			this.WorkExpTodate1Text.DataField = "WORK_EXP_TODATE_1";
			this.WorkExpTodate1Text.Height = 0.168F;
			this.WorkExpTodate1Text.Left = 0.063F;
			this.WorkExpTodate1Text.Name = "WorkExpTodate1Text";
			this.WorkExpTodate1Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate1Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate1Text.Top = 6.888F;
			this.WorkExpTodate1Text.Width = 0.563F;
			// 
			// WordExpRemarks1Text
			// 
			this.WordExpRemarks1Text.CanGrow = false;
			this.WordExpRemarks1Text.DataField = "WORK_EXP_REMARKS_1";
			this.WordExpRemarks1Text.Height = 0.3425002F;
			this.WordExpRemarks1Text.Left = 1.625F;
			this.WordExpRemarks1Text.Name = "WordExpRemarks1Text";
			this.WordExpRemarks1Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks1Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks1Text.Top = 6.72F;
			this.WordExpRemarks1Text.Width = 1.788F;
			// 
			// WorkExpFromDate2Text
			// 
			this.WorkExpFromDate2Text.CanGrow = false;
			this.WorkExpFromDate2Text.DataField = "WORK_EXP_FROMDATE_2";
			this.WorkExpFromDate2Text.Height = 0.168F;
			this.WorkExpFromDate2Text.Left = 0.063F;
			this.WorkExpFromDate2Text.Name = "WorkExpFromDate2Text";
			this.WorkExpFromDate2Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate2Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate2Text.Top = 7.056F;
			this.WorkExpFromDate2Text.Width = 0.563F;
			// 
			// WorkExpTodate2Text
			// 
			this.WorkExpTodate2Text.CanGrow = false;
			this.WorkExpTodate2Text.DataField = "WORK_EXP_TODATE_2";
			this.WorkExpTodate2Text.Height = 0.168F;
			this.WorkExpTodate2Text.Left = 0.063F;
			this.WorkExpTodate2Text.Name = "WorkExpTodate2Text";
			this.WorkExpTodate2Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate2Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate2Text.Top = 7.224F;
			this.WorkExpTodate2Text.Width = 0.563F;
			// 
			// WorkExpName2Text
			// 
			this.WorkExpName2Text.CanGrow = false;
			this.WorkExpName2Text.DataField = "WORK_EXP_NAME_2";
			this.WorkExpName2Text.Height = 0.168F;
			this.WorkExpName2Text.Left = 0.625F;
			this.WorkExpName2Text.Name = "WorkExpName2Text";
			this.WorkExpName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName2Text.Text = "ああああああああああ";
			this.WorkExpName2Text.Top = 7.224F;
			this.WorkExpName2Text.Width = 1F;
			// 
			// WorkExpFromDate3Text
			// 
			this.WorkExpFromDate3Text.CanGrow = false;
			this.WorkExpFromDate3Text.DataField = "WORK_EXP_FROMDATE_3";
			this.WorkExpFromDate3Text.Height = 0.168F;
			this.WorkExpFromDate3Text.Left = 0.063F;
			this.WorkExpFromDate3Text.Name = "WorkExpFromDate3Text";
			this.WorkExpFromDate3Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate3Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate3Text.Top = 7.392F;
			this.WorkExpFromDate3Text.Width = 0.563F;
			// 
			// WorkExpTodate3Text
			// 
			this.WorkExpTodate3Text.CanGrow = false;
			this.WorkExpTodate3Text.DataField = "WORK_EXP_TODATE_3";
			this.WorkExpTodate3Text.Height = 0.168F;
			this.WorkExpTodate3Text.Left = 0.063F;
			this.WorkExpTodate3Text.Name = "WorkExpTodate3Text";
			this.WorkExpTodate3Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate3Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate3Text.Top = 7.56F;
			this.WorkExpTodate3Text.Width = 0.563F;
			// 
			// WorkExpName3Text
			// 
			this.WorkExpName3Text.CanGrow = false;
			this.WorkExpName3Text.DataField = "WORK_EXP_NAME_3";
			this.WorkExpName3Text.Height = 0.168F;
			this.WorkExpName3Text.Left = 0.625F;
			this.WorkExpName3Text.Name = "WorkExpName3Text";
			this.WorkExpName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName3Text.Text = "ああああああああああ";
			this.WorkExpName3Text.Top = 7.56F;
			this.WorkExpName3Text.Width = 1F;
			// 
			// WorkExpTodate6Text
			// 
			this.WorkExpTodate6Text.CanGrow = false;
			this.WorkExpTodate6Text.DataField = "WORK_EXP_TODATE_6";
			this.WorkExpTodate6Text.Height = 0.168F;
			this.WorkExpTodate6Text.Left = 0.063F;
			this.WorkExpTodate6Text.Name = "WorkExpTodate6Text";
			this.WorkExpTodate6Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate6Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate6Text.Top = 8.568F;
			this.WorkExpTodate6Text.Width = 0.563F;
			// 
			// WorkExpName6Text
			// 
			this.WorkExpName6Text.CanGrow = false;
			this.WorkExpName6Text.DataField = "WORK_EXP_NAME_6";
			this.WorkExpName6Text.Height = 0.168F;
			this.WorkExpName6Text.Left = 0.625F;
			this.WorkExpName6Text.Name = "WorkExpName6Text";
			this.WorkExpName6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName6Text.Text = "ああああああああああ";
			this.WorkExpName6Text.Top = 8.568F;
			this.WorkExpName6Text.Width = 1F;
			// 
			// WorkExpName5Text
			// 
			this.WorkExpName5Text.CanGrow = false;
			this.WorkExpName5Text.DataField = "WORK_EXP_NAME_5";
			this.WorkExpName5Text.Height = 0.168F;
			this.WorkExpName5Text.Left = 0.625F;
			this.WorkExpName5Text.Name = "WorkExpName5Text";
			this.WorkExpName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName5Text.Text = "ああああああああああ";
			this.WorkExpName5Text.Top = 8.232F;
			this.WorkExpName5Text.Width = 1F;
			// 
			// WorkExpName4Text
			// 
			this.WorkExpName4Text.CanGrow = false;
			this.WorkExpName4Text.DataField = "WORK_EXP_NAME_4";
			this.WorkExpName4Text.Height = 0.168F;
			this.WorkExpName4Text.Left = 0.625F;
			this.WorkExpName4Text.Name = "WorkExpName4Text";
			this.WorkExpName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName4Text.Text = "ああああああああああ";
			this.WorkExpName4Text.Top = 7.896F;
			this.WorkExpName4Text.Width = 1F;
			// 
			// WorkExpFromDate4Text
			// 
			this.WorkExpFromDate4Text.CanGrow = false;
			this.WorkExpFromDate4Text.DataField = "WORK_EXP_FROMDATE_4";
			this.WorkExpFromDate4Text.Height = 0.168F;
			this.WorkExpFromDate4Text.Left = 0.063F;
			this.WorkExpFromDate4Text.Name = "WorkExpFromDate4Text";
			this.WorkExpFromDate4Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate4Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate4Text.Top = 7.728F;
			this.WorkExpFromDate4Text.Width = 0.563F;
			// 
			// WorkExpTodate4Text
			// 
			this.WorkExpTodate4Text.CanGrow = false;
			this.WorkExpTodate4Text.DataField = "WORK_EXP_TODATE_4";
			this.WorkExpTodate4Text.Height = 0.168F;
			this.WorkExpTodate4Text.Left = 0.063F;
			this.WorkExpTodate4Text.Name = "WorkExpTodate4Text";
			this.WorkExpTodate4Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate4Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate4Text.Top = 7.896F;
			this.WorkExpTodate4Text.Width = 0.563F;
			// 
			// WorkExpFromDate5Text
			// 
			this.WorkExpFromDate5Text.CanGrow = false;
			this.WorkExpFromDate5Text.DataField = "WORK_EXP_FROMDATE_5";
			this.WorkExpFromDate5Text.Height = 0.168F;
			this.WorkExpFromDate5Text.Left = 0.063F;
			this.WorkExpFromDate5Text.Name = "WorkExpFromDate5Text";
			this.WorkExpFromDate5Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate5Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate5Text.Top = 8.064F;
			this.WorkExpFromDate5Text.Width = 0.563F;
			// 
			// WorkExpTodate5Text
			// 
			this.WorkExpTodate5Text.CanGrow = false;
			this.WorkExpTodate5Text.DataField = "WORK_EXP_TODATE_5";
			this.WorkExpTodate5Text.Height = 0.168F;
			this.WorkExpTodate5Text.Left = 0.063F;
			this.WorkExpTodate5Text.Name = "WorkExpTodate5Text";
			this.WorkExpTodate5Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate5Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate5Text.Top = 8.232F;
			this.WorkExpTodate5Text.Width = 0.563F;
			// 
			// WorkExpFromDate6Text
			// 
			this.WorkExpFromDate6Text.CanGrow = false;
			this.WorkExpFromDate6Text.DataField = "WORK_EXP_FROMDATE_6";
			this.WorkExpFromDate6Text.Height = 0.168F;
			this.WorkExpFromDate6Text.Left = 0.063F;
			this.WorkExpFromDate6Text.Name = "WorkExpFromDate6Text";
			this.WorkExpFromDate6Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate6Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate6Text.Top = 8.4F;
			this.WorkExpFromDate6Text.Width = 0.563F;
			// 
			// WorkExpFromDate7Text
			// 
			this.WorkExpFromDate7Text.CanGrow = false;
			this.WorkExpFromDate7Text.DataField = "WORK_EXP_FROMDATE_7";
			this.WorkExpFromDate7Text.Height = 0.168F;
			this.WorkExpFromDate7Text.Left = 0.063F;
			this.WorkExpFromDate7Text.Name = "WorkExpFromDate7Text";
			this.WorkExpFromDate7Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate7Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate7Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate7Text.Top = 8.736F;
			this.WorkExpFromDate7Text.Width = 0.563F;
			// 
			// WorkExpTodate7Text
			// 
			this.WorkExpTodate7Text.CanGrow = false;
			this.WorkExpTodate7Text.DataField = "WORK_EXP_TODATE_7";
			this.WorkExpTodate7Text.Height = 0.168F;
			this.WorkExpTodate7Text.Left = 0.063F;
			this.WorkExpTodate7Text.Name = "WorkExpTodate7Text";
			this.WorkExpTodate7Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate7Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate7Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate7Text.Top = 8.904F;
			this.WorkExpTodate7Text.Width = 0.563F;
			// 
			// WorkExpName7Text
			// 
			this.WorkExpName7Text.CanGrow = false;
			this.WorkExpName7Text.DataField = "WORK_EXP_NAME_7";
			this.WorkExpName7Text.Height = 0.168F;
			this.WorkExpName7Text.Left = 0.625F;
			this.WorkExpName7Text.Name = "WorkExpName7Text";
			this.WorkExpName7Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName7Text.Text = "ああああああああああ";
			this.WorkExpName7Text.Top = 8.904F;
			this.WorkExpName7Text.Width = 1F;
			// 
			// WorkExpFromDate8Text
			// 
			this.WorkExpFromDate8Text.CanGrow = false;
			this.WorkExpFromDate8Text.DataField = "WORK_EXP_FROMDATE_8";
			this.WorkExpFromDate8Text.Height = 0.168F;
			this.WorkExpFromDate8Text.Left = 0.063F;
			this.WorkExpFromDate8Text.Name = "WorkExpFromDate8Text";
			this.WorkExpFromDate8Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate8Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate8Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate8Text.Top = 9.072F;
			this.WorkExpFromDate8Text.Width = 0.563F;
			// 
			// WorkExpTodate8Text
			// 
			this.WorkExpTodate8Text.CanGrow = false;
			this.WorkExpTodate8Text.DataField = "WORK_EXP_TODATE_8";
			this.WorkExpTodate8Text.Height = 0.168F;
			this.WorkExpTodate8Text.Left = 0.063F;
			this.WorkExpTodate8Text.Name = "WorkExpTodate8Text";
			this.WorkExpTodate8Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate8Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate8Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate8Text.Top = 9.24F;
			this.WorkExpTodate8Text.Width = 0.563F;
			// 
			// WorkExpName8Text
			// 
			this.WorkExpName8Text.CanGrow = false;
			this.WorkExpName8Text.DataField = "WORK_EXP_NAME_8";
			this.WorkExpName8Text.Height = 0.168F;
			this.WorkExpName8Text.Left = 0.625F;
			this.WorkExpName8Text.Name = "WorkExpName8Text";
			this.WorkExpName8Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName8Text.Text = "ああああああああああ";
			this.WorkExpName8Text.Top = 9.24F;
			this.WorkExpName8Text.Width = 1F;
			// 
			// WorkExpTodate9Text
			// 
			this.WorkExpTodate9Text.CanGrow = false;
			this.WorkExpTodate9Text.DataField = "WORK_EXP_TODATE_9";
			this.WorkExpTodate9Text.Height = 0.168F;
			this.WorkExpTodate9Text.Left = 0.063F;
			this.WorkExpTodate9Text.Name = "WorkExpTodate9Text";
			this.WorkExpTodate9Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpTodate9Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpTodate9Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpTodate9Text.Top = 9.576F;
			this.WorkExpTodate9Text.Width = 0.688F;
			// 
			// WorkExpFromDate9Text
			// 
			this.WorkExpFromDate9Text.CanGrow = false;
			this.WorkExpFromDate9Text.DataField = "WORK_EXP_FROMDATE_9";
			this.WorkExpFromDate9Text.Height = 0.168F;
			this.WorkExpFromDate9Text.Left = 0.063F;
			this.WorkExpFromDate9Text.Name = "WorkExpFromDate9Text";
			this.WorkExpFromDate9Text.OutputFormat = "yyyy/MM/dd";
			this.WorkExpFromDate9Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpFromDate9Text.Text = "ZZZ6/Z6/Z6";
			this.WorkExpFromDate9Text.Top = 9.408F;
			this.WorkExpFromDate9Text.Width = 0.688F;
			// 
			// WorkExpName9Text
			// 
			this.WorkExpName9Text.CanGrow = false;
			this.WorkExpName9Text.DataField = "WORK_EXP_NAME_9";
			this.WorkExpName9Text.Height = 0.168F;
			this.WorkExpName9Text.Left = 0.625F;
			this.WorkExpName9Text.Name = "WorkExpName9Text";
			this.WorkExpName9Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkExpName9Text.Text = "ああああああああああ";
			this.WorkExpName9Text.Top = 9.576F;
			this.WorkExpName9Text.Width = 1F;
			// 
			// Label145
			// 
			this.Label145.Height = 0.168F;
			this.Label145.HyperLink = null;
			this.Label145.Left = 5.1F;
			this.Label145.Name = "Label145";
			this.Label145.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label145.Text = "昼夜";
			this.Label145.Top = 3.024F;
			this.Label145.Width = 0.813F;
			// 
			// EntraYm1Text
			// 
			this.EntraYm1Text.CanGrow = false;
			this.EntraYm1Text.DataField = "ENTRA_YM_1";
			this.EntraYm1Text.Height = 0.168F;
			this.EntraYm1Text.Left = 3.438F;
			this.EntraYm1Text.Name = "EntraYm1Text";
			this.EntraYm1Text.OutputFormat = "yyyy/MM";
			this.EntraYm1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm1Text.Text = "ZZZ6/Z6";
			this.EntraYm1Text.Top = 3.192F;
			this.EntraYm1Text.Width = 0.6244998F;
			// 
			// SchoolName1Text
			// 
			this.SchoolName1Text.CanGrow = false;
			this.SchoolName1Text.DataField = "SCHOOL_NAME_1";
			this.SchoolName1Text.Height = 0.168F;
			this.SchoolName1Text.Left = 4.1F;
			this.SchoolName1Text.Name = "SchoolName1Text";
			this.SchoolName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName1Text.Text = "ああああああああああ";
			this.SchoolName1Text.Top = 3.192F;
			this.SchoolName1Text.Width = 3F;
			// 
			// ClsName1Text
			// 
			this.ClsName1Text.CanGrow = false;
			this.ClsName1Text.DataField = "CLS_NAME_1";
			this.ClsName1Text.Height = 0.168F;
			this.ClsName1Text.Left = 4.1F;
			this.ClsName1Text.Name = "ClsName1Text";
			this.ClsName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName1Text.Text = "ああああああああああ";
			this.ClsName1Text.Top = 3.36F;
			this.ClsName1Text.Width = 1F;
			// 
			// DayNightType1Text
			// 
			this.DayNightType1Text.CanGrow = false;
			this.DayNightType1Text.DataField = "DAY_NAIGHT1";
			this.DayNightType1Text.Height = 0.168F;
			this.DayNightType1Text.Left = 5.1F;
			this.DayNightType1Text.Name = "DayNightType1Text";
			this.DayNightType1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DayNightType1Text.Text = "ああ";
			this.DayNightType1Text.Top = 3.36F;
			this.DayNightType1Text.Width = 0.813F;
			// 
			// Label147
			// 
			this.Label147.Height = 0.168F;
			this.Label147.HyperLink = null;
			this.Label147.Left = 3.413F;
			this.Label147.Name = "Label147";
			this.Label147.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label147.Text = "【兼務職情報】";
			this.Label147.Top = 4.2F;
			this.Label147.Width = 3.687F;
			// 
			// Label149
			// 
			this.Label149.Height = 0.168F;
			this.Label149.HyperLink = null;
			this.Label149.Left = 4.038F;
			this.Label149.Name = "Label149";
			this.Label149.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label149.Text = "解職日";
			this.Label149.Top = 4.368F;
			this.Label149.Width = 0.625F;
			// 
			// Label150
			// 
			this.Label150.Height = 0.168F;
			this.Label150.HyperLink = null;
			this.Label150.Left = 4.663F;
			this.Label150.Name = "Label150";
			this.Label150.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label150.Text = "兼務職内容";
			this.Label150.Top = 4.368F;
			this.Label150.Width = 2.438F;
			// 
			// ConcurDate2Text
			// 
			this.ConcurDate2Text.CanGrow = false;
			this.ConcurDate2Text.DataField = "CONCUR_DATE_2";
			this.ConcurDate2Text.Height = 0.168F;
			this.ConcurDate2Text.Left = 3.438F;
			this.ConcurDate2Text.Name = "ConcurDate2Text";
			this.ConcurDate2Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurDate2Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurDate2Text.Top = 4.704F;
			this.ConcurDate2Text.Width = 0.625F;
			// 
			// ConcurDate3Text
			// 
			this.ConcurDate3Text.CanGrow = false;
			this.ConcurDate3Text.DataField = "CONCUR_DATE_3";
			this.ConcurDate3Text.Height = 0.168F;
			this.ConcurDate3Text.Left = 3.438F;
			this.ConcurDate3Text.Name = "ConcurDate3Text";
			this.ConcurDate3Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurDate3Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurDate3Text.Top = 4.872F;
			this.ConcurDate3Text.Width = 0.625F;
			// 
			// ConcurDate4Text
			// 
			this.ConcurDate4Text.CanGrow = false;
			this.ConcurDate4Text.DataField = "CONCUR_DATE_4";
			this.ConcurDate4Text.Height = 0.168F;
			this.ConcurDate4Text.Left = 3.438F;
			this.ConcurDate4Text.Name = "ConcurDate4Text";
			this.ConcurDate4Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurDate4Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurDate4Text.Top = 5.04F;
			this.ConcurDate4Text.Width = 0.625F;
			// 
			// ConcurTodate3Text
			// 
			this.ConcurTodate3Text.CanGrow = false;
			this.ConcurTodate3Text.DataField = "CONCUR_TODATE_3";
			this.ConcurTodate3Text.Height = 0.168F;
			this.ConcurTodate3Text.Left = 4.063F;
			this.ConcurTodate3Text.Name = "ConcurTodate3Text";
			this.ConcurTodate3Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurTodate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurTodate3Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurTodate3Text.Top = 4.872F;
			this.ConcurTodate3Text.Width = 0.625F;
			// 
			// ConcurTodate4Text
			// 
			this.ConcurTodate4Text.CanGrow = false;
			this.ConcurTodate4Text.DataField = "CONCUR_TODATE_4";
			this.ConcurTodate4Text.Height = 0.168F;
			this.ConcurTodate4Text.Left = 4.063F;
			this.ConcurTodate4Text.Name = "ConcurTodate4Text";
			this.ConcurTodate4Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurTodate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurTodate4Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurTodate4Text.Top = 5.04F;
			this.ConcurTodate4Text.Width = 0.625F;
			// 
			// ConcurName1Text
			// 
			this.ConcurName1Text.CanGrow = false;
			this.ConcurName1Text.DataField = "CONCUR_NAME_1";
			this.ConcurName1Text.Height = 0.168F;
			this.ConcurName1Text.Left = 4.663F;
			this.ConcurName1Text.Name = "ConcurName1Text";
			this.ConcurName1Text.OutputFormat = "#,##0";
			this.ConcurName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurName1Text.Text = "ああああああああ";
			this.ConcurName1Text.Top = 4.536F;
			this.ConcurName1Text.Width = 1.025197F;
			// 
			// ConcurName2Text
			// 
			this.ConcurName2Text.CanGrow = false;
			this.ConcurName2Text.DataField = "CONCUR_NAME_2";
			this.ConcurName2Text.Height = 0.168F;
			this.ConcurName2Text.Left = 4.663F;
			this.ConcurName2Text.Name = "ConcurName2Text";
			this.ConcurName2Text.OutputFormat = "#,##0";
			this.ConcurName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurName2Text.Text = "ああああああああ";
			this.ConcurName2Text.Top = 4.704F;
			this.ConcurName2Text.Width = 1.025197F;
			// 
			// ConcurName3Text
			// 
			this.ConcurName3Text.CanGrow = false;
			this.ConcurName3Text.DataField = "CONCUR_NAME_3";
			this.ConcurName3Text.Height = 0.168F;
			this.ConcurName3Text.Left = 4.663F;
			this.ConcurName3Text.Name = "ConcurName3Text";
			this.ConcurName3Text.OutputFormat = "#,##0";
			this.ConcurName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurName3Text.Text = "ああああああああ";
			this.ConcurName3Text.Top = 4.872F;
			this.ConcurName3Text.Width = 1.025197F;
			// 
			// ConcurName4Text
			// 
			this.ConcurName4Text.CanGrow = false;
			this.ConcurName4Text.DataField = "CONCUR_NAME_4";
			this.ConcurName4Text.Height = 0.168F;
			this.ConcurName4Text.Left = 4.663F;
			this.ConcurName4Text.Name = "ConcurName4Text";
			this.ConcurName4Text.OutputFormat = "#,##0";
			this.ConcurName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurName4Text.Text = "ああああああああ";
			this.ConcurName4Text.Top = 5.04F;
			this.ConcurName4Text.Width = 1.025197F;
			// 
			// Label151
			// 
			this.Label151.Height = 0.168F;
			this.Label151.HyperLink = null;
			this.Label151.Left = 3.413F;
			this.Label151.Name = "Label151";
			this.Label151.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label151.Text = "【研修情報】";
			this.Label151.Top = 5.208001F;
			this.Label151.Width = 3.687F;
			// 
			// TraniFrom1Text
			// 
			this.TraniFrom1Text.CanGrow = false;
			this.TraniFrom1Text.DataField = "TRANI_FROM_1";
			this.TraniFrom1Text.Height = 0.168F;
			this.TraniFrom1Text.Left = 3.438F;
			this.TraniFrom1Text.Name = "TraniFrom1Text";
			this.TraniFrom1Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom1Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom1Text.Top = 5.543999F;
			this.TraniFrom1Text.Width = 0.625F;
			// 
			// TraniName1Text
			// 
			this.TraniName1Text.CanGrow = false;
			this.TraniName1Text.DataField = "TRANI_NAME_1";
			this.TraniName1Text.Height = 0.168F;
			this.TraniName1Text.Left = 4.038F;
			this.TraniName1Text.Name = "TraniName1Text";
			this.TraniName1Text.OutputFormat = "#,##0";
			this.TraniName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName1Text.Text = "ああああああああああ";
			this.TraniName1Text.Top = 5.543999F;
			this.TraniName1Text.Width = 1.625F;
			// 
			// TraniFrom2Text
			// 
			this.TraniFrom2Text.CanGrow = false;
			this.TraniFrom2Text.DataField = "TRANI_FROM_2";
			this.TraniFrom2Text.Height = 0.168F;
			this.TraniFrom2Text.Left = 3.438F;
			this.TraniFrom2Text.Name = "TraniFrom2Text";
			this.TraniFrom2Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom2Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom2Text.Top = 5.712F;
			this.TraniFrom2Text.Width = 0.625F;
			// 
			// TraniName2Text
			// 
			this.TraniName2Text.CanGrow = false;
			this.TraniName2Text.DataField = "TRANI_NAME_2";
			this.TraniName2Text.Height = 0.168F;
			this.TraniName2Text.Left = 4.038F;
			this.TraniName2Text.Name = "TraniName2Text";
			this.TraniName2Text.OutputFormat = "#,##0";
			this.TraniName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName2Text.Text = "ああああああああああ";
			this.TraniName2Text.Top = 5.712F;
			this.TraniName2Text.Width = 1.625F;
			// 
			// TraniFrom3Text
			// 
			this.TraniFrom3Text.CanGrow = false;
			this.TraniFrom3Text.DataField = "TRANI_FROM_3";
			this.TraniFrom3Text.Height = 0.168F;
			this.TraniFrom3Text.Left = 3.438F;
			this.TraniFrom3Text.Name = "TraniFrom3Text";
			this.TraniFrom3Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom3Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom3Text.Top = 5.88F;
			this.TraniFrom3Text.Width = 0.625F;
			// 
			// TraniName3Text
			// 
			this.TraniName3Text.CanGrow = false;
			this.TraniName3Text.DataField = "TRANI_NAME_3";
			this.TraniName3Text.Height = 0.168F;
			this.TraniName3Text.Left = 4.038F;
			this.TraniName3Text.Name = "TraniName3Text";
			this.TraniName3Text.OutputFormat = "#,##0";
			this.TraniName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName3Text.Text = "ああああああああああ";
			this.TraniName3Text.Top = 5.88F;
			this.TraniName3Text.Width = 1.625F;
			// 
			// TraniFrom4Text
			// 
			this.TraniFrom4Text.CanGrow = false;
			this.TraniFrom4Text.DataField = "TRANI_FROM_4";
			this.TraniFrom4Text.Height = 0.168F;
			this.TraniFrom4Text.Left = 3.438F;
			this.TraniFrom4Text.Name = "TraniFrom4Text";
			this.TraniFrom4Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom4Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom4Text.Top = 6.048F;
			this.TraniFrom4Text.Width = 0.625F;
			// 
			// TraniName4Text
			// 
			this.TraniName4Text.CanGrow = false;
			this.TraniName4Text.DataField = "TRANI_NAME_4";
			this.TraniName4Text.Height = 0.168F;
			this.TraniName4Text.Left = 4.038F;
			this.TraniName4Text.Name = "TraniName4Text";
			this.TraniName4Text.OutputFormat = "#,##0";
			this.TraniName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName4Text.Text = "ああああああああああ";
			this.TraniName4Text.Top = 6.048F;
			this.TraniName4Text.Width = 1.625F;
			// 
			// Label152
			// 
			this.Label152.Height = 0.168F;
			this.Label152.HyperLink = null;
			this.Label152.Left = 3.413F;
			this.Label152.Name = "Label152";
			this.Label152.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label152.Text = "日付";
			this.Label152.Top = 5.376F;
			this.Label152.Width = 0.625F;
			// 
			// Label153
			// 
			this.Label153.Height = 0.168F;
			this.Label153.HyperLink = null;
			this.Label153.Left = 4.038F;
			this.Label153.Name = "Label153";
			this.Label153.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label153.Text = "研修内容";
			this.Label153.Top = 5.376F;
			this.Label153.Width = 1.65F;
			// 
			// TraniFrom5Text
			// 
			this.TraniFrom5Text.CanGrow = false;
			this.TraniFrom5Text.DataField = "TRANI_FROM_5";
			this.TraniFrom5Text.Height = 0.168F;
			this.TraniFrom5Text.Left = 3.438F;
			this.TraniFrom5Text.Name = "TraniFrom5Text";
			this.TraniFrom5Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom5Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom5Text.Top = 6.216F;
			this.TraniFrom5Text.Width = 0.625F;
			// 
			// TraniName5Text
			// 
			this.TraniName5Text.CanGrow = false;
			this.TraniName5Text.DataField = "TRANI_NAME_5";
			this.TraniName5Text.Height = 0.168F;
			this.TraniName5Text.Left = 4.038F;
			this.TraniName5Text.Name = "TraniName5Text";
			this.TraniName5Text.OutputFormat = "#,##0";
			this.TraniName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName5Text.Text = "ああああああああああ";
			this.TraniName5Text.Top = 6.216F;
			this.TraniName5Text.Width = 1.625F;
			// 
			// TraniFrom6Text
			// 
			this.TraniFrom6Text.CanGrow = false;
			this.TraniFrom6Text.DataField = "TRANI_FROM_6";
			this.TraniFrom6Text.Height = 0.168F;
			this.TraniFrom6Text.Left = 3.438F;
			this.TraniFrom6Text.Name = "TraniFrom6Text";
			this.TraniFrom6Text.OutputFormat = "yyyy/MM/dd";
			this.TraniFrom6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniFrom6Text.Text = "ZZZ6/Z6/Z6";
			this.TraniFrom6Text.Top = 6.384F;
			this.TraniFrom6Text.Width = 0.625F;
			// 
			// TraniName6Text
			// 
			this.TraniName6Text.CanGrow = false;
			this.TraniName6Text.DataField = "TRANI_NAME_6";
			this.TraniName6Text.Height = 0.168F;
			this.TraniName6Text.Left = 4.038F;
			this.TraniName6Text.Name = "TraniName6Text";
			this.TraniName6Text.OutputFormat = "#,##0";
			this.TraniName6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TraniName6Text.Text = "ああああああああああ";
			this.TraniName6Text.Top = 6.384F;
			this.TraniName6Text.Width = 1.625F;
			// 
			// Label154
			// 
			this.Label154.Height = 0.168F;
			this.Label154.HyperLink = null;
			this.Label154.Left = 3.413F;
			this.Label154.Name = "Label154";
			this.Label154.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label154.Text = "【公的資格情報】";
			this.Label154.Top = 6.552F;
			this.Label154.Width = 3.687F;
			// 
			// Label155
			// 
			this.Label155.Height = 0.168F;
			this.Label155.HyperLink = null;
			this.Label155.Left = 3.413F;
			this.Label155.Name = "Label155";
			this.Label155.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label155.Text = "取得日";
			this.Label155.Top = 6.72F;
			this.Label155.Width = 0.625F;
			// 
			// QualfObtainDate1Text
			// 
			this.QualfObtainDate1Text.CanGrow = false;
			this.QualfObtainDate1Text.DataField = "QUALF_OBTAIN_DATE_1";
			this.QualfObtainDate1Text.Height = 0.168F;
			this.QualfObtainDate1Text.Left = 3.438F;
			this.QualfObtainDate1Text.Name = "QualfObtainDate1Text";
			this.QualfObtainDate1Text.OutputFormat = "yyyy/MM/dd";
			this.QualfObtainDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfObtainDate1Text.Text = "ZZZ6/Z6/Z6";
			this.QualfObtainDate1Text.Top = 6.888F;
			this.QualfObtainDate1Text.Width = 0.625F;
			// 
			// QualfObtainDate2Text
			// 
			this.QualfObtainDate2Text.CanGrow = false;
			this.QualfObtainDate2Text.DataField = "QUALF_OBTAIN_DATE_2";
			this.QualfObtainDate2Text.Height = 0.168F;
			this.QualfObtainDate2Text.Left = 3.438F;
			this.QualfObtainDate2Text.Name = "QualfObtainDate2Text";
			this.QualfObtainDate2Text.OutputFormat = "yyyy/MM/dd";
			this.QualfObtainDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfObtainDate2Text.Text = "ZZZ6/Z6/Z6";
			this.QualfObtainDate2Text.Top = 7.056F;
			this.QualfObtainDate2Text.Width = 0.625F;
			// 
			// QualfObtainDate3Text
			// 
			this.QualfObtainDate3Text.CanGrow = false;
			this.QualfObtainDate3Text.DataField = "QUALF_OBTAIN_DATE_3";
			this.QualfObtainDate3Text.Height = 0.168F;
			this.QualfObtainDate3Text.Left = 3.438F;
			this.QualfObtainDate3Text.Name = "QualfObtainDate3Text";
			this.QualfObtainDate3Text.OutputFormat = "yyyy/MM/dd";
			this.QualfObtainDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfObtainDate3Text.Text = "ZZZ6/Z6/Z6";
			this.QualfObtainDate3Text.Top = 7.224F;
			this.QualfObtainDate3Text.Width = 0.625F;
			// 
			// QualfObtainDate4Text
			// 
			this.QualfObtainDate4Text.CanGrow = false;
			this.QualfObtainDate4Text.DataField = "QUALF_OBTAIN_DATE_4";
			this.QualfObtainDate4Text.Height = 0.168F;
			this.QualfObtainDate4Text.Left = 3.438F;
			this.QualfObtainDate4Text.Name = "QualfObtainDate4Text";
			this.QualfObtainDate4Text.OutputFormat = "yyyy/MM/dd";
			this.QualfObtainDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfObtainDate4Text.Text = "ZZZ6/Z6/Z6";
			this.QualfObtainDate4Text.Top = 7.392F;
			this.QualfObtainDate4Text.Width = 0.625F;
			// 
			// QualfObtainDate5Text
			// 
			this.QualfObtainDate5Text.CanGrow = false;
			this.QualfObtainDate5Text.DataField = "QUALF_OBTAIN_DATE_5";
			this.QualfObtainDate5Text.Height = 0.168F;
			this.QualfObtainDate5Text.Left = 3.438F;
			this.QualfObtainDate5Text.Name = "QualfObtainDate5Text";
			this.QualfObtainDate5Text.OutputFormat = "yyyy/MM/dd";
			this.QualfObtainDate5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfObtainDate5Text.Text = "ZZZ6/Z6/Z6";
			this.QualfObtainDate5Text.Top = 7.56F;
			this.QualfObtainDate5Text.Width = 0.625F;
			// 
			// Label157
			// 
			this.Label157.Height = 0.168F;
			this.Label157.HyperLink = null;
			this.Label157.Left = 3.413F;
			this.Label157.Name = "Label157";
			this.Label157.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label157.Text = "【賞罰情報】";
			this.Label157.Top = 7.728F;
			this.Label157.Width = 3.687F;
			// 
			// Label158
			// 
			this.Label158.Height = 0.168F;
			this.Label158.HyperLink = null;
			this.Label158.Left = 3.413F;
			this.Label158.Name = "Label158";
			this.Label158.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label158.Text = "日付";
			this.Label158.Top = 7.896F;
			this.Label158.Width = 0.625F;
			// 
			// Label159
			// 
			this.Label159.Height = 0.168F;
			this.Label159.HyperLink = null;
			this.Label159.Left = 4.038F;
			this.Label159.Name = "Label159";
			this.Label159.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label159.Text = "賞罰内容";
			this.Label159.Top = 7.896F;
			this.Label159.Width = 3.063F;
			// 
			// RwdPntDate1Text
			// 
			this.RwdPntDate1Text.CanGrow = false;
			this.RwdPntDate1Text.DataField = "RWD_PNT_DATE_1";
			this.RwdPntDate1Text.Height = 0.168F;
			this.RwdPntDate1Text.Left = 3.438F;
			this.RwdPntDate1Text.Name = "RwdPntDate1Text";
			this.RwdPntDate1Text.OutputFormat = "yyyy/MM/dd";
			this.RwdPntDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntDate1Text.Text = "ZZZ6/Z6/Z6";
			this.RwdPntDate1Text.Top = 8.064F;
			this.RwdPntDate1Text.Width = 0.625F;
			// 
			// RwdPntName1Text
			// 
			this.RwdPntName1Text.CanGrow = false;
			this.RwdPntName1Text.DataField = "RWD_PNT_NAME_1";
			this.RwdPntName1Text.Height = 0.168F;
			this.RwdPntName1Text.Left = 4.038F;
			this.RwdPntName1Text.Name = "RwdPntName1Text";
			this.RwdPntName1Text.OutputFormat = "#,##0";
			this.RwdPntName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntName1Text.Text = "ああああああああああああああああああああ";
			this.RwdPntName1Text.Top = 8.064F;
			this.RwdPntName1Text.Width = 3.063F;
			// 
			// RwdPntDate2Text
			// 
			this.RwdPntDate2Text.CanGrow = false;
			this.RwdPntDate2Text.DataField = "RWD_PNT_DATE_2";
			this.RwdPntDate2Text.Height = 0.168F;
			this.RwdPntDate2Text.Left = 3.438F;
			this.RwdPntDate2Text.Name = "RwdPntDate2Text";
			this.RwdPntDate2Text.OutputFormat = "yyyy/MM/dd";
			this.RwdPntDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntDate2Text.Text = "ZZZ6/Z6/Z6";
			this.RwdPntDate2Text.Top = 8.232F;
			this.RwdPntDate2Text.Width = 0.625F;
			// 
			// RwdPntName2Text
			// 
			this.RwdPntName2Text.CanGrow = false;
			this.RwdPntName2Text.DataField = "RWD_PNT_NAME_2";
			this.RwdPntName2Text.Height = 0.168F;
			this.RwdPntName2Text.Left = 4.038F;
			this.RwdPntName2Text.Name = "RwdPntName2Text";
			this.RwdPntName2Text.OutputFormat = "#,##0";
			this.RwdPntName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntName2Text.Text = "ああああああああああああああああああああ";
			this.RwdPntName2Text.Top = 8.232F;
			this.RwdPntName2Text.Width = 3.063F;
			// 
			// RwdPntDate3Text
			// 
			this.RwdPntDate3Text.CanGrow = false;
			this.RwdPntDate3Text.DataField = "RWD_PNT_DATE_3";
			this.RwdPntDate3Text.Height = 0.168F;
			this.RwdPntDate3Text.Left = 3.438F;
			this.RwdPntDate3Text.Name = "RwdPntDate3Text";
			this.RwdPntDate3Text.OutputFormat = "yyyy/MM/dd";
			this.RwdPntDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntDate3Text.Text = "ZZZ6/Z6/Z6";
			this.RwdPntDate3Text.Top = 8.4F;
			this.RwdPntDate3Text.Width = 0.625F;
			// 
			// RwdPntName3Text
			// 
			this.RwdPntName3Text.CanGrow = false;
			this.RwdPntName3Text.DataField = "RWD_PNT_NAME_3";
			this.RwdPntName3Text.Height = 0.168F;
			this.RwdPntName3Text.Left = 4.038F;
			this.RwdPntName3Text.Name = "RwdPntName3Text";
			this.RwdPntName3Text.OutputFormat = "#,##0";
			this.RwdPntName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntName3Text.Text = "ああああああああああああああああああああ";
			this.RwdPntName3Text.Top = 8.4F;
			this.RwdPntName3Text.Width = 3.063F;
			// 
			// RwdPntDate4Text
			// 
			this.RwdPntDate4Text.CanGrow = false;
			this.RwdPntDate4Text.DataField = "RWD_PNT_DATE_4";
			this.RwdPntDate4Text.Height = 0.168F;
			this.RwdPntDate4Text.Left = 3.438F;
			this.RwdPntDate4Text.Name = "RwdPntDate4Text";
			this.RwdPntDate4Text.OutputFormat = "yyyy/MM/dd";
			this.RwdPntDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntDate4Text.Text = "ZZZ6/Z6/Z6";
			this.RwdPntDate4Text.Top = 8.568F;
			this.RwdPntDate4Text.Width = 0.625F;
			// 
			// RwdPntName4Text
			// 
			this.RwdPntName4Text.CanGrow = false;
			this.RwdPntName4Text.DataField = "RWD_PNT_NAME_4";
			this.RwdPntName4Text.Height = 0.168F;
			this.RwdPntName4Text.Left = 4.038F;
			this.RwdPntName4Text.Name = "RwdPntName4Text";
			this.RwdPntName4Text.OutputFormat = "#,##0";
			this.RwdPntName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RwdPntName4Text.Text = "ああああああああああああああああああああ";
			this.RwdPntName4Text.Top = 8.568F;
			this.RwdPntName4Text.Width = 3.063F;
			// 
			// Label160
			// 
			this.Label160.Height = 0.168F;
			this.Label160.HyperLink = null;
			this.Label160.Left = 3.413F;
			this.Label160.Name = "Label160";
			this.Label160.Style = "font-size: 7pt; font-weight: normal; text-align: center; vertical-align: middle; " +
    "ddo-char-set: 1";
			this.Label160.Text = "【休職情報】";
			this.Label160.Top = 8.736F;
			this.Label160.Width = 3.687F;
			// 
			// Label161
			// 
			this.Label161.Height = 0.168F;
			this.Label161.HyperLink = null;
			this.Label161.Left = 3.413F;
			this.Label161.Name = "Label161";
			this.Label161.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label161.Text = "休職日";
			this.Label161.Top = 8.904F;
			this.Label161.Width = 0.625F;
			// 
			// Label162
			// 
			this.Label162.Height = 0.168F;
			this.Label162.HyperLink = null;
			this.Label162.Left = 4.038F;
			this.Label162.Name = "Label162";
			this.Label162.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label162.Text = "復帰日";
			this.Label162.Top = 8.904F;
			this.Label162.Width = 0.625F;
			// 
			// Label163
			// 
			this.Label163.Height = 0.168F;
			this.Label163.HyperLink = null;
			this.Label163.Left = 4.663F;
			this.Label163.Name = "Label163";
			this.Label163.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label163.Text = "休職理由";
			this.Label163.Top = 8.904F;
			this.Label163.Width = 2.437F;
			// 
			// LeaveFromdate1Text
			// 
			this.LeaveFromdate1Text.CanGrow = false;
			this.LeaveFromdate1Text.DataField = "LEAVE_FROMDATE_1";
			this.LeaveFromdate1Text.Height = 0.168F;
			this.LeaveFromdate1Text.Left = 3.438F;
			this.LeaveFromdate1Text.Name = "LeaveFromdate1Text";
			this.LeaveFromdate1Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveFromdate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveFromdate1Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveFromdate1Text.Top = 9.072F;
			this.LeaveFromdate1Text.Width = 0.625F;
			// 
			// LeaveTodate1Text
			// 
			this.LeaveTodate1Text.CanGrow = false;
			this.LeaveTodate1Text.DataField = "LEAVE_TODATE_1";
			this.LeaveTodate1Text.Height = 0.168F;
			this.LeaveTodate1Text.Left = 4.063F;
			this.LeaveTodate1Text.Name = "LeaveTodate1Text";
			this.LeaveTodate1Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveTodate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveTodate1Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveTodate1Text.Top = 9.072F;
			this.LeaveTodate1Text.Width = 0.625F;
			// 
			// LeaveReason1Text
			// 
			this.LeaveReason1Text.CanGrow = false;
			this.LeaveReason1Text.DataField = "LEAVE_REASON_1";
			this.LeaveReason1Text.Height = 0.168F;
			this.LeaveReason1Text.Left = 4.663F;
			this.LeaveReason1Text.Name = "LeaveReason1Text";
			this.LeaveReason1Text.OutputFormat = "#,##0";
			this.LeaveReason1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveReason1Text.Text = "ああああああああああああああああああああ";
			this.LeaveReason1Text.Top = 9.072F;
			this.LeaveReason1Text.Width = 2.437F;
			// 
			// LeaveFromdate2Text
			// 
			this.LeaveFromdate2Text.CanGrow = false;
			this.LeaveFromdate2Text.DataField = "LEAVE_FROMDATE_2";
			this.LeaveFromdate2Text.Height = 0.168F;
			this.LeaveFromdate2Text.Left = 3.438F;
			this.LeaveFromdate2Text.Name = "LeaveFromdate2Text";
			this.LeaveFromdate2Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveFromdate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveFromdate2Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveFromdate2Text.Top = 9.24F;
			this.LeaveFromdate2Text.Width = 0.625F;
			// 
			// LeaveTodate2Text
			// 
			this.LeaveTodate2Text.CanGrow = false;
			this.LeaveTodate2Text.DataField = "LEAVE_TODATE_2";
			this.LeaveTodate2Text.Height = 0.168F;
			this.LeaveTodate2Text.Left = 4.063F;
			this.LeaveTodate2Text.Name = "LeaveTodate2Text";
			this.LeaveTodate2Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveTodate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveTodate2Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveTodate2Text.Top = 9.24F;
			this.LeaveTodate2Text.Width = 0.625F;
			// 
			// LeaveFromdate3Text
			// 
			this.LeaveFromdate3Text.CanGrow = false;
			this.LeaveFromdate3Text.DataField = "LEAVE_FROMDATE_3";
			this.LeaveFromdate3Text.Height = 0.168F;
			this.LeaveFromdate3Text.Left = 3.438F;
			this.LeaveFromdate3Text.Name = "LeaveFromdate3Text";
			this.LeaveFromdate3Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveFromdate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveFromdate3Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveFromdate3Text.Top = 9.408F;
			this.LeaveFromdate3Text.Width = 0.625F;
			// 
			// LeaveTodate3Text
			// 
			this.LeaveTodate3Text.CanGrow = false;
			this.LeaveTodate3Text.DataField = "LEAVE_TODATE_3";
			this.LeaveTodate3Text.Height = 0.168F;
			this.LeaveTodate3Text.Left = 4.063F;
			this.LeaveTodate3Text.Name = "LeaveTodate3Text";
			this.LeaveTodate3Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveTodate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveTodate3Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveTodate3Text.Top = 9.408F;
			this.LeaveTodate3Text.Width = 0.625F;
			// 
			// LeaveFromdate4Text
			// 
			this.LeaveFromdate4Text.CanGrow = false;
			this.LeaveFromdate4Text.DataField = "LEAVE_FROMDATE_4";
			this.LeaveFromdate4Text.Height = 0.168F;
			this.LeaveFromdate4Text.Left = 3.438F;
			this.LeaveFromdate4Text.Name = "LeaveFromdate4Text";
			this.LeaveFromdate4Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveFromdate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveFromdate4Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveFromdate4Text.Top = 9.576F;
			this.LeaveFromdate4Text.Width = 0.625F;
			// 
			// LeaveTodate4Text
			// 
			this.LeaveTodate4Text.CanGrow = false;
			this.LeaveTodate4Text.DataField = "LEAVE_TODATE_4";
			this.LeaveTodate4Text.Height = 0.168F;
			this.LeaveTodate4Text.Left = 4.063F;
			this.LeaveTodate4Text.Name = "LeaveTodate4Text";
			this.LeaveTodate4Text.OutputFormat = "yyyy/MM/dd";
			this.LeaveTodate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveTodate4Text.Text = "ZZZ6/Z6/Z6";
			this.LeaveTodate4Text.Top = 9.576F;
			this.LeaveTodate4Text.Width = 0.625F;
			// 
			// WordExpRemarks2Text
			// 
			this.WordExpRemarks2Text.CanGrow = false;
			this.WordExpRemarks2Text.DataField = "WORK_EXP_REMARKS_3";
			this.WordExpRemarks2Text.Height = 0.343F;
			this.WordExpRemarks2Text.Left = 1.625F;
			this.WordExpRemarks2Text.Name = "WordExpRemarks2Text";
			this.WordExpRemarks2Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks2Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks2Text.Top = 7.056F;
			this.WordExpRemarks2Text.Width = 1.788F;
			// 
			// WordExpRemarks3Text
			// 
			this.WordExpRemarks3Text.CanGrow = false;
			this.WordExpRemarks3Text.DataField = "WORK_EXP_REMARKS_5";
			this.WordExpRemarks3Text.Height = 0.343F;
			this.WordExpRemarks3Text.Left = 1.625F;
			this.WordExpRemarks3Text.Name = "WordExpRemarks3Text";
			this.WordExpRemarks3Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks3Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks3Text.Top = 7.392F;
			this.WordExpRemarks3Text.Width = 1.788F;
			// 
			// WordExpRemarks4Text
			// 
			this.WordExpRemarks4Text.CanGrow = false;
			this.WordExpRemarks4Text.DataField = "WORK_EXP_REMARKS_7";
			this.WordExpRemarks4Text.Height = 0.3344998F;
			this.WordExpRemarks4Text.Left = 1.625F;
			this.WordExpRemarks4Text.Name = "WordExpRemarks4Text";
			this.WordExpRemarks4Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks4Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks4Text.Top = 7.728F;
			this.WordExpRemarks4Text.Width = 1.788F;
			// 
			// WordExpRemarks5Text
			// 
			this.WordExpRemarks5Text.CanGrow = false;
			this.WordExpRemarks5Text.DataField = "WORK_EXP_REMARKS_9";
			this.WordExpRemarks5Text.Height = 0.343F;
			this.WordExpRemarks5Text.Left = 1.625F;
			this.WordExpRemarks5Text.Name = "WordExpRemarks5Text";
			this.WordExpRemarks5Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks5Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks5Text.Top = 8.064F;
			this.WordExpRemarks5Text.Width = 1.788F;
			// 
			// WordExpRemarks6Text
			// 
			this.WordExpRemarks6Text.CanGrow = false;
			this.WordExpRemarks6Text.DataField = "WORK_EXP_REMARKS_11";
			this.WordExpRemarks6Text.Height = 0.3500004F;
			this.WordExpRemarks6Text.Left = 1.625F;
			this.WordExpRemarks6Text.Name = "WordExpRemarks6Text";
			this.WordExpRemarks6Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks6Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks6Text.Top = 8.4F;
			this.WordExpRemarks6Text.Width = 1.788F;
			// 
			// WordExpRemarks7Text
			// 
			this.WordExpRemarks7Text.CanGrow = false;
			this.WordExpRemarks7Text.DataField = "WORK_EXP_REMARKS_13";
			this.WordExpRemarks7Text.Height = 0.343F;
			this.WordExpRemarks7Text.Left = 1.625F;
			this.WordExpRemarks7Text.Name = "WordExpRemarks7Text";
			this.WordExpRemarks7Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks7Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks7Text.Top = 8.736F;
			this.WordExpRemarks7Text.Width = 1.788F;
			// 
			// WordExpRemarks8Text
			// 
			this.WordExpRemarks8Text.CanGrow = false;
			this.WordExpRemarks8Text.DataField = "WORK_EXP_REMARKS_15";
			this.WordExpRemarks8Text.Height = 0.343F;
			this.WordExpRemarks8Text.Left = 1.625F;
			this.WordExpRemarks8Text.Name = "WordExpRemarks8Text";
			this.WordExpRemarks8Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks8Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks8Text.Top = 9.0625F;
			this.WordExpRemarks8Text.Width = 1.788F;
			// 
			// WordExpRemarks9Text
			// 
			this.WordExpRemarks9Text.CanGrow = false;
			this.WordExpRemarks9Text.DataField = "WORK_EXP_REMARKS_17";
			this.WordExpRemarks9Text.Height = 0.342F;
			this.WordExpRemarks9Text.Left = 1.625F;
			this.WordExpRemarks9Text.Name = "WordExpRemarks9Text";
			this.WordExpRemarks9Text.Style = "font-size: 7pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.WordExpRemarks9Text.Text = "ああああああああああああああああああああああああああああああああああああ";
			this.WordExpRemarks9Text.Top = 9.408F;
			this.WordExpRemarks9Text.Width = 1.788F;
			// 
			// LeaveReason2Text
			// 
			this.LeaveReason2Text.CanGrow = false;
			this.LeaveReason2Text.DataField = "LEAVE_REASON_2";
			this.LeaveReason2Text.Height = 0.168F;
			this.LeaveReason2Text.Left = 4.663F;
			this.LeaveReason2Text.Name = "LeaveReason2Text";
			this.LeaveReason2Text.OutputFormat = "#,##0";
			this.LeaveReason2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveReason2Text.Text = "ああああああああああああああああああああ";
			this.LeaveReason2Text.Top = 9.24F;
			this.LeaveReason2Text.Width = 2.437F;
			// 
			// LeaveReason3Text
			// 
			this.LeaveReason3Text.CanGrow = false;
			this.LeaveReason3Text.DataField = "LEAVE_REASON_3";
			this.LeaveReason3Text.Height = 0.168F;
			this.LeaveReason3Text.Left = 4.663F;
			this.LeaveReason3Text.Name = "LeaveReason3Text";
			this.LeaveReason3Text.OutputFormat = "#,##0";
			this.LeaveReason3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveReason3Text.Text = "ああああああああああああああああああああ";
			this.LeaveReason3Text.Top = 9.408F;
			this.LeaveReason3Text.Width = 2.437F;
			// 
			// LeaveReason4Text
			// 
			this.LeaveReason4Text.CanGrow = false;
			this.LeaveReason4Text.DataField = "LEAVE_REASON_4";
			this.LeaveReason4Text.Height = 0.168F;
			this.LeaveReason4Text.Left = 4.663F;
			this.LeaveReason4Text.Name = "LeaveReason4Text";
			this.LeaveReason4Text.OutputFormat = "#,##0";
			this.LeaveReason4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveReason4Text.Text = "ああああああああああああああああああああ";
			this.LeaveReason4Text.Top = 9.576F;
			this.LeaveReason4Text.Width = 2.437F;
			// 
			// EndType1Text
			// 
			this.EndType1Text.CanGrow = false;
			this.EndType1Text.DataField = "END_TYPE_1";
			this.EndType1Text.Height = 0.168F;
			this.EndType1Text.Left = 5.663F;
			this.EndType1Text.Name = "EndType1Text";
			this.EndType1Text.OutputFormat = "#,##0";
			this.EndType1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType1Text.Text = "ああああああああああ";
			this.EndType1Text.Top = 5.543999F;
			this.EndType1Text.Width = 1.437F;
			// 
			// Label164
			// 
			this.Label164.Height = 0.168F;
			this.Label164.HyperLink = null;
			this.Label164.Left = 5.663F;
			this.Label164.Name = "Label164";
			this.Label164.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label164.Text = "終了状況";
			this.Label164.Top = 5.376F;
			this.Label164.Width = 1.437F;
			// 
			// EndType2Text
			// 
			this.EndType2Text.CanGrow = false;
			this.EndType2Text.DataField = "END_TYPE_2";
			this.EndType2Text.Height = 0.168F;
			this.EndType2Text.Left = 5.663F;
			this.EndType2Text.Name = "EndType2Text";
			this.EndType2Text.OutputFormat = "#,##0";
			this.EndType2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType2Text.Text = "ああああああああああ";
			this.EndType2Text.Top = 5.712F;
			this.EndType2Text.Width = 1.437F;
			// 
			// EndType3Text
			// 
			this.EndType3Text.CanGrow = false;
			this.EndType3Text.DataField = "END_TYPE_3";
			this.EndType3Text.Height = 0.168F;
			this.EndType3Text.Left = 5.663F;
			this.EndType3Text.Name = "EndType3Text";
			this.EndType3Text.OutputFormat = "#,##0";
			this.EndType3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType3Text.Text = "ああああああああああ";
			this.EndType3Text.Top = 5.88F;
			this.EndType3Text.Width = 1.437F;
			// 
			// EndType4Text
			// 
			this.EndType4Text.CanGrow = false;
			this.EndType4Text.DataField = "END_TYPE_4";
			this.EndType4Text.Height = 0.168F;
			this.EndType4Text.Left = 5.663F;
			this.EndType4Text.Name = "EndType4Text";
			this.EndType4Text.OutputFormat = "#,##0";
			this.EndType4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType4Text.Text = "ああああああああああ";
			this.EndType4Text.Top = 6.048F;
			this.EndType4Text.Width = 1.437F;
			// 
			// EndType5Text
			// 
			this.EndType5Text.CanGrow = false;
			this.EndType5Text.DataField = "END_TYPE_5";
			this.EndType5Text.Height = 0.168F;
			this.EndType5Text.Left = 5.663F;
			this.EndType5Text.Name = "EndType5Text";
			this.EndType5Text.OutputFormat = "#,##0";
			this.EndType5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType5Text.Text = "ああああああああああ";
			this.EndType5Text.Top = 6.216F;
			this.EndType5Text.Width = 1.437F;
			// 
			// EndType6Text
			// 
			this.EndType6Text.CanGrow = false;
			this.EndType6Text.DataField = "END_TYPE_6";
			this.EndType6Text.Height = 0.168F;
			this.EndType6Text.Left = 5.663F;
			this.EndType6Text.Name = "EndType6Text";
			this.EndType6Text.OutputFormat = "#,##0";
			this.EndType6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EndType6Text.Text = "ああああああああああ";
			this.EndType6Text.Top = 6.384F;
			this.EndType6Text.Width = 1.437F;
			// 
			// Label165
			// 
			this.Label165.Height = 0.168F;
			this.Label165.HyperLink = null;
			this.Label165.Left = 4.038F;
			this.Label165.Name = "Label165";
			this.Label165.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label165.Text = "公的資格名";
			this.Label165.Top = 6.72F;
			this.Label165.Width = 1.625F;
			// 
			// QualfName1Text
			// 
			this.QualfName1Text.CanGrow = false;
			this.QualfName1Text.DataField = "QUALF_NAME_1";
			this.QualfName1Text.Height = 0.168F;
			this.QualfName1Text.Left = 4.038F;
			this.QualfName1Text.Name = "QualfName1Text";
			this.QualfName1Text.OutputFormat = "#,##0";
			this.QualfName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfName1Text.Text = "ああああああああああ";
			this.QualfName1Text.Top = 6.888F;
			this.QualfName1Text.Width = 1.625F;
			// 
			// ObtainType1Text
			// 
			this.ObtainType1Text.CanGrow = false;
			this.ObtainType1Text.DataField = "QUALIFI_TYPE_1";
			this.ObtainType1Text.Height = 0.168F;
			this.ObtainType1Text.Left = 5.663F;
			this.ObtainType1Text.Name = "ObtainType1Text";
			this.ObtainType1Text.OutputFormat = "#,##0";
			this.ObtainType1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ObtainType1Text.Text = "ああああああああああ";
			this.ObtainType1Text.Top = 6.888F;
			this.ObtainType1Text.Width = 1.437F;
			// 
			// Label166
			// 
			this.Label166.Height = 0.168F;
			this.Label166.HyperLink = null;
			this.Label166.Left = 5.663F;
			this.Label166.Name = "Label166";
			this.Label166.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label166.Text = "取得状況";
			this.Label166.Top = 6.72F;
			this.Label166.Width = 1.437F;
			// 
			// QualfName2Text
			// 
			this.QualfName2Text.CanGrow = false;
			this.QualfName2Text.DataField = "QUALF_NAME_2";
			this.QualfName2Text.Height = 0.168F;
			this.QualfName2Text.Left = 4.038F;
			this.QualfName2Text.Name = "QualfName2Text";
			this.QualfName2Text.OutputFormat = "#,##0";
			this.QualfName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfName2Text.Text = "ああああああああああ";
			this.QualfName2Text.Top = 7.056F;
			this.QualfName2Text.Width = 1.625F;
			// 
			// ObtainType2Text
			// 
			this.ObtainType2Text.CanGrow = false;
			this.ObtainType2Text.DataField = "QUALIFI_TYPE_2";
			this.ObtainType2Text.Height = 0.168F;
			this.ObtainType2Text.Left = 5.663F;
			this.ObtainType2Text.Name = "ObtainType2Text";
			this.ObtainType2Text.OutputFormat = "#,##0";
			this.ObtainType2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ObtainType2Text.Text = "ああああああああああ";
			this.ObtainType2Text.Top = 7.056F;
			this.ObtainType2Text.Width = 1.437F;
			// 
			// QualfName3Text
			// 
			this.QualfName3Text.CanGrow = false;
			this.QualfName3Text.DataField = "QUALF_NAME_3";
			this.QualfName3Text.Height = 0.168F;
			this.QualfName3Text.Left = 4.038F;
			this.QualfName3Text.Name = "QualfName3Text";
			this.QualfName3Text.OutputFormat = "#,##0";
			this.QualfName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfName3Text.Text = "ああああああああああ";
			this.QualfName3Text.Top = 7.224F;
			this.QualfName3Text.Width = 1.625F;
			// 
			// ObtainType3Text
			// 
			this.ObtainType3Text.CanGrow = false;
			this.ObtainType3Text.DataField = "QUALIFI_TYPE_3";
			this.ObtainType3Text.Height = 0.168F;
			this.ObtainType3Text.Left = 5.663F;
			this.ObtainType3Text.Name = "ObtainType3Text";
			this.ObtainType3Text.OutputFormat = "#,##0";
			this.ObtainType3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ObtainType3Text.Text = "ああああああああああ";
			this.ObtainType3Text.Top = 7.224F;
			this.ObtainType3Text.Width = 1.437F;
			// 
			// QualfName4Text
			// 
			this.QualfName4Text.CanGrow = false;
			this.QualfName4Text.DataField = "QUALF_NAME_4";
			this.QualfName4Text.Height = 0.168F;
			this.QualfName4Text.Left = 4.038F;
			this.QualfName4Text.Name = "QualfName4Text";
			this.QualfName4Text.OutputFormat = "#,##0";
			this.QualfName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfName4Text.Text = "ああああああああああ";
			this.QualfName4Text.Top = 7.392F;
			this.QualfName4Text.Width = 1.625F;
			// 
			// ObtainType4Text
			// 
			this.ObtainType4Text.CanGrow = false;
			this.ObtainType4Text.DataField = "QUALIFI_TYPE_4";
			this.ObtainType4Text.Height = 0.168F;
			this.ObtainType4Text.Left = 5.663F;
			this.ObtainType4Text.Name = "ObtainType4Text";
			this.ObtainType4Text.OutputFormat = "#,##0";
			this.ObtainType4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ObtainType4Text.Text = "ああああああああああ";
			this.ObtainType4Text.Top = 7.392F;
			this.ObtainType4Text.Width = 1.437F;
			// 
			// GraduYm1Text
			// 
			this.GraduYm1Text.CanGrow = false;
			this.GraduYm1Text.DataField = "GRADU_YM_1";
			this.GraduYm1Text.Height = 0.168F;
			this.GraduYm1Text.Left = 3.438F;
			this.GraduYm1Text.Name = "GraduYm1Text";
			this.GraduYm1Text.OutputFormat = "yyyy/MM";
			this.GraduYm1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm1Text.Text = "ZZZ6/Z6";
			this.GraduYm1Text.Top = 3.36F;
			this.GraduYm1Text.Width = 0.6244998F;
			// 
			// TextBox235
			// 
			this.TextBox235.CanGrow = false;
			this.TextBox235.DataField = "ENTRA_YM_2";
			this.TextBox235.Height = 0.168F;
			this.TextBox235.Left = 3.438F;
			this.TextBox235.Name = "TextBox235";
			this.TextBox235.OutputFormat = "yyyy/MM";
			this.TextBox235.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TextBox235.Text = "ZZZ6/Z6";
			this.TextBox235.Top = 3.528F;
			this.TextBox235.Width = 0.6244998F;
			// 
			// EntraYm3Text
			// 
			this.EntraYm3Text.CanGrow = false;
			this.EntraYm3Text.DataField = "ENTRA_YM_3";
			this.EntraYm3Text.Height = 0.168F;
			this.EntraYm3Text.Left = 3.438F;
			this.EntraYm3Text.Name = "EntraYm3Text";
			this.EntraYm3Text.OutputFormat = "yyyy/MM";
			this.EntraYm3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm3Text.Text = "ZZZ6/Z6";
			this.EntraYm3Text.Top = 3.864F;
			this.EntraYm3Text.Width = 0.6244998F;
			// 
			// AtacName1Text
			// 
			this.AtacName1Text.CanGrow = false;
			this.AtacName1Text.DataField = "ATAC_NAME_1";
			this.AtacName1Text.Height = 0.168F;
			this.AtacName1Text.Left = 1.5625F;
			this.AtacName1Text.Name = "AtacName1Text";
			this.AtacName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName1Text.Text = "あああああああああああああああ";
			this.AtacName1Text.Top = 1.848F;
			this.AtacName1Text.Width = 1.850499F;
			// 
			// ShfTypeName2Text
			// 
			this.ShfTypeName2Text.CanGrow = false;
			this.ShfTypeName2Text.DataField = "SHF_TYPE_NAME_2";
			this.ShfTypeName2Text.Height = 0.168F;
			this.ShfTypeName2Text.Left = 0.625F;
			this.ShfTypeName2Text.Name = "ShfTypeName2Text";
			this.ShfTypeName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName2Text.Text = "ああああああああ";
			this.ShfTypeName2Text.Top = 2.016F;
			this.ShfTypeName2Text.Width = 0.875F;
			// 
			// AtacName2Text
			// 
			this.AtacName2Text.CanGrow = false;
			this.AtacName2Text.DataField = "ATAC_NAME_2";
			this.AtacName2Text.Height = 0.168F;
			this.AtacName2Text.Left = 1.563F;
			this.AtacName2Text.Name = "AtacName2Text";
			this.AtacName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName2Text.Text = "あああああああああああああああ";
			this.AtacName2Text.Top = 2.016F;
			this.AtacName2Text.Width = 1.851F;
			// 
			// ShfTypeName3Text
			// 
			this.ShfTypeName3Text.CanGrow = false;
			this.ShfTypeName3Text.DataField = "SHF_TYPE_NAME_3";
			this.ShfTypeName3Text.Height = 0.168F;
			this.ShfTypeName3Text.Left = 0.625F;
			this.ShfTypeName3Text.Name = "ShfTypeName3Text";
			this.ShfTypeName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName3Text.Text = "ああああああああ";
			this.ShfTypeName3Text.Top = 2.184F;
			this.ShfTypeName3Text.Width = 0.875F;
			// 
			// AtacName3Text
			// 
			this.AtacName3Text.CanGrow = false;
			this.AtacName3Text.DataField = "ATAC_NAME_3";
			this.AtacName3Text.Height = 0.168F;
			this.AtacName3Text.Left = 1.563F;
			this.AtacName3Text.Name = "AtacName3Text";
			this.AtacName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName3Text.Text = "あああああああああああああああ";
			this.AtacName3Text.Top = 2.184F;
			this.AtacName3Text.Width = 1.851F;
			// 
			// ShfTypeName4Text
			// 
			this.ShfTypeName4Text.CanGrow = false;
			this.ShfTypeName4Text.DataField = "SHF_TYPE_NAME_4";
			this.ShfTypeName4Text.Height = 0.168F;
			this.ShfTypeName4Text.Left = 0.625F;
			this.ShfTypeName4Text.Name = "ShfTypeName4Text";
			this.ShfTypeName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName4Text.Text = "ああああああああ";
			this.ShfTypeName4Text.Top = 2.352F;
			this.ShfTypeName4Text.Width = 0.875F;
			// 
			// AtacName4Text
			// 
			this.AtacName4Text.CanGrow = false;
			this.AtacName4Text.DataField = "ATAC_NAME_4";
			this.AtacName4Text.Height = 0.168F;
			this.AtacName4Text.Left = 1.563F;
			this.AtacName4Text.Name = "AtacName4Text";
			this.AtacName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName4Text.Text = "あああああああああああああああ";
			this.AtacName4Text.Top = 2.352F;
			this.AtacName4Text.Width = 1.851F;
			// 
			// ShfTypeName5Text
			// 
			this.ShfTypeName5Text.CanGrow = false;
			this.ShfTypeName5Text.DataField = "SHF_TYPE_NAME_5";
			this.ShfTypeName5Text.Height = 0.168F;
			this.ShfTypeName5Text.Left = 0.625F;
			this.ShfTypeName5Text.Name = "ShfTypeName5Text";
			this.ShfTypeName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName5Text.Text = "ああああああああ";
			this.ShfTypeName5Text.Top = 2.52F;
			this.ShfTypeName5Text.Width = 0.875F;
			// 
			// AtacName5Text
			// 
			this.AtacName5Text.CanGrow = false;
			this.AtacName5Text.DataField = "ATAC_NAME_5";
			this.AtacName5Text.Height = 0.168F;
			this.AtacName5Text.Left = 1.563F;
			this.AtacName5Text.Name = "AtacName5Text";
			this.AtacName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName5Text.Text = "あああああああああああああああ";
			this.AtacName5Text.Top = 2.52F;
			this.AtacName5Text.Width = 1.851F;
			// 
			// ShfTypeName6Text
			// 
			this.ShfTypeName6Text.CanGrow = false;
			this.ShfTypeName6Text.DataField = "SHF_TYPE_NAME_6";
			this.ShfTypeName6Text.Height = 0.168F;
			this.ShfTypeName6Text.Left = 0.625F;
			this.ShfTypeName6Text.Name = "ShfTypeName6Text";
			this.ShfTypeName6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName6Text.Text = "ああああああああ";
			this.ShfTypeName6Text.Top = 2.6875F;
			this.ShfTypeName6Text.Width = 0.875F;
			// 
			// ShfTypeName7Text
			// 
			this.ShfTypeName7Text.CanGrow = false;
			this.ShfTypeName7Text.DataField = "SHF_TYPE_NAME_7";
			this.ShfTypeName7Text.Height = 0.168F;
			this.ShfTypeName7Text.Left = 0.625F;
			this.ShfTypeName7Text.Name = "ShfTypeName7Text";
			this.ShfTypeName7Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName7Text.Text = "ああああああああ";
			this.ShfTypeName7Text.Top = 2.856F;
			this.ShfTypeName7Text.Width = 0.875F;
			// 
			// ShfTypeName8Text
			// 
			this.ShfTypeName8Text.CanGrow = false;
			this.ShfTypeName8Text.DataField = "SHF_TYPE_NAME_8";
			this.ShfTypeName8Text.Height = 0.168F;
			this.ShfTypeName8Text.Left = 0.625F;
			this.ShfTypeName8Text.Name = "ShfTypeName8Text";
			this.ShfTypeName8Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName8Text.Text = "ああああああああ";
			this.ShfTypeName8Text.Top = 3.024F;
			this.ShfTypeName8Text.Width = 0.875F;
			// 
			// ShfTypeName9Text
			// 
			this.ShfTypeName9Text.CanGrow = false;
			this.ShfTypeName9Text.DataField = "SHF_TYPE_NAME_9";
			this.ShfTypeName9Text.Height = 0.168F;
			this.ShfTypeName9Text.Left = 0.625F;
			this.ShfTypeName9Text.Name = "ShfTypeName9Text";
			this.ShfTypeName9Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName9Text.Text = "ああああああああ";
			this.ShfTypeName9Text.Top = 3.1875F;
			this.ShfTypeName9Text.Width = 0.875F;
			// 
			// ShfTypeName10Text
			// 
			this.ShfTypeName10Text.CanGrow = false;
			this.ShfTypeName10Text.DataField = "SHF_TYPE_NAME_10";
			this.ShfTypeName10Text.Height = 0.168F;
			this.ShfTypeName10Text.Left = 0.625F;
			this.ShfTypeName10Text.Name = "ShfTypeName10Text";
			this.ShfTypeName10Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName10Text.Text = "ああああああああ";
			this.ShfTypeName10Text.Top = 3.36F;
			this.ShfTypeName10Text.Width = 0.875F;
			// 
			// AtacName6Text
			// 
			this.AtacName6Text.CanGrow = false;
			this.AtacName6Text.DataField = "ATAC_NAME_6";
			this.AtacName6Text.Height = 0.168F;
			this.AtacName6Text.Left = 1.563F;
			this.AtacName6Text.Name = "AtacName6Text";
			this.AtacName6Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName6Text.Text = "あああああああああああああああ";
			this.AtacName6Text.Top = 2.688F;
			this.AtacName6Text.Width = 1.851F;
			// 
			// AtacName7Text
			// 
			this.AtacName7Text.CanGrow = false;
			this.AtacName7Text.DataField = "ATAC_NAME_7";
			this.AtacName7Text.Height = 0.168F;
			this.AtacName7Text.Left = 1.563F;
			this.AtacName7Text.Name = "AtacName7Text";
			this.AtacName7Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName7Text.Text = "あああああああああああああああ";
			this.AtacName7Text.Top = 2.856F;
			this.AtacName7Text.Width = 1.851F;
			// 
			// AtacName8Text
			// 
			this.AtacName8Text.CanGrow = false;
			this.AtacName8Text.DataField = "ATAC_NAME_8";
			this.AtacName8Text.Height = 0.168F;
			this.AtacName8Text.Left = 1.563F;
			this.AtacName8Text.Name = "AtacName8Text";
			this.AtacName8Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName8Text.Text = "あああああああああああああああ";
			this.AtacName8Text.Top = 3.024F;
			this.AtacName8Text.Width = 1.851F;
			// 
			// AtacName9Text
			// 
			this.AtacName9Text.CanGrow = false;
			this.AtacName9Text.DataField = "ATAC_NAME_9";
			this.AtacName9Text.Height = 0.168F;
			this.AtacName9Text.Left = 1.563F;
			this.AtacName9Text.Name = "AtacName9Text";
			this.AtacName9Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName9Text.Text = "あああああああああああああああ";
			this.AtacName9Text.Top = 3.192F;
			this.AtacName9Text.Width = 1.851F;
			// 
			// AtacName10Text
			// 
			this.AtacName10Text.CanGrow = false;
			this.AtacName10Text.DataField = "ATAC_NAME_10";
			this.AtacName10Text.Height = 0.168F;
			this.AtacName10Text.Left = 1.563F;
			this.AtacName10Text.Name = "AtacName10Text";
			this.AtacName10Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName10Text.Text = "あああああああああああああああ";
			this.AtacName10Text.Top = 3.36F;
			this.AtacName10Text.Width = 1.851F;
			// 
			// ShfTypeName11Text
			// 
			this.ShfTypeName11Text.CanGrow = false;
			this.ShfTypeName11Text.DataField = "SHF_TYPE_NAME_11";
			this.ShfTypeName11Text.Height = 0.168F;
			this.ShfTypeName11Text.Left = 0.625F;
			this.ShfTypeName11Text.Name = "ShfTypeName11Text";
			this.ShfTypeName11Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName11Text.Text = "ああああああああ";
			this.ShfTypeName11Text.Top = 3.528F;
			this.ShfTypeName11Text.Width = 0.875F;
			// 
			// ShfTypeName12Text
			// 
			this.ShfTypeName12Text.CanGrow = false;
			this.ShfTypeName12Text.DataField = "SHF_TYPE_NAME_12";
			this.ShfTypeName12Text.Height = 0.168F;
			this.ShfTypeName12Text.Left = 0.625F;
			this.ShfTypeName12Text.Name = "ShfTypeName12Text";
			this.ShfTypeName12Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName12Text.Text = "ああああああああ";
			this.ShfTypeName12Text.Top = 3.696F;
			this.ShfTypeName12Text.Width = 0.875F;
			// 
			// ShfTypeName13Text
			// 
			this.ShfTypeName13Text.CanGrow = false;
			this.ShfTypeName13Text.DataField = "SHF_TYPE_NAME_13";
			this.ShfTypeName13Text.Height = 0.168F;
			this.ShfTypeName13Text.Left = 0.625F;
			this.ShfTypeName13Text.Name = "ShfTypeName13Text";
			this.ShfTypeName13Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName13Text.Text = "ああああああああ";
			this.ShfTypeName13Text.Top = 3.864F;
			this.ShfTypeName13Text.Width = 0.875F;
			// 
			// ShfTypeName14Text
			// 
			this.ShfTypeName14Text.CanGrow = false;
			this.ShfTypeName14Text.DataField = "SHF_TYPE_NAME_14";
			this.ShfTypeName14Text.Height = 0.168F;
			this.ShfTypeName14Text.Left = 0.625F;
			this.ShfTypeName14Text.Name = "ShfTypeName14Text";
			this.ShfTypeName14Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName14Text.Text = "ああああああああ";
			this.ShfTypeName14Text.Top = 4.032F;
			this.ShfTypeName14Text.Width = 0.875F;
			// 
			// ShfTypeName15Text
			// 
			this.ShfTypeName15Text.CanGrow = false;
			this.ShfTypeName15Text.DataField = "SHF_TYPE_NAME_15";
			this.ShfTypeName15Text.Height = 0.168F;
			this.ShfTypeName15Text.Left = 0.625F;
			this.ShfTypeName15Text.Name = "ShfTypeName15Text";
			this.ShfTypeName15Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName15Text.Text = "ああああああああ";
			this.ShfTypeName15Text.Top = 4.2F;
			this.ShfTypeName15Text.Width = 0.875F;
			// 
			// AtacName11Text
			// 
			this.AtacName11Text.CanGrow = false;
			this.AtacName11Text.DataField = "ATAC_NAME_11";
			this.AtacName11Text.Height = 0.168F;
			this.AtacName11Text.Left = 1.563F;
			this.AtacName11Text.Name = "AtacName11Text";
			this.AtacName11Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName11Text.Text = "あああああああああああああああ";
			this.AtacName11Text.Top = 3.528F;
			this.AtacName11Text.Width = 1.851F;
			// 
			// AtacName12Text
			// 
			this.AtacName12Text.CanGrow = false;
			this.AtacName12Text.DataField = "ATAC_NAME_12";
			this.AtacName12Text.Height = 0.168F;
			this.AtacName12Text.Left = 1.563F;
			this.AtacName12Text.Name = "AtacName12Text";
			this.AtacName12Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName12Text.Text = "あああああああああああああああ";
			this.AtacName12Text.Top = 3.696F;
			this.AtacName12Text.Width = 1.851F;
			// 
			// AtacName13Text
			// 
			this.AtacName13Text.CanGrow = false;
			this.AtacName13Text.DataField = "ATAC_NAME_13";
			this.AtacName13Text.Height = 0.168F;
			this.AtacName13Text.Left = 1.563F;
			this.AtacName13Text.Name = "AtacName13Text";
			this.AtacName13Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName13Text.Text = "あああああああああああああああ";
			this.AtacName13Text.Top = 3.864F;
			this.AtacName13Text.Width = 1.851F;
			// 
			// AtacName14Text
			// 
			this.AtacName14Text.CanGrow = false;
			this.AtacName14Text.DataField = "ATAC_NAME_14";
			this.AtacName14Text.Height = 0.168F;
			this.AtacName14Text.Left = 1.563F;
			this.AtacName14Text.Name = "AtacName14Text";
			this.AtacName14Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName14Text.Text = "あああああああああああああああ";
			this.AtacName14Text.Top = 4.032F;
			this.AtacName14Text.Width = 1.851F;
			// 
			// AtacName15Text
			// 
			this.AtacName15Text.CanGrow = false;
			this.AtacName15Text.DataField = "ATAC_NAME_15";
			this.AtacName15Text.Height = 0.168F;
			this.AtacName15Text.Left = 1.563F;
			this.AtacName15Text.Name = "AtacName15Text";
			this.AtacName15Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName15Text.Text = "あああああああああああああああ";
			this.AtacName15Text.Top = 4.2F;
			this.AtacName15Text.Width = 1.851F;
			// 
			// AtacName18Text
			// 
			this.AtacName18Text.CanGrow = false;
			this.AtacName18Text.DataField = "ATAC_NAME_18";
			this.AtacName18Text.Height = 0.168F;
			this.AtacName18Text.Left = 1.563F;
			this.AtacName18Text.Name = "AtacName18Text";
			this.AtacName18Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName18Text.Text = "あああああああああああああああ";
			this.AtacName18Text.Top = 4.704F;
			this.AtacName18Text.Width = 1.851F;
			// 
			// AtacName19Text
			// 
			this.AtacName19Text.CanGrow = false;
			this.AtacName19Text.DataField = "ATAC_NAME_19";
			this.AtacName19Text.Height = 0.168F;
			this.AtacName19Text.Left = 1.563F;
			this.AtacName19Text.Name = "AtacName19Text";
			this.AtacName19Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName19Text.Text = "あああああああああああああああ";
			this.AtacName19Text.Top = 4.872F;
			this.AtacName19Text.Width = 1.851F;
			// 
			// AtacName20Text
			// 
			this.AtacName20Text.CanGrow = false;
			this.AtacName20Text.DataField = "ATAC_NAME_20";
			this.AtacName20Text.Height = 0.168F;
			this.AtacName20Text.Left = 1.563F;
			this.AtacName20Text.Name = "AtacName20Text";
			this.AtacName20Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacName20Text.Text = "あああああああああああああああ";
			this.AtacName20Text.Top = 5.04F;
			this.AtacName20Text.Width = 1.851F;
			// 
			// ProjShortName1Text
			// 
			this.ProjShortName1Text.CanGrow = false;
			this.ProjShortName1Text.DataField = "PROJ_SHORT_NAME_1";
			this.ProjShortName1Text.Height = 0.168F;
			this.ProjShortName1Text.Left = 1.188F;
			this.ProjShortName1Text.Name = "ProjShortName1Text";
			this.ProjShortName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName1Text.Text = "あああああああああああああああ";
			this.ProjShortName1Text.Top = 5.543999F;
			this.ProjShortName1Text.Width = 2.226F;
			// 
			// ProjShortName2Text
			// 
			this.ProjShortName2Text.CanGrow = false;
			this.ProjShortName2Text.DataField = "PROJ_SHORT_NAME_2";
			this.ProjShortName2Text.Height = 0.168F;
			this.ProjShortName2Text.Left = 1.188F;
			this.ProjShortName2Text.Name = "ProjShortName2Text";
			this.ProjShortName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName2Text.Text = "あああああああああああああああ";
			this.ProjShortName2Text.Top = 5.712F;
			this.ProjShortName2Text.Width = 2.226F;
			// 
			// ProjShortName3Text
			// 
			this.ProjShortName3Text.CanGrow = false;
			this.ProjShortName3Text.DataField = "PROJ_SHORT_NAME_3";
			this.ProjShortName3Text.Height = 0.168F;
			this.ProjShortName3Text.Left = 1.188F;
			this.ProjShortName3Text.Name = "ProjShortName3Text";
			this.ProjShortName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName3Text.Text = "あああああああああああああああ";
			this.ProjShortName3Text.Top = 5.88F;
			this.ProjShortName3Text.Width = 2.226F;
			// 
			// ProjShortName4Text
			// 
			this.ProjShortName4Text.CanGrow = false;
			this.ProjShortName4Text.DataField = "PROJ_SHORT_NAME_4";
			this.ProjShortName4Text.Height = 0.168F;
			this.ProjShortName4Text.Left = 1.188F;
			this.ProjShortName4Text.Name = "ProjShortName4Text";
			this.ProjShortName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName4Text.Text = "あああああああああああああああ";
			this.ProjShortName4Text.Top = 6.048F;
			this.ProjShortName4Text.Width = 2.226F;
			// 
			// ProjShortName5Text
			// 
			this.ProjShortName5Text.CanGrow = false;
			this.ProjShortName5Text.DataField = "PROJ_SHORT_NAME_5";
			this.ProjShortName5Text.Height = 0.168F;
			this.ProjShortName5Text.Left = 1.188F;
			this.ProjShortName5Text.Name = "ProjShortName5Text";
			this.ProjShortName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName5Text.Text = "あああああああああああああああ";
			this.ProjShortName5Text.Top = 6.216F;
			this.ProjShortName5Text.Width = 2.226F;
			// 
			// SchoolName2Text
			// 
			this.SchoolName2Text.CanGrow = false;
			this.SchoolName2Text.DataField = "SCHOOL_NAME_2";
			this.SchoolName2Text.Height = 0.168F;
			this.SchoolName2Text.Left = 4.1F;
			this.SchoolName2Text.Name = "SchoolName2Text";
			this.SchoolName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName2Text.Text = "ああああああああああ";
			this.SchoolName2Text.Top = 3.528F;
			this.SchoolName2Text.Width = 3F;
			// 
			// SchoolName3Text
			// 
			this.SchoolName3Text.CanGrow = false;
			this.SchoolName3Text.DataField = "SCHOOL_NAME_3";
			this.SchoolName3Text.Height = 0.168F;
			this.SchoolName3Text.Left = 4.1F;
			this.SchoolName3Text.Name = "SchoolName3Text";
			this.SchoolName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName3Text.Text = "ああああああああああ";
			this.SchoolName3Text.Top = 3.864F;
			this.SchoolName3Text.Width = 3F;
			// 
			// GraduYm2Text
			// 
			this.GraduYm2Text.CanGrow = false;
			this.GraduYm2Text.DataField = "GRADU_YM_2";
			this.GraduYm2Text.Height = 0.168F;
			this.GraduYm2Text.Left = 3.438F;
			this.GraduYm2Text.Name = "GraduYm2Text";
			this.GraduYm2Text.OutputFormat = "yyyy/MM";
			this.GraduYm2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm2Text.Text = "ZZZ6/Z6";
			this.GraduYm2Text.Top = 3.696F;
			this.GraduYm2Text.Width = 0.6244998F;
			// 
			// ClsName2Text
			// 
			this.ClsName2Text.CanGrow = false;
			this.ClsName2Text.DataField = "CLS_NAME_2";
			this.ClsName2Text.Height = 0.168F;
			this.ClsName2Text.Left = 4.1F;
			this.ClsName2Text.Name = "ClsName2Text";
			this.ClsName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName2Text.Text = "ああああああああああ";
			this.ClsName2Text.Top = 3.696F;
			this.ClsName2Text.Width = 1F;
			// 
			// DayNightType2Text
			// 
			this.DayNightType2Text.CanGrow = false;
			this.DayNightType2Text.DataField = "DAY_NAIGHT2";
			this.DayNightType2Text.Height = 0.168F;
			this.DayNightType2Text.Left = 5.1F;
			this.DayNightType2Text.Name = "DayNightType2Text";
			this.DayNightType2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DayNightType2Text.Text = "ああ";
			this.DayNightType2Text.Top = 3.696F;
			this.DayNightType2Text.Width = 0.813F;
			// 
			// GraduYm3Text
			// 
			this.GraduYm3Text.CanGrow = false;
			this.GraduYm3Text.DataField = "GRADU_YM_3";
			this.GraduYm3Text.Height = 0.168F;
			this.GraduYm3Text.Left = 3.438F;
			this.GraduYm3Text.Name = "GraduYm3Text";
			this.GraduYm3Text.OutputFormat = "yyyy/MM";
			this.GraduYm3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm3Text.Text = "ZZZ6/Z6";
			this.GraduYm3Text.Top = 4.032F;
			this.GraduYm3Text.Width = 0.6244998F;
			// 
			// ClsName3Text
			// 
			this.ClsName3Text.CanGrow = false;
			this.ClsName3Text.DataField = "CLS_NAME_3";
			this.ClsName3Text.Height = 0.168F;
			this.ClsName3Text.Left = 4.1F;
			this.ClsName3Text.Name = "ClsName3Text";
			this.ClsName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName3Text.Text = "ああああああああああ";
			this.ClsName3Text.Top = 4.032F;
			this.ClsName3Text.Width = 1F;
			// 
			// DayNightType3Text
			// 
			this.DayNightType3Text.CanGrow = false;
			this.DayNightType3Text.DataField = "DAY_NAIGHT3";
			this.DayNightType3Text.Height = 0.168F;
			this.DayNightType3Text.Left = 5.1F;
			this.DayNightType3Text.Name = "DayNightType3Text";
			this.DayNightType3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DayNightType3Text.Text = "ああ";
			this.DayNightType3Text.Top = 4.032F;
			this.DayNightType3Text.Width = 0.813F;
			// 
			// ConcurTodate2Text
			// 
			this.ConcurTodate2Text.CanGrow = false;
			this.ConcurTodate2Text.DataField = "CONCUR_TODATE_2";
			this.ConcurTodate2Text.Height = 0.168F;
			this.ConcurTodate2Text.Left = 4.063F;
			this.ConcurTodate2Text.Name = "ConcurTodate2Text";
			this.ConcurTodate2Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurTodate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurTodate2Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurTodate2Text.Top = 4.704F;
			this.ConcurTodate2Text.Width = 0.625F;
			// 
			// ConcurTodate1Text
			// 
			this.ConcurTodate1Text.CanGrow = false;
			this.ConcurTodate1Text.DataField = "CONCUR_TODATE_1";
			this.ConcurTodate1Text.Height = 0.168F;
			this.ConcurTodate1Text.Left = 4.063F;
			this.ConcurTodate1Text.Name = "ConcurTodate1Text";
			this.ConcurTodate1Text.OutputFormat = "yyyy/MM/dd";
			this.ConcurTodate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurTodate1Text.Text = "ZZZ6/Z6/Z6";
			this.ConcurTodate1Text.Top = 4.536F;
			this.ConcurTodate1Text.Width = 0.625F;
			// 
			// QualfName5Text
			// 
			this.QualfName5Text.CanGrow = false;
			this.QualfName5Text.DataField = "QUALF_NAME_5";
			this.QualfName5Text.Height = 0.168F;
			this.QualfName5Text.Left = 4.038F;
			this.QualfName5Text.Name = "QualfName5Text";
			this.QualfName5Text.OutputFormat = "#,##0";
			this.QualfName5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfName5Text.Text = "ああああああああああ";
			this.QualfName5Text.Top = 7.56F;
			this.QualfName5Text.Width = 1.625F;
			// 
			// ObtainType5Text
			// 
			this.ObtainType5Text.CanGrow = false;
			this.ObtainType5Text.DataField = "QUALIFI_TYPE_5";
			this.ObtainType5Text.Height = 0.168F;
			this.ObtainType5Text.Left = 5.663F;
			this.ObtainType5Text.Name = "ObtainType5Text";
			this.ObtainType5Text.OutputFormat = "#,##0";
			this.ObtainType5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ObtainType5Text.Text = "ああああああああああ";
			this.ObtainType5Text.Top = 7.56F;
			this.ObtainType5Text.Width = 1.437F;
			// 
			// Line146
			// 
			this.Line146.Height = 7.25F;
			this.Line146.Left = 7.1F;
			this.Line146.LineWeight = 1F;
			this.Line146.Name = "Line146";
			this.Line146.Top = 0F;
			this.Line146.Width = 0F;
			this.Line146.X1 = 7.1F;
			this.Line146.X2 = 7.1F;
			this.Line146.Y1 = 0F;
			this.Line146.Y2 = 7.25F;
			// 
			// Line147
			// 
			this.Line147.Height = 0F;
			this.Line147.Left = 0.063F;
			this.Line147.LineWeight = 1F;
			this.Line147.Name = "Line147";
			this.Line147.Top = 0F;
			this.Line147.Width = 7.037F;
			this.Line147.X1 = 0.063F;
			this.Line147.X2 = 7.1F;
			this.Line147.Y1 = 0F;
			this.Line147.Y2 = 0F;
			// 
			// Line148
			// 
			this.Line148.Height = 0F;
			this.Line148.Left = 0.063F;
			this.Line148.LineWeight = 1F;
			this.Line148.Name = "Line148";
			this.Line148.Top = 0.28F;
			this.Line148.Width = 7.037F;
			this.Line148.X1 = 0.063F;
			this.Line148.X2 = 7.1F;
			this.Line148.Y1 = 0.28F;
			this.Line148.Y2 = 0.28F;
			// 
			// Line149
			// 
			this.Line149.Height = 0F;
			this.Line149.Left = 0.063F;
			this.Line149.LineWeight = 1F;
			this.Line149.Name = "Line149";
			this.Line149.Top = 1.008F;
			this.Line149.Width = 7.037F;
			this.Line149.X1 = 0.063F;
			this.Line149.X2 = 7.1F;
			this.Line149.Y1 = 1.008F;
			this.Line149.Y2 = 1.008F;
			// 
			// Line150
			// 
			this.Line150.Height = 0.28F;
			this.Line150.Left = 2.375F;
			this.Line150.LineWeight = 1F;
			this.Line150.Name = "Line150";
			this.Line150.Top = 0F;
			this.Line150.Width = 0F;
			this.Line150.X1 = 2.375F;
			this.Line150.X2 = 2.375F;
			this.Line150.Y1 = 0F;
			this.Line150.Y2 = 0.28F;
			// 
			// Line151
			// 
			this.Line151.Height = 0.28F;
			this.Line151.Left = 3.188F;
			this.Line151.LineWeight = 1F;
			this.Line151.Name = "Line151";
			this.Line151.Top = 0F;
			this.Line151.Width = 0F;
			this.Line151.X1 = 3.188F;
			this.Line151.X2 = 3.188F;
			this.Line151.Y1 = 0F;
			this.Line151.Y2 = 0.28F;
			// 
			// Line152
			// 
			this.Line152.Height = 0.28F;
			this.Line152.Left = 4.562F;
			this.Line152.LineWeight = 1F;
			this.Line152.Name = "Line152";
			this.Line152.Top = 0F;
			this.Line152.Width = 0F;
			this.Line152.X1 = 4.562F;
			this.Line152.X2 = 4.562F;
			this.Line152.Y1 = 0F;
			this.Line152.Y2 = 0.28F;
			// 
			// Line153
			// 
			this.Line153.Height = 0.28F;
			this.Line153.Left = 6.023622F;
			this.Line153.LineWeight = 1F;
			this.Line153.Name = "Line153";
			this.Line153.Top = 0F;
			this.Line153.Width = 0F;
			this.Line153.X1 = 6.023622F;
			this.Line153.X2 = 6.023622F;
			this.Line153.Y1 = 0F;
			this.Line153.Y2 = 0.28F;
			// 
			// Line154
			// 
			this.Line154.Height = 0.28F;
			this.Line154.Left = 6.271654F;
			this.Line154.LineWeight = 1F;
			this.Line154.Name = "Line154";
			this.Line154.Top = 0F;
			this.Line154.Width = 0F;
			this.Line154.X1 = 6.271654F;
			this.Line154.X2 = 6.271654F;
			this.Line154.Y1 = 0F;
			this.Line154.Y2 = 0.28F;
			// 
			// Line155
			// 
			this.Line155.Height = 0F;
			this.Line155.Left = 2.125F;
			this.Line155.LineWeight = 1F;
			this.Line155.Name = "Line155";
			this.Line155.Top = 0.479F;
			this.Line155.Width = 4.975F;
			this.Line155.X1 = 2.125F;
			this.Line155.X2 = 7.1F;
			this.Line155.Y1 = 0.479F;
			this.Line155.Y2 = 0.479F;
			// 
			// Line156
			// 
			this.Line156.Height = 0F;
			this.Line156.Left = 0.063F;
			this.Line156.LineWeight = 1F;
			this.Line156.Name = "Line156";
			this.Line156.Top = 0.672F;
			this.Line156.Width = 7.037F;
			this.Line156.X1 = 0.063F;
			this.Line156.X2 = 7.1F;
			this.Line156.Y1 = 0.672F;
			this.Line156.Y2 = 0.672F;
			// 
			// Line157
			// 
			this.Line157.Height = 0.728F;
			this.Line157.Left = 5.5F;
			this.Line157.LineWeight = 1F;
			this.Line157.Name = "Line157";
			this.Line157.Top = 0.28F;
			this.Line157.Width = 0F;
			this.Line157.X1 = 5.5F;
			this.Line157.X2 = 5.5F;
			this.Line157.Y1 = 0.28F;
			this.Line157.Y2 = 1.008F;
			// 
			// Line158
			// 
			this.Line158.Height = 0F;
			this.Line158.Left = 0.063F;
			this.Line158.LineWeight = 1F;
			this.Line158.Name = "Line158";
			this.Line158.Top = 1.512F;
			this.Line158.Width = 7.037F;
			this.Line158.X1 = 0.063F;
			this.Line158.X2 = 7.1F;
			this.Line158.Y1 = 1.512F;
			this.Line158.Y2 = 1.512F;
			// 
			// Line159
			// 
			this.Line159.Height = 0F;
			this.Line159.Left = 0.625F;
			this.Line159.LineWeight = 1F;
			this.Line159.Name = "Line159";
			this.Line159.Top = 1.344F;
			this.Line159.Width = 3.687F;
			this.Line159.X1 = 0.625F;
			this.Line159.X2 = 4.312F;
			this.Line159.Y1 = 1.344F;
			this.Line159.Y2 = 1.344F;
			// 
			// Line160
			// 
			this.Line160.Height = 0.336F;
			this.Line160.Left = 3.938F;
			this.Line160.LineWeight = 1F;
			this.Line160.Name = "Line160";
			this.Line160.Top = 0.672F;
			this.Line160.Width = 0F;
			this.Line160.X1 = 3.938F;
			this.Line160.X2 = 3.938F;
			this.Line160.Y1 = 0.672F;
			this.Line160.Y2 = 1.008F;
			// 
			// Line161
			// 
			this.Line161.Height = 0F;
			this.Line161.Left = 0.063F;
			this.Line161.LineWeight = 1F;
			this.Line161.Name = "Line161";
			this.Line161.Top = 2.688F;
			this.Line161.Width = 7.037F;
			this.Line161.X1 = 0.063F;
			this.Line161.X2 = 7.1F;
			this.Line161.Y1 = 2.688F;
			this.Line161.Y2 = 2.688F;
			// 
			// Line163
			// 
			this.Line163.Height = 0F;
			this.Line163.Left = 0.063F;
			this.Line163.LineWeight = 1F;
			this.Line163.Name = "Line163";
			this.Line163.Top = 1.68F;
			this.Line163.Width = 7.037F;
			this.Line163.X1 = 0.063F;
			this.Line163.X2 = 7.1F;
			this.Line163.Y1 = 1.68F;
			this.Line163.Y2 = 1.68F;
			// 
			// Line164
			// 
			this.Line164.Height = 0F;
			this.Line164.Left = 0.063F;
			this.Line164.LineWeight = 1F;
			this.Line164.Name = "Line164";
			this.Line164.Top = 1.848F;
			this.Line164.Width = 7.037F;
			this.Line164.X1 = 0.063F;
			this.Line164.X2 = 7.1F;
			this.Line164.Y1 = 1.848F;
			this.Line164.Y2 = 1.848F;
			// 
			// Line165
			// 
			this.Line165.Height = 0F;
			this.Line165.Left = 0.063F;
			this.Line165.LineWeight = 1F;
			this.Line165.Name = "Line165";
			this.Line165.Top = 2.184F;
			this.Line165.Width = 7.037F;
			this.Line165.X1 = 0.063F;
			this.Line165.X2 = 7.1F;
			this.Line165.Y1 = 2.184F;
			this.Line165.Y2 = 2.184F;
			// 
			// Line166
			// 
			this.Line166.Height = 0F;
			this.Line166.Left = 0.06944445F;
			this.Line166.LineWeight = 1F;
			this.Line166.Name = "Line166";
			this.Line166.Top = 2.352F;
			this.Line166.Width = 7.037F;
			this.Line166.X1 = 0.06944445F;
			this.Line166.X2 = 7.106445F;
			this.Line166.Y1 = 2.352F;
			this.Line166.Y2 = 2.352F;
			// 
			// Line167
			// 
			this.Line167.Height = 0F;
			this.Line167.Left = 0.063F;
			this.Line167.LineWeight = 1F;
			this.Line167.Name = "Line167";
			this.Line167.Top = 2.52F;
			this.Line167.Width = 7.037F;
			this.Line167.X1 = 0.063F;
			this.Line167.X2 = 7.1F;
			this.Line167.Y1 = 2.52F;
			this.Line167.Y2 = 2.52F;
			// 
			// Line168
			// 
			this.Line168.Height = 0F;
			this.Line168.Left = 0.063F;
			this.Line168.LineWeight = 1F;
			this.Line168.Name = "Line168";
			this.Line168.Top = 3.864F;
			this.Line168.Width = 7.037F;
			this.Line168.X1 = 0.063F;
			this.Line168.X2 = 7.1F;
			this.Line168.Y1 = 3.864F;
			this.Line168.Y2 = 3.864F;
			// 
			// Line169
			// 
			this.Line169.Height = 0F;
			this.Line169.Left = 0.063F;
			this.Line169.LineWeight = 1F;
			this.Line169.Name = "Line169";
			this.Line169.Top = 2.856F;
			this.Line169.Width = 7.037F;
			this.Line169.X1 = 0.063F;
			this.Line169.X2 = 7.1F;
			this.Line169.Y1 = 2.856F;
			this.Line169.Y2 = 2.856F;
			// 
			// Line170
			// 
			this.Line170.Height = 0F;
			this.Line170.Left = 0.063F;
			this.Line170.LineWeight = 1F;
			this.Line170.Name = "Line170";
			this.Line170.Top = 3.024F;
			this.Line170.Width = 7.037F;
			this.Line170.X1 = 0.063F;
			this.Line170.X2 = 7.1F;
			this.Line170.Y1 = 3.024F;
			this.Line170.Y2 = 3.024F;
			// 
			// Line171
			// 
			this.Line171.Height = 0F;
			this.Line171.Left = 0.063F;
			this.Line171.LineWeight = 1F;
			this.Line171.Name = "Line171";
			this.Line171.Top = 3.192F;
			this.Line171.Width = 7.037F;
			this.Line171.X1 = 0.063F;
			this.Line171.X2 = 7.1F;
			this.Line171.Y1 = 3.192F;
			this.Line171.Y2 = 3.192F;
			// 
			// Line172
			// 
			this.Line172.Height = 0F;
			this.Line172.Left = 0.063F;
			this.Line172.LineWeight = 1F;
			this.Line172.Name = "Line172";
			this.Line172.Top = 3.36F;
			this.Line172.Width = 7.037F;
			this.Line172.X1 = 0.063F;
			this.Line172.X2 = 7.1F;
			this.Line172.Y1 = 3.36F;
			this.Line172.Y2 = 3.36F;
			// 
			// Line173
			// 
			this.Line173.Height = 0F;
			this.Line173.Left = 0.063F;
			this.Line173.LineWeight = 1F;
			this.Line173.Name = "Line173";
			this.Line173.Top = 3.528F;
			this.Line173.Width = 7.037F;
			this.Line173.X1 = 0.063F;
			this.Line173.X2 = 7.1F;
			this.Line173.Y1 = 3.528F;
			this.Line173.Y2 = 3.528F;
			// 
			// Line174
			// 
			this.Line174.Height = 0F;
			this.Line174.Left = 0.063F;
			this.Line174.LineWeight = 1F;
			this.Line174.Name = "Line174";
			this.Line174.Top = 3.696F;
			this.Line174.Width = 7.037F;
			this.Line174.X1 = 0.063F;
			this.Line174.X2 = 7.1F;
			this.Line174.Y1 = 3.696F;
			this.Line174.Y2 = 3.696F;
			// 
			// Line175
			// 
			this.Line175.Height = 0F;
			this.Line175.Left = 0.063F;
			this.Line175.LineWeight = 1F;
			this.Line175.Name = "Line175";
			this.Line175.Top = 4.032F;
			this.Line175.Width = 7.037F;
			this.Line175.X1 = 0.063F;
			this.Line175.X2 = 7.1F;
			this.Line175.Y1 = 4.032F;
			this.Line175.Y2 = 4.032F;
			// 
			// Line176
			// 
			this.Line176.Height = 0F;
			this.Line176.Left = 0.063F;
			this.Line176.LineWeight = 1F;
			this.Line176.Name = "Line176";
			this.Line176.Top = 4.2F;
			this.Line176.Width = 7.037F;
			this.Line176.X1 = 0.063F;
			this.Line176.X2 = 7.1F;
			this.Line176.Y1 = 4.2F;
			this.Line176.Y2 = 4.2F;
			// 
			// Line182
			// 
			this.Line182.Height = 0F;
			this.Line182.Left = 0.063F;
			this.Line182.LineWeight = 1F;
			this.Line182.Name = "Line182";
			this.Line182.Top = 5.376F;
			this.Line182.Width = 7.037F;
			this.Line182.X1 = 0.063F;
			this.Line182.X2 = 7.1F;
			this.Line182.Y1 = 5.376F;
			this.Line182.Y2 = 5.376F;
			// 
			// Line183
			// 
			this.Line183.Height = 0F;
			this.Line183.Left = 0.063F;
			this.Line183.LineWeight = 1F;
			this.Line183.Name = "Line183";
			this.Line183.Top = 5.554F;
			this.Line183.Width = 7.037F;
			this.Line183.X1 = 0.063F;
			this.Line183.X2 = 7.1F;
			this.Line183.Y1 = 5.554F;
			this.Line183.Y2 = 5.554F;
			// 
			// Line184
			// 
			this.Line184.Height = 0F;
			this.Line184.Left = 0.063F;
			this.Line184.LineWeight = 1F;
			this.Line184.Name = "Line184";
			this.Line184.Top = 5.712F;
			this.Line184.Width = 7.037F;
			this.Line184.X1 = 0.063F;
			this.Line184.X2 = 7.1F;
			this.Line184.Y1 = 5.712F;
			this.Line184.Y2 = 5.712F;
			// 
			// Line185
			// 
			this.Line185.Height = 0F;
			this.Line185.Left = 0.063F;
			this.Line185.LineWeight = 1F;
			this.Line185.Name = "Line185";
			this.Line185.Top = 5.88F;
			this.Line185.Width = 7.037F;
			this.Line185.X1 = 0.063F;
			this.Line185.X2 = 7.1F;
			this.Line185.Y1 = 5.88F;
			this.Line185.Y2 = 5.88F;
			// 
			// Line186
			// 
			this.Line186.Height = 0F;
			this.Line186.Left = 0.063F;
			this.Line186.LineWeight = 1F;
			this.Line186.Name = "Line186";
			this.Line186.Top = 6.048F;
			this.Line186.Width = 7.037F;
			this.Line186.X1 = 0.063F;
			this.Line186.X2 = 7.1F;
			this.Line186.Y1 = 6.048F;
			this.Line186.Y2 = 6.048F;
			// 
			// Line187
			// 
			this.Line187.Height = 0F;
			this.Line187.Left = 0.063F;
			this.Line187.LineWeight = 1F;
			this.Line187.Name = "Line187";
			this.Line187.Top = 6.216F;
			this.Line187.Width = 7.037F;
			this.Line187.X1 = 0.063F;
			this.Line187.X2 = 7.1F;
			this.Line187.Y1 = 6.216F;
			this.Line187.Y2 = 6.216F;
			// 
			// Line188
			// 
			this.Line188.Height = 0F;
			this.Line188.Left = 0.063F;
			this.Line188.LineWeight = 1F;
			this.Line188.Name = "Line188";
			this.Line188.Top = 6.216F;
			this.Line188.Width = 7.037F;
			this.Line188.X1 = 0.063F;
			this.Line188.X2 = 7.1F;
			this.Line188.Y1 = 6.216F;
			this.Line188.Y2 = 6.216F;
			// 
			// Line189
			// 
			this.Line189.Height = 0F;
			this.Line189.Left = 0.063F;
			this.Line189.LineWeight = 1F;
			this.Line189.Name = "Line189";
			this.Line189.Top = 6.384F;
			this.Line189.Width = 7.037F;
			this.Line189.X1 = 0.063F;
			this.Line189.X2 = 7.1F;
			this.Line189.Y1 = 6.384F;
			this.Line189.Y2 = 6.384F;
			// 
			// Line190
			// 
			this.Line190.Height = 0F;
			this.Line190.Left = 0.063F;
			this.Line190.LineWeight = 1F;
			this.Line190.Name = "Line190";
			this.Line190.Top = 6.72F;
			this.Line190.Width = 7.037F;
			this.Line190.X1 = 0.063F;
			this.Line190.X2 = 7.1F;
			this.Line190.Y1 = 6.72F;
			this.Line190.Y2 = 6.72F;
			// 
			// Line191
			// 
			this.Line191.Height = 0F;
			this.Line191.Left = 0.063F;
			this.Line191.LineWeight = 1F;
			this.Line191.Name = "Line191";
			this.Line191.Top = 6.552F;
			this.Line191.Width = 7.037F;
			this.Line191.X1 = 0.063F;
			this.Line191.X2 = 7.1F;
			this.Line191.Y1 = 6.552F;
			this.Line191.Y2 = 6.552F;
			// 
			// Line192
			// 
			this.Line192.Height = 8.232F;
			this.Line192.Left = 3.413F;
			this.Line192.LineWeight = 1F;
			this.Line192.Name = "Line192";
			this.Line192.Top = 1.512F;
			this.Line192.Width = 0F;
			this.Line192.X1 = 3.413F;
			this.Line192.X2 = 3.413F;
			this.Line192.Y1 = 1.512F;
			this.Line192.Y2 = 9.744F;
			// 
			// Line193
			// 
			this.Line193.Height = 3.192F;
			this.Line193.Left = 1.625F;
			this.Line193.LineWeight = 1F;
			this.Line193.Name = "Line193";
			this.Line193.Top = 6.552F;
			this.Line193.Width = 0F;
			this.Line193.X1 = 1.625F;
			this.Line193.X2 = 1.625F;
			this.Line193.Y1 = 6.552F;
			this.Line193.Y2 = 9.744F;
			// 
			// Line194
			// 
			this.Line194.Height = 3.192F;
			this.Line194.Left = 0.625F;
			this.Line194.LineWeight = 1F;
			this.Line194.Name = "Line194";
			this.Line194.Top = 6.552F;
			this.Line194.Width = 0F;
			this.Line194.X1 = 0.625F;
			this.Line194.X2 = 0.625F;
			this.Line194.Y1 = 6.552F;
			this.Line194.Y2 = 9.744F;
			// 
			// Line196
			// 
			this.Line196.Height = 0F;
			this.Line196.Left = 0.063F;
			this.Line196.LineWeight = 1F;
			this.Line196.Name = "Line196";
			this.Line196.Top = 7.056F;
			this.Line196.Width = 7.037F;
			this.Line196.X1 = 0.063F;
			this.Line196.X2 = 7.1F;
			this.Line196.Y1 = 7.056F;
			this.Line196.Y2 = 7.056F;
			// 
			// Line197
			// 
			this.Line197.Height = 0F;
			this.Line197.Left = 0.063F;
			this.Line197.LineWeight = 1F;
			this.Line197.Name = "Line197";
			this.Line197.Top = 7.392F;
			this.Line197.Width = 7.037F;
			this.Line197.X1 = 0.063F;
			this.Line197.X2 = 7.1F;
			this.Line197.Y1 = 7.392F;
			this.Line197.Y2 = 7.392F;
			// 
			// Line198
			// 
			this.Line198.Height = 0F;
			this.Line198.Left = 0.063F;
			this.Line198.LineWeight = 1F;
			this.Line198.Name = "Line198";
			this.Line198.Top = 7.728F;
			this.Line198.Width = 7.037F;
			this.Line198.X1 = 0.063F;
			this.Line198.X2 = 7.1F;
			this.Line198.Y1 = 7.728F;
			this.Line198.Y2 = 7.728F;
			// 
			// Line199
			// 
			this.Line199.Height = 0F;
			this.Line199.Left = 0.063F;
			this.Line199.LineWeight = 1F;
			this.Line199.Name = "Line199";
			this.Line199.Top = 8.064F;
			this.Line199.Width = 7.037F;
			this.Line199.X1 = 0.063F;
			this.Line199.X2 = 7.1F;
			this.Line199.Y1 = 8.064F;
			this.Line199.Y2 = 8.064F;
			// 
			// Line200
			// 
			this.Line200.Height = 0F;
			this.Line200.Left = 0.063F;
			this.Line200.LineWeight = 1F;
			this.Line200.Name = "Line200";
			this.Line200.Top = 8.4F;
			this.Line200.Width = 7.037F;
			this.Line200.X1 = 0.063F;
			this.Line200.X2 = 7.1F;
			this.Line200.Y1 = 8.4F;
			this.Line200.Y2 = 8.4F;
			// 
			// Line201
			// 
			this.Line201.Height = 0F;
			this.Line201.Left = 0.063F;
			this.Line201.LineWeight = 1F;
			this.Line201.Name = "Line201";
			this.Line201.Top = 8.736F;
			this.Line201.Width = 7.037F;
			this.Line201.X1 = 0.063F;
			this.Line201.X2 = 7.1F;
			this.Line201.Y1 = 8.736F;
			this.Line201.Y2 = 8.736F;
			// 
			// Line202
			// 
			this.Line202.Height = 0F;
			this.Line202.Left = 0.063F;
			this.Line202.LineWeight = 1F;
			this.Line202.Name = "Line202";
			this.Line202.Top = 9.072F;
			this.Line202.Width = 7.037F;
			this.Line202.X1 = 0.063F;
			this.Line202.X2 = 7.1F;
			this.Line202.Y1 = 9.072F;
			this.Line202.Y2 = 9.072F;
			// 
			// Line204
			// 
			this.Line204.Height = 0F;
			this.Line204.Left = 0.063F;
			this.Line204.LineWeight = 1F;
			this.Line204.Name = "Line204";
			this.Line204.Top = 9.24F;
			this.Line204.Width = 1.562F;
			this.Line204.X1 = 0.063F;
			this.Line204.X2 = 1.625F;
			this.Line204.Y1 = 9.24F;
			this.Line204.Y2 = 9.24F;
			// 
			// Line205
			// 
			this.Line205.Height = 0F;
			this.Line205.Left = 0.063F;
			this.Line205.LineWeight = 1F;
			this.Line205.Name = "Line205";
			this.Line205.Top = 9.408F;
			this.Line205.Width = 7.037F;
			this.Line205.X1 = 0.063F;
			this.Line205.X2 = 7.1F;
			this.Line205.Y1 = 9.408F;
			this.Line205.Y2 = 9.408F;
			// 
			// Line206
			// 
			this.Line206.Height = 0F;
			this.Line206.Left = 0.063F;
			this.Line206.LineWeight = 1F;
			this.Line206.Name = "Line206";
			this.Line206.Top = 9.576F;
			this.Line206.Width = 1.562F;
			this.Line206.X1 = 0.063F;
			this.Line206.X2 = 1.625F;
			this.Line206.Y1 = 9.576F;
			this.Line206.Y2 = 9.576F;
			// 
			// Line207
			// 
			this.Line207.Height = 0F;
			this.Line207.Left = 0.063F;
			this.Line207.LineWeight = 1F;
			this.Line207.Name = "Line207";
			this.Line207.Top = 8.904F;
			this.Line207.Width = 1.562F;
			this.Line207.X1 = 0.063F;
			this.Line207.X2 = 1.625F;
			this.Line207.Y1 = 8.904F;
			this.Line207.Y2 = 8.904F;
			// 
			// Line208
			// 
			this.Line208.Height = 0F;
			this.Line208.Left = 0.063F;
			this.Line208.LineWeight = 1F;
			this.Line208.Name = "Line208";
			this.Line208.Top = 8.568F;
			this.Line208.Width = 1.562F;
			this.Line208.X1 = 0.063F;
			this.Line208.X2 = 1.625F;
			this.Line208.Y1 = 8.568F;
			this.Line208.Y2 = 8.568F;
			// 
			// Line209
			// 
			this.Line209.Height = 0F;
			this.Line209.Left = 0.063F;
			this.Line209.LineWeight = 1F;
			this.Line209.Name = "Line209";
			this.Line209.Top = 8.232F;
			this.Line209.Width = 1.562F;
			this.Line209.X1 = 0.063F;
			this.Line209.X2 = 1.625F;
			this.Line209.Y1 = 8.232F;
			this.Line209.Y2 = 8.232F;
			// 
			// Line210
			// 
			this.Line210.Height = 0F;
			this.Line210.Left = 0.063F;
			this.Line210.LineWeight = 1F;
			this.Line210.Name = "Line210";
			this.Line210.Top = 7.896F;
			this.Line210.Width = 1.562F;
			this.Line210.X1 = 0.063F;
			this.Line210.X2 = 1.625F;
			this.Line210.Y1 = 7.896F;
			this.Line210.Y2 = 7.896F;
			// 
			// Line211
			// 
			this.Line211.Height = 0F;
			this.Line211.Left = 0.063F;
			this.Line211.LineWeight = 1F;
			this.Line211.Name = "Line211";
			this.Line211.Top = 7.56F;
			this.Line211.Width = 1.562F;
			this.Line211.X1 = 0.063F;
			this.Line211.X2 = 1.625F;
			this.Line211.Y1 = 7.56F;
			this.Line211.Y2 = 7.56F;
			// 
			// Line212
			// 
			this.Line212.Height = 9.744F;
			this.Line212.Left = 7.1F;
			this.Line212.LineWeight = 1F;
			this.Line212.Name = "Line212";
			this.Line212.Top = 0F;
			this.Line212.Width = 0F;
			this.Line212.X1 = 7.1F;
			this.Line212.X2 = 7.1F;
			this.Line212.Y1 = 0F;
			this.Line212.Y2 = 9.744F;
			// 
			// Line213
			// 
			this.Line213.Height = 0F;
			this.Line213.Left = 0.063F;
			this.Line213.LineWeight = 1F;
			this.Line213.Name = "Line213";
			this.Line213.Top = 6.886F;
			this.Line213.Width = 1.562F;
			this.Line213.X1 = 0.063F;
			this.Line213.X2 = 1.625F;
			this.Line213.Y1 = 6.886F;
			this.Line213.Y2 = 6.886F;
			// 
			// Line214
			// 
			this.Line214.Height = 0.8400002F;
			this.Line214.Left = 4.038F;
			this.Line214.LineWeight = 1F;
			this.Line214.Name = "Line214";
			this.Line214.Top = 7.896F;
			this.Line214.Width = 0F;
			this.Line214.X1 = 4.038F;
			this.Line214.X2 = 4.038F;
			this.Line214.Y1 = 7.896F;
			this.Line214.Y2 = 8.736F;
			// 
			// Line215
			// 
			this.Line215.Height = 0.8400002F;
			this.Line215.Left = 4.038F;
			this.Line215.LineWeight = 1F;
			this.Line215.Name = "Line215";
			this.Line215.Top = 8.904F;
			this.Line215.Width = 0F;
			this.Line215.X1 = 4.038F;
			this.Line215.X2 = 4.038F;
			this.Line215.Y1 = 8.904F;
			this.Line215.Y2 = 9.744F;
			// 
			// Line216
			// 
			this.Line216.Height = 0.8400002F;
			this.Line216.Left = 4.663F;
			this.Line216.LineWeight = 1F;
			this.Line216.Name = "Line216";
			this.Line216.Top = 8.904F;
			this.Line216.Width = 0F;
			this.Line216.X1 = 4.663F;
			this.Line216.X2 = 4.663F;
			this.Line216.Y1 = 8.904F;
			this.Line216.Y2 = 9.744F;
			// 
			// Line217
			// 
			this.Line217.Height = 0.8400011F;
			this.Line217.Left = 4.663F;
			this.Line217.LineWeight = 1F;
			this.Line217.Name = "Line217";
			this.Line217.Top = 4.368F;
			this.Line217.Width = 0F;
			this.Line217.X1 = 4.663F;
			this.Line217.X2 = 4.663F;
			this.Line217.Y1 = 4.368F;
			this.Line217.Y2 = 5.208001F;
			// 
			// Line218
			// 
			this.Line218.Height = 0.8400011F;
			this.Line218.Left = 4.038F;
			this.Line218.LineWeight = 1F;
			this.Line218.Name = "Line218";
			this.Line218.Top = 4.368F;
			this.Line218.Width = 0F;
			this.Line218.X1 = 4.038F;
			this.Line218.X2 = 4.038F;
			this.Line218.Y1 = 4.368F;
			this.Line218.Y2 = 5.208001F;
			// 
			// Line219
			// 
			this.Line219.Height = 1.176F;
			this.Line219.Left = 4.038F;
			this.Line219.LineWeight = 1F;
			this.Line219.Name = "Line219";
			this.Line219.Top = 5.376F;
			this.Line219.Width = 0F;
			this.Line219.X1 = 4.038F;
			this.Line219.X2 = 4.038F;
			this.Line219.Y1 = 5.376F;
			this.Line219.Y2 = 6.552F;
			// 
			// Line220
			// 
			this.Line220.Height = 1.344F;
			this.Line220.Left = 4.1F;
			this.Line220.LineWeight = 1F;
			this.Line220.Name = "Line220";
			this.Line220.Top = 2.856F;
			this.Line220.Width = 0F;
			this.Line220.X1 = 4.1F;
			this.Line220.X2 = 4.1F;
			this.Line220.Y1 = 2.856F;
			this.Line220.Y2 = 4.2F;
			// 
			// Line221
			// 
			this.Line221.Height = 0.168F;
			this.Line221.Left = 5.1F;
			this.Line221.LineWeight = 1F;
			this.Line221.Name = "Line221";
			this.Line221.Top = 3.024F;
			this.Line221.Width = 0F;
			this.Line221.X1 = 5.1F;
			this.Line221.X2 = 5.1F;
			this.Line221.Y1 = 3.024F;
			this.Line221.Y2 = 3.192F;
			// 
			// Line222
			// 
			this.Line222.Height = 0.1680002F;
			this.Line222.Left = 5.1F;
			this.Line222.LineWeight = 1F;
			this.Line222.Name = "Line222";
			this.Line222.Top = 3.36F;
			this.Line222.Width = 0F;
			this.Line222.X1 = 5.1F;
			this.Line222.X2 = 5.1F;
			this.Line222.Y1 = 3.36F;
			this.Line222.Y2 = 3.528F;
			// 
			// Line223
			// 
			this.Line223.Height = 0.1679997F;
			this.Line223.Left = 5.1F;
			this.Line223.LineWeight = 1F;
			this.Line223.Name = "Line223";
			this.Line223.Top = 4.032F;
			this.Line223.Width = 0F;
			this.Line223.X1 = 5.1F;
			this.Line223.X2 = 5.1F;
			this.Line223.Y1 = 4.032F;
			this.Line223.Y2 = 4.2F;
			// 
			// Line224
			// 
			this.Line224.Height = 0.168F;
			this.Line224.Left = 5.1F;
			this.Line224.LineWeight = 1F;
			this.Line224.Name = "Line224";
			this.Line224.Top = 3.696F;
			this.Line224.Width = 0F;
			this.Line224.X1 = 5.1F;
			this.Line224.X2 = 5.1F;
			this.Line224.Y1 = 3.696F;
			this.Line224.Y2 = 3.864F;
			// 
			// Line229
			// 
			this.Line229.Height = 1.008F;
			this.Line229.Left = 4.038F;
			this.Line229.LineWeight = 1F;
			this.Line229.Name = "Line229";
			this.Line229.Top = 6.72F;
			this.Line229.Width = 0F;
			this.Line229.X1 = 4.038F;
			this.Line229.X2 = 4.038F;
			this.Line229.Y1 = 6.72F;
			this.Line229.Y2 = 7.728F;
			// 
			// Line230
			// 
			this.Line230.Height = 1.008F;
			this.Line230.Left = 4.461F;
			this.Line230.LineWeight = 1F;
			this.Line230.Name = "Line230";
			this.Line230.Top = 1.68F;
			this.Line230.Width = 0F;
			this.Line230.X1 = 4.461F;
			this.Line230.X2 = 4.461F;
			this.Line230.Y1 = 1.68F;
			this.Line230.Y2 = 2.688F;
			// 
			// Line231
			// 
			this.Line231.Height = 1.008F;
			this.Line231.Left = 6.43F;
			this.Line231.LineWeight = 1F;
			this.Line231.Name = "Line231";
			this.Line231.Top = 1.68F;
			this.Line231.Width = 0F;
			this.Line231.X1 = 6.43F;
			this.Line231.X2 = 6.43F;
			this.Line231.Y1 = 1.68F;
			this.Line231.Y2 = 2.688F;
			// 
			// Line232
			// 
			this.Line232.Height = 1.008F;
			this.Line232.Left = 0.625F;
			this.Line232.LineWeight = 1F;
			this.Line232.Name = "Line232";
			this.Line232.Top = 5.376F;
			this.Line232.Width = 0F;
			this.Line232.X1 = 0.625F;
			this.Line232.X2 = 0.625F;
			this.Line232.Y1 = 5.376F;
			this.Line232.Y2 = 6.384F;
			// 
			// LengthServMmText
			// 
			this.LengthServMmText.CanGrow = false;
			this.LengthServMmText.DataField = "LENGTH_SERV_MM";
			this.LengthServMmText.Height = 0.168F;
			this.LengthServMmText.Left = 5.75F;
			this.LengthServMmText.Name = "LengthServMmText";
			this.LengthServMmText.OutputFormat = "ddヶ月";
			this.LengthServMmText.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.LengthServMmText.Text = "Z6ヶ月";
			this.LengthServMmText.Top = 0.31F;
			this.LengthServMmText.Width = 0.375F;
			// 
			// WordExpPeriodMonth1Text
			// 
			this.WordExpPeriodMonth1Text.CanGrow = false;
			this.WordExpPeriodMonth1Text.DataField = "WORK_EXP_PERIOD_MONTH_1";
			this.WordExpPeriodMonth1Text.Height = 0.168F;
			this.WordExpPeriodMonth1Text.Left = 0.875F;
			this.WordExpPeriodMonth1Text.Name = "WordExpPeriodMonth1Text";
			this.WordExpPeriodMonth1Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth1Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth1Text.Top = 6.72F;
			this.WordExpPeriodMonth1Text.Width = 0.375F;
			// 
			// WordExpPeriodYear1Text
			// 
			this.WordExpPeriodYear1Text.CanGrow = false;
			this.WordExpPeriodYear1Text.DataField = "WORK_EXP_PERIOD_YEAR_1";
			this.WordExpPeriodYear1Text.Height = 0.168F;
			this.WordExpPeriodYear1Text.Left = 0.625F;
			this.WordExpPeriodYear1Text.Name = "WordExpPeriodYear1Text";
			this.WordExpPeriodYear1Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear1Text.Text = "Z6年";
			this.WordExpPeriodYear1Text.Top = 6.72F;
			this.WordExpPeriodYear1Text.Width = 0.25F;
			// 
			// WordExpPeriodYear2Text
			// 
			this.WordExpPeriodYear2Text.CanGrow = false;
			this.WordExpPeriodYear2Text.DataField = "WORK_EXP_PERIOD_YEAR_2";
			this.WordExpPeriodYear2Text.Height = 0.168F;
			this.WordExpPeriodYear2Text.Left = 0.625F;
			this.WordExpPeriodYear2Text.Name = "WordExpPeriodYear2Text";
			this.WordExpPeriodYear2Text.OutputFormat = "年";
			this.WordExpPeriodYear2Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear2Text.Text = "Z6年";
			this.WordExpPeriodYear2Text.Top = 7.056F;
			this.WordExpPeriodYear2Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth2Text
			// 
			this.WordExpPeriodMonth2Text.CanGrow = false;
			this.WordExpPeriodMonth2Text.DataField = "WORK_EXP_PERIOD_MONTH_2";
			this.WordExpPeriodMonth2Text.Height = 0.168F;
			this.WordExpPeriodMonth2Text.Left = 0.875F;
			this.WordExpPeriodMonth2Text.Name = "WordExpPeriodMonth2Text";
			this.WordExpPeriodMonth2Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth2Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth2Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth2Text.Top = 7.056F;
			this.WordExpPeriodMonth2Text.Width = 0.375F;
			// 
			// WordExpPeriodYear3Text
			// 
			this.WordExpPeriodYear3Text.CanGrow = false;
			this.WordExpPeriodYear3Text.DataField = "WORK_EXP_PERIOD_YEAR_3";
			this.WordExpPeriodYear3Text.Height = 0.168F;
			this.WordExpPeriodYear3Text.Left = 0.625F;
			this.WordExpPeriodYear3Text.Name = "WordExpPeriodYear3Text";
			this.WordExpPeriodYear3Text.OutputFormat = "yy年";
			this.WordExpPeriodYear3Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear3Text.Text = "Z6年";
			this.WordExpPeriodYear3Text.Top = 7.392F;
			this.WordExpPeriodYear3Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth3Text
			// 
			this.WordExpPeriodMonth3Text.CanGrow = false;
			this.WordExpPeriodMonth3Text.DataField = "WORK_EXP_PERIOD_MONTH_3";
			this.WordExpPeriodMonth3Text.Height = 0.168F;
			this.WordExpPeriodMonth3Text.Left = 0.875F;
			this.WordExpPeriodMonth3Text.Name = "WordExpPeriodMonth3Text";
			this.WordExpPeriodMonth3Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth3Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth3Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth3Text.Top = 7.392F;
			this.WordExpPeriodMonth3Text.Width = 0.375F;
			// 
			// WordExpPeriodYear4Text
			// 
			this.WordExpPeriodYear4Text.CanGrow = false;
			this.WordExpPeriodYear4Text.DataField = "WORK_EXP_PERIOD_YEAR_4";
			this.WordExpPeriodYear4Text.Height = 0.168F;
			this.WordExpPeriodYear4Text.Left = 0.625F;
			this.WordExpPeriodYear4Text.Name = "WordExpPeriodYear4Text";
			this.WordExpPeriodYear4Text.OutputFormat = "yy年";
			this.WordExpPeriodYear4Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear4Text.Text = "Z6年";
			this.WordExpPeriodYear4Text.Top = 7.728F;
			this.WordExpPeriodYear4Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth4Text
			// 
			this.WordExpPeriodMonth4Text.CanGrow = false;
			this.WordExpPeriodMonth4Text.DataField = "WORK_EXP_PERIOD_MONTH_4";
			this.WordExpPeriodMonth4Text.Height = 0.168F;
			this.WordExpPeriodMonth4Text.Left = 0.875F;
			this.WordExpPeriodMonth4Text.Name = "WordExpPeriodMonth4Text";
			this.WordExpPeriodMonth4Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth4Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth4Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth4Text.Top = 7.728F;
			this.WordExpPeriodMonth4Text.Width = 0.375F;
			// 
			// WordExpPeriodYear5Text
			// 
			this.WordExpPeriodYear5Text.CanGrow = false;
			this.WordExpPeriodYear5Text.DataField = "WORK_EXP_PERIOD_YEAR_5";
			this.WordExpPeriodYear5Text.Height = 0.168F;
			this.WordExpPeriodYear5Text.Left = 0.625F;
			this.WordExpPeriodYear5Text.Name = "WordExpPeriodYear5Text";
			this.WordExpPeriodYear5Text.OutputFormat = "yy年";
			this.WordExpPeriodYear5Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear5Text.Text = "Z6年";
			this.WordExpPeriodYear5Text.Top = 8.064F;
			this.WordExpPeriodYear5Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth5Text
			// 
			this.WordExpPeriodMonth5Text.CanGrow = false;
			this.WordExpPeriodMonth5Text.DataField = "WORK_EXP_PERIOD_MONTH_5";
			this.WordExpPeriodMonth5Text.Height = 0.168F;
			this.WordExpPeriodMonth5Text.Left = 0.875F;
			this.WordExpPeriodMonth5Text.Name = "WordExpPeriodMonth5Text";
			this.WordExpPeriodMonth5Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth5Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth5Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth5Text.Top = 8.064F;
			this.WordExpPeriodMonth5Text.Width = 0.375F;
			// 
			// WordExpPeriodYear6Text
			// 
			this.WordExpPeriodYear6Text.CanGrow = false;
			this.WordExpPeriodYear6Text.DataField = "WORK_EXP_PERIOD_YEAR_6";
			this.WordExpPeriodYear6Text.Height = 0.168F;
			this.WordExpPeriodYear6Text.Left = 0.625F;
			this.WordExpPeriodYear6Text.Name = "WordExpPeriodYear6Text";
			this.WordExpPeriodYear6Text.OutputFormat = "yy年";
			this.WordExpPeriodYear6Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear6Text.Text = "Z6年";
			this.WordExpPeriodYear6Text.Top = 8.4F;
			this.WordExpPeriodYear6Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth6Text
			// 
			this.WordExpPeriodMonth6Text.CanGrow = false;
			this.WordExpPeriodMonth6Text.DataField = "WORK_EXP_PERIOD_MONTH_6";
			this.WordExpPeriodMonth6Text.Height = 0.168F;
			this.WordExpPeriodMonth6Text.Left = 0.875F;
			this.WordExpPeriodMonth6Text.Name = "WordExpPeriodMonth6Text";
			this.WordExpPeriodMonth6Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth6Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth6Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth6Text.Top = 8.4F;
			this.WordExpPeriodMonth6Text.Width = 0.375F;
			// 
			// WordExpPeriodYear7Text
			// 
			this.WordExpPeriodYear7Text.CanGrow = false;
			this.WordExpPeriodYear7Text.DataField = "WORK_EXP_PERIOD_YEAR_7";
			this.WordExpPeriodYear7Text.Height = 0.168F;
			this.WordExpPeriodYear7Text.Left = 0.625F;
			this.WordExpPeriodYear7Text.Name = "WordExpPeriodYear7Text";
			this.WordExpPeriodYear7Text.OutputFormat = "yy年";
			this.WordExpPeriodYear7Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear7Text.Text = "Z6年";
			this.WordExpPeriodYear7Text.Top = 8.736F;
			this.WordExpPeriodYear7Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth7Text
			// 
			this.WordExpPeriodMonth7Text.CanGrow = false;
			this.WordExpPeriodMonth7Text.DataField = "WORK_EXP_PERIOD_MONTH_7";
			this.WordExpPeriodMonth7Text.Height = 0.168F;
			this.WordExpPeriodMonth7Text.Left = 0.875F;
			this.WordExpPeriodMonth7Text.Name = "WordExpPeriodMonth7Text";
			this.WordExpPeriodMonth7Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth7Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth7Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth7Text.Top = 8.736F;
			this.WordExpPeriodMonth7Text.Width = 0.375F;
			// 
			// WordExpPeriodYear8Text
			// 
			this.WordExpPeriodYear8Text.CanGrow = false;
			this.WordExpPeriodYear8Text.DataField = "WORK_EXP_PERIOD_YEAR_8";
			this.WordExpPeriodYear8Text.Height = 0.168F;
			this.WordExpPeriodYear8Text.Left = 0.625F;
			this.WordExpPeriodYear8Text.Name = "WordExpPeriodYear8Text";
			this.WordExpPeriodYear8Text.OutputFormat = "yy年";
			this.WordExpPeriodYear8Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear8Text.Text = "Z6年";
			this.WordExpPeriodYear8Text.Top = 9.072F;
			this.WordExpPeriodYear8Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth8Text
			// 
			this.WordExpPeriodMonth8Text.CanGrow = false;
			this.WordExpPeriodMonth8Text.DataField = "WORK_EXP_PERIOD_MONTH_8";
			this.WordExpPeriodMonth8Text.Height = 0.168F;
			this.WordExpPeriodMonth8Text.Left = 0.875F;
			this.WordExpPeriodMonth8Text.Name = "WordExpPeriodMonth8Text";
			this.WordExpPeriodMonth8Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth8Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth8Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth8Text.Top = 9.072F;
			this.WordExpPeriodMonth8Text.Width = 0.375F;
			// 
			// WordExpPeriodYear9Text
			// 
			this.WordExpPeriodYear9Text.CanGrow = false;
			this.WordExpPeriodYear9Text.DataField = "WORK_EXP_PERIOD_YEAR_9";
			this.WordExpPeriodYear9Text.Height = 0.168F;
			this.WordExpPeriodYear9Text.Left = 0.625F;
			this.WordExpPeriodYear9Text.Name = "WordExpPeriodYear9Text";
			this.WordExpPeriodYear9Text.OutputFormat = "yy年";
			this.WordExpPeriodYear9Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodYear9Text.Text = "Z6年";
			this.WordExpPeriodYear9Text.Top = 9.408F;
			this.WordExpPeriodYear9Text.Width = 0.25F;
			// 
			// WordExpPeriodMonth9Text
			// 
			this.WordExpPeriodMonth9Text.CanGrow = false;
			this.WordExpPeriodMonth9Text.DataField = "WORK_EXP_PERIOD_MONTH_9";
			this.WordExpPeriodMonth9Text.Height = 0.168F;
			this.WordExpPeriodMonth9Text.Left = 0.875F;
			this.WordExpPeriodMonth9Text.Name = "WordExpPeriodMonth9Text";
			this.WordExpPeriodMonth9Text.OutputFormat = "MMヶ月";
			this.WordExpPeriodMonth9Text.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.WordExpPeriodMonth9Text.Text = "Z6ヶ月";
			this.WordExpPeriodMonth9Text.Top = 9.408F;
			this.WordExpPeriodMonth9Text.Width = 0.375F;
			// 
			// RetirementDate1Text
			// 
			this.RetirementDate1Text.CanGrow = false;
			this.RetirementDate1Text.DataField = "RETIREMENT_DATE1";
			this.RetirementDate1Text.Height = 0.168F;
			this.RetirementDate1Text.Left = 4F;
			this.RetirementDate1Text.Name = "RetirementDate1Text";
			this.RetirementDate1Text.OutputFormat = "yyyy/MM";
			this.RetirementDate1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetirementDate1Text.Text = "ZZZ6/Z6";
			this.RetirementDate1Text.Top = 1.848F;
			this.RetirementDate1Text.Width = 0.461F;
			// 
			// EntranceDate2Text
			// 
			this.EntranceDate2Text.CanGrow = false;
			this.EntranceDate2Text.DataField = "ENTRANCE_DATE2";
			this.EntranceDate2Text.Height = 0.168F;
			this.EntranceDate2Text.Left = 3.438F;
			this.EntranceDate2Text.Name = "EntranceDate2Text";
			this.EntranceDate2Text.OutputFormat = "yyyy/MM";
			this.EntranceDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate2Text.Text = "ZZZ9/Z9";
			this.EntranceDate2Text.Top = 2.016F;
			this.EntranceDate2Text.Width = 0.4995F;
			// 
			// RetirementDate2Text
			// 
			this.RetirementDate2Text.CanGrow = false;
			this.RetirementDate2Text.DataField = "RETIREMENT_DATE2";
			this.RetirementDate2Text.Height = 0.168F;
			this.RetirementDate2Text.Left = 4F;
			this.RetirementDate2Text.Name = "RetirementDate2Text";
			this.RetirementDate2Text.OutputFormat = "yyyy/MM";
			this.RetirementDate2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetirementDate2Text.Text = "ZZZ6/Z6";
			this.RetirementDate2Text.Top = 2.016F;
			this.RetirementDate2Text.Width = 0.4619999F;
			// 
			// EntranceDate3Text
			// 
			this.EntranceDate3Text.CanGrow = false;
			this.EntranceDate3Text.DataField = "ENTRANCE_DATE3";
			this.EntranceDate3Text.Height = 0.168F;
			this.EntranceDate3Text.Left = 3.438F;
			this.EntranceDate3Text.Name = "EntranceDate3Text";
			this.EntranceDate3Text.OutputFormat = "yyyy/MM";
			this.EntranceDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate3Text.Text = "ZZZ9/Z9";
			this.EntranceDate3Text.Top = 2.184F;
			this.EntranceDate3Text.Width = 0.4995F;
			// 
			// RetirementDate3Text
			// 
			this.RetirementDate3Text.CanGrow = false;
			this.RetirementDate3Text.DataField = "RETIREMENT_DATE3";
			this.RetirementDate3Text.Height = 0.168F;
			this.RetirementDate3Text.Left = 4F;
			this.RetirementDate3Text.Name = "RetirementDate3Text";
			this.RetirementDate3Text.OutputFormat = "yyyy/MM";
			this.RetirementDate3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetirementDate3Text.Text = "ZZZ6/Z6";
			this.RetirementDate3Text.Top = 2.184F;
			this.RetirementDate3Text.Width = 0.461F;
			// 
			// EntranceDate4Text
			// 
			this.EntranceDate4Text.CanGrow = false;
			this.EntranceDate4Text.DataField = "ENTRANCE_DATE4";
			this.EntranceDate4Text.Height = 0.168F;
			this.EntranceDate4Text.Left = 3.438F;
			this.EntranceDate4Text.Name = "EntranceDate4Text";
			this.EntranceDate4Text.OutputFormat = "yyyy/MM";
			this.EntranceDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate4Text.Text = "ZZZ9/Z9";
			this.EntranceDate4Text.Top = 2.352F;
			this.EntranceDate4Text.Width = 0.4995F;
			// 
			// RetirementDate4Text
			// 
			this.RetirementDate4Text.CanGrow = false;
			this.RetirementDate4Text.DataField = "RETIREMENT_DATE4";
			this.RetirementDate4Text.Height = 0.168F;
			this.RetirementDate4Text.Left = 4F;
			this.RetirementDate4Text.Name = "RetirementDate4Text";
			this.RetirementDate4Text.OutputFormat = "yyyy/MM";
			this.RetirementDate4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetirementDate4Text.Text = "ZZZ6/Z6";
			this.RetirementDate4Text.Top = 2.352F;
			this.RetirementDate4Text.Width = 0.461F;
			// 
			// EntranceDate5Text
			// 
			this.EntranceDate5Text.CanGrow = false;
			this.EntranceDate5Text.DataField = "ENTRANCE_DATE5";
			this.EntranceDate5Text.Height = 0.168F;
			this.EntranceDate5Text.Left = 3.438F;
			this.EntranceDate5Text.Name = "EntranceDate5Text";
			this.EntranceDate5Text.OutputFormat = "yyyy/MM";
			this.EntranceDate5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate5Text.Text = "ZZZ9/Z9";
			this.EntranceDate5Text.Top = 2.52F;
			this.EntranceDate5Text.Width = 0.4995F;
			// 
			// RetirementDate5Text
			// 
			this.RetirementDate5Text.CanGrow = false;
			this.RetirementDate5Text.DataField = "RETIREMENT_DATE5";
			this.RetirementDate5Text.Height = 0.168F;
			this.RetirementDate5Text.Left = 4F;
			this.RetirementDate5Text.Name = "RetirementDate5Text";
			this.RetirementDate5Text.OutputFormat = "yyyy/MM";
			this.RetirementDate5Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetirementDate5Text.Text = "ZZZ6/Z6";
			this.RetirementDate5Text.Top = 2.52F;
			this.RetirementDate5Text.Width = 0.461F;
			// 
			// Line234
			// 
			this.Line234.Height = 0F;
			this.Line234.Left = 0.063F;
			this.Line234.LineWeight = 1F;
			this.Line234.Name = "Line234";
			this.Line234.Top = 1.176F;
			this.Line234.Width = 7.037F;
			this.Line234.X1 = 0.063F;
			this.Line234.X2 = 7.1F;
			this.Line234.Y1 = 1.176F;
			this.Line234.Y2 = 1.176F;
			// 
			// Line235
			// 
			this.Line235.Height = 0.5039999F;
			this.Line235.Left = 0.625F;
			this.Line235.LineWeight = 1F;
			this.Line235.Name = "Line235";
			this.Line235.Top = 1.008F;
			this.Line235.Width = 0F;
			this.Line235.X1 = 0.625F;
			this.Line235.X2 = 0.625F;
			this.Line235.Y1 = 1.008F;
			this.Line235.Y2 = 1.512F;
			// 
			// Line145
			// 
			this.Line145.Height = 0F;
			this.Line145.Left = 0.063F;
			this.Line145.LineWeight = 1F;
			this.Line145.Name = "Line145";
			this.Line145.Top = 9.744F;
			this.Line145.Width = 7.037F;
			this.Line145.X1 = 0.063F;
			this.Line145.X2 = 7.1F;
			this.Line145.Y1 = 9.744F;
			this.Line145.Y2 = 9.744F;
			// 
			// Line236
			// 
			this.Line236.Height = 0F;
			this.Line236.Left = 0.063F;
			this.Line236.LineWeight = 1F;
			this.Line236.Name = "Line236";
			this.Line236.Top = 4.368F;
			this.Line236.Width = 7.037F;
			this.Line236.X1 = 0.063F;
			this.Line236.X2 = 7.1F;
			this.Line236.Y1 = 4.368F;
			this.Line236.Y2 = 4.368F;
			// 
			// Line237
			// 
			this.Line237.Height = 0F;
			this.Line237.Left = 0.063F;
			this.Line237.LineWeight = 1F;
			this.Line237.Name = "Line237";
			this.Line237.Top = 7.224F;
			this.Line237.Width = 1.562F;
			this.Line237.X1 = 0.063F;
			this.Line237.X2 = 1.625F;
			this.Line237.Y1 = 7.224F;
			this.Line237.Y2 = 7.224F;
			// 
			// Label175
			// 
			this.Label175.Height = 0.168F;
			this.Label175.HyperLink = null;
			this.Label175.Left = 3.813F;
			this.Label175.Name = "Label175";
			this.Label175.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label175.Text = "～";
			this.Label175.Top = 1.68F;
			this.Label175.Width = 0.2495001F;
			// 
			// Label176
			// 
			this.Label176.Height = 0.168F;
			this.Label176.HyperLink = null;
			this.Label176.Left = 4.0625F;
			this.Label176.Name = "Label176";
			this.Label176.Style = "font-size: 7pt; font-weight: normal; text-align: left; vertical-align: middle; dd" +
    "o-char-set: 1";
			this.Label176.Text = "退社";
			this.Label176.Top = 1.6875F;
			this.Label176.Width = 0.4F;
			// 
			// ConcurAtacName1Text
			// 
			this.ConcurAtacName1Text.CanGrow = false;
			this.ConcurAtacName1Text.DataField = "CONCUR_ATAC_NAME_1";
			this.ConcurAtacName1Text.Height = 0.168F;
			this.ConcurAtacName1Text.Left = 5.68819F;
			this.ConcurAtacName1Text.Name = "ConcurAtacName1Text";
			this.ConcurAtacName1Text.OutputFormat = "#,##0";
			this.ConcurAtacName1Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurAtacName1Text.Text = "ああああああああ";
			this.ConcurAtacName1Text.Top = 4.536F;
			this.ConcurAtacName1Text.Width = 1.082677F;
			// 
			// ConcurAtacName2Text
			// 
			this.ConcurAtacName2Text.CanGrow = false;
			this.ConcurAtacName2Text.DataField = "CONCUR_ATAC_NAME_2";
			this.ConcurAtacName2Text.Height = 0.168F;
			this.ConcurAtacName2Text.Left = 5.68819F;
			this.ConcurAtacName2Text.Name = "ConcurAtacName2Text";
			this.ConcurAtacName2Text.OutputFormat = "#,##0";
			this.ConcurAtacName2Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurAtacName2Text.Text = "ああああああああ";
			this.ConcurAtacName2Text.Top = 4.704F;
			this.ConcurAtacName2Text.Width = 1.082677F;
			// 
			// ConcurAtacName3Text
			// 
			this.ConcurAtacName3Text.CanGrow = false;
			this.ConcurAtacName3Text.DataField = "CONCUR_ATAC_NAME_3";
			this.ConcurAtacName3Text.Height = 0.168F;
			this.ConcurAtacName3Text.Left = 5.68819F;
			this.ConcurAtacName3Text.Name = "ConcurAtacName3Text";
			this.ConcurAtacName3Text.OutputFormat = "#,##0";
			this.ConcurAtacName3Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurAtacName3Text.Text = "ああああああああ";
			this.ConcurAtacName3Text.Top = 4.872F;
			this.ConcurAtacName3Text.Width = 1.082677F;
			// 
			// ConcurAtacName4Text
			// 
			this.ConcurAtacName4Text.CanGrow = false;
			this.ConcurAtacName4Text.DataField = "CONCUR_ATAC_NAME_4";
			this.ConcurAtacName4Text.Height = 0.168F;
			this.ConcurAtacName4Text.Left = 5.68819F;
			this.ConcurAtacName4Text.Name = "ConcurAtacName4Text";
			this.ConcurAtacName4Text.OutputFormat = "#,##0";
			this.ConcurAtacName4Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ConcurAtacName4Text.Text = "ああああああああ";
			this.ConcurAtacName4Text.Top = 5.04F;
			this.ConcurAtacName4Text.Width = 1.082677F;
			// 
			// Line179
			// 
			this.Line179.Height = 0F;
			this.Line179.Left = 0.063F;
			this.Line179.LineWeight = 1F;
			this.Line179.Name = "Line179";
			this.Line179.Top = 4.872F;
			this.Line179.Width = 7.037F;
			this.Line179.X1 = 0.063F;
			this.Line179.X2 = 7.1F;
			this.Line179.Y1 = 4.872F;
			this.Line179.Y2 = 4.872F;
			// 
			// Line180
			// 
			this.Line180.Height = 0F;
			this.Line180.Left = 0.063F;
			this.Line180.LineWeight = 1F;
			this.Line180.Name = "Line180";
			this.Line180.Top = 5.04F;
			this.Line180.Width = 7.037F;
			this.Line180.X1 = 0.063F;
			this.Line180.X2 = 7.1F;
			this.Line180.Y1 = 5.04F;
			this.Line180.Y2 = 5.04F;
			// 
			// Line181
			// 
			this.Line181.Height = 0F;
			this.Line181.Left = 0.063F;
			this.Line181.LineWeight = 1F;
			this.Line181.Name = "Line181";
			this.Line181.Top = 5.208001F;
			this.Line181.Width = 7.037F;
			this.Line181.X1 = 0.063F;
			this.Line181.X2 = 7.1F;
			this.Line181.Y1 = 5.208001F;
			this.Line181.Y2 = 5.208001F;
			// 
			// Line177
			// 
			this.Line177.Height = 0F;
			this.Line177.Left = 0.063F;
			this.Line177.LineWeight = 1F;
			this.Line177.Name = "Line177";
			this.Line177.Top = 4.536F;
			this.Line177.Width = 7.037F;
			this.Line177.X1 = 0.063F;
			this.Line177.X2 = 7.1F;
			this.Line177.Y1 = 4.536F;
			this.Line177.Y2 = 4.536F;
			// 
			// BirthYmdJPText
			// 
			this.BirthYmdJPText.CanGrow = false;
			this.BirthYmdJPText.DataField = "BIRTH_YMD";
			this.BirthYmdJPText.Height = 0.168F;
			this.BirthYmdJPText.Left = 3.7505F;
			this.BirthYmdJPText.Name = "BirthYmdJPText";
			this.BirthYmdJPText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthYmdJPText.Text = "H999年";
			this.BirthYmdJPText.Top = 0.31F;
			this.BirthYmdJPText.Width = 0.35F;
			// 
			// InDateJPText
			// 
			this.InDateJPText.CanGrow = false;
			this.InDateJPText.DataField = "IN_DATE";
			this.InDateJPText.Height = 0.168F;
			this.InDateJPText.Left = 3.75F;
			this.InDateJPText.Name = "InDateJPText";
			this.InDateJPText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDateJPText.Text = "H999年";
			this.InDateJPText.Top = 0.5F;
			this.InDateJPText.Width = 0.35F;
			// 
			// InDate2JPText
			// 
			this.InDate2JPText.CanGrow = false;
			this.InDate2JPText.DataField = "IN_DATE2";
			this.InDate2JPText.Height = 0.168F;
			this.InDate2JPText.Left = 6.3125F;
			this.InDate2JPText.Name = "InDate2JPText";
			this.InDate2JPText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDate2JPText.Text = "H999年";
			this.InDate2JPText.Top = 0.5F;
			this.InDate2JPText.Width = 0.35F;
			// 
			// Line238
			// 
			this.Line238.Height = 0F;
			this.Line238.Left = 3.413F;
			this.Line238.LineWeight = 1F;
			this.Line238.Name = "Line238";
			this.Line238.Top = 6.886F;
			this.Line238.Width = 3.687F;
			this.Line238.X1 = 3.413F;
			this.Line238.X2 = 7.1F;
			this.Line238.Y1 = 6.886F;
			this.Line238.Y2 = 6.886F;
			// 
			// Line239
			// 
			this.Line239.Height = 0F;
			this.Line239.Left = 3.413F;
			this.Line239.LineWeight = 1F;
			this.Line239.Name = "Line239";
			this.Line239.Top = 7.224F;
			this.Line239.Width = 3.687F;
			this.Line239.X1 = 3.413F;
			this.Line239.X2 = 7.1F;
			this.Line239.Y1 = 7.224F;
			this.Line239.Y2 = 7.224F;
			// 
			// Line240
			// 
			this.Line240.Height = 0F;
			this.Line240.Left = 3.413F;
			this.Line240.LineWeight = 1F;
			this.Line240.Name = "Line240";
			this.Line240.Top = 7.56F;
			this.Line240.Width = 3.687F;
			this.Line240.X1 = 3.413F;
			this.Line240.X2 = 7.1F;
			this.Line240.Y1 = 7.56F;
			this.Line240.Y2 = 7.56F;
			// 
			// Line241
			// 
			this.Line241.Height = 0F;
			this.Line241.Left = 3.413F;
			this.Line241.LineWeight = 1F;
			this.Line241.Name = "Line241";
			this.Line241.Top = 7.896F;
			this.Line241.Width = 3.687F;
			this.Line241.X1 = 3.413F;
			this.Line241.X2 = 7.1F;
			this.Line241.Y1 = 7.896F;
			this.Line241.Y2 = 7.896F;
			// 
			// Line242
			// 
			this.Line242.Height = 0F;
			this.Line242.Left = 3.413F;
			this.Line242.LineWeight = 1F;
			this.Line242.Name = "Line242";
			this.Line242.Top = 8.232F;
			this.Line242.Width = 3.687F;
			this.Line242.X1 = 3.413F;
			this.Line242.X2 = 7.1F;
			this.Line242.Y1 = 8.232F;
			this.Line242.Y2 = 8.232F;
			// 
			// Line243
			// 
			this.Line243.Height = 0F;
			this.Line243.Left = 3.413F;
			this.Line243.LineWeight = 1F;
			this.Line243.Name = "Line243";
			this.Line243.Top = 8.568F;
			this.Line243.Width = 3.687F;
			this.Line243.X1 = 3.413F;
			this.Line243.X2 = 7.1F;
			this.Line243.Y1 = 8.568F;
			this.Line243.Y2 = 8.568F;
			// 
			// Line244
			// 
			this.Line244.Height = 0F;
			this.Line244.Left = 3.413F;
			this.Line244.LineWeight = 1F;
			this.Line244.Name = "Line244";
			this.Line244.Top = 8.904F;
			this.Line244.Width = 3.687F;
			this.Line244.X1 = 3.413F;
			this.Line244.X2 = 7.1F;
			this.Line244.Y1 = 8.904F;
			this.Line244.Y2 = 8.904F;
			// 
			// Line245
			// 
			this.Line245.Height = 0F;
			this.Line245.Left = 3.413F;
			this.Line245.LineWeight = 1F;
			this.Line245.Name = "Line245";
			this.Line245.Top = 9.24F;
			this.Line245.Width = 3.687F;
			this.Line245.X1 = 3.413F;
			this.Line245.X2 = 7.1F;
			this.Line245.Y1 = 9.24F;
			this.Line245.Y2 = 9.24F;
			// 
			// Line246
			// 
			this.Line246.Height = 0F;
			this.Line246.Left = 3.413F;
			this.Line246.LineWeight = 1F;
			this.Line246.Name = "Line246";
			this.Line246.Top = 9.576F;
			this.Line246.Width = 3.687F;
			this.Line246.X1 = 3.413F;
			this.Line246.X2 = 7.1F;
			this.Line246.Y1 = 9.576F;
			this.Line246.Y2 = 9.576F;
			// 
			// SHF_DATE_16
			// 
			this.SHF_DATE_16.CanGrow = false;
			this.SHF_DATE_16.DataField = "SHF_DATE_16";
			this.SHF_DATE_16.Height = 0.168F;
			this.SHF_DATE_16.Left = 0.0625F;
			this.SHF_DATE_16.Name = "SHF_DATE_16";
			this.SHF_DATE_16.OutputFormat = "yyyy/MM/dd";
			this.SHF_DATE_16.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SHF_DATE_16.Text = "ZZZ6/Z6/Z6";
			this.SHF_DATE_16.Top = 4.375F;
			this.SHF_DATE_16.Width = 0.563F;
			// 
			// SHF_DATE_17
			// 
			this.SHF_DATE_17.CanGrow = false;
			this.SHF_DATE_17.DataField = "SHF_DATE_17";
			this.SHF_DATE_17.Height = 0.168F;
			this.SHF_DATE_17.Left = 0.063F;
			this.SHF_DATE_17.Name = "SHF_DATE_17";
			this.SHF_DATE_17.OutputFormat = "yyyy/MM/dd";
			this.SHF_DATE_17.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SHF_DATE_17.Text = "ZZZ6/Z6/Z6";
			this.SHF_DATE_17.Top = 4.538F;
			this.SHF_DATE_17.Width = 0.563F;
			// 
			// ShfTypeName16Text
			// 
			this.ShfTypeName16Text.CanGrow = false;
			this.ShfTypeName16Text.DataField = "SHF_TYPE_NAME_16";
			this.ShfTypeName16Text.Height = 0.168F;
			this.ShfTypeName16Text.Left = 0.625F;
			this.ShfTypeName16Text.Name = "ShfTypeName16Text";
			this.ShfTypeName16Text.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ShfTypeName16Text.Text = "ああああああああ";
			this.ShfTypeName16Text.Top = 4.375F;
			this.ShfTypeName16Text.Width = 0.875F;
			// 
			// Line178
			// 
			this.Line178.Height = 0F;
			this.Line178.Left = 0.063F;
			this.Line178.LineWeight = 1F;
			this.Line178.Name = "Line178";
			this.Line178.Top = 4.704F;
			this.Line178.Width = 7.037F;
			this.Line178.X1 = 0.063F;
			this.Line178.X2 = 7.1F;
			this.Line178.Y1 = 4.704F;
			this.Line178.Y2 = 4.704F;
			// 
			// Line162
			// 
			this.Line162.Height = 0F;
			this.Line162.Left = 0.063F;
			this.Line162.LineWeight = 1F;
			this.Line162.Name = "Line162";
			this.Line162.Top = 2.016F;
			this.Line162.Width = 7.037F;
			this.Line162.X1 = 0.063F;
			this.Line162.X2 = 7.1F;
			this.Line162.Y1 = 2.016F;
			this.Line162.Y2 = 2.016F;
			// 
			// Line247
			// 
			this.Line247.Height = 1.008F;
			this.Line247.Left = 1.187F;
			this.Line247.LineWeight = 1F;
			this.Line247.Name = "Line247";
			this.Line247.Top = 5.376F;
			this.Line247.Width = 0F;
			this.Line247.X1 = 1.187F;
			this.Line247.X2 = 1.187F;
			this.Line247.Y1 = 5.376F;
			this.Line247.Y2 = 6.384F;
			// 
			// Line233
			// 
			this.Line233.Height = 3.528001F;
			this.Line233.Left = 0.625F;
			this.Line233.LineWeight = 1F;
			this.Line233.Name = "Line233";
			this.Line233.Top = 1.68F;
			this.Line233.Width = 0F;
			this.Line233.X1 = 0.625F;
			this.Line233.X2 = 0.625F;
			this.Line233.Y1 = 1.68F;
			this.Line233.Y2 = 5.208001F;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label1,
            this.ReportIDText,
            this.TextBox236,
            this.Label174,
            this.Label3,
            this.DateText});
			this.PageHeader.Height = 0.5729167F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			// 
			// Label1
			// 
			this.Label1.Height = 0.25F;
			this.Label1.HyperLink = null;
			this.Label1.Left = 2.197917F;
			this.Label1.Name = "Label1";
			this.Label1.Style = "font-size: 14pt; font-weight: normal; text-align: center; ddo-char-set: 1";
			this.Label1.Text = "個人経歴書";
			this.Label1.Top = 0F;
			this.Label1.Width = 2.875F;
			// 
			// ReportIDText
			// 
			this.ReportIDText.CanGrow = false;
			this.ReportIDText.Height = 0.1875F;
			this.ReportIDText.Left = 0.0625F;
			this.ReportIDText.Name = "ReportIDText";
			this.ReportIDText.Style = "font-size: 9pt; white-space: nowrap; ddo-char-set: 1";
			this.ReportIDText.Text = "(HR_PA_03_R07)";
			this.ReportIDText.Top = 0F;
			this.ReportIDText.Width = 1.6875F;
			// 
			// TextBox236
			// 
			this.TextBox236.CanGrow = false;
			this.TextBox236.DataField = "PRESENT_DATE";
			this.TextBox236.Height = 0.1875F;
			this.TextBox236.Left = 3.0625F;
			this.TextBox236.Name = "TextBox236";
			this.TextBox236.OutputFormat = "yyyy/MM/dd";
			this.TextBox236.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TextBox236.Text = "ZZZ6/Z6/Z6";
			this.TextBox236.Top = 0.375F;
			this.TextBox236.Width = 0.8125F;
			// 
			// Label174
			// 
			this.Label174.Height = 0.1875F;
			this.Label174.HyperLink = null;
			this.Label174.Left = 3.75F;
			this.Label174.Name = "Label174";
			this.Label174.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 1";
			this.Label174.Text = "現在";
			this.Label174.Top = 0.375F;
			this.Label174.Width = 0.375F;
			// 
			// Label3
			// 
			this.Label3.Height = 0.1875F;
			this.Label3.HyperLink = null;
			this.Label3.Left = 5.1875F;
			this.Label3.Name = "Label3";
			this.Label3.Style = "font-size: 9pt; ddo-char-set: 1";
			this.Label3.Text = "作成日時：";
			this.Label3.Top = 0.0625F;
			this.Label3.Width = 0.6875F;
			// 
			// DateText
			// 
			this.DateText.CanGrow = false;
			this.DateText.Height = 0.188F;
			this.DateText.Left = 5.8125F;
			this.DateText.Name = "DateText";
			this.DateText.Style = "font-size: 9pt; text-align: left; white-space: nowrap; ddo-char-set: 1";
			this.DateText.Text = "6666/66/66 66:66:66";
			this.DateText.Top = 0.0625F;
			this.DateText.Width = 1.25F;
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.CompanyNameText});
			this.PageFooter.Height = 0.1875F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Format += new System.EventHandler(this.PageFooter_Format);
			// 
			// CompanyNameText
			// 
			this.CompanyNameText.CanGrow = false;
			this.CompanyNameText.Height = 0.188F;
			this.CompanyNameText.Left = 0.5104167F;
			this.CompanyNameText.Name = "CompanyNameText";
			this.CompanyNameText.Style = "font-size: 9pt; text-align: right; white-space: nowrap; ddo-char-set: 1";
			this.CompanyNameText.Text = null;
			this.CompanyNameText.Top = 0F;
			this.CompanyNameText.Width = 6.590001F;
			// 
			// HR_PA_03_R07
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.5F;
			this.PageSettings.Margins.Left = 0.7F;
			this.PageSettings.Margins.Right = 0.4F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.268056F;
			this.PrintWidth = 7.12F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PA_03_R07_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.Label180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label179)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label178)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjToDateText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName17Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName16Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName20Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName19Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName17Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName18Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCodeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastEduNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpNameKanaText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthServYyText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label107)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MarriYmdText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label110)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChangeDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfDate15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Job1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Job2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Job3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Job4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Job5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label134)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDateText5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpTodate9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpFromDate9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkExpName9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label152)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniFrom6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TraniName6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfObtainDate5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label159)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RwdPntName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveFromdate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveTodate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpRemarks9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReason4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndType6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox235)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName10Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName10Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName11Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName12Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName13Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName14Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName15Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName11Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName12Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName13Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName14Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName15Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName18Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName19Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacName20Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightType3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurTodate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfName5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObtainType5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthServMmText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth6Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth7Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth8Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodYear9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WordExpPeriodMonth9Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetirementDate5Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label176)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConcurAtacName4Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdJPText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateJPText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDate2JPText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SHF_DATE_17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShfTypeName16Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox236)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
