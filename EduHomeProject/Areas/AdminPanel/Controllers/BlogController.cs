using EduHomeProject.Areas.AdminPanel.Data;
using EduHomeProject.DataAccessLayer;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _dbContext;
        public BlogController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var existBlog = await _dbContext.Blogs.Where(x => x.IsDeleted == false).ToListAsync();
            return View(existBlog);
        }
        public async Task<IActionResult> Create()
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog,int?[] categoryId)
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            var existBlogInDatabase = await _dbContext.Blogs.Where(x => x.IsDeleted == false).AnyAsync(x => x.BlogTitle.ToLower() == blog.BlogTitle.ToLower());
            if (existBlogInDatabase)
            {
                return Content("we have that blog");
            }
            if (blog.Photo == null)
            {
                ModelState.AddModelError("", "Photo must be upload");
                return View();
            }
            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "it is not image,Please Upload a photo");
                return View();
            }
            if (!blog.Photo.IsSizeAllowed(4))
            {
                ModelState.AddModelError("Photo", "Size isn't right,Please choose under 4mb photo");
                return View();
            }
            if (categoryId.Length == 0 || categoryId == null)
            {
                ModelState.AddModelError("", "Please,Choose category");
                return View();
            }
            var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, blog.Photo);
            blog.BlogImageName = fileName;
            var blogs = new List<BlogCategory>();
            foreach (var item in categoryId)
            {
                var blogCategory = new BlogCategory
                {
                    CategoryId = (int)item,
                    BlogId = blog.Id
                };
                blogs.Add(blogCategory);
            }
            blog.BlogCategories = blogs;

            blog.IsDeleted = false;
            await _dbContext.AddAsync(blog);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existBlogInDatabase = await _dbContext.Blogs.Include(x => x.BlogDetail).Include(x=>x.BlogCategories).ThenInclude(x=>x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (existBlogInDatabase == null)
            {
                return View(existBlogInDatabase);
            }
            return View(existBlogInDatabase);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            var existBlogInDatabase = await _dbContext.Blogs.Include(x => x.BlogDetail).FirstOrDefaultAsync(x => x.Id == id);
            if(existBlogInDatabase == null)
            {
                return View(existBlogInDatabase);
            }
            return View(existBlogInDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog, int?[] categoryId)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(id != blog.Id)
            {
                return NotFound();
            }

            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            var isBlogExistInDatabase = await _dbContext.Blogs.AnyAsync(x => x.BlogTitle.ToLower() == blog.BlogTitle.ToLower() && x.Id != blog.Id);
            if (isBlogExistInDatabase)
            {
                ModelState.AddModelError("", "We have this blog");
                return View();
            }
            var existBlogInDatabase = await _dbContext.Blogs.Include(x => x.BlogDetail).FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if(existBlogInDatabase == null)
            {
                return NotFound();
            }
            if(blog.Photo!=null)
            {
                if(!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please,choose a photo");
                    return View();
                }
                if(!blog.Photo.IsSizeAllowed(4))
                {
                    ModelState.AddModelError("", "Please,choose under 4 mb");
                    return View();
                }
                var path = Path.Combine(Constants.ImageFolderPath, existBlogInDatabase.BlogImageName);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                var filename = await FileUtil.GenerateFile(Constants.ImageFolderPath, blog.Photo);
                existBlogInDatabase.BlogImageName = filename;
            }
            else
            {
                blog.BlogImageName = existBlogInDatabase.BlogImageName;
            }
            if(categoryId.Length == 0 || categoryId == null)
            {
                blog.BlogCategories = existBlogInDatabase.BlogCategories;
            }
            else
            {
                var blogCategories = new List<BlogCategory>();
                foreach(var item in categoryId)
                {
                    var blogCategory = new BlogCategory()
                    {
                        CategoryId = (int)item,
                        BlogId = blog.Id
                    };
                    blogCategories.Add(blogCategory);

                }
                existBlogInDatabase.BlogCategories = blogCategories;
            }
            existBlogInDatabase.BlogDetail = blog.BlogDetail;
            existBlogInDatabase.Author = blog.Author;
            existBlogInDatabase.BlogTitle = blog.BlogTitle;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));



        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existBlogInDatabase = await _dbContext.Blogs.Include(x => x.BlogDetail).FirstOrDefaultAsync( x=> x.Id == id && x.IsDeleted == false);
            if(existBlogInDatabase == null)
            {
                return NotFound();
            }
            return View(existBlogInDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existBlogInDatabase = await _dbContext.Blogs.Include(x => x.BlogDetail).FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (existBlogInDatabase == null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, existBlogInDatabase.BlogImageName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
             _dbContext.Blogs.Remove(existBlogInDatabase);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
