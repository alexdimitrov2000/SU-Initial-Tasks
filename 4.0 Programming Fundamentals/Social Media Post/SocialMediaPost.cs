using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Post
{
    class SocialMediaPost
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> likesDict = new Dictionary<string, int>();

            Dictionary<string, int> dislikesDict = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, string>> commentsDict =
                new Dictionary<string, Dictionary<string, string>>();

            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');
                string command = inputTokens[0];
                string postName = inputTokens[1];

                if (!likesDict.ContainsKey(postName))
                {
                    likesDict.Add(postName, 0);
                }
                if (!dislikesDict.ContainsKey(postName))
                {
                    dislikesDict.Add(postName, 0);
                }
                if (!commentsDict.ContainsKey(postName))
                {
                    commentsDict.Add(postName, new Dictionary<string, string>());
                }

                if (command == "like")
                {
                    likesDict[postName]++;
                }
                else if (command == "dislike")
                {
                    dislikesDict[postName]++;
                }
                else if (command == "comment")
                {
                    string commentator = inputTokens[2];
                    string comment = string.Empty;
                    for (int i = 3; i < inputTokens.Length; i++)
                    {
                        comment += inputTokens[i] + " ";
                    }

                    commentsDict[postName].Add(commentator, comment);
                }
                
                input = Console.ReadLine();
            }

            foreach (var likePair in likesDict)
            {
                string currentPost = likePair.Key;
                Console.WriteLine($"Post: {currentPost} | Likes: {likePair.Value} | Dislikes: {dislikesDict[currentPost]}");

                Dictionary<string, string> currentComments = commentsDict[currentPost];
                Console.WriteLine("Comments:");
                if (currentComments.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comments in currentComments)
                    {
                        string currentCommentator = comments.Key;
                        string currentComment = comments.Value;
                        Console.WriteLine($"*  {currentCommentator}: {currentComment}");
                    }
                }

            }
        }
    }
}
