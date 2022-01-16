using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Core.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Seeds
{
    class BlogSeed : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData(new Blog
            {
                Id = 1,
                AuthorId = 1,
                Title = "C#'IN DOĞUŞU",
                Content = @" Bir programlama dilinin nasıl meydana geldiğini anlamak onu anlamaktan daha önemlidir. Daha önce çıkan başarılı programlama dillerinde olduğu gibi C# da bir yandan programlama sanatını daha ileriye taşırken bir yandan da geçmişin üzerine inşa edilmiştir.Microsoft tarafından .Net Framework’ ün gelişimini desteklemek amacı ile geliştirilen C# kendisinden önce kabul görmüş ve kendi geliştirdiği yeniliklerden faydalanmıştır. C# Aile Ağacı
Aslında programlama dilleri birbirleri ile bağlantılıdır.Her yeni dil,
kendisinden önceki dillerden bir şekilde etkilenmiştir.
C# Zengin bir programlama mimarisine sahiptir. C# direkt olarak dünyanın en başarılı dillerinden C ve C++ ‘dan türetilmiştir ayrıca bir başkasıyla da yakından ilgilidir. Java. Bu ilişkileri anlamak C#’ ı anlamak için kritik bir öneme sahiptir.C: Modern Programlama Çağının Başlangıcı
C ’nin ortaya çıkışı programlamanın modern çağıdır. C ,1960‘ ların yapısal programlama devrimi ile ortaya çıkmıştır . Yapısal programlama öncesi büyük programlar geliştirmek zordu. Program mantığı spagetti kod olarak bilinen takibi güç, arapsaçına dönmüş atlamalar, çağrılar, ve dönüşlerden ibaret olan bir program yapısına dönüşmemesi imkansızdı. Yapısal diller bu yaraya merhem oldu ve yapısal dilleri kullanarak büyük programları yazmak mümkün hale geldi.
Her şeye rağmen saygın C dilinin bile kısıtlayıcı özellikleri vardı;gelişmiş programları ele almada yetersizdi 5000 satırlık programda işler karışmaya başlıyordu.OOP ve C++’ın Doğuşu
1970'lerin sonuna doğru bir çok programın boyutu C dilinin boyunu aşmış durumdaydı. Bu problemi çözmek amacı ile OOP denilen yeni bir programlama yöntemi ortaya çıkmaya başladı.
1983'de C++ ilk ismi ile “C With Classes” çıkmıştı. İlk isminden de anlaşılacağı üzere C dilinin üzerine sınıf eklenmiş haliydi.İnternet ve Java’nın Gelişi
Programlama dillerindeki bir sonraki ilerleyiş Java ile gerçekleşmiştir. Java sözdizimi ve felsefesi C++’dan alınan yapısal ve nesne yönelimli bir dildir. Java’nın yenilikçi özelliklerini, bilişim dünyasında yaşanan gelişmeler biçimlendirdi. İnternet genel kullanıma açılmadan önce programlar belirli işlemci ve işletim sistemlerine göre yazılıyordu ancak internet genel kullanıma açıldığında taşınabilirlik özelliği gündeme geldi ve bu sorunu ortadan kaldıracak dil Java idi. İnternete çok farklı tipte cihazlar bağlı olduğundan yazılan programlarında tüm cihazlarda çalışması gerekliydi bunu da Java başarıyla sağladı.
C#’ın Doğuşu Java internet ortamında taşınabilirliği çerçeveleyen bir çok hususu başarıyla ortaya koymuş olmasına rağmen Java’nın da yetersiz kaldığı bazı özellikler hala mevcuttur. Bunlardan biri diller arasında uyum içinde çalışma (Cross-Language Interoperability) olarak tarif edilebilecek özelliğidir yani bir dilde üretilmiş bir kodun başka bir dilde üretilmiş kod içerisinde çalışma becerisidir. Diller arasında uyum içinde çalışma özelliği büyük ,dağıtık yazılım sistemleri geliştirirken önemlidir. Java’nın yoksun olduğu bir diğer özellik ise Windows platformlarıyla tam entegresyonudur . Java programları JVM nin kurulu olduğu bilgisayarlarda çalışır. Bu ve diğer ihtiyaçlara cevap vermek amacıyla Microsoft , C#’ ı geliştirdi.",
                İmage = @"https://miro.medium.com/max/375/1*47e_Cq4HPaXzoKNCpgvPdA.png"
            }); 
        }
    }
}
