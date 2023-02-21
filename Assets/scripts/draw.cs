using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour
{
    [Range(2,512)]
    [SerializeField] private int Texture_Size = 128;
    [SerializeField] private TextureWrapMode Texture_wrap_mode;
    [SerializeField] private FilterMode filter_mode;
    [SerializeField] private Texture2D texture1;
    [SerializeField] private Material materials;
    [SerializeField] private Camera camera1;
    [SerializeField] private Collider colider1;
    [SerializeField] private int brush_size = 8;

    private void OnValidate()
    {
        if(texture1==null)
        {
            texture1 = new Texture2D(Texture_Size, Texture_Size);
        }
        if(texture1.width!=Texture_Size)
        {
            texture1.Reinitialize(Texture_Size, Texture_Size);
        }
        texture1.wrapMode = Texture_wrap_mode;
        texture1.filterMode = filter_mode;
        materials.mainTexture = texture1;
        texture1.Apply();
    }



    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (colider1.Raycast(ray, out hit, 10f))
            {
                if (Singlton.instance.obj_for_draw == "brush")
                { 
                    int rayX = (int)(hit.textureCoord.x * Texture_Size);
                int rayY = (int)(hit.textureCoord.y * Texture_Size);
                    for (int i = 0; i < brush_size; i++)
                    {
                        for (int j = 0; j < brush_size; j++)
                        {
                            texture1.SetPixel(rayX + i, rayY + j, Singlton.instance.color_for_draw);
                        }
                    }
                   
                texture1.Apply();
                 }
                if (Singlton.instance.obj_for_draw == "pencil")
                {
                    int rayX = (int)(hit.textureCoord.x * Texture_Size);
                    int rayY = (int)(hit.textureCoord.y * Texture_Size);
                    for(int i=0;i<brush_size;i++)
                    {
                        for (int j = 0; j < brush_size; j++)
                        {
                            texture1.SetPixel(rayX + i, rayY + j, Color.black);
                        }
                    }
                  
                    texture1.Apply();
                }
                if (Singlton.instance.obj_for_draw == "pouring")
                {
                    for (int i = 0; i <= Texture_Size; i++)
                    {
                        for (int j = 0; j <= Texture_Size; j++)
                        {
                            texture1.SetPixel(i, j, Singlton.instance.color_for_draw);

                        }
                    }
                    texture1.Apply();
                }

                    if (Singlton.instance.obj_for_draw == "eraser")
                    {
                        int rayX = (int)(hit.textureCoord.x * Texture_Size);
                        int rayY = (int)(hit.textureCoord.y * Texture_Size);
                        texture1.SetPixel(rayX, rayY, Color.white);
                        texture1.Apply();
                    }
                
            }
        }
    }
}
