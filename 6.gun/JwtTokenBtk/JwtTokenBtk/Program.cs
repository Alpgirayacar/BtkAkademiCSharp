using JwtTokenBtk.Entities;
using JwtTokenBtk.Helpers;
using JwtTokenBtk.User;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Projemizde DbContext olarak ApplicationDbContext kullanacaðýmýz belirtliyoruz.
builder.Services.AddDbContext<ApplicationDbContext>();
// appsettings.json içinde oluþturduðumuz gizli anahtarýmýzý AppSettings ile çaðýracaðýmýzý söylüyoruz.
var appSettingsSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);

// Oluþturduðumuz gizli anahtarýmýzý byte dizisi olarak alýyoruz.
var appSettings = appSettingsSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

//Projede farklý authentication tipleri olabileceði için varsayýlan olarak JWT ile kontrol edeceðimizin bilgisini kaydediyoruz.
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})

    //JWT kullanacaðým ve ayarlarý da þunlar olsun dediðimiz yer ise burasýdýr.
    .AddJwtBearer(x =>
    {
        //Gelen isteklerin sadece HTTPS yani SSL sertifikasý olanlarý kabul etmesi(varsayýlan true)
        x.RequireHttpsMetadata = false;
        //Eðer token onaylanmýþ ise sunucu tarafýnda kayýt edilir.
        x.SaveToken = true;
        //Token içinde neleri kontrol edeceðimizin ayarlarý.
        x.TokenValidationParameters = new TokenValidationParameters
        {
            //Token 3.kýsým(imza) kontrolü
            ValidateIssuerSigningKey = true,
            //Neyle kontrol etmesi gerektigi
            IssuerSigningKey = new SymmetricSecurityKey(key),
            //Bu iki ayar ise "aud" ve "iss" claimlerini kontrol edelim mi diye soruyor
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

//Son olarak authentication kullanacaðýmýzý belirtiyoruz.
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();



