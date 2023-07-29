namespace ToDoUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<kart> todoBoard = new List<kart>();
            List<kart> inProgressBoard = new List<kart>();
            List<kart> doneBoard = new List<kart>();
            
            Dictionary<int, string> Kisiler = new Dictionary<int, string>()
            {
            {1,"elif" },
            {2,"ayşe" },
            {3,"a" },
            {4,"b" }
            };
            todoBoard.Add(new kart { Baslik = "sunum", Icerik = "yenilikler", Kisi = Kisiler[1], Buyukluk = buyukluk.M.ToString() });
            inProgressBoard.Add(new kart { Baslik = "raporlama", Icerik = "ciro", Kisi = Kisiler[2], Buyukluk = buyukluk.S.ToString() });
            doneBoard.Add(new kart { Baslik = "düzenleme", Icerik = "yeni evraklar", Kisi = Kisiler[3], Buyukluk = buyukluk.XS.ToString() });
            int secim = -1;
            while (true)
            {
                if (secim == -1)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("ANA MENÜ");
                    Console.WriteLine("(1) Board Listelemek\n(2) Board'a Kart Eklemek\n" +
                        "(3) Board'dan Kart Silmek\n(4) Kart Taşımak\n" +
                        "(0) Menüden çıkış");
                    Console.WriteLine("**********************************************");

                    Console.Write("seçiminiz:");
                    secim = Convert.ToInt32(Console.ReadLine());
                }
           
                if (secim == 1)
                {
                    Console.WriteLine("TODO Line\r\n ************************");
                    if (todoBoard.Count == 0)
                    {
                        Console.WriteLine("~ BOŞ ~");
                    }
                    foreach (var item in todoBoard)
                    {
                        
                        bilgileriyazdirma(item.Baslik, item.Icerik, item.Kisi, item.Buyukluk);
      
                    }

                    Console.WriteLine("IN PROGRESS Line\r\n ************************");
                    if (inProgressBoard.Count==0)
                    {
                        Console.WriteLine("~ BOŞ ~");
                    }
                    foreach (var item in inProgressBoard)
                    {
                        
                        bilgileriyazdirma(item.Baslik, item.Icerik, item.Kisi, item.Buyukluk);
              
                    }

                    Console.WriteLine("DONE Line\r\n ************************");
                    if (doneBoard.Count == 0)
                    {
                        Console.WriteLine("~ BOŞ ~");
                    }
                    foreach (var item in doneBoard)
                    {
                       
                       bilgileriyazdirma(item.Baslik, item.Icerik, item.Kisi, item.Buyukluk);

                    }
                    secim = -1;
                }

                if (secim == 2)
                {
                    Console.Write("Başlık Giriniz                                  :");
                    string baslik = Console.ReadLine();
                    Console.Write("İçerik Giriniz                                  :");
                    string icerik = Console.ReadLine();
                    Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                    int buyukluk1 =Convert.ToInt32( Console.ReadLine());
                    Console.Write("Kişi Seçiniz                                    :");
                    int kisi = Convert.ToInt32(Console.ReadLine());
                    if (Kisiler.ContainsKey(kisi))
                        {
                        if (buyukluk1 ==(int)buyukluk.XS)
                        {
                            todoBoard.Add(new kart { Baslik = baslik, Icerik = icerik, Kisi = Kisiler[kisi], Buyukluk = buyukluk.XS.ToString() });
                        }
                        if (buyukluk1 == (int)buyukluk.S)
                        {
                            todoBoard.Add(new kart { Baslik = baslik, Icerik = icerik, Kisi = Kisiler[kisi], Buyukluk = buyukluk.S.ToString() });
                        }
                        if (buyukluk1 == (int)buyukluk.M)
                        {
                            todoBoard.Add(new kart { Baslik = baslik, Icerik = icerik, Kisi = Kisiler[kisi], Buyukluk = buyukluk.M.ToString() });
                        }
                        if (buyukluk1 == (int)buyukluk.L)
                        {
                            todoBoard.Add(new kart { Baslik = baslik, Icerik = icerik, Kisi = Kisiler[kisi], Buyukluk = buyukluk.L.ToString() });
                        }
                        if (buyukluk1 == (int)buyukluk.XL)
                        {
                            todoBoard.Add(new kart { Baslik = baslik, Icerik = icerik, Kisi = Kisiler[kisi], Buyukluk = buyukluk.XL.ToString() });
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı girişler yaptınız!");
                    }
                    secim = -1;
                }

                if (secim == 3)
                {
                    Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:");
                    string baslikArma = Console.ReadLine();
                    int sayac = 0;
                    
                    for(int i=0;i<todoBoard.Count;i++)
                    { 
                        if (todoBoard[i].Baslik == baslikArma)
                        {
                            todoBoard.RemoveAt(i);
                            sayac = 1;
                        }                       
                    }
                    for (int i = 0; i < inProgressBoard.Count; i++)
                    {
                        
                        if (inProgressBoard[i].Baslik == baslikArma)
                        {
                            inProgressBoard.RemoveAt(i);
                            sayac = 1;
                        }                       
                    }
                    for (int i = 0; i < doneBoard.Count; i++)
                    {
                        if (doneBoard[i].Baslik == baslikArma)
                        {
                            doneBoard.RemoveAt(i);
                            sayac = 1;
                        }
                    }

                    if (sayac == 0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                            "* Silmeyi sonlandırmak için : (1)\n"+
                            "* Yeniden denemek için : (2)");
                        Console.Write("seçim:");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        if (secim1 == 1)
                        {
                            secim = -1;
                        }
                        if (secim1 == 2)
                        {
                            secim = 3;
                        }
                    }
                    else
                    {
                        secim = -1;
                    }
                }

                if (secim == 4)
                {
                    Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız:");
                    string kartArma = Console.ReadLine();
                    int sayac = 0;

                    for (int i = 0; i < todoBoard.Count; i++)
                    {
                        if (todoBoard[i].Baslik == kartArma)
                        {
                            
                            bilgileriyazdirma(todoBoard[i].Baslik, todoBoard[i].Icerik, todoBoard[i].Kisi, todoBoard[i].Buyukluk);

                            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                            Console.Write("seçim:");
                            int secim2 = Convert.ToInt32(Console.ReadLine());
                            if (secim2 == 1)
                            {
                                Console.WriteLine("hatalı işlem.");
                            }
                            if (secim2 == 2)
                            {
                                inProgressBoard.Add(todoBoard[i]);
                                todoBoard.RemoveAt(i);
                                sayac = 1;
                                break;

                            }
                            if (secim2 == 3)
                            {
                                doneBoard.Add(todoBoard[i]);
                                todoBoard.RemoveAt(i);
                                sayac = 1;
                                break;
                            }                            
                        }                      
                    }
                    if (sayac == 0)
                    {
                        for (int i = 0; i < inProgressBoard.Count; i++)
                        {

                            if (inProgressBoard[i].Baslik == kartArma)
                            {
                                bilgileriyazdirma(inProgressBoard[i].Baslik, inProgressBoard[i].Icerik, inProgressBoard[i].Kisi, inProgressBoard[i].Buyukluk);

                                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                                Console.Write("seçim:");
                                int secim2 = Convert.ToInt32(Console.ReadLine());
                                if (secim2 == 1)
                                {
                                    todoBoard.Add(inProgressBoard[i]);
                                    inProgressBoard.RemoveAt(i);
                                    sayac = 1;
                                    break;
                                }
                                if (secim2 == 2)
                                {
                                    Console.WriteLine("hatalı işlem.");

                                }
                                if (secim2 == 3)
                                {

                                    doneBoard.Add(inProgressBoard[i]);
                                    inProgressBoard.RemoveAt(i);
                                    sayac = 1;
                                    break;
                                }
                            }
                        }
                        if (sayac == 0)
                        {
                            for (int i = 0; i < doneBoard.Count; i++)
                            {
                                if (doneBoard[i].Baslik == kartArma)
                                {
                                    bilgileriyazdirma(doneBoard[i].Baslik, doneBoard[i].Icerik, doneBoard[i].Kisi, doneBoard[i].Buyukluk);

                                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                                    Console.Write("seçim:");
                                    int secim2 = Convert.ToInt32(Console.ReadLine());
                                    if (secim2 == 1)
                                    {
                                        todoBoard.Add(doneBoard[i]);
                                        doneBoard.RemoveAt(i);
                                        sayac = 1;
                                        break;
                                    }
                                    if (secim2 == 2)
                                    {
                                        inProgressBoard.Add(doneBoard[i]);
                                        doneBoard.RemoveAt(i);
                                        sayac = 1;
                                        break;

                                    }
                                    if (secim2 == 3)
                                    {
                                        Console.WriteLine("hatalı işlem.");
                                    }
                                }
                            }
                        }
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                            "* İşlemi sonlandırmak için : (1)\n" +
                            "* Yeniden denemek için : (2)");
                        Console.Write("seçim:");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        if (secim1 == 1)
                        {
                            secim = -1;
                        }
                        if (secim1 == 2)
                        {
                            secim = 4;
                        }
                    }
                    else
                    {
                        secim = -1;
                    }
                }

                if (secim == 0)
                {
                    break;

                }
            }

            void bilgileriyazdirma(string b,string I,string k,string bu)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:\r\n **************************************");
                Console.WriteLine("Başlık      :{0}\n" +
                "İçerik      :{1}\n" +
                "Atanan Kişi :{2}\n" +
                "Büyüklük    :{3}\n", b, I, k, bu);

            }           
        }
    }

    class kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Kisi { get; set; }
        public string Buyukluk { get; set; }
                   
    }

    enum buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
