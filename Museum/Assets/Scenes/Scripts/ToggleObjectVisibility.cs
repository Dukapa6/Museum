using UnityEngine;
using UnityEngine.UI;

public class ToggleObjectVisibility : MonoBehaviour
{
    // Объект, который будет скрываться или показываться
    public GameObject targetObject;

    // Кнопка для переключения
    public Button toggleButton;

    private void Start()
    {
        // Убедимся, что кнопка назначена
        if (toggleButton != null && targetObject != null)
        {
            // Привязываем метод ToggleVisibility к кнопке
            toggleButton.onClick.AddListener(ToggleVisibility);
        }
        else
        {
            Debug.LogError("Не назначен targetObject или toggleButton в инспекторе!");
        }
    }

    private void ToggleVisibility()
    {
        // Проверяем, есть ли целевой объект
        if (targetObject != null)
        {
            // Меняем активное состояние объекта
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}