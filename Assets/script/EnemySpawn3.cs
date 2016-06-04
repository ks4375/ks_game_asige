using UnityEngine;
using System.Collections;

public class EnemySpawn3 : MonoBehaviour
{
    public GameObject enemy;    //敵オブジェクト
    public Transform ground;    //地面オブジェクト
    public float count = 1;     //一度に何体のオブジェクトをスポーンさせるか
    public float interval = 1;  //何秒おきに敵を発生させるか
    private float timer;        //経過時間
    public GameObject player_pos; //playerのポジション
    // Use this for initialization
    void Start()
    {
        Spawn();    //初期スポーン
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    //経過時間加算
        if (timer >= interval)
        {
            Spawn();    //スポーン実行
            timer = 0;  //初期化
        }
    }

    void Spawn()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 _player_pos = player_pos.transform.position;
            float x = Random.Range(-1.6f, 1.6f);
            float y = Random.Range(-0.02f, 0.03f);
            Vector3 pos = new Vector3(x, y + _player_pos.y + 3.0f, 0) + ground.position;
            GameObject.Instantiate(enemy, pos, Quaternion.identity);
        }
    }
}