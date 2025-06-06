using UnityEngine;
using UnityEngine.UI; // Button �� InputField Ŭ������ ����ϱ� ���� �ʿ��մϴ�.
using TMPro;          // TextMeshProUGUI Ŭ������ ����ϱ� ���� �ʿ��մϴ�.

public class InputDisplayManager : MonoBehaviour
{
    [Header("UI ��� ����")]
    public TMP_InputField inputField;    // �ν����Ϳ��� ����� �Է��� ���� InputField (TextMeshPro ����)�� �����մϴ�.
    public Button displayButton;         // �ν����Ϳ��� Ŭ�� �̺�Ʈ�� �߻���ų Button�� �����մϴ�.
    public TextMeshProUGUI outputText;   // �ν����Ϳ��� ����� ǥ���� TextMeshPro - Text UI ��Ҹ� �����մϴ�.

    void Start()
    {
        // 1. ��ư�� �Ҵ�Ǿ����� Ȯ���ϰ� Ŭ�� �����ʸ� �߰��մϴ�.
        if (displayButton != null)
        {
            // displayButton�� Ŭ���Ǹ� UpdateOutputText �Լ��� ȣ���ϵ��� �����մϴ�.
            displayButton.onClick.AddListener(UpdateOutputText);
        }
        else
        {
            Debug.LogError("Display Button�� InputDisplayManager ��ũ��Ʈ�� ������� �ʾҽ��ϴ�!");
        }

        // 2. InputField�� OutputText�� �Ҵ�Ǿ����� Ȯ���մϴ�.
        if (inputField == null)
        {
            Debug.LogError("Input Field�� InputDisplayManager ��ũ��Ʈ�� ������� �ʾҽ��ϴ�!");
        }

        if (outputText == null)
        {
            Debug.LogError("Output Text (TextMeshPro)�� InputDisplayManager ��ũ��Ʈ�� ������� �ʾҽ��ϴ�!");
        }
        else
        {
            // 3. ���� �� OutputText�� ����Ӵϴ� (���� ����).
            outputText.text = "��ư�� ���� �Է� ������ ǥ���ϼ���...";
        }
    }

    // ��ư Ŭ�� �� ȣ��� �Լ�
    void UpdateOutputText()
    {
        if (inputField != null && outputText != null)
        {
            // InputField�� ���� �ؽ�Ʈ ���� ������ OutputText�� �����մϴ�.
            outputText.text = inputField.text;
            Debug.Log($"�Էµ� ����: {inputField.text} (��)�� TextMeshPro�� ǥ�õǾ����ϴ�.");
        }
        else
        {
            Debug.LogWarning("InputField �Ǵ� OutputText�� ����� ������� �ʾ� �ؽ�Ʈ�� ������Ʈ�� �� �����ϴ�.");
        }

        // (���� ����) �ؽ�Ʈ�� ǥ���� �� InputField ������ ��� �� �ֽ��ϴ�.
        // if (inputField != null)
        // {
        //     inputField.text = "";
        // }
    }

    // (����) OnDestroy�� ��ũ��Ʈ�� �ı��� �� ȣ��˴ϴ�.
    // AddListener�� ����� �̺�Ʈ�� �޸� ������ �����ϱ� ���� �������ִ� ���� �����ϴ�.
    void OnDestroy()
    {
        if (displayButton != null)
        {
            displayButton.onClick.RemoveListener(UpdateOutputText);
        }
    }
}
