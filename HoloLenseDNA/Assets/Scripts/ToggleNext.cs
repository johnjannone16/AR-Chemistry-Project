using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleNext : MonoBehaviour
{
    private GameObject[] moleculeList;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        moleculeList = new GameObject[transform.childCount];
        //fill arrray with models
        for (int i = 0; i < transform.childCount; i++)
        {
            moleculeList[i] = transform.GetChild(i).gameObject;
        }

        //toggle renderer
        foreach (GameObject go in moleculeList)
        {
            go.SetActive(false);
        }

        //toggle first index
        if (moleculeList[0])
        {
            moleculeList[0].SetActive(true);
        }
    }


    public void toggleLeft()
    {
        //toggle off current model
        moleculeList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = moleculeList.Length - 1;
        }

        //toggle on new model
        moleculeList[index].SetActive(true);

        Debug.Log("toggle left");
    }

    public void toggleRight()
    {
        //toggle off current model
        moleculeList[index].SetActive(false);
        index++;
        if (index == moleculeList.Length)
        {
            index = 0;
        }

        //toggle on new model
        moleculeList[index].SetActive(true);

        Debug.Log("toggle right");
    }
}
