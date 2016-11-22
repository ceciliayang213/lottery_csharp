using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newLottery
{
    public partial class Form1 : Form
    {
        //timer
        int s = 10;
        int showNum = 0;
        int[] showNumArray = new int[30];
        int ramNum = 0;
        int[] ramArray = new int[40];
        //539
        //general
        int length = 5;
        Random ram = new Random();
        string totalResult = "";
        int count = 0;
        //for manual select
        bool bo1, bo2, bo3, bo4, bo5, bo6, bo7, bo8, bo9, bo10, bo11, bo12,
            bo13, bo14, bo15, bo16, bo17, bo18, bo19, bo20, bo21, bo22, bo23,
            bo24, bo25, bo26, bo27, bo28, bo29, bo30, bo31, bo32, bo33,
            bo34, bo35, bo36, bo37, bo38, bo39;
        int manual = 0;
        //string manualResult = "", randomResult = "",lotteryResult = "";
        List<int> manualSelect = new List<int>();
        //for random select
        int random = 0;
        int[] randomSelect = new int[5];
        //for result
        int lottery = 0;
        string beforeSort = "";
        string afterSort = "";
        int[] lotteryNum = new int[5];
        int[] tempLottery = new int[5];
        //*****************************************
        //WeeLee
        //general
        int wlength = 6;
        // Random wram = new Random();
        string wResult = "";
        int wCount = 0;
        //for manual select
        bool wbo1, wbo2, wbo3, wbo4, wbo5, wbo6, wbo7, wbo8, wbo9, wbo10, wbo11, wbo12,
            wbo13, wbo14, wbo15, wbo16, wbo17, wbo18, wbo19, wbo20, wbo21, wbo22, wbo23,
            wbo24, wbo25, wbo26, wbo27, wbo28, wbo29, wbo30, wbo31, wbo32, wbo33,
            wbo34, wbo35, wbo36, wbo37, wbo38;
        bool zoneB1, zoneB2, zoneB3, zoneB4, zoneB5, zoneB6, zoneB7, zoneB8;
        int wManual = 0;
        int wManualZoneB = 0;
        string wManualResult = "";
        List<int> wManualSelect = new List<int>();
        //for random select
        int wRandom = 0;
        int wZoneB = 0;
        string wRandomResult = "";
        int[] wRandomSelect = new int[6];
        //for result
        int wLottery = 0;
        int wLotteryZoneB = 0;
        int[] wLotteryNum = new int[6];
        int[] wTempLottery = new int[6];
        bool matchZoneB = false;
        int match = 0;
        //***********Bingo Bingo***********
        //general
        int blength = 20;
        string bResult = "";
        int bCount = 0;
        //for manual select
        bool bbo1, bbo2, bbo3, bbo4, bbo5, bbo6, bbo7, bbo8, bbo9, bbo10, bbo11, bbo12,
            bbo13, bbo14, bbo15, bbo16, bbo17, bbo18, bbo19, bbo20, bbo21, bbo22, bbo23,
            bbo24, bbo25, bbo26, bbo27, bbo28, bbo29, bbo30, bbo31, bbo32, bbo33,
            bbo34, bbo35, bbo36, bbo37, bbo38, bbo39, bbo40, bbo41, bbo42, bbo43,
            bbo44, bbo45, bbo46, bbo47, bbo48, bbo49, bbo50, bbo51, bbo52, bbo53,
            bbo54, bbo55, bbo56, bbo57, bbo58, bbo59, bbo60, bbo61, bbo62, bbo63,
            bbo64, bbo65, bbo66, bbo67, bbo68, bbo69, bbo70, bbo71, bbo72, bbo73,
            bbo74, bbo75, bbo76, bbo77, bbo78, bbo79, bbo80;

        private void chkB16_CheckedChanged(object sender, EventArgs e)
        {
            bbo16 = chkB16.Checked;
        }

        private void chkB17_CheckedChanged(object sender, EventArgs e)
        {
            bbo17 = chkB17.Checked;
        }

        private void chkB18_CheckedChanged(object sender, EventArgs e)
        {
            bbo18 = chkB18.Checked;
        }

        private void chkB19_CheckedChanged(object sender, EventArgs e)
        {
            bbo19 = chkB19.Checked;
        }

        private void chkB20_CheckedChanged(object sender, EventArgs e)
        {
            bbo20 = chkB20.Checked;
        }

        private void chkB21_CheckedChanged(object sender, EventArgs e)
        {
            bbo21 = chkB21.Checked;
        }

        private void chkB22_CheckedChanged(object sender, EventArgs e)
        {
            bbo22 = chkB22.Checked;
        }

        private void chkB23_CheckedChanged(object sender, EventArgs e)
        {
            bbo23 = chkB23.Checked;
        }

        private void chkB24_CheckedChanged(object sender, EventArgs e)
        {
            bbo24 = chkB24.Checked;
        }

        private void chkB25_CheckedChanged(object sender, EventArgs e)
        {
            bbo25 = chkB25.Checked;
        }

        private void chkB26_CheckedChanged(object sender, EventArgs e)
        {
            bbo26 = chkB26.Checked;
        }

        private void chkB27_CheckedChanged(object sender, EventArgs e)
        {
            bbo26 = chkB27.Checked;
        }

        private void chkB28_CheckedChanged(object sender, EventArgs e)
        {
            bbo28 = chkB28.Checked;
        }

        private void chkB29_CheckedChanged(object sender, EventArgs e)
        {
            bbo29 = chkB29.Checked;
        }

        private void chkB30_CheckedChanged(object sender, EventArgs e)
        {
            bbo30 = chkB30.Checked;
        }

        private void chkB31_CheckedChanged(object sender, EventArgs e)
        {
            bbo31 = chkB31.Checked;
        }

        private void chkB32_CheckedChanged(object sender, EventArgs e)
        {
            bbo32 = chkB32.Checked;
        }

        private void chkB33_CheckedChanged(object sender, EventArgs e)
        {
            bbo33 = chkB33.Checked;
        }

        private void chkB34_CheckedChanged(object sender, EventArgs e)
        {
            bbo34 = chkB34.Checked;
        }

        private void chkB35_CheckedChanged(object sender, EventArgs e)
        {
            bbo35 = chkB35.Checked;
        }

        private void chkB36_CheckedChanged(object sender, EventArgs e)
        {
            bbo36 = chkB36.Checked;
        }

        private void chkB37_CheckedChanged(object sender, EventArgs e)
        {
            bbo37 = chkB37.Checked;
        }

        private void chkB38_CheckedChanged(object sender, EventArgs e)
        {
            bbo38 = chkB38.Checked;
        }

        private void chkB39_CheckedChanged(object sender, EventArgs e)
        {
            bbo39 = chkB39.Checked;
        }

        private void chkB40_CheckedChanged(object sender, EventArgs e)
        {
            bbo40 = chkB40.Checked;
        }

        private void chkB41_CheckedChanged(object sender, EventArgs e)
        {
            bbo41 = chkB41.Checked;
        }

        private void chkB42_CheckedChanged(object sender, EventArgs e)
        {
            bbo42 = chkB42.Checked;
        }

        private void chkB43_CheckedChanged(object sender, EventArgs e)
        {
            bbo43 = chkB43.Checked;
        }

        private void chkB44_CheckedChanged(object sender, EventArgs e)
        {
            bbo44 = chkB44.Checked;
        }

        private void chkB45_CheckedChanged(object sender, EventArgs e)
        {
            bbo45 = chkB45.Checked;
        }

        private void chkB46_CheckedChanged(object sender, EventArgs e)
        {
            bbo46 = chkB46.Checked;
        }

        private void chkB47_CheckedChanged(object sender, EventArgs e)
        {
            bbo47 = chkB47.Checked;
        }

        private void chkB48_CheckedChanged(object sender, EventArgs e)
        {
            bbo48 = chkB48.Checked;
        }

        private void chkB49_CheckedChanged(object sender, EventArgs e)
        {
            bbo49 = chkB49.Checked;
        }

        private void chkB50_CheckedChanged(object sender, EventArgs e)
        {
            bbo50 = chkB50.Checked;
        }

        private void chkB51_CheckedChanged(object sender, EventArgs e)
        {
            bbo51 = chkB51.Checked;
        }

        private void chkB52_CheckedChanged(object sender, EventArgs e)
        {
            bbo52 = chkB52.Checked;
        }

        private void chkB53_CheckedChanged(object sender, EventArgs e)
        {
            bbo53 = chkB53.Checked;
        }

        private void chkB54_CheckedChanged(object sender, EventArgs e)
        {
            bbo54 = chkB54.Checked;
        }

        private void chkB55_CheckedChanged(object sender, EventArgs e)
        {
            bbo55 = chkB55.Checked;
        }

        private void chkB56_CheckedChanged(object sender, EventArgs e)
        {
            bbo56 = chkB56.Checked;
        }

        private void chkB57_CheckedChanged(object sender, EventArgs e)
        {
            bbo57 = chkB57.Checked;
        }

        private void chkB58_CheckedChanged(object sender, EventArgs e)
        {
            bbo58 = chkB58.Checked;
        }

        private void chkB59_CheckedChanged(object sender, EventArgs e)
        {
            bbo59 = chkB59.Checked;
        }

        private void chkB60_CheckedChanged(object sender, EventArgs e)
        {
            bbo60 = chkB60.Checked;
        }

        private void chkB61_CheckedChanged(object sender, EventArgs e)
        {
            bbo61 = chkB61.Checked;
        }

        private void chkB62_CheckedChanged(object sender, EventArgs e)
        {
            bbo62 = chkB62.Checked;
        }

        private void chkB63_CheckedChanged(object sender, EventArgs e)
        {
            bbo63 = chkB63.Checked;
        }

        private void chkB64_CheckedChanged(object sender, EventArgs e)
        {
            bbo64 = chkB64.Checked;
        }

        private void chkB65_CheckedChanged(object sender, EventArgs e)
        {
            bbo65 = chkB65.Checked;
        }

        private void chkB66_CheckedChanged(object sender, EventArgs e)
        {
            bbo66 = chkB66.Checked;
        }

        private void chkB67_CheckedChanged(object sender, EventArgs e)
        {
            bbo67 = chkB67.Checked;
        }

        private void chkB68_CheckedChanged(object sender, EventArgs e)
        {
            bbo68 = chkB68.Checked;
        }

        private void chkB69_CheckedChanged(object sender, EventArgs e)
        {
            bbo69 = chkB69.Checked;
        }

        private void chkB70_CheckedChanged(object sender, EventArgs e)
        {
            bbo70 = chkB70.Checked;
        }

        private void chkB71_CheckedChanged(object sender, EventArgs e)
        {
            bbo71 = chkB71.Checked;
        }

        private void chkB72_CheckedChanged(object sender, EventArgs e)
        {
            bbo72 = chkB72.Checked;
        }

        private void chkB73_CheckedChanged(object sender, EventArgs e)
        {
            bbo73 = chkB73.Checked;
        }

        private void chkB74_CheckedChanged(object sender, EventArgs e)
        {
            bbo74 = chkB74.Checked;
        }

        private void chkB75_CheckedChanged(object sender, EventArgs e)
        {
            bbo75 = chkB75.Checked;
        }

        private void chkB76_CheckedChanged(object sender, EventArgs e)
        {
            bbo76 = chkB76.Checked;
        }

        private void chkB77_CheckedChanged(object sender, EventArgs e)
        {
            bbo77 = chkB77.Checked;
        }

        private void chkB78_CheckedChanged(object sender, EventArgs e)
        {
            bbo78 = chkB78.Checked;
        }

        private void chkB79_CheckedChanged(object sender, EventArgs e)
        {
            bbo79 = chkB79.Checked;
        }

        private void chkB80_CheckedChanged(object sender, EventArgs e)
        {
            bbo80 = chkB80.Checked;
        }

        private void rbtRandom_CheckedChanged(object sender, EventArgs e)
        {
            selectRandom = rbtRandom.Checked;
        }

        private void rbtBig_CheckedChanged(object sender, EventArgs e)
        {
            selectBig = rbtBig.Checked;
        }

        private void rbtSmall_CheckedChanged(object sender, EventArgs e)
        {
            selectSmall = rbtSmall.Checked;
        }

        private void chkSuper_CheckedChanged(object sender, EventArgs e)
        {
            boSuper = chkSuper.Checked;
        }

        private void btnBingoRandom_Click(object sender, EventArgs e)
        {
            if (countStar() < 1)
            {
                MessageBox.Show("請先選擇星數");
            }
            else
            {
                for (int i = 0; i < countStar(); i++)
                {
                    do
                    {
                        bRandom = ram.Next(1, 81);
                    } while (bRandomSelect.Contains(bRandom));
                    bRandomSelect[i] = bRandom;
                    luckyString += String.Format("{0,2}  ", bRandom);
                }
            }
            //timer4.Start();
            lblBingoResult.Text = luckyString;

        }

        private void btnBingoManual_Click(object sender, EventArgs e)
        {
            countStar();
            if (countStar() < 1)
            {
                MessageBox.Show("請先選擇星數");
            }

            string msg = "";
            int bingoCheckCount = 0;
            bool[] boBingoManual = new bool[80] {bbo1, bbo2, bbo3, bbo4, bbo5, bbo6, bbo7, bbo8, bbo9, bbo10, bbo11, bbo12,
            bbo13, bbo14, bbo15, bbo16, bbo17, bbo18, bbo19, bbo20, bbo21, bbo22, bbo23,
            bbo24, bbo25, bbo26, bbo27, bbo28, bbo29, bbo30, bbo31, bbo32, bbo33,
            bbo34, bbo35, bbo36, bbo37, bbo38, bbo39, bbo40, bbo41, bbo42, bbo43,
            bbo44, bbo45, bbo46, bbo47, bbo48, bbo49, bbo50, bbo51, bbo52, bbo53,
            bbo54, bbo55, bbo56, bbo57, bbo58, bbo59, bbo60, bbo61, bbo62, bbo63,
            bbo64, bbo65, bbo66, bbo67, bbo68, bbo69, bbo70, bbo71, bbo72, bbo73,
            bbo74, bbo75, bbo76, bbo77, bbo78, bbo79, bbo80};
            bool boDoRandom = true;
            foreach (bool bo in boBingoManual)
            {
                if (bo == true)
                {
                    bingoCheckCount++;
                }
            }
            if (bingoCheckCount <= countStar())
            {
                for (int i = 0; i < 80; i++)
                {
                    if (boBingoManual[i] == true)
                    {
                        bManual = i + 1;
                        bManualSelect.Add(bManual);
                    }
                }
            }
            else
            {
                msg = String.Format("最多只能選{0}個號碼, 請清除號碼重選", countStar());
                MessageBox.Show(msg);
                boDoRandom = false;
            }

            if (boDoRandom == true)
            {
                int len = countStar() - bManualSelect.Count;
                for (int i = 0; i < len; i++)
                {
                    do
                    {
                        bManual = ram.Next(1, 81);
                    } while (bManualSelect.Contains(bManual));
                    bManualSelect.Add(bManual);
                }
            }
            foreach (int number in bManualSelect)
            {
                luckyString += String.Format("{0,2}  ", number);
            }

            lblBingoResult.Text = luckyString;
            stars = 0;
        }

        private void btnBingoClear_Click(object sender, EventArgs e)
        {
            if (bManualSelect.Count > 0)
            {
                bManualSelect.RemoveRange(0, countStar());
                Array.Clear(bLotteryNum, 0, bLotteryNum.Length);
            }
            else if (bRandomSelect[0] != 0)
            {
                bRandomSelect.Initialize();
                Array.Clear(bLotteryNum, 0, bLotteryNum.Length);
            }

            rbt1.Checked = false;
            rbt2.Checked = false;
            rbt3.Checked = false;
            rbt4.Checked = false;
            rbt5.Checked = false;
            rbt6.Checked = false;
            rbt7.Checked = false;
            rbt8.Checked = false;
            rbt9.Checked = false;
            rbt10.Checked = false;
            rbtRandom.Checked = false;
            rbtBig.Checked = false;
            rbtSmall.Checked = false;
            chkSuper.CheckState = CheckState.Unchecked;
            chkB1.CheckState = CheckState.Unchecked;
            chkB2.CheckState = CheckState.Unchecked;
            chkB3.CheckState = CheckState.Unchecked;
            chkB4.CheckState = CheckState.Unchecked;
            chkB5.CheckState = CheckState.Unchecked;
            chkB6.CheckState = CheckState.Unchecked;
            chkB7.CheckState = CheckState.Unchecked;
            chkB8.CheckState = CheckState.Unchecked;
            chkB9.CheckState = CheckState.Unchecked;
            chkB10.CheckState = CheckState.Unchecked;
            chkB11.CheckState = CheckState.Unchecked;
            chkB12.CheckState = CheckState.Unchecked;
            chkB13.CheckState = CheckState.Unchecked;
            chkB14.CheckState = CheckState.Unchecked;
            chkB15.CheckState = CheckState.Unchecked;
            chkB16.CheckState = CheckState.Unchecked;
            chkB17.CheckState = CheckState.Unchecked;
            chkB18.CheckState = CheckState.Unchecked;
            chkB19.CheckState = CheckState.Unchecked;
            chkB20.CheckState = CheckState.Unchecked;
            chkB21.CheckState = CheckState.Unchecked;
            chkB22.CheckState = CheckState.Unchecked;
            chkB23.CheckState = CheckState.Unchecked;
            chkB24.CheckState = CheckState.Unchecked;
            chkB25.CheckState = CheckState.Unchecked;
            chkB26.CheckState = CheckState.Unchecked;
            chkB27.CheckState = CheckState.Unchecked;
            chkB28.CheckState = CheckState.Unchecked;
            chkB29.CheckState = CheckState.Unchecked;
            chkB30.CheckState = CheckState.Unchecked;
            chkB31.CheckState = CheckState.Unchecked;
            chkB32.CheckState = CheckState.Unchecked;
            chkB33.CheckState = CheckState.Unchecked;
            chkB34.CheckState = CheckState.Unchecked;
            chkB35.CheckState = CheckState.Unchecked;
            chkB36.CheckState = CheckState.Unchecked;
            chkB37.CheckState = CheckState.Unchecked;
            chkB38.CheckState = CheckState.Unchecked;
            chkB39.CheckState = CheckState.Unchecked;
            chkB40.CheckState = CheckState.Unchecked;
            chkB41.CheckState = CheckState.Unchecked;
            chkB42.CheckState = CheckState.Unchecked;
            chkB43.CheckState = CheckState.Unchecked;
            chkB44.CheckState = CheckState.Unchecked;
            chkB45.CheckState = CheckState.Unchecked;
            chkB46.CheckState = CheckState.Unchecked;
            chkB47.CheckState = CheckState.Unchecked;
            chkB48.CheckState = CheckState.Unchecked;
            chkB49.CheckState = CheckState.Unchecked;
            chkB50.CheckState = CheckState.Unchecked;
            chkB51.CheckState = CheckState.Unchecked;
            chkB52.CheckState = CheckState.Unchecked;
            chkB53.CheckState = CheckState.Unchecked;
            chkB54.CheckState = CheckState.Unchecked;
            chkB55.CheckState = CheckState.Unchecked;
            chkB56.CheckState = CheckState.Unchecked;
            chkB57.CheckState = CheckState.Unchecked;
            chkB58.CheckState = CheckState.Unchecked;
            chkB59.CheckState = CheckState.Unchecked;
            chkB60.CheckState = CheckState.Unchecked;
            chkB61.CheckState = CheckState.Unchecked;
            chkB62.CheckState = CheckState.Unchecked;
            chkB63.CheckState = CheckState.Unchecked;
            chkB64.CheckState = CheckState.Unchecked;
            chkB65.CheckState = CheckState.Unchecked;
            chkB66.CheckState = CheckState.Unchecked;
            chkB67.CheckState = CheckState.Unchecked;
            chkB68.CheckState = CheckState.Unchecked;
            chkB69.CheckState = CheckState.Unchecked;
            chkB70.CheckState = CheckState.Unchecked;
            chkB71.CheckState = CheckState.Unchecked;
            chkB72.CheckState = CheckState.Unchecked;
            chkB73.CheckState = CheckState.Unchecked;
            chkB74.CheckState = CheckState.Unchecked;
            chkB75.CheckState = CheckState.Unchecked;
            chkB76.CheckState = CheckState.Unchecked;
            chkB77.CheckState = CheckState.Unchecked;
            chkB78.CheckState = CheckState.Unchecked;
            chkB79.CheckState = CheckState.Unchecked;
            chkB80.CheckState = CheckState.Unchecked;
            luckyString = "";
            lblBingoResult.Text = "";
            stringBefore = "";
            stringAfter = "";
            lblBefore.Text = "";
            lblAfter.Text = "";
            bigSmallString = "";
            lblFinalResult.Text = "";
            lblBigSmall.Text = "";
            tbSuperBefore.Text = "";
            tbSuperAfter.Text = "";
            stars = 0;
            countBig = 0;
            countSmall = 0;
            boBig = false;
            boSmall = false;
            resultBig = false;
            resultSmall = false;
            countBingoMatch = 0;
            countBingoManualMatch = 0;
            boSuper = false;
            boSuperRandom = false;
            boSuperManual = false;
            manualMatchSuper = false;
            randomMatchSuper = false;
        }

        private void btnBingoDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    bLottery = ram.Next(1, 81);
                } while (bLotteryNum.Contains(bLottery));
                bLotteryNum[i] = bLottery;
                stringBefore += String.Format("{0,2}  ", bLottery);
            }
            lblBefore.Text = stringBefore;
            superNum = bLotteryNum[19];
            Array.Copy(bLotteryNum, bTempLottery, blength);
            Array.Sort(bTempLottery);
            foreach (int number in bTempLottery)
            {
                stringAfter += String.Format("{0, 2}  ", number);
            }
           

            tbSuperBefore.Text = Convert.ToString(superNum);
            tbSuperAfter.Text = Convert.ToString(superNum);
            lblAfter.Text = stringAfter;
        }
        private int countStar()
        {
            bool[] boStarArray = new bool[10] { star1, star2, star3, star4, star5,
                star6, star7, star8, star9, star10 };
            for (int i = 0; i < 10; i++)
            {
                if (boStarArray[i] == true)
                {
                    stars = i + 1;
                }
            }
            return stars;
        }
        
        private void bigSmall()
        {
            string msg = "";
            //get user input, big or small or random
            if (countStar() > 0)
            {
                if (selectRandom == true)
                {
                    randomBigSmall = ram.Next(1, 3);//set 1 to small, 2 to big;
                    if (randomBigSmall == 2)
                    {
                        boBig = true;//randomly select big
                    }
                    else
                    {
                        boSmall = true;//randomly select small
                    }
                }
                else if (selectBig == true)//user select big
                {
                    boBig = true;
                }
                else if (selectSmall == true)//user select small
                {
                    boSmall = true;
                }
                else
                {
                    bigSmallString = "--";
                    lblBigSmall.Text = bigSmallString;
                }
                foreach (int number in bLotteryNum)
                {
                    if (number >= 41)
                    {
                        countBig++;
                    }
                    else
                    {
                        countSmall++;
                    }
                }
                if (countBig >= 13)
                {
                    resultBig = true;
                }
                else if (countSmall >= 13)
                {
                    resultSmall = true;
                }
                if (resultBig == true)
                {
                    if (boBig == true)
                    {
                        bigSmallString = "您猜大, 開獎結果也是大, 恭喜猜中!!!";
                    }
                    else
                    {
                        bigSmallString = "您猜小, 可惜開獎結果是大...";
                    }
                }
                else if (resultSmall == true)
                {
                    if (boSmall == true)
                    {
                        bigSmallString = "您猜小, 開獎結果也是小, 恭喜猜中!!!";
                    }
                    else
                    {
                        bigSmallString = "您猜大, 可惜開獎結果是小...";
                    }
                }
                else
                {
                    bigSmallString = "開獎結果非大亦非小";
                }

                lblBigSmall.Text = bigSmallString;
            }
            else
            {
                msg = "猜大小需搭配基本玩法, 請先選擇基本玩法星數";
                MessageBox.Show(msg);
            }
        }

        private void btnBingoPrize_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (selectRandom == true || selectBig == true || selectSmall == true)
            {
                bigSmall();
            }
            matchBingo();
            //lblFinalResult.Text = Convert.ToString(countBingoMatch) + "\nRandom Match: "+ randomMatchSuper + "\nManual Match: " + manualMatchSuper;
            //lblBigSmall.Text = "RandomMatchSuper: " + randomMatchSuper + "\n" + "MAnualMatchSuper: " + manualMatchSuper;
            countBingoMatch = 0;
            countBingoManualMatch = 0;
            randomMatchSuper = false;
            manualMatchSuper = false;

        }
        public void matchBingo()//作為一般兌獎用已完成
        {
            //測試超級獎號
            string msg = "";

            if (boSuper == true)//if user checks chkSuper
            {
                //又分為快選跟人工選, 兩者之內又分為兌到超級號跟沒兌到
                if (bRandomSelect[0] != 0)//如果快選
                {
                    for (int i = 0; i < countStar(); i++)
                    {
                        if (bRandomSelect[i] == bLotteryNum[19])
                        {
                            randomMatchSuper = true;//快選有兌到超級獎號
                            break;
                        }
                    }
                    foreach (int num in bRandomSelect)
                    {
                        if (Array.IndexOf(bLotteryNum, num) >= 0)
                        {
                            countBingoMatch++;
                        }
                    }
                    if (randomMatchSuper == true)//有兌到超級獎號
                    {
                        switch (countBingoMatch)
                        {
                            case 1:
                                msg = "恭喜兌中超級一星(0+1)";
                                break;
                            case 2:
                                msg = "恭喜兌中超級二星(1+1)";
                                break;
                            case 3:
                                msg = "恭喜兌中超級三星(2+1)";
                                break;
                            case 4:
                                msg = "恭喜兌中超級四星(3+1)";
                                break;
                            case 5:
                                msg = "恭喜兌中超級五星(4+1)";
                                break;
                            case 6:
                                msg = "恭喜兌中超級六星(5+1)";
                                break;
                            case 7:
                                msg = "恭喜兌中超級七星(6+1)";
                                break;
                            case 8:
                                msg = "恭喜兌中超級八星(7+1)";
                                break;
                            case 9:
                                msg = "恭喜兌中超級九星(8+1)";
                                break;
                            case 10:
                                msg = "恭喜兌中超級十星(9+1)";
                                break;
                        }
                    }
                    else//沒兌到超級獎號
                    {
                        if (countBingoMatch > 0)
                        {
                            switch (countBingoMatch)
                            {
                                case 1:
                                    msg = "恭喜兌中基本一星";
                                    break;
                                case 2:
                                    msg = "恭喜兌中基本二星";
                                    break;
                                case 3:
                                    msg = "恭喜兌中基本三星";
                                    break;
                                case 4:
                                    msg = "恭喜兌中基本四星";
                                    break;
                                case 5:
                                    msg = "恭喜兌中基本五星";
                                    break;
                                case 6:
                                    msg = "恭喜兌中基本六星";
                                    break;
                                case 7:
                                    msg = "恭喜兌中基本七星";
                                    break;
                                case 8:
                                    msg = "恭喜兌中基本八星";
                                    break;
                                case 9:
                                    msg = "恭喜兌中基本九星";
                                    break;
                                case 10:
                                    msg = "恭喜兌中基本十星";
                                    break;
                            }
                        }
                        else
                        {
                            msg = "下次再試試手氣吧!";
                        }
                    }

                    lblFinalResult.Text = msg;
                }
                //below is manual select****************************************************************
                if (bManualSelect.Count > 0)//如果manual選
                {
                    for (int i = 0; i < bManualSelect.Count; i++)
                    {
                        if (bManualSelect[i] == bLotteryNum[19])
                        {
                            manualMatchSuper = true;//快選有兌到超級獎號
                            break;
                        }
                    }
                    for (int j = 0; j < bManualSelect.Count; j++)
                    {
                        if (Array.IndexOf(bLotteryNum, bManualSelect[j]) >= 0)
                        {
                            countBingoManualMatch++;
                        }
                    }
                    if (manualMatchSuper == true)//有兌到超級獎號
                    {
                        switch (countBingoManualMatch)
                        {
                            case 1:
                                msg = "恭喜兌中超級一星(0+1)";
                                break;
                            case 2:
                                msg = "恭喜兌中超級二星(1+1)";
                                break;
                            case 3:
                                msg = "恭喜兌中超級三星(2+1)";
                                break;
                            case 4:
                                msg = "恭喜兌中超級四星(3+1)";
                                break;
                            case 5:
                                msg = "恭喜兌中超級五星(4+1)";
                                break;
                            case 6:
                                msg = "恭喜兌中超級六星(5+1)";
                                break;
                            case 7:
                                msg = "恭喜兌中超級七星(6+1)";
                                break;
                            case 8:
                                msg = "恭喜兌中超級八星(7+1)";
                                break;
                            case 9:
                                msg = "恭喜兌中超級九星(8+1)";
                                break;
                            case 10:
                                msg = "恭喜兌中超級十星(9+1)";
                                break;
                        }
                    }
                    else//沒兌到超級獎號
                    {
                        if (countBingoManualMatch > 0)
                        {
                            switch (countBingoManualMatch)
                            {
                                case 1:
                                    msg = "恭喜兌中基本一星";
                                    break;
                                case 2:
                                    msg = "恭喜兌中基本二星";
                                    break;
                                case 3:
                                    msg = "恭喜兌中基本三星";
                                    break;
                                case 4:
                                    msg = "恭喜兌中基本四星";
                                    break;
                                case 5:
                                    msg = "恭喜兌中基本五星";
                                    break;
                                case 6:
                                    msg = "恭喜兌中基本六星";
                                    break;
                                case 7:
                                    msg = "恭喜兌中基本七星";
                                    break;
                                case 8:
                                    msg = "恭喜兌中基本八星";
                                    break;
                                case 9:
                                    msg = "恭喜兌中基本九星";
                                    break;
                                case 10:
                                    msg = "恭喜兌中基本十星";
                                    break;
                            }
                        }
                        else
                        {
                            msg = "下次再試試手氣吧!";
                        }
                    }

                    lblFinalResult.Text = msg;
                }


            }
            //以下是沒選超級獎號**********************************************
            else//也就是user沒勾選chkSuper
            {
                //又分為快選跟人工選
                if (bRandomSelect[0] != 0)//如果快選
                {
                    for (int i = 0; i < countStar(); i++)
                    {
                        if (bRandomSelect[i] == bLotteryNum[19])
                        {
                            randomMatchSuper = true;//快選有兌到超級獎號
                            break;
                        }
                    }
                    foreach (int num in bRandomSelect)
                    {
                        if (Array.IndexOf(bLotteryNum, num) >= 0)
                        {
                            countBingoMatch++;
                        }
                    }
                    if (countBingoMatch > 0)
                    {
                        switch (countBingoMatch)
                        {
                            case 1:
                                msg = "恭喜兌中基本一星";
                                break;
                            case 2:
                                msg = "恭喜兌中基本二星";
                                break;
                            case 3:
                                msg = "恭喜兌中基本三星";
                                break;
                            case 4:
                                msg = "恭喜兌中基本四星";
                                break;
                            case 5:
                                msg = "恭喜兌中基本五星";
                                break;
                            case 6:
                                msg = "恭喜兌中基本六星";
                                break;
                            case 7:
                                msg = "恭喜兌中基本七星";
                                break;
                            case 8:
                                msg = "恭喜兌中基本八星";
                                break;
                            case 9:
                                msg = "恭喜兌中基本九星";
                                break;
                            case 10:
                                msg = "恭喜兌中基本十星";
                                break;
                        }
                    }
                    else
                    {
                        msg = "下次再試試手氣吧!";
                    }
                    lblFinalResult.Text = msg;
                }
                else if (bManualSelect.Count > 0)//如果人工選號
                {
                    for (int i = 0; i < bManualSelect.Count; i++)
                    {
                        if (bManualSelect[i] == bLotteryNum[19])
                        {
                            manualMatchSuper = true;//人工選有兌到超級獎號
                            break;
                        }
                    }
                    for (int j = 0; j < bManualSelect.Count; j++)
                    {
                        if (Array.IndexOf(bLotteryNum, bManualSelect[j]) >= 0)
                        {
                            countBingoManualMatch++;
                        }
                    }
                    if (countBingoManualMatch > 0)
                    {
                        switch (countBingoManualMatch)
                        {
                            case 1:
                                msg = "恭喜兌中基本一星";
                                break;
                            case 2:
                                msg = "恭喜兌中基本二星";
                                break;
                            case 3:
                                msg = "恭喜兌中基本三星";
                                break;
                            case 4:
                                msg = "恭喜兌中基本四星";
                                break;
                            case 5:
                                msg = "恭喜兌中基本五星";
                                break;
                            case 6:
                                msg = "恭喜兌中基本六星";
                                break;
                            case 7:
                                msg = "恭喜兌中基本七星";
                                break;
                            case 8:
                                msg = "恭喜兌中基本八星";
                                break;
                            case 9:
                                msg = "恭喜兌中基本九星";
                                break;
                            case 10:
                                msg = "恭喜兌中基本十星";
                                break;
                        }
                    }
                    else
                    {
                        msg = "下次再試試手氣吧!";
                    }
                    lblFinalResult.Text = msg;
                }

            }


        }

        private void btnBingoAdd_Click(object sender, EventArgs e)
        {
            this.result3BindingSource.AddNew();
        }

        private void btnBingoSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.result3BindingSource.EndEdit();
            result = MessageBox.Show("是否儲存號碼?", "儲存號碼", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.result3TableAdapter.Update(this.lotteryDataSet2.result3);
                this.result3TableAdapter.Fill(this.lotteryDataSet2.result3);
                this.result3BindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("取消儲存");
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex;
            currentIndex = this.result1BindingSource.Position;
            this.result1BindingSource.EndEdit();
            result = MessageBox.Show("確認修改資料?", "修改資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result1TableAdapter.Update(this.lotteryDataSet.result1);
                this.result1TableAdapter.Fill(this.lotteryDataSet.result1);
                MessageBox.Show("資料修改完成");
            }
            else
            {
                this.result1TableAdapter.Fill(this.lotteryDataSet.result1);
                MessageBox.Show("取消資料修改");
            }
            this.result1BindingSource.Position = currentIndex;
        }

        private void btnWRevise_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex;
            currentIndex = this.result2BindingSource.Position;
            this.result2BindingSource.EndEdit();
            result = MessageBox.Show("確認修改資料?", "修改資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result2TableAdapter.Update(this.lotteryDataSet1.result2);
                this.result2TableAdapter.Fill(this.lotteryDataSet1.result2);
                MessageBox.Show("資料修改完成");
            }
            else
            {
                this.result2TableAdapter.Fill(this.lotteryDataSet1.result2);
                MessageBox.Show("取消資料修改");
            }
            this.result2BindingSource.Position = currentIndex;
        }

        private void btnBingoRevise_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex;
            currentIndex = this.result3BindingSource.Position;
            this.result3BindingSource.EndEdit();
            result = MessageBox.Show("確認修改資料?", "修改資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result3TableAdapter.Update(this.lotteryDataSet2.result3);
                this.result3TableAdapter.Fill(this.lotteryDataSet2.result3);
                MessageBox.Show("資料修改完成");
            }
            else
            {
                this.result3TableAdapter.Fill(this.lotteryDataSet2.result3);
                MessageBox.Show("取消資料修改");
            }
            this.result3BindingSource.Position = currentIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result1BindingSource.Position;
            this.result1BindingSource.EndEdit();
            result = MessageBox.Show("確認刪除資料?", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result1BindingSource.RemoveAt(currentIndex);
                this.result1BindingSource.EndEdit();
                this.result1TableAdapter.Update(this.lotteryDataSet.result1);
                this.result1TableAdapter.Update(this.lotteryDataSet.result1);
            }
            else
            {
                MessageBox.Show("取消刪除資料");
            }
        }

        private void btnWDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result2BindingSource.Position;
            this.result2BindingSource.EndEdit();
            result = MessageBox.Show("確認刪除資料?", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result2BindingSource.RemoveAt(currentIndex);
                this.result2BindingSource.EndEdit();
                this.result2TableAdapter.Update(this.lotteryDataSet1.result2);
                this.result2TableAdapter.Update(this.lotteryDataSet1.result2);
            }
            else
            {
                MessageBox.Show("取消刪除資料");
            }
        }

        private void btnBingoDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result3BindingSource.Position;
            this.result3BindingSource.EndEdit();
            result = MessageBox.Show("確認刪除資料?", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.result3BindingSource.RemoveAt(currentIndex);
                this.result3BindingSource.EndEdit();
                this.result3TableAdapter.Update(this.lotteryDataSet2.result3);
                this.result3TableAdapter.Update(this.lotteryDataSet2.result3);
            }
            else
            {
                MessageBox.Show("取消刪除資料");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result1BindingSource.Position;
            this.result1BindingSource.EndEdit();
            result = MessageBox.Show("確認取消異動?", "取消異動", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.result1TableAdapter.Fill(this.lotteryDataSet.result1);
                MessageBox.Show("資料異動取消");

            }
            else
            {

            }
            this.result1BindingSource.Position = currentIndex;
            //only change message content and do fill directly without updating
        }

        private void btnWCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result2BindingSource.Position;
            this.result2BindingSource.EndEdit();
            result = MessageBox.Show("確認取消異動?", "取消異動", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.result2TableAdapter.Fill(this.lotteryDataSet1.result2);
                MessageBox.Show("資料異動取消");

            }
            else
            {

            }
            this.result2BindingSource.Position = currentIndex;
        }

        private void btnBingoCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int currentIndex = this.result3BindingSource.Position;
            this.result3BindingSource.EndEdit();
            result = MessageBox.Show("確認取消異動?", "取消異動", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.result3TableAdapter.Fill(this.lotteryDataSet2.result3);
                MessageBox.Show("資料異動取消");

            }
            else
            {

            }
            this.result3BindingSource.Position = currentIndex;
        }

        private void chkB15_CheckedChanged(object sender, EventArgs e)
        {
            bbo15 = chkB15.Checked;
        }

        private void chkB14_CheckedChanged(object sender, EventArgs e)
        {
            bbo14 = chkB14.Checked;
        }

        private void chkB13_CheckedChanged(object sender, EventArgs e)
        {
            bbo13 = chkB13.Checked;
        }

        private void chkB12_CheckedChanged(object sender, EventArgs e)
        {
            bbo12 = chkB12.Checked;
        }

        private void chkB11_CheckedChanged(object sender, EventArgs e)
        {
            bbo11 = chkB11.Checked;
        }

        private void chkB10_CheckedChanged(object sender, EventArgs e)
        {
            bbo10 = chkB10.Checked;
        }

        private void chkB9_CheckedChanged(object sender, EventArgs e)
        {
            bbo9 = chkB9.Checked;
        }

        private void chkB8_CheckedChanged(object sender, EventArgs e)
        {
            bbo8 = chkB8.Checked;
        }

        private void chkB7_CheckedChanged(object sender, EventArgs e)
        {
            bbo7 = chkB7.Checked;
        }

        private void chkB6_CheckedChanged(object sender, EventArgs e)
        {
            bbo6 = chkB6.Checked;
        }

        private void chkB5_CheckedChanged(object sender, EventArgs e)
        {
            bbo5 = chkB5.Checked;
        }

        private void chkB4_CheckedChanged(object sender, EventArgs e)
        {
            bbo4 = chkB4.Checked;
        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {
            bbo3 = chkB3.Checked;
        }

        private void chkB2_CheckedChanged(object sender, EventArgs e)
        {
            bbo2 = chkB2.Checked;
        }

        private void chkB1_CheckedChanged(object sender, EventArgs e)
        {
            bbo1 = chkB1.Checked;
        }

        private void rbt10_CheckedChanged(object sender, EventArgs e)
        {
            star10 = rbt10.Checked;
        }

        private void rbt9_CheckedChanged(object sender, EventArgs e)
        {
            star9 = rbt9.Checked;
        }

        private void rbt8_CheckedChanged(object sender, EventArgs e)
        {
            star8 = rbt8.Checked;
        }

        private void rbt7_CheckedChanged(object sender, EventArgs e)
        {
            star7 = rbt7.Checked;
        }

        private void rbt6_CheckedChanged(object sender, EventArgs e)
        {
            star6 = rbt6.Checked;
        }

        private void rbt5_CheckedChanged(object sender, EventArgs e)
        {
            star5 = rbt5.Checked;
        }

        private void rbt4_CheckedChanged(object sender, EventArgs e)
        {
            star4 = rbt4.Checked;
        }

        private void rbt3_CheckedChanged(object sender, EventArgs e)
        {
            star3 = rbt3.Checked;
        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            star2 = rbt2.Checked;
        }

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            star1 = rbt1.Checked;
        }

        private void btnWSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.result2BindingSource.EndEdit();
            result = MessageBox.Show("是否儲存號碼?", "儲存號碼", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.result2TableAdapter.Update(this.lotteryDataSet1.result2);
                this.result2TableAdapter.Fill(this.lotteryDataSet1.result2);
                this.result2BindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("取消儲存");
            }
        }

        private void btnWAdd_Click(object sender, EventArgs e)
        {
            this.result2BindingSource.AddNew();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            this.result1BindingSource.EndEdit();
            result = MessageBox.Show("是否儲存號碼?", "儲存號碼", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.result1TableAdapter.Update(this.lotteryDataSet.result1);
                this.result1TableAdapter.Fill(this.lotteryDataSet.result1);
                this.result1BindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("取消儲存");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.result1BindingSource.AddNew();
        }

        bool star1, star2, star3, star4, star5, star6, star7, star8, star9, star10;
        int stars = 0;
        bool selectRandom, selectBig, selectSmall;
        bool boBig, boSmall, resultBig, resultSmall;
        int randomBigSmall;
        string bigSmallString = "";
        string luckyString = "";
        //for manual select
        int bManual = 0;
        List<int> bManualSelect = new List<int>();
        //for random select
        int bRandom = 0;
        int[] bRandomSelect = new int[10];
        //for result
        string stringBefore = "";
        string stringAfter = "";
        int bLottery = 0;
        int[] bLotteryNum = new int[20];
        int[] bTempLottery = new int[20];
        int countBingoMatch = 0;
        int countBingoManualMatch = 0;
        bool boSuper = false;
        bool randomMatchSuper = false;
        bool manualMatchSuper = false;
        int countBig = 0;
        int countSmall = 0;
        int superNum = 0;
        bool boSuperRandom = false;
        bool boSuperManual = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lotteryDataSet2.result3' table. You can move, or remove it, as needed.
            this.result3TableAdapter.Fill(this.lotteryDataSet2.result3);
            // TODO: This line of code loads data into the 'lotteryDataSet1.result2' table. You can move, or remove it, as needed.
            this.result2TableAdapter.Fill(this.lotteryDataSet1.result2);
            // TODO: This line of code loads data into the 'lotteryDataSet.result1' table. You can move, or remove it, as needed.
            this.result1TableAdapter.Fill(this.lotteryDataSet.result1);

        }

        private void result1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.result1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lotteryDataSet);

        }

        private void chkW1_CheckedChanged(object sender, EventArgs e)
        {
            wbo1 = chkW1.Checked;
        }

        private void chkW2_CheckedChanged(object sender, EventArgs e)
        {
            wbo2 = chkW2.Checked;
        }

        private void chkW3_CheckedChanged(object sender, EventArgs e)
        {
            wbo3 = chkW3.Checked;
        }

        private void chkW4_CheckedChanged(object sender, EventArgs e)
        {
            wbo4 = chkW4.Checked;
        }

        private void chkW5_CheckedChanged(object sender, EventArgs e)
        {
            wbo5 = chkW5.Checked;
        }

        private void chkW6_CheckedChanged(object sender, EventArgs e)
        {
            wbo6 = chkW6.Checked;
        }

        private void chkW7_CheckedChanged(object sender, EventArgs e)
        {
            wbo7 = chkW7.Checked;
        }

        private void chkW8_CheckedChanged(object sender, EventArgs e)
        {
            wbo8 = chkW8.Checked;
        }

        private void chkW9_CheckedChanged(object sender, EventArgs e)
        {
            wbo9 = chkW9.Checked;
        }

        private void chkW10_CheckedChanged(object sender, EventArgs e)
        {
            wbo10 = chkW10.Checked;
        }

        private void chkW11_CheckedChanged(object sender, EventArgs e)
        {
            wbo11 = chkW11.Checked;
        }

        private void chkW12_CheckedChanged(object sender, EventArgs e)
        {
            wbo12 = chkW12.Checked;
        }

        private void chkW13_CheckedChanged(object sender, EventArgs e)
        {
            wbo13 = chkW13.Checked;
        }

        private void chkW14_CheckedChanged(object sender, EventArgs e)
        {
            wbo14 = chkW14.Checked;
        }

        private void chkW15_CheckedChanged(object sender, EventArgs e)
        {
            wbo15 = chkW15.Checked;
        }

        private void chkW16_CheckedChanged(object sender, EventArgs e)
        {
            wbo16 = chkW16.Checked;
        }

        private void chkW17_CheckedChanged(object sender, EventArgs e)
        {
            wbo17 = chkW17.Checked;
        }

        private void chkW18_CheckedChanged(object sender, EventArgs e)
        {
            wbo18 = chkW18.Checked;
        }

        private void chkW19_CheckedChanged(object sender, EventArgs e)
        {
            wbo19 = chkW19.Checked;
        }

        private void chkW20_CheckedChanged(object sender, EventArgs e)
        {
            wbo20 = chkW20.Checked;
        }

        private void chkW21_CheckedChanged(object sender, EventArgs e)
        {
            wbo21 = chkW21.Checked;
        }

        private void chkW22_CheckedChanged(object sender, EventArgs e)
        {
            wbo22 = chkW22.Checked;
        }

        private void chkW23_CheckedChanged(object sender, EventArgs e)
        {
            wbo23 = chkW23.Checked;
        }

        private void chkW24_CheckedChanged(object sender, EventArgs e)
        {
            wbo24 = chkW24.Checked;
        }

        private void chkW25_CheckedChanged(object sender, EventArgs e)
        {
            wbo25 = chkW25.Checked;
        }

        private void chkW26_CheckedChanged(object sender, EventArgs e)
        {
            wbo26 = chkW26.Checked;
        }

        private void chkW27_CheckedChanged(object sender, EventArgs e)
        {
            wbo27 = chkW27.Checked;
        }

        private void chkW28_CheckedChanged(object sender, EventArgs e)
        {
            wbo28 = chkW28.Checked;
        }

        private void chkW29_CheckedChanged(object sender, EventArgs e)
        {
            wbo29 = chkW29.Checked;
        }

        private void chkW30_CheckedChanged(object sender, EventArgs e)
        {
            wbo30 = chkW30.Checked;
        }

        private void chkW31_CheckedChanged(object sender, EventArgs e)
        {
            wbo31 = chkW31.Checked;
        }

        private void chkW32_CheckedChanged(object sender, EventArgs e)
        {
            wbo32 = chkW32.Checked;
        }

        private void chkW33_CheckedChanged(object sender, EventArgs e)
        {
            wbo33 = chkW33.Checked;
        }

        private void chkW34_CheckedChanged(object sender, EventArgs e)
        {
            wbo34 = chkW34.Checked;
        }

        private void chkW35_CheckedChanged(object sender, EventArgs e)
        {
            wbo35 = chkW35.Checked;
        }

        private void chkW36_CheckedChanged(object sender, EventArgs e)
        {
            wbo36 = chkW36.Checked;
        }

        private void chkW37_CheckedChanged(object sender, EventArgs e)
        {
            wbo37 = chkW37.Checked;
        }

        private void chkW38_CheckedChanged(object sender, EventArgs e)
        {
            wbo38 = chkW38.Checked;
        }

        private void chkZoneB1_CheckedChanged(object sender, EventArgs e)
        {
            zoneB1 = chkZoneB1.Checked;
        }

        private void chkZoneB2_CheckedChanged(object sender, EventArgs e)
        {
            zoneB2 = chkZoneB2.Checked;
        }

        private void chkZoneB3_CheckedChanged(object sender, EventArgs e)
        {
            zoneB3 = chkZoneB3.Checked;
        }

        private void chkZoneB4_CheckedChanged(object sender, EventArgs e)
        {
            zoneB4 = chkZoneB4.Checked;
        }

        private void chkZoneB5_CheckedChanged(object sender, EventArgs e)
        {
            zoneB5 = chkZoneB5.Checked;
        }

        private void chkZoneB6_CheckedChanged(object sender, EventArgs e)
        {
            zoneB6 = chkZoneB6.Checked;
        }

        private void chkZoneB7_CheckedChanged(object sender, EventArgs e)
        {
            zoneB7 = chkZoneB7.Checked;
        }

        private void chkZoneB8_CheckedChanged(object sender, EventArgs e)
        {
            zoneB8 = chkZoneB8.Checked;
        }

        private void btnWRandomSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < wlength; i++)
            {
                do
                {
                    wRandom = ram.Next(1, 39);//generate ram betweeb 1 ~ 38
                } while (wRandomSelect.Contains(wRandom));
                //while a random num already in buyerZoneA array, generate new num;
                wRandomSelect[i] = wRandom;
                //if a random num is not in buyerZoneA, store it in the array;
            }
            wZoneB = ram.Next(1, 9);//generate ram between 1 ~ 8
            timer3.Start();
            timer2.Start();
        }

        private void btnWManualSelect_Click(object sender, EventArgs e)
        {
            string msg = "";
            string msgB = "";
            int manualZoneB = 0;
            //bool boClear = false;
            bool[] wboManual = new bool[38] {wbo1, wbo2,wbo3,wbo4, wbo5, wbo6,
            wbo7, wbo8, wbo9, wbo10, wbo11, wbo12, wbo13, wbo14, wbo15, wbo16, wbo17,
            wbo18, wbo19, wbo20, wbo21, wbo22, wbo23, wbo24, wbo25, wbo26, wbo27,
            wbo28, wbo29, wbo30, wbo31, wbo32, wbo33, wbo34, wbo35, wbo36, wbo37,
            wbo38};
            bool[] boZoneB = new bool[8] { zoneB1, zoneB2, zoneB3, zoneB4, zoneB5, zoneB6, zoneB7, zoneB8 };
            int wCheckCount = 0;
            int zoneBCheckCount = 0;
            bool wDoRandom = true;
            foreach (bool bo in wboManual)
            {
                if (bo == true)
                {
                    wCheckCount++;
                }
            }
            foreach (bool bo in boZoneB)
            {
                if (bo == true)
                {
                    zoneBCheckCount++;
                }
            }
            if (wCheckCount <= 6)
            {
                for (int i = 0; i < 38; i++)
                {
                    if (wboManual[i] == true)
                    {
                        wManual = i + 1;
                        wManualSelect.Add(wManual);
                    }
                }
            }
            else
            {
                msg = "第一區最多只能選6個號碼, 請清除號碼重選";
                MessageBox.Show(msg);
                wDoRandom = false;
            }
            if (zoneBCheckCount < 2)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (boZoneB[j] == true)
                    {
                        wManualZoneB = j + 1;
                    }
                }
            }
            else
            {
                msgB = "第二區最多只能選1個號碼, 請清除號碼重選";
                MessageBox.Show(msgB);
                wDoRandom = false;
            }
            if (wManualZoneB == 0)
            {
                wManualZoneB = ram.Next(1, 9);
            }
            if (wDoRandom == true)
            {
                int len = wlength - wManualSelect.Count;
                for (int i = 0; i < len; i++)
                {
                    do
                    {
                        wManual = ram.Next(1, 39);
                    } while (wManualSelect.Contains(wManual));
                    wManualSelect.Add(wManual);
                }
                tbWLucky1.Text = Convert.ToString(wManualSelect[0]);
                tbWLucky2.Text = Convert.ToString(wManualSelect[1]);
                tbWLucky3.Text = Convert.ToString(wManualSelect[2]);
                tbWLucky4.Text = Convert.ToString(wManualSelect[3]);
                tbWLucky5.Text = Convert.ToString(wManualSelect[4]);
                tbWLucky6.Text = Convert.ToString(wManualSelect[5]);
                tbWLucky7.Text = Convert.ToString(wManualZoneB);
            }
        }

        private void btnWClear_Click(object sender, EventArgs e)
        {
            if (wManualSelect.Count > 0)
            {
                wManualSelect.RemoveRange(0, 6);
            }
            else
            {
                wRandomSelect.Initialize();
            }
            Array.Clear(ramArray, 0, ramArray.Length);
            lblWResult.Text = "";
            lblWShowRandom.Text = "";
            lblShowRandom.Text = "";
            tbWLucky1.Text = "";
            tbWLucky2.Text = "";
            tbWLucky3.Text = "";
            tbWLucky4.Text = "";
            tbWLucky5.Text = "";
            tbWLucky6.Text = "";
            tbWLucky7.Text = "";
            tbWDraw1.Text = "";
            tbWDraw2.Text = "";
            tbWDraw3.Text = "";
            tbWDraw4.Text = "";
            tbWDraw5.Text = "";
            tbWDraw6.Text = "";
            tbWDraw7.Text = "";
            tbWDraw11.Text = "";
            tbWDraw22.Text = "";
            tbWDraw33.Text = "";
            tbWDraw44.Text = "";
            tbWDraw55.Text = "";
            tbWDraw66.Text = "";
            tbWDraw77.Text = "";
            chkW1.CheckState = CheckState.Unchecked;
            chkW2.CheckState = CheckState.Unchecked;
            chkW3.CheckState = CheckState.Unchecked;
            chkW4.CheckState = CheckState.Unchecked;
            chkW5.CheckState = CheckState.Unchecked;
            chkW6.CheckState = CheckState.Unchecked;
            chkW7.CheckState = CheckState.Unchecked;
            chkW8.CheckState = CheckState.Unchecked;
            chkW9.CheckState = CheckState.Unchecked;
            chkW10.CheckState = CheckState.Unchecked;
            chkW11.CheckState = CheckState.Unchecked;
            chkW12.CheckState = CheckState.Unchecked;
            chkW13.CheckState = CheckState.Unchecked;
            chkW14.CheckState = CheckState.Unchecked;
            chkW15.CheckState = CheckState.Unchecked;
            chkW16.CheckState = CheckState.Unchecked;
            chkW17.CheckState = CheckState.Unchecked;
            chkW18.CheckState = CheckState.Unchecked;
            chkW19.CheckState = CheckState.Unchecked;
            chkW20.CheckState = CheckState.Unchecked;
            chkW21.CheckState = CheckState.Unchecked;
            chkW22.CheckState = CheckState.Unchecked;
            chkW23.CheckState = CheckState.Unchecked;
            chkW24.CheckState = CheckState.Unchecked;
            chkW25.CheckState = CheckState.Unchecked;
            chkW26.CheckState = CheckState.Unchecked;
            chkW27.CheckState = CheckState.Unchecked;
            chkW28.CheckState = CheckState.Unchecked;
            chkW29.CheckState = CheckState.Unchecked;
            chkW30.CheckState = CheckState.Unchecked;
            chkW31.CheckState = CheckState.Unchecked;
            chkW32.CheckState = CheckState.Unchecked;
            chkW33.CheckState = CheckState.Unchecked;
            chkW34.CheckState = CheckState.Unchecked;
            chkW35.CheckState = CheckState.Unchecked;
            chkW36.CheckState = CheckState.Unchecked;
            chkW37.CheckState = CheckState.Unchecked;
            chkW38.CheckState = CheckState.Unchecked;
            chkZoneB1.CheckState = CheckState.Unchecked;
            chkZoneB2.CheckState = CheckState.Unchecked;
            chkZoneB3.CheckState = CheckState.Unchecked;
            chkZoneB4.CheckState = CheckState.Unchecked;
            chkZoneB5.CheckState = CheckState.Unchecked;
            chkZoneB6.CheckState = CheckState.Unchecked;
            chkZoneB7.CheckState = CheckState.Unchecked;
            chkZoneB8.CheckState = CheckState.Unchecked;
        }

        private void btnWDraw_Click(object sender, EventArgs e)
        {
            //lotteryZoneB
            for (int i = 0; i < wlength; i++)
            {
                do
                {
                    wLottery = ram.Next(1, 39);
                } while (wLotteryNum.Contains(wLottery));
                //beforeSort += String.Format("{0,2}  ", lottery);
                wLotteryNum[i] = wLottery;
            }
            wLotteryZoneB = ram.Next(1, 9);
            tbWDraw1.Text = Convert.ToString(wLotteryNum[0]);
            tbWDraw2.Text = Convert.ToString(wLotteryNum[1]);
            tbWDraw3.Text = Convert.ToString(wLotteryNum[2]);
            tbWDraw4.Text = Convert.ToString(wLotteryNum[3]);
            tbWDraw5.Text = Convert.ToString(wLotteryNum[4]);
            tbWDraw6.Text = Convert.ToString(wLotteryNum[5]);
            tbWDraw7.Text = Convert.ToString(wLotteryZoneB);

            Array.Copy(wLotteryNum, wTempLottery, wlength);
            Array.Sort(wTempLottery);

            tbWDraw11.Text = Convert.ToString(wTempLottery[0]);
            tbWDraw22.Text = Convert.ToString(wTempLottery[1]);
            tbWDraw33.Text = Convert.ToString(wTempLottery[2]);
            tbWDraw44.Text = Convert.ToString(wTempLottery[3]);
            tbWDraw55.Text = Convert.ToString(wTempLottery[4]);
            tbWDraw66.Text = Convert.ToString(wTempLottery[5]);
            tbWDraw77.Text = Convert.ToString(wLotteryZoneB);
        }

        private void btnWPrize_Click(object sender, EventArgs e)
        {
            if (wRandomSelect[0] != 0)
            {
                wPrize(lotteryNum, wRandomSelect);
            }
            if (wManualSelect.Count == 6)
            {
                string msg = "";
                for (int k = 0; k < wlength; k++)
                {
                    if (Array.IndexOf(wLotteryNum, wManualSelect[k]) >= 0)
                    {
                        wCount += 1;
                    }
                }

                if (wManualZoneB == wLotteryZoneB)
                {
                    matchZoneB = true;
                    match = 1;
                }
                else
                {
                    matchZoneB = false;
                    match = 0;
                }
                if (wCount + match >= 2)
                {
                    if (wCount + match == 2)
                    {
                        if (matchZoneB)
                            msg = "恭喜贏得100元!";
                        else
                            msg = "下次再試試手氣吧!";
                    }
                    else if (wCount + match == 3)
                    {
                        if (!matchZoneB)
                        {
                            msg = "恭喜贏得100元!";
                        }
                        else
                        {
                            msg = "恭喜贏得200元!";
                        }
                    }
                    else if (wCount + match == 4)
                    {
                        if (matchZoneB)
                        {
                            msg = "恭喜贏得400元!";
                        }
                        else
                        {
                            msg = "恭喜贏得800元!";
                        }
                    }
                    else if (wCount + match == 5)
                    {
                        if (matchZoneB)
                        {
                            msg = "恭喜贏得4,000元!";
                        }
                        else
                        {
                            msg = "恭喜贏得20,000元!";
                        }
                    }
                    else if (wCount + match == 6)
                    {
                        if (matchZoneB)
                        {
                            msg = "恭喜贏得150,000元!";
                        }
                        else
                        {
                            msg = "恭喜贏得總獎金的11%!";
                        }
                    }
                    else if (wCount + match == 7)
                        msg = "恭喜贏得總獎金的89%";
                }
                else
                {
                    msg = "下次再試試手氣吧!";
                }
                lblWResult.Text = msg;
                wCount = 0;
                matchZoneB = false;
                wManualSelect.RemoveRange(0, 6);
            }
        }

        private void wPrize(int[] lotteryArray, int[] myArray)
        {
            string msg = "";
            for (int k = 0; k < wlength; k++)
            {
                if (Array.IndexOf(wLotteryNum, wRandomSelect[k]) >= 0)
                {
                    wCount += 1;
                }
            }

            if (wZoneB == wLotteryZoneB)
            {
                matchZoneB = true;
                match = 1;
            }
            else
            {
                matchZoneB = false;
                match = 0;
            }
            if (wCount + match >= 2)
            {
                if (wCount + match == 2)
                {
                    if (matchZoneB)
                        msg = "恭喜贏得100元!";
                    else
                        msg = "下次再試試手氣吧!";
                }
                else if (wCount + match == 3)
                {
                    if (!matchZoneB)
                    {
                        msg = "恭喜贏得100元!";
                    }
                    else
                    {
                        msg = "恭喜贏得200元!";
                    }
                }
                else if (wCount + match == 4)
                {
                    if (matchZoneB)
                    {
                        msg = "恭喜贏得400元!";
                    }
                    else
                    {
                        msg = "恭喜贏得800元!";
                    }
                }
                else if (wCount + match == 5)
                {
                    if (matchZoneB)
                    {
                        msg = "恭喜贏得4,000元!";
                    }
                    else
                    {
                        msg = "恭喜贏得20,000元!";
                    }
                }
                else if (wCount + match == 6)
                {
                    if (matchZoneB)
                    {
                        msg = "恭喜贏得150,000元!";
                    }
                    else
                    {
                        msg = "恭喜贏得總獎金的11%!";
                    }
                }
                else if (wCount + match == 7)
                    msg = "恭喜贏得總獎金的89%!";
            }
            else
            {
                msg = "下次再試試手氣吧!";
            }
            lblWResult.Text = msg;
            wCount = 0;
            matchZoneB = false;
            wRandomSelect.Initialize();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (s == 10)
            {
                tbWLucky1.Text = Convert.ToString(wRandomSelect[0]);
            }
            else if (s == 8)
            {
                tbWLucky2.Text = Convert.ToString(wRandomSelect[1]);
            }
            else if (s == 6)
            {
                tbWLucky3.Text = Convert.ToString(wRandomSelect[2]);
            }
            else if (s == 5)
            {
                tbWLucky4.Text = Convert.ToString(wRandomSelect[3]);
            }
            else if (s == 4)
            {
                tbWLucky5.Text = Convert.ToString(wRandomSelect[4]);
            }
            else if (s == 3)
            {
                tbWLucky6.Text = Convert.ToString(wRandomSelect[5]);
            }
            else if (s == 1)
            {
                tbWLucky7.Text = Convert.ToString(wZoneB);
            }
            s--;
        }        
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            bo1 = chk1.Checked;
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            bo2 = chk2.Checked;
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            bo3 = chk3.Checked;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            bo4 = chk4.Checked;
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            bo5 = chk5.Checked;
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            bo6 = chk6.Checked;
        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            bo7 = chk7.Checked;
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            bo8 = chk8.Checked;
        }

        private void chk9_CheckedChanged(object sender, EventArgs e)
        {
            bo9 = chk9.Checked;
        }

        private void chk10_CheckedChanged(object sender, EventArgs e)
        {
            bo10 = chk10.Checked;
        }

        private void chk11_CheckedChanged(object sender, EventArgs e)
        {
            bo11 = chk11.Checked;
        }

        private void chk12_CheckedChanged(object sender, EventArgs e)
        {
            bo12 = chk12.Checked;
        }

        private void chk13_CheckedChanged(object sender, EventArgs e)
        {
            bo13 = chk13.Checked;
        }

        private void chk14_CheckedChanged(object sender, EventArgs e)
        {
            bo14 = chk14.Checked;
        }

        private void chk15_CheckedChanged(object sender, EventArgs e)
        {
            bo15 = chk15.Checked;
        }

        private void chk16_CheckedChanged(object sender, EventArgs e)
        {
            bo16 = chk16.Checked;
        }

        private void chk17_CheckedChanged(object sender, EventArgs e)
        {
            bo17 = chk17.Checked;
        }

        private void chk18_CheckedChanged(object sender, EventArgs e)
        {
            bo18 = chk18.Checked;
        }

        private void chk19_CheckedChanged(object sender, EventArgs e)
        {
            bo19 = chk19.Checked;
        }

        private void chk20_CheckedChanged(object sender, EventArgs e)
        {
            bo20 = chk20.Checked;
        }

        private void chk21_CheckedChanged(object sender, EventArgs e)
        {
            bo21 = chk21.Checked;
        }

        private void chk22_CheckedChanged(object sender, EventArgs e)
        {
            bo22 = chk22.Checked;
        }

        private void chk23_CheckedChanged(object sender, EventArgs e)
        {
            bo23 = chk23.Checked;
        }

        private void chk24_CheckedChanged(object sender, EventArgs e)
        {
            bo24 = chk24.Checked;
        }

        private void chk25_CheckedChanged(object sender, EventArgs e)
        {
            bo25 = chk25.Checked;
        }

        private void chk26_CheckedChanged(object sender, EventArgs e)
        {
            bo26 = chk26.Checked;
        }

        private void chk27_CheckedChanged(object sender, EventArgs e)
        {
            bo27 = chk27.Checked;
        }

        private void chk28_CheckedChanged(object sender, EventArgs e)
        {
            bo28 = chk28.Checked;
        }

        private void chk29_CheckedChanged(object sender, EventArgs e)
        {
            bo29 = chk29.Checked;
        }

        private void chk30_CheckedChanged(object sender, EventArgs e)
        {
            bo30 = chk30.Checked;
        }

        private void chk31_CheckedChanged(object sender, EventArgs e)
        {
            bo31 = chk31.Checked;
        }

        private void chk32_CheckedChanged(object sender, EventArgs e)
        {
            bo32 = chk32.Checked;
        }

        private void chk33_CheckedChanged(object sender, EventArgs e)
        {
            bo33 = chk33.Checked;
        }

        private void chk34_CheckedChanged(object sender, EventArgs e)
        {
            bo34 = chk34.Checked;
        }

        private void chk35_CheckedChanged(object sender, EventArgs e)
        {
            bo35 = chk35.Checked;
        }

        private void chk36_CheckedChanged(object sender, EventArgs e)
        {
            bo36 = chk36.Checked;
        }

        private void chk37_CheckedChanged(object sender, EventArgs e)
        {
            bo37 = chk37.Checked;
        }

        private void chk38_CheckedChanged(object sender, EventArgs e)
        {
            bo38 = chk38.Checked;
        }

        private void chk39_CheckedChanged(object sender, EventArgs e)
        {
            bo39 = chk39.Checked;
        }

        private void btnRandomSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < length; i++)
            {
                do
                {
                    random = ram.Next(1, 40);
                } while (randomSelect.Contains(random));
                randomSelect[i] = random;
            }
            timer1.Start();
            timer2.Start();
            //for (int i = 0; i < length; i++)
            //{
            //    do
            //    {
            //        random = ram.Next(1, 40);
            //    } while (randomSelect.Contains(random));
            //    randomSelect[i] = random;
            //}
            //tbLucky1.Text = Convert.ToString(randomSelect[0]);
            //tbLucky2.Text = Convert.ToString(randomSelect[1]);
            //tbLucky3.Text = Convert.ToString(randomSelect[2]);
            //tbLucky4.Text = Convert.ToString(randomSelect[3]);
            //tbLucky5.Text = Convert.ToString(randomSelect[4]);
        }

        private void btnManualSelect_Click(object sender, EventArgs e)
        {
            string msg = "";
            int checkCount = 0;
            bool[] boManual = new bool[39] {bo1, bo2,bo3,bo4, bo5, bo6,
            bo7, bo8, bo9, bo10, bo11, bo12, bo13, bo14, bo15, bo16, bo17,
            bo18, bo19, bo20, bo21, bo22, bo23, bo24, bo25, bo26, bo27,
            bo28, bo29, bo30, bo31, bo32, bo33, bo34, bo35, bo36, bo37,
            bo38, bo39};
            bool boDoRandom = true;
            foreach (bool bo in boManual)
            {
                if (bo == true)
                {
                    checkCount++;
                }
            }
            if (checkCount <= 5)
            {
                for (int i = 0; i < 39; i++)
                {
                    if (boManual[i] == true)
                    {
                        manual = i + 1;
                        manualSelect.Add(manual);
                    }
                }
            }
            else
            {
                msg = "最多只能選5個號碼, 請清除號碼重選";
                MessageBox.Show(msg);
                boDoRandom = false;
            }

            if (boDoRandom == true)
            {
                int length = 5 - manualSelect.Count;
                for (int i = 0; i < length; i++)
                {
                    do
                    {
                        manual = ram.Next(1, 40);
                    } while (manualSelect.Contains(manual));
                    manualSelect.Add(manual);
                }

                tbLucky1.Text = Convert.ToString(manualSelect[0]);
                tbLucky2.Text = Convert.ToString(manualSelect[1]);
                tbLucky3.Text = Convert.ToString(manualSelect[2]);
                tbLucky4.Text = Convert.ToString(manualSelect[3]);
                tbLucky5.Text = Convert.ToString(manualSelect[4]);
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (manualSelect.Count > 0)
            {
                manualSelect.RemoveRange(0, 5);
            }
            else if (randomSelect[0] != 0)
            {
                randomSelect.Initialize();
            }

            Array.Clear(ramArray, 0, ramArray.Length);
            chk1.CheckState = CheckState.Unchecked;
            chk2.CheckState = CheckState.Unchecked;
            chk3.CheckState = CheckState.Unchecked;
            chk4.CheckState = CheckState.Unchecked;
            chk5.CheckState = CheckState.Unchecked;
            chk6.CheckState = CheckState.Unchecked;
            chk7.CheckState = CheckState.Unchecked;
            chk8.CheckState = CheckState.Unchecked;
            chk9.CheckState = CheckState.Unchecked;
            chk10.CheckState = CheckState.Unchecked;
            chk11.CheckState = CheckState.Unchecked;
            chk12.CheckState = CheckState.Unchecked;
            chk13.CheckState = CheckState.Unchecked;
            chk14.CheckState = CheckState.Unchecked;
            chk15.CheckState = CheckState.Unchecked;
            chk16.CheckState = CheckState.Unchecked;
            chk17.CheckState = CheckState.Unchecked;
            chk18.CheckState = CheckState.Unchecked;
            chk19.CheckState = CheckState.Unchecked;
            chk20.CheckState = CheckState.Unchecked;
            chk21.CheckState = CheckState.Unchecked;
            chk22.CheckState = CheckState.Unchecked;
            chk23.CheckState = CheckState.Unchecked;
            chk24.CheckState = CheckState.Unchecked;
            chk25.CheckState = CheckState.Unchecked;
            chk26.CheckState = CheckState.Unchecked;
            chk27.CheckState = CheckState.Unchecked;
            chk28.CheckState = CheckState.Unchecked;
            chk29.CheckState = CheckState.Unchecked;
            chk30.CheckState = CheckState.Unchecked;
            chk31.CheckState = CheckState.Unchecked;
            chk32.CheckState = CheckState.Unchecked;
            chk33.CheckState = CheckState.Unchecked;
            chk34.CheckState = CheckState.Unchecked;
            chk35.CheckState = CheckState.Unchecked;
            chk36.CheckState = CheckState.Unchecked;
            chk37.CheckState = CheckState.Unchecked;
            chk38.CheckState = CheckState.Unchecked;
            chk39.CheckState = CheckState.Unchecked;
            count = 0;
            clearTextBox();
        }
        private void clearTextBox()
        {
            lblResult.Text = "";
            lblShowRandom.Text = "";
            lblWShowRandom.Text = "";
            tbLucky1.Text = "";
            tbLucky2.Text = "";
            tbLucky3.Text = "";
            tbLucky4.Text = "";
            tbLucky5.Text = "";

            tbDrawNum1.Text = "";
            tbDrawNum2.Text = "";
            tbDrawNum3.Text = "";
            tbDrawNum4.Text = "";
            tbDrawNum5.Text = "";
            tbDrawNum11.Text = "";
            tbDrawNum22.Text = "";
            tbDrawNum33.Text = "";
            tbDrawNum44.Text = "";
            tbDrawNum55.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.result1BindingSource.EndEdit();
            result = MessageBox.Show("是否儲存號碼?", "儲存號碼", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.result1TableAdapter.Update(this.lotteryDataSet.result1);
                this.result1TableAdapter.Fill(this.lotteryDataSet.result1);
                this.result1BindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("取消儲存");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < length; i++)
            {
                do
                {
                    lottery = ram.Next(1, 40);
                } while (lotteryNum.Contains(lottery));
                lotteryNum[i] = lottery;
            }
            tbDrawNum1.Text = Convert.ToString(lotteryNum[0]);
            tbDrawNum2.Text = Convert.ToString(lotteryNum[1]);
            tbDrawNum3.Text = Convert.ToString(lotteryNum[2]);
            tbDrawNum4.Text = Convert.ToString(lotteryNum[3]);
            tbDrawNum5.Text = Convert.ToString(lotteryNum[4]);
            //beforeSort = "開出順序  " + beforeSort;
            // lotteryResult += beforeSort + "\n";
            Array.Copy(lotteryNum, tempLottery, length);
            Array.Sort(tempLottery);
            for (int j = 0; j < length; j++)
            {
                afterSort += String.Format("{0,2}  ", tempLottery[j]);
            }
            //afterSort = "大小順序  " + afterSort;
            //lotteryResult += afterSort + "\n";
            //lblLottery.Text = lotteryResult;
            tbDrawNum11.Text = Convert.ToString(tempLottery[0]);
            tbDrawNum22.Text = Convert.ToString(tempLottery[1]);
            tbDrawNum33.Text = Convert.ToString(tempLottery[2]);
            tbDrawNum44.Text = Convert.ToString(tempLottery[3]);
            tbDrawNum55.Text = Convert.ToString(tempLottery[4]);

        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            if (randomSelect[0] != 0)
            {
                prize(lotteryNum, randomSelect);
            }
            if (manualSelect.Count == 5)
            {
                string msg = "";
                for (int i = 0; i < length; i++)
                {
                    if (Array.IndexOf(lotteryNum, manualSelect[i]) >= 0)
                    {
                        count += 1;
                    }
                }
                if (count < 2)
                {
                    msg = "下次再試試手氣吧!";
                }
                else
                {
                    switch (count)
                    {
                        case 5:
                            msg = "恭喜贏得8,000,000元!";
                            break;
                        case 4:
                            msg = "恭喜贏得20,000元!";
                            break;
                        case 3:
                            msg = "恭喜贏得300元!";
                            break;
                        case 2:
                            msg = "恭喜贏得50元!";
                            break;
                    }
                }
                lblResult.Text = msg;
                count = 0;
            }

        }
        private void prize(int[] lotteryArray, int[] myArray)
        {
            string msg = "";
            for (int i = 0; i < length; i++)
            {
                if (Array.IndexOf(lotteryArray, myArray[i]) >= 0)
                {
                    count += 1;
                }
            }
            if (count < 2)
            {
                msg = "下次再試試手氣吧!";
            }
            else
            {
                switch (count)
                {
                    case 5:
                        msg = "恭喜贏得8,000,000元!";
                        break;
                    case 4:
                        msg = "恭喜贏得20,000元!";
                        break;
                    case 3:
                        msg = "恭喜贏得300元!";
                        break;
                    case 2:
                        msg = "恭喜贏得50元!";
                        break;
                }
            }
            lblResult.Text = msg;
            count = 0;
            myArray.Initialize();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 9)
            {
                tbLucky1.Text = Convert.ToString(randomSelect[0]);
            }
            else if (s == 7)
            {
                tbLucky2.Text = Convert.ToString(randomSelect[1]);
            }
            else if (s == 5)
            {
                tbLucky3.Text = Convert.ToString(randomSelect[2]);
            }
            else if (s == 3)
            {
                tbLucky4.Text = Convert.ToString(randomSelect[3]);
            }
            else if (s == 1)
            {
                tbLucky5.Text = Convert.ToString(randomSelect[4]);
            }
            s--;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                ramNum = ram.Next(1, 40);
                ramArray[i] = ramNum;
            }
            for (int k = 0; k < 30; k++)
            {
                if (randomSelect.Length > 0)
                    lblShowRandom.Text = Convert.ToString(ramArray[k]);
                if (wRandomSelect.Length > 0)
                    lblWShowRandom.Text = Convert.ToString(ramArray[k]);
            }
            if (tbLucky5.Text.Length > 0)
            {
                lblShowRandom.Text = "自動選號完成";
                timer2.Stop();
                timer1.Stop();
                s = 10;
            }
            if (tbWLucky7.Text.Length > 0)
            {
                lblWShowRandom.Text = "自動選號完成";
                timer3.Stop();
                timer2.Stop();
                s = 10;
            }
        }
//************************************
    }
}
