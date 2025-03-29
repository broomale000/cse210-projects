using System;

class Program
{
    static void Main(string[] args)
    {
        Video DogVid = new Video("Life of Dogs", "John Doe", "3/19/2025", 75);
        Video CatVid = new Video("Life of Cats", "John Doe", "3/20/2025", 60);
        Video HorseVid = new Video("Life of Horses", "John Doe", "3/21/2025", 120);

        DogVid.AddComment(new Comment("Joe Joe", "This vid is great!"));
        DogVid.AddComment(new Comment("Somebody123", "The worst vid!"));
        DogVid.AddComment(new Comment("WhyNot?", "What is the meaning of life?"));

        CatVid.AddComment(new Comment("Joe Joe", "This vid is great!"));
        CatVid.AddComment(new Comment("Somebody123", "The worst vid!"));
        CatVid.AddComment(new Comment("WhyNot?", "What is the meaning of life?"));

        HorseVid.AddComment(new Comment("Joe Joe", "This vid is great!"));
        HorseVid.AddComment(new Comment("Somebody123", "The worst vid!"));
        HorseVid.AddComment(new Comment("WhyNot?", "What is the meaning of life?"));

        DogVid.DisplayAll();
        CatVid.DisplayAll();
        HorseVid.DisplayAll();
    }
}