using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SeeZong.WebSite.Models
{
    public class SeeZongContext : DbContext
    {
        public DbSet<Article> Article { get; set; }

        public DbSet<CodeLanguage> CodeLanguage { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ArticleTag> ArticleTag { get; set; }

        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }

        public SeeZongContext()
            : base("SZConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }


    public class Article
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int? CoeLanguageId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(255)]
        private string LinkUrl { get; set; }

        [MaxLength(255)]
        public string ImgUrl { get; set; }

        [MaxLength(255)]
        public string SeoTitle { get; set; }

        [MaxLength(255)]
        public string SeoKeyWords { get; set; }

        [MaxLength(255)]
        public string SeoDescription { get; set; }

        public string Content { get; set; }
        [MaxLength(255)]
        public string Author { get; set; }
        [MaxLength(255)]
        public string SourceName { get; set; }
        [MaxLength(500)]
        public string SourceUrl { get; set; }

        public int SortOrder { get; set; }

        public int Views { get; set; }

        public int Praises { get; set; }

        public int Forwards { get; set; }
        public int Replies { get; set; }

        public int Status { get; set; }

        public bool IsTop { get; set; }

        public bool IsRed { get; set; }

        public bool IsHot { get; set; }

        public bool AllowReply { get; set; }

        public DateTime PostTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int UserId { get; set; }

        public virtual Category Category { get; set; }

        public virtual CodeLanguage CodeLanguage { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }

    public class CodeLanguage
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(255)]
        private string ImgUrl { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Namge { get; set; }

        [MaxLength(255)]
        public string ImgUrl { get; set; }

        public int SortOrder { get; set; }

        public int? ParentId { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }

    public class ArticleTag
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public int TagId { get; set; }

        public virtual Article Article { get; set; }

        public virtual Tag Tag { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string TagName { get; set; }

        public int Count { get; set; }

        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }

    public class User
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string UserName { get; set; }

        [MaxLength(128)]
        public string Password { get; set; }

        [MaxLength(128)]
        public string PassWordSalt { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Mobile { get; set; }

        [MaxLength(255)]
        public string TencentWB { get; set; }

        [MaxLength(255)]
        public string SinaWB { get; set; }

        [MaxLength(255)]
        public string WeiXin { get; set; }

        [MaxLength(255)]
        public string GitHub { get; set; }

        public string Website { get; set; }

        public bool IsApproved { get; set; }

        public int Status { get; set; }

        [MaxLength(1000)]
        public string Signature { get; set; }

        [MaxLength(15)]
        public string RegIp { get; set; }

        public DateTime RegTime { get; set; }

        [MaxLength(15)]
        public string LastLoginIp { get; set; }

        public DateTime LastActivityTime { get; set; }

        public DateTime LastLockoutDate { get; set; }

        public int FailedPasswordAttemptCount { get; set; }

        public int FailedPasswordAnswerAttempt { get; set; }

        public DateTime? BirthDay { get; set; }

        [MaxLength(255)]
        public string Avatar { get; set; }
    }

}
