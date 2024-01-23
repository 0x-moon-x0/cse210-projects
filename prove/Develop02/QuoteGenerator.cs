public class QuoteGenerator
{
    // quotes taken from parade.com and churchofjesuschrist.org
    public List<string> _quotes = new List<string> {
        "'When you have a dream, you've got to grab it and never let go.' — Carol Burnett",
        "'Nothing is impossible. The word itself says 'I'm possible!'' — Audrey Hepburn",
        "'There is nothing impossible to they who will try.' — Alexander the Great",
        "'The bad news is time flies. The good news is you're the pilot.' — Michael Altshuler",
        "'Life has got all those twists and turns. You've got to hold on tight and off you go.' — Nicole Kidman",
        "'Keep your face always toward the sunshine, and shadows will fall behind you.' — Walt Whitman",
        "'Be courageous. Challenge orthodoxy. Stand up for what you believe in. When you are in your rocking chair talking to your grandchildren many years from now, be sure you have a good story to tell.' — Amal Clooney",
        "'Success is not final, failure is not fatal: it is the courage to continue that counts.' — Winston Churchill",
        "'You are never too old to set another goal or to dream a new dream.' — Malala Yousafzai",
        "'At the end of the day, whether or not those people are comfortable with how you're living your life doesn't matter. What matters is whether you're comfortable with it.' — Dr. Phil",
        "'Spread love everywhere you go.' — Mother Teresa",
        "'You don't always need a plan. Sometimes you just need to breathe, trust, let go and see what happens.' — Mandy Hale",
        "'You can be everything. You can be the infinite amount of things that people are.' — Kesha",
        "'What lies behind you and what lies in front of you, pales in comparison to what lies inside of you.' — Ralph Waldo Emerson",
        "'Belief creates the actual fact.' — William James",
        "'Not having the best situation, but seeing the best in your situation is the key to happiness.' — Marie Forleo",
        "'It is during our darkest moments that we must focus to see the light.' — Aristotle",
        "'Try to be a rainbow in someone's cloud.' — Maya Angelou",
        "'Real change, enduring change, happens one step at a time.' — Ruth Bader Ginsburg",
        "'Live your beliefs and you can turn the world around.' — Henry David Thoreau",
        "'Don't try to lessen yourself for the world; let the world catch up to you.' — Beyoncé",
        "'If you don't like the road you're walking, start paving another one!' — Dolly Parton",
        "'The power of imagination makes us infinite.' — John Muir",
        "'God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.' — 2 Timothy 1:7",
        "'Work hard to achieve your dreams. Don’t let discouragement or mistakes delay you.' — Sister Elaine S. Dalton, 'How to Dare Great Things'",
        "'If ye have faith ye hope for things which are not seen, which are true.' — Alma 32:21",
        "'Live in thanksgiving daily.' — Alma 34:38",
        "'Counsel with the Lord in all thy doings, and he will direct thee for good.' — Alma 37:37",
        "'Cultivate an attitude of happiness. Cultivate a spirit of optimism. Walk with faith.' — President Gordon B. Hinckley, 'The Spirit of Optimism'",
        "'Search diligently, pray always, and be believing, and all things shall work together for your good.' — Doctrine and Covenants 90:24"
    };

    public string GetRandomQuote()
    {
        Random random = new Random();
        int index = random.Next(_quotes.Count);
        string randomQuote = _quotes[index];

        return randomQuote;
    }
}