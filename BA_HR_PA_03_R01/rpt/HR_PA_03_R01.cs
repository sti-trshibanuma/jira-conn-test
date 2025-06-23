// Product     : Allegro
// Unit        : HR
// Module      : PA
// Function    : 03
// File Name   : HR_PA_03_R01.cs
// 機能名      : HR_PA_03_R01 個人基本情報
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 管理番号 B13875 2005/02/04 画像ファイル保存場所を自社マスタ(HR)がら取得する方法からWeb.configから取得する方法に変更する
// 1.4.0 2005/10/31
// 管理番号 B17075 2006/01/21 住所情報履歴管理対応
// 管理番号 B17653 2006/04/20 社保事業所登録(項目見出し修正)
// 管理番号 B19309 2006/10/16 個人基本情報(顔写真の印刷不具合)
// 1.4.2 2006/11/30
// 管理番号 B19982 2007/01/22 個人基本情報(サーバ帳票の写真表示不具合)
// 管理番号 K20207 2007/02/05 プロジェクトコード桁数拡張および複数プロジェクト管理
// 1.5.1 2007/06/30
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 B21943 2009/08/25 標準報酬月額の印字位置を調整し、枠内に収まるよう修正
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
	public class HR_PA_03_R01 : GrapeCity.ActiveReports.SectionReport
	{

		public HR_PA_03_R01()
		{


			InitializeComponent();
		}

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

		public string BaseDate
		{
			get { return baseDate; }
			set { baseDate = value; }
		}

		public CommonData commonData
		{
			get { return cd; }
			set { cd = value; }
		}

		#endregion


		#region Protected Fields
		protected string reportID;
		protected string companyName;
		protected string baseDate;
		protected CommonData cd;
// 管理番号 K24565 From
		private SubReport subReport1;
// 管理番号 K24565 To
		protected string empCode;
// 管理番号 B17075 From
//		protected System.Web.UI.WebControls.Image FacePhotoImg;
// 管理番号 B17075 To
// 管理番号 B19982 From
//		private string folderAliasPath = string.Empty;
//		private string folderRealPath = string.Empty;
//		private string facePhotoUseFlg = string.Empty;
// 管理番号 B19982 To

		#endregion

		private void HR_PA_03_R01_ReportStart(object sender, System.EventArgs eArgs)
		{
// 管理番号 B19982 From
//			BL_HR_MS_MycompHR_L mycompHR_L = BL_HR_MS_MycompHR_L.GetInstance();	//自社マスタL
//			BL_HR_MS_MycompHR mycompHR = mycompHR_L.Select(cd,cd.CompCode);	//自社マスタ
//
//// 管理番号 B13875 From
////			folderAliasPath = mycompHR.MycompHR.FacePhotoAliasFolder ;  
////			folderRealPath = mycompHR.MycompHR.FacePhotoRealFolder ;
//			folderAliasPath = System.Configuration.ConfigurationManager.AppSettings[cd.CompCode + "_ImportFacePhotoFileUrl"];
//			folderRealPath = System.Configuration.ConfigurationManager.AppSettings[cd.CompCode + "_ImportFacePhotoFileSavePath"] + @"\";
//// 管理番号 B13875 To
//			folderRealPath = MyComp.GetImportFacePhotoFileSavePath(cd.CompCode) + @"\";
//
//			facePhotoUseFlg = mycompHR.MycompHR.FacePhotoUseFlg;  
// 管理番号 B19982 To


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
			BaseDateText.Text = baseDate;
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

			empCode = EmpCodeTextBox.Text;

			SetImgPhotoURL(empCode);
//			Picture1.Image= System.Drawing.Image.FromFile("folderAliasPath + f.Name");
//			Picture1.Image= System.Drawing.Image.FromFile("C:/img/0921.jpg"); 
			BL_HR_Common com = BL_HR_Common.GetInstance();

			string birthYmdDateJP = com.GetDateFormatJP(this.BirthYmdJPText.Text);
			string entranceDateJP = com.GetDateFormatJP(this.InDateJPTextBox.Text);

			// 生年月日和暦表示
			this.BirthYmdJPText.Text = birthYmdDateJP == string.Empty ? " " : birthYmdDateJP;

			// 入社日和暦表示
			this.InDateJPTextBox.Text = entranceDateJP == string.Empty ? " " : entranceDateJP;

// 管理番号 K24565 From
			System.Data.DataRow[] dtR01 = ((System.Data.DataView)DataSource).Table.Select("[EMP_CODE] = '" + empCode + "'", "[EMP_CODE]");

			rpt.HR_PA_03_R99 rptR99 = new HR_PA_03_R99();
			//データソースを渡す
			rptR99.DataSource = dtR01;
			this.subReport1.Report = rptR99;
			this.subReport1.Visible = true;
// 管理番号 K24565 To
		}
		///---------------------------------------------------------------------------------------------------------
		/// <summary>
		/// 画像設定関数
		/// </summary>
		/// <param name="empCode">社員コード</param>
		///---------------------------------------------------------------------------------------------------------
		private void SetImgPhotoURL(string empCode)
		{
// 管理番号 B19982 From
////			BL_HR_MS_MycompHR_L mycompHR_L = BL_HR_MS_MycompHR_L.GetInstance();	//自社マスタL
////			BL_HR_MS_MycompHR mycompHR = mycompHR_L.Select(cd,cd.CompCode);	//自社マスタ
//
//			
////			string folderAliasPath = mycompHR.MycompHR.FacePhotoAliasFolder ;  
////			string folderRealPath = mycompHR.MycompHR.FacePhotoRealFolder ;  
//
//			//写真仕様フラグ
////			FacePhotoImg.ImageUrl ="img/default.JPG";
//
//// 管理番号 B19309 From
//			//写真情報クリア
//			Picture1.Image = null;
//// 管理番号 B19309 To
//
//			if((facePhotoUseFlg != null) && (facePhotoUseFlg =="1"))
//
////	if(mycompHR.MycompHR.FacePhotoUseFlg =="1")
//			{ 
//				if(System.IO.Directory.Exists(folderRealPath))
//				{  
//					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@folderRealPath);
//					System.IO.FileInfo[] imageFils = dir.GetFiles(empCode + ".*");
//					if ((imageFils != null) && (imageFils.Length > 0))
//					{
//						foreach (System.IO.FileInfo f in imageFils)
//						{
//						
////							FacePhotoImg.ImageUrl =folderRealPath + f.Name; 
//							Picture1.Image= System.Drawing.Image.FromFile(folderRealPath + f.Name);
//							break;
//						}
//					}
//				}
//			}
			Picture1.Image = WEB_HR_Common.GetFacePhotoImage(commonData, empCode, false);
// 管理番号 B19982 To
		}


		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGE = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label3 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PAGESUM = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label4 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ReportIDText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label174 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BaseDateText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label144 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label143 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label106 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReason5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReason1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReason2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReason3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label53 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ClsNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label54 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EntranceDate1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label33 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label35 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label34 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PositTypeNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GrnAdrs3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Zip2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GrnAdrs1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label37 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label36 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label99 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line117 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line120 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmpCodeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox NameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthYmdText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line196 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line218 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line219 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line220 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line221 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label8 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line222 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label9 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label10 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox NameKanaTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line226 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label11 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label12 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label13 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line229 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label14 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label15 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label16 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line230 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label17 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexTypeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label18 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label19 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line233 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label32 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line243 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line245 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line246 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line247 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line248 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line250 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line251 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line253 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line254 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line255 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line256 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line258 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line259 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line260 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line261 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line262 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line263 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label38 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line265 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line267 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line268 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line269 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line270 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line271 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line277 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PreJobRetirDate1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label49 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label50 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line278 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line281 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobName1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label55 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ZipTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label56 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PhoneTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label57 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ChgDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Adrs1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label58 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Zip_1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label59 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Phone_1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Adrs1_1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Adrs2_153 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label62 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label63 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label64 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label65 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PreJobRetirDate5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PreJobRetirDate4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PreJobRetirDate3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PreJobRetirDate2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobName4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox JobName3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox67 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReason4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AgeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox StrServTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label74 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label75 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line289 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label90 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label91 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Phone1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label92 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GrnNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label93 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RELAT1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label94 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label95 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Phone2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label96 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GrnName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label97 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Relate2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label98 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label100 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label101 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label102 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label103 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label104 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label105 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line297 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line298 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line301 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line303 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label108 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line304 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PositReasonTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label109 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line305 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line306 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox IntroTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label110 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label111 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label112 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label113 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label114 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label115 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label117 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduYmTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line307 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line308 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line309 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SchoolNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SubjNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line310 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line311 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FacultyNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line312 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox GraduTypeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DayNightTypeTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line316 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FmlyAlowType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line317 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line318 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label120 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmployInsOfcNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line319 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label121 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SocInsOfcNameTextBox178 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line320 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmployInsMarkNoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label124 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label125 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndNoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensNoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsNoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label126 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox WorkAccInsOfcNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line321 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line322 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay1TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label127 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label128 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line323 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndStandCompsAmtTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensStandCompsAmtTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsStandMonAmtTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label130 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label131 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label132 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndRevYmTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensRevYmTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsRevYmTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label133 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label135 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label136 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label137 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label139 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label140 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label141 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label142 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line324 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensBasePensNoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label145 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensBasePensNoSbnoTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CareInsTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TBirthDay7extBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TBirthDay4extBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType7TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType6TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType5TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType4TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType3TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType8TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label146 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Zip_2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label147 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Phone_2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label148 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Name2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label149 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Relation2TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObtainDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndObtainDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensObtainDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensFndLossDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox PensLossDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsLossDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox RetireReasonTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox FamRal9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LastName9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox SexType9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthDay9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LiveTgtType9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox Employ9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox DpndType9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HeltInsObjType9TextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmployInsObtainDateTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox EmployInsLossDateTextBox309 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line335 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line338 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Picture Picture1 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label175 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AdrsChgDate2 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line238 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line235 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line273 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox BirthYmdJPText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox InDateJPTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox AssocItemNameTextBox = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line237 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line225 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line223 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line249 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line272 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line266 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line264 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line257 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line252 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line241 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line299 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line300 = null;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox CompanyNameText = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PA_03_R01));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.Label144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.FmlyAlowType9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FmlyAlowType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label106 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RetireReason5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireReason1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireReason2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireReason3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label53 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ClsNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label54 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.EntranceDate5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EntranceDate1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label33 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label34 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PositTypeNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GrnAdrs3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Zip2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.GrnAdrs1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox122 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label37 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.LastName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label99 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line117 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line120 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line123 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.EmpCodeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.NameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthYmdText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line196 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line218 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line219 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line220 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line221 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line222 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.NameKanaTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line226 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label11 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label12 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label13 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line229 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label14 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label15 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label16 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line230 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label17 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SexTypeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label18 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label19 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line233 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label32 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line243 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line245 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line246 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line247 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line248 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line250 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line251 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line253 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line254 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line255 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line256 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line258 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line259 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line260 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line261 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line262 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line263 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label38 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line265 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line267 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line268 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line269 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line270 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line271 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line277 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PreJobRetirDate1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label49 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label50 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line278 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line281 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.CompName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobName1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CompName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label55 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ZipTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label56 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PhoneTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label57 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ChgDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Adrs1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label58 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Zip_1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label59 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Phone_1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Adrs1_1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Adrs2_153 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label62 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label63 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label64 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label65 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PreJobRetirDate5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PreJobRetirDate4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PreJobRetirDate3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PreJobRetirDate2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobName4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.JobName3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox67 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireReason4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AgeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.StrServTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label74 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label75 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line289 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label90 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label91 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Phone1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label92 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GrnNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label93 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.RELAT1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label94 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label95 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Phone2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label96 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GrnName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label97 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Relate2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label98 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label100 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label101 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label102 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label103 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label104 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.FamRal1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line297 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.FamRal8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line298 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line301 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line303 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label108 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line304 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PositReasonTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label109 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line305 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line306 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.IntroTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label110 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label111 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label112 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label114 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label115 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label117 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.GraduYmTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line307 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line308 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line309 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SchoolNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubjNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line310 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line311 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.FacultyNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line312 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.GraduTypeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DayNightTypeTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line316 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.FmlyAlowType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line317 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.HeltInsObjType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line318 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label120 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Employ1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmployInsOfcNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line319 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label121 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SocInsOfcNameTextBox178 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label122 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line320 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.EmployInsMarkNoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label124 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label125 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PensFndNoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensNoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsNoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label126 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.WorkAccInsOfcNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line321 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line322 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.LiveTgtType1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay1TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label127 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label128 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line323 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PensFndStandCompsAmtTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensStandCompsAmtTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsStandMonAmtTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label132 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PensFndRevYmTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensRevYmTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsRevYmTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label133 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label135 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label136 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line324 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.PensBasePensNoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PensBasePensNoSbnoTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CareInsTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TBirthDay7extBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TBirthDay4extBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType7TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType6TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType5TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType4TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType3TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType8TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label146 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Zip_2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Phone_2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Name2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label149 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Relation2TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObtainDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensFndObtainDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensObtainDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensFndLossDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PensLossDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsLossDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.RetireReasonTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.FamRal9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LastName9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SexType9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.BirthDay9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LiveTgtType9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Employ9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndType9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HeltInsObjType9TextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmployInsObtainDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EmployInsLossDateTextBox309 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line335 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line338 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Picture1 = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.Label175 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.AdrsChgDate2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line238 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line235 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line273 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.BirthYmdJPText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.InDateJPTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.AssocItemNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line237 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line225 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line223 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line249 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line272 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line266 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line264 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line257 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line252 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line241 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line299 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line300 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.subReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGE = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PAGESUM = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.DateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ReportIDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label174 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.BaseDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.CompanyNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Label144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositTypeNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnAdrs3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnAdrs1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NameKanaTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChgDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip_1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone_1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1_1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs2_153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StrServTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label90)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label91)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label92)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RELAT1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Relate2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositReasonTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IntroTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label110)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label117)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYmTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduTypeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightTypeTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label120)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsOfcNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label121)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SocInsOfcNameTextBox178)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsMarkNoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndNoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensNoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsNoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkAccInsOfcNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay1TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndStandCompsAmtTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensStandCompsAmtTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsStandMonAmtTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndRevYmTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensRevYmTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsRevYmTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensBasePensNoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensBasePensNoSbnoTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CareInsTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TBirthDay7extBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TBirthDay4extBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType7TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType6TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType5TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType4TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType3TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType8TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip_2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone_2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Name2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Relation2TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObtainDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndObtainDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensObtainDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndLossDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PensLossDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsLossDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReasonTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType9TextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsObtainDateTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsLossDateTextBox309)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AdrsChgDate2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdJPText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateJPTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AssocItemNameTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BaseDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Label144,
            this.Label143,
            this.FmlyAlowType9TextBox,
            this.FmlyAlowType8TextBox,
            this.FmlyAlowType7TextBox,
            this.FmlyAlowType6TextBox,
            this.FmlyAlowType5TextBox,
            this.FmlyAlowType4TextBox,
            this.FmlyAlowType3TextBox,
            this.FmlyAlowType2TextBox,
            this.Label106,
            this.RetireReason5TextBox,
            this.RetireReason1TextBox,
            this.RetireReason2TextBox,
            this.RetireReason3TextBox,
            this.LastName3TextBox,
            this.LastName4TextBox,
            this.Label53,
            this.ClsNameTextBox,
            this.Label54,
            this.EntranceDate5TextBox,
            this.EntranceDate4TextBox,
            this.EntranceDate3TextBox,
            this.EntranceDate2TextBox,
            this.EntranceDate1TextBox,
            this.Label33,
            this.Label35,
            this.Label34,
            this.PositTypeNameTextBox,
            this.GrnAdrs3TextBox,
            this.Zip2TextBox,
            this.GrnAdrs1TextBox,
            this.TextBox122,
            this.Label37,
            this.Label36,
            this.LastName1TextBox,
            this.Label99,
            this.Line117,
            this.Line120,
            this.Line123,
            this.EmpCodeTextBox,
            this.NameTextBox,
            this.BirthYmdText,
            this.Line196,
            this.Line218,
            this.Line219,
            this.Line220,
            this.Line221,
            this.Label8,
            this.Line222,
            this.Label9,
            this.Label10,
            this.NameKanaTextBox,
            this.Line226,
            this.Label11,
            this.Label12,
            this.Label13,
            this.Line229,
            this.Label14,
            this.Label15,
            this.Label16,
            this.Line230,
            this.Label17,
            this.SexTypeTextBox,
            this.RetireDateTextBox,
            this.TextBox,
            this.InDateTextBox,
            this.Label18,
            this.Label19,
            this.Line233,
            this.Label32,
            this.Line243,
            this.Line245,
            this.Line246,
            this.Line247,
            this.Line248,
            this.Line250,
            this.Line251,
            this.Line253,
            this.Line254,
            this.Line255,
            this.Line256,
            this.Line258,
            this.Line259,
            this.Line260,
            this.Line261,
            this.Line262,
            this.Line263,
            this.Label38,
            this.Line265,
            this.Line267,
            this.Line268,
            this.Line269,
            this.Line270,
            this.Line271,
            this.Line277,
            this.PreJobRetirDate1TextBox,
            this.Label49,
            this.Label50,
            this.Line278,
            this.Line281,
            this.CompName1TextBox,
            this.JobName1TextBox,
            this.CompName5TextBox,
            this.CompName4TextBox,
            this.CompName3TextBox,
            this.CompName2TextBox,
            this.Label55,
            this.ZipTextBox,
            this.Label56,
            this.PhoneTextBox,
            this.Label57,
            this.ChgDateTextBox,
            this.Adrs1TextBox,
            this.Label58,
            this.Zip_1TextBox,
            this.Label59,
            this.Phone_1TextBox,
            this.Adrs1_1TextBox,
            this.Adrs2_153,
            this.Label62,
            this.Label63,
            this.Label64,
            this.Label65,
            this.PreJobRetirDate5TextBox,
            this.PreJobRetirDate4TextBox,
            this.PreJobRetirDate3TextBox,
            this.PreJobRetirDate2TextBox,
            this.JobName5TextBox,
            this.JobName4TextBox,
            this.JobName3TextBox,
            this.TextBox67,
            this.RetireReason4TextBox,
            this.AgeTextBox,
            this.StrServTextBox,
            this.Label74,
            this.Label75,
            this.Line289,
            this.Label90,
            this.Label91,
            this.Phone1TextBox,
            this.Label92,
            this.GrnNameTextBox,
            this.Label93,
            this.RELAT1TextBox,
            this.Label94,
            this.Label95,
            this.Phone2TextBox,
            this.Label96,
            this.GrnName2TextBox,
            this.Label97,
            this.Relate2TextBox,
            this.Label98,
            this.Label100,
            this.Label101,
            this.Label102,
            this.Label103,
            this.Label104,
            this.Label105,
            this.FamRal1TextBox,
            this.Line297,
            this.FamRal8TextBox,
            this.FamRal7TextBox,
            this.FamRal6TextBox,
            this.FamRal5TextBox,
            this.FamRal4TextBox,
            this.FamRal3TextBox,
            this.FamRal2,
            this.Line298,
            this.Line301,
            this.Line303,
            this.Label108,
            this.Line304,
            this.PositReasonTextBox,
            this.Label109,
            this.Line305,
            this.Line306,
            this.IntroTextBox,
            this.Label110,
            this.Label111,
            this.Label112,
            this.Label113,
            this.Label114,
            this.Label115,
            this.Label117,
            this.GraduYmTextBox,
            this.Line307,
            this.Line308,
            this.Line309,
            this.SchoolNameTextBox,
            this.SubjNameTextBox,
            this.Line310,
            this.Line311,
            this.FacultyNameTextBox,
            this.Line312,
            this.GraduTypeTextBox,
            this.DayNightTypeTextBox,
            this.Line316,
            this.FmlyAlowType1TextBox,
            this.Line317,
            this.HeltInsObjType1TextBox,
            this.Line318,
            this.DpndType1TextBox,
            this.SexType1TextBox,
            this.Label120,
            this.Employ1TextBox,
            this.EmployInsOfcNameTextBox,
            this.Line319,
            this.Label121,
            this.SocInsOfcNameTextBox178,
            this.Label122,
            this.Line320,
            this.EmployInsMarkNoTextBox,
            this.Label123,
            this.Label124,
            this.Label125,
            this.PensFndNoTextBox,
            this.PensNoTextBox,
            this.HeltInsNoTextBox,
            this.Label126,
            this.WorkAccInsOfcNameTextBox,
            this.Line321,
            this.Line322,
            this.LiveTgtType1TextBox,
            this.BirthDay1TextBox,
            this.Label127,
            this.Label128,
            this.Line323,
            this.PensFndStandCompsAmtTextBox,
            this.PensStandCompsAmtTextBox,
            this.HeltInsStandMonAmtTextBox,
            this.Label129,
            this.Label130,
            this.Label131,
            this.Label132,
            this.PensFndRevYmTextBox,
            this.PensRevYmTextBox,
            this.HeltInsRevYmTextBox,
            this.Label133,
            this.Label135,
            this.Label136,
            this.Label137,
            this.Label139,
            this.Label140,
            this.Label141,
            this.Label142,
            this.Line324,
            this.PensBasePensNoTextBox,
            this.Label145,
            this.PensBasePensNoSbnoTextBox,
            this.CareInsTextBox,
            this.LastName8TextBox,
            this.LastName7TextBox,
            this.LastName6TextBox,
            this.LastName5TextBox,
            this.LastName2TextBox,
            this.SexType8TextBox,
            this.SexType7TextBox,
            this.SexType6TextBox,
            this.SexType5TextBox,
            this.SexType4TextBox,
            this.SexType3TextBox,
            this.SexType2TextBox,
            this.BirthDay8TextBox,
            this.TBirthDay7extBox,
            this.BirthDay6TextBox,
            this.BirthDay5TextBox,
            this.TBirthDay4extBox,
            this.BirthDay3TextBox,
            this.BirthDay2TextBox,
            this.LiveTgtType8TextBox,
            this.LiveTgtType7TextBox,
            this.LiveTgtType6TextBox,
            this.LiveTgtType5TextBox,
            this.LiveTgtType4TextBox,
            this.LiveTgtType3TextBox,
            this.LiveTgtType2TextBox,
            this.Employ8TextBox,
            this.Employ7TextBox,
            this.Employ6TextBox,
            this.Employ5TextBox,
            this.Employ4TextBox,
            this.Employ3TextBox,
            this.Employ2TextBox,
            this.DpndType7TextBox,
            this.DpndType6TextBox,
            this.DpndType5TextBox,
            this.DpndType4TextBox,
            this.DpndType3TextBox,
            this.DpndType2TextBox,
            this.DpndType8TextBox,
            this.HeltInsObjType7TextBox,
            this.HeltInsObjType6TextBox,
            this.HeltInsObjType5TextBox,
            this.HeltInsObjType4TextBox,
            this.HeltInsObjType3TextBox,
            this.HeltInsObjType2TextBox,
            this.HeltInsObjType8TextBox,
            this.Label146,
            this.Zip_2TextBox,
            this.Label147,
            this.Phone_2TextBox,
            this.Label148,
            this.Name2TextBox,
            this.Label149,
            this.Relation2TextBox,
            this.HeltInsObtainDateTextBox,
            this.PensFndObtainDateTextBox,
            this.PensObtainDateTextBox,
            this.PensFndLossDateTextBox,
            this.PensLossDateTextBox,
            this.HeltInsLossDateTextBox,
            this.RetireReasonTextBox,
            this.FamRal9TextBox,
            this.LastName9TextBox,
            this.SexType9TextBox,
            this.BirthDay9TextBox,
            this.LiveTgtType9TextBox,
            this.Employ9TextBox,
            this.DpndType9TextBox,
            this.HeltInsObjType9TextBox,
            this.EmployInsObtainDateTextBox,
            this.EmployInsLossDateTextBox309,
            this.Line335,
            this.Line338,
            this.Picture1,
            this.Label175,
            this.AdrsChgDate2,
            this.Line238,
            this.Line235,
            this.Line273,
            this.BirthYmdJPText,
            this.InDateJPTextBox,
            this.AssocItemNameTextBox,
            this.Line237,
            this.Line225,
            this.Line223,
            this.Line249,
            this.Line272,
            this.Line266,
            this.Line264,
            this.Line257,
            this.Line252,
            this.Line241,
            this.Line299,
            this.Line300,
            this.subReport1});
			this.Detail.Height = 6.666667F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// Label144
			// 
			this.Label144.Height = 0.1875F;
			this.Label144.HyperLink = null;
			this.Label144.Left = 4.4375F;
			this.Label144.Name = "Label144";
			this.Label144.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label144.Text = "基礎年金番号";
			this.Label144.Top = 5.75F;
			this.Label144.Width = 1F;
			// 
			// Label143
			// 
			this.Label143.Height = 0.1875F;
			this.Label143.HyperLink = null;
			this.Label143.Left = 4.4375F;
			this.Label143.Name = "Label143";
			this.Label143.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label143.Text = "介護保険";
			this.Label143.Top = 5.4375F;
			this.Label143.Width = 1F;
			// 
			// FmlyAlowType9TextBox
			// 
			this.FmlyAlowType9TextBox.CanGrow = false;
			this.FmlyAlowType9TextBox.DataField = "FMLY_ALOW_TYPE_9";
			this.FmlyAlowType9TextBox.Height = 0.125F;
			this.FmlyAlowType9TextBox.Left = 5F;
			this.FmlyAlowType9TextBox.Name = "FmlyAlowType9TextBox";
			this.FmlyAlowType9TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType9TextBox.Text = "あいう";
			this.FmlyAlowType9TextBox.Top = 5F;
			this.FmlyAlowType9TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType8TextBox
			// 
			this.FmlyAlowType8TextBox.CanGrow = false;
			this.FmlyAlowType8TextBox.DataField = "FMLY_ALOW_TYPE_8";
			this.FmlyAlowType8TextBox.Height = 0.1875F;
			this.FmlyAlowType8TextBox.Left = 5F;
			this.FmlyAlowType8TextBox.Name = "FmlyAlowType8TextBox";
			this.FmlyAlowType8TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType8TextBox.Text = "あいう";
			this.FmlyAlowType8TextBox.Top = 4.8125F;
			this.FmlyAlowType8TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType7TextBox
			// 
			this.FmlyAlowType7TextBox.CanGrow = false;
			this.FmlyAlowType7TextBox.DataField = "FMLY_ALOW_TYPE_7";
			this.FmlyAlowType7TextBox.Height = 0.125F;
			this.FmlyAlowType7TextBox.Left = 5F;
			this.FmlyAlowType7TextBox.Name = "FmlyAlowType7TextBox";
			this.FmlyAlowType7TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType7TextBox.Text = "あいう";
			this.FmlyAlowType7TextBox.Top = 4.6875F;
			this.FmlyAlowType7TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType6TextBox
			// 
			this.FmlyAlowType6TextBox.CanGrow = false;
			this.FmlyAlowType6TextBox.DataField = "FMLY_ALOW_TYPE_6";
			this.FmlyAlowType6TextBox.Height = 0.1875F;
			this.FmlyAlowType6TextBox.Left = 5F;
			this.FmlyAlowType6TextBox.Name = "FmlyAlowType6TextBox";
			this.FmlyAlowType6TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType6TextBox.Text = "あいう";
			this.FmlyAlowType6TextBox.Top = 4.5F;
			this.FmlyAlowType6TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType5TextBox
			// 
			this.FmlyAlowType5TextBox.CanGrow = false;
			this.FmlyAlowType5TextBox.DataField = "FMLY_ALOW_TYPE_5";
			this.FmlyAlowType5TextBox.Height = 0.125F;
			this.FmlyAlowType5TextBox.Left = 5F;
			this.FmlyAlowType5TextBox.Name = "FmlyAlowType5TextBox";
			this.FmlyAlowType5TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType5TextBox.Text = "あいう";
			this.FmlyAlowType5TextBox.Top = 4.375F;
			this.FmlyAlowType5TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType4TextBox
			// 
			this.FmlyAlowType4TextBox.CanGrow = false;
			this.FmlyAlowType4TextBox.DataField = "FMLY_ALOW_TYPE_4";
			this.FmlyAlowType4TextBox.Height = 0.1875F;
			this.FmlyAlowType4TextBox.Left = 5F;
			this.FmlyAlowType4TextBox.Name = "FmlyAlowType4TextBox";
			this.FmlyAlowType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType4TextBox.Text = "あいう";
			this.FmlyAlowType4TextBox.Top = 4.1875F;
			this.FmlyAlowType4TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType3TextBox
			// 
			this.FmlyAlowType3TextBox.CanGrow = false;
			this.FmlyAlowType3TextBox.DataField = "FMLY_ALOW_TYPE_3";
			this.FmlyAlowType3TextBox.Height = 0.125F;
			this.FmlyAlowType3TextBox.Left = 5F;
			this.FmlyAlowType3TextBox.Name = "FmlyAlowType3TextBox";
			this.FmlyAlowType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType3TextBox.Text = "あいう";
			this.FmlyAlowType3TextBox.Top = 4.0625F;
			this.FmlyAlowType3TextBox.Width = 0.4375F;
			// 
			// FmlyAlowType2TextBox
			// 
			this.FmlyAlowType2TextBox.CanGrow = false;
			this.FmlyAlowType2TextBox.DataField = "FMLY_ALOW_TYPE_2";
			this.FmlyAlowType2TextBox.Height = 0.1875F;
			this.FmlyAlowType2TextBox.Left = 5F;
			this.FmlyAlowType2TextBox.Name = "FmlyAlowType2TextBox";
			this.FmlyAlowType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType2TextBox.Text = "あいう";
			this.FmlyAlowType2TextBox.Top = 3.875F;
			this.FmlyAlowType2TextBox.Width = 0.4375F;
			// 
			// Label106
			// 
			this.Label106.Height = 0.1875F;
			this.Label106.HyperLink = null;
			this.Label106.Left = 5F;
			this.Label106.Name = "Label106";
			this.Label106.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label106.Text = "家族手当";
			this.Label106.Top = 3.5625F;
			this.Label106.Width = 0.4375F;
			// 
			// RetireReason5TextBox
			// 
			this.RetireReason5TextBox.CanGrow = false;
			this.RetireReason5TextBox.DataField = "RETIRE_REASON_5";
			this.RetireReason5TextBox.Height = 0.1875F;
			this.RetireReason5TextBox.Left = 4.4375F;
			this.RetireReason5TextBox.Name = "RetireReason5TextBox";
			this.RetireReason5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireReason5TextBox.Text = "あいうえおかきくけこ";
			this.RetireReason5TextBox.Top = 2.625F;
			this.RetireReason5TextBox.Width = 1F;
			// 
			// RetireReason1TextBox
			// 
			this.RetireReason1TextBox.CanGrow = false;
			this.RetireReason1TextBox.DataField = "RETIRE_REASON_1";
			this.RetireReason1TextBox.Height = 0.1875F;
			this.RetireReason1TextBox.Left = 4.4375F;
			this.RetireReason1TextBox.Name = "RetireReason1TextBox";
			this.RetireReason1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireReason1TextBox.Text = "あいうえおかきくけこ";
			this.RetireReason1TextBox.Top = 2F;
			this.RetireReason1TextBox.Width = 1F;
			// 
			// RetireReason2TextBox
			// 
			this.RetireReason2TextBox.CanGrow = false;
			this.RetireReason2TextBox.DataField = "RETIRE_REASON_2";
			this.RetireReason2TextBox.Height = 0.125F;
			this.RetireReason2TextBox.Left = 4.4375F;
			this.RetireReason2TextBox.Name = "RetireReason2TextBox";
			this.RetireReason2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireReason2TextBox.Text = "あいうえおかきくけこ";
			this.RetireReason2TextBox.Top = 2.1875F;
			this.RetireReason2TextBox.Width = 1F;
			// 
			// RetireReason3TextBox
			// 
			this.RetireReason3TextBox.CanGrow = false;
			this.RetireReason3TextBox.DataField = "RETIRE_REASON_3";
			this.RetireReason3TextBox.Height = 0.1875F;
			this.RetireReason3TextBox.Left = 4.4375F;
			this.RetireReason3TextBox.Name = "RetireReason3TextBox";
			this.RetireReason3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireReason3TextBox.Text = "あいうえおかきくけこ";
			this.RetireReason3TextBox.Top = 2.3125F;
			this.RetireReason3TextBox.Width = 1F;
			// 
			// LastName3TextBox
			// 
			this.LastName3TextBox.CanGrow = false;
			this.LastName3TextBox.DataField = "LAST_NAME_3";
			this.LastName3TextBox.Height = 0.125F;
			this.LastName3TextBox.Left = 0.8125F;
			this.LastName3TextBox.Name = "LastName3TextBox";
			this.LastName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName3TextBox.Text = "あいうえおかき";
			this.LastName3TextBox.Top = 4.0625F;
			this.LastName3TextBox.Width = 1.375F;
			// 
			// LastName4TextBox
			// 
			this.LastName4TextBox.CanGrow = false;
			this.LastName4TextBox.DataField = "LAST_NAME_4";
			this.LastName4TextBox.Height = 0.1875F;
			this.LastName4TextBox.Left = 0.8125F;
			this.LastName4TextBox.Name = "LastName4TextBox";
			this.LastName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName4TextBox.Text = "あいうえおかき";
			this.LastName4TextBox.Top = 4.1875F;
			this.LastName4TextBox.Width = 1.375F;
			// 
			// Label53
			// 
			this.Label53.Height = 0.125F;
			this.Label53.HyperLink = null;
			this.Label53.Left = 3.4375F;
			this.Label53.Name = "Label53";
			this.Label53.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label53.Text = "職種";
			this.Label53.Top = 1.875F;
			this.Label53.Width = 1F;
			// 
			// ClsNameTextBox
			// 
			this.ClsNameTextBox.CanGrow = false;
			this.ClsNameTextBox.DataField = "CLS_NAME";
			this.ClsNameTextBox.Height = 0.125F;
			this.ClsNameTextBox.Left = 3.8125F;
			this.ClsNameTextBox.Name = "ClsNameTextBox";
			this.ClsNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ClsNameTextBox.Text = "あいうえおかきくけこ";
			this.ClsNameTextBox.Top = 1.75F;
			this.ClsNameTextBox.Width = 1.125F;
			// 
			// Label54
			// 
			this.Label54.Height = 0.125F;
			this.Label54.HyperLink = null;
			this.Label54.Left = 4.4375F;
			this.Label54.Name = "Label54";
			this.Label54.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label54.Text = "退職事由";
			this.Label54.Top = 1.875F;
			this.Label54.Width = 1F;
			// 
			// EntranceDate5TextBox
			// 
			this.EntranceDate5TextBox.CanGrow = false;
			this.EntranceDate5TextBox.DataField = "ENTRANCE_DATE_5";
			this.EntranceDate5TextBox.Height = 0.1875F;
			this.EntranceDate5TextBox.Left = 0.3125F;
			this.EntranceDate5TextBox.Name = "EntranceDate5TextBox";
			this.EntranceDate5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate5TextBox.Text = "zzz6/z6/z6";
			this.EntranceDate5TextBox.Top = 2.625F;
			this.EntranceDate5TextBox.Width = 0.5625F;
			// 
			// EntranceDate4TextBox
			// 
			this.EntranceDate4TextBox.CanGrow = false;
			this.EntranceDate4TextBox.DataField = "ENTRANCE_DATE_4";
			this.EntranceDate4TextBox.Height = 0.125F;
			this.EntranceDate4TextBox.Left = 0.3125F;
			this.EntranceDate4TextBox.Name = "EntranceDate4TextBox";
			this.EntranceDate4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate4TextBox.Text = "zzz6/z6/z6";
			this.EntranceDate4TextBox.Top = 2.5F;
			this.EntranceDate4TextBox.Width = 0.5625F;
			// 
			// EntranceDate3TextBox
			// 
			this.EntranceDate3TextBox.CanGrow = false;
			this.EntranceDate3TextBox.DataField = "ENTRANCE_DATE_3";
			this.EntranceDate3TextBox.Height = 0.1875F;
			this.EntranceDate3TextBox.Left = 0.3125F;
			this.EntranceDate3TextBox.Name = "EntranceDate3TextBox";
			this.EntranceDate3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate3TextBox.Text = "zzz6/z6/z6";
			this.EntranceDate3TextBox.Top = 2.3125F;
			this.EntranceDate3TextBox.Width = 0.5625F;
			// 
			// EntranceDate2TextBox
			// 
			this.EntranceDate2TextBox.CanGrow = false;
			this.EntranceDate2TextBox.DataField = "ENTRANCE_DATE_2";
			this.EntranceDate2TextBox.Height = 0.125F;
			this.EntranceDate2TextBox.Left = 0.3125F;
			this.EntranceDate2TextBox.Name = "EntranceDate2TextBox";
			this.EntranceDate2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate2TextBox.Text = "zzz6/z6/z6";
			this.EntranceDate2TextBox.Top = 2.1875F;
			this.EntranceDate2TextBox.Width = 0.5625F;
			// 
			// EntranceDate1TextBox
			// 
			this.EntranceDate1TextBox.CanGrow = false;
			this.EntranceDate1TextBox.DataField = "ENTRANCE_DATE_1";
			this.EntranceDate1TextBox.Height = 0.1875F;
			this.EntranceDate1TextBox.Left = 0.3125F;
			this.EntranceDate1TextBox.Name = "EntranceDate1TextBox";
			this.EntranceDate1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EntranceDate1TextBox.Text = "zzz6/z6/z6";
			this.EntranceDate1TextBox.Top = 2F;
			this.EntranceDate1TextBox.Width = 0.5625F;
			// 
			// Label33
			// 
			this.Label33.Height = 0.125F;
			this.Label33.HyperLink = null;
			this.Label33.Left = 0.3125F;
			this.Label33.Name = "Label33";
			this.Label33.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label33.Text = "勤務期間";
			this.Label33.Top = 1.875F;
			this.Label33.Width = 1.125F;
			// 
			// Label35
			// 
			this.Label35.Height = 0.6354166F;
			this.Label35.HyperLink = null;
			this.Label35.Left = 0F;
			this.Label35.Name = "Label35";
			this.Label35.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label35.Text = "保証人";
			this.Label35.Top = 2.8125F;
			this.Label35.Width = 0.3125F;
			// 
			// Label34
			// 
			this.Label34.Height = 0.9375F;
			this.Label34.HyperLink = null;
			this.Label34.Left = 0F;
			this.Label34.Name = "Label34";
			this.Label34.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label34.Text = " 前 職歴";
			this.Label34.Top = 1.875F;
			this.Label34.Width = 0.3125F;
			// 
			// PositTypeNameTextBox
			// 
			this.PositTypeNameTextBox.CanGrow = false;
			this.PositTypeNameTextBox.DataField = "POSIT_TYPE_NAME";
			this.PositTypeNameTextBox.Height = 0.125F;
			this.PositTypeNameTextBox.Left = 0.3125F;
			this.PositTypeNameTextBox.Name = "PositTypeNameTextBox";
			this.PositTypeNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PositTypeNameTextBox.Text = "あいうえおかきく";
			this.PositTypeNameTextBox.Top = 3.4375F;
			this.PositTypeNameTextBox.Width = 0.8125F;
			// 
			// GrnAdrs3TextBox
			// 
			this.GrnAdrs3TextBox.CanGrow = false;
			this.GrnAdrs3TextBox.DataField = "GRN_ADRS3";
			this.GrnAdrs3TextBox.Height = 0.1875F;
			this.GrnAdrs3TextBox.Left = 0.3125F;
			this.GrnAdrs3TextBox.Name = "GrnAdrs3TextBox";
			this.GrnAdrs3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GrnAdrs3TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなに";
			this.GrnAdrs3TextBox.Top = 3.25F;
			this.GrnAdrs3TextBox.Width = 5.0625F;
			// 
			// Zip2TextBox
			// 
			this.Zip2TextBox.CanGrow = false;
			this.Zip2TextBox.DataField = "ZIP2";
			this.Zip2TextBox.Height = 0.125F;
			this.Zip2TextBox.Left = 0.4375F;
			this.Zip2TextBox.Name = "Zip2TextBox";
			this.Zip2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Zip2TextBox.Text = "0000000000";
			this.Zip2TextBox.Top = 3.125F;
			this.Zip2TextBox.Width = 0.5F;
			// 
			// GrnAdrs1TextBox
			// 
			this.GrnAdrs1TextBox.CanGrow = false;
			this.GrnAdrs1TextBox.DataField = "GRN_ADRS1";
			this.GrnAdrs1TextBox.Height = 0.1875F;
			this.GrnAdrs1TextBox.Left = 0.3125F;
			this.GrnAdrs1TextBox.Name = "GrnAdrs1TextBox";
			this.GrnAdrs1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GrnAdrs1TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなに";
			this.GrnAdrs1TextBox.Top = 2.9375F;
			this.GrnAdrs1TextBox.Width = 5.135417F;
			// 
			// TextBox122
			// 
			this.TextBox122.CanGrow = false;
			this.TextBox122.DataField = "ZIP1";
			this.TextBox122.Height = 0.125F;
			this.TextBox122.Left = 0.4375F;
			this.TextBox122.Name = "TextBox122";
			this.TextBox122.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TextBox122.Text = "0000000000";
			this.TextBox122.Top = 2.8125F;
			this.TextBox122.Width = 0.5F;
			// 
			// Label37
			// 
			this.Label37.Height = 1.5625F;
			this.Label37.HyperLink = null;
			this.Label37.Left = 0F;
			this.Label37.Name = "Label37";
			this.Label37.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label37.Text = "家族情報";
			this.Label37.Top = 3.5625F;
			this.Label37.Width = 0.3125F;
			// 
			// Label36
			// 
			this.Label36.Height = 0.125F;
			this.Label36.HyperLink = null;
			this.Label36.Left = 0F;
			this.Label36.Name = "Label36";
			this.Label36.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label36.Text = "採用";
			this.Label36.Top = 3.4375F;
			this.Label36.Width = 0.3125F;
			// 
			// LastName1TextBox
			// 
			this.LastName1TextBox.CanGrow = false;
			this.LastName1TextBox.DataField = "LAST_NAME_1";
			this.LastName1TextBox.Height = 0.125F;
			this.LastName1TextBox.Left = 0.8125F;
			this.LastName1TextBox.Name = "LastName1TextBox";
			this.LastName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName1TextBox.Text = "あいうえおかき";
			this.LastName1TextBox.Top = 3.75F;
			this.LastName1TextBox.Width = 1.375F;
			// 
			// Label99
			// 
			this.Label99.Height = 0.1875F;
			this.Label99.HyperLink = null;
			this.Label99.Left = 0.8125F;
			this.Label99.Name = "Label99";
			this.Label99.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label99.Text = "氏名";
			this.Label99.Top = 3.5625F;
			this.Label99.Width = 1.375F;
			// 
			// Line117
			// 
			this.Line117.Height = 0.305F;
			this.Line117.Left = 1.829861F;
			this.Line117.LineWeight = 1F;
			this.Line117.Name = "Line117";
			this.Line117.Top = 0.312F;
			this.Line117.Width = 0F;
			this.Line117.X1 = 1.829861F;
			this.Line117.X2 = 1.829861F;
			this.Line117.Y1 = 0.312F;
			this.Line117.Y2 = 0.617F;
			// 
			// Line120
			// 
			this.Line120.Height = 0F;
			this.Line120.Left = 0.006944444F;
			this.Line120.LineWeight = 1F;
			this.Line120.Name = "Line120";
			this.Line120.Top = 0.312F;
			this.Line120.Width = 4.276055F;
			this.Line120.X1 = 0.006944444F;
			this.Line120.X2 = 4.283F;
			this.Line120.Y1 = 0.312F;
			this.Line120.Y2 = 0.312F;
			// 
			// Line123
			// 
			this.Line123.Height = 6.375055F;
			this.Line123.Left = 0F;
			this.Line123.LineWeight = 1F;
			this.Line123.Name = "Line123";
			this.Line123.Top = 0.006944444F;
			this.Line123.Width = 0F;
			this.Line123.X1 = 0F;
			this.Line123.X2 = 0F;
			this.Line123.Y1 = 0.006944444F;
			this.Line123.Y2 = 6.382F;
			// 
			// EmpCodeTextBox
			// 
			this.EmpCodeTextBox.CanGrow = false;
			this.EmpCodeTextBox.DataField = "EMP_CODE";
			this.EmpCodeTextBox.Height = 0.3125F;
			this.EmpCodeTextBox.Left = 0.3125F;
			this.EmpCodeTextBox.Name = "EmpCodeTextBox";
			this.EmpCodeTextBox.Style = "font-size: 9pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmpCodeTextBox.Text = "0000000000";
			this.EmpCodeTextBox.Top = 0F;
			this.EmpCodeTextBox.Width = 1.75F;
			// 
			// NameTextBox
			// 
			this.NameTextBox.CanGrow = false;
			this.NameTextBox.DataField = "NAME";
			this.NameTextBox.Height = 0.1875F;
			this.NameTextBox.Left = 0.313F;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.NameTextBox.Text = "あいうえおかきくけこさしすせそ";
			this.NameTextBox.Top = 0.444F;
			this.NameTextBox.Width = 1.5F;
			// 
			// BirthYmdText
			// 
			this.BirthYmdText.CanGrow = false;
			this.BirthYmdText.DataField = "BIRTH_YMD";
			this.BirthYmdText.Height = 0.15F;
			this.BirthYmdText.Left = 2.6875F;
			this.BirthYmdText.Name = "BirthYmdText";
			this.BirthYmdText.OutputFormat = "yyyy年MM月dd日";
			this.BirthYmdText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthYmdText.Text = "0000年00月00日";
			this.BirthYmdText.Top = 0F;
			this.BirthYmdText.Width = 0.7F;
			// 
			// Line196
			// 
			this.Line196.Height = 6.381F;
			this.Line196.Left = 5.444F;
			this.Line196.LineWeight = 1F;
			this.Line196.Name = "Line196";
			this.Line196.Top = 0.001F;
			this.Line196.Width = 0F;
			this.Line196.X1 = 5.444F;
			this.Line196.X2 = 5.444F;
			this.Line196.Y1 = 0.001F;
			this.Line196.Y2 = 6.382F;
			// 
			// Line218
			// 
			this.Line218.Height = 6.375F;
			this.Line218.Left = 0.3125F;
			this.Line218.LineWeight = 1F;
			this.Line218.Name = "Line218";
			this.Line218.Top = 0.007F;
			this.Line218.Width = 0.0004999042F;
			this.Line218.X1 = 0.3129999F;
			this.Line218.X2 = 0.3125F;
			this.Line218.Y1 = 0.007F;
			this.Line218.Y2 = 6.382F;
			// 
			// Line219
			// 
			this.Line219.Height = 0.61F;
			this.Line219.Left = 2.631944F;
			this.Line219.LineWeight = 1F;
			this.Line219.Name = "Line219";
			this.Line219.Top = 0.007F;
			this.Line219.Width = 0F;
			this.Line219.X1 = 2.631944F;
			this.Line219.X2 = 2.631944F;
			this.Line219.Y1 = 0.007F;
			this.Line219.Y2 = 0.617F;
			// 
			// Line220
			// 
			this.Line220.Height = 0.305F;
			this.Line220.Left = 4.009F;
			this.Line220.LineWeight = 1F;
			this.Line220.Name = "Line220";
			this.Line220.Top = 0.007F;
			this.Line220.Width = 0F;
			this.Line220.X1 = 4.009F;
			this.Line220.X2 = 4.009F;
			this.Line220.Y1 = 0.007F;
			this.Line220.Y2 = 0.312F;
			// 
			// Line221
			// 
			this.Line221.Height = 0.765F;
			this.Line221.Left = 4.283F;
			this.Line221.LineWeight = 1F;
			this.Line221.Name = "Line221";
			this.Line221.Top = 0.007F;
			this.Line221.Width = 0F;
			this.Line221.X1 = 4.283F;
			this.Line221.X2 = 4.283F;
			this.Line221.Y1 = 0.007F;
			this.Line221.Y2 = 0.772F;
			// 
			// Label8
			// 
			this.Label8.Height = 0.3125F;
			this.Label8.HyperLink = null;
			this.Label8.Left = 0F;
			this.Label8.Name = "Label8";
			this.Label8.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label8.Text = "社員番号";
			this.Label8.Top = 0F;
			this.Label8.Width = 0.3125F;
			// 
			// Line222
			// 
			this.Line222.Height = 0F;
			this.Line222.Left = 0.313F;
			this.Line222.LineWeight = 1F;
			this.Line222.Name = "Line222";
			this.Line222.Top = 0.462F;
			this.Line222.Width = 3.97F;
			this.Line222.X1 = 0.313F;
			this.Line222.X2 = 4.283F;
			this.Line222.Y1 = 0.462F;
			this.Line222.Y2 = 0.462F;
			// 
			// Label9
			// 
			this.Label9.Height = 0.3125F;
			this.Label9.HyperLink = null;
			this.Label9.Left = 0F;
			this.Label9.Name = "Label9";
			this.Label9.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label9.Text = "氏名";
			this.Label9.Top = 0.3125F;
			this.Label9.Width = 0.3125F;
			// 
			// Label10
			// 
			this.Label10.Height = 0.3125F;
			this.Label10.HyperLink = null;
			this.Label10.Left = 0F;
			this.Label10.Name = "Label10";
			this.Label10.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label10.Text = " 現 住所";
			this.Label10.Top = 0.625F;
			this.Label10.Width = 0.3125F;
			// 
			// NameKanaTextBox
			// 
			this.NameKanaTextBox.CanGrow = false;
			this.NameKanaTextBox.DataField = "NAME_KANA";
			this.NameKanaTextBox.Height = 0.125F;
			this.NameKanaTextBox.Left = 0.3125F;
			this.NameKanaTextBox.Name = "NameKanaTextBox";
			this.NameKanaTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.NameKanaTextBox.Text = "000000000000000000000000000000";
			this.NameKanaTextBox.Top = 0.3125F;
			this.NameKanaTextBox.Width = 1.5F;
			// 
			// Line226
			// 
			this.Line226.Height = 0.61F;
			this.Line226.Left = 2.079861F;
			this.Line226.LineWeight = 1F;
			this.Line226.Name = "Line226";
			this.Line226.Top = 0.007F;
			this.Line226.Width = 0.000138998F;
			this.Line226.X1 = 2.08F;
			this.Line226.X2 = 2.079861F;
			this.Line226.Y1 = 0.007F;
			this.Line226.Y2 = 0.617F;
			// 
			// Label11
			// 
			this.Label11.Height = 0.125F;
			this.Label11.HyperLink = null;
			this.Label11.Left = 1.8125F;
			this.Label11.Name = "Label11";
			this.Label11.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label11.Text = "性別";
			this.Label11.Top = 0.3125F;
			this.Label11.Width = 0.3125F;
			// 
			// Label12
			// 
			this.Label12.Height = 0.3125F;
			this.Label12.HyperLink = null;
			this.Label12.Left = 0F;
			this.Label12.Name = "Label12";
			this.Label12.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label12.Text = "年調";
			this.Label12.Top = 0.9375F;
			this.Label12.Width = 0.3125F;
			// 
			// Label13
			// 
			this.Label13.Height = 0.15F;
			this.Label13.HyperLink = null;
			this.Label13.Left = 2.0625F;
			this.Label13.Name = "Label13";
			this.Label13.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label13.Text = "生年月日";
			this.Label13.Top = 0F;
			this.Label13.Width = 0.6000001F;
			// 
			// Line229
			// 
			this.Line229.Height = 0F;
			this.Line229.Left = 2.08F;
			this.Line229.LineWeight = 1F;
			this.Line229.Name = "Line229";
			this.Line229.Top = 0.157F;
			this.Line229.Width = 2.203F;
			this.Line229.X1 = 2.08F;
			this.Line229.X2 = 4.283F;
			this.Line229.Y1 = 0.157F;
			this.Line229.Y2 = 0.157F;
			// 
			// Label14
			// 
			this.Label14.Height = 0.15F;
			this.Label14.HyperLink = null;
			this.Label14.Left = 2.063F;
			this.Label14.Name = "Label14";
			this.Label14.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label14.Text = "入社日";
			this.Label14.Top = 0.17F;
			this.Label14.Width = 0.6000001F;
			// 
			// Label15
			// 
			this.Label15.Height = 0.15F;
			this.Label15.HyperLink = null;
			this.Label15.Left = 2.0625F;
			this.Label15.Name = "Label15";
			this.Label15.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label15.Text = "氏名変更日";
			this.Label15.Top = 0.313F;
			this.Label15.Width = 0.6000001F;
			// 
			// Label16
			// 
			this.Label16.Height = 0.15F;
			this.Label16.HyperLink = null;
			this.Label16.Left = 2.063F;
			this.Label16.Name = "Label16";
			this.Label16.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label16.Text = "退職日";
			this.Label16.Top = 0.46F;
			this.Label16.Width = 0.6000001F;
			// 
			// Line230
			// 
			this.Line230.Height = 0.765F;
			this.Line230.Left = 3.756944F;
			this.Line230.LineWeight = 1F;
			this.Line230.Name = "Line230";
			this.Line230.Top = 0.007F;
			this.Line230.Width = 0F;
			this.Line230.X1 = 3.756944F;
			this.Line230.X2 = 3.756944F;
			this.Line230.Y1 = 0.007F;
			this.Line230.Y2 = 0.772F;
			// 
			// Label17
			// 
			this.Label17.Height = 0.125F;
			this.Label17.HyperLink = null;
			this.Label17.Left = 3.75F;
			this.Label17.Name = "Label17";
			this.Label17.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label17.Text = "退職事由";
			this.Label17.Top = 0.313F;
			this.Label17.Width = 0.5625F;
			// 
			// SexTypeTextBox
			// 
			this.SexTypeTextBox.CanGrow = false;
			this.SexTypeTextBox.DataField = "SEX_TYPE";
			this.SexTypeTextBox.Height = 0.1875F;
			this.SexTypeTextBox.Left = 1.813F;
			this.SexTypeTextBox.Name = "SexTypeTextBox";
			this.SexTypeTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexTypeTextBox.Text = "○";
			this.SexTypeTextBox.Top = 0.444F;
			this.SexTypeTextBox.Width = 0.25F;
			// 
			// RetireDateTextBox
			// 
			this.RetireDateTextBox.CanGrow = false;
			this.RetireDateTextBox.DataField = "RETIRE_DATE";
			this.RetireDateTextBox.Height = 0.15F;
			this.RetireDateTextBox.Left = 2.6875F;
			this.RetireDateTextBox.Name = "RetireDateTextBox";
			this.RetireDateTextBox.OutputFormat = "yyyy年MM月dd日";
			this.RetireDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireDateTextBox.Text = "0000年00月00日";
			this.RetireDateTextBox.Top = 0.46F;
			this.RetireDateTextBox.Width = 0.875F;
			// 
			// TextBox
			// 
			this.TextBox.CanGrow = false;
			this.TextBox.DataField = "MARRI_YMD";
			this.TextBox.Height = 0.15F;
			this.TextBox.Left = 2.6875F;
			this.TextBox.Name = "TextBox";
			this.TextBox.OutputFormat = "yyyy年MM月dd日";
			this.TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TextBox.Text = "0000年00月00日";
			this.TextBox.Top = 0.3125F;
			this.TextBox.Width = 0.875F;
			// 
			// InDateTextBox
			// 
			this.InDateTextBox.CanGrow = false;
			this.InDateTextBox.DataField = "IN_DATE";
			this.InDateTextBox.Height = 0.15F;
			this.InDateTextBox.Left = 2.6875F;
			this.InDateTextBox.Name = "InDateTextBox";
			this.InDateTextBox.OutputFormat = "yyyy年MM月dd日";
			this.InDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDateTextBox.Text = "0000年00月00日";
			this.InDateTextBox.Top = 0.17F;
			this.InDateTextBox.Width = 0.7F;
			// 
			// Label18
			// 
			this.Label18.Height = 0.1875F;
			this.Label18.HyperLink = null;
			this.Label18.Left = 3.75F;
			this.Label18.Name = "Label18";
			this.Label18.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label18.Text = "年齢";
			this.Label18.Top = 0F;
			this.Label18.Width = 0.25F;
			// 
			// Label19
			// 
			this.Label19.Height = 0.125F;
			this.Label19.HyperLink = null;
			this.Label19.Left = 3.75F;
			this.Label19.Name = "Label19";
			this.Label19.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label19.Text = "勤続";
			this.Label19.Top = 0.1875F;
			this.Label19.Width = 0.25F;
			// 
			// Line233
			// 
			this.Line233.Height = 0F;
			this.Line233.Left = 0F;
			this.Line233.LineWeight = 1F;
			this.Line233.Name = "Line233";
			this.Line233.Top = 0.617F;
			this.Line233.Width = 3.757F;
			this.Line233.X1 = 0F;
			this.Line233.X2 = 3.757F;
			this.Line233.Y1 = 0.617F;
			this.Line233.Y2 = 0.617F;
			// 
			// Label32
			// 
			this.Label32.Height = 0.3125F;
			this.Label32.HyperLink = null;
			this.Label32.Left = 0F;
			this.Label32.Name = "Label32";
			this.Label32.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label32.Text = "最終学歴";
			this.Label32.Top = 1.5625F;
			this.Label32.Width = 0.3125F;
			// 
			// Line243
			// 
			this.Line243.Height = 0F;
			this.Line243.Left = 0.313F;
			this.Line243.LineWeight = 1F;
			this.Line243.Name = "Line243";
			this.Line243.Top = 2.18F;
			this.Line243.Width = 5.131F;
			this.Line243.X1 = 0.313F;
			this.Line243.X2 = 5.444F;
			this.Line243.Y1 = 2.18F;
			this.Line243.Y2 = 2.18F;
			// 
			// Line245
			// 
			this.Line245.Height = 0F;
			this.Line245.Left = 0F;
			this.Line245.LineWeight = 1F;
			this.Line245.Name = "Line245";
			this.Line245.Top = 1.87F;
			this.Line245.Width = 5.444F;
			this.Line245.X1 = 0F;
			this.Line245.X2 = 5.444F;
			this.Line245.Y1 = 1.87F;
			this.Line245.Y2 = 1.87F;
			// 
			// Line246
			// 
			this.Line246.Height = 0F;
			this.Line246.Left = 0.313F;
			this.Line246.LineWeight = 1F;
			this.Line246.Name = "Line246";
			this.Line246.Top = 2.025F;
			this.Line246.Width = 5.131F;
			this.Line246.X1 = 0.313F;
			this.Line246.X2 = 5.444F;
			this.Line246.Y1 = 2.025F;
			this.Line246.Y2 = 2.025F;
			// 
			// Line247
			// 
			this.Line247.Height = 0F;
			this.Line247.Left = 0.313F;
			this.Line247.LineWeight = 1F;
			this.Line247.Name = "Line247";
			this.Line247.Top = 2.336F;
			this.Line247.Width = 5.131F;
			this.Line247.X1 = 0.313F;
			this.Line247.X2 = 5.444F;
			this.Line247.Y1 = 2.336F;
			this.Line247.Y2 = 2.336F;
			// 
			// Line248
			// 
			this.Line248.Height = 0F;
			this.Line248.Left = 0.313F;
			this.Line248.LineWeight = 1F;
			this.Line248.Name = "Line248";
			this.Line248.Top = 2.951F;
			this.Line248.Width = 5.131F;
			this.Line248.X1 = 0.313F;
			this.Line248.X2 = 5.444F;
			this.Line248.Y1 = 2.951F;
			this.Line248.Y2 = 2.951F;
			// 
			// Line250
			// 
			this.Line250.Height = 0F;
			this.Line250.Left = 0.313F;
			this.Line250.LineWeight = 1F;
			this.Line250.Name = "Line250";
			this.Line250.Top = 2.491F;
			this.Line250.Width = 5.131095F;
			this.Line250.X1 = 0.313F;
			this.Line250.X2 = 5.444095F;
			this.Line250.Y1 = 2.491F;
			this.Line250.Y2 = 2.491F;
			// 
			// Line251
			// 
			this.Line251.Height = 0F;
			this.Line251.Left = 0F;
			this.Line251.LineWeight = 1F;
			this.Line251.Name = "Line251";
			this.Line251.Top = 2.796F;
			this.Line251.Width = 5.444F;
			this.Line251.X1 = 0F;
			this.Line251.X2 = 5.444F;
			this.Line251.Y1 = 2.796F;
			this.Line251.Y2 = 2.796F;
			// 
			// Line253
			// 
			this.Line253.Height = 0F;
			this.Line253.Left = 0.313F;
			this.Line253.LineWeight = 1F;
			this.Line253.Name = "Line253";
			this.Line253.Top = 3.106F;
			this.Line253.Width = 5.131F;
			this.Line253.X1 = 0.313F;
			this.Line253.X2 = 5.444F;
			this.Line253.Y1 = 3.106F;
			this.Line253.Y2 = 3.106F;
			// 
			// Line254
			// 
			this.Line254.Height = 0F;
			this.Line254.Left = 0.313F;
			this.Line254.LineWeight = 1F;
			this.Line254.Name = "Line254";
			this.Line254.Top = 3.262F;
			this.Line254.Width = 5.131F;
			this.Line254.X1 = 0.313F;
			this.Line254.X2 = 5.444F;
			this.Line254.Y1 = 3.262F;
			this.Line254.Y2 = 3.262F;
			// 
			// Line255
			// 
			this.Line255.Height = 0F;
			this.Line255.Left = 0F;
			this.Line255.LineWeight = 1F;
			this.Line255.Name = "Line255";
			this.Line255.Top = 3.573F;
			this.Line255.Width = 5.444F;
			this.Line255.X1 = 0F;
			this.Line255.X2 = 5.444F;
			this.Line255.Y1 = 3.573F;
			this.Line255.Y2 = 3.573F;
			// 
			// Line256
			// 
			this.Line256.Height = 0F;
			this.Line256.Left = 0.313F;
			this.Line256.LineWeight = 1F;
			this.Line256.Name = "Line256";
			this.Line256.Top = 4.508F;
			this.Line256.Width = 5.131F;
			this.Line256.X1 = 0.313F;
			this.Line256.X2 = 5.444F;
			this.Line256.Y1 = 4.508F;
			this.Line256.Y2 = 4.508F;
			// 
			// Line258
			// 
			this.Line258.Height = 0F;
			this.Line258.Left = 0.313F;
			this.Line258.LineWeight = 1F;
			this.Line258.Name = "Line258";
			this.Line258.Top = 4.04F;
			this.Line258.Width = 5.131F;
			this.Line258.X1 = 0.313F;
			this.Line258.X2 = 5.444F;
			this.Line258.Y1 = 4.04F;
			this.Line258.Y2 = 4.04F;
			// 
			// Line259
			// 
			this.Line259.Height = 0F;
			this.Line259.Left = 0.313F;
			this.Line259.LineWeight = 1F;
			this.Line259.Name = "Line259";
			this.Line259.Top = 3.884F;
			this.Line259.Width = 5.131F;
			this.Line259.X1 = 0.313F;
			this.Line259.X2 = 5.444F;
			this.Line259.Y1 = 3.884F;
			this.Line259.Y2 = 3.884F;
			// 
			// Line260
			// 
			this.Line260.Height = 0F;
			this.Line260.Left = 0.313F;
			this.Line260.LineWeight = 1F;
			this.Line260.Name = "Line260";
			this.Line260.Top = 3.728F;
			this.Line260.Width = 5.131F;
			this.Line260.X1 = 0.313F;
			this.Line260.X2 = 5.444F;
			this.Line260.Y1 = 3.728F;
			this.Line260.Y2 = 3.728F;
			// 
			// Line261
			// 
			this.Line261.Height = 0F;
			this.Line261.Left = 0.313F;
			this.Line261.LineWeight = 1F;
			this.Line261.Name = "Line261";
			this.Line261.Top = 4.664F;
			this.Line261.Width = 5.131F;
			this.Line261.X1 = 0.313F;
			this.Line261.X2 = 5.444F;
			this.Line261.Y1 = 4.664F;
			this.Line261.Y2 = 4.664F;
			// 
			// Line262
			// 
			this.Line262.Height = 0F;
			this.Line262.Left = 0.313F;
			this.Line262.LineWeight = 1F;
			this.Line262.Name = "Line262";
			this.Line262.Top = 4.819F;
			this.Line262.Width = 5.131F;
			this.Line262.X1 = 0.313F;
			this.Line262.X2 = 5.444F;
			this.Line262.Y1 = 4.819F;
			this.Line262.Y2 = 4.819F;
			// 
			// Line263
			// 
			this.Line263.Height = 0F;
			this.Line263.Left = 0.313F;
			this.Line263.LineWeight = 1F;
			this.Line263.Name = "Line263";
			this.Line263.Top = 4.975F;
			this.Line263.Width = 5.131F;
			this.Line263.X1 = 0.313F;
			this.Line263.X2 = 5.444F;
			this.Line263.Y1 = 4.975F;
			this.Line263.Y2 = 4.975F;
			// 
			// Label38
			// 
			this.Label38.Height = 1.25F;
			this.Label38.HyperLink = null;
			this.Label38.Left = 0F;
			this.Label38.Name = "Label38";
			this.Label38.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label38.Text = "社会保険";
			this.Label38.Top = 5.125F;
			this.Label38.Width = 0.3125F;
			// 
			// Line265
			// 
			this.Line265.Height = 0F;
			this.Line265.Left = 0.313F;
			this.Line265.LineWeight = 1F;
			this.Line265.Name = "Line265";
			this.Line265.Top = 5.287F;
			this.Line265.Width = 5.131F;
			this.Line265.X1 = 0.313F;
			this.Line265.X2 = 5.444F;
			this.Line265.Y1 = 5.287F;
			this.Line265.Y2 = 5.287F;
			// 
			// Line267
			// 
			this.Line267.Height = 0F;
			this.Line267.Left = 0.313F;
			this.Line267.LineWeight = 1F;
			this.Line267.Name = "Line267";
			this.Line267.Top = 5.6F;
			this.Line267.Width = 5.131F;
			this.Line267.X1 = 0.313F;
			this.Line267.X2 = 5.444F;
			this.Line267.Y1 = 5.6F;
			this.Line267.Y2 = 5.6F;
			// 
			// Line268
			// 
			this.Line268.Height = 0F;
			this.Line268.Left = 0.313F;
			this.Line268.LineWeight = 1F;
			this.Line268.Name = "Line268";
			this.Line268.Top = 5.757F;
			this.Line268.Width = 5.131F;
			this.Line268.X1 = 0.313F;
			this.Line268.X2 = 5.444F;
			this.Line268.Y1 = 5.757F;
			this.Line268.Y2 = 5.757F;
			// 
			// Line269
			// 
			this.Line269.Height = 0F;
			this.Line269.Left = 0.3194444F;
			this.Line269.LineWeight = 1F;
			this.Line269.Name = "Line269";
			this.Line269.Top = 5.913F;
			this.Line269.Width = 5.124556F;
			this.Line269.X1 = 0.3194444F;
			this.Line269.X2 = 5.444F;
			this.Line269.Y1 = 5.913F;
			this.Line269.Y2 = 5.913F;
			// 
			// Line270
			// 
			this.Line270.Height = 0F;
			this.Line270.Left = 0.313F;
			this.Line270.LineWeight = 1F;
			this.Line270.Name = "Line270";
			this.Line270.Top = 6.069445F;
			this.Line270.Width = 5.131F;
			this.Line270.X1 = 0.313F;
			this.Line270.X2 = 5.444F;
			this.Line270.Y1 = 6.069445F;
			this.Line270.Y2 = 6.069445F;
			// 
			// Line271
			// 
			this.Line271.Height = 0.0004997253F;
			this.Line271.Left = 0.313F;
			this.Line271.LineWeight = 1F;
			this.Line271.Name = "Line271";
			this.Line271.Top = 6.2255F;
			this.Line271.Width = 5.131F;
			this.Line271.X1 = 0.313F;
			this.Line271.X2 = 5.444F;
			this.Line271.Y1 = 6.2255F;
			this.Line271.Y2 = 6.226F;
			// 
			// Line277
			// 
			this.Line277.Height = 0.926F;
			this.Line277.Left = 1.444444F;
			this.Line277.LineWeight = 1F;
			this.Line277.Name = "Line277";
			this.Line277.Top = 1.87F;
			this.Line277.Width = 0.0005010366F;
			this.Line277.X1 = 1.444444F;
			this.Line277.X2 = 1.444945F;
			this.Line277.Y1 = 1.87F;
			this.Line277.Y2 = 2.796F;
			// 
			// PreJobRetirDate1TextBox
			// 
			this.PreJobRetirDate1TextBox.CanGrow = false;
			this.PreJobRetirDate1TextBox.DataField = "PRE_JOB_RETIR_DATE_1";
			this.PreJobRetirDate1TextBox.Height = 0.1875F;
			this.PreJobRetirDate1TextBox.Left = 0.9375F;
			this.PreJobRetirDate1TextBox.Name = "PreJobRetirDate1TextBox";
			this.PreJobRetirDate1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PreJobRetirDate1TextBox.Text = "zzz6/z6/z6";
			this.PreJobRetirDate1TextBox.Top = 2F;
			this.PreJobRetirDate1TextBox.Width = 0.5625F;
			// 
			// Label49
			// 
			this.Label49.Height = 0.125F;
			this.Label49.HyperLink = null;
			this.Label49.Left = 0.813F;
			this.Label49.Name = "Label49";
			this.Label49.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label49.Text = "～";
			this.Label49.Top = 2.05F;
			this.Label49.Width = 0.125F;
			// 
			// Label50
			// 
			this.Label50.Height = 0.125F;
			this.Label50.HyperLink = null;
			this.Label50.Left = 1.5F;
			this.Label50.Name = "Label50";
			this.Label50.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label50.Text = "会社名";
			this.Label50.Top = 1.875F;
			this.Label50.Width = 1.875F;
			// 
			// Line278
			// 
			this.Line278.Height = 0.926F;
			this.Line278.Left = 3.407999F;
			this.Line278.LineWeight = 1F;
			this.Line278.Name = "Line278";
			this.Line278.Top = 1.87F;
			this.Line278.Width = 0.0005009174F;
			this.Line278.X1 = 3.407999F;
			this.Line278.X2 = 3.4085F;
			this.Line278.Y1 = 1.87F;
			this.Line278.Y2 = 2.796F;
			// 
			// Line281
			// 
			this.Line281.Height = 0.926F;
			this.Line281.Left = 4.444F;
			this.Line281.LineWeight = 1F;
			this.Line281.Name = "Line281";
			this.Line281.Top = 1.87F;
			this.Line281.Width = 0F;
			this.Line281.X1 = 4.444F;
			this.Line281.X2 = 4.444F;
			this.Line281.Y1 = 1.87F;
			this.Line281.Y2 = 2.796F;
			// 
			// CompName1TextBox
			// 
			this.CompName1TextBox.CanGrow = false;
			this.CompName1TextBox.DataField = "COMP_NAME_1";
			this.CompName1TextBox.Height = 0.1875F;
			this.CompName1TextBox.Left = 1.4375F;
			this.CompName1TextBox.Name = "CompName1TextBox";
			this.CompName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName1TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.CompName1TextBox.Top = 2F;
			this.CompName1TextBox.Width = 1.9375F;
			// 
			// JobName1TextBox
			// 
			this.JobName1TextBox.CanGrow = false;
			this.JobName1TextBox.DataField = "JOB_NAME_1";
			this.JobName1TextBox.Height = 0.1875F;
			this.JobName1TextBox.Left = 3.4375F;
			this.JobName1TextBox.Name = "JobName1TextBox";
			this.JobName1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobName1TextBox.Text = "あいうえおかきくけこ";
			this.JobName1TextBox.Top = 2F;
			this.JobName1TextBox.Width = 1F;
			// 
			// CompName5TextBox
			// 
			this.CompName5TextBox.CanGrow = false;
			this.CompName5TextBox.DataField = "COMP_NAME_5";
			this.CompName5TextBox.Height = 0.1875F;
			this.CompName5TextBox.Left = 1.4375F;
			this.CompName5TextBox.Name = "CompName5TextBox";
			this.CompName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName5TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.CompName5TextBox.Top = 2.625F;
			this.CompName5TextBox.Width = 1.9375F;
			// 
			// CompName4TextBox
			// 
			this.CompName4TextBox.CanGrow = false;
			this.CompName4TextBox.DataField = "COMP_NAME_4";
			this.CompName4TextBox.Height = 0.125F;
			this.CompName4TextBox.Left = 1.4375F;
			this.CompName4TextBox.Name = "CompName4TextBox";
			this.CompName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName4TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.CompName4TextBox.Top = 2.5F;
			this.CompName4TextBox.Width = 2F;
			// 
			// CompName3TextBox
			// 
			this.CompName3TextBox.CanGrow = false;
			this.CompName3TextBox.DataField = "COMP_NAME_3";
			this.CompName3TextBox.Height = 0.1875F;
			this.CompName3TextBox.Left = 1.4375F;
			this.CompName3TextBox.Name = "CompName3TextBox";
			this.CompName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName3TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.CompName3TextBox.Top = 2.3125F;
			this.CompName3TextBox.Width = 2F;
			// 
			// CompName2TextBox
			// 
			this.CompName2TextBox.CanGrow = false;
			this.CompName2TextBox.DataField = "COMP_NAME_2";
			this.CompName2TextBox.Height = 0.125F;
			this.CompName2TextBox.Left = 1.4375F;
			this.CompName2TextBox.Name = "CompName2TextBox";
			this.CompName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CompName2TextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.CompName2TextBox.Top = 2.1875F;
			this.CompName2TextBox.Width = 2F;
			// 
			// Label55
			// 
			this.Label55.Height = 0.125F;
			this.Label55.HyperLink = null;
			this.Label55.Left = 0.3125F;
			this.Label55.Name = "Label55";
			this.Label55.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label55.Text = "〒";
			this.Label55.Top = 0.625F;
			this.Label55.Width = 0.125F;
			// 
			// ZipTextBox
			// 
			this.ZipTextBox.CanGrow = false;
			this.ZipTextBox.DataField = "ZIP";
			this.ZipTextBox.Height = 0.125F;
			this.ZipTextBox.Left = 0.4375F;
			this.ZipTextBox.Name = "ZipTextBox";
			this.ZipTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ZipTextBox.Text = "0000000000";
			this.ZipTextBox.Top = 0.625F;
			this.ZipTextBox.Width = 0.5F;
			// 
			// Label56
			// 
			this.Label56.Height = 0.125F;
			this.Label56.HyperLink = null;
			this.Label56.Left = 0.9375F;
			this.Label56.Name = "Label56";
			this.Label56.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label56.Text = "℡";
			this.Label56.Top = 0.625F;
			this.Label56.Width = 0.125F;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.CanGrow = false;
			this.PhoneTextBox.DataField = "PHONE";
			this.PhoneTextBox.Height = 0.125F;
			this.PhoneTextBox.Left = 1.0625F;
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PhoneTextBox.Text = "000000000000000";
			this.PhoneTextBox.Top = 0.625F;
			this.PhoneTextBox.Width = 0.75F;
			// 
			// Label57
			// 
			this.Label57.Height = 0.125F;
			this.Label57.HyperLink = null;
			this.Label57.Left = 2.3125F;
			this.Label57.Name = "Label57";
			this.Label57.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label57.Text = "変更日";
			this.Label57.Top = 0.625F;
			this.Label57.Width = 0.4375F;
			// 
			// ChgDateTextBox
			// 
			this.ChgDateTextBox.CanGrow = false;
			this.ChgDateTextBox.DataField = "CHG_DATE";
			this.ChgDateTextBox.Height = 0.125F;
			this.ChgDateTextBox.Left = 2.75F;
			this.ChgDateTextBox.Name = "ChgDateTextBox";
			this.ChgDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.ChgDateTextBox.Text = "zzz6/z6/z6";
			this.ChgDateTextBox.Top = 0.625F;
			this.ChgDateTextBox.Width = 0.5625F;
			// 
			// Adrs1TextBox
			// 
			this.Adrs1TextBox.CanGrow = false;
			this.Adrs1TextBox.DataField = "ADRS1";
			this.Adrs1TextBox.Height = 0.1875F;
			this.Adrs1TextBox.Left = 0.3125F;
			this.Adrs1TextBox.Name = "Adrs1TextBox";
			this.Adrs1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Adrs1TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなに";
			this.Adrs1TextBox.Top = 0.75F;
			this.Adrs1TextBox.Width = 5.125F;
			// 
			// Label58
			// 
			this.Label58.Height = 0.125F;
			this.Label58.HyperLink = null;
			this.Label58.Left = 0.3125F;
			this.Label58.Name = "Label58";
			this.Label58.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label58.Text = "〒";
			this.Label58.Top = 0.9375F;
			this.Label58.Width = 0.125F;
			// 
			// Zip_1TextBox
			// 
			this.Zip_1TextBox.CanGrow = false;
			this.Zip_1TextBox.DataField = "ZIP_2";
			this.Zip_1TextBox.Height = 0.125F;
			this.Zip_1TextBox.Left = 0.4375F;
			this.Zip_1TextBox.Name = "Zip_1TextBox";
			this.Zip_1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Zip_1TextBox.Text = "0000000000";
			this.Zip_1TextBox.Top = 0.9375F;
			this.Zip_1TextBox.Width = 0.5F;
			// 
			// Label59
			// 
			this.Label59.Height = 0.125F;
			this.Label59.HyperLink = null;
			this.Label59.Left = 0.9375F;
			this.Label59.Name = "Label59";
			this.Label59.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label59.Text = "℡";
			this.Label59.Top = 0.9375F;
			this.Label59.Width = 0.125F;
			// 
			// Phone_1TextBox
			// 
			this.Phone_1TextBox.CanGrow = false;
			this.Phone_1TextBox.DataField = "PHONE_2";
			this.Phone_1TextBox.Height = 0.125F;
			this.Phone_1TextBox.Left = 1.0625F;
			this.Phone_1TextBox.Name = "Phone_1TextBox";
			this.Phone_1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Phone_1TextBox.Text = "000000000000000";
			this.Phone_1TextBox.Top = 0.9375F;
			this.Phone_1TextBox.Width = 0.75F;
			// 
			// Adrs1_1TextBox
			// 
			this.Adrs1_1TextBox.CanGrow = false;
			this.Adrs1_1TextBox.DataField = "ADRS1_2";
			this.Adrs1_1TextBox.Height = 0.1875F;
			this.Adrs1_1TextBox.Left = 0.3125F;
			this.Adrs1_1TextBox.Name = "Adrs1_1TextBox";
			this.Adrs1_1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Adrs1_1TextBox.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなに";
			this.Adrs1_1TextBox.Top = 1.0625F;
			this.Adrs1_1TextBox.Width = 5.0625F;
			// 
			// Adrs2_153
			// 
			this.Adrs2_153.CanGrow = false;
			this.Adrs2_153.DataField = "ADRS1_3";
			this.Adrs2_153.Height = 0.1875F;
			this.Adrs2_153.Left = 0.3125F;
			this.Adrs2_153.Name = "Adrs2_153";
			this.Adrs2_153.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Adrs2_153.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほあいうえおかきくけこさしすせそたちつてとなに";
			this.Adrs2_153.Top = 1.375F;
			this.Adrs2_153.Width = 5.125F;
			// 
			// Label62
			// 
			this.Label62.Height = 0.125F;
			this.Label62.HyperLink = null;
			this.Label62.Left = 0.813F;
			this.Label62.Name = "Label62";
			this.Label62.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label62.Text = "～";
			this.Label62.Top = 2.675F;
			this.Label62.Width = 0.125F;
			// 
			// Label63
			// 
			this.Label63.Height = 0.125F;
			this.Label63.HyperLink = null;
			this.Label63.Left = 0.8125F;
			this.Label63.Name = "Label63";
			this.Label63.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label63.Text = "～";
			this.Label63.Top = 2.5F;
			this.Label63.Width = 0.125F;
			// 
			// Label64
			// 
			this.Label64.Height = 0.125F;
			this.Label64.HyperLink = null;
			this.Label64.Left = 0.813F;
			this.Label64.Name = "Label64";
			this.Label64.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label64.Text = "～";
			this.Label64.Top = 2.363F;
			this.Label64.Width = 0.125F;
			// 
			// Label65
			// 
			this.Label65.Height = 0.125F;
			this.Label65.HyperLink = null;
			this.Label65.Left = 0.8125F;
			this.Label65.Name = "Label65";
			this.Label65.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label65.Text = "～";
			this.Label65.Top = 2.1875F;
			this.Label65.Width = 0.125F;
			// 
			// PreJobRetirDate5TextBox
			// 
			this.PreJobRetirDate5TextBox.CanGrow = false;
			this.PreJobRetirDate5TextBox.DataField = "PRE_JOB_RETIR_DATE_5";
			this.PreJobRetirDate5TextBox.Height = 0.188F;
			this.PreJobRetirDate5TextBox.Left = 0.9375F;
			this.PreJobRetirDate5TextBox.Name = "PreJobRetirDate5TextBox";
			this.PreJobRetirDate5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PreJobRetirDate5TextBox.Text = "zzz6/z6/z6";
			this.PreJobRetirDate5TextBox.Top = 2.625F;
			this.PreJobRetirDate5TextBox.Width = 0.563F;
			// 
			// PreJobRetirDate4TextBox
			// 
			this.PreJobRetirDate4TextBox.CanGrow = false;
			this.PreJobRetirDate4TextBox.DataField = "PRE_JOB_RETIR_DATE_4";
			this.PreJobRetirDate4TextBox.Height = 0.125F;
			this.PreJobRetirDate4TextBox.Left = 0.9375F;
			this.PreJobRetirDate4TextBox.Name = "PreJobRetirDate4TextBox";
			this.PreJobRetirDate4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PreJobRetirDate4TextBox.Text = "zzz6/z6/z6";
			this.PreJobRetirDate4TextBox.Top = 2.5F;
			this.PreJobRetirDate4TextBox.Width = 0.563F;
			// 
			// PreJobRetirDate3TextBox
			// 
			this.PreJobRetirDate3TextBox.CanGrow = false;
			this.PreJobRetirDate3TextBox.DataField = "PRE_JOB_RETIR_DATE_3";
			this.PreJobRetirDate3TextBox.Height = 0.1879999F;
			this.PreJobRetirDate3TextBox.Left = 0.9375F;
			this.PreJobRetirDate3TextBox.Name = "PreJobRetirDate3TextBox";
			this.PreJobRetirDate3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PreJobRetirDate3TextBox.Text = "zzz6/z6/z6";
			this.PreJobRetirDate3TextBox.Top = 2.3125F;
			this.PreJobRetirDate3TextBox.Width = 0.563F;
			// 
			// PreJobRetirDate2TextBox
			// 
			this.PreJobRetirDate2TextBox.CanGrow = false;
			this.PreJobRetirDate2TextBox.DataField = "PRE_JOB_RETIR_DATE_2";
			this.PreJobRetirDate2TextBox.Height = 0.125F;
			this.PreJobRetirDate2TextBox.Left = 0.9375F;
			this.PreJobRetirDate2TextBox.Name = "PreJobRetirDate2TextBox";
			this.PreJobRetirDate2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PreJobRetirDate2TextBox.Text = "zzz6/z6/z6";
			this.PreJobRetirDate2TextBox.Top = 2.1875F;
			this.PreJobRetirDate2TextBox.Width = 0.563F;
			// 
			// JobName5TextBox
			// 
			this.JobName5TextBox.CanGrow = false;
			this.JobName5TextBox.DataField = "JOB_NAME_5";
			this.JobName5TextBox.Height = 0.1875F;
			this.JobName5TextBox.Left = 3.4375F;
			this.JobName5TextBox.Name = "JobName5TextBox";
			this.JobName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobName5TextBox.Text = "あいうえおかきくけこ";
			this.JobName5TextBox.Top = 2.625F;
			this.JobName5TextBox.Width = 1F;
			// 
			// JobName4TextBox
			// 
			this.JobName4TextBox.CanGrow = false;
			this.JobName4TextBox.DataField = "JOB_NAME_4";
			this.JobName4TextBox.Height = 0.125F;
			this.JobName4TextBox.Left = 3.4375F;
			this.JobName4TextBox.Name = "JobName4TextBox";
			this.JobName4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobName4TextBox.Text = "あいうえおかきくけこ";
			this.JobName4TextBox.Top = 2.5F;
			this.JobName4TextBox.Width = 1F;
			// 
			// JobName3TextBox
			// 
			this.JobName3TextBox.CanGrow = false;
			this.JobName3TextBox.DataField = "JOB_NAME_3";
			this.JobName3TextBox.Height = 0.1875F;
			this.JobName3TextBox.Left = 3.4375F;
			this.JobName3TextBox.Name = "JobName3TextBox";
			this.JobName3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.JobName3TextBox.Text = "あいうえおかきくけこ";
			this.JobName3TextBox.Top = 2.3125F;
			this.JobName3TextBox.Width = 1F;
			// 
			// TextBox67
			// 
			this.TextBox67.CanGrow = false;
			this.TextBox67.DataField = "JOB_NAME_2";
			this.TextBox67.Height = 0.125F;
			this.TextBox67.Left = 3.4375F;
			this.TextBox67.Name = "TextBox67";
			this.TextBox67.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TextBox67.Text = "あいうえおかきくけこ";
			this.TextBox67.Top = 2.1875F;
			this.TextBox67.Width = 1F;
			// 
			// RetireReason4TextBox
			// 
			this.RetireReason4TextBox.CanGrow = false;
			this.RetireReason4TextBox.DataField = "RETIRE_REASON_4";
			this.RetireReason4TextBox.Height = 0.125F;
			this.RetireReason4TextBox.Left = 4.4375F;
			this.RetireReason4TextBox.Name = "RetireReason4TextBox";
			this.RetireReason4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RetireReason4TextBox.Text = "あいうえおかきくけこ";
			this.RetireReason4TextBox.Top = 2.5F;
			this.RetireReason4TextBox.Width = 1F;
			// 
			// AgeTextBox
			// 
			this.AgeTextBox.CanGrow = false;
			this.AgeTextBox.DataField = "AGE";
			this.AgeTextBox.Height = 0.1875F;
			this.AgeTextBox.Left = 4.025F;
			this.AgeTextBox.Name = "AgeTextBox";
			this.AgeTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AgeTextBox.Text = "z9";
			this.AgeTextBox.Top = 0F;
			this.AgeTextBox.Width = 0.125F;
			// 
			// StrServTextBox
			// 
			this.StrServTextBox.CanGrow = false;
			this.StrServTextBox.DataField = "STR_SERV_YM";
			this.StrServTextBox.Height = 0.125F;
			this.StrServTextBox.Left = 4.025F;
			this.StrServTextBox.Name = "StrServTextBox";
			this.StrServTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.StrServTextBox.Text = "z9";
			this.StrServTextBox.Top = 0.188F;
			this.StrServTextBox.Width = 0.125F;
			// 
			// Label74
			// 
			this.Label74.Height = 0.1875F;
			this.Label74.HyperLink = null;
			this.Label74.Left = 4.125F;
			this.Label74.Name = "Label74";
			this.Label74.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label74.Text = "歳";
			this.Label74.Top = 0F;
			this.Label74.Width = 0.125F;
			// 
			// Label75
			// 
			this.Label75.Height = 0.125F;
			this.Label75.HyperLink = null;
			this.Label75.Left = 4.125F;
			this.Label75.Name = "Label75";
			this.Label75.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label75.Text = "年";
			this.Label75.Top = 0.1875F;
			this.Label75.Width = 0.125F;
			// 
			// Line289
			// 
			this.Line289.Height = 0F;
			this.Line289.Left = 0.3194444F;
			this.Line289.LineWeight = 1F;
			this.Line289.Name = "Line289";
			this.Line289.Top = 4.352F;
			this.Line289.Width = 5.124084F;
			this.Line289.X1 = 0.3194444F;
			this.Line289.X2 = 5.443528F;
			this.Line289.Y1 = 4.352F;
			this.Line289.Y2 = 4.352F;
			// 
			// Label90
			// 
			this.Label90.Height = 0.125F;
			this.Label90.HyperLink = null;
			this.Label90.Left = 0.3125F;
			this.Label90.Name = "Label90";
			this.Label90.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label90.Text = "〒";
			this.Label90.Top = 2.8125F;
			this.Label90.Width = 0.125F;
			// 
			// Label91
			// 
			this.Label91.Height = 0.125F;
			this.Label91.HyperLink = null;
			this.Label91.Left = 0.9375F;
			this.Label91.Name = "Label91";
			this.Label91.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label91.Text = "℡";
			this.Label91.Top = 2.8125F;
			this.Label91.Width = 0.125F;
			// 
			// Phone1TextBox
			// 
			this.Phone1TextBox.CanGrow = false;
			this.Phone1TextBox.DataField = "PHONE1";
			this.Phone1TextBox.Height = 0.125F;
			this.Phone1TextBox.Left = 1.0625F;
			this.Phone1TextBox.Name = "Phone1TextBox";
			this.Phone1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Phone1TextBox.Text = "000000000000000";
			this.Phone1TextBox.Top = 2.8125F;
			this.Phone1TextBox.Width = 0.75F;
			// 
			// Label92
			// 
			this.Label92.Height = 0.125F;
			this.Label92.HyperLink = null;
			this.Label92.Left = 1.75F;
			this.Label92.Name = "Label92";
			this.Label92.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label92.Text = "氏名";
			this.Label92.Top = 2.8125F;
			this.Label92.Width = 0.4375F;
			// 
			// GrnNameTextBox
			// 
			this.GrnNameTextBox.CanGrow = false;
			this.GrnNameTextBox.DataField = "GRN_NAME_1";
			this.GrnNameTextBox.Height = 0.125F;
			this.GrnNameTextBox.Left = 2.0625F;
			this.GrnNameTextBox.Name = "GrnNameTextBox";
			this.GrnNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GrnNameTextBox.Text = "あいうえおかきくけこ";
			this.GrnNameTextBox.Top = 2.8125F;
			this.GrnNameTextBox.Width = 1F;
			// 
			// Label93
			// 
			this.Label93.Height = 0.125F;
			this.Label93.HyperLink = null;
			this.Label93.Left = 3F;
			this.Label93.Name = "Label93";
			this.Label93.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label93.Text = "関係";
			this.Label93.Top = 2.8125F;
			this.Label93.Width = 0.4375F;
			// 
			// RELAT1TextBox
			// 
			this.RELAT1TextBox.CanGrow = false;
			this.RELAT1TextBox.DataField = "RELAT_1";
			this.RELAT1TextBox.Height = 0.125F;
			this.RELAT1TextBox.Left = 3.375F;
			this.RELAT1TextBox.Name = "RELAT1TextBox";
			this.RELAT1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.RELAT1TextBox.Text = "あいうえおかきくけこ";
			this.RELAT1TextBox.Top = 2.8125F;
			this.RELAT1TextBox.Width = 1F;
			// 
			// Label94
			// 
			this.Label94.Height = 0.125F;
			this.Label94.HyperLink = null;
			this.Label94.Left = 0.3125F;
			this.Label94.Name = "Label94";
			this.Label94.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label94.Text = "〒";
			this.Label94.Top = 3.125F;
			this.Label94.Width = 0.125F;
			// 
			// Label95
			// 
			this.Label95.Height = 0.125F;
			this.Label95.HyperLink = null;
			this.Label95.Left = 0.9375F;
			this.Label95.Name = "Label95";
			this.Label95.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label95.Text = "℡";
			this.Label95.Top = 3.125F;
			this.Label95.Width = 0.125F;
			// 
			// Phone2TextBox
			// 
			this.Phone2TextBox.CanGrow = false;
			this.Phone2TextBox.DataField = "PHONE2";
			this.Phone2TextBox.Height = 0.125F;
			this.Phone2TextBox.Left = 1.0625F;
			this.Phone2TextBox.Name = "Phone2TextBox";
			this.Phone2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Phone2TextBox.Text = "000000000000000";
			this.Phone2TextBox.Top = 3.125F;
			this.Phone2TextBox.Width = 0.75F;
			// 
			// Label96
			// 
			this.Label96.Height = 0.125F;
			this.Label96.HyperLink = null;
			this.Label96.Left = 1.75F;
			this.Label96.Name = "Label96";
			this.Label96.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label96.Text = "氏名";
			this.Label96.Top = 3.125F;
			this.Label96.Width = 0.4375F;
			// 
			// GrnName2TextBox
			// 
			this.GrnName2TextBox.CanGrow = false;
			this.GrnName2TextBox.DataField = "GRN_NAME_2";
			this.GrnName2TextBox.Height = 0.125F;
			this.GrnName2TextBox.Left = 2.0625F;
			this.GrnName2TextBox.Name = "GrnName2TextBox";
			this.GrnName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GrnName2TextBox.Text = "あいうえおかきくけこ";
			this.GrnName2TextBox.Top = 3.125F;
			this.GrnName2TextBox.Width = 1F;
			// 
			// Label97
			// 
			this.Label97.Height = 0.125F;
			this.Label97.HyperLink = null;
			this.Label97.Left = 3F;
			this.Label97.Name = "Label97";
			this.Label97.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label97.Text = "関係";
			this.Label97.Top = 3.125F;
			this.Label97.Width = 0.4375F;
			// 
			// Relate2TextBox
			// 
			this.Relate2TextBox.CanGrow = false;
			this.Relate2TextBox.DataField = "RELAT_2";
			this.Relate2TextBox.Height = 0.125F;
			this.Relate2TextBox.Left = 3.375F;
			this.Relate2TextBox.Name = "Relate2TextBox";
			this.Relate2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Relate2TextBox.Text = "あいうえおかきくけこ";
			this.Relate2TextBox.Top = 3.125F;
			this.Relate2TextBox.Width = 1F;
			// 
			// Label98
			// 
			this.Label98.Height = 0.1875F;
			this.Label98.HyperLink = null;
			this.Label98.Left = 0.3125F;
			this.Label98.Name = "Label98";
			this.Label98.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label98.Text = "続柄";
			this.Label98.Top = 3.5625F;
			this.Label98.Width = 0.5F;
			// 
			// Label100
			// 
			this.Label100.Height = 0.1875F;
			this.Label100.HyperLink = null;
			this.Label100.Left = 2.1875F;
			this.Label100.Name = "Label100";
			this.Label100.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label100.Text = "性別";
			this.Label100.Top = 3.5625F;
			this.Label100.Width = 0.25F;
			// 
			// Label101
			// 
			this.Label101.Height = 0.1875F;
			this.Label101.HyperLink = null;
			this.Label101.Left = 2.4375F;
			this.Label101.Name = "Label101";
			this.Label101.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label101.Text = "生年月日";
			this.Label101.Top = 3.5625F;
			this.Label101.Width = 0.6875F;
			// 
			// Label102
			// 
			this.Label102.Height = 0.1875F;
			this.Label102.HyperLink = null;
			this.Label102.Left = 3.125F;
			this.Label102.Name = "Label102";
			this.Label102.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label102.Text = "同";
			this.Label102.Top = 3.5625F;
			this.Label102.Width = 0.25F;
			// 
			// Label103
			// 
			this.Label103.Height = 0.1875F;
			this.Label103.HyperLink = null;
			this.Label103.Left = 3.375F;
			this.Label103.Name = "Label103";
			this.Label103.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label103.Text = "職業";
			this.Label103.Top = 3.5625F;
			this.Label103.Width = 1F;
			// 
			// Label104
			// 
			this.Label104.Height = 0.188F;
			this.Label104.HyperLink = null;
			this.Label104.Left = 4.375F;
			this.Label104.Name = "Label104";
			this.Label104.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label104.Text = "税扶養";
			this.Label104.Top = 3.5625F;
			this.Label104.Width = 0.355F;
			// 
			// Label105
			// 
			this.Label105.Height = 0.1875F;
			this.Label105.HyperLink = null;
			this.Label105.Left = 4.6875F;
			this.Label105.Name = "Label105";
			this.Label105.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label105.Text = "健保";
			this.Label105.Top = 3.5625F;
			this.Label105.Width = 0.3125F;
			// 
			// FamRal1TextBox
			// 
			this.FamRal1TextBox.CanGrow = false;
			this.FamRal1TextBox.DataField = "FAM_RAL_1";
			this.FamRal1TextBox.Height = 0.125F;
			this.FamRal1TextBox.Left = 0.3125F;
			this.FamRal1TextBox.Name = "FamRal1TextBox";
			this.FamRal1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal1TextBox.Text = "あいうえお";
			this.FamRal1TextBox.Top = 3.75F;
			this.FamRal1TextBox.Width = 0.5F;
			// 
			// Line297
			// 
			this.Line297.Height = 1.552F;
			this.Line297.Left = 0.819F;
			this.Line297.LineWeight = 1F;
			this.Line297.Name = "Line297";
			this.Line297.Top = 3.573F;
			this.Line297.Width = 0F;
			this.Line297.X1 = 0.819F;
			this.Line297.X2 = 0.819F;
			this.Line297.Y1 = 3.573F;
			this.Line297.Y2 = 5.125F;
			// 
			// FamRal8TextBox
			// 
			this.FamRal8TextBox.CanGrow = false;
			this.FamRal8TextBox.DataField = "FAM_RAL_8";
			this.FamRal8TextBox.Height = 0.1875F;
			this.FamRal8TextBox.Left = 0.3125F;
			this.FamRal8TextBox.Name = "FamRal8TextBox";
			this.FamRal8TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal8TextBox.Text = "あいうえお";
			this.FamRal8TextBox.Top = 4.8125F;
			this.FamRal8TextBox.Width = 0.5625F;
			// 
			// FamRal7TextBox
			// 
			this.FamRal7TextBox.CanGrow = false;
			this.FamRal7TextBox.DataField = "FAM_RAL_7";
			this.FamRal7TextBox.Height = 0.125F;
			this.FamRal7TextBox.Left = 0.3125F;
			this.FamRal7TextBox.Name = "FamRal7TextBox";
			this.FamRal7TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal7TextBox.Text = "あいうえお";
			this.FamRal7TextBox.Top = 4.6875F;
			this.FamRal7TextBox.Width = 0.5F;
			// 
			// FamRal6TextBox
			// 
			this.FamRal6TextBox.CanGrow = false;
			this.FamRal6TextBox.DataField = "FAM_RAL_6";
			this.FamRal6TextBox.Height = 0.1875F;
			this.FamRal6TextBox.Left = 0.3125F;
			this.FamRal6TextBox.Name = "FamRal6TextBox";
			this.FamRal6TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal6TextBox.Text = "あいうえお";
			this.FamRal6TextBox.Top = 4.5F;
			this.FamRal6TextBox.Width = 0.5F;
			// 
			// FamRal5TextBox
			// 
			this.FamRal5TextBox.CanGrow = false;
			this.FamRal5TextBox.DataField = "FAM_RAL_5";
			this.FamRal5TextBox.Height = 0.125F;
			this.FamRal5TextBox.Left = 0.3125F;
			this.FamRal5TextBox.Name = "FamRal5TextBox";
			this.FamRal5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal5TextBox.Text = "あいうえお";
			this.FamRal5TextBox.Top = 4.375F;
			this.FamRal5TextBox.Width = 0.5F;
			// 
			// FamRal4TextBox
			// 
			this.FamRal4TextBox.CanGrow = false;
			this.FamRal4TextBox.DataField = "FAM_RAL_4";
			this.FamRal4TextBox.Height = 0.1875F;
			this.FamRal4TextBox.Left = 0.3125F;
			this.FamRal4TextBox.Name = "FamRal4TextBox";
			this.FamRal4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal4TextBox.Text = "あいうえお";
			this.FamRal4TextBox.Top = 4.1875F;
			this.FamRal4TextBox.Width = 0.5F;
			// 
			// FamRal3TextBox
			// 
			this.FamRal3TextBox.CanGrow = false;
			this.FamRal3TextBox.DataField = "FAM_RAL_3";
			this.FamRal3TextBox.Height = 0.125F;
			this.FamRal3TextBox.Left = 0.3125F;
			this.FamRal3TextBox.Name = "FamRal3TextBox";
			this.FamRal3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal3TextBox.Text = "あいうえお";
			this.FamRal3TextBox.Top = 4.0625F;
			this.FamRal3TextBox.Width = 0.5F;
			// 
			// FamRal2
			// 
			this.FamRal2.CanGrow = false;
			this.FamRal2.DataField = "FAM_RAL_2";
			this.FamRal2.Height = 0.1875F;
			this.FamRal2.Left = 0.3125F;
			this.FamRal2.Name = "FamRal2";
			this.FamRal2.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal2.Text = "あいうえお";
			this.FamRal2.Top = 3.875F;
			this.FamRal2.Width = 0.5F;
			// 
			// Line298
			// 
			this.Line298.Height = 1.552F;
			this.Line298.Left = 2.194F;
			this.Line298.LineWeight = 1F;
			this.Line298.Name = "Line298";
			this.Line298.Top = 3.573F;
			this.Line298.Width = 0F;
			this.Line298.X1 = 2.194F;
			this.Line298.X2 = 2.194F;
			this.Line298.Y1 = 3.573F;
			this.Line298.Y2 = 5.125F;
			// 
			// Line301
			// 
			this.Line301.Height = 1.552F;
			this.Line301.Left = 2.444F;
			this.Line301.LineWeight = 1F;
			this.Line301.Name = "Line301";
			this.Line301.Top = 3.573F;
			this.Line301.Width = 0F;
			this.Line301.X1 = 2.444F;
			this.Line301.X2 = 2.444F;
			this.Line301.Y1 = 3.573F;
			this.Line301.Y2 = 5.125F;
			// 
			// Line303
			// 
			this.Line303.Height = 0.1559999F;
			this.Line303.Left = 1.1315F;
			this.Line303.LineWeight = 1F;
			this.Line303.Name = "Line303";
			this.Line303.Top = 3.417F;
			this.Line303.Width = 0F;
			this.Line303.X1 = 1.1315F;
			this.Line303.X2 = 1.1315F;
			this.Line303.Y1 = 3.417F;
			this.Line303.Y2 = 3.573F;
			// 
			// Label108
			// 
			this.Label108.Height = 0.125F;
			this.Label108.HyperLink = null;
			this.Label108.Left = 1.125F;
			this.Label108.Name = "Label108";
			this.Label108.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label108.Text = "事由";
			this.Label108.Top = 3.4375F;
			this.Label108.Width = 0.25F;
			// 
			// Line304
			// 
			this.Line304.Height = 0.1559999F;
			this.Line304.Left = 1.3815F;
			this.Line304.LineWeight = 1F;
			this.Line304.Name = "Line304";
			this.Line304.Top = 3.417F;
			this.Line304.Width = 0F;
			this.Line304.X1 = 1.3815F;
			this.Line304.X2 = 1.3815F;
			this.Line304.Y1 = 3.417F;
			this.Line304.Y2 = 3.573F;
			// 
			// PositReasonTextBox
			// 
			this.PositReasonTextBox.CanGrow = false;
			this.PositReasonTextBox.DataField = "POSIT_REASON";
			this.PositReasonTextBox.Height = 0.125F;
			this.PositReasonTextBox.Left = 1.375F;
			this.PositReasonTextBox.Name = "PositReasonTextBox";
			this.PositReasonTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PositReasonTextBox.Text = "あいうえおかきくけこさしすせそたちつてと";
			this.PositReasonTextBox.Top = 3.4375F;
			this.PositReasonTextBox.Width = 2.0625F;
			// 
			// Label109
			// 
			this.Label109.Height = 0.125F;
			this.Label109.HyperLink = null;
			this.Label109.Left = 3.4375F;
			this.Label109.Name = "Label109";
			this.Label109.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label109.Text = "紹介者";
			this.Label109.Top = 3.4375F;
			this.Label109.Width = 0.375F;
			// 
			// Line305
			// 
			this.Line305.Height = 0.1559999F;
			this.Line305.Left = 3.444F;
			this.Line305.LineWeight = 1F;
			this.Line305.Name = "Line305";
			this.Line305.Top = 3.417F;
			this.Line305.Width = 0F;
			this.Line305.X1 = 3.444F;
			this.Line305.X2 = 3.444F;
			this.Line305.Y1 = 3.417F;
			this.Line305.Y2 = 3.573F;
			// 
			// Line306
			// 
			this.Line306.Height = 0.1559999F;
			this.Line306.Left = 3.819F;
			this.Line306.LineWeight = 1F;
			this.Line306.Name = "Line306";
			this.Line306.Top = 3.417F;
			this.Line306.Width = 0F;
			this.Line306.X1 = 3.819F;
			this.Line306.X2 = 3.819F;
			this.Line306.Y1 = 3.417F;
			this.Line306.Y2 = 3.573F;
			// 
			// IntroTextBox
			// 
			this.IntroTextBox.CanGrow = false;
			this.IntroTextBox.DataField = "INTRO";
			this.IntroTextBox.Height = 0.125F;
			this.IntroTextBox.Left = 3.8125F;
			this.IntroTextBox.Name = "IntroTextBox";
			this.IntroTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.IntroTextBox.Text = "あいうえおかきくけこさしすせそ";
			this.IntroTextBox.Top = 3.4375F;
			this.IntroTextBox.Width = 1.625F;
			// 
			// Label110
			// 
			this.Label110.Height = 0.125F;
			this.Label110.HyperLink = null;
			this.Label110.Left = 0.3125F;
			this.Label110.Name = "Label110";
			this.Label110.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label110.Text = "卒業年月";
			this.Label110.Top = 1.5625F;
			this.Label110.Width = 0.5F;
			// 
			// Label111
			// 
			this.Label111.Height = 0.125F;
			this.Label111.HyperLink = null;
			this.Label111.Left = 5.1875F;
			this.Label111.Name = "Label111";
			this.Label111.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label111.Text = "卒業";
			this.Label111.Top = 1.5625F;
			this.Label111.Width = 0.25F;
			// 
			// Label112
			// 
			this.Label112.Height = 0.125F;
			this.Label112.HyperLink = null;
			this.Label112.Left = 4.9375F;
			this.Label112.Name = "Label112";
			this.Label112.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label112.Text = "昼夜";
			this.Label112.Top = 1.5625F;
			this.Label112.Width = 0.25F;
			// 
			// Label113
			// 
			this.Label113.Height = 0.125F;
			this.Label113.HyperLink = null;
			this.Label113.Left = 3.8125F;
			this.Label113.Name = "Label113";
			this.Label113.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label113.Text = "分類";
			this.Label113.Top = 1.5625F;
			this.Label113.Width = 1.125F;
			// 
			// Label114
			// 
			this.Label114.Height = 0.125F;
			this.Label114.HyperLink = null;
			this.Label114.Left = 2.8125F;
			this.Label114.Name = "Label114";
			this.Label114.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label114.Text = "学科";
			this.Label114.Top = 1.5625F;
			this.Label114.Width = 1F;
			// 
			// Label115
			// 
			this.Label115.Height = 0.125F;
			this.Label115.HyperLink = null;
			this.Label115.Left = 1.8125F;
			this.Label115.Name = "Label115";
			this.Label115.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label115.Text = "学部";
			this.Label115.Top = 1.5625F;
			this.Label115.Width = 1F;
			// 
			// Label117
			// 
			this.Label117.Height = 0.125F;
			this.Label117.HyperLink = null;
			this.Label117.Left = 0.8125F;
			this.Label117.Name = "Label117";
			this.Label117.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label117.Text = "学校名";
			this.Label117.Top = 1.5625F;
			this.Label117.Width = 1F;
			// 
			// GraduYmTextBox
			// 
			this.GraduYmTextBox.CanGrow = false;
			this.GraduYmTextBox.DataField = "GRADU_YM";
			this.GraduYmTextBox.Height = 0.125F;
			this.GraduYmTextBox.Left = 0.3125F;
			this.GraduYmTextBox.Name = "GraduYmTextBox";
			this.GraduYmTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.GraduYmTextBox.Text = "zzz6年z6月";
			this.GraduYmTextBox.Top = 1.75F;
			this.GraduYmTextBox.Width = 0.5F;
			// 
			// Line307
			// 
			this.Line307.Height = 0.311F;
			this.Line307.Left = 0.8194444F;
			this.Line307.LineWeight = 1F;
			this.Line307.Name = "Line307";
			this.Line307.Top = 1.559F;
			this.Line307.Width = 0F;
			this.Line307.X1 = 0.8194444F;
			this.Line307.X2 = 0.8194444F;
			this.Line307.Y1 = 1.559F;
			this.Line307.Y2 = 1.87F;
			// 
			// Line308
			// 
			this.Line308.Height = 0.311F;
			this.Line308.Left = 5.194445F;
			this.Line308.LineWeight = 1F;
			this.Line308.Name = "Line308";
			this.Line308.Top = 1.559F;
			this.Line308.Width = 0F;
			this.Line308.X1 = 5.194445F;
			this.Line308.X2 = 5.194445F;
			this.Line308.Y1 = 1.559F;
			this.Line308.Y2 = 1.87F;
			// 
			// Line309
			// 
			this.Line309.Height = 0.311F;
			this.Line309.Left = 4.944445F;
			this.Line309.LineWeight = 1F;
			this.Line309.Name = "Line309";
			this.Line309.Top = 1.559F;
			this.Line309.Width = 0F;
			this.Line309.X1 = 4.944445F;
			this.Line309.X2 = 4.944445F;
			this.Line309.Y1 = 1.559F;
			this.Line309.Y2 = 1.87F;
			// 
			// SchoolNameTextBox
			// 
			this.SchoolNameTextBox.CanGrow = false;
			this.SchoolNameTextBox.DataField = "SCHOOL_NAME";
			this.SchoolNameTextBox.Height = 0.125F;
			this.SchoolNameTextBox.Left = 0.8125F;
			this.SchoolNameTextBox.Name = "SchoolNameTextBox";
			this.SchoolNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SchoolNameTextBox.Text = "あいうえおかきくけこ";
			this.SchoolNameTextBox.Top = 1.75F;
			this.SchoolNameTextBox.Width = 1F;
			// 
			// SubjNameTextBox
			// 
			this.SubjNameTextBox.CanGrow = false;
			this.SubjNameTextBox.DataField = "SUBJ_NAME";
			this.SubjNameTextBox.Height = 0.125F;
			this.SubjNameTextBox.Left = 2.8125F;
			this.SubjNameTextBox.Name = "SubjNameTextBox";
			this.SubjNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SubjNameTextBox.Text = "あいうえおかきくけこ";
			this.SubjNameTextBox.Top = 1.75F;
			this.SubjNameTextBox.Width = 1F;
			// 
			// Line310
			// 
			this.Line310.Height = 0.311F;
			this.Line310.Left = 3.819444F;
			this.Line310.LineWeight = 1F;
			this.Line310.Name = "Line310";
			this.Line310.Top = 1.559F;
			this.Line310.Width = 0F;
			this.Line310.X1 = 3.819444F;
			this.Line310.X2 = 3.819444F;
			this.Line310.Y1 = 1.559F;
			this.Line310.Y2 = 1.87F;
			// 
			// Line311
			// 
			this.Line311.Height = 0.311F;
			this.Line311.Left = 1.819444F;
			this.Line311.LineWeight = 1F;
			this.Line311.Name = "Line311";
			this.Line311.Top = 1.559F;
			this.Line311.Width = 0F;
			this.Line311.X1 = 1.819444F;
			this.Line311.X2 = 1.819444F;
			this.Line311.Y1 = 1.559F;
			this.Line311.Y2 = 1.87F;
			// 
			// FacultyNameTextBox
			// 
			this.FacultyNameTextBox.CanGrow = false;
			this.FacultyNameTextBox.DataField = "FACULTY_NAME";
			this.FacultyNameTextBox.Height = 0.125F;
			this.FacultyNameTextBox.Left = 1.8125F;
			this.FacultyNameTextBox.Name = "FacultyNameTextBox";
			this.FacultyNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FacultyNameTextBox.Text = "あいうえおかきくけこ";
			this.FacultyNameTextBox.Top = 1.75F;
			this.FacultyNameTextBox.Width = 1F;
			// 
			// Line312
			// 
			this.Line312.Height = 0.311F;
			this.Line312.Left = 2.819444F;
			this.Line312.LineWeight = 1F;
			this.Line312.Name = "Line312";
			this.Line312.Top = 1.559F;
			this.Line312.Width = 0F;
			this.Line312.X1 = 2.819444F;
			this.Line312.X2 = 2.819444F;
			this.Line312.Y1 = 1.559F;
			this.Line312.Y2 = 1.87F;
			// 
			// GraduTypeTextBox
			// 
			this.GraduTypeTextBox.CanGrow = false;
			this.GraduTypeTextBox.DataField = "GRADU_TYPE";
			this.GraduTypeTextBox.Height = 0.125F;
			this.GraduTypeTextBox.Left = 5.1875F;
			this.GraduTypeTextBox.Name = "GraduTypeTextBox";
			this.GraduTypeTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.GraduTypeTextBox.Text = "○○";
			this.GraduTypeTextBox.Top = 1.75F;
			this.GraduTypeTextBox.Width = 0.25F;
			// 
			// DayNightTypeTextBox
			// 
			this.DayNightTypeTextBox.CanGrow = false;
			this.DayNightTypeTextBox.DataField = "DAY_NIGHT_TYPE";
			this.DayNightTypeTextBox.Height = 0.125F;
			this.DayNightTypeTextBox.Left = 4.9375F;
			this.DayNightTypeTextBox.Name = "DayNightTypeTextBox";
			this.DayNightTypeTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DayNightTypeTextBox.Text = "○○";
			this.DayNightTypeTextBox.Top = 1.75F;
			this.DayNightTypeTextBox.Width = 0.25F;
			// 
			// Line316
			// 
			this.Line316.Height = 1.552F;
			this.Line316.Left = 5.0065F;
			this.Line316.LineWeight = 1F;
			this.Line316.Name = "Line316";
			this.Line316.Top = 3.573F;
			this.Line316.Width = 0F;
			this.Line316.X1 = 5.0065F;
			this.Line316.X2 = 5.0065F;
			this.Line316.Y1 = 3.573F;
			this.Line316.Y2 = 5.125F;
			// 
			// FmlyAlowType1TextBox
			// 
			this.FmlyAlowType1TextBox.CanGrow = false;
			this.FmlyAlowType1TextBox.DataField = "FMLY_ALOW_TYPE_1";
			this.FmlyAlowType1TextBox.Height = 0.125F;
			this.FmlyAlowType1TextBox.Left = 5F;
			this.FmlyAlowType1TextBox.Name = "FmlyAlowType1TextBox";
			this.FmlyAlowType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.FmlyAlowType1TextBox.Text = "あいう";
			this.FmlyAlowType1TextBox.Top = 3.75F;
			this.FmlyAlowType1TextBox.Width = 0.4375F;
			// 
			// Line317
			// 
			this.Line317.Height = 1.552F;
			this.Line317.Left = 4.694F;
			this.Line317.LineWeight = 1F;
			this.Line317.Name = "Line317";
			this.Line317.Top = 3.573F;
			this.Line317.Width = 0F;
			this.Line317.X1 = 4.694F;
			this.Line317.X2 = 4.694F;
			this.Line317.Y1 = 3.573F;
			this.Line317.Y2 = 5.125F;
			// 
			// HeltInsObjType1TextBox
			// 
			this.HeltInsObjType1TextBox.CanGrow = false;
			this.HeltInsObjType1TextBox.DataField = "HELT_INS_OBJ_TYPE_1";
			this.HeltInsObjType1TextBox.Height = 0.125F;
			this.HeltInsObjType1TextBox.Left = 4.6875F;
			this.HeltInsObjType1TextBox.Name = "HeltInsObjType1TextBox";
			this.HeltInsObjType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType1TextBox.Text = "あいう";
			this.HeltInsObjType1TextBox.Top = 3.75F;
			this.HeltInsObjType1TextBox.Width = 0.3125F;
			// 
			// Line318
			// 
			this.Line318.Height = 1.558945F;
			this.Line318.Left = 4.694445F;
			this.Line318.LineWeight = 1F;
			this.Line318.Name = "Line318";
			this.Line318.Top = 3.569444F;
			this.Line318.Width = 0F;
			this.Line318.X1 = 4.694445F;
			this.Line318.X2 = 4.694445F;
			this.Line318.Y1 = 3.569444F;
			this.Line318.Y2 = 5.128389F;
			// 
			// DpndType1TextBox
			// 
			this.DpndType1TextBox.CanGrow = false;
			this.DpndType1TextBox.DataField = "DPND_TYPE_1";
			this.DpndType1TextBox.Height = 0.125F;
			this.DpndType1TextBox.Left = 4.375F;
			this.DpndType1TextBox.Name = "DpndType1TextBox";
			this.DpndType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType1TextBox.Text = "あいう";
			this.DpndType1TextBox.Top = 3.75F;
			this.DpndType1TextBox.Width = 0.3125F;
			// 
			// SexType1TextBox
			// 
			this.SexType1TextBox.CanGrow = false;
			this.SexType1TextBox.DataField = "SEX_TYPE_1";
			this.SexType1TextBox.Height = 0.125F;
			this.SexType1TextBox.Left = 2.1875F;
			this.SexType1TextBox.Name = "SexType1TextBox";
			this.SexType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType1TextBox.Text = "○";
			this.SexType1TextBox.Top = 3.75F;
			this.SexType1TextBox.Width = 0.25F;
			// 
			// Label120
			// 
			this.Label120.Height = 0.1875F;
			this.Label120.HyperLink = null;
			this.Label120.Left = 0.3125F;
			this.Label120.Name = "Label120";
			this.Label120.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label120.Text = "労働保険適用事業所";
			this.Label120.Top = 5.125F;
			this.Label120.Width = 1F;
			// 
			// Employ1TextBox
			// 
			this.Employ1TextBox.CanGrow = false;
			this.Employ1TextBox.DataField = "EMPLOY_1";
			this.Employ1TextBox.Height = 0.125F;
			this.Employ1TextBox.Left = 3.375F;
			this.Employ1TextBox.Name = "Employ1TextBox";
			this.Employ1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ1TextBox.Text = "あいうえおかきくけこ";
			this.Employ1TextBox.Top = 3.75F;
			this.Employ1TextBox.Width = 1F;
			// 
			// EmployInsOfcNameTextBox
			// 
			this.EmployInsOfcNameTextBox.CanGrow = false;
			this.EmployInsOfcNameTextBox.DataField = "EMPLOY_INS_OFC_NAME";
			this.EmployInsOfcNameTextBox.Height = 0.125F;
			this.EmployInsOfcNameTextBox.Left = 0.3125F;
			this.EmployInsOfcNameTextBox.Name = "EmployInsOfcNameTextBox";
			this.EmployInsOfcNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmployInsOfcNameTextBox.Text = "あいうえおかきくけこ";
			this.EmployInsOfcNameTextBox.Top = 5.3125F;
			this.EmployInsOfcNameTextBox.Width = 1F;
			// 
			// Line319
			// 
			this.Line319.Height = 1.244F;
			this.Line319.Left = 1.319F;
			this.Line319.LineWeight = 1F;
			this.Line319.Name = "Line319";
			this.Line319.Top = 5.131F;
			this.Line319.Width = 0F;
			this.Line319.X1 = 1.319F;
			this.Line319.X2 = 1.319F;
			this.Line319.Y1 = 5.131F;
			this.Line319.Y2 = 6.375F;
			// 
			// Label121
			// 
			this.Label121.Height = 0.1875F;
			this.Label121.HyperLink = null;
			this.Label121.Left = 0.3125F;
			this.Label121.Name = "Label121";
			this.Label121.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label121.Text = "社会保険適用事業所";
			this.Label121.Top = 5.4375F;
			this.Label121.Width = 1F;
			// 
			// SocInsOfcNameTextBox178
			// 
			this.SocInsOfcNameTextBox178.CanGrow = false;
			this.SocInsOfcNameTextBox178.DataField = "SOC_INS_OFC_NAME";
			this.SocInsOfcNameTextBox178.Height = 0.125F;
			this.SocInsOfcNameTextBox178.Left = 0.3125F;
			this.SocInsOfcNameTextBox178.Name = "SocInsOfcNameTextBox178";
			this.SocInsOfcNameTextBox178.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.SocInsOfcNameTextBox178.Text = "あいうえおかきくけこ";
			this.SocInsOfcNameTextBox178.Top = 5.625F;
			this.SocInsOfcNameTextBox178.Width = 1F;
			// 
			// Label122
			// 
			this.Label122.Height = 0.1875F;
			this.Label122.HyperLink = null;
			this.Label122.Left = 1.3125F;
			this.Label122.Name = "Label122";
			this.Label122.Style = "font-size: 6.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label122.Text = "雇用保険被保険者番号";
			this.Label122.Top = 5.125F;
			this.Label122.Width = 1F;
			// 
			// Line320
			// 
			this.Line320.Height = 1.244F;
			this.Line320.Left = 2.319F;
			this.Line320.LineWeight = 1F;
			this.Line320.Name = "Line320";
			this.Line320.Top = 5.131F;
			this.Line320.Width = 0F;
			this.Line320.X1 = 2.319F;
			this.Line320.X2 = 2.319F;
			this.Line320.Y1 = 5.131F;
			this.Line320.Y2 = 6.375F;
			// 
			// EmployInsMarkNoTextBox
			// 
			this.EmployInsMarkNoTextBox.CanGrow = false;
			this.EmployInsMarkNoTextBox.DataField = "EMPLOY_INS_MARK_NO";
			this.EmployInsMarkNoTextBox.Height = 0.125F;
			this.EmployInsMarkNoTextBox.Left = 1.375F;
			this.EmployInsMarkNoTextBox.Name = "EmployInsMarkNoTextBox";
			this.EmployInsMarkNoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmployInsMarkNoTextBox.Text = "00000000000000";
			this.EmployInsMarkNoTextBox.Top = 5.3125F;
			this.EmployInsMarkNoTextBox.Width = 1F;
			// 
			// Label123
			// 
			this.Label123.Height = 0.1875F;
			this.Label123.HyperLink = null;
			this.Label123.Left = 1.3125F;
			this.Label123.Name = "Label123";
			this.Label123.Style = "font-size: 6.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label123.Text = "健康保険被保険者番号";
			this.Label123.Top = 5.4375F;
			this.Label123.Width = 1F;
			// 
			// Label124
			// 
			this.Label124.Height = 0.1875F;
			this.Label124.HyperLink = null;
			this.Label124.Left = 1.3125F;
			this.Label124.Name = "Label124";
			this.Label124.Style = "font-size: 6.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label124.Text = "厚年被保険者整理番号";
			this.Label124.Top = 5.75F;
			this.Label124.Width = 1F;
			// 
			// Label125
			// 
			this.Label125.Height = 0.1875F;
			this.Label125.HyperLink = null;
			this.Label125.Left = 1.3125F;
			this.Label125.Name = "Label125";
			this.Label125.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label125.Text = "厚年基金加入員番号";
			this.Label125.Top = 6.0625F;
			this.Label125.Width = 1F;
			// 
			// PensFndNoTextBox
			// 
			this.PensFndNoTextBox.CanGrow = false;
			this.PensFndNoTextBox.DataField = "PENS_FND_NO";
			this.PensFndNoTextBox.Height = 0.125F;
			this.PensFndNoTextBox.Left = 1.375F;
			this.PensFndNoTextBox.Name = "PensFndNoTextBox";
			this.PensFndNoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensFndNoTextBox.Text = "00000000000000";
			this.PensFndNoTextBox.Top = 6.25F;
			this.PensFndNoTextBox.Width = 1F;
			// 
			// PensNoTextBox
			// 
			this.PensNoTextBox.CanGrow = false;
			this.PensNoTextBox.DataField = "PENS_REFE_NUM";
			this.PensNoTextBox.Height = 0.125F;
			this.PensNoTextBox.Left = 1.375F;
			this.PensNoTextBox.Name = "PensNoTextBox";
			this.PensNoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensNoTextBox.Text = "00000000000000";
			this.PensNoTextBox.Top = 5.9375F;
			this.PensNoTextBox.Width = 1F;
			// 
			// HeltInsNoTextBox
			// 
			this.HeltInsNoTextBox.CanGrow = false;
			this.HeltInsNoTextBox.DataField = "HELT_INS_NO";
			this.HeltInsNoTextBox.Height = 0.125F;
			this.HeltInsNoTextBox.Left = 1.375F;
			this.HeltInsNoTextBox.Name = "HeltInsNoTextBox";
			this.HeltInsNoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.HeltInsNoTextBox.Text = "00000000000000";
			this.HeltInsNoTextBox.Top = 5.625F;
			this.HeltInsNoTextBox.Width = 1F;
			// 
			// Label126
			// 
			this.Label126.Height = 0.1875F;
			this.Label126.HyperLink = null;
			this.Label126.Left = 2.3125F;
			this.Label126.Name = "Label126";
			this.Label126.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label126.Text = "労働基準監督署";
			this.Label126.Top = 5.125F;
			this.Label126.Width = 1F;
			// 
			// WorkAccInsOfcNameTextBox
			// 
			this.WorkAccInsOfcNameTextBox.CanGrow = false;
			this.WorkAccInsOfcNameTextBox.DataField = "WORK_ACC_INS_OFC_NAME";
			this.WorkAccInsOfcNameTextBox.Height = 0.125F;
			this.WorkAccInsOfcNameTextBox.Left = 2.3125F;
			this.WorkAccInsOfcNameTextBox.Name = "WorkAccInsOfcNameTextBox";
			this.WorkAccInsOfcNameTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.WorkAccInsOfcNameTextBox.Text = "あいうえおかきくけこ";
			this.WorkAccInsOfcNameTextBox.Top = 5.3125F;
			this.WorkAccInsOfcNameTextBox.Width = 1F;
			// 
			// Line321
			// 
			this.Line321.Height = 1.244F;
			this.Line321.Left = 3.85F;
			this.Line321.LineWeight = 1F;
			this.Line321.Name = "Line321";
			this.Line321.Top = 5.131F;
			this.Line321.Width = 0F;
			this.Line321.X1 = 3.85F;
			this.Line321.X2 = 3.85F;
			this.Line321.Y1 = 5.131F;
			this.Line321.Y2 = 6.375F;
			// 
			// Line322
			// 
			this.Line322.Height = 0.9310002F;
			this.Line322.Left = 2.819F;
			this.Line322.LineWeight = 1F;
			this.Line322.Name = "Line322";
			this.Line322.Top = 5.444F;
			this.Line322.Width = 0F;
			this.Line322.X1 = 2.819F;
			this.Line322.X2 = 2.819F;
			this.Line322.Y1 = 5.444F;
			this.Line322.Y2 = 6.375F;
			// 
			// LiveTgtType1TextBox
			// 
			this.LiveTgtType1TextBox.CanGrow = false;
			this.LiveTgtType1TextBox.DataField = "LIVE_TGT_TYPE_1";
			this.LiveTgtType1TextBox.Height = 0.125F;
			this.LiveTgtType1TextBox.Left = 3.125F;
			this.LiveTgtType1TextBox.Name = "LiveTgtType1TextBox";
			this.LiveTgtType1TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType1TextBox.Text = "○○";
			this.LiveTgtType1TextBox.Top = 3.75F;
			this.LiveTgtType1TextBox.Width = 0.25F;
			// 
			// BirthDay1TextBox
			// 
			this.BirthDay1TextBox.CanGrow = false;
			this.BirthDay1TextBox.DataField = "BIRTH_DAY_1";
			this.BirthDay1TextBox.Height = 0.125F;
			this.BirthDay1TextBox.Left = 2.4375F;
			this.BirthDay1TextBox.Name = "BirthDay1TextBox";
			this.BirthDay1TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay1TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay1TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay1TextBox.Top = 3.75F;
			this.BirthDay1TextBox.Width = 0.6875F;
			// 
			// Label127
			// 
			this.Label127.Height = 0.1875F;
			this.Label127.HyperLink = null;
			this.Label127.Left = 2.3125F;
			this.Label127.Name = "Label127";
			this.Label127.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label127.Text = "標準報酬";
			this.Label127.Top = 5.4375F;
			this.Label127.Width = 0.5F;
			// 
			// Label128
			// 
			this.Label128.Height = 0.1875F;
			this.Label128.HyperLink = null;
			this.Label128.Left = 2.8125F;
			this.Label128.Name = "Label128";
			this.Label128.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label128.Text = "改定年月";
			this.Label128.Top = 5.4375F;
			this.Label128.Width = 0.5F;
			// 
			// Line323
			// 
			this.Line323.Height = 1.244F;
			this.Line323.Left = 3.296F;
			this.Line323.LineWeight = 1F;
			this.Line323.Name = "Line323";
			this.Line323.Top = 5.131F;
			this.Line323.Width = 0F;
			this.Line323.X1 = 3.296F;
			this.Line323.X2 = 3.296F;
			this.Line323.Y1 = 5.131F;
			this.Line323.Y2 = 6.375F;
			// 
			// PensFndStandCompsAmtTextBox
			// 
			this.PensFndStandCompsAmtTextBox.CanGrow = false;
			this.PensFndStandCompsAmtTextBox.DataField = "PENS_FND_STAND_COMPS_AMT";
			this.PensFndStandCompsAmtTextBox.Height = 0.125F;
			this.PensFndStandCompsAmtTextBox.Left = 2.313F;
			this.PensFndStandCompsAmtTextBox.Name = "PensFndStandCompsAmtTextBox";
			this.PensFndStandCompsAmtTextBox.OutputFormat = "#,##0";
			this.PensFndStandCompsAmtTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PensFndStandCompsAmtTextBox.Text = "zzz,zz6";
			this.PensFndStandCompsAmtTextBox.Top = 6.25F;
			this.PensFndStandCompsAmtTextBox.Width = 0.5F;
			// 
			// PensStandCompsAmtTextBox
			// 
			this.PensStandCompsAmtTextBox.CanGrow = false;
			this.PensStandCompsAmtTextBox.DataField = "PENS_STAND_COMPS_AMT";
			this.PensStandCompsAmtTextBox.Height = 0.125F;
			this.PensStandCompsAmtTextBox.Left = 2.313F;
			this.PensStandCompsAmtTextBox.Name = "PensStandCompsAmtTextBox";
			this.PensStandCompsAmtTextBox.OutputFormat = "#,##0";
			this.PensStandCompsAmtTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.PensStandCompsAmtTextBox.Text = "zzz,zz6";
			this.PensStandCompsAmtTextBox.Top = 5.938F;
			this.PensStandCompsAmtTextBox.Width = 0.5F;
			// 
			// HeltInsStandMonAmtTextBox
			// 
			this.HeltInsStandMonAmtTextBox.CanGrow = false;
			this.HeltInsStandMonAmtTextBox.DataField = "HELT_INS_STAND_MON_AMT";
			this.HeltInsStandMonAmtTextBox.Height = 0.125F;
			this.HeltInsStandMonAmtTextBox.Left = 2.313F;
			this.HeltInsStandMonAmtTextBox.Name = "HeltInsStandMonAmtTextBox";
			this.HeltInsStandMonAmtTextBox.OutputFormat = "#,##0";
			this.HeltInsStandMonAmtTextBox.Style = "font-size: 7pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HeltInsStandMonAmtTextBox.Text = "z,zzz,zz6";
			this.HeltInsStandMonAmtTextBox.Top = 5.625F;
			this.HeltInsStandMonAmtTextBox.Width = 0.5F;
			// 
			// Label129
			// 
			this.Label129.Height = 0.1875F;
			this.Label129.HyperLink = null;
			this.Label129.Left = 2.3125F;
			this.Label129.Name = "Label129";
			this.Label129.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label129.Text = "標準報酬";
			this.Label129.Top = 6.0625F;
			this.Label129.Width = 0.5F;
			// 
			// Label130
			// 
			this.Label130.Height = 0.1875F;
			this.Label130.HyperLink = null;
			this.Label130.Left = 2.3125F;
			this.Label130.Name = "Label130";
			this.Label130.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label130.Text = "標準報酬";
			this.Label130.Top = 5.75F;
			this.Label130.Width = 0.5F;
			// 
			// Label131
			// 
			this.Label131.Height = 0.1875F;
			this.Label131.HyperLink = null;
			this.Label131.Left = 2.8125F;
			this.Label131.Name = "Label131";
			this.Label131.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label131.Text = "改定年月";
			this.Label131.Top = 6.0625F;
			this.Label131.Width = 0.5F;
			// 
			// Label132
			// 
			this.Label132.Height = 0.1875F;
			this.Label132.HyperLink = null;
			this.Label132.Left = 2.8125F;
			this.Label132.Name = "Label132";
			this.Label132.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label132.Text = "改定年月";
			this.Label132.Top = 5.75F;
			this.Label132.Width = 0.5F;
			// 
			// PensFndRevYmTextBox
			// 
			this.PensFndRevYmTextBox.CanGrow = false;
			this.PensFndRevYmTextBox.DataField = "PENS_FND_REV_YM";
			this.PensFndRevYmTextBox.Height = 0.125F;
			this.PensFndRevYmTextBox.Left = 2.8125F;
			this.PensFndRevYmTextBox.Name = "PensFndRevYmTextBox";
			this.PensFndRevYmTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.PensFndRevYmTextBox.Text = "zzz6/z6";
			this.PensFndRevYmTextBox.Top = 6.25F;
			this.PensFndRevYmTextBox.Width = 0.5F;
			// 
			// PensRevYmTextBox
			// 
			this.PensRevYmTextBox.CanGrow = false;
			this.PensRevYmTextBox.DataField = "PENS_REV_YM";
			this.PensRevYmTextBox.Height = 0.125F;
			this.PensRevYmTextBox.Left = 2.8125F;
			this.PensRevYmTextBox.Name = "PensRevYmTextBox";
			this.PensRevYmTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.PensRevYmTextBox.Text = "zzz6/z6";
			this.PensRevYmTextBox.Top = 5.9375F;
			this.PensRevYmTextBox.Width = 0.5F;
			// 
			// HeltInsRevYmTextBox
			// 
			this.HeltInsRevYmTextBox.CanGrow = false;
			this.HeltInsRevYmTextBox.DataField = "HELT_INS_REV_YM";
			this.HeltInsRevYmTextBox.Height = 0.125F;
			this.HeltInsRevYmTextBox.Left = 2.813F;
			this.HeltInsRevYmTextBox.Name = "HeltInsRevYmTextBox";
			this.HeltInsRevYmTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsRevYmTextBox.Text = "zzz6/z6";
			this.HeltInsRevYmTextBox.Top = 5.625F;
			this.HeltInsRevYmTextBox.Width = 0.5F;
			// 
			// Label133
			// 
			this.Label133.Height = 0.1875F;
			this.Label133.HyperLink = null;
			this.Label133.Left = 3.3125F;
			this.Label133.Name = "Label133";
			this.Label133.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label133.Text = "取得日";
			this.Label133.Top = 5.125F;
			this.Label133.Width = 0.5625F;
			// 
			// Label135
			// 
			this.Label135.Height = 0.1875F;
			this.Label135.HyperLink = null;
			this.Label135.Left = 3.3125F;
			this.Label135.Name = "Label135";
			this.Label135.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label135.Text = "取得日";
			this.Label135.Top = 6.0625F;
			this.Label135.Width = 0.5625F;
			// 
			// Label136
			// 
			this.Label136.Height = 0.1875F;
			this.Label136.HyperLink = null;
			this.Label136.Left = 3.3125F;
			this.Label136.Name = "Label136";
			this.Label136.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label136.Text = "取得日";
			this.Label136.Top = 5.4375F;
			this.Label136.Width = 0.5625F;
			// 
			// Label137
			// 
			this.Label137.Height = 0.1875F;
			this.Label137.HyperLink = null;
			this.Label137.Left = 3.3125F;
			this.Label137.Name = "Label137";
			this.Label137.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label137.Text = "取得日";
			this.Label137.Top = 5.75F;
			this.Label137.Width = 0.5625F;
			// 
			// Label139
			// 
			this.Label139.Height = 0.1875F;
			this.Label139.HyperLink = null;
			this.Label139.Left = 3.875F;
			this.Label139.Name = "Label139";
			this.Label139.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label139.Text = "喪失日";
			this.Label139.Top = 6.0625F;
			this.Label139.Width = 0.5625F;
			// 
			// Label140
			// 
			this.Label140.Height = 0.1875F;
			this.Label140.HyperLink = null;
			this.Label140.Left = 3.875F;
			this.Label140.Name = "Label140";
			this.Label140.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label140.Text = "喪失日";
			this.Label140.Top = 5.125F;
			this.Label140.Width = 0.5625F;
			// 
			// Label141
			// 
			this.Label141.Height = 0.1875F;
			this.Label141.HyperLink = null;
			this.Label141.Left = 3.875F;
			this.Label141.Name = "Label141";
			this.Label141.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label141.Text = "喪失日";
			this.Label141.Top = 5.75F;
			this.Label141.Width = 0.5625F;
			// 
			// Label142
			// 
			this.Label142.Height = 0.1875F;
			this.Label142.HyperLink = null;
			this.Label142.Left = 3.875F;
			this.Label142.Name = "Label142";
			this.Label142.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label142.Text = "喪失日";
			this.Label142.Top = 5.4375F;
			this.Label142.Width = 0.5625F;
			// 
			// Line324
			// 
			this.Line324.Height = 1.244F;
			this.Line324.Left = 4.444F;
			this.Line324.LineWeight = 1F;
			this.Line324.Name = "Line324";
			this.Line324.Top = 5.131F;
			this.Line324.Width = 0F;
			this.Line324.X1 = 4.444F;
			this.Line324.X2 = 4.444F;
			this.Line324.Y1 = 5.131F;
			this.Line324.Y2 = 6.375F;
			// 
			// PensBasePensNoTextBox
			// 
			this.PensBasePensNoTextBox.CanGrow = false;
			this.PensBasePensNoTextBox.DataField = "PENS_BASE_PENS_NO";
			this.PensBasePensNoTextBox.Height = 0.125F;
			this.PensBasePensNoTextBox.Left = 4.625F;
			this.PensBasePensNoTextBox.Name = "PensBasePensNoTextBox";
			this.PensBasePensNoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensBasePensNoTextBox.Text = "0000";
			this.PensBasePensNoTextBox.Top = 5.9375F;
			this.PensBasePensNoTextBox.Width = 0.25F;
			// 
			// Label145
			// 
			this.Label145.Height = 0.125F;
			this.Label145.HyperLink = null;
			this.Label145.Left = 4.875F;
			this.Label145.Name = "Label145";
			this.Label145.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label145.Text = "-";
			this.Label145.Top = 5.9375F;
			this.Label145.Width = 0.125F;
			// 
			// PensBasePensNoSbnoTextBox
			// 
			this.PensBasePensNoSbnoTextBox.CanGrow = false;
			this.PensBasePensNoSbnoTextBox.DataField = "PENS_BASE_PENS_NO_SBNO";
			this.PensBasePensNoSbnoTextBox.Height = 0.125F;
			this.PensBasePensNoSbnoTextBox.Left = 5F;
			this.PensBasePensNoSbnoTextBox.Name = "PensBasePensNoSbnoTextBox";
			this.PensBasePensNoSbnoTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensBasePensNoSbnoTextBox.Text = "000000";
			this.PensBasePensNoSbnoTextBox.Top = 5.9375F;
			this.PensBasePensNoSbnoTextBox.Width = 0.3125F;
			// 
			// CareInsTextBox
			// 
			this.CareInsTextBox.CanGrow = false;
			this.CareInsTextBox.DataField = "CARE_INS";
			this.CareInsTextBox.Height = 0.125F;
			this.CareInsTextBox.Left = 4.4375F;
			this.CareInsTextBox.Name = "CareInsTextBox";
			this.CareInsTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.CareInsTextBox.Text = "あいうえおかきくけこ";
			this.CareInsTextBox.Top = 5.625F;
			this.CareInsTextBox.Width = 1F;
			// 
			// LastName8TextBox
			// 
			this.LastName8TextBox.CanGrow = false;
			this.LastName8TextBox.DataField = "LAST_NAME_8";
			this.LastName8TextBox.Height = 0.1875F;
			this.LastName8TextBox.Left = 0.8125F;
			this.LastName8TextBox.Name = "LastName8TextBox";
			this.LastName8TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName8TextBox.Text = "あいうえおかき";
			this.LastName8TextBox.Top = 4.8125F;
			this.LastName8TextBox.Width = 1.375F;
			// 
			// LastName7TextBox
			// 
			this.LastName7TextBox.CanGrow = false;
			this.LastName7TextBox.DataField = "LAST_NAME_7";
			this.LastName7TextBox.Height = 0.125F;
			this.LastName7TextBox.Left = 0.8125F;
			this.LastName7TextBox.Name = "LastName7TextBox";
			this.LastName7TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName7TextBox.Text = "あいうえおかき";
			this.LastName7TextBox.Top = 4.6875F;
			this.LastName7TextBox.Width = 1.375F;
			// 
			// LastName6TextBox
			// 
			this.LastName6TextBox.CanGrow = false;
			this.LastName6TextBox.DataField = "LAST_NAME_6";
			this.LastName6TextBox.Height = 0.1875F;
			this.LastName6TextBox.Left = 0.8125F;
			this.LastName6TextBox.Name = "LastName6TextBox";
			this.LastName6TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName6TextBox.Text = "あいうえおかき";
			this.LastName6TextBox.Top = 4.5F;
			this.LastName6TextBox.Width = 1.375F;
			// 
			// LastName5TextBox
			// 
			this.LastName5TextBox.CanGrow = false;
			this.LastName5TextBox.DataField = "LAST_NAME_5";
			this.LastName5TextBox.Height = 0.125F;
			this.LastName5TextBox.Left = 0.8125F;
			this.LastName5TextBox.Name = "LastName5TextBox";
			this.LastName5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName5TextBox.Text = "あいうえおかき";
			this.LastName5TextBox.Top = 4.375F;
			this.LastName5TextBox.Width = 1.375F;
			// 
			// LastName2TextBox
			// 
			this.LastName2TextBox.CanGrow = false;
			this.LastName2TextBox.DataField = "LAST_NAME_2";
			this.LastName2TextBox.Height = 0.1875F;
			this.LastName2TextBox.Left = 0.8125F;
			this.LastName2TextBox.Name = "LastName2TextBox";
			this.LastName2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName2TextBox.Text = "あいうえおかき";
			this.LastName2TextBox.Top = 3.875F;
			this.LastName2TextBox.Width = 1.375F;
			// 
			// SexType8TextBox
			// 
			this.SexType8TextBox.CanGrow = false;
			this.SexType8TextBox.DataField = "SEX_TYPE_8";
			this.SexType8TextBox.Height = 0.1875F;
			this.SexType8TextBox.Left = 2.1875F;
			this.SexType8TextBox.Name = "SexType8TextBox";
			this.SexType8TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType8TextBox.Text = "○";
			this.SexType8TextBox.Top = 4.8125F;
			this.SexType8TextBox.Width = 0.25F;
			// 
			// SexType7TextBox
			// 
			this.SexType7TextBox.CanGrow = false;
			this.SexType7TextBox.DataField = "SEX_TYPE_7";
			this.SexType7TextBox.Height = 0.125F;
			this.SexType7TextBox.Left = 2.1875F;
			this.SexType7TextBox.Name = "SexType7TextBox";
			this.SexType7TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType7TextBox.Text = "○";
			this.SexType7TextBox.Top = 4.6875F;
			this.SexType7TextBox.Width = 0.25F;
			// 
			// SexType6TextBox
			// 
			this.SexType6TextBox.CanGrow = false;
			this.SexType6TextBox.DataField = "SEX_TYPE_6";
			this.SexType6TextBox.Height = 0.1875F;
			this.SexType6TextBox.Left = 2.1875F;
			this.SexType6TextBox.Name = "SexType6TextBox";
			this.SexType6TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType6TextBox.Text = "○";
			this.SexType6TextBox.Top = 4.5F;
			this.SexType6TextBox.Width = 0.25F;
			// 
			// SexType5TextBox
			// 
			this.SexType5TextBox.CanGrow = false;
			this.SexType5TextBox.DataField = "SEX_TYPE_5";
			this.SexType5TextBox.Height = 0.125F;
			this.SexType5TextBox.Left = 2.1875F;
			this.SexType5TextBox.Name = "SexType5TextBox";
			this.SexType5TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType5TextBox.Text = "○";
			this.SexType5TextBox.Top = 4.375F;
			this.SexType5TextBox.Width = 0.25F;
			// 
			// SexType4TextBox
			// 
			this.SexType4TextBox.CanGrow = false;
			this.SexType4TextBox.DataField = "SEX_TYPE_4";
			this.SexType4TextBox.Height = 0.1875F;
			this.SexType4TextBox.Left = 2.1875F;
			this.SexType4TextBox.Name = "SexType4TextBox";
			this.SexType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType4TextBox.Text = "○";
			this.SexType4TextBox.Top = 4.1875F;
			this.SexType4TextBox.Width = 0.25F;
			// 
			// SexType3TextBox
			// 
			this.SexType3TextBox.CanGrow = false;
			this.SexType3TextBox.DataField = "SEX_TYPE_3";
			this.SexType3TextBox.Height = 0.125F;
			this.SexType3TextBox.Left = 2.1875F;
			this.SexType3TextBox.Name = "SexType3TextBox";
			this.SexType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType3TextBox.Text = "○";
			this.SexType3TextBox.Top = 4.0625F;
			this.SexType3TextBox.Width = 0.25F;
			// 
			// SexType2TextBox
			// 
			this.SexType2TextBox.CanGrow = false;
			this.SexType2TextBox.DataField = "SEX_TYPE_2";
			this.SexType2TextBox.Height = 0.1875F;
			this.SexType2TextBox.Left = 2.1875F;
			this.SexType2TextBox.Name = "SexType2TextBox";
			this.SexType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType2TextBox.Text = "○";
			this.SexType2TextBox.Top = 3.875F;
			this.SexType2TextBox.Width = 0.25F;
			// 
			// BirthDay8TextBox
			// 
			this.BirthDay8TextBox.CanGrow = false;
			this.BirthDay8TextBox.DataField = "BIRTH_DAY_8";
			this.BirthDay8TextBox.Height = 0.1875F;
			this.BirthDay8TextBox.Left = 2.4375F;
			this.BirthDay8TextBox.Name = "BirthDay8TextBox";
			this.BirthDay8TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay8TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay8TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay8TextBox.Top = 4.8125F;
			this.BirthDay8TextBox.Width = 0.6875F;
			// 
			// TBirthDay7extBox
			// 
			this.TBirthDay7extBox.CanGrow = false;
			this.TBirthDay7extBox.DataField = "BIRTH_DAY_7";
			this.TBirthDay7extBox.Height = 0.125F;
			this.TBirthDay7extBox.Left = 2.4375F;
			this.TBirthDay7extBox.Name = "TBirthDay7extBox";
			this.TBirthDay7extBox.OutputFormat = "yyyy年MM月dd日";
			this.TBirthDay7extBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TBirthDay7extBox.Text = "zzz6年z6月z6日";
			this.TBirthDay7extBox.Top = 4.6875F;
			this.TBirthDay7extBox.Width = 0.6875F;
			// 
			// BirthDay6TextBox
			// 
			this.BirthDay6TextBox.CanGrow = false;
			this.BirthDay6TextBox.DataField = "BIRTH_DAY_6";
			this.BirthDay6TextBox.Height = 0.1875F;
			this.BirthDay6TextBox.Left = 2.4375F;
			this.BirthDay6TextBox.Name = "BirthDay6TextBox";
			this.BirthDay6TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay6TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay6TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay6TextBox.Top = 4.5F;
			this.BirthDay6TextBox.Width = 0.6875F;
			// 
			// BirthDay5TextBox
			// 
			this.BirthDay5TextBox.CanGrow = false;
			this.BirthDay5TextBox.DataField = "BIRTH_DAY_5";
			this.BirthDay5TextBox.Height = 0.125F;
			this.BirthDay5TextBox.Left = 2.4375F;
			this.BirthDay5TextBox.Name = "BirthDay5TextBox";
			this.BirthDay5TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay5TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay5TextBox.Top = 4.375F;
			this.BirthDay5TextBox.Width = 0.6875F;
			// 
			// TBirthDay4extBox
			// 
			this.TBirthDay4extBox.CanGrow = false;
			this.TBirthDay4extBox.DataField = "BIRTH_DAY_4";
			this.TBirthDay4extBox.Height = 0.1875F;
			this.TBirthDay4extBox.Left = 2.4375F;
			this.TBirthDay4extBox.Name = "TBirthDay4extBox";
			this.TBirthDay4extBox.OutputFormat = "yyyy年MM月dd日";
			this.TBirthDay4extBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.TBirthDay4extBox.Text = "zzz6年z6月z6日";
			this.TBirthDay4extBox.Top = 4.1875F;
			this.TBirthDay4extBox.Width = 0.6875F;
			// 
			// BirthDay3TextBox
			// 
			this.BirthDay3TextBox.CanGrow = false;
			this.BirthDay3TextBox.DataField = "BIRTH_DAY_3";
			this.BirthDay3TextBox.Height = 0.125F;
			this.BirthDay3TextBox.Left = 2.4375F;
			this.BirthDay3TextBox.Name = "BirthDay3TextBox";
			this.BirthDay3TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay3TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay3TextBox.Top = 4.0625F;
			this.BirthDay3TextBox.Width = 0.75F;
			// 
			// BirthDay2TextBox
			// 
			this.BirthDay2TextBox.CanGrow = false;
			this.BirthDay2TextBox.DataField = "BIRTH_DAY_2";
			this.BirthDay2TextBox.Height = 0.1875F;
			this.BirthDay2TextBox.Left = 2.4375F;
			this.BirthDay2TextBox.Name = "BirthDay2TextBox";
			this.BirthDay2TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay2TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay2TextBox.Top = 3.875F;
			this.BirthDay2TextBox.Width = 0.6875F;
			// 
			// LiveTgtType8TextBox
			// 
			this.LiveTgtType8TextBox.CanGrow = false;
			this.LiveTgtType8TextBox.DataField = "LIVE_TGT_TYPE_8";
			this.LiveTgtType8TextBox.Height = 0.1875F;
			this.LiveTgtType8TextBox.Left = 3.125F;
			this.LiveTgtType8TextBox.Name = "LiveTgtType8TextBox";
			this.LiveTgtType8TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType8TextBox.Text = "○○";
			this.LiveTgtType8TextBox.Top = 4.8125F;
			this.LiveTgtType8TextBox.Width = 0.25F;
			// 
			// LiveTgtType7TextBox
			// 
			this.LiveTgtType7TextBox.CanGrow = false;
			this.LiveTgtType7TextBox.DataField = "LIVE_TGT_TYPE_7";
			this.LiveTgtType7TextBox.Height = 0.125F;
			this.LiveTgtType7TextBox.Left = 3.125F;
			this.LiveTgtType7TextBox.Name = "LiveTgtType7TextBox";
			this.LiveTgtType7TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType7TextBox.Text = "○○";
			this.LiveTgtType7TextBox.Top = 4.6875F;
			this.LiveTgtType7TextBox.Width = 0.25F;
			// 
			// LiveTgtType6TextBox
			// 
			this.LiveTgtType6TextBox.CanGrow = false;
			this.LiveTgtType6TextBox.DataField = "LIVE_TGT_TYPE_6";
			this.LiveTgtType6TextBox.Height = 0.1875F;
			this.LiveTgtType6TextBox.Left = 3.125F;
			this.LiveTgtType6TextBox.Name = "LiveTgtType6TextBox";
			this.LiveTgtType6TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType6TextBox.Text = "○○";
			this.LiveTgtType6TextBox.Top = 4.5F;
			this.LiveTgtType6TextBox.Width = 0.25F;
			// 
			// LiveTgtType5TextBox
			// 
			this.LiveTgtType5TextBox.CanGrow = false;
			this.LiveTgtType5TextBox.DataField = "LIVE_TGT_TYPE_5";
			this.LiveTgtType5TextBox.Height = 0.125F;
			this.LiveTgtType5TextBox.Left = 3.125F;
			this.LiveTgtType5TextBox.Name = "LiveTgtType5TextBox";
			this.LiveTgtType5TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType5TextBox.Text = "○○";
			this.LiveTgtType5TextBox.Top = 4.375F;
			this.LiveTgtType5TextBox.Width = 0.25F;
			// 
			// LiveTgtType4TextBox
			// 
			this.LiveTgtType4TextBox.CanGrow = false;
			this.LiveTgtType4TextBox.DataField = "LIVE_TGT_TYPE_4";
			this.LiveTgtType4TextBox.Height = 0.1875F;
			this.LiveTgtType4TextBox.Left = 3.125F;
			this.LiveTgtType4TextBox.Name = "LiveTgtType4TextBox";
			this.LiveTgtType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType4TextBox.Text = "○○";
			this.LiveTgtType4TextBox.Top = 4.1875F;
			this.LiveTgtType4TextBox.Width = 0.25F;
			// 
			// LiveTgtType3TextBox
			// 
			this.LiveTgtType3TextBox.CanGrow = false;
			this.LiveTgtType3TextBox.DataField = "LIVE_TGT_TYPE_3";
			this.LiveTgtType3TextBox.Height = 0.125F;
			this.LiveTgtType3TextBox.Left = 3.125F;
			this.LiveTgtType3TextBox.Name = "LiveTgtType3TextBox";
			this.LiveTgtType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType3TextBox.Text = "○○";
			this.LiveTgtType3TextBox.Top = 4.0625F;
			this.LiveTgtType3TextBox.Width = 0.25F;
			// 
			// LiveTgtType2TextBox
			// 
			this.LiveTgtType2TextBox.CanGrow = false;
			this.LiveTgtType2TextBox.DataField = "LIVE_TGT_TYPE_2";
			this.LiveTgtType2TextBox.Height = 0.1875F;
			this.LiveTgtType2TextBox.Left = 3.125F;
			this.LiveTgtType2TextBox.Name = "LiveTgtType2TextBox";
			this.LiveTgtType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType2TextBox.Text = "○○";
			this.LiveTgtType2TextBox.Top = 3.875F;
			this.LiveTgtType2TextBox.Width = 0.25F;
			// 
			// Employ8TextBox
			// 
			this.Employ8TextBox.CanGrow = false;
			this.Employ8TextBox.DataField = "EMPLOY_8";
			this.Employ8TextBox.Height = 0.1875F;
			this.Employ8TextBox.Left = 3.375F;
			this.Employ8TextBox.Name = "Employ8TextBox";
			this.Employ8TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ8TextBox.Text = "あいうえおかきくけこ";
			this.Employ8TextBox.Top = 4.8125F;
			this.Employ8TextBox.Width = 1F;
			// 
			// Employ7TextBox
			// 
			this.Employ7TextBox.CanGrow = false;
			this.Employ7TextBox.DataField = "EMPLOY_7";
			this.Employ7TextBox.Height = 0.125F;
			this.Employ7TextBox.Left = 3.375F;
			this.Employ7TextBox.Name = "Employ7TextBox";
			this.Employ7TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ7TextBox.Text = "あいうえおかきくけこ";
			this.Employ7TextBox.Top = 4.6875F;
			this.Employ7TextBox.Width = 1F;
			// 
			// Employ6TextBox
			// 
			this.Employ6TextBox.CanGrow = false;
			this.Employ6TextBox.DataField = "EMPLOY_6";
			this.Employ6TextBox.Height = 0.1875F;
			this.Employ6TextBox.Left = 3.375F;
			this.Employ6TextBox.Name = "Employ6TextBox";
			this.Employ6TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ6TextBox.Text = "あいうえおかきくけこ";
			this.Employ6TextBox.Top = 4.5F;
			this.Employ6TextBox.Width = 1F;
			// 
			// Employ5TextBox
			// 
			this.Employ5TextBox.CanGrow = false;
			this.Employ5TextBox.DataField = "EMPLOY_5";
			this.Employ5TextBox.Height = 0.125F;
			this.Employ5TextBox.Left = 3.375F;
			this.Employ5TextBox.Name = "Employ5TextBox";
			this.Employ5TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ5TextBox.Text = "あいうえおかきくけこ";
			this.Employ5TextBox.Top = 4.375F;
			this.Employ5TextBox.Width = 1F;
			// 
			// Employ4TextBox
			// 
			this.Employ4TextBox.CanGrow = false;
			this.Employ4TextBox.DataField = "EMPLOY_4";
			this.Employ4TextBox.Height = 0.1875F;
			this.Employ4TextBox.Left = 3.375F;
			this.Employ4TextBox.Name = "Employ4TextBox";
			this.Employ4TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ4TextBox.Text = "あいうえおかきくけこ";
			this.Employ4TextBox.Top = 4.1875F;
			this.Employ4TextBox.Width = 1F;
			// 
			// Employ3TextBox
			// 
			this.Employ3TextBox.CanGrow = false;
			this.Employ3TextBox.DataField = "EMPLOY_3";
			this.Employ3TextBox.Height = 0.125F;
			this.Employ3TextBox.Left = 3.375F;
			this.Employ3TextBox.Name = "Employ3TextBox";
			this.Employ3TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ3TextBox.Text = "あいうえおかきくけこ";
			this.Employ3TextBox.Top = 4.0625F;
			this.Employ3TextBox.Width = 1F;
			// 
			// Employ2TextBox
			// 
			this.Employ2TextBox.CanGrow = false;
			this.Employ2TextBox.DataField = "EMPLOY_2";
			this.Employ2TextBox.Height = 0.1875F;
			this.Employ2TextBox.Left = 3.375F;
			this.Employ2TextBox.Name = "Employ2TextBox";
			this.Employ2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ2TextBox.Text = "あいうえおかきくけこ";
			this.Employ2TextBox.Top = 3.875F;
			this.Employ2TextBox.Width = 1F;
			// 
			// DpndType7TextBox
			// 
			this.DpndType7TextBox.CanGrow = false;
			this.DpndType7TextBox.DataField = "DPND_TYPE_7";
			this.DpndType7TextBox.Height = 0.125F;
			this.DpndType7TextBox.Left = 4.375F;
			this.DpndType7TextBox.Name = "DpndType7TextBox";
			this.DpndType7TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType7TextBox.Text = "あいう";
			this.DpndType7TextBox.Top = 4.6875F;
			this.DpndType7TextBox.Width = 0.3125F;
			// 
			// DpndType6TextBox
			// 
			this.DpndType6TextBox.CanGrow = false;
			this.DpndType6TextBox.DataField = "DPND_TYPE_6";
			this.DpndType6TextBox.Height = 0.1875F;
			this.DpndType6TextBox.Left = 4.375F;
			this.DpndType6TextBox.Name = "DpndType6TextBox";
			this.DpndType6TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType6TextBox.Text = "あいう";
			this.DpndType6TextBox.Top = 4.5F;
			this.DpndType6TextBox.Width = 0.3125F;
			// 
			// DpndType5TextBox
			// 
			this.DpndType5TextBox.CanGrow = false;
			this.DpndType5TextBox.DataField = "DPND_TYPE_5";
			this.DpndType5TextBox.Height = 0.125F;
			this.DpndType5TextBox.Left = 4.375F;
			this.DpndType5TextBox.Name = "DpndType5TextBox";
			this.DpndType5TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType5TextBox.Text = "あいう";
			this.DpndType5TextBox.Top = 4.375F;
			this.DpndType5TextBox.Width = 0.3125F;
			// 
			// DpndType4TextBox
			// 
			this.DpndType4TextBox.CanGrow = false;
			this.DpndType4TextBox.DataField = "DPND_TYPE_4";
			this.DpndType4TextBox.Height = 0.1875F;
			this.DpndType4TextBox.Left = 4.375F;
			this.DpndType4TextBox.Name = "DpndType4TextBox";
			this.DpndType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType4TextBox.Text = "あいう";
			this.DpndType4TextBox.Top = 4.1875F;
			this.DpndType4TextBox.Width = 0.3125F;
			// 
			// DpndType3TextBox
			// 
			this.DpndType3TextBox.CanGrow = false;
			this.DpndType3TextBox.DataField = "DPND_TYPE_3";
			this.DpndType3TextBox.Height = 0.125F;
			this.DpndType3TextBox.Left = 4.375F;
			this.DpndType3TextBox.Name = "DpndType3TextBox";
			this.DpndType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType3TextBox.Text = "あいう";
			this.DpndType3TextBox.Top = 4.0625F;
			this.DpndType3TextBox.Width = 0.3125F;
			// 
			// DpndType2TextBox
			// 
			this.DpndType2TextBox.CanGrow = false;
			this.DpndType2TextBox.DataField = "DPND_TYPE_2";
			this.DpndType2TextBox.Height = 0.1875F;
			this.DpndType2TextBox.Left = 4.375F;
			this.DpndType2TextBox.Name = "DpndType2TextBox";
			this.DpndType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType2TextBox.Text = "あいう";
			this.DpndType2TextBox.Top = 3.875F;
			this.DpndType2TextBox.Width = 0.3125F;
			// 
			// DpndType8TextBox
			// 
			this.DpndType8TextBox.CanGrow = false;
			this.DpndType8TextBox.DataField = "DPND_TYPE_8";
			this.DpndType8TextBox.Height = 0.1875F;
			this.DpndType8TextBox.Left = 4.375F;
			this.DpndType8TextBox.Name = "DpndType8TextBox";
			this.DpndType8TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType8TextBox.Text = "あいう";
			this.DpndType8TextBox.Top = 4.8125F;
			this.DpndType8TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType7TextBox
			// 
			this.HeltInsObjType7TextBox.CanGrow = false;
			this.HeltInsObjType7TextBox.DataField = "HELT_INS_OBJ_TYPE_7";
			this.HeltInsObjType7TextBox.Height = 0.125F;
			this.HeltInsObjType7TextBox.Left = 4.6875F;
			this.HeltInsObjType7TextBox.Name = "HeltInsObjType7TextBox";
			this.HeltInsObjType7TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType7TextBox.Text = "あいう";
			this.HeltInsObjType7TextBox.Top = 4.6875F;
			this.HeltInsObjType7TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType6TextBox
			// 
			this.HeltInsObjType6TextBox.CanGrow = false;
			this.HeltInsObjType6TextBox.DataField = "HELT_INS_OBJ_TYPE_6";
			this.HeltInsObjType6TextBox.Height = 0.1875F;
			this.HeltInsObjType6TextBox.Left = 4.6875F;
			this.HeltInsObjType6TextBox.Name = "HeltInsObjType6TextBox";
			this.HeltInsObjType6TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType6TextBox.Text = "あいう";
			this.HeltInsObjType6TextBox.Top = 4.5F;
			this.HeltInsObjType6TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType5TextBox
			// 
			this.HeltInsObjType5TextBox.CanGrow = false;
			this.HeltInsObjType5TextBox.DataField = "HELT_INS_OBJ_TYPE_5";
			this.HeltInsObjType5TextBox.Height = 0.125F;
			this.HeltInsObjType5TextBox.Left = 4.6875F;
			this.HeltInsObjType5TextBox.Name = "HeltInsObjType5TextBox";
			this.HeltInsObjType5TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType5TextBox.Text = "あいう";
			this.HeltInsObjType5TextBox.Top = 4.375F;
			this.HeltInsObjType5TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType4TextBox
			// 
			this.HeltInsObjType4TextBox.CanGrow = false;
			this.HeltInsObjType4TextBox.DataField = "HELT_INS_OBJ_TYPE_4";
			this.HeltInsObjType4TextBox.Height = 0.1875F;
			this.HeltInsObjType4TextBox.Left = 4.6875F;
			this.HeltInsObjType4TextBox.Name = "HeltInsObjType4TextBox";
			this.HeltInsObjType4TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType4TextBox.Text = "あいう";
			this.HeltInsObjType4TextBox.Top = 4.1875F;
			this.HeltInsObjType4TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType3TextBox
			// 
			this.HeltInsObjType3TextBox.CanGrow = false;
			this.HeltInsObjType3TextBox.DataField = "HELT_INS_OBJ_TYPE_3";
			this.HeltInsObjType3TextBox.Height = 0.125F;
			this.HeltInsObjType3TextBox.Left = 4.6875F;
			this.HeltInsObjType3TextBox.Name = "HeltInsObjType3TextBox";
			this.HeltInsObjType3TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType3TextBox.Text = "あいう";
			this.HeltInsObjType3TextBox.Top = 4.0625F;
			this.HeltInsObjType3TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType2TextBox
			// 
			this.HeltInsObjType2TextBox.CanGrow = false;
			this.HeltInsObjType2TextBox.DataField = "HELT_INS_OBJ_TYPE_2";
			this.HeltInsObjType2TextBox.Height = 0.1875F;
			this.HeltInsObjType2TextBox.Left = 4.6875F;
			this.HeltInsObjType2TextBox.Name = "HeltInsObjType2TextBox";
			this.HeltInsObjType2TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType2TextBox.Text = "あいう";
			this.HeltInsObjType2TextBox.Top = 3.875F;
			this.HeltInsObjType2TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType8TextBox
			// 
			this.HeltInsObjType8TextBox.CanGrow = false;
			this.HeltInsObjType8TextBox.DataField = "HELT_INS_OBJ_TYPE_8";
			this.HeltInsObjType8TextBox.Height = 0.1875F;
			this.HeltInsObjType8TextBox.Left = 4.6875F;
			this.HeltInsObjType8TextBox.Name = "HeltInsObjType8TextBox";
			this.HeltInsObjType8TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType8TextBox.Text = "あいう";
			this.HeltInsObjType8TextBox.Top = 4.8125F;
			this.HeltInsObjType8TextBox.Width = 0.3125F;
			// 
			// Label146
			// 
			this.Label146.Height = 0.125F;
			this.Label146.HyperLink = null;
			this.Label146.Left = 0.3125F;
			this.Label146.Name = "Label146";
			this.Label146.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label146.Text = "〒";
			this.Label146.Top = 1.25F;
			this.Label146.Width = 0.125F;
			// 
			// Zip_2TextBox
			// 
			this.Zip_2TextBox.CanGrow = false;
			this.Zip_2TextBox.DataField = "ZIP_3";
			this.Zip_2TextBox.Height = 0.125F;
			this.Zip_2TextBox.Left = 0.4375F;
			this.Zip_2TextBox.Name = "Zip_2TextBox";
			this.Zip_2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Zip_2TextBox.Text = "0000000000";
			this.Zip_2TextBox.Top = 1.25F;
			this.Zip_2TextBox.Width = 0.5F;
			// 
			// Label147
			// 
			this.Label147.Height = 0.125F;
			this.Label147.HyperLink = null;
			this.Label147.Left = 0.9375F;
			this.Label147.Name = "Label147";
			this.Label147.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label147.Text = "℡";
			this.Label147.Top = 1.25F;
			this.Label147.Width = 0.125F;
			// 
			// Phone_2TextBox
			// 
			this.Phone_2TextBox.CanGrow = false;
			this.Phone_2TextBox.DataField = "PHONE_3";
			this.Phone_2TextBox.Height = 0.125F;
			this.Phone_2TextBox.Left = 1.0625F;
			this.Phone_2TextBox.Name = "Phone_2TextBox";
			this.Phone_2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Phone_2TextBox.Text = "000000000000000";
			this.Phone_2TextBox.Top = 1.25F;
			this.Phone_2TextBox.Width = 0.75F;
			// 
			// Label148
			// 
			this.Label148.Height = 0.125F;
			this.Label148.HyperLink = null;
			this.Label148.Left = 1.75F;
			this.Label148.Name = "Label148";
			this.Label148.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label148.Text = "氏名";
			this.Label148.Top = 1.25F;
			this.Label148.Width = 0.4375F;
			// 
			// Name2TextBox
			// 
			this.Name2TextBox.CanGrow = false;
			this.Name2TextBox.DataField = "NAME_3";
			this.Name2TextBox.Height = 0.125F;
			this.Name2TextBox.Left = 2.0625F;
			this.Name2TextBox.Name = "Name2TextBox";
			this.Name2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Name2TextBox.Text = "あいうえおかきくけこ";
			this.Name2TextBox.Top = 1.25F;
			this.Name2TextBox.Width = 1F;
			// 
			// Label149
			// 
			this.Label149.Height = 0.125F;
			this.Label149.HyperLink = null;
			this.Label149.Left = 3F;
			this.Label149.Name = "Label149";
			this.Label149.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label149.Text = "関係";
			this.Label149.Top = 1.25F;
			this.Label149.Width = 0.4375F;
			// 
			// Relation2TextBox
			// 
			this.Relation2TextBox.CanGrow = false;
			this.Relation2TextBox.DataField = "RELATION_3";
			this.Relation2TextBox.Height = 0.125F;
			this.Relation2TextBox.Left = 3.375F;
			this.Relation2TextBox.Name = "Relation2TextBox";
			this.Relation2TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Relation2TextBox.Text = "あいうえ";
			this.Relation2TextBox.Top = 1.25F;
			this.Relation2TextBox.Width = 0.4375F;
			// 
			// HeltInsObtainDateTextBox
			// 
			this.HeltInsObtainDateTextBox.CanGrow = false;
			this.HeltInsObtainDateTextBox.DataField = "HELT_INS_OBTAIN_DATE";
			this.HeltInsObtainDateTextBox.Height = 0.125F;
			this.HeltInsObtainDateTextBox.Left = 3.3125F;
			this.HeltInsObtainDateTextBox.Name = "HeltInsObtainDateTextBox";
			this.HeltInsObtainDateTextBox.OutputFormat = "d";
			this.HeltInsObtainDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.HeltInsObtainDateTextBox.Text = "zzz6/z6/z6";
			this.HeltInsObtainDateTextBox.Top = 5.625F;
			this.HeltInsObtainDateTextBox.Width = 0.5625F;
			// 
			// PensFndObtainDateTextBox
			// 
			this.PensFndObtainDateTextBox.CanGrow = false;
			this.PensFndObtainDateTextBox.DataField = "PENS_FND_OBTAIN_DATE";
			this.PensFndObtainDateTextBox.Height = 0.125F;
			this.PensFndObtainDateTextBox.Left = 3.3125F;
			this.PensFndObtainDateTextBox.Name = "PensFndObtainDateTextBox";
			this.PensFndObtainDateTextBox.OutputFormat = "d";
			this.PensFndObtainDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensFndObtainDateTextBox.Text = "zzz6/z6/z6";
			this.PensFndObtainDateTextBox.Top = 6.25F;
			this.PensFndObtainDateTextBox.Width = 0.5625F;
			// 
			// PensObtainDateTextBox
			// 
			this.PensObtainDateTextBox.CanGrow = false;
			this.PensObtainDateTextBox.DataField = "PENS_OBTAIN_DATE";
			this.PensObtainDateTextBox.Height = 0.125F;
			this.PensObtainDateTextBox.Left = 3.3125F;
			this.PensObtainDateTextBox.Name = "PensObtainDateTextBox";
			this.PensObtainDateTextBox.OutputFormat = "d";
			this.PensObtainDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensObtainDateTextBox.Text = "zzz6/z6/z6";
			this.PensObtainDateTextBox.Top = 5.9375F;
			this.PensObtainDateTextBox.Width = 0.5625F;
			// 
			// PensFndLossDateTextBox
			// 
			this.PensFndLossDateTextBox.CanGrow = false;
			this.PensFndLossDateTextBox.DataField = "PENS_FND_LOSS_DATE";
			this.PensFndLossDateTextBox.Height = 0.125F;
			this.PensFndLossDateTextBox.Left = 3.875F;
			this.PensFndLossDateTextBox.Name = "PensFndLossDateTextBox";
			this.PensFndLossDateTextBox.OutputFormat = "d";
			this.PensFndLossDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensFndLossDateTextBox.Text = "zzz6/z6/z6";
			this.PensFndLossDateTextBox.Top = 6.25F;
			this.PensFndLossDateTextBox.Width = 0.5625F;
			// 
			// PensLossDateTextBox
			// 
			this.PensLossDateTextBox.CanGrow = false;
			this.PensLossDateTextBox.DataField = "PENS_LOSS_DATE";
			this.PensLossDateTextBox.Height = 0.125F;
			this.PensLossDateTextBox.Left = 3.875F;
			this.PensLossDateTextBox.Name = "PensLossDateTextBox";
			this.PensLossDateTextBox.OutputFormat = "d";
			this.PensLossDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.PensLossDateTextBox.Text = "zzz6/z6/z6";
			this.PensLossDateTextBox.Top = 5.9375F;
			this.PensLossDateTextBox.Width = 0.5625F;
			// 
			// HeltInsLossDateTextBox
			// 
			this.HeltInsLossDateTextBox.CanGrow = false;
			this.HeltInsLossDateTextBox.DataField = "HELT_INS_LOSS_DATE";
			this.HeltInsLossDateTextBox.Height = 0.125F;
			this.HeltInsLossDateTextBox.Left = 3.875F;
			this.HeltInsLossDateTextBox.Name = "HeltInsLossDateTextBox";
			this.HeltInsLossDateTextBox.OutputFormat = "d";
			this.HeltInsLossDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.HeltInsLossDateTextBox.Text = "zzz6/z6/z6";
			this.HeltInsLossDateTextBox.Top = 5.625F;
			this.HeltInsLossDateTextBox.Width = 0.5625F;
			// 
			// RetireReasonTextBox
			// 
			this.RetireReasonTextBox.CanGrow = false;
			this.RetireReasonTextBox.DataField = "RETIRE_REASON";
			this.RetireReasonTextBox.Height = 0.25F;
			this.RetireReasonTextBox.Left = 3.75F;
			this.RetireReasonTextBox.Name = "RetireReasonTextBox";
			this.RetireReasonTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.RetireReasonTextBox.Text = "あいうえおかきくけこ";
			this.RetireReasonTextBox.Top = 0.5F;
			this.RetireReasonTextBox.Width = 0.5625F;
			// 
			// FamRal9TextBox
			// 
			this.FamRal9TextBox.CanGrow = false;
			this.FamRal9TextBox.DataField = "FAM_RAL_9";
			this.FamRal9TextBox.Height = 0.125F;
			this.FamRal9TextBox.Left = 0.3125F;
			this.FamRal9TextBox.Name = "FamRal9TextBox";
			this.FamRal9TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.FamRal9TextBox.Text = "あいうえお";
			this.FamRal9TextBox.Top = 5F;
			this.FamRal9TextBox.Width = 0.5F;
			// 
			// LastName9TextBox
			// 
			this.LastName9TextBox.CanGrow = false;
			this.LastName9TextBox.DataField = "LAST_NAME_9";
			this.LastName9TextBox.Height = 0.125F;
			this.LastName9TextBox.Left = 0.8125F;
			this.LastName9TextBox.Name = "LastName9TextBox";
			this.LastName9TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.LastName9TextBox.Text = "あいうえおかき";
			this.LastName9TextBox.Top = 5F;
			this.LastName9TextBox.Width = 1.375F;
			// 
			// SexType9TextBox
			// 
			this.SexType9TextBox.CanGrow = false;
			this.SexType9TextBox.DataField = "SEX_TYPE_9";
			this.SexType9TextBox.Height = 0.125F;
			this.SexType9TextBox.Left = 2.1875F;
			this.SexType9TextBox.Name = "SexType9TextBox";
			this.SexType9TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SexType9TextBox.Text = "○";
			this.SexType9TextBox.Top = 5F;
			this.SexType9TextBox.Width = 0.25F;
			// 
			// BirthDay9TextBox
			// 
			this.BirthDay9TextBox.CanGrow = false;
			this.BirthDay9TextBox.DataField = "BIRTH_DAY_9";
			this.BirthDay9TextBox.Height = 0.125F;
			this.BirthDay9TextBox.Left = 2.4375F;
			this.BirthDay9TextBox.Name = "BirthDay9TextBox";
			this.BirthDay9TextBox.OutputFormat = "yyyy年MM月dd日";
			this.BirthDay9TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthDay9TextBox.Text = "zzz6年z6月z6日";
			this.BirthDay9TextBox.Top = 5F;
			this.BirthDay9TextBox.Width = 0.6875F;
			// 
			// LiveTgtType9TextBox
			// 
			this.LiveTgtType9TextBox.CanGrow = false;
			this.LiveTgtType9TextBox.DataField = "LIVE_TGT_TYPE_9";
			this.LiveTgtType9TextBox.Height = 0.125F;
			this.LiveTgtType9TextBox.Left = 3.125F;
			this.LiveTgtType9TextBox.Name = "LiveTgtType9TextBox";
			this.LiveTgtType9TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.LiveTgtType9TextBox.Text = "○○";
			this.LiveTgtType9TextBox.Top = 5F;
			this.LiveTgtType9TextBox.Width = 0.25F;
			// 
			// Employ9TextBox
			// 
			this.Employ9TextBox.CanGrow = false;
			this.Employ9TextBox.DataField = "EMPLOY_9";
			this.Employ9TextBox.Height = 0.125F;
			this.Employ9TextBox.Left = 3.375F;
			this.Employ9TextBox.Name = "Employ9TextBox";
			this.Employ9TextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.Employ9TextBox.Text = "あいうえおかきくけこ";
			this.Employ9TextBox.Top = 5F;
			this.Employ9TextBox.Width = 1F;
			// 
			// DpndType9TextBox
			// 
			this.DpndType9TextBox.CanGrow = false;
			this.DpndType9TextBox.DataField = "DPND_TYPE_9";
			this.DpndType9TextBox.Height = 0.125F;
			this.DpndType9TextBox.Left = 4.375F;
			this.DpndType9TextBox.Name = "DpndType9TextBox";
			this.DpndType9TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndType9TextBox.Text = "あいう";
			this.DpndType9TextBox.Top = 5F;
			this.DpndType9TextBox.Width = 0.3125F;
			// 
			// HeltInsObjType9TextBox
			// 
			this.HeltInsObjType9TextBox.CanGrow = false;
			this.HeltInsObjType9TextBox.DataField = "HELT_INS_OBJ_TYPE_9";
			this.HeltInsObjType9TextBox.Height = 0.125F;
			this.HeltInsObjType9TextBox.Left = 4.6875F;
			this.HeltInsObjType9TextBox.Name = "HeltInsObjType9TextBox";
			this.HeltInsObjType9TextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HeltInsObjType9TextBox.Text = "あいう";
			this.HeltInsObjType9TextBox.Top = 5F;
			this.HeltInsObjType9TextBox.Width = 0.3125F;
			// 
			// EmployInsObtainDateTextBox
			// 
			this.EmployInsObtainDateTextBox.CanGrow = false;
			this.EmployInsObtainDateTextBox.DataField = "EMPLOY_INS_OBTAIN_DATE";
			this.EmployInsObtainDateTextBox.Height = 0.125F;
			this.EmployInsObtainDateTextBox.Left = 3.3125F;
			this.EmployInsObtainDateTextBox.Name = "EmployInsObtainDateTextBox";
			this.EmployInsObtainDateTextBox.OutputFormat = "d";
			this.EmployInsObtainDateTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmployInsObtainDateTextBox.Text = "zzz6/z6/z6";
			this.EmployInsObtainDateTextBox.Top = 5.3125F;
			this.EmployInsObtainDateTextBox.Width = 0.5625F;
			// 
			// EmployInsLossDateTextBox309
			// 
			this.EmployInsLossDateTextBox309.CanGrow = false;
			this.EmployInsLossDateTextBox309.DataField = "EMPLOY_INS_LOSS_DATE";
			this.EmployInsLossDateTextBox309.Height = 0.125F;
			this.EmployInsLossDateTextBox309.Left = 3.875F;
			this.EmployInsLossDateTextBox309.Name = "EmployInsLossDateTextBox309";
			this.EmployInsLossDateTextBox309.OutputFormat = "d";
			this.EmployInsLossDateTextBox309.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.EmployInsLossDateTextBox309.Text = "zzz6/z6/z6";
			this.EmployInsLossDateTextBox309.Top = 5.3125F;
			this.EmployInsLossDateTextBox309.Width = 0.5625F;
			// 
			// Line335
			// 
			this.Line335.Height = 0F;
			this.Line335.Left = 0.001F;
			this.Line335.LineWeight = 1F;
			this.Line335.Name = "Line335";
			this.Line335.Top = 0F;
			this.Line335.Width = 10.63128F;
			this.Line335.X1 = 0.001F;
			this.Line335.X2 = 10.63228F;
			this.Line335.Y1 = 0F;
			this.Line335.Y2 = 0F;
			// 
			// Line338
			// 
			this.Line338.Height = 1.558F;
			this.Line338.Left = 4.3815F;
			this.Line338.LineWeight = 1F;
			this.Line338.Name = "Line338";
			this.Line338.Top = 3.573F;
			this.Line338.Width = 0F;
			this.Line338.X1 = 4.3815F;
			this.Line338.X2 = 4.3815F;
			this.Line338.Y1 = 3.573F;
			this.Line338.Y2 = 5.131F;
			// 
			// Picture1
			// 
			this.Picture1.Height = 0.745F;
			this.Picture1.Left = 4.313F;
			this.Picture1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Picture1.Name = "Picture1";
			this.Picture1.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
			this.Picture1.Top = 0.02F;
			this.Picture1.Width = 1.125F;
			// 
			// Label175
			// 
			this.Label175.Height = 0.125F;
			this.Label175.HyperLink = null;
			this.Label175.Left = 2.3125F;
			this.Label175.Name = "Label175";
			this.Label175.Style = "font-size: 7pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label175.Text = "変更日";
			this.Label175.Top = 0.9375F;
			this.Label175.Width = 0.4375F;
			// 
			// AdrsChgDate2
			// 
			this.AdrsChgDate2.CanGrow = false;
			this.AdrsChgDate2.DataField = "ADRS_CHG_DATE_2";
			this.AdrsChgDate2.Height = 0.125F;
			this.AdrsChgDate2.Left = 2.75F;
			this.AdrsChgDate2.Name = "AdrsChgDate2";
			this.AdrsChgDate2.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.AdrsChgDate2.Text = "zzz6/z6/z6";
			this.AdrsChgDate2.Top = 0.9375F;
			this.AdrsChgDate2.Width = 0.5625F;
			// 
			// Line238
			// 
			this.Line238.Height = 0F;
			this.Line238.Left = 0.313F;
			this.Line238.LineWeight = 1F;
			this.Line238.Name = "Line238";
			this.Line238.Top = 1.384F;
			this.Line238.Width = 5.131095F;
			this.Line238.X1 = 0.313F;
			this.Line238.X2 = 5.444095F;
			this.Line238.Y1 = 1.384F;
			this.Line238.Y2 = 1.384F;
			// 
			// Line235
			// 
			this.Line235.Height = 0F;
			this.Line235.Left = 0.313F;
			this.Line235.LineWeight = 1F;
			this.Line235.Name = "Line235";
			this.Line235.Top = 0.772F;
			this.Line235.Width = 5.131095F;
			this.Line235.X1 = 0.313F;
			this.Line235.X2 = 5.444095F;
			this.Line235.Y1 = 0.772F;
			this.Line235.Y2 = 0.772F;
			// 
			// Line273
			// 
			this.Line273.Height = 0F;
			this.Line273.Left = 0F;
			this.Line273.LineWeight = 1F;
			this.Line273.Name = "Line273";
			this.Line273.Top = 1.228F;
			this.Line273.Width = 5.444095F;
			this.Line273.X1 = 0F;
			this.Line273.X2 = 5.444095F;
			this.Line273.Y1 = 1.228F;
			this.Line273.Y2 = 1.228F;
			// 
			// BirthYmdJPText
			// 
			this.BirthYmdJPText.CanGrow = false;
			this.BirthYmdJPText.DataField = "BIRTH_YMD";
			this.BirthYmdJPText.Height = 0.15F;
			this.BirthYmdJPText.Left = 3.43F;
			this.BirthYmdJPText.Name = "BirthYmdJPText";
			this.BirthYmdJPText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.BirthYmdJPText.Text = "H999年";
			this.BirthYmdJPText.Top = 0F;
			this.BirthYmdJPText.Width = 0.3F;
			// 
			// InDateJPTextBox
			// 
			this.InDateJPTextBox.CanGrow = false;
			this.InDateJPTextBox.DataField = "IN_DATE";
			this.InDateJPTextBox.Height = 0.15F;
			this.InDateJPTextBox.Left = 3.43F;
			this.InDateJPTextBox.Name = "InDateJPTextBox";
			this.InDateJPTextBox.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.InDateJPTextBox.Text = "H999年";
			this.InDateJPTextBox.Top = 0.17F;
			this.InDateJPTextBox.Width = 0.3F;
			// 
			// AssocItemNameTextBox
			// 
			this.AssocItemNameTextBox.CanGrow = false;
			this.AssocItemNameTextBox.DataField = "ASSOC_ITEM_NAME_3";
			this.AssocItemNameTextBox.Height = 0.313F;
			this.AssocItemNameTextBox.Left = 0F;
			this.AssocItemNameTextBox.Name = "AssocItemNameTextBox";
			this.AssocItemNameTextBox.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.AssocItemNameTextBox.Text = "あいうえ";
			this.AssocItemNameTextBox.Top = 1.25F;
			this.AssocItemNameTextBox.Width = 0.313F;
			// 
			// Line237
			// 
			this.Line237.Height = 0F;
			this.Line237.Left = 0F;
			this.Line237.LineWeight = 1F;
			this.Line237.Name = "Line237";
			this.Line237.Top = 1.555F;
			this.Line237.Width = 5.444095F;
			this.Line237.X1 = 0F;
			this.Line237.X2 = 5.444095F;
			this.Line237.Y1 = 1.555F;
			this.Line237.Y2 = 1.555F;
			// 
			// Line225
			// 
			this.Line225.Height = 0F;
			this.Line225.Left = 0.313F;
			this.Line225.LineWeight = 1F;
			this.Line225.Name = "Line225";
			this.Line225.Top = 1.078F;
			this.Line225.Width = 5.131095F;
			this.Line225.X1 = 0.313F;
			this.Line225.X2 = 5.444095F;
			this.Line225.Y1 = 1.078F;
			this.Line225.Y2 = 1.078F;
			// 
			// Line223
			// 
			this.Line223.Height = 0F;
			this.Line223.Left = 0F;
			this.Line223.LineWeight = 1F;
			this.Line223.Name = "Line223";
			this.Line223.Top = 0.927F;
			this.Line223.Width = 5.444095F;
			this.Line223.X1 = 0F;
			this.Line223.X2 = 5.444095F;
			this.Line223.Y1 = 0.927F;
			this.Line223.Y2 = 0.927F;
			// 
			// Line249
			// 
			this.Line249.Height = 0F;
			this.Line249.Left = 0.313F;
			this.Line249.LineWeight = 1F;
			this.Line249.Name = "Line249";
			this.Line249.Top = 2.641F;
			this.Line249.Width = 5.131F;
			this.Line249.X1 = 0.313F;
			this.Line249.X2 = 5.444F;
			this.Line249.Y1 = 2.641F;
			this.Line249.Y2 = 2.641F;
			// 
			// Line272
			// 
			this.Line272.Height = 0F;
			this.Line272.Left = 0F;
			this.Line272.LineWeight = 1F;
			this.Line272.Name = "Line272";
			this.Line272.Top = 6.381945F;
			this.Line272.Width = 10.63228F;
			this.Line272.X1 = 0F;
			this.Line272.X2 = 10.63228F;
			this.Line272.Y1 = 6.381945F;
			this.Line272.Y2 = 6.381945F;
			// 
			// Line266
			// 
			this.Line266.Height = 0F;
			this.Line266.Left = 0.313F;
			this.Line266.LineWeight = 1F;
			this.Line266.Name = "Line266";
			this.Line266.Top = 5.444F;
			this.Line266.Width = 5.131095F;
			this.Line266.X1 = 0.313F;
			this.Line266.X2 = 5.444095F;
			this.Line266.Y1 = 5.444F;
			this.Line266.Y2 = 5.444F;
			// 
			// Line264
			// 
			this.Line264.Height = 0F;
			this.Line264.Left = 0F;
			this.Line264.LineWeight = 1F;
			this.Line264.Name = "Line264";
			this.Line264.Top = 5.131F;
			this.Line264.Width = 5.444095F;
			this.Line264.X1 = 0F;
			this.Line264.X2 = 5.444095F;
			this.Line264.Y1 = 5.131F;
			this.Line264.Y2 = 5.131F;
			// 
			// Line257
			// 
			this.Line257.Height = 0F;
			this.Line257.Left = 0.313F;
			this.Line257.LineWeight = 1F;
			this.Line257.Name = "Line257";
			this.Line257.Top = 4.196F;
			this.Line257.Width = 5.131095F;
			this.Line257.X1 = 0.313F;
			this.Line257.X2 = 5.444095F;
			this.Line257.Y1 = 4.196F;
			this.Line257.Y2 = 4.196F;
			// 
			// Line252
			// 
			this.Line252.Height = 0F;
			this.Line252.Left = 0F;
			this.Line252.LineWeight = 1F;
			this.Line252.Name = "Line252";
			this.Line252.Top = 3.417F;
			this.Line252.Width = 5.444095F;
			this.Line252.X1 = 0F;
			this.Line252.X2 = 5.444095F;
			this.Line252.Y1 = 3.417F;
			this.Line252.Y2 = 3.417F;
			// 
			// Line241
			// 
			this.Line241.Height = 0F;
			this.Line241.Left = 0.315F;
			this.Line241.LineWeight = 1F;
			this.Line241.Name = "Line241";
			this.Line241.Top = 1.714F;
			this.Line241.Width = 5.129F;
			this.Line241.X1 = 0.315F;
			this.Line241.X2 = 5.444F;
			this.Line241.Y1 = 1.714F;
			this.Line241.Y2 = 1.714F;
			// 
			// Line299
			// 
			this.Line299.Height = 1.558F;
			this.Line299.Left = 3.3815F;
			this.Line299.LineWeight = 1F;
			this.Line299.Name = "Line299";
			this.Line299.Top = 3.573F;
			this.Line299.Width = 0F;
			this.Line299.X1 = 3.3815F;
			this.Line299.X2 = 3.3815F;
			this.Line299.Y1 = 3.573F;
			this.Line299.Y2 = 5.131F;
			// 
			// Line300
			// 
			this.Line300.Height = 1.558F;
			this.Line300.Left = 3.131944F;
			this.Line300.LineWeight = 1F;
			this.Line300.Name = "Line300";
			this.Line300.Top = 3.573F;
			this.Line300.Width = 0F;
			this.Line300.X1 = 3.131944F;
			this.Line300.X2 = 3.131944F;
			this.Line300.Y1 = 3.573F;
			this.Line300.Y2 = 5.131F;
			// 
			// subReport1
			// 
			this.subReport1.CloseBorder = false;
			this.subReport1.Height = 6.38189F;
			this.subReport1.Left = 5.444095F;
			this.subReport1.Name = "subReport1";
			this.subReport1.Report = null;
			this.subReport1.ReportName = "subReport1";
			this.subReport1.Top = 0F;
			this.subReport1.Width = 5.212205F;
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
            this.Label1,
            this.ReportIDText,
            this.Label174,
            this.BaseDateText});
			this.PageHeader.Height = 0.3868056F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Format += new System.EventHandler(this.PageHeader_Format);
			// 
			// Label2
			// 
			this.Label2.Height = 0.2F;
			this.Label2.HyperLink = null;
			this.Label2.Left = 8.6875F;
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
			this.PAGE.Left = 9.260417F;
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
			this.Label3.Left = 9.625F;
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
			this.PAGESUM.Left = 9.6875F;
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
			this.Label4.Left = 8.6875F;
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
			this.DateText.Left = 9.3125F;
			this.DateText.Name = "DateText";
			this.DateText.Style = "font-size: 9pt; text-align: left; white-space: nowrap; ddo-char-set: 1";
			this.DateText.Text = "6666/66/66 66:66:66";
			this.DateText.Top = 0.1875F;
			this.DateText.Width = 1.25F;
			// 
			// Label1
			// 
			this.Label1.Height = 0.25F;
			this.Label1.HyperLink = null;
			this.Label1.Left = 3.5625F;
			this.Label1.Name = "Label1";
			this.Label1.Style = "font-size: 14pt; font-weight: normal; text-align: center; ddo-char-set: 1";
			this.Label1.Text = "個人基本情報";
			this.Label1.Top = 0F;
			this.Label1.Width = 3.5F;
			// 
			// ReportIDText
			// 
			this.ReportIDText.CanGrow = false;
			this.ReportIDText.Height = 0.1875F;
			this.ReportIDText.Left = 0.0625F;
			this.ReportIDText.Name = "ReportIDText";
			this.ReportIDText.Style = "font-size: 9pt; white-space: nowrap; ddo-char-set: 1";
			this.ReportIDText.Text = "(HR_PA_03_R01)";
			this.ReportIDText.Top = 0F;
			this.ReportIDText.Width = 1.6875F;
			// 
			// Label174
			// 
			this.Label174.Height = 0.2F;
			this.Label174.HyperLink = null;
			this.Label174.Left = 8F;
			this.Label174.Name = "Label174";
			this.Label174.Style = "font-size: 9pt; ddo-char-set: 1";
			this.Label174.Text = "現在";
			this.Label174.Top = 0.1875F;
			this.Label174.Width = 0.6875F;
			// 
			// BaseDateText
			// 
			this.BaseDateText.CanGrow = false;
			this.BaseDateText.Height = 0.188F;
			this.BaseDateText.Left = 7.3125F;
			this.BaseDateText.Name = "BaseDateText";
			this.BaseDateText.Style = "font-size: 9pt; text-align: left; white-space: nowrap; ddo-char-set: 1";
			this.BaseDateText.Text = "6666/66/66";
			this.BaseDateText.Top = 0.1875F;
			this.BaseDateText.Width = 0.6875F;
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
			this.CompanyNameText.Height = 0.1875F;
			this.CompanyNameText.Left = 0.4375F;
			this.CompanyNameText.Name = "CompanyNameText";
			this.CompanyNameText.Style = "font-size: 9pt; text-align: right; white-space: nowrap; ddo-char-set: 1";
			this.CompanyNameText.Text = null;
			this.CompanyNameText.Top = 0F;
			this.CompanyNameText.Width = 10.17708F;
			// 
			// HR_PA_03_R01
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
			this.ReportStart += new System.EventHandler(this.HR_PA_03_R01_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.Label144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label106)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClsNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntranceDate1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositTypeNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnAdrs3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnAdrs1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label99)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NameKanaTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexTypeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChgDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip_1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone_1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs1_1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Adrs2_153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreJobRetirDate2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.JobName3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReason4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StrServTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label90)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label91)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label92)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label93)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RELAT1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label94)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label95)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label96)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GrnName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label97)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Relate2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label98)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label100)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label101)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label102)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label103)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label104)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label108)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositReasonTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label109)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IntroTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label110)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label111)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label112)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label114)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label115)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label117)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduYmTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SchoolNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubjNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FacultyNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GraduTypeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DayNightTypeTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FmlyAlowType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label120)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsOfcNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label121)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SocInsOfcNameTextBox178)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsMarkNoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label124)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label125)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndNoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensNoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsNoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label126)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WorkAccInsOfcNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay1TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label127)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label128)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndStandCompsAmtTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensStandCompsAmtTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsStandMonAmtTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndRevYmTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensRevYmTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsRevYmTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label133)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label135)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label136)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensBasePensNoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensBasePensNoSbnoTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CareInsTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TBirthDay7extBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TBirthDay4extBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType7TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType6TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType5TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType4TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType3TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType8TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label146)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Zip_2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Phone_2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Name2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label149)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Relation2TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObtainDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndObtainDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensObtainDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensFndLossDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PensLossDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsLossDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetireReasonTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FamRal9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastName9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexType9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthDay9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LiveTgtType9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employ9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndType9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeltInsObjType9TextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsObtainDateTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmployInsLossDateTextBox309)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label175)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AdrsChgDate2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BirthYmdJPText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InDateJPTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AssocItemNameTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PAGESUM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReportIDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label174)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BaseDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CompanyNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
