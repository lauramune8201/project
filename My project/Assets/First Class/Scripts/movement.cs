using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // 변수란?
    // 데이터를 저장할 수 있는 메모리 공간을 생성하는
    // 것입니다.

    char grade = 'A'; // 접근 지정자를 설정하지 않으면 private로 설정됩니다.
    public float speed = 0;
    private Vector3 direction;

    // Start() : 게임 오브젝트 생성되었을 떄 단 한 번만
    //           호출되는 이벤트 함수입니다.
    private void Start()
    {
        Debug.Log("grade 변수의 값 : " + grade);
        Debug.Log("speed 변수의 값 : " + speed);
        Debug.Log("direction 변수의 값 : " + direction);
    }

    // Update() : 프레임마다 호출되는 이벤트 함수입니다.
    public void Update()
    {
        Debug.Log("Update");
    }

    #region 접근 지정자
    // 클래스 내부의 포함되어 있는 속성에 대한 접근
    // 범위를 제한하는 지정자입니다.

    // public : 클래스 내부와 외부에서 접근을 허용하는 지정자입니다.

    // protcted : 클래스 내부와 자기가 상속하고 있는 클래스에서만
    //            접근을 허용하는 지정자입니다.

    // private : 클래스 내부에서만 접근을 허용하는 지정자입니다.

    #endregion

    #region 자료형
    // 데이터를 저장하기 위해 데이터의 형태를
    // 정해주는 것입니다.

    // 자료형  메모리의 크키
    // bool     1 byte (true 또는 false)
    // char     1 byte (하나의 문자)
    // short    2 byte (정수)
    // int      4 byte (정수)
    // float    4 byte (실수)
    // double   8 byte (실수)
    #endregion
}
