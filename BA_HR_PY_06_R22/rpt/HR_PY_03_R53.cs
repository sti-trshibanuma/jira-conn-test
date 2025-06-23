// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R53.cs
// 機能名      : HR_PY_03_R53 退職者用源泉徴収票(専用)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 1.0.0 2004/04/01
// 1.4.0 2005/10/31
// 管理番号 B17652 2006/05/25 給与支払報告書(前職会社住所追加)
// 1.5.2 2007/10/31
// 管理番号 B21040 2007/12/04 源泉徴収票用紙タイプ選択機能追加
// 管理番号 K21502 2009/03/31 .NETバージョンアップ
// 1.6.0 2009/09/30
// 管理番号 K23122 2009/11/20 平成２１年度税制改正対応
// 管理番号 K23940 2012/04/16 平成２２年度税制改正対応
// 管理番号 K24565 2012/06/06 ActiveReportsバージョンアップ対応
// 2.0.0 2012/10/31
// 管理番号 K24060 2012/11/15 法改正対応（介護医療保険料控除）に伴う源泉徴収票のレイアウト変更
// 2.2.0 2014/10/31
// 管理番号 K25928 2015/08/10 ActiveReports9バージョンアップ対応
// 2.3.0 2016/06/30
// 管理番号K26355 2016/12/09 マイナンバー帳票対応（源泉徴収票専用紙）
// 3.0.0 2018/04/30
// 管理番号K27147 2020/04/01 中途就・退職の年を印字(2019年のみ)
// 3.1.0 2020/06/30
// 管理番号K27275 2021/06/11 住宅借入金等特別控除（特別特定取得）対応
// 管理番号K27274 2021/06/11 年末調整関連法改正(令和２年)
// 管理番号K27583 2023/01/23 住宅借入金等特別控除の控除区分追加
// 3.2.0 2023/03/31
// 管理番号K27665 2023/07/11 ActiveReportsバージョンアップ（SP4）対応

using System;
using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;
using System.Globalization;

namespace Infocom.Allegro.HR.rpt
{
	public class HR_PY_03_R53 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R53()
		{


			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
		protected CommonData cd;
// 管理番号K26355 From
// ---------------------------------------------------------------------------------------------
// 帳票用のオブジェクト自動生成の変数はFromTo対象外なため、本対応にて全てコメント化し、
// FromToの外に配置する。
// 自動生成箇所の変数宣言でFromToが必要なのは明示的に宣言した変数のみとする。
// ---------------------------------------------------------------------------------------------
//// 管理番号 K23940 From
//		protected string ylyEdCalYear;
//		private TextBox youngDpndNumText;
//// 管理番号 K23940 To
//// 管理番号 K24060 From
//		private TextBox newLifeInsPensAmtText;
//		private TextBox summaryDigitText;
//		private TextBox newLifeInsCareAmtText;
//		private TextBox newLifeInsGeneralAmtText;
//		private TextBox lifeInsGeneralAmtText;
//// 管理番号 K24060 To
		protected string ylyEdCalYear;
// 管理番号K26355 To
        private TextBox YngDpndRemarksText1;
        private TextBox DpndRemarksText1;
        private TextBox CorpNumber1_4;
        private TextBox CorpNumber1_3;
        private TextBox CorpNumber1_2;
        private TextBox CorpNumber1_1;
        private TextBox ylyEdAddress1_1Text;
        private TextBox empCodeText;
        private TextBox postNameText;
        private TextBox empNameKanaText;
        private TextBox classText;
        private TextBox paymntAmtText;
        private TextBox slryInsmDedAmtText;
        private TextBox ylyCollectTaxText;
        private TextBox sposOldAgeTypeText;
        private TextBox dedSposExistText;
        private TextBox dedSposExist2Text;
        private TextBox sposExtDedAmtText;
        private TextBox specDpndNum1_1Text;
        private TextBox specDpndNum2_1Text;
        private TextBox liveTgtAgePreNumText;
        private TextBox agePreNumText;
        private TextBox agePreNum2Text;
        private TextBox othersDpndNumText;
        private TextBox othersDpndNum2Text;
        private TextBox liveTgtExtHandiNumText;
        private TextBox extHndiNumText;
        private TextBox HandiNumText;
        private TextBox smlScaleCompCpratAmtText;
        private TextBox lifeInsDedAmtText;
        private TextBox TextBox454;
        private TextBox sponSumIncmAmtText;
        private TextBox LifeInsPensAmtText;
        private TextBox nolfInsLongProdAmtText;
        private TextBox empNameText;
        private TextBox minrTypeText;
        private TextBox latterText;
        private TextBox extHandiTypeText;
        private TextBox handiTypeText;
        private TextBox widowTypeText;
        private TextBox extWidowTypeText;
        private TextBox widomTypeText;
        private TextBox wrkStdTypeText;
        private TextBox paymntAddressText;
        private TextBox paymntNameText;
        private TextBox paymntPhoneText;
        private TextBox nolfInsDedAmtText;
        private TextBox deathRetireTypeText;
        private TextBox disasterTypeText;
        private TextBox foreignTypeText;
        private TextBox halfEmployTypeText;
        private TextBox halfRetireTypeText;
        private TextBox halfEmReDateYearText;
        private TextBox halfEmReFateMonthText;
        private TextBox halfEmReDateDayText;
        private TextBox birthNameOfEraText;
        private TextBox birthDayYearText;
        private TextBox birthDayMonthText;
        private TextBox birthDayDayText;
        private TextBox socInsDedAmtText;
        private TextBox summary0Digit0Text;
        private TextBox newLifeInsPensAmtText;
        private TextBox newLifeInsCareAmtText;
        private TextBox newLifeInsGeneralAmtText;
        private TextBox lifeInsGeneralAmtText;
        private TextBox summary1Digit0Text;
        private TextBox YoungDpndNumText;
        private TextBox NonResidentNumText;
        private TextBox HousingObtDedPsblAmtText;
        private TextBox HousingMovingDateYText;
        private TextBox HousingMovingDate2YText;
        private TextBox HousingMovingDateMText;
        private TextBox HousingMovingDate2MText;
        private TextBox HousingMovingDateDText;
        private TextBox HousingMovingDate2DText;
        private TextBox HousingMovingDateText;
        private TextBox HousingMovingDate2Text;
        private TextBox SpecDedTypeText;
        private TextBox SpecDedType2Text;
        private TextBox EyLoanBalanceText;
        private TextBox EyLoanBalance2Text;
        private TextBox NationalPensPremText;
        private TextBox SposNonResTypeText;
        private TextBox DpndNonResType1_Text;
        private TextBox SposNameKana_Text;
        private TextBox SposName_Text;
        private TextBox DpndNameKana1_Text;
        private TextBox DpndName1_Text;
        private TextBox DpndNameKana2_Text;
        private TextBox DpndName2_Text;
        private TextBox DpndNonResType2_Text;
        private TextBox DpndNameKana3_Text;
        private TextBox DpndName3_Text;
        private TextBox DpndNonResType3_Text;
        private TextBox DpndNameKana4_Text;
        private TextBox DpndName4_Text;
        private TextBox DpndNonResType4_Text;
        private TextBox YngDpndNameKana1_Text;
        private TextBox YngDpndName1_Text;
        private TextBox YngDpndNonRexType1_Text;
        private TextBox YngDpndName2_Text;
        private TextBox YngDpndNameKana2_Text;
        private TextBox YngDpndNonRexType2_Text;
        private TextBox YngDpndName3_Text;
        private TextBox YngDpndNameKana3_Text;
        private TextBox YngDpndNonRexType3_Text;
        private TextBox YngDpndNameKana4_Text;
        private TextBox YngDpndName4_Text;
        private TextBox YngDpndNonRexType4_Text;
        private TextBox HousingObtDedCntText;
        private TextBox MyNumber1_3Text;
        private TextBox MyNumber1_2Text;
        private TextBox MyNumber1_1Text;
        private TextBox SposMyNumber1_1Text;
        private TextBox SposMyNumber1_2Text;
        private TextBox SposMyNumber1_3Text;
        private TextBox DpndMyNumber1_1_1Text;
        private TextBox DpndMyNumber1_1_2Text;
        private TextBox DpndMyNumber1_1_3Text;
        private TextBox DpndMyNumber1_2_1Text;
        private TextBox DpndMyNumber1_2_2Text;
        private TextBox DpndMyNumber1_2_3Text;
        private TextBox DpndMyNumber1_3_1Text;
        private TextBox DpndMyNumber1_3_2Text;
        private TextBox DpndMyNumber1_3_3Text;
        private TextBox DpndMyNumber1_4_1Text;
        private TextBox DpndMyNumber1_4_2Text;
        private TextBox DpndMyNumber1_4_3Text;
        private TextBox YngDpndMyNumber1_4_3Text;
        private TextBox YngDpndMyNumber1_1_1Text;
        private TextBox YngDpndMyNumber1_1_2Text;
        private TextBox YngDpndMyNumber1_1_3Text;
        private TextBox YngDpndMyNumber1_2_1Text;
        private TextBox YngDpndMyNumber1_2_2Text;
        private TextBox YngDpndMyNumber1_2_3Text;
        private TextBox YngDpndMyNumber1_3_1Text;
        private TextBox YngDpndMyNumber1_3_2Text;
        private TextBox YngDpndMyNumber1_3_3Text;
        private TextBox YngDpndMyNumber1_4_1Text;
        private TextBox YngDpndMyNumber1_4_2Text;
        private TextBox SposMyNumber_Text;
        private TextBox DpndMyNumber1_Text;
        private TextBox DpndMyNumber2_Text;
        private TextBox DpndMyNumber3_Text;
        private TextBox DpndMyNumber4_Text;
        private TextBox MyNumber_Text;
        private TextBox YngDpndMyNumber1_Text;
        private TextBox YngDpndMyNumber4_Text;
        private TextBox YngDpndMyNumber3_Text;
        private TextBox YngDpndMyNumber2_Text;
        private TextBox CorpNumber;
        private TextBox incmDedAmtSumText;
		private TextBox incmAdjDedAmtText1;

// 管理番号 B21040 From
		protected string withHoldingSlipOutputFlg;
// 管理番号 B21040 To

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
// 管理番号 B21040 From
		public string WithHoldingSlipOutputFlg
		{
			get { return withHoldingSlipOutputFlg; }
			set { withHoldingSlipOutputFlg = value; }
		}
// 管理番号 B21040 To
// 管理番号 K23940 From
		public string YlyEdCalYear
		{
			get { return ylyEdCalYear; }
			set { ylyEdCalYear = value; }
		}
// 管理番号 K23940 To
		#endregion

		private void HR_PY_03_R53_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName = "";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;

// 管理番号 B21040 From
			if (withHoldingSlipOutputFlg != null && withHoldingSlipOutputFlg.Length > 0)
			{
				if (withHoldingSlipOutputFlg == "0")
				{
					this.Detail.ColumnCount = 2;
				}
				else
				{
// 管理番号K26355 From
//					this.PrintWidth = (float)8.27;
//					this.Detail.Height = (float)3.96;
					this.PrintWidth = (float)5.51;
					this.Detail.Height = (float)8.36;
// 管理番号K26355 To
					this.Detail.ColumnCount = 1;
					this.Detail.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
				}
			}
// 管理番号 B21040 To


//			DateText.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
// 管理番号K27147 From
			if (this.YlyEdCalYear == "2019")
			{
				// 2019年のみ和暦年を表示する
				// それ以外は原紙にプレ印字されている
				halfEmReDateYearText.Visible = true;
			}
// 管理番号K27147 To
		}

		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
//			ReportIDText.Text=reportID;
		}

		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
