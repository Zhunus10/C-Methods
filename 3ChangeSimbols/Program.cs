// replace "space" to "hyphens", "A" to "a", "T" to "t"

string text = "As thou art to thyself:"
+ "Such was the very armour he had on "
+ "When he the ambitious Norway combated;"
+"So frown'd he once, when, in an angry parle,"
+"He smote the sledded Polacks on the ice.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for ( int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}    

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 't', 'T');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'a', 'A');
Console.WriteLine(newText);


