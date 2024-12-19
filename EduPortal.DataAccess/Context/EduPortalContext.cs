using EduPortal.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduPortal.DataAccess.Context;

public class EduPortalContext : DbContext
{
    public EduPortalContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Subscriber> Subscribers { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }


}