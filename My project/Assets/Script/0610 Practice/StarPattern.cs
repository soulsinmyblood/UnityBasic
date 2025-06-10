using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPattern : MonoBehaviour
{
    // 변수 선언
    string star;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("스크립트 실행 테스트");

        // 순서대로 호출할 함수들
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    // 별 모양을 출력하는 함수들
    // Phase1: 직각삼각형 모양 별 출력
    public void Phase1()
    {
        // star 변수를 빈 문자열로 초기화
        star = string.Empty;

        // 바깥쪽 for문: 총 5줄 생성
        for (int i = 0; i < 5; i++)
        {
            // 안쪽 for문: 각 줄에 별 개수(column)을 추가
            // 현재 줄 번호 i에 +1 만큼 별 찍기...? (첫 줄 1개, 둘째 줄 2개, ...)
            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }

        Debug.Log(star);
    }

    // Phase2: 역직각삼각형 모양 별 출력
    public void Phase2()
    {
        // star 변수를 빈 문자열로 초기화
        star = string.Empty;

        // 바깥쪽 for문: 총 5줄 생성
        for (int i = 5; i > 0; i--)
        {
            // 안쪽 for문: 각 줄에 별 개수(column)을 추가
            // 현재 줄 번호 i에 +1 만큼 별 찍기...? (첫 줄 5개, 둘째 줄 4개, ...)
            for (int j = 0; j < i; j++)
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase3: 우측 방향 삼각형 모양 별 출력
    public void Phase3()
    {
        star = string.Empty;

        // 바깥쪽 for문: 총 5줄 생성
        for (int i = 0; i <= 5; i++)
        {
            // 1st 안쪽 for문: 위에서부터 별이 1개에서 5개로 늘어남 (상단)
            for (int j = 0; j < i; j++)
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }

        // 2nd 안쪽 for문: 별이 4개에서 1개로 줄어듬 (하단)
        for (int i = 4; i >= 1; i--)
        {
            // 각 줄에 i개 만큼 별 추가 (4, 3, 2, 1개)
            for (int j = 0; j < i; j++)
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase4: 좌측 방향 삼각형 모양 별 출력
    public void Phase4()
    {
        star = string.Empty;

        // 상단 (별이 1개에서 5개로 늘어남)
        for (int i = 1; i <= 5; i++)
        {
            // 위에서부터 공백 4, 3, 2, 1, 0개 추가
            for (int j = 0; j < 5 - i; j++)
            {
                star += "　"; // 공백 추가
            }
            // 각 줄에 i개 만큼 별 추가 (1, 2, 3, 4, 5개)
            for (int k = 0; k < i; k++)
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }

        // 하단 (별이 4개에서 1개로 줄어듬)
        for (int i = 4; i >= 1; i--)
        {
            // 위에서부터 공백 1, 2, 3, 4개 추가
            for (int j = 0; j < 5 - i; j++)
            {
                star += "　"; // 공백 추가
            }
            // 각 줄에 i개 만큼 별 추가 (4, 3, 2, 1개)
            for (int k = 0; k < i; k++)
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase5: 다이아몬드 모양 별 출력
    public void Phase5()
    {
        star = string.Empty;

        // 상단 피라미드 (Phase3이랑 동...일?)
        // 바깥쪽 for문: 총 5줄 생성
        for (int i = 0; i < 5; i++)
        {
            // 공백 추가
            for (int j = 0; j < 4 - i; j++)
            {
                star += "　"; // 공백 추가
            }

            // 별의 개수를 홀수로 설정 (1, 3, 5, 7, 9)
            for (int k = 0; k < (i * 2) + 1; k++) 
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }

            // 한 줄 완성 후 줄 바꿈
            star += "\n";
        }
        // 하단 피라미드 (Phase4 로직...유..사..????)
        // 바깥쪽 for문: 총 4줄 생성
        for (int i = 3; i >= 0; i--)
        {
            // 공백 추가
            for (int j = 0; j < 4 - i; j++)
            {
                star += ""; // 공백 추가
            }
            // 별 추가
            for (int k = 0; k < (i * 2) + 1; k++) 
            {
                star += "★"; // 강사님이 주신 별 특수문자 추가
            }
            star += "\n";
        }
        Debug.Log(star);
    }
}