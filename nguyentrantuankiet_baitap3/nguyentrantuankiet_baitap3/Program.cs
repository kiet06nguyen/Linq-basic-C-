using BaiTapBai2;

#region them data 
var authors = new List<Author>
    {
        new Author { Id = 1, Name = "Nguyễn Du", Nationality = "Việt Nam" },
        new Author { Id = 2, Name = "Victor Hugo", Nationality = "Pháp" },
        new Author { Id = 3, Name = "Lev Tolstoy", Nationality = "Anh" },
        new Author { Id = 4, Name = "J.K. Rowling", Nationality = "Anh" }
    };
 
var books = new List<Book>
    {
        new Book { Id = 101, Title = "Truyện Kiều", AuthorId = 1, PublisherId = 1,
YearPublished = 1820, Price = 150000 },
        new Book { Id = 102, Title = "Những người khốn khổ", AuthorId = 2, PublisherId = 2,
YearPublished = 1862, Price = 200000 },
        new Book { Id = 103, Title = "Chiến tranh và hòa bình", AuthorId = 3, PublisherId = 3,
YearPublished = 1869, Price = 250000 },
        new Book { Id = 104, Title = "Harry Potter và Hòn đá Phù thủy", AuthorId = 4,
PublisherId = 4, YearPublished = 1997, Price = 300000 },
        new Book { Id = 105, Title = "Harry Potter và Phòng chứa bí mật", AuthorId = 4,
PublisherId = 4, YearPublished = 1998, Price = 320000 }
    };

var publishers = new List<Publisher>
    {
        new Publisher { Id = 1, Name = "NXB Văn Học", Location = "Hà Nội" },
        new Publisher { Id = 2, Name = "Gallimard", Location = "Paris" },
        new Publisher { Id = 3, Name = "Progress Publishers", Location = "Moscow" },
        new Publisher { Id = 4, Name = "Bloomsbury", Location = "London" }
    };

#endregion


bool menu = true;
while (menu == true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nBAI TAP BUOI 3");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------------------");
    Console.WriteLine("Cau 1: Lay danh sach nhung sach co gia tren 200k ");
    Console.WriteLine("Cau 2: Lay danh sach ten cua tat ca tac gia va in ra ");
    Console.WriteLine("Cau 3: Lay danh sach tac gia co id = 4, va in ra tieu de cung nam xuat ban");
    Console.WriteLine("Cau 4: Lay danh sach va sap xep theo nam xuat ban tang dan, in ra tieu de va nam xuat ban");
    Console.WriteLine("Cau 5: Tim sach co gia cao nhat, in ra tieu de cung gia, neu khong co thi tb 'Khong co sach nao'");
    Console.WriteLine("Cau 6: In sach cung ten tac gia, chi lay sach xuat ban sau nam 1900");
    Console.WriteLine("Cau 7: Tinh tong gia tri sach cua nha xuat ban va in ra ket qua");
    Console.WriteLine("Cau 8: Nhom tac gia theo quoc tich va in quoc tich cung danh sach tac gia trong moi nhom");
    Console.WriteLine("Cau 9: Nhom cac cuon sach theo nam xuat ban va sap xep cac thu tu nhom theo nam giam dan");
    Console.WriteLine("Cau 10: Tim tac gia co so luong sach nhieu nhat");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nDEV");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------------------");
    Console.WriteLine("Cau 11: Xem Code");;
    Console.WriteLine("Cau 12: Thoat chuong trinh");
    Console.Write("\nChon cau: ");
    byte chonmenu = byte.Parse(Console.ReadLine());
    switch (chonmenu)
    {
        case 1:
            cau1();
            break;
        case 2:
            cau2();
            break;
        case 3:
            cau3();
            break;
        case 4:
            cau4();
            break;
        case 5:
            cau5();
            break;
        case 6:
            cau6();
            break;
        case 7:
            cau7();
            break;
        case 8:
            cau8();
            break;
        case 9:
            cau9();
            break;
        case 10:
            cau10();
            break;
        case 11:
            xemCode();
            break;
        case 12:
            thoat();
            break;
        default:
            saicuphap();
            break;
    }
  
}
#region saicuphap
void saicuphap()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Sai cu phap !\nNhan phim bat ky de quay lai"); Console.ReadKey();
}
#endregion

#region thoat
void thoat()
{
    Console.Clear();
    Console.WriteLine($"Dang thoat.");
    Thread.Sleep(500);
    Console.WriteLine($"Dang thoat..");
    Thread.Sleep(500);
    Console.WriteLine($"Dang thoat...");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Thoat Thanh Cong !");
    Thread.Sleep(500);
    Console.Clear();
    menu = false;
}
#endregion

