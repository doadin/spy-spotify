﻿using EspionSpotify.Spotify;
    
namespace EspionSpotify.Models
{
    public class SpotifyWindowInfo
    {
        public string WindowTitle { get; set; }
        public bool IsPlaying { get; set; }

        public bool IsTitledSpotify { get => SpotifyStatus.WindowTitleIsSpotify(WindowTitle); }
    }
}
