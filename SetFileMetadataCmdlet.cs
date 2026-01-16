using System.Management.Automation;

namespace AVClub
{
    [Cmdlet(VerbsCommon.Set, "FileMetadata")]
    public class SetFileMetadataCmdlet : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
        [ValidatePathExists]
        public string FilePath { get; set; }

        [Parameter(Mandatory = false)]
        public string Title { get; set; }

        [Parameter(Mandatory = false)]
        public string[] AlbumArtists { get; set; }

        [Parameter(Mandatory = false)]
        public string Album { get; set; }

        [Parameter(Mandatory = false)]
        public string[] Composers { get; set; }

        [Parameter(Mandatory = false)]
        public string[] Genres { get; set; }

        [Parameter(Mandatory = false)]
        public uint Track { get; set; }

        [Parameter(Mandatory = false)]
        public uint TrackCount { get; set; }

        [Parameter(Mandatory = false)]
        public uint Disc { get; set; }

        [Parameter(Mandatory = false)]
        public uint DiscCount { get; set; }

        [Parameter(Mandatory = false)]
        public uint Year { get; set; }

        [Parameter(Mandatory = false)]
        public string Publisher { get; set; }

        [Parameter(Mandatory = false)]
        public string[] Performers { get; set; }

        [Parameter(Mandatory = false)]
        public string Comment { get; set; }

        [Parameter(Mandatory = false)]
        public string Copyright { get; set; }

        [Parameter(Mandatory = false)]
        public string Description { get; set; }

        [Parameter(Mandatory = false)]
        public string Lyrics { get; set; }

        [Parameter(Mandatory = false)]
        public string Subtitle { get; set; }

        protected override void ProcessRecord()
        {
            using (var f = TagLib.File.Create(FilePath))
            {
                if (MyInvocation.BoundParameters.ContainsKey("Title")) f.Tag.Title = Title;
                if (MyInvocation.BoundParameters.ContainsKey("AlbumArtists")) f.Tag.AlbumArtists = AlbumArtists;
                if (MyInvocation.BoundParameters.ContainsKey("Album")) f.Tag.Album = Album;
                if (MyInvocation.BoundParameters.ContainsKey("Composers")) f.Tag.Composers = Composers;
                if (MyInvocation.BoundParameters.ContainsKey("Genres")) f.Tag.Genres = Genres;
                if (MyInvocation.BoundParameters.ContainsKey("Track")) f.Tag.Track = Track;
                if (MyInvocation.BoundParameters.ContainsKey("TrackCount")) f.Tag.TrackCount = TrackCount;
                if (MyInvocation.BoundParameters.ContainsKey("Disc")) f.Tag.Disc = Disc;
                if (MyInvocation.BoundParameters.ContainsKey("DiscCount")) f.Tag.DiscCount = DiscCount;
                if (MyInvocation.BoundParameters.ContainsKey("Year")) f.Tag.Year = Year;
                if (MyInvocation.BoundParameters.ContainsKey("Publisher")) f.Tag.Publisher = Publisher;
                if (MyInvocation.BoundParameters.ContainsKey("Performers")) f.Tag.Performers = Performers;
                if (MyInvocation.BoundParameters.ContainsKey("Comment")) f.Tag.Comment = Comment;
                if (MyInvocation.BoundParameters.ContainsKey("Copyright")) f.Tag.Copyright = Copyright;
                if (MyInvocation.BoundParameters.ContainsKey("Description")) f.Tag.Description = Description;
                if (MyInvocation.BoundParameters.ContainsKey("Lyrics")) f.Tag.Lyrics = Lyrics;
                if (MyInvocation.BoundParameters.ContainsKey("Subtitle")) f.Tag.Subtitle = Subtitle;
                f.Save();
            }
        }
    }
}