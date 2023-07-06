using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Demo_Dziedziczenia
{
    public class VideoPost : ImagePost
    {
        protected bool isPlaying = false;
        protected int curDuration = 0;

        Timer timer;

        protected string VideoUri { get; set; }
        protected int Length { get; set; }
        public VideoPost(string Title, string SentBy, bool IsPublic, string VideoUri, int Length) : base(Title, SentBy, IsPublic, VideoUri)
        {
            this.VideoUri = VideoUri;
            this.Length = Length;
        }

        public override string ToString()
        {
            return $"ID: {this.PostId}\nTitle: {this.Title}\nSentBy: {this.SentBy}\nVideoUri: {this.VideoUri}";
        }

        public void Play() 
        {
            if (!isPlaying) 
            {
                isPlaying = true;
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        public void TimerCallback(Object o) 
        {
            if (curDuration < this.Length) 
            {
                curDuration++;
                Console.WriteLine($"Video at {curDuration}");
                GC.Collect();
            }
            else 
            {
                Stop();
            }
        }

        public void Stop() 
        {
            if (isPlaying) 
            {
                Console.WriteLine($"Stoping at {curDuration}");
                curDuration = 0;
                timer.Dispose();    
            }
        }
    }
}
