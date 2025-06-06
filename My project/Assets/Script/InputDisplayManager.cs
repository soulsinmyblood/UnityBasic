using UnityEngine;
using UnityEngine.UI; // Button 및 InputField 클래스를 사용하기 위해 필요합니다.
using TMPro;          // TextMeshProUGUI 클래스를 사용하기 위해 필요합니다.

public class InputDisplayManager : MonoBehaviour
{
    [Header("UI 요소 연결")]
    public TMP_InputField inputField;    // 인스펙터에서 사용자 입력을 받을 InputField (TextMeshPro 버전)를 연결합니다.
    public Button displayButton;         // 인스펙터에서 클릭 이벤트를 발생시킬 Button을 연결합니다.
    public TextMeshProUGUI outputText;   // 인스펙터에서 결과를 표시할 TextMeshPro - Text UI 요소를 연결합니다.

    void Start()
    {
        // 1. 버튼이 할당되었는지 확인하고 클릭 리스너를 추가합니다.
        if (displayButton != null)
        {
            // displayButton이 클릭되면 UpdateOutputText 함수를 호출하도록 설정합니다.
            displayButton.onClick.AddListener(UpdateOutputText);
        }
        else
        {
            Debug.LogError("Display Button이 InputDisplayManager 스크립트에 연결되지 않았습니다!");
        }

        // 2. InputField와 OutputText가 할당되었는지 확인합니다.
        if (inputField == null)
        {
            Debug.LogError("Input Field가 InputDisplayManager 스크립트에 연결되지 않았습니다!");
        }

        if (outputText == null)
        {
            Debug.LogError("Output Text (TextMeshPro)가 InputDisplayManager 스크립트에 연결되지 않았습니다!");
        }
        else
        {
            // 3. 시작 시 OutputText를 비워둡니다 (선택 사항).
            outputText.text = "버튼을 눌러 입력 내용을 표시하세요...";
        }
    }

    // 버튼 클릭 시 호출될 함수
    void UpdateOutputText()
    {
        if (inputField != null && outputText != null)
        {
            // InputField의 현재 텍스트 값을 가져와 OutputText에 설정합니다.
            outputText.text = inputField.text;
            Debug.Log($"입력된 내용: {inputField.text} (이)가 TextMeshPro에 표시되었습니다.");
        }
        else
        {
            Debug.LogWarning("InputField 또는 OutputText가 제대로 연결되지 않아 텍스트를 업데이트할 수 없습니다.");
        }

        // (선택 사항) 텍스트를 표시한 후 InputField 내용을 비울 수 있습니다.
        // if (inputField != null)
        // {
        //     inputField.text = "";
        // }
    }

    // (참고) OnDestroy는 스크립트가 파괴될 때 호출됩니다.
    // AddListener로 등록한 이벤트는 메모리 누수를 방지하기 위해 제거해주는 것이 좋습니다.
    void OnDestroy()
    {
        if (displayButton != null)
        {
            displayButton.onClick.RemoveListener(UpdateOutputText);
        }
    }
}
