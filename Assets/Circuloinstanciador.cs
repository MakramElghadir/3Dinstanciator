using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuloinstanciador : MonoBehaviour
{
    public GameObject cubePrefab;
    public float convenientSpawnCounter = 1;    
    public float xAxis = 2;
    public float yAxis = 2;
    public float zAxis = 0;
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    private void Update()
    {
        if (convenientSpawnCounter <= 6)
        {
            GameEvents.NewTimeValues.AddListener(OnNewTimeValues);
        }
    }

    // Update is called once per frame
    public void OnNewTimeValues(int minutes, int seconds)
    {

        if (seconds > convenientSpawnCounter)
        {
            Vector3 nextPosition = new Vector3(xAxis, yAxis, zAxis);
            Vector3 otherNextPosition = new Vector3(0, yAxis, 0);
            xAxis++;
            yAxis++;
            zAxis++;
            convenientSpawnCounter++;
            Instantiate(cubePrefab, nextPosition, Quaternion.identity).GetComponent<MeshRenderer>().material.color=new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Instantiate(cubePrefab, otherNextPosition, Quaternion.identity).GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }

    }
}
