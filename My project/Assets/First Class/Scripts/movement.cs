using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // ������?
    // �����͸� ������ �� �ִ� �޸� ������ �����ϴ�
    // ���Դϴ�.

    char grade = 'A'; // ���� �����ڸ� �������� ������ private�� �����˴ϴ�.
    public float speed = 0;
    private Vector3 direction;

    // Start() : ���� ������Ʈ �����Ǿ��� �� �� �� ����
    //           ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void Start()
    {
        Debug.Log("grade ������ �� : " + grade);
        Debug.Log("speed ������ �� : " + speed);
        Debug.Log("direction ������ �� : " + direction);
    }

    // Update() : �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    public void Update()
    {
        Debug.Log("Update");
    }

    #region ���� ������
    // Ŭ���� ������ ���ԵǾ� �ִ� �Ӽ��� ���� ����
    // ������ �����ϴ� �������Դϴ�.

    // public : Ŭ���� ���ο� �ܺο��� ������ ����ϴ� �������Դϴ�.

    // protcted : Ŭ���� ���ο� �ڱⰡ ����ϰ� �ִ� Ŭ����������
    //            ������ ����ϴ� �������Դϴ�.

    // private : Ŭ���� ���ο����� ������ ����ϴ� �������Դϴ�.

    #endregion

    #region �ڷ���
    // �����͸� �����ϱ� ���� �������� ���¸�
    // �����ִ� ���Դϴ�.

    // �ڷ���  �޸��� ũŰ
    // bool     1 byte (true �Ǵ� false)
    // char     1 byte (�ϳ��� ����)
    // short    2 byte (����)
    // int      4 byte (����)
    // float    4 byte (�Ǽ�)
    // double   8 byte (�Ǽ�)
    #endregion
}
