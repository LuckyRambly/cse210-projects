using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("TUTORIALES EPICOS DE MINECRAFT - Como hacer PAN", "EsVandal" , 170);

        // Comments
        video1.AddComment(new Comment("RamonLamas", "Amo tus videos Vandal!"));
        video1.AddComment(new Comment("RamonRayo", "Olvide la contraseña de mi cuenta original, pero ahora te sigo aqui!"));
        video1.AddComment(new Comment("LuckyRambly", "Volvi a olvidar la contraseña de mi cuenta :c... Real story here"));
        
        // List
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Chocolate cake recipe", "Cooking&Stuff", 900);

        // Comments
        video2.AddComment(new Comment("Martha", "Oh dear, that was a really sweet cake, too much sugar"));
        video2.AddComment(new Comment("Chincheto", "Dude, why I'm seeing this if I don't speak english???"));
        video2.AddComment(new Comment("weirddude99", "It works as an musical instrument?"));
        video2.AddComment(new Comment("NotSpongebob", "hahahahahahahaha"));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("The size of life", "Kurzgesagt", 340);

        // Comments
        video3.AddComment(new Comment("anon44", "I feel bad for the elephant."));
        video3.AddComment(new Comment("geekdude", "So... I understand nothing"));
        video3.AddComment(new Comment("EvilCat", "Meow meow meow."));
        
        videos.Add(video3);

        // Great title
        Console.WriteLine("----------Video stadistics----------");
        
        // Loop stuff
        foreach (Video video in videos)
        {
            Console.WriteLine($"\n--- VIDEO: {video.GetTitle()} ---");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Lenght: {video.GetLengthSeconds()} secs");
            
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}"); 
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("COMMENTS:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  > {comment.GetCommenterName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine("--------------------");
        }
    }
}