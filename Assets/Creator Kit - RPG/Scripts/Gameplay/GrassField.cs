using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassField : MonoBehaviour
{
    ///<summary>
    /// 2D�̐N������
    /// OnTriggerEnter2D�͐N�����ɍs������
    /// </summary>   
    /// <param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
   
    private void Start()
    {

    Multi(20, 30);
    }

    public void Multi(int a1, int b1)
    {
        int Multi = a1 * b1;
        Debug.Log("���Ȃ��������Ă���ab�̐���" + Multi + "�ł�");
    }

    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }
    ///<summary>
    ///2D�̐N������
    /// OnTriggerExit�͐N�����Ĕ����Ă���̔���
    /// �R�[�f�B���O�K��́A���̉�Ђ̃v���O�����`�����̌��܂�
    /// �C���f���g�����i���@���₷������
    /// </summary>
    /// <param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
    void OnTriggerExit2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 2f;
    }
}
