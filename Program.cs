using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopsisUniversiteGirisOnceligi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek-1 üniversite yerleşim önceliği

            var alternatiflerO1 = new List<Alternatif>()
            {
                new Alternatif{ Id = 1, Adi = "Ahmet"},
                new Alternatif{ Id = 2, Adi = "Mehmet"},
                new Alternatif{ Id = 3, Adi = "Murat"},
                new Alternatif{ Id = 4, Adi = "Kemal"},
                new Alternatif{ Id = 5, Adi = "Fatih"},
                new Alternatif{ Id = 6, Adi = "Ferhat"},
                new Alternatif{ Id = 7, Adi = "Kerem"},
            };

            var kriterlerO1 = new List<Kriter>() {
                new Kriter{ Id = 1, Adi = "Öss Puanı", Agirlik = 0.4},
                new Kriter{ Id = 2, Adi = "Diploma Notu", Agirlik = 0.2},
                new Kriter{ Id = 3, Adi = "Mezun Öğrenci Ortalaması", Agirlik = 0.1},
                new Kriter{ Id = 4, Adi = "Öğrenci Derecesi", Agirlik = 0.17, MaliyetBazliMi = true},
                new Kriter{ Id = 5, Adi = "Okul Başarısı % Yerleştirme", Agirlik = 0.13},
            };

            var topsisTablosuO1 = new List<TopsisTablo>
            {
               new TopsisTablo{ KriterId = 1, AlternatifId= 1, Deger = 348},
               new TopsisTablo{ KriterId = 1, AlternatifId= 2, Deger = 330},
               new TopsisTablo{ KriterId = 1, AlternatifId= 3, Deger = 345},
               new TopsisTablo{ KriterId = 1, AlternatifId= 4, Deger = 335},
               new TopsisTablo{ KriterId = 1, AlternatifId= 5, Deger = 338},
               new TopsisTablo{ KriterId = 1, AlternatifId= 6, Deger = 350},
               new TopsisTablo{ KriterId = 1, AlternatifId= 7, Deger = 352},

               new TopsisTablo{ KriterId = 2, AlternatifId= 1, Deger = 4.8},
               new TopsisTablo{ KriterId = 2, AlternatifId= 2, Deger = 3.0},
               new TopsisTablo{ KriterId = 2, AlternatifId= 3, Deger = 3.7},
               new TopsisTablo{ KriterId = 2, AlternatifId= 4, Deger = 4.3},
               new TopsisTablo{ KriterId = 2, AlternatifId= 5, Deger = 4.0},
               new TopsisTablo{ KriterId = 2, AlternatifId= 6, Deger = 4.7},
               new TopsisTablo{ KriterId = 2, AlternatifId= 7, Deger = 4.9},

               new TopsisTablo{ KriterId = 3, AlternatifId= 1, Deger = 3.00},
               new TopsisTablo{ KriterId = 3, AlternatifId= 2, Deger = 3.25},
               new TopsisTablo{ KriterId = 3, AlternatifId= 3, Deger = 3.50},
               new TopsisTablo{ KriterId = 3, AlternatifId= 4, Deger = 4.00},
               new TopsisTablo{ KriterId = 3, AlternatifId= 5, Deger = 3.50},
               new TopsisTablo{ KriterId = 3, AlternatifId= 6, Deger = 4.80},
               new TopsisTablo{ KriterId = 3, AlternatifId= 7, Deger = 4.50},

               new TopsisTablo{ KriterId = 4, AlternatifId= 1, Deger = 5},
               new TopsisTablo{ KriterId = 4, AlternatifId= 2, Deger = 40},
               new TopsisTablo{ KriterId = 4, AlternatifId= 3, Deger = 20},
               new TopsisTablo{ KriterId = 4, AlternatifId= 4, Deger = 15},
               new TopsisTablo{ KriterId = 4, AlternatifId= 5, Deger = 18},
               new TopsisTablo{ KriterId = 4, AlternatifId= 6, Deger = 10},
               new TopsisTablo{ KriterId = 4, AlternatifId= 7, Deger = 2},

               new TopsisTablo{ KriterId = 5, AlternatifId= 1, Deger = 50},
               new TopsisTablo{ KriterId = 5, AlternatifId= 2, Deger = 40},
               new TopsisTablo{ KriterId = 5, AlternatifId= 3, Deger = 35},
               new TopsisTablo{ KriterId = 5, AlternatifId= 4, Deger = 45},
               new TopsisTablo{ KriterId = 5, AlternatifId= 5, Deger = 30},
               new TopsisTablo{ KriterId = 5, AlternatifId= 6, Deger = 70},
               new TopsisTablo{ KriterId = 5, AlternatifId= 7, Deger = 80},
            };

            #endregion

            #region örnek-2 

            var alternatiflerO2 = new List<Alternatif>()
            {
                new Alternatif{ Id = 1, Adi = "A1" },
                new Alternatif{ Id = 2, Adi = "A2" },
                new Alternatif{ Id = 3, Adi = "A3" }
            };

            var kriterlerO2 = new List<Kriter>() {
                new Kriter{ Id = 1, Adi = "K1", Agirlik = 0.20},
                new Kriter{ Id = 2, Adi = "K2", Agirlik = 0.15},
                new Kriter{ Id = 3, Adi = "K3", Agirlik = 0.40},
                new Kriter{ Id = 4, Adi = "K4", Agirlik = 0.25},
            };

            var topsisTablosuO2 = new List<TopsisTablo>
            {
               new TopsisTablo{ KriterId = 1, AlternatifId= 1, Deger = 25},
               new TopsisTablo{ KriterId = 1, AlternatifId= 2, Deger = 10},
               new TopsisTablo{ KriterId = 1, AlternatifId= 3, Deger = 30},

               new TopsisTablo{ KriterId = 2, AlternatifId= 1, Deger = 20},
               new TopsisTablo{ KriterId = 2, AlternatifId= 2, Deger = 30},
               new TopsisTablo{ KriterId = 2, AlternatifId= 3, Deger = 10},

               new TopsisTablo{ KriterId = 3, AlternatifId= 1, Deger = 15},
               new TopsisTablo{ KriterId = 3, AlternatifId= 2, Deger = 20},
               new TopsisTablo{ KriterId = 3, AlternatifId= 3, Deger = 30},

               new TopsisTablo{ KriterId = 4, AlternatifId= 1, Deger = 30},
               new TopsisTablo{ KriterId = 4, AlternatifId= 2, Deger = 30},
               new TopsisTablo{ KriterId = 4, AlternatifId= 3, Deger = 10}
            };

            #endregion

            var alternatifler = alternatiflerO2;

            var kriterler = kriterlerO2;

            var topsisTablosu = topsisTablosuO2;

            var sonuclar = TopsisHesapla(alternatifler, kriterler, topsisTablosu);

            EkranaYazdirKararMatrisi(topsisTablosu, "karar matrisi: A matrisi");
            EkranaYazdirNormalizeDegerler(topsisTablosu, "normalize değerler: R matrisi");
            EkranaYazdirNormalizeDegerlerAgirlikli(topsisTablosu, "normalize değerler (ağırlıklı): V matrisi");
            EkranaYazdirKriterler(kriterler, "İdeal çözüm kümesi: A*, A-");
            EkranaYazdirIdealUzakliklar(topsisTablosu, "ideal uzaklıklar");

            Console.WriteLine();
            Console.WriteLine("****** Sonuçlar ******");
            Console.WriteLine();

            EkranaYazdirAlternatifler(sonuclar, "Adı, S*, S-, C");

            Console.ReadLine();
        }

        private static List<Alternatif> TopsisHesapla(List<Alternatif> alternatifler, List<Kriter> kriterler, List<TopsisTablo> topsisTablosu)
        {
            foreach (var kriter in kriterler)
            {
                var kriterSutunu = topsisTablosu.Where(w => w.KriterId == kriter.Id);

                var kriterdekiDegerler = Math.Round(Math.Sqrt(kriterSutunu.Sum(s => Math.Pow(s.Deger, 2))), 4);

                foreach (var alternatif in alternatifler)
                {
                    var topsisTabloVeri = topsisTablosu.SingleOrDefault(x => x.AlternatifId == alternatif.Id && x.KriterId == kriter.Id);

                    topsisTabloVeri.NormalizeDeger = Math.Round(topsisTabloVeri.Deger / kriterdekiDegerler, 4);

                    topsisTabloVeri.AgirlikliNormalizeDeger = Math.Round(topsisTabloVeri.NormalizeDeger * kriter.Agirlik, 4);
                }

                kriter.IdealCozumDegeri = kriter.MaliyetBazliMi ? kriterSutunu.Min(x => x.AgirlikliNormalizeDeger) : kriterSutunu.Max(x => x.AgirlikliNormalizeDeger);

                kriter.IdealCozumDegeriNegatif = kriter.MaliyetBazliMi ? kriterSutunu.Max(x => x.AgirlikliNormalizeDeger) : kriterSutunu.Min(x => x.AgirlikliNormalizeDeger);

                foreach (var alternatif in alternatifler)
                {
                    var topsisTabloVeri = topsisTablosu.SingleOrDefault(x => x.AlternatifId == alternatif.Id && x.KriterId == kriter.Id);

                    topsisTabloVeri.IdealUzaklikPozitif = Math.Abs(Math.Round(kriter.IdealCozumDegeri - topsisTabloVeri.AgirlikliNormalizeDeger, 4));

                    topsisTabloVeri.IdealUzaklikNegatif = Math.Abs(Math.Round(topsisTabloVeri.AgirlikliNormalizeDeger - kriter.IdealCozumDegeriNegatif, 4));
                }
            }

            foreach (var alternatif in alternatifler)
            {
                var alternatifSatiri = topsisTablosu.Where(w => w.AlternatifId == alternatif.Id).ToList();

                alternatif.IdealCozumdenUzaklikSPozitif = Math.Round(Math.Sqrt(alternatifSatiri.Sum(x => Math.Pow(x.IdealUzaklikPozitif, 2))), 4);

                alternatif.IdealCozumdenUzaklikSNegatif = Math.Round(Math.Sqrt(alternatifSatiri.Sum(x => Math.Pow(x.IdealUzaklikNegatif, 2))), 4);

                alternatif.IdealCozumdenUzaklikC = Math.Round(alternatif.IdealCozumdenUzaklikSNegatif / (alternatif.IdealCozumdenUzaklikSNegatif + alternatif.IdealCozumdenUzaklikSPozitif), 4);
            }

            //var i = 1;

            var siraliListe = alternatifler.OrderByDescending(o => o.IdealCozumdenUzaklikC).ToList();

            return siraliListe;

            //foreach (var alternatif in sonSiralama)
            //{
            //    Console.WriteLine($"{i}. {alternatif.Adi}, C={alternatif.IdealCozumdenUzaklikC}");

            //    i++;
            //}
        }

        class Alternatif
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public double IdealCozumdenUzaklikSPozitif { get; set; }
            public double IdealCozumdenUzaklikSNegatif { get; set; }
            public double IdealCozumdenUzaklikC { get; set; }
        }

        class Kriter
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public double Agirlik { get; set; }
            public bool MaliyetBazliMi { get; set; }
            public double IdealCozumDegeri { get; set; }
            public double IdealCozumDegeriNegatif { get; set; }
        }

        class TopsisTablo
        {
            public int AlternatifId { get; set; }
            public int KriterId { get; set; }
            public double Deger { get; set; }
            public double NormalizeDeger { get; set; }
            public double AgirlikliNormalizeDeger { get; set; }
            public double IdealUzaklikPozitif { get; set; }
            public double IdealUzaklikNegatif { get; set; }
        }

        private static void EkranaYazdirKararMatrisi(List<TopsisTablo> topsisTablosu, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            var rows = topsisTablosu.Select(s => s.AlternatifId).Distinct().ToList();
            var cols = topsisTablosu.Select(s => s.KriterId).Distinct().ToList();

            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    Console.Write(topsisTablosu.SingleOrDefault(x => x.AlternatifId == row && x.KriterId == col).Deger + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------");
        }

        private static void EkranaYazdirNormalizeDegerler(List<TopsisTablo> topsisTablosu, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            var rows = topsisTablosu.Select(s => s.AlternatifId).Distinct().ToList();
            var cols = topsisTablosu.Select(s => s.KriterId).Distinct().ToList();

            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    Console.Write(topsisTablosu.SingleOrDefault(x => x.AlternatifId == row && x.KriterId == col).NormalizeDeger + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------");
        }

        private static void EkranaYazdirNormalizeDegerlerAgirlikli(List<TopsisTablo> topsisTablosu, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            var rows = topsisTablosu.Select(s => s.AlternatifId).Distinct().ToList();
            var cols = topsisTablosu.Select(s => s.KriterId).Distinct().ToList();

            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    Console.Write(topsisTablosu.SingleOrDefault(x => x.AlternatifId == row && x.KriterId == col).AgirlikliNormalizeDeger + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------");
        }

        private static void EkranaYazdirIdealUzakliklar(List<TopsisTablo> topsisTablosu, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            var rows = topsisTablosu.Select(s => s.AlternatifId).Distinct().ToList();
            var cols = topsisTablosu.Select(s => s.KriterId).Distinct().ToList();

            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    var idealUzaklik = topsisTablosu.SingleOrDefault(x => x.AlternatifId == row && x.KriterId == col);

                    Console.Write(idealUzaklik.IdealUzaklikPozitif + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------");

            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    var idealUzaklik = topsisTablosu.SingleOrDefault(x => x.AlternatifId == row && x.KriterId == col);

                    Console.Write(idealUzaklik.IdealUzaklikNegatif + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------");
        }

        private static void EkranaYazdirKriterler(List<Kriter> kriterler, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            foreach (var kriter in kriterler)
            {
                Console.WriteLine(kriter.IdealCozumDegeri + ", " + kriter.IdealCozumDegeriNegatif);
            }

            Console.WriteLine("-------------");
        }

        private static void EkranaYazdirAlternatifler(List<Alternatif> alternatifler, string aciklama = null)
        {
            if (aciklama != null)
            {
                Console.WriteLine(aciklama);
                Console.WriteLine();
            }

            var i = 1;

            foreach (var alternatif in alternatifler)
            {
                Console.WriteLine(i + " " + alternatif.Adi + ", " + alternatif.IdealCozumdenUzaklikSPozitif + ", " + alternatif.IdealCozumdenUzaklikSNegatif + ", " + alternatif.IdealCozumdenUzaklikC);

                i++;
            }

            Console.WriteLine("-------------");
        }
    }
}

/*

    var topsisTablo = new double[,]
            {
                { 348, 4.8, 3.00, 5,  50 },
                { 330, 3.0, 3.25, 40, 40 },
                { 345, 3.7, 3.50, 20, 35 },
                { 335, 4.3, 4.00, 15, 45 },
                { 338, 4.0, 3.50, 18, 30 },
                { 350, 4.7, 4.80, 10, 70 },
                { 352, 4.9, 4.50, 2,  80 }
            };

    double[,] r = null;
            double[] karelerinToplamlari = null;
            double[,] v = null;
            double[] kriterAgirliklari = { 0.4, 0.2, 0.1, 0.17, 0.13 };
            double toplamAgirlik = 0;

            for (int i = 0; i < kriterAgirliklari.Length; i++)
            {
                toplamAgirlik += kriterAgirliklari[i];
            };

            if (toplamAgirlik != 1)
            {
                throw new Exception($"Kriter ağırlıklarının toplamı 1 olalıdır. ({toplamAgirlik})");
            }

            //karelerin toplamlarını hesapla
            for (int j = 0; j < topsisTablo.GetLength(1); j++)
            {
                var karelerinToplami = 1.0;

                for (int i = 0; i < topsisTablo.GetLength(0); i++)
                {
                    karelerinToplami += Math.Exp(topsisTablo[i, j]);
                }

                karelerinToplamlari[j] = karelerinToplami;
            }

            //tablonun normalize edilmesi r(i,j)
            for (int j = 0; j < topsisTablo.GetLength(1); j++)
            {
                var sutundakiIlkDeger = topsisTablo[0, j];

                for (int i = 0; i < topsisTablo.GetLength(0); i++)
                {
                    r[j, j] = sutundakiIlkDeger / Math.Sqrt(karelerinToplamlari[j]);
                }
            }

            //ağırlıklı normalize matris (Vij)
            for (int j = 0; j < topsisTablo.GetLength(1); j++)
            {
                for (int i = 0; i < topsisTablo.GetLength(0); i++)
                {
                    v[i, j] = kriterAgirliklari[j] * r[i, j];
                }
            }
     */
