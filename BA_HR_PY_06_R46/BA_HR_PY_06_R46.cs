// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 06
// File Name   : BA_HR_PY_06_R46.cs
// 機能名      : HR_PY_06_R46 給与支払報告書(A4)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 2.3.0 2016/06/30
// 管理番号K26330 2016/07/29 マイナンバー帳票対応
// 管理番号B26406 2017/01/05 源泉徴収票の摘要欄見切れ
// 3.0.0 2018/04/30
// 3.1.0 2020/06/30
// 管理番号K27228 2020/10/20 サーバ帳票PDF化
// 管理番号K27445 2022/08/26 ログ管理強化
// 3.2.0 2023/03/31

using System;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Web;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using Infocom.Allegro;
using Infocom.Allegro.BL.SqlClient;
using Infocom.Allegro.CM.MS;
using Infocom.Allegro.IF;
using Infocom.Allegro.HR.rpt;

namespace Infocom.Allegro.HR
{
	public class BA_HR_PY_06_R46
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
			// 帳票出力条件取得用のため、ユーザーホスト名は"batch"固定
			CommonData commonData = new CommonData(args[0],args[1],args[2], "batch");
// 管理番号K27445 To

// 管理番号K27228 From
			string reportPrintUniqueId = args[4];
			PrintServerReport pr = new PrintServerReport();
// 管理番号K27228 To
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
				condition.LoginAccount				= sKey[56].Trim();		//ログインアカウント
				condition.ProgramID					= sKey[57].Trim();		//帳票ID
				condition.OutputPatternId			= sKey[58].Trim();		//出力パターンID
				condition.MyNumberOutputFlg			= sKey[59].Trim();		//個人番号使用フラグ
				condition.SortPatternId				= string.Empty;			//ソートパターンID
				condition.EmpSearchQuery			= null;					//条件
				condition.IsServerOutputMode		= true;					//帳票サーバ出力モード

				//rptのパスを取得
				string getPath=Directory.GetParent(Application.ExecutablePath).ToString() +"\\rpt";

				BL_HR_PY_06_R21 blHrPy06R21 = BL_HR_PY_06_R21.GetInstance();

				DataTable detailDt = new DataTable();

				DataTable retDt = new DataTable();
				int ylyEdCalYear = 0;
				if (
					(condition.DateResvYFrom != null)
					&& (condition.DateResvYFrom.Length > 0)
				)
				{
					ylyEdCalYear = int.Parse(condition.DateResvYFrom);
				}

				condition.ExclusiveFlg = "0";	// 専用紙フラグ

				// 帳票出力対象となる年調年度が2015年以前の場合はマイナンバー対応前のレイアウトで出力
				if (ylyEdCalYear <= 2015)
				{
					condition.SummaryWideWidth = 95;	// 摘要欄(広域)横幅
					condition.SummaryWidth = 56;		// 摘要欄横幅
					condition.SummaryHight = 7;			// 摘要欄縦幅
				}
				else
				{
// 管理番号B26406 From
//					condition.SummaryWideWidth = 65;	// 摘要欄(広域)横幅
//					condition.SummaryWidth = 65;		// 摘要欄横幅
//					condition.SummaryHight = 5;			// 摘要欄縦幅
					condition.SummaryWideWidth = 131;	// 摘要欄(広域)横幅
					condition.SummaryWidth = 131;		// 摘要欄横幅
					condition.SummaryHight = 6;			// 摘要欄縦幅
// 管理番号B26406 To
				}

