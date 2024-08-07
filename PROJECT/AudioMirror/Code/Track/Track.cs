﻿namespace AudioMirror.Code.Modules
{
    /// <summary>
    /// An audio track's metadata
    /// </summary>
    internal class Track
    {
        // The track's relative path within the music library folder
        private string relPath;
        public string RelPath
        {
            get => relPath;
            set => relPath = value;
        }


        // The track's title
        private string title;
        public string Title
        {
            get => title;
            set => title = value;
        }


        // The track's artists (concatenated)
        private string artists;
        public string Artists
        {
            get => artists;
            set => artists = value;
        }


        // The track's primary artist
        public string PrimaryArtist
        { 
            get => Analyser.ProcessProperty(Artists)[0];
        }


        // The track's album
        private string album;
        public string Album
        { 
            get => album;
            set => album = value;
        }


        // The track's year
        private string year;
        public string Year
        { 
            get => year;
            set => year = value;
        }


        // The track's number (disc order)
        private string trackNumber;
        public string TrackNumber
        { 
            get => trackNumber;
            set => trackNumber = value;
        }


        // The track's genres (concatenated)
        private string genres;
        public string Genres
        {
            get => genres;
            set => genres = value;
        }


        // The track's duration
        private string length;
        public string Length
        { 
            get => length;
            set => length = value;
        }
    }
}
