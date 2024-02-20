using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How To Build A Fence", "Bobby", 840);

        Comment v1C1 = new Comment("@ashley_735", "Very nice tutorial!");
        Comment v1C2 = new Comment("@zorb38", "Useful, thanks.");
        Comment v1C3 = new Comment("@joe_hubert76", "cool");

        v1.AddComment(v1C1);
        v1.AddComment(v1C2);
        v1.AddComment(v1C3);

        videos.Add(v1);

        Video v2 = new Video("FNAF Night 1", "Markie", 1020);

        Comment v2C1 = new Comment("@lord-dragonnn", "The king of fnaf is back!");
        Comment v2C2 = new Comment("@potato020", "freddyyy");
        Comment v2C3 = new Comment("@nightbearerxX", "are u streaming 2night?");
        Comment v2C4 = new Comment("@gob_dob986", "So nostalgic...");

        v2.AddComment(v2C1);
        v2.AddComment(v2C2);
        v2.AddComment(v2C3);
        v2.AddComment(v2C4);

        videos.Add(v2);

        Video v3 = new Video("Best PC Build Of All Time?", "GameOn", 1500);

        Comment v3C1 = new Comment("@vaderzzz_00", "Nice review");
        Comment v3C2 = new Comment("@sarah3462", "I wish mining wasn't such a big problem, I could never afford that video card...");
        Comment v3C3 = new Comment("@user827462", "thx, ordering mine tonight.");

        v3.AddComment(v3C1);
        v3.AddComment(v3C2);
        v3.AddComment(v3C3);

        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}