#region quayve
void quayve()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nAn phim bat ky de quay ve");
    Console.ReadKey();
}
#endregion

#region tieude
void tieude(string noidung)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{noidung}\n");
    Console.ForegroundColor = ConsoleColor.White;
}
#endregion

#region cau1
void cau1()
{
    tieude("CAU 1");
    var danhsach200k = books.Where(s => s.Price >= 200000);
    Console.WriteLine("Danh sach co gia tren 200k");
    foreach (var i in danhsach200k)
    {
        Console.WriteLine($"Tieu de: {i.Title}\nGia: {i.Price} vnd \n");
    }
    quayve();
}
#endregion

#region cau2
void cau2()
{
    tieude("CAU 2");
    var danhsachtentg = authors.Select(i => i.Name).ToList();
    Console.WriteLine("Danh sach ten tac gia");
    foreach (var i in danhsachtentg)
    {
        Console.WriteLine($"Ten Tac Gia: {i}");
    }
    quayve();
}
#endregion

#region cau3
void cau3()
{
    tieude("CAU 3");
    var danhsachid4 = books.Where(i => i.AuthorId == 4).Select(o => o.Title).ToList();
    foreach (var i in danhsachid4) Console.WriteLine($"Tieu de: {i}");
    quayve();
}

#endregion

#region cau4
void cau4()
{
    tieude("CAU 4");
    var sapxep = books.OrderBy(o => o.YearPublished).Select(i => new { i.YearPublished, i.Title }).ToList();
    foreach (var i in sapxep)
    {
        Console.WriteLine($"Nam xuat ban: {i.YearPublished} | Tieu de: {i.Title}");
    }
    quayve();
}
#endregion

#region cau5
void cau5()
{
    tieude("CAU 5");
    var sachgiacaonhat = books.OrderByDescending(o => o.Price).Select(i => new { i.Title, i.Price }).First();
    if (sachgiacaonhat == null) Console.WriteLine("Khong co sach nao");
    else Console.WriteLine($"SACH CO GIA CAO NHAT\nGia: {sachgiacaonhat.Price}, Tieu de: {sachgiacaonhat.Title}");
    quayve();
}
#endregion

#region cau6
void cau6()
{
    tieude("CAU 6");
    var sachsau1900 = books.Where(o => o.YearPublished > 1900).Join(authors, sach => sach.AuthorId, tacgia => tacgia.Id, (sach, tacgia) => new
    {
        tacgia.Name,
        sach.Title,
        sach.YearPublished
    });
    Console.WriteLine("Danh sach tac gia cua nhung sach xuat ban sau nam 1900");
    foreach (var i in sachsau1900) Console.WriteLine($"Tac gia: {i.Name} | Tieu de: {i.Title} | Nam xuat ban {i.YearPublished}");
    quayve();
}
#endregion

#region cau7
void cau7()
{
    tieude("CAU 7");
    var tonggiatri = books.Where(o => o.PublisherId == 4).Sum(i => i.Price);
    Console.WriteLine($"Tong gia tri sach cua nha xuat ban co ID = 4 la: {tonggiatri} vnd");
    quayve();
}
#endregion

#region cau8
void cau8()
{
    tieude("CAU 8");
    var nhomtacgia = authors.GroupBy(o => o.Nationality);
    foreach (var quoctich in nhomtacgia)
    {
        Console.WriteLine($"Quoc tich: {quoctich.Key}");
        foreach (var o in quoctich)
        {
            Console.WriteLine($"- Tac gia: {o.Name}");
        }
    }
    quayve();
}
#endregion

#region cau9
void cau9()
{
    tieude("CAU 9");
    var nhomtheonam = books.GroupBy(o => o.YearPublished).OrderByDescending(o => o.Key);
    foreach (var nhom in nhomtheonam)
    {
        Console.WriteLine($"Nam xuat ban {nhom.Key}");
        foreach (var i in nhom) Console.WriteLine($"Tieu de: {i.Title}, Nam xuat ban: {i.YearPublished}");
    }
    quayve();
}
#endregion

#region cau10
void cau10()
{
    tieude("CAU 10");
    var nhomsach = books.GroupBy(o => o.AuthorId);
    var laysoluong = nhomsach.Select(o => new { AuthorId = o.Key, soluong = o.Count() }).OrderByDescending(o => o.soluong).First();
    var sosanhvalayten = authors.FirstOrDefault(a => a.Id == laysoluong.AuthorId);
    Console.WriteLine($"Tac gia co so luong sach nhieu nhat la: \nTac gia: {sosanhvalayten.Name}, So luong sach: {laysoluong.soluong}");
    quayve();
}
#endregion



