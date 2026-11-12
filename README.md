# Vize Ödevi
## Oyunun Açıklaması
Tuzakları geçip yeterli puanı(>=50)topladığımız bir oyundur.
## Scriptlerin Görevi
### Controller scripti 
Playerın hareket kabiliyetini sağlar (zıplama,ileri geri sağa sola gitmesini)
### Tuzak scripti
Tuzakları seçilen x,y,z eksenlerinde hareket ettirir ve oyuncu tuzağa değerse sahne başa dönmesini sağlar.
### Score scripti
Ekranın sol alt kısmına güncel puanı yazar 
### Kutular scripti
Score scriptinden skorekle fonsiyonunu çağırır ve oyuncu toplarla temas ettikten sonra topun yok olmasını sağlar
### Finish scripti
Skor 50 ve 50den büyük ise oyuncu bitiş bölgesine değdiğinde oyunu baştan başlatır. Skor 50den küçükse oyun baştan başlamaz.
## Zıplama mekaniğinin algoritması
booleon türünden isGrounded değişkenimiz var ve zeminin tagi grounded dir. Oyuncudaki Controller scripti kontrol eder , grounded ile çarpışıldı mı diye eğer çarpışıldıysa 
isGrounded değeri true olur . Space tuşuna basıldığında ve isGrounded true olduğunda karakter zıplar. Addforce kullanarak 
y ekseninde hareket gerçekleşir. Zıpladıktan sonra isGrounded false olur. Havada bir daha zıplayamaması için.
## Hata Analizi
### Sorun :
Score scriptinin içindeki score değişkenine Finish scriptinden erişirmeye çalışırken erişemedim. erişmek istememin nedeni
playerın bitiş noktasına geldiğinde puanını öğrenebilmek.
### Çözüm : 
Başka bir script içindeki değişkene erişmek için scriptAdı.değişkenAdı şeklinde yazıldığını bilmiyordum.Fonksiyonların böyle çağrıldığını biliyordum.
Yapay zekaya sorarak öğrendim.

