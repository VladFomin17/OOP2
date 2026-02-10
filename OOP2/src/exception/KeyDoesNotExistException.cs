namespace OOP2.src.exception;

public class KeyDoesNotExistException : Exception
{
    public KeyDoesNotExistException(int key)
        : base($"Элемент с ключом {key} не найден.")
    {
    }
}