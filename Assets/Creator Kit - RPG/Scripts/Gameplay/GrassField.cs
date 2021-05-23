using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassField : MonoBehaviour
{
    ///<summary>
    /// 2Dの侵入判定
    /// OnTriggerEnter2Dは侵入時に行う判定
    /// </summary>   
    /// <param name="characterCollider">プレイヤーのキャラクター</param>
   
    private void Start()
    {

    Multi(20, 30);
    }

    public void Multi(int a1, int b1)
    {
        int Multi = a1 * b1;
        Debug.Log("あなたが持っているabの数は" + Multi + "です");
    }

    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }
    ///<summary>
    ///2Dの侵入判定
    /// OnTriggerExitは侵入して抜けてからの判定
    /// コーディング規約は、その会社のプログラム描く時の決まり
    /// インデント＝＝段落　見やすくする
    /// </summary>
    /// <param name="characterCollider">プレイヤーのキャラクター</param>
    void OnTriggerExit2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 2f;
    }
}
