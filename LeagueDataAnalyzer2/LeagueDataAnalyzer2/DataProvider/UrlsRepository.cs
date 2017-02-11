﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.DataProvider
{
    class UrlsRepository
    {
        private static string riotKey = "?api_key=" + ConfigurationManager.AppSettings.Get("riot_key");

        public static string GetPlayerByName(string name)
        {
            return "https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/by-name/" + name + riotKey;
        }
    }
}