using Android.Media;
using Dersler.Dersler;
using Java.Util.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Android.Hardware.Camera;

namespace Dersler.Dersler
{
    internal class Keywordler
    {
    }
}

abstract: Soyut sınıfların veya üyelerin tanımlanmasını sağlar.
as: Bir türü veya ifadeyi başka bir türe dönüştürmek için kullanılır.
base: Bir alt sınıfın üst sınıfına erişim sağlar veya bir yapılandırıcıyı çağırmak için kullanılır.
bool: Mantıksal değerler(true veya false) için veri türünü belirtir.
break: Döngü veya anahtar kelimenin kontrolündeki ifadeyi sonlandırır.
byte: 0 ile 255 arasındaki tamsayı değerlerini temsil eden 8 bitlik veri türünü belirtir.
case: switch ifadesinde belirli bir durumu temsil eder.
catch: Hata durumlarını ele almak için kullanılan try-catch bloğunda kullanılır.
char: Tek bir Unicode karakterini temsil eden 16 bitlik veri türünü belirtir.
checked: Taşmaların kontrol edilmesini sağlar.
class: Nesnelerin özelliklerini ve davranışlarını tanımlayan bir sınıfın başlangıcını belirtir.
const: Değişmeyen sabit bir değer tanımlar.
continue: Döngünün geri kalanını atlayarak döngünün bir sonraki adımına geçer.
decimal: Hassas ondalık sayılar için 128 bitlik veri türünü belirtir.
default: switch ifadesinde varsayılan bir durumu temsil eder.
delegate: Metotları temsil eden ve metotların diğer metotlara parametre olarak geçilmesini sağlayan bir türdür.
do: Belirli bir koşulu sağladığı sürece belirli bir kod bloğunu yürütür.
double: Ondalık sayılar için 64 bitlik veri türünü belirtir.
else: Bir if ifadesinde, koşulun sağlanmadığı durumda yürütülecek kod bloğunu belirtir.
enum: Belirli bir türün değerlerini tanımlayan bir numaralı sabitler kümesini belirtir.
event: Bir olayın tanımlanmasını ve olaya abone olunabilmesini sağlar.
explicit: Belirli bir tür dönüşümünün açıkça belirtilmesini sağlar.
extern: Bir yöntem veya nesne bildiriminin başka bir derleme biriminde olduğunu belirtir.
false: Mantıksal false değerini temsil eder.
finally: Bir try-catch bloğunda, hata olsun veya olmasın her durumda yürütülecek kod bloğunu belirtir.
fixed: Bir değişkenin bellekte sabit bir konumda olmasını sağlar.
float: Ondalık sayılar için 32 bitlik veri türünü belirtir.
for: Belirli bir koşulu sağladığı sürece belirli bir kod bloğunu yineleyen bir döngüyü belirtir.
foreach: Bir koleksiyonun tüm elemanları üzerinde yineleme yapmak için kullanılır.
goto: Belirtilen bir etikete atlamak için kullanılır.
if: Belirli bir koşulu kontrol eder ve koşul sağlandığında belirli bir kod bloğunu yürütür.
implicit: Belirli bir tür dönüşümünün açıkça belirtilmesine gerek kalmadan otomatik olarak gerçekleşmesini sağlar.
in: Bir metoda bir parametrenin geçişini ve değişmez olarak ele alınmasını sağlar.
int: Tamsayı değerlerini temsil eden 32 bitlik veri türünü belirtir.
interface: Sınıfların uygulayabileceği özellikler ve davranışlar için bir arayüzün tanımlanmasını sağlar.
internal: Bir sınıfın veya üyenin yalnızca kendi içinde veya aynı derleme biriminde erişilebilir olduğunu belirtir.
is: Bir nesnenin belirli bir türe ait olup olmadığını kontrol eder.
lock: Eşzamanlılık kontrolü için bir nesnenin kilidini alır.
long: Büyük tamsayı değerlerini temsil eden 64 bitlik veri türünü belirtir.
namespace: Kodun içerdiği sınıfların ve diğer türlerin mantıksal gruplamasını sağlar.
new: Yeni bir nesne oluşturur veya bir üyeye yeni bir uygulama ekler.
null: Bir referansın değeri olmadığını belirtir.
object: Herhangi bir türün bir nesnesini temsil eden en temel veri türünü belirtir.
operator: Operatör aşırı yükleme için bir metodu belirtir.
out: Bir metot parametresinin referans olarak geçildiğini ve metot tarafından doldurulacağını belirtir.
override: Bir sınıfın veya üyenin üst sınıfın sürümünü geçersiz kılar.
params: Birden çok değişken sayısını kabul eden bir metot parametresini belirtir.
private: Bir üyenin sadece tanımlandığı sınıf içerisinden erişilebilir olduğunu belirtir.
protected: Bir üyenin tanımlandığı sınıf veya türetilmiş sınıflar içinden erişilebilir olduğunu belirtir.
public: Bir üyenin herhangi bir yerden erişilebilir olduğunu belirtir.
readonly: Sadece bir kez atanabilen bir alanın değerini belirtir.
ref: Bir metot parametresinin referans olarak geçildiğini belirtir.
return: Bir metottan değer döndürmek için kullanılır.
sbyte: İkili formatta işaretli 8 bitlik tamsayı değerlerini temsil eden veri türünü belirtir.
sealed: Bir sınıfın başka bir sınıf tarafından devralınmasını engeller.
short: İkili formatta işaretli 16 bitlik tamsayı değerlerini temsil eden veri türünü belirtir.
sizeof: Bir türün bellekteki boyutunu döndürür.
stackalloc: Yerel bellekte bir dizi oluşturur.
static: Bir üyenin sınıf seviyesinde olduğunu belirtir ve nesne örneği oluşturulmadan erişilebilir.
string: Metin dizilerini temsil eden bir veri türünü belirtir.
struct: Değer türü bir yapıyı belirtir.
switch: Birden çok duruma dayalı olarak farklı kod bloklarını yürütmek için kullanılır.
this: Bir sınıfın geçerli örneğini temsil eder.
throw: Bir istisna fırlatmak için kullanılır.
true: Mantıksal true değerini temsil eder.
try: Bir hata durumunu ele almak için kullanılan try-catch bloğunun başlangıcını belirtir.
typeof: Bir türün çalışma zamanında belirtilen Type nesnesini alır.
uint: İkili formatta işaretsiz 32 bitlik tamsayı değerlerini temsil eden veri türünü belirtir.
ulong: İkili formatta işaretsiz 64 bitlik tamsayı değerlerini temsil eden veri türünü belirtir.
unchecked: Taşmaların denetimini devre dışı bırakır.
unsafe: Güvenli olmayan kod bloğunu belirtir.
ushort: İkili formatta işaretsiz 16 bitlik tamsayı değerlerini temsil eden veri türünü belirtir.
using: Kaynakların düzgün bir şekilde serbest bırakılmasını sağlamak için bir nesneyi tanımlar ve kullanır.
virtual: Bir sınıfın veya üyenin bir türetilmiş sınıf tarafından geçersiz kılınabileceğini belirtir.
void: Bir metotun geriye değer döndürmediğini belirtir.
volatile: Bir değişkenin çoklu iş parçacığı tarafından erişildiğinde optimize edilmesini önler.
while: Belirli bir koşulu sağladığı sürece belirli bir kod bloğunu yineleyen bir döngüyü belirtir.
add: Bir olaya bir abone ekler.
alias: Bir tür veya alanın takma adını belirtir.
ascending: Sıralama sırasının artan (küçükten büyüğe) olduğunu belirtir.
async: Bir metodu asenkron olarak işaretler.
await: Bir asenkron işlemin tamamlanmasını bekler ve sonucunu alır.
by: Gruplama veya sıralama için kullanılan ölçütü belirtir.
descending: Sıralama sırasının azalan (büyükten küçüğe) olduğunu belirtir.
dynamic: Çalışma zamanında tür kontrolü yapılmadan bir nesneye erişmek için kullanılır.
equals: İki nesnenin eşit olup olmadığını kontrol eder.
from: Bir sorgunun kaynak veri kümesini belirtir.
get: Bir özelliğin veya dizinin değerini alır.
global: İçerik bulunduran dosya içindeki bir değişkeni veya üyeyi temsil eder.
group: Bir sorgudaki elemanları gruplandırır.
into: Bir sorgunun sonucunu yeni bir tür veya sorgu ifadesi olarak dönüştürür.
join: İki kaynak koleksiyonunu ortak bir anahtar üzerinde birleştirir.
let: Bir sorguda ara değerleri tanımlar.
nameof: Bir değişkenin, türün veya üyenin adını alır.
on: Bir join ifadesinde birleşim kuralını belirtir.
orderby: Bir sorgunun sonucunu belirli bir sıraya göre sıralar.
partial: Bir sınıf veya metot tanımını birden çok dosyaya yaymak için kullanılır.
remove: Bir olaydan bir abone kaldırır.
select: Bir sorgunun sonucundan belirli bir özelliği veya değeri seçer.
set: Bir özelliğin veya dizinin değerini ayarlar.
value: Bir özelliğin veya dizinin değerini temsil eder.
var: Bir değişkenin türünü otomatik olarak belirler.
when: Bir pattern eşleştirmesinde veya catch ifadesinde belirli bir koşulu belirtir.
where: Bir sorgunun sonuçlarını belirli bir koşula göre filtreler.
yield: Bir yineleme bloğunun geçerli değerini döndürür ve yinelemeyi duraklatır.