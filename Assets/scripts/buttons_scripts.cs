using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons_scripts : MonoBehaviour
{
    public GameObject Brush;
    public GameObject Pencil;
    public GameObject Eraser;
    public GameObject Pouring;

    public void Button_brush()
    {
        Singlton.instance.obj_for_draw = Brush.gameObject.tag;
    }
    public void Button_pencil()
    {
        Singlton.instance.obj_for_draw = Pencil.gameObject.tag;
    }
    public void Button_eraser()
    {
        Singlton.instance.obj_for_draw = Eraser.gameObject.tag;
    }
    public void Button_pouring()
    {
        Singlton.instance.obj_for_draw = Pouring.gameObject.tag;
    }
    public void Button_RED()
    {
        Singlton.instance.color_for_draw = Color.red;
    }
    public void Button_GREEN()
    {
        Singlton.instance.color_for_draw = Color.green;
    }
    public void Button_YELLOW()
    {
        Singlton.instance.color_for_draw = Color.yellow;
    }
    public void Button_BLUE()
    {
        Singlton.instance.color_for_draw = Color.blue;
    }
}
