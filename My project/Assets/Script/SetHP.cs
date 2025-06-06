using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    public Image Img_HPbar;
    public TextMeshProUGUI Txt_HP; // ���� HP ǥ�ÿ� �ؽ�Ʈ
    public TextMeshProUGUI Txt_Text; // ������/ȸ�� �޽��� ǥ�ÿ� �ؽ�Ʈ

    public int MaxHP = 100; // �ִ� HP ����
    public int Damage; // Ŭ���� ������
    public int HealPoint = 10; // Ŭ���� ȸ����

    private float nowHP; // ���� HP�� ������ ����

    void Awake() // ��� Start �ᵵ �ǳ���? -> �ȴ�!
    {
        nowHP = MaxHP;
        UpdateHPStatus(); // �ʱ� HP ���� ������Ʈ
        Initialized(); // ���� �ʱ�ȭ �� ���� HP�� �ִ� HP�� ����
    }

    void Initialized()
    {
        nowHP = MaxHP; // ���� �ʱ�ȭ �� ���� HP�� �ִ� HP�� ����
        UpdateHPStatus(); // �ʱ� HP ���� ������Ʈ
    }

    private void UpdateHPStatus() // HP ���� ������Ʈ �Լ�
    {
        // HP �� Image fillAmount ������Ʈ
        Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP�� ������Ʈ

        // ���� HP �ؽ�Ʈ ������Ʈ
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // ���� HP �ؽ�Ʈ ������Ʈ
    }

    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 21); // 5���� 20 ������ ���� ������ ����
        // HP Image fillAmnt ������Ʈ
        nowHP -= Damage; // �������� �޴´�
        if (nowHP < 0) // ���� ���� HP�� 0���� �۴ٸ� 0���� ����
        { 
            nowHP = 0; 
        }

        Txt_Text.text = $"{Damage}�� �������� �Ծ���."; // ������ �ؽ�Ʈ ������Ʈ
        UpdateHPStatus(); // HP ���� ������Ʈ
        Debug.Log($"������ {Damage} ����. ���� HP: {nowHP}"); // ���� HP ���
        //Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP�� ������Ʈ

    }

    public void OnClickHeal() // ȸ��
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        UpdateHPStatus(); // HP ���� ������Ʈ
        Debug.Log($"ȸ�� {HealPoint} ����. ���� HP: {nowHP}"); // ���� HP ���
        //Img_HPbar.fillAmount = (float)nowHP / MaxHP; // HP�� ������Ʈ
    }
}
