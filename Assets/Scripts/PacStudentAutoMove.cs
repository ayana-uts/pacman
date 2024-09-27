using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentAutoMove : MonoBehaviour
{
    // PacStudentが移動するコーナーの位置を設定
    private Vector3[] corners = new Vector3[4];

    // 移動速度
    public float speed = 2f;

    // 現在の目標コーナーのインデックス
    private int currentCorner = 0;

    // Start is called before the first frame update
    void Start()
    {
        // コーナーの座標を設定
        // 右下 (0, 0), 左下 (-5.5, 0), 左上 (-5.5, 3.5), 右上 (0, 3.5)
        corners[0] = new Vector3(0, 0, 0);      // 右下
        corners[1] = new Vector3(-5.5f, 0, 0);  // 左下
        corners[2] = new Vector3(-5.5f, 3.5f, 0);  // 左上
        corners[3] = new Vector3(0, 3.5f, 0);   // 右上

        // 最初の目標位置を設定
        transform.position = corners[currentCorner];
    }

    // Update is called once per frame
    void Update()
    {
        // 現在のコーナーに向かって移動
        MoveToNextCorner();
    }

    // コーナーに向かって移動する関数
    void MoveToNextCorner()
    {
        // 次のコーナーまでの移動
        Vector3 targetPosition = corners[currentCorner];
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // コーナーに到達したか確認
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // 次のコーナーへ移動
            currentCorner = (currentCorner + 1) % corners.Length;
        }
    }
}
