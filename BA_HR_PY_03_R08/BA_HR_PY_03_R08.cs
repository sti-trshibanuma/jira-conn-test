// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : BA_HR_PY_03_R08.cs
// 機能名      : HR_PY_03_R08 年末調整支給明細書（A4）
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 1.3.3 2005/06/30
// 管理番号K15531 2005/10/14 画面帳票出力順序
// 1.4.0 2005/10/31
// 管理番号 B17038 2006/02/02 大量印刷帳票(SQLコマンドのタイムアウト)
// 管理番号 K15504 2007/03/01 支給体系ごとの給与明細書設定対応
// 1.5.1 2007/06/30
// 管理番号 K22634 2009/03/05 帳票ディスクキャッシュ対応
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 B24365 2012/04/16 帳票出力時に不要なログが出力される不具合を修正
// 2.0.0 2012/10/31
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30
// 3.1.0 2020/06/30
// 管理番号K27228 2020/10/20 サーバ帳票PDF化
// 管理番号K27445 2022/10/04 ログ管理強化
// 3.2.0 2023/03/31

using System;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Web;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using Infocom.Allegro;
using Infocom.Allegro.BL.SqlClient;
// 管理番号K27228 From
using Infocom.Allegro.CM.MS;
// 管理番号K27228 To
using Infocom.Allegro.IF;
using Infocom.Allegro.HR.rpt;

