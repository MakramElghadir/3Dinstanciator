using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public GameObject model;

    public Renderer modelRenderer;

    public Color newSphereColor;

    public float red, green, blue;

    // Start is called before the first frame update
    void Start()
    {
        modelRenderer = model.GetComponent<Renderer>();
        
    }

    private void Update()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void ChangeColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        newSphereColor = new Color(red, green, blue, 1f);
        modelRenderer.material.SetColor("_Color", newSphereColor);
    }
}
