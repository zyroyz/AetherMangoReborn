﻿using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.magenta, 1f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
