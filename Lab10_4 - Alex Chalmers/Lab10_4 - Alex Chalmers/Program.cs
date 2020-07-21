using System;

namespace Lab10_4___Alex_Chalmers
{
    class Program
    {
        public static void Main(string[] args)
        {
            MusicArtist prince = new MusicArtist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            Mediaplayer player = new Mediaplayer();
            player.PlayMedia(prince);

            Audiobooks howto = new Audiobooks("How to Win Friends and Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            MovieSoundtracks starWars = new MovieSoundtracks("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);
        }
    }
}
