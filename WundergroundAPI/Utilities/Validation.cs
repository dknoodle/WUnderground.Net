using System;

namespace CreativeGurus.Weather.Wunderground.Utilities
{
    internal static class Validation
    {
        internal static void ValidateState(string State)
        {
            if (State.Length != 2) { throw new ArgumentException("State must be a two character abbreviation."); }
        }
    }
}