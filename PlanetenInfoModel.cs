namespace Astro_DB
{
    public class PlanetenInfoModel
    {
        //select planet_ID, planets.Name, Age, Aphelion, diameter, mass, rotation_Period, temperature, luminosity, gravity, Moons_Number, planetcomposition_Type.name from planets join planetcomposition_Type on(planets.Planetcompositiontype_ID = planetcomposition_Type.Planetcompositiontype_ID)
        public int Planet_ID { get; set; }
        public string PlanetName { get; set; }
        public string Alter { get; set; }
        public string Aphelion { get; set; }
        public string Diameter { get; set; }
        public string Mass { get; set; }
        public string Rotation_Period { get; set; }
        public string Temperature { get; set; }
        public string Luminosity { get; set; }
        public string Gravity { get; set; }
        public string Moons_Number { get; set; }//TODO: ändern auf int
        public string CompositionName { get; set; }
    }
}
