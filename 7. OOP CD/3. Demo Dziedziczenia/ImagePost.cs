using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Demo_Dziedziczenia
{
    public class ImagePost :Post
    {
        protected string ImgUri { get; set; }
        public ImagePost(string Title, string SentBy, bool IsPublic, string ImgUri) : base(Title, SentBy, IsPublic)
        {

            this.ImgUri = ImgUri;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nUri: {this.ImgUri}";
        }
        public string ReturnLink() 
        {
            return this.ImgUri;
        }
    }
}
