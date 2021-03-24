using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comments> Comments = new List<Comments>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }


        public void AddComment(Comments x)
        {
            Comments.Add(x);
        }
        public void RemoveComment(Comments x)
        {
            Comments.Remove(x);
        }

        public override string ToString()
        {
            StringBuilder x = new StringBuilder();

            x.AppendLine(Title);
            x.Append(Likes);
            x.AppendLine(" - Likes");
            x.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            x.AppendLine(Content);
            x.AppendLine("Comments: ");
            foreach (Comments i in Comments)
            {
                x.AppendLine(i.Text);
            }
            return x.ToString();
        }
    }
}
