using UnityEngine;
using System.Collections;

public class Effectmanager : MonoBehaviour {

    public GameObject damage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            EffectDamage();
        }
    }

    public void EffectDamage()
    {
        Instantiate(damage,transform.position, Quaternion.identity);
    }
}
