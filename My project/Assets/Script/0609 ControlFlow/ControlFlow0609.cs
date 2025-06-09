using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow0609 : MonoBehaviour
{
    int count;
    private void Awake()
    {
        
        count = 0; // 초기화
    }
    /*int count;

    private void Awake()
    {
        count = 0;
    }*/

    void Start()
    {
        for(int i = 0; i < 11; i++) // 0부터 10까지 반복
        {
            count++; // count를 1씩 증가시킨다.
            Debug.Log($"현재 count: {count}"); // 현재 count 값을 출력한다.


        }
    }

    /*public void GachaSwitchByProbability()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'모나'을 뽑았다!");
        }
        else
        {
            Debug.Log("'치치'를 뽑아버렸다!");
        }



        switch(randomValue)
            {
            case int n when (n <= 10): // 1 ~ 10 -> 10%
                Debug.Log("'각청'을 뽑았다!");
                break;
            case int n when (n <= 30): // 11 ~ 30
                Debug.Log("'모나'을 뽑았다!");
                break;
            default: // 나머지 70% 확률로 '치치'를 뽑아버렸다!
                Debug.Log("'치치'를 뽑아버렸다!");
                break;
        }
    }*/

    public int selectNumber = 0; // 0 ~ 3 까지의 숫자를 선택할 수 있다.
    public void GachaSwitchBySelection()
    {
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100)
        Debug.Log($"Switch로 가챠를 돌린다!");

        switch (selectNumber) // 0
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    Debug.Log("'은색 머리'을 뽑았다!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }*/
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    Debug.Log("'파란 머리'을 뽑았다!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }*/
                }
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    Debug.Log("'분홍 머리'을 뽑았다!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }*/
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }*/
                }
                break;
        }
    }

    public void Gotcha()
    {
        int number = 0;

        while (number < 5)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log("랜덤한 값은: {randomValue}입니다");

            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("모나를 뽑았다");
    
        }
            else if (randomValue <= 30)
            {
                Debug.Log("치치를 뽑았다");
    
        }

            count++;
            number++;
        }
    }

}