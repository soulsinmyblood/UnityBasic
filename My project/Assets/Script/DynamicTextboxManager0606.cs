using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DynamicTextboxManager : MonoBehaviour
{
    [Header("UI ��� ����")]
    public TMP_InputField messageInput;   // ����� �Է��� ���� InputField
    public TextMeshProUGUI messageText; // ��ǳ�� �ȿ� ǥ�õ� TextMeshPro UI
    public Button sendButton;             // �޽��� ����(������Ʈ) ��ư

    void Start()
    {
        // ��ư�� �Ҵ�Ǿ� �ְ�, Ŭ�� �̺�Ʈ�� �Լ� ���
        if (sendButton != null)
        {
            sendButton.onClick.AddListener(UpdateMessage);
        }
        else
        {
            Debug.LogError("Send Button�� ��ũ��Ʈ�� ������� �ʾҽ��ϴ�.");
        }

        // ��ȿ�� �˻�
        if (messageInput == null)
        {
            Debug.LogError("Message Input Field�� ��ũ��Ʈ�� ������� �ʾҽ��ϴ�.");
        }
        if (messageText == null)
        {
            Debug.LogError("Message Text (TextMeshPro)�� ��ũ��Ʈ�� ������� �ʾҽ��ϴ�.");
        }
        else
        {
            // ���� ���� �� �ʱ� �ؽ�Ʈ ����
            messageText.text = "��ǳ�� ũ�Ⱑ �ؽ�Ʈ ���̿� ���� �ڵ����� �����˴ϴ�.";
        }
    }

    /// <summary>
    /// ��ư Ŭ�� �� ȣ��Ǿ� InputField�� ������ TextMeshPro�� ������Ʈ�ϴ� �Լ�
    /// </summary>
    private void UpdateMessage()
    {
        // InputField�� ������� ���� ��쿡�� �ؽ�Ʈ�� ������Ʈ�մϴ�.
        if (messageInput != null && !string.IsNullOrEmpty(messageInput.text))
        {
            messageText.text = messageInput.text;

            // ���� �� �Է� �ʵ带 ���ϴ�.
            messageInput.text = "";

            // �Է� �ʵ带 �ٽ� Ȱ��ȭ�Ͽ� �ٷ� ���� �Է��� �� �� �ֵ��� �մϴ� (���� ����).
            messageInput.ActivateInputField();
        }
    }

    /// <summary>
    /// ��ũ��Ʈ�� �ı��� �� ��ϵ� �����ʸ� �����Ͽ� �޸� ������ �����մϴ�.
    /// </summary>
    void OnDestroy()
    {
        if (sendButton != null)
        {
            sendButton.onClick.RemoveListener(UpdateMessage);
        }
    }
}
