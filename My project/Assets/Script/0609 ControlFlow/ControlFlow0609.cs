using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow0609 : MonoBehaviour
{
    int count;
    private void Awake()
    {
        
        count = 0; // �ʱ�ȭ
    }
    /*int count;

    private void Awake()
    {
        count = 0;
    }*/

    void Start()
    {
        for(int i = 0; i < 11; i++) // 0���� 10���� �ݺ�
        {
            count++; // count�� 1�� ������Ų��.
            Debug.Log($"���� count: {count}"); // ���� count ���� ����Ѵ�.


        }
    }

    /*public void GachaSwitchByProbability()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }



        switch(randomValue)
            {
            case int n when (n <= 10): // 1 ~ 10 -> 10%
                Debug.Log("'��û'�� �̾Ҵ�!");
                break;
            case int n when (n <= 30): // 11 ~ 30
                Debug.Log("'��'�� �̾Ҵ�!");
                break;
            default: // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                break;
        }
    }*/

    public int selectNumber = 0; // 0 ~ 3 ������ ���ڸ� ������ �� �ִ�.
    public void GachaSwitchBySelection()
    {
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100)
        Debug.Log($"Switch�� ��í�� ������!");

        switch (selectNumber) // 0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }*/
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }*/
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }*/
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    /*if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
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

            Debug.Log("������ ����: {randomValue}�Դϴ�");

            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("�𳪸� �̾Ҵ�");
    
        }
            else if (randomValue <= 30)
            {
                Debug.Log("ġġ�� �̾Ҵ�");
    
        }

            count++;
            number++;
        }
    }

}