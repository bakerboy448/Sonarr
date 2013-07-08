﻿using System;
using Marr.Data;
using NzbDrone.Core.Datastore;
using NzbDrone.Core.MediaFiles;


namespace NzbDrone.Core.Tv
{
    public class Episode : ModelBase
    {
        public int TvDbEpisodeId { get; set; }
        public int SeriesId { get; set; }
        public int EpisodeFileId { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public DateTime? AirDate { get; set; }

        public string Overview { get; set; }
        public Boolean Ignored { get; set; }
        public Nullable<Int32> AbsoluteEpisodeNumber { get; set; }
        public int SceneSeasonNumber { get; set; }
        public int SceneEpisodeNumber { get; set; }

        public String SeriesTitle { get; private set; }

        public LazyLoaded<EpisodeFile> EpisodeFile { get; set; }

        public Boolean HasFile
        {
            get { return EpisodeFileId > 0; }
        }
    }
}