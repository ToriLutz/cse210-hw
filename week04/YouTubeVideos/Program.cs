using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1.Title = "♫ I Fell in Lava - A Minecraft Parody of Katy Perry's 'Unconditionally' ♫";
        video1.Author = "TriggerHappyGamer";
        video1.Length = 260;

        Video video2 = new Video();
        video2.Title = "using PINTEREST to build a house in the sims 4";
        video2.Author = "CarynandConnieGaming";
        video2.Length = 1697;

        Video video3 = new Video();
        video3.Title = "I Tried the Best (& Worst) Hot Dog Hacks";
        video3.Author = "Babish Culinary Universe";
        video3.Length = 1697;

        // Add comments to video1 all the ways i could find other than this online was using get: set: and you said we weren't using that
        //format so i did my best
        video1.Comments.Add(new Comment { Username = "tehapplejuice", Text = "Happy Birthdayyyy" });
        video1.Comments.Add(new Comment { Username = "thekeydom6671", Text = "1:27 Im sorry that your friends don't accept you" });
        video1.Comments.Add(new Comment { Username = "TriggerHappyGamer", Text = "it's not their fault they don't understand ;n;" });

        // Add comments to video2
        video2.Comments.Add(new Comment { Username = "Kipyenaa", Text = "Taking AI art and making it real art is a win in my books 🤷‍♀" });
        video2.Comments.Add(new Comment { Username = "Thirrin73", Text = "No worries trying to make sense of the initial house picture yall started with, cause that image was absolutely AI lol. It sucks that pinterest has been pretty much ruined by all the AI." });
        video2.Comments.Add(new Comment { Username = "Chezmeralda", Text = "Pinterest making you fight for your lives with the AI art lo" });
        // Add comments to video3
        video3.Comments.Add(new Comment { Username = "cofleddi", Text = "This video is a beautiful reminder that even prepackaged/cooked food is still ingredients and recipes are just food someone else made once." });
        video3.Comments.Add(new Comment { Username = "bpoirier4", Text = "Hey Andrew, this felt like the first time in awhile where you’ve really had fun with an episode. Thanks man. This one made me briefly exhale a few times 🥲" });
        video3.Comments.Add(new Comment { Username = "DaringDid", Text = "'But this way you feel in charge of the hot dog, and not the other way around' Babish has lived, hasn't he? Truly one of us." });
        video3.Comments.Add(new Comment { Username = "parcell017", Text = "Hotdog." });


        //okay let's hope this displays what i made 
        video1.DisplayVideo();
        video1.DisplayGroup();
        Console.WriteLine();

        video2.DisplayVideo();
        video2.DisplayGroup();
        Console.WriteLine();

        video3.DisplayVideo();
        video3.DisplayGroup();
        Console.WriteLine();


    }
}

class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments = new List<Comment>();


    public void DisplayVideo()
    {
        Console.WriteLine($"{Title} by {Author} it is {Length} seconds long");
    }
    public void DisplayGroup()
    {
           foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
    }
}

class Comment
{
    public string Username;
    public string Text;

    public void DisplayComment()
    {
        Console.WriteLine($"Comment by {Username}: {Text}");
    }

}
