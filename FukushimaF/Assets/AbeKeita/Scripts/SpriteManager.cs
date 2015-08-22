using UnityEngine;
using System.Collections;

public class SpriteManager : MonoBehaviour {

    private int random;
    public GameObject childR;
    public GameObject childL;

    [SerializeField]
    Sprite[] body_sprite = new Sprite[5];
    [SerializeField]
    Sprite[] arm_sprite = new Sprite[5];

    // Use this for initialization
    void Start()
    {
        random = Random.Range(0, 5);
        SetNumber(random);      // 作成されたときにランダムで決定
        SetNumberChild(random);
    }

    //数字の設定
    public void SetNumber(int num)
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = body_sprite[num];
    }

    public void SetNumberChild(int numchild)
    {
        //childR = transform.FindChild("ArmR1").gameObject;
        //childL = transform.FindChild("ArmL1").gameObject;

        SpriteRenderer childr = childR.GetComponent<SpriteRenderer>();
        SpriteRenderer childl = childL.GetComponent<SpriteRenderer>();

        childr.sprite = arm_sprite[numchild];
        childl.sprite = arm_sprite[numchild];
    }
}
