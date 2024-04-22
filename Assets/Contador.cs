using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public float elapsedTime;
    public string textedTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        textedTime = elapsedTime.ToString();
        print(minutes + ":" + seconds);

        GameEvents.NewTimeValues.Invoke(minutes, seconds);
    }
}
