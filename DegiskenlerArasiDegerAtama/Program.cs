#region DeepCopy

int a = 5;
int b = a;

// deep copyde eldeki veri çoğalır/klonlanır

// değer türlü değişkenler birbirine atanırken default olarak deep copy geçerlidir

a = a * 5; // a yaptığın değişiklik b'ye yansımaz buna derin kopyalama denir

#endregion


#region Shallow Copy

string s = "Kadir";
string  h = s;

// Değişkenler arası değer atamalarında değeri türetmek/Çoğaltmak YERİNE var olanı birden fazla referans ile
// işaretleme yöntemidir

// bellekte birden fazla referansın tek bir veriyi işaret etmesidir



#endregion