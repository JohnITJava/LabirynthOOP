using UnityEngine;
using System.IO;


namespace BallLabirynthOOP
{

    public sealed class SavedData<T> where T : class, new()
    {
        private static int _saveCounter = 0;
        private string _path;

        public void Save(T value)
        {
            _saveCounter++;
            string savedString = (value.ToString());
            _path = Application.dataPath + "/Saves";
            Directory.CreateDirectory(_path);

            string savedDataPath = Path.Combine(_path, $"r-{_saveCounter}_{GetHashCode()}.txt");
            File.WriteAllText(savedDataPath, savedString);
        }

        //public T Load(string fileName) 
        //{
        //    T sd = JsonUtility.FromJson<>( File.ReadAllText(_path, System.Text.Encoding.UTF8));
        //    return sd;
        //}

    }
}
