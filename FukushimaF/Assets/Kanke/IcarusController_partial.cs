using UnityEngine;
using System.Collections;

public partial class IcarusController : MonoBehaviour {
    public float rightVelocity
    {
        get
        {
			return speed * Mathf.Cos( angle * Mathf.Deg2Rad );
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Chara Angle:" + angle);
        GUILayout.Label("Chara Speed:" + speed);
        GUILayout.Label("Chara rightVel:" + rightVelocity);
    }
}
