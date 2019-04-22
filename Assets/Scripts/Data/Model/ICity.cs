﻿namespace CrowdedEarth.Data.Model {
    public interface ICity {
        int ID { get; }
        string Name { get; }
        float Latitude { get; }
        float Longitude { get; }
    }
}