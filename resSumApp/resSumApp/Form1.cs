using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resSumApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button event
            Double tot = 0; //tot variable is the total price for customer's order. (include tax)

            //calculate all Appetizers items that customer ordered.
            tot += (double)numericUpDown101.Value * 6.75; //Agedashi Tofu
            tot += (double)numericUpDown102.Value * 6.75; //Spring Rolls
            tot += (double)numericUpDown103.Value * 4.75; //Seaweed Salad
            tot += (double)numericUpDown104.Value * 5.25; //Edamame
            tot += (double)numericUpDown105.Value * 6.95; //Tokoyaki 
            tot += (double)numericUpDown106.Value * 6.95; //Goyoza
            tot += (double)numericUpDown107_1.Value * 3.75; //Sunomono Cucumber
            tot += (double)numericUpDown107_2.Value * 4.85; //Sunomono Prawn/Kani
            tot += (double)numericUpDown108_1.Value * 12.95; //Tempura Vegetable
            tot += (double)numericUpDown108_2.Value * 13.25; //Tempura Prawn
            tot += (double)numericUpDown108_3.Value * 14.25; //Tempura Assorted
            tot += (double)numericUpDown109.Value * 3.25; //Stuff Mushroom

            //calculate all Signatures items that customer ordered.
            tot += (double)numericUpDown201.Value * 8.25; //Banzai
            tot += (double)numericUpDown202.Value * 8.25; //Kamikaze
            tot += (double)numericUpDown203.Value * 8.50; //Flame
            tot += (double)numericUpDown204.Value * 8.75; //Crazy
            tot += (double)numericUpDown205.Value * 11.50; //House Special
            tot += (double)numericUpDown206.Value * 12.95; //Rainbow
            tot += (double)numericUpDown207.Value * 13.50; //Fishionair
            tot += (double)numericUpDown208.Value * 9.25; //Green Latern
            tot += (double)numericUpDown209.Value * 12.25; //Beefancination
            tot += (double)numericUpDown210.Value * 13.25; //Aquarium

            //calculate all MiKi-Maki items that customer ordered.
            tot += (double)numericUpDown301.Value * 3.95; //Avocado Maki
            tot += (double)numericUpDown302.Value * 3.95; //Cucumber Maki
            tot += (double)numericUpDown303.Value * 3.95; //Ishinko Maki
            tot += (double)numericUpDown304.Value * 4.25; //Tuna/Sal,on/Tai/Scallop Maki
            tot += (double)numericUpDown304_1.Value * 0.75; //add spicy on maki
            tot += (double)numericUpDown304_2.Value * 1.00; //add Fried on maki

            //calculate all Nigiri/Sashimi items that customer ordered.

            // 1pc = 2.25, 5pc = 10

            //Tuna
            if (TunaNUD.Value < 5) {
                tot += (double)TunaNUD.Value * 2.25;
            }else if (TunaNUD.Value % 5 > 0){
                tot += (double)TunaNUD.Value/5 * 10;
                tot += (double)TunaNUD.Value % 5 * 2.25;
            }else if(TunaNUD.Value % 5 == 0){ 
                tot += (double)TunaNUD.Value / 5 * 10;
            }

            //Ebi
            if (EbiNUD.Value < 5)
            {
                tot += (double)EbiNUD.Value * 2.25;
            }
            else if (EbiNUD.Value % 5 > 0)
            {
                tot += (double)EbiNUD.Value / 5 * 10;
                tot += (double)EbiNUD.Value % 5 * 2.25;
            }
            else if (EbiNUD.Value % 5 == 0)
            {
                tot += (double)EbiNUD.Value / 5 * 10;
            }

            //Tai
            if (TaiNUD.Value < 5)
            {
                tot += (double)TaiNUD.Value * 2.25;
            }
            else if (TaiNUD.Value % 5 > 0)
            {
                tot += (double)TaiNUD.Value / 5 * 10;
                tot += (double)TaiNUD.Value % 5 * 2.25;
            }
            else if (TaiNUD.Value % 5 == 0)
            {
                tot += (double)TaiNUD.Value / 5 * 10;
            }

            //Tamago
            if (TamagoNUD.Value < 5)
            {
                tot += (double)TamagoNUD.Value * 2.25;
            }
            else if (TamagoNUD.Value % 5 > 0)
            {
                tot += (double)TamagoNUD.Value / 5 * 10;
                tot += (double)TamagoNUD.Value % 5 * 2.25;
            }
            else if (TamagoNUD.Value % 5 == 0)
            {
                tot += (double)TamagoNUD.Value / 5 * 10;
            }

            //Inari
            if (InariNUD.Value < 5)
            {
                tot += (double)InariNUD.Value * 2.25;
            }
            else if (InariNUD.Value % 5 > 0)
            {
                tot += (double)InariNUD.Value / 5 * 10;
                tot += (double)InariNUD.Value % 5 * 2.25;
            }
            else if (InariNUD.Value % 5 == 0)
            {
                tot += (double)InariNUD.Value / 5 * 10;
            }

            //Sake
            if (SakeNUD.Value < 5)
            {
                tot += (double)SakeNUD.Value * 2.25;
            }
            else if (SakeNUD.Value % 5 > 0)
            {
                tot += (double)SakeNUD.Value / 5 * 10;
                tot += (double)SakeNUD.Value % 5 * 2.25;
            }
            else if (SakeNUD.Value % 5 == 0)
            {
                tot += (double)SakeNUD.Value / 5 * 10;
            }

            //Hokki Gai
            if (HokkiNUD.Value < 5)
            {
                tot += (double)HokkiNUD.Value * 2.25;
            }
            else if (HokkiNUD.Value % 5 > 0)
            {
                tot += (double)HokkiNUD.Value / 5 * 10;
                tot += (double)HokkiNUD.Value % 5 * 2.25;
            }
            else if (HokkiNUD.Value % 5 == 0)
            {
                tot += (double)HokkiNUD.Value / 5 * 10;
            }

            //Kani
            if (KaniNUD.Value < 5)
            {
                tot += (double)KaniNUD.Value * 2.25;
            }
            else if (KaniNUD.Value % 5 > 0)
            {
                tot += (double)KaniNUD.Value / 5 * 10;
                tot += (double)KaniNUD.Value % 5 * 2.25;
            }
            else if (KaniNUD.Value % 5 == 0)
            {
                tot += (double)KaniNUD.Value / 5 * 10;
            }

            //Scallop
            if (ScallopNUD.Value < 5)
            {
                tot += (double)ScallopNUD.Value * 2.25;
            }
            else if (ScallopNUD.Value % 5 > 0)
            {
                tot += (double)ScallopNUD.Value / 5 * 10;
                tot += (double)ScallopNUD.Value % 5 * 2.25;
            }
            else if (ScallopNUD.Value % 5 == 0)
            {
                tot += (double)ScallopNUD.Value / 5 * 10;
            }

            //Tobiko
            if (TobikoNUD.Value < 5)
            {
                tot += (double)TobikoNUD.Value * 2.25;
            }
            else if (TobikoNUD.Value % 5 > 0)
            {
                tot += (double)TobikoNUD.Value / 5 * 10;
                tot += (double)TobikoNUD.Value % 5 * 2.25;
            }
            else if (TobikoNUD.Value % 5 == 0)
            {
                tot += (double)TobikoNUD.Value / 5 * 10;
            }

            //Unagi
            if (UnagiNUD.Value < 5)
            {
                tot += (double)UnagiNUD.Value * 2.25;
            }
            else if (UnagiNUD.Value % 5 > 0)
            {
                tot += (double)UnagiNUD.Value / 5 * 10;
                tot += (double)UnagiNUD.Value % 5 * 2.25;
            }
            else if (UnagiNUD.Value % 5 == 0)
            {
                tot += (double)UnagiNUD.Value / 5 * 10;
            }

            //Seaweed Salad
            if (SeaweedNUD.Value < 5)
            {
                tot += (double)SeaweedNUD.Value * 2.25;
            }
            else if (SeaweedNUD.Value % 5 > 0)
            {
                tot += (double)SeaweedNUD.Value / 5 * 10;
                tot += (double)SeaweedNUD.Value % 5 * 2.25;
            }
            else if (SeaweedNUD.Value % 5 == 0)
            {
                tot += (double)SeaweedNUD.Value / 5 * 10;
            }


            //calculate all Ura-Maki items that customer ordered.
            tot += (double)numericUpDown401.Value * 5.50; //California
            tot += (double)numericUpDown402.Value * 5.50; //Avocumber
            tot += (double)numericUpDown403.Value * 5.50; //Fresh
            tot += (double)numericUpDown404.Value * 5.50; //Sweetie
            tot += (double)numericUpDown405.Value * 5.50; //Yam
            tot += (double)numericUpDown406.Value * 7.25; //Smoke Salmon
            tot += (double)numericUpDown407.Value * 7.95; //Negitoro
            tot += (double)numericUpDown408.Value * 5.95; //Dynamite
            tot += (double)numericUpDown409.Value * 5.50; //B.C.
            tot += (double)numericUpDown410.Value * 5.75; //Beff Teriyaki
            tot += (double)numericUpDown411.Value * 5.75; //Chicken Teriyaki
            tot += (double)numericUpDown412.Value * 6.25; //Unagi
            tot += (double)numericUpDown413.Value * 6.25; //Up

            //calculate all Soup items that customer ordered.
            tot += (double)numericUpDown501.Value * 2.00; //Miso Soup
            tot += (double)numericUpDown502.Value * 13.25; //Chicken/Beef/Tofu Udon
            tot += (double)numericUpDown503.Value * 14.95; //Tempura Udon

            //calculate all Stir-fry items that customer ordered.
            tot += (double)numericUpDown601.Value * 13.95; //Teriyaki Yakiudon
            tot += (double)numericUpDown602.Value * 14.25; //Siracha Honey Yakiudon
            tot += (double)numericUpDown603.Value * 13.95; //Terriyaki Donburi
            tot += (double)numericUpDown604.Value * 14.25; //House Spicy Donburi

            //calculate all Bento Box items that customer ordered.
            tot += (double)numericUpDown1.Value * 13.25; //Kyoto
            tot += (double)numericUpDown2.Value * 15.95; //Ninja
            tot += (double)numericUpDown3.Value * 18.25; //Tono
            tot += (double)numericUpDown4.Value * 15.25; //Samurai
            tot += (double)numericUpDown5.Value * 16.95; //Sumo

            //calculate all side items that customer ordered.
            tot += (double)RiceNUD.Value * 2.00; //Rice
            tot += (double)GWSmNUD.Value * 1.00; //Ginger/Wasabi/Spicy Mayo
            tot += (double)SoftNUD.Value * 2.00; //Soft Drink
            tot += (double)GTNUD.Value * 2.00; //Green Tea
            tot += (double)GTMicNUD.Value * 2.00; //Ice Cream

            //total plus tax
            tot = tot * 1.05; // BC tax rate

            SumLabel.Text = tot.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Value Clear
            numericUpDown101.Value = 0;
            numericUpDown102.Value = 0;
            numericUpDown103.Value = 0;
            numericUpDown104.Value = 0;
            numericUpDown105.Value = 0;
            numericUpDown106.Value = 0;
            numericUpDown107_1.Value = 0;
            numericUpDown107_2.Value = 0;
            numericUpDown108_1.Value = 0;
            numericUpDown108_2.Value = 0;
            numericUpDown108_3.Value = 0;
            numericUpDown109.Value = 0;
            numericUpDown201.Value = 0;
            numericUpDown202.Value = 0;
            numericUpDown203.Value = 0;
            numericUpDown204.Value = 0;
            numericUpDown205.Value = 0;
            numericUpDown206.Value = 0;
            numericUpDown207.Value = 0;
            numericUpDown208.Value = 0;
            numericUpDown209.Value = 0;
            numericUpDown210.Value = 0;
            numericUpDown301.Value = 0;
            numericUpDown302.Value = 0;
            numericUpDown303.Value = 0;
            numericUpDown304.Value = 0;
            numericUpDown304_1.Value = 0;
            numericUpDown304_2.Value = 0;
            numericUpDown401.Value = 0;
            numericUpDown402.Value = 0;
            numericUpDown403.Value = 0;
            numericUpDown404.Value = 0;
            numericUpDown405.Value = 0;
            numericUpDown406.Value = 0;
            numericUpDown407.Value = 0;
            numericUpDown408.Value = 0;
            numericUpDown409.Value = 0;
            numericUpDown410.Value = 0;
            numericUpDown411.Value = 0;
            numericUpDown412.Value = 0;
            numericUpDown413.Value = 0;
            numericUpDown501.Value = 0;
            numericUpDown502.Value = 0;
            numericUpDown503.Value = 0;
            numericUpDown601.Value = 0;
            numericUpDown602.Value = 0;
            numericUpDown603.Value = 0;
            numericUpDown604.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            RiceNUD.Value = 0;
            GWSmNUD.Value = 0;
            SoftNUD.Value = 0;
            GTNUD.Value = 0;
            GTMicNUD.Value = 0;
            TunaNUD.Value = 0;
            EbiNUD.Value = 0;
            TaiNUD.Value = 0;
            TamagoNUD.Value = 0;
            InariNUD.Value = 0;
            SakeNUD.Value = 0;
            HokkiNUD.Value = 0;
            KaniNUD.Value = 0;
            ScallopNUD.Value = 0;
            TobikoNUD.Value = 0;
            UnagiNUD.Value = 0;
            SeaweedNUD.Value = 0;
        }
    }
}