//			CompanyNameText.Text=companyName;
		}



		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{

		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
//			JapaneseCalendar ca = new JapaneseCalendar();
//			string [] gg = { "明治", "大正", "昭和", "平成" };
//			string YlyEdCalYear = YlyEdCalYear3Text.Text + "/12" + "/31"; 
//
//			
//			if (YlyEdCalYear3Text.Text.Length != 0)
//			{
//				DateTime dt = DateTime.Parse(YlyEdCalYear);
//				if(ca.GetYear(dt) < 10)
//				{
//					YlyEdCalYear4Text.Text = string.Format("{0} {1}年",
//						gg[ca.GetEra(dt)-1],
//						ca.GetYear(dt));
//				}
//				else
//				{
//					YlyEdCalYear4Text.Text = string.Format("{0}{1}年",
//						gg[ca.GetEra(dt)-1],
//						ca.GetYear(dt));
//				}
//			}
// 管理番号K26355 From
			HousingMovingDateYText.Text = "";
			HousingMovingDateMText.Text = "";
			HousingMovingDateDText.Text = "";

			HousingMovingDate2YText.Text = "";
			HousingMovingDate2MText.Text = "";
			HousingMovingDate2DText.Text = "";

			MyNumber1_1Text.Text = "";
			MyNumber1_2Text.Text = "";
			MyNumber1_3Text.Text = "";

			SposMyNumber1_1Text.Text = "";
			SposMyNumber1_2Text.Text = "";
			SposMyNumber1_3Text.Text = "";

			DpndMyNumber1_1_1Text.Text = "";
			DpndMyNumber1_1_2Text.Text = "";
			DpndMyNumber1_1_3Text.Text = "";
			DpndMyNumber1_2_1Text.Text = "";
			DpndMyNumber1_2_2Text.Text = "";
			DpndMyNumber1_2_3Text.Text = "";
			DpndMyNumber1_3_1Text.Text = "";
			DpndMyNumber1_3_2Text.Text = "";
			DpndMyNumber1_3_3Text.Text = "";
			DpndMyNumber1_4_1Text.Text = "";
			DpndMyNumber1_4_2Text.Text = "";
			DpndMyNumber1_4_3Text.Text = "";

			YngDpndMyNumber1_1_1Text.Text = "";
			YngDpndMyNumber1_1_2Text.Text = "";
			YngDpndMyNumber1_1_3Text.Text = "";
			YngDpndMyNumber1_2_1Text.Text = "";
			YngDpndMyNumber1_2_2Text.Text = "";
			YngDpndMyNumber1_2_3Text.Text = "";
			YngDpndMyNumber1_3_1Text.Text = "";
			YngDpndMyNumber1_3_2Text.Text = "";
			YngDpndMyNumber1_3_3Text.Text = "";
			YngDpndMyNumber1_4_1Text.Text = "";
			YngDpndMyNumber1_4_2Text.Text = "";
			YngDpndMyNumber1_4_3Text.Text = "";

			CorpNumber1_1.Text = "";
			CorpNumber1_2.Text = "";
			CorpNumber1_3.Text = "";
			CorpNumber1_4.Text = "";

			JapaneseCalendar ca = new JapaneseCalendar();

			// 居住開始年月日1
			if (HousingMovingDateText.Text.Length != 0)
			{
				DateTime hmDt = DateTime.Parse(HousingMovingDateText.Text);
				HousingMovingDateYText.Text = ca.GetYear(hmDt).ToString();
				HousingMovingDateMText.Text = ca.GetMonth(hmDt).ToString();
				HousingMovingDateDText.Text = ca.GetDayOfMonth(hmDt).ToString();
			}

			// 居住開始年月日2
			if (HousingMovingDate2Text.Text.Length != 0)
			{
				DateTime hm2Dt = DateTime.Parse(HousingMovingDate2Text.Text);
				HousingMovingDate2YText.Text = ca.GetYear(hm2Dt).ToString();
				HousingMovingDate2MText.Text = ca.GetMonth(hm2Dt).ToString();
				HousingMovingDate2DText.Text = ca.GetDayOfMonth(hm2Dt).ToString();
			}

			// 個人番号
			if ((MyNumber_Text.Text != null) && (MyNumber_Text.Text.Length == 12))
			{
				MyNumber1_1Text.Text = MyNumber_Text.Text.Substring(0, 4);
				MyNumber1_2Text.Text = MyNumber_Text.Text.Substring(4, 4);
				MyNumber1_3Text.Text = MyNumber_Text.Text.Substring(8, 4);
			}

			// 配偶者個人番号
			if ((SposMyNumber_Text.Text != null) && (SposMyNumber_Text.Text.Length == 12))
			{
				SposMyNumber1_1Text.Text = SposMyNumber_Text.Text.Substring(0, 4);
				SposMyNumber1_2Text.Text = SposMyNumber_Text.Text.Substring(4, 4);
				SposMyNumber1_3Text.Text = SposMyNumber_Text.Text.Substring(8, 4);
			}

			// 扶養親族1
			if ((DpndMyNumber1_Text.Text != null) && (DpndMyNumber1_Text.Text.Length == 12))
			{
				DpndMyNumber1_1_1Text.Text = DpndMyNumber1_Text.Text.Substring(0, 4);
				DpndMyNumber1_1_2Text.Text = DpndMyNumber1_Text.Text.Substring(4, 4);
				DpndMyNumber1_1_3Text.Text = DpndMyNumber1_Text.Text.Substring(8, 4);
			}
			// 扶養親族2
			if ((DpndMyNumber2_Text.Text != null) && (DpndMyNumber2_Text.Text.Length == 12))
			{
				DpndMyNumber1_2_1Text.Text = DpndMyNumber2_Text.Text.Substring(0, 4);
				DpndMyNumber1_2_2Text.Text = DpndMyNumber2_Text.Text.Substring(4, 4);
				DpndMyNumber1_2_3Text.Text = DpndMyNumber2_Text.Text.Substring(8, 4);
			}
			// 扶養親族3
			if ((DpndMyNumber3_Text.Text != null) && (DpndMyNumber3_Text.Text.Length == 12))
			{
				DpndMyNumber1_3_1Text.Text = DpndMyNumber3_Text.Text.Substring(0, 4);
				DpndMyNumber1_3_2Text.Text = DpndMyNumber3_Text.Text.Substring(4, 4);
				DpndMyNumber1_3_3Text.Text = DpndMyNumber3_Text.Text.Substring(8, 4);
			}
			// 扶養親族4
			if ((DpndMyNumber4_Text.Text != null) && (DpndMyNumber4_Text.Text.Length == 12))
			{
				DpndMyNumber1_4_1Text.Text = DpndMyNumber4_Text.Text.Substring(0, 4);
				DpndMyNumber1_4_2Text.Text = DpndMyNumber4_Text.Text.Substring(4, 4);
				DpndMyNumber1_4_3Text.Text = DpndMyNumber4_Text.Text.Substring(8, 4);
			}

			// 16歳未満親族1
			if ((YngDpndMyNumber1_Text.Text != null) && (YngDpndMyNumber1_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_1_1Text.Text = YngDpndMyNumber1_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_1_2Text.Text = YngDpndMyNumber1_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_1_3Text.Text = YngDpndMyNumber1_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族2
			if ((YngDpndMyNumber2_Text.Text != null) && (YngDpndMyNumber2_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_2_1Text.Text = YngDpndMyNumber2_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_2_2Text.Text = YngDpndMyNumber2_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_2_3Text.Text = YngDpndMyNumber2_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族3
			if ((YngDpndMyNumber3_Text.Text != null) && (YngDpndMyNumber3_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_3_1Text.Text = YngDpndMyNumber3_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_3_2Text.Text = YngDpndMyNumber3_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_3_3Text.Text = YngDpndMyNumber3_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族4
			if ((YngDpndMyNumber4_Text.Text != null) && (YngDpndMyNumber4_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_4_1Text.Text = YngDpndMyNumber4_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_4_2Text.Text = YngDpndMyNumber4_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_4_3Text.Text = YngDpndMyNumber4_Text.Text.Substring(8, 4);
			}

			// 法人番号
			if ((CorpNumber.Text != null) && (CorpNumber.Text.Length == 13))
			{
				CorpNumber1_1.Text = CorpNumber.Text.Substring(0, 1);
				CorpNumber1_2.Text = CorpNumber.Text.Substring(1, 4);
				CorpNumber1_3.Text = CorpNumber.Text.Substring(5, 4);
				CorpNumber1_4.Text = CorpNumber.Text.Substring(9, 4);
			}
// 管理番号K26355 To
		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
// 管理番号K26355 From
//// 管理番号 K23940 From
//			if (Decimal.Parse(this.YlyEdCalYear) < 2011)
//			{
//				//対象年度が平成２２年度以前は旧レイアウトで表示
//				//未成年者
//				minrTypeText.Width = 0.188F;
//				minrTypeText.Left = 0.188F;
//				//乙欄
//				latterText.Width = 0.25F;
//				latterText.Left = 0.375F;
//				//特別障害
//				extHandiTypeText.Width = 0.197F;
//				extHandiTypeText.Left = 0.656F;
//				//一般障害
//				HandiTypeText.Width = 0.234F;
//				HandiTypeText.Left = 0.859F;
//				//一般寡婦
//				widowTypeText.Width = 0.2F;
//				widowTypeText.Left = 1.125F;
//				//特別寡婦
//				extWidowTypeText.Width = 0.2F;
//				extWidowTypeText.Left = 1.341F;
//				//寡夫
//				widomTypeText.Width = 0.192F;
//				widomTypeText.Left = 1.572F;
//				//勤労学生
//				wekStdTypeText.Width = 0.192F;
//				wekStdTypeText.Left = 1.788F;
//				//死亡退職
//				DeathRetireTypeText.Width = 0.192F;
//				DeathRetireTypeText.Left = 2.05F;
//				//災害者
//				disasterTypeText.Width = 0.192F;
//				disasterTypeText.Left = 2.281F;
//				//外国人
//				foreiginTypeText.Width = 0.194F;
//				foreiginTypeText.Left = 2.481F;
//				//年少扶養
//				youngDpndNumText.Visible = false;
//			}
//			else
//			{
//				//対象年度が平成２３年度以降は新レイアウトで表示
//				//未成年者
//				minrTypeText.Width = 0.212F;
//				minrTypeText.Left = 0.375F;
//				//乙欄
//				latterText.Width = 0.212F;
//				latterText.Left = 1.25F;
//				//特別障害
//				extHandiTypeText.Width = 0.212F;
//				extHandiTypeText.Left = 1.438F;
//				//一般障害
//				HandiTypeText.Width = 0.212F;
//				HandiTypeText.Left = 1.625F;
//				//一般寡婦
//				widowTypeText.Width = 0.212F;
//				widowTypeText.Left = 1.875F;
//				//特別寡婦
//				extWidowTypeText.Width = 0.212F;
//				extWidowTypeText.Left = 2.063F;
//				//寡夫
//				widomTypeText.Width = 0.212F;
//				widomTypeText.Left = 2.313F;
//				//勤労学生
//				wekStdTypeText.Width = 0.212F;
//				wekStdTypeText.Left = 2.5F;
//				//死亡退職
//				DeathRetireTypeText.Width = 0.212F;
//				DeathRetireTypeText.Left = 0.813F;
//				//災害者
//				disasterTypeText.Width = 0.212F;
//				disasterTypeText.Left = 1F;
//				//外国人
//				foreiginTypeText.Width = 0.212F;
//				foreiginTypeText.Left = 0.625F;
//			}
//// 管理番号 K23940 To
// 管理番号K26355 To
// 管理番号 K23122 From
//			if(PreJobSlryBnsAmt1Text.Text == null)
//			{
//				PreJobSlryBnsAmt1Text.Text = "";
//			}
//			if(PreJobSlryBnsAmt1Text.Text.Length != 0)
//			{
//				Label1096.Visible = true;
//				Label1097.Visible = true;
//				Label1100.Visible = true;
//				//Label247.Visible = true;
//				//Label248.Visible = true;
//				//Label251.Visible = true;
//				//Label1240.Visible = true;
//				//Label1241.Visible = true;
//				//Label1244.Visible = true;
//				//Label1529.Visible = true;
//				//Label1530.Visible = true;
//				//Label1533.Visible = true;
//			}
//			else
//			{
//				Label1096.Visible = false;
//				Label1097.Visible = false;
//				Label1100.Visible = false;
//				//Label247.Visible = false;
//				//Label248.Visible = false;
//				//Label251.Visible = false;
//				//Label1240.Visible = false;
//				//Label1241.Visible = false;
//				//Label1244.Visible = false;
//				//Label1529.Visible = false;
//				//Label1530.Visible = false;
//				//Label1533.Visible = false;
//			}
//
//			if(PreJobTax1Text.Text == null)
//			{
//				PreJobTax1Text.Text = "";
//			}
//				if(PreJobTax1Text.Text.Length != 0)
//				{
//					Label1096.Visible = true;
//					Label1098.Visible = true;
//					Label1101.Visible = true;
////					Label247.Visible = true;
////					Label249.Visible = true;
////					Label252.Visible = true;
////					Label1240.Visible = true;
////					Label1242.Visible = true;
////					Label1245.Visible = true;
////					Label1529.Visible = true;
////					Label1531.Visible = true;
////					Label1534.Visible = true;
//				}
//				else
//				{
//					Label1098.Visible = false;
//					Label1101.Visible = false;
////					Label249.Visible = false;
////					Label252.Visible = false;
////					Label1242.Visible = false;
////					Label1245.Visible = false;
////					Label1531.Visible = false;
////					Label1534.Visible = false;
//				}
//
//			if(PreJobSocInsAmt1Text.Text == null)
//			{
//				PreJobSocInsAmt1Text.Text = "";
//			}
//				if(PreJobSocInsAmt1Text.Text.Length != 0)
//				{
//					Label1096.Visible = true;
//					Label1099.Visible = true;
//					Label1102.Visible = true;
////					Label247.Visible = true;
////					Label250.Visible = true;
////					Label253.Visible = true;
////					Label1240.Visible = true;
////					Label1243.Visible = true;
////					Label1246.Visible = true;
////					Label1529.Visible = true;
////					Label1532.Visible = true;
////					Label1535.Visible = true;
//				}
//				else
//				{
//					Label1099.Visible = false;
//					Label1102.Visible = false;
////					Label250.Visible = false;
////					Label253.Visible = false;
////					Label1243.Visible = false;
////					Label1246.Visible = false;
////					Label1532.Visible = false;
////					Label1535.Visible = false;
//				}
// 管理番号 K23122 To
//			if(TextBox126.Text.Length != 0)
//			{
//				Label389.Visible = true;
//				Label390.Visible = true;
//				Label391.Visible = true;
//				Label392.Visible = true;
//				Label393.Visible = true;
//				Label394.Visible = true;
//				Label395.Visible = true;
//			}
//			else
//			{
//				Label389.Visible = false;
//				Label390.Visible = false;
//				Label391.Visible = false;
//				Label392.Visible = false;
//				Label393.Visible = false;
//				Label394.Visible = false;
//				Label395.Visible = false;
//			}
//			//年調納付地コード重複データは非表示にする。
//			if (ylyEdPaymntPlCodeText.Text != ylyEdPaymntPlCode)
//			{
//				ylyEdPaymntPlCodeText.Visible = true;
//			} 
//			else
//			{
//				ylyEdPaymntPlCodeText.Visible = false;
//			}
//
//			//納付地名重複データは非表示にする。
//			if (paymntPlNameText.Text != paymntPlName)
//			{
//				paymntPlNameText.Visible = true;
//			} 
//			else
//			{
//				paymntPlNameText.Visible = false;
//			}
//
//			ylyEdPaymntPlCode = ylyEdPaymntPlCodeText.Text;
//			paymntPlName = paymntPlNameText.Text;
//
//			if(empCode1Text.Text == null)
//			{
//				empCode1Text.Text = "";
//			}
//		    if(empCode1Text.Text.Length != 0)
//			{
//				EmpNum = EmpNum + 1;
//			}
//
//			if(empCode2Text.Text == null)
//			{
//				empCode2Text.Text = "";
//			}
//			if(empCode2Text.Text.Length != 0)
//			{
//				EmpNum = EmpNum + 1;
//			}
//
//			if(empCode3Text.Text == null)
//			{
//				empCode3Text.Text = "";
//			}
//			if(empCode3Text.Text.Length != 0)
//			{
//				EmpNum = EmpNum + 1;
//			}
//
//			if(empCode4Text.Text == null)
//			{
//				empCode4Text.Text = "";
//			}
//			if(empCode4Text.Text.Length != 0)
//			{
//				EmpNum = EmpNum + 1;
//			}
//
//			if(empCode5Text.Text == null)
//			{
//				empCode5Text.Text = "";
//			}
//			if(empCode5Text.Text.Length != 0)
//			{
//				EmpNum = EmpNum + 1;
//			}

//			if((empcode2Text.Text != "" ) && (empcode2Text.Text != null))
//			{
//				EmpNum = EmpNum + 1;
//			}
//			
//			if((empcode3Text.Text != "" ) && (empcode3Text.Text != null))
//			{
//				EmpNum = EmpNum + 1;
//			}
//			
//			if((empcode4Text.Text != "" ) && (empcode4Text.Text != null))
//			{
//				EmpNum = EmpNum + 1;
//			}
//			
//			if((empcode5Text.Text != "" ) && (empcode5Text.Text != null))
//			{
//				EmpNum = EmpNum + 1;
//			}
		}

		private void GroupFooter2_AfterPrint(object sender, System.EventArgs eArgs)
		{
			// GroupFooderでブレイク後、最初のデータを出力する。
//			ylyEdPaymntPlCode = "";
//			paymntPlName = "";
//			EmpNum = 0;
		}

		private void PageFooter_BeforePrint(object sender, System.EventArgs eArgs)
		{

		}

		private void PageFooter_AfterPrint(object sender, System.EventArgs eArgs)
		{
			// 改ページ後、最初のデータを出力する。
//			ylyEdPaymntPlCode = "";
//			paymntPlName = "";
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{

		}

		private void GroupFooter2_BeforePrint(object sender, System.EventArgs eArgs)
		{
//			PaymntPlCodeText.Text = EmpNum.ToString();
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R53));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.YngDpndRemarksText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndRemarksText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ylyEdAddress1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empCodeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.postNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameKanaText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.classText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.slryInsmDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.incmDedAmtSumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ylyCollectTaxText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.sposOldAgeTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExistText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExist2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.sposExtDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.liveTgtAgePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.othersDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.othersDpndNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.liveTgtExtHandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHndiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.smlScaleCompCpratAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox454 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.sponSumIncmAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.nolfInsLongProdAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.minrTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latterText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.handiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAddressText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntPhoneText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.nolfInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.deathRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.foreignTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmployTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReFateMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthNameOfEraText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary0Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsCareAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary1Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YoungDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.NonResidentNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingObtDedPsblAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateYText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2YText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateMText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2MText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2DText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SpecDedTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SpecDedType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EyLoanBalanceText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EyLoanBalance2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.NationalPensPremText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposNonResTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNonResType1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposNameKana_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposName_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNameKana1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndName1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNameKana2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndName2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNonResType2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNameKana3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndName3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNonResType3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNameKana4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndName4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndNonResType4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNameKana1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndName1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNonRexType1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndName2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNameKana2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNonRexType2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndName3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNameKana3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNonRexType3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNameKana4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndName4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndNonRexType4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingObtDedCntText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.incmAdjDedAmtText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemarksText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NonResidentNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedPsblAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateYText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2YText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateMText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2MText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2DText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalanceText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalance2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NationalPensPremText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposNonResTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposNameKana_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposName_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedCntText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.ColumnCount = 2;
			this.Detail.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.YngDpndRemarksText1,
            this.DpndRemarksText1,
            this.CorpNumber1_4,
            this.CorpNumber1_3,
            this.CorpNumber1_2,
            this.CorpNumber1_1,
            this.ylyEdAddress1_1Text,
            this.empCodeText,
            this.postNameText,
            this.empNameKanaText,
            this.classText,
            this.paymntAmtText,
            this.slryInsmDedAmtText,
            this.incmDedAmtSumText,
            this.ylyCollectTaxText,
            this.sposOldAgeTypeText,
            this.dedSposExistText,
            this.dedSposExist2Text,
            this.sposExtDedAmtText,
            this.specDpndNum1_1Text,
            this.specDpndNum2_1Text,
            this.liveTgtAgePreNumText,
            this.agePreNumText,
            this.agePreNum2Text,
            this.othersDpndNumText,
            this.othersDpndNum2Text,
            this.liveTgtExtHandiNumText,
            this.extHndiNumText,
            this.HandiNumText,
            this.smlScaleCompCpratAmtText,
            this.lifeInsDedAmtText,
            this.TextBox454,
            this.sponSumIncmAmtText,
            this.LifeInsPensAmtText,
            this.nolfInsLongProdAmtText,
            this.empNameText,
            this.minrTypeText,
            this.latterText,
            this.extHandiTypeText,
            this.handiTypeText,
            this.widowTypeText,
            this.extWidowTypeText,
            this.widomTypeText,
            this.wrkStdTypeText,
            this.paymntAddressText,
            this.paymntNameText,
            this.paymntPhoneText,
            this.nolfInsDedAmtText,
            this.deathRetireTypeText,
            this.disasterTypeText,
            this.foreignTypeText,
            this.halfEmployTypeText,
            this.halfRetireTypeText,
            this.halfEmReDateYearText,
            this.halfEmReFateMonthText,
            this.halfEmReDateDayText,
            this.birthNameOfEraText,
            this.birthDayYearText,
            this.birthDayMonthText,
            this.birthDayDayText,
            this.socInsDedAmtText,
            this.summary0Digit0Text,
            this.newLifeInsPensAmtText,
            this.newLifeInsCareAmtText,
            this.newLifeInsGeneralAmtText,
            this.lifeInsGeneralAmtText,
            this.summary1Digit0Text,
            this.YoungDpndNumText,
            this.NonResidentNumText,
            this.HousingObtDedPsblAmtText,
            this.HousingMovingDateYText,
            this.HousingMovingDate2YText,
            this.HousingMovingDateMText,
            this.HousingMovingDate2MText,
            this.HousingMovingDateDText,
            this.HousingMovingDate2DText,
            this.HousingMovingDateText,
            this.HousingMovingDate2Text,
            this.SpecDedTypeText,
            this.SpecDedType2Text,
            this.EyLoanBalanceText,
            this.EyLoanBalance2Text,
            this.NationalPensPremText,
            this.SposNonResTypeText,
            this.DpndNonResType1_Text,
            this.SposNameKana_Text,
            this.SposName_Text,
            this.DpndNameKana1_Text,
            this.DpndName1_Text,
            this.DpndNameKana2_Text,
            this.DpndName2_Text,
            this.DpndNonResType2_Text,
            this.DpndNameKana3_Text,
            this.DpndName3_Text,
            this.DpndNonResType3_Text,
            this.DpndNameKana4_Text,
            this.DpndName4_Text,
            this.DpndNonResType4_Text,
            this.YngDpndNameKana1_Text,
            this.YngDpndName1_Text,
            this.YngDpndNonRexType1_Text,
            this.YngDpndName2_Text,
            this.YngDpndNameKana2_Text,
            this.YngDpndNonRexType2_Text,
            this.YngDpndName3_Text,
            this.YngDpndNameKana3_Text,
            this.YngDpndNonRexType3_Text,
            this.YngDpndNameKana4_Text,
            this.YngDpndName4_Text,
            this.YngDpndNonRexType4_Text,
            this.HousingObtDedCntText,
            this.MyNumber1_3Text,
            this.MyNumber1_2Text,
            this.MyNumber1_1Text,
            this.SposMyNumber1_1Text,
            this.SposMyNumber1_2Text,
            this.SposMyNumber1_3Text,
            this.DpndMyNumber1_1_1Text,
            this.DpndMyNumber1_1_2Text,
            this.DpndMyNumber1_1_3Text,
            this.DpndMyNumber1_2_1Text,
            this.DpndMyNumber1_2_2Text,
            this.DpndMyNumber1_2_3Text,
            this.DpndMyNumber1_3_1Text,
            this.DpndMyNumber1_3_2Text,
            this.DpndMyNumber1_3_3Text,
            this.DpndMyNumber1_4_1Text,
            this.DpndMyNumber1_4_2Text,
            this.DpndMyNumber1_4_3Text,
            this.YngDpndMyNumber1_4_3Text,
            this.YngDpndMyNumber1_1_1Text,
            this.YngDpndMyNumber1_1_2Text,
            this.YngDpndMyNumber1_1_3Text,
            this.YngDpndMyNumber1_2_1Text,
            this.YngDpndMyNumber1_2_2Text,
            this.YngDpndMyNumber1_2_3Text,
            this.YngDpndMyNumber1_3_1Text,
            this.YngDpndMyNumber1_3_2Text,
            this.YngDpndMyNumber1_3_3Text,
            this.YngDpndMyNumber1_4_1Text,
            this.YngDpndMyNumber1_4_2Text,
            this.SposMyNumber_Text,
            this.DpndMyNumber1_Text,
            this.DpndMyNumber2_Text,
            this.DpndMyNumber3_Text,
            this.DpndMyNumber4_Text,
            this.MyNumber_Text,
            this.YngDpndMyNumber1_Text,
            this.YngDpndMyNumber4_Text,
            this.YngDpndMyNumber3_Text,
            this.YngDpndMyNumber2_Text,
            this.CorpNumber,
            this.incmAdjDedAmtText1});
			this.Detail.Height = 8.36F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// YngDpndRemarksText1
			// 
			this.YngDpndRemarksText1.CanGrow = false;
			this.YngDpndRemarksText1.DataField = "YNGREMARKS";
			this.YngDpndRemarksText1.Height = 0.5574803F;
			this.YngDpndRemarksText1.Left = 4.722F;
			this.YngDpndRemarksText1.Name = "YngDpndRemarksText1";
			this.YngDpndRemarksText1.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.YngDpndRemarksText1.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012";
			this.YngDpndRemarksText1.Top = 6.254F;
			this.YngDpndRemarksText1.Width = 0.7299993F;
			// 
			// DpndRemarksText1
			// 
			this.DpndRemarksText1.CanGrow = false;
			this.DpndRemarksText1.DataField = "Remarks";
			this.DpndRemarksText1.Height = 0.803F;
			this.DpndRemarksText1.Left = 4.722F;
			this.DpndRemarksText1.Name = "DpndRemarksText1";
			this.DpndRemarksText1.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.DpndRemarksText1.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012(7)123456789012(8)123456789012(9)123456789012";
			this.DpndRemarksText1.Top = 5.141F;
			this.DpndRemarksText1.Width = 0.7299993F;
			// 
			// CorpNumber1_4
			// 
			this.CorpNumber1_4.CanGrow = false;
			this.CorpNumber1_4.Height = 0.2F;
			this.CorpNumber1_4.Left = 1.765F;
			this.CorpNumber1_4.MultiLine = false;
			this.CorpNumber1_4.Name = "CorpNumber1_4";
			this.CorpNumber1_4.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_4.Text = null;
			this.CorpNumber1_4.Top = 7.571F;
			this.CorpNumber1_4.Width = 0.3F;
			// 
			// CorpNumber1_3
			// 
			this.CorpNumber1_3.CanGrow = false;
			this.CorpNumber1_3.Height = 0.2F;
			this.CorpNumber1_3.Left = 1.465F;
			this.CorpNumber1_3.MultiLine = false;
			this.CorpNumber1_3.Name = "CorpNumber1_3";
			this.CorpNumber1_3.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_3.Text = null;
			this.CorpNumber1_3.Top = 7.571F;
			this.CorpNumber1_3.Width = 0.3F;
			// 
			// CorpNumber1_2
			// 
			this.CorpNumber1_2.CanGrow = false;
			this.CorpNumber1_2.Height = 0.2F;
			this.CorpNumber1_2.Left = 1.165F;
			this.CorpNumber1_2.MultiLine = false;
			this.CorpNumber1_2.Name = "CorpNumber1_2";
			this.CorpNumber1_2.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_2.Text = null;
			this.CorpNumber1_2.Top = 7.571F;
			this.CorpNumber1_2.Width = 0.3F;
			// 
			// CorpNumber1_1
			// 
			this.CorpNumber1_1.CanGrow = false;
			this.CorpNumber1_1.Height = 0.2F;
			this.CorpNumber1_1.Left = 1.015F;
			this.CorpNumber1_1.MultiLine = false;
			this.CorpNumber1_1.Name = "CorpNumber1_1";
			this.CorpNumber1_1.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_1.Text = null;
			this.CorpNumber1_1.Top = 7.571F;
			this.CorpNumber1_1.Width = 0.15F;
			// 
			// ylyEdAddress1_1Text
			// 
			this.ylyEdAddress1_1Text.CanGrow = false;
			this.ylyEdAddress1_1Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_1Text.Height = 0.7779999F;
			this.ylyEdAddress1_1Text.Left = 0.678F;
			this.ylyEdAddress1_1Text.Name = "ylyEdAddress1_1Text";
			this.ylyEdAddress1_1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_1Text.Top = 0.268F;
			this.ylyEdAddress1_1Text.Width = 2.329F;
			// 
			// empCodeText
			// 
			this.empCodeText.CanGrow = false;
			this.empCodeText.DataField = "EMP_CODE";
			this.empCodeText.Height = 0.1232283F;
			this.empCodeText.Left = 3.75F;
			this.empCodeText.Name = "empCodeText";
			this.empCodeText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empCodeText.Text = "0000000000";
			this.empCodeText.Top = 0.267F;
			this.empCodeText.Width = 1.494094F;
			// 
			// postNameText
			// 
			this.postNameText.CanGrow = false;
			this.postNameText.DataField = "POST_NAME";
			this.postNameText.Height = 0.156F;
			this.postNameText.Left = 3.716F;
			this.postNameText.Name = "postNameText";
			this.postNameText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.postNameText.Text = "ああああああああああ";
			this.postNameText.Top = 0.591F;
			this.postNameText.Width = 1.619F;
			// 
			// empNameKanaText
			// 
			this.empNameKanaText.CanGrow = false;
			this.empNameKanaText.DataField = "EMP_REGIST_NAME_KANA";
			this.empNameKanaText.Height = 0.12F;
			this.empNameKanaText.Left = 3.834F;
			this.empNameKanaText.Name = "empNameKanaText";
			this.empNameKanaText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameKanaText.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.empNameKanaText.Top = 0.78F;
			this.empNameKanaText.Width = 1.619F;
			// 
			// classText
			// 
			this.classText.CanGrow = false;
			this.classText.DataField = "CLASS";
			this.classText.Height = 0.28F;
			this.classText.Left = 0.191F;
			this.classText.Name = "classText";
			this.classText.Style = "font-size: 9pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.classText.Text = "ああああああ";
			this.classText.Top = 1.48F;
			this.classText.Width = 0.92F;
			// 
			// paymntAmtText
			// 
			this.paymntAmtText.CanGrow = false;
			this.paymntAmtText.DataField = "PAYMNT_AMT";
			this.paymntAmtText.Height = 0.28F;
			this.paymntAmtText.Left = 1.225F;
			this.paymntAmtText.Name = "paymntAmtText";
			this.paymntAmtText.OutputFormat = "#,##0";
			this.paymntAmtText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.paymntAmtText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.paymntAmtText.Top = 1.48F;
			this.paymntAmtText.Width = 0.85F;
			// 
			// slryInsmDedAmtText
			// 
			this.slryInsmDedAmtText.CanGrow = false;
			this.slryInsmDedAmtText.DataField = "SLRY_INSM_DED_AMT";
			this.slryInsmDedAmtText.Height = 0.28F;
			this.slryInsmDedAmtText.Left = 2.303F;
			this.slryInsmDedAmtText.Name = "slryInsmDedAmtText";
			this.slryInsmDedAmtText.OutputFormat = "#,##0";
			this.slryInsmDedAmtText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.slryInsmDedAmtText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.slryInsmDedAmtText.Top = 1.48F;
			this.slryInsmDedAmtText.Width = 0.85F;
			// 
			// incmDedAmtSumText
			// 
			this.incmDedAmtSumText.CanGrow = false;
			this.incmDedAmtSumText.DataField = "INCM_DED_AMT_SUM";
			this.incmDedAmtSumText.Height = 0.28F;
			this.incmDedAmtSumText.Left = 3.366F;
			this.incmDedAmtSumText.Name = "incmDedAmtSumText";
			this.incmDedAmtSumText.OutputFormat = "#,##0";
			this.incmDedAmtSumText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmDedAmtSumText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.incmDedAmtSumText.Top = 1.48F;
			this.incmDedAmtSumText.Width = 0.85F;
			// 
			// ylyCollectTaxText
			// 
			this.ylyCollectTaxText.CanGrow = false;
			this.ylyCollectTaxText.DataField = "YLY_COLLECT_TAX";
			this.ylyCollectTaxText.Height = 0.28F;
			this.ylyCollectTaxText.Left = 4.399F;
			this.ylyCollectTaxText.Name = "ylyCollectTaxText";
			this.ylyCollectTaxText.OutputFormat = "#,##0";
			this.ylyCollectTaxText.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.ylyCollectTaxText.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.ylyCollectTaxText.Top = 1.48F;
			this.ylyCollectTaxText.Width = 0.85F;
			// 
			// sposOldAgeTypeText
			// 
			this.sposOldAgeTypeText.CanGrow = false;
			this.sposOldAgeTypeText.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeTypeText.Height = 0.23F;
			this.sposOldAgeTypeText.Left = 0.807F;
			this.sposOldAgeTypeText.Name = "sposOldAgeTypeText";
			this.sposOldAgeTypeText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeTypeText.Text = "○";
			this.sposOldAgeTypeText.Top = 2.211F;
			this.sposOldAgeTypeText.Width = 0.23F;
			// 
			// dedSposExistText
			// 
			this.dedSposExistText.CanGrow = false;
			this.dedSposExistText.DataField = "DED_SPOS_EXIST";
			this.dedSposExistText.Height = 0.23F;
			this.dedSposExistText.Left = 0.18F;
			this.dedSposExistText.Name = "dedSposExistText";
			this.dedSposExistText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExistText.Text = "○";
			this.dedSposExistText.Top = 2.211F;
			this.dedSposExistText.Width = 0.23F;
			// 
			// dedSposExist2Text
			// 
			this.dedSposExist2Text.CanGrow = false;
			this.dedSposExist2Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExist2Text.Height = 0.23F;
			this.dedSposExist2Text.Left = 0.494F;
			this.dedSposExist2Text.Name = "dedSposExist2Text";
			this.dedSposExist2Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExist2Text.Text = "○";
			this.dedSposExist2Text.Top = 2.211F;
			this.dedSposExist2Text.Width = 0.23F;
			// 
			// sposExtDedAmtText
			// 
			this.sposExtDedAmtText.CanGrow = false;
			this.sposExtDedAmtText.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmtText.Height = 0.15F;
			this.sposExtDedAmtText.Left = 1.181F;
			this.sposExtDedAmtText.Name = "sposExtDedAmtText";
			this.sposExtDedAmtText.OutputFormat = "#,##0";
			this.sposExtDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.sposExtDedAmtText.Text = "Z,ZZZ,ZZ9";
			this.sposExtDedAmtText.Top = 2.241F;
			this.sposExtDedAmtText.Width = 0.7F;
			// 
			// specDpndNum1_1Text
			// 
			this.specDpndNum1_1Text.CanGrow = false;
			this.specDpndNum1_1Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_1Text.Height = 0.15F;
			this.specDpndNum1_1Text.Left = 2.089F;
			this.specDpndNum1_1Text.Name = "specDpndNum1_1Text";
			this.specDpndNum1_1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_1Text.Text = "Z6";
			this.specDpndNum1_1Text.Top = 2.241F;
			this.specDpndNum1_1Text.Width = 0.15F;
			// 
			// specDpndNum2_1Text
			// 
			this.specDpndNum2_1Text.CanGrow = false;
			this.specDpndNum2_1Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_1Text.Height = 0.15F;
			this.specDpndNum2_1Text.Left = 2.346F;
			this.specDpndNum2_1Text.Name = "specDpndNum2_1Text";
			this.specDpndNum2_1Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.specDpndNum2_1Text.Text = "Z6";
			this.specDpndNum2_1Text.Top = 2.241F;
			this.specDpndNum2_1Text.Width = 0.22F;
			// 
			// liveTgtAgePreNumText
			// 
			this.liveTgtAgePreNumText.CanGrow = false;
			this.liveTgtAgePreNumText.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNumText.Height = 0.15F;
			this.liveTgtAgePreNumText.Left = 2.606F;
			this.liveTgtAgePreNumText.Name = "liveTgtAgePreNumText";
			this.liveTgtAgePreNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNumText.Text = "Z6";
			this.liveTgtAgePreNumText.Top = 2.241F;
			this.liveTgtAgePreNumText.Width = 0.15F;
			// 
			// agePreNumText
			// 
			this.agePreNumText.CanGrow = false;
			this.agePreNumText.DataField = "AGE_PRE_NUM";
			this.agePreNumText.Height = 0.15F;
			this.agePreNumText.Left = 2.896F;
			this.agePreNumText.Name = "agePreNumText";
			this.agePreNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNumText.Text = "Z6";
			this.agePreNumText.Top = 2.241F;
			this.agePreNumText.Width = 0.15F;
			// 
			// agePreNum2Text
			// 
			this.agePreNum2Text.CanGrow = false;
			this.agePreNum2Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2Text.Height = 0.15F;
			this.agePreNum2Text.Left = 3.146F;
			this.agePreNum2Text.Name = "agePreNum2Text";
			this.agePreNum2Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.agePreNum2Text.Text = "Z6";
			this.agePreNum2Text.Top = 2.241F;
			this.agePreNum2Text.Width = 0.22F;
			// 
			// othersDpndNumText
			// 
			this.othersDpndNumText.CanGrow = false;
			this.othersDpndNumText.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNumText.Height = 0.15F;
			this.othersDpndNumText.Left = 3.436F;
			this.othersDpndNumText.Name = "othersDpndNumText";
			this.othersDpndNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNumText.Text = "Z6";
			this.othersDpndNumText.Top = 2.241F;
			this.othersDpndNumText.Width = 0.15F;
			// 
			// othersDpndNum2Text
			// 
			this.othersDpndNum2Text.CanGrow = false;
			this.othersDpndNum2Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2Text.Height = 0.15F;
			this.othersDpndNum2Text.Left = 3.637F;
			this.othersDpndNum2Text.Name = "othersDpndNum2Text";
			this.othersDpndNum2Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.othersDpndNum2Text.Text = "Z6";
			this.othersDpndNum2Text.Top = 2.241F;
			this.othersDpndNum2Text.Width = 0.22F;
			// 
			// liveTgtExtHandiNumText
			// 
			this.liveTgtExtHandiNumText.CanGrow = false;
			this.liveTgtExtHandiNumText.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtExtHandiNumText.Height = 0.15F;
			this.liveTgtExtHandiNumText.Left = 4.308F;
			this.liveTgtExtHandiNumText.Name = "liveTgtExtHandiNumText";
			this.liveTgtExtHandiNumText.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.liveTgtExtHandiNumText.Text = "Z6";
			this.liveTgtExtHandiNumText.Top = 2.241F;
			this.liveTgtExtHandiNumText.Width = 0.15F;
			// 
			// extHndiNumText
			// 
			this.extHndiNumText.CanGrow = false;
			this.extHndiNumText.DataField = "EXT_HANDI_NUM";
			this.extHndiNumText.Height = 0.15F;
			this.extHndiNumText.Left = 4.58F;
			this.extHndiNumText.Name = "extHndiNumText";
			this.extHndiNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHndiNumText.Text = "Z6";
			this.extHndiNumText.Top = 2.241F;
			this.extHndiNumText.Width = 0.15F;
			// 
			// HandiNumText
			// 
			this.HandiNumText.CanGrow = false;
			this.HandiNumText.DataField = "HANDI_NUM";
			this.HandiNumText.Height = 0.15F;
			this.HandiNumText.Left = 4.9F;
			this.HandiNumText.Name = "HandiNumText";
			this.HandiNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HandiNumText.Text = "Z6";
			this.HandiNumText.Top = 2.241F;
			this.HandiNumText.Width = 0.15F;
			// 
			// smlScaleCompCpratAmtText
			// 
			this.smlScaleCompCpratAmtText.CanGrow = false;
			this.smlScaleCompCpratAmtText.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.smlScaleCompCpratAmtText.Height = 0.15F;
			this.smlScaleCompCpratAmtText.Left = 0.35F;
			this.smlScaleCompCpratAmtText.Name = "smlScaleCompCpratAmtText";
			this.smlScaleCompCpratAmtText.OutputFormat = "#,##0";
			this.smlScaleCompCpratAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.smlScaleCompCpratAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.smlScaleCompCpratAmtText.Top = 2.607F;
			this.smlScaleCompCpratAmtText.Width = 1F;
			// 
			// lifeInsDedAmtText
			// 
			this.lifeInsDedAmtText.CanGrow = false;
			this.lifeInsDedAmtText.DataField = "LIFE_INS_DED_AMT";
			this.lifeInsDedAmtText.Height = 0.15F;
			this.lifeInsDedAmtText.Left = 1.64F;
			this.lifeInsDedAmtText.Name = "lifeInsDedAmtText";
			this.lifeInsDedAmtText.OutputFormat = "#,##0";
			this.lifeInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsDedAmtText.Top = 2.686F;
			this.lifeInsDedAmtText.Width = 1F;
			// 
			// TextBox454
			// 
			this.TextBox454.CanGrow = false;
			this.TextBox454.DataField = "HOUSING_OBT_DED_AMT";
			this.TextBox454.Height = 0.15F;
			this.TextBox454.Left = 4.22F;
			this.TextBox454.Name = "TextBox454";
			this.TextBox454.OutputFormat = "#,##0";
			this.TextBox454.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.TextBox454.Text = "ZZ,ZZZ,ZZ6";
			this.TextBox454.Top = 2.686F;
			this.TextBox454.Width = 1F;
			// 
			// sponSumIncmAmtText
			// 
			this.sponSumIncmAmtText.CanGrow = false;
			this.sponSumIncmAmtText.DataField = "SPOS_SUM_INCM_AMT";
			this.sponSumIncmAmtText.Height = 0.153F;
			this.sponSumIncmAmtText.Left = 2.958F;
			this.sponSumIncmAmtText.Name = "sponSumIncmAmtText";
			this.sponSumIncmAmtText.OutputFormat = "#,##0";
			this.sponSumIncmAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.sponSumIncmAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.sponSumIncmAmtText.Top = 4.564F;
			this.sponSumIncmAmtText.Width = 0.45F;
			// 
			// LifeInsPensAmtText
			// 
			this.LifeInsPensAmtText.CanGrow = false;
			this.LifeInsPensAmtText.DataField = "LIFE_INS_PENS_AMT";
			this.LifeInsPensAmtText.Height = 0.15F;
			this.LifeInsPensAmtText.Left = 4.903F;
			this.LifeInsPensAmtText.Name = "LifeInsPensAmtText";
			this.LifeInsPensAmtText.OutputFormat = "#,##0";
			this.LifeInsPensAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.LifeInsPensAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.LifeInsPensAmtText.Top = 3.529F;
			this.LifeInsPensAmtText.Width = 0.45F;
			// 
			// nolfInsLongProdAmtText
			// 
			this.nolfInsLongProdAmtText.CanGrow = false;
			this.nolfInsLongProdAmtText.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmtText.Height = 0.153F;
			this.nolfInsLongProdAmtText.Left = 4.909843F;
			this.nolfInsLongProdAmtText.Name = "nolfInsLongProdAmtText";
			this.nolfInsLongProdAmtText.OutputFormat = "#,##0";
			this.nolfInsLongProdAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsLongProdAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmtText.Top = 4.457874F;
			this.nolfInsLongProdAmtText.Width = 0.45F;
			// 
			// empNameText
			// 
			this.empNameText.CanGrow = false;
			this.empNameText.DataField = "EMP_REGIST_NAME";
			this.empNameText.Height = 0.21F;
			this.empNameText.Left = 3.716F;
			this.empNameText.Name = "empNameText";
			this.empNameText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameText.Text = "あいうえおかきくけこあいうえお";
			this.empNameText.Top = 1F;
			this.empNameText.Width = 1.619F;
			// 
			// minrTypeText
			// 
			this.minrTypeText.CanGrow = false;
			this.minrTypeText.DataField = "MINR_TYPE";
			this.minrTypeText.Height = 0.25F;
			this.minrTypeText.Left = 0.159F;
			this.minrTypeText.Name = "minrTypeText";
			this.minrTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrTypeText.Text = "0";
			this.minrTypeText.Top = 7.364F;
			this.minrTypeText.Width = 0.177F;
			// 
			// latterText
			// 
			this.latterText.CanGrow = false;
			this.latterText.DataField = "LATTER";
			this.latterText.Height = 0.25F;
			this.latterText.Left = 0.951F;
			this.latterText.Name = "latterText";
			this.latterText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latterText.Text = "0";
			this.latterText.Top = 7.364F;
			this.latterText.Width = 0.177F;
			// 
			// extHandiTypeText
			// 
			this.extHandiTypeText.CanGrow = false;
			this.extHandiTypeText.DataField = "EXT_HANDI_TYPE";
			this.extHandiTypeText.Height = 0.25F;
			this.extHandiTypeText.Left = 1.149F;
			this.extHandiTypeText.Name = "extHandiTypeText";
			this.extHandiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiTypeText.Text = "0";
			this.extHandiTypeText.Top = 7.364F;
			this.extHandiTypeText.Width = 0.177F;
			// 
			// handiTypeText
			// 
			this.handiTypeText.CanGrow = false;
			this.handiTypeText.DataField = "HANDI_TYPE";
			this.handiTypeText.Height = 0.25F;
			this.handiTypeText.Left = 1.347F;
			this.handiTypeText.Name = "handiTypeText";
			this.handiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.handiTypeText.Text = "0";
			this.handiTypeText.Top = 7.364F;
			this.handiTypeText.Width = 0.177F;
			// 
			// widowTypeText
			// 
			this.widowTypeText.CanGrow = false;
			this.widowTypeText.DataField = "WIDOW_TYPE";
			this.widowTypeText.Height = 0.25F;
			this.widowTypeText.Left = 1.545F;
			this.widowTypeText.Name = "widowTypeText";
			this.widowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowTypeText.Text = "0";
			this.widowTypeText.Top = 7.364F;
			this.widowTypeText.Width = 0.177F;
			// 
			// extWidowTypeText
			// 
			this.extWidowTypeText.CanGrow = false;
			this.extWidowTypeText.DataField = "EXT_WIDOW_TYPE";
			this.extWidowTypeText.Height = 0.25F;
			this.extWidowTypeText.Left = 1.743F;
			this.extWidowTypeText.Name = "extWidowTypeText";
			this.extWidowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowTypeText.Text = "0";
			this.extWidowTypeText.Top = 7.364F;
			this.extWidowTypeText.Width = 0.177F;
			// 
			// widomTypeText
			// 
			this.widomTypeText.CanGrow = false;
			this.widomTypeText.DataField = "WIDOM_TYPE";
			this.widomTypeText.Height = 0.25F;
			this.widomTypeText.Left = 1.941F;
			this.widomTypeText.Name = "widomTypeText";
			this.widomTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomTypeText.Text = "0";
			this.widomTypeText.Top = 7.364F;
			this.widomTypeText.Width = 0.177F;
			// 
			// wrkStdTypeText
			// 
			this.wrkStdTypeText.CanGrow = false;
			this.wrkStdTypeText.DataField = "WRK_STD_TYPE";
			this.wrkStdTypeText.Height = 0.25F;
			this.wrkStdTypeText.Left = 2.139F;
			this.wrkStdTypeText.Name = "wrkStdTypeText";
			this.wrkStdTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdTypeText.Text = "0";
			this.wrkStdTypeText.Top = 7.364F;
			this.wrkStdTypeText.Width = 0.177F;
			// 
			// paymntAddressText
			// 
			this.paymntAddressText.CanGrow = false;
			this.paymntAddressText.DataField = "PAYMNT_ADDRESS";
			this.paymntAddressText.Height = 0.332F;
			this.paymntAddressText.Left = 0.985F;
			this.paymntAddressText.Name = "paymntAddressText";
			this.paymntAddressText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddressText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddressText.Top = 7.73F;
			this.paymntAddressText.Width = 4.312F;
			// 
			// paymntNameText
			// 
			this.paymntNameText.CanGrow = false;
			this.paymntNameText.DataField = "PAYMNT_NAME";
			this.paymntNameText.Height = 0.2F;
			this.paymntNameText.Left = 0.985F;
			this.paymntNameText.MultiLine = false;
			this.paymntNameText.Name = "paymntNameText";
			this.paymntNameText.Style = "font-size: 7pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntNameText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntNameText.Top = 8.06F;
			this.paymntNameText.Width = 3.125F;
			// 
			// paymntPhoneText
			// 
			this.paymntPhoneText.CanGrow = false;
			this.paymntPhoneText.DataField = "PAYMNT_PHONE";
			this.paymntPhoneText.Height = 0.2F;
			this.paymntPhoneText.Left = 4.45F;
			this.paymntPhoneText.Name = "paymntPhoneText";
			this.paymntPhoneText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.paymntPhoneText.Text = "99999999999999";
			this.paymntPhoneText.Top = 8.05F;
			this.paymntPhoneText.Width = 0.813F;
			// 
			// nolfInsDedAmtText
			// 
			this.nolfInsDedAmtText.CanGrow = false;
			this.nolfInsDedAmtText.DataField = "NOLF_INS_DED_AMT";
			this.nolfInsDedAmtText.Height = 0.15F;
			this.nolfInsDedAmtText.Left = 2.93F;
			this.nolfInsDedAmtText.Name = "nolfInsDedAmtText";
			this.nolfInsDedAmtText.OutputFormat = "#,##0";
			this.nolfInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsDedAmtText.Top = 2.686F;
			this.nolfInsDedAmtText.Width = 1F;
			// 
			// deathRetireTypeText
			// 
			this.deathRetireTypeText.CanGrow = false;
			this.deathRetireTypeText.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireTypeText.Height = 0.25F;
			this.deathRetireTypeText.Left = 0.555F;
			this.deathRetireTypeText.Name = "deathRetireTypeText";
			this.deathRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireTypeText.Text = "0";
			this.deathRetireTypeText.Top = 7.364F;
			this.deathRetireTypeText.Width = 0.177F;
			// 
			// disasterTypeText
			// 
			this.disasterTypeText.CanGrow = false;
			this.disasterTypeText.DataField = "DISASTER_TYPE";
			this.disasterTypeText.Height = 0.25F;
			this.disasterTypeText.Left = 0.753F;
			this.disasterTypeText.Name = "disasterTypeText";
			this.disasterTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterTypeText.Text = "0";
			this.disasterTypeText.Top = 7.364F;
			this.disasterTypeText.Width = 0.177F;
			// 
			// foreignTypeText
			// 
			this.foreignTypeText.CanGrow = false;
			this.foreignTypeText.DataField = "FOREIGN_TYPE";
			this.foreignTypeText.Height = 0.25F;
			this.foreignTypeText.Left = 0.357F;
			this.foreignTypeText.Name = "foreignTypeText";
			this.foreignTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignTypeText.Text = "0";
			this.foreignTypeText.Top = 7.364F;
			this.foreignTypeText.Width = 0.177F;
			// 
			// halfEmployTypeText
			// 
			this.halfEmployTypeText.CanGrow = false;
			this.halfEmployTypeText.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployTypeText.Height = 0.25F;
			this.halfEmployTypeText.Left = 2.337F;
			this.halfEmployTypeText.Name = "halfEmployTypeText";
			this.halfEmployTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployTypeText.Text = "0";
			this.halfEmployTypeText.Top = 7.364F;
			this.halfEmployTypeText.Width = 0.177F;
			// 
			// halfRetireTypeText
			// 
			this.halfRetireTypeText.CanGrow = false;
			this.halfRetireTypeText.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireTypeText.Height = 0.25F;
			this.halfRetireTypeText.Left = 2.535F;
			this.halfRetireTypeText.Name = "halfRetireTypeText";
			this.halfRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireTypeText.Text = "0";
			this.halfRetireTypeText.Top = 7.364F;
			this.halfRetireTypeText.Width = 0.177F;
			// 
			// halfEmReDateYearText
			// 
			this.halfEmReDateYearText.CanGrow = false;
			this.halfEmReDateYearText.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halfEmReDateYearText.Height = 0.25F;
			this.halfEmReDateYearText.Left = 2.753F;
			this.halfEmReDateYearText.Name = "halfEmReDateYearText";
			this.halfEmReDateYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateYearText.Text = "0";
			this.halfEmReDateYearText.Top = 7.364F;
			this.halfEmReDateYearText.Visible = false;
			this.halfEmReDateYearText.Width = 0.315F;
			// 
			// halfEmReFateMonthText
			// 
			this.halfEmReFateMonthText.CanGrow = false;
			this.halfEmReFateMonthText.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReFateMonthText.Height = 0.25F;
			this.halfEmReFateMonthText.Left = 3.069F;
			this.halfEmReFateMonthText.Name = "halfEmReFateMonthText";
			this.halfEmReFateMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReFateMonthText.Text = "0";
			this.halfEmReFateMonthText.Top = 7.364F;
			this.halfEmReFateMonthText.Width = 0.315F;
			// 
			// halfEmReDateDayText
			// 
			this.halfEmReDateDayText.CanGrow = false;
			this.halfEmReDateDayText.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDayText.Height = 0.25F;
			this.halfEmReDateDayText.Left = 3.385F;
			this.halfEmReDateDayText.Name = "halfEmReDateDayText";
			this.halfEmReDateDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDayText.Text = "0";
			this.halfEmReDateDayText.Top = 7.364F;
			this.halfEmReDateDayText.Width = 0.315F;
			// 
			// birthNameOfEraText
			// 
			this.birthNameOfEraText.CanGrow = false;
			this.birthNameOfEraText.DataField = "BIRTH_NAME_OF_ERA_NAME";
			this.birthNameOfEraText.Height = 0.25F;
			this.birthNameOfEraText.Left = 3.717F;
			this.birthNameOfEraText.Name = "birthNameOfEraText";
			this.birthNameOfEraText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraText.Text = "あい";
			this.birthNameOfEraText.Top = 7.364F;
			this.birthNameOfEraText.Width = 0.7811024F;
			// 
			// birthDayYearText
			// 
			this.birthDayYearText.CanGrow = false;
			this.birthDayYearText.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYearText.Height = 0.25F;
			this.birthDayYearText.Left = 4.528F;
			this.birthDayYearText.Name = "birthDayYearText";
			this.birthDayYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYearText.Text = "0";
			this.birthDayYearText.Top = 7.364F;
			this.birthDayYearText.Width = 0.315F;
			// 
			// birthDayMonthText
			// 
			this.birthDayMonthText.CanGrow = false;
			this.birthDayMonthText.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonthText.Height = 0.25F;
			this.birthDayMonthText.Left = 4.843F;
			this.birthDayMonthText.Name = "birthDayMonthText";
			this.birthDayMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonthText.Text = "0";
			this.birthDayMonthText.Top = 7.364F;
			this.birthDayMonthText.Width = 0.315F;
			// 
			// birthDayDayText
			// 
			this.birthDayDayText.CanGrow = false;
			this.birthDayDayText.DataField = "BIRTH_DAY_DAY";
			this.birthDayDayText.Height = 0.25F;
			this.birthDayDayText.Left = 5.158F;
			this.birthDayDayText.Name = "birthDayDayText";
			this.birthDayDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDayText.Text = "0";
			this.birthDayDayText.Top = 7.364F;
			this.birthDayDayText.Width = 0.315F;
			// 
			// socInsDedAmtText
			// 
			this.socInsDedAmtText.CanGrow = false;
			this.socInsDedAmtText.DataField = "SOC_INS_DED_AMT";
			this.socInsDedAmtText.Height = 0.15F;
			this.socInsDedAmtText.Left = 0.35F;
			this.socInsDedAmtText.Name = "socInsDedAmtText";
			this.socInsDedAmtText.OutputFormat = "#,##0";
			this.socInsDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.socInsDedAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.socInsDedAmtText.Top = 2.74F;
			this.socInsDedAmtText.Width = 1F;
			// 
			// summary0Digit0Text
			// 
			this.summary0Digit0Text.CanGrow = false;
			this.summary0Digit0Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit0Text.Height = 0.125F;
			this.summary0Digit0Text.Left = 0.437F;
			this.summary0Digit0Text.MultiLine = false;
			this.summary0Digit0Text.Name = "summary0Digit0Text";
			this.summary0Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit0Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit0Text.Top = 2.908F;
			this.summary0Digit0Text.Width = 5.063002F;
			// 
			// newLifeInsPensAmtText
			// 
			this.newLifeInsPensAmtText.CanGrow = false;
			this.newLifeInsPensAmtText.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.newLifeInsPensAmtText.Height = 0.15F;
			this.newLifeInsPensAmtText.Left = 3.913F;
			this.newLifeInsPensAmtText.Name = "newLifeInsPensAmtText";
			this.newLifeInsPensAmtText.OutputFormat = "#,##0";
			this.newLifeInsPensAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.newLifeInsPensAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.newLifeInsPensAmtText.Top = 3.529F;
			this.newLifeInsPensAmtText.Width = 0.45F;
			// 
			// newLifeInsCareAmtText
			// 
			this.newLifeInsCareAmtText.CanGrow = false;
			this.newLifeInsCareAmtText.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.newLifeInsCareAmtText.Height = 0.15F;
			this.newLifeInsCareAmtText.Left = 2.92F;
			this.newLifeInsCareAmtText.Name = "newLifeInsCareAmtText";
			this.newLifeInsCareAmtText.OutputFormat = "#,##0";
			this.newLifeInsCareAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.newLifeInsCareAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.newLifeInsCareAmtText.Top = 3.529F;
			this.newLifeInsCareAmtText.Width = 0.45F;
			// 
			// newLifeInsGeneralAmtText
			// 
			this.newLifeInsGeneralAmtText.CanGrow = false;
			this.newLifeInsGeneralAmtText.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmtText.Height = 0.15F;
			this.newLifeInsGeneralAmtText.Left = 0.946F;
			this.newLifeInsGeneralAmtText.Name = "newLifeInsGeneralAmtText";
			this.newLifeInsGeneralAmtText.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.newLifeInsGeneralAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmtText.Top = 3.529F;
			this.newLifeInsGeneralAmtText.Width = 0.45F;
			// 
			// lifeInsGeneralAmtText
			// 
			this.lifeInsGeneralAmtText.CanGrow = false;
			this.lifeInsGeneralAmtText.DataField = "LIFE_INS_GENERAL_AMT";
			this.lifeInsGeneralAmtText.Height = 0.15F;
			this.lifeInsGeneralAmtText.Left = 1.933F;
			this.lifeInsGeneralAmtText.Name = "lifeInsGeneralAmtText";
			this.lifeInsGeneralAmtText.OutputFormat = "#,##0";
			this.lifeInsGeneralAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.lifeInsGeneralAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.lifeInsGeneralAmtText.Top = 3.529F;
			this.lifeInsGeneralAmtText.Width = 0.45F;
			// 
			// summary1Digit0Text
			// 
			this.summary1Digit0Text.CanGrow = false;
			this.summary1Digit0Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit0Text.Height = 0.5F;
			this.summary1Digit0Text.Left = 0.437F;
			this.summary1Digit0Text.Name = "summary1Digit0Text";
			this.summary1Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit0Text.Text = resources.GetString("summary1Digit0Text.Text");
			this.summary1Digit0Text.Top = 2.993F;
			this.summary1Digit0Text.Width = 5.063F;
			// 
			// YoungDpndNumText
			// 
			this.YoungDpndNumText.CanGrow = false;
			this.YoungDpndNumText.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNumText.Height = 0.15F;
			this.YoungDpndNumText.Left = 4.016F;
			this.YoungDpndNumText.Name = "YoungDpndNumText";
			this.YoungDpndNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNumText.Text = "Z6";
			this.YoungDpndNumText.Top = 2.241F;
			this.YoungDpndNumText.Width = 0.15F;
			// 
			// NonResidentNumText
			// 
			this.NonResidentNumText.CanGrow = false;
			this.NonResidentNumText.DataField = "NON_RESIDENT_NUM";
			this.NonResidentNumText.Height = 0.15F;
			this.NonResidentNumText.Left = 5.26F;
			this.NonResidentNumText.Name = "NonResidentNumText";
			this.NonResidentNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.NonResidentNumText.Text = "Z9";
			this.NonResidentNumText.Top = 2.241F;
			this.NonResidentNumText.Width = 0.15F;
			// 
			// HousingObtDedPsblAmtText
			// 
			this.HousingObtDedPsblAmtText.CanGrow = false;
			this.HousingObtDedPsblAmtText.DataField = "HOUSING_OBT_DED_PSBL_AMT";
			this.HousingObtDedPsblAmtText.Height = 0.15F;
			this.HousingObtDedPsblAmtText.Left = 0.945F;
			this.HousingObtDedPsblAmtText.Name = "HousingObtDedPsblAmtText";
			this.HousingObtDedPsblAmtText.OutputFormat = "#,##0";
			this.HousingObtDedPsblAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingObtDedPsblAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.HousingObtDedPsblAmtText.Top = 4.14F;
			this.HousingObtDedPsblAmtText.Width = 0.45F;
			// 
			// HousingMovingDateYText
			// 
			this.HousingMovingDateYText.CanGrow = false;
			this.HousingMovingDateYText.Height = 0.15F;
			this.HousingMovingDateYText.Left = 1.881F;
			this.HousingMovingDateYText.Name = "HousingMovingDateYText";
			this.HousingMovingDateYText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateYText.Text = "9999";
			this.HousingMovingDateYText.Top = 3.862F;
			this.HousingMovingDateYText.Width = 0.25F;
			// 
			// HousingMovingDate2YText
			// 
			this.HousingMovingDate2YText.CanGrow = false;
			this.HousingMovingDate2YText.Height = 0.15F;
			this.HousingMovingDate2YText.Left = 1.881F;
			this.HousingMovingDate2YText.Name = "HousingMovingDate2YText";
			this.HousingMovingDate2YText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2YText.Text = "9999";
			this.HousingMovingDate2YText.Top = 4.14F;
			this.HousingMovingDate2YText.Width = 0.25F;
			// 
			// HousingMovingDateMText
			// 
			this.HousingMovingDateMText.CanGrow = false;
			this.HousingMovingDateMText.Height = 0.15F;
			this.HousingMovingDateMText.Left = 2.351F;
			this.HousingMovingDateMText.Name = "HousingMovingDateMText";
			this.HousingMovingDateMText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateMText.Text = "99";
			this.HousingMovingDateMText.Top = 3.862F;
			this.HousingMovingDateMText.Width = 0.13F;
			// 
			// HousingMovingDate2MText
			// 
			this.HousingMovingDate2MText.CanGrow = false;
			this.HousingMovingDate2MText.Height = 0.15F;
			this.HousingMovingDate2MText.Left = 2.351F;
			this.HousingMovingDate2MText.Name = "HousingMovingDate2MText";
			this.HousingMovingDate2MText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2MText.Text = "99";
			this.HousingMovingDate2MText.Top = 4.14F;
			this.HousingMovingDate2MText.Width = 0.13F;
			// 
			// HousingMovingDateDText
			// 
			this.HousingMovingDateDText.CanGrow = false;
			this.HousingMovingDateDText.Height = 0.15F;
			this.HousingMovingDateDText.Left = 2.621F;
			this.HousingMovingDateDText.Name = "HousingMovingDateDText";
			this.HousingMovingDateDText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateDText.Text = "99";
			this.HousingMovingDateDText.Top = 3.862F;
			this.HousingMovingDateDText.Width = 0.13F;
			// 
			// HousingMovingDate2DText
			// 
			this.HousingMovingDate2DText.CanGrow = false;
			this.HousingMovingDate2DText.Height = 0.15F;
			this.HousingMovingDate2DText.Left = 2.621F;
			this.HousingMovingDate2DText.Name = "HousingMovingDate2DText";
			this.HousingMovingDate2DText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2DText.Text = "99";
			this.HousingMovingDate2DText.Top = 4.14F;
			this.HousingMovingDate2DText.Width = 0.13F;
			// 
			// HousingMovingDateText
			// 
			this.HousingMovingDateText.CanGrow = false;
			this.HousingMovingDateText.DataField = "HOUSING_MOVING_DATE";
			this.HousingMovingDateText.Height = 0.08000014F;
			this.HousingMovingDateText.Left = 1.938F;
			this.HousingMovingDateText.Name = "HousingMovingDateText";
			this.HousingMovingDateText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateText.Text = "9999";
			this.HousingMovingDateText.Top = 3.762F;
			this.HousingMovingDateText.Visible = false;
			this.HousingMovingDateText.Width = 0.204F;
			// 
			// HousingMovingDate2Text
			// 
			this.HousingMovingDate2Text.CanGrow = false;
			this.HousingMovingDate2Text.DataField = "HOUSING_MOVING_DATE2";
			this.HousingMovingDate2Text.Height = 0.08000014F;
			this.HousingMovingDate2Text.Left = 1.938F;
			this.HousingMovingDate2Text.Name = "HousingMovingDate2Text";
			this.HousingMovingDate2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2Text.Text = "9999";
			this.HousingMovingDate2Text.Top = 4.04F;
			this.HousingMovingDate2Text.Visible = false;
			this.HousingMovingDate2Text.Width = 0.204F;
			// 
			// SpecDedTypeText
			// 
			this.SpecDedTypeText.CanGrow = false;
			this.SpecDedTypeText.DataField = "SPEC_DED_TYPE1";
			this.SpecDedTypeText.Height = 0.15F;
			this.SpecDedTypeText.Left = 3.408661F;
			this.SpecDedTypeText.Name = "SpecDedTypeText";
			this.SpecDedTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SpecDedTypeText.Text = "増(特特特)";
			this.SpecDedTypeText.Top = 3.862F;
			this.SpecDedTypeText.Width = 0.4822835F;
			// 
			// SpecDedType2Text
			// 
			this.SpecDedType2Text.CanGrow = false;
			this.SpecDedType2Text.DataField = "SPEC_DED_TYPE2";
			this.SpecDedType2Text.Height = 0.15F;
			this.SpecDedType2Text.Left = 3.408661F;
			this.SpecDedType2Text.Name = "SpecDedType2Text";
			this.SpecDedType2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SpecDedType2Text.Text = "増(特特特)";
			this.SpecDedType2Text.Top = 4.14F;
			this.SpecDedType2Text.Width = 0.4822835F;
			// 
			// EyLoanBalanceText
			// 
			this.EyLoanBalanceText.CanGrow = false;
			this.EyLoanBalanceText.DataField = "EY_LOAN_BALANCE";
			this.EyLoanBalanceText.Height = 0.15F;
			this.EyLoanBalanceText.Left = 4.513F;
			this.EyLoanBalanceText.Name = "EyLoanBalanceText";
			this.EyLoanBalanceText.OutputFormat = "#,##0";
			this.EyLoanBalanceText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.EyLoanBalanceText.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.EyLoanBalanceText.Top = 3.862F;
			this.EyLoanBalanceText.Width = 0.7F;
			// 
			// EyLoanBalance2Text
			// 
			this.EyLoanBalance2Text.CanGrow = false;
			this.EyLoanBalance2Text.DataField = "EY_LOAN_BALANCE2";
			this.EyLoanBalance2Text.Height = 0.15F;
			this.EyLoanBalance2Text.Left = 4.513F;
			this.EyLoanBalance2Text.Name = "EyLoanBalance2Text";
			this.EyLoanBalance2Text.OutputFormat = "#,##0";
			this.EyLoanBalance2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.EyLoanBalance2Text.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.EyLoanBalance2Text.Top = 4.14F;
			this.EyLoanBalance2Text.Width = 0.7F;
			// 
			// NationalPensPremText
			// 
			this.NationalPensPremText.CanGrow = false;
			this.NationalPensPremText.DataField = "NATIONAL_PENS_PREM";
			this.NationalPensPremText.Height = 0.153F;
			this.NationalPensPremText.Left = 3.929922F;
			this.NationalPensPremText.Name = "NationalPensPremText";
			this.NationalPensPremText.OutputFormat = "#,##0";
			this.NationalPensPremText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.NationalPensPremText.Text = "ZZ,ZZZ,ZZ6";
			this.NationalPensPremText.Top = 4.457874F;
			this.NationalPensPremText.Width = 0.45F;
			// 
			// SposNonResTypeText
			// 
			this.SposNonResTypeText.CanGrow = false;
			this.SposNonResTypeText.DataField = "SPOS_NON_RES_TYPE";
			this.SposNonResTypeText.Height = 0.2F;
			this.SposNonResTypeText.Left = 2.22F;
			this.SposNonResTypeText.Name = "SposNonResTypeText";
			this.SposNonResTypeText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SposNonResTypeText.Text = "○";
			this.SposNonResTypeText.Top = 4.458F;
			this.SposNonResTypeText.Width = 0.2F;
			// 
			// DpndNonResType1_Text
			// 
			this.DpndNonResType1_Text.CanGrow = false;
			this.DpndNonResType1_Text.DataField = "DPND_NON_RES_TYPE1";
			this.DpndNonResType1_Text.Height = 0.2F;
			this.DpndNonResType1_Text.Left = 2.22F;
			this.DpndNonResType1_Text.Name = "DpndNonResType1_Text";
			this.DpndNonResType1_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType1_Text.Text = "○";
			this.DpndNonResType1_Text.Top = 4.963F;
			this.DpndNonResType1_Text.Width = 0.2F;
			// 
			// SposNameKana_Text
			// 
			this.SposNameKana_Text.CanGrow = false;
			this.SposNameKana_Text.DataField = "SPOS_NAME_KANA";
			this.SposNameKana_Text.Height = 0.14F;
			this.SposNameKana_Text.Left = 0.755F;
			this.SposNameKana_Text.Name = "SposNameKana_Text";
			this.SposNameKana_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposNameKana_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.SposNameKana_Text.Top = 4.416F;
			this.SposNameKana_Text.Width = 1.4F;
			// 
			// SposName_Text
			// 
			this.SposName_Text.CanGrow = false;
			this.SposName_Text.DataField = "SPOS_NAME";
			this.SposName_Text.Height = 0.14F;
			this.SposName_Text.Left = 0.755F;
			this.SposName_Text.Name = "SposName_Text";
			this.SposName_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposName_Text.Text = "あいうえおかきくけこあいうえ";
			this.SposName_Text.Top = 4.605F;
			this.SposName_Text.Width = 1.4F;
			// 
			// DpndNameKana1_Text
			// 
			this.DpndNameKana1_Text.CanGrow = false;
			this.DpndNameKana1_Text.DataField = "DPND_NAME_KANA1";
			this.DpndNameKana1_Text.Height = 0.14F;
			this.DpndNameKana1_Text.Left = 0.755F;
			this.DpndNameKana1_Text.Name = "DpndNameKana1_Text";
			this.DpndNameKana1_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana1_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana1_Text.Top = 4.905F;
			this.DpndNameKana1_Text.Width = 1.4F;
			// 
			// DpndName1_Text
			// 
			this.DpndName1_Text.CanGrow = false;
			this.DpndName1_Text.DataField = "DPND_NAME1";
			this.DpndName1_Text.Height = 0.14F;
			this.DpndName1_Text.Left = 0.755F;
			this.DpndName1_Text.Name = "DpndName1_Text";
			this.DpndName1_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName1_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName1_Text.Top = 5.103F;
			this.DpndName1_Text.Width = 1.4F;
			// 
			// DpndNameKana2_Text
			// 
			this.DpndNameKana2_Text.CanGrow = false;
			this.DpndNameKana2_Text.DataField = "DPND_NAME_KANA2";
			this.DpndNameKana2_Text.Height = 0.14F;
			this.DpndNameKana2_Text.Left = 0.755F;
			this.DpndNameKana2_Text.Name = "DpndNameKana2_Text";
			this.DpndNameKana2_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana2_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana2_Text.Top = 5.404F;
			this.DpndNameKana2_Text.Width = 1.4F;
			// 
			// DpndName2_Text
			// 
			this.DpndName2_Text.CanGrow = false;
			this.DpndName2_Text.DataField = "DPND_NAME2";
			this.DpndName2_Text.Height = 0.14F;
			this.DpndName2_Text.Left = 0.755F;
			this.DpndName2_Text.Name = "DpndName2_Text";
			this.DpndName2_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName2_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName2_Text.Top = 5.601F;
			this.DpndName2_Text.Width = 1.4F;
			// 
			// DpndNonResType2_Text
			// 
			this.DpndNonResType2_Text.CanGrow = false;
			this.DpndNonResType2_Text.DataField = "DPND_NON_RES_TYPE2";
			this.DpndNonResType2_Text.Height = 0.2F;
			this.DpndNonResType2_Text.Left = 2.22F;
			this.DpndNonResType2_Text.Name = "DpndNonResType2_Text";
			this.DpndNonResType2_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType2_Text.Text = "○";
			this.DpndNonResType2_Text.Top = 5.468F;
			this.DpndNonResType2_Text.Width = 0.2F;
			// 
			// DpndNameKana3_Text
			// 
			this.DpndNameKana3_Text.CanGrow = false;
			this.DpndNameKana3_Text.DataField = "DPND_NAME_KANA3";
			this.DpndNameKana3_Text.Height = 0.14F;
			this.DpndNameKana3_Text.Left = 0.755F;
			this.DpndNameKana3_Text.Name = "DpndNameKana3_Text";
			this.DpndNameKana3_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana3_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana3_Text.Top = 5.903F;
			this.DpndNameKana3_Text.Width = 1.4F;
			// 
			// DpndName3_Text
			// 
			this.DpndName3_Text.CanGrow = false;
			this.DpndName3_Text.DataField = "DPND_NAME3";
			this.DpndName3_Text.Height = 0.14F;
			this.DpndName3_Text.Left = 0.755F;
			this.DpndName3_Text.Name = "DpndName3_Text";
			this.DpndName3_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName3_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName3_Text.Top = 6.099F;
			this.DpndName3_Text.Width = 1.4F;
			// 
			// DpndNonResType3_Text
			// 
			this.DpndNonResType3_Text.CanGrow = false;
			this.DpndNonResType3_Text.DataField = "DPND_NON_RES_TYPE3";
			this.DpndNonResType3_Text.Height = 0.1999998F;
			this.DpndNonResType3_Text.Left = 2.22F;
			this.DpndNonResType3_Text.Name = "DpndNonResType3_Text";
			this.DpndNonResType3_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType3_Text.Text = "○";
			this.DpndNonResType3_Text.Top = 5.973F;
			this.DpndNonResType3_Text.Width = 0.2F;
			// 
			// DpndNameKana4_Text
			// 
			this.DpndNameKana4_Text.CanGrow = false;
			this.DpndNameKana4_Text.DataField = "DPND_NAME_KANA4";
			this.DpndNameKana4_Text.Height = 0.14F;
			this.DpndNameKana4_Text.Left = 0.755F;
			this.DpndNameKana4_Text.Name = "DpndNameKana4_Text";
			this.DpndNameKana4_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana4_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana4_Text.Top = 6.392F;
			this.DpndNameKana4_Text.Width = 1.4F;
			// 
			// DpndName4_Text
			// 
			this.DpndName4_Text.CanGrow = false;
			this.DpndName4_Text.DataField = "DPND_NAME4";
			this.DpndName4_Text.Height = 0.14F;
			this.DpndName4_Text.Left = 0.755F;
			this.DpndName4_Text.Name = "DpndName4_Text";
			this.DpndName4_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName4_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName4_Text.Top = 6.597F;
			this.DpndName4_Text.Width = 1.4F;
			// 
			// DpndNonResType4_Text
			// 
			this.DpndNonResType4_Text.CanGrow = false;
			this.DpndNonResType4_Text.DataField = "DPND_NON_RES_TYPE4";
			this.DpndNonResType4_Text.Height = 0.2F;
			this.DpndNonResType4_Text.Left = 2.22F;
			this.DpndNonResType4_Text.Name = "DpndNonResType4_Text";
			this.DpndNonResType4_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType4_Text.Text = "○";
			this.DpndNonResType4_Text.Top = 6.478F;
			this.DpndNonResType4_Text.Width = 0.2F;
			// 
			// YngDpndNameKana1_Text
			// 
			this.YngDpndNameKana1_Text.CanGrow = false;
			this.YngDpndNameKana1_Text.DataField = "YNG_DPND_NAME_KANA1";
			this.YngDpndNameKana1_Text.Height = 0.14F;
			this.YngDpndNameKana1_Text.Left = 3.029F;
			this.YngDpndNameKana1_Text.Name = "YngDpndNameKana1_Text";
			this.YngDpndNameKana1_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana1_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana1_Text.Top = 4.905F;
			this.YngDpndNameKana1_Text.Width = 1.4F;
			// 
			// YngDpndName1_Text
			// 
			this.YngDpndName1_Text.CanGrow = false;
			this.YngDpndName1_Text.DataField = "YNG_DPND_NAME1";
			this.YngDpndName1_Text.Height = 0.14F;
			this.YngDpndName1_Text.Left = 3.029F;
			this.YngDpndName1_Text.Name = "YngDpndName1_Text";
			this.YngDpndName1_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName1_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName1_Text.Top = 5.103F;
			this.YngDpndName1_Text.Width = 1.4F;
			// 
			// YngDpndNonRexType1_Text
			// 
			this.YngDpndNonRexType1_Text.CanGrow = false;
			this.YngDpndNonRexType1_Text.DataField = "YNG_DPND_NON_RES_TYPE1";
			this.YngDpndNonRexType1_Text.Height = 0.2F;
			this.YngDpndNonRexType1_Text.Left = 4.513F;
			this.YngDpndNonRexType1_Text.Name = "YngDpndNonRexType1_Text";
			this.YngDpndNonRexType1_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType1_Text.Text = "○";
			this.YngDpndNonRexType1_Text.Top = 4.963F;
			this.YngDpndNonRexType1_Text.Width = 0.2F;
			// 
			// YngDpndName2_Text
			// 
			this.YngDpndName2_Text.CanGrow = false;
			this.YngDpndName2_Text.DataField = "YNG_DPND_NAME2";
			this.YngDpndName2_Text.Height = 0.14F;
			this.YngDpndName2_Text.Left = 3.029F;
			this.YngDpndName2_Text.Name = "YngDpndName2_Text";
			this.YngDpndName2_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName2_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName2_Text.Top = 5.601F;
			this.YngDpndName2_Text.Width = 1.4F;
			// 
			// YngDpndNameKana2_Text
			// 
			this.YngDpndNameKana2_Text.CanGrow = false;
			this.YngDpndNameKana2_Text.DataField = "YNG_DPND_NAME_KANA2";
			this.YngDpndNameKana2_Text.Height = 0.14F;
			this.YngDpndNameKana2_Text.Left = 3.029F;
			this.YngDpndNameKana2_Text.Name = "YngDpndNameKana2_Text";
			this.YngDpndNameKana2_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana2_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana2_Text.Top = 5.404F;
			this.YngDpndNameKana2_Text.Width = 1.4F;
			// 
			// YngDpndNonRexType2_Text
			// 
			this.YngDpndNonRexType2_Text.CanGrow = false;
			this.YngDpndNonRexType2_Text.DataField = "YNG_DPND_NON_RES_TYPE2";
			this.YngDpndNonRexType2_Text.Height = 0.2F;
			this.YngDpndNonRexType2_Text.Left = 4.513F;
			this.YngDpndNonRexType2_Text.Name = "YngDpndNonRexType2_Text";
			this.YngDpndNonRexType2_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType2_Text.Text = "○";
			this.YngDpndNonRexType2_Text.Top = 5.468F;
			this.YngDpndNonRexType2_Text.Width = 0.2F;
			// 
			// YngDpndName3_Text
			// 
			this.YngDpndName3_Text.CanGrow = false;
			this.YngDpndName3_Text.DataField = "YNG_DPND_NAME3";
			this.YngDpndName3_Text.Height = 0.14F;
			this.YngDpndName3_Text.Left = 3.029F;
			this.YngDpndName3_Text.Name = "YngDpndName3_Text";
			this.YngDpndName3_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName3_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName3_Text.Top = 6.099F;
			this.YngDpndName3_Text.Width = 1.4F;
			// 
			// YngDpndNameKana3_Text
			// 
			this.YngDpndNameKana3_Text.CanGrow = false;
			this.YngDpndNameKana3_Text.DataField = "YNG_DPND_NAME_KANA3";
			this.YngDpndNameKana3_Text.Height = 0.14F;
			this.YngDpndNameKana3_Text.Left = 3.029F;
			this.YngDpndNameKana3_Text.Name = "YngDpndNameKana3_Text";
			this.YngDpndNameKana3_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana3_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana3_Text.Top = 5.903F;
			this.YngDpndNameKana3_Text.Width = 1.4F;
			// 
			// YngDpndNonRexType3_Text
			// 
			this.YngDpndNonRexType3_Text.CanGrow = false;
			this.YngDpndNonRexType3_Text.DataField = "YNG_DPND_NON_RES_TYPE3";
			this.YngDpndNonRexType3_Text.Height = 0.2F;
			this.YngDpndNonRexType3_Text.Left = 4.513F;
			this.YngDpndNonRexType3_Text.Name = "YngDpndNonRexType3_Text";
			this.YngDpndNonRexType3_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType3_Text.Text = "○";
			this.YngDpndNonRexType3_Text.Top = 5.973F;
			this.YngDpndNonRexType3_Text.Width = 0.2F;
			// 
			// YngDpndNameKana4_Text
			// 
			this.YngDpndNameKana4_Text.CanGrow = false;
			this.YngDpndNameKana4_Text.DataField = "YNG_DPND_NAME_KANA4";
			this.YngDpndNameKana4_Text.Height = 0.14F;
			this.YngDpndNameKana4_Text.Left = 3.029F;
			this.YngDpndNameKana4_Text.Name = "YngDpndNameKana4_Text";
			this.YngDpndNameKana4_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana4_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana4_Text.Top = 6.392F;
			this.YngDpndNameKana4_Text.Width = 1.4F;
			// 
			// YngDpndName4_Text
			// 
			this.YngDpndName4_Text.CanGrow = false;
			this.YngDpndName4_Text.DataField = "YNG_DPND_NAME4";
			this.YngDpndName4_Text.Height = 0.14F;
			this.YngDpndName4_Text.Left = 3.029F;
			this.YngDpndName4_Text.Name = "YngDpndName4_Text";
			this.YngDpndName4_Text.Style = "font-size: 7pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName4_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName4_Text.Top = 6.597F;
			this.YngDpndName4_Text.Width = 1.4F;
			// 
			// YngDpndNonRexType4_Text
			// 
			this.YngDpndNonRexType4_Text.CanGrow = false;
			this.YngDpndNonRexType4_Text.DataField = "YNG_DPND_NON_RES_TYPE4";
			this.YngDpndNonRexType4_Text.Height = 0.1999998F;
			this.YngDpndNonRexType4_Text.Left = 4.513F;
			this.YngDpndNonRexType4_Text.Name = "YngDpndNonRexType4_Text";
			this.YngDpndNonRexType4_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType4_Text.Text = "○";
			this.YngDpndNonRexType4_Text.Top = 6.478F;
			this.YngDpndNonRexType4_Text.Width = 0.1999998F;
			// 
			// HousingObtDedCntText
			// 
			this.HousingObtDedCntText.CanGrow = false;
			this.HousingObtDedCntText.DataField = "HOUSING_OBT_DED_CNT";
			this.HousingObtDedCntText.Height = 0.15F;
			this.HousingObtDedCntText.Left = 1.08F;
			this.HousingObtDedCntText.Name = "HousingObtDedCntText";
			this.HousingObtDedCntText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.HousingObtDedCntText.Text = "999";
			this.HousingObtDedCntText.Top = 3.862F;
			this.HousingObtDedCntText.Width = 0.3F;
			// 
			// MyNumber1_3Text
			// 
			this.MyNumber1_3Text.CanGrow = false;
			this.MyNumber1_3Text.Height = 0.15F;
			this.MyNumber1_3Text.Left = 4.91F;
			this.MyNumber1_3Text.Name = "MyNumber1_3Text";
			this.MyNumber1_3Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_3Text.Text = "1234";
			this.MyNumber1_3Text.Top = 0.44F;
			this.MyNumber1_3Text.Width = 0.35F;
			// 
			// MyNumber1_2Text
			// 
			this.MyNumber1_2Text.CanGrow = false;
			this.MyNumber1_2Text.Height = 0.15F;
			this.MyNumber1_2Text.Left = 4.36F;
			this.MyNumber1_2Text.Name = "MyNumber1_2Text";
			this.MyNumber1_2Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_2Text.Text = "1234";
			this.MyNumber1_2Text.Top = 0.44F;
			this.MyNumber1_2Text.Width = 0.35F;
			// 
			// MyNumber1_1Text
			// 
			this.MyNumber1_1Text.CanGrow = false;
			this.MyNumber1_1Text.Height = 0.15F;
			this.MyNumber1_1Text.Left = 3.81F;
			this.MyNumber1_1Text.Name = "MyNumber1_1Text";
			this.MyNumber1_1Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_1Text.Text = "1234";
			this.MyNumber1_1Text.Top = 0.44F;
			this.MyNumber1_1Text.Width = 0.35F;
			// 
			// SposMyNumber1_1Text
			// 
			this.SposMyNumber1_1Text.CanGrow = false;
			this.SposMyNumber1_1Text.Height = 0.14F;
			this.SposMyNumber1_1Text.Left = 0.855F;
			this.SposMyNumber1_1Text.Name = "SposMyNumber1_1Text";
			this.SposMyNumber1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_1Text.Text = "1234";
			this.SposMyNumber1_1Text.Top = 4.745F;
			this.SposMyNumber1_1Text.Width = 0.355F;
			// 
			// SposMyNumber1_2Text
			// 
			this.SposMyNumber1_2Text.CanGrow = false;
			this.SposMyNumber1_2Text.Height = 0.14F;
			this.SposMyNumber1_2Text.Left = 1.3F;
			this.SposMyNumber1_2Text.Name = "SposMyNumber1_2Text";
			this.SposMyNumber1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_2Text.Text = "1234";
			this.SposMyNumber1_2Text.Top = 4.745F;
			this.SposMyNumber1_2Text.Width = 0.355F;
			// 
			// SposMyNumber1_3Text
			// 
			this.SposMyNumber1_3Text.CanGrow = false;
			this.SposMyNumber1_3Text.Height = 0.14F;
			this.SposMyNumber1_3Text.Left = 1.745F;
			this.SposMyNumber1_3Text.Name = "SposMyNumber1_3Text";
			this.SposMyNumber1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_3Text.Text = "1234";
			this.SposMyNumber1_3Text.Top = 4.745F;
			this.SposMyNumber1_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_1_1Text
			// 
			this.DpndMyNumber1_1_1Text.CanGrow = false;
			this.DpndMyNumber1_1_1Text.Height = 0.14F;
			this.DpndMyNumber1_1_1Text.Left = 0.855F;
			this.DpndMyNumber1_1_1Text.Name = "DpndMyNumber1_1_1Text";
			this.DpndMyNumber1_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_1Text.Text = "1234";
			this.DpndMyNumber1_1_1Text.Top = 5.248F;
			this.DpndMyNumber1_1_1Text.Width = 0.355F;
			// 
			// DpndMyNumber1_1_2Text
			// 
			this.DpndMyNumber1_1_2Text.CanGrow = false;
			this.DpndMyNumber1_1_2Text.Height = 0.14F;
			this.DpndMyNumber1_1_2Text.Left = 1.3F;
			this.DpndMyNumber1_1_2Text.Name = "DpndMyNumber1_1_2Text";
			this.DpndMyNumber1_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_2Text.Text = "1234";
			this.DpndMyNumber1_1_2Text.Top = 5.248F;
			this.DpndMyNumber1_1_2Text.Width = 0.355F;
			// 
			// DpndMyNumber1_1_3Text
			// 
			this.DpndMyNumber1_1_3Text.CanGrow = false;
			this.DpndMyNumber1_1_3Text.Height = 0.14F;
			this.DpndMyNumber1_1_3Text.Left = 1.745F;
			this.DpndMyNumber1_1_3Text.Name = "DpndMyNumber1_1_3Text";
			this.DpndMyNumber1_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_3Text.Text = "1234";
			this.DpndMyNumber1_1_3Text.Top = 5.248F;
			this.DpndMyNumber1_1_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_2_1Text
			// 
			this.DpndMyNumber1_2_1Text.CanGrow = false;
			this.DpndMyNumber1_2_1Text.Height = 0.14F;
			this.DpndMyNumber1_2_1Text.Left = 0.855F;
			this.DpndMyNumber1_2_1Text.Name = "DpndMyNumber1_2_1Text";
			this.DpndMyNumber1_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_1Text.Text = "1234";
			this.DpndMyNumber1_2_1Text.Top = 5.751F;
			this.DpndMyNumber1_2_1Text.Width = 0.355F;
			// 
			// DpndMyNumber1_2_2Text
			// 
			this.DpndMyNumber1_2_2Text.CanGrow = false;
			this.DpndMyNumber1_2_2Text.Height = 0.14F;
			this.DpndMyNumber1_2_2Text.Left = 1.3F;
			this.DpndMyNumber1_2_2Text.Name = "DpndMyNumber1_2_2Text";
			this.DpndMyNumber1_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_2Text.Text = "1234";
			this.DpndMyNumber1_2_2Text.Top = 5.751F;
			this.DpndMyNumber1_2_2Text.Width = 0.355F;
			// 
			// DpndMyNumber1_2_3Text
			// 
			this.DpndMyNumber1_2_3Text.CanGrow = false;
			this.DpndMyNumber1_2_3Text.Height = 0.14F;
			this.DpndMyNumber1_2_3Text.Left = 1.745F;
			this.DpndMyNumber1_2_3Text.Name = "DpndMyNumber1_2_3Text";
			this.DpndMyNumber1_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_3Text.Text = "1234";
			this.DpndMyNumber1_2_3Text.Top = 5.751F;
			this.DpndMyNumber1_2_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_3_1Text
			// 
			this.DpndMyNumber1_3_1Text.CanGrow = false;
			this.DpndMyNumber1_3_1Text.Height = 0.14F;
			this.DpndMyNumber1_3_1Text.Left = 0.855F;
			this.DpndMyNumber1_3_1Text.Name = "DpndMyNumber1_3_1Text";
			this.DpndMyNumber1_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_1Text.Text = "1234";
			this.DpndMyNumber1_3_1Text.Top = 6.254F;
			this.DpndMyNumber1_3_1Text.Width = 0.355F;
			// 
			// DpndMyNumber1_3_2Text
			// 
			this.DpndMyNumber1_3_2Text.CanGrow = false;
			this.DpndMyNumber1_3_2Text.Height = 0.14F;
			this.DpndMyNumber1_3_2Text.Left = 1.3F;
			this.DpndMyNumber1_3_2Text.Name = "DpndMyNumber1_3_2Text";
			this.DpndMyNumber1_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_2Text.Text = "1234";
			this.DpndMyNumber1_3_2Text.Top = 6.254F;
			this.DpndMyNumber1_3_2Text.Width = 0.355F;
			// 
			// DpndMyNumber1_3_3Text
			// 
			this.DpndMyNumber1_3_3Text.CanGrow = false;
			this.DpndMyNumber1_3_3Text.Height = 0.14F;
			this.DpndMyNumber1_3_3Text.Left = 1.745F;
			this.DpndMyNumber1_3_3Text.Name = "DpndMyNumber1_3_3Text";
			this.DpndMyNumber1_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_3Text.Text = "1234";
			this.DpndMyNumber1_3_3Text.Top = 6.254F;
			this.DpndMyNumber1_3_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_4_1Text
			// 
			this.DpndMyNumber1_4_1Text.CanGrow = false;
			this.DpndMyNumber1_4_1Text.Height = 0.14F;
			this.DpndMyNumber1_4_1Text.Left = 0.855F;
			this.DpndMyNumber1_4_1Text.Name = "DpndMyNumber1_4_1Text";
			this.DpndMyNumber1_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_1Text.Text = "1234";
			this.DpndMyNumber1_4_1Text.Top = 6.757F;
			this.DpndMyNumber1_4_1Text.Width = 0.355F;
			// 
			// DpndMyNumber1_4_2Text
			// 
			this.DpndMyNumber1_4_2Text.CanGrow = false;
			this.DpndMyNumber1_4_2Text.Height = 0.14F;
			this.DpndMyNumber1_4_2Text.Left = 1.3F;
			this.DpndMyNumber1_4_2Text.Name = "DpndMyNumber1_4_2Text";
			this.DpndMyNumber1_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_2Text.Text = "1234";
			this.DpndMyNumber1_4_2Text.Top = 6.757F;
			this.DpndMyNumber1_4_2Text.Width = 0.355F;
			// 
			// DpndMyNumber1_4_3Text
			// 
			this.DpndMyNumber1_4_3Text.CanGrow = false;
			this.DpndMyNumber1_4_3Text.Height = 0.14F;
			this.DpndMyNumber1_4_3Text.Left = 1.745F;
			this.DpndMyNumber1_4_3Text.Name = "DpndMyNumber1_4_3Text";
			this.DpndMyNumber1_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_3Text.Text = "1234";
			this.DpndMyNumber1_4_3Text.Top = 6.757F;
			this.DpndMyNumber1_4_3Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_4_3Text
			// 
			this.YngDpndMyNumber1_4_3Text.CanGrow = false;
			this.YngDpndMyNumber1_4_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_3Text.Left = 4.113F;
			this.YngDpndMyNumber1_4_3Text.Name = "YngDpndMyNumber1_4_3Text";
			this.YngDpndMyNumber1_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_3Text.Text = "1234";
			this.YngDpndMyNumber1_4_3Text.Top = 6.757F;
			this.YngDpndMyNumber1_4_3Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_1_1Text
			// 
			this.YngDpndMyNumber1_1_1Text.CanGrow = false;
			this.YngDpndMyNumber1_1_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_1Text.Left = 3.223F;
			this.YngDpndMyNumber1_1_1Text.Name = "YngDpndMyNumber1_1_1Text";
			this.YngDpndMyNumber1_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_1Text.Text = "1234";
			this.YngDpndMyNumber1_1_1Text.Top = 5.248F;
			this.YngDpndMyNumber1_1_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_1_2Text
			// 
			this.YngDpndMyNumber1_1_2Text.CanGrow = false;
			this.YngDpndMyNumber1_1_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_2Text.Left = 3.668F;
			this.YngDpndMyNumber1_1_2Text.Name = "YngDpndMyNumber1_1_2Text";
			this.YngDpndMyNumber1_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_2Text.Text = "1234";
			this.YngDpndMyNumber1_1_2Text.Top = 5.248F;
			this.YngDpndMyNumber1_1_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_1_3Text
			// 
			this.YngDpndMyNumber1_1_3Text.CanGrow = false;
			this.YngDpndMyNumber1_1_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_3Text.Left = 4.113F;
			this.YngDpndMyNumber1_1_3Text.Name = "YngDpndMyNumber1_1_3Text";
			this.YngDpndMyNumber1_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_3Text.Text = "1234";
			this.YngDpndMyNumber1_1_3Text.Top = 5.248F;
			this.YngDpndMyNumber1_1_3Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_2_1Text
			// 
			this.YngDpndMyNumber1_2_1Text.CanGrow = false;
			this.YngDpndMyNumber1_2_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_1Text.Left = 3.223F;
			this.YngDpndMyNumber1_2_1Text.Name = "YngDpndMyNumber1_2_1Text";
			this.YngDpndMyNumber1_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_1Text.Text = "1234";
			this.YngDpndMyNumber1_2_1Text.Top = 5.751F;
			this.YngDpndMyNumber1_2_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_2_2Text
			// 
			this.YngDpndMyNumber1_2_2Text.CanGrow = false;
			this.YngDpndMyNumber1_2_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_2Text.Left = 3.668F;
			this.YngDpndMyNumber1_2_2Text.Name = "YngDpndMyNumber1_2_2Text";
			this.YngDpndMyNumber1_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_2Text.Text = "1234";
			this.YngDpndMyNumber1_2_2Text.Top = 5.751F;
			this.YngDpndMyNumber1_2_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_2_3Text
			// 
			this.YngDpndMyNumber1_2_3Text.CanGrow = false;
			this.YngDpndMyNumber1_2_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_3Text.Left = 4.113F;
			this.YngDpndMyNumber1_2_3Text.Name = "YngDpndMyNumber1_2_3Text";
			this.YngDpndMyNumber1_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_3Text.Text = "1234";
			this.YngDpndMyNumber1_2_3Text.Top = 5.751F;
			this.YngDpndMyNumber1_2_3Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_3_1Text
			// 
			this.YngDpndMyNumber1_3_1Text.CanGrow = false;
			this.YngDpndMyNumber1_3_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_1Text.Left = 3.223F;
			this.YngDpndMyNumber1_3_1Text.Name = "YngDpndMyNumber1_3_1Text";
			this.YngDpndMyNumber1_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_1Text.Text = "1234";
			this.YngDpndMyNumber1_3_1Text.Top = 6.254F;
			this.YngDpndMyNumber1_3_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_3_2Text
			// 
			this.YngDpndMyNumber1_3_2Text.CanGrow = false;
			this.YngDpndMyNumber1_3_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_2Text.Left = 3.668F;
			this.YngDpndMyNumber1_3_2Text.Name = "YngDpndMyNumber1_3_2Text";
			this.YngDpndMyNumber1_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_2Text.Text = "1234";
			this.YngDpndMyNumber1_3_2Text.Top = 6.254F;
			this.YngDpndMyNumber1_3_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_3_3Text
			// 
			this.YngDpndMyNumber1_3_3Text.CanGrow = false;
			this.YngDpndMyNumber1_3_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_3Text.Left = 4.113F;
			this.YngDpndMyNumber1_3_3Text.Name = "YngDpndMyNumber1_3_3Text";
			this.YngDpndMyNumber1_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_3Text.Text = "1234";
			this.YngDpndMyNumber1_3_3Text.Top = 6.254F;
			this.YngDpndMyNumber1_3_3Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_4_1Text
			// 
			this.YngDpndMyNumber1_4_1Text.CanGrow = false;
			this.YngDpndMyNumber1_4_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_1Text.Left = 3.223F;
			this.YngDpndMyNumber1_4_1Text.Name = "YngDpndMyNumber1_4_1Text";
			this.YngDpndMyNumber1_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_1Text.Text = "1234";
			this.YngDpndMyNumber1_4_1Text.Top = 6.757F;
			this.YngDpndMyNumber1_4_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber1_4_2Text
			// 
			this.YngDpndMyNumber1_4_2Text.CanGrow = false;
			this.YngDpndMyNumber1_4_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_2Text.Left = 3.668F;
			this.YngDpndMyNumber1_4_2Text.Name = "YngDpndMyNumber1_4_2Text";
			this.YngDpndMyNumber1_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_2Text.Text = "1234";
			this.YngDpndMyNumber1_4_2Text.Top = 6.757F;
			this.YngDpndMyNumber1_4_2Text.Width = 0.355F;
			// 
			// SposMyNumber_Text
			// 
			this.SposMyNumber_Text.CanGrow = false;
			this.SposMyNumber_Text.DataField = "SPOS_MY_NUMBER";
			this.SposMyNumber_Text.Height = 0.07500042F;
			this.SposMyNumber_Text.Left = 0.735F;
			this.SposMyNumber_Text.Name = "SposMyNumber_Text";
			this.SposMyNumber_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber_Text.Text = "123456789012";
			this.SposMyNumber_Text.Top = 4.75F;
			this.SposMyNumber_Text.Visible = false;
			this.SposMyNumber_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber1_Text
			// 
			this.DpndMyNumber1_Text.CanGrow = false;
			this.DpndMyNumber1_Text.DataField = "DPND_MY_NUMBER1";
			this.DpndMyNumber1_Text.Height = 0.07500042F;
			this.DpndMyNumber1_Text.Left = 0.745F;
			this.DpndMyNumber1_Text.Name = "DpndMyNumber1_Text";
			this.DpndMyNumber1_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_Text.Text = "123456789012";
			this.DpndMyNumber1_Text.Top = 5.248F;
			this.DpndMyNumber1_Text.Visible = false;
			this.DpndMyNumber1_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber2_Text
			// 
			this.DpndMyNumber2_Text.CanGrow = false;
			this.DpndMyNumber2_Text.DataField = "DPND_MY_NUMBER2";
			this.DpndMyNumber2_Text.Height = 0.07500042F;
			this.DpndMyNumber2_Text.Left = 0.735F;
			this.DpndMyNumber2_Text.Name = "DpndMyNumber2_Text";
			this.DpndMyNumber2_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_Text.Text = "123456789012";
			this.DpndMyNumber2_Text.Top = 5.751F;
			this.DpndMyNumber2_Text.Visible = false;
			this.DpndMyNumber2_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber3_Text
			// 
			this.DpndMyNumber3_Text.CanGrow = false;
			this.DpndMyNumber3_Text.DataField = "DPND_MY_NUMBER3";
			this.DpndMyNumber3_Text.Height = 0.07500042F;
			this.DpndMyNumber3_Text.Left = 0.735F;
			this.DpndMyNumber3_Text.Name = "DpndMyNumber3_Text";
			this.DpndMyNumber3_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber3_Text.Text = "123456789012";
			this.DpndMyNumber3_Text.Top = 6.257F;
			this.DpndMyNumber3_Text.Visible = false;
			this.DpndMyNumber3_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber4_Text
			// 
			this.DpndMyNumber4_Text.CanGrow = false;
			this.DpndMyNumber4_Text.DataField = "DPND_MY_NUMBER4";
			this.DpndMyNumber4_Text.Height = 0.07500042F;
			this.DpndMyNumber4_Text.Left = 0.735F;
			this.DpndMyNumber4_Text.Name = "DpndMyNumber4_Text";
			this.DpndMyNumber4_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber4_Text.Text = "123456789012";
			this.DpndMyNumber4_Text.Top = 6.757F;
			this.DpndMyNumber4_Text.Visible = false;
			this.DpndMyNumber4_Text.Width = 0.1826772F;
			// 
			// MyNumber_Text
			// 
			this.MyNumber_Text.CanGrow = false;
			this.MyNumber_Text.DataField = "MY_NUMBER";
			this.MyNumber_Text.Height = 0.1456693F;
			this.MyNumber_Text.Left = 3.52F;
			this.MyNumber_Text.Name = "MyNumber_Text";
			this.MyNumber_Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.MyNumber_Text.Text = "123456789012";
			this.MyNumber_Text.Top = 0.44F;
			this.MyNumber_Text.Visible = false;
			this.MyNumber_Text.Width = 0.2047246F;
			// 
			// YngDpndMyNumber1_Text
			// 
			this.YngDpndMyNumber1_Text.CanGrow = false;
			this.YngDpndMyNumber1_Text.DataField = "YNG_DPND_MY_NUMBER1";
			this.YngDpndMyNumber1_Text.Height = 0.07500042F;
			this.YngDpndMyNumber1_Text.Left = 2.945F;
			this.YngDpndMyNumber1_Text.Name = "YngDpndMyNumber1_Text";
			this.YngDpndMyNumber1_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_Text.Text = "123456789012";
			this.YngDpndMyNumber1_Text.Top = 5.248F;
			this.YngDpndMyNumber1_Text.Visible = false;
			this.YngDpndMyNumber1_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber4_Text
			// 
			this.YngDpndMyNumber4_Text.CanGrow = false;
			this.YngDpndMyNumber4_Text.DataField = "YNG_DPND_MY_NUMBER4";
			this.YngDpndMyNumber4_Text.Height = 0.07500042F;
			this.YngDpndMyNumber4_Text.Left = 2.955F;
			this.YngDpndMyNumber4_Text.Name = "YngDpndMyNumber4_Text";
			this.YngDpndMyNumber4_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber4_Text.Text = "123456789012";
			this.YngDpndMyNumber4_Text.Top = 6.757F;
			this.YngDpndMyNumber4_Text.Visible = false;
			this.YngDpndMyNumber4_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber3_Text
			// 
			this.YngDpndMyNumber3_Text.CanGrow = false;
			this.YngDpndMyNumber3_Text.DataField = "YNG_DPND_MY_NUMBER3";
			this.YngDpndMyNumber3_Text.Height = 0.07500042F;
			this.YngDpndMyNumber3_Text.Left = 2.955F;
			this.YngDpndMyNumber3_Text.Name = "YngDpndMyNumber3_Text";
			this.YngDpndMyNumber3_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber3_Text.Text = "123456789012";
			this.YngDpndMyNumber3_Text.Top = 6.254F;
			this.YngDpndMyNumber3_Text.Visible = false;
			this.YngDpndMyNumber3_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber2_Text
			// 
			this.YngDpndMyNumber2_Text.CanGrow = false;
			this.YngDpndMyNumber2_Text.DataField = "YNG_DPND_MY_NUMBER2";
			this.YngDpndMyNumber2_Text.Height = 0.07500042F;
			this.YngDpndMyNumber2_Text.Left = 2.955F;
			this.YngDpndMyNumber2_Text.Name = "YngDpndMyNumber2_Text";
			this.YngDpndMyNumber2_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_Text.Text = "123456789012";
			this.YngDpndMyNumber2_Text.Top = 5.751F;
			this.YngDpndMyNumber2_Text.Visible = false;
			this.YngDpndMyNumber2_Text.Width = 0.1826772F;
			// 
			// CorpNumber
			// 
			this.CorpNumber.CanGrow = false;
			this.CorpNumber.DataField = "CORP_NUMBER";
			this.CorpNumber.Height = 0.2F;
			this.CorpNumber.Left = 2.707F;
			this.CorpNumber.MultiLine = false;
			this.CorpNumber.Name = "CorpNumber";
			this.CorpNumber.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber.Text = null;
			this.CorpNumber.Top = 7.571F;
			this.CorpNumber.Visible = false;
			this.CorpNumber.Width = 0.3F;
			// 
			// incmAdjDedAmtText1
			// 
			this.incmAdjDedAmtText1.CanGrow = false;
			this.incmAdjDedAmtText1.DataField = "INCM_ADJ_DED_AMT";
			this.incmAdjDedAmtText1.Height = 0.153F;
			this.incmAdjDedAmtText1.Left = 4.909843F;
			this.incmAdjDedAmtText1.Name = "incmAdjDedAmtText1";
			this.incmAdjDedAmtText1.OutputFormat = "#,##0";
			this.incmAdjDedAmtText1.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmAdjDedAmtText1.Text = "ZZ,ZZZ,ZZ6";
			this.incmAdjDedAmtText1.Top = 4.716929F;
			this.incmAdjDedAmtText1.Width = 0.45F;
			// 
			// HR_PY_03_R53
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0F;
			this.PageSettings.Margins.Left = 0.1F;
			this.PageSettings.Margins.Right = 0.1F;
			this.PageSettings.Margins.Top = 0.1F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
			this.PageSettings.PaperHeight = 8.46F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PageSettings.PaperName = "ユーザー定義のサイズ";
			this.PageSettings.PaperWidth = 5.71F;
			this.PrintWidth = 11.22F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R53_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemarksText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NonResidentNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedPsblAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateYText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2YText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateMText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2MText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2DText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalanceText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalance2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NationalPensPremText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposNonResTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposNameKana_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposName_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNameKana4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndName4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndNonResType4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNameKana4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndName4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndNonRexType4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedCntText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_3_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_4_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion
	}
}
