using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System.Collections;
using System.Collections.Generic;

// [System.Serializable]
[System.Serializable]
public class Character
{
    public string characterName;
    public Sprite characterImage; 
}

public class Practice0609 : MonoBehaviour
{
    // �ν����� â���� ������ ��� ĳ������ ���
    public List<Character> characterPool = new List<Character>();

    // UI ���
    [Header("UI Elements")]
    public Image characterImageUI;      // ���� ĳ���� �̹����� ǥ���� UI Image
    public TextMeshProUGUI characterNameUI; // ���� ĳ���� �̸��� ǥ���� UI TextMeshPro
    public Button gachaButton;          // �̱⸦ ������ UI Button

    // �ý��� ���� ����
    private bool isGachaActive = false; // ���� �̱Ⱑ ���� ������ Ȯ�� (�ߺ� Ŭ�� ����)

    void Start()
    {
        // �ʱ� ����
        // ��ư�� ������ �� OnGachaButtonPressed �Լ��� ����ǵ��� ����
        if (gachaButton != null)
        {
            gachaButton.onClick.AddListener(OnGachaButtonPressed);
        }

        // ó������ �̹����� �ؽ�Ʈ�� �ʱ� ���·� ����
        if (characterImageUI != null)
        {
            characterImageUI.gameObject.SetActive(false); // ó���� �̹��� �����
        }
        if (characterNameUI != null)
        {
            characterNameUI.text = "��ư�� ���� �̱⸦ �����ϼ���!";
        }
    }

    
    // �̱� ��ư�� ������ �� ȣ��Ǵ� �Լ�
    public void OnGachaButtonPressed()
    {
        if (!isGachaActive && characterPool.Count > 0)
        {
            // �ڷ�ƾ�� ����Ͽ� 10���� �̱� ����
            StartCoroutine(PerformTenPull());
        }
        else if (characterPool.Count == 0)
        {
            Debug.LogError("ĳ���� Ǯ(Character Pool)�� ĳ���Ͱ� �����ϴ�! �ν����Ϳ��� ĳ���͸� �߰����ּ���.");
            characterNameUI.text = "���� �� �ִ� ĳ���Ͱ� �����ϴ�.";
        }
    }

    // 10���� �̱⸦ ���������� �����ְ� �������� ����� ����ϴ� �ڷ�ƾ
    private IEnumerator PerformTenPull()
    {
        isGachaActive = true; // ���¸� '�̱� ���� ��'���� ����
        gachaButton.interactable = false; // �̱� �߿��� ��ư ��Ȱ��ȭ
        characterImageUI.gameObject.SetActive(true); // �̹��� ǥ�� ���� Ȱ��ȭ

        // ���� ĳ������ �̸��� Ƚ���� ����� Dictionary ����
        Dictionary<string, int> gachaResults = new Dictionary<string, int>();

        Debug.Log("====10���� �̱⸦ �����մϴ�!====");

        // 10�� �ݺ�
        for (int i = 0; i < 10; i++)
        {
            // 1. ĳ���� Ǯ���� �������� ĳ���� �ϳ� ����
            int randomIndex = Random.Range(0, characterPool.Count);
            Character drawnCharacter = characterPool[randomIndex];

            // 2. UI ������Ʈ
            characterImageUI.sprite = drawnCharacter.characterImage;
            characterNameUI.text = drawnCharacter.characterName;

            // 3. �ֿܼ� ��� ���
            Debug.Log($"[{i + 1}/10] \"{drawnCharacter.characterName}\"��(��) �̾ҽ��ϴ�!");

            // 4. ��� ����ϱ�
            if (gachaResults.ContainsKey(drawnCharacter.characterName))
            {
                gachaResults[drawnCharacter.characterName]++; // �̹� ���� �� ������ Ƚ�� ����
            }
            else
            {
                gachaResults.Add(drawnCharacter.characterName, 1); // ó�� �������� ���� �߰�
            }

            // 5. ���� ĳ���͸� �����ֱ� �� ��� ��� (1��)
            yield return new WaitForSeconds(1f);
        }

        Debug.Log("====10���� �̱� �Ϸ�!====");

        // ���� ��� ���� �� ���
        // StringBuilder�� ����Ͽ� ���� ���� ���ڿ� ����
        System.Text.StringBuilder resultTextBuilder = new System.Text.StringBuilder();
        resultTextBuilder.AppendLine("<b>--- �̱� ��� ��� ---</b>"); 

        foreach (KeyValuePair<string, int> result in gachaResults)
        {
            resultTextBuilder.AppendLine($"{result.Key} x{result.Value}");
        }

        // ���� ����� �ְܼ� UI Text�� ǥ��
        Debug.Log(resultTextBuilder.ToString());
        characterNameUI.text = resultTextBuilder.ToString();

        // �̱� �Ϸ� �� ���� ����
        isGachaActive = false; // ���¸� '��� ��'���� ����
        gachaButton.interactable = true; // ��ư �ٽ� Ȱ��ȭ
    }
}
