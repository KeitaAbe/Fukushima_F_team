using UnityEngine;
using UnityEditor;
using System.Collections;

#if false
public class WaveController_Editor : Editor
{
    public void OnSceneGUI()
    {
        var p = transform.position;
        var obj = target as WaveController;
        var halfSize = obj._size * 0.5f;
        var pos = new Vector3[]{
            new Vector3(p.x - halfSize.x, p.y - halfSize.y, p.z),
            new Vector3(p.x + halfSize.x, p.y - halfSize.y, p.z),
            new Vector3(p.x + halfSize.x, p.y + halfSize.y, p.z),
            new Vector3(p.x - halfSize.x, p.y + halfSize.y, p.z),
        };
        Handles.DrawSolidRectangleWithOutline(pos, Color.whie, Color.black);
    }
}
#endif