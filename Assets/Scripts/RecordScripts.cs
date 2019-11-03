using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class RecordScripts : MonoBehaviour
{
    private float timer;

    [SerializeField]
    private Text textRecord;

    [SerializeField]
    private Text textTimer;

    private int record;

    void Start()
    {
        record = PlayerPrefs.GetInt("record");
        textRecord.text = $"Record:{record} sec.";
    }
    void Update()
    {
        if (GameScripts.isStart == true)
        {
            timer += Time.deltaTime;
            int time = (int)timer;
            textTimer.text = $"Time: {time} s.";
            if (time > record)
            {
                textTimer.color = Color.red;
                record = time;
                PlayerPrefs.SetInt("record", record);
                textRecord.text = $"Record:{record} sec.";
            }
        }
    }
}
