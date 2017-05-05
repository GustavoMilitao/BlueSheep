﻿using System;
using System.Collections;

namespace BlueSheep.DTO
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServerComment { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Language { get; set; }
        public PopulationId Population { get; set; }
        public GameTypeId GameType { get; set; }
        public CommunityId Comunity { get; set; }
        public ArrayList RestrictedToLanguages { get; set; }
    }
}