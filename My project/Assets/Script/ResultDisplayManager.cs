using UnityEngine;
using UnityEngine.UI; // UI ���� Ŭ���� ���

public class ResultDisplayManager : MonoBehaviour
{
    [Header("UI ��� ����")]
    public Button confirmResultButton; // �ν����Ϳ��� 'ConfirmResultButton' UI ��ư�� ����.
    public Image youDiedImage;       // �ν����Ϳ��� 'YouDied' UI �̹����� ����
    public Image victoryImage;       // �ν����Ϳ��� 'Victory' UI �̹����� ����

    private bool hasPlayerWon = false;

    void Start()
    {
        // 1. ���� �� ��� ��� �̹����� �����
        if (youDiedImage != null)
        {
            youDiedImage.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("YouDied �̹����� ResultDisplayManager ��ũ��Ʈ�� ������� ����!");
        }

        if (victoryImage != null)
        {
            victoryImage.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Victory �̹����� ResultDisplayManager ��ũ��Ʈ�� ������� ����!");
        }

        // 2. ��ư Ŭ�� �̺�Ʈ�� �Լ� ���
        if (confirmResultButton != null)
        {
            // ��ư�� Ŭ���Ǹ� ShowOutcome �Լ��� ȣ��
            confirmResultButton.onClick.AddListener(ShowOutcome);
        }
        else
        {
            Debug.LogError("ConfirmResultButton�� ResultDisplayManager ��ũ��Ʈ�� ������� ����!");
        }
    }

    // ���� ���¸� ����
    public void SetPlayerWinStatus(bool playerWins)
    {
        hasPlayerWon = playerWins;
    }

    // ��ư Ŭ�� �� ȣ��� �Լ�
    void ShowOutcome()
    {
        // ��� ��� �̹����� �ٽ� ���ܼ� �ߺ� ǥ�� ����
        if (youDiedImage != null) youDiedImage.gameObject.SetActive(false);
        if (victoryImage != null) victoryImage.gameObject.SetActive(false);
        SimulateRandomOutcomeOnClick(); // ��ư Ŭ�� �� ���� ��� ����

        if (hasPlayerWon)
        {
            if (victoryImage != null)
            {
                victoryImage.gameObject.SetActive(true);
                Debug.Log("�¸�! Victory �̹��� ǥ��.");
            }
        }
        else
        {
            if (youDiedImage != null)
            {
                youDiedImage.gameObject.SetActive(true);
                Debug.Log("�й�! YouDied �̹��� ǥ��.");
            }
        }

        // ����� ǥ�õ� �� ��ư�� ��Ȱ��ȭ
        //confirmResultButton.interactable = false;
    }

    private void SimulateRandomOutcomeOnClick()
    {
        hasPlayerWon = Random.Range(0, 2) == 0; // 0 �Ǵ� 1 �� ����, 0�̸� true (�¸�)
        if (hasPlayerWon)
        {
            Debug.Log("��� �ùķ��̼�: �¸�");
        }
        else
        {
            Debug.Log("��� �ùķ��̼�: �й�");
        }
    }









    //// (���� ����) ���� ������ ���� �ܺο��� ���� Ư�� ����� ǥ���ϰ� �ϴ� �Լ���
    //public void DisplayVictoryScreen()
    //{
    //    if (youDiedImage != null) youDiedImage.gameObject.SetActive(false);
    //    if (victoryImage != null) victoryImage.gameObject.SetActive(true);
    //    Debug.Log("Victory ȭ���� ���� ȣ��Ǿ� ǥ�õ˴ϴ�.");
    //}

    //public void DisplayYouDiedScreen()
    //{
    //    if (victoryImage != null) victoryImage.gameObject.SetActive(false);
    //    if (youDiedImage != null) youDiedImage.gameObject.SetActive(true);
    //    Debug.Log("YouDied ȭ���� ���� ȣ��Ǿ� ǥ�õ˴ϴ�.");
    //}
}
