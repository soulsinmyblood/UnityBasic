using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private string name = "������";// �̸�
    private int age = 18; // ����
    private float height = 1.66f; // Ű
    private bool isStudent = true; // �л� ����
    private string[] hobbies = { "����", "����", "��ȭ ����" }; // ���
    private List<string> friends = new List<string> { "�ο���", "������", "���δ�", "�μ���" }; // ģ�� ���
    private Dictionary<string, int> scores = new Dictionary<string, int> // ���� ����
    {
        { "���� ��ȹ", 95 },
        { "������ ��ȹ", 90 },
        { "�ý��� ��ȹ", 85 }
    };
    private enum GameGenre // ���� �帣�� �����ϴ� ������
    {
        Soulslike,
        Adventure,
        Metroidvania,
        Simulation,
        Rhythm
    }
    private string school = "���ϰ���IT��ī����"; // �б� �̸�
    private string major = "����Ʈ 2�� ��ȹ��"; // ����
    private string studentId = "60"; // ����
    private string steamId = "76561199534729810"; // ���� ���̵�
    private string game = "Lies of P"; // �����ϴ� ����
    private string favoriteFood = "ī�̼���"; // �����ϴ� ����
    private string favoriteColor = "���̺�"; // �����ϴ� ��
    private string favoriteMusic = "Pop"; // �����ϴ� ���� �帣
    private int favoriteNumber = 7; // �����ϴ� ����
    private int numberOfPets = 0; // �ݷ������� ��

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction(); // �⺻ �ڱ�Ұ� ȣ��
    }

    void SelfIntroduction()
    {
        Debug.Log($"�ȳ��ϼ���, �� �̸��� {name}�Դϴ�. ���̴� {age}���̰�, Ű�� {height}m�Դϴ�. �л� ���δ� {isStudent}�Դϴ�.");
        Debug.Log($"��̴� {string.Join(", ", hobbies)}�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {favoriteFood}�Դϴ�. �����ϴ� ���� {favoriteColor}�̰�, �����ϴ� ���� �帣�� {favoriteMusic}�̸�.  �����ϴ� ���ڴ� {favoriteNumber}�Դϴ�.");
        Debug.Log($"�� ģ���� {string.Join(", ", friends)}�̽ʴϴ�. (����Ī)");
        Debug.Log($"���� �� �ݷ������� ���� {numberOfPets} �Դϴ�. ���� �ݷ����� �����.");
        Debug.Log($"���ݱ��� ������ ����: ���� ��ȹ {scores["���� ��ȹ"]}��, ������ ��ȹ {scores["������ ��ȹ"]}��, �ý��� ��ȹ {scores["�ý��� ��ȹ"]}��. (�̸� ���ڴٴ� ��)");
        Debug.Log($"���� {school}���� ���� ��ȹ�� ���� �ֽ��ϴ�. ���� ���� ���� {major}�̸�, �� ������ {studentId}�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {game}�Դϴ�. �� ���� �帣�� ���� �����ϴ� {GameGenre.Soulslike}�Դϴ�. ���� ģ�ߴ� �����: {steamId}!");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
