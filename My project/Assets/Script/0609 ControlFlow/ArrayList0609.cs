using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ArrayList0609 : MonoBehaviour
{
    string[] Character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "��ä��", "������", "������" };
    List<string> CharacterList = new List<string>();

    void Start()
    {
        CharacterList.Add("������");
        CharacterList.Add("���ѳ�");
        CharacterList.Add("�ռ���");
        CharacterList.Add("����ȣ");
        CharacterList.Add("������");
        CharacterList.Add("��ä��");
        CharacterList.Add("������");
        CharacterList.Add("������");

        ArrayGacha(); // Start �Լ����� ArrayGacha �Լ��� ȣ���Ͽ� ĳ���͸� �̴´�.
    }

    public void ArrayGacha()
    { 
        int randomValue = Random.Range(0, Character.Length); // 0�̻� Character.Length �̸��� ������ ���� �޾� ���ڴ�. = 0~7����!
        Debug.Log("��� Ȯ��"); // ��� Ȯ�ο� �α�
        Debug.Log(Character[randomValue] + "��(��) �̾Ҵ�!"); // �������� ���� ĳ���͸� ����Ѵ�.
    }

}