namespace Infocom.Allegro.HR
{
	public class BA_HR_PY_03_R08
	{
// 管理番号K27228 From
// 未使用のためコメントアウト
//		private static bool EndPrintFlag=false; // 印刷完了フラグ
//		private static GrapeCity.ActiveReports.Extensibility.Printing.Printer doc = new GrapeCity.ActiveReports.Extensibility.Printing.Printer();
// 管理番号K27228 To
		public static int Main(string[] args)
		{
			/*args説明(配列)
			 * 引数1:CompCode
			 * 引数2:ユーザー名
			 * 引数3:レポートコード
			 * 引数4:プリンタ名
			 * 引数5:帳票出力条件（ユニークＩＤ）			
			*/
			//argsのチェック

			if (args.Length!=5)
			{
				//args不正
				return 1;
			}

// 管理番号K27445 From
//			CommonData commonData = new CommonData(args[0],args[1],args[2]);
			CommonData commonData = new CommonData(args[0],args[1],args[2], "batch");
// 管理番号K27445 To
// 管理番号K27228 From
			string reportPrintUniqueId = args[4];
			PrintServerReport pr = new PrintServerReport();
// 管理番号K27228 To
			BL_HR_MS_MycompHR_L mycompHR_L = BL_HR_MS_MycompHR_L.GetInstance();
			BL_HR_MS_MycompHR mycompHR = mycompHR_L.Select(commonData,commonData.CompCode);
			
			try
			{			
// 管理番号K27228 From
//				string[] sKey = args[4].Split("\t".ToCharArray()[0]);
				// 帳票出力処理開始
				pr.Start(commonData, reportPrintUniqueId);
				string[] sKey = pr.GetPrintTerm(commonData, reportPrintUniqueId).Split("\t".ToCharArray()[0]);
// 管理番号K27228 To
// 管理番号K27445 From
				string userHostName = sKey[sKey.Length - 1];
				commonData = new CommonData(args[0], args[1], args[2], userHostName);
// 管理番号K27445 To
	
				//データをIFに格納する。
				IF_HR_MS_ListOutputCondit condition = new IF_HR_MS_ListOutputCondit();
				string sCopyName					= sKey[0].Trim();		//自社名
				condition.EmpCode					= sKey[1].Trim();		//社員番号
				condition.ListType					= sKey[2].Trim();		//帳票区分
				condition.ListCtlId					= sKey[3].Trim();		//帳票制御ID
				condition.OutputOrderCntFlg			= sKey[4].Trim();		//出力順制御フラグ
				condition.AtacCodeFrom				= sKey[5].Trim();		//所属部門コードFrom
				condition.AtacCodeTo				= sKey[6].Trim();		//所属部門コードTo
				condition.EmpCodeFrom				= sKey[7].Trim();		//社員番号From
				condition.EmpCodeTo					= sKey[8].Trim();		//社員番号To
				condition.SocInsOfcCodeFrom			= sKey[9].Trim();		//社保事業所コードFrom
				condition.SocInsOfcCodeTo			= sKey[10].Trim();		//社保事業所コードTo
				condition.BreakMethodLevel			= sKey[11].Trim();		//ブレイク方法フラグ
				condition.BreakMethodAtacLevel		= sKey[12].Trim();		//ブレイク方法所属レベル
				condition.OutputMethodLevel			= sKey[13].Trim();		//出力方法フラグ
				condition.OutputMethodAtacLevel		= sKey[14].Trim();		//出力方法所属レベル
				condition.FractionResvEmpCode1		= sKey[15].Trim();		//個人指定社員番号１
				condition.FractionResvEmpCode2		= sKey[16].Trim();		//個人指定社員番号２
				condition.FractionResvEmpCode3		= sKey[17].Trim();		//個人指定社員番号３
				condition.FractionResvEmpCode4		= sKey[18].Trim();		//個人指定社員番号４
				condition.FractionResvEmpCode5		= sKey[19].Trim();		//個人指定社員番号５
				condition.FractionResvEmpCode6		= sKey[20].Trim();		//個人指定社員番号６
				condition.PaymntSysCode1			= sKey[21].Trim();		//支給体系コード１
				condition.PaymntSysCode2			= sKey[22].Trim();		//支給体系コード２
				condition.PaymntSysCode3			= sKey[23].Trim();		//支給体系コード３
				condition.PaymntSysCode4			= sKey[24].Trim();		//支給体系コード４
				condition.PaymntSysCode5			= sKey[25].Trim();		//支給体系コード５
				condition.PaymntSysCode6			= sKey[26].Trim();		//支給体系コード６
				condition.PaymntGroup1				= sKey[27].Trim();		//支給グループ１
				condition.PaymntGroup2				= sKey[28].Trim();		//支給グループ２
				condition.PaymntGroup3				= sKey[29].Trim();		//支給グループ３
				condition.PaymntGroup4				= sKey[30].Trim();		//支給グループ４
				condition.PaymntGroup5				= sKey[31].Trim();		//支給グループ５
				condition.PaymntGroup6				= sKey[32].Trim();		//支給グループ６
				condition.ExtractResv1CodeFrom		= sKey[33].Trim();		//抽出指定１コードFrom
				condition.ExtractResv1CodeTo		= sKey[34].Trim();		//抽出指定１コードTo
				condition.ExtractResv2CodeFrom		= sKey[35].Trim();		//抽出指定２コードFrom
				condition.ExtractResv2CodeTo		= sKey[36].Trim();		//抽出指定２コードTo
				condition.ExtractResv3CodeFrom		= sKey[37].Trim();		//抽出指定３コードFrom
				condition.ExtractResv3CodeTo		= sKey[38].Trim();		//抽出指定３コードTo
				condition.DateResvYmdFrom			= sKey[39].Trim();		//日付指定年月日From
				condition.DateResvYmdTo				= sKey[40].Trim();		//日付指定年月日To
				condition.DateResvYmFrom			= sKey[41].Trim();		//日付指定年月From
				condition.DateResvYmTo				= sKey[42].Trim();		//日付指定年月To
				condition.DateResvYFrom				= sKey[43].Trim();		//日付指定年度From
				condition.DateResvYTo				= sKey[44].Trim();		//日付指定年度To
				condition.PaymntDayType1			= sKey[45].Trim();		//支給日種別１
				condition.PaymntDayType2			= sKey[46].Trim();		//支給日種別２
				condition.PaymntDayType3			= sKey[47].Trim();		//支給日種別３
				condition.PaymntDayType4			= sKey[48].Trim();		//支給日種別４
				condition.PaymntDayType5			= sKey[49].Trim();		//支給日種別５
				condition.Output					= sKey[50].Trim();		//出力先
				condition.PeriodAtacLevel			= sKey[51].Trim();		//範囲所属部門レベル
// 管理番号K15531 From
				condition.LoginAccount				= sKey[56].Trim();						//ログインアカウント
				condition.ProgramID					= sKey[57].Trim();						//帳票ID
				condition.OutputPatternId			= sKey[58].Trim();						//出力パターンID
				condition.SortPatternId				= string.Empty;							//ソートパターンID
				condition.EmpSearchQuery			= null;									//条件
// 管理番号K15531 To
// 管理番号 B17038 From
				condition.IsServerOutputMode		= true;									//帳票サーバ出力モード
// 管理番号 B17038 To
				//rptのパスを取得
				string getPath=Directory.GetParent(Application.ExecutablePath).ToString() +"\\rpt";
			
				BL_HR_PY_03_R08 blHrPy03R08 = BL_HR_PY_03_R08.GetInstance();
				DataTable detailDt = new DataTable(); 
				try
				{
					//データ取得
					detailDt = blHrPy03R08.Select(commonData, condition, false);
				}
				catch (AllegroException ex)
				{
					AllegroLog.Write(commonData,ExceptionLevel.Error,"サーバー帳票出力エラー：" + ex.Message);
// 管理番号K27228 From
					// 帳票出力処理エラー
					pr.Error(commonData, reportPrintUniqueId);
// 管理番号K27228 To
					return 1;
				}		

				try
				{
					//帳票の定義設定
// 管理番号 K15504 From
//					Infocom.Allegro.HR.rpt.HR_PY_03_R08	rpt01  = new Infocom.Allegro.HR.rpt.HR_PY_03_R08();
					Infocom.Allegro.HR.rpt.HR_PY_03_R61	rpt01  = new Infocom.Allegro.HR.rpt.HR_PY_03_R61();

//					rpt01.Flg = mycompHR.MycompHR.InstSavBrFrdFlg;
// 管理番号 K15504 To
					rpt01.commonData = commonData;
					rpt01.Title = "給与";
// 管理番号 K15504 From
//					rpt01.ReportID = "(HR_PY_03_R08)";
// 管理番号 B24365 From
//					rpt01.ReportID = "(HR_PY_03_R61)";
					rpt01.ReportID = "(HR_PY_03_R08)";
// 管理番号 B24365 To
// 管理番号 K15504 To

					//明細情報の設定
					DataView dv = new DataView(detailDt);
					rpt01.DataSource=dv;

// 管理番号 K22634 From
					// 帳票データの生成
//					rpt01.Run(false);
					// 帳票マスタからキャッシュフラグ及びキャッシュ先を取得
					Allegro.Report.RptCache rc = new Allegro.Report.RptCache(rpt01.ReportID.Replace("(", "").Replace(")",""), commonData);
					// ディスクキャッシュプロパティの設定
					rpt01.Document.CacheToDisk = rc.CacheToDisk;
					if (rc.CacheToDisk == true)
					{
						// ディスクキャッシュ先の指定
						rpt01.Document.CacheToDiskLocation = rc.CacheToDiskLocation;
					}
					try
					{
						// 帳票データの生成
						rpt01.Run(false);	//帳票ディスクキャッシュ対応
// 管理番号K27228 From
//						//印刷する
//						rpt01.Document.Printer.PrinterName = args[3];						//印刷プリンター設定
//						EndPrintFlag = false;
//						doc = rpt01.Document.Printer;
//
//						//終了イベントの定義
//						doc.EndPrint += new System.Drawing.Printing.PrintEventHandler(doc_EndPrint);
//						rpt01.Document.Print(false, false, false);							//印刷処理開始
//
//						while (!EndPrintFlag)											//印刷終了までループ（フラグの制御は終了イベントで行う。）
//						{
//							//終了まで待機
//							Application.DoEvents();
//						}
						// 帳票出力
						pr.OutputReport(commonData, reportPrintUniqueId, rpt01, args[3]);

						// 帳票出力結果登録
						pr.InsertOutputReportFile(commonData, reportPrintUniqueId);

						// 帳票出力処理終了
						pr.End(commonData, reportPrintUniqueId);
// 管理番号K27228 To
					}
					catch (Exception ex)
					{
						// 例外処理
						AllegroLog.Write(commonData, ExceptionLevel.Error, "帳票作成エラー：" + ex.Message);
// 管理番号K27228 From
						// 帳票出力処理エラー
						pr.Error(commonData, reportPrintUniqueId);
// 管理番号K27228 To
						return 1;
					}
					finally
					{
						rpt01.Document.Dispose();
						rpt01.Dispose();
						rpt01 = null;
					}
// 管理番号 K22634 To

				}
				catch(Exception ex)
				{
					AllegroLog.Write(commonData,ExceptionLevel.Error,"サーバー帳票出力エラー：" + ex.Message);
// 管理番号K27228 From
					// 帳票出力処理エラー
					pr.Error(commonData, reportPrintUniqueId);
// 管理番号K27228 To
					return 1;	
				}
			}
			catch(Exception ex)
			{
				AllegroLog.Write(commonData,ExceptionLevel.Error,"サーバー帳票出力エラー"+ex.Message);
// 管理番号K27228 From
				// 帳票出力処理エラー
				pr.Error(commonData, reportPrintUniqueId);
// 管理番号K27228 To
				return 1;
			}
			return 0;
		}
// 管理番号K27228 From
// 未使用のためコメントアウト
//		/// <summary>
//		/// 印刷終了時イベント
//		/// </summary>
//		/// <param name="sender"></param>
//		/// <param name="e"></param>
//		private static void doc_EndPrint( object sender, System.Drawing.Printing.PrintEventArgs e )
//		{
//			//印刷終了時イベント
//			EndPrintFlag = true;
//		}
// 管理番号K27228 To
	}
}
