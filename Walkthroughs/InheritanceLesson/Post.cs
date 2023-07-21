using System;
namespace InheritanceLesson
{
	public class Post
	{
		private static int currentPostId;

		//properties
		protected int ID { get; set; }

		protected string Title { get; set; }

		protected string SendByUsername { get; set; }

		protected bool IsPublic { get; set; }


		public Post()
		{
			ID = 0;
			Title = "My First Post";
			IsPublic = true;
			SendByUsername = "James Madison";
		}

		public Post(string title, bool isPublic, string sentBy)
		{
			this.ID = GetNextId();
			this.Title = title;
			this.IsPublic = isPublic;
			this.SendByUsername = sentBy;
		}

		protected int GetNextId()
		{
			return ++currentPostId;
		}

		public void Update(string title, bool isPublic)
		{
			this.Title = title;
			this.IsPublic = isPublic;
		}

        public override string ToString()
        {
			return String.Format("{0} - {1} - By: {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}

