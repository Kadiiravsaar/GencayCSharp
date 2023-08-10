
#region object


#region Boxing

// bir veriyi object'in içine koymaya boxing (Kutulama) diyoruz

using System.Security.AccessControl;

int yas = 28;
object _yas = 28; // Buna boxing diyoruz

// object değikenin içerisinde değer üzerinde işlemler yapmak için mesela int topla çıkar gibi
// o işlemler object türünde yapılamaz

#endregion

#region UnBoxing

// object'e koyduğumuz veriyi kendi türünde elde etmeye UNBOXİNG denir
// cast operatörü ile sağlanır


#endregion

#region Cast Operatürü


// unboxing işlemlerini yapabilmek için kullanılır

// Boxing olmuş veriyi UNBOXİNG'e yani kendi türünde elde etmeye yarar

// () işlemi ile yapılır

// hangi türe unboxing etmek istiyotsak parantez içine hedef türü verilir

int a = 5;
Object b = 5;
int _b = (int)b;

#endregion



#endregion