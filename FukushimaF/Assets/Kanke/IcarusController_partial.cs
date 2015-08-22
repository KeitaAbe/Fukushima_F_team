using UnityEngine;
using System.Collections;

public partial class IcarusController : MonoBehaviour {
    public float rightVelocityRate
    {
        get
        {
            return Mathf.Cos(angle * Mathf.Deg2Rad);
        }
    }
    public float rightVelocity
    {
        get
        {
            return speed * rightVelocityRate;
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Chara Angle:" + angle);
        GUILayout.Label("Chara Speed:" + speed);
        GUILayout.Label("Chara rightVel:" + rightVelocity);
        GUILayout.Label("Chara rightVelRate:" + rightVelocityRate);
    }
}
