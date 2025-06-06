using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    public Image Img_HPbar;
    public TextMeshProUGUI Txt_HP; // 현재 HP 표시용 텍스트
    public TextMeshProUGUI Txt_Text; // 데미지/회복 메시지 표시용 텍스트

    public int MaxHP = 100; // 최대 HP 설정
    public int Damage; // 클릭당 데미지
    public int HealPoint = 10; // 클릭당 회복량

    private float nowHP; // 현재 HP를 저장할 변수

    void Awake() // 요기 Start 써도 되나요? -> 된다!
    {
        nowHP = MaxHP;
        UpdateHPStatus(); // 초기 HP 상태 업데이트
        Initialized(); // 서버 초기화 시 현재 HP를 최대 HP로 설정
    }

    void Initialized()
    {
        nowHP = MaxHP; // 서버 초기화 시 현재 HP를 최대 HP로 설정
        UpdateHPStatus(); // 초기 HP 상태 업데이트
    }

    private void UpdateHPStatus() // HP 상태 업데이트 함수
    {
        // HP 바 Image fillAmount 업데이트
        Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP바 업데이트

        // 현재 HP 텍스트 업데이트
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 현재 HP 텍스트 업데이트
    }

    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 21); // 5에서 20 사이의 랜덤 데미지 생성
        // HP Image fillAmnt 업데이트
        nowHP -= Damage; // 데미지를 받는다
        if (nowHP < 0) // 만약 현재 HP가 0보다 작다면 0으로 고정
        { 
            nowHP = 0; 
        }

        Txt_Text.text = $"{Damage}의 데미지를 입었다."; // 데미지 텍스트 업데이트
        UpdateHPStatus(); // HP 상태 업데이트
        Debug.Log($"데미지 {Damage} 받음. 현재 HP: {nowHP}"); // 현재 HP 출력
        //Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP바 업데이트

    }

    public void OnClickHeal() // 회복
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        UpdateHPStatus(); // HP 상태 업데이트
        Debug.Log($"회복 {HealPoint} 받음. 현재 HP: {nowHP}"); // 현재 HP 출력
        //Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP바 업데이트
    }
}
