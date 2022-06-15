using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisualizerController : MonoBehaviour
{
    public Misil [] currentMisil;
    public GameObject currentActiveObject;


    public void Start()
    {
        currentActiveObject = currentMisil[0].gameObject;
    }

    public void activateMisil(int indexMisil) {
        currentMisil[indexMisil].gameObject.SetActive(true);
    }

    public int getCurrentActiveObject(int indexMisil) {
        int currentMisil = indexMisil;
        return currentMisil;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
