using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour // MonoBehaviour는 유티니에서 동작하기 위해 붙은 친구!
{
    int playuerLevel = 10; // 플레이어 레벨을 저장하는 변수입니다.

    // Start is called before the first frame update
    void Start()
    {
        // 유니티에서 시작할 때 호출되는 함수입니다.
        Debug.Log("나의 레벨은" + playuerLevel +"입니다.");
        Debug.Log($"나의 레벨은 {playuerLevel}입니다."); // C# 6.0부터 지원하는 문자열 보간법입니다.
    }


}
