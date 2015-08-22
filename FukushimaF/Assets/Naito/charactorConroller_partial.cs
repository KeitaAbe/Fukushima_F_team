using UnityEngine;
using System.Collections;

public partial class charactorConroller : MonoBehaviour {
    public float rightVelocity
    {
        get
        {
            return Mathf.Abs(Mathf.Cos(Mathf.Deg2Rad * angle));
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Chara Angle:" + angle);
        GUILayout.Label("Chara Speed:" + speed);
        GUILayout.Label("Chara y:" + y);
        GUILayout.Label("Chara rightVel:" + rightVelocity);
    }
}
