using System;
using System.Threading;
namespace InheritanceLesson
{
	public class VideoPost : Post
	{

        protected bool isPlaying = false;

        protected int currDuration = 0;

        Timer timer;

		public string VideoUrl { get; set; }

		public int Length { get; set; }

		public VideoPost() { }

		public VideoPost(string title, string sentBy, bool isPublic, string videoUrl, int length)
		{
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sentBy;
            this.IsPublic = isPublic;
            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        static void playTime(object state)
        {
            Console.WriteLine("1 Sec has passed");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
            Thread.Sleep(500);
        }

        public void Play()
        {

            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
            
        }

        private void TimerCallBack(object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {4} seconds  - {3} -By: {2} ", this.ID, this.Title, this.SendByUsername, this.VideoUrl, this.Length);
        }

    }
}

