using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ArrayList0609 : MonoBehaviour
{
    string[] Character = { "정은교", "김한나", "손석현", "이윤호", "엄지성", "신채현", "차정훈", "최현석" };
    List<string> CharacterList = new List<string>();

    void Start()
    {
        CharacterList.Add("정은교");
        CharacterList.Add("김한나");
        CharacterList.Add("손석현");
        CharacterList.Add("이윤호");
        CharacterList.Add("엄지성");
        CharacterList.Add("신채현");
        CharacterList.Add("차정훈");
        CharacterList.Add("최현석");

        ArrayGacha(); // Start 함수에서 ArrayGacha 함수를 호출하여 캐릭터를 뽑는다.
    }

    public void ArrayGacha()
    { 
        int randomValue = Random.Range(0, Character.Length); // 0이상 Character.Length 미만의 랜덤한 값을 받아 오겠다. = 0~7까지!
        Debug.Log("출력 확인"); // 출력 확인용 로그
        Debug.Log(Character[randomValue] + "을(를) 뽑았다!"); // 랜덤으로 뽑힌 캐릭터를 출력한다.
    }

}
