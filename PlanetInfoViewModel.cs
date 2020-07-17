using System;
using System.Collections.Generic;
using System.Text;

namespace Astro_DB
{
    class PlanetInfoViewModel
    {
        private PlanetenInfoModel _currentPlanet;


        public PlanetInfoViewModel(int PlanetNumber)
        {
            _currentPlanet = Database.PlanetenDaten[PlanetNumber];
            _imagePath = "/Pictures/" + _currentPlanet.PlanetName +".png";
        }

        public PlanetenInfoModel CurrentPlanet
        {
            get { return _currentPlanet; }
            set { _currentPlanet = value; }
        }

        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }


    }
}
