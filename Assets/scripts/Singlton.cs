using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singlton : MonoBehaviour
{
    public static Singlton instance;
    public string obj_for_draw;
    public Color color_for_draw;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;

        }
        else
        {
            Destroy(this);
        }
    }

   
}
