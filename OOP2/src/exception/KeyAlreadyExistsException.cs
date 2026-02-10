namespace OOP2.src.exception;

public class KeyAlreadyExistsException : Exception
{
    public KeyAlreadyExistsException(int key)
        : base($"Элемент с ключом {key} уже существует.")
    {
    }
}