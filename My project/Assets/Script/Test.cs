using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour // MonoBehaviour�� ��Ƽ�Ͽ��� �����ϱ� ���� ���� ģ��!
{
    int playuerLevel = 10; // �÷��̾� ������ �����ϴ� �����Դϴ�.

    // Start is called before the first frame update
    void Start()
    {
        // ����Ƽ���� ������ �� ȣ��Ǵ� �Լ��Դϴ�.
        Debug.Log("���� ������" + playuerLevel +"�Դϴ�.");
        Debug.Log($"���� ������ {playuerLevel}�Դϴ�."); // C# 6.0���� �����ϴ� ���ڿ� �������Դϴ�.
    }


}
