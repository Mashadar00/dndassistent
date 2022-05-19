using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class JsonDataController : MonoBehaviour
{
    public Race races { get; set; }

    private void Awake()
    {
        Race race1 = ScriptableObject.CreateInstance<Race>();
        List<string> vs = new List<string>();
        List<Race> races = new List<Race>();
        Race race = new Race("", 0, 0, 0, 0, 0, 0, 0, "", vs, vs, vs);
        races.Add(race);
        races.Add(race);
        races.Add(race);

        //StreamReader sr = new StreamReader("E:\\Projects\\DndAssistant\\Assets\\StreamingAssets\\Races.json");
        //StreamReader sr = new StreamReader(Path.Combine(Application.streamingAssetsPath, "Races.json"));
        //string sss = sr.ReadToEnd();
        ////races = JsonUtility.FromJson<Race>(sss);
        //sr.Close();
        //Debug.LogWarning(sss);

        string asda = JsonUtility.ToJson(race);

        StreamWriter sw = new StreamWriter("E:\\test\\demo.json");
        sw.WriteLine(asda);
        sw.Close();
    }
}
