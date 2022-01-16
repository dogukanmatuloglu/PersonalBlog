using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalBlog.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SocialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    İmage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "SocialLink", "Surname" },
                values: new object[] { 1, new DateTime(2022, 1, 16, 9, 50, 25, 523, DateTimeKind.Local).AddTicks(8548), "Doğukan", "123456789", "www.pornhub.com", "Matuloğlu" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedDate", "Title", "İmage" },
                values: new object[] { 1, 1, " Bir programlama dilinin nasıl meydana geldiğini anlamak onu anlamaktan daha önemlidir. Daha önce çıkan başarılı programlama dillerinde olduğu gibi C# da bir yandan programlama sanatını daha ileriye taşırken bir yandan da geçmişin üzerine inşa edilmiştir.Microsoft tarafından .Net Framework’ ün gelişimini desteklemek amacı ile geliştirilen C# kendisinden önce kabul görmüş ve kendi geliştirdiği yeniliklerden faydalanmıştır. C# Aile Ağacı\r\nAslında programlama dilleri birbirleri ile bağlantılıdır.Her yeni dil,\r\nkendisinden önceki dillerden bir şekilde etkilenmiştir.\r\nC# Zengin bir programlama mimarisine sahiptir. C# direkt olarak dünyanın en başarılı dillerinden C ve C++ ‘dan türetilmiştir ayrıca bir başkasıyla da yakından ilgilidir. Java. Bu ilişkileri anlamak C#’ ı anlamak için kritik bir öneme sahiptir.C: Modern Programlama Çağının Başlangıcı\r\nC ’nin ortaya çıkışı programlamanın modern çağıdır. C ,1960‘ ların yapısal programlama devrimi ile ortaya çıkmıştır . Yapısal programlama öncesi büyük programlar geliştirmek zordu. Program mantığı spagetti kod olarak bilinen takibi güç, arapsaçına dönmüş atlamalar, çağrılar, ve dönüşlerden ibaret olan bir program yapısına dönüşmemesi imkansızdı. Yapısal diller bu yaraya merhem oldu ve yapısal dilleri kullanarak büyük programları yazmak mümkün hale geldi.\r\nHer şeye rağmen saygın C dilinin bile kısıtlayıcı özellikleri vardı;gelişmiş programları ele almada yetersizdi 5000 satırlık programda işler karışmaya başlıyordu.OOP ve C++’ın Doğuşu\r\n1970'lerin sonuna doğru bir çok programın boyutu C dilinin boyunu aşmış durumdaydı. Bu problemi çözmek amacı ile OOP denilen yeni bir programlama yöntemi ortaya çıkmaya başladı.\r\n1983'de C++ ilk ismi ile “C With Classes” çıkmıştı. İlk isminden de anlaşılacağı üzere C dilinin üzerine sınıf eklenmiş haliydi.İnternet ve Java’nın Gelişi\r\nProgramlama dillerindeki bir sonraki ilerleyiş Java ile gerçekleşmiştir. Java sözdizimi ve felsefesi C++’dan alınan yapısal ve nesne yönelimli bir dildir. Java’nın yenilikçi özelliklerini, bilişim dünyasında yaşanan gelişmeler biçimlendirdi. İnternet genel kullanıma açılmadan önce programlar belirli işlemci ve işletim sistemlerine göre yazılıyordu ancak internet genel kullanıma açıldığında taşınabilirlik özelliği gündeme geldi ve bu sorunu ortadan kaldıracak dil Java idi. İnternete çok farklı tipte cihazlar bağlı olduğundan yazılan programlarında tüm cihazlarda çalışması gerekliydi bunu da Java başarıyla sağladı.\r\nC#’ın Doğuşu Java internet ortamında taşınabilirliği çerçeveleyen bir çok hususu başarıyla ortaya koymuş olmasına rağmen Java’nın da yetersiz kaldığı bazı özellikler hala mevcuttur. Bunlardan biri diller arasında uyum içinde çalışma (Cross-Language Interoperability) olarak tarif edilebilecek özelliğidir yani bir dilde üretilmiş bir kodun başka bir dilde üretilmiş kod içerisinde çalışma becerisidir. Diller arasında uyum içinde çalışma özelliği büyük ,dağıtık yazılım sistemleri geliştirirken önemlidir. Java’nın yoksun olduğu bir diğer özellik ise Windows platformlarıyla tam entegresyonudur . Java programları JVM nin kurulu olduğu bilgisayarlarda çalışır. Bu ve diğer ihtiyaçlara cevap vermek amacıyla Microsoft , C#’ ı geliştirdi.", new DateTime(2022, 1, 16, 9, 50, 25, 526, DateTimeKind.Local).AddTicks(7455), "C#'IN DOĞUŞU", "https://miro.medium.com/max/375/1*47e_Cq4HPaXzoKNCpgvPdA.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
