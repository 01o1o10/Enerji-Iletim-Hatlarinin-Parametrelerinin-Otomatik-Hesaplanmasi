using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double GMR, GMRd, GMD;
        double d;
        double r, rd;
        double L, C;
        double GMRa, GMRb, GMRc, GMRL, ra, rb, rc, rK;

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        Direk direk = new Direk();

        double Da1a2, Db1b2, Dc1c2, Dab, Dbc, Dac;
        double a1b1, a1b2, a2b1, a2b2, b1c1, b1c2, b2c1, b2c2, a1c1, a1c2, a2c1, a2c2;

        bool ciftDevre = false;


        private void iletkenTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (iletkenTipi.Text)
            {
                case "Stilt": GMR = 10.58; r = 26.31 / 2.0; break;
                case "Grebe": GMR = 10.18; r = 25.63 / 2.0; break;
                case "Gannet": GMR = 10.45; r = 25.76 / 2.0; break;
                case "Gull": GMR = 10.27; r = 25.4 / 2.0; break;
                case "Flamingo": GMR = 10.21; r = 25.4 / 2.0; break;
                case "Scoter": GMR = 10.70; r = 25.88 / 2.0; break;
                case "Egret": GMR = 10.70; r = 25.88 / 2.0; break;
                case "Grosbeak": GMR = 10.21; r = 25.15 / 2.0; break;
                case "Goose": GMR = 10.06; r = 24.82 / 2.0; break;
                case "Rook": GMR = 10.06; r = 24.82 / 2.0; break;
                case "Kingbind": GMR = 9.27; r = 23.88 / 2.0; break;
                case "Swirl": GMR = 9.20; r = 23.62 / 2.0; break;
                case "Wood Duck": GMR = 10.42; r = 25.25 / 2.0; break;
                case "Teal": GMR = 10.42; r = 25.25 / 2.0; break;
                case "Squab": GMR = 9.97; r = 25.54 / 2.0; break;
                case "Peacock": GMR = 9.72; r = 24.21 / 2.0; break;
                case "Duck": GMR = 9.81; r = 24.21 / 2.0; break;
                case "Eagle": GMR = 10.00; r = 24.21 / 2.0; break;
                case "Dove": GMR = 9.54; r = 23.55 / 2.0; break;
                case "Parakeet": GMR = 9.33; r = 23.22 / 2.0; break;
                case "Osprey": GMR = 8.66; r = 22.33 / 2.0; break;
                case "Hen": GMR = 9.27; r = 22.43 / 2.0; break;
                case "Hawk": GMR = 8.84; r = 21.79 / 2.0; break;
                case "Flicker": GMR = 8.63; r = 21.49 / 2.0; break;
                case "Pelican": GMR = 8.02; r = 20.68 / 2.0; break;
                case "Lark": GMR = 8.44; r = 20.47 / 2.0; break;
                case "Ibis": GMR = 8.08; r = 19.89 / 2.0; break;
                case "Brant": GMR = 7.89; r = 19.61 / 2.0; break;
                case "Chickadee": GMR = 7.32; r = 18.87 / 2.0; break;
                case "Oriole": GMR = 7.77; r = 18.82 / 2.0; break;
                case "Linnet": GMR = 7.41; r = 18.29 / 2.0; break;
                case "Widgeom": GMR = 7.25; r = 18.03 / 2.0; break;
                case "Merlin": GMR = 6.74; r = 16.46 / 2.0; break;
                case "Piper": GMR = 7.35; r = 17.78 / 2.0; break;
                case "Ostrich": GMR = 7.01; r = 17.27 / 2.0; break;
                case "Gadwall": GMR = 6.86; r = 17.04 / 2.0; break;
                case "Phobe": GMR = 6.37; r = 16.41 / 2.0; break;
                case "Junco": GMR = 6.92; r = 16.76 / 2.0; break;
                case "Partridge": GMR = 6.61; r = 16.31 / 2.0; break;
                case "Waxwing": GMR = 6.00; r = 15.47 / 2.0; break;
                case "Drake": GMR = 11.37; r = 28.11 / 2.0; break;
            }
        }
        
        public void direkOku()
        {
            String dosyaYolu = "veri.txt";
            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            String line = "";
            line = sr.ReadLine();
            while (line != null)
            {
                String[] split = line.Split(' ');
                if (string.Compare(direkTipi.Text, split[0]) == 0)
                {
                    switch (split[1])
                    {
                        case "1":
                            direk.direkTipi = split[0];
                            direk.devreTipi = Convert.ToInt32(split[1]);
                            direk.f = Convert.ToDouble(split[2]);//y
                            direk.d = Convert.ToDouble(split[3]);//x
                            direk.g = Convert.ToDouble(split[4]);//j
                            break;
                        case "2":
                            direk.direkTipi = split[0];
                            direk.devreTipi = Convert.ToInt32(split[1]);
                            direk.d = Convert.ToDouble(split[2]);
                            direk.f = Convert.ToDouble(split[3]);
                            direk.g = Convert.ToDouble(split[4]);
                            direk.h = Convert.ToDouble(split[5]);
                            direk.k = Convert.ToDouble(split[6]);
                            break;
                        case "3":
                            direk.direkTipi = split[0];
                            direk.devreTipi = Convert.ToInt32(split[1]);
                            direk.f = Convert.ToDouble(split[2]);//y
                            direk.d = Convert.ToDouble(split[3]);//x
                            break;
                        case "4":
                            direk.direkTipi = split[0];
                            direk.devreTipi = Convert.ToInt32(split[1]);
                            direk.d = Convert.ToDouble(split[2]);//x
                            break;
                    }
                }
                line = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            direkOku();
            Console.WriteLine(direk.direkTipi);
            Console.WriteLine(direk.devreTipi);
            Console.WriteLine(direk.d);
            Console.WriteLine(direk.f);
            Console.WriteLine(direk.g);
            Console.WriteLine(direk.h);
            Console.WriteLine(direk.k);

            if (string.Compare(dau.Text, "") != 0)
            {
                d = Convert.ToDouble(dau.Text) * 10;
            }
            else
            {
                d = 1.0;
            }

            if (tekDemet.Checked)
            {
                GMRd = GMR;
                rd = r;
            }
            if (ciftDemet.Checked)
            {
                GMRd = Math.Pow(GMR * d * d, (1.0 / 2.0));
                rd = Math.Pow(r * d, (1.0 / 2.0));
            }
            if (ucDemet.Checked)
            {
                GMRd = Math.Pow(GMR * d * d, (1.0 / 3.0));
                rd = Math.Pow(r * d, (1.0 / 3.0));
            }
            if (dortDemet.Checked)
            {
                GMRd = Math.Pow(GMR * d * d, (1.0 / 4.0));
                rd = Math.Pow(r * d, (1.0 / 4.0)) * 1.09;
            }
            Console.WriteLine("GMRd: " + GMRd + " rd: " + rd);

            if (direk.devreTipi == 1)
            {
                double a = direk.f * 2;
                double b = Math.Sqrt(Math.Pow(direk.d + direk.f, 2) + direk.g * direk.g);
                double c = Math.Sqrt(Math.Pow(direk.f - direk.d, 2) + direk.g * direk.g);

                direk.GMD = Math.Pow(a * b * c, (1.0 / 3.0));

                L = 0.2 * Math.Log(direk.GMD * 1000 / GMRd);
                C = 0.0556 / (Math.Log((direk.GMD * 1000) / rd));
            }
            else if (direk.devreTipi == 2)
            {
                a1b1 = Math.Sqrt(Math.Pow((direk.f - direk.d), 2) + direk.h * direk.h);
                a1b2 = Math.Sqrt(Math.Pow((direk.d + direk.f), 2) + direk.h * direk.h);
                a2b1 = Math.Sqrt(Math.Pow((direk.f + direk.g), 2) + direk.k * direk.k);
                a2b2 = Math.Sqrt(Math.Pow((direk.f - direk.g), 2) + direk.k * direk.k);
                Dab = Math.Pow((a1b1 * a1b2 * a2b1 * a2b2), (1.0 / 4.0));


                b1c1 = Math.Sqrt(Math.Pow((direk.f - direk.g), 2) + direk.k * direk.k);
                b1c2 = Math.Sqrt(Math.Pow((direk.d + direk.f), 2) + direk.h * direk.h);
                b2c1 = Math.Sqrt(Math.Pow((direk.f + direk.g), 2) + direk.k * direk.k);
                b2c2 = Math.Sqrt(Math.Pow((direk.f - direk.d), 2) + direk.h * direk.h);
                Dbc = Math.Pow((b1c1 * b1c2 * b2c1 * b2c2), (1.0 / 4.0));


                a1c1 = Math.Sqrt(Math.Pow((direk.g - direk.d), 2) + Math.Pow((direk.h + direk.k), 2));
                a1c2 = 2 * direk.d;
                a2c1 = 2 * direk.g;
                a2c2 = Math.Sqrt(Math.Pow((direk.g - direk.d), 2) + Math.Pow((direk.h + direk.k), 2));
                Dac = Math.Pow((a1c1 * a1c2 * a2c1 * a2c2), (1.0 / 4.0));

                direk.GMD = Math.Pow(Dab * Dbc * Dac, (1.0 / 3.0));

                Da1a2 = Math.Sqrt(Math.Pow(direk.d + direk.g, 2) + Math.Pow(direk.h + direk.k, 2));
                Db1b2 = 2 * direk.f;
                Dc1c2 = Da1a2;

                GMRa = Math.Sqrt(GMRd * Da1a2 * 1000);
                ra = Math.Sqrt(rd * Da1a2 * 1000);

                GMRb = Math.Sqrt(GMRd * Db1b2 * 1000);
                rb = Math.Sqrt(rd * Db1b2 * 1000);

                GMRc = Math.Sqrt(GMRd * Dc1c2 * 1000);
                rc = Math.Sqrt(rd * Dc1c2 * 1000);

                GMRL = Math.Pow(GMRa * GMRb * GMRc, (1.0 / 3.0));
                rK = Math.Pow(ra * rb * rc, (1.0 / 3.0));

                L = 0.2 * Math.Log(direk.GMD * 1000 / GMRd);
                C = 0.0556 / (Math.Log(direk.GMD * 1000 / rK));
            }
            else if (direk.devreTipi == 3)
            {
                double a = 2 * direk.f;
                double b = Math.Sqrt(direk.d * direk.d + direk.f * direk.f);
                double c = Math.Sqrt(direk.d * direk.d + direk.f * direk.f);

                direk.GMD = Math.Pow(a * b * c, (1.0 / 3.0));

                L = 0.2 * Math.Log(direk.GMD * 1000 / GMRd);
                C = 0.0556 / (Math.Log((direk.GMD * 1000) / rd));
            }
            else if (direk.devreTipi == 4)
            {
                double a = direk.d;
                double b = direk.d;
                double c = 2 * direk.d;

                direk.GMD = Math.Pow(a * b * c, (1.0 / 3.0));

                L = 0.2 * Math.Log(direk.GMD * 1000 / GMRd);
                C = 0.0556 / (Math.Log((direk.GMD * 1000) / rd));
            }
            Console.WriteLine("GMD: " + direk.GMD);
            kl.Text = "L=" + Math.Round(L, 2);
            kc.Text = "C=" + Math.Round(C, 2);
            L *= Math.Pow(10, -3);
            C *= Math.Pow(10, -6);

            Hat kisaHat = new Hat();
            Hat ortaUzunHat = new Hat();
            Hat ortaUzunHatT = new Hat();
            Hat uzunHat = new Hat();

            if (string.Compare(uzunluk.Text, "") != 0) {
                double omega = 2 * Math.PI * 50 * L;
                
                double Z = omega * Convert.ToDouble(uzunluk.Text);
                kisaHat.A = 1;
                kisaHat.B = Z;
                kisaHat.C = 0;
                kisaHat.D = 1;

                kisahat_a.Text = kisaHat.A.ToString();
                kisahat_b.Text = Math.Round(kisaHat.B, 2).ToString();
                kisahat_c.Text = kisaHat.C.ToString();
                kisahat_d.Text = kisaHat.D.ToString();

                double omegaC = 2 * Math.PI * 50 * C;
                double Y = omegaC;

                ortaUzunHat.A = (1 + (Z * Y / 2));
                ortaUzunHat.B = Z;
                ortaUzunHat.C = (Y + (Z * Y * Y / 2));
                ortaUzunHat.D = (1 + (Z * Y / 2));

                ortauzunhat_a.Text = Math.Round(ortaUzunHat.A, 2).ToString();
                ortauzunhat_b.Text = Math.Round(ortaUzunHat.B, 2).ToString();
                ortauzunhat_c.Text = Math.Round(ortaUzunHat.C, 2).ToString();
                ortauzunhat_d.Text = Math.Round(ortaUzunHat.D, 2).ToString();


                ortaUzunHatT.A = (1 + (Z * Y / 2));
                ortaUzunHatT.B = Y;
                ortaUzunHatT.C = (Z + (Z * Z * Y / 4));
                ortaUzunHatT.D = (1 + (Z * Y / 2));

                ortauzunhatt_a.Text = Math.Round(ortaUzunHatT.A, 2).ToString();
                ortauzunhatt_b.Text = Math.Round(ortaUzunHatT.B, 2).ToString();
                ortauzunhatt_c.Text = Math.Round(ortaUzunHatT.C, 2).ToString();
                ortauzunhatt_d.Text = Math.Round(ortaUzunHatT.D, 2).ToString();

                double sayi = Math.Sqrt(L * C ) * 360 * 50 * Convert.ToDouble(uzunluk.Text);
                Complex gamma = new Complex(0, sayi);

                double Zc = Math.Sqrt(L / C);


                uzunHat.A = Complex.Cosh(gamma).Real;
                uzunHat.B = Complex.Sinh(gamma).Real * Zc;
                uzunHat.C = Complex.Sinh(gamma).Real / Zc;
                uzunHat.D = Complex.Cosh(gamma).Real;

                uzunhat_a.Text = "[" + Math.Round(uzunHat.A, 2).ToString() + "]";
                uzunhat_b.Text = "[" + Math.Round(uzunHat.B, 2).ToString() + "]";
                uzunhat_c.Text = "[" + Math.Round(uzunHat.C, 2).ToString() + "]";
                uzunhat_d.Text = "[" + Math.Round(uzunHat.D, 2).ToString() + "]";
            }

            double U2 = Convert.ToDouble(this.hatsonugerilimi.Text);
            double s2 = (U2 * U2) / Math.Sqrt(L/C);
            double I = s2 / (3 * U2);

            if (string.Compare(guckatsayisi.Text, "") != 0 && string.Compare(katsayitipi.Text, "") != 0)
            {
                double gucKatsayisi = Convert.ToDouble(guckatsayisi.Text);
                double deger;
                if (string.Compare(katsayitipi.Text, "Kapasitif") == 0)
                {
                    deger = Math.Sin(Math.Acos(gucKatsayisi));
                }
                else
                {
                    deger = (-1) * Math.Sin(Math.Acos(gucKatsayisi));
                }
                double real = I * gucKatsayisi;
                double imajiner = I * deger;

                Complex I2 = new Complex(real, imajiner);
                Complex imgZ = new Complex(0, kisaHat.B);
                kisaHat.U1 = new Complex();
                kisaHat.U1 = U2 + Complex.Multiply(imgZ, I2);
                kisaHat.I1 = new Complex(I2.Real, I2.Imaginary);

                kisahat_u1.Text = "U1: " + Math.Round(kisaHat.U1.Real, 2).ToString() + "," + Math.Round(kisaHat.U1.Imaginary, 2).ToString();
                kisahat_i1.Text = "I1: " + Math.Round(kisaHat.I1.Real, 2).ToString() + "," + Math.Round(kisaHat.I1.Imaginary, 2).ToString();
                u2.Text = "U2: " + U2.ToString();
                i2.Text = "I1: " + Math.Round(I2.Real, 2).ToString() + "," + Math.Round(I2.Imaginary, 2).ToString();

                ortaUzunHat.U1 = new Complex();
                ortaUzunHat.U1 = ortaUzunHat.A * U2 + Complex.Multiply(new Complex(0, ortaUzunHat.B), I2);
                ortaUzunHat.I1 = U2 * new Complex(0, ortaUzunHat.C) + ortaUzunHat.D * I2;

                ortauzunhat_u1.Text = "U1: " + Math.Round(kisaHat.U1.Real, 2).ToString() + "," + Math.Round(kisaHat.U1.Imaginary, 2).ToString();
                ortauzunhat_i1.Text = "I1: " + Math.Round(uzunHat.I1.Real, 2).ToString() + "," + Math.Round(uzunHat.I1.Imaginary, 2).ToString();
                
                uzunHat.U1 = new Complex();
                uzunHat.U1 = uzunHat.A * uzunHat.B * I2;
                uzunHat.I1 = U2 * uzunHat.C + uzunHat.D * I2;

                uzunhat_u1.Text = "U1: " + Math.Round(kisaHat.U1.Real, 2).ToString() + "," + Math.Round(kisaHat.U1.Imaginary, 2).ToString();
                uzunhat_i1.Text = "I1: " + Math.Round(uzunHat.I1.Real, 2).ToString() + "," + Math.Round(uzunHat.I1.Imaginary, 2).ToString();

                double P2 = s2 * gucKatsayisi;
                double Q2 = s2 * Math.Sin(Math.Acos(gucKatsayisi));

                kisaHat.S1 = 3 * Complex.Multiply(kisaHat.U1, kisaHat.I1);
                kisaHat.P1 = kisaHat.S1.Real;
                kisaHat.Q1 = kisaHat.S1.Imaginary;

                ortaUzunHat.S1 = 3 * Complex.Multiply(ortaUzunHat.U1, ortaUzunHat.I1);
                ortaUzunHat.P1 = ortaUzunHat.S1.Real;
                ortaUzunHat.Q1 = ortaUzunHat.S1.Imaginary;

                uzunHat.S1 = 3 * Complex.Multiply(uzunHat.U1, uzunHat.I1);
                uzunHat.P1 = uzunHat.S1.Real;
                uzunHat.Q1 = uzunHat.S1.Imaginary;

                p2.Text = P2.ToString();
                q2.Text = Q2.ToString();

                kisahat_p1.Text = kisaHat.P1.ToString();
                kisahat_q1.Text = kisaHat.Q1.ToString();

                ortauzunhat_p1.Text = ortaUzunHat.P1.ToString();
                ortauzunhat_q1.Text = ortaUzunHat.Q1.ToString();

                uzunhat_p1.Text = uzunHat.P1.ToString();
                uzunhat_q1.Text = uzunHat.Q1.ToString();

                kisaHat.M = (P2 / kisaHat.P1) * 100;
                kisaHat.VR = ((Math.Sqrt(kisaHat.U1.Real * kisaHat.U1.Real + kisaHat.U1.Imaginary * kisaHat.U1.Imaginary) / kisaHat.A) - U2) / U2;

                ortaUzunHat.M = (P2 / ortaUzunHat.P1) * 100;
                ortaUzunHat.VR = ((Math.Sqrt(ortaUzunHat.U1.Real * ortaUzunHat.U1.Real + ortaUzunHat.U1.Imaginary * ortaUzunHat.U1.Imaginary) / ortaUzunHat.A) - U2) / U2;

                uzunHat.M = (P2 / uzunHat.P1) * 100;
                uzunHat.VR = ((Math.Sqrt(uzunHat.U1.Real * uzunHat.U1.Real + uzunHat.U1.Imaginary * uzunHat.U1.Imaginary) / uzunHat.A) - U2) / U2;

                kisahat_m.Text = kisaHat.M.ToString();
                kisahat_vr.Text = kisaHat.VR.ToString();

                ortauzunhat_m.Text = ortaUzunHat.M.ToString();
                ortauzunhat_vr.Text = ortaUzunHat.VR.ToString();

                uzunhat_m.Text = uzunHat.M.ToString();
                uzunhat_vr.Text = uzunHat.VR.ToString();
            }



        }



        private void v(object sender, EventArgs e)
        {

        }


    }

    class Direk
    {
        public String direkTipi;
        public double d = 0, f = 0, g = 0, h = 0, k = 0;
        public int devreTipi;
        public double GMD;
    }

    class Hat
    {
        public double A = 0;
        public double B = 0;
        public double C = 0;
        public double D = 0;
        public Complex U1;
        public Complex I1;
        public Complex S1;
        public double P1;
        public double Q1;
        public double M;
        public double VR;
    }
}
