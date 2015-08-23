using UnityEngine;
using System.Collections;

public class WaveController : MonoBehaviour
{
    enum State
    {
        Spawn,
        NextSpawn,
    }
    State _status = State.Spawn;

    void Start()
    {
        var newPos = transform.localPosition;
        newPos.z += -5f;
        transform.localPosition = newPos;
    }

    void Update()
    {
        var scrollController = ScrollController.instance;
        if (!scrollController.canScroll)
        {
            return;
        }

        var newPos = transform.localPosition;
        newPos.x += scrollController.scrollSpeed * Time.smoothDeltaTime;
        transform.localPosition = newPos;

        switch (_status)
        {
            case State.Spawn:
                //中間地点通過をチェック
                {
                    //とりあえず座標0のところ（画面中央）を中韓地点に
                    if (transform.position.x < 0f)
                    {
                        scrollController.SpawnWave();//次のやつを生成
                        _status = State.NextSpawn;
                    }
                }
                break;
            case State.NextSpawn:
                //Kill地点通過をチェック
                {
                    if (transform.position.x < scrollController.waveKillLocator.position.x)
                    {
                        DestroyObject(gameObject);
                        return;
                    }
                }
                break;
        }
    }
}
