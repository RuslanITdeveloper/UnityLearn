using UnityEngine;

public class Batut : MonoBehaviour
{
    // Событие, которое срабатывает после входа в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Увеличивает силу прыжка до 10
        other.gameObject.GetComponent<Jump>().jumpStrength = 10;
    }

    // Событие, которое срабатывает после выхода из триггера
    private void OnTriggerExit(Collider other)
    {
        // Уменьшает силу прыжка до 2
        other.gameObject.GetComponent<Jump>().jumpStrength = 2;
    }
}
