using UnityEngine.UI;
using UnityEngine;

public class PinCodeInput : MonoBehaviour
{
    private string enteredPin = "";
    public string correctPinCode = "1234"; // ���������� PIN-���
    public Text displayText; // ��������� ���� ��� ����������� ���������� PIN-����

    void Update()
    {
        // ��������� ������� ������ �� 0 �� 9
        for (int i = 0; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                EnterDigit(i.ToString());
            }
        }

        // ��������� ������� ������� Enter ��� ������������� �����
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckPin();
        }

        // ��������� ������� ������� Backspace ��� �������� ���������� �������
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            RemoveLastDigit();
        }
    }

    void EnterDigit(string digit)
    {
        enteredPin += digit;
        UpdateDisplayText();
    }

    void CheckPin()
    {
        if (enteredPin == correctPinCode)
        {
            Debug.Log("PIN-��� ����������!");
            // ����� ����� �������� �������������� ������ ��� ��������� �����
        }
        else
        {
            Debug.Log("�������� PIN-���.");
            // ����� ����� �������� �������������� ������ ��� ��������� �����
        }

        // ������� ��������� PIN-��� ����� ��������
        enteredPin = "";
        UpdateDisplayText();
    }

    void RemoveLastDigit()
    {
        if (enteredPin.Length > 0)
        {
            enteredPin = enteredPin.Substring(0, enteredPin.Length - 1);
            UpdateDisplayText();
        }
    }

    void UpdateDisplayText()
    {
        // ��������� ��������� ����, ��������� ������ ������� '*'
        displayText.text = new string('*', enteredPin.Length);
    }
}