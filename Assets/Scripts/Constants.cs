using UnityEngine;
using System.Collections.Generic;

namespace BallLabirynthOOP
{
    public static class Constants
    {
        public static List<Vector3> StartPositions = new List<Vector3>() {
            new Vector3(-1.0f, 0.1f, 14.5f),
            new Vector3(-7.0f, 0.1f, 14.5f),
            new Vector3(-15.0f, 0.1f, 14.0f)};

        public static List<Vector3> FinishPositions = new List<Vector3>() {
            new Vector3(-13.0f, 0.1f, 14.0f),
            new Vector3(-1.0f, 0.1f, 14.0f)};

        public static List<Vector3> BonusPositions = new List<Vector3>()
        {
            new Vector3(-1.15f, 0.7f, 11.0f),
            new Vector3(3.0f, 0.7f, 11.0f),
            new Vector3(1.3f, 0.7f, 13.0f),
            new Vector3(-3.0f, 0.7f, 9.0f),
            new Vector3(0.8f, 0.7f, 9.0f),
            new Vector3(3.0f, 0.7f, 2.0f),
            new Vector3(-3.0f, 0.7f, 5.0f),
            new Vector3(-1.0f, 0.7f, 3.0f),
            new Vector3(-7.0f, 0.7f, 3.0f),
            new Vector3(-5.0f, 0.7f, 1.0f),
            new Vector3(-3.0f, 0.7f, -5.0f),
            new Vector3(3.0f, 0.7f, -3.0f),
            new Vector3(3.0f, 0.7f, -9.0f),
            new Vector3(-1.0f, 0.7f, -11.0f),
            new Vector3(1.0f, 0.7f, -7.0f),
            new Vector3(-1.2f, 0.7f, -13.0f),
            new Vector3(-7.0f, 0.7f, -7.0f),
            new Vector3(-9.0f, 0.7f, -7.0f),
            new Vector3(-15.0f, 0.7f, -7.0f),
            new Vector3(-19.0f, 0.7f, -9.0f),
            new Vector3(-7.0f, 0.7f, -9.0f),
            new Vector3(-7.0f, 0.7f, -1.0f),
            new Vector3(-11.0f, 0.7f, 0.8f),
            new Vector3(-17.0f, 0.7f, -4.0f),
            new Vector3(-17.0f, 0.7f, -4.0f),
            new Vector3(-11.0f, 0.7f, 3.0f),
            new Vector3(-13.0f, 0.7f, 3.0f),
            new Vector3(-19.0f, 0.7f, 5.0f),
            new Vector3(-23.0f, 0.7f, 0.8f),
            new Vector3(-19.0f, 0.7f, -5.0f),
            new Vector3(-21.0f, 0.7f, 6.7f),
            new Vector3(-21.0f, 0.7f, 11.0f),
            new Vector3(-19.0f, 0.7f, 11.0f),
            new Vector3(-15.0f, 0.7f, 13.0f),
            new Vector3(-11.0f, 0.7f, 13.0f),
            new Vector3(-17.0f, 0.7f, 9.0f),
            new Vector3(-5.0f, 0.7f, 5.0f) };
    }
}