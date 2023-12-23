using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField] Light _light;
    int i = 0;

    public void ChangeColor()
    {
        switch (i)
        {
            case 0:
                _light.color = Color.red;
                i++;
                break;
            case 1:
                _light.color = Color.green;
                i++;
                break;
            case 2:
                _light.color = Color.blue;
                i++;
                break;
            case 3:
                _light.color = Color.yellow;
                i++;
                break;
            case 4:
                _light.color = Color.cyan;
                i++;
                break;
            case 5:
                _light.color = Color.magenta;
                i++;
                break;
            default:
                _light.color = Color.white;
                i = 0;
                break;
        }
    }
}
