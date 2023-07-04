using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Demo_Dziedziczenia
{
    public class Post
    {
        private static int currentPostId;

        protected int PostId { get; set; }
        protected string Title { get; set; }
        protected string SentBy { get; set; }
        protected bool IsPublic { get; set; } 

        public Post(string Title, string SentBy, bool IsPublic) 
        {
            //To działa:
            this.PostId = ReturnNextPostId();
            
            this.Title = Title;
            this.SentBy = SentBy;
            this.IsPublic = IsPublic;
        }

        //To działa i zwiększa Id :D
        public int ReturnNextPostId() 
        {
            return currentPostId++;
        }

        public void Update(string Title, bool IsPublic) 
        {
            this.Title = Title;
            this.IsPublic = IsPublic;
        }

        public override string ToString() 
        {
            return $"ID: {this.PostId}\nTitle: {this.Title}\nSentBy: {this.SentBy}";
        }

        

    }
}
