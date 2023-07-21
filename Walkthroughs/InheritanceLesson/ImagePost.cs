using System;
namespace InheritanceLesson
{
	public class ImagePost : Post
	{

		public string ImageURL { get; set; }

        public ImagePost() { }

		public ImagePost(string title, string sentBy, bool isPublic, string imageUrl)
		{
			this.ID = GetNextId();
			this.Title = title;
			this.SendByUsername = sentBy;
			this.IsPublic = isPublic;
			this.ImageURL = imageUrl;
		}

        public override string ToString()
        {
            return String.Format("{0} - {1} - By: {2} - {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}