				try
				{
					//データ取得
					retDt = blHrPy06R21.Select(commonData, condition, false);
					detailDt = ((DataTable)retDt.Rows[0]["HRPY06R21"]).Copy();
					foreach (DataRow dr in detailDt.Rows)
					{
						dr["PAYMNT_AMT"] = (dr["PAYMNT_AMT"].ToString().StartsWith("-") ? 0 : dr["PAYMNT_AMT"]);
					}
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
					// 帳票出力対象となる年調年度が2015年以前の場合はマイナンバー対応前のレイアウトで出力
					if (ylyEdCalYear <= 2015)
					{
						Infocom.Allegro.HR.rpt.HR_PY_03_R64 rpt01 = new Infocom.Allegro.HR.rpt.HR_PY_03_R64();

						// プロパティによるヘッダ情報の設定
						rpt01.commonData = commonData;
						rpt01.ReportID = "(HR_PY_06_R46)";
						rpt01.CompanyName = sCopyName;

						//明細情報の設定
						DataView dv = new DataView(detailDt);
						rpt01.DataSource = dv;

						// 帳票マスタからキャッシュフラグ及びキャッシュ先を取得
						Allegro.Report.RptCache rc = new Allegro.Report.RptCache(rpt01.ReportID.Replace("(", "").Replace(")", ""), commonData);
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
//							//印刷する
//							rpt01.Document.Printer.PrinterName = args[3];						//印刷プリンター設定
//							EndPrintFlag = false;
//							doc = rpt01.Document.Printer;
//
//							//終了イベントの定義
//							doc.EndPrint += new System.Drawing.Printing.PrintEventHandler(doc_EndPrint);
//							rpt01.Document.Print(false, false, false);							//印刷処理開始
//
//							while (!EndPrintFlag)											//印刷終了までループ（フラグの制御は終了イベントで行う。）
//							{
//								//終了まで待機
//								Application.DoEvents();
//							}
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
					}
					// 帳票出力対象となる年調年度が2016年以降の場合はマイナンバー対応後のレイアウトで出力
					else
					{
						Infocom.Allegro.HR.rpt.HR_PY_03_R63 rpt02 = new Infocom.Allegro.HR.rpt.HR_PY_03_R63();

						// プロパティによるヘッダ情報の設定
						rpt02.commonData = commonData;
						rpt02.ReportID = "(HR_PY_06_R46)";
						rpt02.CompanyName = sCopyName;


						IF_CM_MS_MyNumber logParam = new IF_CM_MS_MyNumber();
						DataRow dr;

						// 画面操作用アクセスログパラメータ設定
						dr = logParam.AccessLogDt.NewRow();
						dr["LOGIN_ACCOUNT"] = condition.LoginAccount;
						dr["EMP_CODE"] = condition.EmpCode;
						dr["REMOTE_ADDR"] = Dns.GetHostAddresses(Dns.GetHostName())[0];
						dr["REMOTE_USER"] = Dns.GetHostName();
						logParam.AccessLogDt.Rows.Add(dr);
						logParam.AccessLogDt.AcceptChanges();


						// 個人番号を使用する場合のみ設定
						if (condition.MyNumberOutputFlg == "1")
						{
							// 本人の個人番号設定
							blHrPy06R21.SetEmpMyNumber(
								commonData
								, detailDt
								, logParam
							);
						}

						// 家族情報の取得（個人番号含む）
						blHrPy06R21.SetFmlyMyNumber(
							commonData
							, detailDt
							, ((DataTable)retDt.Rows[0]["HRPY06R21FMLY"])
							, condition.MyNumberOutputFlg
							, logParam
							, "2"	// 給与支払報告書
						);


						//明細情報の設定
						DataView dv = new DataView(detailDt);
						rpt02.DataSource = dv;

						// 帳票マスタからキャッシュフラグ及びキャッシュ先を取得
						Allegro.Report.RptCache rc = new Allegro.Report.RptCache(rpt02.ReportID.Replace("(", "").Replace(")", ""), commonData);
						// ディスクキャッシュプロパティの設定
						rpt02.Document.CacheToDisk = rc.CacheToDisk;
						if (rc.CacheToDisk == true)
						{
							// ディスクキャッシュ先の指定
							rpt02.Document.CacheToDiskLocation = rc.CacheToDiskLocation;
						}
						try
						{
							// 帳票データの生成
							rpt02.Run(false);	//帳票ディスクキャッシュ対応
// 管理番号K27228 From
//							//印刷する
//							rpt02.Document.Printer.PrinterName = args[3];						//印刷プリンター設定
//							EndPrintFlag = false;
//							doc = rpt02.Document.Printer;
//
//							//終了イベントの定義
//							doc.EndPrint += new System.Drawing.Printing.PrintEventHandler(doc_EndPrint);
//							rpt02.Document.Print(false, false, false);							//印刷処理開始
//
//							while (!EndPrintFlag)											//印刷終了までループ（フラグの制御は終了イベントで行う。）
//							{
//								//終了まで待機
//								Application.DoEvents();
//							}
							// 帳票出力
							pr.OutputReport(commonData, reportPrintUniqueId, rpt02, args[3]);

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
							rpt02.Document.Dispose();
							rpt02.Dispose();
							rpt02 = null;
						}
					}
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
