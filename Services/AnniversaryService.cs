using happy_anniversary.Models;

namespace happy_anniversary.Services
{
    // This acts as the Controller — manages all data and business logic
    public class AnniversaryService
    {
        // ✏️ EDIT THESE with your real details
        public string PersonName { get; set; } = "My Love";
        public string YourName { get; set; } = "Saurabh";
        public int YearsTogther { get; set; } = 1;
        public DateTime AnniversaryDate { get; set; } = new DateTime(2025, 11, 22);

        //public string GetAnniversaryMessage() =>
        //    $"Happy {YearsTogther} Year Anniversary, {PersonName}! 💕";
        public string GetAnniversaryMessage() =>
           $"Happy Anniversary, {PersonName}! 💕";

        public int GetDaysTogether() =>
            (DateTime.Today - AnniversaryDate).Days;

        // ✏️ REPLACE src with your actual image paths like "images/photo1.jpg"
        public List<Photo> GetPhotos() => new()
{
    new Photo
    {
        Src = "https://www.shutterstock.com/image-vector/love-dating-romance-feelings-concept-260nw-2042816195.jpg",
        Caption = "Our First Date 💕",
        Date = "The day it all began",
        CropPosition = "center"
    },
    new Photo
    {
        Src = "https://i.pinimg.com/originals/86/8a/9d/868a9d4bedd7a09cf2943782ee061576.jpg",
        Caption = "First Trip Together ✈️",
        Date = "Adventure awaits",
        CropPosition = "top"       // 👈 crops from top for trip image
    },
    new Photo
    {
        Src = "https://pichut.in/wp-content/uploads/best-couple-pic-cartoon-1.webp",
        Caption = "That Crazy Night 🤪",
        Date = "We still laugh about this",
        CropPosition = "center"
    },
    new Photo
    {
        Src = "https://wallpapers.com/images/hd/love-cartoon-silhouette-4kkhxjl630ytfpah.jpg",
        Caption = "Forever & Always 💍",
        Date = "This moment changed everything",
        CropPosition = "center"
    },
    new Photo
    {
        Src = "https://media.istockphoto.com/id/997118460/vector/happy-friendship-day-greeting-card.jpg?s=612x612&w=0&k=20&c=pWy72uZX60DNYQj_zEjnzehUTgInKbbp6hPNhc37qXs=",
        Caption = "Our Favorite Selfie 📱",
        Date = "Candid happiness",
        CropPosition = "center"
    },
    new Photo
    {
        Src = "https://pichut.in/wp-content/uploads/romantic-cartoon-couple-pic-2.webp",
        Caption = "Because I Love You ❤️",
        Date = "Every single day",
        CropPosition = "50% 30%"   // 👈 crops to show upper-center for love image
    }
};

        // ✏️ EDIT these steps with your real story
        public List<CrazyStep> GetCrazySteps() => new()
    {
        new CrazyStep
        {
            StepNumber = 1, Emoji = "👀",
            Title = "The First Look",
            Description = "Remember when our eyes met for the first time? My heart did a full backflip! 🤸",
            Color = "#ff1493"
        },
        new CrazyStep
        {
            StepNumber = 2, Emoji = "😜",
            Title = "The Awkward Phase",
            Description = "Those butterflies, the nervous laughs, and 100 times I typed and deleted messages! 📱",
            Color = "#ff69b4"
        },
        new CrazyStep
        {
            StepNumber = 3, Emoji = "🎭",
            Title = "Our First Fight",
            Description = "We fought over the most stupid thing ever... then couldn't stop laughing about it! 😂",
            Color = "#ff4500"
        },
        new CrazyStep
        {
            StepNumber = 4, Emoji = "🌧️",
            Title = "Dancing in the Rain",
            Description = "That one time we got completely drenched and danced like no one was watching! 💃🕺",
            Color = "#1e90ff"
        },
        new CrazyStep
        {
            StepNumber = 5, Emoji = "🍕",
            Title = "Midnight Cravings",
            Description = "Late Night pizza runs and weird hour ice cream - our kind of romance! 🍦",
            Color = "#ffa500"
        },
        new CrazyStep
        {
            StepNumber = 6, Emoji = "🤪",
            Title = "The Prank Wars",
            Description = "From hiding things to jump scares - we're basically professional pranksters! 😈",
            Color = "#9400d3"
        },
        new CrazyStep
        {
            StepNumber = 7, Emoji = "🎵",
            Title = "Our Song Moments",
            Description = "Singing terribly together like we're absolute rockstars! 🎤🤘",
            Color = "#50fa7b"
        },
        new CrazyStep
        {
            StepNumber = 8, Emoji = "💪",
            Title = "Through Thick & Thin",
            Description = "Every tough moment made us unbreakable. We're the best team ever! 🏆",
            Color = "#ff1493"
        },
        new CrazyStep
        {
            StepNumber = 9, Emoji = "🚀",
            Title = "Building Our Dreams",
            Description = "Planning our future - crazy travel plans, our dream home, and everything in between! 🏠",
            Color = "#ffd700"
        },
        new CrazyStep
        {
            StepNumber = 10, Emoji = "💕",
            Title = "Forever & Always",
            Description = "Here we are - still crazy, still in love, still choosing each other every single day! 💍",
            Color = "#ff69b4"
        }
    };
    }
}
