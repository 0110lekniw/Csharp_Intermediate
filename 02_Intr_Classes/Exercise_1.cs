using System;

namespace _02_Intr_Classes
{
    public class Stopwatch
    {
        private DateTime _beginTime;
        private TimeSpan _timeLength;
        private void Start()
        {
            if (_beginTime != default)
                throw new ArgumentException("Stopwatch has not been stoped yet.");
            _beginTime = DateTime.Now;
                
        }

        private void Stop()
        {
            if (_beginTime == default)
                throw new ArgumentException("Stopwatch has not been started yet.");
            
            _timeLength += DateTime.Now - _beginTime;
            _beginTime = default;
        }

        private TimeSpan Result()
        {
            return _timeLength;
        }

        public static void Timer()
        {  
            var stopwatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("Write Start, Stop or Exit: ");
                var InputData = Console.ReadLine();

                if (InputData == "Start")
                    stopwatch.Start();

                else if (InputData == "Stop")
                    stopwatch.Stop();

                else if (InputData == "Exit")
                {
                    Console.WriteLine("The total time is {0}", stopwatch.Result());
                    break;
                }

                else Console.WriteLine("Wrong Input");
            }
        }
    }

    public class StackOverflowPost
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime Date = DateTime.Now;
        public int VoteCount { get; private set; }

        

        public void DownVote()
        {
            VoteCount -= 1;
        }

        public void UpVote()
        {
            VoteCount += 1;
        }
    }

    public class CreatingPost
    {
        public static void NewPost()
        {
            var post = new StackOverflowPost();
            Console.WriteLine("Enter the Title: ");
            post.Title = Console.ReadLine();
            Console.WriteLine("Enter the description: ");
            post.Description = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Write Up to UpVote, Down to DownVote or Exit: ");
                var inputData = Console.ReadLine();
                if (inputData == "Up") post.UpVote();
                else if (inputData == "Down") post.DownVote();
                else if (inputData == "Exit")
                {
                    Console.WriteLine("The post {0} was created {1}, its total number of votes is {2} " +
                        "and it cointains given description: {3}",post.Title, post.Date, post.VoteCount, post.Description);
                    break;
                }
                else Console.WriteLine("Wrong Input");

            }


        }
    }
}
