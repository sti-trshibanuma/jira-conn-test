// Product     : Allegro
// Unit        : HR
// Module      : PA
// Function    : 03
// File Name   : HR_PA_03_R99.cs
// 機能名      : HR_PA_03_R99 個人基本情報(サブレポート)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 K24565 2012/10/04 ActiveReportsバージョンアップ対応
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
	public class HR_PA_03_R99 : GrapeCity.ActiveReports.SectionReport
	{

		public HR_PA_03_R99()
		{


			InitializeComponent();
		}

		#region Properties
		#endregion


		#region Protected Fields
		#endregion

		private void HR_PA_03_R01_ReportStart(object sender, System.EventArgs eArgs)
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
		}


		#region ActiveReports Designer generated code

		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HousingRentTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label172 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TransferName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label173 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label119 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label87 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TransferDate1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label68 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HousingAlowNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox StrMovingInYmdTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label118 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label206 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label205 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OwnHouseTypeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label85 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label89 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SubjName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SubjName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SubjName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SubjName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FacultyName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FacultyName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FacultyName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FacultyName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line294 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line293 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYm4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntraYm1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label86 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label88 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label168 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label169 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label170 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label171 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label163 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label204 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label69 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label70 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveReasonTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label203 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label202 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostAtacName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostAtacName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostAtacName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostAtacName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label48 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostAtacName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDate2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDate5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDate4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDate3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjFromDate1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjCodeSbno5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjShortName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjCodeSbno4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjCodeSbno3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjCodeSbno2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjCodeSbno1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label191 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label189 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label190 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label47 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label51 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label52 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobStayPerodY = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnFrom4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OwnTypeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label78 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnFrom1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnFrom3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnFrom2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label188 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ExpenAtacCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfJobCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GradeCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServPlCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label42 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label41 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label40 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label30 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label28 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label27 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label26 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label25 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label24 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label21 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line196 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line231 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label23 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line250 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label43 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ExpenAtacChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label44 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfJobChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServPlChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostFromDate1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostFromDate5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostFromDate4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostFromDate3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostFromDate2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName6extBox73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ItemShortName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line285 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label71 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label72 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label73 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacStayPerodTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line286 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox OptItemName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label79 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label80 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label81 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label82 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line296 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnTo1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnTo4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnTo2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnTo3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnMeansName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnMeansName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnMeansName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnMeansName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnspAlowAmt4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remarks1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnspAlowAmt1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnspAlowAmt3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TrnspAlowAmt2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remarks4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remarks3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Remarks2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label150 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LeaveStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label151 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AtacChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostStayPerpdYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfJobStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label154 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label155 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label157 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label158 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfJobStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label160 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label161 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodY1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label162 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodM1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodY2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodY5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodY3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodY4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label164 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label165 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label166 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label167 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodM2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodM3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodM4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AddPostStayPerodM5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line329 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line330 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line331 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line332 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line333 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EepenAtacNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServPlNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox QualfJobNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GradeNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DutyNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PostNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line334 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line336 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line238 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line235 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ExpenStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label176 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ExpenStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label177 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label180 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label181 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ServStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label182 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label183 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RankStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PrmtDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GradeStayPerodYTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label184 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GradeStayPerodMTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label185 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line273 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label186 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobStayPerodM = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label187 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line237 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line345 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line275 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line234 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line337 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line232 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line225 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line223 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodY1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label192 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodM1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label193 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodY2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label194 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodM2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label195 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodY3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label196 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodM3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label197 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodY4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label198 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodM4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label199 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodY5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label200 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ProjStayPerodM5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label201 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line341 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line342 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line343 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line339 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line340 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line347 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line348 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line349 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line350 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line351 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line266 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line198 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line352 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line264 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line353 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line354 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line355 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line356 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line357 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line276 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line214 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line257 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line358 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line359 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line360 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line361 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line252 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line291 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line362 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line363 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line364 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line365 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line366 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line314 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line344 = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PA_03_R99));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.HousingRentTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label172 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TransferName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label173 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label119 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label87 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TransferDate1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label68 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HousingAlowNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.StrMovingInYmdTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label118 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label206 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label205 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.OwnHouseTypeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label85 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GraduType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label89 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SubjName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubjName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubjName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubjName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FacultyName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FacultyName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FacultyName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FacultyName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SchoolName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line294 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line293 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.GraduYm1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GraduYm4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntraYm2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntraYm3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntraYm4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntraYm1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label86 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ClsName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label88 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label168 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label169 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label170 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label171 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label163 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label204 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label69 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label70 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LeaveReasonTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label203 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ItemShortName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label202 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AddPostAtacName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostAtacName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostAtacName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostAtacName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AddPostAtacName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDate2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDate5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDate4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDate3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjFromDate1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjCodeSbno5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjShortName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjCodeSbno4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjCodeSbno3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjCodeSbno2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ProjCodeSbno1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label191 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label189 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label190 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label51 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label52 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.JobStayPerodY = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnFrom4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OwnTypeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label78 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TrnFrom1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnFrom3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnFrom2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label188 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ExpenAtacCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfJobCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GradeCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DutyCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PostCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RankCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ServPlCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label42 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label41 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label40 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label30 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label28 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label27 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label26 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label25 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label24 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label21 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line196 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line231 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label23 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line250 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label43 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ExpenAtacChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.QualfJobChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DutyChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PostChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RankChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ServPlChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostFromDate1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostFromDate5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostFromDate4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostFromDate3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostFromDate2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OptItemName6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemShortName6extBox73 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemShortName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemShortName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemShortName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ItemShortName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line285 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.LeaveStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label71 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label72 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label73 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AtacStayPerodTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line286 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.OptItemName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OptItemName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OptItemName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OptItemName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.OptItemName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label79 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label80 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label81 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label82 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line296 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.ClsName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ClsName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ClsName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnTo1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnTo4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnTo2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnTo3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnMeansName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnMeansName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnMeansName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnMeansName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnspAlowAmt4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remarks1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnspAlowAmt1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnspAlowAmt3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TrnspAlowAmt2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remarks4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remarks3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Remarks2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AtacStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LeaveStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AtacChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PostStayPerpdYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DutyStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfJobStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label157 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PostStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label158 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DutyStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfJobStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label160 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label161 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AddPostStayPerodY1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label162 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AddPostStayPerodM1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodY2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodY5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodY3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodY4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label164 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label165 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label166 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label167 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AddPostStayPerodM2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodM3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodM4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AddPostStayPerodM5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line329 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line330 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line331 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line332 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line333 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.EepenAtacNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ServPlNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.QualfJobNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GradeNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DutyNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PostNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RankNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line334 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line336 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line238 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line235 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.ExpenStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label176 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ExpenStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label177 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label180 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ServStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label181 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ServStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label182 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RankStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label183 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RankStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PrmtDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GradeStayPerodYTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label184 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GradeStayPerodMTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label185 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line273 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label186 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.JobStayPerodM = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label187 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line237 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line345 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line275 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line234 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line337 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line232 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line225 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line223 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.ProjStayPerodY1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label192 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodM1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label193 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodY2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label194 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodM2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label195 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodY3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label196 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodM3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label197 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodY4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label198 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodM4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label199 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodY5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label200 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ProjStayPerodM5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label201 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line341 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line342 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line343 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line339 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line340 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line347 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line348 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line349 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line350 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line351 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line266 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line198 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line352 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line264 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line353 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line354 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line355 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line356 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line357 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line276 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line214 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line257 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line358 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line359 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line360 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line361 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line252 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line291 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line362 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line363 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line364 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line365 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line366 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line314 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line344 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			((System.ComponentModel.ISupportInitialize)(this.HousingRentTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label172)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TransferName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label173)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label119)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label87)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TransferDate1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingAlowNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StrMovingInYmdTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label118)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label206)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label205)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OwnHouseTypeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label85)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label89)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label86)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label88)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label168)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label169)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label170)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label171)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label204)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReasonTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label203)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label202)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label191)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label189)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label190)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobStayPerodY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OwnTypeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label188)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenAtacCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenAtacChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName6extBox73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacStayPerodTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label82)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostStayPerpdYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label167)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EepenAtacNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PostNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label176)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label181)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label182)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label183)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RankStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PrmtDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeStayPerodYTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label184)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeStayPerodMTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label185)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label186)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobStayPerodM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label187)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label192)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label193)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label194)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label195)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label196)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label197)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label198)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label199)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label200)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label201)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.HousingRentTextBox,
            this.Label172,
            this.TransferName1TextBox,
            this.Label173,
            this.Label119,
            this.Label87,
            this.TransferDate1TextBox,
            this.Label68,
            this.HousingAlowNameTextBox,
            this.StrMovingInYmdTextBox,
            this.Label118,
            this.Label206,
            this.Label205,
            this.OwnHouseTypeTextBox,
            this.Label85,
            this.GraduType4TextBox,
            this.GraduType3TextBox,
            this.GraduType2TextBox,
            this.GraduType1TextBox,
            this.Label89,
            this.SubjName2TextBox,
            this.SubjName1TextBox,
            this.SubjName3TextBox,
            this.SubjName4TextBox,
            this.FacultyName2TextBox,
            this.FacultyName3TextBox,
            this.FacultyName4TextBox,
            this.FacultyName1TextBox,
            this.SchoolName2TextBox,
            this.SchoolName3TextBox,
            this.SchoolName4TextBox,
            this.SchoolName1TextBox,
            this.Line294,
            this.Line293,
            this.GraduYm1TextBox,
            this.GraduYm2TextBox,
            this.GraduYm3TextBox,
            this.GraduYm4TextBox,
            this.EntraYm2TextBox,
            this.EntraYm3TextBox,
            this.EntraYm4TextBox,
            this.EntraYm1TextBox,
            this.Label86,
            this.ClsName1TextBox,
            this.Label88,
            this.Label168,
            this.Label169,
            this.Label170,
            this.Label171,
            this.Label163,
            this.Label204,
            this.Label69,
            this.Label70,
            this.LeaveReasonTextBox,
            this.Label203,
            this.ItemShortName1TextBox,
            this.Label202,
            this.AddPostAtacName5TextBox,
            this.AddPostAtacName4TextBox,
            this.AddPostAtacName3TextBox,
            this.AddPostAtacName2TextBox,
            this.Label48,
            this.AddPostAtacName1TextBox,
            this.ProjFromDate2TextBox,
            this.ProjFromDate5TextBox,
            this.ProjFromDate4TextBox,
            this.ProjFromDate3TextBox,
            this.ProjFromDate1TextBox,
            this.ProjShortName2TextBox,
            this.ProjCodeSbno5TextBox,
            this.ProjShortName5TextBox,
            this.ProjShortName4TextBox,
            this.ProjShortName3TextBox,
            this.ProjShortName1TextBox,
            this.ProjCodeSbno4TextBox,
            this.ProjCodeSbno3TextBox,
            this.ProjCodeSbno2TextBox,
            this.ProjCodeSbno1TextBox,
            this.Label191,
            this.Label189,
            this.Label190,
            this.Label47,
            this.Label51,
            this.Label52,
            this.JobStayPerodY,
            this.JobChgDateTextBox,
            this.TrnFrom4TextBox,
            this.OwnTypeTextBox,
            this.Label78,
            this.TrnFrom1TextBox,
            this.TrnFrom3TextBox,
            this.TrnFrom2TextBox,
            this.Label188,
            this.ExpenAtacCodeTextBox,
            this.JobCodeTextBox,
            this.QualfJobCodeTextBox,
            this.GradeCodeTextBox,
            this.DutyCodeTextBox,
            this.PostCodeTextBox,
            this.RankCodeTextBox,
            this.ServPlCodeTextBox,
            this.AtacCodeTextBox,
            this.Label42,
            this.Label41,
            this.Label40,
            this.Label30,
            this.Label28,
            this.Label27,
            this.Label26,
            this.Label25,
            this.Label24,
            this.Label21,
            this.Line196,
            this.Line231,
            this.Label23,
            this.Line250,
            this.Label43,
            this.ExpenAtacChgDateTextBox,
            this.Label44,
            this.QualfJobChgDateTextBox,
            this.DutyChgDateTextBox,
            this.PostChgDateTextBox,
            this.RankChgDateTextBox,
            this.ServPlChgDateTextBox,
            this.AddPostName1TextBox,
            this.AddPostName5TextBox,
            this.AddPostName3TextBox,
            this.AddPostName2TextBox,
            this.AddPostName4TextBox,
            this.AddPostFromDate1TextBox,
            this.AtacNameTextBox,
            this.AddPostFromDate5TextBox,
            this.AddPostFromDate4TextBox,
            this.AddPostFromDate3TextBox,
            this.AddPostFromDate2TextBox,
            this.OptItemName6TextBox,
            this.ItemShortName6extBox73,
            this.ItemShortName5TextBox,
            this.ItemShortName4TextBox,
            this.ItemShortName3TextBox,
            this.ItemShortName2TextBox,
            this.Line285,
            this.LeaveStayPerodYTextBox,
            this.Label71,
            this.Label72,
            this.Label73,
            this.AtacStayPerodTextBox,
            this.Line286,
            this.OptItemName1TextBox,
            this.OptItemName2TextBox,
            this.OptItemName3TextBox,
            this.OptItemName4TextBox,
            this.OptItemName5TextBox,
            this.Label79,
            this.Label80,
            this.Label81,
            this.Label82,
            this.Line296,
            this.ClsName4TextBox,
            this.ClsName3TextBox,
            this.ClsName2TextBox,
            this.TrnTo1TextBox,
            this.TrnTo4TextBox,
            this.TrnTo2TextBox,
            this.TrnTo3TextBox,
            this.TrnMeansName1TextBox,
            this.TrnMeansName2TextBox,
            this.TrnMeansName3TextBox,
            this.TrnMeansName4TextBox,
            this.TrnspAlowAmt4TextBox,
            this.Remarks1TextBox,
            this.TrnspAlowAmt1TextBox,
            this.TrnspAlowAmt3TextBox,
            this.TrnspAlowAmt2TextBox,
            this.Remarks4TextBox,
            this.Remarks3TextBox,
            this.Remarks2TextBox,
            this.AtacStayPerodYTextBox,
            this.Label150,
            this.LeaveStayPerodMTextBox,
            this.Label151,
            this.AtacChgDateTextBox,
            this.PostStayPerpdYTextBox,
            this.DutyStayPerodYTextBox,
            this.QualfJobStayPerodYTextBox,
            this.Label154,
            this.Label155,
            this.Label157,
            this.PostStayPerodMTextBox,
            this.Label158,
            this.DutyStayPerodMTextBox,
            this.QualfJobStayPerodMTextBox,
            this.Label160,
            this.Label161,
            this.AddPostStayPerodY1TextBox,
            this.Label162,
            this.AddPostStayPerodM1TextBox,
            this.AddPostStayPerodY2TextBox,
            this.AddPostStayPerodY5TextBox,
            this.AddPostStayPerodY3TextBox,
            this.AddPostStayPerodY4TextBox,
            this.Label164,
            this.Label165,
            this.Label166,
            this.Label167,
            this.AddPostStayPerodM2TextBox,
            this.AddPostStayPerodM3TextBox,
            this.AddPostStayPerodM4TextBox,
            this.AddPostStayPerodM5TextBox,
            this.Line329,
            this.Line330,
            this.Line331,
            this.Line332,
            this.Line333,
            this.EepenAtacNameTextBox,
            this.ServPlNameTextBox,
            this.JobNameTextBox,
            this.QualfJobNameTextBox,
            this.GradeNameTextBox,
            this.DutyNameTextBox,
            this.PostNameTextBox,
            this.RankNameTextBox,
            this.Line334,
            this.Line336,
            this.Line238,
            this.Line235,
            this.ExpenStayPerodYTextBox,
            this.Label176,
            this.ExpenStayPerodMTextBox,
            this.Label177,
            this.Label180,
            this.ServStayPerodMTextBox,
            this.Label181,
            this.ServStayPerodYTextBox,
            this.Label182,
            this.RankStayPerodMTextBox,
            this.Label183,
            this.RankStayPerodYTextBox,
            this.PrmtDateTextBox,
            this.GradeStayPerodYTextBox,
            this.Label184,
            this.GradeStayPerodMTextBox,
            this.Label185,
            this.Line273,
            this.Label186,
            this.JobStayPerodM,
            this.Label187,
            this.Line237,
            this.Line345,
            this.Line275,
            this.Line234,
            this.Line337,
            this.Line232,
            this.Line225,
            this.Line223,
            this.ProjStayPerodY1TextBox,
            this.Label192,
            this.ProjStayPerodM1TextBox,
            this.Label193,
            this.ProjStayPerodY2TextBox,
            this.Label194,
            this.ProjStayPerodM2TextBox,
            this.Label195,
            this.ProjStayPerodY3TextBox,
            this.Label196,
            this.ProjStayPerodM3TextBox,
            this.Label197,
            this.ProjStayPerodY4TextBox,
            this.Label198,
            this.ProjStayPerodM4TextBox,
            this.Label199,
            this.ProjStayPerodY5TextBox,
            this.Label200,
            this.ProjStayPerodM5TextBox,
            this.Label201,
            this.Line341,
            this.Line342,
            this.Line343,
            this.Line339,
            this.Line340,
            this.Line347,
            this.Line348,
            this.Line349,
            this.Line350,
            this.Line351,
            this.Line266,
            this.Line198,
            this.Line352,
            this.Line264,
            this.Line353,
            this.Line354,
            this.Line355,
            this.Line356,
            this.Line357,
            this.Line276,
            this.Line214,
            this.Line257,
            this.Line358,
            this.Line359,
            this.Line360,
            this.Line361,
            this.Line252,
            this.Line291,
            this.Line362,
            this.Line363,
            this.Line364,
            this.Line365,
            this.Line366,
            this.Line314,
            this.Line344});
			this.Detail.Height = 6.666667F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// HousingRentTextBox
			// 
			this.HousingRentTextBox.CanGrow = false;
			this.HousingRentTextBox.DataField = "HOUSING_RENT";
			this.HousingRentTextBox.Height = 0.1666667F;
			this.HousingRentTextBox.Left = 1.753917F;
			this.HousingRentTextBox.Name = "HousingRentTextBox";
			this.HousingRentTextBox.OutputFormat = "#,##0";
			this.HousingRentTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingRentTextBox.Text = "z,zzz,zz6";
			this.HousingRentTextBox.Top = 4.19794F;
			this.HousingRentTextBox.Width = 0.5F;
			// 
			// Label172
			// 
			this.Label172.Height = 0.1666667F;
			this.Label172.HyperLink = null;
			this.Label172.Left = 1.441417F;
			this.Label172.Name = "Label172";
			this.Label172.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label172.Text = "家賃";
			this.Label172.Top = 4.19794F;
			this.Label172.Width = 0.3333333F;
			// 
			// TransferName1TextBox
			// 
			this.TransferName1TextBox.CanGrow = false;
			this.TransferName1TextBox.DataField = "TRANSFER_NAME1";
			this.TransferName1TextBox.Height = 0.1666667F;
			this.TransferName1TextBox.Left = 1.431F;
			this.TransferName1TextBox.Name = "TransferName1TextBox";
			this.TransferName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TransferName1TextBox.Text = "あいうえおかきくけこ";
			this.TransferName1TextBox.Top = 5.29169F;
			this.TransferName1TextBox.Width = 1.916667F;
			// 
			// Label173
			// 
			this.Label173.Height = 0.1666667F;
			this.Label173.HyperLink = null;
			this.Label173.Left = 2.253917F;
			this.Label173.Name = "Label173";
			this.Label173.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label173.Text = "入居";
			this.Label173.Top = 4.19794F;
			this.Label173.Width = 0.3125F;
			// 
			// Label119
			// 
			this.Label119.Height = 0.1666667F;
			this.Label119.HyperLink = null;
			this.Label119.Left = 2.451833F;
			this.Label119.Name = "Label119";
			this.Label119.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label119.Text = "学部";
			this.Label119.Top = 3.41669F;
			this.Label119.Width = 1.010417F;
			// 
			// Label87
			// 
			this.Label87.Height = 0.1666667F;
			this.Label87.HyperLink = null;
			this.Label87.Left = 1.441417F;
			this.Label87.Name = "Label87";
			this.Label87.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label87.Text = "学校名";
			this.Label87.Top = 3.41669F;
			this.Label87.Width = 1.020833F;
			// 
			// TransferDate1TextBox
			// 
			this.TransferDate1TextBox.CanGrow = false;
			this.TransferDate1TextBox.DataField = "TRANSFER_DATE1";
			this.TransferDate1TextBox.Height = 0.1666667F;
			this.TransferDate1TextBox.Left = 0.4414172F;
			this.TransferDate1TextBox.Name = "TransferDate1TextBox";
			this.TransferDate1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TransferDate1TextBox.Text = "zzz6年z6月z6日";
			this.TransferDate1TextBox.Top = 5.29169F;
			this.TransferDate1TextBox.Width = 1F;
			// 
			// Label68
			// 
			this.Label68.Height = 0.1666667F;
			this.Label68.HyperLink = null;
			this.Label68.Left = 0.4414172F;
			this.Label68.Name = "Label68";
			this.Label68.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label68.Text = "出向日付";
			this.Label68.Top = 5.13544F;
			this.Label68.Width = 1F;
			// 
			// HousingAlowNameTextBox
			// 
			this.HousingAlowNameTextBox.CanGrow = false;
			this.HousingAlowNameTextBox.DataField = "HOUSING_ALOW_NAME";
			this.HousingAlowNameTextBox.Height = 0.1666667F;
			this.HousingAlowNameTextBox.Left = 3.264332F;
			this.HousingAlowNameTextBox.Name = "HousingAlowNameTextBox";
			this.HousingAlowNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.HousingAlowNameTextBox.Text = "あいうえおかきくけこさしすせそなにぬね";
			this.HousingAlowNameTextBox.Top = 4.19794F;
			this.HousingAlowNameTextBox.Width = 1.927083F;
			// 
			// StrMovingInYmdTextBox
			// 
			this.StrMovingInYmdTextBox.CanGrow = false;
			this.StrMovingInYmdTextBox.DataField = "STR_MOVING_IN_YMD";
			this.StrMovingInYmdTextBox.Height = 0.1666667F;
			this.StrMovingInYmdTextBox.Left = 2.566417F;
			this.StrMovingInYmdTextBox.Name = "StrMovingInYmdTextBox";
			this.StrMovingInYmdTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.StrMovingInYmdTextBox.Text = "zzz6年z6月z6日";
			this.StrMovingInYmdTextBox.Top = 4.19794F;
			this.StrMovingInYmdTextBox.Width = 0.6875F;
			// 
			// Label118
			// 
			this.Label118.Height = 0.1666667F;
			this.Label118.HyperLink = null;
			this.Label118.Left = 3.451832F;
			this.Label118.Name = "Label118";
			this.Label118.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label118.Text = "学科";
			this.Label118.Top = 3.41669F;
			this.Label118.Width = 0.90625F;
			// 
			// Label206
			// 
			this.Label206.Height = 0.9520833F;
			this.Label206.HyperLink = null;
			this.Label206.Left = 0.004417419F;
			this.Label206.Name = "Label206";
			this.Label206.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label206.Text = "住宅通勤情報";
			this.Label206.Top = 4.195439F;
			this.Label206.Width = 0.4445834F;
			// 
			// Label205
			// 
			this.Label205.Height = 0.80625F;
			this.Label205.HyperLink = null;
			this.Label205.Left = 0.004417419F;
			this.Label205.Name = "Label205";
			this.Label205.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label205.Text = "学歴情報";
			this.Label205.Top = 3.41419F;
			this.Label205.Width = 0.4445834F;
			// 
			// OwnHouseTypeTextBox
			// 
			this.OwnHouseTypeTextBox.CanGrow = false;
			this.OwnHouseTypeTextBox.DataField = "OWN_HOUSE_TYPE";
			this.OwnHouseTypeTextBox.Height = 0.1666667F;
			this.OwnHouseTypeTextBox.Left = 0.9518332F;
			this.OwnHouseTypeTextBox.Name = "OwnHouseTypeTextBox";
			this.OwnHouseTypeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OwnHouseTypeTextBox.Text = "あいうえお";
			this.OwnHouseTypeTextBox.Top = 4.19794F;
			this.OwnHouseTypeTextBox.Width = 0.5F;
			// 
			// Label85
			// 
			this.Label85.Height = 0.1666667F;
			this.Label85.HyperLink = null;
			this.Label85.Left = 0.4414172F;
			this.Label85.Name = "Label85";
			this.Label85.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label85.Text = "入学年月";
			this.Label85.Top = 3.41669F;
			this.Label85.Width = 0.5208333F;
			// 
			// GraduType4TextBox
			// 
			this.GraduType4TextBox.CanGrow = false;
			this.GraduType4TextBox.DataField = "GRADU_TYPE_4";
			this.GraduType4TextBox.Height = 0.1666667F;
			this.GraduType4TextBox.Left = 4.347666F;
			this.GraduType4TextBox.Name = "GraduType4TextBox";
			this.GraduType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.GraduType4TextBox.Text = "あい";
			this.GraduType4TextBox.Top = 4.041689F;
			this.GraduType4TextBox.Width = 0.2291667F;
			// 
			// GraduType3TextBox
			// 
			this.GraduType3TextBox.CanGrow = false;
			this.GraduType3TextBox.DataField = "GRADU_TYPE_3";
			this.GraduType3TextBox.Height = 0.1666667F;
			this.GraduType3TextBox.Left = 4.347666F;
			this.GraduType3TextBox.Name = "GraduType3TextBox";
			this.GraduType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.GraduType3TextBox.Text = "あい";
			this.GraduType3TextBox.Top = 3.88544F;
			this.GraduType3TextBox.Width = 0.2291667F;
			// 
			// GraduType2TextBox
			// 
			this.GraduType2TextBox.CanGrow = false;
			this.GraduType2TextBox.DataField = "GRADU_TYPE_2";
			this.GraduType2TextBox.Height = 0.1666667F;
			this.GraduType2TextBox.Left = 4.347666F;
			this.GraduType2TextBox.Name = "GraduType2TextBox";
			this.GraduType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.GraduType2TextBox.Text = "あい";
			this.GraduType2TextBox.Top = 3.72919F;
			this.GraduType2TextBox.Width = 0.2291667F;
			// 
			// GraduType1TextBox
			// 
			this.GraduType1TextBox.CanGrow = false;
			this.GraduType1TextBox.DataField = "GRADU_TYPE_1";
			this.GraduType1TextBox.Height = 0.1666667F;
			this.GraduType1TextBox.Left = 4.347666F;
			this.GraduType1TextBox.Name = "GraduType1TextBox";
			this.GraduType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.GraduType1TextBox.Text = "あい";
			this.GraduType1TextBox.Top = 3.57294F;
			this.GraduType1TextBox.Width = 0.2291667F;
			// 
			// Label89
			// 
			this.Label89.Height = 0.1666667F;
			this.Label89.HyperLink = null;
			this.Label89.Left = 4.347666F;
			this.Label89.Name = "Label89";
			this.Label89.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label89.Text = "卒業";
			this.Label89.Top = 3.41669F;
			this.Label89.Width = 0.2291667F;
			// 
			// SubjName2TextBox
			// 
			this.SubjName2TextBox.CanGrow = false;
			this.SubjName2TextBox.DataField = "SUBJ_NAME_2";
			this.SubjName2TextBox.Height = 0.1666667F;
			this.SubjName2TextBox.Left = 3.441416F;
			this.SubjName2TextBox.Name = "SubjName2TextBox";
			this.SubjName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SubjName2TextBox.Text = "あいうえおかきくけ";
			this.SubjName2TextBox.Top = 3.72919F;
			this.SubjName2TextBox.Width = 0.90625F;
			// 
			// SubjName1TextBox
			// 
			this.SubjName1TextBox.CanGrow = false;
			this.SubjName1TextBox.DataField = "SUBJ_NAME_1";
			this.SubjName1TextBox.Height = 0.1666667F;
			this.SubjName1TextBox.Left = 3.441416F;
			this.SubjName1TextBox.Name = "SubjName1TextBox";
			this.SubjName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SubjName1TextBox.Text = "あいうえおかきくけ";
			this.SubjName1TextBox.Top = 3.57294F;
			this.SubjName1TextBox.Width = 0.90625F;
			// 
			// SubjName3TextBox
			// 
			this.SubjName3TextBox.CanGrow = false;
			this.SubjName3TextBox.DataField = "SUBJ_NAME_3";
			this.SubjName3TextBox.Height = 0.1666667F;
			this.SubjName3TextBox.Left = 3.441416F;
			this.SubjName3TextBox.Name = "SubjName3TextBox";
			this.SubjName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SubjName3TextBox.Text = "あいうえおかきくけ";
			this.SubjName3TextBox.Top = 3.88544F;
			this.SubjName3TextBox.Width = 0.90625F;
			// 
			// SubjName4TextBox
			// 
			this.SubjName4TextBox.CanGrow = false;
			this.SubjName4TextBox.DataField = "SUBJ_NAME_4";
			this.SubjName4TextBox.Height = 0.1666667F;
			this.SubjName4TextBox.Left = 3.441416F;
			this.SubjName4TextBox.Name = "SubjName4TextBox";
			this.SubjName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SubjName4TextBox.Text = "あいうえおかきくけ";
			this.SubjName4TextBox.Top = 4.04169F;
			this.SubjName4TextBox.Width = 0.90625F;
			// 
			// FacultyName2TextBox
			// 
			this.FacultyName2TextBox.CanGrow = false;
			this.FacultyName2TextBox.DataField = "FACULTY_NAME_2";
			this.FacultyName2TextBox.Height = 0.1666667F;
			this.FacultyName2TextBox.Left = 2.451833F;
			this.FacultyName2TextBox.Name = "FacultyName2TextBox";
			this.FacultyName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FacultyName2TextBox.Text = "あいうえおかきくけこ";
			this.FacultyName2TextBox.Top = 3.72919F;
			this.FacultyName2TextBox.Width = 1.010417F;
			// 
			// FacultyName3TextBox
			// 
			this.FacultyName3TextBox.CanGrow = false;
			this.FacultyName3TextBox.DataField = "FACULTY_NAME_3";
			this.FacultyName3TextBox.Height = 0.1666667F;
			this.FacultyName3TextBox.Left = 2.451833F;
			this.FacultyName3TextBox.Name = "FacultyName3TextBox";
			this.FacultyName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FacultyName3TextBox.Text = "あいうえおかきくけこ";
			this.FacultyName3TextBox.Top = 3.88544F;
			this.FacultyName3TextBox.Width = 1.010417F;
			// 
			// FacultyName4TextBox
			// 
			this.FacultyName4TextBox.CanGrow = false;
			this.FacultyName4TextBox.DataField = "FACULTY_NAME_4";
			this.FacultyName4TextBox.Height = 0.1666667F;
			this.FacultyName4TextBox.Left = 2.451833F;
			this.FacultyName4TextBox.Name = "FacultyName4TextBox";
			this.FacultyName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FacultyName4TextBox.Text = "あいうえおかきくけこ";
			this.FacultyName4TextBox.Top = 4.04169F;
			this.FacultyName4TextBox.Width = 1.010417F;
			// 
			// FacultyName1TextBox
			// 
			this.FacultyName1TextBox.CanGrow = false;
			this.FacultyName1TextBox.DataField = "FACULTY_NAME_1";
			this.FacultyName1TextBox.Height = 0.1666667F;
			this.FacultyName1TextBox.Left = 2.451833F;
			this.FacultyName1TextBox.Name = "FacultyName1TextBox";
			this.FacultyName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FacultyName1TextBox.Text = "あいうえおかきくけこ";
			this.FacultyName1TextBox.Top = 3.57294F;
			this.FacultyName1TextBox.Width = 1.010417F;
			// 
			// SchoolName2TextBox
			// 
			this.SchoolName2TextBox.CanGrow = false;
			this.SchoolName2TextBox.DataField = "SCHOOL_NAME_2";
			this.SchoolName2TextBox.Height = 0.15625F;
			this.SchoolName2TextBox.Left = 1.441417F;
			this.SchoolName2TextBox.Name = "SchoolName2TextBox";
			this.SchoolName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName2TextBox.Text = "あいうえおかきくけこ";
			this.SchoolName2TextBox.Top = 3.739606F;
			this.SchoolName2TextBox.Width = 1.020833F;
			// 
			// SchoolName3TextBox
			// 
			this.SchoolName3TextBox.CanGrow = false;
			this.SchoolName3TextBox.DataField = "SCHOOL_NAME_3";
			this.SchoolName3TextBox.Height = 0.1666667F;
			this.SchoolName3TextBox.Left = 1.441417F;
			this.SchoolName3TextBox.Name = "SchoolName3TextBox";
			this.SchoolName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName3TextBox.Text = "あいうえおかきくけこ";
			this.SchoolName3TextBox.Top = 3.88544F;
			this.SchoolName3TextBox.Width = 1.020833F;
			// 
			// SchoolName4TextBox
			// 
			this.SchoolName4TextBox.CanGrow = false;
			this.SchoolName4TextBox.DataField = "SCHOOL_NAME_4";
			this.SchoolName4TextBox.Height = 0.1666667F;
			this.SchoolName4TextBox.Left = 1.441417F;
			this.SchoolName4TextBox.Name = "SchoolName4TextBox";
			this.SchoolName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName4TextBox.Text = "あいうえおかきくけこ";
			this.SchoolName4TextBox.Top = 4.04169F;
			this.SchoolName4TextBox.Width = 1.020833F;
			// 
			// SchoolName1TextBox
			// 
			this.SchoolName1TextBox.CanGrow = false;
			this.SchoolName1TextBox.DataField = "SCHOOL_NAME_1";
			this.SchoolName1TextBox.Height = 0.1666667F;
			this.SchoolName1TextBox.Left = 1.441417F;
			this.SchoolName1TextBox.Name = "SchoolName1TextBox";
			this.SchoolName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolName1TextBox.Text = "あいうえおかきくけこ";
			this.SchoolName1TextBox.Top = 3.562523F;
			this.SchoolName1TextBox.Width = 1.020833F;
			// 
			// Line294
			// 
			this.Line294.Height = 0.7789991F;
			this.Line294.Left = 3.448359F;
			this.Line294.LineWeight = 1F;
			this.Line294.Name = "Line294";
			this.Line294.Top = 3.417024F;
			this.Line294.Width = 0F;
			this.Line294.X1 = 3.448359F;
			this.Line294.X2 = 3.448359F;
			this.Line294.Y1 = 3.417024F;
			this.Line294.Y2 = 4.196023F;
			// 
			// Line293
			// 
			this.Line293.Height = 0.7789991F;
			this.Line293.Left = 2.448361F;
			this.Line293.LineWeight = 1F;
			this.Line293.Name = "Line293";
			this.Line293.Top = 3.417024F;
			this.Line293.Width = 0F;
			this.Line293.X1 = 2.448361F;
			this.Line293.X2 = 2.448361F;
			this.Line293.Y1 = 3.417024F;
			this.Line293.Y2 = 4.196023F;
			// 
			// GraduYm1TextBox
			// 
			this.GraduYm1TextBox.CanGrow = false;
			this.GraduYm1TextBox.DataField = "GRADU_YM_1";
			this.GraduYm1TextBox.Height = 0.1666667F;
			this.GraduYm1TextBox.Left = 0.9518332F;
			this.GraduYm1TextBox.Name = "GraduYm1TextBox";
			this.GraduYm1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm1TextBox.Text = "zzz6年z6月";
			this.GraduYm1TextBox.Top = 3.57294F;
			this.GraduYm1TextBox.Width = 0.5F;
			// 
			// GraduYm2TextBox
			// 
			this.GraduYm2TextBox.CanGrow = false;
			this.GraduYm2TextBox.DataField = "GRADU_YM_2";
			this.GraduYm2TextBox.Height = 0.1666667F;
			this.GraduYm2TextBox.Left = 0.9518332F;
			this.GraduYm2TextBox.Name = "GraduYm2TextBox";
			this.GraduYm2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm2TextBox.Text = "zzz6年z6月";
			this.GraduYm2TextBox.Top = 3.72919F;
			this.GraduYm2TextBox.Width = 0.5F;
			// 
			// GraduYm3TextBox
			// 
			this.GraduYm3TextBox.CanGrow = false;
			this.GraduYm3TextBox.DataField = "GRADU_YM_3";
			this.GraduYm3TextBox.Height = 0.1666667F;
			this.GraduYm3TextBox.Left = 0.9518332F;
			this.GraduYm3TextBox.Name = "GraduYm3TextBox";
			this.GraduYm3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm3TextBox.Text = "zzz6年z6月";
			this.GraduYm3TextBox.Top = 3.88544F;
			this.GraduYm3TextBox.Width = 0.5F;
			// 
			// GraduYm4TextBox
			// 
			this.GraduYm4TextBox.CanGrow = false;
			this.GraduYm4TextBox.DataField = "GRADU_YM_4";
			this.GraduYm4TextBox.Height = 0.1666667F;
			this.GraduYm4TextBox.Left = 0.9518332F;
			this.GraduYm4TextBox.Name = "GraduYm4TextBox";
			this.GraduYm4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYm4TextBox.Text = "zzz6年z6月";
			this.GraduYm4TextBox.Top = 4.04169F;
			this.GraduYm4TextBox.Width = 0.5F;
			// 
			// EntraYm2TextBox
			// 
			this.EntraYm2TextBox.CanGrow = false;
			this.EntraYm2TextBox.DataField = "ENTRA_YM_2";
			this.EntraYm2TextBox.Height = 0.1666667F;
			this.EntraYm2TextBox.Left = 0.4414172F;
			this.EntraYm2TextBox.Name = "EntraYm2TextBox";
			this.EntraYm2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm2TextBox.Text = "zzz6年z6月";
			this.EntraYm2TextBox.Top = 3.72919F;
			this.EntraYm2TextBox.Width = 0.5208333F;
			// 
			// EntraYm3TextBox
			// 
			this.EntraYm3TextBox.CanGrow = false;
			this.EntraYm3TextBox.DataField = "ENTRA_YM_3";
			this.EntraYm3TextBox.Height = 0.1666667F;
			this.EntraYm3TextBox.Left = 0.4414172F;
			this.EntraYm3TextBox.Name = "EntraYm3TextBox";
			this.EntraYm3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm3TextBox.Text = "zzz6年z6月";
			this.EntraYm3TextBox.Top = 3.88544F;
			this.EntraYm3TextBox.Width = 0.5208333F;
			// 
			// EntraYm4TextBox
			// 
			this.EntraYm4TextBox.CanGrow = false;
			this.EntraYm4TextBox.DataField = "ENTRA_YM_4";
			this.EntraYm4TextBox.Height = 0.1666667F;
			this.EntraYm4TextBox.Left = 0.4414172F;
			this.EntraYm4TextBox.Name = "EntraYm4TextBox";
			this.EntraYm4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm4TextBox.Text = "zzz6年z6月";
			this.EntraYm4TextBox.Top = 4.04169F;
			this.EntraYm4TextBox.Width = 0.5208333F;
			// 
			// EntraYm1TextBox
			// 
			this.EntraYm1TextBox.CanGrow = false;
			this.EntraYm1TextBox.DataField = "ENTRA_YM_1";
			this.EntraYm1TextBox.Height = 0.1666667F;
			this.EntraYm1TextBox.Left = 0.4414172F;
			this.EntraYm1TextBox.Name = "EntraYm1TextBox";
			this.EntraYm1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntraYm1TextBox.Text = "zzz6年z6月";
			this.EntraYm1TextBox.Top = 3.57294F;
			this.EntraYm1TextBox.Width = 0.5208333F;
			// 
			// Label86
			// 
			this.Label86.Height = 0.1666667F;
			this.Label86.HyperLink = null;
			this.Label86.Left = 0.9518332F;
			this.Label86.Name = "Label86";
			this.Label86.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label86.Text = "卒業年月";
			this.Label86.Top = 3.41669F;
			this.Label86.Width = 0.4999999F;
			// 
			// ClsName1TextBox
			// 
			this.ClsName1TextBox.CanGrow = false;
			this.ClsName1TextBox.DataField = "CLS_NAME_1";
			this.ClsName1TextBox.Height = 0.1666667F;
			this.ClsName1TextBox.Left = 4.566418F;
			this.ClsName1TextBox.Name = "ClsName1TextBox";
			this.ClsName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName1TextBox.Text = "あいうえおか";
			this.ClsName1TextBox.Top = 3.573023F;
			this.ClsName1TextBox.Width = 0.6354166F;
			// 
			// Label88
			// 
			this.Label88.Height = 0.1458333F;
			this.Label88.HyperLink = null;
			this.Label88.Left = 4.566418F;
			this.Label88.Name = "Label88";
			this.Label88.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label88.Text = "分類";
			this.Label88.Top = 3.417024F;
			this.Label88.Width = 0.6354167F;
			// 
			// Label168
			// 
			this.Label168.Height = 0.15625F;
			this.Label168.HyperLink = null;
			this.Label168.Left = 4.941418F;
			this.Label168.Name = "Label168";
			this.Label168.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label168.Text = "ヶ月";
			this.Label168.Top = 3.26044F;
			this.Label168.Width = 0.25F;
			// 
			// Label169
			// 
			this.Label169.Height = 0.1666667F;
			this.Label169.HyperLink = null;
			this.Label169.Left = 4.941418F;
			this.Label169.Name = "Label169";
			this.Label169.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label169.Text = "ヶ月";
			this.Label169.Top = 3.10419F;
			this.Label169.Width = 0.25F;
			// 
			// Label170
			// 
			this.Label170.Height = 0.1666667F;
			this.Label170.HyperLink = null;
			this.Label170.Left = 4.941418F;
			this.Label170.Name = "Label170";
			this.Label170.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label170.Text = "ヶ月";
			this.Label170.Top = 2.94794F;
			this.Label170.Width = 0.25F;
			// 
			// Label171
			// 
			this.Label171.Height = 0.1666667F;
			this.Label171.HyperLink = null;
			this.Label171.Left = 4.941418F;
			this.Label171.Name = "Label171";
			this.Label171.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label171.Text = "ヶ月";
			this.Label171.Top = 2.79169F;
			this.Label171.Width = 0.25F;
			// 
			// Label163
			// 
			this.Label163.Height = 0.15625F;
			this.Label163.HyperLink = null;
			this.Label163.Left = 4.941418F;
			this.Label163.Name = "Label163";
			this.Label163.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label163.Text = "ヶ月";
			this.Label163.Top = 2.645856F;
			this.Label163.Width = 0.25F;
			// 
			// Label204
			// 
			this.Label204.Height = 0.9416667F;
			this.Label204.HyperLink = null;
			this.Label204.Left = 0.02525043F;
			this.Label204.Name = "Label204";
			this.Label204.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label204.Text = "兼務職情報";
			this.Label204.Top = 2.487106F;
			this.Label204.Width = 0.4029167F;
			// 
			// Label69
			// 
			this.Label69.Height = 0.1666667F;
			this.Label69.HyperLink = null;
			this.Label69.Left = 4.524748F;
			this.Label69.Name = "Label69";
			this.Label69.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label69.Text = "休職期間";
			this.Label69.Top = 5.13544F;
			this.Label69.Width = 0.6770834F;
			// 
			// Label70
			// 
			this.Label70.Height = 0.1666667F;
			this.Label70.HyperLink = null;
			this.Label70.Left = 3.337248F;
			this.Label70.Name = "Label70";
			this.Label70.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label70.Text = "休職事由";
			this.Label70.Top = 5.13544F;
			this.Label70.Width = 1.197917F;
			// 
			// LeaveReasonTextBox
			// 
			this.LeaveReasonTextBox.CanGrow = false;
			this.LeaveReasonTextBox.DataField = "LEAVE_REASON";
			this.LeaveReasonTextBox.Height = 0.1666667F;
			this.LeaveReasonTextBox.Left = 3.337248F;
			this.LeaveReasonTextBox.Name = "LeaveReasonTextBox";
			this.LeaveReasonTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LeaveReasonTextBox.Text = "○○○○○○○○○○";
			this.LeaveReasonTextBox.Top = 5.29169F;
			this.LeaveReasonTextBox.Width = 1.197917F;
			// 
			// Label203
			// 
			this.Label203.Height = 0.3270835F;
			this.Label203.HyperLink = null;
			this.Label203.Left = 0.004417419F;
			this.Label203.Name = "Label203";
			this.Label203.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label203.Text = "出向休職";
			this.Label203.Top = 5.132939F;
			this.Label203.Width = 0.4445834F;
			// 
			// ItemShortName1TextBox
			// 
			this.ItemShortName1TextBox.CanGrow = false;
			this.ItemShortName1TextBox.DataField = "ITEM_SHORT_NAME_1";
			this.ItemShortName1TextBox.Height = 0.167F;
			this.ItemShortName1TextBox.Left = 0.4414172F;
			this.ItemShortName1TextBox.Name = "ItemShortName1TextBox";
			this.ItemShortName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName1TextBox.Text = "あいうえおかきくけこ";
			this.ItemShortName1TextBox.Top = 5.44794F;
			this.ItemShortName1TextBox.Width = 1F;
			// 
			// Label202
			// 
			this.Label202.Height = 0.9520833F;
			this.Label202.HyperLink = null;
			this.Label202.Left = 0.004417419F;
			this.Label202.Name = "Label202";
			this.Label202.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label202.Text = "任意項目情報";
			this.Label202.Top = 5.445439F;
			this.Label202.Width = 0.4341667F;
			// 
			// AddPostAtacName5TextBox
			// 
			this.AddPostAtacName5TextBox.CanGrow = false;
			this.AddPostAtacName5TextBox.DataField = "ADD_POST_ATAC_NAME_5";
			this.AddPostAtacName5TextBox.Height = 0.1666667F;
			this.AddPostAtacName5TextBox.Left = 1.441417F;
			this.AddPostAtacName5TextBox.Name = "AddPostAtacName5TextBox";
			this.AddPostAtacName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostAtacName5TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのは";
			this.AddPostAtacName5TextBox.Top = 3.26044F;
			this.AddPostAtacName5TextBox.Width = 2.625F;
			// 
			// AddPostAtacName4TextBox
			// 
			this.AddPostAtacName4TextBox.CanGrow = false;
			this.AddPostAtacName4TextBox.DataField = "ADD_POST_ATAC_NAME_4";
			this.AddPostAtacName4TextBox.Height = 0.1666667F;
			this.AddPostAtacName4TextBox.Left = 1.441417F;
			this.AddPostAtacName4TextBox.Name = "AddPostAtacName4TextBox";
			this.AddPostAtacName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostAtacName4TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのは";
			this.AddPostAtacName4TextBox.Top = 3.10419F;
			this.AddPostAtacName4TextBox.Width = 2.625F;
			// 
			// AddPostAtacName3TextBox
			// 
			this.AddPostAtacName3TextBox.CanGrow = false;
			this.AddPostAtacName3TextBox.DataField = "ADD_POST_ATAC_NAME_3";
			this.AddPostAtacName3TextBox.Height = 0.1666667F;
			this.AddPostAtacName3TextBox.Left = 1.441417F;
			this.AddPostAtacName3TextBox.Name = "AddPostAtacName3TextBox";
			this.AddPostAtacName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostAtacName3TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのは";
			this.AddPostAtacName3TextBox.Top = 2.94794F;
			this.AddPostAtacName3TextBox.Width = 2.625F;
			// 
			// AddPostAtacName2TextBox
			// 
			this.AddPostAtacName2TextBox.CanGrow = false;
			this.AddPostAtacName2TextBox.DataField = "ADD_POST_ATAC_NAME_2";
			this.AddPostAtacName2TextBox.Height = 0.1666666F;
			this.AddPostAtacName2TextBox.Left = 1.441416F;
			this.AddPostAtacName2TextBox.Name = "AddPostAtacName2TextBox";
			this.AddPostAtacName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostAtacName2TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのは";
			this.AddPostAtacName2TextBox.Top = 2.79169F;
			this.AddPostAtacName2TextBox.Width = 2.625F;
			// 
			// Label48
			// 
			this.Label48.Height = 0.1666667F;
			this.Label48.HyperLink = null;
			this.Label48.Left = 1.441417F;
			this.Label48.Name = "Label48";
			this.Label48.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label48.Text = "兼務所属";
			this.Label48.Top = 2.489606F;
			this.Label48.Width = 2.625F;
			// 
			// AddPostAtacName1TextBox
			// 
			this.AddPostAtacName1TextBox.CanGrow = false;
			this.AddPostAtacName1TextBox.DataField = "ADD_POST_ATAC_NAME_1";
			this.AddPostAtacName1TextBox.Height = 0.15625F;
			this.AddPostAtacName1TextBox.Left = 1.441417F;
			this.AddPostAtacName1TextBox.Name = "AddPostAtacName1TextBox";
			this.AddPostAtacName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostAtacName1TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのは";
			this.AddPostAtacName1TextBox.Top = 2.645856F;
			this.AddPostAtacName1TextBox.Width = 2.625F;
			// 
			// ProjFromDate2TextBox
			// 
			this.ProjFromDate2TextBox.CanGrow = false;
			this.ProjFromDate2TextBox.DataField = "PROJ_FROM_DATE_2";
			this.ProjFromDate2TextBox.Height = 0.15F;
			this.ProjFromDate2TextBox.Left = 4.056416F;
			this.ProjFromDate2TextBox.Name = "ProjFromDate2TextBox";
			this.ProjFromDate2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDate2TextBox.Text = "zzz6/z6/z6";
			this.ProjFromDate2TextBox.Top = 1.872523F;
			this.ProjFromDate2TextBox.Width = 0.51F;
			// 
			// ProjFromDate5TextBox
			// 
			this.ProjFromDate5TextBox.CanGrow = false;
			this.ProjFromDate5TextBox.DataField = "PROJ_FROM_DATE_5";
			this.ProjFromDate5TextBox.Height = 0.15F;
			this.ProjFromDate5TextBox.Left = 4.056416F;
			this.ProjFromDate5TextBox.Name = "ProjFromDate5TextBox";
			this.ProjFromDate5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDate5TextBox.Text = "zzz6/z6/z6";
			this.ProjFromDate5TextBox.Top = 2.330856F;
			this.ProjFromDate5TextBox.Width = 0.51F;
			// 
			// ProjFromDate4TextBox
			// 
			this.ProjFromDate4TextBox.CanGrow = false;
			this.ProjFromDate4TextBox.DataField = "PROJ_FROM_DATE_4";
			this.ProjFromDate4TextBox.Height = 0.15F;
			this.ProjFromDate4TextBox.Left = 4.056416F;
			this.ProjFromDate4TextBox.Name = "ProjFromDate4TextBox";
			this.ProjFromDate4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDate4TextBox.Text = "zzz6/z6/z6";
			this.ProjFromDate4TextBox.Top = 2.174606F;
			this.ProjFromDate4TextBox.Width = 0.51F;
			// 
			// ProjFromDate3TextBox
			// 
			this.ProjFromDate3TextBox.CanGrow = false;
			this.ProjFromDate3TextBox.DataField = "PROJ_FROM_DATE_3";
			this.ProjFromDate3TextBox.Height = 0.15F;
			this.ProjFromDate3TextBox.Left = 4.055998F;
			this.ProjFromDate3TextBox.Name = "ProjFromDate3TextBox";
			this.ProjFromDate3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDate3TextBox.Text = "zzz6/z6/z6";
			this.ProjFromDate3TextBox.Top = 2.029024F;
			this.ProjFromDate3TextBox.Width = 0.51F;
			// 
			// ProjFromDate1TextBox
			// 
			this.ProjFromDate1TextBox.CanGrow = false;
			this.ProjFromDate1TextBox.DataField = "PROJ_FROM_DATE_1";
			this.ProjFromDate1TextBox.Height = 0.15F;
			this.ProjFromDate1TextBox.Left = 4.055998F;
			this.ProjFromDate1TextBox.Name = "ProjFromDate1TextBox";
			this.ProjFromDate1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjFromDate1TextBox.Text = "zzz6/z6/z6";
			this.ProjFromDate1TextBox.Top = 1.716023F;
			this.ProjFromDate1TextBox.Width = 0.51F;
			// 
			// ProjShortName2TextBox
			// 
			this.ProjShortName2TextBox.CanGrow = false;
			this.ProjShortName2TextBox.DataField = "PROJ_SHORT_NAME_2";
			this.ProjShortName2TextBox.Height = 0.1604167F;
			this.ProjShortName2TextBox.Left = 1.587F;
			this.ProjShortName2TextBox.Name = "ProjShortName2TextBox";
			this.ProjShortName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName2TextBox.Text = "あいうえおかきくけこ";
			this.ProjShortName2TextBox.Top = 1.873024F;
			this.ProjShortName2TextBox.Width = 2.479167F;
			// 
			// ProjCodeSbno5TextBox
			// 
			this.ProjCodeSbno5TextBox.CanGrow = false;
			this.ProjCodeSbno5TextBox.DataField = "PROJ_CODE_SBNO_5";
			this.ProjCodeSbno5TextBox.Height = 0.1708334F;
			this.ProjCodeSbno5TextBox.Left = 0.4419184F;
			this.ProjCodeSbno5TextBox.Name = "ProjCodeSbno5TextBox";
			this.ProjCodeSbno5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjCodeSbno5TextBox.Text = "00000000000000000000-00";
			this.ProjCodeSbno5TextBox.Top = 2.330856F;
			this.ProjCodeSbno5TextBox.Width = 1.15625F;
			// 
			// ProjShortName5TextBox
			// 
			this.ProjShortName5TextBox.CanGrow = false;
			this.ProjShortName5TextBox.DataField = "PROJ_SHORT_NAME_5";
			this.ProjShortName5TextBox.Height = 0.1708333F;
			this.ProjShortName5TextBox.Left = 1.587F;
			this.ProjShortName5TextBox.Name = "ProjShortName5TextBox";
			this.ProjShortName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName5TextBox.Text = "あいうえおかきくけこ";
			this.ProjShortName5TextBox.Top = 2.331024F;
			this.ProjShortName5TextBox.Width = 2.479167F;
			// 
			// ProjShortName4TextBox
			// 
			this.ProjShortName4TextBox.CanGrow = false;
			this.ProjShortName4TextBox.DataField = "PROJ_SHORT_NAME_4";
			this.ProjShortName4TextBox.Height = 0.1708333F;
			this.ProjShortName4TextBox.Left = 1.587F;
			this.ProjShortName4TextBox.Name = "ProjShortName4TextBox";
			this.ProjShortName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName4TextBox.Text = "あいうえおかきくけこ";
			this.ProjShortName4TextBox.Top = 2.175024F;
			this.ProjShortName4TextBox.Width = 2.479167F;
			// 
			// ProjShortName3TextBox
			// 
			this.ProjShortName3TextBox.CanGrow = false;
			this.ProjShortName3TextBox.DataField = "PROJ_SHORT_NAME_3";
			this.ProjShortName3TextBox.Height = 0.1708333F;
			this.ProjShortName3TextBox.Left = 1.587F;
			this.ProjShortName3TextBox.Name = "ProjShortName3TextBox";
			this.ProjShortName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName3TextBox.Text = "あいうえおかきくけこ";
			this.ProjShortName3TextBox.Top = 2.029024F;
			this.ProjShortName3TextBox.Width = 2.479167F;
			// 
			// ProjShortName1TextBox
			// 
			this.ProjShortName1TextBox.CanGrow = false;
			this.ProjShortName1TextBox.DataField = "PROJ_SHORT_NAME_1";
			this.ProjShortName1TextBox.Height = 0.1708333F;
			this.ProjShortName1TextBox.Left = 1.587F;
			this.ProjShortName1TextBox.Name = "ProjShortName1TextBox";
			this.ProjShortName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjShortName1TextBox.Text = "あいうえおかきくけこ";
			this.ProjShortName1TextBox.Top = 1.716023F;
			this.ProjShortName1TextBox.Width = 2.479167F;
			// 
			// ProjCodeSbno4TextBox
			// 
			this.ProjCodeSbno4TextBox.CanGrow = false;
			this.ProjCodeSbno4TextBox.DataField = "PROJ_CODE_SBNO_4";
			this.ProjCodeSbno4TextBox.Height = 0.1708334F;
			this.ProjCodeSbno4TextBox.Left = 0.4419184F;
			this.ProjCodeSbno4TextBox.Name = "ProjCodeSbno4TextBox";
			this.ProjCodeSbno4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjCodeSbno4TextBox.Text = "00000000000000000000-00";
			this.ProjCodeSbno4TextBox.Top = 2.174606F;
			this.ProjCodeSbno4TextBox.Width = 1.15625F;
			// 
			// ProjCodeSbno3TextBox
			// 
			this.ProjCodeSbno3TextBox.CanGrow = false;
			this.ProjCodeSbno3TextBox.DataField = "PROJ_CODE_SBNO_3";
			this.ProjCodeSbno3TextBox.Height = 0.1708334F;
			this.ProjCodeSbno3TextBox.Left = 0.4419184F;
			this.ProjCodeSbno3TextBox.Name = "ProjCodeSbno3TextBox";
			this.ProjCodeSbno3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjCodeSbno3TextBox.Text = "00000000000000000000-00";
			this.ProjCodeSbno3TextBox.Top = 2.028773F;
			this.ProjCodeSbno3TextBox.Width = 1.15625F;
			// 
			// ProjCodeSbno2TextBox
			// 
			this.ProjCodeSbno2TextBox.CanGrow = false;
			this.ProjCodeSbno2TextBox.DataField = "PROJ_CODE_SBNO_2";
			this.ProjCodeSbno2TextBox.Height = 0.1604167F;
			this.ProjCodeSbno2TextBox.Left = 0.4419184F;
			this.ProjCodeSbno2TextBox.Name = "ProjCodeSbno2TextBox";
			this.ProjCodeSbno2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjCodeSbno2TextBox.Text = "00000000000000000000-00";
			this.ProjCodeSbno2TextBox.Top = 1.872523F;
			this.ProjCodeSbno2TextBox.Width = 1.15625F;
			// 
			// ProjCodeSbno1TextBox
			// 
			this.ProjCodeSbno1TextBox.CanGrow = false;
			this.ProjCodeSbno1TextBox.DataField = "PROJ_CODE_SBNO_1";
			this.ProjCodeSbno1TextBox.Height = 0.1708334F;
			this.ProjCodeSbno1TextBox.Left = 0.4419184F;
			this.ProjCodeSbno1TextBox.Name = "ProjCodeSbno1TextBox";
			this.ProjCodeSbno1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ProjCodeSbno1TextBox.Text = "00000000000000000000-00";
			this.ProjCodeSbno1TextBox.Top = 1.716273F;
			this.ProjCodeSbno1TextBox.Width = 1.145833F;
			// 
			// Label191
			// 
			this.Label191.Height = 0.1812501F;
			this.Label191.HyperLink = null;
			this.Label191.Left = 4.566418F;
			this.Label191.Name = "Label191";
			this.Label191.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label191.Text = "期間";
			this.Label191.Top = 1.552106F;
			this.Label191.Width = 0.6354166F;
			// 
			// Label189
			// 
			this.Label189.Height = 0.18125F;
			this.Label189.HyperLink = null;
			this.Label189.Left = 0.4419174F;
			this.Label189.Name = "Label189";
			this.Label189.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label189.Text = "プロジェクト名";
			this.Label189.Top = 1.549606F;
			this.Label189.Width = 3.621667F;
			// 
			// Label190
			// 
			this.Label190.Height = 0.1812501F;
			this.Label190.HyperLink = null;
			this.Label190.Left = 4.055998F;
			this.Label190.Name = "Label190";
			this.Label190.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label190.Text = "開始日";
			this.Label190.Top = 1.552106F;
			this.Label190.Width = 0.5208333F;
			// 
			// Label47
			// 
			this.Label47.Height = 0.167F;
			this.Label47.HyperLink = null;
			this.Label47.Left = 0.4414172F;
			this.Label47.Name = "Label47";
			this.Label47.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label47.Text = "兼務職名";
			this.Label47.Top = 2.489606F;
			this.Label47.Width = 1F;
			// 
			// Label51
			// 
			this.Label51.Height = 0.1666666F;
			this.Label51.HyperLink = null;
			this.Label51.Left = 4.055998F;
			this.Label51.Name = "Label51";
			this.Label51.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label51.Text = "兼務日";
			this.Label51.Top = 2.489606F;
			this.Label51.Width = 0.5208333F;
			// 
			// Label52
			// 
			this.Label52.Height = 0.1666667F;
			this.Label52.HyperLink = null;
			this.Label52.Left = 4.566418F;
			this.Label52.Name = "Label52";
			this.Label52.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label52.Text = "期間";
			this.Label52.Top = 2.489606F;
			this.Label52.Width = 0.6354167F;
			// 
			// JobStayPerodY
			// 
			this.JobStayPerodY.CanGrow = false;
			this.JobStayPerodY.DataField = "JOB_STAY_PEROD_Y";
			this.JobStayPerodY.Height = 0.15F;
			this.JobStayPerodY.Left = 4.566418F;
			this.JobStayPerodY.Name = "JobStayPerodY";
			this.JobStayPerodY.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.JobStayPerodY.Text = "z9";
			this.JobStayPerodY.Top = 1.403773F;
			this.JobStayPerodY.Width = 0.125F;
			// 
			// JobChgDateTextBox
			// 
			this.JobChgDateTextBox.CanGrow = false;
			this.JobChgDateTextBox.DataField = "JOB_CHG_DATE";
			this.JobChgDateTextBox.Height = 0.15F;
			this.JobChgDateTextBox.Left = 4.055998F;
			this.JobChgDateTextBox.Name = "JobChgDateTextBox";
			this.JobChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobChgDateTextBox.Text = "zzz6/z6/z6";
			this.JobChgDateTextBox.Top = 1.404024F;
			this.JobChgDateTextBox.Width = 0.51F;
			// 
			// TrnFrom4TextBox
			// 
			this.TrnFrom4TextBox.CanGrow = false;
			this.TrnFrom4TextBox.DataField = "TRN_FROM_4";
			this.TrnFrom4TextBox.Height = 0.1666666F;
			this.TrnFrom4TextBox.Left = 0.4414172F;
			this.TrnFrom4TextBox.Name = "TrnFrom4TextBox";
			this.TrnFrom4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnFrom4TextBox.Text = "あいうえおかきくけこ";
			this.TrnFrom4TextBox.Top = 4.97919F;
			this.TrnFrom4TextBox.Width = 1.010417F;
			// 
			// OwnTypeTextBox
			// 
			this.OwnTypeTextBox.CanGrow = false;
			this.OwnTypeTextBox.DataField = "OWN_TYPE";
			this.OwnTypeTextBox.Height = 0.1666667F;
			this.OwnTypeTextBox.Left = 0.4414172F;
			this.OwnTypeTextBox.Name = "OwnTypeTextBox";
			this.OwnTypeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OwnTypeTextBox.Text = "あいうえお";
			this.OwnTypeTextBox.Top = 4.19794F;
			this.OwnTypeTextBox.Width = 0.5208333F;
			// 
			// Label78
			// 
			this.Label78.Height = 0.1666667F;
			this.Label78.HyperLink = null;
			this.Label78.Left = 0.4414172F;
			this.Label78.Name = "Label78";
			this.Label78.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label78.Text = "FROM";
			this.Label78.Top = 4.35419F;
			this.Label78.Width = 1.010417F;
			// 
			// TrnFrom1TextBox
			// 
			this.TrnFrom1TextBox.CanGrow = false;
			this.TrnFrom1TextBox.DataField = "TRN_FROM_1";
			this.TrnFrom1TextBox.Height = 0.1666667F;
			this.TrnFrom1TextBox.Left = 0.4414172F;
			this.TrnFrom1TextBox.Name = "TrnFrom1TextBox";
			this.TrnFrom1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnFrom1TextBox.Text = "あいうえおかきくけこ";
			this.TrnFrom1TextBox.Top = 4.51044F;
			this.TrnFrom1TextBox.Width = 1.010417F;
			// 
			// TrnFrom3TextBox
			// 
			this.TrnFrom3TextBox.CanGrow = false;
			this.TrnFrom3TextBox.DataField = "TRN_FROM_3";
			this.TrnFrom3TextBox.Height = 0.1666667F;
			this.TrnFrom3TextBox.Left = 0.4414172F;
			this.TrnFrom3TextBox.Name = "TrnFrom3TextBox";
			this.TrnFrom3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnFrom3TextBox.Text = "あいうえおかきくけこ";
			this.TrnFrom3TextBox.Top = 4.82294F;
			this.TrnFrom3TextBox.Width = 1.010417F;
			// 
			// TrnFrom2TextBox
			// 
			this.TrnFrom2TextBox.CanGrow = false;
			this.TrnFrom2TextBox.DataField = "TRN_FROM_2";
			this.TrnFrom2TextBox.Height = 0.15625F;
			this.TrnFrom2TextBox.Left = 0.4414172F;
			this.TrnFrom2TextBox.Name = "TrnFrom2TextBox";
			this.TrnFrom2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnFrom2TextBox.Text = "あいうえおかきくけこ";
			this.TrnFrom2TextBox.Top = 4.66669F;
			this.TrnFrom2TextBox.Width = 1.010417F;
			// 
			// Label188
			// 
			this.Label188.Height = 0.9520833F;
			this.Label188.HyperLink = null;
			this.Label188.Left = 0.004417419F;
			this.Label188.Name = "Label188";
			this.Label188.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label188.Text = "ﾌﾟﾛｼﾞｪｸﾄ情報";
			this.Label188.Top = 1.549606F;
			this.Label188.Width = 0.4445834F;
			// 
			// ExpenAtacCodeTextBox
			// 
			this.ExpenAtacCodeTextBox.CanGrow = false;
			this.ExpenAtacCodeTextBox.DataField = "EXPEN_ATAC_CODE";
			this.ExpenAtacCodeTextBox.Height = 0.16F;
			this.ExpenAtacCodeTextBox.Left = 0.4447513F;
			this.ExpenAtacCodeTextBox.Name = "ExpenAtacCodeTextBox";
			this.ExpenAtacCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ExpenAtacCodeTextBox.Text = "0000000000";
			this.ExpenAtacCodeTextBox.Top = 0.3130234F;
			this.ExpenAtacCodeTextBox.Width = 0.667F;
			// 
			// JobCodeTextBox
			// 
			this.JobCodeTextBox.CanGrow = false;
			this.JobCodeTextBox.DataField = "JOB_CODE";
			this.JobCodeTextBox.Height = 0.1812501F;
			this.JobCodeTextBox.Left = 0.4450002F;
			this.JobCodeTextBox.Name = "JobCodeTextBox";
			this.JobCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobCodeTextBox.Text = "000000";
			this.JobCodeTextBox.Top = 1.383024F;
			this.JobCodeTextBox.Width = 0.6666667F;
			// 
			// QualfJobCodeTextBox
			// 
			this.QualfJobCodeTextBox.CanGrow = false;
			this.QualfJobCodeTextBox.DataField = "QUALF_JOB_CODE";
			this.QualfJobCodeTextBox.Height = 0.1708333F;
			this.QualfJobCodeTextBox.Left = 0.4450002F;
			this.QualfJobCodeTextBox.Name = "QualfJobCodeTextBox";
			this.QualfJobCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfJobCodeTextBox.Text = "000000";
			this.QualfJobCodeTextBox.Top = 1.233024F;
			this.QualfJobCodeTextBox.Width = 0.6666667F;
			// 
			// GradeCodeTextBox
			// 
			this.GradeCodeTextBox.CanGrow = false;
			this.GradeCodeTextBox.DataField = "GRADE_CODE";
			this.GradeCodeTextBox.Height = 0.1708333F;
			this.GradeCodeTextBox.Left = 0.4450002F;
			this.GradeCodeTextBox.Name = "GradeCodeTextBox";
			this.GradeCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GradeCodeTextBox.Text = "000000";
			this.GradeCodeTextBox.Top = 1.074023F;
			this.GradeCodeTextBox.Width = 0.6666667F;
			// 
			// DutyCodeTextBox
			// 
			this.DutyCodeTextBox.CanGrow = false;
			this.DutyCodeTextBox.DataField = "DUTY_CODE";
			this.DutyCodeTextBox.Height = 0.1604167F;
			this.DutyCodeTextBox.Left = 0.4450002F;
			this.DutyCodeTextBox.Name = "DutyCodeTextBox";
			this.DutyCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DutyCodeTextBox.Text = "000000";
			this.DutyCodeTextBox.Top = 0.9240235F;
			this.DutyCodeTextBox.Width = 0.6666667F;
			// 
			// PostCodeTextBox
			// 
			this.PostCodeTextBox.CanGrow = false;
			this.PostCodeTextBox.DataField = "POST_CODE";
			this.PostCodeTextBox.Height = 0.1708334F;
			this.PostCodeTextBox.Left = 0.4450002F;
			this.PostCodeTextBox.Name = "PostCodeTextBox";
			this.PostCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PostCodeTextBox.Text = "000000";
			this.PostCodeTextBox.Top = 0.7740235F;
			this.PostCodeTextBox.Width = 0.6666667F;
			// 
			// RankCodeTextBox
			// 
			this.RankCodeTextBox.CanGrow = false;
			this.RankCodeTextBox.DataField = "RANK_CODE";
			this.RankCodeTextBox.Height = 0.1708333F;
			this.RankCodeTextBox.Left = 0.4450002F;
			this.RankCodeTextBox.Name = "RankCodeTextBox";
			this.RankCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RankCodeTextBox.Text = "000000";
			this.RankCodeTextBox.Top = 0.6140235F;
			this.RankCodeTextBox.Width = 0.6666667F;
			// 
			// ServPlCodeTextBox
			// 
			this.ServPlCodeTextBox.CanGrow = false;
			this.ServPlCodeTextBox.DataField = "SERV_PL_CODE";
			this.ServPlCodeTextBox.Height = 0.1708332F;
			this.ServPlCodeTextBox.Left = 0.4450002F;
			this.ServPlCodeTextBox.Name = "ServPlCodeTextBox";
			this.ServPlCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ServPlCodeTextBox.Text = "000000";
			this.ServPlCodeTextBox.Top = 0.4580235F;
			this.ServPlCodeTextBox.Width = 0.6666667F;
			// 
			// AtacCodeTextBox
			// 
			this.AtacCodeTextBox.CanGrow = false;
			this.AtacCodeTextBox.DataField = "ATAC_CODE";
			this.AtacCodeTextBox.Height = 0.1708334F;
			this.AtacCodeTextBox.Left = 0.4450002F;
			this.AtacCodeTextBox.Name = "AtacCodeTextBox";
			this.AtacCodeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacCodeTextBox.Text = "0000000000";
			this.AtacCodeTextBox.Top = 0.1600235F;
			this.AtacCodeTextBox.Width = 0.6666666F;
			// 
			// Label42
			// 
			this.Label42.Height = 0.1812501F;
			this.Label42.HyperLink = null;
			this.Label42.Left = 0.004417419F;
			this.Label42.Name = "Label42";
			this.Label42.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label42.Text = "職種";
			this.Label42.Top = 1.382941F;
			this.Label42.Width = 0.4445832F;
			// 
			// Label41
			// 
			this.Label41.Height = 0.1708333F;
			this.Label41.HyperLink = null;
			this.Label41.Left = 0.004417419F;
			this.Label41.Name = "Label41";
			this.Label41.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label41.Text = "資格";
			this.Label41.Top = 1.233356F;
			this.Label41.Width = 0.4445832F;
			// 
			// Label40
			// 
			this.Label40.Height = 0.1708333F;
			this.Label40.HyperLink = null;
			this.Label40.Left = 0.004417419F;
			this.Label40.Name = "Label40";
			this.Label40.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label40.Text = "等級";
			this.Label40.Top = 1.073774F;
			this.Label40.Width = 0.4445832F;
			// 
			// Label30
			// 
			this.Label30.Height = 0.1604167F;
			this.Label30.HyperLink = null;
			this.Label30.Left = 0.004417419F;
			this.Label30.Name = "Label30";
			this.Label30.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label30.Text = "職掌";
			this.Label30.Top = 0.9241902F;
			this.Label30.Width = 0.4445832F;
			// 
			// Label28
			// 
			this.Label28.Height = 0.1708333F;
			this.Label28.HyperLink = null;
			this.Label28.Left = 0.004417419F;
			this.Label28.Name = "Label28";
			this.Label28.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label28.Text = "役職";
			this.Label28.Top = 0.7741902F;
			this.Label28.Width = 0.4445832F;
			// 
			// Label27
			// 
			this.Label27.Height = 0.15F;
			this.Label27.HyperLink = null;
			this.Label27.Left = 0.004417419F;
			this.Label27.Name = "Label27";
			this.Label27.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label27.Text = "身分";
			this.Label27.Top = 0.6137735F;
			this.Label27.Width = 0.4445832F;
			// 
			// Label26
			// 
			this.Label26.Height = 0.15F;
			this.Label26.HyperLink = null;
			this.Label26.Left = 0.003917217F;
			this.Label26.Name = "Label26";
			this.Label26.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label26.Text = "勤務地";
			this.Label26.Top = 0.4687736F;
			this.Label26.Width = 0.4445832F;
			// 
			// Label25
			// 
			this.Label25.Height = 0.15F;
			this.Label25.HyperLink = null;
			this.Label25.Left = 0.003916264F;
			this.Label25.Name = "Label25";
			this.Label25.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label25.Text = "経費";
			this.Label25.Top = 0.3125235F;
			this.Label25.Width = 0.444583F;
			// 
			// Label24
			// 
			this.Label24.Height = 0.15F;
			this.Label24.HyperLink = null;
			this.Label24.Left = 0.004416466F;
			this.Label24.Name = "Label24";
			this.Label24.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label24.Text = "所属";
			this.Label24.Top = 0.1700235F;
			this.Label24.Width = 0.444583F;
			// 
			// Label21
			// 
			this.Label21.Height = 0.15F;
			this.Label21.HyperLink = null;
			this.Label21.Left = 0.003916264F;
			this.Label21.Name = "Label21";
			this.Label21.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label21.Text = "項目";
			this.Label21.Top = 2.348423E-05F;
			this.Label21.Width = 0.4445836F;
			// 
			// Line196
			// 
			this.Line196.Height = 6.381F;
			this.Line196.Left = 0F;
			this.Line196.LineWeight = 1F;
			this.Line196.Name = "Line196";
			this.Line196.Top = 0.001023484F;
			this.Line196.Width = 0F;
			this.Line196.X1 = 0F;
			this.Line196.X2 = 0F;
			this.Line196.Y1 = 0.001023484F;
			this.Line196.Y2 = 6.382023F;
			// 
			// Line231
			// 
			this.Line231.Height = 0F;
			this.Line231.Left = 0F;
			this.Line231.LineWeight = 1F;
			this.Line231.Name = "Line231";
			this.Line231.Top = 0.1570235F;
			this.Line231.Width = 5.187998F;
			this.Line231.X1 = 0F;
			this.Line231.X2 = 5.187998F;
			this.Line231.Y1 = 0.1570235F;
			this.Line231.Y2 = 0.1570235F;
			// 
			// Label23
			// 
			this.Label23.Height = 0.15F;
			this.Label23.HyperLink = null;
			this.Label23.Left = 4.555998F;
			this.Label23.Name = "Label23";
			this.Label23.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label23.Text = "滞留期間";
			this.Label23.Top = 2.348423E-05F;
			this.Label23.Width = 0.625F;
			// 
			// Line250
			// 
			this.Line250.Height = 0F;
			this.Line250.Left = 9.489059E-05F;
			this.Line250.LineWeight = 1F;
			this.Line250.Name = "Line250";
			this.Line250.Top = 2.491024F;
			this.Line250.Width = 5.187903F;
			this.Line250.X1 = 9.489059E-05F;
			this.Line250.X2 = 5.187998F;
			this.Line250.Y1 = 2.491024F;
			this.Line250.Y2 = 2.491024F;
			// 
			// Label43
			// 
			this.Label43.Height = 0.15F;
			this.Label43.HyperLink = null;
			this.Label43.Left = 4.045582F;
			this.Label43.Name = "Label43";
			this.Label43.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label43.Text = "異動日付";
			this.Label43.Top = 2.348423E-05F;
			this.Label43.Width = 0.5F;
			// 
			// ExpenAtacChgDateTextBox
			// 
			this.ExpenAtacChgDateTextBox.CanGrow = false;
			this.ExpenAtacChgDateTextBox.DataField = "EXPEN_ATAC_CHG_DATE";
			this.ExpenAtacChgDateTextBox.Height = 0.15F;
			this.ExpenAtacChgDateTextBox.Left = 4.055998F;
			this.ExpenAtacChgDateTextBox.Name = "ExpenAtacChgDateTextBox";
			this.ExpenAtacChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ExpenAtacChgDateTextBox.Text = "zzz6/z6/z6";
			this.ExpenAtacChgDateTextBox.Top = 0.3125235F;
			this.ExpenAtacChgDateTextBox.Width = 0.51F;
			// 
			// Label44
			// 
			this.Label44.Height = 0.15F;
			this.Label44.HyperLink = null;
			this.Label44.Left = 1.1185F;
			this.Label44.Name = "Label44";
			this.Label44.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label44.Text = "現職内容";
			this.Label44.Top = 2.348423E-05F;
			this.Label44.Width = 2.938F;
			// 
			// QualfJobChgDateTextBox
			// 
			this.QualfJobChgDateTextBox.CanGrow = false;
			this.QualfJobChgDateTextBox.DataField = "QUALF_JOB_CHG_DATE";
			this.QualfJobChgDateTextBox.Height = 0.15F;
			this.QualfJobChgDateTextBox.Left = 4.055998F;
			this.QualfJobChgDateTextBox.Name = "QualfJobChgDateTextBox";
			this.QualfJobChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfJobChgDateTextBox.Text = "zzz6/z6/z6";
			this.QualfJobChgDateTextBox.Top = 1.244023F;
			this.QualfJobChgDateTextBox.Width = 0.51F;
			// 
			// DutyChgDateTextBox
			// 
			this.DutyChgDateTextBox.CanGrow = false;
			this.DutyChgDateTextBox.DataField = "DUTY_CHG_DATE";
			this.DutyChgDateTextBox.Height = 0.15F;
			this.DutyChgDateTextBox.Left = 4.055998F;
			this.DutyChgDateTextBox.Name = "DutyChgDateTextBox";
			this.DutyChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DutyChgDateTextBox.Text = "zzz6/z6/z6";
			this.DutyChgDateTextBox.Top = 0.9140235F;
			this.DutyChgDateTextBox.Width = 0.51F;
			// 
			// PostChgDateTextBox
			// 
			this.PostChgDateTextBox.CanGrow = false;
			this.PostChgDateTextBox.DataField = "POST_CHG_DATE";
			this.PostChgDateTextBox.Height = 0.15F;
			this.PostChgDateTextBox.Left = 4.055998F;
			this.PostChgDateTextBox.Name = "PostChgDateTextBox";
			this.PostChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PostChgDateTextBox.Text = "zzz6/z6/z6";
			this.PostChgDateTextBox.Top = 0.7640235F;
			this.PostChgDateTextBox.Width = 0.51F;
			// 
			// RankChgDateTextBox
			// 
			this.RankChgDateTextBox.CanGrow = false;
			this.RankChgDateTextBox.DataField = "RANK_CHG_DATE";
			this.RankChgDateTextBox.Height = 0.15F;
			this.RankChgDateTextBox.Left = 4.055998F;
			this.RankChgDateTextBox.Name = "RankChgDateTextBox";
			this.RankChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RankChgDateTextBox.Text = "zzz6/z6/z6";
			this.RankChgDateTextBox.Top = 0.6140235F;
			this.RankChgDateTextBox.Width = 0.51F;
			// 
			// ServPlChgDateTextBox
			// 
			this.ServPlChgDateTextBox.CanGrow = false;
			this.ServPlChgDateTextBox.DataField = "SERV_PL_CHG_DATE";
			this.ServPlChgDateTextBox.Height = 0.15F;
			this.ServPlChgDateTextBox.Left = 4.055998F;
			this.ServPlChgDateTextBox.Name = "ServPlChgDateTextBox";
			this.ServPlChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ServPlChgDateTextBox.Text = "zzz6/z6/z6";
			this.ServPlChgDateTextBox.Top = 0.4690235F;
			this.ServPlChgDateTextBox.Width = 0.51F;
			// 
			// AddPostName1TextBox
			// 
			this.AddPostName1TextBox.CanGrow = false;
			this.AddPostName1TextBox.DataField = "ADD_POST_NAME_1";
			this.AddPostName1TextBox.Height = 0.156F;
			this.AddPostName1TextBox.Left = 0.4414172F;
			this.AddPostName1TextBox.Name = "AddPostName1TextBox";
			this.AddPostName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostName1TextBox.Text = "あいうえおかきくけこ";
			this.AddPostName1TextBox.Top = 2.645856F;
			this.AddPostName1TextBox.Width = 1F;
			// 
			// AddPostName5TextBox
			// 
			this.AddPostName5TextBox.CanGrow = false;
			this.AddPostName5TextBox.DataField = "ADD_POST_NAME_5";
			this.AddPostName5TextBox.Height = 0.1671667F;
			this.AddPostName5TextBox.Left = 0.4410005F;
			this.AddPostName5TextBox.Name = "AddPostName5TextBox";
			this.AddPostName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostName5TextBox.Text = "あいうえおかきくけこ";
			this.AddPostName5TextBox.Top = 3.260273F;
			this.AddPostName5TextBox.Width = 1F;
			// 
			// AddPostName3TextBox
			// 
			this.AddPostName3TextBox.CanGrow = false;
			this.AddPostName3TextBox.DataField = "ADD_POST_NAME_3";
			this.AddPostName3TextBox.Height = 0.1671667F;
			this.AddPostName3TextBox.Left = 0.4410005F;
			this.AddPostName3TextBox.Name = "AddPostName3TextBox";
			this.AddPostName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostName3TextBox.Text = "あいうえおかきくけこ";
			this.AddPostName3TextBox.Top = 2.948274F;
			this.AddPostName3TextBox.Width = 1F;
			// 
			// AddPostName2TextBox
			// 
			this.AddPostName2TextBox.CanGrow = false;
			this.AddPostName2TextBox.DataField = "ADD_POST_NAME_2";
			this.AddPostName2TextBox.Height = 0.167F;
			this.AddPostName2TextBox.Left = 0.4414172F;
			this.AddPostName2TextBox.Name = "AddPostName2TextBox";
			this.AddPostName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostName2TextBox.Text = "あいうえおかきくけこ";
			this.AddPostName2TextBox.Top = 2.79169F;
			this.AddPostName2TextBox.Width = 1F;
			// 
			// AddPostName4TextBox
			// 
			this.AddPostName4TextBox.CanGrow = false;
			this.AddPostName4TextBox.DataField = "ADD_POST_NAME_4";
			this.AddPostName4TextBox.Height = 0.1666667F;
			this.AddPostName4TextBox.Left = 0.4410005F;
			this.AddPostName4TextBox.Name = "AddPostName4TextBox";
			this.AddPostName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostName4TextBox.Text = "あいうえおかきくけこ";
			this.AddPostName4TextBox.Top = 3.104023F;
			this.AddPostName4TextBox.Width = 1F;
			// 
			// AddPostFromDate1TextBox
			// 
			this.AddPostFromDate1TextBox.CanGrow = false;
			this.AddPostFromDate1TextBox.DataField = "ADD_POST_FROM_DATE_1";
			this.AddPostFromDate1TextBox.Height = 0.15675F;
			this.AddPostFromDate1TextBox.Left = 4.055998F;
			this.AddPostFromDate1TextBox.Name = "AddPostFromDate1TextBox";
			this.AddPostFromDate1TextBox.OutputFormat = "yyyy/MM/dd";
			this.AddPostFromDate1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostFromDate1TextBox.Text = "zzz6/z6/z6";
			this.AddPostFromDate1TextBox.Top = 2.645856F;
			this.AddPostFromDate1TextBox.Width = 0.51F;
			// 
			// AtacNameTextBox
			// 
			this.AtacNameTextBox.CanGrow = false;
			this.AtacNameTextBox.DataField = "ATAC_NAME";
			this.AtacNameTextBox.Height = 0.15F;
			this.AtacNameTextBox.Left = 1.098168F;
			this.AtacNameTextBox.Name = "AtacNameTextBox";
			this.AtacNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacNameTextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほ";
			this.AtacNameTextBox.Top = 0.1700235F;
			this.AtacNameTextBox.Width = 2.958834F;
			// 
			// AddPostFromDate5TextBox
			// 
			this.AddPostFromDate5TextBox.CanGrow = false;
			this.AddPostFromDate5TextBox.DataField = "ADD_POST_FROM_DATE_5";
			this.AddPostFromDate5TextBox.Height = 0.1671667F;
			this.AddPostFromDate5TextBox.Left = 4.055998F;
			this.AddPostFromDate5TextBox.Name = "AddPostFromDate5TextBox";
			this.AddPostFromDate5TextBox.OutputFormat = "yyyy/MM/dd";
			this.AddPostFromDate5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostFromDate5TextBox.Text = "zzz6/z6/z6";
			this.AddPostFromDate5TextBox.Top = 3.26044F;
			this.AddPostFromDate5TextBox.Width = 0.51F;
			// 
			// AddPostFromDate4TextBox
			// 
			this.AddPostFromDate4TextBox.CanGrow = false;
			this.AddPostFromDate4TextBox.DataField = "ADD_POST_FROM_DATE_4";
			this.AddPostFromDate4TextBox.Height = 0.1666667F;
			this.AddPostFromDate4TextBox.Left = 4.055998F;
			this.AddPostFromDate4TextBox.Name = "AddPostFromDate4TextBox";
			this.AddPostFromDate4TextBox.OutputFormat = "yyyy/MM/dd";
			this.AddPostFromDate4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostFromDate4TextBox.Text = "zzz6/z6/z6";
			this.AddPostFromDate4TextBox.Top = 3.10419F;
			this.AddPostFromDate4TextBox.Width = 0.5099993F;
			// 
			// AddPostFromDate3TextBox
			// 
			this.AddPostFromDate3TextBox.CanGrow = false;
			this.AddPostFromDate3TextBox.DataField = "ADD_POST_FROM_DATE_3";
			this.AddPostFromDate3TextBox.Height = 0.1671666F;
			this.AddPostFromDate3TextBox.Left = 4.055998F;
			this.AddPostFromDate3TextBox.Name = "AddPostFromDate3TextBox";
			this.AddPostFromDate3TextBox.OutputFormat = "yyyy/MM/dd";
			this.AddPostFromDate3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostFromDate3TextBox.Text = "zzz6/z6/z6";
			this.AddPostFromDate3TextBox.Top = 2.94794F;
			this.AddPostFromDate3TextBox.Width = 0.51F;
			// 
			// AddPostFromDate2TextBox
			// 
			this.AddPostFromDate2TextBox.CanGrow = false;
			this.AddPostFromDate2TextBox.DataField = "ADD_POST_FROM_DATE_2";
			this.AddPostFromDate2TextBox.Height = 0.1666667F;
			this.AddPostFromDate2TextBox.Left = 4.055998F;
			this.AddPostFromDate2TextBox.Name = "AddPostFromDate2TextBox";
			this.AddPostFromDate2TextBox.OutputFormat = "yyyy/MM/dd";
			this.AddPostFromDate2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AddPostFromDate2TextBox.Text = "zzz6/z6/z6";
			this.AddPostFromDate2TextBox.Top = 2.79169F;
			this.AddPostFromDate2TextBox.Width = 0.5100002F;
			// 
			// OptItemName6TextBox
			// 
			this.OptItemName6TextBox.CanGrow = false;
			this.OptItemName6TextBox.DataField = "OPT_ITEM_NAME_6";
			this.OptItemName6TextBox.Height = 0.1666667F;
			this.OptItemName6TextBox.Left = 1.431F;
			this.OptItemName6TextBox.Name = "OptItemName6TextBox";
			this.OptItemName6TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName6TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName6TextBox.Top = 6.22919F;
			this.OptItemName6TextBox.Width = 3.770833F;
			// 
			// ItemShortName6extBox73
			// 
			this.ItemShortName6extBox73.CanGrow = false;
			this.ItemShortName6extBox73.DataField = "ITEM_SHORT_NAME_6";
			this.ItemShortName6extBox73.Height = 0.1666667F;
			this.ItemShortName6extBox73.Left = 0.4414172F;
			this.ItemShortName6extBox73.Name = "ItemShortName6extBox73";
			this.ItemShortName6extBox73.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName6extBox73.Text = "あいうえおかきくけこ";
			this.ItemShortName6extBox73.Top = 6.22919F;
			this.ItemShortName6extBox73.Width = 1F;
			// 
			// ItemShortName5TextBox
			// 
			this.ItemShortName5TextBox.CanGrow = false;
			this.ItemShortName5TextBox.DataField = "ITEM_SHORT_NAME_5";
			this.ItemShortName5TextBox.Height = 0.1666667F;
			this.ItemShortName5TextBox.Left = 0.4414172F;
			this.ItemShortName5TextBox.Name = "ItemShortName5TextBox";
			this.ItemShortName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName5TextBox.Text = "あいうえおかきくけこ";
			this.ItemShortName5TextBox.Top = 6.07294F;
			this.ItemShortName5TextBox.Width = 1F;
			// 
			// ItemShortName4TextBox
			// 
			this.ItemShortName4TextBox.CanGrow = false;
			this.ItemShortName4TextBox.DataField = "ITEM_SHORT_NAME_4";
			this.ItemShortName4TextBox.Height = 0.1666667F;
			this.ItemShortName4TextBox.Left = 0.4414172F;
			this.ItemShortName4TextBox.Name = "ItemShortName4TextBox";
			this.ItemShortName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName4TextBox.Text = "あいうえおかきくけこ";
			this.ItemShortName4TextBox.Top = 5.91669F;
			this.ItemShortName4TextBox.Width = 1F;
			// 
			// ItemShortName3TextBox
			// 
			this.ItemShortName3TextBox.CanGrow = false;
			this.ItemShortName3TextBox.DataField = "ITEM_SHORT_NAME_3";
			this.ItemShortName3TextBox.Height = 0.167F;
			this.ItemShortName3TextBox.Left = 0.4414172F;
			this.ItemShortName3TextBox.Name = "ItemShortName3TextBox";
			this.ItemShortName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName3TextBox.Text = "あいうえおかきくけこ";
			this.ItemShortName3TextBox.Top = 5.76044F;
			this.ItemShortName3TextBox.Width = 1F;
			// 
			// ItemShortName2TextBox
			// 
			this.ItemShortName2TextBox.CanGrow = false;
			this.ItemShortName2TextBox.DataField = "ITEM_SHORT_NAME_2";
			this.ItemShortName2TextBox.Height = 0.167F;
			this.ItemShortName2TextBox.Left = 0.4414172F;
			this.ItemShortName2TextBox.Name = "ItemShortName2TextBox";
			this.ItemShortName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ItemShortName2TextBox.Text = "あいうえおかきくけこ";
			this.ItemShortName2TextBox.Top = 5.60419F;
			this.ItemShortName2TextBox.Width = 1F;
			// 
			// Line285
			// 
			this.Line285.Height = 0.3130002F;
			this.Line285.Left = 4.521277F;
			this.Line285.LineWeight = 1F;
			this.Line285.Name = "Line285";
			this.Line285.Top = 5.131023F;
			this.Line285.Width = 0F;
			this.Line285.X1 = 4.521277F;
			this.Line285.X2 = 4.521277F;
			this.Line285.Y1 = 5.131023F;
			this.Line285.Y2 = 5.444023F;
			// 
			// LeaveStayPerodYTextBox
			// 
			this.LeaveStayPerodYTextBox.CanGrow = false;
			this.LeaveStayPerodYTextBox.DataField = "LEAVE_STAY_PEROD_Y";
			this.LeaveStayPerodYTextBox.Height = 0.1875F;
			this.LeaveStayPerodYTextBox.Left = 4.576828F;
			this.LeaveStayPerodYTextBox.Name = "LeaveStayPerodYTextBox";
			this.LeaveStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.LeaveStayPerodYTextBox.Text = "z9";
			this.LeaveStayPerodYTextBox.Top = 5.270856F;
			this.LeaveStayPerodYTextBox.Width = 0.125F;
			// 
			// Label71
			// 
			this.Label71.Height = 0.1875F;
			this.Label71.HyperLink = null;
			this.Label71.Left = 4.701828F;
			this.Label71.Name = "Label71";
			this.Label71.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label71.Text = "年";
			this.Label71.Top = 5.270856F;
			this.Label71.Width = 0.125F;
			// 
			// Label72
			// 
			this.Label72.Height = 0.1666667F;
			this.Label72.HyperLink = null;
			this.Label72.Left = 1.431F;
			this.Label72.Name = "Label72";
			this.Label72.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label72.Text = "出向先名／出向元名";
			this.Label72.Top = 5.13544F;
			this.Label72.Width = 1.916667F;
			// 
			// Label73
			// 
			this.Label73.Height = 0.1875F;
			this.Label73.HyperLink = null;
			this.Label73.Left = 4.889328F;
			this.Label73.Name = "Label73";
			this.Label73.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label73.Text = "ヶ月";
			this.Label73.Top = 5.270856F;
			this.Label73.Width = 0.25F;
			// 
			// AtacStayPerodTextBox
			// 
			this.AtacStayPerodTextBox.CanGrow = false;
			this.AtacStayPerodTextBox.DataField = "ATAC_STAY_PEROD_M";
			this.AtacStayPerodTextBox.Height = 0.15F;
			this.AtacStayPerodTextBox.Left = 4.805998F;
			this.AtacStayPerodTextBox.Name = "AtacStayPerodTextBox";
			this.AtacStayPerodTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AtacStayPerodTextBox.Text = "z9";
			this.AtacStayPerodTextBox.Top = 0.1700235F;
			this.AtacStayPerodTextBox.Width = 0.125F;
			// 
			// Line286
			// 
			this.Line286.Height = 0.3130002F;
			this.Line286.Left = 3.333777F;
			this.Line286.LineWeight = 1F;
			this.Line286.Name = "Line286";
			this.Line286.Top = 5.131023F;
			this.Line286.Width = 0F;
			this.Line286.X1 = 3.333777F;
			this.Line286.X2 = 3.333777F;
			this.Line286.Y1 = 5.131023F;
			this.Line286.Y2 = 5.444023F;
			// 
			// OptItemName1TextBox
			// 
			this.OptItemName1TextBox.CanGrow = false;
			this.OptItemName1TextBox.DataField = "OPT_ITEM_NAME_1";
			this.OptItemName1TextBox.Height = 0.1666667F;
			this.OptItemName1TextBox.Left = 1.431F;
			this.OptItemName1TextBox.Name = "OptItemName1TextBox";
			this.OptItemName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName1TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName1TextBox.Top = 5.44794F;
			this.OptItemName1TextBox.Width = 3.770833F;
			// 
			// OptItemName2TextBox
			// 
			this.OptItemName2TextBox.CanGrow = false;
			this.OptItemName2TextBox.DataField = "OPT_ITEM_NAME_2";
			this.OptItemName2TextBox.Height = 0.1666667F;
			this.OptItemName2TextBox.Left = 1.431F;
			this.OptItemName2TextBox.Name = "OptItemName2TextBox";
			this.OptItemName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName2TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName2TextBox.Top = 5.60419F;
			this.OptItemName2TextBox.Width = 3.770833F;
			// 
			// OptItemName3TextBox
			// 
			this.OptItemName3TextBox.CanGrow = false;
			this.OptItemName3TextBox.DataField = "OPT_ITEM_NAME_3";
			this.OptItemName3TextBox.Height = 0.1666667F;
			this.OptItemName3TextBox.Left = 1.431F;
			this.OptItemName3TextBox.Name = "OptItemName3TextBox";
			this.OptItemName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName3TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName3TextBox.Top = 5.76044F;
			this.OptItemName3TextBox.Width = 3.770833F;
			// 
			// OptItemName4TextBox
			// 
			this.OptItemName4TextBox.CanGrow = false;
			this.OptItemName4TextBox.DataField = "OPT_ITEM_NAME_4";
			this.OptItemName4TextBox.Height = 0.1666667F;
			this.OptItemName4TextBox.Left = 1.431F;
			this.OptItemName4TextBox.Name = "OptItemName4TextBox";
			this.OptItemName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName4TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName4TextBox.Top = 5.91669F;
			this.OptItemName4TextBox.Width = 3.770833F;
			// 
			// OptItemName5TextBox
			// 
			this.OptItemName5TextBox.CanGrow = false;
			this.OptItemName5TextBox.DataField = "OPT_ITEM_NAME_5";
			this.OptItemName5TextBox.Height = 0.1666667F;
			this.OptItemName5TextBox.Left = 1.431F;
			this.OptItemName5TextBox.Name = "OptItemName5TextBox";
			this.OptItemName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.OptItemName5TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやいゆ";
			this.OptItemName5TextBox.Top = 6.07294F;
			this.OptItemName5TextBox.Width = 3.770833F;
			// 
			// Label79
			// 
			this.Label79.Height = 0.1666667F;
			this.Label79.HyperLink = null;
			this.Label79.Left = 1.441417F;
			this.Label79.Name = "Label79";
			this.Label79.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label79.Text = "TO";
			this.Label79.Top = 4.35419F;
			this.Label79.Width = 1.03125F;
			// 
			// Label80
			// 
			this.Label80.Height = 0.1666667F;
			this.Label80.HyperLink = null;
			this.Label80.Left = 2.46225F;
			this.Label80.Name = "Label80";
			this.Label80.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label80.Text = "交通手段";
			this.Label80.Top = 4.35419F;
			this.Label80.Width = 0.6250001F;
			// 
			// Label81
			// 
			this.Label81.Height = 0.1666667F;
			this.Label81.HyperLink = null;
			this.Label81.Left = 3.076832F;
			this.Label81.Name = "Label81";
			this.Label81.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label81.Text = "通勤手当";
			this.Label81.Top = 4.35419F;
			this.Label81.Width = 0.53125F;
			// 
			// Label82
			// 
			this.Label82.Height = 0.1666667F;
			this.Label82.HyperLink = null;
			this.Label82.Left = 3.597666F;
			this.Label82.Name = "Label82";
			this.Label82.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label82.Text = "備考";
			this.Label82.Top = 4.35419F;
			this.Label82.Width = 1.59375F;
			// 
			// Line296
			// 
			this.Line296.Height = 0.7789991F;
			this.Line296.Left = 4.344193F;
			this.Line296.LineWeight = 1F;
			this.Line296.Name = "Line296";
			this.Line296.Top = 3.417024F;
			this.Line296.Width = 0F;
			this.Line296.X1 = 4.344193F;
			this.Line296.X2 = 4.344193F;
			this.Line296.Y1 = 3.417024F;
			this.Line296.Y2 = 4.196023F;
			// 
			// ClsName4TextBox
			// 
			this.ClsName4TextBox.CanGrow = false;
			this.ClsName4TextBox.DataField = "CLS_NAME_4";
			this.ClsName4TextBox.Height = 0.188F;
			this.ClsName4TextBox.Left = 4.566168F;
			this.ClsName4TextBox.Name = "ClsName4TextBox";
			this.ClsName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName4TextBox.Text = "あいうえおか";
			this.ClsName4TextBox.Top = 4.031024F;
			this.ClsName4TextBox.Width = 0.6358333F;
			// 
			// ClsName3TextBox
			// 
			this.ClsName3TextBox.CanGrow = false;
			this.ClsName3TextBox.DataField = "CLS_NAME_3";
			this.ClsName3TextBox.Height = 0.125F;
			this.ClsName3TextBox.Left = 4.566168F;
			this.ClsName3TextBox.Name = "ClsName3TextBox";
			this.ClsName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName3TextBox.Text = "あいうえおか";
			this.ClsName3TextBox.Top = 3.906024F;
			this.ClsName3TextBox.Width = 0.6358333F;
			// 
			// ClsName2TextBox
			// 
			this.ClsName2TextBox.CanGrow = false;
			this.ClsName2TextBox.DataField = "CLS_NAME_2";
			this.ClsName2TextBox.Height = 0.1775833F;
			this.ClsName2TextBox.Left = 4.566168F;
			this.ClsName2TextBox.Name = "ClsName2TextBox";
			this.ClsName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsName2TextBox.Text = "あいうえおか";
			this.ClsName2TextBox.Top = 3.729441F;
			this.ClsName2TextBox.Width = 0.6358333F;
			// 
			// TrnTo1TextBox
			// 
			this.TrnTo1TextBox.CanGrow = false;
			this.TrnTo1TextBox.DataField = "TRN_TO_1";
			this.TrnTo1TextBox.Height = 0.1666667F;
			this.TrnTo1TextBox.Left = 1.441416F;
			this.TrnTo1TextBox.Name = "TrnTo1TextBox";
			this.TrnTo1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnTo1TextBox.Text = "あいうえおかきくけこ";
			this.TrnTo1TextBox.Top = 4.51044F;
			this.TrnTo1TextBox.Width = 1.03125F;
			// 
			// TrnTo4TextBox
			// 
			this.TrnTo4TextBox.CanGrow = false;
			this.TrnTo4TextBox.DataField = "TRN_TO_4";
			this.TrnTo4TextBox.Height = 0.1666666F;
			this.TrnTo4TextBox.Left = 1.441416F;
			this.TrnTo4TextBox.Name = "TrnTo4TextBox";
			this.TrnTo4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnTo4TextBox.Text = "あいうえおかきくけこ";
			this.TrnTo4TextBox.Top = 4.97919F;
			this.TrnTo4TextBox.Width = 1.03125F;
			// 
			// TrnTo2TextBox
			// 
			this.TrnTo2TextBox.CanGrow = false;
			this.TrnTo2TextBox.DataField = "TRN_TO_2";
			this.TrnTo2TextBox.Height = 0.15625F;
			this.TrnTo2TextBox.Left = 1.441416F;
			this.TrnTo2TextBox.Name = "TrnTo2TextBox";
			this.TrnTo2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnTo2TextBox.Text = "あいうえおかきくけこ";
			this.TrnTo2TextBox.Top = 4.66669F;
			this.TrnTo2TextBox.Width = 1.03125F;
			// 
			// TrnTo3TextBox
			// 
			this.TrnTo3TextBox.CanGrow = false;
			this.TrnTo3TextBox.DataField = "TRN_TO_3";
			this.TrnTo3TextBox.Height = 0.1666667F;
			this.TrnTo3TextBox.Left = 1.441416F;
			this.TrnTo3TextBox.Name = "TrnTo3TextBox";
			this.TrnTo3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnTo3TextBox.Text = "あいうえおかきくけこ";
			this.TrnTo3TextBox.Top = 4.82294F;
			this.TrnTo3TextBox.Width = 1.03125F;
			// 
			// TrnMeansName1TextBox
			// 
			this.TrnMeansName1TextBox.CanGrow = false;
			this.TrnMeansName1TextBox.DataField = "TRN_MEANS_NAME_1";
			this.TrnMeansName1TextBox.Height = 0.1666667F;
			this.TrnMeansName1TextBox.Left = 2.46225F;
			this.TrnMeansName1TextBox.Name = "TrnMeansName1TextBox";
			this.TrnMeansName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnMeansName1TextBox.Text = "あいうえお";
			this.TrnMeansName1TextBox.Top = 4.51044F;
			this.TrnMeansName1TextBox.Width = 0.625F;
			// 
			// TrnMeansName2TextBox
			// 
			this.TrnMeansName2TextBox.CanGrow = false;
			this.TrnMeansName2TextBox.DataField = "TRN_MEANS_NAME_2";
			this.TrnMeansName2TextBox.Height = 0.15625F;
			this.TrnMeansName2TextBox.Left = 2.46225F;
			this.TrnMeansName2TextBox.Name = "TrnMeansName2TextBox";
			this.TrnMeansName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnMeansName2TextBox.Text = "あいうえお";
			this.TrnMeansName2TextBox.Top = 4.66669F;
			this.TrnMeansName2TextBox.Width = 0.625F;
			// 
			// TrnMeansName3TextBox
			// 
			this.TrnMeansName3TextBox.CanGrow = false;
			this.TrnMeansName3TextBox.DataField = "TRN_MEANS_NAME_3";
			this.TrnMeansName3TextBox.Height = 0.1666667F;
			this.TrnMeansName3TextBox.Left = 2.46225F;
			this.TrnMeansName3TextBox.Name = "TrnMeansName3TextBox";
			this.TrnMeansName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnMeansName3TextBox.Text = "あいうえお";
			this.TrnMeansName3TextBox.Top = 4.82294F;
			this.TrnMeansName3TextBox.Width = 0.625F;
			// 
			// TrnMeansName4TextBox
			// 
			this.TrnMeansName4TextBox.CanGrow = false;
			this.TrnMeansName4TextBox.DataField = "TRN_MEANS_NAME_4";
			this.TrnMeansName4TextBox.Height = 0.1666666F;
			this.TrnMeansName4TextBox.Left = 2.46225F;
			this.TrnMeansName4TextBox.Name = "TrnMeansName4TextBox";
			this.TrnMeansName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TrnMeansName4TextBox.Text = "あいうえお";
			this.TrnMeansName4TextBox.Top = 4.97919F;
			this.TrnMeansName4TextBox.Width = 0.625F;
			// 
			// TrnspAlowAmt4TextBox
			// 
			this.TrnspAlowAmt4TextBox.CanGrow = false;
			this.TrnspAlowAmt4TextBox.DataField = "TRNSP_ALOW_AMT_4";
			this.TrnspAlowAmt4TextBox.Height = 0.1666666F;
			this.TrnspAlowAmt4TextBox.Left = 3.076832F;
			this.TrnspAlowAmt4TextBox.Name = "TrnspAlowAmt4TextBox";
			this.TrnspAlowAmt4TextBox.OutputFormat = "#,##0";
			this.TrnspAlowAmt4TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TrnspAlowAmt4TextBox.Text = "z,zzz,zz6";
			this.TrnspAlowAmt4TextBox.Top = 4.97919F;
			this.TrnspAlowAmt4TextBox.Width = 0.53125F;
			// 
			// Remarks1TextBox
			// 
			this.Remarks1TextBox.CanGrow = false;
			this.Remarks1TextBox.DataField = "REMARKS_1";
			this.Remarks1TextBox.Height = 0.1666667F;
			this.Remarks1TextBox.Left = 3.597666F;
			this.Remarks1TextBox.Name = "Remarks1TextBox";
			this.Remarks1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Remarks1TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.Remarks1TextBox.Top = 4.51044F;
			this.Remarks1TextBox.Width = 1.59375F;
			// 
			// TrnspAlowAmt1TextBox
			// 
			this.TrnspAlowAmt1TextBox.CanGrow = false;
			this.TrnspAlowAmt1TextBox.DataField = "TRNSP_ALOW_AMT_1";
			this.TrnspAlowAmt1TextBox.Height = 0.1666667F;
			this.TrnspAlowAmt1TextBox.Left = 3.076832F;
			this.TrnspAlowAmt1TextBox.Name = "TrnspAlowAmt1TextBox";
			this.TrnspAlowAmt1TextBox.OutputFormat = "#,##0";
			this.TrnspAlowAmt1TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TrnspAlowAmt1TextBox.Text = "z,zzz,zz6";
			this.TrnspAlowAmt1TextBox.Top = 4.51044F;
			this.TrnspAlowAmt1TextBox.Width = 0.53125F;
			// 
			// TrnspAlowAmt3TextBox
			// 
			this.TrnspAlowAmt3TextBox.CanGrow = false;
			this.TrnspAlowAmt3TextBox.DataField = "TRNSP_ALOW_AMT_3";
			this.TrnspAlowAmt3TextBox.Height = 0.1666667F;
			this.TrnspAlowAmt3TextBox.Left = 3.076832F;
			this.TrnspAlowAmt3TextBox.Name = "TrnspAlowAmt3TextBox";
			this.TrnspAlowAmt3TextBox.OutputFormat = "#,##0";
			this.TrnspAlowAmt3TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TrnspAlowAmt3TextBox.Text = "z,zzz,zz6";
			this.TrnspAlowAmt3TextBox.Top = 4.82294F;
			this.TrnspAlowAmt3TextBox.Width = 0.53125F;
			// 
			// TrnspAlowAmt2TextBox
			// 
			this.TrnspAlowAmt2TextBox.CanGrow = false;
			this.TrnspAlowAmt2TextBox.DataField = "TRNSP_ALOW_AMT_2";
			this.TrnspAlowAmt2TextBox.Height = 0.15625F;
			this.TrnspAlowAmt2TextBox.Left = 3.076832F;
			this.TrnspAlowAmt2TextBox.Name = "TrnspAlowAmt2TextBox";
			this.TrnspAlowAmt2TextBox.OutputFormat = "#,##0";
			this.TrnspAlowAmt2TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TrnspAlowAmt2TextBox.Text = "z,zzz,zz6";
			this.TrnspAlowAmt2TextBox.Top = 4.66669F;
			this.TrnspAlowAmt2TextBox.Width = 0.53125F;
			// 
			// Remarks4TextBox
			// 
			this.Remarks4TextBox.CanGrow = false;
			this.Remarks4TextBox.DataField = "REMARKS_4";
			this.Remarks4TextBox.Height = 0.1666666F;
			this.Remarks4TextBox.Left = 3.597666F;
			this.Remarks4TextBox.Name = "Remarks4TextBox";
			this.Remarks4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Remarks4TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.Remarks4TextBox.Top = 4.97919F;
			this.Remarks4TextBox.Width = 1.59375F;
			// 
			// Remarks3TextBox
			// 
			this.Remarks3TextBox.CanGrow = false;
			this.Remarks3TextBox.DataField = "REMARKS_3";
			this.Remarks3TextBox.Height = 0.1666667F;
			this.Remarks3TextBox.Left = 3.597666F;
			this.Remarks3TextBox.Name = "Remarks3TextBox";
			this.Remarks3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Remarks3TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.Remarks3TextBox.Top = 4.82294F;
			this.Remarks3TextBox.Width = 1.59375F;
			// 
			// Remarks2TextBox
			// 
			this.Remarks2TextBox.CanGrow = false;
			this.Remarks2TextBox.DataField = "REMARKS_2";
			this.Remarks2TextBox.Height = 0.15625F;
			this.Remarks2TextBox.Left = 3.597666F;
			this.Remarks2TextBox.Name = "Remarks2TextBox";
			this.Remarks2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Remarks2TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.Remarks2TextBox.Top = 4.66669F;
			this.Remarks2TextBox.Width = 1.59375F;
			// 
			// AtacStayPerodYTextBox
			// 
			this.AtacStayPerodYTextBox.CanGrow = false;
			this.AtacStayPerodYTextBox.DataField = "ATAC_STAY_PEROD_Y";
			this.AtacStayPerodYTextBox.Height = 0.15F;
			this.AtacStayPerodYTextBox.Left = 4.555998F;
			this.AtacStayPerodYTextBox.Name = "AtacStayPerodYTextBox";
			this.AtacStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AtacStayPerodYTextBox.Text = "z9";
			this.AtacStayPerodYTextBox.Top = 0.1700235F;
			this.AtacStayPerodYTextBox.Width = 0.125F;
			// 
			// Label150
			// 
			this.Label150.Height = 0.15F;
			this.Label150.HyperLink = null;
			this.Label150.Left = 4.680998F;
			this.Label150.Name = "Label150";
			this.Label150.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label150.Text = "年";
			this.Label150.Top = 0.1700235F;
			this.Label150.Width = 0.125F;
			// 
			// LeaveStayPerodMTextBox
			// 
			this.LeaveStayPerodMTextBox.CanGrow = false;
			this.LeaveStayPerodMTextBox.DataField = "LEAVE_STAY_PEROD_M";
			this.LeaveStayPerodMTextBox.Height = 0.1875F;
			this.LeaveStayPerodMTextBox.Left = 4.826828F;
			this.LeaveStayPerodMTextBox.Name = "LeaveStayPerodMTextBox";
			this.LeaveStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.LeaveStayPerodMTextBox.Text = "z9";
			this.LeaveStayPerodMTextBox.Top = 5.270856F;
			this.LeaveStayPerodMTextBox.Width = 0.125F;
			// 
			// Label151
			// 
			this.Label151.Height = 0.15F;
			this.Label151.HyperLink = null;
			this.Label151.Left = 4.930998F;
			this.Label151.Name = "Label151";
			this.Label151.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label151.Text = "ヶ月";
			this.Label151.Top = 0.1700235F;
			this.Label151.Width = 0.25F;
			// 
			// AtacChgDateTextBox
			// 
			this.AtacChgDateTextBox.CanGrow = false;
			this.AtacChgDateTextBox.DataField = "ATAC_CHG_DATE";
			this.AtacChgDateTextBox.Height = 0.15F;
			this.AtacChgDateTextBox.Left = 4.055998F;
			this.AtacChgDateTextBox.Name = "AtacChgDateTextBox";
			this.AtacChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AtacChgDateTextBox.Text = "zzz6/z6/z6";
			this.AtacChgDateTextBox.Top = 0.1700235F;
			this.AtacChgDateTextBox.Width = 0.51F;
			// 
			// PostStayPerpdYTextBox
			// 
			this.PostStayPerpdYTextBox.CanGrow = false;
			this.PostStayPerpdYTextBox.DataField = "POST_STAY_PEROD_Y";
			this.PostStayPerpdYTextBox.Height = 0.15F;
			this.PostStayPerpdYTextBox.Left = 4.566418F;
			this.PostStayPerpdYTextBox.Name = "PostStayPerpdYTextBox";
			this.PostStayPerpdYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PostStayPerpdYTextBox.Text = "z9";
			this.PostStayPerpdYTextBox.Top = 0.7637735F;
			this.PostStayPerpdYTextBox.Width = 0.125F;
			// 
			// DutyStayPerodYTextBox
			// 
			this.DutyStayPerodYTextBox.CanGrow = false;
			this.DutyStayPerodYTextBox.DataField = "DUTY_STAY_PEROD_Y";
			this.DutyStayPerodYTextBox.Height = 0.15F;
			this.DutyStayPerodYTextBox.Left = 4.566418F;
			this.DutyStayPerodYTextBox.Name = "DutyStayPerodYTextBox";
			this.DutyStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DutyStayPerodYTextBox.Text = "z9";
			this.DutyStayPerodYTextBox.Top = 0.9062735F;
			this.DutyStayPerodYTextBox.Width = 0.125F;
			// 
			// QualfJobStayPerodYTextBox
			// 
			this.QualfJobStayPerodYTextBox.CanGrow = false;
			this.QualfJobStayPerodYTextBox.DataField = "QUALF_JOB_STAY_PEROD_Y";
			this.QualfJobStayPerodYTextBox.Height = 0.15F;
			this.QualfJobStayPerodYTextBox.Left = 4.566418F;
			this.QualfJobStayPerodYTextBox.Name = "QualfJobStayPerodYTextBox";
			this.QualfJobStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.QualfJobStayPerodYTextBox.Text = "z9";
			this.QualfJobStayPerodYTextBox.Top = 1.243773F;
			this.QualfJobStayPerodYTextBox.Width = 0.125F;
			// 
			// Label154
			// 
			this.Label154.Height = 0.15F;
			this.Label154.HyperLink = null;
			this.Label154.Left = 4.691418F;
			this.Label154.Name = "Label154";
			this.Label154.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label154.Text = "年";
			this.Label154.Top = 1.243773F;
			this.Label154.Width = 0.125F;
			// 
			// Label155
			// 
			this.Label155.Height = 0.15F;
			this.Label155.HyperLink = null;
			this.Label155.Left = 4.691418F;
			this.Label155.Name = "Label155";
			this.Label155.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label155.Text = "年";
			this.Label155.Top = 0.9137736F;
			this.Label155.Width = 0.125F;
			// 
			// Label157
			// 
			this.Label157.Height = 0.15F;
			this.Label157.HyperLink = null;
			this.Label157.Left = 4.691418F;
			this.Label157.Name = "Label157";
			this.Label157.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label157.Text = "年";
			this.Label157.Top = 0.7637735F;
			this.Label157.Width = 0.125F;
			// 
			// PostStayPerodMTextBox
			// 
			this.PostStayPerodMTextBox.CanGrow = false;
			this.PostStayPerodMTextBox.DataField = "POST_STAY_PEROD_M";
			this.PostStayPerodMTextBox.Height = 0.15F;
			this.PostStayPerodMTextBox.Left = 4.816418F;
			this.PostStayPerodMTextBox.Name = "PostStayPerodMTextBox";
			this.PostStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PostStayPerodMTextBox.Text = "z9";
			this.PostStayPerodMTextBox.Top = 0.7812735F;
			this.PostStayPerodMTextBox.Width = 0.125F;
			// 
			// Label158
			// 
			this.Label158.Height = 0.15F;
			this.Label158.HyperLink = null;
			this.Label158.Left = 4.930998F;
			this.Label158.Name = "Label158";
			this.Label158.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label158.Text = "ヶ月";
			this.Label158.Top = 0.7637735F;
			this.Label158.Width = 0.25F;
			// 
			// DutyStayPerodMTextBox
			// 
			this.DutyStayPerodMTextBox.CanGrow = false;
			this.DutyStayPerodMTextBox.DataField = "DUTY_STAY_PEROD_M";
			this.DutyStayPerodMTextBox.Height = 0.15F;
			this.DutyStayPerodMTextBox.Left = 4.816418F;
			this.DutyStayPerodMTextBox.Name = "DutyStayPerodMTextBox";
			this.DutyStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.DutyStayPerodMTextBox.Text = "z9";
			this.DutyStayPerodMTextBox.Top = 0.9137736F;
			this.DutyStayPerodMTextBox.Width = 0.125F;
			// 
			// QualfJobStayPerodMTextBox
			// 
			this.QualfJobStayPerodMTextBox.CanGrow = false;
			this.QualfJobStayPerodMTextBox.DataField = "QUALF_JOB_STAY_PEROD_M";
			this.QualfJobStayPerodMTextBox.Height = 0.15F;
			this.QualfJobStayPerodMTextBox.Left = 4.816418F;
			this.QualfJobStayPerodMTextBox.Name = "QualfJobStayPerodMTextBox";
			this.QualfJobStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.QualfJobStayPerodMTextBox.Text = "z9";
			this.QualfJobStayPerodMTextBox.Top = 1.243773F;
			this.QualfJobStayPerodMTextBox.Width = 0.125F;
			// 
			// Label160
			// 
			this.Label160.Height = 0.15F;
			this.Label160.HyperLink = null;
			this.Label160.Left = 4.930998F;
			this.Label160.Name = "Label160";
			this.Label160.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label160.Text = "ヶ月";
			this.Label160.Top = 1.243773F;
			this.Label160.Width = 0.25F;
			// 
			// Label161
			// 
			this.Label161.Height = 0.15F;
			this.Label161.HyperLink = null;
			this.Label161.Left = 4.930998F;
			this.Label161.Name = "Label161";
			this.Label161.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label161.Text = "ヶ月";
			this.Label161.Top = 0.9137736F;
			this.Label161.Width = 0.25F;
			// 
			// AddPostStayPerodY1TextBox
			// 
			this.AddPostStayPerodY1TextBox.CanGrow = false;
			this.AddPostStayPerodY1TextBox.DataField = "ADD_POST_STAY_PEROD_Y_1";
			this.AddPostStayPerodY1TextBox.Height = 0.15625F;
			this.AddPostStayPerodY1TextBox.Left = 4.566418F;
			this.AddPostStayPerodY1TextBox.Name = "AddPostStayPerodY1TextBox";
			this.AddPostStayPerodY1TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodY1TextBox.Text = "z9";
			this.AddPostStayPerodY1TextBox.Top = 2.645856F;
			this.AddPostStayPerodY1TextBox.Width = 0.125F;
			// 
			// Label162
			// 
			this.Label162.Height = 0.15625F;
			this.Label162.HyperLink = null;
			this.Label162.Left = 4.691418F;
			this.Label162.Name = "Label162";
			this.Label162.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label162.Text = "年";
			this.Label162.Top = 2.645856F;
			this.Label162.Width = 0.125F;
			// 
			// AddPostStayPerodM1TextBox
			// 
			this.AddPostStayPerodM1TextBox.CanGrow = false;
			this.AddPostStayPerodM1TextBox.DataField = "ADD_POST_STAY_PEROD_M_1";
			this.AddPostStayPerodM1TextBox.Height = 0.15625F;
			this.AddPostStayPerodM1TextBox.Left = 4.816418F;
			this.AddPostStayPerodM1TextBox.Name = "AddPostStayPerodM1TextBox";
			this.AddPostStayPerodM1TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodM1TextBox.Text = "z9";
			this.AddPostStayPerodM1TextBox.Top = 2.645856F;
			this.AddPostStayPerodM1TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodY2TextBox
			// 
			this.AddPostStayPerodY2TextBox.CanGrow = false;
			this.AddPostStayPerodY2TextBox.DataField = "ADD_POST_STAY_PEROD_Y_2";
			this.AddPostStayPerodY2TextBox.Height = 0.1666667F;
			this.AddPostStayPerodY2TextBox.Left = 4.566418F;
			this.AddPostStayPerodY2TextBox.Name = "AddPostStayPerodY2TextBox";
			this.AddPostStayPerodY2TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodY2TextBox.Text = "z9";
			this.AddPostStayPerodY2TextBox.Top = 2.79169F;
			this.AddPostStayPerodY2TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodY5TextBox
			// 
			this.AddPostStayPerodY5TextBox.CanGrow = false;
			this.AddPostStayPerodY5TextBox.DataField = "ADD_POST_STAY_PEROD_Y_5";
			this.AddPostStayPerodY5TextBox.Height = 0.1666667F;
			this.AddPostStayPerodY5TextBox.Left = 4.566418F;
			this.AddPostStayPerodY5TextBox.Name = "AddPostStayPerodY5TextBox";
			this.AddPostStayPerodY5TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodY5TextBox.Text = "z9";
			this.AddPostStayPerodY5TextBox.Top = 3.26044F;
			this.AddPostStayPerodY5TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodY3TextBox
			// 
			this.AddPostStayPerodY3TextBox.CanGrow = false;
			this.AddPostStayPerodY3TextBox.DataField = "ADD_POST_STAY_PEROD_Y_3";
			this.AddPostStayPerodY3TextBox.Height = 0.1666667F;
			this.AddPostStayPerodY3TextBox.Left = 4.566418F;
			this.AddPostStayPerodY3TextBox.Name = "AddPostStayPerodY3TextBox";
			this.AddPostStayPerodY3TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodY3TextBox.Text = "z9";
			this.AddPostStayPerodY3TextBox.Top = 2.94794F;
			this.AddPostStayPerodY3TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodY4TextBox
			// 
			this.AddPostStayPerodY4TextBox.CanGrow = false;
			this.AddPostStayPerodY4TextBox.DataField = "ADD_POST_STAY_PEROD_Y_4";
			this.AddPostStayPerodY4TextBox.Height = 0.1666667F;
			this.AddPostStayPerodY4TextBox.Left = 4.566418F;
			this.AddPostStayPerodY4TextBox.Name = "AddPostStayPerodY4TextBox";
			this.AddPostStayPerodY4TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodY4TextBox.Text = "z9";
			this.AddPostStayPerodY4TextBox.Top = 3.10419F;
			this.AddPostStayPerodY4TextBox.Width = 0.125F;
			// 
			// Label164
			// 
			this.Label164.Height = 0.1666666F;
			this.Label164.HyperLink = null;
			this.Label164.Left = 4.691418F;
			this.Label164.Name = "Label164";
			this.Label164.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label164.Text = "年";
			this.Label164.Top = 3.26044F;
			this.Label164.Width = 0.125F;
			// 
			// Label165
			// 
			this.Label165.Height = 0.1666667F;
			this.Label165.HyperLink = null;
			this.Label165.Left = 4.691418F;
			this.Label165.Name = "Label165";
			this.Label165.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label165.Text = "年";
			this.Label165.Top = 3.10419F;
			this.Label165.Width = 0.125F;
			// 
			// Label166
			// 
			this.Label166.Height = 0.1666667F;
			this.Label166.HyperLink = null;
			this.Label166.Left = 4.691418F;
			this.Label166.Name = "Label166";
			this.Label166.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label166.Text = "年";
			this.Label166.Top = 2.94794F;
			this.Label166.Width = 0.125F;
			// 
			// Label167
			// 
			this.Label167.Height = 0.1666666F;
			this.Label167.HyperLink = null;
			this.Label167.Left = 4.691418F;
			this.Label167.Name = "Label167";
			this.Label167.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label167.Text = "年";
			this.Label167.Top = 2.79169F;
			this.Label167.Width = 0.125F;
			// 
			// AddPostStayPerodM2TextBox
			// 
			this.AddPostStayPerodM2TextBox.CanGrow = false;
			this.AddPostStayPerodM2TextBox.DataField = "ADD_POST_STAY_PEROD_M_2";
			this.AddPostStayPerodM2TextBox.Height = 0.1666666F;
			this.AddPostStayPerodM2TextBox.Left = 4.816418F;
			this.AddPostStayPerodM2TextBox.Name = "AddPostStayPerodM2TextBox";
			this.AddPostStayPerodM2TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodM2TextBox.Text = "z9";
			this.AddPostStayPerodM2TextBox.Top = 2.79169F;
			this.AddPostStayPerodM2TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodM3TextBox
			// 
			this.AddPostStayPerodM3TextBox.CanGrow = false;
			this.AddPostStayPerodM3TextBox.DataField = "ADD_POST_STAY_PEROD_M_3";
			this.AddPostStayPerodM3TextBox.Height = 0.1666667F;
			this.AddPostStayPerodM3TextBox.Left = 4.816418F;
			this.AddPostStayPerodM3TextBox.Name = "AddPostStayPerodM3TextBox";
			this.AddPostStayPerodM3TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodM3TextBox.Text = "z9";
			this.AddPostStayPerodM3TextBox.Top = 2.94794F;
			this.AddPostStayPerodM3TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodM4TextBox
			// 
			this.AddPostStayPerodM4TextBox.CanGrow = false;
			this.AddPostStayPerodM4TextBox.DataField = "ADD_POST_STAY_PEROD_M_4";
			this.AddPostStayPerodM4TextBox.Height = 0.1666667F;
			this.AddPostStayPerodM4TextBox.Left = 4.816418F;
			this.AddPostStayPerodM4TextBox.Name = "AddPostStayPerodM4TextBox";
			this.AddPostStayPerodM4TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodM4TextBox.Text = "z9";
			this.AddPostStayPerodM4TextBox.Top = 3.10419F;
			this.AddPostStayPerodM4TextBox.Width = 0.125F;
			// 
			// AddPostStayPerodM5TextBox
			// 
			this.AddPostStayPerodM5TextBox.CanGrow = false;
			this.AddPostStayPerodM5TextBox.DataField = "ADD_POST_STAY_PEROD_M_5";
			this.AddPostStayPerodM5TextBox.Height = 0.1666666F;
			this.AddPostStayPerodM5TextBox.Left = 4.816418F;
			this.AddPostStayPerodM5TextBox.Name = "AddPostStayPerodM5TextBox";
			this.AddPostStayPerodM5TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.AddPostStayPerodM5TextBox.Text = "z9";
			this.AddPostStayPerodM5TextBox.Top = 3.26044F;
			this.AddPostStayPerodM5TextBox.Width = 0.125F;
			// 
			// Line329
			// 
			this.Line329.Height = 0.1609998F;
			this.Line329.Left = 1.760417F;
			this.Line329.LineWeight = 1F;
			this.Line329.Name = "Line329";
			this.Line329.Top = 4.196023F;
			this.Line329.Width = 0F;
			this.Line329.X1 = 1.760417F;
			this.Line329.X2 = 1.760417F;
			this.Line329.Y1 = 4.196023F;
			this.Line329.Y2 = 4.357023F;
			// 
			// Line330
			// 
			this.Line330.Height = 0.7740002F;
			this.Line330.Left = 2.458778F;
			this.Line330.LineWeight = 1F;
			this.Line330.Name = "Line330";
			this.Line330.Top = 4.357023F;
			this.Line330.Width = 0.0004990101F;
			this.Line330.X1 = 2.458778F;
			this.Line330.X2 = 2.459277F;
			this.Line330.Y1 = 4.357023F;
			this.Line330.Y2 = 5.131023F;
			// 
			// Line331
			// 
			this.Line331.Height = 0.1609998F;
			this.Line331.Left = 2.260417F;
			this.Line331.LineWeight = 1F;
			this.Line331.Name = "Line331";
			this.Line331.Top = 4.196023F;
			this.Line331.Width = 0F;
			this.Line331.X1 = 2.260417F;
			this.Line331.X2 = 2.260417F;
			this.Line331.Y1 = 4.196023F;
			this.Line331.Y2 = 4.357023F;
			// 
			// Line332
			// 
			this.Line332.Height = 0.1609998F;
			this.Line332.Left = 3.260417F;
			this.Line332.LineWeight = 1F;
			this.Line332.Name = "Line332";
			this.Line332.Top = 4.196023F;
			this.Line332.Width = 0F;
			this.Line332.X1 = 3.260417F;
			this.Line332.X2 = 3.260417F;
			this.Line332.Y1 = 4.196023F;
			this.Line332.Y2 = 4.357023F;
			// 
			// Line333
			// 
			this.Line333.Height = 0.7740002F;
			this.Line333.Left = 3.073861F;
			this.Line333.LineWeight = 1F;
			this.Line333.Name = "Line333";
			this.Line333.Top = 4.357023F;
			this.Line333.Width = 0.0001370907F;
			this.Line333.X1 = 3.073998F;
			this.Line333.X2 = 3.073861F;
			this.Line333.Y1 = 4.357023F;
			this.Line333.Y2 = 5.131023F;
			// 
			// EepenAtacNameTextBox
			// 
			this.EepenAtacNameTextBox.CanGrow = false;
			this.EepenAtacNameTextBox.DataField = "EXPEN_ATAC_NAME";
			this.EepenAtacNameTextBox.Height = 0.15F;
			this.EepenAtacNameTextBox.Left = 1.098168F;
			this.EepenAtacNameTextBox.Name = "EepenAtacNameTextBox";
			this.EepenAtacNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EepenAtacNameTextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほ";
			this.EepenAtacNameTextBox.Top = 0.3130235F;
			this.EepenAtacNameTextBox.Width = 2.958834F;
			// 
			// ServPlNameTextBox
			// 
			this.ServPlNameTextBox.CanGrow = false;
			this.ServPlNameTextBox.DataField = "SERV_PL_NAME";
			this.ServPlNameTextBox.Height = 0.15F;
			this.ServPlNameTextBox.Left = 1.097667F;
			this.ServPlNameTextBox.Name = "ServPlNameTextBox";
			this.ServPlNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ServPlNameTextBox.Text = "あいうえおかきくけこ";
			this.ServPlNameTextBox.Top = 0.4687736F;
			this.ServPlNameTextBox.Width = 2.96875F;
			// 
			// JobNameTextBox
			// 
			this.JobNameTextBox.CanGrow = false;
			this.JobNameTextBox.DataField = "JOB_NAME";
			this.JobNameTextBox.Height = 0.15F;
			this.JobNameTextBox.Left = 1.098168F;
			this.JobNameTextBox.Name = "JobNameTextBox";
			this.JobNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobNameTextBox.Text = "あいうえおかきくけこ";
			this.JobNameTextBox.Top = 1.403773F;
			this.JobNameTextBox.Width = 2.96875F;
			// 
			// QualfJobNameTextBox
			// 
			this.QualfJobNameTextBox.CanGrow = false;
			this.QualfJobNameTextBox.DataField = "QUALF_JOB_NAME";
			this.QualfJobNameTextBox.Height = 0.15F;
			this.QualfJobNameTextBox.Left = 1.098168F;
			this.QualfJobNameTextBox.Name = "QualfJobNameTextBox";
			this.QualfJobNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.QualfJobNameTextBox.Text = "あいうえおかきくけこ";
			this.QualfJobNameTextBox.Top = 1.243773F;
			this.QualfJobNameTextBox.Width = 2.96875F;
			// 
			// GradeNameTextBox
			// 
			this.GradeNameTextBox.CanGrow = false;
			this.GradeNameTextBox.DataField = "GRADE_NAME";
			this.GradeNameTextBox.Height = 0.15F;
			this.GradeNameTextBox.Left = 1.098168F;
			this.GradeNameTextBox.Name = "GradeNameTextBox";
			this.GradeNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GradeNameTextBox.Text = "あいうえおかきくけこ";
			this.GradeNameTextBox.Top = 1.073774F;
			this.GradeNameTextBox.Width = 2.96875F;
			// 
			// DutyNameTextBox
			// 
			this.DutyNameTextBox.CanGrow = false;
			this.DutyNameTextBox.DataField = "DUTY_NAME";
			this.DutyNameTextBox.Height = 0.15F;
			this.DutyNameTextBox.Left = 1.098168F;
			this.DutyNameTextBox.Name = "DutyNameTextBox";
			this.DutyNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.DutyNameTextBox.Text = "あいうえおかきくけこ";
			this.DutyNameTextBox.Top = 0.9137736F;
			this.DutyNameTextBox.Width = 2.96875F;
			// 
			// PostNameTextBox
			// 
			this.PostNameTextBox.CanGrow = false;
			this.PostNameTextBox.DataField = "POST_NAME";
			this.PostNameTextBox.Height = 0.15F;
			this.PostNameTextBox.Left = 1.098168F;
			this.PostNameTextBox.Name = "PostNameTextBox";
			this.PostNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PostNameTextBox.Text = "あいうえおかきくけこ";
			this.PostNameTextBox.Top = 0.7637735F;
			this.PostNameTextBox.Width = 2.96875F;
			// 
			// RankNameTextBox
			// 
			this.RankNameTextBox.CanGrow = false;
			this.RankNameTextBox.DataField = "RANK_NAME";
			this.RankNameTextBox.Height = 0.15F;
			this.RankNameTextBox.Left = 1.098168F;
			this.RankNameTextBox.Name = "RankNameTextBox";
			this.RankNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RankNameTextBox.Text = "あいうえおかきくけこ";
			this.RankNameTextBox.Top = 0.6137735F;
			this.RankNameTextBox.Width = 2.96875F;
			// 
			// Line334
			// 
			this.Line334.Height = 1.553999F;
			this.Line334.Left = 1.094195F;
			this.Line334.LineWeight = 1F;
			this.Line334.Name = "Line334";
			this.Line334.Top = 0.001023484F;
			this.Line334.Width = 0F;
			this.Line334.X1 = 1.094195F;
			this.Line334.X2 = 1.094195F;
			this.Line334.Y1 = 0.001023484F;
			this.Line334.Y2 = 1.555023F;
			// 
			// Line336
			// 
			this.Line336.Height = 0.1609998F;
			this.Line336.Left = 2.572918F;
			this.Line336.LineWeight = 1F;
			this.Line336.Name = "Line336";
			this.Line336.Top = 4.196023F;
			this.Line336.Width = 0F;
			this.Line336.X1 = 2.572918F;
			this.Line336.X2 = 2.572918F;
			this.Line336.Y1 = 4.196023F;
			this.Line336.Y2 = 4.357023F;
			// 
			// Line238
			// 
			this.Line238.Height = 0F;
			this.Line238.Left = 9.489059E-05F;
			this.Line238.LineWeight = 1F;
			this.Line238.Name = "Line238";
			this.Line238.Top = 1.384023F;
			this.Line238.Width = 5.187903F;
			this.Line238.X1 = 9.489059E-05F;
			this.Line238.X2 = 5.187998F;
			this.Line238.Y1 = 1.384023F;
			this.Line238.Y2 = 1.384023F;
			// 
			// Line235
			// 
			this.Line235.Height = 0F;
			this.Line235.Left = 9.489059E-05F;
			this.Line235.LineWeight = 1F;
			this.Line235.Name = "Line235";
			this.Line235.Top = 0.7720235F;
			this.Line235.Width = 5.187903F;
			this.Line235.X1 = 9.489059E-05F;
			this.Line235.X2 = 5.187998F;
			this.Line235.Y1 = 0.7720235F;
			this.Line235.Y2 = 0.7720235F;
			// 
			// ExpenStayPerodYTextBox
			// 
			this.ExpenStayPerodYTextBox.CanGrow = false;
			this.ExpenStayPerodYTextBox.DataField = "EXPEN_ATAC_STAY_PEROD_Y";
			this.ExpenStayPerodYTextBox.Height = 0.15F;
			this.ExpenStayPerodYTextBox.Left = 4.555998F;
			this.ExpenStayPerodYTextBox.Name = "ExpenStayPerodYTextBox";
			this.ExpenStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ExpenStayPerodYTextBox.Text = "z9";
			this.ExpenStayPerodYTextBox.Top = 0.3125235F;
			this.ExpenStayPerodYTextBox.Width = 0.125F;
			// 
			// Label176
			// 
			this.Label176.Height = 0.15F;
			this.Label176.HyperLink = null;
			this.Label176.Left = 4.680998F;
			this.Label176.Name = "Label176";
			this.Label176.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label176.Text = "年";
			this.Label176.Top = 0.3130235F;
			this.Label176.Width = 0.125F;
			// 
			// ExpenStayPerodMTextBox
			// 
			this.ExpenStayPerodMTextBox.CanGrow = false;
			this.ExpenStayPerodMTextBox.DataField = "EXPEN_ATAC_STAY_PEROD_M";
			this.ExpenStayPerodMTextBox.Height = 0.15F;
			this.ExpenStayPerodMTextBox.Left = 4.805998F;
			this.ExpenStayPerodMTextBox.Name = "ExpenStayPerodMTextBox";
			this.ExpenStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ExpenStayPerodMTextBox.Text = "z9";
			this.ExpenStayPerodMTextBox.Top = 0.3130235F;
			this.ExpenStayPerodMTextBox.Width = 0.125F;
			// 
			// Label177
			// 
			this.Label177.Height = 0.15F;
			this.Label177.HyperLink = null;
			this.Label177.Left = 4.930998F;
			this.Label177.Name = "Label177";
			this.Label177.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label177.Text = "ヶ月";
			this.Label177.Top = 0.3130235F;
			this.Label177.Width = 0.25F;
			// 
			// Label180
			// 
			this.Label180.Height = 0.15F;
			this.Label180.HyperLink = null;
			this.Label180.Left = 4.930998F;
			this.Label180.Name = "Label180";
			this.Label180.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label180.Text = "ヶ月";
			this.Label180.Top = 0.4687735F;
			this.Label180.Width = 0.25F;
			// 
			// ServStayPerodMTextBox
			// 
			this.ServStayPerodMTextBox.CanGrow = false;
			this.ServStayPerodMTextBox.DataField = "SERV_PL_STAY_PEROD_M";
			this.ServStayPerodMTextBox.Height = 0.15F;
			this.ServStayPerodMTextBox.Left = 4.816418F;
			this.ServStayPerodMTextBox.Name = "ServStayPerodMTextBox";
			this.ServStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ServStayPerodMTextBox.Text = "z9";
			this.ServStayPerodMTextBox.Top = 0.4687736F;
			this.ServStayPerodMTextBox.Width = 0.125F;
			// 
			// Label181
			// 
			this.Label181.Height = 0.15F;
			this.Label181.HyperLink = null;
			this.Label181.Left = 4.691418F;
			this.Label181.Name = "Label181";
			this.Label181.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label181.Text = "年";
			this.Label181.Top = 0.4687736F;
			this.Label181.Width = 0.125F;
			// 
			// ServStayPerodYTextBox
			// 
			this.ServStayPerodYTextBox.CanGrow = false;
			this.ServStayPerodYTextBox.DataField = "SERV_PL_STAY_PEROD_Y";
			this.ServStayPerodYTextBox.Height = 0.15F;
			this.ServStayPerodYTextBox.Left = 4.566418F;
			this.ServStayPerodYTextBox.Name = "ServStayPerodYTextBox";
			this.ServStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ServStayPerodYTextBox.Text = "z9";
			this.ServStayPerodYTextBox.Top = 0.4687736F;
			this.ServStayPerodYTextBox.Width = 0.125F;
			// 
			// Label182
			// 
			this.Label182.Height = 0.15F;
			this.Label182.HyperLink = null;
			this.Label182.Left = 4.930998F;
			this.Label182.Name = "Label182";
			this.Label182.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label182.Text = "ヶ月";
			this.Label182.Top = 0.6137735F;
			this.Label182.Width = 0.25F;
			// 
			// RankStayPerodMTextBox
			// 
			this.RankStayPerodMTextBox.CanGrow = false;
			this.RankStayPerodMTextBox.DataField = "RANK_STAY_PEROD_M";
			this.RankStayPerodMTextBox.Height = 0.15F;
			this.RankStayPerodMTextBox.Left = 4.816418F;
			this.RankStayPerodMTextBox.Name = "RankStayPerodMTextBox";
			this.RankStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.RankStayPerodMTextBox.Text = "z9";
			this.RankStayPerodMTextBox.Top = 0.6137736F;
			this.RankStayPerodMTextBox.Width = 0.125F;
			// 
			// Label183
			// 
			this.Label183.Height = 0.15F;
			this.Label183.HyperLink = null;
			this.Label183.Left = 4.691418F;
			this.Label183.Name = "Label183";
			this.Label183.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label183.Text = "年";
			this.Label183.Top = 0.6137736F;
			this.Label183.Width = 0.125F;
			// 
			// RankStayPerodYTextBox
			// 
			this.RankStayPerodYTextBox.CanGrow = false;
			this.RankStayPerodYTextBox.DataField = "RANK_STAY_PEROD_Y";
			this.RankStayPerodYTextBox.Height = 0.15F;
			this.RankStayPerodYTextBox.Left = 4.566418F;
			this.RankStayPerodYTextBox.Name = "RankStayPerodYTextBox";
			this.RankStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.RankStayPerodYTextBox.Text = "z9";
			this.RankStayPerodYTextBox.Top = 0.6137736F;
			this.RankStayPerodYTextBox.Width = 0.125F;
			// 
			// PrmtDateTextBox
			// 
			this.PrmtDateTextBox.CanGrow = false;
			this.PrmtDateTextBox.DataField = "PRMT_DATE";
			this.PrmtDateTextBox.Height = 0.15F;
			this.PrmtDateTextBox.Left = 4.055998F;
			this.PrmtDateTextBox.Name = "PrmtDateTextBox";
			this.PrmtDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PrmtDateTextBox.Text = "zzz6/z6/z6";
			this.PrmtDateTextBox.Top = 1.074023F;
			this.PrmtDateTextBox.Width = 0.51F;
			// 
			// GradeStayPerodYTextBox
			// 
			this.GradeStayPerodYTextBox.CanGrow = false;
			this.GradeStayPerodYTextBox.DataField = "GRADE_STAY_PEROD_Y";
			this.GradeStayPerodYTextBox.Height = 0.15F;
			this.GradeStayPerodYTextBox.Left = 4.566418F;
			this.GradeStayPerodYTextBox.Name = "GradeStayPerodYTextBox";
			this.GradeStayPerodYTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.GradeStayPerodYTextBox.Text = "z9";
			this.GradeStayPerodYTextBox.Top = 1.073774F;
			this.GradeStayPerodYTextBox.Width = 0.125F;
			// 
			// Label184
			// 
			this.Label184.Height = 0.15F;
			this.Label184.HyperLink = null;
			this.Label184.Left = 4.691418F;
			this.Label184.Name = "Label184";
			this.Label184.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label184.Text = "年";
			this.Label184.Top = 1.073774F;
			this.Label184.Width = 0.125F;
			// 
			// GradeStayPerodMTextBox
			// 
			this.GradeStayPerodMTextBox.CanGrow = false;
			this.GradeStayPerodMTextBox.DataField = "GRADE_STAY_PEROD_M";
			this.GradeStayPerodMTextBox.Height = 0.15F;
			this.GradeStayPerodMTextBox.Left = 4.816418F;
			this.GradeStayPerodMTextBox.Name = "GradeStayPerodMTextBox";
			this.GradeStayPerodMTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.GradeStayPerodMTextBox.Text = "z9";
			this.GradeStayPerodMTextBox.Top = 1.073774F;
			this.GradeStayPerodMTextBox.Width = 0.125F;
			// 
			// Label185
			// 
			this.Label185.Height = 0.15F;
			this.Label185.HyperLink = null;
			this.Label185.Left = 4.930998F;
			this.Label185.Name = "Label185";
			this.Label185.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label185.Text = "ヶ月";
			this.Label185.Top = 1.073774F;
			this.Label185.Width = 0.25F;
			// 
			// Line273
			// 
			this.Line273.Height = 0F;
			this.Line273.Left = 9.489059E-05F;
			this.Line273.LineWeight = 1F;
			this.Line273.Name = "Line273";
			this.Line273.Top = 1.228024F;
			this.Line273.Width = 5.187903F;
			this.Line273.X1 = 9.489059E-05F;
			this.Line273.X2 = 5.187998F;
			this.Line273.Y1 = 1.228024F;
			this.Line273.Y2 = 1.228024F;
			// 
			// Label186
			// 
			this.Label186.Height = 0.15F;
			this.Label186.HyperLink = null;
			this.Label186.Left = 4.691418F;
			this.Label186.Name = "Label186";
			this.Label186.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label186.Text = "年";
			this.Label186.Top = 1.403773F;
			this.Label186.Width = 0.125F;
			// 
			// JobStayPerodM
			// 
			this.JobStayPerodM.CanGrow = false;
			this.JobStayPerodM.DataField = "JOB_STAY_PEROD_M";
			this.JobStayPerodM.Height = 0.15F;
			this.JobStayPerodM.Left = 4.816418F;
			this.JobStayPerodM.Name = "JobStayPerodM";
			this.JobStayPerodM.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.JobStayPerodM.Text = "z9";
			this.JobStayPerodM.Top = 1.403773F;
			this.JobStayPerodM.Width = 0.125F;
			// 
			// Label187
			// 
			this.Label187.Height = 0.15F;
			this.Label187.HyperLink = null;
			this.Label187.Left = 4.930998F;
			this.Label187.Name = "Label187";
			this.Label187.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label187.Text = "ヶ月";
			this.Label187.Top = 1.403773F;
			this.Label187.Width = 0.25F;
			// 
			// Line237
			// 
			this.Line237.Height = 0F;
			this.Line237.Left = 9.489059E-05F;
			this.Line237.LineWeight = 1F;
			this.Line237.Name = "Line237";
			this.Line237.Top = 1.555023F;
			this.Line237.Width = 5.187903F;
			this.Line237.X1 = 9.489059E-05F;
			this.Line237.X2 = 5.187998F;
			this.Line237.Y1 = 1.555023F;
			this.Line237.Y2 = 1.555023F;
			// 
			// Line345
			// 
			this.Line345.Height = 0.7700011F;
			this.Line345.Left = 1.583778F;
			this.Line345.LineWeight = 1F;
			this.Line345.Name = "Line345";
			this.Line345.Top = 1.721023F;
			this.Line345.Width = 0F;
			this.Line345.X1 = 1.583778F;
			this.Line345.X2 = 1.583778F;
			this.Line345.Y1 = 1.721023F;
			this.Line345.Y2 = 2.491024F;
			// 
			// Line275
			// 
			this.Line275.Height = 3.417F;
			this.Line275.Left = 4.055998F;
			this.Line275.LineWeight = 1F;
			this.Line275.Name = "Line275";
			this.Line275.Top = 2.348423E-05F;
			this.Line275.Width = 0F;
			this.Line275.X1 = 4.055998F;
			this.Line275.X2 = 4.055998F;
			this.Line275.Y1 = 2.348423E-05F;
			this.Line275.Y2 = 3.417024F;
			// 
			// Line234
			// 
			this.Line234.Height = 0F;
			this.Line234.Left = 0F;
			this.Line234.LineWeight = 1F;
			this.Line234.Name = "Line234";
			this.Line234.Top = 0.6170235F;
			this.Line234.Width = 5.187998F;
			this.Line234.X1 = 0F;
			this.Line234.X2 = 5.187998F;
			this.Line234.Y1 = 0.6170235F;
			this.Line234.Y2 = 0.6170235F;
			// 
			// Line337
			// 
			this.Line337.Height = 0F;
			this.Line337.Left = 0F;
			this.Line337.LineWeight = 1F;
			this.Line337.Name = "Line337";
			this.Line337.Top = 0.4620235F;
			this.Line337.Width = 5.187998F;
			this.Line337.X1 = 0F;
			this.Line337.X2 = 5.187998F;
			this.Line337.Y1 = 0.4620235F;
			this.Line337.Y2 = 0.4620235F;
			// 
			// Line232
			// 
			this.Line232.Height = 0F;
			this.Line232.Left = 0F;
			this.Line232.LineWeight = 1F;
			this.Line232.Name = "Line232";
			this.Line232.Top = 0.3120235F;
			this.Line232.Width = 5.187998F;
			this.Line232.X1 = 0F;
			this.Line232.X2 = 5.187998F;
			this.Line232.Y1 = 0.3120235F;
			this.Line232.Y2 = 0.3120235F;
			// 
			// Line225
			// 
			this.Line225.Height = 0F;
			this.Line225.Left = 9.489059E-05F;
			this.Line225.LineWeight = 1F;
			this.Line225.Name = "Line225";
			this.Line225.Top = 1.078023F;
			this.Line225.Width = 5.187903F;
			this.Line225.X1 = 9.489059E-05F;
			this.Line225.X2 = 5.187998F;
			this.Line225.Y1 = 1.078023F;
			this.Line225.Y2 = 1.078023F;
			// 
			// Line223
			// 
			this.Line223.Height = 0F;
			this.Line223.Left = 9.489059E-05F;
			this.Line223.LineWeight = 1F;
			this.Line223.Name = "Line223";
			this.Line223.Top = 0.9270235F;
			this.Line223.Width = 5.187903F;
			this.Line223.X1 = 9.489059E-05F;
			this.Line223.X2 = 5.187998F;
			this.Line223.Y1 = 0.9270235F;
			this.Line223.Y2 = 0.9270235F;
			// 
			// ProjStayPerodY1TextBox
			// 
			this.ProjStayPerodY1TextBox.CanGrow = false;
			this.ProjStayPerodY1TextBox.DataField = "PROJ_STAY_PEROD_Y_1";
			this.ProjStayPerodY1TextBox.Height = 0.15F;
			this.ProjStayPerodY1TextBox.Left = 4.565999F;
			this.ProjStayPerodY1TextBox.Name = "ProjStayPerodY1TextBox";
			this.ProjStayPerodY1TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodY1TextBox.Text = "z9";
			this.ProjStayPerodY1TextBox.Top = 1.716023F;
			this.ProjStayPerodY1TextBox.Width = 0.125F;
			// 
			// Label192
			// 
			this.Label192.Height = 0.15F;
			this.Label192.HyperLink = null;
			this.Label192.Left = 4.690999F;
			this.Label192.Name = "Label192";
			this.Label192.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label192.Text = "年";
			this.Label192.Top = 1.716023F;
			this.Label192.Width = 0.125F;
			// 
			// ProjStayPerodM1TextBox
			// 
			this.ProjStayPerodM1TextBox.CanGrow = false;
			this.ProjStayPerodM1TextBox.DataField = "PROJ_STAY_PEROD_M_1";
			this.ProjStayPerodM1TextBox.Height = 0.15F;
			this.ProjStayPerodM1TextBox.Left = 4.815999F;
			this.ProjStayPerodM1TextBox.Name = "ProjStayPerodM1TextBox";
			this.ProjStayPerodM1TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodM1TextBox.Text = "z9";
			this.ProjStayPerodM1TextBox.Top = 1.716023F;
			this.ProjStayPerodM1TextBox.Width = 0.125F;
			// 
			// Label193
			// 
			this.Label193.Height = 0.15F;
			this.Label193.HyperLink = null;
			this.Label193.Left = 4.930998F;
			this.Label193.Name = "Label193";
			this.Label193.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label193.Text = "ヶ月";
			this.Label193.Top = 1.716023F;
			this.Label193.Width = 0.25F;
			// 
			// ProjStayPerodY2TextBox
			// 
			this.ProjStayPerodY2TextBox.CanGrow = false;
			this.ProjStayPerodY2TextBox.DataField = "PROJ_STAY_PEROD_Y_2";
			this.ProjStayPerodY2TextBox.Height = 0.15F;
			this.ProjStayPerodY2TextBox.Left = 4.565999F;
			this.ProjStayPerodY2TextBox.Name = "ProjStayPerodY2TextBox";
			this.ProjStayPerodY2TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodY2TextBox.Text = "z9";
			this.ProjStayPerodY2TextBox.Top = 1.873024F;
			this.ProjStayPerodY2TextBox.Width = 0.125F;
			// 
			// Label194
			// 
			this.Label194.Height = 0.15F;
			this.Label194.HyperLink = null;
			this.Label194.Left = 4.690999F;
			this.Label194.Name = "Label194";
			this.Label194.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label194.Text = "年";
			this.Label194.Top = 1.873024F;
			this.Label194.Width = 0.125F;
			// 
			// ProjStayPerodM2TextBox
			// 
			this.ProjStayPerodM2TextBox.CanGrow = false;
			this.ProjStayPerodM2TextBox.DataField = "PROJ_STAY_PEROD_M_2";
			this.ProjStayPerodM2TextBox.Height = 0.15F;
			this.ProjStayPerodM2TextBox.Left = 4.815999F;
			this.ProjStayPerodM2TextBox.Name = "ProjStayPerodM2TextBox";
			this.ProjStayPerodM2TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodM2TextBox.Text = "z9";
			this.ProjStayPerodM2TextBox.Top = 1.873024F;
			this.ProjStayPerodM2TextBox.Width = 0.125F;
			// 
			// Label195
			// 
			this.Label195.Height = 0.15F;
			this.Label195.HyperLink = null;
			this.Label195.Left = 4.930998F;
			this.Label195.Name = "Label195";
			this.Label195.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label195.Text = "ヶ月";
			this.Label195.Top = 1.873024F;
			this.Label195.Width = 0.25F;
			// 
			// ProjStayPerodY3TextBox
			// 
			this.ProjStayPerodY3TextBox.CanGrow = false;
			this.ProjStayPerodY3TextBox.DataField = "PROJ_STAY_PEROD_Y_3";
			this.ProjStayPerodY3TextBox.Height = 0.15F;
			this.ProjStayPerodY3TextBox.Left = 4.565999F;
			this.ProjStayPerodY3TextBox.Name = "ProjStayPerodY3TextBox";
			this.ProjStayPerodY3TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodY3TextBox.Text = "z9";
			this.ProjStayPerodY3TextBox.Top = 2.029024F;
			this.ProjStayPerodY3TextBox.Width = 0.125F;
			// 
			// Label196
			// 
			this.Label196.Height = 0.15F;
			this.Label196.HyperLink = null;
			this.Label196.Left = 4.690999F;
			this.Label196.Name = "Label196";
			this.Label196.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label196.Text = "年";
			this.Label196.Top = 2.029024F;
			this.Label196.Width = 0.125F;
			// 
			// ProjStayPerodM3TextBox
			// 
			this.ProjStayPerodM3TextBox.CanGrow = false;
			this.ProjStayPerodM3TextBox.DataField = "PROJ_STAY_PEROD_M_3";
			this.ProjStayPerodM3TextBox.Height = 0.15F;
			this.ProjStayPerodM3TextBox.Left = 4.815999F;
			this.ProjStayPerodM3TextBox.Name = "ProjStayPerodM3TextBox";
			this.ProjStayPerodM3TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodM3TextBox.Text = "z9";
			this.ProjStayPerodM3TextBox.Top = 2.029024F;
			this.ProjStayPerodM3TextBox.Width = 0.125F;
			// 
			// Label197
			// 
			this.Label197.Height = 0.15F;
			this.Label197.HyperLink = null;
			this.Label197.Left = 4.930998F;
			this.Label197.Name = "Label197";
			this.Label197.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label197.Text = "ヶ月";
			this.Label197.Top = 2.029024F;
			this.Label197.Width = 0.25F;
			// 
			// ProjStayPerodY4TextBox
			// 
			this.ProjStayPerodY4TextBox.CanGrow = false;
			this.ProjStayPerodY4TextBox.DataField = "PROJ_STAY_PEROD_Y_4";
			this.ProjStayPerodY4TextBox.Height = 0.15F;
			this.ProjStayPerodY4TextBox.Left = 4.566418F;
			this.ProjStayPerodY4TextBox.Name = "ProjStayPerodY4TextBox";
			this.ProjStayPerodY4TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodY4TextBox.Text = "z9";
			this.ProjStayPerodY4TextBox.Top = 2.174606F;
			this.ProjStayPerodY4TextBox.Width = 0.125F;
			// 
			// Label198
			// 
			this.Label198.Height = 0.15F;
			this.Label198.HyperLink = null;
			this.Label198.Left = 4.691418F;
			this.Label198.Name = "Label198";
			this.Label198.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label198.Text = "年";
			this.Label198.Top = 2.174606F;
			this.Label198.Width = 0.125F;
			// 
			// ProjStayPerodM4TextBox
			// 
			this.ProjStayPerodM4TextBox.CanGrow = false;
			this.ProjStayPerodM4TextBox.DataField = "PROJ_STAY_PEROD_M_4";
			this.ProjStayPerodM4TextBox.Height = 0.15F;
			this.ProjStayPerodM4TextBox.Left = 4.816418F;
			this.ProjStayPerodM4TextBox.Name = "ProjStayPerodM4TextBox";
			this.ProjStayPerodM4TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodM4TextBox.Text = "z9";
			this.ProjStayPerodM4TextBox.Top = 2.174606F;
			this.ProjStayPerodM4TextBox.Width = 0.125F;
			// 
			// Label199
			// 
			this.Label199.Height = 0.15F;
			this.Label199.HyperLink = null;
			this.Label199.Left = 4.930998F;
			this.Label199.Name = "Label199";
			this.Label199.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label199.Text = "ヶ月";
			this.Label199.Top = 2.174606F;
			this.Label199.Width = 0.25F;
			// 
			// ProjStayPerodY5TextBox
			// 
			this.ProjStayPerodY5TextBox.CanGrow = false;
			this.ProjStayPerodY5TextBox.DataField = "PROJ_STAY_PEROD_Y_5";
			this.ProjStayPerodY5TextBox.Height = 0.15F;
			this.ProjStayPerodY5TextBox.Left = 4.566418F;
			this.ProjStayPerodY5TextBox.Name = "ProjStayPerodY5TextBox";
			this.ProjStayPerodY5TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodY5TextBox.Text = "z9";
			this.ProjStayPerodY5TextBox.Top = 2.330856F;
			this.ProjStayPerodY5TextBox.Width = 0.125F;
			// 
			// Label200
			// 
			this.Label200.Height = 0.15F;
			this.Label200.HyperLink = null;
			this.Label200.Left = 4.691418F;
			this.Label200.Name = "Label200";
			this.Label200.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label200.Text = "年";
			this.Label200.Top = 2.330856F;
			this.Label200.Width = 0.125F;
			// 
			// ProjStayPerodM5TextBox
			// 
			this.ProjStayPerodM5TextBox.CanGrow = false;
			this.ProjStayPerodM5TextBox.DataField = "PROJ_STAY_PEROD_M_5";
			this.ProjStayPerodM5TextBox.Height = 0.15F;
			this.ProjStayPerodM5TextBox.Left = 4.816418F;
			this.ProjStayPerodM5TextBox.Name = "ProjStayPerodM5TextBox";
			this.ProjStayPerodM5TextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ProjStayPerodM5TextBox.Text = "z9";
			this.ProjStayPerodM5TextBox.Top = 2.330856F;
			this.ProjStayPerodM5TextBox.Width = 0.125F;
			// 
			// Label201
			// 
			this.Label201.Height = 0.15F;
			this.Label201.HyperLink = null;
			this.Label201.Left = 4.930998F;
			this.Label201.Name = "Label201";
			this.Label201.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label201.Text = "ヶ月";
			this.Label201.Top = 2.330856F;
			this.Label201.Width = 0.25F;
			// 
			// Line341
			// 
			this.Line341.Height = 0F;
			this.Line341.Left = 0.4430003F;
			this.Line341.LineWeight = 1F;
			this.Line341.Name = "Line341";
			this.Line341.Top = 2.023273F;
			this.Line341.Width = 4.744998F;
			this.Line341.X1 = 0.4430003F;
			this.Line341.X2 = 5.187998F;
			this.Line341.Y1 = 2.023273F;
			this.Line341.Y2 = 2.023273F;
			// 
			// Line342
			// 
			this.Line342.Height = 0F;
			this.Line342.Left = 0.4430003F;
			this.Line342.LineWeight = 1F;
			this.Line342.Name = "Line342";
			this.Line342.Top = 2.179523F;
			this.Line342.Width = 4.744998F;
			this.Line342.X1 = 0.4430003F;
			this.Line342.X2 = 5.187998F;
			this.Line342.Y1 = 2.179523F;
			this.Line342.Y2 = 2.179523F;
			// 
			// Line343
			// 
			this.Line343.Height = 0F;
			this.Line343.Left = 0.4430003F;
			this.Line343.LineWeight = 1F;
			this.Line343.Name = "Line343";
			this.Line343.Top = 2.335773F;
			this.Line343.Width = 4.744998F;
			this.Line343.X1 = 0.4430003F;
			this.Line343.X2 = 5.187998F;
			this.Line343.Y1 = 2.335773F;
			this.Line343.Y2 = 2.335773F;
			// 
			// Line339
			// 
			this.Line339.Height = 4.196F;
			this.Line339.Left = 4.562998F;
			this.Line339.LineWeight = 1F;
			this.Line339.Name = "Line339";
			this.Line339.Top = 2.348423E-05F;
			this.Line339.Width = 0F;
			this.Line339.X1 = 4.562998F;
			this.Line339.X2 = 4.562998F;
			this.Line339.Y1 = 2.348423E-05F;
			this.Line339.Y2 = 4.196023F;
			// 
			// Line340
			// 
			this.Line340.Height = 0F;
			this.Line340.Left = 0.4430003F;
			this.Line340.LineWeight = 1F;
			this.Line340.Name = "Line340";
			this.Line340.Top = 1.72119F;
			this.Line340.Width = 4.744998F;
			this.Line340.X1 = 0.4430003F;
			this.Line340.X2 = 5.187998F;
			this.Line340.Y1 = 1.72119F;
			this.Line340.Y2 = 1.72119F;
			// 
			// Line347
			// 
			this.Line347.Height = 0F;
			this.Line347.Left = 0.4430003F;
			this.Line347.LineWeight = 1F;
			this.Line347.Name = "Line347";
			this.Line347.Top = 5.606606F;
			this.Line347.Width = 4.744998F;
			this.Line347.X1 = 0.4430003F;
			this.Line347.X2 = 5.187998F;
			this.Line347.Y1 = 5.606606F;
			this.Line347.Y2 = 5.606606F;
			// 
			// Line348
			// 
			this.Line348.Height = 0F;
			this.Line348.Left = 0.4430003F;
			this.Line348.LineWeight = 1F;
			this.Line348.Name = "Line348";
			this.Line348.Top = 5.762856F;
			this.Line348.Width = 4.744998F;
			this.Line348.X1 = 0.4430003F;
			this.Line348.X2 = 5.187998F;
			this.Line348.Y1 = 5.762856F;
			this.Line348.Y2 = 5.762856F;
			// 
			// Line349
			// 
			this.Line349.Height = 0F;
			this.Line349.Left = 0.4430003F;
			this.Line349.LineWeight = 1F;
			this.Line349.Name = "Line349";
			this.Line349.Top = 5.919106F;
			this.Line349.Width = 4.744998F;
			this.Line349.X1 = 0.4430003F;
			this.Line349.X2 = 5.187998F;
			this.Line349.Y1 = 5.919106F;
			this.Line349.Y2 = 5.919106F;
			// 
			// Line350
			// 
			this.Line350.Height = 0F;
			this.Line350.Left = 0.4430003F;
			this.Line350.LineWeight = 1F;
			this.Line350.Name = "Line350";
			this.Line350.Top = 6.075356F;
			this.Line350.Width = 4.744998F;
			this.Line350.X1 = 0.4430003F;
			this.Line350.X2 = 5.187998F;
			this.Line350.Y1 = 6.075356F;
			this.Line350.Y2 = 6.075356F;
			// 
			// Line351
			// 
			this.Line351.Height = 0F;
			this.Line351.Left = 0.4430003F;
			this.Line351.LineWeight = 1F;
			this.Line351.Name = "Line351";
			this.Line351.Top = 6.231606F;
			this.Line351.Width = 4.744998F;
			this.Line351.X1 = 0.4430003F;
			this.Line351.X2 = 5.187998F;
			this.Line351.Y1 = 6.231606F;
			this.Line351.Y2 = 6.231606F;
			// 
			// Line266
			// 
			this.Line266.Height = 0F;
			this.Line266.Left = 9.489059E-05F;
			this.Line266.LineWeight = 1F;
			this.Line266.Name = "Line266";
			this.Line266.Top = 5.444023F;
			this.Line266.Width = 5.187903F;
			this.Line266.X1 = 9.489059E-05F;
			this.Line266.X2 = 5.187998F;
			this.Line266.Y1 = 5.444023F;
			this.Line266.Y2 = 5.444023F;
			// 
			// Line198
			// 
			this.Line198.Height = 6.381F;
			this.Line198.Left = 0.4431672F;
			this.Line198.LineWeight = 1F;
			this.Line198.Name = "Line198";
			this.Line198.Top = 0.001023484F;
			this.Line198.Width = 0F;
			this.Line198.X1 = 0.4431672F;
			this.Line198.X2 = 0.4431672F;
			this.Line198.Y1 = 0.001023484F;
			this.Line198.Y2 = 6.382023F;
			// 
			// Line352
			// 
			this.Line352.Height = 0F;
			this.Line352.Left = 0.4430003F;
			this.Line352.LineWeight = 1F;
			this.Line352.Name = "Line352";
			this.Line352.Top = 5.294106F;
			this.Line352.Width = 4.744998F;
			this.Line352.X1 = 0.4430003F;
			this.Line352.X2 = 5.187998F;
			this.Line352.Y1 = 5.294106F;
			this.Line352.Y2 = 5.294106F;
			// 
			// Line264
			// 
			this.Line264.Height = 0F;
			this.Line264.Left = 9.489059E-05F;
			this.Line264.LineWeight = 1F;
			this.Line264.Name = "Line264";
			this.Line264.Top = 5.131023F;
			this.Line264.Width = 5.187903F;
			this.Line264.X1 = 9.489059E-05F;
			this.Line264.X2 = 5.187998F;
			this.Line264.Y1 = 5.131023F;
			this.Line264.Y2 = 5.131023F;
			// 
			// Line353
			// 
			this.Line353.Height = 0F;
			this.Line353.Left = 0.4430003F;
			this.Line353.LineWeight = 1F;
			this.Line353.Name = "Line353";
			this.Line353.Top = 2.648273F;
			this.Line353.Width = 4.744998F;
			this.Line353.X1 = 0.4430003F;
			this.Line353.X2 = 5.187998F;
			this.Line353.Y1 = 2.648273F;
			this.Line353.Y2 = 2.648273F;
			// 
			// Line354
			// 
			this.Line354.Height = 0F;
			this.Line354.Left = 0.4430003F;
			this.Line354.LineWeight = 1F;
			this.Line354.Name = "Line354";
			this.Line354.Top = 2.794106F;
			this.Line354.Width = 4.744998F;
			this.Line354.X1 = 0.4430003F;
			this.Line354.X2 = 5.187998F;
			this.Line354.Y1 = 2.794106F;
			this.Line354.Y2 = 2.794106F;
			// 
			// Line355
			// 
			this.Line355.Height = 0F;
			this.Line355.Left = 0.4430003F;
			this.Line355.LineWeight = 1F;
			this.Line355.Name = "Line355";
			this.Line355.Top = 2.950356F;
			this.Line355.Width = 4.744998F;
			this.Line355.X1 = 0.4430003F;
			this.Line355.X2 = 5.187998F;
			this.Line355.Y1 = 2.950356F;
			this.Line355.Y2 = 2.950356F;
			// 
			// Line356
			// 
			this.Line356.Height = 0F;
			this.Line356.Left = 0.4430003F;
			this.Line356.LineWeight = 1F;
			this.Line356.Name = "Line356";
			this.Line356.Top = 3.106606F;
			this.Line356.Width = 4.744998F;
			this.Line356.X1 = 0.4430003F;
			this.Line356.X2 = 5.187998F;
			this.Line356.Y1 = 3.106606F;
			this.Line356.Y2 = 3.106606F;
			// 
			// Line357
			// 
			this.Line357.Height = 0F;
			this.Line357.Left = 0.4430003F;
			this.Line357.LineWeight = 1F;
			this.Line357.Name = "Line357";
			this.Line357.Top = 3.262856F;
			this.Line357.Width = 4.744998F;
			this.Line357.X1 = 0.4430003F;
			this.Line357.X2 = 5.187998F;
			this.Line357.Y1 = 3.262856F;
			this.Line357.Y2 = 3.262856F;
			// 
			// Line276
			// 
			this.Line276.Height = 3.887F;
			this.Line276.Left = 1.443166F;
			this.Line276.LineWeight = 1F;
			this.Line276.Name = "Line276";
			this.Line276.Top = 2.495023F;
			this.Line276.Width = 0.0004999638F;
			this.Line276.X1 = 1.443166F;
			this.Line276.X2 = 1.443666F;
			this.Line276.Y1 = 2.495023F;
			this.Line276.Y2 = 6.382023F;
			// 
			// Line214
			// 
			this.Line214.Height = 6.381F;
			this.Line214.Left = 5.187939F;
			this.Line214.LineWeight = 1F;
			this.Line214.Name = "Line214";
			this.Line214.Top = 0.001023484F;
			this.Line214.Width = 0F;
			this.Line214.X1 = 5.187939F;
			this.Line214.X2 = 5.187939F;
			this.Line214.Y1 = 0.001023484F;
			this.Line214.Y2 = 6.382023F;
			// 
			// Line257
			// 
			this.Line257.Height = 0F;
			this.Line257.Left = 9.489059E-05F;
			this.Line257.LineWeight = 1F;
			this.Line257.Name = "Line257";
			this.Line257.Top = 4.196023F;
			this.Line257.Width = 5.187903F;
			this.Line257.X1 = 9.489059E-05F;
			this.Line257.X2 = 5.187998F;
			this.Line257.Y1 = 4.196023F;
			this.Line257.Y2 = 4.196023F;
			// 
			// Line358
			// 
			this.Line358.Height = 0F;
			this.Line358.Left = 0.4430003F;
			this.Line358.LineWeight = 1F;
			this.Line358.Name = "Line358";
			this.Line358.Top = 3.575356F;
			this.Line358.Width = 4.744998F;
			this.Line358.X1 = 0.4430003F;
			this.Line358.X2 = 5.187998F;
			this.Line358.Y1 = 3.575356F;
			this.Line358.Y2 = 3.575356F;
			// 
			// Line359
			// 
			this.Line359.Height = 0F;
			this.Line359.Left = 0.4430003F;
			this.Line359.LineWeight = 1F;
			this.Line359.Name = "Line359";
			this.Line359.Top = 3.731606F;
			this.Line359.Width = 4.744998F;
			this.Line359.X1 = 0.4430003F;
			this.Line359.X2 = 5.187998F;
			this.Line359.Y1 = 3.731606F;
			this.Line359.Y2 = 3.731606F;
			// 
			// Line360
			// 
			this.Line360.Height = 0F;
			this.Line360.Left = 0.4430003F;
			this.Line360.LineWeight = 1F;
			this.Line360.Name = "Line360";
			this.Line360.Top = 3.887856F;
			this.Line360.Width = 4.744998F;
			this.Line360.X1 = 0.4430003F;
			this.Line360.X2 = 5.187998F;
			this.Line360.Y1 = 3.887856F;
			this.Line360.Y2 = 3.887856F;
			// 
			// Line361
			// 
			this.Line361.Height = 0F;
			this.Line361.Left = 0.4430003F;
			this.Line361.LineWeight = 1F;
			this.Line361.Name = "Line361";
			this.Line361.Top = 4.044106F;
			this.Line361.Width = 4.744998F;
			this.Line361.X1 = 0.4430003F;
			this.Line361.X2 = 5.187998F;
			this.Line361.Y1 = 4.044106F;
			this.Line361.Y2 = 4.044106F;
			// 
			// Line252
			// 
			this.Line252.Height = 0F;
			this.Line252.Left = 9.489059E-05F;
			this.Line252.LineWeight = 1F;
			this.Line252.Name = "Line252";
			this.Line252.Top = 3.417024F;
			this.Line252.Width = 5.187903F;
			this.Line252.X1 = 9.489059E-05F;
			this.Line252.X2 = 5.187998F;
			this.Line252.Y1 = 3.417024F;
			this.Line252.Y2 = 3.417024F;
			// 
			// Line291
			// 
			this.Line291.Height = 0.9399989F;
			this.Line291.Left = 0.9483624F;
			this.Line291.LineWeight = 1F;
			this.Line291.Name = "Line291";
			this.Line291.Top = 3.417024F;
			this.Line291.Width = 0F;
			this.Line291.X1 = 0.9483624F;
			this.Line291.X2 = 0.9483624F;
			this.Line291.Y1 = 3.417024F;
			this.Line291.Y2 = 4.357023F;
			// 
			// Line362
			// 
			this.Line362.Height = 0F;
			this.Line362.Left = 0.4430003F;
			this.Line362.LineWeight = 1F;
			this.Line362.Name = "Line362";
			this.Line362.Top = 4.356606F;
			this.Line362.Width = 4.744998F;
			this.Line362.X1 = 0.4430003F;
			this.Line362.X2 = 5.187998F;
			this.Line362.Y1 = 4.356606F;
			this.Line362.Y2 = 4.356606F;
			// 
			// Line363
			// 
			this.Line363.Height = 0F;
			this.Line363.Left = 0.4430003F;
			this.Line363.LineWeight = 1F;
			this.Line363.Name = "Line363";
			this.Line363.Top = 4.512856F;
			this.Line363.Width = 4.744998F;
			this.Line363.X1 = 0.4430003F;
			this.Line363.X2 = 5.187998F;
			this.Line363.Y1 = 4.512856F;
			this.Line363.Y2 = 4.512856F;
			// 
			// Line364
			// 
			this.Line364.Height = 0F;
			this.Line364.Left = 0.4430003F;
			this.Line364.LineWeight = 1F;
			this.Line364.Name = "Line364";
			this.Line364.Top = 4.669106F;
			this.Line364.Width = 4.744998F;
			this.Line364.X1 = 0.4430003F;
			this.Line364.X2 = 5.187998F;
			this.Line364.Y1 = 4.669106F;
			this.Line364.Y2 = 4.669106F;
			// 
			// Line365
			// 
			this.Line365.Height = 0F;
			this.Line365.Left = 0.4430003F;
			this.Line365.LineWeight = 1F;
			this.Line365.Name = "Line365";
			this.Line365.Top = 4.825356F;
			this.Line365.Width = 4.744998F;
			this.Line365.X1 = 0.4430003F;
			this.Line365.X2 = 5.187998F;
			this.Line365.Y1 = 4.825356F;
			this.Line365.Y2 = 4.825356F;
			// 
			// Line366
			// 
			this.Line366.Height = 0F;
			this.Line366.Left = 0.4430003F;
			this.Line366.LineWeight = 1F;
			this.Line366.Name = "Line366";
			this.Line366.Top = 4.981606F;
			this.Line366.Width = 4.744998F;
			this.Line366.X1 = 0.4430003F;
			this.Line366.X2 = 5.187998F;
			this.Line366.Y1 = 4.981606F;
			this.Line366.Y2 = 4.981606F;
			// 
			// Line314
			// 
			this.Line314.Height = 0.7740002F;
			this.Line314.Left = 3.599415F;
			this.Line314.LineWeight = 1F;
			this.Line314.Name = "Line314";
			this.Line314.Top = 4.357023F;
			this.Line314.Width = 0.0004999638F;
			this.Line314.X1 = 3.599415F;
			this.Line314.X2 = 3.599915F;
			this.Line314.Y1 = 4.357023F;
			this.Line314.Y2 = 5.131023F;
			// 
			// Line344
			// 
			this.Line344.Height = 0F;
			this.Line344.Left = 0.4430003F;
			this.Line344.LineWeight = 1F;
			this.Line344.Name = "Line344";
			this.Line344.Top = 1.87744F;
			this.Line344.Width = 4.744998F;
			this.Line344.X1 = 0.4430003F;
			this.Line344.X2 = 5.187998F;
			this.Line344.Y1 = 1.87744F;
			this.Line344.Y2 = 1.87744F;
			// 
			// HR_PA_03_R99
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.5F;
			this.PageSettings.Margins.Left = 0.5F;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.268056F;
			this.PrintWidth = 10.65625F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PA_03_R01_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.HousingRentTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label172)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TransferName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label173)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label119)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label87)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TransferDate1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingAlowNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StrMovingInYmdTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label118)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label206)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label205)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OwnHouseTypeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label85)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label89)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYm4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntraYm1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label86)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label88)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label168)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label169)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label170)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label171)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label163)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label204)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveReasonTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label203)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label202)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostAtacName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjFromDate1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjShortName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjCodeSbno1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label191)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label189)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label190)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobStayPerodY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OwnTypeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnFrom2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label188)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenAtacCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenAtacChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostFromDate2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName6extBox73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemShortName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacStayPerodTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OptItemName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label82)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnTo3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnMeansName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrnspAlowAmt2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remarks2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeaveStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtacChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostStayPerpdYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label160)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label161)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label162)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodY4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label164)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label165)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label166)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label167)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPostStayPerodM5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EepenAtacNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServPlNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualfJobNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutyNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PostNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label176)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpenStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label177)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label181)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label182)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label183)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RankStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PrmtDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeStayPerodYTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label184)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GradeStayPerodMTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label185)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label186)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobStayPerodM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label187)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label192)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label193)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label194)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label195)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label196)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label197)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label198)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label199)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodY5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label200)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjStayPerodM5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label201)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
