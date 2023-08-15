string isim = "";

int i = 10;

#region eski yöntem
switch (i)
{
    case 5:
        isim = "hilmi";
        break;
    case 6:
        isim = "kadir";
        break;
    case 7:
        isim = "hilmi";
        break;
    case 50:
        isim = "hilmi";
        break;

}
#endregion

#region Yeni yöntem

int x = 6;
string ad = x switch
{
    5 when 3 == 3 => "Kadir", // => ise demek
    var y when y == 6 && y % 2 == 1 => "Şerif",
    7 => "Memo",
    8 => "Deniz",
    var y => "kek"
};

#endregion