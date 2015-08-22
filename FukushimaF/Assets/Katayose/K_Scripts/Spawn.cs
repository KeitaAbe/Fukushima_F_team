using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
	// : 発射オブジェクト.
	public GameObject[] obj ;

	private int rand ;

	void Start ()
	{
		rand = Random.Range(0, obj.Length) ;

        GameObject gobj = null;
		switch( rand )
		{
			case 0 :
                gobj = Instantiate<GameObject>(obj[0]);
				break ;

			case 1 :
                gobj = Instantiate<GameObject>(obj[0]);
				break ;

			case 2 :
                gobj = Instantiate<GameObject>(obj[1]);
				break ;

			case 3 :
                gobj = Instantiate<GameObject>(obj[2]);
				break ;				
		}

        if (gobj != null)
        {
            gobj.transform.SetParent(transform.parent, false);
            gobj.transform.position = transform.position;
        }
	}
}
