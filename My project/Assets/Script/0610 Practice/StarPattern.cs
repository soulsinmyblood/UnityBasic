using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPattern : MonoBehaviour
{
    // ���� ����
    string star;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("��ũ��Ʈ ���� �׽�Ʈ");

        // ������� ȣ���� �Լ���
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    // �� ����� ����ϴ� �Լ���
    // Phase1: �����ﰢ�� ��� �� ���
    public void Phase1()
    {
        // star ������ �� ���ڿ��� �ʱ�ȭ
        star = string.Empty;

        // �ٱ��� for��: �� 5�� ����
        for (int i = 0; i < 5; i++)
        {
            // ���� for��: �� �ٿ� �� ����(column)�� �߰�
            // ���� �� ��ȣ i�� +1 ��ŭ �� ���...? (ù �� 1��, ��° �� 2��, ...)
            for (int j = 0; j <= i; j++)
            {
                star += "��";
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }

        Debug.Log(star);
    }

    // Phase2: �������ﰢ�� ��� �� ���
    public void Phase2()
    {
        // star ������ �� ���ڿ��� �ʱ�ȭ
        star = string.Empty;

        // �ٱ��� for��: �� 5�� ����
        for (int i = 5; i > 0; i--)
        {
            // ���� for��: �� �ٿ� �� ����(column)�� �߰�
            // ���� �� ��ȣ i�� +1 ��ŭ �� ���...? (ù �� 5��, ��° �� 4��, ...)
            for (int j = 0; j < i; j++)
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase3: ���� ���� �ﰢ�� ��� �� ���
    public void Phase3()
    {
        star = string.Empty;

        // �ٱ��� for��: �� 5�� ����
        for (int i = 0; i <= 5; i++)
        {
            // 1st ���� for��: ���������� ���� 1������ 5���� �þ (���)
            for (int j = 0; j < i; j++)
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }

        // 2nd ���� for��: ���� 4������ 1���� �پ�� (�ϴ�)
        for (int i = 4; i >= 1; i--)
        {
            // �� �ٿ� i�� ��ŭ �� �߰� (4, 3, 2, 1��)
            for (int j = 0; j < i; j++)
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase4: ���� ���� �ﰢ�� ��� �� ���
    public void Phase4()
    {
        star = string.Empty;

        // ��� (���� 1������ 5���� �þ)
        for (int i = 1; i <= 5; i++)
        {
            // ���������� ���� 4, 3, 2, 1, 0�� �߰�
            for (int j = 0; j < 5 - i; j++)
            {
                star += "��"; // ���� �߰�
            }
            // �� �ٿ� i�� ��ŭ �� �߰� (1, 2, 3, 4, 5��)
            for (int k = 0; k < i; k++)
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }

        // �ϴ� (���� 4������ 1���� �پ��)
        for (int i = 4; i >= 1; i--)
        {
            // ���������� ���� 1, 2, 3, 4�� �߰�
            for (int j = 0; j < 5 - i; j++)
            {
                star += "��"; // ���� �߰�
            }
            // �� �ٿ� i�� ��ŭ �� �߰� (4, 3, 2, 1��)
            for (int k = 0; k < i; k++)
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }
        Debug.Log(star);
    }

    // Phase5: ���̾Ƹ�� ��� �� ���
    public void Phase5()
    {
        star = string.Empty;

        // ��� �Ƕ�̵� (Phase3�̶� ��...��?)
        // �ٱ��� for��: �� 5�� ����
        for (int i = 0; i < 5; i++)
        {
            // ���� �߰�
            for (int j = 0; j < 4 - i; j++)
            {
                star += "��"; // ���� �߰�
            }

            // ���� ������ Ȧ���� ���� (1, 3, 5, 7, 9)
            for (int k = 0; k < (i * 2) + 1; k++) 
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }

            // �� �� �ϼ� �� �� �ٲ�
            star += "\n";
        }
        // �ϴ� �Ƕ�̵� (Phase4 ����...��..��..????)
        // �ٱ��� for��: �� 4�� ����
        for (int i = 3; i >= 0; i--)
        {
            // ���� �߰�
            for (int j = 0; j < 4 - i; j++)
            {
                star += ""; // ���� �߰�
            }
            // �� �߰�
            for (int k = 0; k < (i * 2) + 1; k++) 
            {
                star += "��"; // ������� �ֽ� �� Ư������ �߰�
            }
            star += "\n";
        }
        Debug.Log(star);
    }
}