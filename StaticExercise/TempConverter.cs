﻿using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsuis(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
    }
}

