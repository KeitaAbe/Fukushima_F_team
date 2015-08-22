using UnityEngine;
using System.Collections;

public class SpriteManager : MonoBehaviour {

    private int i;

    [SerializeField]
    Sprite[] m_sprite = new Sprite[3*2];

    // Update is called once per frame
    void Update()
    {
        if (i++ % 20 == 0)
        {
            SetNumber(Random.Range(0, 3));
        }
    }

    //数字の設定
    public void SetNumber(int num)
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = m_sprite[num];
    }

    public void SetNumberChildRight(int numchildRight)
    {

        SpriteRenderer srchild = gameObject.GetComponentInChildren<SpriteRenderer>();
        srchild.sprite = m_sprite[numchildRight + 3];
    }
}
