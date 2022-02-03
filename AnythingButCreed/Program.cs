// See https://aka.ms/new-console-template for more information

using AnythingButCreed.Models;

List<Song> allSongs = new List<Song> ();

Song palms = new Song("Palms", "Gus Dapperton");
Song velcro = new Song("Velcro", "Spill Tab");
Song charlie = new Song("Charlie", "Mallrat");
Song arms = new Song("With Arms Wide Open", "Creed");
Song prison = new Song("My Own Prison", "Creed");
Song higher = new Song("Higher", "Creed");
Song hurricane = new Song("Hurricane", "Bob Dylan");
Song motorbike = new Song("Motorbike", "Leon Bridges");
Song tusk = new Song("Tusk", "Fleetwood Mac");
Song medicine = new Song("Medicine", "Gus Dapperton");
Song gloom = new Song("MF Gloom", "Strawberry Milk Cult");
Song diver = new Song("Diver", "Lala Lala");

allSongs.Add(palms);
allSongs.Add(velcro);
allSongs.Add(charlie);
allSongs.Add(arms);
allSongs.Add(prison);
allSongs.Add(higher);
allSongs.Add(hurricane);
allSongs.Add(motorbike);
allSongs.Add(tusk);
allSongs.Add(medicine);
allSongs.Add(gloom);
allSongs.Add(diver);

//Once the set is populated with 12 instances of song, use Linq to filter the allSongs list for songs where the artist is not Creed. Set goodSongs equal to the filtered result.
//Loop to print out all the good songs.

List<Song> goodSongs = new List<Song>(allSongs.Where(song => song.Artist != "Creed"));

foreach (Song song in goodSongs)
{
    Console.WriteLine($"{song.Name} by {song.Artist}");
}