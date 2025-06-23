// Product     : Allegro
// Unit        : HR
// Module      : PY
// Function    : 03
// File Name   : HR_PY_03_R63.cs
// 機能名      : HR_PY_03_R63 給与支払報告書(A4)
// Version     : 3.2.0
// Last Update : 2023/03/31
// Copyright (c) 2004-2023 Grandit Corp. All Rights Reserved.
//
// 2.3.0 2016/06/30
// 管理番号K26330 2016/07/27 マイナンバー帳票対応
// 管理番号K26528 2018/02/16 UI見直し
// 3.0.0 2018/04/30
// 管理番号K26715 2018/10/02 平成30年源泉徴収票レイアウト変更
// 3.1.0 2020/06/30
// 管理番号K27275 2021/06/11 住宅借入金等特別控除（特別特定取得）対応
// 管理番号K27274 2021/06/11 年末調整関連法改正(令和２年)
// 管理番号K27583 2023/01/23 住宅借入金等特別控除の控除区分追加
// 3.2.0 2023/03/31
// 管理番号K27665 2023/07/13 ActiveReportsバージョンアップ（SP4）対応

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
	public class HR_PY_03_R63 : GrapeCity.ActiveReports.SectionReport
	{
		public HR_PY_03_R63()
		{
			InitializeComponent();
		}

		#region Protected Fields
		protected string reportID;
		protected string companyName;
		private Line line1;
		private Line line2;
		private Line line3;
		private Label label14;
		private Label Label1078;
		private Label Label1079;
		private Label label4;
		private TextBox newLifeInsPensAmtText;
		private TextBox newLifeInsCareAmtText;
		private Label label20;
		private Label label24;
		private TextBox newLifeInsGeneralAmtText;
		private TextBox lifeInsGeneralAmtText;
		private TextBox summary1Digit0Text;
		private Line line26;
		private Line line31;
		private Line line32;
		private Label label2;
		private Label label3;
		private Label label1;
		private TextBox YoungDpndNumText;
		private Line line33;
		private Line line34;
		private Line line35;
		private Line line36;
		private Line line37;
		private Label label41;
		private Label label42;
		private Label label43;
		private Label label44;
		private Label label45;
		private Line line38;
		private Line line39;
		private Line line40;
		private Line line41;
		private Line line42;
		private Line line43;
		private Label label46;
		private Label label47;
		private Label label48;
		private Label label49;
		private Line line44;
		private Line line45;
		private Line line46;
		private Line line47;
		private Line line48;
		private Label label50;
		private Line line49;
		private Line line50;
		private Line line51;
		private Line line52;
		private Line line53;
		private Line line54;
		private Line line55;
		private Line line56;
		private Line line57;
		private Line line58;
		private Line line59;
		private Line line60;
		private Line line61;
		private Line line62;
		private Line line63;
		private Label label51;
		private Label label52;
		private Label label53;
		private Label label54;
		private Label label55;
		private Label label56;
		private Label label57;
		private Label label58;
		private Label label59;
		private Label label60;
		private Label label61;
		private Label label62;
		private Label label63;
		private Label label64;
		private Line line64;
		private Line line65;
		private Line line66;
		private Line line67;
		private Line line68;
		private Label label65;
		private Label label66;
		private Label label67;
		private Label label68;
		private Line line70;
		private Line line71;
		private Line line72;
		private Line line73;
		private Line line74;
		private Label label69;
		private Label label70;
		private Label label71;
		private Line line76;
		private Line line77;
		private Line line78;
		private Line line79;
		private Label label72;
		private Label label73;
		private Label label74;
		private Line line81;
		private Label label75;
		private Label label76;
		private Line line82;
		private Line line83;
		private Label label77;
		private Line line84;
		private Line line85;
		private Label label78;
		private Label label79;
		private Line line90;
		private Label label80;
		private Label label81;
		private Line line91;
		private Line line92;
		private Line line93;
		private Line line94;
		private Label label82;
		private Label label83;
		private Label label84;
		private Label label85;
		private Label label86;
		private Label label87;
		private Line line95;
		private Line line96;
		private Line line97;
		private Line line98;
		private Line line99;
		private Line line100;
		private Label label88;
		private Label label89;
		private Label label90;
		private Line line101;
		private Line line102;
		private Line line103;
		private Label label91;
		private Label label92;
		private Label label93;
		private Label label94;
		private Label label95;
		private Label label96;
		private Label label97;
		private Label label98;
		private Label label99;
		private Label label100;
		private Label label101;
		private Label label102;
		private Label label103;
		private Label label104;
		private Label label105;
		private Line line16;
		private Line line18;
		private Label label26;
		private Label label27;
		private Label label106;
		private Label label107;
		private Label label108;
		private Label label109;
		private Label label110;
		private Label label111;
		private Label label112;
		private Label label113;
		private Label label114;
		private Label label115;
		private Label label116;
		private Label label117;
		private Label label118;
		private Label label13;
		private Label label5;
		private Label label18;
		private Label label119;
		private Label label120;
		private Label label121;
		private Label label122;
		private Label label171;
		private Label label176;
		private Label label183;
		private Line line17;
		private Line line19;
		private Line line104;
		private Line line105;
		private Line line106;
		private Line line107;
		private Label label184;
		private Label label185;
		private Label label186;
		private Label label187;
		private Label label188;
		private Line line108;
		private Line line109;
		private Line line110;
		private Line line111;
		private Label label189;
		private Line line112;
		private Line line113;
		private Label label190;
		private Line line114;
		private TextBox NonResidentNumText;
		private Label label191;
		private Label label192;
		private Label label193;
		private Label label194;
		private Line line115;
		private Line line116;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label12;
		private Label label15;
		private TextBox ylyEdAddress1_2Text;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private Label label16;
		private Label label17;
		private Label label19;
		private Label label21;
		private Label label22;
		private Label label23;
		private Label label25;
		private TextBox textBox7;
		private TextBox textBox8;
		private Label label28;
		private Label label29;
		private TextBox textBox10;
		private Label label30;
		private TextBox textBox11;
		private Label label31;
		private Label label32;
		private TextBox textBox12;
		private Label label33;
		private Label label34;
		private Label label35;
		private Label label36;
		private Label label39;
		private Label label40;
		private TextBox textBox13;
		private TextBox textBox14;
		private TextBox textBox15;
		private Label label123;
		private TextBox textBox16;
		private Label label124;
		private Label label125;
		private Label label126;
		private Label label127;
		private Label label128;
		private Label label129;
		private TextBox textBox17;
		private TextBox textBox18;
		private Label label130;
		private Label label131;
		private TextBox textBox19;
		private Label label132;
		private TextBox textBox20;
		private TextBox textBox21;
		private Label label133;
		private Label label134;
		private TextBox textBox22;
		private Label label135;
		private TextBox textBox23;
		private Label label136;
		private Label label137;
		private TextBox textBox24;
		private TextBox textBox25;
		private Label label138;
		private Label label139;
		private Label label140;
		private Label label141;
		private Label label142;
		private TextBox textBox26;
		private Label label143;
		private TextBox textBox27;
		private Label label144;
		private TextBox textBox28;
		private TextBox textBox29;
		private TextBox textBox30;
		private TextBox textBox31;
		private TextBox textBox32;
		private Label label145;
		private Label label146;
		private Label label147;
		private Label label148;
		private Label label150;
		private Label label151;
		private Label label153;
		private Label label154;
		private Label label155;
		private Label label156;
		private Label label157;
		private Label label158;
		private Label label159;
		private TextBox textBox33;
		private Label label160;
		private TextBox textBox34;
		private TextBox textBox35;
		private TextBox textBox36;
		private TextBox textBox37;
		private TextBox textBox38;
		private TextBox textBox39;
		private TextBox textBox40;
		private TextBox textBox41;
		private Label label161;
		private Label label162;
		private Label label163;
		private TextBox textBox42;
		private TextBox textBox43;
		private Label label164;
		private TextBox textBox44;
		private Label label165;
		private Label label166;
		private Label label167;
		private Label label168;
		private Label label169;
		private Label label170;
		private Label label172;
		private Label label173;
		private Label label174;
		private TextBox textBox45;
		private TextBox textBox46;
		private TextBox textBox47;
		private Label label175;
		private TextBox textBox48;
		private Label label177;
		private TextBox textBox49;
		private Label label178;
		private TextBox textBox50;
		private TextBox textBox51;
		private TextBox textBox52;
		private TextBox textBox53;
		private Label label182;
		private Label label196;
		private TextBox textBox54;
		private TextBox textBox58;
		private TextBox textBox59;
		private TextBox textBox60;
		private TextBox textBox61;
		private Label label197;
		private Line line4;
		private Line line5;
		private Line line6;
		private Line line7;
		private Line line8;
		private Line line9;
		private Line line10;
		private Line line11;
		private Line line12;
		private Line line13;
		private Line line14;
		private Line line15;
		private Line line20;
		private Line line21;
		private Line line22;
		private Line line23;
		private Line line120;
		private Line line121;
		private Line line122;
		private Line line123;
		private Line line124;
		private Line line125;
		private Line line126;
		private Line line127;
		private Line line128;
		private Line line130;
		private Line line131;
		private Line line133;
		private Line line134;
		private Line line135;
		private Line line136;
		private Line line137;
		private Line line139;
		private Line line143;
		private Line line146;
		private Line line147;
		private Line line148;
		private Line line149;
		private Line line150;
		private Label label201;
		private Line line151;
		private TextBox textBox63;
		private Line line152;
		private Line line153;
		private Line line154;
		private Line line155;
		private Line line156;
		private Line line157;
		private Line line158;
		private Line line159;
		private Line line160;
		private Label label202;
		private TextBox textBox64;
		private TextBox textBox65;
		private Label label203;
		private Label label204;
		private TextBox textBox66;
		private TextBox textBox67;
		private TextBox textBox68;
		private Line line161;
		private Label label205;
		private Label label206;
		private TextBox CorpNumber2_1;
		private TextBox CorpNumber2_2;
		private TextBox CorpNumber2_3;
		private TextBox CorpNumber2_4;
		private Line line162;
		private Line line163;
		private Line line164;
		private Line line165;
		private TextBox textBox73;
		private Line line166;
		private Line line167;
		private Label label207;
		private Label label208;
		private Label label209;
		private TextBox textBox74;
		private Line line168;
		private Line line169;
		private Line line170;
		private Line line171;
		private Line line172;
		private Label label210;
		private Label label211;
		private Label label212;
		private Label label213;
		private Label label214;
		private Line line173;
		private Line line174;
		private Line line175;
		private Line line176;
		private Line line177;
		private Line line178;
		private Label label215;
		private Label label216;
		private Label label217;
		private Label label218;
		private Line line179;
		private Line line180;
		private Line line181;
		private Line line182;
		private Line line183;
		private Label label219;
		private Line line184;
		private Line line185;
		private Line line186;
		private Line line187;
		private Line line188;
		private Line line189;
		private Line line190;
		private Line line191;
		private Line line192;
		private Line line193;
		private Line line194;
		private Line line195;
		private Line line196;
		private Line line197;
		private Line line198;
		private Label label220;
		private Label label221;
		private Label label222;
		private Label label223;
		private Label label224;
		private Label label225;
		private Label label226;
		private Label label227;
		private Label label228;
		private Label label229;
		private Label label230;
		private Label label231;
		private Label label232;
		private Label label233;
		private Line line199;
		private Line line200;
		private Line line201;
		private Line line202;
		private Line line203;
		private Label label234;
		private Label label235;
		private Label label236;
		private Label label237;
		private Line line205;
		private Line line206;
		private Line line207;
		private Line line208;
		private Line line209;
		private Label label238;
		private Label label239;
		private Label label240;
		private Line line211;
		private Line line212;
		private Line line213;
		private Line line214;
		private Label label241;
		private Label label242;
		private Label label243;
		private Line line216;
		private Label label244;
		private Label label245;
		private Line line217;
		private Line line218;
		private Label label246;
		private Line line219;
		private Line line220;
		private Label label247;
		private Label label248;
		private Line line225;
		private Label label249;
		private Label label250;
		private Line line226;
		private Line line227;
		private Line line228;
		private Line line229;
		private Label label251;
		private Label label252;
		private Label label253;
		private Label label254;
		private Label label255;
		private Label label256;
		private Line line230;
		private Line line231;
		private Line line232;
		private Line line233;
		private Line line234;
		private Line line235;
		private Label label257;
		private Label label258;
		private Label label259;
		private Line line236;
		private Line line237;
		private Line line238;
		private Label label260;
		private Label label261;
		private Label label262;
		private Label label263;
		private Label label264;
		private Label label265;
		private Label label266;
		private Label label267;
		private Label label268;
		private Label label269;
		private Label label270;
		private Label label271;
		private Label label272;
		private Label label273;
		private Label label274;
		private Line line239;
		private Line line240;
		private Label label275;
		private Label label276;
		private Label label277;
		private Label label278;
		private Label label279;
		private Label label280;
		private Label label281;
		private Label label282;
		private Label label283;
		private Label label284;
		private Label label285;
		private Label label286;
		private Label label287;
		private Label label288;
		private Label label289;
		private Label label290;
		private Label label291;
		private Label label292;
		private Label label293;
		private Label label294;
		private Label label295;
		private Label label296;
		private Label label297;
		private Label label298;
		private Label label299;
		private Line line241;
		private Line line242;
		private Line line243;
		private Line line244;
		private Line line245;
		private Line line246;
		private Label label300;
		private Label label301;
		private Label label302;
		private Label label303;
		private Label label304;
		private Line line247;
		private Line line248;
		private Line line249;
		private Line line250;
		private Label label305;
		private Line line251;
		private Line line252;
		private Label label306;
		private Line line253;
		private TextBox textBox75;
		private Label label307;
		private Label label308;
		private Label label309;
		private Label label310;
		private Line line254;
		private Line line255;
		private Label label311;
		private Line line256;
		private Line line257;
		private Line line258;
		private Line line27;
		private Label label37;
		private Label label38;
		private Label label312;
		private Label label313;
		private Label label314;
		private Line line28;
		private Line line29;
		private Line line265;
		private Line line266;
		private Line line267;
		private Line line268;
		private Line line269;
		private Line line270;
		private Line line271;
		private Line line272;
		private TextBox DpndRemaksText2;
		private TextBox CorpNumber;
		private Label label316;
		private TextBox HousingObtDedPsblAmtText;
		private Label label317;
		private TextBox textBox1;
		private TextBox HousingMovingDateYText;
		private TextBox HousingMovingDate2YText;
		private TextBox HousingMovingDateMText;
		private TextBox HousingMovingDate2MText;
		private TextBox HousingMovingDateDText;
		private TextBox HousingMovingDate2DText;
		private TextBox HousingMovingDateText;
		private TextBox HousingMovingDate2Text;
		private TextBox HousingMovingDateY2Text;
		private TextBox HousingMovingDate2Y2Text;
		private TextBox HousingMovingDate2M2Text;
		private TextBox HousingMovingDateM2Text;
		private TextBox HousingMovingDateD2Text;
		private TextBox HousingMovingDate2D2Text;
		private TextBox SpecDedTypeText;
		private TextBox SpecDedType2Text;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox EyLoanBalanceText;
		private TextBox EyLoanBalance2Text;
		private TextBox textBox9;
		private TextBox textBox62;
		private TextBox NationalPensPremText;
		private TextBox textBox69;
		private TextBox SposNonResTypeText;
		private TextBox DpndNonResType1_Text;
		private TextBox SposNameKana_Text;
		private TextBox SposName_Text;
		private TextBox DpndNameKana1_Text;
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
		private TextBox YngDpndNameKana3_Text;
		private TextBox YngDpndNonRexType3_Text;
		private TextBox YngDpndNameKana4_Text;
		private TextBox YngDpndName4_Text;
		private TextBox YngDpndNonRexType4_Text;
		private TextBox textBox70;
		private TextBox textBox71;
		private TextBox textBox72;
		private TextBox textBox76;
		private TextBox textBox77;
		private TextBox textBox78;
		private TextBox textBox79;
		private TextBox textBox80;
		private TextBox textBox81;
		private TextBox textBox82;
		private TextBox textBox83;
		private TextBox textBox84;
		private TextBox textBox85;
		private TextBox textBox86;
		private TextBox textBox87;
		private TextBox textBox88;
		private TextBox textBox89;
		private TextBox textBox90;
		private TextBox textBox91;
		private TextBox textBox92;
		private TextBox textBox93;
		private TextBox textBox94;
		private TextBox textBox95;
		private TextBox textBox96;
		private TextBox textBox97;
		private TextBox textBox98;
		private TextBox textBox99;
		private TextBox SposMyNumber2_1Text;
		private TextBox SposMyNumber2_2Text;
		private TextBox SposMyNumber2_3Text;
		private TextBox DpndMyNumber2_1_1Text;
		private TextBox DpndMyNumber2_1_2Text;
		private TextBox DpndMyNumber2_1_3Text;
		private TextBox DpndMyNumber2_2_1Text;
		private TextBox DpndMyNumber2_2_2Text;
		private TextBox DpndMyNumber2_2_3Text;
		private TextBox DpndMyNumber2_3_1Text;
		private TextBox DpndMyNumber2_3_2Text;
		private TextBox DpndMyNumber2_3_3Text;
		private TextBox DpndMyNumber2_4_1Text;
		private TextBox DpndMyNumber2_4_2Text;
		private TextBox DpndMyNumber2_4_3Text;
		private TextBox MyNumber2_1Text;
		private TextBox MyNumber2_2Text;
		private TextBox MyNumber2_3Text;
		private TextBox HousingObtDedCntText;
		private TextBox textBox100;
		private Line line117;
		private Label label195;
		private TextBox DpndName1_Text;
		private Line line119;
		private TextBox MyNumber1_3Text;
		private TextBox MyNumber1_2Text;
		private TextBox MyNumber1_1Text;
		private Line line278;
		private Line line279;
		private Label label318;
		private Label label319;
		private Label label320;
		private Label label321;
		private Label label322;
		private Line line259;
		private TextBox SposMyNumber1_2Text;
		private Line line261;
		private TextBox SposMyNumber1_3Text;
		private TextBox DpndMyNumber1_1_1Text;
		private Line line262;
		private TextBox DpndMyNumber1_1_2Text;
		private TextBox DpndMyNumber1_1_3Text;
		private Line line263;
		private TextBox DpndMyNumber1_2_1Text;
		private Line line264;
		private TextBox DpndMyNumber1_2_2Text;
		private Line line280;
		private TextBox DpndMyNumber1_2_3Text;
		private TextBox DpndMyNumber1_3_1Text;
		private Line line281;
		private TextBox DpndMyNumber1_3_2Text;
		private Line line282;
		private TextBox DpndMyNumber1_3_3Text;
		private TextBox DpndMyNumber1_4_1Text;
		private Line line283;
		private TextBox DpndMyNumber1_4_2Text;
		private Line line284;
		private TextBox DpndMyNumber1_4_3Text;
		private Line line260;
		private Label label323;
		private Label label324;
		private Line line285;
		private Line line286;
		private TextBox YngDpndName3_Text;
		private TextBox DpndRemarksText1;
		private TextBox YngDpndRemarksText1;
		private TextBox YngDpndMyNumber1_4_3Text;
		private Label label325;
		private TextBox YngDpndMyNumber1_1_1Text;
		private Line line86;
		private TextBox YngDpndMyNumber1_1_2Text;
		private Line line87;
		private TextBox YngDpndMyNumber1_1_3Text;
		private Label label326;
		private TextBox YngDpndMyNumber1_2_1Text;
		private Line line88;
		private TextBox YngDpndMyNumber1_2_2Text;
		private Line line89;
		private TextBox YngDpndMyNumber1_2_3Text;
		private Label label327;
		private TextBox YngDpndMyNumber1_3_1Text;
		private Line line287;
		private TextBox YngDpndMyNumber1_3_2Text;
		private Line line288;
		private TextBox YngDpndMyNumber1_3_3Text;
		private Label label328;
		private TextBox YngDpndMyNumber1_4_1Text;
		private Line line289;
		private TextBox YngDpndMyNumber1_4_2Text;
		private Line line290;
		private TextBox CorpNumber1_4;
		private TextBox CorpNumber1_3;
		private TextBox CorpNumber1_2;
		private TextBox CorpNumber1_1;
		private Label label329;
		private Line line30;
		private Label label330;
		private TextBox textBox137;
		private Line line291;
		private Line line292;
		private Line line293;
		private Label label315;
		private Line line294;
		private TextBox YngDpndRemarksText2;
		private Line line273;
		private Line line274;
		private Label label331;
		private TextBox YngDpndMyNumber2_1_1Text;
		private Label label332;
		private TextBox YngDpndMyNumber2_1_2Text;
		private TextBox YngDpndMyNumber2_1_3Text;
		private Line line69;
		private Line line75;
		private Label label333;
		private TextBox YngDpndMyNumber2_2_1Text;
		private TextBox YngDpndMyNumber2_2_2Text;
		private TextBox YngDpndMyNumber2_2_3Text;
		private Line line80;
		private Line line118;
		private Label label334;
		private TextBox YngDpndMyNumber2_3_1Text;
		private TextBox YngDpndMyNumber2_3_2Text;
		private TextBox YngDpndMyNumber2_3_3Text;
		private Line line204;
		private Line line210;
		private Label label335;
		private TextBox YngDpndMyNumber2_4_1Text;
		private TextBox YngDpndMyNumber2_4_2Text;
		private TextBox YngDpndMyNumber2_4_3Text;
		private Line line215;
		private Line line221;
		private Line line222;
		private Line line223;
		private Line line275;
		private Line line276;
		private Line line277;
		private Line line295;
		private Line line308;
		private Line line307;
		private Line line306;
		private Line line305;
		private Line line304;
		private Line line303;
		private Line line302;
		private Line line301;
		private Line line300;
		private Line line299;
		private Line line298;
		private Line line297;
		private Line line296;
		private Line line224;
		private Line Line313;
		private Label label336;
		private Line line309;
		private Line line310;
		private Label label337;
		private Label label338;
		private Label label339;
		private Label label10;
		private Line line314;
		private Line line315;
		private Line line316;
		private Line line317;
		private Line line318;
		private Line line319;
		private Line line320;
		private Line line321;
		private Line line326;
		private Line line331;
		private Line line332;
		private Line line333;
		private Line line334;
		private Line line335;
		private Line line336;
		private Line line337;
		private Line line338;
		private Line line339;
		private Line line340;
		private Line line341;
		private Line line342;
		private Line line343;
		private Label label11;
		private Label label340;
		private Label label341;
		private Label label342;
		private Label label344;
		private Label label348;
		private Label label350;
		private Label label351;
		private Label label352;
		private Label label353;
		private TextBox SposMyNumber_Text;
		private TextBox DpndMyNumber1_Text;
		private TextBox DpndMyNumber2_Text;
		private TextBox DpndMyNumber3_Text;
		private TextBox DpndMyNumber4_Text;
		private TextBox MyNumber_Text;
		private TextBox YlyEdCalYear2Text;
		private TextBox YlyEdCalYear1Text;
		private TextBox YlyEdCalYearText;
		private TextBox YngDpndMyNumber1_Text;
		private TextBox YngDpndMyNumber4_Text;
		private TextBox YngDpndMyNumber3_Text;
		private TextBox YngDpndMyNumber2_Text;
		private Label label198;
		private Label label199;
		private Label label200;
		private Label label343;
		private Label label345;
		private Label adjDedLabel1;
		private Line line24;
		private Label baseDedAmtLabel1;
		private Label baseDedAmtYen1;
		private Label incmAdjDedAmt1Label1;
		private Label incmAdjDedAmtYen1;
		private TextBox incmAdjDedAmtText1;
		private Label incmAdjDedAmt2Label1;
		private Line pesnlDed11_Line1;
		private TextBox birthNameOfEraText;
		private Line line25;
		private Label baseDedAmtLabel2;
		private Label baseDedAmtYen2;
		private Label incmAdjDedAmt1Label2;
		private Label incmAdjDedAmt2Label2;
		private TextBox incmAdjDedAmtText2;
		private Label incmAdjDedAmtYen2;
		private Line pesnlDed11_Line2;
		private Line line138;
		private Line line140;
		private Line line141;
		private Line line142;
		private Label adjDedLabel2;
		private TextBox SposMyNumber1_1Text;
		protected CommonData cd;


		#endregion
		#region Properties
		public string ReportID
		{
			get {return reportID;}
			set {reportID = value;}
		}

		public string CompanyName
		{
			get {return companyName;}
			set {companyName = value;}
		}

		public CommonData commonData
		{
			get {return cd;}
			set {cd = value;}
		}

		#endregion

		private void HR_PY_03_R62_ReportStart(object sender, System.EventArgs eArgs)
		{
			//仮想プリンタの設定
			this.Document.Printer.PrinterName="";
			// 用紙サイズ:A4
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			// 用紙方向:横
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;

		}

		private void PageHeader_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_Format(object sender, System.EventArgs eArgs)
		{
		}



		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			HousingMovingDateYText.Text = "";
			HousingMovingDateMText.Text = "";
			HousingMovingDateDText.Text = "";
			HousingMovingDateY2Text.Text = "";
			HousingMovingDateM2Text.Text = "";
			HousingMovingDateD2Text.Text = "";

			HousingMovingDate2YText.Text = "";
			HousingMovingDate2MText.Text = "";
			HousingMovingDate2DText.Text = "";
			HousingMovingDate2Y2Text.Text = "";
			HousingMovingDate2M2Text.Text = "";
			HousingMovingDate2D2Text.Text = "";

			MyNumber1_1Text.Text = "";
			MyNumber1_2Text.Text = "";
			MyNumber1_3Text.Text = "";
			MyNumber2_1Text.Text = "";
			MyNumber2_2Text.Text = "";
			MyNumber2_3Text.Text = "";

			SposMyNumber1_1Text.Text = "";
			SposMyNumber1_2Text.Text = "";
			SposMyNumber1_3Text.Text = "";
			SposMyNumber2_1Text.Text = "";
			SposMyNumber2_2Text.Text = "";
			SposMyNumber2_3Text.Text = "";

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
			DpndMyNumber2_1_1Text.Text = "";
			DpndMyNumber2_1_2Text.Text = "";
			DpndMyNumber2_1_3Text.Text = "";
			DpndMyNumber2_2_1Text.Text = "";
			DpndMyNumber2_2_2Text.Text = "";
			DpndMyNumber2_2_3Text.Text = "";
			DpndMyNumber2_3_1Text.Text = "";
			DpndMyNumber2_3_2Text.Text = "";
			DpndMyNumber2_3_3Text.Text = "";
			DpndMyNumber2_4_1Text.Text = "";
			DpndMyNumber2_4_2Text.Text = "";
			DpndMyNumber2_4_3Text.Text = "";

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
			YngDpndMyNumber2_1_1Text.Text = "";
			YngDpndMyNumber2_1_2Text.Text = "";
			YngDpndMyNumber2_1_3Text.Text = "";
			YngDpndMyNumber2_2_1Text.Text = "";
			YngDpndMyNumber2_2_2Text.Text = "";
			YngDpndMyNumber2_2_3Text.Text = "";
			YngDpndMyNumber2_3_1Text.Text = "";
			YngDpndMyNumber2_3_2Text.Text = "";
			YngDpndMyNumber2_3_3Text.Text = "";
			YngDpndMyNumber2_4_1Text.Text = "";
			YngDpndMyNumber2_4_2Text.Text = "";
			YngDpndMyNumber2_4_3Text.Text = "";

			CorpNumber1_1.Text = "";
			CorpNumber1_2.Text = "";
			CorpNumber1_3.Text = "";
			CorpNumber1_4.Text = "";
			CorpNumber2_1.Text = "";
			CorpNumber2_2.Text = "";
			CorpNumber2_3.Text = "";
			CorpNumber2_4.Text = "";

			JapaneseCalendar ca = new JapaneseCalendar();
			string YlyEdCalYear = YlyEdCalYearText.Text + "/12" + "/31";

			if (YlyEdCalYearText.Text.Length != 0)
			{
				DateTime dt = DateTime.Parse(YlyEdCalYear);
				YlyEdCalYear1Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);
				YlyEdCalYear2Text.Text = string.Format("{0}", ca.GetYear(dt) + 1);
			}

			// 居住開始年月日1
			if (HousingMovingDateText.Text.Length != 0)
			{
				DateTime hmDt = DateTime.Parse(HousingMovingDateText.Text);
				HousingMovingDateYText.Text = ca.GetYear(hmDt).ToString();
				HousingMovingDateMText.Text = ca.GetMonth(hmDt).ToString();
				HousingMovingDateDText.Text = ca.GetDayOfMonth(hmDt).ToString();
				HousingMovingDateY2Text.Text = ca.GetYear(hmDt).ToString();
				HousingMovingDateM2Text.Text = ca.GetMonth(hmDt).ToString();
				HousingMovingDateD2Text.Text = ca.GetDayOfMonth(hmDt).ToString();
			}

			// 居住開始年月日2
			if (HousingMovingDate2Text.Text.Length != 0)
			{
				DateTime hm2Dt = DateTime.Parse(HousingMovingDate2Text.Text);
				HousingMovingDate2YText.Text = ca.GetYear(hm2Dt).ToString();
				HousingMovingDate2MText.Text = ca.GetMonth(hm2Dt).ToString();
				HousingMovingDate2DText.Text = ca.GetDayOfMonth(hm2Dt).ToString();
				HousingMovingDate2Y2Text.Text = ca.GetYear(hm2Dt).ToString();
				HousingMovingDate2M2Text.Text = ca.GetMonth(hm2Dt).ToString();
				HousingMovingDate2D2Text.Text = ca.GetDayOfMonth(hm2Dt).ToString();
			}

			// 個人番号
			if ((MyNumber_Text.Text != null) && (MyNumber_Text.Text.Length == 12))
			{
				MyNumber1_1Text.Text = MyNumber_Text.Text.Substring(0, 4);
				MyNumber1_2Text.Text = MyNumber_Text.Text.Substring(4, 4);
				MyNumber1_3Text.Text = MyNumber_Text.Text.Substring(8, 4);
				MyNumber2_1Text.Text = MyNumber_Text.Text.Substring(0, 4);
				MyNumber2_2Text.Text = MyNumber_Text.Text.Substring(4, 4);
				MyNumber2_3Text.Text = MyNumber_Text.Text.Substring(8, 4);
			}

			// 配偶者個人番号
			if((SposMyNumber_Text.Text != null) && (SposMyNumber_Text.Text.Length == 12))
			{
				SposMyNumber1_1Text.Text = SposMyNumber_Text.Text.Substring(0, 4);
				SposMyNumber1_2Text.Text = SposMyNumber_Text.Text.Substring(4, 4);
				SposMyNumber1_3Text.Text = SposMyNumber_Text.Text.Substring(8, 4);
				SposMyNumber2_1Text.Text = SposMyNumber_Text.Text.Substring(0, 4);
				SposMyNumber2_2Text.Text = SposMyNumber_Text.Text.Substring(4, 4);
				SposMyNumber2_3Text.Text = SposMyNumber_Text.Text.Substring(8, 4);
			}

			// 扶養親族1
			if((DpndMyNumber1_Text.Text != null) && (DpndMyNumber1_Text.Text.Length == 12))
			{
				DpndMyNumber1_1_1Text.Text = DpndMyNumber1_Text.Text.Substring(0, 4);
				DpndMyNumber1_1_2Text.Text = DpndMyNumber1_Text.Text.Substring(4, 4);
				DpndMyNumber1_1_3Text.Text = DpndMyNumber1_Text.Text.Substring(8, 4);
				DpndMyNumber2_1_1Text.Text = DpndMyNumber1_Text.Text.Substring(0, 4);
				DpndMyNumber2_1_2Text.Text = DpndMyNumber1_Text.Text.Substring(4, 4);
				DpndMyNumber2_1_3Text.Text = DpndMyNumber1_Text.Text.Substring(8, 4);
			}
			// 扶養親族2
			if((DpndMyNumber2_Text.Text != null) && (DpndMyNumber2_Text.Text.Length == 12))
			{
				DpndMyNumber1_2_1Text.Text = DpndMyNumber2_Text.Text.Substring(0, 4);
				DpndMyNumber1_2_2Text.Text = DpndMyNumber2_Text.Text.Substring(4, 4);
				DpndMyNumber1_2_3Text.Text = DpndMyNumber2_Text.Text.Substring(8, 4);
				DpndMyNumber2_2_1Text.Text = DpndMyNumber2_Text.Text.Substring(0, 4);
				DpndMyNumber2_2_2Text.Text = DpndMyNumber2_Text.Text.Substring(4, 4);
				DpndMyNumber2_2_3Text.Text = DpndMyNumber2_Text.Text.Substring(8, 4);
			}
			// 扶養親族3
			if((DpndMyNumber3_Text.Text != null) && (DpndMyNumber3_Text.Text.Length == 12))
			{
				DpndMyNumber1_3_1Text.Text = DpndMyNumber3_Text.Text.Substring(0, 4);
				DpndMyNumber1_3_2Text.Text = DpndMyNumber3_Text.Text.Substring(4, 4);
				DpndMyNumber1_3_3Text.Text = DpndMyNumber3_Text.Text.Substring(8, 4);
				DpndMyNumber2_3_1Text.Text = DpndMyNumber3_Text.Text.Substring(0, 4);
				DpndMyNumber2_3_2Text.Text = DpndMyNumber3_Text.Text.Substring(4, 4);
				DpndMyNumber2_3_3Text.Text = DpndMyNumber3_Text.Text.Substring(8, 4);
			}
			// 扶養親族4
			if ((DpndMyNumber4_Text.Text != null) && (DpndMyNumber4_Text.Text.Length == 12))
			{
				DpndMyNumber1_4_1Text.Text = DpndMyNumber4_Text.Text.Substring(0, 4);
				DpndMyNumber1_4_2Text.Text = DpndMyNumber4_Text.Text.Substring(4, 4);
				DpndMyNumber1_4_3Text.Text = DpndMyNumber4_Text.Text.Substring(8, 4);
				DpndMyNumber2_4_1Text.Text = DpndMyNumber4_Text.Text.Substring(0, 4);
				DpndMyNumber2_4_2Text.Text = DpndMyNumber4_Text.Text.Substring(4, 4);
				DpndMyNumber2_4_3Text.Text = DpndMyNumber4_Text.Text.Substring(8, 4);
			}

			// 16歳未満親族1
			if ((YngDpndMyNumber1_Text.Text != null) && (YngDpndMyNumber1_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_1_1Text.Text = YngDpndMyNumber1_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_1_2Text.Text = YngDpndMyNumber1_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_1_3Text.Text = YngDpndMyNumber1_Text.Text.Substring(8, 4);
				YngDpndMyNumber2_1_1Text.Text = YngDpndMyNumber1_Text.Text.Substring(0, 4);
				YngDpndMyNumber2_1_2Text.Text = YngDpndMyNumber1_Text.Text.Substring(4, 4);
				YngDpndMyNumber2_1_3Text.Text = YngDpndMyNumber1_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族2
			if ((YngDpndMyNumber2_Text.Text != null) && (YngDpndMyNumber2_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_2_1Text.Text = YngDpndMyNumber2_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_2_2Text.Text = YngDpndMyNumber2_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_2_3Text.Text = YngDpndMyNumber2_Text.Text.Substring(8, 4);
				YngDpndMyNumber2_2_1Text.Text = YngDpndMyNumber2_Text.Text.Substring(0, 4);
				YngDpndMyNumber2_2_2Text.Text = YngDpndMyNumber2_Text.Text.Substring(4, 4);
				YngDpndMyNumber2_2_3Text.Text = YngDpndMyNumber2_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族3
			if ((YngDpndMyNumber3_Text.Text != null) && (YngDpndMyNumber3_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_3_1Text.Text = YngDpndMyNumber3_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_3_2Text.Text = YngDpndMyNumber3_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_3_3Text.Text = YngDpndMyNumber3_Text.Text.Substring(8, 4);
				YngDpndMyNumber2_3_1Text.Text = YngDpndMyNumber3_Text.Text.Substring(0, 4);
				YngDpndMyNumber2_3_2Text.Text = YngDpndMyNumber3_Text.Text.Substring(4, 4);
				YngDpndMyNumber2_3_3Text.Text = YngDpndMyNumber3_Text.Text.Substring(8, 4);
			}
			// 16歳未満親族4
			if ((YngDpndMyNumber4_Text.Text != null) && (YngDpndMyNumber4_Text.Text.Length == 12))
			{
				YngDpndMyNumber1_4_1Text.Text = YngDpndMyNumber4_Text.Text.Substring(0, 4);
				YngDpndMyNumber1_4_2Text.Text = YngDpndMyNumber4_Text.Text.Substring(4, 4);
				YngDpndMyNumber1_4_3Text.Text = YngDpndMyNumber4_Text.Text.Substring(8, 4);
				YngDpndMyNumber2_4_1Text.Text = YngDpndMyNumber4_Text.Text.Substring(0, 4);
				YngDpndMyNumber2_4_2Text.Text = YngDpndMyNumber4_Text.Text.Substring(4, 4);
				YngDpndMyNumber2_4_3Text.Text = YngDpndMyNumber4_Text.Text.Substring(8, 4);
			}

			// 法人番号
			if ((CorpNumber.Text != null) && (CorpNumber.Text.Length == 13))
			{
				CorpNumber1_1.Text = CorpNumber.Text.Substring(0, 1);
				CorpNumber1_2.Text = CorpNumber.Text.Substring(1, 4);
				CorpNumber1_3.Text = CorpNumber.Text.Substring(5, 4);
				CorpNumber1_4.Text = CorpNumber.Text.Substring(9, 4);
				CorpNumber2_1.Text = CorpNumber.Text.Substring(0, 1);
				CorpNumber2_2.Text = CorpNumber.Text.Substring(1, 4);
				CorpNumber2_3.Text = CorpNumber.Text.Substring(5, 4);
				CorpNumber2_4.Text = CorpNumber.Text.Substring(9, 4);
			}

// 管理番号K26715 From
			// 年度によるラベルの切替
			if (int.Parse(YlyEdCalYearText.Text) < 2018)
			{
				// 控除対象配偶者の有無等
				Label1010.Text	= "控除対象配偶者";
				label35.Text	= "控除対象配偶者";

				// 配偶者特別控除の額
				Label1016.Text	= "配 偶 者 特 別";
				label123.Text	= "配 偶 者 特 別";

				// 控除対象配偶者
				label343.Visible = false;
				label345.Visible = false;
				label75.Top		= 4.17F;
				label244.Top	= 4.17F;
			}
			else
			{
				// (源泉)控除対象配偶者の有無等
				Label1010.Text	= "(源泉)控除対象配偶者";
				label35.Text	= "(源泉)控除対象配偶者";

				// 配偶者(特別)控除の額
				Label1016.Text	= "配 偶 者 (特 別)";
				label123.Text	= "配 偶 者 (特 別)";

				// (源泉・特別)控除対象配偶者
				label343.Visible = true;
				label345.Visible = true;
				label75.Top		= 4.237F;
				label244.Top	= 4.237F;
			}
// 管理番号K26715 To
// 管理番号K27274 From
			// 年度による切替
			if (int.Parse(YlyEdCalYearText.Text) < 2020)
			{
				// 給与所得控除後の金額(調整控除後)
				// 表示位置の調整・(調整控除後)を非表示
				Label1001.Top = 1.05F;
				label23.Top = 1.05F;

				adjDedLabel1.Visible = false;
				adjDedLabel2.Visible = false;

				// 基礎控除の額
				// 項目名・円を非表示
				baseDedAmtLabel1.Visible = false;
				baseDedAmtYen1.Visible = false;

				baseDedAmtLabel2.Visible = false;
				baseDedAmtYen2.Visible = false;

				// 所得金額調整控除額
				// 項目名・データ・円を非表示
				incmAdjDedAmt1Label1.Visible = false;
				incmAdjDedAmt2Label1.Visible = false;
				incmAdjDedAmtText1.Visible = false;
				incmAdjDedAmtYen1.Visible = false;

				incmAdjDedAmt1Label2.Visible = false;
				incmAdjDedAmt2Label2.Visible = false;
				incmAdjDedAmtText2.Visible = false;
				incmAdjDedAmtYen2.Visible = false;

				// 本人控除等申告
				// 8列目：一般寡婦
				Label1063.Text = "一般寡婦";
				label6.Text = "一般寡婦";

				// 9列目：特別寡婦
				Label1065.Text = "特別寡婦";
				label150.Text = "特別寡婦";

				// 10列目：寡夫
				Label1067.Text = "寡夫";
				label151.Text = "寡夫";

				// 11列目：勤労学生
				Label1105.Visible = true;
				Label1105.Text = "勤労学生";
				wrkStdTypeText.Visible = true;
				pesnlDed11_Line1.Visible = false;	//斜線
				label8.Visible = true;
				label8.Text = "勤労学生";
				textBox41.Visible = true;
				pesnlDed11_Line2.Visible = false;	//斜線
			}
			else
			{
				// 給与所得控除後の金額(調整控除後)
				// 表示位置の調整・(調整控除後)を表示
				Label1001.Top = 1.015748F;
				label23.Top = 1.015748F;

				adjDedLabel1.Visible = true;
				adjDedLabel2.Visible = true;

				// 基礎控除の額
				// 項目名・データ・円を表示
				baseDedAmtLabel1.Visible = true;
				baseDedAmtYen1.Visible = true;

				baseDedAmtLabel2.Visible = true;
				baseDedAmtYen2.Visible = true;

				// 所得金額調整控除額
				// 項目名・データ・円を表示
				incmAdjDedAmt1Label1.Visible = true;
				incmAdjDedAmt2Label1.Visible = true;
				incmAdjDedAmtText1.Visible = true;
				incmAdjDedAmtYen1.Visible = true;

				incmAdjDedAmt1Label2.Visible = true;
				incmAdjDedAmt2Label2.Visible = true;
				incmAdjDedAmtText2.Visible = true;
				incmAdjDedAmtYen2.Visible = true;

				// 本人控除等申告
				// 8列目：寡婦
				Label1063.Text = "寡婦";
				label6.Text = "寡婦";

				// 9列目：ひとり親
				Label1065.Text = "ひとり親";
				label150.Text = "ひとり親";

				// 10列目：勤労学生
				Label1067.Text = "勤労学生";
				label151.Text = "勤労学生";

				// 11列目：斜線
				Label1105.Visible = false;
				wrkStdTypeText.Visible = false;
				pesnlDed11_Line1.Visible = true;	//斜線
				label8.Visible = false;
				textBox41.Visible = false;
				pesnlDed11_Line2.Visible = true;	//斜線
			}
// 管理番号K27274 To

		}

		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
		}

		private void GroupFooter2_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_BeforePrint(object sender, System.EventArgs eArgs)
		{
		}

		private void PageFooter_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void Detail_AfterPrint(object sender, System.EventArgs eArgs)
		{
		}

		private void GroupFooter2_BeforePrint(object sender, System.EventArgs eArgs)
		{
		}

		#region ActiveReports Designer generated code
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label993 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label994 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyEdAddress1_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empCodeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox postNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameKanaText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label996 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label997 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label998 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label999 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1000 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1001 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1002 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox classText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1003 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1004 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox slryInsmDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1005 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox incmDedAmtSumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1006 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1007 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox ylyCollectTaxText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1008 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1009 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1010 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1011 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1012 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1014 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposOldAgeTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExistText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox dedSposExist2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1016 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sposExtDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1018 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1019 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1020 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1021 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1022 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1023 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum1_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox specDpndNum2_1Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1024 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1025 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtAgePreNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1026 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox agePreNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1027 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1028 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1029 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox othersDpndNum2Text = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1030 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1031 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox liveTgtExtHandiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHndiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1032 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1033 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1034 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1035 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1036 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox HandiNumText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1037 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox smlScaleCompCpratAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1039 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox lifeInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox454 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox sponSumIncmAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox LifeInsPensAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsLongProdAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1051 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1052 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1053 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1054 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1055 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1063 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1065 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1067 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1069 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1070 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1071 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1072 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1073 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1074 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1075 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox empNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1076 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox minrTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox latterText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extHandiTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox handiTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widowTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox extWidowTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox widomTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox wrkStdTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1077 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntAddressText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntNameText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1080 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox paymntPhoneText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1081 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1082 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1084 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1085 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1086 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1087 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1088 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1089 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1093 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox nolfInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1105 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox deathRetireTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox disasterTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1113 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox foreignTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1116 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmployTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1117 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfRetireTypeText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateYearText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReFateMonthText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox halfEmReDateDayText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1121 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1122 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayYearText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayMonthText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox birthDayDayText = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox socInsDedAmtText = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1123 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line323 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line324 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line325 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line327 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line328 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line329 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line330 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line129 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line395 = null;
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
		private GrapeCity.ActiveReports.SectionReportModel.Line Line408 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line413 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line415 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line417 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line418 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line419 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line420 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line421 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line422 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line427 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line431 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line433 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line434 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line436 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line438 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line439 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line440 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line441 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line442 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line443 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line444 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line445 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line446 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line447 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line450 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line451 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line452 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line455 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line615 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1595 = null;
		private GrapeCity.ActiveReports.SectionReportModel.Line Line752 = null;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox summary0Digit0Text = null;

		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_PY_03_R63));
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.label343 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label345 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line315 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line222 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line275 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label336 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line223 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label993 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line308 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line307 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line306 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line305 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line304 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line303 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line302 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line301 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line300 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line299 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line298 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line297 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line296 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line224 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line295 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line277 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line276 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line313 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line324 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label309 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label310 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label308 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label79 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line170 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label38 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label242 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label239 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label235 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label233 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndRemarksText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndRemaksText2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndRemarksText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label323 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox73 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label330 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label206 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.CorpNumber1_4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber1_1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label329 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label205 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.CorpNumber2_1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label73 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label70 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label66 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label64 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label193 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label194 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label192 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label78 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label99 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1063 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label14 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1055 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label994 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empCodeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.postNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.empNameKanaText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label996 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label997 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label998 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label999 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1000 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1001 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1002 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.classText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1003 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1004 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.slryInsmDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1005 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmDedAmtSumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1006 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1007 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyCollectTaxText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1008 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1009 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1010 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1011 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1012 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1014 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposOldAgeTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExistText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.dedSposExist2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1016 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.sposExtDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1018 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1019 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1020 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1021 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1022 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1023 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.specDpndNum1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.specDpndNum2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1024 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1025 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtAgePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1026 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.agePreNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.agePreNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1027 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1028 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1029 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.othersDpndNum2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1030 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1031 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.liveTgtExtHandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHndiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1032 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1033 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1034 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1035 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1036 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HandiNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1037 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.smlScaleCompCpratAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1039 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lifeInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox454 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.sponSumIncmAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.LifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.nolfInsLongProdAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1051 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1052 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1053 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1054 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1065 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1067 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1069 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1070 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1071 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1072 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1073 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1074 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1075 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.empNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1076 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.minrTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.latterText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extHandiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.handiTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.extWidowTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.widomTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.wrkStdTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1077 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1078 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1079 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntAddressText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.paymntNameText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1080 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.paymntPhoneText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1081 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1082 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1084 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1085 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1086 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1087 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1088 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1089 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1093 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.nolfInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.deathRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.disasterTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.foreignTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1116 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfEmployTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1117 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.halfRetireTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReFateMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.halfEmReDateDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1121 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1122 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.birthDayYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayMonthText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.birthDayDayText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.socInsDedAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line323 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line325 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line327 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line328 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line129 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line395 = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.Line408 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line413 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line415 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line417 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line418 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line419 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line420 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line421 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line422 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line427 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line431 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line434 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line436 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line440 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line441 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line442 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line443 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line444 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line445 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line446 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line447 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line450 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line451 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line452 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line455 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line615 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Label1595 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Line752 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.summary0Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line433 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line438 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line439 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line329 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Line330 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsPensAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.newLifeInsCareAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label20 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label24 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.newLifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lifeInsGeneralAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.summary1Digit0Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line26 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line31 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line32 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YoungDpndNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line33 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line34 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line35 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line36 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line37 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label41 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label42 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label43 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line38 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line39 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line40 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line41 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line42 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line43 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label46 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label49 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line44 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line45 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line46 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line47 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line48 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label50 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line49 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line50 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line51 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line52 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line53 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line54 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line55 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line56 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line57 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line58 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line59 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line60 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line61 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line62 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line63 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label51 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label52 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label53 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label54 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label55 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label56 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label57 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label58 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label59 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label60 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label61 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label62 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label63 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line64 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line65 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line66 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line67 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line68 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label65 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label67 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label68 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line70 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line71 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line72 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line73 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line74 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label69 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label71 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line76 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line77 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line78 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line79 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label72 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label74 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line81 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label75 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label76 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line82 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line83 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label77 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line84 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line85 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line90 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label80 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label81 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line91 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line92 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line93 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line94 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label82 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label83 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label84 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label85 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label86 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label87 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line95 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line96 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line97 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line98 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line99 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line100 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label88 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label89 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label90 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line101 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line102 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line103 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label91 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label92 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label93 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label94 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label95 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label96 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label97 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label98 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label100 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label101 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label102 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label103 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label104 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label105 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line16 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line18 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label26 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label27 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label106 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label107 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label108 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label109 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label110 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label111 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label112 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label113 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label114 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label115 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label116 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label117 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label118 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label13 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label18 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label119 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label120 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label121 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label122 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label171 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label176 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label183 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line17 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line19 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line104 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line105 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line106 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line107 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label184 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label185 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label186 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label187 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label188 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line108 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line109 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line110 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line111 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label189 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line112 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line113 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label190 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line114 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.NonResidentNumText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label191 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line115 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line116 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label12 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label15 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ylyEdAddress1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label16 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label17 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label19 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label21 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label22 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label23 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label25 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label28 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label29 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox10 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label30 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox11 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label31 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label32 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox12 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label33 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label34 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label39 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label40 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox13 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox14 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox15 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label123 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox16 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label124 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label125 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label126 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label127 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label128 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label129 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox17 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox18 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label130 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label131 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox19 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label132 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox20 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox21 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label133 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label134 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox22 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label135 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox23 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label136 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label137 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox24 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox25 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label138 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label139 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label140 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label141 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label142 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox26 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label143 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox27 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label144 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox28 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox29 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox30 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox31 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox32 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label145 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label146 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label147 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label148 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label150 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label151 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label153 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label154 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label155 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label156 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label157 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label158 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label159 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox33 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label160 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox34 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox35 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox36 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox37 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox38 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox39 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox40 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox41 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label161 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label162 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label163 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox42 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox43 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label164 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox44 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label165 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label166 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label167 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label168 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label169 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label170 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label172 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label173 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label174 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox45 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox46 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox47 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label175 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox48 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label177 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox49 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label178 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox50 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox51 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox52 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox53 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label182 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label196 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox54 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox58 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox59 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox60 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox61 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label197 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line9 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line10 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line11 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line12 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line13 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line14 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line15 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line20 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line21 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line22 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line23 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line120 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line121 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line122 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line123 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line124 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line125 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line126 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line127 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line128 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line130 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line131 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line133 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line134 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line135 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line136 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line137 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line138 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line139 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line140 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line141 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line142 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line143 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line146 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line147 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line148 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line149 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line150 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label201 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line151 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.textBox63 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line152 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line153 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line154 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line155 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line156 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line157 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line158 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line159 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line160 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label202 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox64 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox65 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label203 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label204 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox66 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox67 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox68 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line161 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.CorpNumber2_2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber2_3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.CorpNumber2_4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line162 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line163 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line164 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line165 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line166 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line167 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label207 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label208 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label209 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox74 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line168 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line169 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line171 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line172 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label210 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label211 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label212 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label213 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label214 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line173 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line174 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line175 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line176 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line177 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line178 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label215 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label216 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label217 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label218 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line179 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line180 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line181 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line182 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line183 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label219 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line184 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line185 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line186 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line187 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line188 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line189 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line190 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line191 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line192 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line193 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line194 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line195 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line196 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line197 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line198 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label220 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label221 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label222 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label223 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label224 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label225 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label226 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label227 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label228 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label229 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label230 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label231 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label232 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line199 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line200 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line201 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line202 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line203 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label234 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label236 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label237 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line205 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line206 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line207 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line208 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line209 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label238 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label240 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line211 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line212 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line213 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line214 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label241 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label243 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line216 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label244 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label245 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line217 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line218 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label246 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line219 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line220 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label247 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label248 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line225 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label249 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label250 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line226 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line227 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line228 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line229 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label251 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label252 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label253 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label254 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label255 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label256 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line230 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line231 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line232 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line233 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line234 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line235 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label257 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label258 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label259 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line236 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line237 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line238 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label260 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label261 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label262 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label263 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label264 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label265 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label266 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label267 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label268 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label269 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label270 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label271 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label272 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label273 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label274 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line239 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line240 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label275 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label276 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label277 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label278 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label279 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label280 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label281 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label282 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label283 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label284 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label285 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label286 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label287 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label288 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label289 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label290 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label291 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label292 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label293 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label294 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label295 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label296 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label297 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label298 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label299 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line241 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line242 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line243 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line244 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line245 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line246 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label300 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label301 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label302 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label303 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label304 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line247 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line248 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line249 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line250 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label305 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line251 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line252 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label306 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line253 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.textBox75 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label307 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line254 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line255 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label311 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line256 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line257 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line258 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line27 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label37 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label312 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label313 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label314 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line28 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line29 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line265 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line266 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line267 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line268 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line269 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line270 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line271 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line272 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.CorpNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label316 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.HousingObtDedPsblAmtText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label317 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateYText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2YText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateMText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2MText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateDText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2DText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateY2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2Y2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2M2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateM2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDateD2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingMovingDate2D2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SpecDedTypeText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SpecDedType2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EyLoanBalanceText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.EyLoanBalance2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox9 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox62 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.NationalPensPremText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox69 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
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
			this.textBox70 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox71 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox72 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox76 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox77 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox78 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox79 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox80 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox81 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox82 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox83 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox84 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox85 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox86 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox87 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox88 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox89 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox90 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox91 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox92 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox93 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox94 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox95 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox96 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox97 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox98 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox99 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SposMyNumber2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.HousingObtDedCntText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox100 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line117 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label195 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line119 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.MyNumber1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line278 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line279 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label318 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label319 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label320 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label321 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label322 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SposMyNumber1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line259 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SposMyNumber1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line261 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.SposMyNumber1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line262 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line263 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line264 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line280 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line281 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line282 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line283 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line284 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.DpndMyNumber1_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line260 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label324 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line285 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line286 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label325 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber1_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line86 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line87 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label326 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber1_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line88 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line89 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label327 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber1_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line287 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line288 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label328 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber1_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line289 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndMyNumber1_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line290 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line30 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.textBox137 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line291 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line292 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line293 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label315 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line294 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.YngDpndRemarksText2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line273 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line274 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label331 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber2_1_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label332 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber2_1_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_1_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line69 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line75 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label333 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber2_2_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_2_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_2_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line80 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line118 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label334 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber2_3_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_3_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_3_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line204 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line210 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label335 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.YngDpndMyNumber2_4_1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_4_2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_4_3Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line215 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line221 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line309 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line310 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label337 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label338 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label339 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line314 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line316 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line317 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line318 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line319 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line320 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line321 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line326 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line331 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line332 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line333 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line334 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line335 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line336 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line337 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line338 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line339 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line340 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line341 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line342 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line343 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.label11 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label340 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label341 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label342 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label344 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label348 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label350 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label351 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label352 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label353 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.SposMyNumber_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.DpndMyNumber4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.MyNumber_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YlyEdCalYear2Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YlyEdCalYear1Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YlyEdCalYearText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber1_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber4_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber3_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.YngDpndMyNumber2_Text = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label198 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label199 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label200 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.adjDedLabel1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line24 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.baseDedAmtLabel1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.baseDedAmtYen1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmt1Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmtYen1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmtText1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.incmAdjDedAmt2Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.pesnlDed11_Line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.birthNameOfEraText = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line25 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.baseDedAmtLabel2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.baseDedAmtYen2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmt1Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmt2Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.incmAdjDedAmtText2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.incmAdjDedAmtYen2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.pesnlDed11_Line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.adjDedLabel2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			((System.ComponentModel.ISupportInitialize)(this.label343)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label345)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label336)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label993)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label309)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label310)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label308)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label242)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label239)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label235)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label233)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemaksText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemarksText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label323)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label330)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label206)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label329)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label205)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label73)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label193)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label194)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label192)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label99)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1063)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1055)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label994)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label996)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label997)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label998)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label999)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1000)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1001)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1002)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1003)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1004)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1005)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1006)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1007)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1008)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1009)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1010)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1011)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1012)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1014)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1016)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1018)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1019)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1020)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1021)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1022)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1023)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1024)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1025)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1026)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1027)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1028)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1029)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1030)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1031)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1032)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1033)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1034)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1035)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1036)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1037)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1039)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1051)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1052)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1053)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1054)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1065)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1067)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1069)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1070)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1071)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1072)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1073)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1074)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1075)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1076)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1077)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1078)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1079)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1080)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1081)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1082)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1084)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1085)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1086)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1087)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1088)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1089)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1093)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1116)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1117)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1121)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1595)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label55)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label56)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label57)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label69)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label82)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label83)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label84)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label85)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label86)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label87)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label88)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label89)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label90)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label91)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label92)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label93)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label94)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label95)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label96)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label97)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label98)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label100)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label101)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label102)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label103)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label104)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label105)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label106)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label107)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label108)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label109)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label110)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label111)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label112)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label113)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label114)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label115)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label116)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label117)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label118)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label119)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label120)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label121)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label122)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label171)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label176)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label183)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label184)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label185)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label186)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label187)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label188)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label189)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label190)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NonResidentNumText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label191)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label123)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label124)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label125)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label126)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label127)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label128)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label129)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label130)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label132)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label133)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label134)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label135)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label136)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label138)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label139)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label140)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label141)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label142)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label143)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label144)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox30)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox32)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label145)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label146)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label147)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label148)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label150)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label151)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label153)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label154)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label155)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label156)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label157)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label158)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label159)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox33)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label160)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox34)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox35)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox36)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox38)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox39)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox40)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label161)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label162)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label163)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox42)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox43)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label164)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox44)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label165)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label166)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label167)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label168)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label169)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label170)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label172)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label173)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label174)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox45)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox46)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox47)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label175)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox48)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label177)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox49)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label178)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox50)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox52)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox53)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label182)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label196)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox54)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox58)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox59)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox60)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label197)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label201)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox63)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label202)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox64)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox65)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label203)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label204)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox66)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox67)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox68)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label207)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label208)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label209)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox74)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label210)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label211)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label212)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label213)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label214)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label215)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label216)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label217)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label218)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label219)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label220)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label221)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label222)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label223)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label224)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label225)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label226)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label227)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label228)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label229)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label230)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label231)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label232)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label234)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label236)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label237)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label238)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label240)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label241)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label243)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label244)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label245)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label246)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label247)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label248)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label249)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label250)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label251)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label252)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label253)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label254)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label255)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label256)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label257)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label258)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label259)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label260)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label261)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label262)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label263)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label264)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label265)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label266)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label267)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label268)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label269)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label270)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label271)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label272)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label273)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label274)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label275)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label276)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label277)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label278)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label279)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label280)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label281)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label282)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label283)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label284)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label285)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label286)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label287)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label288)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label289)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label290)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label291)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label292)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label293)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label294)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label295)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label296)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label297)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label298)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label299)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label300)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label301)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label302)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label303)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label304)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label305)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label306)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox75)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label307)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label311)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label37)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label312)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label313)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label314)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label316)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedPsblAmtText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label317)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateYText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2YText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateMText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2MText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateDText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2DText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateY2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Y2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2M2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateM2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateD2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2D2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedTypeText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedType2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalanceText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalance2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox62)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NationalPensPremText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox69)).BeginInit();
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
			((System.ComponentModel.ISupportInitialize)(this.textBox70)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox71)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox72)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox76)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox77)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox78)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox79)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox80)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox81)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox82)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox83)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox84)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox85)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox86)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox87)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox88)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox89)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox90)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox91)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox92)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox93)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox94)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox95)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox96)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox97)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox98)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox99)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedCntText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox100)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label195)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label318)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label319)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label320)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label321)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label322)).BeginInit();
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
			((System.ComponentModel.ISupportInitialize)(this.label324)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label325)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label326)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label327)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label328)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox137)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label315)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label331)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label332)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label333)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label334)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label335)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_3Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label337)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label338)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label339)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label340)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label341)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label342)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label344)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label348)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label350)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label351)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label352)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label353)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear2Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear1Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYearText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber4_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber3_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_Text)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label198)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label199)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label200)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adjDedLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtYen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt1Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtYen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt2Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtYen2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt1Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt2Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtYen2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adjDedLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label343,
            this.label345,
            this.line315,
            this.line222,
            this.line275,
            this.label336,
            this.line223,
            this.Label993,
            this.line308,
            this.line307,
            this.line306,
            this.line305,
            this.line304,
            this.line303,
            this.line302,
            this.line301,
            this.line300,
            this.line299,
            this.line298,
            this.line297,
            this.line296,
            this.line224,
            this.line295,
            this.line277,
            this.line276,
            this.Line313,
            this.Line324,
            this.label309,
            this.label310,
            this.label308,
            this.label79,
            this.line170,
            this.label38,
            this.label242,
            this.label239,
            this.label235,
            this.label233,
            this.YngDpndRemarksText1,
            this.DpndRemaksText2,
            this.DpndRemarksText1,
            this.label323,
            this.textBox73,
            this.label330,
            this.label206,
            this.CorpNumber1_4,
            this.CorpNumber1_3,
            this.CorpNumber1_2,
            this.CorpNumber1_1,
            this.label329,
            this.label205,
            this.CorpNumber2_1,
            this.label73,
            this.label70,
            this.label66,
            this.label64,
            this.label193,
            this.label194,
            this.label192,
            this.label78,
            this.label99,
            this.Label1063,
            this.label14,
            this.Label1105,
            this.Label1055,
            this.Label994,
            this.ylyEdAddress1_1Text,
            this.empCodeText,
            this.postNameText,
            this.empNameKanaText,
            this.Label996,
            this.Label997,
            this.Label998,
            this.Label999,
            this.Label1000,
            this.Label1001,
            this.Label1002,
            this.classText,
            this.paymntAmtText,
            this.Label1003,
            this.Label1004,
            this.slryInsmDedAmtText,
            this.Label1005,
            this.incmDedAmtSumText,
            this.Label1006,
            this.Label1007,
            this.ylyCollectTaxText,
            this.Label1008,
            this.Label1009,
            this.Label1010,
            this.Label1011,
            this.Label1012,
            this.Label1014,
            this.sposOldAgeTypeText,
            this.dedSposExistText,
            this.dedSposExist2Text,
            this.Label1016,
            this.sposExtDedAmtText,
            this.Label1018,
            this.Label1019,
            this.Label1020,
            this.Label1021,
            this.Label1022,
            this.Label1023,
            this.specDpndNum1_1Text,
            this.specDpndNum2_1Text,
            this.Label1024,
            this.Label1025,
            this.liveTgtAgePreNumText,
            this.Label1026,
            this.agePreNumText,
            this.agePreNum2Text,
            this.Label1027,
            this.Label1028,
            this.othersDpndNumText,
            this.Label1029,
            this.othersDpndNum2Text,
            this.Label1030,
            this.Label1031,
            this.liveTgtExtHandiNumText,
            this.extHndiNumText,
            this.Label1032,
            this.Label1033,
            this.Label1034,
            this.Label1035,
            this.Label1036,
            this.HandiNumText,
            this.Label1037,
            this.smlScaleCompCpratAmtText,
            this.Label1039,
            this.lifeInsDedAmtText,
            this.TextBox454,
            this.sponSumIncmAmtText,
            this.LifeInsPensAmtText,
            this.nolfInsLongProdAmtText,
            this.Label1051,
            this.Label1052,
            this.Label1053,
            this.Label1054,
            this.Label1065,
            this.Label1067,
            this.Label1069,
            this.Label1070,
            this.Label1071,
            this.Label1072,
            this.Label1073,
            this.Label1074,
            this.Label1075,
            this.empNameText,
            this.Label1076,
            this.minrTypeText,
            this.latterText,
            this.extHandiTypeText,
            this.handiTypeText,
            this.widowTypeText,
            this.extWidowTypeText,
            this.widomTypeText,
            this.wrkStdTypeText,
            this.Label1077,
            this.Label1078,
            this.Label1079,
            this.paymntAddressText,
            this.paymntNameText,
            this.Label1080,
            this.paymntPhoneText,
            this.Label1081,
            this.Label1082,
            this.Label1084,
            this.Label1085,
            this.Label1086,
            this.Label1087,
            this.Label1088,
            this.Label1089,
            this.Label1093,
            this.nolfInsDedAmtText,
            this.deathRetireTypeText,
            this.disasterTypeText,
            this.Label1113,
            this.foreignTypeText,
            this.Label1116,
            this.halfEmployTypeText,
            this.Label1117,
            this.halfRetireTypeText,
            this.halfEmReDateYearText,
            this.halfEmReFateMonthText,
            this.halfEmReDateDayText,
            this.Label1121,
            this.Label1122,
            this.birthDayYearText,
            this.birthDayMonthText,
            this.birthDayDayText,
            this.socInsDedAmtText,
            this.Label1123,
            this.Line323,
            this.Line325,
            this.Line327,
            this.Line328,
            this.Line129,
            this.Line395,
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
            this.Line408,
            this.Line413,
            this.Line415,
            this.Line417,
            this.Line418,
            this.Line419,
            this.Line420,
            this.Line421,
            this.Line422,
            this.Line427,
            this.Line431,
            this.Line434,
            this.Line436,
            this.Line440,
            this.Line441,
            this.Line442,
            this.Line443,
            this.Line444,
            this.Line445,
            this.Line446,
            this.Line447,
            this.Line450,
            this.Line451,
            this.Line452,
            this.Line455,
            this.Line615,
            this.Label1595,
            this.Line752,
            this.summary0Digit0Text,
            this.line1,
            this.line2,
            this.line3,
            this.Line433,
            this.Line438,
            this.Line439,
            this.Line329,
            this.Line330,
            this.label4,
            this.newLifeInsPensAmtText,
            this.newLifeInsCareAmtText,
            this.label20,
            this.label24,
            this.newLifeInsGeneralAmtText,
            this.lifeInsGeneralAmtText,
            this.summary1Digit0Text,
            this.line26,
            this.line31,
            this.line32,
            this.label2,
            this.label3,
            this.label1,
            this.YoungDpndNumText,
            this.line33,
            this.line34,
            this.line35,
            this.line36,
            this.line37,
            this.label41,
            this.label42,
            this.label43,
            this.label44,
            this.label45,
            this.line38,
            this.line39,
            this.line40,
            this.line41,
            this.line42,
            this.line43,
            this.label46,
            this.label47,
            this.label48,
            this.label49,
            this.line44,
            this.line45,
            this.line46,
            this.line47,
            this.line48,
            this.label50,
            this.line49,
            this.line50,
            this.line51,
            this.line52,
            this.line53,
            this.line54,
            this.line55,
            this.line56,
            this.line57,
            this.line58,
            this.line59,
            this.line60,
            this.line61,
            this.line62,
            this.line63,
            this.label51,
            this.label52,
            this.label53,
            this.label54,
            this.label55,
            this.label56,
            this.label57,
            this.label58,
            this.label59,
            this.label60,
            this.label61,
            this.label62,
            this.label63,
            this.line64,
            this.line65,
            this.line66,
            this.line67,
            this.line68,
            this.label65,
            this.label67,
            this.label68,
            this.line70,
            this.line71,
            this.line72,
            this.line73,
            this.line74,
            this.label69,
            this.label71,
            this.line76,
            this.line77,
            this.line78,
            this.line79,
            this.label72,
            this.label74,
            this.line81,
            this.label75,
            this.label76,
            this.line82,
            this.line83,
            this.label77,
            this.line84,
            this.line85,
            this.line90,
            this.label80,
            this.label81,
            this.line91,
            this.line92,
            this.line93,
            this.line94,
            this.label82,
            this.label83,
            this.label84,
            this.label85,
            this.label86,
            this.label87,
            this.line95,
            this.line96,
            this.line97,
            this.line98,
            this.line99,
            this.line100,
            this.label88,
            this.label89,
            this.label90,
            this.line101,
            this.line102,
            this.line103,
            this.label91,
            this.label92,
            this.label93,
            this.label94,
            this.label95,
            this.label96,
            this.label97,
            this.label98,
            this.label100,
            this.label101,
            this.label102,
            this.label103,
            this.label104,
            this.label105,
            this.line16,
            this.line18,
            this.label26,
            this.label27,
            this.label106,
            this.label107,
            this.label108,
            this.label109,
            this.label110,
            this.label111,
            this.label112,
            this.label113,
            this.label114,
            this.label115,
            this.label116,
            this.label117,
            this.label118,
            this.label13,
            this.label5,
            this.label18,
            this.label119,
            this.label120,
            this.label121,
            this.label122,
            this.label171,
            this.label176,
            this.label183,
            this.line17,
            this.line19,
            this.line104,
            this.line105,
            this.line106,
            this.line107,
            this.label184,
            this.label185,
            this.label186,
            this.label187,
            this.label188,
            this.line108,
            this.line109,
            this.line110,
            this.line111,
            this.label189,
            this.line112,
            this.line113,
            this.label190,
            this.line114,
            this.NonResidentNumText,
            this.label191,
            this.line115,
            this.line116,
            this.label6,
            this.label7,
            this.label8,
            this.label9,
            this.label12,
            this.label15,
            this.ylyEdAddress1_2Text,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.label16,
            this.label17,
            this.label19,
            this.label21,
            this.label22,
            this.label23,
            this.label25,
            this.textBox7,
            this.textBox8,
            this.label28,
            this.label29,
            this.textBox10,
            this.label30,
            this.textBox11,
            this.label31,
            this.label32,
            this.textBox12,
            this.label33,
            this.label34,
            this.label35,
            this.label36,
            this.label39,
            this.label40,
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.label123,
            this.textBox16,
            this.label124,
            this.label125,
            this.label126,
            this.label127,
            this.label128,
            this.label129,
            this.textBox17,
            this.textBox18,
            this.label130,
            this.label131,
            this.textBox19,
            this.label132,
            this.textBox20,
            this.textBox21,
            this.label133,
            this.label134,
            this.textBox22,
            this.label135,
            this.textBox23,
            this.label136,
            this.label137,
            this.textBox24,
            this.textBox25,
            this.label138,
            this.label139,
            this.label140,
            this.label141,
            this.label142,
            this.textBox26,
            this.label143,
            this.textBox27,
            this.label144,
            this.textBox28,
            this.textBox29,
            this.textBox30,
            this.textBox31,
            this.textBox32,
            this.label145,
            this.label146,
            this.label147,
            this.label148,
            this.label150,
            this.label151,
            this.label153,
            this.label154,
            this.label155,
            this.label156,
            this.label157,
            this.label158,
            this.label159,
            this.textBox33,
            this.label160,
            this.textBox34,
            this.textBox35,
            this.textBox36,
            this.textBox37,
            this.textBox38,
            this.textBox39,
            this.textBox40,
            this.textBox41,
            this.label161,
            this.label162,
            this.label163,
            this.textBox42,
            this.textBox43,
            this.label164,
            this.textBox44,
            this.label165,
            this.label166,
            this.label167,
            this.label168,
            this.label169,
            this.label170,
            this.label172,
            this.label173,
            this.label174,
            this.textBox45,
            this.textBox46,
            this.textBox47,
            this.label175,
            this.textBox48,
            this.label177,
            this.textBox49,
            this.label178,
            this.textBox50,
            this.textBox51,
            this.textBox52,
            this.textBox53,
            this.label182,
            this.label196,
            this.textBox54,
            this.textBox58,
            this.textBox59,
            this.textBox60,
            this.textBox61,
            this.label197,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line9,
            this.line10,
            this.line11,
            this.line12,
            this.line13,
            this.line14,
            this.line15,
            this.line20,
            this.line21,
            this.line22,
            this.line23,
            this.line120,
            this.line121,
            this.line122,
            this.line123,
            this.line124,
            this.line125,
            this.line126,
            this.line127,
            this.line128,
            this.line130,
            this.line131,
            this.line133,
            this.line134,
            this.line135,
            this.line136,
            this.line137,
            this.line138,
            this.line139,
            this.line140,
            this.line141,
            this.line142,
            this.line143,
            this.line146,
            this.line147,
            this.line148,
            this.line149,
            this.line150,
            this.label201,
            this.line151,
            this.textBox63,
            this.line152,
            this.line153,
            this.line154,
            this.line155,
            this.line156,
            this.line157,
            this.line158,
            this.line159,
            this.line160,
            this.label202,
            this.textBox64,
            this.textBox65,
            this.label203,
            this.label204,
            this.textBox66,
            this.textBox67,
            this.textBox68,
            this.line161,
            this.CorpNumber2_2,
            this.CorpNumber2_3,
            this.CorpNumber2_4,
            this.line162,
            this.line163,
            this.line164,
            this.line165,
            this.line166,
            this.line167,
            this.label207,
            this.label208,
            this.label209,
            this.textBox74,
            this.line168,
            this.line169,
            this.line171,
            this.line172,
            this.label210,
            this.label211,
            this.label212,
            this.label213,
            this.label214,
            this.line173,
            this.line174,
            this.line175,
            this.line176,
            this.line177,
            this.line178,
            this.label215,
            this.label216,
            this.label217,
            this.label218,
            this.line179,
            this.line180,
            this.line181,
            this.line182,
            this.line183,
            this.label219,
            this.line184,
            this.line185,
            this.line186,
            this.line187,
            this.line188,
            this.line189,
            this.line190,
            this.line191,
            this.line192,
            this.line193,
            this.line194,
            this.line195,
            this.line196,
            this.line197,
            this.line198,
            this.label220,
            this.label221,
            this.label222,
            this.label223,
            this.label224,
            this.label225,
            this.label226,
            this.label227,
            this.label228,
            this.label229,
            this.label230,
            this.label231,
            this.label232,
            this.line199,
            this.line200,
            this.line201,
            this.line202,
            this.line203,
            this.label234,
            this.label236,
            this.label237,
            this.line205,
            this.line206,
            this.line207,
            this.line208,
            this.line209,
            this.label238,
            this.label240,
            this.line211,
            this.line212,
            this.line213,
            this.line214,
            this.label241,
            this.label243,
            this.line216,
            this.label244,
            this.label245,
            this.line217,
            this.line218,
            this.label246,
            this.line219,
            this.line220,
            this.label247,
            this.label248,
            this.line225,
            this.label249,
            this.label250,
            this.line226,
            this.line227,
            this.line228,
            this.line229,
            this.label251,
            this.label252,
            this.label253,
            this.label254,
            this.label255,
            this.label256,
            this.line230,
            this.line231,
            this.line232,
            this.line233,
            this.line234,
            this.line235,
            this.label257,
            this.label258,
            this.label259,
            this.line236,
            this.line237,
            this.line238,
            this.label260,
            this.label261,
            this.label262,
            this.label263,
            this.label264,
            this.label265,
            this.label266,
            this.label267,
            this.label268,
            this.label269,
            this.label270,
            this.label271,
            this.label272,
            this.label273,
            this.label274,
            this.line239,
            this.line240,
            this.label275,
            this.label276,
            this.label277,
            this.label278,
            this.label279,
            this.label280,
            this.label281,
            this.label282,
            this.label283,
            this.label284,
            this.label285,
            this.label286,
            this.label287,
            this.label288,
            this.label289,
            this.label290,
            this.label291,
            this.label292,
            this.label293,
            this.label294,
            this.label295,
            this.label296,
            this.label297,
            this.label298,
            this.label299,
            this.line241,
            this.line242,
            this.line243,
            this.line244,
            this.line245,
            this.line246,
            this.label300,
            this.label301,
            this.label302,
            this.label303,
            this.label304,
            this.line247,
            this.line248,
            this.line249,
            this.line250,
            this.label305,
            this.line251,
            this.line252,
            this.label306,
            this.line253,
            this.textBox75,
            this.label307,
            this.line254,
            this.line255,
            this.label311,
            this.line256,
            this.line257,
            this.line258,
            this.line27,
            this.label37,
            this.label312,
            this.label313,
            this.label314,
            this.line28,
            this.line29,
            this.line265,
            this.line266,
            this.line267,
            this.line268,
            this.line269,
            this.line270,
            this.line271,
            this.line272,
            this.CorpNumber,
            this.label316,
            this.HousingObtDedPsblAmtText,
            this.label317,
            this.textBox1,
            this.HousingMovingDateYText,
            this.HousingMovingDate2YText,
            this.HousingMovingDateMText,
            this.HousingMovingDate2MText,
            this.HousingMovingDateDText,
            this.HousingMovingDate2DText,
            this.HousingMovingDateText,
            this.HousingMovingDate2Text,
            this.HousingMovingDateY2Text,
            this.HousingMovingDate2Y2Text,
            this.HousingMovingDate2M2Text,
            this.HousingMovingDateM2Text,
            this.HousingMovingDateD2Text,
            this.HousingMovingDate2D2Text,
            this.SpecDedTypeText,
            this.SpecDedType2Text,
            this.textBox2,
            this.textBox3,
            this.EyLoanBalanceText,
            this.EyLoanBalance2Text,
            this.textBox9,
            this.textBox62,
            this.NationalPensPremText,
            this.textBox69,
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
            this.textBox70,
            this.textBox71,
            this.textBox72,
            this.textBox76,
            this.textBox77,
            this.textBox78,
            this.textBox79,
            this.textBox80,
            this.textBox81,
            this.textBox82,
            this.textBox83,
            this.textBox84,
            this.textBox85,
            this.textBox86,
            this.textBox87,
            this.textBox88,
            this.textBox89,
            this.textBox90,
            this.textBox91,
            this.textBox92,
            this.textBox93,
            this.textBox94,
            this.textBox95,
            this.textBox96,
            this.textBox97,
            this.textBox98,
            this.textBox99,
            this.SposMyNumber2_1Text,
            this.SposMyNumber2_2Text,
            this.SposMyNumber2_3Text,
            this.DpndMyNumber2_1_1Text,
            this.DpndMyNumber2_1_2Text,
            this.DpndMyNumber2_1_3Text,
            this.DpndMyNumber2_2_1Text,
            this.DpndMyNumber2_2_2Text,
            this.DpndMyNumber2_2_3Text,
            this.DpndMyNumber2_3_1Text,
            this.DpndMyNumber2_3_2Text,
            this.DpndMyNumber2_3_3Text,
            this.DpndMyNumber2_4_1Text,
            this.DpndMyNumber2_4_2Text,
            this.DpndMyNumber2_4_3Text,
            this.MyNumber2_1Text,
            this.MyNumber2_2Text,
            this.MyNumber2_3Text,
            this.HousingObtDedCntText,
            this.textBox100,
            this.line117,
            this.label195,
            this.line119,
            this.MyNumber1_3Text,
            this.MyNumber1_2Text,
            this.MyNumber1_1Text,
            this.line278,
            this.line279,
            this.label318,
            this.label319,
            this.label320,
            this.label321,
            this.label322,
            this.SposMyNumber1_1Text,
            this.line259,
            this.SposMyNumber1_2Text,
            this.line261,
            this.SposMyNumber1_3Text,
            this.DpndMyNumber1_1_1Text,
            this.line262,
            this.DpndMyNumber1_1_2Text,
            this.DpndMyNumber1_1_3Text,
            this.line263,
            this.DpndMyNumber1_2_1Text,
            this.line264,
            this.DpndMyNumber1_2_2Text,
            this.line280,
            this.DpndMyNumber1_2_3Text,
            this.DpndMyNumber1_3_1Text,
            this.line281,
            this.DpndMyNumber1_3_2Text,
            this.line282,
            this.DpndMyNumber1_3_3Text,
            this.DpndMyNumber1_4_1Text,
            this.line283,
            this.DpndMyNumber1_4_2Text,
            this.line284,
            this.DpndMyNumber1_4_3Text,
            this.line260,
            this.label324,
            this.line285,
            this.line286,
            this.YngDpndMyNumber1_4_3Text,
            this.label325,
            this.YngDpndMyNumber1_1_1Text,
            this.line86,
            this.YngDpndMyNumber1_1_2Text,
            this.line87,
            this.YngDpndMyNumber1_1_3Text,
            this.label326,
            this.YngDpndMyNumber1_2_1Text,
            this.line88,
            this.YngDpndMyNumber1_2_2Text,
            this.line89,
            this.YngDpndMyNumber1_2_3Text,
            this.label327,
            this.YngDpndMyNumber1_3_1Text,
            this.line287,
            this.YngDpndMyNumber1_3_2Text,
            this.line288,
            this.YngDpndMyNumber1_3_3Text,
            this.label328,
            this.YngDpndMyNumber1_4_1Text,
            this.line289,
            this.YngDpndMyNumber1_4_2Text,
            this.line290,
            this.line30,
            this.textBox137,
            this.line291,
            this.line292,
            this.line293,
            this.label315,
            this.line294,
            this.YngDpndRemarksText2,
            this.line273,
            this.line274,
            this.label331,
            this.YngDpndMyNumber2_1_1Text,
            this.label332,
            this.YngDpndMyNumber2_1_2Text,
            this.YngDpndMyNumber2_1_3Text,
            this.line69,
            this.line75,
            this.label333,
            this.YngDpndMyNumber2_2_1Text,
            this.YngDpndMyNumber2_2_2Text,
            this.YngDpndMyNumber2_2_3Text,
            this.line80,
            this.line118,
            this.label334,
            this.YngDpndMyNumber2_3_1Text,
            this.YngDpndMyNumber2_3_2Text,
            this.YngDpndMyNumber2_3_3Text,
            this.line204,
            this.line210,
            this.label335,
            this.YngDpndMyNumber2_4_1Text,
            this.YngDpndMyNumber2_4_2Text,
            this.YngDpndMyNumber2_4_3Text,
            this.line215,
            this.line221,
            this.line309,
            this.line310,
            this.label337,
            this.label338,
            this.label339,
            this.label10,
            this.line314,
            this.line316,
            this.line317,
            this.line318,
            this.line319,
            this.line320,
            this.line321,
            this.line326,
            this.line331,
            this.line332,
            this.line333,
            this.line334,
            this.line335,
            this.line336,
            this.line337,
            this.line338,
            this.line339,
            this.line340,
            this.line341,
            this.line342,
            this.line343,
            this.label11,
            this.label340,
            this.label341,
            this.label342,
            this.label344,
            this.label348,
            this.label350,
            this.label351,
            this.label352,
            this.label353,
            this.SposMyNumber_Text,
            this.DpndMyNumber1_Text,
            this.DpndMyNumber2_Text,
            this.DpndMyNumber3_Text,
            this.DpndMyNumber4_Text,
            this.MyNumber_Text,
            this.YlyEdCalYear2Text,
            this.YlyEdCalYear1Text,
            this.YlyEdCalYearText,
            this.YngDpndMyNumber1_Text,
            this.YngDpndMyNumber4_Text,
            this.YngDpndMyNumber3_Text,
            this.YngDpndMyNumber2_Text,
            this.label198,
            this.label199,
            this.label200,
            this.adjDedLabel1,
            this.line24,
            this.baseDedAmtLabel1,
            this.baseDedAmtYen1,
            this.incmAdjDedAmt1Label1,
            this.incmAdjDedAmtYen1,
            this.incmAdjDedAmtText1,
            this.incmAdjDedAmt2Label1,
            this.pesnlDed11_Line1,
            this.birthNameOfEraText,
            this.line25,
            this.baseDedAmtLabel2,
            this.baseDedAmtYen2,
            this.incmAdjDedAmt1Label2,
            this.incmAdjDedAmt2Label2,
            this.incmAdjDedAmtText2,
            this.incmAdjDedAmtYen2,
            this.pesnlDed11_Line2,
            this.adjDedLabel2});
			this.Detail.Height = 7.958F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
			// 
			// label343
			// 
			this.label343.Height = 0.14F;
			this.label343.HyperLink = null;
			this.label343.Left = 0.1751969F;
			this.label343.Name = "label343";
			this.label343.Style = "font-size: 3pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 128";
			this.label343.Text = "(源泉・特別)";
			this.label343.Top = 4.163386F;
			this.label343.Width = 0.2917323F;
			// 
			// label345
			// 
			this.label345.Height = 0.14F;
			this.label345.HyperLink = null;
			this.label345.Left = 5.903937F;
			this.label345.Name = "label345";
			this.label345.Style = "font-size: 3pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 128";
			this.label345.Text = "(源泉・特別)";
			this.label345.Top = 4.163386F;
			this.label345.Width = 0.2917323F;
			// 
			// line315
			// 
			this.line315.Height = 9.313226E-09F;
			this.line315.Left = 5.916536F;
			this.line315.LineWeight = 1F;
			this.line315.Name = "line315";
			this.line315.Top = 0.01062992F;
			this.line315.Width = 5.192514F;
			this.line315.X1 = 5.916536F;
			this.line315.X2 = 11.10905F;
			this.line315.Y1 = 0.01062992F;
			this.line315.Y2 = 0.01062993F;
			// 
			// line222
			// 
			this.line222.Height = 0F;
			this.line222.Left = 0.188189F;
			this.line222.LineWeight = 1F;
			this.line222.Name = "line222";
			this.line222.Top = 0.00984253F;
			this.line222.Width = 5.191732F;
			this.line222.X1 = 0.188189F;
			this.line222.X2 = 5.379921F;
			this.line222.Y1 = 0.00984253F;
			this.line222.Y2 = 0.00984253F;
			// 
			// line275
			// 
			this.line275.Height = 0.0929134F;
			this.line275.Left = 0.2866141F;
			this.line275.LineWeight = 1F;
			this.line275.Name = "line275";
			this.line275.Top = 0.103937F;
			this.line275.Width = 1.192093E-07F;
			this.line275.X1 = 0.2866142F;
			this.line275.X2 = 0.2866141F;
			this.line275.Y1 = 0.103937F;
			this.line275.Y2 = 0.1968504F;
			// 
			// label336
			// 
			this.label336.Height = 0.1149606F;
			this.label336.HyperLink = null;
			this.label336.Left = 0.1976378F;
			this.label336.Name = "label336";
			this.label336.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label336.Text = "※";
			this.label336.Top = 0.009842521F;
			this.label336.Width = 0.1271654F;
			// 
			// line223
			// 
			this.line223.Height = 0F;
			this.line223.Left = 0.188189F;
			this.line223.LineWeight = 1F;
			this.line223.Name = "line223";
			this.line223.Top = 0.103937F;
			this.line223.Width = 5.191732F;
			this.line223.X1 = 0.188189F;
			this.line223.X2 = 5.379921F;
			this.line223.Y1 = 0.103937F;
			this.line223.Y2 = 0.103937F;
			// 
			// Label993
			// 
			this.Label993.Height = 0.2F;
			this.Label993.HyperLink = null;
			this.Label993.Left = 0.188F;
			this.Label993.Name = "Label993";
			this.Label993.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label993.Text = "支　払";
			this.Label993.Top = 0.318F;
			this.Label993.Width = 0.292F;
			// 
			// line308
			// 
			this.line308.Height = 0.1870079F;
			this.line308.Left = 2.062992F;
			this.line308.LineWeight = 1F;
			this.line308.Name = "line308";
			this.line308.Top = 0.009842522F;
			this.line308.Width = 0F;
			this.line308.X1 = 2.062992F;
			this.line308.X2 = 2.062992F;
			this.line308.Y1 = 0.009842522F;
			this.line308.Y2 = 0.1968504F;
			// 
			// line307
			// 
			this.line307.Height = 0.0929134F;
			this.line307.Left = 1.959843F;
			this.line307.LineWeight = 1F;
			this.line307.Name = "line307";
			this.line307.Top = 0.103937F;
			this.line307.Width = 0F;
			this.line307.X1 = 1.959843F;
			this.line307.X2 = 1.959843F;
			this.line307.Y1 = 0.103937F;
			this.line307.Y2 = 0.1968504F;
			// 
			// line306
			// 
			this.line306.Height = 0.0929134F;
			this.line306.Left = 1.855118F;
			this.line306.LineWeight = 1F;
			this.line306.Name = "line306";
			this.line306.Top = 0.103937F;
			this.line306.Width = 0F;
			this.line306.X1 = 1.855118F;
			this.line306.X2 = 1.855118F;
			this.line306.Y1 = 0.103937F;
			this.line306.Y2 = 0.1968504F;
			// 
			// line305
			// 
			this.line305.Height = 0.0929134F;
			this.line305.Left = 1.751969F;
			this.line305.LineWeight = 1F;
			this.line305.Name = "line305";
			this.line305.Top = 0.103937F;
			this.line305.Width = 0F;
			this.line305.X1 = 1.751969F;
			this.line305.X2 = 1.751969F;
			this.line305.Y1 = 0.103937F;
			this.line305.Y2 = 0.1968504F;
			// 
			// line304
			// 
			this.line304.Height = 0.0929134F;
			this.line304.Left = 1.64252F;
			this.line304.LineWeight = 1F;
			this.line304.Name = "line304";
			this.line304.Top = 0.103937F;
			this.line304.Width = 0F;
			this.line304.X1 = 1.64252F;
			this.line304.X2 = 1.64252F;
			this.line304.Y1 = 0.103937F;
			this.line304.Y2 = 0.1968504F;
			// 
			// line303
			// 
			this.line303.Height = 0.0929134F;
			this.line303.Left = 1.543307F;
			this.line303.LineWeight = 1F;
			this.line303.Name = "line303";
			this.line303.Top = 0.103937F;
			this.line303.Width = 0F;
			this.line303.X1 = 1.543307F;
			this.line303.X2 = 1.543307F;
			this.line303.Y1 = 0.103937F;
			this.line303.Y2 = 0.1968504F;
			// 
			// line302
			// 
			this.line302.Height = 0.0929134F;
			this.line302.Left = 1.435039F;
			this.line302.LineWeight = 1F;
			this.line302.Name = "line302";
			this.line302.Top = 0.103937F;
			this.line302.Width = 0F;
			this.line302.X1 = 1.435039F;
			this.line302.X2 = 1.435039F;
			this.line302.Y1 = 0.103937F;
			this.line302.Y2 = 0.1968504F;
			// 
			// line301
			// 
			this.line301.Height = 0.0929134F;
			this.line301.Left = 1.33504F;
			this.line301.LineWeight = 1F;
			this.line301.Name = "line301";
			this.line301.Top = 0.103937F;
			this.line301.Width = 0F;
			this.line301.X1 = 1.33504F;
			this.line301.X2 = 1.33504F;
			this.line301.Y1 = 0.103937F;
			this.line301.Y2 = 0.1968504F;
			// 
			// line300
			// 
			this.line300.Height = 0.0929134F;
			this.line300.Left = 1.229921F;
			this.line300.LineWeight = 1F;
			this.line300.Name = "line300";
			this.line300.Top = 0.103937F;
			this.line300.Width = 0F;
			this.line300.X1 = 1.229921F;
			this.line300.X2 = 1.229921F;
			this.line300.Y1 = 0.103937F;
			this.line300.Y2 = 0.1968504F;
			// 
			// line299
			// 
			this.line299.Height = 0.0929134F;
			this.line299.Left = 1.125984F;
			this.line299.LineWeight = 1F;
			this.line299.Name = "line299";
			this.line299.Top = 0.103937F;
			this.line299.Width = 0F;
			this.line299.X1 = 1.125984F;
			this.line299.X2 = 1.125984F;
			this.line299.Y1 = 0.103937F;
			this.line299.Y2 = 0.1968504F;
			// 
			// line298
			// 
			this.line298.Height = 0.0929134F;
			this.line298.Left = 1.02126F;
			this.line298.LineWeight = 1F;
			this.line298.Name = "line298";
			this.line298.Top = 0.103937F;
			this.line298.Width = 0F;
			this.line298.X1 = 1.02126F;
			this.line298.X2 = 1.02126F;
			this.line298.Y1 = 0.103937F;
			this.line298.Y2 = 0.1968504F;
			// 
			// line297
			// 
			this.line297.Height = 0.0929134F;
			this.line297.Left = 0.9181103F;
			this.line297.LineWeight = 1F;
			this.line297.Name = "line297";
			this.line297.Top = 0.103937F;
			this.line297.Width = 0F;
			this.line297.X1 = 0.9181103F;
			this.line297.X2 = 0.9181103F;
			this.line297.Y1 = 0.103937F;
			this.line297.Y2 = 0.1968504F;
			// 
			// line296
			// 
			this.line296.Height = 0.0929134F;
			this.line296.Left = 0.8086612F;
			this.line296.LineWeight = 1F;
			this.line296.Name = "line296";
			this.line296.Top = 0.103937F;
			this.line296.Width = 0F;
			this.line296.X1 = 0.8086612F;
			this.line296.X2 = 0.8086612F;
			this.line296.Y1 = 0.103937F;
			this.line296.Y2 = 0.1968504F;
			// 
			// line224
			// 
			this.line224.Height = 0.0929134F;
			this.line224.Left = 0.7094486F;
			this.line224.LineWeight = 1F;
			this.line224.Name = "line224";
			this.line224.Top = 0.103937F;
			this.line224.Width = 2.980232E-07F;
			this.line224.X1 = 0.7094489F;
			this.line224.X2 = 0.7094486F;
			this.line224.Y1 = 0.103937F;
			this.line224.Y2 = 0.1968504F;
			// 
			// line295
			// 
			this.line295.Height = 0.0929134F;
			this.line295.Left = 0.6090549F;
			this.line295.LineWeight = 1F;
			this.line295.Name = "line295";
			this.line295.Top = 0.103937F;
			this.line295.Width = 2.980232E-07F;
			this.line295.X1 = 0.6090552F;
			this.line295.X2 = 0.6090549F;
			this.line295.Y1 = 0.103937F;
			this.line295.Y2 = 0.1968504F;
			// 
			// line277
			// 
			this.line277.Height = 0.0929134F;
			this.line277.Left = 0.5047243F;
			this.line277.LineWeight = 1F;
			this.line277.Name = "line277";
			this.line277.Top = 0.103937F;
			this.line277.Width = 1.788139E-07F;
			this.line277.X1 = 0.5047245F;
			this.line277.X2 = 0.5047243F;
			this.line277.Y1 = 0.103937F;
			this.line277.Y2 = 0.1968504F;
			// 
			// line276
			// 
			this.line276.Height = 0.0929134F;
			this.line276.Left = 0.4003936F;
			this.line276.LineWeight = 1F;
			this.line276.Name = "line276";
			this.line276.Top = 0.103937F;
			this.line276.Width = 8.940697E-08F;
			this.line276.X1 = 0.4003937F;
			this.line276.X2 = 0.4003936F;
			this.line276.Y1 = 0.103937F;
			this.line276.Y2 = 0.1968504F;
			// 
			// Line313
			// 
			this.Line313.Height = 7.590158F;
			this.Line313.Left = 0.19F;
			this.Line313.LineWeight = 1F;
			this.Line313.Name = "Line313";
			this.Line313.Top = 0.009842521F;
			this.Line313.Width = 0.0001575053F;
			this.Line313.X1 = 0.1901575F;
			this.Line313.X2 = 0.19F;
			this.Line313.Y1 = 0.009842521F;
			this.Line313.Y2 = 7.6F;
			// 
			// Line324
			// 
			this.Line324.Height = 0F;
			this.Line324.Left = 0.1880815F;
			this.Line324.LineWeight = 1F;
			this.Line324.Name = "Line324";
			this.Line324.Top = 0.1982861F;
			this.Line324.Width = 5.187F;
			this.Line324.X1 = 0.1880815F;
			this.Line324.X2 = 5.375082F;
			this.Line324.Y1 = 0.1982861F;
			this.Line324.Y2 = 0.1982861F;
			// 
			// label309
			// 
			this.label309.Height = 0.11F;
			this.label309.HyperLink = null;
			this.label309.Left = 10.75892F;
			this.label309.Name = "label309";
			this.label309.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label309.Text = "である";
			this.label309.Top = 1.629714F;
			this.label309.Width = 0.34F;
			// 
			// label310
			// 
			this.label310.Height = 0.11F;
			this.label310.HyperLink = null;
			this.label310.Left = 10.75892F;
			this.label310.Name = "label310";
			this.label310.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label310.Text = "親族の数";
			this.label310.Top = 1.739714F;
			this.label310.Width = 0.34F;
			// 
			// label308
			// 
			this.label308.Height = 0.11F;
			this.label308.HyperLink = null;
			this.label308.Left = 10.75892F;
			this.label308.Name = "label308";
			this.label308.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label308.Text = "非居住者";
			this.label308.Top = 1.519715F;
			this.label308.Width = 0.34F;
			// 
			// label79
			// 
			this.label79.Height = 0.14F;
			this.label79.HyperLink = null;
			this.label79.Left = 0.45F;
			this.label79.Name = "label79";
			this.label79.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label79.Text = "氏名";
			this.label79.Top = 4.24F;
			this.label79.Width = 0.295F;
			// 
			// line170
			// 
			this.line170.Height = 0F;
			this.line170.Left = 6.098917F;
			this.line170.LineWeight = 1F;
			this.line170.Name = "line170";
			this.line170.Top = 4.934715F;
			this.line170.Width = 2.030002F;
			this.line170.X1 = 6.098917F;
			this.line170.X2 = 8.128919F;
			this.line170.Y1 = 4.934715F;
			this.line170.Y2 = 4.934715F;
			// 
			// label38
			// 
			this.label38.Height = 0.14F;
			this.label38.HyperLink = null;
			this.label38.Left = 6.188999F;
			this.label38.Name = "label38";
			this.label38.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label38.Text = "個人番号";
			this.label38.Top = 4.829F;
			this.label38.Width = 0.275F;
			// 
			// label242
			// 
			this.label242.Height = 0.14F;
			this.label242.HyperLink = null;
			this.label242.Left = 8.388917F;
			this.label242.Name = "label242";
			this.label242.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label242.Text = "氏名";
			this.label242.Top = 5.954714F;
			this.label242.Width = 0.295F;
			// 
			// label239
			// 
			this.label239.Height = 0.14F;
			this.label239.HyperLink = null;
			this.label239.Left = 8.388917F;
			this.label239.Name = "label239";
			this.label239.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label239.Text = "氏名";
			this.label239.Top = 5.529715F;
			this.label239.Width = 0.295F;
			// 
			// label235
			// 
			this.label235.Height = 0.14F;
			this.label235.HyperLink = null;
			this.label235.Left = 8.388917F;
			this.label235.Name = "label235";
			this.label235.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label235.Text = "氏名";
			this.label235.Top = 5.104715F;
			this.label235.Width = 0.295F;
			// 
			// label233
			// 
			this.label233.Height = 0.14F;
			this.label233.HyperLink = null;
			this.label233.Left = 8.388917F;
			this.label233.Name = "label233";
			this.label233.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label233.Text = "氏名";
			this.label233.Top = 4.679714F;
			this.label233.Width = 0.295F;
			// 
			// YngDpndRemarksText1
			// 
			this.YngDpndRemarksText1.CanGrow = false;
			this.YngDpndRemarksText1.DataField = "YNGREMARKS";
			this.YngDpndRemarksText1.Height = 0.5574803F;
			this.YngDpndRemarksText1.Left = 4.625197F;
			this.YngDpndRemarksText1.Name = "YngDpndRemarksText1";
			this.YngDpndRemarksText1.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.YngDpndRemarksText1.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012";
			this.YngDpndRemarksText1.Top = 5.662599F;
			this.YngDpndRemarksText1.Width = 0.7299993F;
			// 
			// DpndRemaksText2
			// 
			this.DpndRemaksText2.CanGrow = false;
			this.DpndRemaksText2.DataField = "Remarks";
			this.DpndRemaksText2.Height = 0.803F;
			this.DpndRemaksText2.Left = 10.35394F;
			this.DpndRemaksText2.Name = "DpndRemaksText2";
			this.DpndRemaksText2.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.DpndRemaksText2.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012(7)123456789012(8)123456789012(9)123456789012";
			this.DpndRemaksText2.Top = 4.703544F;
			this.DpndRemaksText2.Width = 0.7299995F;
			// 
			// DpndRemarksText1
			// 
			this.DpndRemarksText1.CanGrow = false;
			this.DpndRemarksText1.DataField = "Remarks";
			this.DpndRemarksText1.Height = 0.803F;
			this.DpndRemarksText1.Left = 4.625197F;
			this.DpndRemarksText1.Name = "DpndRemarksText1";
			this.DpndRemarksText1.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.DpndRemarksText1.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012(7)123456789012(8)123456789012(9)123456789012";
			this.DpndRemarksText1.Top = 4.696851F;
			this.DpndRemarksText1.Width = 0.7299993F;
			// 
			// label323
			// 
			this.label323.Height = 0.1602364F;
			this.label323.HyperLink = null;
			this.label323.Left = 4.624804F;
			this.label323.Name = "label323";
			this.label323.Style = "font-size: 4pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.label323.Text = "5人目以降の控除対象扶養親族の個人番号";
			this.label323.Top = 4.529922F;
			this.label323.Width = 0.7251964F;
			// 
			// textBox73
			// 
			this.textBox73.CanGrow = false;
			this.textBox73.Height = 0.2F;
			this.textBox73.Left = 7.728918F;
			this.textBox73.MultiLine = false;
			this.textBox73.Name = "textBox73";
			this.textBox73.Style = "font-size: 5pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.textBox73.Text = "（右詰で記載してください。）";
			this.textBox73.Top = 6.899715F;
			this.textBox73.Width = 1.08F;
			// 
			// label330
			// 
			this.label330.Height = 0.15F;
			this.label330.HyperLink = null;
			this.label330.Left = 0.4251969F;
			this.label330.Name = "label330";
			this.label330.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label330.Text = "法人番号";
			this.label330.Top = 6.979922F;
			this.label330.Width = 0.48F;
			// 
			// label206
			// 
			this.label206.Height = 0.15F;
			this.label206.HyperLink = null;
			this.label206.Left = 6.153918F;
			this.label206.Name = "label206";
			this.label206.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label206.Text = "個人番号又は";
			this.label206.Top = 6.869714F;
			this.label206.Width = 0.48F;
			// 
			// CorpNumber1_4
			// 
			this.CorpNumber1_4.CanGrow = false;
			this.CorpNumber1_4.Height = 0.2F;
			this.CorpNumber1_4.Left = 1.655279F;
			this.CorpNumber1_4.MultiLine = false;
			this.CorpNumber1_4.Name = "CorpNumber1_4";
			this.CorpNumber1_4.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_4.Text = null;
			this.CorpNumber1_4.Top = 6.900365F;
			this.CorpNumber1_4.Width = 0.3F;
			// 
			// CorpNumber1_3
			// 
			this.CorpNumber1_3.CanGrow = false;
			this.CorpNumber1_3.Height = 0.2F;
			this.CorpNumber1_3.Left = 1.355279F;
			this.CorpNumber1_3.MultiLine = false;
			this.CorpNumber1_3.Name = "CorpNumber1_3";
			this.CorpNumber1_3.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_3.Text = null;
			this.CorpNumber1_3.Top = 6.900365F;
			this.CorpNumber1_3.Width = 0.3F;
			// 
			// CorpNumber1_2
			// 
			this.CorpNumber1_2.CanGrow = false;
			this.CorpNumber1_2.Height = 0.2F;
			this.CorpNumber1_2.Left = 1.055197F;
			this.CorpNumber1_2.MultiLine = false;
			this.CorpNumber1_2.Name = "CorpNumber1_2";
			this.CorpNumber1_2.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_2.Text = null;
			this.CorpNumber1_2.Top = 6.90008F;
			this.CorpNumber1_2.Width = 0.3F;
			// 
			// CorpNumber1_1
			// 
			this.CorpNumber1_1.CanGrow = false;
			this.CorpNumber1_1.Height = 0.2F;
			this.CorpNumber1_1.Left = 0.9051955F;
			this.CorpNumber1_1.MultiLine = false;
			this.CorpNumber1_1.Name = "CorpNumber1_1";
			this.CorpNumber1_1.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber1_1.Text = null;
			this.CorpNumber1_1.Top = 6.90008F;
			this.CorpNumber1_1.Width = 0.15F;
			// 
			// label329
			// 
			this.label329.Height = 0.15F;
			this.label329.HyperLink = null;
			this.label329.Left = 0.4251969F;
			this.label329.Name = "label329";
			this.label329.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label329.Text = "個人番号又は";
			this.label329.Top = 6.880315F;
			this.label329.Width = 0.48F;
			// 
			// label205
			// 
			this.label205.Height = 0.15F;
			this.label205.HyperLink = null;
			this.label205.Left = 6.153918F;
			this.label205.Name = "label205";
			this.label205.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label205.Text = "法人番号";
			this.label205.Top = 6.979715F;
			this.label205.Width = 0.48F;
			// 
			// CorpNumber2_1
			// 
			this.CorpNumber2_1.CanGrow = false;
			this.CorpNumber2_1.Height = 0.2F;
			this.CorpNumber2_1.Left = 6.633917F;
			this.CorpNumber2_1.MultiLine = false;
			this.CorpNumber2_1.Name = "CorpNumber2_1";
			this.CorpNumber2_1.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber2_1.Text = null;
			this.CorpNumber2_1.Top = 6.899715F;
			this.CorpNumber2_1.Width = 0.15F;
			// 
			// label73
			// 
			this.label73.Height = 0.14F;
			this.label73.HyperLink = null;
			this.label73.Left = 2.66F;
			this.label73.Name = "label73";
			this.label73.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label73.Text = "氏名";
			this.label73.Top = 5.955F;
			this.label73.Width = 0.295F;
			// 
			// label70
			// 
			this.label70.Height = 0.14F;
			this.label70.HyperLink = null;
			this.label70.Left = 2.66F;
			this.label70.Name = "label70";
			this.label70.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label70.Text = "氏名";
			this.label70.Top = 5.53F;
			this.label70.Width = 0.295F;
			// 
			// label66
			// 
			this.label66.Height = 0.14F;
			this.label66.HyperLink = null;
			this.label66.Left = 2.66F;
			this.label66.Name = "label66";
			this.label66.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label66.Text = "氏名";
			this.label66.Top = 5.105F;
			this.label66.Width = 0.295F;
			// 
			// label64
			// 
			this.label64.Height = 0.14F;
			this.label64.HyperLink = null;
			this.label64.Left = 2.66F;
			this.label64.Name = "label64";
			this.label64.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label64.Text = "氏名";
			this.label64.Top = 4.68F;
			this.label64.Width = 0.295F;
			// 
			// label193
			// 
			this.label193.Height = 0.11F;
			this.label193.HyperLink = null;
			this.label193.Left = 5.03F;
			this.label193.Name = "label193";
			this.label193.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label193.Text = "である";
			this.label193.Top = 1.63F;
			this.label193.Width = 0.34F;
			// 
			// label194
			// 
			this.label194.Height = 0.11F;
			this.label194.HyperLink = null;
			this.label194.Left = 5.03F;
			this.label194.Name = "label194";
			this.label194.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label194.Text = "親族の数";
			this.label194.Top = 1.74F;
			this.label194.Width = 0.34F;
			// 
			// label192
			// 
			this.label192.Height = 0.11F;
			this.label192.HyperLink = null;
			this.label192.Left = 5.03F;
			this.label192.Name = "label192";
			this.label192.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label192.Text = "非居住者";
			this.label192.Top = 1.52F;
			this.label192.Width = 0.34F;
			// 
			// label78
			// 
			this.label78.Height = 0.14F;
			this.label78.HyperLink = null;
			this.label78.Left = 0.43F;
			this.label78.Name = "label78";
			this.label78.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label78.Text = "(フリガナ)";
			this.label78.Top = 4.1F;
			this.label78.Width = 0.33F;
			// 
			// label99
			// 
			this.label99.Height = 0.14F;
			this.label99.HyperLink = null;
			this.label99.Left = 0.55F;
			this.label99.Name = "label99";
			this.label99.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label99.Text = "特別控除可能額";
			this.label99.Top = 3.969998F;
			this.label99.Width = 0.42F;
			// 
			// Label1063
			// 
			this.Label1063.Height = 0.4401575F;
			this.Label1063.HyperLink = null;
			this.Label1063.Left = 1.66811F;
			this.Label1063.Name = "Label1063";
			this.Label1063.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1063.Text = "寡婦";
			this.Label1063.Top = 6.209843F;
			this.Label1063.Width = 0.1251968F;
			// 
			// label14
			// 
			this.label14.Height = 0.44F;
			this.label14.HyperLink = null;
			this.label14.Left = 0.6F;
			this.label14.Name = "label14";
			this.label14.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label14.Text = "死亡退職";
			this.label14.Top = 6.21F;
			this.label14.Width = 0.125F;
			// 
			// Label1105
			// 
			this.Label1105.Height = 0.44F;
			this.Label1105.HyperLink = null;
			this.Label1105.Left = 2.375F;
			this.Label1105.Name = "Label1105";
			this.Label1105.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1105.Text = "";
			this.Label1105.Top = 6.210001F;
			this.Label1105.Width = 0.125F;
			// 
			// Label1055
			// 
			this.Label1055.Height = 0.2499999F;
			this.Label1055.HyperLink = null;
			this.Label1055.Left = 1.435F;
			this.Label1055.Name = "Label1055";
			this.Label1055.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1055.Text = "その他";
			this.Label1055.Top = 6.35F;
			this.Label1055.Width = 0.125F;
			// 
			// Label994
			// 
			this.Label994.Height = 0.82F;
			this.Label994.HyperLink = null;
			this.Label994.Left = 0.48F;
			this.Label994.Name = "Label994";
			this.Label994.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label994.Text = "住所又は居所";
			this.Label994.Top = 0.208F;
			this.Label994.Width = 0.188F;
			// 
			// ylyEdAddress1_1Text
			// 
			this.ylyEdAddress1_1Text.CanGrow = false;
			this.ylyEdAddress1_1Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_1Text.Height = 0.7780001F;
			this.ylyEdAddress1_1Text.Left = 0.678F;
			this.ylyEdAddress1_1Text.Name = "ylyEdAddress1_1Text";
			this.ylyEdAddress1_1Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_1Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_1Text.Top = 0.208F;
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
			this.empCodeText.Top = 0.1968504F;
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
			this.postNameText.Top = 0.511F;
			this.postNameText.Width = 1.619F;
			// 
			// empNameKanaText
			// 
			this.empNameKanaText.CanGrow = false;
			this.empNameKanaText.DataField = "EMP_REGIST_NAME_KANA";
			this.empNameKanaText.Height = 0.12F;
			this.empNameKanaText.Left = 3.716F;
			this.empNameKanaText.Name = "empNameKanaText";
			this.empNameKanaText.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.empNameKanaText.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.empNameKanaText.Top = 0.7F;
			this.empNameKanaText.Width = 1.619F;
			// 
			// Label996
			// 
			this.Label996.Height = 0.1200787F;
			this.Label996.HyperLink = null;
			this.Label996.Left = 3.087F;
			this.Label996.Name = "Label996";
			this.Label996.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label996.Text = "(受給者番号）";
			this.Label996.Top = 0.198F;
			this.Label996.Width = 0.6059055F;
			// 
			// Label997
			// 
			this.Label997.Height = 0.12F;
			this.Label997.HyperLink = null;
			this.Label997.Left = 3.207F;
			this.Label997.Name = "Label997";
			this.Label997.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label997.Text = "(フリガナ）";
			this.Label997.Top = 0.7040001F;
			this.Label997.Width = 0.543F;
			// 
			// Label998
			// 
			this.Label998.Height = 0.156F;
			this.Label998.HyperLink = null;
			this.Label998.Left = 3.087F;
			this.Label998.Name = "Label998";
			this.Label998.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label998.Text = "(役職名）";
			this.Label998.Top = 0.5100001F;
			this.Label998.Width = 0.543F;
			// 
			// Label999
			// 
			this.Label999.Height = 0.15F;
			this.Label999.HyperLink = null;
			this.Label999.Left = 0.191F;
			this.Label999.Name = "Label999";
			this.Label999.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label999.Text = "種　　別";
			this.Label999.Top = 1.05F;
			this.Label999.Width = 0.92F;
			// 
			// Label1000
			// 
			this.Label1000.Height = 0.15F;
			this.Label1000.HyperLink = null;
			this.Label1000.Left = 1.136F;
			this.Label1000.Name = "Label1000";
			this.Label1000.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1000.Text = "支　払　金　額";
			this.Label1000.Top = 1.05F;
			this.Label1000.Width = 1.05F;
			// 
			// Label1001
			// 
			this.Label1001.Height = 0.15F;
			this.Label1001.HyperLink = null;
			this.Label1001.Left = 2.214173F;
			this.Label1001.Name = "Label1001";
			this.Label1001.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1001.Text = " 給与所得控除後の金額";
			this.Label1001.Top = 1.015748F;
			this.Label1001.Width = 1.04F;
			// 
			// Label1002
			// 
			this.Label1002.Height = 0.15F;
			this.Label1002.HyperLink = null;
			this.Label1002.Left = 3.277F;
			this.Label1002.Name = "Label1002";
			this.Label1002.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1002.Text = "所得控除の額の合計額";
			this.Label1002.Top = 1.05F;
			this.Label1002.Width = 1.04F;
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
			this.classText.Top = 1.22F;
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
			this.paymntAmtText.Top = 1.22F;
			this.paymntAmtText.Width = 0.85F;
			// 
			// Label1003
			// 
			this.Label1003.Height = 0.125F;
			this.Label1003.HyperLink = null;
			this.Label1003.Left = 1.136F;
			this.Label1003.Name = "Label1003";
			this.Label1003.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1003.Text = "内";
			this.Label1003.Top = 1.22F;
			this.Label1003.Width = 0.1F;
			// 
			// Label1004
			// 
			this.Label1004.Height = 0.125F;
			this.Label1004.HyperLink = null;
			this.Label1004.Left = 2.063F;
			this.Label1004.Name = "Label1004";
			this.Label1004.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1004.Text = "円";
			this.Label1004.Top = 1.22F;
			this.Label1004.Width = 0.141F;
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
			this.slryInsmDedAmtText.Top = 1.22F;
			this.slryInsmDedAmtText.Width = 0.85F;
			// 
			// Label1005
			// 
			this.Label1005.Height = 0.125F;
			this.Label1005.HyperLink = null;
			this.Label1005.Left = 3.142F;
			this.Label1005.Name = "Label1005";
			this.Label1005.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1005.Text = "円";
			this.Label1005.Top = 1.22F;
			this.Label1005.Width = 0.1245001F;
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
			this.incmDedAmtSumText.Top = 1.22F;
			this.incmDedAmtSumText.Width = 0.85F;
			// 
			// Label1006
			// 
			this.Label1006.Height = 0.125F;
			this.Label1006.HyperLink = null;
			this.Label1006.Left = 4.205F;
			this.Label1006.Name = "Label1006";
			this.Label1006.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1006.Text = "円";
			this.Label1006.Top = 1.22F;
			this.Label1006.Width = 0.125F;
			// 
			// Label1007
			// 
			this.Label1007.Height = 0.125F;
			this.Label1007.HyperLink = null;
			this.Label1007.Left = 4.33F;
			this.Label1007.Name = "Label1007";
			this.Label1007.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1007.Text = "内";
			this.Label1007.Top = 1.22F;
			this.Label1007.Width = 0.125F;
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
			this.ylyCollectTaxText.Top = 1.22F;
			this.ylyCollectTaxText.Width = 0.85F;
			// 
			// Label1008
			// 
			this.Label1008.Height = 0.125F;
			this.Label1008.HyperLink = null;
			this.Label1008.Left = 5.236F;
			this.Label1008.Name = "Label1008";
			this.Label1008.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1008.Text = "円";
			this.Label1008.Top = 1.22F;
			this.Label1008.Width = 0.134F;
			// 
			// Label1009
			// 
			this.Label1009.Height = 0.15F;
			this.Label1009.HyperLink = null;
			this.Label1009.Left = 4.34F;
			this.Label1009.Name = "Label1009";
			this.Label1009.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1009.Text = "源　泉　徴　収　税　額";
			this.Label1009.Top = 1.05F;
			this.Label1009.Width = 1.03F;
			// 
			// Label1010
			// 
			this.Label1010.Height = 0.157F;
			this.Label1010.HyperLink = null;
			this.Label1010.Left = 0.2F;
			this.Label1010.Name = "Label1010";
			this.Label1010.Style = "font-size: 4.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1010.Text = "(源泉)控除対象配偶者";
			this.Label1010.Top = 1.517F;
			this.Label1010.Width = 0.68F;
			// 
			// Label1011
			// 
			this.Label1011.Height = 0.15F;
			this.Label1011.HyperLink = null;
			this.Label1011.Left = 0.67F;
			this.Label1011.Name = "Label1011";
			this.Label1011.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1011.Text = "老人";
			this.Label1011.Top = 1.695F;
			this.Label1011.Width = 0.23F;
			// 
			// Label1012
			// 
			this.Label1012.Height = 0.14F;
			this.Label1012.HyperLink = null;
			this.Label1012.Left = 0.2F;
			this.Label1012.Name = "Label1012";
			this.Label1012.Style = "font-size: 4pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1012.Text = "有";
			this.Label1012.Top = 1.807F;
			this.Label1012.Width = 0.23F;
			// 
			// Label1014
			// 
			this.Label1014.Height = 0.14F;
			this.Label1014.HyperLink = null;
			this.Label1014.Left = 0.435F;
			this.Label1014.Name = "Label1014";
			this.Label1014.Style = "font-size: 4pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.Label1014.Text = "従有";
			this.Label1014.Top = 1.807F;
			this.Label1014.Width = 0.23F;
			// 
			// sposOldAgeTypeText
			// 
			this.sposOldAgeTypeText.CanGrow = false;
			this.sposOldAgeTypeText.DataField = "SPOS_OLD_AGE_TYPE";
			this.sposOldAgeTypeText.Height = 0.33F;
			this.sposOldAgeTypeText.Left = 0.67F;
			this.sposOldAgeTypeText.Name = "sposOldAgeTypeText";
			this.sposOldAgeTypeText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.sposOldAgeTypeText.Text = "○";
			this.sposOldAgeTypeText.Top = 1.87F;
			this.sposOldAgeTypeText.Width = 0.23F;
			// 
			// dedSposExistText
			// 
			this.dedSposExistText.CanGrow = false;
			this.dedSposExistText.DataField = "DED_SPOS_EXIST";
			this.dedSposExistText.Height = 0.23F;
			this.dedSposExistText.Left = 0.2F;
			this.dedSposExistText.Name = "dedSposExistText";
			this.dedSposExistText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExistText.Text = "○";
			this.dedSposExistText.Top = 1.97F;
			this.dedSposExistText.Width = 0.23F;
			// 
			// dedSposExist2Text
			// 
			this.dedSposExist2Text.CanGrow = false;
			this.dedSposExist2Text.DataField = "DED_SPOS_EXIST2";
			this.dedSposExist2Text.Height = 0.23F;
			this.dedSposExist2Text.Left = 0.435F;
			this.dedSposExist2Text.Name = "dedSposExist2Text";
			this.dedSposExist2Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.dedSposExist2Text.Text = "○";
			this.dedSposExist2Text.Top = 1.97F;
			this.dedSposExist2Text.Width = 0.23F;
			// 
			// Label1016
			// 
			this.Label1016.Height = 0.157F;
			this.Label1016.HyperLink = null;
			this.Label1016.Left = 0.905F;
			this.Label1016.Name = "Label1016";
			this.Label1016.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1016.Text = "配 偶 者 (特 別)";
			this.Label1016.Top = 1.528F;
			this.Label1016.Width = 0.85F;
			// 
			// sposExtDedAmtText
			// 
			this.sposExtDedAmtText.CanGrow = false;
			this.sposExtDedAmtText.DataField = "SPOS_EXT_DED_AMT";
			this.sposExtDedAmtText.Height = 0.15F;
			this.sposExtDedAmtText.Left = 0.905F;
			this.sposExtDedAmtText.Name = "sposExtDedAmtText";
			this.sposExtDedAmtText.OutputFormat = "#,##0";
			this.sposExtDedAmtText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.sposExtDedAmtText.Text = "Z,ZZZ,ZZ9";
			this.sposExtDedAmtText.Top = 2.03F;
			this.sposExtDedAmtText.Width = 0.7F;
			// 
			// Label1018
			// 
			this.Label1018.Height = 0.11F;
			this.Label1018.HyperLink = null;
			this.Label1018.Left = 1.865F;
			this.Label1018.Name = "Label1018";
			this.Label1018.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1018.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.Label1018.Top = 1.52F;
			this.Label1018.Width = 1.7F;
			// 
			// Label1019
			// 
			this.Label1019.Height = 0.11F;
			this.Label1019.HyperLink = null;
			this.Label1019.Left = 1.865F;
			this.Label1019.Name = "Label1019";
			this.Label1019.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1019.Text = "（ 配 偶 者 を 除 く 。）";
			this.Label1019.Top = 1.63F;
			this.Label1019.Width = 1.7F;
			// 
			// Label1020
			// 
			this.Label1020.Height = 0.1F;
			this.Label1020.HyperLink = null;
			this.Label1020.Left = 1.775F;
			this.Label1020.Name = "Label1020";
			this.Label1020.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1020.Text = "特　定";
			this.Label1020.Top = 1.775F;
			this.Label1020.Width = 0.54F;
			// 
			// Label1021
			// 
			this.Label1021.Height = 0.1F;
			this.Label1021.HyperLink = null;
			this.Label1021.Left = 2.33F;
			this.Label1021.Name = "Label1021";
			this.Label1021.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1021.Text = "老　人";
			this.Label1021.Top = 1.775F;
			this.Label1021.Width = 0.77F;
			// 
			// Label1022
			// 
			this.Label1022.Height = 0.1F;
			this.Label1022.HyperLink = null;
			this.Label1022.Left = 3.12F;
			this.Label1022.Name = "Label1022";
			this.Label1022.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1022.Text = "その他";
			this.Label1022.Top = 1.775F;
			this.Label1022.Width = 0.53F;
			// 
			// Label1023
			// 
			this.Label1023.Height = 0.15F;
			this.Label1023.HyperLink = null;
			this.Label1023.Left = 1.97F;
			this.Label1023.Name = "Label1023";
			this.Label1023.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1023.Text = "人";
			this.Label1023.Top = 1.9F;
			this.Label1023.Width = 0.1F;
			// 
			// specDpndNum1_1Text
			// 
			this.specDpndNum1_1Text.CanGrow = false;
			this.specDpndNum1_1Text.DataField = "SPEC_DPND_NUM";
			this.specDpndNum1_1Text.Height = 0.15F;
			this.specDpndNum1_1Text.Left = 1.813F;
			this.specDpndNum1_1Text.Name = "specDpndNum1_1Text";
			this.specDpndNum1_1Text.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.specDpndNum1_1Text.Text = "Z6";
			this.specDpndNum1_1Text.Top = 2.03F;
			this.specDpndNum1_1Text.Width = 0.15F;
			// 
			// specDpndNum2_1Text
			// 
			this.specDpndNum2_1Text.CanGrow = false;
			this.specDpndNum2_1Text.DataField = "SPEC_DPND_NUM2";
			this.specDpndNum2_1Text.Height = 0.15F;
			this.specDpndNum2_1Text.Left = 2.09F;
			this.specDpndNum2_1Text.Name = "specDpndNum2_1Text";
			this.specDpndNum2_1Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.specDpndNum2_1Text.Text = "Z6";
			this.specDpndNum2_1Text.Top = 2.03F;
			this.specDpndNum2_1Text.Width = 0.22F;
			// 
			// Label1024
			// 
			this.Label1024.Height = 0.15F;
			this.Label1024.HyperLink = null;
			this.Label1024.Left = 2.09F;
			this.Label1024.Name = "Label1024";
			this.Label1024.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1024.Text = "従人";
			this.Label1024.Top = 1.9F;
			this.Label1024.Width = 0.22F;
			// 
			// Label1025
			// 
			this.Label1025.Height = 0.15F;
			this.Label1025.HyperLink = null;
			this.Label1025.Left = 2.42F;
			this.Label1025.Name = "Label1025";
			this.Label1025.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1025.Text = "内";
			this.Label1025.Top = 1.9F;
			this.Label1025.Width = 0.125F;
			// 
			// liveTgtAgePreNumText
			// 
			this.liveTgtAgePreNumText.CanGrow = false;
			this.liveTgtAgePreNumText.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.liveTgtAgePreNumText.Height = 0.15F;
			this.liveTgtAgePreNumText.Left = 2.33F;
			this.liveTgtAgePreNumText.Name = "liveTgtAgePreNumText";
			this.liveTgtAgePreNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.liveTgtAgePreNumText.Text = "Z6";
			this.liveTgtAgePreNumText.Top = 2.03F;
			this.liveTgtAgePreNumText.Width = 0.15F;
			// 
			// Label1026
			// 
			this.Label1026.Height = 0.15F;
			this.Label1026.HyperLink = null;
			this.Label1026.Left = 2.76F;
			this.Label1026.Name = "Label1026";
			this.Label1026.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1026.Text = "人";
			this.Label1026.Top = 1.9F;
			this.Label1026.Width = 0.1F;
			// 
			// agePreNumText
			// 
			this.agePreNumText.CanGrow = false;
			this.agePreNumText.DataField = "AGE_PRE_NUM";
			this.agePreNumText.Height = 0.15F;
			this.agePreNumText.Left = 2.62F;
			this.agePreNumText.Name = "agePreNumText";
			this.agePreNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.agePreNumText.Text = "Z6";
			this.agePreNumText.Top = 2.03F;
			this.agePreNumText.Width = 0.15F;
			// 
			// agePreNum2Text
			// 
			this.agePreNum2Text.CanGrow = false;
			this.agePreNum2Text.DataField = "AGE_PRE_NUM2";
			this.agePreNum2Text.Height = 0.15F;
			this.agePreNum2Text.Left = 2.89F;
			this.agePreNum2Text.Name = "agePreNum2Text";
			this.agePreNum2Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.agePreNum2Text.Text = "Z6";
			this.agePreNum2Text.Top = 2.03F;
			this.agePreNum2Text.Width = 0.22F;
			// 
			// Label1027
			// 
			this.Label1027.Height = 0.125F;
			this.Label1027.HyperLink = null;
			this.Label1027.Left = 2.89F;
			this.Label1027.Name = "Label1027";
			this.Label1027.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1027.Text = "従人";
			this.Label1027.Top = 1.9F;
			this.Label1027.Width = 0.22F;
			// 
			// Label1028
			// 
			this.Label1028.Height = 0.15F;
			this.Label1028.HyperLink = null;
			this.Label1028.Left = 3.3F;
			this.Label1028.Name = "Label1028";
			this.Label1028.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1028.Text = "人";
			this.Label1028.Top = 1.9F;
			this.Label1028.Width = 0.1F;
			// 
			// othersDpndNumText
			// 
			this.othersDpndNumText.CanGrow = false;
			this.othersDpndNumText.DataField = "OTHERS_DPND_NUM";
			this.othersDpndNumText.Height = 0.15F;
			this.othersDpndNumText.Left = 3.18F;
			this.othersDpndNumText.Name = "othersDpndNumText";
			this.othersDpndNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.othersDpndNumText.Text = "Z6";
			this.othersDpndNumText.Top = 2.03F;
			this.othersDpndNumText.Width = 0.15F;
			// 
			// Label1029
			// 
			this.Label1029.Height = 0.125F;
			this.Label1029.HyperLink = null;
			this.Label1029.Left = 3.44F;
			this.Label1029.Name = "Label1029";
			this.Label1029.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1029.Text = "従人";
			this.Label1029.Top = 1.9F;
			this.Label1029.Width = 0.22F;
			// 
			// othersDpndNum2Text
			// 
			this.othersDpndNum2Text.CanGrow = false;
			this.othersDpndNum2Text.DataField = "OTHERS_DPND_NUM2";
			this.othersDpndNum2Text.Height = 0.15F;
			this.othersDpndNum2Text.Left = 3.44F;
			this.othersDpndNum2Text.Name = "othersDpndNum2Text";
			this.othersDpndNum2Text.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.othersDpndNum2Text.Text = "Z6";
			this.othersDpndNum2Text.Top = 2.03F;
			this.othersDpndNum2Text.Width = 0.22F;
			// 
			// Label1030
			// 
			this.Label1030.Height = 0.11F;
			this.Label1030.HyperLink = null;
			this.Label1030.Left = 4.07F;
			this.Label1030.Name = "Label1030";
			this.Label1030.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1030.Text = "障 害 者 の 数";
			this.Label1030.Top = 1.52F;
			this.Label1030.Width = 0.94F;
			// 
			// Label1031
			// 
			this.Label1031.Height = 0.1F;
			this.Label1031.HyperLink = null;
			this.Label1031.Left = 4.07F;
			this.Label1031.Name = "Label1031";
			this.Label1031.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1031.Text = "特 別";
			this.Label1031.Top = 1.775F;
			this.Label1031.Width = 0.62F;
			// 
			// liveTgtExtHandiNumText
			// 
			this.liveTgtExtHandiNumText.CanGrow = false;
			this.liveTgtExtHandiNumText.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.liveTgtExtHandiNumText.Height = 0.15F;
			this.liveTgtExtHandiNumText.Left = 4.15F;
			this.liveTgtExtHandiNumText.Name = "liveTgtExtHandiNumText";
			this.liveTgtExtHandiNumText.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.liveTgtExtHandiNumText.Text = "Z6";
			this.liveTgtExtHandiNumText.Top = 2.03F;
			this.liveTgtExtHandiNumText.Width = 0.15F;
			// 
			// extHndiNumText
			// 
			this.extHndiNumText.CanGrow = false;
			this.extHndiNumText.DataField = "EXT_HANDI_NUM";
			this.extHndiNumText.Height = 0.15F;
			this.extHndiNumText.Left = 4.46F;
			this.extHndiNumText.Name = "extHndiNumText";
			this.extHndiNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.extHndiNumText.Text = "Z6";
			this.extHndiNumText.Top = 2.03F;
			this.extHndiNumText.Width = 0.15F;
			// 
			// Label1032
			// 
			this.Label1032.Height = 0.15F;
			this.Label1032.HyperLink = null;
			this.Label1032.Left = 4.57F;
			this.Label1032.Name = "Label1032";
			this.Label1032.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1032.Text = "人";
			this.Label1032.Top = 1.9F;
			this.Label1032.Width = 0.1F;
			// 
			// Label1033
			// 
			this.Label1033.Height = 0.15F;
			this.Label1033.HyperLink = null;
			this.Label1033.Left = 4.24F;
			this.Label1033.Name = "Label1033";
			this.Label1033.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1033.Text = "内";
			this.Label1033.Top = 1.9F;
			this.Label1033.Width = 0.125F;
			// 
			// Label1034
			// 
			this.Label1034.Height = 0.11F;
			this.Label1034.HyperLink = null;
			this.Label1034.Left = 4.07F;
			this.Label1034.Name = "Label1034";
			this.Label1034.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1034.Text = "（ 本 人 を 除 く。）";
			this.Label1034.Top = 1.63F;
			this.Label1034.Width = 0.94F;
			// 
			// Label1035
			// 
			this.Label1035.Height = 0.1F;
			this.Label1035.HyperLink = null;
			this.Label1035.Left = 4.71F;
			this.Label1035.Name = "Label1035";
			this.Label1035.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1035.Text = "その他";
			this.Label1035.Top = 1.775F;
			this.Label1035.Width = 0.3F;
			// 
			// Label1036
			// 
			this.Label1036.Height = 0.15F;
			this.Label1036.HyperLink = null;
			this.Label1036.Left = 4.9F;
			this.Label1036.Name = "Label1036";
			this.Label1036.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.Label1036.Text = "人";
			this.Label1036.Top = 1.9F;
			this.Label1036.Width = 0.1F;
			// 
			// HandiNumText
			// 
			this.HandiNumText.CanGrow = false;
			this.HandiNumText.DataField = "HANDI_NUM";
			this.HandiNumText.Height = 0.15F;
			this.HandiNumText.Left = 4.78F;
			this.HandiNumText.Name = "HandiNumText";
			this.HandiNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HandiNumText.Text = "Z6";
			this.HandiNumText.Top = 2.03F;
			this.HandiNumText.Width = 0.15F;
			// 
			// Label1037
			// 
			this.Label1037.Height = 0.15F;
			this.Label1037.HyperLink = null;
			this.Label1037.Left = 0.2F;
			this.Label1037.Name = "Label1037";
			this.Label1037.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1037.Text = "社会保険料等の金額";
			this.Label1037.Top = 2.22F;
			this.Label1037.Width = 1.27F;
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
			this.smlScaleCompCpratAmtText.Top = 2.39F;
			this.smlScaleCompCpratAmtText.Width = 1F;
			// 
			// Label1039
			// 
			this.Label1039.Height = 0.15F;
			this.Label1039.HyperLink = null;
			this.Label1039.Left = 1.49F;
			this.Label1039.Name = "Label1039";
			this.Label1039.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1039.Text = "生命保険料の控除額";
			this.Label1039.Top = 2.22F;
			this.Label1039.Width = 1.27F;
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
			this.lifeInsDedAmtText.Top = 2.522F;
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
			this.TextBox454.Top = 2.522F;
			this.TextBox454.Width = 1F;
			// 
			// sponSumIncmAmtText
			// 
			this.sponSumIncmAmtText.CanGrow = false;
			this.sponSumIncmAmtText.DataField = "SPOS_SUM_INCM_AMT";
			this.sponSumIncmAmtText.Height = 0.153F;
			this.sponSumIncmAmtText.Left = 2.92F;
			this.sponSumIncmAmtText.Name = "sponSumIncmAmtText";
			this.sponSumIncmAmtText.OutputFormat = "#,##0";
			this.sponSumIncmAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.sponSumIncmAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.sponSumIncmAmtText.Top = 4.229F;
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
			this.LifeInsPensAmtText.Top = 3.468F;
			this.LifeInsPensAmtText.Width = 0.45F;
			// 
			// nolfInsLongProdAmtText
			// 
			this.nolfInsLongProdAmtText.CanGrow = false;
			this.nolfInsLongProdAmtText.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.nolfInsLongProdAmtText.Height = 0.153F;
			this.nolfInsLongProdAmtText.Left = 4.920079F;
			this.nolfInsLongProdAmtText.Name = "nolfInsLongProdAmtText";
			this.nolfInsLongProdAmtText.OutputFormat = "#,##0";
			this.nolfInsLongProdAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.nolfInsLongProdAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.nolfInsLongProdAmtText.Top = 4.149212F;
			this.nolfInsLongProdAmtText.Width = 0.45F;
			// 
			// Label1051
			// 
			this.Label1051.Height = 0.165F;
			this.Label1051.HyperLink = null;
			this.Label1051.Left = 0.905F;
			this.Label1051.Name = "Label1051";
			this.Label1051.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.Label1051.Text = "乙";
			this.Label1051.Top = 6.25F;
			this.Label1051.Width = 0.235F;
			// 
			// Label1052
			// 
			this.Label1052.Height = 0.165F;
			this.Label1052.HyperLink = null;
			this.Label1052.Left = 0.905F;
			this.Label1052.Name = "Label1052";
			this.Label1052.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1052.Text = "欄";
			this.Label1052.Top = 6.44F;
			this.Label1052.Width = 0.235F;
			// 
			// Label1053
			// 
			this.Label1053.Height = 0.09F;
			this.Label1053.HyperLink = null;
			this.Label1053.Left = 1.14F;
			this.Label1053.Name = "Label1053";
			this.Label1053.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1053.Text = "本人が障害者";
			this.Label1053.Top = 6.21F;
			this.Label1053.Width = 0.47F;
			// 
			// Label1054
			// 
			this.Label1054.Height = 0.21F;
			this.Label1054.HyperLink = null;
			this.Label1054.Left = 1.2F;
			this.Label1054.Name = "Label1054";
			this.Label1054.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1054.Text = "特別";
			this.Label1054.Top = 6.37F;
			this.Label1054.Width = 0.1249999F;
			// 
			// Label1065
			// 
			this.Label1065.Height = 0.4401575F;
			this.Label1065.HyperLink = null;
			this.Label1065.Left = 1.9F;
			this.Label1065.Name = "Label1065";
			this.Label1065.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1065.Text = "ひとり親";
			this.Label1065.Top = 6.209843F;
			this.Label1065.Width = 0.1251968F;
			// 
			// Label1067
			// 
			this.Label1067.Height = 0.4401575F;
			this.Label1067.HyperLink = null;
			this.Label1067.Left = 2.137008F;
			this.Label1067.Name = "Label1067";
			this.Label1067.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1067.Text = "勤労学生";
			this.Label1067.Top = 6.209843F;
			this.Label1067.Width = 0.1251968F;
			// 
			// Label1069
			// 
			this.Label1069.Height = 0.22F;
			this.Label1069.HyperLink = null;
			this.Label1069.Left = 2.55F;
			this.Label1069.Name = "Label1069";
			this.Label1069.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1069.Text = "就職";
			this.Label1069.Top = 6.43F;
			this.Label1069.Width = 0.235F;
			// 
			// Label1070
			// 
			this.Label1070.Height = 0.22F;
			this.Label1070.HyperLink = null;
			this.Label1070.Left = 3.255F;
			this.Label1070.Name = "Label1070";
			this.Label1070.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1070.Text = "月";
			this.Label1070.Top = 6.43F;
			this.Label1070.Width = 0.235F;
			// 
			// Label1071
			// 
			this.Label1071.Height = 0.22F;
			this.Label1071.HyperLink = null;
			this.Label1071.Left = 3.02F;
			this.Label1071.Name = "Label1071";
			this.Label1071.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1071.Text = "年";
			this.Label1071.Top = 6.43F;
			this.Label1071.Width = 0.235F;
			// 
			// Label1072
			// 
			this.Label1072.Height = 0.22F;
			this.Label1072.HyperLink = null;
			this.Label1072.Left = 3.49F;
			this.Label1072.Name = "Label1072";
			this.Label1072.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1072.Text = "日";
			this.Label1072.Top = 6.43F;
			this.Label1072.Width = 0.235F;
			// 
			// Label1073
			// 
			this.Label1073.Height = 0.22F;
			this.Label1073.HyperLink = null;
			this.Label1073.Left = 3.725F;
			this.Label1073.Name = "Label1073";
			this.Label1073.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1073.Text = "受 給 者 生 年 月 日";
			this.Label1073.Top = 6.21F;
			this.Label1073.Width = 1.655F;
			// 
			// Label1074
			// 
			this.Label1074.Height = 0.2200788F;
			this.Label1074.HyperLink = null;
			this.Label1074.Left = 3.724803F;
			this.Label1074.Name = "Label1074";
			this.Label1074.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1074.Text = "元号";
			this.Label1074.Top = 6.429922F;
			this.Label1074.Width = 0.9401575F;
			// 
			// Label1075
			// 
			this.Label1075.Height = 0.22F;
			this.Label1075.HyperLink = null;
			this.Label1075.Left = 4.665F;
			this.Label1075.Name = "Label1075";
			this.Label1075.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1075.Text = "年";
			this.Label1075.Top = 6.43F;
			this.Label1075.Width = 0.235F;
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
			this.empNameText.Top = 0.8200001F;
			this.empNameText.Width = 1.619F;
			// 
			// Label1076
			// 
			this.Label1076.Height = 0.22F;
			this.Label1076.HyperLink = null;
			this.Label1076.Left = 2.55F;
			this.Label1076.Name = "Label1076";
			this.Label1076.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1076.Text = "中 途 就 ・ 退 職";
			this.Label1076.Top = 6.21F;
			this.Label1076.Width = 1.175F;
			// 
			// minrTypeText
			// 
			this.minrTypeText.CanGrow = false;
			this.minrTypeText.DataField = "MINR_TYPE";
			this.minrTypeText.Height = 0.25F;
			this.minrTypeText.Left = 0.19F;
			this.minrTypeText.Name = "minrTypeText";
			this.minrTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.minrTypeText.Text = "0";
			this.minrTypeText.Top = 6.65F;
			this.minrTypeText.Width = 0.235F;
			// 
			// latterText
			// 
			this.latterText.CanGrow = false;
			this.latterText.DataField = "LATTER";
			this.latterText.Height = 0.25F;
			this.latterText.Left = 0.905F;
			this.latterText.Name = "latterText";
			this.latterText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.latterText.Text = "0";
			this.latterText.Top = 6.65F;
			this.latterText.Width = 0.235F;
			// 
			// extHandiTypeText
			// 
			this.extHandiTypeText.CanGrow = false;
			this.extHandiTypeText.DataField = "EXT_HANDI_TYPE";
			this.extHandiTypeText.Height = 0.25F;
			this.extHandiTypeText.Left = 1.14F;
			this.extHandiTypeText.Name = "extHandiTypeText";
			this.extHandiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extHandiTypeText.Text = "0";
			this.extHandiTypeText.Top = 6.65F;
			this.extHandiTypeText.Width = 0.235F;
			// 
			// handiTypeText
			// 
			this.handiTypeText.CanGrow = false;
			this.handiTypeText.DataField = "HANDI_TYPE";
			this.handiTypeText.Height = 0.25F;
			this.handiTypeText.Left = 1.375F;
			this.handiTypeText.Name = "handiTypeText";
			this.handiTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.handiTypeText.Text = "0";
			this.handiTypeText.Top = 6.65F;
			this.handiTypeText.Width = 0.235F;
			// 
			// widowTypeText
			// 
			this.widowTypeText.CanGrow = false;
			this.widowTypeText.DataField = "WIDOW_TYPE";
			this.widowTypeText.Height = 0.25F;
			this.widowTypeText.Left = 1.61F;
			this.widowTypeText.Name = "widowTypeText";
			this.widowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widowTypeText.Text = "0";
			this.widowTypeText.Top = 6.65F;
			this.widowTypeText.Width = 0.235F;
			// 
			// extWidowTypeText
			// 
			this.extWidowTypeText.CanGrow = false;
			this.extWidowTypeText.DataField = "EXT_WIDOW_TYPE";
			this.extWidowTypeText.Height = 0.25F;
			this.extWidowTypeText.Left = 1.845F;
			this.extWidowTypeText.Name = "extWidowTypeText";
			this.extWidowTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.extWidowTypeText.Text = "0";
			this.extWidowTypeText.Top = 6.65F;
			this.extWidowTypeText.Width = 0.235F;
			// 
			// widomTypeText
			// 
			this.widomTypeText.CanGrow = false;
			this.widomTypeText.DataField = "WIDOM_TYPE";
			this.widomTypeText.Height = 0.25F;
			this.widomTypeText.Left = 2.08F;
			this.widomTypeText.Name = "widomTypeText";
			this.widomTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.widomTypeText.Text = "0";
			this.widomTypeText.Top = 6.65F;
			this.widomTypeText.Width = 0.235F;
			// 
			// wrkStdTypeText
			// 
			this.wrkStdTypeText.CanGrow = false;
			this.wrkStdTypeText.DataField = "WRK_STD_TYPE";
			this.wrkStdTypeText.Height = 0.25F;
			this.wrkStdTypeText.Left = 2.315F;
			this.wrkStdTypeText.Name = "wrkStdTypeText";
			this.wrkStdTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.wrkStdTypeText.Text = "0";
			this.wrkStdTypeText.Top = 6.65F;
			this.wrkStdTypeText.Width = 0.235F;
			// 
			// Label1077
			// 
			this.Label1077.Height = 0.166F;
			this.Label1077.HyperLink = null;
			this.Label1077.Left = 0.19F;
			this.Label1077.Name = "Label1077";
			this.Label1077.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1077.Text = "支";
			this.Label1077.Top = 7F;
			this.Label1077.Width = 0.235F;
			// 
			// Label1078
			// 
			this.Label1078.Height = 0.166F;
			this.Label1078.HyperLink = null;
			this.Label1078.Left = 0.19F;
			this.Label1078.Name = "Label1078";
			this.Label1078.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1078.Text = "払";
			this.Label1078.Top = 7.2F;
			this.Label1078.Width = 0.235F;
			// 
			// Label1079
			// 
			this.Label1079.Height = 0.166F;
			this.Label1079.HyperLink = null;
			this.Label1079.Left = 0.19F;
			this.Label1079.Name = "Label1079";
			this.Label1079.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1079.Text = "者";
			this.Label1079.Top = 7.4F;
			this.Label1079.Width = 0.235F;
			// 
			// paymntAddressText
			// 
			this.paymntAddressText.CanGrow = false;
			this.paymntAddressText.DataField = "PAYMNT_ADDRESS";
			this.paymntAddressText.Height = 0.332F;
			this.paymntAddressText.Left = 0.905F;
			this.paymntAddressText.Name = "paymntAddressText";
			this.paymntAddressText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntAddressText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntAddressText.Top = 7.1F;
			this.paymntAddressText.Width = 4.312F;
			// 
			// paymntNameText
			// 
			this.paymntNameText.CanGrow = false;
			this.paymntNameText.DataField = "PAYMNT_NAME";
			this.paymntNameText.Height = 0.2F;
			this.paymntNameText.Left = 0.905F;
			this.paymntNameText.MultiLine = false;
			this.paymntNameText.Name = "paymntNameText";
			this.paymntNameText.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.paymntNameText.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.paymntNameText.Top = 7.4F;
			this.paymntNameText.Width = 3.125F;
			// 
			// Label1080
			// 
			this.Label1080.Height = 0.2F;
			this.Label1080.HyperLink = null;
			this.Label1080.Left = 4.05F;
			this.Label1080.Name = "Label1080";
			this.Label1080.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1080.Text = "（電話）";
			this.Label1080.Top = 7.4F;
			this.Label1080.Width = 0.375F;
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
			this.paymntPhoneText.Top = 7.4F;
			this.paymntPhoneText.Width = 0.813F;
			// 
			// Label1081
			// 
			this.Label1081.Height = 0.15F;
			this.Label1081.HyperLink = null;
			this.Label1081.Left = 0.425F;
			this.Label1081.Name = "Label1081";
			this.Label1081.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1081.Text = "住所（居所）";
			this.Label1081.Top = 7.1F;
			this.Label1081.Width = 0.51F;
			// 
			// Label1082
			// 
			this.Label1082.Height = 0.15F;
			this.Label1082.HyperLink = null;
			this.Label1082.Left = 0.425F;
			this.Label1082.Name = "Label1082";
			this.Label1082.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1082.Text = "又は所在地";
			this.Label1082.Top = 7.25F;
			this.Label1082.Width = 0.48F;
			// 
			// Label1084
			// 
			this.Label1084.Height = 0.1999998F;
			this.Label1084.HyperLink = null;
			this.Label1084.Left = 0.425F;
			this.Label1084.Name = "Label1084";
			this.Label1084.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1084.Text = "氏名又は名称";
			this.Label1084.Top = 7.4F;
			this.Label1084.Width = 0.48F;
			// 
			// Label1085
			// 
			this.Label1085.Height = 0.2F;
			this.Label1085.HyperLink = null;
			this.Label1085.Left = 0.188F;
			this.Label1085.Name = "Label1085";
			this.Label1085.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1085.Text = "を受け";
			this.Label1085.Top = 0.518F;
			this.Label1085.Width = 0.292F;
			// 
			// Label1086
			// 
			this.Label1086.Height = 0.2F;
			this.Label1086.HyperLink = null;
			this.Label1086.Left = 0.188F;
			this.Label1086.Name = "Label1086";
			this.Label1086.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1086.Text = "る　者";
			this.Label1086.Top = 0.718F;
			this.Label1086.Width = 0.292F;
			// 
			// Label1087
			// 
			this.Label1087.Height = 0.33F;
			this.Label1087.HyperLink = null;
			this.Label1087.Left = 3.027F;
			this.Label1087.Name = "Label1087";
			this.Label1087.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1087.Text = "氏名";
			this.Label1087.Top = 0.7F;
			this.Label1087.Width = 0.17F;
			// 
			// Label1088
			// 
			this.Label1088.Height = 0.157F;
			this.Label1088.HyperLink = null;
			this.Label1088.Left = 0.2F;
			this.Label1088.Name = "Label1088";
			this.Label1088.Style = "font-size: 4.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1088.Text = "の 有 無 等";
			this.Label1088.Top = 1.663F;
			this.Label1088.Width = 0.479F;
			// 
			// Label1089
			// 
			this.Label1089.Height = 0.157F;
			this.Label1089.HyperLink = null;
			this.Label1089.Left = 0.905F;
			this.Label1089.Name = "Label1089";
			this.Label1089.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1089.Text = "控  除  の  額";
			this.Label1089.Top = 1.708F;
			this.Label1089.Width = 0.85F;
			// 
			// Label1093
			// 
			this.Label1093.Height = 0.15F;
			this.Label1093.HyperLink = null;
			this.Label1093.Left = 2.78F;
			this.Label1093.Name = "Label1093";
			this.Label1093.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.Label1093.Text = "地震保険料の控除額";
			this.Label1093.Top = 2.22F;
			this.Label1093.Width = 1.27F;
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
			this.nolfInsDedAmtText.Top = 2.522F;
			this.nolfInsDedAmtText.Width = 1F;
			// 
			// deathRetireTypeText
			// 
			this.deathRetireTypeText.CanGrow = false;
			this.deathRetireTypeText.DataField = "DEATH_RETIRE_TYPE";
			this.deathRetireTypeText.Height = 0.25F;
			this.deathRetireTypeText.Left = 0.585F;
			this.deathRetireTypeText.Name = "deathRetireTypeText";
			this.deathRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.deathRetireTypeText.Text = "0";
			this.deathRetireTypeText.Top = 6.65F;
			this.deathRetireTypeText.Width = 0.16F;
			// 
			// disasterTypeText
			// 
			this.disasterTypeText.CanGrow = false;
			this.disasterTypeText.DataField = "DISASTER_TYPE";
			this.disasterTypeText.Height = 0.25F;
			this.disasterTypeText.Left = 0.745F;
			this.disasterTypeText.Name = "disasterTypeText";
			this.disasterTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.disasterTypeText.Text = "0";
			this.disasterTypeText.Top = 6.65F;
			this.disasterTypeText.Width = 0.16F;
			// 
			// Label1113
			// 
			this.Label1113.Height = 0.29F;
			this.Label1113.HyperLink = null;
			this.Label1113.Left = 0.745F;
			this.Label1113.Name = "Label1113";
			this.Label1113.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1113.Text = "災害者";
			this.Label1113.Top = 6.27F;
			this.Label1113.Width = 0.135F;
			// 
			// foreignTypeText
			// 
			this.foreignTypeText.CanGrow = false;
			this.foreignTypeText.DataField = "FOREIGN_TYPE";
			this.foreignTypeText.Height = 0.25F;
			this.foreignTypeText.Left = 0.425F;
			this.foreignTypeText.Name = "foreignTypeText";
			this.foreignTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.foreignTypeText.Text = "0";
			this.foreignTypeText.Top = 6.65F;
			this.foreignTypeText.Width = 0.16F;
			// 
			// Label1116
			// 
			this.Label1116.Height = 0.29F;
			this.Label1116.HyperLink = null;
			this.Label1116.Left = 0.43F;
			this.Label1116.Name = "Label1116";
			this.Label1116.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.Label1116.Text = "外国人";
			this.Label1116.Top = 6.27F;
			this.Label1116.Width = 0.135F;
			// 
			// halfEmployTypeText
			// 
			this.halfEmployTypeText.CanGrow = false;
			this.halfEmployTypeText.DataField = "HALF_EMPLOY_TYPE";
			this.halfEmployTypeText.Height = 0.25F;
			this.halfEmployTypeText.Left = 2.55F;
			this.halfEmployTypeText.Name = "halfEmployTypeText";
			this.halfEmployTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmployTypeText.Text = "0";
			this.halfEmployTypeText.Top = 6.65F;
			this.halfEmployTypeText.Width = 0.235F;
			// 
			// Label1117
			// 
			this.Label1117.Height = 0.22F;
			this.Label1117.HyperLink = null;
			this.Label1117.Left = 2.785F;
			this.Label1117.Name = "Label1117";
			this.Label1117.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1117.Text = "退職";
			this.Label1117.Top = 6.43F;
			this.Label1117.Width = 0.235F;
			// 
			// halfRetireTypeText
			// 
			this.halfRetireTypeText.CanGrow = false;
			this.halfRetireTypeText.DataField = "HALF_RETIRE_TYPE";
			this.halfRetireTypeText.Height = 0.25F;
			this.halfRetireTypeText.Left = 2.785F;
			this.halfRetireTypeText.Name = "halfRetireTypeText";
			this.halfRetireTypeText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfRetireTypeText.Text = "0";
			this.halfRetireTypeText.Top = 6.65F;
			this.halfRetireTypeText.Width = 0.235F;
			// 
			// halfEmReDateYearText
			// 
			this.halfEmReDateYearText.CanGrow = false;
			this.halfEmReDateYearText.DataField = "HALF_EM_RE_DATE_YEAR";
			this.halfEmReDateYearText.Height = 0.25F;
			this.halfEmReDateYearText.Left = 3.02F;
			this.halfEmReDateYearText.Name = "halfEmReDateYearText";
			this.halfEmReDateYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateYearText.Text = "0";
			this.halfEmReDateYearText.Top = 6.65F;
			this.halfEmReDateYearText.Width = 0.235F;
			// 
			// halfEmReFateMonthText
			// 
			this.halfEmReFateMonthText.CanGrow = false;
			this.halfEmReFateMonthText.DataField = "HALF_EM_RE_DATE_MONTH";
			this.halfEmReFateMonthText.Height = 0.25F;
			this.halfEmReFateMonthText.Left = 3.255F;
			this.halfEmReFateMonthText.Name = "halfEmReFateMonthText";
			this.halfEmReFateMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReFateMonthText.Text = "0";
			this.halfEmReFateMonthText.Top = 6.65F;
			this.halfEmReFateMonthText.Width = 0.235F;
			// 
			// halfEmReDateDayText
			// 
			this.halfEmReDateDayText.CanGrow = false;
			this.halfEmReDateDayText.DataField = "HALF_EM_RE_DATE_DAY";
			this.halfEmReDateDayText.Height = 0.25F;
			this.halfEmReDateDayText.Left = 3.49F;
			this.halfEmReDateDayText.Name = "halfEmReDateDayText";
			this.halfEmReDateDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.halfEmReDateDayText.Text = "0";
			this.halfEmReDateDayText.Top = 6.65F;
			this.halfEmReDateDayText.Width = 0.235F;
			// 
			// Label1121
			// 
			this.Label1121.Height = 0.22F;
			this.Label1121.HyperLink = null;
			this.Label1121.Left = 4.9F;
			this.Label1121.Name = "Label1121";
			this.Label1121.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1121.Text = "月";
			this.Label1121.Top = 6.43F;
			this.Label1121.Width = 0.235F;
			// 
			// Label1122
			// 
			this.Label1122.Height = 0.22F;
			this.Label1122.HyperLink = null;
			this.Label1122.Left = 5.135F;
			this.Label1122.Name = "Label1122";
			this.Label1122.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.Label1122.Text = "日";
			this.Label1122.Top = 6.43F;
			this.Label1122.Width = 0.235F;
			// 
			// birthDayYearText
			// 
			this.birthDayYearText.CanGrow = false;
			this.birthDayYearText.DataField = "BIRTH_DAY_YEAR";
			this.birthDayYearText.Height = 0.25F;
			this.birthDayYearText.Left = 4.665F;
			this.birthDayYearText.Name = "birthDayYearText";
			this.birthDayYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayYearText.Text = "0";
			this.birthDayYearText.Top = 6.65F;
			this.birthDayYearText.Width = 0.235F;
			// 
			// birthDayMonthText
			// 
			this.birthDayMonthText.CanGrow = false;
			this.birthDayMonthText.DataField = "BIRTH_DAY_MONTH";
			this.birthDayMonthText.Height = 0.25F;
			this.birthDayMonthText.Left = 4.9F;
			this.birthDayMonthText.Name = "birthDayMonthText";
			this.birthDayMonthText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayMonthText.Text = "0";
			this.birthDayMonthText.Top = 6.65F;
			this.birthDayMonthText.Width = 0.235F;
			// 
			// birthDayDayText
			// 
			this.birthDayDayText.CanGrow = false;
			this.birthDayDayText.DataField = "BIRTH_DAY_DAY";
			this.birthDayDayText.Height = 0.25F;
			this.birthDayDayText.Left = 5.135F;
			this.birthDayDayText.Name = "birthDayDayText";
			this.birthDayDayText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthDayDayText.Text = "0";
			this.birthDayDayText.Top = 6.65F;
			this.birthDayDayText.Width = 0.235F;
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
			this.socInsDedAmtText.Top = 2.522F;
			this.socInsDedAmtText.Width = 1F;
			// 
			// Label1123
			// 
			this.Label1123.Height = 0.44F;
			this.Label1123.HyperLink = null;
			this.Label1123.Left = 0.25F;
			this.Label1123.Name = "Label1123";
			this.Label1123.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.Label1123.Text = "未成年者";
			this.Label1123.Top = 6.21F;
			this.Label1123.Width = 0.125F;
			// 
			// Line323
			// 
			this.Line323.Height = 0F;
			this.Line323.Left = 0.1880815F;
			this.Line323.LineWeight = 1F;
			this.Line323.Name = "Line323";
			this.Line323.Top = 7.6F;
			this.Line323.Width = 5.191918F;
			this.Line323.X1 = 0.1880815F;
			this.Line323.X2 = 5.38F;
			this.Line323.Y1 = 7.6F;
			this.Line323.Y2 = 7.6F;
			// 
			// Line325
			// 
			this.Line325.Height = 0F;
			this.Line325.Left = 0.19F;
			this.Line325.LineWeight = 1F;
			this.Line325.Name = "Line325";
			this.Line325.Top = 1.04F;
			this.Line325.Width = 5.19F;
			this.Line325.X1 = 0.19F;
			this.Line325.X2 = 5.38F;
			this.Line325.Y1 = 1.04F;
			this.Line325.Y2 = 1.04F;
			// 
			// Line327
			// 
			this.Line327.Height = 0F;
			this.Line327.Left = 1.765F;
			this.Line327.LineWeight = 1F;
			this.Line327.Name = "Line327";
			this.Line327.Top = 1.76F;
			this.Line327.Width = 1.9F;
			this.Line327.X1 = 1.765F;
			this.Line327.X2 = 3.665F;
			this.Line327.Y1 = 1.76F;
			this.Line327.Y2 = 1.76F;
			// 
			// Line328
			// 
			this.Line328.Height = 0F;
			this.Line328.Left = 0.1880815F;
			this.Line328.LineWeight = 1F;
			this.Line328.Name = "Line328";
			this.Line328.Top = 6.21F;
			this.Line328.Width = 5.187F;
			this.Line328.X1 = 0.1880815F;
			this.Line328.X2 = 5.375082F;
			this.Line328.Y1 = 6.21F;
			this.Line328.Y2 = 6.21F;
			// 
			// Line129
			// 
			this.Line129.Height = 7.590158F;
			this.Line129.Left = 5.379921F;
			this.Line129.LineWeight = 1F;
			this.Line129.Name = "Line129";
			this.Line129.Top = 0.009842521F;
			this.Line129.Width = 7.915497E-05F;
			this.Line129.X1 = 5.379921F;
			this.Line129.X2 = 5.38F;
			this.Line129.Y1 = 0.009842521F;
			this.Line129.Y2 = 7.6F;
			// 
			// Line395
			// 
			this.Line395.Height = 0.8417138F;
			this.Line395.Left = 0.4800815F;
			this.Line395.LineWeight = 1F;
			this.Line395.Name = "Line395";
			this.Line395.Top = 0.1982861F;
			this.Line395.Width = 0F;
			this.Line395.X1 = 0.4800815F;
			this.Line395.X2 = 0.4800815F;
			this.Line395.Y1 = 0.1982861F;
			this.Line395.Y2 = 1.04F;
			// 
			// Line396
			// 
			this.Line396.Height = 0.8417138F;
			this.Line396.Left = 0.6680815F;
			this.Line396.LineWeight = 1F;
			this.Line396.Name = "Line396";
			this.Line396.Top = 0.1982861F;
			this.Line396.Width = 0F;
			this.Line396.X1 = 0.6680815F;
			this.Line396.X2 = 0.6680815F;
			this.Line396.Y1 = 0.1982861F;
			this.Line396.Y2 = 1.04F;
			// 
			// Line397
			// 
			this.Line397.Height = 0.8417138F;
			this.Line397.Left = 3.017081F;
			this.Line397.LineWeight = 1F;
			this.Line397.Name = "Line397";
			this.Line397.Top = 0.1982861F;
			this.Line397.Width = 0F;
			this.Line397.X1 = 3.017081F;
			this.Line397.X2 = 3.017081F;
			this.Line397.Y1 = 0.1982861F;
			this.Line397.Y2 = 1.04F;
			// 
			// Line398
			// 
			this.Line398.Height = 0.35F;
			this.Line398.Left = 3.207082F;
			this.Line398.LineWeight = 1F;
			this.Line398.Name = "Line398";
			this.Line398.Top = 0.69F;
			this.Line398.Width = 0F;
			this.Line398.X1 = 3.207082F;
			this.Line398.X2 = 3.207082F;
			this.Line398.Y1 = 0.69F;
			this.Line398.Y2 = 1.04F;
			// 
			// Line399
			// 
			this.Line399.Height = 0F;
			this.Line399.Left = 3.017F;
			this.Line399.LineWeight = 1F;
			this.Line399.Name = "Line399";
			this.Line399.Top = 0.319685F;
			this.Line399.Width = 2.363F;
			this.Line399.X1 = 3.017F;
			this.Line399.X2 = 5.38F;
			this.Line399.Y1 = 0.319685F;
			this.Line399.Y2 = 0.319685F;
			// 
			// Line400
			// 
			this.Line400.Height = 0F;
			this.Line400.Left = 3.017F;
			this.Line400.LineWeight = 1F;
			this.Line400.Name = "Line400";
			this.Line400.Top = 0.49F;
			this.Line400.Width = 2.363F;
			this.Line400.X1 = 3.017F;
			this.Line400.X2 = 5.38F;
			this.Line400.Y1 = 0.49F;
			this.Line400.Y2 = 0.49F;
			// 
			// Line401
			// 
			this.Line401.Height = 0.47F;
			this.Line401.Left = 1.126082F;
			this.Line401.LineWeight = 1F;
			this.Line401.Name = "Line401";
			this.Line401.Top = 1.04F;
			this.Line401.Width = 0F;
			this.Line401.X1 = 1.126082F;
			this.Line401.X2 = 1.126082F;
			this.Line401.Y1 = 1.04F;
			this.Line401.Y2 = 1.51F;
			// 
			// Line402
			// 
			this.Line402.Height = 0.47F;
			this.Line402.Left = 2.204082F;
			this.Line402.LineWeight = 1F;
			this.Line402.Name = "Line402";
			this.Line402.Top = 1.04F;
			this.Line402.Width = 0F;
			this.Line402.X1 = 2.204082F;
			this.Line402.X2 = 2.204082F;
			this.Line402.Y1 = 1.04F;
			this.Line402.Y2 = 1.51F;
			// 
			// Line403
			// 
			this.Line403.Height = 0.47F;
			this.Line403.Left = 3.267081F;
			this.Line403.LineWeight = 1F;
			this.Line403.Name = "Line403";
			this.Line403.Top = 1.04F;
			this.Line403.Width = 0F;
			this.Line403.X1 = 3.267081F;
			this.Line403.X2 = 3.267081F;
			this.Line403.Y1 = 1.04F;
			this.Line403.Y2 = 1.51F;
			// 
			// Line404
			// 
			this.Line404.Height = 0.47F;
			this.Line404.Left = 4.330081F;
			this.Line404.LineWeight = 1F;
			this.Line404.Name = "Line404";
			this.Line404.Top = 1.04F;
			this.Line404.Width = 0F;
			this.Line404.X1 = 4.330081F;
			this.Line404.X2 = 4.330081F;
			this.Line404.Y1 = 1.04F;
			this.Line404.Y2 = 1.51F;
			// 
			// Line405
			// 
			this.Line405.Height = 0F;
			this.Line405.Left = 0.19F;
			this.Line405.LineWeight = 1F;
			this.Line405.Name = "Line405";
			this.Line405.Top = 1.21F;
			this.Line405.Width = 5.19F;
			this.Line405.X1 = 0.19F;
			this.Line405.X2 = 5.38F;
			this.Line405.Y1 = 1.21F;
			this.Line405.Y2 = 1.21F;
			// 
			// Line408
			// 
			this.Line408.Height = 0.7F;
			this.Line408.Left = 0.895F;
			this.Line408.LineWeight = 1F;
			this.Line408.Name = "Line408";
			this.Line408.Top = 1.51F;
			this.Line408.Width = 0F;
			this.Line408.X1 = 0.895F;
			this.Line408.X2 = 0.895F;
			this.Line408.Y1 = 1.51F;
			this.Line408.Y2 = 2.21F;
			// 
			// Line413
			// 
			this.Line413.Height = 0.35F;
			this.Line413.Left = 2.555F;
			this.Line413.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line413.LineWeight = 1F;
			this.Line413.Name = "Line413";
			this.Line413.Top = 1.86F;
			this.Line413.Width = 0F;
			this.Line413.X1 = 2.555F;
			this.Line413.X2 = 2.555F;
			this.Line413.Y1 = 1.86F;
			this.Line413.Y2 = 2.21F;
			// 
			// Line415
			// 
			this.Line415.Height = 0.35F;
			this.Line415.Left = 2.875F;
			this.Line415.LineWeight = 1F;
			this.Line415.Name = "Line415";
			this.Line415.Top = 1.86F;
			this.Line415.Width = 0F;
			this.Line415.X1 = 2.875F;
			this.Line415.X2 = 2.875F;
			this.Line415.Y1 = 1.86F;
			this.Line415.Y2 = 2.21F;
			// 
			// Line417
			// 
			this.Line417.Height = 0.45F;
			this.Line417.Left = 3.11F;
			this.Line417.LineWeight = 1F;
			this.Line417.Name = "Line417";
			this.Line417.Top = 1.76F;
			this.Line417.Width = 0F;
			this.Line417.X1 = 3.11F;
			this.Line417.X2 = 3.11F;
			this.Line417.Y1 = 1.76F;
			this.Line417.Y2 = 2.21F;
			// 
			// Line418
			// 
			this.Line418.Height = 0.35F;
			this.Line418.Left = 3.43F;
			this.Line418.LineWeight = 1F;
			this.Line418.Name = "Line418";
			this.Line418.Top = 1.86F;
			this.Line418.Width = 0F;
			this.Line418.X1 = 3.43F;
			this.Line418.X2 = 3.43F;
			this.Line418.Y1 = 1.86F;
			this.Line418.Y2 = 2.21F;
			// 
			// Line419
			// 
			this.Line419.Height = 0.7F;
			this.Line419.Left = 3.665F;
			this.Line419.LineWeight = 1F;
			this.Line419.Name = "Line419";
			this.Line419.Top = 1.51F;
			this.Line419.Width = 0F;
			this.Line419.X1 = 3.665F;
			this.Line419.X2 = 3.665F;
			this.Line419.Y1 = 1.51F;
			this.Line419.Y2 = 2.21F;
			// 
			// Line420
			// 
			this.Line420.Height = 0.45F;
			this.Line420.Left = 4.7F;
			this.Line420.LineWeight = 1F;
			this.Line420.Name = "Line420";
			this.Line420.Top = 1.76F;
			this.Line420.Width = 0F;
			this.Line420.X1 = 4.7F;
			this.Line420.X2 = 4.7F;
			this.Line420.Y1 = 1.76F;
			this.Line420.Y2 = 2.21F;
			// 
			// Line421
			// 
			this.Line421.Height = 0.35F;
			this.Line421.Left = 4.38F;
			this.Line421.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.Line421.LineWeight = 1F;
			this.Line421.Name = "Line421";
			this.Line421.Top = 1.86F;
			this.Line421.Width = 0F;
			this.Line421.X1 = 4.38F;
			this.Line421.X2 = 4.38F;
			this.Line421.Y1 = 1.86F;
			this.Line421.Y2 = 2.21F;
			// 
			// Line422
			// 
			this.Line422.Height = 0.7F;
			this.Line422.Left = 5.02F;
			this.Line422.LineWeight = 1F;
			this.Line422.Name = "Line422";
			this.Line422.Top = 1.51F;
			this.Line422.Width = 0F;
			this.Line422.X1 = 5.02F;
			this.Line422.X2 = 5.02F;
			this.Line422.Y1 = 1.51F;
			this.Line422.Y2 = 2.21F;
			// 
			// Line427
			// 
			this.Line427.Height = 0F;
			this.Line427.Left = 0.19F;
			this.Line427.LineWeight = 1F;
			this.Line427.Name = "Line427";
			this.Line427.Top = 1.96F;
			this.Line427.Width = 0.47F;
			this.Line427.X1 = 0.19F;
			this.Line427.X2 = 0.66F;
			this.Line427.Y1 = 1.96F;
			this.Line427.Y2 = 1.96F;
			// 
			// Line431
			// 
			this.Line431.Height = 1.7F;
			this.Line431.Left = 0.37F;
			this.Line431.LineWeight = 1F;
			this.Line431.Name = "Line431";
			this.Line431.Top = 4.51F;
			this.Line431.Width = 0F;
			this.Line431.X1 = 0.37F;
			this.Line431.X2 = 0.37F;
			this.Line431.Y1 = 4.51F;
			this.Line431.Y2 = 6.21F;
			// 
			// Line434
			// 
			this.Line434.Height = 0F;
			this.Line434.Left = 1.14F;
			this.Line434.LineWeight = 1F;
			this.Line434.Name = "Line434";
			this.Line434.Top = 6.3F;
			this.Line434.Width = 0.469843F;
			this.Line434.X1 = 1.14F;
			this.Line434.X2 = 1.609843F;
			this.Line434.Y1 = 6.3F;
			this.Line434.Y2 = 6.3F;
			// 
			// Line436
			// 
			this.Line436.Height = 0.6900001F;
			this.Line436.Left = 1.14F;
			this.Line436.LineWeight = 1F;
			this.Line436.Name = "Line436";
			this.Line436.Top = 6.21F;
			this.Line436.Width = 0F;
			this.Line436.X1 = 1.14F;
			this.Line436.X2 = 1.14F;
			this.Line436.Y1 = 6.21F;
			this.Line436.Y2 = 6.9F;
			// 
			// Line440
			// 
			this.Line440.Height = 0.6900001F;
			this.Line440.Left = 2.315F;
			this.Line440.LineWeight = 1F;
			this.Line440.Name = "Line440";
			this.Line440.Top = 6.21F;
			this.Line440.Width = 0F;
			this.Line440.X1 = 2.315F;
			this.Line440.X2 = 2.315F;
			this.Line440.Y1 = 6.21F;
			this.Line440.Y2 = 6.9F;
			// 
			// Line441
			// 
			this.Line441.Height = 0.6900001F;
			this.Line441.Left = 2.55F;
			this.Line441.LineWeight = 1F;
			this.Line441.Name = "Line441";
			this.Line441.Top = 6.21F;
			this.Line441.Width = 0F;
			this.Line441.X1 = 2.55F;
			this.Line441.X2 = 2.55F;
			this.Line441.Y1 = 6.21F;
			this.Line441.Y2 = 6.9F;
			// 
			// Line442
			// 
			this.Line442.Height = 0.4700003F;
			this.Line442.Left = 2.785F;
			this.Line442.LineWeight = 1F;
			this.Line442.Name = "Line442";
			this.Line442.Top = 6.43F;
			this.Line442.Width = 0F;
			this.Line442.X1 = 2.785F;
			this.Line442.X2 = 2.785F;
			this.Line442.Y1 = 6.43F;
			this.Line442.Y2 = 6.9F;
			// 
			// Line443
			// 
			this.Line443.Height = 0F;
			this.Line443.Left = 2.55F;
			this.Line443.LineWeight = 1F;
			this.Line443.Name = "Line443";
			this.Line443.Top = 6.43F;
			this.Line443.Width = 2.83F;
			this.Line443.X1 = 2.55F;
			this.Line443.X2 = 5.38F;
			this.Line443.Y1 = 6.43F;
			this.Line443.Y2 = 6.43F;
			// 
			// Line444
			// 
			this.Line444.Height = 0.4700003F;
			this.Line444.Left = 3.02F;
			this.Line444.LineWeight = 1F;
			this.Line444.Name = "Line444";
			this.Line444.Top = 6.43F;
			this.Line444.Width = 0F;
			this.Line444.X1 = 3.02F;
			this.Line444.X2 = 3.02F;
			this.Line444.Y1 = 6.43F;
			this.Line444.Y2 = 6.9F;
			// 
			// Line445
			// 
			this.Line445.Height = 0.4700003F;
			this.Line445.Left = 3.255F;
			this.Line445.LineWeight = 1F;
			this.Line445.Name = "Line445";
			this.Line445.Top = 6.43F;
			this.Line445.Width = 0F;
			this.Line445.X1 = 3.255F;
			this.Line445.X2 = 3.255F;
			this.Line445.Y1 = 6.43F;
			this.Line445.Y2 = 6.9F;
			// 
			// Line446
			// 
			this.Line446.Height = 0.4700003F;
			this.Line446.Left = 3.49F;
			this.Line446.LineWeight = 1F;
			this.Line446.Name = "Line446";
			this.Line446.Top = 6.43F;
			this.Line446.Width = 0F;
			this.Line446.X1 = 3.49F;
			this.Line446.X2 = 3.49F;
			this.Line446.Y1 = 6.43F;
			this.Line446.Y2 = 6.9F;
			// 
			// Line447
			// 
			this.Line447.Height = 0.6900001F;
			this.Line447.Left = 3.725F;
			this.Line447.LineWeight = 1F;
			this.Line447.Name = "Line447";
			this.Line447.Top = 6.21F;
			this.Line447.Width = 0F;
			this.Line447.X1 = 3.725F;
			this.Line447.X2 = 3.725F;
			this.Line447.Y1 = 6.21F;
			this.Line447.Y2 = 6.9F;
			// 
			// Line450
			// 
			this.Line450.Height = 0.4700003F;
			this.Line450.Left = 4.665F;
			this.Line450.LineWeight = 1F;
			this.Line450.Name = "Line450";
			this.Line450.Top = 6.43F;
			this.Line450.Width = 0F;
			this.Line450.X1 = 4.665F;
			this.Line450.X2 = 4.665F;
			this.Line450.Y1 = 6.43F;
			this.Line450.Y2 = 6.9F;
			// 
			// Line451
			// 
			this.Line451.Height = 0.4700003F;
			this.Line451.Left = 4.9F;
			this.Line451.LineWeight = 1F;
			this.Line451.Name = "Line451";
			this.Line451.Top = 6.43F;
			this.Line451.Width = 0F;
			this.Line451.X1 = 4.9F;
			this.Line451.X2 = 4.9F;
			this.Line451.Y1 = 6.43F;
			this.Line451.Y2 = 6.9F;
			// 
			// Line452
			// 
			this.Line452.Height = 0.4700003F;
			this.Line452.Left = 5.135F;
			this.Line452.LineWeight = 1F;
			this.Line452.Name = "Line452";
			this.Line452.Top = 6.43F;
			this.Line452.Width = 0F;
			this.Line452.X1 = 5.135F;
			this.Line452.X2 = 5.135F;
			this.Line452.Y1 = 6.43F;
			this.Line452.Y2 = 6.9F;
			// 
			// Line455
			// 
			this.Line455.Height = 0F;
			this.Line455.Left = 0.44F;
			this.Line455.LineWeight = 1F;
			this.Line455.Name = "Line455";
			this.Line455.Top = 7.4F;
			this.Line455.Width = 4.94F;
			this.Line455.X1 = 0.44F;
			this.Line455.X2 = 5.38F;
			this.Line455.Y1 = 7.4F;
			this.Line455.Y2 = 7.4F;
			// 
			// Line615
			// 
			this.Line615.Height = 0.7F;
			this.Line615.Left = 1.765F;
			this.Line615.LineWeight = 1F;
			this.Line615.Name = "Line615";
			this.Line615.Top = 1.51F;
			this.Line615.Width = 0F;
			this.Line615.X1 = 1.765F;
			this.Line615.X2 = 1.765F;
			this.Line615.Y1 = 1.51F;
			this.Line615.Y2 = 2.21F;
			// 
			// Label1595
			// 
			this.Label1595.Height = 0.125F;
			this.Label1595.HyperLink = null;
			this.Label1595.Left = 0.2F;
			this.Label1595.Name = "Label1595";
			this.Label1595.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.Label1595.Text = "内";
			this.Label1595.Top = 2.39F;
			this.Label1595.Width = 0.125F;
			// 
			// Line752
			// 
			this.Line752.Height = 0F;
			this.Line752.Left = 0.19F;
			this.Line752.LineWeight = 1F;
			this.Line752.Name = "Line752";
			this.Line752.Top = 1.86F;
			this.Line752.Width = 5.19F;
			this.Line752.X1 = 0.19F;
			this.Line752.X2 = 5.38F;
			this.Line752.Y1 = 1.86F;
			this.Line752.Y2 = 1.86F;
			// 
			// summary0Digit0Text
			// 
			this.summary0Digit0Text.CanGrow = false;
			this.summary0Digit0Text.DataField = "SUMMARY_0_DIGIT";
			this.summary0Digit0Text.Height = 0.125F;
			this.summary0Digit0Text.Left = 0.2F;
			this.summary0Digit0Text.MultiLine = false;
			this.summary0Digit0Text.Name = "summary0Digit0Text";
			this.summary0Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary0Digit0Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.summary0Digit0Text.Top = 2.69F;
			this.summary0Digit0Text.Width = 5.063001F;
			// 
			// line1
			// 
			this.line1.Height = 0.6900001F;
			this.line1.Left = 1.61F;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.Top = 6.21F;
			this.line1.Width = 0F;
			this.line1.X1 = 1.61F;
			this.line1.X2 = 1.61F;
			this.line1.Y1 = 6.21F;
			this.line1.Y2 = 6.9F;
			// 
			// line2
			// 
			this.line2.Height = 0.5999999F;
			this.line2.Left = 1.375F;
			this.line2.LineWeight = 1F;
			this.line2.Name = "line2";
			this.line2.Top = 6.3F;
			this.line2.Width = 0F;
			this.line2.X1 = 1.375F;
			this.line2.X2 = 1.375F;
			this.line2.Y1 = 6.3F;
			this.line2.Y2 = 6.9F;
			// 
			// line3
			// 
			this.line3.Height = 0.6900001F;
			this.line3.Left = 0.905F;
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.Top = 6.21F;
			this.line3.Width = 0F;
			this.line3.X1 = 0.905F;
			this.line3.X2 = 0.905F;
			this.line3.Y1 = 6.21F;
			this.line3.Y2 = 6.9F;
			// 
			// Line433
			// 
			this.Line433.Height = 2.139843F;
			this.Line433.Left = 0.7448819F;
			this.Line433.LineWeight = 1F;
			this.Line433.Name = "Line433";
			this.Line433.Top = 4.07F;
			this.Line433.Width = 0.0001180768F;
			this.Line433.X1 = 0.745F;
			this.Line433.X2 = 0.7448819F;
			this.Line433.Y1 = 4.07F;
			this.Line433.Y2 = 6.209843F;
			// 
			// Line438
			// 
			this.Line438.Height = 0.6901569F;
			this.Line438.Left = 1.845F;
			this.Line438.LineWeight = 1F;
			this.Line438.Name = "Line438";
			this.Line438.Top = 6.209843F;
			this.Line438.Width = 0F;
			this.Line438.X1 = 1.845F;
			this.Line438.X2 = 1.845F;
			this.Line438.Y1 = 6.209843F;
			this.Line438.Y2 = 6.9F;
			// 
			// Line439
			// 
			this.Line439.Height = 0.6900001F;
			this.Line439.Left = 2.08F;
			this.Line439.LineWeight = 1F;
			this.Line439.Name = "Line439";
			this.Line439.Top = 6.21F;
			this.Line439.Width = 0F;
			this.Line439.X1 = 2.08F;
			this.Line439.X2 = 2.08F;
			this.Line439.Y1 = 6.21F;
			this.Line439.Y2 = 6.9F;
			// 
			// Line329
			// 
			this.Line329.Height = 0F;
			this.Line329.Left = 0.188F;
			this.Line329.LineWeight = 1F;
			this.Line329.Name = "Line329";
			this.Line329.Top = 6.65F;
			this.Line329.Width = 5.187F;
			this.Line329.X1 = 0.188F;
			this.Line329.X2 = 5.375F;
			this.Line329.Y1 = 6.65F;
			this.Line329.Y2 = 6.65F;
			// 
			// Line330
			// 
			this.Line330.Height = 0F;
			this.Line330.Left = 0.188F;
			this.Line330.LineWeight = 1F;
			this.Line330.Name = "Line330";
			this.Line330.Top = 6.9F;
			this.Line330.Width = 5.192F;
			this.Line330.X1 = 0.188F;
			this.Line330.X2 = 5.38F;
			this.Line330.Y1 = 6.9F;
			this.Line330.Y2 = 6.9F;
			// 
			// label4
			// 
			this.label4.Height = 0.153F;
			this.label4.HyperLink = null;
			this.label4.Left = 3.25F;
			this.label4.Name = "label4";
			this.label4.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label4.Text = "円";
			this.label4.Top = 4.07F;
			this.label4.Width = 0.125F;
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
			this.newLifeInsPensAmtText.Top = 3.468F;
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
			this.newLifeInsCareAmtText.Top = 3.468F;
			this.newLifeInsCareAmtText.Width = 0.45F;
			// 
			// label20
			// 
			this.label20.Height = 0.153F;
			this.label20.HyperLink = null;
			this.label20.Left = 1.335F;
			this.label20.Name = "label20";
			this.label20.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label20.Text = "円";
			this.label20.Top = 3.37F;
			this.label20.Width = 0.125F;
			// 
			// label24
			// 
			this.label24.Height = 0.153F;
			this.label24.HyperLink = null;
			this.label24.Left = 2.25F;
			this.label24.Name = "label24";
			this.label24.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label24.Text = "円";
			this.label24.Top = 3.37F;
			this.label24.Width = 0.125F;
			// 
			// newLifeInsGeneralAmtText
			// 
			this.newLifeInsGeneralAmtText.CanGrow = false;
			this.newLifeInsGeneralAmtText.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.newLifeInsGeneralAmtText.Height = 0.15F;
			this.newLifeInsGeneralAmtText.Left = 1.005F;
			this.newLifeInsGeneralAmtText.Name = "newLifeInsGeneralAmtText";
			this.newLifeInsGeneralAmtText.OutputFormat = "#,##0";
			this.newLifeInsGeneralAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.newLifeInsGeneralAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.newLifeInsGeneralAmtText.Top = 3.468F;
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
			this.lifeInsGeneralAmtText.Top = 3.468F;
			this.lifeInsGeneralAmtText.Width = 0.45F;
			// 
			// summary1Digit0Text
			// 
			this.summary1Digit0Text.CanGrow = false;
			this.summary1Digit0Text.DataField = "SUMMARY_DIGIT";
			this.summary1Digit0Text.Height = 0.5F;
			this.summary1Digit0Text.Left = 0.2F;
			this.summary1Digit0Text.Name = "summary1Digit0Text";
			this.summary1Digit0Text.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.summary1Digit0Text.Text = resources.GetString("summary1Digit0Text.Text");
			this.summary1Digit0Text.Top = 2.82F;
			this.summary1Digit0Text.Width = 5.063F;
			// 
			// line26
			// 
			this.line26.Height = 0F;
			this.line26.Left = 0.44F;
			this.line26.LineWeight = 1F;
			this.line26.Name = "line26";
			this.line26.Top = 7.1F;
			this.line26.Width = 4.94F;
			this.line26.X1 = 0.44F;
			this.line26.X2 = 5.38F;
			this.line26.Y1 = 7.1F;
			this.line26.Y2 = 7.1F;
			// 
			// line31
			// 
			this.line31.Height = 1.39F;
			this.line31.Left = 0.425F;
			this.line31.LineWeight = 1F;
			this.line31.Name = "line31";
			this.line31.Top = 6.21F;
			this.line31.Width = 0F;
			this.line31.X1 = 0.425F;
			this.line31.X2 = 0.425F;
			this.line31.Y1 = 6.21F;
			this.line31.Y2 = 7.6F;
			// 
			// line32
			// 
			this.line32.Height = 0.6900001F;
			this.line32.Left = 0.585F;
			this.line32.LineWeight = 1F;
			this.line32.Name = "line32";
			this.line32.Top = 6.21F;
			this.line32.Width = 0F;
			this.line32.X1 = 0.585F;
			this.line32.X2 = 0.585F;
			this.line32.Y1 = 6.21F;
			this.line32.Y2 = 6.9F;
			// 
			// label2
			// 
			this.label2.Height = 0.11F;
			this.label2.HyperLink = null;
			this.label2.Left = 3.675F;
			this.label2.Name = "label2";
			this.label2.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label2.Text = "16歳未満";
			this.label2.Top = 1.52F;
			this.label2.Width = 0.375F;
			// 
			// label3
			// 
			this.label3.Height = 0.11F;
			this.label3.HyperLink = null;
			this.label3.Left = 3.675F;
			this.label3.Name = "label3";
			this.label3.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label3.Text = "扶養親族";
			this.label3.Top = 1.63F;
			this.label3.Width = 0.375F;
			// 
			// label1
			// 
			this.label1.Height = 0.15F;
			this.label1.HyperLink = null;
			this.label1.Left = 3.942F;
			this.label1.Name = "label1";
			this.label1.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label1.Text = "人";
			this.label1.Top = 1.9F;
			this.label1.Width = 0.1F;
			// 
			// YoungDpndNumText
			// 
			this.YoungDpndNumText.CanGrow = false;
			this.YoungDpndNumText.DataField = "YOUNG_DPND_NUM";
			this.YoungDpndNumText.Height = 0.15F;
			this.YoungDpndNumText.Left = 3.78F;
			this.YoungDpndNumText.Name = "YoungDpndNumText";
			this.YoungDpndNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.YoungDpndNumText.Text = "Z6";
			this.YoungDpndNumText.Top = 2.03F;
			this.YoungDpndNumText.Width = 0.15F;
			// 
			// line33
			// 
			this.line33.Height = 0F;
			this.line33.Left = 0.19F;
			this.line33.LineWeight = 1F;
			this.line33.Name = "line33";
			this.line33.Top = 4.51F;
			this.line33.Width = 5.19F;
			this.line33.X1 = 0.19F;
			this.line33.X2 = 5.38F;
			this.line33.Y1 = 4.51F;
			this.line33.Y2 = 4.51F;
			// 
			// line34
			// 
			this.line34.Height = 2.14F;
			this.line34.Left = 0.45F;
			this.line34.LineWeight = 1F;
			this.line34.Name = "line34";
			this.line34.Top = 4.07F;
			this.line34.Width = 0F;
			this.line34.X1 = 0.45F;
			this.line34.X2 = 0.45F;
			this.line34.Y1 = 4.07F;
			this.line34.Y2 = 6.21F;
			// 
			// line35
			// 
			this.line35.Height = 0F;
			this.line35.Left = 0.37F;
			this.line35.LineWeight = 1F;
			this.line35.Name = "line35";
			this.line35.Top = 4.935F;
			this.line35.Width = 2.03F;
			this.line35.X1 = 0.37F;
			this.line35.X2 = 2.4F;
			this.line35.Y1 = 4.935F;
			this.line35.Y2 = 4.935F;
			// 
			// line36
			// 
			this.line36.Height = 0F;
			this.line36.Left = 0.37F;
			this.line36.LineWeight = 1F;
			this.line36.Name = "line36";
			this.line36.Top = 5.36F;
			this.line36.Width = 2.03F;
			this.line36.X1 = 0.37F;
			this.line36.X2 = 2.4F;
			this.line36.Y1 = 5.36F;
			this.line36.Y2 = 5.36F;
			// 
			// line37
			// 
			this.line37.Height = 0F;
			this.line37.Left = 0.37F;
			this.line37.LineWeight = 1F;
			this.line37.Name = "line37";
			this.line37.Top = 5.785F;
			this.line37.Width = 2.03F;
			this.line37.X1 = 0.37F;
			this.line37.X2 = 2.4F;
			this.line37.Y1 = 5.785F;
			this.line37.Y2 = 5.785F;
			// 
			// label41
			// 
			this.label41.Height = 1.4F;
			this.label41.HyperLink = null;
			this.label41.Left = 0.21F;
			this.label41.Name = "label41";
			this.label41.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label41.Text = "控除対象扶養親族";
			this.label41.Top = 4.66F;
			this.label41.Width = 0.15F;
			// 
			// label42
			// 
			this.label42.Height = 0.385F;
			this.label42.HyperLink = null;
			this.label42.Left = 0.385F;
			this.label42.Name = "label42";
			this.label42.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label42.Text = "1";
			this.label42.Top = 4.53F;
			this.label42.Width = 0.05F;
			// 
			// label43
			// 
			this.label43.Height = 0.385F;
			this.label43.HyperLink = null;
			this.label43.Left = 0.385F;
			this.label43.Name = "label43";
			this.label43.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label43.Text = "2";
			this.label43.Top = 4.945F;
			this.label43.Width = 0.05F;
			// 
			// label44
			// 
			this.label44.Height = 0.385F;
			this.label44.HyperLink = null;
			this.label44.Left = 0.385F;
			this.label44.Name = "label44";
			this.label44.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label44.Text = "3";
			this.label44.Top = 5.37F;
			this.label44.Width = 0.05F;
			// 
			// label45
			// 
			this.label45.Height = 0.385F;
			this.label45.HyperLink = null;
			this.label45.Left = 0.385F;
			this.label45.Name = "label45";
			this.label45.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label45.Text = "4";
			this.label45.Top = 5.795F;
			this.label45.Width = 0.05F;
			// 
			// line38
			// 
			this.line38.Height = 0F;
			this.line38.Left = 0.45F;
			this.line38.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line38.LineWeight = 1F;
			this.line38.Name = "line38";
			this.line38.Top = 4.65F;
			this.line38.Width = 1.51F;
			this.line38.X1 = 0.45F;
			this.line38.X2 = 1.96F;
			this.line38.Y1 = 4.65F;
			this.line38.Y2 = 4.65F;
			// 
			// line39
			// 
			this.line39.Height = 0.2819996F;
			this.line39.Left = 1.96F;
			this.line39.LineWeight = 1F;
			this.line39.Name = "line39";
			this.line39.Top = 4.51F;
			this.line39.Width = 0F;
			this.line39.X1 = 1.96F;
			this.line39.X2 = 1.96F;
			this.line39.Y1 = 4.51F;
			this.line39.Y2 = 4.792F;
			// 
			// line40
			// 
			this.line40.Height = 0.2819996F;
			this.line40.Left = 2.15F;
			this.line40.LineWeight = 1F;
			this.line40.Name = "line40";
			this.line40.Top = 4.51F;
			this.line40.Width = 0F;
			this.line40.X1 = 2.15F;
			this.line40.X2 = 2.15F;
			this.line40.Y1 = 4.51F;
			this.line40.Y2 = 4.792F;
			// 
			// line41
			// 
			this.line41.Height = 2.14F;
			this.line41.Left = 2.4F;
			this.line41.LineWeight = 1F;
			this.line41.Name = "line41";
			this.line41.Top = 4.07F;
			this.line41.Width = 0F;
			this.line41.X1 = 2.4F;
			this.line41.X2 = 2.4F;
			this.line41.Y1 = 4.07F;
			this.line41.Y2 = 6.21F;
			// 
			// line42
			// 
			this.line42.Height = 1.7F;
			this.line42.Left = 2.58F;
			this.line42.LineWeight = 1F;
			this.line42.Name = "line42";
			this.line42.Top = 4.51F;
			this.line42.Width = 0F;
			this.line42.X1 = 2.58F;
			this.line42.X2 = 2.58F;
			this.line42.Y1 = 4.51F;
			this.line42.Y2 = 6.21F;
			// 
			// line43
			// 
			this.line43.Height = 1.700001F;
			this.line43.Left = 2.66F;
			this.line43.LineWeight = 1F;
			this.line43.Name = "line43";
			this.line43.Top = 4.51F;
			this.line43.Width = 0F;
			this.line43.X1 = 2.66F;
			this.line43.X2 = 2.66F;
			this.line43.Y1 = 4.51F;
			this.line43.Y2 = 6.210001F;
			// 
			// label46
			// 
			this.label46.Height = 0.385F;
			this.label46.HyperLink = null;
			this.label46.Left = 2.59F;
			this.label46.Name = "label46";
			this.label46.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label46.Text = "1";
			this.label46.Top = 4.53F;
			this.label46.Width = 0.05F;
			// 
			// label47
			// 
			this.label47.Height = 0.385F;
			this.label47.HyperLink = null;
			this.label47.Left = 2.59F;
			this.label47.Name = "label47";
			this.label47.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label47.Text = "2";
			this.label47.Top = 4.945F;
			this.label47.Width = 0.05F;
			// 
			// label48
			// 
			this.label48.Height = 0.385F;
			this.label48.HyperLink = null;
			this.label48.Left = 2.59F;
			this.label48.Name = "label48";
			this.label48.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label48.Text = "3";
			this.label48.Top = 5.37F;
			this.label48.Width = 0.05F;
			// 
			// label49
			// 
			this.label49.Height = 0.385F;
			this.label49.HyperLink = null;
			this.label49.Left = 2.59F;
			this.label49.Name = "label49";
			this.label49.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label49.Text = "4";
			this.label49.Top = 5.795F;
			this.label49.Width = 0.05F;
			// 
			// line44
			// 
			this.line44.Height = 0F;
			this.line44.Left = 2.66F;
			this.line44.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line44.LineWeight = 1F;
			this.line44.Name = "line44";
			this.line44.Top = 4.65F;
			this.line44.Width = 1.51F;
			this.line44.X1 = 2.66F;
			this.line44.X2 = 4.17F;
			this.line44.Y1 = 4.65F;
			this.line44.Y2 = 4.65F;
			// 
			// line45
			// 
			this.line45.Height = 0.2819996F;
			this.line45.Left = 4.17F;
			this.line45.LineWeight = 1F;
			this.line45.Name = "line45";
			this.line45.Top = 4.51F;
			this.line45.Width = 0F;
			this.line45.X1 = 4.17F;
			this.line45.X2 = 4.17F;
			this.line45.Y1 = 4.51F;
			this.line45.Y2 = 4.792F;
			// 
			// line46
			// 
			this.line46.Height = 0.2819996F;
			this.line46.Left = 4.36F;
			this.line46.LineWeight = 1F;
			this.line46.Name = "line46";
			this.line46.Top = 4.51F;
			this.line46.Width = 0F;
			this.line46.X1 = 4.36F;
			this.line46.X2 = 4.36F;
			this.line46.Y1 = 4.51F;
			this.line46.Y2 = 4.792F;
			// 
			// line47
			// 
			this.line47.Height = 1.7F;
			this.line47.Left = 4.61F;
			this.line47.LineWeight = 1F;
			this.line47.Name = "line47";
			this.line47.Top = 4.51F;
			this.line47.Width = 0F;
			this.line47.X1 = 4.61F;
			this.line47.X2 = 4.61F;
			this.line47.Y1 = 4.51F;
			this.line47.Y2 = 6.21F;
			// 
			// line48
			// 
			this.line48.Height = 0F;
			this.line48.Left = 0.45F;
			this.line48.LineWeight = 1F;
			this.line48.Name = "line48";
			this.line48.Top = 4.792F;
			this.line48.Width = 1.95F;
			this.line48.X1 = 0.45F;
			this.line48.X2 = 2.4F;
			this.line48.Y1 = 4.792F;
			this.line48.Y2 = 4.792F;
			// 
			// label50
			// 
			this.label50.Height = 1.4F;
			this.label50.HyperLink = null;
			this.label50.Left = 2.42F;
			this.label50.Name = "label50";
			this.label50.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label50.Text = "１６歳未満の扶養親族";
			this.label50.Top = 4.66F;
			this.label50.Width = 0.15F;
			// 
			// line49
			// 
			this.line49.Height = 0.2820001F;
			this.line49.Left = 1.96F;
			this.line49.LineWeight = 1F;
			this.line49.Name = "line49";
			this.line49.Top = 4.935F;
			this.line49.Width = 0F;
			this.line49.X1 = 1.96F;
			this.line49.X2 = 1.96F;
			this.line49.Y1 = 4.935F;
			this.line49.Y2 = 5.217F;
			// 
			// line50
			// 
			this.line50.Height = 0F;
			this.line50.Left = 0.45F;
			this.line50.LineWeight = 1F;
			this.line50.Name = "line50";
			this.line50.Top = 5.217F;
			this.line50.Width = 1.95F;
			this.line50.X1 = 0.45F;
			this.line50.X2 = 2.4F;
			this.line50.Y1 = 5.217F;
			this.line50.Y2 = 5.217F;
			// 
			// line51
			// 
			this.line51.Height = 0.2820001F;
			this.line51.Left = 2.15F;
			this.line51.LineWeight = 1F;
			this.line51.Name = "line51";
			this.line51.Top = 4.935F;
			this.line51.Width = 0F;
			this.line51.X1 = 2.15F;
			this.line51.X2 = 2.15F;
			this.line51.Y1 = 4.935F;
			this.line51.Y2 = 5.217F;
			// 
			// line52
			// 
			this.line52.Height = 0F;
			this.line52.Left = 0.45F;
			this.line52.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line52.LineWeight = 1F;
			this.line52.Name = "line52";
			this.line52.Top = 5.075F;
			this.line52.Width = 1.51F;
			this.line52.X1 = 0.45F;
			this.line52.X2 = 1.96F;
			this.line52.Y1 = 5.075F;
			this.line52.Y2 = 5.075F;
			// 
			// line53
			// 
			this.line53.Height = 0F;
			this.line53.Left = 0.45F;
			this.line53.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line53.LineWeight = 1F;
			this.line53.Name = "line53";
			this.line53.Top = 5.5F;
			this.line53.Width = 1.51F;
			this.line53.X1 = 0.45F;
			this.line53.X2 = 1.96F;
			this.line53.Y1 = 5.5F;
			this.line53.Y2 = 5.5F;
			// 
			// line54
			// 
			this.line54.Height = 0F;
			this.line54.Left = 0.45F;
			this.line54.LineWeight = 1F;
			this.line54.Name = "line54";
			this.line54.Top = 5.642F;
			this.line54.Width = 1.95F;
			this.line54.X1 = 0.45F;
			this.line54.X2 = 2.4F;
			this.line54.Y1 = 5.642F;
			this.line54.Y2 = 5.642F;
			// 
			// line55
			// 
			this.line55.Height = 0.2820001F;
			this.line55.Left = 1.96F;
			this.line55.LineWeight = 1F;
			this.line55.Name = "line55";
			this.line55.Top = 5.36F;
			this.line55.Width = 0F;
			this.line55.X1 = 1.96F;
			this.line55.X2 = 1.96F;
			this.line55.Y1 = 5.36F;
			this.line55.Y2 = 5.642F;
			// 
			// line56
			// 
			this.line56.Height = 0.2820001F;
			this.line56.Left = 2.15F;
			this.line56.LineWeight = 1F;
			this.line56.Name = "line56";
			this.line56.Top = 5.36F;
			this.line56.Width = 0F;
			this.line56.X1 = 2.15F;
			this.line56.X2 = 2.15F;
			this.line56.Y1 = 5.36F;
			this.line56.Y2 = 5.642F;
			// 
			// line57
			// 
			this.line57.Height = 0F;
			this.line57.Left = 0.45F;
			this.line57.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line57.LineWeight = 1F;
			this.line57.Name = "line57";
			this.line57.Top = 5.925F;
			this.line57.Width = 1.51F;
			this.line57.X1 = 0.45F;
			this.line57.X2 = 1.96F;
			this.line57.Y1 = 5.925F;
			this.line57.Y2 = 5.925F;
			// 
			// line58
			// 
			this.line58.Height = 0F;
			this.line58.Left = 0.45F;
			this.line58.LineWeight = 1F;
			this.line58.Name = "line58";
			this.line58.Top = 6.067F;
			this.line58.Width = 1.95F;
			this.line58.X1 = 0.45F;
			this.line58.X2 = 2.4F;
			this.line58.Y1 = 6.067F;
			this.line58.Y2 = 6.067F;
			// 
			// line59
			// 
			this.line59.Height = 0.2820001F;
			this.line59.Left = 1.96F;
			this.line59.LineWeight = 1F;
			this.line59.Name = "line59";
			this.line59.Top = 5.785F;
			this.line59.Width = 0F;
			this.line59.X1 = 1.96F;
			this.line59.X2 = 1.96F;
			this.line59.Y1 = 5.785F;
			this.line59.Y2 = 6.067F;
			// 
			// line60
			// 
			this.line60.Height = 0.2820001F;
			this.line60.Left = 2.15F;
			this.line60.LineWeight = 1F;
			this.line60.Name = "line60";
			this.line60.Top = 5.785F;
			this.line60.Width = 0F;
			this.line60.X1 = 2.15F;
			this.line60.X2 = 2.15F;
			this.line60.Y1 = 5.785F;
			this.line60.Y2 = 6.067F;
			// 
			// line61
			// 
			this.line61.Height = 0F;
			this.line61.Left = 2.58F;
			this.line61.LineWeight = 1F;
			this.line61.Name = "line61";
			this.line61.Top = 4.935F;
			this.line61.Width = 2.03F;
			this.line61.X1 = 2.58F;
			this.line61.X2 = 4.61F;
			this.line61.Y1 = 4.935F;
			this.line61.Y2 = 4.935F;
			// 
			// line62
			// 
			this.line62.Height = 0F;
			this.line62.Left = 2.66F;
			this.line62.LineWeight = 1F;
			this.line62.Name = "line62";
			this.line62.Top = 4.792F;
			this.line62.Width = 1.95F;
			this.line62.X1 = 2.66F;
			this.line62.X2 = 4.61F;
			this.line62.Y1 = 4.792F;
			this.line62.Y2 = 4.792F;
			// 
			// line63
			// 
			this.line63.Height = 1.699843F;
			this.line63.Left = 2.955F;
			this.line63.LineWeight = 1F;
			this.line63.Name = "line63";
			this.line63.Top = 4.51F;
			this.line63.Width = 0.0001180172F;
			this.line63.X1 = 2.955F;
			this.line63.X2 = 2.955118F;
			this.line63.Y1 = 4.51F;
			this.line63.Y2 = 6.209843F;
			// 
			// label51
			// 
			this.label51.Height = 0.14F;
			this.label51.HyperLink = null;
			this.label51.Left = 0.43F;
			this.label51.Name = "label51";
			this.label51.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label51.Text = "(フリガナ)";
			this.label51.Top = 4.54F;
			this.label51.Width = 0.33F;
			// 
			// label52
			// 
			this.label52.Height = 0.14F;
			this.label52.HyperLink = null;
			this.label52.Left = 0.45F;
			this.label52.Name = "label52";
			this.label52.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label52.Text = "氏名";
			this.label52.Top = 4.68F;
			this.label52.Width = 0.295F;
			// 
			// label53
			// 
			this.label53.Height = 0.14F;
			this.label53.HyperLink = null;
			this.label53.Left = 0.43F;
			this.label53.Name = "label53";
			this.label53.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label53.Text = "(フリガナ)";
			this.label53.Top = 4.965F;
			this.label53.Width = 0.33F;
			// 
			// label54
			// 
			this.label54.Height = 0.14F;
			this.label54.HyperLink = null;
			this.label54.Left = 0.45F;
			this.label54.Name = "label54";
			this.label54.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label54.Text = "氏名";
			this.label54.Top = 5.105F;
			this.label54.Width = 0.295F;
			// 
			// label55
			// 
			this.label55.Height = 0.14F;
			this.label55.HyperLink = null;
			this.label55.Left = 0.43F;
			this.label55.Name = "label55";
			this.label55.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label55.Text = "(フリガナ)";
			this.label55.Top = 5.39F;
			this.label55.Width = 0.33F;
			// 
			// label56
			// 
			this.label56.Height = 0.14F;
			this.label56.HyperLink = null;
			this.label56.Left = 0.45F;
			this.label56.Name = "label56";
			this.label56.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label56.Text = "氏名";
			this.label56.Top = 5.53F;
			this.label56.Width = 0.295F;
			// 
			// label57
			// 
			this.label57.Height = 0.14F;
			this.label57.HyperLink = null;
			this.label57.Left = 0.45F;
			this.label57.Name = "label57";
			this.label57.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label57.Text = "氏名";
			this.label57.Top = 5.955F;
			this.label57.Width = 0.295F;
			// 
			// label58
			// 
			this.label58.Height = 0.14F;
			this.label58.HyperLink = null;
			this.label58.Left = 0.43F;
			this.label58.Name = "label58";
			this.label58.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label58.Text = "(フリガナ)";
			this.label58.Top = 5.815F;
			this.label58.Width = 0.33F;
			// 
			// label59
			// 
			this.label59.Height = 0.2F;
			this.label59.HyperLink = null;
			this.label59.Left = 2F;
			this.label59.Name = "label59";
			this.label59.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label59.Text = "区分";
			this.label59.Top = 4.56F;
			this.label59.Width = 0.1F;
			// 
			// label60
			// 
			this.label60.Height = 0.2F;
			this.label60.HyperLink = null;
			this.label60.Left = 2F;
			this.label60.Name = "label60";
			this.label60.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label60.Text = "区分";
			this.label60.Top = 4.985F;
			this.label60.Width = 0.1F;
			// 
			// label61
			// 
			this.label61.Height = 0.2F;
			this.label61.HyperLink = null;
			this.label61.Left = 2F;
			this.label61.Name = "label61";
			this.label61.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label61.Text = "区分";
			this.label61.Top = 5.41F;
			this.label61.Width = 0.1F;
			// 
			// label62
			// 
			this.label62.Height = 0.2F;
			this.label62.HyperLink = null;
			this.label62.Left = 2F;
			this.label62.Name = "label62";
			this.label62.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label62.Text = "区分";
			this.label62.Top = 5.835F;
			this.label62.Width = 0.1F;
			// 
			// label63
			// 
			this.label63.Height = 0.14F;
			this.label63.HyperLink = null;
			this.label63.Left = 2.64F;
			this.label63.Name = "label63";
			this.label63.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label63.Text = "(フリガナ)";
			this.label63.Top = 4.54F;
			this.label63.Width = 0.33F;
			// 
			// line64
			// 
			this.line64.Height = 0F;
			this.line64.Left = 2.66F;
			this.line64.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line64.LineWeight = 1F;
			this.line64.Name = "line64";
			this.line64.Top = 5.075F;
			this.line64.Width = 1.51F;
			this.line64.X1 = 2.66F;
			this.line64.X2 = 4.17F;
			this.line64.Y1 = 5.075F;
			this.line64.Y2 = 5.075F;
			// 
			// line65
			// 
			this.line65.Height = 0.2820001F;
			this.line65.Left = 4.17F;
			this.line65.LineWeight = 1F;
			this.line65.Name = "line65";
			this.line65.Top = 4.935F;
			this.line65.Width = 0F;
			this.line65.X1 = 4.17F;
			this.line65.X2 = 4.17F;
			this.line65.Y1 = 4.935F;
			this.line65.Y2 = 5.217F;
			// 
			// line66
			// 
			this.line66.Height = 0.2820001F;
			this.line66.Left = 4.360001F;
			this.line66.LineWeight = 1F;
			this.line66.Name = "line66";
			this.line66.Top = 4.935F;
			this.line66.Width = 0F;
			this.line66.X1 = 4.360001F;
			this.line66.X2 = 4.360001F;
			this.line66.Y1 = 4.935F;
			this.line66.Y2 = 5.217F;
			// 
			// line67
			// 
			this.line67.Height = 0F;
			this.line67.Left = 2.58F;
			this.line67.LineWeight = 1F;
			this.line67.Name = "line67";
			this.line67.Top = 5.36F;
			this.line67.Width = 2.03F;
			this.line67.X1 = 2.58F;
			this.line67.X2 = 4.61F;
			this.line67.Y1 = 5.36F;
			this.line67.Y2 = 5.36F;
			// 
			// line68
			// 
			this.line68.Height = 0F;
			this.line68.Left = 2.66F;
			this.line68.LineWeight = 1F;
			this.line68.Name = "line68";
			this.line68.Top = 5.217F;
			this.line68.Width = 1.950001F;
			this.line68.X1 = 2.66F;
			this.line68.X2 = 4.610001F;
			this.line68.Y1 = 5.217F;
			this.line68.Y2 = 5.217F;
			// 
			// label65
			// 
			this.label65.Height = 0.14F;
			this.label65.HyperLink = null;
			this.label65.Left = 2.64F;
			this.label65.Name = "label65";
			this.label65.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label65.Text = "(フリガナ)";
			this.label65.Top = 4.965F;
			this.label65.Width = 0.33F;
			// 
			// label67
			// 
			this.label67.Height = 0.2F;
			this.label67.HyperLink = null;
			this.label67.Left = 4.219F;
			this.label67.Name = "label67";
			this.label67.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label67.Text = "区分";
			this.label67.Top = 4.56F;
			this.label67.Width = 0.1F;
			// 
			// label68
			// 
			this.label68.Height = 0.2F;
			this.label68.HyperLink = null;
			this.label68.Left = 4.219F;
			this.label68.Name = "label68";
			this.label68.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label68.Text = "区分";
			this.label68.Top = 4.985F;
			this.label68.Width = 0.1F;
			// 
			// line70
			// 
			this.line70.Height = 0F;
			this.line70.Left = 2.66F;
			this.line70.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line70.LineWeight = 1F;
			this.line70.Name = "line70";
			this.line70.Top = 5.5F;
			this.line70.Width = 1.51F;
			this.line70.X1 = 2.66F;
			this.line70.X2 = 4.17F;
			this.line70.Y1 = 5.5F;
			this.line70.Y2 = 5.5F;
			// 
			// line71
			// 
			this.line71.Height = 0.2820001F;
			this.line71.Left = 4.17F;
			this.line71.LineWeight = 1F;
			this.line71.Name = "line71";
			this.line71.Top = 5.36F;
			this.line71.Width = 0F;
			this.line71.X1 = 4.17F;
			this.line71.X2 = 4.17F;
			this.line71.Y1 = 5.36F;
			this.line71.Y2 = 5.642F;
			// 
			// line72
			// 
			this.line72.Height = 0.2820001F;
			this.line72.Left = 4.360001F;
			this.line72.LineWeight = 1F;
			this.line72.Name = "line72";
			this.line72.Top = 5.36F;
			this.line72.Width = 0F;
			this.line72.X1 = 4.360001F;
			this.line72.X2 = 4.360001F;
			this.line72.Y1 = 5.36F;
			this.line72.Y2 = 5.642F;
			// 
			// line73
			// 
			this.line73.Height = 0F;
			this.line73.Left = 2.58F;
			this.line73.LineWeight = 1F;
			this.line73.Name = "line73";
			this.line73.Top = 5.785F;
			this.line73.Width = 2.03F;
			this.line73.X1 = 2.58F;
			this.line73.X2 = 4.61F;
			this.line73.Y1 = 5.785F;
			this.line73.Y2 = 5.785F;
			// 
			// line74
			// 
			this.line74.Height = 0F;
			this.line74.Left = 2.66F;
			this.line74.LineWeight = 1F;
			this.line74.Name = "line74";
			this.line74.Top = 5.642F;
			this.line74.Width = 1.950001F;
			this.line74.X1 = 2.66F;
			this.line74.X2 = 4.610001F;
			this.line74.Y1 = 5.642F;
			this.line74.Y2 = 5.642F;
			// 
			// label69
			// 
			this.label69.Height = 0.14F;
			this.label69.HyperLink = null;
			this.label69.Left = 2.64F;
			this.label69.Name = "label69";
			this.label69.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label69.Text = "(フリガナ)";
			this.label69.Top = 5.39F;
			this.label69.Width = 0.33F;
			// 
			// label71
			// 
			this.label71.Height = 0.2F;
			this.label71.HyperLink = null;
			this.label71.Left = 4.219F;
			this.label71.Name = "label71";
			this.label71.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label71.Text = "区分";
			this.label71.Top = 5.41F;
			this.label71.Width = 0.1F;
			// 
			// line76
			// 
			this.line76.Height = 0F;
			this.line76.Left = 2.66F;
			this.line76.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line76.LineWeight = 1F;
			this.line76.Name = "line76";
			this.line76.Top = 5.925F;
			this.line76.Width = 1.51F;
			this.line76.X1 = 2.66F;
			this.line76.X2 = 4.17F;
			this.line76.Y1 = 5.925F;
			this.line76.Y2 = 5.925F;
			// 
			// line77
			// 
			this.line77.Height = 0.2820001F;
			this.line77.Left = 4.17F;
			this.line77.LineWeight = 1F;
			this.line77.Name = "line77";
			this.line77.Top = 5.785F;
			this.line77.Width = 0F;
			this.line77.X1 = 4.17F;
			this.line77.X2 = 4.17F;
			this.line77.Y1 = 5.785F;
			this.line77.Y2 = 6.067F;
			// 
			// line78
			// 
			this.line78.Height = 0.2820001F;
			this.line78.Left = 4.360001F;
			this.line78.LineWeight = 1F;
			this.line78.Name = "line78";
			this.line78.Top = 5.785F;
			this.line78.Width = 0F;
			this.line78.X1 = 4.360001F;
			this.line78.X2 = 4.360001F;
			this.line78.Y1 = 5.785F;
			this.line78.Y2 = 6.067F;
			// 
			// line79
			// 
			this.line79.Height = 0F;
			this.line79.Left = 2.66F;
			this.line79.LineWeight = 1F;
			this.line79.Name = "line79";
			this.line79.Top = 6.067F;
			this.line79.Width = 1.950001F;
			this.line79.X1 = 2.66F;
			this.line79.X2 = 4.610001F;
			this.line79.Y1 = 6.067F;
			this.line79.Y2 = 6.067F;
			// 
			// label72
			// 
			this.label72.Height = 0.14F;
			this.label72.HyperLink = null;
			this.label72.Left = 2.64F;
			this.label72.Name = "label72";
			this.label72.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label72.Text = "(フリガナ)";
			this.label72.Top = 5.815F;
			this.label72.Width = 0.33F;
			// 
			// label74
			// 
			this.label74.Height = 0.2F;
			this.label74.HyperLink = null;
			this.label74.Left = 4.219F;
			this.label74.Name = "label74";
			this.label74.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label74.Text = "区分";
			this.label74.Top = 5.835F;
			this.label74.Width = 0.1F;
			// 
			// line81
			// 
			this.line81.Height = 0F;
			this.line81.Left = 0.19F;
			this.line81.LineWeight = 1F;
			this.line81.Name = "line81";
			this.line81.Top = 4.07F;
			this.line81.Width = 5.19F;
			this.line81.X1 = 0.19F;
			this.line81.X2 = 5.38F;
			this.line81.Y1 = 4.07F;
			this.line81.Y2 = 4.07F;
			// 
			// label75
			// 
			this.label75.Height = 0.14F;
			this.label75.HyperLink = null;
			this.label75.Left = 0.19F;
			this.label75.Name = "label75";
			this.label75.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label75.Text = "控除対象";
			this.label75.Top = 4.237008F;
			this.label75.Width = 0.25F;
			// 
			// label76
			// 
			this.label76.Height = 0.14F;
			this.label76.HyperLink = null;
			this.label76.Left = 0.19F;
			this.label76.Name = "label76";
			this.label76.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label76.Text = "配偶者";
			this.label76.Top = 4.31F;
			this.label76.Width = 0.25F;
			// 
			// line82
			// 
			this.line82.Height = 0F;
			this.line82.Left = 0.45F;
			this.line82.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line82.LineWeight = 1F;
			this.line82.Name = "line82";
			this.line82.Top = 4.21F;
			this.line82.Width = 1.51F;
			this.line82.X1 = 0.45F;
			this.line82.X2 = 1.96F;
			this.line82.Y1 = 4.21F;
			this.line82.Y2 = 4.21F;
			// 
			// line83
			// 
			this.line83.Height = 0F;
			this.line83.Left = 0.45F;
			this.line83.LineWeight = 1F;
			this.line83.Name = "line83";
			this.line83.Top = 4.352F;
			this.line83.Width = 1.95F;
			this.line83.X1 = 0.45F;
			this.line83.X2 = 2.4F;
			this.line83.Y1 = 4.352F;
			this.line83.Y2 = 4.352F;
			// 
			// label77
			// 
			this.label77.Height = 0.2F;
			this.label77.HyperLink = null;
			this.label77.Left = 2F;
			this.label77.Name = "label77";
			this.label77.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label77.Text = "区分";
			this.label77.Top = 4.12F;
			this.label77.Width = 0.1F;
			// 
			// line84
			// 
			this.line84.Height = 0.2820001F;
			this.line84.Left = 2.15F;
			this.line84.LineWeight = 1F;
			this.line84.Name = "line84";
			this.line84.Top = 4.07F;
			this.line84.Width = 0F;
			this.line84.X1 = 2.15F;
			this.line84.X2 = 2.15F;
			this.line84.Y1 = 4.07F;
			this.line84.Y2 = 4.352F;
			// 
			// line85
			// 
			this.line85.Height = 0.2820001F;
			this.line85.Left = 1.96F;
			this.line85.LineWeight = 1F;
			this.line85.Name = "line85";
			this.line85.Top = 4.07F;
			this.line85.Width = 0F;
			this.line85.X1 = 1.96F;
			this.line85.X2 = 1.96F;
			this.line85.Y1 = 4.07F;
			this.line85.Y2 = 4.352F;
			// 
			// line90
			// 
			this.line90.Height = 1.13F;
			this.line90.Left = 2.9F;
			this.line90.LineWeight = 1F;
			this.line90.Name = "line90";
			this.line90.Top = 3.38F;
			this.line90.Width = 0F;
			this.line90.X1 = 2.9F;
			this.line90.X2 = 2.9F;
			this.line90.Y1 = 3.38F;
			this.line90.Y2 = 4.51F;
			// 
			// label80
			// 
			this.label80.Height = 0.14F;
			this.label80.HyperLink = null;
			this.label80.Left = 2.43F;
			this.label80.Name = "label80";
			this.label80.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label80.Text = "配偶者の";
			this.label80.Top = 4.17F;
			this.label80.Width = 0.44F;
			// 
			// label81
			// 
			this.label81.Height = 0.14F;
			this.label81.HyperLink = null;
			this.label81.Left = 2.43F;
			this.label81.Name = "label81";
			this.label81.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label81.Text = "合計所得";
			this.label81.Top = 4.31F;
			this.label81.Width = 0.44F;
			// 
			// line91
			// 
			this.line91.Height = 1.13F;
			this.line91.Left = 3.4F;
			this.line91.LineWeight = 1F;
			this.line91.Name = "line91";
			this.line91.Top = 3.38F;
			this.line91.Width = 0F;
			this.line91.X1 = 3.4F;
			this.line91.X2 = 3.4F;
			this.line91.Y1 = 3.38F;
			this.line91.Y2 = 4.51F;
			// 
			// line92
			// 
			this.line92.Height = 1.13F;
			this.line92.Left = 3.9F;
			this.line92.LineWeight = 1F;
			this.line92.Name = "line92";
			this.line92.Top = 3.38F;
			this.line92.Width = 0F;
			this.line92.X1 = 3.9F;
			this.line92.X2 = 3.9F;
			this.line92.Y1 = 3.38F;
			this.line92.Y2 = 4.51F;
			// 
			// line93
			// 
			this.line93.Height = 1.13F;
			this.line93.Left = 4.4F;
			this.line93.LineWeight = 1F;
			this.line93.Name = "line93";
			this.line93.Top = 3.38F;
			this.line93.Width = 0F;
			this.line93.X1 = 4.4F;
			this.line93.X2 = 4.4F;
			this.line93.Y1 = 3.38F;
			this.line93.Y2 = 4.51F;
			// 
			// line94
			// 
			this.line94.Height = 0.4400001F;
			this.line94.Left = 4.9F;
			this.line94.LineWeight = 1F;
			this.line94.Name = "line94";
			this.line94.Top = 4.07F;
			this.line94.Width = 0F;
			this.line94.X1 = 4.9F;
			this.line94.X2 = 4.9F;
			this.line94.Y1 = 4.07F;
			this.line94.Y2 = 4.51F;
			// 
			// label82
			// 
			this.label82.Height = 0.14F;
			this.label82.HyperLink = null;
			this.label82.Left = 3.429921F;
			this.label82.Name = "label82";
			this.label82.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label82.Text = "国民年金保険";
			this.label82.Top = 4.098819F;
			this.label82.Width = 0.45F;
			// 
			// label83
			// 
			this.label83.Height = 0.14F;
			this.label83.HyperLink = null;
			this.label83.Left = 3.429921F;
			this.label83.Name = "label83";
			this.label83.Style = "font-size: 5pt; text-align: center; text-justify: auto; vertical-align: top; whit" +
    "e-space: inherit; ddo-char-set: 1";
			this.label83.Text = "料等の金額";
			this.label83.Top = 4.187795F;
			this.label83.Width = 0.45F;
			// 
			// label84
			// 
			this.label84.Height = 0.14F;
			this.label84.HyperLink = null;
			this.label84.Left = 4.429921F;
			this.label84.Name = "label84";
			this.label84.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label84.Text = "旧長期損害";
			this.label84.Top = 4.098819F;
			this.label84.Width = 0.45F;
			// 
			// label85
			// 
			this.label85.Height = 0.14F;
			this.label85.HyperLink = null;
			this.label85.Left = 4.429921F;
			this.label85.Name = "label85";
			this.label85.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label85.Text = "保険料の金額";
			this.label85.Top = 4.187795F;
			this.label85.Width = 0.45F;
			// 
			// label86
			// 
			this.label86.Height = 0.153F;
			this.label86.HyperLink = null;
			this.label86.Left = 4.25F;
			this.label86.Name = "label86";
			this.label86.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label86.Text = "円";
			this.label86.Top = 4.05F;
			this.label86.Width = 0.125F;
			// 
			// label87
			// 
			this.label87.Height = 0.153F;
			this.label87.HyperLink = null;
			this.label87.Left = 5.229921F;
			this.label87.Name = "label87";
			this.label87.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label87.Text = "円";
			this.label87.Top = 4.05F;
			this.label87.Width = 0.125F;
			// 
			// line95
			// 
			this.line95.Height = 0F;
			this.line95.Left = 0.19F;
			this.line95.LineWeight = 1F;
			this.line95.Name = "line95";
			this.line95.Top = 3.63F;
			this.line95.Width = 5.19F;
			this.line95.X1 = 0.19F;
			this.line95.X2 = 5.38F;
			this.line95.Y1 = 3.63F;
			this.line95.Y2 = 3.63F;
			// 
			// line96
			// 
			this.line96.Height = 0F;
			this.line96.Left = 0.54F;
			this.line96.LineWeight = 1F;
			this.line96.Name = "line96";
			this.line96.Top = 3.85F;
			this.line96.Width = 4.84F;
			this.line96.X1 = 0.54F;
			this.line96.X2 = 5.38F;
			this.line96.Y1 = 3.85F;
			this.line96.Y2 = 3.85F;
			// 
			// line97
			// 
			this.line97.Height = 0.25F;
			this.line97.Left = 2.4F;
			this.line97.LineWeight = 1F;
			this.line97.Name = "line97";
			this.line97.Top = 3.38F;
			this.line97.Width = 0F;
			this.line97.X1 = 2.4F;
			this.line97.X2 = 2.4F;
			this.line97.Y1 = 3.38F;
			this.line97.Y2 = 3.63F;
			// 
			// line98
			// 
			this.line98.Height = 0F;
			this.line98.Left = 0.19F;
			this.line98.LineWeight = 1F;
			this.line98.Name = "line98";
			this.line98.Top = 3.38F;
			this.line98.Width = 5.19F;
			this.line98.X1 = 0.19F;
			this.line98.X2 = 5.38F;
			this.line98.Y1 = 3.38F;
			this.line98.Y2 = 3.38F;
			// 
			// line99
			// 
			this.line99.Height = 0.25F;
			this.line99.Left = 4.9F;
			this.line99.LineWeight = 1F;
			this.line99.Name = "line99";
			this.line99.Top = 3.38F;
			this.line99.Width = 0F;
			this.line99.X1 = 4.9F;
			this.line99.X2 = 4.9F;
			this.line99.Y1 = 3.38F;
			this.line99.Y2 = 3.63F;
			// 
			// line100
			// 
			this.line100.Height = 0.6900001F;
			this.line100.Left = 0.54F;
			this.line100.LineWeight = 1F;
			this.line100.Name = "line100";
			this.line100.Top = 3.38F;
			this.line100.Width = 0F;
			this.line100.X1 = 0.54F;
			this.line100.X2 = 0.54F;
			this.line100.Y1 = 3.38F;
			this.line100.Y2 = 4.07F;
			// 
			// label88
			// 
			this.label88.Height = 0.14F;
			this.label88.HyperLink = null;
			this.label88.Left = 0.2F;
			this.label88.Name = "label88";
			this.label88.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label88.Text = "住宅借入金";
			this.label88.Top = 3.68F;
			this.label88.Width = 0.33F;
			// 
			// label89
			// 
			this.label89.Height = 0.14F;
			this.label89.HyperLink = null;
			this.label89.Left = 0.2F;
			this.label89.Name = "label89";
			this.label89.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label89.Text = "等特別控除";
			this.label89.Top = 3.78F;
			this.label89.Width = 0.33F;
			// 
			// label90
			// 
			this.label90.Height = 0.1400001F;
			this.label90.HyperLink = null;
			this.label90.Left = 0.2F;
			this.label90.Name = "label90";
			this.label90.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label90.Text = "の額の内訳";
			this.label90.Top = 3.89F;
			this.label90.Width = 0.33F;
			// 
			// line101
			// 
			this.line101.Height = 0.6900001F;
			this.line101.Left = 0.98F;
			this.line101.LineWeight = 1F;
			this.line101.Name = "line101";
			this.line101.Top = 3.38F;
			this.line101.Width = 0F;
			this.line101.X1 = 0.98F;
			this.line101.X2 = 0.98F;
			this.line101.Y1 = 3.38F;
			this.line101.Y2 = 4.07F;
			// 
			// line102
			// 
			this.line102.Height = 0.6900001F;
			this.line102.Left = 1.48F;
			this.line102.LineWeight = 1F;
			this.line102.Name = "line102";
			this.line102.Top = 3.38F;
			this.line102.Width = 0F;
			this.line102.X1 = 1.48F;
			this.line102.X2 = 1.48F;
			this.line102.Y1 = 3.38F;
			this.line102.Y2 = 4.07F;
			// 
			// line103
			// 
			this.line103.Height = 0.6900001F;
			this.line103.Left = 1.92F;
			this.line103.LineWeight = 1F;
			this.line103.Name = "line103";
			this.line103.Top = 3.38F;
			this.line103.Width = 0F;
			this.line103.X1 = 1.92F;
			this.line103.X2 = 1.92F;
			this.line103.Y1 = 3.38F;
			this.line103.Y2 = 4.07F;
			// 
			// label91
			// 
			this.label91.Height = 0.14F;
			this.label91.HyperLink = null;
			this.label91.Left = 0.2F;
			this.label91.Name = "label91";
			this.label91.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label91.Text = "生命保険料";
			this.label91.Top = 3.39F;
			this.label91.Width = 0.33F;
			// 
			// label92
			// 
			this.label92.Height = 0.14F;
			this.label92.HyperLink = null;
			this.label92.Left = 0.2F;
			this.label92.Name = "label92";
			this.label92.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label92.Text = "の金額の";
			this.label92.Top = 3.46F;
			this.label92.Width = 0.33F;
			// 
			// label93
			// 
			this.label93.Height = 0.14F;
			this.label93.HyperLink = null;
			this.label93.Left = 0.2F;
			this.label93.Name = "label93";
			this.label93.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label93.Text = "内訳";
			this.label93.Top = 3.53F;
			this.label93.Width = 0.33F;
			// 
			// label94
			// 
			this.label94.Height = 0.14F;
			this.label94.HyperLink = null;
			this.label94.Left = 0.55F;
			this.label94.Name = "label94";
			this.label94.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label94.Text = "新生命保険料";
			this.label94.Top = 3.41F;
			this.label94.Width = 0.42F;
			// 
			// label95
			// 
			this.label95.Height = 0.14F;
			this.label95.HyperLink = null;
			this.label95.Left = 0.55F;
			this.label95.Name = "label95";
			this.label95.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label95.Text = "の金額";
			this.label95.Top = 3.51F;
			this.label95.Width = 0.42F;
			// 
			// label96
			// 
			this.label96.Height = 0.14F;
			this.label96.HyperLink = null;
			this.label96.Left = 0.55F;
			this.label96.Name = "label96";
			this.label96.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label96.Text = "特別控除適用数";
			this.label96.Top = 3.75F;
			this.label96.Width = 0.42F;
			// 
			// label97
			// 
			this.label97.Height = 0.14F;
			this.label97.HyperLink = null;
			this.label97.Left = 0.55F;
			this.label97.Name = "label97";
			this.label97.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label97.Text = "住宅借入金等";
			this.label97.Top = 3.65F;
			this.label97.Width = 0.42F;
			// 
			// label98
			// 
			this.label98.Height = 0.14F;
			this.label98.HyperLink = null;
			this.label98.Left = 0.55F;
			this.label98.Name = "label98";
			this.label98.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label98.Text = "住宅借入金等";
			this.label98.Top = 3.87F;
			this.label98.Width = 0.42F;
			// 
			// label100
			// 
			this.label100.Height = 0.14F;
			this.label100.HyperLink = null;
			this.label100.Left = 1.49F;
			this.label100.Name = "label100";
			this.label100.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label100.Text = "旧生命保険料";
			this.label100.Top = 3.41F;
			this.label100.Width = 0.42F;
			// 
			// label101
			// 
			this.label101.Height = 0.14F;
			this.label101.HyperLink = null;
			this.label101.Left = 1.49F;
			this.label101.Name = "label101";
			this.label101.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label101.Text = "の金額";
			this.label101.Top = 3.51F;
			this.label101.Width = 0.42F;
			// 
			// label102
			// 
			this.label102.Height = 0.14F;
			this.label102.HyperLink = null;
			this.label102.Left = 1.49F;
			this.label102.Name = "label102";
			this.label102.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label102.Text = "日（1回目）";
			this.label102.Top = 3.75F;
			this.label102.Width = 0.42F;
			// 
			// label103
			// 
			this.label103.Height = 0.14F;
			this.label103.HyperLink = null;
			this.label103.Left = 1.49F;
			this.label103.Name = "label103";
			this.label103.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label103.Text = "居住開始年月";
			this.label103.Top = 3.65F;
			this.label103.Width = 0.42F;
			// 
			// label104
			// 
			this.label104.Height = 0.14F;
			this.label104.HyperLink = null;
			this.label104.Left = 1.49F;
			this.label104.Name = "label104";
			this.label104.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label104.Text = "日（2回目）";
			this.label104.Top = 3.97F;
			this.label104.Width = 0.42F;
			// 
			// label105
			// 
			this.label105.Height = 0.14F;
			this.label105.HyperLink = null;
			this.label105.Left = 1.49F;
			this.label105.Name = "label105";
			this.label105.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label105.Text = "居住開始年月";
			this.label105.Top = 3.87F;
			this.label105.Width = 0.42F;
			// 
			// line16
			// 
			this.line16.Height = 0.4400001F;
			this.line16.Left = 2.34F;
			this.line16.LineWeight = 0.2F;
			this.line16.Name = "line16";
			this.line16.Top = 3.63F;
			this.line16.Width = 0F;
			this.line16.X1 = 2.34F;
			this.line16.X2 = 2.34F;
			this.line16.Y1 = 3.63F;
			this.line16.Y2 = 4.07F;
			// 
			// line18
			// 
			this.line18.Height = 0.4400001F;
			this.line18.Left = 2.62F;
			this.line18.LineWeight = 0.2F;
			this.line18.Name = "line18";
			this.line18.Top = 3.63F;
			this.line18.Width = 0F;
			this.line18.X1 = 2.62F;
			this.line18.X2 = 2.62F;
			this.line18.Y1 = 3.63F;
			this.line18.Y2 = 4.07F;
			// 
			// label26
			// 
			this.label26.Height = 0.153F;
			this.label26.HyperLink = null;
			this.label26.Left = 2.21F;
			this.label26.Name = "label26";
			this.label26.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label26.Text = "年";
			this.label26.Top = 3.623F;
			this.label26.Width = 0.125F;
			// 
			// label27
			// 
			this.label27.Height = 0.153F;
			this.label27.HyperLink = null;
			this.label27.Left = 2.21F;
			this.label27.Name = "label27";
			this.label27.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label27.Text = "年";
			this.label27.Top = 3.846F;
			this.label27.Width = 0.125F;
			// 
			// label106
			// 
			this.label106.Height = 0.153F;
			this.label106.HyperLink = null;
			this.label106.Left = 2.49F;
			this.label106.Name = "label106";
			this.label106.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label106.Text = "月";
			this.label106.Top = 3.619F;
			this.label106.Width = 0.125F;
			// 
			// label107
			// 
			this.label107.Height = 0.153F;
			this.label107.HyperLink = null;
			this.label107.Left = 2.49F;
			this.label107.Name = "label107";
			this.label107.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label107.Text = "月";
			this.label107.Top = 3.841995F;
			this.label107.Width = 0.125F;
			// 
			// label108
			// 
			this.label108.Height = 0.153F;
			this.label108.HyperLink = null;
			this.label108.Left = 2.76F;
			this.label108.Name = "label108";
			this.label108.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label108.Text = "日";
			this.label108.Top = 3.615F;
			this.label108.Width = 0.125F;
			// 
			// label109
			// 
			this.label109.Height = 0.153F;
			this.label109.HyperLink = null;
			this.label109.Left = 2.76F;
			this.label109.Name = "label109";
			this.label109.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label109.Text = "日";
			this.label109.Top = 3.837991F;
			this.label109.Width = 0.125F;
			// 
			// label110
			// 
			this.label110.Height = 0.14F;
			this.label110.HyperLink = null;
			this.label110.Left = 2.44F;
			this.label110.Name = "label110";
			this.label110.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label110.Text = "介護医療保";
			this.label110.Top = 3.41F;
			this.label110.Width = 0.42F;
			// 
			// label111
			// 
			this.label111.Height = 0.14F;
			this.label111.HyperLink = null;
			this.label111.Left = 2.44F;
			this.label111.Name = "label111";
			this.label111.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label111.Text = "険料の金額";
			this.label111.Top = 3.51F;
			this.label111.Width = 0.42F;
			// 
			// label112
			// 
			this.label112.Height = 0.153F;
			this.label112.HyperLink = null;
			this.label112.Left = 3.25F;
			this.label112.Name = "label112";
			this.label112.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label112.Text = "円";
			this.label112.Top = 3.37F;
			this.label112.Width = 0.125F;
			// 
			// label113
			// 
			this.label113.Height = 0.14F;
			this.label113.HyperLink = null;
			this.label113.Left = 2.9F;
			this.label113.Name = "label113";
			this.label113.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label113.Text = "住宅借入金等特別";
			this.label113.Top = 3.65F;
			this.label113.Width = 0.48F;
			// 
			// label114
			// 
			this.label114.Height = 0.14F;
			this.label114.HyperLink = null;
			this.label114.Left = 2.9F;
			this.label114.Name = "label114";
			this.label114.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label114.Text = "控除区分(1回目)";
			this.label114.Top = 3.75F;
			this.label114.Width = 0.48F;
			// 
			// label115
			// 
			this.label115.Height = 0.14F;
			this.label115.HyperLink = null;
			this.label115.Left = 2.9F;
			this.label115.Name = "label115";
			this.label115.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label115.Text = "住宅借入金等特別";
			this.label115.Top = 3.87F;
			this.label115.Width = 0.48F;
			// 
			// label116
			// 
			this.label116.Height = 0.14F;
			this.label116.HyperLink = null;
			this.label116.Left = 2.9F;
			this.label116.Name = "label116";
			this.label116.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label116.Text = "控除区分(2回目)";
			this.label116.Top = 3.969998F;
			this.label116.Width = 0.48F;
			// 
			// label117
			// 
			this.label117.Height = 0.14F;
			this.label117.HyperLink = null;
			this.label117.Left = 3.44F;
			this.label117.Name = "label117";
			this.label117.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label117.Text = "保険料の金額";
			this.label117.Top = 3.51F;
			this.label117.Width = 0.42F;
			// 
			// label118
			// 
			this.label118.Height = 0.14F;
			this.label118.HyperLink = null;
			this.label118.Left = 3.44F;
			this.label118.Name = "label118";
			this.label118.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label118.Text = "新個人年金";
			this.label118.Top = 3.41F;
			this.label118.Width = 0.42F;
			// 
			// label13
			// 
			this.label13.Height = 0.153F;
			this.label13.HyperLink = null;
			this.label13.Left = 4.25F;
			this.label13.Name = "label13";
			this.label13.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label13.Text = "円";
			this.label13.Top = 3.37F;
			this.label13.Width = 0.125F;
			// 
			// label5
			// 
			this.label5.Height = 0.14F;
			this.label5.HyperLink = null;
			this.label5.Left = 3.9F;
			this.label5.Name = "label5";
			this.label5.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label5.Text = "住宅借入金等";
			this.label5.Top = 3.65F;
			this.label5.Width = 0.48F;
			// 
			// label18
			// 
			this.label18.Height = 0.14F;
			this.label18.HyperLink = null;
			this.label18.Left = 3.9F;
			this.label18.Name = "label18";
			this.label18.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label18.Text = "年末残高(1回目)";
			this.label18.Top = 3.749998F;
			this.label18.Width = 0.48F;
			// 
			// label119
			// 
			this.label119.Height = 0.14F;
			this.label119.HyperLink = null;
			this.label119.Left = 3.9F;
			this.label119.Name = "label119";
			this.label119.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label119.Text = "住宅借入金等";
			this.label119.Top = 3.87F;
			this.label119.Width = 0.48F;
			// 
			// label120
			// 
			this.label120.Height = 0.14F;
			this.label120.HyperLink = null;
			this.label120.Left = 3.9F;
			this.label120.Name = "label120";
			this.label120.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label120.Text = "年末残高(2回目)";
			this.label120.Top = 3.97F;
			this.label120.Width = 0.48F;
			// 
			// label121
			// 
			this.label121.Height = 0.14F;
			this.label121.HyperLink = null;
			this.label121.Left = 4.44F;
			this.label121.Name = "label121";
			this.label121.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label121.Text = "旧個人年金";
			this.label121.Top = 3.41F;
			this.label121.Width = 0.42F;
			// 
			// label122
			// 
			this.label122.Height = 0.14F;
			this.label122.HyperLink = null;
			this.label122.Left = 4.44F;
			this.label122.Name = "label122";
			this.label122.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label122.Text = "保険料の金額";
			this.label122.Top = 3.51F;
			this.label122.Width = 0.42F;
			// 
			// label171
			// 
			this.label171.Height = 0.153F;
			this.label171.HyperLink = null;
			this.label171.Left = 5.23F;
			this.label171.Name = "label171";
			this.label171.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label171.Text = "円";
			this.label171.Top = 3.37F;
			this.label171.Width = 0.125F;
			// 
			// label176
			// 
			this.label176.Height = 0.153F;
			this.label176.HyperLink = null;
			this.label176.Left = 5.23F;
			this.label176.Name = "label176";
			this.label176.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label176.Text = "円";
			this.label176.Top = 3.623F;
			this.label176.Width = 0.125F;
			// 
			// label183
			// 
			this.label183.Height = 0.153F;
			this.label183.HyperLink = null;
			this.label183.Left = 5.23F;
			this.label183.Name = "label183";
			this.label183.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label183.Text = "円";
			this.label183.Top = 3.856F;
			this.label183.Width = 0.125F;
			// 
			// line17
			// 
			this.line17.Height = 0F;
			this.line17.Left = 0.19F;
			this.line17.LineWeight = 1F;
			this.line17.Name = "line17";
			this.line17.Top = 2.68F;
			this.line17.Width = 5.19F;
			this.line17.X1 = 0.19F;
			this.line17.X2 = 5.38F;
			this.line17.Y1 = 2.68F;
			this.line17.Y2 = 2.68F;
			// 
			// line19
			// 
			this.line19.Height = 0F;
			this.line19.Left = 0.19F;
			this.line19.LineWeight = 1F;
			this.line19.Name = "line19";
			this.line19.Top = 2.38F;
			this.line19.Width = 5.19F;
			this.line19.X1 = 0.19F;
			this.line19.X2 = 5.38F;
			this.line19.Y1 = 2.38F;
			this.line19.Y2 = 2.38F;
			// 
			// line104
			// 
			this.line104.Height = 0F;
			this.line104.Left = 0.19F;
			this.line104.LineWeight = 1F;
			this.line104.Name = "line104";
			this.line104.Top = 2.21F;
			this.line104.Width = 5.19F;
			this.line104.X1 = 0.19F;
			this.line104.X2 = 5.38F;
			this.line104.Y1 = 2.21F;
			this.line104.Y2 = 2.21F;
			// 
			// line105
			// 
			this.line105.Height = 0.47F;
			this.line105.Left = 1.48F;
			this.line105.LineWeight = 1F;
			this.line105.Name = "line105";
			this.line105.Top = 2.21F;
			this.line105.Width = 0F;
			this.line105.X1 = 1.48F;
			this.line105.X2 = 1.48F;
			this.line105.Y1 = 2.21F;
			this.line105.Y2 = 2.68F;
			// 
			// line106
			// 
			this.line106.Height = 0.47F;
			this.line106.Left = 2.77F;
			this.line106.LineWeight = 1F;
			this.line106.Name = "line106";
			this.line106.Top = 2.21F;
			this.line106.Width = 0F;
			this.line106.X1 = 2.77F;
			this.line106.X2 = 2.77F;
			this.line106.Y1 = 2.21F;
			this.line106.Y2 = 2.68F;
			// 
			// line107
			// 
			this.line107.Height = 1.17F;
			this.line107.Left = 4.06F;
			this.line107.LineWeight = 1F;
			this.line107.Name = "line107";
			this.line107.Top = 1.51F;
			this.line107.Width = 0F;
			this.line107.X1 = 4.06F;
			this.line107.X2 = 4.06F;
			this.line107.Y1 = 1.51F;
			this.line107.Y2 = 2.68F;
			// 
			// label184
			// 
			this.label184.Height = 0.1530001F;
			this.label184.HyperLink = null;
			this.label184.Left = 1.34F;
			this.label184.Name = "label184";
			this.label184.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label184.Text = "円";
			this.label184.Top = 2.39F;
			this.label184.Width = 0.125F;
			// 
			// label185
			// 
			this.label185.Height = 0.153F;
			this.label185.HyperLink = null;
			this.label185.Left = 2.63F;
			this.label185.Name = "label185";
			this.label185.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label185.Text = "円";
			this.label185.Top = 2.39F;
			this.label185.Width = 0.125F;
			// 
			// label186
			// 
			this.label186.Height = 0.153F;
			this.label186.HyperLink = null;
			this.label186.Left = 3.92F;
			this.label186.Name = "label186";
			this.label186.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label186.Text = "円";
			this.label186.Top = 2.39F;
			this.label186.Width = 0.125F;
			// 
			// label187
			// 
			this.label187.Height = 0.15F;
			this.label187.HyperLink = null;
			this.label187.Left = 4.08F;
			this.label187.Name = "label187";
			this.label187.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label187.Text = "住宅借入金等特別控除の額";
			this.label187.Top = 2.22F;
			this.label187.Width = 1.27F;
			// 
			// label188
			// 
			this.label188.Height = 0.153F;
			this.label188.HyperLink = null;
			this.label188.Left = 5.23F;
			this.label188.Name = "label188";
			this.label188.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label188.Text = "円";
			this.label188.Top = 2.39F;
			this.label188.Width = 0.125F;
			// 
			// line108
			// 
			this.line108.Height = 0F;
			this.line108.Left = 0.19F;
			this.line108.LineWeight = 1F;
			this.line108.Name = "line108";
			this.line108.Top = 1.51F;
			this.line108.Width = 5.19F;
			this.line108.X1 = 0.19F;
			this.line108.X2 = 5.38F;
			this.line108.Y1 = 1.51F;
			this.line108.Y2 = 1.51F;
			// 
			// line109
			// 
			this.line109.Height = 0.35F;
			this.line109.Left = 0.425F;
			this.line109.LineWeight = 1F;
			this.line109.Name = "line109";
			this.line109.Top = 1.86F;
			this.line109.Width = 0F;
			this.line109.X1 = 0.425F;
			this.line109.X2 = 0.425F;
			this.line109.Y1 = 1.86F;
			this.line109.Y2 = 2.21F;
			// 
			// line110
			// 
			this.line110.Height = 0F;
			this.line110.Left = 0.66F;
			this.line110.LineWeight = 1F;
			this.line110.Name = "line110";
			this.line110.Top = 1.685F;
			this.line110.Width = 0.235F;
			this.line110.X1 = 0.66F;
			this.line110.X2 = 0.895F;
			this.line110.Y1 = 1.685F;
			this.line110.Y2 = 1.685F;
			// 
			// line111
			// 
			this.line111.Height = 0.5250001F;
			this.line111.Left = 0.66F;
			this.line111.LineWeight = 1F;
			this.line111.Name = "line111";
			this.line111.Top = 1.685F;
			this.line111.Width = 0F;
			this.line111.X1 = 0.66F;
			this.line111.X2 = 0.66F;
			this.line111.Y1 = 1.685F;
			this.line111.Y2 = 2.21F;
			// 
			// label189
			// 
			this.label189.Height = 0.15F;
			this.label189.HyperLink = null;
			this.label189.Left = 1.61F;
			this.label189.Name = "label189";
			this.label189.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label189.Text = "円";
			this.label189.Top = 1.9F;
			this.label189.Width = 0.125F;
			// 
			// line112
			// 
			this.line112.Height = 0.35F;
			this.line112.Left = 2.085F;
			this.line112.LineWeight = 1F;
			this.line112.Name = "line112";
			this.line112.Top = 1.86F;
			this.line112.Width = 0F;
			this.line112.X1 = 2.085F;
			this.line112.X2 = 2.085F;
			this.line112.Y1 = 1.86F;
			this.line112.Y2 = 2.21F;
			// 
			// line113
			// 
			this.line113.Height = 0.45F;
			this.line113.Left = 2.32F;
			this.line113.LineWeight = 1F;
			this.line113.Name = "line113";
			this.line113.Top = 1.76F;
			this.line113.Width = 0F;
			this.line113.X1 = 2.32F;
			this.line113.X2 = 2.32F;
			this.line113.Y1 = 1.76F;
			this.line113.Y2 = 2.21F;
			// 
			// label190
			// 
			this.label190.Height = 0.11F;
			this.label190.HyperLink = null;
			this.label190.Left = 3.675F;
			this.label190.Name = "label190";
			this.label190.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label190.Text = "の数";
			this.label190.Top = 1.74F;
			this.label190.Width = 0.375F;
			// 
			// line114
			// 
			this.line114.Height = 0F;
			this.line114.Left = 4.06F;
			this.line114.LineWeight = 1F;
			this.line114.Name = "line114";
			this.line114.Top = 1.76F;
			this.line114.Width = 0.96F;
			this.line114.X1 = 4.06F;
			this.line114.X2 = 5.02F;
			this.line114.Y1 = 1.76F;
			this.line114.Y2 = 1.76F;
			// 
			// NonResidentNumText
			// 
			this.NonResidentNumText.CanGrow = false;
			this.NonResidentNumText.DataField = "NON_RESIDENT_NUM";
			this.NonResidentNumText.Height = 0.15F;
			this.NonResidentNumText.Left = 5.12F;
			this.NonResidentNumText.Name = "NonResidentNumText";
			this.NonResidentNumText.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.NonResidentNumText.Text = "Z9";
			this.NonResidentNumText.Top = 2.03F;
			this.NonResidentNumText.Width = 0.15F;
			// 
			// label191
			// 
			this.label191.Height = 0.15F;
			this.label191.HyperLink = null;
			this.label191.Left = 5.25F;
			this.label191.Name = "label191";
			this.label191.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label191.Text = "人";
			this.label191.Top = 1.9F;
			this.label191.Width = 0.1F;
			// 
			// line115
			// 
			this.line115.Height = 0F;
			this.line115.Left = 3.017F;
			this.line115.LineWeight = 1F;
			this.line115.Name = "line115";
			this.line115.Top = 0.69F;
			this.line115.Width = 2.362918F;
			this.line115.X1 = 3.017F;
			this.line115.X2 = 5.379918F;
			this.line115.Y1 = 0.69F;
			this.line115.Y2 = 0.69F;
			// 
			// line116
			// 
			this.line116.Height = 0F;
			this.line116.Left = 3.207F;
			this.line116.LineWeight = 1F;
			this.line116.Name = "line116";
			this.line116.Top = 0.81F;
			this.line116.Width = 2.172918F;
			this.line116.X1 = 3.207F;
			this.line116.X2 = 5.379918F;
			this.line116.Y1 = 0.81F;
			this.line116.Y2 = 0.81F;
			// 
			// label6
			// 
			this.label6.Height = 0.4401575F;
			this.label6.HyperLink = null;
			this.label6.Left = 7.396851F;
			this.label6.Name = "label6";
			this.label6.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label6.Text = "寡婦";
			this.label6.Top = 6.209843F;
			this.label6.Width = 0.1251968F;
			// 
			// label7
			// 
			this.label7.Height = 0.44F;
			this.label7.HyperLink = null;
			this.label7.Left = 6.328917F;
			this.label7.Name = "label7";
			this.label7.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label7.Text = "死亡退職";
			this.label7.Top = 6.209714F;
			this.label7.Width = 0.125F;
			// 
			// label8
			// 
			this.label8.Height = 0.44F;
			this.label8.HyperLink = null;
			this.label8.Left = 8.103917F;
			this.label8.Name = "label8";
			this.label8.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label8.Text = "";
			this.label8.Top = 6.209715F;
			this.label8.Width = 0.125F;
			// 
			// label9
			// 
			this.label9.Height = 0.2499999F;
			this.label9.HyperLink = null;
			this.label9.Left = 7.163917F;
			this.label9.Name = "label9";
			this.label9.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label9.Text = "その他";
			this.label9.Top = 6.349715F;
			this.label9.Width = 0.125F;
			// 
			// label12
			// 
			this.label12.Height = 0.2F;
			this.label12.HyperLink = null;
			this.label12.Left = 5.916918F;
			this.label12.Name = "label12";
			this.label12.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label12.Text = "支　払";
			this.label12.Top = 0.3177142F;
			this.label12.Width = 0.292F;
			// 
			// label15
			// 
			this.label15.Height = 0.8200001F;
			this.label15.HyperLink = null;
			this.label15.Left = 6.208918F;
			this.label15.Name = "label15";
			this.label15.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label15.Text = "住所又は居所";
			this.label15.Top = 0.2077145F;
			this.label15.Width = 0.188F;
			// 
			// ylyEdAddress1_2Text
			// 
			this.ylyEdAddress1_2Text.CanGrow = false;
			this.ylyEdAddress1_2Text.DataField = "YLY_ED_ADDRESS1";
			this.ylyEdAddress1_2Text.Height = 0.7779999F;
			this.ylyEdAddress1_2Text.Left = 6.406918F;
			this.ylyEdAddress1_2Text.Name = "ylyEdAddress1_2Text";
			this.ylyEdAddress1_2Text.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.ylyEdAddress1_2Text.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.ylyEdAddress1_2Text.Top = 0.2077145F;
			this.ylyEdAddress1_2Text.Width = 2.329F;
			// 
			// textBox4
			// 
			this.textBox4.CanGrow = false;
			this.textBox4.DataField = "EMP_CODE";
			this.textBox4.Height = 0.1330709F;
			this.textBox4.Left = 9.478999F;
			this.textBox4.Name = "textBox4";
			this.textBox4.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox4.Text = "0000000000";
			this.textBox4.Top = 0.1975007F;
			this.textBox4.Width = 1.494094F;
			// 
			// textBox5
			// 
			this.textBox5.CanGrow = false;
			this.textBox5.DataField = "POST_NAME";
			this.textBox5.Height = 0.156F;
			this.textBox5.Left = 9.444919F;
			this.textBox5.Name = "textBox5";
			this.textBox5.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox5.Text = "ああああああああああ";
			this.textBox5.Top = 0.5107141F;
			this.textBox5.Width = 1.619F;
			// 
			// textBox6
			// 
			this.textBox6.CanGrow = false;
			this.textBox6.DataField = "EMP_REGIST_NAME_KANA";
			this.textBox6.Height = 0.12F;
			this.textBox6.Left = 9.444919F;
			this.textBox6.Name = "textBox6";
			this.textBox6.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox6.Text = "ｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱｱ";
			this.textBox6.Top = 0.6997142F;
			this.textBox6.Width = 1.619F;
			// 
			// label16
			// 
			this.label16.Height = 0.1204724F;
			this.label16.HyperLink = null;
			this.label16.Left = 8.815917F;
			this.label16.Name = "label16";
			this.label16.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label16.Text = "(受給者番号）";
			this.label16.Top = 0.1977143F;
			this.label16.Width = 0.6059055F;
			// 
			// label17
			// 
			this.label17.Height = 0.12F;
			this.label17.HyperLink = null;
			this.label17.Left = 8.935918F;
			this.label17.Name = "label17";
			this.label17.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label17.Text = "(フリガナ）";
			this.label17.Top = 0.7037148F;
			this.label17.Width = 0.543F;
			// 
			// label19
			// 
			this.label19.Height = 0.156F;
			this.label19.HyperLink = null;
			this.label19.Left = 8.815917F;
			this.label19.Name = "label19";
			this.label19.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label19.Text = "(役職名）";
			this.label19.Top = 0.5097146F;
			this.label19.Width = 0.543F;
			// 
			// label21
			// 
			this.label21.Height = 0.15F;
			this.label21.HyperLink = null;
			this.label21.Left = 5.919918F;
			this.label21.Name = "label21";
			this.label21.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label21.Text = "種　　別";
			this.label21.Top = 1.049714F;
			this.label21.Width = 0.92F;
			// 
			// label22
			// 
			this.label22.Height = 0.15F;
			this.label22.HyperLink = null;
			this.label22.Left = 6.864917F;
			this.label22.Name = "label22";
			this.label22.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label22.Text = "支　払　金　額";
			this.label22.Top = 1.049714F;
			this.label22.Width = 1.05F;
			// 
			// label23
			// 
			this.label23.Height = 0.15F;
			this.label23.HyperLink = null;
			this.label23.Left = 7.942913F;
			this.label23.Name = "label23";
			this.label23.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label23.Text = " 給与所得控除後の金額";
			this.label23.Top = 1.015748F;
			this.label23.Width = 1.04F;
			// 
			// label25
			// 
			this.label25.Height = 0.15F;
			this.label25.HyperLink = null;
			this.label25.Left = 9.005919F;
			this.label25.Name = "label25";
			this.label25.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label25.Text = "所得控除の額の合計額";
			this.label25.Top = 1.049714F;
			this.label25.Width = 1.04F;
			// 
			// textBox7
			// 
			this.textBox7.CanGrow = false;
			this.textBox7.DataField = "CLASS";
			this.textBox7.Height = 0.28F;
			this.textBox7.Left = 5.919918F;
			this.textBox7.Name = "textBox7";
			this.textBox7.Style = "font-size: 9pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox7.Text = "ああああああ";
			this.textBox7.Top = 1.219714F;
			this.textBox7.Width = 0.92F;
			// 
			// textBox8
			// 
			this.textBox8.CanGrow = false;
			this.textBox8.DataField = "PAYMNT_AMT";
			this.textBox8.Height = 0.28F;
			this.textBox8.Left = 6.953917F;
			this.textBox8.Name = "textBox8";
			this.textBox8.OutputFormat = "#,##0";
			this.textBox8.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox8.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.textBox8.Top = 1.219714F;
			this.textBox8.Width = 0.85F;
			// 
			// label28
			// 
			this.label28.Height = 0.125F;
			this.label28.HyperLink = null;
			this.label28.Left = 6.864917F;
			this.label28.Name = "label28";
			this.label28.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label28.Text = "内";
			this.label28.Top = 1.219714F;
			this.label28.Width = 0.1F;
			// 
			// label29
			// 
			this.label29.Height = 0.125F;
			this.label29.HyperLink = null;
			this.label29.Left = 7.791917F;
			this.label29.Name = "label29";
			this.label29.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label29.Text = "円";
			this.label29.Top = 1.219714F;
			this.label29.Width = 0.141F;
			// 
			// textBox10
			// 
			this.textBox10.CanGrow = false;
			this.textBox10.DataField = "SLRY_INSM_DED_AMT";
			this.textBox10.Height = 0.28F;
			this.textBox10.Left = 8.031918F;
			this.textBox10.Name = "textBox10";
			this.textBox10.OutputFormat = "#,##0";
			this.textBox10.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox10.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.textBox10.Top = 1.219714F;
			this.textBox10.Width = 0.85F;
			// 
			// label30
			// 
			this.label30.Height = 0.125F;
			this.label30.HyperLink = null;
			this.label30.Left = 8.870917F;
			this.label30.Name = "label30";
			this.label30.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label30.Text = "円";
			this.label30.Top = 1.219714F;
			this.label30.Width = 0.1245001F;
			// 
			// textBox11
			// 
			this.textBox11.CanGrow = false;
			this.textBox11.DataField = "INCM_DED_AMT_SUM";
			this.textBox11.Height = 0.28F;
			this.textBox11.Left = 9.094918F;
			this.textBox11.Name = "textBox11";
			this.textBox11.OutputFormat = "#,##0";
			this.textBox11.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox11.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.textBox11.Top = 1.219714F;
			this.textBox11.Width = 0.85F;
			// 
			// label31
			// 
			this.label31.Height = 0.125F;
			this.label31.HyperLink = null;
			this.label31.Left = 9.933917F;
			this.label31.Name = "label31";
			this.label31.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label31.Text = "円";
			this.label31.Top = 1.219714F;
			this.label31.Width = 0.125F;
			// 
			// label32
			// 
			this.label32.Height = 0.125F;
			this.label32.HyperLink = null;
			this.label32.Left = 10.05892F;
			this.label32.Name = "label32";
			this.label32.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label32.Text = "内";
			this.label32.Top = 1.219714F;
			this.label32.Width = 0.125F;
			// 
			// textBox12
			// 
			this.textBox12.CanGrow = false;
			this.textBox12.DataField = "YLY_COLLECT_TAX";
			this.textBox12.Height = 0.28F;
			this.textBox12.Left = 10.128F;
			this.textBox12.Name = "textBox12";
			this.textBox12.OutputFormat = "#,##0";
			this.textBox12.Style = "font-size: 8pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox12.Text = "ZZ,ZZ6,ZZ6,ZZ6";
			this.textBox12.Top = 1.22F;
			this.textBox12.Width = 0.85F;
			// 
			// label33
			// 
			this.label33.Height = 0.125F;
			this.label33.HyperLink = null;
			this.label33.Left = 10.96492F;
			this.label33.Name = "label33";
			this.label33.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label33.Text = "円";
			this.label33.Top = 1.219714F;
			this.label33.Width = 0.134F;
			// 
			// label34
			// 
			this.label34.Height = 0.15F;
			this.label34.HyperLink = null;
			this.label34.Left = 10.06892F;
			this.label34.Name = "label34";
			this.label34.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label34.Text = "源　泉　徴　収　税　額";
			this.label34.Top = 1.049714F;
			this.label34.Width = 1.03F;
			// 
			// label35
			// 
			this.label35.Height = 0.157F;
			this.label35.HyperLink = null;
			this.label35.Left = 5.928917F;
			this.label35.Name = "label35";
			this.label35.Style = "font-size: 4.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label35.Text = "(源泉)控除対象配偶者";
			this.label35.Top = 1.516714F;
			this.label35.Width = 0.68F;
			// 
			// label36
			// 
			this.label36.Height = 0.15F;
			this.label36.HyperLink = null;
			this.label36.Left = 6.398918F;
			this.label36.Name = "label36";
			this.label36.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label36.Text = "老人";
			this.label36.Top = 1.694714F;
			this.label36.Width = 0.23F;
			// 
			// label39
			// 
			this.label39.Height = 0.14F;
			this.label39.HyperLink = null;
			this.label39.Left = 5.928917F;
			this.label39.Name = "label39";
			this.label39.Style = "font-size: 4pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.label39.Text = "有";
			this.label39.Top = 1.806714F;
			this.label39.Width = 0.23F;
			// 
			// label40
			// 
			this.label40.Height = 0.14F;
			this.label40.HyperLink = null;
			this.label40.Left = 6.163917F;
			this.label40.Name = "label40";
			this.label40.Style = "font-size: 4pt; text-align: center; vertical-align: bottom; ddo-char-set: 1";
			this.label40.Text = "従有";
			this.label40.Top = 1.806714F;
			this.label40.Width = 0.23F;
			// 
			// textBox13
			// 
			this.textBox13.CanGrow = false;
			this.textBox13.DataField = "SPOS_OLD_AGE_TYPE";
			this.textBox13.Height = 0.33F;
			this.textBox13.Left = 6.398918F;
			this.textBox13.Name = "textBox13";
			this.textBox13.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox13.Text = "○";
			this.textBox13.Top = 1.869714F;
			this.textBox13.Width = 0.23F;
			// 
			// textBox14
			// 
			this.textBox14.CanGrow = false;
			this.textBox14.DataField = "DED_SPOS_EXIST";
			this.textBox14.Height = 0.23F;
			this.textBox14.Left = 5.928917F;
			this.textBox14.Name = "textBox14";
			this.textBox14.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox14.Text = "○";
			this.textBox14.Top = 1.969714F;
			this.textBox14.Width = 0.23F;
			// 
			// textBox15
			// 
			this.textBox15.CanGrow = false;
			this.textBox15.DataField = "DED_SPOS_EXIST2";
			this.textBox15.Height = 0.23F;
			this.textBox15.Left = 6.163917F;
			this.textBox15.Name = "textBox15";
			this.textBox15.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox15.Text = "○";
			this.textBox15.Top = 1.969714F;
			this.textBox15.Width = 0.23F;
			// 
			// label123
			// 
			this.label123.Height = 0.157F;
			this.label123.HyperLink = null;
			this.label123.Left = 6.633917F;
			this.label123.Name = "label123";
			this.label123.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label123.Text = "配 偶 者 (特 別)";
			this.label123.Top = 1.527714F;
			this.label123.Width = 0.85F;
			// 
			// textBox16
			// 
			this.textBox16.CanGrow = false;
			this.textBox16.DataField = "SPOS_EXT_DED_AMT";
			this.textBox16.Height = 0.15F;
			this.textBox16.Left = 6.633917F;
			this.textBox16.Name = "textBox16";
			this.textBox16.OutputFormat = "#,##0";
			this.textBox16.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox16.Text = "Z,ZZZ,ZZ9";
			this.textBox16.Top = 2.029714F;
			this.textBox16.Width = 0.7F;
			// 
			// label124
			// 
			this.label124.Height = 0.11F;
			this.label124.HyperLink = null;
			this.label124.Left = 7.593917F;
			this.label124.Name = "label124";
			this.label124.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label124.Text = "控 除 対 象 扶 養 親 族 の 数";
			this.label124.Top = 1.519715F;
			this.label124.Width = 1.7F;
			// 
			// label125
			// 
			this.label125.Height = 0.11F;
			this.label125.HyperLink = null;
			this.label125.Left = 7.593917F;
			this.label125.Name = "label125";
			this.label125.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label125.Text = "（ 配 偶 者 を 除 く 。）";
			this.label125.Top = 1.629714F;
			this.label125.Width = 1.7F;
			// 
			// label126
			// 
			this.label126.Height = 0.1F;
			this.label126.HyperLink = null;
			this.label126.Left = 7.503918F;
			this.label126.Name = "label126";
			this.label126.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label126.Text = "特　定";
			this.label126.Top = 1.774714F;
			this.label126.Width = 0.54F;
			// 
			// label127
			// 
			this.label127.Height = 0.1F;
			this.label127.HyperLink = null;
			this.label127.Left = 8.058917F;
			this.label127.Name = "label127";
			this.label127.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label127.Text = "老　人";
			this.label127.Top = 1.774714F;
			this.label127.Width = 0.77F;
			// 
			// label128
			// 
			this.label128.Height = 0.1F;
			this.label128.HyperLink = null;
			this.label128.Left = 8.848918F;
			this.label128.Name = "label128";
			this.label128.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label128.Text = "その他";
			this.label128.Top = 1.774714F;
			this.label128.Width = 0.53F;
			// 
			// label129
			// 
			this.label129.Height = 0.15F;
			this.label129.HyperLink = null;
			this.label129.Left = 7.698918F;
			this.label129.Name = "label129";
			this.label129.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label129.Text = "人";
			this.label129.Top = 1.899714F;
			this.label129.Width = 0.1F;
			// 
			// textBox17
			// 
			this.textBox17.CanGrow = false;
			this.textBox17.DataField = "SPEC_DPND_NUM";
			this.textBox17.Height = 0.15F;
			this.textBox17.Left = 7.541917F;
			this.textBox17.Name = "textBox17";
			this.textBox17.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox17.Text = "Z6";
			this.textBox17.Top = 2.029714F;
			this.textBox17.Width = 0.15F;
			// 
			// textBox18
			// 
			this.textBox18.CanGrow = false;
			this.textBox18.DataField = "SPEC_DPND_NUM2";
			this.textBox18.Height = 0.15F;
			this.textBox18.Left = 7.818918F;
			this.textBox18.Name = "textBox18";
			this.textBox18.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox18.Text = "Z6";
			this.textBox18.Top = 2.029714F;
			this.textBox18.Width = 0.22F;
			// 
			// label130
			// 
			this.label130.Height = 0.15F;
			this.label130.HyperLink = null;
			this.label130.Left = 7.818918F;
			this.label130.Name = "label130";
			this.label130.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label130.Text = "従人";
			this.label130.Top = 1.899714F;
			this.label130.Width = 0.22F;
			// 
			// label131
			// 
			this.label131.Height = 0.15F;
			this.label131.HyperLink = null;
			this.label131.Left = 8.148917F;
			this.label131.Name = "label131";
			this.label131.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label131.Text = "内";
			this.label131.Top = 1.899714F;
			this.label131.Width = 0.125F;
			// 
			// textBox19
			// 
			this.textBox19.CanGrow = false;
			this.textBox19.DataField = "LIVE_TGT_AGE_PRE_NUM";
			this.textBox19.Height = 0.15F;
			this.textBox19.Left = 8.058917F;
			this.textBox19.Name = "textBox19";
			this.textBox19.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox19.Text = "Z6";
			this.textBox19.Top = 2.029714F;
			this.textBox19.Width = 0.15F;
			// 
			// label132
			// 
			this.label132.Height = 0.15F;
			this.label132.HyperLink = null;
			this.label132.Left = 8.488917F;
			this.label132.Name = "label132";
			this.label132.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label132.Text = "人";
			this.label132.Top = 1.899714F;
			this.label132.Width = 0.1F;
			// 
			// textBox20
			// 
			this.textBox20.CanGrow = false;
			this.textBox20.DataField = "AGE_PRE_NUM";
			this.textBox20.Height = 0.15F;
			this.textBox20.Left = 8.348918F;
			this.textBox20.Name = "textBox20";
			this.textBox20.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox20.Text = "Z6";
			this.textBox20.Top = 2.029714F;
			this.textBox20.Width = 0.15F;
			// 
			// textBox21
			// 
			this.textBox21.CanGrow = false;
			this.textBox21.DataField = "AGE_PRE_NUM2";
			this.textBox21.Height = 0.15F;
			this.textBox21.Left = 8.618918F;
			this.textBox21.Name = "textBox21";
			this.textBox21.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox21.Text = "Z6";
			this.textBox21.Top = 2.029714F;
			this.textBox21.Width = 0.22F;
			// 
			// label133
			// 
			this.label133.Height = 0.125F;
			this.label133.HyperLink = null;
			this.label133.Left = 8.618918F;
			this.label133.Name = "label133";
			this.label133.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label133.Text = "従人";
			this.label133.Top = 1.899714F;
			this.label133.Width = 0.22F;
			// 
			// label134
			// 
			this.label134.Height = 0.15F;
			this.label134.HyperLink = null;
			this.label134.Left = 9.028918F;
			this.label134.Name = "label134";
			this.label134.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label134.Text = "人";
			this.label134.Top = 1.899714F;
			this.label134.Width = 0.1F;
			// 
			// textBox22
			// 
			this.textBox22.CanGrow = false;
			this.textBox22.DataField = "OTHERS_DPND_NUM";
			this.textBox22.Height = 0.15F;
			this.textBox22.Left = 8.908917F;
			this.textBox22.Name = "textBox22";
			this.textBox22.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox22.Text = "Z6";
			this.textBox22.Top = 2.029714F;
			this.textBox22.Width = 0.15F;
			// 
			// label135
			// 
			this.label135.Height = 0.125F;
			this.label135.HyperLink = null;
			this.label135.Left = 9.168918F;
			this.label135.Name = "label135";
			this.label135.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label135.Text = "従人";
			this.label135.Top = 1.899714F;
			this.label135.Width = 0.22F;
			// 
			// textBox23
			// 
			this.textBox23.CanGrow = false;
			this.textBox23.DataField = "OTHERS_DPND_NUM2";
			this.textBox23.Height = 0.15F;
			this.textBox23.Left = 9.168918F;
			this.textBox23.Name = "textBox23";
			this.textBox23.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox23.Text = "Z6";
			this.textBox23.Top = 2.029714F;
			this.textBox23.Width = 0.22F;
			// 
			// label136
			// 
			this.label136.Height = 0.11F;
			this.label136.HyperLink = null;
			this.label136.Left = 9.798917F;
			this.label136.Name = "label136";
			this.label136.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label136.Text = "障 害 者 の 数";
			this.label136.Top = 1.519715F;
			this.label136.Width = 0.94F;
			// 
			// label137
			// 
			this.label137.Height = 0.1F;
			this.label137.HyperLink = null;
			this.label137.Left = 9.798917F;
			this.label137.Name = "label137";
			this.label137.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label137.Text = "特 別";
			this.label137.Top = 1.774714F;
			this.label137.Width = 0.62F;
			// 
			// textBox24
			// 
			this.textBox24.CanGrow = false;
			this.textBox24.DataField = "LIVE_TGT_EXT_HANDI_NUM";
			this.textBox24.Height = 0.15F;
			this.textBox24.Left = 9.878919F;
			this.textBox24.Name = "textBox24";
			this.textBox24.Style = "font-size: 7pt; text-align: center; vertical-align: bottom; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox24.Text = "Z6";
			this.textBox24.Top = 2.029714F;
			this.textBox24.Width = 0.15F;
			// 
			// textBox25
			// 
			this.textBox25.CanGrow = false;
			this.textBox25.DataField = "EXT_HANDI_NUM";
			this.textBox25.Height = 0.15F;
			this.textBox25.Left = 10.18892F;
			this.textBox25.Name = "textBox25";
			this.textBox25.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox25.Text = "Z6";
			this.textBox25.Top = 2.029714F;
			this.textBox25.Width = 0.15F;
			// 
			// label138
			// 
			this.label138.Height = 0.15F;
			this.label138.HyperLink = null;
			this.label138.Left = 10.29892F;
			this.label138.Name = "label138";
			this.label138.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label138.Text = "人";
			this.label138.Top = 1.899714F;
			this.label138.Width = 0.1F;
			// 
			// label139
			// 
			this.label139.Height = 0.15F;
			this.label139.HyperLink = null;
			this.label139.Left = 9.968919F;
			this.label139.Name = "label139";
			this.label139.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label139.Text = "内";
			this.label139.Top = 1.899714F;
			this.label139.Width = 0.125F;
			// 
			// label140
			// 
			this.label140.Height = 0.11F;
			this.label140.HyperLink = null;
			this.label140.Left = 9.798917F;
			this.label140.Name = "label140";
			this.label140.Style = "font-size: 6pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label140.Text = "（ 本 人 を 除 く。）";
			this.label140.Top = 1.629714F;
			this.label140.Width = 0.94F;
			// 
			// label141
			// 
			this.label141.Height = 0.1F;
			this.label141.HyperLink = null;
			this.label141.Left = 10.43892F;
			this.label141.Name = "label141";
			this.label141.Style = "font-size: 4pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label141.Text = "その他";
			this.label141.Top = 1.774714F;
			this.label141.Width = 0.3F;
			// 
			// label142
			// 
			this.label142.Height = 0.15F;
			this.label142.HyperLink = null;
			this.label142.Left = 10.62892F;
			this.label142.Name = "label142";
			this.label142.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label142.Text = "人";
			this.label142.Top = 1.899714F;
			this.label142.Width = 0.1F;
			// 
			// textBox26
			// 
			this.textBox26.CanGrow = false;
			this.textBox26.DataField = "HANDI_NUM";
			this.textBox26.Height = 0.15F;
			this.textBox26.Left = 10.50892F;
			this.textBox26.Name = "textBox26";
			this.textBox26.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox26.Text = "Z6";
			this.textBox26.Top = 2.029714F;
			this.textBox26.Width = 0.15F;
			// 
			// label143
			// 
			this.label143.Height = 0.15F;
			this.label143.HyperLink = null;
			this.label143.Left = 5.928917F;
			this.label143.Name = "label143";
			this.label143.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label143.Text = "社会保険料等の金額";
			this.label143.Top = 2.219714F;
			this.label143.Width = 1.27F;
			// 
			// textBox27
			// 
			this.textBox27.CanGrow = false;
			this.textBox27.DataField = "SML_SCALE_COMP_CPRAT_AMT";
			this.textBox27.Height = 0.15F;
			this.textBox27.Left = 6.078917F;
			this.textBox27.Name = "textBox27";
			this.textBox27.OutputFormat = "#,##0";
			this.textBox27.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox27.Text = "ZZ,ZZZ,ZZ6";
			this.textBox27.Top = 2.389714F;
			this.textBox27.Width = 1F;
			// 
			// label144
			// 
			this.label144.Height = 0.15F;
			this.label144.HyperLink = null;
			this.label144.Left = 7.218917F;
			this.label144.Name = "label144";
			this.label144.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label144.Text = "生命保険料の控除額";
			this.label144.Top = 2.219714F;
			this.label144.Width = 1.27F;
			// 
			// textBox28
			// 
			this.textBox28.CanGrow = false;
			this.textBox28.DataField = "LIFE_INS_DED_AMT";
			this.textBox28.Height = 0.15F;
			this.textBox28.Left = 7.368918F;
			this.textBox28.Name = "textBox28";
			this.textBox28.OutputFormat = "#,##0";
			this.textBox28.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox28.Text = "ZZ,ZZZ,ZZ6";
			this.textBox28.Top = 2.521714F;
			this.textBox28.Width = 1F;
			// 
			// textBox29
			// 
			this.textBox29.CanGrow = false;
			this.textBox29.DataField = "HOUSING_OBT_DED_AMT";
			this.textBox29.Height = 0.15F;
			this.textBox29.Left = 9.948918F;
			this.textBox29.Name = "textBox29";
			this.textBox29.OutputFormat = "#,##0";
			this.textBox29.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox29.Text = "ZZ,ZZZ,ZZ6";
			this.textBox29.Top = 2.521714F;
			this.textBox29.Width = 1F;
			// 
			// textBox30
			// 
			this.textBox30.CanGrow = false;
			this.textBox30.DataField = "SPOS_SUM_INCM_AMT";
			this.textBox30.Height = 0.153F;
			this.textBox30.Left = 8.648917F;
			this.textBox30.Name = "textBox30";
			this.textBox30.OutputFormat = "#,##0";
			this.textBox30.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox30.Text = "ZZ,ZZZ,ZZ6";
			this.textBox30.Top = 4.228714F;
			this.textBox30.Width = 0.45F;
			// 
			// textBox31
			// 
			this.textBox31.CanGrow = false;
			this.textBox31.DataField = "LIFE_INS_PENS_AMT";
			this.textBox31.Height = 0.15F;
			this.textBox31.Left = 10.63192F;
			this.textBox31.Name = "textBox31";
			this.textBox31.OutputFormat = "#,##0";
			this.textBox31.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox31.Text = "ZZ,ZZZ,ZZ6";
			this.textBox31.Top = 3.467715F;
			this.textBox31.Width = 0.45F;
			// 
			// textBox32
			// 
			this.textBox32.CanGrow = false;
			this.textBox32.DataField = "NOLF_INS_LONG_PROD_AMT";
			this.textBox32.Height = 0.153F;
			this.textBox32.Left = 10.64882F;
			this.textBox32.Name = "textBox32";
			this.textBox32.OutputFormat = "#,##0";
			this.textBox32.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox32.Text = "ZZ,ZZZ,ZZ6";
			this.textBox32.Top = 4.149212F;
			this.textBox32.Width = 0.45F;
			// 
			// label145
			// 
			this.label145.Height = 0.165F;
			this.label145.HyperLink = null;
			this.label145.Left = 6.633917F;
			this.label145.Name = "label145";
			this.label145.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label145.Text = "乙";
			this.label145.Top = 6.249714F;
			this.label145.Width = 0.235F;
			// 
			// label146
			// 
			this.label146.Height = 0.165F;
			this.label146.HyperLink = null;
			this.label146.Left = 6.633917F;
			this.label146.Name = "label146";
			this.label146.Style = "font-size: 6pt; text-align: center; vertical-align: bottom; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label146.Text = "欄";
			this.label146.Top = 6.439714F;
			this.label146.Width = 0.235F;
			// 
			// label147
			// 
			this.label147.Height = 0.09F;
			this.label147.HyperLink = null;
			this.label147.Left = 6.868917F;
			this.label147.Name = "label147";
			this.label147.Style = "font-size: 4pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label147.Text = "本人が障害者";
			this.label147.Top = 6.209714F;
			this.label147.Width = 0.47F;
			// 
			// label148
			// 
			this.label148.Height = 0.21F;
			this.label148.HyperLink = null;
			this.label148.Left = 6.928917F;
			this.label148.Name = "label148";
			this.label148.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label148.Text = "特別";
			this.label148.Top = 6.369714F;
			this.label148.Width = 0.1249999F;
			// 
			// label150
			// 
			this.label150.Height = 0.4401575F;
			this.label150.HyperLink = null;
			this.label150.Left = 7.628741F;
			this.label150.Name = "label150";
			this.label150.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label150.Text = "ひとり親";
			this.label150.Top = 6.209843F;
			this.label150.Width = 0.1248032F;
			// 
			// label151
			// 
			this.label151.Height = 0.4401575F;
			this.label151.HyperLink = null;
			this.label151.Left = 7.865748F;
			this.label151.Name = "label151";
			this.label151.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label151.Text = "勤労学生";
			this.label151.Top = 6.209843F;
			this.label151.Width = 0.1251968F;
			// 
			// label153
			// 
			this.label153.Height = 0.22F;
			this.label153.HyperLink = null;
			this.label153.Left = 8.278918F;
			this.label153.Name = "label153";
			this.label153.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label153.Text = "就職";
			this.label153.Top = 6.429714F;
			this.label153.Width = 0.235F;
			// 
			// label154
			// 
			this.label154.Height = 0.22F;
			this.label154.HyperLink = null;
			this.label154.Left = 8.983918F;
			this.label154.Name = "label154";
			this.label154.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label154.Text = "月";
			this.label154.Top = 6.429714F;
			this.label154.Width = 0.235F;
			// 
			// label155
			// 
			this.label155.Height = 0.22F;
			this.label155.HyperLink = null;
			this.label155.Left = 8.748918F;
			this.label155.Name = "label155";
			this.label155.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label155.Text = "年";
			this.label155.Top = 6.429714F;
			this.label155.Width = 0.235F;
			// 
			// label156
			// 
			this.label156.Height = 0.22F;
			this.label156.HyperLink = null;
			this.label156.Left = 9.218917F;
			this.label156.Name = "label156";
			this.label156.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label156.Text = "日";
			this.label156.Top = 6.429714F;
			this.label156.Width = 0.235F;
			// 
			// label157
			// 
			this.label157.Height = 0.22F;
			this.label157.HyperLink = null;
			this.label157.Left = 9.453918F;
			this.label157.Name = "label157";
			this.label157.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label157.Text = "受 給 者 生 年 月 日";
			this.label157.Top = 6.209714F;
			this.label157.Width = 1.655F;
			// 
			// label158
			// 
			this.label158.Height = 0.2200788F;
			this.label158.HyperLink = null;
			this.label158.Left = 9.453918F;
			this.label158.Name = "label158";
			this.label158.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label158.Text = "元号";
			this.label158.Top = 6.429714F;
			this.label158.Width = 0.9401575F;
			// 
			// label159
			// 
			this.label159.Height = 0.22F;
			this.label159.HyperLink = null;
			this.label159.Left = 10.39392F;
			this.label159.Name = "label159";
			this.label159.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label159.Text = "年";
			this.label159.Top = 6.429714F;
			this.label159.Width = 0.235F;
			// 
			// textBox33
			// 
			this.textBox33.CanGrow = false;
			this.textBox33.DataField = "EMP_REGIST_NAME";
			this.textBox33.Height = 0.21F;
			this.textBox33.Left = 9.444919F;
			this.textBox33.Name = "textBox33";
			this.textBox33.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox33.Text = "あいうえおかきくけこあいうえお";
			this.textBox33.Top = 0.819714F;
			this.textBox33.Width = 1.619F;
			// 
			// label160
			// 
			this.label160.Height = 0.22F;
			this.label160.HyperLink = null;
			this.label160.Left = 8.278918F;
			this.label160.Name = "label160";
			this.label160.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label160.Text = "中 途 就 ・ 退 職";
			this.label160.Top = 6.209714F;
			this.label160.Width = 1.175F;
			// 
			// textBox34
			// 
			this.textBox34.CanGrow = false;
			this.textBox34.DataField = "MINR_TYPE";
			this.textBox34.Height = 0.25F;
			this.textBox34.Left = 5.918918F;
			this.textBox34.Name = "textBox34";
			this.textBox34.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox34.Text = "0";
			this.textBox34.Top = 6.649715F;
			this.textBox34.Width = 0.235F;
			// 
			// textBox35
			// 
			this.textBox35.CanGrow = false;
			this.textBox35.DataField = "LATTER";
			this.textBox35.Height = 0.25F;
			this.textBox35.Left = 6.633917F;
			this.textBox35.Name = "textBox35";
			this.textBox35.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox35.Text = "0";
			this.textBox35.Top = 6.649715F;
			this.textBox35.Width = 0.235F;
			// 
			// textBox36
			// 
			this.textBox36.CanGrow = false;
			this.textBox36.DataField = "EXT_HANDI_TYPE";
			this.textBox36.Height = 0.25F;
			this.textBox36.Left = 6.868917F;
			this.textBox36.Name = "textBox36";
			this.textBox36.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox36.Text = "0";
			this.textBox36.Top = 6.649715F;
			this.textBox36.Width = 0.235F;
			// 
			// textBox37
			// 
			this.textBox37.CanGrow = false;
			this.textBox37.DataField = "HANDI_TYPE";
			this.textBox37.Height = 0.25F;
			this.textBox37.Left = 7.103918F;
			this.textBox37.Name = "textBox37";
			this.textBox37.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox37.Text = "0";
			this.textBox37.Top = 6.649715F;
			this.textBox37.Width = 0.235F;
			// 
			// textBox38
			// 
			this.textBox38.CanGrow = false;
			this.textBox38.DataField = "WIDOW_TYPE";
			this.textBox38.Height = 0.25F;
			this.textBox38.Left = 7.338917F;
			this.textBox38.Name = "textBox38";
			this.textBox38.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox38.Text = "0";
			this.textBox38.Top = 6.649715F;
			this.textBox38.Width = 0.235F;
			// 
			// textBox39
			// 
			this.textBox39.CanGrow = false;
			this.textBox39.DataField = "EXT_WIDOW_TYPE";
			this.textBox39.Height = 0.25F;
			this.textBox39.Left = 7.573918F;
			this.textBox39.Name = "textBox39";
			this.textBox39.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox39.Text = "0";
			this.textBox39.Top = 6.649715F;
			this.textBox39.Width = 0.235F;
			// 
			// textBox40
			// 
			this.textBox40.CanGrow = false;
			this.textBox40.DataField = "WIDOM_TYPE";
			this.textBox40.Height = 0.25F;
			this.textBox40.Left = 7.808917F;
			this.textBox40.Name = "textBox40";
			this.textBox40.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox40.Text = "0";
			this.textBox40.Top = 6.649715F;
			this.textBox40.Width = 0.235F;
			// 
			// textBox41
			// 
			this.textBox41.CanGrow = false;
			this.textBox41.DataField = "WRK_STD_TYPE";
			this.textBox41.Height = 0.25F;
			this.textBox41.Left = 8.043918F;
			this.textBox41.Name = "textBox41";
			this.textBox41.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox41.Text = "0";
			this.textBox41.Top = 6.649715F;
			this.textBox41.Width = 0.235F;
			// 
			// label161
			// 
			this.label161.Height = 0.166F;
			this.label161.HyperLink = null;
			this.label161.Left = 5.918918F;
			this.label161.Name = "label161";
			this.label161.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label161.Text = "支";
			this.label161.Top = 6.999714F;
			this.label161.Width = 0.235F;
			// 
			// label162
			// 
			this.label162.Height = 0.166F;
			this.label162.HyperLink = null;
			this.label162.Left = 5.918918F;
			this.label162.Name = "label162";
			this.label162.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label162.Text = "払";
			this.label162.Top = 7.199714F;
			this.label162.Width = 0.235F;
			// 
			// label163
			// 
			this.label163.Height = 0.166F;
			this.label163.HyperLink = null;
			this.label163.Left = 5.918918F;
			this.label163.Name = "label163";
			this.label163.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label163.Text = "者";
			this.label163.Top = 7.399715F;
			this.label163.Width = 0.235F;
			// 
			// textBox42
			// 
			this.textBox42.CanGrow = false;
			this.textBox42.DataField = "PAYMNT_ADDRESS";
			this.textBox42.Height = 0.332F;
			this.textBox42.Left = 6.633917F;
			this.textBox42.Name = "textBox42";
			this.textBox42.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.textBox42.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.textBox42.Top = 7.099715F;
			this.textBox42.Width = 4.312F;
			// 
			// textBox43
			// 
			this.textBox43.CanGrow = false;
			this.textBox43.DataField = "PAYMNT_NAME";
			this.textBox43.Height = 0.2F;
			this.textBox43.Left = 6.633917F;
			this.textBox43.MultiLine = false;
			this.textBox43.Name = "textBox43";
			this.textBox43.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.textBox43.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.textBox43.Top = 7.399715F;
			this.textBox43.Width = 3.125F;
			// 
			// label164
			// 
			this.label164.Height = 0.2F;
			this.label164.HyperLink = null;
			this.label164.Left = 9.778918F;
			this.label164.Name = "label164";
			this.label164.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label164.Text = "（電話）";
			this.label164.Top = 7.399715F;
			this.label164.Width = 0.375F;
			// 
			// textBox44
			// 
			this.textBox44.CanGrow = false;
			this.textBox44.DataField = "PAYMNT_PHONE";
			this.textBox44.Height = 0.2F;
			this.textBox44.Left = 10.17892F;
			this.textBox44.Name = "textBox44";
			this.textBox44.Style = "font-size: 8pt; text-align: left; vertical-align: middle; white-space: nowrap; dd" +
    "o-char-set: 1";
			this.textBox44.Text = "99999999999999";
			this.textBox44.Top = 7.399715F;
			this.textBox44.Width = 0.813F;
			// 
			// label165
			// 
			this.label165.Height = 0.15F;
			this.label165.HyperLink = null;
			this.label165.Left = 6.153918F;
			this.label165.Name = "label165";
			this.label165.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label165.Text = "住所（居所）";
			this.label165.Top = 7.099715F;
			this.label165.Width = 0.51F;
			// 
			// label166
			// 
			this.label166.Height = 0.15F;
			this.label166.HyperLink = null;
			this.label166.Left = 6.153918F;
			this.label166.Name = "label166";
			this.label166.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label166.Text = "又は所在地";
			this.label166.Top = 7.249714F;
			this.label166.Width = 0.48F;
			// 
			// label167
			// 
			this.label167.Height = 0.1999998F;
			this.label167.HyperLink = null;
			this.label167.Left = 6.153918F;
			this.label167.Name = "label167";
			this.label167.Style = "font-size: 5pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label167.Text = "氏名又は名称";
			this.label167.Top = 7.399715F;
			this.label167.Width = 0.48F;
			// 
			// label168
			// 
			this.label168.Height = 0.2F;
			this.label168.HyperLink = null;
			this.label168.Left = 5.916918F;
			this.label168.Name = "label168";
			this.label168.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label168.Text = "を受け";
			this.label168.Top = 0.517714F;
			this.label168.Width = 0.292F;
			// 
			// label169
			// 
			this.label169.Height = 0.2F;
			this.label169.HyperLink = null;
			this.label169.Left = 5.916918F;
			this.label169.Name = "label169";
			this.label169.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label169.Text = "る　者";
			this.label169.Top = 0.7177148F;
			this.label169.Width = 0.292F;
			// 
			// label170
			// 
			this.label170.Height = 0.33F;
			this.label170.HyperLink = null;
			this.label170.Left = 8.755919F;
			this.label170.Name = "label170";
			this.label170.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label170.Text = "氏名";
			this.label170.Top = 0.6997142F;
			this.label170.Width = 0.17F;
			// 
			// label172
			// 
			this.label172.Height = 0.157F;
			this.label172.HyperLink = null;
			this.label172.Left = 5.928917F;
			this.label172.Name = "label172";
			this.label172.Style = "font-size: 4.5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label172.Text = "の 有 無 等";
			this.label172.Top = 1.662714F;
			this.label172.Width = 0.4790001F;
			// 
			// label173
			// 
			this.label173.Height = 0.157F;
			this.label173.HyperLink = null;
			this.label173.Left = 6.633917F;
			this.label173.Name = "label173";
			this.label173.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label173.Text = "控  除  の  額";
			this.label173.Top = 1.707714F;
			this.label173.Width = 0.85F;
			// 
			// label174
			// 
			this.label174.Height = 0.15F;
			this.label174.HyperLink = null;
			this.label174.Left = 8.508918F;
			this.label174.Name = "label174";
			this.label174.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label174.Text = "地震保険料の控除額";
			this.label174.Top = 2.219714F;
			this.label174.Width = 1.27F;
			// 
			// textBox45
			// 
			this.textBox45.CanGrow = false;
			this.textBox45.DataField = "NOLF_INS_DED_AMT";
			this.textBox45.Height = 0.15F;
			this.textBox45.Left = 8.658917F;
			this.textBox45.Name = "textBox45";
			this.textBox45.OutputFormat = "#,##0";
			this.textBox45.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox45.Text = "ZZ,ZZZ,ZZ6";
			this.textBox45.Top = 2.521714F;
			this.textBox45.Width = 1F;
			// 
			// textBox46
			// 
			this.textBox46.CanGrow = false;
			this.textBox46.DataField = "DEATH_RETIRE_TYPE";
			this.textBox46.Height = 0.25F;
			this.textBox46.Left = 6.313918F;
			this.textBox46.Name = "textBox46";
			this.textBox46.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox46.Text = "0";
			this.textBox46.Top = 6.649715F;
			this.textBox46.Width = 0.16F;
			// 
			// textBox47
			// 
			this.textBox47.CanGrow = false;
			this.textBox47.DataField = "DISASTER_TYPE";
			this.textBox47.Height = 0.25F;
			this.textBox47.Left = 6.473917F;
			this.textBox47.Name = "textBox47";
			this.textBox47.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox47.Text = "0";
			this.textBox47.Top = 6.649715F;
			this.textBox47.Width = 0.16F;
			// 
			// label175
			// 
			this.label175.Height = 0.29F;
			this.label175.HyperLink = null;
			this.label175.Left = 6.473917F;
			this.label175.Name = "label175";
			this.label175.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label175.Text = "災害者";
			this.label175.Top = 6.269715F;
			this.label175.Width = 0.135F;
			// 
			// textBox48
			// 
			this.textBox48.CanGrow = false;
			this.textBox48.DataField = "FOREIGN_TYPE";
			this.textBox48.Height = 0.25F;
			this.textBox48.Left = 6.153918F;
			this.textBox48.Name = "textBox48";
			this.textBox48.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox48.Text = "0";
			this.textBox48.Top = 6.649715F;
			this.textBox48.Width = 0.16F;
			// 
			// label177
			// 
			this.label177.Height = 0.29F;
			this.label177.HyperLink = null;
			this.label177.Left = 6.158917F;
			this.label177.Name = "label177";
			this.label177.Style = "font-size: 6pt; text-align: center; text-decoration: none; vertical-align: top; w" +
    "hite-space: inherit; ddo-char-set: 1";
			this.label177.Text = "外国人";
			this.label177.Top = 6.269715F;
			this.label177.Width = 0.135F;
			// 
			// textBox49
			// 
			this.textBox49.CanGrow = false;
			this.textBox49.DataField = "HALF_EMPLOY_TYPE";
			this.textBox49.Height = 0.25F;
			this.textBox49.Left = 8.278918F;
			this.textBox49.Name = "textBox49";
			this.textBox49.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox49.Text = "0";
			this.textBox49.Top = 6.649715F;
			this.textBox49.Width = 0.235F;
			// 
			// label178
			// 
			this.label178.Height = 0.22F;
			this.label178.HyperLink = null;
			this.label178.Left = 8.513917F;
			this.label178.Name = "label178";
			this.label178.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label178.Text = "退職";
			this.label178.Top = 6.429714F;
			this.label178.Width = 0.235F;
			// 
			// textBox50
			// 
			this.textBox50.CanGrow = false;
			this.textBox50.DataField = "HALF_RETIRE_TYPE";
			this.textBox50.Height = 0.25F;
			this.textBox50.Left = 8.513917F;
			this.textBox50.Name = "textBox50";
			this.textBox50.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox50.Text = "0";
			this.textBox50.Top = 6.649715F;
			this.textBox50.Width = 0.235F;
			// 
			// textBox51
			// 
			this.textBox51.CanGrow = false;
			this.textBox51.DataField = "HALF_EM_RE_DATE_YEAR";
			this.textBox51.Height = 0.25F;
			this.textBox51.Left = 8.748918F;
			this.textBox51.Name = "textBox51";
			this.textBox51.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox51.Text = "0";
			this.textBox51.Top = 6.649715F;
			this.textBox51.Width = 0.235F;
			// 
			// textBox52
			// 
			this.textBox52.CanGrow = false;
			this.textBox52.DataField = "HALF_EM_RE_DATE_MONTH";
			this.textBox52.Height = 0.25F;
			this.textBox52.Left = 8.983918F;
			this.textBox52.Name = "textBox52";
			this.textBox52.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox52.Text = "0";
			this.textBox52.Top = 6.649715F;
			this.textBox52.Width = 0.235F;
			// 
			// textBox53
			// 
			this.textBox53.CanGrow = false;
			this.textBox53.DataField = "HALF_EM_RE_DATE_DAY";
			this.textBox53.Height = 0.25F;
			this.textBox53.Left = 9.218917F;
			this.textBox53.Name = "textBox53";
			this.textBox53.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox53.Text = "0";
			this.textBox53.Top = 6.649715F;
			this.textBox53.Width = 0.235F;
			// 
			// label182
			// 
			this.label182.Height = 0.22F;
			this.label182.HyperLink = null;
			this.label182.Left = 10.62892F;
			this.label182.Name = "label182";
			this.label182.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label182.Text = "月";
			this.label182.Top = 6.429714F;
			this.label182.Width = 0.235F;
			// 
			// label196
			// 
			this.label196.Height = 0.22F;
			this.label196.HyperLink = null;
			this.label196.Left = 10.86392F;
			this.label196.Name = "label196";
			this.label196.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label196.Text = "日";
			this.label196.Top = 6.429714F;
			this.label196.Width = 0.235F;
			// 
			// textBox54
			// 
			this.textBox54.CanGrow = false;
			this.textBox54.DataField = "BIRTH_NAME_OF_ERA_NAME";
			this.textBox54.Height = 0.25F;
			this.textBox54.Left = 9.453918F;
			this.textBox54.Name = "textBox54";
			this.textBox54.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox54.Text = "あい";
			this.textBox54.Top = 6.649715F;
			this.textBox54.Width = 0.9401575F;
			// 
			// textBox58
			// 
			this.textBox58.CanGrow = false;
			this.textBox58.DataField = "BIRTH_DAY_YEAR";
			this.textBox58.Height = 0.25F;
			this.textBox58.Left = 10.39392F;
			this.textBox58.Name = "textBox58";
			this.textBox58.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox58.Text = "0";
			this.textBox58.Top = 6.649715F;
			this.textBox58.Width = 0.235F;
			// 
			// textBox59
			// 
			this.textBox59.CanGrow = false;
			this.textBox59.DataField = "BIRTH_DAY_MONTH";
			this.textBox59.Height = 0.25F;
			this.textBox59.Left = 10.62892F;
			this.textBox59.Name = "textBox59";
			this.textBox59.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox59.Text = "0";
			this.textBox59.Top = 6.649715F;
			this.textBox59.Width = 0.235F;
			// 
			// textBox60
			// 
			this.textBox60.CanGrow = false;
			this.textBox60.DataField = "BIRTH_DAY_DAY";
			this.textBox60.Height = 0.25F;
			this.textBox60.Left = 10.86392F;
			this.textBox60.Name = "textBox60";
			this.textBox60.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox60.Text = "0";
			this.textBox60.Top = 6.649715F;
			this.textBox60.Width = 0.235F;
			// 
			// textBox61
			// 
			this.textBox61.CanGrow = false;
			this.textBox61.DataField = "SOC_INS_DED_AMT";
			this.textBox61.Height = 0.15F;
			this.textBox61.Left = 6.078917F;
			this.textBox61.Name = "textBox61";
			this.textBox61.OutputFormat = "#,##0";
			this.textBox61.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox61.Text = "ZZ,ZZZ,ZZ6";
			this.textBox61.Top = 2.521714F;
			this.textBox61.Width = 1F;
			// 
			// label197
			// 
			this.label197.Height = 0.44F;
			this.label197.HyperLink = null;
			this.label197.Left = 5.978918F;
			this.label197.Name = "label197";
			this.label197.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label197.Text = "未成年者";
			this.label197.Top = 6.209714F;
			this.label197.Width = 0.125F;
			// 
			// line4
			// 
			this.line4.Height = 0F;
			this.line4.Left = 5.916999F;
			this.line4.LineWeight = 1F;
			this.line4.Name = "line4";
			this.line4.Top = 7.599715F;
			this.line4.Width = 5.191921F;
			this.line4.X1 = 5.916999F;
			this.line4.X2 = 11.10892F;
			this.line4.Y1 = 7.599715F;
			this.line4.Y2 = 7.599715F;
			// 
			// line5
			// 
			this.line5.Height = 0F;
			this.line5.Left = 5.916999F;
			this.line5.LineWeight = 1F;
			this.line5.Name = "line5";
			this.line5.Top = 0.1980004F;
			this.line5.Width = 5.187001F;
			this.line5.X1 = 5.916999F;
			this.line5.X2 = 11.104F;
			this.line5.Y1 = 0.1980004F;
			this.line5.Y2 = 0.1980004F;
			// 
			// line6
			// 
			this.line6.Height = 0F;
			this.line6.Left = 5.918918F;
			this.line6.LineWeight = 1F;
			this.line6.Name = "line6";
			this.line6.Top = 1.039714F;
			this.line6.Width = 5.190002F;
			this.line6.X1 = 5.918918F;
			this.line6.X2 = 11.10892F;
			this.line6.Y1 = 1.039714F;
			this.line6.Y2 = 1.039714F;
			// 
			// line7
			// 
			this.line7.Height = 0F;
			this.line7.Left = 7.493918F;
			this.line7.LineWeight = 1F;
			this.line7.Name = "line7";
			this.line7.Top = 1.759714F;
			this.line7.Width = 1.9F;
			this.line7.X1 = 7.493918F;
			this.line7.X2 = 9.393918F;
			this.line7.Y1 = 1.759714F;
			this.line7.Y2 = 1.759714F;
			// 
			// line8
			// 
			this.line8.Height = 0F;
			this.line8.Left = 5.916999F;
			this.line8.LineWeight = 1F;
			this.line8.Name = "line8";
			this.line8.Top = 6.209714F;
			this.line8.Width = 5.187001F;
			this.line8.X1 = 5.916999F;
			this.line8.X2 = 11.104F;
			this.line8.Y1 = 6.209714F;
			this.line8.Y2 = 6.209714F;
			// 
			// line9
			// 
			this.line9.Height = 7.589084F;
			this.line9.Left = 11.10892F;
			this.line9.LineWeight = 1F;
			this.line9.Name = "line9";
			this.line9.Top = 0.01062992F;
			this.line9.Width = 0.0001401901F;
			this.line9.X1 = 11.10906F;
			this.line9.X2 = 11.10892F;
			this.line9.Y1 = 0.01062992F;
			this.line9.Y2 = 7.599714F;
			// 
			// line10
			// 
			this.line10.Height = 0.8417135F;
			this.line10.Left = 6.208999F;
			this.line10.LineWeight = 1F;
			this.line10.Name = "line10";
			this.line10.Top = 0.1980004F;
			this.line10.Width = 0F;
			this.line10.X1 = 6.208999F;
			this.line10.X2 = 6.208999F;
			this.line10.Y1 = 0.1980004F;
			this.line10.Y2 = 1.039714F;
			// 
			// line11
			// 
			this.line11.Height = 0.8417135F;
			this.line11.Left = 6.396999F;
			this.line11.LineWeight = 1F;
			this.line11.Name = "line11";
			this.line11.Top = 0.1980004F;
			this.line11.Width = 0F;
			this.line11.X1 = 6.396999F;
			this.line11.X2 = 6.396999F;
			this.line11.Y1 = 0.1980004F;
			this.line11.Y2 = 1.039714F;
			// 
			// line12
			// 
			this.line12.Height = 0.8417135F;
			this.line12.Left = 8.745999F;
			this.line12.LineWeight = 1F;
			this.line12.Name = "line12";
			this.line12.Top = 0.1980004F;
			this.line12.Width = 0F;
			this.line12.X1 = 8.745999F;
			this.line12.X2 = 8.745999F;
			this.line12.Y1 = 0.1980004F;
			this.line12.Y2 = 1.039714F;
			// 
			// line13
			// 
			this.line13.Height = 0.35F;
			this.line13.Left = 8.936F;
			this.line13.LineWeight = 1F;
			this.line13.Name = "line13";
			this.line13.Top = 0.689714F;
			this.line13.Width = 0F;
			this.line13.X1 = 8.936F;
			this.line13.X2 = 8.936F;
			this.line13.Y1 = 0.689714F;
			this.line13.Y2 = 1.039714F;
			// 
			// line14
			// 
			this.line14.Height = 0F;
			this.line14.Left = 8.745917F;
			this.line14.LineWeight = 1F;
			this.line14.Name = "line14";
			this.line14.Top = 0.319685F;
			this.line14.Width = 2.363003F;
			this.line14.X1 = 8.745917F;
			this.line14.X2 = 11.10892F;
			this.line14.Y1 = 0.319685F;
			this.line14.Y2 = 0.319685F;
			// 
			// line15
			// 
			this.line15.Height = 0F;
			this.line15.Left = 8.745917F;
			this.line15.LineWeight = 1F;
			this.line15.Name = "line15";
			this.line15.Top = 0.4897141F;
			this.line15.Width = 2.363003F;
			this.line15.X1 = 8.745917F;
			this.line15.X2 = 11.10892F;
			this.line15.Y1 = 0.4897141F;
			this.line15.Y2 = 0.4897141F;
			// 
			// line20
			// 
			this.line20.Height = 0.47F;
			this.line20.Left = 6.854999F;
			this.line20.LineWeight = 1F;
			this.line20.Name = "line20";
			this.line20.Top = 1.039714F;
			this.line20.Width = 0F;
			this.line20.X1 = 6.854999F;
			this.line20.X2 = 6.854999F;
			this.line20.Y1 = 1.039714F;
			this.line20.Y2 = 1.509714F;
			// 
			// line21
			// 
			this.line21.Height = 0.47F;
			this.line21.Left = 7.933F;
			this.line21.LineWeight = 1F;
			this.line21.Name = "line21";
			this.line21.Top = 1.039714F;
			this.line21.Width = 0F;
			this.line21.X1 = 7.933F;
			this.line21.X2 = 7.933F;
			this.line21.Y1 = 1.039714F;
			this.line21.Y2 = 1.509714F;
			// 
			// line22
			// 
			this.line22.Height = 0.47F;
			this.line22.Left = 8.995999F;
			this.line22.LineWeight = 1F;
			this.line22.Name = "line22";
			this.line22.Top = 1.039714F;
			this.line22.Width = 0F;
			this.line22.X1 = 8.995999F;
			this.line22.X2 = 8.995999F;
			this.line22.Y1 = 1.039714F;
			this.line22.Y2 = 1.509714F;
			// 
			// line23
			// 
			this.line23.Height = 0.47F;
			this.line23.Left = 10.059F;
			this.line23.LineWeight = 1F;
			this.line23.Name = "line23";
			this.line23.Top = 1.039714F;
			this.line23.Width = 0F;
			this.line23.X1 = 10.059F;
			this.line23.X2 = 10.059F;
			this.line23.Y1 = 1.039714F;
			this.line23.Y2 = 1.509714F;
			// 
			// line120
			// 
			this.line120.Height = 0F;
			this.line120.Left = 5.918918F;
			this.line120.LineWeight = 1F;
			this.line120.Name = "line120";
			this.line120.Top = 1.209714F;
			this.line120.Width = 5.190002F;
			this.line120.X1 = 5.918918F;
			this.line120.X2 = 11.10892F;
			this.line120.Y1 = 1.209714F;
			this.line120.Y2 = 1.209714F;
			// 
			// line121
			// 
			this.line121.Height = 0.6999999F;
			this.line121.Left = 6.623918F;
			this.line121.LineWeight = 1F;
			this.line121.Name = "line121";
			this.line121.Top = 1.509714F;
			this.line121.Width = 0F;
			this.line121.X1 = 6.623918F;
			this.line121.X2 = 6.623918F;
			this.line121.Y1 = 1.509714F;
			this.line121.Y2 = 2.209714F;
			// 
			// line122
			// 
			this.line122.Height = 0.3499999F;
			this.line122.Left = 8.283917F;
			this.line122.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line122.LineWeight = 1F;
			this.line122.Name = "line122";
			this.line122.Top = 1.859714F;
			this.line122.Width = 0F;
			this.line122.X1 = 8.283917F;
			this.line122.X2 = 8.283917F;
			this.line122.Y1 = 1.859714F;
			this.line122.Y2 = 2.209714F;
			// 
			// line123
			// 
			this.line123.Height = 0.3499999F;
			this.line123.Left = 8.603917F;
			this.line123.LineWeight = 1F;
			this.line123.Name = "line123";
			this.line123.Top = 1.859714F;
			this.line123.Width = 0F;
			this.line123.X1 = 8.603917F;
			this.line123.X2 = 8.603917F;
			this.line123.Y1 = 1.859714F;
			this.line123.Y2 = 2.209714F;
			// 
			// line124
			// 
			this.line124.Height = 0.4499999F;
			this.line124.Left = 8.838918F;
			this.line124.LineWeight = 1F;
			this.line124.Name = "line124";
			this.line124.Top = 1.759714F;
			this.line124.Width = 0F;
			this.line124.X1 = 8.838918F;
			this.line124.X2 = 8.838918F;
			this.line124.Y1 = 1.759714F;
			this.line124.Y2 = 2.209714F;
			// 
			// line125
			// 
			this.line125.Height = 0.3499999F;
			this.line125.Left = 9.158917F;
			this.line125.LineWeight = 1F;
			this.line125.Name = "line125";
			this.line125.Top = 1.859714F;
			this.line125.Width = 0F;
			this.line125.X1 = 9.158917F;
			this.line125.X2 = 9.158917F;
			this.line125.Y1 = 1.859714F;
			this.line125.Y2 = 2.209714F;
			// 
			// line126
			// 
			this.line126.Height = 0.6999999F;
			this.line126.Left = 9.393918F;
			this.line126.LineWeight = 1F;
			this.line126.Name = "line126";
			this.line126.Top = 1.509714F;
			this.line126.Width = 0F;
			this.line126.X1 = 9.393918F;
			this.line126.X2 = 9.393918F;
			this.line126.Y1 = 1.509714F;
			this.line126.Y2 = 2.209714F;
			// 
			// line127
			// 
			this.line127.Height = 0.4499999F;
			this.line127.Left = 10.42892F;
			this.line127.LineWeight = 1F;
			this.line127.Name = "line127";
			this.line127.Top = 1.759714F;
			this.line127.Width = 0F;
			this.line127.X1 = 10.42892F;
			this.line127.X2 = 10.42892F;
			this.line127.Y1 = 1.759714F;
			this.line127.Y2 = 2.209714F;
			// 
			// line128
			// 
			this.line128.Height = 0.3499999F;
			this.line128.Left = 10.10892F;
			this.line128.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line128.LineWeight = 1F;
			this.line128.Name = "line128";
			this.line128.Top = 1.859714F;
			this.line128.Width = 0F;
			this.line128.X1 = 10.10892F;
			this.line128.X2 = 10.10892F;
			this.line128.Y1 = 1.859714F;
			this.line128.Y2 = 2.209714F;
			// 
			// line130
			// 
			this.line130.Height = 0.6999999F;
			this.line130.Left = 10.74892F;
			this.line130.LineWeight = 1F;
			this.line130.Name = "line130";
			this.line130.Top = 1.509714F;
			this.line130.Width = 0F;
			this.line130.X1 = 10.74892F;
			this.line130.X2 = 10.74892F;
			this.line130.Y1 = 1.509714F;
			this.line130.Y2 = 2.209714F;
			// 
			// line131
			// 
			this.line131.Height = 0F;
			this.line131.Left = 5.918918F;
			this.line131.LineWeight = 1F;
			this.line131.Name = "line131";
			this.line131.Top = 1.959714F;
			this.line131.Width = 0.4699988F;
			this.line131.X1 = 5.918918F;
			this.line131.X2 = 6.388917F;
			this.line131.Y1 = 1.959714F;
			this.line131.Y2 = 1.959714F;
			// 
			// line133
			// 
			this.line133.Height = 1.7F;
			this.line133.Left = 6.098917F;
			this.line133.LineWeight = 1F;
			this.line133.Name = "line133";
			this.line133.Top = 4.509714F;
			this.line133.Width = 0F;
			this.line133.X1 = 6.098917F;
			this.line133.X2 = 6.098917F;
			this.line133.Y1 = 4.509714F;
			this.line133.Y2 = 6.209714F;
			// 
			// line134
			// 
			this.line134.Height = 0F;
			this.line134.Left = 6.868917F;
			this.line134.LineWeight = 1F;
			this.line134.Name = "line134";
			this.line134.Top = 6.299714F;
			this.line134.Width = 0.4700599F;
			this.line134.X1 = 6.868917F;
			this.line134.X2 = 7.338977F;
			this.line134.Y1 = 6.299714F;
			this.line134.Y2 = 6.299714F;
			// 
			// line135
			// 
			this.line135.Height = 0.690001F;
			this.line135.Left = 6.868917F;
			this.line135.LineWeight = 1F;
			this.line135.Name = "line135";
			this.line135.Top = 6.209714F;
			this.line135.Width = 0F;
			this.line135.X1 = 6.868917F;
			this.line135.X2 = 6.868917F;
			this.line135.Y1 = 6.209714F;
			this.line135.Y2 = 6.899715F;
			// 
			// line136
			// 
			this.line136.Height = 0.690001F;
			this.line136.Left = 8.043918F;
			this.line136.LineWeight = 1F;
			this.line136.Name = "line136";
			this.line136.Top = 6.209714F;
			this.line136.Width = 0F;
			this.line136.X1 = 8.043918F;
			this.line136.X2 = 8.043918F;
			this.line136.Y1 = 6.209714F;
			this.line136.Y2 = 6.899715F;
			// 
			// line137
			// 
			this.line137.Height = 0.690001F;
			this.line137.Left = 8.278918F;
			this.line137.LineWeight = 1F;
			this.line137.Name = "line137";
			this.line137.Top = 6.209714F;
			this.line137.Width = 0F;
			this.line137.X1 = 8.278918F;
			this.line137.X2 = 8.278918F;
			this.line137.Y1 = 6.209714F;
			this.line137.Y2 = 6.899715F;
			// 
			// line138
			// 
			this.line138.Height = 0.4700007F;
			this.line138.Left = 8.513917F;
			this.line138.LineWeight = 1F;
			this.line138.Name = "line138";
			this.line138.Top = 6.429714F;
			this.line138.Width = 0F;
			this.line138.X1 = 8.513917F;
			this.line138.X2 = 8.513917F;
			this.line138.Y1 = 6.429714F;
			this.line138.Y2 = 6.899715F;
			// 
			// line139
			// 
			this.line139.Height = 0F;
			this.line139.Left = 8.278918F;
			this.line139.LineWeight = 1F;
			this.line139.Name = "line139";
			this.line139.Top = 6.429714F;
			this.line139.Width = 2.830002F;
			this.line139.X1 = 8.278918F;
			this.line139.X2 = 11.10892F;
			this.line139.Y1 = 6.429714F;
			this.line139.Y2 = 6.429714F;
			// 
			// line140
			// 
			this.line140.Height = 0.4700007F;
			this.line140.Left = 8.748918F;
			this.line140.LineWeight = 1F;
			this.line140.Name = "line140";
			this.line140.Top = 6.429714F;
			this.line140.Width = 0F;
			this.line140.X1 = 8.748918F;
			this.line140.X2 = 8.748918F;
			this.line140.Y1 = 6.429714F;
			this.line140.Y2 = 6.899715F;
			// 
			// line141
			// 
			this.line141.Height = 0.4700007F;
			this.line141.Left = 8.983918F;
			this.line141.LineWeight = 1F;
			this.line141.Name = "line141";
			this.line141.Top = 6.429714F;
			this.line141.Width = 0F;
			this.line141.X1 = 8.983918F;
			this.line141.X2 = 8.983918F;
			this.line141.Y1 = 6.429714F;
			this.line141.Y2 = 6.899715F;
			// 
			// line142
			// 
			this.line142.Height = 0.4700007F;
			this.line142.Left = 9.218917F;
			this.line142.LineWeight = 1F;
			this.line142.Name = "line142";
			this.line142.Top = 6.429714F;
			this.line142.Width = 0F;
			this.line142.X1 = 9.218917F;
			this.line142.X2 = 9.218917F;
			this.line142.Y1 = 6.429714F;
			this.line142.Y2 = 6.899715F;
			// 
			// line143
			// 
			this.line143.Height = 0.690001F;
			this.line143.Left = 9.453918F;
			this.line143.LineWeight = 1F;
			this.line143.Name = "line143";
			this.line143.Top = 6.209714F;
			this.line143.Width = 0F;
			this.line143.X1 = 9.453918F;
			this.line143.X2 = 9.453918F;
			this.line143.Y1 = 6.209714F;
			this.line143.Y2 = 6.899715F;
			// 
			// line146
			// 
			this.line146.Height = 0.4700007F;
			this.line146.Left = 10.39392F;
			this.line146.LineWeight = 1F;
			this.line146.Name = "line146";
			this.line146.Top = 6.429714F;
			this.line146.Width = 0F;
			this.line146.X1 = 10.39392F;
			this.line146.X2 = 10.39392F;
			this.line146.Y1 = 6.429714F;
			this.line146.Y2 = 6.899715F;
			// 
			// line147
			// 
			this.line147.Height = 0.4700007F;
			this.line147.Left = 10.62892F;
			this.line147.LineWeight = 1F;
			this.line147.Name = "line147";
			this.line147.Top = 6.429714F;
			this.line147.Width = 0F;
			this.line147.X1 = 10.62892F;
			this.line147.X2 = 10.62892F;
			this.line147.Y1 = 6.429714F;
			this.line147.Y2 = 6.899715F;
			// 
			// line148
			// 
			this.line148.Height = 0.4700007F;
			this.line148.Left = 10.86392F;
			this.line148.LineWeight = 1F;
			this.line148.Name = "line148";
			this.line148.Top = 6.429714F;
			this.line148.Width = 0F;
			this.line148.X1 = 10.86392F;
			this.line148.X2 = 10.86392F;
			this.line148.Y1 = 6.429714F;
			this.line148.Y2 = 6.899715F;
			// 
			// line149
			// 
			this.line149.Height = 0F;
			this.line149.Left = 6.168918F;
			this.line149.LineWeight = 1F;
			this.line149.Name = "line149";
			this.line149.Top = 7.399715F;
			this.line149.Width = 4.940002F;
			this.line149.X1 = 6.168918F;
			this.line149.X2 = 11.10892F;
			this.line149.Y1 = 7.399715F;
			this.line149.Y2 = 7.399715F;
			// 
			// line150
			// 
			this.line150.Height = 0.6999999F;
			this.line150.Left = 7.493918F;
			this.line150.LineWeight = 1F;
			this.line150.Name = "line150";
			this.line150.Top = 1.509714F;
			this.line150.Width = 0F;
			this.line150.X1 = 7.493918F;
			this.line150.X2 = 7.493918F;
			this.line150.Y1 = 1.509714F;
			this.line150.Y2 = 2.209714F;
			// 
			// label201
			// 
			this.label201.Height = 0.125F;
			this.label201.HyperLink = null;
			this.label201.Left = 5.928917F;
			this.label201.Name = "label201";
			this.label201.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label201.Text = "内";
			this.label201.Top = 2.389714F;
			this.label201.Width = 0.125F;
			// 
			// line151
			// 
			this.line151.Height = 0F;
			this.line151.Left = 5.918918F;
			this.line151.LineWeight = 1F;
			this.line151.Name = "line151";
			this.line151.Top = 1.859714F;
			this.line151.Width = 5.190002F;
			this.line151.X1 = 5.918918F;
			this.line151.X2 = 11.10892F;
			this.line151.Y1 = 1.859714F;
			this.line151.Y2 = 1.859714F;
			// 
			// textBox63
			// 
			this.textBox63.CanGrow = false;
			this.textBox63.DataField = "SUMMARY_0_DIGIT";
			this.textBox63.Height = 0.125F;
			this.textBox63.Left = 5.928917F;
			this.textBox63.MultiLine = false;
			this.textBox63.Name = "textBox63";
			this.textBox63.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.textBox63.Text = "あいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこあいうえおかきくけこ";
			this.textBox63.Top = 2.689715F;
			this.textBox63.Width = 5.063001F;
			// 
			// line152
			// 
			this.line152.Height = 0.690001F;
			this.line152.Left = 7.338917F;
			this.line152.LineWeight = 1F;
			this.line152.Name = "line152";
			this.line152.Top = 6.209714F;
			this.line152.Width = 0F;
			this.line152.X1 = 7.338917F;
			this.line152.X2 = 7.338917F;
			this.line152.Y1 = 6.209714F;
			this.line152.Y2 = 6.899715F;
			// 
			// line153
			// 
			this.line153.Height = 0.6000009F;
			this.line153.Left = 7.103918F;
			this.line153.LineWeight = 1F;
			this.line153.Name = "line153";
			this.line153.Top = 6.299714F;
			this.line153.Width = 0F;
			this.line153.X1 = 7.103918F;
			this.line153.X2 = 7.103918F;
			this.line153.Y1 = 6.299714F;
			this.line153.Y2 = 6.899715F;
			// 
			// line154
			// 
			this.line154.Height = 1.39F;
			this.line154.Left = 6.633917F;
			this.line154.LineWeight = 1F;
			this.line154.Name = "line154";
			this.line154.Top = 6.209714F;
			this.line154.Width = 0F;
			this.line154.X1 = 6.633917F;
			this.line154.X2 = 6.633917F;
			this.line154.Y1 = 6.209714F;
			this.line154.Y2 = 7.599714F;
			// 
			// line155
			// 
			this.line155.Height = 2.830001F;
			this.line155.Left = 6.473917F;
			this.line155.LineWeight = 1F;
			this.line155.Name = "line155";
			this.line155.Top = 4.069714F;
			this.line155.Width = 0F;
			this.line155.X1 = 6.473917F;
			this.line155.X2 = 6.473917F;
			this.line155.Y1 = 4.069714F;
			this.line155.Y2 = 6.899715F;
			// 
			// line156
			// 
			this.line156.Height = 0.6898718F;
			this.line156.Left = 7.573918F;
			this.line156.LineWeight = 1F;
			this.line156.Name = "line156";
			this.line156.Top = 6.209843F;
			this.line156.Width = 0F;
			this.line156.X1 = 7.573918F;
			this.line156.X2 = 7.573918F;
			this.line156.Y1 = 6.209843F;
			this.line156.Y2 = 6.899715F;
			// 
			// line157
			// 
			this.line157.Height = 0.690001F;
			this.line157.Left = 7.808917F;
			this.line157.LineWeight = 1F;
			this.line157.Name = "line157";
			this.line157.Top = 6.209714F;
			this.line157.Width = 0F;
			this.line157.X1 = 7.808917F;
			this.line157.X2 = 7.808917F;
			this.line157.Y1 = 6.209714F;
			this.line157.Y2 = 6.899715F;
			// 
			// line158
			// 
			this.line158.Height = 0F;
			this.line158.Left = 5.916918F;
			this.line158.LineWeight = 1F;
			this.line158.Name = "line158";
			this.line158.Top = 6.649715F;
			this.line158.Width = 5.187002F;
			this.line158.X1 = 5.916918F;
			this.line158.X2 = 11.10392F;
			this.line158.Y1 = 6.649715F;
			this.line158.Y2 = 6.649715F;
			// 
			// line159
			// 
			this.line159.Height = 7.589084F;
			this.line159.Left = 5.918898F;
			this.line159.LineWeight = 1F;
			this.line159.Name = "line159";
			this.line159.Top = 0.01062992F;
			this.line159.Width = 2.002716E-05F;
			this.line159.X1 = 5.918898F;
			this.line159.X2 = 5.918918F;
			this.line159.Y1 = 0.01062992F;
			this.line159.Y2 = 7.599714F;
			// 
			// line160
			// 
			this.line160.Height = 0F;
			this.line160.Left = 5.916918F;
			this.line160.LineWeight = 1F;
			this.line160.Name = "line160";
			this.line160.Top = 6.899715F;
			this.line160.Width = 5.192002F;
			this.line160.X1 = 5.916918F;
			this.line160.X2 = 11.10892F;
			this.line160.Y1 = 6.899715F;
			this.line160.Y2 = 6.899715F;
			// 
			// label202
			// 
			this.label202.Height = 0.153F;
			this.label202.HyperLink = null;
			this.label202.Left = 8.978917F;
			this.label202.Name = "label202";
			this.label202.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label202.Text = "円";
			this.label202.Top = 4.069714F;
			this.label202.Width = 0.125F;
			// 
			// textBox64
			// 
			this.textBox64.CanGrow = false;
			this.textBox64.DataField = "NEW_LIFE_INS_PENS_AMT";
			this.textBox64.Height = 0.15F;
			this.textBox64.Left = 9.651917F;
			this.textBox64.Name = "textBox64";
			this.textBox64.OutputFormat = "#,##0";
			this.textBox64.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox64.Text = "ZZ,ZZZ,ZZ6";
			this.textBox64.Top = 3.467715F;
			this.textBox64.Width = 0.45F;
			// 
			// textBox65
			// 
			this.textBox65.CanGrow = false;
			this.textBox65.DataField = "NEW_LIFE_INS_CARE_AMT";
			this.textBox65.Height = 0.15F;
			this.textBox65.Left = 8.649F;
			this.textBox65.Name = "textBox65";
			this.textBox65.OutputFormat = "#,##0";
			this.textBox65.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox65.Text = "ZZ,ZZZ,ZZ6";
			this.textBox65.Top = 3.468F;
			this.textBox65.Width = 0.45F;
			// 
			// label203
			// 
			this.label203.Height = 0.153F;
			this.label203.HyperLink = null;
			this.label203.Left = 7.063918F;
			this.label203.Name = "label203";
			this.label203.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label203.Text = "円";
			this.label203.Top = 3.369714F;
			this.label203.Width = 0.125F;
			// 
			// label204
			// 
			this.label204.Height = 0.153F;
			this.label204.HyperLink = null;
			this.label204.Left = 7.978918F;
			this.label204.Name = "label204";
			this.label204.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label204.Text = "円";
			this.label204.Top = 3.369714F;
			this.label204.Width = 0.125F;
			// 
			// textBox66
			// 
			this.textBox66.CanGrow = false;
			this.textBox66.DataField = "NEW_LIFE_INS_GENERAL_AMT";
			this.textBox66.Height = 0.15F;
			this.textBox66.Left = 6.734F;
			this.textBox66.Name = "textBox66";
			this.textBox66.OutputFormat = "#,##0";
			this.textBox66.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox66.Text = "ZZ,ZZZ,ZZ6";
			this.textBox66.Top = 3.468F;
			this.textBox66.Width = 0.45F;
			// 
			// textBox67
			// 
			this.textBox67.CanGrow = false;
			this.textBox67.DataField = "LIFE_INS_GENERAL_AMT";
			this.textBox67.Height = 0.15F;
			this.textBox67.Left = 7.662F;
			this.textBox67.Name = "textBox67";
			this.textBox67.OutputFormat = "#,##0";
			this.textBox67.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox67.Text = "ZZ,ZZZ,ZZ6";
			this.textBox67.Top = 3.468F;
			this.textBox67.Width = 0.45F;
			// 
			// textBox68
			// 
			this.textBox68.CanGrow = false;
			this.textBox68.DataField = "SUMMARY_DIGIT";
			this.textBox68.Height = 0.5F;
			this.textBox68.Left = 5.928917F;
			this.textBox68.Name = "textBox68";
			this.textBox68.Style = "font-size: 5.5pt; text-align: left; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.textBox68.Text = resources.GetString("textBox68.Text");
			this.textBox68.Top = 2.819714F;
			this.textBox68.Width = 5.063F;
			// 
			// line161
			// 
			this.line161.Height = 0F;
			this.line161.Left = 6.168918F;
			this.line161.LineWeight = 1F;
			this.line161.Name = "line161";
			this.line161.Top = 7.099715F;
			this.line161.Width = 4.940002F;
			this.line161.X1 = 6.168918F;
			this.line161.X2 = 11.10892F;
			this.line161.Y1 = 7.099715F;
			this.line161.Y2 = 7.099715F;
			// 
			// CorpNumber2_2
			// 
			this.CorpNumber2_2.CanGrow = false;
			this.CorpNumber2_2.Height = 0.2F;
			this.CorpNumber2_2.Left = 6.783917F;
			this.CorpNumber2_2.MultiLine = false;
			this.CorpNumber2_2.Name = "CorpNumber2_2";
			this.CorpNumber2_2.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber2_2.Text = null;
			this.CorpNumber2_2.Top = 6.899715F;
			this.CorpNumber2_2.Width = 0.3F;
			// 
			// CorpNumber2_3
			// 
			this.CorpNumber2_3.CanGrow = false;
			this.CorpNumber2_3.Height = 0.2F;
			this.CorpNumber2_3.Left = 7.083999F;
			this.CorpNumber2_3.MultiLine = false;
			this.CorpNumber2_3.Name = "CorpNumber2_3";
			this.CorpNumber2_3.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber2_3.Text = null;
			this.CorpNumber2_3.Top = 6.9F;
			this.CorpNumber2_3.Width = 0.3F;
			// 
			// CorpNumber2_4
			// 
			this.CorpNumber2_4.CanGrow = false;
			this.CorpNumber2_4.Height = 0.2F;
			this.CorpNumber2_4.Left = 7.383999F;
			this.CorpNumber2_4.MultiLine = false;
			this.CorpNumber2_4.Name = "CorpNumber2_4";
			this.CorpNumber2_4.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber2_4.Text = null;
			this.CorpNumber2_4.Top = 6.9F;
			this.CorpNumber2_4.Width = 0.3F;
			// 
			// line162
			// 
			this.line162.Height = 0.2000003F;
			this.line162.Left = 6.783917F;
			this.line162.LineWeight = 1F;
			this.line162.Name = "line162";
			this.line162.Top = 6.899715F;
			this.line162.Width = 0F;
			this.line162.X1 = 6.783917F;
			this.line162.X2 = 6.783917F;
			this.line162.Y1 = 6.899715F;
			this.line162.Y2 = 7.099715F;
			// 
			// line163
			// 
			this.line163.Height = 0.2000003F;
			this.line163.Left = 7.083918F;
			this.line163.LineWeight = 1F;
			this.line163.Name = "line163";
			this.line163.Top = 6.899715F;
			this.line163.Width = 0F;
			this.line163.X1 = 7.083918F;
			this.line163.X2 = 7.083918F;
			this.line163.Y1 = 6.899715F;
			this.line163.Y2 = 7.099715F;
			// 
			// line164
			// 
			this.line164.Height = 0.2000003F;
			this.line164.Left = 7.383917F;
			this.line164.LineWeight = 1F;
			this.line164.Name = "line164";
			this.line164.Top = 6.899715F;
			this.line164.Width = 0F;
			this.line164.X1 = 7.383917F;
			this.line164.X2 = 7.383917F;
			this.line164.Y1 = 6.899715F;
			this.line164.Y2 = 7.099715F;
			// 
			// line165
			// 
			this.line165.Height = 0.2000003F;
			this.line165.Left = 7.683917F;
			this.line165.LineWeight = 1F;
			this.line165.Name = "line165";
			this.line165.Top = 6.899715F;
			this.line165.Width = 0F;
			this.line165.X1 = 7.683917F;
			this.line165.X2 = 7.683917F;
			this.line165.Y1 = 6.899715F;
			this.line165.Y2 = 7.099715F;
			// 
			// line166
			// 
			this.line166.Height = 1.39F;
			this.line166.Left = 6.153918F;
			this.line166.LineWeight = 1F;
			this.line166.Name = "line166";
			this.line166.Top = 6.209714F;
			this.line166.Width = 0F;
			this.line166.X1 = 6.153918F;
			this.line166.X2 = 6.153918F;
			this.line166.Y1 = 6.209714F;
			this.line166.Y2 = 7.599714F;
			// 
			// line167
			// 
			this.line167.Height = 0.690001F;
			this.line167.Left = 6.313918F;
			this.line167.LineWeight = 1F;
			this.line167.Name = "line167";
			this.line167.Top = 6.209714F;
			this.line167.Width = 0F;
			this.line167.X1 = 6.313918F;
			this.line167.X2 = 6.313918F;
			this.line167.Y1 = 6.209714F;
			this.line167.Y2 = 6.899715F;
			// 
			// label207
			// 
			this.label207.Height = 0.11F;
			this.label207.HyperLink = null;
			this.label207.Left = 9.403918F;
			this.label207.Name = "label207";
			this.label207.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label207.Text = "16歳未満";
			this.label207.Top = 1.519715F;
			this.label207.Width = 0.375F;
			// 
			// label208
			// 
			this.label208.Height = 0.11F;
			this.label208.HyperLink = null;
			this.label208.Left = 9.403918F;
			this.label208.Name = "label208";
			this.label208.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label208.Text = "扶養親族";
			this.label208.Top = 1.629714F;
			this.label208.Width = 0.375F;
			// 
			// label209
			// 
			this.label209.Height = 0.15F;
			this.label209.HyperLink = null;
			this.label209.Left = 9.670918F;
			this.label209.Name = "label209";
			this.label209.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label209.Text = "人";
			this.label209.Top = 1.899714F;
			this.label209.Width = 0.1F;
			// 
			// textBox74
			// 
			this.textBox74.CanGrow = false;
			this.textBox74.DataField = "YOUNG_DPND_NUM";
			this.textBox74.Height = 0.15F;
			this.textBox74.Left = 9.508918F;
			this.textBox74.Name = "textBox74";
			this.textBox74.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox74.Text = "Z6";
			this.textBox74.Top = 2.029714F;
			this.textBox74.Width = 0.15F;
			// 
			// line168
			// 
			this.line168.Height = 0F;
			this.line168.Left = 5.918918F;
			this.line168.LineWeight = 1F;
			this.line168.Name = "line168";
			this.line168.Top = 4.509714F;
			this.line168.Width = 5.190002F;
			this.line168.X1 = 5.918918F;
			this.line168.X2 = 11.10892F;
			this.line168.Y1 = 4.509714F;
			this.line168.Y2 = 4.509714F;
			// 
			// line169
			// 
			this.line169.Height = 2.14F;
			this.line169.Left = 6.178917F;
			this.line169.LineWeight = 1F;
			this.line169.Name = "line169";
			this.line169.Top = 4.069714F;
			this.line169.Width = 0F;
			this.line169.X1 = 6.178917F;
			this.line169.X2 = 6.178917F;
			this.line169.Y1 = 4.069714F;
			this.line169.Y2 = 6.209714F;
			// 
			// line171
			// 
			this.line171.Height = 0F;
			this.line171.Left = 6.098917F;
			this.line171.LineWeight = 1F;
			this.line171.Name = "line171";
			this.line171.Top = 5.359715F;
			this.line171.Width = 2.030002F;
			this.line171.X1 = 6.098917F;
			this.line171.X2 = 8.128919F;
			this.line171.Y1 = 5.359715F;
			this.line171.Y2 = 5.359715F;
			// 
			// line172
			// 
			this.line172.Height = 0F;
			this.line172.Left = 6.098917F;
			this.line172.LineWeight = 1F;
			this.line172.Name = "line172";
			this.line172.Top = 5.784714F;
			this.line172.Width = 2.030002F;
			this.line172.X1 = 6.098917F;
			this.line172.X2 = 8.128919F;
			this.line172.Y1 = 5.784714F;
			this.line172.Y2 = 5.784714F;
			// 
			// label210
			// 
			this.label210.Height = 1.4F;
			this.label210.HyperLink = null;
			this.label210.Left = 5.938918F;
			this.label210.Name = "label210";
			this.label210.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label210.Text = "控除対象扶養親族";
			this.label210.Top = 4.659714F;
			this.label210.Width = 0.15F;
			// 
			// label211
			// 
			this.label211.Height = 0.385F;
			this.label211.HyperLink = null;
			this.label211.Left = 6.113918F;
			this.label211.Name = "label211";
			this.label211.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label211.Text = "1";
			this.label211.Top = 4.529715F;
			this.label211.Width = 0.05F;
			// 
			// label212
			// 
			this.label212.Height = 0.385F;
			this.label212.HyperLink = null;
			this.label212.Left = 6.113918F;
			this.label212.Name = "label212";
			this.label212.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label212.Text = "2";
			this.label212.Top = 4.944714F;
			this.label212.Width = 0.05F;
			// 
			// label213
			// 
			this.label213.Height = 0.385F;
			this.label213.HyperLink = null;
			this.label213.Left = 6.113918F;
			this.label213.Name = "label213";
			this.label213.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label213.Text = "3";
			this.label213.Top = 5.369714F;
			this.label213.Width = 0.05F;
			// 
			// label214
			// 
			this.label214.Height = 0.385F;
			this.label214.HyperLink = null;
			this.label214.Left = 6.113918F;
			this.label214.Name = "label214";
			this.label214.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label214.Text = "4";
			this.label214.Top = 5.794714F;
			this.label214.Width = 0.05F;
			// 
			// line173
			// 
			this.line173.Height = 0F;
			this.line173.Left = 6.178917F;
			this.line173.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line173.LineWeight = 1F;
			this.line173.Name = "line173";
			this.line173.Top = 4.649715F;
			this.line173.Width = 1.510001F;
			this.line173.X1 = 6.178917F;
			this.line173.X2 = 7.688918F;
			this.line173.Y1 = 4.649715F;
			this.line173.Y2 = 4.649715F;
			// 
			// line174
			// 
			this.line174.Height = 0.2820001F;
			this.line174.Left = 7.688918F;
			this.line174.LineWeight = 1F;
			this.line174.Name = "line174";
			this.line174.Top = 4.509714F;
			this.line174.Width = 0F;
			this.line174.X1 = 7.688918F;
			this.line174.X2 = 7.688918F;
			this.line174.Y1 = 4.509714F;
			this.line174.Y2 = 4.791714F;
			// 
			// line175
			// 
			this.line175.Height = 0.2820001F;
			this.line175.Left = 7.878918F;
			this.line175.LineWeight = 1F;
			this.line175.Name = "line175";
			this.line175.Top = 4.509714F;
			this.line175.Width = 0F;
			this.line175.X1 = 7.878918F;
			this.line175.X2 = 7.878918F;
			this.line175.Y1 = 4.509714F;
			this.line175.Y2 = 4.791714F;
			// 
			// line176
			// 
			this.line176.Height = 2.14F;
			this.line176.Left = 8.128919F;
			this.line176.LineWeight = 1F;
			this.line176.Name = "line176";
			this.line176.Top = 4.069714F;
			this.line176.Width = 0F;
			this.line176.X1 = 8.128919F;
			this.line176.X2 = 8.128919F;
			this.line176.Y1 = 4.069714F;
			this.line176.Y2 = 6.209714F;
			// 
			// line177
			// 
			this.line177.Height = 1.7F;
			this.line177.Left = 8.308917F;
			this.line177.LineWeight = 1F;
			this.line177.Name = "line177";
			this.line177.Top = 4.509714F;
			this.line177.Width = 0F;
			this.line177.X1 = 8.308917F;
			this.line177.X2 = 8.308917F;
			this.line177.Y1 = 4.509714F;
			this.line177.Y2 = 6.209714F;
			// 
			// line178
			// 
			this.line178.Height = 1.700002F;
			this.line178.Left = 8.388917F;
			this.line178.LineWeight = 1F;
			this.line178.Name = "line178";
			this.line178.Top = 4.509714F;
			this.line178.Width = 0F;
			this.line178.X1 = 8.388917F;
			this.line178.X2 = 8.388917F;
			this.line178.Y1 = 4.509714F;
			this.line178.Y2 = 6.209716F;
			// 
			// label215
			// 
			this.label215.Height = 0.385F;
			this.label215.HyperLink = null;
			this.label215.Left = 8.318917F;
			this.label215.Name = "label215";
			this.label215.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label215.Text = "1";
			this.label215.Top = 4.529715F;
			this.label215.Width = 0.05F;
			// 
			// label216
			// 
			this.label216.Height = 0.385F;
			this.label216.HyperLink = null;
			this.label216.Left = 8.318917F;
			this.label216.Name = "label216";
			this.label216.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label216.Text = "2";
			this.label216.Top = 4.944714F;
			this.label216.Width = 0.05F;
			// 
			// label217
			// 
			this.label217.Height = 0.385F;
			this.label217.HyperLink = null;
			this.label217.Left = 8.318917F;
			this.label217.Name = "label217";
			this.label217.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label217.Text = "3";
			this.label217.Top = 5.369714F;
			this.label217.Width = 0.05F;
			// 
			// label218
			// 
			this.label218.Height = 0.385F;
			this.label218.HyperLink = null;
			this.label218.Left = 8.318917F;
			this.label218.Name = "label218";
			this.label218.Style = "font-size: 5.5pt; text-align: center; vertical-align: middle; white-space: inheri" +
    "t; ddo-char-set: 1";
			this.label218.Text = "4";
			this.label218.Top = 5.794714F;
			this.label218.Width = 0.05F;
			// 
			// line179
			// 
			this.line179.Height = 0F;
			this.line179.Left = 8.388917F;
			this.line179.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line179.LineWeight = 1F;
			this.line179.Name = "line179";
			this.line179.Top = 4.649715F;
			this.line179.Width = 1.51F;
			this.line179.X1 = 8.388917F;
			this.line179.X2 = 9.898917F;
			this.line179.Y1 = 4.649715F;
			this.line179.Y2 = 4.649715F;
			// 
			// line180
			// 
			this.line180.Height = 0.2820001F;
			this.line180.Left = 9.898917F;
			this.line180.LineWeight = 1F;
			this.line180.Name = "line180";
			this.line180.Top = 4.509714F;
			this.line180.Width = 0F;
			this.line180.X1 = 9.898917F;
			this.line180.X2 = 9.898917F;
			this.line180.Y1 = 4.509714F;
			this.line180.Y2 = 4.791714F;
			// 
			// line181
			// 
			this.line181.Height = 0.2820001F;
			this.line181.Left = 10.08892F;
			this.line181.LineWeight = 1F;
			this.line181.Name = "line181";
			this.line181.Top = 4.509714F;
			this.line181.Width = 0F;
			this.line181.X1 = 10.08892F;
			this.line181.X2 = 10.08892F;
			this.line181.Y1 = 4.509714F;
			this.line181.Y2 = 4.791714F;
			// 
			// line182
			// 
			this.line182.Height = 1.7F;
			this.line182.Left = 10.33892F;
			this.line182.LineWeight = 1F;
			this.line182.Name = "line182";
			this.line182.Top = 4.509714F;
			this.line182.Width = 0F;
			this.line182.X1 = 10.33892F;
			this.line182.X2 = 10.33892F;
			this.line182.Y1 = 4.509714F;
			this.line182.Y2 = 6.209714F;
			// 
			// line183
			// 
			this.line183.Height = 0F;
			this.line183.Left = 6.178917F;
			this.line183.LineWeight = 1F;
			this.line183.Name = "line183";
			this.line183.Top = 4.791714F;
			this.line183.Width = 1.950002F;
			this.line183.X1 = 6.178917F;
			this.line183.X2 = 8.128919F;
			this.line183.Y1 = 4.791714F;
			this.line183.Y2 = 4.791714F;
			// 
			// label219
			// 
			this.label219.Height = 1.4F;
			this.label219.HyperLink = null;
			this.label219.Left = 8.148917F;
			this.label219.Name = "label219";
			this.label219.Style = "font-size: 7pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.label219.Text = "１６歳未満の扶養親族";
			this.label219.Top = 4.659714F;
			this.label219.Width = 0.15F;
			// 
			// line184
			// 
			this.line184.Height = 0.2819991F;
			this.line184.Left = 7.688918F;
			this.line184.LineWeight = 1F;
			this.line184.Name = "line184";
			this.line184.Top = 4.934715F;
			this.line184.Width = 0F;
			this.line184.X1 = 7.688918F;
			this.line184.X2 = 7.688918F;
			this.line184.Y1 = 4.934715F;
			this.line184.Y2 = 5.216714F;
			// 
			// line185
			// 
			this.line185.Height = 0F;
			this.line185.Left = 6.178917F;
			this.line185.LineWeight = 1F;
			this.line185.Name = "line185";
			this.line185.Top = 5.216714F;
			this.line185.Width = 1.950002F;
			this.line185.X1 = 6.178917F;
			this.line185.X2 = 8.128919F;
			this.line185.Y1 = 5.216714F;
			this.line185.Y2 = 5.216714F;
			// 
			// line186
			// 
			this.line186.Height = 0.2819991F;
			this.line186.Left = 7.878918F;
			this.line186.LineWeight = 1F;
			this.line186.Name = "line186";
			this.line186.Top = 4.934715F;
			this.line186.Width = 0F;
			this.line186.X1 = 7.878918F;
			this.line186.X2 = 7.878918F;
			this.line186.Y1 = 4.934715F;
			this.line186.Y2 = 5.216714F;
			// 
			// line187
			// 
			this.line187.Height = 0F;
			this.line187.Left = 6.178917F;
			this.line187.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line187.LineWeight = 1F;
			this.line187.Name = "line187";
			this.line187.Top = 5.074714F;
			this.line187.Width = 1.510001F;
			this.line187.X1 = 6.178917F;
			this.line187.X2 = 7.688918F;
			this.line187.Y1 = 5.074714F;
			this.line187.Y2 = 5.074714F;
			// 
			// line188
			// 
			this.line188.Height = 0F;
			this.line188.Left = 6.178917F;
			this.line188.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line188.LineWeight = 1F;
			this.line188.Name = "line188";
			this.line188.Top = 5.499714F;
			this.line188.Width = 1.510001F;
			this.line188.X1 = 6.178917F;
			this.line188.X2 = 7.688918F;
			this.line188.Y1 = 5.499714F;
			this.line188.Y2 = 5.499714F;
			// 
			// line189
			// 
			this.line189.Height = 0F;
			this.line189.Left = 6.178917F;
			this.line189.LineWeight = 1F;
			this.line189.Name = "line189";
			this.line189.Top = 5.641714F;
			this.line189.Width = 1.950002F;
			this.line189.X1 = 6.178917F;
			this.line189.X2 = 8.128919F;
			this.line189.Y1 = 5.641714F;
			this.line189.Y2 = 5.641714F;
			// 
			// line190
			// 
			this.line190.Height = 0.2820001F;
			this.line190.Left = 7.688918F;
			this.line190.LineWeight = 1F;
			this.line190.Name = "line190";
			this.line190.Top = 5.359715F;
			this.line190.Width = 0F;
			this.line190.X1 = 7.688918F;
			this.line190.X2 = 7.688918F;
			this.line190.Y1 = 5.359715F;
			this.line190.Y2 = 5.641715F;
			// 
			// line191
			// 
			this.line191.Height = 0.2820001F;
			this.line191.Left = 7.878918F;
			this.line191.LineWeight = 1F;
			this.line191.Name = "line191";
			this.line191.Top = 5.359715F;
			this.line191.Width = 0F;
			this.line191.X1 = 7.878918F;
			this.line191.X2 = 7.878918F;
			this.line191.Y1 = 5.359715F;
			this.line191.Y2 = 5.641715F;
			// 
			// line192
			// 
			this.line192.Height = 0F;
			this.line192.Left = 6.178917F;
			this.line192.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line192.LineWeight = 1F;
			this.line192.Name = "line192";
			this.line192.Top = 5.924714F;
			this.line192.Width = 1.510001F;
			this.line192.X1 = 6.178917F;
			this.line192.X2 = 7.688918F;
			this.line192.Y1 = 5.924714F;
			this.line192.Y2 = 5.924714F;
			// 
			// line193
			// 
			this.line193.Height = 0F;
			this.line193.Left = 6.178917F;
			this.line193.LineWeight = 1F;
			this.line193.Name = "line193";
			this.line193.Top = 6.066714F;
			this.line193.Width = 1.950002F;
			this.line193.X1 = 6.178917F;
			this.line193.X2 = 8.128919F;
			this.line193.Y1 = 6.066714F;
			this.line193.Y2 = 6.066714F;
			// 
			// line194
			// 
			this.line194.Height = 0.2819996F;
			this.line194.Left = 7.688918F;
			this.line194.LineWeight = 1F;
			this.line194.Name = "line194";
			this.line194.Top = 5.784714F;
			this.line194.Width = 0F;
			this.line194.X1 = 7.688918F;
			this.line194.X2 = 7.688918F;
			this.line194.Y1 = 5.784714F;
			this.line194.Y2 = 6.066714F;
			// 
			// line195
			// 
			this.line195.Height = 0.2819996F;
			this.line195.Left = 7.878918F;
			this.line195.LineWeight = 1F;
			this.line195.Name = "line195";
			this.line195.Top = 5.784714F;
			this.line195.Width = 0F;
			this.line195.X1 = 7.878918F;
			this.line195.X2 = 7.878918F;
			this.line195.Y1 = 5.784714F;
			this.line195.Y2 = 6.066714F;
			// 
			// line196
			// 
			this.line196.Height = 0F;
			this.line196.Left = 8.308917F;
			this.line196.LineWeight = 1F;
			this.line196.Name = "line196";
			this.line196.Top = 4.934715F;
			this.line196.Width = 2.030003F;
			this.line196.X1 = 8.308917F;
			this.line196.X2 = 10.33892F;
			this.line196.Y1 = 4.934715F;
			this.line196.Y2 = 4.934715F;
			// 
			// line197
			// 
			this.line197.Height = 0F;
			this.line197.Left = 8.388917F;
			this.line197.LineWeight = 1F;
			this.line197.Name = "line197";
			this.line197.Top = 4.791714F;
			this.line197.Width = 1.950003F;
			this.line197.X1 = 8.388917F;
			this.line197.X2 = 10.33892F;
			this.line197.Y1 = 4.791714F;
			this.line197.Y2 = 4.791714F;
			// 
			// line198
			// 
			this.line198.Height = 1.700129F;
			this.line198.Left = 8.683859F;
			this.line198.LineWeight = 1F;
			this.line198.Name = "line198";
			this.line198.Top = 4.509714F;
			this.line198.Width = 5.817413E-05F;
			this.line198.X1 = 8.683917F;
			this.line198.X2 = 8.683859F;
			this.line198.Y1 = 4.509714F;
			this.line198.Y2 = 6.209843F;
			// 
			// label220
			// 
			this.label220.Height = 0.14F;
			this.label220.HyperLink = null;
			this.label220.Left = 6.158917F;
			this.label220.Name = "label220";
			this.label220.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label220.Text = "(フリガナ)";
			this.label220.Top = 4.539714F;
			this.label220.Width = 0.33F;
			// 
			// label221
			// 
			this.label221.Height = 0.14F;
			this.label221.HyperLink = null;
			this.label221.Left = 6.178917F;
			this.label221.Name = "label221";
			this.label221.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label221.Text = "氏名";
			this.label221.Top = 4.679714F;
			this.label221.Width = 0.295F;
			// 
			// label222
			// 
			this.label222.Height = 0.14F;
			this.label222.HyperLink = null;
			this.label222.Left = 6.158917F;
			this.label222.Name = "label222";
			this.label222.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label222.Text = "(フリガナ)";
			this.label222.Top = 4.964714F;
			this.label222.Width = 0.33F;
			// 
			// label223
			// 
			this.label223.Height = 0.14F;
			this.label223.HyperLink = null;
			this.label223.Left = 6.178917F;
			this.label223.Name = "label223";
			this.label223.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label223.Text = "氏名";
			this.label223.Top = 5.104715F;
			this.label223.Width = 0.295F;
			// 
			// label224
			// 
			this.label224.Height = 0.14F;
			this.label224.HyperLink = null;
			this.label224.Left = 6.158917F;
			this.label224.Name = "label224";
			this.label224.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label224.Text = "(フリガナ)";
			this.label224.Top = 5.389714F;
			this.label224.Width = 0.33F;
			// 
			// label225
			// 
			this.label225.Height = 0.14F;
			this.label225.HyperLink = null;
			this.label225.Left = 6.178917F;
			this.label225.Name = "label225";
			this.label225.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label225.Text = "氏名";
			this.label225.Top = 5.529715F;
			this.label225.Width = 0.295F;
			// 
			// label226
			// 
			this.label226.Height = 0.14F;
			this.label226.HyperLink = null;
			this.label226.Left = 6.178917F;
			this.label226.Name = "label226";
			this.label226.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label226.Text = "氏名";
			this.label226.Top = 5.954714F;
			this.label226.Width = 0.295F;
			// 
			// label227
			// 
			this.label227.Height = 0.14F;
			this.label227.HyperLink = null;
			this.label227.Left = 6.158917F;
			this.label227.Name = "label227";
			this.label227.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label227.Text = "(フリガナ)";
			this.label227.Top = 5.814714F;
			this.label227.Width = 0.33F;
			// 
			// label228
			// 
			this.label228.Height = 0.2F;
			this.label228.HyperLink = null;
			this.label228.Left = 7.728918F;
			this.label228.Name = "label228";
			this.label228.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label228.Text = "区分";
			this.label228.Top = 4.559715F;
			this.label228.Width = 0.1F;
			// 
			// label229
			// 
			this.label229.Height = 0.2F;
			this.label229.HyperLink = null;
			this.label229.Left = 7.728918F;
			this.label229.Name = "label229";
			this.label229.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label229.Text = "区分";
			this.label229.Top = 4.984715F;
			this.label229.Width = 0.1F;
			// 
			// label230
			// 
			this.label230.Height = 0.2F;
			this.label230.HyperLink = null;
			this.label230.Left = 7.728918F;
			this.label230.Name = "label230";
			this.label230.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label230.Text = "区分";
			this.label230.Top = 5.409714F;
			this.label230.Width = 0.1F;
			// 
			// label231
			// 
			this.label231.Height = 0.2F;
			this.label231.HyperLink = null;
			this.label231.Left = 7.728918F;
			this.label231.Name = "label231";
			this.label231.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label231.Text = "区分";
			this.label231.Top = 5.834714F;
			this.label231.Width = 0.1F;
			// 
			// label232
			// 
			this.label232.Height = 0.14F;
			this.label232.HyperLink = null;
			this.label232.Left = 8.368918F;
			this.label232.Name = "label232";
			this.label232.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label232.Text = "(フリガナ)";
			this.label232.Top = 4.539714F;
			this.label232.Width = 0.33F;
			// 
			// line199
			// 
			this.line199.Height = 0F;
			this.line199.Left = 8.388917F;
			this.line199.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line199.LineWeight = 1F;
			this.line199.Name = "line199";
			this.line199.Top = 5.074714F;
			this.line199.Width = 1.51F;
			this.line199.X1 = 8.388917F;
			this.line199.X2 = 9.898917F;
			this.line199.Y1 = 5.074714F;
			this.line199.Y2 = 5.074714F;
			// 
			// line200
			// 
			this.line200.Height = 0.2819991F;
			this.line200.Left = 9.898917F;
			this.line200.LineWeight = 1F;
			this.line200.Name = "line200";
			this.line200.Top = 4.934715F;
			this.line200.Width = 0F;
			this.line200.X1 = 9.898917F;
			this.line200.X2 = 9.898917F;
			this.line200.Y1 = 4.934715F;
			this.line200.Y2 = 5.216714F;
			// 
			// line201
			// 
			this.line201.Height = 0.2819991F;
			this.line201.Left = 10.08892F;
			this.line201.LineWeight = 1F;
			this.line201.Name = "line201";
			this.line201.Top = 4.934715F;
			this.line201.Width = 0F;
			this.line201.X1 = 10.08892F;
			this.line201.X2 = 10.08892F;
			this.line201.Y1 = 4.934715F;
			this.line201.Y2 = 5.216714F;
			// 
			// line202
			// 
			this.line202.Height = 0F;
			this.line202.Left = 8.308917F;
			this.line202.LineWeight = 1F;
			this.line202.Name = "line202";
			this.line202.Top = 5.359715F;
			this.line202.Width = 2.030003F;
			this.line202.X1 = 8.308917F;
			this.line202.X2 = 10.33892F;
			this.line202.Y1 = 5.359715F;
			this.line202.Y2 = 5.359715F;
			// 
			// line203
			// 
			this.line203.Height = 0F;
			this.line203.Left = 8.388917F;
			this.line203.LineWeight = 1F;
			this.line203.Name = "line203";
			this.line203.Top = 5.216714F;
			this.line203.Width = 1.950003F;
			this.line203.X1 = 8.388917F;
			this.line203.X2 = 10.33892F;
			this.line203.Y1 = 5.216714F;
			this.line203.Y2 = 5.216714F;
			// 
			// label234
			// 
			this.label234.Height = 0.14F;
			this.label234.HyperLink = null;
			this.label234.Left = 8.368918F;
			this.label234.Name = "label234";
			this.label234.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label234.Text = "(フリガナ)";
			this.label234.Top = 4.964714F;
			this.label234.Width = 0.33F;
			// 
			// label236
			// 
			this.label236.Height = 0.2F;
			this.label236.HyperLink = null;
			this.label236.Left = 9.947917F;
			this.label236.Name = "label236";
			this.label236.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label236.Text = "区分";
			this.label236.Top = 4.559715F;
			this.label236.Width = 0.1F;
			// 
			// label237
			// 
			this.label237.Height = 0.2F;
			this.label237.HyperLink = null;
			this.label237.Left = 9.947917F;
			this.label237.Name = "label237";
			this.label237.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label237.Text = "区分";
			this.label237.Top = 4.984715F;
			this.label237.Width = 0.1F;
			// 
			// line205
			// 
			this.line205.Height = 0F;
			this.line205.Left = 8.388917F;
			this.line205.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line205.LineWeight = 1F;
			this.line205.Name = "line205";
			this.line205.Top = 5.499714F;
			this.line205.Width = 1.51F;
			this.line205.X1 = 8.388917F;
			this.line205.X2 = 9.898917F;
			this.line205.Y1 = 5.499714F;
			this.line205.Y2 = 5.499714F;
			// 
			// line206
			// 
			this.line206.Height = 0.2820001F;
			this.line206.Left = 9.898917F;
			this.line206.LineWeight = 1F;
			this.line206.Name = "line206";
			this.line206.Top = 5.359715F;
			this.line206.Width = 0F;
			this.line206.X1 = 9.898917F;
			this.line206.X2 = 9.898917F;
			this.line206.Y1 = 5.359715F;
			this.line206.Y2 = 5.641715F;
			// 
			// line207
			// 
			this.line207.Height = 0.2820001F;
			this.line207.Left = 10.08892F;
			this.line207.LineWeight = 1F;
			this.line207.Name = "line207";
			this.line207.Top = 5.359715F;
			this.line207.Width = 0F;
			this.line207.X1 = 10.08892F;
			this.line207.X2 = 10.08892F;
			this.line207.Y1 = 5.359715F;
			this.line207.Y2 = 5.641715F;
			// 
			// line208
			// 
			this.line208.Height = 0F;
			this.line208.Left = 8.308917F;
			this.line208.LineWeight = 1F;
			this.line208.Name = "line208";
			this.line208.Top = 5.784714F;
			this.line208.Width = 2.030003F;
			this.line208.X1 = 8.308917F;
			this.line208.X2 = 10.33892F;
			this.line208.Y1 = 5.784714F;
			this.line208.Y2 = 5.784714F;
			// 
			// line209
			// 
			this.line209.Height = 0F;
			this.line209.Left = 8.388917F;
			this.line209.LineWeight = 1F;
			this.line209.Name = "line209";
			this.line209.Top = 5.641714F;
			this.line209.Width = 1.950003F;
			this.line209.X1 = 8.388917F;
			this.line209.X2 = 10.33892F;
			this.line209.Y1 = 5.641714F;
			this.line209.Y2 = 5.641714F;
			// 
			// label238
			// 
			this.label238.Height = 0.14F;
			this.label238.HyperLink = null;
			this.label238.Left = 8.368918F;
			this.label238.Name = "label238";
			this.label238.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label238.Text = "(フリガナ)";
			this.label238.Top = 5.389714F;
			this.label238.Width = 0.33F;
			// 
			// label240
			// 
			this.label240.Height = 0.2F;
			this.label240.HyperLink = null;
			this.label240.Left = 9.947917F;
			this.label240.Name = "label240";
			this.label240.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label240.Text = "区分";
			this.label240.Top = 5.409714F;
			this.label240.Width = 0.1F;
			// 
			// line211
			// 
			this.line211.Height = 0F;
			this.line211.Left = 8.388917F;
			this.line211.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line211.LineWeight = 1F;
			this.line211.Name = "line211";
			this.line211.Top = 5.924714F;
			this.line211.Width = 1.51F;
			this.line211.X1 = 8.388917F;
			this.line211.X2 = 9.898917F;
			this.line211.Y1 = 5.924714F;
			this.line211.Y2 = 5.924714F;
			// 
			// line212
			// 
			this.line212.Height = 0.2819996F;
			this.line212.Left = 9.898917F;
			this.line212.LineWeight = 1F;
			this.line212.Name = "line212";
			this.line212.Top = 5.784714F;
			this.line212.Width = 0F;
			this.line212.X1 = 9.898917F;
			this.line212.X2 = 9.898917F;
			this.line212.Y1 = 5.784714F;
			this.line212.Y2 = 6.066714F;
			// 
			// line213
			// 
			this.line213.Height = 0.2819996F;
			this.line213.Left = 10.08892F;
			this.line213.LineWeight = 1F;
			this.line213.Name = "line213";
			this.line213.Top = 5.784714F;
			this.line213.Width = 0F;
			this.line213.X1 = 10.08892F;
			this.line213.X2 = 10.08892F;
			this.line213.Y1 = 5.784714F;
			this.line213.Y2 = 6.066714F;
			// 
			// line214
			// 
			this.line214.Height = 0F;
			this.line214.Left = 8.388917F;
			this.line214.LineWeight = 1F;
			this.line214.Name = "line214";
			this.line214.Top = 6.066714F;
			this.line214.Width = 1.950003F;
			this.line214.X1 = 8.388917F;
			this.line214.X2 = 10.33892F;
			this.line214.Y1 = 6.066714F;
			this.line214.Y2 = 6.066714F;
			// 
			// label241
			// 
			this.label241.Height = 0.14F;
			this.label241.HyperLink = null;
			this.label241.Left = 8.368918F;
			this.label241.Name = "label241";
			this.label241.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label241.Text = "(フリガナ)";
			this.label241.Top = 5.814714F;
			this.label241.Width = 0.33F;
			// 
			// label243
			// 
			this.label243.Height = 0.2F;
			this.label243.HyperLink = null;
			this.label243.Left = 9.947917F;
			this.label243.Name = "label243";
			this.label243.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label243.Text = "区分";
			this.label243.Top = 5.834714F;
			this.label243.Width = 0.1F;
			// 
			// line216
			// 
			this.line216.Height = 0F;
			this.line216.Left = 5.918918F;
			this.line216.LineWeight = 1F;
			this.line216.Name = "line216";
			this.line216.Top = 4.069714F;
			this.line216.Width = 5.190002F;
			this.line216.X1 = 5.918918F;
			this.line216.X2 = 11.10892F;
			this.line216.Y1 = 4.069714F;
			this.line216.Y2 = 4.069714F;
			// 
			// label244
			// 
			this.label244.Height = 0.14F;
			this.label244.HyperLink = null;
			this.label244.Left = 5.918918F;
			this.label244.Name = "label244";
			this.label244.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label244.Text = "控除対象";
			this.label244.Top = 4.237008F;
			this.label244.Width = 0.25F;
			// 
			// label245
			// 
			this.label245.Height = 0.14F;
			this.label245.HyperLink = null;
			this.label245.Left = 5.918918F;
			this.label245.Name = "label245";
			this.label245.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label245.Text = "配偶者";
			this.label245.Top = 4.309715F;
			this.label245.Width = 0.25F;
			// 
			// line217
			// 
			this.line217.Height = 0F;
			this.line217.Left = 6.178917F;
			this.line217.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot;
			this.line217.LineWeight = 1F;
			this.line217.Name = "line217";
			this.line217.Top = 4.209714F;
			this.line217.Width = 1.510001F;
			this.line217.X1 = 6.178917F;
			this.line217.X2 = 7.688918F;
			this.line217.Y1 = 4.209714F;
			this.line217.Y2 = 4.209714F;
			// 
			// line218
			// 
			this.line218.Height = 0F;
			this.line218.Left = 6.178917F;
			this.line218.LineWeight = 1F;
			this.line218.Name = "line218";
			this.line218.Top = 4.351714F;
			this.line218.Width = 1.950002F;
			this.line218.X1 = 6.178917F;
			this.line218.X2 = 8.128919F;
			this.line218.Y1 = 4.351714F;
			this.line218.Y2 = 4.351714F;
			// 
			// label246
			// 
			this.label246.Height = 0.2F;
			this.label246.HyperLink = null;
			this.label246.Left = 7.728918F;
			this.label246.Name = "label246";
			this.label246.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label246.Text = "区分";
			this.label246.Top = 4.119714F;
			this.label246.Width = 0.1F;
			// 
			// line219
			// 
			this.line219.Height = 0.2820001F;
			this.line219.Left = 7.878918F;
			this.line219.LineWeight = 1F;
			this.line219.Name = "line219";
			this.line219.Top = 4.069714F;
			this.line219.Width = 0F;
			this.line219.X1 = 7.878918F;
			this.line219.X2 = 7.878918F;
			this.line219.Y1 = 4.069714F;
			this.line219.Y2 = 4.351714F;
			// 
			// line220
			// 
			this.line220.Height = 0.2820001F;
			this.line220.Left = 7.688918F;
			this.line220.LineWeight = 1F;
			this.line220.Name = "line220";
			this.line220.Top = 4.069714F;
			this.line220.Width = 0F;
			this.line220.X1 = 7.688918F;
			this.line220.X2 = 7.688918F;
			this.line220.Y1 = 4.069714F;
			this.line220.Y2 = 4.351714F;
			// 
			// label247
			// 
			this.label247.Height = 0.14F;
			this.label247.HyperLink = null;
			this.label247.Left = 6.158917F;
			this.label247.Name = "label247";
			this.label247.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label247.Text = "(フリガナ)";
			this.label247.Top = 4.099715F;
			this.label247.Width = 0.33F;
			// 
			// label248
			// 
			this.label248.Height = 0.14F;
			this.label248.HyperLink = null;
			this.label248.Left = 6.178917F;
			this.label248.Name = "label248";
			this.label248.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label248.Text = "氏名";
			this.label248.Top = 4.239715F;
			this.label248.Width = 0.295F;
			// 
			// line225
			// 
			this.line225.Height = 1.129999F;
			this.line225.Left = 8.628919F;
			this.line225.LineWeight = 1F;
			this.line225.Name = "line225";
			this.line225.Top = 3.379714F;
			this.line225.Width = 0F;
			this.line225.X1 = 8.628919F;
			this.line225.X2 = 8.628919F;
			this.line225.Y1 = 3.379714F;
			this.line225.Y2 = 4.509713F;
			// 
			// label249
			// 
			this.label249.Height = 0.14F;
			this.label249.HyperLink = null;
			this.label249.Left = 8.158917F;
			this.label249.Name = "label249";
			this.label249.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label249.Text = "配偶者の";
			this.label249.Top = 4.169714F;
			this.label249.Width = 0.44F;
			// 
			// label250
			// 
			this.label250.Height = 0.14F;
			this.label250.HyperLink = null;
			this.label250.Left = 8.158917F;
			this.label250.Name = "label250";
			this.label250.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label250.Text = "合計所得";
			this.label250.Top = 4.309715F;
			this.label250.Width = 0.44F;
			// 
			// line226
			// 
			this.line226.Height = 1.129999F;
			this.line226.Left = 9.128919F;
			this.line226.LineWeight = 1F;
			this.line226.Name = "line226";
			this.line226.Top = 3.379714F;
			this.line226.Width = 0F;
			this.line226.X1 = 9.128919F;
			this.line226.X2 = 9.128919F;
			this.line226.Y1 = 3.379714F;
			this.line226.Y2 = 4.509713F;
			// 
			// line227
			// 
			this.line227.Height = 1.129999F;
			this.line227.Left = 9.628919F;
			this.line227.LineWeight = 1F;
			this.line227.Name = "line227";
			this.line227.Top = 3.379714F;
			this.line227.Width = 0F;
			this.line227.X1 = 9.628919F;
			this.line227.X2 = 9.628919F;
			this.line227.Y1 = 3.379714F;
			this.line227.Y2 = 4.509713F;
			// 
			// line228
			// 
			this.line228.Height = 1.129999F;
			this.line228.Left = 10.12892F;
			this.line228.LineWeight = 1F;
			this.line228.Name = "line228";
			this.line228.Top = 3.379714F;
			this.line228.Width = 0F;
			this.line228.X1 = 10.12892F;
			this.line228.X2 = 10.12892F;
			this.line228.Y1 = 3.379714F;
			this.line228.Y2 = 4.509713F;
			// 
			// line229
			// 
			this.line229.Height = 0.4399991F;
			this.line229.Left = 10.62892F;
			this.line229.LineWeight = 1F;
			this.line229.Name = "line229";
			this.line229.Top = 4.069714F;
			this.line229.Width = 0F;
			this.line229.X1 = 10.62892F;
			this.line229.X2 = 10.62892F;
			this.line229.Y1 = 4.069714F;
			this.line229.Y2 = 4.509713F;
			// 
			// label251
			// 
			this.label251.Height = 0.14F;
			this.label251.HyperLink = null;
			this.label251.Left = 9.159055F;
			this.label251.Name = "label251";
			this.label251.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label251.Text = "国民年金保険";
			this.label251.Top = 4.098819F;
			this.label251.Width = 0.45F;
			// 
			// label252
			// 
			this.label252.Height = 0.14F;
			this.label252.HyperLink = null;
			this.label252.Left = 9.159055F;
			this.label252.Name = "label252";
			this.label252.Style = "font-size: 5pt; text-align: center; text-justify: auto; vertical-align: top; whit" +
    "e-space: inherit; ddo-char-set: 1";
			this.label252.Text = "料等の金額";
			this.label252.Top = 4.187795F;
			this.label252.Width = 0.45F;
			// 
			// label253
			// 
			this.label253.Height = 0.14F;
			this.label253.HyperLink = null;
			this.label253.Left = 10.15906F;
			this.label253.Name = "label253";
			this.label253.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label253.Text = "旧長期損害";
			this.label253.Top = 4.098819F;
			this.label253.Width = 0.45F;
			// 
			// label254
			// 
			this.label254.Height = 0.14F;
			this.label254.HyperLink = null;
			this.label254.Left = 10.15906F;
			this.label254.Name = "label254";
			this.label254.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label254.Text = "保険料の金額";
			this.label254.Top = 4.187795F;
			this.label254.Width = 0.45F;
			// 
			// label255
			// 
			this.label255.Height = 0.153F;
			this.label255.HyperLink = null;
			this.label255.Left = 9.978917F;
			this.label255.Name = "label255";
			this.label255.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label255.Text = "円";
			this.label255.Top = 4.069714F;
			this.label255.Width = 0.125F;
			// 
			// label256
			// 
			this.label256.Height = 0.153F;
			this.label256.HyperLink = null;
			this.label256.Left = 10.95906F;
			this.label256.Name = "label256";
			this.label256.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label256.Text = "円";
			this.label256.Top = 4.05F;
			this.label256.Width = 0.125F;
			// 
			// line230
			// 
			this.line230.Height = 0F;
			this.line230.Left = 5.918918F;
			this.line230.LineWeight = 1F;
			this.line230.Name = "line230";
			this.line230.Top = 3.629714F;
			this.line230.Width = 5.190002F;
			this.line230.X1 = 5.918918F;
			this.line230.X2 = 11.10892F;
			this.line230.Y1 = 3.629714F;
			this.line230.Y2 = 3.629714F;
			// 
			// line231
			// 
			this.line231.Height = 0F;
			this.line231.Left = 6.268918F;
			this.line231.LineWeight = 1F;
			this.line231.Name = "line231";
			this.line231.Top = 3.849715F;
			this.line231.Width = 4.840002F;
			this.line231.X1 = 6.268918F;
			this.line231.X2 = 11.10892F;
			this.line231.Y1 = 3.849715F;
			this.line231.Y2 = 3.849715F;
			// 
			// line232
			// 
			this.line232.Height = 0.25F;
			this.line232.Left = 8.128919F;
			this.line232.LineWeight = 1F;
			this.line232.Name = "line232";
			this.line232.Top = 3.379714F;
			this.line232.Width = 0F;
			this.line232.X1 = 8.128919F;
			this.line232.X2 = 8.128919F;
			this.line232.Y1 = 3.379714F;
			this.line232.Y2 = 3.629714F;
			// 
			// line233
			// 
			this.line233.Height = 0F;
			this.line233.Left = 5.918918F;
			this.line233.LineWeight = 1F;
			this.line233.Name = "line233";
			this.line233.Top = 3.379714F;
			this.line233.Width = 5.190002F;
			this.line233.X1 = 5.918918F;
			this.line233.X2 = 11.10892F;
			this.line233.Y1 = 3.379714F;
			this.line233.Y2 = 3.379714F;
			// 
			// line234
			// 
			this.line234.Height = 0.25F;
			this.line234.Left = 10.62892F;
			this.line234.LineWeight = 1F;
			this.line234.Name = "line234";
			this.line234.Top = 3.379714F;
			this.line234.Width = 0F;
			this.line234.X1 = 10.62892F;
			this.line234.X2 = 10.62892F;
			this.line234.Y1 = 3.379714F;
			this.line234.Y2 = 3.629714F;
			// 
			// line235
			// 
			this.line235.Height = 0.6900001F;
			this.line235.Left = 6.268918F;
			this.line235.LineWeight = 1F;
			this.line235.Name = "line235";
			this.line235.Top = 3.379714F;
			this.line235.Width = 0F;
			this.line235.X1 = 6.268918F;
			this.line235.X2 = 6.268918F;
			this.line235.Y1 = 3.379714F;
			this.line235.Y2 = 4.069714F;
			// 
			// label257
			// 
			this.label257.Height = 0.14F;
			this.label257.HyperLink = null;
			this.label257.Left = 5.928917F;
			this.label257.Name = "label257";
			this.label257.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label257.Text = "住宅借入金";
			this.label257.Top = 3.679714F;
			this.label257.Width = 0.33F;
			// 
			// label258
			// 
			this.label258.Height = 0.14F;
			this.label258.HyperLink = null;
			this.label258.Left = 5.928917F;
			this.label258.Name = "label258";
			this.label258.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label258.Text = "等特別控除";
			this.label258.Top = 3.779715F;
			this.label258.Width = 0.33F;
			// 
			// label259
			// 
			this.label259.Height = 0.1400001F;
			this.label259.HyperLink = null;
			this.label259.Left = 5.928917F;
			this.label259.Name = "label259";
			this.label259.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label259.Text = "の額の内訳";
			this.label259.Top = 3.889714F;
			this.label259.Width = 0.33F;
			// 
			// line236
			// 
			this.line236.Height = 0.6900001F;
			this.line236.Left = 6.708918F;
			this.line236.LineWeight = 1F;
			this.line236.Name = "line236";
			this.line236.Top = 3.379714F;
			this.line236.Width = 0F;
			this.line236.X1 = 6.708918F;
			this.line236.X2 = 6.708918F;
			this.line236.Y1 = 3.379714F;
			this.line236.Y2 = 4.069714F;
			// 
			// line237
			// 
			this.line237.Height = 0.6900001F;
			this.line237.Left = 7.208918F;
			this.line237.LineWeight = 1F;
			this.line237.Name = "line237";
			this.line237.Top = 3.379714F;
			this.line237.Width = 0F;
			this.line237.X1 = 7.208918F;
			this.line237.X2 = 7.208918F;
			this.line237.Y1 = 3.379714F;
			this.line237.Y2 = 4.069714F;
			// 
			// line238
			// 
			this.line238.Height = 0.6900001F;
			this.line238.Left = 7.648918F;
			this.line238.LineWeight = 1F;
			this.line238.Name = "line238";
			this.line238.Top = 3.379714F;
			this.line238.Width = 0F;
			this.line238.X1 = 7.648918F;
			this.line238.X2 = 7.648918F;
			this.line238.Y1 = 3.379714F;
			this.line238.Y2 = 4.069714F;
			// 
			// label260
			// 
			this.label260.Height = 0.14F;
			this.label260.HyperLink = null;
			this.label260.Left = 5.928917F;
			this.label260.Name = "label260";
			this.label260.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label260.Text = "生命保険料";
			this.label260.Top = 3.389714F;
			this.label260.Width = 0.33F;
			// 
			// label261
			// 
			this.label261.Height = 0.14F;
			this.label261.HyperLink = null;
			this.label261.Left = 5.928917F;
			this.label261.Name = "label261";
			this.label261.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label261.Text = "の金額の";
			this.label261.Top = 3.459714F;
			this.label261.Width = 0.33F;
			// 
			// label262
			// 
			this.label262.Height = 0.14F;
			this.label262.HyperLink = null;
			this.label262.Left = 5.928917F;
			this.label262.Name = "label262";
			this.label262.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label262.Text = "内訳";
			this.label262.Top = 3.529715F;
			this.label262.Width = 0.33F;
			// 
			// label263
			// 
			this.label263.Height = 0.14F;
			this.label263.HyperLink = null;
			this.label263.Left = 6.278918F;
			this.label263.Name = "label263";
			this.label263.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label263.Text = "新生命保険料";
			this.label263.Top = 3.409714F;
			this.label263.Width = 0.42F;
			// 
			// label264
			// 
			this.label264.Height = 0.14F;
			this.label264.HyperLink = null;
			this.label264.Left = 6.278918F;
			this.label264.Name = "label264";
			this.label264.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label264.Text = "の金額";
			this.label264.Top = 3.509714F;
			this.label264.Width = 0.42F;
			// 
			// label265
			// 
			this.label265.Height = 0.14F;
			this.label265.HyperLink = null;
			this.label265.Left = 6.278918F;
			this.label265.Name = "label265";
			this.label265.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label265.Text = "特別控除適用数";
			this.label265.Top = 3.749714F;
			this.label265.Width = 0.42F;
			// 
			// label266
			// 
			this.label266.Height = 0.14F;
			this.label266.HyperLink = null;
			this.label266.Left = 6.278918F;
			this.label266.Name = "label266";
			this.label266.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label266.Text = "住宅借入金等";
			this.label266.Top = 3.649715F;
			this.label266.Width = 0.42F;
			// 
			// label267
			// 
			this.label267.Height = 0.14F;
			this.label267.HyperLink = null;
			this.label267.Left = 6.278918F;
			this.label267.Name = "label267";
			this.label267.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label267.Text = "住宅借入金等";
			this.label267.Top = 3.869714F;
			this.label267.Width = 0.42F;
			// 
			// label268
			// 
			this.label268.Height = 0.14F;
			this.label268.HyperLink = null;
			this.label268.Left = 6.278918F;
			this.label268.Name = "label268";
			this.label268.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label268.Text = "特別控除可能額";
			this.label268.Top = 3.969713F;
			this.label268.Width = 0.42F;
			// 
			// label269
			// 
			this.label269.Height = 0.14F;
			this.label269.HyperLink = null;
			this.label269.Left = 7.218917F;
			this.label269.Name = "label269";
			this.label269.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label269.Text = "旧生命保険料";
			this.label269.Top = 3.409714F;
			this.label269.Width = 0.42F;
			// 
			// label270
			// 
			this.label270.Height = 0.14F;
			this.label270.HyperLink = null;
			this.label270.Left = 7.218917F;
			this.label270.Name = "label270";
			this.label270.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label270.Text = "の金額";
			this.label270.Top = 3.509714F;
			this.label270.Width = 0.42F;
			// 
			// label271
			// 
			this.label271.Height = 0.14F;
			this.label271.HyperLink = null;
			this.label271.Left = 7.218917F;
			this.label271.Name = "label271";
			this.label271.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label271.Text = "日（1回目）";
			this.label271.Top = 3.749714F;
			this.label271.Width = 0.42F;
			// 
			// label272
			// 
			this.label272.Height = 0.14F;
			this.label272.HyperLink = null;
			this.label272.Left = 7.218917F;
			this.label272.Name = "label272";
			this.label272.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label272.Text = "居住開始年月";
			this.label272.Top = 3.649715F;
			this.label272.Width = 0.42F;
			// 
			// label273
			// 
			this.label273.Height = 0.14F;
			this.label273.HyperLink = null;
			this.label273.Left = 7.218917F;
			this.label273.Name = "label273";
			this.label273.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label273.Text = "日（2回目）";
			this.label273.Top = 3.969714F;
			this.label273.Width = 0.42F;
			// 
			// label274
			// 
			this.label274.Height = 0.14F;
			this.label274.HyperLink = null;
			this.label274.Left = 7.218917F;
			this.label274.Name = "label274";
			this.label274.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label274.Text = "居住開始年月";
			this.label274.Top = 3.869714F;
			this.label274.Width = 0.42F;
			// 
			// line239
			// 
			this.line239.Height = 0.4400001F;
			this.line239.Left = 8.068917F;
			this.line239.LineWeight = 0.2F;
			this.line239.Name = "line239";
			this.line239.Top = 3.629714F;
			this.line239.Width = 0F;
			this.line239.X1 = 8.068917F;
			this.line239.X2 = 8.068917F;
			this.line239.Y1 = 3.629714F;
			this.line239.Y2 = 4.069714F;
			// 
			// line240
			// 
			this.line240.Height = 0.4400001F;
			this.line240.Left = 8.348918F;
			this.line240.LineWeight = 0.2F;
			this.line240.Name = "line240";
			this.line240.Top = 3.629714F;
			this.line240.Width = 0F;
			this.line240.X1 = 8.348918F;
			this.line240.X2 = 8.348918F;
			this.line240.Y1 = 3.629714F;
			this.line240.Y2 = 4.069714F;
			// 
			// label275
			// 
			this.label275.Height = 0.153F;
			this.label275.HyperLink = null;
			this.label275.Left = 7.938918F;
			this.label275.Name = "label275";
			this.label275.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label275.Text = "年";
			this.label275.Top = 3.622714F;
			this.label275.Width = 0.125F;
			// 
			// label276
			// 
			this.label276.Height = 0.153F;
			this.label276.HyperLink = null;
			this.label276.Left = 7.938918F;
			this.label276.Name = "label276";
			this.label276.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label276.Text = "年";
			this.label276.Top = 3.845715F;
			this.label276.Width = 0.125F;
			// 
			// label277
			// 
			this.label277.Height = 0.153F;
			this.label277.HyperLink = null;
			this.label277.Left = 8.218917F;
			this.label277.Name = "label277";
			this.label277.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label277.Text = "月";
			this.label277.Top = 3.618715F;
			this.label277.Width = 0.125F;
			// 
			// label278
			// 
			this.label278.Height = 0.153F;
			this.label278.HyperLink = null;
			this.label278.Left = 8.218917F;
			this.label278.Name = "label278";
			this.label278.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label278.Text = "月";
			this.label278.Top = 3.841709F;
			this.label278.Width = 0.125F;
			// 
			// label279
			// 
			this.label279.Height = 0.153F;
			this.label279.HyperLink = null;
			this.label279.Left = 8.488917F;
			this.label279.Name = "label279";
			this.label279.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label279.Text = "日";
			this.label279.Top = 3.614715F;
			this.label279.Width = 0.125F;
			// 
			// label280
			// 
			this.label280.Height = 0.153F;
			this.label280.HyperLink = null;
			this.label280.Left = 8.488917F;
			this.label280.Name = "label280";
			this.label280.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label280.Text = "日";
			this.label280.Top = 3.837705F;
			this.label280.Width = 0.125F;
			// 
			// label281
			// 
			this.label281.Height = 0.14F;
			this.label281.HyperLink = null;
			this.label281.Left = 8.168918F;
			this.label281.Name = "label281";
			this.label281.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label281.Text = "介護医療保";
			this.label281.Top = 3.409714F;
			this.label281.Width = 0.42F;
			// 
			// label282
			// 
			this.label282.Height = 0.14F;
			this.label282.HyperLink = null;
			this.label282.Left = 8.168918F;
			this.label282.Name = "label282";
			this.label282.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label282.Text = "険料の金額";
			this.label282.Top = 3.509714F;
			this.label282.Width = 0.42F;
			// 
			// label283
			// 
			this.label283.Height = 0.153F;
			this.label283.HyperLink = null;
			this.label283.Left = 8.978917F;
			this.label283.Name = "label283";
			this.label283.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label283.Text = "円";
			this.label283.Top = 3.369714F;
			this.label283.Width = 0.125F;
			// 
			// label284
			// 
			this.label284.Height = 0.14F;
			this.label284.HyperLink = null;
			this.label284.Left = 8.628919F;
			this.label284.Name = "label284";
			this.label284.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label284.Text = "住宅借入金等特別";
			this.label284.Top = 3.649715F;
			this.label284.Width = 0.48F;
			// 
			// label285
			// 
			this.label285.Height = 0.14F;
			this.label285.HyperLink = null;
			this.label285.Left = 8.628919F;
			this.label285.Name = "label285";
			this.label285.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label285.Text = "控除区分(1回目)";
			this.label285.Top = 3.749714F;
			this.label285.Width = 0.48F;
			// 
			// label286
			// 
			this.label286.Height = 0.14F;
			this.label286.HyperLink = null;
			this.label286.Left = 8.628919F;
			this.label286.Name = "label286";
			this.label286.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label286.Text = "住宅借入金等特別";
			this.label286.Top = 3.869714F;
			this.label286.Width = 0.48F;
			// 
			// label287
			// 
			this.label287.Height = 0.14F;
			this.label287.HyperLink = null;
			this.label287.Left = 8.628919F;
			this.label287.Name = "label287";
			this.label287.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label287.Text = "控除区分(2回目)";
			this.label287.Top = 3.969713F;
			this.label287.Width = 0.48F;
			// 
			// label288
			// 
			this.label288.Height = 0.14F;
			this.label288.HyperLink = null;
			this.label288.Left = 9.168918F;
			this.label288.Name = "label288";
			this.label288.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label288.Text = "保険料の金額";
			this.label288.Top = 3.509714F;
			this.label288.Width = 0.42F;
			// 
			// label289
			// 
			this.label289.Height = 0.14F;
			this.label289.HyperLink = null;
			this.label289.Left = 9.168918F;
			this.label289.Name = "label289";
			this.label289.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label289.Text = "新個人年金";
			this.label289.Top = 3.409714F;
			this.label289.Width = 0.42F;
			// 
			// label290
			// 
			this.label290.Height = 0.153F;
			this.label290.HyperLink = null;
			this.label290.Left = 9.978917F;
			this.label290.Name = "label290";
			this.label290.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label290.Text = "円";
			this.label290.Top = 3.369714F;
			this.label290.Width = 0.125F;
			// 
			// label291
			// 
			this.label291.Height = 0.14F;
			this.label291.HyperLink = null;
			this.label291.Left = 9.628919F;
			this.label291.Name = "label291";
			this.label291.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label291.Text = "住宅借入金等";
			this.label291.Top = 3.649715F;
			this.label291.Width = 0.48F;
			// 
			// label292
			// 
			this.label292.Height = 0.14F;
			this.label292.HyperLink = null;
			this.label292.Left = 9.628919F;
			this.label292.Name = "label292";
			this.label292.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label292.Text = "年末残高(1回目)";
			this.label292.Top = 3.749713F;
			this.label292.Width = 0.48F;
			// 
			// label293
			// 
			this.label293.Height = 0.14F;
			this.label293.HyperLink = null;
			this.label293.Left = 9.628919F;
			this.label293.Name = "label293";
			this.label293.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label293.Text = "住宅借入金等";
			this.label293.Top = 3.869714F;
			this.label293.Width = 0.48F;
			// 
			// label294
			// 
			this.label294.Height = 0.14F;
			this.label294.HyperLink = null;
			this.label294.Left = 9.628919F;
			this.label294.Name = "label294";
			this.label294.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label294.Text = "年末残高(2回目)";
			this.label294.Top = 3.969714F;
			this.label294.Width = 0.48F;
			// 
			// label295
			// 
			this.label295.Height = 0.14F;
			this.label295.HyperLink = null;
			this.label295.Left = 10.16892F;
			this.label295.Name = "label295";
			this.label295.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label295.Text = "旧個人年金";
			this.label295.Top = 3.409714F;
			this.label295.Width = 0.42F;
			// 
			// label296
			// 
			this.label296.Height = 0.14F;
			this.label296.HyperLink = null;
			this.label296.Left = 10.16892F;
			this.label296.Name = "label296";
			this.label296.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label296.Text = "保険料の金額";
			this.label296.Top = 3.509714F;
			this.label296.Width = 0.42F;
			// 
			// label297
			// 
			this.label297.Height = 0.153F;
			this.label297.HyperLink = null;
			this.label297.Left = 10.95892F;
			this.label297.Name = "label297";
			this.label297.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label297.Text = "円";
			this.label297.Top = 3.369714F;
			this.label297.Width = 0.125F;
			// 
			// label298
			// 
			this.label298.Height = 0.153F;
			this.label298.HyperLink = null;
			this.label298.Left = 10.95892F;
			this.label298.Name = "label298";
			this.label298.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label298.Text = "円";
			this.label298.Top = 3.622714F;
			this.label298.Width = 0.125F;
			// 
			// label299
			// 
			this.label299.Height = 0.153F;
			this.label299.HyperLink = null;
			this.label299.Left = 10.95892F;
			this.label299.Name = "label299";
			this.label299.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label299.Text = "円";
			this.label299.Top = 3.855714F;
			this.label299.Width = 0.125F;
			// 
			// line241
			// 
			this.line241.Height = 0F;
			this.line241.Left = 5.918918F;
			this.line241.LineWeight = 1F;
			this.line241.Name = "line241";
			this.line241.Top = 2.679714F;
			this.line241.Width = 5.190002F;
			this.line241.X1 = 5.918918F;
			this.line241.X2 = 11.10892F;
			this.line241.Y1 = 2.679714F;
			this.line241.Y2 = 2.679714F;
			// 
			// line242
			// 
			this.line242.Height = 0F;
			this.line242.Left = 5.918918F;
			this.line242.LineWeight = 1F;
			this.line242.Name = "line242";
			this.line242.Top = 2.379714F;
			this.line242.Width = 5.190002F;
			this.line242.X1 = 5.918918F;
			this.line242.X2 = 11.10892F;
			this.line242.Y1 = 2.379714F;
			this.line242.Y2 = 2.379714F;
			// 
			// line243
			// 
			this.line243.Height = 0F;
			this.line243.Left = 5.918918F;
			this.line243.LineWeight = 1F;
			this.line243.Name = "line243";
			this.line243.Top = 2.209714F;
			this.line243.Width = 5.190002F;
			this.line243.X1 = 5.918918F;
			this.line243.X2 = 11.10892F;
			this.line243.Y1 = 2.209714F;
			this.line243.Y2 = 2.209714F;
			// 
			// line244
			// 
			this.line244.Height = 0.47F;
			this.line244.Left = 7.208918F;
			this.line244.LineWeight = 1F;
			this.line244.Name = "line244";
			this.line244.Top = 2.209714F;
			this.line244.Width = 0F;
			this.line244.X1 = 7.208918F;
			this.line244.X2 = 7.208918F;
			this.line244.Y1 = 2.209714F;
			this.line244.Y2 = 2.679714F;
			// 
			// line245
			// 
			this.line245.Height = 0.47F;
			this.line245.Left = 8.498918F;
			this.line245.LineWeight = 1F;
			this.line245.Name = "line245";
			this.line245.Top = 2.209714F;
			this.line245.Width = 0F;
			this.line245.X1 = 8.498918F;
			this.line245.X2 = 8.498918F;
			this.line245.Y1 = 2.209714F;
			this.line245.Y2 = 2.679714F;
			// 
			// line246
			// 
			this.line246.Height = 1.17F;
			this.line246.Left = 9.788918F;
			this.line246.LineWeight = 1F;
			this.line246.Name = "line246";
			this.line246.Top = 1.509714F;
			this.line246.Width = 0F;
			this.line246.X1 = 9.788918F;
			this.line246.X2 = 9.788918F;
			this.line246.Y1 = 1.509714F;
			this.line246.Y2 = 2.679714F;
			// 
			// label300
			// 
			this.label300.Height = 0.1530001F;
			this.label300.HyperLink = null;
			this.label300.Left = 7.068918F;
			this.label300.Name = "label300";
			this.label300.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label300.Text = "円";
			this.label300.Top = 2.389714F;
			this.label300.Width = 0.125F;
			// 
			// label301
			// 
			this.label301.Height = 0.153F;
			this.label301.HyperLink = null;
			this.label301.Left = 8.358918F;
			this.label301.Name = "label301";
			this.label301.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label301.Text = "円";
			this.label301.Top = 2.389714F;
			this.label301.Width = 0.125F;
			// 
			// label302
			// 
			this.label302.Height = 0.153F;
			this.label302.HyperLink = null;
			this.label302.Left = 9.648917F;
			this.label302.Name = "label302";
			this.label302.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label302.Text = "円";
			this.label302.Top = 2.389714F;
			this.label302.Width = 0.125F;
			// 
			// label303
			// 
			this.label303.Height = 0.15F;
			this.label303.HyperLink = null;
			this.label303.Left = 9.808919F;
			this.label303.Name = "label303";
			this.label303.Style = "font-size: 6pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label303.Text = "住宅借入金等特別控除の額";
			this.label303.Top = 2.219714F;
			this.label303.Width = 1.27F;
			// 
			// label304
			// 
			this.label304.Height = 0.153F;
			this.label304.HyperLink = null;
			this.label304.Left = 10.95892F;
			this.label304.Name = "label304";
			this.label304.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label304.Text = "円";
			this.label304.Top = 2.389714F;
			this.label304.Width = 0.125F;
			// 
			// line247
			// 
			this.line247.Height = 0F;
			this.line247.Left = 5.918918F;
			this.line247.LineWeight = 1F;
			this.line247.Name = "line247";
			this.line247.Top = 1.509714F;
			this.line247.Width = 5.190002F;
			this.line247.X1 = 5.918918F;
			this.line247.X2 = 11.10892F;
			this.line247.Y1 = 1.509714F;
			this.line247.Y2 = 1.509714F;
			// 
			// line248
			// 
			this.line248.Height = 0.3499999F;
			this.line248.Left = 6.153918F;
			this.line248.LineWeight = 1F;
			this.line248.Name = "line248";
			this.line248.Top = 1.859714F;
			this.line248.Width = 0F;
			this.line248.X1 = 6.153918F;
			this.line248.X2 = 6.153918F;
			this.line248.Y1 = 1.859714F;
			this.line248.Y2 = 2.209714F;
			// 
			// line249
			// 
			this.line249.Height = 0F;
			this.line249.Left = 6.388917F;
			this.line249.LineWeight = 1F;
			this.line249.Name = "line249";
			this.line249.Top = 1.684715F;
			this.line249.Width = 0.2350011F;
			this.line249.X1 = 6.388917F;
			this.line249.X2 = 6.623918F;
			this.line249.Y1 = 1.684715F;
			this.line249.Y2 = 1.684715F;
			// 
			// line250
			// 
			this.line250.Height = 0.5249989F;
			this.line250.Left = 6.388917F;
			this.line250.LineWeight = 1F;
			this.line250.Name = "line250";
			this.line250.Top = 1.684715F;
			this.line250.Width = 0F;
			this.line250.X1 = 6.388917F;
			this.line250.X2 = 6.388917F;
			this.line250.Y1 = 1.684715F;
			this.line250.Y2 = 2.209714F;
			// 
			// label305
			// 
			this.label305.Height = 0.15F;
			this.label305.HyperLink = null;
			this.label305.Left = 7.338917F;
			this.label305.Name = "label305";
			this.label305.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label305.Text = "円";
			this.label305.Top = 1.899714F;
			this.label305.Width = 0.125F;
			// 
			// line251
			// 
			this.line251.Height = 0.3499999F;
			this.line251.Left = 7.813918F;
			this.line251.LineWeight = 1F;
			this.line251.Name = "line251";
			this.line251.Top = 1.859714F;
			this.line251.Width = 0F;
			this.line251.X1 = 7.813918F;
			this.line251.X2 = 7.813918F;
			this.line251.Y1 = 1.859714F;
			this.line251.Y2 = 2.209714F;
			// 
			// line252
			// 
			this.line252.Height = 0.4499999F;
			this.line252.Left = 8.048917F;
			this.line252.LineWeight = 1F;
			this.line252.Name = "line252";
			this.line252.Top = 1.759714F;
			this.line252.Width = 0F;
			this.line252.X1 = 8.048917F;
			this.line252.X2 = 8.048917F;
			this.line252.Y1 = 1.759714F;
			this.line252.Y2 = 2.209714F;
			// 
			// label306
			// 
			this.label306.Height = 0.11F;
			this.label306.HyperLink = null;
			this.label306.Left = 9.403918F;
			this.label306.Name = "label306";
			this.label306.Style = "font-size: 5.5pt; text-align: center; vertical-align: top; white-space: inherit; " +
    "ddo-char-set: 1";
			this.label306.Text = "の数";
			this.label306.Top = 1.739714F;
			this.label306.Width = 0.375F;
			// 
			// line253
			// 
			this.line253.Height = 0F;
			this.line253.Left = 9.788918F;
			this.line253.LineWeight = 1F;
			this.line253.Name = "line253";
			this.line253.Top = 1.759714F;
			this.line253.Width = 0.9600029F;
			this.line253.X1 = 9.788918F;
			this.line253.X2 = 10.74892F;
			this.line253.Y1 = 1.759714F;
			this.line253.Y2 = 1.759714F;
			// 
			// textBox75
			// 
			this.textBox75.CanGrow = false;
			this.textBox75.DataField = "NON_RESIDENT_NUM";
			this.textBox75.Height = 0.15F;
			this.textBox75.Left = 10.84892F;
			this.textBox75.Name = "textBox75";
			this.textBox75.Style = "font-size: 7pt; text-align: right; vertical-align: bottom; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox75.Text = "Z9";
			this.textBox75.Top = 2.029714F;
			this.textBox75.Width = 0.15F;
			// 
			// label307
			// 
			this.label307.Height = 0.15F;
			this.label307.HyperLink = null;
			this.label307.Left = 10.97892F;
			this.label307.Name = "label307";
			this.label307.Style = "font-size: 5pt; text-align: center; vertical-align: top; ddo-char-set: 1";
			this.label307.Text = "人";
			this.label307.Top = 1.899714F;
			this.label307.Width = 0.1F;
			// 
			// line254
			// 
			this.line254.Height = 0F;
			this.line254.Left = 8.745917F;
			this.line254.LineWeight = 1F;
			this.line254.Name = "line254";
			this.line254.Top = 0.689714F;
			this.line254.Width = 2.362923F;
			this.line254.X1 = 8.745917F;
			this.line254.X2 = 11.10884F;
			this.line254.Y1 = 0.689714F;
			this.line254.Y2 = 0.689714F;
			// 
			// line255
			// 
			this.line255.Height = 0F;
			this.line255.Left = 8.935918F;
			this.line255.LineWeight = 1F;
			this.line255.Name = "line255";
			this.line255.Top = 0.8097149F;
			this.line255.Width = 2.172922F;
			this.line255.X1 = 8.935918F;
			this.line255.X2 = 11.10884F;
			this.line255.Y1 = 0.8097149F;
			this.line255.Y2 = 0.8097149F;
			// 
			// label311
			// 
			this.label311.Height = 0.156F;
			this.label311.HyperLink = null;
			this.label311.Left = 8.815748F;
			this.label311.Name = "label311";
			this.label311.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label311.Text = "(個人番号）";
			this.label311.Top = 0.3216535F;
			this.label311.Width = 0.543F;
			// 
			// line256
			// 
			this.line256.Height = 0.1700291F;
			this.line256.Left = 9.444919F;
			this.line256.LineWeight = 1F;
			this.line256.Name = "line256";
			this.line256.Top = 0.319685F;
			this.line256.Width = 0F;
			this.line256.X1 = 9.444919F;
			this.line256.X2 = 9.444919F;
			this.line256.Y1 = 0.319685F;
			this.line256.Y2 = 0.4897141F;
			// 
			// line257
			// 
			this.line257.Height = 0.1700291F;
			this.line257.Left = 9.994918F;
			this.line257.LineWeight = 1F;
			this.line257.Name = "line257";
			this.line257.Top = 0.319685F;
			this.line257.Width = 0F;
			this.line257.X1 = 9.994918F;
			this.line257.X2 = 9.994918F;
			this.line257.Y1 = 0.319685F;
			this.line257.Y2 = 0.4897141F;
			// 
			// line258
			// 
			this.line258.Height = 0.1700291F;
			this.line258.Left = 10.54492F;
			this.line258.LineWeight = 1F;
			this.line258.Name = "line258";
			this.line258.Top = 0.319685F;
			this.line258.Width = 0F;
			this.line258.X1 = 10.54492F;
			this.line258.X2 = 10.54492F;
			this.line258.Y1 = 0.319685F;
			this.line258.Y2 = 0.4897141F;
			// 
			// line27
			// 
			this.line27.Height = 0.7003927F;
			this.line27.Left = 0.905F;
			this.line27.LineWeight = 1F;
			this.line27.Name = "line27";
			this.line27.Top = 6.899607F;
			this.line27.Width = 0.0001182556F;
			this.line27.X1 = 0.9051182F;
			this.line27.X2 = 0.905F;
			this.line27.Y1 = 6.899607F;
			this.line27.Y2 = 7.6F;
			// 
			// label37
			// 
			this.label37.Height = 0.14F;
			this.label37.HyperLink = null;
			this.label37.Left = 6.188999F;
			this.label37.Name = "label37";
			this.label37.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label37.Text = "個人番号";
			this.label37.Top = 4.399F;
			this.label37.Width = 0.275F;
			// 
			// label312
			// 
			this.label312.Height = 0.14F;
			this.label312.HyperLink = null;
			this.label312.Left = 6.188999F;
			this.label312.Name = "label312";
			this.label312.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label312.Text = "個人番号";
			this.label312.Top = 5.249F;
			this.label312.Width = 0.275F;
			// 
			// label313
			// 
			this.label313.Height = 0.14F;
			this.label313.HyperLink = null;
			this.label313.Left = 6.188999F;
			this.label313.Name = "label313";
			this.label313.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label313.Text = "個人番号";
			this.label313.Top = 5.669F;
			this.label313.Width = 0.275F;
			// 
			// label314
			// 
			this.label314.Height = 0.14F;
			this.label314.HyperLink = null;
			this.label314.Left = 6.188999F;
			this.label314.Name = "label314";
			this.label314.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label314.Text = "個人番号";
			this.label314.Top = 6.099F;
			this.label314.Width = 0.275F;
			// 
			// line28
			// 
			this.line28.Height = 0.158F;
			this.line28.Left = 7.578999F;
			this.line28.LineWeight = 1F;
			this.line28.Name = "line28";
			this.line28.Top = 4.352F;
			this.line28.Width = 0F;
			this.line28.X1 = 7.578999F;
			this.line28.X2 = 7.578999F;
			this.line28.Y1 = 4.352F;
			this.line28.Y2 = 4.51F;
			// 
			// line29
			// 
			this.line29.Height = 0.158F;
			this.line29.Left = 7.028999F;
			this.line29.LineWeight = 1F;
			this.line29.Name = "line29";
			this.line29.Top = 4.352F;
			this.line29.Width = 0F;
			this.line29.X1 = 7.028999F;
			this.line29.X2 = 7.028999F;
			this.line29.Y1 = 4.352F;
			this.line29.Y2 = 4.51F;
			// 
			// line265
			// 
			this.line265.Height = 0.1430001F;
			this.line265.Left = 7.028999F;
			this.line265.LineWeight = 1F;
			this.line265.Name = "line265";
			this.line265.Top = 4.792F;
			this.line265.Width = 0F;
			this.line265.X1 = 7.028999F;
			this.line265.X2 = 7.028999F;
			this.line265.Y1 = 4.792F;
			this.line265.Y2 = 4.935F;
			// 
			// line266
			// 
			this.line266.Height = 0.1430001F;
			this.line266.Left = 7.578999F;
			this.line266.LineWeight = 1F;
			this.line266.Name = "line266";
			this.line266.Top = 4.792F;
			this.line266.Width = 0F;
			this.line266.X1 = 7.578999F;
			this.line266.X2 = 7.578999F;
			this.line266.Y1 = 4.792F;
			this.line266.Y2 = 4.935F;
			// 
			// line267
			// 
			this.line267.Height = 0.1430001F;
			this.line267.Left = 7.028999F;
			this.line267.LineWeight = 1F;
			this.line267.Name = "line267";
			this.line267.Top = 5.217F;
			this.line267.Width = 0F;
			this.line267.X1 = 7.028999F;
			this.line267.X2 = 7.028999F;
			this.line267.Y1 = 5.217F;
			this.line267.Y2 = 5.36F;
			// 
			// line268
			// 
			this.line268.Height = 0.1430001F;
			this.line268.Left = 7.578999F;
			this.line268.LineWeight = 1F;
			this.line268.Name = "line268";
			this.line268.Top = 5.217F;
			this.line268.Width = 0F;
			this.line268.X1 = 7.578999F;
			this.line268.X2 = 7.578999F;
			this.line268.Y1 = 5.217F;
			this.line268.Y2 = 5.36F;
			// 
			// line269
			// 
			this.line269.Height = 0.1429996F;
			this.line269.Left = 7.028999F;
			this.line269.LineWeight = 1F;
			this.line269.Name = "line269";
			this.line269.Top = 5.642F;
			this.line269.Width = 0F;
			this.line269.X1 = 7.028999F;
			this.line269.X2 = 7.028999F;
			this.line269.Y1 = 5.642F;
			this.line269.Y2 = 5.785F;
			// 
			// line270
			// 
			this.line270.Height = 0.1429996F;
			this.line270.Left = 7.578999F;
			this.line270.LineWeight = 1F;
			this.line270.Name = "line270";
			this.line270.Top = 5.642F;
			this.line270.Width = 0F;
			this.line270.X1 = 7.578999F;
			this.line270.X2 = 7.578999F;
			this.line270.Y1 = 5.642F;
			this.line270.Y2 = 5.785F;
			// 
			// line271
			// 
			this.line271.Height = 0.1430001F;
			this.line271.Left = 7.578999F;
			this.line271.LineWeight = 1F;
			this.line271.Name = "line271";
			this.line271.Top = 6.067F;
			this.line271.Width = 0F;
			this.line271.X1 = 7.578999F;
			this.line271.X2 = 7.578999F;
			this.line271.Y1 = 6.067F;
			this.line271.Y2 = 6.21F;
			// 
			// line272
			// 
			this.line272.Height = 0.1430001F;
			this.line272.Left = 7.028999F;
			this.line272.LineWeight = 1F;
			this.line272.Name = "line272";
			this.line272.Top = 6.067F;
			this.line272.Width = 0F;
			this.line272.X1 = 7.028999F;
			this.line272.X2 = 7.028999F;
			this.line272.Y1 = 6.067F;
			this.line272.Y2 = 6.21F;
			// 
			// CorpNumber
			// 
			this.CorpNumber.CanGrow = false;
			this.CorpNumber.DataField = "CORP_NUMBER";
			this.CorpNumber.Height = 0.2F;
			this.CorpNumber.Left = 8.914001F;
			this.CorpNumber.MultiLine = false;
			this.CorpNumber.Name = "CorpNumber";
			this.CorpNumber.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: inherit;" +
    " ddo-char-set: 1";
			this.CorpNumber.Text = null;
			this.CorpNumber.Top = 6.929F;
			this.CorpNumber.Visible = false;
			this.CorpNumber.Width = 0.3F;
			// 
			// label316
			// 
			this.label316.Height = 0.153F;
			this.label316.HyperLink = null;
			this.label316.Left = 1.335F;
			this.label316.Name = "label316";
			this.label316.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label316.Text = "円";
			this.label316.Top = 3.838F;
			this.label316.Width = 0.125F;
			// 
			// HousingObtDedPsblAmtText
			// 
			this.HousingObtDedPsblAmtText.CanGrow = false;
			this.HousingObtDedPsblAmtText.DataField = "HOUSING_OBT_DED_PSBL_AMT";
			this.HousingObtDedPsblAmtText.Height = 0.15F;
			this.HousingObtDedPsblAmtText.Left = 1.005F;
			this.HousingObtDedPsblAmtText.Name = "HousingObtDedPsblAmtText";
			this.HousingObtDedPsblAmtText.OutputFormat = "#,##0";
			this.HousingObtDedPsblAmtText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingObtDedPsblAmtText.Text = "ZZ,ZZZ,ZZ6";
			this.HousingObtDedPsblAmtText.Top = 3.936F;
			this.HousingObtDedPsblAmtText.Width = 0.45F;
			// 
			// label317
			// 
			this.label317.Height = 0.153F;
			this.label317.HyperLink = null;
			this.label317.Left = 7.063999F;
			this.label317.Name = "label317";
			this.label317.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.label317.Text = "円";
			this.label317.Top = 3.848001F;
			this.label317.Width = 0.125F;
			// 
			// textBox1
			// 
			this.textBox1.CanGrow = false;
			this.textBox1.DataField = "HOUSING_OBT_DED_PSBL_AMT";
			this.textBox1.Height = 0.15F;
			this.textBox1.Left = 6.734F;
			this.textBox1.Name = "textBox1";
			this.textBox1.OutputFormat = "#,##0";
			this.textBox1.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox1.Text = "ZZ,ZZZ,ZZ6";
			this.textBox1.Top = 3.936F;
			this.textBox1.Width = 0.45F;
			// 
			// HousingMovingDateYText
			// 
			this.HousingMovingDateYText.CanGrow = false;
			this.HousingMovingDateYText.Height = 0.15F;
			this.HousingMovingDateYText.Left = 1.943F;
			this.HousingMovingDateYText.Name = "HousingMovingDateYText";
			this.HousingMovingDateYText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateYText.Text = "9999";
			this.HousingMovingDateYText.Top = 3.698F;
			this.HousingMovingDateYText.Width = 0.25F;
			// 
			// HousingMovingDate2YText
			// 
			this.HousingMovingDate2YText.CanGrow = false;
			this.HousingMovingDate2YText.Height = 0.15F;
			this.HousingMovingDate2YText.Left = 1.943F;
			this.HousingMovingDate2YText.Name = "HousingMovingDate2YText";
			this.HousingMovingDate2YText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2YText.Text = "9999";
			this.HousingMovingDate2YText.Top = 3.926F;
			this.HousingMovingDate2YText.Width = 0.25F;
			// 
			// HousingMovingDateMText
			// 
			this.HousingMovingDateMText.CanGrow = false;
			this.HousingMovingDateMText.Height = 0.15F;
			this.HousingMovingDateMText.Left = 2.413F;
			this.HousingMovingDateMText.Name = "HousingMovingDateMText";
			this.HousingMovingDateMText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateMText.Text = "99";
			this.HousingMovingDateMText.Top = 3.696006F;
			this.HousingMovingDateMText.Width = 0.13F;
			// 
			// HousingMovingDate2MText
			// 
			this.HousingMovingDate2MText.CanGrow = false;
			this.HousingMovingDate2MText.Height = 0.15F;
			this.HousingMovingDate2MText.Left = 2.413F;
			this.HousingMovingDate2MText.Name = "HousingMovingDate2MText";
			this.HousingMovingDate2MText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2MText.Text = "99";
			this.HousingMovingDate2MText.Top = 3.934F;
			this.HousingMovingDate2MText.Width = 0.13F;
			// 
			// HousingMovingDateDText
			// 
			this.HousingMovingDateDText.CanGrow = false;
			this.HousingMovingDateDText.Height = 0.15F;
			this.HousingMovingDateDText.Left = 2.683F;
			this.HousingMovingDateDText.Name = "HousingMovingDateDText";
			this.HousingMovingDateDText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateDText.Text = "99";
			this.HousingMovingDateDText.Top = 3.694F;
			this.HousingMovingDateDText.Width = 0.13F;
			// 
			// HousingMovingDate2DText
			// 
			this.HousingMovingDate2DText.CanGrow = false;
			this.HousingMovingDate2DText.Height = 0.15F;
			this.HousingMovingDate2DText.Left = 2.683F;
			this.HousingMovingDate2DText.Name = "HousingMovingDate2DText";
			this.HousingMovingDate2DText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2DText.Text = "99";
			this.HousingMovingDate2DText.Top = 3.931989F;
			this.HousingMovingDate2DText.Width = 0.13F;
			// 
			// HousingMovingDateText
			// 
			this.HousingMovingDateText.CanGrow = false;
			this.HousingMovingDateText.DataField = "HOUSING_MOVING_DATE";
			this.HousingMovingDateText.Height = 0.08000016F;
			this.HousingMovingDateText.Left = 2F;
			this.HousingMovingDateText.Name = "HousingMovingDateText";
			this.HousingMovingDateText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateText.Text = "9999";
			this.HousingMovingDateText.Top = 3.67F;
			this.HousingMovingDateText.Visible = false;
			this.HousingMovingDateText.Width = 0.204F;
			// 
			// HousingMovingDate2Text
			// 
			this.HousingMovingDate2Text.CanGrow = false;
			this.HousingMovingDate2Text.DataField = "HOUSING_MOVING_DATE2";
			this.HousingMovingDate2Text.Height = 0.08000014F;
			this.HousingMovingDate2Text.Left = 2F;
			this.HousingMovingDate2Text.Name = "HousingMovingDate2Text";
			this.HousingMovingDate2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2Text.Text = "9999";
			this.HousingMovingDate2Text.Top = 3.9F;
			this.HousingMovingDate2Text.Visible = false;
			this.HousingMovingDate2Text.Width = 0.204F;
			// 
			// HousingMovingDateY2Text
			// 
			this.HousingMovingDateY2Text.CanGrow = false;
			this.HousingMovingDateY2Text.Height = 0.15F;
			this.HousingMovingDateY2Text.Left = 7.663001F;
			this.HousingMovingDateY2Text.Name = "HousingMovingDateY2Text";
			this.HousingMovingDateY2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateY2Text.Text = "9999";
			this.HousingMovingDateY2Text.Top = 3.698F;
			this.HousingMovingDateY2Text.Width = 0.25F;
			// 
			// HousingMovingDate2Y2Text
			// 
			this.HousingMovingDate2Y2Text.CanGrow = false;
			this.HousingMovingDate2Y2Text.Height = 0.15F;
			this.HousingMovingDate2Y2Text.Left = 7.663001F;
			this.HousingMovingDate2Y2Text.Name = "HousingMovingDate2Y2Text";
			this.HousingMovingDate2Y2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2Y2Text.Text = "9999";
			this.HousingMovingDate2Y2Text.Top = 3.925995F;
			this.HousingMovingDate2Y2Text.Width = 0.25F;
			// 
			// HousingMovingDate2M2Text
			// 
			this.HousingMovingDate2M2Text.CanGrow = false;
			this.HousingMovingDate2M2Text.Height = 0.15F;
			this.HousingMovingDate2M2Text.Left = 8.133015F;
			this.HousingMovingDate2M2Text.Name = "HousingMovingDate2M2Text";
			this.HousingMovingDate2M2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2M2Text.Text = "99";
			this.HousingMovingDate2M2Text.Top = 3.933995F;
			this.HousingMovingDate2M2Text.Width = 0.13F;
			// 
			// HousingMovingDateM2Text
			// 
			this.HousingMovingDateM2Text.CanGrow = false;
			this.HousingMovingDateM2Text.Height = 0.15F;
			this.HousingMovingDateM2Text.Left = 8.133015F;
			this.HousingMovingDateM2Text.Name = "HousingMovingDateM2Text";
			this.HousingMovingDateM2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateM2Text.Text = "99";
			this.HousingMovingDateM2Text.Top = 3.696006F;
			this.HousingMovingDateM2Text.Width = 0.13F;
			// 
			// HousingMovingDateD2Text
			// 
			this.HousingMovingDateD2Text.CanGrow = false;
			this.HousingMovingDateD2Text.Height = 0.15F;
			this.HousingMovingDateD2Text.Left = 8.403027F;
			this.HousingMovingDateD2Text.Name = "HousingMovingDateD2Text";
			this.HousingMovingDateD2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDateD2Text.Text = "99";
			this.HousingMovingDateD2Text.Top = 3.694F;
			this.HousingMovingDateD2Text.Width = 0.13F;
			// 
			// HousingMovingDate2D2Text
			// 
			this.HousingMovingDate2D2Text.CanGrow = false;
			this.HousingMovingDate2D2Text.Height = 0.15F;
			this.HousingMovingDate2D2Text.Left = 8.403027F;
			this.HousingMovingDate2D2Text.Name = "HousingMovingDate2D2Text";
			this.HousingMovingDate2D2Text.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.HousingMovingDate2D2Text.Text = "99";
			this.HousingMovingDate2D2Text.Top = 3.931985F;
			this.HousingMovingDate2D2Text.Width = 0.13F;
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
			this.SpecDedTypeText.Top = 3.682F;
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
			this.SpecDedType2Text.Top = 3.922F;
			this.SpecDedType2Text.Width = 0.4822835F;
			// 
			// textBox2
			// 
			this.textBox2.CanGrow = false;
			this.textBox2.DataField = "SPEC_DED_TYPE1";
			this.textBox2.Height = 0.15F;
			this.textBox2.Left = 9.137402F;
			this.textBox2.Name = "textBox2";
			this.textBox2.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox2.Text = "増(特特特)";
			this.textBox2.Top = 3.682F;
			this.textBox2.Width = 0.4822835F;
			// 
			// textBox3
			// 
			this.textBox3.CanGrow = false;
			this.textBox3.DataField = "SPEC_DED_TYPE2";
			this.textBox3.Height = 0.15F;
			this.textBox3.Left = 9.137402F;
			this.textBox3.Name = "textBox3";
			this.textBox3.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox3.Text = "増(特特特)";
			this.textBox3.Top = 3.922F;
			this.textBox3.Width = 0.4822835F;
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
			this.EyLoanBalanceText.Top = 3.684F;
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
			this.EyLoanBalance2Text.Top = 3.922F;
			this.EyLoanBalance2Text.Width = 0.7F;
			// 
			// textBox9
			// 
			this.textBox9.CanGrow = false;
			this.textBox9.DataField = "EY_LOAN_BALANCE";
			this.textBox9.Height = 0.15F;
			this.textBox9.Left = 10.243F;
			this.textBox9.Name = "textBox9";
			this.textBox9.OutputFormat = "#,##0";
			this.textBox9.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox9.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.textBox9.Top = 3.682F;
			this.textBox9.Width = 0.7F;
			// 
			// textBox62
			// 
			this.textBox62.CanGrow = false;
			this.textBox62.DataField = "EY_LOAN_BALANCE2";
			this.textBox62.Height = 0.15F;
			this.textBox62.Left = 10.243F;
			this.textBox62.Name = "textBox62";
			this.textBox62.OutputFormat = "#,##0";
			this.textBox62.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox62.Text = "Z,ZZZ,ZZZ,ZZ6";
			this.textBox62.Top = 3.919996F;
			this.textBox62.Width = 0.7F;
			// 
			// NationalPensPremText
			// 
			this.NationalPensPremText.CanGrow = false;
			this.NationalPensPremText.DataField = "NATIONAL_PENS_PREM";
			this.NationalPensPremText.Height = 0.153F;
			this.NationalPensPremText.Left = 3.929921F;
			this.NationalPensPremText.Name = "NationalPensPremText";
			this.NationalPensPremText.OutputFormat = "#,##0";
			this.NationalPensPremText.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.NationalPensPremText.Text = "ZZ,ZZZ,ZZ6";
			this.NationalPensPremText.Top = 4.149212F;
			this.NationalPensPremText.Width = 0.45F;
			// 
			// textBox69
			// 
			this.textBox69.CanGrow = false;
			this.textBox69.DataField = "NATIONAL_PENS_PREM";
			this.textBox69.Height = 0.153F;
			this.textBox69.Left = 9.659056F;
			this.textBox69.Name = "textBox69";
			this.textBox69.OutputFormat = "#,##0";
			this.textBox69.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.textBox69.Text = "ZZ,ZZZ,ZZ6";
			this.textBox69.Top = 4.149212F;
			this.textBox69.Width = 0.45F;
			// 
			// SposNonResTypeText
			// 
			this.SposNonResTypeText.CanGrow = false;
			this.SposNonResTypeText.DataField = "SPOS_NON_RES_TYPE";
			this.SposNonResTypeText.Height = 0.2F;
			this.SposNonResTypeText.Left = 2.18F;
			this.SposNonResTypeText.Name = "SposNonResTypeText";
			this.SposNonResTypeText.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.SposNonResTypeText.Text = "○";
			this.SposNonResTypeText.Top = 4.12F;
			this.SposNonResTypeText.Width = 0.2F;
			// 
			// DpndNonResType1_Text
			// 
			this.DpndNonResType1_Text.CanGrow = false;
			this.DpndNonResType1_Text.DataField = "DPND_NON_RES_TYPE1";
			this.DpndNonResType1_Text.Height = 0.2F;
			this.DpndNonResType1_Text.Left = 2.18F;
			this.DpndNonResType1_Text.Name = "DpndNonResType1_Text";
			this.DpndNonResType1_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType1_Text.Text = "○";
			this.DpndNonResType1_Text.Top = 4.56F;
			this.DpndNonResType1_Text.Width = 0.2F;
			// 
			// SposNameKana_Text
			// 
			this.SposNameKana_Text.CanGrow = false;
			this.SposNameKana_Text.DataField = "SPOS_NAME_KANA";
			this.SposNameKana_Text.Height = 0.14F;
			this.SposNameKana_Text.Left = 0.845F;
			this.SposNameKana_Text.Name = "SposNameKana_Text";
			this.SposNameKana_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposNameKana_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.SposNameKana_Text.Top = 4.1F;
			this.SposNameKana_Text.Width = 1F;
			// 
			// SposName_Text
			// 
			this.SposName_Text.CanGrow = false;
			this.SposName_Text.DataField = "SPOS_NAME";
			this.SposName_Text.Height = 0.14F;
			this.SposName_Text.Left = 0.845F;
			this.SposName_Text.Name = "SposName_Text";
			this.SposName_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposName_Text.Text = "あいうえおかきくけこあいうえ";
			this.SposName_Text.Top = 4.24F;
			this.SposName_Text.Width = 1F;
			// 
			// DpndNameKana1_Text
			// 
			this.DpndNameKana1_Text.CanGrow = false;
			this.DpndNameKana1_Text.DataField = "DPND_NAME_KANA1";
			this.DpndNameKana1_Text.Height = 0.14F;
			this.DpndNameKana1_Text.Left = 0.845F;
			this.DpndNameKana1_Text.Name = "DpndNameKana1_Text";
			this.DpndNameKana1_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana1_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana1_Text.Top = 4.54F;
			this.DpndNameKana1_Text.Width = 1F;
			// 
			// DpndName1_Text
			// 
			this.DpndName1_Text.CanGrow = false;
			this.DpndName1_Text.DataField = "DPND_NAME1";
			this.DpndName1_Text.Height = 0.14F;
			this.DpndName1_Text.Left = 0.845F;
			this.DpndName1_Text.Name = "DpndName1_Text";
			this.DpndName1_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName1_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName1_Text.Top = 4.68F;
			this.DpndName1_Text.Width = 1F;
			// 
			// DpndNameKana2_Text
			// 
			this.DpndNameKana2_Text.CanGrow = false;
			this.DpndNameKana2_Text.DataField = "DPND_NAME_KANA2";
			this.DpndNameKana2_Text.Height = 0.14F;
			this.DpndNameKana2_Text.Left = 0.845F;
			this.DpndNameKana2_Text.Name = "DpndNameKana2_Text";
			this.DpndNameKana2_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana2_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana2_Text.Top = 4.965F;
			this.DpndNameKana2_Text.Width = 1F;
			// 
			// DpndName2_Text
			// 
			this.DpndName2_Text.CanGrow = false;
			this.DpndName2_Text.DataField = "DPND_NAME2";
			this.DpndName2_Text.Height = 0.14F;
			this.DpndName2_Text.Left = 0.845F;
			this.DpndName2_Text.Name = "DpndName2_Text";
			this.DpndName2_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName2_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName2_Text.Top = 5.105F;
			this.DpndName2_Text.Width = 1F;
			// 
			// DpndNonResType2_Text
			// 
			this.DpndNonResType2_Text.CanGrow = false;
			this.DpndNonResType2_Text.DataField = "DPND_NON_RES_TYPE2";
			this.DpndNonResType2_Text.Height = 0.2F;
			this.DpndNonResType2_Text.Left = 2.18F;
			this.DpndNonResType2_Text.Name = "DpndNonResType2_Text";
			this.DpndNonResType2_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType2_Text.Text = "○";
			this.DpndNonResType2_Text.Top = 4.985F;
			this.DpndNonResType2_Text.Width = 0.2F;
			// 
			// DpndNameKana3_Text
			// 
			this.DpndNameKana3_Text.CanGrow = false;
			this.DpndNameKana3_Text.DataField = "DPND_NAME_KANA3";
			this.DpndNameKana3_Text.Height = 0.14F;
			this.DpndNameKana3_Text.Left = 0.845F;
			this.DpndNameKana3_Text.Name = "DpndNameKana3_Text";
			this.DpndNameKana3_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana3_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana3_Text.Top = 5.39F;
			this.DpndNameKana3_Text.Width = 1F;
			// 
			// DpndName3_Text
			// 
			this.DpndName3_Text.CanGrow = false;
			this.DpndName3_Text.DataField = "DPND_NAME3";
			this.DpndName3_Text.Height = 0.14F;
			this.DpndName3_Text.Left = 0.845F;
			this.DpndName3_Text.Name = "DpndName3_Text";
			this.DpndName3_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName3_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName3_Text.Top = 5.53F;
			this.DpndName3_Text.Width = 1F;
			// 
			// DpndNonResType3_Text
			// 
			this.DpndNonResType3_Text.CanGrow = false;
			this.DpndNonResType3_Text.DataField = "DPND_NON_RES_TYPE3";
			this.DpndNonResType3_Text.Height = 0.1999998F;
			this.DpndNonResType3_Text.Left = 2.18F;
			this.DpndNonResType3_Text.Name = "DpndNonResType3_Text";
			this.DpndNonResType3_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType3_Text.Text = "○";
			this.DpndNonResType3_Text.Top = 5.41F;
			this.DpndNonResType3_Text.Width = 0.2F;
			// 
			// DpndNameKana4_Text
			// 
			this.DpndNameKana4_Text.CanGrow = false;
			this.DpndNameKana4_Text.DataField = "DPND_NAME_KANA4";
			this.DpndNameKana4_Text.Height = 0.14F;
			this.DpndNameKana4_Text.Left = 0.845F;
			this.DpndNameKana4_Text.Name = "DpndNameKana4_Text";
			this.DpndNameKana4_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndNameKana4_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.DpndNameKana4_Text.Top = 5.815F;
			this.DpndNameKana4_Text.Width = 1F;
			// 
			// DpndName4_Text
			// 
			this.DpndName4_Text.CanGrow = false;
			this.DpndName4_Text.DataField = "DPND_NAME4";
			this.DpndName4_Text.Height = 0.14F;
			this.DpndName4_Text.Left = 0.845F;
			this.DpndName4_Text.Name = "DpndName4_Text";
			this.DpndName4_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndName4_Text.Text = "あいうえおかきくけこあいうえ";
			this.DpndName4_Text.Top = 5.955F;
			this.DpndName4_Text.Width = 1F;
			// 
			// DpndNonResType4_Text
			// 
			this.DpndNonResType4_Text.CanGrow = false;
			this.DpndNonResType4_Text.DataField = "DPND_NON_RES_TYPE4";
			this.DpndNonResType4_Text.Height = 0.2F;
			this.DpndNonResType4_Text.Left = 2.18F;
			this.DpndNonResType4_Text.Name = "DpndNonResType4_Text";
			this.DpndNonResType4_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.DpndNonResType4_Text.Text = "○";
			this.DpndNonResType4_Text.Top = 5.835F;
			this.DpndNonResType4_Text.Width = 0.2F;
			// 
			// YngDpndNameKana1_Text
			// 
			this.YngDpndNameKana1_Text.CanGrow = false;
			this.YngDpndNameKana1_Text.DataField = "YNG_DPND_NAME_KANA1";
			this.YngDpndNameKana1_Text.Height = 0.14F;
			this.YngDpndNameKana1_Text.Left = 3.05F;
			this.YngDpndNameKana1_Text.Name = "YngDpndNameKana1_Text";
			this.YngDpndNameKana1_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana1_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana1_Text.Top = 4.54F;
			this.YngDpndNameKana1_Text.Width = 1F;
			// 
			// YngDpndName1_Text
			// 
			this.YngDpndName1_Text.CanGrow = false;
			this.YngDpndName1_Text.DataField = "YNG_DPND_NAME1";
			this.YngDpndName1_Text.Height = 0.14F;
			this.YngDpndName1_Text.Left = 3.05F;
			this.YngDpndName1_Text.Name = "YngDpndName1_Text";
			this.YngDpndName1_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName1_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName1_Text.Top = 4.68F;
			this.YngDpndName1_Text.Width = 1F;
			// 
			// YngDpndNonRexType1_Text
			// 
			this.YngDpndNonRexType1_Text.CanGrow = false;
			this.YngDpndNonRexType1_Text.DataField = "YNG_DPND_NON_RES_TYPE1";
			this.YngDpndNonRexType1_Text.Height = 0.2F;
			this.YngDpndNonRexType1_Text.Left = 4.395F;
			this.YngDpndNonRexType1_Text.Name = "YngDpndNonRexType1_Text";
			this.YngDpndNonRexType1_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType1_Text.Text = "○";
			this.YngDpndNonRexType1_Text.Top = 4.56F;
			this.YngDpndNonRexType1_Text.Width = 0.2F;
			// 
			// YngDpndName2_Text
			// 
			this.YngDpndName2_Text.CanGrow = false;
			this.YngDpndName2_Text.DataField = "YNG_DPND_NAME2";
			this.YngDpndName2_Text.Height = 0.14F;
			this.YngDpndName2_Text.Left = 3.05F;
			this.YngDpndName2_Text.Name = "YngDpndName2_Text";
			this.YngDpndName2_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName2_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName2_Text.Top = 5.105F;
			this.YngDpndName2_Text.Width = 1F;
			// 
			// YngDpndNameKana2_Text
			// 
			this.YngDpndNameKana2_Text.CanGrow = false;
			this.YngDpndNameKana2_Text.DataField = "YNG_DPND_NAME_KANA2";
			this.YngDpndNameKana2_Text.Height = 0.14F;
			this.YngDpndNameKana2_Text.Left = 3.05F;
			this.YngDpndNameKana2_Text.Name = "YngDpndNameKana2_Text";
			this.YngDpndNameKana2_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana2_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana2_Text.Top = 4.965F;
			this.YngDpndNameKana2_Text.Width = 1F;
			// 
			// YngDpndNonRexType2_Text
			// 
			this.YngDpndNonRexType2_Text.CanGrow = false;
			this.YngDpndNonRexType2_Text.DataField = "YNG_DPND_NON_RES_TYPE2";
			this.YngDpndNonRexType2_Text.Height = 0.2F;
			this.YngDpndNonRexType2_Text.Left = 4.395F;
			this.YngDpndNonRexType2_Text.Name = "YngDpndNonRexType2_Text";
			this.YngDpndNonRexType2_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType2_Text.Text = "○";
			this.YngDpndNonRexType2_Text.Top = 4.985F;
			this.YngDpndNonRexType2_Text.Width = 0.2F;
			// 
			// YngDpndName3_Text
			// 
			this.YngDpndName3_Text.CanGrow = false;
			this.YngDpndName3_Text.DataField = "YNG_DPND_NAME3";
			this.YngDpndName3_Text.Height = 0.14F;
			this.YngDpndName3_Text.Left = 3.05F;
			this.YngDpndName3_Text.Name = "YngDpndName3_Text";
			this.YngDpndName3_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName3_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName3_Text.Top = 5.53F;
			this.YngDpndName3_Text.Width = 1F;
			// 
			// YngDpndNameKana3_Text
			// 
			this.YngDpndNameKana3_Text.CanGrow = false;
			this.YngDpndNameKana3_Text.DataField = "YNG_DPND_NAME_KANA3";
			this.YngDpndNameKana3_Text.Height = 0.14F;
			this.YngDpndNameKana3_Text.Left = 3.05F;
			this.YngDpndNameKana3_Text.Name = "YngDpndNameKana3_Text";
			this.YngDpndNameKana3_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana3_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana3_Text.Top = 5.39F;
			this.YngDpndNameKana3_Text.Width = 1F;
			// 
			// YngDpndNonRexType3_Text
			// 
			this.YngDpndNonRexType3_Text.CanGrow = false;
			this.YngDpndNonRexType3_Text.DataField = "YNG_DPND_NON_RES_TYPE3";
			this.YngDpndNonRexType3_Text.Height = 0.2F;
			this.YngDpndNonRexType3_Text.Left = 4.395F;
			this.YngDpndNonRexType3_Text.Name = "YngDpndNonRexType3_Text";
			this.YngDpndNonRexType3_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType3_Text.Text = "○";
			this.YngDpndNonRexType3_Text.Top = 5.41F;
			this.YngDpndNonRexType3_Text.Width = 0.2F;
			// 
			// YngDpndNameKana4_Text
			// 
			this.YngDpndNameKana4_Text.CanGrow = false;
			this.YngDpndNameKana4_Text.DataField = "YNG_DPND_NAME_KANA4";
			this.YngDpndNameKana4_Text.Height = 0.14F;
			this.YngDpndNameKana4_Text.Left = 3.05F;
			this.YngDpndNameKana4_Text.Name = "YngDpndNameKana4_Text";
			this.YngDpndNameKana4_Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndNameKana4_Text.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.YngDpndNameKana4_Text.Top = 5.815F;
			this.YngDpndNameKana4_Text.Width = 1F;
			// 
			// YngDpndName4_Text
			// 
			this.YngDpndName4_Text.CanGrow = false;
			this.YngDpndName4_Text.DataField = "YNG_DPND_NAME4";
			this.YngDpndName4_Text.Height = 0.14F;
			this.YngDpndName4_Text.Left = 3.05F;
			this.YngDpndName4_Text.Name = "YngDpndName4_Text";
			this.YngDpndName4_Text.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndName4_Text.Text = "あいうえおかきくけこあいうえ";
			this.YngDpndName4_Text.Top = 5.955F;
			this.YngDpndName4_Text.Width = 1F;
			// 
			// YngDpndNonRexType4_Text
			// 
			this.YngDpndNonRexType4_Text.CanGrow = false;
			this.YngDpndNonRexType4_Text.DataField = "YNG_DPND_NON_RES_TYPE4";
			this.YngDpndNonRexType4_Text.Height = 0.1999998F;
			this.YngDpndNonRexType4_Text.Left = 4.395F;
			this.YngDpndNonRexType4_Text.Name = "YngDpndNonRexType4_Text";
			this.YngDpndNonRexType4_Text.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YngDpndNonRexType4_Text.Text = "○";
			this.YngDpndNonRexType4_Text.Top = 5.835F;
			this.YngDpndNonRexType4_Text.Width = 0.1999998F;
			// 
			// textBox70
			// 
			this.textBox70.CanGrow = false;
			this.textBox70.DataField = "SPOS_NAME_KANA";
			this.textBox70.Height = 0.14F;
			this.textBox70.Left = 6.574F;
			this.textBox70.Name = "textBox70";
			this.textBox70.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox70.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox70.Top = 4.1F;
			this.textBox70.Width = 1F;
			// 
			// textBox71
			// 
			this.textBox71.CanGrow = false;
			this.textBox71.DataField = "SPOS_NAME";
			this.textBox71.Height = 0.14F;
			this.textBox71.Left = 6.574F;
			this.textBox71.Name = "textBox71";
			this.textBox71.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox71.Text = "あいうえおかきくけこあいうえ";
			this.textBox71.Top = 4.24F;
			this.textBox71.Width = 1F;
			// 
			// textBox72
			// 
			this.textBox72.CanGrow = false;
			this.textBox72.DataField = "SPOS_NON_RES_TYPE";
			this.textBox72.Height = 0.2F;
			this.textBox72.Left = 7.909F;
			this.textBox72.Name = "textBox72";
			this.textBox72.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox72.Text = "○";
			this.textBox72.Top = 4.12F;
			this.textBox72.Width = 0.2F;
			// 
			// textBox76
			// 
			this.textBox76.CanGrow = false;
			this.textBox76.DataField = "DPND_NAME_KANA1";
			this.textBox76.Height = 0.14F;
			this.textBox76.Left = 6.574F;
			this.textBox76.Name = "textBox76";
			this.textBox76.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox76.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox76.Top = 4.54F;
			this.textBox76.Width = 1F;
			// 
			// textBox77
			// 
			this.textBox77.CanGrow = false;
			this.textBox77.DataField = "DPND_NAME1";
			this.textBox77.Height = 0.14F;
			this.textBox77.Left = 6.574F;
			this.textBox77.Name = "textBox77";
			this.textBox77.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox77.Text = "あいうえおかきくけこあいうえ";
			this.textBox77.Top = 4.68F;
			this.textBox77.Width = 1F;
			// 
			// textBox78
			// 
			this.textBox78.CanGrow = false;
			this.textBox78.DataField = "DPND_NON_RES_TYPE1";
			this.textBox78.Height = 0.2F;
			this.textBox78.Left = 7.909F;
			this.textBox78.Name = "textBox78";
			this.textBox78.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox78.Text = "○";
			this.textBox78.Top = 4.56F;
			this.textBox78.Width = 0.2F;
			// 
			// textBox79
			// 
			this.textBox79.CanGrow = false;
			this.textBox79.DataField = "DPND_NAME_KANA2";
			this.textBox79.Height = 0.14F;
			this.textBox79.Left = 6.574F;
			this.textBox79.Name = "textBox79";
			this.textBox79.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox79.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox79.Top = 4.965F;
			this.textBox79.Width = 1F;
			// 
			// textBox80
			// 
			this.textBox80.CanGrow = false;
			this.textBox80.DataField = "DPND_NAME2";
			this.textBox80.Height = 0.14F;
			this.textBox80.Left = 6.574F;
			this.textBox80.Name = "textBox80";
			this.textBox80.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox80.Text = "あいうえおかきくけこあいうえ";
			this.textBox80.Top = 5.105F;
			this.textBox80.Width = 1F;
			// 
			// textBox81
			// 
			this.textBox81.CanGrow = false;
			this.textBox81.DataField = "DPND_NON_RES_TYPE2";
			this.textBox81.Height = 0.2F;
			this.textBox81.Left = 7.909F;
			this.textBox81.Name = "textBox81";
			this.textBox81.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox81.Text = "○";
			this.textBox81.Top = 4.985F;
			this.textBox81.Width = 0.2F;
			// 
			// textBox82
			// 
			this.textBox82.CanGrow = false;
			this.textBox82.DataField = "DPND_NON_RES_TYPE3";
			this.textBox82.Height = 0.2F;
			this.textBox82.Left = 7.909F;
			this.textBox82.Name = "textBox82";
			this.textBox82.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox82.Text = "○";
			this.textBox82.Top = 5.41F;
			this.textBox82.Width = 0.2F;
			// 
			// textBox83
			// 
			this.textBox83.CanGrow = false;
			this.textBox83.DataField = "DPND_NAME_KANA3";
			this.textBox83.Height = 0.14F;
			this.textBox83.Left = 6.574F;
			this.textBox83.Name = "textBox83";
			this.textBox83.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox83.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox83.Top = 5.39F;
			this.textBox83.Width = 1F;
			// 
			// textBox84
			// 
			this.textBox84.CanGrow = false;
			this.textBox84.DataField = "DPND_NAME3";
			this.textBox84.Height = 0.14F;
			this.textBox84.Left = 6.574F;
			this.textBox84.Name = "textBox84";
			this.textBox84.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox84.Text = "あいうえおかきくけこあいうえ";
			this.textBox84.Top = 5.53F;
			this.textBox84.Width = 1F;
			// 
			// textBox85
			// 
			this.textBox85.CanGrow = false;
			this.textBox85.DataField = "DPND_NAME_KANA4";
			this.textBox85.Height = 0.14F;
			this.textBox85.Left = 6.574F;
			this.textBox85.Name = "textBox85";
			this.textBox85.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox85.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox85.Top = 5.815F;
			this.textBox85.Width = 1F;
			// 
			// textBox86
			// 
			this.textBox86.CanGrow = false;
			this.textBox86.DataField = "DPND_NAME4";
			this.textBox86.Height = 0.14F;
			this.textBox86.Left = 6.574F;
			this.textBox86.Name = "textBox86";
			this.textBox86.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox86.Text = "あいうえおかきくけこあいうえ";
			this.textBox86.Top = 5.955F;
			this.textBox86.Width = 1F;
			// 
			// textBox87
			// 
			this.textBox87.CanGrow = false;
			this.textBox87.DataField = "DPND_NON_RES_TYPE4";
			this.textBox87.Height = 0.2F;
			this.textBox87.Left = 7.909F;
			this.textBox87.Name = "textBox87";
			this.textBox87.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox87.Text = "○";
			this.textBox87.Top = 5.835F;
			this.textBox87.Width = 0.2F;
			// 
			// textBox88
			// 
			this.textBox88.CanGrow = false;
			this.textBox88.DataField = "YNG_DPND_NAME_KANA4";
			this.textBox88.Height = 0.14F;
			this.textBox88.Left = 8.779F;
			this.textBox88.Name = "textBox88";
			this.textBox88.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox88.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox88.Top = 5.815F;
			this.textBox88.Width = 1F;
			// 
			// textBox89
			// 
			this.textBox89.CanGrow = false;
			this.textBox89.DataField = "YNG_DPND_NAME4";
			this.textBox89.Height = 0.14F;
			this.textBox89.Left = 8.779F;
			this.textBox89.Name = "textBox89";
			this.textBox89.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox89.Text = "あいうえおかきくけこあいうえ";
			this.textBox89.Top = 5.955F;
			this.textBox89.Width = 1F;
			// 
			// textBox90
			// 
			this.textBox90.CanGrow = false;
			this.textBox90.DataField = "YNG_DPND_NON_RES_TYPE4";
			this.textBox90.Height = 0.1999998F;
			this.textBox90.Left = 10.124F;
			this.textBox90.Name = "textBox90";
			this.textBox90.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox90.Text = "○";
			this.textBox90.Top = 5.835F;
			this.textBox90.Width = 0.1999998F;
			// 
			// textBox91
			// 
			this.textBox91.CanGrow = false;
			this.textBox91.DataField = "YNG_DPND_NON_RES_TYPE3";
			this.textBox91.Height = 0.2F;
			this.textBox91.Left = 10.124F;
			this.textBox91.Name = "textBox91";
			this.textBox91.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox91.Text = "○";
			this.textBox91.Top = 5.41F;
			this.textBox91.Width = 0.2F;
			// 
			// textBox92
			// 
			this.textBox92.CanGrow = false;
			this.textBox92.DataField = "YNG_DPND_NAME3";
			this.textBox92.Height = 0.14F;
			this.textBox92.Left = 8.779F;
			this.textBox92.Name = "textBox92";
			this.textBox92.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox92.Text = "あいうえおかきくけこあいうえ";
			this.textBox92.Top = 5.53F;
			this.textBox92.Width = 1F;
			// 
			// textBox93
			// 
			this.textBox93.CanGrow = false;
			this.textBox93.DataField = "YNG_DPND_NAME_KANA3";
			this.textBox93.Height = 0.14F;
			this.textBox93.Left = 8.779F;
			this.textBox93.Name = "textBox93";
			this.textBox93.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox93.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox93.Top = 5.39F;
			this.textBox93.Width = 1F;
			// 
			// textBox94
			// 
			this.textBox94.CanGrow = false;
			this.textBox94.DataField = "YNG_DPND_NAME_KANA2";
			this.textBox94.Height = 0.14F;
			this.textBox94.Left = 8.779F;
			this.textBox94.Name = "textBox94";
			this.textBox94.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox94.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox94.Top = 4.965F;
			this.textBox94.Width = 1F;
			// 
			// textBox95
			// 
			this.textBox95.CanGrow = false;
			this.textBox95.DataField = "YNG_DPND_NAME2";
			this.textBox95.Height = 0.14F;
			this.textBox95.Left = 8.779F;
			this.textBox95.Name = "textBox95";
			this.textBox95.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox95.Text = "あいうえおかきくけこあいうえ";
			this.textBox95.Top = 5.105F;
			this.textBox95.Width = 1F;
			// 
			// textBox96
			// 
			this.textBox96.CanGrow = false;
			this.textBox96.DataField = "YNG_DPND_NON_RES_TYPE2";
			this.textBox96.Height = 0.2F;
			this.textBox96.Left = 10.124F;
			this.textBox96.Name = "textBox96";
			this.textBox96.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox96.Text = "○";
			this.textBox96.Top = 4.985F;
			this.textBox96.Width = 0.2F;
			// 
			// textBox97
			// 
			this.textBox97.CanGrow = false;
			this.textBox97.DataField = "YNG_DPND_NON_RES_TYPE1";
			this.textBox97.Height = 0.2F;
			this.textBox97.Left = 10.124F;
			this.textBox97.Name = "textBox97";
			this.textBox97.Style = "font-size: 8pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox97.Text = "○";
			this.textBox97.Top = 4.56F;
			this.textBox97.Width = 0.2F;
			// 
			// textBox98
			// 
			this.textBox98.CanGrow = false;
			this.textBox98.DataField = "YNG_DPND_NAME_KANA1";
			this.textBox98.Height = 0.14F;
			this.textBox98.Left = 8.779F;
			this.textBox98.Name = "textBox98";
			this.textBox98.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox98.Text = "ｱｲｳｴｵｶｷｸｹｺｱｲｳｴｵ";
			this.textBox98.Top = 4.54F;
			this.textBox98.Width = 1F;
			// 
			// textBox99
			// 
			this.textBox99.CanGrow = false;
			this.textBox99.DataField = "YNG_DPND_NAME1";
			this.textBox99.Height = 0.14F;
			this.textBox99.Left = 8.779F;
			this.textBox99.Name = "textBox99";
			this.textBox99.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.textBox99.Text = "あいうえおかきくけこあいうえ";
			this.textBox99.Top = 4.68F;
			this.textBox99.Width = 1F;
			// 
			// SposMyNumber2_1Text
			// 
			this.SposMyNumber2_1Text.CanGrow = false;
			this.SposMyNumber2_1Text.Height = 0.14F;
			this.SposMyNumber2_1Text.Left = 6.574F;
			this.SposMyNumber2_1Text.Name = "SposMyNumber2_1Text";
			this.SposMyNumber2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber2_1Text.Text = "1234";
			this.SposMyNumber2_1Text.Top = 4.399F;
			this.SposMyNumber2_1Text.Width = 0.355F;
			// 
			// SposMyNumber2_2Text
			// 
			this.SposMyNumber2_2Text.CanGrow = false;
			this.SposMyNumber2_2Text.Height = 0.14F;
			this.SposMyNumber2_2Text.Left = 7.129F;
			this.SposMyNumber2_2Text.Name = "SposMyNumber2_2Text";
			this.SposMyNumber2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber2_2Text.Text = "1234";
			this.SposMyNumber2_2Text.Top = 4.399F;
			this.SposMyNumber2_2Text.Width = 0.355F;
			// 
			// SposMyNumber2_3Text
			// 
			this.SposMyNumber2_3Text.CanGrow = false;
			this.SposMyNumber2_3Text.Height = 0.14F;
			this.SposMyNumber2_3Text.Left = 7.659F;
			this.SposMyNumber2_3Text.Name = "SposMyNumber2_3Text";
			this.SposMyNumber2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber2_3Text.Text = "1234";
			this.SposMyNumber2_3Text.Top = 4.399F;
			this.SposMyNumber2_3Text.Width = 0.355F;
			// 
			// DpndMyNumber2_1_1Text
			// 
			this.DpndMyNumber2_1_1Text.CanGrow = false;
			this.DpndMyNumber2_1_1Text.Height = 0.14F;
			this.DpndMyNumber2_1_1Text.Left = 6.574F;
			this.DpndMyNumber2_1_1Text.Name = "DpndMyNumber2_1_1Text";
			this.DpndMyNumber2_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_1_1Text.Text = "1234";
			this.DpndMyNumber2_1_1Text.Top = 4.829F;
			this.DpndMyNumber2_1_1Text.Width = 0.355F;
			// 
			// DpndMyNumber2_1_2Text
			// 
			this.DpndMyNumber2_1_2Text.CanGrow = false;
			this.DpndMyNumber2_1_2Text.Height = 0.14F;
			this.DpndMyNumber2_1_2Text.Left = 7.129F;
			this.DpndMyNumber2_1_2Text.Name = "DpndMyNumber2_1_2Text";
			this.DpndMyNumber2_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_1_2Text.Text = "1234";
			this.DpndMyNumber2_1_2Text.Top = 4.829F;
			this.DpndMyNumber2_1_2Text.Width = 0.355F;
			// 
			// DpndMyNumber2_1_3Text
			// 
			this.DpndMyNumber2_1_3Text.CanGrow = false;
			this.DpndMyNumber2_1_3Text.Height = 0.14F;
			this.DpndMyNumber2_1_3Text.Left = 7.659F;
			this.DpndMyNumber2_1_3Text.Name = "DpndMyNumber2_1_3Text";
			this.DpndMyNumber2_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_1_3Text.Text = "1234";
			this.DpndMyNumber2_1_3Text.Top = 4.829F;
			this.DpndMyNumber2_1_3Text.Width = 0.355F;
			// 
			// DpndMyNumber2_2_1Text
			// 
			this.DpndMyNumber2_2_1Text.CanGrow = false;
			this.DpndMyNumber2_2_1Text.Height = 0.14F;
			this.DpndMyNumber2_2_1Text.Left = 6.574F;
			this.DpndMyNumber2_2_1Text.Name = "DpndMyNumber2_2_1Text";
			this.DpndMyNumber2_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_2_1Text.Text = "1234";
			this.DpndMyNumber2_2_1Text.Top = 5.249F;
			this.DpndMyNumber2_2_1Text.Width = 0.355F;
			// 
			// DpndMyNumber2_2_2Text
			// 
			this.DpndMyNumber2_2_2Text.CanGrow = false;
			this.DpndMyNumber2_2_2Text.Height = 0.14F;
			this.DpndMyNumber2_2_2Text.Left = 7.129F;
			this.DpndMyNumber2_2_2Text.Name = "DpndMyNumber2_2_2Text";
			this.DpndMyNumber2_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_2_2Text.Text = "1234";
			this.DpndMyNumber2_2_2Text.Top = 5.249F;
			this.DpndMyNumber2_2_2Text.Width = 0.355F;
			// 
			// DpndMyNumber2_2_3Text
			// 
			this.DpndMyNumber2_2_3Text.CanGrow = false;
			this.DpndMyNumber2_2_3Text.Height = 0.14F;
			this.DpndMyNumber2_2_3Text.Left = 7.659F;
			this.DpndMyNumber2_2_3Text.Name = "DpndMyNumber2_2_3Text";
			this.DpndMyNumber2_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_2_3Text.Text = "1234";
			this.DpndMyNumber2_2_3Text.Top = 5.249F;
			this.DpndMyNumber2_2_3Text.Width = 0.355F;
			// 
			// DpndMyNumber2_3_1Text
			// 
			this.DpndMyNumber2_3_1Text.CanGrow = false;
			this.DpndMyNumber2_3_1Text.Height = 0.14F;
			this.DpndMyNumber2_3_1Text.Left = 6.574F;
			this.DpndMyNumber2_3_1Text.Name = "DpndMyNumber2_3_1Text";
			this.DpndMyNumber2_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_3_1Text.Text = "1234";
			this.DpndMyNumber2_3_1Text.Top = 5.669F;
			this.DpndMyNumber2_3_1Text.Width = 0.355F;
			// 
			// DpndMyNumber2_3_2Text
			// 
			this.DpndMyNumber2_3_2Text.CanGrow = false;
			this.DpndMyNumber2_3_2Text.Height = 0.14F;
			this.DpndMyNumber2_3_2Text.Left = 7.129F;
			this.DpndMyNumber2_3_2Text.Name = "DpndMyNumber2_3_2Text";
			this.DpndMyNumber2_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_3_2Text.Text = "1234";
			this.DpndMyNumber2_3_2Text.Top = 5.669F;
			this.DpndMyNumber2_3_2Text.Width = 0.355F;
			// 
			// DpndMyNumber2_3_3Text
			// 
			this.DpndMyNumber2_3_3Text.CanGrow = false;
			this.DpndMyNumber2_3_3Text.Height = 0.14F;
			this.DpndMyNumber2_3_3Text.Left = 7.659F;
			this.DpndMyNumber2_3_3Text.Name = "DpndMyNumber2_3_3Text";
			this.DpndMyNumber2_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_3_3Text.Text = "1234";
			this.DpndMyNumber2_3_3Text.Top = 5.669F;
			this.DpndMyNumber2_3_3Text.Width = 0.355F;
			// 
			// DpndMyNumber2_4_1Text
			// 
			this.DpndMyNumber2_4_1Text.CanGrow = false;
			this.DpndMyNumber2_4_1Text.Height = 0.14F;
			this.DpndMyNumber2_4_1Text.Left = 6.574F;
			this.DpndMyNumber2_4_1Text.Name = "DpndMyNumber2_4_1Text";
			this.DpndMyNumber2_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_4_1Text.Text = "1234";
			this.DpndMyNumber2_4_1Text.Top = 6.099F;
			this.DpndMyNumber2_4_1Text.Width = 0.355F;
			// 
			// DpndMyNumber2_4_2Text
			// 
			this.DpndMyNumber2_4_2Text.CanGrow = false;
			this.DpndMyNumber2_4_2Text.Height = 0.14F;
			this.DpndMyNumber2_4_2Text.Left = 7.129F;
			this.DpndMyNumber2_4_2Text.Name = "DpndMyNumber2_4_2Text";
			this.DpndMyNumber2_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_4_2Text.Text = "1234";
			this.DpndMyNumber2_4_2Text.Top = 6.099F;
			this.DpndMyNumber2_4_2Text.Width = 0.355F;
			// 
			// DpndMyNumber2_4_3Text
			// 
			this.DpndMyNumber2_4_3Text.CanGrow = false;
			this.DpndMyNumber2_4_3Text.Height = 0.14F;
			this.DpndMyNumber2_4_3Text.Left = 7.659F;
			this.DpndMyNumber2_4_3Text.Name = "DpndMyNumber2_4_3Text";
			this.DpndMyNumber2_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_4_3Text.Text = "1234";
			this.DpndMyNumber2_4_3Text.Top = 6.099F;
			this.DpndMyNumber2_4_3Text.Width = 0.355F;
			// 
			// MyNumber2_1Text
			// 
			this.MyNumber2_1Text.CanGrow = false;
			this.MyNumber2_1Text.Height = 0.15F;
			this.MyNumber2_1Text.Left = 9.545F;
			this.MyNumber2_1Text.Name = "MyNumber2_1Text";
			this.MyNumber2_1Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber2_1Text.Text = "1234";
			this.MyNumber2_1Text.Top = 0.32F;
			this.MyNumber2_1Text.Width = 0.35F;
			// 
			// MyNumber2_2Text
			// 
			this.MyNumber2_2Text.CanGrow = false;
			this.MyNumber2_2Text.Height = 0.15F;
			this.MyNumber2_2Text.Left = 10.095F;
			this.MyNumber2_2Text.Name = "MyNumber2_2Text";
			this.MyNumber2_2Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber2_2Text.Text = "1234";
			this.MyNumber2_2Text.Top = 0.32F;
			this.MyNumber2_2Text.Width = 0.35F;
			// 
			// MyNumber2_3Text
			// 
			this.MyNumber2_3Text.CanGrow = false;
			this.MyNumber2_3Text.Height = 0.15F;
			this.MyNumber2_3Text.Left = 10.645F;
			this.MyNumber2_3Text.Name = "MyNumber2_3Text";
			this.MyNumber2_3Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber2_3Text.Text = "1234";
			this.MyNumber2_3Text.Top = 0.32F;
			this.MyNumber2_3Text.Width = 0.35F;
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
			this.HousingObtDedCntText.Top = 3.682F;
			this.HousingObtDedCntText.Width = 0.3F;
			// 
			// textBox100
			// 
			this.textBox100.CanGrow = false;
			this.textBox100.DataField = "HOUSING_OBT_DED_CNT";
			this.textBox100.Height = 0.15F;
			this.textBox100.Left = 6.809F;
			this.textBox100.Name = "textBox100";
			this.textBox100.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.textBox100.Text = "999";
			this.textBox100.Top = 3.682F;
			this.textBox100.Width = 0.3F;
			// 
			// line117
			// 
			this.line117.Height = 0.6900001F;
			this.line117.Left = 0.745F;
			this.line117.LineWeight = 1F;
			this.line117.Name = "line117";
			this.line117.Top = 6.21F;
			this.line117.Width = 0F;
			this.line117.X1 = 0.745F;
			this.line117.X2 = 0.745F;
			this.line117.Y1 = 6.21F;
			this.line117.Y2 = 6.9F;
			// 
			// label195
			// 
			this.label195.Height = 0.156F;
			this.label195.HyperLink = null;
			this.label195.Left = 3.087008F;
			this.label195.Name = "label195";
			this.label195.Style = "font-size: 6pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label195.Text = "(個人番号）";
			this.label195.Top = 0.3216535F;
			this.label195.Width = 0.543F;
			// 
			// line119
			// 
			this.line119.Height = 0.1679524F;
			this.line119.Left = 3.714567F;
			this.line119.LineWeight = 1F;
			this.line119.Name = "line119";
			this.line119.Top = 0.319685F;
			this.line119.Width = 0F;
			this.line119.X1 = 3.714567F;
			this.line119.X2 = 3.714567F;
			this.line119.Y1 = 0.319685F;
			this.line119.Y2 = 0.4876374F;
			// 
			// MyNumber1_3Text
			// 
			this.MyNumber1_3Text.CanGrow = false;
			this.MyNumber1_3Text.Height = 0.15F;
			this.MyNumber1_3Text.Left = 4.909842F;
			this.MyNumber1_3Text.Name = "MyNumber1_3Text";
			this.MyNumber1_3Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_3Text.Text = "1234";
			this.MyNumber1_3Text.Top = 0.3200788F;
			this.MyNumber1_3Text.Width = 0.35F;
			// 
			// MyNumber1_2Text
			// 
			this.MyNumber1_2Text.CanGrow = false;
			this.MyNumber1_2Text.Height = 0.15F;
			this.MyNumber1_2Text.Left = 4.359843F;
			this.MyNumber1_2Text.Name = "MyNumber1_2Text";
			this.MyNumber1_2Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_2Text.Text = "1234";
			this.MyNumber1_2Text.Top = 0.3200788F;
			this.MyNumber1_2Text.Width = 0.35F;
			// 
			// MyNumber1_1Text
			// 
			this.MyNumber1_1Text.CanGrow = false;
			this.MyNumber1_1Text.Height = 0.15F;
			this.MyNumber1_1Text.Left = 3.809843F;
			this.MyNumber1_1Text.Name = "MyNumber1_1Text";
			this.MyNumber1_1Text.Style = "font-size: 7.5pt; text-align: center; vertical-align: middle; white-space: nowrap" +
    "; ddo-char-set: 1";
			this.MyNumber1_1Text.Text = "1234";
			this.MyNumber1_1Text.Top = 0.3200788F;
			this.MyNumber1_1Text.Width = 0.35F;
			// 
			// line278
			// 
			this.line278.Height = 0.1679524F;
			this.line278.Left = 4.815748F;
			this.line278.LineWeight = 1F;
			this.line278.Name = "line278";
			this.line278.Top = 0.319685F;
			this.line278.Width = 0F;
			this.line278.X1 = 4.815748F;
			this.line278.X2 = 4.815748F;
			this.line278.Y1 = 0.319685F;
			this.line278.Y2 = 0.4876374F;
			// 
			// line279
			// 
			this.line279.Height = 0.1679524F;
			this.line279.Left = 4.274015F;
			this.line279.LineWeight = 1F;
			this.line279.Name = "line279";
			this.line279.Top = 0.319685F;
			this.line279.Width = 0F;
			this.line279.X1 = 4.274015F;
			this.line279.X2 = 4.274015F;
			this.line279.Y1 = 0.319685F;
			this.line279.Y2 = 0.4876374F;
			// 
			// label318
			// 
			this.label318.Height = 0.14F;
			this.label318.HyperLink = null;
			this.label318.Left = 0.4602363F;
			this.label318.Name = "label318";
			this.label318.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label318.Text = "個人番号";
			this.label318.Top = 4.400394F;
			this.label318.Width = 0.275F;
			// 
			// label319
			// 
			this.label319.Height = 0.14F;
			this.label319.HyperLink = null;
			this.label319.Left = 0.4602363F;
			this.label319.Name = "label319";
			this.label319.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label319.Text = "個人番号";
			this.label319.Top = 4.829134F;
			this.label319.Width = 0.275F;
			// 
			// label320
			// 
			this.label320.Height = 0.14F;
			this.label320.HyperLink = null;
			this.label320.Left = 0.4602363F;
			this.label320.Name = "label320";
			this.label320.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label320.Text = "個人番号";
			this.label320.Top = 5.259449F;
			this.label320.Width = 0.275F;
			// 
			// label321
			// 
			this.label321.Height = 0.14F;
			this.label321.HyperLink = null;
			this.label321.Left = 0.4602363F;
			this.label321.Name = "label321";
			this.label321.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label321.Text = "個人番号";
			this.label321.Top = 5.68504F;
			this.label321.Width = 0.275F;
			// 
			// label322
			// 
			this.label322.Height = 0.14F;
			this.label322.HyperLink = null;
			this.label322.Left = 0.4602363F;
			this.label322.Name = "label322";
			this.label322.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label322.Text = "個人番号";
			this.label322.Top = 6.109056F;
			this.label322.Width = 0.275F;
			// 
			// SposMyNumber1_1Text
			// 
			this.SposMyNumber1_1Text.CanGrow = false;
			this.SposMyNumber1_1Text.Height = 0.14F;
			this.SposMyNumber1_1Text.Left = 0.8551183F;
			this.SposMyNumber1_1Text.Name = "SposMyNumber1_1Text";
			this.SposMyNumber1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_1Text.Text = "1234";
			this.SposMyNumber1_1Text.Top = 4.398819F;
			this.SposMyNumber1_1Text.Width = 0.355F;
			// 
			// line259
			// 
			this.line259.Height = 0.158F;
			this.line259.Left = 1.310118F;
			this.line259.LineWeight = 1F;
			this.line259.Name = "line259";
			this.line259.Top = 4.351819F;
			this.line259.Width = 0F;
			this.line259.X1 = 1.310118F;
			this.line259.X2 = 1.310118F;
			this.line259.Y1 = 4.351819F;
			this.line259.Y2 = 4.509819F;
			// 
			// SposMyNumber1_2Text
			// 
			this.SposMyNumber1_2Text.CanGrow = false;
			this.SposMyNumber1_2Text.Height = 0.14F;
			this.SposMyNumber1_2Text.Left = 1.410118F;
			this.SposMyNumber1_2Text.Name = "SposMyNumber1_2Text";
			this.SposMyNumber1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_2Text.Text = "1234";
			this.SposMyNumber1_2Text.Top = 4.398819F;
			this.SposMyNumber1_2Text.Width = 0.355F;
			// 
			// line261
			// 
			this.line261.Height = 0.158F;
			this.line261.Left = 1.860118F;
			this.line261.LineWeight = 1F;
			this.line261.Name = "line261";
			this.line261.Top = 4.351819F;
			this.line261.Width = 0F;
			this.line261.X1 = 1.860118F;
			this.line261.X2 = 1.860118F;
			this.line261.Y1 = 4.351819F;
			this.line261.Y2 = 4.509819F;
			// 
			// SposMyNumber1_3Text
			// 
			this.SposMyNumber1_3Text.CanGrow = false;
			this.SposMyNumber1_3Text.Height = 0.14F;
			this.SposMyNumber1_3Text.Left = 1.940118F;
			this.SposMyNumber1_3Text.Name = "SposMyNumber1_3Text";
			this.SposMyNumber1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber1_3Text.Text = "1234";
			this.SposMyNumber1_3Text.Top = 4.398819F;
			this.SposMyNumber1_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_1_1Text
			// 
			this.DpndMyNumber1_1_1Text.CanGrow = false;
			this.DpndMyNumber1_1_1Text.Height = 0.14F;
			this.DpndMyNumber1_1_1Text.Left = 0.8551183F;
			this.DpndMyNumber1_1_1Text.Name = "DpndMyNumber1_1_1Text";
			this.DpndMyNumber1_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_1Text.Text = "1234";
			this.DpndMyNumber1_1_1Text.Top = 4.828819F;
			this.DpndMyNumber1_1_1Text.Width = 0.355F;
			// 
			// line262
			// 
			this.line262.Height = 0.1430011F;
			this.line262.Left = 1.310118F;
			this.line262.LineWeight = 1F;
			this.line262.Name = "line262";
			this.line262.Top = 4.791818F;
			this.line262.Width = 0F;
			this.line262.X1 = 1.310118F;
			this.line262.X2 = 1.310118F;
			this.line262.Y1 = 4.791818F;
			this.line262.Y2 = 4.934819F;
			// 
			// DpndMyNumber1_1_2Text
			// 
			this.DpndMyNumber1_1_2Text.CanGrow = false;
			this.DpndMyNumber1_1_2Text.Height = 0.14F;
			this.DpndMyNumber1_1_2Text.Left = 1.410118F;
			this.DpndMyNumber1_1_2Text.Name = "DpndMyNumber1_1_2Text";
			this.DpndMyNumber1_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_2Text.Text = "1234";
			this.DpndMyNumber1_1_2Text.Top = 4.828819F;
			this.DpndMyNumber1_1_2Text.Width = 0.355F;
			// 
			// DpndMyNumber1_1_3Text
			// 
			this.DpndMyNumber1_1_3Text.CanGrow = false;
			this.DpndMyNumber1_1_3Text.Height = 0.14F;
			this.DpndMyNumber1_1_3Text.Left = 1.940118F;
			this.DpndMyNumber1_1_3Text.Name = "DpndMyNumber1_1_3Text";
			this.DpndMyNumber1_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_1_3Text.Text = "1234";
			this.DpndMyNumber1_1_3Text.Top = 4.828819F;
			this.DpndMyNumber1_1_3Text.Width = 0.355F;
			// 
			// line263
			// 
			this.line263.Height = 0.1430011F;
			this.line263.Left = 1.860118F;
			this.line263.LineWeight = 1F;
			this.line263.Name = "line263";
			this.line263.Top = 4.791818F;
			this.line263.Width = 0F;
			this.line263.X1 = 1.860118F;
			this.line263.X2 = 1.860118F;
			this.line263.Y1 = 4.791818F;
			this.line263.Y2 = 4.934819F;
			// 
			// DpndMyNumber1_2_1Text
			// 
			this.DpndMyNumber1_2_1Text.CanGrow = false;
			this.DpndMyNumber1_2_1Text.Height = 0.14F;
			this.DpndMyNumber1_2_1Text.Left = 0.8551183F;
			this.DpndMyNumber1_2_1Text.Name = "DpndMyNumber1_2_1Text";
			this.DpndMyNumber1_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_1Text.Text = "1234";
			this.DpndMyNumber1_2_1Text.Top = 5.248819F;
			this.DpndMyNumber1_2_1Text.Width = 0.355F;
			// 
			// line264
			// 
			this.line264.Height = 0.1430001F;
			this.line264.Left = 1.310118F;
			this.line264.LineWeight = 1F;
			this.line264.Name = "line264";
			this.line264.Top = 5.216819F;
			this.line264.Width = 0F;
			this.line264.X1 = 1.310118F;
			this.line264.X2 = 1.310118F;
			this.line264.Y1 = 5.216819F;
			this.line264.Y2 = 5.359819F;
			// 
			// DpndMyNumber1_2_2Text
			// 
			this.DpndMyNumber1_2_2Text.CanGrow = false;
			this.DpndMyNumber1_2_2Text.Height = 0.14F;
			this.DpndMyNumber1_2_2Text.Left = 1.410118F;
			this.DpndMyNumber1_2_2Text.Name = "DpndMyNumber1_2_2Text";
			this.DpndMyNumber1_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_2Text.Text = "1234";
			this.DpndMyNumber1_2_2Text.Top = 5.248819F;
			this.DpndMyNumber1_2_2Text.Width = 0.355F;
			// 
			// line280
			// 
			this.line280.Height = 0.1430001F;
			this.line280.Left = 1.860118F;
			this.line280.LineWeight = 1F;
			this.line280.Name = "line280";
			this.line280.Top = 5.216819F;
			this.line280.Width = 0F;
			this.line280.X1 = 1.860118F;
			this.line280.X2 = 1.860118F;
			this.line280.Y1 = 5.216819F;
			this.line280.Y2 = 5.359819F;
			// 
			// DpndMyNumber1_2_3Text
			// 
			this.DpndMyNumber1_2_3Text.CanGrow = false;
			this.DpndMyNumber1_2_3Text.Height = 0.14F;
			this.DpndMyNumber1_2_3Text.Left = 1.940118F;
			this.DpndMyNumber1_2_3Text.Name = "DpndMyNumber1_2_3Text";
			this.DpndMyNumber1_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_2_3Text.Text = "1234";
			this.DpndMyNumber1_2_3Text.Top = 5.248819F;
			this.DpndMyNumber1_2_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_3_1Text
			// 
			this.DpndMyNumber1_3_1Text.CanGrow = false;
			this.DpndMyNumber1_3_1Text.Height = 0.14F;
			this.DpndMyNumber1_3_1Text.Left = 0.8551183F;
			this.DpndMyNumber1_3_1Text.Name = "DpndMyNumber1_3_1Text";
			this.DpndMyNumber1_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_1Text.Text = "1234";
			this.DpndMyNumber1_3_1Text.Top = 5.668818F;
			this.DpndMyNumber1_3_1Text.Width = 0.355F;
			// 
			// line281
			// 
			this.line281.Height = 0.1429992F;
			this.line281.Left = 1.310118F;
			this.line281.LineWeight = 1F;
			this.line281.Name = "line281";
			this.line281.Top = 5.641819F;
			this.line281.Width = 0F;
			this.line281.X1 = 1.310118F;
			this.line281.X2 = 1.310118F;
			this.line281.Y1 = 5.641819F;
			this.line281.Y2 = 5.784818F;
			// 
			// DpndMyNumber1_3_2Text
			// 
			this.DpndMyNumber1_3_2Text.CanGrow = false;
			this.DpndMyNumber1_3_2Text.Height = 0.14F;
			this.DpndMyNumber1_3_2Text.Left = 1.410118F;
			this.DpndMyNumber1_3_2Text.Name = "DpndMyNumber1_3_2Text";
			this.DpndMyNumber1_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_2Text.Text = "1234";
			this.DpndMyNumber1_3_2Text.Top = 5.668818F;
			this.DpndMyNumber1_3_2Text.Width = 0.355F;
			// 
			// line282
			// 
			this.line282.Height = 0.1429992F;
			this.line282.Left = 1.860118F;
			this.line282.LineWeight = 1F;
			this.line282.Name = "line282";
			this.line282.Top = 5.641819F;
			this.line282.Width = 0F;
			this.line282.X1 = 1.860118F;
			this.line282.X2 = 1.860118F;
			this.line282.Y1 = 5.641819F;
			this.line282.Y2 = 5.784818F;
			// 
			// DpndMyNumber1_3_3Text
			// 
			this.DpndMyNumber1_3_3Text.CanGrow = false;
			this.DpndMyNumber1_3_3Text.Height = 0.14F;
			this.DpndMyNumber1_3_3Text.Left = 1.940118F;
			this.DpndMyNumber1_3_3Text.Name = "DpndMyNumber1_3_3Text";
			this.DpndMyNumber1_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_3_3Text.Text = "1234";
			this.DpndMyNumber1_3_3Text.Top = 5.668818F;
			this.DpndMyNumber1_3_3Text.Width = 0.355F;
			// 
			// DpndMyNumber1_4_1Text
			// 
			this.DpndMyNumber1_4_1Text.CanGrow = false;
			this.DpndMyNumber1_4_1Text.Height = 0.14F;
			this.DpndMyNumber1_4_1Text.Left = 0.8551183F;
			this.DpndMyNumber1_4_1Text.Name = "DpndMyNumber1_4_1Text";
			this.DpndMyNumber1_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_1Text.Text = "1234";
			this.DpndMyNumber1_4_1Text.Top = 6.098818F;
			this.DpndMyNumber1_4_1Text.Width = 0.355F;
			// 
			// line283
			// 
			this.line283.Height = 0.1430006F;
			this.line283.Left = 1.310118F;
			this.line283.LineWeight = 1F;
			this.line283.Name = "line283";
			this.line283.Top = 6.066818F;
			this.line283.Width = 0F;
			this.line283.X1 = 1.310118F;
			this.line283.X2 = 1.310118F;
			this.line283.Y1 = 6.066818F;
			this.line283.Y2 = 6.209819F;
			// 
			// DpndMyNumber1_4_2Text
			// 
			this.DpndMyNumber1_4_2Text.CanGrow = false;
			this.DpndMyNumber1_4_2Text.Height = 0.14F;
			this.DpndMyNumber1_4_2Text.Left = 1.410118F;
			this.DpndMyNumber1_4_2Text.Name = "DpndMyNumber1_4_2Text";
			this.DpndMyNumber1_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_2Text.Text = "1234";
			this.DpndMyNumber1_4_2Text.Top = 6.098818F;
			this.DpndMyNumber1_4_2Text.Width = 0.355F;
			// 
			// line284
			// 
			this.line284.Height = 0.1430006F;
			this.line284.Left = 1.860118F;
			this.line284.LineWeight = 1F;
			this.line284.Name = "line284";
			this.line284.Top = 6.066818F;
			this.line284.Width = 0F;
			this.line284.X1 = 1.860118F;
			this.line284.X2 = 1.860118F;
			this.line284.Y1 = 6.066818F;
			this.line284.Y2 = 6.209819F;
			// 
			// DpndMyNumber1_4_3Text
			// 
			this.DpndMyNumber1_4_3Text.CanGrow = false;
			this.DpndMyNumber1_4_3Text.Height = 0.14F;
			this.DpndMyNumber1_4_3Text.Left = 1.940118F;
			this.DpndMyNumber1_4_3Text.Name = "DpndMyNumber1_4_3Text";
			this.DpndMyNumber1_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_4_3Text.Text = "1234";
			this.DpndMyNumber1_4_3Text.Top = 6.098818F;
			this.DpndMyNumber1_4_3Text.Width = 0.355F;
			// 
			// line260
			// 
			this.line260.Height = 0F;
			this.line260.Left = 4.609843F;
			this.line260.LineWeight = 1F;
			this.line260.Name = "line260";
			this.line260.Top = 4.693307F;
			this.line260.Width = 0.7700005F;
			this.line260.X1 = 4.609843F;
			this.line260.X2 = 5.379843F;
			this.line260.Y1 = 4.693307F;
			this.line260.Y2 = 4.693307F;
			// 
			// label324
			// 
			this.label324.Height = 0.1602364F;
			this.label324.HyperLink = null;
			this.label324.Left = 4.624804F;
			this.label324.Name = "label324";
			this.label324.Style = "font-size: 4pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.label324.Text = "5人目以降の16歳未満の扶養親族の個人番号";
			this.label324.Top = 5.480315F;
			this.label324.Width = 0.7251965F;
			// 
			// line285
			// 
			this.line285.Height = 0F;
			this.line285.Left = 4.609843F;
			this.line285.LineWeight = 1F;
			this.line285.Name = "line285";
			this.line285.Top = 5.641733F;
			this.line285.Width = 0.7700005F;
			this.line285.X1 = 4.609843F;
			this.line285.X2 = 5.379843F;
			this.line285.Y1 = 5.641733F;
			this.line285.Y2 = 5.641733F;
			// 
			// line286
			// 
			this.line286.Height = 0F;
			this.line286.Left = 4.609843F;
			this.line286.LineWeight = 1F;
			this.line286.Name = "line286";
			this.line286.Top = 5.470079F;
			this.line286.Width = 0.7700005F;
			this.line286.X1 = 4.609843F;
			this.line286.X2 = 5.379843F;
			this.line286.Y1 = 5.470079F;
			this.line286.Y2 = 5.470079F;
			// 
			// YngDpndMyNumber1_4_3Text
			// 
			this.YngDpndMyNumber1_4_3Text.CanGrow = false;
			this.YngDpndMyNumber1_4_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_3Text.Left = 4.15F;
			this.YngDpndMyNumber1_4_3Text.Name = "YngDpndMyNumber1_4_3Text";
			this.YngDpndMyNumber1_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_3Text.Text = "1234";
			this.YngDpndMyNumber1_4_3Text.Top = 6.09882F;
			this.YngDpndMyNumber1_4_3Text.Width = 0.355F;
			// 
			// label325
			// 
			this.label325.Height = 0.14F;
			this.label325.HyperLink = null;
			this.label325.Left = 2.670118F;
			this.label325.Name = "label325";
			this.label325.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label325.Text = "個人番号";
			this.label325.Top = 4.829135F;
			this.label325.Width = 0.275F;
			// 
			// YngDpndMyNumber1_1_1Text
			// 
			this.YngDpndMyNumber1_1_1Text.CanGrow = false;
			this.YngDpndMyNumber1_1_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_1Text.Left = 3.065F;
			this.YngDpndMyNumber1_1_1Text.Name = "YngDpndMyNumber1_1_1Text";
			this.YngDpndMyNumber1_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_1Text.Text = "1234";
			this.YngDpndMyNumber1_1_1Text.Top = 4.82882F;
			this.YngDpndMyNumber1_1_1Text.Width = 0.355F;
			// 
			// line86
			// 
			this.line86.Height = 0.1430011F;
			this.line86.Left = 3.52F;
			this.line86.LineWeight = 1F;
			this.line86.Name = "line86";
			this.line86.Top = 4.791819F;
			this.line86.Width = 0F;
			this.line86.X1 = 3.52F;
			this.line86.X2 = 3.52F;
			this.line86.Y1 = 4.791819F;
			this.line86.Y2 = 4.93482F;
			// 
			// YngDpndMyNumber1_1_2Text
			// 
			this.YngDpndMyNumber1_1_2Text.CanGrow = false;
			this.YngDpndMyNumber1_1_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_2Text.Left = 3.62F;
			this.YngDpndMyNumber1_1_2Text.Name = "YngDpndMyNumber1_1_2Text";
			this.YngDpndMyNumber1_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_2Text.Text = "1234";
			this.YngDpndMyNumber1_1_2Text.Top = 4.82882F;
			this.YngDpndMyNumber1_1_2Text.Width = 0.355F;
			// 
			// line87
			// 
			this.line87.Height = 0.1430011F;
			this.line87.Left = 4.070001F;
			this.line87.LineWeight = 1F;
			this.line87.Name = "line87";
			this.line87.Top = 4.791819F;
			this.line87.Width = 0F;
			this.line87.X1 = 4.070001F;
			this.line87.X2 = 4.070001F;
			this.line87.Y1 = 4.791819F;
			this.line87.Y2 = 4.93482F;
			// 
			// YngDpndMyNumber1_1_3Text
			// 
			this.YngDpndMyNumber1_1_3Text.CanGrow = false;
			this.YngDpndMyNumber1_1_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_1_3Text.Left = 4.15F;
			this.YngDpndMyNumber1_1_3Text.Name = "YngDpndMyNumber1_1_3Text";
			this.YngDpndMyNumber1_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_1_3Text.Text = "1234";
			this.YngDpndMyNumber1_1_3Text.Top = 4.82882F;
			this.YngDpndMyNumber1_1_3Text.Width = 0.355F;
			// 
			// label326
			// 
			this.label326.Height = 0.14F;
			this.label326.HyperLink = null;
			this.label326.Left = 2.670118F;
			this.label326.Name = "label326";
			this.label326.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label326.Text = "個人番号";
			this.label326.Top = 5.259449F;
			this.label326.Width = 0.275F;
			// 
			// YngDpndMyNumber1_2_1Text
			// 
			this.YngDpndMyNumber1_2_1Text.CanGrow = false;
			this.YngDpndMyNumber1_2_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_1Text.Left = 3.065F;
			this.YngDpndMyNumber1_2_1Text.Name = "YngDpndMyNumber1_2_1Text";
			this.YngDpndMyNumber1_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_1Text.Text = "1234";
			this.YngDpndMyNumber1_2_1Text.Top = 5.248819F;
			this.YngDpndMyNumber1_2_1Text.Width = 0.355F;
			// 
			// line88
			// 
			this.line88.Height = 0.1430001F;
			this.line88.Left = 3.52F;
			this.line88.LineWeight = 1F;
			this.line88.Name = "line88";
			this.line88.Top = 5.21682F;
			this.line88.Width = 0F;
			this.line88.X1 = 3.52F;
			this.line88.X2 = 3.52F;
			this.line88.Y1 = 5.21682F;
			this.line88.Y2 = 5.35982F;
			// 
			// YngDpndMyNumber1_2_2Text
			// 
			this.YngDpndMyNumber1_2_2Text.CanGrow = false;
			this.YngDpndMyNumber1_2_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_2Text.Left = 3.62F;
			this.YngDpndMyNumber1_2_2Text.Name = "YngDpndMyNumber1_2_2Text";
			this.YngDpndMyNumber1_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_2Text.Text = "1234";
			this.YngDpndMyNumber1_2_2Text.Top = 5.248819F;
			this.YngDpndMyNumber1_2_2Text.Width = 0.355F;
			// 
			// line89
			// 
			this.line89.Height = 0.1430001F;
			this.line89.Left = 4.070001F;
			this.line89.LineWeight = 1F;
			this.line89.Name = "line89";
			this.line89.Top = 5.21682F;
			this.line89.Width = 0F;
			this.line89.X1 = 4.070001F;
			this.line89.X2 = 4.070001F;
			this.line89.Y1 = 5.21682F;
			this.line89.Y2 = 5.35982F;
			// 
			// YngDpndMyNumber1_2_3Text
			// 
			this.YngDpndMyNumber1_2_3Text.CanGrow = false;
			this.YngDpndMyNumber1_2_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_2_3Text.Left = 4.15F;
			this.YngDpndMyNumber1_2_3Text.Name = "YngDpndMyNumber1_2_3Text";
			this.YngDpndMyNumber1_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_2_3Text.Text = "1234";
			this.YngDpndMyNumber1_2_3Text.Top = 5.248819F;
			this.YngDpndMyNumber1_2_3Text.Width = 0.355F;
			// 
			// label327
			// 
			this.label327.Height = 0.14F;
			this.label327.HyperLink = null;
			this.label327.Left = 2.670118F;
			this.label327.Name = "label327";
			this.label327.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label327.Text = "個人番号";
			this.label327.Top = 5.685041F;
			this.label327.Width = 0.275F;
			// 
			// YngDpndMyNumber1_3_1Text
			// 
			this.YngDpndMyNumber1_3_1Text.CanGrow = false;
			this.YngDpndMyNumber1_3_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_1Text.Left = 3.065F;
			this.YngDpndMyNumber1_3_1Text.Name = "YngDpndMyNumber1_3_1Text";
			this.YngDpndMyNumber1_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_1Text.Text = "1234";
			this.YngDpndMyNumber1_3_1Text.Top = 5.66882F;
			this.YngDpndMyNumber1_3_1Text.Width = 0.355F;
			// 
			// line287
			// 
			this.line287.Height = 0.1429992F;
			this.line287.Left = 3.52F;
			this.line287.LineWeight = 1F;
			this.line287.Name = "line287";
			this.line287.Top = 5.64182F;
			this.line287.Width = 0F;
			this.line287.X1 = 3.52F;
			this.line287.X2 = 3.52F;
			this.line287.Y1 = 5.64182F;
			this.line287.Y2 = 5.784819F;
			// 
			// YngDpndMyNumber1_3_2Text
			// 
			this.YngDpndMyNumber1_3_2Text.CanGrow = false;
			this.YngDpndMyNumber1_3_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_2Text.Left = 3.62F;
			this.YngDpndMyNumber1_3_2Text.Name = "YngDpndMyNumber1_3_2Text";
			this.YngDpndMyNumber1_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_2Text.Text = "1234";
			this.YngDpndMyNumber1_3_2Text.Top = 5.66882F;
			this.YngDpndMyNumber1_3_2Text.Width = 0.355F;
			// 
			// line288
			// 
			this.line288.Height = 0.1429992F;
			this.line288.Left = 4.070001F;
			this.line288.LineWeight = 1F;
			this.line288.Name = "line288";
			this.line288.Top = 5.64182F;
			this.line288.Width = 0F;
			this.line288.X1 = 4.070001F;
			this.line288.X2 = 4.070001F;
			this.line288.Y1 = 5.64182F;
			this.line288.Y2 = 5.784819F;
			// 
			// YngDpndMyNumber1_3_3Text
			// 
			this.YngDpndMyNumber1_3_3Text.CanGrow = false;
			this.YngDpndMyNumber1_3_3Text.Height = 0.14F;
			this.YngDpndMyNumber1_3_3Text.Left = 4.15F;
			this.YngDpndMyNumber1_3_3Text.Name = "YngDpndMyNumber1_3_3Text";
			this.YngDpndMyNumber1_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_3_3Text.Text = "1234";
			this.YngDpndMyNumber1_3_3Text.Top = 5.66882F;
			this.YngDpndMyNumber1_3_3Text.Width = 0.355F;
			// 
			// label328
			// 
			this.label328.Height = 0.14F;
			this.label328.HyperLink = null;
			this.label328.Left = 2.670118F;
			this.label328.Name = "label328";
			this.label328.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label328.Text = "個人番号";
			this.label328.Top = 6.109056F;
			this.label328.Width = 0.275F;
			// 
			// YngDpndMyNumber1_4_1Text
			// 
			this.YngDpndMyNumber1_4_1Text.CanGrow = false;
			this.YngDpndMyNumber1_4_1Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_1Text.Left = 3.065F;
			this.YngDpndMyNumber1_4_1Text.Name = "YngDpndMyNumber1_4_1Text";
			this.YngDpndMyNumber1_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_1Text.Text = "1234";
			this.YngDpndMyNumber1_4_1Text.Top = 6.09882F;
			this.YngDpndMyNumber1_4_1Text.Width = 0.355F;
			// 
			// line289
			// 
			this.line289.Height = 0.1429996F;
			this.line289.Left = 3.52F;
			this.line289.LineWeight = 1F;
			this.line289.Name = "line289";
			this.line289.Top = 6.066819F;
			this.line289.Width = 0F;
			this.line289.X1 = 3.52F;
			this.line289.X2 = 3.52F;
			this.line289.Y1 = 6.066819F;
			this.line289.Y2 = 6.209819F;
			// 
			// YngDpndMyNumber1_4_2Text
			// 
			this.YngDpndMyNumber1_4_2Text.CanGrow = false;
			this.YngDpndMyNumber1_4_2Text.Height = 0.14F;
			this.YngDpndMyNumber1_4_2Text.Left = 3.62F;
			this.YngDpndMyNumber1_4_2Text.Name = "YngDpndMyNumber1_4_2Text";
			this.YngDpndMyNumber1_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_4_2Text.Text = "1234";
			this.YngDpndMyNumber1_4_2Text.Top = 6.09882F;
			this.YngDpndMyNumber1_4_2Text.Width = 0.355F;
			// 
			// line290
			// 
			this.line290.Height = 0.1429996F;
			this.line290.Left = 4.070001F;
			this.line290.LineWeight = 1F;
			this.line290.Name = "line290";
			this.line290.Top = 6.066819F;
			this.line290.Width = 0F;
			this.line290.X1 = 4.070001F;
			this.line290.X2 = 4.070001F;
			this.line290.Y1 = 6.066819F;
			this.line290.Y2 = 6.209819F;
			// 
			// line30
			// 
			this.line30.Height = 0.1999998F;
			this.line30.Left = 1.055197F;
			this.line30.LineWeight = 1F;
			this.line30.Name = "line30";
			this.line30.Top = 6.90008F;
			this.line30.Width = 0F;
			this.line30.X1 = 1.055197F;
			this.line30.X2 = 1.055197F;
			this.line30.Y1 = 6.90008F;
			this.line30.Y2 = 7.10008F;
			// 
			// textBox137
			// 
			this.textBox137.CanGrow = false;
			this.textBox137.Height = 0.2F;
			this.textBox137.Left = 2F;
			this.textBox137.MultiLine = false;
			this.textBox137.Name = "textBox137";
			this.textBox137.Style = "font-size: 5pt; text-align: left; vertical-align: middle; white-space: inherit; d" +
    "do-char-set: 1";
			this.textBox137.Text = "（右詰で記載してください。）";
			this.textBox137.Top = 6.900394F;
			this.textBox137.Width = 1.08F;
			// 
			// line291
			// 
			this.line291.Height = 0.1999998F;
			this.line291.Left = 1.355F;
			this.line291.LineWeight = 1F;
			this.line291.Name = "line291";
			this.line291.Top = 6.900394F;
			this.line291.Width = 0F;
			this.line291.X1 = 1.355F;
			this.line291.X2 = 1.355F;
			this.line291.Y1 = 6.900394F;
			this.line291.Y2 = 7.100394F;
			// 
			// line292
			// 
			this.line292.Height = 0.1999998F;
			this.line292.Left = 1.655F;
			this.line292.LineWeight = 1F;
			this.line292.Name = "line292";
			this.line292.Top = 6.900394F;
			this.line292.Width = 0F;
			this.line292.X1 = 1.655F;
			this.line292.X2 = 1.655F;
			this.line292.Y1 = 6.900394F;
			this.line292.Y2 = 7.100394F;
			// 
			// line293
			// 
			this.line293.Height = 0.1999998F;
			this.line293.Left = 1.955F;
			this.line293.LineWeight = 1F;
			this.line293.Name = "line293";
			this.line293.Top = 6.900394F;
			this.line293.Width = 0F;
			this.line293.X1 = 1.955F;
			this.line293.X2 = 1.955F;
			this.line293.Y1 = 6.900394F;
			this.line293.Y2 = 7.100394F;
			// 
			// label315
			// 
			this.label315.Height = 0.1602364F;
			this.label315.HyperLink = null;
			this.label315.Left = 10.35354F;
			this.label315.Name = "label315";
			this.label315.Style = "font-size: 4pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.label315.Text = "5人目以降の控除対象扶養親族の個人番号";
			this.label315.Top = 4.529922F;
			this.label315.Width = 0.7251965F;
			// 
			// line294
			// 
			this.line294.Height = 0F;
			this.line294.Left = 10.33858F;
			this.line294.LineWeight = 1F;
			this.line294.Name = "line294";
			this.line294.Top = 4.693307F;
			this.line294.Width = 0.7699995F;
			this.line294.X1 = 10.33858F;
			this.line294.X2 = 11.10858F;
			this.line294.Y1 = 4.693307F;
			this.line294.Y2 = 4.693307F;
			// 
			// YngDpndRemarksText2
			// 
			this.YngDpndRemarksText2.CanGrow = false;
			this.YngDpndRemarksText2.DataField = "YNGREMARKS";
			this.YngDpndRemarksText2.Height = 0.5574804F;
			this.YngDpndRemarksText2.Left = 10.35433F;
			this.YngDpndRemarksText2.Name = "YngDpndRemarksText2";
			this.YngDpndRemarksText2.Style = "font-size: 6pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.YngDpndRemarksText2.Text = "(1)123456789012(2)123456789012(3)123456789012(4)123456789012(5)123456789012(6)123" +
    "456789012";
			this.YngDpndRemarksText2.Top = 5.662599F;
			this.YngDpndRemarksText2.Width = 0.7299993F;
			// 
			// line273
			// 
			this.line273.Height = 0F;
			this.line273.Left = 10.33898F;
			this.line273.LineWeight = 1F;
			this.line273.Name = "line273";
			this.line273.Top = 5.641733F;
			this.line273.Width = 0.7700005F;
			this.line273.X1 = 10.33898F;
			this.line273.X2 = 11.10898F;
			this.line273.Y1 = 5.641733F;
			this.line273.Y2 = 5.641733F;
			// 
			// line274
			// 
			this.line274.Height = 0F;
			this.line274.Left = 10.33898F;
			this.line274.LineWeight = 1F;
			this.line274.Name = "line274";
			this.line274.Top = 5.470079F;
			this.line274.Width = 0.7700005F;
			this.line274.X1 = 10.33898F;
			this.line274.X2 = 11.10898F;
			this.line274.Y1 = 5.470079F;
			this.line274.Y2 = 5.470079F;
			// 
			// label331
			// 
			this.label331.Height = 0.1602364F;
			this.label331.HyperLink = null;
			this.label331.Left = 10.35394F;
			this.label331.Name = "label331";
			this.label331.Style = "font-size: 4pt; text-align: left; vertical-align: top; white-space: inherit; ddo-" +
    "char-set: 1";
			this.label331.Text = "5人目以降の16歳未満の扶養親族の個人番号";
			this.label331.Top = 5.480315F;
			this.label331.Width = 0.7251965F;
			// 
			// YngDpndMyNumber2_1_1Text
			// 
			this.YngDpndMyNumber2_1_1Text.CanGrow = false;
			this.YngDpndMyNumber2_1_1Text.Height = 0.14F;
			this.YngDpndMyNumber2_1_1Text.Left = 8.783859F;
			this.YngDpndMyNumber2_1_1Text.Name = "YngDpndMyNumber2_1_1Text";
			this.YngDpndMyNumber2_1_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_1_1Text.Text = "1234";
			this.YngDpndMyNumber2_1_1Text.Top = 4.829134F;
			this.YngDpndMyNumber2_1_1Text.Width = 0.355F;
			// 
			// label332
			// 
			this.label332.Height = 0.14F;
			this.label332.HyperLink = null;
			this.label332.Left = 8.398859F;
			this.label332.Name = "label332";
			this.label332.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label332.Text = "個人番号";
			this.label332.Top = 4.829134F;
			this.label332.Width = 0.275F;
			// 
			// YngDpndMyNumber2_1_2Text
			// 
			this.YngDpndMyNumber2_1_2Text.CanGrow = false;
			this.YngDpndMyNumber2_1_2Text.Height = 0.14F;
			this.YngDpndMyNumber2_1_2Text.Left = 9.33886F;
			this.YngDpndMyNumber2_1_2Text.Name = "YngDpndMyNumber2_1_2Text";
			this.YngDpndMyNumber2_1_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_1_2Text.Text = "1234";
			this.YngDpndMyNumber2_1_2Text.Top = 4.829134F;
			this.YngDpndMyNumber2_1_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_1_3Text
			// 
			this.YngDpndMyNumber2_1_3Text.CanGrow = false;
			this.YngDpndMyNumber2_1_3Text.Height = 0.14F;
			this.YngDpndMyNumber2_1_3Text.Left = 9.868859F;
			this.YngDpndMyNumber2_1_3Text.Name = "YngDpndMyNumber2_1_3Text";
			this.YngDpndMyNumber2_1_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_1_3Text.Text = "1234";
			this.YngDpndMyNumber2_1_3Text.Top = 4.829134F;
			this.YngDpndMyNumber2_1_3Text.Width = 0.355F;
			// 
			// line69
			// 
			this.line69.Height = 0.1430011F;
			this.line69.Left = 9.238859F;
			this.line69.LineWeight = 1F;
			this.line69.Name = "line69";
			this.line69.Top = 4.792133F;
			this.line69.Width = 0F;
			this.line69.X1 = 9.238859F;
			this.line69.X2 = 9.238859F;
			this.line69.Y1 = 4.792133F;
			this.line69.Y2 = 4.935134F;
			// 
			// line75
			// 
			this.line75.Height = 0.1430011F;
			this.line75.Left = 9.788859F;
			this.line75.LineWeight = 1F;
			this.line75.Name = "line75";
			this.line75.Top = 4.792133F;
			this.line75.Width = 0F;
			this.line75.X1 = 9.788859F;
			this.line75.X2 = 9.788859F;
			this.line75.Y1 = 4.792133F;
			this.line75.Y2 = 4.935134F;
			// 
			// label333
			// 
			this.label333.Height = 0.14F;
			this.label333.HyperLink = null;
			this.label333.Left = 8.398859F;
			this.label333.Name = "label333";
			this.label333.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label333.Text = "個人番号";
			this.label333.Top = 5.249134F;
			this.label333.Width = 0.275F;
			// 
			// YngDpndMyNumber2_2_1Text
			// 
			this.YngDpndMyNumber2_2_1Text.CanGrow = false;
			this.YngDpndMyNumber2_2_1Text.Height = 0.14F;
			this.YngDpndMyNumber2_2_1Text.Left = 8.783859F;
			this.YngDpndMyNumber2_2_1Text.Name = "YngDpndMyNumber2_2_1Text";
			this.YngDpndMyNumber2_2_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_2_1Text.Text = "1234";
			this.YngDpndMyNumber2_2_1Text.Top = 5.249134F;
			this.YngDpndMyNumber2_2_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_2_2Text
			// 
			this.YngDpndMyNumber2_2_2Text.CanGrow = false;
			this.YngDpndMyNumber2_2_2Text.Height = 0.14F;
			this.YngDpndMyNumber2_2_2Text.Left = 9.33886F;
			this.YngDpndMyNumber2_2_2Text.Name = "YngDpndMyNumber2_2_2Text";
			this.YngDpndMyNumber2_2_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_2_2Text.Text = "1234";
			this.YngDpndMyNumber2_2_2Text.Top = 5.249134F;
			this.YngDpndMyNumber2_2_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_2_3Text
			// 
			this.YngDpndMyNumber2_2_3Text.CanGrow = false;
			this.YngDpndMyNumber2_2_3Text.Height = 0.14F;
			this.YngDpndMyNumber2_2_3Text.Left = 9.868859F;
			this.YngDpndMyNumber2_2_3Text.Name = "YngDpndMyNumber2_2_3Text";
			this.YngDpndMyNumber2_2_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_2_3Text.Text = "1234";
			this.YngDpndMyNumber2_2_3Text.Top = 5.249134F;
			this.YngDpndMyNumber2_2_3Text.Width = 0.355F;
			// 
			// line80
			// 
			this.line80.Height = 0.1430001F;
			this.line80.Left = 9.238859F;
			this.line80.LineWeight = 1F;
			this.line80.Name = "line80";
			this.line80.Top = 5.217134F;
			this.line80.Width = 0F;
			this.line80.X1 = 9.238859F;
			this.line80.X2 = 9.238859F;
			this.line80.Y1 = 5.217134F;
			this.line80.Y2 = 5.360134F;
			// 
			// line118
			// 
			this.line118.Height = 0.1430001F;
			this.line118.Left = 9.788859F;
			this.line118.LineWeight = 1F;
			this.line118.Name = "line118";
			this.line118.Top = 5.217134F;
			this.line118.Width = 0F;
			this.line118.X1 = 9.788859F;
			this.line118.X2 = 9.788859F;
			this.line118.Y1 = 5.217134F;
			this.line118.Y2 = 5.360134F;
			// 
			// label334
			// 
			this.label334.Height = 0.14F;
			this.label334.HyperLink = null;
			this.label334.Left = 8.398859F;
			this.label334.Name = "label334";
			this.label334.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label334.Text = "個人番号";
			this.label334.Top = 5.669134F;
			this.label334.Width = 0.275F;
			// 
			// YngDpndMyNumber2_3_1Text
			// 
			this.YngDpndMyNumber2_3_1Text.CanGrow = false;
			this.YngDpndMyNumber2_3_1Text.Height = 0.14F;
			this.YngDpndMyNumber2_3_1Text.Left = 8.783859F;
			this.YngDpndMyNumber2_3_1Text.Name = "YngDpndMyNumber2_3_1Text";
			this.YngDpndMyNumber2_3_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_3_1Text.Text = "1234";
			this.YngDpndMyNumber2_3_1Text.Top = 5.669134F;
			this.YngDpndMyNumber2_3_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_3_2Text
			// 
			this.YngDpndMyNumber2_3_2Text.CanGrow = false;
			this.YngDpndMyNumber2_3_2Text.Height = 0.14F;
			this.YngDpndMyNumber2_3_2Text.Left = 9.33886F;
			this.YngDpndMyNumber2_3_2Text.Name = "YngDpndMyNumber2_3_2Text";
			this.YngDpndMyNumber2_3_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_3_2Text.Text = "1234";
			this.YngDpndMyNumber2_3_2Text.Top = 5.669134F;
			this.YngDpndMyNumber2_3_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_3_3Text
			// 
			this.YngDpndMyNumber2_3_3Text.CanGrow = false;
			this.YngDpndMyNumber2_3_3Text.Height = 0.14F;
			this.YngDpndMyNumber2_3_3Text.Left = 9.868859F;
			this.YngDpndMyNumber2_3_3Text.Name = "YngDpndMyNumber2_3_3Text";
			this.YngDpndMyNumber2_3_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_3_3Text.Text = "1234";
			this.YngDpndMyNumber2_3_3Text.Top = 5.669134F;
			this.YngDpndMyNumber2_3_3Text.Width = 0.355F;
			// 
			// line204
			// 
			this.line204.Height = 0.1429987F;
			this.line204.Left = 9.238859F;
			this.line204.LineWeight = 1F;
			this.line204.Name = "line204";
			this.line204.Top = 5.642134F;
			this.line204.Width = 0F;
			this.line204.X1 = 9.238859F;
			this.line204.X2 = 9.238859F;
			this.line204.Y1 = 5.642134F;
			this.line204.Y2 = 5.785133F;
			// 
			// line210
			// 
			this.line210.Height = 0.1429987F;
			this.line210.Left = 9.788859F;
			this.line210.LineWeight = 1F;
			this.line210.Name = "line210";
			this.line210.Top = 5.642134F;
			this.line210.Width = 0F;
			this.line210.X1 = 9.788859F;
			this.line210.X2 = 9.788859F;
			this.line210.Y1 = 5.642134F;
			this.line210.Y2 = 5.785133F;
			// 
			// label335
			// 
			this.label335.Height = 0.14F;
			this.label335.HyperLink = null;
			this.label335.Left = 8.398859F;
			this.label335.Name = "label335";
			this.label335.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.label335.Text = "個人番号";
			this.label335.Top = 6.099133F;
			this.label335.Width = 0.275F;
			// 
			// YngDpndMyNumber2_4_1Text
			// 
			this.YngDpndMyNumber2_4_1Text.CanGrow = false;
			this.YngDpndMyNumber2_4_1Text.Height = 0.14F;
			this.YngDpndMyNumber2_4_1Text.Left = 8.783859F;
			this.YngDpndMyNumber2_4_1Text.Name = "YngDpndMyNumber2_4_1Text";
			this.YngDpndMyNumber2_4_1Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_4_1Text.Text = "1234";
			this.YngDpndMyNumber2_4_1Text.Top = 6.099133F;
			this.YngDpndMyNumber2_4_1Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_4_2Text
			// 
			this.YngDpndMyNumber2_4_2Text.CanGrow = false;
			this.YngDpndMyNumber2_4_2Text.Height = 0.14F;
			this.YngDpndMyNumber2_4_2Text.Left = 9.33886F;
			this.YngDpndMyNumber2_4_2Text.Name = "YngDpndMyNumber2_4_2Text";
			this.YngDpndMyNumber2_4_2Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_4_2Text.Text = "1234";
			this.YngDpndMyNumber2_4_2Text.Top = 6.099133F;
			this.YngDpndMyNumber2_4_2Text.Width = 0.355F;
			// 
			// YngDpndMyNumber2_4_3Text
			// 
			this.YngDpndMyNumber2_4_3Text.CanGrow = false;
			this.YngDpndMyNumber2_4_3Text.Height = 0.14F;
			this.YngDpndMyNumber2_4_3Text.Left = 9.868859F;
			this.YngDpndMyNumber2_4_3Text.Name = "YngDpndMyNumber2_4_3Text";
			this.YngDpndMyNumber2_4_3Text.Style = "font-size: 6pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_4_3Text.Text = "1234";
			this.YngDpndMyNumber2_4_3Text.Top = 6.099133F;
			this.YngDpndMyNumber2_4_3Text.Width = 0.355F;
			// 
			// line215
			// 
			this.line215.Height = 0.1430011F;
			this.line215.Left = 9.238859F;
			this.line215.LineWeight = 1F;
			this.line215.Name = "line215";
			this.line215.Top = 6.067133F;
			this.line215.Width = 0F;
			this.line215.X1 = 9.238859F;
			this.line215.X2 = 9.238859F;
			this.line215.Y1 = 6.067133F;
			this.line215.Y2 = 6.210134F;
			// 
			// line221
			// 
			this.line221.Height = 0.1430011F;
			this.line221.Left = 9.788859F;
			this.line221.LineWeight = 1F;
			this.line221.Name = "line221";
			this.line221.Top = 6.067133F;
			this.line221.Width = 0F;
			this.line221.X1 = 9.788859F;
			this.line221.X2 = 9.788859F;
			this.line221.Y1 = 6.067133F;
			this.line221.Y2 = 6.210134F;
			// 
			// line309
			// 
			this.line309.Height = 0.1870079F;
			this.line309.Left = 3.166929F;
			this.line309.LineWeight = 1F;
			this.line309.Name = "line309";
			this.line309.Top = 0.009842519F;
			this.line309.Width = 0F;
			this.line309.X1 = 3.166929F;
			this.line309.X2 = 3.166929F;
			this.line309.Y1 = 0.009842519F;
			this.line309.Y2 = 0.1968504F;
			// 
			// line310
			// 
			this.line310.Height = 0.1870079F;
			this.line310.Left = 4.274015F;
			this.line310.LineWeight = 1F;
			this.line310.Name = "line310";
			this.line310.Top = 0.009842522F;
			this.line310.Width = 0F;
			this.line310.X1 = 4.274015F;
			this.line310.X2 = 4.274015F;
			this.line310.Y1 = 0.009842522F;
			this.line310.Y2 = 0.1968504F;
			// 
			// label337
			// 
			this.label337.Height = 0.1149606F;
			this.label337.HyperLink = null;
			this.label337.Left = 2.074803F;
			this.label337.Name = "label337";
			this.label337.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label337.Text = "※種　　　別";
			this.label337.Top = 0.009842521F;
			this.label337.Width = 0.9322834F;
			// 
			// label338
			// 
			this.label338.Height = 0.1149606F;
			this.label338.HyperLink = null;
			this.label338.Left = 3.177166F;
			this.label338.Name = "label338";
			this.label338.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label338.Text = "※整　理　番　号";
			this.label338.Top = 0.009842521F;
			this.label338.Width = 0.9322833F;
			// 
			// label339
			// 
			this.label339.Height = 0.1149606F;
			this.label339.HyperLink = null;
			this.label339.Left = 4.284252F;
			this.label339.Name = "label339";
			this.label339.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label339.Text = "※";
			this.label339.Top = 0.009842521F;
			this.label339.Width = 0.9322833F;
			// 
			// label10
			// 
			this.label10.Height = 0.1141732F;
			this.label10.HyperLink = null;
			this.label10.Left = 5.931497F;
			this.label10.Name = "label10";
			this.label10.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label10.Text = "※";
			this.label10.Top = 0.01062992F;
			this.label10.Width = 0.1224403F;
			// 
			// line314
			// 
			this.line314.Height = 0F;
			this.line314.Left = 5.91693F;
			this.line314.LineWeight = 1F;
			this.line314.Name = "line314";
			this.line314.Top = 0.1047244F;
			this.line314.Width = 5.187F;
			this.line314.X1 = 5.91693F;
			this.line314.X2 = 11.10393F;
			this.line314.Y1 = 0.1047244F;
			this.line314.Y2 = 0.1047244F;
			// 
			// line316
			// 
			this.line316.Height = 0.1870079F;
			this.line316.Left = 7.807087F;
			this.line316.LineWeight = 1F;
			this.line316.Name = "line316";
			this.line316.Top = 0.01062992F;
			this.line316.Width = 0F;
			this.line316.X1 = 7.807087F;
			this.line316.X2 = 7.807087F;
			this.line316.Y1 = 0.01062992F;
			this.line316.Y2 = 0.1976378F;
			// 
			// line317
			// 
			this.line317.Height = 0.0929134F;
			this.line317.Left = 7.693701F;
			this.line317.LineWeight = 1F;
			this.line317.Name = "line317";
			this.line317.Top = 0.1047244F;
			this.line317.Width = 0F;
			this.line317.X1 = 7.693701F;
			this.line317.X2 = 7.693701F;
			this.line317.Y1 = 0.1047244F;
			this.line317.Y2 = 0.1976378F;
			// 
			// line318
			// 
			this.line318.Height = 0.0929134F;
			this.line318.Left = 7.588978F;
			this.line318.LineWeight = 1F;
			this.line318.Name = "line318";
			this.line318.Top = 0.1047244F;
			this.line318.Width = 0F;
			this.line318.X1 = 7.588978F;
			this.line318.X2 = 7.588978F;
			this.line318.Y1 = 0.1047244F;
			this.line318.Y2 = 0.1976378F;
			// 
			// line319
			// 
			this.line319.Height = 0.0929134F;
			this.line319.Left = 7.485827F;
			this.line319.LineWeight = 1F;
			this.line319.Name = "line319";
			this.line319.Top = 0.1047244F;
			this.line319.Width = 0F;
			this.line319.X1 = 7.485827F;
			this.line319.X2 = 7.485827F;
			this.line319.Y1 = 0.1047244F;
			this.line319.Y2 = 0.1976378F;
			// 
			// line320
			// 
			this.line320.Height = 0.0929134F;
			this.line320.Left = 7.386615F;
			this.line320.LineWeight = 1F;
			this.line320.Name = "line320";
			this.line320.Top = 0.1047244F;
			this.line320.Width = 0F;
			this.line320.X1 = 7.386615F;
			this.line320.X2 = 7.386615F;
			this.line320.Y1 = 0.1047244F;
			this.line320.Y2 = 0.1976378F;
			// 
			// line321
			// 
			this.line321.Height = 0.0929134F;
			this.line321.Left = 7.277166F;
			this.line321.LineWeight = 1F;
			this.line321.Name = "line321";
			this.line321.Top = 0.1047244F;
			this.line321.Width = 0F;
			this.line321.X1 = 7.277166F;
			this.line321.X2 = 7.277166F;
			this.line321.Y1 = 0.1047244F;
			this.line321.Y2 = 0.1976378F;
			// 
			// line326
			// 
			this.line326.Height = 0.0929134F;
			this.line326.Left = 7.179134F;
			this.line326.LineWeight = 1F;
			this.line326.Name = "line326";
			this.line326.Top = 0.1047244F;
			this.line326.Width = 0F;
			this.line326.X1 = 7.179134F;
			this.line326.X2 = 7.179134F;
			this.line326.Y1 = 0.1047244F;
			this.line326.Y2 = 0.1976378F;
			// 
			// line331
			// 
			this.line331.Height = 0.0929134F;
			this.line331.Left = 7.068899F;
			this.line331.LineWeight = 1F;
			this.line331.Name = "line331";
			this.line331.Top = 0.1047244F;
			this.line331.Width = 0F;
			this.line331.X1 = 7.068899F;
			this.line331.X2 = 7.068899F;
			this.line331.Y1 = 0.1047244F;
			this.line331.Y2 = 0.1976378F;
			// 
			// line332
			// 
			this.line332.Height = 0.0929134F;
			this.line332.Left = 6.96378F;
			this.line332.LineWeight = 1F;
			this.line332.Name = "line332";
			this.line332.Top = 0.1047244F;
			this.line332.Width = 0F;
			this.line332.X1 = 6.96378F;
			this.line332.X2 = 6.96378F;
			this.line332.Y1 = 0.1047244F;
			this.line332.Y2 = 0.1976378F;
			// 
			// line333
			// 
			this.line333.Height = 0.0929134F;
			this.line333.Left = 6.859843F;
			this.line333.LineWeight = 1F;
			this.line333.Name = "line333";
			this.line333.Top = 0.1047244F;
			this.line333.Width = 0F;
			this.line333.X1 = 6.859843F;
			this.line333.X2 = 6.859843F;
			this.line333.Y1 = 0.1047244F;
			this.line333.Y2 = 0.1976378F;
			// 
			// line334
			// 
			this.line334.Height = 0.0929134F;
			this.line334.Left = 6.765355F;
			this.line334.LineWeight = 1F;
			this.line334.Name = "line334";
			this.line334.Top = 0.1047244F;
			this.line334.Width = 0F;
			this.line334.X1 = 6.765355F;
			this.line334.X2 = 6.765355F;
			this.line334.Y1 = 0.1047244F;
			this.line334.Y2 = 0.1976378F;
			// 
			// line335
			// 
			this.line335.Height = 0.0929134F;
			this.line335.Left = 6.651969F;
			this.line335.LineWeight = 1F;
			this.line335.Name = "line335";
			this.line335.Top = 0.1047244F;
			this.line335.Width = 0F;
			this.line335.X1 = 6.651969F;
			this.line335.X2 = 6.651969F;
			this.line335.Y1 = 0.1047244F;
			this.line335.Y2 = 0.1976378F;
			// 
			// line336
			// 
			this.line336.Height = 0.0929134F;
			this.line336.Left = 6.552756F;
			this.line336.LineWeight = 1F;
			this.line336.Name = "line336";
			this.line336.Top = 0.1047244F;
			this.line336.Width = 0F;
			this.line336.X1 = 6.552756F;
			this.line336.X2 = 6.552756F;
			this.line336.Y1 = 0.1047244F;
			this.line336.Y2 = 0.1976378F;
			// 
			// line337
			// 
			this.line337.Height = 0.0929134F;
			this.line337.Left = 6.443307F;
			this.line337.LineWeight = 1F;
			this.line337.Name = "line337";
			this.line337.Top = 0.1047244F;
			this.line337.Width = 0F;
			this.line337.X1 = 6.443307F;
			this.line337.X2 = 6.443307F;
			this.line337.Y1 = 0.1047244F;
			this.line337.Y2 = 0.1976378F;
			// 
			// line338
			// 
			this.line338.Height = 0.0929134F;
			this.line338.Left = 6.342914F;
			this.line338.LineWeight = 1F;
			this.line338.Name = "line338";
			this.line338.Top = 0.1047244F;
			this.line338.Width = 0F;
			this.line338.X1 = 6.342914F;
			this.line338.X2 = 6.342914F;
			this.line338.Y1 = 0.1047244F;
			this.line338.Y2 = 0.1976378F;
			// 
			// line339
			// 
			this.line339.Height = 0.0929134F;
			this.line339.Left = 6.238583F;
			this.line339.LineWeight = 1F;
			this.line339.Name = "line339";
			this.line339.Top = 0.1047244F;
			this.line339.Width = 0F;
			this.line339.X1 = 6.238583F;
			this.line339.X2 = 6.238583F;
			this.line339.Y1 = 0.1047244F;
			this.line339.Y2 = 0.1976378F;
			// 
			// line340
			// 
			this.line340.Height = 0.0929134F;
			this.line340.Left = 6.134253F;
			this.line340.LineWeight = 1F;
			this.line340.Name = "line340";
			this.line340.Top = 0.1047244F;
			this.line340.Width = 0F;
			this.line340.X1 = 6.134253F;
			this.line340.X2 = 6.134253F;
			this.line340.Y1 = 0.1047244F;
			this.line340.Y2 = 0.1976378F;
			// 
			// line341
			// 
			this.line341.Height = 0.0929134F;
			this.line341.Left = 6.030709F;
			this.line341.LineWeight = 1F;
			this.line341.Name = "line341";
			this.line341.Top = 0.1047244F;
			this.line341.Width = 0F;
			this.line341.X1 = 6.030709F;
			this.line341.X2 = 6.030709F;
			this.line341.Y1 = 0.1047244F;
			this.line341.Y2 = 0.1976378F;
			// 
			// line342
			// 
			this.line342.Height = 0.1870079F;
			this.line342.Left = 8.900787F;
			this.line342.LineWeight = 1F;
			this.line342.Name = "line342";
			this.line342.Top = 0.01062992F;
			this.line342.Width = 0F;
			this.line342.X1 = 8.900787F;
			this.line342.X2 = 8.900787F;
			this.line342.Y1 = 0.01062992F;
			this.line342.Y2 = 0.1976378F;
			// 
			// line343
			// 
			this.line343.Height = 0.1870079F;
			this.line343.Left = 10.00787F;
			this.line343.LineWeight = 1F;
			this.line343.Name = "line343";
			this.line343.Top = 0.01062992F;
			this.line343.Width = 0F;
			this.line343.X1 = 10.00787F;
			this.line343.X2 = 10.00787F;
			this.line343.Y1 = 0.01062992F;
			this.line343.Y2 = 0.1976378F;
			// 
			// label11
			// 
			this.label11.Height = 0.1141732F;
			this.label11.HyperLink = null;
			this.label11.Left = 7.808662F;
			this.label11.Name = "label11";
			this.label11.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label11.Text = "※種　　　別";
			this.label11.Top = 0.01062992F;
			this.label11.Width = 0.9322833F;
			// 
			// label340
			// 
			this.label340.Height = 0.1141732F;
			this.label340.HyperLink = null;
			this.label340.Left = 8.911024F;
			this.label340.Name = "label340";
			this.label340.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label340.Text = "※整　理　番　号";
			this.label340.Top = 0.01062992F;
			this.label340.Width = 0.9322833F;
			// 
			// label341
			// 
			this.label341.Height = 0.1141732F;
			this.label341.HyperLink = null;
			this.label341.Left = 10.01811F;
			this.label341.Name = "label341";
			this.label341.Style = "font-size: 5pt; text-align: left; vertical-align: top; ddo-char-set: 1";
			this.label341.Text = "※";
			this.label341.Top = 0.01062992F;
			this.label341.Width = 0.9322833F;
			// 
			// label342
			// 
			this.label342.Height = 0.1984252F;
			this.label342.HyperLink = null;
			this.label342.Left = 0F;
			this.label342.Name = "label342";
			this.label342.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 1";
			this.label342.Text = "○";
			this.label342.Top = 0.02007874F;
			this.label342.Width = 0.1917323F;
			// 
			// label344
			// 
			this.label344.Height = 1.027559F;
			this.label344.HyperLink = null;
			this.label344.Left = 0.01023622F;
			this.label344.Name = "label344";
			this.label344.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label344.Text = "給与支払報告書";
			this.label344.Top = 0.3850394F;
			this.label344.Width = 0.1598426F;
			// 
			// label348
			// 
			this.label348.Height = 0.188189F;
			this.label348.HyperLink = null;
			this.label348.Left = 5.724803F;
			this.label348.Name = "label348";
			this.label348.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: inherit; d" +
    "do-char-set: 1";
			this.label348.Text = "○";
			this.label348.Top = 0.02007874F;
			this.label348.Width = 0.1917323F;
			// 
			// label350
			// 
			this.label350.Height = 1.027559F;
			this.label350.HyperLink = null;
			this.label350.Left = 5.73504F;
			this.label350.Name = "label350";
			this.label350.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label350.Text = "給与支払報告書";
			this.label350.Top = 0.3850394F;
			this.label350.Width = 0.1598426F;
			// 
			// label351
			// 
			this.label351.Angle = 2700;
			this.label351.Height = 0.1830708F;
			this.label351.HyperLink = null;
			this.label351.Left = 5.73504F;
			this.label351.Name = "label351";
			this.label351.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label351.Text = "（";
			this.label351.Top = 1.32441F;
			this.label351.Width = 0.1598426F;
			// 
			// label352
			// 
			this.label352.Height = 0.8570864F;
			this.label352.HyperLink = null;
			this.label352.Left = 5.73504F;
			this.label352.Name = "label352";
			this.label352.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label352.Text = "個人別明細書";
			this.label352.Top = 1.467717F;
			this.label352.Width = 0.1598426F;
			// 
			// label353
			// 
			this.label353.Angle = 2700;
			this.label353.Height = 0.1897637F;
			this.label353.HyperLink = null;
			this.label353.Left = 5.73504F;
			this.label353.Name = "label353";
			this.label353.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label353.Text = "）";
			this.label353.Top = 2.269685F;
			this.label353.Width = 0.1598426F;
			// 
			// SposMyNumber_Text
			// 
			this.SposMyNumber_Text.CanGrow = false;
			this.SposMyNumber_Text.DataField = "SPOS_MY_NUMBER";
			this.SposMyNumber_Text.Height = 0.07500042F;
			this.SposMyNumber_Text.Left = 0.7354331F;
			this.SposMyNumber_Text.Name = "SposMyNumber_Text";
			this.SposMyNumber_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.SposMyNumber_Text.Text = "123456789012";
			this.SposMyNumber_Text.Top = 4.38504F;
			this.SposMyNumber_Text.Visible = false;
			this.SposMyNumber_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber1_Text
			// 
			this.DpndMyNumber1_Text.CanGrow = false;
			this.DpndMyNumber1_Text.DataField = "DPND_MY_NUMBER1";
			this.DpndMyNumber1_Text.Height = 0.07500042F;
			this.DpndMyNumber1_Text.Left = 0.7448819F;
			this.DpndMyNumber1_Text.Name = "DpndMyNumber1_Text";
			this.DpndMyNumber1_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber1_Text.Text = "123456789012";
			this.DpndMyNumber1_Text.Top = 4.791733F;
			this.DpndMyNumber1_Text.Visible = false;
			this.DpndMyNumber1_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber2_Text
			// 
			this.DpndMyNumber2_Text.CanGrow = false;
			this.DpndMyNumber2_Text.DataField = "DPND_MY_NUMBER2";
			this.DpndMyNumber2_Text.Height = 0.07500042F;
			this.DpndMyNumber2_Text.Left = 0.7354331F;
			this.DpndMyNumber2_Text.Name = "DpndMyNumber2_Text";
			this.DpndMyNumber2_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber2_Text.Text = "123456789012";
			this.DpndMyNumber2_Text.Top = 5.225039F;
			this.DpndMyNumber2_Text.Visible = false;
			this.DpndMyNumber2_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber3_Text
			// 
			this.DpndMyNumber3_Text.CanGrow = false;
			this.DpndMyNumber3_Text.DataField = "DPND_MY_NUMBER3";
			this.DpndMyNumber3_Text.Height = 0.07500042F;
			this.DpndMyNumber3_Text.Left = 0.7354331F;
			this.DpndMyNumber3_Text.Name = "DpndMyNumber3_Text";
			this.DpndMyNumber3_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber3_Text.Text = "123456789012";
			this.DpndMyNumber3_Text.Top = 5.65004F;
			this.DpndMyNumber3_Text.Visible = false;
			this.DpndMyNumber3_Text.Width = 0.1826772F;
			// 
			// DpndMyNumber4_Text
			// 
			this.DpndMyNumber4_Text.CanGrow = false;
			this.DpndMyNumber4_Text.DataField = "DPND_MY_NUMBER4";
			this.DpndMyNumber4_Text.Height = 0.07500042F;
			this.DpndMyNumber4_Text.Left = 0.7354331F;
			this.DpndMyNumber4_Text.Name = "DpndMyNumber4_Text";
			this.DpndMyNumber4_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.DpndMyNumber4_Text.Text = "123456789012";
			this.DpndMyNumber4_Text.Top = 6.07504F;
			this.DpndMyNumber4_Text.Visible = false;
			this.DpndMyNumber4_Text.Width = 0.1826772F;
			// 
			// MyNumber_Text
			// 
			this.MyNumber_Text.CanGrow = false;
			this.MyNumber_Text.DataField = "MY_NUMBER";
			this.MyNumber_Text.Height = 0.1456693F;
			this.MyNumber_Text.Left = 3.520079F;
			this.MyNumber_Text.Name = "MyNumber_Text";
			this.MyNumber_Text.Style = "font-size: 7.5pt; text-align: left; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.MyNumber_Text.Text = "123456789012";
			this.MyNumber_Text.Top = 0.3200788F;
			this.MyNumber_Text.Visible = false;
			this.MyNumber_Text.Width = 0.2047246F;
			// 
			// YlyEdCalYear2Text
			// 
			this.YlyEdCalYear2Text.CanGrow = false;
			this.YlyEdCalYear2Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear2Text.Height = 0.1665357F;
			this.YlyEdCalYear2Text.Left = 5.721654F;
			this.YlyEdCalYear2Text.Name = "YlyEdCalYear2Text";
			this.YlyEdCalYear2Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YlyEdCalYear2Text.Text = "66";
			this.YlyEdCalYear2Text.Top = 0.03031496F;
			this.YlyEdCalYear2Text.Width = 0.1881895F;
			// 
			// YlyEdCalYear1Text
			// 
			this.YlyEdCalYear1Text.CanGrow = false;
			this.YlyEdCalYear1Text.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYear1Text.Height = 0.1665357F;
			this.YlyEdCalYear1Text.Left = 0F;
			this.YlyEdCalYear1Text.Name = "YlyEdCalYear1Text";
			this.YlyEdCalYear1Text.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YlyEdCalYear1Text.Text = "66";
			this.YlyEdCalYear1Text.Top = 0.03070866F;
			this.YlyEdCalYear1Text.Width = 0.1881895F;
			// 
			// YlyEdCalYearText
			// 
			this.YlyEdCalYearText.CanGrow = false;
			this.YlyEdCalYearText.DataField = "YLY_ED_CAL_YEAR";
			this.YlyEdCalYearText.Height = 0.1665357F;
			this.YlyEdCalYearText.Left = 5.419685F;
			this.YlyEdCalYearText.Name = "YlyEdCalYearText";
			this.YlyEdCalYearText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.YlyEdCalYearText.Text = "66";
			this.YlyEdCalYearText.Top = 0.03031497F;
			this.YlyEdCalYearText.Visible = false;
			this.YlyEdCalYearText.Width = 0.1881895F;
			// 
			// YngDpndMyNumber1_Text
			// 
			this.YngDpndMyNumber1_Text.CanGrow = false;
			this.YngDpndMyNumber1_Text.DataField = "YNG_DPND_MY_NUMBER1";
			this.YngDpndMyNumber1_Text.Height = 0.07500042F;
			this.YngDpndMyNumber1_Text.Left = 2.945276F;
			this.YngDpndMyNumber1_Text.Name = "YngDpndMyNumber1_Text";
			this.YngDpndMyNumber1_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber1_Text.Text = "123456789012";
			this.YngDpndMyNumber1_Text.Top = 4.791733F;
			this.YngDpndMyNumber1_Text.Visible = false;
			this.YngDpndMyNumber1_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber4_Text
			// 
			this.YngDpndMyNumber4_Text.CanGrow = false;
			this.YngDpndMyNumber4_Text.DataField = "YNG_DPND_MY_NUMBER4";
			this.YngDpndMyNumber4_Text.Height = 0.07500042F;
			this.YngDpndMyNumber4_Text.Left = 2.955119F;
			this.YngDpndMyNumber4_Text.Name = "YngDpndMyNumber4_Text";
			this.YngDpndMyNumber4_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber4_Text.Text = "123456789012";
			this.YngDpndMyNumber4_Text.Top = 6.075078F;
			this.YngDpndMyNumber4_Text.Visible = false;
			this.YngDpndMyNumber4_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber3_Text
			// 
			this.YngDpndMyNumber3_Text.CanGrow = false;
			this.YngDpndMyNumber3_Text.DataField = "YNG_DPND_MY_NUMBER3";
			this.YngDpndMyNumber3_Text.Height = 0.07500042F;
			this.YngDpndMyNumber3_Text.Left = 2.955119F;
			this.YngDpndMyNumber3_Text.Name = "YngDpndMyNumber3_Text";
			this.YngDpndMyNumber3_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber3_Text.Text = "123456789012";
			this.YngDpndMyNumber3_Text.Top = 5.650079F;
			this.YngDpndMyNumber3_Text.Visible = false;
			this.YngDpndMyNumber3_Text.Width = 0.1826772F;
			// 
			// YngDpndMyNumber2_Text
			// 
			this.YngDpndMyNumber2_Text.CanGrow = false;
			this.YngDpndMyNumber2_Text.DataField = "YNG_DPND_MY_NUMBER2";
			this.YngDpndMyNumber2_Text.Height = 0.07500042F;
			this.YngDpndMyNumber2_Text.Left = 2.955119F;
			this.YngDpndMyNumber2_Text.Name = "YngDpndMyNumber2_Text";
			this.YngDpndMyNumber2_Text.Style = "font-size: 4pt; text-align: center; vertical-align: top; white-space: nowrap; ddo" +
    "-char-set: 1";
			this.YngDpndMyNumber2_Text.Text = "123456789012";
			this.YngDpndMyNumber2_Text.Top = 5.225078F;
			this.YngDpndMyNumber2_Text.Visible = false;
			this.YngDpndMyNumber2_Text.Width = 0.1826772F;
			// 
			// label198
			// 
			this.label198.Angle = 2700;
			this.label198.Height = 0.1830707F;
			this.label198.HyperLink = null;
			this.label198.Left = 0.01023622F;
			this.label198.Name = "label198";
			this.label198.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label198.Text = "（";
			this.label198.Top = 1.32441F;
			this.label198.Width = 0.1598426F;
			// 
			// label199
			// 
			this.label199.Height = 0.8570861F;
			this.label199.HyperLink = null;
			this.label199.Left = 0.01023622F;
			this.label199.Name = "label199";
			this.label199.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label199.Text = "個人別明細書";
			this.label199.Top = 1.467717F;
			this.label199.Width = 0.1598426F;
			// 
			// label200
			// 
			this.label200.Angle = 2700;
			this.label200.Height = 0.1897637F;
			this.label200.HyperLink = null;
			this.label200.Left = 0.01023574F;
			this.label200.Name = "label200";
			this.label200.Style = "font-size: 9pt; font-weight: normal; text-align: center; text-justify: auto; vert" +
    "ical-align: top; white-space: inherit; ddo-char-set: 1; ddo-font-vertical: none";
			this.label200.Text = "）";
			this.label200.Top = 2.269685F;
			this.label200.Width = 0.1598426F;
			// 
			// adjDedLabel1
			// 
			this.adjDedLabel1.Height = 0.15F;
			this.adjDedLabel1.HyperLink = null;
			this.adjDedLabel1.Left = 2.214173F;
			this.adjDedLabel1.Name = "adjDedLabel1";
			this.adjDedLabel1.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.adjDedLabel1.Text = "( 調 整 控 除 後 )";
			this.adjDedLabel1.Top = 1.098425F;
			this.adjDedLabel1.Width = 1.04F;
			// 
			// line24
			// 
			this.line24.Height = 0F;
			this.line24.Left = 3.4F;
			this.line24.LineWeight = 1F;
			this.line24.Name = "line24";
			this.line24.Top = 4.289764F;
			this.line24.Width = 1.979921F;
			this.line24.X1 = 3.4F;
			this.line24.X2 = 5.379921F;
			this.line24.Y1 = 4.289764F;
			this.line24.Y2 = 4.289764F;
			// 
			// baseDedAmtLabel1
			// 
			this.baseDedAmtLabel1.Height = 0.14F;
			this.baseDedAmtLabel1.HyperLink = null;
			this.baseDedAmtLabel1.Left = 3.429921F;
			this.baseDedAmtLabel1.Name = "baseDedAmtLabel1";
			this.baseDedAmtLabel1.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.baseDedAmtLabel1.Text = "基礎控除の額";
			this.baseDedAmtLabel1.Top = 4.358268F;
			this.baseDedAmtLabel1.Width = 0.45F;
			// 
			// baseDedAmtYen1
			// 
			this.baseDedAmtYen1.Height = 0.153F;
			this.baseDedAmtYen1.HyperLink = null;
			this.baseDedAmtYen1.Left = 4.25F;
			this.baseDedAmtYen1.Name = "baseDedAmtYen1";
			this.baseDedAmtYen1.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.baseDedAmtYen1.Text = "円";
			this.baseDedAmtYen1.Top = 4.269685F;
			this.baseDedAmtYen1.Width = 0.125F;
			// 
			// incmAdjDedAmt1Label1
			// 
			this.incmAdjDedAmt1Label1.Height = 0.14F;
			this.incmAdjDedAmt1Label1.HyperLink = null;
			this.incmAdjDedAmt1Label1.Left = 4.429921F;
			this.incmAdjDedAmt1Label1.Name = "incmAdjDedAmt1Label1";
			this.incmAdjDedAmt1Label1.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.incmAdjDedAmt1Label1.Text = "所得金額";
			this.incmAdjDedAmt1Label1.Top = 4.318504F;
			this.incmAdjDedAmt1Label1.Width = 0.45F;
			// 
			// incmAdjDedAmtYen1
			// 
			this.incmAdjDedAmtYen1.Height = 0.153F;
			this.incmAdjDedAmtYen1.HyperLink = null;
			this.incmAdjDedAmtYen1.Left = 5.229921F;
			this.incmAdjDedAmtYen1.Name = "incmAdjDedAmtYen1";
			this.incmAdjDedAmtYen1.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.incmAdjDedAmtYen1.Text = "円";
			this.incmAdjDedAmtYen1.Top = 4.269685F;
			this.incmAdjDedAmtYen1.Width = 0.125F;
			// 
			// incmAdjDedAmtText1
			// 
			this.incmAdjDedAmtText1.CanGrow = false;
			this.incmAdjDedAmtText1.DataField = "INCM_ADJ_DED_AMT";
			this.incmAdjDedAmtText1.Height = 0.153F;
			this.incmAdjDedAmtText1.Left = 4.920079F;
			this.incmAdjDedAmtText1.Name = "incmAdjDedAmtText1";
			this.incmAdjDedAmtText1.OutputFormat = "#,##0";
			this.incmAdjDedAmtText1.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmAdjDedAmtText1.Text = "ZZ,ZZZ,ZZ6";
			this.incmAdjDedAmtText1.Top = 4.368898F;
			this.incmAdjDedAmtText1.Width = 0.45F;
			// 
			// incmAdjDedAmt2Label1
			// 
			this.incmAdjDedAmt2Label1.Height = 0.14F;
			this.incmAdjDedAmt2Label1.HyperLink = null;
			this.incmAdjDedAmt2Label1.Left = 4.429921F;
			this.incmAdjDedAmt2Label1.Name = "incmAdjDedAmt2Label1";
			this.incmAdjDedAmt2Label1.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.incmAdjDedAmt2Label1.Text = "調整控除額";
			this.incmAdjDedAmt2Label1.Top = 4.40748F;
			this.incmAdjDedAmt2Label1.Width = 0.45F;
			// 
			// pesnlDed11_Line1
			// 
			this.pesnlDed11_Line1.Height = 0.6901569F;
			this.pesnlDed11_Line1.Left = 2.314961F;
			this.pesnlDed11_Line1.LineWeight = 1F;
			this.pesnlDed11_Line1.Name = "pesnlDed11_Line1";
			this.pesnlDed11_Line1.Top = 6.209843F;
			this.pesnlDed11_Line1.Visible = false;
			this.pesnlDed11_Line1.Width = 0.235039F;
			this.pesnlDed11_Line1.X1 = 2.55F;
			this.pesnlDed11_Line1.X2 = 2.314961F;
			this.pesnlDed11_Line1.Y1 = 6.209843F;
			this.pesnlDed11_Line1.Y2 = 6.9F;
			// 
			// birthNameOfEraText
			// 
			this.birthNameOfEraText.CanGrow = false;
			this.birthNameOfEraText.DataField = "BIRTH_NAME_OF_ERA_NAME";
			this.birthNameOfEraText.Height = 0.25F;
			this.birthNameOfEraText.Left = 3.724803F;
			this.birthNameOfEraText.Name = "birthNameOfEraText";
			this.birthNameOfEraText.Style = "font-size: 6pt; text-align: center; vertical-align: middle; white-space: nowrap; " +
    "ddo-char-set: 1";
			this.birthNameOfEraText.Text = "あい";
			this.birthNameOfEraText.Top = 6.650001F;
			this.birthNameOfEraText.Width = 0.9401577F;
			// 
			// line25
			// 
			this.line25.Height = 0F;
			this.line25.Left = 9.12874F;
			this.line25.LineWeight = 1F;
			this.line25.Name = "line25";
			this.line25.Top = 4.289764F;
			this.line25.Width = 1.980309F;
			this.line25.X1 = 9.12874F;
			this.line25.X2 = 11.10905F;
			this.line25.Y1 = 4.289764F;
			this.line25.Y2 = 4.289764F;
			// 
			// baseDedAmtLabel2
			// 
			this.baseDedAmtLabel2.Height = 0.14F;
			this.baseDedAmtLabel2.HyperLink = null;
			this.baseDedAmtLabel2.Left = 9.159451F;
			this.baseDedAmtLabel2.Name = "baseDedAmtLabel2";
			this.baseDedAmtLabel2.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.baseDedAmtLabel2.Text = "基礎控除の額";
			this.baseDedAmtLabel2.Top = 4.367717F;
			this.baseDedAmtLabel2.Width = 0.45F;
			// 
			// baseDedAmtYen2
			// 
			this.baseDedAmtYen2.Height = 0.153F;
			this.baseDedAmtYen2.HyperLink = null;
			this.baseDedAmtYen2.Left = 9.979131F;
			this.baseDedAmtYen2.Name = "baseDedAmtYen2";
			this.baseDedAmtYen2.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.baseDedAmtYen2.Text = "円";
			this.baseDedAmtYen2.Top = 4.279134F;
			this.baseDedAmtYen2.Width = 0.125F;
			// 
			// incmAdjDedAmt1Label2
			// 
			this.incmAdjDedAmt1Label2.Height = 0.14F;
			this.incmAdjDedAmt1Label2.HyperLink = null;
			this.incmAdjDedAmt1Label2.Left = 10.15946F;
			this.incmAdjDedAmt1Label2.Name = "incmAdjDedAmt1Label2";
			this.incmAdjDedAmt1Label2.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.incmAdjDedAmt1Label2.Text = "所得金額";
			this.incmAdjDedAmt1Label2.Top = 4.327953F;
			this.incmAdjDedAmt1Label2.Width = 0.45F;
			// 
			// incmAdjDedAmt2Label2
			// 
			this.incmAdjDedAmt2Label2.Height = 0.14F;
			this.incmAdjDedAmt2Label2.HyperLink = null;
			this.incmAdjDedAmt2Label2.Left = 10.15946F;
			this.incmAdjDedAmt2Label2.Name = "incmAdjDedAmt2Label2";
			this.incmAdjDedAmt2Label2.Style = "font-size: 5pt; text-align: center; vertical-align: top; white-space: inherit; dd" +
    "o-char-set: 1";
			this.incmAdjDedAmt2Label2.Text = "調整控除額";
			this.incmAdjDedAmt2Label2.Top = 4.416929F;
			this.incmAdjDedAmt2Label2.Width = 0.45F;
			// 
			// incmAdjDedAmtText2
			// 
			this.incmAdjDedAmtText2.CanGrow = false;
			this.incmAdjDedAmtText2.DataField = "INCM_ADJ_DED_AMT";
			this.incmAdjDedAmtText2.Height = 0.153F;
			this.incmAdjDedAmtText2.Left = 10.64921F;
			this.incmAdjDedAmtText2.Name = "incmAdjDedAmtText2";
			this.incmAdjDedAmtText2.OutputFormat = "#,##0";
			this.incmAdjDedAmtText2.Style = "font-size: 6pt; text-align: right; vertical-align: middle; white-space: nowrap; d" +
    "do-char-set: 1";
			this.incmAdjDedAmtText2.Text = "ZZ,ZZZ,ZZ6";
			this.incmAdjDedAmtText2.Top = 4.378347F;
			this.incmAdjDedAmtText2.Width = 0.45F;
			// 
			// incmAdjDedAmtYen2
			// 
			this.incmAdjDedAmtYen2.Height = 0.153F;
			this.incmAdjDedAmtYen2.HyperLink = null;
			this.incmAdjDedAmtYen2.Left = 10.95921F;
			this.incmAdjDedAmtYen2.Name = "incmAdjDedAmtYen2";
			this.incmAdjDedAmtYen2.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.incmAdjDedAmtYen2.Text = "円";
			this.incmAdjDedAmtYen2.Top = 4.279134F;
			this.incmAdjDedAmtYen2.Width = 0.125F;
			// 
			// pesnlDed11_Line2
			// 
			this.pesnlDed11_Line2.Height = 0.6897631F;
			this.pesnlDed11_Line2.Left = 8.044094F;
			this.pesnlDed11_Line2.LineWeight = 1F;
			this.pesnlDed11_Line2.Name = "pesnlDed11_Line2";
			this.pesnlDed11_Line2.Top = 6.209843F;
			this.pesnlDed11_Line2.Visible = false;
			this.pesnlDed11_Line2.Width = 0.2346458F;
			this.pesnlDed11_Line2.X1 = 8.27874F;
			this.pesnlDed11_Line2.X2 = 8.044094F;
			this.pesnlDed11_Line2.Y1 = 6.209843F;
			this.pesnlDed11_Line2.Y2 = 6.899606F;
			// 
			// adjDedLabel2
			// 
			this.adjDedLabel2.Height = 0.15F;
			this.adjDedLabel2.HyperLink = null;
			this.adjDedLabel2.Left = 7.942913F;
			this.adjDedLabel2.Name = "adjDedLabel2";
			this.adjDedLabel2.Style = "font-size: 5pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
			this.adjDedLabel2.Text = "( 調 整 控 除 後 )";
			this.adjDedLabel2.Top = 1.098425F;
			this.adjDedLabel2.Width = 1.04F;
			// 
			// HR_PY_03_R63
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.1F;
			this.PageSettings.Margins.Left = 0.2F;
			this.PageSettings.Margins.Right = 0.2F;
			this.PageSettings.Margins.Top = 0.2F;
			this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.267716F;
			this.PrintWidth = 11.23958F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.HR_PY_03_R62_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.label343)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label345)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label336)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label993)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label309)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label310)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label308)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label242)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label239)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label235)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label233)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemaksText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndRemarksText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label323)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label330)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label206)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber1_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label329)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label205)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label73)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label193)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label194)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label192)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label99)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1063)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1055)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label994)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCodeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameKanaText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label996)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label997)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label998)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label999)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1000)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1001)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1002)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.classText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1003)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1004)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slryInsmDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1005)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmDedAmtSumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1006)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1007)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyCollectTaxText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1008)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1009)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1010)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1011)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1012)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1014)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposOldAgeTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExistText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dedSposExist2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1016)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sposExtDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1018)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1019)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1020)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1021)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1022)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1023)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specDpndNum2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1024)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1025)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtAgePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1026)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agePreNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1027)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1028)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1029)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.othersDpndNum2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1030)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1031)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liveTgtExtHandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHndiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1032)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1033)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1034)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1035)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1036)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HandiNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1037)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smlScaleCompCpratAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1039)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox454)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sponSumIncmAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsLongProdAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1051)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1052)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1053)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1054)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1065)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1067)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1069)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1070)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1071)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1072)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1073)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1074)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1075)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1076)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minrTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.latterText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extHandiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handiTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.extWidowTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widomTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wrkStdTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1077)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1078)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1079)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntAddressText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntNameText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1080)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymntPhoneText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1081)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1082)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1084)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1085)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1086)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1087)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1088)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1089)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1093)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nolfInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.disasterTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1116)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmployTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1117)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfRetireTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReFateMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.halfEmReDateDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1121)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayMonthText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthDayDayText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.socInsDedAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label1595)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary0Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsPensAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsCareAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newLifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeInsGeneralAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summary1Digit0Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YoungDpndNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label55)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label56)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label57)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label69)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label82)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label83)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label84)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label85)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label86)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label87)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label88)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label89)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label90)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label91)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label92)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label93)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label94)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label95)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label96)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label97)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label98)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label100)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label101)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label102)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label103)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label104)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label105)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label106)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label107)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label108)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label109)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label110)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label111)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label112)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label113)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label114)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label115)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label116)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label117)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label118)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label119)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label120)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label121)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label122)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label171)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label176)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label183)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label184)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label185)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label186)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label187)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label188)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label189)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label190)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NonResidentNumText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label191)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ylyEdAddress1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label123)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label124)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label125)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label126)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label127)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label128)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label129)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label130)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label132)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label133)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label134)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label135)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label136)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label138)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label139)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label140)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label141)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label142)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label143)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label144)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox30)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox32)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label145)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label146)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label147)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label148)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label150)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label151)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label153)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label154)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label155)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label156)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label157)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label158)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label159)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox33)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label160)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox34)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox35)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox36)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox38)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox39)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox40)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label161)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label162)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label163)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox42)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox43)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label164)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox44)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label165)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label166)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label167)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label168)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label169)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label170)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label172)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label173)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label174)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox45)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox46)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox47)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label175)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox48)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label177)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox49)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label178)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox50)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox52)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox53)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label182)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label196)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox54)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox58)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox59)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox60)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label197)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label201)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox63)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label202)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox64)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox65)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label203)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label204)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox66)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox67)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox68)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber2_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label207)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label208)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label209)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox74)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label210)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label211)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label212)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label213)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label214)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label215)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label216)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label217)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label218)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label219)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label220)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label221)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label222)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label223)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label224)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label225)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label226)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label227)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label228)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label229)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label230)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label231)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label232)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label234)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label236)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label237)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label238)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label240)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label241)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label243)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label244)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label245)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label246)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label247)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label248)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label249)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label250)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label251)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label252)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label253)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label254)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label255)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label256)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label257)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label258)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label259)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label260)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label261)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label262)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label263)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label264)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label265)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label266)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label267)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label268)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label269)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label270)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label271)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label272)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label273)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label274)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label275)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label276)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label277)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label278)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label279)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label280)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label281)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label282)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label283)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label284)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label285)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label286)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label287)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label288)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label289)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label290)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label291)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label292)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label293)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label294)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label295)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label296)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label297)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label298)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label299)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label300)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label301)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label302)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label303)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label304)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label305)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label306)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox75)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label307)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label311)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label37)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label312)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label313)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label314)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CorpNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label316)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedPsblAmtText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label317)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateYText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2YText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateMText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2MText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateDText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2DText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateY2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2Y2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2M2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateM2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDateD2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingMovingDate2D2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedTypeText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecDedType2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalanceText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EyLoanBalance2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox62)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NationalPensPremText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox69)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.textBox70)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox71)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox72)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox76)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox77)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox78)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox79)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox80)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox81)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox82)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox83)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox84)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox85)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox86)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox87)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox88)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox89)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox90)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox91)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox92)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox93)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox94)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox95)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox96)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox97)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox98)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox99)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_3_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_4_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HousingObtDedCntText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox100)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label195)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label318)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label319)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label320)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label321)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label322)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.label324)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label325)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label326)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label327)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_3_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label328)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_4_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox137)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label315)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndRemarksText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label331)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label332)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_1_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label333)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_2_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label334)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_3_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label335)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_4_3Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label337)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label338)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label339)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label340)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label341)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label342)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label344)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label348)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label350)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label351)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label352)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label353)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SposMyNumber_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DpndMyNumber4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MyNumber_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear2Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYear1Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YlyEdCalYearText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber1_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber4_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber3_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YngDpndMyNumber2_Text)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label198)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label199)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label200)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adjDedLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtYen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt1Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtYen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt2Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.birthNameOfEraText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseDedAmtYen2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt1Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmt2Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incmAdjDedAmtYen2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adjDedLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		 }

		#endregion
	}
}
