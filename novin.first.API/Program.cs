using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using novin.first.API.DB;
using novin.first.API.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FirstDB>(Options =>
{
    Options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=WebAppDB;Trusted_Connection=True");
});
builder.Services.AddCors(Options =>
{
    Options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});
var app = builder.Build();
app.UseCors();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

// Student
app.MapPost("student/add", (FirstDB db, Student Student) =>
{
    db.Students.Add(Student);
    db.SaveChanges();
});
app.MapPost("student/list", (FirstDB db) =>
{
    return db.Students.ToList();
});
app.MapPost("student/update", (FirstDB db, Student User) =>
{
    db.Students.Update(User);
    db.SaveChanges();
});
object value = app.MapPost("student/remove/{id}", (FirstDB db, int id) =>
{
    var student = db.Students.Find(id);
    if (student != null)
    {
        db.Students.Remove(student);
        db.SaveChanges();
    }
});

// Libary
app.MapPost("libary/add", (FirstDB db, Student Student) =>
{
    db.Students.Add(Student);
    db.SaveChanges();
});
app.MapPost("libary/list", (FirstDB db) =>
{
    return db.Students.ToList();
});
app.MapPost("libary/update", (FirstDB db, Student User) =>
{
    db.Students.Update(User);
    db.SaveChanges();
});
app.MapPost("libary/remove/{id}", (FirstDB db, int id) =>
{
    var student = db.Students.Find(id);
    if (student != null)
    {
        db.Students.Remove(student);
        db.SaveChanges();
    }
});

app.Run();