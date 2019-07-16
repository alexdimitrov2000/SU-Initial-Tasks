using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_Topics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forumTopics = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            string topic = string.Empty;
            List<string> tags = new List<string>();

            while (input != "filter")
            {
                string[] inputTokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                topic = inputTokens[0];
                tags = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics.Add(topic, new List<string>());
                }
                for (int i = 0; i < tags.Count; i++)
                {
                    if (!forumTopics[topic].Contains(tags[i]))
                    {
                        forumTopics[topic].Add(tags[i]);
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] sequenceOfTags = input.Split(new string[] {", "},
                StringSplitOptions.RemoveEmptyEntries);
            bool shouldPrintTopic = true;

            foreach (var forumTopicsPair in forumTopics)
            {
                shouldPrintTopic = true;
                List<string> currentTags = forumTopicsPair.Value;
                for (int i = 0; i < sequenceOfTags.Length; i++)
                {
                    string currentTag = sequenceOfTags[i];
                    if (!(currentTags.Contains(currentTag)))
                    {
                        shouldPrintTopic = false;
                        break;
                    }
                }

                if (shouldPrintTopic)
                {
                    Console.Write($"{forumTopicsPair.Key} | ");
                    for (int i = 0; i < currentTags.Count; i++)
                    {
                        currentTags[i] = "#" + currentTags[i];
                    }
                    Console.Write($"{string.Join(", ", currentTags)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
