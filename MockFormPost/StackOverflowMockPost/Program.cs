using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowMockPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var newFormPost = new FormPost();
            var quitCount = 0;

           

                Console.WriteLine("Please enter the title of your post");
                var postTitle = Console.ReadLine();
                Console.WriteLine("Please Give a description of your post");
                var postDescription = Console.ReadLine();

                var postData = newFormPost.newFormPost("Title: " + postTitle, "description: " + postDescription);
                
                //newFormPost.ForumPostVote(vote);
                Console.WriteLine(postData);

                while (quitCount == 0)
                {
                Console.WriteLine("Did you find this post helpful? type \"exit\" to leave the program");
                var voteReply = Console.ReadLine().ToLower();

                if (voteReply == "exit")
                {
                    quitCount += 1;
                   
                }

                var upVotes = newFormPost.ForumPostVote(voteReply);

                Console.WriteLine(upVotes + postData);
                Console.ReadLine();
                }
        }
    }

    class FormPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        private int UpVote { get; set; }
        private int DownVote { get; set; }
        private DateTime PostDate { get; set; }

        public string newFormPost(string title, string description)
        {
            var postDate = DateTime.Now;

            return title + ", " + description + ", " + postDate;
        }

        public int ForumPostVote(string vote)
        {
            //string[] upVotes = new string[]{};
            List<string> upVotes = new List<string>(){};
            List<string> downVotes = new List<string>(){};

                if (vote == "yes")
                {
                    upVotes.Add(vote);
                }
                else if (vote == "no")
                {
                    downVotes.Add(vote);
                }
            return upVotes.Count;
        }

    }
}
