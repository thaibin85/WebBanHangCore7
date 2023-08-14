using System.ComponentModel.DataAnnotations;

namespace AspNetCaNhan.Areas.Admin.Models.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        [StringLength(150)]
        public string SeoTitle { get; set; }// seo tu khoa cho google
        [StringLength(250)]
        public string SeoDescription { get; set; }
        [StringLength(150)]
        public string SeoKeywords { get; set; }
        public int Position { get; set; }
        public bool IsActive { get; set; }
    }
}
