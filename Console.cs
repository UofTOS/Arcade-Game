using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    // Start is called before the first frame update
    public int var;
    private Material mat;
    public Color newColor;
    public KeyCode changecol;

    public void awake()
    {
        Debug.Log (" This is when the awake module is being called at the beginning of the code.");
    }

    void Start()
    {
        mat.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        mat.color = newColor;
    }
}
