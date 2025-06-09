using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using TMPro;    

public class UpDownGame : MonoBehaviour
{
    // UI ���
    [Header("UI ���")]
    public TMP_InputField userInputField; // ����� ���� �Է� �ʵ�
    public Button submitButton; // ���� ��ư
    public TextMeshProUGUI resultLogText; // ��� �α׸� ǥ���� �ؽ�Ʈ
    public TextMeshProUGUI tryCountText; // �õ� Ƚ���� ǥ���� �ؽ�Ʈ

    // ���� ���� ������
    private int targetNumber; // ����� �� ����  
    private int tryCount; // �õ� Ƚ��
    private bool isGameFinished; // ���� ���� ����
    private List<string> resultLogs; // ��� �α׸� ������ ����Ʈ

    // ������ ���۵� �� �ѹ��� ȣ��Ǵ� �Լ�
    private void Start()
    {
        // OnClick()�� ������ ���
        submitButton.onClick.AddListener(OnSubmitionButtonClicked);

        // ��� �α׸� ������ ����Ʈ �ʱ�ȭ
        resultLogs = new List<string>();

        // �� ���� ����
        StartNewGame();
    }

    void StartNewGame() 
    {
        // 1. 1���� 100 ������ ���� ���� ����
        targetNumber = Random.Range(1, 101);

        // 2. ���� �ʱ�ȭ
        tryCount = 0;
        isGameFinished = false;
        resultLogs.Clear(); // ���� ������ �α׸� �ʱ�ȭ

        // 3. UI �ʱ�ȭ
        userInputField.text = ""; // �Է� �ʵ� �ʱ�ȭ
        userInputField.interactable = true; // �Է� �ʵ� Ȱ��ȭ
        submitButton.interactable = true; // ���� ��ư Ȱ��ȭ  
        resultLogText.text = "1~100 ������ ���ڸ� ���纸����!";
        tryCountText.text = "�õ� Ƚ��: 0"; // �õ� Ƚ�� �ʱ�ȭ

        // ������ �ֿܼ� ���
        Debug.Log("����: " + targetNumber);
    }

    // ���� ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
    public void OnSubmitionButtonClicked() 
    {
        // ������ ������ ȣ��X
        if (isGameFinished) return;

        // �Է�â�� �ִ� �ؽ�Ʈ ��������
        string inputText = userInputField.text;

        // �Էµ� �ؽ�Ʈ�� ���ڷ� ��ȯ
        int guessNumber;
        if (!int.TryParse(inputText, out guessNumber) || guessNumber < 1 || guessNumber > 100) 
        {
            // ���ڷ� ��ȯ �����ϰų� ������ ��� ���
            resultLogText.text = "1���� 100 ������ ���ڸ� �Է��ϼ���!";
            return; // ��ȿ���� ���� �Է�
        }

        // �õ� Ƚ�� ���� +1
        tryCount++;
        tryCountText.text = $"�õ� Ƚ��: {tryCount}";

        // �÷��̾ �Է��� ���ڿ� ���� ��
        string currentLog;
        if (guessNumber > targetNumber) 
        {
            // �Է��� ���ڰ� ���亸�� ū ���
            currentLog = $"{guessNumber}��(��) ���亸�� Ů�ϴ�. �ٽ� �õ��ϼ���.";
        }

        else if (guessNumber < targetNumber) 
        {
            // �Է��� ���ڰ� ���亸�� ���� ���
            currentLog = $"{guessNumber}��(��) ���亸�� �۽��ϴ�. �ٽ� �õ��ϼ���.";
        }
        else 
        {
            // ������ ���� ���
            currentLog = $"�����մϴ�! {guessNumber}�� �����Դϴ�!";
            isGameFinished = true; // ���� ���� ���·� ����
            userInputField.interactable = false; // �Է� �ʵ� ��Ȱ��ȭ
            submitButton.interactable = false; // ���� ��ư ��Ȱ��ȭ
        }

        // ��� �α׿� ���� �õ� ��� �߰�
        resultLogs.Insert(0, currentLog); // �ֽ� ����� ���� ���� �߰�

        // ��� �α׸� UI�� ǥ��
        UpdateResultLogText();

        userInputField.text = ""; // �Է� �ʵ� �ʱ�ȭ
    }

    // resultLogs ����Ʈ�� �ִ� ��� �α׸� UI�� ǥ���ϴ� �Լ�
    void UpdateResultLogText() 
    {
        // ����Ʈ�� �ִ� ��� ���ڿ��� �� �پ� �� �ϳ��� ���ڿ��� ����
        resultLogText.text = string.Join("\n", resultLogs);

        // ������ ����Ǹ� ���� �޽��� �߰�!
        if (isGameFinished) 
        { 
            resultLogText.text += "\n������ ����Ǿ����ϴ�! \n<b>{tryCount}�� ���� ���߼̽��ϴ�! �� ������ �����Ϸ��� �ٽ� ���� ��ư�� �����ּ���.";
        }
    }

}
