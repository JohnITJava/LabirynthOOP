﻿using TMPro;
using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "BonusCubeData", menuName = "Data/Bonus Cube", order = 2)]
    public sealed class BonusCubeData : ScriptableObject
    {
        public BonusCube BonusCube;
    }
}
