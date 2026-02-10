namespace OOP2.src;

public class HashtableEventListener
{
    private TextBox _textBox;
    
    public HashtableEventListener(HousingDepartmentHashtable hashtable, TextBox textBox)
    {
        this._textBox = textBox;
        hashtable.ItemAdded += (message) => { this._textBox.Text += message; };
        hashtable.ItemRemoved += (message) => { this._textBox.Text += message; };
    }
}