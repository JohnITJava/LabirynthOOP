using UnityEngine;
using System;


namespace BallLabirynthOOP
{
    internal struct EnemyInfo
    {
        private Type _type;
        private string _name;
        private Color _color;

        public EnemyInfo(Type type, string name, Color color) 
        {
            _type = type;
            _name = name;
            _color = color;
        }

        public string ToString(string formatMessage)
        {
            return String.Format(formatMessage, _type.Name, _name, _color);
        }
    }
}
