using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    private int index, colorIndex;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Color[] myColors = new Color[4];
    [SerializeField]
    private float changeTime;
    void Start()
    {
        index = Random.Range(1, 4);
        colorIndex = Random.Range(1, 4);
        text = GetComponent<Text>();
        RandomColor();
        RandomTextString();
    }
    void Update()
    {
        if(changeTime > 0)
            changeTime--;
        else
        {
            index = Random.Range(1, 4);
            colorIndex = Random.Range(1, 4);
            RandomTextString();
            RandomColor();
            changeTime = 1000f;
        }
    }
    void RandomTextString()
    {
        switch (index)
        {
            case 1:
                text.text = "PINK";
                break;
            case 2:
                text.text = "PURPLE";
                break;
            case 3:
                text.text = "YELLOW";
                break;
            case 4:
                text.text = "CYAN";
                break;
        }
    }
    void RandomColor()
    {
        switch (colorIndex)
        {
            case 1:
                text.color = myColors[0];
                break;
            case 2:
                text.color = myColors[1];
                break;
            case 3:
                text.color = myColors[2];
                break;
            case 4:
                text.color = myColors[3];
                break;
        }
    }
}
