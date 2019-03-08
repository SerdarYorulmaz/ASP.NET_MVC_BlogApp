using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{ 
    //bernevi veritabani
    public class BlogContext:DbContext   //entity framework codefirst Dbcontextten blog context kazandirmis olduk
    {

        public BlogContext():base("blogVt") //base ile veritabnamizin isimini degistebiliriz
        {  //WEB CONfig
            Database.SetInitializer(new BlogInitializer());
        }

        //veritabanimizdaki siniflar
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

    }
}