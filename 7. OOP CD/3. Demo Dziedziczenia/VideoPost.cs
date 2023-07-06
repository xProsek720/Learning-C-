using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Demo_Dziedziczenia
{
    public class VideoPost : ImagePost
    {
        protected string VideoUri { get; set; }
        public VideoPost(string Title, string SentBy, bool IsPublic, string VideoUri) : base(Title, SentBy, IsPublic, VideoUri)
        {
            this.VideoUri = VideoUri;
        }

        public override string ToString()
        {
            return $"ID: {this.PostId}\nTitle: {this.Title}\nSentBy: {this.SentBy}\nVideoUri: {this.VideoUri}";
        }

    }
}