#region xem code
void xemCode()
{
    tieude("XEM CODE CAC CAU\n----------------------------");
    Console.WriteLine("1: Code Cau 1");
    Console.WriteLine("2: Code Cau 2");
    Console.WriteLine("3: Code Cau 3");
    Console.WriteLine("4: Code Cau 4");
    Console.WriteLine("5: Code Cau 5");
    Console.WriteLine("6: Code Cau 6");
    Console.WriteLine("7: Code Cau 7");
    Console.WriteLine("8: Code Cau 8");
    Console.WriteLine("9: Code Cau 9");
    Console.WriteLine("10: Code Cau 10");
    Console.Write("\nChon cau de xem code: ");
    byte choncode = byte.Parse(Console.ReadLine());
    xemcodecau(choncode);
}
void xemcodecau(byte cau)
{
    tieude($"CODE CAU {cau}");
    string code = cau switch
    {
        1 => @"
void cau1()
{
    var danhsach200k = books.Where(s => s.Price >= 200000);
    Console.WriteLine(""Danh sach co gia tren 200k"");
    foreach (var i in danhsach200k)
    {
        Console.WriteLine($""Tieu de: {i.Title}\nGia: {i.Price} vnd \n"");
    }
}",
        2 => @"
void cau2()
{  
    var danhsachtentg = authors.Select(i => i.Name).ToList();
    Console.WriteLine(""Danh sach ten tac gia"");
    foreach (var i in danhsachtentg)
    {
        Console.WriteLine($""Ten Tac Gia: {i}"");
    }
}",
        3 => @"var danhsachid4 = books.Where(i => i.AuthorId == 4).Select(o => o.Title).ToList();
    foreach (var i in danhsachid4) Console.WriteLine($""Tieu de: {i}"");",
        4 => @" var sapxep = books.OrderBy(o => o.YearPublished).Select(i => new { i.YearPublished, i.Title }).ToList();
    foreach (var i in sapxep)
    {
        Console.WriteLine($""Nam xuat ban: {i.YearPublished} | Tieu de: {i.Title}"");
    }",
        5 => @"var sachgiacaonhat = books.OrderByDescending(o => o.Price).Select(i => new { i.Title, i.Price }).First();
    if (sachgiacaonhat == null) Console.WriteLine(""Khong co sach nao"");
    else Console.WriteLine($""SACH CO GIA CAO NHAT\nGia: {sachgiacaonhat.Price}, Tieu de: {sachgiacaonhat.Title}"");",
        6 => @" var sachsau1900 = books.Where(o => o.YearPublished > 1900).Join(authors, sach => sach.AuthorId, tacgia => tacgia.Id, (sach, tacgia) => new
    {
        tacgia.Name,
        sach.Title,
        sach.YearPublished
    });
    Console.WriteLine(""Danh sach tac gia cua nhung sach xuat ban sau nam 1900"");
    foreach (var i in sachsau1900) Console.WriteLine($""Tac gia: {i.Name} | Tieu de: {i.Title} | Nam xuat ban {i.YearPublished}"");",
        7 => @"var tonggiatri = books.Where(o => o.PublisherId == 4).Sum(i => i.Price);
    Console.WriteLine($""Tong gia tri sach cua nha xuat ban co ID = 4 la: {tonggiatri} vnd"");",
        8 => @"    var nhomtacgia = authors.GroupBy(o => o.Nationality);
    foreach (var quoctich in nhomtacgia)
    {
        Console.WriteLine($""\nQuoc tich: {quoctich.Key}"");
        foreach (var o in quoctich)
        {
            Console.WriteLine($""- Tac gia: {o.Name}"");
        }
    }",
        9 => @" var nhomtheonam = books.GroupBy(o => o.YearPublished).OrderByDescending(o => o.Key);
    foreach (var nhom in nhomtheonam)
    {
        Console.WriteLine($""\nNam xuat ban {nhom.Key}"");
        foreach (var i in nhom) Console.WriteLine($""Tieu de: {i.Title}, Nam xuat ban: {i.YearPublished}"");
    }",
        10 => @" var nhomsach = books.GroupBy(o => o.AuthorId);
    var laysoluong = nhomsach.Select(o => new { AuthorId = o.Key, soluong = o.Count() }).OrderByDescending(o => o.soluong).First();
    var sosanhvalayten = authors.Where(o => o.Id == laysoluong.AuthorId).Select(o => o.Name);
    Console.WriteLine($""Tac gia co so luong sach nhieu nhat la: \nTac gia: {sosanhvalayten}, So luong sach: {laysoluong}"");",
    };

    Console.WriteLine(code);
    quayve();
}

#endregion