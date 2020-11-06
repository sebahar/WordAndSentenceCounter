# WordAndSentenceCounter

Kelime & Cümle Sayacı
Aşağıdaki kriteleri sağlayan basit bir kelime ve cümle sayacı yapmak istiyoruz:
 Parametre olarak bir txt dosyasının dosya sistemindeki adresini alacak
 Programda bir ana thread ve sayısı parametrik olan (default 5) birden çok yardımcı
thread olacak.
 Ana thread verilen dosyayı okuyup cümlelerine ayıracak, cümle sayısını ve tüm
cümlelerdeki ortalama kelime sayısını tutacak.
 Ana thread text içindeki her cümleyi sırayla bir threadin kuyruğuna ekleyecek.
 Her yardımcı thread, kuyruğuna eklenen cümleleri kelimelerine ayıracak ve her kelime
için global tutulan bir listede, ilgili kelime sayısını güncelleyecek.
 Ana thread tüm yardımcı threadlerin işlerini bitirmesini bekleyecek, cümle sayısını,
ortalama kelime sayısını ve tüm threadlerin oluşturdugu listeyi sayı ve kelimeler
olarak ekrana yazdıracak.
 Kelimeler büyük-küçük harf duyarlı tutulacak ve sayıca azalan sırada yazdırılacak.
